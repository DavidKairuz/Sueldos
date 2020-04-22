<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unidades
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
        Me.dgvunidades = New System.Windows.Forms.DataGridView()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lblfiltro = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.gbdatos = New System.Windows.Forms.GroupBox()
        Me.gbacciones = New System.Windows.Forms.GroupBox()
        Me.btnalta = New System.Windows.Forms.Button()
        Me.cmseliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgvunidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdatos.SuspendLayout()
        Me.gbacciones.SuspendLayout()
        Me.cmseliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvunidades
        '
        Me.dgvunidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvunidades.Location = New System.Drawing.Point(358, 78)
        Me.dgvunidades.Name = "dgvunidades"
        Me.dgvunidades.Size = New System.Drawing.Size(262, 250)
        Me.dgvunidades.TabIndex = 0
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(13, 28)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 1
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(106, 28)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 2
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Location = New System.Drawing.Point(277, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(52, 13)
        Me.lbltitulo.TabIndex = 5
        Me.lbltitulo.Text = "Unidades"
        '
        'lblfiltro
        '
        Me.lblfiltro.AutoSize = True
        Me.lblfiltro.Location = New System.Drawing.Point(366, 55)
        Me.lblfiltro.Name = "lblfiltro"
        Me.lblfiltro.Size = New System.Drawing.Size(40, 13)
        Me.lblfiltro.TabIndex = 6
        Me.lblfiltro.Text = "Buscar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(424, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 7
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(85, 21)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 20)
        Me.txtcod.TabIndex = 8
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(85, 71)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 9
        '
        'gbdatos
        '
        Me.gbdatos.Controls.Add(Me.txtnombre)
        Me.gbdatos.Controls.Add(Me.txtcod)
        Me.gbdatos.Controls.Add(Me.Label2)
        Me.gbdatos.Controls.Add(Me.Label1)
        Me.gbdatos.Location = New System.Drawing.Point(10, 57)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Size = New System.Drawing.Size(218, 112)
        Me.gbdatos.TabIndex = 10
        Me.gbdatos.TabStop = False
        Me.gbdatos.Text = "Datos"
        '
        'gbacciones
        '
        Me.gbacciones.Controls.Add(Me.btnalta)
        Me.gbacciones.Controls.Add(Me.btnagregar)
        Me.gbacciones.Controls.Add(Me.btnactualizar)
        Me.gbacciones.Location = New System.Drawing.Point(28, 216)
        Me.gbacciones.Name = "gbacciones"
        Me.gbacciones.Size = New System.Drawing.Size(286, 69)
        Me.gbacciones.TabIndex = 11
        Me.gbacciones.TabStop = False
        Me.gbacciones.Text = "Acciones"
        '
        'btnalta
        '
        Me.btnalta.Location = New System.Drawing.Point(205, 28)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(75, 23)
        Me.btnalta.TabIndex = 3
        Me.btnalta.Text = "Alta"
        Me.btnalta.UseVisualStyleBackColor = True
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(358, 334)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Mostrar Todo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Unidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 377)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.gbacciones)
        Me.Controls.Add(Me.gbdatos)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblfiltro)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.dgvunidades)
        Me.Name = "Unidades"
        Me.Text = "Unidades"
        CType(Me.dgvunidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.gbacciones.ResumeLayout(False)
        Me.cmseliminar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvunidades As DataGridView
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltitulo As Label
    Friend WithEvents lblfiltro As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents gbdatos As GroupBox
    Friend WithEvents gbacciones As GroupBox
    Friend WithEvents cmseliminar As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnalta As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
