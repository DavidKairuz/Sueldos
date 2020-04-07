Public Class AccesoDatos
    Shared ctx As New LoguinEntities()


    ' create a re-usable helper function to validate login information
    Shared Function ValidateLogin(username As String, password As String) As Boolean

        ' create LINQ context to the access database
        ' check credentials against User table
        Dim usr As Usuario = ctx.Usuario.SingleOrDefault(Function(u) _
            u.dni = username AndAlso u.contraseña = password)

        Return (usr IsNot Nothing)

    End Function



End Class
