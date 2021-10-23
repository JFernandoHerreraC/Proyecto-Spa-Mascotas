Public Class Form_splash
    Private Sub Form_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Form_Ventas.Show()
        Me.Hide()
    End Sub
End Class
