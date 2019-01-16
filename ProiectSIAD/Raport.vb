Public Class Raport
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ComboBox2.Visible = True

        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Master\ProiectSIAD\ProiectSIAD\VanzariMasini2.mdb")

        conn.Open()

        Dim DS As New DataSet()
        Dim DA As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "Select DISTINCT " & ComboBox1.SelectedItem.ToString & " FROM clienti"

        DA.SelectCommand = New OleDb.OleDbCommand(sql, conn)

        DA.Fill(DS)
        ComboBox2.DataSource = DS.Tables(0).DefaultView
        ComboBox2.DisplayMember = ComboBox1.SelectedItem.ToString

        conn.Close()

    End Sub

    Private Sub Raport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VanzariMasini2DataSet.clienti' table. You can move, or remove it, as needed.
        Me.ClientiTableAdapter.Fill(Me.VanzariMasini2DataSet.clienti)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

        DGVClienti.Pop(dgvc, ComboBox1, ComboBox2)

    End Sub
End Class