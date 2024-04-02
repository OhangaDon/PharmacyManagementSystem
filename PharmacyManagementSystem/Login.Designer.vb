<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PassWordTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(98, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Login"
        '
        'UnameTb
        '
        Me.UnameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.UnameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.UnameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UnameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.UnameTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UnameTb.HintForeColor = System.Drawing.Color.Empty
        Me.UnameTb.HintText = ""
        Me.UnameTb.isPassword = False
        Me.UnameTb.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.UnameTb.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.UnameTb.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.UnameTb.LineThickness = 3
        Me.UnameTb.Location = New System.Drawing.Point(13, 101)
        Me.UnameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.UnameTb.MaxLength = 32767
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.Size = New System.Drawing.Size(301, 37)
        Me.UnameTb.TabIndex = 3
        Me.UnameTb.Text = "UserName"
        Me.UnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PassWordTb
        '
        Me.PassWordTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.PassWordTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.PassWordTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PassWordTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PassWordTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.PassWordTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PassWordTb.HintForeColor = System.Drawing.Color.Empty
        Me.PassWordTb.HintText = ""
        Me.PassWordTb.isPassword = False
        Me.PassWordTb.LineFocusedColor = System.Drawing.Color.DarkGreen
        Me.PassWordTb.LineIdleColor = System.Drawing.Color.DarkGreen
        Me.PassWordTb.LineMouseHoverColor = System.Drawing.Color.DarkGreen
        Me.PassWordTb.LineThickness = 3
        Me.PassWordTb.Location = New System.Drawing.Point(13, 191)
        Me.PassWordTb.Margin = New System.Windows.Forms.Padding(4)
        Me.PassWordTb.MaxLength = 32767
        Me.PassWordTb.Name = "PassWordTb"
        Me.PassWordTb.Size = New System.Drawing.Size(301, 37)
        Me.PassWordTb.TabIndex = 4
        Me.PassWordTb.Text = "Password"
        Me.PassWordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(12, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(301, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Himalaya", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(278, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Close"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(326, 390)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PassWordTb)
        Me.Controls.Add(Me.UnameTb)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents UnameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PassWordTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
