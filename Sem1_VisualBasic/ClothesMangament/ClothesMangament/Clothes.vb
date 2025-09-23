Imports MySql.Data.MySqlClient

Public Class Clothes

    ' Load danh sách loại quần áo vào ComboBox
    Private Sub LoadTypes()
        Using conn = Database.GetConnection()
            Dim da As New MySqlDataAdapter("SELECT id, name FROM clothes_type", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbType.DataSource = dt
            cbType.DisplayMember = "name"
            cbType.ValueMember = "id"
        End Using
    End Sub

    ' Load danh sách quần áo
    Private Sub LoadClothes()
        Using conn = Database.GetConnection()
            Dim da As New MySqlDataAdapter("
                SELECT c.id, c.name, t.name AS type, c.size, c.color, c.price, c.quantity
                FROM clothes c
                JOIN clothes_type t ON c.typeID=t.id", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvClothes.DataSource = dt
        End Using
    End Sub

    Private Sub ClothesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTypes()
        LoadClothes()
        cbSize.Items.AddRange(New String() {"S", "M", "L", "XL", "XXL", "OS"})
    End Sub

    Private Sub Clothes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Using conn = Database.GetConnection()
            Dim cmd As New MySqlCommand("
                INSERT INTO clothes(name, typeID, size, color, price, quantity)
                VALUES(@n,@t,@s,@c,@p,@q)", conn)
            cmd.Parameters.AddWithValue("@n", txtName.Text.Trim())
            cmd.Parameters.AddWithValue("@t", cbType.SelectedValue)
            cmd.Parameters.AddWithValue("@s", cbSize.Text)
            cmd.Parameters.AddWithValue("@c", txtColor.Text.Trim())
            cmd.Parameters.AddWithValue("@p", Decimal.Parse(txtPrice.Text))
            cmd.Parameters.AddWithValue("@q", Integer.Parse(txtQuantity.Text))

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Thêm quần áo thành công!")
                LoadClothes()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        If dgvClothes.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn quần áo để sửa.")
            Return
        End If

        Dim id As Integer = dgvClothes.CurrentRow.Cells("id").Value

        Using conn = Database.GetConnection()
            Dim cmd As New MySqlCommand("
                UPDATE clothes SET name=@n, typeID=@t, size=@s, color=@c, price=@p, quantity=@q
                WHERE id=@id", conn)
            cmd.Parameters.AddWithValue("@n", txtName.Text.Trim())
            cmd.Parameters.AddWithValue("@t", cbType.SelectedValue)
            cmd.Parameters.AddWithValue("@s", cbSize.Text)
            cmd.Parameters.AddWithValue("@c", txtColor.Text.Trim())
            cmd.Parameters.AddWithValue("@p", Decimal.Parse(txtPrice.Text))
            cmd.Parameters.AddWithValue("@q", Integer.Parse(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@id", id)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cập nhật thành công!")
                LoadClothes()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        If dgvClothes.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn quần áo để xóa.")
            Return
        End If

        Dim id As Integer = dgvClothes.CurrentRow.Cells("id").Value

        If MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn = Database.GetConnection()
                Dim cmd As New MySqlCommand("DELETE FROM clothes WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Xóa thành công!")
                    LoadClothes()
                Catch ex As Exception
                    MessageBox.Show("Lỗi: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btReload_Click(sender As Object, e As EventArgs) Handles btReload.Click
        LoadClothes()
    End Sub

    Private Sub dgvClothes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClothes.CellClick
        If e.RowIndex >= 0 Then
            txtName.Text = dgvClothes.Rows(e.RowIndex).Cells("name").Value.ToString()
            cbType.Text = dgvClothes.Rows(e.RowIndex).Cells("type").Value.ToString()
            cbSize.Text = dgvClothes.Rows(e.RowIndex).Cells("size").Value.ToString()
            txtColor.Text = dgvClothes.Rows(e.RowIndex).Cells("color").Value.ToString()
            txtPrice.Text = dgvClothes.Rows(e.RowIndex).Cells("price").Value.ToString()
            txtQuantity.Text = dgvClothes.Rows(e.RowIndex).Cells("quantity").Value.ToString()
        End If
    End Sub
End Class