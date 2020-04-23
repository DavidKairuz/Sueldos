Public Class AccesoDatosTipoConcepto
    Shared ctx As New LiquidSueldosEntities

    'Da de alta un objeto de tipo concepto
    Shared Sub AgregarTipoConcepto(tipo As Tipo_Concepto)
        ctx.Tipo_Concepto.Add(tipo)
        ctx.SaveChanges()
    End Sub

    'muestra la lista de tipos e conceptos disponibles
    Shared Sub MostrarTipoConcepto(dgv As DataGridView)
        Dim tipo = (From t In ctx.Tipo_Concepto
                    Select t).ToString
    End Sub

    'Baja logica de Tipo concepto
    Shared Sub EliminarTipoConcepto(id As Integer)
        Dim tipo = (From t In ctx.Tipo_Concepto
                    Where t.id_tipoConcepto = id
                    Select t).SingleOrDefault

        tipo.estadobaja = 1
        ctx.SaveChanges()
    End Sub


    Shared Sub ModificarTipoConcepto(id As Integer, name As String, chec As Boolean)
        Dim tipo = (From t In ctx.Tipo_Concepto
                    Where t.id_tipoConcepto = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
            .estado_R_NRm = chec
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(Id As Integer, name As String) As Boolean
        Dim result As Boolean
        If (ctx.Tipo_Concepto.Any()) Then
            Dim ban = (From b In ctx.Tipo_Concepto
                       Where b.id_tipoConcepto = Id Or b.descripcion = name
                       Select b).SingleOrDefault
            result = True
        Else
            result = False

        End If

        Return result

    End Function

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Unidad.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Tipo_Concepto) = (From c In ctx.Tipo_Concepto
                                              Where c.descripcion.StartsWith(txt.Text)
                                              Select c).ToList
        dgv.DataSource = tipo

    End Sub
End Class
