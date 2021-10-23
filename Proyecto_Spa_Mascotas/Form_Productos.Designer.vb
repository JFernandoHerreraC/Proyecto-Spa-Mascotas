<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Productos
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
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_ABCC_Productos = New System.Windows.Forms.TabControl()
        Me.Alta_Productos = New System.Windows.Forms.TabPage()
        Me.Consulta_Productos = New System.Windows.Forms.TabPage()
        Me.Baja_Productos = New System.Windows.Forms.TabPage()
        Me.Cambios_Productos = New System.Windows.Forms.TabPage()
        Me.Caducos_Productos = New System.Windows.Forms.TabPage()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_ABCC_Productos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(12, 27)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(75, 23)
        Me.Btn_atras.TabIndex = 8
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiciosToolStripMenuItem1, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem1})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Size = New System.Drawing.Size(800, 24)
        Me.MenuS_Principal.TabIndex = 7
        Me.MenuS_Principal.Text = "MenuStrip1"
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
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'Tab_ABCC_Productos
        '
        Me.Tab_ABCC_Productos.Controls.Add(Me.Alta_Productos)
        Me.Tab_ABCC_Productos.Controls.Add(Me.Consulta_Productos)
        Me.Tab_ABCC_Productos.Controls.Add(Me.Baja_Productos)
        Me.Tab_ABCC_Productos.Controls.Add(Me.Cambios_Productos)
        Me.Tab_ABCC_Productos.Controls.Add(Me.Caducos_Productos)
        Me.Tab_ABCC_Productos.Location = New System.Drawing.Point(12, 68)
        Me.Tab_ABCC_Productos.Name = "Tab_ABCC_Productos"
        Me.Tab_ABCC_Productos.SelectedIndex = 0
        Me.Tab_ABCC_Productos.Size = New System.Drawing.Size(776, 370)
        Me.Tab_ABCC_Productos.TabIndex = 9
        '
        'Alta_Productos
        '
        Me.Alta_Productos.Location = New System.Drawing.Point(4, 22)
        Me.Alta_Productos.Name = "Alta_Productos"
        Me.Alta_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Productos.Size = New System.Drawing.Size(768, 344)
        Me.Alta_Productos.TabIndex = 0
        Me.Alta_Productos.Text = "Alta Productos"
        Me.Alta_Productos.UseVisualStyleBackColor = True
        '
        'Consulta_Productos
        '
        Me.Consulta_Productos.Location = New System.Drawing.Point(4, 22)
        Me.Consulta_Productos.Name = "Consulta_Productos"
        Me.Consulta_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.Consulta_Productos.Size = New System.Drawing.Size(768, 344)
        Me.Consulta_Productos.TabIndex = 1
        Me.Consulta_Productos.Text = "Consulta de Producto"
        Me.Consulta_Productos.UseVisualStyleBackColor = True
        '
        'Baja_Productos
        '
        Me.Baja_Productos.Location = New System.Drawing.Point(4, 22)
        Me.Baja_Productos.Name = "Baja_Productos"
        Me.Baja_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Productos.Size = New System.Drawing.Size(768, 344)
        Me.Baja_Productos.TabIndex = 3
        Me.Baja_Productos.Text = "Bajas de Productos"
        Me.Baja_Productos.UseVisualStyleBackColor = True
        '
        'Cambios_Productos
        '
        Me.Cambios_Productos.Location = New System.Drawing.Point(4, 22)
        Me.Cambios_Productos.Name = "Cambios_Productos"
        Me.Cambios_Productos.Size = New System.Drawing.Size(768, 344)
        Me.Cambios_Productos.TabIndex = 4
        Me.Cambios_Productos.Text = "Cambios de Productos"
        Me.Cambios_Productos.UseVisualStyleBackColor = True
        '
        'Caducos_Productos
        '
        Me.Caducos_Productos.Location = New System.Drawing.Point(4, 22)
        Me.Caducos_Productos.Name = "Caducos_Productos"
        Me.Caducos_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.Caducos_Productos.Size = New System.Drawing.Size(768, 344)
        Me.Caducos_Productos.TabIndex = 5
        Me.Caducos_Productos.Text = "Productos caducos"
        Me.Caducos_Productos.UseVisualStyleBackColor = True
        '
        'Form_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tab_ABCC_Productos)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Name = "Form_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_ABCC_Productos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_atras As Button
    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ServiciosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Tab_ABCC_Productos As TabControl
    Friend WithEvents Alta_Productos As TabPage
    Friend WithEvents Consulta_Productos As TabPage
    Friend WithEvents Baja_Productos As TabPage
    Friend WithEvents Cambios_Productos As TabPage
    Friend WithEvents Caducos_Productos As TabPage
End Class
