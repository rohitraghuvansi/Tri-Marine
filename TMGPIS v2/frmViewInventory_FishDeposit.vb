Public Class frmViewInventory_FishDeposit
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
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboFishSizes As C1.Win.C1List.C1Combo
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblInventory As System.Windows.Forms.Label
    Friend WithEvents lblBins As System.Windows.Forms.Label
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents lblMT As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmViewInventory_FishDeposit))
        Me.cboCS = New C1.Win.C1List.C1Combo
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.cboSpecie = New C1.Win.C1List.C1Combo
        Me.cboFishSizes = New C1.Win.C1List.C1Combo
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblInventory = New System.Windows.Forms.Label
        Me.lblBins = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblMT = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFishSizes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cboCS.ContentHeight = 18
        Me.cboCS.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCS.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCS.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCS.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCS.EditorHeight = 18
        Me.cboCS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCS.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(96, 56)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(10, Short)
        Me.cboCS.MaxLength = 32767
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.Size = New System.Drawing.Size(256, 24)
        Me.cboCS.TabIndex = 0
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
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
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
        Me.cboLot.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(96, 87)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(10, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(192, 24)
        Me.cboLot.TabIndex = 1
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
        'cboSpecie
        '
        Me.cboSpecie.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSpecie.AllowColMove = False
        Me.cboSpecie.AutoCompletion = True
        Me.cboSpecie.AutoDropDown = True
        Me.cboSpecie.Caption = ""
        Me.cboSpecie.CaptionHeight = 17
        Me.cboSpecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSpecie.ColumnCaptionHeight = 17
        Me.cboSpecie.ColumnFooterHeight = 17
        Me.cboSpecie.ContentHeight = 18
        Me.cboSpecie.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSpecie.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSpecie.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSpecie.EditorHeight = 18
        Me.cboSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboSpecie.ItemHeight = 20
        Me.cboSpecie.Location = New System.Drawing.Point(96, 118)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(10, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.Size = New System.Drawing.Size(192, 24)
        Me.cboSpecie.TabIndex = 2
        Me.cboSpecie.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboFishSizes
        '
        Me.cboFishSizes.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboFishSizes.AllowColMove = False
        Me.cboFishSizes.AutoCompletion = True
        Me.cboFishSizes.AutoDropDown = True
        Me.cboFishSizes.Caption = ""
        Me.cboFishSizes.CaptionHeight = 17
        Me.cboFishSizes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFishSizes.ColumnCaptionHeight = 17
        Me.cboFishSizes.ColumnFooterHeight = 17
        Me.cboFishSizes.ContentHeight = 18
        Me.cboFishSizes.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboFishSizes.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboFishSizes.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSizes.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFishSizes.EditorHeight = 18
        Me.cboFishSizes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSizes.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboFishSizes.ItemHeight = 20
        Me.cboFishSizes.Location = New System.Drawing.Point(96, 150)
        Me.cboFishSizes.MatchEntryTimeout = CType(2000, Long)
        Me.cboFishSizes.MaxDropDownItems = CType(10, Short)
        Me.cboFishSizes.MaxLength = 32767
        Me.cboFishSizes.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboFishSizes.Name = "cboFishSizes"
        Me.cboFishSizes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFishSizes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboFishSizes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFishSizes.Size = New System.Drawing.Size(192, 24)
        Me.cboFishSizes.TabIndex = 3
        Me.cboFishSizes.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(9, 208)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(875, 328)
        Me.grid.TabIndex = 4
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "eight=""17"" FilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=" & _
        """16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Heig" & _
        "ht>324</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=" & _
        """Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarSt" & _
        "yle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 871, " & _
        "324</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1." & _
        "Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" />" & _
        "<Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Sty" & _
        "le parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Styl" & _
        "e parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style pa" & _
        "rent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style p" & _
        "arent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Styl" & _
        "e parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedS" & _
        "tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><" & _
        "DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 871, 324</ClientArea" & _
        "><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" " & _
        "me=""Style15"" /></Blob>"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(792, 64)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 5
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(792, 120)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Cold Storage"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(890, 40)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Round Fish Stock Inventory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Lot No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Fish Specie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Fish Sizes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Fish Bin Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(480, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 19)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Total Inventory"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(480, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 19)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "# of Fish Bins"
        '
        'lblInventory
        '
        Me.lblInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInventory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.Location = New System.Drawing.Point(576, 111)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(192, 24)
        Me.lblInventory.TabIndex = 63
        Me.lblInventory.Text = "0.0"
        Me.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBins
        '
        Me.lblBins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBins.Location = New System.Drawing.Point(576, 80)
        Me.lblBins.Name = "lblBins"
        Me.lblBins.Size = New System.Drawing.Size(192, 24)
        Me.lblBins.TabIndex = 62
        Me.lblBins.Text = "0"
        Me.lblBins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(464, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(416, 120)
        Me.Label11.TabIndex = 64
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(468, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 19)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Summary"
        '
        'lblMT
        '
        Me.lblMT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMT.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMT.Location = New System.Drawing.Point(576, 143)
        Me.lblMT.Name = "lblMT"
        Me.lblMT.Size = New System.Drawing.Size(192, 24)
        Me.lblMT.TabIndex = 67
        Me.lblMT.Text = "0.0"
        Me.lblMT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(480, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 19)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "MT Conversion"
        '
        'frmViewInventory_FishDeposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(890, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblInventory)
        Me.Controls.Add(Me.lblBins)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboFishSizes)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.cboCS)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmViewInventory_FishDeposit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmViewInventory_FishDeposit"
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFishSizes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmViewInventory_FishDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        displayColdStorage()
        displayLot(cboCS.Text)
        displaySpecie(cboCS.Text, cboLot.Text)
        displaySizes(cboCS.Text, cboLot.Text, cboSpecie.Text)

        displayRecords(cboCS.Text, cboLot.Text, cboSpecie.Text, cboFishSizes.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DefColWidth = 235
            .DataSource = modModule.getColdStorage().Tables(0)
        End With
    End Sub

    Public Sub displayLot(ByVal cs As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            If cs = "" Then cs = "%"
            Dim qry As String = "SELECT DISTINCT dbo.tblFishDeposit.batchlot AS [Lot No.] " & _
                " FROM dbo.tblFishDeposit INNER JOIN " & _
                " dbo.tblColdStorage ON dbo.tblFishDeposit.csCode = dbo.tblColdStorage.csCode " & _
                " WHERE dbo.tblColdStorage.csName LIKE '" & cs & "' AND dbo.tblFishDeposit.withdraw = 'NO'"

            Dim cmd As New SqlClient.SqlCommand(qry, c)

            Dim da As New SqlClient.SqlDataAdapter()
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            With cboLot
                .DefColWidth = 170
                .DataSource = ds.Tables(0)
            End With

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displaySpecie(ByVal cs As String, ByVal lot As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            If cs = "" Then cs = "%"
            If lot = "" Then lot = "%"
            Dim qry As String = "SELECT DISTINCT dbo.tblFishSpecie.specie AS [Fish Specie] " & _
                " FROM dbo.tblFishDeposit INNER JOIN " & _
                " dbo.tblFishSpecie ON dbo.tblFishDeposit.specieCode = dbo.tblFishSpecie.specieCode INNER JOIN " & _
                " dbo.tblColdStorage ON dbo.tblFishDeposit.csCode = dbo.tblColdStorage.csCode " & _
                " WHERE dbo.tblColdStorage.csName LIKE '" & cs & "' AND " & _
                " dbo.tblFishDeposit.batchlot LIKE '" & lot & "' AND dbo.tblFishDeposit.withdraw = 'NO'"

            Dim cmd As New SqlClient.SqlCommand(qry, c)

            Dim da As New SqlClient.SqlDataAdapter()
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            With cboSpecie
                .DefColWidth = 170
                .DataSource = ds.Tables(0)
            End With

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displaySizes(ByVal cs As String, ByVal lot As String, ByVal specie As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            If cs = "" Then cs = "%"
            If lot = "" Then lot = "%"
            If specie = "" Then specie = "%"
            Dim qry As String = "SELECT DISTINCT dbo.tblFishSizes.sizeRange AS [Fish Size] " & _
                " FROM dbo.tblFishDeposit INNER JOIN " & _
                " dbo.tblFishSpecie ON dbo.tblFishDeposit.specieCode = dbo.tblFishSpecie.specieCode INNER JOIN " & _
                " dbo.tblColdStorage ON dbo.tblFishDeposit.csCode = dbo.tblColdStorage.csCode INNER JOIN " & _
                " dbo.tblFishSizes ON dbo.tblFishDeposit.sizeCode = dbo.tblFishSizes.sizeCode " & _
                " WHERE dbo.tblColdStorage.csName LIKE '" & cs & "' AND " & _
                " dbo.tblFishDeposit.batchlot LIKE '" & lot & "' AND " & _
                " dbo.tblFishSpecie.specie LIKE '" & specie & "' AND dbo.tblFishDeposit.withdraw = 'NO'"

            Dim cmd As New SqlClient.SqlCommand(qry, c)

            Dim da As New SqlClient.SqlDataAdapter()
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            With cboFishSizes
                .DefColWidth = 170
                .DataSource = ds.Tables(0)
            End With

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboCS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCS.TextChanged
        displayLot(cboCS.Text)
        displayRecords(cboCS.Text, cboLot.Text, cboSpecie.Text, cboFishSizes.Text)
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displaySpecie(cboCS.Text, cboLot.Text)
        displayRecords(cboCS.Text, cboLot.Text, cboSpecie.Text, cboFishSizes.Text)
    End Sub

    Private Sub cboSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSpecie.TextChanged
        displaySizes(cboCS.Text, cboLot.Text, cboSpecie.Text)
        displayRecords(cboCS.Text, cboLot.Text, cboSpecie.Text, cboFishSizes.Text)
    End Sub

    Public Sub displayRecords(ByVal cs As String, ByVal lot As String, ByVal specie As String, ByVal size As String)
        With grid
            If cs = "" Then cs = "%"
            If lot = "" Then lot = "%"
            If specie = "" Then specie = "%"
            If size = "" Then size = "%"

            .DataSource = getReport_FishDepositInventory(cs, lot, specie, size).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 150
            .Splits(0).DisplayColumns(1).Width = 150
            .Splits(0).DisplayColumns(2).Width = 200
            .Splits(0).DisplayColumns(3).Width = 80
            .Splits(0).DisplayColumns(4).Width = 150
            .Columns(4).NumberFormat = "###,###,##0.0"

            computeSummary(cs, lot, specie, size)
        End With
    End Sub

    Private Sub cboFishSizes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFishSizes.TextChanged
        displayRecords(cboCS.Text, cboLot.Text, cboSpecie.Text, cboFishSizes.Text)
    End Sub

    Public Sub computeSummary(ByVal cs As String, ByVal lot As String, ByVal specie As String, ByVal size As String)
        lblBins.Text = grid.RowCount

        If cs = "" Then cs = "%"
        If lot = "" Then lot = "%"
        If specie = "" Then specie = "%"
        If size = "" Then size = "%"
        lblInventory.Text = Format(getTotalFishDepositInventory(cs, lot, specie, size), "###,###,##0.0")
        lblMT.Text = Format(CDbl(lblInventory.Text) / 1000, "###,###,##0.#0")
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        ''If cboCS.Text.Trim = "" Then
        'Dim f As New frmPrintInventory_Total_perRoom()
        'f.Label1.Text = "Print Total Inventory Report"
        'f.Label1.Text = "Print Total Inventory Report"
        'f.Label10.Visible = False
        'f.cboCS.Visible = False
        'f.ShowDialog(Me)
        ''Else
        ''    Dim f As New frmPrintInventory_Total_perRoom()
        ''    f.Label1.Text = "Print Total Inventory Report By Room"
        ''    f.grp.Visible = True
        ''    f.grp.Enabled = True
        ''    f.displayColdStorage()
        ''    f.cboCS.Text = cboCS.Text
        ''    'f.displayReport(cboCS.Text)
        ''    f.ShowDialog(Me)
        ''End If

        ''Dim f As New frmPrintInventory_Total_perRoom()

        ''Dim cs As String = cboCS.Text
        ''If cs = "" Then
        ''    cs = "%"
        ''    f.Label1.Text = "Print Total Inventory Report"
        ''Else
        ''    f.Label1.Text = "Print Total Inventory Report by Room"
        ''End If


        ''f.displayReport(cs, "%", "%", "%")

        ''f.ShowDialog(Me)
    End Sub

    Private Sub cboCS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCS.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSpecie.SelectAll()
            cboSpecie.Focus()
        End If
    End Sub

    Private Sub cboSpecie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSpecie.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboFishSizes.SelectAll()
            cboFishSizes.Focus()
        End If
    End Sub

    Private Sub cboFishSizes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFishSizes.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdPrint.Focus()
        End If
    End Sub
End Class
