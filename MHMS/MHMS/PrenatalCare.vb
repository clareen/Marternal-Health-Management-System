Imports MySql.Data.MySqlClient
Public Class PrenatalCare

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim FileSize As UInt32

            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()
            ' MsgBox(FileSize)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  `prenatal`(`nin_id`, `surname`, `othername`, `age`, `village`, `parish`, `contact`, `nextofkin`, `relationship`, `hypertension`,  `donation`, `date_of_operation`, `residence`, `email`, `visits_to_healthcenter`, `health_exam`, `complication_of_pregnancy`, `weight`, `doctor_name`, `photo`)  VALUES ('" & TextBox1.Text & "','" & TextBox9.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox10.Text & "','" & TextBox16.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "','" & TextBox19.Text & "','" & DateTimePicker1.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox20.Text & "','" & TextBox21.Text & "',@image_data) ", mycon)
            Dim myReader As MySqlDataReader
            mycon.Open()
           SelectCommand.Parameters.AddWithValue("@image_data", arrImage)
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button2.Enabled = False

           
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ofd.ShowDialog = 1 Then
            Me.PictureBox1.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
        End If
        'Dim opd As New OpenFileDialog
        'opd.Title = "Open citizen's photo"
        'opd.Filter = ("JPG Images |*.jpg*|PNG Images |*.png*")

        'If opd.ShowDialog = DialogResult.OK Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile(opd.FileName)
        'End If

    End Sub

    Sub Reset()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        'TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        'TextBox17.Text = ""
        'TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        PictureBox1.Image = Nothing
        Button2.Enabled = True
        'btnUpdate_record.Enabled = False
        Button5.Enabled = False
        TextBox1.Focus()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Reset()
    End Sub

    Sub delete()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from prenatal where nin_in ='" & TextBox22.Text & "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been deleted")
            Reset()

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                delete()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            'Dim arrImage() As Byte
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)


            mycon.Open()
            Dim cb As String = "update prenatal set nin_id='" & TextBox1.Text & "', surname='" & TextBox9.Text & "',othername='" & TextBox2.Text & "',age='" & TextBox3.Text & "',village='" & TextBox4.Text & "',parish='" & TextBox5.Text & "',contact='" & TextBox10.Text & "',nextofkin='" & TextBox16.Text & "',relationship='" & TextBox6.Text & "',hypertension='" & TextBox8.Text & "',donation='" & TextBox19.Text & "',date_of_operation='" & DateTimePicker1.Text & "',residence='" & TextBox11.Text & "',email='" & TextBox12.Text & "',visits_to_healthcenter='" & TextBox13.Text & "',health_exam='" & TextBox14.Text & "',complication_of_pregnancy='" & TextBox15.Text & "',weight='" & TextBox20.Text & "',doctor_name='" & TextBox21.Text & "' where nin_id= '" & TextBox22.Text & "'"
            Dim SelectCommand As MySqlCommand = New MySqlCommand(cb)

            SelectCommand.Connection = mycon
            SelectCommand.ExecuteNonQuery()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub combo()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)

            mycon.Open()
            Dim saw As String = ("select emp_id from employee")
            Dim da As New MySqlDataAdapter(saw, mycon)
            Dim ds As New DataSet
            da.Fill(ds)

            'ComboBox1.DisplayMember = "emp_id"
            ComboBox1.ValueMember = "emp_id"
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.SelectedIndex = 0
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub

    Private Sub PrenatalCare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combo()
        Timer1.Start()

        MainMenu.lblUser.Text = lblUser.Text
        MainMenu.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
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

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
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

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsLetter(cv) Then
            e.Handled = True
            MessageBox.Show("letters not allowed")

        End If
    End Sub
End Class