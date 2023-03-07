Imports System.Data.SqlClient

Module DatabaseConnection
    Public connection As SqlConnection

    Public Sub connection_DB()
        Try
            'Data Source=LAPTOP-27VJVUPP\SQLEXPRESS;Initial Catalog=tcer23;User ID=tcer23;Password=***********
            Dim dataBase As String = "Data Source=LAPTOP-27VJVUPP\SQLEXPRESS;
            initial catalog=tcer23;
            User ID=tcer23;
            Password=123456789"
            connection = New SqlConnection(dataBase)
            If connection.State = ConnectionState.Closed Then connection.Open() Else connection.Close()
        Catch ex As Exception

        End Try
    End Sub
End Module