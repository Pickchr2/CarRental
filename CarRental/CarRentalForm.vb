'Christopher Pickens
'RCET0265
'Spring 2023
'Car Rental
'https://github.com/Pickchr2/CarRental.git

Option Explicit On
Option Strict On

Class CarRentalForm
    Dim daysRented As Integer
    Dim endingOdometer As Integer
    Dim startingOdometer As Integer
    Dim totalCustomers As Integer
    Dim totalMilesSummary As Double
    Dim totalChargesSummary As Double

    Private Sub Calculate()
        Const freeMiles As Integer = 200
        Const dailyCharge As Double = 15.0
        Const firstMilageCharge As Double = 0.12
        Const secondMilageCharge As Double = 0.1
        Const aaaDiscountPercent As Double = 0.05
        Const seniorDiscountPercent As Double = 0.03

        Dim distanceInMiles As Double
        Dim milageCharge As Double
        Dim dayCharge As Double
        Dim totalDiscount As Double
        Dim totalCharge As Double

        totalCustomers += 1
        distanceInMiles = endingOdometer - startingOdometer
        totalMilesSummary += distanceInMiles

        If KilometersRadioButton.Checked Then
            distanceInMiles *= 0.62
        End If

        DistanceDrivenTextBox.Text = Math.Round(distanceInMiles, 2).ToString()
        distanceInMiles -= freeMiles

        If distanceInMiles <= 0 Then
            milageCharge = 0
        ElseIf distanceInMiles > 0 And distanceInMiles < 301 Then
            milageCharge = distanceInMiles * firstMilageCharge
        Else
            distanceInMiles -= 300
            milageCharge = (firstMilageCharge * 300)
            milageCharge += (distanceInMiles * secondMilageCharge)
        End If

        MilageChargeTextBox.Text = milageCharge.ToString("C")
        dayCharge = daysRented * dailyCharge
        DayChargeTextBox.Text = dayCharge.ToString("C")
        totalCharge = milageCharge + dayCharge

        If AAACheckBox.Checked Then
            totalDiscount += aaaDiscountPercent
        End If

        If SeniorCheckBox.Checked Then
            totalDiscount += seniorDiscountPercent
        End If

        totalDiscount *= totalCharge
        AmountDiscountedTextBox.Text = totalDiscount.ToString("C")
        totalCharge -= totalDiscount
        TotalChargeTextBox.Text = totalCharge.ToString("C")
        totalChargesSummary += totalCharge
    End Sub

    Private Function ValidateInput() As Boolean
        Dim invalidData As String = ""

        NameTextBox.BackColor = Color.White
        StreetTextBox.BackColor = Color.White
        CityTextBox.BackColor = Color.White
        StateTextBox.BackColor = Color.White
        ZipTextBox.BackColor = Color.White
        StartingOdometerTextBox.BackColor = Color.White
        EndingOdometerTextBox.BackColor = Color.White
        DaysRentedTextBox.BackColor = Color.White

        If DaysRentedTextBox.Text = "" Then
            invalidData = "Days Rented must be entered." & vbCrLf & invalidData
            DaysRentedTextBox.BackColor = Color.Yellow
            DaysRentedTextBox.Focus()
        Else
            Try
                daysRented = CInt(DaysRentedTextBox.Text)

                If daysRented < 1 Then
                    invalidData = "Days Rented cannot be less than 1." & vbCrLf & invalidData
                    DaysRentedTextBox.BackColor = Color.Yellow
                    DaysRentedTextBox.Focus()
                    DaysRentedTextBox.SelectAll()
                End If
            Catch ex As Exception
                invalidData = "Days Rented must a valid whole number." & vbCrLf & invalidData
                DaysRentedTextBox.BackColor = Color.Yellow
                DaysRentedTextBox.Focus()
                DaysRentedTextBox.SelectAll()
            End Try
        End If

        If EndingOdometerTextBox.Text = "" Then
            invalidData = "Ending Odometer Reading must be entered." & vbCrLf & invalidData
            EndingOdometerTextBox.BackColor = Color.Yellow
            EndingOdometerTextBox.Focus()
        Else
            Try
                endingOdometer = CInt(EndingOdometerTextBox.Text)
            Catch ex As Exception
                invalidData = "Ending Odometer Reading must a valid whole number." & vbCrLf & invalidData
                EndingOdometerTextBox.BackColor = Color.Yellow
                EndingOdometerTextBox.Focus()
                EndingOdometerTextBox.SelectAll()
            End Try
        End If

        If StartingOdometerTextBox.Text = "" Then
            invalidData = "Starting Odometer Reading must be entered." & vbCrLf & invalidData
            StartingOdometerTextBox.BackColor = Color.Yellow
            StartingOdometerTextBox.Focus()
        Else
            Try
                startingOdometer = CInt(StartingOdometerTextBox.Text)

                If startingOdometer >= endingOdometer And EndingOdometerTextBox.Text <> "" Then
                    invalidData = "Starting Odometer Reading must be less than Ending Odometer Reading." & vbCrLf & invalidData
                    StartingOdometerTextBox.BackColor = Color.Yellow
                    StartingOdometerTextBox.Focus()
                    StartingOdometerTextBox.SelectAll()
                ElseIf startingOdometer < 1 Then
                    invalidData = "Starting Odometer Reading cannot be less than 1." & vbCrLf & invalidData
                    StartingOdometerTextBox.BackColor = Color.Yellow
                    StartingOdometerTextBox.Focus()
                    StartingOdometerTextBox.SelectAll()
                End If
            Catch ex As Exception
                invalidData = "Starting Odometer Reading must a valid whole number." & vbCrLf & invalidData
                StartingOdometerTextBox.BackColor = Color.Yellow
                StartingOdometerTextBox.Focus()
                StartingOdometerTextBox.SelectAll()
            End Try
        End If

        If ZipTextBox.Text = "" Then
            invalidData = "Zip Code must be entered." & vbCrLf & invalidData
            ZipTextBox.BackColor = Color.Yellow
            ZipTextBox.Focus()
        ElseIf ZipTextBox.TextLength <> 5 Then
            invalidData = "Zip Code must contain exactly 5 characters." & vbCrLf & invalidData
            ZipTextBox.BackColor = Color.Yellow
            ZipTextBox.Focus()
            ZipTextBox.SelectAll()
        End If

        If StateTextBox.Text = "" Then
            invalidData = "State must be entered." & vbCrLf & invalidData
            StateTextBox.BackColor = Color.Yellow
            StateTextBox.Focus()
        End If

        If CityTextBox.Text = "" Then
            invalidData = "City must be entered." & vbCrLf & invalidData
            CityTextBox.BackColor = Color.Yellow
            CityTextBox.Focus()
        End If

        If StreetTextBox.Text = "" Then
            invalidData = "Street Address must be entered." & vbCrLf & invalidData
            StreetTextBox.BackColor = Color.Yellow
            StreetTextBox.Focus()
        End If

        If NameTextBox.Text = "" Then
            invalidData = "Customer's Name must be entered." & vbCrLf & invalidData
            NameTextBox.BackColor = Color.Yellow
            NameTextBox.Focus()
        End If

        If invalidData <> "" Then
            MessageBox.Show(invalidData, "Please correct the following errors.")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ExitPrompt()
        Dim userResponse As Integer

        userResponse = MsgBox("You are about to close the application and lose all saved information. Are you sure you wish to exit?", vbYesNo, "Exit the Application.")

        If userResponse = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        ExitPrompt()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        NameTextBox.BackColor = Color.White
        StreetTextBox.BackColor = Color.White
        CityTextBox.BackColor = Color.White
        StateTextBox.BackColor = Color.White
        ZipTextBox.BackColor = Color.White
        StartingOdometerTextBox.BackColor = Color.White
        EndingOdometerTextBox.BackColor = Color.White
        DaysRentedTextBox.BackColor = Color.White
        NameTextBox.Clear()
        StreetTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipTextBox.Clear()
        StartingOdometerTextBox.Clear()
        EndingOdometerTextBox.Clear()
        DaysRentedTextBox.Clear()
        DistanceDrivenTextBox.Clear()
        MilageChargeTextBox.Clear()
        DayChargeTextBox.Clear()
        AmountDiscountedTextBox.Clear()
        TotalChargeTextBox.Clear()
        AAACheckBox.Checked = False
        SeniorCheckBox.Checked = False
        KilometersRadioButton.Checked = False
        MilesRadioButton.Checked = True
        NameTextBox.Focus()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click
        Dim inputValidated As Boolean

        inputValidated = ValidateInput()

        If inputValidated Then
            Calculate()
            NameTextBox.Clear()
            StreetTextBox.Clear()
            CityTextBox.Clear()
            StateTextBox.Clear()
            ZipTextBox.Clear()
            StartingOdometerTextBox.Clear()
            EndingOdometerTextBox.Clear()
            DaysRentedTextBox.Clear()
            AAACheckBox.Checked = False
            SeniorCheckBox.Checked = False
            KilometersRadioButton.Checked = False
            MilesRadioButton.Checked = True
            NameTextBox.Focus()
        End If
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click, SummaryToolStripMenuItem.Click
        Dim displayTotal As String

        displayTotal = "Total Customers: " & totalCustomers & vbCrLf _
                       & "Total Miles Driven: " & totalMilesSummary & vbCrLf _
                       & "Total Charges: " & totalChargesSummary.ToString("C")

        MessageBox.Show(displayTotal, "Detailed Summary of All Transactions.")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutMessage As String

        aboutMessage = "Enter all customer information into the application, as well as the starting and ending odometer reading along with days rented. " _
                       & "If any fields are incorrect, please correct all errors before continuing, then the charges will be calculated " _
                       & "Click the Detailed Summary button to to see the summary of all charges so far."

        MessageBox.Show(aboutMessage, "About.")
    End Sub
End Class
