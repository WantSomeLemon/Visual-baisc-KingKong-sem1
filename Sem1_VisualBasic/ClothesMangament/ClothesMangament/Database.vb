Imports MySql.Data.MySqlClient

Public Class Database
    Private Shared connectionString As String = "Server=localhost;User ID=root;Password=12345678;Database=ClothesManagement;AllowPublicKeyRetrieval=True;SslMode=none"

    Public Shared Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        conn.Open()
        Return conn
    End Function
End Class
