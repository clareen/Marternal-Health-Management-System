Imports MySql.Data.MySqlClient
Public Class MaterMortality
    Dim rand As New Random()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Public Sub fill_data_grid_view()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  mortality ", conDatabase)
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
    Private Sub MaterMortality_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DataGridView1.Hide()
        MainMenu.lblUser.Text = lblUser.Text
        MainMenu.Show()
        TextBox1.Text = "MM-" & rand.Next(12345).ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)


            mycon.Close()
            mycon.Open()

            Dim SelectCommand As MySqlCommand = New MySqlCommand("INSERT INTO `mortality`(`mm_id`,`cases`, `cause_of_death`, `time_of_death`, `date_of_death`,`loggedinas`) VALUES ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & lblUser.Text & "') ", mycon)
            ' Dim myReader As MySqlDataReader


            SelectCommand.ExecuteNonQuery()

            'myReader = SelectCommand.ExecuteReader()

            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox1.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            


            mycon.Close()
            TextBox1.Text = "MM-" & rand.Next(12345).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Show()
        fill_data_grid_view()
        TextBox1.Text = "MM-" & rand.Next(12345).ToString
    End Sub
End Class