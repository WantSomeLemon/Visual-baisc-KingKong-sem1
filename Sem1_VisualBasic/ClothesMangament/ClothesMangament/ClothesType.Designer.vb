<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClothesType
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
        Me.lbClothesTypes = New System.Windows.Forms.Label()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.dgvTypes = New System.Windows.Forms.DataGridView()
        Me.btReload = New System.Windows.Forms.Button()
        Me.txtTypeName = New System.Windows.Forms.TextBox()
        CType(Me.dgvTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbClothesTypes
        '
        Me.lbClothesTypes.AutoSize = True
        Me.lbClothesTypes.Location = New System.Drawing.Point(353, 98)
        Me.lbClothesTypes.Name = "lbClothesTypes"
        Me.lbClothesTypes.Size = New System.Drawing.Size(96, 15)
        Me.lbClothesTypes.TabIndex = 0
        Me.lbClothesTypes.Text = "Clothes Types"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(313, 182)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 1
        Me.btAdd.Text = "Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(438, 182)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 23)
        Me.btEdit.TabIndex = 2
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(567, 182)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 23)
        Me.btDelete.TabIndex = 3
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'dgvTypes
        '
        Me.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTypes.Location = New System.Drawing.Point(324, 239)
        Me.dgvTypes.Name = "dgvTypes"
        Me.dgvTypes.Size = New System.Drawing.Size(391, 239)
        Me.dgvTypes.TabIndex = 4
        '
        'btReload
        '
        Me.btReload.Location = New System.Drawing.Point(695, 182)
        Me.btReload.Name = "btReload"
        Me.btReload.Size = New System.Drawing.Size(75, 23)
        Me.btReload.TabIndex = 5
        Me.btReload.Text = "Reload"
        Me.btReload.UseVisualStyleBackColor = True
        '
        'txtTypeName
        '
        Me.txtTypeName.Location = New System.Drawing.Point(483, 98)
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.Size = New System.Drawing.Size(180, 21)
        Me.txtTypeName.TabIndex = 6
        '
        'ClothesType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.txtTypeName)
        Me.Controls.Add(Me.btReload)
        Me.Controls.Add(Me.dgvTypes)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.lbClothesTypes)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ClothesType"
        Me.Text = "ClothesType"
        CType(Me.dgvTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbClothesTypes As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents dgvTypes As DataGridView
    Friend WithEvents btReload As Button
    Friend WithEvents txtTypeName As TextBox
End Class
