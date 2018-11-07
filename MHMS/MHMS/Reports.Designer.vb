<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.emp1 = New MHMS.emp()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.immuni1 = New MHMS.immuni()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.mother1 = New MHMS.mother()
        Me.CrystalReportViewer4 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.maternal1 = New MHMS.maternal()
        Me.CrystalReportViewer5 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cb1 = New MHMS.cb()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer6 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.his1 = New MHMS.his()
        Me.CrystalReportViewer7 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.mortality1 = New MHMS.mortality()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer8 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.baby1 = New MHMS.baby()
        Me.button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 77)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1266, 642)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1229, 440)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "EMPLOYEES"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.emp1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1223, 434)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer2)
        Me.TabPage2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1229, 440)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "IMMUIZATION"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = 0
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.ReportSource = Me.immuni1
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1223, 434)
        Me.CrystalReportViewer2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CrystalReportViewer3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1229, 440)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "MOTHER DETAILS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CrystalReportViewer4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1229, 440)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "MATERNAL"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.CrystalReportViewer5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1229, 440)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "CHILDBIRTH"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer3
        '
        Me.CrystalReportViewer3.ActiveViewIndex = 0
        Me.CrystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer3.Name = "CrystalReportViewer3"
        Me.CrystalReportViewer3.ReportSource = Me.mother1
        Me.CrystalReportViewer3.Size = New System.Drawing.Size(1229, 440)
        Me.CrystalReportViewer3.TabIndex = 0
        '
        'CrystalReportViewer4
        '
        Me.CrystalReportViewer4.ActiveViewIndex = 0
        Me.CrystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer4.Name = "CrystalReportViewer4"
        Me.CrystalReportViewer4.ReportSource = Me.maternal1
        Me.CrystalReportViewer4.Size = New System.Drawing.Size(1229, 440)
        Me.CrystalReportViewer4.TabIndex = 0
        '
        'CrystalReportViewer5
        '
        Me.CrystalReportViewer5.ActiveViewIndex = 0
        Me.CrystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer5.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer5.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer5.Name = "CrystalReportViewer5"
        Me.CrystalReportViewer5.ReportSource = Me.cb1
        Me.CrystalReportViewer5.Size = New System.Drawing.Size(1229, 440)
        Me.CrystalReportViewer5.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.CrystalReportViewer6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1229, 440)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "HEALTH HISTOTRY"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.CrystalReportViewer7)
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1229, 440)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "MORTALITY"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer6
        '
        Me.CrystalReportViewer6.ActiveViewIndex = 0
        Me.CrystalReportViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer6.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer6.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer6.Name = "CrystalReportViewer6"
        Me.CrystalReportViewer6.ReportSource = Me.his1
        Me.CrystalReportViewer6.Size = New System.Drawing.Size(1229, 440)
        Me.CrystalReportViewer6.TabIndex = 0
        '
        'CrystalReportViewer7
        '
        Me.CrystalReportViewer7.ActiveViewIndex = 0
        Me.CrystalReportViewer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer7.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer7.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer7.Name = "CrystalReportViewer7"
        Me.CrystalReportViewer7.ReportSource = Me.mortality1
        Me.CrystalReportViewer7.Size = New System.Drawing.Size(1229, 440)
        Me.CrystalReportViewer7.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.CrystalReportViewer8)
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(1258, 615)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "CHILD"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer8
        '
        Me.CrystalReportViewer8.ActiveViewIndex = 0
        Me.CrystalReportViewer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer8.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer8.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer8.Name = "CrystalReportViewer8"
        Me.CrystalReportViewer8.ReportSource = Me.baby1
        Me.CrystalReportViewer8.Size = New System.Drawing.Size(1258, 615)
        Me.CrystalReportViewer8.TabIndex = 0
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.Red
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Location = New System.Drawing.Point(1197, 21)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(50, 33)
        Me.button3.TabIndex = 365
        Me.button3.Text = "X"
        Me.button3.UseVisualStyleBackColor = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 640)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents emp1 As MHMS.emp
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents immuni1 As MHMS.immuni
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents mother1 As MHMS.mother
    Friend WithEvents CrystalReportViewer4 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents maternal1 As MHMS.maternal
    Friend WithEvents CrystalReportViewer5 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cb1 As MHMS.cb
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer6 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents his1 As MHMS.his
    Friend WithEvents CrystalReportViewer7 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents mortality1 As MHMS.mortality
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer8 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents baby1 As MHMS.baby
    Private WithEvents button3 As System.Windows.Forms.Button
End Class
