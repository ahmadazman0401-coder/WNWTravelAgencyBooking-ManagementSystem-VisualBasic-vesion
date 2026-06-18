Imports System.Data.OleDb
Public Class Form17
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

    Private Sub btnPackages_Click(sender As Object, e As EventArgs) Handles btnPackages.Click
        Dim nextForm As New Form16()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub TblUsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblUsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblUsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wnw_travel_dbDataSet1)

    End Sub

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblUsersTableAdapter.Fill(Me.Wnw_travel_dbDataSet1.tblUsers)
    End Sub
End Class