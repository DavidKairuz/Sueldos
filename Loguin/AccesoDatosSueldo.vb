Public Class AccesoDatosSueldo

    Shared ctxs As New LiquidacionSueldosEntities1




    Shared Sub MostrarCategoriaActividad(combo As ComboBox)
        Dim cate = (From c In ctxs.CategoriaA
                    Select c).ToList
        combo.DataSource = cate
        combo.DisplayMember = "id_categoria"
        combo.SelectedValue = -1
    End Sub




End Class
