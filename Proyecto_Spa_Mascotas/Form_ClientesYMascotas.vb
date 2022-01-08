Public Class Form_ClientesYMascotas
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Form_Productos.Show()
        Me.Hide()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Form_Inventario.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Form_Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
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

    Private Sub Btn_atras_Click(sender As Object, e As EventArgs) Handles Btn_atras.Click
        'Form_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub Alta_Clientes_Click(sender As Object, e As EventArgs) Handles Alta_Clientes.Click

    End Sub




    Private Sub MenuS_Principal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuS_Principal.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lab_Alta_NombDueno.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Btn_Alta_AgregarMascotaDueno.Click
        Form_Mascotas.Show()
        Me.Hide()

    End Sub
End Class