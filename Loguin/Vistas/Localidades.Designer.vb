<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Localidades
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblfiltro = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboprov = New System.Windows.Forms.ComboBox()
        Me.lblprovincia = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.dgvlocalidades = New System.Windows.Forms.DataGridView()
        Me.cmseliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnalta = New System.Windows.Forms.Button()
        Me.chbmostrartodo = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvlocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmseliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(590, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 17
        '
        'lblfiltro
        '
        Me.lblfiltro.AutoSize = True
        Me.lblfiltro.Location = New System.Drawing.Point(527, 60)
        Me.lblfiltro.Name = "lblfiltro"
        Me.lblfiltro.Size = New System.Drawing.Size(40, 13)
        Me.lblfiltro.TabIndex = 16
        Me.lblfiltro.Text = "Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboprov)
        Me.GroupBox2.Controls.Add(Me.lblprovincia)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.lblnombre)
        Me.GroupBox2.Controls.Add(Me.lblcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 163)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'cboprov
        '
        Me.cboprov.FormattingEnabled = True
        Me.cboprov.Location = New System.Drawing.Point(74, 69)
        Me.cboprov.Name = "cboprov"
        Me.cboprov.Size = New System.Drawing.Size(125, 21)
        Me.cboprov.TabIndex = 9
        '
        'lblprovincia
        '
        Me.lblprovincia.AutoSize = True
        Me.lblprovincia.Location = New System.Drawing.Point(18, 73)
        Me.lblprovincia.Name = "lblprovincia"
        Me.lblprovincia.Size = New System.Drawing.Size(51, 13)
        Me.lblprovincia.TabIndex = 8
        Me.lblprovincia.Text = "Provincia"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(74, 107)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(126, 20)
        Me.txtnombre.TabIndex = 7
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(74, 31)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(127, 20)
        Me.txtcodigo.TabIndex = 6
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(25, 107)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 3
        Me.lblnombre.Text = "Nombre"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(29, 34)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 2
        Me.lblcodigo.Text = "Codigo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnalta)
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 72)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(125, 22)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(71, 25)
        Me.btnactualizar.TabIndex = 5
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(26, 22)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(79, 23)
        Me.btnagregar.TabIndex = 4
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Location = New System.Drawing.Point(264, 20)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(64, 13)
        Me.lbltitulo.TabIndex = 13
        Me.lbltitulo.Text = "Localidades"
        '
        'dgvlocalidades
        '
        Me.dgvlocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlocalidades.Location = New System.Drawing.Point(471, 83)
        Me.dgvlocalidades.Name = "dgvlocalidades"
        Me.dgvlocalidades.Size = New System.Drawing.Size(308, 309)
        Me.dgvlocalidades.TabIndex = 12
        '
        'cmseliminar
        '
        Me.cmseliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.cmseliminar.Name = "cmseliminar"
        Me.cmseliminar.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'btnalta
        '
        Me.btnalta.Location = New System.Drawing.Point(220, 22)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(71, 25)
        Me.btnalta.TabIndex = 18
        Me.btnalta.Text = "Alta"
        Me.btnalta.UseVisualStyleBackColor = True
        '
        'chbmostrartodo
        '
        Me.chbmostrartodo.AutoSize = True
        Me.chbmostrartodo.Location = New System.Drawing.Point(471, 398)
        Me.chbmostrartodo.Name = "chbmostrartodo"
        Me.chbmostrartodo.Size = New System.Drawing.Size(89, 17)
        Me.chbmostrartodo.TabIndex = 18
        Me.chbmostrartodo.Text = "Mostrar Todo"
        Me.chbmostrartodo.UseVisualStyleBackColor = True
        '
        'Localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 444)
        Me.ContextMenuStrip = Me.cmseliminar
        Me.Controls.Add(Me.chbmostrartodo)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblfiltro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.dgvlocalidades)
        Me.Name = "Localidades"
        Me.Text = "Localidades"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvlocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmseliminar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblfiltro As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents dgvlocalidades As DataGridView
    Friend WithEvents lblprovincia As Label
    Friend WithEvents cboprov As ComboBox
    Friend WithEvents cmseliminar As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnalta As Button
    Friend WithEvents chbmostrartodo As CheckBox
End Class
