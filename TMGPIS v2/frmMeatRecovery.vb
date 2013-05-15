Public Class frmMeatRecovery
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboFishSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents cboFishSize As C1.Win.C1List.C1Combo
    Friend WithEvents cboMeatType As C1.Win.C1List.C1Combo
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdAClose As System.Windows.Forms.Button
    Friend WithEvents cmdASave As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMeatRecovery))
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.cboFishSpecie = New C1.Win.C1List.C1Combo()
        Me.cboFishSize = New C1.Win.C1List.C1Combo()
        Me.cboMeatType = New C1.Win.C1List.C1Combo()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdAClose = New System.Windows.Forms.Button()
        Me.cmdASave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFishSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFishSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMeatType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(81, 56)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(160, 23)
        Me.txtProdnDate.TabIndex = 0
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboShift.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboShift.EditorHeight = 18
        Me.cboShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(81, 88)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(20, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.Size = New System.Drawing.Size(160, 24)
        Me.cboShift.TabIndex = 1
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
        Me.cboLot.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(81, 120)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(160, 24)
        Me.cboLot.TabIndex = 2
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboFishSpecie
        '
        Me.cboFishSpecie.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboFishSpecie.AllowColMove = False
        Me.cboFishSpecie.AutoCompletion = True
        Me.cboFishSpecie.AutoDropDown = True
        Me.cboFishSpecie.Caption = ""
        Me.cboFishSpecie.CaptionHeight = 17
        Me.cboFishSpecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFishSpecie.ColumnCaptionHeight = 17
        Me.cboFishSpecie.ColumnFooterHeight = 17
        Me.cboFishSpecie.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboFishSpecie.ContentHeight = 18
        Me.cboFishSpecie.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboFishSpecie.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboFishSpecie.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSpecie.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFishSpecie.EditorHeight = 18
        Me.cboFishSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSpecie.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.cboFishSpecie.ItemHeight = 20
        Me.cboFishSpecie.Location = New System.Drawing.Point(81, 152)
        Me.cboFishSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboFishSpecie.MaxDropDownItems = CType(20, Short)
        Me.cboFishSpecie.MaxLength = 32767
        Me.cboFishSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboFishSpecie.Name = "cboFishSpecie"
        Me.cboFishSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFishSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboFishSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFishSpecie.Size = New System.Drawing.Size(160, 24)
        Me.cboFishSpecie.TabIndex = 3
        Me.cboFishSpecie.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboFishSize
        '
        Me.cboFishSize.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboFishSize.AllowColMove = False
        Me.cboFishSize.AutoCompletion = True
        Me.cboFishSize.AutoDropDown = True
        Me.cboFishSize.Caption = ""
        Me.cboFishSize.CaptionHeight = 17
        Me.cboFishSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFishSize.ColumnCaptionHeight = 17
        Me.cboFishSize.ColumnFooterHeight = 17
        Me.cboFishSize.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboFishSize.ContentHeight = 18
        Me.cboFishSize.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboFishSize.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboFishSize.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSize.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFishSize.EditorHeight = 18
        Me.cboFishSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSize.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.cboFishSize.ItemHeight = 20
        Me.cboFishSize.Location = New System.Drawing.Point(81, 184)
        Me.cboFishSize.MatchEntryTimeout = CType(2000, Long)
        Me.cboFishSize.MaxDropDownItems = CType(20, Short)
        Me.cboFishSize.MaxLength = 32767
        Me.cboFishSize.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboFishSize.Name = "cboFishSize"
        Me.cboFishSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFishSize.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboFishSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFishSize.Size = New System.Drawing.Size(160, 24)
        Me.cboFishSize.TabIndex = 4
        Me.cboFishSize.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboMeatType
        '
        Me.cboMeatType.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboMeatType.AllowColMove = False
        Me.cboMeatType.AutoCompletion = True
        Me.cboMeatType.AutoDropDown = True
        Me.cboMeatType.Caption = ""
        Me.cboMeatType.CaptionHeight = 17
        Me.cboMeatType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMeatType.ColumnCaptionHeight = 17
        Me.cboMeatType.ColumnFooterHeight = 17
        Me.cboMeatType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboMeatType.ContentHeight = 18
        Me.cboMeatType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboMeatType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboMeatType.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMeatType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMeatType.EditorHeight = 18
        Me.cboMeatType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMeatType.Images.Add(CType(resources.GetObject("resource.Images4"), System.Drawing.Bitmap))
        Me.cboMeatType.ItemHeight = 20
        Me.cboMeatType.Location = New System.Drawing.Point(409, 55)
        Me.cboMeatType.MatchEntryTimeout = CType(2000, Long)
        Me.cboMeatType.MaxDropDownItems = CType(20, Short)
        Me.cboMeatType.MaxLength = 32767
        Me.cboMeatType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMeatType.Name = "cboMeatType"
        Me.cboMeatType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMeatType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMeatType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMeatType.Size = New System.Drawing.Size(264, 24)
        Me.cboMeatType.TabIndex = 5
        Me.cboMeatType.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(409, 88)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(264, 85)
        Me.txtWeight.TabIndex = 6
        Me.txtWeight.Text = "0"
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Fish Specie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Lot No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Prodn Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Fish Size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Meat Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Shift"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(337, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Weight"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(682, 40)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Loining"
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(544, 184)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(128, 96)
        Me.lblId.TabIndex = 43
        Me.lblId.Text = "0"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblId.Visible = False
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Bitmap)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(144, 224)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 44
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Bitmap)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(224, 224)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 45
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(304, 224)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 46
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(384, 224)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 47
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(464, 224)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 48
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grp
        '
        Me.grp.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label9, Me.Label11, Me.cmdAClose, Me.cmdASave, Me.txtPassword, Me.txtUsername})
        Me.grp.Enabled = False
        Me.grp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(133, 136)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(416, 136)
        Me.grp.TabIndex = 70
        Me.grp.TabStop = False
        Me.grp.Text = "User Authentication"
        Me.grp.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Username"
        '
        'cmdAClose
        '
        Me.cmdAClose.Image = CType(resources.GetObject("cmdAClose.Image"), System.Drawing.Bitmap)
        Me.cmdAClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAClose.Location = New System.Drawing.Point(211, 88)
        Me.cmdAClose.Name = "cmdAClose"
        Me.cmdAClose.Size = New System.Drawing.Size(75, 40)
        Me.cmdAClose.TabIndex = 3
        Me.cmdAClose.Text = "&Cancel"
        Me.cmdAClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdASave
        '
        Me.cmdASave.Image = CType(resources.GetObject("cmdASave.Image"), System.Drawing.Bitmap)
        Me.cmdASave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdASave.Location = New System.Drawing.Point(131, 88)
        Me.cmdASave.Name = "cmdASave"
        Me.cmdASave.Size = New System.Drawing.Size(75, 40)
        Me.cmdASave.TabIndex = 2
        Me.cmdASave.Text = "&Override"
        Me.cmdASave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(148, 56)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(216, 23)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = ""
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(148, 24)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(216, 23)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Text = ""
        '
        'frmMeatRecovery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 279)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdSave, Me.cmdNew, Me.lblId, Me.Label6, Me.Label1, Me.Label7, Me.Label8, Me.Label4, Me.Label3, Me.Label2, Me.txtWeight, Me.cboMeatType, Me.cboFishSize, Me.cboFishSpecie, Me.cboLot, Me.cboShift, Me.txtProdnDate, Me.Label5, Me.grp})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMeatRecovery"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMeatRecovery"
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFishSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFishSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMeatType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMeatRecovery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtProdnDate.Value = getServerDateTime()

        initializeShift()
        displayAllMeatType()
    End Sub

    Public Sub initializeShift()
        With cboShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 135
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text = "" And cboShift.ListCount > 0 Then
            cboShift.SelectedIndex = 0
        End If

        displayAllBatchlotsWithdraw(txtProdnDate.Text, cboShift.Text)
    End Sub

    Public Sub displayAllBatchlotsWithdraw(ByVal prodnDate As String, ByVal shift As String)
        With cboLot
            .Text = ""

            .DataSource = modModule.getAllBatchlotsWithdraw(prodnDate, shift).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 135

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub txtProdnDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdnDate.TextChanged
        displayAllBatchlotsWithdraw(txtProdnDate.Text, cboShift.Text)
    End Sub

    Public Sub displayAllFishSpecieWithdrawPerBatchlot(ByVal prodnDate As String, ByVal shift As String, ByVal lot As String)
        With cboFishSpecie
            .Text = ""

            .DataSource = modModule.getAllFishSpecieWithdrawPerBatchlot(prodnDate, shift, lot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 135

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displayAllFishSpecieWithdrawPerBatchlot(txtProdnDate.Text, cboShift.Text, cboLot.Text)
    End Sub

    Private Sub cboFishSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFishSpecie.TextChanged
        If cboFishSpecie.Text = "" Then If cboFishSpecie.ListCount > 0 Then cboFishSpecie.SelectedIndex = 0

        displayAllFishSizesWithdrawPerBatchlot(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboFishSpecie.Text)
    End Sub

    Public Sub displayAllFishSizesWithdrawPerBatchlot(ByVal prodnDate As String, _
    ByVal shift As String, ByVal lot As String, ByVal specie As String)
        With cboFishSize
            .Text = ""

            .DataSource = modModule.getAllFishSizesWithdrawPerBatchlot(prodnDate, shift, lot, specie).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 135

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboFishSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFishSize.TextChanged
        If cboFishSize.Text = "" Then If cboFishSize.ListCount > 0 Then cboFishSize.SelectedIndex = 0
    End Sub

    Public Sub displayAllMeatType()
        With cboMeatType
            .Text = ""

            .DataSource = modModule.getAllMeatType().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 240

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboMeatType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMeatType.TextChanged
        If cboMeatType.Text = "" Then If cboMeatType.ListCount > 0 Then cboMeatType.SelectedIndex = 0
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged
        If Not IsNumeric(txtWeight.Text) Or txtWeight.Text = "" Then
            txtWeight.Text = "0"
            txtWeight.SelectAll()
            txtWeight.Focus()
        End If
    End Sub

    Public Sub addNewRecord()
        txtProdnDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        'cboLot.Text = ""
        'cboFishSpecie.Text = ""
        'cboFishSize.Text = ""
        displayAllMeatType()
        txtWeight.Text = "0"
        lblId.Text = "0"
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        txtProdnDate.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Not cboShift.Text.Trim = "" And Not cboLot.Text.Trim = "" And _
                            Not cboFishSpecie.Text.Trim = "" And Not cboFishSize.Text.Trim = "" And _
                            Not cboMeatType.Text.Trim = "" And Not txtWeight.Text.Trim = "0" Then
            Dim reply As String
            If lblId.Text = "0" Then
                If Not validateMeatRecovery(txtProdnDate.Text, cboShift.Text, cboLot.Text, _
                        cboFishSpecie.Text, cboFishSize.Text, cboMeatType.Text) Then
                    reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        saveNewMeatRecovery(txtProdnDate.Text, cboShift.Text, cboLot.Text, _
                            cboFishSpecie.Text, cboFishSize.Text, cboMeatType.Text, txtWeight.Text)

                        MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                        addNewRecord()
                        txtProdnDate.Focus()
                    Else
                        txtProdnDate.Focus()
                        Exit Sub
                    End If
                Else
                    MsgBox("Record already exists in the system", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                    txtProdnDate.Focus()
                End If
            Else
                reply = MsgBox("Fish meat information already stored in the database" & Chr(13) & _
                    "To update, please click YES to proceed but please make sure you have properly coordinated this matter to your supervisor", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    showValidationMenu(True)
                Else
                    txtProdnDate.Focus()
                    Exit Sub
                End If
            End If

            'If Not validateMeatRecovery(txtProdnDate.Text, cboShift.Text, cboLot.Text, _
            '            cboFishSpecie.Text, cboFishSize.Text, cboMeatType.Text) Then
            '    reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            '    If reply = vbYes Then
            '        saveNewMeatRecovery(txtProdnDate.Text, cboShift.Text, cboLot.Text, _
            '            cboFishSpecie.Text, cboFishSize.Text, cboMeatType.Text, txtWeight.Text)

            '        MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
            '    Else
            '        txtProdnDate.Focus()
            '        Exit Sub
            '    End If
            'Else
            '    reply = MsgBox("Record already exists in the system." & Chr(13) & _
            '        "Click YES to update the record.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            '    If reply = vbYes Then
            '        updateMeatRecovery(txtProdnDate.Text, cboShift.Text, cboLot.Text, _
            '            cboFishSpecie.Text, cboFishSize.Text, cboMeatType.Text, txtWeight.Text, CLng(lblId.Text))

            '        MsgBox("You have successfully update the existing record.", MsgBoxStyle.Information, "Information")
            '    Else
            '        txtProdnDate.Focus()
            '        Exit Sub
            '    End If
            'End If

            'addNewRecord()
            'txtProdnDate.Focus()
        Else
            MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
            txtProdnDate.Focus()
        End If
        'txtProdnDate.Focus()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        With f
            .lblTitle.Text = "Search Meat Recovery"
            .searchType = 2
            .displayAllMeatRecovery()
            .ShowDialog(Me)

            If Not f.cancel Then
                If .grid.RowCount > 0 Then
                    txtProdnDate.Value = .grid.Item(.grid.Row, 0)
                    cboShift.Text = .grid.Item(.grid.Row, 1)
                    cboLot.Text = .grid.Item(.grid.Row, 2)
                    cboFishSpecie.Text = .grid.Item(.grid.Row, 3)
                    cboFishSize.Text = .grid.Item(.grid.Row, 4)
                    cboMeatType.Text = .grid.Item(.grid.Row, 5)
                    txtWeight.Text = .grid.Item(.grid.Row, 6)
                    lblId.Text = .grid.Item(.grid.Row, 7)
                Else
                    addNewRecord()
                End If
            End If
        End With
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub showValidationMenu(ByVal showMe As Boolean)
        txtUsername.Text = ""
        txtPassword.Text = ""
        Select Case showMe
            Case True
                grp.Enabled = True
                grp.Visible = True
            Case False
                grp.Enabled = False
                grp.Visible = False
        End Select

        txtUsername.SelectAll()
        txtUsername.Focus()
    End Sub

    Private Sub cmdAClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAClose.Click
        showValidationMenu(False)
    End Sub

    Private Sub cmdASave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdASave.Click
        If validateOverrideAccount(txtUsername.Text, txtPassword.Text) Then
            Dim reply As String
            reply = MsgBox("Are you sure you want to update the following information?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then

                updateMeatRecovery(txtProdnDate.Text, cboShift.Text, cboLot.Text, _
                        cboFishSpecie.Text, cboFishSize.Text, cboMeatType.Text, txtWeight.Text, CLng(lblId.Text))

                MsgBox("You have successfully modify the existing record", MsgBoxStyle.Information, "Information")
                Me.showValidationMenu(False)
                addNewRecord()
                cmdClose.Focus()
            End If
        Else
            MsgBox("You have an invalid account.  For assistance, please call your supervisor", MsgBoxStyle.Exclamation, "Access denied")
            cmdAClose.Focus()
        End If
    End Sub
End Class
