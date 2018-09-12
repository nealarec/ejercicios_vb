Public Class MainForm
    Public inicio As Inicio = New Inicio()
    Public ejercicio3 As Ejercicio3 = New Ejercicio3()
    Public ejercicio5 As Ejercicio5 = New Ejercicio5()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize(inicio)
        Initialize(ejercicio3)
        Initialize(ejercicio5)

        MainPanel.Controls.Add(inicio)
    End Sub

    Private Sub InicioButton_Click(sender As Object, e As EventArgs) Handles InicioButton.Click
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(inicio)
    End Sub

    Private Sub Ejercicio3Button_Click(sender As Object, e As EventArgs) Handles Ejercicio3Button.Click
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(ejercicio3)
    End Sub

    Private Sub Ejercicio5Button_Click(sender As Object, e As EventArgs) Handles Ejercicio5Button.Click
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(ejercicio5)
    End Sub

    Private Sub Initialize(form As UserControl)
        form.Dock = DockStyle.Fill
        form.AutoSize = True
    End Sub
End Class
