<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAMASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahDiagnosaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahPertanyaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGNOSAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.DATAMASTERToolStripMenuItem, Me.DIAGNOSAToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(707, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.ToolStripMenuItem1.Text = "FILE"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem1
        '
        Me.KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        Me.KeluarToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem1.Text = "Keluar"
        '
        'DATAMASTERToolStripMenuItem
        '
        Me.DATAMASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahUserToolStripMenuItem, Me.TambahDiagnosaToolStripMenuItem, Me.TambahPertanyaanToolStripMenuItem})
        Me.DATAMASTERToolStripMenuItem.Name = "DATAMASTERToolStripMenuItem"
        Me.DATAMASTERToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.DATAMASTERToolStripMenuItem.Text = "DATA MASTER"
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TambahUserToolStripMenuItem.Text = "Tambah User"
        '
        'TambahDiagnosaToolStripMenuItem
        '
        Me.TambahDiagnosaToolStripMenuItem.Name = "TambahDiagnosaToolStripMenuItem"
        Me.TambahDiagnosaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TambahDiagnosaToolStripMenuItem.Text = "Tambah Diagnosa"
        '
        'TambahPertanyaanToolStripMenuItem
        '
        Me.TambahPertanyaanToolStripMenuItem.Name = "TambahPertanyaanToolStripMenuItem"
        Me.TambahPertanyaanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TambahPertanyaanToolStripMenuItem.Text = "Tambah Pertanyaan"
        '
        'DIAGNOSAToolStripMenuItem1
        '
        Me.DIAGNOSAToolStripMenuItem1.Name = "DIAGNOSAToolStripMenuItem1"
        Me.DIAGNOSAToolStripMenuItem1.Size = New System.Drawing.Size(78, 20)
        Me.DIAGNOSAToolStripMenuItem1.Text = "DIAGNOSA"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(707, 361)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Utama"
        Me.Text = "Menu_Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAMASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDiagnosaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahPertanyaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIAGNOSAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
