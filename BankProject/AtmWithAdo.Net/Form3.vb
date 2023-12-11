Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    MessageBox.Show("please enter correct data", "Employee Login")
                End If
            End If
        Next

        emplogin("select * from employeelogin where username='" + usertxt.Text + "' and password='" + passtxt.Text + "'")

    End Sub

    Private Sub usertxt_TextChanged(sender As Object, e As EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub usertxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usertxt.KeyPress
        If e.KeyChar = Chr(13) Then
            passtxt.Select()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class