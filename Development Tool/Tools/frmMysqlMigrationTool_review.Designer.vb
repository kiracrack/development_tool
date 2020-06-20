<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMysqlMigrationTool_review
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DatagridSetup = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.id = New System.Windows.Forms.TextBox()
        CType(Me.DatagridSetup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridSetup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridSetup.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridSetup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridSetup.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridSetup.Location = New System.Drawing.Point(0, 0)
        Me.DatagridSetup.Margin = New System.Windows.Forms.Padding(2)
        Me.DatagridSetup.MultiSelect = False
        Me.DatagridSetup.Name = "DatagridSetup"
        Me.DatagridSetup.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridSetup.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DatagridSetup.RowHeadersVisible = False
        Me.DatagridSetup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DatagridSetup.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DatagridSetup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridSetup.Size = New System.Drawing.Size(297, 397)
        Me.DatagridSetup.TabIndex = 381
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
        'id
        '
        Me.id.Location = New System.Drawing.Point(135, 188)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(27, 20)
        Me.id.TabIndex = 396
        Me.id.Visible = False
        '
        'frmMysqlMigrationTool_review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 397)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.DatagridSetup)
        Me.MaximizeBox = False
        Me.Name = "frmMysqlMigrationTool_review"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mysql Migration Tool"
        CType(Me.DatagridSetup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatagridSetup As System.Windows.Forms.DataGridView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents id As System.Windows.Forms.TextBox
End Class
