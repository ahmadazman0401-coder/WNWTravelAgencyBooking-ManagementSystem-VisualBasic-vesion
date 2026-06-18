Public Class Form10
    Private Sub btnContactUs_Click(sender As Object, e As EventArgs) Handles btnContactUs.Click
        Dim nextForm As New Form11()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim nextForm As New Form4()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nextForm As New Form5()
        nextForm.Show()
        Me.Hide()
    End Sub
End Class