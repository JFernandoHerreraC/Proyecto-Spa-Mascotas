Public Class Form_UsuarioYContraseña
    Dim Usuario_Fijo As String = "Dueño"
    Dim Contraseña_Fija As String = "123"

    Private Sub LimpiarCajas()
        TtBo_Login_Usuario.Clear()
        TtBo_Login_Contraseña.Clear()
    End Sub
    Private Function Login(ByVal Usuario As String, ByVal Contraseña As String) As Boolean
        Dim Respuesta As Boolean = False
        If Not Usuario = "" And Not Contraseña = "" Then
            If Usuario <> Usuario_Fijo And Contraseña <> Contraseña_Fija Then
                MsgBox("Lo sentimos, su usuario y contraseña son incorrectas", MsgBoxStyle.Critical, "Error en los datos")
                LimpiarCajas()
                TtBo_Login_Usuario.Select()
                Exit Function
            End If
            If Not Usuario = Usuario_Fijo Then
                MsgBox("Los sentimos, su usuario es inconrrecto", MsgBoxStyle.Critical, "Error en los datos")
                TtBo_Login_Usuario.Clear()
                TtBo_Login_Usuario.Select()
            End If
            If Not Contraseña = Contraseña_Fija Then
                MsgBox("Los sentimos, su contraseña es inconrrecto", MsgBoxStyle.Critical, "Error en los datos")
                TtBo_Login_Contraseña.Clear()
                TtBo_Login_Contraseña.Select()
            End If
            If Usuario = Usuario_Fijo And Contraseña = Contraseña_Fija Then
                Respuesta = True
            End If
        Else
            MsgBox("Coloque su usuario y contraseña", MsgBoxStyle.Critical, "Error en los datos")
            TtBo_Login_Usuario.Select()
        End If
        Return Respuesta
    End Function
    Private Sub Iniciar()
        Dim Usuario As String = TtBo_Login_Usuario.Text
        Dim Contraseña As String = TtBo_Login_Contraseña.Text
        Dim Respuesta As Boolean = Login(Usuario, Contraseña)
        If Respuesta Then
            Form_Ventas.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Btn_Login_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Login_Ingresar.Click
        Iniciar()
    End Sub
    Private Sub TtBo_Login_Contraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TtBo_Login_Contraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Iniciar()
        End If
    End Sub

    Private Sub Btn_Login_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Login_Cancelar.Click
        LimpiarCajas()
        Form_splash.Show()
        Me.Hide()
    End Sub

    Private Sub TtBo_Login_Usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TtBo_Login_Usuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TtBo_Login_Contraseña.Select()
        End If
    End Sub
End Class