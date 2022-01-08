<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Compras))
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.MenuS_Principal = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaducosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_Ctr_Compra = New System.Windows.Forms.TabControl()
        Me.Alta_Compra = New System.Windows.Forms.TabPage()
        Me.Btn_Alta_LimpiarCompras = New System.Windows.Forms.Button()
        Me.Btn_Alta_GuardarCompras = New System.Windows.Forms.Button()
        Me.DaTiPi_Alta_FechaCompras = New System.Windows.Forms.DateTimePicker()
        Me.Lab_Alta_DescCompras = New System.Windows.Forms.Label()
        Me.TtBo_Alta_DescCompras = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_NombCompras = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_IdCompras = New System.Windows.Forms.TextBox()
        Me.Lab_FechaCompras = New System.Windows.Forms.Label()
        Me.Lab_Alta_NombCompras = New System.Windows.Forms.Label()
        Me.Lab_Alta_IdCompras = New System.Windows.Forms.Label()
        Me.Devoluciones_Compra = New System.Windows.Forms.TabPage()
        Me.Btn_Dev_LimpiarCompras = New System.Windows.Forms.Button()
        Me.Btn_Dev_GuardarCompras = New System.Windows.Forms.Button()
        Me.DaTiPi_Dev_FechaCompras = New System.Windows.Forms.DateTimePicker()
        Me.Lab_Dev_DescCompras = New System.Windows.Forms.Label()
        Me.TtBo_Dev_DescCompras = New System.Windows.Forms.TextBox()
        Me.TtBo_Dev_NombCompras = New System.Windows.Forms.TextBox()
        Me.TtBo_Dev_IdCompras = New System.Windows.Forms.TextBox()
        Me.Lab_Dev_FechaCompras = New System.Windows.Forms.Label()
        Me.Lab_Dev_NombCompras = New System.Windows.Forms.Label()
        Me.Lab_Dev_IdCompras = New System.Windows.Forms.Label()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_Compra.SuspendLayout()
        Me.Alta_Compra.SuspendLayout()
        Me.Devoluciones_Compra.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(12, 27)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(75, 23)
        Me.Btn_atras.TabIndex = 6
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'MenuS_Principal
        '
        Me.MenuS_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem1, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.ClientesYMascotasToolStripMenuItem})
        Me.MenuS_Principal.Location = New System.Drawing.Point(0, 0)
        Me.MenuS_Principal.Name = "MenuS_Principal"
        Me.MenuS_Principal.Size = New System.Drawing.Size(800, 24)
        Me.MenuS_Principal.TabIndex = 5
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
        'ClientesYMascotasToolStripMenuItem
        '
        Me.ClientesYMascotasToolStripMenuItem.Name = "ClientesYMascotasToolStripMenuItem"
        Me.ClientesYMascotasToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.ClientesYMascotasToolStripMenuItem.Text = "Clientes y mascotas"
        '
        'Tab_Ctr_Compra
        '
        Me.Tab_Ctr_Compra.Controls.Add(Me.Alta_Compra)
        Me.Tab_Ctr_Compra.Controls.Add(Me.Devoluciones_Compra)
        Me.Tab_Ctr_Compra.Location = New System.Drawing.Point(12, 56)
        Me.Tab_Ctr_Compra.Name = "Tab_Ctr_Compra"
        Me.Tab_Ctr_Compra.SelectedIndex = 0
        Me.Tab_Ctr_Compra.Size = New System.Drawing.Size(776, 382)
        Me.Tab_Ctr_Compra.TabIndex = 7
        '
        'Alta_Compra
        '
        Me.Alta_Compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_Compra.Controls.Add(Me.Btn_Alta_LimpiarCompras)
        Me.Alta_Compra.Controls.Add(Me.Btn_Alta_GuardarCompras)
        Me.Alta_Compra.Controls.Add(Me.DaTiPi_Alta_FechaCompras)
        Me.Alta_Compra.Controls.Add(Me.Lab_Alta_DescCompras)
        Me.Alta_Compra.Controls.Add(Me.TtBo_Alta_DescCompras)
        Me.Alta_Compra.Controls.Add(Me.TtBo_Alta_NombCompras)
        Me.Alta_Compra.Controls.Add(Me.TtBo_Alta_IdCompras)
        Me.Alta_Compra.Controls.Add(Me.Lab_FechaCompras)
        Me.Alta_Compra.Controls.Add(Me.Lab_Alta_NombCompras)
        Me.Alta_Compra.Controls.Add(Me.Lab_Alta_IdCompras)
        Me.Alta_Compra.Location = New System.Drawing.Point(4, 22)
        Me.Alta_Compra.Name = "Alta_Compra"
        Me.Alta_Compra.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Compra.Size = New System.Drawing.Size(768, 356)
        Me.Alta_Compra.TabIndex = 0
        Me.Alta_Compra.Text = "Alta de compras"
        '
        'Btn_Alta_LimpiarCompras
        '
        Me.Btn_Alta_LimpiarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Alta_LimpiarCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Alta_LimpiarCompras.Location = New System.Drawing.Point(342, 195)
        Me.Btn_Alta_LimpiarCompras.Name = "Btn_Alta_LimpiarCompras"
        Me.Btn_Alta_LimpiarCompras.Size = New System.Drawing.Size(86, 25)
        Me.Btn_Alta_LimpiarCompras.TabIndex = 10
        Me.Btn_Alta_LimpiarCompras.Text = "Limpiar"
        Me.Btn_Alta_LimpiarCompras.UseVisualStyleBackColor = False
        '
        'Btn_Alta_GuardarCompras
        '
        Me.Btn_Alta_GuardarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Alta_GuardarCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Alta_GuardarCompras.Location = New System.Drawing.Point(434, 195)
        Me.Btn_Alta_GuardarCompras.Name = "Btn_Alta_GuardarCompras"
        Me.Btn_Alta_GuardarCompras.Size = New System.Drawing.Size(107, 25)
        Me.Btn_Alta_GuardarCompras.TabIndex = 9
        Me.Btn_Alta_GuardarCompras.Text = "Guardar"
        Me.Btn_Alta_GuardarCompras.UseVisualStyleBackColor = False
        '
        'DaTiPi_Alta_FechaCompras
        '
        Me.DaTiPi_Alta_FechaCompras.Location = New System.Drawing.Point(348, 160)
        Me.DaTiPi_Alta_FechaCompras.Name = "DaTiPi_Alta_FechaCompras"
        Me.DaTiPi_Alta_FechaCompras.Size = New System.Drawing.Size(193, 20)
        Me.DaTiPi_Alta_FechaCompras.TabIndex = 8
        '
        'Lab_Alta_DescCompras
        '
        Me.Lab_Alta_DescCompras.AutoSize = True
        Me.Lab_Alta_DescCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_DescCompras.Location = New System.Drawing.Point(214, 131)
        Me.Lab_Alta_DescCompras.Name = "Lab_Alta_DescCompras"
        Me.Lab_Alta_DescCompras.Size = New System.Drawing.Size(83, 16)
        Me.Lab_Alta_DescCompras.TabIndex = 7
        Me.Lab_Alta_DescCompras.Text = "Descripcion:"
        '
        'TtBo_Alta_DescCompras
        '
        Me.TtBo_Alta_DescCompras.Location = New System.Drawing.Point(359, 125)
        Me.TtBo_Alta_DescCompras.Name = "TtBo_Alta_DescCompras"
        Me.TtBo_Alta_DescCompras.Size = New System.Drawing.Size(155, 20)
        Me.TtBo_Alta_DescCompras.TabIndex = 6
        '
        'TtBo_Alta_NombCompras
        '
        Me.TtBo_Alta_NombCompras.Location = New System.Drawing.Point(359, 98)
        Me.TtBo_Alta_NombCompras.Name = "TtBo_Alta_NombCompras"
        Me.TtBo_Alta_NombCompras.Size = New System.Drawing.Size(155, 20)
        Me.TtBo_Alta_NombCompras.TabIndex = 5
        '
        'TtBo_Alta_IdCompras
        '
        Me.TtBo_Alta_IdCompras.Location = New System.Drawing.Point(359, 71)
        Me.TtBo_Alta_IdCompras.Name = "TtBo_Alta_IdCompras"
        Me.TtBo_Alta_IdCompras.Size = New System.Drawing.Size(155, 20)
        Me.TtBo_Alta_IdCompras.TabIndex = 4
        '
        'Lab_FechaCompras
        '
        Me.Lab_FechaCompras.AutoSize = True
        Me.Lab_FechaCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_FechaCompras.Location = New System.Drawing.Point(211, 160)
        Me.Lab_FechaCompras.Name = "Lab_FechaCompras"
        Me.Lab_FechaCompras.Size = New System.Drawing.Size(131, 16)
        Me.Lab_FechaCompras.TabIndex = 3
        Me.Lab_FechaCompras.Text = "Fecha de la compra:"
        '
        'Lab_Alta_NombCompras
        '
        Me.Lab_Alta_NombCompras.AutoSize = True
        Me.Lab_Alta_NombCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_NombCompras.Location = New System.Drawing.Point(211, 98)
        Me.Lab_Alta_NombCompras.Name = "Lab_Alta_NombCompras"
        Me.Lab_Alta_NombCompras.Size = New System.Drawing.Size(142, 16)
        Me.Lab_Alta_NombCompras.TabIndex = 2
        Me.Lab_Alta_NombCompras.Text = "Nombre de la compra:"
        '
        'Lab_Alta_IdCompras
        '
        Me.Lab_Alta_IdCompras.AutoSize = True
        Me.Lab_Alta_IdCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Alta_IdCompras.Location = New System.Drawing.Point(211, 71)
        Me.Lab_Alta_IdCompras.Name = "Lab_Alta_IdCompras"
        Me.Lab_Alta_IdCompras.Size = New System.Drawing.Size(104, 16)
        Me.Lab_Alta_IdCompras.TabIndex = 1
        Me.Lab_Alta_IdCompras.Text = "Id de la compra:"
        '
        'Devoluciones_Compra
        '
        Me.Devoluciones_Compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Devoluciones_Compra.Controls.Add(Me.Btn_Dev_LimpiarCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.Btn_Dev_GuardarCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.DaTiPi_Dev_FechaCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.Lab_Dev_DescCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.TtBo_Dev_DescCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.TtBo_Dev_NombCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.TtBo_Dev_IdCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.Lab_Dev_FechaCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.Lab_Dev_NombCompras)
        Me.Devoluciones_Compra.Controls.Add(Me.Lab_Dev_IdCompras)
        Me.Devoluciones_Compra.Location = New System.Drawing.Point(4, 22)
        Me.Devoluciones_Compra.Name = "Devoluciones_Compra"
        Me.Devoluciones_Compra.Padding = New System.Windows.Forms.Padding(3)
        Me.Devoluciones_Compra.Size = New System.Drawing.Size(768, 356)
        Me.Devoluciones_Compra.TabIndex = 1
        Me.Devoluciones_Compra.Text = "Devoluciones"
        '
        'Btn_Dev_LimpiarCompras
        '
        Me.Btn_Dev_LimpiarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Dev_LimpiarCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dev_LimpiarCompras.Location = New System.Drawing.Point(396, 186)
        Me.Btn_Dev_LimpiarCompras.Name = "Btn_Dev_LimpiarCompras"
        Me.Btn_Dev_LimpiarCompras.Size = New System.Drawing.Size(86, 25)
        Me.Btn_Dev_LimpiarCompras.TabIndex = 20
        Me.Btn_Dev_LimpiarCompras.Text = "Limpiar"
        Me.Btn_Dev_LimpiarCompras.UseVisualStyleBackColor = False
        '
        'Btn_Dev_GuardarCompras
        '
        Me.Btn_Dev_GuardarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Dev_GuardarCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dev_GuardarCompras.Location = New System.Drawing.Point(488, 186)
        Me.Btn_Dev_GuardarCompras.Name = "Btn_Dev_GuardarCompras"
        Me.Btn_Dev_GuardarCompras.Size = New System.Drawing.Size(125, 25)
        Me.Btn_Dev_GuardarCompras.TabIndex = 19
        Me.Btn_Dev_GuardarCompras.Text = "Guardar"
        Me.Btn_Dev_GuardarCompras.UseVisualStyleBackColor = False
        '
        'DaTiPi_Dev_FechaCompras
        '
        Me.DaTiPi_Dev_FechaCompras.Location = New System.Drawing.Point(420, 143)
        Me.DaTiPi_Dev_FechaCompras.Name = "DaTiPi_Dev_FechaCompras"
        Me.DaTiPi_Dev_FechaCompras.Size = New System.Drawing.Size(193, 20)
        Me.DaTiPi_Dev_FechaCompras.TabIndex = 18
        '
        'Lab_Dev_DescCompras
        '
        Me.Lab_Dev_DescCompras.AutoSize = True
        Me.Lab_Dev_DescCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Dev_DescCompras.Location = New System.Drawing.Point(286, 114)
        Me.Lab_Dev_DescCompras.Name = "Lab_Dev_DescCompras"
        Me.Lab_Dev_DescCompras.Size = New System.Drawing.Size(83, 16)
        Me.Lab_Dev_DescCompras.TabIndex = 17
        Me.Lab_Dev_DescCompras.Text = "Descripcion:"
        '
        'TtBo_Dev_DescCompras
        '
        Me.TtBo_Dev_DescCompras.Location = New System.Drawing.Point(431, 108)
        Me.TtBo_Dev_DescCompras.Name = "TtBo_Dev_DescCompras"
        Me.TtBo_Dev_DescCompras.Size = New System.Drawing.Size(155, 20)
        Me.TtBo_Dev_DescCompras.TabIndex = 16
        '
        'TtBo_Dev_NombCompras
        '
        Me.TtBo_Dev_NombCompras.Location = New System.Drawing.Point(431, 81)
        Me.TtBo_Dev_NombCompras.Name = "TtBo_Dev_NombCompras"
        Me.TtBo_Dev_NombCompras.Size = New System.Drawing.Size(155, 20)
        Me.TtBo_Dev_NombCompras.TabIndex = 15
        '
        'TtBo_Dev_IdCompras
        '
        Me.TtBo_Dev_IdCompras.Location = New System.Drawing.Point(431, 54)
        Me.TtBo_Dev_IdCompras.Name = "TtBo_Dev_IdCompras"
        Me.TtBo_Dev_IdCompras.Size = New System.Drawing.Size(155, 20)
        Me.TtBo_Dev_IdCompras.TabIndex = 14
        '
        'Lab_Dev_FechaCompras
        '
        Me.Lab_Dev_FechaCompras.AutoSize = True
        Me.Lab_Dev_FechaCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Dev_FechaCompras.Location = New System.Drawing.Point(283, 143)
        Me.Lab_Dev_FechaCompras.Name = "Lab_Dev_FechaCompras"
        Me.Lab_Dev_FechaCompras.Size = New System.Drawing.Size(131, 16)
        Me.Lab_Dev_FechaCompras.TabIndex = 13
        Me.Lab_Dev_FechaCompras.Text = "Fecha de la compra:"
        '
        'Lab_Dev_NombCompras
        '
        Me.Lab_Dev_NombCompras.AutoSize = True
        Me.Lab_Dev_NombCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Dev_NombCompras.Location = New System.Drawing.Point(283, 81)
        Me.Lab_Dev_NombCompras.Name = "Lab_Dev_NombCompras"
        Me.Lab_Dev_NombCompras.Size = New System.Drawing.Size(142, 16)
        Me.Lab_Dev_NombCompras.TabIndex = 12
        Me.Lab_Dev_NombCompras.Text = "Nombre de la compra:"
        '
        'Lab_Dev_IdCompras
        '
        Me.Lab_Dev_IdCompras.AutoSize = True
        Me.Lab_Dev_IdCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Dev_IdCompras.Location = New System.Drawing.Point(283, 54)
        Me.Lab_Dev_IdCompras.Name = "Lab_Dev_IdCompras"
        Me.Lab_Dev_IdCompras.Size = New System.Drawing.Size(104, 16)
        Me.Lab_Dev_IdCompras.TabIndex = 11
        Me.Lab_Dev_IdCompras.Text = "Id de la compra:"
        '
        'Form_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tab_Ctr_Compra)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.MenuS_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_Compra.ResumeLayout(False)
        Me.Alta_Compra.ResumeLayout(False)
        Me.Alta_Compra.PerformLayout()
        Me.Devoluciones_Compra.ResumeLayout(False)
        Me.Devoluciones_Compra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_atras As Button
    Friend WithEvents MenuS_Principal As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tab_Ctr_Compra As TabControl
    Friend WithEvents Alta_Compra As TabPage
    Friend WithEvents Devoluciones_Compra As TabPage
    Friend WithEvents ClientesYMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaducosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TtBo_Alta_DescCompras As TextBox
    Friend WithEvents TtBo_Alta_NombCompras As TextBox
    Friend WithEvents TtBo_Alta_IdCompras As TextBox
    Friend WithEvents Lab_FechaCompras As Label
    Friend WithEvents Lab_Alta_NombCompras As Label
    Friend WithEvents Lab_Alta_IdCompras As Label
    Friend WithEvents DaTiPi_Alta_FechaCompras As DateTimePicker
    Friend WithEvents Lab_Alta_DescCompras As Label
    Friend WithEvents Btn_Alta_GuardarCompras As Button
    Friend WithEvents Btn_Alta_LimpiarCompras As Button
    Friend WithEvents Btn_Dev_LimpiarCompras As Button
    Friend WithEvents Btn_Dev_GuardarCompras As Button
    Friend WithEvents DaTiPi_Dev_FechaCompras As DateTimePicker
    Friend WithEvents Lab_Dev_DescCompras As Label
    Friend WithEvents TtBo_Dev_DescCompras As TextBox
    Friend WithEvents TtBo_Dev_NombCompras As TextBox
    Friend WithEvents TtBo_Dev_IdCompras As TextBox
    Friend WithEvents Lab_Dev_FechaCompras As Label
    Friend WithEvents Lab_Dev_NombCompras As Label
    Friend WithEvents Lab_Dev_IdCompras As Label
End Class
