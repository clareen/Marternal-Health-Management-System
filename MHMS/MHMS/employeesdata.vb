Imports MySql.Data.MySqlClient

Imports Excel = Microsoft.Office.Interop.Excel
Public Class employeesdata
    Dim rdr As MySqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As MySqlConnection = Nothing
    Dim adp As MySqlDataAdapter
    Dim ds As DataSet
    Dim cmd As MySqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "datasource=localhost;port=3306;username=root;database=mhms;Persist Security Info=False;"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fill_data_grid_view()
        'Try
        '    con = New MySqlConnection(cs)
        '    con.Open()
        '    cmd = New MySqlCommand(" SELECT distinct `emp_id`, `names`, `age`, `gender`, `dob`, `date`, `title`, `proffession`, `contact`, `email`, `residence`, `mstatus`, `username`, `time` FROM `employee` where dob between #" & DateFrom.Text & " # and #" & DateTo.Text & "# order by dob", con)
        '    ''cmd = New MySqlCommand("SELECT distinct emp_id as [Employee ID],names as [Employee Name],age as [Age],gender as [Gender],dob as [Date of Birth],date as [Date of Registration],title as [Title],proffession as [Proffession],contact as [Contact],email as [Email Address],residence as [Residence],mstatus as [Martial Status],username as [User Name],time as [Time] from employee where dob between #" & DateFrom.Text & " # and #" & DateTo.Text & "# order by dob", con)
        '    Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        '    Dim myDataSet As DataSet = New DataSet()
        '    myDA.Fill(myDataSet, "employee")
        '    DataGridView1.DataSource = myDataSet.Tables("employee").DefaultView
        '    con.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Public Sub fill_data_grid_view()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select distinct emp_id as Employee_ID,names as Employee_Name,age as Age,gender as Gender,dob as Date_of_Birth,date as Date_of_Registration,title as Title,proffession as Proffession,contact as Contact,email as Email_Address,residence as Residence,mstatus as Martial_Status,username as User_Name,time as Time from  employee   order by dob; ", conDatabase)
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

    Public Sub fill_data_grid_view1()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;database=mhms;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select distinct `emp_id`, `names`, `age`, `gender`, `dob`, `date`, `title`, `proffession`, `contact`, `email`, `residence`, `mstatus`, `username`, `time`  from  employee where dob between #" & DateFrom.Text & " # and #" & DateTo.Text & "# ", conDatabase)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DateFrom.Text = Today
        DateTo.Text = Today
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub DataGridView1_Paint(sender As Object, e As PaintEventArgs) Handles DataGridView1.Paint

    End Sub

    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub employeesdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill_data_grid_view1()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()
        Dim printDialog As PrintDialog = New PrintDialog()
        printDialog.Document = PrintDocument1
        'printDialog.Document = DataGridView1

        printDialog.UseEXDialog = True
        If (DialogResult.OK = printDialog.ShowDialog()) Then
            PrintDocument1.DocumentName = "dfd"
            PrintDocument1.Print()

        End If


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'e.Graphics.DrawString(DataGridView1.Text, New Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120)
        'DataGridView1.ToString()
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs) Handles PrintPreviewControl1.Click

    End Sub
End Class