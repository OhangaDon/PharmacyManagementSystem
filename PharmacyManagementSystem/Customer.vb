Imports System.Data.SqlClient

Public Class Customer
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oliver\source\repos\PharmacyManagementSystem\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from CustomerTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CustomerGv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Con.Open()
        Dim query As String
        query = "INSERT INTO CustomerTable VALUES (" & CustIDBox.Text & ", '" & CustNameBox.Text & "', " & TeleBox.Text & ", " & AddressBox.Text & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        populate()
        MsgBox("Customer Successfully Added")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CustIDBox.Text = "" Or CustNameBox.Text = "" Or TeleBox.Text = "" Or AddressBox.Text = "" Then
            MsgBox("The data is incomplete")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("Update CustomerTable set CustomerName = " & CustNameBox.Text & ", Telephone = " & TeleBox.Text & ", CustomerAddress = " & AddressBox.Text & " ' where CustomerId = '" & CustIDBox.Text & "'", Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            populate()
            MsgBox("Customer Successfully Updated")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CustIDBox.Text = "" Then
            MsgBox("No Customer Selected")
        Else
            Con.Open()
            Dim query As String
            query = "DELETE FROM CustomerTable WHERE CustomerId = '" & CustIDBox.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            populate()
            MsgBox("Customer Successfully Deleted")
        End If
    End Sub
End Class