Public Class frmFishDeposit_Loin_Bags
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gridSummary As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cboHeight As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboPosition As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboLocation As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cboSize As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboSpecie As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalNW As System.Windows.Forms.Label
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblCondition As System.Windows.Forms.Label
    Friend WithEvents cboSubLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents mnuFB As System.Windows.Forms.MenuItem
    Friend WithEvents gridBin As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuFS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFZ As System.Windows.Forms.MenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPreservationMethod As System.Windows.Forms.Label
    Friend WithEvents lblVessel As System.Windows.Forms.Label
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents chkHold As System.Windows.Forms.CheckBox
    Friend WithEvents cboPositionx As C1.Win.C1List.C1Combo
    Friend WithEvents cboLocationx As C1.Win.C1List.C1Combo
    Friend WithEvents cboType As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishDeposit_Loin_Bags))
        Me.Label5 = New System.Windows.Forms.Label
        Me.gridSummary = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cboHeight = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboPosition = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboLocation = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cboSize = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboSpecie = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblTotalNW = New System.Windows.Forms.Label
        Me.cboType = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.txtDate = New C1.Win.C1Input.C1DateEdit
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblCondition = New System.Windows.Forms.Label
        Me.cboSubLot = New C1.Win.C1List.C1Combo
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.mnuFB = New System.Windows.Forms.MenuItem
        Me.gridBin = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboCS = New C1.Win.C1List.C1Combo
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuFS = New System.Windows.Forms.MenuItem
        Me.mnuFZ = New System.Windows.Forms.MenuItem
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPreservationMethod = New System.Windows.Forms.Label
        Me.lblVessel = New System.Windows.Forms.Label
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.chkHold = New System.Windows.Forms.CheckBox
        Me.cboPositionx = New C1.Win.C1List.C1Combo
        Me.cboLocationx = New C1.Win.C1List.C1Combo
        CType(Me.gridSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPositionx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLocationx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(600, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 19)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Summary: Outstanding Balance"
        '
        'gridSummary
        '
        Me.gridSummary.AllowColMove = False
        Me.gridSummary.AllowUpdate = False
        Me.gridSummary.CaptionHeight = 17
        Me.gridSummary.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSummary.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSummary.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.gridSummary.Location = New System.Drawing.Point(600, 80)
        Me.gridSummary.Name = "gridSummary"
        Me.gridSummary.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSummary.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSummary.PreviewInfo.ZoomFactor = 75
        Me.gridSummary.RowHeight = 20
        Me.gridSummary.Size = New System.Drawing.Size(306, 148)
        Me.gridSummary.TabIndex = 140
        Me.gridSummary.Text = "C1TrueDBGrid1"
        Me.gridSummary.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}FilterBar{}EvenRow{BackColor:Aqua;}Selected{ForeColor:HighlightText;BackC" & _
        "olor:Highlight;}Heading{Wrap:True;Font:Tahoma, 9.75pt;BackColor:Control;Border:R" & _
        "aised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Inactive{ForeColor:Ina" & _
        "ctiveCaptionText;BackColor:InactiveCaption;}OddRow{}Footer{}Caption{AlignHorz:Ce" & _
        "nter;}Style78{}Style79{}Style76{}Normal{Font:Tahoma, 9.75pt;}Style72{}Style73{}S" & _
        "tyle70{}Style71{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" & _
        "77{AlignHorz:Near;}Style74{}Style75{}Style80{}Style69{}Style68{}RecordSelector{A" & _
        "lignImage:Center;}Style14{}Style15{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid" & _
        ".MergeView AllowColMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""" & _
        "17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=" & _
        """16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Heig" & _
        "ht>144</Height><CaptionStyle parent=""Heading"" me=""Style77"" /><EditorStyle parent" & _
        "=""Editor"" me=""Style69"" /><EvenRowStyle parent=""EvenRow"" me=""Style75"" /><FilterBa" & _
        "rStyle parent=""FilterBar"" me=""Style80"" /><FooterStyle parent=""Footer"" me=""Style7" & _
        "1"" /><GroupStyle parent=""Group"" me=""Style79"" /><HeadingStyle parent=""Heading"" me" & _
        "=""Style70"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style74"" /><InactiveSt" & _
        "yle parent=""Inactive"" me=""Style73"" /><OddRowStyle parent=""OddRow"" me=""Style76"" /" & _
        "><RecordSelectorStyle parent=""RecordSelector"" me=""Style78"" /><SelectedStyle pare" & _
        "nt=""Selected"" me=""Style72"" /><Style parent=""Normal"" me=""Style68"" /><ClientRect>0" & _
        ", 0, 302, 144</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 302, 144</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(499, 512)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 139
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cboHeight
        '
        Me.cboHeight.AllowColMove = True
        Me.cboHeight.AllowColSelect = True
        Me.cboHeight.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboHeight.AlternatingRows = False
        Me.cboHeight.CaptionHeight = 17
        Me.cboHeight.ColumnCaptionHeight = 17
        Me.cboHeight.ColumnFooterHeight = 17
        Me.cboHeight.FetchRowStyles = False
        Me.cboHeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHeight.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboHeight.Location = New System.Drawing.Point(776, 264)
        Me.cboHeight.Name = "cboHeight"
        Me.cboHeight.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboHeight.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboHeight.RowHeight = 20
        Me.cboHeight.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboHeight.ScrollTips = False
        Me.cboHeight.Size = New System.Drawing.Size(104, 232)
        Me.cboHeight.TabIndex = 138
        Me.cboHeight.Text = "C1TrueDBDropdown1"
        Me.cboHeight.Visible = False
        Me.cboHeight.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Alig" & _
        "nVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>228</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 100, 228</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 100, 228</ClientArea></Blob>"
        '
        'cboPosition
        '
        Me.cboPosition.AllowColMove = True
        Me.cboPosition.AllowColSelect = True
        Me.cboPosition.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboPosition.AlternatingRows = False
        Me.cboPosition.CaptionHeight = 17
        Me.cboPosition.ColumnCaptionHeight = 17
        Me.cboPosition.ColumnFooterHeight = 17
        Me.cboPosition.FetchRowStyles = False
        Me.cboPosition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPosition.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboPosition.Location = New System.Drawing.Point(672, 264)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPosition.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboPosition.RowHeight = 20
        Me.cboPosition.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPosition.ScrollTips = False
        Me.cboPosition.Size = New System.Drawing.Size(104, 232)
        Me.cboPosition.TabIndex = 137
        Me.cboPosition.Text = "C1TrueDBDropdown1"
        Me.cboPosition.Visible = False
        Me.cboPosition.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Alig" & _
        "nVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>228</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 100, 228</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 100, 228</ClientArea></Blob>"
        '
        'cboLocation
        '
        Me.cboLocation.AllowColMove = True
        Me.cboLocation.AllowColSelect = True
        Me.cboLocation.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboLocation.AlternatingRows = False
        Me.cboLocation.CaptionHeight = 17
        Me.cboLocation.ColumnCaptionHeight = 17
        Me.cboLocation.ColumnFooterHeight = 17
        Me.cboLocation.FetchRowStyles = False
        Me.cboLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboLocation.Location = New System.Drawing.Point(600, 264)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLocation.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboLocation.RowHeight = 20
        Me.cboLocation.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLocation.ScrollTips = False
        Me.cboLocation.Size = New System.Drawing.Size(104, 232)
        Me.cboLocation.TabIndex = 136
        Me.cboLocation.Text = "C1TrueDBDropdown1"
        Me.cboLocation.Visible = False
        Me.cboLocation.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style9{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackC" & _
        "olor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>228</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 100, 228</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 100, 228</ClientArea></Blob>"
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(584, 560)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 135
        Me.cmdPrint.TabStop = False
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.Visible = False
        '
        'cboSize
        '
        Me.cboSize.AllowColMove = True
        Me.cboSize.AllowColSelect = True
        Me.cboSize.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSize.AlternatingRows = False
        Me.cboSize.CaptionHeight = 17
        Me.cboSize.ColumnCaptionHeight = 17
        Me.cboSize.ColumnFooterHeight = 17
        Me.cboSize.FetchRowStyles = False
        Me.cboSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSize.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboSize.Location = New System.Drawing.Point(184, 264)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboSize.RowHeight = 20
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.ScrollTips = False
        Me.cboSize.Size = New System.Drawing.Size(104, 232)
        Me.cboSize.TabIndex = 134
        Me.cboSize.Text = "C1TrueDBDropdown1"
        Me.cboSize.Visible = False
        Me.cboSize.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style9{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackC" & _
        "olor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>228</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 100, 228</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 100, 228</ClientArea></Blob>"
        '
        'cboSpecie
        '
        Me.cboSpecie.AllowColMove = True
        Me.cboSpecie.AllowColSelect = True
        Me.cboSpecie.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSpecie.AlternatingRows = False
        Me.cboSpecie.CaptionHeight = 17
        Me.cboSpecie.ColumnCaptionHeight = 17
        Me.cboSpecie.ColumnFooterHeight = 17
        Me.cboSpecie.FetchRowStyles = False
        Me.cboSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboSpecie.Location = New System.Drawing.Point(80, 264)
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboSpecie.RowHeight = 20
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.ScrollTips = False
        Me.cboSpecie.Size = New System.Drawing.Size(104, 232)
        Me.cboSpecie.TabIndex = 133
        Me.cboSpecie.Text = "C1TrueDBDropdown1"
        Me.cboSpecie.Visible = False
        Me.cboSpecie.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style9{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackC" & _
        "olor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>228</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 100, 228</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 100, 228</ClientArea></Blob>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "Total NW"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(288, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 19)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Date/ Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Fish Bin Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(288, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 19)
        Me.Label17.TabIndex = 124
        Me.Label17.Text = "Remarks"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 19)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Vessel Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 19)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Fish Condition"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 19)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Sub-lot#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(688, 584)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 19)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Hold"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(688, 576)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Position"
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Lot No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(288, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 19)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Cold Storage"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(648, 584)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 19)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Location"
        Me.Label12.Visible = False
        '
        'lblTotalNW
        '
        Me.lblTotalNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNW.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNW.Location = New System.Drawing.Point(376, 152)
        Me.lblTotalNW.Name = "lblTotalNW"
        Me.lblTotalNW.Size = New System.Drawing.Size(208, 80)
        Me.lblTotalNW.TabIndex = 131
        Me.lblTotalNW.Text = "0.00"
        Me.lblTotalNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboType
        '
        Me.cboType.AllowColMove = True
        Me.cboType.AllowColSelect = True
        Me.cboType.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboType.AlternatingRows = False
        Me.cboType.CaptionHeight = 17
        Me.cboType.ColumnCaptionHeight = 17
        Me.cboType.ColumnFooterHeight = 17
        Me.cboType.FetchRowStyles = False
        Me.cboType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.cboType.Location = New System.Drawing.Point(8, 264)
        Me.cboType.Name = "cboType"
        Me.cboType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboType.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboType.RowHeight = 20
        Me.cboType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboType.ScrollTips = False
        Me.cboType.Size = New System.Drawing.Size(104, 232)
        Me.cboType.TabIndex = 130
        Me.cboType.Text = "C1TrueDBDropdown1"
        Me.cboType.Visible = False
        Me.cboType.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Alig" & _
        "nVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>228</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 100, 228</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 100, 228</ClientArea></Blob>"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(376, 48)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(208, 23)
        Me.txtDate.TabIndex = 2
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(688, 576)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(216, 56)
        Me.lblCode.TabIndex = 112
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCode.Visible = False
        '
        'lblCondition
        '
        Me.lblCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCondition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondition.Location = New System.Drawing.Point(104, 152)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(173, 24)
        Me.lblCondition.TabIndex = 113
        '
        'cboSubLot
        '
        Me.cboSubLot.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSubLot.AllowColMove = False
        Me.cboSubLot.AutoCompletion = True
        Me.cboSubLot.AutoDropDown = True
        Me.cboSubLot.Caption = ""
        Me.cboSubLot.CaptionHeight = 17
        Me.cboSubLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSubLot.ColumnCaptionHeight = 17
        Me.cboSubLot.ColumnFooterHeight = 17
        Me.cboSubLot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboSubLot.ContentHeight = 18
        Me.cboSubLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSubLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSubLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSubLot.EditorHeight = 18
        Me.cboSubLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubLot.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.cboSubLot.ItemHeight = 20
        Me.cboSubLot.Location = New System.Drawing.Point(104, 80)
        Me.cboSubLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboSubLot.MaxDropDownItems = CType(20, Short)
        Me.cboSubLot.MaxLength = 32767
        Me.cboSubLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSubLot.Name = "cboSubLot"
        Me.cboSubLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSubLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSubLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSubLot.Size = New System.Drawing.Size(176, 24)
        Me.cboSubLot.TabIndex = 1
        Me.cboSubLot.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Contr" & _
        "ol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Sty" & _
        "le10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
        "tBoxView AllowColMove=""False"" AllowColSelect=""False"" Name=""Split[0,0]"" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=""" & _
        "1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 156</ClientRect><Height>156<" & _
        "/Height><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Height" & _
        "></HScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowStyle parent=""" & _
        "EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pa" & _
        "rent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLi" & _
        "ghtRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactive""" & _
        " me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle p" & _
        "arent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Style" & _
        "5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits><" & _
        "NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /" & _
        "><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><S" & _
        "tyle parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><St" & _
        "yle parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><S" & _
        "tyle parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /" & _
        "><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><h" & _
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
        Me.cboLot.AutoSelect = True
        Me.cboLot.Caption = ""
        Me.cboLot.CaptionHeight = 17
        Me.cboLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLot.ColumnCaptionHeight = 17
        Me.cboLot.ColumnFooterHeight = 17
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.Images.Add(CType(resources.GetObject("resource8"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(104, 48)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(121, 24)
        Me.cboLot.TabIndex = 0
        Me.cboLot.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Contr" & _
        "ol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Sty" & _
        "le10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
        "tBoxView AllowColMove=""False"" AllowColSelect=""False"" Name=""Split[0,0]"" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=""" & _
        "1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 156</ClientRect><Height>156<" & _
        "/Height><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Height" & _
        "></HScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowStyle parent=""" & _
        "EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pa" & _
        "rent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLi" & _
        "ghtRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactive""" & _
        " me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle p" & _
        "arent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Style" & _
        "5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits><" & _
        "NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /" & _
        "><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><S" & _
        "tyle parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><St" & _
        "yle parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><S" & _
        "tyle parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /" & _
        "><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><h" & _
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'mnuFB
        '
        Me.mnuFB.Index = 0
        Me.mnuFB.Text = "Fish &Bins"
        '
        'gridBin
        '
        Me.gridBin.AllowAddNew = True
        Me.gridBin.AllowColMove = False
        Me.gridBin.AllowDelete = True
        Me.gridBin.CaptionHeight = 17
        Me.gridBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBin.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridBin.Images.Add(CType(resources.GetObject("resource9"), System.Drawing.Image))
        Me.gridBin.Location = New System.Drawing.Point(8, 240)
        Me.gridBin.Name = "gridBin"
        Me.gridBin.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridBin.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridBin.PreviewInfo.ZoomFactor = 75
        Me.gridBin.RowHeight = 20
        Me.gridBin.Size = New System.Drawing.Size(896, 256)
        Me.gridBin.TabIndex = 5
        Me.gridBin.Text = "C1TrueDBGrid1"
        Me.gridBin.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;" & _
        "}Style13{}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColo" & _
        "r:ControlText;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14" & _
        "{}Style15{}Style9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowC" & _
        "olMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterH" & _
        "eight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWid" & _
        "th=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>252</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 892, 252</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>16</DefaultRecSelWidth><ClientArea>0, 0, 892, 252</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cboCS
        '
        Me.cboCS.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCS.AllowColMove = False
        Me.cboCS.AutoCompletion = True
        Me.cboCS.AutoDropDown = True
        Me.cboCS.Caption = ""
        Me.cboCS.CaptionHeight = 17
        Me.cboCS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCS.ColumnCaptionHeight = 17
        Me.cboCS.ColumnFooterHeight = 17
        Me.cboCS.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCS.ContentHeight = 18
        Me.cboCS.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCS.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCS.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCS.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCS.EditorHeight = 18
        Me.cboCS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCS.Images.Add(CType(resources.GetObject("resource10"), System.Drawing.Image))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(376, 80)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(20, Short)
        Me.cboCS.MaxLength = 32767
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.Size = New System.Drawing.Size(208, 24)
        Me.cboCS.TabIndex = 3
        Me.cboCS.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Contr" & _
        "ol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Sty" & _
        "le10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
        "tBoxView AllowColMove=""False"" AllowColSelect=""False"" Name=""Split[0,0]"" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=""" & _
        "1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 156</ClientRect><Height>156<" & _
        "/Height><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Height" & _
        "></HScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowStyle parent=""" & _
        "EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pa" & _
        "rent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLi" & _
        "ghtRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactive""" & _
        " me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle p" & _
        "arent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Style" & _
        "5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits><" & _
        "NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /" & _
        "><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><S" & _
        "tyle parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><St" & _
        "yle parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><S" & _
        "tyle parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /" & _
        "><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><h" & _
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFB, Me.mnuFS, Me.mnuFZ})
        '
        'mnuFS
        '
        Me.mnuFS.Index = 1
        Me.mnuFS.Text = "Fish &Specie"
        '
        'mnuFZ
        '
        Me.mnuFZ.Index = 2
        Me.mnuFZ.Text = "Fish Si&zes"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(912, 40)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Flake Bags Deposit Information"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 36)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Preservation Method"
        '
        'lblPreservationMethod
        '
        Me.lblPreservationMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPreservationMethod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreservationMethod.Location = New System.Drawing.Point(104, 120)
        Me.lblPreservationMethod.Name = "lblPreservationMethod"
        Me.lblPreservationMethod.Size = New System.Drawing.Size(173, 24)
        Me.lblPreservationMethod.TabIndex = 126
        Me.lblPreservationMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVessel
        '
        Me.lblVessel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVessel.Location = New System.Drawing.Point(104, 184)
        Me.lblVessel.Name = "lblVessel"
        Me.lblVessel.Size = New System.Drawing.Size(173, 24)
        Me.lblVessel.TabIndex = 114
        '
        'cmdFind
        '
        Me.cmdFind.Enabled = False
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(504, 560)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 10
        Me.cmdFind.TabStop = False
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind.Visible = False
        '
        'cmdView
        '
        Me.cmdView.Enabled = False
        Me.cmdView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdView.Location = New System.Drawing.Point(416, 560)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(86, 48)
        Me.cmdView.TabIndex = 9
        Me.cmdView.TabStop = False
        Me.cmdView.Text = "&View Inventory"
        Me.cmdView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdView.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(336, 560)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 8
        Me.cmdEdit.TabStop = False
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEdit.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(419, 512)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(339, 512)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 7
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(376, 120)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(208, 23)
        Me.txtRemarks.TabIndex = 4
        Me.txtRemarks.Text = "*"
        '
        'chkHold
        '
        Me.chkHold.Enabled = False
        Me.chkHold.Location = New System.Drawing.Point(744, 576)
        Me.chkHold.Name = "chkHold"
        Me.chkHold.TabIndex = 104
        Me.chkHold.TabStop = False
        Me.chkHold.Visible = False
        '
        'cboPositionx
        '
        Me.cboPositionx.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboPositionx.AllowColMove = False
        Me.cboPositionx.AutoCompletion = True
        Me.cboPositionx.AutoDropDown = True
        Me.cboPositionx.Caption = ""
        Me.cboPositionx.CaptionHeight = 17
        Me.cboPositionx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPositionx.ColumnCaptionHeight = 17
        Me.cboPositionx.ColumnFooterHeight = 17
        Me.cboPositionx.ContentHeight = 18
        Me.cboPositionx.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPositionx.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPositionx.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPositionx.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPositionx.EditorHeight = 18
        Me.cboPositionx.Enabled = False
        Me.cboPositionx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPositionx.Images.Add(CType(resources.GetObject("resource11"), System.Drawing.Image))
        Me.cboPositionx.ItemHeight = 20
        Me.cboPositionx.Location = New System.Drawing.Point(744, 576)
        Me.cboPositionx.MatchEntryTimeout = CType(2000, Long)
        Me.cboPositionx.MaxDropDownItems = CType(20, Short)
        Me.cboPositionx.MaxLength = 32767
        Me.cboPositionx.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPositionx.Name = "cboPositionx"
        Me.cboPositionx.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPositionx.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPositionx.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPositionx.Size = New System.Drawing.Size(208, 24)
        Me.cboPositionx.TabIndex = 103
        Me.cboPositionx.TabStop = False
        Me.cboPositionx.Visible = False
        Me.cboPositionx.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Contr" & _
        "ol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Sty" & _
        "le10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
        "tBoxView AllowColMove=""False"" AllowColSelect=""False"" Name=""Split[0,0]"" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=""" & _
        "1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 156</ClientRect><Height>156<" & _
        "/Height><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Height" & _
        "></HScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowStyle parent=""" & _
        "EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pa" & _
        "rent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLi" & _
        "ghtRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactive""" & _
        " me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle p" & _
        "arent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Style" & _
        "5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits><" & _
        "NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /" & _
        "><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><S" & _
        "tyle parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><St" & _
        "yle parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><S" & _
        "tyle parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /" & _
        "><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><h" & _
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboLocationx
        '
        Me.cboLocationx.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboLocationx.AllowColMove = False
        Me.cboLocationx.AutoCompletion = True
        Me.cboLocationx.AutoDropDown = True
        Me.cboLocationx.Caption = ""
        Me.cboLocationx.CaptionHeight = 17
        Me.cboLocationx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLocationx.ColumnCaptionHeight = 17
        Me.cboLocationx.ColumnFooterHeight = 17
        Me.cboLocationx.ContentHeight = 18
        Me.cboLocationx.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLocationx.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLocationx.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocationx.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLocationx.EditorHeight = 18
        Me.cboLocationx.Enabled = False
        Me.cboLocationx.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocationx.Images.Add(CType(resources.GetObject("resource12"), System.Drawing.Image))
        Me.cboLocationx.ItemHeight = 20
        Me.cboLocationx.Location = New System.Drawing.Point(744, 576)
        Me.cboLocationx.MatchEntryTimeout = CType(2000, Long)
        Me.cboLocationx.MaxDropDownItems = CType(20, Short)
        Me.cboLocationx.MaxLength = 32767
        Me.cboLocationx.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLocationx.Name = "cboLocationx"
        Me.cboLocationx.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLocationx.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLocationx.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLocationx.Size = New System.Drawing.Size(208, 24)
        Me.cboLocationx.TabIndex = 102
        Me.cboLocationx.TabStop = False
        Me.cboLocationx.Visible = False
        Me.cboLocationx.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Contr" & _
        "ol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Sty" & _
        "le10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
        "tBoxView AllowColMove=""False"" AllowColSelect=""False"" Name=""Split[0,0]"" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=""" & _
        "1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 156</ClientRect><Height>156<" & _
        "/Height><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Height" & _
        "></HScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowStyle parent=""" & _
        "EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pa" & _
        "rent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLi" & _
        "ghtRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactive""" & _
        " me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle p" & _
        "arent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Style" & _
        "5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits><" & _
        "NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /" & _
        "><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><S" & _
        "tyle parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><St" & _
        "yle parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><S" & _
        "tyle parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /" & _
        "><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><h" & _
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'frmFishDeposit_Loin_Bags
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(912, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.gridSummary)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cboHeight)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTotalNW)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.cboSubLot)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.gridBin)
        Me.Controls.Add(Me.cboCS)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPreservationMethod)
        Me.Controls.Add(Me.lblVessel)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.chkHold)
        Me.Controls.Add(Me.cboPositionx)
        Me.Controls.Add(Me.cboLocationx)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishDeposit_Loin_Bags"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishDeposit_Loin_Bags"
        CType(Me.gridSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPositionx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLocationx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishDeposit_Loin_Bags_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()

        displayListsOfFishBins()
        displayBatchlot()
        displayColdStorage()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayBatchlot()
        With cboLot
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 99
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtDate.Value = getServerDateTime()
    End Sub

    Public Sub displayListsOfFishBins()
        With gridBin
            .DataSource = modModule.getListsOfFishBinsForDeposit2().Tables(0)
            '.Columns(0).DropDown = cboBin
            .Columns(0).DropDown = cboSpecie
            .Columns(1).DropDown = cboType
            .Columns(2).DropDown = cboSize
            '.Columns(6).DropDown = cboLocation
            '.Columns(7).DropDown = cboPosition
            '.Columns(8).DropDown = cboHeight
            .Splits(0).DisplayColumns(0).DropDownList = True
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Splits(0).DisplayColumns(2).DropDownList = True
            ''.Splits(0).DisplayColumns(6).DropDownList = True
            ''.Splits(0).DisplayColumns(7).DropDownList = True
            ''.Splits(0).DisplayColumns(8).DropDownList = True
            'displayFishBins()
            displayFishSpecie()
            displayFishType()
            displayFishSizes()
            'displayLocation()
            'displayPosition()
            'displayHeight()

            '.Splits(0).DisplayColumns(0).Width = 90

            .Splits(0).DisplayColumns(3).Width = 90
            .Columns(3).DefaultValue = "0.0"
            .Columns(3).NumberFormat = "###,##0.0"
            .Splits(0).DisplayColumns(4).Width = 84
            .Columns(4).DefaultValue = "0.0"
            .Columns(4).NumberFormat = "###,##0.0"
            .Splits(0).DisplayColumns(4).Locked = True
            .Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(5).Width = 90
            .Columns(5).DefaultValue = "0.0"
            .Columns(5).NumberFormat = "###,##0.0"
            .Splits(0).DisplayColumns(5).Locked = True
            .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(9).Width = 120
            .Splits(0).DisplayColumns(9).Locked = True
            .Splits(0).DisplayColumns(9).Style.BackColor = Color.Gray
        End With
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displaySublot(cboLot.Text)

        searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text, txtDate.Value)
        displaySummary()
    End Sub

    Public Sub displaySublot(ByVal lot As String)
        With cboSubLot
            .Text = ""
            .DataSource = modModule.getFishLot_MethodAndVesselInfo(lot).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 65
            .Splits(0).DisplayColumns(1).Width = 105

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishSpecie()
        With cboSpecie
            .DefColWidth = 95
            .DataSource = modModule.getFishSpecie().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub

    Public Sub displayFishType()
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand("SELECT classification AS [Fish Type] " & _
                " FROM dbo.tblFlakesType", c)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("type")
            da.Fill(ds)

            cboType.DefColWidth = 95
            cboType.DataSource = ds.Tables(0)

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub displayFishSizes()
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand("SELECT canSize AS [Fish Size] " & _
                " FROM dbo.tblProduct_CanSize " & _
                " WHERE (canType = 'Frozen Loins') " & _
                " UNION " & _
                " SELECT 'Mixed' AS [Fish Size]", c)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("type")
            da.Fill(ds)

            cboSize.DefColWidth = 95
            cboSize.DataSource = ds.Tables(0)

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboSubLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubLot.TextChanged
        With cboSubLot
            If .ListCount > 0 And Not .Text = "" Then
                lblPreservationMethod.Text = .GetItemText(.Row, 1)
                lblCondition.Text = .GetItemText(.Row, 2)
                lblVessel.Text = .GetItemText(.Row, 3)
            Else
                lblPreservationMethod.Text = ""
                lblCondition.Text = ""
                lblVessel.Text = ""
            End If

            searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text, txtDate.Value)
        End With
    End Sub

    Private Sub gridBin_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles gridBin.RowColChange
        calculateWeights()
    End Sub

    Public Sub calculateWeights()
        Dim ctr As Integer
        Dim depositCode As String
        With gridBin
            While ctr < .RowCount
                Try
                    If .Item(ctr, 9) = "" Then
                        depositCode = ""
                    Else
                        depositCode = .Item(ctr, 9)
                    End If
                Catch ex As Exception
                    If .Item(ctr, 9) Is DBNull.Value Then
                        depositCode = ""
                    Else
                        depositCode = .Item(ctr, 9)
                    End If
                End Try


                '.Item(ctr, 3) = getStoredBags(depositCode) - getAllocatedBags(depositCode)
                .Item(ctr, 5) = .Item(ctr, 3) - .Item(ctr, 4)

                ctr += 1
            End While

            computeTotalNW()
            'computeSummary()
        End With
    End Sub

    Public Sub computeTotalNW()
        Dim ctr As Integer
        Dim total As Double

        While ctr < gridBin.RowCount
            total += gridBin.Item(ctr, 5)

            ctr += 1
        End While

        lblTotalNW.Text = Format(total, "###,###,##0.0")
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        cboLot.SelectAll()
        cboLot.Focus()
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        cboLot.Text = ""
        displayBatchlot()
        cboSubLot.Text = ""
        'cboSpecie.Text = ""
        'displayFishSpecie()
        'cboSize.Text = ""
        'displayFishSizes()
        'cboBin.Text = ""
        'displayFishBins()
        chkHold.Checked = False
        cboCS.Text = ""
        displayColdStorage()
        'cboLocation.Text = ""
        'displayLocation()
        'cboPosition.Text = ""
        'displayPosition()
        'Timer1.Enabled = True
        'txtDate.ReadOnly = True

        txtDate.Value = getServerDateTime()
        txtRemarks.Text = "*"
        'txtGW.Text = "0"
        'txtTW.Text = "0"
        'txtNW.Text = "0"
        'lblTotalNW.Text = "0.0"
        computeTotalNW()

        displayListsOfFishBins()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        calculateWeights()

        Dim reply As String
        'Select Case cmd.Text
        '    Case "&Save"
        If gridBin.RowCount > 0 And Not cboCS.Text.Trim = "" And Not cboLot.Text.Trim = "" And Not cboSubLot.Text.Trim = "" And _
        Not lblVessel.Text.Trim = "" And _
        CDbl(lblTotalNW.Text) > 0 And Not isGWisZero() And _
        Not isDataEntryFieldsAreEmpty() Then
            'And Not cboLocation.Text.Trim = "" And Not cboPosition.Text.Trim = ""
            If validateFishLot(cboLot.Text) Then 'Not validateFishBinsFromDepositInventory() And 
                reply = MsgBox("Are you sure you want to proceed for this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                Dim withError As Boolean = False

                If reply = vbYes Then
                    Dim index As Integer = 0

                    Dim lane, position, height As String
                    Dim undeposited As Boolean
                    With gridBin
                        While index < .RowCount
                            Try
                                If .Item(index, 6) = "" Then
                                    lane = ""
                                Else
                                    lane = .Item(index, 6)
                                End If

                                If .Item(index, 7) = "" Then
                                    position = ""
                                Else
                                    position = .Item(index, 7)
                                End If

                                If .Item(index, 8) = "" Then
                                    height = ""
                                Else
                                    height = .Item(index, 8)
                                End If

                                If .Item(index, 9) = "" Then
                                    undeposited = True
                                Else
                                    undeposited = False
                                End If
                            Catch ex As Exception
                                If .Item(index, 6) Is DBNull.Value Then
                                    lane = ""
                                Else
                                    lane = .Item(index, 6)
                                End If

                                If .Item(index, 7) Is DBNull.Value Then
                                    position = ""
                                Else
                                    position = .Item(index, 7)
                                End If

                                If .Item(index, 8) Is DBNull.Value Then
                                    height = ""
                                Else
                                    height = .Item(index, 8)
                                End If

                                If .Item(index, 9) Is DBNull.Value Then
                                    undeposited = True
                                Else
                                    undeposited = False
                                End If
                            End Try

                            If undeposited Then
                                saveNewFishBinForDeposit(generateDummyBin(), txtDate.Text, cboCS.Text, txtRemarks.Text.Trim, _
                                    cboLot.Text, .Item(index, 0), "Bags", CDbl(.Item(index, 3)), cboSubLot.Text, _
                                    False, lane, position, height, .Item(index, 1), .Item(index, 2))
                            Else
                                updateBagsDeposited(.Item(index, 9), .Item(index, 0), cboCS.Text, .Item(index, 3), _
                                    txtRemarks.Text, .Item(index, 6), .Item(index, 7), .Item(index, 8), _
                                    .Item(index, 1), .Item(index, 2))
                            End If

                            index += 1
                        End While
                    End With

                    MsgBox("Transaction completed", MsgBoxStyle.Information, "Information")

                    addNewRecord()
                    cboLot.SelectAll()
                    cboLot.Focus()
                Else
                    cboLot.SelectAll()
                    cboLot.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("Fish lot doesn't found in the database", MsgBoxStyle.Critical, "No record found")
                cboLot.SelectAll()
                cboLot.Focus()
            End If
        Else
            MsgBox("Please check your data entry fields.", MsgBoxStyle.Critical, "Result: Invalid input and check the data")
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Public Function isGWisZero() As Boolean
        Dim ctr As Integer
        While ctr < gridBin.RowCount
            If Not gridBin.Item(ctr, 3) Is DBNull.Value Then
                If CDbl(gridBin.Item(ctr, 3)) <= 0 Then
                    MsgBox("Gross Weight must not be equal to zero", MsgBoxStyle.Exclamation, "Warning")
                    Return True
                End If
            Else
                MsgBox("Gross Weight must not be equal to zero", MsgBoxStyle.Exclamation, "Warning")
                Return True
            End If

            ctr += 1
        End While

        Return False
    End Function

    Public Function isDataEntryFieldsAreEmpty() As Boolean
        Try
            Dim ctr As Integer = 0
            With gridBin
                While ctr < .RowCount
                    If .Item(ctr, 0) = "" Or .Item(ctr, 1) = "" Or .Item(ctr, 2) = "" Then
                        MsgBox("Please check your data entry fields such as Fish bin, specie and size, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                    End If

                    ctr += 1
                End While
            End With

            Return False
        Catch e As Exception
            Dim ctr As Integer = 0
            With gridBin
                While ctr < .RowCount
                    If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or .Item(ctr, 2) Is DBNull.Value Then
                        MsgBox("Please check your data entry fields such as Fish bin, specie and size, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                    End If

                    ctr += 1
                End While
            End With

            Return False
        End Try
    End Function

    Public Function generateDummyBin() As String
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim bin As String

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FishBins"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishBinCounter()

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@binCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = Format(getFishBinCounter, "FB0###")

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@bin#"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = "BG" & Format(p1.Value, "###0")
            bin = p3.Value

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@tareWeight"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.Float
            p4.Value = 0

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@dummyBin"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = "N"

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
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)

            Dim daBuyer As New SqlClient.SqlDataAdapter
            daBuyer.SelectCommand = cmd

            Dim dsBuyer As New DataSet("dbPPICIS")
            daBuyer.Fill(dsBuyer)

            daBuyer.Dispose()
            dsBuyer.Dispose()
            c.Close()

            Return bin
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Function

    Public Sub saveNewFishBinForDeposit(ByVal bin As String, ByVal dateTime As String, ByVal cs As String, _
    ByVal remarks As String, ByVal lot As String, ByVal fishSpecie As String, ByVal size As String, _
    ByVal grossWeight As Double, ByVal sublot As String, ByVal hold As Boolean, _
    ByVal location As String, ByVal position As String, ByVal height As String, _
    ByVal fishType As String, ByVal loinSize As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FishBinsDeposit2"
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
            p2.Value = "FD" & Format(getFishBinForDepositCounter, "0#####") & bin & p1.Value
            lblCode.Text = p2.Value

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
            dateTime = txtDate.Value
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
            p18.ParameterName = "@fishType"
            p18.Direction = ParameterDirection.Input
            p18.SqlDbType = SqlDbType.VarChar
            p18.Value = fishType

            Dim p19 As New SqlClient.SqlParameter
            p19.ParameterName = "@loinSize"
            p19.Direction = ParameterDirection.Input
            p19.SqlDbType = SqlDbType.VarChar
            p19.Value = loinSize

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

    Public Sub searchFishDepositDetails(ByVal lot As String, ByVal sublot As String, _
    ByVal specie As String, ByVal size As String, ByVal cs As String, ByVal receivedDate As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_FishDepositDetails_byBagsDeposited"  '"proc_display_FishDepositDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@lot"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = lot

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@sublot"
            p2.SqlDbType = SqlDbType.VarChar
            p2.Direction = ParameterDirection.Input
            If Not sublot = "" Then
                p2.Value = sublot
            Else
                p2.Value = 0
            End If

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@specie"
            p3.SqlDbType = SqlDbType.VarChar
            p3.Direction = ParameterDirection.Input
            p3.Value = specie

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@size"
            p4.SqlDbType = SqlDbType.VarChar
            p4.Direction = ParameterDirection.Input
            p4.Value = size

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@cs"
            p5.SqlDbType = SqlDbType.VarChar
            p5.Direction = ParameterDirection.Input
            p5.Value = cs

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@dateFrom"
            p6.SqlDbType = SqlDbType.DateTime
            p6.Direction = ParameterDirection.Input
            p6.Value = Format(CDate(receivedDate), "dd/MM/yyyy 00:00:01")

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@dateTo"
            p7.SqlDbType = SqlDbType.DateTime
            p7.Direction = ParameterDirection.Input
            p7.Value = Format(CDate(receivedDate), "dd/MM/yyyy 23:59:59")

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("TRAKIM")
            da.Fill(ds)

            With gridBin
                .DataSource = ds.Tables(0)
                '.Columns(0).DropDown = cboBin
                .Columns(0).DropDown = cboSpecie
                .Columns(1).DropDown = cboType
                .Columns(2).DropDown = cboSize
                '.Columns(6).DropDown = cboLocation
                '.Columns(7).DropDown = cboPosition
                '.Columns(8).DropDown = cboHeight
                .Splits(0).DisplayColumns(0).DropDownList = True
                .Splits(0).DisplayColumns(1).DropDownList = True
                .Splits(0).DisplayColumns(2).DropDownList = True
                ''.Splits(0).DisplayColumns(6).DropDownList = True
                ''.Splits(0).DisplayColumns(7).DropDownList = True
                ''.Splits(0).DisplayColumns(8).DropDownList = True
                'displayFishBins()
                displayFishSpecie()
                displayFishType()
                displayFishSizes()
                'displayLocation()
                'displayPosition()
                'displayHeight()

                '.Splits(0).DisplayColumns(0).Width = 90

                .Splits(0).DisplayColumns(3).Width = 90
                .Columns(3).DefaultValue = "0.0"
                .Columns(3).NumberFormat = "###,##0.0"
                .Splits(0).DisplayColumns(4).Width = 84
                .Columns(4).DefaultValue = "0.0"
                .Columns(4).NumberFormat = "###,##0.0"
                .Splits(0).DisplayColumns(4).Locked = True
                .Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
                .Splits(0).DisplayColumns(5).Width = 90
                .Columns(5).DefaultValue = "0.0"
                .Columns(5).NumberFormat = "###,##0.0"
                .Splits(0).DisplayColumns(5).Locked = True
                .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
                .Splits(0).DisplayColumns(9).Width = 120
                .Splits(0).DisplayColumns(9).Locked = True
                .Splits(0).DisplayColumns(9).Style.BackColor = Color.Gray
            End With

            da.Dispose()
            ds.Dispose()
            c.Close()

            calculateWeights()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displaySummary()
        With gridSummary
            .DataSource = getLotSummaryPerDeposited_Bags(cboLot.Text).Tables(0)
            .Columns(1).NumberFormat = "###,###,###,##0.#0"

            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 80

            Dim ctr As Integer
            While ctr < .RowCount
                .Item(ctr, 1) -= getAllocatedBags(cboLot.Text, .Item(ctr, 0), .Item(ctr, 2), .Item(ctr, 3))
                ctr += 1
            End While
        End With
    End Sub

    Private Sub txtDate_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.DoubleClick
        'Dim reply As String
        'reply = InputBox("Please enter security code?", "Security")
        'If reply = "soltai" Then
        '    Timer1.Enabled = False
        '    txtDate.Value = getServerDateTime()
        '    txtDate.ReadOnly = False
        '    txtDate.SelectAll()
        '    txtDate.Focus()
        'End If
    End Sub
End Class
