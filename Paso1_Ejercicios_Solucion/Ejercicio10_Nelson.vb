Public Class Ejercicio10_Nelson
    Private GravityVal As Double
    Private MaxHeightVal As Double

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If CaptureValues() Then
            Dim InitialSpeed As Double = CalculateInitalSpeed()
            ResultLabel.Text = InitialSpeed.ToString("F2") + " m/s2"
        End If
    End Sub

    Private Function CaptureValues() As Boolean
        Try
            MaxHeightVal = Double.Parse(MaxHeight.Text.Replace(".", ","))
        Catch ex As Exception
            MessageBox.Show("La altura debe ser un número", "Error de Formato")
            Return False
        End Try

        Try
            GravityVal = Double.Parse(Gravity.Text.Replace(".", ","))
        Catch ex As Exception
            MessageBox.Show("La gravedad debe ser un número", "Error de Formato")
            Return False
        End Try

        Return True
    End Function

    Private Function CalculateInitalSpeed() As Double
        Return Math.Sqrt(2 * GravityVal * MaxHeightVal)
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Gravity.Text = "9.78"
        MaxHeight.Text = ""
    End Sub
End Class
