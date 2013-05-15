Public Class frmFishLot
    Inherits System.Windows.Forms.Form

    Dim currRecord, prevRecord As Integer
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
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
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboSpecie As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboSet As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboSize As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents lblRow As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFishLot))
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
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblLot = New C1.Win.C1List.C1Combo()
        Me.cboSpecie = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboSet = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboSize = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblID = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cboVessel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
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
        Me.cboVessel.Location = New System.Drawing.Point(104, 56)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(10, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.OddRowStyle = Style6
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.SelectedStyle = Style7
        Me.cboVessel.Size = New System.Drawing.Size(376, 24)
        Me.cboVessel.Style = Style8
        Me.cboVessel.TabIndex = 1
        Me.cboVessel.PropBag = resources.GetString("cboVessel.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Fishing Vessel*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Trip Code*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Lot Details"
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
        Me.grid.Location = New System.Drawing.Point(8, 152)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(880, 224)
        Me.grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.grid.TabIndex = 3
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(776, 64)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 8
        Me.cmdEdit.TabStop = False
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEdit.Visible = False
        '
        'cmd
        '
        Me.cmd.Enabled = False
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(696, 64)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 7
        Me.cmd.TabStop = False
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(612, 64)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(898, 40)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Fish Lot Id"
        '
        'lblLot
        '
        Me.lblLot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lblLot.AllowColMove = False
        Me.lblLot.AutoCompletion = True
        Me.lblLot.AutoDropDown = True
        Me.lblLot.Caption = ""
        Me.lblLot.CaptionHeight = 17
        Me.lblLot.CaptionStyle = Style9
        Me.lblLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lblLot.ColumnCaptionHeight = 17
        Me.lblLot.ColumnFooterHeight = 17
        Me.lblLot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.lblLot.ContentHeight = 18
        Me.lblLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.lblLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.lblLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLot.EditorHeight = 18
        Me.lblLot.EvenRowStyle = Style10
        Me.lblLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.FooterStyle = Style11
        Me.lblLot.HeadingStyle = Style12
        Me.lblLot.HighLightRowStyle = Style13
        Me.lblLot.Images.Add(CType(resources.GetObject("lblLot.Images"), System.Drawing.Image))
        Me.lblLot.ItemHeight = 20
        Me.lblLot.Location = New System.Drawing.Point(104, 88)
        Me.lblLot.MatchEntryTimeout = CType(2000, Long)
        Me.lblLot.MaxDropDownItems = CType(10, Short)
        Me.lblLot.MaxLength = 32767
        Me.lblLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.lblLot.Name = "lblLot"
        Me.lblLot.OddRowStyle = Style14
        Me.lblLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.lblLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lblLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lblLot.SelectedStyle = Style15
        Me.lblLot.Size = New System.Drawing.Size(376, 24)
        Me.lblLot.Style = Style16
        Me.lblLot.TabIndex = 2
        Me.lblLot.PropBag = resources.GetString("lblLot.PropBag")
        '
        'cboSpecie
        '
        Me.cboSpecie.AllowColMove = True
        Me.cboSpecie.AllowColSelect = True
        Me.cboSpecie.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSpecie.AlternatingRows = False
        Me.cboSpecie.CaptionStyle = Style17
        Me.cboSpecie.ColumnCaptionHeight = 17
        Me.cboSpecie.ColumnFooterHeight = 17
        Me.cboSpecie.EvenRowStyle = Style18
        Me.cboSpecie.FetchRowStyles = False
        Me.cboSpecie.FooterStyle = Style19
        Me.cboSpecie.HeadingStyle = Style20
        Me.cboSpecie.HighLightRowStyle = Style21
        Me.cboSpecie.Images.Add(CType(resources.GetObject("cboSpecie.Images"), System.Drawing.Image))
        Me.cboSpecie.Location = New System.Drawing.Point(96, 152)
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.OddRowStyle = Style22
        Me.cboSpecie.RecordSelectorStyle = Style23
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSpecie.RowHeight = 20
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.ScrollTips = False
        Me.cboSpecie.Size = New System.Drawing.Size(105, 224)
        Me.cboSpecie.Style = Style24
        Me.cboSpecie.TabIndex = 4
        Me.cboSpecie.Text = "C1TrueDBDropdown1"
        Me.cboSpecie.Visible = False
        Me.cboSpecie.PropBag = resources.GetString("cboSpecie.PropBag")
        '
        'cboSet
        '
        Me.cboSet.AllowColMove = True
        Me.cboSet.AllowColSelect = True
        Me.cboSet.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSet.AlternatingRows = False
        Me.cboSet.CaptionStyle = Style25
        Me.cboSet.ColumnCaptionHeight = 17
        Me.cboSet.ColumnFooterHeight = 17
        Me.cboSet.EvenRowStyle = Style26
        Me.cboSet.FetchRowStyles = False
        Me.cboSet.FooterStyle = Style27
        Me.cboSet.HeadingStyle = Style28
        Me.cboSet.HighLightRowStyle = Style29
        Me.cboSet.Images.Add(CType(resources.GetObject("cboSet.Images"), System.Drawing.Image))
        Me.cboSet.Location = New System.Drawing.Point(208, 152)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.OddRowStyle = Style30
        Me.cboSet.RecordSelectorStyle = Style31
        Me.cboSet.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSet.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSet.RowHeight = 20
        Me.cboSet.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSet.ScrollTips = False
        Me.cboSet.Size = New System.Drawing.Size(96, 224)
        Me.cboSet.Style = Style32
        Me.cboSet.TabIndex = 5
        Me.cboSet.Text = "C1TrueDBDropdown2"
        Me.cboSet.Visible = False
        Me.cboSet.PropBag = resources.GetString("cboSet.PropBag")
        '
        'cboSize
        '
        Me.cboSize.AllowColMove = True
        Me.cboSize.AllowColSelect = True
        Me.cboSize.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSize.AlternatingRows = False
        Me.cboSize.CaptionStyle = Style33
        Me.cboSize.ColumnCaptionHeight = 17
        Me.cboSize.ColumnFooterHeight = 17
        Me.cboSize.EvenRowStyle = Style34
        Me.cboSize.FetchRowStyles = False
        Me.cboSize.FooterStyle = Style35
        Me.cboSize.HeadingStyle = Style36
        Me.cboSize.HighLightRowStyle = Style37
        Me.cboSize.Images.Add(CType(resources.GetObject("cboSize.Images"), System.Drawing.Image))
        Me.cboSize.Location = New System.Drawing.Point(488, 152)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.OddRowStyle = Style38
        Me.cboSize.RecordSelectorStyle = Style39
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSize.RowHeight = 20
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.ScrollTips = False
        Me.cboSize.Size = New System.Drawing.Size(105, 224)
        Me.cboSize.Style = Style40
        Me.cboSize.TabIndex = 6
        Me.cboSize.Text = "C1TrueDBDropdown3"
        Me.cboSize.Visible = False
        Me.cboSize.PropBag = resources.GetString("cboSize.PropBag")
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Location = New System.Drawing.Point(600, 99)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(13, 13)
        Me.lblRow.TabIndex = 105
        Me.lblRow.Text = "0"
        Me.lblRow.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(101, 128)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(16, 16)
        Me.lblID.TabIndex = 106
        Me.lblID.Text = "*"
        Me.lblID.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(486, 64)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(120, 48)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmFishLot
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(898, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboSet)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.lblLot)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboVessel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishLot"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishLot"
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFishLot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        'displayFishingVessel()
    End Sub

    Public Sub displayFishingVessel()
        With cboVessel
            .DataSource = modModule.getFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 353

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        displayLot(cboVessel.Text)
        lblLot.Text = getCurrentLotPerVessel(cboVessel.Text)
    End Sub

    Public Sub displayLotDetails(ByVal lot As String)
        With grid
            .DataSource = getLotDetails(lot).Tables(0)
            .Columns(1).DropDown = cboSpecie
            displayFishSpecie()
            .Columns(2).DropDown = cboSet
            displayTypeOfSets()
            .Columns(5).DropDown = cboSize
            displayFishSizes()

            .Splits(0).DisplayColumns(1).DropDownList = True
            .Splits(0).DisplayColumns(2).DropDownList = True
            .Splits(0).DisplayColumns(5).DropDownList = True
            .Splits(0).DisplayColumns(6).Locked = True
            .Splits(0).DisplayColumns(6).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(7).Locked = True
            .Splits(0).DisplayColumns(7).Style.BackColor = Color.Gray

            .Columns(7).DefaultValue = 0
            .Columns(7).NumberFormat = "###,###,##0.##0"

            .Splits(0).DisplayColumns(2).Width = 100
            .Splits(0).DisplayColumns(4).Width = 60
            .Splits(0).DisplayColumns(6).Width = 60
            .Splits(0).DisplayColumns(7).Width = 80
            .Splits(0).DisplayColumns(8).Width = 130

            displaySublotTonnage()
        End With
    End Sub

    Public Sub displayLot(ByVal fv As String)
        With lblLot
            .Text = ""
            .DataSource = getFishLotByFV(fv).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 353
        End With
    End Sub

    Private Sub lblLot_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLot.TextChanged
        displayLotDetails(lblLot.Text)
    End Sub

    Public Sub displayFishSpecie(Optional ByVal specie As String = "")
        With cboSpecie
            '.DefColWidth = 210
            If specie = "" Then
                .DataSource = modModule.getFishSpecie().Tables(0)
            Else
                .DataSource = modModule.getFishSpecie(True).Tables(0)
            End If
            '.Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub

    Public Sub displayFishSizes()
        With cboSize
            .DefColWidth = 210
            .DataSource = modModule.getFishSizeRanges().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayTypeOfSets()
        With cboSet
            .DefColWidth = 120
            .DataSource = getTypeOfSets().Tables(0)
        End With
    End Sub

    Private Sub grid_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.AfterUpdate
        Dim lot As String
        Dim subLot As String
        Dim specie As String
        Dim sets As String
        Dim subLot2 As String
        Dim well As String
        Dim size As String
        Dim remarks As String

        With grid
            lblRow.Text = prevRecord

            If Not cboVessel.Text.Trim = "" And Not lblLot.Text.Trim = "" Then
                If allFieldsAreFilled() Then
                    If .RowCount > 0 Then

                        If .Item(prevRecord, 0) Is DBNull.Value Then
                            subLot = ""
                        Else
                            subLot = .Item(prevRecord, 0)
                            .Item(prevRecord, 0) = UCase(CStr(.Item(prevRecord, 0)).Trim)
                        End If

                        If .Item(prevRecord, 1) Is DBNull.Value Then
                            specie = ""
                        Else
                            specie = .Item(prevRecord, 1)
                        End If

                        If .Item(prevRecord, 2) Is DBNull.Value Then
                            sets = ""
                        Else
                            sets = .Item(prevRecord, 2)
                        End If

                        If .Item(prevRecord, 3) Is DBNull.Value Then
                            subLot2 = ""
                        Else
                            subLot2 = .Item(prevRecord, 3)
                            .Item(prevRecord, 3) = UCase(CStr(.Item(prevRecord, 3)).Trim)
                        End If

                        If .Item(prevRecord, 4) Is DBNull.Value Then
                            well = ""
                        Else
                            well = .Item(prevRecord, 4)
                        End If

                        If .Item(prevRecord, 5) Is DBNull.Value Then
                            size = ""
                        Else
                            size = .Item(prevRecord, 5)
                        End If

                        If .Item(prevRecord, 8) Is DBNull.Value Then
                            remarks = ""
                        Else
                            remarks = .Item(prevRecord, 8)
                        End If


                        saveBatchLotDetails(lblLot.Text, subLot, specie, _
                            sets, subLot2, well, size, remarks)
                        'Else
                        '    updateFishLotDetailsByID(lblID.Text, lblLot.Text, subLot, sets, _
                        '        well, sets, specie, size, remarks, subLot2)
                        'End If
                        'End If
                        'Else
                        'displayLotDetails(lblLot.Text)
                    End If
                Else
                    MsgBox("Please identify the fish lot, specie and type of sets", MsgBoxStyle.Exclamation, "Warning")
                    grid.Focus()
                End If
            Else
                MsgBox("Please identify the trip code details", MsgBoxStyle.Exclamation, "Warning")
                displayLotDetails(lblLot.Text)
                cboVessel.SelectAll()
                cboVessel.Focus()
            End If
        End With
    End Sub

    Private Sub grid_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.Change
        prevRecord = grid.Row
        lblRow.Text = prevRecord
    End Sub

    Public Sub saveBatchLotDetails(ByVal lot As String, ByVal subLot As String, ByVal specie As String, ByVal sets As String, _
    ByVal subLot2 As String, ByVal well As String, ByVal size As String, ByVal remarks As String)

        If lblID.Text = "" Then
            If isLotExisting(subLot.Trim) Then
                If validateFishLotSpecie(lot.Trim, subLot.Trim, specie) Then
                    saveRecord(lot, subLot, specie, subLot2, well, size, sets, remarks)
                Else
                    MsgBox("You are not allowed to assigned different fish species to a fish lot" & Chr(13) & _
                        "For details, please contact your System Administrator", MsgBoxStyle.Exclamation, "Warning")
                End If
            Else
                saveRecord(lot, subLot, specie, subLot2, well, size, sets, remarks)
            End If
        Else
            MsgBox("You are not allowed to modify the existing fish lot" & Chr(13) & _
                "For details, please contact your System Administrator", MsgBoxStyle.Exclamation, "Warning")
            displayLotDetails(lblLot.Text)
        End If

    End Sub

    Public Sub saveRecord(ByVal lot As String, ByVal sublot As String, ByVal specie As String, ByVal sublot2 As String, _
    ByVal well As String, ByVal size As String, ByVal sets As String, ByVal remarks As String)

        If Not validateFishLotDetails(lot.Trim, sublot.Trim, specie.Trim, sublot2.Trim, well) Then
            Dim reply As String = MsgBox("Are you sure you want to add/ update this lot number?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then
                saveNewFishLotDetails(lot.Trim, sublot.Trim, "Brine Frozen", well, sets, specie.Trim, size, remarks, sublot2.Trim)

                MsgBox("You have successfully added new fish lot!", MsgBoxStyle.Information, "Information")
            Else
                displayLotDetails(lblLot.Text)
            End If
        Else
            MsgBox("You are not allowed to modify the existing fish lot" & Chr(13) & _
                "For details, please contact your System Administrator", MsgBoxStyle.Exclamation, "Warning")
            displayLotDetails(lblLot.Text)
        End If

        grid.Row = grid.RowCount
        grid.Col = 0

        'displayLotDetails(lblLot.Text)
    End Sub

    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        With grid
            If e.KeyCode = Keys.Delete Then
                deleteRecord()
            ElseIf e.KeyCode = Keys.Escape Then
                displayLotDetails(lblLot.Text)
            End If
        End With
    End Sub

    Public Sub deleteRecord()
        With grid
            If Not .Item(.Row, 7) Is DBNull.Value Then
                If Not CStr(.Item(.Row, 7)) = "" Then
                    If CDbl(.Item(.Row, 7)) <= 0 Then
                        Dim reply As String = MsgBox("Do you want to remove the lot number?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                        If reply = vbYes Then
                            Dim sublot, specie, sublot2 As String

                            If .Item(.Row, 0) Is DBNull.Value Then
                                sublot = ""
                            Else
                                sublot = .Item(.Row, 0)
                            End If

                            If .Item(.Row, 1) Is DBNull.Value Then
                                specie = ""
                            Else
                                specie = .Item(.Row, 1)
                            End If

                            If .Item(.Row, 3) Is DBNull.Value Then
                                sublot2 = ""
                            Else
                                sublot2 = .Item(.Row, 3)
                            End If

                            deleteFishLotDetails(lblLot.Text, sublot, specie, sublot2)
                            MsgBox("You have successfully deleted the Lot number " & sublot & " from the database", MsgBoxStyle.Information, "Information")
                        End If

                        displayLotDetails(lblLot.Text)
                    Else
                        MsgBox("Removing this lot is not allowed because it's not empty or zero tonnage", MsgBoxStyle.Exclamation, "Warning")
                        displayLotDetails(lblLot.Text)
                    End If
                Else
                    MsgBox("Please identify the fish lot to remove", MsgBoxStyle.Exclamation, "Warning")
                    grid.Focus()
                End If
            Else
                MsgBox("Please identify the fish lot to remove", MsgBoxStyle.Exclamation, "Warning")
                grid.Focus()
            End If
        End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        displaySublotTonnage()

        displayFishLotID()
    End Sub

    Public Sub displayFishLotID()
        Dim sublot, specie As String, sublot2 As String
        If grid.Item(grid.Row, 0) Is DBNull.Value Then
            sublot = ""
        Else
            sublot = grid.Item(grid.Row, 0)
        End If

        If grid.Item(grid.Row, 1) Is DBNull.Value Then
            specie = ""
        Else
            specie = grid.Item(grid.Row, 1)
        End If

        If grid.Item(grid.Row, 3) Is DBNull.Value Then
            sublot2 = ""
        Else
            sublot2 = grid.Item(grid.Row, 3)
        End If

        lblID.Text = getFishLotID(lblLot.Text, sublot, sublot2, specie)
    End Sub

    Public Sub displaySublotTonnage()
        Dim sublot, specie, sublot2 As String
        With grid
            Dim ctr As Integer
            While ctr < .RowCount
                If .Item(ctr, 0) Is DBNull.Value Then
                    sublot = ""
                Else
                    sublot = .Item(ctr, 0)
                End If

                If .Item(ctr, 1) Is DBNull.Value Then
                    specie = ""
                Else
                    specie = .Item(ctr, 1)
                End If

                If .Item(ctr, 3) Is DBNull.Value Then
                    sublot2 = ""
                Else
                    sublot2 = .Item(ctr, 3)
                End If

                .Item(ctr, 7) = Format(getSubLotTotalTonnage(lblLot.Text, sublot, specie, sublot2), "###,##0.##0")

                ctr += 1
            End While
        End With
    End Sub

    Public Function allFieldsAreFilled() As Boolean
        With grid
            Dim ctr As Integer
            Try
                While ctr < .RowCount
                    If .Item(ctr, 0) = "" Or .Item(ctr, 1) = "" Or .Item(ctr, 2) = "" Then
                        Return False
                    End If

                    ctr += 1
                End While

                Return True
            Catch ex As Exception
                While ctr < .RowCount
                    If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or .Item(ctr, 2) Is DBNull.Value Then
                        Return False
                    End If

                    ctr += 1
                End While

                Return True
            End Try
        End With
    End Function

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        deleteRecord()
        grid.Focus()
    End Sub

    Public Function isLotExisting(ByVal sublot As String) As Boolean
        Dim ctr As Integer
        Dim count As Integer
        With grid
            If grid.RowCount <= 1 Then
                Return False
            Else
                While ctr < .RowCount
                    If UCase(CStr(.Item(ctr, 0)).Trim) = UCase(sublot.Trim) Then count += 1

                    ctr += 1
                End While
            End If
        End With

        If count > 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
