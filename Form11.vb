Public Class Form11
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim nextForm As New Form4()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAboutus_Click(sender As Object, e As EventArgs) Handles btnAboutus.Click
        Dim nextForm As New Form10()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtName.Text = "" Or txtEmail.Text = "" Or txtMessage.Text = "" Then
            MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
        Catch ex As Exception
            MessageBox.Show("Failed to send message: " & ex.Message)
        End Try

        MessageBox.Show("Message sent! We will contact you as soon as possible!",
                        "WNW Travel", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtMessage.Clear()

        Dim nextForm As New Form4()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowSuccessPopup()
        MessageBox.Show("Message sent! We will contact you as soon as possible!",
                        "WNW Travel", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtMessage.Clear()
    End Sub

End Class