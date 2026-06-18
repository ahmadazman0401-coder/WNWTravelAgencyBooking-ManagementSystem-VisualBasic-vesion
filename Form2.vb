Imports System.Data.OleDb

Public Class Form2
    Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\wnw_travel_db.accdb"

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Using conn As New OleDbConnection(connStr)
            Try
                conn.Open()

                Dim sql As String = "SELECT [UserType] FROM [tblUsers] WHERE [Username]=? AND [UserPassword]=?"
                Dim cmd As New OleDbCommand(sql, conn)

                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtUsername.Text.Trim()
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtPassword.Text.Trim()
                Dim userRole As Object = cmd.ExecuteScalar()

                If userRole IsNot Nothing Then
                    GlobalVariables.LoggedInUser = txtUsername.Text.Trim()
                    Dim role As String = userRole.ToString().Trim()

                    If role = "Admin" Then
                        MessageBox.Show("Welcome, Admin!")
                        Dim adminPanel As New Form14()
                        adminPanel.Show()
                    Else
                        MessageBox.Show("Login Successful!")
                        Dim userHome As New Form4()
                        userHome.Show()
                    End If
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Username or Password. Please check your entries.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim nextForm As New Form1()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim nextForm As New Form3()
        nextForm.Show()
        Me.Hide()
    End Sub
End Class