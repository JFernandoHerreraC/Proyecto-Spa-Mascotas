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
        Me.Consulta_Servicio = New System.Windows.Forms.TabPage()
        Me.Cambio_Servicio = New System.Windows.Forms.TabPage()
        Me.Baja_Servicio = New System.Windows.Forms.TabPage()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DVG_ID_Serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Nom_Serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Precio_Serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Descrip_Serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_Servicio.SuspendLayout()
        Me.Alta_Servicio.SuspendLayout()
        Me.Consulta_Servicio.SuspendLayout()
        Me.Cambio_Servicio.SuspendLayout()
        Me.Baja_Servicio.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Consulta_Servicio)
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Cambio_Servicio)
        Me.Tab_Ctr_Servicio.Controls.Add(Me.Baja_Servicio)
        Me.Tab_Ctr_Servicio.Location = New System.Drawing.Point(12, 56)
        Me.Tab_Ctr_Servicio.Name = "Tab_Ctr_Servicio"
        Me.Tab_Ctr_Servicio.SelectedIndex = 0
        Me.Tab_Ctr_Servicio.Size = New System.Drawing.Size(776, 382)
        Me.Tab_Ctr_Servicio.TabIndex = 3
        '
        'Alta_Servicio
        '
        Me.Alta_Servicio.Controls.Add(Me.Button2)
        Me.Alta_Servicio.Controls.Add(Me.Button1)
        Me.Alta_Servicio.Controls.Add(Me.MaskedTextBox1)
        Me.Alta_Servicio.Controls.Add(Me.TextBox2)
        Me.Alta_Servicio.Controls.Add(Me.TextBox1)
        Me.Alta_Servicio.Controls.Add(Me.Label3)
        Me.Alta_Servicio.Controls.Add(Me.Label2)
        Me.Alta_Servicio.Controls.Add(Me.Label1)
        Me.Alta_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Alta_Servicio.Name = "Alta_Servicio"
        Me.Alta_Servicio.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Alta_Servicio.TabIndex = 0
        Me.Alta_Servicio.Text = "Altas de Servicio"
        Me.Alta_Servicio.UseVisualStyleBackColor = True
        '
        'Consulta_Servicio
        '
        Me.Consulta_Servicio.Controls.Add(Me.Button4)
        Me.Consulta_Servicio.Controls.Add(Me.DataGridView1)
        Me.Consulta_Servicio.Controls.Add(Me.Button3)
        Me.Consulta_Servicio.Controls.Add(Me.TextBox3)
        Me.Consulta_Servicio.Controls.Add(Me.Label4)
        Me.Consulta_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Consulta_Servicio.Name = "Consulta_Servicio"
        Me.Consulta_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Consulta_Servicio.TabIndex = 2
        Me.Consulta_Servicio.Text = "Consulta de Servicios"
        Me.Consulta_Servicio.UseVisualStyleBackColor = True
        '
        'Cambio_Servicio
        '
        Me.Cambio_Servicio.Controls.Add(Me.Button5)
        Me.Cambio_Servicio.Controls.Add(Me.Button6)
        Me.Cambio_Servicio.Controls.Add(Me.MaskedTextBox2)
        Me.Cambio_Servicio.Controls.Add(Me.TextBox4)
        Me.Cambio_Servicio.Controls.Add(Me.TextBox5)
        Me.Cambio_Servicio.Controls.Add(Me.Label5)
        Me.Cambio_Servicio.Controls.Add(Me.Label6)
        Me.Cambio_Servicio.Controls.Add(Me.Label7)
        Me.Cambio_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Cambio_Servicio.Name = "Cambio_Servicio"
        Me.Cambio_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Cambio_Servicio.TabIndex = 3
        Me.Cambio_Servicio.Text = "Cambios en el servicio"
        Me.Cambio_Servicio.UseVisualStyleBackColor = True
        '
        'Baja_Servicio
        '
        Me.Baja_Servicio.Controls.Add(Me.Button7)
        Me.Baja_Servicio.Controls.Add(Me.Button8)
        Me.Baja_Servicio.Controls.Add(Me.MaskedTextBox3)
        Me.Baja_Servicio.Controls.Add(Me.TextBox6)
        Me.Baja_Servicio.Controls.Add(Me.TextBox7)
        Me.Baja_Servicio.Controls.Add(Me.Label8)
        Me.Baja_Servicio.Controls.Add(Me.Label9)
        Me.Baja_Servicio.Controls.Add(Me.Label10)
        Me.Baja_Servicio.Controls.Add(Me.TextBox33)
        Me.Baja_Servicio.Controls.Add(Me.TextBox34)
        Me.Baja_Servicio.Controls.Add(Me.Label40)
        Me.Baja_Servicio.Controls.Add(Me.Label41)
        Me.Baja_Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Baja_Servicio.Name = "Baja_Servicio"
        Me.Baja_Servicio.Padding = New System.Windows.Forms.Padding(3)
        Me.Baja_Servicio.Size = New System.Drawing.Size(768, 356)
        Me.Baja_Servicio.TabIndex = 1
        Me.Baja_Servicio.Text = "Bajas de Servicio"
        Me.Baja_Servicio.UseVisualStyleBackColor = True
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(193, 387)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(164, 20)
        Me.TextBox33.TabIndex = 87
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(193, 357)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(164, 20)
        Me.TextBox34.TabIndex = 86
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label40.Location = New System.Drawing.Point(23, 388)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(80, 17)
        Me.Label40.TabIndex = 80
        Me.Label40.Text = "Teléfono 2:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label41.Location = New System.Drawing.Point(23, 358)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 17)
        Me.Label41.TabIndex = 79
        Me.Label41.Text = "Teléfono 1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(206, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del servicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(206, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio del servicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(206, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descrip del servicio:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(360, 76)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(360, 137)
        Me.TextBox2.MaxLength = 120
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(179, 20)
        Me.TextBox2.TabIndex = 4
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(360, 109)
        Me.MaskedTextBox1.Mask = "99999.99"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(179, 20)
        Me.MaskedTextBox1.TabIndex = 5
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(360, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(464, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(368, 39)
        Me.TextBox3.MaxLength = 50
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(167, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(214, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre del servicio:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(290, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DVG_ID_Serv, Me.DVG_Nom_Serv, Me.DVG_Precio_Serv, Me.DVG_Descrip_Serv})
        Me.DataGridView1.Location = New System.Drawing.Point(147, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'DVG_ID_Serv
        '
        Me.DVG_ID_Serv.HeaderText = "ID"
        Me.DVG_ID_Serv.MaxInputLength = 3
        Me.DVG_ID_Serv.Name = "DVG_ID_Serv"
        '
        'DVG_Nom_Serv
        '
        Me.DVG_Nom_Serv.HeaderText = "Nombre"
        Me.DVG_Nom_Serv.MaxInputLength = 50
        Me.DVG_Nom_Serv.Name = "DVG_Nom_Serv"
        '
        'DVG_Precio_Serv
        '
        Me.DVG_Precio_Serv.HeaderText = "Precio"
        Me.DVG_Precio_Serv.MaxInputLength = 5
        Me.DVG_Precio_Serv.Name = "DVG_Precio_Serv"
        '
        'DVG_Descrip_Serv
        '
        Me.DVG_Descrip_Serv.HeaderText = "Descripción"
        Me.DVG_Descrip_Serv.MaxInputLength = 120
        Me.DVG_Descrip_Serv.Name = "DVG_Descrip_Serv"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button4.Location = New System.Drawing.Point(416, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Buscar todos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button5.Location = New System.Drawing.Point(479, 151)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Limpiar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button6.Location = New System.Drawing.Point(375, 151)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Guardar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(375, 83)
        Me.MaskedTextBox2.Mask = "99999.99"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.ReadOnly = True
        Me.MaskedTextBox2.Size = New System.Drawing.Size(179, 20)
        Me.MaskedTextBox2.TabIndex = 13
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(375, 111)
        Me.TextBox4.MaxLength = 120
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(179, 20)
        Me.TextBox4.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(375, 50)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(179, 20)
        Me.TextBox5.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(221, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Descrip del servicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(221, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Precio del servicio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(221, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Nombre del servicio:"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button7.Location = New System.Drawing.Point(460, 156)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 95
        Me.Button7.Text = "Limpiar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button8.Location = New System.Drawing.Point(356, 156)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 23)
        Me.Button8.TabIndex = 94
        Me.Button8.Text = "Buscar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Enabled = False
        Me.MaskedTextBox3.Location = New System.Drawing.Point(356, 88)
        Me.MaskedTextBox3.Mask = "99999.99"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(179, 20)
        Me.MaskedTextBox3.TabIndex = 93
        Me.MaskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(356, 116)
        Me.TextBox6.MaxLength = 120
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(179, 20)
        Me.TextBox6.TabIndex = 92
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(356, 55)
        Me.TextBox7.MaxLength = 50
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(179, 20)
        Me.TextBox7.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(202, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 17)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Descrip del servicio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(202, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 17)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Precio del servicio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(202, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 17)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Nombre del servicio:"
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
        Me.Alta_Servicio.ResumeLayout(False)
        Me.Alta_Servicio.PerformLayout()
        Me.Consulta_Servicio.ResumeLayout(False)
        Me.Consulta_Servicio.PerformLayout()
        Me.Cambio_Servicio.ResumeLayout(False)
        Me.Cambio_Servicio.PerformLayout()
        Me.Baja_Servicio.ResumeLayout(False)
        Me.Baja_Servicio.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DVG_ID_Serv As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Nom_Serv As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Precio_Serv As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Descrip_Serv As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
