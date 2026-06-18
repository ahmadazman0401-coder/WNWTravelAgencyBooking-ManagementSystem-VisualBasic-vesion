Public Class Form7
    Const travelday As Integer = 7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblPackagesTableAdapter.Fill(Me.Wnw_travel_dbDataSet1.tblPackages)
        Me.TblBookingsTableAdapter.Fill(Me.Wnw_travel_dbDataSet1.tblBookings)
        Dim Accomodation() As String = {"AirBnB", "Hotels", "Resorts"}
        Dim Choice() As String = {"Budget", "Standard", "Extra"}

        cmbAccomodation.Items.AddRange(Accomodation)
        cmbClass.Items.AddRange(Choice)


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim assitance As String = txtAssistance.Text
        Dim destination As String = cmbDestination.Text
        Dim adultCount As String = CInt(txtAdults.Text)
        Dim kidCount As String = CInt(txtKids.Text)
        Dim infants As String = CInt(txtInfants.Text)
        Dim infantsseat As String = txtInfantsSeat.Text
        Dim elderCount As String = CInt(txtElders.Text)
        Dim Accomodation As String = cmbAccomodation.Text
        Dim choice As String = cmbClass.Text
        Dim groups As String = txtGroups.Text
        Dim startDate As String = dtpStart.Value.ToShortDateString()
        Dim endDate As String = dtpEnd.Value.ToShortDateString()

        Form1.SelectedSourceForm = 7
        Form1.userdestination = cmbDestination.Text
        Form1.TravelDays = travelday
        Form1.pax = txtAdults.Text & "adults" & txtKids.Text & "kids" & txtElders.Text & "elders"
        Form1.aaccomodation = cmbAccomodation.Text
        Form1.group = txtGroups.Text
        Form1.dates = dtpStart.Value.ToShortDateString() & "-" & dtpEnd.Value.ToShortDateString()
        Form1.adult = txtAdults.Text
        Form1.kid = txtKids.Text
        Form1.infant = txtInfants.Text
        Form1.elder = txtElders.Text
        Form1.choice = cmbClass.Text

        Dim confirmationMsg As String
        confirmationMsg = "Are you sure of all the details?" & vbCrLf & vbCrLf &
                      "Destination: " & destination & vbCrLf &
                     " Days" & vbCrLf &
                      "Travelers: " & adultCount & " Adults, " & kidCount & " Kids, " & elderCount & " Elders"

        Dim result As DialogResult = MessageBox.Show(confirmationMsg, "NOTICE", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim nextForm As New Form12()
            nextForm.Show()
            Me.Hide()
        End If

        dtpStart.Value = DateTime.Today
        dtpStart.MinDate = DateTime.Today
        dtpEnd.Value = dtpStart.Value.AddDays(7)
        dtpEnd.Enabled = False

    End Sub

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged
        dtpEnd.Value = dtpStart.Value.AddDays(7)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim nextForm As New Form5()
        nextForm.Show()
        Me.Hide()
    End Sub
End Class