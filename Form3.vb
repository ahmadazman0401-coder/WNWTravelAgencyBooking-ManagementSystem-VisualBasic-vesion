
Imports System.Data.OleDb
Public Class Form3

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Dim username As String = txtUser.Text
        Dim password As String = txtPassword.Text
        Dim confirmPass As String = txtConfirmPassword.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhoneNum.Text
        Dim vCode As String = txtVerificationCode.Text


        If password <> confirmPass Then
            MessageBox.Show("Passwords do not match!")
            Return
        End If

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all required fields (Username and Password).")
            Return
        End If

        SaveUserToDatabase(username, password, email, phone, vCode)
    End Sub

    Private Sub SaveUserToDatabase(user As String, pass As String, mail As String, ph As String, code As String)
        ' Application.StartupPath points directly to bin\Debug folder
        Dim dbPath As String = Application.StartupPath & "\wnw_travel_db.accdb"
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath

        ' SQL Insert Statement
        Dim query As String = "INSERT INTO [tblUsers] ([Username], [UserPassword], [UserEmail], [UserPhoneNum]) VALUES (?, ?, ?, ?)"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)

                cmd.Parameters.AddWithValue("?", user)
                cmd.Parameters.AddWithValue("?", pass)
                cmd.Parameters.AddWithValue("?", mail)
                cmd.Parameters.AddWithValue("?", ph)
                cmd.Parameters.AddWithValue("?", code)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registration Successful!")
                    Dim nextForm As New Form2()
                    nextForm.Show()
                    Me.Hide()
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim nextForm As New Form1()
        nextForm.Show()
        Me.Hide()
    End Sub


End Class