Public Class frmFishWithdrawal_DataEntry2
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
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cboPurpose As C1.Win.C1List.C1Combo
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents cboRemarks As C1.Win.C1List.C1Combo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblNW As System.Windows.Forms.Label
    Friend WithEvents lblTW As System.Windows.Forms.Label
    Friend WithEvents lblFishSize As System.Windows.Forms.Label
    Friend WithEvents lblFishSpecie As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblFWS As System.Windows.Forms.Label
    Friend WithEvents txtAcceptDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblGW As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblStack As System.Windows.Forms.Label
    Friend WithEvents lblRow As System.Windows.Forms.Label
    Friend WithEvents lblLane As System.Windows.Forms.Label
    Friend WithEvents lblRm As System.Windows.Forms.Label
    Friend WithEvents lblRejectMsg As System.Windows.Forms.Label
    Friend WithEvents lblPS As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents gridSalt As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblSubLot As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFishWithdrawal_DataEntry2))
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
        Dim Style17 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style18 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style19 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style20 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style21 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style22 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style23 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style24 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style25 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style26 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style27 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style28 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style29 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style30 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style31 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style32 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style33 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style34 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style35 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style36 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style37 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style38 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style39 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style40 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.txtAcceptDate = New C1.Win.C1Input.C1DateEdit()
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.cboPurpose = New C1.Win.C1List.C1Combo()
        Me.cboBin = New C1.Win.C1List.C1Combo()
        Me.cboRemarks = New C1.Win.C1List.C1Combo()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblNW = New System.Windows.Forms.Label()
        Me.lblTW = New System.Windows.Forms.Label()
        Me.lblFishSize = New System.Windows.Forms.Label()
        Me.lblFishSpecie = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.lblFWS = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSubLot = New System.Windows.Forms.Label()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblGW = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStack = New System.Windows.Forms.Label()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.lblLane = New System.Windows.Forms.Label()
        Me.lblRm = New System.Windows.Forms.Label()
        Me.lblRejectMsg = New System.Windows.Forms.Label()
        Me.lblPS = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.gridSalt = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.txtAcceptDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPurpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSalt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAcceptDate
        '
        Me.txtAcceptDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcceptDate.Location = New System.Drawing.Point(112, 55)
        Me.txtAcceptDate.Name = "txtAcceptDate"
        Me.txtAcceptDate.Size = New System.Drawing.Size(224, 23)
        Me.txtAcceptDate.TabIndex = 1
        Me.txtAcceptDate.Tag = Nothing
        Me.txtAcceptDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(112, 88)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(224, 23)
        Me.txtProdnDate.TabIndex = 2
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboShift
        '
        Me.cboShift.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboShift.AllowColMove = False
        Me.cboShift.AutoCompletion = True
        Me.cboShift.AutoDropDown = True
        Me.cboShift.Caption = ""
        Me.cboShift.CaptionHeight = 17
        Me.cboShift.CaptionStyle = Style1
        Me.cboShift.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboShift.ColumnCaptionHeight = 17
        Me.cboShift.ColumnFooterHeight = 17
        Me.cboShift.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboShift.ContentHeight = 18
        Me.cboShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboShift.EditorHeight = 18
        Me.cboShift.EvenRowStyle = Style2
        Me.cboShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.FooterStyle = Style3
        Me.cboShift.HeadingStyle = Style4
        Me.cboShift.HighLightRowStyle = Style5
        Me.cboShift.Images.Add(CType(resources.GetObject("cboShift.Images"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(112, 119)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.OddRowStyle = Style6
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.SelectedStyle = Style7
        Me.cboShift.Size = New System.Drawing.Size(144, 24)
        Me.cboShift.Style = Style8
        Me.cboShift.TabIndex = 3
        Me.cboShift.PropBag = resources.GetString("cboShift.PropBag")
        '
        'cboPurpose
        '
        Me.cboPurpose.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboPurpose.AllowColMove = False
        Me.cboPurpose.AutoCompletion = True
        Me.cboPurpose.AutoDropDown = True
        Me.cboPurpose.Caption = ""
        Me.cboPurpose.CaptionHeight = 17
        Me.cboPurpose.CaptionStyle = Style9
        Me.cboPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPurpose.ColumnCaptionHeight = 17
        Me.cboPurpose.ColumnFooterHeight = 17
        Me.cboPurpose.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboPurpose.ContentHeight = 18
        Me.cboPurpose.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPurpose.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPurpose.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPurpose.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPurpose.EditorHeight = 18
        Me.cboPurpose.EvenRowStyle = Style10
        Me.cboPurpose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPurpose.FooterStyle = Style11
        Me.cboPurpose.HeadingStyle = Style12
        Me.cboPurpose.HighLightRowStyle = Style13
        Me.cboPurpose.Images.Add(CType(resources.GetObject("cboPurpose.Images"), System.Drawing.Image))
        Me.cboPurpose.ItemHeight = 20
        Me.cboPurpose.Location = New System.Drawing.Point(112, 152)
        Me.cboPurpose.MatchEntryTimeout = CType(2000, Long)
        Me.cboPurpose.MaxDropDownItems = CType(5, Short)
        Me.cboPurpose.MaxLength = 32767
        Me.cboPurpose.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.OddRowStyle = Style14
        Me.cboPurpose.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPurpose.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPurpose.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPurpose.SelectedStyle = Style15
        Me.cboPurpose.Size = New System.Drawing.Size(224, 24)
        Me.cboPurpose.Style = Style16
        Me.cboPurpose.TabIndex = 4
        Me.cboPurpose.PropBag = resources.GetString("cboPurpose.PropBag")
        '
        'cboBin
        '
        Me.cboBin.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboBin.AllowColMove = False
        Me.cboBin.AutoCompletion = True
        Me.cboBin.AutoDropDown = True
        Me.cboBin.Caption = ""
        Me.cboBin.CaptionHeight = 17
        Me.cboBin.CaptionStyle = Style17
        Me.cboBin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBin.ColumnCaptionHeight = 17
        Me.cboBin.ColumnFooterHeight = 17
        Me.cboBin.ContentHeight = 45
        Me.cboBin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBin.EditorFont = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBin.EditorHeight = 45
        Me.cboBin.EvenRowStyle = Style18
        Me.cboBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.FooterStyle = Style19
        Me.cboBin.HeadingStyle = Style20
        Me.cboBin.HighLightRowStyle = Style21
        Me.cboBin.Images.Add(CType(resources.GetObject("cboBin.Images"), System.Drawing.Image))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(112, 216)
        Me.cboBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboBin.MaxDropDownItems = CType(10, Short)
        Me.cboBin.MaxLength = 32767
        Me.cboBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBin.Name = "cboBin"
        Me.cboBin.OddRowStyle = Style22
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.SelectedStyle = Style23
        Me.cboBin.Size = New System.Drawing.Size(224, 51)
        Me.cboBin.Style = Style24
        Me.cboBin.TabIndex = 6
        Me.cboBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cboBin.PropBag = resources.GetString("cboBin.PropBag")
        '
        'cboRemarks
        '
        Me.cboRemarks.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboRemarks.AllowColMove = False
        Me.cboRemarks.AutoCompletion = True
        Me.cboRemarks.AutoDropDown = True
        Me.cboRemarks.Caption = ""
        Me.cboRemarks.CaptionHeight = 17
        Me.cboRemarks.CaptionStyle = Style25
        Me.cboRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRemarks.ColumnCaptionHeight = 17
        Me.cboRemarks.ColumnFooterHeight = 17
        Me.cboRemarks.ContentHeight = 18
        Me.cboRemarks.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRemarks.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRemarks.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemarks.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemarks.EditorHeight = 18
        Me.cboRemarks.EvenRowStyle = Style26
        Me.cboRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemarks.FooterStyle = Style27
        Me.cboRemarks.HeadingStyle = Style28
        Me.cboRemarks.HighLightRowStyle = Style29
        Me.cboRemarks.Images.Add(CType(resources.GetObject("cboRemarks.Images"), System.Drawing.Image))
        Me.cboRemarks.ItemHeight = 20
        Me.cboRemarks.Location = New System.Drawing.Point(112, 272)
        Me.cboRemarks.MatchEntryTimeout = CType(2000, Long)
        Me.cboRemarks.MaxDropDownItems = CType(5, Short)
        Me.cboRemarks.MaxLength = 32767
        Me.cboRemarks.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRemarks.Name = "cboRemarks"
        Me.cboRemarks.OddRowStyle = Style30
        Me.cboRemarks.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRemarks.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRemarks.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRemarks.SelectedStyle = Style31
        Me.cboRemarks.Size = New System.Drawing.Size(224, 24)
        Me.cboRemarks.Style = Style32
        Me.cboRemarks.TabIndex = 7
        Me.cboRemarks.PropBag = resources.GetString("cboRemarks.PropBag")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(363, 240)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 16)
        Me.Label19.TabIndex = 148
        Me.Label19.Text = "Net Weight"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(363, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 16)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = "Tare Weight"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(640, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 16)
        Me.Label18.TabIndex = 146
        Me.Label18.Text = "Fish Size"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(640, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 16)
        Me.Label16.TabIndex = 145
        Me.Label16.Text = "Fish Species"
        '
        'lblNW
        '
        Me.lblNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNW.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNW.Location = New System.Drawing.Point(448, 240)
        Me.lblNW.Name = "lblNW"
        Me.lblNW.Size = New System.Drawing.Size(176, 56)
        Me.lblNW.TabIndex = 144
        Me.lblNW.Text = "0"
        Me.lblNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTW
        '
        Me.lblTW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTW.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTW.Location = New System.Drawing.Point(448, 184)
        Me.lblTW.Name = "lblTW"
        Me.lblTW.Size = New System.Drawing.Size(176, 50)
        Me.lblTW.TabIndex = 143
        Me.lblTW.Text = "0"
        Me.lblTW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFishSize
        '
        Me.lblFishSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFishSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFishSize.Location = New System.Drawing.Point(720, 120)
        Me.lblFishSize.Name = "lblFishSize"
        Me.lblFishSize.Size = New System.Drawing.Size(168, 23)
        Me.lblFishSize.TabIndex = 142
        Me.lblFishSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFishSpecie
        '
        Me.lblFishSpecie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFishSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFishSpecie.Location = New System.Drawing.Point(720, 88)
        Me.lblFishSpecie.Name = "lblFishSpecie"
        Me.lblFishSpecie.Size = New System.Drawing.Size(168, 23)
        Me.lblFishSpecie.TabIndex = 141
        Me.lblFishSpecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Shift"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Prodn Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Acceptance Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Remarks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Trip Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Purpose"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(248, 488)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(168, 488)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 10
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(88, 488)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(8, 488)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 8
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(898, 40)
        Me.Label13.TabIndex = 159
        Me.Label13.Text = "Raw Fish Withdrawal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 16)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Cannery Accepted Summary"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 328)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(664, 152)
        Me.grid.TabIndex = 160
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'lblFWS
        '
        Me.lblFWS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFWS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWS.Location = New System.Drawing.Point(332, 17)
        Me.lblFWS.Name = "lblFWS"
        Me.lblFWS.Size = New System.Drawing.Size(224, 23)
        Me.lblFWS.TabIndex = 162
        Me.lblFWS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFWS.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(504, 488)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(168, 47)
        Me.lblTotal.TabIndex = 164
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(416, 496)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Total Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(363, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Lot ID"
        '
        'lblSubLot
        '
        Me.lblSubLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubLot.Location = New System.Drawing.Point(448, 88)
        Me.lblSubLot.Name = "lblSubLot"
        Me.lblSubLot.Size = New System.Drawing.Size(176, 23)
        Me.lblSubLot.TabIndex = 166
        Me.lblSubLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
        Me.cboLot.Caption = ""
        Me.cboLot.CaptionHeight = 17
        Me.cboLot.CaptionStyle = Style33
        Me.cboLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLot.ColumnCaptionHeight = 17
        Me.cboLot.ColumnFooterHeight = 17
        Me.cboLot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.EvenRowStyle = Style34
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.FooterStyle = Style35
        Me.cboLot.HeadingStyle = Style36
        Me.cboLot.HighLightRowStyle = Style37
        Me.cboLot.Images.Add(CType(resources.GetObject("cboLot.Images"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(112, 184)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(10, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style38
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.SelectedStyle = Style39
        Me.cboLot.Size = New System.Drawing.Size(224, 24)
        Me.cboLot.Style = Style40
        Me.cboLot.TabIndex = 5
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 170
        Me.Label9.Text = "Fish Bin"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(363, 128)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 16)
        Me.Label20.TabIndex = 172
        Me.Label20.Text = "Gross Weight"
        '
        'lblGW
        '
        Me.lblGW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGW.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGW.Location = New System.Drawing.Point(448, 128)
        Me.lblGW.Name = "lblGW"
        Me.lblGW.Size = New System.Drawing.Size(176, 50)
        Me.lblGW.TabIndex = 171
        Me.lblGW.Text = "0"
        Me.lblGW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(640, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 180
        Me.Label10.Text = "Room"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(640, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 179
        Me.Label11.Text = "Stack"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(640, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 16)
        Me.Label12.TabIndex = 178
        Me.Label12.Text = "Row"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(640, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 177
        Me.Label14.Text = "Lane"
        '
        'lblStack
        '
        Me.lblStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStack.Location = New System.Drawing.Point(720, 248)
        Me.lblStack.Name = "lblStack"
        Me.lblStack.Size = New System.Drawing.Size(168, 23)
        Me.lblStack.TabIndex = 176
        '
        'lblRow
        '
        Me.lblRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow.Location = New System.Drawing.Point(720, 215)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(168, 23)
        Me.lblRow.TabIndex = 175
        '
        'lblLane
        '
        Me.lblLane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLane.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLane.Location = New System.Drawing.Point(720, 185)
        Me.lblLane.Name = "lblLane"
        Me.lblLane.Size = New System.Drawing.Size(168, 23)
        Me.lblLane.TabIndex = 174
        '
        'lblRm
        '
        Me.lblRm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRm.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRm.Location = New System.Drawing.Point(720, 153)
        Me.lblRm.Name = "lblRm"
        Me.lblRm.Size = New System.Drawing.Size(168, 23)
        Me.lblRm.TabIndex = 173
        '
        'lblRejectMsg
        '
        Me.lblRejectMsg.AutoSize = True
        Me.lblRejectMsg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRejectMsg.Location = New System.Drawing.Point(453, 90)
        Me.lblRejectMsg.Name = "lblRejectMsg"
        Me.lblRejectMsg.Size = New System.Drawing.Size(0, 16)
        Me.lblRejectMsg.TabIndex = 181
        '
        'lblPS
        '
        Me.lblPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPS.Location = New System.Drawing.Point(448, 55)
        Me.lblPS.Name = "lblPS"
        Me.lblPS.Size = New System.Drawing.Size(176, 23)
        Me.lblPS.TabIndex = 182
        Me.lblPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(363, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 16)
        Me.Label21.TabIndex = 183
        Me.Label21.Text = "Protocol"
        '
        'gridSalt
        '
        Me.gridSalt.AllowColMove = False
        Me.gridSalt.AllowUpdate = False
        Me.gridSalt.CaptionHeight = 17
        Me.gridSalt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSalt.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSalt.Images.Add(CType(resources.GetObject("gridSalt.Images"), System.Drawing.Image))
        Me.gridSalt.Location = New System.Drawing.Point(717, 328)
        Me.gridSalt.Name = "gridSalt"
        Me.gridSalt.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSalt.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSalt.PreviewInfo.ZoomFactor = 75.0R
        Me.gridSalt.PrintInfo.PageSettings = CType(resources.GetObject("gridSalt.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridSalt.RowHeight = 20
        Me.gridSalt.Size = New System.Drawing.Size(171, 152)
        Me.gridSalt.TabIndex = 184
        Me.gridSalt.Text = "C1TrueDBGrid1"
        Me.gridSalt.Visible = False
        Me.gridSalt.PropBag = resources.GetString("gridSalt.PropBag")
        '
        'frmFishWithdrawal_DataEntry2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(898, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.gridSalt)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblPS)
        Me.Controls.Add(Me.lblRejectMsg)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblStack)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.lblLane)
        Me.Controls.Add(Me.lblRm)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblGW)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblSubLot)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFWS)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblNW)
        Me.Controls.Add(Me.lblTW)
        Me.Controls.Add(Me.lblFishSize)
        Me.Controls.Add(Me.lblFishSpecie)
        Me.Controls.Add(Me.cboRemarks)
        Me.Controls.Add(Me.cboBin)
        Me.Controls.Add(Me.cboPurpose)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtProdnDate)
        Me.Controls.Add(Me.txtAcceptDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishWithdrawal_DataEntry2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishWithdrawal_DataEntry2"
        CType(Me.txtAcceptDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPurpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSalt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFishWithdrawal_DataEntry2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtAcceptDate.Value = getServerDateTime()
        txtProdnDate.Value = getServerDateTime()

        initializeShift()
        displayPurpose()
        'displayDepositedBins()
        displayAllBatchlotsDeposited("%")
        'displayColdStorage)
        'displayAllBatchlotsDeposited("%")
        'displayFishLotDepositedDetails(cboCS.Text, cboLot.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Public Sub displayColdStorage()
    '    With cboCS
    '        .DataSource = modModule.getColdStorage().Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 200

    '        If .ListCount > 0 Then .SelectedIndex = 0
    '    End With
    'End Sub

    Public Sub initializeShift()
        With cboShift
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 120
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayPurpose()
        With cboPurpose
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .AddItemTitles("Purpose")
            .AddItem("For Production")
            .AddItem("For Export")
            .AddItem("For Reject")
            .Splits(0).DisplayColumns(0).Width = 200
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayDepositedBins(ByVal lot As String)
        'With cboBin
        '    .DataSource = getFishBins_Deposited().Tables(0)
        '    .Splits(0).DisplayColumns(0).Width = 200
        '    displaySummary()
        'End With

        With cboBin
            '.DataSource = modModule.getFishBinDepositedDetails(cs, lot).Tables(0)
            .DataSource = getFishBinDepositedByLot(lot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200

            displaySummary()
        End With
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPurpose.SelectAll()
            cboPurpose.Focus()
        End If
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text.Trim = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

        displayFWSCode(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboPurpose.Text)
        displaySummary()
    End Sub

    Private Sub cboPurpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPurpose.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Private Sub cboPurpose_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPurpose.TextChanged
        If cboPurpose.Text.Trim = "" Then If cboPurpose.ListCount > 0 Then cboPurpose.SelectedIndex = 0

        'If cboPurpose.Text.StartsWith("For Prod") Then
        '    cboRemarks.ReadOnly = True
        '    cboRemarks.Text = "*"
        'Else
        '    cboRemarks.ReadOnly = False
        '    cboRemarks.Text = ""
        'End If

        displaySummary()
    End Sub

    Public Sub getFishBinDepositedDetails(ByVal lot As String, ByVal bin As String)
        'ByVal cs As String, 
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_FishBinDetailsPerLot" ' "proc_display_FishBinDetailsPerColdStorage"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            'Dim p1 As New SqlClient.SqlParameter
            'p1.ParameterName = "@cs"
            'p1.Direction = ParameterDirection.Input
            'p1.SqlDbType = SqlDbType.VarChar
            'p1.Value = cs

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@lot"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = lot

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@bin"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = bin

            'cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblFishSpecie.Text = dr.GetString(1)
                    lblFishSize.Text = dr.GetString(2)
                    lblTW.Text = Format(dr.GetDouble(3), "###,##0")
                    lblNW.Text = Format(dr.GetDouble(4), "###,##0")
                    'cboCS.Text = dr.GetString(5)
                    lblSubLot.Text = dr.GetString(7)   '6

                    If dr.GetString(7) = "" Then lblSubLot.Text = "Fish Reject"

                    lblGW.Text = Format(CDbl(lblTW.Text) + lblNW.Text, "###,##0")

                    If dr.GetString(8) = "-1" Then
                        lblPS.Text = "YES"
                    Else
                        lblPS.Text = ""
                    End If

                    displaySaltContent(cboLot.Text, lblSubLot.Text)
                Else
                    lblFishSpecie.Text = ""
                    lblFishSize.Text = ""
                    lblTW.Text = "0"
                    lblNW.Text = "0"
                    'cboCS.Text = ""
                    lblSubLot.Text = ""
                    lblGW.Text = "0"
                    lblPS.Text = ""
                    displaySaltContent(cboLot.Text, lblSubLot.Text)
                End If
            Else
                lblFishSpecie.Text = ""
                lblFishSize.Text = ""
                lblTW.Text = "0"
                lblNW.Text = "0"
                'cboCS.Text = ""
                lblSubLot.Text = ""
                lblGW.Text = "0"
                lblPS.Text = ""
                displaySaltContent(cboLot.Text, lblSubLot.Text)
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboBin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBin.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboRemarks.SelectAll()
            cboRemarks.Focus()
        End If
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        getFishBinDepositedDetails(cboLot.Text, cboBin.Text)    'cboCS.Text, 
        displayBinLocations(cboBin.Text, cboLot.Text)
    End Sub

    Public Sub displaySummary()
        With grid
            .DataSource = getSummaryCanneryAccepted(txtProdnDate.Value, cboShift.Text, cboPurpose.Text).Tables(0)

            .Columns(3).NumberFormat = "###,###,###,##0.#0"
            .Splits(0).DisplayColumns(0).Width = 150
            .Splits(0).DisplayColumns(1).Width = 170
            .Splits(0).DisplayColumns(2).Width = 150
            .Splits(0).DisplayColumns(3).Width = 150
        End With

        computeTotalAccepted()
    End Sub

    Private Sub txtProdnDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdnDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        If Not txtProdnDate.Text = "" Then
            displayFWSCode(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboPurpose.Text)
            displayDepositedBins(cboLot.Text)
            'displayFishBinsDepositedDetails(cboLot.Text)    'cboCS.Text, 
            displaySummary()
            'computeTotalWeight()
        End If
    End Sub

    Public Sub computeTotalAccepted()
        Dim ctr As Integer
        Dim total As Double
        While ctr < grid.RowCount
            total += grid.Item(ctr, 3)
            ctr += 1
        End While

        lblTotal.Text = Format(total, "###,###,##0.#0")
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        txtAcceptDate.SelectAll()
        txtAcceptDate.Focus()
    End Sub

    Public Sub addNewRecord()
        lblFWS.Text = ""
        txtAcceptDate.Value = getServerDateTime()
        txtProdnDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        cboPurpose.SelectedIndex = 0
        'displayColdStorage()
        'cboCS.Text = ""
        'displayDepositedBins()
        displayAllBatchlotsDeposited("%")
        'displayFishBinsDepositedDetails(cboLot.Text)    'cboCS.Text, 

        displaySummary()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim f As New frmPrintFishDeposits
        'f.Label13.Text = "Detailed Cannery Acceptance of Fish Lot"
        'f.displayFWS(cboLot.Text)
        'f.ShowDialog(Me)

        ''Dim f As New frmPrintFWS
        ''f.bags = False
        ''f.txtDate.Value = getServerDateTime()
        ''f.initializeShift()

        ''f.txtDate.Value = txtProdnDate.Value
        ''f.cboShift.Text = cboProdnShift.Text
        ''f.cboFWS.Text = lblFWS.Text
        ''f.ShowDialog(Me)

        Dim f As New frmPrintFWR
        f.Label1.Text = "Print Daily Cold Storage Fish Bin Withdrawal Report"
        f.daily = True
        f.lot = False
        f.specie = False
        f.weekly = False
        f.dailyLoin = False
        f.ShowDialog(Me)

        cmdNew.Focus()
    End Sub

    Public Sub displayFWSCode(ByVal prodnDate As String, ByVal shift As String, ByVal lot As String, ByVal purpose As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getFWSCode_ByProdnDate"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@prodnDate"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            If prodnDate = "" Then
                p1.Value = Format(getServerDateTime, getTimeFormat())
            Else
                p1.Value = Format(CDate(prodnDate), getTimeFormat())
            End If

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@shift"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = shift

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@lot"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = lot

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@purpose"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = purpose

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblFWS.Text = dr.GetString(0)
                Else
                    lblFWS.Text = ""
                End If
            Else
                lblFWS.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub lblLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSubLot.TextChanged
        'displayFWSCode(txtProdnDate.Text, cboShift.Text, lblLot.Text, cboPurpose.Text)
        'displayFishBinsDepositedDetails(lblLot.Text)    'cboCS.Text, 

       
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String
        If Not txtAcceptDate.Text.Trim = "" And Not txtProdnDate.Text.Trim = "" And Not cboShift.Text.Trim = "" And _
        Not cboPurpose.Text.Trim = "" And Not cboLot.Text.Trim = "" And Not cboBin.Text.Trim = "" And _
        Not lblFishSpecie.Text.Trim = "" And Not lblNW.Text.Trim = "" And Not lblNW.Text.Trim = "0" Then
            If validateSpecie() Then
                If lblFWS.Text.Trim = "" Then
                    'If validateFishLot(cboLot.Text) Then
                    reply = MsgBox("Are you sure you want to withdraw this bin from this tripcode?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        saveNewFishBinWithdrawals(getServerDateTime(), "Day", cboLot.Text, _
                            txtProdnDate.Text, cboShift.Text, cboRemarks.Text, cboPurpose.Text, txtAcceptDate.Text)

                        'Dim ctr As Integer
                        'With grid
                        '    While ctr < .RowCount
                        '        If Not .Item(ctr, 7) Is DBNull.Value Then
                        '            If CStr(.Item(ctr, 7)).StartsWith("Yes") Then
                        saveNewFishBinWithdrawalsDetails(lblFWS.Text, cboBin.Text, cboLot.Text, "", "0", "")

                        updateColdStorageStack(lblRm.Text, lblLane.Text, lblRow.Text, lblStack.Text, "")

                        'updateFishBinStack(lblRm.Text, lblLane.Text, lblRow.Text)

                        updateFishBinWithdrawalStatus(cboBin.Text, cboLot.Text, "YES")
                        '            End If
                        '        End If

                        '        ctr += 1
                        '    End While
                        'End With

                        Dim stack As Integer
                        While stack < 6
                            checkForAutoStack(lblRm.Text, lblLane.Text, lblRow.Text)

                            stack += 1
                        End While

                        MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")

                        displayFWSCode(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboPurpose.Text)
                        'displayDepositedBins()
                        displayDepositedBins(cboLot.Text)        'cboCS.Text, 
                        'lblFWS.Text = ""
                        cboBin.Text = ""
                        cboBin.SelectAll()
                        cboBin.Focus()

                    Else
                        txtProdnDate.SelectAll()
                        txtProdnDate.Focus()
                        Exit Sub
                    End If
                    'Else
                    '    MsgBox("Fish lot doesn't found in the database", MsgBoxStyle.Critical, "No record found")
                    '    cboLot.SelectAll()
                    '    cboLot.Focus()
                    'End If
                Else
                    'reply = MsgBox("Fish Withdrawal Slip No. " & lblFWS.Text & " already stored in the database" & Chr(13) & _
                    '    "Once you clicked Yes, the bin number and it's details will be added to the existing records.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    reply = MsgBox("Are you sure you want to withdraw this bin number from this tripcode?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        saveNewFishBinWithdrawalsDetails(lblFWS.Text, cboBin.Text, cboLot.Text, "", "0", "")

                        updateColdStorageStack(lblRm.Text, lblLane.Text, lblRow.Text, lblStack.Text, "")

                        'updateFishBinStack(lblRm.Text, lblLane.Text, lblRow.Text)

                        updateFishBinWithdrawalStatus(cboBin.Text, cboLot.Text, "YES")

                        Dim stack As Integer
                        While stack < 6
                            checkForAutoStack(lblRm.Text, lblLane.Text, lblRow.Text)

                            stack += 1
                        End While

                        MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")

                        'displayFishBinsDepositedDetails(cboLot.Text)        'cboCS.Text, 
                        'displayFishBinsDepositedDetails(cboLot.Text)        'cboCS.Text, 
                        Me.displayDepositedBins(cboLot.Text)
                        'lblFWS.Text = ""
                        cboBin.Text = ""
                        cboBin.SelectAll()
                        cboBin.Focus()
                    Else
                        cboBin.SelectAll()
                        cboBin.Focus()
                        Exit Sub
                    End If
                End If
                'Else
                '    MsgBox("Attempt to withdraw fish lot having no QC laboratory test or production hold is strictly not allowed", MsgBoxStyle.Exclamation, "Warning")
                '    cboLot.SelectAll()
                '    cboLot.Focus()
            End If
        Else
            MsgBox("Please check your fish deposit details.", MsgBoxStyle.Critical, "Result: Found missing value.")
            txtAcceptDate.SelectAll()
            txtAcceptDate.Focus()
        End If
    End Sub

    Public Function validateSpecie() As Boolean
        If cboPurpose.Text.Contains("Export") Then
            If getQALotResults(cboLot.Text, lblSubLot.Text, "status").StartsWith("Fail") Or lblSubLot.Text = "Fish Reject" Then
                MsgBox("You cannot export fish when it Fails to laboratory test or if the bin is vessel rejects", MsgBoxStyle.Exclamation, "Warning")

                Return False
            Else
                Return True
            End If
        ElseIf cboPurpose.Text.Contains("Reject") Then
            If getQALotResults(cboLot.Text, lblSubLot.Text, "status").StartsWith("Fail") Or lblSubLot.Text = "Fish Reject" Then
                Return True
            Else
                MsgBox("You cannot withdraw fish for dumping if the lot didn't failed from the laboratory test or if the bin is not vessel rejects", MsgBoxStyle.Exclamation, "Warning")
            End If

            'Else
            'Return False
            'End If
        Else
            If lblPS.Text = "YES" Then
                If getRawFishAnalysisResults(cboLot.Text, lblSubLot.Text, "histamine") = "Pass" And getRawFishAnalysisResults(cboLot.Text, lblSubLot.Text, "salt") = "Pass" And getIfSaltValueIsAcceptable() Then
                    Return True
                Else
                    MsgBox("Protocol sample must pass first the histamine, salt test and has salt value", MsgBoxStyle.Exclamation, "Warning")
                    Return False
                End If
            Else
                If getQALotResults(cboLot.Text, lblSubLot.Text, "status").StartsWith("Pass") Or getQALotResults(cboLot.Text, lblSubLot.Text, "status").StartsWith("SP") Then
                    Return True
                Else
                    MsgBox("You cannot withdraw fish for production if the lot doesn't have any laboratory test", MsgBoxStyle.Exclamation, "Warning")
                    Return False
                End If
            End If
        End If
    End Function

    Public Sub saveNewFishBinWithdrawals(ByVal dateTime As String, ByVal shift As String, ByVal lot As String, _
   ByVal prodnDate As String, ByVal prodnShift As String, ByVal relNo As String, ByVal purpose As String, _
    ByVal acceptDate As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FishBinsWithdrawal"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishBinWithdrawalCounter()

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@fwsCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            If prodnShift = "Day" Then
                lblFWS.Text = Format(CDate(prodnDate), getTimeFormatForCode()) & "D" & lot & "_" & Format(getFishBinWithdrawalCounter, "0#####")
            Else
                lblFWS.Text = Format(CDate(prodnDate), getTimeFormatForCode()) & "N" & lot & "_" & Format(getFishBinWithdrawalCounter, "0#####")
            End If

            p2.Value = lblFWS.Text

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@dateReleased"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.DateTime
            p3.Value = Format(getServerDateTime(), getTimeFormat())

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@shift"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = shift

            Dim pOptr As New SqlClient.SqlParameter
            pOptr.ParameterName = "@optr"
            pOptr.Direction = ParameterDirection.Input
            pOptr.SqlDbType = SqlDbType.VarChar
            pOptr.Value = modModule.getUsername

            Dim pEncoded As New SqlClient.SqlParameter
            pEncoded.ParameterName = "@dateTimeEncoded"
            pEncoded.Direction = ParameterDirection.Input
            pEncoded.SqlDbType = SqlDbType.DateTime
            pEncoded.Value = getServerDateTime()

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@prodnDate"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.DateTime
            p5.Value = Format(CDate(prodnDate), getTimeFormat())

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@prodnShift"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = prodnShift

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@relNo"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.VarChar
            p7.Value = relNo

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@purpose"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.VarChar
            p8.Value = purpose

            Dim p9 As New SqlClient.SqlParameter
            p9.ParameterName = "@acceptDate"
            p9.Direction = ParameterDirection.Input
            p9.SqlDbType = SqlDbType.DateTime
            p9.Value = Format(CDate(acceptDate), getTimeFormat() & " hh:mm:ss tt")

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)
            cmd.Parameters.Add(p9)

            Dim daBuyer As New SqlClient.SqlDataAdapter
            daBuyer.SelectCommand = cmd

            Dim dsBuyer As New DataSet("dbPPICIS")
            daBuyer.Fill(dsBuyer)

            daBuyer.Dispose()
            dsBuyer.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displayBinLocations(ByVal bin As String, ByVal lot As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_binLocationsByLot"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@bin"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = bin

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@lot"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = lot

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblRm.Text = dr.GetString(0)
                    lblLane.Text = dr.GetString(1)
                    lblRow.Text = dr.GetString(2)
                    lblStack.Text = dr.GetString(3)
                Else
                    lblRm.Text = ""
                    lblLane.Text = ""
                    lblRow.Text = ""
                    lblStack.Text = ""
                End If
            Else
                lblRm.Text = ""
                lblLane.Text = ""
                lblRow.Text = ""
                lblStack.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displayAllBatchlotsDeposited(ByVal cs As String)
        With cboLot
            .Text = ""
            .DataSource = modModule.getBatchlotsDeposited().Tables(0) 'getBatchlotsDeposited(cs).Tables(0)
            'getBatchlotsDeposited().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
            '.Splits(0).DisplayColumns(1).Width = 440
            '.Splits(0).DisplayColumns(2).Width = 118

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboBin.SelectAll()
            cboBin.Focus()
        End If
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displayFWSCode(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboPurpose.Text)
        displayDepositedBins(cboLot.Text)    'cboCS.Text, 

        getFishBinDepositedDetails(cboLot.Text, cboBin.Text)    'cboCS.Text, 
        displayBinLocations(cboBin.Text, cboLot.Text)
    End Sub

    Public Sub displaySaltContent(ByVal lot As String, ByVal sublot As String)
        With gridSalt
            .DataSource = getFishLotFishSizes(lot, sublot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 50
            .Splits(0).DisplayColumns(1).Width = 50

            '.Splits(0).DisplayColumns(0).Locked = True
            '.Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray

            displayContent(lot, sublot)
        End With
    End Sub

    Public Sub displayContent(ByVal lot As String, ByVal sublot As String)
        With gridSalt
            Dim ctr As Integer
            While ctr < .RowCount
                .Item(ctr, 1) = Format(getSaltContent(lot, sublot, .Item(ctr, 0)), "###,##0.#0")

                ctr += 1
            End While
        End With
    End Sub

    Public Function getIfSaltValueIsAcceptable() As Boolean
        With gridSalt
            Dim ctr As Integer
            Dim total As Double
            While ctr < .RowCount
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

    Private Sub txtAcceptDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcceptDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProdnDate.SelectAll()
            txtProdnDate.Focus()
        End If
    End Sub

    Private Sub cboRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave.Focus()
        End If
    End Sub
End Class

