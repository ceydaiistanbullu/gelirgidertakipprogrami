<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gelirKategori
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
        Me.components = New System.ComponentModel.Container()
        Me.dgKategori = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KategoriyiSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        CType(Me.dgKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgKategori
        '
        Me.dgKategori.AllowUserToAddRows = False
        Me.dgKategori.AllowUserToDeleteRows = False
        Me.dgKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKategori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgKategori.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgKategori.Location = New System.Drawing.Point(66, 10)
        Me.dgKategori.Name = "dgKategori"
        Me.dgKategori.ReadOnly = True
        Me.dgKategori.RowTemplate.Height = 24
        Me.dgKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgKategori.Size = New System.Drawing.Size(369, 282)
        Me.dgKategori.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Kategori No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 123
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Kategori Adı"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KategoriyiSilToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(176, 56)
        '
        'KategoriyiSilToolStripMenuItem
        '
        Me.KategoriyiSilToolStripMenuItem.Name = "KategoriyiSilToolStripMenuItem"
        Me.KategoriyiSilToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.KategoriyiSilToolStripMenuItem.Text = "Kategoriyi Sil"
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(197, 310)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(183, 22)
        Me.txtKategori.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Kategori Adı :"
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(103, 346)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(128, 30)
        Me.btnEkle.TabIndex = 7
        Me.btnEkle.Text = "Kategori Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'btnKapat
        '
        Me.btnKapat.Location = New System.Drawing.Point(292, 346)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(128, 30)
        Me.btnKapat.TabIndex = 6
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = True
        '
        'gelirKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 411)
        Me.Controls.Add(Me.dgKategori)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.btnKapat)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "gelirKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gelir Kategorisi"
        CType(Me.dgKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgKategori As DataGridView
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnKapat As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents KategoriyiSilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
