Public Class Ejercicio4_Alex
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Txt_t.Text = ""
        Lbl_h.Text = ""
        Txt_Vi.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Lbl_h.Text = Val(Txt_Vi.Text * Val(Txt_t.Text)) + 0.5 * Val(10 * Val(Txt_t.Text) ^ 2)
    End Sub
End Class
