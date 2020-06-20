<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseResetter
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
        Me.txtDatabase = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDatabase
        '
        Me.txtDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDatabase.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtDatabase.ForeColor = System.Drawing.Color.Black
        Me.txtDatabase.FormattingEnabled = True
        Me.txtDatabase.ItemHeight = 15
        Me.txtDatabase.Location = New System.Drawing.Point(13, 10)
        Me.txtDatabase.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(343, 23)
        Me.txtDatabase.TabIndex = 383
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(13, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(344, 47)
        Me.Button1.TabIndex = 394
        Me.Button1.Text = "Reset Database"
        Me.Button1.UseVisualStyleBackColor = True
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
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(14, 40)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(342, 328)
        Me.CheckedListBox1.TabIndex = 395
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(14, 370)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 19)
        Me.CheckBox1.TabIndex = 396
        Me.CheckBox1.Text = "Check all"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmDatabaseResetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 444)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDatabase)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.Name = "frmDatabaseResetter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Database"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDatabase As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
