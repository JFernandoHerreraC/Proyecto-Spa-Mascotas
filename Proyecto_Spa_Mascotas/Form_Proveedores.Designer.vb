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
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_Ctr_Proveedor = New System.Windows.Forms.TabControl()
        Me.Alta_Proveedores = New System.Windows.Forms.TabPage()
        Me.Consulta_Proveedores = New System.Windows.Forms.TabPage()
        Me.Cambio_Proveedor = New System.Windows.Forms.TabPage()
        Me.Baja_Proveedores = New System.Windows.Forms.TabPage()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_Proveedor.SuspendLayout()
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
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem1, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem})
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
        Me.Tab_Ctr_Proveedor.Controls.Add(Me.Alta_Proveedores)
        Me.Tab_Ctr_Proveedor.Controls.Add(Me.Consulta_Proveedores)
        Me.Tab_Ctr_Proveedor.Controls.Add(Me.Cambio_Proveedor)
        Me.Tab_Ctr_Proveedor.Controls.Add(Me.Baja_Proveedores)
        Me.Tab_Ctr_Proveedor.Location = New System.Drawing.Point(12, 56)
        Me.Tab_Ctr_Proveedor.Name = "Tab_Ctr_Proveedor"
        Me.Tab_Ctr_Proveedor.SelectedIndex = 0
        Me.Tab_Ctr_Proveedor.Size = New System.Drawing.Size(776, 382)
        Me.Tab_Ctr_Proveedor.TabIndex = 5
        '
        'Alta_Proveedores
        '
        Me.Alta_Proveedores.Location = New System.Drawing.Point(4, 22)
        Me.Alta_Proveedores.Name = "Alta_Proveedores"
        Me.Alta_Proveedores.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Proveedores.Size = New System.Drawing.Size(768, 356)
        Me.Alta_Proveedores.TabIndex = 0
        Me.Alta_Proveedores.Text = "Alta de proveedor"
        Me.Alta_Proveedores.UseVisualStyleBackColor = True
        '
        'Consulta_Proveedores
        '
        Me.Consulta_Proveedores.Location = New System.Drawing.Point(4, 22)
        Me.Consulta_Proveedores.Name = "Consulta_Proveedores"
        Me.Consulta_Proveedores.Size = New System.Drawing.Size(768, 356)
        Me.Consulta_Proveedores.TabIndex = 2
        Me.Consulta_Proveedores.Text = "Consulta de proveedores"
        Me.Consulta_Proveedores.UseVisualStyleBackColor = True
        '
        'Cambio_Proveedor
        '
        Me.Cambio_Proveedor.Location = New System.Drawing.Point(4, 22)
        Me.Cambio_Proveedor.Name = "Cambio_Proveedor"
        Me.Cambio_Proveedor.Size = New System.Drawing.Size(768, 356)
        Me.Cambio_Proveedor.TabIndex = 3
        Me.Cambio_Proveedor.Text = "Cambios en el proveedor"
        Me.Cambio_Proveedor.UseVisualStyleBackColor = True
        '
        'Baja_Proveedores
        '
        Me.Baja_Proveedores.Location = New System.Drawing.Point(4, 22)
        Me.Baja_Proveedores.Name = "Baja_Proveedores"
        Me.Baja_Proveedores.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Proveedores.Size = New System.Drawing.Size(768, 356)
        Me.Baja_Proveedores.TabIndex = 1
        Me.Baja_Proveedores.Text = "Baja de proveedor"
        Me.Baja_Proveedores.UseVisualStyleBackColor = True
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'CaducosToolStripMenuItem
        '
        Me.CaducosToolStripMenuItem.Name = "CaducosToolStripMenuItem"
        Me.CaducosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CaducosToolStripMenuItem.Text = "Caducos"
        '
        'Form_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tab_Ctr_Proveedor)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Name = "Form_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_Proveedor.ResumeLayout(False)
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
End Class
