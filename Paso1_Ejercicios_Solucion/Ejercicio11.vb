Public Class Ejercicio11
    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click
        Dim birth As Date = BirthDate.Value
        Dim diff As TimeSpan = Now - BirthDate.Value.Date
        Dim months As Integer = (Now.Year - birth.Year) * 12 + Now.Month - birth.Month
        DayLabel.Text = Int(diff.TotalDays).ToString()
        MonthLabel.Text = months.ToString()
        YearLabel.Text = Int(months / 12).ToString()
    End Sub
End Class
