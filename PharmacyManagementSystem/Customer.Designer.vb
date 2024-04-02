<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CustNameBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TeleBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.AddressBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CustIDBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CustomerGv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.CustomerGv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(592, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CUSTOMER"
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(153, 674)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 34)
        Me.Button3.TabIndex = 35
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
        Me.Button2.Location = New System.Drawing.Point(258, 674)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 34)
        Me.Button2.TabIndex = 34
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
        Me.Button1.Location = New System.Drawing.Point(153, 726)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 34)
        Me.Button1.TabIndex = 33
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
        Me.Button4.Location = New System.Drawing.Point(50, 674)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 34)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CustNameBox
        '
        Me.CustNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CustNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CustNameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CustNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CustNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustNameBox.HintForeColor = System.Drawing.Color.Empty
        Me.CustNameBox.HintText = ""
        Me.CustNameBox.isPassword = False
        Me.CustNameBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.CustNameBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.CustNameBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.CustNameBox.LineThickness = 3
        Me.CustNameBox.Location = New System.Drawing.Point(50, 364)
        Me.CustNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CustNameBox.MaxLength = 32767
        Me.CustNameBox.Name = "CustNameBox"
        Me.CustNameBox.Size = New System.Drawing.Size(273, 33)
        Me.CustNameBox.TabIndex = 30
        Me.CustNameBox.Text = "CustomerName"
        Me.CustNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TeleBox
        '
        Me.TeleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TeleBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TeleBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TeleBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TeleBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TeleBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TeleBox.HintForeColor = System.Drawing.Color.Empty
        Me.TeleBox.HintText = ""
        Me.TeleBox.isPassword = False
        Me.TeleBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.TeleBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.TeleBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.TeleBox.LineThickness = 3
        Me.TeleBox.Location = New System.Drawing.Point(50, 463)
        Me.TeleBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TeleBox.MaxLength = 32767
        Me.TeleBox.Name = "TeleBox"
        Me.TeleBox.Size = New System.Drawing.Size(273, 29)
        Me.TeleBox.TabIndex = 29
        Me.TeleBox.Text = "Telephone"
        Me.TeleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddressBox
        '
        Me.AddressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.AddressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.AddressBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AddressBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.AddressBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddressBox.HintForeColor = System.Drawing.Color.Empty
        Me.AddressBox.HintText = ""
        Me.AddressBox.isPassword = False
        Me.AddressBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.AddressBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.AddressBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.AddressBox.LineThickness = 3
        Me.AddressBox.Location = New System.Drawing.Point(50, 562)
        Me.AddressBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressBox.MaxLength = 32767
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(273, 34)
        Me.AddressBox.TabIndex = 28
        Me.AddressBox.Text = "Address"
        Me.AddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CustIDBox
        '
        Me.CustIDBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CustIDBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CustIDBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CustIDBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustIDBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CustIDBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustIDBox.HintForeColor = System.Drawing.Color.Empty
        Me.CustIDBox.HintText = ""
        Me.CustIDBox.isPassword = False
        Me.CustIDBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.CustIDBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.CustIDBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.CustIDBox.LineThickness = 3
        Me.CustIDBox.Location = New System.Drawing.Point(50, 283)
        Me.CustIDBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CustIDBox.MaxLength = 32767
        Me.CustIDBox.Name = "CustIDBox"
        Me.CustIDBox.Size = New System.Drawing.Size(273, 37)
        Me.CustIDBox.TabIndex = 27
        Me.CustIDBox.Text = "CustomerID"
        Me.CustIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CustomerGv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.CustomerGv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerGv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerGv.ColumnHeadersHeight = 30
        Me.CustomerGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerGv.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomerGv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerGv.Location = New System.Drawing.Point(515, 256)
        Me.CustomerGv.Name = "CustomerGv"
        Me.CustomerGv.RowHeadersVisible = False
        Me.CustomerGv.Size = New System.Drawing.Size(902, 504)
        Me.CustomerGv.TabIndex = 36
        Me.CustomerGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CustomerGv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CustomerGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CustomerGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CustomerGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CustomerGv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CustomerGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CustomerGv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CustomerGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CustomerGv.ThemeStyle.HeaderStyle.Height = 30
        Me.CustomerGv.ThemeStyle.ReadOnly = False
        Me.CustomerGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CustomerGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CustomerGv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CustomerGv.ThemeStyle.RowsStyle.Height = 22
        Me.CustomerGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGreen
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(828, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 37)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Customer Table"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1463, 799)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CustomerGv)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CustNameBox)
        Me.Controls.Add(Me.TeleBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.CustIDBox)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CustomerGv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CustNameBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TeleBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents AddressBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CustIDBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CustomerGv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
End Class
