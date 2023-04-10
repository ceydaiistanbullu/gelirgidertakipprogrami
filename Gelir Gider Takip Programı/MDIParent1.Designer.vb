<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HesapHareketleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaporlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GelirRaporuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiderRaporuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HesapHareketleriToolStripMenuItem, Me.RaporlarToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1253, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HesapHareketleriToolStripMenuItem
        '
        Me.HesapHareketleriToolStripMenuItem.Name = "HesapHareketleriToolStripMenuItem"
        Me.HesapHareketleriToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.HesapHareketleriToolStripMenuItem.Text = "Hesap Hareketleri"
        '
        'RaporlarToolStripMenuItem
        '
        Me.RaporlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GelirRaporuToolStripMenuItem, Me.GiderRaporuToolStripMenuItem})
        Me.RaporlarToolStripMenuItem.Name = "RaporlarToolStripMenuItem"
        Me.RaporlarToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.RaporlarToolStripMenuItem.Text = " Raporlar"
        '
        'GelirRaporuToolStripMenuItem
        '
        Me.GelirRaporuToolStripMenuItem.Name = "GelirRaporuToolStripMenuItem"
        Me.GelirRaporuToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.GelirRaporuToolStripMenuItem.Text = "Gelir Raporu"
        '
        'GiderRaporuToolStripMenuItem
        '
        Me.GiderRaporuToolStripMenuItem.Name = "GiderRaporuToolStripMenuItem"
        Me.GiderRaporuToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.GiderRaporuToolStripMenuItem.Text = "Gider Raporu"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.ÇıkışToolStripMenuItem.Text = " Çıkış"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 632)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "main"
        Me.Text = "Gelir Gider Takip Programı v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HesapHareketleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RaporlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelirRaporuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiderRaporuToolStripMenuItem As ToolStripMenuItem
End Class
