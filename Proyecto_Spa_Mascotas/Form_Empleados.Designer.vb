<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Empleados))
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_Ctr_Empleados = New System.Windows.Forms.TabControl()
        Me.Alta_Empleado = New System.Windows.Forms.TabPage()
        Me.Lab_Alta_HrSalEmp = New System.Windows.Forms.Label()
        Me.Mas_Alta_SueldoEmp = New System.Windows.Forms.MaskedTextBox()
        Me.Lab_Alta_SueldoEmp = New System.Windows.Forms.Label()
        Me.CoBo_Alta_HrSalEmp = New System.Windows.Forms.ComboBox()
        Me.CoBo_Alta_MeridianaSalEmp = New System.Windows.Forms.ComboBox()
        Me.CoBo_Alta_MeridianaEntEmp = New System.Windows.Forms.ComboBox()
        Me.CoBo_Alta_HrEntEmp = New System.Windows.Forms.ComboBox()
        Me.Lab_Alta_HrEntEmp = New System.Windows.Forms.Label()
        Me.CoBo_Alta_TurnoEmp = New System.Windows.Forms.ComboBox()
        Me.Lab_Alta_TurnoEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_CalleEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_CalleEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_PuestoTrabEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_PuestoTrabEmp = New System.Windows.Forms.Label()
        Me.Btn_Alta_LimpiarEmp = New System.Windows.Forms.Button()
        Me.Btn_Alta_GuardaEmp = New System.Windows.Forms.Button()
        Me.Lab_Alta_CurpNota = New System.Windows.Forms.Label()
        Me.TtBo_Alta_CurpEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_CurpEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_NaclidadOrigEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_NaclidadOrigEmp = New System.Windows.Forms.Label()
        Me.RaBo_Alta_NaclidadExtjEmp = New System.Windows.Forms.RadioButton()
        Me.RaBo_Alta_NaclidadMexEmp = New System.Windows.Forms.RadioButton()
        Me.Lab_Alta_NaclidadEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_EmailEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_EmailEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_CpEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_CpEmp = New System.Windows.Forms.Label()
        Me.CoBo_Alta_EstadoEmp = New System.Windows.Forms.ComboBox()
        Me.TtBo_Alta_MunicipioEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_ColoniaEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NumExtEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NumIntEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_EstadoEmp = New System.Windows.Forms.Label()
        Me.Lab_Alta_MunicipioEmp = New System.Windows.Forms.Label()
        Me.Lab_Alta_ColoniaEmp = New System.Windows.Forms.Label()
        Me.Lab_Alta_NumExtEmp = New System.Windows.Forms.Label()
        Me.Lab_Alta_NumIntEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_TelefFijoEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_TelefFijoEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_TelefMoviEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_TelefMovEmp = New System.Windows.Forms.Label()
        Me.RaBo_Alta_SMasculinoEmp = New System.Windows.Forms.RadioButton()
        Me.RaBo_Alta_SFemeninoEmp = New System.Windows.Forms.RadioButton()
        Me.Lab_Alta_SexoEmp = New System.Windows.Forms.Label()
        Me.DaTiPi_Alta_FechNacEmp = New System.Windows.Forms.DateTimePicker()
        Me.Lab_Alta_FechaNacEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_AmatEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_ApatEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_AmatEmp = New System.Windows.Forms.Label()
        Me.Lab_Alta_ApatEmp = New System.Windows.Forms.Label()
        Me.TtBo_Alta_NombEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_NombEmp = New System.Windows.Forms.Label()
        Me.Consulta_Empleado = New System.Windows.Forms.TabPage()
        Me.DGV_ListaEmp = New System.Windows.Forms.DataGridView()
        Me.DGV_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NombraComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_FNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_CurpORne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Domio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Cons_Consultar = New System.Windows.Forms.Button()
        Me.Lab_Cons_CurpNota = New System.Windows.Forms.Label()
        Me.TtBo_Cons_CurpEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Cons_CurpbEmp = New System.Windows.Forms.Label()
        Me.TtBo_Cons_AmatEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Cons_ApatEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Cons_AmatEmp = New System.Windows.Forms.Label()
        Me.Lab_Cons_ApatEmp = New System.Windows.Forms.Label()
        Me.TtBo_Cons_NombEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Cons_NombEmp = New System.Windows.Forms.Label()
        Me.Cambio_Empleado = New System.Windows.Forms.TabPage()
        Me.Btn_Camb_Buscar = New System.Windows.Forms.Button()
        Me.TtBo_Camb_PuestoTrabEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_PuestoTrabEmp = New System.Windows.Forms.Label()
        Me.Btn_Camb_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Camb_Guardar = New System.Windows.Forms.Button()
        Me.TtBo_Camb_CalleEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_CalleEmp = New System.Windows.Forms.Label()
        Me.Lab_Camb_CurpNota = New System.Windows.Forms.Label()
        Me.TtBo_Camb_CurpEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_CurpEmp = New System.Windows.Forms.Label()
        Me.TtBo_Camb_NaclidadOrigEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_NaclidadOrigEmp = New System.Windows.Forms.Label()
        Me.RaBo_Camb_NaclidadExtjEmp = New System.Windows.Forms.RadioButton()
        Me.RaBo_Camb_NaclidadMexEmp = New System.Windows.Forms.RadioButton()
        Me.Lab_Camb_NaclidadEmp = New System.Windows.Forms.Label()
        Me.TtBo_Camb_EmailEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_EmailEmp = New System.Windows.Forms.Label()
        Me.TtBo_Camb_CpEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_CpEmp = New System.Windows.Forms.Label()
        Me.CoBo_Camb_EstadoEmp = New System.Windows.Forms.ComboBox()
        Me.TtBo_Camb_MunicipioEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Camb_ColoniaEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Camb_NumExtEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Camb_NumIntEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_EstadoEmp = New System.Windows.Forms.Label()
        Me.Lab_Camb_MunicipioEmp = New System.Windows.Forms.Label()
        Me.Lab_Camb_ColoniaEmp = New System.Windows.Forms.Label()
        Me.Lab_Camb_NumExtEmp = New System.Windows.Forms.Label()
        Me.Lab_Camb_NumIntEmp = New System.Windows.Forms.Label()
        Me.TtBo_Camb_TelefFijoEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_TelefFijoEmp = New System.Windows.Forms.Label()
        Me.TtBo_Camb_TelefMovilEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_TelefMovilEmp = New System.Windows.Forms.Label()
        Me.RaBo_Camb_SMasculinoEmp = New System.Windows.Forms.RadioButton()
        Me.RaBo_Camb_SFemeninoEmp = New System.Windows.Forms.RadioButton()
        Me.Lab_Camb_SexoEmp = New System.Windows.Forms.Label()
        Me.DaTiPi_Camb_FechNacEmp = New System.Windows.Forms.DateTimePicker()
        Me.Lab_Camb_FechNacEmp = New System.Windows.Forms.Label()
        Me.TtBo_Camb_AmatEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Camb_ApatEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_AmatEmp = New System.Windows.Forms.Label()
        Me.Lab_Camb_ApatEmp = New System.Windows.Forms.Label()
        Me.TtBo_Camb_NombEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_NombEmp = New System.Windows.Forms.Label()
        Me.Baja_Empleado = New System.Windows.Forms.TabPage()
        Me.DGV_Baja_ListaEmp = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Baja_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Baja_Buscar = New System.Windows.Forms.Button()
        Me.Lab_Baja_CurpNota = New System.Windows.Forms.Label()
        Me.TtBo_Baja_CurpEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Baja_CurpEmp = New System.Windows.Forms.Label()
        Me.TtBo_Baja_AmatEmp = New System.Windows.Forms.TextBox()
        Me.TtBo_Baja_ApatEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Baja_AmatEmp = New System.Windows.Forms.Label()
        Me.Lab_Baja_ApatEmp = New System.Windows.Forms.Label()
        Me.TtBo_Baja_NombEmp = New System.Windows.Forms.TextBox()
        Me.Lab_Baja_NombEmp = New System.Windows.Forms.Label()
        Me.Lab_Camb_HrSalEmp = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Lab_Camb_SueldoEmp = New System.Windows.Forms.Label()
        Me.CoBo_Camb_HrSalEmp = New System.Windows.Forms.ComboBox()
        Me.CoBo_Camb_MeridianoSalEmp = New System.Windows.Forms.ComboBox()
        Me.CoBo_Camb_MeridianoEntEmp = New System.Windows.Forms.ComboBox()
        Me.CoBo_Camb_HrEntEmp = New System.Windows.Forms.ComboBox()
        Me.Lab_Camb_HrEntEmp = New System.Windows.Forms.Label()
        Me.CoBo_Camb_TurnoEmp = New System.Windows.Forms.ComboBox()
        Me.Lab_Camb_TurnoEmp = New System.Windows.Forms.Label()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_Empleados.SuspendLayout()
        Me.Alta_Empleado.SuspendLayout()
        Me.Consulta_Empleado.SuspendLayout()
        CType(Me.DGV_ListaEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cambio_Empleado.SuspendLayout()
        Me.Baja_Empleado.SuspendLayout()
        CType(Me.DGV_Baja_ListaEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(12, 27)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(75, 23)
        Me.Btn_atras.TabIndex = 0
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem1, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ClientesYMascotasToolStripMenuItem})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Size = New System.Drawing.Size(800, 24)
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
        'ClientesYMascotasToolStripMenuItem
        '
        Me.ClientesYMascotasToolStripMenuItem.Name = "ClientesYMascotasToolStripMenuItem"
        Me.ClientesYMascotasToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.ClientesYMascotasToolStripMenuItem.Text = "Clientes y mascotas"
        '
        'Tab_Ctr_Empleados
        '
        Me.Tab_Ctr_Empleados.Controls.Add(Me.Alta_Empleado)
        Me.Tab_Ctr_Empleados.Controls.Add(Me.Consulta_Empleado)
        Me.Tab_Ctr_Empleados.Controls.Add(Me.Cambio_Empleado)
        Me.Tab_Ctr_Empleados.Controls.Add(Me.Baja_Empleado)
        Me.Tab_Ctr_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Tab_Ctr_Empleados.Location = New System.Drawing.Point(12, 50)
        Me.Tab_Ctr_Empleados.Name = "Tab_Ctr_Empleados"
        Me.Tab_Ctr_Empleados.SelectedIndex = 0
        Me.Tab_Ctr_Empleados.Size = New System.Drawing.Size(776, 446)
        Me.Tab_Ctr_Empleados.TabIndex = 0
        '
        'Alta_Empleado
        '
        Me.Alta_Empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_HrSalEmp)
        Me.Alta_Empleado.Controls.Add(Me.Mas_Alta_SueldoEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_SueldoEmp)
        Me.Alta_Empleado.Controls.Add(Me.CoBo_Alta_HrSalEmp)
        Me.Alta_Empleado.Controls.Add(Me.CoBo_Alta_MeridianaSalEmp)
        Me.Alta_Empleado.Controls.Add(Me.CoBo_Alta_MeridianaEntEmp)
        Me.Alta_Empleado.Controls.Add(Me.CoBo_Alta_HrEntEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_HrEntEmp)
        Me.Alta_Empleado.Controls.Add(Me.CoBo_Alta_TurnoEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_TurnoEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_CalleEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_CalleEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_PuestoTrabEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_PuestoTrabEmp)
        Me.Alta_Empleado.Controls.Add(Me.Btn_Alta_LimpiarEmp)
        Me.Alta_Empleado.Controls.Add(Me.Btn_Alta_GuardaEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_CurpNota)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_CurpEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_CurpEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_NaclidadOrigEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_NaclidadOrigEmp)
        Me.Alta_Empleado.Controls.Add(Me.RaBo_Alta_NaclidadExtjEmp)
        Me.Alta_Empleado.Controls.Add(Me.RaBo_Alta_NaclidadMexEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_NaclidadEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_EmailEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_EmailEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_CpEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_CpEmp)
        Me.Alta_Empleado.Controls.Add(Me.CoBo_Alta_EstadoEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_MunicipioEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_ColoniaEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_NumExtEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_NumIntEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_EstadoEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_MunicipioEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_ColoniaEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_NumExtEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_NumIntEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_TelefFijoEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_TelefFijoEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_TelefMoviEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_TelefMovEmp)
        Me.Alta_Empleado.Controls.Add(Me.RaBo_Alta_SMasculinoEmp)
        Me.Alta_Empleado.Controls.Add(Me.RaBo_Alta_SFemeninoEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_SexoEmp)
        Me.Alta_Empleado.Controls.Add(Me.DaTiPi_Alta_FechNacEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_FechaNacEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_AmatEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_ApatEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_AmatEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_ApatEmp)
        Me.Alta_Empleado.Controls.Add(Me.TtBo_Alta_NombEmp)
        Me.Alta_Empleado.Controls.Add(Me.Lab_Alta_NombEmp)
        Me.Alta_Empleado.Location = New System.Drawing.Point(4, 25)
        Me.Alta_Empleado.Name = "Alta_Empleado"
        Me.Alta_Empleado.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Empleado.Size = New System.Drawing.Size(768, 377)
        Me.Alta_Empleado.TabIndex = 0
        Me.Alta_Empleado.Text = "Alta de empleado"
        '
        'Lab_Alta_HrSalEmp
        '
        Me.Lab_Alta_HrSalEmp.AutoSize = True
        Me.Lab_Alta_HrSalEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_HrSalEmp.Location = New System.Drawing.Point(20, 345)
        Me.Lab_Alta_HrSalEmp.Name = "Lab_Alta_HrSalEmp"
        Me.Lab_Alta_HrSalEmp.Size = New System.Drawing.Size(115, 16)
        Me.Lab_Alta_HrSalEmp.TabIndex = 56
        Me.Lab_Alta_HrSalEmp.Text = "Horario de salida:"
        '
        'Mas_Alta_SueldoEmp
        '
        Me.Mas_Alta_SueldoEmp.Location = New System.Drawing.Point(497, 24)
        Me.Mas_Alta_SueldoEmp.Mask = "99999.99"
        Me.Mas_Alta_SueldoEmp.Name = "Mas_Alta_SueldoEmp"
        Me.Mas_Alta_SueldoEmp.Size = New System.Drawing.Size(209, 23)
        Me.Mas_Alta_SueldoEmp.TabIndex = 17
        Me.Mas_Alta_SueldoEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Alta_SueldoEmp
        '
        Me.Lab_Alta_SueldoEmp.AutoSize = True
        Me.Lab_Alta_SueldoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_SueldoEmp.Location = New System.Drawing.Point(386, 24)
        Me.Lab_Alta_SueldoEmp.Name = "Lab_Alta_SueldoEmp"
        Me.Lab_Alta_SueldoEmp.Size = New System.Drawing.Size(56, 17)
        Me.Lab_Alta_SueldoEmp.TabIndex = 55
        Me.Lab_Alta_SueldoEmp.Text = "Sueldo:"
        '
        'CoBo_Alta_HrSalEmp
        '
        Me.CoBo_Alta_HrSalEmp.FormattingEnabled = True
        Me.CoBo_Alta_HrSalEmp.Items.AddRange(New Object() {"6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00"})
        Me.CoBo_Alta_HrSalEmp.Location = New System.Drawing.Point(167, 346)
        Me.CoBo_Alta_HrSalEmp.Name = "CoBo_Alta_HrSalEmp"
        Me.CoBo_Alta_HrSalEmp.Size = New System.Drawing.Size(61, 24)
        Me.CoBo_Alta_HrSalEmp.TabIndex = 15
        '
        'CoBo_Alta_MeridianaSalEmp
        '
        Me.CoBo_Alta_MeridianaSalEmp.FormattingEnabled = True
        Me.CoBo_Alta_MeridianaSalEmp.Items.AddRange(New Object() {"Am", "Pm"})
        Me.CoBo_Alta_MeridianaSalEmp.Location = New System.Drawing.Point(265, 345)
        Me.CoBo_Alta_MeridianaSalEmp.Name = "CoBo_Alta_MeridianaSalEmp"
        Me.CoBo_Alta_MeridianaSalEmp.Size = New System.Drawing.Size(60, 24)
        Me.CoBo_Alta_MeridianaSalEmp.TabIndex = 16
        '
        'CoBo_Alta_MeridianaEntEmp
        '
        Me.CoBo_Alta_MeridianaEntEmp.FormattingEnabled = True
        Me.CoBo_Alta_MeridianaEntEmp.Items.AddRange(New Object() {"Am", "Pm"})
        Me.CoBo_Alta_MeridianaEntEmp.Location = New System.Drawing.Point(265, 318)
        Me.CoBo_Alta_MeridianaEntEmp.Name = "CoBo_Alta_MeridianaEntEmp"
        Me.CoBo_Alta_MeridianaEntEmp.Size = New System.Drawing.Size(60, 24)
        Me.CoBo_Alta_MeridianaEntEmp.TabIndex = 14
        '
        'CoBo_Alta_HrEntEmp
        '
        Me.CoBo_Alta_HrEntEmp.FormattingEnabled = True
        Me.CoBo_Alta_HrEntEmp.Items.AddRange(New Object() {"6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00"})
        Me.CoBo_Alta_HrEntEmp.Location = New System.Drawing.Point(167, 317)
        Me.CoBo_Alta_HrEntEmp.Name = "CoBo_Alta_HrEntEmp"
        Me.CoBo_Alta_HrEntEmp.Size = New System.Drawing.Size(61, 24)
        Me.CoBo_Alta_HrEntEmp.TabIndex = 13
        '
        'Lab_Alta_HrEntEmp
        '
        Me.Lab_Alta_HrEntEmp.AutoSize = True
        Me.Lab_Alta_HrEntEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_HrEntEmp.Location = New System.Drawing.Point(17, 317)
        Me.Lab_Alta_HrEntEmp.Name = "Lab_Alta_HrEntEmp"
        Me.Lab_Alta_HrEntEmp.Size = New System.Drawing.Size(132, 17)
        Me.Lab_Alta_HrEntEmp.TabIndex = 49
        Me.Lab_Alta_HrEntEmp.Text = "Horario de entrada:"
        '
        'CoBo_Alta_TurnoEmp
        '
        Me.CoBo_Alta_TurnoEmp.FormattingEnabled = True
        Me.CoBo_Alta_TurnoEmp.Items.AddRange(New Object() {"Diurno", "Nocturno"})
        Me.CoBo_Alta_TurnoEmp.Location = New System.Drawing.Point(157, 289)
        Me.CoBo_Alta_TurnoEmp.Name = "CoBo_Alta_TurnoEmp"
        Me.CoBo_Alta_TurnoEmp.Size = New System.Drawing.Size(209, 24)
        Me.CoBo_Alta_TurnoEmp.TabIndex = 12
        '
        'Lab_Alta_TurnoEmp
        '
        Me.Lab_Alta_TurnoEmp.AutoSize = True
        Me.Lab_Alta_TurnoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_TurnoEmp.Location = New System.Drawing.Point(21, 289)
        Me.Lab_Alta_TurnoEmp.Name = "Lab_Alta_TurnoEmp"
        Me.Lab_Alta_TurnoEmp.Size = New System.Drawing.Size(50, 17)
        Me.Lab_Alta_TurnoEmp.TabIndex = 47
        Me.Lab_Alta_TurnoEmp.Text = "Turno:"
        '
        'TtBo_Alta_CalleEmp
        '
        Me.TtBo_Alta_CalleEmp.Location = New System.Drawing.Point(497, 57)
        Me.TtBo_Alta_CalleEmp.MaxLength = 40
        Me.TtBo_Alta_CalleEmp.Name = "TtBo_Alta_CalleEmp"
        Me.TtBo_Alta_CalleEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Alta_CalleEmp.TabIndex = 18
        '
        'Lab_Alta_CalleEmp
        '
        Me.Lab_Alta_CalleEmp.AutoSize = True
        Me.Lab_Alta_CalleEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CalleEmp.Location = New System.Drawing.Point(386, 58)
        Me.Lab_Alta_CalleEmp.Name = "Lab_Alta_CalleEmp"
        Me.Lab_Alta_CalleEmp.Size = New System.Drawing.Size(43, 17)
        Me.Lab_Alta_CalleEmp.TabIndex = 45
        Me.Lab_Alta_CalleEmp.Text = "Calle:"
        '
        'TtBo_Alta_PuestoTrabEmp
        '
        Me.TtBo_Alta_PuestoTrabEmp.Location = New System.Drawing.Point(157, 260)
        Me.TtBo_Alta_PuestoTrabEmp.Name = "TtBo_Alta_PuestoTrabEmp"
        Me.TtBo_Alta_PuestoTrabEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Alta_PuestoTrabEmp.TabIndex = 11
        '
        'Lab_Alta_PuestoTrabEmp
        '
        Me.Lab_Alta_PuestoTrabEmp.AutoSize = True
        Me.Lab_Alta_PuestoTrabEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_PuestoTrabEmp.Location = New System.Drawing.Point(17, 263)
        Me.Lab_Alta_PuestoTrabEmp.Name = "Lab_Alta_PuestoTrabEmp"
        Me.Lab_Alta_PuestoTrabEmp.Size = New System.Drawing.Size(124, 17)
        Me.Lab_Alta_PuestoTrabEmp.TabIndex = 43
        Me.Lab_Alta_PuestoTrabEmp.Text = "Puesto de trabajo:"
        '
        'Btn_Alta_LimpiarEmp
        '
        Me.Btn_Alta_LimpiarEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Alta_LimpiarEmp.Location = New System.Drawing.Point(637, 346)
        Me.Btn_Alta_LimpiarEmp.Name = "Btn_Alta_LimpiarEmp"
        Me.Btn_Alta_LimpiarEmp.Size = New System.Drawing.Size(69, 23)
        Me.Btn_Alta_LimpiarEmp.TabIndex = 29
        Me.Btn_Alta_LimpiarEmp.Text = "Limpiar"
        Me.Btn_Alta_LimpiarEmp.UseVisualStyleBackColor = False
        '
        'Btn_Alta_GuardaEmp
        '
        Me.Btn_Alta_GuardaEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Alta_GuardaEmp.Location = New System.Drawing.Point(497, 346)
        Me.Btn_Alta_GuardaEmp.Name = "Btn_Alta_GuardaEmp"
        Me.Btn_Alta_GuardaEmp.Size = New System.Drawing.Size(124, 23)
        Me.Btn_Alta_GuardaEmp.TabIndex = 28
        Me.Btn_Alta_GuardaEmp.Text = "Guardar"
        Me.Btn_Alta_GuardaEmp.UseVisualStyleBackColor = False
        '
        'Lab_Alta_CurpNota
        '
        Me.Lab_Alta_CurpNota.AutoSize = True
        Me.Lab_Alta_CurpNota.Location = New System.Drawing.Point(18, 241)
        Me.Lab_Alta_CurpNota.Name = "Lab_Alta_CurpNota"
        Me.Lab_Alta_CurpNota.Size = New System.Drawing.Size(265, 17)
        Me.Lab_Alta_CurpNota.TabIndex = 38
        Me.Lab_Alta_CurpNota.Text = "* RNE: Registro Nacional de Extranjeros."
        '
        'TtBo_Alta_CurpEmp
        '
        Me.TtBo_Alta_CurpEmp.Location = New System.Drawing.Point(140, 218)
        Me.TtBo_Alta_CurpEmp.MaxLength = 18
        Me.TtBo_Alta_CurpEmp.Name = "TtBo_Alta_CurpEmp"
        Me.TtBo_Alta_CurpEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Alta_CurpEmp.TabIndex = 10
        '
        'Lab_Alta_CurpEmp
        '
        Me.Lab_Alta_CurpEmp.AutoSize = True
        Me.Lab_Alta_CurpEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CurpEmp.Location = New System.Drawing.Point(17, 218)
        Me.Lab_Alta_CurpEmp.Name = "Lab_Alta_CurpEmp"
        Me.Lab_Alta_CurpEmp.Size = New System.Drawing.Size(91, 17)
        Me.Lab_Alta_CurpEmp.TabIndex = 36
        Me.Lab_Alta_CurpEmp.Text = "CURP o RNE"
        '
        'TtBo_Alta_NaclidadOrigEmp
        '
        Me.TtBo_Alta_NaclidadOrigEmp.Enabled = False
        Me.TtBo_Alta_NaclidadOrigEmp.Location = New System.Drawing.Point(182, 188)
        Me.TtBo_Alta_NaclidadOrigEmp.MaxLength = 40
        Me.TtBo_Alta_NaclidadOrigEmp.Name = "TtBo_Alta_NaclidadOrigEmp"
        Me.TtBo_Alta_NaclidadOrigEmp.Size = New System.Drawing.Size(185, 23)
        Me.TtBo_Alta_NaclidadOrigEmp.TabIndex = 9
        '
        'Lab_Alta_NaclidadOrigEmp
        '
        Me.Lab_Alta_NaclidadOrigEmp.AutoSize = True
        Me.Lab_Alta_NaclidadOrigEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NaclidadOrigEmp.Location = New System.Drawing.Point(17, 189)
        Me.Lab_Alta_NaclidadOrigEmp.Name = "Lab_Alta_NaclidadOrigEmp"
        Me.Lab_Alta_NaclidadOrigEmp.Size = New System.Drawing.Size(158, 17)
        Me.Lab_Alta_NaclidadOrigEmp.TabIndex = 34
        Me.Lab_Alta_NaclidadOrigEmp.Text = "Nacionalidad de origen:"
        '
        'RaBo_Alta_NaclidadExtjEmp
        '
        Me.RaBo_Alta_NaclidadExtjEmp.AutoSize = True
        Me.RaBo_Alta_NaclidadExtjEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Alta_NaclidadExtjEmp.Location = New System.Drawing.Point(265, 159)
        Me.RaBo_Alta_NaclidadExtjEmp.Name = "RaBo_Alta_NaclidadExtjEmp"
        Me.RaBo_Alta_NaclidadExtjEmp.Size = New System.Drawing.Size(102, 21)
        Me.RaBo_Alta_NaclidadExtjEmp.TabIndex = 8
        Me.RaBo_Alta_NaclidadExtjEmp.TabStop = True
        Me.RaBo_Alta_NaclidadExtjEmp.Text = "Extranjera/o"
        Me.RaBo_Alta_NaclidadExtjEmp.UseVisualStyleBackColor = True
        '
        'RaBo_Alta_NaclidadMexEmp
        '
        Me.RaBo_Alta_NaclidadMexEmp.AutoSize = True
        Me.RaBo_Alta_NaclidadMexEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Alta_NaclidadMexEmp.Location = New System.Drawing.Point(149, 161)
        Me.RaBo_Alta_NaclidadMexEmp.Name = "RaBo_Alta_NaclidadMexEmp"
        Me.RaBo_Alta_NaclidadMexEmp.Size = New System.Drawing.Size(97, 21)
        Me.RaBo_Alta_NaclidadMexEmp.TabIndex = 7
        Me.RaBo_Alta_NaclidadMexEmp.TabStop = True
        Me.RaBo_Alta_NaclidadMexEmp.Text = "Mexicana/o"
        Me.RaBo_Alta_NaclidadMexEmp.UseVisualStyleBackColor = True
        '
        'Lab_Alta_NaclidadEmp
        '
        Me.Lab_Alta_NaclidadEmp.AutoSize = True
        Me.Lab_Alta_NaclidadEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NaclidadEmp.Location = New System.Drawing.Point(18, 161)
        Me.Lab_Alta_NaclidadEmp.Name = "Lab_Alta_NaclidadEmp"
        Me.Lab_Alta_NaclidadEmp.Size = New System.Drawing.Size(94, 17)
        Me.Lab_Alta_NaclidadEmp.TabIndex = 31
        Me.Lab_Alta_NaclidadEmp.Text = "Nacionalidad:"
        '
        'TtBo_Alta_EmailEmp
        '
        Me.TtBo_Alta_EmailEmp.Location = New System.Drawing.Point(520, 317)
        Me.TtBo_Alta_EmailEmp.MaxLength = 45
        Me.TtBo_Alta_EmailEmp.Name = "TtBo_Alta_EmailEmp"
        Me.TtBo_Alta_EmailEmp.Size = New System.Drawing.Size(186, 23)
        Me.TtBo_Alta_EmailEmp.TabIndex = 27
        '
        'Lab_Alta_EmailEmp
        '
        Me.Lab_Alta_EmailEmp.AutoSize = True
        Me.Lab_Alta_EmailEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_EmailEmp.Location = New System.Drawing.Point(386, 318)
        Me.Lab_Alta_EmailEmp.Name = "Lab_Alta_EmailEmp"
        Me.Lab_Alta_EmailEmp.Size = New System.Drawing.Size(128, 17)
        Me.Lab_Alta_EmailEmp.TabIndex = 29
        Me.Lab_Alta_EmailEmp.Text = "Correo electrónico:"
        '
        'TtBo_Alta_CpEmp
        '
        Me.TtBo_Alta_CpEmp.Location = New System.Drawing.Point(497, 204)
        Me.TtBo_Alta_CpEmp.MaxLength = 5
        Me.TtBo_Alta_CpEmp.Name = "TtBo_Alta_CpEmp"
        Me.TtBo_Alta_CpEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Alta_CpEmp.TabIndex = 23
        '
        'Lab_Alta_CpEmp
        '
        Me.Lab_Alta_CpEmp.AutoSize = True
        Me.Lab_Alta_CpEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_CpEmp.Location = New System.Drawing.Point(386, 204)
        Me.Lab_Alta_CpEmp.Name = "Lab_Alta_CpEmp"
        Me.Lab_Alta_CpEmp.Size = New System.Drawing.Size(98, 17)
        Me.Lab_Alta_CpEmp.TabIndex = 27
        Me.Lab_Alta_CpEmp.Text = "Código postal:"
        '
        'CoBo_Alta_EstadoEmp
        '
        Me.CoBo_Alta_EstadoEmp.FormattingEnabled = True
        Me.CoBo_Alta_EstadoEmp.Items.AddRange(New Object() {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Ciudad de México", "Coahuila", "Colima", "Durango", "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"})
        Me.CoBo_Alta_EstadoEmp.Location = New System.Drawing.Point(497, 233)
        Me.CoBo_Alta_EstadoEmp.Name = "CoBo_Alta_EstadoEmp"
        Me.CoBo_Alta_EstadoEmp.Size = New System.Drawing.Size(209, 24)
        Me.CoBo_Alta_EstadoEmp.TabIndex = 24
        Me.CoBo_Alta_EstadoEmp.Text = "Seleccione un estado"
        '
        'TtBo_Alta_MunicipioEmp
        '
        Me.TtBo_Alta_MunicipioEmp.Location = New System.Drawing.Point(547, 174)
        Me.TtBo_Alta_MunicipioEmp.MaxLength = 40
        Me.TtBo_Alta_MunicipioEmp.Name = "TtBo_Alta_MunicipioEmp"
        Me.TtBo_Alta_MunicipioEmp.Size = New System.Drawing.Size(159, 23)
        Me.TtBo_Alta_MunicipioEmp.TabIndex = 22
        '
        'TtBo_Alta_ColoniaEmp
        '
        Me.TtBo_Alta_ColoniaEmp.Location = New System.Drawing.Point(497, 148)
        Me.TtBo_Alta_ColoniaEmp.MaxLength = 40
        Me.TtBo_Alta_ColoniaEmp.Name = "TtBo_Alta_ColoniaEmp"
        Me.TtBo_Alta_ColoniaEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Alta_ColoniaEmp.TabIndex = 21
        '
        'TtBo_Alta_NumExtEmp
        '
        Me.TtBo_Alta_NumExtEmp.Location = New System.Drawing.Point(497, 114)
        Me.TtBo_Alta_NumExtEmp.MaxLength = 5
        Me.TtBo_Alta_NumExtEmp.Name = "TtBo_Alta_NumExtEmp"
        Me.TtBo_Alta_NumExtEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Alta_NumExtEmp.TabIndex = 20
        '
        'TtBo_Alta_NumIntEmp
        '
        Me.TtBo_Alta_NumIntEmp.Location = New System.Drawing.Point(497, 83)
        Me.TtBo_Alta_NumIntEmp.MaxLength = 3
        Me.TtBo_Alta_NumIntEmp.Name = "TtBo_Alta_NumIntEmp"
        Me.TtBo_Alta_NumIntEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Alta_NumIntEmp.TabIndex = 19
        '
        'Lab_Alta_EstadoEmp
        '
        Me.Lab_Alta_EstadoEmp.AutoSize = True
        Me.Lab_Alta_EstadoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_EstadoEmp.Location = New System.Drawing.Point(386, 237)
        Me.Lab_Alta_EstadoEmp.Name = "Lab_Alta_EstadoEmp"
        Me.Lab_Alta_EstadoEmp.Size = New System.Drawing.Size(56, 17)
        Me.Lab_Alta_EstadoEmp.TabIndex = 20
        Me.Lab_Alta_EstadoEmp.Text = "Estado:"
        '
        'Lab_Alta_MunicipioEmp
        '
        Me.Lab_Alta_MunicipioEmp.AutoSize = True
        Me.Lab_Alta_MunicipioEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_MunicipioEmp.Location = New System.Drawing.Point(386, 174)
        Me.Lab_Alta_MunicipioEmp.Name = "Lab_Alta_MunicipioEmp"
        Me.Lab_Alta_MunicipioEmp.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Alta_MunicipioEmp.TabIndex = 19
        Me.Lab_Alta_MunicipioEmp.Text = "Municipio / Delegación:"
        '
        'Lab_Alta_ColoniaEmp
        '
        Me.Lab_Alta_ColoniaEmp.AutoSize = True
        Me.Lab_Alta_ColoniaEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_ColoniaEmp.Location = New System.Drawing.Point(386, 148)
        Me.Lab_Alta_ColoniaEmp.Name = "Lab_Alta_ColoniaEmp"
        Me.Lab_Alta_ColoniaEmp.Size = New System.Drawing.Size(59, 17)
        Me.Lab_Alta_ColoniaEmp.TabIndex = 18
        Me.Lab_Alta_ColoniaEmp.Text = "Colonia:"
        '
        'Lab_Alta_NumExtEmp
        '
        Me.Lab_Alta_NumExtEmp.AutoSize = True
        Me.Lab_Alta_NumExtEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NumExtEmp.Location = New System.Drawing.Point(386, 115)
        Me.Lab_Alta_NumExtEmp.Name = "Lab_Alta_NumExtEmp"
        Me.Lab_Alta_NumExtEmp.Size = New System.Drawing.Size(113, 17)
        Me.Lab_Alta_NumExtEmp.TabIndex = 17
        Me.Lab_Alta_NumExtEmp.Text = "Número exterior:"
        '
        'Lab_Alta_NumIntEmp
        '
        Me.Lab_Alta_NumIntEmp.AutoSize = True
        Me.Lab_Alta_NumIntEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NumIntEmp.Location = New System.Drawing.Point(386, 83)
        Me.Lab_Alta_NumIntEmp.Name = "Lab_Alta_NumIntEmp"
        Me.Lab_Alta_NumIntEmp.Size = New System.Drawing.Size(110, 17)
        Me.Lab_Alta_NumIntEmp.TabIndex = 16
        Me.Lab_Alta_NumIntEmp.Text = "Número interior:"
        '
        'TtBo_Alta_TelefFijoEmp
        '
        Me.TtBo_Alta_TelefFijoEmp.Location = New System.Drawing.Point(497, 286)
        Me.TtBo_Alta_TelefFijoEmp.MaxLength = 10
        Me.TtBo_Alta_TelefFijoEmp.Name = "TtBo_Alta_TelefFijoEmp"
        Me.TtBo_Alta_TelefFijoEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Alta_TelefFijoEmp.TabIndex = 26
        '
        'Lab_Alta_TelefFijoEmp
        '
        Me.Lab_Alta_TelefFijoEmp.AutoSize = True
        Me.Lab_Alta_TelefFijoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_TelefFijoEmp.Location = New System.Drawing.Point(386, 286)
        Me.Lab_Alta_TelefFijoEmp.Name = "Lab_Alta_TelefFijoEmp"
        Me.Lab_Alta_TelefFijoEmp.Size = New System.Drawing.Size(90, 17)
        Me.Lab_Alta_TelefFijoEmp.TabIndex = 13
        Me.Lab_Alta_TelefFijoEmp.Text = "Teléfono fijo:"
        '
        'TtBo_Alta_TelefMoviEmp
        '
        Me.TtBo_Alta_TelefMoviEmp.Location = New System.Drawing.Point(497, 260)
        Me.TtBo_Alta_TelefMoviEmp.MaxLength = 10
        Me.TtBo_Alta_TelefMoviEmp.Name = "TtBo_Alta_TelefMoviEmp"
        Me.TtBo_Alta_TelefMoviEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Alta_TelefMoviEmp.TabIndex = 25
        '
        'Lab_Alta_TelefMovEmp
        '
        Me.Lab_Alta_TelefMovEmp.AutoSize = True
        Me.Lab_Alta_TelefMovEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_TelefMovEmp.Location = New System.Drawing.Point(386, 263)
        Me.Lab_Alta_TelefMovEmp.Name = "Lab_Alta_TelefMovEmp"
        Me.Lab_Alta_TelefMovEmp.Size = New System.Drawing.Size(114, 17)
        Me.Lab_Alta_TelefMovEmp.TabIndex = 11
        Me.Lab_Alta_TelefMovEmp.Text = "Teléfono celular:"
        '
        'RaBo_Alta_SMasculinoEmp
        '
        Me.RaBo_Alta_SMasculinoEmp.AutoSize = True
        Me.RaBo_Alta_SMasculinoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Alta_SMasculinoEmp.Location = New System.Drawing.Point(277, 124)
        Me.RaBo_Alta_SMasculinoEmp.Name = "RaBo_Alta_SMasculinoEmp"
        Me.RaBo_Alta_SMasculinoEmp.Size = New System.Drawing.Size(89, 21)
        Me.RaBo_Alta_SMasculinoEmp.TabIndex = 6
        Me.RaBo_Alta_SMasculinoEmp.TabStop = True
        Me.RaBo_Alta_SMasculinoEmp.Text = "Masculino"
        Me.RaBo_Alta_SMasculinoEmp.UseVisualStyleBackColor = True
        '
        'RaBo_Alta_SFemeninoEmp
        '
        Me.RaBo_Alta_SFemeninoEmp.AutoSize = True
        Me.RaBo_Alta_SFemeninoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Alta_SFemeninoEmp.Location = New System.Drawing.Point(149, 128)
        Me.RaBo_Alta_SFemeninoEmp.Name = "RaBo_Alta_SFemeninoEmp"
        Me.RaBo_Alta_SFemeninoEmp.Size = New System.Drawing.Size(88, 21)
        Me.RaBo_Alta_SFemeninoEmp.TabIndex = 5
        Me.RaBo_Alta_SFemeninoEmp.TabStop = True
        Me.RaBo_Alta_SFemeninoEmp.Text = "Femenino"
        Me.RaBo_Alta_SFemeninoEmp.UseVisualStyleBackColor = True
        '
        'Lab_Alta_SexoEmp
        '
        Me.Lab_Alta_SexoEmp.AutoSize = True
        Me.Lab_Alta_SexoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_SexoEmp.Location = New System.Drawing.Point(18, 130)
        Me.Lab_Alta_SexoEmp.Name = "Lab_Alta_SexoEmp"
        Me.Lab_Alta_SexoEmp.Size = New System.Drawing.Size(43, 17)
        Me.Lab_Alta_SexoEmp.TabIndex = 8
        Me.Lab_Alta_SexoEmp.Text = "Sexo:"
        '
        'DaTiPi_Alta_FechNacEmp
        '
        Me.DaTiPi_Alta_FechNacEmp.Location = New System.Drawing.Point(167, 98)
        Me.DaTiPi_Alta_FechNacEmp.MaxDate = New Date(2021, 12, 31, 0, 0, 0, 0)
        Me.DaTiPi_Alta_FechNacEmp.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DaTiPi_Alta_FechNacEmp.Name = "DaTiPi_Alta_FechNacEmp"
        Me.DaTiPi_Alta_FechNacEmp.Size = New System.Drawing.Size(200, 23)
        Me.DaTiPi_Alta_FechNacEmp.TabIndex = 4
        '
        'Lab_Alta_FechaNacEmp
        '
        Me.Lab_Alta_FechaNacEmp.AutoSize = True
        Me.Lab_Alta_FechaNacEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_FechaNacEmp.Location = New System.Drawing.Point(17, 102)
        Me.Lab_Alta_FechaNacEmp.Name = "Lab_Alta_FechaNacEmp"
        Me.Lab_Alta_FechaNacEmp.Size = New System.Drawing.Size(143, 17)
        Me.Lab_Alta_FechaNacEmp.TabIndex = 6
        Me.Lab_Alta_FechaNacEmp.Text = "Fecha de nacimiento:"
        '
        'TtBo_Alta_AmatEmp
        '
        Me.TtBo_Alta_AmatEmp.Location = New System.Drawing.Point(140, 68)
        Me.TtBo_Alta_AmatEmp.MaxLength = 40
        Me.TtBo_Alta_AmatEmp.Name = "TtBo_Alta_AmatEmp"
        Me.TtBo_Alta_AmatEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Alta_AmatEmp.TabIndex = 3
        '
        'TtBo_Alta_ApatEmp
        '
        Me.TtBo_Alta_ApatEmp.Location = New System.Drawing.Point(140, 36)
        Me.TtBo_Alta_ApatEmp.MaxLength = 40
        Me.TtBo_Alta_ApatEmp.Name = "TtBo_Alta_ApatEmp"
        Me.TtBo_Alta_ApatEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Alta_ApatEmp.TabIndex = 2
        '
        'Lab_Alta_AmatEmp
        '
        Me.Lab_Alta_AmatEmp.AutoSize = True
        Me.Lab_Alta_AmatEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_AmatEmp.Location = New System.Drawing.Point(17, 71)
        Me.Lab_Alta_AmatEmp.Name = "Lab_Alta_AmatEmp"
        Me.Lab_Alta_AmatEmp.Size = New System.Drawing.Size(118, 17)
        Me.Lab_Alta_AmatEmp.TabIndex = 3
        Me.Lab_Alta_AmatEmp.Text = "Apellido materno:"
        '
        'Lab_Alta_ApatEmp
        '
        Me.Lab_Alta_ApatEmp.AutoSize = True
        Me.Lab_Alta_ApatEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_ApatEmp.Location = New System.Drawing.Point(17, 36)
        Me.Lab_Alta_ApatEmp.Name = "Lab_Alta_ApatEmp"
        Me.Lab_Alta_ApatEmp.Size = New System.Drawing.Size(115, 17)
        Me.Lab_Alta_ApatEmp.TabIndex = 2
        Me.Lab_Alta_ApatEmp.Text = "Apellido paterno:"
        '
        'TtBo_Alta_NombEmp
        '
        Me.TtBo_Alta_NombEmp.Location = New System.Drawing.Point(140, 6)
        Me.TtBo_Alta_NombEmp.MaxLength = 40
        Me.TtBo_Alta_NombEmp.Name = "TtBo_Alta_NombEmp"
        Me.TtBo_Alta_NombEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Alta_NombEmp.TabIndex = 1
        '
        'Lab_Alta_NombEmp
        '
        Me.Lab_Alta_NombEmp.AutoSize = True
        Me.Lab_Alta_NombEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NombEmp.Location = New System.Drawing.Point(17, 3)
        Me.Lab_Alta_NombEmp.Name = "Lab_Alta_NombEmp"
        Me.Lab_Alta_NombEmp.Size = New System.Drawing.Size(73, 17)
        Me.Lab_Alta_NombEmp.TabIndex = 0
        Me.Lab_Alta_NombEmp.Text = "Nombre/s:"
        '
        'Consulta_Empleado
        '
        Me.Consulta_Empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_Empleado.Controls.Add(Me.DGV_ListaEmp)
        Me.Consulta_Empleado.Controls.Add(Me.Btn_Cons_Consultar)
        Me.Consulta_Empleado.Controls.Add(Me.Lab_Cons_CurpNota)
        Me.Consulta_Empleado.Controls.Add(Me.TtBo_Cons_CurpEmp)
        Me.Consulta_Empleado.Controls.Add(Me.Lab_Cons_CurpbEmp)
        Me.Consulta_Empleado.Controls.Add(Me.TtBo_Cons_AmatEmp)
        Me.Consulta_Empleado.Controls.Add(Me.TtBo_Cons_ApatEmp)
        Me.Consulta_Empleado.Controls.Add(Me.Lab_Cons_AmatEmp)
        Me.Consulta_Empleado.Controls.Add(Me.Lab_Cons_ApatEmp)
        Me.Consulta_Empleado.Controls.Add(Me.TtBo_Cons_NombEmp)
        Me.Consulta_Empleado.Controls.Add(Me.Lab_Cons_NombEmp)
        Me.Consulta_Empleado.Location = New System.Drawing.Point(4, 25)
        Me.Consulta_Empleado.Name = "Consulta_Empleado"
        Me.Consulta_Empleado.Size = New System.Drawing.Size(768, 377)
        Me.Consulta_Empleado.TabIndex = 3
        Me.Consulta_Empleado.Text = "Consulta de empleado"
        '
        'DGV_ListaEmp
        '
        Me.DGV_ListaEmp.BackgroundColor = System.Drawing.Color.LightGray
        Me.DGV_ListaEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ListaEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_ID, Me.DGV_NombraComp, Me.DGV_FNac, Me.DGV_Sexo, Me.DGV_CurpORne, Me.DGV_Cargo, Me.DGV_Domio})
        Me.DGV_ListaEmp.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_ListaEmp.Location = New System.Drawing.Point(14, 212)
        Me.DGV_ListaEmp.Name = "DGV_ListaEmp"
        Me.DGV_ListaEmp.Size = New System.Drawing.Size(739, 141)
        Me.DGV_ListaEmp.TabIndex = 0
        '
        'DGV_ID
        '
        Me.DGV_ID.HeaderText = "ID"
        Me.DGV_ID.MaxInputLength = 3
        Me.DGV_ID.Name = "DGV_ID"
        '
        'DGV_NombraComp
        '
        Me.DGV_NombraComp.HeaderText = "Nombre Completo"
        Me.DGV_NombraComp.MaxInputLength = 150
        Me.DGV_NombraComp.Name = "DGV_NombraComp"
        '
        'DGV_FNac
        '
        Me.DGV_FNac.HeaderText = "Fecha de nacimiento"
        Me.DGV_FNac.MaxInputLength = 10
        Me.DGV_FNac.Name = "DGV_FNac"
        '
        'DGV_Sexo
        '
        Me.DGV_Sexo.HeaderText = "Sexo"
        Me.DGV_Sexo.MaxInputLength = 10
        Me.DGV_Sexo.Name = "DGV_Sexo"
        '
        'DGV_CurpORne
        '
        Me.DGV_CurpORne.HeaderText = "CURP o RNE"
        Me.DGV_CurpORne.MaxInputLength = 20
        Me.DGV_CurpORne.Name = "DGV_CurpORne"
        '
        'DGV_Cargo
        '
        Me.DGV_Cargo.HeaderText = "Cargo"
        Me.DGV_Cargo.MaxInputLength = 80
        Me.DGV_Cargo.Name = "DGV_Cargo"
        '
        'DGV_Domio
        '
        Me.DGV_Domio.HeaderText = "Domicilio"
        Me.DGV_Domio.MaxInputLength = 250
        Me.DGV_Domio.Name = "DGV_Domio"
        '
        'Btn_Cons_Consultar
        '
        Me.Btn_Cons_Consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Cons_Consultar.Location = New System.Drawing.Point(385, 157)
        Me.Btn_Cons_Consultar.Name = "Btn_Cons_Consultar"
        Me.Btn_Cons_Consultar.Size = New System.Drawing.Size(227, 23)
        Me.Btn_Cons_Consultar.TabIndex = 5
        Me.Btn_Cons_Consultar.Text = "Consultar"
        Me.Btn_Cons_Consultar.UseVisualStyleBackColor = False
        '
        'Lab_Cons_CurpNota
        '
        Me.Lab_Cons_CurpNota.AutoSize = True
        Me.Lab_Cons_CurpNota.Location = New System.Drawing.Point(263, 140)
        Me.Lab_Cons_CurpNota.Name = "Lab_Cons_CurpNota"
        Me.Lab_Cons_CurpNota.Size = New System.Drawing.Size(265, 17)
        Me.Lab_Cons_CurpNota.TabIndex = 41
        Me.Lab_Cons_CurpNota.Text = "* RNE: Registro Nacional de Extranjeros."
        '
        'TtBo_Cons_CurpEmp
        '
        Me.TtBo_Cons_CurpEmp.Location = New System.Drawing.Point(385, 117)
        Me.TtBo_Cons_CurpEmp.MaxLength = 18
        Me.TtBo_Cons_CurpEmp.Name = "TtBo_Cons_CurpEmp"
        Me.TtBo_Cons_CurpEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Cons_CurpEmp.TabIndex = 4
        '
        'Lab_Cons_CurpbEmp
        '
        Me.Lab_Cons_CurpbEmp.AutoSize = True
        Me.Lab_Cons_CurpbEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cons_CurpbEmp.Location = New System.Drawing.Point(262, 117)
        Me.Lab_Cons_CurpbEmp.Name = "Lab_Cons_CurpbEmp"
        Me.Lab_Cons_CurpbEmp.Size = New System.Drawing.Size(91, 17)
        Me.Lab_Cons_CurpbEmp.TabIndex = 39
        Me.Lab_Cons_CurpbEmp.Text = "CURP o RNE"
        '
        'TtBo_Cons_AmatEmp
        '
        Me.TtBo_Cons_AmatEmp.Location = New System.Drawing.Point(385, 86)
        Me.TtBo_Cons_AmatEmp.Name = "TtBo_Cons_AmatEmp"
        Me.TtBo_Cons_AmatEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Cons_AmatEmp.TabIndex = 3
        '
        'TtBo_Cons_ApatEmp
        '
        Me.TtBo_Cons_ApatEmp.Location = New System.Drawing.Point(385, 54)
        Me.TtBo_Cons_ApatEmp.Name = "TtBo_Cons_ApatEmp"
        Me.TtBo_Cons_ApatEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Cons_ApatEmp.TabIndex = 2
        '
        'Lab_Cons_AmatEmp
        '
        Me.Lab_Cons_AmatEmp.AutoSize = True
        Me.Lab_Cons_AmatEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cons_AmatEmp.Location = New System.Drawing.Point(262, 86)
        Me.Lab_Cons_AmatEmp.Name = "Lab_Cons_AmatEmp"
        Me.Lab_Cons_AmatEmp.Size = New System.Drawing.Size(118, 17)
        Me.Lab_Cons_AmatEmp.TabIndex = 9
        Me.Lab_Cons_AmatEmp.Text = "Apellido materno:"
        '
        'Lab_Cons_ApatEmp
        '
        Me.Lab_Cons_ApatEmp.AutoSize = True
        Me.Lab_Cons_ApatEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cons_ApatEmp.Location = New System.Drawing.Point(262, 54)
        Me.Lab_Cons_ApatEmp.Name = "Lab_Cons_ApatEmp"
        Me.Lab_Cons_ApatEmp.Size = New System.Drawing.Size(115, 17)
        Me.Lab_Cons_ApatEmp.TabIndex = 8
        Me.Lab_Cons_ApatEmp.Text = "Apellido paterno:"
        '
        'TtBo_Cons_NombEmp
        '
        Me.TtBo_Cons_NombEmp.Location = New System.Drawing.Point(385, 16)
        Me.TtBo_Cons_NombEmp.Name = "TtBo_Cons_NombEmp"
        Me.TtBo_Cons_NombEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Cons_NombEmp.TabIndex = 1
        '
        'Lab_Cons_NombEmp
        '
        Me.Lab_Cons_NombEmp.AutoSize = True
        Me.Lab_Cons_NombEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cons_NombEmp.Location = New System.Drawing.Point(262, 16)
        Me.Lab_Cons_NombEmp.Name = "Lab_Cons_NombEmp"
        Me.Lab_Cons_NombEmp.Size = New System.Drawing.Size(73, 17)
        Me.Lab_Cons_NombEmp.TabIndex = 6
        Me.Lab_Cons_NombEmp.Text = "Nombre/s:"
        '
        'Cambio_Empleado
        '
        Me.Cambio_Empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_HrSalEmp)
        Me.Cambio_Empleado.Controls.Add(Me.MaskedTextBox1)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_SueldoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.CoBo_Camb_HrSalEmp)
        Me.Cambio_Empleado.Controls.Add(Me.CoBo_Camb_MeridianoSalEmp)
        Me.Cambio_Empleado.Controls.Add(Me.CoBo_Camb_MeridianoEntEmp)
        Me.Cambio_Empleado.Controls.Add(Me.CoBo_Camb_HrEntEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_HrEntEmp)
        Me.Cambio_Empleado.Controls.Add(Me.CoBo_Camb_TurnoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_TurnoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Btn_Camb_Buscar)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_PuestoTrabEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_PuestoTrabEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Btn_Camb_Limpiar)
        Me.Cambio_Empleado.Controls.Add(Me.Btn_Camb_Guardar)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_CalleEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_CalleEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_CurpNota)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_CurpEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_CurpEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_NaclidadOrigEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_NaclidadOrigEmp)
        Me.Cambio_Empleado.Controls.Add(Me.RaBo_Camb_NaclidadExtjEmp)
        Me.Cambio_Empleado.Controls.Add(Me.RaBo_Camb_NaclidadMexEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_NaclidadEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_EmailEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_EmailEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_CpEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_CpEmp)
        Me.Cambio_Empleado.Controls.Add(Me.CoBo_Camb_EstadoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_MunicipioEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_ColoniaEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_NumExtEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_NumIntEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_EstadoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_MunicipioEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_ColoniaEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_NumExtEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_NumIntEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_TelefFijoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_TelefFijoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_TelefMovilEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_TelefMovilEmp)
        Me.Cambio_Empleado.Controls.Add(Me.RaBo_Camb_SMasculinoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.RaBo_Camb_SFemeninoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_SexoEmp)
        Me.Cambio_Empleado.Controls.Add(Me.DaTiPi_Camb_FechNacEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_FechNacEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_AmatEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_ApatEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_AmatEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_ApatEmp)
        Me.Cambio_Empleado.Controls.Add(Me.TtBo_Camb_NombEmp)
        Me.Cambio_Empleado.Controls.Add(Me.Lab_Camb_NombEmp)
        Me.Cambio_Empleado.Location = New System.Drawing.Point(4, 25)
        Me.Cambio_Empleado.Name = "Cambio_Empleado"
        Me.Cambio_Empleado.Size = New System.Drawing.Size(768, 417)
        Me.Cambio_Empleado.TabIndex = 2
        Me.Cambio_Empleado.Text = "Cambios en el empleado"
        '
        'Btn_Camb_Buscar
        '
        Me.Btn_Camb_Buscar.Location = New System.Drawing.Point(545, 350)
        Me.Btn_Camb_Buscar.Name = "Btn_Camb_Buscar"
        Me.Btn_Camb_Buscar.Size = New System.Drawing.Size(186, 23)
        Me.Btn_Camb_Buscar.TabIndex = 21
        Me.Btn_Camb_Buscar.Text = "Buscar"
        Me.Btn_Camb_Buscar.UseVisualStyleBackColor = True
        '
        'TtBo_Camb_PuestoTrabEmp
        '
        Me.TtBo_Camb_PuestoTrabEmp.Enabled = False
        Me.TtBo_Camb_PuestoTrabEmp.Location = New System.Drawing.Point(180, 289)
        Me.TtBo_Camb_PuestoTrabEmp.Name = "TtBo_Camb_PuestoTrabEmp"
        Me.TtBo_Camb_PuestoTrabEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Camb_PuestoTrabEmp.TabIndex = 11
        '
        'Lab_Camb_PuestoTrabEmp
        '
        Me.Lab_Camb_PuestoTrabEmp.AutoSize = True
        Me.Lab_Camb_PuestoTrabEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_PuestoTrabEmp.Location = New System.Drawing.Point(39, 293)
        Me.Lab_Camb_PuestoTrabEmp.Name = "Lab_Camb_PuestoTrabEmp"
        Me.Lab_Camb_PuestoTrabEmp.Size = New System.Drawing.Size(124, 17)
        Me.Lab_Camb_PuestoTrabEmp.TabIndex = 86
        Me.Lab_Camb_PuestoTrabEmp.Text = "Puesto de trabajo:"
        '
        'Btn_Camb_Limpiar
        '
        Me.Btn_Camb_Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Camb_Limpiar.Enabled = False
        Me.Btn_Camb_Limpiar.Location = New System.Drawing.Point(640, 379)
        Me.Btn_Camb_Limpiar.Name = "Btn_Camb_Limpiar"
        Me.Btn_Camb_Limpiar.Size = New System.Drawing.Size(91, 23)
        Me.Btn_Camb_Limpiar.TabIndex = 23
        Me.Btn_Camb_Limpiar.Text = "Limpiar"
        Me.Btn_Camb_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Camb_Guardar
        '
        Me.Btn_Camb_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Camb_Guardar.Enabled = False
        Me.Btn_Camb_Guardar.Location = New System.Drawing.Point(545, 379)
        Me.Btn_Camb_Guardar.Name = "Btn_Camb_Guardar"
        Me.Btn_Camb_Guardar.Size = New System.Drawing.Size(91, 23)
        Me.Btn_Camb_Guardar.TabIndex = 22
        Me.Btn_Camb_Guardar.Text = "Guardar"
        Me.Btn_Camb_Guardar.UseVisualStyleBackColor = False
        '
        'TtBo_Camb_CalleEmp
        '
        Me.TtBo_Camb_CalleEmp.Enabled = False
        Me.TtBo_Camb_CalleEmp.Location = New System.Drawing.Point(522, 47)
        Me.TtBo_Camb_CalleEmp.Name = "TtBo_Camb_CalleEmp"
        Me.TtBo_Camb_CalleEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Camb_CalleEmp.TabIndex = 12
        '
        'Lab_Camb_CalleEmp
        '
        Me.Lab_Camb_CalleEmp.AutoSize = True
        Me.Lab_Camb_CalleEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_CalleEmp.Location = New System.Drawing.Point(411, 50)
        Me.Lab_Camb_CalleEmp.Name = "Lab_Camb_CalleEmp"
        Me.Lab_Camb_CalleEmp.Size = New System.Drawing.Size(43, 17)
        Me.Lab_Camb_CalleEmp.TabIndex = 82
        Me.Lab_Camb_CalleEmp.Text = "Calle:"
        '
        'Lab_Camb_CurpNota
        '
        Me.Lab_Camb_CurpNota.AutoSize = True
        Me.Lab_Camb_CurpNota.Location = New System.Drawing.Point(40, 268)
        Me.Lab_Camb_CurpNota.Name = "Lab_Camb_CurpNota"
        Me.Lab_Camb_CurpNota.Size = New System.Drawing.Size(265, 17)
        Me.Lab_Camb_CurpNota.TabIndex = 81
        Me.Lab_Camb_CurpNota.Text = "* RNE: Registro Nacional de Extranjeros."
        '
        'TtBo_Camb_CurpEmp
        '
        Me.TtBo_Camb_CurpEmp.Location = New System.Drawing.Point(162, 245)
        Me.TtBo_Camb_CurpEmp.MaxLength = 18
        Me.TtBo_Camb_CurpEmp.Name = "TtBo_Camb_CurpEmp"
        Me.TtBo_Camb_CurpEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Camb_CurpEmp.TabIndex = 10
        '
        'Lab_Camb_CurpEmp
        '
        Me.Lab_Camb_CurpEmp.AutoSize = True
        Me.Lab_Camb_CurpEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_CurpEmp.Location = New System.Drawing.Point(39, 245)
        Me.Lab_Camb_CurpEmp.Name = "Lab_Camb_CurpEmp"
        Me.Lab_Camb_CurpEmp.Size = New System.Drawing.Size(83, 17)
        Me.Lab_Camb_CurpEmp.TabIndex = 79
        Me.Lab_Camb_CurpEmp.Text = "Curp o RNE"
        '
        'TtBo_Camb_NaclidadOrigEmp
        '
        Me.TtBo_Camb_NaclidadOrigEmp.Enabled = False
        Me.TtBo_Camb_NaclidadOrigEmp.Location = New System.Drawing.Point(204, 215)
        Me.TtBo_Camb_NaclidadOrigEmp.Name = "TtBo_Camb_NaclidadOrigEmp"
        Me.TtBo_Camb_NaclidadOrigEmp.Size = New System.Drawing.Size(185, 23)
        Me.TtBo_Camb_NaclidadOrigEmp.TabIndex = 9
        '
        'Lab_Camb_NaclidadOrigEmp
        '
        Me.Lab_Camb_NaclidadOrigEmp.AutoSize = True
        Me.Lab_Camb_NaclidadOrigEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_NaclidadOrigEmp.Location = New System.Drawing.Point(39, 215)
        Me.Lab_Camb_NaclidadOrigEmp.Name = "Lab_Camb_NaclidadOrigEmp"
        Me.Lab_Camb_NaclidadOrigEmp.Size = New System.Drawing.Size(158, 17)
        Me.Lab_Camb_NaclidadOrigEmp.TabIndex = 77
        Me.Lab_Camb_NaclidadOrigEmp.Text = "Nacionalidad de origen:"
        '
        'RaBo_Camb_NaclidadExtjEmp
        '
        Me.RaBo_Camb_NaclidadExtjEmp.AutoSize = True
        Me.RaBo_Camb_NaclidadExtjEmp.Enabled = False
        Me.RaBo_Camb_NaclidadExtjEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Camb_NaclidadExtjEmp.Location = New System.Drawing.Point(286, 185)
        Me.RaBo_Camb_NaclidadExtjEmp.Name = "RaBo_Camb_NaclidadExtjEmp"
        Me.RaBo_Camb_NaclidadExtjEmp.Size = New System.Drawing.Size(102, 21)
        Me.RaBo_Camb_NaclidadExtjEmp.TabIndex = 8
        Me.RaBo_Camb_NaclidadExtjEmp.TabStop = True
        Me.RaBo_Camb_NaclidadExtjEmp.Text = "Extranjera/o"
        Me.RaBo_Camb_NaclidadExtjEmp.UseVisualStyleBackColor = True
        '
        'RaBo_Camb_NaclidadMexEmp
        '
        Me.RaBo_Camb_NaclidadMexEmp.AutoSize = True
        Me.RaBo_Camb_NaclidadMexEmp.Enabled = False
        Me.RaBo_Camb_NaclidadMexEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Camb_NaclidadMexEmp.Location = New System.Drawing.Point(162, 185)
        Me.RaBo_Camb_NaclidadMexEmp.Name = "RaBo_Camb_NaclidadMexEmp"
        Me.RaBo_Camb_NaclidadMexEmp.Size = New System.Drawing.Size(97, 21)
        Me.RaBo_Camb_NaclidadMexEmp.TabIndex = 7
        Me.RaBo_Camb_NaclidadMexEmp.TabStop = True
        Me.RaBo_Camb_NaclidadMexEmp.Text = "Mexicana/o"
        Me.RaBo_Camb_NaclidadMexEmp.UseVisualStyleBackColor = True
        '
        'Lab_Camb_NaclidadEmp
        '
        Me.Lab_Camb_NaclidadEmp.AutoSize = True
        Me.Lab_Camb_NaclidadEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_NaclidadEmp.Location = New System.Drawing.Point(39, 187)
        Me.Lab_Camb_NaclidadEmp.Name = "Lab_Camb_NaclidadEmp"
        Me.Lab_Camb_NaclidadEmp.Size = New System.Drawing.Size(94, 17)
        Me.Lab_Camb_NaclidadEmp.TabIndex = 74
        Me.Lab_Camb_NaclidadEmp.Text = "Nacionalidad:"
        '
        'TtBo_Camb_EmailEmp
        '
        Me.TtBo_Camb_EmailEmp.Enabled = False
        Me.TtBo_Camb_EmailEmp.Location = New System.Drawing.Point(545, 312)
        Me.TtBo_Camb_EmailEmp.Name = "TtBo_Camb_EmailEmp"
        Me.TtBo_Camb_EmailEmp.Size = New System.Drawing.Size(186, 23)
        Me.TtBo_Camb_EmailEmp.TabIndex = 20
        '
        'Lab_Camb_EmailEmp
        '
        Me.Lab_Camb_EmailEmp.AutoSize = True
        Me.Lab_Camb_EmailEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_EmailEmp.Location = New System.Drawing.Point(411, 313)
        Me.Lab_Camb_EmailEmp.Name = "Lab_Camb_EmailEmp"
        Me.Lab_Camb_EmailEmp.Size = New System.Drawing.Size(128, 17)
        Me.Lab_Camb_EmailEmp.TabIndex = 72
        Me.Lab_Camb_EmailEmp.Text = "Correo electrónico:"
        '
        'TtBo_Camb_CpEmp
        '
        Me.TtBo_Camb_CpEmp.Enabled = False
        Me.TtBo_Camb_CpEmp.Location = New System.Drawing.Point(522, 192)
        Me.TtBo_Camb_CpEmp.Name = "TtBo_Camb_CpEmp"
        Me.TtBo_Camb_CpEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Camb_CpEmp.TabIndex = 17
        '
        'Lab_Camb_CpEmp
        '
        Me.Lab_Camb_CpEmp.AutoSize = True
        Me.Lab_Camb_CpEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_CpEmp.Location = New System.Drawing.Point(411, 192)
        Me.Lab_Camb_CpEmp.Name = "Lab_Camb_CpEmp"
        Me.Lab_Camb_CpEmp.Size = New System.Drawing.Size(98, 17)
        Me.Lab_Camb_CpEmp.TabIndex = 70
        Me.Lab_Camb_CpEmp.Text = "Código postal:"
        '
        'CoBo_Camb_EstadoEmp
        '
        Me.CoBo_Camb_EstadoEmp.Enabled = False
        Me.CoBo_Camb_EstadoEmp.FormattingEnabled = True
        Me.CoBo_Camb_EstadoEmp.Location = New System.Drawing.Point(522, 221)
        Me.CoBo_Camb_EstadoEmp.Name = "CoBo_Camb_EstadoEmp"
        Me.CoBo_Camb_EstadoEmp.Size = New System.Drawing.Size(209, 24)
        Me.CoBo_Camb_EstadoEmp.TabIndex = 18
        Me.CoBo_Camb_EstadoEmp.Text = "Seleccione un estado"
        '
        'TtBo_Camb_MunicipioEmp
        '
        Me.TtBo_Camb_MunicipioEmp.Enabled = False
        Me.TtBo_Camb_MunicipioEmp.Location = New System.Drawing.Point(572, 163)
        Me.TtBo_Camb_MunicipioEmp.Name = "TtBo_Camb_MunicipioEmp"
        Me.TtBo_Camb_MunicipioEmp.Size = New System.Drawing.Size(159, 23)
        Me.TtBo_Camb_MunicipioEmp.TabIndex = 16
        '
        'TtBo_Camb_ColoniaEmp
        '
        Me.TtBo_Camb_ColoniaEmp.Enabled = False
        Me.TtBo_Camb_ColoniaEmp.Location = New System.Drawing.Point(522, 134)
        Me.TtBo_Camb_ColoniaEmp.Name = "TtBo_Camb_ColoniaEmp"
        Me.TtBo_Camb_ColoniaEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Camb_ColoniaEmp.TabIndex = 15
        '
        'TtBo_Camb_NumExtEmp
        '
        Me.TtBo_Camb_NumExtEmp.Enabled = False
        Me.TtBo_Camb_NumExtEmp.Location = New System.Drawing.Point(522, 105)
        Me.TtBo_Camb_NumExtEmp.Name = "TtBo_Camb_NumExtEmp"
        Me.TtBo_Camb_NumExtEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Camb_NumExtEmp.TabIndex = 14
        '
        'TtBo_Camb_NumIntEmp
        '
        Me.TtBo_Camb_NumIntEmp.Enabled = False
        Me.TtBo_Camb_NumIntEmp.Location = New System.Drawing.Point(522, 76)
        Me.TtBo_Camb_NumIntEmp.Name = "TtBo_Camb_NumIntEmp"
        Me.TtBo_Camb_NumIntEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Camb_NumIntEmp.TabIndex = 13
        '
        'Lab_Camb_EstadoEmp
        '
        Me.Lab_Camb_EstadoEmp.AutoSize = True
        Me.Lab_Camb_EstadoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_EstadoEmp.Location = New System.Drawing.Point(411, 225)
        Me.Lab_Camb_EstadoEmp.Name = "Lab_Camb_EstadoEmp"
        Me.Lab_Camb_EstadoEmp.Size = New System.Drawing.Size(56, 17)
        Me.Lab_Camb_EstadoEmp.TabIndex = 64
        Me.Lab_Camb_EstadoEmp.Text = "Estado:"
        '
        'Lab_Camb_MunicipioEmp
        '
        Me.Lab_Camb_MunicipioEmp.AutoSize = True
        Me.Lab_Camb_MunicipioEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_MunicipioEmp.Location = New System.Drawing.Point(411, 163)
        Me.Lab_Camb_MunicipioEmp.Name = "Lab_Camb_MunicipioEmp"
        Me.Lab_Camb_MunicipioEmp.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Camb_MunicipioEmp.TabIndex = 63
        Me.Lab_Camb_MunicipioEmp.Text = "Municipio / Delegación:"
        '
        'Lab_Camb_ColoniaEmp
        '
        Me.Lab_Camb_ColoniaEmp.AutoSize = True
        Me.Lab_Camb_ColoniaEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_ColoniaEmp.Location = New System.Drawing.Point(414, 137)
        Me.Lab_Camb_ColoniaEmp.Name = "Lab_Camb_ColoniaEmp"
        Me.Lab_Camb_ColoniaEmp.Size = New System.Drawing.Size(59, 17)
        Me.Lab_Camb_ColoniaEmp.TabIndex = 62
        Me.Lab_Camb_ColoniaEmp.Text = "Colonia:"
        '
        'Lab_Camb_NumExtEmp
        '
        Me.Lab_Camb_NumExtEmp.AutoSize = True
        Me.Lab_Camb_NumExtEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_NumExtEmp.Location = New System.Drawing.Point(411, 108)
        Me.Lab_Camb_NumExtEmp.Name = "Lab_Camb_NumExtEmp"
        Me.Lab_Camb_NumExtEmp.Size = New System.Drawing.Size(113, 17)
        Me.Lab_Camb_NumExtEmp.TabIndex = 61
        Me.Lab_Camb_NumExtEmp.Text = "Número exterior:"
        '
        'Lab_Camb_NumIntEmp
        '
        Me.Lab_Camb_NumIntEmp.AutoSize = True
        Me.Lab_Camb_NumIntEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_NumIntEmp.Location = New System.Drawing.Point(411, 79)
        Me.Lab_Camb_NumIntEmp.Name = "Lab_Camb_NumIntEmp"
        Me.Lab_Camb_NumIntEmp.Size = New System.Drawing.Size(110, 17)
        Me.Lab_Camb_NumIntEmp.TabIndex = 60
        Me.Lab_Camb_NumIntEmp.Text = "Número interior:"
        '
        'TtBo_Camb_TelefFijoEmp
        '
        Me.TtBo_Camb_TelefFijoEmp.Enabled = False
        Me.TtBo_Camb_TelefFijoEmp.Location = New System.Drawing.Point(522, 280)
        Me.TtBo_Camb_TelefFijoEmp.Name = "TtBo_Camb_TelefFijoEmp"
        Me.TtBo_Camb_TelefFijoEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Camb_TelefFijoEmp.TabIndex = 20
        '
        'Lab_Camb_TelefFijoEmp
        '
        Me.Lab_Camb_TelefFijoEmp.AutoSize = True
        Me.Lab_Camb_TelefFijoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_TelefFijoEmp.Location = New System.Drawing.Point(411, 280)
        Me.Lab_Camb_TelefFijoEmp.Name = "Lab_Camb_TelefFijoEmp"
        Me.Lab_Camb_TelefFijoEmp.Size = New System.Drawing.Size(90, 17)
        Me.Lab_Camb_TelefFijoEmp.TabIndex = 58
        Me.Lab_Camb_TelefFijoEmp.Text = "Teléfono fijo:"
        '
        'TtBo_Camb_TelefMovilEmp
        '
        Me.TtBo_Camb_TelefMovilEmp.Enabled = False
        Me.TtBo_Camb_TelefMovilEmp.Location = New System.Drawing.Point(522, 251)
        Me.TtBo_Camb_TelefMovilEmp.Name = "TtBo_Camb_TelefMovilEmp"
        Me.TtBo_Camb_TelefMovilEmp.Size = New System.Drawing.Size(209, 23)
        Me.TtBo_Camb_TelefMovilEmp.TabIndex = 19
        '
        'Lab_Camb_TelefMovilEmp
        '
        Me.Lab_Camb_TelefMovilEmp.AutoSize = True
        Me.Lab_Camb_TelefMovilEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_TelefMovilEmp.Location = New System.Drawing.Point(411, 254)
        Me.Lab_Camb_TelefMovilEmp.Name = "Lab_Camb_TelefMovilEmp"
        Me.Lab_Camb_TelefMovilEmp.Size = New System.Drawing.Size(114, 17)
        Me.Lab_Camb_TelefMovilEmp.TabIndex = 56
        Me.Lab_Camb_TelefMovilEmp.Text = "Teléfono celular:"
        '
        'RaBo_Camb_SMasculinoEmp
        '
        Me.RaBo_Camb_SMasculinoEmp.AutoSize = True
        Me.RaBo_Camb_SMasculinoEmp.Enabled = False
        Me.RaBo_Camb_SMasculinoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Camb_SMasculinoEmp.Location = New System.Drawing.Point(299, 156)
        Me.RaBo_Camb_SMasculinoEmp.Name = "RaBo_Camb_SMasculinoEmp"
        Me.RaBo_Camb_SMasculinoEmp.Size = New System.Drawing.Size(89, 21)
        Me.RaBo_Camb_SMasculinoEmp.TabIndex = 6
        Me.RaBo_Camb_SMasculinoEmp.TabStop = True
        Me.RaBo_Camb_SMasculinoEmp.Text = "Masculino"
        Me.RaBo_Camb_SMasculinoEmp.UseVisualStyleBackColor = True
        '
        'RaBo_Camb_SFemeninoEmp
        '
        Me.RaBo_Camb_SFemeninoEmp.AutoSize = True
        Me.RaBo_Camb_SFemeninoEmp.Enabled = False
        Me.RaBo_Camb_SFemeninoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RaBo_Camb_SFemeninoEmp.Location = New System.Drawing.Point(162, 156)
        Me.RaBo_Camb_SFemeninoEmp.Name = "RaBo_Camb_SFemeninoEmp"
        Me.RaBo_Camb_SFemeninoEmp.Size = New System.Drawing.Size(88, 21)
        Me.RaBo_Camb_SFemeninoEmp.TabIndex = 5
        Me.RaBo_Camb_SFemeninoEmp.TabStop = True
        Me.RaBo_Camb_SFemeninoEmp.Text = "Femenino"
        Me.RaBo_Camb_SFemeninoEmp.UseVisualStyleBackColor = True
        '
        'Lab_Camb_SexoEmp
        '
        Me.Lab_Camb_SexoEmp.AutoSize = True
        Me.Lab_Camb_SexoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_SexoEmp.Location = New System.Drawing.Point(39, 156)
        Me.Lab_Camb_SexoEmp.Name = "Lab_Camb_SexoEmp"
        Me.Lab_Camb_SexoEmp.Size = New System.Drawing.Size(43, 17)
        Me.Lab_Camb_SexoEmp.TabIndex = 53
        Me.Lab_Camb_SexoEmp.Text = "Sexo:"
        '
        'DaTiPi_Camb_FechNacEmp
        '
        Me.DaTiPi_Camb_FechNacEmp.Enabled = False
        Me.DaTiPi_Camb_FechNacEmp.Location = New System.Drawing.Point(189, 121)
        Me.DaTiPi_Camb_FechNacEmp.MaxDate = New Date(2021, 12, 15, 0, 0, 0, 0)
        Me.DaTiPi_Camb_FechNacEmp.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DaTiPi_Camb_FechNacEmp.Name = "DaTiPi_Camb_FechNacEmp"
        Me.DaTiPi_Camb_FechNacEmp.Size = New System.Drawing.Size(200, 23)
        Me.DaTiPi_Camb_FechNacEmp.TabIndex = 4
        Me.DaTiPi_Camb_FechNacEmp.Value = New Date(2021, 12, 15, 0, 0, 0, 0)
        '
        'Lab_Camb_FechNacEmp
        '
        Me.Lab_Camb_FechNacEmp.AutoSize = True
        Me.Lab_Camb_FechNacEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_FechNacEmp.Location = New System.Drawing.Point(39, 121)
        Me.Lab_Camb_FechNacEmp.Name = "Lab_Camb_FechNacEmp"
        Me.Lab_Camb_FechNacEmp.Size = New System.Drawing.Size(143, 17)
        Me.Lab_Camb_FechNacEmp.TabIndex = 51
        Me.Lab_Camb_FechNacEmp.Text = "Fecha de nacimiento:"
        '
        'TtBo_Camb_AmatEmp
        '
        Me.TtBo_Camb_AmatEmp.Location = New System.Drawing.Point(162, 88)
        Me.TtBo_Camb_AmatEmp.Name = "TtBo_Camb_AmatEmp"
        Me.TtBo_Camb_AmatEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Camb_AmatEmp.TabIndex = 3
        '
        'TtBo_Camb_ApatEmp
        '
        Me.TtBo_Camb_ApatEmp.Location = New System.Drawing.Point(162, 56)
        Me.TtBo_Camb_ApatEmp.Name = "TtBo_Camb_ApatEmp"
        Me.TtBo_Camb_ApatEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Camb_ApatEmp.TabIndex = 2
        '
        'Lab_Camb_AmatEmp
        '
        Me.Lab_Camb_AmatEmp.AutoSize = True
        Me.Lab_Camb_AmatEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_AmatEmp.Location = New System.Drawing.Point(39, 88)
        Me.Lab_Camb_AmatEmp.Name = "Lab_Camb_AmatEmp"
        Me.Lab_Camb_AmatEmp.Size = New System.Drawing.Size(118, 17)
        Me.Lab_Camb_AmatEmp.TabIndex = 48
        Me.Lab_Camb_AmatEmp.Text = "Apellido materno:"
        '
        'Lab_Camb_ApatEmp
        '
        Me.Lab_Camb_ApatEmp.AutoSize = True
        Me.Lab_Camb_ApatEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_ApatEmp.Location = New System.Drawing.Point(39, 56)
        Me.Lab_Camb_ApatEmp.Name = "Lab_Camb_ApatEmp"
        Me.Lab_Camb_ApatEmp.Size = New System.Drawing.Size(115, 17)
        Me.Lab_Camb_ApatEmp.TabIndex = 47
        Me.Lab_Camb_ApatEmp.Text = "Apellido paterno:"
        '
        'TtBo_Camb_NombEmp
        '
        Me.TtBo_Camb_NombEmp.Location = New System.Drawing.Point(162, 18)
        Me.TtBo_Camb_NombEmp.Name = "TtBo_Camb_NombEmp"
        Me.TtBo_Camb_NombEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Camb_NombEmp.TabIndex = 1
        '
        'Lab_Camb_NombEmp
        '
        Me.Lab_Camb_NombEmp.AutoSize = True
        Me.Lab_Camb_NombEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_NombEmp.Location = New System.Drawing.Point(39, 18)
        Me.Lab_Camb_NombEmp.Name = "Lab_Camb_NombEmp"
        Me.Lab_Camb_NombEmp.Size = New System.Drawing.Size(73, 17)
        Me.Lab_Camb_NombEmp.TabIndex = 45
        Me.Lab_Camb_NombEmp.Text = "Nombre/s:"
        '
        'Baja_Empleado
        '
        Me.Baja_Empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baja_Empleado.Controls.Add(Me.DGV_Baja_ListaEmp)
        Me.Baja_Empleado.Controls.Add(Me.Btn_Baja_Eliminar)
        Me.Baja_Empleado.Controls.Add(Me.Btn_Baja_Buscar)
        Me.Baja_Empleado.Controls.Add(Me.Lab_Baja_CurpNota)
        Me.Baja_Empleado.Controls.Add(Me.TtBo_Baja_CurpEmp)
        Me.Baja_Empleado.Controls.Add(Me.Lab_Baja_CurpEmp)
        Me.Baja_Empleado.Controls.Add(Me.TtBo_Baja_AmatEmp)
        Me.Baja_Empleado.Controls.Add(Me.TtBo_Baja_ApatEmp)
        Me.Baja_Empleado.Controls.Add(Me.Lab_Baja_AmatEmp)
        Me.Baja_Empleado.Controls.Add(Me.Lab_Baja_ApatEmp)
        Me.Baja_Empleado.Controls.Add(Me.TtBo_Baja_NombEmp)
        Me.Baja_Empleado.Controls.Add(Me.Lab_Baja_NombEmp)
        Me.Baja_Empleado.Location = New System.Drawing.Point(4, 25)
        Me.Baja_Empleado.Name = "Baja_Empleado"
        Me.Baja_Empleado.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Empleado.Size = New System.Drawing.Size(768, 377)
        Me.Baja_Empleado.TabIndex = 1
        Me.Baja_Empleado.Text = "Baja de empleado"
        '
        'DGV_Baja_ListaEmp
        '
        Me.DGV_Baja_ListaEmp.BackgroundColor = System.Drawing.Color.Silver
        Me.DGV_Baja_ListaEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Baja_ListaEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DGV_Baja_ListaEmp.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_Baja_ListaEmp.Location = New System.Drawing.Point(6, 209)
        Me.DGV_Baja_ListaEmp.Name = "DGV_Baja_ListaEmp"
        Me.DGV_Baja_ListaEmp.Size = New System.Drawing.Size(743, 141)
        Me.DGV_Baja_ListaEmp.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 3
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Completo"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha de nacimiento"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "CURP o RNE"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 80
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Domicilio"
        Me.DataGridViewTextBoxColumn7.MaxInputLength = 250
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Btn_Baja_Eliminar
        '
        Me.Btn_Baja_Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Baja_Eliminar.Enabled = False
        Me.Btn_Baja_Eliminar.Location = New System.Drawing.Point(530, 164)
        Me.Btn_Baja_Eliminar.Name = "Btn_Baja_Eliminar"
        Me.Btn_Baja_Eliminar.Size = New System.Drawing.Size(100, 23)
        Me.Btn_Baja_Eliminar.TabIndex = 6
        Me.Btn_Baja_Eliminar.Text = "Eliminar"
        Me.Btn_Baja_Eliminar.UseVisualStyleBackColor = False
        '
        'Btn_Baja_Buscar
        '
        Me.Btn_Baja_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Baja_Buscar.Location = New System.Drawing.Point(403, 164)
        Me.Btn_Baja_Buscar.Name = "Btn_Baja_Buscar"
        Me.Btn_Baja_Buscar.Size = New System.Drawing.Size(100, 23)
        Me.Btn_Baja_Buscar.TabIndex = 5
        Me.Btn_Baja_Buscar.Text = "Buscar"
        Me.Btn_Baja_Buscar.UseVisualStyleBackColor = False
        '
        'Lab_Baja_CurpNota
        '
        Me.Lab_Baja_CurpNota.AutoSize = True
        Me.Lab_Baja_CurpNota.Location = New System.Drawing.Point(281, 144)
        Me.Lab_Baja_CurpNota.Name = "Lab_Baja_CurpNota"
        Me.Lab_Baja_CurpNota.Size = New System.Drawing.Size(265, 17)
        Me.Lab_Baja_CurpNota.TabIndex = 50
        Me.Lab_Baja_CurpNota.Text = "* RNE: Registro Nacional de Extranjeros."
        '
        'TtBo_Baja_CurpEmp
        '
        Me.TtBo_Baja_CurpEmp.Location = New System.Drawing.Point(403, 121)
        Me.TtBo_Baja_CurpEmp.MaxLength = 18
        Me.TtBo_Baja_CurpEmp.Name = "TtBo_Baja_CurpEmp"
        Me.TtBo_Baja_CurpEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Baja_CurpEmp.TabIndex = 4
        '
        'Lab_Baja_CurpEmp
        '
        Me.Lab_Baja_CurpEmp.AutoSize = True
        Me.Lab_Baja_CurpEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Baja_CurpEmp.Location = New System.Drawing.Point(280, 121)
        Me.Lab_Baja_CurpEmp.Name = "Lab_Baja_CurpEmp"
        Me.Lab_Baja_CurpEmp.Size = New System.Drawing.Size(91, 17)
        Me.Lab_Baja_CurpEmp.TabIndex = 48
        Me.Lab_Baja_CurpEmp.Text = "CURP o RNE"
        '
        'TtBo_Baja_AmatEmp
        '
        Me.TtBo_Baja_AmatEmp.Location = New System.Drawing.Point(403, 90)
        Me.TtBo_Baja_AmatEmp.Name = "TtBo_Baja_AmatEmp"
        Me.TtBo_Baja_AmatEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Baja_AmatEmp.TabIndex = 3
        '
        'TtBo_Baja_ApatEmp
        '
        Me.TtBo_Baja_ApatEmp.Location = New System.Drawing.Point(403, 58)
        Me.TtBo_Baja_ApatEmp.Name = "TtBo_Baja_ApatEmp"
        Me.TtBo_Baja_ApatEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Baja_ApatEmp.TabIndex = 2
        '
        'Lab_Baja_AmatEmp
        '
        Me.Lab_Baja_AmatEmp.AutoSize = True
        Me.Lab_Baja_AmatEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Baja_AmatEmp.Location = New System.Drawing.Point(280, 90)
        Me.Lab_Baja_AmatEmp.Name = "Lab_Baja_AmatEmp"
        Me.Lab_Baja_AmatEmp.Size = New System.Drawing.Size(118, 17)
        Me.Lab_Baja_AmatEmp.TabIndex = 45
        Me.Lab_Baja_AmatEmp.Text = "Apellido materno:"
        '
        'Lab_Baja_ApatEmp
        '
        Me.Lab_Baja_ApatEmp.AutoSize = True
        Me.Lab_Baja_ApatEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Baja_ApatEmp.Location = New System.Drawing.Point(280, 58)
        Me.Lab_Baja_ApatEmp.Name = "Lab_Baja_ApatEmp"
        Me.Lab_Baja_ApatEmp.Size = New System.Drawing.Size(115, 17)
        Me.Lab_Baja_ApatEmp.TabIndex = 44
        Me.Lab_Baja_ApatEmp.Text = "Apellido paterno:"
        '
        'TtBo_Baja_NombEmp
        '
        Me.TtBo_Baja_NombEmp.Location = New System.Drawing.Point(403, 20)
        Me.TtBo_Baja_NombEmp.Name = "TtBo_Baja_NombEmp"
        Me.TtBo_Baja_NombEmp.Size = New System.Drawing.Size(227, 23)
        Me.TtBo_Baja_NombEmp.TabIndex = 1
        '
        'Lab_Baja_NombEmp
        '
        Me.Lab_Baja_NombEmp.AutoSize = True
        Me.Lab_Baja_NombEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Baja_NombEmp.Location = New System.Drawing.Point(280, 20)
        Me.Lab_Baja_NombEmp.Name = "Lab_Baja_NombEmp"
        Me.Lab_Baja_NombEmp.Size = New System.Drawing.Size(73, 17)
        Me.Lab_Baja_NombEmp.TabIndex = 42
        Me.Lab_Baja_NombEmp.Text = "Nombre/s:"
        '
        'Lab_Camb_HrSalEmp
        '
        Me.Lab_Camb_HrSalEmp.AutoSize = True
        Me.Lab_Camb_HrSalEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_HrSalEmp.Location = New System.Drawing.Point(40, 380)
        Me.Lab_Camb_HrSalEmp.Name = "Lab_Camb_HrSalEmp"
        Me.Lab_Camb_HrSalEmp.Size = New System.Drawing.Size(120, 17)
        Me.Lab_Camb_HrSalEmp.TabIndex = 96
        Me.Lab_Camb_HrSalEmp.Text = "Horario de salida:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(522, 18)
        Me.MaskedTextBox1.Mask = "99999.99"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(209, 23)
        Me.MaskedTextBox1.TabIndex = 92
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Camb_SueldoEmp
        '
        Me.Lab_Camb_SueldoEmp.AutoSize = True
        Me.Lab_Camb_SueldoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_SueldoEmp.Location = New System.Drawing.Point(414, 24)
        Me.Lab_Camb_SueldoEmp.Name = "Lab_Camb_SueldoEmp"
        Me.Lab_Camb_SueldoEmp.Size = New System.Drawing.Size(56, 17)
        Me.Lab_Camb_SueldoEmp.TabIndex = 95
        Me.Lab_Camb_SueldoEmp.Text = "Sueldo:"
        '
        'CoBo_Camb_HrSalEmp
        '
        Me.CoBo_Camb_HrSalEmp.FormattingEnabled = True
        Me.CoBo_Camb_HrSalEmp.Items.AddRange(New Object() {"6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00"})
        Me.CoBo_Camb_HrSalEmp.Location = New System.Drawing.Point(180, 377)
        Me.CoBo_Camb_HrSalEmp.Name = "CoBo_Camb_HrSalEmp"
        Me.CoBo_Camb_HrSalEmp.Size = New System.Drawing.Size(61, 24)
        Me.CoBo_Camb_HrSalEmp.TabIndex = 90
        '
        'CoBo_Camb_MeridianoSalEmp
        '
        Me.CoBo_Camb_MeridianoSalEmp.FormattingEnabled = True
        Me.CoBo_Camb_MeridianoSalEmp.Items.AddRange(New Object() {"Am", "Pm"})
        Me.CoBo_Camb_MeridianoSalEmp.Location = New System.Drawing.Point(278, 376)
        Me.CoBo_Camb_MeridianoSalEmp.Name = "CoBo_Camb_MeridianoSalEmp"
        Me.CoBo_Camb_MeridianoSalEmp.Size = New System.Drawing.Size(60, 24)
        Me.CoBo_Camb_MeridianoSalEmp.TabIndex = 91
        '
        'CoBo_Camb_MeridianoEntEmp
        '
        Me.CoBo_Camb_MeridianoEntEmp.FormattingEnabled = True
        Me.CoBo_Camb_MeridianoEntEmp.Items.AddRange(New Object() {"Am", "Pm"})
        Me.CoBo_Camb_MeridianoEntEmp.Location = New System.Drawing.Point(278, 349)
        Me.CoBo_Camb_MeridianoEntEmp.Name = "CoBo_Camb_MeridianoEntEmp"
        Me.CoBo_Camb_MeridianoEntEmp.Size = New System.Drawing.Size(60, 24)
        Me.CoBo_Camb_MeridianoEntEmp.TabIndex = 89
        '
        'CoBo_Camb_HrEntEmp
        '
        Me.CoBo_Camb_HrEntEmp.FormattingEnabled = True
        Me.CoBo_Camb_HrEntEmp.Items.AddRange(New Object() {"6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00"})
        Me.CoBo_Camb_HrEntEmp.Location = New System.Drawing.Point(180, 348)
        Me.CoBo_Camb_HrEntEmp.Name = "CoBo_Camb_HrEntEmp"
        Me.CoBo_Camb_HrEntEmp.Size = New System.Drawing.Size(61, 24)
        Me.CoBo_Camb_HrEntEmp.TabIndex = 88
        '
        'Lab_Camb_HrEntEmp
        '
        Me.Lab_Camb_HrEntEmp.AutoSize = True
        Me.Lab_Camb_HrEntEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_HrEntEmp.Location = New System.Drawing.Point(39, 351)
        Me.Lab_Camb_HrEntEmp.Name = "Lab_Camb_HrEntEmp"
        Me.Lab_Camb_HrEntEmp.Size = New System.Drawing.Size(132, 17)
        Me.Lab_Camb_HrEntEmp.TabIndex = 94
        Me.Lab_Camb_HrEntEmp.Text = "Horario de entrada:"
        '
        'CoBo_Camb_TurnoEmp
        '
        Me.CoBo_Camb_TurnoEmp.FormattingEnabled = True
        Me.CoBo_Camb_TurnoEmp.Items.AddRange(New Object() {"Diurno", "Nocturno"})
        Me.CoBo_Camb_TurnoEmp.Location = New System.Drawing.Point(180, 318)
        Me.CoBo_Camb_TurnoEmp.Name = "CoBo_Camb_TurnoEmp"
        Me.CoBo_Camb_TurnoEmp.Size = New System.Drawing.Size(209, 24)
        Me.CoBo_Camb_TurnoEmp.TabIndex = 87
        '
        'Lab_Camb_TurnoEmp
        '
        Me.Lab_Camb_TurnoEmp.AutoSize = True
        Me.Lab_Camb_TurnoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_TurnoEmp.Location = New System.Drawing.Point(40, 315)
        Me.Lab_Camb_TurnoEmp.Name = "Lab_Camb_TurnoEmp"
        Me.Lab_Camb_TurnoEmp.Size = New System.Drawing.Size(50, 17)
        Me.Lab_Camb_TurnoEmp.TabIndex = 93
        Me.Lab_Camb_TurnoEmp.Text = "Turno:"
        '
        'Form_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile1
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.Tab_Ctr_Empleados)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_Empleados.ResumeLayout(False)
        Me.Alta_Empleado.ResumeLayout(False)
        Me.Alta_Empleado.PerformLayout()
        Me.Consulta_Empleado.ResumeLayout(False)
        Me.Consulta_Empleado.PerformLayout()
        CType(Me.DGV_ListaEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cambio_Empleado.ResumeLayout(False)
        Me.Cambio_Empleado.PerformLayout()
        Me.Baja_Empleado.ResumeLayout(False)
        Me.Baja_Empleado.PerformLayout()
        CType(Me.DGV_Baja_ListaEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_atras As Button
    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tab_Ctr_Empleados As TabControl
    Friend WithEvents Alta_Empleado As TabPage
    Friend WithEvents Baja_Empleado As TabPage
    Friend WithEvents Consulta_Empleado As TabPage
    Friend WithEvents Cambio_Empleado As TabPage
    Friend WithEvents DaTiPi_Alta_FechNacEmp As DateTimePicker
    Friend WithEvents Lab_Alta_FechaNacEmp As Label
    Friend WithEvents TtBo_Alta_AmatEmp As TextBox
    Friend WithEvents TtBo_Alta_ApatEmp As TextBox
    Friend WithEvents Lab_Alta_AmatEmp As Label
    Friend WithEvents Lab_Alta_ApatEmp As Label
    Friend WithEvents TtBo_Alta_NombEmp As TextBox
    Friend WithEvents Lab_Alta_NombEmp As Label
    Friend WithEvents Btn_Alta_LimpiarEmp As Button
    Friend WithEvents Btn_Alta_GuardaEmp As Button
    Friend WithEvents Lab_Alta_CurpNota As Label
    Friend WithEvents TtBo_Alta_CurpEmp As TextBox
    Friend WithEvents Lab_Alta_CurpEmp As Label
    Friend WithEvents TtBo_Alta_NaclidadOrigEmp As TextBox
    Friend WithEvents Lab_Alta_NaclidadOrigEmp As Label
    Friend WithEvents RaBo_Alta_NaclidadExtjEmp As RadioButton
    Friend WithEvents RaBo_Alta_NaclidadMexEmp As RadioButton
    Friend WithEvents Lab_Alta_NaclidadEmp As Label
    Friend WithEvents TtBo_Alta_EmailEmp As TextBox
    Friend WithEvents Lab_Alta_EmailEmp As Label
    Friend WithEvents TtBo_Alta_CpEmp As TextBox
    Friend WithEvents Lab_Alta_CpEmp As Label
    Friend WithEvents CoBo_Alta_EstadoEmp As ComboBox
    Friend WithEvents TtBo_Alta_MunicipioEmp As TextBox
    Friend WithEvents TtBo_Alta_ColoniaEmp As TextBox
    Friend WithEvents TtBo_Alta_NumExtEmp As TextBox
    Friend WithEvents TtBo_Alta_NumIntEmp As TextBox
    Friend WithEvents Lab_Alta_EstadoEmp As Label
    Friend WithEvents Lab_Alta_MunicipioEmp As Label
    Friend WithEvents Lab_Alta_ColoniaEmp As Label
    Friend WithEvents Lab_Alta_NumExtEmp As Label
    Friend WithEvents Lab_Alta_NumIntEmp As Label
    Friend WithEvents TtBo_Alta_TelefFijoEmp As TextBox
    Friend WithEvents Lab_Alta_TelefFijoEmp As Label
    Friend WithEvents TtBo_Alta_TelefMoviEmp As TextBox
    Friend WithEvents Lab_Alta_TelefMovEmp As Label
    Friend WithEvents RaBo_Alta_SMasculinoEmp As RadioButton
    Friend WithEvents RaBo_Alta_SFemeninoEmp As RadioButton
    Friend WithEvents Lab_Alta_SexoEmp As Label
    Friend WithEvents TtBo_Alta_PuestoTrabEmp As TextBox
    Friend WithEvents Lab_Alta_PuestoTrabEmp As Label
    Friend WithEvents TtBo_Cons_AmatEmp As TextBox
    Friend WithEvents TtBo_Cons_ApatEmp As TextBox
    Friend WithEvents Lab_Cons_AmatEmp As Label
    Friend WithEvents Lab_Cons_ApatEmp As Label
    Friend WithEvents TtBo_Cons_NombEmp As TextBox
    Friend WithEvents Lab_Cons_NombEmp As Label
    Friend WithEvents DGV_ListaEmp As DataGridView
    Friend WithEvents DGV_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_NombraComp As DataGridViewTextBoxColumn
    Friend WithEvents DGV_FNac As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Sexo As DataGridViewTextBoxColumn
    Friend WithEvents DGV_CurpORne As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Cargo As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Domio As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Cons_Consultar As Button
    Friend WithEvents Lab_Cons_CurpNota As Label
    Friend WithEvents TtBo_Cons_CurpEmp As TextBox
    Friend WithEvents Lab_Cons_CurpbEmp As Label
    Friend WithEvents TtBo_Camb_PuestoTrabEmp As TextBox
    Friend WithEvents Lab_Camb_PuestoTrabEmp As Label
    Friend WithEvents Btn_Camb_Limpiar As Button
    Friend WithEvents Btn_Camb_Guardar As Button
    Friend WithEvents TtBo_Camb_CalleEmp As TextBox
    Friend WithEvents Lab_Camb_CalleEmp As Label
    Friend WithEvents Lab_Camb_CurpNota As Label
    Friend WithEvents TtBo_Camb_CurpEmp As TextBox
    Friend WithEvents Lab_Camb_CurpEmp As Label
    Friend WithEvents TtBo_Camb_NaclidadOrigEmp As TextBox
    Friend WithEvents Lab_Camb_NaclidadOrigEmp As Label
    Friend WithEvents RaBo_Camb_NaclidadExtjEmp As RadioButton
    Friend WithEvents RaBo_Camb_NaclidadMexEmp As RadioButton
    Friend WithEvents Lab_Camb_NaclidadEmp As Label
    Friend WithEvents TtBo_Camb_EmailEmp As TextBox
    Friend WithEvents Lab_Camb_EmailEmp As Label
    Friend WithEvents TtBo_Camb_CpEmp As TextBox
    Friend WithEvents Lab_Camb_CpEmp As Label
    Friend WithEvents CoBo_Camb_EstadoEmp As ComboBox
    Friend WithEvents TtBo_Camb_MunicipioEmp As TextBox
    Friend WithEvents TtBo_Camb_ColoniaEmp As TextBox
    Friend WithEvents TtBo_Camb_NumExtEmp As TextBox
    Friend WithEvents TtBo_Camb_NumIntEmp As TextBox
    Friend WithEvents Lab_Camb_EstadoEmp As Label
    Friend WithEvents Lab_Camb_MunicipioEmp As Label
    Friend WithEvents Lab_Camb_ColoniaEmp As Label
    Friend WithEvents Lab_Camb_NumExtEmp As Label
    Friend WithEvents Lab_Camb_NumIntEmp As Label
    Friend WithEvents TtBo_Camb_TelefFijoEmp As TextBox
    Friend WithEvents Lab_Camb_TelefFijoEmp As Label
    Friend WithEvents TtBo_Camb_TelefMovilEmp As TextBox
    Friend WithEvents Lab_Camb_TelefMovilEmp As Label
    Friend WithEvents RaBo_Camb_SMasculinoEmp As RadioButton
    Friend WithEvents RaBo_Camb_SFemeninoEmp As RadioButton
    Friend WithEvents Lab_Camb_SexoEmp As Label
    Friend WithEvents DaTiPi_Camb_FechNacEmp As DateTimePicker
    Friend WithEvents Lab_Camb_FechNacEmp As Label
    Friend WithEvents TtBo_Camb_AmatEmp As TextBox
    Friend WithEvents TtBo_Camb_ApatEmp As TextBox
    Friend WithEvents Lab_Camb_AmatEmp As Label
    Friend WithEvents Lab_Camb_ApatEmp As Label
    Friend WithEvents TtBo_Camb_NombEmp As TextBox
    Friend WithEvents Lab_Camb_NombEmp As Label
    Friend WithEvents Btn_Camb_Buscar As Button
    Friend WithEvents DGV_Baja_ListaEmp As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Baja_Eliminar As Button
    Friend WithEvents Btn_Baja_Buscar As Button
    Friend WithEvents Lab_Baja_CurpNota As Label
    Friend WithEvents TtBo_Baja_CurpEmp As TextBox
    Friend WithEvents Lab_Baja_CurpEmp As Label
    Friend WithEvents TtBo_Baja_AmatEmp As TextBox
    Friend WithEvents TtBo_Baja_ApatEmp As TextBox
    Friend WithEvents Lab_Baja_AmatEmp As Label
    Friend WithEvents Lab_Baja_ApatEmp As Label
    Friend WithEvents TtBo_Baja_NombEmp As TextBox
    Friend WithEvents Lab_Baja_NombEmp As Label
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoBo_Alta_HrSalEmp As ComboBox
    Friend WithEvents CoBo_Alta_MeridianaSalEmp As ComboBox
    Friend WithEvents CoBo_Alta_MeridianaEntEmp As ComboBox
    Friend WithEvents CoBo_Alta_HrEntEmp As ComboBox
    Friend WithEvents Lab_Alta_HrEntEmp As Label
    Friend WithEvents CoBo_Alta_TurnoEmp As ComboBox
    Friend WithEvents Lab_Alta_TurnoEmp As Label
    Friend WithEvents TtBo_Alta_CalleEmp As TextBox
    Friend WithEvents Lab_Alta_CalleEmp As Label
    Friend WithEvents Lab_Alta_SueldoEmp As Label
    Friend WithEvents Mas_Alta_SueldoEmp As MaskedTextBox
    Friend WithEvents Lab_Alta_HrSalEmp As Label
    Friend WithEvents Lab_Camb_HrSalEmp As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Lab_Camb_SueldoEmp As Label
    Friend WithEvents CoBo_Camb_HrSalEmp As ComboBox
    Friend WithEvents CoBo_Camb_MeridianoSalEmp As ComboBox
    Friend WithEvents CoBo_Camb_MeridianoEntEmp As ComboBox
    Friend WithEvents CoBo_Camb_HrEntEmp As ComboBox
    Friend WithEvents Lab_Camb_HrEntEmp As Label
    Friend WithEvents CoBo_Camb_TurnoEmp As ComboBox
    Friend WithEvents Lab_Camb_TurnoEmp As Label
End Class
