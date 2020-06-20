Imports MySql.Data.MySqlClient

Public Class frmMysqlMigrationTool
    Dim SelectedSourceRow As Integer
    Dim SelectedRow As Integer
#Region "CONNECTION SETTINGS"
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Space) Then
            If txtCustomQuery.Focus = False Then
                cmdNext.PerformClick()
            End If

        ElseIf keyData = (Keys.Delete) Then
            If txtCustomQuery.Focus = False Then
                cmdBack.PerformClick()
            End If

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMysqlMigrationTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidateConnection()
    End Sub
    Public Sub ValidateConnection()
        If System.IO.File.Exists(file_conn) = True Then
            If OpenMysqlConnection() = True Then
                com.CommandText = "CREATE DATABASE IF NOT EXISTS migration" : com.ExecuteNonQuery()
                com.CommandText = "CREATE TABLE IF NOT EXISTS `migration`.`tbltable_destination` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `tablename` varchar(45) NOT NULL,  `fieldname` varchar(45) DEFAULT NULL,  `configured` tinyint(1) DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=4591 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
                com.CommandText = "CREATE TABLE IF NOT EXISTS `migration`.`tbltable_details` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `sourcedb` text,  `sourcetablename` text,  `sourcefieldname` text,  `destinationdb` text,  `destinationtablename` text,  `destinationfieldname` text,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=1250 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
                com.CommandText = "CREATE TABLE IF NOT EXISTS `migration`.`tbltable_setup` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `sourcedb` text,  `sourcetable` text,  `destinationdb` text,  `destinationtable` text,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=1026 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
                com.CommandText = "CREATE TABLE IF NOT EXISTS `migration`.`tbltable_source` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `tablename` varchar(45) NOT NULL,  `fieldname` varchar(45) DEFAULT NULL,  `configured` tinyint(1) DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=3376 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
                com.CommandText = "CREATE TABLE IF NOT EXISTS `migration`.`tbltable_notincluded` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `dbname` VARCHAR(100) NOT NULL,  `tablename` VARCHAR(100) NOT NULL,  PRIMARY KEY (`id`)) ENGINE = InnoDB;" : com.ExecuteNonQuery()

                lblSource.Text = "Connected Server: " & sqlserver & ":" & sqlport
                lblSourceDatabase.Text = "Source: " & sqldatabasesource
                ckSource.Text = "View all (" & sqldatabasesource & " table)"

                lblDestinationDatabase.Text = "Target: " & sqldatabasedestination
                ckDestination.Text = "View all (" & sqldatabasedestination & " table)"

                lblSource.ForeColor = Color.Green
                cmdConnectionSetup.Text = "Disconnect"
                cmdConnectionSetup.ForeColor = Color.Red
                loadSourceTable() : loadDestinationTable()
            Else
                lblSource.Text = "Disconnected"
                lblSource.ForeColor = Color.Red
                cmdConnectionSetup.ForeColor = DefaultForeColor
                cmdConnectionSetup.Text = "Connection Setup"
            End If
        Else
            lblSource.Text = "Disconnected"
            lblSource.ForeColor = Color.Red
            cmdConnectionSetup.ForeColor = DefaultForeColor
            cmdConnectionSetup.Text = "Connection Setup"
        End If
    End Sub
#End Region

