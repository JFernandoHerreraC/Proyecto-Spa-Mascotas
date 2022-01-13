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
            Btn_Consulta_Buscar.Enabled = True
        End If
    End Sub

    Private Sub Btn_Cambios_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Cambios_Guardar.Click
        If Btn_Cambios_Guardar.Text = "Buscar" Then
            'aqui va la opcion de buscar
            Dim Busqueda As String = TtBo_Cambios_NombCategoria.Text
            If Not Busqueda = "" Then
                Dim Consulta = New Consultas.ConsultasGenerales()
                Dim Respuesta As DataTable = Consulta.ConsultaTodoPor("Categorias", "Nombre", "Ctg", Busqueda)
                If Respuesta.Rows.Count > 0 Then
                    Id = Respuesta.Rows(0).Item(0)
                    TtBo_Cambios_NombCategoria.Clear()
                    TtBo_Cambios_NombCategoria.Text = Respuesta.Rows(0).Item(1)
                    TtBo_Cambios_DescCategoria.Text = Respuesta.Rows(0).Item(2)
                    Btn_Cambios_Guardar.Text = "Guardar"
                Else
                    MsgBox("No se encontrarón elementos en la busqueda", MsgBoxStyle.Critical, "Error en la busqueda")
                End If
            Else
                MsgBox("No hay elementos para buscar", MsgBoxStyle.Critical, "Error en la busqueda")
            End If
        Else
            Dim Consulta_G = New Consultas.Categorias()
            Dim Nombre As String = TtBo_Cambios_NombCategoria.Text
            Dim Desc As String = TtBo_Cambios_DescCategoria.Text
            Dim Repuesta As Boolean = Consulta_G.CambioCategorias(Id.ToString(), Nombre, Desc)
            If Repuesta Then
                MsgBox("Se guardarón los cambios con exito", MsgBoxStyle.Information, "Datos guardados")
                Btn_Cambios_Guardar.Text = "Buscar"
                TtBo_Cambios_NombCategoria.Clear()
                TtBo_Cambios_DescCategoria.Clear()
            End If
        End If
        '    MsgBox("Lo sentimos, el campo de nombre esta vacío", MsgBoxStyle.Critical)
    End Sub

    Private Sub Btn_Baja_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Baja_Buscar.Click
        If Btn_Baja_Buscar.Text = "Buscar" Then
            'aqui va la opcion de buscar
            Dim Busqueda As String = TtBo_Baja_NombCategoria.Text
            If Not Busqueda = "" Then
                Dim Consulta = New Consultas.ConsultasGenerales()
                Dim Respuesta As DataTable = Consulta.ConsultaTodoPor("Categorias", "Nombre", "Ctg", Busqueda)
                If Respuesta.Rows.Count > 0 Then
                    Id = Respuesta.Rows(0).Item(0)
                    TtBo_Baja_NombCategoria.Text = Respuesta.Rows(0).Item(1)
                    TtBo_Baja_DescCategoria.Text = Respuesta.Rows(0).Item(2)
                    Btn_Baja_Buscar.Text = "Eliminar"
                Else
                    MsgBox("No se encontrarón elementos en la busqueda", MsgBoxStyle.Critical, "Error en la busqueda")
                End If
            Else
                MsgBox("No hay elementos para buscar", MsgBoxStyle.Critical, "Error en la busqueda")
            End If
        Else
            Dim Consulta_G = New Consultas.Categorias()
            Dim Repuesta As Boolean = Consulta_G.BajaCategorias(Id.ToString())
            If Repuesta Then
                MsgBox("Se guardarón los cambios con exito", MsgBoxStyle.Information, "Datos guardados")
                TtBo_Baja_NombCategoria.Clear()
                TtBo_Baja_DescCategoria.Clear()
                Btn_Baja_Buscar.Text = "Buscar"
            Else
                MsgBox("Lo sentimos se origino un error", MsgBoxStyle.Critical, "¡Ocurrio un error!")
            End If
        End If
    End Sub

    Private Sub Btn_Consulta_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Consulta_Buscar.Click
        Dim Busqueda As String = TtBo_Consulta_NombCategoria.Text
        If Not Busqueda = "" Then
            Dim Consulta = New Consultas.ConsultasGenerales()
            Dim Repuesta = Consulta.ConsultaTodoPor("Categorias", "Nombre", "Ctg", Busqueda)
            DGVListaCtg.Columns().Clear()
            DGVListaCtg.DataSource = Repuesta
            DGVListaCtg.Columns(0).HeaderText = "ID"
            DGVListaCtg.Columns(1).HeaderText = "Nombre de categoria"
            DGVListaCtg.Columns(2).HeaderText = "Descripción de la categoria"
        Else
            MsgBox("Lo sentimos, esta vacío el campo nombre de categoría", MsgBoxStyle.Critical, "Error en el guardado")
        End If

    End Sub

    Private Sub Btn_Consulta_BuscarTodo_Click(sender As Object, e As EventArgs) Handles Btn_Consulta_BuscarTodo.Click
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Repuesta = Consulta.ConsultaTodo("Categorias")
        DGVListaCtg.Columns().Clear()
        DGVListaCtg.DataSource = Repuesta
        DGVListaCtg.Columns(0).HeaderText = "ID"
        DGVListaCtg.Columns(1).HeaderText = "Nombre de categoria"
        DGVListaCtg.Columns(2).HeaderText = "Descripción de la categoria"
    End Sub

    Private Sub Btn_Alta_Limpiar_Categorias_Click(sender As Object, e As EventArgs) Handles Btn_Alta_Limpiar_Categorias.Click
        TtBo_Alta_NombCategoria.Clear()
        TtBo_Alta_DescCategoria.Clear()
    End Sub

    Private Sub Btn_Cambios_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Cambios_Limpiar.Click
        TtBo_Cambios_NombCategoria.Clear()
        TtBo_Cambios_DescCategoria.Clear()
        Btn_Cambios_Guardar.Text = "Buscar"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn_Baja_Limpiar_Ctg.Click
        TtBo_Baja_NombCategoria.Clear()
        TtBo_Baja_DescCategoria.Clear()
        Btn_Baja_Buscar.Text = "Buscar"
    End Sub
End Class