Public Class GiderEkle
    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub cbBaslik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKategori.SelectedIndexChanged

    End Sub

    Private Sub GiderEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbKategori.DisplayMember = "KategoriAdi"
        cbKategori.ValueMember = "KategoriNo"
        cbKategori.DataSource = dtGetir("select * from giderKategorisi")
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click

        Dim gun As Integer = dtTarih.Value.Day
        Dim ay As Integer = dtTarih.Value.Month
        Dim yil As Integer = dtTarih.Value.Year
        Dim miktar As Integer = Convert.ToInt32(txtMiktar.Text)
        Dim kategoriNo As Integer = cbKategori.SelectedValue

        sqlCalistir("insert into gider (KategoriNo,Gun,Ay,Yil,Miktar,Aciklama) values (" & kategoriNo & "," & gun & "," & ay & "," & yil & "," & miktar & ",'" & txtAciklama.Text & "')")



        MsgBox("Gider Kaydı Yapılmıştır", MsgBoxStyle.Information, "İşlem Tamam")
        btnTemizle.PerformClick()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If

        Next
    End Sub

    Private Sub btnBasEkle_Click(sender As Object, e As EventArgs) Handles btnKatEkle.Click
        Me.Close()
        giderKategori.Show()


    End Sub
End Class