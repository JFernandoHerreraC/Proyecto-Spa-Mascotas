<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CorteCaja
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
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_Ctr_CorteCaja = New System.Windows.Forms.TabControl()
        Me.Alta_CorteCajaParcial = New System.Windows.Forms.TabPage()
        Me.Alta_CorteCajaFinal = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Consulta_CorteCajaHist = New System.Windows.Forms.TabPage()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_CorteCaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Size = New System.Drawing.Size(800, 24)
        Me.MenuS_Principal.TabIndex = 1
        Me.MenuS_Principal.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaducosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CaducosToolStripMenuItem
        '
        Me.CaducosToolStripMenuItem.Name = "CaducosToolStripMenuItem"
        Me.CaducosToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CaducosToolStripMenuItem.Text = "Caducos"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
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
        'Tab_Ctr_CorteCaja
        '
        Me.Tab_Ctr_CorteCaja.Controls.Add(Me.Alta_CorteCajaParcial)
        Me.Tab_Ctr_CorteCaja.Controls.Add(Me.Alta_CorteCajaFinal)
        Me.Tab_Ctr_CorteCaja.Controls.Add(Me.Consulta_CorteCajaHist)
        Me.Tab_Ctr_CorteCaja.Location = New System.Drawing.Point(12, 61)
        Me.Tab_Ctr_CorteCaja.Name = "Tab_Ctr_CorteCaja"
        Me.Tab_Ctr_CorteCaja.SelectedIndex = 0
        Me.Tab_Ctr_CorteCaja.Size = New System.Drawing.Size(750, 377)
        Me.Tab_Ctr_CorteCaja.TabIndex = 2
        '
        'Alta_CorteCajaParcial
        '
        Me.Alta_CorteCajaParcial.Location = New System.Drawing.Point(4, 22)
        Me.Alta_CorteCajaParcial.Name = "Alta_CorteCajaParcial"
        Me.Alta_CorteCajaParcial.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_CorteCajaParcial.Size = New System.Drawing.Size(742, 351)
        Me.Alta_CorteCajaParcial.TabIndex = 0
        Me.Alta_CorteCajaParcial.Text = "Corte de caja parcial"
        Me.Alta_CorteCajaParcial.UseVisualStyleBackColor = True
        '
        'Alta_CorteCajaFinal
        '
        Me.Alta_CorteCajaFinal.Location = New System.Drawing.Point(4, 22)
        Me.Alta_CorteCajaFinal.Name = "Alta_CorteCajaFinal"
        Me.Alta_CorteCajaFinal.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_CorteCajaFinal.Size = New System.Drawing.Size(742, 351)
        Me.Alta_CorteCajaFinal.TabIndex = 1
        Me.Alta_CorteCajaFinal.Text = "Carte de caja final"
        Me.Alta_CorteCajaFinal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "< Atras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Consulta_CorteCajaHist
        '
        Me.Consulta_CorteCajaHist.Location = New System.Drawing.Point(4, 22)
        Me.Consulta_CorteCajaHist.Name = "Consulta_CorteCajaHist"
        Me.Consulta_CorteCajaHist.Size = New System.Drawing.Size(742, 351)
        Me.Consulta_CorteCajaHist.TabIndex = 2
        Me.Consulta_CorteCajaHist.Text = "Historial de cortes de caja"
        Me.Consulta_CorteCajaHist.UseVisualStyleBackColor = True
        '
        'Form_CorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tab_Ctr_CorteCaja)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Name = "Form_CorteCaja"
        Me.Text = "Corte de caja"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_CorteCaja.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tab_Ctr_CorteCaja As TabControl
    Friend WithEvents Alta_CorteCajaParcial As TabPage
    Friend WithEvents Alta_CorteCajaFinal As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Consulta_CorteCajaHist As TabPage
End Class
