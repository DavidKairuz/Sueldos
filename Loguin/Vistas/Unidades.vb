Public Class Unidades
    Shared validacion As Validar = New Validar
    Shared AccesoDatosUnidad As New AccesoDatosUnidad

    Private Sub Unidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrargrid()
        Validar.configuraDGV(dgvunidades)


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
        If validacion.DatagridVacio(dgvunidades) Or (chbmostrart.Checked = False) Then
            MsgBox("No hay regitros para dar de alta", MsgBoxStyle.Critical, "Error")
        Else
            If dgvunidades.CurrentRow.Cells(2).Value = True Then
                AccesoDatosUnidad.DarAlta(ide)
                MsgBox("Se Actualizo el estado del registro exitosamente", MsgBoxStyle.Information, "Alta de registro")
                mostrargrid()
            End If
        End If
    End Sub

    Sub prueba(i As Integer)
        Select Case i
            Case 1
                validacion.DatagridVacio(dgvunidades)
                MsgBox("No hay regitros para dar de alta", MsgBoxStyle.Critical, "Error")
                Return
            Case 2
                If chbmostrart.Checked = False Then
                    MsgBox("No hay regitros para dar de alta", MsgBoxStyle.Critical, "Error")
                End If
            Case 3
                Dim ide = dgvunidades.CurrentRow().Cells(0).Value
                If dgvunidades.CurrentRow.Cells(2).Value = True Then
                    AccesoDatosUnidad.Daralta(ide)
                    MsgBox("Se Actualizo el estado del registro exitosamente", MsgBoxStyle.Information, "Alta de registro")
                    mostrargrid()
                End If
            Case Else
                MsgBox("El registro se encuentra activo", MsgBoxStyle.Exclamation, "Error")

        End Select




    End Sub


    'muestra solo los registros activos
    Sub mostrargrid()
        AccesoDatosUnidad.MostrarUnidadesA(dgvunidades)
    End Sub

    'Private Sub dgvunidades_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvunidades.CellValueChanged
    '    Dim IsDirty As Boolean
    '    If e.RowIndex = -1 Then Exit Sub
    '    'mark as dirty
    '    IsDirty = True
    '    MsgBox(IsDirty)
    '    '  End If
    'End Sub

    Private Sub dgvunidades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim j As Integer = dgvunidades.ColumnCount

        If validacion.DatagridVacio(dgvunidades) Then
            MsgBox("No hay regitros para dar de alta", MsgBoxStyle.Critical, "Error")
        Else
            If CBool(dgvunidades.CurrentRow.Cells(j).Value) = True Then
                Dim ide = dgvunidades.CurrentRow().Cells(0).Value

                ' If dgvunidades.CurrentRow.Cells(2).Value = True Then
                AccesoDatosUnidad.Daralta(ide)
                MsgBox("Se Actualizo el estado del registro exitosamente", MsgBoxStyle.Information, "Alta de registro")
                mostrargrid()
                'End If
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

        End If
    End Sub
    'muestra todos los registros y les añade un color dependiendo del estado
    Sub CargarTodosdgv()
        AccesoDatosUnidad.MostrarUnidadesT(dgvunidades)

        Dim y As Integer = dgvunidades.ColumnCount - 1

        Dim row As DataGridViewRow
        For Each row In dgvunidades.Rows
            If row.Cells(y).Value = True Then
                row.DefaultCellStyle.BackColor = Color.Red
            Else
                row.DefaultCellStyle.BackColor = Color.Green
            End If
        Next

    End Sub

    'Este checkbox muestra todos los registros incluso los dados de baja
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbmostrart.CheckedChanged

        If chbmostrart.Checked = True Then
            CargarTodosdgv()
        ElseIf chbmostrart.Checked = False Then
            mostrargrid()
        End If

    End Sub
    ' sirve para colocar condiciones lo vamos a usar despues
    Private Sub dgvunidades_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvunidades.CellFormatting
        'If dgvunidades.Columns(e.ColumnIndex).Name = "Estado" Then
        '    If dgvunidades.Columns(e.Value) = True Then
        '        e.CellStyle.ForeColor = Color.Red
        '    Else
        '        e.CellStyle.BackColor = Color.Purple
        '    End If

        'End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

    End Sub
End Class