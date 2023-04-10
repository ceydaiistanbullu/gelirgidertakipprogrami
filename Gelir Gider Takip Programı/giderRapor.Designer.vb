<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class giderRapor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(giderRapor))
        Me.dgGiderler = New System.Windows.Forms.DataGridView()
        Me.cbYil = New System.Windows.Forms.ComboBox()
        Me.cbAy = New System.Windows.Forms.ComboBox()
        Me.btnRapor = New System.Windows.Forms.Button()
        Me.btnArti = New System.Windows.Forms.Button()
        Me.btnEksi = New System.Windows.Forms.Button()
        Me.Report1 = New FastReport.Report()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgGiderler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgGiderler
        '
        Me.dgGiderler.AllowUserToAddRows = False
        Me.dgGiderler.AllowUserToDeleteRows = False
        Me.dgGiderler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGiderler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgGiderler.Location = New System.Drawing.Point(25, 92)
        Me.dgGiderler.Name = "dgGiderler"
        Me.dgGiderler.ReadOnly = True
        Me.dgGiderler.RowTemplate.Height = 24
        Me.dgGiderler.Size = New System.Drawing.Size(892, 418)
        Me.dgGiderler.TabIndex = 8
        '
        'cbYil
        '
        Me.cbYil.FormattingEnabled = True
        Me.cbYil.Location = New System.Drawing.Point(193, 26)
        Me.cbYil.Name = "cbYil"
        Me.cbYil.Size = New System.Drawing.Size(105, 24)
        Me.cbYil.TabIndex = 6
        '
        'cbAy
        '
        Me.cbAy.FormattingEnabled = True
        Me.cbAy.Items.AddRange(New Object() {"Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"})
        Me.cbAy.Location = New System.Drawing.Point(81, 26)
        Me.cbAy.Name = "cbAy"
        Me.cbAy.Size = New System.Drawing.Size(105, 24)
        Me.cbAy.TabIndex = 7
        '
        'btnRapor
        '
        Me.btnRapor.Location = New System.Drawing.Point(390, 26)
        Me.btnRapor.Name = "btnRapor"
        Me.btnRapor.Size = New System.Drawing.Size(89, 24)
        Me.btnRapor.TabIndex = 3
        Me.btnRapor.Text = "Rapor"
        Me.btnRapor.UseVisualStyleBackColor = True
        '
        'btnArti
        '
        Me.btnArti.Location = New System.Drawing.Point(320, 26)
        Me.btnArti.Name = "btnArti"
        Me.btnArti.Size = New System.Drawing.Size(52, 24)
        Me.btnArti.TabIndex = 4
        Me.btnArti.Text = "+"
        Me.btnArti.UseVisualStyleBackColor = True
        '
        'btnEksi
        '
        Me.btnEksi.Location = New System.Drawing.Point(25, 26)
        Me.btnEksi.Name = "btnEksi"
        Me.btnEksi.Size = New System.Drawing.Size(50, 23)
        Me.btnEksi.TabIndex = 5
        Me.btnEksi.Text = "-"
        Me.btnEksi.UseVisualStyleBackColor = True
        '
        'Report1
        '
        Me.Report1.NeedRefresh = False
        Me.Report1.ReportResourceString = resources.GetString("Report1.ReportResourceString")
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "KN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 58
        '
        'Column2
        '
        Me.Column2.HeaderText = "Gider Kategorisi"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 155
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
        'giderRapor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 540)
        Me.Controls.Add(Me.dgGiderler)
        Me.Controls.Add(Me.cbYil)
        Me.Controls.Add(Me.cbAy)
        Me.Controls.Add(Me.btnRapor)
        Me.Controls.Add(Me.btnArti)
        Me.Controls.Add(Me.btnEksi)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "giderRapor"
        Me.Text = "Gider Raporu"
        CType(Me.dgGiderler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgGiderler As DataGridView
    Friend WithEvents cbYil As ComboBox
    Friend WithEvents cbAy As ComboBox
    Friend WithEvents btnRapor As Button
    Friend WithEvents btnArti As Button
    Friend WithEvents btnEksi As Button
    Friend WithEvents Report1 As FastReport.Report
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
