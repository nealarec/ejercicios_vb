Public Class Ejercicio11_Andres
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim fechaN As Date = dtpNacimiento.Value.ToShortDateString
        Dim fechaA As Date = DateTime.Today

        If (fechaN > fechaA) Then
            lblEdad.Text = "La fecha es mayor a la fecha actual. ¡Verifique!"
        Else
            lblEdad.Text = "Usted tiene " & DateDiff(DateInterval.Year, fechaN, fechaA) & " años."
            lblMeses.Text = "Desde su nacimiento han transcurrido " & DateDiff(DateInterval.Month, fechaN, fechaA) & " meses"
            lblDias.Text = "y " & DateDiff(DateInterval.Day, fechaN, fechaA) & " días."
        End If
    End Sub
End Class
