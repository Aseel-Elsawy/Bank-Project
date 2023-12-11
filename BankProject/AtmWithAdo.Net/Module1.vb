Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Http

Module Module1
    Public cn As New SqlConnection("data source=SQLOLEDB.1;Password=samah;Persist Security Info=True;User ID=sa;Initial Catalog=atmbank;Data Source=DESKTOP-678O052\Aseel
")

    Public cm As New SqlCommand()

    Public Function clientlogin(sql As String) As Boolean
        cm.Connection = cn
        cm.CommandText = sql
        cn.Open()
        Dim rd As SqlDataReader = cm.ExecuteReader()
        rd.Read()
        If rd.HasRows = True Then
            cn.Close()
            Form2.Hide()
            Form8.Show()


        Else
            cn.Close()
            MessageBox.Show("please enter correct data", "error")


        End If
    End Function
    Public Function emplogin(sql As String) As Boolean
        cm.Connection = cn
        cm.CommandText = sql
        cn.Open()
        Dim rd As SqlDataReader = cm.ExecuteReader()
        rd.Read()
        If rd.HasRows = True Then
            cn.Close()
            Form3.Hide()
            Form10.Show()


        Else
            cn.Close()
            MessageBox.Show("please enter correct data", "error")


        End If

    End Function
    Public Function newclient(sql As String) As Integer

        cm.CommandText = sql
        cm.Connection = cn

        Dim aff As Integer = cm.ExecuteNonQuery()
        If aff > 0 Then
            Return 1
        End If

    End Function
    Public Function money(sql As String) As Integer
        cm.CommandText = sql
        cm.Connection = cn

        Dim aff As Integer = cm.ExecuteNonQuery()
        If aff > 0 Then
            Return 1
        End If
    End Function
    Public Function search(sql As String) As SqlDataReader
        cn.Close()
        cm.CommandText = sql
        cm.Connection = cn
        cn.Open()

        Dim dr As SqlDataReader = cm.ExecuteReader()
        dr.Read()

        If (dr.HasRows = True) Then

            Return dr
            dr.Close()
            cn.Close()

        Else


            Return dr

            MessageBox.Show("client not found")
        End If


    End Function

End Module
