Imports MySql.Data.MySqlClient
Public Class Immunization
    Dim rand As New Random()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            

            mycon.Close()
            mycon.Open()

            Dim SelectCommand As MySqlCommand = New MySqlCommand("INSERT INTO `baby_immunization`(`immun_id`, `at_birth`, `at_one_month`, `at_three_month`, `at_six_months`,`date`,`officer`)  VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Text & "','" & TextBox7.Text & "') ", mycon)
            ' Dim myReader As MySqlDataReader

            
            SelectCommand.ExecuteNonQuery()

            'myReader = SelectCommand.ExecuteReader()
            fill_data_grid_view()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""

            TextBox7.Text = ""


            mycon.Close()
            TextBox1.Text = "IM-" & rand.Next(12345).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub sam()
        Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"

        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        'Dim arrImage() As Byte
        'Dim myMS As New IO.MemoryStream
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM baby_immunization " & _
                                             " WHERE immun_id=" & Me.TextBox6.Text, mycon)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.TextBox1.Text = dt.Rows(0).Item("immun_id") & ""
            Me.TextBox2.Text = dt.Rows(0).Item("at_birth") & ""
            Me.TextBox3.Text = dt.Rows(0).Item("at_one_month") & ""
            Me.TextBox4.Text = dt.Rows(0).Item("at_three_month") & ""
            Me.TextBox5.Text = dt.Rows(0).Item("at_six_months") & ""
            Me.DateTimePicker1.Text = dt.Rows(0).Item("date") & ""
            Me.TextBox7.Text = dt.Rows(0).Item("officer") & ""
            
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
            'TextBox8.Text = ""


            'ComboBox1.Text = ""
            'ComboBox2.Text = ""
            'ComboBox3.Text = ""
        End If

        mycon.Close()


    End Sub
    Public Sub fill_data_grid_view()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  baby_immunization ", conDatabase)
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

    Private Sub Immunization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "IM-" & rand.Next(12345).ToString
        fill_data_grid_view()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sam()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then


                Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from baby_immunization WHERE immun_id= '" & Me.TextBox6.Text & "'", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been deleted")
                fill_data_grid_view()

                'TextBox1.Text = ""
                'TextBox2.Text = ""

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""


                mycon.Close()
                TextBox1.Text = rand.Next(1234567890).ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
End Class