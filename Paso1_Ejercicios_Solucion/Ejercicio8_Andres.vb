Public Class Ejercicio8_Andres
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim peso, altura As Integer
        Dim imc As Single

        altura = txtAltura.Text
        peso = txtPeso.Text
        imc = Val(txtPeso.Text) / (Val(txtAltura.Text) * Val(txtAltura.Text))

        txtImc.Text = imc

        If imc < 18.5 Then
            txtDescripcion.Text = "Peso Bajo"
        ElseIf (imc >= 18.5) And (imc <= 24.99) Then
            txtDescripcion.Text = "Peso Normal"
        ElseIf (imc >= 25) And (imc <= 29.99) Then
            txtDescripcion.Text = "Sobrepeso"
        ElseIf (imc >= 30) And (imc <= 39.99) Then
            txtDescripcion.Text = "Obesidad"
        ElseIf imc >= 40 Then
            txtDescripcion.Text = "Obesidad Mórbida"
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtAltura.Clear()
        txtPeso.Clear()
        txtImc.Clear()
        txtDescripcion.Clear()
    End Sub
End Class
