Public Class frmAnalysis_FG
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
    Friend WithEvents txtAnalysisDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboCategory As C1.Win.C1List.C1Combo
    Friend WithEvents optComposite As System.Windows.Forms.RadioButton
    Friend WithEvents optIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboProduct As C1.Win.C1List.C1Combo
    Friend WithEvents cboProduct2 As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAnalysis_FG))
        Me.txtAnalysisDate = New C1.Win.C1Input.C1DateEdit
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.cboProduct = New C1.Win.C1List.C1Combo
        Me.cboProduct2 = New C1.Win.C1List.C1Combo
        Me.cboCategory = New C1.Win.C1List.C1Combo
        Me.optComposite = New System.Windows.Forms.RadioButton
        Me.optIndividual = New System.Windows.Forms.RadioButton
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmd = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.txtAnalysisDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProduct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAnalysisDate
        '
        Me.txtAnalysisDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnalysisDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtAnalysisDate.Location = New System.Drawing.Point(136, 62)
        Me.txtAnalysisDate.Name = "txtAnalysisDate"
        Me.txtAnalysisDate.Size = New System.Drawing.Size(144, 23)
        Me.txtAnalysisDate.TabIndex = 1
        Me.txtAnalysisDate.Tag = Nothing
        Me.txtAnalysisDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(136, 94)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(144, 23)
        Me.txtProdnDate.TabIndex = 2
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AllowSort = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
        Me.cboLot.Caption = ""
        Me.cboLot.CaptionHeight = 17
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
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(136, 126)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(10, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(144, 24)
        Me.cboLot.TabIndex = 3
        Me.cboLot.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;" & _
        "AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Contr" & _
        "ol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboProduct
        '
        Me.cboProduct.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboProduct.AllowColMove = False
        Me.cboProduct.AllowSort = False
        Me.cboProduct.AutoCompletion = True
        Me.cboProduct.AutoDropDown = True
        Me.cboProduct.Caption = ""
        Me.cboProduct.CaptionHeight = 17
        Me.cboProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProduct.ColumnCaptionHeight = 17
        Me.cboProduct.ColumnFooterHeight = 17
        Me.cboProduct.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboProduct.ContentHeight = 18
        Me.cboProduct.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboProduct.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboProduct.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProduct.EditorHeight = 18
        Me.cboProduct.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboProduct.ItemHeight = 20
        Me.cboProduct.Location = New System.Drawing.Point(136, 158)
        Me.cboProduct.MatchEntryTimeout = CType(2000, Long)
        Me.cboProduct.MaxDropDownItems = CType(10, Short)
        Me.cboProduct.MaxLength = 32767
        Me.cboProduct.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProduct.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProduct.Size = New System.Drawing.Size(144, 24)
        Me.cboProduct.TabIndex = 4
        Me.cboProduct.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboProduct2
        '
        Me.cboProduct2.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboProduct2.AllowColMove = False
        Me.cboProduct2.AllowSort = False
        Me.cboProduct2.AutoCompletion = True
        Me.cboProduct2.AutoDropDown = True
        Me.cboProduct2.Caption = ""
        Me.cboProduct2.CaptionHeight = 17
        Me.cboProduct2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProduct2.ColumnCaptionHeight = 17
        Me.cboProduct2.ColumnFooterHeight = 17
        Me.cboProduct2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboProduct2.ContentHeight = 18
        Me.cboProduct2.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboProduct2.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboProduct2.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct2.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProduct2.EditorHeight = 18
        Me.cboProduct2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct2.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboProduct2.ItemHeight = 20
        Me.cboProduct2.Location = New System.Drawing.Point(136, 190)
        Me.cboProduct2.MatchEntryTimeout = CType(2000, Long)
        Me.cboProduct2.MaxDropDownItems = CType(10, Short)
        Me.cboProduct2.MaxLength = 32767
        Me.cboProduct2.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboProduct2.Name = "cboProduct2"
        Me.cboProduct2.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProduct2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboProduct2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProduct2.Size = New System.Drawing.Size(144, 24)
        Me.cboProduct2.TabIndex = 5
        Me.cboProduct2.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;" & _
        "AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Contr" & _
        "ol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboCategory
        '
        Me.cboCategory.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCategory.AllowColMove = False
        Me.cboCategory.AllowSort = False
        Me.cboCategory.AutoCompletion = True
        Me.cboCategory.AutoDropDown = True
        Me.cboCategory.Caption = ""
        Me.cboCategory.CaptionHeight = 17
        Me.cboCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCategory.ColumnCaptionHeight = 17
        Me.cboCategory.ColumnFooterHeight = 17
        Me.cboCategory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCategory.ContentHeight = 18
        Me.cboCategory.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCategory.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCategory.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCategory.EditorHeight = 18
        Me.cboCategory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboCategory.ItemHeight = 20
        Me.cboCategory.Location = New System.Drawing.Point(136, 221)
        Me.cboCategory.MatchEntryTimeout = CType(2000, Long)
        Me.cboCategory.MaxDropDownItems = CType(10, Short)
        Me.cboCategory.MaxLength = 32767
        Me.cboCategory.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCategory.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategory.Size = New System.Drawing.Size(144, 24)
        Me.cboCategory.TabIndex = 6
        Me.cboCategory.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;" & _
        "AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Contr" & _
        "ol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'optComposite
        '
        Me.optComposite.Checked = True
        Me.optComposite.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optComposite.Location = New System.Drawing.Point(448, 65)
        Me.optComposite.Name = "optComposite"
        Me.optComposite.Size = New System.Drawing.Size(104, 16)
        Me.optComposite.TabIndex = 7
        Me.optComposite.TabStop = True
        Me.optComposite.Text = "C&omposite"
        '
        'optIndividual
        '
        Me.optIndividual.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optIndividual.Location = New System.Drawing.Point(552, 65)
        Me.optIndividual.Name = "optIndividual"
        Me.optIndividual.Size = New System.Drawing.Size(112, 16)
        Me.optIndividual.TabIndex = 8
        Me.optIndividual.Text = "&Invidividual"
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(448, 96)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(208, 216)
        Me.grid.TabIndex = 9
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
        "eight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWid" & _
        "th=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>212</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 204, 212</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>17</DefaultRecSelWidth><ClientArea>0, 0, 204, 212</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(344, 264)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(264, 264)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(184, 264)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 15
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(104, 264)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 14
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(24, 264)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 13
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Type of Analysis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Sampling Type"
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(296, 126)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(120, 24)
        Me.lblCode.TabIndex = 41
        Me.lblCode.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Analysis Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Results"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 32)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Product Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Lot No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Prod'n Date"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(666, 40)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Analysis - Finished Goods"
        '
        'frmAnalysis_FG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.optIndividual)
        Me.Controls.Add(Me.optComposite)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.cboProduct2)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.txtProdnDate)
        Me.Controls.Add(Me.txtAnalysisDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnalysis_FG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnalysis_FG"
        CType(Me.txtAnalysisDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProduct2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAnalysis_FG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtAnalysisDate.Value = getServerDateTime()
        txtProdnDate.Value = getServerDateTime()

        displayLabTest()
        dataEntry(1)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayLot(ByVal prodnDate As String)
        With cboLot
            .DataSource = modModule.getBatchlotsWithdrawn(prodnDate, "%").Tables(0)
            .Splits(0).DisplayColumns(0).Width = 120

            If .ListCount > 0 Then
                .SelectedIndex = 0
            Else
                .Text = ""
            End If
        End With
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        displayLot(txtProdnDate.Text)
        displayTestDetails(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text, cboCategory.Text)
    End Sub

    Public Sub displayProduct(ByVal prodnDate As String, ByVal lot As String, Optional ByVal pCode As String = "")
        If pCode = "" Then
            With cboProduct
                .DataSource = getAllFGOutput_Daily(prodnDate, lot).Tables(0)
                .Splits(0).DisplayColumns(0).Width = 120

                If .ListCount > 0 Then
                    .SelectedIndex = 0
                Else
                    .Text = ""
                End If
            End With
        Else
            With cboProduct2
                .DataSource = getAllFGOutput_Daily(prodnDate, lot, pCode).Tables(0)
                .Splits(0).DisplayColumns(0).Width = 120

                If .ListCount > 0 Then
                    .SelectedIndex = 0
                Else
                    .Text = ""
                End If
            End With
        End If
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displayProduct(txtProdnDate.Text, cboLot.Text)
        displayTestDetails(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text, cboCategory.Text)
    End Sub

    Private Sub cboProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduct.TextChanged
        displayProduct(txtProdnDate.Text, cboLot.Text, cboProduct.Text)
        displayTestDetails(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text, cboCategory.Text)
    End Sub

    Public Sub displayLabTest()
        With cboCategory
            .DefColWidth = 120
            .DataSource = getAnalysis_LaboratoryTest("FG").Tables(0)
        End With
    End Sub

    Public Sub displayTestDetails(ByVal prodnDate As String, ByVal lot As String, ByVal pCode As String, _
    ByVal pCode2 As String, ByVal category As String)
        With grid
            .DefColWidth = 165
            If optComposite.Checked = True Then
                .DataSource = getAnalysis_FG_LaboratoryDetails(prodnDate, lot, pCode, pCode2, category, "Composite").Tables(0)
            Else
                .DataSource = getAnalysis_FG_LaboratoryDetails(prodnDate, lot, pCode, pCode2, category, "Individual").Tables(0)
            End If
        End With
    End Sub

    Private Sub cboCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.TextChanged
        displayTestDetails(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text, cboCategory.Text)
    End Sub

    Private Sub cboProduct2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduct2.TextChanged
        displayTestDetails(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text, cboCategory.Text)
    End Sub

    Private Sub optComposite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optComposite.CheckedChanged
        displayTestDetails(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text, cboCategory.Text)
    End Sub

    Private Sub optIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIndividual.CheckedChanged
        displayTestDetails(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text, cboCategory.Text)
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
                txtAnalysisDate.ReadOnly = False
                txtProdnDate.ReadOnly = False
                cboLot.ReadOnly = False
                cboProduct.ReadOnly = False
                cboProduct2.ReadOnly = False
                cboCategory.ReadOnly = False
                optComposite.Enabled = True
                optIndividual.Enabled = True
                grid.Enabled = True
            Case 1
                txtAnalysisDate.ReadOnly = True
                txtProdnDate.ReadOnly = True
                cboLot.ReadOnly = True
                cboProduct.ReadOnly = True
                cboProduct2.ReadOnly = True
                cboCategory.ReadOnly = True
                optComposite.Enabled = False
                optIndividual.Enabled = False
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        txtProdnDate.ReadOnly = False
        cboLot.ReadOnly = False
        cboProduct.ReadOnly = False
        cboProduct2.ReadOnly = False
        txtAnalysisDate.Value = getServerDateTime()
        txtProdnDate.Value = getServerDateTime()
        cboLot.Text = ""
        cboProduct.Text = ""
        cboProduct2.Text = ""
        cboCategory.SelectedIndex = 0
        'cboResults.SelectedIndex = 0

        displayTestDetails(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text, cboCategory.Text)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboLot.Text = "" And Not cboProduct.Text.Trim = "" And Not cboProduct2.Text.Trim = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    txtProdnDate.ReadOnly = True
                    cboLot.ReadOnly = True
                    cboProduct.ReadOnly = True
                    cboProduct2.ReadOnly = True
                    txtAnalysisDate.SelectAll()
                    txtAnalysisDate.Focus()
                Else
                    MsgBox("Pleas identify the lot number.", MsgBoxStyle.Critical, "Result: Found missing value.")
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

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                buttons(0)
                dataEntry(0)
                addNewRecord()
                txtAnalysisDate.SelectAll()
                txtAnalysisDate.Focus()
            Case "&Save"
                If Not cboLot.Text.Trim = "" And Not cboProduct.Text.Trim = "" And _
                Not cboProduct2.Text.Trim = "" And Not cboCategory.Text.Trim = "" And grid.RowCount > 0 Then
                    If Not validateFGA(txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewFGA(txtAnalysisDate.Text, txtProdnDate.Text, cboLot.Text, cboProduct.Text, cboProduct2.Text)

                            Dim index As Integer
                            While index < grid.RowCount
                                If optComposite.Checked = True Then
                                    saveNewFGADetails(lblCode.Text, "Composite", grid.Item(index, 0), cboCategory.Text)
                                Else
                                    saveNewFGADetails(lblCode.Text, "Individual", grid.Item(index, 0), cboCategory.Text)
                                End If

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
                        MsgBox("Raw Fish Analysis record already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        txtAnalysisDate.SelectAll()
                        txtAnalysisDate.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtAnalysisDate.SelectAll()
                    txtAnalysisDate.Focus()
                End If
            Case "&Save "
                If Not cboLot.Text.Trim = "" And grid.RowCount > 0 Then
                    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        updateFGA(lblCode.Text, txtAnalysisDate.Text)

                        If optComposite.Checked = True Then
                            deleteFGADetails(lblCode.Text, "Composite", cboCategory.Text)
                        Else
                            deleteFGADetails(lblCode.Text, "Individual", cboCategory.Text)
                        End If

                        Dim index As Integer
                        While index < grid.RowCount
                            If optComposite.Checked = True Then
                                saveNewFGADetails(lblCode.Text, "Composite", grid.Item(index, 0), cboCategory.Text)
                            Else
                                saveNewFGADetails(lblCode.Text, "Individual", grid.Item(index, 0), cboCategory.Text)
                            End If

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
                    txtAnalysisDate.SelectAll()
                    txtAnalysisDate.Focus()
                End If
        End Select
    End Sub

    Public Sub saveNewFGA(ByVal analysisDate As String, ByVal prodnDate As String, _
    ByVal lot As String, ByVal pCode As String, ByVal pCode2 As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_AnalysisFG"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@fgaCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            lblCode.Text = Format(CDate(prodnDate), "ddMMyy") & lot & pCode & pCode2
            p1.Value = lblCode.Text

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@analysisDate"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.DateTime
            If analysisDate = "" Then
                p2.Value = Format(getServerDateTime, getTimeFormat())
            Else
                p2.Value = Format(CDate(analysisDate), getTimeFormat())
            End If

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@prodnDate"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.DateTime
            If prodnDate = "" Then
                p3.Value = Format(getServerDateTime, getTimeFormat())
            Else
                p3.Value = Format(CDate(prodnDate), getTimeFormat())
            End If

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@lot#"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = lot

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@pCode"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = pCode

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@pCode2"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = pCode2

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

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Finished Good Analysis"
        f.searchType = 1
        f.displayAllAnalysis_FG()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 7)
                txtAnalysisDate.Value = .Item(.Row, 0)
                txtProdnDate.Value = .Item(.Row, 1)
                cboLot.Text = .Item(.Row, 2)
                cboProduct.Text = .Item(.Row, 3)
                cboProduct2.Text = .Item(.Row, 4)
                cboCategory.Text = .Item(.Row, 5)

                If CStr(.Item(.Row, 6)).StartsWith("Composite") Then
                    optComposite.Checked = True
                    optIndividual.Checked = False
                Else
                    optComposite.Checked = False
                    optIndividual.Checked = True
                End If
            End If
        End With
    End Sub
End Class
