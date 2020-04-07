Public Class Empleados
    Private Sub VEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class