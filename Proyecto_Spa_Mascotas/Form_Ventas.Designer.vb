<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Ventas))
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorteDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGV_ListaProd = New System.Windows.Forms.DataGridView()
        Me.DGV_NumeroItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrBo_BusquedaProducto = New System.Windows.Forms.GroupBox()
        Me.CoBo_Bus_Unidad = New System.Windows.Forms.ComboBox()
        Me.Lab_Bus_Unidad = New System.Windows.Forms.Label()
        Me.CoBo_Bus_TipoCompra = New System.Windows.Forms.ComboBox()
        Me.Lab_Bus_TipoCompra = New System.Windows.Forms.Label()
        Me.Btn_Bus_Buscar = New System.Windows.Forms.Button()
        Me.Lab_Bus_NombProd = New System.Windows.Forms.Label()
        Me.Lab_Bus_CodBarra = New System.Windows.Forms.Label()
        Me.TtBo_Bus_CodBarra = New System.Windows.Forms.TextBox()
        Me.TtBo_Bus_NombProd = New System.Windows.Forms.TextBox()
        Me.Btn_ArPg_Pagar = New System.Windows.Forms.Button()
        Me.Lab_ArPg_SigDolar3 = New System.Windows.Forms.Label()
        Me.Lab_ArPg_SigDolar2 = New System.Windows.Forms.Label()
        Me.Lab_ArPg_SigDolar1 = New System.Windows.Forms.Label()
        Me.Lab_ArPg_Total = New System.Windows.Forms.Label()
        Me.Lab_ArPg_IVA = New System.Windows.Forms.Label()
        Me.Lab_ArPg_Subtatal = New System.Windows.Forms.Label()
        Me.GrBo_AreaPago = New System.Windows.Forms.GroupBox()
        Me.Lab_ArPg_EspTotal = New System.Windows.Forms.Label()
        Me.Lab_ArPg_EspIVA = New System.Windows.Forms.Label()
        Me.Lab_ArPg_EspSubtotal = New System.Windows.Forms.Label()
        Me.GrBo_AgregarProducto = New System.Windows.Forms.GroupBox()
        Me.Btn_Ag_Agregar = New System.Windows.Forms.Button()
        Me.NumUDo_CantProd = New System.Windows.Forms.NumericUpDown()
        Me.Lab_Ag_Cantidad = New System.Windows.Forms.Label()
        Me.TtBo_Ag_Precio = New System.Windows.Forms.TextBox()
        Me.Lab_Ag_Precio = New System.Windows.Forms.Label()
        Me.CoBo_Ag_Marca = New System.Windows.Forms.ComboBox()
        Me.Lab_Ag_Marca = New System.Windows.Forms.Label()
        Me.CoBo_Ag_NombProd = New System.Windows.Forms.ComboBox()
        Me.Lab_Ag_NombProd = New System.Windows.Forms.Label()
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal.SuspendLayout()
        CType(Me.DGV_ListaProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBo_BusquedaProducto.SuspendLayout()
        Me.GrBo_AreaPago.SuspendLayout()
        Me.GrBo_AgregarProducto.SuspendLayout()
        CType(Me.NumUDo_CantProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem, Me.CorteDeCajaToolStripMenuItem})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Size = New System.Drawing.Size(1314, 24)
        Me.MenuS_Principal.TabIndex = 0
        Me.MenuS_Principal.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.CaducosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'CaducosToolStripMenuItem
        '
        Me.CaducosToolStripMenuItem.Name = "CaducosToolStripMenuItem"
        Me.CaducosToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CaducosToolStripMenuItem.Text = "Caducos"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
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
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
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
        'CorteDeCajaToolStripMenuItem
        '
        Me.CorteDeCajaToolStripMenuItem.Name = "CorteDeCajaToolStripMenuItem"
        Me.CorteDeCajaToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CorteDeCajaToolStripMenuItem.Text = "Corte de caja"
        '
        'DGV_ListaProd
        '
        Me.DGV_ListaProd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_ListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ListaProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_NumeroItem, Me.DGV_Producto, Me.DGV_Precio, Me.DGV_Cantidad, Me.DGV_Subtotal})
        Me.DGV_ListaProd.Location = New System.Drawing.Point(12, 262)
        Me.DGV_ListaProd.Name = "DGV_ListaProd"
        Me.DGV_ListaProd.Size = New System.Drawing.Size(539, 407)
        Me.DGV_ListaProd.TabIndex = 0
        Me.DGV_ListaProd.TabStop = False
        '
        'DGV_NumeroItem
        '
        Me.DGV_NumeroItem.HeaderText = "N°"
        Me.DGV_NumeroItem.MaxInputLength = 2
        Me.DGV_NumeroItem.Name = "DGV_NumeroItem"
        '
        'DGV_Producto
        '
        Me.DGV_Producto.HeaderText = "Producto"
        Me.DGV_Producto.MaxInputLength = 100
        Me.DGV_Producto.Name = "DGV_Producto"
        '
        'DGV_Precio
        '
        Me.DGV_Precio.HeaderText = "Precio"
        Me.DGV_Precio.MaxInputLength = 5
        Me.DGV_Precio.Name = "DGV_Precio"
        '
        'DGV_Cantidad
        '
        Me.DGV_Cantidad.HeaderText = "Cantidad"
        Me.DGV_Cantidad.MaxInputLength = 3
        Me.DGV_Cantidad.Name = "DGV_Cantidad"
        '
        'DGV_Subtotal
        '
        Me.DGV_Subtotal.HeaderText = "Subtotal"
        Me.DGV_Subtotal.MaxInputLength = 5
        Me.DGV_Subtotal.Name = "DGV_Subtotal"
        '
        'GrBo_BusquedaProducto
        '
        Me.GrBo_BusquedaProducto.BackColor = System.Drawing.Color.Transparent
        Me.GrBo_BusquedaProducto.Controls.Add(Me.CoBo_Bus_Unidad)
        Me.GrBo_BusquedaProducto.Controls.Add(Me.Lab_Bus_Unidad)
        Me.GrBo_BusquedaProducto.Controls.Add(Me.CoBo_Bus_TipoCompra)
        Me.GrBo_BusquedaProducto.Controls.Add(Me.Lab_Bus_TipoCompra)
        Me.GrBo_BusquedaProducto.Controls.Add(Me.Btn_Bus_Buscar)
        Me.GrBo_BusquedaProducto.Controls.Add(Me.Lab_Bus_NombProd)
        Me.GrBo_BusquedaProducto.Controls.Add(Me.Lab_Bus_CodBarra)
        Me.GrBo_BusquedaProducto.Controls.Add(Me.TtBo_Bus_CodBarra)
        Me.GrBo_BusquedaProducto.Controls.Add(Me.TtBo_Bus_NombProd)
        Me.GrBo_BusquedaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrBo_BusquedaProducto.Location = New System.Drawing.Point(74, 54)
        Me.GrBo_BusquedaProducto.Name = "GrBo_BusquedaProducto"
        Me.GrBo_BusquedaProducto.Size = New System.Drawing.Size(373, 194)
        Me.GrBo_BusquedaProducto.TabIndex = 1
        Me.GrBo_BusquedaProducto.TabStop = False
        Me.GrBo_BusquedaProducto.Text = "Búsqueda de producto"
        '
        'CoBo_Bus_Unidad
        '
        Me.CoBo_Bus_Unidad.FormattingEnabled = True
        Me.CoBo_Bus_Unidad.Items.AddRange(New Object() {"Unidad", "Granel"})
        Me.CoBo_Bus_Unidad.Location = New System.Drawing.Point(194, 88)
        Me.CoBo_Bus_Unidad.Name = "CoBo_Bus_Unidad"
        Me.CoBo_Bus_Unidad.Size = New System.Drawing.Size(170, 24)
        Me.CoBo_Bus_Unidad.TabIndex = 3
        '
        'Lab_Bus_Unidad
        '
        Me.Lab_Bus_Unidad.AutoSize = True
        Me.Lab_Bus_Unidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_Bus_Unidad.Location = New System.Drawing.Point(26, 91)
        Me.Lab_Bus_Unidad.Name = "Lab_Bus_Unidad"
        Me.Lab_Bus_Unidad.Size = New System.Drawing.Size(122, 17)
        Me.Lab_Bus_Unidad.TabIndex = 8
        Me.Lab_Bus_Unidad.Text = "Tipo de unidad:"
        '
        'CoBo_Bus_TipoCompra
        '
        Me.CoBo_Bus_TipoCompra.FormattingEnabled = True
        Me.CoBo_Bus_TipoCompra.Items.AddRange(New Object() {"Producto", "Servicio"})
        Me.CoBo_Bus_TipoCompra.Location = New System.Drawing.Point(194, 28)
        Me.CoBo_Bus_TipoCompra.Name = "CoBo_Bus_TipoCompra"
        Me.CoBo_Bus_TipoCompra.Size = New System.Drawing.Size(170, 24)
        Me.CoBo_Bus_TipoCompra.TabIndex = 1
        '
        'Lab_Bus_TipoCompra
        '
        Me.Lab_Bus_TipoCompra.AutoSize = True
        Me.Lab_Bus_TipoCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_Bus_TipoCompra.Location = New System.Drawing.Point(26, 29)
        Me.Lab_Bus_TipoCompra.Name = "Lab_Bus_TipoCompra"
        Me.Lab_Bus_TipoCompra.Size = New System.Drawing.Size(126, 17)
        Me.Lab_Bus_TipoCompra.TabIndex = 6
        Me.Lab_Bus_TipoCompra.Text = "Tipo de compra:"
        '
        'Btn_Bus_Buscar
        '
        Me.Btn_Bus_Buscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_Bus_Buscar.Location = New System.Drawing.Point(194, 150)
        Me.Btn_Bus_Buscar.Name = "Btn_Bus_Buscar"
        Me.Btn_Bus_Buscar.Size = New System.Drawing.Size(170, 29)
        Me.Btn_Bus_Buscar.TabIndex = 5
        Me.Btn_Bus_Buscar.Text = "Buscar"
        Me.Btn_Bus_Buscar.UseVisualStyleBackColor = False
        '
        'Lab_Bus_NombProd
        '
        Me.Lab_Bus_NombProd.AutoSize = True
        Me.Lab_Bus_NombProd.BackColor = System.Drawing.Color.Transparent
        Me.Lab_Bus_NombProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_Bus_NombProd.Location = New System.Drawing.Point(26, 59)
        Me.Lab_Bus_NombProd.Name = "Lab_Bus_NombProd"
        Me.Lab_Bus_NombProd.Size = New System.Drawing.Size(165, 17)
        Me.Lab_Bus_NombProd.TabIndex = 4
        Me.Lab_Bus_NombProd.Text = "Nombre del producto:"
        '
        'Lab_Bus_CodBarra
        '
        Me.Lab_Bus_CodBarra.AutoSize = True
        Me.Lab_Bus_CodBarra.BackColor = System.Drawing.Color.Transparent
        Me.Lab_Bus_CodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_Bus_CodBarra.Location = New System.Drawing.Point(23, 124)
        Me.Lab_Bus_CodBarra.Name = "Lab_Bus_CodBarra"
        Me.Lab_Bus_CodBarra.Size = New System.Drawing.Size(130, 17)
        Me.Lab_Bus_CodBarra.TabIndex = 5
        Me.Lab_Bus_CodBarra.Text = "Código de barra:"
        '
        'TtBo_Bus_CodBarra
        '
        Me.TtBo_Bus_CodBarra.Location = New System.Drawing.Point(194, 118)
        Me.TtBo_Bus_CodBarra.MaxLength = 15
        Me.TtBo_Bus_CodBarra.Name = "TtBo_Bus_CodBarra"
        Me.TtBo_Bus_CodBarra.Size = New System.Drawing.Size(170, 23)
        Me.TtBo_Bus_CodBarra.TabIndex = 4
        Me.TtBo_Bus_CodBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Bus_NombProd
        '
        Me.TtBo_Bus_NombProd.Location = New System.Drawing.Point(194, 56)
        Me.TtBo_Bus_NombProd.MaxLength = 40
        Me.TtBo_Bus_NombProd.Name = "TtBo_Bus_NombProd"
        Me.TtBo_Bus_NombProd.Size = New System.Drawing.Size(170, 23)
        Me.TtBo_Bus_NombProd.TabIndex = 2
        Me.TtBo_Bus_NombProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_ArPg_Pagar
        '
        Me.Btn_ArPg_Pagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_ArPg_Pagar.Location = New System.Drawing.Point(38, 120)
        Me.Btn_ArPg_Pagar.Name = "Btn_ArPg_Pagar"
        Me.Btn_ArPg_Pagar.Size = New System.Drawing.Size(194, 27)
        Me.Btn_ArPg_Pagar.TabIndex = 12
        Me.Btn_ArPg_Pagar.Text = "Pagar"
        Me.Btn_ArPg_Pagar.UseVisualStyleBackColor = False
        '
        'Lab_ArPg_SigDolar3
        '
        Me.Lab_ArPg_SigDolar3.AutoSize = True
        Me.Lab_ArPg_SigDolar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_ArPg_SigDolar3.Location = New System.Drawing.Point(76, 96)
        Me.Lab_ArPg_SigDolar3.Name = "Lab_ArPg_SigDolar3"
        Me.Lab_ArPg_SigDolar3.Size = New System.Drawing.Size(16, 17)
        Me.Lab_ArPg_SigDolar3.TabIndex = 0
        Me.Lab_ArPg_SigDolar3.Text = "$"
        '
        'Lab_ArPg_SigDolar2
        '
        Me.Lab_ArPg_SigDolar2.AutoSize = True
        Me.Lab_ArPg_SigDolar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_ArPg_SigDolar2.Location = New System.Drawing.Point(76, 58)
        Me.Lab_ArPg_SigDolar2.Name = "Lab_ArPg_SigDolar2"
        Me.Lab_ArPg_SigDolar2.Size = New System.Drawing.Size(16, 17)
        Me.Lab_ArPg_SigDolar2.TabIndex = 0
        Me.Lab_ArPg_SigDolar2.Text = "$"
        '
        'Lab_ArPg_SigDolar1
        '
        Me.Lab_ArPg_SigDolar1.AutoSize = True
        Me.Lab_ArPg_SigDolar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_ArPg_SigDolar1.Location = New System.Drawing.Point(76, 27)
        Me.Lab_ArPg_SigDolar1.Name = "Lab_ArPg_SigDolar1"
        Me.Lab_ArPg_SigDolar1.Size = New System.Drawing.Size(16, 17)
        Me.Lab_ArPg_SigDolar1.TabIndex = 0
        Me.Lab_ArPg_SigDolar1.Text = "$"
        '
        'Lab_ArPg_Total
        '
        Me.Lab_ArPg_Total.AutoSize = True
        Me.Lab_ArPg_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_ArPg_Total.Location = New System.Drawing.Point(6, 96)
        Me.Lab_ArPg_Total.Name = "Lab_ArPg_Total"
        Me.Lab_ArPg_Total.Size = New System.Drawing.Size(44, 17)
        Me.Lab_ArPg_Total.TabIndex = 0
        Me.Lab_ArPg_Total.Text = "Total:"
        '
        'Lab_ArPg_IVA
        '
        Me.Lab_ArPg_IVA.AutoSize = True
        Me.Lab_ArPg_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_ArPg_IVA.Location = New System.Drawing.Point(6, 58)
        Me.Lab_ArPg_IVA.Name = "Lab_ArPg_IVA"
        Me.Lab_ArPg_IVA.Size = New System.Drawing.Size(33, 17)
        Me.Lab_ArPg_IVA.TabIndex = 0
        Me.Lab_ArPg_IVA.Text = "IVA:"
        '
        'Lab_ArPg_Subtatal
        '
        Me.Lab_ArPg_Subtatal.AutoSize = True
        Me.Lab_ArPg_Subtatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_ArPg_Subtatal.Location = New System.Drawing.Point(6, 27)
        Me.Lab_ArPg_Subtatal.Name = "Lab_ArPg_Subtatal"
        Me.Lab_ArPg_Subtatal.Size = New System.Drawing.Size(64, 17)
        Me.Lab_ArPg_Subtatal.TabIndex = 0
        Me.Lab_ArPg_Subtatal.Text = "Subtotal:"
        '
        'GrBo_AreaPago
        '
        Me.GrBo_AreaPago.BackColor = System.Drawing.Color.Transparent
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_EspTotal)
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_EspIVA)
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_EspSubtotal)
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_Subtatal)
        Me.GrBo_AreaPago.Controls.Add(Me.Btn_ArPg_Pagar)
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_SigDolar1)
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_SigDolar3)
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_IVA)
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_Total)
        Me.GrBo_AreaPago.Controls.Add(Me.Lab_ArPg_SigDolar2)
        Me.GrBo_AreaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrBo_AreaPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GrBo_AreaPago.Location = New System.Drawing.Point(667, 262)
        Me.GrBo_AreaPago.Name = "GrBo_AreaPago"
        Me.GrBo_AreaPago.Size = New System.Drawing.Size(248, 184)
        Me.GrBo_AreaPago.TabIndex = 0
        Me.GrBo_AreaPago.TabStop = False
        Me.GrBo_AreaPago.Text = "Área de pago"
        '
        'Lab_ArPg_EspTotal
        '
        Me.Lab_ArPg_EspTotal.AutoSize = True
        Me.Lab_ArPg_EspTotal.Location = New System.Drawing.Point(111, 100)
        Me.Lab_ArPg_EspTotal.Name = "Lab_ArPg_EspTotal"
        Me.Lab_ArPg_EspTotal.Size = New System.Drawing.Size(0, 17)
        Me.Lab_ArPg_EspTotal.TabIndex = 12
        '
        'Lab_ArPg_EspIVA
        '
        Me.Lab_ArPg_EspIVA.AutoSize = True
        Me.Lab_ArPg_EspIVA.Location = New System.Drawing.Point(111, 60)
        Me.Lab_ArPg_EspIVA.Name = "Lab_ArPg_EspIVA"
        Me.Lab_ArPg_EspIVA.Size = New System.Drawing.Size(0, 17)
        Me.Lab_ArPg_EspIVA.TabIndex = 11
        '
        'Lab_ArPg_EspSubtotal
        '
        Me.Lab_ArPg_EspSubtotal.AutoSize = True
        Me.Lab_ArPg_EspSubtotal.Location = New System.Drawing.Point(111, 29)
        Me.Lab_ArPg_EspSubtotal.Name = "Lab_ArPg_EspSubtotal"
        Me.Lab_ArPg_EspSubtotal.Size = New System.Drawing.Size(0, 17)
        Me.Lab_ArPg_EspSubtotal.TabIndex = 10
        '
        'GrBo_AgregarProducto
        '
        Me.GrBo_AgregarProducto.BackColor = System.Drawing.Color.Transparent
        Me.GrBo_AgregarProducto.Controls.Add(Me.Btn_Ag_Agregar)
        Me.GrBo_AgregarProducto.Controls.Add(Me.NumUDo_CantProd)
        Me.GrBo_AgregarProducto.Controls.Add(Me.Lab_Ag_Cantidad)
        Me.GrBo_AgregarProducto.Controls.Add(Me.TtBo_Ag_Precio)
        Me.GrBo_AgregarProducto.Controls.Add(Me.Lab_Ag_Precio)
        Me.GrBo_AgregarProducto.Controls.Add(Me.CoBo_Ag_Marca)
        Me.GrBo_AgregarProducto.Controls.Add(Me.Lab_Ag_Marca)
        Me.GrBo_AgregarProducto.Controls.Add(Me.CoBo_Ag_NombProd)
        Me.GrBo_AgregarProducto.Controls.Add(Me.Lab_Ag_NombProd)
        Me.GrBo_AgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrBo_AgregarProducto.Location = New System.Drawing.Point(506, 54)
        Me.GrBo_AgregarProducto.Name = "GrBo_AgregarProducto"
        Me.GrBo_AgregarProducto.Size = New System.Drawing.Size(409, 194)
        Me.GrBo_AgregarProducto.TabIndex = 0
        Me.GrBo_AgregarProducto.TabStop = False
        Me.GrBo_AgregarProducto.Text = "Área de agregar producto"
        '
        'Btn_Ag_Agregar
        '
        Me.Btn_Ag_Agregar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_Ag_Agregar.Location = New System.Drawing.Point(199, 133)
        Me.Btn_Ag_Agregar.Name = "Btn_Ag_Agregar"
        Me.Btn_Ag_Agregar.Size = New System.Drawing.Size(194, 27)
        Me.Btn_Ag_Agregar.TabIndex = 10
        Me.Btn_Ag_Agregar.Text = "Agregar"
        Me.Btn_Ag_Agregar.UseVisualStyleBackColor = False
        '
        'NumUDo_CantProd
        '
        Me.NumUDo_CantProd.DecimalPlaces = 3
        Me.NumUDo_CantProd.Increment = New Decimal(New Integer() {50, 0, 0, 196608})
        Me.NumUDo_CantProd.Location = New System.Drawing.Point(199, 104)
        Me.NumUDo_CantProd.Name = "NumUDo_CantProd"
        Me.NumUDo_CantProd.Size = New System.Drawing.Size(194, 23)
        Me.NumUDo_CantProd.TabIndex = 9
        Me.NumUDo_CantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumUDo_CantProd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Lab_Ag_Cantidad
        '
        Me.Lab_Ag_Cantidad.AutoSize = True
        Me.Lab_Ag_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_Ag_Cantidad.Location = New System.Drawing.Point(12, 102)
        Me.Lab_Ag_Cantidad.Name = "Lab_Ag_Cantidad"
        Me.Lab_Ag_Cantidad.Size = New System.Drawing.Size(77, 17)
        Me.Lab_Ag_Cantidad.TabIndex = 9
        Me.Lab_Ag_Cantidad.Text = "Cantidad:"
        '
        'TtBo_Ag_Precio
        '
        Me.TtBo_Ag_Precio.Location = New System.Drawing.Point(199, 75)
        Me.TtBo_Ag_Precio.MaxLength = 5
        Me.TtBo_Ag_Precio.Name = "TtBo_Ag_Precio"
        Me.TtBo_Ag_Precio.Size = New System.Drawing.Size(194, 23)
        Me.TtBo_Ag_Precio.TabIndex = 8
        Me.TtBo_Ag_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Ag_Precio
        '
        Me.Lab_Ag_Precio.AutoSize = True
        Me.Lab_Ag_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_Ag_Precio.Location = New System.Drawing.Point(12, 75)
        Me.Lab_Ag_Precio.Name = "Lab_Ag_Precio"
        Me.Lab_Ag_Precio.Size = New System.Drawing.Size(59, 17)
        Me.Lab_Ag_Precio.TabIndex = 10
        Me.Lab_Ag_Precio.Text = "Precio:"
        '
        'CoBo_Ag_Marca
        '
        Me.CoBo_Ag_Marca.FormattingEnabled = True
        Me.CoBo_Ag_Marca.Location = New System.Drawing.Point(199, 48)
        Me.CoBo_Ag_Marca.MaxLength = 40
        Me.CoBo_Ag_Marca.Name = "CoBo_Ag_Marca"
        Me.CoBo_Ag_Marca.Size = New System.Drawing.Size(194, 24)
        Me.CoBo_Ag_Marca.TabIndex = 7
        '
        'Lab_Ag_Marca
        '
        Me.Lab_Ag_Marca.AutoSize = True
        Me.Lab_Ag_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_Ag_Marca.Location = New System.Drawing.Point(13, 48)
        Me.Lab_Ag_Marca.Name = "Lab_Ag_Marca"
        Me.Lab_Ag_Marca.Size = New System.Drawing.Size(57, 17)
        Me.Lab_Ag_Marca.TabIndex = 11
        Me.Lab_Ag_Marca.Text = "Marca:"
        '
        'CoBo_Ag_NombProd
        '
        Me.CoBo_Ag_NombProd.FormattingEnabled = True
        Me.CoBo_Ag_NombProd.Location = New System.Drawing.Point(199, 19)
        Me.CoBo_Ag_NombProd.MaxLength = 40
        Me.CoBo_Ag_NombProd.Name = "CoBo_Ag_NombProd"
        Me.CoBo_Ag_NombProd.Size = New System.Drawing.Size(194, 24)
        Me.CoBo_Ag_NombProd.TabIndex = 6
        '
        'Lab_Ag_NombProd
        '
        Me.Lab_Ag_NombProd.AutoSize = True
        Me.Lab_Ag_NombProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_Ag_NombProd.Location = New System.Drawing.Point(13, 22)
        Me.Lab_Ag_NombProd.Name = "Lab_Ag_NombProd"
        Me.Lab_Ag_NombProd.Size = New System.Drawing.Size(165, 17)
        Me.Lab_Ag_NombProd.TabIndex = 12
        Me.Lab_Ag_NombProd.Text = "Nombre del producto:"
        '
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(12, 27)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(75, 23)
        Me.Btn_atras.TabIndex = 2
        Me.Btn_atras.TabStop = False
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'Form_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile
        Me.ClientSize = New System.Drawing.Size(1314, 681)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.GrBo_AgregarProducto)
        Me.Controls.Add(Me.GrBo_AreaPago)
        Me.Controls.Add(Me.GrBo_BusquedaProducto)
        Me.Controls.Add(Me.DGV_ListaProd)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuS_Principal
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        CType(Me.DGV_ListaProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBo_BusquedaProducto.ResumeLayout(False)
        Me.GrBo_BusquedaProducto.PerformLayout()
        Me.GrBo_AreaPago.ResumeLayout(False)
        Me.GrBo_AreaPago.PerformLayout()
        Me.GrBo_AgregarProducto.ResumeLayout(False)
        Me.GrBo_AgregarProducto.PerformLayout()
        CType(Me.NumUDo_CantProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DGV_ListaProd As DataGridView
    Friend WithEvents GrBo_BusquedaProducto As GroupBox
    Friend WithEvents DGV_NumeroItem As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Precio As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Btn_ArPg_Pagar As Button
    Friend WithEvents Lab_ArPg_SigDolar3 As Label
    Friend WithEvents Lab_ArPg_SigDolar2 As Label
    Friend WithEvents Lab_ArPg_SigDolar1 As Label
    Friend WithEvents Lab_ArPg_Total As Label
    Friend WithEvents Lab_ArPg_IVA As Label
    Friend WithEvents Lab_ArPg_Subtatal As Label
    Friend WithEvents GrBo_AreaPago As GroupBox
    Friend WithEvents GrBo_AgregarProducto As GroupBox
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorteDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Bus_Buscar As Button
    Friend WithEvents Lab_Bus_NombProd As Label
    Friend WithEvents Lab_Bus_CodBarra As Label
    Friend WithEvents TtBo_Bus_CodBarra As TextBox
    Friend WithEvents TtBo_Bus_NombProd As TextBox
    Friend WithEvents Btn_Ag_Agregar As Button
    Friend WithEvents NumUDo_CantProd As NumericUpDown
    Friend WithEvents Lab_Ag_Cantidad As Label
    Friend WithEvents TtBo_Ag_Precio As TextBox
    Friend WithEvents Lab_Ag_Precio As Label
    Friend WithEvents CoBo_Ag_Marca As ComboBox
    Friend WithEvents Lab_Ag_Marca As Label
    Friend WithEvents CoBo_Ag_NombProd As ComboBox
    Friend WithEvents Lab_Ag_NombProd As Label
    Friend WithEvents Lab_ArPg_EspTotal As Label
    Friend WithEvents Lab_ArPg_EspIVA As Label
    Friend WithEvents Lab_ArPg_EspSubtotal As Label
    Friend WithEvents Btn_atras As Button
    Friend WithEvents CoBo_Bus_TipoCompra As ComboBox
    Friend WithEvents Lab_Bus_TipoCompra As Label
    Friend WithEvents CoBo_Bus_Unidad As ComboBox
    Friend WithEvents Lab_Bus_Unidad As Label
End Class
