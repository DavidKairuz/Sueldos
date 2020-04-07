<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReciboSueldo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lbldni = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtactividad = New System.Windows.Forms.TextBox()
        Me.lblactividad = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtperiodo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfechaing = New System.Windows.Forms.TextBox()
        Me.lblingreso = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtciut = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdiastrabajo = New System.Windows.Forms.TextBox()
        Me.cbotipojornada = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gboxemp = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxemp.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(38, 20)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre"
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.Location = New System.Drawing.Point(53, 49)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(23, 13)
        Me.lbldni.TabIndex = 1
        Me.lbldni.Text = "Dni"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(98, 20)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 2
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(98, 50)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 3
        '
        'txtactividad
        '
        Me.txtactividad.Location = New System.Drawing.Point(294, 20)
        Me.txtactividad.Name = "txtactividad"
        Me.txtactividad.Size = New System.Drawing.Size(168, 20)
        Me.txtactividad.TabIndex = 4
        '
        'lblactividad
        '
        Me.lblactividad.AutoSize = True
        Me.lblactividad.Location = New System.Drawing.Point(237, 24)
        Me.lblactividad.Name = "lblactividad"
        Me.lblactividad.Size = New System.Drawing.Size(51, 13)
        Me.lblactividad.TabIndex = 5
        Me.lblactividad.Text = "Actividad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Recibo"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(83, 16)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(38, 46)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(37, 13)
        Me.lblfecha.TabIndex = 8
        Me.lblfecha.Text = "Fecha"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(81, 42)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(102, 20)
        Me.txtfecha.TabIndex = 9
        '
        'txtperiodo
        '
        Me.txtperiodo.Location = New System.Drawing.Point(528, 21)
        Me.txtperiodo.Name = "txtperiodo"
        Me.txtperiodo.Size = New System.Drawing.Size(100, 20)
        Me.txtperiodo.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(479, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Periodo"
        '
        'txtfechaing
        '
        Me.txtfechaing.Location = New System.Drawing.Point(294, 50)
        Me.txtfechaing.Name = "txtfechaing"
        Me.txtfechaing.Size = New System.Drawing.Size(84, 20)
        Me.txtfechaing.TabIndex = 13
        '
        'lblingreso
        '
        Me.lblingreso.AutoSize = True
        Me.lblingreso.Location = New System.Drawing.Point(234, 53)
        Me.lblingreso.Name = "lblingreso"
        Me.lblingreso.Size = New System.Drawing.Size(58, 13)
        Me.lblingreso.TabIndex = 12
        Me.lblingreso.Text = "Fecha Ing "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "CUIT"
        '
        'txtciut
        '
        Me.txtciut.Location = New System.Drawing.Point(98, 80)
        Me.txtciut.Name = "txtciut"
        Me.txtciut.Size = New System.Drawing.Size(100, 20)
        Me.txtciut.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Dias Trabajados"
        '
        'txtdiastrabajo
        '
        Me.txtdiastrabajo.Location = New System.Drawing.Point(294, 80)
        Me.txtdiastrabajo.Name = "txtdiastrabajo"
        Me.txtdiastrabajo.Size = New System.Drawing.Size(100, 20)
        Me.txtdiastrabajo.TabIndex = 17
        '
        'cbotipojornada
        '
        Me.cbotipojornada.FormattingEnabled = True
        Me.cbotipojornada.Location = New System.Drawing.Point(516, 76)
        Me.cbotipojornada.Name = "cbotipojornada"
        Me.cbotipojornada.Size = New System.Drawing.Size(121, 21)
        Me.cbotipojornada.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Tipo Jornada"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 198)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(394, 252)
        Me.DataGridView1.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(505, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(595, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(682, 15)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(30, 13)
        Me.lblhora.TabIndex = 23
        Me.lblhora.Text = "Hora"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(241, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Empresa"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(295, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(218, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'gboxemp
        '
        Me.gboxemp.Controls.Add(Me.Label5)
        Me.gboxemp.Controls.Add(Me.cbotipojornada)
        Me.gboxemp.Controls.Add(Me.txtdiastrabajo)
        Me.gboxemp.Controls.Add(Me.Label3)
        Me.gboxemp.Controls.Add(Me.txtciut)
        Me.gboxemp.Controls.Add(Me.Label2)
        Me.gboxemp.Controls.Add(Me.txtfechaing)
        Me.gboxemp.Controls.Add(Me.lblingreso)
        Me.gboxemp.Controls.Add(Me.Label1)
        Me.gboxemp.Controls.Add(Me.txtperiodo)
        Me.gboxemp.Controls.Add(Me.lblactividad)
        Me.gboxemp.Controls.Add(Me.txtactividad)
        Me.gboxemp.Controls.Add(Me.txtdni)
        Me.gboxemp.Controls.Add(Me.txtnombre)
        Me.gboxemp.Controls.Add(Me.lbldni)
        Me.gboxemp.Controls.Add(Me.lblnombre)
        Me.gboxemp.Location = New System.Drawing.Point(12, 68)
        Me.gboxemp.Name = "gboxemp"
        Me.gboxemp.Size = New System.Drawing.Size(674, 110)
        Me.gboxemp.TabIndex = 26
        Me.gboxemp.TabStop = False
        Me.gboxemp.Text = "Datos Empleado"
        '
        'ReciboSueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 537)
        Me.Controls.Add(Me.gboxemp)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ReciboSueldo"
        Me.Text = "ReciboSueldo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxemp.ResumeLayout(False)
        Me.gboxemp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnombre As Label
    Friend WithEvents lbldni As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txtactividad As TextBox
    Friend WithEvents lblactividad As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblfecha As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtperiodo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfechaing As TextBox
    Friend WithEvents lblingreso As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtciut As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdiastrabajo As TextBox
    Friend WithEvents cbotipojornada As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblhora As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents gboxemp As GroupBox
End Class
