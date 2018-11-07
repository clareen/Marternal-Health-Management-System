Imports MySql.Data.MySqlClient
Public Class SisterLogin

    Private Sub SisterLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminLogin.Show()
        Me.Hide()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Len(Trim(TextBox1.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If
        Try
            Dim myConnection As MySqlConnection
            myConnection = New MySqlConnection("datasource=localhost;port=3306;username=root;database=mhms;Persist Security Info=False;")

            Dim myCommand As MySqlCommand
            'username,[password] 
            myCommand = New MySqlCommand("SELECT * FROM user WHERE username = @username AND password = @UserPassword", myConnection)

            Dim uName As New MySqlParameter("@username", MySqlDbType.VarChar)

            Dim uPassword As New MySqlParameter("@UserPassword", MySqlDbType.VarChar)

            uName.Value = TextBox1.Text

            uPassword.Value = TextBox2.Text

            myCommand.Parameters.Add(uName)

            myCommand.Parameters.Add(uPassword)

            myCommand.Connection.Open()

            Dim myReader As MySqlDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

            Dim Login As Object = 0

            If myReader.HasRows Then

                myReader.Read()

                Login = myReader(Login)

            End If

            If Login = Nothing Then

                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()

            Else

                ProgressBar1.Visible = True
                ProgressBar1.Maximum = 5000
                ProgressBar1.Minimum = 0
                ProgressBar1.Value = 4
                ProgressBar1.Step = 1

                For i = 0 To 5000
                    ProgressBar1.PerformStep()
                Next
                Me.Hide()
                MainMenu.lblUser.Text = TextBox1.Text
                MainMenu.Show()
            End If
            myCommand.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        ChangePassword.Show()
        ChangePassword.UserName.Text = ""
        ChangePassword.OldPassword.Text = ""
        ChangePassword.NewPassword.Text = ""
        ChangePassword.ConfirmPassword.Text = ""
        ChangePassword.UserName.Focus()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        frmPasswordRecovery.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MedicalDirector_sAccess.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Show()

        MidWife.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub
End Class