Public Class Form_Productos
    Dim Id As String
    Private Sub LimpiarCajasBajas()
        TtBo_Baja_Dg_CodBarraProd.Clear()
        TtBo_Baja_Dg_NombreProd.Clear()
        TtBo_Baja_Dg_DescProd.Clear()
        CoBo_Baja_Dg_ContenidoProd.Text = ""
        TtBo_Baja_Dg_ContenidoProd.Clear()
        NuUpDo_Baja_CantidadExistProd.Value = 1
        TtBo_Baja_ProvProd.Clear()
        TtBo_Baja_PrecioProvProd.Clear()
        TtBo_Baja_PrecioPublicProd.Clear()
    End Sub
    Private Sub LimpiarCajasAlta()
        Dim Binarios As New System.IO.MemoryStream
        My.Resources.No_Image.Save(Binarios, Imaging.ImageFormat.Bmp)
        Dim Resultado_Bin As Byte() = Binarios.GetBuffer()
        TtBo_Alta_CodBarraProd.Clear()
        TtBo_Alta_NombProd.Clear()
        TtBo_Alta_DescripProd.Clear()
        TtBo_Alta_ContenidoProd.Clear()
        CoBo_Alta_ContenidoProd.Text = ""
        CoBo_Alta_CategoriaProd.Text = ""
        CoBo_Alta_ProvProd.Text = ""
        NuUpDo_Alta_CantidadExistProd.Value = 1
        RaBo_Alta_NoCaducaProd.Checked = False
        RaBo_Alta_SiCaducaProd.Checked = False
        DaTiPi_Alta_FechaCaducaProd.Value = "01/01/1920"
        TtBo_Alta_PrecioProvProd.Clear()
        TtBo_Alta_PrecioPublicoProd.Clear()
        PiBo_Alta_ImgProd.BackColor = Color.Black
        'PiBo_Alta_ImgProd.BackgroundImage
    End Sub

    Private Sub LimpiarCajasCambios()
        TtBo_Cambios_CodBarraProd.Clear()
        TtBo_Cambios_NombreProd.Clear()
        TtBo_Cambios_DescProd.Clear()
        TtBo_Cambios_ContenidoProd.Clear()
        CoBo_Cambios_ContenidoProd.Text = ""
        CoBo_Cambios_CategoriasProd.Text = ""
        CoBo_Cambios_ProvProd.Text = ""
        NuUpDo_Cambios_CantidadExistProd.Value = 1
        RaBo_Cambios_SiCaducaProd.Checked = False
        RaBo_Cambios_NoCaducaProd.Checked = False
        DaTiPi_Cambios_FechaCaducaProd.Value = "01/01/1920"
        TtBo_Cambios_PrecProvProd.Clear()
        TtBo_Cambios_PrecPublicProd.Clear()
    End Sub
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
        'Form_Menu.Show()
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
        TtBo_Alta_NombProd.TabIndex = 1
        TtBo_Alta_NombProd.TabStop = True
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Respuesta_Ctg As DataTable = Consulta.ConsultaTodo("Categorias")
        Dim Respuesta_Prov As DataTable = Consulta.ConsultaTodo("Proveedores")
        For i = 1 To Respuesta_Ctg.Rows.Count() - 1
            CoBo_Alta_CategoriaProd.Items.Add(Respuesta_Ctg.Rows(i).Item(1))
        Next
        For i = 1 To Respuesta_Prov.Rows.Count() - 1
            CoBo_Alta_ProvProd.Items.Add(Respuesta_Prov.Rows(i).ItemArray(1))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Alta_SubirImg.Click
        Dim File As New OpenFileDialog()
        Dim informacion = My.Computer.FileSystem
        File.InitialDirectory = "c:\\"
        File.Filter = "Archivo PNG| *.png"
        If File.ShowDialog() = DialogResult.OK Then
            PiBo_Alta_ImgProd.Image = Image.FromFile(File.FileName)
            Dim Path_Img = informacion.GetFileInfo(File.FileName).FullName
            Console.WriteLine("Path file: " + File.FileName)
        End If
    End Sub

    Private Sub Btn_Alta_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Alta_Guardar.Click
        Dim ValorRadioBotom As String = ""
        Dim Imagen As Image
        If RaBo_Alta_SiCaducaProd.Checked Then
            ValorRadioBotom = "Sí, Caduca"
        End If
        If RaBo_Alta_NoCaducaProd.Checked Then
            ValorRadioBotom = "No, Caduca"
        End If

        Dim Dia As String = DaTiPi_Alta_FechaCaducaProd.Value.Day
        Dim Mes As String = DaTiPi_Alta_FechaCaducaProd.Value.Month
        Dim Allo As String = DaTiPi_Alta_FechaCaducaProd.Value.Year
        Dim Datos(11) As String
        Datos(0) = TtBo_Alta_CodBarraProd.Text
        Datos(1) = TtBo_Alta_NombProd.Text
        Datos(2) = TtBo_Alta_DescripProd.Text
        Datos(3) = TtBo_Alta_ContenidoProd.Text + CoBo_Alta_ContenidoProd.Text
        Datos(4) = CoBo_Alta_CategoriaProd.Text
        Datos(5) = CoBo_Alta_ProvProd.Text
        Datos(6) = NuUpDo_Alta_CantidadExistProd.Value.ToString()
        Datos(7) = ValorRadioBotom
        Datos(8) = Dia + "/" + Mes + "/" + Allo
        Datos(9) = TtBo_Alta_PrecioProvProd.Text
        Datos(10) = TtBo_Alta_PrecioPublicoProd.Text
        Imagen = PiBo_Alta_ImgProd.Image
        Dim Consulta = New Consultas.Producto()
        Dim Respuesta As Boolean = Consulta.AltaProducto(Datos, Imagen)
        If Respuesta Then
            MsgBox("Se guardo el producto con exito", MsgBoxStyle.Information, "Exito en el guardado")
            LimpiarCajasAlta()
        Else
            MsgBox("Se Origino un error al tratar de guardar el producto", MsgBoxStyle.Critical, "Error en el guardado")
        End If
    End Sub

    Private Sub Alta_Productos_Click(sender As Object, e As EventArgs) Handles Alta_Productos.Click
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Respuesta_Ctg As DataTable = Consulta.ConsultaTodo("Categorias")
        Dim Respuesta_Prov As DataTable = Consulta.ConsultaTodo("Proveedores")
        For i = 1 To Respuesta_Ctg.Rows.Count() - 1
            CoBo_Alta_CategoriaProd.Items.Add(Respuesta_Ctg.Rows(i).Item(1))
        Next
        For i = 1 To Respuesta_Prov.Rows.Count() - 1
            CoBo_Alta_ProvProd.Items.Add(Respuesta_Prov.Rows(i).ItemArray(1))
        Next
    End Sub

    Private Sub Btn_BuscarTodoProd_Click(sender As Object, e As EventArgs) Handles Btn_BuscarTodoProd.Click
        Dim CodBarra As String = TtBo_Consulta_CodBarraProd.Text
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Resultado As DataTable = Consulta.ConsultaTodo("Productos")
        Dim NumeroColumnas As Integer = Resultado.Columns().Count() - 1
        Dim ColumnaQuitar = Resultado.Columns(NumeroColumnas)
        Resultado.Columns().Remove(ColumnaQuitar)
        DGVListProd.Columns.Clear()
        DGVListProd.DataSource = Resultado
        TtBo_Consulta_CodBarraProd.Clear()
    End Sub

    Private Sub Btn_BuscarCodBarraProd_Click(sender As Object, e As EventArgs) Handles Btn_BuscarCodBarraProd.Click
        Dim CodBarra As String = TtBo_Consulta_CodBarraProd.Text
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Resultado As DataTable = Consulta.ConsultaTodoPor("Productos", "CodBarra", "Prod", CodBarra)
        If Resultado.Rows.Count > 0 Then
            Dim NumeroColmunas As Integer = Resultado.Columns().Count() - 1
            Dim ColumnaQuitar = Resultado.Columns(NumeroColmunas)
            Resultado.Columns().Remove(ColumnaQuitar)
            DGVListProd.Columns.Clear()
            DGVListProd.DataSource = Resultado
            DGVListProd.Columns(0).HeaderText = "Codigo de barra"
            DGVListProd.Columns(1).HeaderText = "Nombre del producto"
            DGVListProd.Columns(2).HeaderText = "Contenido"
            DGVListProd.Columns(3).HeaderText = "Categoria"
            DGVListProd.Columns(4).HeaderText = "Proveedor"
            DGVListProd.Columns(5).HeaderText = "Cantidad en existencía"
            DGVListProd.Columns(6).HeaderText = "Caducidad"
            DGVListProd.Columns(7).HeaderText = "Fecha de caducidad"
            DGVListProd.Columns(8).HeaderText = "Precio de proveedor"
            DGVListProd.Columns(9).HeaderText = "Precio al publico"

            TtBo_Consulta_CodBarraProd.Clear()
        Else
            MsgBox("No se encontrarón elemento en la busqueda", MsgBoxStyle.Critical, "Error en la busqueda")
        End If
    End Sub

    Private Sub Btn_Buscar_BajasProd_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_BajasProd.Click
        Dim CodBarra As String = TtBo_Baja_CodBarraProd.Text
        Dim Consulta = New Consultas.ConsultasGenerales()
        Dim Resultado As DataTable = Consulta.ConsultaTodoPor("Productos", "CodBarra", "Prod", CodBarra)
        If Resultado.Rows.Count > 0 Then
            Dim Contenido As String = Resultado.Rows(0).Item(3)
            Dim TipoContenido As String = Contenido.Substring(Contenido.Length - 2, 2)
            Dim ContenidoEmbase As String = Contenido.Substring(0, Contenido.Length - 2)
            Id = Resultado.Rows(0).Item(0)
            TtBo_Baja_Dg_CodBarraProd.Text = Resultado.Rows(0).Item(0)
            TtBo_Baja_Dg_NombreProd.Text = Resultado.Rows(0).Item(1)
            TtBo_Baja_Dg_DescProd.Text = Resultado.Rows(0).Item(2)
            CoBo_Baja_Dg_ContenidoProd.Text = TipoContenido
            TtBo_Baja_Dg_ContenidoProd.Text = ContenidoEmbase
            NuUpDo_Baja_CantidadExistProd.Value = Resultado.Rows(0).Item(6)
            TtBo_Baja_ProvProd.Text = Resultado.Rows(0).Item(5)
            TtBo_Baja_PrecioProvProd.Text = Resultado.Rows(0).Item(9)
            TtBo_Baja_PrecioPublicProd.Text = Resultado.Rows(0).Item(10)
            TtBo_Baja_CodBarraProd.Clear()
        Else
            MsgBox("No se encontrarón elementos en la busqueda", MsgBoxStyle.Critical, "Error en la busqueda")
        End If
    End Sub

    Private Sub Btn_Baja_EliminarProd_Click(sender As Object, e As EventArgs) Handles Btn_Baja_EliminarProd.Click
        Dim Consulta = New Consultas.Producto()
        Dim Resultado As Boolean = Consulta.BajaProductos(Id)
        If Resultado Then
            MsgBox("Se elimino el producto exitosamente", MsgBoxStyle.Information, "Exito en la eliminación")
            LimpiarCajasBajas()
        Else
            MsgBox("No se origino un error al intentar eliminar el producto", MsgBoxStyle.Critical, "Error en la eliminación del producto")
        End If
    End Sub

    Private Sub Btn_Baja_LimpiarProd_Click(sender As Object, e As EventArgs) Handles Btn_Baja_LimpiarProd.Click
        LimpiarCajasBajas()
    End Sub

    Private Sub Btn_Alta_LimpiarProd_Click(sender As Object, e As EventArgs) Handles Btn_Alta_LimpiarProd.Click
        LimpiarCajasAlta()
    End Sub

    Private Sub Btn_Cambios_Guardar_Prod_Click(sender As Object, e As EventArgs) Handles Btn_Cambios_Guardar_Prod.Click
        If Btn_Cambios_Guardar_Prod.Text = "Buscar" Then

            Dim CodBarra As String = TtBo_Cambios_CodBarraProd.Text
            Dim Consulta = New Consultas.ConsultasGenerales()
            Dim Resultado As DataTable = Consulta.ConsultaTodoPor("Productos", "CodBarra", "Prod", CodBarra)
            If Resultado.Rows.Count > 0 Then
                Dim Resultado_Categorias As DataTable = Consulta.ConsultaTodo("Categorias")
                Dim Resultado_Proveedores As DataTable = Consulta.ConsultaTodo("Proveedores")
                For i = 1 To Resultado_Categorias.Rows.Count - 1
                    CoBo_Cambios_CategoriasProd.Items.Add(Resultado_Categorias.Rows(i).Item(1))
                Next
                For i = 1 To Resultado_Proveedores.Rows.Count - 1
                    CoBo_Cambios_ProvProd.Items.Add(Resultado_Proveedores.Rows(i).Item(1))
                Next

                Dim Columna As Integer = Resultado.Rows().Count() - 1
                Dim DesicionCk = Resultado.Rows(Columna).Item(7)

                Dim Id_Ctg As Integer = Resultado.Rows(Columna).Item(4)
                Dim Resultado_Ctg As DataTable = Consulta.ConsultaTodoPor("Categorias", "Id", "Ctg", Id_Ctg)
                Dim Id_Prov As Integer = Resultado.Rows(Columna).Item(5)
                Dim Resultado_Prov As DataTable = Consulta.ConsultaTodoPor("Proveedores", "Id", "Prov", Id_Prov)

                Dim Contenido As String = Resultado.Rows(Columna).Item(3)
                Dim TipoContenido As String = Contenido.Substring(Contenido.Length - 2, 2)
                Dim ContenidoEmbase As String = Contenido.Substring(0, Contenido.Length - 2)

                TtBo_Cambios_CodBarraProd.Text = Resultado.Rows(Columna).Item(0)
                TtBo_Cambios_NombreProd.Text = Resultado.Rows(Columna).Item(1)
                TtBo_Cambios_DescProd.Text = Resultado.Rows(Columna).Item(2)
                TtBo_Cambios_ContenidoProd.Text = ContenidoEmbase
                CoBo_Cambios_ContenidoProd.Text = TipoContenido
                CoBo_Cambios_CategoriasProd.Text = Resultado_Ctg.Rows(0).Item(1)
                CoBo_Cambios_ProvProd.Text = Resultado_Prov.Rows(0).Item(1)
                NuUpDo_Cambios_CantidadExistProd.Value = Resultado.Rows(Columna).Item(6)
                If DesicionCk = "Sí, Caduca" Then
                    RaBo_Cambios_SiCaducaProd.Checked = True
                Else
                    RaBo_Cambios_NoCaducaProd.Checked = False
                End If
                DaTiPi_Cambios_FechaCaducaProd.Value = Resultado.Rows(Columna).Item(8)
                TtBo_Cambios_PrecProvProd.Text = Resultado.Rows(Columna).Item(9)
                TtBo_Cambios_PrecPublicProd.Text = Resultado.Rows(Columna).Item(10)
                'Console.WriteLine(Resultado.Rows(Columna).Item(11).ToString)
                If Resultado.Rows(Columna).Item(11) Is Nothing Then
                    Dim ImagenBy As Byte() = Resultado.Rows(Columna).Item(11)
                    Dim Binarios As New System.IO.MemoryStream(ImagenBy)
                    Dim Imagen As Image = Image.FromStream(Binarios)
                    PiBo_Cambios_ImgProd.Image = Imagen
                End If
                Btn_Cambios_Guardar_Prod.Text = "Guardar"
            End If
        Else
            Dim ValorRadioBotom As String = ""
            Dim Imagen As Image
            If RaBo_Cambios_SiCaducaProd.Checked Then
                ValorRadioBotom = "Sí, Caduca"
            End If
            If RaBo_Cambios_NoCaducaProd.Checked Then
                ValorRadioBotom = "No, Caduca"
            End If

            Dim Dia As String = DaTiPi_Cambios_FechaCaducaProd.Value.Day
            Dim Mes As String = DaTiPi_Cambios_FechaCaducaProd.Value.Month
            Dim Allo As String = DaTiPi_Cambios_FechaCaducaProd.Value.Year
            Dim Datos(11) As String
            Datos(0) = TtBo_Cambios_CodBarraProd.Text
            Datos(1) = TtBo_Cambios_NombreProd.Text
            Datos(2) = TtBo_Cambios_DescProd.Text
            Datos(3) = TtBo_Cambios_ContenidoProd.Text + CoBo_Cambios_ContenidoProd.Text
            Datos(4) = CoBo_Cambios_CategoriasProd.Text
            Datos(5) = CoBo_Cambios_ProvProd.Text
            Datos(6) = NuUpDo_Cambios_CantidadExistProd.Value.ToString()
            Datos(7) = ValorRadioBotom
            Datos(8) = Dia + "/" + Mes + "/" + Allo
            Datos(9) = TtBo_Cambios_PrecProvProd.Text
            Datos(10) = TtBo_Cambios_PrecPublicProd.Text
            Imagen = PiBo_Cambios_ImgProd.Image
            Dim Consulta = New Consultas.Producto()
            Dim Respuesta As Boolean = Consulta.CambiosProducto(Datos, Imagen)
            If Respuesta Then
                MsgBox("Se guardo el producto con exito", MsgBoxStyle.Information, "Exito en el guardado")
                LimpiarCajasCambios()
                Btn_Cambios_Guardar_Prod.Text = "Buscar"
            Else
                MsgBox("Se Origino un error al tratar de guardar el producto", MsgBoxStyle.Critical, "Error en el guardado")
            End If
        End If
    End Sub

    Private Sub Btn_Cambios_Eliminar_Prod_Click(sender As Object, e As EventArgs) Handles Btn_Cambios_Eliminar_Prod.Click
        LimpiarCajasCambios()
    End Sub

    Private Sub Btn_Cambios_SubirImg_Click(sender As Object, e As EventArgs) Handles Btn_Cambios_SubirImg.Click
        Dim File As New OpenFileDialog()
        Dim informacion = My.Computer.FileSystem
        File.InitialDirectory = "c:\\"
        File.Filter = "Archivo PNG| *.png"
        If File.ShowDialog() = DialogResult.OK Then
            PiBo_Cambios_ImgProd.Image = Image.FromFile(File.FileName)
            Dim Path_Img = informacion.GetFileInfo(File.FileName).FullName
            Console.WriteLine("Path file: " + File.FileName)
        End If
    End Sub

    Private Sub TtBo_Cambios_CodBarraProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TtBo_Cambios_CodBarraProd.KeyPress
        Dim Validaciones = New Validaciones_Numeros()
        Validaciones.Textos_solo_numeros(sender, e)
    End Sub

    Private Sub TtBo_Baja_CodBarraProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TtBo_Baja_CodBarraProd.KeyPress
        Dim Validaciones = New Validaciones_Numeros()
        Validaciones.Textos_solo_numeros(sender, e)
    End Sub


    Private Sub TtBo_Consulta_CodBarraProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TtBo_Consulta_CodBarraProd.KeyPress
        Dim Validaciones = New Validaciones_Numeros()
        Validaciones.Textos_solo_numeros(sender, e)
    End Sub

    Private Sub TtBo_Alta_CodBarraProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TtBo_Alta_CodBarraProd.KeyPress
        Dim Validaciones = New Validaciones_Numeros()
        Validaciones.Textos_solo_numeros(sender, e)
    End Sub
End Class