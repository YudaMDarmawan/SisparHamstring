<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputPertanyaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputPertanyaan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtkdp = New System.Windows.Forms.TextBox()
        Me.txtperta = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pertanyaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pertanyaan"
        '
        'txtkdp
        '
        Me.txtkdp.Location = New System.Drawing.Point(107, 47)
        Me.txtkdp.Name = "txtkdp"
        Me.txtkdp.Size = New System.Drawing.Size(100, 20)
        Me.txtkdp.TabIndex = 2
        '
        'txtperta
        '
        Me.txtperta.Location = New System.Drawing.Point(107, 86)
        Me.txtperta.Multiline = True
        Me.txtperta.Name = "txtperta"
        Me.txtperta.Size = New System.Drawing.Size(461, 65)
        Me.txtperta.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnkeluar)
        Me.GroupBox1.Controls.Add(Me.btnhapus)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.btntambah)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'btnkeluar
        '
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkeluar.Location = New System.Drawing.Point(383, 19)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(118, 75)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.Location = New System.Drawing.Point(259, 19)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(118, 75)
        Me.btnhapus.TabIndex = 2
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(135, 19)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(118, 75)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(11, 19)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(118, 75)
        Me.btntambah.TabIndex = 0
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(15, 288)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(578, 144)
        Me.dg.TabIndex = 5
        '
        'InputPertanyaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(605, 444)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtperta)
        Me.Controls.Add(Me.txtkdp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InputPertanyaan"
        Me.Text = "InputPertanyaan"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtkdp As System.Windows.Forms.TextBox
    Friend WithEvents txtperta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
End Class
