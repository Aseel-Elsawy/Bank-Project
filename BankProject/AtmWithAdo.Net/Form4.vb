Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox




Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    MessageBox.Show("please enter correct data", "clients")
                End If
            End If
        Next

        Dim x As String = "insert into customers (name,phone,email,address,username,password,job,city) values ('" + txtname.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtaddrs.Text + "','" + txtuser.Text + "','" + txtpass.Text + "','" + txtjob.Text + "','" + txtcity.Text + "')"
        cn.Open()
        newclient(x)

        If newclient(x) > 0 Then
            cn.Close()

            MessageBox.Show("saved", "clients")

            For Each txt In Me.Controls
                If TypeOf txt Is TextBox Then
                    txt.Text = ""
                End If

            Next
            txtphone.Text = ""
        Else
            cn.Close()
            MessageBox.Show("failure")

        End If

    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next


    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If e.KeyChar = Chr(13) Then
            txtphone.Select()

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form10.Show()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form4_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cm.CommandText = "select ident_current('customers')+1"
        cm.Connection = cn
        cn.Open()
        Dim dr As SqlDataReader = cm.ExecuteReader
        dr.Read()
        txtid.Text = dr(0).ToString()
        dr.Close()
        cn.Close()


    End Sub



    Private Sub txtcity_TextChanged(sender As Object, e As EventArgs) Handles txtcity.TextChanged

    End Sub

    Private Sub txtcity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcity.KeyPress
        If e.KeyChar = Chr(13) Then
            txtemail.Select()

        End If
    End Sub

    Private Sub txtaddrs_TextChanged(sender As Object, e As EventArgs) Handles txtaddrs.TextChanged

    End Sub

    Private Sub txtaddrs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaddrs.KeyPress
        If e.KeyChar = Chr(13) Then
            txtcity.Select()

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
End Class