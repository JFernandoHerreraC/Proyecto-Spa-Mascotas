Public Class Form_Mascotas
    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Btn_Alta_ImgMascotas.Click
        Dim File As New OpenFileDialog()
        Dim informacion = My.Computer.FileSystem
        File.InitialDirectory = "c:\\"
        File.Filter = "Archivo JPG| *.jpg"
        If File.ShowDialog() = DialogResult.OK Then
            PiBo_Alta_ImgMascotas.Image = Image.FromFile(File.FileName)
            Dim Path_Img = informacion.GetFileInfo(File.FileName).FullName
            Console.WriteLine("Path file: " + File.FileName)
        End If
    End Sub

    Private Sub Btn_atras_Click(sender As Object, e As EventArgs) Handles Btn_atras.Click
        Form_ClientesYMascotas.Show()
        Me.Hide()

    End Sub
End Class