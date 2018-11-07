Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class frmPasswordRecovery

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim ds As New DataSet()
            Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;database=mhms;Persist Security Info=False;")
            con.Open()
            Dim cmd As New MySqlCommand("SELECT [Password] FROM Users Where username = 'admin'", con)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(ds)
            con.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                Dim Msg As New MailMessage()
                ' Sender e-mail address.
                Msg.From = New MailAddress("admin@gmail.com")
                ' Recipient e-mail address.
                Msg.[To].Add("admin@gmail.com")
                Msg.Subject = "Your Password Details"
                Msg.Body = "Your Password: " & Convert.ToString(ds.Tables(0).Rows(0)("Password")) & ""
                Msg.IsBodyHtml = True
                ' your remote SMTP server IP.
                Dim smtp As New SmtpClient()
                smtp.Host = "smtp.gmail.com"
                smtp.Port = 587
                smtp.Credentials = New System.Net.NetworkCredential("abcd@gmail.com", "abcd")
                smtp.EnableSsl = True
                smtp.Send(Msg)
                MessageBox.Show("Password Successfully sent " & vbCrLf & "Please check your mail", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form1.Show()
                MedicalDirector_sAccess.TextBox1.Text = ""
                MedicalDirector_sAccess.TextBox2.Text = ""
                MedicalDirector_sAccess.TextBox1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub
End Class