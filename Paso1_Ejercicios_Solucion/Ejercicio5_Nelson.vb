Public Class Ejercicio5_Nelson
    Private ValDistance As Double
    Private ValVelM1 As Double
    Private ValVelM2 As Double
    Private ValDeltaTime As Double

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If CaptureValues() Then
            Dim FinalTime = CalculateTime()
            Dim FinalDistance = CalculateDistance(FinalTime)

            If FinalDistance >= 0 And FinalDistance <= ValDistance Then
                ResTime.Text = FinalTime.ToString("F2") + " h"
                ResDistance.Text = FinalDistance.ToString("F2") + " Km"
            Else
                ResTime.Text = "Los moviles no se encuentran"
                ResDistance.Text = "Los moviles no se encuentran"
            End If

        End If
    End Sub

    ''' <summary>
    ''' Captura los valores desde el formulario con validación de tipos
    ''' </summary>
    ''' <returns></returns>
    Private Function CaptureValues() As Boolean
        Try
            ValDistance = Double.Parse(Distance.Text.Replace(".", ","))
        Catch ex As FormatException
            MessageBox.Show("La distancia debe ser un número", "Error de Formato")
            Return False
        End Try

        Try
            ValVelM1 = Double.Parse(VelMovil1.Text.Replace(".", ","))
        Catch ex As FormatException
            MessageBox.Show("La velocidad del móvil 1 debe ser un número", "Error de Formato")
            Return False
        End Try

        Try
            ValVelM2 = Double.Parse(VelMovil2.Text.Replace(".", ","))
        Catch ex As FormatException
            MessageBox.Show("La velocidad del móvil 2 debe ser un número", "Error de Formato")
            Return False
        End Try

        Try
            ValDeltaTime = Double.Parse(DeltaTime.Text.Replace(".", ","))
        Catch ex As FormatException
            MessageBox.Show("El cambio de tiempo debe ser un número", "Error de Formato")
            Return False
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Calcula el tiempo que tardan los moviles en encontrarse
    ''' </summary>
    ''' <returns></returns>
    Private Function CalculateTime() As Double
        Return (ValDistance + ValVelM1 * ValDeltaTime) / (ValVelM1 + ValVelM2)
    End Function

    ''' <summary>
    ''' Calcula la distancia con respecto a punto A en la que se encuentran 
    ''' los moviles
    ''' </summary>
    ''' <param name="ResultTime"></param>
    ''' <returns></returns>
    Private Function CalculateDistance(ResultTime As Double) As Double
        Return ValVelM1 * (ResultTime - ValDeltaTime)
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        VelMovil1.Text = ""
        VelMovil2.Text = ""
        Distance.Text = ""
        DeltaTime.Text = ""
    End Sub
End Class
