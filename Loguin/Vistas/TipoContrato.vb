Public Class TipoContrato

    Shared AccesoDatosTContrato As New AccesoDatosTContrato
    Shared validacion As Validar = New Validar
    Private Sub TipoConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrargrid()
    End Sub


    Sub mostrargrid()
        AccesoDatosTContrato.mostrartipocontrato(dgvtipo)
    End Sub
    Private Sub cmseliminar_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmseliminar.Opening

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try
            If vacio() = True Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Aviso")
                txtdescripcion.Focus()
            Else

                If (AccesoDatosTContrato.Existe(txtdescripcion.Text) = False) Then

                    If MsgBox("Seguro agregar este registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                        AccesoDatosTContrato.AgregarTipoContrato(New Tipo_Contrato() With
                                        {
                                        .descripcion = txtdescripcion.Text,
                                        .estadobaja = 0
                                        })

                        AccesoDatosTContrato.MostrarTipoContrato(dgvtipo)
                        Limpiar()
                        MsgBox("La Tipo de contrato ha sido agregado exitosamente", MsgBoxStyle.Information, "Gestion")
                        ' ElseIf (AccesoDatosConvenio.Existe(txtdescripcion.Text) = True) Then

                    Else
                        Limpiar()
                    End If

                Else
                    MsgBox("Ya existe un registro con este nombre", MsgBoxStyle.Exclamation, "Alerta")
                    Limpiar()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function vacio() As Boolean
        Dim result As Boolean = False
        If txtdescripcion.Text.Trim = "" Then
            result = True
        Else
            result = False
        End If
        Return result
        '("El Tipo de convenio ha sido agregado exitosamente", MsgBoxStyle.Information, "Gestion Tipo Convenio")

    End Function
    Sub Limpiar()
        txtdescripcion.Clear()
        txtcod.Clear()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvtipo_DoubleClick(sender As Object, e As EventArgs) Handles dgvtipo.DoubleClick

        Try
            If Not (validacion.DatagridVacio(dgvtipo)) Then
                txtcod.Text = dgvtipo.CurrentRow.Cells(0).Value
                txtdescripcion.Text = dgvtipo.CurrentRow().Cells(1).Value

            Else
                MsgBox("No hay datos que asignar", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbmostrar.CheckedChanged
        If chbmostrar.Checked = True Then
            cargarDGtodos()
        Else
            mostrargrid()
        End If
    End Sub


    Sub cargarDGtodos()
        Try
            '  AccesoDatosTContrato.MostrarTipoContrato(dgvtipo)
            Dim row As DataGridViewRow
            For Each row In dgvtipo.Rows
                If row.Cells(2).Value = True Then
                    row.DefaultCellStyle.BackColor = Color.Red
                Else
                    row.DefaultCellStyle.BackColor = Color.Green
                End If
            Next
            Me.dgvtipo.Columns(3).Visible = False
        Catch ex As Exception

        End Try

    End Sub





    Private Sub btnalta_Click(sender As Object, e As EventArgs) Handles btnalta.Click
        Dim ide = dgvtipo.CurrentRow().Cells(0).Value
        If validacion.DatagridVacio(dgvtipo) Then
            MsgBox("No hay regitros para dar de alta", MsgBoxStyle.Critical, "Error")
        Else
            If dgvtipo.CurrentRow.Cells(2).Value = True Then
                AccesoDatosTContrato.DarAlta(ide)
                MsgBox("Se Actualizo el estado del registro exitosamente", MsgBoxStyle.Information, "Alta de registro")
                mostrargrid()
            End If
        End If
        '  Dim id As Integer = dgvtipo.CurrentRow().Cells(0).Value
        ' valorcolumna(dgvtipo, id)
    End Sub


    'Public Sub AltaRegistro(grid As DataGridView, btn As Button)
    '    Dim valida As Validar = New Validar
    '    Dim id = grid.CurrentRow.Cells(0).Value
    '    If valida.DatagridVacio(grid) Then
    '        MsgBox("No hay regitros para eliminar", MsgBoxStyle.Critical, "Error")
    '    Else
    '        valorcolumna(grid, id)
    '    End If
    'End Sub


    'Public Function valorcolumna(grid As DataGridView, id As Integer) As Integer
    '    Dim result As Integer
    '    For i As Integer = 0 To grid.ColumnCount
    '        If grid.ColumnHeadersVisible = "estadobaja" Then

    '            result = i

    '        Else
    '            result = -1
    '        End If
    '    Next
    '    Return result
    '    MsgBox("el estado esta en :" & result)
    'End Function

    Private Sub dgvtipo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtipo.CellContentClick

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try

            If validacion.DatagridVacio(dgvtipo) = True Then
                MsgBox("No hay registros para eliminar", MsgBoxStyle.Exclamation, "Atencion")
            Else
                If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvtipo.CurrentRow().Cells(0).Value
                    AccesoDatosTContrato.EliminarTipoContrato(ide)
                    AccesoDatosTContrato.MostrarTipoContrato(dgvtipo)
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
End Class