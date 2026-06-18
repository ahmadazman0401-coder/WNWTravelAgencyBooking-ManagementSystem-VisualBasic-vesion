
Public Class Form16
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim nextForm As New Form1()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim nextForm As New Form14()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Dim nextForm As New Form15()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim nextForm As New Form17()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub TblPackagesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblPackagesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblPackagesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wnw_travel_dbDataSet1)
    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblPackagesTableAdapter.Fill(Me.Wnw_travel_dbDataSet1.tblPackages)
    End Sub
End Class