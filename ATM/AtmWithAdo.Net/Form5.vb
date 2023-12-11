Imports System.Data.SqlClient

Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    MessageBox.Show("please enter correct data", "deposits")
                End If
            End If
        Next

        Dim x As String = "insert into deposits values('" + txtid.Text + "','" + txtdate3.Value + "','" + txtdetails.Text + "','" + txtamount.Text + "')"
        cn.Open()
        money(x)
        If money(x) > 0 Then
            cn.Close()

            MessageBox.Show("process done", "clients")
            txtdetails.Text = ""
            txtamount.Text = ""


        Else
            cn.Close()
            MessageBox.Show("failure", "clients")


        End If


    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cm.CommandText = "select id from customers where (username='" + Form2.usertxt.Text + "' and password='" + Form2.passtxt.Text + "')"
        cm.Connection = cn

        cn.Open()
        Dim dr As SqlDataReader = cm.ExecuteReader()
        dr.Read()
        txtid.Text = dr(0).ToString
        dr.Close()

        cm.CommandText = "execute gettime"

        dr = cm.ExecuteReader()
        dr.Read()
        txtdate3.Value = dr(0)
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Form5_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form8.Show()

    End Sub

    Private Sub txtdetails_TextChanged(sender As Object, e As EventArgs) Handles txtdetails.TextChanged

    End Sub

    Private Sub txtdetails_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdetails.KeyPress
        If e.KeyChar = Chr(13) Then
            txtamount.Select()
        End If
    End Sub
End Class