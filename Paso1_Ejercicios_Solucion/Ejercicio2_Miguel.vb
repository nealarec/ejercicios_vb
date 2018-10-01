Public Class Ejercicio2_Miguel
    Private Sub btnGuardar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseClick


        If txtNombre.Text <> "" And txtApellido.Text <> "" And txtEdad.Text <> "" And txtTelefono.Text <> "" Then

            lbxRecopilado.Items.Add(txtNombre.Text + " " + txtApellido.Text + " " + txtEdad.Text + " " + txtTelefono.Text)

            txtNombre.Clear()
            txtApellido.Clear()
            txtEdad.Clear()
            txtTelefono.Clear()
            txtNombre.Focus()

        End If

    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            FallaEdad.SetError(txtEdad, Nothing)
        Else
            e.Handled = True
            FallaEdad.SetError(txtEdad, "Este campo es solo para Números")
        End If

    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            FallaTelefono.SetError(txtTelefono, Nothing)
        Else
            e.Handled = True
            FallaTelefono.SetError(txtTelefono, "Este campo es solo para Números")
        End If

    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            FallaApellido.SetError(txtApellido, Nothing)
        Else
            e.Handled = True
            FallaApellido.SetError(txtApellido, "Este campo es solo para Texto")
        End If

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            FallaNombre.SetError(txtNombre, Nothing)
        Else
            e.Handled = True
            FallaNombre.SetError(txtNombre, "Este campo es solo para Texto")
        End If
    End Sub
End Class
