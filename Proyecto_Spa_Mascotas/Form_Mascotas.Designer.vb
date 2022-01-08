<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Mascotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Mascotas))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Alta_Mascotas = New System.Windows.Forms.TabPage()
        Me.Btn_Alta_ImgMascotas = New System.Windows.Forms.Button()
        Me.Btn_Alta_LimpiarMascotas = New System.Windows.Forms.Button()
        Me.Btn_Alta_GuardarMascotas = New System.Windows.Forms.Button()
        Me.TtBo_Alta_ObservMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_ObservMascotas = New System.Windows.Forms.Label()
        Me.DaTiPi_Alta_FechaNacMascotas = New System.Windows.Forms.DateTimePicker()
        Me.Lab_Alta_FechaNacMascotas = New System.Windows.Forms.Label()
        Me.CoBo_Alta_SexoMascotas = New System.Windows.Forms.ComboBox()
        Me.Lab_Alta_SexoMascotas = New System.Windows.Forms.Label()
        Me.CoBo_Alta_FamiliaMascotas = New System.Windows.Forms.ComboBox()
        Me.Lab_Alta_FamiliaMascotas = New System.Windows.Forms.Label()
        Me.TtBo_Alta_RazaMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_RazaMascotas = New System.Windows.Forms.Label()
        Me.TtBo_Alta_ColorMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_ColorMascotas = New System.Windows.Forms.Label()
        Me.TtBo_Alta_NombMascotas = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_DuenoMascotas = New System.Windows.Forms.TextBox()
        Me.TtBo_Alta_IdMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Alta_DuenoMascotas = New System.Windows.Forms.Label()
        Me.Lab_Alta_IdMascotas = New System.Windows.Forms.Label()
        Me.Lab_Alta_NombMascotas = New System.Windows.Forms.Label()
        Me.PiBo_Alta_ImgMascotas = New System.Windows.Forms.PictureBox()
        Me.Consulta_Mascotas = New System.Windows.Forms.TabPage()
        Me.DGV_ListaMascotas = New System.Windows.Forms.DataGridView()
        Me.Id_mascota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dueño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Mascota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Familia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrBo_Alta_BusMascotas = New System.Windows.Forms.GroupBox()
        Me.Btn_Consulta_BuscarIdMascotas = New System.Windows.Forms.Button()
        Me.Btn_Consulta_BuscarTodoMascotas = New System.Windows.Forms.Button()
        Me.TtBo_Consulta_IdMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Consulta_IdMascotas = New System.Windows.Forms.Label()
        Me.Cambios_Mascotas = New System.Windows.Forms.TabPage()
        Me.Btn_Cambios_ImgMascotas = New System.Windows.Forms.Button()
        Me.Btn_Cambios_LimpiarMascotas = New System.Windows.Forms.Button()
        Me.Btn_Cambios_GuardarMascotas = New System.Windows.Forms.Button()
        Me.TtBo_Cambios_ObservMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_ObservMascotas = New System.Windows.Forms.Label()
        Me.DaTiPi_Cambios_FechaNacMascotas = New System.Windows.Forms.DateTimePicker()
        Me.Lab_Cambios_FechNacMascotas = New System.Windows.Forms.Label()
        Me.CoBo_Cambios_SexoMascotas = New System.Windows.Forms.ComboBox()
        Me.Lab_Cambios_SexoMascotas = New System.Windows.Forms.Label()
        Me.CoBo_Cambios_FamiliaMascotas = New System.Windows.Forms.ComboBox()
        Me.Lab_Cambios_FamiliaMascotas = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_RazaMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_RazaMascotas = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_ColorMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_ColorMascotas = New System.Windows.Forms.Label()
        Me.TtBo_Cambios_NombMascotas = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_DuenoMascotas = New System.Windows.Forms.TextBox()
        Me.TtBo_Cambios_IdMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Cambios_DuenoMascotas = New System.Windows.Forms.Label()
        Me.Lab_Cambios_IdMascotas = New System.Windows.Forms.Label()
        Me.Lab_Cambios_NombMascotas = New System.Windows.Forms.Label()
        Me.PiBo_Cambios_ImgMascotas = New System.Windows.Forms.PictureBox()
        Me.Baja_Mascotas = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DGV_Baja_ListaMascotas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrBo_Bajas_BuscarMascotas = New System.Windows.Forms.GroupBox()
        Me.Btn_Baja_BuscarMascotas = New System.Windows.Forms.Button()
        Me.TtBo_Baja_BuscarMascotas = New System.Windows.Forms.TextBox()
        Me.Lab_Baja_IdMascotas = New System.Windows.Forms.Label()
        Me.Btn_atras = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Alta_Mascotas.SuspendLayout()
        CType(Me.PiBo_Alta_ImgMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Consulta_Mascotas.SuspendLayout()
        CType(Me.DGV_ListaMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBo_Alta_BusMascotas.SuspendLayout()
        Me.Cambios_Mascotas.SuspendLayout()
        CType(Me.PiBo_Cambios_ImgMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Baja_Mascotas.SuspendLayout()
        CType(Me.DGV_Baja_ListaMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBo_Bajas_BuscarMascotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Alta_Mascotas)
        Me.TabControl1.Controls.Add(Me.Consulta_Mascotas)
        Me.TabControl1.Controls.Add(Me.Cambios_Mascotas)
        Me.TabControl1.Controls.Add(Me.Baja_Mascotas)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(762, 399)
        Me.TabControl1.TabIndex = 0
        '
        'Alta_Mascotas
        '
        Me.Alta_Mascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Alta_Mascotas.Controls.Add(Me.Btn_Alta_ImgMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Btn_Alta_LimpiarMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Btn_Alta_GuardarMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.TtBo_Alta_ObservMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_ObservMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.DaTiPi_Alta_FechaNacMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_FechaNacMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.CoBo_Alta_SexoMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_SexoMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.CoBo_Alta_FamiliaMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_FamiliaMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.TtBo_Alta_RazaMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_RazaMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.TtBo_Alta_ColorMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_ColorMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.TtBo_Alta_NombMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.TtBo_Alta_DuenoMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.TtBo_Alta_IdMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_DuenoMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_IdMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.Lab_Alta_NombMascotas)
        Me.Alta_Mascotas.Controls.Add(Me.PiBo_Alta_ImgMascotas)
        Me.Alta_Mascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Alta_Mascotas.Location = New System.Drawing.Point(4, 25)
        Me.Alta_Mascotas.Name = "Alta_Mascotas"
        Me.Alta_Mascotas.Padding = New System.Windows.Forms.Padding(3)
        Me.Alta_Mascotas.Size = New System.Drawing.Size(754, 370)
        Me.Alta_Mascotas.TabIndex = 0
        Me.Alta_Mascotas.Text = "Alta de Mascotas"
        '
        'Btn_Alta_ImgMascotas
        '
        Me.Btn_Alta_ImgMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Alta_ImgMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Alta_ImgMascotas.Location = New System.Drawing.Point(53, 244)
        Me.Btn_Alta_ImgMascotas.Name = "Btn_Alta_ImgMascotas"
        Me.Btn_Alta_ImgMascotas.Size = New System.Drawing.Size(134, 25)
        Me.Btn_Alta_ImgMascotas.TabIndex = 33
        Me.Btn_Alta_ImgMascotas.Text = "Subir Imagen"
        Me.Btn_Alta_ImgMascotas.UseVisualStyleBackColor = False
        '
        'Btn_Alta_LimpiarMascotas
        '
        Me.Btn_Alta_LimpiarMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Alta_LimpiarMascotas.Location = New System.Drawing.Point(391, 321)
        Me.Btn_Alta_LimpiarMascotas.Name = "Btn_Alta_LimpiarMascotas"
        Me.Btn_Alta_LimpiarMascotas.Size = New System.Drawing.Size(75, 25)
        Me.Btn_Alta_LimpiarMascotas.TabIndex = 32
        Me.Btn_Alta_LimpiarMascotas.Text = "Limpiar"
        Me.Btn_Alta_LimpiarMascotas.UseVisualStyleBackColor = False
        '
        'Btn_Alta_GuardarMascotas
        '
        Me.Btn_Alta_GuardarMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Alta_GuardarMascotas.Location = New System.Drawing.Point(476, 321)
        Me.Btn_Alta_GuardarMascotas.Name = "Btn_Alta_GuardarMascotas"
        Me.Btn_Alta_GuardarMascotas.Size = New System.Drawing.Size(134, 25)
        Me.Btn_Alta_GuardarMascotas.TabIndex = 31
        Me.Btn_Alta_GuardarMascotas.Text = "Guardar"
        Me.Btn_Alta_GuardarMascotas.UseVisualStyleBackColor = False
        '
        'TtBo_Alta_ObservMascotas
        '
        Me.TtBo_Alta_ObservMascotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TtBo_Alta_ObservMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TtBo_Alta_ObservMascotas.Location = New System.Drawing.Point(391, 293)
        Me.TtBo_Alta_ObservMascotas.Name = "TtBo_Alta_ObservMascotas"
        Me.TtBo_Alta_ObservMascotas.Size = New System.Drawing.Size(219, 22)
        Me.TtBo_Alta_ObservMascotas.TabIndex = 30
        '
        'Lab_Alta_ObservMascotas
        '
        Me.Lab_Alta_ObservMascotas.AutoSize = True
        Me.Lab_Alta_ObservMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_ObservMascotas.Location = New System.Drawing.Point(239, 298)
        Me.Lab_Alta_ObservMascotas.Name = "Lab_Alta_ObservMascotas"
        Me.Lab_Alta_ObservMascotas.Size = New System.Drawing.Size(107, 17)
        Me.Lab_Alta_ObservMascotas.TabIndex = 29
        Me.Lab_Alta_ObservMascotas.Text = "Observaciones:"
        '
        'DaTiPi_Alta_FechaNacMascotas
        '
        Me.DaTiPi_Alta_FechaNacMascotas.Location = New System.Drawing.Point(391, 253)
        Me.DaTiPi_Alta_FechaNacMascotas.Name = "DaTiPi_Alta_FechaNacMascotas"
        Me.DaTiPi_Alta_FechaNacMascotas.Size = New System.Drawing.Size(219, 23)
        Me.DaTiPi_Alta_FechaNacMascotas.TabIndex = 28
        Me.DaTiPi_Alta_FechaNacMascotas.TabStop = False
        '
        'Lab_Alta_FechaNacMascotas
        '
        Me.Lab_Alta_FechaNacMascotas.AutoSize = True
        Me.Lab_Alta_FechaNacMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_FechaNacMascotas.Location = New System.Drawing.Point(239, 253)
        Me.Lab_Alta_FechaNacMascotas.Name = "Lab_Alta_FechaNacMascotas"
        Me.Lab_Alta_FechaNacMascotas.Size = New System.Drawing.Size(143, 17)
        Me.Lab_Alta_FechaNacMascotas.TabIndex = 27
        Me.Lab_Alta_FechaNacMascotas.Text = "Fecha de nacimiento:"
        '
        'CoBo_Alta_SexoMascotas
        '
        Me.CoBo_Alta_SexoMascotas.FormattingEnabled = True
        Me.CoBo_Alta_SexoMascotas.Items.AddRange(New Object() {"Hembra", "Macho", "Sin especificaciones"})
        Me.CoBo_Alta_SexoMascotas.Location = New System.Drawing.Point(553, 214)
        Me.CoBo_Alta_SexoMascotas.Name = "CoBo_Alta_SexoMascotas"
        Me.CoBo_Alta_SexoMascotas.Size = New System.Drawing.Size(57, 24)
        Me.CoBo_Alta_SexoMascotas.TabIndex = 26
        '
        'Lab_Alta_SexoMascotas
        '
        Me.Lab_Alta_SexoMascotas.AutoSize = True
        Me.Lab_Alta_SexoMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_SexoMascotas.Location = New System.Drawing.Point(504, 217)
        Me.Lab_Alta_SexoMascotas.Name = "Lab_Alta_SexoMascotas"
        Me.Lab_Alta_SexoMascotas.Size = New System.Drawing.Size(43, 17)
        Me.Lab_Alta_SexoMascotas.TabIndex = 25
        Me.Lab_Alta_SexoMascotas.Text = "Sexo:"
        '
        'CoBo_Alta_FamiliaMascotas
        '
        Me.CoBo_Alta_FamiliaMascotas.FormattingEnabled = True
        Me.CoBo_Alta_FamiliaMascotas.Items.AddRange(New Object() {"Caninos", "Felinos", "Peces", "Aves", "Insectos", "Arañas y Alacranes", "Ranas", "Otros"})
        Me.CoBo_Alta_FamiliaMascotas.Location = New System.Drawing.Point(434, 214)
        Me.CoBo_Alta_FamiliaMascotas.Name = "CoBo_Alta_FamiliaMascotas"
        Me.CoBo_Alta_FamiliaMascotas.Size = New System.Drawing.Size(57, 24)
        Me.CoBo_Alta_FamiliaMascotas.TabIndex = 24
        '
        'Lab_Alta_FamiliaMascotas
        '
        Me.Lab_Alta_FamiliaMascotas.AutoSize = True
        Me.Lab_Alta_FamiliaMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_FamiliaMascotas.Location = New System.Drawing.Point(372, 217)
        Me.Lab_Alta_FamiliaMascotas.Name = "Lab_Alta_FamiliaMascotas"
        Me.Lab_Alta_FamiliaMascotas.Size = New System.Drawing.Size(56, 17)
        Me.Lab_Alta_FamiliaMascotas.TabIndex = 23
        Me.Lab_Alta_FamiliaMascotas.Text = "Familia:"
        '
        'TtBo_Alta_RazaMascotas
        '
        Me.TtBo_Alta_RazaMascotas.Location = New System.Drawing.Point(380, 177)
        Me.TtBo_Alta_RazaMascotas.Name = "TtBo_Alta_RazaMascotas"
        Me.TtBo_Alta_RazaMascotas.Size = New System.Drawing.Size(230, 23)
        Me.TtBo_Alta_RazaMascotas.TabIndex = 22
        '
        'Lab_Alta_RazaMascotas
        '
        Me.Lab_Alta_RazaMascotas.AutoSize = True
        Me.Lab_Alta_RazaMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_RazaMascotas.Location = New System.Drawing.Point(239, 180)
        Me.Lab_Alta_RazaMascotas.Name = "Lab_Alta_RazaMascotas"
        Me.Lab_Alta_RazaMascotas.Size = New System.Drawing.Size(45, 17)
        Me.Lab_Alta_RazaMascotas.TabIndex = 21
        Me.Lab_Alta_RazaMascotas.Text = "Raza:"
        '
        'TtBo_Alta_ColorMascotas
        '
        Me.TtBo_Alta_ColorMascotas.Location = New System.Drawing.Point(380, 139)
        Me.TtBo_Alta_ColorMascotas.Name = "TtBo_Alta_ColorMascotas"
        Me.TtBo_Alta_ColorMascotas.Size = New System.Drawing.Size(230, 23)
        Me.TtBo_Alta_ColorMascotas.TabIndex = 20
        '
        'Lab_Alta_ColorMascotas
        '
        Me.Lab_Alta_ColorMascotas.AutoSize = True
        Me.Lab_Alta_ColorMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_ColorMascotas.Location = New System.Drawing.Point(221, 139)
        Me.Lab_Alta_ColorMascotas.Name = "Lab_Alta_ColorMascotas"
        Me.Lab_Alta_ColorMascotas.Size = New System.Drawing.Size(137, 17)
        Me.Lab_Alta_ColorMascotas.TabIndex = 18
        Me.Lab_Alta_ColorMascotas.Text = "Color de la mascota:"
        '
        'TtBo_Alta_NombMascotas
        '
        Me.TtBo_Alta_NombMascotas.Location = New System.Drawing.Point(380, 98)
        Me.TtBo_Alta_NombMascotas.Name = "TtBo_Alta_NombMascotas"
        Me.TtBo_Alta_NombMascotas.Size = New System.Drawing.Size(230, 23)
        Me.TtBo_Alta_NombMascotas.TabIndex = 15
        '
        'TtBo_Alta_DuenoMascotas
        '
        Me.TtBo_Alta_DuenoMascotas.Location = New System.Drawing.Point(380, 64)
        Me.TtBo_Alta_DuenoMascotas.Name = "TtBo_Alta_DuenoMascotas"
        Me.TtBo_Alta_DuenoMascotas.Size = New System.Drawing.Size(230, 23)
        Me.TtBo_Alta_DuenoMascotas.TabIndex = 13
        '
        'TtBo_Alta_IdMascotas
        '
        Me.TtBo_Alta_IdMascotas.Location = New System.Drawing.Point(380, 32)
        Me.TtBo_Alta_IdMascotas.Name = "TtBo_Alta_IdMascotas"
        Me.TtBo_Alta_IdMascotas.Size = New System.Drawing.Size(59, 23)
        Me.TtBo_Alta_IdMascotas.TabIndex = 12
        '
        'Lab_Alta_DuenoMascotas
        '
        Me.Lab_Alta_DuenoMascotas.AutoSize = True
        Me.Lab_Alta_DuenoMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_DuenoMascotas.Location = New System.Drawing.Point(239, 67)
        Me.Lab_Alta_DuenoMascotas.Name = "Lab_Alta_DuenoMascotas"
        Me.Lab_Alta_DuenoMascotas.Size = New System.Drawing.Size(54, 17)
        Me.Lab_Alta_DuenoMascotas.TabIndex = 11
        Me.Lab_Alta_DuenoMascotas.Text = "Dueño:"
        '
        'Lab_Alta_IdMascotas
        '
        Me.Lab_Alta_IdMascotas.AutoSize = True
        Me.Lab_Alta_IdMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_IdMascotas.Location = New System.Drawing.Point(239, 32)
        Me.Lab_Alta_IdMascotas.Name = "Lab_Alta_IdMascotas"
        Me.Lab_Alta_IdMascotas.Size = New System.Drawing.Size(80, 17)
        Me.Lab_Alta_IdMascotas.TabIndex = 10
        Me.Lab_Alta_IdMascotas.Text = "Id Mascota:"
        '
        'Lab_Alta_NombMascotas
        '
        Me.Lab_Alta_NombMascotas.AutoSize = True
        Me.Lab_Alta_NombMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Alta_NombMascotas.Location = New System.Drawing.Point(221, 101)
        Me.Lab_Alta_NombMascotas.Name = "Lab_Alta_NombMascotas"
        Me.Lab_Alta_NombMascotas.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Alta_NombMascotas.TabIndex = 9
        Me.Lab_Alta_NombMascotas.Text = "Nombre de la mascota:"
        '
        'PiBo_Alta_ImgMascotas
        '
        Me.PiBo_Alta_ImgMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PiBo_Alta_ImgMascotas.BackgroundImage = CType(resources.GetObject("PiBo_Alta_ImgMascotas.BackgroundImage"), System.Drawing.Image)
        Me.PiBo_Alta_ImgMascotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PiBo_Alta_ImgMascotas.Location = New System.Drawing.Point(42, 77)
        Me.PiBo_Alta_ImgMascotas.Name = "PiBo_Alta_ImgMascotas"
        Me.PiBo_Alta_ImgMascotas.Size = New System.Drawing.Size(162, 154)
        Me.PiBo_Alta_ImgMascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PiBo_Alta_ImgMascotas.TabIndex = 0
        Me.PiBo_Alta_ImgMascotas.TabStop = False
        '
        'Consulta_Mascotas
        '
        Me.Consulta_Mascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Consulta_Mascotas.Controls.Add(Me.DGV_ListaMascotas)
        Me.Consulta_Mascotas.Controls.Add(Me.GrBo_Alta_BusMascotas)
        Me.Consulta_Mascotas.Location = New System.Drawing.Point(4, 25)
        Me.Consulta_Mascotas.Name = "Consulta_Mascotas"
        Me.Consulta_Mascotas.Padding = New System.Windows.Forms.Padding(3)
        Me.Consulta_Mascotas.Size = New System.Drawing.Size(754, 370)
        Me.Consulta_Mascotas.TabIndex = 1
        Me.Consulta_Mascotas.Text = "Consulta de Mascotas"
        '
        'DGV_ListaMascotas
        '
        Me.DGV_ListaMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ListaMascotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_mascota, Me.Dueño, Me.Nombre_Mascota, Me.Raza, Me.Familia, Me.Sexo, Me.Fecha_nacimiento, Me.Observaciones})
        Me.DGV_ListaMascotas.Location = New System.Drawing.Point(18, 141)
        Me.DGV_ListaMascotas.Name = "DGV_ListaMascotas"
        Me.DGV_ListaMascotas.Size = New System.Drawing.Size(733, 192)
        Me.DGV_ListaMascotas.TabIndex = 2
        '
        'Id_mascota
        '
        Me.Id_mascota.HeaderText = "Id Mascota"
        Me.Id_mascota.Name = "Id_mascota"
        '
        'Dueño
        '
        Me.Dueño.HeaderText = "Dueño"
        Me.Dueño.Name = "Dueño"
        '
        'Nombre_Mascota
        '
        Me.Nombre_Mascota.HeaderText = "Nombre Mascota"
        Me.Nombre_Mascota.Name = "Nombre_Mascota"
        '
        'Raza
        '
        Me.Raza.HeaderText = "Raza"
        Me.Raza.Name = "Raza"
        '
        'Familia
        '
        Me.Familia.HeaderText = "Familia"
        Me.Familia.Name = "Familia"
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        '
        'Fecha_nacimiento
        '
        Me.Fecha_nacimiento.HeaderText = "Fecha de nacimiento"
        Me.Fecha_nacimiento.Name = "Fecha_nacimiento"
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        '
        'GrBo_Alta_BusMascotas
        '
        Me.GrBo_Alta_BusMascotas.Controls.Add(Me.Btn_Consulta_BuscarIdMascotas)
        Me.GrBo_Alta_BusMascotas.Controls.Add(Me.Btn_Consulta_BuscarTodoMascotas)
        Me.GrBo_Alta_BusMascotas.Controls.Add(Me.TtBo_Consulta_IdMascotas)
        Me.GrBo_Alta_BusMascotas.Controls.Add(Me.Lab_Consulta_IdMascotas)
        Me.GrBo_Alta_BusMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrBo_Alta_BusMascotas.Location = New System.Drawing.Point(233, 18)
        Me.GrBo_Alta_BusMascotas.Name = "GrBo_Alta_BusMascotas"
        Me.GrBo_Alta_BusMascotas.Size = New System.Drawing.Size(335, 108)
        Me.GrBo_Alta_BusMascotas.TabIndex = 1
        Me.GrBo_Alta_BusMascotas.TabStop = False
        Me.GrBo_Alta_BusMascotas.Text = "Datos de Busqueda de Mascotas"
        '
        'Btn_Consulta_BuscarIdMascotas
        '
        Me.Btn_Consulta_BuscarIdMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Consulta_BuscarIdMascotas.Location = New System.Drawing.Point(173, 67)
        Me.Btn_Consulta_BuscarIdMascotas.Name = "Btn_Consulta_BuscarIdMascotas"
        Me.Btn_Consulta_BuscarIdMascotas.Size = New System.Drawing.Size(132, 23)
        Me.Btn_Consulta_BuscarIdMascotas.TabIndex = 3
        Me.Btn_Consulta_BuscarIdMascotas.Text = "Buscar"
        Me.Btn_Consulta_BuscarIdMascotas.UseVisualStyleBackColor = False
        '
        'Btn_Consulta_BuscarTodoMascotas
        '
        Me.Btn_Consulta_BuscarTodoMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Consulta_BuscarTodoMascotas.Location = New System.Drawing.Point(35, 67)
        Me.Btn_Consulta_BuscarTodoMascotas.Name = "Btn_Consulta_BuscarTodoMascotas"
        Me.Btn_Consulta_BuscarTodoMascotas.Size = New System.Drawing.Size(132, 23)
        Me.Btn_Consulta_BuscarTodoMascotas.TabIndex = 2
        Me.Btn_Consulta_BuscarTodoMascotas.Text = "Buscar todo"
        Me.Btn_Consulta_BuscarTodoMascotas.UseVisualStyleBackColor = False
        '
        'TtBo_Consulta_IdMascotas
        '
        Me.TtBo_Consulta_IdMascotas.Location = New System.Drawing.Point(107, 33)
        Me.TtBo_Consulta_IdMascotas.Name = "TtBo_Consulta_IdMascotas"
        Me.TtBo_Consulta_IdMascotas.Size = New System.Drawing.Size(157, 23)
        Me.TtBo_Consulta_IdMascotas.TabIndex = 1
        '
        'Lab_Consulta_IdMascotas
        '
        Me.Lab_Consulta_IdMascotas.AutoSize = True
        Me.Lab_Consulta_IdMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Consulta_IdMascotas.Location = New System.Drawing.Point(21, 39)
        Me.Lab_Consulta_IdMascotas.Name = "Lab_Consulta_IdMascotas"
        Me.Lab_Consulta_IdMascotas.Size = New System.Drawing.Size(80, 17)
        Me.Lab_Consulta_IdMascotas.TabIndex = 0
        Me.Lab_Consulta_IdMascotas.Text = "Id Mascota:"
        '
        'Cambios_Mascotas
        '
        Me.Cambios_Mascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cambios_Mascotas.Controls.Add(Me.Btn_Cambios_ImgMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Btn_Cambios_LimpiarMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Btn_Cambios_GuardarMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.TtBo_Cambios_ObservMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_ObservMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.DaTiPi_Cambios_FechaNacMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_FechNacMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.CoBo_Cambios_SexoMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_SexoMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.CoBo_Cambios_FamiliaMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_FamiliaMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.TtBo_Cambios_RazaMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_RazaMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.TtBo_Cambios_ColorMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_ColorMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.TtBo_Cambios_NombMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.TtBo_Cambios_DuenoMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.TtBo_Cambios_IdMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_DuenoMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_IdMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.Lab_Cambios_NombMascotas)
        Me.Cambios_Mascotas.Controls.Add(Me.PiBo_Cambios_ImgMascotas)
        Me.Cambios_Mascotas.Location = New System.Drawing.Point(4, 25)
        Me.Cambios_Mascotas.Name = "Cambios_Mascotas"
        Me.Cambios_Mascotas.Size = New System.Drawing.Size(754, 370)
        Me.Cambios_Mascotas.TabIndex = 2
        Me.Cambios_Mascotas.Text = "Cambio en las Mascotas"
        '
        'Btn_Cambios_ImgMascotas
        '
        Me.Btn_Cambios_ImgMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Cambios_ImgMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Btn_Cambios_ImgMascotas.Location = New System.Drawing.Point(104, 240)
        Me.Btn_Cambios_ImgMascotas.Name = "Btn_Cambios_ImgMascotas"
        Me.Btn_Cambios_ImgMascotas.Size = New System.Drawing.Size(134, 25)
        Me.Btn_Cambios_ImgMascotas.TabIndex = 55
        Me.Btn_Cambios_ImgMascotas.Text = "Subir Imagen"
        Me.Btn_Cambios_ImgMascotas.UseVisualStyleBackColor = False
        '
        'Btn_Cambios_LimpiarMascotas
        '
        Me.Btn_Cambios_LimpiarMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Cambios_LimpiarMascotas.Location = New System.Drawing.Point(442, 317)
        Me.Btn_Cambios_LimpiarMascotas.Name = "Btn_Cambios_LimpiarMascotas"
        Me.Btn_Cambios_LimpiarMascotas.Size = New System.Drawing.Size(75, 25)
        Me.Btn_Cambios_LimpiarMascotas.TabIndex = 54
        Me.Btn_Cambios_LimpiarMascotas.Text = "Limpiar"
        Me.Btn_Cambios_LimpiarMascotas.UseVisualStyleBackColor = False
        '
        'Btn_Cambios_GuardarMascotas
        '
        Me.Btn_Cambios_GuardarMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Cambios_GuardarMascotas.Location = New System.Drawing.Point(527, 317)
        Me.Btn_Cambios_GuardarMascotas.Name = "Btn_Cambios_GuardarMascotas"
        Me.Btn_Cambios_GuardarMascotas.Size = New System.Drawing.Size(134, 25)
        Me.Btn_Cambios_GuardarMascotas.TabIndex = 53
        Me.Btn_Cambios_GuardarMascotas.Text = "Guardar"
        Me.Btn_Cambios_GuardarMascotas.UseVisualStyleBackColor = False
        '
        'TtBo_Cambios_ObservMascotas
        '
        Me.TtBo_Cambios_ObservMascotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TtBo_Cambios_ObservMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TtBo_Cambios_ObservMascotas.Location = New System.Drawing.Point(442, 289)
        Me.TtBo_Cambios_ObservMascotas.Name = "TtBo_Cambios_ObservMascotas"
        Me.TtBo_Cambios_ObservMascotas.Size = New System.Drawing.Size(219, 22)
        Me.TtBo_Cambios_ObservMascotas.TabIndex = 52
        '
        'Lab_Cambios_ObservMascotas
        '
        Me.Lab_Cambios_ObservMascotas.AutoSize = True
        Me.Lab_Cambios_ObservMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_ObservMascotas.Location = New System.Drawing.Point(290, 294)
        Me.Lab_Cambios_ObservMascotas.Name = "Lab_Cambios_ObservMascotas"
        Me.Lab_Cambios_ObservMascotas.Size = New System.Drawing.Size(107, 17)
        Me.Lab_Cambios_ObservMascotas.TabIndex = 51
        Me.Lab_Cambios_ObservMascotas.Text = "Observaciones:"
        '
        'DaTiPi_Cambios_FechaNacMascotas
        '
        Me.DaTiPi_Cambios_FechaNacMascotas.Location = New System.Drawing.Point(442, 249)
        Me.DaTiPi_Cambios_FechaNacMascotas.Name = "DaTiPi_Cambios_FechaNacMascotas"
        Me.DaTiPi_Cambios_FechaNacMascotas.Size = New System.Drawing.Size(219, 22)
        Me.DaTiPi_Cambios_FechaNacMascotas.TabIndex = 50
        Me.DaTiPi_Cambios_FechaNacMascotas.TabStop = False
        '
        'Lab_Cambios_FechNacMascotas
        '
        Me.Lab_Cambios_FechNacMascotas.AutoSize = True
        Me.Lab_Cambios_FechNacMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_FechNacMascotas.Location = New System.Drawing.Point(290, 249)
        Me.Lab_Cambios_FechNacMascotas.Name = "Lab_Cambios_FechNacMascotas"
        Me.Lab_Cambios_FechNacMascotas.Size = New System.Drawing.Size(143, 17)
        Me.Lab_Cambios_FechNacMascotas.TabIndex = 49
        Me.Lab_Cambios_FechNacMascotas.Text = "Fecha de nacimiento:"
        '
        'CoBo_Cambios_SexoMascotas
        '
        Me.CoBo_Cambios_SexoMascotas.FormattingEnabled = True
        Me.CoBo_Cambios_SexoMascotas.Items.AddRange(New Object() {"Hembra", "Macho", "Sin especificaciones"})
        Me.CoBo_Cambios_SexoMascotas.Location = New System.Drawing.Point(604, 210)
        Me.CoBo_Cambios_SexoMascotas.Name = "CoBo_Cambios_SexoMascotas"
        Me.CoBo_Cambios_SexoMascotas.Size = New System.Drawing.Size(57, 24)
        Me.CoBo_Cambios_SexoMascotas.TabIndex = 48
        '
        'Lab_Cambios_SexoMascotas
        '
        Me.Lab_Cambios_SexoMascotas.AutoSize = True
        Me.Lab_Cambios_SexoMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_SexoMascotas.Location = New System.Drawing.Point(555, 213)
        Me.Lab_Cambios_SexoMascotas.Name = "Lab_Cambios_SexoMascotas"
        Me.Lab_Cambios_SexoMascotas.Size = New System.Drawing.Size(43, 17)
        Me.Lab_Cambios_SexoMascotas.TabIndex = 47
        Me.Lab_Cambios_SexoMascotas.Text = "Sexo:"
        '
        'CoBo_Cambios_FamiliaMascotas
        '
        Me.CoBo_Cambios_FamiliaMascotas.FormattingEnabled = True
        Me.CoBo_Cambios_FamiliaMascotas.Items.AddRange(New Object() {"Caninos", "Felinos", "Peces", "Aves", "Insectos", "Arañas y Alacranes", "Ranas", "Otros"})
        Me.CoBo_Cambios_FamiliaMascotas.Location = New System.Drawing.Point(485, 210)
        Me.CoBo_Cambios_FamiliaMascotas.Name = "CoBo_Cambios_FamiliaMascotas"
        Me.CoBo_Cambios_FamiliaMascotas.Size = New System.Drawing.Size(57, 24)
        Me.CoBo_Cambios_FamiliaMascotas.TabIndex = 46
        '
        'Lab_Cambios_FamiliaMascotas
        '
        Me.Lab_Cambios_FamiliaMascotas.AutoSize = True
        Me.Lab_Cambios_FamiliaMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_FamiliaMascotas.Location = New System.Drawing.Point(423, 213)
        Me.Lab_Cambios_FamiliaMascotas.Name = "Lab_Cambios_FamiliaMascotas"
        Me.Lab_Cambios_FamiliaMascotas.Size = New System.Drawing.Size(56, 17)
        Me.Lab_Cambios_FamiliaMascotas.TabIndex = 45
        Me.Lab_Cambios_FamiliaMascotas.Text = "Familia:"
        '
        'TtBo_Cambios_RazaMascotas
        '
        Me.TtBo_Cambios_RazaMascotas.Location = New System.Drawing.Point(431, 173)
        Me.TtBo_Cambios_RazaMascotas.Name = "TtBo_Cambios_RazaMascotas"
        Me.TtBo_Cambios_RazaMascotas.Size = New System.Drawing.Size(230, 22)
        Me.TtBo_Cambios_RazaMascotas.TabIndex = 44
        '
        'Lab_Cambios_RazaMascotas
        '
        Me.Lab_Cambios_RazaMascotas.AutoSize = True
        Me.Lab_Cambios_RazaMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_RazaMascotas.Location = New System.Drawing.Point(290, 176)
        Me.Lab_Cambios_RazaMascotas.Name = "Lab_Cambios_RazaMascotas"
        Me.Lab_Cambios_RazaMascotas.Size = New System.Drawing.Size(45, 17)
        Me.Lab_Cambios_RazaMascotas.TabIndex = 43
        Me.Lab_Cambios_RazaMascotas.Text = "Raza:"
        '
        'TtBo_Cambios_ColorMascotas
        '
        Me.TtBo_Cambios_ColorMascotas.Location = New System.Drawing.Point(431, 135)
        Me.TtBo_Cambios_ColorMascotas.Name = "TtBo_Cambios_ColorMascotas"
        Me.TtBo_Cambios_ColorMascotas.Size = New System.Drawing.Size(230, 22)
        Me.TtBo_Cambios_ColorMascotas.TabIndex = 42
        '
        'Lab_Cambios_ColorMascotas
        '
        Me.Lab_Cambios_ColorMascotas.AutoSize = True
        Me.Lab_Cambios_ColorMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_ColorMascotas.Location = New System.Drawing.Point(272, 135)
        Me.Lab_Cambios_ColorMascotas.Name = "Lab_Cambios_ColorMascotas"
        Me.Lab_Cambios_ColorMascotas.Size = New System.Drawing.Size(137, 17)
        Me.Lab_Cambios_ColorMascotas.TabIndex = 41
        Me.Lab_Cambios_ColorMascotas.Text = "Color de la mascota:"
        '
        'TtBo_Cambios_NombMascotas
        '
        Me.TtBo_Cambios_NombMascotas.Location = New System.Drawing.Point(431, 94)
        Me.TtBo_Cambios_NombMascotas.Name = "TtBo_Cambios_NombMascotas"
        Me.TtBo_Cambios_NombMascotas.Size = New System.Drawing.Size(230, 22)
        Me.TtBo_Cambios_NombMascotas.TabIndex = 40
        '
        'TtBo_Cambios_DuenoMascotas
        '
        Me.TtBo_Cambios_DuenoMascotas.Location = New System.Drawing.Point(431, 60)
        Me.TtBo_Cambios_DuenoMascotas.Name = "TtBo_Cambios_DuenoMascotas"
        Me.TtBo_Cambios_DuenoMascotas.Size = New System.Drawing.Size(230, 22)
        Me.TtBo_Cambios_DuenoMascotas.TabIndex = 39
        '
        'TtBo_Cambios_IdMascotas
        '
        Me.TtBo_Cambios_IdMascotas.Location = New System.Drawing.Point(431, 28)
        Me.TtBo_Cambios_IdMascotas.Name = "TtBo_Cambios_IdMascotas"
        Me.TtBo_Cambios_IdMascotas.Size = New System.Drawing.Size(59, 22)
        Me.TtBo_Cambios_IdMascotas.TabIndex = 38
        '
        'Lab_Cambios_DuenoMascotas
        '
        Me.Lab_Cambios_DuenoMascotas.AutoSize = True
        Me.Lab_Cambios_DuenoMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_DuenoMascotas.Location = New System.Drawing.Point(290, 63)
        Me.Lab_Cambios_DuenoMascotas.Name = "Lab_Cambios_DuenoMascotas"
        Me.Lab_Cambios_DuenoMascotas.Size = New System.Drawing.Size(54, 17)
        Me.Lab_Cambios_DuenoMascotas.TabIndex = 37
        Me.Lab_Cambios_DuenoMascotas.Text = "Dueño:"
        '
        'Lab_Cambios_IdMascotas
        '
        Me.Lab_Cambios_IdMascotas.AutoSize = True
        Me.Lab_Cambios_IdMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_IdMascotas.Location = New System.Drawing.Point(290, 28)
        Me.Lab_Cambios_IdMascotas.Name = "Lab_Cambios_IdMascotas"
        Me.Lab_Cambios_IdMascotas.Size = New System.Drawing.Size(80, 17)
        Me.Lab_Cambios_IdMascotas.TabIndex = 36
        Me.Lab_Cambios_IdMascotas.Text = "Id Mascota:"
        '
        'Lab_Cambios_NombMascotas
        '
        Me.Lab_Cambios_NombMascotas.AutoSize = True
        Me.Lab_Cambios_NombMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lab_Cambios_NombMascotas.Location = New System.Drawing.Point(272, 97)
        Me.Lab_Cambios_NombMascotas.Name = "Lab_Cambios_NombMascotas"
        Me.Lab_Cambios_NombMascotas.Size = New System.Drawing.Size(154, 17)
        Me.Lab_Cambios_NombMascotas.TabIndex = 35
        Me.Lab_Cambios_NombMascotas.Text = "Nombre de la mascota:"
        '
        'PiBo_Cambios_ImgMascotas
        '
        Me.PiBo_Cambios_ImgMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PiBo_Cambios_ImgMascotas.BackgroundImage = CType(resources.GetObject("PiBo_Cambios_ImgMascotas.BackgroundImage"), System.Drawing.Image)
        Me.PiBo_Cambios_ImgMascotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PiBo_Cambios_ImgMascotas.Location = New System.Drawing.Point(93, 73)
        Me.PiBo_Cambios_ImgMascotas.Name = "PiBo_Cambios_ImgMascotas"
        Me.PiBo_Cambios_ImgMascotas.Size = New System.Drawing.Size(162, 154)
        Me.PiBo_Cambios_ImgMascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PiBo_Cambios_ImgMascotas.TabIndex = 34
        Me.PiBo_Cambios_ImgMascotas.TabStop = False
        '
        'Baja_Mascotas
        '
        Me.Baja_Mascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baja_Mascotas.Controls.Add(Me.Button6)
        Me.Baja_Mascotas.Controls.Add(Me.DGV_Baja_ListaMascotas)
        Me.Baja_Mascotas.Controls.Add(Me.GrBo_Bajas_BuscarMascotas)
        Me.Baja_Mascotas.Location = New System.Drawing.Point(4, 25)
        Me.Baja_Mascotas.Name = "Baja_Mascotas"
        Me.Baja_Mascotas.Size = New System.Drawing.Size(754, 370)
        Me.Baja_Mascotas.TabIndex = 3
        Me.Baja_Mascotas.Text = "Baja de Mascotas "
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(363, 347)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 23)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Eliminar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DGV_Baja_ListaMascotas
        '
        Me.DGV_Baja_ListaMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Baja_ListaMascotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DGV_Baja_ListaMascotas.Location = New System.Drawing.Point(4, 187)
        Me.DGV_Baja_ListaMascotas.Name = "DGV_Baja_ListaMascotas"
        Me.DGV_Baja_ListaMascotas.Size = New System.Drawing.Size(779, 137)
        Me.DGV_Baja_ListaMascotas.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Mascota"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dueño"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre Mascota"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Raza"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Familia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha de nacimiento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'GrBo_Bajas_BuscarMascotas
        '
        Me.GrBo_Bajas_BuscarMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrBo_Bajas_BuscarMascotas.Controls.Add(Me.Btn_Baja_BuscarMascotas)
        Me.GrBo_Bajas_BuscarMascotas.Controls.Add(Me.TtBo_Baja_BuscarMascotas)
        Me.GrBo_Bajas_BuscarMascotas.Controls.Add(Me.Lab_Baja_IdMascotas)
        Me.GrBo_Bajas_BuscarMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBo_Bajas_BuscarMascotas.Location = New System.Drawing.Point(226, 29)
        Me.GrBo_Bajas_BuscarMascotas.Name = "GrBo_Bajas_BuscarMascotas"
        Me.GrBo_Bajas_BuscarMascotas.Size = New System.Drawing.Size(335, 108)
        Me.GrBo_Bajas_BuscarMascotas.TabIndex = 3
        Me.GrBo_Bajas_BuscarMascotas.TabStop = False
        Me.GrBo_Bajas_BuscarMascotas.Text = "Datos de Busqueda de Mascotas"
        '
        'Btn_Baja_BuscarMascotas
        '
        Me.Btn_Baja_BuscarMascotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Baja_BuscarMascotas.Location = New System.Drawing.Point(85, 67)
        Me.Btn_Baja_BuscarMascotas.Name = "Btn_Baja_BuscarMascotas"
        Me.Btn_Baja_BuscarMascotas.Size = New System.Drawing.Size(152, 23)
        Me.Btn_Baja_BuscarMascotas.TabIndex = 2
        Me.Btn_Baja_BuscarMascotas.Text = "Buscar"
        Me.Btn_Baja_BuscarMascotas.UseVisualStyleBackColor = False
        '
        'TtBo_Baja_BuscarMascotas
        '
        Me.TtBo_Baja_BuscarMascotas.Location = New System.Drawing.Point(107, 39)
        Me.TtBo_Baja_BuscarMascotas.Name = "TtBo_Baja_BuscarMascotas"
        Me.TtBo_Baja_BuscarMascotas.Size = New System.Drawing.Size(157, 22)
        Me.TtBo_Baja_BuscarMascotas.TabIndex = 1
        '
        'Lab_Baja_IdMascotas
        '
        Me.Lab_Baja_IdMascotas.AutoSize = True
        Me.Lab_Baja_IdMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Baja_IdMascotas.Location = New System.Drawing.Point(21, 39)
        Me.Lab_Baja_IdMascotas.Name = "Lab_Baja_IdMascotas"
        Me.Lab_Baja_IdMascotas.Size = New System.Drawing.Size(80, 17)
        Me.Lab_Baja_IdMascotas.TabIndex = 0
        Me.Lab_Baja_IdMascotas.Text = "Id Mascota:"
        '
        'Btn_atras
        '
        Me.Btn_atras.Location = New System.Drawing.Point(12, 10)
        Me.Btn_atras.Name = "Btn_atras"
        Me.Btn_atras.Size = New System.Drawing.Size(75, 25)
        Me.Btn_atras.TabIndex = 34
        Me.Btn_atras.Text = "< Atras"
        Me.Btn_atras.UseVisualStyleBackColor = True
        '
        'Form_Mascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Spa_Mascotas.My.Resources.Resources.depositphotos_81696382_stock_photo_teal_and_white_doggy_tile1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_atras)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Mascotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mascotas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.Alta_Mascotas.ResumeLayout(False)
        Me.Alta_Mascotas.PerformLayout()
        CType(Me.PiBo_Alta_ImgMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Consulta_Mascotas.ResumeLayout(False)
        CType(Me.DGV_ListaMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBo_Alta_BusMascotas.ResumeLayout(False)
        Me.GrBo_Alta_BusMascotas.PerformLayout()
        Me.Cambios_Mascotas.ResumeLayout(False)
        Me.Cambios_Mascotas.PerformLayout()
        CType(Me.PiBo_Cambios_ImgMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Baja_Mascotas.ResumeLayout(False)
        CType(Me.DGV_Baja_ListaMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBo_Bajas_BuscarMascotas.ResumeLayout(False)
        Me.GrBo_Bajas_BuscarMascotas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Alta_Mascotas As TabPage
    Friend WithEvents PiBo_Alta_ImgMascotas As PictureBox
    Friend WithEvents Consulta_Mascotas As TabPage
    Friend WithEvents Lab_Alta_NombMascotas As Label
    Friend WithEvents TtBo_Alta_NombMascotas As TextBox
    Friend WithEvents TtBo_Alta_DuenoMascotas As TextBox
    Friend WithEvents TtBo_Alta_IdMascotas As TextBox
    Friend WithEvents Lab_Alta_DuenoMascotas As Label
    Friend WithEvents Lab_Alta_IdMascotas As Label
    Friend WithEvents Lab_Alta_ColorMascotas As Label
    Friend WithEvents TtBo_Alta_ColorMascotas As TextBox
    Friend WithEvents TtBo_Alta_ObservMascotas As TextBox
    Friend WithEvents Lab_Alta_ObservMascotas As Label
    Friend WithEvents DaTiPi_Alta_FechaNacMascotas As DateTimePicker
    Friend WithEvents Lab_Alta_FechaNacMascotas As Label
    Friend WithEvents CoBo_Alta_SexoMascotas As ComboBox
    Friend WithEvents Lab_Alta_SexoMascotas As Label
    Friend WithEvents CoBo_Alta_FamiliaMascotas As ComboBox
    Friend WithEvents Lab_Alta_FamiliaMascotas As Label
    Friend WithEvents TtBo_Alta_RazaMascotas As TextBox
    Friend WithEvents Lab_Alta_RazaMascotas As Label
    Friend WithEvents Btn_Alta_GuardarMascotas As Button
    Friend WithEvents Btn_Alta_LimpiarMascotas As Button
    Friend WithEvents Btn_Alta_ImgMascotas As Button
    Friend WithEvents Btn_atras As Button
    Friend WithEvents Cambios_Mascotas As TabPage
    Friend WithEvents Baja_Mascotas As TabPage
    Friend WithEvents GrBo_Alta_BusMascotas As GroupBox
    Friend WithEvents Btn_Consulta_BuscarTodoMascotas As Button
    Friend WithEvents TtBo_Consulta_IdMascotas As TextBox
    Friend WithEvents Lab_Consulta_IdMascotas As Label
    Friend WithEvents DGV_ListaMascotas As DataGridView
    Friend WithEvents Id_mascota As DataGridViewTextBoxColumn
    Friend WithEvents Dueño As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Mascota As DataGridViewTextBoxColumn
    Friend WithEvents Raza As DataGridViewTextBoxColumn
    Friend WithEvents Familia As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Baja_ListaMascotas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents GrBo_Bajas_BuscarMascotas As GroupBox
    Friend WithEvents Btn_Baja_BuscarMascotas As Button
    Friend WithEvents TtBo_Baja_BuscarMascotas As TextBox
    Friend WithEvents Lab_Baja_IdMascotas As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Btn_Consulta_BuscarIdMascotas As Button
    Friend WithEvents Btn_Cambios_ImgMascotas As Button
    Friend WithEvents Btn_Cambios_LimpiarMascotas As Button
    Friend WithEvents Btn_Cambios_GuardarMascotas As Button
    Friend WithEvents TtBo_Cambios_ObservMascotas As TextBox
    Friend WithEvents Lab_Cambios_ObservMascotas As Label
    Friend WithEvents DaTiPi_Cambios_FechaNacMascotas As DateTimePicker
    Friend WithEvents Lab_Cambios_FechNacMascotas As Label
    Friend WithEvents CoBo_Cambios_SexoMascotas As ComboBox
    Friend WithEvents Lab_Cambios_SexoMascotas As Label
    Friend WithEvents CoBo_Cambios_FamiliaMascotas As ComboBox
    Friend WithEvents Lab_Cambios_FamiliaMascotas As Label
    Friend WithEvents TtBo_Cambios_RazaMascotas As TextBox
    Friend WithEvents Lab_Cambios_RazaMascotas As Label
    Friend WithEvents TtBo_Cambios_ColorMascotas As TextBox
    Friend WithEvents Lab_Cambios_ColorMascotas As Label
    Friend WithEvents TtBo_Cambios_NombMascotas As TextBox
    Friend WithEvents TtBo_Cambios_DuenoMascotas As TextBox
    Friend WithEvents TtBo_Cambios_IdMascotas As TextBox
    Friend WithEvents Lab_Cambios_DuenoMascotas As Label
    Friend WithEvents Lab_Cambios_IdMascotas As Label
    Friend WithEvents Lab_Cambios_NombMascotas As Label
    Friend WithEvents PiBo_Cambios_ImgMascotas As PictureBox
End Class
