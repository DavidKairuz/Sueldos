Public Class AccesoDatosSueldo

    Shared ctxs As New LiquidSueldosEntities




    Shared Sub MostrarCategoriaActividad(combo As ComboBox)
        Dim cate = (From c In ctxs.CategoriaA
                    Select c).ToList
        combo.DataSource = cate
        combo.DisplayMember = "id_categoria"
        combo.SelectedValue = -1
    End Sub

    'Sub Filtra(txt As TextBox, dgv As DataGridView)
    '    Dim tipo As List(Of Sueldo_Cab) = (From c In ctxs.Sueldo_Cab
    '                                       Where c.fecha.StartsWith(txt.Text)
    '                                       Select c).ToList
    '    dgv.DataSource = tipo

    'End Sub


End Class
