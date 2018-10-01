Public Class Ejercicio1_Miguel
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAzul.CheckedChanged
        If rbtAzul.Checked = True Then
            lblTexto.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub rbtRojo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRojo.CheckedChanged
        If rbtRojo.Checked = True Then
            lblTexto.ForeColor = Color.Red
        End If
    End Sub

    Private Sub rbtAmarillo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAmarillo.CheckedChanged
        If rbtAmarillo.Checked = True Then
            lblTexto.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub rbtVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rbtVerde.CheckedChanged
        If rbtVerde.Checked = True Then
            lblTexto.ForeColor = Color.Green
        End If
    End Sub
End Class
