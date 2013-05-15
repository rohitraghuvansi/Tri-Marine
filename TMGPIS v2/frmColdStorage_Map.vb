Public Class frmColdStorage_Map
    Inherits System.Windows.Forms.Form

    Public Shared room, lane, row, stack As String

    Dim bin As String
    Dim sRm As String
    Dim sLn As String
    Dim sRw As String
    Dim sSk As String
    Friend WithEvents cmdBlock As System.Windows.Forms.Button
    Friend WithEvents lblRejectMsg As System.Windows.Forms.Label
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public Shared cancelTrans As Boolean
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
    Friend WithEvents cboRm As C1.Win.C1List.C1Combo
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cboLane As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSelect As System.Windows.Forms.Button
    Friend WithEvents cmdReserved As System.Windows.Forms.Button
    Friend WithEvents cmdMove As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRow As System.Windows.Forms.Label
    Friend WithEvents lblStack As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblTripCode As System.Windows.Forms.Label
    Friend WithEvents lblLot As System.Windows.Forms.Label
    Friend WithEvents lblBin As System.Windows.Forms.Label
    Friend WithEvents lblSpecie As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblNW As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColdStorage_Map))
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
        Me.cboRm = New C1.Win.C1List.C1Combo()
        Me.cboLane = New C1.Win.C1List.C1Combo()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdReserved = New System.Windows.Forms.Button()
        Me.cmdMove = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStack = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblTripCode = New System.Windows.Forms.Label()
        Me.lblLot = New System.Windows.Forms.Label()
        Me.lblBin = New System.Windows.Forms.Label()
        Me.lblSpecie = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblNW = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdBlock = New System.Windows.Forms.Button()
        Me.lblRejectMsg = New System.Windows.Forms.Label()
        Me.cboBin = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.cboRm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboRm
        '
        Me.cboRm.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboRm.AllowColMove = False
        Me.cboRm.AutoCompletion = True
        Me.cboRm.AutoDropDown = True
        Me.cboRm.Caption = ""
        Me.cboRm.CaptionHeight = 17
        Me.cboRm.CaptionStyle = Style1
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
        Me.cboRm.EvenRowStyle = Style2
        Me.cboRm.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRm.FooterStyle = Style3
        Me.cboRm.HeadingStyle = Style4
        Me.cboRm.HighLightRowStyle = Style5
        Me.cboRm.Images.Add(CType(resources.GetObject("cboRm.Images"), System.Drawing.Image))
        Me.cboRm.ItemHeight = 20
        Me.cboRm.Location = New System.Drawing.Point(144, 51)
        Me.cboRm.MatchEntryTimeout = CType(2000, Long)
        Me.cboRm.MaxDropDownItems = CType(10, Short)
        Me.cboRm.MaxLength = 32767
        Me.cboRm.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRm.Name = "cboRm"
        Me.cboRm.OddRowStyle = Style6
        Me.cboRm.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRm.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRm.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRm.SelectedStyle = Style7
        Me.cboRm.Size = New System.Drawing.Size(200, 24)
        Me.cboRm.Style = Style8
        Me.cboRm.TabIndex = 3
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
        Me.cboLane.CaptionStyle = Style9
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
        Me.cboLane.EvenRowStyle = Style10
        Me.cboLane.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLane.FooterStyle = Style11
        Me.cboLane.HeadingStyle = Style12
        Me.cboLane.HighLightRowStyle = Style13
        Me.cboLane.Images.Add(CType(resources.GetObject("cboLane.Images"), System.Drawing.Image))
        Me.cboLane.ItemHeight = 20
        Me.cboLane.Location = New System.Drawing.Point(144, 85)
        Me.cboLane.MatchEntryTimeout = CType(2000, Long)
        Me.cboLane.MaxDropDownItems = CType(10, Short)
        Me.cboLane.MaxLength = 32767
        Me.cboLane.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLane.Name = "cboLane"
        Me.cboLane.OddRowStyle = Style14
        Me.cboLane.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLane.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLane.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLane.SelectedStyle = Style15
        Me.cboLane.Size = New System.Drawing.Size(152, 24)
        Me.cboLane.Style = Style16
        Me.cboLane.TabIndex = 4
        Me.cboLane.PropBag = resources.GetString("cboLane.PropBag")
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 203)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(824, 221)
        Me.grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.grid.TabIndex = 34
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(566, 434)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 48)
        Me.cmdClose.TabIndex = 38
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSelect
        '
        Me.cmdSelect.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelect.Image = CType(resources.GetObject("cmdSelect.Image"), System.Drawing.Image)
        Me.cmdSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSelect.Location = New System.Drawing.Point(478, 434)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(80, 48)
        Me.cmdSelect.TabIndex = 37
        Me.cmdSelect.Text = "&Select"
        Me.cmdSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdReserved
        '
        Me.cmdReserved.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReserved.Image = CType(resources.GetObject("cmdReserved.Image"), System.Drawing.Image)
        Me.cmdReserved.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReserved.Location = New System.Drawing.Point(285, 434)
        Me.cmdReserved.Name = "cmdReserved"
        Me.cmdReserved.Size = New System.Drawing.Size(94, 48)
        Me.cmdReserved.TabIndex = 36
        Me.cmdReserved.Text = "&Reserve"
        Me.cmdReserved.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdMove
        '
        Me.cmdMove.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMove.Image = CType(resources.GetObject("cmdMove.Image"), System.Drawing.Image)
        Me.cmdMove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdMove.Location = New System.Drawing.Point(197, 434)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(80, 48)
        Me.cmdMove.TabIndex = 35
        Me.cmdMove.Text = "&Move"
        Me.cmdMove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Lane *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Cold Storage Room *"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(842, 40)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Cold Storage Map"
        '
        'lblRow
        '
        Me.lblRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow.Location = New System.Drawing.Point(144, 116)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(152, 24)
        Me.lblRow.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Row *"
        '
        'lblStack
        '
        Me.lblStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStack.Location = New System.Drawing.Point(144, 150)
        Me.lblStack.Name = "lblStack"
        Me.lblStack.Size = New System.Drawing.Size(152, 24)
        Me.lblStack.TabIndex = 117
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Next Stack *"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(141, 179)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(266, 16)
        Me.lblError.TabIndex = 118
        Me.lblError.Text = "Unable to stack more bins from this row"
        Me.lblError.Visible = False
        '
        'lblTripCode
        '
        Me.lblTripCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTripCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTripCode.Location = New System.Drawing.Point(454, 51)
        Me.lblTripCode.Name = "lblTripCode"
        Me.lblTripCode.Size = New System.Drawing.Size(128, 58)
        Me.lblTripCode.TabIndex = 119
        '
        'lblLot
        '
        Me.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.Location = New System.Drawing.Point(454, 116)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(128, 24)
        Me.lblLot.TabIndex = 120
        '
        'lblBin
        '
        Me.lblBin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBin.Location = New System.Drawing.Point(454, 150)
        Me.lblBin.Name = "lblBin"
        Me.lblBin.Size = New System.Drawing.Size(128, 24)
        Me.lblBin.TabIndex = 121
        '
        'lblSpecie
        '
        Me.lblSpecie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecie.Location = New System.Drawing.Point(694, 85)
        Me.lblSpecie.Name = "lblSpecie"
        Me.lblSpecie.Size = New System.Drawing.Size(136, 24)
        Me.lblSpecie.TabIndex = 122
        '
        'lblSize
        '
        Me.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(694, 116)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(136, 24)
        Me.lblSize.TabIndex = 123
        '
        'lblNW
        '
        Me.lblNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNW.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNW.Location = New System.Drawing.Point(694, 150)
        Me.lblNW.Name = "lblNW"
        Me.lblNW.Size = New System.Drawing.Size(136, 24)
        Me.lblNW.TabIndex = 124
        Me.lblNW.Text = "0"
        Me.lblNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(380, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Trip Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(382, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 16)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Lot ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(614, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 16)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "Fish Species"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(382, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 16)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Bin No."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(614, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 16)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "Net Weight"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(614, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 16)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "Fish Size"
        '
        'cmdClear
        '
        Me.cmdClear.Enabled = False
        Me.cmdClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClear.Location = New System.Drawing.Point(11, 430)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 48)
        Me.cmdClear.TabIndex = 131
        Me.cmdClear.TabStop = False
        Me.cmdClear.Text = "C&lear"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClear.Visible = False
        '
        'cmdBlock
        '
        Me.cmdBlock.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBlock.Image = CType(resources.GetObject("cmdBlock.Image"), System.Drawing.Image)
        Me.cmdBlock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBlock.Location = New System.Drawing.Point(385, 434)
        Me.cmdBlock.Name = "cmdBlock"
        Me.cmdBlock.Size = New System.Drawing.Size(87, 48)
        Me.cmdBlock.TabIndex = 132
        Me.cmdBlock.Text = "&Block"
        Me.cmdBlock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblRejectMsg
        '
        Me.lblRejectMsg.AutoSize = True
        Me.lblRejectMsg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRejectMsg.Location = New System.Drawing.Point(459, 120)
        Me.lblRejectMsg.Name = "lblRejectMsg"
        Me.lblRejectMsg.Size = New System.Drawing.Size(0, 16)
        Me.lblRejectMsg.TabIndex = 133
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
        Me.cboBin.ContentHeight = 18
        Me.cboBin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBin.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBin.EditorHeight = 18
        Me.cboBin.EvenRowStyle = Style18
        Me.cboBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.FooterStyle = Style19
        Me.cboBin.HeadingStyle = Style20
        Me.cboBin.HighLightRowStyle = Style21
        Me.cboBin.Images.Add(CType(resources.GetObject("cboBin.Images"), System.Drawing.Image))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(694, 51)
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
        Me.cboBin.Size = New System.Drawing.Size(138, 24)
        Me.cboBin.Style = Style24
        Me.cboBin.TabIndex = 134
        Me.cboBin.PropBag = resources.GetString("cboBin.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(614, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Search Bin"
        '
        'frmColdStorage_Map
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(842, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboBin)
        Me.Controls.Add(Me.lblRejectMsg)
        Me.Controls.Add(Me.cmdBlock)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblNW)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblSpecie)
        Me.Controls.Add(Me.lblBin)
        Me.Controls.Add(Me.lblLot)
        Me.Controls.Add(Me.lblTripCode)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblStack)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdReserved)
        Me.Controls.Add(Me.cmdMove)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboLane)
        Me.Controls.Add(Me.cboRm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmColdStorage_Map"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmColdStorage_Map"
        CType(Me.cboRm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmColdStorage_Map_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        'displayColdStorage()

        validateUser()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If cmdClose.Text = "&Close" Then
            cancelTrans = True
            Me.Close()
            Me.Dispose()
        Else
            cancelTrans = False
            displayColdStorageRow(cboRm.Text, cboLane.Text)

            sRm = ""
            sLn = ""
            sRw = ""
            sSk = ""

            cmdMove.Text = "&Move"
            cmdClose.Text = "&Close"
            cmdReserved.Enabled = True
            cmdClose.Enabled = True
        End If
    End Sub

    Public Sub displayColdStorage()
        With cboRm
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 175

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayColdStorageLane(ByVal room As String)
        With cboLane
            .DataSource = modModule.getColdStorageLane(room).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboRm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRm.TextChanged
        displayColdStorageLane(cboRm.Text)
    End Sub

    Public Sub displayColdStorageRow(ByVal room As String, ByVal lane As String)
        With grid
            .DataSource = modModule.getColdStorageRow(room, lane).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 40
            .Splits(0).DisplayColumns(1).Width = 122
            .Splits(0).DisplayColumns(2).Width = 122
            .Splits(0).DisplayColumns(3).Width = 122
            .Splits(0).DisplayColumns(4).Width = 122
            .Splits(0).DisplayColumns(5).Width = 122
            .Splits(0).DisplayColumns(6).Width = 122

            displayStackDetails()
            convertToBin()
        End With
    End Sub

    Private Sub cboLane_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLane.TextChanged
        displayColdStorageRow(cboRm.Text, cboLane.Text)
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        With grid
            If CStr(.Item(CInt(lblRow.Text) - 1, CInt(lblStack.Text))) = "" And _
            Not lblStack.Text = "0" Then
                room = cboRm.Text
                lane = cboLane.Text
                row = lblRow.Text '.Item(.Row, 0)
                stack = lblStack.Text '.Col

                Me.Close()
                Me.Dispose()
            Else
                MsgBox("Please make sure that the stack is not empty or has still some space", MsgBoxStyle.Exclamation, "Warning")
                grid.Focus()
            End If

        End With
    End Sub

    Private Sub grid_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grid.FetchRowStyle
        'If grid.Columns(1).CellValue(e.Row) = cboBin.Text Or grid.Columns(2).CellValue(e.Row) = cboBin.Text Or _
        '    grid.Columns(3).CellValue(e.Row) = cboBin.Text Or grid.Columns(4).CellValue(e.Row) = cboBin.Text Or _
        '    grid.Columns(5).CellValue(e.Row) = cboBin.Text Or grid.Columns(6).CellValue(e.Row) = cboBin.Text Then

        '    e.CellStyle.ForeColor = System.Drawing.Color.White
        '    e.CellStyle.BackColor = System.Drawing.Color.Red
        'Else
        '    e.CellStyle.ForeColor = System.Drawing.Color.Black
        '    e.CellStyle.BackColor = System.Drawing.Color.White
        'End If
    
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        displayStackDetails()
        displayBinDetails(grid.Item(grid.Row, grid.Col))

        If grid.RowCount > 0 Then
            If CStr(grid.Item(grid.Row, grid.Col)).StartsWith("RESERVE") = True Then
                cmdReserved.Text = "Unreserved"
            Else
                cmdReserved.Text = "Reserve"
            End If

            If CStr(grid.Item(grid.Row, grid.Col)).StartsWith("XXXXX") = True Then
                cmdBlock.Text = "Unblocked"
            Else
                cmdBlock.Text = "Block"
            End If
        End If
    End Sub

    Public Sub displayStackDetails()
        With grid
            If .RowCount > 0 Then
                lblRow.Text = .Item(.Row, 0)
                lblStack.Text = getNextAvailableBinHeight(cboRm.Text, cboLane.Text, lblRow.Text)

                'If lblStack.Text = "1" And Not .Item(CInt(lblRow.Text), 1) = "" Then
                '    lblStack.Text = "2"
                'Else
                '    lblStack.Text = getNextAvailableBinHeight(cboRm.Text, cboLane.Text, lblRow.Text)
                'End If

                'If lblStack.Text = "0" Then
                If .Col = 0 Then
                    If .Item(.Row, 1) = "RESERVED" Then lblStack.Text = "0"
                Else
                    If .Item(.Row, .Col) = "RESERVED" Then lblStack.Text = "0"
                End If

                'End If
            End If
        End With
    End Sub

    Public Sub convertToBin()
        With grid
            Dim row As Integer
            Dim col As Integer
            While row < .RowCount
                col = 1
                While col <= 6
                    If .Item(row, col) = "RESERVED" Then
                        .Item(row, col) = "RESERVED"
                    ElseIf .Item(row, col) = "XXXXX" Then
                        .Item(row, col) = "XXXXX"
                    Else
                        .Item(row, col) = getFishBinByDepositCode(.Item(row, col))
                    End If

                    col += 1
                End While

                row += 1
            End While
        End With
    End Sub

    Private Sub lblStack_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStack.TextChanged
        If lblStack.Text.Trim = "0" Then
            lblError.Visible = True
        Else
            lblError.Visible = False
        End If
    End Sub

    Private Sub cmdReserved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReserved.Click
        With grid
            If .Item(.Row, .Col) = "" Then
                Dim reply As String = MsgBox("Are you sure you want to reserve this location?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    updateColdStorageStack(cboRm.Text, cboLane.Text, lblRow.Text, .Col, _
                        "RESERVED")
                    displayColdStorageRow(cboRm.Text, cboLane.Text)
                    MsgBox("You have successfully reserved the location", MsgBoxStyle.Information, "Information")
                    cboRm.SelectAll()
                    cboRm.Focus()
                End If
            ElseIf .Item(.Row, .Col) = "RESERVED" Then
                Dim reply As String = MsgBox("Are you sure you want to unreserve this location?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    updateColdStorageStack(cboRm.Text, cboLane.Text, lblRow.Text, .Col, _
                        "")
                    displayColdStorageRow(cboRm.Text, cboLane.Text)
                    MsgBox("You have successfully unreserved the location", MsgBoxStyle.Information, "Information")
                    cboRm.SelectAll()
                    cboRm.Focus()
                End If
            Else
                MsgBox("You cannot reserved a location which is not empty", MsgBoxStyle.Critical, "Warning")
                grid.Focus()
            End If
        End With
    End Sub

    Private Sub cmdMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMove.Click
        With grid
            If cmdMove.Text = "&Move" Then

                bin = .Item(.Row, .Col)

                Dim reply As String = MsgBox("Are you sure you want to move this bin " & bin & " from its current location?" & Chr(13) & _
                    "Room: " & cboRm.Text & Chr(13) & _
                    "Lane: " & cboLane.Text & Chr(13) & _
                    "Row: " & .Item(.Row, 0) & Chr(13) & _
                    "Stack: " & .Col, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    sRm = cboRm.Text
                    sLn = cboLane.Text
                    sRw = .Item(.Row, 0)
                    sSk = .Col

                    displayColdStorageRow(cboRm.Text, cboLane.Text)

                    cmdMove.Text = "&Save"
                    cmdClose.Text = "&Cancel"
                    cmdReserved.Enabled = False
                    cmdBlock.Enabled = False
                Else
                    cmdMove.Text = "&Move"
                    cmdClose.Text = "&Close"
                    cmdReserved.Enabled = True
                    cmdBlock.Enabled = True
                End If

            Else
                If Not lblStack.Text = "0" Then
                    Dim reply As String = MsgBox("Are you sure you want to save this transaction?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    If reply = vbYes Then
                        'MsgBox(sRm & Chr(13) & _
                        '    sLn & Chr(13) & _
                        '    sRw & Chr(13) & _
                        '    sSk)

                        updateColdStorageStack(sRm, sLn, sRw, sSk, "")
                        'updateFishBinStack(sRm, sLn, sRw)

                        updateColdStorageStack(cboRm.Text, cboLane.Text, lblRow.Text, lblStack.Text, getDepositCode(bin))

                        updateBinLocation(getDepositCode(bin), cboRm.Text, cboLane.Text, lblRow.Text, lblStack.Text)
                        'MsgBox(bin)

                        Dim stack As Integer
                        While stack < 6
                            checkForAutoStack(sRm, sLn, sRw) 'lblRow.Text)

                            stack += 1
                        End While

                        displayColdStorageRow(cboRm.Text, cboLane.Text)
                        MsgBox("You have successfully moved a bin from it's new destination", MsgBoxStyle.Information, "Information")
                        cmdMove.Text = "&Move"
                        cmdClose.Text = "&Close"
                        validateUser()
                        cboRm.SelectAll()
                        cboRm.Focus()
                    End If
                Else
                    MsgBox("You can stack a bin which is exceeded on its maximum allowable stacking pile", MsgBoxStyle.Exclamation, "Warning")
                    grid.Focus()
                End If
            End If
        End With
    End Sub

    Public Function isStackReserved(ByVal row As Integer) As Boolean
        Dim col As Integer = 1
        With grid
            While col <= 6
                If .Item(row, col) = "RESERVED" Then
                    col += 1
                Else
                    Return False
                End If
            End While
        End With

        Return True
    End Function

    Public Sub displayBinDetails(ByVal depositCode As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_depositCodeDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@depositCode"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = depositCode

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblTripCode.Text = dr.GetString(0)
                    lblLot.Text = dr.GetString(1)

                    If dr.GetString(1) = "" Then lblLot.Text = "Fish Reject"

                    lblBin.Text = dr.GetString(2)
                    lblSpecie.Text = dr.GetString(3)
                    lblSize.Text = dr.GetString(4)
                    lblNW.Text = Format(dr.GetDouble(5), "###,##0.#0")
                Else
                    lblTripCode.Text = ""
                    lblLot.Text = ""
                    lblBin.Text = ""
                    lblSpecie.Text = ""
                    lblSize.Text = ""
                    lblNW.Text = "0"
                    lblRejectMsg.Text = ""
                End If
            Else
                lblTripCode.Text = ""
                lblLot.Text = ""
                lblBin.Text = ""
                lblSpecie.Text = ""
                lblSize.Text = ""
                lblNW.Text = "0"
                lblRejectMsg.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        With grid
            Dim reply As String
            reply = MsgBox("Are you sure you want to clear this location?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then
                'MsgBox(cboRm.Text & " " & cboLane.Text & " " & .Item(.Row, 0) & " " & .Col)
                updateColdStorageStack(cboRm.Text, cboLane.Text, .Item(.Row, 0), .Col, "")

                'updateBinLocation(getDepositCode(bin), cboRm.Text, cboLane.Text, lblRow.Text, lblStack.Text)
                'MsgBox(bin)

                Dim stack As Integer
                While stack < 6
                    checkForAutoStack(sRm, sLn, sRw) 'lblRow.Text)

                    stack += 1
                End While

                displayColdStorageRow(cboRm.Text, cboLane.Text)

                MsgBox("You have successfully free up the location", MsgBoxStyle.Information, "Information")
                cboRm.SelectAll()
                cboRm.Focus()
            End If
        End With
    End Sub

    Private Sub cmdBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBlock.Click
        With grid
            If .Item(.Row, .Col) = "" Then
                Dim reply As String = MsgBox("Are you sure you want to block this location?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    updateColdStorageStack(cboRm.Text, cboLane.Text, lblRow.Text, .Col, _
                        "XXXXX")
                    displayColdStorageRow(cboRm.Text, cboLane.Text)
                    MsgBox("You have successfully blocked the location", MsgBoxStyle.Information, "Information")
                    cboRm.SelectAll()
                    cboRm.Focus()
                End If
            ElseIf .Item(.Row, .Col) = "XXXXX" Then
                Dim reply As String = MsgBox("Are you sure you want to unblock this location?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    updateColdStorageStack(cboRm.Text, cboLane.Text, lblRow.Text, .Col, _
                        "")
                    displayColdStorageRow(cboRm.Text, cboLane.Text)
                    MsgBox("You have successfully unblocked the location", MsgBoxStyle.Information, "Information")
                    cboRm.SelectAll()
                    cboRm.Focus()
                End If
            Else
                MsgBox("You cannot block a location which is not empty", MsgBoxStyle.Critical, "Warning")
                grid.Focus()
            End If
        End With

    End Sub

    Public Sub validateUser()
        Select Case getPositionUser()
            Case "CS Mgr", "System Administrator"
                cmdReserved.Enabled = True
                cmdBlock.Enabled = True
            Case Else
                cmdReserved.Enabled = False
                cmdBlock.Enabled = False
                cmdBlock.Enabled = False
        End Select
    End Sub

    Private Sub lblLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLot.Click

    End Sub

    Private Sub lblLot_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLot.TextChanged
     
    End Sub

    Public Sub displayBinLocations(ByVal bin As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_binCurrentLocations"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@bin"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = bin

            cmd.Parameters.Add(p1)

            Dim drCode As SqlClient.SqlDataReader
            drCode = cmd.ExecuteReader

            If drCode.Read Then
                If Not drCode(0) Is DBNull.Value Then
                    cboRm.Text = drCode.GetString(0)
                    cboLane.Text = drCode.GetString(1)
                    grid.Row = drCode.GetString(2) - 1
                Else
                    cboRm.Text = ""
                    cboLane.Text = ""
                    lblRow.Text = ""
                    lblStack.Text = ""
                End If
            Else
                cboRm.Text = ""
                cboLane.Text = ""
                lblRow.Text = ""
                lblStack.Text = ""
            End If

            drCode.Close()
            c.Close()

        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboBin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBin.KeyDown
        If e.KeyCode = Keys.Enter Then
            displayBinLocations(cboBin.Text)
            displayBinDetails(cboBin.Text)
            'grid.FetchRowStyles = True
        End If
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        grid.Row = 0
    End Sub
End Class
