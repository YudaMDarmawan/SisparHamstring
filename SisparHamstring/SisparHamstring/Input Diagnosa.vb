Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Input_Diagnosa
    Dim sql As String
    Dim ds As DataSet
    Sub tampil()
        da = New MySqlDataAdapter("select * from tbl_ediag order by kddiagnosa", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_ediag")
        conn.Close()
        dg.DataSource = (ds.Tables("tbl_ediag"))
        dg.ReadOnly = True
    End Sub
    Sub bersih()
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is TextBox Then x.Text = ""
        Next
        txtkddiag.Focus()
        txtkddiag.ReadOnly = False
        btntambah.Enabled = True
        btnhapus.Enabled = True
        btnsimpan.Enabled = True
        btnkeluar.Enabled = True
        btntambah.Text = "Tambah"
    End Sub

    Private Sub Input_Diagnosa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        Call koneksivb()
        Call tampil()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Batal" Then
            bersih()
        Else
            bersih()
            btnhapus.Enabled = False
            btntambah.Text = "Batal"
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        conn.Open()
        If txtkddiag.Text = "" Or txtdiag.Text = "" Then
            MsgBox("Masih Ada Field Data yang Tidak Diisi")
            bersih()
        Else
            cmd = New MySqlCommand("Select * from tbl_ediag where kddiagnosa='" & txtdiag.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            If dr.HasRows Then
                MsgBox("Kode Diagnosa Sudah Ada, Masukan Kode Diagnosa yg Lain", , "Perhatian")
                bersih()
                conn.Close()
            Else
                sql = "insert into tbl_ediag values('" & txtkddiag.Text & "','" & txtdiag.Text & "','" & txtsolusi.Text & "')"
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

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtkddiag.Text = "" Then
            MsgBox("Pilih Data yang Akan Dihapus!", , "Info")
        Else
            Dim respons = MsgBox("Anda Yakin Akan Menghapus Data yang Telah Anda Pilih?(OK untuk menghapus / Cancel untuk memilih data lain)", MsgBoxStyle.OkCancel, "Perhatian Menghapus Data!")
            If respons = MsgBoxResult.Ok Then
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("Select * from tbl_ediag where kddiagnosa='" & txtkddiag.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    conn.Close()
                    conn.Open()
                    sql = "Delete from tbl_ediag where kddiagnosa='" & txtkddiag.Text & "'"
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

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
        Menu_Utama.Show()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        If btnhapus.Enabled = False Then
        Else
            Dim row As DataGridViewRow = dg.Rows(dg.CurrentRow.Index)
            If Not IsDBNull(row.Cells("kddiagnosa").Value) Then
                txtkddiag.Text = row.Cells("kddiagnosa").Value
                If Not IsDBNull(row.Cells("diagnosa").Value) Then
                    txtdiag.Text = row.Cells("diagnosa").Value
                    If Not IsDBNull(row.Cells("solusi").Value) Then
                        txtdiag.Text = row.Cells("solusi").Value
                    End If
                End If
            End If
            End If
            btnsimpan.Enabled = False
            btnkeluar.Enabled = False
            btntambah.Text = "Batal"
    End Sub
End Class