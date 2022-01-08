Public Class Form_Ventas
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Form_Productos.Show()
        Me.Hide()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        Form_Servicios.Show()
        Me.Hide()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Form_Inventario.Show()
        Me.Hide()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Form_Proveedores.Show()
        Me.Hide()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Form_Compras.Show()
        Me.Hide()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Form_Empleados.Show()
        Me.Hide()
    End Sub

    Private Sub ClientesYMascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYMascotasToolStripMenuItem.Click
        Form_ClientesYMascotas.Show()
        Me.Hide()
    End Sub

    Private Sub CaducosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CorteDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorteDeCajaToolStripMenuItem.Click
        Form_CorteCaja.Show()
        Me.Hide()
    End Sub

    Private Sub Form_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CoBo_Bus_TipoCompra.SelectedIndex = 0
        CoBo_Bus_Unidad.SelectedIndex = 0
        CoBo_Bus_TipoCompra.Select()
    End Sub

    Private Sub Btn_atras_Click(sender As Object, e As EventArgs) Handles Btn_atras.Click
        ' Form_Menu.Show()
        Me.Hide()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBo_Bus_TipoCompra.SelectedIndexChanged
        If CoBo_Bus_TipoCompra.SelectedIndex = 1 Then
            Lab_Bus_NombProd.Text = "Nombre del servicio"
            Lab_Bus_CodBarra.Visible = False
            TtBo_Bus_CodBarra.Visible = False
            Lab_Ag_NombProd.Text = "Nombre del servicio:"
            Lab_Ag_Marca.Visible = False
            CoBo_Ag_Marca.Visible = False
            Lab_Bus_Unidad.Visible = False
            CoBo_Bus_Unidad.Visible = False
            Lab_Ag_Precio.Location = New Point(13, 48)
            TtBo_Ag_Precio.Location = New Point(199, 48)
            Lab_Ag_Cantidad.Location = New Point(12, 75)
            NumUDo_CantProd.Location = New Point(199, 75)
            NumUDo_CantProd.Increment = 1
        Else
            Lab_Bus_NombProd.Text = "Nombre del producto"
            Lab_Bus_CodBarra.Visible = True
            TtBo_Bus_CodBarra.Visible = True
            Lab_Ag_NombProd.Text = "Nombre del producto:"
            Lab_Ag_Marca.Visible = True
            CoBo_Ag_Marca.Visible = True
            Lab_Bus_Unidad.Visible = True
            CoBo_Bus_Unidad.Visible = True
            Lab_Ag_Precio.Location = New Point(12, 75)
            TtBo_Ag_Precio.Location = New Point(199, 75)
            Lab_Ag_Cantidad.Location = New Point(12, 102)
            NumUDo_CantProd.Location = New Point(199, 104)
            NumUDo_CantProd.Increment = 0.05
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CoBo_Bus_Unidad.SelectedIndexChanged
        If CoBo_Bus_Unidad.SelectedIndex = 1 Then
            Lab_Bus_CodBarra.Visible = False
            TtBo_Bus_CodBarra.Visible = False
            Btn_Bus_Buscar.Location = New Point(194, 118)
        Else
            Lab_Bus_CodBarra.Visible = True
            TtBo_Bus_CodBarra.Visible = True
            Btn_Bus_Buscar.Location = New Point(194, 150)
        End If
    End Sub
End Class