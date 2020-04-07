<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Concepto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.lblley = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.rbtnremunerativo = New System.Windows.Forms.RadioButton()
        Me.rbtnnoremunerativo = New System.Windows.Forms.RadioButton()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.txtley = New System.Windows.Forms.TextBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmseliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvconceptos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvconceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(30, 21)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(44, 13)
        Me.lbldescripcion.TabIndex = 0
        Me.lbldescripcion.Text = "Nombre"
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Location = New System.Drawing.Point(44, 52)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(31, 13)
        Me.lblvalor.TabIndex = 1
        Me.lblvalor.Text = "Valor"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(12, 36)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(40, 13)
        Me.lblestado.TabIndex = 2
        Me.lblestado.Text = "Estado"
        '
        'lblley
        '
        Me.lblley.AutoSize = True
        Me.lblley.Location = New System.Drawing.Point(34, 89)
        Me.lblley.Name = "lblley"
        Me.lblley.Size = New System.Drawing.Size(40, 13)
        Me.lblley.TabIndex = 3
        Me.lblley.Text = "Codigo"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(290, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(110, 24)
        Me.lbltitulo.TabIndex = 4
        Me.lbltitulo.Text = "Conceptos"
        '
        'rbtnremunerativo
        '
        Me.rbtnremunerativo.AutoSize = True
        Me.rbtnremunerativo.Location = New System.Drawing.Point(67, 19)
        Me.rbtnremunerativo.Name = "rbtnremunerativo"
        Me.rbtnremunerativo.Size = New System.Drawing.Size(91, 17)
        Me.rbtnremunerativo.TabIndex = 5
        Me.rbtnremunerativo.TabStop = True
        Me.rbtnremunerativo.Text = "Remunerativo"
        Me.rbtnremunerativo.UseVisualStyleBackColor = True
        '
        'rbtnnoremunerativo
        '
        Me.rbtnnoremunerativo.AutoSize = True
        Me.rbtnnoremunerativo.Location = New System.Drawing.Point(67, 51)
        Me.rbtnnoremunerativo.Name = "rbtnnoremunerativo"
        Me.rbtnnoremunerativo.Size = New System.Drawing.Size(103, 17)
        Me.rbtnnoremunerativo.TabIndex = 6
        Me.rbtnnoremunerativo.TabStop = True
        Me.rbtnnoremunerativo.Text = "No remunerativo"
        Me.rbtnnoremunerativo.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(101, 21)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(121, 20)
        Me.txtnombre.TabIndex = 7
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(101, 49)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(121, 20)
        Me.txtvalor.TabIndex = 8
        '
        'txtley
        '
        Me.txtley.Location = New System.Drawing.Point(101, 82)
        Me.txtley.Name = "txtley"
        Me.txtley.Size = New System.Drawing.Size(121, 20)
        Me.txtley.TabIndex = 9
        '
        'cbotipo
        '
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(101, 117)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(121, 21)
        Me.cbotipo.TabIndex = 10
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(46, 120)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(28, 13)
        Me.lbltipo.TabIndex = 11
        Me.lbltipo.Text = "Tipo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(77, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(168, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmseliminar
        '
        Me.cmseliminar.Name = "cmseliminar"
        Me.cmseliminar.Size = New System.Drawing.Size(61, 4)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnnoremunerativo)
        Me.GroupBox1.Controls.Add(Me.rbtnremunerativo)
        Me.GroupBox1.Controls.Add(Me.lblestado)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 80)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lbltipo)
        Me.GroupBox2.Controls.Add(Me.cbotipo)
        Me.GroupBox2.Controls.Add(Me.txtley)
        Me.GroupBox2.Controls.Add(Me.txtvalor)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.lblley)
        Me.GroupBox2.Controls.Add(Me.lblvalor)
        Me.GroupBox2.Controls.Add(Me.lbldescripcion)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 176)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'dgvconceptos
        '
        Me.dgvconceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvconceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvconceptos.Location = New System.Drawing.Point(347, 49)
        Me.dgvconceptos.Name = "dgvconceptos"
        Me.dgvconceptos.Size = New System.Drawing.Size(316, 346)
        Me.dgvconceptos.TabIndex = 19
        '
        'Concepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 423)
        Me.ContextMenuStrip = Me.cmseliminar
        Me.Controls.Add(Me.dgvconceptos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbltitulo)
        Me.Name = "Concepto"
        Me.Text = "Concepto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvconceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents lblvalor As System.Windows.Forms.Label
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents lblley As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents rbtnremunerativo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnnoremunerativo As System.Windows.Forms.RadioButton
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents txtley As System.Windows.Forms.TextBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cmseliminar As ContextMenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvconceptos As DataGridView
End Class
