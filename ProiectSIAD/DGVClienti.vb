Public Class DGVClienti

    Public Shared Sub Pop(g As DataGridView, cbo1 As ComboBox, cbo2 As ComboBox)

        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Master\ProiectSIAD\ProiectSIAD\VanzariMasini2.mdb")

        conn.Open()

        Dim DS As DataSet = New DataSet
        Dim DA As New OleDb.OleDbDataAdapter
        Dim sql As String


        sql = "SELECT nume, prenume FROM clienti WHERE " & cbo1.SelectedItem.ToString & " = '" & cbo2.SelectedItem.ToString & "';"

        DA.SelectCommand = New OleDb.OleDbCommand(sql, conn)
        DA.Fill(DS)
        g.DataSource = DS.Tables(0).DefaultView

        conn.Close()

    End Sub

End Class
