Imports MySql.Data.MySqlClient

Public Class Bill

    ' Load danh sách quần áo vào combobox
    Private Sub LoadClothes()
        Using conn = Database.GetConnection()
            Dim da As New MySqlDataAdapter("SELECT id, name, price FROM clothes", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbClothes.DataSource = dt
            cbClothes.DisplayMember = "name"
            cbClothes.ValueMember = "id"
        End Using
    End Sub

    Private Sub Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClothes()
        ' Tạo bảng tạm cho chi tiết hóa đơn
        Dim dt As New DataTable()
        dt.Columns.Add("clothesID", GetType(Integer))
        dt.Columns.Add("clothesName", GetType(String))
        dt.Columns.Add("quantity", GetType(Integer))
        dt.Columns.Add("price", GetType(Decimal))
        dt.Columns.Add("total", GetType(Decimal))
        dgvBillDetails.DataSource = dt
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtQuantity.Text.Trim() = "" Or Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("Vui lòng nhập số lượng hợp lệ.")
            Return
        End If

        Dim selectedRow As DataRowView = CType(cbClothes.SelectedItem, DataRowView)
        Dim clothesID As Integer = selectedRow("id")
        Dim clothesName As String = selectedRow("name").ToString()
        Dim price As Decimal = Convert.ToDecimal(selectedRow("price"))
        Dim qty As Integer = Integer.Parse(txtQuantity.Text)
        Dim total As Decimal = qty * price

        Dim dt As DataTable = CType(dgvBillDetails.DataSource, DataTable)
        dt.Rows.Add(clothesID, clothesName, qty, price, total)
        dgvBillDetails.Refresh()
        txtQuantity.Clear()
    End Sub

    Private Sub btCreate_Click(sender As Object, e As EventArgs) Handles btCreate.Click
        If txtCustomer.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập tên khách hàng.")
            Return
        End If

        If dgvBillDetails.Rows.Count = 0 Then
            MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn.")
            Return
        End If

        Using conn = Database.GetConnection()
            Dim trans = conn.BeginTransaction()
            Try
                ' Thêm bill
                Dim cmdBill As New MySqlCommand("INSERT INTO bill(customerName, userID) VALUES(@c, 1)", conn, trans)
                cmdBill.Parameters.AddWithValue("@c", txtCustomer.Text.Trim())
                cmdBill.ExecuteNonQuery()
                Dim billId As Integer = cmdBill.LastInsertedId

                ' Thêm bill_detail
                For Each row As DataGridViewRow In dgvBillDetails.Rows
                    If Not row.IsNewRow Then
                        Dim cmdDetail As New MySqlCommand("
                            INSERT INTO bill_detail(billID, clothesID, quantity, price) 
                            VALUES(@b, @cl, @q, @p)", conn, trans)
                        cmdDetail.Parameters.AddWithValue("@b", billId)
                        cmdDetail.Parameters.AddWithValue("@cl", row.Cells("clothesID").Value)
                        cmdDetail.Parameters.AddWithValue("@q", row.Cells("quantity").Value)
                        cmdDetail.Parameters.AddWithValue("@p", row.Cells("price").Value)
                        cmdDetail.ExecuteNonQuery()
                    End If
                Next

                trans.Commit()
                MessageBox.Show("Tạo hóa đơn thành công!")
                CType(dgvBillDetails.DataSource, DataTable).Clear()
                txtCustomer.Clear()
            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Lỗi khi tạo hóa đơn: " & ex.Message)
            End Try
        End Using
    End Sub

End Class