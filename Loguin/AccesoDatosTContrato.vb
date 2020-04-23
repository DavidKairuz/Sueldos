'Imports System.Data.Linq.SqlClient
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

    Shared Sub EliminarTipoContrato(id As Integer)
        Dim tip = (From t In ctx.Tipo_Contrato
                   Where t.id_tipoContrato = id
                   Select t).SingleOrDefault

        tip.estadobaja = 1
        ctx.SaveChanges()
    End Sub

    Shared Sub DarAlta(id As Integer)
        Dim tp = (From t In ctx.Tipo_Contrato
                  Where t.id_tipoContrato = id
                  Select t).SingleOrDefault
        tp.estadobaja = 0
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


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Tipo_Contrato) = (From c In ctx.Tipo_Contrato
                                              Where c.descripcion.StartsWith(txt.Text)
                                              Select c).ToList
        dgv.DataSource = tipo

    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Tipo_Contrato.Any(Function(o) o.descripcion = name) Then
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
