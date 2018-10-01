Public Class Ejercicio6_Eddie

    Private Sub txtAgregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgregar.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se admiten números", "Validación de número", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click, btnAgregar.BackColorChanged
        'Agregar número
        If txtAgregar.Text <> "" Then
            LstNumero.Items.Add(txtAgregar.Text)
        End If
        txtAgregar.Clear()
        txtAgregar.Focus()

        'Contar registros
        LblRegistros.Text = LstNumero.Items.Count

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAgregar.Focus()
        LblRegistros.Text = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim indice As Integer

        'Eliminar número
        indice = LstNumero.SelectedIndex
        If indice <> -1 Then
            LstNumero.Items.RemoveAt(indice)
        End If

        'Contar registros
        LblRegistros.Text = LstNumero.Items.Count
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        LstNumero.Items.Clear()

        'Contar registros
        LblRegistros.Text = LstNumero.Items.Count
    End Sub

End Class
