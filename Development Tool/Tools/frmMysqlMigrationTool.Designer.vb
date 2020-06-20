<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMysqlMigrationTool
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdConnectionSetup = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.DatagridSetup = New System.Windows.Forms.DataGridView()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.txtSourceTable = New System.Windows.Forms.ComboBox()
        Me.txtDestinationTable = New System.Windows.Forms.ComboBox()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DatagridSource = New System.Windows.Forms.DataGridView()
        Me.txtCustomQuery = New System.Windows.Forms.RichTextBox()
        Me.DatagridDestination = New System.Windows.Forms.DataGridView()
        Me.lblSourceDatabase = New System.Windows.Forms.Label()
        Me.lblDestinationDatabase = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdBackupCurrentSetup = New System.Windows.Forms.Button()
        Me.cmdCaptureDatabase = New System.Windows.Forms.Button()
        Me.cmdResetCurrentSetup = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ckDestination = New System.Windows.Forms.CheckBox()
        Me.ckSource = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.cmdStartMigration = New System.Windows.Forms.Button()
        Me.DataGridMigrationSummary = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtRows = New System.Windows.Forms.Label()
        CType(Me.DatagridSetup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DatagridSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridDestination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridMigrationSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdConnectionSetup
        '
        Me.cmdConnectionSetup.Location = New System.Drawing.Point(41, 113)
        Me.cmdConnectionSetup.Name = "cmdConnectionSetup"
        Me.cmdConnectionSetup.Size = New System.Drawing.Size(161, 28)
        Me.cmdConnectionSetup.TabIndex = 6
        Me.cmdConnectionSetup.Text = "Connection Setup"
        Me.cmdConnectionSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdConnectionSetup.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.Label4.Location = New System.Drawing.Point(36, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 30)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Server Information"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.ForeColor = System.Drawing.Color.Green
        Me.lblSource.Location = New System.Drawing.Point(41, 58)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(96, 13)
        Me.lblSource.TabIndex = 12
        Me.lblSource.Text = "Source server host"
        '
        'DatagridSetup
        '
        Me.DatagridSetup.AllowUserToAddRows = False
        Me.DatagridSetup.AllowUserToDeleteRows = False
        Me.DatagridSetup.AllowUserToResizeColumns = False
        Me.DatagridSetup.AllowUserToResizeRows = False
        Me.DatagridSetup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridSetup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DatagridSetup.BackgroundColor = System.Drawing.Color.White
        Me.DatagridSetup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DatagridSetup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridSetup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridSetup.DefaultCellStyle = DataGridViewCellStyle18
        Me.DatagridSetup.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridSetup.Location = New System.Drawing.Point(577, 50)
        Me.DatagridSetup.Margin = New System.Windows.Forms.Padding(2)
        Me.DatagridSetup.MultiSelect = False
        Me.DatagridSetup.Name = "DatagridSetup"
        Me.DatagridSetup.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridSetup.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DatagridSetup.RowHeadersVisible = False
        Me.DatagridSetup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        Me.DatagridSetup.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DatagridSetup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridSetup.Size = New System.Drawing.Size(388, 385)
        Me.DatagridSetup.TabIndex = 381
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(500, 162)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(72, 28)
        Me.cmdNext.TabIndex = 382
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'txtSourceTable
        '
        Me.txtSourceTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSourceTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtSourceTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSourceTable.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSourceTable.ForeColor = System.Drawing.Color.Black
        Me.txtSourceTable.FormattingEnabled = True
        Me.txtSourceTable.ItemHeight = 13
        Me.txtSourceTable.Location = New System.Drawing.Point(6, 25)
        Me.txtSourceTable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSourceTable.Name = "txtSourceTable"
        Me.txtSourceTable.Size = New System.Drawing.Size(217, 21)
        Me.txtSourceTable.TabIndex = 383
        '
        'txtDestinationTable
        '
        Me.txtDestinationTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDestinationTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDestinationTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDestinationTable.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDestinationTable.ForeColor = System.Drawing.Color.Black
        Me.txtDestinationTable.FormattingEnabled = True
        Me.txtDestinationTable.ItemHeight = 13
        Me.txtDestinationTable.Location = New System.Drawing.Point(250, 25)
        Me.txtDestinationTable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDestinationTable.Name = "txtDestinationTable"
        Me.txtDestinationTable.Size = New System.Drawing.Size(222, 21)
        Me.txtDestinationTable.TabIndex = 384
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(500, 191)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(72, 28)
        Me.cmdBack.TabIndex = 386
        Me.cmdBack.Text = "<"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DatagridDestination)
        Me.SplitContainer1.Size = New System.Drawing.Size(488, 361)
        Me.SplitContainer1.SplitterDistance = 240
        Me.SplitContainer1.TabIndex = 387
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DatagridSource)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomQuery)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(240, 361)
        Me.SplitContainer2.SplitterDistance = 249
        Me.SplitContainer2.TabIndex = 396
        '
        'DatagridSource
        '
        Me.DatagridSource.AllowUserToAddRows = False
        Me.DatagridSource.AllowUserToDeleteRows = False
        Me.DatagridSource.AllowUserToResizeColumns = False
        Me.DatagridSource.AllowUserToResizeRows = False
        Me.DatagridSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridSource.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DatagridSource.BackgroundColor = System.Drawing.Color.White
        Me.DatagridSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DatagridSource.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridSource.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.DatagridSource.ColumnHeadersVisible = False
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridSource.DefaultCellStyle = DataGridViewCellStyle22
        Me.DatagridSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridSource.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridSource.Location = New System.Drawing.Point(0, 0)
        Me.DatagridSource.Margin = New System.Windows.Forms.Padding(2)
        Me.DatagridSource.MultiSelect = False
        Me.DatagridSource.Name = "DatagridSource"
        Me.DatagridSource.ReadOnly = True
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridSource.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DatagridSource.RowHeadersVisible = False
        Me.DatagridSource.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.DatagridSource.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DatagridSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridSource.Size = New System.Drawing.Size(240, 361)
        Me.DatagridSource.TabIndex = 382
        '
        'txtCustomQuery
        '
        Me.txtCustomQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustomQuery.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomQuery.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomQuery.Name = "txtCustomQuery"
        Me.txtCustomQuery.Size = New System.Drawing.Size(150, 46)
        Me.txtCustomQuery.TabIndex = 382
        Me.txtCustomQuery.Text = ""
        '
        'DatagridDestination
        '
        Me.DatagridDestination.AllowUserToAddRows = False
        Me.DatagridDestination.AllowUserToDeleteRows = False
        Me.DatagridDestination.AllowUserToResizeColumns = False
        Me.DatagridDestination.AllowUserToResizeRows = False
        Me.DatagridDestination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridDestination.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DatagridDestination.BackgroundColor = System.Drawing.Color.White
        Me.DatagridDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DatagridDestination.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridDestination.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.DatagridDestination.ColumnHeadersVisible = False
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridDestination.DefaultCellStyle = DataGridViewCellStyle26
        Me.DatagridDestination.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridDestination.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridDestination.Location = New System.Drawing.Point(0, 0)
        Me.DatagridDestination.Margin = New System.Windows.Forms.Padding(2)
        Me.DatagridDestination.MultiSelect = False
        Me.DatagridDestination.Name = "DatagridDestination"
        Me.DatagridDestination.ReadOnly = True
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridDestination.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.DatagridDestination.RowHeadersVisible = False
        Me.DatagridDestination.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White
        Me.DatagridDestination.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.DatagridDestination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridDestination.Size = New System.Drawing.Size(244, 361)
        Me.DatagridDestination.TabIndex = 381
        '
        'lblSourceDatabase
        '
        Me.lblSourceDatabase.AutoSize = True
        Me.lblSourceDatabase.Location = New System.Drawing.Point(41, 76)
        Me.lblSourceDatabase.Name = "lblSourceDatabase"
        Me.lblSourceDatabase.Size = New System.Drawing.Size(88, 13)
        Me.lblSourceDatabase.TabIndex = 388
        Me.lblSourceDatabase.Text = "Database source"
        '
        'lblDestinationDatabase
        '
        Me.lblDestinationDatabase.AutoSize = True
        Me.lblDestinationDatabase.Location = New System.Drawing.Point(41, 94)
        Me.lblDestinationDatabase.Name = "lblDestinationDatabase"
        Me.lblDestinationDatabase.Size = New System.Drawing.Size(107, 13)
        Me.lblDestinationDatabase.TabIndex = 389
        Me.lblDestinationDatabase.Text = "Database destination"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(983, 467)
        Me.TabControl1.TabIndex = 390
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.cmdBackupCurrentSetup)
        Me.TabPage1.Controls.Add(Me.cmdCaptureDatabase)
        Me.TabPage1.Controls.Add(Me.cmdResetCurrentSetup)
        Me.TabPage1.Controls.Add(Me.lblDestinationDatabase)
        Me.TabPage1.Controls.Add(Me.cmdConnectionSetup)
        Me.TabPage1.Controls.Add(Me.lblSourceDatabase)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblSource)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(975, 441)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Connection Setup"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 41)
        Me.Button1.TabIndex = 393
        Me.Button1.Text = "Delete all data on target database"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdBackupCurrentSetup
        '
        Me.cmdBackupCurrentSetup.Location = New System.Drawing.Point(203, 142)
        Me.cmdBackupCurrentSetup.Name = "cmdBackupCurrentSetup"
        Me.cmdBackupCurrentSetup.Size = New System.Drawing.Size(161, 28)
        Me.cmdBackupCurrentSetup.TabIndex = 392
        Me.cmdBackupCurrentSetup.Text = "Backup Current Setup"
        Me.cmdBackupCurrentSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBackupCurrentSetup.UseVisualStyleBackColor = True
        '
        'cmdCaptureDatabase
        '
        Me.cmdCaptureDatabase.Location = New System.Drawing.Point(203, 113)
        Me.cmdCaptureDatabase.Name = "cmdCaptureDatabase"
        Me.cmdCaptureDatabase.Size = New System.Drawing.Size(161, 28)
        Me.cmdCaptureDatabase.TabIndex = 391
        Me.cmdCaptureDatabase.Text = "Capture Database"
        Me.cmdCaptureDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCaptureDatabase.UseVisualStyleBackColor = True
        '
        'cmdResetCurrentSetup
        '
        Me.cmdResetCurrentSetup.Location = New System.Drawing.Point(41, 142)
        Me.cmdResetCurrentSetup.Name = "cmdResetCurrentSetup"
        Me.cmdResetCurrentSetup.Size = New System.Drawing.Size(161, 28)
        Me.cmdResetCurrentSetup.TabIndex = 390
        Me.cmdResetCurrentSetup.Text = "Reset Current Setup"
        Me.cmdResetCurrentSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdResetCurrentSetup.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtRows)
        Me.TabPage2.Controls.Add(Me.CheckBox1)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.ckDestination)
        Me.TabPage2.Controls.Add(Me.ckSource)
        Me.TabPage2.Controls.Add(Me.cmdSave)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Controls.Add(Me.DatagridSetup)
        Me.TabPage2.Controls.Add(Me.cmdBack)
        Me.TabPage2.Controls.Add(Me.cmdNext)
        Me.TabPage2.Controls.Add(Me.txtSourceTable)
        Me.TabPage2.Controls.Add(Me.txtDestinationTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(975, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Migration Setup"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 416)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox1.TabIndex = 396
        Me.CheckBox1.Text = "Custom Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Development_Tool.My.Resources.Resources.cross
        Me.Button3.Location = New System.Drawing.Point(473, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 21)
        Me.Button3.TabIndex = 395
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Development_Tool.My.Resources.Resources.cross
        Me.Button2.Location = New System.Drawing.Point(224, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 21)
        Me.Button2.TabIndex = 394
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ckDestination
        '
        Me.ckDestination.AutoSize = True
        Me.ckDestination.Location = New System.Drawing.Point(250, 7)
        Me.ckDestination.Name = "ckDestination"
        Me.ckDestination.Size = New System.Drawing.Size(63, 17)
        Me.ckDestination.TabIndex = 393
        Me.ckDestination.Text = "View All"
        Me.ckDestination.UseVisualStyleBackColor = True
        '
        'ckSource
        '
        Me.ckSource.AutoSize = True
        Me.ckSource.Location = New System.Drawing.Point(9, 6)
        Me.ckSource.Name = "ckSource"
        Me.ckSource.Size = New System.Drawing.Size(63, 17)
        Me.ckSource.TabIndex = 392
        Me.ckSource.Text = "View All"
        Me.ckSource.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(851, 17)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(114, 28)
        Me.cmdSave.TabIndex = 391
        Me.cmdSave.Text = "Save Setup"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(652, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 13)
        Me.Label1.TabIndex = 390
        Me.Label1.Text = "List of pre-configured fields for migration "
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ProgressBar1)
        Me.TabPage3.Controls.Add(Me.cmdStartMigration)
        Me.TabPage3.Controls.Add(Me.DataGridMigrationSummary)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(975, 441)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Migration Setup Summary"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 5)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(513, 26)
        Me.ProgressBar1.TabIndex = 393
        '
        'cmdStartMigration
        '
        Me.cmdStartMigration.Location = New System.Drawing.Point(522, 4)
        Me.cmdStartMigration.Name = "cmdStartMigration"
        Me.cmdStartMigration.Size = New System.Drawing.Size(203, 28)
        Me.cmdStartMigration.TabIndex = 392
        Me.cmdStartMigration.Text = "> Start Migration"
        Me.cmdStartMigration.UseVisualStyleBackColor = True
        '
        'DataGridMigrationSummary
        '
        Me.DataGridMigrationSummary.AllowUserToAddRows = False
        Me.DataGridMigrationSummary.AllowUserToDeleteRows = False
        Me.DataGridMigrationSummary.AllowUserToResizeColumns = False
        Me.DataGridMigrationSummary.AllowUserToResizeRows = False
        Me.DataGridMigrationSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridMigrationSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridMigrationSummary.BackgroundColor = System.Drawing.Color.White
        Me.DataGridMigrationSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridMigrationSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMigrationSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridMigrationSummary.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridMigrationSummary.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridMigrationSummary.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridMigrationSummary.Location = New System.Drawing.Point(6, 35)
        Me.DataGridMigrationSummary.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridMigrationSummary.Name = "DataGridMigrationSummary"
        Me.DataGridMigrationSummary.ReadOnly = True
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMigrationSummary.RowHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridMigrationSummary.RowHeadersVisible = False
        Me.DataGridMigrationSummary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridMigrationSummary.RowsDefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridMigrationSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMigrationSummary.Size = New System.Drawing.Size(962, 398)
        Me.DataGridMigrationSummary.TabIndex = 382
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteRowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 26)
        '
        'DeleteRowToolStripMenuItem
        '
        Me.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem"
        Me.DeleteRowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteRowToolStripMenuItem.Text = "Delete Row"
        '
        'txtRows
        '
        Me.txtRows.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRows.Location = New System.Drawing.Point(243, 413)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(252, 23)
        Me.txtRows.TabIndex = 397
        Me.txtRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMysqlMigrationTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 467)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "frmMysqlMigrationTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mysql Migration Tool"
        CType(Me.DatagridSetup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DatagridSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridDestination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridMigrationSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConnectionSetup As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents DatagridSetup As System.Windows.Forms.DataGridView
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents txtSourceTable As System.Windows.Forms.ComboBox
    Friend WithEvents txtDestinationTable As System.Windows.Forms.ComboBox
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DatagridSource As System.Windows.Forms.DataGridView
    Friend WithEvents DatagridDestination As System.Windows.Forms.DataGridView
    Friend WithEvents lblSourceDatabase As System.Windows.Forms.Label
    Friend WithEvents lblDestinationDatabase As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdResetCurrentSetup As System.Windows.Forms.Button
    Friend WithEvents ckDestination As System.Windows.Forms.CheckBox
    Friend WithEvents ckSource As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cmdStartMigration As System.Windows.Forms.Button
    Friend WithEvents DataGridMigrationSummary As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdCaptureDatabase As System.Windows.Forms.Button
    Friend WithEvents cmdBackupCurrentSetup As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtCustomQuery As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtRows As System.Windows.Forms.Label
End Class
