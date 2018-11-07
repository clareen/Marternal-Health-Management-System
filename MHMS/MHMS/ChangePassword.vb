Imports MySql.Data.MySqlClient
Public Class ChangePassword
    Dim rdr As MySqlDataReader = Nothing

    Dim con As MySqlConnection = Nothing

    Dim cmd As MySqlCommand = Nothing
    Dim ck As String = "datasource=localhost;port=3306;username=root;database=mhms;Persist Security Info=False;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim RowsAffected As Integer = 0
            If Len(Trim(UserName.Text)) = 0 Then
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserName.Focus()
                Exit Sub
            End If
            If Len(Trim(OldPassword.Text)) = 0 Then
                MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OldPassword.Focus()
                Exit Sub
            End If
            If Len(Trim(NewPassword.Text)) = 0 Then
                MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Focus()
                Exit Sub
            End If
            If Len(Trim(ConfirmPassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ConfirmPassword.Focus()
                Exit Sub
            End If
            If NewPassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                ConfirmPassword.Text = ""
                NewPassword.Focus()
                Exit Sub
            ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                OldPassword.Text = ""
                ConfirmPassword.Text = ""
                OldPassword.Focus()
                Exit Sub
            ElseIf OldPassword.Text = NewPassword.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                ConfirmPassword.Text = ""
                NewPassword.Focus()
                Exit Sub
            End If


            con = New MySqlConnection(ck)

            con.Open()

            Dim co As String = "update user set password = '" & NewPassword.Text & "' where username='" & UserName.Text & "' and password = '" & OldPassword.Text & "'"
            '

            cmd = New MySqlCommand(co)

            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form1.Show()
                UserName.Text = ""
                NewPassword.Text = ""
                OldPassword.Text = ""
                ConfirmPassword.Text = ""
                AdminLogin.TextBox1.Focus()
                MedicalDirector_sAccess.TextBox1.Focus()
                MidWife.TextBox1.Focus()
                SisterLogin.TextBox1.Focus()
            Else

                MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserName.Text = ""
                NewPassword.Text = ""
                OldPassword.Text = ""
                ConfirmPassword.Text = ""
                UserName.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChangePassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()

        Form1.Show()
        'SisterLogin.Show()
        'MedicalDirector_sAccess.Show()

        'MidWife.TextBox1.Text = ""
        'MidWife.TextBox2.Text = ""
        'MidWife.TextBox1.Focus()
        'SisterLogin.TextBox1.Text = ""
        'SisterLogin.TextBox2.Text = ""
        'SisterLogin.TextBox1.Focus()
        'MedicalDirector_sAccess.TextBox1.Text = ""
        'MedicalDirector_sAccess.TextBox2.Text = ""
        'MedicalDirector_sAccess.TextBox1.Focus()
    End Sub
End Class