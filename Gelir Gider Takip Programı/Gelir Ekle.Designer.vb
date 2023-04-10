<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gelir_Ekle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMiktar = New System.Windows.Forms.TextBox()
        Me.txtAciklama = New System.Windows.Forms.TextBox()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtTarih = New System.Windows.Forms.DateTimePicker()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.btnKatEkle = New System.Windows.Forms.Button()
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gelir Ekle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Miktar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Açıklama"
        '
        'txtMiktar
        '
        Me.txtMiktar.Location = New System.Drawing.Point(144, 119)
        Me.txtMiktar.Name = "txtMiktar"
        Me.txtMiktar.Size = New System.Drawing.Size(168, 22)
        Me.txtMiktar.TabIndex = 5
        '
        'txtAciklama
        '
        Me.txtAciklama.Location = New System.Drawing.Point(144, 154)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(345, 106)
        Me.txtAciklama.TabIndex = 6
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(170, 287)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(97, 32)
        Me.btnKaydet.TabIndex = 7
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'btnKapat
        '
        Me.btnKapat.Location = New System.Drawing.Point(337, 287)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(97, 32)
        Me.btnKapat.TabIndex = 8
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tarih"
        '
        'dtTarih
        '
        Me.dtTarih.Location = New System.Drawing.Point(144, 88)
        Me.dtTarih.Name = "dtTarih"
        Me.dtTarih.Size = New System.Drawing.Size(200, 22)
        Me.dtTarih.TabIndex = 9
        '
        'cbKategori
        '
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Location = New System.Drawing.Point(144, 56)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(200, 24)
        Me.cbKategori.TabIndex = 10
        '
        'btnKatEkle
        '
        Me.btnKatEkle.Location = New System.Drawing.Point(369, 52)
        Me.btnKatEkle.Name = "btnKatEkle"
        Me.btnKatEkle.Size = New System.Drawing.Size(120, 30)
        Me.btnKatEkle.TabIndex = 24
        Me.btnKatEkle.Text = "Kategori Ekle"
        Me.btnKatEkle.UseVisualStyleBackColor = True
        '
        'btnTemizle
        '
        Me.btnTemizle.Location = New System.Drawing.Point(369, 117)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(100, 31)
        Me.btnTemizle.TabIndex = 25
        Me.btnTemizle.Text = "Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = True
        '
        'Gelir_Ekle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 357)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.btnKatEkle)
        Me.Controls.Add(Me.cbKategori)
        Me.Controls.Add(Me.dtTarih)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.txtAciklama)
        Me.Controls.Add(Me.txtMiktar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Gelir_Ekle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gelir Ekle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMiktar As TextBox
    Friend WithEvents txtAciklama As TextBox
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnKapat As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtTarih As DateTimePicker
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents btnKatEkle As Button
    Friend WithEvents btnTemizle As Button
End Class
