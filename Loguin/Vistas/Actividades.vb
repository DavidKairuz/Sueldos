Public Class Actividades
    Shared AccesoDatosActividad As New AccesoDatosActividad
    Private Sub Actividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarActividad()
        MostrarCategoria()
    End Sub


    Sub MostrarActividad()
        AccesoDatosActividad.MostrarGridActividad(dgvactividad)
    End Sub
    Sub MostrarCategoria()
        AccesoDatosActividad.MostrarCategorias(cbocategoria)
    End Sub

    Private Sub btnir_Click(sender As Object, e As EventArgs) Handles btnir.Click
        Convenio.ShowDialog()
    End Sub

    Private Sub cbocategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocategoria.SelectedIndexChanged

    End Sub
End Class