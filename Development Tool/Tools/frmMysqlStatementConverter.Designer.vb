<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMysqlStatementConverter
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
        Me.rad_insert = New System.Windows.Forms.RadioButton()
        Me.rad_update = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtspace = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtqueryFrom = New System.Windows.Forms.RichTextBox()
        Me.txtConvertedQuery = New System.Windows.Forms.RichTextBox()
        Me.rad_insertselect = New System.Windows.Forms.RadioButton()
        Me.tabIndertSelectDB = New System.Windows.Forms.RadioButton()
        Me.radSelectReader = New System.Windows.Forms.RadioButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtReader = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad_insert
        '
        Me.rad_insert.AutoSize = True
        Me.rad_insert.Checked = True
        Me.rad_insert.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rad_insert.Location = New System.Drawing.Point(21, 12)
        Me.rad_insert.Name = "rad_insert"
        Me.rad_insert.Size = New System.Drawing.Size(104, 23)
        Me.rad_insert.TabIndex = 3
        Me.rad_insert.TabStop = True
        Me.rad_insert.Text = "Insert Query"
        Me.rad_insert.UseVisualStyleBackColor = True
        '
        'rad_update
        '
        Me.rad_update.AutoSize = True
        Me.rad_update.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rad_update.Location = New System.Drawing.Point(21, 35)
        Me.rad_update.Name = "rad_update"
        Me.rad_update.Size = New System.Drawing.Size(114, 23)
        Me.rad_update.TabIndex = 4
        Me.rad_update.Text = "Update Query"
        Me.rad_update.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(838, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 58)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtspace
        '
        Me.txtspace.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtspace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtspace.Location = New System.Drawing.Point(443, 7)
        Me.txtspace.Name = "txtspace"
        Me.txtspace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtspace.Size = New System.Drawing.Size(38, 25)
        Me.txtspace.TabIndex = 7
        Me.txtspace.Text = "30"
        Me.txtspace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(370, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Set Space"
        '
        'txtPrefix
        '
        Me.txtPrefix.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPrefix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPrefix.Location = New System.Drawing.Point(443, 34)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrefix.Size = New System.Drawing.Size(38, 25)
        Me.txtPrefix.TabIndex = 9
        Me.txtPrefix.Text = "txt"
        Me.txtPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(345, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Textbox Prefix"
        '
        'txtqueryFrom
        '
        Me.txtqueryFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtqueryFrom.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtqueryFrom.Location = New System.Drawing.Point(0, 0)
        Me.txtqueryFrom.Name = "txtqueryFrom"
        Me.txtqueryFrom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtqueryFrom.Size = New System.Drawing.Size(942, 237)
        Me.txtqueryFrom.TabIndex = 11
        Me.txtqueryFrom.Text = ""
        '
        'txtConvertedQuery
        '
        Me.txtConvertedQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConvertedQuery.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtConvertedQuery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtConvertedQuery.Location = New System.Drawing.Point(0, 0)
        Me.txtConvertedQuery.Name = "txtConvertedQuery"
        Me.txtConvertedQuery.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtConvertedQuery.Size = New System.Drawing.Size(942, 265)
        Me.txtConvertedQuery.TabIndex = 12
        Me.txtConvertedQuery.Text = ""
        '
        'rad_insertselect
        '
        Me.rad_insertselect.AutoSize = True
        Me.rad_insertselect.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rad_insertselect.Location = New System.Drawing.Point(137, 11)
        Me.rad_insertselect.Name = "rad_insertselect"
        Me.rad_insertselect.Size = New System.Drawing.Size(101, 23)
        Me.rad_insertselect.TabIndex = 13
        Me.rad_insertselect.Text = "Insert Select"
        Me.rad_insertselect.UseVisualStyleBackColor = True
        '
        'tabIndertSelectDB
        '
        Me.tabIndertSelectDB.AutoSize = True
        Me.tabIndertSelectDB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabIndertSelectDB.Location = New System.Drawing.Point(137, 34)
        Me.tabIndertSelectDB.Name = "tabIndertSelectDB"
        Me.tabIndertSelectDB.Size = New System.Drawing.Size(123, 23)
        Me.tabIndertSelectDB.TabIndex = 14
        Me.tabIndertSelectDB.Text = "Insert Select DB"
        Me.tabIndertSelectDB.UseVisualStyleBackColor = True
        '
        'radSelectReader
        '
        Me.radSelectReader.AutoSize = True
        Me.radSelectReader.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.radSelectReader.Location = New System.Drawing.Point(251, 11)
        Me.radSelectReader.Name = "radSelectReader"
        Me.radSelectReader.Size = New System.Drawing.Size(108, 23)
        Me.radSelectReader.TabIndex = 15
        Me.radSelectReader.Text = "Reader Select"
        Me.radSelectReader.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 77)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtqueryFrom)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtConvertedQuery)
        Me.SplitContainer1.Size = New System.Drawing.Size(942, 506)
        Me.SplitContainer1.SplitterDistance = 237
        Me.SplitContainer1.TabIndex = 16
        '
        'txtReader
        '
        Me.txtReader.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtReader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtReader.Location = New System.Drawing.Point(545, 7)
        Me.txtReader.Name = "txtReader"
        Me.txtReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReader.Size = New System.Drawing.Size(107, 25)
        Me.txtReader.TabIndex = 17
        Me.txtReader.Text = "rst"
        Me.txtReader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(488, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Reader"
        '
        'frmMysqlStatementConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 595)
        Me.Controls.Add(Me.txtReader)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.radSelectReader)
        Me.Controls.Add(Me.tabIndertSelectDB)
        Me.Controls.Add(Me.rad_insertselect)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtspace)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rad_update)
        Me.Controls.Add(Me.rad_insert)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmMysqlStatementConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mysql Statement to VB Query Converter Tool"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rad_insert As System.Windows.Forms.RadioButton
    Friend WithEvents rad_update As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtspace As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtqueryFrom As System.Windows.Forms.RichTextBox
    Friend WithEvents txtConvertedQuery As System.Windows.Forms.RichTextBox
    Friend WithEvents rad_insertselect As System.Windows.Forms.RadioButton
    Friend WithEvents tabIndertSelectDB As System.Windows.Forms.RadioButton
    Friend WithEvents radSelectReader As System.Windows.Forms.RadioButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtReader As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
