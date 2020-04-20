Public Class Unidades
    Shared validacion As Validar = New Validar
    Shared AccesoDatosUnidad As New AccesoDatosUnidad
    Private Sub Unidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub txtcod_TextChanged(sender As Object, e As EventArgs) Handles txtcod.TextChanged

    End Sub
    Sub limpiar()
        txtnombre.Clear()
        txtcod.Clear()
    End Sub


End Class