<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Caducos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Caducos))
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
        Me.CategoriasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Caducos_BuscarTodo = New System.Windows.Forms.Button()
        Me.Lab_NombreCaducos = New System.Windows.Forms.Label()
        Me.CoBo_NombresProdCaducos = New System.Windows.Forms.ComboBox()
        Me.Btn_Caducos_Buscar = New System.Windows.Forms.Button()
        Me.GrBo_BusquedaProductosCaducos = New System.Windows.Forms.GroupBox()
        Me.DGV_ListCaducos = New System.Windows.Forms.DataGridView()
        Me.MenuS_Principal.SuspendLayout()
        Me.GrBo_BusquedaProductosCaducos.SuspendLayout()
        CType(Me.DGV_ListCaducos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem, Me.CategoriasToolStripMenuItem1})
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
        'CategoriasToolStripMenuItem1
        '
        Me.CategoriasToolStripMenuItem1.Name = "CategoriasToolStripMenuItem1"
        Me.CategoriasToolStripMenuItem1.Size = New System.Drawing.Size(75, 20)
        Me.CategoriasToolStripMenuItem1.Text = "Categorias"
        '
        'Btn_Caducos_BuscarTodo
        '
        Me.Btn_Caducos_BuscarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Caducos_BuscarTodo.Location = New System.Drawing.Point(132, 68)
        Me.Btn_Caducos_BuscarTodo.Name = "Btn_Caducos_BuscarTodo"
        Me.Btn_Caducos_BuscarTodo.Size = New System.Drawing.Size(93, 25)
        Me.Btn_Caducos_BuscarTodo.TabIndex = 5
        Me.Btn_Caducos_BuscarTodo.Text = "Buscar todo"
        Me.Btn_Caducos_BuscarTodo.UseVisualStyleBackColor = False
        '
        'Lab_NombreCaducos
        '
        Me.Lab_NombreCaducos.AutoSize = True
        Me.Lab_NombreCaducos.BackColor = System.Drawing.Color.Transparent
        Me.Lab_NombreCaducos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_NombreCaducos.Location = New System.Drawing.Point(22, 38)
        Me.Lab_NombreCaducos.Name = "Lab_NombreCaducos"
        Me.Lab_NombreCaducos.Size = New System.Drawing.Size(133, 17)
        Me.Lab_NombreCaducos.TabIndex = 6
        Me.Lab_NombreCaducos.Text = "Buscar por nombre:"
        '
        'CoBo_NombresProdCaducos
        '
        Me.CoBo_NombresProdCaducos.FormattingEnabled = True
        Me.CoBo_NombresProdCaducos.Location = New System.Drawing.Point(161, 38)
        Me.CoBo_NombresProdCaducos.Name = "CoBo_NombresProdCaducos"
        Me.CoBo_NombresProdCaducos.Size = New System.Drawing.Size(145, 24)
        Me.CoBo_NombresProdCaducos.TabIndex = 7
        '
        'Btn_Caducos_Buscar
        '
        Me.Btn_Caducos_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Caducos_Buscar.Location = New System.Drawing.Point(231, 69)
        Me.Btn_Caducos_Buscar.Name = "Btn_Caducos_Buscar"
        Me.Btn_Caducos_Buscar.Size = New System.Drawing.Size(94, 23)
        Me.Btn_Caducos_Buscar.TabIndex = 8
        Me.Btn_Caducos_Buscar.Text = "Buscar"
        Me.Btn_Caducos_Buscar.UseVisualStyleBackColor = False
        '
        'GrBo_BusquedaProductosCaducos
        '
        Me.GrBo_BusquedaProductosCaducos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrBo_BusquedaProductosCaducos.Controls.Add(Me.CoBo_NombresProdCaducos)
        Me.GrBo_BusquedaProductosCaducos.Controls.Add(Me.Btn_Caducos_Buscar)
        Me.GrBo_BusquedaProductosCaducos.Controls.Add(Me.Btn_Caducos_BuscarTodo)
        Me.GrBo_BusquedaProductosCaducos.Controls.Add(Me.Lab_NombreCaducos)
        Me.GrBo_BusquedaProductosCaducos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrBo_BusquedaProductosCaducos.Location = New System.Drawing.Point(220, 56)
        Me.GrBo_BusquedaProductosCaducos.Name = "GrBo_BusquedaProductosCaducos"
        Me.GrBo_BusquedaProductosCaducos.Size = New System.Drawing.Size(402, 100)
        Me.GrBo_BusquedaProductosCaducos.TabIndex = 9
        Me.GrBo_BusquedaProductosCaducos.TabStop = False
        Me.GrBo_BusquedaProductosCaducos.Text = "Información para busqueda caducos"
        '
        'DGV_ListCaducos
        '
        Me.DGV_ListCaducos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ListCaducos.Location = New System.Drawing.Point(135, 202)
        Me.DGV_ListCaducos.Name = "DGV_ListCaducos"
        Me.DGV_ListCaducos.Size = New System.Drawing.Size(525, 150)
        Me.DGV_ListCaducos.TabIndex = 10
        '
        'Form_Caducos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGV_ListCaducos)
        Me.Controls.Add(Me.GrBo_BusquedaProductosCaducos)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Caducos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos caducos"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.GrBo_BusquedaProductosCaducos.ResumeLayout(False)
        Me.GrBo_BusquedaProductosCaducos.PerformLayout()
        CType(Me.DGV_ListCaducos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CategoriasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Btn_Caducos_BuscarTodo As Button
    Friend WithEvents Lab_NombreCaducos As Label
    Friend WithEvents CoBo_NombresProdCaducos As ComboBox
    Friend WithEvents Btn_Caducos_Buscar As Button
    Friend WithEvents GrBo_BusquedaProductosCaducos As GroupBox
    Friend WithEvents DGV_ListCaducos As DataGridView
End Class
