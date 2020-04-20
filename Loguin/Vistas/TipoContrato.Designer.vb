<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoContrato
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
        Me.dgvtipo = New System.Windows.Forms.DataGridView()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.cmseliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbmostrar = New System.Windows.Forms.CheckBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.gbdatos = New System.Windows.Forms.GroupBox()
        CType(Me.dgvtipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmseliminar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbdatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvtipo
        '
        Me.dgvtipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvtipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtipo.Location = New System.Drawing.Point(362, 106)
        Me.dgvtipo.Name = "dgvtipo"
        Me.dgvtipo.ReadOnly = True
        Me.dgvtipo.Size = New System.Drawing.Size(286, 271)
        Me.dgvtipo.TabIndex = 0
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(26, 29)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(64, 22)
        Me.btnagregar.TabIndex = 4
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(112, 31)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 22)
        Me.btnactualizar.TabIndex = 5
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(15, 70)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 3
        Me.lblnombre.Text = "Nombre"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(65, 67)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(199, 20)
        Me.txtdescripcion.TabIndex = 2
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
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(261, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(142, 25)
        Me.lbltitulo.TabIndex = 10
        Me.lbltitulo.Text = "Tipo Contrato"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(209, 30)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(64, 22)
        Me.btneliminar.TabIndex = 6
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(517, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Filtrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btneliminar)
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 71)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'chbmostrar
        '
        Me.chbmostrar.AutoSize = True
        Me.chbmostrar.Location = New System.Drawing.Point(362, 75)
        Me.chbmostrar.Name = "chbmostrar"
        Me.chbmostrar.Size = New System.Drawing.Size(89, 17)
        Me.chbmostrar.TabIndex = 15
        Me.chbmostrar.Text = "Mostrar Todo"
        Me.chbmostrar.UseVisualStyleBackColor = True
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(65, 29)
        Me.txtcod.MaxLength = 20
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(79, 20)
        Me.txtcod.TabIndex = 1
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(15, 32)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(40, 13)
        Me.lblcod.TabIndex = 16
        Me.lblcod.Text = "Codigo"
        '
        'gbdatos
        '
        Me.gbdatos.Controls.Add(Me.txtcod)
        Me.gbdatos.Controls.Add(Me.lblcod)
        Me.gbdatos.Controls.Add(Me.txtdescripcion)
        Me.gbdatos.Controls.Add(Me.lblnombre)
        Me.gbdatos.Location = New System.Drawing.Point(12, 88)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Size = New System.Drawing.Size(316, 130)
        Me.gbdatos.TabIndex = 18
        Me.gbdatos.TabStop = False
        Me.gbdatos.Text = "Datos"
        '
        'TipoContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 449)
        Me.ContextMenuStrip = Me.cmseliminar
        Me.Controls.Add(Me.gbdatos)
        Me.Controls.Add(Me.chbmostrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.dgvtipo)
        Me.Name = "TipoContrato"
        Me.Text = "TipoContrato"
        CType(Me.dgvtipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmseliminar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvtipo As DataGridView
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents cmseliminar As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chbmostrar As CheckBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents lblcod As Label
    Friend WithEvents gbdatos As GroupBox
End Class
