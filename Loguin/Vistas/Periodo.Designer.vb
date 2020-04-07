<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Periodo
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
        Me.lblmes = New System.Windows.Forms.Label()
        Me.lblaño = New System.Windows.Forms.Label()
        Me.cbomes = New System.Windows.Forms.ComboBox()
        Me.txtanio = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.dgvperiodo = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvperiodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmes
        '
        Me.lblmes.AutoSize = True
        Me.lblmes.Location = New System.Drawing.Point(70, 30)
        Me.lblmes.Name = "lblmes"
        Me.lblmes.Size = New System.Drawing.Size(30, 13)
        Me.lblmes.TabIndex = 0
        Me.lblmes.Text = "MES"
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.Location = New System.Drawing.Point(70, 76)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(30, 13)
        Me.lblaño.TabIndex = 1
        Me.lblaño.Text = "AÑO"
        '
        'cbomes
        '
        Me.cbomes.FormattingEnabled = True
        Me.cbomes.Location = New System.Drawing.Point(122, 27)
        Me.cbomes.Name = "cbomes"
        Me.cbomes.Size = New System.Drawing.Size(121, 21)
        Me.cbomes.TabIndex = 2
        '
        'txtanio
        '
        Me.txtanio.Location = New System.Drawing.Point(122, 73)
        Me.txtanio.Name = "txtanio"
        Me.txtanio.Size = New System.Drawing.Size(121, 20)
        Me.txtanio.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtanio)
        Me.GroupBox1.Controls.Add(Me.cbomes)
        Me.GroupBox1.Controls.Add(Me.lblaño)
        Me.GroupBox1.Controls.Add(Me.lblmes)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 160)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(151, 247)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 5
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(320, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(93, 25)
        Me.lbltitulo.TabIndex = 6
        Me.lbltitulo.Text = "Periodo"
        '
        'dgvperiodo
        '
        Me.dgvperiodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvperiodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvperiodo.Location = New System.Drawing.Point(459, 59)
        Me.dgvperiodo.Name = "dgvperiodo"
        Me.dgvperiodo.Size = New System.Drawing.Size(270, 258)
        Me.dgvperiodo.TabIndex = 7
        '
        'Periodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 366)
        Me.Controls.Add(Me.dgvperiodo)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Periodo"
        Me.Text = "Periodo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvperiodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblmes As Label
    Friend WithEvents lblaño As Label
    Friend WithEvents cbomes As ComboBox
    Friend WithEvents txtanio As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnaceptar As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents dgvperiodo As DataGridView
End Class
