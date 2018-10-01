Public Class Ejercicio6_Alex
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        LstNumeros.Items.Add(TxtIngresar.Text)
    End Sub

    Private Sub BtnContar_Click(sender As Object, e As EventArgs) Handles BtnContar.Click
        TxtCuenta.Text = LstNumeros.Items.Count.ToString()
    End Sub
End Class
