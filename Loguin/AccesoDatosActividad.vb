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
    'deberia mostrar a todos por ende modificar el nombre add una T
    Shared Sub MostrarGridActividad(grid As DataGridView)
        Dim dato = (From s In ctx.Actividad
                    Select Actividad = s.descripcion, s.descripcion).ToList
        grid.DataSource = dato
        '  grid.Columns(0).Visible = False

    End Sub
    'este tiene que mostrar solo los que estan dados de alta
    Shared Sub MostrarGridActividadA(grid As DataGridView)
        Dim dato = (From s In ctx.Actividad
                    Where s.estadobaja = 0
                    Select Actividad = s.descripcion, s.descripcion).ToList
        grid.DataSource = dato
        '  grid.Columns(0).Visible = False

    End Sub

    'Shared Function Existe(name As String) As Boolean
    '    Dim result As Boolean
    '    If (ctx.Actividad.Any()) Then
    '        Dim ban = (From b In ctx.Actividad
    '                   Where b.descripcion Like name
    '                   Select b).SingleOrDefault
    '        result = True
    '    Else
    '        result = False

    '    End If

    '    Return result

    'End Function
    Shared Function ExisteA(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Actividad.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Actividad) = (From c In ctx.Actividad
                                          Where c.descripcion.StartsWith(txt.Text)
                                          Select c).ToList
        dgv.DataSource = tipo

    End Sub



End Class
