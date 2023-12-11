Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    MessageBox.Show("please enter correct data", "Client login")
                End If
            End If
        Next


        clientlogin("select * from customers where username='" + usertxt.Text + "' and password='" + passtxt.Text + "'")
        cn.Close()





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub usertxt_TextChanged(sender As Object, e As EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub usertxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usertxt.KeyPress
        If e.KeyChar = Chr(13) Then
            passtxt.Select()

        End If
    End Sub

    Private Function GetData(ssql As String) As SqlDataReader

    End Function

End Class