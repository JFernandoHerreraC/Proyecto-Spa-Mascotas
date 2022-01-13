<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Proveedores))
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_Ctr_Proveedor = New System.Windows.Forms.TabControl()
        Me.Alta_Proveedores = New System.Windows.Forms.TabPage()
        Me.TtBo_Alta_MpioProv = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_MpioProv = New System.Windows.Forms.Label()
        Me.Btn_Alta_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Alta_Guardar = New System.Windows.Forms.Button()
        Me.CoBo_Alta_EstadoProv = New System.Windows.Forms.ComboBox()
        Me.TtBo_Alta_TelefDosProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_TelefUnoProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_ColoniaProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_CpProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NumInteriorProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NumExteriorProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_DescripProv = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_DescripProv = New System.Windows.Forms.Label()
        Me.TtBo_Alta_SecuenciaProv = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_SecuenciaProv = New System.Windows.Forms.Label()
        Me.CoBo_Alta_MonedaProv = New System.Windows.Forms.ComboBox()
        Me.TtBo_Alta_EmailProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_RubroProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_CuentaDepositoProv = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_CuentaDepositoProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_MonedaProv = New System.Windows.Forms.Label()
        Me.CoBo_Alta_FormaPagoProv = New System.Windows.Forms.ComboBox()
        Me.Lab_Alta_FormaPagoProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_RubroProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_EmailProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_TelefDosProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_TelefUnoProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_EstadoProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_ColoniaProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_CpProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_NumInteriorProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_NumExteriorProv = New System.Windows.Forms.Label()
        Me.TtBo_Alta_CalleProv = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_CalleProv = New System.Windows.Forms.Label()
        Me.TtBo_Alta_RfcProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NombProv = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_RfcProv = New System.Windows.Forms.Label()
        Me.Lab_Alta_NombProv = New System.Windows.Forms.Label()
        Me.Consulta_Proveedores = New System.Windows.Forms.TabPage()
        Me.Btn_Consulta_BuscarTodo = New System.Windows.Forms.Button()
        Me.TtBo_Consulta_RfcProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Consulta_NombProv = New System.Windows.Forms.TextBox()
        Me.DGV_ListaProv = New System.Windows.Forms.DataGridView()
        Me.DVG_ID_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_NombORazonS_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Direcc_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Telefono_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Email_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_RubroOGiro_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_FormaP_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Secuencia_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Moneda_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_CuentaDep_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Descp_Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Consulta_BuscarProv = New System.Windows.Forms.Button()
        Me.Lab_Consulta_RfcProv = New System.Windows.Forms.Label()
        Me.Lab_Consulta_NombProv = New System.Windows.Forms.Label()
        Me.Cambio_Proveedor = New System.Windows.Forms.TabPage()
        Me.TtBo_Cambios_mpioProv = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_MpioProv = New System.Windows.Forms.Label()
        Me.Btn_Cambios_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Cambios_Buscar = New System.Windows.Forms.Button()
        Me.CoBo_Cambios_EstadoProv = New System.Windows.Forms.ComboBox()
        Me.TtBo_Cambios_TelefDosProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_TelefUnoProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_ColoniaProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_CpProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_NumInteriorProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_NumExteriorProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_DescripProv = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_DescripProv = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_SecuenciaProv = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_SecuenciaProv = New System.Windows.Forms.Label()
        Me.CoBo_Cambios_MonedaProv = New System.Windows.Forms.ComboBox()
        Me.TtBo_Cambios_EmailProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_RubroProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_CuentaDepositoProv = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_CuentaDepositoProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_MonedaProv = New System.Windows.Forms.Label()
        Me.CoBo_Cambios_FormaPagoProv = New System.Windows.Forms.ComboBox()
        Me.Lab_Cambios_FormaPagoProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_RubroProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_EmailProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_TelefDosProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_TelefUnoProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_EstadoProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_ColoniaProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_CpProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_NumInteriorProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_NumExteriorProv = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_CalleProv = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_CalleProv = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_RfcProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_NombProv = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_RfcProv = New System.Windows.Forms.Label()
        Me.Lab_Cambios_NombProv = New System.Windows.Forms.Label()
        Me.Baja_Proveedores = New System.Windows.Forms.TabPage()
        Me.Btn_Baja_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Baja_Eliminar = New System.Windows.Forms.Button()
        Me.TtBo_PreBaja_ColoniaProv = New System.Windows.Forms.TextBox()
        Me.TtBo_PreBaja_CpProv = New System.Windows.Forms.TextBox()
        Me.TtBo_PreBaja_NumbExterior = New System.Windows.Forms.TextBox()
        Me.TtBo_PreBaja_RubroProv = New System.Windows.Forms.TextBox()
        Me.Lab_PreBaja_RubroProv = New System.Windows.Forms.Label()
        Me.Lab_PreBaja_ColoniaProv = New System.Windows.Forms.Label()
        Me.Lab_PreBaja_CpProv = New System.Windows.Forms.Label()
        Me.Lab_PreBaja_NumExteriorProv = New System.Windows.Forms.Label()
        Me.TtBo_PreBaja_CalleProv = New System.Windows.Forms.TextBox()
        Me.Lab_PreBaja_CalleProv = New System.Windows.Forms.Label()
        Me.TtBo_PreBaja_RfcProv = New System.Windows.Forms.TextBox()
        Me.TtBo_PreBaja_NombProv = New System.Windows.Forms.TextBox()
        Me.Lab_PreBaja_RfcProv = New System.Windows.Forms.Label()
        Me.Lab_PreBaja_NombProv = New System.Windows.Forms.Label()
        Me.Btn_Baja_Buscar = New System.Windows.Forms.Button()
        Me.TtBo_Baja_RfcProv = New System.Windows.Forms.TextBox()
        Me.TtBo_Baja_NombProv = New System.Windows.Forms.TextBox()
        Me.Lab_Baja_RfcProv = New System.Windows.Forms.Label()
        Me.Lab_Baja_NombProv = New System.Windows.Forms.Label()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_Proveedor.SuspendLayout()
        Me.Alta_Proveedores.SuspendLayout()
        Me.Consulta_Proveedores.SuspendLayout()
        CType(Me.DGV_ListaProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cambio_Proveedor.SuspendLayout()
        Me.Baja_Proveedores.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(16, 33)
        Me.Btn_atras.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(100, 28)
        Me.Btn_atras.TabIndex = 4
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem1, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuS_Principal.Size = New System.Drawing.Size(1067, 24)
        Me.MenuS_Principal.TabIndex = 3
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
        'ServiciosToolStripMenuItem1
        '
        Me.ServiciosToolStripMenuItem1.Name = "ServiciosToolStripMenuItem1"
        Me.ServiciosToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.ServiciosToolStripMenuItem1.Text = "Servicios"
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
        'Tab_Ctr_Proveedor
        '
        Me.Tab_Ctr_Proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Ctr_Proveedor.Controls.Add(Me.Alta_Proveedores)
        Me.Tab_Ctr_Proveedor.Controls.Add(Me.Consulta_Proveedores)
        Me.Tab_Ctr_Proveedor.Controls.Add(Me.Cambio_Proveedor)
        Me.Tab_Ctr_Proveedor.Controls.Add(Me.Baja_Proveedores)
        Me.Tab_Ctr_Proveedor.Location = New System.Drawing.Point(16, 69)
        Me.Tab_Ctr_Proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_Ctr_Proveedor.Name = "Tab_Ctr_Proveedor"
        Me.Tab_Ctr_Proveedor.SelectedIndex = 0
        Me.Tab_Ctr_Proveedor.Size = New System.Drawing.Size(1035, 470)
        Me.Tab_Ctr_Proveedor.TabIndex = 5
        '
        'Alta_Proveedores
        '
        Me.Alta_Proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_MpioProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_MpioProv)
        Me.Alta_Proveedores.Controls.Add(Me.Btn_Alta_Limpiar)
        Me.Alta_Proveedores.Controls.Add(Me.Btn_Alta_Guardar)
        Me.Alta_Proveedores.Controls.Add(Me.CoBo_Alta_EstadoProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_TelefDosProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_TelefUnoProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_ColoniaProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_CpProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_NumInteriorProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_NumExteriorProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_DescripProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_DescripProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_SecuenciaProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_SecuenciaProv)
        Me.Alta_Proveedores.Controls.Add(Me.CoBo_Alta_MonedaProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_EmailProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_RubroProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_CuentaDepositoProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_CuentaDepositoProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_MonedaProv)
        Me.Alta_Proveedores.Controls.Add(Me.CoBo_Alta_FormaPagoProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_FormaPagoProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_RubroProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_EmailProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_TelefDosProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_TelefUnoProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_EstadoProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_ColoniaProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_CpProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_NumInteriorProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_NumExteriorProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_CalleProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_CalleProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_RfcProv)
        Me.Alta_Proveedores.Controls.Add(Me.TtBo_Alta_NombProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_RfcProv)
        Me.Alta_Proveedores.Controls.Add(Me.Lab_Alta_NombProv)
        Me.Alta_Proveedores.Location = New System.Drawing.Point(4, 25)
        Me.Alta_Proveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.Alta_Proveedores.Name = "Alta_Proveedores"
        Me.Alta_Proveedores.Padding = New System.Windows.Forms.Padding(4)
        Me.Alta_Proveedores.Size = New System.Drawing.Size(1027, 441)
        Me.Alta_Proveedores.TabIndex = 0
        Me.Alta_Proveedores.Text = "Alta de proveedor"
        '
        'TtBo_Alta_MpioProv
        '
        Me.TtBo_Alta_MpioProv.Location = New System.Drawing.Point(253, 302)
        Me.TtBo_Alta_MpioProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_MpioProv.MaxLength = 50
        Me.TtBo_Alta_MpioProv.Name = "TtBo_Alta_MpioProv"
        Me.TtBo_Alta_MpioProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_MpioProv.TabIndex = 74
        Me.TtBo_Alta_MpioProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_MpioProv
        '
        Me.Lab_Alta_MpioProv.AutoSize = True
        Me.Lab_Alta_MpioProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_MpioProv.Location = New System.Drawing.Point(27, 304)
        Me.Lab_Alta_MpioProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_MpioProv.Name = "Lab_Alta_MpioProv"
        Me.Lab_Alta_MpioProv.Size = New System.Drawing.Size(71, 17)
        Me.Lab_Alta_MpioProv.TabIndex = 73
        Me.Lab_Alta_MpioProv.Text = "Municipio:"
        '
        'Btn_Alta_Limpiar
        '
        Me.Btn_Alta_Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Alta_Limpiar.Location = New System.Drawing.Point(720, 332)
        Me.Btn_Alta_Limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Alta_Limpiar.Name = "Btn_Alta_Limpiar"
        Me.Btn_Alta_Limpiar.Size = New System.Drawing.Size(92, 31)
        Me.Btn_Alta_Limpiar.TabIndex = 72
        Me.Btn_Alta_Limpiar.Text = "Limpiar"
        Me.Btn_Alta_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Alta_Guardar
        '
        Me.Btn_Alta_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Alta_Guardar.Location = New System.Drawing.Point(820, 332)
        Me.Btn_Alta_Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Alta_Guardar.Name = "Btn_Alta_Guardar"
        Me.Btn_Alta_Guardar.Size = New System.Drawing.Size(141, 31)
        Me.Btn_Alta_Guardar.TabIndex = 71
        Me.Btn_Alta_Guardar.Text = "Guardar"
        Me.Btn_Alta_Guardar.UseVisualStyleBackColor = False
        '
        'CoBo_Alta_EstadoProv
        '
        Me.CoBo_Alta_EstadoProv.FormattingEnabled = True
        Me.CoBo_Alta_EstadoProv.Items.AddRange(New Object() {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Ciudad de México", "Coahuila", "Colima", "Durango", "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"})
        Me.CoBo_Alta_EstadoProv.Location = New System.Drawing.Point(253, 336)
        Me.CoBo_Alta_EstadoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.CoBo_Alta_EstadoProv.Name = "CoBo_Alta_EstadoProv"
        Me.CoBo_Alta_EstadoProv.Size = New System.Drawing.Size(217, 24)
        Me.CoBo_Alta_EstadoProv.TabIndex = 70
        '
        'TtBo_Alta_TelefDosProv
        '
        Me.TtBo_Alta_TelefDosProv.Location = New System.Drawing.Point(253, 410)
        Me.TtBo_Alta_TelefDosProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_TelefDosProv.MaxLength = 10
        Me.TtBo_Alta_TelefDosProv.Name = "TtBo_Alta_TelefDosProv"
        Me.TtBo_Alta_TelefDosProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_TelefDosProv.TabIndex = 69
        Me.TtBo_Alta_TelefDosProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Alta_TelefUnoProv
        '
        Me.TtBo_Alta_TelefUnoProv.Location = New System.Drawing.Point(253, 372)
        Me.TtBo_Alta_TelefUnoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_TelefUnoProv.MaxLength = 10
        Me.TtBo_Alta_TelefUnoProv.Name = "TtBo_Alta_TelefUnoProv"
        Me.TtBo_Alta_TelefUnoProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_TelefUnoProv.TabIndex = 68
        Me.TtBo_Alta_TelefUnoProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Alta_ColoniaProv
        '
        Me.TtBo_Alta_ColoniaProv.Location = New System.Drawing.Point(253, 263)
        Me.TtBo_Alta_ColoniaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_ColoniaProv.MaxLength = 50
        Me.TtBo_Alta_ColoniaProv.Name = "TtBo_Alta_ColoniaProv"
        Me.TtBo_Alta_ColoniaProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_ColoniaProv.TabIndex = 67
        Me.TtBo_Alta_ColoniaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Alta_CpProv
        '
        Me.TtBo_Alta_CpProv.Location = New System.Drawing.Point(253, 226)
        Me.TtBo_Alta_CpProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_CpProv.MaxLength = 5
        Me.TtBo_Alta_CpProv.Name = "TtBo_Alta_CpProv"
        Me.TtBo_Alta_CpProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_CpProv.TabIndex = 66
        '
        'TtBo_Alta_NumInteriorProv
        '
        Me.TtBo_Alta_NumInteriorProv.Location = New System.Drawing.Point(253, 192)
        Me.TtBo_Alta_NumInteriorProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_NumInteriorProv.MaxLength = 5
        Me.TtBo_Alta_NumInteriorProv.Name = "TtBo_Alta_NumInteriorProv"
        Me.TtBo_Alta_NumInteriorProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_NumInteriorProv.TabIndex = 65
        '
        'TtBo_Alta_NumExteriorProv
        '
        Me.TtBo_Alta_NumExteriorProv.Location = New System.Drawing.Point(253, 154)
        Me.TtBo_Alta_NumExteriorProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_NumExteriorProv.MaxLength = 5
        Me.TtBo_Alta_NumExteriorProv.Name = "TtBo_Alta_NumExteriorProv"
        Me.TtBo_Alta_NumExteriorProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_NumExteriorProv.TabIndex = 64
        '
        'TtBo_Alta_DescripProv
        '
        Me.TtBo_Alta_DescripProv.Location = New System.Drawing.Point(720, 282)
        Me.TtBo_Alta_DescripProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_DescripProv.MaxLength = 120
        Me.TtBo_Alta_DescripProv.Name = "TtBo_Alta_DescripProv"
        Me.TtBo_Alta_DescripProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Alta_DescripProv.TabIndex = 63
        Me.TtBo_Alta_DescripProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_DescripProv
        '
        Me.Lab_Alta_DescripProv.AutoSize = True
        Me.Lab_Alta_DescripProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_DescripProv.Location = New System.Drawing.Point(517, 286)
        Me.Lab_Alta_DescripProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_DescripProv.Name = "Lab_Alta_DescripProv"
        Me.Lab_Alta_DescripProv.Size = New System.Drawing.Size(86, 17)
        Me.Lab_Alta_DescripProv.TabIndex = 62
        Me.Lab_Alta_DescripProv.Text = "Descripción:"
        '
        'TtBo_Alta_SecuenciaProv
        '
        Me.TtBo_Alta_SecuenciaProv.Location = New System.Drawing.Point(720, 151)
        Me.TtBo_Alta_SecuenciaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_SecuenciaProv.MaxLength = 5
        Me.TtBo_Alta_SecuenciaProv.Name = "TtBo_Alta_SecuenciaProv"
        Me.TtBo_Alta_SecuenciaProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Alta_SecuenciaProv.TabIndex = 61
        Me.TtBo_Alta_SecuenciaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_SecuenciaProv
        '
        Me.Lab_Alta_SecuenciaProv.AutoSize = True
        Me.Lab_Alta_SecuenciaProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_SecuenciaProv.Location = New System.Drawing.Point(517, 155)
        Me.Lab_Alta_SecuenciaProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_SecuenciaProv.Name = "Lab_Alta_SecuenciaProv"
        Me.Lab_Alta_SecuenciaProv.Size = New System.Drawing.Size(78, 17)
        Me.Lab_Alta_SecuenciaProv.TabIndex = 60
        Me.Lab_Alta_SecuenciaProv.Text = "Secuencia:"
        '
        'CoBo_Alta_MonedaProv
        '
        Me.CoBo_Alta_MonedaProv.FormattingEnabled = True
        Me.CoBo_Alta_MonedaProv.Items.AddRange(New Object() {"Peso Mexicano", "Dolares Americanos", "Euros", "Yuanes "})
        Me.CoBo_Alta_MonedaProv.Location = New System.Drawing.Point(720, 193)
        Me.CoBo_Alta_MonedaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.CoBo_Alta_MonedaProv.Name = "CoBo_Alta_MonedaProv"
        Me.CoBo_Alta_MonedaProv.Size = New System.Drawing.Size(240, 24)
        Me.CoBo_Alta_MonedaProv.TabIndex = 59
        '
        'TtBo_Alta_EmailProv
        '
        Me.TtBo_Alta_EmailProv.Location = New System.Drawing.Point(720, 36)
        Me.TtBo_Alta_EmailProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_EmailProv.MaxLength = 40
        Me.TtBo_Alta_EmailProv.Name = "TtBo_Alta_EmailProv"
        Me.TtBo_Alta_EmailProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Alta_EmailProv.TabIndex = 58
        Me.TtBo_Alta_EmailProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Alta_RubroProv
        '
        Me.TtBo_Alta_RubroProv.Location = New System.Drawing.Point(720, 65)
        Me.TtBo_Alta_RubroProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_RubroProv.MaxLength = 50
        Me.TtBo_Alta_RubroProv.Name = "TtBo_Alta_RubroProv"
        Me.TtBo_Alta_RubroProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Alta_RubroProv.TabIndex = 57
        '
        'TtBo_Alta_CuentaDepositoProv
        '
        Me.TtBo_Alta_CuentaDepositoProv.Location = New System.Drawing.Point(720, 240)
        Me.TtBo_Alta_CuentaDepositoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_CuentaDepositoProv.MaxLength = 20
        Me.TtBo_Alta_CuentaDepositoProv.Name = "TtBo_Alta_CuentaDepositoProv"
        Me.TtBo_Alta_CuentaDepositoProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Alta_CuentaDepositoProv.TabIndex = 56
        Me.TtBo_Alta_CuentaDepositoProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_CuentaDepositoProv
        '
        Me.Lab_Alta_CuentaDepositoProv.AutoSize = True
        Me.Lab_Alta_CuentaDepositoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CuentaDepositoProv.Location = New System.Drawing.Point(517, 241)
        Me.Lab_Alta_CuentaDepositoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_CuentaDepositoProv.Name = "Lab_Alta_CuentaDepositoProv"
        Me.Lab_Alta_CuentaDepositoProv.Size = New System.Drawing.Size(135, 17)
        Me.Lab_Alta_CuentaDepositoProv.TabIndex = 55
        Me.Lab_Alta_CuentaDepositoProv.Text = "Cuenta de deposito:"
        '
        'Lab_Alta_MonedaProv
        '
        Me.Lab_Alta_MonedaProv.AutoSize = True
        Me.Lab_Alta_MonedaProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_MonedaProv.Location = New System.Drawing.Point(517, 198)
        Me.Lab_Alta_MonedaProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_MonedaProv.Name = "Lab_Alta_MonedaProv"
        Me.Lab_Alta_MonedaProv.Size = New System.Drawing.Size(63, 17)
        Me.Lab_Alta_MonedaProv.TabIndex = 54
        Me.Lab_Alta_MonedaProv.Text = "Moneda:"
        '
        'CoBo_Alta_FormaPagoProv
        '
        Me.CoBo_Alta_FormaPagoProv.FormattingEnabled = True
        Me.CoBo_Alta_FormaPagoProv.Items.AddRange(New Object() {"Pagó de una sola exibición", "Depositó baconcario"})
        Me.CoBo_Alta_FormaPagoProv.Location = New System.Drawing.Point(720, 108)
        Me.CoBo_Alta_FormaPagoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.CoBo_Alta_FormaPagoProv.Name = "CoBo_Alta_FormaPagoProv"
        Me.CoBo_Alta_FormaPagoProv.Size = New System.Drawing.Size(240, 24)
        Me.CoBo_Alta_FormaPagoProv.TabIndex = 53
        '
        'Lab_Alta_FormaPagoProv
        '
        Me.Lab_Alta_FormaPagoProv.AutoSize = True
        Me.Lab_Alta_FormaPagoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_FormaPagoProv.Location = New System.Drawing.Point(517, 113)
        Me.Lab_Alta_FormaPagoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_FormaPagoProv.Name = "Lab_Alta_FormaPagoProv"
        Me.Lab_Alta_FormaPagoProv.Size = New System.Drawing.Size(108, 17)
        Me.Lab_Alta_FormaPagoProv.TabIndex = 52
        Me.Lab_Alta_FormaPagoProv.Text = "Forma de pago:"
        '
        'Lab_Alta_RubroProv
        '
        Me.Lab_Alta_RubroProv.AutoSize = True
        Me.Lab_Alta_RubroProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_RubroProv.Location = New System.Drawing.Point(517, 69)
        Me.Lab_Alta_RubroProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_RubroProv.Name = "Lab_Alta_RubroProv"
        Me.Lab_Alta_RubroProv.Size = New System.Drawing.Size(83, 17)
        Me.Lab_Alta_RubroProv.TabIndex = 51
        Me.Lab_Alta_RubroProv.Text = "Rubro/ giro:"
        '
        'Lab_Alta_EmailProv
        '
        Me.Lab_Alta_EmailProv.AutoSize = True
        Me.Lab_Alta_EmailProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_EmailProv.Location = New System.Drawing.Point(517, 36)
        Me.Lab_Alta_EmailProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_EmailProv.Name = "Lab_Alta_EmailProv"
        Me.Lab_Alta_EmailProv.Size = New System.Drawing.Size(46, 17)
        Me.Lab_Alta_EmailProv.TabIndex = 50
        Me.Lab_Alta_EmailProv.Text = "Email:"
        '
        'Lab_Alta_TelefDosProv
        '
        Me.Lab_Alta_TelefDosProv.AutoSize = True
        Me.Lab_Alta_TelefDosProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_TelefDosProv.Location = New System.Drawing.Point(27, 410)
        Me.Lab_Alta_TelefDosProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_TelefDosProv.Name = "Lab_Alta_TelefDosProv"
        Me.Lab_Alta_TelefDosProv.Size = New System.Drawing.Size(80, 17)
        Me.Lab_Alta_TelefDosProv.TabIndex = 49
        Me.Lab_Alta_TelefDosProv.Text = "Teléfono 2:"
        '
        'Lab_Alta_TelefUnoProv
        '
        Me.Lab_Alta_TelefUnoProv.AutoSize = True
        Me.Lab_Alta_TelefUnoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_TelefUnoProv.Location = New System.Drawing.Point(27, 369)
        Me.Lab_Alta_TelefUnoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_TelefUnoProv.Name = "Lab_Alta_TelefUnoProv"
        Me.Lab_Alta_TelefUnoProv.Size = New System.Drawing.Size(80, 17)
        Me.Lab_Alta_TelefUnoProv.TabIndex = 48
        Me.Lab_Alta_TelefUnoProv.Text = "Teléfono 1:"
        '
        'Lab_Alta_EstadoProv
        '
        Me.Lab_Alta_EstadoProv.AutoSize = True
        Me.Lab_Alta_EstadoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_EstadoProv.Location = New System.Drawing.Point(27, 339)
        Me.Lab_Alta_EstadoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_EstadoProv.Name = "Lab_Alta_EstadoProv"
        Me.Lab_Alta_EstadoProv.Size = New System.Drawing.Size(56, 17)
        Me.Lab_Alta_EstadoProv.TabIndex = 47
        Me.Lab_Alta_EstadoProv.Text = "Estado:"
        '
        'Lab_Alta_ColoniaProv
        '
        Me.Lab_Alta_ColoniaProv.AutoSize = True
        Me.Lab_Alta_ColoniaProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_ColoniaProv.Location = New System.Drawing.Point(27, 265)
        Me.Lab_Alta_ColoniaProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_ColoniaProv.Name = "Lab_Alta_ColoniaProv"
        Me.Lab_Alta_ColoniaProv.Size = New System.Drawing.Size(142, 17)
        Me.Lab_Alta_ColoniaProv.TabIndex = 46
        Me.Lab_Alta_ColoniaProv.Text = "Colonia / Delegación:"
        '
        'Lab_Alta_CpProv
        '
        Me.Lab_Alta_CpProv.AutoSize = True
        Me.Lab_Alta_CpProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CpProv.Location = New System.Drawing.Point(27, 230)
        Me.Lab_Alta_CpProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_CpProv.Name = "Lab_Alta_CpProv"
        Me.Lab_Alta_CpProv.Size = New System.Drawing.Size(30, 17)
        Me.Lab_Alta_CpProv.TabIndex = 45
        Me.Lab_Alta_CpProv.Text = "CP:"
        '
        'Lab_Alta_NumInteriorProv
        '
        Me.Lab_Alta_NumInteriorProv.AutoSize = True
        Me.Lab_Alta_NumInteriorProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NumInteriorProv.Location = New System.Drawing.Point(27, 193)
        Me.Lab_Alta_NumInteriorProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_NumInteriorProv.Name = "Lab_Alta_NumInteriorProv"
        Me.Lab_Alta_NumInteriorProv.Size = New System.Drawing.Size(110, 17)
        Me.Lab_Alta_NumInteriorProv.TabIndex = 44
        Me.Lab_Alta_NumInteriorProv.Text = "Número interior:"
        '
        'Lab_Alta_NumExteriorProv
        '
        Me.Lab_Alta_NumExteriorProv.AutoSize = True
        Me.Lab_Alta_NumExteriorProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NumExteriorProv.Location = New System.Drawing.Point(27, 155)
        Me.Lab_Alta_NumExteriorProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_NumExteriorProv.Name = "Lab_Alta_NumExteriorProv"
        Me.Lab_Alta_NumExteriorProv.Size = New System.Drawing.Size(113, 17)
        Me.Lab_Alta_NumExteriorProv.TabIndex = 43
        Me.Lab_Alta_NumExteriorProv.Text = "Número exterior:"
        '
        'TtBo_Alta_CalleProv
        '
        Me.TtBo_Alta_CalleProv.Location = New System.Drawing.Point(253, 110)
        Me.TtBo_Alta_CalleProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_CalleProv.MaxLength = 30
        Me.TtBo_Alta_CalleProv.Name = "TtBo_Alta_CalleProv"
        Me.TtBo_Alta_CalleProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_CalleProv.TabIndex = 42
        Me.TtBo_Alta_CalleProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_CalleProv
        '
        Me.Lab_Alta_CalleProv.AutoSize = True
        Me.Lab_Alta_CalleProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CalleProv.Location = New System.Drawing.Point(27, 113)
        Me.Lab_Alta_CalleProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_CalleProv.Name = "Lab_Alta_CalleProv"
        Me.Lab_Alta_CalleProv.Size = New System.Drawing.Size(43, 17)
        Me.Lab_Alta_CalleProv.TabIndex = 41
        Me.Lab_Alta_CalleProv.Text = "Calle:"
        '
        'TtBo_Alta_RfcProv
        '
        Me.TtBo_Alta_RfcProv.Location = New System.Drawing.Point(253, 69)
        Me.TtBo_Alta_RfcProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_RfcProv.MaxLength = 20
        Me.TtBo_Alta_RfcProv.Name = "TtBo_Alta_RfcProv"
        Me.TtBo_Alta_RfcProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_RfcProv.TabIndex = 40
        Me.TtBo_Alta_RfcProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Alta_NombProv
        '
        Me.TtBo_Alta_NombProv.Location = New System.Drawing.Point(253, 36)
        Me.TtBo_Alta_NombProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Alta_NombProv.MaxLength = 80
        Me.TtBo_Alta_NombProv.Name = "TtBo_Alta_NombProv"
        Me.TtBo_Alta_NombProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Alta_NombProv.TabIndex = 39
        Me.TtBo_Alta_NombProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_RfcProv
        '
        Me.Lab_Alta_RfcProv.AutoSize = True
        Me.Lab_Alta_RfcProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_RfcProv.Location = New System.Drawing.Point(27, 69)
        Me.Lab_Alta_RfcProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_RfcProv.Name = "Lab_Alta_RfcProv"
        Me.Lab_Alta_RfcProv.Size = New System.Drawing.Size(39, 17)
        Me.Lab_Alta_RfcProv.TabIndex = 38
        Me.Lab_Alta_RfcProv.Text = "RFC:"
        '
        'Lab_Alta_NombProv
        '
        Me.Lab_Alta_NombProv.AutoSize = True
        Me.Lab_Alta_NombProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NombProv.Location = New System.Drawing.Point(27, 36)
        Me.Lab_Alta_NombProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Alta_NombProv.Name = "Lab_Alta_NombProv"
        Me.Lab_Alta_NombProv.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Alta_NombProv.TabIndex = 37
        Me.Lab_Alta_NombProv.Text = "Nombre o razón social:"
        '
        'Consulta_Proveedores
        '
        Me.Consulta_Proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_Proveedores.Controls.Add(Me.Btn_Consulta_BuscarTodo)
        Me.Consulta_Proveedores.Controls.Add(Me.TtBo_Consulta_RfcProv)
        Me.Consulta_Proveedores.Controls.Add(Me.TtBo_Consulta_NombProv)
        Me.Consulta_Proveedores.Controls.Add(Me.DGV_ListaProv)
        Me.Consulta_Proveedores.Controls.Add(Me.Btn_Consulta_BuscarProv)
        Me.Consulta_Proveedores.Controls.Add(Me.Lab_Consulta_RfcProv)
        Me.Consulta_Proveedores.Controls.Add(Me.Lab_Consulta_NombProv)
        Me.Consulta_Proveedores.Location = New System.Drawing.Point(4, 25)
        Me.Consulta_Proveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.Consulta_Proveedores.Name = "Consulta_Proveedores"
        Me.Consulta_Proveedores.Size = New System.Drawing.Size(1027, 441)
        Me.Consulta_Proveedores.TabIndex = 2
        Me.Consulta_Proveedores.Text = "Consulta de proveedores"
        '
        'Btn_Consulta_BuscarTodo
        '
        Me.Btn_Consulta_BuscarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Consulta_BuscarTodo.Location = New System.Drawing.Point(461, 75)
        Me.Btn_Consulta_BuscarTodo.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Consulta_BuscarTodo.Name = "Btn_Consulta_BuscarTodo"
        Me.Btn_Consulta_BuscarTodo.Size = New System.Drawing.Size(179, 31)
        Me.Btn_Consulta_BuscarTodo.TabIndex = 3
        Me.Btn_Consulta_BuscarTodo.Text = "Buscar todo"
        Me.Btn_Consulta_BuscarTodo.UseVisualStyleBackColor = False
        '
        'TtBo_Consulta_RfcProv
        '
        Me.TtBo_Consulta_RfcProv.Location = New System.Drawing.Point(527, 43)
        Me.TtBo_Consulta_RfcProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Consulta_RfcProv.MaxLength = 20
        Me.TtBo_Consulta_RfcProv.Name = "TtBo_Consulta_RfcProv"
        Me.TtBo_Consulta_RfcProv.Size = New System.Drawing.Size(215, 23)
        Me.TtBo_Consulta_RfcProv.TabIndex = 2
        '
        'TtBo_Consulta_NombProv
        '
        Me.TtBo_Consulta_NombProv.Location = New System.Drawing.Point(527, 11)
        Me.TtBo_Consulta_NombProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Consulta_NombProv.MaxLength = 100
        Me.TtBo_Consulta_NombProv.Name = "TtBo_Consulta_NombProv"
        Me.TtBo_Consulta_NombProv.Size = New System.Drawing.Size(215, 23)
        Me.TtBo_Consulta_NombProv.TabIndex = 1
        '
        'DGV_ListaProv
        '
        Me.DGV_ListaProv.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_ListaProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ListaProv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DVG_ID_Prov, Me.DVG_NombORazonS_Prov, Me.DVG_Direcc_Prov, Me.DVG_Telefono_Prov, Me.DVG_Email_Prov, Me.DVG_RubroOGiro_Prov, Me.DVG_FormaP_Prov, Me.DVG_Secuencia_Prov, Me.DVG_Moneda_Prov, Me.DVG_CuentaDep_Prov, Me.DVG_Descp_Prov})
        Me.DGV_ListaProv.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DGV_ListaProv.Location = New System.Drawing.Point(12, 148)
        Me.DGV_ListaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_ListaProv.Name = "DGV_ListaProv"
        Me.DGV_ListaProv.Size = New System.Drawing.Size(1016, 185)
        Me.DGV_ListaProv.TabIndex = 13
        '
        'DVG_ID_Prov
        '
        Me.DVG_ID_Prov.HeaderText = "ID"
        Me.DVG_ID_Prov.MaxInputLength = 3
        Me.DVG_ID_Prov.Name = "DVG_ID_Prov"
        Me.DVG_ID_Prov.Width = 35
        '
        'DVG_NombORazonS_Prov
        '
        Me.DVG_NombORazonS_Prov.HeaderText = "Nombre o razón social"
        Me.DVG_NombORazonS_Prov.MaxInputLength = 120
        Me.DVG_NombORazonS_Prov.Name = "DVG_NombORazonS_Prov"
        '
        'DVG_Direcc_Prov
        '
        Me.DVG_Direcc_Prov.HeaderText = "Dirección"
        Me.DVG_Direcc_Prov.MaxInputLength = 120
        Me.DVG_Direcc_Prov.Name = "DVG_Direcc_Prov"
        '
        'DVG_Telefono_Prov
        '
        Me.DVG_Telefono_Prov.HeaderText = "Teléfonos"
        Me.DVG_Telefono_Prov.MaxInputLength = 23
        Me.DVG_Telefono_Prov.Name = "DVG_Telefono_Prov"
        '
        'DVG_Email_Prov
        '
        Me.DVG_Email_Prov.HeaderText = "Email"
        Me.DVG_Email_Prov.MaxInputLength = 45
        Me.DVG_Email_Prov.Name = "DVG_Email_Prov"
        '
        'DVG_RubroOGiro_Prov
        '
        Me.DVG_RubroOGiro_Prov.HeaderText = "Rubro / giro"
        Me.DVG_RubroOGiro_Prov.MaxInputLength = 50
        Me.DVG_RubroOGiro_Prov.Name = "DVG_RubroOGiro_Prov"
        '
        'DVG_FormaP_Prov
        '
        Me.DVG_FormaP_Prov.HeaderText = "Forma de pago"
        Me.DVG_FormaP_Prov.MaxInputLength = 50
        Me.DVG_FormaP_Prov.Name = "DVG_FormaP_Prov"
        '
        'DVG_Secuencia_Prov
        '
        Me.DVG_Secuencia_Prov.HeaderText = "Secuencia"
        Me.DVG_Secuencia_Prov.MaxInputLength = 50
        Me.DVG_Secuencia_Prov.Name = "DVG_Secuencia_Prov"
        '
        'DVG_Moneda_Prov
        '
        Me.DVG_Moneda_Prov.HeaderText = "Moneda"
        Me.DVG_Moneda_Prov.MaxInputLength = 30
        Me.DVG_Moneda_Prov.Name = "DVG_Moneda_Prov"
        Me.DVG_Moneda_Prov.Width = 50
        '
        'DVG_CuentaDep_Prov
        '
        Me.DVG_CuentaDep_Prov.HeaderText = "Cuenta de depósito"
        Me.DVG_CuentaDep_Prov.MaxInputLength = 20
        Me.DVG_CuentaDep_Prov.Name = "DVG_CuentaDep_Prov"
        '
        'DVG_Descp_Prov
        '
        Me.DVG_Descp_Prov.HeaderText = "Descripción"
        Me.DVG_Descp_Prov.MaxInputLength = 120
        Me.DVG_Descp_Prov.Name = "DVG_Descp_Prov"
        '
        'Btn_Consulta_BuscarProv
        '
        Me.Btn_Consulta_BuscarProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Consulta_BuscarProv.Location = New System.Drawing.Point(643, 75)
        Me.Btn_Consulta_BuscarProv.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Consulta_BuscarProv.Name = "Btn_Consulta_BuscarProv"
        Me.Btn_Consulta_BuscarProv.Size = New System.Drawing.Size(179, 31)
        Me.Btn_Consulta_BuscarProv.TabIndex = 2
        Me.Btn_Consulta_BuscarProv.Text = "Buscar"
        Me.Btn_Consulta_BuscarProv.UseVisualStyleBackColor = False
        '
        'Lab_Consulta_RfcProv
        '
        Me.Lab_Consulta_RfcProv.AutoSize = True
        Me.Lab_Consulta_RfcProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Consulta_RfcProv.Location = New System.Drawing.Point(312, 44)
        Me.Lab_Consulta_RfcProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Consulta_RfcProv.Name = "Lab_Consulta_RfcProv"
        Me.Lab_Consulta_RfcProv.Size = New System.Drawing.Size(39, 17)
        Me.Lab_Consulta_RfcProv.TabIndex = 11
        Me.Lab_Consulta_RfcProv.Text = "RFC:"
        '
        'Lab_Consulta_NombProv
        '
        Me.Lab_Consulta_NombProv.AutoSize = True
        Me.Lab_Consulta_NombProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Consulta_NombProv.Location = New System.Drawing.Point(312, 11)
        Me.Lab_Consulta_NombProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Consulta_NombProv.Name = "Lab_Consulta_NombProv"
        Me.Lab_Consulta_NombProv.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Consulta_NombProv.TabIndex = 10
        Me.Lab_Consulta_NombProv.Text = "Nombre o razón social:"
        '
        'Cambio_Proveedor
        '
        Me.Cambio_Proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_mpioProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_MpioProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Btn_Cambios_Limpiar)
        Me.Cambio_Proveedor.Controls.Add(Me.Btn_Cambios_Buscar)
        Me.Cambio_Proveedor.Controls.Add(Me.CoBo_Cambios_EstadoProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_TelefDosProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_TelefUnoProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_ColoniaProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_CpProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_NumInteriorProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_NumExteriorProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_DescripProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_DescripProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_SecuenciaProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_SecuenciaProv)
        Me.Cambio_Proveedor.Controls.Add(Me.CoBo_Cambios_MonedaProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_EmailProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_RubroProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_CuentaDepositoProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_CuentaDepositoProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_MonedaProv)
        Me.Cambio_Proveedor.Controls.Add(Me.CoBo_Cambios_FormaPagoProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_FormaPagoProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_RubroProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_EmailProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_TelefDosProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_TelefUnoProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_EstadoProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_ColoniaProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_CpProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_NumInteriorProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_NumExteriorProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_CalleProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_CalleProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_RfcProv)
        Me.Cambio_Proveedor.Controls.Add(Me.TtBo_Cambios_NombProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_RfcProv)
        Me.Cambio_Proveedor.Controls.Add(Me.Lab_Cambios_NombProv)
        Me.Cambio_Proveedor.Location = New System.Drawing.Point(4, 25)
        Me.Cambio_Proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.Cambio_Proveedor.Name = "Cambio_Proveedor"
        Me.Cambio_Proveedor.Size = New System.Drawing.Size(1027, 441)
        Me.Cambio_Proveedor.TabIndex = 3
        Me.Cambio_Proveedor.Text = "Cambios en el proveedor"
        '
        'TtBo_Cambios_mpioProv
        '
        Me.TtBo_Cambios_mpioProv.Location = New System.Drawing.Point(253, 294)
        Me.TtBo_Cambios_mpioProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_mpioProv.Name = "TtBo_Cambios_mpioProv"
        Me.TtBo_Cambios_mpioProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_mpioProv.TabIndex = 110
        Me.TtBo_Cambios_mpioProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Cambios_MpioProv
        '
        Me.Lab_Cambios_MpioProv.AutoSize = True
        Me.Lab_Cambios_MpioProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_MpioProv.Location = New System.Drawing.Point(27, 296)
        Me.Lab_Cambios_MpioProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_MpioProv.Name = "Lab_Cambios_MpioProv"
        Me.Lab_Cambios_MpioProv.Size = New System.Drawing.Size(71, 17)
        Me.Lab_Cambios_MpioProv.TabIndex = 109
        Me.Lab_Cambios_MpioProv.Text = "Municipio:"
        '
        'Btn_Cambios_Limpiar
        '
        Me.Btn_Cambios_Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Cambios_Limpiar.Location = New System.Drawing.Point(720, 332)
        Me.Btn_Cambios_Limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Cambios_Limpiar.Name = "Btn_Cambios_Limpiar"
        Me.Btn_Cambios_Limpiar.Size = New System.Drawing.Size(91, 31)
        Me.Btn_Cambios_Limpiar.TabIndex = 108
        Me.Btn_Cambios_Limpiar.Text = "Limpiar"
        Me.Btn_Cambios_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Cambios_Buscar
        '
        Me.Btn_Cambios_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Cambios_Buscar.Location = New System.Drawing.Point(819, 332)
        Me.Btn_Cambios_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Cambios_Buscar.Name = "Btn_Cambios_Buscar"
        Me.Btn_Cambios_Buscar.Size = New System.Drawing.Size(141, 31)
        Me.Btn_Cambios_Buscar.TabIndex = 107
        Me.Btn_Cambios_Buscar.Text = "Buscar"
        Me.Btn_Cambios_Buscar.UseVisualStyleBackColor = False
        '
        'CoBo_Cambios_EstadoProv
        '
        Me.CoBo_Cambios_EstadoProv.FormattingEnabled = True
        Me.CoBo_Cambios_EstadoProv.Items.AddRange(New Object() {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Ciudad de México", "Coahuila", "Colima", "Durango", "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"})
        Me.CoBo_Cambios_EstadoProv.Location = New System.Drawing.Point(253, 332)
        Me.CoBo_Cambios_EstadoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.CoBo_Cambios_EstadoProv.Name = "CoBo_Cambios_EstadoProv"
        Me.CoBo_Cambios_EstadoProv.Size = New System.Drawing.Size(217, 24)
        Me.CoBo_Cambios_EstadoProv.TabIndex = 106
        '
        'TtBo_Cambios_TelefDosProv
        '
        Me.TtBo_Cambios_TelefDosProv.Location = New System.Drawing.Point(253, 403)
        Me.TtBo_Cambios_TelefDosProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_TelefDosProv.MaxLength = 10
        Me.TtBo_Cambios_TelefDosProv.Name = "TtBo_Cambios_TelefDosProv"
        Me.TtBo_Cambios_TelefDosProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_TelefDosProv.TabIndex = 105
        Me.TtBo_Cambios_TelefDosProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_TelefUnoProv
        '
        Me.TtBo_Cambios_TelefUnoProv.Location = New System.Drawing.Point(253, 366)
        Me.TtBo_Cambios_TelefUnoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_TelefUnoProv.MaxLength = 10
        Me.TtBo_Cambios_TelefUnoProv.Name = "TtBo_Cambios_TelefUnoProv"
        Me.TtBo_Cambios_TelefUnoProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_TelefUnoProv.TabIndex = 104
        Me.TtBo_Cambios_TelefUnoProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_ColoniaProv
        '
        Me.TtBo_Cambios_ColoniaProv.Location = New System.Drawing.Point(253, 263)
        Me.TtBo_Cambios_ColoniaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_ColoniaProv.MaxLength = 50
        Me.TtBo_Cambios_ColoniaProv.Name = "TtBo_Cambios_ColoniaProv"
        Me.TtBo_Cambios_ColoniaProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_ColoniaProv.TabIndex = 103
        Me.TtBo_Cambios_ColoniaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_CpProv
        '
        Me.TtBo_Cambios_CpProv.Location = New System.Drawing.Point(253, 226)
        Me.TtBo_Cambios_CpProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_CpProv.MaxLength = 5
        Me.TtBo_Cambios_CpProv.Name = "TtBo_Cambios_CpProv"
        Me.TtBo_Cambios_CpProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_CpProv.TabIndex = 102
        Me.TtBo_Cambios_CpProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_NumInteriorProv
        '
        Me.TtBo_Cambios_NumInteriorProv.Location = New System.Drawing.Point(253, 192)
        Me.TtBo_Cambios_NumInteriorProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_NumInteriorProv.MaxLength = 5
        Me.TtBo_Cambios_NumInteriorProv.Name = "TtBo_Cambios_NumInteriorProv"
        Me.TtBo_Cambios_NumInteriorProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_NumInteriorProv.TabIndex = 101
        Me.TtBo_Cambios_NumInteriorProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_NumExteriorProv
        '
        Me.TtBo_Cambios_NumExteriorProv.Location = New System.Drawing.Point(253, 154)
        Me.TtBo_Cambios_NumExteriorProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_NumExteriorProv.MaxLength = 5
        Me.TtBo_Cambios_NumExteriorProv.Name = "TtBo_Cambios_NumExteriorProv"
        Me.TtBo_Cambios_NumExteriorProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_NumExteriorProv.TabIndex = 100
        Me.TtBo_Cambios_NumExteriorProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_DescripProv
        '
        Me.TtBo_Cambios_DescripProv.Location = New System.Drawing.Point(720, 282)
        Me.TtBo_Cambios_DescripProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_DescripProv.MaxLength = 120
        Me.TtBo_Cambios_DescripProv.Name = "TtBo_Cambios_DescripProv"
        Me.TtBo_Cambios_DescripProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Cambios_DescripProv.TabIndex = 99
        Me.TtBo_Cambios_DescripProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Cambios_DescripProv
        '
        Me.Lab_Cambios_DescripProv.AutoSize = True
        Me.Lab_Cambios_DescripProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_DescripProv.Location = New System.Drawing.Point(517, 286)
        Me.Lab_Cambios_DescripProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_DescripProv.Name = "Lab_Cambios_DescripProv"
        Me.Lab_Cambios_DescripProv.Size = New System.Drawing.Size(86, 17)
        Me.Lab_Cambios_DescripProv.TabIndex = 98
        Me.Lab_Cambios_DescripProv.Text = "Descripción:"
        '
        'TtBo_Cambios_SecuenciaProv
        '
        Me.TtBo_Cambios_SecuenciaProv.Location = New System.Drawing.Point(720, 151)
        Me.TtBo_Cambios_SecuenciaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_SecuenciaProv.MaxLength = 5
        Me.TtBo_Cambios_SecuenciaProv.Name = "TtBo_Cambios_SecuenciaProv"
        Me.TtBo_Cambios_SecuenciaProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Cambios_SecuenciaProv.TabIndex = 97
        Me.TtBo_Cambios_SecuenciaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Cambios_SecuenciaProv
        '
        Me.Lab_Cambios_SecuenciaProv.AutoSize = True
        Me.Lab_Cambios_SecuenciaProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_SecuenciaProv.Location = New System.Drawing.Point(517, 155)
        Me.Lab_Cambios_SecuenciaProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_SecuenciaProv.Name = "Lab_Cambios_SecuenciaProv"
        Me.Lab_Cambios_SecuenciaProv.Size = New System.Drawing.Size(78, 17)
        Me.Lab_Cambios_SecuenciaProv.TabIndex = 96
        Me.Lab_Cambios_SecuenciaProv.Text = "Secuencia:"
        '
        'CoBo_Cambios_MonedaProv
        '
        Me.CoBo_Cambios_MonedaProv.FormattingEnabled = True
        Me.CoBo_Cambios_MonedaProv.Items.AddRange(New Object() {"Peso Mexicano", "Dolares Americanos", "Euros", "Yuanes "})
        Me.CoBo_Cambios_MonedaProv.Location = New System.Drawing.Point(720, 193)
        Me.CoBo_Cambios_MonedaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.CoBo_Cambios_MonedaProv.Name = "CoBo_Cambios_MonedaProv"
        Me.CoBo_Cambios_MonedaProv.Size = New System.Drawing.Size(240, 24)
        Me.CoBo_Cambios_MonedaProv.TabIndex = 95
        '
        'TtBo_Cambios_EmailProv
        '
        Me.TtBo_Cambios_EmailProv.Location = New System.Drawing.Point(720, 36)
        Me.TtBo_Cambios_EmailProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_EmailProv.MaxLength = 40
        Me.TtBo_Cambios_EmailProv.Name = "TtBo_Cambios_EmailProv"
        Me.TtBo_Cambios_EmailProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Cambios_EmailProv.TabIndex = 94
        Me.TtBo_Cambios_EmailProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_RubroProv
        '
        Me.TtBo_Cambios_RubroProv.Location = New System.Drawing.Point(720, 65)
        Me.TtBo_Cambios_RubroProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_RubroProv.MaxLength = 50
        Me.TtBo_Cambios_RubroProv.Name = "TtBo_Cambios_RubroProv"
        Me.TtBo_Cambios_RubroProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Cambios_RubroProv.TabIndex = 93
        '
        'TtBo_Cambios_CuentaDepositoProv
        '
        Me.TtBo_Cambios_CuentaDepositoProv.Location = New System.Drawing.Point(720, 240)
        Me.TtBo_Cambios_CuentaDepositoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_CuentaDepositoProv.MaxLength = 20
        Me.TtBo_Cambios_CuentaDepositoProv.Name = "TtBo_Cambios_CuentaDepositoProv"
        Me.TtBo_Cambios_CuentaDepositoProv.Size = New System.Drawing.Size(240, 23)
        Me.TtBo_Cambios_CuentaDepositoProv.TabIndex = 92
        Me.TtBo_Cambios_CuentaDepositoProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Cambios_CuentaDepositoProv
        '
        Me.Lab_Cambios_CuentaDepositoProv.AutoSize = True
        Me.Lab_Cambios_CuentaDepositoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_CuentaDepositoProv.Location = New System.Drawing.Point(517, 241)
        Me.Lab_Cambios_CuentaDepositoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_CuentaDepositoProv.Name = "Lab_Cambios_CuentaDepositoProv"
        Me.Lab_Cambios_CuentaDepositoProv.Size = New System.Drawing.Size(135, 17)
        Me.Lab_Cambios_CuentaDepositoProv.TabIndex = 91
        Me.Lab_Cambios_CuentaDepositoProv.Text = "Cuenta de deposito:"
        '
        'Lab_Cambios_MonedaProv
        '
        Me.Lab_Cambios_MonedaProv.AutoSize = True
        Me.Lab_Cambios_MonedaProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_MonedaProv.Location = New System.Drawing.Point(517, 198)
        Me.Lab_Cambios_MonedaProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_MonedaProv.Name = "Lab_Cambios_MonedaProv"
        Me.Lab_Cambios_MonedaProv.Size = New System.Drawing.Size(63, 17)
        Me.Lab_Cambios_MonedaProv.TabIndex = 90
        Me.Lab_Cambios_MonedaProv.Text = "Moneda:"
        '
        'CoBo_Cambios_FormaPagoProv
        '
        Me.CoBo_Cambios_FormaPagoProv.FormattingEnabled = True
        Me.CoBo_Cambios_FormaPagoProv.Items.AddRange(New Object() {"Pagó de una sola exibición", "Depositó baconcario"})
        Me.CoBo_Cambios_FormaPagoProv.Location = New System.Drawing.Point(720, 108)
        Me.CoBo_Cambios_FormaPagoProv.Margin = New System.Windows.Forms.Padding(4)
        Me.CoBo_Cambios_FormaPagoProv.Name = "CoBo_Cambios_FormaPagoProv"
        Me.CoBo_Cambios_FormaPagoProv.Size = New System.Drawing.Size(240, 24)
        Me.CoBo_Cambios_FormaPagoProv.TabIndex = 89
        '
        'Lab_Cambios_FormaPagoProv
        '
        Me.Lab_Cambios_FormaPagoProv.AutoSize = True
        Me.Lab_Cambios_FormaPagoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_FormaPagoProv.Location = New System.Drawing.Point(517, 113)
        Me.Lab_Cambios_FormaPagoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_FormaPagoProv.Name = "Lab_Cambios_FormaPagoProv"
        Me.Lab_Cambios_FormaPagoProv.Size = New System.Drawing.Size(108, 17)
        Me.Lab_Cambios_FormaPagoProv.TabIndex = 88
        Me.Lab_Cambios_FormaPagoProv.Text = "Forma de pago:"
        '
        'Lab_Cambios_RubroProv
        '
        Me.Lab_Cambios_RubroProv.AutoSize = True
        Me.Lab_Cambios_RubroProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_RubroProv.Location = New System.Drawing.Point(517, 69)
        Me.Lab_Cambios_RubroProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_RubroProv.Name = "Lab_Cambios_RubroProv"
        Me.Lab_Cambios_RubroProv.Size = New System.Drawing.Size(83, 17)
        Me.Lab_Cambios_RubroProv.TabIndex = 87
        Me.Lab_Cambios_RubroProv.Text = "Rubro/ giro:"
        '
        'Lab_Cambios_EmailProv
        '
        Me.Lab_Cambios_EmailProv.AutoSize = True
        Me.Lab_Cambios_EmailProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_EmailProv.Location = New System.Drawing.Point(517, 36)
        Me.Lab_Cambios_EmailProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_EmailProv.Name = "Lab_Cambios_EmailProv"
        Me.Lab_Cambios_EmailProv.Size = New System.Drawing.Size(46, 17)
        Me.Lab_Cambios_EmailProv.TabIndex = 86
        Me.Lab_Cambios_EmailProv.Text = "Email:"
        '
        'Lab_Cambios_TelefDosProv
        '
        Me.Lab_Cambios_TelefDosProv.AutoSize = True
        Me.Lab_Cambios_TelefDosProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_TelefDosProv.Location = New System.Drawing.Point(27, 405)
        Me.Lab_Cambios_TelefDosProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_TelefDosProv.Name = "Lab_Cambios_TelefDosProv"
        Me.Lab_Cambios_TelefDosProv.Size = New System.Drawing.Size(80, 17)
        Me.Lab_Cambios_TelefDosProv.TabIndex = 85
        Me.Lab_Cambios_TelefDosProv.Text = "Teléfono 2:"
        '
        'Lab_Cambios_TelefUnoProv
        '
        Me.Lab_Cambios_TelefUnoProv.AutoSize = True
        Me.Lab_Cambios_TelefUnoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_TelefUnoProv.Location = New System.Drawing.Point(27, 368)
        Me.Lab_Cambios_TelefUnoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_TelefUnoProv.Name = "Lab_Cambios_TelefUnoProv"
        Me.Lab_Cambios_TelefUnoProv.Size = New System.Drawing.Size(80, 17)
        Me.Lab_Cambios_TelefUnoProv.TabIndex = 84
        Me.Lab_Cambios_TelefUnoProv.Text = "Teléfono 1:"
        '
        'Lab_Cambios_EstadoProv
        '
        Me.Lab_Cambios_EstadoProv.AutoSize = True
        Me.Lab_Cambios_EstadoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_EstadoProv.Location = New System.Drawing.Point(27, 332)
        Me.Lab_Cambios_EstadoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_EstadoProv.Name = "Lab_Cambios_EstadoProv"
        Me.Lab_Cambios_EstadoProv.Size = New System.Drawing.Size(56, 17)
        Me.Lab_Cambios_EstadoProv.TabIndex = 83
        Me.Lab_Cambios_EstadoProv.Text = "Estado:"
        '
        'Lab_Cambios_ColoniaProv
        '
        Me.Lab_Cambios_ColoniaProv.AutoSize = True
        Me.Lab_Cambios_ColoniaProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_ColoniaProv.Location = New System.Drawing.Point(27, 265)
        Me.Lab_Cambios_ColoniaProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_ColoniaProv.Name = "Lab_Cambios_ColoniaProv"
        Me.Lab_Cambios_ColoniaProv.Size = New System.Drawing.Size(142, 17)
        Me.Lab_Cambios_ColoniaProv.TabIndex = 82
        Me.Lab_Cambios_ColoniaProv.Text = "Colonia / Delegación:"
        '
        'Lab_Cambios_CpProv
        '
        Me.Lab_Cambios_CpProv.AutoSize = True
        Me.Lab_Cambios_CpProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_CpProv.Location = New System.Drawing.Point(27, 230)
        Me.Lab_Cambios_CpProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_CpProv.Name = "Lab_Cambios_CpProv"
        Me.Lab_Cambios_CpProv.Size = New System.Drawing.Size(30, 17)
        Me.Lab_Cambios_CpProv.TabIndex = 81
        Me.Lab_Cambios_CpProv.Text = "CP:"
        '
        'Lab_Cambios_NumInteriorProv
        '
        Me.Lab_Cambios_NumInteriorProv.AutoSize = True
        Me.Lab_Cambios_NumInteriorProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_NumInteriorProv.Location = New System.Drawing.Point(27, 193)
        Me.Lab_Cambios_NumInteriorProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_NumInteriorProv.Name = "Lab_Cambios_NumInteriorProv"
        Me.Lab_Cambios_NumInteriorProv.Size = New System.Drawing.Size(110, 17)
        Me.Lab_Cambios_NumInteriorProv.TabIndex = 80
        Me.Lab_Cambios_NumInteriorProv.Text = "Número interior:"
        '
        'Lab_Cambios_NumExteriorProv
        '
        Me.Lab_Cambios_NumExteriorProv.AutoSize = True
        Me.Lab_Cambios_NumExteriorProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_NumExteriorProv.Location = New System.Drawing.Point(27, 155)
        Me.Lab_Cambios_NumExteriorProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_NumExteriorProv.Name = "Lab_Cambios_NumExteriorProv"
        Me.Lab_Cambios_NumExteriorProv.Size = New System.Drawing.Size(113, 17)
        Me.Lab_Cambios_NumExteriorProv.TabIndex = 79
        Me.Lab_Cambios_NumExteriorProv.Text = "Número exterior:"
        '
        'TtBo_Cambios_CalleProv
        '
        Me.TtBo_Cambios_CalleProv.Enabled = False
        Me.TtBo_Cambios_CalleProv.Location = New System.Drawing.Point(253, 110)
        Me.TtBo_Cambios_CalleProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_CalleProv.MaxLength = 30
        Me.TtBo_Cambios_CalleProv.Name = "TtBo_Cambios_CalleProv"
        Me.TtBo_Cambios_CalleProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_CalleProv.TabIndex = 78
        Me.TtBo_Cambios_CalleProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Cambios_CalleProv
        '
        Me.Lab_Cambios_CalleProv.AutoSize = True
        Me.Lab_Cambios_CalleProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_CalleProv.Location = New System.Drawing.Point(27, 113)
        Me.Lab_Cambios_CalleProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_CalleProv.Name = "Lab_Cambios_CalleProv"
        Me.Lab_Cambios_CalleProv.Size = New System.Drawing.Size(43, 17)
        Me.Lab_Cambios_CalleProv.TabIndex = 77
        Me.Lab_Cambios_CalleProv.Text = "Calle:"
        '
        'TtBo_Cambios_RfcProv
        '
        Me.TtBo_Cambios_RfcProv.Location = New System.Drawing.Point(253, 69)
        Me.TtBo_Cambios_RfcProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_RfcProv.MaxLength = 20
        Me.TtBo_Cambios_RfcProv.Name = "TtBo_Cambios_RfcProv"
        Me.TtBo_Cambios_RfcProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_RfcProv.TabIndex = 76
        Me.TtBo_Cambios_RfcProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_Cambios_NombProv
        '
        Me.TtBo_Cambios_NombProv.Location = New System.Drawing.Point(253, 36)
        Me.TtBo_Cambios_NombProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Cambios_NombProv.MaxLength = 80
        Me.TtBo_Cambios_NombProv.Name = "TtBo_Cambios_NombProv"
        Me.TtBo_Cambios_NombProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Cambios_NombProv.TabIndex = 75
        Me.TtBo_Cambios_NombProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Cambios_RfcProv
        '
        Me.Lab_Cambios_RfcProv.AutoSize = True
        Me.Lab_Cambios_RfcProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_RfcProv.Location = New System.Drawing.Point(25, 69)
        Me.Lab_Cambios_RfcProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_RfcProv.Name = "Lab_Cambios_RfcProv"
        Me.Lab_Cambios_RfcProv.Size = New System.Drawing.Size(39, 17)
        Me.Lab_Cambios_RfcProv.TabIndex = 74
        Me.Lab_Cambios_RfcProv.Text = "RFC:"
        '
        'Lab_Cambios_NombProv
        '
        Me.Lab_Cambios_NombProv.AutoSize = True
        Me.Lab_Cambios_NombProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_NombProv.Location = New System.Drawing.Point(27, 36)
        Me.Lab_Cambios_NombProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Cambios_NombProv.Name = "Lab_Cambios_NombProv"
        Me.Lab_Cambios_NombProv.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Cambios_NombProv.TabIndex = 73
        Me.Lab_Cambios_NombProv.Text = "Nombre o razón social:"
        '
        'Baja_Proveedores
        '
        Me.Baja_Proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baja_Proveedores.Controls.Add(Me.Btn_Baja_Limpiar)
        Me.Baja_Proveedores.Controls.Add(Me.Btn_Baja_Eliminar)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_PreBaja_ColoniaProv)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_PreBaja_CpProv)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_PreBaja_NumbExterior)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_PreBaja_RubroProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_PreBaja_RubroProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_PreBaja_ColoniaProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_PreBaja_CpProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_PreBaja_NumExteriorProv)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_PreBaja_CalleProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_PreBaja_CalleProv)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_PreBaja_RfcProv)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_PreBaja_NombProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_PreBaja_RfcProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_PreBaja_NombProv)
        Me.Baja_Proveedores.Controls.Add(Me.Btn_Baja_Buscar)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_Baja_RfcProv)
        Me.Baja_Proveedores.Controls.Add(Me.TtBo_Baja_NombProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_Baja_RfcProv)
        Me.Baja_Proveedores.Controls.Add(Me.Lab_Baja_NombProv)
        Me.Baja_Proveedores.Location = New System.Drawing.Point(4, 25)
        Me.Baja_Proveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.Baja_Proveedores.Name = "Baja_Proveedores"
        Me.Baja_Proveedores.Padding = New System.Windows.Forms.Padding(4)
        Me.Baja_Proveedores.Size = New System.Drawing.Size(1027, 441)
        Me.Baja_Proveedores.TabIndex = 1
        Me.Baja_Proveedores.Text = "Baja de proveedor"
        '
        'Btn_Baja_Limpiar
        '
        Me.Btn_Baja_Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Baja_Limpiar.Location = New System.Drawing.Point(732, 249)
        Me.Btn_Baja_Limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Baja_Limpiar.Name = "Btn_Baja_Limpiar"
        Me.Btn_Baja_Limpiar.Size = New System.Drawing.Size(92, 31)
        Me.Btn_Baja_Limpiar.TabIndex = 110
        Me.Btn_Baja_Limpiar.Text = "Limpiar"
        Me.Btn_Baja_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Baja_Eliminar
        '
        Me.Btn_Baja_Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Baja_Eliminar.Location = New System.Drawing.Point(832, 249)
        Me.Btn_Baja_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Baja_Eliminar.Name = "Btn_Baja_Eliminar"
        Me.Btn_Baja_Eliminar.Size = New System.Drawing.Size(119, 31)
        Me.Btn_Baja_Eliminar.TabIndex = 109
        Me.Btn_Baja_Eliminar.Text = "Eliminar"
        Me.Btn_Baja_Eliminar.UseVisualStyleBackColor = False
        '
        'TtBo_PreBaja_ColoniaProv
        '
        Me.TtBo_PreBaja_ColoniaProv.Location = New System.Drawing.Point(732, 185)
        Me.TtBo_PreBaja_ColoniaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_PreBaja_ColoniaProv.MaxLength = 50
        Me.TtBo_PreBaja_ColoniaProv.Name = "TtBo_PreBaja_ColoniaProv"
        Me.TtBo_PreBaja_ColoniaProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_PreBaja_ColoniaProv.TabIndex = 108
        Me.TtBo_PreBaja_ColoniaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_PreBaja_CpProv
        '
        Me.TtBo_PreBaja_CpProv.Location = New System.Drawing.Point(732, 148)
        Me.TtBo_PreBaja_CpProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_PreBaja_CpProv.MaxLength = 5
        Me.TtBo_PreBaja_CpProv.Name = "TtBo_PreBaja_CpProv"
        Me.TtBo_PreBaja_CpProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_PreBaja_CpProv.TabIndex = 107
        Me.TtBo_PreBaja_CpProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_PreBaja_NumbExterior
        '
        Me.TtBo_PreBaja_NumbExterior.Location = New System.Drawing.Point(273, 267)
        Me.TtBo_PreBaja_NumbExterior.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_PreBaja_NumbExterior.MaxLength = 5
        Me.TtBo_PreBaja_NumbExterior.Name = "TtBo_PreBaja_NumbExterior"
        Me.TtBo_PreBaja_NumbExterior.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_PreBaja_NumbExterior.TabIndex = 106
        Me.TtBo_PreBaja_NumbExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_PreBaja_RubroProv
        '
        Me.TtBo_PreBaja_RubroProv.Location = New System.Drawing.Point(732, 217)
        Me.TtBo_PreBaja_RubroProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_PreBaja_RubroProv.MaxLength = 50
        Me.TtBo_PreBaja_RubroProv.Name = "TtBo_PreBaja_RubroProv"
        Me.TtBo_PreBaja_RubroProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_PreBaja_RubroProv.TabIndex = 105
        Me.TtBo_PreBaja_RubroProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_PreBaja_RubroProv
        '
        Me.Lab_PreBaja_RubroProv.AutoSize = True
        Me.Lab_PreBaja_RubroProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_PreBaja_RubroProv.Location = New System.Drawing.Point(505, 220)
        Me.Lab_PreBaja_RubroProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_PreBaja_RubroProv.Name = "Lab_PreBaja_RubroProv"
        Me.Lab_PreBaja_RubroProv.Size = New System.Drawing.Size(83, 17)
        Me.Lab_PreBaja_RubroProv.TabIndex = 104
        Me.Lab_PreBaja_RubroProv.Text = "Rubro/ giro:"
        '
        'Lab_PreBaja_ColoniaProv
        '
        Me.Lab_PreBaja_ColoniaProv.AutoSize = True
        Me.Lab_PreBaja_ColoniaProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_PreBaja_ColoniaProv.Location = New System.Drawing.Point(505, 186)
        Me.Lab_PreBaja_ColoniaProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_PreBaja_ColoniaProv.Name = "Lab_PreBaja_ColoniaProv"
        Me.Lab_PreBaja_ColoniaProv.Size = New System.Drawing.Size(142, 17)
        Me.Lab_PreBaja_ColoniaProv.TabIndex = 103
        Me.Lab_PreBaja_ColoniaProv.Text = "Colonia / Delegación:"
        '
        'Lab_PreBaja_CpProv
        '
        Me.Lab_PreBaja_CpProv.AutoSize = True
        Me.Lab_PreBaja_CpProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_PreBaja_CpProv.Location = New System.Drawing.Point(505, 151)
        Me.Lab_PreBaja_CpProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_PreBaja_CpProv.Name = "Lab_PreBaja_CpProv"
        Me.Lab_PreBaja_CpProv.Size = New System.Drawing.Size(30, 17)
        Me.Lab_PreBaja_CpProv.TabIndex = 102
        Me.Lab_PreBaja_CpProv.Text = "CP:"
        '
        'Lab_PreBaja_NumExteriorProv
        '
        Me.Lab_PreBaja_NumExteriorProv.AutoSize = True
        Me.Lab_PreBaja_NumExteriorProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_PreBaja_NumExteriorProv.Location = New System.Drawing.Point(47, 268)
        Me.Lab_PreBaja_NumExteriorProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_PreBaja_NumExteriorProv.Name = "Lab_PreBaja_NumExteriorProv"
        Me.Lab_PreBaja_NumExteriorProv.Size = New System.Drawing.Size(113, 17)
        Me.Lab_PreBaja_NumExteriorProv.TabIndex = 101
        Me.Lab_PreBaja_NumExteriorProv.Text = "Número exterior:"
        '
        'TtBo_PreBaja_CalleProv
        '
        Me.TtBo_PreBaja_CalleProv.Enabled = False
        Me.TtBo_PreBaja_CalleProv.Location = New System.Drawing.Point(273, 223)
        Me.TtBo_PreBaja_CalleProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_PreBaja_CalleProv.MaxLength = 30
        Me.TtBo_PreBaja_CalleProv.Name = "TtBo_PreBaja_CalleProv"
        Me.TtBo_PreBaja_CalleProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_PreBaja_CalleProv.TabIndex = 100
        Me.TtBo_PreBaja_CalleProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_PreBaja_CalleProv
        '
        Me.Lab_PreBaja_CalleProv.AutoSize = True
        Me.Lab_PreBaja_CalleProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_PreBaja_CalleProv.Location = New System.Drawing.Point(47, 226)
        Me.Lab_PreBaja_CalleProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_PreBaja_CalleProv.Name = "Lab_PreBaja_CalleProv"
        Me.Lab_PreBaja_CalleProv.Size = New System.Drawing.Size(43, 17)
        Me.Lab_PreBaja_CalleProv.TabIndex = 99
        Me.Lab_PreBaja_CalleProv.Text = "Calle:"
        '
        'TtBo_PreBaja_RfcProv
        '
        Me.TtBo_PreBaja_RfcProv.Location = New System.Drawing.Point(273, 182)
        Me.TtBo_PreBaja_RfcProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_PreBaja_RfcProv.MaxLength = 20
        Me.TtBo_PreBaja_RfcProv.Name = "TtBo_PreBaja_RfcProv"
        Me.TtBo_PreBaja_RfcProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_PreBaja_RfcProv.TabIndex = 98
        Me.TtBo_PreBaja_RfcProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TtBo_PreBaja_NombProv
        '
        Me.TtBo_PreBaja_NombProv.Location = New System.Drawing.Point(273, 149)
        Me.TtBo_PreBaja_NombProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_PreBaja_NombProv.MaxLength = 80
        Me.TtBo_PreBaja_NombProv.Name = "TtBo_PreBaja_NombProv"
        Me.TtBo_PreBaja_NombProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_PreBaja_NombProv.TabIndex = 97
        Me.TtBo_PreBaja_NombProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_PreBaja_RfcProv
        '
        Me.Lab_PreBaja_RfcProv.AutoSize = True
        Me.Lab_PreBaja_RfcProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_PreBaja_RfcProv.Location = New System.Drawing.Point(47, 182)
        Me.Lab_PreBaja_RfcProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_PreBaja_RfcProv.Name = "Lab_PreBaja_RfcProv"
        Me.Lab_PreBaja_RfcProv.Size = New System.Drawing.Size(39, 17)
        Me.Lab_PreBaja_RfcProv.TabIndex = 96
        Me.Lab_PreBaja_RfcProv.Text = "RFC:"
        '
        'Lab_PreBaja_NombProv
        '
        Me.Lab_PreBaja_NombProv.AutoSize = True
        Me.Lab_PreBaja_NombProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_PreBaja_NombProv.Location = New System.Drawing.Point(47, 149)
        Me.Lab_PreBaja_NombProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_PreBaja_NombProv.Name = "Lab_PreBaja_NombProv"
        Me.Lab_PreBaja_NombProv.Size = New System.Drawing.Size(154, 17)
        Me.Lab_PreBaja_NombProv.TabIndex = 95
        Me.Lab_PreBaja_NombProv.Text = "Nombre o razón social:"
        '
        'Btn_Baja_Buscar
        '
        Me.Btn_Baja_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Baja_Buscar.Location = New System.Drawing.Point(548, 95)
        Me.Btn_Baja_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Baja_Buscar.Name = "Btn_Baja_Buscar"
        Me.Btn_Baja_Buscar.Size = New System.Drawing.Size(179, 31)
        Me.Btn_Baja_Buscar.TabIndex = 94
        Me.Btn_Baja_Buscar.Text = "Buscar"
        Me.Btn_Baja_Buscar.UseVisualStyleBackColor = False
        '
        'TtBo_Baja_RfcProv
        '
        Me.TtBo_Baja_RfcProv.Location = New System.Drawing.Point(535, 63)
        Me.TtBo_Baja_RfcProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Baja_RfcProv.Name = "TtBo_Baja_RfcProv"
        Me.TtBo_Baja_RfcProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Baja_RfcProv.TabIndex = 93
        '
        'TtBo_Baja_NombProv
        '
        Me.TtBo_Baja_NombProv.Location = New System.Drawing.Point(535, 30)
        Me.TtBo_Baja_NombProv.Margin = New System.Windows.Forms.Padding(4)
        Me.TtBo_Baja_NombProv.Name = "TtBo_Baja_NombProv"
        Me.TtBo_Baja_NombProv.Size = New System.Drawing.Size(217, 23)
        Me.TtBo_Baja_NombProv.TabIndex = 92
        '
        'Lab_Baja_RfcProv
        '
        Me.Lab_Baja_RfcProv.AutoSize = True
        Me.Lab_Baja_RfcProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Baja_RfcProv.Location = New System.Drawing.Point(308, 63)
        Me.Lab_Baja_RfcProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Baja_RfcProv.Name = "Lab_Baja_RfcProv"
        Me.Lab_Baja_RfcProv.Size = New System.Drawing.Size(39, 17)
        Me.Lab_Baja_RfcProv.TabIndex = 91
        Me.Lab_Baja_RfcProv.Text = "RFC:"
        '
        'Lab_Baja_NombProv
        '
        Me.Lab_Baja_NombProv.AutoSize = True
        Me.Lab_Baja_NombProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Baja_NombProv.Location = New System.Drawing.Point(308, 30)
        Me.Lab_Baja_NombProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_Baja_NombProv.Name = "Lab_Baja_NombProv"
        Me.Lab_Baja_NombProv.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Baja_NombProv.TabIndex = 90
        Me.Lab_Baja_NombProv.Text = "Nombre o razón social:"
        '
        'Form_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Tab_Ctr_Proveedor)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_Proveedor.ResumeLayout(False)
        Me.Alta_Proveedores.ResumeLayout(False)
        Me.Alta_Proveedores.PerformLayout()
        Me.Consulta_Proveedores.ResumeLayout(False)
        Me.Consulta_Proveedores.PerformLayout()
        CType(Me.DGV_ListaProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cambio_Proveedor.ResumeLayout(False)
        Me.Cambio_Proveedor.PerformLayout()
        Me.Baja_Proveedores.ResumeLayout(False)
        Me.Baja_Proveedores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_atras As Button
    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tab_Ctr_Proveedor As TabControl
    Friend WithEvents Alta_Proveedores As TabPage
    Friend WithEvents Consulta_Proveedores As TabPage
    Friend WithEvents Cambio_Proveedor As TabPage
    Friend WithEvents Baja_Proveedores As TabPage
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Alta_Limpiar As Button
    Friend WithEvents Btn_Alta_Guardar As Button
    Friend WithEvents CoBo_Alta_EstadoProv As ComboBox
    Friend WithEvents TtBo_Alta_TelefDosProv As TextBox
    Friend WithEvents TtBo_Alta_TelefUnoProv As TextBox
    Friend WithEvents TtBo_Alta_ColoniaProv As TextBox
    Friend WithEvents TtBo_Alta_CpProv As TextBox
    Friend WithEvents TtBo_Alta_NumInteriorProv As TextBox
    Friend WithEvents TtBo_Alta_NumExteriorProv As TextBox
    Friend WithEvents TtBo_Alta_DescripProv As TextBox
    Friend WithEvents Lab_Alta_DescripProv As Label
    Friend WithEvents TtBo_Alta_SecuenciaProv As TextBox
    Friend WithEvents Lab_Alta_SecuenciaProv As Label
    Friend WithEvents CoBo_Alta_MonedaProv As ComboBox
    Friend WithEvents TtBo_Alta_EmailProv As TextBox
    Friend WithEvents TtBo_Alta_RubroProv As TextBox
    Friend WithEvents TtBo_Alta_CuentaDepositoProv As TextBox
    Friend WithEvents Lab_Alta_CuentaDepositoProv As Label
    Friend WithEvents Lab_Alta_MonedaProv As Label
    Friend WithEvents CoBo_Alta_FormaPagoProv As ComboBox
    Friend WithEvents Lab_Alta_FormaPagoProv As Label
    Friend WithEvents Lab_Alta_RubroProv As Label
    Friend WithEvents Lab_Alta_EmailProv As Label
    Friend WithEvents Lab_Alta_TelefDosProv As Label
    Friend WithEvents Lab_Alta_TelefUnoProv As Label
    Friend WithEvents Lab_Alta_EstadoProv As Label
    Friend WithEvents Lab_Alta_ColoniaProv As Label
    Friend WithEvents Lab_Alta_CpProv As Label
    Friend WithEvents Lab_Alta_NumInteriorProv As Label
    Friend WithEvents Lab_Alta_NumExteriorProv As Label
    Friend WithEvents TtBo_Alta_CalleProv As TextBox
    Friend WithEvents Lab_Alta_CalleProv As Label
    Friend WithEvents TtBo_Alta_RfcProv As TextBox
    Friend WithEvents TtBo_Alta_NombProv As TextBox
    Friend WithEvents Lab_Alta_RfcProv As Label
    Friend WithEvents Lab_Alta_NombProv As Label
    Friend WithEvents DGV_ListaProv As DataGridView
    Friend WithEvents DVG_ID_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_NombORazonS_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Direcc_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Telefono_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Email_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_RubroOGiro_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_FormaP_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Secuencia_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Moneda_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_CuentaDep_Prov As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Descp_Prov As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Consulta_BuscarProv As Button
    Friend WithEvents Lab_Consulta_RfcProv As Label
    Friend WithEvents Lab_Consulta_NombProv As Label
    Friend WithEvents Btn_Cambios_Limpiar As Button
    Friend WithEvents Btn_Cambios_Buscar As Button
    Friend WithEvents CoBo_Cambios_EstadoProv As ComboBox
    Friend WithEvents TtBo_Cambios_TelefDosProv As TextBox
    Friend WithEvents TtBo_Cambios_TelefUnoProv As TextBox
    Friend WithEvents TtBo_Cambios_ColoniaProv As TextBox
    Friend WithEvents TtBo_Cambios_CpProv As TextBox
    Friend WithEvents TtBo_Cambios_NumInteriorProv As TextBox
    Friend WithEvents TtBo_Cambios_NumExteriorProv As TextBox
    Friend WithEvents TtBo_Cambios_DescripProv As TextBox
    Friend WithEvents Lab_Cambios_DescripProv As Label
    Friend WithEvents TtBo_Cambios_SecuenciaProv As TextBox
    Friend WithEvents Lab_Cambios_SecuenciaProv As Label
    Friend WithEvents CoBo_Cambios_MonedaProv As ComboBox
    Friend WithEvents TtBo_Cambios_EmailProv As TextBox
    Friend WithEvents TtBo_Cambios_RubroProv As TextBox
    Friend WithEvents TtBo_Cambios_CuentaDepositoProv As TextBox
    Friend WithEvents Lab_Cambios_CuentaDepositoProv As Label
    Friend WithEvents Lab_Cambios_MonedaProv As Label
    Friend WithEvents CoBo_Cambios_FormaPagoProv As ComboBox
    Friend WithEvents Lab_Cambios_FormaPagoProv As Label
    Friend WithEvents Lab_Cambios_RubroProv As Label
    Friend WithEvents Lab_Cambios_EmailProv As Label
    Friend WithEvents Lab_Cambios_TelefDosProv As Label
    Friend WithEvents Lab_Cambios_TelefUnoProv As Label
    Friend WithEvents Lab_Cambios_EstadoProv As Label
    Friend WithEvents Lab_Cambios_ColoniaProv As Label
    Friend WithEvents Lab_Cambios_CpProv As Label
    Friend WithEvents Lab_Cambios_NumInteriorProv As Label
    Friend WithEvents Lab_Cambios_NumExteriorProv As Label
    Friend WithEvents TtBo_Cambios_CalleProv As TextBox
    Friend WithEvents Lab_Cambios_CalleProv As Label
    Friend WithEvents TtBo_Cambios_RfcProv As TextBox
    Friend WithEvents TtBo_Cambios_NombProv As TextBox
    Friend WithEvents Lab_Cambios_RfcProv As Label
    Friend WithEvents Lab_Cambios_NombProv As Label
    Friend WithEvents Btn_Baja_Limpiar As Button
    Friend WithEvents Btn_Baja_Eliminar As Button
    Friend WithEvents TtBo_PreBaja_ColoniaProv As TextBox
    Friend WithEvents TtBo_PreBaja_CpProv As TextBox
    Friend WithEvents TtBo_PreBaja_NumbExterior As TextBox
    Friend WithEvents TtBo_PreBaja_RubroProv As TextBox
    Friend WithEvents Lab_PreBaja_RubroProv As Label
    Friend WithEvents Lab_PreBaja_ColoniaProv As Label
    Friend WithEvents Lab_PreBaja_CpProv As Label
    Friend WithEvents Lab_PreBaja_NumExteriorProv As Label
    Friend WithEvents TtBo_PreBaja_CalleProv As TextBox
    Friend WithEvents Lab_PreBaja_CalleProv As Label
    Friend WithEvents TtBo_PreBaja_RfcProv As TextBox
    Friend WithEvents TtBo_PreBaja_NombProv As TextBox
    Friend WithEvents Lab_PreBaja_RfcProv As Label
    Friend WithEvents Lab_PreBaja_NombProv As Label
    Friend WithEvents Btn_Baja_Buscar As Button
    Friend WithEvents TtBo_Baja_RfcProv As TextBox
    Friend WithEvents TtBo_Baja_NombProv As TextBox
    Friend WithEvents Lab_Baja_RfcProv As Label
    Friend WithEvents Lab_Baja_NombProv As Label
    Friend WithEvents TtBo_Consulta_RfcProv As TextBox
    Friend WithEvents TtBo_Consulta_NombProv As TextBox
    Friend WithEvents Btn_Consulta_BuscarTodo As Button
    Friend WithEvents TtBo_Alta_MpioProv As TextBox
    Friend WithEvents Lab_Alta_MpioProv As Label
    Friend WithEvents TtBo_Cambios_mpioProv As TextBox
    Friend WithEvents Lab_Cambios_MpioProv As Label
End Class
