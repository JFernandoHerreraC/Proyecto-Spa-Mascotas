<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Servicios
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
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.Tab_Ctr_Servicio = New System.Windows.Forms.TabControl()
        Me.Alta_Servicio = New System.Windows.Forms.TabPage()
        Me.Btn_Alta_LimpiarProd = New System.Windows.Forms.Button()
        Me.Btn_Alta_GuardarProd = New System.Windows.Forms.Button()
        Me.TtBo_Alta_PrecioServicio = New System.Windows.Forms.MaskedTextBox()
        Me.TtBo_Alta_DescripServicio = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NombServicio = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_DescripServicio = New System.Windows.Forms.Label()
        Me.Lab_Alta_PrecioServicio = New System.Windows.Forms.Label()
        Me.Lab_Alta_NombServicio = New System.Windows.Forms.Label()
        Me.Consulta_Servicio = New System.Windows.Forms.TabPage()
        Me.Btn_Consulta_BuscarTodo = New System.Windows.Forms.Button()
        Me.DGV_ListaServicio = New System.Windows.Forms.DataGridView()
        Me.DVG_ID_Serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Nom_Serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Precio_Serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Descrip_Serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Consulta_Buscar = New System.Windows.Forms.Button()
        Me.TtBo_Consulta_NombServicio = New System.Windows.Forms.TextBox()
        Me.Lab_Consulta_NombServicio = New System.Windows.Forms.Label()
        Me.Cambio_Servicio = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Cambios_Guardar = New System.Windows.Forms.Button()
        Me.TtBo_Cambios_PrecioServicio = New System.Windows.Forms.MaskedTextBox()
        Me.TtBo_Cambios_DescripServicio = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_NombServicio = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_DescripServicio = New System.Windows.Forms.Label()
        Me.Lab_Cambios_PrecioServicio = New System.Windows.Forms.Label()
        Me.Lab_Cambios_NombServicio = New System.Windows.Forms.Label()
        Me.Baja_Servicio = New System.Windows.Forms.TabPage()
        Me.Btn_Bajas_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Bajas_Buscar = New System.Windows.Forms.Button()
        Me.TtBo_Bajas_PrecioServicio = New System.Windows.Forms.MaskedTextBox()
        Me.TtBo_Bajas_DescripServicio = New System.Windows.Forms.TextBox()
        Me.TtBo_Bajas_NombServicio = New System.Windows.Forms.TextBox()
        Me.Lab_Bajas_DescripServicio = New System.Windows.Forms.Label()
        Me.Lab_Bajas_PrecioServicio = New System.Windows.Forms.Label()
        Me.Lab_Bajas_NombServicio = New System.Windows.Forms.Label()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_Servicio.SuspendLayout()
        Me.Alta_Servicio.SuspendLayout()
        Me.Consulta_Servicio.SuspendLayout()
        CType(Me.DGV_ListaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cambio_Servicio.SuspendLayout()
        Me.Baja_Servicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Size = New System.Drawing.Size(800, 24)
        Me.MenuS_Principal.TabIndex = 1
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
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
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
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(12, 27)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(75, 23)
        Me.Btn_atras.TabIndex = 2
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'Tab_Ctr_Servicio
        '
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Alta_Servicio)
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Consulta_Servicio)
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Cambio_Servicio)
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Baja_Servicio)
        Me.Tab_Ctr_Servicio.Location = New System.Drawing.Point(12, 56)
        Me.Tab_Ctr_Servicio.Name = "Tab_Ctr_Servicio"
        Me.Tab_Ctr_Servicio.SelectedIndex = 0
        Me.Tab_Ctr_Servicio.Size = New System.Drawing.Size(776, 382)
        Me.Tab_Ctr_Servicio.TabIndex = 3
        '
        'Alta_Servicio
        '
        Me.Alta_Servicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_Servicio.Controls.Add(Me.Btn_Alta_LimpiarProd)
        Me.Alta_Servicio.Controls.Add(Me.Btn_Alta_GuardarProd)
        Me.Alta_Servicio.Controls.Add(Me.TtBo_Alta_PrecioServicio)
        Me.Alta_Servicio.Controls.Add(Me.TtBo_Alta_DescripServicio)
        Me.Alta_Servicio.Controls.Add(Me.TtBo_Alta_NombServicio)
        Me.Alta_Servicio.Controls.Add(Me.Lab_Alta_DescripServicio)
        Me.Alta_Servicio.Controls.Add(Me.Lab_Alta_PrecioServicio)
        Me.Alta_Servicio.Controls.Add(Me.Lab_Alta_NombServicio)
        Me.Alta_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Alta_Servicio.Name = "Alta_Servicio"
        Me.Alta_Servicio.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Alta_Servicio.TabIndex = 0
        Me.Alta_Servicio.Text = "Alta de Servicios"
        '
        'Btn_Alta_LimpiarProd
        '
        Me.Btn_Alta_LimpiarProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Alta_LimpiarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Alta_LimpiarProd.Location = New System.Drawing.Point(358, 202)
        Me.Btn_Alta_LimpiarProd.Name = "Btn_Alta_LimpiarProd"
        Me.Btn_Alta_LimpiarProd.Size = New System.Drawing.Size(75, 25)
        Me.Btn_Alta_LimpiarProd.TabIndex = 7
        Me.Btn_Alta_LimpiarProd.Text = "Limpiar"
        Me.Btn_Alta_LimpiarProd.UseVisualStyleBackColor = False
        '
        'Btn_Alta_GuardarProd
        '
        Me.Btn_Alta_GuardarProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Alta_GuardarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Alta_GuardarProd.Location = New System.Drawing.Point(439, 202)
        Me.Btn_Alta_GuardarProd.Name = "Btn_Alta_GuardarProd"
        Me.Btn_Alta_GuardarProd.Size = New System.Drawing.Size(98, 25)
        Me.Btn_Alta_GuardarProd.TabIndex = 6
        Me.Btn_Alta_GuardarProd.Text = "Guardar"
        Me.Btn_Alta_GuardarProd.UseVisualStyleBackColor = False
        '
        'TtBo_Alta_PrecioServicio
        '
        Me.TtBo_Alta_PrecioServicio.Location = New System.Drawing.Point(360, 136)
        Me.TtBo_Alta_PrecioServicio.Mask = "9999.99"
        Me.TtBo_Alta_PrecioServicio.Name = "TtBo_Alta_PrecioServicio"
        Me.TtBo_Alta_PrecioServicio.Size = New System.Drawing.Size(179, 20)
        Me.TtBo_Alta_PrecioServicio.TabIndex = 5
        Me.TtBo_Alta_PrecioServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Alta_DescripServicio
        '
        Me.TtBo_Alta_DescripServicio.Location = New System.Drawing.Point(358, 176)
        Me.TtBo_Alta_DescripServicio.MaxLength = 120
        Me.TtBo_Alta_DescripServicio.Name = "TtBo_Alta_DescripServicio"
        Me.TtBo_Alta_DescripServicio.Size = New System.Drawing.Size(179, 20)
        Me.TtBo_Alta_DescripServicio.TabIndex = 4
        '
        'TtBo_Alta_NombServicio
        '
        Me.TtBo_Alta_NombServicio.Location = New System.Drawing.Point(358, 90)
        Me.TtBo_Alta_NombServicio.MaxLength = 50
        Me.TtBo_Alta_NombServicio.Name = "TtBo_Alta_NombServicio"
        Me.TtBo_Alta_NombServicio.Size = New System.Drawing.Size(179, 20)
        Me.TtBo_Alta_NombServicio.TabIndex = 3
        Me.TtBo_Alta_NombServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_DescripServicio
        '
        Me.Lab_Alta_DescripServicio.AutoSize = True
        Me.Lab_Alta_DescripServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_DescripServicio.Location = New System.Drawing.Point(191, 179)
        Me.Lab_Alta_DescripServicio.Name = "Lab_Alta_DescripServicio"
        Me.Lab_Alta_DescripServicio.Size = New System.Drawing.Size(161, 17)
        Me.Lab_Alta_DescripServicio.TabIndex = 2
        Me.Lab_Alta_DescripServicio.Text = "Descripción del servicio:"
        '
        'Lab_Alta_PrecioServicio
        '
        Me.Lab_Alta_PrecioServicio.AutoSize = True
        Me.Lab_Alta_PrecioServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_PrecioServicio.Location = New System.Drawing.Point(191, 139)
        Me.Lab_Alta_PrecioServicio.Name = "Lab_Alta_PrecioServicio"
        Me.Lab_Alta_PrecioServicio.Size = New System.Drawing.Size(127, 17)
        Me.Lab_Alta_PrecioServicio.TabIndex = 1
        Me.Lab_Alta_PrecioServicio.Text = "Precio del servicio:"
        '
        'Lab_Alta_NombServicio
        '
        Me.Lab_Alta_NombServicio.AutoSize = True
        Me.Lab_Alta_NombServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NombServicio.Location = New System.Drawing.Point(191, 93)
        Me.Lab_Alta_NombServicio.Name = "Lab_Alta_NombServicio"
        Me.Lab_Alta_NombServicio.Size = New System.Drawing.Size(137, 17)
        Me.Lab_Alta_NombServicio.TabIndex = 0
        Me.Lab_Alta_NombServicio.Text = "Nombre del servicio:"
        '
        'Consulta_Servicio
        '
        Me.Consulta_Servicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_Servicio.Controls.Add(Me.Btn_Consulta_BuscarTodo)
        Me.Consulta_Servicio.Controls.Add(Me.DGV_ListaServicio)
        Me.Consulta_Servicio.Controls.Add(Me.Btn_Consulta_Buscar)
        Me.Consulta_Servicio.Controls.Add(Me.TtBo_Consulta_NombServicio)
        Me.Consulta_Servicio.Controls.Add(Me.Lab_Consulta_NombServicio)
        Me.Consulta_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Consulta_Servicio.Name = "Consulta_Servicio"
        Me.Consulta_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Consulta_Servicio.TabIndex = 2
        Me.Consulta_Servicio.Text = "Consulta de Servicios"
        '
        'Btn_Consulta_BuscarTodo
        '
        Me.Btn_Consulta_BuscarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Consulta_BuscarTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Consulta_BuscarTodo.Location = New System.Drawing.Point(464, 78)
        Me.Btn_Consulta_BuscarTodo.Name = "Btn_Consulta_BuscarTodo"
        Me.Btn_Consulta_BuscarTodo.Size = New System.Drawing.Size(119, 25)
        Me.Btn_Consulta_BuscarTodo.TabIndex = 8
        Me.Btn_Consulta_BuscarTodo.Text = "Buscar todos"
        Me.Btn_Consulta_BuscarTodo.UseVisualStyleBackColor = False
        '
        'DGV_ListaServicio
        '
        Me.DGV_ListaServicio.BackgroundColor = System.Drawing.Color.White
        Me.DGV_ListaServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ListaServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DVG_ID_Serv, Me.DVG_Nom_Serv, Me.DVG_Precio_Serv, Me.DVG_Descrip_Serv})
        Me.DGV_ListaServicio.Location = New System.Drawing.Point(231, 109)
        Me.DGV_ListaServicio.Name = "DGV_ListaServicio"
        Me.DGV_ListaServicio.Size = New System.Drawing.Size(443, 214)
        Me.DGV_ListaServicio.TabIndex = 7
        '
        'DVG_ID_Serv
        '
        Me.DVG_ID_Serv.HeaderText = "ID"
        Me.DVG_ID_Serv.MaxInputLength = 3
        Me.DVG_ID_Serv.Name = "DVG_ID_Serv"
        '
        'DVG_Nom_Serv
        '
        Me.DVG_Nom_Serv.HeaderText = "Nombre"
        Me.DVG_Nom_Serv.MaxInputLength = 50
        Me.DVG_Nom_Serv.Name = "DVG_Nom_Serv"
        '
        'DVG_Precio_Serv
        '
        Me.DVG_Precio_Serv.HeaderText = "Precio"
        Me.DVG_Precio_Serv.MaxInputLength = 5
        Me.DVG_Precio_Serv.Name = "DVG_Precio_Serv"
        '
        'DVG_Descrip_Serv
        '
        Me.DVG_Descrip_Serv.HeaderText = "Descripción"
        Me.DVG_Descrip_Serv.MaxInputLength = 120
        Me.DVG_Descrip_Serv.Name = "DVG_Descrip_Serv"
        '
        'Btn_Consulta_Buscar
        '
        Me.Btn_Consulta_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Consulta_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Consulta_Buscar.Location = New System.Drawing.Point(329, 78)
        Me.Btn_Consulta_Buscar.Name = "Btn_Consulta_Buscar"
        Me.Btn_Consulta_Buscar.Size = New System.Drawing.Size(119, 25)
        Me.Btn_Consulta_Buscar.TabIndex = 6
        Me.Btn_Consulta_Buscar.Text = "Buscar"
        Me.Btn_Consulta_Buscar.UseVisualStyleBackColor = False
        '
        'TtBo_Consulta_NombServicio
        '
        Me.TtBo_Consulta_NombServicio.Location = New System.Drawing.Point(416, 35)
        Me.TtBo_Consulta_NombServicio.MaxLength = 50
        Me.TtBo_Consulta_NombServicio.Name = "TtBo_Consulta_NombServicio"
        Me.TtBo_Consulta_NombServicio.Size = New System.Drawing.Size(167, 20)
        Me.TtBo_Consulta_NombServicio.TabIndex = 5
        '
        'Lab_Consulta_NombServicio
        '
        Me.Lab_Consulta_NombServicio.AutoSize = True
        Me.Lab_Consulta_NombServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Consulta_NombServicio.Location = New System.Drawing.Point(262, 35)
        Me.Lab_Consulta_NombServicio.Name = "Lab_Consulta_NombServicio"
        Me.Lab_Consulta_NombServicio.Size = New System.Drawing.Size(137, 17)
        Me.Lab_Consulta_NombServicio.TabIndex = 4
        Me.Lab_Consulta_NombServicio.Text = "Nombre del servicio:"
        '
        'Cambio_Servicio
        '
        Me.Cambio_Servicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cambio_Servicio.Controls.Add(Me.Button5)
        Me.Cambio_Servicio.Controls.Add(Me.Btn_Cambios_Guardar)
        Me.Cambio_Servicio.Controls.Add(Me.TtBo_Cambios_PrecioServicio)
        Me.Cambio_Servicio.Controls.Add(Me.TtBo_Cambios_DescripServicio)
        Me.Cambio_Servicio.Controls.Add(Me.TtBo_Cambios_NombServicio)
        Me.Cambio_Servicio.Controls.Add(Me.Lab_Cambios_DescripServicio)
        Me.Cambio_Servicio.Controls.Add(Me.Lab_Cambios_PrecioServicio)
        Me.Cambio_Servicio.Controls.Add(Me.Lab_Cambios_NombServicio)
        Me.Cambio_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Cambio_Servicio.Name = "Cambio_Servicio"
        Me.Cambio_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Cambio_Servicio.TabIndex = 3
        Me.Cambio_Servicio.Text = "Cambios en el  servicios"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button5.Location = New System.Drawing.Point(375, 185)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 25)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Limpiar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Btn_Cambios_Guardar
        '
        Me.Btn_Cambios_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Cambios_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Cambios_Guardar.Location = New System.Drawing.Point(454, 185)
        Me.Btn_Cambios_Guardar.Name = "Btn_Cambios_Guardar"
        Me.Btn_Cambios_Guardar.Size = New System.Drawing.Size(100, 25)
        Me.Btn_Cambios_Guardar.TabIndex = 14
        Me.Btn_Cambios_Guardar.Text = "Buscar"
        Me.Btn_Cambios_Guardar.UseVisualStyleBackColor = False
        '
        'TtBo_Cambios_PrecioServicio
        '
        Me.TtBo_Cambios_PrecioServicio.Location = New System.Drawing.Point(375, 105)
        Me.TtBo_Cambios_PrecioServicio.Mask = "9999.99"
        Me.TtBo_Cambios_PrecioServicio.Name = "TtBo_Cambios_PrecioServicio"
        Me.TtBo_Cambios_PrecioServicio.ReadOnly = True
        Me.TtBo_Cambios_PrecioServicio.Size = New System.Drawing.Size(179, 20)
        Me.TtBo_Cambios_PrecioServicio.TabIndex = 13
        Me.TtBo_Cambios_PrecioServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_DescripServicio
        '
        Me.TtBo_Cambios_DescripServicio.Location = New System.Drawing.Point(375, 150)
        Me.TtBo_Cambios_DescripServicio.MaxLength = 120
        Me.TtBo_Cambios_DescripServicio.Name = "TtBo_Cambios_DescripServicio"
        Me.TtBo_Cambios_DescripServicio.ReadOnly = True
        Me.TtBo_Cambios_DescripServicio.Size = New System.Drawing.Size(179, 20)
        Me.TtBo_Cambios_DescripServicio.TabIndex = 12
        Me.TtBo_Cambios_DescripServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_NombServicio
        '
        Me.TtBo_Cambios_NombServicio.Location = New System.Drawing.Point(375, 59)
        Me.TtBo_Cambios_NombServicio.MaxLength = 50
        Me.TtBo_Cambios_NombServicio.Name = "TtBo_Cambios_NombServicio"
        Me.TtBo_Cambios_NombServicio.Size = New System.Drawing.Size(179, 20)
        Me.TtBo_Cambios_NombServicio.TabIndex = 11
        Me.TtBo_Cambios_NombServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Cambios_DescripServicio
        '
        Me.Lab_Cambios_DescripServicio.AutoSize = True
        Me.Lab_Cambios_DescripServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_DescripServicio.Location = New System.Drawing.Point(197, 153)
        Me.Lab_Cambios_DescripServicio.Name = "Lab_Cambios_DescripServicio"
        Me.Lab_Cambios_DescripServicio.Size = New System.Drawing.Size(161, 17)
        Me.Lab_Cambios_DescripServicio.TabIndex = 10
        Me.Lab_Cambios_DescripServicio.Text = "Descripción del servicio:"
        '
        'Lab_Cambios_PrecioServicio
        '
        Me.Lab_Cambios_PrecioServicio.AutoSize = True
        Me.Lab_Cambios_PrecioServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_PrecioServicio.Location = New System.Drawing.Point(197, 105)
        Me.Lab_Cambios_PrecioServicio.Name = "Lab_Cambios_PrecioServicio"
        Me.Lab_Cambios_PrecioServicio.Size = New System.Drawing.Size(127, 17)
        Me.Lab_Cambios_PrecioServicio.TabIndex = 9
        Me.Lab_Cambios_PrecioServicio.Text = "Precio del servicio:"
        '
        'Lab_Cambios_NombServicio
        '
        Me.Lab_Cambios_NombServicio.AutoSize = True
        Me.Lab_Cambios_NombServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_NombServicio.Location = New System.Drawing.Point(197, 62)
        Me.Lab_Cambios_NombServicio.Name = "Lab_Cambios_NombServicio"
        Me.Lab_Cambios_NombServicio.Size = New System.Drawing.Size(137, 17)
        Me.Lab_Cambios_NombServicio.TabIndex = 8
        Me.Lab_Cambios_NombServicio.Text = "Nombre del servicio:"
        '
        'Baja_Servicio
        '
        Me.Baja_Servicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baja_Servicio.Controls.Add(Me.Btn_Bajas_Limpiar)
        Me.Baja_Servicio.Controls.Add(Me.Btn_Bajas_Buscar)
        Me.Baja_Servicio.Controls.Add(Me.TtBo_Bajas_PrecioServicio)
        Me.Baja_Servicio.Controls.Add(Me.TtBo_Bajas_DescripServicio)
        Me.Baja_Servicio.Controls.Add(Me.TtBo_Bajas_NombServicio)
        Me.Baja_Servicio.Controls.Add(Me.Lab_Bajas_DescripServicio)
        Me.Baja_Servicio.Controls.Add(Me.Lab_Bajas_PrecioServicio)
        Me.Baja_Servicio.Controls.Add(Me.Lab_Bajas_NombServicio)
        Me.Baja_Servicio.Controls.Add(Me.TextBox33)
        Me.Baja_Servicio.Controls.Add(Me.TextBox34)
        Me.Baja_Servicio.Controls.Add(Me.Label40)
        Me.Baja_Servicio.Controls.Add(Me.Label41)
        Me.Baja_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Baja_Servicio.Name = "Baja_Servicio"
        Me.Baja_Servicio.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Baja_Servicio.TabIndex = 1
        Me.Baja_Servicio.Text = "Bajas de Servicio"
        '
        'Btn_Bajas_Limpiar
        '
        Me.Btn_Bajas_Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Bajas_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Bajas_Limpiar.Location = New System.Drawing.Point(340, 202)
        Me.Btn_Bajas_Limpiar.Name = "Btn_Bajas_Limpiar"
        Me.Btn_Bajas_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Bajas_Limpiar.TabIndex = 95
        Me.Btn_Bajas_Limpiar.Text = "Limpiar"
        Me.Btn_Bajas_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Bajas_Buscar
        '
        Me.Btn_Bajas_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Bajas_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Bajas_Buscar.Location = New System.Drawing.Point(435, 202)
        Me.Btn_Bajas_Buscar.Name = "Btn_Bajas_Buscar"
        Me.Btn_Bajas_Buscar.Size = New System.Drawing.Size(100, 23)
        Me.Btn_Bajas_Buscar.TabIndex = 94
        Me.Btn_Bajas_Buscar.Text = "Buscar"
        Me.Btn_Bajas_Buscar.UseVisualStyleBackColor = False
        '
        'TtBo_Bajas_PrecioServicio
        '
        Me.TtBo_Bajas_PrecioServicio.Enabled = False
        Me.TtBo_Bajas_PrecioServicio.Location = New System.Drawing.Point(340, 125)
        Me.TtBo_Bajas_PrecioServicio.Mask = "9999.99"
        Me.TtBo_Bajas_PrecioServicio.Name = "TtBo_Bajas_PrecioServicio"
        Me.TtBo_Bajas_PrecioServicio.Size = New System.Drawing.Size(195, 20)
        Me.TtBo_Bajas_PrecioServicio.TabIndex = 93
        Me.TtBo_Bajas_PrecioServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Bajas_DescripServicio
        '
        Me.TtBo_Bajas_DescripServicio.Enabled = False
        Me.TtBo_Bajas_DescripServicio.Location = New System.Drawing.Point(340, 166)
        Me.TtBo_Bajas_DescripServicio.MaxLength = 120
        Me.TtBo_Bajas_DescripServicio.Name = "TtBo_Bajas_DescripServicio"
        Me.TtBo_Bajas_DescripServicio.Size = New System.Drawing.Size(195, 20)
        Me.TtBo_Bajas_DescripServicio.TabIndex = 92
        '
        'TtBo_Bajas_NombServicio
        '
        Me.TtBo_Bajas_NombServicio.Location = New System.Drawing.Point(340, 83)
        Me.TtBo_Bajas_NombServicio.MaxLength = 50
        Me.TtBo_Bajas_NombServicio.Name = "TtBo_Bajas_NombServicio"
        Me.TtBo_Bajas_NombServicio.Size = New System.Drawing.Size(195, 20)
        Me.TtBo_Bajas_NombServicio.TabIndex = 91
        '
        'Lab_Bajas_DescripServicio
        '
        Me.Lab_Bajas_DescripServicio.AutoSize = True
        Me.Lab_Bajas_DescripServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Bajas_DescripServicio.Location = New System.Drawing.Point(153, 169)
        Me.Lab_Bajas_DescripServicio.Name = "Lab_Bajas_DescripServicio"
        Me.Lab_Bajas_DescripServicio.Size = New System.Drawing.Size(161, 17)
        Me.Lab_Bajas_DescripServicio.TabIndex = 90
        Me.Lab_Bajas_DescripServicio.Text = "Descripción del servicio:"
        '
        'Lab_Bajas_PrecioServicio
        '
        Me.Lab_Bajas_PrecioServicio.AutoSize = True
        Me.Lab_Bajas_PrecioServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Bajas_PrecioServicio.Location = New System.Drawing.Point(153, 128)
        Me.Lab_Bajas_PrecioServicio.Name = "Lab_Bajas_PrecioServicio"
        Me.Lab_Bajas_PrecioServicio.Size = New System.Drawing.Size(127, 17)
        Me.Lab_Bajas_PrecioServicio.TabIndex = 89
        Me.Lab_Bajas_PrecioServicio.Text = "Precio del servicio:"
        '
        'Lab_Bajas_NombServicio
        '
        Me.Lab_Bajas_NombServicio.AutoSize = True
        Me.Lab_Bajas_NombServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Bajas_NombServicio.Location = New System.Drawing.Point(153, 83)
        Me.Lab_Bajas_NombServicio.Name = "Lab_Bajas_NombServicio"
        Me.Lab_Bajas_NombServicio.Size = New System.Drawing.Size(137, 17)
        Me.Lab_Bajas_NombServicio.TabIndex = 88
        Me.Lab_Bajas_NombServicio.Text = "Nombre del servicio:"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(193, 387)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(164, 20)
        Me.TextBox33.TabIndex = 87
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(193, 357)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(164, 20)
        Me.TextBox34.TabIndex = 86
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label40.Location = New System.Drawing.Point(23, 388)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(80, 17)
        Me.Label40.TabIndex = 80
        Me.Label40.Text = "Teléfono 2:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label41.Location = New System.Drawing.Point(23, 358)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 17)
        Me.Label41.TabIndex = 79
        Me.Label41.Text = "Teléfono 1:"
        '
        'Form_Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tab_Ctr_Servicio)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Name = "Form_Servicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_Servicio.ResumeLayout(False)
        Me.Alta_Servicio.ResumeLayout(False)
        Me.Alta_Servicio.PerformLayout()
        Me.Consulta_Servicio.ResumeLayout(False)
        Me.Consulta_Servicio.PerformLayout()
        CType(Me.DGV_ListaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cambio_Servicio.ResumeLayout(False)
        Me.Cambio_Servicio.PerformLayout()
        Me.Baja_Servicio.ResumeLayout(False)
        Me.Baja_Servicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Btn_atras As Button
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tab_Ctr_Servicio As TabControl
    Friend WithEvents Alta_Servicio As TabPage
    Friend WithEvents Baja_Servicio As TabPage
    Friend WithEvents Consulta_Servicio As TabPage
    Friend WithEvents Cambio_Servicio As TabPage
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Btn_Alta_LimpiarProd As Button
    Friend WithEvents Btn_Alta_GuardarProd As Button
    Friend WithEvents TtBo_Alta_PrecioServicio As MaskedTextBox
    Friend WithEvents TtBo_Alta_DescripServicio As TextBox
    Friend WithEvents TtBo_Alta_NombServicio As TextBox
    Friend WithEvents Lab_Alta_DescripServicio As Label
    Friend WithEvents Lab_Alta_PrecioServicio As Label
    Friend WithEvents Lab_Alta_NombServicio As Label
    Friend WithEvents Btn_Consulta_BuscarTodo As Button
    Friend WithEvents DGV_ListaServicio As DataGridView
    Friend WithEvents DVG_ID_Serv As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Nom_Serv As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Precio_Serv As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Descrip_Serv As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Consulta_Buscar As Button
    Friend WithEvents TtBo_Consulta_NombServicio As TextBox
    Friend WithEvents Lab_Consulta_NombServicio As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Btn_Cambios_Guardar As Button
    Friend WithEvents TtBo_Cambios_PrecioServicio As MaskedTextBox
    Friend WithEvents TtBo_Cambios_DescripServicio As TextBox
    Friend WithEvents TtBo_Cambios_NombServicio As TextBox
    Friend WithEvents Lab_Cambios_DescripServicio As Label
    Friend WithEvents Lab_Cambios_PrecioServicio As Label
    Friend WithEvents Lab_Cambios_NombServicio As Label
    Friend WithEvents Btn_Bajas_Limpiar As Button
    Friend WithEvents Btn_Bajas_Buscar As Button
    Friend WithEvents TtBo_Bajas_PrecioServicio As MaskedTextBox
    Friend WithEvents TtBo_Bajas_DescripServicio As TextBox
    Friend WithEvents TtBo_Bajas_NombServicio As TextBox
    Friend WithEvents Lab_Bajas_DescripServicio As Label
    Friend WithEvents Lab_Bajas_PrecioServicio As Label
    Friend WithEvents Lab_Bajas_NombServicio As Label
End Class
