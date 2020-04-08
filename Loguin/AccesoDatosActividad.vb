Public Class AccesoDatosActividad
    Shared ctx As New LiquidacionSueldosEntities1



    Shared Sub MostrarCategorias(combo As ComboBox)
        Dim dato = (From e In ctx.CategoriaA
                    Select e).ToList

        combo.DataSource = dato
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_categoria"
        combo.SelectedValue = -1

    End Sub


    Shared Sub MostrarGridActividad(grid As DataGridView)
        Dim dato = (From s In ctx.Actividad
                    Select Descripcion = s.descripcion, s.valor, Jornada = s.Unidad.descripcion).ToList
        grid.DataSource = dato
        grid.Columns(0).Visible = False

    End Sub









End Class
