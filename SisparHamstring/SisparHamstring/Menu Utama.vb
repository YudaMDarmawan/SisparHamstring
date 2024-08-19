Public Class Menu_Utama

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call terkunci()
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahUserToolStripMenuItem.Click
        EntryUser.ShowDialog()
    End Sub

    Private Sub TambahDiagnosaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDiagnosaToolStripMenuItem.Click
        Input_Diagnosa.ShowDialog()
    End Sub

    Private Sub TambahPertanyaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahPertanyaanToolStripMenuItem.Click
        InputPertanyaan.ShowDialog()
    End Sub
    Private Sub Menu_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call terkunci()
    End Sub
    Sub terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        DATAMASTERToolStripMenuItem.Enabled = False
        DIAGNOSAToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub DIAGNOSAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DIAGNOSAToolStripMenuItem1.Click
        Formdiagnosa.ShowDialog()
    End Sub
End Class