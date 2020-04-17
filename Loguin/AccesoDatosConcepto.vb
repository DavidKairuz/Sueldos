Public Class AccesoDatosConcepto
    Shared ctx As New LiquidSueldosEntities



    Shared Sub MostrarTipoConcepto(combo As ComboBox)
        Dim dato = (From t In ctx.Tipo_Concepto
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
End Class
