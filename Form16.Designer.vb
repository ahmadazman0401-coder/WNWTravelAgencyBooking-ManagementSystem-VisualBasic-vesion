<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnPackages = New System.Windows.Forms.Button()
        Me.btnBookings = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Wnw_travel_dbDataSet1 = New CSC301__TRAVEL_AGENCY_SYSTEM_.wnw_travel_dbDataSet1()
        Me.TblPackagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPackagesTableAdapter = New CSC301__TRAVEL_AGENCY_SYSTEM_.wnw_travel_dbDataSet1TableAdapters.tblPackagesTableAdapter()
        Me.TableAdapterManager = New CSC301__TRAVEL_AGENCY_SYSTEM_.wnw_travel_dbDataSet1TableAdapters.TableAdapterManager()
        Me.TblPackagesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblPackagesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblPackagesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wnw_travel_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPackagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPackagesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblPackagesBindingNavigator.SuspendLayout()
        CType(Me.TblPackagesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.DimGray
        Me.btnLogout.Location = New System.Drawing.Point(6, 616)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(115, 35)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Admin Panel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(63, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "TRAVEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "WNW"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PictureBox3.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.Screenshot_2026_01_05_002759
        Me.PictureBox3.Location = New System.Drawing.Point(19, 622)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PictureBox2.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.photo_2025_01_21_00_20_58_removebg_preview1
        Me.PictureBox2.Location = New System.Drawing.Point(16, 23)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.WNW_Admin_page_in__use
        Me.PictureBox1.Location = New System.Drawing.Point(0, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 651)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.DimGray
        Me.btnUsers.Location = New System.Drawing.Point(20, 288)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(207, 35)
        Me.btnUsers.TabIndex = 19
        Me.btnUsers.Text = "      Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnPackages
        '
        Me.btnPackages.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnPackages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPackages.FlatAppearance.BorderSize = 0
        Me.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPackages.ForeColor = System.Drawing.Color.White
        Me.btnPackages.Location = New System.Drawing.Point(20, 240)
        Me.btnPackages.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPackages.Name = "btnPackages"
        Me.btnPackages.Size = New System.Drawing.Size(207, 35)
        Me.btnPackages.TabIndex = 18
        Me.btnPackages.Text = "      Packages"
        Me.btnPackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPackages.UseVisualStyleBackColor = False
        '
        'btnBookings
        '
        Me.btnBookings.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnBookings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookings.FlatAppearance.BorderSize = 0
        Me.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookings.ForeColor = System.Drawing.Color.DimGray
        Me.btnBookings.Location = New System.Drawing.Point(20, 184)
        Me.btnBookings.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBookings.Name = "btnBookings"
        Me.btnBookings.Size = New System.Drawing.Size(207, 35)
        Me.btnBookings.TabIndex = 17
        Me.btnBookings.Text = "      Bookings"
        Me.btnBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookings.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.DimGray
        Me.btnDashboard.Location = New System.Drawing.Point(20, 134)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(207, 35)
        Me.btnDashboard.TabIndex = 16
        Me.btnDashboard.Text = "      Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.Screenshot_2026_01_05_004127
        Me.PictureBox5.Location = New System.Drawing.Point(29, 193)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(18, 16)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.Screenshot_2026_01_05_004154
        Me.PictureBox7.Location = New System.Drawing.Point(29, 297)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(18, 16)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 21
        Me.PictureBox7.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.Screenshot_2026_01_05_004205
        Me.PictureBox4.Location = New System.Drawing.Point(29, 142)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(18, 17)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.Screenshot_2026_01_05_004105
        Me.PictureBox6.Location = New System.Drawing.Point(29, 247)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(18, 17)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 24
        Me.PictureBox6.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(275, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Manage your travel package offerings"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(274, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Travel Packages"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.CSC301__TRAVEL_AGENCY_SYSTEM_.My.Resources.Resources.Screenshot_2026_01_08_083051
        Me.PictureBox8.Location = New System.Drawing.Point(262, 39)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(669, 69)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 26
        Me.PictureBox8.TabStop = False
        '
        'Wnw_travel_dbDataSet1
        '
        Me.Wnw_travel_dbDataSet1.DataSetName = "wnw_travel_dbDataSet1"
        Me.Wnw_travel_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPackagesBindingSource
        '
        Me.TblPackagesBindingSource.DataMember = "tblPackages"
        Me.TblPackagesBindingSource.DataSource = Me.Wnw_travel_dbDataSet1
        '
        'TblPackagesTableAdapter
        '
        Me.TblPackagesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBookingsTableAdapter = Nothing
        Me.TableAdapterManager.tblPackagesTableAdapter = Me.TblPackagesTableAdapter
        Me.TableAdapterManager.tblUsersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CSC301__TRAVEL_AGENCY_SYSTEM_.wnw_travel_dbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPackagesBindingNavigator
        '
        Me.TblPackagesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblPackagesBindingNavigator.BindingSource = Me.TblPackagesBindingSource
        Me.TblPackagesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblPackagesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblPackagesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TblPackagesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblPackagesBindingNavigatorSaveItem})
        Me.TblPackagesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblPackagesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblPackagesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblPackagesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblPackagesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblPackagesBindingNavigator.Name = "TblPackagesBindingNavigator"
        Me.TblPackagesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblPackagesBindingNavigator.Size = New System.Drawing.Size(1155, 27)
        Me.TblPackagesBindingNavigator.TabIndex = 29
        Me.TblPackagesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TblPackagesBindingNavigatorSaveItem
        '
        Me.TblPackagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblPackagesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblPackagesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblPackagesBindingNavigatorSaveItem.Name = "TblPackagesBindingNavigatorSaveItem"
        Me.TblPackagesBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.TblPackagesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblPackagesDataGridView
        '
        Me.TblPackagesDataGridView.AutoGenerateColumns = False
        Me.TblPackagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPackagesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column1, Me.Column2})
        Me.TblPackagesDataGridView.DataSource = Me.TblPackagesBindingSource
        Me.TblPackagesDataGridView.Location = New System.Drawing.Point(262, 112)
        Me.TblPackagesDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TblPackagesDataGridView.Name = "TblPackagesDataGridView"
        Me.TblPackagesDataGridView.RowTemplate.Height = 24
        Me.TblPackagesDataGridView.Size = New System.Drawing.Size(669, 189)
        Me.TblPackagesDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PackageID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PackageID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Destination"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Currency"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Duration"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PackageType"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PackageType"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Update"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Delete"
        Me.Column2.Name = "Column2"
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1155, 664)
        Me.Controls.Add(Me.TblPackagesDataGridView)
        Me.Controls.Add(Me.TblPackagesBindingNavigator)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnPackages)
        Me.Controls.Add(Me.btnBookings)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form16"
        Me.Text = "Form16"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wnw_travel_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPackagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPackagesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblPackagesBindingNavigator.ResumeLayout(False)
        Me.TblPackagesBindingNavigator.PerformLayout()
        CType(Me.TblPackagesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnPackages As Button
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Wnw_travel_dbDataSet1 As wnw_travel_dbDataSet1
    Friend WithEvents TblPackagesBindingSource As BindingSource
    Friend WithEvents TblPackagesTableAdapter As wnw_travel_dbDataSet1TableAdapters.tblPackagesTableAdapter
    Friend WithEvents TableAdapterManager As wnw_travel_dbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TblPackagesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblPackagesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblPackagesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
End Class
