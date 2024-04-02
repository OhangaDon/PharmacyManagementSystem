Imports System.Data.SqlClient

Public Class Manufacturer
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oliver\source\repos\PharmacyManagementSystem\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from CompanyTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ManufacturerGv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Con.Open()
        Dim query As String
        query = "INSERT INTO CompanyTable VALUES (" & CompIDBox.Text & ", '" & CompNameBox.Text & "', " & PhoneBox.Text & ", " & CompAddressBox.Text & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        populate()
        MsgBox("Manufacturer Successfully Added")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CompIDBox.Text = "" Or CompNameBox.Text = "" Or PhoneBox.Text = "" Or CompAddressBox.Text = "" Then
            MsgBox("The data is incomplete")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("Update CompanyTable set CompName = " & CompNameBox.Text & ", CompTel = " & PhoneBox.Text & ", CompAddress = " & CompAddressBox.Text & " ' where CompId = '" & CompIDBox.Text & "'", Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            populate()
            MsgBox("Manufacturer Successfully Updated")
        End If
    End Sub



    Private Sub Manufacturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CompIDBox.Text = "" Then
            MsgBox("No manufacturer Selected")
        Else
            Con.Open()
            Dim query As String
            query = "DELETE FROM CompanyTable WHERE CompId = '" & CompIDBox.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            populate()
            MsgBox("Manufacturer Successfully Deleted")
        End If
    End Sub
End Class