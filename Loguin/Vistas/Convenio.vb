Public Class Convenio
    Shared AccesoDatosConvenio As New AccesoDatosConvenio
    Shared validacion As Validar = New Validar

    Private Sub Convenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()
    End Sub

    Sub mostrarDatos()

        AccesoDatosConvenio.MostrarGridConvenio(dgvconvenio)
    End Sub

    Sub limpiar()
        txtdescripcion.Clear()
    End Sub


    Function vacio() As Boolean
        Dim result As Boolean = False
        If (txtdescripcion.Text.Trim = "") Then
            result = True

        Else
            result = False
        End If
        Return result
    End Function


    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click


        If vacio() = True Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Information, "Aviso")
            txtdescripcion.Focus()
        Else

            If (AccesoDatosConvenio.Existe(txtdescripcion.Text) = False) Then


                If MsgBox("Seguro agregar este convenio?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    AccesoDatosConvenio.AgregarConvenio(New Convenio() With
            {
            .descripcion = txtdescripcion.Text,
            .estadobaja = 0
            })

                    AccesoDatosConvenio.MostrarGridConvenio(dgvconvenio)
                    limpiar()
                    MsgBox("El Convenio ha sido agregado exitosamente", MsgBoxStyle.Information, "Gestion Convenio")
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

    Private Sub btnir_Click(sender As Object, e As EventArgs) 
        TipoContrato.ShowDialog()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Dim ide = dgvconvenio.CurrentRow().Cells(0).Value
        Dim nom = txtdescripcion.Text
        AccesoDatosConvenio.ActualizarConvenio(ide, nom)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MsgBox("Seguro desea Eliminar este Convenio?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

            Dim ide = dgvconvenio.CurrentRow().Cells(0).Value
            AccesoDatosConvenio.EliminarConvenio(ide)
            AccesoDatosConvenio.MostrarGridConvenio(dgvconvenio)
        Else
            MsgBox("")

        End If
    End Sub

    Private Sub dgvconvenio_Click(sender As Object, e As EventArgs) Handles dgvconvenio.Click
        Dim ide = dgvconvenio.CurrentRow().Cells(0).Value
        Dim con As Convenio = AccesoDatosConvenio.MostrarConvenioID(ide)
        txtdescripcion.Text = con.descripcion

    End Sub


    'mueve datos de convenio a actividades validando existan datos
    Private Sub dgvconvenio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvconvenio.CellDoubleClick

        Try
            If Not (validacion.DatagridVacio(dgvconvenio)) Then
                Actividades.txtconvenio.Text = dgvconvenio.CurrentRow().Cells(1).Value
                Me.Close()

            Else
                MsgBox("No hay datos que asignar", MsgBoxStyle.Exclamation, "")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try

    End Sub

End Class