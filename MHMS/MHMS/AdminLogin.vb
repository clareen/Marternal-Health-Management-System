Imports MySql.Data.MySqlClient
Public Class AdminLogin

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        '    Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
        '    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        '    Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  administrator where username='" & TextBox1.Text & "' and PassWord='" & TextBox2.Text & "';", mycon)
        '    Dim myReader As MySqlDataReader

        '    mycon.Open()
        '    myReader = SelectCommand.ExecuteReader()
        '    Dim count As Integer = 0
        '    If (myReader.HasRows()) Then
        '        count = count + 1
        '    End If
        '    If (count = 1) Then
        '        MessageBox.Show("you have loged in successfully ")
        '        TextBox1.Text = ""
        '        TextBox2.Text = ""
        '        Administrator_sControlPannel.Show()
        '        Me.Visible = False
        '    ElseIf (count > 1) Then
        '        MessageBox.Show("Duplicate user in the database and access denied")
        '        TextBox1.Text = ""
        '        TextBox2.Text = ""
        '    Else
        '        MessageBox.Show("username and password combination does not macth")
        '        TextBox1.Text = ""
        '        TextBox2.Text = ""
        '    End If
        '    mycon.Close()
        'Catch ex As Exception
        'End Try
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
            myCommand = New MySqlCommand("SELECT * FROM administrator WHERE username = @username AND password = @UserPassword", myConnection)

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
                Administrator_sControlPannel.lblUser.Text = TextBox1.Text
                Administrator_sControlPannel.Show()
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
        frmPasswordRecovery.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Now
    End Sub
End Class