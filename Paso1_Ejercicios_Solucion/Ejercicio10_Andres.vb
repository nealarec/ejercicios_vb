Public Class Ejercicio10_Andres
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        txtAltura.Clear()
        txtVelocidad.Clear()
    End Sub

    Private Sub tsbCalcular_Click(sender As Object, e As EventArgs) Handles tsbCalcular.Click
        Dim h As Double
        h = Val(txtAltura.Text)
        txtVelocidad.Text = Math.Sqrt(2 * 9.8 * h)
    End Sub
End Class
