Public Class Actividades
    Shared AccesoDatosActividad As New AccesoDatosActividad
    Shared validacion As Validar = New Validar

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

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
        Convenio.Show()
    End Sub

    Private Sub cbocategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocategoria.SelectedIndexChanged

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        Dim texto As String
        texto = txtnombre.Text
        validacion.validarnumeros(texto, e)
    End Sub

    'Private Sub txtconvenio_TextChanged(sender As Object, e As EventArgs) Handles txtconvenio.TextChanged
    '    Dim texto As String
    '    texto = txtnombre.Text
    '    validacion.validarnumeros(texto, e)
    'End Sub


    Sub ElegirCategoria()
        Try
            If cbocategoria.SelectedIndex.Equals(-1) Then

                MsgBox("Debe seleccionar una categoria", MsgBoxStyle.Critical, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.YesNo, "Continuar?")
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try
            If (vacio() = True) Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.Information, "Aviso")
            Else
                If MsgBox("Seguro desea actualizar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                    'AccesoDatosActividad.
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Function vacio() As Boolean
        Dim result As Boolean = False
        If txtconvenio.Text.Trim = "" Or txtnombre.Text.Trim = "" Or cbocategoria.SelectedIndex = -1 Or txtsbasico.Text.Trim = "" Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function
    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Try
            If (validacion.DatagridVacio(dgvactividad) = True) Then

                MsgBox("No hay registros para actualizar", MsgBoxStyle.Exclamation, "Atencion")

            Else
                If MsgBox("Seguro desea actualizar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Function prueba(txt As String, e As EventArgs) As String
    '    Dim texto As String
    '    Dim mensa As String = ""
    '    Try
    '        If (txt <> "") Then
    '            texto = txt
    '            validacion.validarnumeros(texto, e)
    '        Else

    '        End If

    '    Catch ex As Exception

    '    End Try


    'End Function

End Class