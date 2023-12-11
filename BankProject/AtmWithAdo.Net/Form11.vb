Imports System.Data.SqlClient

Public Class Form11
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    MessageBox.Show("please enter correct data", "Withdrawals")
                End If
            End If
        Next

        cm.CommandText = "select dbo.getamount('" + txtid1.Text + "','" + txtamount1.Text + "')"
        cm.Connection = cn
        cn.Open()
        Dim dr As SqlDataReader = cm.ExecuteReader()
        dr.Read()


        If dr(0).ToString = "No Enough Credit" Or dr(0).ToString = "failure" Then
            MessageBox.Show(dr(0).ToString)
            dr.Close()
            cn.Close()

            Exit Sub
        Else
            dr.Close()

            Dim x As String = "insert into withdrawals values('" + txtid1.Text + "','" + txtdate2.Value + "','" + txtdetails1.Text + "','" + txtamount1.Text + "')"
            money(x)
            If money(x) > 0 Then
                cn.Close()

                MessageBox.Show("process done", "clients")
                txtdetails1.Text = ""
                txtamount1.Text = ""


            Else
                cn.Close()
                MessageBox.Show("failure", "clients")


            End If


        End If



    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cm.CommandText = "select id from customers where (username='" + Form2.usertxt.Text + "' and password='" + Form2.passtxt.Text + "')"
        cm.Connection = cn

        cn.Open()
        Dim dr As SqlDataReader = cm.ExecuteReader()
        dr.Read()
        txtid1.Text = dr(0).ToString
        dr.Close()

        cm.CommandText = "execute gettime"
        dr = cm.ExecuteReader()
        dr.Read()
        txtdate2.Value = dr(0)
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Form11_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub txtdetails1_TextChanged(sender As Object, e As EventArgs) Handles txtdetails1.TextChanged

    End Sub

    Private Sub txtdetails1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdetails1.KeyPress
        If e.KeyChar = Chr(13) Then
            txtamount1.Select()
        End If
    End Sub
End Class