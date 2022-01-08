Public Class Form_Categorias
    Dim Id As Integer = 0
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

    Private Sub ClientesYMascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYMascotasToolStripMenuItem.Click
        Form_ClientesYMascotas.Show()
        Me.Hide()
    End Sub

    Private Sub CaducosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CaducosToolStripMenuItem1.Click
        Form_Caducos.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_atras_Click(sender As Object, e As EventArgs) Handles Btn_atras.Click
        Form_Productos.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Categorias_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Categorias_Guardar.Click
        If TtBo_Alta_NombCategoria.TextLength > 2 And TtBo_Alta_DescCategoria.TextLength > 2 Then
            'aqui va la funcion de agregar la categiria
            Dim Nombre As String = TtBo_Alta_NombCategoria.Text
            Dim Desc As String = TtBo_Alta_DescCategoria.Text
            Dim NuevaCtg = New Consultas.Categorias()
            NuevaCtg.CrearCategorias(Nombre, Desc)
            TtBo_Alta_NombCategoria.Clear()
            TtBo_Alta_DescCategoria.Clear()
        Else
            MsgBox("Lo sentimos, los campos están vacíos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TtBo_Consulta_NombCategoria.TextChanged
        If TtBo_Consulta_NombCategoria.TextAlign > 2 Then
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "Buscar" Then
            'aqui va la opcion de buscar
            Dim Busqueda As String = TtBo_Cambios_NombCategoria.Text
            Dim Consulta = New Consultas.ConsultasGenerales()
            Dim Repuesta As DataTable = Consulta.ConsultaTodoPor("Categorias", "Nombre", "Ctg", Busqueda)
            Id = Repuesta.Rows(0).Item(0)
            TtBo_Cambios_NombCategoria.Clear()
            TtBo_Cambios_NombCategoria.Text = Repuesta.Rows(0).Item(1)
            TtBo_Cambios_DescCategoria.Text = Repuesta.Rows(0).Item(2)
            Button5.Text = "Guardar"
        Else
            Dim Consulta_G = New Consultas.Categorias()
            Dim Nombre As String = TtBo_Cambios_NombCategoria.Text
            Dim Desc As String = TtBo_Cambios_DescCategoria.Text
            Dim Repuesta As Boolean = Consulta_G.CambioCategorias(Id.ToString(), Nombre, Desc)
            If Repuesta Then
                MsgBox("Se guardarón los cambios con exito", MsgBoxStyle.Information, "Datos guardados")
                TtBo_Cambios_NombCategoria.Clear()
                TtBo_Cambios_DescCategoria.Clear()
            End If
        End If
        '    MsgBox("Lo sentimos, el campo de nombre esta vacío", MsgBoxStyle.Critical)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = "Buscar" Then
            'aqui va la opcion de buscar
            Dim Busqueda As String = TtBo_Baja_NombCategoria.Text
            Dim Consulta = New Consultas.ConsultasGenerales()
            Dim Repuesta As DataTable = Consulta.ConsultaTodoPor("Categorias", "Nombre", "Ctg", Busqueda)
            Id = Repuesta.Rows(0).Item(0)
            TtBo_Baja_NombCategoria.Text = Repuesta.Rows(0).Item(1)
            TtBo_Baja_DescCategoria.Text = Repuesta.Rows(0).Item(2)
            Button7.Text = "Eliminar"
        Else
            Dim Consulta_G = New Consultas.Categorias()
            Dim Repuesta As Boolean = Consulta_G.BajaCategorias(Id.ToString())
            If Repuesta Then
                MsgBox("Se guardarón los cambios con exito", MsgBoxStyle.Information, "Datos guardados")
                TtBo_Baja_NombCategoria.Clear()
                TtBo_Baja_DescCategoria.Clear()
            Else
                MsgBox("Lo sentimos ocurrio algo...", MsgBoxStyle.Critical, "¡Ocurrio un error!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Busqueda As String = TtBo_Consulta_NombCategoria.Text
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Repuesta = Consulta.ConsultaTodoPor("Categorias", "Nombre", "Ctg", Busqueda)
        DataGridView1.Columns().Clear()
        DataGridView1.DataSource = Repuesta
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Nombre de categoria"
        DataGridView1.Columns(2).HeaderText = "Descripción de la categoria"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Repuesta = Consulta.ConsultaTodo("Categorias")
        DataGridView1.Columns().Clear()
        DataGridView1.DataSource = Repuesta
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Nombre de categoria"
        DataGridView1.Columns(2).HeaderText = "Descripción de la categoria"
    End Sub
End Class