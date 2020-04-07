Public Class AccesoDatosTContrato
    Shared ctx As New LiquidacionSueldosEntities1
    ' Dim Tc = New Tipo_Contrato()

    Shared Sub mostrartipocontrato(grid As DataGridView)
        '  Dim tipo As String = Nothing
        Dim tipo = (From t In ctx.Tipo_Contrato
                    Select t).ToList

        grid.DataSource = tipo
    End Sub


End Class
