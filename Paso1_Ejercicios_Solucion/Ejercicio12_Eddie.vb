Public Class Ejercicio12_Eddie
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles pbxCuentosMin.MouseHover
        pbxCuentos.Visible = True
        My.Computer.Audio.Play(My.Resources.Cuentos_de_los_hermanos, AudioPlayMode.Background)
        lblBienvenido.Visible = False
        lblInfo.Visible = False
        wmIntro.Visible = False
        wmIntro.Ctlcontrols.stop()

    End Sub

    Private Sub pbxCuentos_MouseLeave(sender As Object, e As EventArgs) Handles pbxCuentosMin.MouseLeave
        pbxCuentos.Visible = False
        My.Computer.Audio.Stop()
        lblBienvenido.Visible = True
        lblInfo.Visible = True
        wmIntro.Visible = True
        wmIntro.Ctlcontrols.play()
    End Sub

    Private Sub pbxDragonzM_MouseHover(sender As Object, e As EventArgs) Handles pbxDragonzM.MouseHover
        pbxDragonZ.Visible = True
        My.Computer.Audio.Play(My.Resources.DragonZ, AudioPlayMode.Background)
        lblBienvenido.Visible = False
        lblInfo.Visible = False
        wmIntro.Visible = False
        wmIntro.Ctlcontrols.stop()
    End Sub

    Private Sub pbxDragonzM_MouseLeave(sender As Object, e As EventArgs) Handles pbxDragonzM.MouseLeave
        pbxDragonZ.Visible = False
        My.Computer.Audio.Stop()
        lblBienvenido.Visible = True
        lblInfo.Visible = True
        wmIntro.Visible = True
        wmIntro.Ctlcontrols.play()
    End Sub

    Private Sub pbxSantM_MouseHover(sender As Object, e As EventArgs) Handles pbxSantM.MouseHover
        pbxSaintZ.Visible = True
        My.Computer.Audio.Play(My.Resources.SaintZaiya, AudioPlayMode.Background)
        lblBienvenido.Visible = False
        lblInfo.Visible = False
        wmIntro.Visible = False
        wmIntro.Ctlcontrols.stop()
    End Sub

    Private Sub pbxSantM_MouseLeave(sender As Object, e As EventArgs) Handles pbxSantM.MouseLeave
        pbxSaintZ.Visible = False
        My.Computer.Audio.Stop()
        lblBienvenido.Visible = True
        lblInfo.Visible = True
        wmIntro.Visible = True
        wmIntro.Ctlcontrols.play()
    End Sub
End Class
