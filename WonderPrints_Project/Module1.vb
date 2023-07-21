Imports System.Data.SqlClient
Imports System.Windows
Module Module1
    Sub Dagdag()
        Using conn As New SqlConnection("host=127.0.0.1;database=todayshappening;username=root;password=")
            Try
                conn.Open()

                Dim query As String = $"INSERT INTO fruits (customer_username, Fruits, Color,)
                VALUES (@ID, @Fruits, @Color, @Taste)
"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", SignUpForm.txtname.Text)
                    cmd.Parameters.AddWithValue("@Fname", SignUpForm.txtusernameS.Text)
                    cmd.Parameters.AddWithValue("@Lname", SignUpForm.txtC_number.Text)
                    'cmd.Parameters.AddWithValue("@Age", SignUpForm.txtpassS.Text)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Inserted successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

End Module
