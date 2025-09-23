<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Me.lbCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.dgvBillDetails = New System.Windows.Forms.DataGridView()
        Me.btCreate = New System.Windows.Forms.Button()
        Me.lbClothes = New System.Windows.Forms.Label()
        Me.lbQuantity = New System.Windows.Forms.Label()
        Me.cbClothes = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        CType(Me.dgvBillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCustomerName
        '
        Me.lbCustomerName.AutoSize = True
        Me.lbCustomerName.Location = New System.Drawing.Point(278, 58)
        Me.lbCustomerName.Name = "lbCustomerName"
        Me.lbCustomerName.Size = New System.Drawing.Size(116, 15)
        Me.lbCustomerName.TabIndex = 1
        Me.lbCustomerName.Text = "Customer name: "
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(409, 58)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(173, 21)
        Me.txtCustomer.TabIndex = 2
        '
        'dgvBillDetails
        '
        Me.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillDetails.Location = New System.Drawing.Point(268, 205)
        Me.dgvBillDetails.Name = "dgvBillDetails"
        Me.dgvBillDetails.Size = New System.Drawing.Size(478, 223)
        Me.dgvBillDetails.TabIndex = 3
        '
        'btCreate
        '
        Me.btCreate.Location = New System.Drawing.Point(419, 458)
        Me.btCreate.Name = "btCreate"
        Me.btCreate.Size = New System.Drawing.Size(198, 23)
        Me.btCreate.TabIndex = 4
        Me.btCreate.Text = "Create bills"
        Me.btCreate.UseVisualStyleBackColor = True
        '
        'lbClothes
        '
        Me.lbClothes.AutoSize = True
        Me.lbClothes.Location = New System.Drawing.Point(180, 113)
        Me.lbClothes.Name = "lbClothes"
        Me.lbClothes.Size = New System.Drawing.Size(59, 15)
        Me.lbClothes.TabIndex = 5
        Me.lbClothes.Text = "Clothes:"
        '
        'lbQuantity
        '
        Me.lbQuantity.AutoSize = True
        Me.lbQuantity.Location = New System.Drawing.Point(505, 113)
        Me.lbQuantity.Name = "lbQuantity"
        Me.lbQuantity.Size = New System.Drawing.Size(63, 15)
        Me.lbQuantity.TabIndex = 6
        Me.lbQuantity.Text = "Quantity:"
        '
        'cbClothes
        '
        Me.cbClothes.FormattingEnabled = True
        Me.cbClothes.Location = New System.Drawing.Point(253, 113)
        Me.cbClothes.Name = "cbClothes"
        Me.cbClothes.Size = New System.Drawing.Size(121, 23)
        Me.cbClothes.TabIndex = 7
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(586, 113)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 21)
        Me.txtQuantity.TabIndex = 8
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(738, 113)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(90, 23)
        Me.btAdd.TabIndex = 9
        Me.btAdd.Text = "Add bills"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cbClothes)
        Me.Controls.Add(Me.lbQuantity)
        Me.Controls.Add(Me.lbClothes)
        Me.Controls.Add(Me.btCreate)
        Me.Controls.Add(Me.dgvBillDetails)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.lbCustomerName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Bill"
        Me.Text = "Bill"
        CType(Me.dgvBillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCustomerName As Label
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents dgvBillDetails As DataGridView
    Friend WithEvents btCreate As Button
    Friend WithEvents lbClothes As Label
    Friend WithEvents lbQuantity As Label
    Friend WithEvents cbClothes As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btAdd As Button
End Class
