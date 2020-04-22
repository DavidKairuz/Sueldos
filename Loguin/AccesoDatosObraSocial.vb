Public Class AccesoDatosObraSocial
    Shared ctx As New LiquidSueldosEntities


    Sub mostrargridT(grid As DataGridView)
        Dim loc = (From l In ctx.Localidad
                   Select l)
        grid.DataSource = loc
    End Sub

    Sub mostrargridA(grid As DataGridView)
        Dim loc = (From l In ctx.Localidad
                   Where l.estadobaja = 0
                   Select l)
        grid.DataSource = loc
    End Sub

    Sub AgregarObra(ob As Obra_Social)
        ctx.Obra_Social.Add(ob)
        ctx.SaveChanges()
    End Sub

    Sub EliminarObra(id As Integer)
        Dim obj = (From o In ctx.Obra_Social
                   Where o.id_obrasocial = id
                   Select o).SingleOrDefault

        ctx.Obra_Social.Remove(obj)
        ctx.SaveChanges()
    End Sub


    'hay que agregar un estado para dar la baja logica


    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Obra_Social.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


End Class
