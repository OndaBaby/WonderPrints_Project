Imports System.Data.SqlClient
Public Class LogInForm
    Private Sub LogIncmd_Click(sender As Object, e As EventArgs) Handles LogIncmd.Click
        Dim conn As New SqlConnection()
        Dim cmd As New SqlCommand
        Dim dbreader As SqlDataReader = cmd.ExecuteReader

        conn.Open()
        cmd.Parameters.AddWithValue("username", txtusername.Text.Trim)
        cmd.Parameters.AddWithValue("password", txtpass.Text.Trim)

        If dbreader.Read Then
            MessageBox.Show("Login Successfully")
        Else
            MessageBox.Show("Incorrect username or password. Try Again.")
        End If
    End Sub

    Private Sub cbshow_CheckedChanged(sender As Object, e As EventArgs) Handles cbshow.CheckedChanged
        If cbshow.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub
End Class