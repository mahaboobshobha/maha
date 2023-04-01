Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class creditdetail
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    Private Sub creditdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\extra vs code\Train management VB.net\project\Database1.mdf;Integrated Security=True;User Instance=True")

    End Sub

    Private Sub btnbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbook.Click
        con.Open()
        cmd = New SqlCommand("insert into bookticket values('" + txtunm.Text + "','" + txtcnm.Text + "','" + txtpnm.Text + "','" + txtbnm.Text + "'," + txttid.Text + ")", con)

        cmd.ExecuteNonQuery()
        MsgBox("Record insert sucsessfully !!!")

        txtbnm.Text = Nothing
        txtcnm.Text = Nothing
        txtpnm.Text = Nothing
        txttid.Text = Nothing
        txtunm.Text = Nothing




    End Sub

    Private Sub btncncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncncl.Click

        bookticketinuser.Show()
        Me.Close()
    End Sub

    Private Sub txttid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttid.TextChanged
        If Not Regex.Match(txttid.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Number Only!")
        End If
    End Sub

    Private Sub txtunm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunm.TextChanged
        If Not Regex.Match(txtunm.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
        End If
    End Sub

    Private Sub txtbnm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbnm.TextChanged
        If Not Regex.Match(txtbnm.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
        End If
    End Sub

    Private Sub txtcnm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcnm.TextChanged
        If Not Regex.Match(txtcnm.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Number Only!")
        End If
    End Sub

    Private Sub txtpnm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpnm.TextChanged
        If Not Regex.Match(txtpnm.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Number Only!")
        End If
    End Sub
End Class