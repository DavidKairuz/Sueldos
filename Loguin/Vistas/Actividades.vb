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