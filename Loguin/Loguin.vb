Public Class Loguin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        'Dim usuario As New Usuario

        If (validarCampos()) Then


            If (AccesoDatos.ValidateLogin(txtusuario.Text, txtpass.Text)) = True Then
                MsgBox("Acceso Exitoso", MsgBoxStyle.Exclamation, "Aviso")
                limpiar()
            Else
                MsgBox("Acceso Denegado", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Else
            limpiar()


        End If
    End Sub

    Private Function validarCampos() As Boolean
        Dim result As Boolean

        If (txtusuario.Text.Trim = "" Or txtpass.Text = "") Then
            MsgBox("Debe completar los campos", MsgBoxStyle.DefaultButton1, "Aceptar")
            result = False
        Else
            result = True
        End If
        Return result
    End Function

    Private Sub limpiar()
        txtpass.Clear()
        txtusuario.Clear()
    End Sub
End Class
