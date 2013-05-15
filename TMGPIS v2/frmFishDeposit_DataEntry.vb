Public Class frmFishDeposit_DataEntry
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
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents cboSize As C1.Win.C1List.C1Combo
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents chkDummy As System.Windows.Forms.CheckBox
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtGW As System.Windows.Forms.TextBox
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblCondition As System.Windows.Forms.Label
    Friend WithEvents lblVessel As System.Windows.Forms.Label
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtTW As System.Windows.Forms.Label
    Friend WithEvents txtNW As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuFB As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSpecie As System.Windows.Forms.MenuItem
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdAClose As System.Windows.Forms.Button
    Friend WithEvents cmdASave As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents cboSubLot As C1.Win.C1List.C1Combo
    Friend WithEvents lblPreservationMethod As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishDeposit_DataEntry))
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.cboSubLot = New C1.Win.C1List.C1Combo()
        Me.cboSpecie = New C1.Win.C1List.C1Combo()
        Me.cboSize = New C1.Win.C1List.C1Combo()
        Me.cboBin = New C1.Win.C1List.C1Combo()
        Me.chkDummy = New System.Windows.Forms.CheckBox()
        Me.cboCS = New C1.Win.C1List.C1Combo()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtGW = New System.Windows.Forms.TextBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.lblVessel = New System.Windows.Forms.Label()
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTW = New System.Windows.Forms.Label()
        Me.txtNW = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblPreservationMethod = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuFB = New System.Windows.Forms.MenuItem()
        Me.mnuSpecie = New System.Windows.Forms.MenuItem()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdAClose = New System.Windows.Forms.Button()
        Me.cmdASave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
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
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(96, 56)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 6
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
        Me.cboSubLot.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.cboSubLot.ItemHeight = 20
        Me.cboSubLot.Location = New System.Drawing.Point(96, 92)
        Me.cboSubLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboSubLot.MaxDropDownItems = CType(20, Short)
        Me.cboSubLot.MaxLength = 32767
        Me.cboSubLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSubLot.Name = "cboSubLot"
        Me.cboSubLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSubLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSubLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSubLot.Size = New System.Drawing.Size(208, 24)
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
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.cboSpecie.ItemHeight = 20
        Me.cboSpecie.Location = New System.Drawing.Point(96, 224)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(20, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.Size = New System.Drawing.Size(208, 24)
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
        'cboSize
        '
        Me.cboSize.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSize.AllowColMove = False
        Me.cboSize.AllowSort = False
        Me.cboSize.AutoCompletion = True
        Me.cboSize.AutoDropDown = True
        Me.cboSize.Caption = ""
        Me.cboSize.CaptionHeight = 17
        Me.cboSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSize.ColumnCaptionHeight = 17
        Me.cboSize.ColumnFooterHeight = 17
        Me.cboSize.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboSize.ContentHeight = 18
        Me.cboSize.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSize.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSize.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSize.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSize.EditorHeight = 18
        Me.cboSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSize.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.cboSize.ItemHeight = 20
        Me.cboSize.Location = New System.Drawing.Point(96, 256)
        Me.cboSize.MatchEntryTimeout = CType(2000, Long)
        Me.cboSize.MaxDropDownItems = CType(20, Short)
        Me.cboSize.MaxLength = 32767
        Me.cboSize.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSize.Name = "cboSize"
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.Size = New System.Drawing.Size(208, 24)
        Me.cboSize.TabIndex = 3
        Me.cboSize.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboBin
        '
        Me.cboBin.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboBin.AllowColMove = False
        Me.cboBin.AutoCompletion = True
        Me.cboBin.AutoDropDown = True
        Me.cboBin.Caption = ""
        Me.cboBin.CaptionHeight = 17
        Me.cboBin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBin.ColumnCaptionHeight = 17
        Me.cboBin.ColumnFooterHeight = 17
        Me.cboBin.ContentHeight = 18
        Me.cboBin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBin.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBin.EditorHeight = 18
        Me.cboBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.Images.Add(CType(resources.GetObject("resource.Images4"), System.Drawing.Bitmap))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(96, 288)
        Me.cboBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboBin.MaxDropDownItems = CType(20, Short)
        Me.cboBin.MaxLength = 32767
        Me.cboBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBin.Name = "cboBin"
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.Size = New System.Drawing.Size(121, 24)
        Me.cboBin.TabIndex = 4
        Me.cboBin.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'chkDummy
        '
        Me.chkDummy.Font = New System.Drawing.Font("Tahoma", 9.75!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDummy.Location = New System.Drawing.Point(224, 288)
        Me.chkDummy.Name = "chkDummy"
        Me.chkDummy.Size = New System.Drawing.Size(80, 24)
        Me.chkDummy.TabIndex = 5
        Me.chkDummy.Text = "&Dummy"
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
        Me.cboCS.Images.Add(CType(resources.GetObject("resource.Images5"), System.Drawing.Bitmap))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(96, 319)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(20, Short)
        Me.cboCS.MaxLength = 32767
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.Size = New System.Drawing.Size(208, 24)
        Me.cboCS.TabIndex = 6
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
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(96, 352)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(208, 23)
        Me.txtRemarks.TabIndex = 7
        Me.txtRemarks.Text = ""
        '
        'txtGW
        '
        Me.txtGW.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGW.Location = New System.Drawing.Point(512, 176)
        Me.txtGW.Name = "txtGW"
        Me.txtGW.Size = New System.Drawing.Size(200, 43)
        Me.txtGW.TabIndex = 8
        Me.txtGW.Text = "0"
        Me.txtGW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Bitmap)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(168, 400)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 9
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Bitmap)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(248, 400)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(328, 400)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 11
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(408, 400)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 12
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(488, 400)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(520, 56)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(200, 56)
        Me.lblCode.TabIndex = 42
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCode.Visible = False
        '
        'lblCondition
        '
        Me.lblCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCondition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondition.Location = New System.Drawing.Point(96, 160)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(208, 24)
        Me.lblCondition.TabIndex = 43
        '
        'lblVessel
        '
        Me.lblVessel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVessel.Location = New System.Drawing.Point(96, 192)
        Me.lblVessel.Name = "lblVessel"
        Me.lblVessel.Size = New System.Drawing.Size(208, 24)
        Me.lblVessel.TabIndex = 44
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(520, 124)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.TabIndex = 45
        Me.txtDate.TabStop = False
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(730, 40)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Fish Deposit Information"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(448, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 44)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Net Weight"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(448, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 37)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Tare Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Cold Storage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Fish Bin#"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(448, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 37)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Gross Weight"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Lot#"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Fish Specie"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Fish Size"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 16)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Sub-lot#"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Fish Condition"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Vessel Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 355)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Remarks"
        '
        'txtTW
        '
        Me.txtTW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTW.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTW.Location = New System.Drawing.Point(512, 240)
        Me.txtTW.Name = "txtTW"
        Me.txtTW.Size = New System.Drawing.Size(200, 43)
        Me.txtTW.TabIndex = 61
        Me.txtTW.Text = "0"
        Me.txtTW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNW
        '
        Me.txtNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNW.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNW.Location = New System.Drawing.Point(512, 304)
        Me.txtNW.Name = "txtNW"
        Me.txtNW.Size = New System.Drawing.Size(200, 43)
        Me.txtNW.TabIndex = 62
        Me.txtNW.Text = "0"
        Me.txtNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(433, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 16)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "Date/ Time"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(432, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "Control No."
        Me.Label19.Visible = False
        '
        'lblPreservationMethod
        '
        Me.lblPreservationMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPreservationMethod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreservationMethod.Location = New System.Drawing.Point(96, 123)
        Me.lblPreservationMethod.Name = "lblPreservationMethod"
        Me.lblPreservationMethod.Size = New System.Drawing.Size(208, 24)
        Me.lblPreservationMethod.TabIndex = 65
        Me.lblPreservationMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 36)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Preservation Method"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 216)
        Me.Label1.TabIndex = 67
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFB, Me.mnuSpecie})
        '
        'mnuFB
        '
        Me.mnuFB.Index = 0
        Me.mnuFB.Text = "Fish &Bin"
        '
        'mnuSpecie
        '
        Me.mnuSpecie.Index = 1
        Me.mnuSpecie.Text = "Fish &Specie"
        '
        'grp
        '
        Me.grp.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.Label11, Me.cmdAClose, Me.cmdASave, Me.txtPassword, Me.txtUsername})
        Me.grp.Enabled = False
        Me.grp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(157, 312)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(416, 136)
        Me.grp.TabIndex = 68
        Me.grp.TabStop = False
        Me.grp.Text = "User Authentication"
        Me.grp.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Password"
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
        Me.cmdAClose.Text = "&Close"
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
        'frmFishDeposit_DataEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(730, 455)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grp, Me.Label2, Me.lblPreservationMethod, Me.Label19, Me.Label18, Me.txtNW, Me.txtTW, Me.Label17, Me.Label16, Me.Label15, Me.Label14, Me.Label8, Me.Label9, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label10, Me.Label12, Me.Label13, Me.txtDate, Me.lblVessel, Me.lblCondition, Me.lblCode, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdSave, Me.cmdNew, Me.txtGW, Me.txtRemarks, Me.cboCS, Me.chkDummy, Me.cboBin, Me.cboSize, Me.cboSpecie, Me.cboSubLot, Me.cboLot, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishDeposit_DataEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishDeposit_DataEntry"
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishDeposit_DataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()

        displayBatchlot()
        displayFishSpecie()
        displayFishSizes()
        displayFishBins()
        displayColdStorage()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayFishBins()
        With cboBin
            .DataSource = modModule.getFishBins().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 99
        End With
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

    Public Sub displayFishSpecie()
        With cboSpecie
            .DataSource = modModule.getFishSpecie().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub

    Private Sub cboCS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCS.TextChanged
        If cboCS.Text = "" Then If cboCS.ListCount > 0 Then cboCS.SelectedIndex = 0
    End Sub

    Public Sub displayFishSizes()
        With cboSize
            .DataSource = modModule.getFishSizeRanges().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.TextChanged
        If cboSize.Text = "" Then If cboSize.ListCount > 0 Then cboSize.SelectedIndex = 0
    End Sub

    Public Sub displaySublot(ByVal lot As String)
        With cboSubLot
            .Text = ""
            .DataSource = modModule.getFishLot_MethodAndVesselInfo(lot).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 65
            .Splits(0).DisplayColumns(1).Width = 135

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displaySublot(cboLot.Text)
    End Sub

    Private Sub chkDummy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDummy.CheckedChanged
        If chkDummy.Checked = True Then
            cboBin.ReadOnly = True
            cboBin.Text = "BULK"
            cboCS.SelectAll()
            cboCS.Focus()
        Else
            cboBin.ReadOnly = False
            If cboBin.ListCount > 0 Then cboBin.SelectedIndex = 0
            cboBin.Focus()
        End If
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
        cboSpecie.Text = ""
        displayFishSpecie()
        cboSize.Text = ""
        displayFishSizes()
        cboBin.Text = ""
        displayFishBins()
        chkDummy.Checked = False
        cboCS.Text = ""
        displayColdStorage()
        txtDate.Value = getServerDateTime()
        txtRemarks.Text = ""
        txtGW.Text = "0"
        txtTW.Text = "0"
        txtNW.Text = "0"
    End Sub

    Public Sub computeNetWeight(ByVal gross As String, ByVal tare As String)
        If gross = "" Then gross = 0
        If tare = "" Then tare = 0

        txtNW.Text = Format(gross - tare, "###,###,##0.#0")
    End Sub

    Private Sub txtGW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGW.TextChanged
        If Not IsNumeric(txtGW.Text) Or txtGW.Text = "" Then
            txtGW.Text = "0"
            txtGW.SelectAll()
            txtGW.Focus()
        Else
            computeNetWeight(txtGW.Text, txtTW.Text)
        End If
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        If validateFishBinsFromDepositInventory(cboBin.Text) Then
            MsgBox("Please withdraw Fish Bin No. " & cboBin.Text & " in the cold storage inventory before you can re-use it again.", MsgBoxStyle.Critical, "Result: Invalid Fish Bin No.")
            cboBin.Text = ""
            cboBin.Focus()
        End If

        txtTW.Text = Format(getFishBinTareWeight(cboBin.Text), "###,###,##0.#0")
        computeNetWeight(txtGW.Text, txtTW.Text)

        'displayRecord(cboBin.Text)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String
        'Select Case cmd.Text
        '    Case "&Save"
        If Not cboBin.Text.Trim = "" And Not cboCS.Text.Trim = "" And Not cboLot.Text.Trim = "" And Not cboSubLot.Text.Trim = "" And _
        Not lblVessel.Text.Trim = "" And Not cboSpecie.Text.Trim = "" And Not cboSize.Text.Trim = "" And Not txtGW.Text.Trim = "0" Then
            If Not validateFishBinsFromDepositInventory(cboBin.Text) Then
                If validateFishLot(cboLot.Text) Then
                    If validateFishBins(cboBin.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            'NOT YET INCLUDED THE SAVING OF HOLD DATA
                            saveNewFishBinForDeposit(cboBin.Text, txtDate.Text, cboCS.Text, txtRemarks.Text.Trim, _
                                cboLot.Text, cboSpecie.Text, cboSize.Text, CDbl(txtGW.Text), CInt(cboSubLot.Text))

                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            addNewRecord()
                            cboLot.SelectAll()
                            cboLot.Focus()
                        Else
                            cboLot.SelectAll()
                            cboLot.Focus()
                            Exit Sub
                        End If
                    Else
                        MsgBox("Fish bin doesn't found in the database", MsgBoxStyle.Critical, "No record found")
                        cboBin.SelectAll()
                        cboBin.Focus()
                    End If
                Else
                    MsgBox("Fish lot doesn't found in the database", MsgBoxStyle.Critical, "No record found")
                    cboLot.SelectAll()
                    cboLot.Focus()
                End If
            Else
                MsgBox("Please withdraw Fish Bin No. " & cboBin.Text & " in the cold storage inventory before you can re-use it again.", MsgBoxStyle.Critical, "Result: Found missing value.")
                cboBin.SelectAll()
                cboBin.Focus()
                'Dim r As String
                'r = MsgBox("Please withdraw Fish Bin No. " & cboBin.Text & " in the cold storage inventory before you can re-use it again." & Chr(13) & _
                '    "To update, please click YES to proceed but please make sure you have properly coordinated this matter to your supervisor", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning")
                'If r = vbYes Then
                '    showValidationMenu(True)
                'Else
                '    cboBin.SelectAll()
                '    cboBin.Focus()
                'End If
            End If

            'displayAllFishDeposits()

        Else
            MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
            cboBin.SelectAll()
            cboBin.Focus()
        End If
        'Case "&Add"
        '    cmd.Text = "&Save"
        '    cmdEdit.Text = "&Cancel"
        '    buttons(0)
        '    dataEntry(0)
        '    addNewRecord()
        '    txtBinNo.SelectAll()
        '    txtBinNo.Focus()
        'Case "&Save "
        '    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        '    If reply = vbYes Then
        '        updateFishBins(lblCode.Text, txtBinNo.Text, txtTare.Text, "N")
        '        cmd.Text = "&Add"
        '        cmdEdit.Text = "&Edit"
        '        buttons(1)
        '        dataEntry(1)

        '        displayAllFishBins()
        '        MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
        '        cmd.Focus()
        '    End If
        'End Select
    End Sub

    Public Sub saveNewFishBinForDeposit(ByVal bin As String, ByVal dateTime As String, ByVal cs As String, _
    ByVal remarks As String, ByVal lot As String, ByVal fishSpecie As String, ByVal size As String, _
    ByVal grossWeight As Double, ByVal sublot As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_addNew_FishBinsDeposit"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishBinForDepositCounter()

            Dim p2 As New SqlClient.SqlParameter()
            p2.ParameterName = "@depositCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = "FD" & Format(getFishBinForDepositCounter, "0#####") & bin & p1.Value
            lblCode.Text = p2.Value

            Dim p3 As New SqlClient.SqlParameter()
            p3.ParameterName = "@binCode"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = getFishBinCode(bin)

            Dim p4 As New SqlClient.SqlParameter()
            p4.ParameterName = "@batchlot"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = lot

            Dim p5 As New SqlClient.SqlParameter()
            p5.ParameterName = "@specieCode"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = getSpecieCode(fishSpecie)

            Dim p6 As New SqlClient.SqlParameter()
            p6.ParameterName = "@csCode"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = getCSCode(cs)

            Dim p7 As New SqlClient.SqlParameter()
            p7.ParameterName = "@grossWeight"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.Float
            p7.Value = grossWeight

            Dim p8 As New SqlClient.SqlParameter()
            p8.ParameterName = "@dateTimeTransfer"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.DateTime
            p8.Value = Format(CDate(dateTime), getTimeFormat())

            Dim p9 As New SqlClient.SqlParameter()
            p9.ParameterName = "@remarks"
            p9.Direction = ParameterDirection.Input
            p9.SqlDbType = SqlDbType.VarChar
            p9.Value = remarks

            Dim p10 As New SqlClient.SqlParameter()
            p10.ParameterName = "@withdraw"
            p10.Direction = ParameterDirection.Input
            p10.SqlDbType = SqlDbType.VarChar
            p10.Value = "NO"

            Dim p11 As New SqlClient.SqlParameter()
            p11.ParameterName = "@depositStatus"
            p11.Direction = ParameterDirection.Input
            p11.SqlDbType = SqlDbType.VarChar
            p11.Value = "*"

            Dim pOptr As New SqlClient.SqlParameter()
            pOptr.ParameterName = "@optr"
            pOptr.Direction = ParameterDirection.Input
            pOptr.SqlDbType = SqlDbType.VarChar
            pOptr.Value = modModule.getUsername

            Dim pEncoded As New SqlClient.SqlParameter()
            pEncoded.ParameterName = "@dateTimeEncoded"
            pEncoded.Direction = ParameterDirection.Input
            pEncoded.SqlDbType = SqlDbType.DateTime
            pEncoded.Value = getServerDateTime()

            Dim p12 As New SqlClient.SqlParameter()
            p12.ParameterName = "@sizeCode"
            p12.Direction = ParameterDirection.Input
            p12.SqlDbType = SqlDbType.VarChar
            p12.Value = getFishSizeCodeByRange(size)

            Dim p13 As New SqlClient.SqlParameter()
            p13.ParameterName = "@sublot"
            p13.Direction = ParameterDirection.Input
            p13.SqlDbType = SqlDbType.VarChar
            p13.Value = sublot

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

            Dim daBuyer As New SqlClient.SqlDataAdapter()
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

    Public Function isFishBinNotYetWithdrawn(ByVal bin As String) As Boolean
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_search_DepositedFishBins"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@bin"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = bin

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            Dim withdraw As Boolean
            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    withdraw = False
                    'txtDate.Value = dr.GetDateTime(0)
                    'cboCS.Text = dr.GetString(1)
                    'txtRemarks.Text = dr.GetString(2)
                    'cboLot.Text = dr.GetString(3)
                    'cboSpecie.Text = dr.GetString(4)
                    'cboSize.Text = dr.GetString(5)
                    'txtGW.Text = dr.GetDouble(6)
                    'lblCode.Text = dr.GetString(9)
                Else
                    withdraw = True
                    'txtDate.Value = Format(getServerDateTime(), getTimeFormat())
                    'cboCS.Text = ""
                    'txtRemarks.Text = ""
                    'cboLot.Text = ""
                    'cboSpecie.Text = ""
                    'cboSize.Text = ""
                    'txtGW.Text = "0"
                    'lblCode.Text = ""
                End If
            Else
                withdraw = True
                'txtDate.Value = Format(getServerDateTime(), getTimeFormat())
                'cboCS.Text = ""
                'txtRemarks.Text = ""
                'cboLot.Text = ""
                'cboSpecie.Text = ""
                'cboSize.Text = ""
                'txtGW.Text = "0"
                'lblCode.Text = ""
            End If

            dr.Close()
            c.Close()

            Return withdraw
        Catch e As Exception
            'MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Function

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
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
                cboSpecie.Text = .grid.Item(.grid.Row, 5)
                cboSize.Text = .grid.Item(.grid.Row, 6)

                If CStr(.grid.Item(.grid.Row, 7)).StartsWith("BULK") Then
                    chkDummy.Checked = True
                Else
                    chkDummy.Checked = False
                End If

                cboBin.Text = .grid.Item(.grid.Row, 7)
                cboCS.Text = .grid.Item(.grid.Row, 8)
                txtRemarks.Text = .grid.Item(.grid.Row, 9)
                txtDate.Value = .grid.Item(.grid.Row, 10)
                txtGW.Text = Format(CDbl(.grid.Item(.grid.Row, 11)), "###,##0.#0")
                txtTW.Text = Format(.grid.Item(.grid.Row, 12), "###,##0.#0")
                txtNW.Text = Format(.grid.Item(.grid.Row, 13), "###,##0.#0")
                lblCode.Text = .grid.Item(.grid.Row, 15)
            End If
        End With
        'displayRecord(f.searchItem)
    End Sub

    Private Sub mnuFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFB.Click
        Dim f As New frmFishBin()
        f.ShowDialog(Me)

        displayFishBins()
        cboBin_TextChanged(sender, New EventArgs())

        cboBin.SelectAll()
        cboBin.Focus()
    End Sub

    Private Sub mnuSpecie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSpecie.Click
        Dim f As New frmSpecie2()
        f.ShowDialog(Me)

        displayFishSpecie()
        cboSpecie.SelectAll()
        cboSpecie.Focus()
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
                updateFishBinForDeposits(lblCode.Text, cboBin.Text, txtDate.Text, cboCS.Text, _
                    txtRemarks.Text.Trim, cboLot.Text, cboSpecie.Text, cboSize.Text, _
                    CDbl(txtGW.Text), CInt(cboSubLot.Text))

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
        End With
    End Sub
End Class
