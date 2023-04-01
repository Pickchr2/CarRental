<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarRentalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DaysRentedTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.StartingOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StreetLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.StartingOdometerLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerLabel = New System.Windows.Forms.Label()
        Me.DaysLabel = New System.Windows.Forms.Label()
        Me.DiscountsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeniorCheckBox = New System.Windows.Forms.CheckBox()
        Me.AAACheckBox = New System.Windows.Forms.CheckBox()
        Me.OdometerTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.KilometersRadioButton = New System.Windows.Forms.RadioButton()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.RentalInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.CalculatedTotalGroupBox = New System.Windows.Forms.GroupBox()
        Me.DistanceDrivenLabel = New System.Windows.Forms.Label()
        Me.DistanceDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.TotalChargeTextBox = New System.Windows.Forms.TextBox()
        Me.TotalChargeLabel = New System.Windows.Forms.Label()
        Me.AmountDiscountedTextBox = New System.Windows.Forms.TextBox()
        Me.AmountDiscountedLabel = New System.Windows.Forms.Label()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.MilageChargeTextBox = New System.Windows.Forms.TextBox()
        Me.MilageChargeLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DiscountsGroupBox.SuspendLayout()
        Me.OdometerTypeGroupBox.SuspendLayout()
        Me.RentalInfoGroupBox.SuspendLayout()
        Me.CalculatedTotalGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(219, 34)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(188, 30)
        Me.NameTextBox.TabIndex = 0
        '
        'DaysRentedTextBox
        '
        Me.DaysRentedTextBox.Location = New System.Drawing.Point(219, 300)
        Me.DaysRentedTextBox.Name = "DaysRentedTextBox"
        Me.DaysRentedTextBox.Size = New System.Drawing.Size(188, 30)
        Me.DaysRentedTextBox.TabIndex = 1
        '
        'EndingOdometerTextBox
        '
        Me.EndingOdometerTextBox.Location = New System.Drawing.Point(219, 262)
        Me.EndingOdometerTextBox.Name = "EndingOdometerTextBox"
        Me.EndingOdometerTextBox.Size = New System.Drawing.Size(188, 30)
        Me.EndingOdometerTextBox.TabIndex = 2
        '
        'StartingOdometerTextBox
        '
        Me.StartingOdometerTextBox.Location = New System.Drawing.Point(219, 224)
        Me.StartingOdometerTextBox.Name = "StartingOdometerTextBox"
        Me.StartingOdometerTextBox.Size = New System.Drawing.Size(188, 30)
        Me.StartingOdometerTextBox.TabIndex = 3
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(219, 186)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(188, 30)
        Me.ZipTextBox.TabIndex = 4
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(219, 148)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(188, 30)
        Me.StateTextBox.TabIndex = 5
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(219, 110)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(188, 30)
        Me.CityTextBox.TabIndex = 6
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(219, 72)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(188, 30)
        Me.StreetTextBox.TabIndex = 7
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameLabel.Location = New System.Drawing.Point(6, 39)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(119, 20)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Customer Name:"
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StreetLabel.Location = New System.Drawing.Point(6, 77)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(108, 20)
        Me.StreetLabel.TabIndex = 9
        Me.StreetLabel.Text = "Street Address:"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CityLabel.Location = New System.Drawing.Point(6, 115)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(37, 20)
        Me.CityLabel.TabIndex = 10
        Me.CityLabel.Text = "City:"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StateLabel.Location = New System.Drawing.Point(6, 153)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(46, 20)
        Me.StateLabel.TabIndex = 11
        Me.StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ZipLabel.Location = New System.Drawing.Point(6, 191)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(73, 20)
        Me.ZipLabel.TabIndex = 12
        Me.ZipLabel.Text = "Zip Code:"
        '
        'StartingOdometerLabel
        '
        Me.StartingOdometerLabel.AutoSize = True
        Me.StartingOdometerLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartingOdometerLabel.Location = New System.Drawing.Point(6, 229)
        Me.StartingOdometerLabel.Name = "StartingOdometerLabel"
        Me.StartingOdometerLabel.Size = New System.Drawing.Size(195, 20)
        Me.StartingOdometerLabel.TabIndex = 13
        Me.StartingOdometerLabel.Text = "Starting Odometer Reading:"
        '
        'EndingOdometerLabel
        '
        Me.EndingOdometerLabel.AutoSize = True
        Me.EndingOdometerLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EndingOdometerLabel.Location = New System.Drawing.Point(6, 267)
        Me.EndingOdometerLabel.Name = "EndingOdometerLabel"
        Me.EndingOdometerLabel.Size = New System.Drawing.Size(189, 20)
        Me.EndingOdometerLabel.TabIndex = 14
        Me.EndingOdometerLabel.Text = "Ending Odometer Reading:"
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DaysLabel.Location = New System.Drawing.Point(6, 305)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(95, 20)
        Me.DaysLabel.TabIndex = 15
        Me.DaysLabel.Text = "Days Rented:"
        '
        'DiscountsGroupBox
        '
        Me.DiscountsGroupBox.Controls.Add(Me.SeniorCheckBox)
        Me.DiscountsGroupBox.Controls.Add(Me.AAACheckBox)
        Me.DiscountsGroupBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DiscountsGroupBox.Location = New System.Drawing.Point(448, 139)
        Me.DiscountsGroupBox.Name = "DiscountsGroupBox"
        Me.DiscountsGroupBox.Size = New System.Drawing.Size(401, 121)
        Me.DiscountsGroupBox.TabIndex = 16
        Me.DiscountsGroupBox.TabStop = False
        Me.DiscountsGroupBox.Text = "Available Customer Discounts"
        '
        'SeniorCheckBox
        '
        Me.SeniorCheckBox.AutoSize = True
        Me.SeniorCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SeniorCheckBox.Location = New System.Drawing.Point(31, 78)
        Me.SeniorCheckBox.Name = "SeniorCheckBox"
        Me.SeniorCheckBox.Size = New System.Drawing.Size(184, 24)
        Me.SeniorCheckBox.TabIndex = 1
        Me.SeniorCheckBox.Text = "Senior Citizen Discount"
        Me.SeniorCheckBox.UseVisualStyleBackColor = True
        '
        'AAACheckBox
        '
        Me.AAACheckBox.AutoSize = True
        Me.AAACheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AAACheckBox.Location = New System.Drawing.Point(31, 36)
        Me.AAACheckBox.Name = "AAACheckBox"
        Me.AAACheckBox.Size = New System.Drawing.Size(183, 24)
        Me.AAACheckBox.TabIndex = 0
        Me.AAACheckBox.Text = "AAA Member Discount"
        Me.AAACheckBox.UseVisualStyleBackColor = True
        '
        'OdometerTypeGroupBox
        '
        Me.OdometerTypeGroupBox.Controls.Add(Me.KilometersRadioButton)
        Me.OdometerTypeGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.OdometerTypeGroupBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OdometerTypeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OdometerTypeGroupBox.Location = New System.Drawing.Point(448, 12)
        Me.OdometerTypeGroupBox.Name = "OdometerTypeGroupBox"
        Me.OdometerTypeGroupBox.Size = New System.Drawing.Size(401, 121)
        Me.OdometerTypeGroupBox.TabIndex = 17
        Me.OdometerTypeGroupBox.TabStop = False
        Me.OdometerTypeGroupBox.Text = "Is odometer in miles or kilometers?"
        '
        'KilometersRadioButton
        '
        Me.KilometersRadioButton.AutoSize = True
        Me.KilometersRadioButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KilometersRadioButton.Location = New System.Drawing.Point(31, 78)
        Me.KilometersRadioButton.Name = "KilometersRadioButton"
        Me.KilometersRadioButton.Size = New System.Drawing.Size(101, 24)
        Me.KilometersRadioButton.TabIndex = 1
        Me.KilometersRadioButton.TabStop = True
        Me.KilometersRadioButton.Text = "Kilometers"
        Me.KilometersRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MilesRadioButton.Location = New System.Drawing.Point(31, 36)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(65, 24)
        Me.MilesRadioButton.TabIndex = 0
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'RentalInfoGroupBox
        '
        Me.RentalInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.DaysRentedTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.DaysLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.EndingOdometerTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.EndingOdometerLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.StartingOdometerTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.StartingOdometerLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.ZipTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.ZipLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.StateTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.StateLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.CityTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.CityLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.StreetTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.StreetLabel)
        Me.RentalInfoGroupBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RentalInfoGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.RentalInfoGroupBox.Name = "RentalInfoGroupBox"
        Me.RentalInfoGroupBox.Size = New System.Drawing.Size(420, 343)
        Me.RentalInfoGroupBox.TabIndex = 17
        Me.RentalInfoGroupBox.TabStop = False
        Me.RentalInfoGroupBox.Text = "Rental Information"
        '
        'CalculatedTotalGroupBox
        '
        Me.CalculatedTotalGroupBox.Controls.Add(Me.DistanceDrivenLabel)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.DistanceDrivenTextBox)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.TotalChargeTextBox)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.TotalChargeLabel)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.AmountDiscountedTextBox)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.AmountDiscountedLabel)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.DayChargeTextBox)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.DayChargeLabel)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.MilageChargeTextBox)
        Me.CalculatedTotalGroupBox.Controls.Add(Me.MilageChargeLabel)
        Me.CalculatedTotalGroupBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CalculatedTotalGroupBox.Location = New System.Drawing.Point(448, 266)
        Me.CalculatedTotalGroupBox.Name = "CalculatedTotalGroupBox"
        Me.CalculatedTotalGroupBox.Size = New System.Drawing.Size(401, 216)
        Me.CalculatedTotalGroupBox.TabIndex = 18
        Me.CalculatedTotalGroupBox.TabStop = False
        Me.CalculatedTotalGroupBox.Text = "Calculated Total"
        '
        'DistanceDrivenLabel
        '
        Me.DistanceDrivenLabel.AutoSize = True
        Me.DistanceDrivenLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DistanceDrivenLabel.Location = New System.Drawing.Point(11, 31)
        Me.DistanceDrivenLabel.Name = "DistanceDrivenLabel"
        Me.DistanceDrivenLabel.Size = New System.Drawing.Size(171, 20)
        Me.DistanceDrivenLabel.TabIndex = 18
        Me.DistanceDrivenLabel.Text = "Distance Driven In Miles:"
        '
        'DistanceDrivenTextBox
        '
        Me.DistanceDrivenTextBox.Location = New System.Drawing.Point(224, 26)
        Me.DistanceDrivenTextBox.Name = "DistanceDrivenTextBox"
        Me.DistanceDrivenTextBox.Size = New System.Drawing.Size(160, 30)
        Me.DistanceDrivenTextBox.TabIndex = 13
        '
        'TotalChargeTextBox
        '
        Me.TotalChargeTextBox.Location = New System.Drawing.Point(224, 178)
        Me.TotalChargeTextBox.Name = "TotalChargeTextBox"
        Me.TotalChargeTextBox.Size = New System.Drawing.Size(160, 30)
        Me.TotalChargeTextBox.TabIndex = 14
        '
        'TotalChargeLabel
        '
        Me.TotalChargeLabel.AutoSize = True
        Me.TotalChargeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalChargeLabel.Location = New System.Drawing.Point(11, 183)
        Me.TotalChargeLabel.Name = "TotalChargeLabel"
        Me.TotalChargeLabel.Size = New System.Drawing.Size(96, 20)
        Me.TotalChargeLabel.TabIndex = 22
        Me.TotalChargeLabel.Text = "Total Charge:"
        '
        'AmountDiscountedTextBox
        '
        Me.AmountDiscountedTextBox.Location = New System.Drawing.Point(224, 140)
        Me.AmountDiscountedTextBox.Name = "AmountDiscountedTextBox"
        Me.AmountDiscountedTextBox.Size = New System.Drawing.Size(160, 30)
        Me.AmountDiscountedTextBox.TabIndex = 15
        '
        'AmountDiscountedLabel
        '
        Me.AmountDiscountedLabel.AutoSize = True
        Me.AmountDiscountedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountDiscountedLabel.Location = New System.Drawing.Point(11, 145)
        Me.AmountDiscountedLabel.Name = "AmountDiscountedLabel"
        Me.AmountDiscountedLabel.Size = New System.Drawing.Size(144, 20)
        Me.AmountDiscountedLabel.TabIndex = 21
        Me.AmountDiscountedLabel.Text = "Amount Discounted:"
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Location = New System.Drawing.Point(224, 102)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(160, 30)
        Me.DayChargeTextBox.TabIndex = 16
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DayChargeLabel.Location = New System.Drawing.Point(11, 107)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(171, 20)
        Me.DayChargeLabel.TabIndex = 20
        Me.DayChargeLabel.Text = "Charge For Days Rented:"
        '
        'MilageChargeTextBox
        '
        Me.MilageChargeTextBox.Location = New System.Drawing.Point(224, 64)
        Me.MilageChargeTextBox.Name = "MilageChargeTextBox"
        Me.MilageChargeTextBox.Size = New System.Drawing.Size(160, 30)
        Me.MilageChargeTextBox.TabIndex = 17
        '
        'MilageChargeLabel
        '
        Me.MilageChargeLabel.AutoSize = True
        Me.MilageChargeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MilageChargeLabel.Location = New System.Drawing.Point(11, 69)
        Me.MilageChargeLabel.Name = "MilageChargeLabel"
        Me.MilageChargeLabel.Size = New System.Drawing.Size(109, 20)
        Me.MilageChargeLabel.TabIndex = 19
        Me.MilageChargeLabel.Text = "Milage Charge:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 361)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(201, 55)
        Me.CalculateButton.TabIndex = 19
        Me.CalculateButton.Text = "Calculate Total"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(231, 361)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(201, 55)
        Me.SummaryButton.TabIndex = 20
        Me.SummaryButton.Text = "Detailed Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(231, 431)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(201, 55)
        Me.ExitButton.TabIndex = 22
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(12, 431)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(201, 55)
        Me.ClearButton.TabIndex = 21
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CarRentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 498)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.CalculatedTotalGroupBox)
        Me.Controls.Add(Me.RentalInfoGroupBox)
        Me.Controls.Add(Me.OdometerTypeGroupBox)
        Me.Controls.Add(Me.DiscountsGroupBox)
        Me.Name = "CarRentalForm"
        Me.Text = "Acme Car Rental Service"
        Me.DiscountsGroupBox.ResumeLayout(False)
        Me.DiscountsGroupBox.PerformLayout()
        Me.OdometerTypeGroupBox.ResumeLayout(False)
        Me.OdometerTypeGroupBox.PerformLayout()
        Me.RentalInfoGroupBox.ResumeLayout(False)
        Me.RentalInfoGroupBox.PerformLayout()
        Me.CalculatedTotalGroupBox.ResumeLayout(False)
        Me.CalculatedTotalGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DaysRentedTextBox As TextBox
    Friend WithEvents EndingOdometerTextBox As TextBox
    Friend WithEvents StartingOdometerTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents StreetLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StartingOdometerLabel As Label
    Friend WithEvents EndingOdometerLabel As Label
    Friend WithEvents DaysLabel As Label
    Friend WithEvents DiscountsGroupBox As GroupBox
    Friend WithEvents OdometerTypeGroupBox As GroupBox
    Friend WithEvents RentalInfoGroupBox As GroupBox
    Friend WithEvents AAACheckBox As CheckBox
    Friend WithEvents KilometersRadioButton As RadioButton
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents SeniorCheckBox As CheckBox
    Friend WithEvents CalculatedTotalGroupBox As GroupBox
    Friend WithEvents DistanceDrivenLabel As Label
    Friend WithEvents DistanceDrivenTextBox As TextBox
    Friend WithEvents TotalChargeTextBox As TextBox
    Friend WithEvents TotalChargeLabel As Label
    Friend WithEvents AmountDiscountedTextBox As TextBox
    Friend WithEvents AmountDiscountedLabel As Label
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents MilageChargeTextBox As TextBox
    Friend WithEvents MilageChargeLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
End Class
