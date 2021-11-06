Public Class Form_Productos
    Private Sub ServiciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem1.Click
        Form_Servicios.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Form_Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Form_Inventario.Show()
        Me.Hide()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Form_Proveedores.Show()
        Me.Hide()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Form_Empleados.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_atras_Click(sender As Object, e As EventArgs) Handles Btn_atras.Click
        Form_Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub ClientesYMascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYMascotasToolStripMenuItem.Click
        Form_ClientesYMascotas.Show()
        Me.Hide()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sr As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Form_Categorias.Show()
        Me.Hide()
    End Sub

    Private Sub CaducosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaducosToolStripMenuItem.Click
        Form_Caducos.Show()
        Me.Hide()
    End Sub

    Private Sub Form_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.TabIndex = 1
        TextBox1.TabStop = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim File As New OpenFileDialog()
        Dim informacion = My.Computer.FileSystem
        File.InitialDirectory = "c:\\"
        File.Filter = "Archivo JPG| *.jpg"
        If File.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(File.FileName)
            Dim Path_Img = informacion.GetFileInfo(File.FileName).FullName
            Console.WriteLine("Path file: " + File.FileName)
        End If
    End Sub
End Class