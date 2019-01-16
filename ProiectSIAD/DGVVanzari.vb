Public Class DGVVanzari

    Public Shared Sub Pop(g As DataGridView, z As String, ta As String)

        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Master\ProiectSIAD\ProiectSIAD\VanzariMasini2.mdb")

        conn.Open()

        Dim DSgrid As DataSet = New DataSet
        Dim DSchart As DataSet = New DataSet
        Dim DAgrid As New OleDb.OleDbDataAdapter
        Dim DAchart As New OleDb.OleDbDataAdapter
        Dim sql As String
        Dim sqlchart As String
        Dim tip As String = Vanzari.cboTipAuto.Text
        Dim zona As String = Vanzari.cboZone.Text.ToString
        Dim ds As String = Vanzari.dtp1.Value.Month & "/" & Vanzari.dtp1.Value.Day & "/" & Vanzari.dtp1.Value.Year
        Dim de As String = Vanzari.dtp2.Value.Month & "/" & Vanzari.dtp2.Value.Day & "/" & Vanzari.dtp2.Value.Year

        sqlchart = "SELECT masini.model, vanzari_2016.unitatiVandute " &
                   "From durata_timp INNER Join ((judete INNER Join showrooms On judete.[ID] = showrooms.[id_judet]) " &
                   "INNER Join (masini INNER Join vanzari_2016 On masini.[ID] = vanzari_2016.[id_masina]) ON showrooms.[ID] = vanzari_2016.[id_showroom]) ON durata_timp.ID = vanzari_2016.id_timp Where " &
                   "(((judete.judet) = '" & zona & "') And (durata_timp.[data] Between #" & ds & "# And #" & de & "#));"

        sql = "Select vanzari_2016.vanzariShowroom, vanzari_2016.unitatiVandute " &
            "FROM(judete INNER JOIN showrooms On judete.[ID] = showrooms.[id_judet])" &
            "INNER JOIN (masini INNER JOIN (durata_timp INNER JOIN vanzari_2016 On durata_timp.[ID] = vanzari_2016.[id_timp]) On masini.[ID] = vanzari_2016.[id_masina]) On showrooms.[ID] = vanzari_2016.[id_showroom] WHERE " &
            "(durata_timp.[data] Between #" & ds & "# And #" & de & "#) And (masini.[model]= '" & tip & "') And (judete.[judet] = '" & zona & "');"

        DAgrid.SelectCommand = New OleDb.OleDbCommand(sql, conn)
        DAgrid.Fill(DSgrid)
        g.DataSource = DSgrid.Tables(0).DefaultView

        conn.Close()

        DAchart.SelectCommand = New OleDb.OleDbCommand(sqlchart, conn)
        DAchart.Fill(DSchart)

        Vanzari.chVanzari.Series(0).Points.Clear()
        Vanzari.chVanzari.DataSource = DSchart.Tables(0).DefaultView
        Vanzari.chVanzari.Series(0).XValueMember = DSchart.Tables(0).Columns(0).ToString
        Vanzari.chVanzari.Series(0).YValueMembers = DSchart.Tables(0).Columns(1).ToString


        For i As Integer = 1 To DSchart.Tables(0).Rows.Count - 1
            For j As Integer = 1 To DSchart.Tables(0).Columns.Count - 1
                Vanzari.chVanzari.Series(0).Points.AddXY(DSchart.Tables(0).Rows(i).ToString, DSchart.Tables(0).Columns(j).ToString)
            Next
        Next

    End Sub

End Class
