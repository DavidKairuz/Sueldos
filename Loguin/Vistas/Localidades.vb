Public Class Localidades
    Shared validacion As Validar = New Validar
    Shared AccesoDatosLocalidad As New AccesoDatosLocalidad
    Private Sub Localidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try

            If validacion.DatagridVacio(dgvlocalidades) = True Then
                MsgBox("No hay registros para eliminar", MsgBoxStyle.Exclamation, "Atencion")
            Else
                If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvlocalidades.CurrentRow().Cells(0).Value
                    Dim idp = CInt(cboprov.SelectedIndex.ToString)
                    AccesoDatosLocalidad.EliminarLocalidad(ide, idp)
                    AccesoDatosLocalidad.MostrarLocalidadesA(dgvlocalidades)
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
    Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        cboprov.SelectedValue = -1
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        If validacion.vacio(txtnombre) = True Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Aviso")
            txtnombre.Focus()
        Else

            If (AccesoDatosLocalidad.Existe(txtnombre.Text, CInt(cboprov.SelectedIndex.ToString)) = False) Then

                If MsgBox("Seguro agregar esta Unidad?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    AccesoDatosLocalidad.AgregarLocalidad(New Localidad() With
                                    {
                                    .descripcion = txtnombre.Text,
                                    .estadobaja = 0
                                    })

                    AccesoDatosLocalidad.MostrarLocalidadesA(dgvlocalidades)
                    limpiar()
                    MsgBox("El registro ha sido agregada exitosamente", MsgBoxStyle.Information, "Gestion Localidad")
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
End Class