<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input_Diagnosa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Input_Diagnosa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtkddiag = New System.Windows.Forms.TextBox()
        Me.txtdiag = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsolusi = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Diagnosa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagnosa"
        '
        'txtkddiag
        '
        Me.txtkddiag.Location = New System.Drawing.Point(139, 26)
        Me.txtkddiag.Name = "txtkddiag"
        Me.txtkddiag.Size = New System.Drawing.Size(100, 20)
        Me.txtkddiag.TabIndex = 2
        '
        'txtdiag
        '
        Me.txtdiag.Location = New System.Drawing.Point(139, 52)
        Me.txtdiag.Name = "txtdiag"
        Me.txtdiag.Size = New System.Drawing.Size(228, 20)
        Me.txtdiag.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnkeluar)
        Me.GroupBox1.Controls.Add(Me.btnhapus)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.btntambah)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Pilihan"
        '
        'btnkeluar
        '
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkeluar.Location = New System.Drawing.Point(330, 19)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(105, 75)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.Location = New System.Drawing.Point(218, 19)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(106, 75)
        Me.btnhapus.TabIndex = 2
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(115, 19)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(97, 75)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(16, 19)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(93, 75)
        Me.btntambah.TabIndex = 0
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 288)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(512, 111)
        Me.dg.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Solusi"
        '
        'txtsolusi
        '
        Me.txtsolusi.Location = New System.Drawing.Point(139, 84)
        Me.txtsolusi.Multiline = True
        Me.txtsolusi.Name = "txtsolusi"
        Me.txtsolusi.Size = New System.Drawing.Size(349, 82)
        Me.txtsolusi.TabIndex = 7
        '
        'Input_Diagnosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(541, 411)
        Me.Controls.Add(Me.txtsolusi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtdiag)
        Me.Controls.Add(Me.txtkddiag)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Input_Diagnosa"
        Me.Text = "Input_Diagnosa"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtkddiag As System.Windows.Forms.TextBox
    Friend WithEvents txtdiag As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsolusi As System.Windows.Forms.TextBox
End Class
