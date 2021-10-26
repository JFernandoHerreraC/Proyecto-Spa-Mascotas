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
        Me.Alta_CorteCajaFinal = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Consulta_CorteCajaHist = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGV_ID_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_FECHA_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_HORA_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_DnInic_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_SalCaja_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TOTAL_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NOMBCAJERO_CorCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuS_Principal.SuspendLayout()
        Me.Tab_Ctr_CorteCaja.SuspendLayout()
        Me.Alta_CorteCajaFinal.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Consulta_CorteCajaHist.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Tab_Ctr_CorteCaja.Controls.Add(Me.Alta_CorteCajaFinal)
        Me.Tab_Ctr_CorteCaja.Controls.Add(Me.Consulta_CorteCajaHist)
        Me.Tab_Ctr_CorteCaja.Location = New System.Drawing.Point(12, 61)
        Me.Tab_Ctr_CorteCaja.Name = "Tab_Ctr_CorteCaja"
        Me.Tab_Ctr_CorteCaja.SelectedIndex = 0
        Me.Tab_Ctr_CorteCaja.Size = New System.Drawing.Size(776, 377)
        Me.Tab_Ctr_CorteCaja.TabIndex = 2
        '
        'Alta_CorteCajaFinal
        '
        Me.Alta_CorteCajaFinal.Controls.Add(Me.GroupBox2)
        Me.Alta_CorteCajaFinal.Controls.Add(Me.GroupBox1)
        Me.Alta_CorteCajaFinal.Controls.Add(Me.Label1)
        Me.Alta_CorteCajaFinal.Location = New System.Drawing.Point(4, 22)
        Me.Alta_CorteCajaFinal.Name = "Alta_CorteCajaFinal"
        Me.Alta_CorteCajaFinal.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_CorteCajaFinal.Size = New System.Drawing.Size(768, 351)
        Me.Alta_CorteCajaFinal.TabIndex = 1
        Me.Alta_CorteCajaFinal.Text = "Carte de caja final"
        Me.Alta_CorteCajaFinal.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 159)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos para el corte de caja"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(258, 99)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(161, 20)
        Me.TextBox7.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Nombre del cajero"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(258, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "¿Con cuanto inicio su jornada de cobro?"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Corte de caja"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "¿Hubo alguna salida de caja?"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(258, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(161, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 144)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del corte caja"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(112, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Hora:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(112, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Fecha:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Hora:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Fecha:"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(389, 72)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(137, 20)
        Me.TextBox6.TabIndex = 13
        Me.TextBox6.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(279, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(389, 98)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Guardar corte de caja"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(389, 46)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(137, 20)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(389, 20)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 20)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(115, 76)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Subtotal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(279, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Salida de dinero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dinero inicial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corte de caja"
        '
        'Consulta_CorteCajaHist
        '
        Me.Consulta_CorteCajaHist.Controls.Add(Me.Button4)
        Me.Consulta_CorteCajaHist.Controls.Add(Me.DataGridView1)
        Me.Consulta_CorteCajaHist.Controls.Add(Me.DateTimePicker1)
        Me.Consulta_CorteCajaHist.Controls.Add(Me.Label8)
        Me.Consulta_CorteCajaHist.Location = New System.Drawing.Point(4, 22)
        Me.Consulta_CorteCajaHist.Name = "Consulta_CorteCajaHist"
        Me.Consulta_CorteCajaHist.Size = New System.Drawing.Size(768, 351)
        Me.Consulta_CorteCajaHist.TabIndex = 2
        Me.Consulta_CorteCajaHist.Text = "Historial de cortes de caja"
        Me.Consulta_CorteCajaHist.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(305, 77)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(166, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_ID_CorCaja, Me.DGV_FECHA_CorCaja, Me.DGV_HORA_CorCaja, Me.DGV_DnInic_CorCaja, Me.DGV_SalCaja_CorCaja, Me.DGV_TOTAL_CorCaja, Me.DGV_NOMBCAJERO_CorCaja})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(740, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(373, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(123, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Seleccione la fecha del corte de caja:"
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
        'DGV_ID_CorCaja
        '
        Me.DGV_ID_CorCaja.HeaderText = "ID"
        Me.DGV_ID_CorCaja.MaxInputLength = 3
        Me.DGV_ID_CorCaja.Name = "DGV_ID_CorCaja"
        '
        'DGV_FECHA_CorCaja
        '
        Me.DGV_FECHA_CorCaja.HeaderText = "FECHA"
        Me.DGV_FECHA_CorCaja.MaxInputLength = 10
        Me.DGV_FECHA_CorCaja.Name = "DGV_FECHA_CorCaja"
        '
        'DGV_HORA_CorCaja
        '
        Me.DGV_HORA_CorCaja.HeaderText = "HORA"
        Me.DGV_HORA_CorCaja.MaxInputLength = 8
        Me.DGV_HORA_CorCaja.Name = "DGV_HORA_CorCaja"
        '
        'DGV_DnInic_CorCaja
        '
        Me.DGV_DnInic_CorCaja.HeaderText = "DINERO INICIAL"
        Me.DGV_DnInic_CorCaja.MaxInputLength = 5
        Me.DGV_DnInic_CorCaja.Name = "DGV_DnInic_CorCaja"
        '
        'DGV_SalCaja_CorCaja
        '
        Me.DGV_SalCaja_CorCaja.HeaderText = "SALIDAS DE CAJA"
        Me.DGV_SalCaja_CorCaja.MaxInputLength = 5
        Me.DGV_SalCaja_CorCaja.Name = "DGV_SalCaja_CorCaja"
        '
        'DGV_TOTAL_CorCaja
        '
        Me.DGV_TOTAL_CorCaja.HeaderText = "TOTAL"
        Me.DGV_TOTAL_CorCaja.MaxInputLength = 6
        Me.DGV_TOTAL_CorCaja.Name = "DGV_TOTAL_CorCaja"
        '
        'DGV_NOMBCAJERO_CorCaja
        '
        Me.DGV_NOMBCAJERO_CorCaja.HeaderText = "NOMBRE DEL CAJERO"
        Me.DGV_NOMBCAJERO_CorCaja.Name = "DGV_NOMBCAJERO_CorCaja"
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de caja"
        Me.MenuS_Principal.ResumeLayout(False)
        Me.MenuS_Principal.PerformLayout()
        Me.Tab_Ctr_CorteCaja.ResumeLayout(False)
        Me.Alta_CorteCajaFinal.ResumeLayout(False)
        Me.Alta_CorteCajaFinal.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Consulta_CorteCajaHist.ResumeLayout(False)
        Me.Consulta_CorteCajaHist.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Alta_CorteCajaFinal As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Consulta_CorteCajaHist As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DGV_ID_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_FECHA_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_HORA_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_DnInic_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_SalCaja_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_TOTAL_CorCaja As DataGridViewTextBoxColumn
    Friend WithEvents DGV_NOMBCAJERO_CorCaja As DataGridViewTextBoxColumn
End Class
