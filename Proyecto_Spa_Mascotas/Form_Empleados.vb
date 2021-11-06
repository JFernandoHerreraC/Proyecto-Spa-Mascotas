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
        Form_Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub ClientesYMascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYMascotasToolStripMenuItem.Click
        Form_ClientesYMascotas.Show()
        Me.Hide()
    End Sub
    Private Sub TextBox11_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        ComboBox7.Items.Clear()
        If ComboBox3.SelectedIndex = 0 Then
            For i = 6 To 18
                Dim Jornada As String = i.ToString() + ":00"
                ComboBox4.Items.Add(Jornada)
                ComboBox6.Items.Add(Jornada)
            Next
            If ComboBox4.SelectedIndex < 5 Then
                ComboBox5.Items.Add("A.M")
            Else
                ComboBox5.Items.Add("P.M")
            End If
            If ComboBox6.SelectedIndex > 5 Then
                ComboBox7.Items.Add("A.M")
            Else
                ComboBox7.Items.Add("P.M")
            End If
        Else
            For i = 18 To 24
                Dim Jornada As String = i.ToString() + ":00"
                ComboBox4.Items.Add(Jornada)
                ComboBox6.Items.Add(Jornada)
            Next
            For i = 1 To 6
                Dim Jornada As String = i.ToString() + ":00"
                ComboBox4.Items.Add(Jornada)
                ComboBox6.Items.Add(Jornada)
            Next
            If ComboBox4.SelectedIndex < 5 Then
                ComboBox5.Items.Add("P.M")
            Else
                ComboBox5.Items.Add("A.M")
            End If
            If ComboBox6.SelectedIndex > 5 Then
                ComboBox7.Items.Add("P.M")
            Else
                ComboBox7.Items.Add("A.M")
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox13.Enabled = True
        Else
            TextBox13.Enabled = False
        End If
    End Sub

    Private Sub Form_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = "01/01/1920"
        DateTimePicker1.MaxDate = Date.Now().ToShortDateString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Buscar As Boolean = False
        If TextBox34.TextLength >= 1 And TextBox32.TextLength > 2 And TextBox33.TextLength > 2 Then
            Buscar = True
        ElseIf TextBox22.TextLength >= 18 Then
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox18.TextLength >= 1 And TextBox17.TextLength > 2 And TextBox16.TextLength > 2 Or TextBox19.TextLength >= 18 Then
            'Aqui va la funcion de buscar
        Else
            MsgBox("Lo sentimos no se cumple con los criterios de busqueda, intentelo de nuevo", MsgBoxStyle.Critical)
        End If
    End Sub
    'Eliminar
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox38.TextLength >= 1 And TextBox37.TextLength > 2 And TextBox36.TextLength > 2 Or TextBox35.TextLength >= 18 Then
            'Aqui va la funcion de buscar
        Else
            MsgBox("Lo sentimos no se cumple con los criterios de busqueda, intentelo de nuevo", MsgBoxStyle.Critical)
        End If
    End Sub
End Class