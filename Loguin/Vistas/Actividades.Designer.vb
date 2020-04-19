<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Actividades
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
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvactividad = New System.Windows.Forms.DataGridView()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblcategoria = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.cbocategoria = New System.Windows.Forms.ComboBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.cmseliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtsbasico = New System.Windows.Forms.TextBox()
        Me.lblmonto = New System.Windows.Forms.Label()
        Me.txtconvenio = New System.Windows.Forms.TextBox()
        Me.lblconvenio = New System.Windows.Forms.Label()
        Me.btnir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbocatcon = New System.Windows.Forms.ComboBox()
        CType(Me.dgvactividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmseliminar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(466, 74)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 15
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(547, 74)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(143, 20)
        Me.txtbuscar.TabIndex = 14
        '
        'dgvactividad
        '
        Me.dgvactividad.AllowUserToAddRows = False
        Me.dgvactividad.AllowUserToDeleteRows = False
        Me.dgvactividad.AllowUserToResizeColumns = False
        Me.dgvactividad.AllowUserToResizeRows = False
        Me.dgvactividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvactividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvactividad.Location = New System.Drawing.Point(347, 103)
        Me.dgvactividad.Name = "dgvactividad"
        Me.dgvactividad.Size = New System.Drawing.Size(354, 244)
        Me.dgvactividad.TabIndex = 13
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(103, 22)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(125, 20)
        Me.txtnombre.TabIndex = 11
        '
        'lblcategoria
        '
        Me.lblcategoria.AutoSize = True
        Me.lblcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategoria.Location = New System.Drawing.Point(21, 97)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(76, 16)
        Me.lblcategoria.TabIndex = 10
        Me.lblcategoria.Text = "Categoria"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(30, 23)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(67, 16)
        Me.lblnombre.TabIndex = 9
        Me.lblnombre.Text = "Nombre "
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(308, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(134, 25)
        Me.lbltitulo.TabIndex = 8
        Me.lbltitulo.Text = "Actividades"
        '
        'cbocategoria
        '
        Me.cbocategoria.FormattingEnabled = True
        Me.cbocategoria.Location = New System.Drawing.Point(236, 21)
        Me.cbocategoria.Name = "cbocategoria"
        Me.cbocategoria.Size = New System.Drawing.Size(40, 21)
        Me.cbocategoria.TabIndex = 16
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(49, 29)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 17
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(142, 29)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 18
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
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
        'txtsbasico
        '
        Me.txtsbasico.Enabled = False
        Me.txtsbasico.Location = New System.Drawing.Point(103, 137)
        Me.txtsbasico.Name = "txtsbasico"
        Me.txtsbasico.Size = New System.Drawing.Size(125, 20)
        Me.txtsbasico.TabIndex = 19
        Me.txtsbasico.Visible = False
        '
        'lblmonto
        '
        Me.lblmonto.AutoSize = True
        Me.lblmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonto.Location = New System.Drawing.Point(8, 138)
        Me.lblmonto.Name = "lblmonto"
        Me.lblmonto.Size = New System.Drawing.Size(89, 16)
        Me.lblmonto.TabIndex = 20
        Me.lblmonto.Text = "Monto base"
        Me.lblmonto.Visible = False
        '
        'txtconvenio
        '
        Me.txtconvenio.Location = New System.Drawing.Point(103, 60)
        Me.txtconvenio.Name = "txtconvenio"
        Me.txtconvenio.Size = New System.Drawing.Size(125, 20)
        Me.txtconvenio.TabIndex = 21
        '
        'lblconvenio
        '
        Me.lblconvenio.AutoSize = True
        Me.lblconvenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconvenio.Location = New System.Drawing.Point(24, 61)
        Me.lblconvenio.Name = "lblconvenio"
        Me.lblconvenio.Size = New System.Drawing.Size(73, 16)
        Me.lblconvenio.TabIndex = 22
        Me.lblconvenio.Text = "Convenio"
        '
        'btnir
        '
        Me.btnir.Location = New System.Drawing.Point(250, 60)
        Me.btnir.Name = "btnir"
        Me.btnir.Size = New System.Drawing.Size(26, 20)
        Me.btnir.TabIndex = 23
        Me.btnir.Text = "Ir"
        Me.btnir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbocatcon)
        Me.GroupBox1.Controls.Add(Me.btnir)
        Me.GroupBox1.Controls.Add(Me.lblconvenio)
        Me.GroupBox1.Controls.Add(Me.txtconvenio)
        Me.GroupBox1.Controls.Add(Me.lblmonto)
        Me.GroupBox1.Controls.Add(Me.txtsbasico)
        Me.GroupBox1.Controls.Add(Me.cbocategoria)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.lblcategoria)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 175)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnactualizar)
        Me.GroupBox2.Controls.Add(Me.btnagregar)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 73)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'Timer1
        '
        '
        'cbocatcon
        '
        Me.cbocatcon.Enabled = False
        Me.cbocatcon.FormattingEnabled = True
        Me.cbocatcon.Location = New System.Drawing.Point(103, 96)
        Me.cbocatcon.Name = "cbocatcon"
        Me.cbocatcon.Size = New System.Drawing.Size(121, 21)
        Me.cbocatcon.TabIndex = 24
        '
        'Actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 441)
        Me.ContextMenuStrip = Me.cmseliminar
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvactividad)
        Me.Controls.Add(Me.lbltitulo)
        Me.Name = "Actividades"
        Me.Text = "Actividades"
        CType(Me.dgvactividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmseliminar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvactividad As System.Windows.Forms.DataGridView
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblcategoria As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents cbocategoria As System.Windows.Forms.ComboBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents cmseliminar As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtsbasico As TextBox
    Friend WithEvents lblmonto As Label
    Friend WithEvents txtconvenio As TextBox
    Friend WithEvents lblconvenio As Label
    Friend WithEvents btnir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cbocatcon As ComboBox
End Class
