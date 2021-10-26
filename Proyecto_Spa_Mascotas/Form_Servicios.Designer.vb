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
        Me.Baja_Servicio = New System.Windows.Forms.TabPage()
        Me.Consulta_Servicio = New System.Windows.Forms.TabPage()
        Me.Cambio_Servicio = New System.Windows.Forms.TabPage()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_Servicio.SuspendLayout()
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
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Baja_Servicio)
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Consulta_Servicio)
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Cambio_Servicio)
        Me.Tab_Ctr_Servicio.Location = New System.Drawing.Point(12, 56)
        Me.Tab_Ctr_Servicio.Name = "Tab_Ctr_Servicio"
        Me.Tab_Ctr_Servicio.SelectedIndex = 0
        Me.Tab_Ctr_Servicio.Size = New System.Drawing.Size(776, 382)
        Me.Tab_Ctr_Servicio.TabIndex = 3
        '
        'Alta_Servicio
        '
        Me.Alta_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Alta_Servicio.Name = "Alta_Servicio"
        Me.Alta_Servicio.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Alta_Servicio.TabIndex = 0
        Me.Alta_Servicio.Text = "Altas de Servicio"
        Me.Alta_Servicio.UseVisualStyleBackColor = True
        '
        'Baja_Servicio
        '
        Me.Baja_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Baja_Servicio.Name = "Baja_Servicio"
        Me.Baja_Servicio.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Baja_Servicio.TabIndex = 1
        Me.Baja_Servicio.Text = "Bajas de Servicio"
        Me.Baja_Servicio.UseVisualStyleBackColor = True
        '
        'Consulta_Servicio
        '
        Me.Consulta_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Consulta_Servicio.Name = "Consulta_Servicio"
        Me.Consulta_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Consulta_Servicio.TabIndex = 2
        Me.Consulta_Servicio.Text = "Consulta de Servicios"
        Me.Consulta_Servicio.UseVisualStyleBackColor = True
        '
        'Cambio_Servicio
        '
        Me.Cambio_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Cambio_Servicio.Name = "Cambio_Servicio"
        Me.Cambio_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Cambio_Servicio.TabIndex = 3
        Me.Cambio_Servicio.Text = "Cambios en el servicio"
        Me.Cambio_Servicio.UseVisualStyleBackColor = True
        '
        'Form_Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
End Class
