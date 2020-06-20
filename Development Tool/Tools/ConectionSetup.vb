Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Data.OleDb
Imports System.Security.Cryptography

Module ConectionSetup
    Public conn As New MySqlConnection
    Public sqlserver As String
    Public sqlport As String
    Public sqluser As String
    Public sqlpass As String
    Public sqldatabasesource As String
    Public sqldatabasedestination As String

    Public msda As MySqlDataAdapter
    Public dst As New DataSet
    Public com As New MySqlCommand
    Public rst As MySqlDataReader

    Public file_conn As String = Application.StartupPath.ToString & "\migration.conn"

    Public Function OpenMysqlConnection() As Boolean
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(file_conn)
        Dim br As String = sr.ReadLine() : sr.Close()
        strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
        For Each word In strSetup.Split(New Char() {","c})
            If cnt = 0 Then
                sqlserver = word
            ElseIf cnt = 1 Then
                sqlport = word
            ElseIf cnt = 2 Then
                sqluser = word
            ElseIf cnt = 3 Then
                sqlpass = word
            ElseIf cnt = 4 Then
                sqldatabasesource = word
            ElseIf cnt = 5 Then
                sqldatabasedestination = word
            End If
            cnt = cnt + 1
        Next
        Try
            conn.Close()
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabasesource & "; Connection Timeout=6000000 ; Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 6000000
        Catch errMYSQL As MySqlException
            Return False
        End Try
        Return True
    End Function

    Public Function ConnectServer() As Boolean
        Try
            conn.Close()
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabasesource & "; Connection Timeout=6000000 ; Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 6000000
        Catch errMYSQL As MySqlException
            MessageBox.Show("Can't connect database server on '" & sqlserver & "'", _
                          "Connection Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function GridHideColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).Visible = False
                End If
            Next
        Next
        Return grdView
    End Function

    Const sKey As String = "kira"

    Public Function EncryptTripleDES(ByVal sIn As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the encryptor.
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        ' Get a byte array of the string.
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn)
        ' Transform and return the string.
        Return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Function DecryptTripleDES(ByVal sOut As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the decryptor.
        Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
        Dim Buffer As Byte() = Convert.FromBase64String(sOut)
        ' Transform and return the string.
        Return System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Public Function countqry(ByVal tbl As String, ByVal addwhere As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & addwhere
        rst = com.ExecuteReader
        While rst.Read
            cnt = Val(rst("cnt").ToString)
        End While
        rst.Close()
        Return cnt
    End Function
    Public Function GridColumnAlignment(ByVal grdView As DataGridView, ByVal column As Array, ByVal alignment As DataGridViewContentAlignment) As DataGridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).DefaultCellStyle.Alignment = alignment
                    grdView.Columns(i).HeaderCell.Style.Alignment = alignment
                End If
            Next
        Next
        Return grdView
    End Function
End Module
