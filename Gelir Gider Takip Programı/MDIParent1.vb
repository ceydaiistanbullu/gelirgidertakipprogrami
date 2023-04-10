Imports System.Windows.Forms

Public Class main


    Private m_ChildFormNumber As Integer

    Private Sub HesapHareketleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HesapHareketleriToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()


    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Application.Exit()
    End Sub



    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GelirRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GelirRaporuToolStripMenuItem.Click
        gelirRapor.MdiParent = Me
        gelirRapor.Show()

    End Sub

    Private Sub GiderRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiderRaporuToolStripMenuItem.Click
        giderRapor.MdiParent = Me
        giderRapor.Show()
    End Sub
End Class
