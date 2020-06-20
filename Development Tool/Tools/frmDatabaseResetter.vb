Imports MySql.Data.MySqlClient

Public Class frmDatabaseResetter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub LoadDatabase()
        com.CommandText = "show databases;" : rst = com.ExecuteReader
        While rst.Read()
            txtDatabase.Items.Add(rst("Database").ToString)
        End While
        rst.Close()

    End Sub
    Public Sub LoadTables()
        com.CommandText = "show tables from " & txtDatabase.Text & ";" : rst = com.ExecuteReader
        While rst.Read()
            CheckedListBox1.Items.Add(rst("Tables_in_" & txtDatabase.Text).ToString)
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckedListBox1.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select atleast 1 table to continue reset!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CheckedListBox1.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue your action? There's no undo function if this is executed!", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
           For i = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(i) = True Then
                    com.CommandText = "delete from " & txtDatabase.Text & "." & CheckedListBox1.Items(i).ToString & ";" : com.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Data successfully deleted!", "Reset Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub frmDatabaseResetter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenMysqlConnection() = True Then
            LoadDatabase()
        End If
    End Sub

    Private Sub txtDatabase_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtDatabase.SelectedValueChanged
        If txtDatabase.Text = "" Then Exit Sub
        LoadTables()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        For i = 0 To CheckedListBox1.Items.Count - 1
            If CheckBox1.Checked = True Then
                CheckedListBox1.SetItemCheckState(i, CheckState.Checked)
                Button1.Enabled = True
            Else
                CheckedListBox1.SetItemCheckState(i, CheckState.Unchecked)
                Button1.Enabled = False
            End If
        Next
    End Sub
    Private Sub ls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged, CheckedListBox1.ItemCheck
        If CheckedListBox1.CheckedItems.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

End Class