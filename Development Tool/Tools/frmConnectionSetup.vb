Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmConnectionSetup

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver = ""
        sqlport = ""
        sqluser = ""
        sqlpass = ""
        sqldatabasesource = ""
        sqldatabasedestination = ""
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtServerhost.Text = "" Then
            MessageBox.Show("Please enter Server host!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtServerhost.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            MessageBox.Show("Please enter username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        End If
        Try

            sqlserver = txtServerhost.Text
            sqlport = txtPort.Text
            sqluser = txtusername.Text
            sqlpass = txtpassword.Text
            sqldatabasesource = txtDatabaseSource.Text

            ConnectServer()
            If conn.State <> 0 Then
                Try
                    If System.IO.File.Exists(file_conn) = True Then
                        System.IO.File.Delete(file_conn)
                    End If
                    Dim detailsFile As StreamWriter = Nothing
                    detailsFile = New StreamWriter(file_conn, True)
                    detailsFile.WriteLine(EncryptTripleDES(txtServerhost.Text & "," & txtPort.Text & "," & txtusername.Text & "," & txtpassword.Text & "," & txtDatabaseSource.Text & "," & txtDatabaseDestination.Text))
                    detailsFile.Close()
                Catch errMYSQL As MySqlException
                    MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                                    & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Catch errMS As Exception
                    MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
            MessageBox.Show("Connection successfully connected!", "Mysql Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
End Class