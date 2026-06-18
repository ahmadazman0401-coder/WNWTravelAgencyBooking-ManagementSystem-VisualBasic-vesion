Public Class Form12
    Const earlybird As Decimal = 0.4


    Public Function GetAdultTotal(numAdults As Integer) As Decimal
        Dim total As Decimal = numAdults * 2500
        Return total
    End Function

    Public Function GetInfantsTotal(numInfants As Integer) As Decimal
        Dim total As Decimal = numInfants * 900
        Return total
    End Function


    Public Function GetKidTotal(numKids As Integer) As Decimal
        Dim total As Decimal = numKids * 1800
        Return total
    End Function


    Public Function GetElderTotal(numElders As Integer) As Decimal
        Dim total As Decimal = numElders * 1100
        Return total
    End Function

    Public Function AccomodationFee(accomodation As String) As Decimal
        Dim rateAccom As Decimal
        Dim group As Integer = Form1.group
        If accomodation = "AirBnB" Then
            rateAccom = 500
        ElseIf accomodation = "Hotels" Then
            rateAccom = 250
        ElseIf accomodation = "Resorts" Then
            rateAccom = 350
        End If
        Dim total As Decimal = rateAccom * group
        Return total
    End Function
    Public Function ClassFee(choice As String) As Decimal
        Dim rateclass As Decimal
        Dim group As Integer = Form1.group
        If choice = "Budget " Then
            rateclass = 200
        ElseIf choice = "Standard" Then
            rateclass = 300
        ElseIf choice = "Extra" Then
            rateclass = 400
        End If
        Dim total As Decimal = rateclass
        Return total
    End Function

    Public Function GetSubtotal(a As Integer, k As Integer, e As Integer, ac As String, inf As String) As Decimal
        Return GetAdultTotal(a) + GetKidTotal(k) + GetElderTotal(e) + AccomodationFee(ac) + GetInfantsTotal(inf) + 450 + 150
    End Function


    Public Function GetDiscountFee(subtotal As Decimal) As Decimal
        Return subtotal * earlybird
    End Function

    Public Function GetGrandTotal(subtotal As Decimal, discount As Decimal) As Decimal
        Return subtotal - discount
    End Function

    Public Shared SelectedSourceForm As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nextForm As New Form13()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click


        Dim message As String = "Booking and payment confirmed. We'll contact you shortly with your travel details."
        Dim title As String = "Payment Successful"


        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information)


        Form4.Show()
        Me.Close()
    End Sub


    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BankName() As String = {"Bank Islam", "MayBank", "Bank Rakyat", "RHB Bank", "AMBank"}
        cmbBank.Items.AddRange(BankName)

        Dim dest As String = Form1.userdestination
        Dim td As String = Form1.TravelDays
        Dim travelers As String = Form1.pax
        Dim acc As String = Form1.aaccomodation
        Dim gp As String = Form1.group
        Dim dt As String = Form1.dates
        Dim ch As String = Form1.choice
        Dim inf As String = Form1.infant



        Select Case Form1.SelectedSourceForm
            Case 6
                lblDestination.Text = dest
                lblDuration.Text = td
                lblTravelers.Text = travelers
                lblAccommodation.Text = acc & "(" & ch & ")"
                lblGroups.Text = gp
                lblDates.Text = dt

            Case 7
                lblDestination.Text = dest
                lblDuration.Text = td
                lblTravelers.Text = travelers
                lblAccommodation.Text = acc & "(" & ch & ")"
                lblGroups.Text = gp
                lblDates.Text = dt

            Case 8
                lblDestination.Text = dest
                lblDuration.Text = td
                lblTravelers.Text = travelers
                lblAccommodation.Text = acc & "(" & ch & ")"
                lblGroups.Text = gp
                lblDates.Text = dt

            Case 9
                lblDestination.Text = dest
                lblDuration.Text = td
                lblTravelers.Text = travelers
                lblAccommodation.Text = acc & "(" & ch & ")"
                lblGroups.Text = gp
                lblDates.Text = dt

        End Select

        Dim a As Integer = Form1.adult
        Dim k As Integer = Form1.kid
        Dim e_age As Integer = Form1.elder
        Dim accomodation As String = Form1.aaccomodation

        Dim travelinsurance As Decimal = 450
        Dim servicefee As Decimal = 150


        Dim mySubtotal As Decimal = GetSubtotal(a, k, e_age, accomodation, inf)


        Dim myDiscount As Decimal = GetDiscountFee(mySubtotal)

        Dim myGrandTotal As Decimal = GetGrandTotal(mySubtotal, myDiscount)


        lblAdults.Text = "RM:" & GetAdultTotal(Form1.adult).ToString("C2")
        lblInfants.Text = "RM:" & GetInfantsTotal(Form1.infant).ToString("C2")
        lblKids.Text = "RM:" & GetKidTotal(Form1.kid).ToString("C2")
        lblElders.Text = "RM:" & GetElderTotal(Form1.elder).ToString("C2")
        lblFee.Text = "RM: " & AccomodationFee(Form1.aaccomodation).ToString("N2")
        lblInsurance.Text = "RM:" & travelinsurance
        lblService.Text = "RM:" & servicefee
        lblDiscount.Text = "RM:" & myDiscount.ToString("c2")
        lblTotal.Text = "RM:" & myGrandTotal.ToString("c2")
        lblc1.Text = "x" & Form1.adult
        lblc2.Text = "x" & Form1.kid
        lblc3.Text = "x" & Form1.elder
        lblc4.Text = "x" & Form1.group
        lblc5.Text = "x" & Form1.infant

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Select Case Form1.SelectedSourceForm
            Case 6
                Dim nextForm As New Form6()
                nextForm.Show()
                Me.Hide()
            Case 7
                Dim nextForm As New Form7()
                nextForm.Show()
                Me.Hide()
            Case 8
                Dim nextForm As New Form8()
                nextForm.Show()
                Me.Hide()
            Case 9
                Dim nextForm As New Form9()
                nextForm.Show()
                Me.Hide()
        End Select
    End Sub
End Class