<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Convenio
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
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.dgvconvenio = New System.Windows.Forms.DataGridView()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.lblfiltrar = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.chktodo = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        CType(Me.dgvconvenio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(156, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(136, 25)
        Me.lbltitulo.TabIndex = 1
        Me.lbltitulo.Text = "CONVENIOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(100, 62)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(180, 20)
        Me.txtdescripcion.TabIndex = 9
        '
        'dgvconvenio
        '
        Me.dgvconvenio.AllowUserToAddRows = False
        Me.dgvconvenio.AllowUserToDeleteRows = False
        Me.dgvconvenio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvconvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvconvenio.Location = New System.Drawing.Point(389, 86)
        Me.dgvconvenio.Name = "dgvconvenio"
        Me.dgvconvenio.ReadOnly = True
        Me.dgvconvenio.Size = New System.Drawing.Size(314, 282)
        Me.dgvconvenio.TabIndex = 13
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(19, 35)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 14
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(109, 35)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 15
        Me.btnactualizar.Text = "Modificar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'lblfiltrar
        '
        Me.lblfiltrar.AutoSize = True
        Me.lblfiltrar.Location = New System.Drawing.Point(520, 43)
        Me.lblfiltrar.Name = "lblfiltrar"
        Me.lblfiltrar.Size = New System.Drawing.Size(32, 13)
        Me.lblfiltrar.TabIndex = 3
        Me.lblfiltrar.Text = "Filtrar"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(559, 40)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 19)
        Me.TextBox2.TabIndex = 8
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(193, 35)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 16
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'chktodo
        '
        Me.chktodo.AutoSize = True
        Me.chktodo.Checked = True
        Me.chktodo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chktodo.Location = New System.Drawing.Point(389, 42)
        Me.chktodo.Name = "chktodo"
        Me.chktodo.Size = New System.Drawing.Size(89, 17)
        Me.chktodo.TabIndex = 17
        Me.chktodo.Text = "Mostrar Todo"
        Me.chktodo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Controls.Add(Me.btneliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcod)
        Me.GroupBox2.Controls.Add(Me.lblcodigo)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 109)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(100, 16)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(107, 20)
        Me.txtcod.TabIndex = 11
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(41, 19)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 10
        Me.lblcodigo.Text = "Codigo"
        '
        'Convenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 479)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chktodo)
        Me.Controls.Add(Me.dgvconvenio)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblfiltrar)
        Me.Controls.Add(Me.lbltitulo)
        Me.Name = "Convenio"
        Me.Text = "Convenio"
        CType(Me.dgvconvenio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dgvconvenio As DataGridView
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents lblfiltrar As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents chktodo As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents lblcodigo As Label
End Class
