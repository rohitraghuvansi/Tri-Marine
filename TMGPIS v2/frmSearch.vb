Public Class frmSearch
    Inherits System.Windows.Forms.Form

    Public Shared searchType As Integer
    Public Shared searchItem As String
    Public Shared cancel As Boolean
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
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSearch))
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.grid.Location = New System.Drawing.Point(8, 104)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(704, 344)
        Me.grid.TabIndex = 0
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Tahoma, 9.75pt;}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}He" & _
        "ading{Wrap:True;Font:Tahoma, 9.75pt, style=Bold;AlignVert:Center;Border:Raised,," & _
        "1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{AlignHorz:Ne" & _
        "ar;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win.C1TrueDBG" & _
        "rid.MergeView AllowColMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeigh" & _
        "t=""17"" ColumnFooterHeight=""17"" FilterBar=""True"" MarqueeStyle=""DottedCellBorder"" " & _
        "RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalS" & _
        "crollGroup=""1""><Height>340</Height><CaptionStyle parent=""Style2"" me=""Style10"" />" & _
        "<EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""St" & _
        "yle8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""F" & _
        "ooter"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle par" & _
        "ent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7""" & _
        " /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" m" & _
        "e=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><Select" & _
        "edStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><Cl" & _
        "ientRect>0, 0, 700, 340</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunke" & _
        "n</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style pare" & _
        "nt="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading" & _
        """ me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" m" & _
        "e=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=" & _
        """Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=" & _
        """EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Rec" & _
        "ordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" m" & _
        "e=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><L" & _
        "ayout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, " & _
        "700, 340</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFo" & _
        "oterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Bitmap)
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSearch.Location = New System.Drawing.Point(283, 456)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 48)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "&Search"
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(363, 456)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(720, 40)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.Text = "Search"
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(80, 24)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(176, 23)
        Me.lblCode.TabIndex = 34
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCode.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Look into"
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(80, 56)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(632, 40)
        Me.lblDescription.TabIndex = 36
        '
        'frmSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 509)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.lblDescription, Me.lblTitle, Me.cmdClose, Me.cmdSearch, Me.grid, Me.lblCode})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearch"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        cancel = True
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllFWS()
        With grid
            .DataSource = modModule.getAllFWS().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 160
            .Splits(0).DisplayColumns(2).Width = 45
            .Splits(0).DisplayColumns(4).Width = 45
            .Splits(0).DisplayColumns(5).Width = 250
            .Splits(0).DisplayColumns(6).Width = 140
            .Splits(0).DisplayColumns(7).Width = 70
            .Splits(0).DisplayColumns(9).Width = 45
            .Splits(0).DisplayColumns(11).Width = 100
            .Splits(0).DisplayColumns(12).Width = 80
            .Splits(0).DisplayColumns(13).Width = 80
            .Splits(0).DisplayColumns(14).Width = 80
            .Splits(0).DisplayColumns(15).Width = 200
        End With
    End Sub

    Public Sub displayAllSection()
        With grid
            .DataSource = modModule.getAllSection().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllRejects()
        With grid
            .DataSource = modModule.getAllDefects().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllFAO()
        With grid
            .DataSource = modModule.getAllCatchAreas().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllCOS()
        With grid
            .DataSource = modModule.getAllCOS().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 160
            .Columns(5).NumberFormat = "###,###,##0.#0"
        End With
    End Sub

    Public Sub displayAllCOP()
        With grid
            .DataSource = modModule.getAllCOP().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 120
            .Splits(0).DisplayColumns(1).Width = 120
            .Splits(0).DisplayColumns(3).Width = 250
        End With
    End Sub

    Public Sub displayAllFishBins()
        With grid
            .DataSource = modModule.getAllFishBins().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 500
        End With
    End Sub

    Public Sub displayAllFishingVessel()
        With grid
            .DataSource = modModule.getAllFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 200
        End With
    End Sub

    Public Sub displayAllSupplier()
        With grid
            .DataSource = modModule.getAllFishSupplier().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 560
            .Splits(0).DisplayColumns(1).Width = 100
        End With
    End Sub

    Public Sub displayAllFishSpecie()
        With grid
            .DataSource = modModule.getAllFishSpecie().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 100
            .Splits(0).DisplayColumns(1).Width = 60
        End With
    End Sub

    Public Sub displayAllSpecie()
        With grid
            .DataSource = modModule.getAllFishSpecie2().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 300
            .Splits(0).DisplayColumns(2).Width = 300
        End With
    End Sub

    Public Sub displayAllFishRejects()
        With grid
            .DataSource = modModule.getAllFishRejects().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
            .Splits(0).DisplayColumns(2).Width = 50
            .Splits(0).DisplayColumns(3).Width = 70
            .Splits(0).DisplayColumns(4).Width = 150
            '.Splits(0).DisplayColumns(5).Width = 70
            '.Splits(0).DisplayColumns(7).Width = 45
            '.Splits(0).DisplayColumns(9).Width = 70
            '.Splits(0).DisplayColumns(10).Width = 85
            '.Splits(0).DisplayColumns(11).Width = 200
        End With
    End Sub

    Public Sub displayAllFishDeposits()
        With grid
            .DataSource = modModule.getAllFishDeposits().Tables(0)
            .Columns(2).NumberFormat = "##0.#0"
            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 125
            .Splits(0).DisplayColumns(2).Width = 60
            .Splits(0).DisplayColumns(4).Width = 200
            .Splits(0).DisplayColumns(7).Width = 60
            .Splits(0).DisplayColumns(8).Width = 150
            .Splits(0).DisplayColumns(9).Width = 200
            .Splits(0).DisplayColumns(10).Width = 170
            .Columns(10).NumberFormat = "dd/MM/yyyy HH:mm:ss tt"
            .Splits(0).DisplayColumns(11).Width = 80
            .Columns(11).NumberFormat = "###,##0.#0"
            .Splits(0).DisplayColumns(12).Width = 80
            .Columns(12).NumberFormat = "###,##0.#0"
            .Splits(0).DisplayColumns(13).Width = 80
            .Columns(13).NumberFormat = "###,##0.#0"
            .Splits(0).DisplayColumns(14).Width = 80
        End With
    End Sub

    Public Sub displayAllFishLots()
        With grid
            .DataSource = modModule.getAllFishLots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 190
            .Splits(0).DisplayColumns(5).Width = 120
        End With
    End Sub

    Public Sub displayAllCC()
        With grid
            .DataSource = modModule.getAllCC().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
            .Splits(0).DisplayColumns(1).Width = 140
            .Splits(0).DisplayColumns(2).Width = 170
            .Splits(0).DisplayColumns(13).Width = 250
        End With
    End Sub

    Public Sub displayAllMeatRecovery()
        With grid
            .DataSource = modModule.getAllMeatRecovery().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 100
            .Splits(0).DisplayColumns(1).Width = 50
            .Splits(0).DisplayColumns(2).Width = 70
            .Splits(0).DisplayColumns(3).Width = 110
            .Splits(0).DisplayColumns(4).Width = 100
            .Splits(0).DisplayColumns(6).Width = 70
            .Splits(0).DisplayColumns(7).Width = 50
        End With
    End Sub

    Public Sub displayData()
        With grid
            If .RowCount > 0 Then
                lblCode.Text = .Item(.Row, 0)
                lblDescription.Text = .Item(.Row, 0)
            Else
                MsgBox("No data to search", MsgBoxStyle.Exclamation, "Warning")
                grid.Focus()
            End If
        End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        displayData()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        displayData()

        If grid.RowCount > 0 Then
            Select Case searchType
                Case 1  'FISH WITHDRAWAL
                    searchItem = grid.Item(grid.Row, 0)
                Case 2  'FISH DEPOSIT/ BATCHOT/ SICC
                    searchItem = grid.Item(grid.Row, 0)
            End Select
            cancel = False

            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Public Sub displayAllFishSizes()
        With grid
            .DataSource = modModule.getAllFishSizes().Tables(0)
            .Splits(0).DisplayColumns(1).Width = 60
            .Columns(1).NumberFormat = "##0.#0"
            .Splits(0).DisplayColumns(2).Width = 60
            .Columns(2).NumberFormat = "##0.#0"
            .Splits(0).DisplayColumns(3).Width = 70
            .Splits(0).DisplayColumns(4).Width = 370
        End With
    End Sub

    Public Sub displayAllPD()
        With grid
            .DataSource = modModule.getAllPD().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllPS()
        With grid
            .DataSource = modModule.getAllPS().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 380
            .Splits(0).DisplayColumns(2).Width = 200
        End With
    End Sub

    Public Sub displayAllMedia()
        With grid
            .DataSource = modModule.getAllMedia().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllFL()
        With grid
            .DataSource = modModule.getAllFL().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllCS()
        With grid
            .DataSource = modModule.getAllCS().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllCanSize(ByVal category As String)
        With grid
            .DataSource = modModule.getAllCanSize(category).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 280
            .Splits(0).DisplayColumns(2).Width = 120
        End With
    End Sub

    Public Sub displayAllProductCodes()
        With grid
            .DataSource = modModule.getAllProduct().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 480
            .Splits(0).DisplayColumns(2).Width = 120
        End With
    End Sub

    Public Sub displayAllTP()
        With grid
            .DataSource = modModule.getAllTP().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllMRN_Materials()
        With grid
            .DataSource = modModule.getAllMRN_Materials().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 380
            .Splits(0).DisplayColumns(2).Width = 200
        End With
    End Sub

    Public Sub displayAllMRN_Manufacturer()
        With grid
            .DataSource = modModule.getAllMRN_Manufacturer().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 380
            .Splits(0).DisplayColumns(2).Width = 200
        End With
    End Sub

    Public Sub displayAllMRN_Supplier()
        With grid
            .DataSource = modModule.getAllMRN_Supplier().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 380
            .Splits(0).DisplayColumns(2).Width = 200
        End With
    End Sub

    Public Sub displayAllMRN(ByVal category As String)
        With grid
            .DataSource = modModule.getAllMRN(category).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 180
            .Splits(0).DisplayColumns(1).Width = 80
            .Splits(0).DisplayColumns(2).Width = 240
            .Splits(0).DisplayColumns(3).Width = 85

            .Columns(5).NumberFormat = "###,###,###,###.#0"
            .Columns(6).NumberFormat = "###,###,###,###.#0"
            .Columns(7).NumberFormat = "###,###,###,###.#0"
        End With
    End Sub

    Public Sub displayAllWarehouse()
        With grid
            .DataSource = modModule.getAllWarehouse().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllLabels()
        With grid
            .DataSource = modModule.getAllLabels().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 100
            .Splits(0).DisplayColumns(1).Width = 460
            .Splits(0).DisplayColumns(2).Width = 100
        End With
    End Sub

    Public Sub displayAllLS()
        With grid
            .DataSource = modModule.getAllLS().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllFGWithdrawn()
        With grid
            .DataSource = modModule.getFGWithdrawn_Details().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 180
            '.Splits(0).DisplayColumns(1).Width = 150
            '.Splits(0).DisplayColumns(2).Width = 150
            '.Splits(0).DisplayColumns(3).Width = 100
            '.Splits(0).DisplayColumns(7).Width = 100
            '.Splits(0).DisplayColumns(8).Width = 150

            '.Columns(3).NumberFormat = getTimeFormat()
            '.Columns(5).NumberFormat = "###,###,##0.#0"
            '.Columns(6).NumberFormat = "###,###,##0"
        End With
    End Sub

    Public Sub displayAllQCSample()
        With grid
            .DataSource = getQCSampleDetails().Tables(0)
        End With
    End Sub

    Public Sub displayAllMRN_Usage()
        With grid
            .DataSource = getAllMRNUsage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 90
            .Splits(0).DisplayColumns(1).Width = 60
            .Splits(0).DisplayColumns(2).Width = 200
            .Splits(0).DisplayColumns(3).Width = 200
            .Splits(0).DisplayColumns(4).Width = 110
            .Columns(4).NumberFormat = "###,###,##0.#0"
        End With
    End Sub

    Public Sub displayAllMaterialUsages()
        With grid
            .DataSource = getAllMaterialsUsage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 90
            .Splits(0).DisplayColumns(1).Width = 50
            .Splits(0).DisplayColumns(2).Width = 435 '175
            .Splits(0).DisplayColumns(3).Width = 100 '260
            '.Splits(0).DisplayColumns(4).Width = 100
            .Columns(3).NumberFormat = "###,###,##0.#0"
        End With
    End Sub

    Public Sub displayAllBOM()
        With grid
            .DataSource = getAllBOM().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 75
            .Splits(0).DisplayColumns(1).Width = 300
            .Splits(0).DisplayColumns(2).Width = 100


            .Columns(2).NumberFormat = getTimeFormat()
            .Columns(3).NumberFormat = "###,##0.#0"
            .Columns(4).NumberFormat = "###,##0.#0"
            .Columns(5).NumberFormat = "###,##0.#0"
            .Columns(6).NumberFormat = "###,##0.#0"
            .Columns(7).NumberFormat = "###,##0.#0"
            .Columns(8).NumberFormat = "###,##0.#0"
            .Columns(9).NumberFormat = "###,##0.#0"
            .Columns(10).NumberFormat = "###,##0.#0"
            .Columns(11).NumberFormat = "###,##0.#0"
            .Columns(12).NumberFormat = "###,##0.#0"
            .Columns(13).NumberFormat = "###,##0.#0"
            .Columns(14).NumberFormat = "###,##0.#0"
        End With
    End Sub

    Public Sub displayAllFGDefects()
        With grid
            .DataSource = getAllFGDefects().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 600
        End With
    End Sub

    Public Sub displayAllFGShipments()
        With grid
            .DataSource = modModule.getAllFGShipments().Tables(0)
            .Columns(0).NumberFormat = getTimeFormat()

            .Splits(0).DisplayColumns(0).Width = 100
            .Splits(0).DisplayColumns(1).Width = 150
        End With
    End Sub

    Public Sub displayAllFGInvoice()
        With grid
            .DataSource = modModule.getAllFGInvoice().Tables(0)
            .Columns(1).NumberFormat = getTimeFormat()

            .Splits(0).DisplayColumns(0).Width = 120
            .Splits(0).DisplayColumns(2).Width = 200
        End With
    End Sub

    Public Sub displayAllPalletTags()
        With grid
            .DataSource = modModule.getAllPalletTags().Tables(0)
            .Columns(0).NumberFormat = getTimeFormat()

            .Splits(0).DisplayColumns(0).Width = 90
            .Splits(0).DisplayColumns(1).Width = 60
            .Splits(0).DisplayColumns(2).Width = 90
            .Splits(0).DisplayColumns(4).Width = 70
            .Splits(0).DisplayColumns(5).Width = 80
            .Splits(0).DisplayColumns(6).Width = 60
            .Splits(0).DisplayColumns(7).Width = 60
        End With
    End Sub

    Public Sub displayAllAnalysis_RF()
        With grid
            .DataSource = modModule.getAllAnalysis_RF().Tables(0)
            .Columns(0).NumberFormat = getTimeFormat()
            .Columns(1).NumberFormat = getTimeFormat()

            '.Splits(0).DisplayColumns(0).Width = 90
            '.Splits(0).DisplayColumns(1).Width = 60
            '.Splits(0).DisplayColumns(2).Width = 90
            '.Splits(0).DisplayColumns(3).Width = 70
            '.Splits(0).DisplayColumns(4).Width = 80
            '.Splits(0).DisplayColumns(5).Width = 60
            '.Splits(0).DisplayColumns(6).Width = 60
        End With
    End Sub

    Public Sub displayAllAnalysis_FG()
        With grid
            .DataSource = modModule.getAllAnalysis_FG().Tables(0)
            .Columns(0).NumberFormat = getTimeFormat()
            .Columns(1).NumberFormat = getTimeFormat()

            '.Splits(0).DisplayColumns(0).Width = 90
            '.Splits(0).DisplayColumns(1).Width = 60
            '.Splits(0).DisplayColumns(2).Width = 90
            '.Splits(0).DisplayColumns(3).Width = 70
            '.Splits(0).DisplayColumns(4).Width = 80
            '.Splits(0).DisplayColumns(5).Width = 60
            '.Splits(0).DisplayColumns(6).Width = 60
        End With
    End Sub

    Public Sub displayAllFishOwner()
        With grid
            .DataSource = modModule.getAllFishOwner().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 560
            .Splits(0).DisplayColumns(1).Width = 100
        End With
    End Sub

    Public Sub displayAllColdStorage()
        With grid
            .DataSource = modModule.getAllColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
            .Splits(0).DisplayColumns(3).Width = 60
        End With
    End Sub
End Class
