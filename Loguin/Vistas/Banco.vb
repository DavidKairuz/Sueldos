Public Class Banco

    Shared AccesoDatosBanco As New AccesoDatosBanco
    Private Sub Banco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridBanco()
    End Sub


    Sub cargarGridBanco()
        AccesoDatosBanco.MostrarBancosGrid(dgvbanco)
    End Sub


    Sub limpiar()
        txtdireccion.Clear()
        txtnombre.Clear()
        txtsucursal.Clear()
        txttelefono.Clear()
        txtid.Clear()
    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try
            'considerar un case switch por las posibles combinaciones
            Dim ide = CInt(txtid.Text)

            If (ValidarVacio() = True) Then


            ElseIf ValidarExiste = True Then


            Else ' MsgBox("Desea continuar?", MsgBoxStyle.YesNo)

                If MsgBox("Seguro desea agregar este banco?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                    AccesoDatosBanco.AgregarBanco(New Banco With
                    {
                    .nombre = txtnombre.Text,
                    .direccion = txtdireccion.Text,
                    .telefono = txttelefono.Text,
                    .sucursal_banco = txtsucursal.Text
                    })
                    cargarGridBanco()
                    limpiar()
                Else
                    limpiar()
                End If
            End If
        Catch ex As Exception

        End Try
        ' ValidadExiste()

    End Sub

    Function ValidarVacio() As Boolean
        Dim valor As Boolean = False
        If (txtid.Text Is Nothing Or txtnombre.Text Is Nothing Or txtdireccion Is Nothing Or txttelefono.Text Is Nothing Or txtsucursal.Text Is Nothing) Then
            valor = True
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Information)
        Else
            valor = False

        End If
        Return valor

    End Function
    Function ValidarExiste() As Boolean
        Dim va As Boolean = False
        Dim ide = CInt(txtid.Text)

        If (AccesoDatosBanco.Existe(ide) = True) Then
            va = True
            MsgBox("Ya existe un registro con estos datos", MsgBoxStyle.OkOnly, "Registro")

        Else
            va = False
            '  MsgBox("Desea continuar?", MsgBoxStyle.YesNo)
        End If
        Return va
    End Function

    Private Sub dgvbanco_Click(sender As Object, e As EventArgs) Handles dgvbanco.Click
        Dim ide = dgvbanco.CurrentRow().Cells(0).Value
        Dim bank As Banco = AccesoDatosBanco.MostrarBancoID(ide)
        txtdireccion.Text = bank.direccion
        txtnombre.Text = CStr(bank.nombre)
        txtsucursal.Text = CInt(bank.sucursal_banco)
        txttelefono.Text = bank.telefono
        txtid.Text = CInt(bank.id_banco)

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub gbcontroles_Enter(sender As Object, e As EventArgs) Handles gbcontroles.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblsucursal_Click(sender As Object, e As EventArgs) Handles lblsucursal.Click

    End Sub

    Private Sub lbltelefono_Click(sender As Object, e As EventArgs) Handles lbltelefono.Click

    End Sub

    Private Sub lbldireccion_Click(sender As Object, e As EventArgs) Handles lbldireccion.Click

    End Sub

    Private Sub lblnombre_Click(sender As Object, e As EventArgs) Handles lblnombre.Click

    End Sub
End Class