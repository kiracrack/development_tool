<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMysqlColumnToRowConverter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtspace = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFieldFilter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtqueryFrom = New System.Windows.Forms.RichTextBox()
        Me.txtConvertedQuery = New System.Windows.Forms.RichTextBox()
        Me.txtTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Paste CREATE Mysql Statement Here"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(688, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Converted Query Result "
        '
        'txtspace
        '
        Me.txtspace.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.txtspace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtspace.Location = New System.Drawing.Point(67, 190)
        Me.txtspace.Name = "txtspace"
        Me.txtspace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtspace.Size = New System.Drawing.Size(38, 23)
        Me.txtspace.TabIndex = 7
        Me.txtspace.Text = "30"
        Me.txtspace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Set Space"
        '
        'txtFieldFilter
        '
        Me.txtFieldFilter.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.txtFieldFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFieldFilter.Location = New System.Drawing.Point(226, 190)
        Me.txtFieldFilter.Name = "txtFieldFilter"
        Me.txtFieldFilter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFieldFilter.Size = New System.Drawing.Size(67, 23)
        Me.txtFieldFilter.TabIndex = 9
        Me.txtFieldFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Filter By Column Name"
        '
        'txtqueryFrom
        '
        Me.txtqueryFrom.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtqueryFrom.Location = New System.Drawing.Point(12, 25)
        Me.txtqueryFrom.Name = "txtqueryFrom"
        Me.txtqueryFrom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtqueryFrom.Size = New System.Drawing.Size(801, 157)
        Me.txtqueryFrom.TabIndex = 11
        Me.txtqueryFrom.Text = ""
        '
        'txtConvertedQuery
        '
        Me.txtConvertedQuery.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtConvertedQuery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtConvertedQuery.Location = New System.Drawing.Point(12, 235)
        Me.txtConvertedQuery.Name = "txtConvertedQuery"
        Me.txtConvertedQuery.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtConvertedQuery.Size = New System.Drawing.Size(801, 195)
        Me.txtConvertedQuery.TabIndex = 12
        Me.txtConvertedQuery.Text = ""
        '
        'txtTxtBox
        '
        Me.txtTxtBox.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.txtTxtBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTxtBox.Location = New System.Drawing.Point(312, 191)
        Me.txtTxtBox.Name = "txtTxtBox"
        Me.txtTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTxtBox.Size = New System.Drawing.Size(67, 23)
        Me.txtTxtBox.TabIndex = 13
        Me.txtTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "="
        '
        'frmMysqlColumnToRowConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 441)
        Me.Controls.Add(Me.txtTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConvertedQuery)
        Me.Controls.Add(Me.txtqueryFrom)
        Me.Controls.Add(Me.txtFieldFilter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtspace)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmMysqlColumnToRowConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mysql Statement to VB Query Converter Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtspace As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFieldFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtqueryFrom As System.Windows.Forms.RichTextBox
    Friend WithEvents txtConvertedQuery As System.Windows.Forms.RichTextBox
    Friend WithEvents txtTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
