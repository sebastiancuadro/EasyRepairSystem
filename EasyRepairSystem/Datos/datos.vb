Imports MySql.Data.MySqlClient

Public Class Datos
    Private oSql As String

    Dim SqlConection = New MySqlConnection()
    Dim SqlCommand As New MySqlCommand()

    Public oLector As MySqlDataReader

    Public Function AgregarPersona(ByVal P As Cliente) As Integer
        SqlConection.connectionString = Conexion.Cnn

        Try
            oSql = "insert into Cliente (cedula,nombre,apellido,usuario,password) values (" & P.cedula & ",'" & P.Nombre & "','" & P.Apellido & "','" & P.USUARIO & "','" & P.PASSWORD & "')"
            SqlCommand.Connection = SqlConection
            SqlCommand.CommandText = oSql
            SqlCommand.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            Return 0
        Finally
            SqlConection.close()
        End Try

    End Function


    Public Function BuscarPersona(ByVal C As Integer) As Cliente
        Dim P As New Cliente
        oSql = "select * From cliente Where cedula=" & C & ""
        SqlCommand = New MySqlCommand(oSql, SqlConection)
        Try

            SqlConection.Open()
            oLector = SqlCommand.ExecuteReader()
            While oLector.Read()

                P.cedula = CInt(oLector("cedula"))
                P.Nombre = DirectCast(oLector("nombre"), String)
                P.Apellido = DirectCast(oLector("apellido"), String)
                P.USUARIO = DirectCast(oLector("usuario"), String)
                P.PASSWORD = DirectCast(oLector("password"), String)

            End While
            Return P
        Catch ex As Exception
            P = New Cliente
            P.cedula = 0
            Return P
        Finally
            SqlConection.close()

        End Try
    End Function



    Public Function BorrarPersona(ByVal P As Cliente) As Integer
        SqlConection.connectionString = conexion.Cnn
        Try
            oSql = "Delete FROM cliente Where Cedula = " & P.cedula & ""
            SqlCommand = New MySqlCommand(oSql, SqlConection)
            SqlConection.open()
            SqlCommand.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            Return 0
        Finally
            SqlConection.Close()
        End Try
    End Function


End Class


