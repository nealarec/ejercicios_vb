Public Class Ejercicio3
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim val_ax As Double, val_ay As Double, val_bx As Double, val_by As Double
        Try
            val_ax = Double.Parse(ax.Text.Replace(".", ","))
        Catch ex As FormatException
            MessageBox.Show("El valor de X para el Punto A, Debe ser un número", "Error de Conversión")
            Return
        End Try

        Try
            val_ay = Double.Parse(ay.Text.Replace(".", ","))
        Catch ex As FormatException
            MessageBox.Show("El valor de Y para el Punto A, Debe ser un número", "Error de Conversión")
            Return
        End Try

        Try
            val_bx = Double.Parse(bx.Text.Replace(".", ","))
        Catch ex As FormatException
            MessageBox.Show("El valor de X para el Punto B, Debe ser un número", "Error de Conversión")
            Return
        End Try

        Try
            val_by = Double.Parse(by.Text.Replace(".", ","))
        Catch ex As FormatException
            MessageBox.Show("El valor de Y para el Punto B, Debe ser un número", "Error de Conversión")
            Return
        End Try

        resultado.Text = Math.Sqrt(Math.Pow(val_bx - val_ax, 2) + Math.Pow(val_by - val_ay, 2)).ToString("F2")

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ax.Text = ""
        ay.Text = ""
        bx.Text = ""
        by.Text = ""
    End Sub
End Class
