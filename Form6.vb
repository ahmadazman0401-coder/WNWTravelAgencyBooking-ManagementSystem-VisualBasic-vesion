Public Class Form6
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim assitance As String = txtAssistance.Text
        Dim destination As String = cmbDestination.Text
        Dim travelDays As String = CInt(txtDays.Text)
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

        Form1.SelectedSourceForm = 6
        Form1.userdestination = cmbDestination.Text
        Form1.TravelDays = txtDays.Text
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
                      "Duration: " & travelDays & " Days" & vbCrLf &
                      "Travelers: " & adultCount & " Adults, " & kidCount & " Kids, " & elderCount & " Elders"

        Dim result As DialogResult = MessageBox.Show(confirmationMsg, "NOTICE", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim nextForm As New Form12()
            nextForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblPackagesTableAdapter.Fill(Me.Wnw_travel_dbDataSet1.tblPackages)

        Dim Accomodation() As String = {"AirBnB", "Hotels", "Resorts"}
        Dim Choice() As String = {"Budget", "Standard", "Extra"}
        cmbAccomodation.Items.AddRange(Accomodation)
        cmbClass.Items.AddRange(Choice)

    End Sub

    Private Sub txtDays_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged
        Dim daysCount As Integer

        If Integer.TryParse(txtDays.Text, daysCount) Then
            dtpEnd.Value = dtpStart.Value.AddDays(daysCount)

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim nextForm As New Form5()
        nextForm.Show()
        Me.Hide()
    End Sub
End Class