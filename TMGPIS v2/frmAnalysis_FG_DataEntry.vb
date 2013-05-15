Public Class frmAnalysis_FG_DataEntry
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optHFail As System.Windows.Forms.RadioButton
    Friend WithEvents optHPass As System.Windows.Forms.RadioButton
    Friend WithEvents optHPending As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents cboCycle As C1.Win.C1List.C1Combo
    Friend WithEvents cboDisposition As C1.Win.C1List.C1Combo
    Friend WithEvents cboPackType As C1.Win.C1List.C1Combo
    Friend WithEvents optSFail As System.Windows.Forms.RadioButton
    Friend WithEvents optSPass As System.Windows.Forms.RadioButton
    Friend WithEvents optSPending As System.Windows.Forms.RadioButton
    Friend WithEvents optMiFail As System.Windows.Forms.RadioButton
    Friend WithEvents optMiPass As System.Windows.Forms.RadioButton
    Friend WithEvents optMiPending As System.Windows.Forms.RadioButton
    Friend WithEvents optMoFail As System.Windows.Forms.RadioButton
    Friend WithEvents optMoPass As System.Windows.Forms.RadioButton
    Friend WithEvents optMoPending As System.Windows.Forms.RadioButton
    Friend WithEvents optDFail As System.Windows.Forms.RadioButton
    Friend WithEvents optDPass As System.Windows.Forms.RadioButton
    Friend WithEvents optDPending As System.Windows.Forms.RadioButton
    Friend WithEvents txtNW As System.Windows.Forms.TextBox
    Friend WithEvents txtDW As System.Windows.Forms.TextBox
    Friend WithEvents txtFlakes As System.Windows.Forms.TextBox
    Friend WithEvents txtOil As System.Windows.Forms.TextBox
    Friend WithEvents txtBrine As System.Windows.Forms.TextBox
    Friend WithEvents txtDeviation As System.Windows.Forms.TextBox
    Friend WithEvents optSeFail As System.Windows.Forms.RadioButton
    Friend WithEvents optSePass As System.Windows.Forms.RadioButton
    Friend WithEvents optSePending As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents grpFZ As System.Windows.Forms.GroupBox
    Friend WithEvents grpCan As System.Windows.Forms.GroupBox
    Friend WithEvents gridLogs As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAnalysis_FG_DataEntry))
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.cboSpecie = New C1.Win.C1List.C1Combo
        Me.cboCycle = New C1.Win.C1List.C1Combo
        Me.cboDisposition = New C1.Win.C1List.C1Combo
        Me.cboPackType = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.optHFail = New System.Windows.Forms.RadioButton
        Me.optHPass = New System.Windows.Forms.RadioButton
        Me.optHPending = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optSFail = New System.Windows.Forms.RadioButton
        Me.optSPass = New System.Windows.Forms.RadioButton
        Me.optSPending = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.optMiFail = New System.Windows.Forms.RadioButton
        Me.optMiPass = New System.Windows.Forms.RadioButton
        Me.optMiPending = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.optMoFail = New System.Windows.Forms.RadioButton
        Me.optMoPass = New System.Windows.Forms.RadioButton
        Me.optMoPending = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.grpFZ = New System.Windows.Forms.GroupBox
        Me.optDFail = New System.Windows.Forms.RadioButton
        Me.optDPass = New System.Windows.Forms.RadioButton
        Me.optDPending = New System.Windows.Forms.RadioButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.grpCan = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtBrine = New System.Windows.Forms.TextBox
        Me.txtOil = New System.Windows.Forms.TextBox
        Me.txtFlakes = New System.Windows.Forms.TextBox
        Me.txtDW = New System.Windows.Forms.TextBox
        Me.txtNW = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtDeviation = New System.Windows.Forms.TextBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.optSeFail = New System.Windows.Forms.RadioButton
        Me.optSePass = New System.Windows.Forms.RadioButton
        Me.optSePending = New System.Windows.Forms.RadioButton
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.gridLogs = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCycle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDisposition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPackType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpFZ.SuspendLayout()
        Me.grpCan.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(88, 54)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(192, 23)
        Me.txtProdnDate.TabIndex = 0
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboLot.Location = New System.Drawing.Point(88, 86)
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
        "/Height><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Height>17</Height" & _
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
        Me.cboSpecie.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboSpecie.ContentHeight = 18
        Me.cboSpecie.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSpecie.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSpecie.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSpecie.EditorHeight = 18
        Me.cboSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboSpecie.ItemHeight = 20
        Me.cboSpecie.Location = New System.Drawing.Point(88, 120)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(10, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.Size = New System.Drawing.Size(192, 24)
        Me.cboSpecie.TabIndex = 3
        Me.cboSpecie.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "/Height><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Height>17</Height" & _
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
        'cboCycle
        '
        Me.cboCycle.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCycle.AllowColMove = False
        Me.cboCycle.AutoCompletion = True
        Me.cboCycle.AutoDropDown = True
        Me.cboCycle.Caption = ""
        Me.cboCycle.CaptionHeight = 17
        Me.cboCycle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCycle.ColumnCaptionHeight = 17
        Me.cboCycle.ColumnFooterHeight = 17
        Me.cboCycle.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCycle.ContentHeight = 18
        Me.cboCycle.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCycle.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCycle.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCycle.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCycle.EditorHeight = 18
        Me.cboCycle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCycle.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboCycle.ItemHeight = 20
        Me.cboCycle.Location = New System.Drawing.Point(88, 153)
        Me.cboCycle.MatchEntryTimeout = CType(2000, Long)
        Me.cboCycle.MaxDropDownItems = CType(10, Short)
        Me.cboCycle.MaxLength = 32767
        Me.cboCycle.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCycle.Name = "cboCycle"
        Me.cboCycle.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCycle.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCycle.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCycle.Size = New System.Drawing.Size(192, 24)
        Me.cboCycle.TabIndex = 4
        Me.cboCycle.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "/Height><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Height>17</Height" & _
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
        'cboDisposition
        '
        Me.cboDisposition.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboDisposition.AllowColMove = False
        Me.cboDisposition.AutoCompletion = True
        Me.cboDisposition.AutoDropDown = True
        Me.cboDisposition.Caption = ""
        Me.cboDisposition.CaptionHeight = 17
        Me.cboDisposition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDisposition.ColumnCaptionHeight = 17
        Me.cboDisposition.ColumnFooterHeight = 17
        Me.cboDisposition.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboDisposition.ContentHeight = 18
        Me.cboDisposition.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboDisposition.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboDisposition.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDisposition.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDisposition.EditorHeight = 18
        Me.cboDisposition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDisposition.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboDisposition.ItemHeight = 20
        Me.cboDisposition.Location = New System.Drawing.Point(88, 185)
        Me.cboDisposition.MatchEntryTimeout = CType(2000, Long)
        Me.cboDisposition.MaxDropDownItems = CType(10, Short)
        Me.cboDisposition.MaxLength = 32767
        Me.cboDisposition.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboDisposition.Name = "cboDisposition"
        Me.cboDisposition.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDisposition.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboDisposition.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDisposition.Size = New System.Drawing.Size(192, 24)
        Me.cboDisposition.TabIndex = 5
        Me.cboDisposition.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "/Height><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Height>17</Height" & _
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
        'cboPackType
        '
        Me.cboPackType.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboPackType.AllowColMove = False
        Me.cboPackType.AutoCompletion = True
        Me.cboPackType.AutoDropDown = True
        Me.cboPackType.Caption = ""
        Me.cboPackType.CaptionHeight = 17
        Me.cboPackType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPackType.ColumnCaptionHeight = 17
        Me.cboPackType.ColumnFooterHeight = 17
        Me.cboPackType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboPackType.ContentHeight = 18
        Me.cboPackType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPackType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPackType.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPackType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPackType.EditorHeight = 18
        Me.cboPackType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPackType.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboPackType.ItemHeight = 20
        Me.cboPackType.Location = New System.Drawing.Point(88, 219)
        Me.cboPackType.MatchEntryTimeout = CType(2000, Long)
        Me.cboPackType.MaxDropDownItems = CType(10, Short)
        Me.cboPackType.MaxLength = 32767
        Me.cboPackType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPackType.Name = "cboPackType"
        Me.cboPackType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPackType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPackType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPackType.Size = New System.Drawing.Size(192, 24)
        Me.cboPackType.TabIndex = 6
        Me.cboPackType.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "/Height><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Height>17</Height" & _
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Lot No.*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Prodn Date*"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1194, 40)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "QA Finished Good Analysis Results"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Specie*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Disposition*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Cycle*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Pack Type*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optHFail)
        Me.GroupBox2.Controls.Add(Me.optHPass)
        Me.GroupBox2.Controls.Add(Me.optHPending)
        Me.GroupBox2.Location = New System.Drawing.Point(88, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 40)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'optHFail
        '
        Me.optHFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHFail.Location = New System.Drawing.Point(184, 12)
        Me.optHFail.Name = "optHFail"
        Me.optHFail.Size = New System.Drawing.Size(56, 24)
        Me.optHFail.TabIndex = 5
        Me.optHFail.Text = "Fail"
        '
        'optHPass
        '
        Me.optHPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHPass.Location = New System.Drawing.Point(104, 12)
        Me.optHPass.Name = "optHPass"
        Me.optHPass.Size = New System.Drawing.Size(64, 24)
        Me.optHPass.TabIndex = 4
        Me.optHPass.Text = "Pass"
        '
        'optHPending
        '
        Me.optHPending.Checked = True
        Me.optHPending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHPending.Location = New System.Drawing.Point(7, 12)
        Me.optHPending.Name = "optHPending"
        Me.optHPending.Size = New System.Drawing.Size(81, 24)
        Me.optHPending.TabIndex = 3
        Me.optHPending.TabStop = True
        Me.optHPending.Text = "Pending"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Histamine*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSFail)
        Me.GroupBox1.Controls.Add(Me.optSPass)
        Me.GroupBox1.Controls.Add(Me.optSPending)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 40)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'optSFail
        '
        Me.optSFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSFail.Location = New System.Drawing.Point(296, 12)
        Me.optSFail.Name = "optSFail"
        Me.optSFail.Size = New System.Drawing.Size(105, 24)
        Me.optSFail.TabIndex = 5
        Me.optSFail.Text = "Fail"
        '
        'optSPass
        '
        Me.optSPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSPass.Location = New System.Drawing.Point(152, 12)
        Me.optSPass.Name = "optSPass"
        Me.optSPass.Size = New System.Drawing.Size(120, 24)
        Me.optSPass.TabIndex = 4
        Me.optSPass.Text = "Pass"
        '
        'optSPending
        '
        Me.optSPending.Checked = True
        Me.optSPending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSPending.Location = New System.Drawing.Point(7, 12)
        Me.optSPending.Name = "optSPending"
        Me.optSPending.Size = New System.Drawing.Size(120, 24)
        Me.optSPending.TabIndex = 3
        Me.optSPending.TabStop = True
        Me.optSPending.Text = "Pending"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(368, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 19)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Salt*"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optMiFail)
        Me.GroupBox3.Controls.Add(Me.optMiPass)
        Me.GroupBox3.Controls.Add(Me.optMiPending)
        Me.GroupBox3.Location = New System.Drawing.Point(432, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(432, 40)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        '
        'optMiFail
        '
        Me.optMiFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMiFail.Location = New System.Drawing.Point(296, 12)
        Me.optMiFail.Name = "optMiFail"
        Me.optMiFail.Size = New System.Drawing.Size(105, 24)
        Me.optMiFail.TabIndex = 5
        Me.optMiFail.Text = "Fail"
        '
        'optMiPass
        '
        Me.optMiPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMiPass.Location = New System.Drawing.Point(152, 12)
        Me.optMiPass.Name = "optMiPass"
        Me.optMiPass.Size = New System.Drawing.Size(120, 24)
        Me.optMiPass.TabIndex = 4
        Me.optMiPass.Text = "Pass"
        '
        'optMiPending
        '
        Me.optMiPending.Checked = True
        Me.optMiPending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMiPending.Location = New System.Drawing.Point(7, 12)
        Me.optMiPending.Name = "optMiPending"
        Me.optMiPending.Size = New System.Drawing.Size(120, 24)
        Me.optMiPending.TabIndex = 3
        Me.optMiPending.TabStop = True
        Me.optMiPending.Text = "Pending"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(368, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 19)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Micro*"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optMoFail)
        Me.GroupBox4.Controls.Add(Me.optMoPass)
        Me.GroupBox4.Controls.Add(Me.optMoPending)
        Me.GroupBox4.Location = New System.Drawing.Point(432, 136)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 40)
        Me.GroupBox4.TabIndex = 59
        Me.GroupBox4.TabStop = False
        '
        'optMoFail
        '
        Me.optMoFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMoFail.Location = New System.Drawing.Point(296, 12)
        Me.optMoFail.Name = "optMoFail"
        Me.optMoFail.Size = New System.Drawing.Size(105, 24)
        Me.optMoFail.TabIndex = 5
        Me.optMoFail.Text = "Fail"
        '
        'optMoPass
        '
        Me.optMoPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMoPass.Location = New System.Drawing.Point(152, 12)
        Me.optMoPass.Name = "optMoPass"
        Me.optMoPass.Size = New System.Drawing.Size(120, 24)
        Me.optMoPass.TabIndex = 4
        Me.optMoPass.Text = "Pass"
        '
        'optMoPending
        '
        Me.optMoPending.Checked = True
        Me.optMoPending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMoPending.Location = New System.Drawing.Point(7, 12)
        Me.optMoPending.Name = "optMoPending"
        Me.optMoPending.Size = New System.Drawing.Size(120, 24)
        Me.optMoPending.TabIndex = 3
        Me.optMoPending.TabStop = True
        Me.optMoPending.Text = "Pending"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(368, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 19)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Moisture*"
        '
        'grpFZ
        '
        Me.grpFZ.Controls.Add(Me.optDFail)
        Me.grpFZ.Controls.Add(Me.optDPass)
        Me.grpFZ.Controls.Add(Me.optDPending)
        Me.grpFZ.Location = New System.Drawing.Point(432, 176)
        Me.grpFZ.Name = "grpFZ"
        Me.grpFZ.Size = New System.Drawing.Size(432, 40)
        Me.grpFZ.TabIndex = 61
        Me.grpFZ.TabStop = False
        '
        'optDFail
        '
        Me.optDFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDFail.Location = New System.Drawing.Point(296, 12)
        Me.optDFail.Name = "optDFail"
        Me.optDFail.Size = New System.Drawing.Size(105, 24)
        Me.optDFail.TabIndex = 5
        Me.optDFail.Text = "Fail"
        '
        'optDPass
        '
        Me.optDPass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDPass.Location = New System.Drawing.Point(152, 12)
        Me.optDPass.Name = "optDPass"
        Me.optDPass.Size = New System.Drawing.Size(120, 24)
        Me.optDPass.TabIndex = 4
        Me.optDPass.Text = "Pass"
        '
        'optDPending
        '
        Me.optDPending.Checked = True
        Me.optDPending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDPending.Location = New System.Drawing.Point(7, 12)
        Me.optDPending.Name = "optDPending"
        Me.optDPending.Size = New System.Drawing.Size(120, 24)
        Me.optDPending.TabIndex = 3
        Me.optDPending.TabStop = True
        Me.optDPending.Text = "Pending"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(368, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 19)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Drip Loss*"
        '
        'grpCan
        '
        Me.grpCan.Controls.Add(Me.Label19)
        Me.grpCan.Controls.Add(Me.Label18)
        Me.grpCan.Controls.Add(Me.Label15)
        Me.grpCan.Controls.Add(Me.Label16)
        Me.grpCan.Controls.Add(Me.Label17)
        Me.grpCan.Controls.Add(Me.txtBrine)
        Me.grpCan.Controls.Add(Me.txtOil)
        Me.grpCan.Controls.Add(Me.txtFlakes)
        Me.grpCan.Controls.Add(Me.txtDW)
        Me.grpCan.Controls.Add(Me.txtNW)
        Me.grpCan.Location = New System.Drawing.Point(432, 256)
        Me.grpCan.Name = "grpCan"
        Me.grpCan.Size = New System.Drawing.Size(432, 112)
        Me.grpCan.TabIndex = 62
        Me.grpCan.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(252, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 19)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Brine Ratio"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(252, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 19)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Oil Ratio*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 19)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "% Flakes*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Drain Weight*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 19)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Net Weight*"
        '
        'txtBrine
        '
        Me.txtBrine.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrine.Location = New System.Drawing.Point(320, 48)
        Me.txtBrine.Name = "txtBrine"
        Me.txtBrine.ReadOnly = True
        Me.txtBrine.TabIndex = 4
        Me.txtBrine.Text = "0"
        Me.txtBrine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOil
        '
        Me.txtOil.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOil.Location = New System.Drawing.Point(320, 14)
        Me.txtOil.Name = "txtOil"
        Me.txtOil.TabIndex = 3
        Me.txtOil.Text = "0"
        Me.txtOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFlakes
        '
        Me.txtFlakes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlakes.Location = New System.Drawing.Point(96, 81)
        Me.txtFlakes.Name = "txtFlakes"
        Me.txtFlakes.TabIndex = 2
        Me.txtFlakes.Text = "0"
        Me.txtFlakes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDW
        '
        Me.txtDW.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDW.Location = New System.Drawing.Point(96, 48)
        Me.txtDW.Name = "txtDW"
        Me.txtDW.TabIndex = 1
        Me.txtDW.Text = "0"
        Me.txtDW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNW
        '
        Me.txtNW.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNW.Location = New System.Drawing.Point(96, 14)
        Me.txtNW.Name = "txtNW"
        Me.txtNW.TabIndex = 0
        Me.txtNW.Text = "0"
        Me.txtNW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.txtDeviation)
        Me.GroupBox7.Location = New System.Drawing.Point(432, 368)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(432, 64)
        Me.GroupBox7.TabIndex = 63
        Me.GroupBox7.TabStop = False
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 32)
        Me.Label20.TabIndex = 68
        Me.Label20.Text = "Deviation/ Remarks"
        '
        'txtDeviation
        '
        Me.txtDeviation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeviation.Location = New System.Drawing.Point(91, 16)
        Me.txtDeviation.Multiline = True
        Me.txtDeviation.Name = "txtDeviation"
        Me.txtDeviation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDeviation.Size = New System.Drawing.Size(333, 40)
        Me.txtDeviation.TabIndex = 0
        Me.txtDeviation.Text = ""
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.optSeFail)
        Me.GroupBox8.Controls.Add(Me.optSePass)
        Me.GroupBox8.Controls.Add(Me.optSePending)
        Me.GroupBox8.Location = New System.Drawing.Point(432, 216)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(432, 40)
        Me.GroupBox8.TabIndex = 65
        Me.GroupBox8.TabStop = False
        '
        'optSeFail
        '
        Me.optSeFail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSeFail.Location = New System.Drawing.Point(296, 12)
        Me.optSeFail.Name = "optSeFail"
        Me.optSeFail.Size = New System.Drawing.Size(105, 24)
        Me.optSeFail.TabIndex = 5
        Me.optSeFail.Text = "Fail"
        '
        'optSePass
        '
        Me.optSePass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSePass.Location = New System.Drawing.Point(152, 12)
        Me.optSePass.Name = "optSePass"
        Me.optSePass.Size = New System.Drawing.Size(120, 24)
        Me.optSePass.TabIndex = 4
        Me.optSePass.Text = "Pass"
        '
        'optSePending
        '
        Me.optSePending.Checked = True
        Me.optSePending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSePending.Location = New System.Drawing.Point(7, 12)
        Me.optSePending.Name = "optSePending"
        Me.optSePending.Size = New System.Drawing.Size(120, 24)
        Me.optSePending.TabIndex = 3
        Me.optSePending.TabStop = True
        Me.optSePending.Text = "Pending"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(368, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 19)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Sensory*"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(632, 440)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 67
        Me.cmdClose.Text = "&Cancel"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(552, 440)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 66
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(88, 304)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton1.TabIndex = 68
        Me.RadioButton1.Text = "Composite"
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(208, 304)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton2.TabIndex = 69
        Me.RadioButton2.Text = "Individiual"
        Me.RadioButton2.Visible = False
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.Enabled = False
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(88, 336)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(264, 152)
        Me.C1TrueDBGrid1.TabIndex = 70
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.Visible = False
        Me.C1TrueDBGrid1.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""17"" ColumnCapti" & _
        "onHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>148</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 260, 148</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 260, 148</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 304)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 19)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Test Type *"
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 336)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 19)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Values"
        Me.Label22.Visible = False
        '
        'gridLogs
        '
        Me.gridLogs.AllowColMove = False
        Me.gridLogs.AllowUpdate = False
        Me.gridLogs.CaptionHeight = 17
        Me.gridLogs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridLogs.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridLogs.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.gridLogs.Location = New System.Drawing.Point(880, 72)
        Me.gridLogs.Name = "gridLogs"
        Me.gridLogs.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridLogs.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridLogs.PreviewInfo.ZoomFactor = 75
        Me.gridLogs.RowHeight = 20
        Me.gridLogs.Size = New System.Drawing.Size(304, 416)
        Me.gridLogs.TabIndex = 73
        Me.gridLogs.Text = "C1TrueDBGrid2"
        Me.gridLogs.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Tahoma, 9.75pt;}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}He" & _
        "ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" & _
        ";BackColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}S" & _
        "tyle1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""Fals" & _
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" M" & _
        "arqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>412</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 300, 412</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 300, 412</ClientArea><PrintPageHeaderStyle parent" & _
        "="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(880, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "History Logs"
        '
        'frmAnalysis_FG_DataEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1194, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gridLogs)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.grpCan)
        Me.Controls.Add(Me.grpFZ)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPackType)
        Me.Controls.Add(Me.cboDisposition)
        Me.Controls.Add(Me.cboCycle)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.txtProdnDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAnalysis_FG_DataEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnalysis_FG_DataEntry"
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCycle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDisposition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPackType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.grpFZ.ResumeLayout(False)
        Me.grpCan.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAnalysis_FG_DataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtProdnDate.Value = getServerDateTime()

        displayDisposition()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Public Sub displayLotWithdrawn(ByVal prodnDate As String)
        With cboLot
            .Text = ""
            .DataSource = getBatchlotsWithdrawn(prodnDate, "%").Tables(0)
            .Splits(0).DisplayColumns(0).Width = 170

            If .ListCount > 0 Then .SelectedIndex = 0
            
        End With
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        displayLotWithdrawn(txtProdnDate.Text)
        displaySublotSpecie(cboLot.Text, txtProdnDate.Value)
        displayRetortCycle(txtProdnDate.Text, cboLot.Text, "%")
        displayPackType(txtProdnDate.Text, cboLot.Text, "%", cboCycle.Text)

        displayResults(txtProdnDate.Text, cboLot.Text, cboSpecie.Text, cboCycle.Text)
    End Sub

    'Public Sub displaySublot(ByVal lot As String)
    '    With cboSublot
    '        .Text = ""
    '        .DataSource = modModule.getFishLot_MethodAndVesselInfo(lot).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 170

    '        If .ListCount > 0 Then
    '            .SelectedIndex = 0
    '        Else
    '            .Text = ""
    '        End If
    '    End With
    'End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        'displaySublot(cboLot.Text)
        displaySublotSpecie(cboLot.Text, txtProdnDate.Text)
        displayRetortCycle(txtProdnDate.Text, cboLot.Text, "%")
        displayPackType(txtProdnDate.Text, cboLot.Text, "%", cboCycle.Text)

        displayResults(txtProdnDate.Text, cboLot.Text, cboSpecie.Text, cboCycle.Text)
        cboLot.SelectAll()
        cboLot.Focus()
    End Sub

    Public Sub displaySublotSpecie(ByVal lot As String, ByVal prodnDate As String)
        With cboSpecie
            .Text = ""
            .DataSource = Nothing
            .DataSource = modModule.getAllSublotSpecie(lot, prodnDate).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 170

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    'Private Sub cboSublot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSublotx.TextChanged
    '    'displaySublotSpecie(cboLot.Text, cboSublot.Text)
    '    'displayRetortCycle(txtProdnDate.Text, cboLot.Text, cboSublot.Text)
    '    'displayPackType(txtProdnDate.Text, cboLot.Text, cboSublot.Text, cboCycle.Text)
    'End Sub

    Public Sub displayRetortCycle(ByVal prodnDate As String, ByVal lot As String, ByVal sublot As String)
        With cboCycle
            .Text = ""
            .DataSource = getProductionCycleByProductionDetails(prodnDate, lot, sublot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 170

            If .ListCount > 0 Then
                .SelectedIndex = 0
            End If
        End With
    End Sub

    Public Sub displayDisposition()
        With cboDisposition
            .Text = ""
            .DataSource = getAllQCDisposition().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 170

        End With
    End Sub

    Public Sub displayPackType(ByVal prodnDate As String, ByVal lot As String, ByVal sublot As String, ByVal cycle As String)
        With cboPackType
            .Text = ""
            .DataSource = getProductPackTypeByProductionDetails(prodnDate, lot, sublot, cycle).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 170

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboCycle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCycle.TextChanged
        displayPackType(txtProdnDate.Text, cboLot.Text, "%", cboCycle.Text)
        displayResults(txtProdnDate.Text, cboLot.Text, cboSpecie.Text, cboCycle.Text)
    End Sub

    Private Sub cboPackType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPackType.TextChanged
        If cboPackType.Text.StartsWith("Frozen") Then
            grpFZ.Enabled = True
            Me.optDPending.Checked = True
            grpCan.Enabled = False
        Else
            grpFZ.Enabled = False
            Me.optDPending.Checked = False
            grpCan.Enabled = True
        End If
    End Sub

    Public Function getResults(ByVal typeOfTests As String) As String
        Select Case typeOfTests
            Case "histamine"
                If optHPending.Checked = True Then
                    Return "Pending"
                ElseIf optHPass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If

            Case "salt"
                If optSPending.Checked = True Then
                    Return "Pending"
                ElseIf optSPass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If

            Case "micro"
                If optMiPending.Checked = True Then
                    Return "Pending"
                ElseIf optMiPass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If

            Case "moisture"
                If optMoPending.Checked = True Then
                    Return "Pending"
                ElseIf optMoPass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If

            Case "driploss"
                If optDPending.Checked = True Then
                    Return "Pending"
                ElseIf optDPass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If

            Case "sensory"
                If optSePending.Checked = True Then
                    Return "Pending"
                ElseIf optSePass.Checked = True Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If
        End Select
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String
        If Not txtProdnDate.Text = "" And Not cboLot.Text.Trim = "" And Not cboSpecie.Text.Trim = "" And _
        Not cboCycle.Text.Trim = "" And Not cboDisposition.Text.Trim = "" And Not cboPackType.Text.Trim = "" Then
            If validateIfCanSpecIsEmpty() Then
                If validateIfGSDisposition() Then
                    If Not validateQCFGAnalysis(txtProdnDate.Text, cboLot.Text, cboSpecie.Text, cboCycle.Text) Then
                        reply = MsgBox("Are you sure you want to add this test?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                        If reply = vbYes Then
                            saveQCFGAnalysisResults(cboDisposition.Text, cboLot.Text, "", txtProdnDate.Text, cboPackType.Text, getResults("histamine"), _
                                getResults("salt"), getResults("micro"), getResults("moisture"), getResults("driploss"), txtNW.Text, txtDW.Text, _
                                txtFlakes.Text, txtOil.Text, txtDeviation.Text, getResults("sensory"), cboCycle.Text, cboSpecie.Text)

                            saveQCFGAnalysisResults_Logs(txtProdnDate.Text, cboLot.Text, cboSpecie.Text, cboCycle.Text, _
                               "Histamine=" & getResults("histamine") & "; " & "Salt=" & getResults("salt") & "; " & _
                               "Micro=" & getResults("micro") & "; " & "Moisture=" & getResults("moisture") & "; " & _
                               "Drip Loss=" & getResults("driploss") & "; " & "Sensory=" & getResults("Sensory") & "; " & _
                               "NW=" & txtNW.Text & "; " & "DW=" & txtDW.Text & "; " & "Flakes=" & txtFlakes.Text & "; " & _
                               "Oil=" & txtOil.Text & "; " & "Deviation=" & txtDeviation.Text)
                            displayLogs(cboLot.Text)

                            MsgBox("You have successfully added the new test", MsgBoxStyle.Information, "Information")
                            cmdClose.Focus()
                        End If
                    Else
                        reply = MsgBox("Are you sure you want to update this test?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                        If reply = vbYes Then
                            updateQCFGAnalysisResults(cboDisposition.Text, cboLot.Text, "", txtProdnDate.Text, cboPackType.Text, getResults("histamine"), _
                                getResults("salt"), getResults("micro"), getResults("moisture"), getResults("driploss"), txtNW.Text, txtDW.Text, _
                                txtFlakes.Text, txtOil.Text, txtDeviation.Text, getResults("sensory"), cboCycle.Text, cboSpecie.Text)

                            saveQCFGAnalysisResults_Logs(txtProdnDate.Text, cboLot.Text, cboSpecie.Text, cboCycle.Text, _
                                "Histamine=" & getResults("histamine") & "; " & "Salt=" & getResults("salt") & "; " & _
                                "Micro=" & getResults("micro") & "; " & "Moisture=" & getResults("moisture") & "; " & _
                                "Drip Loss=" & getResults("driploss") & "; " & "Sensory=" & getResults("Sensory") & "; " & _
                                "NW=" & txtNW.Text & "; " & "DW=" & txtDW.Text & "; " & "Flakes=" & txtFlakes.Text & "; " & _
                                "Oil=" & txtOil.Text & "; " & "Deviation=" & txtDeviation.Text)
                            displayLogs(cboLot.Text)

                            MsgBox("You have successfully updated this test", MsgBoxStyle.Information, "Information")
                            cmdClose.Focus()
                        End If
                    End If
                Else
                    MsgBox("Please verify your disposition as Histamine or Sensory didn't passed the laboratory test", MsgBoxStyle.Exclamation, "Warning")
                    cboDisposition.SelectAll()
                    cboDisposition.Focus()
                End If
            Else
                MsgBox("Please make sure you properly filled up the can specification details", MsgBoxStyle.Exclamation, "Warning")
                txtNW.SelectAll()
                txtNW.Focus()
            End If
        Else
            MsgBox("Please make sure you properly filled in those fields marked with asterisk (*)", MsgBoxStyle.Exclamation, "Warning")
            txtProdnDate.SelectAll()
            txtProdnDate.Focus()
        End If
    End Sub

    Private Sub txtNW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNW.TextChanged
        If Not IsNumeric(txtNW.Text) Or txtNW.Text.Trim = "" Then
            txtNW.Text = "0"
            txtNW.SelectAll()
            txtNW.Focus()
        End If
    End Sub

    Private Sub txtDW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDW.TextChanged
        If Not IsNumeric(txtDW.Text) Or txtDW.Text.Trim = "" Then
            txtDW.Text = "0"
            txtDW.SelectAll()
            txtDW.Focus()
        End If
    End Sub

    Private Sub txtOil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOil.TextChanged
        If Not IsNumeric(txtOil.Text) Or txtOil.Text.Trim = "" Then
            txtOil.Text = "0"
            txtOil.SelectAll()
            txtOil.Focus()
        End If
    End Sub

    Private Sub txtFlakes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlakes.TextChanged
        If Not IsNumeric(txtFlakes.Text) Or txtFlakes.Text.Trim = "" Then
            txtFlakes.Text = "0"
            txtFlakes.SelectAll()
            txtFlakes.Focus()
        End If
    End Sub

    Public Sub addNewRecord()
        txtProdnDate.Value = getServerDateTime()
        displayLotWithdrawn(txtProdnDate.Text)
        displaySublotSpecie(cboLot.Text, txtProdnDate.Text)
        displayRetortCycle(txtProdnDate.Text, cboLot.Text, "%")
        displayDisposition()
        displayPackType(txtProdnDate.Text, cboLot.Text, "%", cboCycle.Text)
        optHPending.Checked = True
        optSPending.Checked = True
        optMiPending.Checked = True
        optMoPending.Checked = True
        optDPending.Checked = True
        optSePending.Checked = True
        txtNW.Text = "0"
        txtDW.Text = "0"
        txtFlakes.Text = "0"
        txtOil.Text = "0"
        txtDeviation.Text = ""
    End Sub

    Public Sub displayResults(ByVal prodnDate As String, ByVal lot As String, ByVal specie As String, ByVal cycle As String)
        cboDisposition.Text = getQAFGResults(prodnDate, lot, specie, cycle, "dispo")

        Select Case getQAFGResults(prodnDate, lot, specie, cycle, "histamine")
            Case "Pass"
                optHPass.Checked = True
            Case "Fail"
                optHFail.Checked = True
            Case Else
                optHPending.Checked = True
        End Select

        Select Case getQAFGResults(prodnDate, lot, specie, cycle, "salt")
            Case "Pass"
                optSPass.Checked = True
            Case "Fail"
                optSFail.Checked = True
            Case Else
                optSPending.Checked = True
        End Select

        Select Case getQAFGResults(prodnDate, lot, specie, cycle, "micro")
            Case "Pass"
                optMiPass.Checked = True
            Case "Fail"
                optMiFail.Checked = True
            Case Else
                optMiPending.Checked = True
        End Select

        Select Case getQAFGResults(prodnDate, lot, specie, cycle, "moisture")
            Case "Pass"
                optMoPass.Checked = True
            Case "Fail"
                optMoFail.Checked = True
            Case Else
                optMoPending.Checked = True
        End Select

        Select Case getQAFGResults(prodnDate, lot, specie, cycle, "driploss")
            Case "Pass"
                optDPass.Checked = True
            Case "Fail"
                optDFail.Checked = True
            Case Else
                optDPending.Checked = True
        End Select

        Select Case getQAFGResults(prodnDate, lot, specie, cycle, "sensory")
            Case "Pass"
                optSePass.Checked = True
            Case "Fail"
                optSeFail.Checked = True
            Case Else
                optSePending.Checked = True
        End Select

        txtNW.Text = getQAFGResults(prodnDate, lot, specie, cycle, "nw")
        txtDW.Text = getQAFGResults(prodnDate, lot, specie, cycle, "dw")
        txtFlakes.Text = getQAFGResults(prodnDate, lot, specie, cycle, "flakes")
        txtOil.Text = getQAFGResults(prodnDate, lot, specie, cycle, "oil")

        txtDeviation.Text = getQAFGResults(prodnDate, lot, specie, cycle, "deviation")
    End Sub

    Private Sub cboSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSpecie.TextChanged
        displayResults(txtProdnDate.Text, cboLot.Text, cboSpecie.Text, cboCycle.Text)
    End Sub

    Public Function validateIfGSDisposition() As Boolean
        If cboDisposition.Text.StartsWith("Good") Then
            If getResults("histamine").StartsWith("Pend") Or getResults("histamine").StartsWith("Fail") Or _
                getResults("sensory").StartsWith("Pend") Or getResults("sensory").StartsWith("Fail") Then

                Return False
            End If
        End If

        Return True
    End Function

    Public Sub displayLogs(ByVal lot As String)
        With gridLogs
            .DataSource = getAllQCFGAnalysisLogs(lot).Tables(0)
            .Columns(0).NumberFormat = getTimeFormat() & " hh:mm:ss tt"

            .Splits(0).DisplayColumns(0).Width = 130
            .Splits(0).DisplayColumns(1).Width = 60 '180
            .Splits(0).DisplayColumns(2).Width = 70
            .Splits(0).DisplayColumns(3).Width = 50
            .Splits(0).DisplayColumns(4).Width = 180
            .Splits(0).DisplayColumns(6).Width = 130
        End With
    End Sub

    Public Function validateIfCanSpecIsEmpty() As Boolean
        If cboPackType.Text.StartsWith("Can") Then
            If txtNW.Text.Trim = "" Or CDbl(txtNW.Text) = 0 Or txtDW.Text.Trim = "" Or CDbl(txtDW.Text) = 0 Or _
            txtFlakes.Text.Trim = "" Or CDbl(txtFlakes.Text) = 0 Or txtOil.Text.Trim = "" Or CDbl(txtOil.Text) = 0 Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function
End Class
