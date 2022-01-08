<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_UsuarioYContraseña
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
        Me.Lab_Login_Usuario = New System.Windows.Forms.Label()
        Me.Lab_Login_Contraseña = New System.Windows.Forms.Label()
        Me.TtBo_Login_Usuario = New System.Windows.Forms.TextBox()
        Me.TtBo_Login_Contraseña = New System.Windows.Forms.TextBox()
        Me.Btn_Login_Ingresar = New System.Windows.Forms.Button()
        Me.Btn_Login_Cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lab_Login_Usuario
        '
        Me.Lab_Login_Usuario.AutoSize = True
        Me.Lab_Login_Usuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Login_Usuario.Location = New System.Drawing.Point(63, 51)
        Me.Lab_Login_Usuario.Name = "Lab_Login_Usuario"
        Me.Lab_Login_Usuario.Size = New System.Drawing.Size(87, 25)
        Me.Lab_Login_Usuario.TabIndex = 0
        Me.Lab_Login_Usuario.Text = "Usuario:"
        '
        'Lab_Login_Contraseña
        '
        Me.Lab_Login_Contraseña.AutoSize = True
        Me.Lab_Login_Contraseña.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Login_Contraseña.Location = New System.Drawing.Point(63, 105)
        Me.Lab_Login_Contraseña.Name = "Lab_Login_Contraseña"
        Me.Lab_Login_Contraseña.Size = New System.Drawing.Size(122, 25)
        Me.Lab_Login_Contraseña.TabIndex = 1
        Me.Lab_Login_Contraseña.Text = "Contraseña:"
        '
        'TtBo_Login_Usuario
        '
        Me.TtBo_Login_Usuario.Location = New System.Drawing.Point(199, 57)
        Me.TtBo_Login_Usuario.MaxLength = 30
        Me.TtBo_Login_Usuario.Name = "TtBo_Login_Usuario"
        Me.TtBo_Login_Usuario.Size = New System.Drawing.Size(149, 20)
        Me.TtBo_Login_Usuario.TabIndex = 1
        Me.TtBo_Login_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Login_Contraseña
        '
        Me.TtBo_Login_Contraseña.Location = New System.Drawing.Point(199, 111)
        Me.TtBo_Login_Contraseña.MaxLength = 30
        Me.TtBo_Login_Contraseña.Name = "TtBo_Login_Contraseña"
        Me.TtBo_Login_Contraseña.Size = New System.Drawing.Size(149, 20)
        Me.TtBo_Login_Contraseña.TabIndex = 2
        Me.TtBo_Login_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TtBo_Login_Contraseña.UseSystemPasswordChar = True
        '
        'Btn_Login_Ingresar
        '
        Me.Btn_Login_Ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Login_Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login_Ingresar.Location = New System.Drawing.Point(239, 146)
        Me.Btn_Login_Ingresar.Name = "Btn_Login_Ingresar"
        Me.Btn_Login_Ingresar.Size = New System.Drawing.Size(109, 31)
        Me.Btn_Login_Ingresar.TabIndex = 3
        Me.Btn_Login_Ingresar.Text = "Ingresar"
        Me.Btn_Login_Ingresar.UseVisualStyleBackColor = False
        '
        'Btn_Login_Cancelar
        '
        Me.Btn_Login_Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Login_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login_Cancelar.Location = New System.Drawing.Point(169, 146)
        Me.Btn_Login_Cancelar.Name = "Btn_Login_Cancelar"
        Me.Btn_Login_Cancelar.Size = New System.Drawing.Size(64, 31)
        Me.Btn_Login_Cancelar.TabIndex = 4
        Me.Btn_Login_Cancelar.Text = "Cancelar"
        Me.Btn_Login_Cancelar.UseVisualStyleBackColor = False
        '
        'Form_UsuarioYContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile1
        Me.ClientSize = New System.Drawing.Size(453, 239)
        Me.Controls.Add(Me.Btn_Login_Cancelar)
        Me.Controls.Add(Me.Btn_Login_Ingresar)
        Me.Controls.Add(Me.TtBo_Login_Contraseña)
        Me.Controls.Add(Me.TtBo_Login_Usuario)
        Me.Controls.Add(Me.Lab_Login_Contraseña)
        Me.Controls.Add(Me.Lab_Login_Usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_UsuarioYContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_UsuarioYContraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lab_Login_Usuario As Label
    Friend WithEvents Lab_Login_Contraseña As Label
    Friend WithEvents TtBo_Login_Usuario As TextBox
    Friend WithEvents TtBo_Login_Contraseña As TextBox
    Friend WithEvents Btn_Login_Ingresar As Button
    Friend WithEvents Btn_Login_Cancelar As Button
End Class
