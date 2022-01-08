Public Class Form_Proveedores
    Dim Id As Integer = 0
    Dim Resultado As DataTable
    Private Sub LimpiarAlta()
        TtBo_Alta_NombProv.Clear()
        TtBo_Alta_RfcProv.Clear()
        TtBo_Alta_CalleProv.Clear()
        TtBo_Alta_NumExteriorProv.Clear()
        TtBo_Alta_NumInteriorProv.Clear()
        TtBo_Alta_CpProv.Clear()
        TtBo_Alta_ColoniaProv.Clear()
        TtBo_Alta_MpioProv.Clear()
        CoBo_Alta_EstadoProv.SelectedItem = 1
        TtBo_Alta_TelefUnoProv.Clear()
        TtBo_Alta_TelefDosProv.Clear()
        TtBo_Alta_EmailProv.Clear()
        TtBo_Alta_RubroProv.Clear()
        CoBo_Alta_FormaPagoProv.SelectedItem = 1
        TtBo_Alta_SecuenciaProv.Clear()
        CoBo_Alta_MonedaProv.SelectedItem = 1
        TtBo_Alta_CuentaDepositoProv.Clear()
        TtBo_Alta_DescripProv.Clear()
    End Sub
    Private Sub LimpiarBaja()
        TtBo_Baja_NombProv.Clear()
        TtBo_Baja_RfcProv.Clear()
        TtBo_PreBaja_NombProv.Clear()
        TtBo_PreBaja_RfcProv.Clear()
        TtBo_PreBaja_CalleProv.Clear()
        TtBo_PreBaja_NumbExterior.Clear()
        TtBo_PreBaja_CpProv.Clear()
        TtBo_PreBaja_ColoniaProv.Clear()
        TtBo_PreBaja_RubroProv.Clear()
    End Sub
    Private Sub LimpiarCambios()
        TtBo_Cambios_NombProv.Clear()
        TtBo_Cambios_RfcProv.Clear()
        TtBo_Cambios_CalleProv.Clear()
        TtBo_Cambios_NumExteriorProv.Clear()
        TtBo_Cambios_NumInteriorProv.Clear()
        TtBo_Cambios_CpProv.Clear()
        TtBo_Cambios_ColoniaProv.Clear()
        TtBo_Cambios_mpioProv.Clear()
        CoBo_Cambios_EstadoProv.SelectedIndex = 1
        TtBo_Cambios_TelefUnoProv.Clear()
        TtBo_Cambios_TelefDosProv.Clear()
        TtBo_Cambios_EmailProv.Clear()
        TtBo_Cambios_RubroProv.Clear()
        CoBo_Cambios_FormaPagoProv.SelectedIndex = 1
        TtBo_Cambios_SecuenciaProv.Clear()
        CoBo_Cambios_MonedaProv.SelectedIndex = 1
        TtBo_Cambios_CuentaDepositoProv.Clear()
        TtBo_Cambios_DescripProv.Clear()
    End Sub
    Private Function Busqueda(Nombre As String, Rfc As String)
        If Not Nombre = "" And Rfc = "" Then
            Dim Consulta = New Consultas.ConsultasGenerales()
            Resultado = Consulta.ConsultaTodoPor("Proveedores", "Nombre", "Prov", Nombre)
        ElseIf Not Rfc = "" And Nombre = "" Then
            Dim Consulta = New Consultas.ConsultasGenerales()
            Resultado = Consulta.ConsultaTodoPor("Proveedores", "Rfc", "Prov", Rfc)
        ElseIf Not Rfc = "" And Not Nombre = "" Then
            Dim Consulta = New Consultas.ConsultasGenerales()
            Resultado = Consulta.ConsultaTodoPor("Proveedores", "Nombre", "Prov", Nombre)
        Else
            MsgBox("No hay elementos para buscar", MsgBoxStyle.Critical, "Error en la busqueda")
        End If
        Return Resultado
    End Function
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Form_Productos.Show()
        Me.Hide()
    End Sub

    Private Sub ServiciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem1.Click
        Form_Servicios.Show()
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

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Form_Ventas.Show()
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

    Private Sub ClientesYMascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYMascotasToolStripMenuItem.Click
        Form_ClientesYMascotas.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Btn_Alta_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Alta_Guardar.Click
        Dim Datos(18) As String
        Datos(0) = TtBo_Alta_NombProv.Text
        Datos(1) = TtBo_Alta_RfcProv.Text
        Datos(2) = TtBo_Alta_CalleProv.Text
        Datos(3) = TtBo_Alta_NumExteriorProv.Text
        Datos(4) = TtBo_Alta_NumInteriorProv.Text
        Datos(5) = TtBo_Alta_CpProv.Text
        Datos(6) = TtBo_Alta_ColoniaProv.Text
        Datos(7) = TtBo_Alta_MpioProv.Text
        Datos(8) = CoBo_Alta_EstadoProv.Text
        Datos(9) = TtBo_Alta_TelefUnoProv.Text
        Datos(10) = TtBo_Alta_TelefDosProv.Text
        Datos(11) = TtBo_Alta_EmailProv.Text
        Datos(12) = TtBo_Alta_RubroProv.Text
        Datos(13) = CoBo_Alta_FormaPagoProv.Text
        Datos(14) = TtBo_Alta_SecuenciaProv.Text
        Datos(15) = CoBo_Alta_MonedaProv.Text
        Datos(16) = TtBo_Alta_CuentaDepositoProv.Text
        Datos(17) = TtBo_Alta_DescripProv.Text
        Dim Consulta = New Consultas.Proveedores()
        Dim Resultado = Consulta.AltaProveedor(Datos)
        LimpiarAlta()
        If Resultado Then
            MsgBox("Se guardo con exito el proveedor", MsgBoxStyle.Information, "Exito en el guardado")
        Else
            MsgBox("Se origino un problema al guardar el proveedor", MsgBoxStyle.Information, "Error al guardar el proveedor")
        End If
    End Sub

    Private Sub Btn_Consulta_BuscarTodo_Click(sender As Object, e As EventArgs) Handles Btn_Consulta_BuscarTodo.Click
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Resultado As DataTable = Consulta.ConsultaTodo("Proveedores")
        DGV_ListaProv.Columns.Clear()
        DGV_ListaProv.DataSource = Resultado
        DGV_ListaProv.Columns(0).HeaderText = "ID"
        DGV_ListaProv.Columns(1).HeaderText = "Nombre"
        DGV_ListaProv.Columns(2).HeaderText = "RFC"
        DGV_ListaProv.Columns(3).HeaderText = "Calle"
        DGV_ListaProv.Columns(4).HeaderText = "Número exterior"
        DGV_ListaProv.Columns(5).HeaderText = "Número interior"
        DGV_ListaProv.Columns(6).HeaderText = "CP"
        DGV_ListaProv.Columns(7).HeaderText = "Colonia"
        DGV_ListaProv.Columns(8).HeaderText = "Municipio"
        DGV_ListaProv.Columns(9).HeaderText = "Estado"
        DGV_ListaProv.Columns(10).HeaderText = "Telefono Uno"
        DGV_ListaProv.Columns(11).HeaderText = "Telefono dos"
        DGV_ListaProv.Columns(12).HeaderText = "Email"
        DGV_ListaProv.Columns(13).HeaderText = "Rubro/Giro"
        DGV_ListaProv.Columns(14).HeaderText = "Forma de pagó"
        DGV_ListaProv.Columns(15).HeaderText = "Secuencia de pago"
        DGV_ListaProv.Columns(16).HeaderText = "Moneda"
        DGV_ListaProv.Columns(17).HeaderText = "Cuenta de deposíto"
        DGV_ListaProv.Columns(18).HeaderText = "Descripción del proveedor"
        TtBo_Consulta_NombProv.Clear()
        TtBo_Consulta_RfcProv.Clear()
    End Sub

    Private Sub Btn_Alta_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Alta_Limpiar.Click
        LimpiarAlta()
    End Sub

    Private Sub Btn_Consulta_BuscarProv_Click(sender As Object, e As EventArgs) Handles Btn_Consulta_BuscarProv.Click
        Dim Nombre As String = TtBo_Consulta_NombProv.Text
        Dim Rfc As String = TtBo_Consulta_RfcProv.Text
        Dim Resultado As DataTable = Busqueda(Nombre, Rfc)
        DGV_ListaProv.Columns.Clear()
        DGV_ListaProv.DataSource = Resultado
        DGV_ListaProv.Columns(0).HeaderText = "ID"
        DGV_ListaProv.Columns(1).HeaderText = "Nombre"
        DGV_ListaProv.Columns(2).HeaderText = "RFC"
        DGV_ListaProv.Columns(3).HeaderText = "Calle"
        DGV_ListaProv.Columns(4).HeaderText = "Número exterior"
        DGV_ListaProv.Columns(5).HeaderText = "Número interior"
        DGV_ListaProv.Columns(6).HeaderText = "CP"
        DGV_ListaProv.Columns(7).HeaderText = "Colonia"
        DGV_ListaProv.Columns(8).HeaderText = "Municipio"
        DGV_ListaProv.Columns(9).HeaderText = "Estado"
        DGV_ListaProv.Columns(10).HeaderText = "Telefono Uno"
        DGV_ListaProv.Columns(11).HeaderText = "Telefono dos"
        DGV_ListaProv.Columns(12).HeaderText = "Email"
        DGV_ListaProv.Columns(13).HeaderText = "Rubro/Giro"
        DGV_ListaProv.Columns(14).HeaderText = "Forma de pagó"
        DGV_ListaProv.Columns(15).HeaderText = "Secuencia de pago"
        DGV_ListaProv.Columns(16).HeaderText = "Moneda"
        DGV_ListaProv.Columns(17).HeaderText = "Cuenta de deposíto"
        DGV_ListaProv.Columns(18).HeaderText = "Descripción del proveedor"
        TtBo_Consulta_NombProv.Clear()
        TtBo_Consulta_RfcProv.Clear()
    End Sub

    Private Sub Btn_Cambios_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Cambios_Buscar.Click
        Dim Nombre As String = TtBo_Cambios_NombProv.Text
        Dim Rfc As String = TtBo_Cambios_RfcProv.Text
        Dim Datos(19) As String
        If Btn_Cambios_Buscar.Text = "Buscar" Then
            Dim Resultado As DataTable = Busqueda(Nombre, Rfc)
            Id = Resultado.Rows(0).Item(0)
            TtBo_Cambios_NombProv.Text = Resultado.Rows(0).Item(1)
            TtBo_Cambios_RfcProv.Text = Resultado.Rows(0).Item(2)
            TtBo_Cambios_CalleProv.Text = Resultado.Rows(0).Item(3)
            TtBo_Cambios_NumExteriorProv.Text = Resultado.Rows(0).Item(4)
            TtBo_Cambios_NumInteriorProv.Text = Resultado.Rows(0).Item(5)
            TtBo_Cambios_CpProv.Text = Resultado.Rows(0).Item(6)
            TtBo_Cambios_ColoniaProv.Text = Resultado.Rows(0).Item(7)
            TtBo_Cambios_MpioProv.Text = Resultado.Rows(0).Item(8)
            CoBo_Cambios_EstadoProv.Text = Resultado.Rows(0).Item(9)
            TtBo_Cambios_TelefUnoProv.Text = Resultado.Rows(0).Item(10)
            TtBo_Cambios_TelefDosProv.Text = Resultado.Rows(0).Item(11)
            TtBo_Cambios_EmailProv.Text = Resultado.Rows(0).Item(12)
            TtBo_Cambios_RubroProv.Text = Resultado.Rows(0).Item(13)
            CoBo_Cambios_FormaPagoProv.Text = Resultado.Rows(0).Item(14)
            TtBo_Cambios_SecuenciaProv.Text = Resultado.Rows(0).Item(15)
            CoBo_Cambios_MonedaProv.Text = Resultado.Rows(0).Item(16)
            TtBo_Cambios_CuentaDepositoProv.Text = Resultado.Rows(0).Item(17)
            TtBo_Cambios_DescripProv.Text = Resultado.Rows(0).Item(18)
            Btn_Cambios_Buscar.Text = "Guardar"
        Else
            Datos(0) = Id
            Datos(1) = TtBo_Cambios_NombProv.Text
            Datos(2) = TtBo_Cambios_RfcProv.Text
            Datos(3) = TtBo_Cambios_CalleProv.Text
            Datos(4) = TtBo_Cambios_NumExteriorProv.Text
            Datos(5) = TtBo_Cambios_NumInteriorProv.Text
            Datos(6) = TtBo_Cambios_CpProv.Text
            Datos(7) = TtBo_Cambios_ColoniaProv.Text
            Datos(8) = TtBo_Cambios_mpioProv.Text
            Datos(9) = CoBo_Cambios_EstadoProv.Text
            Datos(10) = TtBo_Cambios_TelefUnoProv.Text
            Datos(11) = TtBo_Cambios_TelefDosProv.Text
            Datos(12) = TtBo_Cambios_EmailProv.Text
            Datos(13) = TtBo_Cambios_RubroProv.Text
            Datos(14) = CoBo_Cambios_FormaPagoProv.Text
            Datos(15) = TtBo_Cambios_SecuenciaProv.Text
            Datos(16) = CoBo_Cambios_MonedaProv.Text
            Datos(17) = TtBo_Cambios_CuentaDepositoProv.Text
            Datos(18) = TtBo_Cambios_DescripProv.Text
            Dim Consulta = New Consultas.Proveedores()
            Dim Resultado = Consulta.CambiosProveedor(Datos)
            If Resultado Then
                MsgBox("Se guardo con exito los cambios en proveedor", MsgBoxStyle.Information, "Exito en el guardado")
                LimpiarCambios()
            Else
                MsgBox("Se origino un problema al cambiar los datos del proveedor", MsgBoxStyle.Information, "Error al guardar los datos proveedor")
            End If
        End If
    End Sub

    Private Sub Btn_Baja_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Baja_Buscar.Click
        Dim Nombre As String = TtBo_Baja_NombProv.Text
        Dim Rfc As String = TtBo_Baja_RfcProv.Text
        Dim Resultado As DataTable = Busqueda(Nombre, Rfc)
        Id = Resultado.Rows(0).Item(0)
        TtBo_PreBaja_NombProv.Text = Resultado.Rows(0).Item(1)
        TtBo_PreBaja_RfcProv.Text = Resultado.Rows(0).Item(2)
        TtBo_PreBaja_CalleProv.Text = Resultado.Rows(0).Item(3)
        TtBo_PreBaja_NumbExterior.Text = Resultado.Rows(0).Item(4)
        TtBo_PreBaja_CpProv.Text = Resultado.Rows(0).Item(6)
        TtBo_PreBaja_ColoniaProv.Text = Resultado.Rows(0).Item(7)
        TtBo_PreBaja_RubroProv.Text = Resultado.Rows(0).Item(13)
    End Sub

    Private Sub Btn_Baja_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Baja_Eliminar.Click
        Dim Consulta = New Consultas.Proveedores()
        Dim Respuesta As Boolean = Consulta.BajaProveedor(Id)
        If Respuesta Then
            MsgBox("Se elimino con exito el proveedor", MsgBoxStyle.Information, "Exito al eliminar el proveedor")
            LimpiarBaja()
        Else
            MsgBox("Se origino un problema al eliminar el proveedor", MsgBoxStyle.Information, "Error al eliminar el proveedor")
        End If
    End Sub

    Private Sub Btn_Baja_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Baja_Limpiar.Click
        LimpiarBaja()
    End Sub

    Private Sub Btn_Cambios_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Cambios_Limpiar.Click
        LimpiarCambios()
    End Sub
End Class