﻿Imports System.Data.SqlClient

Public Class userhome
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Public temp As String
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        trainTimeTabbleInUser.Show()
        Me.Close()


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bookticketinuser.Show()
        Me.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub userhome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        temp = userlogin.userid
        Me.Text = temp

        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\extra vs code\Train management VB.net\project\Database1.mdf;Integrated Security=True;User Instance=True")

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd = New SqlCommand("delete from bookticket where username='" + temp + "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("BOOKING CANCEL SUCCESSFULLY !!!")
        con.Close()

    End Sub
End Class