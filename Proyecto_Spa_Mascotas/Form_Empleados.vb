Public Class Form_Empleados
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Form_Productos.Show()
        Me.Hide()
    End Sub

    Private Sub ServiciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem1.Click
        Form_Servicios.Show()
        Me.Hide()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Form_Inventario.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Form_Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Form_Proveedores.Show()
        Me.Hide()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Form_Compras.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_atras_Click(sender As Object, e As EventArgs) Handles Btn_atras.Click
        'Form_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub ClientesYMascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYMascotasToolStripMenuItem.Click
        Form_ClientesYMascotas.Show()
        Me.Hide()
    End Sub
    Private Sub TextBox11_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TtBo_Alta_CpEmp.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TtBo_Alta_TelefMoviEmp.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TtBo_Alta_TelefFijoEmp.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBo_Alta_TurnoEmp.SelectedIndexChanged
        CoBo_Alta_HrEntEmp.Items.Clear()
        CoBo_Alta_MeridianaEntEmp.Items.Clear()
        CoBo_Alta_HrSalEmp.Items.Clear()
        CoBo_Alta_MeridianaSalEmp.Items.Clear()
        If CoBo_Alta_TurnoEmp.SelectedIndex = 0 Then
            For i = 6 To 18
                Dim Jornada As String = i.ToString() + ":00"
                CoBo_Alta_HrEntEmp.Items.Add(Jornada)
                CoBo_Alta_HrSalEmp.Items.Add(Jornada)
            Next
            If CoBo_Alta_HrEntEmp.SelectedIndex < 5 Then
                CoBo_Alta_MeridianaEntEmp.Items.Add("A.M")
            Else
                CoBo_Alta_MeridianaEntEmp.Items.Add("P.M")
            End If
            If CoBo_Alta_HrSalEmp.SelectedIndex > 5 Then
                CoBo_Alta_MeridianaSalEmp.Items.Add("A.M")
            Else
                CoBo_Alta_MeridianaSalEmp.Items.Add("P.M")
            End If
        Else
            For i = 18 To 24
                Dim Jornada As String = i.ToString() + ":00"
                CoBo_Alta_HrEntEmp.Items.Add(Jornada)
                CoBo_Alta_HrSalEmp.Items.Add(Jornada)
            Next
            For i = 1 To 6
                Dim Jornada As String = i.ToString() + ":00"
                CoBo_Alta_HrEntEmp.Items.Add(Jornada)
                CoBo_Alta_HrSalEmp.Items.Add(Jornada)
            Next
            If CoBo_Alta_HrEntEmp.SelectedIndex < 5 Then
                CoBo_Alta_MeridianaEntEmp.Items.Add("P.M")
            Else
                CoBo_Alta_MeridianaEntEmp.Items.Add("A.M")
            End If
            If CoBo_Alta_HrSalEmp.SelectedIndex > 5 Then
                CoBo_Alta_MeridianaSalEmp.Items.Add("P.M")
            Else
                CoBo_Alta_MeridianaSalEmp.Items.Add("A.M")
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RaBo_Alta_NaclidadExtjEmp.CheckedChanged
        If RaBo_Alta_NaclidadExtjEmp.Checked Then
            TtBo_Alta_NaclidadOrigEmp.Enabled = True
        Else
            TtBo_Alta_NaclidadOrigEmp.Enabled = False
        End If
    End Sub

    Private Sub Form_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DaTiPi_Alta_FechNacEmp.MinDate = "01/01/1920"
        DaTiPi_Alta_FechNacEmp.MaxDate = Date.Now().ToShortDateString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn_Camb_Buscar.Click
        Dim Buscar As Boolean = False
        If TtBo_Camb_NombEmp.TextLength >= 1 And TtBo_Camb_AmatEmp.TextLength > 2 And TtBo_Camb_ApatEmp.TextLength > 2 Then
            Buscar = True
        ElseIf TtBo_Camb_CurpEmp.TextLength >= 18 Then
            Buscar = True
        End If
        If Buscar Then
            'Aqui va la funcion de buscar
            'Se debe regresar la información y desbloar las casillas
        Else
            MsgBox("Lo sentimos, no se coloco información valida", MsgBoxStyle.Critical)
        End If
    End Sub
    'Consulta de empleados'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Cons_Consultar.Click
        If TtBo_Cons_NombEmp.TextLength >= 1 And TtBo_Cons_ApatEmp.TextLength > 2 And TtBo_Cons_AmatEmp.TextLength > 2 Or TtBo_Cons_CurpEmp.TextLength >= 18 Then
            'Aqui va la funcion de buscar
        Else
            MsgBox("Lo sentimos no se cumple con los criterios de busqueda, intentelo de nuevo", MsgBoxStyle.Critical)
        End If
    End Sub
    'Eliminar
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Btn_Baja_Buscar.Click
        If TtBo_Baja_NombEmp.TextLength >= 1 And TtBo_Baja_ApatEmp.TextLength > 2 And TtBo_Baja_AmatEmp.TextLength > 2 Or TtBo_Baja_CurpEmp.TextLength >= 18 Then
            'Aqui va la funcion de buscar
        Else
            MsgBox("Lo sentimos no se cumple con los criterios de busqueda, intentelo de nuevo", MsgBoxStyle.Critical)
        End If
    End Sub
End Class