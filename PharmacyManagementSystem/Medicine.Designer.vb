<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medicine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MedicineTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.QuantityTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SellingPriceTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BuyingPriceTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CompCb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.MedicineGv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ExpDateTb = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.MedicineGv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1463, 115)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1424, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 40)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(592, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MEDICINE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(482, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(452, 64)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NezukoPharmacy"
        '
        'MedicineTb
        '
        Me.MedicineTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.MedicineTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.MedicineTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MedicineTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MedicineTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.MedicineTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MedicineTb.HintForeColor = System.Drawing.Color.Empty
        Me.MedicineTb.HintText = ""
        Me.MedicineTb.isPassword = False
        Me.MedicineTb.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.MedicineTb.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.MedicineTb.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.MedicineTb.LineThickness = 3
        Me.MedicineTb.Location = New System.Drawing.Point(75, 292)
        Me.MedicineTb.Margin = New System.Windows.Forms.Padding(4)
        Me.MedicineTb.MaxLength = 32767
        Me.MedicineTb.Name = "MedicineTb"
        Me.MedicineTb.Size = New System.Drawing.Size(273, 37)
        Me.MedicineTb.TabIndex = 4
        Me.MedicineTb.Text = "MedicineName"
        Me.MedicineTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'QuantityTb
        '
        Me.QuantityTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.QuantityTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.QuantityTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.QuantityTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.QuantityTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QuantityTb.HintForeColor = System.Drawing.Color.Empty
        Me.QuantityTb.HintText = ""
        Me.QuantityTb.isPassword = False
        Me.QuantityTb.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.QuantityTb.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.QuantityTb.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.QuantityTb.LineThickness = 3
        Me.QuantityTb.Location = New System.Drawing.Point(75, 511)
        Me.QuantityTb.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTb.MaxLength = 32767
        Me.QuantityTb.Name = "QuantityTb"
        Me.QuantityTb.Size = New System.Drawing.Size(273, 34)
        Me.QuantityTb.TabIndex = 5
        Me.QuantityTb.Text = "Quantity"
        Me.QuantityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SellingPriceTb
        '
        Me.SellingPriceTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.SellingPriceTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.SellingPriceTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SellingPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SellingPriceTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.SellingPriceTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SellingPriceTb.HintForeColor = System.Drawing.Color.Empty
        Me.SellingPriceTb.HintText = ""
        Me.SellingPriceTb.isPassword = False
        Me.SellingPriceTb.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.SellingPriceTb.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.SellingPriceTb.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.SellingPriceTb.LineThickness = 3
        Me.SellingPriceTb.Location = New System.Drawing.Point(75, 435)
        Me.SellingPriceTb.Margin = New System.Windows.Forms.Padding(4)
        Me.SellingPriceTb.MaxLength = 32767
        Me.SellingPriceTb.Name = "SellingPriceTb"
        Me.SellingPriceTb.Size = New System.Drawing.Size(273, 29)
        Me.SellingPriceTb.TabIndex = 6
        Me.SellingPriceTb.Text = "SellingPrice"
        Me.SellingPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BuyingPriceTb
        '
        Me.BuyingPriceTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BuyingPriceTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BuyingPriceTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BuyingPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BuyingPriceTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BuyingPriceTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BuyingPriceTb.HintForeColor = System.Drawing.Color.Empty
        Me.BuyingPriceTb.HintText = ""
        Me.BuyingPriceTb.isPassword = False
        Me.BuyingPriceTb.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.BuyingPriceTb.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.BuyingPriceTb.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.BuyingPriceTb.LineThickness = 3
        Me.BuyingPriceTb.Location = New System.Drawing.Point(75, 361)
        Me.BuyingPriceTb.Margin = New System.Windows.Forms.Padding(4)
        Me.BuyingPriceTb.MaxLength = 32767
        Me.BuyingPriceTb.Name = "BuyingPriceTb"
        Me.BuyingPriceTb.Size = New System.Drawing.Size(273, 33)
        Me.BuyingPriceTb.TabIndex = 7
        Me.BuyingPriceTb.Text = "BuyingPrice"
        Me.BuyingPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CompCb
        '
        Me.CompCb.BackColor = System.Drawing.Color.Transparent
        Me.CompCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CompCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompCb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompCb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CompCb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CompCb.ItemHeight = 30
        Me.CompCb.Location = New System.Drawing.Point(75, 629)
        Me.CompCb.Name = "CompCb"
        Me.CompCb.Size = New System.Drawing.Size(273, 36)
        Me.CompCb.TabIndex = 8
        '
        'MedicineGv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.MedicineGv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MedicineGv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MedicineGv.ColumnHeadersHeight = 30
        Me.MedicineGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedicineGv.DefaultCellStyle = DataGridViewCellStyle3
        Me.MedicineGv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineGv.Location = New System.Drawing.Point(509, 254)
        Me.MedicineGv.Name = "MedicineGv"
        Me.MedicineGv.RowHeadersVisible = False
        Me.MedicineGv.Size = New System.Drawing.Size(902, 504)
        Me.MedicineGv.TabIndex = 9
        Me.MedicineGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.MedicineGv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.MedicineGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.MedicineGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.MedicineGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.MedicineGv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.MedicineGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MedicineGv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.MedicineGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.MedicineGv.ThemeStyle.HeaderStyle.Height = 30
        Me.MedicineGv.ThemeStyle.ReadOnly = False
        Me.MedicineGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.MedicineGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.MedicineGv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.MedicineGv.ThemeStyle.RowsStyle.Height = 22
        Me.MedicineGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGreen
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(855, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 37)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Medicine Table"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(75, 687)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 34)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(178, 739)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 34)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(283, 687)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 34)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(178, 687)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 34)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ExpDateTb
        '
        Me.ExpDateTb.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExpDateTb.Checked = True
        Me.ExpDateTb.FillColor = System.Drawing.Color.DarkGreen
        Me.ExpDateTb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ExpDateTb.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.ExpDateTb.Location = New System.Drawing.Point(75, 563)
        Me.ExpDateTb.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ExpDateTb.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ExpDateTb.Name = "ExpDateTb"
        Me.ExpDateTb.Size = New System.Drawing.Size(273, 43)
        Me.ExpDateTb.TabIndex = 18
        Me.ExpDateTb.Value = New Date(2024, 3, 16, 10, 13, 31, 638)
        '
        'Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1463, 799)
        Me.Controls.Add(Me.ExpDateTb)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MedicineGv)
        Me.Controls.Add(Me.CompCb)
        Me.Controls.Add(Me.BuyingPriceTb)
        Me.Controls.Add(Me.SellingPriceTb)
        Me.Controls.Add(Me.QuantityTb)
        Me.Controls.Add(Me.MedicineTb)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Medicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MedicineGv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MedicineTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents QuantityTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents SellingPriceTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BuyingPriceTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CompCb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents MedicineGv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ExpDateTb As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
