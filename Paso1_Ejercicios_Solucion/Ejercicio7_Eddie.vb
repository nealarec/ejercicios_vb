Public Class Ejercicio7_Eddie
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Numero As Double = txtNumero.Text
        Dim raiz, absoluto, seno, coseno, log As Double

        raiz = Math.Sqrt(Numero)
        absoluto = Math.Abs(Numero)
        seno = Math.Sin(Numero)
        ' coseno = Math.Acos(Numero)
        log = Math.Log(Numero)


        txtRaiz.Text = Math.Round(raiz, 3)
        txtAbsoluto.Text = absoluto
        txtSeno.Text = Math.Round(seno, 3)
        txtCoseno.Text = Math.Round(coseno, 3)
        txtLog.Text = Math.Round(log, 3)
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "-" And txtNumero.Text = "" Then
            e.Handled = False
            FallaEdad.SetError(txtNumero, Nothing)
        Else
            e.Handled = True
            FallaEdad.SetError(txtNumero, "Solo debe ingresar Números")
        End If
    End Sub
End Class
