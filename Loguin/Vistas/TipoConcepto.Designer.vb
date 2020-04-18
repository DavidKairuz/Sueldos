<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoConcepto
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
        Me.dgvtipoc = New System.Windows.Forms.DataGridView()
        Me.gbdatos = New System.Windows.Forms.GroupBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblley = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.rbtnnoremu = New System.Windows.Forms.RadioButton()
        Me.rbtnremu = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.gbControl = New System.Windows.Forms.GroupBox()
        CType(Me.dgvtipoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdatos.SuspendLayout()
        Me.gbControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvtipoc
        '
        Me.dgvtipoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvtipoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtipoc.Location = New System.Drawing.Point(309, 55)
        Me.dgvtipoc.Name = "dgvtipoc"
        Me.dgvtipoc.Size = New System.Drawing.Size(274, 346)
        Me.dgvtipoc.TabIndex = 25
        '
        'gbdatos
        '
        Me.gbdatos.Controls.Add(Me.rbtnnoremu)
        Me.gbdatos.Controls.Add(Me.txtcod)
        Me.gbdatos.Controls.Add(Me.rbtnremu)
        Me.gbdatos.Controls.Add(Me.txtnombre)
        Me.gbdatos.Controls.Add(Me.lblley)
        Me.gbdatos.Controls.Add(Me.lbldescripcion)
        Me.gbdatos.Location = New System.Drawing.Point(12, 55)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Size = New System.Drawing.Size(265, 172)
        Me.gbdatos.TabIndex = 24
        Me.gbdatos.TabStop = False
        Me.gbdatos.Text = "Datos"
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(101, 30)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(69, 20)
        Me.txtcod.TabIndex = 9
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(101, 70)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(142, 20)
        Me.txtnombre.TabIndex = 7
        '
        'lblley
        '
        Me.lblley.AutoSize = True
        Me.lblley.Location = New System.Drawing.Point(44, 33)
        Me.lblley.Name = "lblley"
        Me.lblley.Size = New System.Drawing.Size(40, 13)
        Me.lblley.TabIndex = 3
        Me.lblley.Text = "Codigo"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(40, 73)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(44, 13)
        Me.lbldescripcion.TabIndex = 0
        Me.lbldescripcion.Text = "Nombre"
        '
        'rbtnnoremu
        '
        Me.rbtnnoremu.AutoSize = True
        Me.rbtnnoremu.Location = New System.Drawing.Point(140, 129)
        Me.rbtnnoremu.Name = "rbtnnoremu"
        Me.rbtnnoremu.Size = New System.Drawing.Size(103, 17)
        Me.rbtnnoremu.TabIndex = 6
        Me.rbtnnoremu.TabStop = True
        Me.rbtnnoremu.Text = "No remunerativo"
        Me.rbtnnoremu.UseVisualStyleBackColor = True
        '
        'rbtnremu
        '
        Me.rbtnremu.AutoSize = True
        Me.rbtnremu.Checked = True
        Me.rbtnremu.Location = New System.Drawing.Point(29, 129)
        Me.rbtnremu.Name = "rbtnremu"
        Me.rbtnremu.Size = New System.Drawing.Size(91, 17)
        Me.rbtnremu.TabIndex = 5
        Me.rbtnremu.TabStop = True
        Me.rbtnremu.Text = "Remunerativo"
        Me.rbtnremu.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(119, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(252, 15)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(148, 24)
        Me.lbltitulo.TabIndex = 20
        Me.lbltitulo.Text = "Tipo Concepto"
        '
        'gbControl
        '
        Me.gbControl.Controls.Add(Me.Button2)
        Me.gbControl.Controls.Add(Me.Button3)
        Me.gbControl.Location = New System.Drawing.Point(35, 233)
        Me.gbControl.Name = "gbControl"
        Me.gbControl.Size = New System.Drawing.Size(220, 84)
        Me.gbControl.TabIndex = 26
        Me.gbControl.TabStop = False
        Me.gbControl.Text = "Acciones"
        '
        'TipoConcepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 417)
        Me.Controls.Add(Me.gbControl)
        Me.Controls.Add(Me.dgvtipoc)
        Me.Controls.Add(Me.gbdatos)
        Me.Controls.Add(Me.lbltitulo)
        Me.Name = "TipoConcepto"
        Me.Text = "TipoConcepto"
        CType(Me.dgvtipoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.gbControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvtipoc As DataGridView
    Friend WithEvents gbdatos As GroupBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lblley As Label
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents rbtnnoremu As RadioButton
    Friend WithEvents rbtnremu As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents gbControl As GroupBox
End Class
