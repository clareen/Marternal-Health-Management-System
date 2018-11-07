Imports MySql.Data.MySqlClient
Public Class HealthHistory
    Dim rand As New Random()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"

            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  `healthhistory`(`hh_id`, `sicklecell_disease`, `twins`, `abortion`, `hypertension`, `std`, `tb`, `health_of_the_husband`, `smoking`, `alcohol`)   VALUES ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox8.Text & "','" & ComboBox7.Text & "','" & TextBox2.Text & "','" & ComboBox6.Text & "','" & ComboBox5.Text & "') ", mycon)
            Dim myReader As MySqlDataReader
            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fill_data_grid_view()
            TextBox1.Text = ""
            TextBox2.Text = ""

            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            ComboBox5.Text = ""
            ComboBox6.Text = ""
            ComboBox7.Text = ""
            ComboBox8.Text = ""
            'Button2.Enabled = False
            mycon.Close()
            TextBox1.Text = "HH-" & rand.Next(12345).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub fill_data_grid_view()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  healthhistory ", conDatabase)
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


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        

            Try
                If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
         

                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from healthhistory where hh_id ='" & TextBox1.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been deleted")
                    fill_data_grid_view()
                    TextBox1.Text = ""
                    TextBox2.Text = ""

                    ComboBox1.Text = ""
                    ComboBox2.Text = ""
                    ComboBox3.Text = ""
                    ComboBox4.Text = ""
                    ComboBox5.Text = ""
                    ComboBox6.Text = ""
                    ComboBox7.Text = ""
                    ComboBox8.Text = ""


                    mycon.Close()

            End If
        Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

    End Sub

    Private Sub HealthHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_data_grid_view()
        TextBox1.Text = "HH-" & rand.Next(12345).ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)

            Dim SelectCommand As MySqlCommand = New MySqlCommand("update  healthhistory set hh_id='" & TextBox1.Text & "',sicklecell_disease='" & ComboBox1.Text & "',twins='" & ComboBox2.Text & "',abortion='" & ComboBox3.Text & "',hypertension='" & ComboBox4.Text & "',std='" & ComboBox8.Text & "',tb='" & ComboBox7.Text & "',health_of_the_husband='" & TextBox2.Text & "',smoking='" & ComboBox6.Text & "',alcohol='" & ComboBox5.Text & "' where hh_id='" & TextBox1.Text & "' ", mycon)
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  healthhistory where hh_id='" + TextBox1.Text + "' ;", conDatabase)
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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim cv As Char = e.KeyChar
        If Char.IsDigit(cv) Then
            e.Handled = True
            MessageBox.Show("figures not allowed")

        End If
    End Sub
End Class