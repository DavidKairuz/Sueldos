<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loguin
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
        Me.btningresar = New System.Windows.Forms.Button()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(172, 173)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 0
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(157, 74)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtusuario.TabIndex = 1
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(157, 118)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(100, 20)
        Me.txtpass.TabIndex = 2
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(85, 79)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(43, 13)
        Me.lblusuario.TabIndex = 3
        Me.lblusuario.Text = "Usuario"
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.Location = New System.Drawing.Point(85, 121)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblcontraseña.TabIndex = 4
        Me.lblcontraseña.Text = "Contraseña"
        '
        'Loguin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 281)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.btningresar)
        Me.Name = "Loguin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btningresar As Button
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblcontraseña As Label
End Class
