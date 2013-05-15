Public Class frmLogIn

    Inherits System.Windows.Forms.Form
    Dim con As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim adapter As New SqlClient.SqlDataAdapter
    Dim ds As New DataSet("dbPIS")

    Dim paramUser As New SqlClient.SqlParameter
    Dim paramPassword As New SqlClient.SqlParameter
    Dim paramRecCount As New SqlClient.SqlParameter

    Public Shared position As String
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogIn As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents conDbUser As System.Data.SqlClient.SqlConnection
    Friend WithEvents userView As System.Data.DataView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdLogIn = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.userView = New System.Data.DataView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.userView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(160, 74)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(175, 24)
        Me.txtPassword.TabIndex = 17
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(160, 42)
        Me.txtUsername.MaxLength = 20
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(174, 24)
        Me.txtUsername.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Type your username and password"
        '
        'cmdLogIn
        '
        Me.cmdLogIn.Enabled = False
        Me.cmdLogIn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogIn.Image = CType(resources.GetObject("cmdLogIn.Image"), System.Drawing.Image)
        Me.cmdLogIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLogIn.Location = New System.Drawing.Point(101, 110)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.Size = New System.Drawing.Size(72, 50)
        Me.cmdLogIn.TabIndex = 40
        Me.cmdLogIn.Text = "&Log In"
        Me.cmdLogIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancel.Location = New System.Drawing.Point(181, 110)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 50)
        Me.cmdCancel.TabIndex = 41
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(20, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'frmLogIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(355, 170)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdLogIn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLogIn"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.userView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Application.Exit()
    End Sub

    Private Sub cmdLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click
        validateAccount()
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If Not txtPassword.Text = "" Then
            cmdLogIn.Enabled = True
        Else
            cmdLogIn.Enabled = False
        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.SelectAll()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdLogIn.Focus()
        End If
    End Sub

    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.KeyPreview = True
            con.ConnectionString = modModule.getConnectionString

            cmd.CommandText = "proc_grantAccess"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            paramUser.ParameterName = "@uname"
            paramUser.SqlDbType = SqlDbType.VarChar
            paramUser.Direction = ParameterDirection.Input

            paramPassword.ParameterName = "@password"
            paramPassword.SqlDbType = SqlDbType.VarChar

            paramRecCount.ParameterName = "@recCount"
            paramRecCount.SqlDbType = SqlDbType.Int
            paramRecCount.Direction = ParameterDirection.Output

            cmd.Parameters.Add(paramUser)
            cmd.Parameters.Add(paramPassword)
            cmd.Parameters.Add(paramRecCount)
        Catch ex As Exception
            MsgBox(ex.Message)
            'sendExcemptionError(ex.Message, "Log In")
        Finally
        End Try
    End Sub

    Public Sub validateAccount()
        Try
            con.Open()

            If Not txtUsername.Text = "" And Not txtPassword.Text = "" Then
                paramUser.Value = txtUsername.Text

                paramPassword.Value = txtPassword.Text

                adapter.SelectCommand = cmd
                adapter.Fill(ds)

                If cmd.Parameters("@recCount").Value = 1 Then
                    getUserPosition(Me.txtUsername.Text.ToLower, txtPassword.Text.ToLower)
                    modModule.setUsername(txtUsername.Text.ToLower)
                    modModule.setUserFullName(getUserFullName(Me.txtUsername.Text.ToLower, txtPassword.Text.ToLower))
                    Me.Close()
                    'System.Diagnostics.Process.Start(Application.StartupPath & "\SystemFeedBack.exe")
                    'Dim f As New frmStartupTimeDate
                    'f.ShowDialog(Me)
                    'Me.Dispose()
                    auditTrail()
                Else
                    MsgBox("You have an invalid account.", MsgBoxStyle.Information)
                    txtUsername.Focus()
                    txtUsername.SelectAll()
                End If
            Else
                MsgBox("Kindly fill out all blank spaces", MsgBoxStyle.Information, "Error found")
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ' sendExcemptionError(ex.Message, "Log In: Validation of User Account")
        End Try
    End Sub

    Private Sub frmLogIn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        e.Handled = True
    End Sub

    Public Sub getUserPosition(ByVal username As String, ByVal password As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand("SELECT username, password, userPosition, department " & _
                " FROM dbo.tblSystemAccount " & _
                " WHERE username LIKE '" & username & "' AND " & _
                " password LIKE '" & password & "'", c)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                position = dr.GetString(3)
                modModule.setPositionUser(dr.GetString(3))
            End If

            dr.Close()
            c.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            'sendExcemptionError(ex.Message, "Log In: Getting User Position")
        Finally
        End Try
    End Sub

    Public Sub auditTrail()
        'Try
        '    Dim path As String
        '    path = "System log as of " & Format(System.DateTime.Now, "ddMMyyyy") & ".txt"
        '    Dim fs As New System.IO.FileStream(path.ToString, IO.FileMode.Append.Append, IO.FileAccess.Write)
        '    Dim writer As New System.IO.StreamWriter(fs)

        '    writer.WriteLine("Tri-Marine Group - Production Information System Monitoring Log")
        '    writer.WriteLine("System initialized @		: " & getServerDateTime())
        '    writer.WriteLine("System opened @		: " & getServerDateTime())
        '    writer.WriteLine("Product Name		: " & Application.ProductName.ToString)
        '    writer.WriteLine("Product Version		: " & Application.ProductVersion.ToString)
        '    writer.WriteLine("User			: " & modModule.getUserFullName)
        '    writer.WriteLine("System Developer:")
        '    writer.WriteLine("	Edmond C. Gudez, BSCS")
        '    writer.WriteLine("	IT Manager")
        '    writer.WriteLine("	Tel No. +677(7470023)")
        '    writer.WriteLine("	egudez@gmail.com")
        '    writer.WriteLine()
        '    writer.WriteLine("********************************************************")
        '    writer.Close()
        'Catch ex As Exception
        '    sendExcemptionError(ex.Message, "Log In: Audit Trail")
        'End Try
    End Sub

    Public Function getUserFullName(ByVal username As String, ByVal password As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand("SELECT userCompleteName " & _
                " FROM dbo.tblSystemAccount " & _
                " WHERE username LIKE '" & username & "' AND " & _
                " password LIKE '" & password & "'", c)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            Dim name As String
            If dr.Read Then
                name = dr.GetString(0)
            End If

            dr.Close()
            c.Close()
            Return name
        Catch ex As Exception
            MsgBox(ex.Message)
            'sendExcemptionError(ex.Message, "Log In: Get User Full Name")
        Finally
        End Try
    End Function
End Class
