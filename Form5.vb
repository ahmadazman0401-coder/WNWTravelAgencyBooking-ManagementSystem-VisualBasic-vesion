Public Class Form5
    Private Sub rdbFamilyTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFamilyTrip.CheckedChanged
        If rdbFamilyTrip.Checked Then
            Dim seventhForm As New Form7()
            seventhForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub rdbAdventureTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAdventureTrip.CheckedChanged
        If rdbAdventureTrip.Checked Then
            Dim eightForm As New Form8()
            eightForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub rdbHoneymoonTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHoneymoonTrip.CheckedChanged
        If rdbHoneymoonTrip.Checked Then
            Dim ninthForm As New Form9()
            ninthForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub rdbCustomizeTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCustomizeTrip.CheckedChanged
        If rdbCustomizeTrip.Checked Then
            Dim sixthForm As New Form6()
            sixthForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim nextForm As New Form4()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class