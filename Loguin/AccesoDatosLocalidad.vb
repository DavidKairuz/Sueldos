Public Class AccesoDatosLocalidad
    Shared ctx As New LiquidSueldosEntities


    Shared Sub MostrarProvincias(combo As ComboBox)
        Dim prov = (From p In ctx.Provincia
                    Select p).ToList

        combo.DataSource = prov
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_provincia"
        combo.SelectedValue = -1
    End Sub

    Shared Sub AgregarLocalidad(loc As Localidad)
        ctx.Localidad.Add(loc)
        ctx.SaveChanges()
    End Sub

    Shared Sub EliminarLocalidad(idl As Integer, idp As Integer)
        Dim Loc = (From c In ctx.Localidad
                   Where c.id_provincia = idp And c.id_localidad = idl
                   Select c).SingleOrDefault

        Loc.estadobaja = 1
        ctx.SaveChanges()
    End Sub


    Shared Sub BajaPermanente(idl As Integer, idp As Integer)
        Dim loc = (From c In ctx.Localidad
                   Where c.id_provincia = idp And c.id_localidad = idl).SingleOrDefault
        'If (IsNothing(loc)) Then
        '    MsgBox("No existe este registro o no se encontro")
        'Else
        '    ctx.Localidad.Remove(loc)
        '    ctx.SaveChanges()

        'End If

    End Sub
    Shared Sub MostrarLocalidadesA(dgv As DataGridView)
        Dim loc = (From l In ctx.Localidad
                   Where l.estadobaja = 0
                   Select l).ToList
        dgv.DataSource = loc
    End Sub

    Shared Sub MostrarLocalidadesT(dgv As DataGridView)
        Dim loc = (From l In ctx.Localidad
                   Select l).ToList
        dgv.DataSource = loc
    End Sub



    Shared Function Existe(name As String, idp As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Localidad.Any(Function(o) o.descripcion = name And o.id_provincia = idp) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Localidad) = (From c In ctx.Localidad
                                          Where c.descripcion.StartsWith(txt.Text)
                                          Select c).ToList
        dgv.DataSource = tipo

    End Sub
End Class
