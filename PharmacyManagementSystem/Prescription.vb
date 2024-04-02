Imports System.Data.SqlClient

Public Class Prescription
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oliver\source\repos\PharmacyManagementSystem\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub populate()
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim sql As String = "SELECT * FROM PrescriptionTable"
            Dim adapter As New SqlDataAdapter(sql, Con)
            Dim ds As New DataSet()
            adapter.Fill(ds)
            PrescriptionGv.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("An error occurred while populating the data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back As New Home
        back.Show()
    End Sub

    Private Sub Prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Con.Open()
            Dim query As String = "INSERT INTO PrescriptionTable VALUES (@PrescriptionID, @CustomerID, @CustomerName, @MedicineName, @Dosage, @Date)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@PrescriptionID", PresBox.Text)
            cmd.Parameters.AddWithValue("@CustomerID", CusIDBox.Text)
            cmd.Parameters.AddWithValue("@CustomerName", CusNameBox.Text)
            cmd.Parameters.AddWithValue("@MedicineName", MedNameBox.Text)
            cmd.Parameters.AddWithValue("@Dosage", DosageBox.Text)
            cmd.Parameters.AddWithValue("@Date", DateTb.Text)
            cmd.ExecuteNonQuery()
            populate()
            MsgBox("Prescription Successfully Added")
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding prescription: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Implement code for edit button here
        ' You will need to get the selected row from the DataGridView and update the corresponding record in the database
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Con.Open()
            Dim selectedPrescriptionID As String = PrescriptionGv.CurrentRow.Cells("PrescriptionIDColumn").Value.ToString()
            Dim query As String = "DELETE FROM PrescriptionTable WHERE PrescriptionID = @PrescriptionID"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@PrescriptionID", selectedPrescriptionID)
            cmd.ExecuteNonQuery()
            populate()
            MsgBox("Prescription Successfully Deleted")
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting prescription: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
    End Sub
End Class