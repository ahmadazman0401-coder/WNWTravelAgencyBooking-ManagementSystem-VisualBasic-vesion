<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.cmbDestination = New System.Windows.Forms.ComboBox()
        Me.TblPackagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WnwtraveldbDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wnw_travel_dbDataSet1 = New CSC301__TRAVEL_AGENCY_SYSTEM_.wnw_travel_dbDataSet1()
        Me.cmbAccomodation = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtElders = New System.Windows.Forms.TextBox()
        Me.txtInfants = New System.Windows.Forms.TextBox()
        Me.txtKids = New System.Windows.Forms.TextBox()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.txtInfantsSeat = New System.Windows.Forms.TextBox()
        Me.txtGroups = New System.Windows.Forms.TextBox()
        Me.TblPackagesTableAdapter = New CSC301__TRAVEL_AGENCY_SYSTEM_.wnw_travel_dbDataSet1TableAdapters.tblPackagesTableAdapter()
        Me.txtassistance = New System.Windows.Forms.TextBox()
        CType(Me.TblPackagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WnwtraveldbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wnw_travel_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(144, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "TRAVEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(144, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 41)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "WNW"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1344, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 31)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "BOOKING"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(551, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(491, 41)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "TRAVEL CONFIRMATION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(683, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 30)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "ADVENTURE TRIP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1199, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 23)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "7"
        '
        'dtpEnd
        '
        Me.dtpEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dtpEnd.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dtpEnd.Location = New System.Drawing.Point(787, 638)
        Me.dtpEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(327, 22)
        Me.dtpEnd.TabIndex = 138
        '
        'dtpStart
        '
        Me.dtpStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dtpStart.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dtpStart.Location = New System.Drawing.Point(361, 638)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(327, 22)
        Me.dtpStart.TabIndex = 137
        '
        'cmbClass
        '
        Me.cmbClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.IntegralHeight = False
        Me.cmbClass.ItemHeight = 16
        Me.cmbClass.Location = New System.Drawing.Point(787, 482)
        Me.cmbClass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(325, 24)
        Me.cmbClass.TabIndex = 136
        '
        'cmbDestination
        '
        Me.cmbDestination.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cmbDestination.DataSource = Me.TblPackagesBindingSource
        Me.cmbDestination.DisplayMember = "Destination"
        Me.cmbDestination.FormattingEnabled = True
        Me.cmbDestination.IntegralHeight = False
        Me.cmbDestination.ItemHeight = 16
        Me.cmbDestination.Location = New System.Drawing.Point(1037, 142)
        Me.cmbDestination.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDestination.Name = "cmbDestination"
        Me.cmbDestination.Size = New System.Drawing.Size(183, 24)
        Me.cmbDestination.TabIndex = 132
        Me.cmbDestination.ValueMember = "Destination"
        '
        'TblPackagesBindingSource
        '
        Me.TblPackagesBindingSource.DataMember = "tblPackages"
        Me.TblPackagesBindingSource.DataSource = Me.WnwtraveldbDataSet1BindingSource
        '
        'WnwtraveldbDataSet1BindingSource
        '
        Me.WnwtraveldbDataSet1BindingSource.DataSource = Me.Wnw_travel_dbDataSet1
        Me.WnwtraveldbDataSet1BindingSource.Position = 0
        '
        'Wnw_travel_dbDataSet1
        '
        Me.Wnw_travel_dbDataSet1.DataSetName = "wnw_travel_dbDataSet1"
        Me.Wnw_travel_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbAccomodation
        '
        Me.cmbAccomodation.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cmbAccomodation.FormattingEnabled = True
        Me.cmbAccomodation.IntegralHeight = False
        Me.cmbAccomodation.ItemHeight = 16
        Me.cmbAccomodation.Location = New System.Drawing.Point(363, 482)
        Me.cmbAccomodation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbAccomodation.Name = "cmbAccomodation"
        Me.cmbAccomodation.Size = New System.Drawing.Size(325, 24)
        Me.cmbAccomodation.TabIndex = 130
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(783, 603)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 22)
        Me.Label19.TabIndex = 126
        Me.Label19.Text = "End Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(357, 603)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 22)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Start Date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(357, 534)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 22)
        Me.Label17.TabIndex = 124
        Me.Label17.Text = "Rooms/Groups"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(783, 458)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 22)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Class"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(783, 382)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 22)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Elders (65+ Y/O)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(357, 458)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 22)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Accomodation"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(783, 308)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(170, 22)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "Infants (under 2 Y/O)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(783, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 22)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "Adults"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(357, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 22)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Infant Seat? (Yes/No)"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(361, 708)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 34)
        Me.btnBack.TabIndex = 117
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(1041, 706)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(179, 34)
        Me.btnConfirm.TabIndex = 116
        Me.btnConfirm.Text = "CONFIRM BOOKING"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(357, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 22)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Kids (2-12 Y/O)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(357, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 22)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Travel Assistance? (Yes/No)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(360, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 23)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "Days"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(360, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 23)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Destination"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.Screenshot_2026_01_01_181031
        Me.PictureBox2.Location = New System.Drawing.Point(319, 98)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(951, 676)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.photo_2025_01_21_00_20_58_removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtElders
        '
        Me.txtElders.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtElders.Location = New System.Drawing.Point(787, 418)
        Me.txtElders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtElders.Name = "txtElders"
        Me.txtElders.Size = New System.Drawing.Size(313, 22)
        Me.txtElders.TabIndex = 140
        '
        'txtInfants
        '
        Me.txtInfants.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtInfants.Location = New System.Drawing.Point(787, 342)
        Me.txtInfants.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInfants.Name = "txtInfants"
        Me.txtInfants.Size = New System.Drawing.Size(313, 22)
        Me.txtInfants.TabIndex = 141
        '
        'txtKids
        '
        Me.txtKids.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtKids.Location = New System.Drawing.Point(363, 342)
        Me.txtKids.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKids.Name = "txtKids"
        Me.txtKids.Size = New System.Drawing.Size(313, 22)
        Me.txtKids.TabIndex = 142
        '
        'txtAdults
        '
        Me.txtAdults.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtAdults.Location = New System.Drawing.Point(787, 266)
        Me.txtAdults.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.Size = New System.Drawing.Size(313, 22)
        Me.txtAdults.TabIndex = 143
        '
        'txtInfantsSeat
        '
        Me.txtInfantsSeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtInfantsSeat.Location = New System.Drawing.Point(364, 418)
        Me.txtInfantsSeat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInfantsSeat.Name = "txtInfantsSeat"
        Me.txtInfantsSeat.Size = New System.Drawing.Size(313, 22)
        Me.txtInfantsSeat.TabIndex = 144
        '
        'txtGroups
        '
        Me.txtGroups.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtGroups.Location = New System.Drawing.Point(361, 559)
        Me.txtGroups.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGroups.Name = "txtGroups"
        Me.txtGroups.Size = New System.Drawing.Size(327, 22)
        Me.txtGroups.TabIndex = 145
        '
        'TblPackagesTableAdapter
        '
        Me.TblPackagesTableAdapter.ClearBeforeFill = True
        '
        'txtassistance
        '
        Me.txtassistance.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtassistance.Location = New System.Drawing.Point(364, 266)
        Me.txtassistance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtassistance.Name = "txtassistance"
        Me.txtassistance.Size = New System.Drawing.Size(313, 22)
        Me.txtassistance.TabIndex = 146
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1555, 786)
        Me.Controls.Add(Me.txtassistance)
        Me.Controls.Add(Me.txtGroups)
        Me.Controls.Add(Me.txtInfantsSeat)
        Me.Controls.Add(Me.txtAdults)
        Me.Controls.Add(Me.txtKids)
        Me.Controls.Add(Me.txtInfants)
        Me.Controls.Add(Me.txtElders)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.cmbDestination)
        Me.Controls.Add(Me.cmbAccomodation)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form8"
        Me.Text = "Adventure"
        CType(Me.TblPackagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WnwtraveldbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wnw_travel_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents cmbDestination As ComboBox
    Friend WithEvents cmbAccomodation As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtElders As TextBox
    Friend WithEvents txtInfants As TextBox
    Friend WithEvents txtKids As TextBox
    Friend WithEvents txtAdults As TextBox
    Friend WithEvents txtInfantsSeat As TextBox
    Friend WithEvents txtGroups As TextBox
    Friend WithEvents WnwtraveldbDataSet1BindingSource As BindingSource
    Friend WithEvents Wnw_travel_dbDataSet1 As wnw_travel_dbDataSet1
    Friend WithEvents TblPackagesBindingSource As BindingSource
    Friend WithEvents TblPackagesTableAdapter As wnw_travel_dbDataSet1TableAdapters.tblPackagesTableAdapter
    Friend WithEvents txtassistance As TextBox
End Class
