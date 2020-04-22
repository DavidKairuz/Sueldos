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


End Class
