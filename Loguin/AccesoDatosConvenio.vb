Public Class AccesoDatosConvenio
    Shared ctx As New LiquidacionSueldosEntities1



    Shared Sub MostrarGridConvenio(grid As DataGridView)
        Dim dato = (From s In ctx.Convenio
                    Where s.estadobaja = 0
                    Select Id = s.id_convenio, Nombre = s.descripcion).ToList
        grid.DataSource = dato
        ' grid.Columns(2).Visible = False

    End Sub

    Shared Sub MostrarTodoGridConvenio(grid As DataGridView)
        Dim dato = (From s In ctx.Convenio
                    Where s.estadobaja = 1
                    Select Id = s.id_convenio, Nombre = s.descripcion).ToList
        grid.DataSource = dato
        ' grid.Columns(2).Visible = False

    End Sub


    Shared Sub AgregarConvenio(conve As Convenio)
        ctx.Convenio.Add(conve)
        ctx.SaveChanges()

    End Sub



    Shared Sub EliminarConvenio(idconv As Integer)
        Dim dato = (From e In ctx.Convenio
                    Where e.id_convenio = idconv
                    Select e).SingleOrDefault

        dato.estadobaja = 1
        ctx.SaveChanges()
    End Sub



    Shared Sub ActualizarConvenio(idcon As Integer, descrip As String)
        Dim dato = (From e In ctx.Convenio
                    Where e.id_convenio = idcon
                    Select e).SingleOrDefault
        With dato
            .descripcion = descrip
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function MostrarConvenioID(Id As Integer) As Convenio
        '
        Dim cov = (From e In ctx.Convenio
                   Where e.id_convenio = Id
                   Select e).SingleOrDefault 'para un solo registro utilizo singleordefault
        Return cov
    End Function

    Shared Sub MostrarConvenioCbo(combo As ComboBox)
        Dim convenio = (From e In ctx.Convenio
                        Select e).ToList

        combo.DataSource = convenio
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_convenio"
        combo.SelectedValue = -1

    End Sub


    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        '  Not context.Employees.Any (c => c.PayrollNumber = PropertyToCheck)
        'If (context.MyEntity.Any(o >= o.Id <> idToMAtch)) Then
        'If (ctx.Convenio.Any()) Then
        '    Dim ban = (From b In ctx.Convenio
        '               Where b.descripcion = name
        '               Select b).SingleOrDefault
        '    result = True
        If ctx.Convenio.Any(Function(o) o.descripcion = name) Then
            result = True

        Else
            result = False

        End If

        Return result

    End Function



End Class
