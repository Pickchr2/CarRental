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
        Me.components = New System.ComponentModel.Container()
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
        Me.CarRentalToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CarRentalMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscountsGroupBox.SuspendLayout()
        Me.OdometerTypeGroupBox.SuspendLayout()
        Me.RentalInfoGroupBox.SuspendLayout()
        Me.CalculatedTotalGroupBox.SuspendLayout()
        Me.CarRentalMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.White
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameTextBox.Location = New System.Drawing.Point(219, 34)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(188, 27)
        Me.NameTextBox.TabIndex = 1
        Me.CarRentalToolTip.SetToolTip(Me.NameTextBox, "Enter the customer's name.")
        '
        'DaysRentedTextBox
        '
        Me.DaysRentedTextBox.BackColor = System.Drawing.Color.White
        Me.DaysRentedTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DaysRentedTextBox.Location = New System.Drawing.Point(219, 300)
        Me.DaysRentedTextBox.Name = "DaysRentedTextBox"
        Me.DaysRentedTextBox.Size = New System.Drawing.Size(188, 27)
        Me.DaysRentedTextBox.TabIndex = 15
        Me.CarRentalToolTip.SetToolTip(Me.DaysRentedTextBox, "Enter the total number of days the vehicle was rented.")
        '
        'EndingOdometerTextBox
        '
        Me.EndingOdometerTextBox.BackColor = System.Drawing.Color.White
        Me.EndingOdometerTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EndingOdometerTextBox.Location = New System.Drawing.Point(219, 262)
        Me.EndingOdometerTextBox.Name = "EndingOdometerTextBox"
        Me.EndingOdometerTextBox.Size = New System.Drawing.Size(188, 27)
        Me.EndingOdometerTextBox.TabIndex = 13
        Me.CarRentalToolTip.SetToolTip(Me.EndingOdometerTextBox, "Enter the odometer reading at the end of the rental period.")
        '
        'StartingOdometerTextBox
        '
        Me.StartingOdometerTextBox.BackColor = System.Drawing.Color.White
        Me.StartingOdometerTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartingOdometerTextBox.Location = New System.Drawing.Point(219, 224)
        Me.StartingOdometerTextBox.Name = "StartingOdometerTextBox"
        Me.StartingOdometerTextBox.Size = New System.Drawing.Size(188, 27)
        Me.StartingOdometerTextBox.TabIndex = 11
        Me.CarRentalToolTip.SetToolTip(Me.StartingOdometerTextBox, "Enter the odometer reading at the start of the rental period.")
        '
        'ZipTextBox
        '
        Me.ZipTextBox.BackColor = System.Drawing.Color.White
        Me.ZipTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ZipTextBox.Location = New System.Drawing.Point(219, 186)
        Me.ZipTextBox.MaxLength = 5
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(188, 27)
        Me.ZipTextBox.TabIndex = 9
        Me.CarRentalToolTip.SetToolTip(Me.ZipTextBox, "Enter the customer's zip code.")
        '
        'StateTextBox
        '
        Me.StateTextBox.BackColor = System.Drawing.Color.White
        Me.StateTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StateTextBox.Location = New System.Drawing.Point(219, 148)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(188, 27)
        Me.StateTextBox.TabIndex = 7
        Me.CarRentalToolTip.SetToolTip(Me.StateTextBox, "Enter the customer's state.")
        '
        'CityTextBox
        '
        Me.CityTextBox.BackColor = System.Drawing.Color.White
        Me.CityTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CityTextBox.Location = New System.Drawing.Point(219, 110)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(188, 27)
        Me.CityTextBox.TabIndex = 5
        Me.CarRentalToolTip.SetToolTip(Me.CityTextBox, "Enter the customer's city.")
        '
        'StreetTextBox
        '
        Me.StreetTextBox.BackColor = System.Drawing.Color.White
        Me.StreetTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StreetTextBox.Location = New System.Drawing.Point(219, 72)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(188, 27)
        Me.StreetTextBox.TabIndex = 3
        Me.CarRentalToolTip.SetToolTip(Me.StreetTextBox, "Enter the customer'sstreet address.")
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameLabel.Location = New System.Drawing.Point(6, 39)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(119, 20)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Customer Name:"
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StreetLabel.Location = New System.Drawing.Point(6, 77)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(108, 20)
        Me.StreetLabel.TabIndex = 2
        Me.StreetLabel.Text = "Street Address:"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CityLabel.Location = New System.Drawing.Point(6, 115)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(37, 20)
        Me.CityLabel.TabIndex = 4
        Me.CityLabel.Text = "City:"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StateLabel.Location = New System.Drawing.Point(6, 153)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(46, 20)
        Me.StateLabel.TabIndex = 6
        Me.StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ZipLabel.Location = New System.Drawing.Point(6, 191)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(73, 20)
        Me.ZipLabel.TabIndex = 8
        Me.ZipLabel.Text = "Zip Code:"
        '
        'StartingOdometerLabel
        '
        Me.StartingOdometerLabel.AutoSize = True
        Me.StartingOdometerLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartingOdometerLabel.Location = New System.Drawing.Point(6, 229)
        Me.StartingOdometerLabel.Name = "StartingOdometerLabel"
        Me.StartingOdometerLabel.Size = New System.Drawing.Size(195, 20)
        Me.StartingOdometerLabel.TabIndex = 10
        Me.StartingOdometerLabel.Text = "Starting Odometer Reading:"
        '
        'EndingOdometerLabel
        '
        Me.EndingOdometerLabel.AutoSize = True
        Me.EndingOdometerLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EndingOdometerLabel.Location = New System.Drawing.Point(6, 267)
        Me.EndingOdometerLabel.Name = "EndingOdometerLabel"
        Me.EndingOdometerLabel.Size = New System.Drawing.Size(189, 20)
        Me.EndingOdometerLabel.TabIndex = 12
        Me.EndingOdometerLabel.Text = "Ending Odometer Reading:"
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DaysLabel.Location = New System.Drawing.Point(6, 305)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(95, 20)
        Me.DaysLabel.TabIndex = 14
        Me.DaysLabel.Text = "Days Rented:"
        '
        'DiscountsGroupBox
        '
        Me.DiscountsGroupBox.Controls.Add(Me.SeniorCheckBox)
        Me.DiscountsGroupBox.Controls.Add(Me.AAACheckBox)
        Me.DiscountsGroupBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DiscountsGroupBox.Location = New System.Drawing.Point(448, 168)
        Me.DiscountsGroupBox.Name = "DiscountsGroupBox"
        Me.DiscountsGroupBox.Size = New System.Drawing.Size(401, 121)
        Me.DiscountsGroupBox.TabIndex = 2
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
        Me.CarRentalToolTip.SetToolTip(Me.SeniorCheckBox, "Check if the customer is at least 65 years of age.")
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
        Me.CarRentalToolTip.SetToolTip(Me.AAACheckBox, "Check if the customer is a AAA member.")
        Me.AAACheckBox.UseVisualStyleBackColor = True
        '
        'OdometerTypeGroupBox
        '
        Me.OdometerTypeGroupBox.Controls.Add(Me.KilometersRadioButton)
        Me.OdometerTypeGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.OdometerTypeGroupBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OdometerTypeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OdometerTypeGroupBox.Location = New System.Drawing.Point(448, 41)
        Me.OdometerTypeGroupBox.Name = "OdometerTypeGroupBox"
        Me.OdometerTypeGroupBox.Size = New System.Drawing.Size(401, 121)
        Me.OdometerTypeGroupBox.TabIndex = 1
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
        Me.CarRentalToolTip.SetToolTip(Me.KilometersRadioButton, "Check if odometer is shown in kilometers.")
        Me.KilometersRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Checked = True
        Me.MilesRadioButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MilesRadioButton.Location = New System.Drawing.Point(31, 36)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(65, 24)
        Me.MilesRadioButton.TabIndex = 0
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.CarRentalToolTip.SetToolTip(Me.MilesRadioButton, "Check if odometer is shown in miles.")
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
        Me.RentalInfoGroupBox.Location = New System.Drawing.Point(12, 41)
        Me.RentalInfoGroupBox.Name = "RentalInfoGroupBox"
        Me.RentalInfoGroupBox.Size = New System.Drawing.Size(420, 343)
        Me.RentalInfoGroupBox.TabIndex = 0
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
        Me.CalculatedTotalGroupBox.Location = New System.Drawing.Point(448, 295)
        Me.CalculatedTotalGroupBox.Name = "CalculatedTotalGroupBox"
        Me.CalculatedTotalGroupBox.Size = New System.Drawing.Size(401, 221)
        Me.CalculatedTotalGroupBox.TabIndex = 3
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
        Me.DistanceDrivenLabel.TabIndex = 0
        Me.DistanceDrivenLabel.Text = "Distance Driven In Miles:"
        '
        'DistanceDrivenTextBox
        '
        Me.DistanceDrivenTextBox.BackColor = System.Drawing.Color.White
        Me.DistanceDrivenTextBox.Enabled = False
        Me.DistanceDrivenTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DistanceDrivenTextBox.Location = New System.Drawing.Point(224, 26)
        Me.DistanceDrivenTextBox.Name = "DistanceDrivenTextBox"
        Me.DistanceDrivenTextBox.Size = New System.Drawing.Size(160, 27)
        Me.DistanceDrivenTextBox.TabIndex = 1
        Me.DistanceDrivenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalChargeTextBox
        '
        Me.TotalChargeTextBox.BackColor = System.Drawing.Color.White
        Me.TotalChargeTextBox.Enabled = False
        Me.TotalChargeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalChargeTextBox.Location = New System.Drawing.Point(224, 178)
        Me.TotalChargeTextBox.Name = "TotalChargeTextBox"
        Me.TotalChargeTextBox.Size = New System.Drawing.Size(160, 27)
        Me.TotalChargeTextBox.TabIndex = 9
        Me.TotalChargeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalChargeLabel
        '
        Me.TotalChargeLabel.AutoSize = True
        Me.TotalChargeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalChargeLabel.Location = New System.Drawing.Point(11, 183)
        Me.TotalChargeLabel.Name = "TotalChargeLabel"
        Me.TotalChargeLabel.Size = New System.Drawing.Size(96, 20)
        Me.TotalChargeLabel.TabIndex = 8
        Me.TotalChargeLabel.Text = "Total Charge:"
        '
        'AmountDiscountedTextBox
        '
        Me.AmountDiscountedTextBox.BackColor = System.Drawing.Color.White
        Me.AmountDiscountedTextBox.Enabled = False
        Me.AmountDiscountedTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountDiscountedTextBox.Location = New System.Drawing.Point(224, 140)
        Me.AmountDiscountedTextBox.Name = "AmountDiscountedTextBox"
        Me.AmountDiscountedTextBox.Size = New System.Drawing.Size(160, 27)
        Me.AmountDiscountedTextBox.TabIndex = 7
        Me.AmountDiscountedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmountDiscountedLabel
        '
        Me.AmountDiscountedLabel.AutoSize = True
        Me.AmountDiscountedLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountDiscountedLabel.Location = New System.Drawing.Point(11, 145)
        Me.AmountDiscountedLabel.Name = "AmountDiscountedLabel"
        Me.AmountDiscountedLabel.Size = New System.Drawing.Size(144, 20)
        Me.AmountDiscountedLabel.TabIndex = 6
        Me.AmountDiscountedLabel.Text = "Amount Discounted:"
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.BackColor = System.Drawing.Color.White
        Me.DayChargeTextBox.Enabled = False
        Me.DayChargeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DayChargeTextBox.Location = New System.Drawing.Point(224, 102)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(160, 27)
        Me.DayChargeTextBox.TabIndex = 5
        Me.DayChargeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DayChargeLabel.Location = New System.Drawing.Point(11, 107)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(171, 20)
        Me.DayChargeLabel.TabIndex = 4
        Me.DayChargeLabel.Text = "Charge For Days Rented:"
        '
        'MilageChargeTextBox
        '
        Me.MilageChargeTextBox.BackColor = System.Drawing.Color.White
        Me.MilageChargeTextBox.Enabled = False
        Me.MilageChargeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MilageChargeTextBox.Location = New System.Drawing.Point(224, 64)
        Me.MilageChargeTextBox.Name = "MilageChargeTextBox"
        Me.MilageChargeTextBox.Size = New System.Drawing.Size(160, 27)
        Me.MilageChargeTextBox.TabIndex = 3
        Me.MilageChargeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MilageChargeLabel
        '
        Me.MilageChargeLabel.AutoSize = True
        Me.MilageChargeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MilageChargeLabel.Location = New System.Drawing.Point(11, 69)
        Me.MilageChargeLabel.Name = "MilageChargeLabel"
        Me.MilageChargeLabel.Size = New System.Drawing.Size(109, 20)
        Me.MilageChargeLabel.TabIndex = 2
        Me.MilageChargeLabel.Text = "Milage Charge:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CalculateButton.Location = New System.Drawing.Point(12, 390)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(201, 55)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "Calculate &Total"
        Me.CarRentalToolTip.SetToolTip(Me.CalculateButton, "Click to Calculate the total charges.")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SummaryButton.Location = New System.Drawing.Point(231, 390)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(201, 55)
        Me.SummaryButton.TabIndex = 5
        Me.SummaryButton.Text = "Detailed &Summary"
        Me.CarRentalToolTip.SetToolTip(Me.SummaryButton, "Click to print a detailed summary of the total charges and usage for the day.")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(231, 460)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(201, 55)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "&Exit"
        Me.CarRentalToolTip.SetToolTip(Me.ExitButton, "Click to exit the application.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.Location = New System.Drawing.Point(12, 460)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(201, 55)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "&Clear"
        Me.CarRentalToolTip.SetToolTip(Me.ClearButton, "Click to clear all fields.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CarRentalMenuStrip
        '
        Me.CarRentalMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CarRentalMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.CarRentalMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.CarRentalMenuStrip.Name = "CarRentalMenuStrip"
        Me.CarRentalMenuStrip.Size = New System.Drawing.Size(866, 28)
        Me.CarRentalMenuStrip.TabIndex = 8
        Me.CarRentalMenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CarRentalForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(866, 528)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.CalculatedTotalGroupBox)
        Me.Controls.Add(Me.RentalInfoGroupBox)
        Me.Controls.Add(Me.OdometerTypeGroupBox)
        Me.Controls.Add(Me.DiscountsGroupBox)
        Me.Controls.Add(Me.CarRentalMenuStrip)
        Me.MainMenuStrip = Me.CarRentalMenuStrip
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
        Me.CarRentalMenuStrip.ResumeLayout(False)
        Me.CarRentalMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents CarRentalToolTip As ToolTip
    Friend WithEvents CarRentalMenuStrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
