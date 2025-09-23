<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginRegister
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
        Me.lbLoginRegister = New System.Windows.Forms.Label()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.btRegister = New System.Windows.Forms.Button()
        Me.lbRoles = New System.Windows.Forms.Label()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.btTogglePasswordText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbLoginRegister
        '
        Me.lbLoginRegister.AutoSize = True
        Me.lbLoginRegister.Location = New System.Drawing.Point(418, 95)
        Me.lbLoginRegister.Name = "lbLoginRegister"
        Me.lbLoginRegister.Size = New System.Drawing.Size(110, 16)
        Me.lbLoginRegister.TabIndex = 0
        Me.lbLoginRegister.Text = "Login/Register"
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Location = New System.Drawing.Point(156, 197)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(79, 16)
        Me.lbUsername.TabIndex = 1
        Me.lbUsername.Text = "Username"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(159, 259)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(76, 16)
        Me.lbPassword.TabIndex = 2
        Me.lbPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(292, 192)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(278, 22)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(292, 259)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(278, 22)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(246, 410)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 23)
        Me.btLogin.TabIndex = 5
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'btRegister
        '
        Me.btRegister.Location = New System.Drawing.Point(469, 410)
        Me.btRegister.Name = "btRegister"
        Me.btRegister.Size = New System.Drawing.Size(75, 23)
        Me.btRegister.TabIndex = 6
        Me.btRegister.Text = "Register"
        Me.btRegister.UseVisualStyleBackColor = True
        '
        'lbRoles
        '
        Me.lbRoles.AutoSize = True
        Me.lbRoles.Location = New System.Drawing.Point(159, 332)
        Me.lbRoles.Name = "lbRoles"
        Me.lbRoles.Size = New System.Drawing.Size(49, 16)
        Me.lbRoles.TabIndex = 7
        Me.lbRoles.Text = "Roles"
        '
        'cbRole
        '
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Items.AddRange(New Object() {""})
        Me.cbRole.Location = New System.Drawing.Point(292, 332)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(278, 24)
        Me.cbRole.TabIndex = 8
        '
        'btTogglePasswordText
        '
        Me.btTogglePasswordText.Location = New System.Drawing.Point(591, 259)
        Me.btTogglePasswordText.Name = "btTogglePasswordText"
        Me.btTogglePasswordText.Size = New System.Drawing.Size(75, 23)
        Me.btTogglePasswordText.TabIndex = 9
        Me.btTogglePasswordText.Text = "🙈"
        Me.btTogglePasswordText.UseVisualStyleBackColor = True
        '
        'LoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 554)
        Me.Controls.Add(Me.btTogglePasswordText)
        Me.Controls.Add(Me.cbRole)
        Me.Controls.Add(Me.lbRoles)
        Me.Controls.Add(Me.btRegister)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUsername)
        Me.Controls.Add(Me.lbLoginRegister)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginRegister"
        Me.Text = "LoginRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbLoginRegister As Label
    Friend WithEvents lbUsername As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btLogin As Button
    Friend WithEvents btRegister As Button
    Friend WithEvents lbRoles As Label
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btTogglePasswordText As Button
End Class
