Imports System.Text.RegularExpressions
Public Class Validar

    Public Sub validarnumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            'ElseIf e.KeyChar = "," And Not txtcosto.Text.IndexOf(",") Then
            '    e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo valores numericos", vbExclamation, "Aviso")
        End If
    End Sub



    '----------------------------------------------------------------
    Public Sub validartexto(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo caracteres alfabeticos", vbExclamation, "Aviso")
        End If
    End Sub
    '-------------------------------------------------------------------------
    Public Sub NumerosyDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'ElseIf e.KeyChar = "," And Not sender.Text.IndexOf(",") Then
            '    e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function IsMail(ByVal p_email As String) As Boolean
        Dim l_reg As New System.Text.RegularExpressions.Regex("^(([^<;>;()[\]\\.,;:\s@\""]+" &
        "(\.[^<;>;()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@" &
        "((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}" &
        "\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+" &
        "[a-zA-Z]{2,}))$")
        Return (l_reg.IsMatch(p_email))

    End Function


    Function validarprecio(ByVal pesos As Decimal) As Boolean
        Dim resp As Boolean
        Try
            Dim patron As Regex = New Regex("^(\d|-)?(\d|,)*\.?\d*$")
            If patron.IsMatch(pesos) = True Then
                resp = True
            Else resp = False
            End If

        Catch ex As Exception
            MsgBox("no anda")
        End Try
        Return resp
    End Function

    Function controlaprecio(ByVal costo As Decimal, ByVal precio As Decimal) As Boolean
        Dim resp As Boolean
        Try
            If costo <> 0 And precio <> 0 Then
                If precio > costo Then
                    resp = True
                ElseIf costo >= precio Then
                    resp = False
                End If
            Else
                MsgBox("Debe ingresar valores validos", MsgBoxStyle.Information, "Mensaje")
                resp = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resp
    End Function
    Public Sub condicion(sender As TextBox, e As KeyPressEventArgs)

        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        'If Len(cadena) = 0 Then
        '    filtro += "-"
        'End If
        If Len(cadena) > 0 Then
            filtro += ","
        End If


        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "," And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "," And Not cadena.IndexOf(",") Then
            e.Handled = True
        End If

    End Sub


End Class
