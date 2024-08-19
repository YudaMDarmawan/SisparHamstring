<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntryUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntryUser))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtusename = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.cbstat = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(40, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PENGATURAN USER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "NAMA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "PASSWORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "STATUS"
        '
        'txtusename
        '
        Me.txtusename.Location = New System.Drawing.Point(122, 145)
        Me.txtusename.Name = "txtusename"
        Me.txtusename.Size = New System.Drawing.Size(176, 20)
        Me.txtusename.TabIndex = 19
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(122, 171)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(176, 20)
        Me.txtnama.TabIndex = 20
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(122, 195)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(176, 20)
        Me.txtpw.TabIndex = 21
        '
        'cbstat
        '
        Me.cbstat.FormattingEnabled = True
        Me.cbstat.Location = New System.Drawing.Point(122, 221)
        Me.cbstat.Name = "cbstat"
        Me.cbstat.Size = New System.Drawing.Size(121, 21)
        Me.cbstat.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnkeluar)
        Me.GroupBox1.Controls.Add(Me.btnhapus)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.btntambah)
        Me.GroupBox1.Location = New System.Drawing.Point(330, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 168)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU PILIHAN"
        '
        'btnkeluar
        '
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkeluar.Location = New System.Drawing.Point(123, 92)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(111, 68)
        Me.btnkeluar.TabIndex = 26
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(6, 92)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(111, 66)
        Me.btnhapus.TabIndex = 25
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(123, 19)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(111, 72)
        Me.btnsimpan.TabIndex = 24
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(6, 19)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(111, 72)
        Me.btntambah.TabIndex = 0
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(28, 330)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(543, 134)
        Me.dg.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(330, 274)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 40)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(367, 283)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(173, 20)
        Me.txtcari.TabIndex = 26
        '
        'EntryUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(610, 476)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbstat)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtusename)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "EntryUser"
        Me.Text = "Entry User"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtusename As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
    Friend WithEvents cbstat As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
End Class
