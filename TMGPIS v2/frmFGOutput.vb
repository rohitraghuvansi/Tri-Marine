Public Class frmFGOutput
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
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cboTrans As C1.Win.C1List.C1Combo
    Friend WithEvents cboStatus As C1.Win.C1List.C1Combo
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cboProduct As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboDefects As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboFGStatus As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuFGDefects As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFGOutput))
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.cboShift = New C1.Win.C1List.C1Combo
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit
        Me.cboTrans = New C1.Win.C1List.C1Combo
        Me.cboStatus = New C1.Win.C1List.C1Combo
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboProduct = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboDefects = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboFGStatus = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuFGDefects = New System.Windows.Forms.MenuItem
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDefects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFGStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cboLot.Location = New System.Drawing.Point(88, 118)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(10, Short)
        Me.cboLot.MaxLength = 6
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(152, 24)
        Me.cboLot.TabIndex = 5
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
        'cboShift
        '
        Me.cboShift.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboShift.AllowColMove = False
        Me.cboShift.AutoCompletion = True
        Me.cboShift.AutoDropDown = True
        Me.cboShift.Caption = ""
        Me.cboShift.CaptionHeight = 17
        Me.cboShift.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboShift.ColumnCaptionHeight = 17
        Me.cboShift.ColumnFooterHeight = 17
        Me.cboShift.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboShift.ContentHeight = 18
        Me.cboShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboShift.EditorHeight = 18
        Me.cboShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(88, 86)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.Size = New System.Drawing.Size(152, 24)
        Me.cboShift.TabIndex = 4
        Me.cboShift.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(88, 55)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(152, 23)
        Me.txtProdnDate.TabIndex = 3
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboTrans
        '
        Me.cboTrans.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboTrans.AllowColMove = False
        Me.cboTrans.AutoCompletion = True
        Me.cboTrans.AutoDropDown = True
        Me.cboTrans.Caption = ""
        Me.cboTrans.CaptionHeight = 17
        Me.cboTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTrans.ColumnCaptionHeight = 17
        Me.cboTrans.ColumnFooterHeight = 17
        Me.cboTrans.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboTrans.ContentHeight = 18
        Me.cboTrans.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboTrans.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboTrans.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrans.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTrans.EditorHeight = 18
        Me.cboTrans.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrans.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboTrans.ItemHeight = 20
        Me.cboTrans.Location = New System.Drawing.Point(488, 54)
        Me.cboTrans.MatchEntryTimeout = CType(2000, Long)
        Me.cboTrans.MaxDropDownItems = CType(10, Short)
        Me.cboTrans.MaxLength = 6
        Me.cboTrans.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboTrans.Name = "cboTrans"
        Me.cboTrans.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboTrans.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboTrans.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboTrans.Size = New System.Drawing.Size(208, 24)
        Me.cboTrans.TabIndex = 6
        Me.cboTrans.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboStatus
        '
        Me.cboStatus.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboStatus.AllowColMove = False
        Me.cboStatus.AutoCompletion = True
        Me.cboStatus.AutoDropDown = True
        Me.cboStatus.Caption = ""
        Me.cboStatus.CaptionHeight = 17
        Me.cboStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboStatus.ColumnCaptionHeight = 17
        Me.cboStatus.ColumnFooterHeight = 17
        Me.cboStatus.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboStatus.ContentHeight = 18
        Me.cboStatus.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboStatus.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboStatus.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStatus.EditorHeight = 18
        Me.cboStatus.Enabled = False
        Me.cboStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboStatus.ItemHeight = 20
        Me.cboStatus.Location = New System.Drawing.Point(320, 104)
        Me.cboStatus.MatchEntryTimeout = CType(2000, Long)
        Me.cboStatus.MaxDropDownItems = CType(10, Short)
        Me.cboStatus.MaxLength = 6
        Me.cboStatus.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboStatus.Size = New System.Drawing.Size(208, 24)
        Me.cboStatus.TabIndex = 7
        Me.cboStatus.TabStop = False
        Me.cboStatus.Visible = False
        Me.cboStatus.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(488, 88)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(208, 56)
        Me.txtRemarks.TabIndex = 8
        Me.txtRemarks.Text = ""
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
        Me.grid.Location = New System.Drawing.Point(8, 173)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(688, 296)
        Me.grid.TabIndex = 9
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;" & _
        "}Style15{}Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor" & _
        ":ControlText;BackColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12" & _
        "{}Style13{}Style1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowC" & _
        "olMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterH" & _
        "eight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWid" & _
        "th=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>292</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 684, 292</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>16</DefaultRecSelWidth><ClientArea>0, 0, 684, 292</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(194, 480)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 10
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(274, 480)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 11
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(354, 480)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 12
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(434, 480)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Prod'n Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Lot No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Shift"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(703, 40)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Finished Good Output"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(408, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Transaction"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Remarks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(264, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 19)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Status"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Details"
        '
        'cboProduct
        '
        Me.cboProduct.AllowColMove = False
        Me.cboProduct.AllowColSelect = True
        Me.cboProduct.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboProduct.AlternatingRows = False
        Me.cboProduct.CaptionHeight = 17
        Me.cboProduct.ColumnCaptionHeight = 17
        Me.cboProduct.ColumnFooterHeight = 17
        Me.cboProduct.FetchRowStyles = False
        Me.cboProduct.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboProduct.Location = New System.Drawing.Point(16, 176)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProduct.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboProduct.RowHeight = 20
        Me.cboProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProduct.ScrollTips = False
        Me.cboProduct.Size = New System.Drawing.Size(80, 296)
        Me.cboProduct.TabIndex = 49
        Me.cboProduct.Text = "C1TrueDBDropdown1"
        Me.cboProduct.Visible = False
        Me.cboProduct.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style9{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackC" & _
        "olor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView AllowColMove=""False"" " & _
        "Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" Marq" & _
        "ueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordS" & _
        "electors=""False"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>292</" & _
        "Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor""" & _
        " me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle pare" & _
        "nt=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupS" & _
        "tyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" />" & _
        "<HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""In" & _
        "active"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelector" & _
        "Style parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me" & _
        "=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 76, 292</Clie" & _
        "ntRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1Tru" & _
        "eDBGrid.DropdownView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style" & _
        " parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style par" & _
        "ent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style pare" & _
        "nt=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""" & _
        "Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=" & _
        """Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style pare" & _
        "nt=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles>" & _
        "<vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><Defaul" & _
        "tRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 76, 292</ClientArea></Blob" & _
        ">"
        '
        'cboDefects
        '
        Me.cboDefects.AllowColMove = False
        Me.cboDefects.AllowColSelect = True
        Me.cboDefects.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboDefects.AlternatingRows = False
        Me.cboDefects.CaptionHeight = 17
        Me.cboDefects.ColumnCaptionHeight = 17
        Me.cboDefects.ColumnFooterHeight = 17
        Me.cboDefects.FetchRowStyles = False
        Me.cboDefects.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDefects.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.cboDefects.Location = New System.Drawing.Point(384, 176)
        Me.cboDefects.Name = "cboDefects"
        Me.cboDefects.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDefects.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboDefects.RowHeight = 20
        Me.cboDefects.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDefects.ScrollTips = False
        Me.cboDefects.Size = New System.Drawing.Size(170, 296)
        Me.cboDefects.TabIndex = 50
        Me.cboDefects.Text = "C1TrueDBDropdown2"
        Me.cboDefects.Visible = False
        Me.cboDefects.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Alig" & _
        "nVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView AllowColMove=""False"" " & _
        "Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" Marq" & _
        "ueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordS" & _
        "electors=""False"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>292</" & _
        "Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor""" & _
        " me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle pare" & _
        "nt=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupS" & _
        "tyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" />" & _
        "<HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""In" & _
        "active"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelector" & _
        "Style parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me" & _
        "=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 166, 292</Cli" & _
        "entRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1Tr" & _
        "ueDBGrid.DropdownView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Styl" & _
        "e parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style pa" & _
        "rent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style par" & _
        "ent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=" & _
        """Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent" & _
        "=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style par" & _
        "ent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles" & _
        "><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><Defau" & _
        "ltRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 166, 292</ClientArea></Bl" & _
        "ob>"
        '
        'cboFGStatus
        '
        Me.cboFGStatus.AllowColMove = False
        Me.cboFGStatus.AllowColSelect = True
        Me.cboFGStatus.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboFGStatus.AlternatingRows = False
        Me.cboFGStatus.CaptionHeight = 17
        Me.cboFGStatus.ColumnCaptionHeight = 17
        Me.cboFGStatus.ColumnFooterHeight = 17
        Me.cboFGStatus.FetchRowStyles = False
        Me.cboFGStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFGStatus.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.cboFGStatus.Location = New System.Drawing.Point(520, 176)
        Me.cboFGStatus.Name = "cboFGStatus"
        Me.cboFGStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFGStatus.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboFGStatus.RowHeight = 20
        Me.cboFGStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFGStatus.ScrollTips = False
        Me.cboFGStatus.Size = New System.Drawing.Size(125, 296)
        Me.cboFGStatus.TabIndex = 51
        Me.cboFGStatus.Text = "C1TrueDBDropdown2"
        Me.cboFGStatus.Visible = False
        Me.cboFGStatus.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style9{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackC" & _
        "olor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView AllowColMove=""False"" " & _
        "Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" Marq" & _
        "ueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordS" & _
        "electors=""False"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>292</" & _
        "Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor""" & _
        " me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle pare" & _
        "nt=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupS" & _
        "tyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" />" & _
        "<HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""In" & _
        "active"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelector" & _
        "Style parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me" & _
        "=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 121, 292</Cli" & _
        "entRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1Tr" & _
        "ueDBGrid.DropdownView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Styl" & _
        "e parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style pa" & _
        "rent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style par" & _
        "ent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=" & _
        """Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent" & _
        "=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style par" & _
        "ent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles" & _
        "><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><Defau" & _
        "ltRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 121, 292</ClientArea></Bl" & _
        "ob>"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFGDefects})
        '
        'mnuFGDefects
        '
        Me.mnuFGDefects.Index = 0
        Me.mnuFGDefects.Text = "&FG Defects"
        '
        'frmFGOutput
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(703, 533)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.cboFGStatus)
        Me.Controls.Add(Me.cboDefects)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboTrans)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtProdnDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFGOutput"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFGOutput"
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDefects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFGStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFGOutput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        dataEntry(1)
        txtProdnDate.Value = getServerDateTime()
        initializeShift()
        'initializeStatus()
        displayFGTransaction()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub initializeShift()
        With cboShift
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 130
            .SelectedIndex = 0
        End With
    End Sub

    'Public Sub initializeStatus()
    '    With cboStatus
    '        .DataMode = C1.Win.C1List.DataModeEnum.AddItem
    '        .AddItemTitles("Status")
    '        setStatusData(False)
    '        .Splits(0).DisplayColumns(0).Width = 185
    '    End With
    'End Sub

    'Public Sub setStatusData(ByVal sample As Boolean)
    '    With cboStatus
    '        .ClearItems()
    '        If sample Then
    '            .AddItem("For Samples")
    '        Else
    '            .AddItem("For Reprocess")
    '            .AddItem("For Fish Meal")
    '            .AddItem("For Local Sales")
    '        End If

    '        If .Text = "" Then If .ListCount > 0 Then .SelectedIndex = 0
    '    End With
    'End Sub

    Public Sub displayFishLotWithdrawn(ByVal prodnDate As String, ByVal shift As String)
        With cboLot
            .DataSource = modModule.getBatchlotsWithdrawn(prodnDate, shift).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130

            If .ListCount > 0 Then
                .SelectedIndex = 0
            Else
                .Text = ""
            End If
        End With
    End Sub

    Public Sub displayFGTransaction()
        With cboTrans
            .DataSource = modModule.getFGTransaction().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185

            If .ListCount > 0 Then
                .SelectedIndex = 0
            Else
                .Text = ""
            End If
        End With
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

        displayFishLotWithdrawn(txtProdnDate.Text, cboShift.Text)
        displayFGOutputDetails(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboTrans.Text)
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        displayFishLotWithdrawn(txtProdnDate.Text, cboShift.Text)
        displayFGOutputDetails(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboTrans.Text)
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        If cboLot.Text = "" Then If cboLot.ListCount > 0 Then cboLot.SelectedIndex = 0

        displayFGOutputDetails(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboTrans.Text)
    End Sub

    Private Sub cboTrans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrans.TextChanged
        If cboTrans.Text = "" Then If cboTrans.ListCount > 0 Then cboTrans.SelectedIndex = 0

        displayFGOutputDetails(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboTrans.Text)

        'If cboTrans.Text.StartsWith("QA") Then
        '    setStatusData(True)
        'Else
        '    setStatusData(False)
        'End If
    End Sub

    Private Sub cboStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.TextChanged
        If cboStatus.Text = "" Then If cboStatus.ListCount > 0 Then cboStatus.SelectedIndex = 0
    End Sub

    Public Sub displayFGOutputDetails(ByVal prodnDate As String, ByVal shift As String, _
    ByVal lot As String, ByVal trans As String)
        With grid
            .DataSource = getFGOutputDetails(prodnDate, shift, lot, trans).Tables(0)
            displayProduct()
            .Columns(0).DropDown = cboProduct
            displayFGDefects()
            .Columns(3).DropDown = cboDefects
            displayDefectStatus()
            .Columns(5).DropDown = cboFGStatus

            .Columns(2).DefaultValue = 0
            .Columns(2).NumberFormat = "###,##0"

            .Splits(0).DisplayColumns(0).DropDownList = True
            .Splits(0).DisplayColumns(3).DropDownList = True
            .Splits(0).DisplayColumns(5).DropDownList = True
            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 70
            .Splits(0).DisplayColumns(2).Width = 60
            .Splits(0).DisplayColumns(3).Width = 170
            .Splits(0).DisplayColumns(4).Width = 140
            .Splits(0).DisplayColumns(5).Width = 125

            validateDisplayFGOutputDetails()
        End With
    End Sub

    Public Sub validateDisplayFGOutputDetails()
        With grid
            If cboTrans.Text.StartsWith("QA") Then
                .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
                .Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
                .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
                .Splits(0).DisplayColumns(3).Locked = True
                .Splits(0).DisplayColumns(4).Locked = True
                .Splits(0).DisplayColumns(5).Locked = True
                Dim ctr As Integer
                While ctr < .RowCount
                    .Item(ctr, 3) = "*"
                    .Item(ctr, 4) = "*"
                    .Item(ctr, 5) = getFGDefectStatus("%sample%")

                    ctr += 1
                End While
            Else
                .Splits(0).DisplayColumns(3).Style.BackColor = Color.White
                .Splits(0).DisplayColumns(4).Style.BackColor = Color.White
                .Splits(0).DisplayColumns(5).Style.BackColor = Color.White
                .Splits(0).DisplayColumns(3).Locked = False
                .Splits(0).DisplayColumns(4).Locked = False
                .Splits(0).DisplayColumns(5).Locked = False
            End If
        End With
    End Sub

    Public Sub buttons(ByVal i As Integer)
        Select Case i
            Case 0
                Me.cmdPrint.Enabled = False
                Me.cmdClose.Enabled = False
            Case 1
                Me.cmdPrint.Enabled = True
                Me.cmdClose.Enabled = True
        End Select
    End Sub

    Public Sub dataEntry(ByVal s As Int16)
        'used to disable and enable data entry controls
        Select Case s
            Case 0
                txtProdnDate.ReadOnly = False
                cboShift.ReadOnly = False
                cboLot.ReadOnly = False
                cboTrans.ReadOnly = False
                cboStatus.ReadOnly = False
                txtRemarks.ReadOnly = False
                grid.Enabled = True
            Case 1
                txtProdnDate.ReadOnly = True
                cboShift.ReadOnly = True
                cboLot.ReadOnly = True
                cboTrans.ReadOnly = True
                cboStatus.ReadOnly = True
                txtRemarks.ReadOnly = True
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        txtProdnDate.ReadOnly = False
        txtProdnDate.Value = getServerDateTime()
        cboShift.ReadOnly = False
        cboShift.SelectedIndex = 0
        cboLot.ReadOnly = False
        cboLot.Text = ""
        cboTrans.SelectedIndex = 0
        displayFishLotWithdrawn(txtProdnDate.Value, cboShift.Text)
        displayFGOutputDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboTrans.Text)
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
                txtProdnDate.SelectAll()
                txtProdnDate.Focus()
            Case Else ' "&Save"
                If Not cboLot.Text.Trim = "" And Not cboTrans.Text.Trim = "" And grid.RowCount > 0 Then
                    If Not isDataEntryFieldsAreEmpty() Then 'And Not isFishBinFoundDuplicate() Then
                        If getFGOutputCode(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboTrans.Text) = "" Then
                            reply = MsgBox("Are you sure you want to add this records?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                            If reply = vbYes Then
                                saveNewFGOutput(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboStatus.Text, _
                                    txtRemarks.Text, cboTrans.Text)

                                Dim ctr As Integer
                                While ctr < grid.RowCount
                                    saveNewFGOutput_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                        grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2), grid.Item(ctr, 4), _
                                        grid.Item(ctr, 3), cboTrans.Text, grid.Item(ctr, 5))

                                    'saveNewProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                    '    grid.Item(ctr, 0), "", "", "", "", "", "", "", "", "", "", "")

                                    ctr += 1
                                End While

                                'displayProductionDetails_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, True)
                                '---showMRN(True)
                                'gridMRN2.Focus()
                            Else
                                Exit Sub
                            End If
                        Else
                            'MsgBox("To edit the following meat utilization, please contact your Supervisor or Manager for more details", MsgBoxStyle.Exclamation, "Warning")
                            'reply = MsgBox("To edit the following meat utilization, please contact your Supervisor or Manager for more details" & Chr(13) & _
                            '    "Would you like to proceed for Materials Reference Number (MRN) details?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Warning")
                            'If reply = vbYes Then
                            '    showMRN(True)
                            'End If

                            '***********************************************************************
                            '******* IT WAS REMOVE THE BELOW CODE JUST TO GIVE WAY THE ONE TIME ENCODING FOR THE SYSTEM
                            '***********************************************************************
                            reply = MsgBox("Are you sure you want to update this records?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                            If reply = vbYes Then
                                deleteFGOutputDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboTrans.Text)

                                Dim ctr As Integer
                                While ctr < grid.RowCount
                                    saveNewFGOutput_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                         grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2), grid.Item(ctr, 4), _
                                         grid.Item(ctr, 3), cboTrans.Text, grid.Item(ctr, 5))
                                    'If Not validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, grid.Item(ctr, 0)) Then
                                    '    saveNewProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                    '       grid.Item(ctr, 0), "", "", "", "", "", "", "", "", "", "", "")
                                    '    'End If
                                    'End If

                                    ctr += 1
                                End While

                                'showMRN(True)
                            Else
                                Exit Sub
                            End If
                            '***********************************************************************
                            '***********************************************************************
                        End If

                        MsgBox("You have successfully save the transaction", MsgBoxStyle.Information, "Information")
                        cmd.Text = "&Add"
                        cmdEdit.Text = "&Edit"
                        buttons(1)
                        dataEntry(1)
                    End If
                Else
                    MsgBox("Please review some of the data entry fields because it shouldn't be left empty", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtProdnDate.SelectAll()
                    txtProdnDate.Focus()
                End If
        End Select
    End Sub

    Public Function isDataEntryFieldsAreEmpty() As Boolean
        Try
            Dim ctr As Integer = 0
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 0) = "" Or .Item(ctr, 1) = "" Or .Item(ctr, 2) = "" Or .Item(ctr, 3) = "" Or .Item(ctr, 4) = "" Or .Item(ctr, 5) = "" Then
                        MsgBox("Please check your data entry fields in the table, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                    End If

                    ctr += 1
                End While
            End With

            Return False
        Catch e As Exception
            Dim ctr As Integer = 0
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or .Item(ctr, 2) Is DBNull.Value Or .Item(ctr, 3) Is DBNull.Value Or .Item(ctr, 4) Is DBNull.Value Or .Item(ctr, 5) Is DBNull.Value Then
                        MsgBox("Please check your data entry fields in the table, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                        'Else
                        '    Return False
                    End If

                    ctr += 1
                End While
            End With

            Return False
        End Try
    End Function

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboLot.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    txtProdnDate.ReadOnly = True
                    cboShift.ReadOnly = True
                    cboLot.ReadOnly = True
                    grid.Focus()
                Else
                    MsgBox("Please review some of the data entry fields because it shouldn't be left empty", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cmd.Focus()
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

    Public Sub displayProduct()
        With cboProduct
            .DefColWidth = 57
            .DataSource = getProductCode().Tables(0)
        End With
    End Sub

    Public Sub displayFGDefects()
        With cboDefects
            .DefColWidth = 148
            .DataSource = getFGDefects().Tables(0)
        End With
    End Sub

    Public Sub displayDefectStatus()
        With cboFGStatus
            .DefColWidth = 105
            .DataSource = getAllFGDefectStatus().Tables(0)
        End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        validateDisplayFGOutputDetails()
    End Sub

    Private Sub mnuFGDefects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFGDefects.Click
        Dim f As New frmFGDefects
        f.ShowDialog(Me)
        displayFGDefects()
    End Sub
End Class
