Public Class frmAnalysis_Raw_DataEntry
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
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cboSublot As C1.Win.C1List.C1Combo
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents gridSalt As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents chkHandle As System.Windows.Forms.CheckBox
    Friend WithEvents chkHold As System.Windows.Forms.CheckBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optHFail As System.Windows.Forms.RadioButton
    Friend WithEvents optHPass As System.Windows.Forms.RadioButton
    Friend WithEvents optHPending As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optPFail As System.Windows.Forms.RadioButton
    Friend WithEvents optPPass As System.Windows.Forms.RadioButton
    Friend WithEvents optPPending As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optSFail As System.Windows.Forms.RadioButton
    Friend WithEvents optSPass As System.Windows.Forms.RadioButton
    Friend WithEvents optSPending As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gridLogs As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysis_Raw_DataEntry))
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style9 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style10 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style11 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style12 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style13 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style14 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style15 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style16 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.cboSublot = New C1.Win.C1List.C1Combo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optSFail = New System.Windows.Forms.RadioButton()
        Me.optSPass = New System.Windows.Forms.RadioButton()
        Me.optSPending = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optPFail = New System.Windows.Forms.RadioButton()
        Me.optPPass = New System.Windows.Forms.RadioButton()
        Me.optPPending = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optHFail = New System.Windows.Forms.RadioButton()
        Me.optHPass = New System.Windows.Forms.RadioButton()
        Me.optHPending = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkHold = New System.Windows.Forms.CheckBox()
        Me.chkHandle = New System.Windows.Forms.CheckBox()
        Me.gridSalt = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gridLogs = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridSalt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
        Me.cboLot.Caption = ""
        Me.cboLot.CaptionHeight = 17
        Me.cboLot.CaptionStyle = Style1
        Me.cboLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLot.ColumnCaptionHeight = 17
        Me.cboLot.ColumnFooterHeight = 17
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.EvenRowStyle = Style2
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.FooterStyle = Style3
        Me.cboLot.HeadingStyle = Style4
        Me.cboLot.HighLightRowStyle = Style5
        Me.cboLot.Images.Add(CType(resources.GetObject("cboLot.Images"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(96, 56)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(10, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style6
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.SelectedStyle = Style7
        Me.cboLot.Size = New System.Drawing.Size(200, 24)
        Me.cboLot.Style = Style8
        Me.cboLot.TabIndex = 1
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'cboSublot
        '
        Me.cboSublot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboSublot.AllowColMove = False
        Me.cboSublot.AutoCompletion = True
        Me.cboSublot.AutoDropDown = True
        Me.cboSublot.Caption = ""
        Me.cboSublot.CaptionHeight = 17
        Me.cboSublot.CaptionStyle = Style9
        Me.cboSublot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSublot.ColumnCaptionHeight = 17
        Me.cboSublot.ColumnFooterHeight = 17
        Me.cboSublot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboSublot.ContentHeight = 18
        Me.cboSublot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSublot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSublot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSublot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSublot.EditorHeight = 18
        Me.cboSublot.EvenRowStyle = Style10
        Me.cboSublot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSublot.FooterStyle = Style11
        Me.cboSublot.HeadingStyle = Style12
        Me.cboSublot.HighLightRowStyle = Style13
        Me.cboSublot.Images.Add(CType(resources.GetObject("cboSublot.Images"), System.Drawing.Image))
        Me.cboSublot.ItemHeight = 20
        Me.cboSublot.Location = New System.Drawing.Point(96, 88)
        Me.cboSublot.MatchEntryTimeout = CType(2000, Long)
        Me.cboSublot.MaxDropDownItems = CType(10, Short)
        Me.cboSublot.MaxLength = 32767
        Me.cboSublot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSublot.Name = "cboSublot"
        Me.cboSublot.OddRowStyle = Style14
        Me.cboSublot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSublot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSublot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSublot.SelectedStyle = Style15
        Me.cboSublot.Size = New System.Drawing.Size(200, 24)
        Me.cboSublot.Style = Style16
        Me.cboSublot.TabIndex = 2
        Me.cboSublot.PropBag = resources.GetString("cboSublot.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(352, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Total Quantity"
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.SystemColors.Control
        Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(448, 56)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(101, 24)
        Me.lblQty.TabIndex = 35
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chkHold)
        Me.GroupBox1.Controls.Add(Me.chkHandle)
        Me.GroupBox1.Controls.Add(Me.gridSalt)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 274)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Results"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optSFail)
        Me.GroupBox4.Controls.Add(Me.optSPass)
        Me.GroupBox4.Controls.Add(Me.optSPending)
        Me.GroupBox4.Location = New System.Drawing.Point(120, 90)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(392, 40)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        '
        'optSFail
        '
        Me.optSFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSFail.Location = New System.Drawing.Point(278, 11)
        Me.optSFail.Name = "optSFail"
        Me.optSFail.Size = New System.Drawing.Size(106, 24)
        Me.optSFail.TabIndex = 11
        Me.optSFail.Text = "Fail"
        '
        'optSPass
        '
        Me.optSPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSPass.Location = New System.Drawing.Point(142, 11)
        Me.optSPass.Name = "optSPass"
        Me.optSPass.Size = New System.Drawing.Size(120, 24)
        Me.optSPass.TabIndex = 10
        Me.optSPass.Text = "Pass"
        '
        'optSPending
        '
        Me.optSPending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSPending.Location = New System.Drawing.Point(6, 11)
        Me.optSPending.Name = "optSPending"
        Me.optSPending.Size = New System.Drawing.Size(120, 24)
        Me.optSPending.TabIndex = 9
        Me.optSPending.Text = "Pending"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optPFail)
        Me.GroupBox3.Controls.Add(Me.optPPass)
        Me.GroupBox3.Controls.Add(Me.optPPending)
        Me.GroupBox3.Location = New System.Drawing.Point(120, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 40)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        '
        'optPFail
        '
        Me.optPFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPFail.Location = New System.Drawing.Point(278, 11)
        Me.optPFail.Name = "optPFail"
        Me.optPFail.Size = New System.Drawing.Size(106, 24)
        Me.optPFail.TabIndex = 8
        Me.optPFail.Text = "Fail"
        '
        'optPPass
        '
        Me.optPPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPPass.Location = New System.Drawing.Point(142, 11)
        Me.optPPass.Name = "optPPass"
        Me.optPPass.Size = New System.Drawing.Size(120, 24)
        Me.optPPass.TabIndex = 7
        Me.optPPass.Text = "Pass"
        '
        'optPPending
        '
        Me.optPPending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPPending.Location = New System.Drawing.Point(6, 11)
        Me.optPPending.Name = "optPPending"
        Me.optPPending.Size = New System.Drawing.Size(120, 24)
        Me.optPPending.TabIndex = 6
        Me.optPPending.Text = "Pending"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optHFail)
        Me.GroupBox2.Controls.Add(Me.optHPass)
        Me.GroupBox2.Controls.Add(Me.optHPending)
        Me.GroupBox2.Location = New System.Drawing.Point(120, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 40)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        '
        'optHFail
        '
        Me.optHFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHFail.Location = New System.Drawing.Point(279, 12)
        Me.optHFail.Name = "optHFail"
        Me.optHFail.Size = New System.Drawing.Size(105, 24)
        Me.optHFail.TabIndex = 5
        Me.optHFail.Text = "Fail"
        '
        'optHPass
        '
        Me.optHPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHPass.Location = New System.Drawing.Point(143, 12)
        Me.optHPass.Name = "optHPass"
        Me.optHPass.Size = New System.Drawing.Size(120, 24)
        Me.optHPass.TabIndex = 4
        Me.optHPass.Text = "Pass"
        '
        'optHPending
        '
        Me.optHPending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHPending.Location = New System.Drawing.Point(7, 12)
        Me.optHPending.Name = "optHPending"
        Me.optHPending.Size = New System.Drawing.Size(120, 24)
        Me.optHPending.TabIndex = 3
        Me.optHPending.Text = "Pending"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Salt Content*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Protocol Sample*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Histamine*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Salt*"
        '
        'chkHold
        '
        Me.chkHold.Location = New System.Drawing.Point(272, 248)
        Me.chkHold.Name = "chkHold"
        Me.chkHold.Size = New System.Drawing.Size(272, 24)
        Me.chkHold.TabIndex = 14
        Me.chkHold.Text = "Production Hold (Remarks Req'd)"
        '
        'chkHandle
        '
        Me.chkHandle.Location = New System.Drawing.Point(16, 248)
        Me.chkHandle.Name = "chkHandle"
        Me.chkHandle.Size = New System.Drawing.Size(248, 24)
        Me.chkHandle.TabIndex = 13
        Me.chkHandle.Text = "Special Handle (Remark Req'd)"
        '
        'gridSalt
        '
        Me.gridSalt.CaptionHeight = 17
        Me.gridSalt.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSalt.Images.Add(CType(resources.GetObject("gridSalt.Images"), System.Drawing.Image))
        Me.gridSalt.Location = New System.Drawing.Point(120, 136)
        Me.gridSalt.Name = "gridSalt"
        Me.gridSalt.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSalt.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSalt.PreviewInfo.ZoomFactor = 75.0R
        Me.gridSalt.PrintInfo.PageSettings = CType(resources.GetObject("gridSalt.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridSalt.RowHeight = 20
        Me.gridSalt.Size = New System.Drawing.Size(392, 112)
        Me.gridSalt.TabIndex = 12
        Me.gridSalt.Text = "C1TrueDBGrid1"
        Me.gridSalt.PropBag = resources.GetString("gridSalt.PropBag")
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(128, 400)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(440, 48)
        Me.txtRemarks.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(930, 40)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "QA Raw Fish Analysis Results"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Trip Code*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Lot Name*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Status"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(448, 88)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(120, 24)
        Me.lblStatus.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 400)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "QA Remarks*"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(320, 457)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Cancel"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(240, 457)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 16
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(552, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 16)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "mt"
        '
        'gridLogs
        '
        Me.gridLogs.AllowUpdate = False
        Me.gridLogs.CaptionHeight = 17
        Me.gridLogs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridLogs.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridLogs.Images.Add(CType(resources.GetObject("gridLogs.Images"), System.Drawing.Image))
        Me.gridLogs.Location = New System.Drawing.Point(584, 88)
        Me.gridLogs.Name = "gridLogs"
        Me.gridLogs.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridLogs.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridLogs.PreviewInfo.ZoomFactor = 75.0R
        Me.gridLogs.PrintInfo.PageSettings = CType(resources.GetObject("gridLogs.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridLogs.RowHeight = 20
        Me.gridLogs.Size = New System.Drawing.Size(336, 416)
        Me.gridLogs.TabIndex = 53
        Me.gridLogs.Text = "C1TrueDBGrid1"
        Me.gridLogs.PropBag = resources.GetString("gridLogs.PropBag")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(584, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "History Logs"
        '
        'frmAnalysis_Raw_DataEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(930, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.gridLogs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.cboSublot)
        Me.Controls.Add(Me.cboLot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAnalysis_Raw_DataEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnalysis_Raw_DataEntry"
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridSalt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmAnalysis_Raw_DataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        'displayFishLot()
        'displayLogs()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displaySublot(cboLot.Text)
        displayRawFishAnalysisResults(cboLot.Text, cboSublot.Text)
    End Sub

    Public Sub displaySublot(ByVal lot As String)
        With cboSublot
            .Text = ""
            .DataSource = modModule.getFishLot_MethodAndVesselInfo(lot).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 170
            .Splits(0).DisplayColumns(1).Width = 105

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishLot()
        With cboLot
            .DataSource = modModule.getAllFishLots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 170
        End With
    End Sub

    Private Sub cboSublot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSublot.TextChanged
        lblQty.Text = Format(getTotalTonnagePerSublot(cboLot.Text, cboSublot.Text) / 1000, "###,##0.##0")
        displayRawFishAnalysisResults(cboLot.Text, cboSublot.Text)
    End Sub

    Public Sub isLotApproved()
        If optHPass.Checked = True And optPPass.Checked = True And optSPass.Checked = True And _
            chkHold.Checked = False And chkHandle.Checked = False And checkIfValuesAreEmpty(True) Then
            lblStatus.Text = "Pass"
        Else
            If optHFail.Checked = True Then
                lblStatus.Text = "Fail"
            ElseIf optPFail.Checked = True Then
                lblStatus.Text = "Fail"
            ElseIf optSFail.Checked = True Then
                lblStatus.Text = "Fail"
            Else
                If chkHold.Checked = True Then
                    lblStatus.Text = "Hold"
                ElseIf chkHandle.Checked = True Then
                    lblStatus.Text = "SP Handle"
                Else
                    lblStatus.Text = "Pend"
                End If
            End If
        End If
    End Sub

    Private Sub optHPending_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optHPending.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub optHPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optHPass.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub optHFail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optHFail.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub optPPending_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPPending.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub optPPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPPass.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub optPFail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPFail.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub optSPending_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSPending.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub optSPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSPass.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub optSFail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSFail.CheckedChanged
        isLotApproved()
    End Sub

    Public Sub displaySaltContent(ByVal lot As String, ByVal sublot As String)
        With gridSalt
            .DataSource = getFishLotFishSizes(lot, sublot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
            .Splits(0).DisplayColumns(1).Width = 150

            .Splits(0).DisplayColumns(0).Locked = True
            .Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray

            displayContent()
        End With
    End Sub

    Public Sub displayContent()
        With gridSalt
            Dim ctr As Integer
            While ctr < .RowCount
                .Item(ctr, 1) = Format(getSaltContent(cboLot.Text, cboSublot.Text, .Item(ctr, 0)), "###,##0.#0")

                ctr += 1
            End While
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String
        If Not cboLot.Text.Trim = "" And Not cboSublot.Text.Trim = "" And _
        Not lblStatus.Text.Trim = "" Then   'And checkIfValuesAreEmpty(False) 
            If checkForRemarks() Then
                If Not validateQCRawFishAnalysis(cboLot.Text, cboSublot.Text) Then
                    reply = MsgBox("Are you sure you want to add this test?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    If reply = vbYes Then
                        saveQCRawFishAnalysisResults(cboLot.Text, cboSublot.Text, getResults("histamine"), _
                            getResults("ps"), getResults("salt"), getResults("handle"), getResults("hold"), txtRemarks.Text, lblStatus.Text)

                        saveSaltContent()

                        saveQCRawFishAnalysisResults_Logs(cboLot.Text, cboSublot.Text, _
                            "Histamine=" & getResults("histamine") & "; " & "Protocol=" & getResults("ps") & "; " & _
                            "Salt=" & getResults("salt") & "; " & "Handle=" & getResults("handle") & "; " & _
                            "Hold=" & getResults("hold") & "; " & "Remarks=" & txtRemarks.Text)
                        displayLogs(cboLot.Text, cboSublot.Text)

                        MsgBox("You have successfully added the new record", MsgBoxStyle.Information, "Information")
                    End If
                Else
                    reply = MsgBox("Please save your changes or cancel before moving to another lot?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    If reply = vbYes Then
                        updateQCRawFishAnalysisResults(cboLot.Text, cboSublot.Text, getResults("histamine"), _
                            getResults("ps"), getResults("salt"), getResults("handle"), getResults("hold"), txtRemarks.Text, lblStatus.Text)

                        saveSaltContent()

                        saveQCRawFishAnalysisResults_Logs(cboLot.Text, cboSublot.Text, _
                            "Histamine=" & getResults("histamine") & "; " & "Protocol=" & getResults("ps") & "; " & _
                            "Salt=" & getResults("salt") & "; " & "Handle=" & getResults("handle") & "; " & _
                            "Hold=" & getResults("hold") & "; " & "Remarks=" & txtRemarks.Text)
                        displayLogs(cboLot.Text, cboSublot.Text)

                        MsgBox("You have successfully updated the record", MsgBoxStyle.Information, "Information")
                    End If
                End If
            Else
                MsgBox("A special handle or Hold flag must include a remark", MsgBoxStyle.Exclamation, "Warning")
            End If
        Else
            MsgBox("Please identify the correct trip code, fish lot and status before you can proceed", MsgBoxStyle.Exclamation, "Warning")
        End If

        cboLot.SelectAll()
        cboLot.Focus()
    End Sub

    Public Sub saveSaltContent()
        With gridSalt
            Dim ctr As Integer
            If Not validateQCRawFishAnalysis_SaltContent(cboLot.Text, cboSublot.Text) Then
                While ctr < .RowCount
                    saveQCRawFishAnalysisResults_SaltContent(cboLot.Text, cboSublot.Text, .Item(ctr, 0), .Item(ctr, 1))

                    ctr += 1
                End While
            Else
                While ctr < .RowCount
                    updateQCRawFishAnalysisResults_SaltContent(cboLot.Text, cboSublot.Text, .Item(ctr, 0), .Item(ctr, 1))

                    ctr += 1
                End While
            End If
        End With
    End Sub

    Public Function checkIfValuesAreEmpty(ByVal isZero As Boolean) As Boolean
        With gridSalt
            Dim ctr As Integer
            Dim total As Double
            While ctr < .RowCount
                If isZero Then
                    If .Item(ctr, 1) Is DBNull.Value Then Return False
                    'If CDbl(.Item(ctr, 1)) = 0 Then Return False
                Else
                    If .Item(ctr, 1) Is DBNull.Value Then Return False
                End If

                total += .Item(ctr, 1)

                ctr += 1
            End While

            If total > 0 Then
                Return True
            Else
                Return False
            End If
        End With
    End Function

    Public Sub displayRawFishAnalysisResults(ByVal lot As String, ByVal sublot As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_QCRawAnalysisResults"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@lot"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = lot

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@sublot"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = sublot

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)

            Dim drCode As SqlClient.SqlDataReader
            drCode = cmd.ExecuteReader

            If drCode.Read Then
                If Not drCode(0) Is DBNull.Value Then
                    Select Case drCode.GetString(0)
                        Case "Pending"
                            optHPending.Checked = True
                        Case "Pass"
                            optHPass.Checked = True
                        Case Else
                            optHFail.Checked = True
                    End Select

                    Select Case drCode.GetString(1)
                        Case "Pending"
                            optPPending.Checked = True
                        Case "Pass"
                            optPPass.Checked = True
                        Case Else
                            optPFail.Checked = True
                    End Select

                    Select Case drCode.GetString(2)
                        Case "Pending"
                            optSPending.Checked = True
                        Case "Pass"
                            optSPass.Checked = True
                        Case Else
                            optSFail.Checked = True
                    End Select

                    displaySaltContent(cboLot.Text, cboSublot.Text)

                    If drCode.GetString(3) = "YES" Then
                        chkHandle.Checked = True
                    Else
                        chkHandle.Checked = False
                    End If

                    If drCode.GetString(4) = "YES" Then
                        chkHold.Checked = True
                    Else
                        chkHold.Checked = False
                    End If

                    txtRemarks.Text = drCode.GetString(5)
                Else
                    optHPending.Checked = True
                    optPPending.Checked = True
                    optSPending.Checked = True
                    displaySaltContent(cboLot.Text, cboSublot.Text)
                    chkHandle.Checked = False
                    chkHold.Checked = False
                    txtRemarks.Text = ""
                End If
            Else
                optHPending.Checked = True
                optPPending.Checked = True
                optSPending.Checked = True
                displaySaltContent(cboLot.Text, cboSublot.Text)
                chkHandle.Checked = False
                chkHold.Checked = False
                txtRemarks.Text = ""
            End If

            drCode.Close()
            c.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            ' sendExcemptionError(ex.Message, "Raw Fish Analysis: Display of Raw Fish Analysis Results")
        Finally
        End Try
    End Sub

    Public Function getResults(ByVal typeOfTests As String) As String
        Select Case typeOfTests
            Case "histamine"
                If optHPending.Checked = True Then
                    Return "Pending"
                ElseIf optHPass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If
            Case "ps"
                If optPPending.Checked = True Then
                    Return "Pending"
                ElseIf optPPass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If
            Case "salt"
                If optSPending.Checked = True Then
                    Return "Pending"
                ElseIf optSPass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If
            Case "handle"
                If chkHandle.Checked = True Then
                    Return "YES"
                Else
                    Return "NO"
                End If
            Case "hold"
                If chkHold.Checked = True Then
                    Return "YES"
                Else
                    Return "NO"
                End If
        End Select
    End Function

    Private Sub txtRemarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks.TextChanged

    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSublot.SelectAll()
            cboSublot.Focus()
        End If
    End Sub

    Private Sub cboSublot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSublot.KeyDown
        If e.KeyCode = Keys.Enter Then
            optHPending.Focus()
        End If
    End Sub

    Private Sub optHPending_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optHPending.KeyDown
        If e.KeyCode = Keys.Enter Then
            optHPass.Focus()
        End If
    End Sub

    Private Sub optHPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optHPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            optHFail.Focus()
        End If
    End Sub

    Private Sub optHFail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optHFail.KeyDown
        If e.KeyCode = Keys.Enter Then
            optPPending.Focus()
        End If
    End Sub

    Private Sub optPPending_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optPPending.KeyDown
        If e.KeyCode = Keys.Enter Then
            optPPass.Focus()
        End If
    End Sub

    Private Sub optPPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optPPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            optPFail.Focus()
        End If
    End Sub

    Private Sub optPFail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optPFail.KeyDown
        If e.KeyCode = Keys.Enter Then
            optSPending.Focus()
        End If
    End Sub

    Private Sub optSPending_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optSPending.KeyDown
        If e.KeyCode = Keys.Enter Then
            optSPass.Focus()
        End If
    End Sub

    Private Sub optSPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optSPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            optSFail.Focus()
        End If
    End Sub

    Private Sub optSFail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optSFail.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridSalt.Focus()
        End If
    End Sub

    Private Sub chkHandle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkHandle.KeyDown
        If e.KeyCode = Keys.Enter Then
            chkHold.Focus()
        End If
    End Sub

    Private Sub chkHold_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkHold.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRemarks.SelectAll()
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub txtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave.Focus()
        End If
    End Sub

    Public Sub displayLogs(ByVal lot As String, ByVal sublot As String)
        With gridLogs
            .DataSource = getAllQCRawFishAnalysisLogs(lot, sublot).Tables(0)
            .Columns(1).NumberFormat = getTimeFormat() & " hh:mm:ss tt"

            .Splits(0).DisplayColumns(0).Width = 130
            .Splits(0).DisplayColumns(1).Width = 180
            .Splits(0).DisplayColumns(4).Width = 500
        End With
    End Sub

    Public Function checkForRemarks() As Boolean
        If chkHandle.Checked = True Or chkHold.Checked = True Then
            If txtRemarks.Text.Trim = "" Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If

    End Function

    Private Sub gridSalt_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridSalt.AfterUpdate
        isLotApproved()
    End Sub

    Private Sub gridSalt_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles gridSalt.RowColChange
        isLotApproved()
    End Sub

    Private Sub chkHandle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHandle.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub chkHold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHold.CheckedChanged
        isLotApproved()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
