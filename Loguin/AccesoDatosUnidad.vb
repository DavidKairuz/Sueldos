Public Class AccesoDatosUnidad
    Shared ctx As New LiquidSueldosEntities



    Shared Sub MostrarUnidadesT(dgv As DataGridView)
        Dim uni = (From u In ctx.Unidad
                   Select u).ToList
        dgv.DataSource = uni

    End Sub

    Shared Sub MostrarUnidadesA(dgv As DataGridView)
        Dim uni = (From u In ctx.Unidad
                   Where u.estadobaja = 0
                   Select u).ToList

        dgv.DataSource = uni

    End Sub

    Shared Sub AgregarUnidad(unit As Unidad)
        ctx.Unidad.Add(unit)
        ctx.SaveChanges()
    End Sub


    Shared Sub EliminarUnidad(id As Integer)
        Dim uni = (From u In ctx.Unidad
                   Where u.id_unidad = id
                   Select u).SingleOrDefault

        uni.estadobaja = 1
        ctx.SaveChanges()
    End Sub
    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Unidad.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Shared Sub BuscarUnidad(name As String)
        Dim unit = (From u In ctx.Unidad
                    Where u.descripcion Like name
                    Select u).SingleOrDefault
    End Sub

End Class
