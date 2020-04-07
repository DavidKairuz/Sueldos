<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banco
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
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lblsucursal = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtsucursal = New System.Windows.Forms.TextBox()
        Me.lblbanco = New System.Windows.Forms.Label()
        Me.dgvbanco = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbcontroles = New System.Windows.Forms.GroupBox()
        Me.gbfiltro = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvbanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gbcontroles.SuspendLayout()
        Me.gbfiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(25, 21)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 15)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.Location = New System.Drawing.Point(15, 63)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(68, 15)
        Me.lbldireccion.TabIndex = 1
        Me.lbldireccion.Text = "Direccion"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.Location = New System.Drawing.Point(20, 104)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(63, 15)
        Me.lbltelefono.TabIndex = 2
        Me.lbltelefono.Text = "Telefono"
        '
        'lblsucursal
        '
        Me.lblsucursal.AutoSize = True
        Me.lblsucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsucursal.Location = New System.Drawing.Point(20, 144)
        Me.lblsucursal.Name = "lblsucursal"
        Me.lblsucursal.Size = New System.Drawing.Size(63, 15)
        Me.lblsucursal.TabIndex = 3
        Me.lblsucursal.Text = "Sucursal"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(89, 21)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(258, 20)
        Me.txtnombre.TabIndex = 4
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(89, 62)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(258, 20)
        Me.txtdireccion.TabIndex = 5
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(89, 103)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(179, 20)
        Me.txttelefono.TabIndex = 6
        '
        'txtsucursal
        '
        Me.txtsucursal.Location = New System.Drawing.Point(89, 144)
        Me.txtsucursal.Name = "txtsucursal"
        Me.txtsucursal.Size = New System.Drawing.Size(100, 20)
        Me.txtsucursal.TabIndex = 7
        '
        'lblbanco
        '
        Me.lblbanco.AutoSize = True
        Me.lblbanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbanco.Location = New System.Drawing.Point(321, 9)
        Me.lblbanco.Name = "lblbanco"
        Me.lblbanco.Size = New System.Drawing.Size(69, 24)
        Me.lblbanco.TabIndex = 8
        Me.lblbanco.Text = "Banco"
        '
        'dgvbanco
        '
        Me.dgvbanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvbanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbanco.Location = New System.Drawing.Point(407, 72)
        Me.dgvbanco.Name = "dgvbanco"
        Me.dgvbanco.Size = New System.Drawing.Size(309, 391)
        Me.dgvbanco.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "por nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(79, 220)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 12
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(168, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'gbcontroles
        '
        Me.gbcontroles.Controls.Add(Me.Label2)
        Me.gbcontroles.Controls.Add(Me.txtid)
        Me.gbcontroles.Controls.Add(Me.btnlimpiar)
        Me.gbcontroles.Controls.Add(Me.Button2)
        Me.gbcontroles.Controls.Add(Me.btnagregar)
        Me.gbcontroles.Controls.Add(Me.txtsucursal)
        Me.gbcontroles.Controls.Add(Me.txttelefono)
        Me.gbcontroles.Controls.Add(Me.txtdireccion)
        Me.gbcontroles.Controls.Add(Me.txtnombre)
        Me.gbcontroles.Controls.Add(Me.lblsucursal)
        Me.gbcontroles.Controls.Add(Me.lbltelefono)
        Me.gbcontroles.Controls.Add(Me.lbldireccion)
        Me.gbcontroles.Controls.Add(Me.lblnombre)
        Me.gbcontroles.Location = New System.Drawing.Point(12, 96)
        Me.gbcontroles.Name = "gbcontroles"
        Me.gbcontroles.Size = New System.Drawing.Size(370, 267)
        Me.gbcontroles.TabIndex = 14
        Me.gbcontroles.TabStop = False
        Me.gbcontroles.Text = "Datos"
        '
        'gbfiltro
        '
        Me.gbfiltro.Controls.Add(Me.TextBox1)
        Me.gbfiltro.Controls.Add(Me.Label1)
        Me.gbfiltro.Location = New System.Drawing.Point(422, 24)
        Me.gbfiltro.Name = "gbfiltro"
        Me.gbfiltro.Size = New System.Drawing.Size(256, 34)
        Me.gbfiltro.TabIndex = 15
        Me.gbfiltro.TabStop = False
        Me.gbfiltro.Text = "Filtro"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(255, 220)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 14
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(91, 183)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(23, 20)
        Me.txtid.TabIndex = 16
        Me.txtid.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ID"
        Me.Label2.Visible = False
        '
        'Banco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 494)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.gbfiltro)
        Me.Controls.Add(Me.gbcontroles)
        Me.Controls.Add(Me.dgvbanco)
        Me.Controls.Add(Me.lblbanco)
        Me.Name = "Banco"
        Me.Text = "Banco"
        CType(Me.dgvbanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gbcontroles.ResumeLayout(False)
        Me.gbcontroles.PerformLayout()
        Me.gbfiltro.ResumeLayout(False)
        Me.gbfiltro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents lblsucursal As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtsucursal As System.Windows.Forms.TextBox
    Friend WithEvents lblbanco As System.Windows.Forms.Label
    Friend WithEvents dgvbanco As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbcontroles As GroupBox
    Friend WithEvents gbfiltro As GroupBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label2 As Label
End Class
