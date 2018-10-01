Public Class MainForm

    Private Sub ShowForm(form As UserControl)
        form.Dock = DockStyle.Fill
        form.AutoSize = True
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(form)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowForm(New Inicio)
    End Sub

    Private Sub InicioButton_Click(sender As Object, e As EventArgs) Handles InicioButton.Click
        ShowForm(New Inicio)
    End Sub

    Private Sub Ejerc1AlexButton_Click(sender As Object, e As EventArgs)
        ShowForm(New Ejercicio1_Alex)
    End Sub

    Private Sub Ejerc1MiguelButton_Click(sender As Object, e As EventArgs)
        ShowForm(New Ejercicio1_Miguel)
    End Sub

    Private Sub Ejercicio3Button_Click(sender As Object, e As EventArgs) Handles Ejercicio3Button.Click
        ShowForm(New Ejercicio3_Nelson)
    End Sub

    Private Sub Ejercicio5Button_Click(sender As Object, e As EventArgs) Handles Ejercicio5Button.Click
        ShowForm(New Ejercicio5_Nelson)
    End Sub

    Private Sub Ejerc2MiguelButton_Click(sender As Object, e As EventArgs) Handles Ejerc2MiguelButton.Click
        ShowForm(New Ejercicio2_Miguel)
    End Sub

    Private Sub Ejerc2AlexButton_Click(sender As Object, e As EventArgs) Handles Ejerc2AlexButton.Click
        ShowForm(New Ejercicio2_Alex)
    End Sub

    Private Sub Ejercicio4Button_Click(sender As Object, e As EventArgs) Handles Ejercicio4Button.Click
        ShowForm(New Ejercicio4_Alex)
    End Sub

    Private Sub Ejerc6EddieButton_Click(sender As Object, e As EventArgs) Handles Ejerc6EddieButton.Click
        ShowForm(New Ejercicio6_Eddie)
    End Sub

    Private Sub Ejerc6AndresButton_Click(sender As Object, e As EventArgs) Handles Ejerc6AlexButton.Click
        ShowForm(New Ejercicio6_Alex)
    End Sub

    Private Sub Ejercicio7Button_Click(sender As Object, e As EventArgs) Handles Ejercicio7Button.Click
        ShowForm(New Ejercicio7_Eddie)
    End Sub

    Private Sub Ejerci8AndresButton_Click(sender As Object, e As EventArgs) Handles Ejerci8AndresButton.Click
        ShowForm(New Ejercicio8_Andres)
    End Sub

    Private Sub Ejercicio8EddieButton_Click(sender As Object, e As EventArgs) Handles Ejercicio8EddieButton.Click
        ShowForm(New Ejercicio8_Eddie)
    End Sub

    Private Sub Ejericio9Button_Click(sender As Object, e As EventArgs) Handles Ejericio9Button.Click
        ShowForm(New Ejercicio9_Andres)
    End Sub

    Private Sub Ejerc10AndresButton_Click(sender As Object, e As EventArgs) Handles Ejerc10AndresButton.Click
        ShowForm(New Ejercicio10_Andres)
    End Sub

    Private Sub Ejerc10NelsonButton_Click(sender As Object, e As EventArgs) Handles Ejerc10NelsonButton.Click
        ShowForm(New Ejercicio10_Nelson)
    End Sub

    Private Sub Ejercicio11AndresButton_Click(sender As Object, e As EventArgs) Handles Ejercicio11AndresButton.Click
        ShowForm(New Ejercicio11_Andres)
    End Sub

    Private Sub Ejercicio11NelsonButton_Click(sender As Object, e As EventArgs) Handles Ejercicio11NelsonButton.Click
        ShowForm(New Ejercicio11_Nelson)
    End Sub

    Private Sub Ejercicios12Button_Click(sender As Object, e As EventArgs) Handles Ejercicios12Button.Click
        ShowForm(New Ejercicio12_Eddie)
    End Sub
End Class
