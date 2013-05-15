Public Class frmStartupTimeDate
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Timers.Timer
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblFCL As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartupTimeDate))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Timers.Timer()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblFCL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Enabled = False
        Me.cmdOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Image = CType(resources.GetObject("cmdOk.Image"), System.Drawing.Image)
        Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdOk.Location = New System.Drawing.Point(709, 162)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 48)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.TabStop = False
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOk.UseVisualStyleBackColor = False
        Me.cmdOk.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date today is..."
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Blue
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Yellow
        Me.lblDate.Location = New System.Drawing.Point(24, 200)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(760, 64)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "August 15, 2009"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(16, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(777, 80)
        Me.Label4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(16, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(778, 8)
        Me.Label5.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250.0R
        Me.Timer1.SynchronizingObject = Me
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(200, 161)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(107, 25)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Saturday"
        '
        'lblFCL
        '
        Me.lblFCL.BackColor = System.Drawing.Color.White
        Me.lblFCL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFCL.Font = New System.Drawing.Font("Tahoma", 44.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFCL.ForeColor = System.Drawing.Color.Black
        Me.lblFCL.Location = New System.Drawing.Point(944, 160)
        Me.lblFCL.Name = "lblFCL"
        Me.lblFCL.Size = New System.Drawing.Size(240, 80)
        Me.lblFCL.TabIndex = 0
        Me.lblFCL.Text = "000.00"
        Me.lblFCL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(944, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "No. of FCL"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.White
        Me.lblMonth.Location = New System.Drawing.Point(944, 248)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(246, 18)
        Me.lblMonth.TabIndex = 11
        Me.lblMonth.Text = "As of the month of September 2006"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(920, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 288)
        Me.Label2.TabIndex = 12
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Enabled = False
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(256, 280)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.Tag = ""
        Me.LinkLabel1.Text = "Click here"
        Me.LinkLabel1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(104, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "To change date and time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(137, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(537, 39)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Tri-Marine International Limited"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(251, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmStartupTimeDate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFCL)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStartupTimeDate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "'"
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.Close()

        'Me.Hide()
        'Dim f As New frmMainMenu()
        'f.Show()
    End Sub

    Private Sub frmStartupTimeDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub frmStartupTimeDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmStartupTimeDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        lblDate.Text = Format(getServerDateTime(), "MMMM dd, yyyy")
        lblDay.Text = Format(getServerDateTime(), "dddd")

        'lblFCL.Text = Format(computeFCL, "0##.#0")
        'lblMonth.Text = "As of the month of " & Format(Now(), "MMMM") & " " & _
        '    Format(Now(), "yyyy")
    End Sub

    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        lblDate.Text = Format(getServerDateTime(), "MMMM dd, yyyy")
        lblDay.Text = Format(getServerDateTime(), "dddd")
        If lblDate.Visible = True Then
            lblDate.Visible = False
        Else
            lblDate.Visible = True
        End If
    End Sub

    Public Function getDays()
        Dim yr As String = Format(getServerDateTime(), "yyyy")
        Dim mos As String = Format(getServerDateTime(), "MM")
        Return Now.DaysInMonth(yr, mos)
    End Function

    'Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    '    Dim araw As String = Application.StartupPath & "\timedate.cpl"
    '    System.Diagnostics.Process.Start(araw)
    'End Sub

End Class
