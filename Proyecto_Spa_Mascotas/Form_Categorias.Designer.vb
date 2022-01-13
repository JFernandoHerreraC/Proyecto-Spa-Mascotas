<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Categorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Categorias))
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
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Alta_Categoria = New System.Windows.Forms.TabPage()
        Me.Btn_Alta_Limpiar_Categorias = New System.Windows.Forms.Button()
        Me.Btn_Categorias_Guardar = New System.Windows.Forms.Button()
        Me.TtBo_Alta_DescCategoria = New System.Windows.Forms.TextBox()
        Me.Lab_Catg_DescCategoria = New System.Windows.Forms.Label()
        Me.TtBo_Alta_NombCategoria = New System.Windows.Forms.TextBox()
        Me.Lab_Catg_NombCategoria = New System.Windows.Forms.Label()
        Me.Consulta_Categorias = New System.Windows.Forms.TabPage()
        Me.Btn_Consulta_BuscarTodo = New System.Windows.Forms.Button()
        Me.DGVListaCtg = New System.Windows.Forms.DataGridView()
        Me.DGV_Catg_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Catg_Nomb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Catg_Descp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Consulta_Buscar = New System.Windows.Forms.Button()
        Me.TtBo_Consulta_NombCategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cambio_Categoria = New System.Windows.Forms.TabPage()
        Me.Btn_Cambios_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Cambios_Guardar = New System.Windows.Forms.Button()
        Me.TtBo_Cambios_DescCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_NombCategoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Baja_Categoria = New System.Windows.Forms.TabPage()
        Me.Btn_Baja_Limpiar_Ctg = New System.Windows.Forms.Button()
        Me.Btn_Baja_Buscar = New System.Windows.Forms.Button()
        Me.TtBo_Baja_DescCategoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TtBo_Baja_NombCategoria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuS_Principal.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Alta_Categoria.SuspendLayout()
        Me.Consulta_Categorias.SuspendLayout()
        CType(Me.DGVListaCtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cambio_Categoria.SuspendLayout()
        Me.Baja_Categoria.SuspendLayout()
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
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem, Me.CaducosToolStripMenuItem1})
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
        'ClientesYMascotasToolStripMenuItem
        '
        Me.ClientesYMascotasToolStripMenuItem.Name = "ClientesYMascotasToolStripMenuItem"
        Me.ClientesYMascotasToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.ClientesYMascotasToolStripMenuItem.Text = "Clientes y mascotas"
        '
        'CaducosToolStripMenuItem1
        '
        Me.CaducosToolStripMenuItem1.Name = "CaducosToolStripMenuItem1"
        Me.CaducosToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.CaducosToolStripMenuItem1.Text = "Caducos"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Alta_Categoria)
        Me.TabControl1.Controls.Add(Me.Consulta_Categorias)
        Me.TabControl1.Controls.Add(Me.Cambio_Categoria)
        Me.TabControl1.Controls.Add(Me.Baja_Categoria)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 365)
        Me.TabControl1.TabIndex = 5
        '
        'Alta_Categoria
        '
        Me.Alta_Categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_Categoria.Controls.Add(Me.Btn_Alta_Limpiar_Categorias)
        Me.Alta_Categoria.Controls.Add(Me.Btn_Categorias_Guardar)
        Me.Alta_Categoria.Controls.Add(Me.TtBo_Alta_DescCategoria)
        Me.Alta_Categoria.Controls.Add(Me.Lab_Catg_DescCategoria)
        Me.Alta_Categoria.Controls.Add(Me.TtBo_Alta_NombCategoria)
        Me.Alta_Categoria.Controls.Add(Me.Lab_Catg_NombCategoria)
        Me.Alta_Categoria.Location = New System.Drawing.Point(4, 25)
        Me.Alta_Categoria.Name = "Alta_Categoria"
        Me.Alta_Categoria.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Categoria.Size = New System.Drawing.Size(768, 336)
        Me.Alta_Categoria.TabIndex = 0
        Me.Alta_Categoria.Text = "Alta de categoría"
        '
        'Btn_Alta_Limpiar_Categorias
        '
        Me.Btn_Alta_Limpiar_Categorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Alta_Limpiar_Categorias.Location = New System.Drawing.Point(455, 200)
        Me.Btn_Alta_Limpiar_Categorias.Name = "Btn_Alta_Limpiar_Categorias"
        Me.Btn_Alta_Limpiar_Categorias.Size = New System.Drawing.Size(80, 25)
        Me.Btn_Alta_Limpiar_Categorias.TabIndex = 5
        Me.Btn_Alta_Limpiar_Categorias.Text = "Limpiar"
        Me.Btn_Alta_Limpiar_Categorias.UseVisualStyleBackColor = False
        '
        'Btn_Categorias_Guardar
        '
        Me.Btn_Categorias_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Categorias_Guardar.Location = New System.Drawing.Point(541, 200)
        Me.Btn_Categorias_Guardar.Name = "Btn_Categorias_Guardar"
        Me.Btn_Categorias_Guardar.Size = New System.Drawing.Size(120, 25)
        Me.Btn_Categorias_Guardar.TabIndex = 4
        Me.Btn_Categorias_Guardar.Text = "Guardar"
        Me.Btn_Categorias_Guardar.UseVisualStyleBackColor = False
        '
        'TtBo_Alta_DescCategoria
        '
        Me.TtBo_Alta_DescCategoria.Location = New System.Drawing.Point(455, 162)
        Me.TtBo_Alta_DescCategoria.MaxLength = 80
        Me.TtBo_Alta_DescCategoria.Name = "TtBo_Alta_DescCategoria"
        Me.TtBo_Alta_DescCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Alta_DescCategoria.TabIndex = 3
        Me.TtBo_Alta_DescCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_Catg_DescCategoria
        '
        Me.Lab_Catg_DescCategoria.AutoSize = True
        Me.Lab_Catg_DescCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Catg_DescCategoria.Location = New System.Drawing.Point(246, 165)
        Me.Lab_Catg_DescCategoria.Name = "Lab_Catg_DescCategoria"
        Me.Lab_Catg_DescCategoria.Size = New System.Drawing.Size(184, 17)
        Me.Lab_Catg_DescCategoria.TabIndex = 2
        Me.Lab_Catg_DescCategoria.Text = "Descripción de la categoría:"
        '
        'TtBo_Alta_NombCategoria
        '
        Me.TtBo_Alta_NombCategoria.Location = New System.Drawing.Point(455, 128)
        Me.TtBo_Alta_NombCategoria.MaxLength = 40
        Me.TtBo_Alta_NombCategoria.Name = "TtBo_Alta_NombCategoria"
        Me.TtBo_Alta_NombCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Alta_NombCategoria.TabIndex = 1
        Me.TtBo_Alta_NombCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lab_Catg_NombCategoria
        '
        Me.Lab_Catg_NombCategoria.AutoSize = True
        Me.Lab_Catg_NombCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Catg_NombCategoria.Location = New System.Drawing.Point(246, 128)
        Me.Lab_Catg_NombCategoria.Name = "Lab_Catg_NombCategoria"
        Me.Lab_Catg_NombCategoria.Size = New System.Drawing.Size(160, 17)
        Me.Lab_Catg_NombCategoria.TabIndex = 0
        Me.Lab_Catg_NombCategoria.Text = "Nombre de la categoría:"
        '
        'Consulta_Categorias
        '
        Me.Consulta_Categorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_Categorias.Controls.Add(Me.Btn_Consulta_BuscarTodo)
        Me.Consulta_Categorias.Controls.Add(Me.DGVListaCtg)
        Me.Consulta_Categorias.Controls.Add(Me.Btn_Consulta_Buscar)
        Me.Consulta_Categorias.Controls.Add(Me.TtBo_Consulta_NombCategoria)
        Me.Consulta_Categorias.Controls.Add(Me.Label3)
        Me.Consulta_Categorias.Location = New System.Drawing.Point(4, 25)
        Me.Consulta_Categorias.Name = "Consulta_Categorias"
        Me.Consulta_Categorias.Padding = New System.Windows.Forms.Padding(3)
        Me.Consulta_Categorias.Size = New System.Drawing.Size(768, 336)
        Me.Consulta_Categorias.TabIndex = 1
        Me.Consulta_Categorias.Text = "Consulta de categorías"
        '
        'Btn_Consulta_BuscarTodo
        '
        Me.Btn_Consulta_BuscarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Consulta_BuscarTodo.Location = New System.Drawing.Point(294, 121)
        Me.Btn_Consulta_BuscarTodo.Name = "Btn_Consulta_BuscarTodo"
        Me.Btn_Consulta_BuscarTodo.Size = New System.Drawing.Size(123, 25)
        Me.Btn_Consulta_BuscarTodo.TabIndex = 4
        Me.Btn_Consulta_BuscarTodo.Text = "Buscar todo"
        Me.Btn_Consulta_BuscarTodo.UseVisualStyleBackColor = False
        '
        'DGVListaCtg
        '
        Me.DGVListaCtg.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGVListaCtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListaCtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Catg_ID, Me.DGV_Catg_Nomb, Me.DGV_Catg_Descp})
        Me.DGVListaCtg.Location = New System.Drawing.Point(252, 162)
        Me.DGVListaCtg.Name = "DGVListaCtg"
        Me.DGVListaCtg.Size = New System.Drawing.Size(344, 150)
        Me.DGVListaCtg.TabIndex = 3
        '
        'DGV_Catg_ID
        '
        Me.DGV_Catg_ID.HeaderText = "ID"
        Me.DGV_Catg_ID.MaxInputLength = 3
        Me.DGV_Catg_ID.Name = "DGV_Catg_ID"
        '
        'DGV_Catg_Nomb
        '
        Me.DGV_Catg_Nomb.HeaderText = "Nombre de la categría"
        Me.DGV_Catg_Nomb.MaxInputLength = 40
        Me.DGV_Catg_Nomb.Name = "DGV_Catg_Nomb"
        '
        'DGV_Catg_Descp
        '
        Me.DGV_Catg_Descp.HeaderText = "Descripción de Categoría"
        Me.DGV_Catg_Descp.MaxInputLength = 120
        Me.DGV_Catg_Descp.Name = "DGV_Catg_Descp"
        '
        'Btn_Consulta_Buscar
        '
        Me.Btn_Consulta_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Consulta_Buscar.Location = New System.Drawing.Point(423, 121)
        Me.Btn_Consulta_Buscar.Name = "Btn_Consulta_Buscar"
        Me.Btn_Consulta_Buscar.Size = New System.Drawing.Size(132, 25)
        Me.Btn_Consulta_Buscar.TabIndex = 2
        Me.Btn_Consulta_Buscar.Text = "Buscar"
        Me.Btn_Consulta_Buscar.UseVisualStyleBackColor = False
        '
        'TtBo_Consulta_NombCategoria
        '
        Me.TtBo_Consulta_NombCategoria.Location = New System.Drawing.Point(364, 95)
        Me.TtBo_Consulta_NombCategoria.MaxLength = 40
        Me.TtBo_Consulta_NombCategoria.Name = "TtBo_Consulta_NombCategoria"
        Me.TtBo_Consulta_NombCategoria.Size = New System.Drawing.Size(179, 23)
        Me.TtBo_Consulta_NombCategoria.TabIndex = 1
        Me.TtBo_Consulta_NombCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(197, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre de la categoría:"
        '
        'Cambio_Categoria
        '
        Me.Cambio_Categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cambio_Categoria.Controls.Add(Me.Btn_Cambios_Limpiar)
        Me.Cambio_Categoria.Controls.Add(Me.Btn_Cambios_Guardar)
        Me.Cambio_Categoria.Controls.Add(Me.TtBo_Cambios_DescCategoria)
        Me.Cambio_Categoria.Controls.Add(Me.Label4)
        Me.Cambio_Categoria.Controls.Add(Me.TtBo_Cambios_NombCategoria)
        Me.Cambio_Categoria.Controls.Add(Me.Label5)
        Me.Cambio_Categoria.Location = New System.Drawing.Point(4, 25)
        Me.Cambio_Categoria.Name = "Cambio_Categoria"
        Me.Cambio_Categoria.Padding = New System.Windows.Forms.Padding(3)
        Me.Cambio_Categoria.Size = New System.Drawing.Size(768, 336)
        Me.Cambio_Categoria.TabIndex = 3
        Me.Cambio_Categoria.Text = "Cambios en categoría"
        '
        'Btn_Cambios_Limpiar
        '
        Me.Btn_Cambios_Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Cambios_Limpiar.Location = New System.Drawing.Point(405, 182)
        Me.Btn_Cambios_Limpiar.Name = "Btn_Cambios_Limpiar"
        Me.Btn_Cambios_Limpiar.Size = New System.Drawing.Size(80, 25)
        Me.Btn_Cambios_Limpiar.TabIndex = 11
        Me.Btn_Cambios_Limpiar.Text = "Limpiar"
        Me.Btn_Cambios_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Cambios_Guardar
        '
        Me.Btn_Cambios_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Cambios_Guardar.Location = New System.Drawing.Point(491, 182)
        Me.Btn_Cambios_Guardar.Name = "Btn_Cambios_Guardar"
        Me.Btn_Cambios_Guardar.Size = New System.Drawing.Size(120, 25)
        Me.Btn_Cambios_Guardar.TabIndex = 10
        Me.Btn_Cambios_Guardar.Text = "Buscar"
        Me.Btn_Cambios_Guardar.UseVisualStyleBackColor = False
        '
        'TtBo_Cambios_DescCategoria
        '
        Me.TtBo_Cambios_DescCategoria.Location = New System.Drawing.Point(405, 144)
        Me.TtBo_Cambios_DescCategoria.MaxLength = 80
        Me.TtBo_Cambios_DescCategoria.Name = "TtBo_Cambios_DescCategoria"
        Me.TtBo_Cambios_DescCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Cambios_DescCategoria.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(215, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Descripción de la categoría:"
        '
        'TtBo_Cambios_NombCategoria
        '
        Me.TtBo_Cambios_NombCategoria.Location = New System.Drawing.Point(405, 111)
        Me.TtBo_Cambios_NombCategoria.MaxLength = 40
        Me.TtBo_Cambios_NombCategoria.Name = "TtBo_Cambios_NombCategoria"
        Me.TtBo_Cambios_NombCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Cambios_NombCategoria.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(215, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre de la categoría:"
        '
        'Baja_Categoria
        '
        Me.Baja_Categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baja_Categoria.Controls.Add(Me.Btn_Baja_Limpiar_Ctg)
        Me.Baja_Categoria.Controls.Add(Me.Btn_Baja_Buscar)
        Me.Baja_Categoria.Controls.Add(Me.TtBo_Baja_DescCategoria)
        Me.Baja_Categoria.Controls.Add(Me.Label6)
        Me.Baja_Categoria.Controls.Add(Me.TtBo_Baja_NombCategoria)
        Me.Baja_Categoria.Controls.Add(Me.Label7)
        Me.Baja_Categoria.Location = New System.Drawing.Point(4, 25)
        Me.Baja_Categoria.Name = "Baja_Categoria"
        Me.Baja_Categoria.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Categoria.Size = New System.Drawing.Size(768, 336)
        Me.Baja_Categoria.TabIndex = 2
        Me.Baja_Categoria.Text = "Baja de categoría"
        '
        'Btn_Baja_Limpiar_Ctg
        '
        Me.Btn_Baja_Limpiar_Ctg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Baja_Limpiar_Ctg.Location = New System.Drawing.Point(391, 134)
        Me.Btn_Baja_Limpiar_Ctg.Name = "Btn_Baja_Limpiar_Ctg"
        Me.Btn_Baja_Limpiar_Ctg.Size = New System.Drawing.Size(62, 25)
        Me.Btn_Baja_Limpiar_Ctg.TabIndex = 17
        Me.Btn_Baja_Limpiar_Ctg.Text = "Limpiar"
        Me.Btn_Baja_Limpiar_Ctg.UseVisualStyleBackColor = False
        '
        'Btn_Baja_Buscar
        '
        Me.Btn_Baja_Buscar.BackColor = System.Drawing.Color.Lime
        Me.Btn_Baja_Buscar.Location = New System.Drawing.Point(469, 134)
        Me.Btn_Baja_Buscar.Name = "Btn_Baja_Buscar"
        Me.Btn_Baja_Buscar.Size = New System.Drawing.Size(128, 25)
        Me.Btn_Baja_Buscar.TabIndex = 16
        Me.Btn_Baja_Buscar.Text = "Buscar"
        Me.Btn_Baja_Buscar.UseVisualStyleBackColor = False
        '
        'TtBo_Baja_DescCategoria
        '
        Me.TtBo_Baja_DescCategoria.Location = New System.Drawing.Point(391, 96)
        Me.TtBo_Baja_DescCategoria.MaxLength = 80
        Me.TtBo_Baja_DescCategoria.Name = "TtBo_Baja_DescCategoria"
        Me.TtBo_Baja_DescCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Baja_DescCategoria.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(201, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Descripción de la categoría:"
        '
        'TtBo_Baja_NombCategoria
        '
        Me.TtBo_Baja_NombCategoria.Location = New System.Drawing.Point(391, 62)
        Me.TtBo_Baja_NombCategoria.MaxLength = 40
        Me.TtBo_Baja_NombCategoria.Name = "TtBo_Baja_NombCategoria"
        Me.TtBo_Baja_NombCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Baja_NombCategoria.TabIndex = 13
        Me.TtBo_Baja_NombCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(206, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre de la categoría:"
        '
        'Form_Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Categorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Alta_Categoria.ResumeLayout(False)
        Me.Alta_Categoria.PerformLayout()
        Me.Consulta_Categorias.ResumeLayout(False)
        Me.Consulta_Categorias.PerformLayout()
        CType(Me.DGVListaCtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cambio_Categoria.ResumeLayout(False)
        Me.Cambio_Categoria.PerformLayout()
        Me.Baja_Categoria.ResumeLayout(False)
        Me.Baja_Categoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_atras As Button
    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Alta_Categoria As TabPage
    Friend WithEvents Consulta_Categorias As TabPage
    Friend WithEvents Btn_Alta_Limpiar_Categorias As Button
    Friend WithEvents Btn_Categorias_Guardar As Button
    Friend WithEvents TtBo_Alta_DescCategoria As TextBox
    Friend WithEvents Lab_Catg_DescCategoria As Label
    Friend WithEvents TtBo_Alta_NombCategoria As TextBox
    Friend WithEvents Lab_Catg_NombCategoria As Label
    Friend WithEvents Cambio_Categoria As TabPage
    Friend WithEvents Baja_Categoria As TabPage
    Friend WithEvents Btn_Consulta_Buscar As Button
    Friend WithEvents TtBo_Consulta_NombCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVListaCtg As DataGridView
    Friend WithEvents DGV_Catg_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Catg_Nomb As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Catg_Descp As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Cambios_Limpiar As Button
    Friend WithEvents Btn_Cambios_Guardar As Button
    Friend WithEvents TtBo_Cambios_DescCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TtBo_Cambios_NombCategoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_Baja_Limpiar_Ctg As Button
    Friend WithEvents Btn_Baja_Buscar As Button
    Friend WithEvents TtBo_Baja_DescCategoria As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TtBo_Baja_NombCategoria As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_Consulta_BuscarTodo As Button
End Class
