Module Validaciones
    Public Class Validaciones_Textos
        Public Sub Textos_Sin_Numeros(sender As Object, e As KeyPressEventArgs)
            If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End Sub
    End Class
    Public Class Validaciones_Numeros
        Public Sub Textos_solo_numeros(sender As Object, e As KeyPressEventArgs)
            If Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End Sub
        Public Sub Texto_numero_decimales(sender As Object, e As KeyPressEventArgs, Texto As String)
            If IsNumeric(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf e.KeyChar = "." Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub
    End Class

End Module
