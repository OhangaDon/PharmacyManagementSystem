<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agent
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.EmpNameBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.EmpSalaryBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.EmpAgeBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.EmpIDBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.AgentGv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PhoneBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PasswordBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.AgentGv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        Me.Label1.Size = New System.Drawing.Size(139, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "AGENT"
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
        Me.Button3.Location = New System.Drawing.Point(176, 810)
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
        Me.Button2.Location = New System.Drawing.Point(281, 810)
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
        Me.Button1.Location = New System.Drawing.Point(176, 862)
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
        Me.Button4.Location = New System.Drawing.Point(73, 810)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 34)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'EmpNameBox
        '
        Me.EmpNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.EmpNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.EmpNameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.EmpNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmpNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.EmpNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmpNameBox.HintForeColor = System.Drawing.Color.Empty
        Me.EmpNameBox.HintText = ""
        Me.EmpNameBox.isPassword = False
        Me.EmpNameBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.EmpNameBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.EmpNameBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.EmpNameBox.LineThickness = 3
        Me.EmpNameBox.Location = New System.Drawing.Point(73, 359)
        Me.EmpNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpNameBox.MaxLength = 32767
        Me.EmpNameBox.Name = "EmpNameBox"
        Me.EmpNameBox.Size = New System.Drawing.Size(273, 33)
        Me.EmpNameBox.TabIndex = 30
        Me.EmpNameBox.Text = "EmployeeName"
        Me.EmpNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'EmpSalaryBox
        '
        Me.EmpSalaryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.EmpSalaryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.EmpSalaryBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.EmpSalaryBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmpSalaryBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.EmpSalaryBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmpSalaryBox.HintForeColor = System.Drawing.Color.Empty
        Me.EmpSalaryBox.HintText = ""
        Me.EmpSalaryBox.isPassword = False
        Me.EmpSalaryBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.EmpSalaryBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.EmpSalaryBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.EmpSalaryBox.LineThickness = 3
        Me.EmpSalaryBox.Location = New System.Drawing.Point(73, 458)
        Me.EmpSalaryBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpSalaryBox.MaxLength = 32767
        Me.EmpSalaryBox.Name = "EmpSalaryBox"
        Me.EmpSalaryBox.Size = New System.Drawing.Size(273, 29)
        Me.EmpSalaryBox.TabIndex = 29
        Me.EmpSalaryBox.Text = "EmployeeSalary"
        Me.EmpSalaryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'EmpAgeBox
        '
        Me.EmpAgeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.EmpAgeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.EmpAgeBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.EmpAgeBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmpAgeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.EmpAgeBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmpAgeBox.HintForeColor = System.Drawing.Color.Empty
        Me.EmpAgeBox.HintText = ""
        Me.EmpAgeBox.isPassword = False
        Me.EmpAgeBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.EmpAgeBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.EmpAgeBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.EmpAgeBox.LineThickness = 3
        Me.EmpAgeBox.Location = New System.Drawing.Point(73, 534)
        Me.EmpAgeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpAgeBox.MaxLength = 32767
        Me.EmpAgeBox.Name = "EmpAgeBox"
        Me.EmpAgeBox.Size = New System.Drawing.Size(273, 34)
        Me.EmpAgeBox.TabIndex = 28
        Me.EmpAgeBox.Text = "EmployeeAge"
        Me.EmpAgeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'EmpIDBox
        '
        Me.EmpIDBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.EmpIDBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.EmpIDBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.EmpIDBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmpIDBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.EmpIDBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmpIDBox.HintForeColor = System.Drawing.Color.Empty
        Me.EmpIDBox.HintText = ""
        Me.EmpIDBox.isPassword = False
        Me.EmpIDBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.EmpIDBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.EmpIDBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.EmpIDBox.LineThickness = 3
        Me.EmpIDBox.Location = New System.Drawing.Point(73, 278)
        Me.EmpIDBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpIDBox.MaxLength = 32767
        Me.EmpIDBox.Name = "EmpIDBox"
        Me.EmpIDBox.Size = New System.Drawing.Size(273, 37)
        Me.EmpIDBox.TabIndex = 27
        Me.EmpIDBox.Text = "EmployeeID"
        Me.EmpIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AgentGv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.AgentGv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgentGv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AgentGv.ColumnHeadersHeight = 30
        Me.AgentGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AgentGv.DefaultCellStyle = DataGridViewCellStyle3
        Me.AgentGv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgentGv.Location = New System.Drawing.Point(515, 249)
        Me.AgentGv.Name = "AgentGv"
        Me.AgentGv.RowHeadersVisible = False
        Me.AgentGv.Size = New System.Drawing.Size(902, 628)
        Me.AgentGv.TabIndex = 36
        Me.AgentGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AgentGv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.AgentGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.AgentGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.AgentGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.AgentGv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.AgentGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgentGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgentGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AgentGv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgentGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.AgentGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.AgentGv.ThemeStyle.HeaderStyle.Height = 30
        Me.AgentGv.ThemeStyle.ReadOnly = False
        Me.AgentGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AgentGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AgentGv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgentGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.AgentGv.ThemeStyle.RowsStyle.Height = 22
        Me.AgentGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgentGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGreen
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(884, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 37)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Agent Table"
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
        Me.PhoneBox.Location = New System.Drawing.Point(73, 611)
        Me.PhoneBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneBox.MaxLength = 32767
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(273, 34)
        Me.PhoneBox.TabIndex = 38
        Me.PhoneBox.Text = "Phone"
        Me.PhoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PasswordBox
        '
        Me.PasswordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PasswordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PasswordBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordBox.HintForeColor = System.Drawing.Color.Empty
        Me.PasswordBox.HintText = ""
        Me.PasswordBox.isPassword = False
        Me.PasswordBox.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.PasswordBox.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.PasswordBox.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.PasswordBox.LineThickness = 3
        Me.PasswordBox.Location = New System.Drawing.Point(73, 696)
        Me.PasswordBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordBox.MaxLength = 32767
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(273, 34)
        Me.PasswordBox.TabIndex = 39
        Me.PasswordBox.Text = "Password"
        Me.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Agent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1465, 935)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AgentGv)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.EmpNameBox)
        Me.Controls.Add(Me.EmpSalaryBox)
        Me.Controls.Add(Me.EmpAgeBox)
        Me.Controls.Add(Me.EmpIDBox)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AgentGv, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EmpNameBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents EmpSalaryBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents EmpAgeBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents EmpIDBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents AgentGv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents PhoneBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PasswordBox As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
