Imports MySql.Data
Imports Mysqlx

Public Class Test
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connection = New MySqlClient.MySqlConnection("Data Source=localhost;Database=bprs_berkah;User ID=root;Password=;")
        Dim cmd As MySqlClient.MySqlCommand = New MySqlClient.MySqlCommand
        Dim reader As MySqlClient.MySqlDataReader

        cmd.Connection = connection
        cmd.CommandText = "select * from informasi"
        reader = cmd.ExecuteReader()

        GridView1.DataSource = reader
        GridView1.DataBind()
    End Sub

End Class