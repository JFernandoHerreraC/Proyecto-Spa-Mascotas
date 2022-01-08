Public Class Form_splash
    Private Sub Form_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 5000
        Timer1.Start()
        'Dim Usuario As String = Environment.UserName
        'Dim InfoUnidadInstalacion As Array = System.IO.DriveInfo.GetDrives()
        'Dim UnidadInstalacion = InfoUnidadInstalacion.GetValue(0)
        'UnidadInstalacion = UnidadInstalacion.ToString()
        'Dim path_Base As String = UnidadInstalacion + "Users\" + Usuario + "\Pictures"
        'path_Base = path_Base + "\Imagenes_SKF_Vet"
        'If Not System.IO.Directory.Exists(path_Base) Then
        '    '    My.Computer.FileSystem.CreateDirectory(path_Base + "\Imagenes_SKF_Vet")
        '    Console.WriteLine("Existe la ruta: " + path_Base)
        'End If
        'path_Base = path_Base + "\Imagenes_de_Producto"
        'If Not System.IO.Directory.Exists(path_Base) Then
        '    'My.Computer.FileSystem.CreateDirectory(path_Base)
        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Form_UsuarioYContraseña.Show()
        Me.Hide()
    End Sub
End Class
