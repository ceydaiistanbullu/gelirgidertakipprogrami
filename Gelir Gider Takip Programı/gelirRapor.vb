Public Class gelirRapor
    Private Sub gelirRapor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 2018 To Now.Year + 2
            cbYil.Items.Add(i.ToString())
        Next
        cbAy.SelectedIndex = Now.Month - 1
        cbYil.Text = Now.Year
        gelirGetir()
    End Sub
    Sub gelirGetir()
        Dim ay As Integer = cbAy.SelectedIndex + 1
        Dim yil As Integer = Convert.ToInt32(cbYil.Text)
        Dim dt As DataTable = dtGetir("select * from gelir,gelirKategorisi where gelirKategorisi.KategoriNo=gelir.KategoriNo And Ay = " & ay & " And Yil = " & yil)
        dgGelirler.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgGelirler.Rows.Add(dt.Rows(i)("GelirNo").ToString(),
           dt.Rows(i)("KategoriAdi").ToString(), dt.Rows(i)("Aciklama").ToString(),
           dt.Rows(i)("Miktar").ToString(), dt.Rows(i)("Gun").ToString())
        Next
    End Sub

    Private Sub btnArti_Click(sender As Object, e As EventArgs) Handles btnArti.Click
        Dim ay As Integer = cbAy.SelectedIndex + 1
        Dim yil As Integer = Convert.ToInt32(cbYil.Text)
        If ay = 12 Then
            ay = 1
            yil += 1
        Else
            ay += 1
        End If
        cbYil.Text = yil.ToString()
        cbAy.SelectedIndex = ay - 1
        dgGelirler.Rows.Clear()
        gelirGetir()
    End Sub

    Private Sub btnEksi_Click(sender As Object, e As EventArgs) Handles btnEksi.Click
        Dim ay As Integer = cbAy.SelectedIndex + 1
        Dim yil As Integer = Convert.ToInt32(cbYil.Text)
        If ay = 1 Then
            ay = 12
            yil -= 1
        Else
            ay -= 1
        End If
        cbAy.SelectedIndex = ay - 1
        cbYil.Text = yil.ToString()
        gelirGetir()
    End Sub

    Private Sub cbYil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYil.SelectedIndexChanged
        If cbYil.Text <> "" Then
            gelirGetir()
        End If
    End Sub

    Private Sub cbAy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAy.SelectedIndexChanged
        If cbYil.Text <> "" Then
            gelirGetir()
        End If
    End Sub

    Private Sub btnRapor_Click(sender As Object, e As EventArgs) Handles btnRapor.Click
        Dim ay As Integer = cbAy.SelectedIndex + 1
        Dim yil As Integer = Convert.ToInt32(cbYil.Text)
        Dim ds As DataSet = dsGetir("select * from gelir,gelirKategorisi where gelirKategorisi.KategoriNo=gelir.KategoriNo  And Ay = " & ay & " And Yil = " & yil)
        Report1.Load(Application.StartupPath & "/gelirRapor.frx")
        Report1.SetParameterValue("gelirTarih", cbAy.Text & " " & yil.ToString())
        Dim bnt As FastReport.DataBand = Report1.FindObject("data1")
        Report1.RegisterData(ds)
        Report1.GetDataSource("tb").Enabled = True
        bnt.DataSource = Report1.GetDataSource("tb")

        Report1.Prepare()
        Report1.ShowPrepared()
    End Sub
End Class