Public Class Form4
    Private Sub btnContactUs_Click(sender As Object, e As EventArgs) Handles btnContactUs.Click
        Dim nextForm As New Form11()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim nextForm As New Form1()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAboutus_Click(sender As Object, e As EventArgs) Handles btnAboutus.Click
        Dim nextForm As New Form10()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        Dim nextForm As New Form5()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

