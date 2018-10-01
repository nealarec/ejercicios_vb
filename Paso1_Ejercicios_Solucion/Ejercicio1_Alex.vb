Public Class Ejercicio1_Alex
    Dim strcolor As String
    Dim strcolor2 As String
    Dim strcolor3 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Label4.ForeColor = Color.Yellow
        End If

        If RadioButton2.Checked = True Then
            Label4.ForeColor = Color.Blue
        End If

        If RadioButton3.Checked = True Then
            Label4.ForeColor = Color.Red
        End If
    End Sub
End Class
