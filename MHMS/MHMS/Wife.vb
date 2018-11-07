Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class Wife
    Dim rdr As MySqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As MySqlConnection = Nothing
    Dim adp As MySqlDataAdapter
    Dim ds As DataSet
    Dim cmd As MySqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "datasource=localhost;port=3306;username=root;database=mhms;Persist Security Info=False;"
    Private Sub Wife_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        fillCity()
    End Sub
    Sub fillCity()
        Try
            Dim CN As New MySqlConnection(cs)
            CN.Open()
            adp = New MySqlDataAdapter()
            adp.SelectCommand = New MySqlCommand("SELECT distinct RTRIM(emp_id) FROM employee", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            ComboBox1.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                ComboBox1.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub auto_suggest()
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
    Public Sub sam()
        Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"

        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        'Dim arrImage() As Byte
        'Dim myMS As New IO.MemoryStream
        Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM employee " & _
                                             " WHERE emp_id=" & Me.TextBox1.Text, mycon)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.TextBox1.Text = dt.Rows(0).Item("emp_id") & ""
            Me.TextBox2.Text = dt.Rows(0).Item("names") & ""
            Me.TextBox3.Text = dt.Rows(0).Item("username") & ""
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
        End If

        mycon.Close()


    End Sub
    Public Function make() As Object
        Dim e, f, g, h, j As Object
        e = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        f = Len(e)
        g = 7
        Randomize()
        h = ""
        For intstep = 1 To g
            j = Int((f * Rnd()) + 1)
            'h = h & mid(e, j, 1)
            h = h & Mid(e, j, 1)



        Next
        make = h

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox3.Text = "midwife") Then


            Dim a As String




            While ListBox1.Items.Count < 1
                a = make()
                ListBox1.Items.Add(a)

            End While
            lisr()
            Button3.Enabled = True
        Else
            MessageBox.Show("Invalid Username")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        End If

        


    End Sub

    Private Sub S_Click(sender As Object, e As EventArgs)
        sam()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;database=mhms;"

            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into  `user`(`userid`, `names`, `username`, `password`)   VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "','" & ListBox1.Text & "') ", mycon)
            Dim myReader As MySqlDataReader
            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'fill_data_grid_view()
            TextBox1.Text = ""
            TextBox2.Text = ""

            TextBox3.Text = ""
            TextBox4.Text = ""
            ListBox1.Text = ""
            'Button2.Enabled = False
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()

    End Sub
    Private Sub lisr()
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1

        End If
        'Dim i As Long
        'For i = 0 To ListBox1.Items.Count - 1
        '    ListBox1.SelectedItem(i) = True

        'Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox4.Text = ListBox1.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Text()
        sam()
    End Sub
End Class