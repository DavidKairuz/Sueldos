Public Class AccesoDatosTContrato
    Shared ctx As New LiquidSueldosEntities
    ' Dim Tc = New Tipo_Contrato()

    Shared Sub MostrarTipoContrato(grid As DataGridView)
        '  Dim tipo As String = Nothing
        Dim tipo = (From t In ctx.Tipo_Contrato
                    Select t).ToList
        grid.DataSource = tipo
    End Sub
    Shared Sub AgregarTipoContrato(tipoc As Tipo_Contrato)
        ctx.Tipo_Contrato.Add(tipoc)
        ctx.SaveChanges()
    End Sub

    Shared Sub EliminarTipoContrato(id As Integer, name As String)
        Dim tip = (From t In ctx.Tipo_Contrato
                   Where t.id_tipoContrato = id And t.descripcion = name
                   Select t).SingleOrDefault

        tip.estadobaja = 1
        ctx.SaveChanges()
    End Sub

    Shared Function ExisteTipoContrato(name As String) As Boolean
        Dim result As Boolean

        If (ctx.Tipo_Contrato.Any()) Then
            Dim ban = (From b In ctx.Tipo_Contrato
                       Where b.descripcion = name
                       Select b).SingleOrDefault
            result = True

        Else
            result = False

        End If
        Return result
    End Function

    Shared Sub MostrarBajas()
        Dim bajas = (From c In ctx.Tipo_Concepto
                     Where c.estadobaja = 1
                     Select c).ToString
    End Sub

End Class
