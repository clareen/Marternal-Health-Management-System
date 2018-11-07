Public Class MainMenu

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MotherDetails.lblUser.Text = lblUser.Text
        MotherDetails.Show()
        ' Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Immunization.lblUser.Text = lblUser.Text
        Immunization.Show()
        'Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ChildBirth.lblUser.Text = lblUser.Text
        ChildBirth.Show()
        'Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ChildBirthDetails.lblUser.Text = lblUser.Text
        ChildBirthDetails.Show()
        'Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        HealthHistory.lblUser.Text = lblUser.Text
        HealthHistory.Show()
        'Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrenatalCare.lblUser.Text = lblUser.Text
        PrenatalCare.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        If (lblUser.Text = "sister") Then
            SisterLogin.Show()
            SisterLogin.TextBox1.Text = ""
            SisterLogin.TextBox2.Text = ""
            SisterLogin.ProgressBar1.Visible = False
            SisterLogin.TextBox1.Focus()
        ElseIf (lblUser.Text = "midwife") Then
            MidWife.Show()
            MidWife.TextBox1.Text = ""
            MidWife.TextBox2.Text = ""
            MidWife.ProgressBar1.Visible = False
            MidWife.TextBox1.Focus()
        End If
        
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotePadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Notepad.exe")
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        System.Diagnostics.Process.Start("TaskMgr.exe")
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MSWordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("WinWord.exe")
    End Sub

    Private Sub WardPadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WardPadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Wordpad.exe")
    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemInfoToolStripMenuItem.Click
        frmSystemInfo.Show()
    End Sub

    Private Sub LoginDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginDetailsToolStripMenuItem.Click
        frmLoginDetails.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Me.Hide()
        'If (lblUser.Text = "sister") Then
        '    SisterLogin.Show()
        '    SisterLogin.TextBox1.Text = ""
        '    SisterLogin.TextBox2.Text = ""
        '    SisterLogin.ProgressBar1.Visible = False
        '    SisterLogin.TextBox1.Focus()
        'ElseIf (lblUser.Text = "midwife") Then
        '    MidWife.Show()
        '    MidWife.TextBox1.Text = ""
        '    MidWife.TextBox2.Text = ""
        '    MidWife.ProgressBar1.Visible = False
        '    MidWife.TextBox1.Focus()
        'End If
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        'Me.Hide()
        'If (lblUser.Text = "sister") Then
        '    SisterLogin.Show()
        '    SisterLogin.TextBox1.Text = ""
        '    SisterLogin.TextBox2.Text = ""
        '    SisterLogin.ProgressBar1.Visible = False
        '    SisterLogin.TextBox1.Focus()
        'ElseIf (lblUser.Text = "midwife") Then
        '    MidWife.Show()
        '    MidWife.TextBox1.Text = ""
        '    MidWife.TextBox2.Text = ""
        '    MidWife.ProgressBar1.Visible = False
        '    MidWife.TextBox1.Focus()
        'End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        If (lblUser.Text = "sister") Then
            SisterLogin.Show()
            SisterLogin.TextBox1.Text = ""
            SisterLogin.TextBox2.Text = ""
            SisterLogin.ProgressBar1.Visible = False
            SisterLogin.TextBox1.Focus()
        ElseIf (lblUser.Text = "midwife") Then
            MidWife.Show()
            MidWife.TextBox1.Text = ""
            MidWife.TextBox2.Text = ""
            MidWife.ProgressBar1.Visible = False
            MidWife.TextBox1.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

       
        MaterMortality.lblUser.Text = lblUser.Text
        MaterMortality.Show()
       

    End Sub
End Class