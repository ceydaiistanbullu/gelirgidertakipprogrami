Public Class Form1
    Private Sub btnGelirEkle_Click(sender As Object, e As EventArgs) Handles btnGelirEkle.Click
        Me.Close()
        Gelir_Ekle.Show()
    End Sub

    Private Sub btnGiderEkle_Click(sender As Object, e As EventArgs) Handles btnGiderEkle.Click
        GiderEkle.Show()
        Me.Close()
    End Sub

    Private Sub dgGelir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGelir.CellContentClick

    End Sub
    Sub BakiyeHesapla()
        Dim gelir As Double = 0
        For i = 0 To dgGelir.RowCount - 1
            gelir += dgGelir.Rows(i).Cells(3).Value
        Next
        lbGelir.Text = gelir.ToString("0.00 TL")


        Dim gider As Double = 0
        For i = 0 To dgGider.RowCount - 1
            gider += dgGider.Rows(i).Cells(3).Value
        Next
        lbGider.Text = gider.ToString("0.00 TL")


        Dim bakiye As Double = gelir - gider
        lbBakiye.Text = "Bakiye : " & bakiye.ToString("0.00 TL")
        If bakiye < 0 Then
            lbBakiye.ForeColor = Color.Red
        Else
            lbBakiye.ForeColor = Color.Green
        End If

    End Sub
    Public Sub gelirgetir()
        Dim dt As DataTable = dtGetir("select * from gelir,gelirKategorisi where gelirKategorisi.KategoriNo=gelir.KategoriNo")

        For i = 0 To dt.Rows.Count - 1
            dgGelir.Rows.Add(dt.Rows(i)("GelirNo").ToString(), dt.Rows(i)("KategoriAdi").ToString(), dt.Rows(i)("Gun").ToString() & "." & dt.Rows(i)("Ay").ToString() & "." & dt.Rows(i)("Yil").ToString(), dt.Rows(i)("Miktar").ToString(), dt.Rows(i)("Aciklama").ToString())
        Next
    End Sub
    Sub gidergetir()
        Dim ds As DataTable = dtGetir("select * from gider,giderKategorisi where giderKategorisi.KategoriNo=gider.KategoriNo")
        For i = 0 To ds.Rows.Count - 1
            dgGider.Rows.Add(ds.Rows(i)("GiderNo").ToString(), ds.Rows(i)("KategoriAdi").ToString(), ds.Rows(i)("Gun").ToString() & "." & ds.Rows(i)("Ay").ToString() & "." & ds.Rows(i)("Yil").ToString(), ds.Rows(i)("Miktar").ToString(), ds.Rows(i)("Aciklama").ToString())
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gelirgetir()
        gidergetir()
        BakiyeHesapla()






    End Sub

    Private Sub txtGelirAra_TextChanged(sender As Object, e As EventArgs) Handles txtGelirAra.TextChanged

        dgGelir.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from gelirKategorisi,gelir where gelirKategorisi.KategoriNo=gelir.KategoriNo and Miktar like '%" & txtGelirAra.Text & "%' order by Miktar")
        For i = 0 To dt.Rows.Count - 1
            dgGelir.Rows.Add(dt.Rows(i)("GelirNo").ToString(), dt.Rows(i)("KategoriAdi").ToString(), dt.Rows(i)("Gun").ToString() & "." & dt.Rows(i)("Ay").ToString() & "." & dt.Rows(i)("Yil").ToString(), dt.Rows(i)("Miktar").ToString(), dt.Rows(i)("Aciklama").ToString())
        Next



    End Sub

    Private Sub txtGiderAra_TextChanged(sender As Object, e As EventArgs) Handles txtGiderAra.TextChanged
        dgGider.Rows.Clear()
        Dim ds As DataTable = dtGetir("select * from gider,giderKategorisi where giderKategorisi.KategoriNo=gider.KategoriNo and Miktar like '%" & txtGiderAra.Text & "%' order by Miktar")
        For i = 0 To ds.Rows.Count - 1
            dgGider.Rows.Add(ds.Rows(i)("GiderNo").ToString(), ds.Rows(i)("KategoriAdi").ToString(), ds.Rows(i)("Gun").ToString() & "." & ds.Rows(i)("Ay").ToString() & "." & ds.Rows(i)("Yil").ToString(), ds.Rows(i)("Miktar").ToString(), ds.Rows(i)("Aciklama").ToString())
        Next
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Dim gelirNo = Convert.ToInt32(dgGelir.CurrentRow.Cells(0).Value.ToString())

        Dim kategoriAdı As String = dgGelir.CurrentRow.Cells(1).Value.ToString()

        If MsgBox(kategoriAdı & " Kategorisindeki Geliri Siliyorum! Onaylıyor musunuz?", vbYesNo, "Silme Onayı") = MsgBoxResult.No Then
            Return
        End If

        sqlCalistir("delete from gelir where GelirNo=" & gelirNo)
        MsgBox("Gelir Silindi!", MsgBoxStyle.Information, "İşlem Tamam.")
        dgGelir.Rows.Clear()
        gelirgetir()
        BakiyeHesapla()
    End Sub

    Private Sub GideriSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GideriSilToolStripMenuItem.Click
        Dim giderNo = Convert.ToInt32(dgGider.CurrentRow.Cells(0).Value.ToString())

        Dim kategoriAdı As String = dgGider.CurrentRow.Cells(1).Value.ToString()

        If MsgBox(kategoriAdı & " Kategorisindeki Gideri Siliyorum! Onaylıyor musunuz?", vbYesNo, "Silme Onayı") = MsgBoxResult.No Then
            Return
        End If

        sqlCalistir("delete from gider where GiderNo=" & giderNo)
        MsgBox("Gider Silindi!", MsgBoxStyle.Information, "İşlem Tamam.")
        dgGider.Rows.Clear()
        gidergetir()
        BakiyeHesapla()
    End Sub
End Class
