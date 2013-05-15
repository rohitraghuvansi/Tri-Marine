Public Class frmFishDeposit_DataEntry3
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents gridSummary As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents cboSublot As C1.Win.C1List.C1Combo
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents cboSize As C1.Win.C1List.C1Combo
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As System.Windows.Forms.Label
    Friend WithEvents txtGW As System.Windows.Forms.TextBox
    Friend WithEvents txtLane As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdInventory As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents txtTW As System.Windows.Forms.Label
    Friend WithEvents txtNW As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalNW As System.Windows.Forms.Label
    Friend WithEvents lblTotalSublot As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuFishBin As System.Windows.Forms.MenuItem
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblClassification As System.Windows.Forms.Label
    Friend WithEvents lblSet As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkSample As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtScaler As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishDeposit_DataEntry3))
        Me.cboVessel = New C1.Win.C1List.C1Combo
        Me.cboSublot = New C1.Win.C1List.C1Combo
        Me.txtDate = New C1.Win.C1Input.C1DateEdit
        Me.cboCS = New C1.Win.C1List.C1Combo
        Me.cboSpecie = New C1.Win.C1List.C1Combo
        Me.cboSize = New C1.Win.C1List.C1Combo
        Me.cboBin = New C1.Win.C1List.C1Combo
        Me.txtGW = New System.Windows.Forms.TextBox
        Me.txtLane = New System.Windows.Forms.TextBox
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdInventory = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboLot = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTW = New System.Windows.Forms.Label
        Me.txtNW = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.gridSummary = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotalNW = New System.Windows.Forms.Label
        Me.lblTotalSublot = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuFishBin = New System.Windows.Forms.MenuItem
        Me.lblClassification = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblSet = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkSample = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtScaler = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboVessel
        '
        Me.cboVessel.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboVessel.AllowColMove = False
        Me.cboVessel.AutoCompletion = True
        Me.cboVessel.AutoDropDown = True
        Me.cboVessel.Caption = ""
        Me.cboVessel.CaptionHeight = 17
        Me.cboVessel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVessel.ColumnCaptionHeight = 17
        Me.cboVessel.ColumnFooterHeight = 17
        Me.cboVessel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboVessel.ContentHeight = 18
        Me.cboVessel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVessel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVessel.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVessel.EditorHeight = 18
        Me.cboVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(96, 56)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(15, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.Size = New System.Drawing.Size(232, 24)
        Me.cboVessel.TabIndex = 0
        Me.cboVessel.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboSublot
        '
        Me.cboSublot.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSublot.AllowColMove = False
        Me.cboSublot.AutoCompletion = True
        Me.cboSublot.AutoDropDown = True
        Me.cboSublot.Caption = ""
        Me.cboSublot.CaptionHeight = 17
        Me.cboSublot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSublot.ColumnCaptionHeight = 17
        Me.cboSublot.ColumnFooterHeight = 17
        Me.cboSublot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboSublot.ContentHeight = 18
        Me.cboSublot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSublot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSublot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSublot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSublot.EditorHeight = 18
        Me.cboSublot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSublot.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboSublot.ItemHeight = 20
        Me.cboSublot.Location = New System.Drawing.Point(96, 119)
        Me.cboSublot.MatchEntryTimeout = CType(2000, Long)
        Me.cboSublot.MaxDropDownItems = CType(10, Short)
        Me.cboSublot.MaxLength = 32767
        Me.cboSublot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSublot.Name = "cboSublot"
        Me.cboSublot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSublot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSublot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSublot.Size = New System.Drawing.Size(128, 24)
        Me.cboSublot.TabIndex = 1
        Me.cboSublot.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(96, 185)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(128, 23)
        Me.txtDate.TabIndex = 2
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboCS.Location = New System.Drawing.Point(96, 216)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(10, Short)
        Me.cboCS.MaxLength = 32767
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.Size = New System.Drawing.Size(232, 24)
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
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboSpecie.ItemHeight = 20
        Me.cboSpecie.Location = New System.Drawing.Point(96, 249)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(10, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.Size = New System.Drawing.Size(232, 24)
        Me.cboSpecie.TabIndex = 4
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboSize
        '
        Me.cboSize.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSize.AllowColMove = False
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
        Me.cboSize.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboSize.ItemHeight = 20
        Me.cboSize.Location = New System.Drawing.Point(96, 282)
        Me.cboSize.MatchEntryTimeout = CType(2000, Long)
        Me.cboSize.MaxDropDownItems = CType(10, Short)
        Me.cboSize.MaxLength = 32767
        Me.cboSize.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSize.Name = "cboSize"
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.Size = New System.Drawing.Size(232, 24)
        Me.cboSize.TabIndex = 5
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
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
        Me.cboBin.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(96, 314)
        Me.cboBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboBin.MaxDropDownItems = CType(10, Short)
        Me.cboBin.MaxLength = 32767
        Me.cboBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBin.Name = "cboBin"
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.Size = New System.Drawing.Size(232, 24)
        Me.cboBin.TabIndex = 6
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'txtGW
        '
        Me.txtGW.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGW.Location = New System.Drawing.Point(96, 349)
        Me.txtGW.Name = "txtGW"
        Me.txtGW.Size = New System.Drawing.Size(232, 33)
        Me.txtGW.TabIndex = 7
        Me.txtGW.Text = "0"
        Me.txtGW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLane
        '
        Me.txtLane.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLane.Location = New System.Drawing.Point(464, 217)
        Me.txtLane.Name = "txtLane"
        Me.txtLane.Size = New System.Drawing.Size(216, 23)
        Me.txtLane.TabIndex = 9
        Me.txtLane.Text = ""
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(464, 250)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(216, 23)
        Me.txtPosition.TabIndex = 10
        Me.txtPosition.Text = ""
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(464, 283)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(216, 23)
        Me.txtHeight.TabIndex = 11
        Me.txtHeight.Text = ""
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(464, 315)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(216, 23)
        Me.txtRemarks.TabIndex = 12
        Me.txtRemarks.Text = "*"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(140, 488)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 14
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(220, 488)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdInventory
        '
        Me.cmdInventory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInventory.Image = CType(resources.GetObject("cmdInventory.Image"), System.Drawing.Image)
        Me.cmdInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdInventory.Location = New System.Drawing.Point(300, 488)
        Me.cmdInventory.Name = "cmdInventory"
        Me.cmdInventory.Size = New System.Drawing.Size(88, 48)
        Me.cmdInventory.TabIndex = 16
        Me.cmdInventory.Text = "&Inventory"
        Me.cmdInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(393, 488)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 17
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(475, 488)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1009, 40)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Round Fish Deposit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Gross Weight"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 317)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 19)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Fish Bin No."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 285)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 19)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Fish Size"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 219)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 19)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "Cold Storage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Fishing Vessel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Fish Specie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Lot No."
        '
        'cboLot
        '
        Me.cboLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.Location = New System.Drawing.Point(96, 87)
        Me.cboLot.Name = "cboLot"
        Me.cboLot.Size = New System.Drawing.Size(128, 24)
        Me.cboLot.TabIndex = 93
        Me.cboLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Sub-lot No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Deposit Date"
        '
        'txtTW
        '
        Me.txtTW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTW.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTW.Location = New System.Drawing.Point(96, 391)
        Me.txtTW.Name = "txtTW"
        Me.txtTW.Size = New System.Drawing.Size(232, 32)
        Me.txtTW.TabIndex = 96
        Me.txtTW.Text = "0"
        Me.txtTW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNW
        '
        Me.txtNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNW.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNW.Location = New System.Drawing.Point(96, 432)
        Me.txtNW.Name = "txtNW"
        Me.txtNW.Size = New System.Drawing.Size(232, 40)
        Me.txtNW.TabIndex = 97
        Me.txtNW.Text = "0"
        Me.txtNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 19)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Tare Weight"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 440)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Net Weight"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(384, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 19)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "Remarks"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(384, 285)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 19)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Height"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(384, 252)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 19)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Row"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(384, 219)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 19)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "Block"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(696, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 19)
        Me.Label20.TabIndex = 105
        Me.Label20.Text = "Summary Details"
        '
        'gridSummary
        '
        Me.gridSummary.AllowColMove = False
        Me.gridSummary.AllowUpdate = False
        Me.gridSummary.CaptionHeight = 17
        Me.gridSummary.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSummary.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSummary.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.gridSummary.Location = New System.Drawing.Point(696, 80)
        Me.gridSummary.Name = "gridSummary"
        Me.gridSummary.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSummary.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSummary.PreviewInfo.ZoomFactor = 75
        Me.gridSummary.RowHeight = 20
        Me.gridSummary.Size = New System.Drawing.Size(306, 392)
        Me.gridSummary.TabIndex = 104
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
        """17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Heig" & _
        "ht>388</Height><CaptionStyle parent=""Heading"" me=""Style77"" /><EditorStyle parent" & _
        "=""Editor"" me=""Style69"" /><EvenRowStyle parent=""EvenRow"" me=""Style75"" /><FilterBa" & _
        "rStyle parent=""FilterBar"" me=""Style80"" /><FooterStyle parent=""Footer"" me=""Style7" & _
        "1"" /><GroupStyle parent=""Group"" me=""Style79"" /><HeadingStyle parent=""Heading"" me" & _
        "=""Style70"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style74"" /><InactiveSt" & _
        "yle parent=""Inactive"" me=""Style73"" /><OddRowStyle parent=""OddRow"" me=""Style76"" /" & _
        "><RecordSelectorStyle parent=""RecordSelector"" me=""Style78"" /><SelectedStyle pare" & _
        "nt=""Selected"" me=""Style72"" /><Style parent=""Normal"" me=""Style68"" /><ClientRect>0" & _
        ", 0, 302, 388</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 302, 388</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(384, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 38)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Total Net Weight"
        '
        'lblTotalNW
        '
        Me.lblTotalNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNW.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNW.Location = New System.Drawing.Point(464, 392)
        Me.lblTotalNW.Name = "lblTotalNW"
        Me.lblTotalNW.Size = New System.Drawing.Size(216, 80)
        Me.lblTotalNW.TabIndex = 106
        Me.lblTotalNW.Text = "0.00"
        Me.lblTotalNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalSublot
        '
        Me.lblTotalSublot.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotalSublot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSublot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSublot.Location = New System.Drawing.Point(96, 151)
        Me.lblTotalSublot.Name = "lblTotalSublot"
        Me.lblTotalSublot.Size = New System.Drawing.Size(128, 24)
        Me.lblTotalSublot.TabIndex = 108
        Me.lblTotalSublot.Text = "0"
        Me.lblTotalSublot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Total Qty."
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(872, 48)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(128, 24)
        Me.lblCode.TabIndex = 110
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCode.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFishBin})
        '
        'mnuFishBin
        '
        Me.mnuFishBin.Index = 0
        Me.mnuFishBin.Text = "Fish Biin"
        '
        'lblClassification
        '
        Me.lblClassification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassification.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassification.Location = New System.Drawing.Point(464, 119)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(208, 24)
        Me.lblClassification.TabIndex = 112
        Me.lblClassification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(384, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 19)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = "Classification"
        '
        'lblSet
        '
        Me.lblSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSet.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSet.Location = New System.Drawing.Point(464, 151)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(208, 24)
        Me.lblSet.TabIndex = 114
        Me.lblSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(384, 154)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 19)
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "Type of Set"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(672, 64)
        Me.Label9.TabIndex = 115
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkSample
        '
        Me.chkSample.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSample.Location = New System.Drawing.Point(464, 353)
        Me.chkSample.Name = "chkSample"
        Me.chkSample.Size = New System.Drawing.Size(16, 24)
        Me.chkSample.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(384, 347)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 37)
        Me.Label22.TabIndex = 117
        Me.Label22.Text = "Protocol Sample"
        '
        'txtScaler
        '
        Me.txtScaler.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScaler.Location = New System.Drawing.Point(464, 185)
        Me.txtScaler.Name = "txtScaler"
        Me.txtScaler.Size = New System.Drawing.Size(216, 23)
        Me.txtScaler.TabIndex = 8
        Me.txtScaler.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(384, 187)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 19)
        Me.Label24.TabIndex = 119
        Me.Label24.Text = "Scaler"
        '
        'frmFishDeposit_DataEntry3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1009, 543)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtScaler)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.chkSample)
        Me.Controls.Add(Me.lblSet)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblClassification)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTotalSublot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotalNW)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.gridSummary)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNW)
        Me.Controls.Add(Me.txtTW)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdInventory)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtLane)
        Me.Controls.Add(Me.txtGW)
        Me.Controls.Add(Me.cboBin)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.cboCS)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.cboSublot)
        Me.Controls.Add(Me.cboVessel)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFishDeposit_DataEntry3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishDeposit_DataEntry3"
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishDeposit_DataEntry3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()

        displayFV()
        displayColdStorage()
        'displayFishSpecie()
        displayFishSizes()
        displayFishBins()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayFV()
        With cboVessel
            .DataSource = getFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 210
        End With
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        cboLot.Text = getCurrentLotPerVessel(cboVessel.Text)
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displaySublot(cboLot.Text)
        displaySummary()
    End Sub

    Public Sub displaySublot(ByVal lot As String)
        With cboSubLot
            .Text = ""
            .DataSource = modModule.getFishLot_MethodAndVesselInfo(lot).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 105
            .Splits(0).DisplayColumns(1).Width = 105

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboSublot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSublot.TextChanged
        If cboSublot.Text = "" Then If cboSublot.ListCount > 0 Then cboSublot.SelectedIndex = 0
        lblTotalSublot.Text = Format(getTotalTonnagePerSublot(cboLot.Text, cboSublot.Text) / 1000, "###,##0.##0")
        displaySubLotDetails(cboLot.Text, cboSublot.Text)
        validateSpecie()

        displaySummary()
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 210

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishSpecie(Optional ByVal specie As String = "")
        With cboSpecie
            .DefColWidth = 210
            If specie = "" Then
                .DataSource = modModule.getFishSpecie().Tables(0)
            Else
                .DataSource = modModule.getFishSpecie(True).Tables(0)
            End If
            '.Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub

    Public Sub displayFishSizes()
        With cboSize
            .DefColWidth = 210
            .DataSource = modModule.getFishSizeRanges().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishBins()
        With cboBin
            .DefColWidth = 210
            .DataSource = modModule.getAllFishBins_AvailableForDeposit().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 99
        End With
    End Sub

    Private Sub txtGW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGW.TextChanged
        If Not IsNumeric(txtGW.Text) Or txtGW.Text.Trim = "" Then
            txtGW.Text = "0"
            txtGW.SelectAll()
            txtGW.Focus()
        End If

        calculateWeights()
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        calculateWeights()
    End Sub

    Public Sub calculateWeights()
        txtTW.Text = getFishBinTareWeight(cboBin.Text)
        txtNW.Text = Format(CDbl(txtGW.Text) - txtTW.Text, "###,###")

        computeTotalNW()
    End Sub

    Public Sub displaySummary()
        With gridSummary
            .DataSource = getLotSummaryPerDeposited(cboLot.Text, txtDate.Value, cboSublot.Text, cboCS.Text).Tables(0)
            .Columns(2).NumberFormat = "###,###,###,##0.#0"

            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 83
        End With

        lblTotalSublot.Text = Format(getTotalTonnagePerSublot(cboLot.Text, cboSublot.Text) / 1000, "###,##0.##0")
        computeTotalNW()
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        displaySummary()
    End Sub

    Private Sub cboCS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCS.TextChanged
        displayFishBins()
        displaySummary()
    End Sub

    Public Sub computeTotalNW()
        Dim ctr As Integer
        Dim total As Double

        While ctr < gridSummary.RowCount
            total += gridSummary.Item(ctr, 2)

            ctr += 1
        End While

        lblTotalNW.Text = Format(total, "###,###,##0.0")
    End Sub

    Private Sub cmdInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInventory.Click
        Dim f As New frmViewInventory_FishDeposit
        f.ShowDialog(Me)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim f As New frmPrintFishDeposits
        'f.displayReport(cboLot.Text)
        'f.ShowDialog(Me)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        cboVessel.SelectAll()
        cboVessel.Focus()
    End Sub

    Public Sub addNewRecord()
        cboVessel.Text = ""
        displayFV()
        displaySublot(cboLot.Text)
        cboLot.Text = ""
        txtDate.Value = getServerDateTime()
        displayColdStorage()
        cboSpecie.Text = ""
        'displayFishSpecie()
        displayFishSizes()
        displayFishBins()
        txtGW.Text = "0"
        calculateWeights()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        calculateWeights()

        Dim reply As String
        'Select Case cmd.Text
        '    Case "&Save"
        If Not cboLot.Text.Trim = "" And Not cboSublot.Text.Trim = "" And Not cboCS.Text.Trim = "" And _
        Not txtLane.Text.Trim = "" And Not txtPosition.Text.Trim = "" And Not txtHeight.Text.Trim = "" And _
        Not cboSpecie.Text.Trim = "" And Not cboSize.Text.Trim = "" And Not cboBin.Text.Trim = "" And _
        Not txtGW.Text.Trim = "" And Not txtGW.Text.Trim = "0" And CDbl(txtGW.Text) > 0 And _
        Not txtTW.Text.Trim = "0" And Not txtScaler.Text.Trim = "" Then
            If validateLock_Lot(cboLot.Text) = "N" Then
                If ((getTotalTonnagePerSublot(cboLot.Text, cboSublot.Text) / 1000) + (txtNW.Text / 1000)) <= 98.0 Then
                    If Not validateFishBinsFromDepositInventory(cboBin.Text) Then
                        reply = MsgBox("Are you sure you want to add this fish bin details?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        Dim withError As Boolean = False
                        Dim sample As String

                        If chkSample.Checked = True Then
                            sample = "YES"
                        Else
                            sample = "NO"
                        End If

                        If reply = vbYes Then
                            If validateFishBinDeposited(cboLot.Text, cboBin.Text, cboSublot.Text) Then
                                updateFishBinDeposited(cboLot.Text, cboSublot.Text, cboCS.Text, txtRemarks.Text, _
                                    cboBin.Text, cboSpecie.Text, cboSize.Text, _
                                    CDbl(txtGW.Text), txtLane.Text, txtPosition.Text, txtHeight.Text)
                            Else
                                saveNewFishBinForDeposit(cboBin.Text, txtDate.Text, cboCS.Text, txtRemarks.Text.Trim, _
                                    cboLot.Text, cboSpecie.Text, cboSize.Text, CDbl(txtGW.Text), cboSublot.Text, _
                                    False, txtLane.Text, txtPosition.Text, txtHeight.Text, sample, txtScaler.Text)
                            End If
                        Else
                            cboVessel.SelectAll()
                            cboVessel.Focus()
                            Exit Sub
                        End If

                        MsgBox("You have successfully compeleted the transaction", MsgBoxStyle.Information, "Information")

                        lblCode.Text = ""
                        cboBin.Text = ""
                        txtGW.Text = "0"
                        displayFishBins()
                        displaySummary()
                        cboBin.SelectAll()
                        cboBin.Focus()
                    Else
                        MsgBox("Fish bin number " & cboBin.Text & " already used in the system" & Chr(13) & _
                            "Please use another fish bin number or check the bin number for duplicate numbering", MsgBoxStyle.Exclamation, "Warning")
                        cboVessel.SelectAll()
                        cboVessel.Focus()
                        Exit Sub
                    End If
                Else
                    MsgBox("You are trying to add a quantity of bin which exceeds the total allowable quantity of 98MT that must be allocated per sublot" & Chr(13) & _
                        "Please use another sublot number for this entry", MsgBoxStyle.Exclamation, "Warning")
                    cboSublot.SelectAll()
                    cboSublot.Focus()
                End If
            Else
                MsgBox("Fish Lot already locked for transaction.  Please consult your system administrator for more information", MsgBoxStyle.Exclamation, "Warning")
                cboVessel.SelectAll()
                cboVessel.Focus()
            End If
        Else
            MsgBox("Please check your data entry fields.", MsgBoxStyle.Critical, "Result: Invalid input and check the data")
            cboVessel.SelectAll()
            cboVessel.Focus()
        End If
    End Sub

    Public Sub saveNewFishBinForDeposit(ByVal bin As String, ByVal dateTime As String, ByVal cs As String, _
    ByVal remarks As String, ByVal lot As String, ByVal fishSpecie As String, ByVal size As String, _
    ByVal grossWeight As Double, ByVal sublot As String, ByVal hold As Boolean, _
    ByVal location As String, ByVal position As String, ByVal height As String, _
    ByVal sample As String, ByVal scaler As String)
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

    Private Sub cboVessel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVessel.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSublot.SelectAll()
            cboSublot.Focus()
        End If
    End Sub

    Private Sub cboSublot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSublot.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDate.Focus()
        End If
    End Sub

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCS.SelectAll()
            cboCS.Focus()
        End If
    End Sub

    Private Sub cboCS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCS.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSpecie.SelectAll()
            cboSpecie.Focus()
        End If
    End Sub

    Private Sub cboSpecie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSpecie.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSize.SelectAll()
            cboSize.Focus()
        End If
    End Sub

    Private Sub cboSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSize.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboBin.SelectAll()
            cboBin.Focus()
        End If
    End Sub

    Private Sub cboBin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGW.SelectAll()
            txtGW.Focus()
        End If
    End Sub

    Private Sub txtGW_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGW.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave.Focus()
        End If
    End Sub

    Private Sub mnuFishBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFishBin.Click
        Dim f As New frmFishBin
        f.ShowDialog(Me)
        displayFishBins()
        calculateWeights()

        cboBin.SelectAll()
        cboBin.Focus()
    End Sub

    Public Sub displaySubLotDetails(ByVal lot As String, ByVal sublot As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_sublotDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@lot"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = lot

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@sublot"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = sublot

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblClassification.Text = dr.GetString(1)
                    lblSet.Text = dr.GetString(2)
                Else
                    lblClassification.Text = ""
                    lblSet.Text = ""
                End If
            Else
                lblClassification.Text = ""
                lblSet.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub lblClassification_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClassification.TextChanged
        validateSpecie()
    End Sub

    Public Sub validateSpecie()
        If lblClassification.Text.Trim = "" Then
            displayFishSpecie()
            cboSpecie.ReadOnly = False
        ElseIf lblClassification.Text.StartsWith("Yellow") Then
            cboSpecie.ReadOnly = False
            displayFishSpecie("YF")
            cboSpecie.Text = lblClassification.Text
        Else
            displayFishSpecie()
            cboSpecie.Text = lblClassification.Text
            cboSpecie.ReadOnly = True
        End If
    End Sub

    Private Sub cboSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSpecie.TextChanged
        displayFishBins()
    End Sub

    Private Sub cboSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.TextChanged
        displayFishBins()
    End Sub
End Class
