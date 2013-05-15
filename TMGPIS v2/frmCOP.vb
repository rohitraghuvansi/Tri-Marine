Public Class frmCOP
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblVessel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridSublot As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboCOP As C1.Win.C1List.C1Combo
    Friend WithEvents cboCOS As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblLot As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuMCOS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMPD As System.Windows.Forms.MenuItem
    Friend WithEvents cboSpecie As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboCleaning As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboSize As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtConversion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMT As System.Windows.Forms.TextBox
    Friend WithEvents lblTonnage As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCOP))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboSpecie = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblVessel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridSublot = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cboCOP = New C1.Win.C1List.C1Combo()
        Me.cboCOS = New C1.Win.C1List.C1Combo()
        Me.lblLot = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuMCOS = New System.Windows.Forms.MenuItem()
        Me.mnuMPD = New System.Windows.Forms.MenuItem()
        Me.cboCleaning = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboSize = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.txtConversion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTonnage = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSublot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCleaning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(458, 493)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 52
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(378, 493)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 50
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(298, 493)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 49
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(218, 493)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 48
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(138, 493)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 47
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "COS Details"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(104, 119)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(152, 23)
        Me.txtDate.TabIndex = 45
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboSpecie
        '
        Me.cboSpecie.AllowColMove = True
        Me.cboSpecie.AllowColSelect = True
        Me.cboSpecie.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSpecie.AlternatingRows = False
        Me.cboSpecie.CaptionHeight = 17
        Me.cboSpecie.CaptionStyle = Style1
        Me.cboSpecie.ColumnCaptionHeight = 17
        Me.cboSpecie.ColumnFooterHeight = 17
        Me.cboSpecie.EvenRowStyle = Style2
        Me.cboSpecie.FetchRowStyles = False
        Me.cboSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.FooterStyle = Style3
        Me.cboSpecie.HeadingStyle = Style4
        Me.cboSpecie.HighLightRowStyle = Style5
        Me.cboSpecie.Images.Add(CType(resources.GetObject("cboSpecie.Images"), System.Drawing.Image))
        Me.cboSpecie.Location = New System.Drawing.Point(24, 208)
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.OddRowStyle = Style6
        Me.cboSpecie.RecordSelectorStyle = Style7
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSpecie.RowHeight = 20
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.ScrollTips = False
        Me.cboSpecie.Size = New System.Drawing.Size(152, 278)
        Me.cboSpecie.Style = Style8
        Me.cboSpecie.TabIndex = 59
        Me.cboSpecie.Text = "C1TrueDBDropdown1"
        Me.cboSpecie.Visible = False
        Me.cboSpecie.PropBag = resources.GetString("cboSpecie.PropBag")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Date"
        '
        'lblVessel
        '
        Me.lblVessel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVessel.Location = New System.Drawing.Point(432, 116)
        Me.lblVessel.Name = "lblVessel"
        Me.lblVessel.Size = New System.Drawing.Size(232, 28)
        Me.lblVessel.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "COP No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Vessel Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "COS No."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(670, 40)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Confirmation of Purchase"
        '
        'gridSublot
        '
        Me.gridSublot.AllowUpdate = False
        Me.gridSublot.Enabled = False
        Me.gridSublot.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSublot.Images.Add(CType(resources.GetObject("gridSublot.Images"), System.Drawing.Image))
        Me.gridSublot.Location = New System.Drawing.Point(256, 224)
        Me.gridSublot.Name = "gridSublot"
        Me.gridSublot.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSublot.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSublot.PreviewInfo.ZoomFactor = 75.0R
        Me.gridSublot.PrintInfo.PageSettings = CType(resources.GetObject("gridSublot.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridSublot.Size = New System.Drawing.Size(184, 48)
        Me.gridSublot.TabIndex = 51
        Me.gridSublot.Text = "C1TrueDBGrid2"
        Me.gridSublot.Visible = False
        Me.gridSublot.PropBag = resources.GetString("gridSublot.PropBag")
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(16, 200)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(645, 286)
        Me.grid.TabIndex = 46
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cboCOP
        '
        Me.cboCOP.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCOP.AllowColMove = False
        Me.cboCOP.AutoCompletion = True
        Me.cboCOP.AutoDropDown = True
        Me.cboCOP.Caption = ""
        Me.cboCOP.CaptionHeight = 17
        Me.cboCOP.CaptionStyle = Style9
        Me.cboCOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCOP.ColumnCaptionHeight = 17
        Me.cboCOP.ColumnFooterHeight = 17
        Me.cboCOP.ComboStyle = C1.Win.C1List.ComboStyleEnum.SimpleCombo
        Me.cboCOP.ContentHeight = 18
        Me.cboCOP.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCOP.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCOP.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOP.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCOP.EditorHeight = 18
        Me.cboCOP.EvenRowStyle = Style10
        Me.cboCOP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOP.FooterStyle = Style11
        Me.cboCOP.HeadingStyle = Style12
        Me.cboCOP.HighLightRowStyle = Style13
        Me.cboCOP.Images.Add(CType(resources.GetObject("cboCOP.Images"), System.Drawing.Image))
        Me.cboCOP.ItemHeight = 20
        Me.cboCOP.Location = New System.Drawing.Point(104, 85)
        Me.cboCOP.MatchEntryTimeout = CType(2000, Long)
        Me.cboCOP.MaxDropDownItems = CType(20, Short)
        Me.cboCOP.MaxLength = 32767
        Me.cboCOP.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCOP.Name = "cboCOP"
        Me.cboCOP.OddRowStyle = Style14
        Me.cboCOP.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCOP.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCOP.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCOP.SelectedStyle = Style15
        Me.cboCOP.Size = New System.Drawing.Size(152, 26)
        Me.cboCOP.Style = Style16
        Me.cboCOP.TabIndex = 44
        Me.cboCOP.PropBag = resources.GetString("cboCOP.PropBag")
        '
        'cboCOS
        '
        Me.cboCOS.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCOS.AllowColMove = False
        Me.cboCOS.AutoCompletion = True
        Me.cboCOS.AutoDropDown = True
        Me.cboCOS.Caption = ""
        Me.cboCOS.CaptionHeight = 17
        Me.cboCOS.CaptionStyle = Style17
        Me.cboCOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCOS.ColumnCaptionHeight = 17
        Me.cboCOS.ColumnFooterHeight = 17
        Me.cboCOS.ContentHeight = 18
        Me.cboCOS.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCOS.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCOS.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOS.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCOS.EditorHeight = 18
        Me.cboCOS.EvenRowStyle = Style18
        Me.cboCOS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOS.FooterStyle = Style19
        Me.cboCOS.HeadingStyle = Style20
        Me.cboCOS.HighLightRowStyle = Style21
        Me.cboCOS.Images.Add(CType(resources.GetObject("cboCOS.Images"), System.Drawing.Image))
        Me.cboCOS.ItemHeight = 20
        Me.cboCOS.Location = New System.Drawing.Point(104, 53)
        Me.cboCOS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCOS.MaxDropDownItems = CType(20, Short)
        Me.cboCOS.MaxLength = 32767
        Me.cboCOS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCOS.Name = "cboCOS"
        Me.cboCOS.OddRowStyle = Style22
        Me.cboCOS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCOS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCOS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCOS.SelectedStyle = Style23
        Me.cboCOS.Size = New System.Drawing.Size(152, 24)
        Me.cboCOS.Style = Style24
        Me.cboCOS.TabIndex = 43
        Me.cboCOS.PropBag = resources.GetString("cboCOS.PropBag")
        '
        'lblLot
        '
        Me.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.Location = New System.Drawing.Point(432, 53)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(232, 24)
        Me.lblLot.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Trip Code"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMCOS, Me.mnuMPD})
        '
        'mnuMCOS
        '
        Me.mnuMCOS.Index = 0
        Me.mnuMCOS.Text = "Contract of &Sale"
        '
        'mnuMPD
        '
        Me.mnuMPD.Index = 1
        Me.mnuMPD.Text = "P&roduct Description"
        '
        'cboCleaning
        '
        Me.cboCleaning.AllowColMove = True
        Me.cboCleaning.AllowColSelect = True
        Me.cboCleaning.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboCleaning.AlternatingRows = False
        Me.cboCleaning.CaptionHeight = 17
        Me.cboCleaning.CaptionStyle = Style25
        Me.cboCleaning.ColumnCaptionHeight = 17
        Me.cboCleaning.ColumnFooterHeight = 17
        Me.cboCleaning.EvenRowStyle = Style26
        Me.cboCleaning.FetchRowStyles = False
        Me.cboCleaning.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCleaning.FooterStyle = Style27
        Me.cboCleaning.HeadingStyle = Style28
        Me.cboCleaning.HighLightRowStyle = Style29
        Me.cboCleaning.Images.Add(CType(resources.GetObject("cboCleaning.Images"), System.Drawing.Image))
        Me.cboCleaning.Location = New System.Drawing.Point(176, 208)
        Me.cboCleaning.Name = "cboCleaning"
        Me.cboCleaning.OddRowStyle = Style30
        Me.cboCleaning.RecordSelectorStyle = Style31
        Me.cboCleaning.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCleaning.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboCleaning.RowHeight = 20
        Me.cboCleaning.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCleaning.ScrollTips = False
        Me.cboCleaning.Size = New System.Drawing.Size(152, 278)
        Me.cboCleaning.Style = Style32
        Me.cboCleaning.TabIndex = 66
        Me.cboCleaning.Text = "C1TrueDBDropdown1"
        Me.cboCleaning.Visible = False
        Me.cboCleaning.PropBag = resources.GetString("cboCleaning.PropBag")
        '
        'cboSize
        '
        Me.cboSize.AllowColMove = True
        Me.cboSize.AllowColSelect = True
        Me.cboSize.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSize.AlternatingRows = False
        Me.cboSize.CaptionHeight = 17
        Me.cboSize.CaptionStyle = Style33
        Me.cboSize.ColumnCaptionHeight = 17
        Me.cboSize.ColumnFooterHeight = 17
        Me.cboSize.EvenRowStyle = Style34
        Me.cboSize.FetchRowStyles = False
        Me.cboSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSize.FooterStyle = Style35
        Me.cboSize.HeadingStyle = Style36
        Me.cboSize.HighLightRowStyle = Style37
        Me.cboSize.Images.Add(CType(resources.GetObject("cboSize.Images"), System.Drawing.Image))
        Me.cboSize.Location = New System.Drawing.Point(328, 208)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.OddRowStyle = Style38
        Me.cboSize.RecordSelectorStyle = Style39
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSize.RowHeight = 20
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.ScrollTips = False
        Me.cboSize.Size = New System.Drawing.Size(152, 278)
        Me.cboSize.Style = Style40
        Me.cboSize.TabIndex = 67
        Me.cboSize.Text = "C1TrueDBDropdown1"
        Me.cboSize.Visible = False
        Me.cboSize.PropBag = resources.GetString("cboSize.PropBag")
        '
        'txtConversion
        '
        Me.txtConversion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConversion.Location = New System.Drawing.Point(448, 150)
        Me.txtConversion.Name = "txtConversion"
        Me.txtConversion.Size = New System.Drawing.Size(216, 23)
        Me.txtConversion.TabIndex = 68
        Me.txtConversion.Text = "0.00"
        Me.txtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Converion (SBD)"
        '
        'lblTonnage
        '
        Me.lblTonnage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTonnage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTonnage.Location = New System.Drawing.Point(432, 86)
        Me.lblTonnage.Name = "lblTonnage"
        Me.lblTonnage.Size = New System.Drawing.Size(200, 24)
        Me.lblTonnage.TabIndex = 71
        Me.lblTonnage.Text = "0.000"
        Me.lblTonnage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(344, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 16)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Total Tonnage"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Est (mt)"
        '
        'txtMT
        '
        Me.txtMT.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMT.Location = New System.Drawing.Point(104, 150)
        Me.txtMT.Name = "txtMT"
        Me.txtMT.Size = New System.Drawing.Size(152, 23)
        Me.txtMT.TabIndex = 72
        Me.txtMT.Text = "0"
        Me.txtMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(636, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 16)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "mt"
        '
        'frmCOP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(670, 543)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMT)
        Me.Controls.Add(Me.lblTonnage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConversion)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboCleaning)
        Me.Controls.Add(Me.lblLot)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblVessel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboCOP)
        Me.Controls.Add(Me.cboCOS)
        Me.Controls.Add(Me.gridSublot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCOP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCOP"
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSublot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCleaning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmCOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()
        dataEntry(1)

        displayCOS()
        displayCOP()
        displayListsOfCOPDetails()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayCOS()
        With cboCOS
            .DataSource = modModule.getCOSNo().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130
        End With
    End Sub

    Public Sub displayCOP()
        With cboCOP
            .DataSource = modModule.getCOPNo().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130
        End With
    End Sub

    Private Sub cboCOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCOS.TextChanged
        displayCOSDetails(cboCOS.Text)

        'displayCOPDetails(cboCOP.Text, cboCOS.Text)
    End Sub

    Public Sub displayCOSDetails(ByVal cos As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_getCOS_Vessel"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@cos"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = cos

            cmd.Parameters.Add(p1)

            Dim drCode As SqlClient.SqlDataReader
            drCode = cmd.ExecuteReader

            If drCode.Read Then
                If Not drCode(0) Is DBNull.Value Then
                    lblVessel.Text = drCode.GetString(0)
                    lblLot.Text = drCode.GetString(1)
                Else
                    lblVessel.Text = ""
                    lblLot.Text = ""
                End If
            Else
                lblVessel.Text = ""
                lblLot.Text = ""
            End If

            drCode.Close()
            c.Close()

        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displayListsOfCOPDetails()
        With grid
            .DataSource = modModule.getListsCOPDetails(cboCOP.Text).Tables(0)
            .Columns(0).DropDown = cboSpecie
            .Splits(0).DisplayColumns(0).DropDownList = True
            .Columns(1).DropDown = cboCleaning
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Columns(2).DropDown = cboSize
            .Splits(0).DisplayColumns(2).DropDownList = True
            displaySpecie()
            displayCleaning()
            displaySize()

            .Splits(0).DisplayColumns(0).Width = 150
            .Splits(0).DisplayColumns(1).Width = 150
            .Splits(0).DisplayColumns(2).Width = 150
            .Splits(0).DisplayColumns(3).Width = 150
            .Columns(3).DefaultValue = "0.00"
            .Columns(3).NumberFormat = "###,##0.#0"
        End With
    End Sub

    'Public Sub displayCOPDetails(ByVal cop As String, ByVal cos As String)
    '    With grid
    '        .DataSource = getCOPDetails(cop, cos).Tables(0)
    '        .Columns(0).DropDown = cboProduct
    '        .Splits(0).DisplayColumns(0).DropDownList = True
    '        displayProduct()

    '        .Splits(0).DisplayColumns(0).Width = 300
    '        .Splits(0).DisplayColumns(1).Width = 180
    '        .Columns(1).DefaultValue = "0.00"
    '        .Columns(1).NumberFormat = "###,##0.#0"
    '    End With
    'End Sub

    Public Sub displaySpecie()
        With cboSpecie
            .DefColWidth = 130
            .DataSource = modModule.getFishSpecie().Tables(0)
        End With
    End Sub

    Public Sub displayCleaning()
        With cboCleaning
            .DefColWidth = 130
            .DataSource = modModule.getProductCleaningDescription().Tables(0)
        End With
    End Sub

    Public Sub displaySize()
        With cboSize
            .DefColWidth = 130
            .DataSource = modModule.getProductCanSize_PackType("Frozen Loins").Tables(0)
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
                cboCOS.ReadOnly = False
                cboCOP.ReadOnly = False
                txtDate.ReadOnly = False
                txtConversion.ReadOnly = False
                txtMT.ReadOnly = False
                grid.Enabled = True
            Case 1
                cboCOS.ReadOnly = True
                cboCOP.ReadOnly = True
                txtDate.ReadOnly = True
                txtConversion.ReadOnly = True
                txtMT.ReadOnly = True
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        cboCOP.ReadOnly = False
        cboCOS.Text = ""
        displayCOS()
        lblLot.Text = ""
        lblVessel.Text = ""
        cboCOP.Text = ""
        displayCOP()
        txtDate.Value = getServerDateTime()
        txtConversion.Text = "0.00"
        txtMT.Text = "0"

        displayListsOfCOPDetails()
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
                cboCOS.SelectAll()
                cboCOS.Focus()
            Case "&Save"
                If Not cboCOS.Text.Trim = "" And Not lblLot.Text.Trim = "" And Not cboCOP.Text.Trim = "" And _
                Not isDataEntryFieldsAreEmpty() And Not isItemsFoundDuplicate() And grid.RowCount > 0 And _
                Not CDbl(txtConversion.Text) = 0 Then
                    If Not validateCOP(cboCOP.Text.Trim) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewCOP(cboCOP.Text, cboCOS.Text, txtDate.Text, txtConversion.Text, txtMT.Text)

                            Dim index As Integer
                            While index < grid.RowCount

                                saveNewCOPDetails(cboCOP.Text, grid.Item(index, 0), grid.Item(index, 1), grid.Item(index, 2), grid.Item(index, 3))

                                index += 1
                            End While

                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("COP Number already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCOP.SelectAll()
                        cboCOP.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCOS.SelectAll()
                    cboCOS.Focus()
                End If
            Case "&Save "
                If Not cboCOS.Text.Trim = "" And grid.RowCount > 0 Then
                    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        updateCOP(cboCOP.Text, cboCOS.Text, txtDate.Text, txtConversion.Text, txtMT.Text)

                        deleteCOPDetails(cboCOP.Text)
                        Dim index As Integer
                        While index < grid.RowCount
                            saveNewCOPDetails(cboCOP.Text, grid.Item(index, 0), grid.Item(index, 1), grid.Item(index, 2), grid.Item(index, 3))

                            index += 1
                        End While

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
                    cboCOS.SelectAll()
                    cboCOS.Focus()
                End If
        End Select
    End Sub

    Public Function isDataEntryFieldsAreEmpty() As Boolean
        Try
            Dim ctr As Integer
            With grid
                While ctr < .RowCount
                    'If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or .Item(ctr, 2) Is DBNull.Value Then
                    If CStr(.Item(ctr, 0)).Equals("") Or CStr(.Item(ctr, 1)).Equals("") Or CStr(.Item(ctr, 2)).Equals("") Or CStr(.Item(ctr, 3)).Equals("") Then
                        MsgBox("Please check your data entry fields such as Items and price, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                    Else
                        Return False
                    End If

                    ctr += 1
                End While
            End With

            Return False
        Catch e As Exception
            MsgBox("Please check your data entry fields such as Product and Price, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
            Return True
        End Try
    End Function

    Public Function isItemsFoundDuplicate() As Boolean
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
                        If Not .Item(outer, 0) Is DBNull.Value And Not .Item(inner, 0) Is DBNull.Value Then
                            If .Item(outer, 0) = .Item(inner, 0) And .Item(outer, 1) = .Item(inner, 1) And .Item(outer, 2) = .Item(inner, 2) Then
                                MsgBox("You have a multiple entries of items in the lists." & Chr(13) & _
                                    "Please remove the " & .Item(outer, 0) & " on row " & inner + 1 & " in the grid", MsgBoxStyle.Exclamation, "Warning")
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
            MsgBox("Please check your data entry fields such as Product and Price, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
            Return True
        End Try
    End Function

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Contract of Purchase"
        f.searchType = 1
        f.displayAllCOP()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                cboCOP.Text = .Item(.Row, 0)
                cboCOS.Text = .Item(.Row, 1)
                txtDate.Value = .Item(.Row, 2)
                txtConversion.Text = .Item(.Row, 3)
                txtMT.Text = .Item(.Row, 8)

                displayListsOfCOPDetails()
                'displayCOPDetails(cboCOP.Text, cboCOS.Text)
            End If
        End With
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboCOP.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboCOP.ReadOnly = True
                    cboCOS.SelectAll()
                    cboCOS.Focus()
                Else
                    MsgBox("Pleas identify COP Number.", MsgBoxStyle.Critical, "Result: Found missing value.")
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

    Private Sub cboCOP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCOP.TextChanged
        displayListsOfCOPDetails()
        'displayCOPDetails(cboCOP.Text, cboCOS.Text)
    End Sub

    Private Sub mnuMCOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMCOS.Click
        Dim f As New frmCOS
        f.ShowDialog(Me)

        displayCOS()
        cboCOS.SelectAll()
        cboCOS.Focus()
    End Sub

    Private Sub mnuMPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMPD.Click
        Dim f As New frmProductDescription
        f.ShowDialog(Me)

        displaySpecie()
        grid.Focus()
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick

    End Sub

    Private Sub txtConversion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConversion.TextChanged
        If Not IsNumeric(txtConversion.Text) Or txtConversion.Text = "" Then
            txtConversion.Text = "0"
            txtConversion.SelectAll()
            txtConversion.Focus()
        End If
    End Sub

    Private Sub txtMT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMT.TextChanged
        If Not IsNumeric(txtMT.Text) Or txtMT.Text = "" Then
            txtMT.Text = "0"
            txtMT.SelectAll()
            txtMT.Focus()
        End If
    End Sub

    Private Sub lblLot_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLot.TextChanged
        lblTonnage.Text = Format(getLotTotalTonnage(lblLot.Text), "###,###,###,##0.#0")
    End Sub
End Class
