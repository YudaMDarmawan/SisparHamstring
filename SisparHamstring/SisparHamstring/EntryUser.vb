Imports System.Data
Imports MySql.Data.MySqlClient
Public Class EntryUser
    Dim sql As String
    Dim ds As DataSet
    Sub tampil()
        da = New MySqlDataAdapter("select * from tuser order by kduser", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tuser")
        conn.Close()
        dg.DataSource = (ds.Tables("tuser"))
        dg.ReadOnly = True
    End Sub
    Sub bersih()
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is TextBox Then x.Text = ""
        Next
        txtusename.Focus()
        txtusename.ReadOnly = False
        btntambah.Enabled = True
        btnhapus.Enabled = True
        btnsimpan.Enabled = True
        btnkeluar.Enabled = True
        btntambah.Text = "Tambah"
        txtcari.Text = "Cari Berdasarkan Username"
        txtcari.ForeColor = Color.Gray
        cbstat.Text = ""
        If cbstat.Items.Count = 0 Then
            cbstat.Items.Add("Admin")
            cbstat.Items.Add("Dokter")
        End If
    End Sub

    Private Sub EntryUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        Call koneksivb()
        Call tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Batal" Then
            bersih()
        Else
            bersih()
            btnhapus.Enabled = False
            btntambah.Text = "Batal"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        conn.Open()
        If txtnama.Text = "" Or txtpw.Text = "" Or cbstat.Text = "" Then
            MsgBox("Masih Ada Field Data yang Tidak Diisi")
            bersih()
        Else
            cmd = New MySqlCommand("Select * from tuser where kduser='" & txtusename.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            If dr.HasRows Then
                MsgBox("Username Sudah Ada, Masukan Username yg Lain", , "Perhatian")
                bersih()
                conn.Close()
            Else
                sql = "insert into tuser values('" & txtusename.Text & "','" & txtnama.Text & "','" & txtpw.Text & "','" & _
                                cbstat.Text & "')"
                cmd = New MySqlCommand(sql, conn)
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Simpan Data Berhasil", , "Info")
                    bersih()
                    tampil()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
                bersih()
            End If
            conn.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtusename.Text = "" Then
            MsgBox("Pilih Data yang Akan Dihapus!", , "Info")
        Else
            Dim respons = MsgBox("Anda Yakin Akan Menghapus Data yang Telah Anda Pilih?(OK untuk menghapus / Cancel untuk memilih data lain)", MsgBoxStyle.OkCancel, "Perhatian Menghapus Data!")
            If respons = MsgBoxResult.Ok Then
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("Select * from tuser where kduser='" & txtusename.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    conn.Close()
                    conn.Open()
                    sql = "Delete from tuser where kduser='" & txtusename.Text & "'"
                    cmd = New MySqlCommand(sql, conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Penghapusan Data Berhasil", , "Info")
                        bersih()
                        tampil()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    conn.Close()
                    bersih()
                End If
            Else
                conn.Open()
                bersih()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
        Menu_Utama.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        If btnhapus.Enabled = False Then
        Else
            Dim row As DataGridViewRow = dg.Rows(dg.CurrentRow.Index)
            If Not IsDBNull(row.Cells("kduser").Value) Then
                txtusename.Text = row.Cells("kduser").Value
                If Not IsDBNull(row.Cells("Nama").Value) Then
                    txtnama.Text = row.Cells("Nama").Value
                    If Not IsDBNull(row.Cells("password").Value) Then
                        txtpw.Text = row.Cells("Password").Value
                        If Not IsDBNull(row.Cells("Level").Value) Then
                            cbstat.Text = row.Cells("Level").Value
                        End If
                    End If
                End If
            End If
        End If
        btnsimpan.Enabled = False
        btnkeluar.Enabled = False
        btntambah.Text = "Batal"
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        txtcari.Clear()
        txtcari.Focus()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Dim counter As Integer
        Dim pola As String
        Dim baca, baca1 As String
        Dim found As Boolean

        txtcari.ForeColor = Color.Black
        pola = txtcari.Text + "*"
        For counter = 1 To dg.RowCount - 1
            baca = dg.Rows(counter - 1).Cells(0).Value
            baca1 = dg.Rows(counter - 1).Cells(1).Value
            found = UCase(baca) Like UCase(pola) Or UCase(baca1) Like UCase(pola)

            If found = True Then
                dg.CurrentCell = dg.Item(0, counter - 1)
                Exit Sub
            End If
        Next
    End Sub
End Class