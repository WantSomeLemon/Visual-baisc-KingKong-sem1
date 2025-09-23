Imports MySql.Data.MySqlClient
Public Class LoginRegister
    Private Sub LoginRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRole.Items.Clear()
        cbRole.Items.Add("staff")
        cbRole.Items.Add("admin")
        cbRole.SelectedIndex = 0 ' mặc định staff
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập Username và Password.")
            Return
        End If

        Using conn = Database.GetConnection()
            Dim cmd As New MySqlCommand("SELECT role FROM user WHERE username=@u AND password=@p", conn)
            cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim())
            Dim reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim role As String = reader("role").ToString()
                MessageBox.Show("Đăng nhập thành công với quyền: " & role)

                ' clear textbox + reset combo
                ClearInputs()

                Me.Hide()
                MenuDashboard.CurrentRole = role
                MenuDashboard.Show()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.")
                ' clear textbox + reset combo
                ClearInputs()
            End If
        End Using
    End Sub

    Private Sub btRegister_Click(sender As Object, e As EventArgs) Handles btRegister.Click
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập Username và Password.")
            Return
        End If

        Using conn = Database.GetConnection()
            ' check username đã tồn tại chưa
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM user WHERE username=@u", conn)
            checkCmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng chọn username khác.")
                ' clear textbox + reset combo
                ClearInputs()
                Return
            End If

            ' nếu chưa có thì thêm mới
            Dim cmd As New MySqlCommand("INSERT INTO user(username,password,role) VALUES(@u,@p,@r)", conn)
            cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim())
            cmd.Parameters.AddWithValue("@r", cbRole.Text)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Đăng ký thành công với quyền: " & cbRole.Text)
            Catch ex As Exception
                MessageBox.Show("Lỗi khi đăng ký: " & ex.Message)
            End Try
        End Using

        ' clear textbox + reset combo
        ClearInputs()
    End Sub

    ' Hàm clear inputs
    Private Sub ClearInputs()
        txtUsername.Text = ""
        txtPassword.Text = ""
        cbRole.SelectedIndex = 0
        txtUsername.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btTogglePasswordText.Click
        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
        If txtPassword.UseSystemPasswordChar Then
            btTogglePasswordText.Text = "🙈"
        Else
            btTogglePasswordText.Text = "👁"
        End If
    End Sub
End Class
