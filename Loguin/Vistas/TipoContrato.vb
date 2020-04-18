Public Class TipoContrato

    Shared AccesoDatosTContrato As New AccesoDatosTContrato
    Private Sub TipoConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrargrid()
    End Sub


    Sub mostrargrid()
        AccesoDatosTContrato.mostrartipocontrato(dgvtipo)
    End Sub
    Private Sub cmseliminar_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmseliminar.Opening

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click


        '("El Tipo de convenio ha sido agregado exitosamente", MsgBoxStyle.Information, "Gestion Tipo Convenio")

    End Sub
    Sub Limpiar()
        txtdescripcion.Clear()
    End Sub



End Class