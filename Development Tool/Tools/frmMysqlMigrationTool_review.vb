Imports MySql.Data.MySqlClient

Public Class frmMysqlMigrationTool_review 
    Private Sub frmMysqlMigrationTool_review_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSetupFields()
    End Sub
    Public Sub LoadSetupFields()
        DatagridSetup.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select Sourcefieldname as 'Source', Destinationfieldname as 'Target' from migration.tbltable_details inner join migration.tbltable_setup on tbltable_details.sourcetablename = tbltable_setup.sourcetable and tbltable_details.destinationtablename = tbltable_setup.destinationtable  where tbltable_setup.id='" & id.Text & "' order by tbltable_details.id asc", conn)
        msda.Fill(dst, 0)
        DatagridSetup.DataSource = dst.Tables(0)
        DatagridSetup.Focus()
    End Sub

    Private Sub frmMysqlMigrationTool_review_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        id.Text = ""
    End Sub
End Class