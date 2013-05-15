Public Class frmSpoilage
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cboSection As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboFishSpecie As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboDefects As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboFishSize As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotalWeight As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuSection As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFishSpecie As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLot As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDefect As System.Windows.Forms.MenuItem
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdAClose As System.Windows.Forms.Button
    Friend WithEvents cmdASave As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpoilage))
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
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
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style21 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style22 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style23 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style24 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style25 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style26 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style27 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style28 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style29 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style30 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style31 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style32 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style33 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style34 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style35 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style36 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style37 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style38 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style39 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style40 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style41 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style42 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style43 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style44 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style45 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style46 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style47 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style48 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cboSection = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboFishSpecie = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboDefects = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboFishSize = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalWeight = New System.Windows.Forms.Label()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuSection = New System.Windows.Forms.MenuItem()
        Me.mnuFishSpecie = New System.Windows.Forms.MenuItem()
        Me.mnuLot = New System.Windows.Forms.MenuItem()
        Me.mnuDefect = New System.Windows.Forms.MenuItem()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdAClose = New System.Windows.Forms.Button()
        Me.cmdASave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFishSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDefects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFishSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(88, 50)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(136, 23)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboShift.DataMode = C1.Win.C1List.DataModeEnum.AddItem
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
        Me.cboShift.Location = New System.Drawing.Point(88, 82)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(20, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.OddRowStyle = Style6
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.SelectedStyle = Style7
        Me.cboShift.Size = New System.Drawing.Size(136, 24)
        Me.cboShift.Style = Style8
        Me.cboShift.TabIndex = 1
        Me.cboShift.PropBag = resources.GetString("cboShift.PropBag")
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(353, 50)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(208, 24)
        Me.lblCode.TabIndex = 21
        Me.lblCode.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Prodn Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Reject Ctrl#"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Trip Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Shift"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(727, 40)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Fish Process Reject"
        '
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
        Me.cboLot.Caption = ""
        Me.cboLot.CaptionHeight = 17
        Me.cboLot.CaptionStyle = Style9
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
        Me.cboLot.EvenRowStyle = Style10
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.FooterStyle = Style11
        Me.cboLot.HeadingStyle = Style12
        Me.cboLot.HighLightRowStyle = Style13
        Me.cboLot.Images.Add(CType(resources.GetObject("cboLot.Images"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(88, 112)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style14
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.SelectedStyle = Style15
        Me.cboLot.Size = New System.Drawing.Size(136, 24)
        Me.cboLot.Style = Style16
        Me.cboLot.TabIndex = 27
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(6, 146)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(715, 256)
        Me.grid.TabIndex = 28
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cboSection
        '
        Me.cboSection.AllowColMove = False
        Me.cboSection.AllowColSelect = True
        Me.cboSection.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSection.AlternatingRows = False
        Me.cboSection.CaptionHeight = 17
        Me.cboSection.CaptionStyle = Style17
        Me.cboSection.ColumnCaptionHeight = 17
        Me.cboSection.ColumnFooterHeight = 17
        Me.cboSection.EvenRowStyle = Style18
        Me.cboSection.FetchRowStyles = False
        Me.cboSection.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FooterStyle = Style19
        Me.cboSection.HeadingStyle = Style20
        Me.cboSection.HighLightRowStyle = Style21
        Me.cboSection.Images.Add(CType(resources.GetObject("cboSection.Images"), System.Drawing.Image))
        Me.cboSection.Location = New System.Drawing.Point(8, 186)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.OddRowStyle = Style22
        Me.cboSection.RecordSelectorStyle = Style23
        Me.cboSection.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSection.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSection.RowHeight = 20
        Me.cboSection.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSection.ScrollTips = False
        Me.cboSection.Size = New System.Drawing.Size(160, 208)
        Me.cboSection.Style = Style24
        Me.cboSection.TabIndex = 39
        Me.cboSection.Text = "C1TrueDBDropdown1"
        Me.cboSection.Visible = False
        Me.cboSection.PropBag = resources.GetString("cboSection.PropBag")
        '
        'cboFishSpecie
        '
        Me.cboFishSpecie.AllowColMove = False
        Me.cboFishSpecie.AllowColSelect = True
        Me.cboFishSpecie.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboFishSpecie.AlternatingRows = False
        Me.cboFishSpecie.CaptionHeight = 17
        Me.cboFishSpecie.CaptionStyle = Style25
        Me.cboFishSpecie.ColumnCaptionHeight = 17
        Me.cboFishSpecie.ColumnFooterHeight = 17
        Me.cboFishSpecie.EvenRowStyle = Style26
        Me.cboFishSpecie.FetchRowStyles = False
        Me.cboFishSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSpecie.FooterStyle = Style27
        Me.cboFishSpecie.HeadingStyle = Style28
        Me.cboFishSpecie.HighLightRowStyle = Style29
        Me.cboFishSpecie.Images.Add(CType(resources.GetObject("cboFishSpecie.Images"), System.Drawing.Image))
        Me.cboFishSpecie.Location = New System.Drawing.Point(160, 186)
        Me.cboFishSpecie.Name = "cboFishSpecie"
        Me.cboFishSpecie.OddRowStyle = Style30
        Me.cboFishSpecie.RecordSelectorStyle = Style31
        Me.cboFishSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFishSpecie.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboFishSpecie.RowHeight = 20
        Me.cboFishSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFishSpecie.ScrollTips = False
        Me.cboFishSpecie.Size = New System.Drawing.Size(152, 208)
        Me.cboFishSpecie.Style = Style32
        Me.cboFishSpecie.TabIndex = 40
        Me.cboFishSpecie.Text = "C1TrueDBDropdown1"
        Me.cboFishSpecie.Visible = False
        Me.cboFishSpecie.PropBag = resources.GetString("cboFishSpecie.PropBag")
        '
        'cboDefects
        '
        Me.cboDefects.AllowColMove = False
        Me.cboDefects.AllowColSelect = True
        Me.cboDefects.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboDefects.AlternatingRows = False
        Me.cboDefects.CaptionHeight = 17
        Me.cboDefects.CaptionStyle = Style33
        Me.cboDefects.ColumnCaptionHeight = 17
        Me.cboDefects.ColumnFooterHeight = 17
        Me.cboDefects.EvenRowStyle = Style34
        Me.cboDefects.FetchRowStyles = False
        Me.cboDefects.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDefects.FooterStyle = Style35
        Me.cboDefects.HeadingStyle = Style36
        Me.cboDefects.HighLightRowStyle = Style37
        Me.cboDefects.Images.Add(CType(resources.GetObject("cboDefects.Images"), System.Drawing.Image))
        Me.cboDefects.Location = New System.Drawing.Point(448, 186)
        Me.cboDefects.Name = "cboDefects"
        Me.cboDefects.OddRowStyle = Style38
        Me.cboDefects.RecordSelectorStyle = Style39
        Me.cboDefects.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDefects.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboDefects.RowHeight = 20
        Me.cboDefects.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDefects.ScrollTips = False
        Me.cboDefects.Size = New System.Drawing.Size(160, 208)
        Me.cboDefects.Style = Style40
        Me.cboDefects.TabIndex = 41
        Me.cboDefects.Text = "C1TrueDBDropdown1"
        Me.cboDefects.Visible = False
        Me.cboDefects.PropBag = resources.GetString("cboDefects.PropBag")
        '
        'cboFishSize
        '
        Me.cboFishSize.AllowColMove = False
        Me.cboFishSize.AllowColSelect = True
        Me.cboFishSize.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboFishSize.AlternatingRows = False
        Me.cboFishSize.CaptionHeight = 17
        Me.cboFishSize.CaptionStyle = Style41
        Me.cboFishSize.ColumnCaptionHeight = 17
        Me.cboFishSize.ColumnFooterHeight = 17
        Me.cboFishSize.EvenRowStyle = Style42
        Me.cboFishSize.FetchRowStyles = False
        Me.cboFishSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSize.FooterStyle = Style43
        Me.cboFishSize.HeadingStyle = Style44
        Me.cboFishSize.HighLightRowStyle = Style45
        Me.cboFishSize.Images.Add(CType(resources.GetObject("cboFishSize.Images"), System.Drawing.Image))
        Me.cboFishSize.Location = New System.Drawing.Point(304, 186)
        Me.cboFishSize.Name = "cboFishSize"
        Me.cboFishSize.OddRowStyle = Style46
        Me.cboFishSize.RecordSelectorStyle = Style47
        Me.cboFishSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFishSize.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboFishSize.RowHeight = 20
        Me.cboFishSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFishSize.ScrollTips = False
        Me.cboFishSize.Size = New System.Drawing.Size(101, 208)
        Me.cboFishSize.Style = Style48
        Me.cboFishSize.TabIndex = 42
        Me.cboFishSize.Text = "C1TrueDBDropdown1"
        Me.cboFishSize.Visible = False
        Me.cboFishSize.PropBag = resources.GetString("cboFishSize.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(499, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Total Weight"
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalWeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWeight.Location = New System.Drawing.Point(586, 112)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(112, 24)
        Me.lblTotalWeight.TabIndex = 43
        Me.lblTotalWeight.Text = "0"
        Me.lblTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSection, Me.mnuFishSpecie, Me.mnuLot, Me.mnuDefect})
        '
        'mnuSection
        '
        Me.mnuSection.Index = 0
        Me.mnuSection.Text = "Production &Section"
        '
        'mnuFishSpecie
        '
        Me.mnuFishSpecie.Enabled = False
        Me.mnuFishSpecie.Index = 1
        Me.mnuFishSpecie.Text = "&Fish Specie"
        Me.mnuFishSpecie.Visible = False
        '
        'mnuLot
        '
        Me.mnuLot.Enabled = False
        Me.mnuLot.Index = 2
        Me.mnuLot.Text = "Fish &Lot"
        Me.mnuLot.Visible = False
        '
        'mnuDefect
        '
        Me.mnuDefect.Index = 3
        Me.mnuDefect.Text = "Fish &Reject"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(166, 440)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 45
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(246, 440)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 46
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(326, 440)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 47
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(406, 440)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 48
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(486, 440)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 49
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Label6)
        Me.grp.Controls.Add(Me.Label11)
        Me.grp.Controls.Add(Me.cmdAClose)
        Me.grp.Controls.Add(Me.cmdASave)
        Me.grp.Controls.Add(Me.txtPassword)
        Me.grp.Controls.Add(Me.txtUsername)
        Me.grp.Enabled = False
        Me.grp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(155, 352)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(416, 136)
        Me.grp.TabIndex = 70
        Me.grp.TabStop = False
        Me.grp.Text = "User Authentication"
        Me.grp.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Username"
        '
        'cmdAClose
        '
        Me.cmdAClose.Image = CType(resources.GetObject("cmdAClose.Image"), System.Drawing.Image)
        Me.cmdAClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAClose.Location = New System.Drawing.Point(211, 88)
        Me.cmdAClose.Name = "cmdAClose"
        Me.cmdAClose.Size = New System.Drawing.Size(75, 40)
        Me.cmdAClose.TabIndex = 3
        Me.cmdAClose.Text = "&Cancel"
        Me.cmdAClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdASave
        '
        Me.cmdASave.Image = CType(resources.GetObject("cmdASave.Image"), System.Drawing.Image)
        Me.cmdASave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdASave.Location = New System.Drawing.Point(131, 88)
        Me.cmdASave.Name = "cmdASave"
        Me.cmdASave.Size = New System.Drawing.Size(75, 40)
        Me.cmdASave.TabIndex = 2
        Me.cmdASave.Text = "&Override"
        Me.cmdASave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(148, 56)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(216, 23)
        Me.txtPassword.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(148, 24)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(216, 23)
        Me.txtUsername.TabIndex = 0
        '
        'frmSpoilage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(727, 495)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotalWeight)
        Me.Controls.Add(Me.cboFishSize)
        Me.Controls.Add(Me.cboDefects)
        Me.Controls.Add(Me.cboFishSpecie)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtDate)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSpoilage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSpoilage"
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFishSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDefects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFishSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmSpoilage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()

        initializeShift()
        displayListsofFishRejects()
        'displayBatchlot()
        displayReject()
    End Sub

    Public Sub displayListsofFishRejects()
        With grid
            .DataSource = modModule.getListsOfFishRejects().Tables(0)
            .Splits(0).DisplayColumns(0).DropDownList = True
            .Columns(0).DropDown = cboSection
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Columns(1).DropDown = cboFishSpecie
            .Splits(0).DisplayColumns(2).DropDownList = True
            .Columns(2).DropDown = cboFishSize
            .Splits(0).DisplayColumns(3).DropDownList = True
            .Columns(3).DropDown = cboDefects
            .Splits(0).DisplayColumns(4).DropDownList = True

            displaySection()
            displayDefects()
            displayFishSpecie(cboLot.Text)
            displayFishSize(cboLot.Text, "")

            .Splits(0).DisplayColumns(0).Width = 160
            .Splits(0).DisplayColumns(1).Width = 150
            .Splits(0).DisplayColumns(3).Width = 160

            '.Columns(2).NumberFormat = "###,##0.#0"
            .Columns(4).NumberFormat = "###,##0.#0"

            '.Splits(0).DisplayColumns(1).Locked = True
            '.Splits(0).DisplayColumns(2).Locked = True
            '.Splits(0).DisplayColumns(3).Locked = True
            '.Splits(0).DisplayColumns(4).Locked = True
            '.Splits(0).DisplayColumns(5).Locked = True
        End With
    End Sub

    Public Sub initializeShift()
        With cboShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 113
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayBatchlot()
        With cboLot
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 113
        End With
    End Sub

    Public Sub displaySection()
        With cboSection
            .DefColWidth = 138
            .DataSource = modModule.getSection().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 113
        End With
    End Sub

    Public Sub displayDefects()
        With cboDefects
            .DefColWidth = 138
            .DataSource = modModule.getDefects().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 113
        End With
    End Sub

    Public Sub displayFishSpecie(ByVal lot As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_display_FishSpeciePerLot"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@lot"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = lot

            cmd.Parameters.Add(p1)

            Dim da As New SqlClient.SqlDataAdapter()
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            cboFishSpecie.DefColWidth = 128
            cboFishSpecie.DataSource = ds.Tables(0)

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displayFishSize(ByVal lot As String, ByVal specie As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_display_FishSpecieSizesPerLot"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@lot"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = lot

            Dim p2 As New SqlClient.SqlParameter()
            p2.ParameterName = "@specie"
            p2.SqlDbType = SqlDbType.VarChar
            p2.Direction = ParameterDirection.Input
            p2.Value = specie

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)

            Dim da As New SqlClient.SqlDataAdapter()
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            cboFishSize.DefColWidth = 80
            cboFishSize.DataSource = ds.Tables(0)

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displayListsofFishRejects()

        displayReject()
    End Sub

    Public Sub displayReject()
        displayRejectCode(txtDate.Text, cboShift.Text, cboLot.Text)

        displayRejectDetails(lblCode.Text)
    End Sub

    Private Sub cboFishSpecie_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFishSpecie.RowChange
        displayFishSize(cboLot.Text, cboFishSpecie.Columns(0).Value)
    End Sub

    Public Sub computeTotalWeight()
        Dim ctr As Integer
        Dim sum As Double
        With grid
            While ctr < .RowCount
                If Not .Item(ctr, 4) Is DBNull.Value Then
                    sum += .Item(ctr, 4)
                End If

                ctr += 1
            End While
        End With

        lblTotalWeight.Text = Format(sum, "###,###,##0.#0")
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        computeTotalWeight()
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        txtDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        'displayBatchlot()
        'displayListsofFishRejects()
        displayFishLotWithdrawn(txtDate.Value, cboShift.Text)
        displayReject()

        computeTotalWeight()
    End Sub

    Public Function isFishBinFoundDuplicate() As Boolean
        Dim outer As Integer
        Dim inner As Integer
        With grid
            While outer < .RowCount
                inner = outer + 1
                While inner < .RowCount
                    If isFishBinValid() Then
                        If .Item(outer, 0) = .Item(inner, 0) And _
                        .Item(outer, 1) = .Item(inner, 1) And _
                        .Item(outer, 2) = .Item(inner, 2) And _
                        .Item(outer, 3) = .Item(inner, 3) Then
                            Return True
                        End If
                    Else
                        Return True
                    End If

                    inner += 1
                End While

                outer += 1
            End While
        End With

        Return False
    End Function

    Public Function isFishBinValid() As Boolean
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or _
                .Item(ctr, 2) Is DBNull.Value Or .Item(ctr, 3) Is DBNull.Value Or _
                .Item(ctr, 4) Is DBNull.Value Then
                    Return False
                End If

                ctr += 1
            End While
        End With

        Return True
    End Function

    Public Sub saveNewFishReject(ByVal dateTime As String, ByVal shift As String, _
    ByVal lot As String, ByVal noOfDefects As Integer)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_addNew_FishSpoilage"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishRejectCounter()

            Dim p2 As New SqlClient.SqlParameter()
            p2.ParameterName = "@fsCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            If shift.StartsWith("Day") Then
                lblCode.Text = Format(CDate(dateTime), "ddMMyy") & "D" & lot & Format(noOfDefects, "0#") & Format(getFishRejectCounter, "0#####")
            Else
                lblCode.Text = Format(CDate(dateTime), "ddMMyy") & "N" & lot & Format(noOfDefects, "0#") & Format(getFishRejectCounter, "0#####")
            End If
            p2.Value = lblCode.Text

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@prodnDate"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.DateTime
            p3.Value = Format(CDate(dateTime), getTimeFormat())

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@prodnShift"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = shift

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@lot#"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = lot

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@status"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = "*"

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@printStatus"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.Char
            p7.Value = "N"

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@spoilageConversion"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.Float
            p8.Value = 0

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

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)

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

    Public Sub displayRejectDetails(ByVal code As String)
        With grid
            .DataSource = modModule.getRejectDetails(code).Tables(0)
            .Splits(0).DisplayColumns(0).DropDownList = True
            .Columns(0).DropDown = cboSection
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Columns(1).DropDown = cboFishSpecie
            .Splits(0).DisplayColumns(2).DropDownList = True
            .Columns(2).DropDown = cboFishSize
            .Splits(0).DisplayColumns(3).DropDownList = True
            .Columns(3).DropDown = cboDefects
            .Splits(0).DisplayColumns(4).DropDownList = True

            displaySection()
            displayDefects()
            displayFishSpecie(cboLot.Text)
            displayFishSize(cboLot.Text, "")

            .Splits(0).DisplayColumns(0).Width = 160
            .Splits(0).DisplayColumns(1).Width = 150
            .Splits(0).DisplayColumns(3).Width = 160

            '.Columns(2).NumberFormat = "###,##0.#0"
            .Columns(4).NumberFormat = "###,##0.#0"

            computeTotalWeight()
        End With
    End Sub

    Public Sub displayRejectCode(ByVal prodnDate As String, ByVal shift As String, ByVal lot As String)
        lblCode.Text = getRejectCode(prodnDate, shift, lot)
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        displayFishLotWithdrawn(txtDate.Value, cboShift.Text)
        displayReject()
    End Sub

    Private Sub txtDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.TextChanged

    End Sub

    Private Sub mnuSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSection.Click
        Dim f As New frmSection()
        f.ShowDialog(Me)

        displaySection()
        grid.Focus()
    End Sub

    Private Sub mnuFishSpecie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFishSpecie.Click
        Dim f As New frmSpecie()
        f.ShowDialog(Me)

        Me.displayFishSpecie(cboLot.Text)
        grid.Focus()
    End Sub

    Private Sub mnuLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLot.Click
        Dim f As New frmBatchlot()
        f.ShowDialog(Me)

        displayBatchlot()
        grid.Focus()
    End Sub

    Private Sub mnuDefect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDefect.Click
        Dim f As New frmDefects()
        f.ShowDialog(Me)

        Me.displayReject()
        grid.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        grid.Refresh()
        computeTotalWeight()

        Dim reply As String
        If Not cboShift.Text.Trim = "" And Not cboLot.Text.Trim = "" And grid.RowCount > 0 And _
        Not isFishBinFoundDuplicate() And isFishBinValid() Then
            If lblCode.Text.Trim = "" Then
                If Not validateFishReject(txtDate.Text, cboShift.Text, cboLot.Text) Then
                    reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        saveNewFishReject(txtDate.Text, cboShift.Text, cboLot.Text, grid.RowCount)

                        Dim ctr As Integer
                        With grid
                            While ctr < .RowCount
                                saveNewFishRejectDetails(lblCode.Text, .Item(ctr, 0), _
                                    .Item(ctr, 3), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 4), _
                                    "kg", 0, 0, getServerDateTime)

                                ctr += 1
                            End While
                        End With

                        MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                        addNewRecord()
                        txtDate.Focus()
                    Else
                        txtDate.Focus()
                        Exit Sub
                    End If
                Else
                    MsgBox("Fish Reject already exists in the system, please update the existing record", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtDate.Focus()
                End If
            Else
                reply = MsgBox("Fish Reject Control No. " & lblCode.Text & " already stored in the database" & Chr(13) & _
                    "To update, please click YES to proceed but please make sure you have properly coordinated this matter to your supervisor", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    showValidationMenu(True)
                Else
                    txtDate.Focus()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Kindly fill out important field(s)." & Chr(13) & _
                "Please check fish process rejects for it must be properly identified in the lists", MsgBoxStyle.Critical, "Result: Found missing value.")
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        txtDate.SelectAll()
        txtDate.Focus()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Fish Rejects"
        frmSearch.searchType = 1
        f.displayAllFishRejects()
        f.ShowDialog(Me)

        If Not frmSearch.cancel Then
            With f.grid
                txtDate.Value = .Item(.Row, 1)
                cboShift.Text = .Item(.Row, 2)
                cboLot.Text = .Item(.Row, 3)
            End With
        End If

        txtDate.SelectAll()
        txtDate.Focus()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub showValidationMenu(ByVal showMe As Boolean)
        txtUsername.Text = ""
        txtPassword.Text = ""
        Select Case showMe
            Case True
                grp.Enabled = True
                grp.Visible = True
            Case False
                grp.Enabled = False
                grp.Visible = False
        End Select

        txtUsername.SelectAll()
        txtUsername.Focus()
    End Sub

    Private Sub cmdAClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAClose.Click
        showValidationMenu(False)
    End Sub

    Private Sub cmdASave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdASave.Click
        If validateOverrideAccount(txtUsername.Text, txtPassword.Text) Then
            Dim reply As String
            reply = MsgBox("Are you sure you want to update the following information?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then

                updateFishReject(lblCode.Text, txtDate.Text, cboShift.Text, cboLot.Text)

                Dim ctr As Integer
                With grid
                    deleteFS(lblCode.Text)

                    ctr = 0
                    While ctr < .RowCount
                        saveNewFishRejectDetails(lblCode.Text, .Item(ctr, 0), _
                            .Item(ctr, 3), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 4), _
                            "lbs", 0, 0, getServerDateTime)

                        ctr += 1
                    End While
                End With

                MsgBox("You have successfully modify the existing record", MsgBoxStyle.Information, "Information")
                Me.showValidationMenu(False)
                addNewRecord()
                cmdNew.Focus()
            End If
        Else
            MsgBox("You have an invalid account.  For assistance, please call your supervisor", MsgBoxStyle.Exclamation, "Access denied")
            cmdAClose.Focus()
        End If
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        displayFishLotWithdrawn(txtDate.Value, cboShift.Text)
        displayReject()
    End Sub

    Public Sub displayFishLotWithdrawn(ByVal prodnDate As String, ByVal shift As String)
        With cboLot
            .DataSource = modModule.getBatchlotsWithdrawn(prodnDate, shift).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130

            If .ListCount > 0 Then
                .SelectedIndex = 0
            Else
                .Text = ""
            End If
        End With
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim f As New frmPrintFishSpoilages
        f.txtProdnDate.Value = txtDate.Value
        f.initializeShift()
        f.cboShift.Text = cboShift.Text
        f.ShowDialog(Me)
    End Sub

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid.Focus()
        End If
    End Sub
End Class
