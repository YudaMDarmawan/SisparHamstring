Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Login
    Dim sql As String
    Dim ds As DataSet
    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        If ComboBox1.Text = "" Or txtpw.Text = "" Then
            MsgBox("data login belum lengkap")
            Exit Sub
        Else
            Call koneksivb()
            cmd = New MySqlCommand("select * from tuser where kduser='" & ComboBox1.Text & "' and password='" & txtpw.Text & "' and level='admin'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.Close()
                Menu_Utama.Show()
                Menu_Utama.LoginToolStripMenuItem.Enabled = False
                Menu_Utama.LogoutToolStripMenuItem.Enabled = True
                Menu_Utama.DATAMASTERToolStripMenuItem.Enabled = True
                Menu_Utama.DIAGNOSAToolStripMenuItem1.Enabled = True

            Else
                Call koneksivb()
                cmd = New MySqlCommand("select * from tuser where kduser='" & ComboBox1.Text & "' and password='" & txtpw.Text & "' and level='Dokter'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Me.Close()
                    Menu_Utama.Show()
                    Menu_Utama.LoginToolStripMenuItem.Enabled = False
                    Menu_Utama.LogoutToolStripMenuItem.Enabled = True
                    Menu_Utama.DIAGNOSAToolStripMenuItem1.Enabled = True
                Else
                    MsgBox("Kode Admin atau Password salah")
                End If
            End If
        End If
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
        txtpw.PasswordChar = "X"
        txtpw.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksivb()
        cmd = New MySqlCommand("Select * from tuser where kduser='" & ComboBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        dr.Close()
    End Sub
    Sub awal()
        koneksivb()
        sql = "select kduser from tuser"
        Try
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBox1.Items.Add(dr.Item("kduser"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Close()
    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Me.Close()
        Menu_Utama.ShowDialog()
    End Sub
End Class