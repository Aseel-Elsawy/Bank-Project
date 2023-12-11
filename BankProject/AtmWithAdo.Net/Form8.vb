Imports System.Data.SqlClient
Public Class Form8




    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
            Form11.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class