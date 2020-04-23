Public Class AccesoDatosConcepto
    Shared ctx As New LiquidSueldosEntities



    Shared Sub MostrarTipoConcepto(combo As ComboBox)
        Dim dato = (From t In ctx.Tipo_Concepto
                    Where t.estadobaja = 0
                    Select t.descripcion).ToList

        combo.DataSource = dato
        combo.DisplayMember = "descripcion"
        'combo.SelectedValue = -1
    End Sub

    Shared Sub AgregarConcepto(concep As Concepto)
        ctx.Concepto.Add(concep)
        ctx.SaveChanges()
    End Sub

    Shared Sub EliminarConcepto(idconcep As Integer)
        Dim dato = (From e In ctx.Concepto
                    Where e.id_concepto = idconcep
                    Select e).SingleOrDefault

        dato.estadobaja = 1
        ctx.SaveChanges()
    End Sub

    Shared Sub ActualizarConcepto(idconcep As Integer, nombre As String, valor As Double, codig As Integer, tipo As Integer)
        Dim dato = (From e In ctx.Concepto
                    Where e.id_concepto = idconcep
                    Select e).SingleOrDefault
        With dato
            .descripcion = nombre
            .valor = valor
            .codigo = codig
            .tipo_concepto = tipo
        End With

        ctx.SaveChanges()
    End Sub


    Shared Sub CargarDatagridCon(dta As DataGridView)
        Dim data = (From e In ctx.Concepto
                    Select e).ToList

        dta.DataSource = data
        dta.Columns(0).Visible = False
    End Sub




    ''Shared Function Existe(name As String) As Boolean
    ''    Dim result As Boolean
    ''    If (ctx.Concepto.Any()) Then
    ''        Dim ban = (From b In ctx.Concepto
    ''                   Where b.descripcion Like name
    ''                   Select b).SingleOrDefault
    ''        result = True
    ''    Else
    ''        result = False

    ''    End If

    ''    Return result

    ''End Function

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Concepto.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Concepto) = (From c In ctx.Concepto
                                         Where c.descripcion.StartsWith(txt.Text)
                                         Select c).ToList
        dgv.DataSource = tipo

    End Sub
End Class
