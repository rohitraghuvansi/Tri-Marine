Public Class frmFishingVessel
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
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents txtFlag As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtReg As System.Windows.Forms.TextBox
    Friend WithEvents txtCallSign As System.Windows.Forms.TextBox
    Friend WithEvents txtImo As System.Windows.Forms.TextBox
    Friend WithEvents txtLicense As System.Windows.Forms.TextBox
    Friend WithEvents txtImmarsat As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefax As System.Windows.Forms.TextBox
    Friend WithEvents txtValid As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtTelNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboMethod As C1.Win.C1List.C1Combo
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtEu As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFishingVessel))
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
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.txtCallSign = New System.Windows.Forms.TextBox()
        Me.txtImo = New System.Windows.Forms.TextBox()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.txtImmarsat = New System.Windows.Forms.TextBox()
        Me.txtTelefax = New System.Windows.Forms.TextBox()
        Me.txtValid = New C1.Win.C1Input.C1DateEdit()
        Me.txtTelNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboMethod = New C1.Win.C1List.C1Combo()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtEu = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboVessel
        '
        Me.cboVessel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboVessel.AllowColMove = False
        Me.cboVessel.AutoCompletion = True
        Me.cboVessel.AutoDropDown = True
        Me.cboVessel.Caption = ""
        Me.cboVessel.CaptionHeight = 17
        Me.cboVessel.CaptionStyle = Style1
        Me.cboVessel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVessel.ColumnCaptionHeight = 17
        Me.cboVessel.ColumnFooterHeight = 17
        Me.cboVessel.ContentHeight = 18
        Me.cboVessel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVessel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVessel.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVessel.EditorHeight = 18
        Me.cboVessel.EvenRowStyle = Style2
        Me.cboVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.FooterStyle = Style3
        Me.cboVessel.HeadingStyle = Style4
        Me.cboVessel.HighLightRowStyle = Style5
        Me.cboVessel.Images.Add(CType(resources.GetObject("cboVessel.Images"), System.Drawing.Image))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(121, 85)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(5, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.OddRowStyle = Style6
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.SelectedStyle = Style7
        Me.cboVessel.Size = New System.Drawing.Size(304, 24)
        Me.cboVessel.Style = Style8
        Me.cboVessel.TabIndex = 1
        Me.cboVessel.PropBag = resources.GetString("cboVessel.PropBag")
        '
        'txtFlag
        '
        Me.txtFlag.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlag.Location = New System.Drawing.Point(121, 116)
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(216, 23)
        Me.txtFlag.TabIndex = 2
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(121, 146)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(216, 23)
        Me.txtPort.TabIndex = 3
        '
        'txtReg
        '
        Me.txtReg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReg.Location = New System.Drawing.Point(121, 176)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(216, 23)
        Me.txtReg.TabIndex = 4
        '
        'txtCallSign
        '
        Me.txtCallSign.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallSign.Location = New System.Drawing.Point(121, 207)
        Me.txtCallSign.Name = "txtCallSign"
        Me.txtCallSign.Size = New System.Drawing.Size(216, 23)
        Me.txtCallSign.TabIndex = 5
        '
        'txtImo
        '
        Me.txtImo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImo.Location = New System.Drawing.Point(121, 237)
        Me.txtImo.Name = "txtImo"
        Me.txtImo.Size = New System.Drawing.Size(216, 23)
        Me.txtImo.TabIndex = 6
        '
        'txtLicense
        '
        Me.txtLicense.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicense.Location = New System.Drawing.Point(121, 268)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(216, 23)
        Me.txtLicense.TabIndex = 7
        '
        'txtImmarsat
        '
        Me.txtImmarsat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImmarsat.Location = New System.Drawing.Point(577, 56)
        Me.txtImmarsat.Name = "txtImmarsat"
        Me.txtImmarsat.Size = New System.Drawing.Size(239, 23)
        Me.txtImmarsat.TabIndex = 8
        '
        'txtTelefax
        '
        Me.txtTelefax.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefax.Location = New System.Drawing.Point(577, 86)
        Me.txtTelefax.Name = "txtTelefax"
        Me.txtTelefax.Size = New System.Drawing.Size(239, 23)
        Me.txtTelefax.TabIndex = 9
        '
        'txtValid
        '
        Me.txtValid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValid.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtValid.Location = New System.Drawing.Point(577, 116)
        Me.txtValid.Name = "txtValid"
        Me.txtValid.Size = New System.Drawing.Size(191, 23)
        Me.txtValid.TabIndex = 10
        Me.txtValid.Tag = Nothing
        Me.txtValid.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtTelNo
        '
        Me.txtTelNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelNo.Location = New System.Drawing.Point(577, 146)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(239, 23)
        Me.txtTelNo.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(577, 176)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(239, 23)
        Me.txtEmail.TabIndex = 12
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(9, 328)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(815, 173)
        Me.grid.TabIndex = 12
        Me.grid.TabStop = False
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(540, 506)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(460, 506)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 18
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(380, 506)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 17
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(300, 506)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 16
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(220, 506)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 15
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "License No. *"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Call Sign"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 16)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "IMO UVI No."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 179)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 16)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Registration No. *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Flag"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Vessel Name *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Home Port"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(834, 40)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Fishing Vessel Information"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(815, 250)
        Me.Label1.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(473, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Telephone No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(473, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "E-mail Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(473, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Valid to"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(473, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Immarsat No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(473, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Telefax No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Table View"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Vessel Code"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(473, 210)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 16)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "Fishing Method *"
        '
        'cboMethod
        '
        Me.cboMethod.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboMethod.AllowColMove = False
        Me.cboMethod.AutoCompletion = True
        Me.cboMethod.AutoDropDown = True
        Me.cboMethod.Caption = ""
        Me.cboMethod.CaptionHeight = 17
        Me.cboMethod.CaptionStyle = Style9
        Me.cboMethod.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMethod.ColumnCaptionHeight = 17
        Me.cboMethod.ColumnFooterHeight = 17
        Me.cboMethod.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboMethod.ContentHeight = 18
        Me.cboMethod.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboMethod.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboMethod.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMethod.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMethod.EditorHeight = 18
        Me.cboMethod.EvenRowStyle = Style10
        Me.cboMethod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMethod.FooterStyle = Style11
        Me.cboMethod.HeadingStyle = Style12
        Me.cboMethod.HighLightRowStyle = Style13
        Me.cboMethod.Images.Add(CType(resources.GetObject("cboMethod.Images"), System.Drawing.Image))
        Me.cboMethod.ItemHeight = 20
        Me.cboMethod.Location = New System.Drawing.Point(577, 206)
        Me.cboMethod.MatchEntryTimeout = CType(2000, Long)
        Me.cboMethod.MaxDropDownItems = CType(20, Short)
        Me.cboMethod.MaxLength = 32767
        Me.cboMethod.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMethod.Name = "cboMethod"
        Me.cboMethod.OddRowStyle = Style14
        Me.cboMethod.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMethod.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMethod.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMethod.SelectedStyle = Style15
        Me.cboMethod.Size = New System.Drawing.Size(240, 24)
        Me.cboMethod.Style = Style16
        Me.cboMethod.TabIndex = 13
        Me.cboMethod.PropBag = resources.GetString("cboMethod.PropBag")
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(121, 56)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(136, 23)
        Me.txtCode.TabIndex = 0
        '
        'txtEu
        '
        Me.txtEu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEu.Location = New System.Drawing.Point(577, 237)
        Me.txtEu.Name = "txtEu"
        Me.txtEu.Size = New System.Drawing.Size(240, 23)
        Me.txtEu.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(473, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 16)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "EU Sanitary No."
        '
        'frmFishingVessel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(834, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtEu)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.cboMethod)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelNo)
        Me.Controls.Add(Me.txtValid)
        Me.Controls.Add(Me.txtTelefax)
        Me.Controls.Add(Me.txtImmarsat)
        Me.Controls.Add(Me.txtLicense)
        Me.Controls.Add(Me.txtImo)
        Me.Controls.Add(Me.txtCallSign)
        Me.Controls.Add(Me.txtReg)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.cboVessel)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishingVessel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishingVessel"
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMethod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFishingVessel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtValid.Value = getServerDateTime()
        dataEntry(1)

        displayAllFishingVessel()
        displayFishingVessel()
        displayFishingMethods()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllFishingVessel()
        With grid
            .DataSource = modModule.getAllFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(1).Width = 250
            .Splits(0).DisplayColumns(2).Width = 200
            .Splits(0).DisplayColumns(3).Width = 350
            .Splits(0).DisplayColumns(12).Width = 350
        End With
    End Sub

    Public Sub displayFishingVessel()
        With cboVessel
            .DataSource = modModule.getFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 285
            '.Splits(0).DisplayColumns(5).Width = 120
        End With
    End Sub

    Public Sub buttons(ByVal i As Integer)
        Select Case i
            Case 0
                Me.cmdPrint.Enabled = False
                Me.cmdFind.Enabled = False
                Me.cmdClose.Enabled = False
            Case 1
                Me.cmdPrint.Enabled = True
                Me.cmdFind.Enabled = True
                Me.cmdClose.Enabled = True
        End Select
    End Sub

    Public Sub dataEntry(ByVal s As Int16)
        'used to disable and enable data entry controls
        Select Case s
            Case 0
                txtCode.ReadOnly = False
                cboVessel.ReadOnly = False
                txtFlag.ReadOnly = False
                txtPort.ReadOnly = False
                txtReg.ReadOnly = False
                txtCallSign.ReadOnly = False
                txtImo.ReadOnly = False
                txtLicense.ReadOnly = False
                txtImmarsat.ReadOnly = False
                txtTelefax.ReadOnly = False
                txtValid.ReadOnly = False
                txtTelNo.ReadOnly = False
                txtEmail.ReadOnly = False
                cboMethod.ReadOnly = False
                txtEu.ReadOnly = False
            Case 1
                txtCode.ReadOnly = True
                cboVessel.ReadOnly = True
                txtFlag.ReadOnly = True
                txtPort.ReadOnly = True
                txtReg.ReadOnly = True
                txtCallSign.ReadOnly = True
                txtImo.ReadOnly = True
                txtLicense.ReadOnly = True
                txtImmarsat.ReadOnly = True
                txtTelefax.ReadOnly = True
                txtValid.ReadOnly = True
                txtTelNo.ReadOnly = True
                txtEmail.ReadOnly = True
                cboMethod.ReadOnly = True
                txtEu.ReadOnly = True
        End Select
    End Sub

    Public Sub addNewRecord()
        txtCode.Text = ""
        txtCode.ReadOnly = False
        txtCode.SelectAll()
        txtCode.Focus()
        cboVessel.ReadOnly = False
        cboVessel.Text = ""
        displayFishingVessel()
        txtFlag.Text = ""
        txtPort.Text = ""
        txtReg.Text = ""
        txtCallSign.Text = ""
        txtImo.Text = ""
        txtLicense.Text = ""
        txtImmarsat.Text = ""
        txtTelefax.Text = ""
        txtValid.Value = getServerDateTime()
        txtTelNo.Text = ""
        txtEmail.Text = ""
        txtEu.Text = ""
        displayAllFishingVessel()
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                buttons(0)
                dataEntry(0)
                addNewRecord()
                txtCode.SelectAll()
                txtCode.Focus()
            Case "&Save"
                If Not cboVessel.Text.Trim = "" And Not txtReg.Text = "" And Not txtLicense.Text = "" And _
                Not cboMethod.Text.Trim = "" Then
                    If Not validateFishingVessel(cboVessel.Text, txtReg.Text, txtLicense.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewFishingVessel(cboVessel.Text, txtFlag.Text, txtPort.Text, txtReg.Text, _
                                txtCallSign.Text, txtImo.Text, txtLicense.Text, txtImmarsat.Text, _
                                txtTelefax.Text, txtValid.Text, txtTelNo.Text, txtEmail.Text, cboMethod.Text, txtCode.Text, txtEu.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            displayAllFishingVessel()
                            displayFishingVessel()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Fishing Vessel already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboVessel.SelectAll()
                        cboVessel.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboVessel.SelectAll()
                    cboVessel.Focus()
                End If
            Case "&Save "
                If Not cboVessel.Text.Trim = "" And Not txtReg.Text = "" And Not txtLicense.Text = "" And Not txtImo.Text.Trim = "" Then
                    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        updateFishingVessel(txtCode.Text, cboVessel.Text, txtFlag.Text, txtPort.Text, txtReg.Text, _
                                    txtCallSign.Text, txtImo.Text, txtLicense.Text, txtImmarsat.Text, _
                                    txtTelefax.Text, txtValid.Text, txtTelNo.Text, txtEmail.Text, cboMethod.Text, txtEu.Text)
                        cmd.Text = "&Add"
                        cmdEdit.Text = "&Edit"
                        buttons(1)
                        dataEntry(1)

                        displayAllFishingVessel()
                        'displayFishingVessel()
                        MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                        cmd.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboVessel.SelectAll()
                    cboVessel.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not txtCode.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    txtCode.ReadOnly = True
                    cboVessel.SelectAll()
                    cboVessel.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboVessel.SelectAll()
                    cboVessel.Focus()
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                dataEntry(1)
                cmdEdit.Focus()
        End Select
    End Sub

    Public Sub displayFishingVesselDetails(ByVal code As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_FishingVesselDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@vessel"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = code

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    'txtCode.Text = dr.GetString(0)
                    cboVessel.Text = dr.GetString(1)
                    txtFlag.Text = dr.GetString(2)
                    txtPort.Text = dr.GetString(3)
                    txtReg.Text = dr.GetString(4)
                    txtCallSign.Text = dr.GetString(5)
                    txtImo.Text = dr.GetString(6)
                    txtLicense.Text = dr.GetString(7)
                    txtImmarsat.Text = dr.GetString(8)
                    txtTelefax.Text = dr.GetString(9)
                    txtValid.Value = dr.GetDateTime(10)
                    txtTelNo.Text = dr.GetString(11)
                    txtEmail.Text = dr.GetString(12)
                    cboMethod.Text = dr.GetString(15)
                    txtEu.Text = dr.GetString(16)
                Else
                    'txtCode.Text = ""
                    cboVessel.Text = ""
                    txtFlag.Text = ""
                    txtPort.Text = ""
                    txtReg.Text = ""
                    txtCallSign.Text = ""
                    txtImo.Text = ""
                    txtLicense.Text = ""
                    txtImmarsat.Text = ""
                    txtTelefax.Text = ""
                    txtValid.Value = getServerDateTime()
                    txtTelNo.Text = ""
                    txtEmail.Text = ""
                    cboMethod.Text = ""
                    txtEu.Text = ""
                End If
            Else
                'txtCode.Text = ""
                cboVessel.Text = ""
                txtFlag.Text = ""
                txtPort.Text = ""
                txtReg.Text = ""
                txtCallSign.Text = ""
                txtImo.Text = ""
                txtLicense.Text = ""
                txtImmarsat.Text = ""
                txtTelefax.Text = ""
                txtValid.Value = getServerDateTime()
                txtTelNo.Text = ""
                txtEmail.Text = ""
                cboMethod.Text = ""
                txtEu.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            'MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        'displayFishingVesselDetails(cboVessel.Text)
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        displayDataToEachDataEntry()
    End Sub

    Public Sub displayDataToEachDataEntry()
        With grid
            If .RowCount > 0 Then
                txtCode.Text = .Item(.Row, 0)
                cboVessel.Text = .Item(.Row, 1)
            Else
                txtCode.Text = ""
                cboVessel.Text = ""
            End If
        End With

        txtCode.SelectAll()
        txtCode.Focus()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Fishing Vessel"
        f.searchType = 1
        f.displayAllFishingVessel()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                'cboVessel.Text = .Item(.Row, 1)
                txtCode.Text = .Item(.Row, 0)
            End If
        End With
    End Sub

    Public Sub displayFishingMethods()
        With cboMethod
            .DataSource = modModule.getFishingMethod().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 218
        End With
    End Sub

    Private Sub txtCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave
        txtCode.Text = UCase(txtCode.Text)
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        displayFishingVesselDetails(txtCode.Text)
    End Sub
End Class
