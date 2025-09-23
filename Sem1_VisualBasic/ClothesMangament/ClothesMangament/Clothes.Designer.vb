<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clothes
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
        Me.dgvClothes = New System.Windows.Forms.DataGridView()
        Me.lbName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbType = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lbColor = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Quantity = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.btReload = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        CType(Me.dgvClothes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClothes
        '
        Me.dgvClothes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClothes.Location = New System.Drawing.Point(110, 30)
        Me.dgvClothes.Name = "dgvClothes"
        Me.dgvClothes.Size = New System.Drawing.Size(720, 244)
        Me.dgvClothes.TabIndex = 3
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(119, 336)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(49, 15)
        Me.lbName.TabIndex = 4
        Me.lbName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(203, 336)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 21)
        Me.txtName.TabIndex = 5
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.Location = New System.Drawing.Point(389, 336)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(41, 15)
        Me.lbType.TabIndex = 6
        Me.lbType.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(682, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Size:"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(203, 399)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 21)
        Me.txtColor.TabIndex = 11
        '
        'lbColor
        '
        Me.lbColor.AutoSize = True
        Me.lbColor.Location = New System.Drawing.Point(119, 399)
        Me.lbColor.Name = "lbColor"
        Me.lbColor.Size = New System.Drawing.Size(45, 15)
        Me.lbColor.TabIndex = 10
        Me.lbColor.Text = "Color:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(473, 396)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 21)
        Me.txtPrice.TabIndex = 13
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Location = New System.Drawing.Point(389, 396)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(44, 15)
        Me.lbPrice.TabIndex = 12
        Me.lbPrice.Text = "Price:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(766, 399)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 21)
        Me.txtQuantity.TabIndex = 15
        '
        'Quantity
        '
        Me.Quantity.AutoSize = True
        Me.Quantity.Location = New System.Drawing.Point(682, 399)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(59, 15)
        Me.Quantity.TabIndex = 14
        Me.Quantity.Text = "Quantity"
        '
        'cbType
        '
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(473, 336)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(121, 23)
        Me.cbType.TabIndex = 20
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Location = New System.Drawing.Point(766, 333)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(121, 23)
        Me.cbSize.TabIndex = 21
        '
        'btReload
        '
        Me.btReload.Location = New System.Drawing.Point(649, 465)
        Me.btReload.Name = "btReload"
        Me.btReload.Size = New System.Drawing.Size(75, 23)
        Me.btReload.TabIndex = 25
        Me.btReload.Text = "Reload"
        Me.btReload.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(521, 465)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 23)
        Me.btDelete.TabIndex = 24
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(392, 465)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 23)
        Me.btEdit.TabIndex = 23
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(267, 465)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 22
        Me.btAdd.Text = "Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'Clothes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.btReload)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.lbColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.dgvClothes)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Clothes"
        Me.Text = "Clothes"
        CType(Me.dgvClothes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClothes As DataGridView
    Friend WithEvents lbName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbType As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lbColor As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lbPrice As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Quantity As Label
    Friend WithEvents cbType As ComboBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents btReload As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btAdd As Button
End Class
