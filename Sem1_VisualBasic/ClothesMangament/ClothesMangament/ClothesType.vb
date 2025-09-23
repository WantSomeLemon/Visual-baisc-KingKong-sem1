Imports MySql.Data.MySqlClient

Public Class ClothesType

    ' Load dữ liệu từ DB
    Private Sub LoadTypes()
        Using conn = Database.GetConnection()
            Dim da As New MySqlDataAdapter("SELECT id, name FROM clothes_type", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvTypes.DataSource = dt
        End Using
    End Sub

    Private Sub ClothesType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTypes()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtTypeName.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập tên loại quần áo.")
            Return
        End If

        Using conn = Database.GetConnection()
            Dim cmd As New MySqlCommand("INSERT INTO clothes_type(name) VALUES(@n)", conn)
            cmd.Parameters.AddWithValue("@n", txtTypeName.Text.Trim())

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Thêm loại quần áo thành công!")
                LoadTypes()
                txtTypeName.Clear()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        If dgvTypes.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn loại quần áo để sửa.")
            Return
        End If

        Dim id As Integer = dgvTypes.CurrentRow.Cells("id").Value
        Dim newName As String = txtTypeName.Text.Trim()

        If newName = "" Then
            MessageBox.Show("Tên loại không được để trống.")
            Return
        End If

        Using conn = Database.GetConnection()
            Dim cmd As New MySqlCommand("UPDATE clothes_type SET name=@n WHERE id=@id", conn)
            cmd.Parameters.AddWithValue("@n", newName)
            cmd.Parameters.AddWithValue("@id", id)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cập nhật thành công!")
                LoadTypes()
                txtTypeName.Clear()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        If dgvTypes.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn loại quần áo để xóa.")
            Return
        End If

        Dim id As Integer = dgvTypes.CurrentRow.Cells("id").Value

        If MessageBox.Show("Bạn có chắc muốn xóa loại này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn = Database.GetConnection()
                Dim cmd As New MySqlCommand("DELETE FROM clothes_type WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Xóa thành công!")
                    LoadTypes()
                Catch ex As Exception
                    MessageBox.Show("Lỗi: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btReload_Click(sender As Object, e As EventArgs) Handles btReload.Click
        LoadTypes()
    End Sub

    Private Sub dgvTypes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTypes.CellClick
        If e.RowIndex >= 0 Then
            txtTypeName.Text = dgvTypes.Rows(e.RowIndex).Cells("name").Value.ToString()
        End If
    End Sub
End Class