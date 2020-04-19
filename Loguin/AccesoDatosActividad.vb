Public Class AccesoDatosActividad
    Shared ctx As New LiquidSueldosEntities



    Shared Sub MostrarCategorias(combo As ComboBox)
        Dim dato = (From e In ctx.CategoriaA
                    Select e).ToList

        combo.DataSource = dato
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_categoriaa"
        combo.SelectedValue = -1

    End Sub


    Shared Sub MostrarCategoriaConvenio(comb As ComboBox)
        Dim cc = (From c In ctx.CategoriaC
                  Select c).ToList


        comb.DataSource = cc
        comb.DisplayMember = "descripcion"
        comb.ValueMember = "id_categoria"
        comb.SelectedValue = -1
    End Sub


    Shared Sub AgregarActividad(act As Actividad)
        ctx.Actividad.Add(act)
        ctx.SaveChanges()
    End Sub

    Shared Sub EliminarActividad(id As Integer)
        Dim act = (From a In ctx.Actividad
                   Where a.id_actividad = id
                   Select a).SingleOrDefault
        act.estadobaja = 1
        ctx.SaveChanges()
    End Sub

    Shared Sub ModificarActividad(id As Integer, name As String, cat As Integer, con As Integer, catcon As Integer)
        Dim act = (From a In ctx.Actividad
                   Where a.id_actividad = id
                   Select a).SingleOrDefault

        With act
            .descripcion = name
            .id_categoria = cat
            .id_convenio = con
            .categoriaAct = catcon
        End With
        ctx.SaveChanges()
    End Sub

    Shared Sub MostrarGridActividad(grid As DataGridView)
        Dim dato = (From s In ctx.Actividad
                    Select Actividad = s.descripcion, s.descripcion).ToList
        grid.DataSource = dato
        '  grid.Columns(0).Visible = False

    End Sub









End Class