#Region "MIGRATION SETUP"
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmdConnectionSetup.Click
        If cmdConnectionSetup.Text = "Disconnect" Then
            System.IO.File.Delete(file_conn)
            ValidateConnection()
        Else
            frmConnectionSetup.ShowDialog()
            ValidateConnection()
        End If

    End Sub
    Public Sub loadSourceTable()
        txtSourceTable.Items.Clear()
        com.CommandText = "select distinct tablename from migration.tbltable_source where tablename not in (select tablename from `migration`.`tbltable_notincluded` where dbname='" & sqldatabasesource & "') " & If(ckSource.Checked = True, "", " and tablename not in (select sourcetable from migration.tbltable_setup)") : rst = com.ExecuteReader
        While rst.Read
            txtSourceTable.Items.Add(rst("tablename").ToString)
        End While
        rst.Close()
    End Sub
    Public Sub loadDestinationTable()
        txtDestinationTable.Items.Clear()
        com.CommandText = "select distinct tablename from migration.tbltable_destination where tablename not in (select tablename from `migration`.`tbltable_notincluded` where dbname='" & sqldatabasedestination & "') " & If(ckDestination.Checked = True, "", " and tablename not in (select destinationtable from migration.tbltable_setup)") : rst = com.ExecuteReader
        While rst.Read
            txtDestinationTable.Items.Add(rst("tablename").ToString)
        End While
        rst.Close()
    End Sub

    Public Sub LoadSourceFields()
        DatagridSource.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id, Fieldname from migration.tbltable_source where tablename='" & txtSourceTable.Text & "' and configured=0  order by id asc", conn)
        msda.Fill(dst, 0)
        DatagridSource.DataSource = dst.Tables(0)
        GridHideColumn(DatagridSource, {"id"})
        If DatagridSource.RowCount = 0 Then
            If CheckBox1.Checked = True Then
                cmdNext.Enabled = True
            Else
                cmdNext.Enabled = False
            End If

        Else
            cmdNext.Enabled = True
        End If
        If SelectedSourceRow < DatagridSource.RowCount Then
            DatagridSource.Rows(SelectedSourceRow).Cells(1).Selected = True
            DatagridSource.Select()
        End If
    End Sub
    Public Sub LoadDestinationFields()
        DatagridDestination.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id, Fieldname from migration.tbltable_destination where tablename='" & txtDestinationTable.Text & "' and configured=0  order by id asc", conn)
        msda.Fill(dst, 0)
        DatagridDestination.DataSource = dst.Tables(0)
        GridHideColumn(DatagridDestination, {"id"})

        If SelectedRow < DatagridDestination.RowCount Then
            DatagridDestination.Rows(SelectedRow).Cells(1).Selected = True
            DatagridDestination.Select()
        End If
    End Sub
    Public Sub LoadSetupFields()
        DatagridSetup.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id,  Sourcefieldname as 'Source', destinationfieldname as 'Target' from migration.tbltable_details where sourcetablename='" & txtSourceTable.Text & "' and destinationtablename='" & txtDestinationTable.Text & "' order by id asc", conn)
        msda.Fill(dst, 0)
        DatagridSetup.DataSource = dst.Tables(0)
        GridHideColumn(DatagridSetup, {"id"})
        DatagridSetup.Focus()
        If DatagridSetup.RowCount = 0 Then
            cmdBack.Enabled = False
        Else
            cmdBack.Enabled = True
            DatagridSetup.Rows(DatagridSetup.RowCount - 1).Selected = True
        End If

    End Sub

    Private Sub txtSourceTable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSourceTable.KeyPress
        MsgBox(e.KeyChar())
    End Sub
    Private Sub txtSourceTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSourceTable.SelectedIndexChanged
        SelectedSourceRow = 0
        LoadSourceFields()
        DatagridSource.Focus()
        If txtSourceTable.Text <> "" Then
            Dim totalrows As Integer = countqry(sqldatabasesource & "." & txtSourceTable.Text, "")
            txtRows.Text = totalrows & " Total rows affected"
        Else
            txtRows.Text = ""
        End If
    End Sub

    Private Sub txtDestinationTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDestinationTable.SelectedIndexChanged
        SelectedRow = 0
        LoadDestinationFields() : DatagridDestination.Focus() : LoadSetupFields() : checkExistingSetup()
    End Sub
    Public Sub checkExistingSetup()
        If countqry("migration.tbltable_setup", " where sourcedb='" & sqldatabasesource & "' and sourcetable='" & txtSourceTable.Text & "' and destinationdb='" & sqldatabasedestination & "' and destinationtable='" & txtDestinationTable.Text & "'") = 0 Then
            cmdSave.Text = "Save Setup"
        Else
            cmdSave.Text = "Reset Setup"
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If CheckBox1.Checked = True Then
            com.CommandText = "insert into migration.tbltable_details set sourcedb='" & sqldatabasesource & "', sourcetablename='" & txtSourceTable.Text & "', sourcefieldname='" & txtCustomQuery.Text.Replace("'", "''") & "',destinationdb='" & sqldatabasedestination & "', destinationtablename='" & txtDestinationTable.Text & "', destinationfieldname='" & DatagridDestination.Item("Fieldname", DatagridDestination.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "update migration.tbltable_destination set configured=1 where id='" & DatagridDestination.Item("id", DatagridDestination.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into migration.tbltable_details set sourcedb='" & sqldatabasesource & "', sourcetablename='" & txtSourceTable.Text & "', sourcefieldname='" & DatagridSource.Item("Fieldname", DatagridSource.CurrentRow.Index).Value().ToString & "',destinationdb='" & sqldatabasedestination & "', destinationtablename='" & txtDestinationTable.Text & "', destinationfieldname='" & DatagridDestination.Item("Fieldname", DatagridDestination.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "update migration.tbltable_source set configured=1 where id='" & DatagridSource.Item("id", DatagridSource.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "update migration.tbltable_destination set configured=1 where id='" & DatagridDestination.Item("id", DatagridDestination.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
        End If
        SelectedSourceRow = DatagridSource.CurrentRow.Index : SelectedRow = DatagridDestination.CurrentRow.Index
        LoadSourceFields() : LoadDestinationFields() : LoadSetupFields() : DatagridSource.Focus() : DatagridDestination.Focus() : checkExistingSetup()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        For Each rw As DataGridViewRow In DatagridSetup.SelectedRows
            com.CommandText = "update migration.tbltable_source set configured=0 where fieldname='" & rw.Cells("Source").Value.ToString & "' and tablename='" & txtSourceTable.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update migration.tbltable_destination set configured=0 where fieldname='" & rw.Cells("Target").Value.ToString & "' and tablename='" & txtDestinationTable.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from migration.tbltable_details where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            LoadSourceFields() : LoadDestinationFields() : LoadSetupFields() : DatagridDestination.Focus() : checkExistingSetup() : DatagridSource.Focus()
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cmdResetCurrentSetup.Click
        If MessageBox.Show("Are you sure you want to reset current setup? ", "Migration Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update migration.tbltable_source set configured=0" : com.ExecuteNonQuery()
            com.CommandText = "update migration.tbltable_destination set configured=0" : com.ExecuteNonQuery()
            com.CommandText = "delete from migration.tbltable_details" : com.ExecuteNonQuery()
            com.CommandText = "delete from migration.tbltable_setup" : com.ExecuteNonQuery()
            MessageBox.Show("Database successfully reseted!", "Mysql Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSourceTable.SelectedIndex = -1 : txtDestinationTable.SelectedIndex = -1 : loadSourceTable() : LoadSourceFields() : loadDestinationTable() : LoadDestinationFields() : LoadSetupFields() : DatagridSource.Focus() : DatagridDestination.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If cmdSave.Text = "Save Setup" Then
            If MessageBox.Show("Are you sure you want to save current setup? ", "Migration Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "insert into migration.tbltable_setup set sourcedb='" & sqldatabasesource & "', sourcetable='" & txtSourceTable.Text & "', destinationdb='" & sqldatabasedestination & "', destinationtable='" & txtDestinationTable.Text & "'" : com.ExecuteNonQuery()
                txtSourceTable.SelectedIndex = -1 : txtDestinationTable.SelectedIndex = -1 : loadSourceTable() : LoadSourceFields() : loadDestinationTable() : LoadDestinationFields() : LoadSetupFields() : DatagridSource.Focus() : DatagridDestination.Focus()
                txtSourceTable.SelectedIndex = 0 : txtDestinationTable.SelectedIndex = 0
                MessageBox.Show("Setup successfully saved!", "Mysql Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If MessageBox.Show("Are you sure you want to reset current setup? ", "Migration Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update migration.tbltable_source set configured=0 where tablename='" & txtSourceTable.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update migration.tbltable_destination set configured=0 where tablename='" & txtDestinationTable.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from migration.tbltable_details where sourcedb='" & sqldatabasesource & "' and sourcetablename='" & txtSourceTable.Text & "' and destinationdb='" & sqldatabasedestination & "' and destinationtablename='" & txtDestinationTable.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from migration.tbltable_setup where sourcedb='" & sqldatabasesource & "' and sourcetable='" & txtSourceTable.Text & "' and destinationdb='" & sqldatabasedestination & "' and destinationtable='" & txtDestinationTable.Text & "'" : com.ExecuteNonQuery()
                LoadSourceFields() : LoadDestinationFields() : LoadSetupFields() : DatagridSource.Focus() : DatagridDestination.Focus() : checkExistingSetup()
                MessageBox.Show("Setup successfully reseted!", "Mysql Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ckSource_CheckedChanged(sender As Object, e As EventArgs) Handles ckSource.CheckedChanged
        loadSourceTable()
    End Sub

    Private Sub ckDestination_CheckedChanged(sender As Object, e As EventArgs) Handles ckDestination.CheckedChanged
        loadDestinationTable()
    End Sub
#End Region

#Region "MIGRATION SUMMARY"
    Public Sub ShowMigrationSummary()
        DataGridMigrationSummary.Rows.Clear()
        DataGridMigrationSummary.ColumnCount = 6
        DataGridMigrationSummary.ColumnHeadersVisible = True

        DataGridMigrationSummary.Columns(0).Name = "Source Database"
        DataGridMigrationSummary.Columns(1).Name = "Source Table"
        DataGridMigrationSummary.Columns(2).Name = "Affected Rows"
        DataGridMigrationSummary.Columns(3).Name = "Target Database"
        DataGridMigrationSummary.Columns(4).Name = "Target Table"
        DataGridMigrationSummary.Columns(5).Name = "id"

        dst = New DataSet
        msda = New MySqlDataAdapter("select * from migration.tbltable_setup", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                DataGridMigrationSummary.Rows.Add(.Rows(cnt)("sourcedb").ToString(), .Rows(cnt)("sourcetable").ToString(), countqry(.Rows(cnt)("sourcedb").ToString() & "." & .Rows(cnt)("sourcetable").ToString(), ""), .Rows(cnt)("destinationdb").ToString(), .Rows(cnt)("destinationtable").ToString(), .Rows(cnt)("id").ToString())
            End With
        Next
        GridHideColumn(DataGridMigrationSummary, {"id"})
        GridColumnAlignment(DataGridMigrationSummary, {"Source Database", "Target Database", "Affected Rows"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
#End Region

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ShowMigrationSummary()
    End Sub


    Private Sub cmdStartMigration_Click(sender As Object, e As EventArgs) Handles cmdStartMigration.Click
        If MessageBox.Show("Are you sure you want to start migration? ", "Migration Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            StartMigration()
        End If
    End Sub

    Public Sub StartMigration()
        ProgressBar1.Value = 0

        Dim TableDestinationas As String = ""
        Try
            Dim migrateTable As String = "" : Dim i As Double : Dim rowCount As Double = 100 / countqry("migration.tbltable_setup", "")
            ProgressBar1.Maximum = 100


            dst = New DataSet
            msda = New MySqlDataAdapter("select * from migration.tbltable_setup", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    'DataGridMigrationSummary.Rows.Add(.Rows(cnt)("sourcedb").ToString(), .Rows(cnt)("sourcetable").ToString(), countqry(.Rows(cnt)("sourcedb").ToString() & "." & .Rows(cnt)("sourcetable").ToString(), ""), .Rows(cnt)("destinationdb").ToString(), .Rows(cnt)("destinationtable").ToString())
                    TableDestinationas = .Rows(cnt)("destinationdb").ToString() & "." & .Rows(cnt)("destinationtable").ToString()
                    'TargetFields = .Rows(cnt)("targetfields").ToString()

                    Dim sourcefieldname As String = ""
                    com.CommandText = "select sourcefieldname from `migration`.`tbltable_details` where sourcedb='" & .Rows(cnt)("sourcedb").ToString() & "' and sourcetablename = '" & .Rows(cnt)("sourcetable").ToString() & "' order by id asc" : rst = com.ExecuteReader
                    While rst.Read
                        sourcefieldname += rst("sourcefieldname").ToString & ","
                    End While
                    rst.Close()

                    Dim destinationfieldname As String = ""
                    com.CommandText = "select destinationfieldname from `migration`.`tbltable_details` where destinationdb='" & .Rows(cnt)("destinationdb").ToString() & "' and destinationtablename = '" & .Rows(cnt)("destinationtable").ToString() & "' order by id asc" : rst = com.ExecuteReader
                    While rst.Read
                        destinationfieldname += rst("destinationfieldname").ToString & ","
                    End While
                    rst.Close()

                    '  MsgBox(sourcefieldname & Chr(13) & Chr(13) & destinationfieldname)

                    com.CommandText = "delete from " & .Rows(cnt)("destinationdb").ToString() & "." & .Rows(cnt)("destinationtable").ToString() & ";" : com.ExecuteNonQuery()
                    com.CommandText = "insert into " & .Rows(cnt)("destinationdb").ToString() & "." & .Rows(cnt)("destinationtable").ToString() & " (" & destinationfieldname.Remove(destinationfieldname.Length - 1, 1) & ") " & Environment.NewLine _
                                        + " select " & sourcefieldname.Remove(sourcefieldname.Length - 1, 1) & " from " & .Rows(cnt)("sourcedb").ToString() & "." & .Rows(cnt)("sourcetable").ToString() & ";" : com.ExecuteNonQuery()
                End With
                i = i + rowCount
                ProgressBar1.Value = i
            Next
            If ProgressBar1.Value = 100 Then
                MessageBox.Show("Data successfully migrated!", "Mysql Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Dim strErrorMessage As String = ex.Message
            Dim Split As String() = strErrorMessage.Split("'")
            If (strErrorMessage.Substring(0, strErrorMessage.IndexOf(" ")) = "Field" And strErrorMessage.Contains("default value") = True) Or (strErrorMessage.Substring(0, strErrorMessage.IndexOf(" ")) = "Column" And strErrorMessage.Contains("cannot be null") = True) Then
                dst = New DataSet
                msda = New MySqlDataAdapter("show fields from " & TableDestinationas & " where field ='" & Split(1) & "';", conn)
                msda.Fill(dst, 0)
                For c = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If .Rows(c)("Type").ToString.Contains("varchar") = True Then
                            com.CommandText = "ALTER TABLE " & TableDestinationas & " MODIFY COLUMN `" & Split(1) & "` " & .Rows(c)("Type").ToString & " DEFAULT '';" : com.ExecuteNonQuery()
                        ElseIf .Rows(c)("Type").ToString.Contains("tinyint") = True Or .Rows(c)("Type").ToString.Contains("double") = True Then
                            com.CommandText = "ALTER TABLE " & TableDestinationas & " MODIFY COLUMN `" & Split(1) & "` " & .Rows(c)("Type").ToString & " DEFAULT 0;" : com.ExecuteNonQuery()
                        ElseIf .Rows(c)("Type").ToString.Contains("text") = True Then
                            com.CommandText = "ALTER TABLE " & TableDestinationas & " MODIFY COLUMN `" & Split(1) & "` " & .Rows(c)("Type").ToString & " DEFAULT NULL;" : com.ExecuteNonQuery()
                        ElseIf .Rows(c)("Type").ToString.Contains("int") = True Then
                            com.CommandText = "ALTER TABLE " & TableDestinationas & " MODIFY COLUMN `" & Split(1) & "` " & .Rows(c)("Type").ToString & " DEFAULT 0;" : com.ExecuteNonQuery()
                        ElseIf .Rows(c)("Type").ToString.Contains("longblob") = True Or .Rows(c)("Type").ToString.Contains("blob") = True Or .Rows(c)("Type").ToString.Contains("date") = True Or .Rows(c)("Type").ToString.Contains("time") = True Then
                            com.CommandText = "ALTER TABLE " & TableDestinationas & " MODIFY COLUMN `" & Split(1) & "` " & .Rows(c)("Type").ToString & " DEFAULT NULL;" : com.ExecuteNonQuery()
                        End If
                    End With
                Next
                StartMigration()
            ElseIf strErrorMessage.Substring(0, strErrorMessage.IndexOf(" ")) = "Data" And strErrorMessage.Contains("too long") = True Then
                dst = New DataSet
                msda = New MySqlDataAdapter("show fields from " & TableDestinationas & " where field ='" & Split(1) & "';", conn)
                msda.Fill(dst, 0)
                For c = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        com.CommandText = "ALTER TABLE " & TableDestinationas & " MODIFY COLUMN `" & Split(1) & "` VARCHAR(100) DEFAULT '';" : com.ExecuteNonQuery()
                    End With
                Next
                StartMigration()
            Else
                MsgBox(ex.Message & " on " & com.CommandText)
            End If
        End Try
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles cmdCaptureDatabase.Click
        If MessageBox.Show("Are you sure you want to Capture Database? ", "Migration Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim capturdSourceFields As String = ""
            dst = New DataSet
            msda = New MySqlDataAdapter("show tables in " & sqldatabasesource, conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    com.CommandText = "show fields from " & sqldatabasesource & "." & .Rows(cnt)("Tables_in_" & sqldatabasesource).ToString() : rst = com.ExecuteReader
                    While rst.Read
                        capturdSourceFields = capturdSourceFields + "insert into migration.tbltable_source set tablename='" & .Rows(cnt)("Tables_in_" & sqldatabasesource).ToString() & "',fieldname='" & rst("Field").ToString & "';" & Chr(13)
                    End While
                    rst.Close()
                End With
            Next

            Dim capturdDestinationFields As String = ""
            dst = New DataSet
            msda = New MySqlDataAdapter("show tables in " & sqldatabasedestination, conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    com.CommandText = "show fields from " & sqldatabasedestination & "." & .Rows(cnt)("Tables_in_" & sqldatabasedestination).ToString() : rst = com.ExecuteReader
                    While rst.Read
                        capturdDestinationFields = capturdDestinationFields + "insert into migration.tbltable_destination set tablename='" & .Rows(cnt)("Tables_in_" & sqldatabasedestination).ToString() & "',fieldname='" & rst("Field").ToString & "';" & Chr(13)
                    End While
                    rst.Close()
                End With
            Next

            If capturdSourceFields <> "" Then
                com.CommandText = "delete from migration.tbltable_source" : com.ExecuteNonQuery()
                com.CommandText = capturdSourceFields : com.ExecuteNonQuery()
            End If

            If capturdDestinationFields <> "" Then
                com.CommandText = "delete from migration.tbltable_destination" : com.ExecuteNonQuery()
                com.CommandText = capturdDestinationFields : com.ExecuteNonQuery()
            End If
            txtSourceTable.SelectedIndex = -1 : txtDestinationTable.SelectedIndex = -1 : loadSourceTable() : LoadSourceFields() : loadDestinationTable() : LoadDestinationFields() : LoadSetupFields() : DatagridSource.Focus() : DatagridDestination.Focus()
            MessageBox.Show("Database successfully captured!", "Mysql Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdBackupCurrentSetup_Click(sender As Object, e As EventArgs) Handles cmdBackupCurrentSetup.Click
        Dim xstring As String = ""
        Dim tempenfile As String = Now.ToString("hh:mm:ss").ToString.Replace(":", "")
        Dim process As System.Diagnostics.Process
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        processStartInfo = New System.Diagnostics.ProcessStartInfo
        processStartInfo.FileName = "cmd.exe"

        SaveFileDialog1.Filter = "SQL Files (*.sql*)|*.sql"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'S() 'hell("mysql -h " & sqlserver & " -u " & sqluser & " -p" & sqlpass & " > """ &  & """")

            processStartInfo.Arguments = "/C mysqldump --opt --host " & sqlserver & " --password=" & sqlpass & " --user=" & sqluser & " migration tbltable_source -r """ & SaveFileDialog1.FileName & """ "
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True
            process = System.Diagnostics.Process.Start(processStartInfo)
            process.WaitForExit()

            If process.HasExited = True Then
                MessageBox.Show("Backup successfully done!", "Mysql Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to delete all data on " & sqldatabasedestination & "?", "Migration Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            dst = New DataSet
            msda = New MySqlDataAdapter("show tables in " & sqldatabasedestination, conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    com.CommandText = "delete from " & sqldatabasedestination & "." & .Rows(cnt)("Tables_in_" & sqldatabasedestination).ToString() : com.ExecuteNonQuery()
                End With
            Next
            MessageBox.Show("Data successfully removed!", "Mysql Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete selected row?", "Migration Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In DataGridMigrationSummary.SelectedRows
                com.CommandText = "delete from migration.tbltable_setup where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            ShowMigrationSummary()
        End If

    End Sub



    Private Sub DataGridMigrationSummary_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMigrationSummary.CellDoubleClick
        For Each rw As DataGridViewRow In DataGridMigrationSummary.SelectedRows
            frmMysqlMigrationTool_review.id.Text = rw.Cells("id").Value.ToString
            frmMysqlMigrationTool_review.Show(Me)
        Next

    End Sub


    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        com.CommandText = "insert into migration.tbltable_notincluded  set dbname='" & sqldatabasesource & "', tablename='" & txtSourceTable.Text & "'" : com.ExecuteNonQuery()
        loadSourceTable()
        txtSourceTable.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        com.CommandText = "insert into migration.tbltable_notincluded  set dbname='" & sqldatabasedestination & "', tablename='" & txtDestinationTable.Text & "'" : com.ExecuteNonQuery()
        loadDestinationTable()
        txtDestinationTable.SelectedIndex = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            SplitContainer2.Panel1Collapsed = True
            SplitContainer2.Panel2Collapsed = False
            cmdNext.Enabled = True
        Else
            SplitContainer2.Panel1Collapsed = False
            SplitContainer2.Panel2Collapsed = True
        End If
    End Sub
End Class