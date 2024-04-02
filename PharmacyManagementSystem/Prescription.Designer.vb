<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prescription
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DosageBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CusIDBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MedNameBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PresBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PrescriptionGv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTb = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.CusNameBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.PrescriptionGv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1458, 115)
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
        Me.Label1.Location = New System.Drawing.Point(580, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PRESCRIPTION"
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
        'DosageBox
        '
        Me.DosageBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.DosageBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.DosageBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DosageBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DosageBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.DosageBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DosageBox.HintForeColor = System.Drawing.Color.Empty
        Me.DosageBox.HintText = ""
        Me.DosageBox.isPassword = False
        Me.DosageBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.DosageBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.DosageBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.DosageBox.LineThickness = 3
        Me.DosageBox.Location = New System.Drawing.Point(81, 558)
        Me.DosageBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DosageBox.MaxLength = 32767
        Me.DosageBox.Name = "DosageBox"
        Me.DosageBox.Size = New System.Drawing.Size(273, 36)
        Me.DosageBox.TabIndex = 49
        Me.DosageBox.Text = "Dosage"
        Me.DosageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(184, 759)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 34)
        Me.Button3.TabIndex = 48
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
        Me.Button2.Location = New System.Drawing.Point(289, 759)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 34)
        Me.Button2.TabIndex = 47
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
        Me.Button1.Location = New System.Drawing.Point(184, 811)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 34)
        Me.Button1.TabIndex = 46
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
        Me.Button4.Location = New System.Drawing.Point(81, 759)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 34)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CusIDBox
        '
        Me.CusIDBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CusIDBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CusIDBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CusIDBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CusIDBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CusIDBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CusIDBox.HintForeColor = System.Drawing.Color.Empty
        Me.CusIDBox.HintText = ""
        Me.CusIDBox.isPassword = False
        Me.CusIDBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.CusIDBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.CusIDBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.CusIDBox.LineThickness = 3
        Me.CusIDBox.Location = New System.Drawing.Point(81, 308)
        Me.CusIDBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CusIDBox.MaxLength = 32767
        Me.CusIDBox.Name = "CusIDBox"
        Me.CusIDBox.Size = New System.Drawing.Size(273, 33)
        Me.CusIDBox.TabIndex = 43
        Me.CusIDBox.Text = "CustomerID"
        Me.CusIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MedNameBox
        '
        Me.MedNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.MedNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.MedNameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MedNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MedNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.MedNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MedNameBox.HintForeColor = System.Drawing.Color.Empty
        Me.MedNameBox.HintText = ""
        Me.MedNameBox.isPassword = False
        Me.MedNameBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.MedNameBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.MedNameBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.MedNameBox.LineThickness = 3
        Me.MedNameBox.Location = New System.Drawing.Point(81, 483)
        Me.MedNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MedNameBox.MaxLength = 32767
        Me.MedNameBox.Name = "MedNameBox"
        Me.MedNameBox.Size = New System.Drawing.Size(273, 34)
        Me.MedNameBox.TabIndex = 41
        Me.MedNameBox.Text = "MedicineName"
        Me.MedNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PresBox
        '
        Me.PresBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PresBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PresBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PresBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PresBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.PresBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PresBox.HintForeColor = System.Drawing.Color.Empty
        Me.PresBox.HintText = ""
        Me.PresBox.isPassword = False
        Me.PresBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.PresBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.PresBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.PresBox.LineThickness = 3
        Me.PresBox.Location = New System.Drawing.Point(81, 227)
        Me.PresBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PresBox.MaxLength = 32767
        Me.PresBox.Name = "PresBox"
        Me.PresBox.Size = New System.Drawing.Size(273, 37)
        Me.PresBox.TabIndex = 40
        Me.PresBox.Text = "PrescriptionID"
        Me.PresBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PrescriptionGv
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.PrescriptionGv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrescriptionGv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.PrescriptionGv.ColumnHeadersHeight = 30
        Me.PrescriptionGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PrescriptionGv.DefaultCellStyle = DataGridViewCellStyle9
        Me.PrescriptionGv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrescriptionGv.Location = New System.Drawing.Point(514, 217)
        Me.PrescriptionGv.Name = "PrescriptionGv"
        Me.PrescriptionGv.RowHeadersVisible = False
        Me.PrescriptionGv.Size = New System.Drawing.Size(902, 628)
        Me.PrescriptionGv.TabIndex = 51
        Me.PrescriptionGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PrescriptionGv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PrescriptionGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PrescriptionGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PrescriptionGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PrescriptionGv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PrescriptionGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrescriptionGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrescriptionGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PrescriptionGv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrescriptionGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PrescriptionGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PrescriptionGv.ThemeStyle.HeaderStyle.Height = 30
        Me.PrescriptionGv.ThemeStyle.ReadOnly = False
        Me.PrescriptionGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PrescriptionGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PrescriptionGv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrescriptionGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PrescriptionGv.ThemeStyle.RowsStyle.Height = 22
        Me.PrescriptionGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrescriptionGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGreen
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(829, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 37)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Prescription Table"
        '
        'DateTb
        '
        Me.DateTb.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DateTb.Checked = True
        Me.DateTb.FillColor = System.Drawing.Color.DarkGreen
        Me.DateTb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTb.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTb.Location = New System.Drawing.Point(81, 645)
        Me.DateTb.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTb.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTb.Name = "DateTb"
        Me.DateTb.Size = New System.Drawing.Size(273, 43)
        Me.DateTb.TabIndex = 53
        Me.DateTb.Value = New Date(2024, 3, 16, 10, 13, 31, 638)
        '
        'CusNameBox
        '
        Me.CusNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CusNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CusNameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CusNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CusNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CusNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CusNameBox.HintForeColor = System.Drawing.Color.Empty
        Me.CusNameBox.HintText = ""
        Me.CusNameBox.isPassword = False
        Me.CusNameBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.CusNameBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.CusNameBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.CusNameBox.LineThickness = 3
        Me.CusNameBox.Location = New System.Drawing.Point(81, 407)
        Me.CusNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CusNameBox.MaxLength = 32767
        Me.CusNameBox.Name = "CusNameBox"
        Me.CusNameBox.Size = New System.Drawing.Size(273, 29)
        Me.CusNameBox.TabIndex = 42
        Me.CusNameBox.Text = "CustomerName"
        Me.CusNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1458, 857)
        Me.Controls.Add(Me.DateTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PrescriptionGv)
        Me.Controls.Add(Me.DosageBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CusIDBox)
        Me.Controls.Add(Me.CusNameBox)
        Me.Controls.Add(Me.MedNameBox)
        Me.Controls.Add(Me.PresBox)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Prescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PrescriptionGv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DosageBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CusIDBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MedNameBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PresBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PrescriptionGv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTb As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents CusNameBox As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
