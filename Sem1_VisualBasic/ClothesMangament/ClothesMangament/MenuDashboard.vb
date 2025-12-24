Public Class MenuDashboard
    Public Property CurrentRole As String  ' lưu role khi login

    Private Sub MenuDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Phân quyền
        If CurrentRole = "staff" Then
            btClothesTypes.Enabled = False   ' staff không sửa loại quần áo
        ElseIf CurrentRole = "admin" Then
            btClothesTypes.Enabled = True    ' admin full quyền
        End If
    End Sub

    Private Sub btClothes_Click(sender As Object, e As EventArgs) Handles btClothes.Click
        'Me.Hide()
        Clothes.Show()
    End Sub

    Private Sub btClothesTypes_Click(sender As Object, e As EventArgs) Handles btClothesTypes.Click
        'Me.Hide()
        ClothesType.Show()
    End Sub

    Private Sub btBills_Click(sender As Object, e As EventArgs) Handles btBills.Click
        'Me.Hide()
        Bill.Show()
    End Sub

    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Me.Hide()
        LoginRegister.Show()
    End Sub
End Class