Public Class AccesoDatosUnidad
    Shared ctx As New LiquidSueldosEntities





    Shared Sub AgregarUnidad(unit As Unidad)
        ctx.Unidad.Add(unit)
        ctx.SaveChanges()
    End Sub
    'muestra todos los registros
    Shared Sub MostrarUnidadesT(dgv As DataGridView)
        Dim uni = (From u In ctx.Unidad
                   Select u).ToList
        dgv.DataSource = uni

    End Sub
    'muestra los registros que estan activos
    Shared Sub MostrarUnidadesA(dgv As DataGridView)
        Dim uni = (From u In ctx.Unidad
                   Where u.estadobaja = 0
                   Select u).ToList

        dgv.DataSource = uni

    End Sub
    'baja logica
    Shared Sub EliminarUnidad(id As Integer)
        Dim uni = (From u In ctx.Unidad
                   Where u.id_unidad = id
                   Select u).SingleOrDefault

        uni.estadobaja = 1
        ctx.SaveChanges()
    End Sub

    Shared Sub Daralta(id As Integer)
        Dim uni = (From u In ctx.Unidad
                   Where u.id_unidad = id
                   Select u).SingleOrDefault

        uni.estadobaja = 0
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

    Shared Sub ActualizarUnidad(id As Integer, name As String)
        Dim un = (From u In ctx.Unidad
                  Where u.id_unidad = id
                  Select u).SingleOrDefault
        With un
            .descripcion = name
        End With

    End Sub


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Unidad) = (From c In ctx.Unidad
                                       Where c.descripcion.StartsWith(txt.Text)
                                       Select c).ToList
        dgv.DataSource = tipo

    End Sub
End Class
