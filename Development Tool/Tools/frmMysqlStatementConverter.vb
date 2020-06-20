Public Class frmMysqlStatementConverter
    Dim strtable As String = ""
    Dim datafield As String = ""
    Dim datafield2 As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        strtable = "" : datafield = "" : datafield2 = "" : Dim space = ""
        If txtqueryFrom.Text = "" Then
            MessageBox.Show("Please Paste Mysql CREATE Statement Query!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtqueryFrom.Focus()
            Exit Sub
        ElseIf Val(txtspace.Text) > 100 Then
            MessageBox.Show("Query space to much longer!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtspace.Focus()
            Exit Sub
        End If
        For i = 0 To Val(txtspace.Text)
            space += " "
        Next
        For Each word In txtqueryFrom.Text.Split(New Char() {","})
            If UCase(word).IndexOf(";") = 0 Then
                Exit For
            End If
            If UCase(word).IndexOf("DROP") = 0 Then
                MessageBox.Show("Invalid Mysql CREATE Statement Query!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtqueryFrom.Focus()
                Exit Sub
            End If
            If UCase(word).IndexOf("CREATE TABLE") = 0 Then
                strtable = word.Remove(0, 13)
                Dim toremtable = ""
                For Each splittable In strtable.Split(New Char() {"`"}, 5)
                    toremtable = splittable
                Next
                strtable = strtable.Replace(toremtable, "").Replace(" ", "")
                'MsgBox(strtable)
            End If
            If UCase(word).IndexOf("AUTO_INCREMENT") = -1 And UCase(word).IndexOf("CREATE TABLE") = -1 And UCase(word).IndexOf("PRIMARY KEY") = -1 Then
                Dim toremfield = "" : Dim cnt As Integer = 0
                For Each splitfield In word.Split(New Char() {"`"}, 3)
                    If cnt = 1 Then
                        toremfield = splitfield
                    End If
                    cnt = cnt + 1
                Next
                If radSelectReader.Checked = True Then
                    datafield += txtPrefix.Text & toremfield.Replace(" ", "") & ".Text " & "= " & txtReader.Text & "(""" & toremfield.Replace(" ", "") & """).toString() " & Environment.NewLine & space
                Else
                    If tabIndertSelectDB.Checked = True Then
                        datafield += toremfield.Replace(" ", "") & "='"" & rst(""" & toremfield.Replace(" ", "") & """).toString() & ""', "" _" & Environment.NewLine & space & "+ "" "
                        datafield2 += toremfield.Replace(" ", "") & ","
                    Else
                        datafield += toremfield.Replace(" ", "") & "='"" & " & txtPrefix.Text & StrConv(toremfield.Replace(" ", ""), VbStrConv.ProperCase) & ".Text & ""', "" _" & Environment.NewLine & space & "+ "" "
                        datafield2 += toremfield.Replace(" ", "") & ","
                    End If
                End If
               
            End If
        Next
        If rad_insert.Checked = True Then
            txtConvertedQuery.Text = """INSERT INTO " & strtable & " set  "" _" & Environment.NewLine & space & "+ "" " & datafield.Remove(datafield.Length - (11 + space.Length), (11 + space.Length)) & ";"""
        ElseIf tabIndertSelectDB.Checked = True Then
            txtConvertedQuery.Text = """INSERT INTO " & strtable & " set  "" _" & Environment.NewLine & space & "+ "" " & datafield.Remove(datafield.Length - (11 + space.Length), (11 + space.Length)) & ";"""
        ElseIf rad_update.Checked = True Then
            txtConvertedQuery.Text = """UPDATE " & strtable & " set  "" _" & Environment.NewLine & space & "+ "" " & datafield.Remove(datafield.Length - (11 + space.Length), (11 + space.Length)) & ";"""
        ElseIf rad_insertselect.Checked = True Then
            txtConvertedQuery.Text = """INSERT INTO " & strtable & " (" & datafield2.Remove(datafield2.Length - 1, 1) & ") "" _" & Environment.NewLine & space & "+ "" SELECT (" & datafield2.Remove(datafield2.Length - 1, 1) & ") FROM " & strtable & ""
        ElseIf radSelectReader.Checked = True Then
            txtConvertedQuery.Text = space & datafield
        End If

    End Sub

    Private Sub frmMysqlStatementConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class