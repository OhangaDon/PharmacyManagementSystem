<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manufacturer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CompNameBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PhoneBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CompAddressBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CompIDBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ManufacturerGv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.ManufacturerGv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1465, 115)
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(555, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MANUFACTURER"
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
        'CompNameBox
        '
        Me.CompNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CompNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CompNameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CompNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CompNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CompNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CompNameBox.HintForeColor = System.Drawing.Color.Empty
        Me.CompNameBox.HintText = ""
        Me.CompNameBox.isPassword = False
        Me.CompNameBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.CompNameBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.CompNameBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.CompNameBox.LineThickness = 3
        Me.CompNameBox.Location = New System.Drawing.Point(90, 452)
        Me.CompNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompNameBox.MaxLength = 32767
        Me.CompNameBox.Name = "CompNameBox"
        Me.CompNameBox.Size = New System.Drawing.Size(273, 33)
        Me.CompNameBox.TabIndex = 34
        Me.CompNameBox.Text = "CompanyName"
        Me.CompNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PhoneBox
        '
        Me.PhoneBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PhoneBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PhoneBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PhoneBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.PhoneBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneBox.HintForeColor = System.Drawing.Color.Empty
        Me.PhoneBox.HintText = ""
        Me.PhoneBox.isPassword = False
        Me.PhoneBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.PhoneBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.PhoneBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.PhoneBox.LineThickness = 3
        Me.PhoneBox.Location = New System.Drawing.Point(89, 533)
        Me.PhoneBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneBox.MaxLength = 32767
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(273, 29)
        Me.PhoneBox.TabIndex = 33
        Me.PhoneBox.Text = "Phone"
        Me.PhoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CompAddressBox
        '
        Me.CompAddressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CompAddressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CompAddressBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CompAddressBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CompAddressBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CompAddressBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CompAddressBox.HintForeColor = System.Drawing.Color.Empty
        Me.CompAddressBox.HintText = ""
        Me.CompAddressBox.isPassword = False
        Me.CompAddressBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.CompAddressBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.CompAddressBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.CompAddressBox.LineThickness = 3
        Me.CompAddressBox.Location = New System.Drawing.Point(89, 609)
        Me.CompAddressBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompAddressBox.MaxLength = 32767
        Me.CompAddressBox.Name = "CompAddressBox"
        Me.CompAddressBox.Size = New System.Drawing.Size(273, 34)
        Me.CompAddressBox.TabIndex = 32
        Me.CompAddressBox.Text = "CompanyAddress"
        Me.CompAddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CompIDBox
        '
        Me.CompIDBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CompIDBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CompIDBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CompIDBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CompIDBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CompIDBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CompIDBox.HintForeColor = System.Drawing.Color.Empty
        Me.CompIDBox.HintText = ""
        Me.CompIDBox.isPassword = False
        Me.CompIDBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.CompIDBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.CompIDBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.CompIDBox.LineThickness = 3
        Me.CompIDBox.Location = New System.Drawing.Point(89, 353)
        Me.CompIDBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompIDBox.MaxLength = 32767
        Me.CompIDBox.Name = "CompIDBox"
        Me.CompIDBox.Size = New System.Drawing.Size(273, 37)
        Me.CompIDBox.TabIndex = 31
        Me.CompIDBox.Text = "CompanyID"
        Me.CompIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGreen
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(806, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 37)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Manufacturer Table"
        '
        'ManufacturerGv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ManufacturerGv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ManufacturerGv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ManufacturerGv.ColumnHeadersHeight = 30
        Me.ManufacturerGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ManufacturerGv.DefaultCellStyle = DataGridViewCellStyle3
        Me.ManufacturerGv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ManufacturerGv.Location = New System.Drawing.Point(493, 254)
        Me.ManufacturerGv.Name = "ManufacturerGv"
        Me.ManufacturerGv.RowHeadersVisible = False
        Me.ManufacturerGv.Size = New System.Drawing.Size(902, 628)
        Me.ManufacturerGv.TabIndex = 38
        Me.ManufacturerGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ManufacturerGv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ManufacturerGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ManufacturerGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ManufacturerGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ManufacturerGv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ManufacturerGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ManufacturerGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ManufacturerGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ManufacturerGv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ManufacturerGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ManufacturerGv.ThemeStyle.HeaderStyle.Height = 30
        Me.ManufacturerGv.ThemeStyle.ReadOnly = False
        Me.ManufacturerGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ManufacturerGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ManufacturerGv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ManufacturerGv.ThemeStyle.RowsStyle.Height = 22
        Me.ManufacturerGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ManufacturerGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(193, 758)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 34)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(298, 758)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 34)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(193, 810)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 34)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(90, 758)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 34)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Manufacturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1465, 935)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ManufacturerGv)
        Me.Controls.Add(Me.CompNameBox)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.CompAddressBox)
        Me.Controls.Add(Me.CompIDBox)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Manufacturer"
        Me.Text = "Manufacturer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ManufacturerGv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CompNameBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PhoneBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CompAddressBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CompIDBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents ManufacturerGv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
End Class
