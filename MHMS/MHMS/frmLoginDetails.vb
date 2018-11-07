Imports MySql.Data.MySqlClient
Public Class frmLoginDetails
    Private Const ConnectionString As String = "datasource=localhost;port=3306;username=root;database=mhms;Persist Security Info=False;"
    Private Sub frmLoginDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetData()
    End Sub
    Private ReadOnly Property Connection() As MySqlConnection
        Get
            Dim ConnectionToFetch As New MySqlConnection(ConnectionString)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property
    Public Function GetData() As DataView
        
        Dim SelectQry = "SELECT username as User_Name,password as Password FROM user "
        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New MySqlCommand()
            Dim SampleDataAdapter = New MySqlDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TableView
    End Function
End Class