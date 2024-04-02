Imports System.Data.SqlClient

Public Class Billing
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oliver\source\repos\PharmacyManagementSystem\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from MedicineTable", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        BillingCombo.DataSource = Tbl
        BillingCombo.DisplayMember = "MedName"
        BillingCombo.ValueMember = "Medname"
        Con.Close()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
    Private Sub FetchQty()
        Try
            Con.Open()
            Dim query = "select Quantity from MedicineTable where MedName = '" & BillingCombo.SelectedValue.ToString() & "'"
            Debug.WriteLine("Query: " & query) ' Print out query for debugging
            Dim cmd As New SqlCommand(query, Con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Stock.Text = reader(0).ToString()
            Else
                MsgBox("No quantity found for selected medicine.")
            End If
        Catch ex As Exception
            MsgBox("Error fetching quantity: " & ex.Message)
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub
    Private Sub BillingCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles BillingCombo.SelectionChangeCommitted
        FetchQty()
    End Sub

    Dim i = 1, totalprice

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Create a PrintDocument object
            Dim pd As New Printing.PrintDocument

            ' Add event handler for PrintPage event
            AddHandler pd.PrintPage, AddressOf PrintPageHandler

            ' Display print dialog
            Dim printDialog As New PrintDialog
            printDialog.Document = pd
            If printDialog.ShowDialog = DialogResult.OK Then
                ' Print the document
                pd.Print()
            End If
        Catch ex As Exception
            ' Display error message
            MessageBox.Show("An error occurred while printing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As Printing.PrintPageEventArgs)
        Try
            ' Check if BillingGv is not Nothing
            If BillingGv IsNot Nothing Then
                ' Define the content to be printed
                ' For example, you can use Graphics.DrawString to draw text on the page
                Dim font As New Font("Arial", 12)
                Dim brush As New SolidBrush(Color.Black)
                Dim startX As Integer = 100
                Dim startY As Integer = 100

                ' Example content
                Dim content As String = "This is a sample text to be printed."

                ' Draw the content on the page
                e.Graphics.DrawString(content, font, brush, startX, startY)

                ' You can add more content to be printed here
                ' For example, loop through the rows in DataGridView and print them
                For Each row As DataGridViewRow In BillingGv.Rows
                    ' Check if the row is not Nothing
                    If row IsNot Nothing Then
                        ' Print each row's content
                        Dim rowContent As String = ""
                        For Each cell As DataGridViewCell In row.Cells
                            ' Check if the cell is not Nothing and has a value
                            If cell IsNot Nothing AndAlso cell.Value IsNot Nothing Then
                                rowContent &= cell.Value.ToString() & " "
                            End If
                        Next
                        startY += 20 ' Move to the next line
                        e.Graphics.DrawString(rowContent, font, brush, startX, startY)
                    End If
                Next

                ' Indicate that there are no more pages to print
                e.HasMorePages = False
            Else
                ' Display error message if BillingGv is Nothing
                MessageBox.Show("An error occurred while printing: BillingGv is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Display error message
            MessageBox.Show("An error occurred while printing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Check if QuantBox.Text and Stock.Text contain valid numbers
        Dim quantity As Integer
        Dim stockQuantity As Integer
        Dim unitPrice As Double ' Variable to store unit price
        If Integer.TryParse(QuantBox.Text, quantity) AndAlso Integer.TryParse(Stock.Text, stockQuantity) Then
            ' Both QuantBox.Text and Stock.Text are valid integers
            If quantity > stockQuantity Then
                MsgBox("Not enough " & BillingCombo.SelectedValue.ToString() & " in stock")
            ElseIf quantity <= stockQuantity Then
                ' Retrieve unit price from the database based on selected medicine
                Dim query As String = "SELECT SellingPrice FROM MedicineTable WHERE MedName = '" & BillingCombo.SelectedValue.ToString() & "'"
                Using cmd As New SqlCommand(query, Con)
                    Con.Open()
                    unitPrice = Convert.ToDouble(cmd.ExecuteScalar())
                    Con.Close()
                End Using

                ' Calculate total price
                Dim totalPrice As Double = quantity * unitPrice

                ' Add a new row to the DataGridView
                Dim rowIndex As Integer = BillingGv.Rows.Add()
                BillingGv.Rows(rowIndex).Cells("Column1").Value = i
                BillingGv.Rows(rowIndex).Cells("Column2").Value = BillingCombo.SelectedValue.ToString()
                BillingGv.Rows(rowIndex).Cells("Column3").Value = quantity
                BillingGv.Rows(rowIndex).Cells("Column4").Value = unitPrice
                BillingGv.Rows(rowIndex).Cells("Column5").Value = totalPrice
                Totalbox.Text = totalPrice

                ' Increment counter
                i += 1
            End If
        Else
            ' Either QuantBox.Text or Stock.Text is not a valid integer
            MsgBox("Invalid quantity or stock value. Please enter valid numbers.")
        End If
    End Sub


End Class