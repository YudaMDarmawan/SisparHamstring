Imports System.Data
Imports MySql.Data.MySqlClient
Public Class InputPertanyaan
    Dim sql As String
    Dim ds As DataSet
    Sub tampil()
        da = New MySqlDataAdapter("select * from tentrypertanyaan order by kdpertanyaan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tentrypertanyaan")
        conn.Close()
        dg.DataSource = (ds.Tables("tentrypertanyaan"))
        dg.ReadOnly = True
    End Sub
    Sub bersih()
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is TextBox Then x.Text = ""
        Next
        txtkdp.Focus()
        txtkdp.ReadOnly = False
        btntambah.Enabled = True
        btnhapus.Enabled = True
        btnsimpan.Enabled = True
        btnkeluar.Enabled = True
        btntambah.Text = "Tambah"
    End Sub
    Sub aturdg()
        dg.Columns(0).Width = 80
        dg.Columns(1).Width = 500
    End Sub

    Private Sub InputPertanyaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksivb()
        Call tampil()
        Call bersih()
        Call aturdg()
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
        If txtkdp.Text = "" Or txtperta.Text = "" Then
            MsgBox("Masih Ada Field Data yang Tidak Diisi")
            bersih()
        Else
            cmd = New MySqlCommand("Select * from tentrypertanyaan where kdpertanyaan='" & txtkdp.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            If dr.HasRows Then
                MsgBox("Kode Pertanyaan Sudah Ada, Masukan Kode Pertanyaan yg Lain", , "Perhatian")
                bersih()
                conn.Close()
            Else
                sql = "insert into tentrypertanyaan values('" & txtkdp.Text & "','" & txtperta.Text & "')"
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
        If txtkdp.Text = "" Then
            MsgBox("Pilih Data yang Akan Dihapus!", , "Info")
        Else
            Dim respons = MsgBox("Anda Yakin Akan Menghapus Data yang Telah Anda Pilih?(OK untuk menghapus / Cancel untuk memilih data lain)", MsgBoxStyle.OkCancel, "Perhatian Menghapus Data!")
            If respons = MsgBoxResult.Ok Then
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("Select * from tentrypertanyaan where kdpertanyaan'" & txtkdp.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    conn.Close()
                    conn.Open()
                    sql = "Delete from tentrypertanyaan where kdpertanyaan='" & txtkdp.Text & "'"
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
            If Not IsDBNull(row.Cells("kdpertanyaan").Value) Then
                txtkdp.Text = row.Cells("kdpertanyaan").Value
                If Not IsDBNull(row.Cells("pertanyaan").Value) Then
                    txtperta.Text = row.Cells("pertanyaan").Value
                End If
            End If
        End If
        btnsimpan.Enabled = False
        btnkeluar.Enabled = False
        btntambah.Text = "Batal"
    End Sub
End Class