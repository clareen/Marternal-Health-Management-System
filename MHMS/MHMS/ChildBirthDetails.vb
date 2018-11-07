Imports MySql.Data.MySqlClient

Public Class ChildBirthDetails
    Dim rand As New Random()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
           


            mycon.Close()
            mycon.Open()

            ' Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  `childbirthid`(`childbirthid`, `nin`, `admissiondate`, `deiverydate`, `time_of_delivery`, `type_of_delivery`, `number_of_babies`, `delivery`, `healthofficer`, `compilication`, `vitimingiven`, `discahgredate`, `nextappointment`,`time`, `photo`)   VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox3.Text & "','" & TextBox8.Text & "','" & DateTimePicker3.Text & "','" & strImage & "') ", mycon)
            ' Dim myReader As MySqlDataReader

           
            'SelectCommand.ExecuteNonQuery()

            'myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fill_data_grid_view()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            'TextBox7.Text = ""
            'TextBox8.Text = ""


            ComboBox1.Text = ""
            'ComboBox2.Text = ""
            'ComboBox3.Text = ""
            'PictureBox1.Image = Nothing

            mycon.Close()
            TextBox1.Text = "CBD-" & rand.Next(12345).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChildBirthDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_data_grid_view()
        TextBox1.Text = "CBD-" & rand.Next(12345).ToString
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

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsLetter(cv) Then
            e.Handled = True
            MessageBox.Show("letters not allowed")

        End If
    End Sub
End Class