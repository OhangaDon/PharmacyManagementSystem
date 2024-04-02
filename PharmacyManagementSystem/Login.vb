Imports System.Data.SqlClient

Public Class Login

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oliver\source\repos\PharmacyManagementSystem\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Open the connection
            Con.Open()

            ' SQL query to check if the entered username and password match any record in the EmployeeTable
            Dim query As String = "SELECT COUNT(*) FROM EmployeeTable WHERE EmpName = @username AND EmpPassword = @password"

            ' Create a SqlCommand object with parameters
            Using cmd As New SqlCommand(query, Con)
                ' Set the parameters
                cmd.Parameters.AddWithValue("@username", UnameTb.Text)
                cmd.Parameters.AddWithValue("@password", PassWordTb.Text)

                ' Execute the query
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Check if a record with the entered username and password exists
                If count > 0 Then
                    ' Successful login, navigate to the Home form
                    Me.Hide()
                    Dim homeForm As New Home()
                    homeForm.Show()
                Else
                    ' Display an error message if login fails
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            Con.Close()
        End Try

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
End Class