Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable

    Sub openCon()
        ' Set the connection string first
        con.ConnectionString = "server=localhost;username=root;password=12345;database=db_tutorial"

        ' Open the connection
        con.Open()
    End Sub
End Module
