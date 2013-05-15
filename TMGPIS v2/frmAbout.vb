Public Class frmAbout
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLicensed As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMe As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLicensed = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblMe = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 88)
        Me.Label1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblWarning
        '
        Me.lblWarning.Location = New System.Drawing.Point(8, 176)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(416, 64)
        Me.lblWarning.TabIndex = 2
        Me.lblWarning.Text = "Label2"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(368, 104)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 62)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "&Ok"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 48)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tri-Marine International"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLicensed
        '
        Me.lblLicensed.Location = New System.Drawing.Point(8, 112)
        Me.lblLicensed.Name = "lblLicensed"
        Me.lblLicensed.Size = New System.Drawing.Size(352, 32)
        Me.lblLicensed.TabIndex = 12
        Me.lblLicensed.Text = "Label3"
        '
        'lblCopyright
        '
        Me.lblCopyright.Location = New System.Drawing.Point(192, 57)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(240, 38)
        Me.lblCopyright.TabIndex = 13
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'lblMe
        '
        Me.lblMe.AutoSize = True
        Me.lblMe.Location = New System.Drawing.Point(216, 152)
        Me.lblMe.Name = "lblMe"
        Me.lblMe.Size = New System.Drawing.Size(120, 13)
        Me.lblMe.TabIndex = 14
        Me.lblMe.TabStop = True
        Me.lblMe.Text = "ois@trimarinegroup.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "For inquiries and comments, email me @"
        '
        'frmAbout
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblLicensed)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About: A Fill Weight Monitoring System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "About: " & modModule.getSystemTitle
        Label2.Text = "Tri-Marine International" & Chr(13) & " Limited"
        Me.KeyPreview = True
        lblWarning.Text = "Warning: This computer program is owned and sole use only for " & Chr(13) & _
            "this company.  Unauthorized reproduction or distribution of this program, " & Chr(13) & _
            "or any portion of it, may result in severe civil and criminal penalties, " & Chr(13) & _
            "and will be prosecuted to the maximum extent possible under the law."
        lblLicensed.Text = "This program is owned by Tri-Marine International Limited"
        lblCopyright.Text = "Copyright ® 2013"  '"Noro, Western Province, Solomon Island " & Chr(13) & _
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        'Me.Close()
        Me.Dispose()
        'modModule.setAboutClick(0)
    End Sub

    Private Sub frmAbout_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        e.Handled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblMe.LinkClicked
        System.Diagnostics.Process.Start("mailto: " & lblMe.Text)
    End Sub
End Class
