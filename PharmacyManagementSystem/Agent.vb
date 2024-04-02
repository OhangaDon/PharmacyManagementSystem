Imports System.Data.SqlClient

Public Class Agent

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oliver\source\repos\PharmacyManagementSystem\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from EmployeeTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        AgentGv.DataSource = ds.Tables(0)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Con.Open()
        Dim query As String
        query = "INSERT INTO EmployeeTable VALUES (" & EmpIDBox.Text & ", '" & EmpNameBox.Text & "', " & EmpSalaryBox.Text & ", " & EmpAgeBox.Text & ", '" & PhoneBox.Text & "', '" & PasswordBox.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        populate()
        MsgBox("Employee Successfully Added")
    End Sub

    Private Sub Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If EmpIDBox.Text = "" Then
            MsgBox("No Agent Selected")
        Else
            Con.Open()
            Dim query As String
            query = "DELETE FROM EmployeeTable WHERE EmpId = '" & EmpIDBox.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            populate()
            MsgBox("Employee Successfully Deleted")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If EmpIDBox.Text = "" Or EmpNameBox.Text = "" Or EmpSalaryBox.Text = "" Or EmpAgeBox.Text = "" Then
            MsgBox("The data is incomplete")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("Update EmployeeTable set EmpName = " & EmpNameBox.Text & ", EmpSalary = " & EmpSalaryBox.Text & ", EmpAge = " & EmpAgeBox.Text & ", EmpPhone  = '" & PhoneBox.Text & "', EmpPassword = '" & PasswordBox.Text & "' where EmpId = '" & EmpIDBox.Text & "'", Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            populate()
            MsgBox("Employee Successfully Updated")
        End If
    End Sub
End Class