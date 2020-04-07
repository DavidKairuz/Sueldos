Public Class Concepto

    Shared AccesoDatosConcepto As New AccesoDatosConcepto
    Private Sub Panel1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Concepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostartipo()
    End Sub
    Sub mostartipo()
        AccesoDatosConcepto.MostrarTipoConcepto(cbotipo)
    End Sub


    Sub switchpanel(panel As Form)
        'Panel1.Controls.Clear()
        'panel.TopLevel = False
        'panel.Controls.Add(panel)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' switchpanel(TipoConcepto)
    End Sub

    Private Sub dgvconceptos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvconceptos.CellContentClick

    End Sub

    Private Sub cbotipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotipo.SelectedIndexChanged
        If cbotipo.SelectedIndex = 1 Then
            rbtnnoremunerativo.Checked = True
        Else
            rbtnremunerativo.Checked = True

        End If
    End Sub
End Class