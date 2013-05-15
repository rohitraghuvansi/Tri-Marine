Public Class frmPushBack
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFWS As System.Windows.Forms.Label
    Friend WithEvents cmdTB As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboRm As C1.Win.C1List.C1Combo
    Friend WithEvents cboLane As C1.Win.C1List.C1Combo
    Friend WithEvents cboRow As C1.Win.C1List.C1Combo
    Friend WithEvents lblStack As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style41 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style42 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style43 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style44 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style45 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPushBack))
        Dim Style46 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style47 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style48 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style49 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style50 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style51 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style52 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style53 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style54 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style55 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style56 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style57 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style58 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style59 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style60 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style61 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style62 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style63 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style64 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style65 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style66 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style67 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style68 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style69 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style70 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style71 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style72 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style73 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style74 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style75 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style76 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style77 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style78 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style79 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style80 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.cboBin = New C1.Win.C1List.C1Combo()
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFWS = New System.Windows.Forms.Label()
        Me.cmdTB = New System.Windows.Forms.Button()
        Me.cboRm = New C1.Win.C1List.C1Combo()
        Me.cboLane = New C1.Win.C1List.C1Combo()
        Me.cboRow = New C1.Win.C1List.C1Combo()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblStack = New System.Windows.Forms.Label()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboBin
        '
        Me.cboBin.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboBin.AllowColMove = False
        Me.cboBin.AutoCompletion = True
        Me.cboBin.AutoDropDown = True
        Me.cboBin.Caption = ""
        Me.cboBin.CaptionHeight = 17
        Me.cboBin.CaptionStyle = Style41
        Me.cboBin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBin.ColumnCaptionHeight = 17
        Me.cboBin.ColumnFooterHeight = 17
        Me.cboBin.ContentHeight = 18
        Me.cboBin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBin.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBin.EditorHeight = 18
        Me.cboBin.EvenRowStyle = Style42
        Me.cboBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.FooterStyle = Style43
        Me.cboBin.HeadingStyle = Style44
        Me.cboBin.HighLightRowStyle = Style45
        Me.cboBin.Images.Add(CType(resources.GetObject("cboBin.Images"), System.Drawing.Image))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(112, 53)
        Me.cboBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboBin.MaxDropDownItems = CType(10, Short)
        Me.cboBin.MaxLength = 32767
        Me.cboBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBin.Name = "cboBin"
        Me.cboBin.OddRowStyle = Style46
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.SelectedStyle = Style47
        Me.cboBin.Size = New System.Drawing.Size(160, 24)
        Me.cboBin.Style = Style48
        Me.cboBin.TabIndex = 0
        Me.cboBin.PropBag = resources.GetString("cboBin.PropBag")
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(112, 87)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(160, 23)
        Me.txtProdnDate.TabIndex = 1
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
        Me.cboShift.CaptionStyle = Style49
        Me.cboShift.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboShift.ColumnCaptionHeight = 17
        Me.cboShift.ColumnFooterHeight = 17
        Me.cboShift.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboShift.ContentHeight = 18
        Me.cboShift.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboShift.EditorHeight = 18
        Me.cboShift.EvenRowStyle = Style50
        Me.cboShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.FooterStyle = Style51
        Me.cboShift.HeadingStyle = Style52
        Me.cboShift.HighLightRowStyle = Style53
        Me.cboShift.Images.Add(CType(resources.GetObject("cboShift.Images"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(112, 120)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.OddRowStyle = Style54
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.SelectedStyle = Style55
        Me.cboShift.Size = New System.Drawing.Size(160, 24)
        Me.cboShift.Style = Style56
        Me.cboShift.TabIndex = 2
        Me.cboShift.PropBag = resources.GetString("cboShift.PropBag")
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(6, 208)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(823, 208)
        Me.grid.TabIndex = 3
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(272, 424)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 48)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "&Push-Back"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(488, 424)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "New Shift"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "New Prod'n Date"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(834, 40)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Push Back and Take Back Fish Bins"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Bin Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Bin No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "FWS No."
        '
        'lblFWS
        '
        Me.lblFWS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFWS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWS.Location = New System.Drawing.Point(112, 154)
        Me.lblFWS.Name = "lblFWS"
        Me.lblFWS.Size = New System.Drawing.Size(208, 24)
        Me.lblFWS.TabIndex = 33
        '
        'cmdTB
        '
        Me.cmdTB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTB.Image = CType(resources.GetObject("cmdTB.Image"), System.Drawing.Image)
        Me.cmdTB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTB.Location = New System.Drawing.Point(378, 424)
        Me.cmdTB.Name = "cmdTB"
        Me.cmdTB.Size = New System.Drawing.Size(104, 48)
        Me.cmdTB.TabIndex = 35
        Me.cmdTB.Text = "&Take-Back"
        Me.cmdTB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cboRm
        '
        Me.cboRm.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboRm.AllowColMove = False
        Me.cboRm.AutoCompletion = True
        Me.cboRm.AutoDropDown = True
        Me.cboRm.Caption = ""
        Me.cboRm.CaptionHeight = 17
        Me.cboRm.CaptionStyle = Style57
        Me.cboRm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRm.ColumnCaptionHeight = 17
        Me.cboRm.ColumnFooterHeight = 17
        Me.cboRm.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboRm.ContentHeight = 18
        Me.cboRm.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRm.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRm.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRm.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRm.EditorHeight = 18
        Me.cboRm.EvenRowStyle = Style58
        Me.cboRm.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRm.FooterStyle = Style59
        Me.cboRm.HeadingStyle = Style60
        Me.cboRm.HighLightRowStyle = Style61
        Me.cboRm.Images.Add(CType(resources.GetObject("cboRm.Images"), System.Drawing.Image))
        Me.cboRm.ItemHeight = 20
        Me.cboRm.Location = New System.Drawing.Point(456, 53)
        Me.cboRm.MatchEntryTimeout = CType(2000, Long)
        Me.cboRm.MaxDropDownItems = CType(5, Short)
        Me.cboRm.MaxLength = 32767
        Me.cboRm.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRm.Name = "cboRm"
        Me.cboRm.OddRowStyle = Style62
        Me.cboRm.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRm.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRm.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRm.SelectedStyle = Style63
        Me.cboRm.Size = New System.Drawing.Size(224, 24)
        Me.cboRm.Style = Style64
        Me.cboRm.TabIndex = 36
        Me.cboRm.PropBag = resources.GetString("cboRm.PropBag")
        '
        'cboLane
        '
        Me.cboLane.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboLane.AllowColMove = False
        Me.cboLane.AutoCompletion = True
        Me.cboLane.AutoDropDown = True
        Me.cboLane.Caption = ""
        Me.cboLane.CaptionHeight = 17
        Me.cboLane.CaptionStyle = Style65
        Me.cboLane.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLane.ColumnCaptionHeight = 17
        Me.cboLane.ColumnFooterHeight = 17
        Me.cboLane.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboLane.ContentHeight = 18
        Me.cboLane.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLane.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLane.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLane.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLane.EditorHeight = 18
        Me.cboLane.EvenRowStyle = Style66
        Me.cboLane.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLane.FooterStyle = Style67
        Me.cboLane.HeadingStyle = Style68
        Me.cboLane.HighLightRowStyle = Style69
        Me.cboLane.Images.Add(CType(resources.GetObject("cboLane.Images"), System.Drawing.Image))
        Me.cboLane.ItemHeight = 20
        Me.cboLane.Location = New System.Drawing.Point(456, 86)
        Me.cboLane.MatchEntryTimeout = CType(2000, Long)
        Me.cboLane.MaxDropDownItems = CType(5, Short)
        Me.cboLane.MaxLength = 32767
        Me.cboLane.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLane.Name = "cboLane"
        Me.cboLane.OddRowStyle = Style70
        Me.cboLane.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLane.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLane.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLane.SelectedStyle = Style71
        Me.cboLane.Size = New System.Drawing.Size(224, 24)
        Me.cboLane.Style = Style72
        Me.cboLane.TabIndex = 37
        Me.cboLane.PropBag = resources.GetString("cboLane.PropBag")
        '
        'cboRow
        '
        Me.cboRow.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboRow.AllowColMove = False
        Me.cboRow.AutoCompletion = True
        Me.cboRow.AutoDropDown = True
        Me.cboRow.Caption = ""
        Me.cboRow.CaptionHeight = 17
        Me.cboRow.CaptionStyle = Style73
        Me.cboRow.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRow.ColumnCaptionHeight = 17
        Me.cboRow.ColumnFooterHeight = 17
        Me.cboRow.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboRow.ContentHeight = 18
        Me.cboRow.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRow.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRow.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRow.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRow.EditorHeight = 18
        Me.cboRow.EvenRowStyle = Style74
        Me.cboRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRow.FooterStyle = Style75
        Me.cboRow.HeadingStyle = Style76
        Me.cboRow.HighLightRowStyle = Style77
        Me.cboRow.Images.Add(CType(resources.GetObject("cboRow.Images"), System.Drawing.Image))
        Me.cboRow.ItemHeight = 20
        Me.cboRow.Location = New System.Drawing.Point(456, 120)
        Me.cboRow.MatchEntryTimeout = CType(2000, Long)
        Me.cboRow.MaxDropDownItems = CType(5, Short)
        Me.cboRow.MaxLength = 32767
        Me.cboRow.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRow.Name = "cboRow"
        Me.cboRow.OddRowStyle = Style78
        Me.cboRow.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRow.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRow.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRow.SelectedStyle = Style79
        Me.cboRow.Size = New System.Drawing.Size(224, 24)
        Me.cboRow.Style = Style80
        Me.cboRow.TabIndex = 38
        Me.cboRow.PropBag = resources.GetString("cboRow.PropBag")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(384, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Room"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Row"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(384, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Lane"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(384, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Stack"
        '
        'lblStack
        '
        Me.lblStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStack.Location = New System.Drawing.Point(456, 154)
        Me.lblStack.Name = "lblStack"
        Me.lblStack.Size = New System.Drawing.Size(224, 24)
        Me.lblStack.TabIndex = 42
        '
        'frmPushBack
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(834, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblStack)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboRow)
        Me.Controls.Add(Me.cboLane)
        Me.Controls.Add(Me.cboRm)
        Me.Controls.Add(Me.cmdTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFWS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtProdnDate)
        Me.Controls.Add(Me.cboBin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPushBack"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPushBack"
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmPushBack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtProdnDate.Value = getServerDateTime()
        initializeShift()
        displayColdStorage()
        displayBin()

        displayBinDetails(cboBin.Text)

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayBin()
        With cboBin
            .DefColWidth = 137
            .DataSource = getAllFishBinsWithdrawn().Tables(0)
        End With
    End Sub

    Public Sub initializeShift()
        With cboShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 137
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayBinDetails(ByVal bin As String)
        With grid
            .DataSource = getFishBinsWithdrawn_Details(bin).Tables(0)
            .Splits(0).DisplayColumns(1).Width = 50
            .Splits(0).DisplayColumns(2).Width = 80
            .Splits(0).DisplayColumns(3).Width = 200
            .Splits(0).DisplayColumns(4).Width = 80
            .Splits(0).DisplayColumns(8).Width = 80
            .Splits(0).DisplayColumns(9).Width = 60
            .Splits(0).DisplayColumns(10).Width = 60
            .Splits(0).DisplayColumns(11).Width = 60
            .Splits(0).DisplayColumns(12).Width = 150
            .Splits(0).DisplayColumns(13).Width = 150

            .Columns(6).NumberFormat = "###,###,##0.#0"
            .Columns(7).NumberFormat = "###,###,##0.#0"
        End With
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        lblFWS.Text = ""
        displayBinDetails(cboBin.Text)
        displaybinlocations(cboBin.Text)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'MsgBox(getFWSCode(grid.Item(grid.Row, 0), grid.Item(grid.Row, 1), grid.Item(grid.Row, 2), cboBin.Text))
        Dim reply As String
        Dim binCode_FromDeposit As String

        With grid
            If Not cboBin.Text = "" Then 'And Not getFWSCode(txtProdnDate.Text, cboShift.Text, .Item(.Row, 2), "%") = "" Then
                reply = MsgBox("Are you sure you want to push it to the next production date??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    If lblFWS.Text = "" Then
                        saveNewFishBinWithdrawals(getServerDateTime(), "Day", .Item(.Row, 2), _
                            txtProdnDate.Text, cboShift.Text, "", "For Production")
                    End If

                    binCode_FromDeposit = .Item(.Row, 12)
                    '//getDepositCode(cboBin.Text, .Item(.Row, 2), getFWSCode(.Item(.Row, 0), .Item(.Row, 1), .Item(.Row, 2), cboBin.Text))

                    deleteBinFromFWS(.Item(.Row, 13), binCode_FromDeposit)
                    'getFWSCode(.Item(.Row, 0), .Item(.Row, 1), .Item(.Row, 2), cboBin.Text)

                    updateBin_PushBack(binCode_FromDeposit, txtProdnDate.Text)

                    saveNewFishBinWithdrawalsDetails(lblFWS.Text, binCode_FromDeposit)
                    'getFWSCode(txtProdnDate.Text, cboShift.Text, .Item(.Row, 2), "%")

                    displayBinDetails(cboBin.Text)

                    MsgBox("Transaction completed", MsgBoxStyle.Information, "Information")
                End If
            Else
                MsgBox("Please make sure you have properly identify the production date", MsgBoxStyle.Exclamation, "Warning")
            End If

            cboBin.SelectAll()
            cboBin.Focus()
        End With
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

        With grid
            If .RowCount > 0 Then
                lblFWS.Text = getFWSCode(txtProdnDate.Text, cboShift.Text, .Item(.Row, 2), "%")
            Else
                lblFWS.Text = ""
            End If
        End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        With grid
            If .RowCount > 0 Then
                lblFWS.Text = getFWSCode(txtProdnDate.Text, cboShift.Text, .Item(.Row, 2), "%")
            Else
                lblFWS.Text = ""
            End If
        End With
    End Sub

    Public Sub saveNewFishBinWithdrawals(ByVal dateTime As String, ByVal shift As String, ByVal lot As String, _
    ByVal prodnDate As String, ByVal prodnShift As String, ByVal relNo As String, ByVal purpose As String)
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
                lblFWS.Text = Format(CDate(prodnDate), "ddMMyy") & "D" & lot & "_" & Format(getFishBinWithdrawalCounter, "0#####")
            Else
                lblFWS.Text = Format(CDate(prodnDate), "ddMMyy") & "N" & lot & "_" & Format(getFishBinWithdrawalCounter, "0#####")
            End If

            p2.Value = lblFWS.Text

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@dateReleased"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.DateTime
            p3.Value = CDate(dateTime) 'Format(CDate(dateTime), getTimeFormat())

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
            p9.ParameterName = "@prodnTime"
            p9.Direction = ParameterDirection.Input
            p9.SqlDbType = SqlDbType.DateTime
            p9.Value = Format(CDate(prodnDate), getTimeFormat() & " hh:mm:ss tt")

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

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        With grid
            If .RowCount > 0 Then
                lblFWS.Text = getFWSCode(txtProdnDate.Text, cboShift.Text, .Item(.Row, 2), "%")
            Else
                lblFWS.Text = ""
            End If
        End With
    End Sub

    Private Sub cmdTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTB.Click
        'MsgBox(getFWSCode(grid.Item(grid.Row, 0), grid.Item(grid.Row, 1), grid.Item(grid.Row, 2), cboBin.Text))
        Dim reply As String
        Dim binCode_FromDeposit As String

        With grid
            If Not cboRm.Text.Trim = "" And Not cboLane.Text.Trim = "" And _
            Not cboRow.Text.Trim = "" And Not lblStack.Text.Trim = "0" Then
                If Not cboBin.Text = "" Then 'And Not getFWSCode(txtProdnDate.Text, cboShift.Text, .Item(.Row, 2), "%") = "" Then
                    reply = MsgBox("Are you sure you want to take-it back to the cold storage?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        'If lblFWS.Text = "" Then
                        '    saveNewFishBinWithdrawals(getServerDateTime(), "Day", .Item(.Row, 2), _
                        '        txtProdnDate.Text, cboShift.Text, "", "For Production")
                        'End If

                        binCode_FromDeposit = .Item(.Row, 12)

                        updateFishBinWithdrawalStatus(binCode_FromDeposit, "NO")
                        updateBinLocation(binCode_FromDeposit, cboRm.Text, cboLane.Text, cboRow.Text, lblStack.Text)

                        updateColdStorageStack(cboRm.Text, cboLane.Text, cboRow.Text, lblStack.Text, binCode_FromDeposit)

                        updateBin_PushBack(binCode_FromDeposit, txtProdnDate.Text)

                        '//getDepositCode(cboBin.Text, .Item(.Row, 2), getFWSCode(.Item(.Row, 0), .Item(.Row, 1), .Item(.Row, 2), cboBin.Text))

                        deleteBinFromFWS(.Item(.Row, 13), binCode_FromDeposit)
                        'getFWSCode(.Item(.Row, 0), .Item(.Row, 1), .Item(.Row, 2), cboBin.Text)

                        'saveNewFishBinWithdrawalsDetails(lblFWS.Text, binCode_FromDeposit)
                        'getFWSCode(txtProdnDate.Text, cboShift.Text, .Item(.Row, 2), "%")

                        displayBinDetails(cboBin.Text)

                        MsgBox("Transaction completed", MsgBoxStyle.Information, "Information")
                        cboBin.Text = ""
                    End If
                Else
                    MsgBox("Please make sure you have properly identify the production date", MsgBoxStyle.Exclamation, "Warning")
                    cboBin.SelectAll()
                    cboBin.Focus()
                End If
            Else
                MsgBox("Please make sure that the stack of the bin is not yet full", MsgBoxStyle.Exclamation, "Warning")
                cboRow.SelectAll()
                cboRow.Focus()
            End If
        End With
    End Sub

    Public Sub displayBinLocations(ByVal bin As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_binLocations"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@bin"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = bin

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    cboRm.Text = dr.GetString(0)
                    cboLane.Text = dr.GetString(1)
                    cboRow.Text = dr.GetString(2)
                    lblStack.Text = dr.GetString(3)
                    lblStack.Text = getNextAvailableBinHeight(cboRm.Text, cboLane.Text, cboRow.Text)
                Else
                    cboRm.Text = ""
                    cboLane.Text = ""
                    cboRow.Text = ""
                    lblStack.Text = ""
                End If
            Else
                cboRm.Text = ""
                cboLane.Text = ""
                cboRow.Text = ""
                lblStack.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displayColdStorage()
        With cboRm
            .DefColWidth = 200
            .DataSource = modModule.getColdStorage().Tables(0)
        End With
    End Sub

    Private Sub cboRm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRm.TextChanged
        displayColdStorageLane(cboRm.Text)
    End Sub

    Public Sub displayColdStorageLane(ByVal room As String)
        With cboLane
            .Text = ""
            .DataSource = modModule.getColdStorageLane(room).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLane_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLane.TextChanged
        displayColdStorageRow(cboRm.Text, cboLane.Text)
    End Sub

    Public Sub displayColdStorageRow(ByVal room As String, ByVal lane As String)
        With cboRow
            .Text = ""
            .DataSource = modModule.getColdStorageRow(room, cboLane.Text).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboRow_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRow.TextChanged
        lblStack.Text = getNextAvailableBinHeight(cboRm.Text, cboLane.Text, cboRow.Text)
    End Sub

    Private Sub grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid.Click

    End Sub
End Class
