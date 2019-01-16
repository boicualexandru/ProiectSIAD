Public Class Vanzari
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub cboZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZone.SelectedIndexChanged

        DGVVanzari.Pop(grid, cboZone.SelectedText, cboTipAuto.SelectedText)

    End Sub

    Private Sub cboTipAuto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipAuto.SelectedIndexChanged

        DGVVanzari.Pop(grid, cboZone.SelectedText, cboTipAuto.SelectedText)

    End Sub

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged

        DGVVanzari.Pop(grid, cboZone.SelectedText, cboTipAuto.SelectedText)

    End Sub

    Private Sub dtp2_ValueChanged(sender As Object, e As EventArgs) Handles dtp2.ValueChanged

        DGVVanzari.Pop(grid, cboZone.SelectedText, cboTipAuto.SelectedText)

    End Sub

    Private Sub Vanzari_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'VanzariMasini2DataSet.masini' table. You can move, or remove it, as needed.
        Me.MasiniTableAdapter.Fill(Me.VanzariMasini2DataSet.masini)
        'TODO: This line of code loads data into the 'VanzariMasini2DataSet.judete' table. You can move, or remove it, as needed.
        Me.JudeteTableAdapter.Fill(Me.VanzariMasini2DataSet.judete)

        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Master\ProiectSIAD\ProiectSIAD\VanzariMasini2.mdb")
        Dim DSzona As New DataSet()
        Dim DAzona As New OleDb.OleDbDataAdapter("Select DISTINCT judet FROM judete", conn)

        Dim DStip As New DataSet()
        Dim DAtip As New OleDb.OleDbDataAdapter("Select DISTINCT model FROM masini", conn)

        conn.Open()

        DAzona.Fill(DSzona)
        cboZone.DataSource = DSzona.Tables(0).DefaultView

        DAtip.Fill(DStip)
        cboTipAuto.DataSource = DStip.Tables(0).DefaultView

        conn.Close()

    End Sub
End Class