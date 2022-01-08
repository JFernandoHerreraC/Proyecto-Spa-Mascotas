<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CorteCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CorteCaja))
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_Ctr_CorteCaja = New System.Windows.Forms.TabControl()
        Me.Alta_CorteCajaFinal = New System.Windows.Forms.TabPage()
        Me.GrBo_DatosCorteCaja = New System.Windows.Forms.GroupBox()
        Me.TtBo_CCaja_NombCajero = New System.Windows.Forms.TextBox()
        Me.Lab_CCaja_NombCajero = New System.Windows.Forms.Label()
        Me.TtBo_CCaja_DineroJornadaInicial = New System.Windows.Forms.TextBox()
        Me.Lab_CCaja_DineroJornadaInicial = New System.Windows.Forms.Label()
        Me.Btn_CCaja_CorteDeCaja = New System.Windows.Forms.Button()
        Me.Lab_CCaja_AlgunaSalidaCaja = New System.Windows.Forms.Label()
        Me.TtBo_CCaja_SalidaCaja = New System.Windows.Forms.TextBox()
        Me.GrBo_InformacionCorteCaja = New System.Windows.Forms.GroupBox()
        Me.Lab_CCaja_HoraDerecha = New System.Windows.Forms.Label()
        Me.Lab_CCaja_FechaDerecha = New System.Windows.Forms.Label()
        Me.Lab_CCaja_InfHora = New System.Windows.Forms.Label()
        Me.Lab_CCaja_InfFecha = New System.Windows.Forms.Label()
        Me.TtBo_CCaja_InfTotal = New System.Windows.Forms.TextBox()
        Me.Lab_CCaja_InfTotal = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TtBo_CCaja_InfSubtotal = New System.Windows.Forms.TextBox()
        Me.TtBo_CCaja_InfSalidaDinero = New System.Windows.Forms.TextBox()
        Me.TtBo_CCaja_InfDineroInicial = New System.Windows.Forms.TextBox()
        Me.Lab_CCaja_InfSubtotal = New System.Windows.Forms.Label()
        Me.Lab_CCaja_InfSalidaDinero = New System.Windows.Forms.Label()
        Me.Lab_CCaja_InfDimeroInicial = New System.Windows.Forms.Label()
        Me.Lab_CCaja_Titulo = New System.Windows.Forms.Label()
        Me.Consulta_CorteCajaHist = New System.Windows.Forms.TabPage()
        Me.Btn_HCCaja_Buscar = New System.Windows.Forms.Button()
        Me.DGV_ListaCCajas = New System.Windows.Forms.DataGridView()
        Me.DGV_ID_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_FECHA_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_HORA_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_DnInic_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_SalCaja_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TOTAL_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NOMBCAJERO_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaTiPi_HCCaja_SeleccionFecha = New System.Windows.Forms.DateTimePicker()
        Me.Lab_HCCaja_SeleccionFecha = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_HCCaja_BuscarTodo = New System.Windows.Forms.Button()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_CorteCaja.SuspendLayout()
        Me.Alta_CorteCajaFinal.SuspendLayout()
        Me.GrBo_DatosCorteCaja.SuspendLayout()
        Me.GrBo_InformacionCorteCaja.SuspendLayout()
        Me.Consulta_CorteCajaHist.SuspendLayout()
        CType(Me.DGV_ListaCCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem})
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
        'Tab_Ctr_CorteCaja
        '
        Me.Tab_Ctr_CorteCaja.Controls.Add(Me.Alta_CorteCajaFinal)
        Me.Tab_Ctr_CorteCaja.Controls.Add(Me.Consulta_CorteCajaHist)
        Me.Tab_Ctr_CorteCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Tab_Ctr_CorteCaja.Location = New System.Drawing.Point(12, 61)
        Me.Tab_Ctr_CorteCaja.Name = "Tab_Ctr_CorteCaja"
        Me.Tab_Ctr_CorteCaja.SelectedIndex = 0
        Me.Tab_Ctr_CorteCaja.Size = New System.Drawing.Size(776, 377)
        Me.Tab_Ctr_CorteCaja.TabIndex = 2
        '
        'Alta_CorteCajaFinal
        '
        Me.Alta_CorteCajaFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_CorteCajaFinal.Controls.Add(Me.GrBo_DatosCorteCaja)
        Me.Alta_CorteCajaFinal.Controls.Add(Me.GrBo_InformacionCorteCaja)
        Me.Alta_CorteCajaFinal.Controls.Add(Me.Lab_CCaja_Titulo)
        Me.Alta_CorteCajaFinal.Location = New System.Drawing.Point(4, 25)
        Me.Alta_CorteCajaFinal.Name = "Alta_CorteCajaFinal"
        Me.Alta_CorteCajaFinal.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_CorteCajaFinal.Size = New System.Drawing.Size(768, 348)
        Me.Alta_CorteCajaFinal.TabIndex = 1
        Me.Alta_CorteCajaFinal.Text = "Carte de caja final"
        '
        'GrBo_DatosCorteCaja
        '
        Me.GrBo_DatosCorteCaja.Controls.Add(Me.TtBo_CCaja_NombCajero)
        Me.GrBo_DatosCorteCaja.Controls.Add(Me.Lab_CCaja_NombCajero)
        Me.GrBo_DatosCorteCaja.Controls.Add(Me.TtBo_CCaja_DineroJornadaInicial)
        Me.GrBo_DatosCorteCaja.Controls.Add(Me.Lab_CCaja_DineroJornadaInicial)
        Me.GrBo_DatosCorteCaja.Controls.Add(Me.Btn_CCaja_CorteDeCaja)
        Me.GrBo_DatosCorteCaja.Controls.Add(Me.Lab_CCaja_AlgunaSalidaCaja)
        Me.GrBo_DatosCorteCaja.Controls.Add(Me.TtBo_CCaja_SalidaCaja)
        Me.GrBo_DatosCorteCaja.Location = New System.Drawing.Point(45, 36)
        Me.GrBo_DatosCorteCaja.Name = "GrBo_DatosCorteCaja"
        Me.GrBo_DatosCorteCaja.Size = New System.Drawing.Size(667, 159)
        Me.GrBo_DatosCorteCaja.TabIndex = 8
        Me.GrBo_DatosCorteCaja.TabStop = False
        Me.GrBo_DatosCorteCaja.Text = "Datos para el corte de caja"
        '
        'TtBo_CCaja_NombCajero
        '
        Me.TtBo_CCaja_NombCajero.Location = New System.Drawing.Point(258, 99)
        Me.TtBo_CCaja_NombCajero.Name = "TtBo_CCaja_NombCajero"
        Me.TtBo_CCaja_NombCajero.Size = New System.Drawing.Size(161, 23)
        Me.TtBo_CCaja_NombCajero.TabIndex = 8
        '
        'Lab_CCaja_NombCajero
        '
        Me.Lab_CCaja_NombCajero.AutoSize = True
        Me.Lab_CCaja_NombCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_NombCajero.Location = New System.Drawing.Point(6, 99)
        Me.Lab_CCaja_NombCajero.Name = "Lab_CCaja_NombCajero"
        Me.Lab_CCaja_NombCajero.Size = New System.Drawing.Size(120, 16)
        Me.Lab_CCaja_NombCajero.TabIndex = 7
        Me.Lab_CCaja_NombCajero.Text = "Nombre del cajero"
        '
        'TtBo_CCaja_DineroJornadaInicial
        '
        Me.TtBo_CCaja_DineroJornadaInicial.Location = New System.Drawing.Point(258, 41)
        Me.TtBo_CCaja_DineroJornadaInicial.Name = "TtBo_CCaja_DineroJornadaInicial"
        Me.TtBo_CCaja_DineroJornadaInicial.Size = New System.Drawing.Size(161, 23)
        Me.TtBo_CCaja_DineroJornadaInicial.TabIndex = 3
        Me.TtBo_CCaja_DineroJornadaInicial.TabStop = False
        '
        'Lab_CCaja_DineroJornadaInicial
        '
        Me.Lab_CCaja_DineroJornadaInicial.AutoSize = True
        Me.Lab_CCaja_DineroJornadaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_DineroJornadaInicial.Location = New System.Drawing.Point(6, 42)
        Me.Lab_CCaja_DineroJornadaInicial.Name = "Lab_CCaja_DineroJornadaInicial"
        Me.Lab_CCaja_DineroJornadaInicial.Size = New System.Drawing.Size(246, 16)
        Me.Lab_CCaja_DineroJornadaInicial.TabIndex = 2
        Me.Lab_CCaja_DineroJornadaInicial.Text = "¿Con cuanto inicio su jornada de cobro?"
        '
        'Btn_CCaja_CorteDeCaja
        '
        Me.Btn_CCaja_CorteDeCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_CCaja_CorteDeCaja.Location = New System.Drawing.Point(258, 125)
        Me.Btn_CCaja_CorteDeCaja.Name = "Btn_CCaja_CorteDeCaja"
        Me.Btn_CCaja_CorteDeCaja.Size = New System.Drawing.Size(161, 23)
        Me.Btn_CCaja_CorteDeCaja.TabIndex = 6
        Me.Btn_CCaja_CorteDeCaja.Text = "Corte de caja"
        Me.Btn_CCaja_CorteDeCaja.UseVisualStyleBackColor = False
        '
        'Lab_CCaja_AlgunaSalidaCaja
        '
        Me.Lab_CCaja_AlgunaSalidaCaja.AutoSize = True
        Me.Lab_CCaja_AlgunaSalidaCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_AlgunaSalidaCaja.Location = New System.Drawing.Point(6, 70)
        Me.Lab_CCaja_AlgunaSalidaCaja.Name = "Lab_CCaja_AlgunaSalidaCaja"
        Me.Lab_CCaja_AlgunaSalidaCaja.Size = New System.Drawing.Size(187, 16)
        Me.Lab_CCaja_AlgunaSalidaCaja.TabIndex = 4
        Me.Lab_CCaja_AlgunaSalidaCaja.Text = "¿Hubo alguna salida de caja?"
        '
        'TtBo_CCaja_SalidaCaja
        '
        Me.TtBo_CCaja_SalidaCaja.Location = New System.Drawing.Point(258, 69)
        Me.TtBo_CCaja_SalidaCaja.Name = "TtBo_CCaja_SalidaCaja"
        Me.TtBo_CCaja_SalidaCaja.Size = New System.Drawing.Size(161, 23)
        Me.TtBo_CCaja_SalidaCaja.TabIndex = 5
        Me.TtBo_CCaja_SalidaCaja.TabStop = False
        '
        'GrBo_InformacionCorteCaja
        '
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Lab_CCaja_HoraDerecha)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Lab_CCaja_FechaDerecha)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Lab_CCaja_InfHora)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Lab_CCaja_InfFecha)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.TtBo_CCaja_InfTotal)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Lab_CCaja_InfTotal)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Button3)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.TtBo_CCaja_InfSubtotal)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.TtBo_CCaja_InfSalidaDinero)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.TtBo_CCaja_InfDineroInicial)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Lab_CCaja_InfSubtotal)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Lab_CCaja_InfSalidaDinero)
        Me.GrBo_InformacionCorteCaja.Controls.Add(Me.Lab_CCaja_InfDimeroInicial)
        Me.GrBo_InformacionCorteCaja.Location = New System.Drawing.Point(45, 204)
        Me.GrBo_InformacionCorteCaja.Name = "GrBo_InformacionCorteCaja"
        Me.GrBo_InformacionCorteCaja.Size = New System.Drawing.Size(667, 144)
        Me.GrBo_InformacionCorteCaja.TabIndex = 7
        Me.GrBo_InformacionCorteCaja.TabStop = False
        Me.GrBo_InformacionCorteCaja.Text = "Información del corte caja"
        '
        'Lab_CCaja_HoraDerecha
        '
        Me.Lab_CCaja_HoraDerecha.AutoSize = True
        Me.Lab_CCaja_HoraDerecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_HoraDerecha.Location = New System.Drawing.Point(112, 50)
        Me.Lab_CCaja_HoraDerecha.Name = "Lab_CCaja_HoraDerecha"
        Me.Lab_CCaja_HoraDerecha.Size = New System.Drawing.Size(41, 16)
        Me.Lab_CCaja_HoraDerecha.TabIndex = 17
        Me.Lab_CCaja_HoraDerecha.Text = "Hora:"
        '
        'Lab_CCaja_FechaDerecha
        '
        Me.Lab_CCaja_FechaDerecha.AutoSize = True
        Me.Lab_CCaja_FechaDerecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_FechaDerecha.Location = New System.Drawing.Point(112, 24)
        Me.Lab_CCaja_FechaDerecha.Name = "Lab_CCaja_FechaDerecha"
        Me.Lab_CCaja_FechaDerecha.Size = New System.Drawing.Size(49, 16)
        Me.Lab_CCaja_FechaDerecha.TabIndex = 16
        Me.Lab_CCaja_FechaDerecha.Text = "Fecha:"
        '
        'Lab_CCaja_InfHora
        '
        Me.Lab_CCaja_InfHora.AutoSize = True
        Me.Lab_CCaja_InfHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_InfHora.Location = New System.Drawing.Point(5, 50)
        Me.Lab_CCaja_InfHora.Name = "Lab_CCaja_InfHora"
        Me.Lab_CCaja_InfHora.Size = New System.Drawing.Size(41, 16)
        Me.Lab_CCaja_InfHora.TabIndex = 15
        Me.Lab_CCaja_InfHora.Text = "Hora:"
        '
        'Lab_CCaja_InfFecha
        '
        Me.Lab_CCaja_InfFecha.AutoSize = True
        Me.Lab_CCaja_InfFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_InfFecha.Location = New System.Drawing.Point(5, 21)
        Me.Lab_CCaja_InfFecha.Name = "Lab_CCaja_InfFecha"
        Me.Lab_CCaja_InfFecha.Size = New System.Drawing.Size(49, 16)
        Me.Lab_CCaja_InfFecha.TabIndex = 14
        Me.Lab_CCaja_InfFecha.Text = "Fecha:"
        '
        'TtBo_CCaja_InfTotal
        '
        Me.TtBo_CCaja_InfTotal.Enabled = False
        Me.TtBo_CCaja_InfTotal.Location = New System.Drawing.Point(389, 72)
        Me.TtBo_CCaja_InfTotal.Name = "TtBo_CCaja_InfTotal"
        Me.TtBo_CCaja_InfTotal.Size = New System.Drawing.Size(137, 23)
        Me.TtBo_CCaja_InfTotal.TabIndex = 13
        Me.TtBo_CCaja_InfTotal.TabStop = False
        '
        'Lab_CCaja_InfTotal
        '
        Me.Lab_CCaja_InfTotal.AutoSize = True
        Me.Lab_CCaja_InfTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_InfTotal.Location = New System.Drawing.Point(279, 76)
        Me.Lab_CCaja_InfTotal.Name = "Lab_CCaja_InfTotal"
        Me.Lab_CCaja_InfTotal.Size = New System.Drawing.Size(42, 16)
        Me.Lab_CCaja_InfTotal.TabIndex = 12
        Me.Lab_CCaja_InfTotal.Text = "Total:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(377, 101)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 25)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Guardar corte de caja"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TtBo_CCaja_InfSubtotal
        '
        Me.TtBo_CCaja_InfSubtotal.Enabled = False
        Me.TtBo_CCaja_InfSubtotal.Location = New System.Drawing.Point(389, 46)
        Me.TtBo_CCaja_InfSubtotal.Name = "TtBo_CCaja_InfSubtotal"
        Me.TtBo_CCaja_InfSubtotal.Size = New System.Drawing.Size(137, 23)
        Me.TtBo_CCaja_InfSubtotal.TabIndex = 10
        Me.TtBo_CCaja_InfSubtotal.TabStop = False
        '
        'TtBo_CCaja_InfSalidaDinero
        '
        Me.TtBo_CCaja_InfSalidaDinero.Enabled = False
        Me.TtBo_CCaja_InfSalidaDinero.Location = New System.Drawing.Point(389, 20)
        Me.TtBo_CCaja_InfSalidaDinero.Name = "TtBo_CCaja_InfSalidaDinero"
        Me.TtBo_CCaja_InfSalidaDinero.Size = New System.Drawing.Size(137, 23)
        Me.TtBo_CCaja_InfSalidaDinero.TabIndex = 9
        Me.TtBo_CCaja_InfSalidaDinero.TabStop = False
        '
        'TtBo_CCaja_InfDineroInicial
        '
        Me.TtBo_CCaja_InfDineroInicial.Enabled = False
        Me.TtBo_CCaja_InfDineroInicial.Location = New System.Drawing.Point(115, 76)
        Me.TtBo_CCaja_InfDineroInicial.Name = "TtBo_CCaja_InfDineroInicial"
        Me.TtBo_CCaja_InfDineroInicial.Size = New System.Drawing.Size(137, 23)
        Me.TtBo_CCaja_InfDineroInicial.TabIndex = 8
        Me.TtBo_CCaja_InfDineroInicial.TabStop = False
        '
        'Lab_CCaja_InfSubtotal
        '
        Me.Lab_CCaja_InfSubtotal.AutoSize = True
        Me.Lab_CCaja_InfSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_InfSubtotal.Location = New System.Drawing.Point(279, 50)
        Me.Lab_CCaja_InfSubtotal.Name = "Lab_CCaja_InfSubtotal"
        Me.Lab_CCaja_InfSubtotal.Size = New System.Drawing.Size(60, 16)
        Me.Lab_CCaja_InfSubtotal.TabIndex = 7
        Me.Lab_CCaja_InfSubtotal.Text = "Subtotal:"
        '
        'Lab_CCaja_InfSalidaDinero
        '
        Me.Lab_CCaja_InfSalidaDinero.AutoSize = True
        Me.Lab_CCaja_InfSalidaDinero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_InfSalidaDinero.Location = New System.Drawing.Point(279, 21)
        Me.Lab_CCaja_InfSalidaDinero.Name = "Lab_CCaja_InfSalidaDinero"
        Me.Lab_CCaja_InfSalidaDinero.Size = New System.Drawing.Size(110, 16)
        Me.Lab_CCaja_InfSalidaDinero.TabIndex = 6
        Me.Lab_CCaja_InfSalidaDinero.Text = "Salida de dinero:"
        '
        'Lab_CCaja_InfDimeroInicial
        '
        Me.Lab_CCaja_InfDimeroInicial.AutoSize = True
        Me.Lab_CCaja_InfDimeroInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CCaja_InfDimeroInicial.Location = New System.Drawing.Point(5, 80)
        Me.Lab_CCaja_InfDimeroInicial.Name = "Lab_CCaja_InfDimeroInicial"
        Me.Lab_CCaja_InfDimeroInicial.Size = New System.Drawing.Size(88, 16)
        Me.Lab_CCaja_InfDimeroInicial.TabIndex = 5
        Me.Lab_CCaja_InfDimeroInicial.Text = "Dinero inicial:"
        '
        'Lab_CCaja_Titulo
        '
        Me.Lab_CCaja_Titulo.AutoSize = True
        Me.Lab_CCaja_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_CCaja_Titulo.Location = New System.Drawing.Point(318, 16)
        Me.Lab_CCaja_Titulo.Name = "Lab_CCaja_Titulo"
        Me.Lab_CCaja_Titulo.Size = New System.Drawing.Size(92, 17)
        Me.Lab_CCaja_Titulo.TabIndex = 0
        Me.Lab_CCaja_Titulo.Text = "Corte de caja"
        '
        'Consulta_CorteCajaHist
        '
        Me.Consulta_CorteCajaHist.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_CorteCajaHist.Controls.Add(Me.Btn_HCCaja_BuscarTodo)
        Me.Consulta_CorteCajaHist.Controls.Add(Me.Btn_HCCaja_Buscar)
        Me.Consulta_CorteCajaHist.Controls.Add(Me.DGV_ListaCCajas)
        Me.Consulta_CorteCajaHist.Controls.Add(Me.DaTiPi_HCCaja_SeleccionFecha)
        Me.Consulta_CorteCajaHist.Controls.Add(Me.Lab_HCCaja_SeleccionFecha)
        Me.Consulta_CorteCajaHist.Location = New System.Drawing.Point(4, 25)
        Me.Consulta_CorteCajaHist.Name = "Consulta_CorteCajaHist"
        Me.Consulta_CorteCajaHist.Size = New System.Drawing.Size(768, 348)
        Me.Consulta_CorteCajaHist.TabIndex = 2
        Me.Consulta_CorteCajaHist.Text = "Historial de cortes de caja"
        '
        'Btn_HCCaja_Buscar
        '
        Me.Btn_HCCaja_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_HCCaja_Buscar.Location = New System.Drawing.Point(447, 73)
        Me.Btn_HCCaja_Buscar.Name = "Btn_HCCaja_Buscar"
        Me.Btn_HCCaja_Buscar.Size = New System.Drawing.Size(166, 25)
        Me.Btn_HCCaja_Buscar.TabIndex = 3
        Me.Btn_HCCaja_Buscar.Text = "Buscar"
        Me.Btn_HCCaja_Buscar.UseVisualStyleBackColor = False
        '
        'DGV_ListaCCajas
        '
        Me.DGV_ListaCCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ListaCCajas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_ID_CorCaja, Me.DGV_FECHA_CorCaja, Me.DGV_HORA_CorCaja, Me.DGV_DnInic_CorCaja, Me.DGV_SalCaja_CorCaja, Me.DGV_TOTAL_CorCaja, Me.DGV_NOMBCAJERO_CorCaja})
        Me.DGV_ListaCCajas.Location = New System.Drawing.Point(14, 118)
        Me.DGV_ListaCCajas.Name = "DGV_ListaCCajas"
        Me.DGV_ListaCCajas.Size = New System.Drawing.Size(740, 208)
        Me.DGV_ListaCCajas.TabIndex = 2
        '
        'DGV_ID_CorCaja
        '
        Me.DGV_ID_CorCaja.HeaderText = "ID"
        Me.DGV_ID_CorCaja.MaxInputLength = 3
        Me.DGV_ID_CorCaja.Name = "DGV_ID_CorCaja"
        '
        'DGV_FECHA_CorCaja
        '
        Me.DGV_FECHA_CorCaja.HeaderText = "FECHA"
        Me.DGV_FECHA_CorCaja.MaxInputLength = 10
        Me.DGV_FECHA_CorCaja.Name = "DGV_FECHA_CorCaja"
        '
        'DGV_HORA_CorCaja
        '
        Me.DGV_HORA_CorCaja.HeaderText = "HORA"
        Me.DGV_HORA_CorCaja.MaxInputLength = 8
        Me.DGV_HORA_CorCaja.Name = "DGV_HORA_CorCaja"
        '
        'DGV_DnInic_CorCaja
        '
        Me.DGV_DnInic_CorCaja.HeaderText = "DINERO INICIAL"
        Me.DGV_DnInic_CorCaja.MaxInputLength = 5
        Me.DGV_DnInic_CorCaja.Name = "DGV_DnInic_CorCaja"
        '
        'DGV_SalCaja_CorCaja
        '
        Me.DGV_SalCaja_CorCaja.HeaderText = "SALIDAS DE CAJA"
        Me.DGV_SalCaja_CorCaja.MaxInputLength = 5
        Me.DGV_SalCaja_CorCaja.Name = "DGV_SalCaja_CorCaja"
        '
        'DGV_TOTAL_CorCaja
        '
        Me.DGV_TOTAL_CorCaja.HeaderText = "TOTAL"
        Me.DGV_TOTAL_CorCaja.MaxInputLength = 6
        Me.DGV_TOTAL_CorCaja.Name = "DGV_TOTAL_CorCaja"
        '
        'DGV_NOMBCAJERO_CorCaja
        '
        Me.DGV_NOMBCAJERO_CorCaja.HeaderText = "NOMBRE DEL CAJERO"
        Me.DGV_NOMBCAJERO_CorCaja.Name = "DGV_NOMBCAJERO_CorCaja"
        '
        'DaTiPi_HCCaja_SeleccionFecha
        '
        Me.DaTiPi_HCCaja_SeleccionFecha.Location = New System.Drawing.Point(373, 44)
        Me.DaTiPi_HCCaja_SeleccionFecha.Name = "DaTiPi_HCCaja_SeleccionFecha"
        Me.DaTiPi_HCCaja_SeleccionFecha.Size = New System.Drawing.Size(200, 23)
        Me.DaTiPi_HCCaja_SeleccionFecha.TabIndex = 1
        '
        'Lab_HCCaja_SeleccionFecha
        '
        Me.Lab_HCCaja_SeleccionFecha.AutoSize = True
        Me.Lab_HCCaja_SeleccionFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_HCCaja_SeleccionFecha.Location = New System.Drawing.Point(123, 44)
        Me.Lab_HCCaja_SeleccionFecha.Name = "Lab_HCCaja_SeleccionFecha"
        Me.Lab_HCCaja_SeleccionFecha.Size = New System.Drawing.Size(244, 17)
        Me.Lab_HCCaja_SeleccionFecha.TabIndex = 0
        Me.Lab_HCCaja_SeleccionFecha.Text = "Seleccione la fecha del corte de caja:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "< Atras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_HCCaja_BuscarTodo
        '
        Me.Btn_HCCaja_BuscarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_HCCaja_BuscarTodo.Location = New System.Drawing.Point(275, 73)
        Me.Btn_HCCaja_BuscarTodo.Name = "Btn_HCCaja_BuscarTodo"
        Me.Btn_HCCaja_BuscarTodo.Size = New System.Drawing.Size(166, 25)
        Me.Btn_HCCaja_BuscarTodo.TabIndex = 4
        Me.Btn_HCCaja_BuscarTodo.Text = "Buscar todo"
        Me.Btn_HCCaja_BuscarTodo.UseVisualStyleBackColor = False
        '
        'Form_CorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tab_Ctr_CorteCaja)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_CorteCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_CorteCaja.ResumeLayout(False)
        Me.Alta_CorteCajaFinal.ResumeLayout(False)
        Me.Alta_CorteCajaFinal.PerformLayout()
        Me.GrBo_DatosCorteCaja.ResumeLayout(False)
        Me.GrBo_DatosCorteCaja.PerformLayout()
        Me.GrBo_InformacionCorteCaja.ResumeLayout(False)
        Me.GrBo_InformacionCorteCaja.PerformLayout()
        Me.Consulta_CorteCajaHist.ResumeLayout(False)
        Me.Consulta_CorteCajaHist.PerformLayout()
        CType(Me.DGV_ListaCCajas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tab_Ctr_CorteCaja As TabControl
    Friend WithEvents Alta_CorteCajaFinal As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Consulta_CorteCajaHist As TabPage
    Friend WithEvents GrBo_InformacionCorteCaja As GroupBox
    Friend WithEvents TtBo_CCaja_InfTotal As TextBox
    Friend WithEvents Lab_CCaja_InfTotal As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TtBo_CCaja_InfSubtotal As TextBox
    Friend WithEvents TtBo_CCaja_InfSalidaDinero As TextBox
    Friend WithEvents TtBo_CCaja_InfDineroInicial As TextBox
    Friend WithEvents Lab_CCaja_InfSubtotal As Label
    Friend WithEvents Lab_CCaja_InfSalidaDinero As Label
    Friend WithEvents Lab_CCaja_InfDimeroInicial As Label
    Friend WithEvents Btn_CCaja_CorteDeCaja As Button
    Friend WithEvents TtBo_CCaja_SalidaCaja As TextBox
    Friend WithEvents Lab_CCaja_AlgunaSalidaCaja As Label
    Friend WithEvents TtBo_CCaja_DineroJornadaInicial As TextBox
    Friend WithEvents Lab_CCaja_DineroJornadaInicial As Label
    Friend WithEvents Lab_CCaja_Titulo As Label
    Friend WithEvents GrBo_DatosCorteCaja As GroupBox
    Friend WithEvents Btn_HCCaja_Buscar As Button
    Friend WithEvents DGV_ListaCCajas As DataGridView
    Friend WithEvents DaTiPi_HCCaja_SeleccionFecha As DateTimePicker
    Friend WithEvents Lab_HCCaja_SeleccionFecha As Label
    Friend WithEvents TtBo_CCaja_NombCajero As TextBox
    Friend WithEvents Lab_CCaja_NombCajero As Label
    Friend WithEvents Lab_CCaja_HoraDerecha As Label
    Friend WithEvents Lab_CCaja_FechaDerecha As Label
    Friend WithEvents Lab_CCaja_InfHora As Label
    Friend WithEvents Lab_CCaja_InfFecha As Label
    Friend WithEvents DGV_ID_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_FECHA_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_HORA_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_DnInic_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_SalCaja_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_TOTAL_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_NOMBCAJERO_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_HCCaja_BuscarTodo As Button
End Class
