Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Drawing.Printing


Public Class Healthworkers
    Dim rand As New Random()
    Dim sql As String
    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_reader As MySqlDataReader

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button7.Click
        Me.Hide()

    End Sub
    Public Sub fill_data_grid_view()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  employee ", conDatabase)
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button6.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)

            Dim FileSize As UInt32

            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()
            MsgBox(FileSize)
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

            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  `employee`(`emp_id`, `names`, `age`, `gender`, `dob`, `date`, `title`, `proffession`, `contact`, `email`, `residence`, `mstatus`, `username`,`time`, `photo`)   VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox3.Text & "','" & TextBox8.Text & "','" & DateTimePicker3.Text & "',@image_data) ", mycon)
            ' Dim myReader As MySqlDataReader
            'sql_command = New MySqlClient.MySqlCommand(Sql, sql_connection)

            SelectCommand.Parameters.AddWithValue("@image_data", arrImage)
            'If strImage = "?" Then
            '    SelectCommand.Parameters.Add(strImage, MySqlDbType.Binary).Value = arrImage
            '    'SelectCommand.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
            'End If
            SelectCommand.ExecuteNonQuery()

            'myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fill_data_grid_view()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""


            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            PictureBox1.Image = Nothing

            mycon.Close()
            TextBox1.Text = "KT-" & rand.Next(12345).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ofd.ShowDialog = 1 Then
            Me.PictureBox1.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
        End If
    End Sub

    Private Sub Healthworkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_data_grid_view()
        'TextBox1.Text = rand.Next(1234567890).ToString
        TextBox1.Text = "KT-" & rand.Next(12345).ToString
    End Sub
    Public Sub sam()
        Dim arrImage() As Byte
        Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"

        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        'Dim arrImage() As Byte
        'Dim myMS As New IO.MemoryStream
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM employee " & _
                                             " WHERE emp_id=" & Me.TextBox11.Text, mycon)
        Dim dt As New DataTable
        'sql_reader = sql_command.ExecuteReader()

        
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.TextBox1.Text = dt.Rows(0).Item("emp_id") & ""
            Me.TextBox2.Text = dt.Rows(0).Item("names") & ""
            Me.TextBox3.Text = dt.Rows(0).Item("age") & ""
            Me.ComboBox1.Text = dt.Rows(0).Item("gender") & ""
            Me.DateTimePicker1.Text = dt.Rows(0).Item("dob") & ""
            Me.DateTimePicker2.Text = dt.Rows(0).Item("date") & ""
            Me.ComboBox2.Text = dt.Rows(0).Item("title") & ""
            Me.TextBox4.Text = dt.Rows(0).Item("proffession") & ""
            Me.TextBox5.Text = dt.Rows(0).Item("contact") & ""
            Me.TextBox6.Text = dt.Rows(0).Item("email") & ""
            Me.TextBox7.Text = dt.Rows(0).Item("residence") & ""
            Me.ComboBox3.Text = dt.Rows(0).Item("mstatus") & ""
            Me.TextBox8.Text = dt.Rows(0).Item("username") & ""
            Me.DateTimePicker3.Text = dt.Rows(0).Item("time") & ""
            arrImage = dt.Rows(0).Item("photo")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            PictureBox1.Image = Image.FromStream(mstream)
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
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""


            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
        End If

        mycon.Close()


    End Sub
    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sam()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)


            Dim SelectCommand As MySqlCommand = New MySqlCommand("update  employee set emp_id='" & TextBox1.Text & "',names='" & TextBox2.Text & "',age='" & TextBox3.Text & "',gender='" & ComboBox1.Text & "',dob='" & DateTimePicker1.Text & "',date='" & DateTimePicker2.Text & "',title='" & ComboBox2.Text & "',proffession='" & TextBox4.Text & "',contact='" & TextBox5.Text & "',email='" & TextBox6.Text & "',residence='" & TextBox7.Text & "',mstatus='" & ComboBox3.Text & "',username='" & TextBox8.Text & "',time='" & DateTimePicker3.Text & "' where emp_id='" & TextBox11.Text & "' ", mycon)
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

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Dim arrImage() As Byte

        Try
            sql_connection.Close()
            sql_connection.Open()

            sql = "SELECT * FROM mhms.employee WHERE emp_id = '" & TextBox1.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("photo")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            PictureBox1.Image = Image.FromStream(mstream)
            sql_reader.Close()
            sql_connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
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

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        'e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
        Dim pd As New System.Drawing.Printing.PrintDocument
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        pd.Print()
    End Sub

    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawImage(PictureBox1.Image, 0, 0)
    End Sub

End Class