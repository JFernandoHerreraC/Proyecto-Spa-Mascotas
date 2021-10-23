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
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_Ctr_Empleados = New System.Windows.Forms.TabControl()
        Me.Alta_Empleado = New System.Windows.Forms.TabPage()
        Me.Consulta_Empleado = New System.Windows.Forms.TabPage()
        Me.Cambio_Empleado = New System.Windows.Forms.TabPage()
        Me.Baja_Empleado = New System.Windows.Forms.TabPage()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_Empleados.SuspendLayout()
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
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem1, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Size = New System.Drawing.Size(800, 24)
        Me.MenuS_Principal.TabIndex = 3
        Me.MenuS_Principal.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
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
        'Tab_Ctr_Empleados
        '
        Me.Tab_Ctr_Empleados.Controls.Add(Me.Alta_Empleado)
        Me.Tab_Ctr_Empleados.Controls.Add(Me.Consulta_Empleado)
        Me.Tab_Ctr_Empleados.Controls.Add(Me.Cambio_Empleado)
        Me.Tab_Ctr_Empleados.Controls.Add(Me.Baja_Empleado)
        Me.Tab_Ctr_Empleados.Location = New System.Drawing.Point(12, 56)
        Me.Tab_Ctr_Empleados.Name = "Tab_Ctr_Empleados"
        Me.Tab_Ctr_Empleados.SelectedIndex = 0
        Me.Tab_Ctr_Empleados.Size = New System.Drawing.Size(776, 382)
        Me.Tab_Ctr_Empleados.TabIndex = 5
        '
        'Alta_Empleado
        '
        Me.Alta_Empleado.Location = New System.Drawing.Point(4, 22)
        Me.Alta_Empleado.Name = "Alta_Empleado"
        Me.Alta_Empleado.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Empleado.Size = New System.Drawing.Size(768, 356)
        Me.Alta_Empleado.TabIndex = 0
        Me.Alta_Empleado.Text = "Alta de empleado"
        Me.Alta_Empleado.UseVisualStyleBackColor = True
        '
        'Consulta_Empleado
        '
        Me.Consulta_Empleado.Location = New System.Drawing.Point(4, 22)
        Me.Consulta_Empleado.Name = "Consulta_Empleado"
        Me.Consulta_Empleado.Size = New System.Drawing.Size(768, 356)
        Me.Consulta_Empleado.TabIndex = 3
        Me.Consulta_Empleado.Text = "Consulta de empleado"
        Me.Consulta_Empleado.UseVisualStyleBackColor = True
        '
        'Cambio_Empleado
        '
        Me.Cambio_Empleado.Location = New System.Drawing.Point(4, 22)
        Me.Cambio_Empleado.Name = "Cambio_Empleado"
        Me.Cambio_Empleado.Size = New System.Drawing.Size(768, 356)
        Me.Cambio_Empleado.TabIndex = 2
        Me.Cambio_Empleado.Text = "Cambios en el empleado"
        Me.Cambio_Empleado.UseVisualStyleBackColor = True
        '
        'Baja_Empleado
        '
        Me.Baja_Empleado.Location = New System.Drawing.Point(4, 22)
        Me.Baja_Empleado.Name = "Baja_Empleado"
        Me.Baja_Empleado.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Empleado.Size = New System.Drawing.Size(768, 356)
        Me.Baja_Empleado.TabIndex = 1
        Me.Baja_Empleado.Text = "Baja de empleado"
        Me.Baja_Empleado.UseVisualStyleBackColor = True
        '
        'Form_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tab_Ctr_Empleados)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Name = "Form_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_Empleados.ResumeLayout(False)
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
End Class
