Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Formdiagnosa
    Dim sql As String
    Dim ds As DataSet
    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub Formdiagnosa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()
        Call koneksivb()
        Call aturdg()
    End Sub
    Sub aturdg()
        dg.Columns(0).Width = 80
        dg.Columns(1).Width = 500
    End Sub
    Sub tampil()
        Call koneksivb()
        da = New MySqlDataAdapter("select * from tentrypertanyaan order by kdpertanyaan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tentrypertanyaan")
        conn.Close()
        dg.DataSource = (ds.Tables("tentrypertanyaan"))
        dg.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If chk1.Checked Then
            If chk4.Checked Then
                If chk5.Checked Then
                    If chk10.Checked Then
                        If chk9.Checked Then
                            If chk12.Checked Then
                                txtdiag.Text = "R01"
                            ElseIf chk2.Checked Then
                                If chk4.Checked Then
                                    If chk9.Checked Then
                                        If chk10.Checked Then
                                            If chk12.Checked Then
                                                If chk14.Checked Then
                                                    txtdiag.Text = "R02"
                                                ElseIf chk2.Checked Then
                                                    If chk3.Checked Then
                                                        If chk6.Checked Then
                                                            If chk8.Checked Then
                                                                If chk11.Checked Then
                                                                    If chk14.Checked Then
                                                                        txtdiag.Text = "R03"
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtdiag_TextChanged(sender As Object, e As EventArgs) Handles txtdiag.TextChanged
        koneksivb()
        cmd = New MySqlCommand("Select * from tbl_ediag where kddiagnosa='" & txtdiag.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtdiagnosa.Text = dr.Item("diagnosa")
            txtsolusi.Text = dr.Item("solusi")
        End If
    End Sub

  
End Class
