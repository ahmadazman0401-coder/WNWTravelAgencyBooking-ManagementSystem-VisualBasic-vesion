Imports System.Data.OleDb
Public Class Form15

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

    Private Sub btnPackages_Click(sender As Object, e As EventArgs) Handles btnPackages.Click
        Dim nextForm As New Form16()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim nextForm As New Form1()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub TblBookingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblBookingsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblBookingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wnw_travel_dbDataSet1)

    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblBookingsTableAdapter.Fill(Me.Wnw_travel_dbDataSet1.tblBookings)
    End Sub
End Class