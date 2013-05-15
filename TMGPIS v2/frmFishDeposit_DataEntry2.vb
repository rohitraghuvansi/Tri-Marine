Public Class frmFishDeposit_DataEntry2
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
    Friend WithEvents lblPreservationMethod As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblVessel As System.Windows.Forms.Label
    Friend WithEvents lblCondition As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboSubLot As C1.Win.C1List.C1Combo
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cboBin As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents gridBin As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuFB As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFS As System.Windows.Forms.MenuItem
    Friend WithEvents lblTotalNW As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mnuFZ As System.Windows.Forms.MenuItem
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents cboSpecie As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboSize As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboLocationx As C1.Win.C1List.C1Combo
    Friend WithEvents cboPositionx As C1.Win.C1List.C1Combo
    Friend WithEvents cboHeight As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboPosition As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboLocation As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents chkHold As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gridSummary As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grpBin As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboEBin As C1.Win.C1List.C1Combo
    Friend WithEvents txtEGW As System.Windows.Forms.TextBox
    Friend WithEvents txtERemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblETW As System.Windows.Forms.Label
    Friend WithEvents lblENW As System.Windows.Forms.Label
    Friend WithEvents cmdESave As System.Windows.Forms.Button
    Friend WithEvents cmdEClose As System.Windows.Forms.Button
    Friend WithEvents lblLot As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents gridSummaryBin As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblETotal As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishDeposit_DataEntry2))
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.cboSubLot = New C1.Win.C1List.C1Combo
        Me.cboCS = New C1.Win.C1List.C1Combo
        Me.cboLocationx = New C1.Win.C1List.C1Combo
        Me.cboPositionx = New C1.Win.C1List.C1Combo
        Me.chkHold = New System.Windows.Forms.CheckBox
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.gridBin = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPreservationMethod = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDate = New C1.Win.C1Input.C1DateEdit
        Me.lblVessel = New System.Windows.Forms.Label
        Me.lblCondition = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboBin = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuFB = New System.Windows.Forms.MenuItem
        Me.mnuFS = New System.Windows.Forms.MenuItem
        Me.mnuFZ = New System.Windows.Forms.MenuItem
        Me.lblTotalNW = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboSpecie = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboSize = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cboHeight = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboPosition = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboLocation = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me.gridSummary = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label5 = New System.Windows.Forms.Label
        Me.grpBin = New System.Windows.Forms.GroupBox
        Me.lblETotal = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.gridSummaryBin = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.lblLot = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmdEClose = New System.Windows.Forms.Button
        Me.cmdESave = New System.Windows.Forms.Button
        Me.lblENW = New System.Windows.Forms.Label
        Me.lblETW = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtERemarks = New System.Windows.Forms.TextBox
        Me.txtEGW = New System.Windows.Forms.TextBox
        Me.cboEBin = New C1.Win.C1List.C1Combo
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLocationx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPositionx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBin.SuspendLayout()
        CType(Me.gridSummaryBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEBin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cboLot.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(101, 53)
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
        Me.cboSubLot.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboSubLot.ItemHeight = 20
        Me.cboSubLot.Location = New System.Drawing.Point(101, 84)
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
        Me.cboCS.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(376, 84)
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
        Me.cboLocationx.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboLocationx.ItemHeight = 20
        Me.cboLocationx.Location = New System.Drawing.Point(744, 528)
        Me.cboLocationx.MatchEntryTimeout = CType(2000, Long)
        Me.cboLocationx.MaxDropDownItems = CType(20, Short)
        Me.cboLocationx.MaxLength = 32767
        Me.cboLocationx.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLocationx.Name = "cboLocationx"
        Me.cboLocationx.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLocationx.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLocationx.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLocationx.Size = New System.Drawing.Size(208, 24)
        Me.cboLocationx.TabIndex = 3
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
        Me.cboPositionx.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboPositionx.ItemHeight = 20
        Me.cboPositionx.Location = New System.Drawing.Point(744, 560)
        Me.cboPositionx.MatchEntryTimeout = CType(2000, Long)
        Me.cboPositionx.MaxDropDownItems = CType(20, Short)
        Me.cboPositionx.MaxLength = 32767
        Me.cboPositionx.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPositionx.Name = "cboPositionx"
        Me.cboPositionx.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPositionx.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPositionx.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPositionx.Size = New System.Drawing.Size(208, 24)
        Me.cboPositionx.TabIndex = 4
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
        'chkHold
        '
        Me.chkHold.Enabled = False
        Me.chkHold.Location = New System.Drawing.Point(744, 592)
        Me.chkHold.Name = "chkHold"
        Me.chkHold.TabIndex = 5
        Me.chkHold.TabStop = False
        Me.chkHold.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(376, 121)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(208, 23)
        Me.txtRemarks.TabIndex = 4
        Me.txtRemarks.Text = "*"
        '
        'gridBin
        '
        Me.gridBin.AllowAddNew = True
        Me.gridBin.AllowColMove = False
        Me.gridBin.AllowDelete = True
        Me.gridBin.CaptionHeight = 17
        Me.gridBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBin.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridBin.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
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
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(173, 512)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 7
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(253, 512)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(333, 512)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 8
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdView
        '
        Me.cmdView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdView.Location = New System.Drawing.Point(413, 512)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(86, 48)
        Me.cmdView.TabIndex = 9
        Me.cmdView.Text = "&View Inventory"
        Me.cmdView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(504, 512)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 10
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 36)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Preservation Method"
        '
        'lblPreservationMethod
        '
        Me.lblPreservationMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPreservationMethod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreservationMethod.Location = New System.Drawing.Point(101, 120)
        Me.lblPreservationMethod.Name = "lblPreservationMethod"
        Me.lblPreservationMethod.Size = New System.Drawing.Size(173, 24)
        Me.lblPreservationMethod.TabIndex = 82
        Me.lblPreservationMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(288, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 19)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Date/ Time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(288, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 19)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Remarks"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 19)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Vessel Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 19)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Fish Condition"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 19)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Sub-lot#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(688, 600)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 19)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Hold"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(688, 560)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 74
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
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Lot No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(288, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 19)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Cold Storage"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(647, 528)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 19)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Location"
        Me.Label12.Visible = False
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(376, 54)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(208, 23)
        Me.txtDate.TabIndex = 2
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblVessel
        '
        Me.lblVessel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVessel.Location = New System.Drawing.Point(101, 184)
        Me.lblVessel.Name = "lblVessel"
        Me.lblVessel.Size = New System.Drawing.Size(173, 24)
        Me.lblVessel.TabIndex = 69
        '
        'lblCondition
        '
        Me.lblCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCondition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondition.Location = New System.Drawing.Point(101, 152)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(173, 24)
        Me.lblCondition.TabIndex = 68
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(688, 624)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(216, 56)
        Me.lblCode.TabIndex = 67
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCode.Visible = False
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
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Fish Deposit Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Fish Bin Details"
        '
        'cboBin
        '
        Me.cboBin.AllowColMove = True
        Me.cboBin.AllowColSelect = True
        Me.cboBin.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboBin.AlternatingRows = False
        Me.cboBin.CaptionHeight = 17
        Me.cboBin.ColumnCaptionHeight = 17
        Me.cboBin.ColumnFooterHeight = 17
        Me.cboBin.FetchRowStyles = False
        Me.cboBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.cboBin.Location = New System.Drawing.Point(8, 264)
        Me.cboBin.Name = "cboBin"
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboBin.RowHeight = 20
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.ScrollTips = False
        Me.cboBin.Size = New System.Drawing.Size(83, 232)
        Me.cboBin.TabIndex = 86
        Me.cboBin.Text = "C1TrueDBDropdown1"
        Me.cboBin.Visible = False
        Me.cboBin.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 79, 228</ClientRect><BorderSide>0<" & _
        "/BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 79, 228</ClientArea></Blob>"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFB, Me.mnuFS, Me.mnuFZ})
        '
        'mnuFB
        '
        Me.mnuFB.Index = 0
        Me.mnuFB.Text = "Fish &Bins"
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
        'lblTotalNW
        '
        Me.lblTotalNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNW.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNW.Location = New System.Drawing.Point(376, 152)
        Me.lblTotalNW.Name = "lblTotalNW"
        Me.lblTotalNW.Size = New System.Drawing.Size(208, 80)
        Me.lblTotalNW.TabIndex = 87
        Me.lblTotalNW.Text = "0.00"
        Me.lblTotalNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Total NW"
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
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.cboSpecie.Location = New System.Drawing.Point(80, 264)
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboSpecie.RowHeight = 20
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.ScrollTips = False
        Me.cboSpecie.Size = New System.Drawing.Size(104, 232)
        Me.cboSpecie.TabIndex = 89
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
        Me.cboSize.Images.Add(CType(resources.GetObject("resource8"), System.Drawing.Image))
        Me.cboSize.Location = New System.Drawing.Point(184, 264)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboSize.RowHeight = 20
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.ScrollTips = False
        Me.cboSize.Size = New System.Drawing.Size(104, 232)
        Me.cboSize.TabIndex = 90
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
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(584, 512)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.cboHeight.Images.Add(CType(resources.GetObject("resource9"), System.Drawing.Image))
        Me.cboHeight.Location = New System.Drawing.Point(776, 264)
        Me.cboHeight.Name = "cboHeight"
        Me.cboHeight.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboHeight.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboHeight.RowHeight = 20
        Me.cboHeight.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboHeight.ScrollTips = False
        Me.cboHeight.Size = New System.Drawing.Size(104, 232)
        Me.cboHeight.TabIndex = 94
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
        Me.cboPosition.Images.Add(CType(resources.GetObject("resource10"), System.Drawing.Image))
        Me.cboPosition.Location = New System.Drawing.Point(672, 264)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPosition.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboPosition.RowHeight = 20
        Me.cboPosition.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPosition.ScrollTips = False
        Me.cboPosition.Size = New System.Drawing.Size(104, 232)
        Me.cboPosition.TabIndex = 93
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
        Me.cboLocation.Images.Add(CType(resources.GetObject("resource11"), System.Drawing.Image))
        Me.cboLocation.Location = New System.Drawing.Point(600, 264)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLocation.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboLocation.RowHeight = 20
        Me.cboLocation.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLocation.ScrollTips = False
        Me.cboLocation.Size = New System.Drawing.Size(104, 232)
        Me.cboLocation.TabIndex = 92
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
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(664, 512)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'gridSummary
        '
        Me.gridSummary.AllowColMove = False
        Me.gridSummary.AllowUpdate = False
        Me.gridSummary.CaptionHeight = 17
        Me.gridSummary.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSummary.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSummary.Images.Add(CType(resources.GetObject("resource12"), System.Drawing.Image))
        Me.gridSummary.Location = New System.Drawing.Point(598, 84)
        Me.gridSummary.Name = "gridSummary"
        Me.gridSummary.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSummary.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSummary.PreviewInfo.ZoomFactor = 75
        Me.gridSummary.RowHeight = 20
        Me.gridSummary.Size = New System.Drawing.Size(306, 148)
        Me.gridSummary.TabIndex = 96
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(598, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Summary Details"
        '
        'grpBin
        '
        Me.grpBin.Controls.Add(Me.lblETotal)
        Me.grpBin.Controls.Add(Me.Label23)
        Me.grpBin.Controls.Add(Me.gridSummaryBin)
        Me.grpBin.Controls.Add(Me.lblLot)
        Me.grpBin.Controls.Add(Me.Label22)
        Me.grpBin.Controls.Add(Me.cmdEClose)
        Me.grpBin.Controls.Add(Me.cmdESave)
        Me.grpBin.Controls.Add(Me.lblENW)
        Me.grpBin.Controls.Add(Me.lblETW)
        Me.grpBin.Controls.Add(Me.Label20)
        Me.grpBin.Controls.Add(Me.Label19)
        Me.grpBin.Controls.Add(Me.Label11)
        Me.grpBin.Controls.Add(Me.Label9)
        Me.grpBin.Controls.Add(Me.Label8)
        Me.grpBin.Controls.Add(Me.txtERemarks)
        Me.grpBin.Controls.Add(Me.txtEGW)
        Me.grpBin.Controls.Add(Me.cboEBin)
        Me.grpBin.Enabled = False
        Me.grpBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBin.Location = New System.Drawing.Point(8, 48)
        Me.grpBin.Name = "grpBin"
        Me.grpBin.Size = New System.Drawing.Size(896, 512)
        Me.grpBin.TabIndex = 98
        Me.grpBin.TabStop = False
        Me.grpBin.Visible = False
        '
        'lblETotal
        '
        Me.lblETotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblETotal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETotal.Location = New System.Drawing.Point(104, 464)
        Me.lblETotal.Name = "lblETotal"
        Me.lblETotal.Size = New System.Drawing.Size(272, 40)
        Me.lblETotal.TabIndex = 16
        Me.lblETotal.Text = "0.00"
        Me.lblETotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 475)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 19)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Total Quantity"
        '
        'gridSummaryBin
        '
        Me.gridSummaryBin.AllowColMove = False
        Me.gridSummaryBin.AllowUpdate = False
        Me.gridSummaryBin.CaptionHeight = 17
        Me.gridSummaryBin.Dock = System.Windows.Forms.DockStyle.Right
        Me.gridSummaryBin.FilterBar = True
        Me.gridSummaryBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSummaryBin.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSummaryBin.Images.Add(CType(resources.GetObject("resource13"), System.Drawing.Image))
        Me.gridSummaryBin.Location = New System.Drawing.Point(397, 19)
        Me.gridSummaryBin.Name = "gridSummaryBin"
        Me.gridSummaryBin.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSummaryBin.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSummaryBin.PreviewInfo.ZoomFactor = 75
        Me.gridSummaryBin.RowHeight = 20
        Me.gridSummaryBin.Size = New System.Drawing.Size(496, 490)
        Me.gridSummaryBin.TabIndex = 14
        Me.gridSummaryBin.Text = "C1TrueDBGrid1"
        Me.gridSummaryBin.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Tahoma, 9.75pt;}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}He" & _
        "ading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTex" & _
        "t;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}S" & _
        "tyle9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""Fals" & _
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" F" & _
        "ilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecS" & _
        "elWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>486</Heig" & _
        "ht><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=" & _
        """Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""" & _
        "FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle" & _
        " parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><Hig" & _
        "hLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inacti" & _
        "ve"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyl" & _
        "e parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""St" & _
        "yle6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 492, 486</ClientR" & _
        "ect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDB" & _
        "Grid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style paren" & _
        "t=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""H" & _
        "eading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""No" & _
        "rmal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal" & _
        """ me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Norma" & _
        "l"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""No" & _
        "rmal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertS" & _
        "plits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSe" & _
        "lWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 492, 486</ClientArea><PrintPageH" & _
        "eaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15""" & _
        " /></Blob>"
        '
        'lblLot
        '
        Me.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLot.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.Location = New System.Drawing.Point(104, 24)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(172, 35)
        Me.lblLot.TabIndex = 13
        Me.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 19)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Lot No."
        '
        'cmdEClose
        '
        Me.cmdEClose.Image = CType(resources.GetObject("cmdEClose.Image"), System.Drawing.Image)
        Me.cmdEClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEClose.Location = New System.Drawing.Point(200, 336)
        Me.cmdEClose.Name = "cmdEClose"
        Me.cmdEClose.Size = New System.Drawing.Size(88, 48)
        Me.cmdEClose.TabIndex = 11
        Me.cmdEClose.Text = "&Close"
        Me.cmdEClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdESave
        '
        Me.cmdESave.Image = CType(resources.GetObject("cmdESave.Image"), System.Drawing.Image)
        Me.cmdESave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdESave.Location = New System.Drawing.Point(104, 336)
        Me.cmdESave.Name = "cmdESave"
        Me.cmdESave.Size = New System.Drawing.Size(88, 48)
        Me.cmdESave.TabIndex = 10
        Me.cmdESave.Text = "&Save"
        Me.cmdESave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblENW
        '
        Me.lblENW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblENW.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblENW.Location = New System.Drawing.Point(104, 189)
        Me.lblENW.Name = "lblENW"
        Me.lblENW.Size = New System.Drawing.Size(172, 40)
        Me.lblENW.TabIndex = 9
        Me.lblENW.Text = "0.00"
        Me.lblENW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblETW
        '
        Me.lblETW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblETW.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETW.Location = New System.Drawing.Point(104, 144)
        Me.lblETW.Name = "lblETW"
        Me.lblETW.Size = New System.Drawing.Size(172, 35)
        Me.lblETW.TabIndex = 8
        Me.lblETW.Text = "0.00"
        Me.lblETW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 19)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Net Weight"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 19)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Tare Weight"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Remarks"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Gross Weight"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Bin No."
        '
        'txtERemarks
        '
        Me.txtERemarks.Location = New System.Drawing.Point(104, 240)
        Me.txtERemarks.Multiline = True
        Me.txtERemarks.Name = "txtERemarks"
        Me.txtERemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtERemarks.Size = New System.Drawing.Size(276, 79)
        Me.txtERemarks.TabIndex = 2
        Me.txtERemarks.Text = ""
        '
        'txtEGW
        '
        Me.txtEGW.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEGW.Location = New System.Drawing.Point(104, 100)
        Me.txtEGW.Name = "txtEGW"
        Me.txtEGW.Size = New System.Drawing.Size(172, 33)
        Me.txtEGW.TabIndex = 1
        Me.txtEGW.Text = "0"
        Me.txtEGW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboEBin
        '
        Me.cboEBin.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboEBin.AllowColMove = False
        Me.cboEBin.AutoCompletion = True
        Me.cboEBin.AutoDropDown = True
        Me.cboEBin.Caption = ""
        Me.cboEBin.CaptionHeight = 17
        Me.cboEBin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEBin.ColumnCaptionHeight = 17
        Me.cboEBin.ColumnFooterHeight = 17
        Me.cboEBin.ContentHeight = 18
        Me.cboEBin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboEBin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboEBin.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEBin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEBin.EditorHeight = 18
        Me.cboEBin.Images.Add(CType(resources.GetObject("resource14"), System.Drawing.Image))
        Me.cboEBin.ItemHeight = 20
        Me.cboEBin.Location = New System.Drawing.Point(104, 67)
        Me.cboEBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboEBin.MaxDropDownItems = CType(10, Short)
        Me.cboEBin.MaxLength = 32767
        Me.cboEBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboEBin.Name = "cboEBin"
        Me.cboEBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboEBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboEBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboEBin.Size = New System.Drawing.Size(176, 24)
        Me.cboEBin.TabIndex = 0
        Me.cboEBin.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:Near;}OddRow{}Reco" & _
        "rdSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Border:Raised,," & _
        "1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{}Style11{}St" & _
        "yle1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColMove=""False"" Al" & _
        "lowColSelect=""False"" Name=""Split[0,0]"" CaptionHeight=""17"" ColumnCaptionHeight=""1" & _
        "7"" ColumnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Cl" & _
        "ientRect>0, 0, 116, 156</ClientRect><Height>156</Height><VScrollBar><Width>16</W" & _
        "idth></VScrollBar><HScrollBar><Height>16</Height></HScrollBar><CaptionStyle pare" & _
        "nt=""Style2"" me=""Style9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterSt" & _
        "yle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><Hea" & _
        "dingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow" & _
        """ me=""Style6"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle pare" & _
        "nt=""OddRow"" me=""Style8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style" & _
        "10"" /><SelectedStyle parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""" & _
        "Style1"" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent="""" me=" & _
        """Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foo" & _
        "ter"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inacti" & _
        "ve"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Gro" & _
        "up"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>" & _
        "Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>"
        '
        'frmFishDeposit_DataEntry2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(912, 567)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.grpBin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.gridSummary)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cboHeight)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.lblTotalNW)
        Me.Controls.Add(Me.cboBin)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPreservationMethod)
        Me.Controls.Add(Me.lblVessel)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.gridBin)
        Me.Controls.Add(Me.chkHold)
        Me.Controls.Add(Me.cboPositionx)
        Me.Controls.Add(Me.cboLocationx)
        Me.Controls.Add(Me.cboCS)
        Me.Controls.Add(Me.cboSubLot)
        Me.Controls.Add(Me.cboLot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishDeposit_DataEntry2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishDeposit_DataEntry2"
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLocationx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPositionx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBin.ResumeLayout(False)
        CType(Me.gridSummaryBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEBin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishDeposit_DataEntry2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()

        displayListsOfFishBins()
        displayBatchlot()
        displayColdStorage()
    End Sub

    Public Sub displayListsOfFishBins()
        With gridBin
            .DataSource = modModule.getListsOfFishBinsForDeposit().Tables(0)
            .Columns(0).DropDown = cboBin
            .Columns(1).DropDown = cboSpecie
            .Columns(2).DropDown = cboSize
            .Columns(6).DropDown = cboLocation
            .Columns(7).DropDown = cboPosition
            .Columns(8).DropDown = cboHeight
            '.Splits(0).DisplayColumns(0).DropDownList = True
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Splits(0).DisplayColumns(2).DropDownList = True
            '.Splits(0).DisplayColumns(6).DropDownList = True
            '.Splits(0).DisplayColumns(7).DropDownList = True
            '.Splits(0).DisplayColumns(8).DropDownList = True
            displayFishBins()
            displayFishSpecie()
            displayFishSizes()
            displayLocation()
            displayPosition()
            displayHeight()

            .Splits(0).DisplayColumns(0).Width = 80

            .Splits(0).DisplayColumns(3).Width = 90
            .Columns(3).DefaultValue = "0.0"
            .Columns(3).NumberFormat = "###,##0.0"
            .Splits(0).DisplayColumns(4).Width = 90
            .Columns(4).DefaultValue = "0.0"
            .Columns(4).NumberFormat = "###,##0.0"
            .Splits(0).DisplayColumns(4).Locked = True
            .Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(5).Width = 90
            .Columns(5).DefaultValue = "0.0"
            .Columns(5).NumberFormat = "###,##0.0"
            .Splits(0).DisplayColumns(5).Locked = True
            .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
        End With
    End Sub

    Public Sub displayFishBins()
        With cboBin
            .DefColWidth = 60
            .DataSource = modModule.getAllFishBins_AvailableForDeposit().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 99
        End With
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayPosition()
        With cboPosition
            .DefColWidth = 80
            .DataSource = modModule.getPosition().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayHeight()
        With cboHeight
            .DefColWidth = 80
            .DataSource = modModule.getHeight().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayLocation()
        With cboLocation
            .DefColWidth = 80
            .DataSource = modModule.getLocation().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayBatchlot()
        With cboLot
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 99
        End With
    End Sub

    Public Sub displayFishSpecie()
        With cboSpecie
            .DefColWidth = 80
            .DataSource = modModule.getFishSpecie().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub

    Private Sub cboCS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPositionx.TextChanged
        If cboCS.Text = "" Then If cboCS.ListCount > 0 Then cboCS.SelectedIndex = 0

        'searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text)
    End Sub

    Public Sub displayFishSizes()
        With cboSize
            .DefColWidth = 80
            .DataSource = modModule.getFishSizeRanges().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    'Private Sub cboSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLocation.TextChanged
    '    If cboSize.Text = "" Then If cboSize.ListCount > 0 Then cboSize.SelectedIndex = 0

    '    'searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text)
    'End Sub

    Public Sub displaySublot(ByVal lot As String)
        With cboSubLot
            .Text = ""
            .DataSource = modModule.getFishLot_MethodAndVesselInfo(lot).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 65
            .Splits(0).DisplayColumns(1).Width = 105

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displaySublot(cboLot.Text)

        searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text, txtDate.Value)
        displaySummary()
        'searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text)
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

    Public Function computeNetWeight(ByVal gross As String, ByVal tare As String) As Double
        If gross = "" Then gross = 0
        If tare = "" Then tare = 0

        'txtNW.Text = Format(gross - tare, "###,###,##0.#0")
        Return gross - tare
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        calculateWeights()

        Dim reply As String
        'Select Case cmd.Text
        '    Case "&Save"
        If gridBin.RowCount > 0 And Not cboCS.Text.Trim = "" And Not cboLot.Text.Trim = "" And Not cboSubLot.Text.Trim = "" And _
        Not lblVessel.Text.Trim = "" And _
        CDbl(lblTotalNW.Text) > 0 And Not isGWisZero() And _
        Not isDataEntryFieldsAreEmpty() And Not isFishBinFoundDuplicate() Then
            'And Not cboLocation.Text.Trim = "" And Not cboPosition.Text.Trim = ""
            If validateFishLot(cboLot.Text) Then 'Not validateFishBinsFromDepositInventory() And 
                If Not validateFishBinsExistence() Then
                    reply = MsgBox("Are you sure you want to proceed for this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    Dim withError As Boolean = False

                    If reply = vbYes Then
                        Dim index As Integer = 0

                        Dim lane, position, height As String

                        While index < gridBin.RowCount
                            Try
                                If gridBin.Item(index, 6) = "" Then
                                    lane = ""
                                Else
                                    lane = gridBin.Item(index, 6)
                                End If

                                If gridBin.Item(index, 7) = "" Then
                                    position = ""
                                Else
                                    position = gridBin.Item(index, 7)
                                End If

                                If gridBin.Item(index, 8) = "" Then
                                    height = ""
                                Else
                                    height = gridBin.Item(index, 8)
                                End If
                            Catch ex As Exception
                                If gridBin.Item(index, 6) Is DBNull.Value Then
                                    lane = ""
                                Else
                                    lane = gridBin.Item(index, 6)
                                End If

                                If gridBin.Item(index, 7) Is DBNull.Value Then
                                    position = ""
                                Else
                                    position = gridBin.Item(index, 7)
                                End If

                                If gridBin.Item(index, 8) Is DBNull.Value Then
                                    height = ""
                                Else
                                    height = gridBin.Item(index, 8)
                                End If
                            End Try

                            If validateFishBinDeposited(cboLot.Text, gridBin.Item(index, 0), cboSubLot.Text) Then
                                updateFishBinDeposited(cboLot.Text, cboSubLot.Text, cboCS.Text, txtRemarks.Text, _
                                    gridBin.Item(index, 0), gridBin.Item(index, 1), gridBin.Item(index, 2), _
                                    gridBin.Item(index, 3), lane, position, height)
                            Else
                                If Not modModule.validateFishBinsFromDepositInventory(gridBin.Item(index, 0)) Then
                                    saveNewFishBinForDeposit(gridBin.Item(index, 0), txtDate.Text, cboCS.Text, txtRemarks.Text.Trim, _
                                        cboLot.Text, gridBin.Item(index, 1), gridBin.Item(index, 2), CDbl(gridBin.Item(index, 3)), cboSubLot.Text, _
                                        False, lane, position, height)
                                Else
                                    withError = True
                                    MsgBox("Fish bin number " & gridBin.Item(index, 0) & " already used in the system" & Chr(13) & _
                                        "Therefore, that the referring bin number will not be saved again for fish deposits", MsgBoxStyle.Exclamation, "Warning")
                                End If
                            End If

                            index += 1
                        End While

                        If withError Then
                            MsgBox("Transaction completed but with errors.", MsgBoxStyle.Information, "Information")
                        Else
                            MsgBox("You have successfully finished the transaction", MsgBoxStyle.Information, "Information")
                        End If

                        addNewRecord()
                        cboLot.SelectAll()
                        cboLot.Focus()
                    Else
                        cboLot.SelectAll()
                        cboLot.Focus()
                        Exit Sub
                    End If
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

    Public Sub saveNewFishBinForDeposit(ByVal bin As String, ByVal dateTime As String, ByVal cs As String, _
    ByVal remarks As String, ByVal lot As String, ByVal fishSpecie As String, ByVal size As String, _
    ByVal grossWeight As Double, ByVal sublot As String, ByVal hold As Boolean, _
    ByVal location As String, ByVal position As String, ByVal height As String)
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
            'dateTime = txtDate.Value
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

    'RETURNS TRUE IF FOUND FISH BIN IN THE COLD STORAGE INVENTORY
    Public Function validateFishBinsFromDepositInventory() As Boolean
        Dim ctr As Integer
        While ctr < gridBin.RowCount
            If Not gridBin.Item(ctr, 0) Is DBNull.Value Then
                If modModule.validateFishBinsFromDepositInventory(gridBin.Item(ctr, 0)) Then
                    MsgBox("Please withdraw Fish Bin No. " & gridBin.Item(ctr, 0) & " in the cold storage inventory before you can re-use it again.", MsgBoxStyle.Critical, "Result: Found Fish Bin in the inventory.")
                    Return True
                End If
            Else
                Return True
            End If

            ctr += 1
        End While

        Return False
    End Function

    Public Sub calculateWeights()
        Dim ctr As Integer
        While ctr < gridBin.RowCount
            If Not gridBin.Item(ctr, 0) Is DBNull.Value Then
                'If validateFishBinDeposited(gridBin.Item(ctr, 0)) Then
                '    gridBin.Item(ctr, 4) = 0
                'Else
                gridBin.Item(ctr, 4) = getFishBinTareWeight(gridBin.Item(ctr, 0))
                'End If

                gridBin.Item(ctr, 5) = gridBin.Item(ctr, 3) - gridBin.Item(ctr, 4)
            Else
                gridBin.Item(ctr, 4) = 0
                gridBin.Item(ctr, 5) = 0
            End If

            ctr += 1
        End While

        computeTotalNW()
        'computeSummary()
    End Sub

    Private Sub gridBin_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles gridBin.RowColChange
        calculateWeights()
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
            displaySummary()
            'searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text)
        End With
    End Sub

    Public Sub searchFishDepositDetails(ByVal lot As String, ByVal sublot As String, _
    ByVal specie As String, ByVal size As String, ByVal cs As String, ByVal receivedDate As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_FishDepositDetails_byReceivedDate"  '"proc_display_FishDepositDetails"
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
            p6.Value = Format(CDate(receivedDate), getTimeFormat()) ' 00:00:01")

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@dateTo"
            p7.SqlDbType = SqlDbType.DateTime
            p7.Direction = ParameterDirection.Input
            p7.Value = Format(CDate(receivedDate), getTimeFormat()) ' 23:59:59")

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
                .Columns(0).DropDown = cboBin
                .Columns(1).DropDown = cboSpecie
                .Columns(2).DropDown = cboSize
                '.Splits(0).DisplayColumns(0).DropDownList = True
                .Splits(0).DisplayColumns(1).DropDownList = True
                .Splits(0).DisplayColumns(2).DropDownList = True
                displayFishBins()
                displayFishSpecie()
                displayFishSizes()

                .Splits(0).DisplayColumns(0).Width = 80

                .Splits(0).DisplayColumns(3).Width = 90
                .Columns(3).DefaultValue = "0.0"
                .Columns(3).NumberFormat = "###,##0.0"
                .Splits(0).DisplayColumns(4).Width = 90
                .Columns(4).DefaultValue = "0.0"
                .Columns(4).NumberFormat = "###,##0.0"
                .Splits(0).DisplayColumns(4).Locked = True
                .Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
                .Splits(0).DisplayColumns(5).Width = 90
                .Columns(5).DefaultValue = "0.0"
                .Columns(5).NumberFormat = "###,##0.0"
                .Splits(0).DisplayColumns(5).Locked = True
                .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
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

    Private Sub mnuFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFB.Click
        Dim f As New frmFishBin
        f.ShowDialog(Me)

        displayFishBins()
        'cboBin_TextChanged(sender, New EventArgs())

        gridBin.Focus()
    End Sub

    Private Sub mnuFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFS.Click
        Dim f As New frmSpecie2
        f.ShowDialog(Me)

        displayFishSpecie()
        'cboSpecie.SelectAll()
        gridBin.Focus()
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

    Private Sub cboSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCS.TextChanged
        searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text, txtDate.Value)
        displaySummary()
        'searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text) ', txtDate.Value)
        'searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text)
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

    Private Sub mnuFZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFZ.Click
        Dim f As New frmFishSize
        f.ShowDialog(Me)

        displayFishSizes()
        'cboSize.SelectAll()
        gridBin.Focus()
    End Sub

    Public Function isFishBinFoundDuplicate() As Boolean
        Dim outer As Integer
        Dim inner As Integer
        With gridBin
            While outer < .RowCount
                'If isFishBinFoundDuplicate(.Item(ctr, 0), ctr) Then
                '    Return True
                'End If

                inner = outer + 1
                While inner < .RowCount
                    If Not .Item(outer, 0) Is DBNull.Value And Not .Item(inner, 0) Is DBNull.Value Then
                        If .Item(outer, 0) = .Item(inner, 0) Then
                            MsgBox("You have a multiple entries of Fish bin in the lists." & Chr(13) & _
                                "Please remove bin# " & .Item(outer, 0) & " on row " & inner + 1 & " in the grid", MsgBoxStyle.Exclamation, "Warning")
                            Return True
                        End If
                    End If

                    inner += 1
                End While

                outer += 1
            End While
        End With

        Return False
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtDate.Value = getServerDateTime()
    End Sub

    'RETURNS TRUE IF FOUND FISH BIN IN THE COLD STORAGE INVENTORY
    Public Function validateFishBinsExistence() As Boolean
        Dim ctr As Integer
        While ctr < gridBin.RowCount
            If Not gridBin.Item(ctr, 0) Is DBNull.Value Then
                If Not modModule.validateFishBins(gridBin.Item(ctr, 0)) Then
                    MsgBox("Fish bin number " & gridBin.Item(ctr, 0) & " on row " & ctr + 1 & " doesn't exists in the master list of all fish bin" & Chr(13) & _
                        "Please check your fish bin before you can proceed to this transaction.", MsgBoxStyle.Exclamation, "Warning")
                    Return True
                End If
            Else
                Return True
            End If

            ctr += 1
        End While

        Return False
    End Function

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        With f
            .lblTitle.Text = "Search Fish Deposit"
            .searchType = 2
            .displayAllFishDeposits()
            .ShowDialog(Me)

            If Not .cancel Then
                'cboBin.Text = f.searchItem
                cboLot.Text = .grid.Item(.grid.Row, 0)

                cboSubLot.Text = .grid.Item(.grid.Row, 2)
                lblPreservationMethod.Text = .grid.Item(.grid.Row, 1)

                lblCondition.Text = .grid.Item(.grid.Row, 3)
                lblVessel.Text = .grid.Item(.grid.Row, 4)
                'cboSpecie.Text = .grid.Item(.grid.Row, 5)
                'cboSize.Text = .grid.Item(.grid.Row, 6)

                'If CStr(.grid.Item(.grid.Row, 7)).StartsWith("BULK") Then
                '    chkDummy.Checked = True
                'Else
                '    chkDummy.Checked = False
                'End If

                cboBin.Text = .grid.Item(.grid.Row, 7)
                cboCS.Text = .grid.Item(.grid.Row, 8)
                txtRemarks.Text = .grid.Item(.grid.Row, 9)
                Timer1.Enabled = False
                txtDate.Value = .grid.Item(.grid.Row, 10)
                'txtGW.Text = Format(CDbl(.grid.Item(.grid.Row, 11)), "###,##0.#0")
                'txtTW.Text = Format(.grid.Item(.grid.Row, 12), "###,##0.#0")
                'txtNW.Text = Format(.grid.Item(.grid.Row, 13), "###,##0.#0")
                lblCode.Text = .grid.Item(.grid.Row, 15)

                If .grid.Item(.grid.Row, 16) = 1 Then
                    chkHold.Checked = True
                Else
                    chkHold.Checked = False
                End If

                cboLocation.Text = .grid.Item(.grid.Row, 17)
                cboPosition.Text = .grid.Item(.grid.Row, 18)

                searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text, txtDate.Value)
            End If
        End With
        'displayRecord(f.searchItem)
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Dim f As New frmViewInventory_FishDeposit
        f.ShowDialog(Me)
    End Sub

    Private Sub txtDate_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.DoubleClick
        Dim reply As String
        reply = InputBox("Please enter security code?", "Security")
        If reply = "soltai" Then
            Timer1.Enabled = False
            txtDate.Value = getServerDateTime()
            txtDate.ReadOnly = False
            txtDate.SelectAll()
            txtDate.Focus()
        End If
    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSubLot.SelectAll()
            cboSubLot.Focus()
        End If
    End Sub

    Private Sub cboSubLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSubLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDate.SelectAll()
            txtDate.Focus()
        End If
    End Sub

    Private Sub cboCS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCS.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRemarks.SelectAll()
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub txtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridBin.Focus()
        End If
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text, txtDate.Value)
        displaySummary()
    End Sub

    Public Sub displaySummary()
        With gridSummary
            .DataSource = getLotSummaryPerDeposited(cboLot.Text, txtDate.Value, cboSubLot.Text, cboCS.Text).Tables(0)
            .Columns(2).NumberFormat = "###,###,###,##0.#0"

            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 83
        End With
    End Sub

    Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
        'searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text, txtDate.Value)
        'displaySummary()
    End Sub

    Private Sub cmdEClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEClose.Click
        grpBin.Enabled = False
        grpBin.Visible = False
        cmdNew.Focus()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        grpBin.Enabled = True
        grpBin.Visible = True
        lblLot.Text = cboLot.Text
        displayFishBins(cboLot.Text)
        cboEBin.SelectAll()
        cboEBin.Focus()
    End Sub

    Public Sub displayFishBins(ByVal lot As String)
        With cboEBin
            .DataSource = getFishBinsDeposited(lot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 60
            .Splits(0).DisplayColumns(2).Width = 60
            .Splits(0).DisplayColumns(3).Width = 60

            .Columns(1).NumberFormat = "###,###,##0.#0"
            .Columns(3).NumberFormat = "###,###,##0.#0"
        End With

        With gridSummaryBin
            .DataSource = getFishBinsDeposited2(lot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 50
            .Splits(0).DisplayColumns(1).Width = 100
            .Splits(0).DisplayColumns(2).Width = 100
            .Splits(0).DisplayColumns(3).Width = 100
            .Splits(0).DisplayColumns(4).Width = 100

            .Columns(3).NumberFormat = "###,###,##0.#0"
            .Columns(4).NumberFormat = "###,###,##0.#0"
        End With

        computeTotalQty_perLot()
    End Sub

    Private Sub cboEBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEBin.TextChanged
        If cboEBin.GetItemText(cboEBin.Row, 1) = "" Then
            txtEGW.Text = "0.00"
        Else
            txtEGW.Text = Format(CDbl(cboEBin.GetItemText(cboEBin.Row, 1)), "###,###,##0.#0")
        End If

        lblETW.Text = getFishBinTareWeight(cboEBin.Text)

    End Sub

    Private Sub txtEGW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEGW.TextChanged
        If Not IsNumeric(txtEGW.Text) Or txtEGW.Text = "" Then
            txtEGW.Text = "0"
            txtEGW.SelectAll()
            txtEGW.Focus()
        End If

        lblENW.Text = Format(getNW(txtEGW.Text, lblETW.Text), "###,###,##0.#0")
    End Sub

    Private Sub lblETW_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblETW.TextChanged
        If lblETW.Text = "" Then lblETW.Text = "0"

        lblENW.Text = Format(getNW(txtEGW.Text, lblETW.Text), "###,###,##0.#0")
    End Sub

    Public Function getNW(ByVal gw As String, ByVal tw As String) As Double
        If gw = "" Then gw = 0
        If tw = "" Then tw = 0

        Return gw - tw
    End Function

    Private Sub cmdESave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdESave.Click
        If Not lblLot.Text.Trim = "" And Not cboEBin.Text.Trim = "" And Not CDbl(txtEGW.Text) = 0 And Not txtERemarks.Text = "" Then
            Dim reply As String = MsgBox("Are you sure you want to update the quantity of this bin?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then
                updateFishBinDepositedQuantity(lblLot.Text, cboEBin.Text, txtEGW.Text, txtERemarks.Text)

                displayFishBins(cboLot.Text)
                txtERemarks.Text = ""
                MsgBox("You have successfully update the Fish Bin No. " & cboEBin.Text, MsgBoxStyle.Information, "Information")
                cmdEClose.Focus()
            End If
        Else
            MsgBox("Please identify the bin quantity and remarks of this override", MsgBoxStyle.Exclamation, "Warning")
            cboEBin.SelectAll()
            cboEBin.Focus()
        End If
    End Sub

    Private Sub cboEBin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEBin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEGW.SelectAll()
            txtEGW.Focus()
        End If
    End Sub

    Private Sub txtEGW_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEGW.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRemarks.SelectAll()
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub txtERemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtERemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdESave.Focus()
        End If
    End Sub

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchFishDepositDetails(cboLot.Text, cboSubLot.Text, cboSpecie.Text, cboSize.Text, cboCS.Text, txtDate.Value)
            displaySummary()

            cboCS.SelectAll()
            cboCS.Focus()
        End If
    End Sub

    Public Sub computeTotalQty_perLot()
        Dim ctr As Integer
        Dim sum As Double
        With gridSummaryBin
            While ctr < .RowCount
                sum += .Item(ctr, 4)
                ctr += 1
            End While
        End With

        lblETotal.Text = Format(sum, "###,###,###,##0.#0")
    End Sub

    Private Sub gridSummaryBin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridSummaryBin.DoubleClick
        With gridSummaryBin
            If .RowCount > 0 Then
                cboEBin.Text = .Item(.Row, 0)
                txtEGW.Text = .Item(.Row, 3)
            End If
        End With

        cboEBin.SelectAll()
        cboEBin.Focus()
    End Sub

    Private Sub gridSummaryBin_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles gridSummaryBin.RowColChange
        computeTotalQty_perLot()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim f As New frmPrintFishDeposits
        'f.displayReport(cboLot.Text)
        'f.ShowDialog(Me)
    End Sub
End Class
