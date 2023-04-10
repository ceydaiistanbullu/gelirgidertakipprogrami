<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGelirAra = New System.Windows.Forms.TextBox()
        Me.dgGelir = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgGider = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GideriSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtGiderAra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbBakiye = New System.Windows.Forms.Label()
        Me.btnGelirEkle = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnGiderEkle = New System.Windows.Forms.Button()
        Me.lbGelir = New System.Windows.Forms.Label()
        Me.lbGider = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgGelir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgGider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gelir Ara  :"
        '
        'txtGelirAra
        '
        Me.txtGelirAra.Location = New System.Drawing.Point(153, 15)
        Me.txtGelirAra.Name = "txtGelirAra"
        Me.txtGelirAra.Size = New System.Drawing.Size(345, 22)
        Me.txtGelirAra.TabIndex = 2
        '
        'dgGelir
        '
        Me.dgGelir.AllowUserToAddRows = False
        Me.dgGelir.AllowUserToDeleteRows = False
        Me.dgGelir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGelir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5})
        Me.dgGelir.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgGelir.Location = New System.Drawing.Point(45, 107)
        Me.dgGelir.Name = "dgGelir"
        Me.dgGelir.ReadOnly = True
        Me.dgGelir.RowTemplate.Height = 24
        Me.dgGelir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGelir.Size = New System.Drawing.Size(639, 360)
        Me.dgGelir.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Gelir No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kategori"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "Tarih"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Miktar"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Açıklama"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SilToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 28)
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.SilToolStripMenuItem.Text = "Geliri Sil"
        '
        'dgGider
        '
        Me.dgGider.AllowUserToAddRows = False
        Me.dgGider.AllowUserToDeleteRows = False
        Me.dgGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGider.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column8, Me.Column7, Me.Column9, Me.Column10})
        Me.dgGider.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dgGider.Location = New System.Drawing.Point(747, 107)
        Me.dgGider.Name = "dgGider"
        Me.dgGider.ReadOnly = True
        Me.dgGider.RowTemplate.Height = 24
        Me.dgGider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGider.Size = New System.Drawing.Size(639, 360)
        Me.dgGider.TabIndex = 3
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column6.HeaderText = "Gider No"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 102
        '
        'Column8
        '
        Me.Column8.HeaderText = "Kategori"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column7.HeaderText = "Tarih"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 75
        '
        'Column9
        '
        Me.Column9.HeaderText = "Miktar"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "Açıklama"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GideriSilToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(139, 28)
        '
        'GideriSilToolStripMenuItem
        '
        Me.GideriSilToolStripMenuItem.Name = "GideriSilToolStripMenuItem"
        Me.GideriSilToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.GideriSilToolStripMenuItem.Text = "Gideri Sil"
        '
        'txtGiderAra
        '
        Me.txtGiderAra.Location = New System.Drawing.Point(881, 10)
        Me.txtGiderAra.Name = "txtGiderAra"
        Me.txtGiderAra.Size = New System.Drawing.Size(345, 22)
        Me.txtGiderAra.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(767, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gider Ara  :"
        '
        'lbBakiye
        '
        Me.lbBakiye.AutoSize = True
        Me.lbBakiye.Location = New System.Drawing.Point(42, 588)
        Me.lbBakiye.Name = "lbBakiye"
        Me.lbBakiye.Size = New System.Drawing.Size(71, 17)
        Me.lbBakiye.TabIndex = 5
        Me.lbBakiye.Text = "Bakiye  :"
        '
        'btnGelirEkle
        '
        Me.btnGelirEkle.Location = New System.Drawing.Point(536, 545)
        Me.btnGelirEkle.Name = "btnGelirEkle"
        Me.btnGelirEkle.Size = New System.Drawing.Size(148, 30)
        Me.btnGelirEkle.TabIndex = 6
        Me.btnGelirEkle.Text = "Gelir Ekle"
        Me.btnGelirEkle.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(0, 0)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnGiderEkle
        '
        Me.btnGiderEkle.Location = New System.Drawing.Point(1238, 545)
        Me.btnGiderEkle.Name = "btnGiderEkle"
        Me.btnGiderEkle.Size = New System.Drawing.Size(148, 30)
        Me.btnGiderEkle.TabIndex = 8
        Me.btnGiderEkle.Text = "Gider Ekle"
        Me.btnGiderEkle.UseVisualStyleBackColor = True
        '
        'lbGelir
        '
        Me.lbGelir.AutoSize = True
        Me.lbGelir.Location = New System.Drawing.Point(608, 487)
        Me.lbGelir.Name = "lbGelir"
        Me.lbGelir.Size = New System.Drawing.Size(41, 17)
        Me.lbGelir.TabIndex = 9
        Me.lbGelir.Text = "0 TL"
        '
        'lbGider
        '
        Me.lbGider.AutoSize = True
        Me.lbGider.Location = New System.Drawing.Point(1310, 487)
        Me.lbGider.Name = "lbGider"
        Me.lbGider.Size = New System.Drawing.Size(41, 17)
        Me.lbGider.TabIndex = 10
        Me.lbGider.Text = "0 TL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(458, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(469, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Gelir Ve Gider Aramalarınızı sadece Miktara göre yapabilirsiniz."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1519, 716)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbGider)
        Me.Controls.Add(Me.lbGelir)
        Me.Controls.Add(Me.btnGiderEkle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGelirEkle)
        Me.Controls.Add(Me.lbBakiye)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgGider)
        Me.Controls.Add(Me.dgGelir)
        Me.Controls.Add(Me.txtGiderAra)
        Me.Controls.Add(Me.txtGelirAra)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form1"
        Me.Text = "Hesap Hareketleri"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgGelir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgGider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGelirAra As TextBox
    Friend WithEvents dgGelir As DataGridView
    Friend WithEvents dgGider As DataGridView
    Friend WithEvents txtGiderAra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbBakiye As Label
    Friend WithEvents btnGelirEkle As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnGiderEkle As Button
    Friend WithEvents lbGelir As Label
    Friend WithEvents lbGider As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents GideriSilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
End Class
