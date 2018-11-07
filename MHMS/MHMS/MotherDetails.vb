Imports MySql.Data.MySqlClient
Public Class MotherDetails
    ' Dim rand As New Random()
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
           

            mycon.Close()
            mycon.Open()

            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  `mother`(`nin_id`,`admission_date`,`delivery_time`,`delivery_type`,`numberof_babies`,`healthofficer`,`complication`,`vitim_given`,`dischagre_date`,`nextappointment`,`address`)   VALUES ('" & TextBox1.Text & "','" & DateTimePicker5.Text & "','" & DateTimePicker4.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker3.Text & "','" & TextBox2.Text & "') ", mycon)
            ' Dim myReader As MySqlDataReader

           
           
            SelectCommand.ExecuteNonQuery()

            'myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fill_data_grid_view()
            TextBox1.Text = ""
            TextBox2.Text = ""
            'TextBox3.Text = ""
            'TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            'TextBox7.Text = ""
            'TextBox8.Text = ""


            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            'PictureBox1.Image = Nothing

            mycon.Close()
            'TextBox1.Text = rand.Next(1234567890).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'If Me.ofd.ShowDialog = DialogResult.OK Then
        '    Me.PictureBox1.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
        'End If
        'If Me.ofd.ShowDialog = DialogResult.OK Then
        '    Me.PictureBox1.ImageLocation = ofd.FileName
        '    'Me.PictureBox1.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
        'End If
        'ofd.FileName = ""
    End Sub
    
    Private Sub MotherDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_data_grid_view()
        'TextBox1.Text = rand.Next(1234567890).ToString
    End Sub
    Public Sub fill_data_grid_view()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  mother ", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try








        'Dim i As Integer
        'i = DataGridView1.CurrentRow.Index
        'Me.TextBox1.Text = DataGridView1.Item(0, i).Value
        'Me.ComboBox1.Text = DataGridView1.Item(1, i).Value
        'Me.ComboBox2.Text = DataGridView1.Item(2, i).Value
        'Me.ComboBox3.Text = DataGridView1.Item(3, i).Value
        'Me.ComboBox4.Text = DataGridView1.Item(4, i).Value

        'Me.ComboBox8.Text = DataGridView1.Item(5, i).Value
        'Me.ComboBox7.Text = DataGridView1.Item(6, i).Value
        'Me.TextBox2.Text = DataGridView1.Item(7, i).Value
        'Me.ComboBox6.Text = DataGridView1.Item(8, i).Value
        'Me.ComboBox5.Text = DataGridView1.Item(9, i).Value


    End Sub
    Public Sub sam()
        Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"

        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        'Dim arrImage() As Byte
        'Dim myMS As New IO.MemoryStream
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM mother " & _
                                             " WHERE nin_id=" & Me.TextBox1.Text, mycon)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.TextBox1.Text = dt.Rows(0).Item("nin_id") & ""
            Me.DateTimePicker5.Text = dt.Rows(0).Item("admission_date") & ""
            Me.DateTimePicker4.Text = dt.Rows(0).Item("delivery_time") & ""
            Me.ComboBox1.Text = dt.Rows(0).Item("delivery_type=") & ""
            Me.TextBox5.Text = dt.Rows(0).Item("numberof_babies") & ""
            Me.TextBox6.Text = dt.Rows(0).Item("healthofficer") & ""
            Me.ComboBox2.Text = dt.Rows(0).Item("complication") & ""
            Me.ComboBox3.Text = dt.Rows(0).Item("vitim_given") & ""
            Me.DateTimePicker1.Text = dt.Rows(0).Item("dischagre_date") & ""
            Me.DateTimePicker3.Text = dt.Rows(0).Item("nextappointment") & ""
            Me.TextBox2.Text = dt.Rows(0).Item("address") & ""

            'Me.TextBox4.Text = dt.Rows(0).Item("proffession") & ""
            'Me.TextBox5.Text = dt.Rows(0).Item("contact") & ""
            'Me.TextBox6.Text = dt.Rows(0).Item("email") & ""
            'Me.TextBox7.Text = dt.Rows(0).Item("residence") & ""
            'Me.ComboBox3.Text = dt.Rows(0).Item("mstatus") & ""
            'Me.TextBox8.Text = dt.Rows(0).Item("username") & ""
            'Me.DateTimePicker3.Text = dt.Rows(0).Item("time") & ""
            'Me.txtcos.Text = dt.Rows(0).Item("course") & ""
            'Me.txtcot.Text = dt.Rows(0).Item("courseunit") & ""
            'Me.txtcwork.Text = dt.Rows(0).Item("courseworkmark") & ""
            'Me.txtemark.Text = dt.Rows(0).Item("examinationmark") & ""
            'Me.txtfscore.Text = dt.Rows(0).Item("finalscore") & ""
            'Dim img() As Byte
            'img = dt.Rows(0).Item("photo")

            'Dim ms As New IO.MemoryStream(img)

            'If Not IsDBNull(dt.Rows(0).Item("photo")) Then
            '    arrImage = dt.Rows(0).Item("photo")
            '    For Each ar As Byte In arrImage
            '        myMS.WriteByte(ar)
            '    Next
            '    ' PictureBox1.Image = New Bitmap(myMS)
            '    'PictureBox1.Image=
            '    '
            '    'Me.PictureBox1.Image = System.Drawing.Image.FromStream(myMS)
            'End If

        Else
            MsgBox("Record not found!")
            TextBox1.Text = ""
            'TextBox2.Text = ""
            'TextBox3.Text = ""
            'TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            'TextBox7.Text = ""
            'TextBox8.Text = ""


            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
        End If

        mycon.Close()


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
           
            '
          


            Dim SelectCommand As MySqlCommand = New MySqlCommand("update  mother set nin_id='" & TextBox1.Text & "',admission_date='" & DateTimePicker5.Text & "',delivery_time='" & DateTimePicker4.Text & "',delivery_type='" & ComboBox1.Text & "',numberof_babies='" & TextBox5.Text & "',healthofficer'" & TextBox6.Text & "',complication='" & ComboBox2.Text & "',vitim_given='" & ComboBox3.Text & "',dischagre_date='" & DateTimePicker1.Text & "',nextappointment='" & DateTimePicker3.Text & "',address='" & TextBox2.Text & "' where nin_id='" & TextBox1.Text & "' ", mycon)
            Dim myReader As MySqlDataReader
           
            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been updated")
            fill_data_grid_view()

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sam()
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then


                Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from mother where nin_id ='" & TextBox1.Text & "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been deleted")
                fill_data_grid_view()
                TextBox1.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox2.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
                TextBox2.Text = ""

               


                mycon.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsLetter(cv) Then
            e.Handled = True
            MessageBox.Show("letters not allowed")

        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub
End Class