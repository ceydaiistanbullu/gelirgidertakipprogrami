Public Class giderKategori

    Public Sub KategoriGetir()
        Dim dt As DataTable = dtGetir("select * from giderKategorisi")

        For i = 0 To dt.Rows.Count - 1
            dgKategori.Rows.Add(dt.Rows(i)("KategoriNo").ToString(), dt.Rows(i)("KategoriAdi").ToString())
        Next
    End Sub

    Private Sub giderKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KategoriGetir()
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
        GiderEkle.Show()
    End Sub

    Private Sub KategoriyiSilToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim KategoriNo = Convert.ToInt32(dgKategori.CurrentRow.Cells(0).Value.ToString())

        Dim kategoriAdı As String = dgKategori.CurrentRow.Cells(1).Value.ToString()

        If MsgBox(kategoriAdı & " Kategorisini Siliyorum! Onaylıyor musunuz?", vbYesNo, "Silme Onayı") = MsgBoxResult.No Then
            Return
        End If

        sqlCalistir("delete from giderKategorisi where KategoriNo=" & KategoriNo)
        MsgBox("Kategori Silindi!", MsgBoxStyle.Information, "İşlem Tamam.")
        dgKategori.Rows.Clear()
        KategoriGetir()
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If txtKategori.Text = "" Then
            MsgBox("Kategori Belirtiniz.", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        sqlCalistir("insert into giderKategorisi (KategoriAdi) values ('" & txtKategori.Text & "')")
        dgKategori.Rows.Clear()
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If

        Next
        KategoriGetir()


    End Sub

    Private Sub KategoriyiSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriyiSilToolStripMenuItem.Click
        Dim KategoriNo = Convert.ToInt32(dgKategori.CurrentRow.Cells(0).Value.ToString())

        Dim kategoriAdı As String = dgKategori.CurrentRow.Cells(1).Value.ToString()

        If MsgBox(kategoriAdı & " Kategorisini Siliyorum! Onaylıyor musunuz?", vbYesNo, "Silme Onayı") = MsgBoxResult.No Then
            Return
        End If

        sqlCalistir("delete from giderKategorisi where KategoriNo=" & KategoriNo)
        MsgBox("Kategori Silindi!", MsgBoxStyle.Information, "İşlem Tamam.")
        dgKategori.Rows.Clear()
        KategoriGetir()
    End Sub
End Class