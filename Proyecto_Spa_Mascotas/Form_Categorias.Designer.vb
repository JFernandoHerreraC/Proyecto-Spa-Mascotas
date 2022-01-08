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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_Categorias_Guardar = New System.Windows.Forms.Button()
        Me.TtBo_Alta_DescCategoria = New System.Windows.Forms.TextBox()
        Me.Lab_Catg_DescCategoria = New System.Windows.Forms.Label()
        Me.TtBo_Alta_NombCategoria = New System.Windows.Forms.TextBox()
        Me.Lab_Catg_NombCategoria = New System.Windows.Forms.Label()
        Me.Consulta_Categorias = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DGV_Catg_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Catg_Nomb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Catg_Descp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TtBo_Consulta_NombCategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cambio_Categoria = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TtBo_Cambios_DescCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_NombCategoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Baja_Categoria = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TtBo_Baja_DescCategoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TtBo_Baja_NombCategoria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuS_Principal.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Alta_Categoria.SuspendLayout()
        Me.Consulta_Categorias.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Alta_Categoria.Controls.Add(Me.Button2)
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(395, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btn_Categorias_Guardar
        '
        Me.Btn_Categorias_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Categorias_Guardar.Location = New System.Drawing.Point(481, 136)
        Me.Btn_Categorias_Guardar.Name = "Btn_Categorias_Guardar"
        Me.Btn_Categorias_Guardar.Size = New System.Drawing.Size(120, 25)
        Me.Btn_Categorias_Guardar.TabIndex = 4
        Me.Btn_Categorias_Guardar.Text = "Guardar"
        Me.Btn_Categorias_Guardar.UseVisualStyleBackColor = False
        '
        'TtBo_Alta_DescCategoria
        '
        Me.TtBo_Alta_DescCategoria.Location = New System.Drawing.Point(395, 98)
        Me.TtBo_Alta_DescCategoria.MaxLength = 120
        Me.TtBo_Alta_DescCategoria.Name = "TtBo_Alta_DescCategoria"
        Me.TtBo_Alta_DescCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Alta_DescCategoria.TabIndex = 3
        '
        'Lab_Catg_DescCategoria
        '
        Me.Lab_Catg_DescCategoria.AutoSize = True
        Me.Lab_Catg_DescCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Catg_DescCategoria.Location = New System.Drawing.Point(186, 101)
        Me.Lab_Catg_DescCategoria.Name = "Lab_Catg_DescCategoria"
        Me.Lab_Catg_DescCategoria.Size = New System.Drawing.Size(184, 17)
        Me.Lab_Catg_DescCategoria.TabIndex = 2
        Me.Lab_Catg_DescCategoria.Text = "Descripción de la categoría:"
        '
        'TtBo_Alta_NombCategoria
        '
        Me.TtBo_Alta_NombCategoria.Location = New System.Drawing.Point(395, 64)
        Me.TtBo_Alta_NombCategoria.MaxLength = 30
        Me.TtBo_Alta_NombCategoria.Name = "TtBo_Alta_NombCategoria"
        Me.TtBo_Alta_NombCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Alta_NombCategoria.TabIndex = 1
        '
        'Lab_Catg_NombCategoria
        '
        Me.Lab_Catg_NombCategoria.AutoSize = True
        Me.Lab_Catg_NombCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Catg_NombCategoria.Location = New System.Drawing.Point(186, 64)
        Me.Lab_Catg_NombCategoria.Name = "Lab_Catg_NombCategoria"
        Me.Lab_Catg_NombCategoria.Size = New System.Drawing.Size(160, 17)
        Me.Lab_Catg_NombCategoria.TabIndex = 0
        Me.Lab_Catg_NombCategoria.Text = "Nombre de la categoría:"
        '
        'Consulta_Categorias
        '
        Me.Consulta_Categorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_Categorias.Controls.Add(Me.Button8)
        Me.Consulta_Categorias.Controls.Add(Me.DataGridView1)
        Me.Consulta_Categorias.Controls.Add(Me.Button3)
        Me.Consulta_Categorias.Controls.Add(Me.TtBo_Consulta_NombCategoria)
        Me.Consulta_Categorias.Controls.Add(Me.Label3)
        Me.Consulta_Categorias.Location = New System.Drawing.Point(4, 25)
        Me.Consulta_Categorias.Name = "Consulta_Categorias"
        Me.Consulta_Categorias.Padding = New System.Windows.Forms.Padding(3)
        Me.Consulta_Categorias.Size = New System.Drawing.Size(768, 336)
        Me.Consulta_Categorias.TabIndex = 1
        Me.Consulta_Categorias.Text = "Consulta de categorías"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(268, 75)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(123, 25)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Buscar todo"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Catg_ID, Me.DGV_Catg_Nomb, Me.DGV_Catg_Descp})
        Me.DataGridView1.Location = New System.Drawing.Point(229, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 150)
        Me.DataGridView1.TabIndex = 3
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(397, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 25)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TtBo_Consulta_NombCategoria
        '
        Me.TtBo_Consulta_NombCategoria.Location = New System.Drawing.Point(338, 49)
        Me.TtBo_Consulta_NombCategoria.MaxLength = 30
        Me.TtBo_Consulta_NombCategoria.Name = "TtBo_Consulta_NombCategoria"
        Me.TtBo_Consulta_NombCategoria.Size = New System.Drawing.Size(179, 23)
        Me.TtBo_Consulta_NombCategoria.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(171, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre de la categoría:"
        '
        'Cambio_Categoria
        '
        Me.Cambio_Categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cambio_Categoria.Controls.Add(Me.Button4)
        Me.Cambio_Categoria.Controls.Add(Me.Button5)
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(395, 151)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 25)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(481, 151)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 25)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TtBo_Cambios_DescCategoria
        '
        Me.TtBo_Cambios_DescCategoria.Location = New System.Drawing.Point(395, 113)
        Me.TtBo_Cambios_DescCategoria.MaxLength = 120
        Me.TtBo_Cambios_DescCategoria.Name = "TtBo_Cambios_DescCategoria"
        Me.TtBo_Cambios_DescCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Cambios_DescCategoria.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(205, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Descripción de la categoría:"
        '
        'TtBo_Cambios_NombCategoria
        '
        Me.TtBo_Cambios_NombCategoria.Location = New System.Drawing.Point(395, 80)
        Me.TtBo_Cambios_NombCategoria.MaxLength = 30
        Me.TtBo_Cambios_NombCategoria.Name = "TtBo_Cambios_NombCategoria"
        Me.TtBo_Cambios_NombCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Cambios_NombCategoria.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(205, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre de la categoría:"
        '
        'Baja_Categoria
        '
        Me.Baja_Categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baja_Categoria.Controls.Add(Me.Button6)
        Me.Baja_Categoria.Controls.Add(Me.Button7)
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
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(397, 173)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(62, 25)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Limpiar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Lime
        Me.Button7.Location = New System.Drawing.Point(475, 173)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 25)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Buscar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TtBo_Baja_DescCategoria
        '
        Me.TtBo_Baja_DescCategoria.Location = New System.Drawing.Point(397, 135)
        Me.TtBo_Baja_DescCategoria.MaxLength = 120
        Me.TtBo_Baja_DescCategoria.Name = "TtBo_Baja_DescCategoria"
        Me.TtBo_Baja_DescCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Baja_DescCategoria.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(207, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Descripción de la categoría:"
        '
        'TtBo_Baja_NombCategoria
        '
        Me.TtBo_Baja_NombCategoria.Location = New System.Drawing.Point(397, 101)
        Me.TtBo_Baja_NombCategoria.MaxLength = 30
        Me.TtBo_Baja_NombCategoria.Name = "TtBo_Baja_NombCategoria"
        Me.TtBo_Baja_NombCategoria.Size = New System.Drawing.Size(206, 23)
        Me.TtBo_Baja_NombCategoria.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(212, 101)
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
        Me.Text = "Categorias"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Alta_Categoria.ResumeLayout(False)
        Me.Alta_Categoria.PerformLayout()
        Me.Consulta_Categorias.ResumeLayout(False)
        Me.Consulta_Categorias.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Btn_Categorias_Guardar As Button
    Friend WithEvents TtBo_Alta_DescCategoria As TextBox
    Friend WithEvents Lab_Catg_DescCategoria As Label
    Friend WithEvents TtBo_Alta_NombCategoria As TextBox
    Friend WithEvents Lab_Catg_NombCategoria As Label
    Friend WithEvents Cambio_Categoria As TabPage
    Friend WithEvents Baja_Categoria As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents TtBo_Consulta_NombCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DGV_Catg_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Catg_Nomb As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Catg_Descp As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TtBo_Cambios_DescCategoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TtBo_Cambios_NombCategoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TtBo_Baja_DescCategoria As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TtBo_Baja_NombCategoria As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
End Class
