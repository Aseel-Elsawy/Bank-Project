Imports System.Data.SqlClient

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cm.CommandText = "select * from customers where id='" + Form9.txtid.Text + "'"
        cm.Connection = cn

        cn.Open()
        Dim dr As SqlDataReader = cm.ExecuteReader()

        'Form6.DataGridView1.Rows.Clear()
        While dr.Read()
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8))
        End While
        dr.Close()
        cn.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form9.Show()

    End Sub
End Class