Public Class Ejercicio2_Alex

    Public nombre, apellido, edad, telefono, cadena

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        nombre = Txtb_Nombre.Text
        apellido = Txtb_Apellido.Text
        edad = Txtb_Edad.Text
        telefono = Txtb_telefono.Text

        cadena = nombre & " " & apellido & " " & edad & " " & telefono

        Lstb_Usuarios.Items.Add(cadena)
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Lstb_Usuarios.Items.RemoveAt(Lstb_Usuarios.SelectedIndex())
    End Sub
End Class
