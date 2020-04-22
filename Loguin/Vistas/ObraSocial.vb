Public Class ObraSocial

    Shared validacion As Validar = New Validar
    Shared AccesoDatosObrasocial As New AccesoDatosObraSocial


    Private Sub ObraSocial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrargrid()
    End Sub

    Sub mostrargrid()

    End Sub



    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try

            If validacion.DatagridVacio(dgvobra) = True Then
                MsgBox("No hay registros para eliminar", MsgBoxStyle.Exclamation, "Atencion")
            Else
                If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvobra.CurrentRow().Cells(0).Value
                    AccesoDatosTContrato.EliminarTipoContrato(ide)
                    AccesoDatosTContrato.MostrarTipoContrato(dgvobra)
                    MsgBox("Registro eliminado con exito", MsgBoxStyle.Information, "Eliminacion")
                    Limpiar()
                Else
                    MsgBox("Operacion cancelada", MsgBoxStyle.Critical, "Cancelacion")
                    Limpiar()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub Limpiar()

    End Sub


End Class