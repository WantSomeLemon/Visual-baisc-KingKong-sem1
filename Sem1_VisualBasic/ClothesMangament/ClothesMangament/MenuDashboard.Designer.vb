<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuDashboard
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
        Me.lbMenuDashBoard = New System.Windows.Forms.Label()
        Me.btClothes = New System.Windows.Forms.Button()
        Me.btClothesTypes = New System.Windows.Forms.Button()
        Me.btBills = New System.Windows.Forms.Button()
        Me.btLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbMenuDashBoard
        '
        Me.lbMenuDashBoard.AutoSize = True
        Me.lbMenuDashBoard.Location = New System.Drawing.Point(457, 93)
        Me.lbMenuDashBoard.Name = "lbMenuDashBoard"
        Me.lbMenuDashBoard.Size = New System.Drawing.Size(78, 15)
        Me.lbMenuDashBoard.TabIndex = 0
        Me.lbMenuDashBoard.Text = "DashBoard"
        '
        'btClothes
        '
        Me.btClothes.Location = New System.Drawing.Point(432, 141)
        Me.btClothes.Name = "btClothes"
        Me.btClothes.Size = New System.Drawing.Size(141, 23)
        Me.btClothes.TabIndex = 1
        Me.btClothes.Text = "Clothes"
        Me.btClothes.UseVisualStyleBackColor = True
        '
        'btClothesTypes
        '
        Me.btClothesTypes.Location = New System.Drawing.Point(432, 207)
        Me.btClothesTypes.Name = "btClothesTypes"
        Me.btClothesTypes.Size = New System.Drawing.Size(141, 23)
        Me.btClothesTypes.TabIndex = 6
        Me.btClothesTypes.Text = "Clothes Types"
        Me.btClothesTypes.UseVisualStyleBackColor = True
        '
        'btBills
        '
        Me.btBills.Location = New System.Drawing.Point(432, 267)
        Me.btBills.Name = "btBills"
        Me.btBills.Size = New System.Drawing.Size(141, 23)
        Me.btBills.TabIndex = 7
        Me.btBills.Text = "Bills"
        Me.btBills.UseVisualStyleBackColor = True
        '
        'btLogout
        '
        Me.btLogout.Location = New System.Drawing.Point(432, 338)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Size = New System.Drawing.Size(141, 23)
        Me.btLogout.TabIndex = 8
        Me.btLogout.Text = "Logout"
        Me.btLogout.UseVisualStyleBackColor = True
        '
        'MenuDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.btLogout)
        Me.Controls.Add(Me.btBills)
        Me.Controls.Add(Me.btClothesTypes)
        Me.Controls.Add(Me.btClothes)
        Me.Controls.Add(Me.lbMenuDashBoard)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MenuDashboard"
        Me.Text = "Menu Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMenuDashBoard As Label
    Friend WithEvents btClothes As Button
    Friend WithEvents btClothesTypes As Button
    Friend WithEvents btBills As Button
    Friend WithEvents btLogout As Button
End Class
