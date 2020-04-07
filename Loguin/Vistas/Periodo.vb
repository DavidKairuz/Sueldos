Public Class Periodo
    Shared AccesoDatosPeriodo As New AccesoDatosPeriodo
    Private Sub Periodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
    End Sub

    Sub CargarGrid()
        AccesoDatosPeriodo.MostrarPeriodogrid(dgvperiodo)
    End Sub
End Class