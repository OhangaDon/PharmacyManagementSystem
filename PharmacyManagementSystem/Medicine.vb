Imports System.Data.SqlClient
Public Class Medicine
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oliver\source\repos\PharmacyManagementSystem\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from CompanyTable", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        CompCb.DataSource = Tbl
        CompCb.DisplayMember = "CompName"
        CompCb.ValueMember = "CompName"
        Con.Close()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from MedicineTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        MedicineGv.DataSource = ds.Tables(0)
        Con.Close()

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back = New Home
        Home.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Con.Open()
        Dim query As String
        Dim selectedCompany As String = ""
        If CompCb.SelectedItem IsNot Nothing Then
            selectedCompany = CompCb.SelectedValue.ToString()
        End If
        query = "INSERT INTO MedicineTable VALUES ('" & MedicineTb.Text & "', " & BuyingPriceTb.Text & ", " & SellingPriceTb.Text & ", " & QuantityTb.Text & ", '" & ExpDateTb.Text & "', '" & selectedCompany & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        populate()
        MsgBox("Medicine Successfully Added")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MedicineTb.Text = "" Then
            MsgBox("No Medicine Selected")
        Else
            Con.Open()
            Dim query As String
            query = "DELETE FROM MedicineTable WHERE MedName = '" & MedicineTb.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            populate()
            MsgBox("Medicine Successfully Deleted")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MedicineTb.Text = "" Or BuyingPriceTb.Text = "" Or SellingPriceTb.Text = "" Or QuantityTb.Text = "" Then
            MsgBox("The data is incomplete")
        Else
            Dim selectedCompany As String = ""
            If CompCb.SelectedItem IsNot Nothing Then
                selectedCompany = CompCb.SelectedValue.ToString()
            End If

            Con.Open()
            Dim cmd As New SqlCommand("Update MedicineTable set BuyingPrice = " & BuyingPriceTb.Text & ", SellingPrice = " & SellingPriceTb.Text & ", Quantity = " & QuantityTb.Text & ", ExpDate = '" & ExpDateTb.Text & "', Company = '" & selectedCompany & "' where MedName = '" & MedicineTb.Text & "'", Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            populate()
            MsgBox("Medicine Successfully Updated")
        End If
    End Sub

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        populate()
    End Sub

End Class