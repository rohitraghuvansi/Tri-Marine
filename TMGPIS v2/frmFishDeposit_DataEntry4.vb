Public Class frmFishDeposit_DataEntry4
    Inherits System.Windows.Forms.Form

    Dim currRecord, prevRecord As Integer
    Friend WithEvents cboSublot2 As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboSpecie As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents lblSub2 As System.Windows.Forms.Label
    Public Shared depositDateAndTime As Date
    Dim page As Integer
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblReceipt As System.Windows.Forms.Label
    Friend WithEvents lblTripCode As System.Windows.Forms.Label
    Friend WithEvents cboLot As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboBin As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboOwner As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboSize As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboCS As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents lblRow As System.Windows.Forms.Label
    Friend WithEvents cmdScale As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCS As System.Windows.Forms.Button
    Friend WithEvents cmdLot As System.Windows.Forms.Button
    Friend WithEvents gridDetails As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblVessel As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As C1.Win.C1BarCode.C1BarCode
    Friend WithEvents lblDepositCode As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSublot As System.Windows.Forms.Label
    Friend WithEvents lblSpecie As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblBin As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblNW As System.Windows.Forms.Label
    Friend WithEvents lblCSStack As System.Windows.Forms.Label
    Friend WithEvents lblCSRow As System.Windows.Forms.Label
    Friend WithEvents lblCSLane As System.Windows.Forms.Label
    Friend WithEvents lblCS As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFishDeposit_DataEntry4))
        Dim Style57 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style58 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style59 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style60 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style61 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style62 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style63 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style64 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style65 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style66 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style67 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style68 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style69 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style70 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style71 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style72 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style73 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style74 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style75 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style76 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style77 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style78 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style79 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style80 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style81 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style82 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style83 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style84 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style85 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style86 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style87 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style88 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style89 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style90 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style91 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style92 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style93 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style94 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style95 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style96 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style97 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style98 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style99 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style100 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style101 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style102 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style103 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style104 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style105 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style106 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style107 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style108 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style109 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style110 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style111 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style112 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.cmdScale = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdCS = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.lblTripCode = New System.Windows.Forms.Label()
        Me.cboLot = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboBin = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboOwner = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cmdLot = New System.Windows.Forms.Button()
        Me.cboSize = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboCS = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.gridDetails = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblVessel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBarcode = New C1.Win.C1BarCode.C1BarCode()
        Me.lblDepositCode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCSStack = New System.Windows.Forms.Label()
        Me.lblCSRow = New System.Windows.Forms.Label()
        Me.lblCSLane = New System.Windows.Forms.Label()
        Me.lblCS = New System.Windows.Forms.Label()
        Me.lblNW = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblBin = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblSpecie = New System.Windows.Forms.Label()
        Me.lblSublot = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cboSublot2 = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBin = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboSpecie = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.lblSub2 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboSublot2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdScale
        '
        Me.cmdScale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdScale.Image = CType(resources.GetObject("cmdScale.Image"), System.Drawing.Image)
        Me.cmdScale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdScale.Location = New System.Drawing.Point(344, 504)
        Me.cmdScale.Name = "cmdScale"
        Me.cmdScale.Size = New System.Drawing.Size(120, 48)
        Me.cmdScale.TabIndex = 18
        Me.cmdScale.TabStop = False
        Me.cmdScale.Text = "Read Scale"
        Me.cmdScale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(216, 504)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(120, 48)
        Me.cmdPrint.TabIndex = 17
        Me.cmdPrint.TabStop = False
        Me.cmdPrint.Text = "&Print Label"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(88, 504)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(120, 48)
        Me.cmdDelete.TabIndex = 16
        Me.cmdDelete.TabStop = False
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdCS
        '
        Me.cmdCS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCS.Image = CType(resources.GetObject("cmdCS.Image"), System.Drawing.Image)
        Me.cmdCS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCS.Location = New System.Drawing.Point(8, 504)
        Me.cmdCS.Name = "cmdCS"
        Me.cmdCS.Size = New System.Drawing.Size(75, 48)
        Me.cmdCS.TabIndex = 15
        Me.cmdCS.TabStop = False
        Me.cmdCS.Text = "CS &Map"
        Me.cmdCS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(981, 40)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "Fish Receiving - Receipt Details"
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(7, 96)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(970, 336)
        Me.grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.grid.TabIndex = 109
        Me.grid.Text = "C1TrueDBGrid1"
        Me.ToolTip1.SetToolTip(Me.grid, "Press F1 to display the Cold Storage Map")
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Receipt No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Trip Code"
        '
        'lblReceipt
        '
        Me.lblReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReceipt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.Location = New System.Drawing.Point(88, 54)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(77, 24)
        Me.lblReceipt.TabIndex = 113
        '
        'lblTripCode
        '
        Me.lblTripCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTripCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTripCode.Location = New System.Drawing.Point(288, 54)
        Me.lblTripCode.Name = "lblTripCode"
        Me.lblTripCode.Size = New System.Drawing.Size(240, 24)
        Me.lblTripCode.TabIndex = 114
        '
        'cboLot
        '
        Me.cboLot.AllowColMove = True
        Me.cboLot.AllowColSelect = True
        Me.cboLot.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboLot.AlternatingRows = False
        Me.cboLot.CaptionStyle = Style57
        Me.cboLot.ColumnCaptionHeight = 17
        Me.cboLot.ColumnFooterHeight = 17
        Me.cboLot.EvenRowStyle = Style58
        Me.cboLot.FetchRowStyles = False
        Me.cboLot.FooterStyle = Style59
        Me.cboLot.HeadingStyle = Style60
        Me.cboLot.HighLightRowStyle = Style61
        Me.cboLot.Images.Add(CType(resources.GetObject("cboLot.Images"), System.Drawing.Image))
        Me.cboLot.Location = New System.Drawing.Point(8, 96)
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style62
        Me.cboLot.RecordSelectorStyle = Style63
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboLot.RowHeight = 20
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.ScrollTips = False
        Me.cboLot.Size = New System.Drawing.Size(106, 336)
        Me.cboLot.Style = Style64
        Me.cboLot.TabIndex = 115
        Me.cboLot.Text = "C1TrueDBDropdown1"
        Me.cboLot.Visible = False
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'cboBin
        '
        Me.cboBin.AllowColMove = True
        Me.cboBin.AllowColSelect = True
        Me.cboBin.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboBin.AlternatingRows = False
        Me.cboBin.CaptionStyle = Style65
        Me.cboBin.ColumnCaptionHeight = 17
        Me.cboBin.ColumnFooterHeight = 17
        Me.cboBin.EvenRowStyle = Style66
        Me.cboBin.FetchRowStyles = False
        Me.cboBin.FooterStyle = Style67
        Me.cboBin.HeadingStyle = Style68
        Me.cboBin.HighLightRowStyle = Style69
        Me.cboBin.Images.Add(CType(resources.GetObject("cboBin.Images"), System.Drawing.Image))
        Me.cboBin.Location = New System.Drawing.Point(440, 96)
        Me.cboBin.Name = "cboBin"
        Me.cboBin.OddRowStyle = Style70
        Me.cboBin.RecordSelectorStyle = Style71
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboBin.RowHeight = 20
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.ScrollTips = False
        Me.cboBin.Size = New System.Drawing.Size(88, 336)
        Me.cboBin.Style = Style72
        Me.cboBin.TabIndex = 116
        Me.cboBin.Text = "C1TrueDBDropdown2"
        Me.cboBin.Visible = False
        Me.cboBin.PropBag = resources.GetString("cboBin.PropBag")
        '
        'cboOwner
        '
        Me.cboOwner.AllowColMove = True
        Me.cboOwner.AllowColSelect = True
        Me.cboOwner.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboOwner.AlternatingRows = False
        Me.cboOwner.CaptionStyle = Style73
        Me.cboOwner.ColumnCaptionHeight = 17
        Me.cboOwner.ColumnFooterHeight = 17
        Me.cboOwner.EvenRowStyle = Style74
        Me.cboOwner.FetchRowStyles = False
        Me.cboOwner.FooterStyle = Style75
        Me.cboOwner.HeadingStyle = Style76
        Me.cboOwner.HighLightRowStyle = Style77
        Me.cboOwner.Images.Add(CType(resources.GetObject("cboOwner.Images"), System.Drawing.Image))
        Me.cboOwner.Location = New System.Drawing.Point(1056, 96)
        Me.cboOwner.Name = "cboOwner"
        Me.cboOwner.OddRowStyle = Style78
        Me.cboOwner.RecordSelectorStyle = Style79
        Me.cboOwner.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboOwner.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboOwner.RowHeight = 20
        Me.cboOwner.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboOwner.ScrollTips = False
        Me.cboOwner.Size = New System.Drawing.Size(144, 336)
        Me.cboOwner.Style = Style80
        Me.cboOwner.TabIndex = 117
        Me.cboOwner.Text = "C1TrueDBDropdown3"
        Me.cboOwner.Visible = False
        Me.cboOwner.PropBag = resources.GetString("cboOwner.PropBag")
        '
        'cmdLot
        '
        Me.cmdLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLot.Image = CType(resources.GetObject("cmdLot.Image"), System.Drawing.Image)
        Me.cmdLot.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLot.Location = New System.Drawing.Point(472, 504)
        Me.cmdLot.Name = "cmdLot"
        Me.cmdLot.Size = New System.Drawing.Size(120, 48)
        Me.cmdLot.TabIndex = 118
        Me.cmdLot.TabStop = False
        Me.cmdLot.Text = "Lot &Id"
        Me.cmdLot.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cboSize
        '
        Me.cboSize.AllowColMove = True
        Me.cboSize.AllowColSelect = True
        Me.cboSize.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSize.AlternatingRows = False
        Me.cboSize.CaptionStyle = Style81
        Me.cboSize.ColumnCaptionHeight = 17
        Me.cboSize.ColumnFooterHeight = 17
        Me.cboSize.EvenRowStyle = Style82
        Me.cboSize.FetchRowStyles = False
        Me.cboSize.FooterStyle = Style83
        Me.cboSize.HeadingStyle = Style84
        Me.cboSize.HighLightRowStyle = Style85
        Me.cboSize.Images.Add(CType(resources.GetObject("cboSize.Images"), System.Drawing.Image))
        Me.cboSize.Location = New System.Drawing.Point(264, 96)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.OddRowStyle = Style86
        Me.cboSize.RecordSelectorStyle = Style87
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSize.RowHeight = 20
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.ScrollTips = False
        Me.cboSize.Size = New System.Drawing.Size(106, 336)
        Me.cboSize.Style = Style88
        Me.cboSize.TabIndex = 119
        Me.cboSize.Text = "C1TrueDBDropdown1"
        Me.cboSize.Visible = False
        Me.cboSize.PropBag = resources.GetString("cboSize.PropBag")
        '
        'cboCS
        '
        Me.cboCS.AllowColMove = True
        Me.cboCS.AllowColSelect = True
        Me.cboCS.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboCS.AlternatingRows = False
        Me.cboCS.CaptionStyle = Style89
        Me.cboCS.ColumnCaptionHeight = 17
        Me.cboCS.ColumnFooterHeight = 17
        Me.cboCS.EvenRowStyle = Style90
        Me.cboCS.FetchRowStyles = False
        Me.cboCS.FooterStyle = Style91
        Me.cboCS.HeadingStyle = Style92
        Me.cboCS.HighLightRowStyle = Style93
        Me.cboCS.Images.Add(CType(resources.GetObject("cboCS.Images"), System.Drawing.Image))
        Me.cboCS.Location = New System.Drawing.Point(592, 96)
        Me.cboCS.Name = "cboCS"
        Me.cboCS.OddRowStyle = Style94
        Me.cboCS.RecordSelectorStyle = Style95
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboCS.RowHeight = 20
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.ScrollTips = False
        Me.cboCS.Size = New System.Drawing.Size(136, 336)
        Me.cboCS.Style = Style96
        Me.cboCS.TabIndex = 120
        Me.cboCS.Text = "C1TrueDBDropdown1"
        Me.cboCS.Visible = False
        Me.cboCS.PropBag = resources.GetString("cboCS.PropBag")
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow.Location = New System.Drawing.Point(600, 440)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(15, 16)
        Me.lblRow.TabIndex = 121
        Me.lblRow.Text = "0"
        Me.lblRow.Visible = False
        '
        'gridDetails
        '
        Me.gridDetails.AllowColMove = False
        Me.gridDetails.AllowUpdate = False
        Me.gridDetails.CaptionHeight = 17
        Me.gridDetails.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDetails.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridDetails.Images.Add(CType(resources.GetObject("gridDetails.Images"), System.Drawing.Image))
        Me.gridDetails.Location = New System.Drawing.Point(744, 440)
        Me.gridDetails.Name = "gridDetails"
        Me.gridDetails.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridDetails.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridDetails.PreviewInfo.ZoomFactor = 75.0R
        Me.gridDetails.PrintInfo.PageSettings = CType(resources.GetObject("gridDetails.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridDetails.RowHeight = 20
        Me.gridDetails.Size = New System.Drawing.Size(233, 110)
        Me.gridDetails.TabIndex = 122
        Me.gridDetails.TabStop = False
        Me.gridDetails.Text = "C1TrueDBGrid1"
        Me.gridDetails.PropBag = resources.GetString("gridDetails.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(648, 441)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Fish Lot Metrics"
        '
        'lblVessel
        '
        Me.lblVessel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVessel.Location = New System.Drawing.Point(655, 54)
        Me.lblVessel.Name = "lblVessel"
        Me.lblVessel.Size = New System.Drawing.Size(227, 24)
        Me.lblVessel.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(560, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Fishing Vessel"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(688, 488)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(128, 24)
        Me.txtBarcode.TabIndex = 126
        Me.txtBarcode.TabStop = False
        Me.txtBarcode.Text = "C1BarCode1"
        Me.txtBarcode.Visible = False
        '
        'lblDepositCode
        '
        Me.lblDepositCode.AutoSize = True
        Me.lblDepositCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepositCode.Location = New System.Drawing.Point(616, 464)
        Me.lblDepositCode.Name = "lblDepositCode"
        Me.lblDepositCode.Size = New System.Drawing.Size(0, 16)
        Me.lblDepositCode.TabIndex = 127
        Me.lblDepositCode.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCSStack)
        Me.GroupBox1.Controls.Add(Me.lblCSRow)
        Me.GroupBox1.Controls.Add(Me.lblCSLane)
        Me.GroupBox1.Controls.Add(Me.lblCS)
        Me.GroupBox1.Controls.Add(Me.lblNW)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblBin)
        Me.GroupBox1.Controls.Add(Me.lblSize)
        Me.GroupBox1.Controls.Add(Me.lblSpecie)
        Me.GroupBox1.Controls.Add(Me.lblSublot)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 80)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'lblCSStack
        '
        Me.lblCSStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCSStack.Location = New System.Drawing.Point(464, 48)
        Me.lblCSStack.Name = "lblCSStack"
        Me.lblCSStack.Size = New System.Drawing.Size(100, 23)
        Me.lblCSStack.TabIndex = 9
        '
        'lblCSRow
        '
        Me.lblCSRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCSRow.Location = New System.Drawing.Point(464, 16)
        Me.lblCSRow.Name = "lblCSRow"
        Me.lblCSRow.Size = New System.Drawing.Size(100, 23)
        Me.lblCSRow.TabIndex = 8
        '
        'lblCSLane
        '
        Me.lblCSLane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCSLane.Location = New System.Drawing.Point(352, 48)
        Me.lblCSLane.Name = "lblCSLane"
        Me.lblCSLane.Size = New System.Drawing.Size(100, 23)
        Me.lblCSLane.TabIndex = 7
        '
        'lblCS
        '
        Me.lblCS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCS.Location = New System.Drawing.Point(352, 16)
        Me.lblCS.Name = "lblCS"
        Me.lblCS.Size = New System.Drawing.Size(100, 23)
        Me.lblCS.TabIndex = 6
        '
        'lblNW
        '
        Me.lblNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNW.Location = New System.Drawing.Point(240, 48)
        Me.lblNW.Name = "lblNW"
        Me.lblNW.Size = New System.Drawing.Size(100, 23)
        Me.lblNW.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(240, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 23)
        Me.lblDate.TabIndex = 4
        '
        'lblBin
        '
        Me.lblBin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBin.Location = New System.Drawing.Point(128, 48)
        Me.lblBin.Name = "lblBin"
        Me.lblBin.Size = New System.Drawing.Size(100, 23)
        Me.lblBin.TabIndex = 3
        '
        'lblSize
        '
        Me.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSize.Location = New System.Drawing.Point(128, 16)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(100, 23)
        Me.lblSize.TabIndex = 2
        '
        'lblSpecie
        '
        Me.lblSpecie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpecie.Location = New System.Drawing.Point(16, 48)
        Me.lblSpecie.Name = "lblSpecie"
        Me.lblSpecie.Size = New System.Drawing.Size(100, 23)
        Me.lblSpecie.TabIndex = 1
        '
        'lblSublot
        '
        Me.lblSublot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSublot.Location = New System.Drawing.Point(16, 16)
        Me.lblSublot.Name = "lblSublot"
        Me.lblSublot.Size = New System.Drawing.Size(100, 23)
        Me.lblSublot.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(600, 504)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 159
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cboSublot2
        '
        Me.cboSublot2.AllowColMove = True
        Me.cboSublot2.AllowColSelect = True
        Me.cboSublot2.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSublot2.AlternatingRows = False
        Me.cboSublot2.CaptionStyle = Style97
        Me.cboSublot2.ColumnCaptionHeight = 17
        Me.cboSublot2.ColumnFooterHeight = 17
        Me.cboSublot2.EvenRowStyle = Style98
        Me.cboSublot2.FetchRowStyles = False
        Me.cboSublot2.FooterStyle = Style99
        Me.cboSublot2.HeadingStyle = Style100
        Me.cboSublot2.HighLightRowStyle = Style101
        Me.cboSublot2.Images.Add(CType(resources.GetObject("cboSublot2.Images"), System.Drawing.Image))
        Me.cboSublot2.Location = New System.Drawing.Point(111, 96)
        Me.cboSublot2.Name = "cboSublot2"
        Me.cboSublot2.OddRowStyle = Style102
        Me.cboSublot2.RecordSelectorStyle = Style103
        Me.cboSublot2.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSublot2.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSublot2.RowHeight = 20
        Me.cboSublot2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSublot2.ScrollTips = False
        Me.cboSublot2.Size = New System.Drawing.Size(106, 336)
        Me.cboSublot2.Style = Style104
        Me.cboSublot2.TabIndex = 160
        Me.cboSublot2.Text = "C1TrueDBDropdown1"
        Me.cboSublot2.Visible = False
        Me.cboSublot2.PropBag = resources.GetString("cboSublot2.PropBag")
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner.Location = New System.Drawing.Point(616, 439)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(0, 16)
        Me.lblOwner.TabIndex = 161
        Me.lblOwner.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSize, Me.mnuBin})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 48)
        '
        'mnuSize
        '
        Me.mnuSize.Name = "mnuSize"
        Me.mnuSize.Size = New System.Drawing.Size(126, 22)
        Me.mnuSize.Text = "Fish Size"
        '
        'mnuBin
        '
        Me.mnuBin.Name = "mnuBin"
        Me.mnuBin.Size = New System.Drawing.Size(126, 22)
        Me.mnuBin.Text = "Fish Bin"
        '
        'cboSpecie
        '
        Me.cboSpecie.AllowColMove = True
        Me.cboSpecie.AllowColSelect = True
        Me.cboSpecie.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSpecie.AlternatingRows = False
        Me.cboSpecie.CaptionStyle = Style105
        Me.cboSpecie.ColumnCaptionHeight = 17
        Me.cboSpecie.ColumnFooterHeight = 17
        Me.cboSpecie.EvenRowStyle = Style106
        Me.cboSpecie.FetchRowStyles = False
        Me.cboSpecie.FooterStyle = Style107
        Me.cboSpecie.HeadingStyle = Style108
        Me.cboSpecie.HighLightRowStyle = Style109
        Me.cboSpecie.Images.Add(CType(resources.GetObject("cboSpecie.Images"), System.Drawing.Image))
        Me.cboSpecie.Location = New System.Drawing.Point(59, 96)
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.OddRowStyle = Style110
        Me.cboSpecie.RecordSelectorStyle = Style111
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSpecie.RowHeight = 20
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.ScrollTips = False
        Me.cboSpecie.Size = New System.Drawing.Size(106, 336)
        Me.cboSpecie.Style = Style112
        Me.cboSpecie.TabIndex = 162
        Me.cboSpecie.Text = "C1TrueDBDropdown1"
        Me.cboSpecie.Visible = False
        Me.cboSpecie.PropBag = resources.GetString("cboSpecie.PropBag")
        '
        'lblSub2
        '
        Me.lblSub2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSub2.Location = New System.Drawing.Point(24, 358)
        Me.lblSub2.Name = "lblSub2"
        Me.lblSub2.Size = New System.Drawing.Size(100, 23)
        Me.lblSub2.TabIndex = 10
        Me.lblSub2.Visible = False
        '
        'frmFishDeposit_DataEntry4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(981, 555)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSub2)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.cboSublot2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblDepositCode)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.gridDetails)
        Me.Controls.Add(Me.lblVessel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.cboCS)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cmdLot)
        Me.Controls.Add(Me.cboOwner)
        Me.Controls.Add(Me.cboBin)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.lblReceipt)
        Me.Controls.Add(Me.lblTripCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdScale)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdCS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFishDeposit_DataEntry4"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOwner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cboSublot2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFishDeposit_DataEntry4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
    End Sub

    Public Sub displayReceiptDetails(ByVal fr As String)
        With grid
            .DataSource = getFishReceivingReceiptsDetails(fr).Tables(0)
            .Columns(0).DropDown = cboLot
            .Columns(0).FilterDropdown = True
            displaySublot(lblTripCode.Text)
            '.Columns(1).DropDown = cboSpecie
            'displaySpecie("", "")
            .Columns(2).DropDown = cboSublot2
            .Columns(2).FilterDropdown = True
            'displaySublot2()
            .Columns(3).DropDown = cboSize
            .Columns(3).FilterDropdown = True
            displayFishSizes()
            .Columns(4).DropDown = cboBin
            displayFishBins()
            .Columns(8).DropDown = cboCS
            .Columns(8).FilterDropdown = True
            displayColdStorage()
            .Columns(12).DropDown = cboOwner
            .Columns(12).FilterDropdown = True
            displayFishOwner()

            .Columns(5).DefaultValue = "0"
            .Columns(5).NumberFormat = "###,###,##0"
            .Columns(6).DefaultValue = "0"
            .Columns(6).NumberFormat = "###,###,##0"
            .Columns(7).DefaultValue = "0"
            .Columns(7).NumberFormat = "###,###,##0"
            .Columns(13).DefaultValue = 0
            .Columns(13).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            .Splits(0).DisplayColumns(13).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            .Splits(0).DisplayColumns(0).DropDownList = True
            .Splits(0).DisplayColumns(2).DropDownList = True
            .Splits(0).DisplayColumns(3).DropDownList = True
            .Splits(0).DisplayColumns(8).DropDownList = True
            '.Splits(0).DisplayColumns(11).DropDownList = True
            .Splits(0).DisplayColumns(12).DropDownList = True

            .Splits(0).DisplayColumns(1).Locked = True
            .Splits(0).DisplayColumns(6).Locked = True
            .Splits(0).DisplayColumns(7).Locked = True
            '.Splits(0).DisplayColumns(9).Locked = True
            '.Splits(0).DisplayColumns(10).Locked = True
            .Splits(0).DisplayColumns(11).Locked = True

            .Splits(0).DisplayColumns(1).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(6).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(7).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(9).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(10).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(11).Style.BackColor = Color.Gray

            .Splits(0).DisplayColumns(0).Width = 70
            .Splits(0).DisplayColumns(1).Width = 75
            .Splits(0).DisplayColumns(2).Width = 45
            .Splits(0).DisplayColumns(3).Width = 80
            .Splits(0).DisplayColumns(4).Width = 50
            .Splits(0).DisplayColumns(5).Width = 50
            .Splits(0).DisplayColumns(6).Width = 30
            .Splits(0).DisplayColumns(7).Width = 50
            .Splits(0).DisplayColumns(8).Width = 90
            .Splits(0).DisplayColumns(9).Width = 40
            .Splits(0).DisplayColumns(10).Width = 40
            .Splits(0).DisplayColumns(11).Width = 40
            .Splits(0).DisplayColumns(14).Width = 145
            .Splits(0).DisplayColumns(13).Width = 20
            .Splits(0).DisplayColumns(12).Width = 90
        End With
    End Sub

    Public Sub displayFishBins()
        With cboBin
            .DefColWidth = 60
            .DataSource = modModule.getAllFishBins_AvailableForDeposit().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 99
        End With
    End Sub

    Public Sub displaySublot(ByVal lot As String)
        With cboLot
            '.Text = ""
            .DataSource = modModule.getFishLot_MethodAndVesselInfo(lot).Tables(0)

            '.Splits(0).DisplayColumns(0).Width = 105
            '.Splits(0).DisplayColumns(1).Width = 105

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displaySpecie(ByVal lot As String, ByVal sublot As String)
        With cboSpecie
            '.Text = ""
            .DataSource = getLotSpecieDetails(lot, sublot).Tables(0)

            '.Splits(0).DisplayColumns(0).Width = 105
            '.Splits(0).DisplayColumns(1).Width = 105

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub populateDetails()
        'Try
        '    With grid
        '        Dim ctr As Integer = 0
        '        While ctr < .RowCount
        '            If Not .Item(ctr, 0) Is DBNull.Value Then
        '                Dim sublot2 As String
        '                If .Item(ctr, 2) Is DBNull.Value Then
        '                    sublot2 = ""
        '                Else
        '                    sublot2 = .Item(ctr, 2)
        '                End If

        '                .Item(ctr, 1) = getSublotDetails(lblTripCode.Text, .Item(ctr, 0), "0", sublot2)

        '                'displaySpecie(lblTripCode.Text, .Item(ctr, 0))

        '                cboSublot2.DataSource = getSublotDetails(lblTripCode.Text, .Item(ctr, 0)).Tables(0)
        '                '.Item(ctr, 2) = getSublotDetails(lblTripCode.Text, .Item(ctr, 0), "1")

        '                If Not getSublotDetails(lblTripCode.Text, .Item(ctr, 0), "2", sublot2) = "" Then .Item(ctr, 3) = getSublotDetails(lblTripCode.Text, .Item(ctr, 0), "2", sublot2)
        '            End If

        '            If .Item(ctr, 4) Is DBNull.Value Then
        '                .Item(ctr, 6) = getFishBinTareWeight("")
        '            Else
        '                .Item(ctr, 6) = getFishBinTareWeight(.Item(ctr, 4))
        '            End If

        '            Try
        '                If Not IsNumeric(.Item(ctr, 5)) Or .Item(ctr, 5) Is DBNull.Value Then .Item(ctr, 5) = 0
        '            Catch
        '                .Item(ctr, 5) = 0
        '            End Try

        '            .Item(ctr, 7) = .Item(ctr, 5) - .Item(ctr, 6)

        '            'If prevRecord > 0 And Not prevRecord > .RowCount Then .Item(prevRecord, 12) = .Item(prevRecord - 1, 12)

        '            ctr += 1
        '        End While
        '    End With
        'Catch

        'Finally
        'End Try

        Try
            With grid
                Dim ctr As Integer = prevRecord

                If Not .Item(ctr, 0) = "" Then

                    If Not .Item(ctr, 0) Is DBNull.Value Then
                        Dim sublot2 As String
                        If .Item(ctr, 2) Is DBNull.Value Then
                            sublot2 = ""
                        Else
                            sublot2 = .Item(ctr, 2)
                        End If

                        .Item(ctr, 1) = getSublotDetails(lblTripCode.Text, .Item(ctr, 0), "0", sublot2)

                        'displaySpecie(lblTripCode.Text, .Item(ctr, 0))

                        cboSublot2.DataSource = getSublotDetails(lblTripCode.Text, .Item(ctr, 0)).Tables(0)
                        '.Item(ctr, 2) = getSublotDetails(lblTripCode.Text, .Item(ctr, 0), "1")

                        If Not getSublotDetails(lblTripCode.Text, .Item(ctr, 0), "2", sublot2) = "" Then .Item(ctr, 3) = getSublotDetails(lblTripCode.Text, .Item(ctr, 0), "2", sublot2)

                    End If

                    'Try
                    '    If .Item(ctr, 4) Is DBNull.Value Then
                    '        .Item(ctr, 6) = getFishBinTareWeight("")
                    '    Else
                    '        .Item(ctr, 6) = getFishBinTareWeight(.Item(ctr, 4))
                    '    End If
                    'Catch
                    '    If .Item(ctr, 4) = "" Then
                    '        .Item(ctr, 6) = getFishBinTareWeight("")
                    '    Else
                    '        .Item(ctr, 6) = getFishBinTareWeight(.Item(ctr, 4))
                    '    End If
                    'End Try

                    Try
                        If .Item(ctr, 4) Is DBNull.Value Then .Item(ctr, 4) = ""
                    Catch
                        If .Item(ctr, 4) = "" Then .Item(ctr, 4) = ""
                    End Try

                    'If Not .Item(ctr, 4) = "" Then
                    '    If validateFishBins(.Item(ctr, 4)) Then
                    '        MsgBox("Please make sure that you're using fish bin that exists in the system", MsgBoxStyle.Exclamation, "Warning")
                    '        .Col = 4
                    '    End If
                    'End If

                    .Item(ctr, 6) = getFishBinTareWeight(.Item(ctr, 4))

                    Try
                        If Not IsNumeric(.Item(ctr, 5)) Or .Item(ctr, 5) Is DBNull.Value Then .Item(ctr, 5) = 0

                        If .Item(ctr, 5) > 2000 Then
                            MsgBox("Please verify and confirm the weight of the fish bin, it must not be greater than 2MT", MsgBoxStyle.Exclamation, "Warning")
                            .Item(ctr, 5) = "0"
                            .Col = 5
                        End If

                    Catch
                        .Item(ctr, 5) = 0
                    End Try

                    .Item(ctr, 7) = .Item(ctr, 5) - .Item(ctr, 6)
                End If
            End With
        Catch
        End Try

    End Sub

    Private Sub grid_BeforeRowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grid.BeforeRowColChange
        'With grid
        '    Try
        '        If .Item(prevRecord, 4) Is DBNull.Value Then
        '            cmdPrint.Enabled = False
        '        Else
        '            cmdPrint.Enabled = True
        '        End If
        '    Catch
        '        If .Item(prevRecord, 4) = "" Then
        '            cmdPrint.Enabled = False
        '        Else
        '            cmdPrint.Enabled = True
        '        End If
        '    End Try
        'End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        With grid
            'grid.Item(prevRecord, 13) = 0

            displayReceiptSummary(lblTripCode.Text) '(Me.lblReceipt.Text)

            populateDetails()

            If prevRecord > 0 And Not prevRecord > .RowCount Then .Item(prevRecord, 12) = .Item(prevRecord - 1, 12)


        End With
    End Sub

    Public Sub displayBarcodeTag(ByVal bin As String)
        'Dim bin As String
        'With grid
        '    If .RowCount > 0 Then
        '        If .Item(.Row, 4) Is DBNull.Value Then
        '            bin = ""
        '        Else
        '            bin = .Item(.Row, 4)
        '        End If

        lblDepositCode.Text = bin 'getDepositCode(.Item(.Row, 4))
        txtBarcode.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code39 'Code128
        txtBarcode.Text = bin 'getDepositCode(.Item(.Row, 4))

        'lblSublot.Text = .Item(.Row, 0)
        'lblSub2.Text = .Item(.Row, 2)
        '/lblSpecie.Text = getSpecieCode(.Item(.Row, 1))
        '/lblSize.Text = .Item(.Row, 3)
        'lblBin.Text = bin
        'lblDate.Text = getServerDateTime()
        '/lblNW.Text = .Item(.Row, 7)
        '/lblCS.Text = .Item(.Row, 8)
        '/lblCSLane.Text = .Item(.Row, 9)
        '/lblCSRow.Text = .Item(.Row, 10)
        '/lblCSStack.Text = .Item(.Row, 11)
        '    Else
        'lblDepositCode.Text = ""
        'txtBarcode.Text = ""
        'lblSublot.Text = ""
        'lblSpecie.Text = ""
        'lblSize.Text = ""
        'lblBin.Text = ""
        'lblDate.Text = getServerDateTime()
        'lblNW.Text = ""
        'lblCS.Text = ""
        'lblCSLane.Text = ""
        'lblCSRow.Text = ""
        'lblCSStack.Text = ""
        '    End If
        'End With

        getFishBinDepositedDetails(lblTripCode.Text, bin)
        displayBinLocations(bin, lblTripCode.Text)

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
                    lblSublot.Text = dr.GetString(7)
                    lblSub2.Text = dr.GetString(9)
                    lblSpecie.Text = dr.GetString(1)
                    lblSize.Text = dr.GetString(2)
                    lblNW.Text = dr.GetDouble(4)
                    lblBin.Text = bin
                    lblDate.Text = depositDateAndTime
                Else
                    lblSublot.Text = ""
                    lblSub2.Text = ""
                    lblSpecie.Text = ""
                    lblSize.Text = ""
                    lblBin.Text = ""
                    lblDate.Text = ""
                    lblNW.Text = "0"
                End If
            Else
                lblSublot.Text = ""
                lblSub2.Text = ""
                lblSpecie.Text = ""
                lblSize.Text = ""
                lblBin.Text = ""
                lblDate.Text = ""
                lblNW.Text = "0"
            End If

            dr.Close()
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
                    lblCS.Text = dr.GetString(0)
                    lblCSLane.Text = dr.GetString(1)
                    lblCSRow.Text = dr.GetString(2)
                    lblCSStack.Text = dr.GetString(3)
                Else
                    lblCS.Text = ""
                    lblCSLane.Text = ""
                    lblCSRow.Text = ""
                    lblCSStack.Text = ""
                End If
            Else
                lblCS.Text = ""
                lblCSLane.Text = ""
                lblCSRow.Text = ""
                lblCSStack.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub
    Public Sub displayFishSizes()
        With cboSize
            .DefColWidth = 80
            .DataSource = modModule.getFishSizeRanges().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishOwner()
        With cboOwner
            .DefColWidth = 150
            .DataSource = modModule.getOwner().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 99
        End With
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DefColWidth = 120
            .DataSource = modModule.getColdStorage().Tables(0)
        End With
    End Sub

    Public Function allFieldsAreFilled() As Boolean
        With grid
            Dim ctr As Integer
            Try
                While ctr < .RowCount
                    If .Item(ctr, 0) = "" Or .Item(ctr, 3) = "" Or .Item(ctr, 4) = "" Or _
                    .Item(ctr, 5) = "" Or .Item(ctr, 6) = "" Or _
                    .Item(ctr, 7) = "" Or .Item(ctr, 8) = "" Or .Item(ctr, 12) = "" Then
                        Return False
                    End If

                    ctr += 1
                End While

                Return True
            Catch ex As Exception
                While ctr < .RowCount
                    If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 3) Is DBNull.Value Or .Item(ctr, 4) Is DBNull.Value Or _
                   .Item(ctr, 5) Is DBNull.Value Or .Item(ctr, 6) Is DBNull.Value Or _
                   .Item(ctr, 7) Is DBNull.Value Or .Item(ctr, 8) Is DBNull.Value Or _
                   .Item(ctr, 12) Is DBNull.Value Then
                        Return False
                    End If

                    ctr += 1
                End While

                Return True
            End Try
        End With
    End Function

    Public Function noZeroQuantity() As Boolean
        With grid
            Dim ctr As Integer
            Try
                While ctr < .RowCount
                    If CDbl(.Item(ctr, 7)) <= 0 Then Return False

                    ctr += 1
                End While

                Return True
            Catch ex As Exception

            End Try
        End With
    End Function

    Private Sub grid_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.Change
        prevRecord = grid.Row
        lblRow.Text = prevRecord


    End Sub

    Private Sub grid_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.AfterUpdate
        If saveRecord() Then
            'MsgBox("Transaction completed", MsgBoxStyle.Information, "Information")

            resetFields()

            'grid.Row = grid.RowCount
            'lblRow.Text = grid.Row
            grid.Col = 0
            grid.Focus()
        End If
    End Sub

    Public Function saveRecord() As Boolean
        Dim ctr As Integer
        Dim reply As String
        Dim sublot, remarks As String
        Dim rm, lane, row, sample As String
        Dim returnValue As Boolean

        populateDetails()

        With grid
            If .Item(prevRecord, 2) Is DBNull.Value Then
                sublot = ""
            Else
                sublot = .Item(prevRecord, 2)
            End If

            If .Item(prevRecord, 14) Is DBNull.Value Then
                remarks = ""
            Else
                remarks = .Item(prevRecord, 14)
            End If

            If .Item(prevRecord, 8) Is DBNull.Value Then
                rm = ""
            Else
                rm = .Item(prevRecord, 8)
            End If

            If .Item(prevRecord, 9) Is DBNull.Value Then
                lane = ""
            Else
                lane = .Item(prevRecord, 9)
            End If

            If .Item(prevRecord, 10) Is DBNull.Value Then
                row = ""
            Else
                row = .Item(prevRecord, 10)
            End If

            If allFieldsAreFilled() And noZeroQuantity() Then
                If validateFishBins(.Item(prevRecord, 4)) Then
                    If Not validateFishBinsInTheInventory(.Item(prevRecord, 4)) Then
                        If Not getNextAvailableBinHeight(rm, lane, row) = 0 Then
                            If ((getTotalTonnagePerSublot(lblTripCode.Text, .Item(prevRecord, 0)) / 1000) + (.Item(prevRecord, 7) / 1000)) <= 98.0 Then
                                reply = MsgBox("Are you sure you want to add this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                                If reply = vbYes Then
                                    .Item(prevRecord, 11) = getNextAvailableBinHeight(rm, lane, row)

                                    If Not .Item(prevRecord, 13) Is DBNull.Value Then
                                        If CStr(.Item(prevRecord, 13)) = "-1" Or CStr(.Item(prevRecord, 13)) = "True" Then
                                            saveNewFishBinForDeposit(.Item(prevRecord, 4), depositDateAndTime, rm, _
                                                remarks, lblTripCode.Text, .Item(prevRecord, 1), .Item(prevRecord, 3), _
                                                CDbl(.Item(prevRecord, 5)), .Item(prevRecord, 0), False, lane, _
                                                row, .Item(prevRecord, 11), "-1", modModule.getUsername, lblReceipt.Text, _
                                                .Item(prevRecord, 12), sublot)

                                            'grid.Row = grid.RowCount
                                            'grid.Col = 0
                                        Else
                                            saveNewFishBinForDeposit(.Item(prevRecord, 4), depositDateAndTime, rm, _
                                                remarks, lblTripCode.Text, .Item(prevRecord, 1), .Item(prevRecord, 3), _
                                                CDbl(.Item(prevRecord, 5)), .Item(prevRecord, 0), False, lane, _
                                                row, .Item(prevRecord, 11), "0", modModule.getUsername, lblReceipt.Text, _
                                                .Item(prevRecord, 12), sublot)

                                            'grid.Row = grid.RowCount
                                            'grid.Col = 0
                                        End If
                                    Else
                                        saveNewFishBinForDeposit(.Item(prevRecord, 4), depositDateAndTime, rm, _
                                            remarks, lblTripCode.Text, .Item(prevRecord, 1), .Item(prevRecord, 3), _
                                            CDbl(.Item(prevRecord, 5)), .Item(prevRecord, 0), False, lane, _
                                            row, .Item(prevRecord, 11), "0", modModule.getUsername, lblReceipt.Text, _
                                            .Item(prevRecord, 12), sublot)

                                        'grid.Row = grid.RowCount
                                        'grid.Col = 0
                                    End If

                                    updateColdStorageStack(.Item(prevRecord, 8), .Item(prevRecord, 9), .Item(prevRecord, 10), .Item(prevRecord, 11), _
                                         getDepositCode(.Item(prevRecord, 4), lblTripCode.Text))

                                    returnValue = True
                                    'MsgBox("You have successfully added the fish receipt details", MsgBoxStyle.Information, "Information")

                                    'resetFields()


                                    'grid.Row = grid.RowCount
                                    'grid.Col = 0

                                End If

                            Else
                                MsgBox("You are trying to add a quantity of bin which exceeds the total allowable quantity of 98MT that must be allocated per sublot" & Chr(13) & _
                                    "Please use another sublot number for this entry", MsgBoxStyle.Exclamation, "Warning")
                                returnValue = False
                                displayReceiptDetails(lblReceipt.Text)
                                grid.Row = 0
                                prevRecord = 0
                                .Col = 0
                            End If

                        Else
                            MsgBox("Unable to stack more bins from this row", MsgBoxStyle.Exclamation, "Warning")
                            returnValue = False
                            grid.Focus()
                        End If

                    Else
                        If Not (.Item(prevRecord, 11) Is DBNull.Value) Then
                            If Not (CStr(.Item(prevRecord, 11)).Equals("")) Then
                                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                                If reply = vbYes Then
                                    If Not .Item(prevRecord, 13) Is DBNull.Value Then
                                        If CStr(.Item(prevRecord, 13)) = "-1" Or CStr(.Item(prevRecord, 13)) = "True" Then
                                            updateFishBinDeposited(getDepositCode(.Item(prevRecord, 4)), lblTripCode.Text, .Item(prevRecord, 0), rm, _
                                                remarks, .Item(prevRecord, 4), .Item(prevRecord, 1), .Item(prevRecord, 3), _
                                                CDbl(.Item(prevRecord, 5)), lane, row, _
                                                .Item(prevRecord, 11), "-1", .Item(prevRecord, 12), sublot)  ' .Item(prevRecord, 8), .Item(prevRecord, 2)
                                            'grid.Row = grid.RowCount
                                            'grid.Col = 0
                                        Else
                                            updateFishBinDeposited(getDepositCode(.Item(prevRecord, 4)), lblTripCode.Text, .Item(prevRecord, 0), rm, _
                                                remarks, .Item(prevRecord, 4), .Item(prevRecord, 1), .Item(prevRecord, 3), _
                                                CDbl(.Item(prevRecord, 5)), lane, row, _
                                                .Item(prevRecord, 11), "0", .Item(prevRecord, 12), sublot)  '.Item(prevRecord, 2)
                                            'grid.Row = grid.RowCount
                                            'grid.Col = 0
                                        End If
                                    Else
                                        updateFishBinDeposited(getDepositCode(.Item(prevRecord, 4)), lblTripCode.Text, .Item(prevRecord, 0), rm, _
                                            remarks, .Item(prevRecord, 4), .Item(prevRecord, 1), .Item(prevRecord, 3), _
                                            CDbl(.Item(prevRecord, 5)), lane, row, _
                                            .Item(prevRecord, 11), "0", .Item(prevRecord, 12), sublot)  '.Item(prevRecord, 2)
                                        'grid.Row = grid.RowCount
                                        'grid.Col = 0
                                    End If

                                    returnValue = True
                                    MsgBox("Transaction completed", MsgBoxStyle.Information, "Information")

                                    'resetFields()

                                    'grid.Row = .RowCount
                                    '.Col = 0
                                End If
                            Else
                                MsgBox("The fish bin is already existing from the database. Please go to that record and update it manually", MsgBoxStyle.Exclamation, "Warning")
                                returnValue = False
                                displayReceiptDetails(lblReceipt.Text)
                                grid.Row = 0
                                prevRecord = 0
                            End If
                        Else
                            MsgBox("The fish bin is already existing from the database. Please go to that record and update it manually", MsgBoxStyle.Exclamation, "Warning")
                            returnValue = False
                            displayReceiptDetails(lblReceipt.Text)
                            grid.Row = 0
                            prevRecord = 0
                        End If
                    End If
                Else
                    MsgBox("Fish bin doesn't exists in the system", MsgBoxStyle.Exclamation, "Warning")
                    returnValue = False
                    grid.Col = 4
                End If
            Else
                reply = MsgBox("Please properly fil in those fields marked with asterisk (*)" & Chr(13) & Chr(13) & _
                        "Would you like to cancel this transaction?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    displayReceiptDetails(lblReceipt.Text)
                    grid.Row = 0
                    prevRecord = 0
                End If
                returnValue = False
            End If
        End With

        Return returnValue
    End Function

    Private Sub cmdLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLot.Click
        Dim f As New frmFishLot
        f.displayFishingVessel()
        f.cboVessel.Text = lblVessel.Text
        f.lblLot.Text = lblTripCode.Text
        f.cboVessel.ReadOnly = True
        f.lblLot.ReadOnly = True
        f.ShowDialog(Me)
        Me.displaySublot(lblTripCode.Text)
        grid.Focus()
        grid.Row = grid.RowCount
        grid.Col = 0
    End Sub

    Public Sub saveNewFishBinForDeposit(ByVal bin As String, ByVal dateTime As String, ByVal cs As String, _
    ByVal remarks As String, ByVal lot As String, ByVal fishSpecie As String, ByVal size As String, _
    ByVal grossWeight As Double, ByVal sublot As String, ByVal hold As Boolean, _
    ByVal location As String, ByVal position As String, ByVal height As String, _
    ByVal sample As String, ByVal scaler As String, ByVal rr As String, ByVal owner As String, ByVal sub2 As String)
        Dim depositCode As String

        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FishBinsDeposit"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishBinForDepositCounter()

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@depositCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = Format(CDate(dateTime), "ddMMyy") & "L" & lot & bin & p1.Value
            depositCode = p2.Value

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@binCode"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = getFishBinCode(bin)

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@batchlot"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = lot

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@specieCode"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = getSpecieCode(fishSpecie)

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@csCode"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = getCSCode(cs)

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@grossWeight"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.Float
            p7.Value = grossWeight

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@dateTimeTransfer"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.DateTime
            'txtDate.Value = getServerDateTime()
            'dateTime = txtDate.Value
            'dateTime = txtDate.Value
            p8.Value = Format(CDate(dateTime), getTimeFormat())

            Dim p9 As New SqlClient.SqlParameter
            p9.ParameterName = "@remarks"
            p9.Direction = ParameterDirection.Input
            p9.SqlDbType = SqlDbType.VarChar
            p9.Value = remarks

            Dim p10 As New SqlClient.SqlParameter
            p10.ParameterName = "@withdraw"
            p10.Direction = ParameterDirection.Input
            p10.SqlDbType = SqlDbType.VarChar
            p10.Value = "NO"

            Dim p11 As New SqlClient.SqlParameter
            p11.ParameterName = "@depositStatus"
            p11.Direction = ParameterDirection.Input
            p11.SqlDbType = SqlDbType.VarChar
            p11.Value = "*"

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

            Dim p12 As New SqlClient.SqlParameter
            p12.ParameterName = "@sizeCode"
            p12.Direction = ParameterDirection.Input
            p12.SqlDbType = SqlDbType.VarChar
            p12.Value = getFishSizeCodeByRange(size)

            Dim p13 As New SqlClient.SqlParameter
            p13.ParameterName = "@sublot"
            p13.Direction = ParameterDirection.Input
            p13.SqlDbType = SqlDbType.VarChar
            p13.Value = sublot

            Dim p14 As New SqlClient.SqlParameter
            p14.ParameterName = "@hold"
            p14.Direction = ParameterDirection.Input
            p14.SqlDbType = SqlDbType.Int
            If hold Then
                p14.Value = 1
            Else
                p14.Value = 0
            End If

            Dim p15 As New SqlClient.SqlParameter
            p15.ParameterName = "@location"
            p15.Direction = ParameterDirection.Input
            p15.SqlDbType = SqlDbType.VarChar
            p15.Value = location

            Dim p16 As New SqlClient.SqlParameter
            p16.ParameterName = "@position"
            p16.Direction = ParameterDirection.Input
            p16.SqlDbType = SqlDbType.VarChar
            p16.Value = position

            Dim p17 As New SqlClient.SqlParameter
            p17.ParameterName = "@height"
            p17.Direction = ParameterDirection.Input
            p17.SqlDbType = SqlDbType.VarChar
            p17.Value = height

            Dim p18 As New SqlClient.SqlParameter
            p18.ParameterName = "@sample"
            p18.Direction = ParameterDirection.Input
            p18.SqlDbType = SqlDbType.VarChar
            p18.Value = sample

            Dim p19 As New SqlClient.SqlParameter
            p19.ParameterName = "@scaler"
            p19.Direction = ParameterDirection.Input
            p19.SqlDbType = SqlDbType.VarChar
            p19.Value = scaler

            Dim p20 As New SqlClient.SqlParameter
            p20.ParameterName = "@rrNo"
            p20.Direction = ParameterDirection.Input
            p20.SqlDbType = SqlDbType.VarChar
            p20.Value = rr

            Dim p21 As New SqlClient.SqlParameter
            p21.ParameterName = "@ownerCode"
            p21.Direction = ParameterDirection.Input
            p21.SqlDbType = SqlDbType.VarChar
            p21.Value = getFishOwnerCode(owner)

            Dim p22 As New SqlClient.SqlParameter
            p22.ParameterName = "@sub"
            p22.Direction = ParameterDirection.Input
            p22.SqlDbType = SqlDbType.VarChar
            p22.Value = sub2

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)
            cmd.Parameters.Add(p9)
            cmd.Parameters.Add(p10)
            cmd.Parameters.Add(p11)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)
            cmd.Parameters.Add(p12)
            cmd.Parameters.Add(p13)
            cmd.Parameters.Add(p14)
            cmd.Parameters.Add(p15)
            cmd.Parameters.Add(p16)
            cmd.Parameters.Add(p17)
            cmd.Parameters.Add(p18)
            cmd.Parameters.Add(p19)
            cmd.Parameters.Add(p20)
            cmd.Parameters.Add(p21)
            cmd.Parameters.Add(p22)

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

    Public Sub displayReceiptSummary(ByVal lot As String)
        With gridDetails
            .DataSource = getFishReceiptSummary(lot).Tables(0)
            .Columns(2).NumberFormat = "###,###0.##0"
            .Splits(0).DisplayColumns(0).Width = 70
            .Splits(0).DisplayColumns(1).Width = 60
            .Splits(0).DisplayColumns(2).Width = 65
        End With
    End Sub

    Private Sub cmdCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCS.Click
        displayDestination()
        grid.Focus()
        grid.Row = grid.RowCount
        grid.Col = 0
    End Sub

    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        If e.KeyCode = Keys.F1 Then
            displayDestination()
        ElseIf e.KeyCode = Keys.Escape Then
            'displayReceiptDetails(lblReceipt.Text)
            'grid.RefreshRow()
            'grid.Refresh()
        End If
    End Sub

    Public Sub displayDestination()
        With grid
            Dim f As New frmColdStorage_Map
            f.cmdClear.Enabled = False
            f.cmdMove.Enabled = False
            f.cmdReserved.Enabled = False
            f.cmdBlock.Enabled = False
            f.displayColdStorage()
            If Not .Item(.Row, 8) Is DBNull.Value Then f.cboRm.Text = .Item(.Row, 8)
            If Not .Item(.Row, 9) Is DBNull.Value Then f.cboLane.Text = .Item(.Row, 9)
            'If Not .Item(.Row, 10) Is DBNull.Value Then f.lblRow.Text = .Item(.Row, 10)

            f.displayColdStorageLane(f.cboRm.Text)
            f.displayColdStorageRow(f.cboRm.Text, f.cboLane.Text)
            f.ShowDialog(Me)

            If Not f.cancelTrans Then

                'prevRecord
                If Not .Item(.Row, 8) Is DBNull.Value Then f.cboRm.Text = .Item(.Row, 8)
                If Not .Item(.Row, 9) Is DBNull.Value Then f.cboLane.Text = .Item(.Row, 9)
                'If Not .Item(.Row, 8) Is DBNull.Value Then f.lblro.Text = .Item(.Row, 10)

                .Item(.Row, 8) = f.room
                .Item(.Row, 9) = f.lane
                '  MsgBox(f.room & " " & f.lane)

                .Item(.Row, 10) = f.row
                .Item(.Row, 11) = f.stack

                'MsgBox("Confirming the location." & Chr(13) & _
                '    "Room: " & f.room & Chr(13) & _
                '    "Lane: " & f.lane & Chr(13) & _
                '    "Row: " & f.row & Chr(13) & _
                '    "Stack: " & f.stack)

                '   MsgBox(f.row & " " & f.stack)

                Dim bin As String
                If .Item(.Row, 4) Is DBNull.Value Then
                    bin = ""
                Else
                    bin = .Item(.Row, 4)
                End If

                If validateFishBinsInTheInventory(bin) Then .Item(.Row, 11) = ""

            End If
        End With
    End Sub

    'Private Sub txtBarCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged
    '    barCode.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code39
    '    If Not txtBarCode.Text = "" Then barCode.Text = txtBarCode.Text

    '    If Not txtBarCode.Text = "" Then
    '        Me.cmdEdit.Enabled = True
    '        cmdPrint.Enabled = True
    '    Else
    '        cmdEdit.Enabled = False
    '        cmdPrint.Enabled = False
    '    End If
    'End Sub

    Public Sub printBarcodeTag()
        Try
            'updateRecord(lblBarcodeTag.Text)
            Dim printDoc As New System.Drawing.Printing.PrintDocument
            'rintDoc.PrinterSettings.PaperSizes = System.Drawing.Printing.PrinterSettings.PaperSizeCollection
            'rintDoc.DefaultPageSettings = Printing.PaperSize = Size.Width = 2
            'printDoc.PrinterSettings.PrinterName = "OIS Barcode Printer" '"ZDesigner S4M-300dpi ZPL"
            AddHandler printDoc.BeginPrint, New System.Drawing.Printing.PrintEventHandler(AddressOf beginPrint)
            AddHandler printDoc.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf printDocument)

            printDoc.Print()

            'Dim printPreview As New PrintPreviewDialog
            'printPreview.Document = printDoc
            'printPreview.WindowState = FormWindowState.Maximized
            'printPreview.ShowInTaskbar = False
            'printPreview.ShowDialog()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim index As Integer

        'If lblRow.Text = grid.Row Then
        'grid_AfterUpdate(sender, New EventArgs)

        'index = lblRow.Text
        'Else
        index = grid.Row
        'End If

        Dim bin As String

        With grid
            Try
                If .Item(index, 4) Is DBNull.Value Then
                    bin = ""
                Else
                    bin = .Item(index, 4)
                End If
            Catch
                If .Item(index, 4) = "" Then
                    bin = ""
                Else
                    bin = .Item(index, 4)
                End If
            End Try

            'If Not validateFishBinsInTheInventory(bin) Then
            '    grid_AfterUpdate(sender, New EventArgs)
            'End If

            printLabel(bin)
        End With

    End Sub

    Public Sub printLabel(ByVal bin As String)
        Try
            With grid
                If Not getDepositCode(bin) = "" Then
                    displayBarcodeTag(bin)
                    printBarcodeTag()
                    grid.Focus()
                    grid.Row = grid.RowCount
                    grid.Col = 0
                    'Else
                    '    MsgBox("Bin number doesn't exists", MsgBoxStyle.Exclamation, "Warning")
                    '    displayReceiptDetails(lblReceipt.Text)

                    '    grid.Row = 0
                    '    prevRecord = 0
                    '    lblRow.Text = prevRecord
                    '    .Col = 0
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub beginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        page = 1
    End Sub

    Private Sub printDocument(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim f As New Font("Tahoma", 12.0)
        Dim rcPage As New RectangleF(10, 20, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim rcPage2 As New RectangleF(100, 20, e.MarginBounds.Width, e.MarginBounds.Height)
        '( e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, e.MarginBounds.Height)

        'MsgBox(e.MarginBounds.Width & " " & e.MarginBounds.Height)  '650 , 900

        Dim rc1 As RectangleF = rcPage
        rc1.Height = 30
        rc1.Width = 550 '130

        Dim rc As RectangleF = rcPage2
        rc.Height = 30
        rc.Width = 550 '130

        'Dim rc0 As RectangleF = rcPage
        'rc0.Height = 30
        'rc0.Width = 300

        Dim rc2 As RectangleF = rc1
        rc2.Offset(0, 0) '(rc1.Width, 0)
        rc2.Width = 300

        Dim rc3 As RectangleF = rc2
        rc3.Offset(0, 0) '(rc2.Width, 0)
        rc3.Width = 260

        Dim str As String = lblTripCode.Text
        g.DrawString("  " & str, New Font("Tahoma", 12.0, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, CType(rc3, RectangleF))
        rc3.Y = rc3.Y + (rc3.Height + 1)
        g.DrawString("", New Font("Tahoma", 6.0), Brushes.Black, CType(rc3, RectangleF))
        g.DrawString("  " & lblSublot.Text & " * " & lblSub2.Text & " * " & lblSpecie.Text, _
            New Font("Tahoma", 10.0), Brushes.Black, CType(rc3, RectangleF))
        rc3.Y = rc3.Y + (rc3.Height + 1)

        rc3.Y = 69
        rc3.X = 20
        rc3.Height = 54
        g.DrawImage(txtBarcode.Image, rc3)
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        rc1.Y = rc1.Y + (rc1.Height + 70)
        rc.Y = rc.Y + (rc.Height + 30)
        rc2.Y = rc2.Y + (rc2.Height + 10)
        'rc3.Y = rc3.Y + (rc3.Height + 10)
        g.DrawString("", New Font("Tahoma", 6.0), Brushes.Black, CType(rc, RectangleF))
        g.DrawString("  *" & lblBin.Text & "* " & lblSize.Text, New Font("Tahoma", 10.0), Brushes.Black, CType(rc1, RectangleF))

        rc1.Y = rc1.Y + (rc1.Height + 1)
        g.DrawString("  " & Format(CDate(lblDate.Text), getTimeFormat()) & " * " & Format(CDbl(lblNW.Text), "###,##0") & " * " & _
            lblCS.Text & " , " & lblCSLane.Text & ", " & lblCSRow.Text & ", " & lblCSStack.Text, _
            New Font("Tahoma", 10.0), Brushes.Black, CType(rc1, RectangleF))

        'rc1.Y = rc1.Y + (rc1.Height + 1)
        'g.DrawString("No. Of Cans: " & "", New Font("Tahoma", 10.0), Brushes.Black, CType(rc1, RectangleF))
        'rc1.Y = rc1.Y + (rc1.Height + 1)
        'g.DrawString("Time: " & "", New Font("Tahoma", 10.0), Brushes.Black, CType(rc1, RectangleF))
        'rc1.Y = rc1.Y + (rc1.Height + 1)
        'g.DrawString("Date: " & "", New Font("Tahoma", 10.0), Brushes.Black, CType(rc1, RectangleF))
        'rc1.Y = rc1.Y + (rc1.Height + 1)

        'Dim rcRemarks As RectangleF = rc1
        'rcRemarks.Offset(0, 0)
        'rcRemarks.Y = rc1.Y
        'rcRemarks.Height = 60
        'rcRemarks.Width = 300 'rc1.Width
        ''rcRemarks.X = 290
        'g.DrawString("Remarks: " & "", New Font("Tahoma", 10.0), Brushes.Black, CType(rcRemarks, RectangleF))

        e.HasMorePages = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub mnuSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSize.Click
        Dim f As New frmFishSize
        f.ShowDialog(Me)

        displayFishSizes()
    End Sub

    Private Sub mnuBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBin.Click
        Dim f As New frmFishBin
        f.ShowDialog(Me)

        displayFishBins()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim reply As String
        reply = MsgBox("Are you sure you want to delete this bin from the lists?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If reply = vbYes Then
            With grid
                If .RowCount > 0 Then
                    If Not .Item(.Row, 4) Is DBNull.Value Then
                        If Not CStr(.Item(.Row, 4)) = "" Then
                            Dim rm, lane, row, height As String

                            If .Item(.Row, 8) Is DBNull.Value Then
                                rm = ""
                            Else
                                rm = .Item(.Row, 8)
                            End If

                            If .Item(.Row, 9) Is DBNull.Value Then
                                lane = ""
                            Else
                                lane = .Item(.Row, 9)
                            End If

                            If .Item(.Row, 10) Is DBNull.Value Then
                                row = ""
                            Else
                                row = .Item(.Row, 10)
                            End If

                            If .Item(.Row, 11) Is DBNull.Value Then
                                height = ""
                            Else
                                height = .Item(.Row, 11)
                            End If

                            'MsgBox(.Item(.Row, 4) & " " & _
                            '    rm & " " & lane & " " & row & " " & height)

                            deleteBinFromDeposit(.Item(.Row, 4))

                            updateColdStorageStack(rm, lane, row, height, "")

                            Dim stack As Integer
                            While stack < 6
                                checkForAutoStack(rm, lane, row) 'lblRow.Text)

                                stack += 1
                            End While

                            displayReceiptDetails(lblReceipt.Text)

                            MsgBox("You have successfully remove the bins from the lists", MsgBoxStyle.Information, "Information")
                            grid.Focus()
                        Else
                            MsgBox("Please identify properly the bin number before you can remove the record", MsgBoxStyle.Exclamation, "Warning")
                            grid.Focus()
                        End If
                    Else
                        MsgBox("Please identify properly the bin number before you can remove the record", MsgBoxStyle.Exclamation, "Warning")
                        grid.Focus()
                    End If
                Else
                    MsgBox("Please identify properly the bin number before you can remove the record", MsgBoxStyle.Exclamation, "Warning")
                    grid.Focus()
                End If
            End With
        End If

        grid.Focus()
        grid.Row = grid.RowCount
        grid.Col = 0
    End Sub

    Public Sub resetFields()
        displaySublot(lblTripCode.Text)
        'displaySublot2()
        displayFishSizes()
        displayFishBins()
        displayColdStorage()
        displayFishOwner()
    End Sub

    Private Sub cmdScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScale.Click
        grid.Focus()
    End Sub

    Public Sub setRowAndColFocus()
        With grid
            If .RowCount > 0 Then
                .Row = .RowCount - 1
                .Col = 0
                lblRow.Text = .RowCount - 1
                prevRecord = lblRow.Text
            Else
                .Row = 0
                .Col = 0
                lblRow.Text = 0
                prevRecord = 0
            End If
        End With
    End Sub

    Public Sub enableUI(ByVal enable As Boolean)
        Select Case enable
            Case True
                cmdCS.Enabled = True
                cmdDelete.Enabled = True
                cmdScale.Enabled = True
                cmdLot.Enabled = True

                grid.AllowUpdate = True
                grid.AllowAddNew = True
                grid.AllowDelete = True
            Case False
                cmdCS.Enabled = False
                cmdDelete.Enabled = False
                cmdScale.Enabled = False
                cmdLot.Enabled = False

                grid.AllowUpdate = False
                grid.AllowAddNew = False
                grid.AllowDelete = False
        End Select
    End Sub
End Class
