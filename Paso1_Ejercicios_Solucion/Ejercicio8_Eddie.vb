Public Class Ejercicio8_Eddie
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim peso, estatura As Double
        Dim IMC As Double
        If TxtPeso.Text <> "" And TxtEstatura.Text <> "" Then
            peso = TxtPeso.Text
            estatura = TxtEstatura.Text / 100

            IMC = peso / (estatura * estatura) 'Cálculo IMC
            TxtIMC.Text = System.Math.Round(IMC, decimals:=1)

            'Condicional de Peso
            If IMC < 16.0 Then
                TxtEstado.Text = "Infrapeso: Delgadez Severa"
            ElseIf (IMC >= 16.1) And (IMC <= 16.99) Then
                TxtEstado.Text = "Infrapeso: Delgadez moderada"
            ElseIf (IMC >= 17.0) And (IMC <= 18.49) Then
                TxtEstado.Text = "Infrapeso: Delgadez aceptable"
            ElseIf (IMC >= 18.5) And (IMC <= 24.99) Then
                TxtEstado.Text = "Peso Normal"
            ElseIf (IMC >= 25.0) And (IMC <= 29.99) Then
                TxtEstado.Text = "Sobrepeso"
            ElseIf (IMC >= 30.0) And (IMC <= 34.99) Then
                TxtEstado.Text = "Obeso: Tipo I"
            ElseIf (IMC >= 35.0) And (IMC <= 40.0) Then
                TxtEstado.Text = "Obeso: Tipo II"
            ElseIf IMC > 40.0 Then
                TxtEstado.Text = "Obeso: Tipo III"
            End If
        Else
            ' MessageBox.Show("Los datos no pueden estar vacíos", "Validación datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorProvider1.SetError(TxtPeso, "ingresar datos")
            ErrorProvider1.SetError(TxtEstatura, "ingresar datos")
        End If
    End Sub
End Class
