<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ClientesYMascotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ClientesYMascotas))
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_Ctr_ClientesYMascotas = New System.Windows.Forms.TabControl()
        Me.Alta_Clientes = New System.Windows.Forms.TabPage()
        Me.TtBo_Alta_MunicipioDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_MunicipioDueno = New System.Windows.Forms.Label()
        Me.TtBo_Alta_CpDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_CpDueno = New System.Windows.Forms.Label()
        Me.TtBo_Alta_TelefDueno = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NumeroDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_NumeroDueno = New System.Windows.Forms.Label()
        Me.Btn_Alta_AgregarMascotaDueno = New System.Windows.Forms.Button()
        Me.TtBo_Alta_EmailDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_AmatDueno = New System.Windows.Forms.Label()
        Me.TtBo_Alta_IdDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_IdDueno = New System.Windows.Forms.Label()
        Me.Btn_Alta_LimpiarDueno = New System.Windows.Forms.Button()
        Me.Btn_Alta_GuardarDueno = New System.Windows.Forms.Button()
        Me.DGV_Alta_ListaDueno = New System.Windows.Forms.DataGridView()
        Me.Id_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_paterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_materno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo_Electronico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Mascota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtBo_Alta_CalleDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_EmailDueno = New System.Windows.Forms.Label()
        Me.Lab_Alta_TelefDueno = New System.Windows.Forms.Label()
        Me.TtBo_Alta_AmatDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_CalleDueno = New System.Windows.Forms.Label()
        Me.TtBo_Alta_ApatDueno = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NombDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_ApatDueno = New System.Windows.Forms.Label()
        Me.Lab_Alta_NombDueno = New System.Windows.Forms.Label()
        Me.Consulta_Clientes = New System.Windows.Forms.TabPage()
        Me.DGV_Cons_ListDueno = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GoBo_Cons_DatosBusqClienteDueno = New System.Windows.Forms.GroupBox()
        Me.Btn_Const_BuscarTodoDueno = New System.Windows.Forms.Button()
        Me.Btn_Cons_BuscarDueno = New System.Windows.Forms.Button()
        Me.TtBo_Cons_NombDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Cons_NombDueno = New System.Windows.Forms.Label()
        Me.Baja_Clientes = New System.Windows.Forms.TabPage()
        Me.DGV_Baja_ListDueno = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GoBo_Baja_DatosBusqClienteDueno = New System.Windows.Forms.GroupBox()
        Me.Btn_Baja_BuscarDueno = New System.Windows.Forms.Button()
        Me.TtBo_Baja_NombDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Baja_NombDueno = New System.Windows.Forms.Label()
        Me.Cambio_Clientes = New System.Windows.Forms.TabPage()
        Me.Btn_Camb_LimpiarDueno = New System.Windows.Forms.Button()
        Me.Btn_Camb_ActualizarDueno = New System.Windows.Forms.Button()
        Me.GoBo_Camb_DatosGenerMascoDueno = New System.Windows.Forms.GroupBox()
        Me.Btn_Camb_CambiarImgMasDueno = New System.Windows.Forms.Button()
        Me.PiBo_Camb_ImgMasDueno = New System.Windows.Forms.PictureBox()
        Me.Lab_Camb_ImgMasDueno = New System.Windows.Forms.Label()
        Me.Lab_Camb_RazaMasDueno = New System.Windows.Forms.Label()
        Me.TtBo_Camb_RazaMasDueno = New System.Windows.Forms.TextBox()
        Me.TtBo_Camb_ColorMasDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_ColorMasDueno = New System.Windows.Forms.Label()
        Me.TtBo_Camb_EdadMasDueno = New System.Windows.Forms.TextBox()
        Me.TtBo_Camb_TipoMasDueno = New System.Windows.Forms.TextBox()
        Me.TtBo_Camb_NombMasDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_EdadMasDueno = New System.Windows.Forms.Label()
        Me.Lab_Camb_TipoMasDueno = New System.Windows.Forms.Label()
        Me.Lab_Camb_NombMasDueno = New System.Windows.Forms.Label()
        Me.GoBo_Camb_DatosGenerDueno = New System.Windows.Forms.GroupBox()
        Me.TtBo_Camb_EmailDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_AmatDueno = New System.Windows.Forms.Label()
        Me.TtBo_Camb_IdDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_IdDueno = New System.Windows.Forms.Label()
        Me.TtBo_Camb_DireccDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_EmailDueno = New System.Windows.Forms.Label()
        Me.TtBo_Camb_TelefDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_TelefDueno = New System.Windows.Forms.Label()
        Me.TtBo_Camb_AmatDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_DireccDueno = New System.Windows.Forms.Label()
        Me.TtBo_Camb_ApatDueno = New System.Windows.Forms.TextBox()
        Me.TtBo_Camb_NombDueno = New System.Windows.Forms.TextBox()
        Me.Lab_Camb_ApatDueno = New System.Windows.Forms.Label()
        Me.Lab_Camb_NombDueno = New System.Windows.Forms.Label()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_ClientesYMascotas.SuspendLayout()
        Me.Alta_Clientes.SuspendLayout()
        CType(Me.DGV_Alta_ListaDueno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Consulta_Clientes.SuspendLayout()
        CType(Me.DGV_Cons_ListDueno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GoBo_Cons_DatosBusqClienteDueno.SuspendLayout()
        Me.Baja_Clientes.SuspendLayout()
        CType(Me.DGV_Baja_ListDueno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GoBo_Baja_DatosBusqClienteDueno.SuspendLayout()
        Me.Cambio_Clientes.SuspendLayout()
        Me.GoBo_Camb_DatosGenerMascoDueno.SuspendLayout()
        CType(Me.PiBo_Camb_ImgMasDueno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GoBo_Camb_DatosGenerDueno.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(12, 27)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(75, 23)
        Me.Btn_atras.TabIndex = 4
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1})
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
        'Tab_Ctr_ClientesYMascotas
        '
        Me.Tab_Ctr_ClientesYMascotas.Controls.Add(Me.Alta_Clientes)
        Me.Tab_Ctr_ClientesYMascotas.Controls.Add(Me.Consulta_Clientes)
        Me.Tab_Ctr_ClientesYMascotas.Controls.Add(Me.Baja_Clientes)
        Me.Tab_Ctr_ClientesYMascotas.Controls.Add(Me.Cambio_Clientes)
        Me.Tab_Ctr_ClientesYMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Ctr_ClientesYMascotas.Location = New System.Drawing.Point(12, 56)
        Me.Tab_Ctr_ClientesYMascotas.Name = "Tab_Ctr_ClientesYMascotas"
        Me.Tab_Ctr_ClientesYMascotas.SelectedIndex = 0
        Me.Tab_Ctr_ClientesYMascotas.Size = New System.Drawing.Size(776, 382)
        Me.Tab_Ctr_ClientesYMascotas.TabIndex = 5
        '
        'Alta_Clientes
        '
        Me.Alta_Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_MunicipioDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_MunicipioDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_CpDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_CpDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_TelefDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_NumeroDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_NumeroDueno)
        Me.Alta_Clientes.Controls.Add(Me.Btn_Alta_AgregarMascotaDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_EmailDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_AmatDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_IdDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_IdDueno)
        Me.Alta_Clientes.Controls.Add(Me.Btn_Alta_LimpiarDueno)
        Me.Alta_Clientes.Controls.Add(Me.Btn_Alta_GuardarDueno)
        Me.Alta_Clientes.Controls.Add(Me.DGV_Alta_ListaDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_CalleDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_EmailDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_TelefDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_AmatDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_CalleDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_ApatDueno)
        Me.Alta_Clientes.Controls.Add(Me.TtBo_Alta_NombDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_ApatDueno)
        Me.Alta_Clientes.Controls.Add(Me.Lab_Alta_NombDueno)
        Me.Alta_Clientes.Location = New System.Drawing.Point(4, 25)
        Me.Alta_Clientes.Name = "Alta_Clientes"
        Me.Alta_Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Clientes.Size = New System.Drawing.Size(768, 353)
        Me.Alta_Clientes.TabIndex = 0
        Me.Alta_Clientes.Text = "Alta de clientes"
        '
        'TtBo_Alta_MunicipioDueno
        '
        Me.TtBo_Alta_MunicipioDueno.Location = New System.Drawing.Point(455, 77)
        Me.TtBo_Alta_MunicipioDueno.Name = "TtBo_Alta_MunicipioDueno"
        Me.TtBo_Alta_MunicipioDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_MunicipioDueno.TabIndex = 36
        '
        'Lab_Alta_MunicipioDueno
        '
        Me.Lab_Alta_MunicipioDueno.AutoSize = True
        Me.Lab_Alta_MunicipioDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_MunicipioDueno.Location = New System.Drawing.Point(307, 80)
        Me.Lab_Alta_MunicipioDueno.Name = "Lab_Alta_MunicipioDueno"
        Me.Lab_Alta_MunicipioDueno.Size = New System.Drawing.Size(142, 16)
        Me.Lab_Alta_MunicipioDueno.TabIndex = 35
        Me.Lab_Alta_MunicipioDueno.Text = "Municipio/Delegación:"
        '
        'TtBo_Alta_CpDueno
        '
        Me.TtBo_Alta_CpDueno.Location = New System.Drawing.Point(455, 49)
        Me.TtBo_Alta_CpDueno.Name = "TtBo_Alta_CpDueno"
        Me.TtBo_Alta_CpDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_CpDueno.TabIndex = 34
        '
        'Lab_Alta_CpDueno
        '
        Me.Lab_Alta_CpDueno.AutoSize = True
        Me.Lab_Alta_CpDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_CpDueno.Location = New System.Drawing.Point(337, 52)
        Me.Lab_Alta_CpDueno.Name = "Lab_Alta_CpDueno"
        Me.Lab_Alta_CpDueno.Size = New System.Drawing.Size(29, 16)
        Me.Lab_Alta_CpDueno.TabIndex = 33
        Me.Lab_Alta_CpDueno.Text = "CP:"
        '
        'TtBo_Alta_TelefDueno
        '
        Me.TtBo_Alta_TelefDueno.Location = New System.Drawing.Point(455, 105)
        Me.TtBo_Alta_TelefDueno.Name = "TtBo_Alta_TelefDueno"
        Me.TtBo_Alta_TelefDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_TelefDueno.TabIndex = 32
        '
        'TtBo_Alta_NumeroDueno
        '
        Me.TtBo_Alta_NumeroDueno.Location = New System.Drawing.Point(455, 21)
        Me.TtBo_Alta_NumeroDueno.Name = "TtBo_Alta_NumeroDueno"
        Me.TtBo_Alta_NumeroDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_NumeroDueno.TabIndex = 30
        '
        'Lab_Alta_NumeroDueno
        '
        Me.Lab_Alta_NumeroDueno.AutoSize = True
        Me.Lab_Alta_NumeroDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_NumeroDueno.Location = New System.Drawing.Point(337, 22)
        Me.Lab_Alta_NumeroDueno.Name = "Lab_Alta_NumeroDueno"
        Me.Lab_Alta_NumeroDueno.Size = New System.Drawing.Size(59, 16)
        Me.Lab_Alta_NumeroDueno.TabIndex = 29
        Me.Lab_Alta_NumeroDueno.Text = "Numero:"
        '
        'Btn_Alta_AgregarMascotaDueno
        '
        Me.Btn_Alta_AgregarMascotaDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Alta_AgregarMascotaDueno.Location = New System.Drawing.Point(615, 64)
        Me.Btn_Alta_AgregarMascotaDueno.Name = "Btn_Alta_AgregarMascotaDueno"
        Me.Btn_Alta_AgregarMascotaDueno.Size = New System.Drawing.Size(92, 48)
        Me.Btn_Alta_AgregarMascotaDueno.TabIndex = 28
        Me.Btn_Alta_AgregarMascotaDueno.Text = "Agregar Mascota"
        Me.Btn_Alta_AgregarMascotaDueno.UseVisualStyleBackColor = False
        '
        'TtBo_Alta_EmailDueno
        '
        Me.TtBo_Alta_EmailDueno.Location = New System.Drawing.Point(455, 133)
        Me.TtBo_Alta_EmailDueno.Name = "TtBo_Alta_EmailDueno"
        Me.TtBo_Alta_EmailDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_EmailDueno.TabIndex = 27
        '
        'Lab_Alta_AmatDueno
        '
        Me.Lab_Alta_AmatDueno.AutoSize = True
        Me.Lab_Alta_AmatDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_AmatDueno.Location = New System.Drawing.Point(25, 123)
        Me.Lab_Alta_AmatDueno.Name = "Lab_Alta_AmatDueno"
        Me.Lab_Alta_AmatDueno.Size = New System.Drawing.Size(113, 16)
        Me.Lab_Alta_AmatDueno.TabIndex = 26
        Me.Lab_Alta_AmatDueno.Text = "Apellido materno:"
        '
        'TtBo_Alta_IdDueno
        '
        Me.TtBo_Alta_IdDueno.Location = New System.Drawing.Point(151, 23)
        Me.TtBo_Alta_IdDueno.Name = "TtBo_Alta_IdDueno"
        Me.TtBo_Alta_IdDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_IdDueno.TabIndex = 25
        '
        'Lab_Alta_IdDueno
        '
        Me.Lab_Alta_IdDueno.AutoSize = True
        Me.Lab_Alta_IdDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_IdDueno.Location = New System.Drawing.Point(25, 24)
        Me.Lab_Alta_IdDueno.Name = "Lab_Alta_IdDueno"
        Me.Lab_Alta_IdDueno.Size = New System.Drawing.Size(69, 17)
        Me.Lab_Alta_IdDueno.TabIndex = 24
        Me.Lab_Alta_IdDueno.Text = "Id Dueño:"
        '
        'Btn_Alta_LimpiarDueno
        '
        Me.Btn_Alta_LimpiarDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Alta_LimpiarDueno.Location = New System.Drawing.Point(438, 175)
        Me.Btn_Alta_LimpiarDueno.Name = "Btn_Alta_LimpiarDueno"
        Me.Btn_Alta_LimpiarDueno.Size = New System.Drawing.Size(75, 25)
        Me.Btn_Alta_LimpiarDueno.TabIndex = 23
        Me.Btn_Alta_LimpiarDueno.Text = "Limpiar"
        Me.Btn_Alta_LimpiarDueno.UseVisualStyleBackColor = False
        '
        'Btn_Alta_GuardarDueno
        '
        Me.Btn_Alta_GuardarDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Alta_GuardarDueno.Location = New System.Drawing.Point(519, 175)
        Me.Btn_Alta_GuardarDueno.Name = "Btn_Alta_GuardarDueno"
        Me.Btn_Alta_GuardarDueno.Size = New System.Drawing.Size(75, 25)
        Me.Btn_Alta_GuardarDueno.TabIndex = 22
        Me.Btn_Alta_GuardarDueno.Text = "Guardar"
        Me.Btn_Alta_GuardarDueno.UseVisualStyleBackColor = False
        '
        'DGV_Alta_ListaDueno
        '
        Me.DGV_Alta_ListaDueno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Alta_ListaDueno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Cliente, Me.Nombre_Cliente, Me.Apellido_paterno, Me.Apellido_materno, Me.Direccion, Me.Telefono, Me.Correo_Electronico, Me.Nombre_Mascota})
        Me.DGV_Alta_ListaDueno.Location = New System.Drawing.Point(14, 206)
        Me.DGV_Alta_ListaDueno.Name = "DGV_Alta_ListaDueno"
        Me.DGV_Alta_ListaDueno.Size = New System.Drawing.Size(748, 141)
        Me.DGV_Alta_ListaDueno.TabIndex = 21
        '
        'Id_Cliente
        '
        Me.Id_Cliente.HeaderText = "Id Cliente"
        Me.Id_Cliente.Name = "Id_Cliente"
        '
        'Nombre_Cliente
        '
        Me.Nombre_Cliente.HeaderText = "Nombre Cliente"
        Me.Nombre_Cliente.Name = "Nombre_Cliente"
        '
        'Apellido_paterno
        '
        Me.Apellido_paterno.HeaderText = "Apellido paterno"
        Me.Apellido_paterno.Name = "Apellido_paterno"
        '
        'Apellido_materno
        '
        Me.Apellido_materno.HeaderText = "Apellido materno"
        Me.Apellido_materno.Name = "Apellido_materno"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'Correo_Electronico
        '
        Me.Correo_Electronico.HeaderText = "Correo Electronico"
        Me.Correo_Electronico.Name = "Correo_Electronico"
        '
        'Nombre_Mascota
        '
        Me.Nombre_Mascota.HeaderText = "Nombre Mascota"
        Me.Nombre_Mascota.Name = "Nombre_Mascota"
        '
        'TtBo_Alta_CalleDueno
        '
        Me.TtBo_Alta_CalleDueno.Location = New System.Drawing.Point(151, 157)
        Me.TtBo_Alta_CalleDueno.Name = "TtBo_Alta_CalleDueno"
        Me.TtBo_Alta_CalleDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_CalleDueno.TabIndex = 20
        '
        'Lab_Alta_EmailDueno
        '
        Me.Lab_Alta_EmailDueno.AutoSize = True
        Me.Lab_Alta_EmailDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_EmailDueno.Location = New System.Drawing.Point(307, 136)
        Me.Lab_Alta_EmailDueno.Name = "Lab_Alta_EmailDueno"
        Me.Lab_Alta_EmailDueno.Size = New System.Drawing.Size(122, 16)
        Me.Lab_Alta_EmailDueno.TabIndex = 19
        Me.Lab_Alta_EmailDueno.Text = "Correo Electronico:"
        '
        'Lab_Alta_TelefDueno
        '
        Me.Lab_Alta_TelefDueno.AutoSize = True
        Me.Lab_Alta_TelefDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_TelefDueno.Location = New System.Drawing.Point(337, 111)
        Me.Lab_Alta_TelefDueno.Name = "Lab_Alta_TelefDueno"
        Me.Lab_Alta_TelefDueno.Size = New System.Drawing.Size(65, 16)
        Me.Lab_Alta_TelefDueno.TabIndex = 6
        Me.Lab_Alta_TelefDueno.Text = "Telefono:"
        '
        'TtBo_Alta_AmatDueno
        '
        Me.TtBo_Alta_AmatDueno.Location = New System.Drawing.Point(151, 120)
        Me.TtBo_Alta_AmatDueno.Name = "TtBo_Alta_AmatDueno"
        Me.TtBo_Alta_AmatDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_AmatDueno.TabIndex = 5
        '
        'Lab_Alta_CalleDueno
        '
        Me.Lab_Alta_CalleDueno.AutoSize = True
        Me.Lab_Alta_CalleDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_CalleDueno.Location = New System.Drawing.Point(33, 158)
        Me.Lab_Alta_CalleDueno.Name = "Lab_Alta_CalleDueno"
        Me.Lab_Alta_CalleDueno.Size = New System.Drawing.Size(42, 16)
        Me.Lab_Alta_CalleDueno.TabIndex = 4
        Me.Lab_Alta_CalleDueno.Text = "Calle:"
        '
        'TtBo_Alta_ApatDueno
        '
        Me.TtBo_Alta_ApatDueno.Location = New System.Drawing.Point(151, 85)
        Me.TtBo_Alta_ApatDueno.Name = "TtBo_Alta_ApatDueno"
        Me.TtBo_Alta_ApatDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_ApatDueno.TabIndex = 3
        '
        'TtBo_Alta_NombDueno
        '
        Me.TtBo_Alta_NombDueno.Location = New System.Drawing.Point(151, 54)
        Me.TtBo_Alta_NombDueno.Name = "TtBo_Alta_NombDueno"
        Me.TtBo_Alta_NombDueno.Size = New System.Drawing.Size(139, 22)
        Me.TtBo_Alta_NombDueno.TabIndex = 2
        '
        'Lab_Alta_ApatDueno
        '
        Me.Lab_Alta_ApatDueno.AutoSize = True
        Me.Lab_Alta_ApatDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_ApatDueno.Location = New System.Drawing.Point(22, 91)
        Me.Lab_Alta_ApatDueno.Name = "Lab_Alta_ApatDueno"
        Me.Lab_Alta_ApatDueno.Size = New System.Drawing.Size(110, 16)
        Me.Lab_Alta_ApatDueno.TabIndex = 1
        Me.Lab_Alta_ApatDueno.Text = "Apellido paterno:"
        '
        'Lab_Alta_NombDueno
        '
        Me.Lab_Alta_NombDueno.AutoSize = True
        Me.Lab_Alta_NombDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_NombDueno.Location = New System.Drawing.Point(22, 58)
        Me.Lab_Alta_NombDueno.Name = "Lab_Alta_NombDueno"
        Me.Lab_Alta_NombDueno.Size = New System.Drawing.Size(123, 16)
        Me.Lab_Alta_NombDueno.TabIndex = 0
        Me.Lab_Alta_NombDueno.Text = "Nombre del dueño:"
        '
        'Consulta_Clientes
        '
        Me.Consulta_Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_Clientes.Controls.Add(Me.DGV_Cons_ListDueno)
        Me.Consulta_Clientes.Controls.Add(Me.GoBo_Cons_DatosBusqClienteDueno)
        Me.Consulta_Clientes.Location = New System.Drawing.Point(4, 25)
        Me.Consulta_Clientes.Name = "Consulta_Clientes"
        Me.Consulta_Clientes.Size = New System.Drawing.Size(768, 353)
        Me.Consulta_Clientes.TabIndex = 2
        Me.Consulta_Clientes.Text = "Consulta de Clientes"
        '
        'DGV_Cons_ListDueno
        '
        Me.DGV_Cons_ListDueno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Cons_ListDueno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.DGV_Cons_ListDueno.Location = New System.Drawing.Point(3, 178)
        Me.DGV_Cons_ListDueno.Name = "DGV_Cons_ListDueno"
        Me.DGV_Cons_ListDueno.Size = New System.Drawing.Size(748, 141)
        Me.DGV_Cons_ListDueno.TabIndex = 22
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Id Cliente"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Nombre Cliente"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Apellido paterno"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Apellido materno"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Correo Electronico"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Nombre Mascota"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'GoBo_Cons_DatosBusqClienteDueno
        '
        Me.GoBo_Cons_DatosBusqClienteDueno.Controls.Add(Me.Btn_Const_BuscarTodoDueno)
        Me.GoBo_Cons_DatosBusqClienteDueno.Controls.Add(Me.Btn_Cons_BuscarDueno)
        Me.GoBo_Cons_DatosBusqClienteDueno.Controls.Add(Me.TtBo_Cons_NombDueno)
        Me.GoBo_Cons_DatosBusqClienteDueno.Controls.Add(Me.Lab_Cons_NombDueno)
        Me.GoBo_Cons_DatosBusqClienteDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GoBo_Cons_DatosBusqClienteDueno.Location = New System.Drawing.Point(195, 41)
        Me.GoBo_Cons_DatosBusqClienteDueno.Name = "GoBo_Cons_DatosBusqClienteDueno"
        Me.GoBo_Cons_DatosBusqClienteDueno.Size = New System.Drawing.Size(335, 108)
        Me.GoBo_Cons_DatosBusqClienteDueno.TabIndex = 0
        Me.GoBo_Cons_DatosBusqClienteDueno.TabStop = False
        Me.GoBo_Cons_DatosBusqClienteDueno.Text = "Datos de Busqueda de Clientes "
        '
        'Btn_Const_BuscarTodoDueno
        '
        Me.Btn_Const_BuscarTodoDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Const_BuscarTodoDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Const_BuscarTodoDueno.Location = New System.Drawing.Point(59, 67)
        Me.Btn_Const_BuscarTodoDueno.Name = "Btn_Const_BuscarTodoDueno"
        Me.Btn_Const_BuscarTodoDueno.Size = New System.Drawing.Size(132, 25)
        Me.Btn_Const_BuscarTodoDueno.TabIndex = 3
        Me.Btn_Const_BuscarTodoDueno.Text = "Buscar todo"
        Me.Btn_Const_BuscarTodoDueno.UseVisualStyleBackColor = False
        '
        'Btn_Cons_BuscarDueno
        '
        Me.Btn_Cons_BuscarDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Cons_BuscarDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Cons_BuscarDueno.Location = New System.Drawing.Point(197, 67)
        Me.Btn_Cons_BuscarDueno.Name = "Btn_Cons_BuscarDueno"
        Me.Btn_Cons_BuscarDueno.Size = New System.Drawing.Size(132, 25)
        Me.Btn_Cons_BuscarDueno.TabIndex = 2
        Me.Btn_Cons_BuscarDueno.Text = "Buscar"
        Me.Btn_Cons_BuscarDueno.UseVisualStyleBackColor = False
        '
        'TtBo_Cons_NombDueno
        '
        Me.TtBo_Cons_NombDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TtBo_Cons_NombDueno.Location = New System.Drawing.Point(157, 33)
        Me.TtBo_Cons_NombDueno.Name = "TtBo_Cons_NombDueno"
        Me.TtBo_Cons_NombDueno.Size = New System.Drawing.Size(157, 23)
        Me.TtBo_Cons_NombDueno.TabIndex = 1
        '
        'Lab_Cons_NombDueno
        '
        Me.Lab_Cons_NombDueno.AutoSize = True
        Me.Lab_Cons_NombDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Cons_NombDueno.Location = New System.Drawing.Point(21, 39)
        Me.Lab_Cons_NombDueno.Name = "Lab_Cons_NombDueno"
        Me.Lab_Cons_NombDueno.Size = New System.Drawing.Size(130, 17)
        Me.Lab_Cons_NombDueno.TabIndex = 0
        Me.Lab_Cons_NombDueno.Text = "Nombre del cliente:"
        '
        'Baja_Clientes
        '
        Me.Baja_Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baja_Clientes.Controls.Add(Me.DGV_Baja_ListDueno)
        Me.Baja_Clientes.Controls.Add(Me.Button5)
        Me.Baja_Clientes.Controls.Add(Me.GoBo_Baja_DatosBusqClienteDueno)
        Me.Baja_Clientes.Location = New System.Drawing.Point(4, 25)
        Me.Baja_Clientes.Name = "Baja_Clientes"
        Me.Baja_Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Clientes.Size = New System.Drawing.Size(768, 353)
        Me.Baja_Clientes.TabIndex = 1
        Me.Baja_Clientes.Text = "Baja de clientes"
        '
        'DGV_Baja_ListDueno
        '
        Me.DGV_Baja_ListDueno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Baja_ListDueno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DGV_Baja_ListDueno.Location = New System.Drawing.Point(6, 151)
        Me.DGV_Baja_ListDueno.Name = "DGV_Baja_ListDueno"
        Me.DGV_Baja_ListDueno.Size = New System.Drawing.Size(748, 141)
        Me.DGV_Baja_ListDueno.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido paterno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellido materno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Correo Electronico"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre Mascota"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button5.Location = New System.Drawing.Point(357, 309)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 25)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GoBo_Baja_DatosBusqClienteDueno
        '
        Me.GoBo_Baja_DatosBusqClienteDueno.Controls.Add(Me.Btn_Baja_BuscarDueno)
        Me.GoBo_Baja_DatosBusqClienteDueno.Controls.Add(Me.TtBo_Baja_NombDueno)
        Me.GoBo_Baja_DatosBusqClienteDueno.Controls.Add(Me.Lab_Baja_NombDueno)
        Me.GoBo_Baja_DatosBusqClienteDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GoBo_Baja_DatosBusqClienteDueno.Location = New System.Drawing.Point(207, 31)
        Me.GoBo_Baja_DatosBusqClienteDueno.Name = "GoBo_Baja_DatosBusqClienteDueno"
        Me.GoBo_Baja_DatosBusqClienteDueno.Size = New System.Drawing.Size(320, 114)
        Me.GoBo_Baja_DatosBusqClienteDueno.TabIndex = 5
        Me.GoBo_Baja_DatosBusqClienteDueno.TabStop = False
        Me.GoBo_Baja_DatosBusqClienteDueno.Text = "Datos de busqueda del cliente"
        '
        'Btn_Baja_BuscarDueno
        '
        Me.Btn_Baja_BuscarDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Baja_BuscarDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Baja_BuscarDueno.Location = New System.Drawing.Point(150, 63)
        Me.Btn_Baja_BuscarDueno.Name = "Btn_Baja_BuscarDueno"
        Me.Btn_Baja_BuscarDueno.Size = New System.Drawing.Size(131, 25)
        Me.Btn_Baja_BuscarDueno.TabIndex = 5
        Me.Btn_Baja_BuscarDueno.Text = "Buscar"
        Me.Btn_Baja_BuscarDueno.UseVisualStyleBackColor = False
        '
        'TtBo_Baja_NombDueno
        '
        Me.TtBo_Baja_NombDueno.Location = New System.Drawing.Point(140, 34)
        Me.TtBo_Baja_NombDueno.Name = "TtBo_Baja_NombDueno"
        Me.TtBo_Baja_NombDueno.Size = New System.Drawing.Size(150, 23)
        Me.TtBo_Baja_NombDueno.TabIndex = 4
        '
        'Lab_Baja_NombDueno
        '
        Me.Lab_Baja_NombDueno.AutoSize = True
        Me.Lab_Baja_NombDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Baja_NombDueno.Location = New System.Drawing.Point(4, 37)
        Me.Lab_Baja_NombDueno.Name = "Lab_Baja_NombDueno"
        Me.Lab_Baja_NombDueno.Size = New System.Drawing.Size(130, 17)
        Me.Lab_Baja_NombDueno.TabIndex = 0
        Me.Lab_Baja_NombDueno.Text = "Nombre del cliente:"
        '
        'Cambio_Clientes
        '
        Me.Cambio_Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cambio_Clientes.Controls.Add(Me.Btn_Camb_LimpiarDueno)
        Me.Cambio_Clientes.Controls.Add(Me.Btn_Camb_ActualizarDueno)
        Me.Cambio_Clientes.Controls.Add(Me.GoBo_Camb_DatosGenerMascoDueno)
        Me.Cambio_Clientes.Controls.Add(Me.GoBo_Camb_DatosGenerDueno)
        Me.Cambio_Clientes.Location = New System.Drawing.Point(4, 25)
        Me.Cambio_Clientes.Name = "Cambio_Clientes"
        Me.Cambio_Clientes.Size = New System.Drawing.Size(768, 353)
        Me.Cambio_Clientes.TabIndex = 3
        Me.Cambio_Clientes.Text = "Cambio de clientes"
        '
        'Btn_Camb_LimpiarDueno
        '
        Me.Btn_Camb_LimpiarDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Camb_LimpiarDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Camb_LimpiarDueno.Location = New System.Drawing.Point(388, 303)
        Me.Btn_Camb_LimpiarDueno.Name = "Btn_Camb_LimpiarDueno"
        Me.Btn_Camb_LimpiarDueno.Size = New System.Drawing.Size(80, 25)
        Me.Btn_Camb_LimpiarDueno.TabIndex = 4
        Me.Btn_Camb_LimpiarDueno.Text = "Limpiar"
        Me.Btn_Camb_LimpiarDueno.UseVisualStyleBackColor = False
        '
        'Btn_Camb_ActualizarDueno
        '
        Me.Btn_Camb_ActualizarDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Camb_ActualizarDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Camb_ActualizarDueno.Location = New System.Drawing.Point(251, 303)
        Me.Btn_Camb_ActualizarDueno.Name = "Btn_Camb_ActualizarDueno"
        Me.Btn_Camb_ActualizarDueno.Size = New System.Drawing.Size(131, 25)
        Me.Btn_Camb_ActualizarDueno.TabIndex = 3
        Me.Btn_Camb_ActualizarDueno.Text = "Actualizar"
        Me.Btn_Camb_ActualizarDueno.UseVisualStyleBackColor = False
        '
        'GoBo_Camb_DatosGenerMascoDueno
        '
        Me.GoBo_Camb_DatosGenerMascoDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.Btn_Camb_CambiarImgMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.PiBo_Camb_ImgMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.Lab_Camb_ImgMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.Lab_Camb_RazaMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.TtBo_Camb_RazaMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.TtBo_Camb_ColorMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.Lab_Camb_ColorMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.TtBo_Camb_EdadMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.TtBo_Camb_TipoMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.TtBo_Camb_NombMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.Lab_Camb_EdadMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.Lab_Camb_TipoMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Controls.Add(Me.Lab_Camb_NombMasDueno)
        Me.GoBo_Camb_DatosGenerMascoDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GoBo_Camb_DatosGenerMascoDueno.Location = New System.Drawing.Point(372, 16)
        Me.GoBo_Camb_DatosGenerMascoDueno.Name = "GoBo_Camb_DatosGenerMascoDueno"
        Me.GoBo_Camb_DatosGenerMascoDueno.Size = New System.Drawing.Size(393, 281)
        Me.GoBo_Camb_DatosGenerMascoDueno.TabIndex = 2
        Me.GoBo_Camb_DatosGenerMascoDueno.TabStop = False
        Me.GoBo_Camb_DatosGenerMascoDueno.Text = "Datos Generales de la Mascota"
        '
        'Btn_Camb_CambiarImgMasDueno
        '
        Me.Btn_Camb_CambiarImgMasDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Camb_CambiarImgMasDueno.Location = New System.Drawing.Point(190, 246)
        Me.Btn_Camb_CambiarImgMasDueno.Name = "Btn_Camb_CambiarImgMasDueno"
        Me.Btn_Camb_CambiarImgMasDueno.Size = New System.Drawing.Size(131, 25)
        Me.Btn_Camb_CambiarImgMasDueno.TabIndex = 13
        Me.Btn_Camb_CambiarImgMasDueno.Text = "Cambiar foto"
        Me.Btn_Camb_CambiarImgMasDueno.UseVisualStyleBackColor = False
        '
        'PiBo_Camb_ImgMasDueno
        '
        Me.PiBo_Camb_ImgMasDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PiBo_Camb_ImgMasDueno.BackgroundImage = CType(resources.GetObject("PiBo_Camb_ImgMasDueno.BackgroundImage"), System.Drawing.Image)
        Me.PiBo_Camb_ImgMasDueno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PiBo_Camb_ImgMasDueno.Location = New System.Drawing.Point(190, 170)
        Me.PiBo_Camb_ImgMasDueno.Name = "PiBo_Camb_ImgMasDueno"
        Me.PiBo_Camb_ImgMasDueno.Size = New System.Drawing.Size(144, 70)
        Me.PiBo_Camb_ImgMasDueno.TabIndex = 12
        Me.PiBo_Camb_ImgMasDueno.TabStop = False
        '
        'Lab_Camb_ImgMasDueno
        '
        Me.Lab_Camb_ImgMasDueno.AutoSize = True
        Me.Lab_Camb_ImgMasDueno.Location = New System.Drawing.Point(18, 192)
        Me.Lab_Camb_ImgMasDueno.Name = "Lab_Camb_ImgMasDueno"
        Me.Lab_Camb_ImgMasDueno.Size = New System.Drawing.Size(168, 17)
        Me.Lab_Camb_ImgMasDueno.TabIndex = 11
        Me.Lab_Camb_ImgMasDueno.Text = "Fotografia de la Mascota:"
        '
        'Lab_Camb_RazaMasDueno
        '
        Me.Lab_Camb_RazaMasDueno.AutoSize = True
        Me.Lab_Camb_RazaMasDueno.Location = New System.Drawing.Point(35, 140)
        Me.Lab_Camb_RazaMasDueno.Name = "Lab_Camb_RazaMasDueno"
        Me.Lab_Camb_RazaMasDueno.Size = New System.Drawing.Size(45, 17)
        Me.Lab_Camb_RazaMasDueno.TabIndex = 10
        Me.Lab_Camb_RazaMasDueno.Text = "Raza:"
        '
        'TtBo_Camb_RazaMasDueno
        '
        Me.TtBo_Camb_RazaMasDueno.Location = New System.Drawing.Point(190, 137)
        Me.TtBo_Camb_RazaMasDueno.Name = "TtBo_Camb_RazaMasDueno"
        Me.TtBo_Camb_RazaMasDueno.Size = New System.Drawing.Size(144, 23)
        Me.TtBo_Camb_RazaMasDueno.TabIndex = 9
        '
        'TtBo_Camb_ColorMasDueno
        '
        Me.TtBo_Camb_ColorMasDueno.Location = New System.Drawing.Point(190, 108)
        Me.TtBo_Camb_ColorMasDueno.Name = "TtBo_Camb_ColorMasDueno"
        Me.TtBo_Camb_ColorMasDueno.Size = New System.Drawing.Size(144, 23)
        Me.TtBo_Camb_ColorMasDueno.TabIndex = 8
        '
        'Lab_Camb_ColorMasDueno
        '
        Me.Lab_Camb_ColorMasDueno.AutoSize = True
        Me.Lab_Camb_ColorMasDueno.Location = New System.Drawing.Point(18, 111)
        Me.Lab_Camb_ColorMasDueno.Name = "Lab_Camb_ColorMasDueno"
        Me.Lab_Camb_ColorMasDueno.Size = New System.Drawing.Size(137, 17)
        Me.Lab_Camb_ColorMasDueno.TabIndex = 7
        Me.Lab_Camb_ColorMasDueno.Text = "Color de la Mascota:"
        '
        'TtBo_Camb_EdadMasDueno
        '
        Me.TtBo_Camb_EdadMasDueno.Location = New System.Drawing.Point(190, 79)
        Me.TtBo_Camb_EdadMasDueno.Name = "TtBo_Camb_EdadMasDueno"
        Me.TtBo_Camb_EdadMasDueno.Size = New System.Drawing.Size(144, 23)
        Me.TtBo_Camb_EdadMasDueno.TabIndex = 6
        '
        'TtBo_Camb_TipoMasDueno
        '
        Me.TtBo_Camb_TipoMasDueno.Location = New System.Drawing.Point(190, 50)
        Me.TtBo_Camb_TipoMasDueno.Name = "TtBo_Camb_TipoMasDueno"
        Me.TtBo_Camb_TipoMasDueno.Size = New System.Drawing.Size(144, 23)
        Me.TtBo_Camb_TipoMasDueno.TabIndex = 5
        '
        'TtBo_Camb_NombMasDueno
        '
        Me.TtBo_Camb_NombMasDueno.Location = New System.Drawing.Point(190, 21)
        Me.TtBo_Camb_NombMasDueno.Name = "TtBo_Camb_NombMasDueno"
        Me.TtBo_Camb_NombMasDueno.Size = New System.Drawing.Size(144, 23)
        Me.TtBo_Camb_NombMasDueno.TabIndex = 4
        '
        'Lab_Camb_EdadMasDueno
        '
        Me.Lab_Camb_EdadMasDueno.AutoSize = True
        Me.Lab_Camb_EdadMasDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Camb_EdadMasDueno.Location = New System.Drawing.Point(18, 82)
        Me.Lab_Camb_EdadMasDueno.Name = "Lab_Camb_EdadMasDueno"
        Me.Lab_Camb_EdadMasDueno.Size = New System.Drawing.Size(132, 16)
        Me.Lab_Camb_EdadMasDueno.TabIndex = 3
        Me.Lab_Camb_EdadMasDueno.Text = "Edad de la Mascota:"
        '
        'Lab_Camb_TipoMasDueno
        '
        Me.Lab_Camb_TipoMasDueno.AutoSize = True
        Me.Lab_Camb_TipoMasDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Camb_TipoMasDueno.Location = New System.Drawing.Point(18, 53)
        Me.Lab_Camb_TipoMasDueno.Name = "Lab_Camb_TipoMasDueno"
        Me.Lab_Camb_TipoMasDueno.Size = New System.Drawing.Size(113, 16)
        Me.Lab_Camb_TipoMasDueno.TabIndex = 2
        Me.Lab_Camb_TipoMasDueno.Text = "Tipo de Mascota:"
        '
        'Lab_Camb_NombMasDueno
        '
        Me.Lab_Camb_NombMasDueno.AutoSize = True
        Me.Lab_Camb_NombMasDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_NombMasDueno.Location = New System.Drawing.Point(18, 24)
        Me.Lab_Camb_NombMasDueno.Name = "Lab_Camb_NombMasDueno"
        Me.Lab_Camb_NombMasDueno.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Camb_NombMasDueno.TabIndex = 1
        Me.Lab_Camb_NombMasDueno.Text = "Nombre de la Mascota:"
        '
        'GoBo_Camb_DatosGenerDueno
        '
        Me.GoBo_Camb_DatosGenerDueno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.TtBo_Camb_EmailDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.Lab_Camb_AmatDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.TtBo_Camb_IdDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.Lab_Camb_IdDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.TtBo_Camb_DireccDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.Lab_Camb_EmailDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.TtBo_Camb_TelefDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.Lab_Camb_TelefDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.TtBo_Camb_AmatDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.Lab_Camb_DireccDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.TtBo_Camb_ApatDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.TtBo_Camb_NombDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.Lab_Camb_ApatDueno)
        Me.GoBo_Camb_DatosGenerDueno.Controls.Add(Me.Lab_Camb_NombDueno)
        Me.GoBo_Camb_DatosGenerDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GoBo_Camb_DatosGenerDueno.Location = New System.Drawing.Point(3, 16)
        Me.GoBo_Camb_DatosGenerDueno.Name = "GoBo_Camb_DatosGenerDueno"
        Me.GoBo_Camb_DatosGenerDueno.Size = New System.Drawing.Size(349, 281)
        Me.GoBo_Camb_DatosGenerDueno.TabIndex = 0
        Me.GoBo_Camb_DatosGenerDueno.TabStop = False
        Me.GoBo_Camb_DatosGenerDueno.Text = "Datos Generales del Dueño"
        '
        'TtBo_Camb_EmailDueno
        '
        Me.TtBo_Camb_EmailDueno.Location = New System.Drawing.Point(138, 223)
        Me.TtBo_Camb_EmailDueno.Name = "TtBo_Camb_EmailDueno"
        Me.TtBo_Camb_EmailDueno.Size = New System.Drawing.Size(139, 23)
        Me.TtBo_Camb_EmailDueno.TabIndex = 41
        '
        'Lab_Camb_AmatDueno
        '
        Me.Lab_Camb_AmatDueno.AutoSize = True
        Me.Lab_Camb_AmatDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_AmatDueno.Location = New System.Drawing.Point(12, 130)
        Me.Lab_Camb_AmatDueno.Name = "Lab_Camb_AmatDueno"
        Me.Lab_Camb_AmatDueno.Size = New System.Drawing.Size(118, 17)
        Me.Lab_Camb_AmatDueno.TabIndex = 40
        Me.Lab_Camb_AmatDueno.Text = "Apellido materno:"
        '
        'TtBo_Camb_IdDueno
        '
        Me.TtBo_Camb_IdDueno.Location = New System.Drawing.Point(138, 21)
        Me.TtBo_Camb_IdDueno.Name = "TtBo_Camb_IdDueno"
        Me.TtBo_Camb_IdDueno.Size = New System.Drawing.Size(139, 23)
        Me.TtBo_Camb_IdDueno.TabIndex = 39
        '
        'Lab_Camb_IdDueno
        '
        Me.Lab_Camb_IdDueno.AutoSize = True
        Me.Lab_Camb_IdDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_IdDueno.Location = New System.Drawing.Point(12, 22)
        Me.Lab_Camb_IdDueno.Name = "Lab_Camb_IdDueno"
        Me.Lab_Camb_IdDueno.Size = New System.Drawing.Size(69, 17)
        Me.Lab_Camb_IdDueno.TabIndex = 38
        Me.Lab_Camb_IdDueno.Text = "Id Dueño:"
        '
        'TtBo_Camb_DireccDueno
        '
        Me.TtBo_Camb_DireccDueno.Location = New System.Drawing.Point(138, 161)
        Me.TtBo_Camb_DireccDueno.Name = "TtBo_Camb_DireccDueno"
        Me.TtBo_Camb_DireccDueno.Size = New System.Drawing.Size(139, 23)
        Me.TtBo_Camb_DireccDueno.TabIndex = 37
        '
        'Lab_Camb_EmailDueno
        '
        Me.Lab_Camb_EmailDueno.AutoSize = True
        Me.Lab_Camb_EmailDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_EmailDueno.Location = New System.Drawing.Point(12, 226)
        Me.Lab_Camb_EmailDueno.Name = "Lab_Camb_EmailDueno"
        Me.Lab_Camb_EmailDueno.Size = New System.Drawing.Size(129, 17)
        Me.Lab_Camb_EmailDueno.TabIndex = 36
        Me.Lab_Camb_EmailDueno.Text = "Correo Electronico:"
        '
        'TtBo_Camb_TelefDueno
        '
        Me.TtBo_Camb_TelefDueno.Location = New System.Drawing.Point(138, 192)
        Me.TtBo_Camb_TelefDueno.Name = "TtBo_Camb_TelefDueno"
        Me.TtBo_Camb_TelefDueno.Size = New System.Drawing.Size(139, 23)
        Me.TtBo_Camb_TelefDueno.TabIndex = 35
        '
        'Lab_Camb_TelefDueno
        '
        Me.Lab_Camb_TelefDueno.AutoSize = True
        Me.Lab_Camb_TelefDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_TelefDueno.Location = New System.Drawing.Point(12, 195)
        Me.Lab_Camb_TelefDueno.Name = "Lab_Camb_TelefDueno"
        Me.Lab_Camb_TelefDueno.Size = New System.Drawing.Size(68, 17)
        Me.Lab_Camb_TelefDueno.TabIndex = 34
        Me.Lab_Camb_TelefDueno.Text = "Teléfono:"
        '
        'TtBo_Camb_AmatDueno
        '
        Me.TtBo_Camb_AmatDueno.Location = New System.Drawing.Point(138, 127)
        Me.TtBo_Camb_AmatDueno.Name = "TtBo_Camb_AmatDueno"
        Me.TtBo_Camb_AmatDueno.Size = New System.Drawing.Size(139, 23)
        Me.TtBo_Camb_AmatDueno.TabIndex = 33
        '
        'Lab_Camb_DireccDueno
        '
        Me.Lab_Camb_DireccDueno.AutoSize = True
        Me.Lab_Camb_DireccDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_DireccDueno.Location = New System.Drawing.Point(13, 165)
        Me.Lab_Camb_DireccDueno.Name = "Lab_Camb_DireccDueno"
        Me.Lab_Camb_DireccDueno.Size = New System.Drawing.Size(71, 17)
        Me.Lab_Camb_DireccDueno.TabIndex = 32
        Me.Lab_Camb_DireccDueno.Text = "Dirección:"
        '
        'TtBo_Camb_ApatDueno
        '
        Me.TtBo_Camb_ApatDueno.Location = New System.Drawing.Point(138, 91)
        Me.TtBo_Camb_ApatDueno.Name = "TtBo_Camb_ApatDueno"
        Me.TtBo_Camb_ApatDueno.Size = New System.Drawing.Size(139, 23)
        Me.TtBo_Camb_ApatDueno.TabIndex = 31
        '
        'TtBo_Camb_NombDueno
        '
        Me.TtBo_Camb_NombDueno.Location = New System.Drawing.Point(138, 52)
        Me.TtBo_Camb_NombDueno.Name = "TtBo_Camb_NombDueno"
        Me.TtBo_Camb_NombDueno.Size = New System.Drawing.Size(139, 23)
        Me.TtBo_Camb_NombDueno.TabIndex = 30
        '
        'Lab_Camb_ApatDueno
        '
        Me.Lab_Camb_ApatDueno.AutoSize = True
        Me.Lab_Camb_ApatDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_ApatDueno.Location = New System.Drawing.Point(12, 97)
        Me.Lab_Camb_ApatDueno.Name = "Lab_Camb_ApatDueno"
        Me.Lab_Camb_ApatDueno.Size = New System.Drawing.Size(115, 17)
        Me.Lab_Camb_ApatDueno.TabIndex = 29
        Me.Lab_Camb_ApatDueno.Text = "Apellido paterno:"
        '
        'Lab_Camb_NombDueno
        '
        Me.Lab_Camb_NombDueno.AutoSize = True
        Me.Lab_Camb_NombDueno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Camb_NombDueno.Location = New System.Drawing.Point(9, 56)
        Me.Lab_Camb_NombDueno.Name = "Lab_Camb_NombDueno"
        Me.Lab_Camb_NombDueno.Size = New System.Drawing.Size(129, 17)
        Me.Lab_Camb_NombDueno.TabIndex = 28
        Me.Lab_Camb_NombDueno.Text = "Nombre del dueño:"
        '
        'Form_ClientesYMascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tab_Ctr_ClientesYMascotas)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_ClientesYMascotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes y Mascotas"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_ClientesYMascotas.ResumeLayout(False)
        Me.Alta_Clientes.ResumeLayout(False)
        Me.Alta_Clientes.PerformLayout()
        CType(Me.DGV_Alta_ListaDueno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Consulta_Clientes.ResumeLayout(False)
        CType(Me.DGV_Cons_ListDueno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GoBo_Cons_DatosBusqClienteDueno.ResumeLayout(False)
        Me.GoBo_Cons_DatosBusqClienteDueno.PerformLayout()
        Me.Baja_Clientes.ResumeLayout(False)
        CType(Me.DGV_Baja_ListDueno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GoBo_Baja_DatosBusqClienteDueno.ResumeLayout(False)
        Me.GoBo_Baja_DatosBusqClienteDueno.PerformLayout()
        Me.Cambio_Clientes.ResumeLayout(False)
        Me.GoBo_Camb_DatosGenerMascoDueno.ResumeLayout(False)
        Me.GoBo_Camb_DatosGenerMascoDueno.PerformLayout()
        CType(Me.PiBo_Camb_ImgMasDueno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GoBo_Camb_DatosGenerDueno.ResumeLayout(False)
        Me.GoBo_Camb_DatosGenerDueno.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_atras As Button
    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tab_Ctr_ClientesYMascotas As TabControl
    Friend WithEvents Alta_Clientes As TabPage
    Friend WithEvents Lab_Alta_TelefDueno As Label
    Friend WithEvents TtBo_Alta_AmatDueno As TextBox
    Friend WithEvents Lab_Alta_CalleDueno As Label
    Friend WithEvents TtBo_Alta_ApatDueno As TextBox
    Friend WithEvents TtBo_Alta_NombDueno As TextBox
    Friend WithEvents Lab_Alta_ApatDueno As Label
    Friend WithEvents Lab_Alta_NombDueno As Label
    Friend WithEvents Baja_Clientes As TabPage
    Friend WithEvents Btn_Alta_LimpiarDueno As Button
    Friend WithEvents Btn_Alta_GuardarDueno As Button
    Friend WithEvents DGV_Alta_ListaDueno As DataGridView
    Friend WithEvents TtBo_Alta_CalleDueno As TextBox
    Friend WithEvents Lab_Alta_EmailDueno As Label
    Friend WithEvents Consulta_Clientes As TabPage
    Friend WithEvents GoBo_Cons_DatosBusqClienteDueno As GroupBox
    Friend WithEvents TtBo_Cons_NombDueno As TextBox
    Friend WithEvents Lab_Cons_NombDueno As Label
    Friend WithEvents Btn_Cons_BuscarDueno As Button
    Friend WithEvents TtBo_Baja_NombDueno As TextBox
    Friend WithEvents Lab_Baja_NombDueno As Label
    Friend WithEvents GoBo_Baja_DatosBusqClienteDueno As GroupBox
    Friend WithEvents Btn_Baja_BuscarDueno As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Cambio_Clientes As TabPage
    Friend WithEvents GoBo_Camb_DatosGenerDueno As GroupBox
    Friend WithEvents GoBo_Camb_DatosGenerMascoDueno As GroupBox
    Friend WithEvents Lab_Camb_RazaMasDueno As Label
    Friend WithEvents TtBo_Camb_RazaMasDueno As TextBox
    Friend WithEvents TtBo_Camb_ColorMasDueno As TextBox
    Friend WithEvents Lab_Camb_ColorMasDueno As Label
    Friend WithEvents TtBo_Camb_EdadMasDueno As TextBox
    Friend WithEvents TtBo_Camb_TipoMasDueno As TextBox
    Friend WithEvents TtBo_Camb_NombMasDueno As TextBox
    Friend WithEvents Lab_Camb_EdadMasDueno As Label
    Friend WithEvents Lab_Camb_TipoMasDueno As Label
    Friend WithEvents Lab_Camb_NombMasDueno As Label
    Friend WithEvents PiBo_Camb_ImgMasDueno As PictureBox
    Friend WithEvents Lab_Camb_ImgMasDueno As Label
    Friend WithEvents Btn_Camb_LimpiarDueno As Button
    Friend WithEvents Btn_Camb_ActualizarDueno As Button
    Friend WithEvents Btn_Alta_AgregarMascotaDueno As Button
    Friend WithEvents TtBo_Alta_EmailDueno As TextBox
    Friend WithEvents Lab_Alta_AmatDueno As Label
    Friend WithEvents TtBo_Alta_IdDueno As TextBox
    Friend WithEvents Lab_Alta_IdDueno As Label
    Friend WithEvents Id_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_paterno As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_materno As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo_Electronico As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Mascota As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Cons_ListDueno As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Baja_ListDueno As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Camb_CambiarImgMasDueno As Button
    Friend WithEvents TtBo_Camb_EmailDueno As TextBox
    Friend WithEvents Lab_Camb_AmatDueno As Label
    Friend WithEvents TtBo_Camb_IdDueno As TextBox
    Friend WithEvents Lab_Camb_IdDueno As Label
    Friend WithEvents TtBo_Camb_DireccDueno As TextBox
    Friend WithEvents Lab_Camb_EmailDueno As Label
    Friend WithEvents TtBo_Camb_TelefDueno As TextBox
    Friend WithEvents Lab_Camb_TelefDueno As Label
    Friend WithEvents TtBo_Camb_AmatDueno As TextBox
    Friend WithEvents Lab_Camb_DireccDueno As Label
    Friend WithEvents TtBo_Camb_ApatDueno As TextBox
    Friend WithEvents TtBo_Camb_NombDueno As TextBox
    Friend WithEvents Lab_Camb_ApatDueno As Label
    Friend WithEvents Lab_Camb_NombDueno As Label
    Friend WithEvents TtBo_Alta_MunicipioDueno As TextBox
    Friend WithEvents Lab_Alta_MunicipioDueno As Label
    Friend WithEvents TtBo_Alta_CpDueno As TextBox
    Friend WithEvents Lab_Alta_CpDueno As Label
    Friend WithEvents TtBo_Alta_TelefDueno As TextBox
    Friend WithEvents TtBo_Alta_NumeroDueno As TextBox
    Friend WithEvents Lab_Alta_NumeroDueno As Label
    Friend WithEvents Btn_Const_BuscarTodoDueno As Button
End Class
