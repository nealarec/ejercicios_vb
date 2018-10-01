Public Class Ejercicio9_Andres
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtResultado1.Clear()
        txtResultado2.Clear()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, c As Double
        Dim discriminante As Double

        a = Val(txtA.Text)
        b = Val(txtB.Text)
        c = Val(txtC.Text)
        discriminante = (b ^ 2) - 4 * a * c

        If (discriminante < 0) Then
            MessageBox.Show("La ecuación no tiene solución en los números reales", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (discriminante = 0) Then
            txtResultado1.Text = -b / (2 * a)
        ElseIf (discriminante > 0) Then
            txtResultado1.Text = (-b + (discriminante) ^ (1 / 2)) / (2 * a)
            txtResultado2.Text = (-b - (discriminante) ^ (1 / 2)) / (2 * a)
        End If
    End Sub
End Class
