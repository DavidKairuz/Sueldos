<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObraSocial
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
        Me.dgvobra = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.brnagregar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnalta = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblfiltro = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.chbmostrar = New System.Windows.Forms.CheckBox()
        Me.cmseliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvobra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.cmseliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvobra
        '
        Me.dgvobra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvobra.Location = New System.Drawing.Point(469, 96)
        Me.dgvobra.Name = "dgvobra"
        Me.dgvobra.Size = New System.Drawing.Size(324, 277)
        Me.dgvobra.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Obras Sociales"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(30, 26)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 2
        Me.lblcodigo.Text = "Codigo"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(29, 61)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 3
        Me.lblnombre.Text = "Nombre"
        '
        'brnagregar
        '
        Me.brnagregar.Location = New System.Drawing.Point(26, 22)
        Me.brnagregar.Name = "brnagregar"
        Me.brnagregar.Size = New System.Drawing.Size(79, 23)
        Me.brnagregar.TabIndex = 4
        Me.brnagregar.Text = "Agregar"
        Me.brnagregar.UseVisualStyleBackColor = True
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
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(80, 23)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 6
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(81, 61)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(208, 20)
        Me.txtnombre.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnalta)
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.brnagregar)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 74)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'btnalta
        '
        Me.btnalta.Location = New System.Drawing.Point(215, 22)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(71, 25)
        Me.btnalta.TabIndex = 6
        Me.btnalta.Text = "Alta"
        Me.btnalta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.lblnombre)
        Me.GroupBox2.Controls.Add(Me.lblcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 139)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'lblfiltro
        '
        Me.lblfiltro.AutoSize = True
        Me.lblfiltro.Location = New System.Drawing.Point(530, 73)
        Me.lblfiltro.Name = "lblfiltro"
        Me.lblfiltro.Size = New System.Drawing.Size(40, 13)
        Me.lblfiltro.TabIndex = 10
        Me.lblfiltro.Text = "Buscar"
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(637, 70)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(121, 20)
        Me.txtfiltro.TabIndex = 11
        '
        'chbmostrar
        '
        Me.chbmostrar.AutoSize = True
        Me.chbmostrar.Location = New System.Drawing.Point(488, 388)
        Me.chbmostrar.Name = "chbmostrar"
        Me.chbmostrar.Size = New System.Drawing.Size(92, 17)
        Me.chbmostrar.TabIndex = 12
        Me.chbmostrar.Text = "Mostrar Todo:"
        Me.chbmostrar.UseVisualStyleBackColor = True
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
        'ObraSocial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 442)
        Me.ContextMenuStrip = Me.cmseliminar
        Me.Controls.Add(Me.chbmostrar)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.lblfiltro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvobra)
        Me.Name = "ObraSocial"
        Me.Text = "ObraSocial"
        CType(Me.dgvobra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.cmseliminar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvobra As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents brnagregar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblfiltro As Label
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents btnalta As Button
    Friend WithEvents chbmostrar As CheckBox
    Friend WithEvents cmseliminar As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
