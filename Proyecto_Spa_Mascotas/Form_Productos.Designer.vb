<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Productos))
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_ABCC_Productos = New System.Windows.Forms.TabControl()
        Me.Alta_Productos = New System.Windows.Forms.TabPage()
        Me.GrBo_DG_Prod = New System.Windows.Forms.GroupBox()
        Me.Lab_Alta_CodBarraProd = New System.Windows.Forms.Label()
        Me.TtBo_Alta_CodBarraProd = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_ProvProd = New System.Windows.Forms.Label()
        Me.CoBo_Alta_ProvProd = New System.Windows.Forms.ComboBox()
        Me.CoBo_Alta_ContenidoProd = New System.Windows.Forms.ComboBox()
        Me.Lab_Alta_NombProd = New System.Windows.Forms.Label()
        Me.TtBo_Alta_NombProd = New System.Windows.Forms.TextBox()
        Me.DaTiPi_Alta_FechaCaducaProd = New System.Windows.Forms.DateTimePicker()
        Me.Lab_Alta_DescripProd = New System.Windows.Forms.Label()
        Me.Lab_Alta_CuandoCaducaProd = New System.Windows.Forms.Label()
        Me.Lab_Alta_CapacidadProd = New System.Windows.Forms.Label()
        Me.RaBo_Alta_NoCaducaProd = New System.Windows.Forms.RadioButton()
        Me.Lab_Alta_CatgProd = New System.Windows.Forms.Label()
        Me.RaBo_Alta_SiCaducaProd = New System.Windows.Forms.RadioButton()
        Me.TtBo_Alta_DescripProd = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_FechCadProd = New System.Windows.Forms.Label()
        Me.TtBo_Alta_ContenidoProd = New System.Windows.Forms.TextBox()
        Me.NuUpDo_Alta_CantidadExistProd = New System.Windows.Forms.NumericUpDown()
        Me.CoBo_Alta_CategoriaProd = New System.Windows.Forms.ComboBox()
        Me.Lab_Alta_CantExisProd = New System.Windows.Forms.Label()
        Me.Btn_Alta_SubirImg = New System.Windows.Forms.Button()
        Me.PiBo_Alta_ImgProd = New System.Windows.Forms.PictureBox()
        Me.Btn_Alta_LimpiarProd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TtBo_Alta_PrecioPublicoProd = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_PrecioProvProd = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_PrecioPublicoProd = New System.Windows.Forms.Label()
        Me.Lab_Alta_PrecioProvProd = New System.Windows.Forms.Label()
        Me.Btn_Alta_Guardar = New System.Windows.Forms.Button()
        Me.Consulta_Productos = New System.Windows.Forms.TabPage()
        Me.DGVListProd = New System.Windows.Forms.DataGridView()
        Me.DGV_CodigoBarra_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Desc_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Fcaducidad_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_PrecioPub_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_PrecioProv_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_CantidadEx_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_BuscarTodoProd = New System.Windows.Forms.Button()
        Me.Btn_BuscarCodBarraProd = New System.Windows.Forms.Button()
        Me.TtBo_Consulta_CodBarraProd = New System.Windows.Forms.TextBox()
        Me.Lab_Consulta_CodBarra = New System.Windows.Forms.Label()
        Me.Baja_Productos = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Btn_Baja_LimpiarProd = New System.Windows.Forms.Button()
        Me.Btn_Baja_EliminarProd = New System.Windows.Forms.Button()
        Me.TtBo_Baja_PrecioPublicProd = New System.Windows.Forms.TextBox()
        Me.TtBo_Baja_PrecioProvProd = New System.Windows.Forms.TextBox()
        Me.TtBo_Baja_ProvProd = New System.Windows.Forms.TextBox()
        Me.CoBo_Baja_Dg_ContenidoProd = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TtBo_Baja_Dg_ContenidoProd = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NuUpDo_Baja_CantidadExistProd = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TtBo_Baja_Dg_DescProd = New System.Windows.Forms.TextBox()
        Me.TtBo_Baja_Dg_NombreProd = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TtBo_Baja_Dg_CodBarraProd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btn_Buscar_BajasProd = New System.Windows.Forms.Button()
        Me.TtBo_Baja_CodBarraProd = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Cambios_Productos = New System.Windows.Forms.TabPage()
        Me.Btn_Cambios_SubirImg = New System.Windows.Forms.Button()
        Me.PiBo_Cambios_ImgProd = New System.Windows.Forms.PictureBox()
        Me.Btn_Cambios_Eliminar_Prod = New System.Windows.Forms.Button()
        Me.Btn_Cambios_Guardar_Prod = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TtBo_Cambios_PrecPublicProd = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_PrecProvProd = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CoBo_Cambios_ProvProd = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CoBo_Cambios_ContenidoProd = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_NombreProd = New System.Windows.Forms.TextBox()
        Me.DaTiPi_Cambios_FechaCaducaProd = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.RaBo_Cambios_NoCaducaProd = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.RaBo_Cambios_SiCaducaProd = New System.Windows.Forms.RadioButton()
        Me.TtBo_Cambios_DescProd = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_ContenidoProd = New System.Windows.Forms.TextBox()
        Me.NuUpDo_Cambios_CantidadExistProd = New System.Windows.Forms.NumericUpDown()
        Me.CoBo_Cambios_CategoriasProd = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_CodBarraProd = New System.Windows.Forms.TextBox()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_ABCC_Productos.SuspendLayout()
        Me.Alta_Productos.SuspendLayout()
        Me.GrBo_DG_Prod.SuspendLayout()
        CType(Me.NuUpDo_Alta_CantidadExistProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PiBo_Alta_ImgProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Consulta_Productos.SuspendLayout()
        CType(Me.DGVListProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Baja_Productos.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NuUpDo_Baja_CantidadExistProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Cambios_Productos.SuspendLayout()
        CType(Me.PiBo_Cambios_ImgProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.NuUpDo_Cambios_CantidadExistProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(12, 27)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(75, 23)
        Me.Btn_atras.TabIndex = 0
        Me.Btn_atras.TabStop = False
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiciosToolStripMenuItem1, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.CaducosToolStripMenuItem})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Size = New System.Drawing.Size(800, 24)
        Me.MenuS_Principal.TabIndex = 7
        Me.MenuS_Principal.Text = "MenuStrip1"
        '
        'ServiciosToolStripMenuItem1
        '
        Me.ServiciosToolStripMenuItem1.Name = "ServiciosToolStripMenuItem1"
        Me.ServiciosToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.ServiciosToolStripMenuItem1.Text = "Servicios"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'ClientesYMascotasToolStripMenuItem
        '
        Me.ClientesYMascotasToolStripMenuItem.Name = "ClientesYMascotasToolStripMenuItem"
        Me.ClientesYMascotasToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.ClientesYMascotasToolStripMenuItem.Text = "Clientes y mascotas"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'CaducosToolStripMenuItem
        '
        Me.CaducosToolStripMenuItem.Name = "CaducosToolStripMenuItem"
        Me.CaducosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.CaducosToolStripMenuItem.Text = "Caducos"
        '
        'Tab_ABCC_Productos
        '
        Me.Tab_ABCC_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_ABCC_Productos.Controls.Add(Me.Alta_Productos)
        Me.Tab_ABCC_Productos.Controls.Add(Me.Consulta_Productos)
        Me.Tab_ABCC_Productos.Controls.Add(Me.Baja_Productos)
        Me.Tab_ABCC_Productos.Controls.Add(Me.Cambios_Productos)
        Me.Tab_ABCC_Productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Tab_ABCC_Productos.Location = New System.Drawing.Point(12, 68)
        Me.Tab_ABCC_Productos.Name = "Tab_ABCC_Productos"
        Me.Tab_ABCC_Productos.SelectedIndex = 0
        Me.Tab_ABCC_Productos.Size = New System.Drawing.Size(776, 381)
        Me.Tab_ABCC_Productos.TabIndex = 0
        Me.Tab_ABCC_Productos.TabStop = False
        '
        'Alta_Productos
        '
        Me.Alta_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_Productos.Controls.Add(Me.GrBo_DG_Prod)
        Me.Alta_Productos.Controls.Add(Me.Btn_Alta_SubirImg)
        Me.Alta_Productos.Controls.Add(Me.PiBo_Alta_ImgProd)
        Me.Alta_Productos.Controls.Add(Me.Btn_Alta_LimpiarProd)
        Me.Alta_Productos.Controls.Add(Me.GroupBox3)
        Me.Alta_Productos.Controls.Add(Me.Btn_Alta_Guardar)
        Me.Alta_Productos.Location = New System.Drawing.Point(4, 25)
        Me.Alta_Productos.Name = "Alta_Productos"
        Me.Alta_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Productos.Size = New System.Drawing.Size(768, 352)
        Me.Alta_Productos.TabIndex = 0
        Me.Alta_Productos.Text = "Alta de Productos"
        '
        'GrBo_DG_Prod
        '
        Me.GrBo_DG_Prod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_CodBarraProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.TtBo_Alta_CodBarraProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_ProvProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.CoBo_Alta_ProvProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.CoBo_Alta_ContenidoProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_NombProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.TtBo_Alta_NombProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.DaTiPi_Alta_FechaCaducaProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_DescripProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_CuandoCaducaProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_CapacidadProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.RaBo_Alta_NoCaducaProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_CatgProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.RaBo_Alta_SiCaducaProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.TtBo_Alta_DescripProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_FechCadProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.TtBo_Alta_ContenidoProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.NuUpDo_Alta_CantidadExistProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.CoBo_Alta_CategoriaProd)
        Me.GrBo_DG_Prod.Controls.Add(Me.Lab_Alta_CantExisProd)
        Me.GrBo_DG_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrBo_DG_Prod.Location = New System.Drawing.Point(18, 19)
        Me.GrBo_DG_Prod.Name = "GrBo_DG_Prod"
        Me.GrBo_DG_Prod.Size = New System.Drawing.Size(454, 339)
        Me.GrBo_DG_Prod.TabIndex = 8
        Me.GrBo_DG_Prod.TabStop = False
        Me.GrBo_DG_Prod.Text = "Datos generales"
        '
        'Lab_Alta_CodBarraProd
        '
        Me.Lab_Alta_CodBarraProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_CodBarraProd.AutoSize = True
        Me.Lab_Alta_CodBarraProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CodBarraProd.Location = New System.Drawing.Point(6, 22)
        Me.Lab_Alta_CodBarraProd.Name = "Lab_Alta_CodBarraProd"
        Me.Lab_Alta_CodBarraProd.Size = New System.Drawing.Size(114, 17)
        Me.Lab_Alta_CodBarraProd.TabIndex = 18
        Me.Lab_Alta_CodBarraProd.Text = "Código de barra:"
        '
        'TtBo_Alta_CodBarraProd
        '
        Me.TtBo_Alta_CodBarraProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TtBo_Alta_CodBarraProd.Location = New System.Drawing.Point(126, 16)
        Me.TtBo_Alta_CodBarraProd.MaxLength = 18
        Me.TtBo_Alta_CodBarraProd.Name = "TtBo_Alta_CodBarraProd"
        Me.TtBo_Alta_CodBarraProd.Size = New System.Drawing.Size(182, 23)
        Me.TtBo_Alta_CodBarraProd.TabIndex = 1
        Me.TtBo_Alta_CodBarraProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_ProvProd
        '
        Me.Lab_Alta_ProvProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_ProvProd.AutoSize = True
        Me.Lab_Alta_ProvProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_ProvProd.Location = New System.Drawing.Point(13, 189)
        Me.Lab_Alta_ProvProd.Name = "Lab_Alta_ProvProd"
        Me.Lab_Alta_ProvProd.Size = New System.Drawing.Size(78, 17)
        Me.Lab_Alta_ProvProd.TabIndex = 16
        Me.Lab_Alta_ProvProd.Text = "Proveedor:"
        '
        'CoBo_Alta_ProvProd
        '
        Me.CoBo_Alta_ProvProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoBo_Alta_ProvProd.FormattingEnabled = True
        Me.CoBo_Alta_ProvProd.Location = New System.Drawing.Point(126, 182)
        Me.CoBo_Alta_ProvProd.Name = "CoBo_Alta_ProvProd"
        Me.CoBo_Alta_ProvProd.Size = New System.Drawing.Size(182, 24)
        Me.CoBo_Alta_ProvProd.TabIndex = 7
        '
        'CoBo_Alta_ContenidoProd
        '
        Me.CoBo_Alta_ContenidoProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoBo_Alta_ContenidoProd.FormattingEnabled = True
        Me.CoBo_Alta_ContenidoProd.Items.AddRange(New Object() {"Ml", "L", "Kg", "Gr"})
        Me.CoBo_Alta_ContenidoProd.Location = New System.Drawing.Point(239, 111)
        Me.CoBo_Alta_ContenidoProd.Name = "CoBo_Alta_ContenidoProd"
        Me.CoBo_Alta_ContenidoProd.Size = New System.Drawing.Size(69, 24)
        Me.CoBo_Alta_ContenidoProd.TabIndex = 5
        '
        'Lab_Alta_NombProd
        '
        Me.Lab_Alta_NombProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_NombProd.AutoSize = True
        Me.Lab_Alta_NombProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NombProd.Location = New System.Drawing.Point(13, 49)
        Me.Lab_Alta_NombProd.Name = "Lab_Alta_NombProd"
        Me.Lab_Alta_NombProd.Size = New System.Drawing.Size(62, 17)
        Me.Lab_Alta_NombProd.TabIndex = 0
        Me.Lab_Alta_NombProd.Text = "Nombre:"
        '
        'TtBo_Alta_NombProd
        '
        Me.TtBo_Alta_NombProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TtBo_Alta_NombProd.Location = New System.Drawing.Point(126, 46)
        Me.TtBo_Alta_NombProd.MaxLength = 30
        Me.TtBo_Alta_NombProd.Name = "TtBo_Alta_NombProd"
        Me.TtBo_Alta_NombProd.Size = New System.Drawing.Size(182, 23)
        Me.TtBo_Alta_NombProd.TabIndex = 2
        Me.TtBo_Alta_NombProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DaTiPi_Alta_FechaCaducaProd
        '
        Me.DaTiPi_Alta_FechaCaducaProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DaTiPi_Alta_FechaCaducaProd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.DaTiPi_Alta_FechaCaducaProd.Location = New System.Drawing.Point(148, 275)
        Me.DaTiPi_Alta_FechaCaducaProd.MaxDate = New Date(2050, 1, 1, 0, 0, 0, 0)
        Me.DaTiPi_Alta_FechaCaducaProd.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DaTiPi_Alta_FechaCaducaProd.Name = "DaTiPi_Alta_FechaCaducaProd"
        Me.DaTiPi_Alta_FechaCaducaProd.Size = New System.Drawing.Size(238, 23)
        Me.DaTiPi_Alta_FechaCaducaProd.TabIndex = 11
        Me.DaTiPi_Alta_FechaCaducaProd.Value = New Date(2022, 1, 11, 0, 0, 0, 0)
        '
        'Lab_Alta_DescripProd
        '
        Me.Lab_Alta_DescripProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_DescripProd.AutoSize = True
        Me.Lab_Alta_DescripProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_DescripProd.Location = New System.Drawing.Point(13, 81)
        Me.Lab_Alta_DescripProd.Name = "Lab_Alta_DescripProd"
        Me.Lab_Alta_DescripProd.Size = New System.Drawing.Size(82, 17)
        Me.Lab_Alta_DescripProd.TabIndex = 2
        Me.Lab_Alta_DescripProd.Text = "Descripción"
        '
        'Lab_Alta_CuandoCaducaProd
        '
        Me.Lab_Alta_CuandoCaducaProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_CuandoCaducaProd.AutoSize = True
        Me.Lab_Alta_CuandoCaducaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CuandoCaducaProd.Location = New System.Drawing.Point(18, 275)
        Me.Lab_Alta_CuandoCaducaProd.Name = "Lab_Alta_CuandoCaducaProd"
        Me.Lab_Alta_CuandoCaducaProd.Size = New System.Drawing.Size(123, 17)
        Me.Lab_Alta_CuandoCaducaProd.TabIndex = 15
        Me.Lab_Alta_CuandoCaducaProd.Text = "¿Cuando caduca?"
        '
        'Lab_Alta_CapacidadProd
        '
        Me.Lab_Alta_CapacidadProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_CapacidadProd.AutoSize = True
        Me.Lab_Alta_CapacidadProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CapacidadProd.Location = New System.Drawing.Point(13, 118)
        Me.Lab_Alta_CapacidadProd.Name = "Lab_Alta_CapacidadProd"
        Me.Lab_Alta_CapacidadProd.Size = New System.Drawing.Size(90, 17)
        Me.Lab_Alta_CapacidadProd.TabIndex = 3
        Me.Lab_Alta_CapacidadProd.Text = "Peso o litros:"
        '
        'RaBo_Alta_NoCaducaProd
        '
        Me.RaBo_Alta_NoCaducaProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RaBo_Alta_NoCaducaProd.AutoSize = True
        Me.RaBo_Alta_NoCaducaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Alta_NoCaducaProd.Location = New System.Drawing.Point(327, 248)
        Me.RaBo_Alta_NoCaducaProd.Name = "RaBo_Alta_NoCaducaProd"
        Me.RaBo_Alta_NoCaducaProd.Size = New System.Drawing.Size(100, 21)
        Me.RaBo_Alta_NoCaducaProd.TabIndex = 10
        Me.RaBo_Alta_NoCaducaProd.TabStop = True
        Me.RaBo_Alta_NoCaducaProd.Text = "No, Caduca"
        Me.RaBo_Alta_NoCaducaProd.UseVisualStyleBackColor = True
        '
        'Lab_Alta_CatgProd
        '
        Me.Lab_Alta_CatgProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_CatgProd.AutoSize = True
        Me.Lab_Alta_CatgProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CatgProd.Location = New System.Drawing.Point(13, 155)
        Me.Lab_Alta_CatgProd.Name = "Lab_Alta_CatgProd"
        Me.Lab_Alta_CatgProd.Size = New System.Drawing.Size(73, 17)
        Me.Lab_Alta_CatgProd.TabIndex = 4
        Me.Lab_Alta_CatgProd.Text = "Categoria:"
        '
        'RaBo_Alta_SiCaducaProd
        '
        Me.RaBo_Alta_SiCaducaProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RaBo_Alta_SiCaducaProd.AutoSize = True
        Me.RaBo_Alta_SiCaducaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Alta_SiCaducaProd.Location = New System.Drawing.Point(227, 248)
        Me.RaBo_Alta_SiCaducaProd.Name = "RaBo_Alta_SiCaducaProd"
        Me.RaBo_Alta_SiCaducaProd.Size = New System.Drawing.Size(94, 21)
        Me.RaBo_Alta_SiCaducaProd.TabIndex = 9
        Me.RaBo_Alta_SiCaducaProd.TabStop = True
        Me.RaBo_Alta_SiCaducaProd.Text = "Sí, Caduca"
        Me.RaBo_Alta_SiCaducaProd.UseVisualStyleBackColor = True
        '
        'TtBo_Alta_DescripProd
        '
        Me.TtBo_Alta_DescripProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TtBo_Alta_DescripProd.Location = New System.Drawing.Point(126, 75)
        Me.TtBo_Alta_DescripProd.MaxLength = 120
        Me.TtBo_Alta_DescripProd.Name = "TtBo_Alta_DescripProd"
        Me.TtBo_Alta_DescripProd.Size = New System.Drawing.Size(182, 23)
        Me.TtBo_Alta_DescripProd.TabIndex = 3
        Me.TtBo_Alta_DescripProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_FechCadProd
        '
        Me.Lab_Alta_FechCadProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_FechCadProd.AutoSize = True
        Me.Lab_Alta_FechCadProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_FechCadProd.Location = New System.Drawing.Point(18, 250)
        Me.Lab_Alta_FechCadProd.Name = "Lab_Alta_FechCadProd"
        Me.Lab_Alta_FechCadProd.Size = New System.Drawing.Size(196, 17)
        Me.Lab_Alta_FechCadProd.TabIndex = 12
        Me.Lab_Alta_FechCadProd.Text = "¿Tienen fecha de caducidad?"
        '
        'TtBo_Alta_ContenidoProd
        '
        Me.TtBo_Alta_ContenidoProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TtBo_Alta_ContenidoProd.Location = New System.Drawing.Point(126, 111)
        Me.TtBo_Alta_ContenidoProd.MaxLength = 3
        Me.TtBo_Alta_ContenidoProd.Name = "TtBo_Alta_ContenidoProd"
        Me.TtBo_Alta_ContenidoProd.Size = New System.Drawing.Size(107, 23)
        Me.TtBo_Alta_ContenidoProd.TabIndex = 4
        Me.TtBo_Alta_ContenidoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NuUpDo_Alta_CantidadExistProd
        '
        Me.NuUpDo_Alta_CantidadExistProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuUpDo_Alta_CantidadExistProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NuUpDo_Alta_CantidadExistProd.Location = New System.Drawing.Point(176, 219)
        Me.NuUpDo_Alta_CantidadExistProd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NuUpDo_Alta_CantidadExistProd.Name = "NuUpDo_Alta_CantidadExistProd"
        Me.NuUpDo_Alta_CantidadExistProd.Size = New System.Drawing.Size(132, 23)
        Me.NuUpDo_Alta_CantidadExistProd.TabIndex = 8
        Me.NuUpDo_Alta_CantidadExistProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NuUpDo_Alta_CantidadExistProd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CoBo_Alta_CategoriaProd
        '
        Me.CoBo_Alta_CategoriaProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoBo_Alta_CategoriaProd.FormattingEnabled = True
        Me.CoBo_Alta_CategoriaProd.Location = New System.Drawing.Point(126, 148)
        Me.CoBo_Alta_CategoriaProd.Name = "CoBo_Alta_CategoriaProd"
        Me.CoBo_Alta_CategoriaProd.Size = New System.Drawing.Size(182, 24)
        Me.CoBo_Alta_CategoriaProd.TabIndex = 6
        '
        'Lab_Alta_CantExisProd
        '
        Me.Lab_Alta_CantExisProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Alta_CantExisProd.AutoSize = True
        Me.Lab_Alta_CantExisProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CantExisProd.Location = New System.Drawing.Point(18, 221)
        Me.Lab_Alta_CantExisProd.Name = "Lab_Alta_CantExisProd"
        Me.Lab_Alta_CantExisProd.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Alta_CantExisProd.TabIndex = 10
        Me.Lab_Alta_CantExisProd.Text = "Cantidad en existencia:"
        '
        'Btn_Alta_SubirImg
        '
        Me.Btn_Alta_SubirImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Alta_SubirImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Alta_SubirImg.Location = New System.Drawing.Point(560, 246)
        Me.Btn_Alta_SubirImg.Name = "Btn_Alta_SubirImg"
        Me.Btn_Alta_SubirImg.Size = New System.Drawing.Size(149, 30)
        Me.Btn_Alta_SubirImg.TabIndex = 14
        Me.Btn_Alta_SubirImg.Text = "Subír imagen"
        Me.Btn_Alta_SubirImg.UseVisualStyleBackColor = False
        '
        'PiBo_Alta_ImgProd
        '
        Me.PiBo_Alta_ImgProd.BackColor = System.Drawing.Color.White
        Me.PiBo_Alta_ImgProd.BackgroundImage = CType(resources.GetObject("PiBo_Alta_ImgProd.BackgroundImage"), System.Drawing.Image)
        Me.PiBo_Alta_ImgProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PiBo_Alta_ImgProd.Location = New System.Drawing.Point(544, 130)
        Me.PiBo_Alta_ImgProd.Name = "PiBo_Alta_ImgProd"
        Me.PiBo_Alta_ImgProd.Size = New System.Drawing.Size(175, 110)
        Me.PiBo_Alta_ImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PiBo_Alta_ImgProd.TabIndex = 15
        Me.PiBo_Alta_ImgProd.TabStop = False
        '
        'Btn_Alta_LimpiarProd
        '
        Me.Btn_Alta_LimpiarProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Alta_LimpiarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Alta_LimpiarProd.Location = New System.Drawing.Point(544, 293)
        Me.Btn_Alta_LimpiarProd.Name = "Btn_Alta_LimpiarProd"
        Me.Btn_Alta_LimpiarProd.Size = New System.Drawing.Size(63, 25)
        Me.Btn_Alta_LimpiarProd.TabIndex = 16
        Me.Btn_Alta_LimpiarProd.Text = "Limpiar"
        Me.Btn_Alta_LimpiarProd.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TtBo_Alta_PrecioPublicoProd)
        Me.GroupBox3.Controls.Add(Me.TtBo_Alta_PrecioProvProd)
        Me.GroupBox3.Controls.Add(Me.Lab_Alta_PrecioPublicoProd)
        Me.GroupBox3.Controls.Add(Me.Lab_Alta_PrecioProvProd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(478, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(272, 98)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de precio"
        '
        'TtBo_Alta_PrecioPublicoProd
        '
        Me.TtBo_Alta_PrecioPublicoProd.Location = New System.Drawing.Point(154, 55)
        Me.TtBo_Alta_PrecioPublicoProd.MaxLength = 5
        Me.TtBo_Alta_PrecioPublicoProd.Name = "TtBo_Alta_PrecioPublicoProd"
        Me.TtBo_Alta_PrecioPublicoProd.Size = New System.Drawing.Size(112, 23)
        Me.TtBo_Alta_PrecioPublicoProd.TabIndex = 13
        '
        'TtBo_Alta_PrecioProvProd
        '
        Me.TtBo_Alta_PrecioProvProd.Location = New System.Drawing.Point(154, 25)
        Me.TtBo_Alta_PrecioProvProd.MaxLength = 5
        Me.TtBo_Alta_PrecioProvProd.Name = "TtBo_Alta_PrecioProvProd"
        Me.TtBo_Alta_PrecioProvProd.Size = New System.Drawing.Size(112, 23)
        Me.TtBo_Alta_PrecioProvProd.TabIndex = 12
        Me.TtBo_Alta_PrecioProvProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_PrecioPublicoProd
        '
        Me.Lab_Alta_PrecioPublicoProd.AutoSize = True
        Me.Lab_Alta_PrecioPublicoProd.Location = New System.Drawing.Point(6, 55)
        Me.Lab_Alta_PrecioPublicoProd.Name = "Lab_Alta_PrecioPublicoProd"
        Me.Lab_Alta_PrecioPublicoProd.Size = New System.Drawing.Size(116, 17)
        Me.Lab_Alta_PrecioPublicoProd.TabIndex = 1
        Me.Lab_Alta_PrecioPublicoProd.Text = "Precio al público:"
        '
        'Lab_Alta_PrecioProvProd
        '
        Me.Lab_Alta_PrecioProvProd.AutoSize = True
        Me.Lab_Alta_PrecioProvProd.Location = New System.Drawing.Point(6, 25)
        Me.Lab_Alta_PrecioProvProd.Name = "Lab_Alta_PrecioProvProd"
        Me.Lab_Alta_PrecioProvProd.Size = New System.Drawing.Size(141, 17)
        Me.Lab_Alta_PrecioProvProd.TabIndex = 0
        Me.Lab_Alta_PrecioProvProd.Text = "Precio de proveedor:"
        '
        'Btn_Alta_Guardar
        '
        Me.Btn_Alta_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Alta_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Alta_Guardar.Location = New System.Drawing.Point(613, 294)
        Me.Btn_Alta_Guardar.Name = "Btn_Alta_Guardar"
        Me.Btn_Alta_Guardar.Size = New System.Drawing.Size(106, 25)
        Me.Btn_Alta_Guardar.TabIndex = 15
        Me.Btn_Alta_Guardar.Text = "Guardar"
        Me.Btn_Alta_Guardar.UseVisualStyleBackColor = False
        '
        'Consulta_Productos
        '
        Me.Consulta_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_Productos.Controls.Add(Me.DGVListProd)
        Me.Consulta_Productos.Controls.Add(Me.GroupBox1)
        Me.Consulta_Productos.Location = New System.Drawing.Point(4, 25)
        Me.Consulta_Productos.Name = "Consulta_Productos"
        Me.Consulta_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.Consulta_Productos.Size = New System.Drawing.Size(768, 352)
        Me.Consulta_Productos.TabIndex = 1
        Me.Consulta_Productos.Text = "Consulta de Producto"
        '
        'DGVListProd
        '
        Me.DGVListProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_CodigoBarra_Producto, Me.DGV_Nombre_Producto, Me.DGV_Desc_Producto, Me.DGV_Fcaducidad_Producto, Me.DGV_PrecioPub_Producto, Me.DGV_PrecioProv_Producto, Me.DGV_CantidadEx_Producto})
        Me.DGVListProd.Location = New System.Drawing.Point(21, 167)
        Me.DGVListProd.Name = "DGVListProd"
        Me.DGVListProd.Size = New System.Drawing.Size(741, 163)
        Me.DGVListProd.TabIndex = 0
        '
        'DGV_CodigoBarra_Producto
        '
        Me.DGV_CodigoBarra_Producto.HeaderText = "Código de barra"
        Me.DGV_CodigoBarra_Producto.MaxInputLength = 15
        Me.DGV_CodigoBarra_Producto.Name = "DGV_CodigoBarra_Producto"
        '
        'DGV_Nombre_Producto
        '
        Me.DGV_Nombre_Producto.HeaderText = "Nombre"
        Me.DGV_Nombre_Producto.MaxInputLength = 100
        Me.DGV_Nombre_Producto.Name = "DGV_Nombre_Producto"
        '
        'DGV_Desc_Producto
        '
        Me.DGV_Desc_Producto.HeaderText = "Descripción"
        Me.DGV_Desc_Producto.MaxInputLength = 120
        Me.DGV_Desc_Producto.Name = "DGV_Desc_Producto"
        '
        'DGV_Fcaducidad_Producto
        '
        Me.DGV_Fcaducidad_Producto.HeaderText = "Fecha de caducidad"
        Me.DGV_Fcaducidad_Producto.MaxInputLength = 10
        Me.DGV_Fcaducidad_Producto.Name = "DGV_Fcaducidad_Producto"
        '
        'DGV_PrecioPub_Producto
        '
        Me.DGV_PrecioPub_Producto.HeaderText = "Precio al publico"
        Me.DGV_PrecioPub_Producto.MaxInputLength = 5
        Me.DGV_PrecioPub_Producto.Name = "DGV_PrecioPub_Producto"
        '
        'DGV_PrecioProv_Producto
        '
        Me.DGV_PrecioProv_Producto.HeaderText = "Precio de proveedor"
        Me.DGV_PrecioProv_Producto.MaxInputLength = 5
        Me.DGV_PrecioProv_Producto.Name = "DGV_PrecioProv_Producto"
        '
        'DGV_CantidadEx_Producto
        '
        Me.DGV_CantidadEx_Producto.HeaderText = "Cantidad de producto en existencia"
        Me.DGV_CantidadEx_Producto.MaxInputLength = 3
        Me.DGV_CantidadEx_Producto.Name = "DGV_CantidadEx_Producto"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Btn_BuscarTodoProd)
        Me.GroupBox1.Controls.Add(Me.Btn_BuscarCodBarraProd)
        Me.GroupBox1.Controls.Add(Me.TtBo_Consulta_CodBarraProd)
        Me.GroupBox1.Controls.Add(Me.Lab_Consulta_CodBarra)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(173, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de busqueda"
        '
        'Btn_BuscarTodoProd
        '
        Me.Btn_BuscarTodoProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_BuscarTodoProd.Location = New System.Drawing.Point(113, 57)
        Me.Btn_BuscarTodoProd.Name = "Btn_BuscarTodoProd"
        Me.Btn_BuscarTodoProd.Size = New System.Drawing.Size(157, 25)
        Me.Btn_BuscarTodoProd.TabIndex = 3
        Me.Btn_BuscarTodoProd.Text = "Buscar todo"
        Me.Btn_BuscarTodoProd.UseVisualStyleBackColor = False
        '
        'Btn_BuscarCodBarraProd
        '
        Me.Btn_BuscarCodBarraProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_BuscarCodBarraProd.Location = New System.Drawing.Point(276, 57)
        Me.Btn_BuscarCodBarraProd.Name = "Btn_BuscarCodBarraProd"
        Me.Btn_BuscarCodBarraProd.Size = New System.Drawing.Size(157, 25)
        Me.Btn_BuscarCodBarraProd.TabIndex = 2
        Me.Btn_BuscarCodBarraProd.Text = "Buscar"
        Me.Btn_BuscarCodBarraProd.UseVisualStyleBackColor = False
        '
        'TtBo_Consulta_CodBarraProd
        '
        Me.TtBo_Consulta_CodBarraProd.Location = New System.Drawing.Point(190, 28)
        Me.TtBo_Consulta_CodBarraProd.MaxLength = 18
        Me.TtBo_Consulta_CodBarraProd.Name = "TtBo_Consulta_CodBarraProd"
        Me.TtBo_Consulta_CodBarraProd.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Consulta_CodBarraProd.TabIndex = 1
        Me.TtBo_Consulta_CodBarraProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Consulta_CodBarra
        '
        Me.Lab_Consulta_CodBarra.AutoSize = True
        Me.Lab_Consulta_CodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Consulta_CodBarra.Location = New System.Drawing.Point(57, 31)
        Me.Lab_Consulta_CodBarra.Name = "Lab_Consulta_CodBarra"
        Me.Lab_Consulta_CodBarra.Size = New System.Drawing.Size(114, 17)
        Me.Lab_Consulta_CodBarra.TabIndex = 0
        Me.Lab_Consulta_CodBarra.Text = "Código de barra:"
        '
        'Baja_Productos
        '
        Me.Baja_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baja_Productos.Controls.Add(Me.GroupBox5)
        Me.Baja_Productos.Controls.Add(Me.GroupBox4)
        Me.Baja_Productos.Location = New System.Drawing.Point(4, 25)
        Me.Baja_Productos.Name = "Baja_Productos"
        Me.Baja_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Productos.Size = New System.Drawing.Size(768, 352)
        Me.Baja_Productos.TabIndex = 3
        Me.Baja_Productos.Text = "Bajas de Productos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Btn_Baja_LimpiarProd)
        Me.GroupBox5.Controls.Add(Me.Btn_Baja_EliminarProd)
        Me.GroupBox5.Controls.Add(Me.TtBo_Baja_PrecioPublicProd)
        Me.GroupBox5.Controls.Add(Me.TtBo_Baja_PrecioProvProd)
        Me.GroupBox5.Controls.Add(Me.TtBo_Baja_ProvProd)
        Me.GroupBox5.Controls.Add(Me.CoBo_Baja_Dg_ContenidoProd)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TtBo_Baja_Dg_ContenidoProd)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.NuUpDo_Baja_CantidadExistProd)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.TtBo_Baja_Dg_DescProd)
        Me.GroupBox5.Controls.Add(Me.TtBo_Baja_Dg_NombreProd)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.TtBo_Baja_Dg_CodBarraProd)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 124)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(725, 214)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos generales del producto"
        '
        'Btn_Baja_LimpiarProd
        '
        Me.Btn_Baja_LimpiarProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Baja_LimpiarProd.Location = New System.Drawing.Point(530, 152)
        Me.Btn_Baja_LimpiarProd.Name = "Btn_Baja_LimpiarProd"
        Me.Btn_Baja_LimpiarProd.Size = New System.Drawing.Size(78, 28)
        Me.Btn_Baja_LimpiarProd.TabIndex = 4
        Me.Btn_Baja_LimpiarProd.Text = "Limpiar"
        Me.Btn_Baja_LimpiarProd.UseVisualStyleBackColor = False
        '
        'Btn_Baja_EliminarProd
        '
        Me.Btn_Baja_EliminarProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Baja_EliminarProd.Location = New System.Drawing.Point(612, 152)
        Me.Btn_Baja_EliminarProd.Name = "Btn_Baja_EliminarProd"
        Me.Btn_Baja_EliminarProd.Size = New System.Drawing.Size(106, 28)
        Me.Btn_Baja_EliminarProd.TabIndex = 3
        Me.Btn_Baja_EliminarProd.Text = "Eliminar"
        Me.Btn_Baja_EliminarProd.UseVisualStyleBackColor = False
        '
        'TtBo_Baja_PrecioPublicProd
        '
        Me.TtBo_Baja_PrecioPublicProd.Location = New System.Drawing.Point(529, 123)
        Me.TtBo_Baja_PrecioPublicProd.MaxLength = 120
        Me.TtBo_Baja_PrecioPublicProd.Name = "TtBo_Baja_PrecioPublicProd"
        Me.TtBo_Baja_PrecioPublicProd.ReadOnly = True
        Me.TtBo_Baja_PrecioPublicProd.Size = New System.Drawing.Size(189, 23)
        Me.TtBo_Baja_PrecioPublicProd.TabIndex = 16
        '
        'TtBo_Baja_PrecioProvProd
        '
        Me.TtBo_Baja_PrecioProvProd.Location = New System.Drawing.Point(529, 88)
        Me.TtBo_Baja_PrecioProvProd.MaxLength = 120
        Me.TtBo_Baja_PrecioProvProd.Name = "TtBo_Baja_PrecioProvProd"
        Me.TtBo_Baja_PrecioProvProd.ReadOnly = True
        Me.TtBo_Baja_PrecioProvProd.Size = New System.Drawing.Size(189, 23)
        Me.TtBo_Baja_PrecioProvProd.TabIndex = 15
        '
        'TtBo_Baja_ProvProd
        '
        Me.TtBo_Baja_ProvProd.Location = New System.Drawing.Point(529, 54)
        Me.TtBo_Baja_ProvProd.MaxLength = 120
        Me.TtBo_Baja_ProvProd.Name = "TtBo_Baja_ProvProd"
        Me.TtBo_Baja_ProvProd.ReadOnly = True
        Me.TtBo_Baja_ProvProd.Size = New System.Drawing.Size(189, 23)
        Me.TtBo_Baja_ProvProd.TabIndex = 14
        '
        'CoBo_Baja_Dg_ContenidoProd
        '
        Me.CoBo_Baja_Dg_ContenidoProd.Enabled = False
        Me.CoBo_Baja_Dg_ContenidoProd.FormattingEnabled = True
        Me.CoBo_Baja_Dg_ContenidoProd.Items.AddRange(New Object() {"Ml", "L", "Kg", "Gr"})
        Me.CoBo_Baja_Dg_ContenidoProd.Location = New System.Drawing.Point(302, 129)
        Me.CoBo_Baja_Dg_ContenidoProd.Name = "CoBo_Baja_Dg_ContenidoProd"
        Me.CoBo_Baja_Dg_ContenidoProd.Size = New System.Drawing.Size(69, 24)
        Me.CoBo_Baja_Dg_ContenidoProd.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(7, 137)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 17)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Peso o litros:"
        '
        'TtBo_Baja_Dg_ContenidoProd
        '
        Me.TtBo_Baja_Dg_ContenidoProd.Location = New System.Drawing.Point(182, 131)
        Me.TtBo_Baja_Dg_ContenidoProd.MaxLength = 3
        Me.TtBo_Baja_Dg_ContenidoProd.Name = "TtBo_Baja_Dg_ContenidoProd"
        Me.TtBo_Baja_Dg_ContenidoProd.ReadOnly = True
        Me.TtBo_Baja_Dg_ContenidoProd.Size = New System.Drawing.Size(107, 23)
        Me.TtBo_Baja_Dg_ContenidoProd.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(382, 123)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 17)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Precio al público:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(382, 94)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 17)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Precio de proveedor:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(382, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Proveedor:"
        '
        'NuUpDo_Baja_CantidadExistProd
        '
        Me.NuUpDo_Baja_CantidadExistProd.Location = New System.Drawing.Point(568, 23)
        Me.NuUpDo_Baja_CantidadExistProd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NuUpDo_Baja_CantidadExistProd.Name = "NuUpDo_Baja_CantidadExistProd"
        Me.NuUpDo_Baja_CantidadExistProd.ReadOnly = True
        Me.NuUpDo_Baja_CantidadExistProd.Size = New System.Drawing.Size(120, 23)
        Me.NuUpDo_Baja_CantidadExistProd.TabIndex = 7
        Me.NuUpDo_Baja_CantidadExistProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NuUpDo_Baja_CantidadExistProd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(382, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(179, 17)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Cantidad total de producto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(169, 17)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Descripción del producto:"
        '
        'TtBo_Baja_Dg_DescProd
        '
        Me.TtBo_Baja_Dg_DescProd.Location = New System.Drawing.Point(182, 94)
        Me.TtBo_Baja_Dg_DescProd.MaxLength = 120
        Me.TtBo_Baja_Dg_DescProd.Name = "TtBo_Baja_Dg_DescProd"
        Me.TtBo_Baja_Dg_DescProd.ReadOnly = True
        Me.TtBo_Baja_Dg_DescProd.Size = New System.Drawing.Size(189, 23)
        Me.TtBo_Baja_Dg_DescProd.TabIndex = 4
        '
        'TtBo_Baja_Dg_NombreProd
        '
        Me.TtBo_Baja_Dg_NombreProd.Location = New System.Drawing.Point(182, 57)
        Me.TtBo_Baja_Dg_NombreProd.MaxLength = 100
        Me.TtBo_Baja_Dg_NombreProd.Name = "TtBo_Baja_Dg_NombreProd"
        Me.TtBo_Baja_Dg_NombreProd.ReadOnly = True
        Me.TtBo_Baja_Dg_NombreProd.Size = New System.Drawing.Size(182, 23)
        Me.TtBo_Baja_Dg_NombreProd.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Nombre del producto:"
        '
        'TtBo_Baja_Dg_CodBarraProd
        '
        Me.TtBo_Baja_Dg_CodBarraProd.Location = New System.Drawing.Point(182, 22)
        Me.TtBo_Baja_Dg_CodBarraProd.MaxLength = 15
        Me.TtBo_Baja_Dg_CodBarraProd.Name = "TtBo_Baja_Dg_CodBarraProd"
        Me.TtBo_Baja_Dg_CodBarraProd.ReadOnly = True
        Me.TtBo_Baja_Dg_CodBarraProd.Size = New System.Drawing.Size(150, 23)
        Me.TtBo_Baja_Dg_CodBarraProd.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Código de barra:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Btn_Buscar_BajasProd)
        Me.GroupBox4.Controls.Add(Me.TtBo_Baja_CodBarraProd)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(230, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de busqueda"
        '
        'Btn_Buscar_BajasProd
        '
        Me.Btn_Buscar_BajasProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Buscar_BajasProd.Location = New System.Drawing.Point(219, 57)
        Me.Btn_Buscar_BajasProd.Name = "Btn_Buscar_BajasProd"
        Me.Btn_Buscar_BajasProd.Size = New System.Drawing.Size(157, 23)
        Me.Btn_Buscar_BajasProd.TabIndex = 2
        Me.Btn_Buscar_BajasProd.Text = "Buscar"
        Me.Btn_Buscar_BajasProd.UseVisualStyleBackColor = False
        '
        'TtBo_Baja_CodBarraProd
        '
        Me.TtBo_Baja_CodBarraProd.Location = New System.Drawing.Point(190, 28)
        Me.TtBo_Baja_CodBarraProd.MaxLength = 18
        Me.TtBo_Baja_CodBarraProd.Name = "TtBo_Baja_CodBarraProd"
        Me.TtBo_Baja_CodBarraProd.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Baja_CodBarraProd.TabIndex = 1
        Me.TtBo_Baja_CodBarraProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(57, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Código de barra:"
        '
        'Cambios_Productos
        '
        Me.Cambios_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cambios_Productos.Controls.Add(Me.Btn_Cambios_SubirImg)
        Me.Cambios_Productos.Controls.Add(Me.PiBo_Cambios_ImgProd)
        Me.Cambios_Productos.Controls.Add(Me.Btn_Cambios_Eliminar_Prod)
        Me.Cambios_Productos.Controls.Add(Me.Btn_Cambios_Guardar_Prod)
        Me.Cambios_Productos.Controls.Add(Me.GroupBox7)
        Me.Cambios_Productos.Controls.Add(Me.GroupBox6)
        Me.Cambios_Productos.Location = New System.Drawing.Point(4, 25)
        Me.Cambios_Productos.Name = "Cambios_Productos"
        Me.Cambios_Productos.Size = New System.Drawing.Size(768, 352)
        Me.Cambios_Productos.TabIndex = 4
        Me.Cambios_Productos.Text = "Cambios de Productos"
        '
        'Btn_Cambios_SubirImg
        '
        Me.Btn_Cambios_SubirImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Cambios_SubirImg.Location = New System.Drawing.Point(578, 266)
        Me.Btn_Cambios_SubirImg.Name = "Btn_Cambios_SubirImg"
        Me.Btn_Cambios_SubirImg.Size = New System.Drawing.Size(125, 29)
        Me.Btn_Cambios_SubirImg.TabIndex = 20
        Me.Btn_Cambios_SubirImg.Text = "Cambiar Imagen"
        Me.Btn_Cambios_SubirImg.UseVisualStyleBackColor = False
        '
        'PiBo_Cambios_ImgProd
        '
        Me.PiBo_Cambios_ImgProd.BackColor = System.Drawing.Color.LightGray
        Me.PiBo_Cambios_ImgProd.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.No_Image
        Me.PiBo_Cambios_ImgProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PiBo_Cambios_ImgProd.Location = New System.Drawing.Point(550, 138)
        Me.PiBo_Cambios_ImgProd.Name = "PiBo_Cambios_ImgProd"
        Me.PiBo_Cambios_ImgProd.Size = New System.Drawing.Size(175, 120)
        Me.PiBo_Cambios_ImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PiBo_Cambios_ImgProd.TabIndex = 19
        Me.PiBo_Cambios_ImgProd.TabStop = False
        '
        'Btn_Cambios_Eliminar_Prod
        '
        Me.Btn_Cambios_Eliminar_Prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Cambios_Eliminar_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Cambios_Eliminar_Prod.Location = New System.Drawing.Point(519, 310)
        Me.Btn_Cambios_Eliminar_Prod.Name = "Btn_Cambios_Eliminar_Prod"
        Me.Btn_Cambios_Eliminar_Prod.Size = New System.Drawing.Size(78, 28)
        Me.Btn_Cambios_Eliminar_Prod.TabIndex = 16
        Me.Btn_Cambios_Eliminar_Prod.Text = "Limpiar"
        Me.Btn_Cambios_Eliminar_Prod.UseVisualStyleBackColor = False
        '
        'Btn_Cambios_Guardar_Prod
        '
        Me.Btn_Cambios_Guardar_Prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Cambios_Guardar_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Cambios_Guardar_Prod.Location = New System.Drawing.Point(619, 310)
        Me.Btn_Cambios_Guardar_Prod.Name = "Btn_Cambios_Guardar_Prod"
        Me.Btn_Cambios_Guardar_Prod.Size = New System.Drawing.Size(106, 28)
        Me.Btn_Cambios_Guardar_Prod.TabIndex = 15
        Me.Btn_Cambios_Guardar_Prod.Text = "Buscar"
        Me.Btn_Cambios_Guardar_Prod.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TtBo_Cambios_PrecPublicProd)
        Me.GroupBox7.Controls.Add(Me.TtBo_Cambios_PrecProvProd)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox7.Location = New System.Drawing.Point(484, 25)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(272, 98)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Datos de precio"
        '
        'TtBo_Cambios_PrecPublicProd
        '
        Me.TtBo_Cambios_PrecPublicProd.Location = New System.Drawing.Point(154, 55)
        Me.TtBo_Cambios_PrecPublicProd.Name = "TtBo_Cambios_PrecPublicProd"
        Me.TtBo_Cambios_PrecPublicProd.Size = New System.Drawing.Size(112, 23)
        Me.TtBo_Cambios_PrecPublicProd.TabIndex = 13
        '
        'TtBo_Cambios_PrecProvProd
        '
        Me.TtBo_Cambios_PrecProvProd.Location = New System.Drawing.Point(154, 25)
        Me.TtBo_Cambios_PrecProvProd.Name = "TtBo_Cambios_PrecProvProd"
        Me.TtBo_Cambios_PrecProvProd.Size = New System.Drawing.Size(112, 23)
        Me.TtBo_Cambios_PrecProvProd.TabIndex = 12
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 55)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(116, 17)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Precio al público:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 25)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(141, 17)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Precio de proveedor:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.CoBo_Cambios_ProvProd)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.CoBo_Cambios_ContenidoProd)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.TtBo_Cambios_NombreProd)
        Me.GroupBox6.Controls.Add(Me.DaTiPi_Cambios_FechaCaducaProd)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.RaBo_Cambios_NoCaducaProd)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.RaBo_Cambios_SiCaducaProd)
        Me.GroupBox6.Controls.Add(Me.TtBo_Cambios_DescProd)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.TtBo_Cambios_ContenidoProd)
        Me.GroupBox6.Controls.Add(Me.NuUpDo_Cambios_CantidadExistProd)
        Me.GroupBox6.Controls.Add(Me.CoBo_Cambios_CategoriasProd)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.TtBo_Cambios_CodBarraProd)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(454, 336)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos generales"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(18, 189)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 17)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Proveedor:"
        '
        'CoBo_Cambios_ProvProd
        '
        Me.CoBo_Cambios_ProvProd.FormattingEnabled = True
        Me.CoBo_Cambios_ProvProd.Location = New System.Drawing.Point(116, 189)
        Me.CoBo_Cambios_ProvProd.Name = "CoBo_Cambios_ProvProd"
        Me.CoBo_Cambios_ProvProd.Size = New System.Drawing.Size(182, 24)
        Me.CoBo_Cambios_ProvProd.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label23.Location = New System.Drawing.Point(18, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(114, 17)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Código de barra:"
        '
        'CoBo_Cambios_ContenidoProd
        '
        Me.CoBo_Cambios_ContenidoProd.FormattingEnabled = True
        Me.CoBo_Cambios_ContenidoProd.Items.AddRange(New Object() {"Ml", "L", "Kg", "Gr"})
        Me.CoBo_Cambios_ContenidoProd.Location = New System.Drawing.Point(227, 115)
        Me.CoBo_Cambios_ContenidoProd.Name = "CoBo_Cambios_ContenidoProd"
        Me.CoBo_Cambios_ContenidoProd.Size = New System.Drawing.Size(69, 24)
        Me.CoBo_Cambios_ContenidoProd.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label24.Location = New System.Drawing.Point(18, 61)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 17)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Nombre:"
        '
        'TtBo_Cambios_NombreProd
        '
        Me.TtBo_Cambios_NombreProd.Location = New System.Drawing.Point(114, 55)
        Me.TtBo_Cambios_NombreProd.MaxLength = 100
        Me.TtBo_Cambios_NombreProd.Name = "TtBo_Cambios_NombreProd"
        Me.TtBo_Cambios_NombreProd.Size = New System.Drawing.Size(182, 23)
        Me.TtBo_Cambios_NombreProd.TabIndex = 1
        '
        'DaTiPi_Cambios_FechaCaducaProd
        '
        Me.DaTiPi_Cambios_FechaCaducaProd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.DaTiPi_Cambios_FechaCaducaProd.Location = New System.Drawing.Point(210, 275)
        Me.DaTiPi_Cambios_FechaCaducaProd.MaxDate = New Date(2050, 1, 1, 0, 0, 0, 0)
        Me.DaTiPi_Cambios_FechaCaducaProd.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DaTiPi_Cambios_FechaCaducaProd.Name = "DaTiPi_Cambios_FechaCaducaProd"
        Me.DaTiPi_Cambios_FechaCaducaProd.Size = New System.Drawing.Size(238, 23)
        Me.DaTiPi_Cambios_FechaCaducaProd.TabIndex = 11
        Me.DaTiPi_Cambios_FechaCaducaProd.Value = New Date(2022, 1, 11, 0, 0, 0, 0)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label25.Location = New System.Drawing.Point(18, 90)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 17)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Descripción"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label26.Location = New System.Drawing.Point(23, 275)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(123, 17)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "¿Caundo caduca?"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label27.Location = New System.Drawing.Point(18, 122)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 17)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Peso o litros:"
        '
        'RaBo_Cambios_NoCaducaProd
        '
        Me.RaBo_Cambios_NoCaducaProd.AutoSize = True
        Me.RaBo_Cambios_NoCaducaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Cambios_NoCaducaProd.Location = New System.Drawing.Point(350, 248)
        Me.RaBo_Cambios_NoCaducaProd.Name = "RaBo_Cambios_NoCaducaProd"
        Me.RaBo_Cambios_NoCaducaProd.Size = New System.Drawing.Size(100, 21)
        Me.RaBo_Cambios_NoCaducaProd.TabIndex = 10
        Me.RaBo_Cambios_NoCaducaProd.TabStop = True
        Me.RaBo_Cambios_NoCaducaProd.Text = "No, Caduca"
        Me.RaBo_Cambios_NoCaducaProd.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label28.Location = New System.Drawing.Point(18, 159)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 17)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Categoria:"
        '
        'RaBo_Cambios_SiCaducaProd
        '
        Me.RaBo_Cambios_SiCaducaProd.AutoSize = True
        Me.RaBo_Cambios_SiCaducaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Cambios_SiCaducaProd.Location = New System.Drawing.Point(227, 248)
        Me.RaBo_Cambios_SiCaducaProd.Name = "RaBo_Cambios_SiCaducaProd"
        Me.RaBo_Cambios_SiCaducaProd.Size = New System.Drawing.Size(94, 21)
        Me.RaBo_Cambios_SiCaducaProd.TabIndex = 9
        Me.RaBo_Cambios_SiCaducaProd.TabStop = True
        Me.RaBo_Cambios_SiCaducaProd.Text = "Sí, Caduca"
        Me.RaBo_Cambios_SiCaducaProd.UseVisualStyleBackColor = True
        '
        'TtBo_Cambios_DescProd
        '
        Me.TtBo_Cambios_DescProd.Location = New System.Drawing.Point(114, 84)
        Me.TtBo_Cambios_DescProd.MaxLength = 120
        Me.TtBo_Cambios_DescProd.Name = "TtBo_Cambios_DescProd"
        Me.TtBo_Cambios_DescProd.Size = New System.Drawing.Size(182, 23)
        Me.TtBo_Cambios_DescProd.TabIndex = 2
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label29.Location = New System.Drawing.Point(25, 250)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(196, 17)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "¿Tienen fecha de caducidad?"
        '
        'TtBo_Cambios_ContenidoProd
        '
        Me.TtBo_Cambios_ContenidoProd.Location = New System.Drawing.Point(114, 116)
        Me.TtBo_Cambios_ContenidoProd.MaxLength = 3
        Me.TtBo_Cambios_ContenidoProd.Name = "TtBo_Cambios_ContenidoProd"
        Me.TtBo_Cambios_ContenidoProd.Size = New System.Drawing.Size(107, 23)
        Me.TtBo_Cambios_ContenidoProd.TabIndex = 3
        '
        'NuUpDo_Cambios_CantidadExistProd
        '
        Me.NuUpDo_Cambios_CantidadExistProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NuUpDo_Cambios_CantidadExistProd.Location = New System.Drawing.Point(176, 219)
        Me.NuUpDo_Cambios_CantidadExistProd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NuUpDo_Cambios_CantidadExistProd.Name = "NuUpDo_Cambios_CantidadExistProd"
        Me.NuUpDo_Cambios_CantidadExistProd.Size = New System.Drawing.Size(120, 23)
        Me.NuUpDo_Cambios_CantidadExistProd.TabIndex = 8
        Me.NuUpDo_Cambios_CantidadExistProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NuUpDo_Cambios_CantidadExistProd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CoBo_Cambios_CategoriasProd
        '
        Me.CoBo_Cambios_CategoriasProd.FormattingEnabled = True
        Me.CoBo_Cambios_CategoriasProd.Location = New System.Drawing.Point(114, 152)
        Me.CoBo_Cambios_CategoriasProd.Name = "CoBo_Cambios_CategoriasProd"
        Me.CoBo_Cambios_CategoriasProd.Size = New System.Drawing.Size(182, 24)
        Me.CoBo_Cambios_CategoriasProd.TabIndex = 5
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label30.Location = New System.Drawing.Point(18, 221)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(154, 17)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Cantidad en existencia:"
        '
        'TtBo_Cambios_CodBarraProd
        '
        Me.TtBo_Cambios_CodBarraProd.Location = New System.Drawing.Point(146, 26)
        Me.TtBo_Cambios_CodBarraProd.MaxLength = 15
        Me.TtBo_Cambios_CodBarraProd.Name = "TtBo_Cambios_CodBarraProd"
        Me.TtBo_Cambios_CodBarraProd.Size = New System.Drawing.Size(150, 23)
        Me.TtBo_Cambios_CodBarraProd.TabIndex = 7
        '
        'Form_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile1
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.Tab_ABCC_Productos)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_ABCC_Productos.ResumeLayout(False)
        Me.Alta_Productos.ResumeLayout(False)
        Me.GrBo_DG_Prod.ResumeLayout(False)
        Me.GrBo_DG_Prod.PerformLayout()
        CType(Me.NuUpDo_Alta_CantidadExistProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PiBo_Alta_ImgProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Consulta_Productos.ResumeLayout(False)
        CType(Me.DGVListProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Baja_Productos.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NuUpDo_Baja_CantidadExistProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Cambios_Productos.ResumeLayout(False)
        CType(Me.PiBo_Cambios_ImgProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.NuUpDo_Cambios_CantidadExistProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_atras As Button
    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ServiciosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Tab_ABCC_Productos As TabControl
    Friend WithEvents Consulta_Productos As TabPage
    Friend WithEvents Baja_Productos As TabPage
    Friend WithEvents Cambios_Productos As TabPage
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Alta_Productos As TabPage
    Friend WithEvents Btn_Alta_Guardar As Button
    Friend WithEvents DGVListProd As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_BuscarCodBarraProd As Button
    Friend WithEvents TtBo_Consulta_CodBarraProd As TextBox
    Friend WithEvents Lab_Consulta_CodBarra As Label
    Friend WithEvents Btn_Alta_LimpiarProd As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TtBo_Alta_PrecioPublicoProd As TextBox
    Friend WithEvents TtBo_Alta_PrecioProvProd As TextBox
    Friend WithEvents Lab_Alta_PrecioPublicoProd As Label
    Friend WithEvents Lab_Alta_PrecioProvProd As Label
    Friend WithEvents Btn_Alta_SubirImg As Button
    Friend WithEvents PiBo_Alta_ImgProd As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NuUpDo_Baja_CantidadExistProd As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TtBo_Baja_Dg_DescProd As TextBox
    Friend WithEvents TtBo_Baja_Dg_NombreProd As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TtBo_Baja_Dg_CodBarraProd As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Btn_Buscar_BajasProd As Button
    Friend WithEvents TtBo_Baja_CodBarraProd As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Btn_Baja_LimpiarProd As Button
    Friend WithEvents Btn_Baja_EliminarProd As Button
    Friend WithEvents TtBo_Baja_PrecioPublicProd As TextBox
    Friend WithEvents TtBo_Baja_PrecioProvProd As TextBox
    Friend WithEvents TtBo_Baja_ProvProd As TextBox
    Friend WithEvents CoBo_Baja_Dg_ContenidoProd As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TtBo_Baja_Dg_ContenidoProd As TextBox
    Friend WithEvents PiBo_Cambios_ImgProd As PictureBox
    Friend WithEvents Btn_Cambios_Eliminar_Prod As Button
    Friend WithEvents Btn_Cambios_Guardar_Prod As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TtBo_Cambios_PrecPublicProd As TextBox
    Friend WithEvents TtBo_Cambios_PrecProvProd As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CoBo_Cambios_ProvProd As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents CoBo_Cambios_ContenidoProd As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TtBo_Cambios_NombreProd As TextBox
    Friend WithEvents DaTiPi_Cambios_FechaCaducaProd As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents RaBo_Cambios_NoCaducaProd As RadioButton
    Friend WithEvents Label28 As Label
    Friend WithEvents RaBo_Cambios_SiCaducaProd As RadioButton
    Friend WithEvents TtBo_Cambios_DescProd As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TtBo_Cambios_ContenidoProd As TextBox
    Friend WithEvents NuUpDo_Cambios_CantidadExistProd As NumericUpDown
    Friend WithEvents CoBo_Cambios_CategoriasProd As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TtBo_Cambios_CodBarraProd As TextBox
    Friend WithEvents DGV_CodigoBarra_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Nombre_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Desc_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Fcaducidad_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_PrecioPub_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_PrecioProv_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_CantidadEx_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Cambios_SubirImg As Button
    Friend WithEvents GrBo_DG_Prod As GroupBox
    Friend WithEvents Lab_Alta_CodBarraProd As Label
    Friend WithEvents TtBo_Alta_CodBarraProd As TextBox
    Friend WithEvents Lab_Alta_ProvProd As Label
    Friend WithEvents CoBo_Alta_ProvProd As ComboBox
    Friend WithEvents CoBo_Alta_ContenidoProd As ComboBox
    Friend WithEvents Lab_Alta_NombProd As Label
    Friend WithEvents TtBo_Alta_NombProd As TextBox
    Friend WithEvents DaTiPi_Alta_FechaCaducaProd As DateTimePicker
    Friend WithEvents Lab_Alta_DescripProd As Label
    Friend WithEvents Lab_Alta_CuandoCaducaProd As Label
    Friend WithEvents Lab_Alta_CapacidadProd As Label
    Friend WithEvents RaBo_Alta_NoCaducaProd As RadioButton
    Friend WithEvents Lab_Alta_CatgProd As Label
    Friend WithEvents RaBo_Alta_SiCaducaProd As RadioButton
    Friend WithEvents TtBo_Alta_DescripProd As TextBox
    Friend WithEvents Lab_Alta_FechCadProd As Label
    Friend WithEvents TtBo_Alta_ContenidoProd As TextBox
    Friend WithEvents NuUpDo_Alta_CantidadExistProd As NumericUpDown
    Friend WithEvents CoBo_Alta_CategoriaProd As ComboBox
    Friend WithEvents Lab_Alta_CantExisProd As Label
    Friend WithEvents Btn_BuscarTodoProd As Button
End Class
