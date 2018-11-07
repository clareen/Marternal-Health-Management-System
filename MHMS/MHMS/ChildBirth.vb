Imports MySql.Data.MySqlClient
Public Class ChildBirth
    Dim rand As New Random()
    Private Sub ChildBirth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Hide()
        'GroupBox3.Hide()
        TextBox2.Text = "BI-" & rand.Next(12345).ToString
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GroupBox2.Show()
        TextBox19.Text = "BI-" & rand.Next(12345).ToString
        Button1.Enabled = False

        ' GroupBox3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        'MainMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            'Dim arrImage() As Byte
            'Dim strImage As String
            'Dim myMs As New IO.MemoryStream
            ''
            'If Not IsNothing(Me.PictureBox1.Image) Then
            '    Me.PictureBox1.Image.Save(myMs, Me.PictureBox1.Image.RawFormat)
            '    arrImage = myMs.GetBuffer
            '    strImage = "?"
            'Else
            '    arrImage = Nothing
            '    strImage = "NULL"
            'End If

            mycon.Close()
            mycon.Open()

            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  `baby`(`nin`,`baby_id`,`name`,`time_of_birth`,`weight`,`body_parts_exam`,`gender`,`skin_color`,`breast_feeding`,`cdofbabyon_discharge`)   VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox7.Text & "','" & DateTimePicker1.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & ComboBox3.Text & "','" & TextBox10.Text & "')", mycon)
            ' Dim myReader As MySqlDataReader

            'If strImage = "?" Then
            '    SelectCommand.Parameters.Add(strImage, MySqlDbType.Binary).Value = arrImage
            '    'SelectCommand.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
            'End If
            SelectCommand.ExecuteNonQuery()

            'myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'fill_data_grid_view()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox9.Text = ""

            ' TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox10.Text = ""
            'TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""


            ComboBox1.Text = ""
            ComboBox3.Text = ""
            'ComboBox3.Text = ""
            'PictureBox1.Image = Nothing

            mycon.Close()
            TextBox2.Text = "BI-" & rand.Next(12345).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            'Dim arrImage() As Byte
            'Dim strImage As String
            'Dim myMs As New IO.MemoryStream
            ''
            'If Not IsNothing(Me.PictureBox1.Image) Then
            '    Me.PictureBox1.Image.Save(myMs, Me.PictureBox1.Image.RawFormat)
            '    arrImage = myMs.GetBuffer
            '    strImage = "?"
            'Else
            '    arrImage = Nothing
            '    strImage = "NULL"
            'End If

            mycon.Close()
            mycon.Open()

            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  `baby`(`nin`,`baby_id`,`name`,`time_of_birth`,`weight`,`body_parts_exam`,`gender1`,`skin_color`,`breast_feeding`,`cdofbabyon_discharge`,`baby_id2`,`name2`,`time_of_birth2`,`weight2`,`body_parts_exam2`,`gender2`,`skin_color2`,`breast_feeding2`,`cdofbabyon_discharge2`)   VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox7.Text & "','" & DateTimePicker1.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & ComboBox3.Text & "','" & TextBox10.Text & "','" & TextBox19.Text & "','" & TextBox14.Text & "','" & DateTimePicker2.Text & "','" & TextBox13.Text & "','" & TextBox12.Text & "','" & ComboBox2.Text & "','" & TextBox16.Text & "','" & ComboBox4.Text & "','" & TextBox11.Text & "') ", mycon)
            ' Dim myReader As MySqlDataReader

            'If strImage = "?" Then
            '    SelectCommand.Parameters.Add(strImage, MySqlDbType.Binary).Value = arrImage
            '    'SelectCommand.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
            'End If
            SelectCommand.ExecuteNonQuery()

            'myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'fill_data_grid_view()
            TextBox1.Text = ""
            TextBox2.Text = ""
            'TextBox3.Text = ""
            ' TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox16.Text = ""



            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            'PictureBox1.Image = Nothing

            mycon.Close()
            TextBox19.Text = "BI-" & rand.Next(12345).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class