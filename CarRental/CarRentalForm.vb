'Christopher Pickens
'RCET0265
'Spring 2023
'Car Rental
'https://github.com/Pickchr2/CarRental.git

Option Explicit On
Option Strict On

Class CarRentalForm
    Sub ExitPrompt()
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
End Class
