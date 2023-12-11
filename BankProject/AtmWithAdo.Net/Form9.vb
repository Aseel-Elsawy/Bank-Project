Imports System.Data.SqlClient

Public Class Form9
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    MessageBox.Show("no data to show")
                End If
            End If
        Next
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim x As String = InputBox("enter account number", "clients")
        Dim z As String = "select * from customers where id='" + x + "'"


        If search(z).HasRows = True Then

            txtid.Text = search(z)(0).ToString()

            txtname.Text = search(z)(1).ToString()

            txtphone.Text = search(z)(2).ToString()

            txtemail.Text = search(z)(3).ToString()

            txtaddrs.Text = search(z)(4).ToString()

            txtuser.Text = search(z)(5).ToString()


            txtpass.Text = search(z)(6).ToString()

            txtjob.Text = search(z)(7).ToString()

            txtcity.Text = search(z)(8).ToString()
        Else
            MessageBox.Show("client not found", "clients")
        End If


        cn.Close()








    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Dim x As String = "update customers set name='" + txtname.Text + "',phone='" + txtphone.Text + "',email='" + txtemail.Text + "',address='" + txtaddrs.Text + "',username='" + txtuser.Text + "',password='" + txtpass.Text + "',job='" + txtjob.Text + "',city='" + txtcity.Text + "' where id='" + txtid.Text + "'"
        cn.Open()
        newclient(x)
        If newclient(x) > 0 Then
            cn.Close()

            MessageBox.Show("updated", "clients")


        Else
            cn.Close()
            MessageBox.Show("failure")

        End If
        'cm.Connection = cn
        'cn.Open()

        'Dim aff As Integer = cm.ExecuteNonQuery()
        'If aff > 0 Then
        '    MessageBox.Show("updated", "done")
        '    cn.Close()
        'Else
        '    MessageBox.Show("this is an failure", "fail")
        '    cn.Close()
        'End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If

        Next
        txtphone.Text = ""

        Me.Hide()
        Form10.Show()

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub




    Private Sub txtaddrs_TextChanged(sender As Object, e As EventArgs) Handles txtaddrs.TextChanged

    End Sub

    Private Sub txtaddrs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaddrs.KeyPress
        If e.KeyChar = Chr(13) Then
            txtcity.Select()

        End If
    End Sub

    Private Sub txtcity_TextChanged(sender As Object, e As EventArgs) Handles txtcity.TextChanged

    End Sub

    Private Sub txtcity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcity.KeyPress
        If e.KeyChar = Chr(13) Then
            txtemail.Select()

        End If
    End Sub

    Private Sub txtjob_TextChanged(sender As Object, e As EventArgs) Handles txtjob.TextChanged

    End Sub

    Private Sub txtjob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjob.KeyPress
        If e.KeyChar = Chr(13) Then
            txtuser.Select()

        End If
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpass.Select()

        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Chr(13) Then
            txtemail.Select()

        End If
    End Sub

    Private Sub txtphone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtphone.MaskInputRejected

    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        If e.KeyChar = Chr(13) Then
            txtaddrs.Select()

        End If
    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub txtemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemail.KeyPress
        If e.KeyChar = Chr(13) Then
            txtjob.Select()

        End If
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class