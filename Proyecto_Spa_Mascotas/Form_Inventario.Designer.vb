<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Inventario
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
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DGV_CodigoBarra_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Desc_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Fcaducidad_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_PrecioPub_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_PrecioProv_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_CantidadEx_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuS_Principal.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem1, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem})
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Mostrar productos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_CodigoBarra_Producto, Me.DGV_Nombre_Producto, Me.DGV_Desc_Producto, Me.DGV_Fcaducidad_Producto, Me.DGV_PrecioPub_Producto, Me.DGV_PrecioProv_Producto, Me.DGV_CantidadEx_Producto})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(741, 284)
        Me.DataGridView1.TabIndex = 6
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
        'Form_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Name = "Form_Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_atras As Button
    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DGV_CodigoBarra_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Nombre_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Desc_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Fcaducidad_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_PrecioPub_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_PrecioProv_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DGV_CantidadEx_Producto As DataGridViewTextBoxColumn
End Class
