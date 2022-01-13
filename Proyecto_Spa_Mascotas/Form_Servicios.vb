Public Class Form_Servicios
    Dim Id As Integer
    Private Sub TraerServiciosCambios()
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Respuesta As DataTable = Consulta.ConsultaTodo("Servicios")
        For i = 1 To Respuesta.Rows().Count - 1
            CoBo_Cambios_NombServ.Items.Add(Respuesta.Rows(i).Item(1))
        Next
    End Sub
    Private Sub TraerServicio()
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Respuesta As DataTable = Consulta.ConsultaTodo("Servicios")
        For i = 1 To Respuesta.Rows().Count - 1
            CoBo_Alta_DtsSrv_NombreServicio.Items.Add(Respuesta.Rows(1).Item(i))
        Next
    End Sub
    Private Sub LimpiarSrvAlta()
        TtBo_Alta_NombreServicio.Clear()
        TtBo_Alta_DescServicio.Clear()
    End Sub
    Private Sub LimpiarAuxServAlta()
        CoBo_Alta_DtsSrv_NombreServicio.Text = ""
        TtBo_Alta_DtsSrv_DescripServicio.Clear()
        TtBo_Alta_DtsSrv_PrecioServicio.Clear()
    End Sub
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Form_Productos.Show()
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

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Form_Compras.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Form_Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_atras_Click(sender As Object, e As EventArgs) Handles Btn_atras.Click
        '   Form_Menu.Show()
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
    Private Sub Form_Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerServicio()
        TraerServiciosCambios()
    End Sub
    Private Sub Btn_Alta_Servicio_Click(sender As Object, e As EventArgs) Handles Btn_Alta_Servicio.Click
        Dim Nombre As String = TtBo_Alta_NombreServicio.Text
        Dim Desc As String = TtBo_Alta_DescServicio.Text
        Dim Consulta = New Consultas.Servicios()
        Dim Respuesta As Boolean = Consulta.AltaServicios(Nombre, Desc)
        If Respuesta Then
            MsgBox("Se guardo con exito el servicio", MsgBoxStyle.Information, "Exito en el guardado")
            LimpiarSrvAlta()
            TraerServicio()
        Else
            MsgBox("Se origino un error al guardar el servicio", MsgBoxStyle.Information, "Exito en el guardado")
        End If
    End Sub

    Private Sub Btn_Alta_Limpiar_Servicio_Click(sender As Object, e As EventArgs) Handles Btn_Alta_Limpiar_Servicio.Click
        LimpiarSrvAlta()
    End Sub

    Private Sub Btn_Alta_DtsSrv_GuardarProd_Click(sender As Object, e As EventArgs) Handles Btn_Alta_DtsSrv_GuardarProd.Click
        Dim NombreSrv As String = CoBo_Alta_DtsSrv_NombreServicio.Text
        Dim Desc As String = TtBo_Alta_DtsSrv_DescripServicio.Text
        Dim Precio As Integer = Convert.ToDecimal(TtBo_Alta_DtsSrv_PrecioServicio.Text)
        Dim Consulta = New Consultas.Aux_Servicios()
        Dim Respuesta As Boolean = Consulta.Alta_AuxSrv(NombreSrv, Desc, Precio)
        If Respuesta Then
            MsgBox("Se guardo con exito los detalles del servicio", MsgBoxStyle.Information, "Exito en el guardado")
            LimpiarAuxServAlta()
        Else
            MsgBox("Se origino un error al guardar los detalles del servicio", MsgBoxStyle.Information, "Exito en el guardado")
        End If
    End Sub

    Private Sub Btn_Alta_DtsSrv_LimpiarProd_Click(sender As Object, e As EventArgs) Handles Btn_Alta_DtsSrv_LimpiarProd.Click
        LimpiarAuxServAlta()
    End Sub

    Private Sub Btn_Consulta_BuscarTodo_Click(sender As Object, e As EventArgs) Handles Btn_Consulta_BuscarTodo.Click
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Resultado As DataTable = Consulta.ConsultaTodo("Aux_Servicios")
        Dim Id_Srv As Integer
        DGV_ListaServicio.Columns().Clear()
        For i = 1 To Resultado.Rows().Count - 1
            Id_Srv = Resultado.Rows(i).Item(1)
            Dim ResultadoBusq As DataTable = Consulta.ConsultaTodoPor("Servicios", "Id", "Serv", Id_Srv)
            Resultado.Rows(1).Item(1) = ResultadoBusq.Rows(0).Item(1)
        Next
        DGV_ListaServicio.DataSource = Resultado
        'Dim Consulta = New Consultas.ConsultasGenerales()
        'Dim Resultado As DataTable = Consulta.ConsultaTodo("Aux_Servicios")
    End Sub

End Class