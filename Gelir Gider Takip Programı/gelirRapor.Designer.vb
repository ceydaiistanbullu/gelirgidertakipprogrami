<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gelirRapor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gelirRapor))
        Me.btnEksi = New System.Windows.Forms.Button()
        Me.btnArti = New System.Windows.Forms.Button()
        Me.cbAy = New System.Windows.Forms.ComboBox()
        Me.cbYil = New System.Windows.Forms.ComboBox()
        Me.btnRapor = New System.Windows.Forms.Button()
        Me.dgGelirler = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Report1 = New FastReport.Report()
        CType(Me.dgGelirler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEksi
        '
        Me.btnEksi.Location = New System.Drawing.Point(27, 24)
        Me.btnEksi.Name = "btnEksi"
        Me.btnEksi.Size = New System.Drawing.Size(50, 23)
        Me.btnEksi.TabIndex = 0
        Me.btnEksi.Text = "-"
        Me.btnEksi.UseVisualStyleBackColor = True
        '
        'btnArti
        '
        Me.btnArti.Location = New System.Drawing.Point(323, 24)
        Me.btnArti.Name = "btnArti"
        Me.btnArti.Size = New System.Drawing.Size(52, 24)
        Me.btnArti.TabIndex = 0
        Me.btnArti.Text = "+"
        Me.btnArti.UseVisualStyleBackColor = True
        '
        'cbAy
        '
        Me.cbAy.FormattingEnabled = True
        Me.cbAy.Items.AddRange(New Object() {"Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"})
        Me.cbAy.Location = New System.Drawing.Point(83, 24)
        Me.cbAy.Name = "cbAy"
        Me.cbAy.Size = New System.Drawing.Size(105, 24)
        Me.cbAy.TabIndex = 1
        '
        'cbYil
        '
        Me.cbYil.FormattingEnabled = True
        Me.cbYil.Location = New System.Drawing.Point(196, 24)
        Me.cbYil.Name = "cbYil"
        Me.cbYil.Size = New System.Drawing.Size(105, 24)
        Me.cbYil.TabIndex = 1
        '
        'btnRapor
        '
        Me.btnRapor.Location = New System.Drawing.Point(393, 24)
        Me.btnRapor.Name = "btnRapor"
        Me.btnRapor.Size = New System.Drawing.Size(89, 24)
        Me.btnRapor.TabIndex = 0
        Me.btnRapor.Text = "Rapor"
        Me.btnRapor.UseVisualStyleBackColor = True
        '
        'dgGelirler
        '
        Me.dgGelirler.AllowUserToAddRows = False
        Me.dgGelirler.AllowUserToDeleteRows = False
        Me.dgGelirler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGelirler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgGelirler.Location = New System.Drawing.Point(27, 89)
        Me.dgGelirler.Name = "dgGelirler"
        Me.dgGelirler.ReadOnly = True
        Me.dgGelirler.RowTemplate.Height = 24
        Me.dgGelirler.Size = New System.Drawing.Size(892, 418)
        Me.dgGelirler.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "GN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.HeaderText = "Gelir Kategorisi"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Açıklama"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Ücret"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column5.HeaderText = "Gün"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 67
        '
        'Report1
        '
        Me.Report1.NeedRefresh = False
        Me.Report1.ReportResourceString = resources.GetString("Report1.ReportResourceString")
        '
        'gelirRapor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 526)
        Me.Controls.Add(Me.dgGelirler)
        Me.Controls.Add(Me.cbYil)
        Me.Controls.Add(Me.cbAy)
        Me.Controls.Add(Me.btnRapor)
        Me.Controls.Add(Me.btnArti)
        Me.Controls.Add(Me.btnEksi)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "gelirRapor"
        Me.Text = "Gelir Raporu"
        CType(Me.dgGelirler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEksi As Button
    Friend WithEvents btnArti As Button
    Friend WithEvents cbAy As ComboBox
    Friend WithEvents cbYil As ComboBox
    Friend WithEvents btnRapor As Button
    Friend WithEvents dgGelirler As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Report1 As FastReport.Report
End Class
