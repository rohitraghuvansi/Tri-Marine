Public Class frmCOS

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboCOS As C1.Win.C1List.C1Combo
    Friend WithEvents lblVessel As System.Windows.Forms.Label
    Friend WithEvents cboSpecie As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboSize As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents gridSublot As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtMerchandise As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtConversion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCOS))
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
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.cboCOS = New C1.Win.C1List.C1Combo()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmd = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblVessel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSpecie = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboSize = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.gridSublot = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.txtMerchandise = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConversion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSublot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cboLot.Location = New System.Drawing.Point(104, 53)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 6
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style6
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.SelectedStyle = Style7
        Me.cboLot.Size = New System.Drawing.Size(152, 24)
        Me.cboLot.Style = Style8
        Me.cboLot.TabIndex = 0
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'cboCOS
        '
        Me.cboCOS.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCOS.AllowColMove = False
        Me.cboCOS.AutoCompletion = True
        Me.cboCOS.AutoDropDown = True
        Me.cboCOS.Caption = ""
        Me.cboCOS.CaptionHeight = 17
        Me.cboCOS.CaptionStyle = Style9
        Me.cboCOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCOS.ColumnCaptionHeight = 17
        Me.cboCOS.ColumnFooterHeight = 17
        Me.cboCOS.ComboStyle = C1.Win.C1List.ComboStyleEnum.SimpleCombo
        Me.cboCOS.ContentHeight = 18
        Me.cboCOS.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCOS.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCOS.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOS.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCOS.EditorHeight = 18
        Me.cboCOS.EvenRowStyle = Style10
        Me.cboCOS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOS.FooterStyle = Style11
        Me.cboCOS.HeadingStyle = Style12
        Me.cboCOS.HighLightRowStyle = Style13
        Me.cboCOS.Images.Add(CType(resources.GetObject("cboCOS.Images"), System.Drawing.Image))
        Me.cboCOS.ItemHeight = 20
        Me.cboCOS.Location = New System.Drawing.Point(104, 86)
        Me.cboCOS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCOS.MaxDropDownItems = CType(20, Short)
        Me.cboCOS.MaxLength = 32767
        Me.cboCOS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCOS.Name = "cboCOS"
        Me.cboCOS.OddRowStyle = Style14
        Me.cboCOS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCOS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCOS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCOS.SelectedStyle = Style15
        Me.cboCOS.Size = New System.Drawing.Size(152, 26)
        Me.cboCOS.Style = Style16
        Me.cboCOS.TabIndex = 1
        Me.cboCOS.PropBag = resources.GetString("cboCOS.PropBag")
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(16, 260)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(520, 217)
        Me.grid.TabIndex = 4
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(76, 482)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 5
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(156, 482)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 6
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(236, 482)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 7
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(316, 482)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(396, 482)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 40)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Confirmation of Sale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Vessel Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Trip Code"
        '
        'lblVessel
        '
        Me.lblVessel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVessel.Location = New System.Drawing.Point(376, 53)
        Me.lblVessel.Name = "lblVessel"
        Me.lblVessel.Size = New System.Drawing.Size(160, 59)
        Me.lblVessel.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "COS No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Date"
        '
        'cboSpecie
        '
        Me.cboSpecie.AllowColMove = True
        Me.cboSpecie.AllowColSelect = True
        Me.cboSpecie.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSpecie.AlternatingRows = False
        Me.cboSpecie.CaptionHeight = 17
        Me.cboSpecie.CaptionStyle = Style17
        Me.cboSpecie.ColumnCaptionHeight = 17
        Me.cboSpecie.ColumnFooterHeight = 17
        Me.cboSpecie.EvenRowStyle = Style18
        Me.cboSpecie.FetchRowStyles = False
        Me.cboSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.FooterStyle = Style19
        Me.cboSpecie.HeadingStyle = Style20
        Me.cboSpecie.HighLightRowStyle = Style21
        Me.cboSpecie.Images.Add(CType(resources.GetObject("cboSpecie.Images"), System.Drawing.Image))
        Me.cboSpecie.Location = New System.Drawing.Point(24, 292)
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.OddRowStyle = Style22
        Me.cboSpecie.RecordSelectorStyle = Style23
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSpecie.RowHeight = 20
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.ScrollTips = False
        Me.cboSpecie.Size = New System.Drawing.Size(182, 185)
        Me.cboSpecie.Style = Style24
        Me.cboSpecie.TabIndex = 37
        Me.cboSpecie.Text = "C1TrueDBDropdown1"
        Me.cboSpecie.Visible = False
        Me.cboSpecie.PropBag = resources.GetString("cboSpecie.PropBag")
        '
        'cboSize
        '
        Me.cboSize.AllowColMove = True
        Me.cboSize.AllowColSelect = True
        Me.cboSize.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSize.AlternatingRows = False
        Me.cboSize.CaptionHeight = 17
        Me.cboSize.CaptionStyle = Style25
        Me.cboSize.ColumnCaptionHeight = 17
        Me.cboSize.ColumnFooterHeight = 17
        Me.cboSize.EvenRowStyle = Style26
        Me.cboSize.FetchRowStyles = False
        Me.cboSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSize.FooterStyle = Style27
        Me.cboSize.HeadingStyle = Style28
        Me.cboSize.HighLightRowStyle = Style29
        Me.cboSize.Images.Add(CType(resources.GetObject("cboSize.Images"), System.Drawing.Image))
        Me.cboSize.Location = New System.Drawing.Point(208, 292)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.OddRowStyle = Style30
        Me.cboSize.RecordSelectorStyle = Style31
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSize.RowHeight = 20
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.ScrollTips = False
        Me.cboSize.Size = New System.Drawing.Size(182, 185)
        Me.cboSize.Style = Style32
        Me.cboSize.TabIndex = 38
        Me.cboSize.Text = "C1TrueDBDropdown2"
        Me.cboSize.Visible = False
        Me.cboSize.PropBag = resources.GetString("cboSize.PropBag")
        '
        'gridSublot
        '
        Me.gridSublot.AllowUpdate = False
        Me.gridSublot.Enabled = False
        Me.gridSublot.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSublot.Images.Add(CType(resources.GetObject("gridSublot.Images"), System.Drawing.Image))
        Me.gridSublot.Location = New System.Drawing.Point(280, 208)
        Me.gridSublot.Name = "gridSublot"
        Me.gridSublot.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSublot.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSublot.PreviewInfo.ZoomFactor = 75.0R
        Me.gridSublot.PrintInfo.PageSettings = CType(resources.GetObject("gridSublot.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridSublot.Size = New System.Drawing.Size(256, 32)
        Me.gridSublot.TabIndex = 8
        Me.gridSublot.Text = "C1TrueDBGrid2"
        Me.gridSublot.Visible = False
        Me.gridSublot.PropBag = resources.GetString("gridSublot.PropBag")
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(104, 120)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(152, 23)
        Me.txtDate.TabIndex = 2
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtMerchandise
        '
        Me.txtMerchandise.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMerchandise.Location = New System.Drawing.Point(104, 152)
        Me.txtMerchandise.Multiline = True
        Me.txtMerchandise.Name = "txtMerchandise"
        Me.txtMerchandise.ReadOnly = True
        Me.txtMerchandise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMerchandise.Size = New System.Drawing.Size(432, 40)
        Me.txtMerchandise.TabIndex = 40
        Me.txtMerchandise.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Merchandise"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "COS Details"
        '
        'txtConversion
        '
        Me.txtConversion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConversion.Location = New System.Drawing.Point(104, 200)
        Me.txtConversion.Name = "txtConversion"
        Me.txtConversion.Size = New System.Drawing.Size(152, 23)
        Me.txtConversion.TabIndex = 3
        Me.txtConversion.Text = "0.00"
        Me.txtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 30)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Conversion (SBD)"
        '
        'frmCOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(546, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.gridSublot)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtConversion)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMerchandise)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblVessel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboCOS)
        Me.Controls.Add(Me.cboLot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCOS"
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSublot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmCOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()
        dataEntry(1)

        displayBatchlot()
        displayCOS()
        displayListsOfCOSDetails()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayBatchlot()
        With cboLot
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130
        End With
    End Sub

    Public Sub displayCOS()
        With cboCOS
            .DataSource = modModule.getCOSNo().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130
        End With
    End Sub

    Public Sub displaySublot(ByVal lot As String)
        With gridSublot
            .Text = ""
            .DataSource = modModule.getFishLot_MethodAndVesselInfo(lot).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 65

            If .RowCount > 0 Then
                lblVessel.Text = .Item(.Row, 3)
            Else
                lblVessel.Text = ""
            End If
        End With
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displaySublot(cboLot.Text)
        displayListsOfCOSDetails()
        'displayCOSDetails(cboCOS.Text, cboLot.Text)

        If getLotFishCondition(cboLot.Text) = "" Then
            txtMerchandise.Text = "Total of " & Format(getLotTotalTonnage(cboLot.Text), "###,###,###,##0.#0") & " MT"
        Else
            txtMerchandise.Text = "Total of " & Format(getLotTotalTonnage(cboLot.Text), "###,###,###,##0.#0") & " MT of " & _
                getLotFishCondition(cboLot.Text) & " " & getLotFishSpecie(cboLot.Text) & " Round"
        End If
    End Sub

    Public Sub displayListsOfCOSDetails()
        With grid
            .DataSource = modModule.getListsCOSDetails(cboLot.Text).Tables(0)
            '.Columns(0).DropDown = cboSpecie
            '.Columns(1).DropDown = cboSize
            '.Splits(0).DisplayColumns(0).DropDownList = True
            '.Splits(0).DisplayColumns(1).DropDownList = True
            displayFishSpecie()
            displayFishSizes()

            '.Splits(0).DisplayColumns(0).Width = 70
            '.Splits(0).DisplayColumns(1).Width = 110
            '.Splits(0).DisplayColumns(2).Width = 110
            '.Splits(0).DisplayColumns(3).Width = 95
            '.Splits(0).DisplayColumns(4).Width = 90
            '.Columns(4).DefaultValue = "0.00"
            '.Columns(4).NumberFormat = "###,##0.#0"

            .Splits(0).DisplayColumns(0).Width = 130
            .Splits(0).DisplayColumns(1).Width = 125
            .Splits(0).DisplayColumns(2).Width = 105
            .Splits(0).DisplayColumns(3).Width = 100
            .Columns(3).DefaultValue = "0.00"
            .Columns(3).NumberFormat = "###,##0.#0"

            .Splits(0).DisplayColumns(0).Locked = True
            .Splits(0).DisplayColumns(1).Locked = True
            .Splits(0).DisplayColumns(2).Locked = True
            '.Splits(0).DisplayColumns(3).Locked = True

            .Splits(0).DisplayColumns(0).Style.BackColor = Color.LightGray
            .Splits(0).DisplayColumns(1).Style.BackColor = Color.LightGray
            .Splits(0).DisplayColumns(2).Style.BackColor = Color.LightGray
            '.Splits(0).DisplayColumns(3).Style.BackColor = Color.LightGray

            displayCOSDetails()
        End With

        '    Public Sub displayListsOfCOSDetails()
        '    With grid
        '        .DataSource = modModule.getListsCOSDetails().Tables(0)
        '        .Columns(0).DropDown = cboSpecie
        '        .Columns(1).DropDown = cboSize
        '        .Splits(0).DisplayColumns(0).DropDownList = True
        '        .Splits(0).DisplayColumns(1).DropDownList = True
        '        displayFishSpecie()
        '        displayFishSizes()

        '        .Splits(0).DisplayColumns(0).Width = 180
        '        .Splits(0).DisplayColumns(1).Width = 180
        '        .Splits(0).DisplayColumns(2).Width = 120
        '        .Columns(2).DefaultValue = "0.00"
        '        .Columns(2).NumberFormat = "###,##0.#0"
        '    End With
        'End Sub
    End Sub

    Public Sub displayFishSpecie()
        With cboSpecie
            .DefColWidth = 160
            .DataSource = modModule.getFishSpecie().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub

    Public Sub displayFishSizes()
        With cboSize
            .DefColWidth = 160
            .DataSource = modModule.getFishSizeRanges().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            'If .ListCount > 0 Then .SelectedIndex = 0
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
                cboLot.ReadOnly = False
                cboCOS.ReadOnly = False
                txtDate.ReadOnly = False
                txtConversion.ReadOnly = False
                grid.Enabled = True
            Case 1
                cboLot.ReadOnly = True
                cboCOS.ReadOnly = True
                txtDate.ReadOnly = True
                txtConversion.ReadOnly = True
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        cboLot.ReadOnly = False
        cboLot.Text = ""
        displayBatchlot()
        lblVessel.Text = ""
        cboCOS.Text = ""
        txtDate.Value = getServerDateTime()
        displayCOS()
        txtConversion.Text = "0.00"

        displayListsOfCOSDetails()
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
                cboLot.ReadOnly = False
                cboCOS.ReadOnly = False
                cboLot.SelectAll()
                cboLot.Focus()
            Case "&Save"
                If Not cboLot.Text.Trim = "" And Not lblVessel.Text.Trim = "" And Not cboCOS.Text.Trim = "" And _
                Not isDataEntryFieldsAreEmpty() And Not isFishBinFoundDuplicate() And grid.RowCount > 0 And _
                Not CDbl(txtConversion.Text) = 0 Then
                    If Not validateCOS(cboCOS.Text.Trim) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewCOS(cboCOS.Text, txtDate.Text, txtConversion.Text)

                            'Dim sublotIndex As Integer
                            Dim cosDetIndex As Integer
                            'While sublotIndex < gridSublot.RowCount

                            'cosDetIndex = 0
                            While cosDetIndex < grid.RowCount
                                saveNewCOSDetails(cboCOS.Text, cboLot.Text, "", grid.Item(cosDetIndex, 0), grid.Item(cosDetIndex, 1), grid.Item(cosDetIndex, 3))
                                'grid.Item(cosDetIndex, 0)

                                cosDetIndex += 1
                            End While

                            'sublotIndex += 1
                            'End While

                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("COS Number already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCOS.SelectAll()
                        cboCOS.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboLot.SelectAll()
                    cboLot.Focus()
                End If
            Case "&Save "
                If Not cboLot.Text.Trim = "" And grid.RowCount > 0 Then
                    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        updateCOS(cboCOS.Text, txtDate.Text, txtConversion.Text)

                        deleteCOSDetails(cboCOS.Text)
                        'Dim sublotIndex As Integer
                        Dim cosDetIndex As Integer
                        'While sublotIndex < gridSublot.RowCount

                        cosDetIndex = 0
                        While cosDetIndex < grid.RowCount
                            saveNewCOSDetails(cboCOS.Text, cboLot.Text, "", grid.Item(cosDetIndex, 0), grid.Item(cosDetIndex, 1), grid.Item(cosDetIndex, 3))
                            'grid.Item(cosDetIndex, 0)

                            cosDetIndex += 1
                        End While

                        'sublotIndex += 1
                        'End While

                        cmd.Text = "&Add"
                        cmdEdit.Text = "&Edit"
                        buttons(1)
                        dataEntry(1)
                        'displayAllCatchAreas()
                        'displayAreaCode()
                        'displayOcean()
                        MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                        cmd.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboLot.SelectAll()
                    cboLot.Focus()
                End If
        End Select
    End Sub

    Public Function isDataEntryFieldsAreEmpty() As Boolean
        Try
            Dim ctr As Integer
            With grid
                While ctr < .RowCount
                    'If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or .Item(ctr, 2) Is DBNull.Value Then
                    If CStr(.Item(ctr, 0)).Equals("") Or CStr(.Item(ctr, 1)).Equals("") Or CStr(.Item(ctr, 2)).Equals("") Then
                        MsgBox("Please check your data entry fields such as Fish specie, size and price, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                    Else
                        Return False
                    End If

                    ctr += 1
                End While
            End With

            Return False
        Catch e As Exception
            MsgBox("Please check your data entry fields such as Fish specie, size and price, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
            Return True
        End Try
    End Function

    Public Function isFishBinFoundDuplicate() As Boolean
        Try
            Dim outer As Integer
            Dim inner As Integer
            With grid
                While outer < .RowCount
                    'If isFishBinFoundDuplicate(.Item(ctr, 0), ctr) Then
                    '    Return True
                    'End If

                    inner = outer + 1
                    While inner < .RowCount
                        If Not .Item(outer, 2) Is DBNull.Value And Not .Item(inner, 2) Is DBNull.Value Then
                            If .Item(outer, 0) = .Item(inner, 0) And .Item(outer, 1) = .Item(inner, 1) And .Item(outer, 2) = .Item(inner, 2) Then
                                MsgBox("You have a multiple entries of Fish size in the lists." & Chr(13) & _
                                    "Please remove the size " & .Item(outer, 1) & " on row " & inner + 1 & " in the grid", MsgBoxStyle.Exclamation, "Warning")
                                Return True
                            End If
                        End If

                        inner += 1
                    End While

                    outer += 1
                End While
            End With

            Return False
        Catch e As Exception
            MsgBox("Please check your data entry fields such as Fish specie, size and price, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
            Return True
        End Try
    End Function

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Contract of Sale"
        f.searchType = 1
        f.displayAllCOS()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                cboCOS.Text = .Item(.Row, 0)
                txtDate.Value = .Item(.Row, 1)
                cboLot.Text = .Item(.Row, 2)
                txtConversion.Text = .Item(.Row, 6)

                displayListsOfCOSDetails()  'displayCOSDetails(cboCOS.Text, cboLot.Text)
            End If
        End With
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboCOS.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboLot.ReadOnly = True
                    cboCOS.ReadOnly = True
                    cboLot.SelectAll()
                    cboLot.Focus()
                Else
                    MsgBox("Pleas identify COS Number.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cmdFind.Focus()
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

    'Public Sub displayCOSDetails(ByVal cos As String, ByVal lot As String)
    '    With grid
    '        .DataSource = getCOSDetails(cos, lot).Tables(0)
    '        .Columns(0).DropDown = cboSpecie
    '        .Columns(1).DropDown = cboSize
    '        .Splits(0).DisplayColumns(0).DropDownList = True
    '        .Splits(0).DisplayColumns(1).DropDownList = True
    '        displayFishSpecie()
    '        displayFishSizes()

    '        .Splits(0).DisplayColumns(0).Width = 180
    '        .Splits(0).DisplayColumns(1).Width = 180
    '        .Splits(0).DisplayColumns(2).Width = 120
    '        .Columns(2).DefaultValue = "0.00"
    '        .Columns(2).NumberFormat = "###,##0.#0"
    '    End With
    'End Sub

    Private Sub cboCOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCOS.TextChanged
        displayListsOfCOSDetails()  'displayCOSDetails(cboCOS.Text, cboLot.Text)
    End Sub



    Public Sub displayCOSDetails()
        Dim index As Integer
        While index < grid.RowCount
            grid.Item(index, 3) = getCOSPrice(cboCOS.Text, cboLot.Text, _
                "", grid.Item(index, 0), grid.Item(index, 1))    'grid.Item(index, 0)

            index += 1
        End While
    End Sub

End Class

