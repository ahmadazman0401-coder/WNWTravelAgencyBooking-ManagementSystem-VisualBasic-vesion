Public Class Form1

    Public Shared userdestination As String
    Public Shared TravelDays As String
    Public Shared pax As String
    Public Shared aaccomodation As String
    Public Shared group As String
    Public Shared dates As String
    Public Shared SelectedSourceForm As String
    Public Shared adult As String
    Public Shared kid As String
    Public Shared elder As String
    Public Shared infant As String
    Public Shared choice As String
    Public Shared LoggedInUser As String

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click

        Dim nextForm As New Form2()
        nextForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnBookNow_Click_1(sender As Object, e As EventArgs) Handles btnBookNow.Click
        Dim nextForm As New Form2()
        nextForm.Show()
        Me.Hide()
    End Sub

End Class
