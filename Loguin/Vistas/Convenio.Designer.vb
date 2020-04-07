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
        CType(Me.dgvconvenio, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Location = New System.Drawing.Point(66, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(121, 65)
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
        Me.btnagregar.Location = New System.Drawing.Point(92, 132)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 14
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(182, 132)
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
        Me.btneliminar.Location = New System.Drawing.Point(266, 132)
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
        'Convenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 479)
        Me.Controls.Add(Me.chktodo)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.dgvconvenio)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblfiltrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltitulo)
        Me.Name = "Convenio"
        Me.Text = "Convenio"
        CType(Me.dgvconvenio, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
