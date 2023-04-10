Public Class Login
    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Application.Exit()
    End Sub

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        If txtKulAdi.Text = "" Then
            MsgBox("Kullanıcı Adı Giriniz.", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        If txtSifre.Text = "" Then
            MsgBox("Şifre Giriniz.", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        If txtSifre.Text <> "1" Then
            MsgBox("Şifreniz uyuşmuyor", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        main.Show()
        Me.WindowState = FormWindowState.Minimized



    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKulAdi.Select()
    End Sub
End Class