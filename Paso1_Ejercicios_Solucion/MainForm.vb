Public Class MainForm
    Public inicio As Inicio = New Inicio()
    Public ejercicio3 As Ejercicio3 = New Ejercicio3()
    Public ejercicio5 As Ejercicio5 = New Ejercicio5()
    Public ejercicio10 As Ejercicio10 = New Ejercicio10()
    Public ejercicio11 As Ejercicio11 = New Ejercicio11()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize(inicio)
        Initialize(ejercicio3)
        Initialize(ejercicio5)
        Initialize(ejercicio10)
        Initialize(Ejercicio11)

        MainPanel.Controls.Add(inicio)
    End Sub

    Private Sub InicioButton_Click(sender As Object, e As EventArgs) Handles InicioButton.Click
        ShowForm(inicio)
    End Sub

    Private Sub Ejercicio3Button_Click(sender As Object, e As EventArgs) Handles Ejercicio3Button.Click
        ShowForm(ejercicio3)
    End Sub

    Private Sub Ejercicio5Button_Click(sender As Object, e As EventArgs) Handles Ejercicio5Button.Click
        ShowForm(ejercicio5)
    End Sub

    Private Sub Ejercicio10Button_Click(sender As Object, e As EventArgs) Handles Ejercicio10Button.Click
        ShowForm(ejercicio10)
    End Sub

    Private Sub Ejercicio11Button_Click(sender As Object, e As EventArgs) Handles Ejercicio11Button.Click
        ShowForm(ejercicio11)
    End Sub

    Private Sub ShowForm(form As UserControl)
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(form)
    End Sub

    Private Sub Initialize(form As UserControl)
        form.Dock = DockStyle.Fill
        form.AutoSize = True
    End Sub
End Class
