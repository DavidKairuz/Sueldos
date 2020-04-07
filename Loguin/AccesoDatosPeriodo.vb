Public Class AccesoDatosPeriodo

    Shared ctx As New LiquidacionSueldosEntities1
    Shared Sub MostrarConvenioCbo(combo As ComboBox)
        Dim per = (From e In ctx.Periodo
                   Select e).ToList

        combo.DataSource = per
        combo.DisplayMember = "mes"
        combo.ValueMember = "id_periodo"
        combo.SelectedValue = -1

    End Sub



    Shared Sub MostrarPeriodogrid(grid As DataGridView)
        Dim per = (From p In ctx.Periodo
                   Select ID = p.id_periodo, Mes = p.mes).ToList

        grid.DataSource = per

    End Sub
End Class
