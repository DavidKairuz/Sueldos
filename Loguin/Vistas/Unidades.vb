Public Class Unidades
    Shared validacion As Validar = New Validar
    Shared AccesoDatosUnidad As New AccesoDatosUnidad

    Private Sub Unidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrargrid()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If validacion.vacio(txtnombre) = True Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Aviso")
            txtnombre.Focus()
        Else

            If (AccesoDatosUnidad.Existe(txtnombre.Text) = False) Then

                If MsgBox("Seguro agregar esta Unidad?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    AccesoDatosUnidad.AgregarUnidad(New Unidad() With
                                    {
                                    .descripcion = txtnombre.Text,
                                    .estadobaja = 0
                                    })

                    AccesoDatosUnidad.MostrarUnidadesA(dgvunidades)
                    limpiar()
                    MsgBox("La unidad ha sido agregada exitosamente", MsgBoxStyle.Information, "Gestion Unidad")
                    ' ElseIf (AccesoDatosConvenio.Existe(txtdescripcion.Text) = True) Then

                Else
                    limpiar()
                End If

            Else
                MsgBox("Ya existe un registro con este nombre", MsgBoxStyle.Exclamation, "Alerta")
                limpiar()
            End If

        End If

    End Sub

    Sub limpiar()
        txtnombre.Clear()
        txtcod.Clear()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try

            If validacion.DatagridVacio(dgvunidades) = True Then
                MsgBox("No hay registros para eliminar", MsgBoxStyle.Exclamation, "Atencion")
            Else
                If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvunidades.CurrentRow().Cells(0).Value
                    AccesoDatosUnidad.EliminarUnidad(ide)
                    AccesoDatosUnidad.MostrarUnidadesA(dgvunidades)
                    MsgBox("Registro eliminado con exito", MsgBoxStyle.Information, "Eliminacion")
                    limpiar()
                Else
                    MsgBox("Operacion cancelada", MsgBoxStyle.Critical, "Cancelacion")
                    limpiar()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnalta_Click(sender As Object, e As EventArgs) Handles btnalta.Click
        Dim ide = dgvunidades.CurrentRow().Cells(0).Value
        If validacion.DatagridVacio(dgvunidades) Then
            MsgBox("No hay regitros para dar de alta", MsgBoxStyle.Critical, "Error")
        Else
            If dgvunidades.CurrentRow.Cells(2).Value = True Then
                AccesoDatosUnidad.DarAlta(ide)
                MsgBox("Se Actualizo el estado del registro exitosamente", MsgBoxStyle.Information, "Alta de registro")
                mostrargrid()
            End If
        End If
    End Sub



    Sub mostrargrid()
        AccesoDatosUnidad.MostrarUnidadesA(dgvunidades)
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged

    End Sub
End Class