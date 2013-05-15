Public Class frmFishWithdrawal_DataEntry
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFWS As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cboPurpose As C1.Win.C1List.C1Combo
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents lblDateRel As System.Windows.Forms.Label
    Friend WithEvents lblFishSpecie As System.Windows.Forms.Label
    Friend WithEvents lblFishSize As System.Windows.Forms.Label
    Friend WithEvents lblNW As System.Windows.Forms.Label
    Friend WithEvents lblTW As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cboRemarks As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishWithdrawal_DataEntry))
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit
        Me.cboShift = New C1.Win.C1List.C1Combo
        Me.cboPurpose = New C1.Win.C1List.C1Combo
        Me.cboCS = New C1.Win.C1List.C1Combo
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.cboBin = New C1.Win.C1List.C1Combo
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFWS = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDateRel = New System.Windows.Forms.Label
        Me.lblFishSpecie = New System.Windows.Forms.Label
        Me.lblFishSize = New System.Windows.Forms.Label
        Me.lblNW = New System.Windows.Forms.Label
        Me.lblTW = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboRemarks = New C1.Win.C1List.C1Combo
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPurpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.Location = New System.Drawing.Point(96, 86)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(224, 23)
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
        Me.cboShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboShift.EditorHeight = 18
        Me.cboShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(96, 120)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.Size = New System.Drawing.Size(144, 24)
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboPurpose
        '
        Me.cboPurpose.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboPurpose.AllowColMove = False
        Me.cboPurpose.AutoCompletion = True
        Me.cboPurpose.AutoDropDown = True
        Me.cboPurpose.Caption = ""
        Me.cboPurpose.CaptionHeight = 17
        Me.cboPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPurpose.ColumnCaptionHeight = 17
        Me.cboPurpose.ColumnFooterHeight = 17
        Me.cboPurpose.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboPurpose.ContentHeight = 18
        Me.cboPurpose.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPurpose.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPurpose.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPurpose.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPurpose.EditorHeight = 18
        Me.cboPurpose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPurpose.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboPurpose.ItemHeight = 20
        Me.cboPurpose.Location = New System.Drawing.Point(96, 152)
        Me.cboPurpose.MatchEntryTimeout = CType(2000, Long)
        Me.cboPurpose.MaxDropDownItems = CType(5, Short)
        Me.cboPurpose.MaxLength = 32767
        Me.cboPurpose.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPurpose.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPurpose.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPurpose.Size = New System.Drawing.Size(224, 24)
        Me.cboPurpose.TabIndex = 2
        Me.cboPurpose.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboCS.ReadOnly = True
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.Size = New System.Drawing.Size(224, 24)
        Me.cboCS.TabIndex = 3
        Me.cboCS.TabStop = False
        Me.cboCS.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboLot.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(96, 249)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(10, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(224, 24)
        Me.cboLot.TabIndex = 4
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
        Me.cboBin.ContentHeight = 45
        Me.cboBin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBin.EditorFont = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBin.EditorHeight = 45
        Me.cboBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(448, 53)
        Me.cboBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboBin.MaxDropDownItems = CType(10, Short)
        Me.cboBin.MaxLength = 32767
        Me.cboBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBin.Name = "cboBin"
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.Size = New System.Drawing.Size(224, 51)
        Me.cboBin.TabIndex = 5
        Me.cboBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cboBin.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(64, 488)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 6
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(144, 488)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(224, 488)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(304, 488)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 9
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
        Me.Label13.Size = New System.Drawing.Size(682, 40)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Cannery Acceptance Transaction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Bin No."
        '
        'lblFWS
        '
        Me.lblFWS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFWS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWS.Location = New System.Drawing.Point(96, 54)
        Me.lblFWS.Name = "lblFWS"
        Me.lblFWS.Size = New System.Drawing.Size(224, 23)
        Me.lblFWS.TabIndex = 34
        Me.lblFWS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 19)
        Me.Label14.TabIndex = 127
        Me.Label14.Text = "Lot No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 19)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Prodn Shift"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 19)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Prodn Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Cold Storage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Purpose"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Date Released"
        Me.Label3.Visible = False
        '
        'lblDateRel
        '
        Me.lblDateRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateRel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRel.Location = New System.Drawing.Point(136, 32)
        Me.lblDateRel.Name = "lblDateRel"
        Me.lblDateRel.Size = New System.Drawing.Size(184, 23)
        Me.lblDateRel.TabIndex = 128
        Me.lblDateRel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDateRel.Visible = False
        '
        'lblFishSpecie
        '
        Me.lblFishSpecie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFishSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFishSpecie.Location = New System.Drawing.Point(448, 112)
        Me.lblFishSpecie.Name = "lblFishSpecie"
        Me.lblFishSpecie.Size = New System.Drawing.Size(224, 23)
        Me.lblFishSpecie.TabIndex = 129
        Me.lblFishSpecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFishSize
        '
        Me.lblFishSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFishSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFishSize.Location = New System.Drawing.Point(448, 144)
        Me.lblFishSize.Name = "lblFishSize"
        Me.lblFishSize.Size = New System.Drawing.Size(224, 23)
        Me.lblFishSize.TabIndex = 130
        Me.lblFishSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNW
        '
        Me.lblNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNW.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNW.Location = New System.Drawing.Point(448, 232)
        Me.lblNW.Name = "lblNW"
        Me.lblNW.Size = New System.Drawing.Size(224, 48)
        Me.lblNW.TabIndex = 132
        Me.lblNW.Text = "0"
        Me.lblNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTW
        '
        Me.lblTW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTW.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTW.Location = New System.Drawing.Point(448, 176)
        Me.lblTW.Name = "lblTW"
        Me.lblTW.Size = New System.Drawing.Size(224, 48)
        Me.lblTW.TabIndex = 131
        Me.lblTW.Text = "0"
        Me.lblTW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 19)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "Tracking No."
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 304)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(664, 176)
        Me.grid.TabIndex = 134
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
        "eight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWid" & _
        "th=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>172</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 660, 172</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>17</DefaultRecSelWidth><ClientArea>0, 0, 660, 172</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 283)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 19)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Cannery Accepted Summary"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(368, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 19)
        Me.Label16.TabIndex = 136
        Me.Label16.Text = "Fish Specie"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(368, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 19)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Tare Weight"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(368, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 19)
        Me.Label18.TabIndex = 137
        Me.Label18.Text = "Fish Size"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(368, 238)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 19)
        Me.Label19.TabIndex = 140
        Me.Label19.Text = "Net Weight"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(504, 488)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(168, 47)
        Me.lblTotal.TabIndex = 141
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(416, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Total Quantity"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'cboRemarks
        '
        Me.cboRemarks.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboRemarks.AllowColMove = False
        Me.cboRemarks.AutoCompletion = True
        Me.cboRemarks.AutoDropDown = True
        Me.cboRemarks.Caption = ""
        Me.cboRemarks.CaptionHeight = 17
        Me.cboRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRemarks.ColumnCaptionHeight = 17
        Me.cboRemarks.ColumnFooterHeight = 17
        Me.cboRemarks.ContentHeight = 18
        Me.cboRemarks.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRemarks.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRemarks.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemarks.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemarks.EditorHeight = 18
        Me.cboRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemarks.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.cboRemarks.ItemHeight = 20
        Me.cboRemarks.Location = New System.Drawing.Point(96, 184)
        Me.cboRemarks.MatchEntryTimeout = CType(2000, Long)
        Me.cboRemarks.MaxDropDownItems = CType(5, Short)
        Me.cboRemarks.MaxLength = 32767
        Me.cboRemarks.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRemarks.Name = "cboRemarks"
        Me.cboRemarks.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRemarks.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRemarks.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRemarks.Size = New System.Drawing.Size(224, 24)
        Me.cboRemarks.TabIndex = 3
        Me.cboRemarks.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Destination"
        '
        'frmFishWithdrawal_DataEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboRemarks)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblNW)
        Me.Controls.Add(Me.lblTW)
        Me.Controls.Add(Me.lblFishSize)
        Me.Controls.Add(Me.lblFishSpecie)
        Me.Controls.Add(Me.lblDateRel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFWS)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cboBin)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.cboCS)
        Me.Controls.Add(Me.cboPurpose)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtProdnDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFishWithdrawal_DataEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishWithdrawal_DataEntry"
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPurpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishWithdrawal_DataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        lblDateRel.Text = getServerDateTime()
        txtProdnDate.Value = getServerDateTime()

        initializeShift()
        displayPurpose()
        'displayColdStorage()
        displayAllBatchlotsDeposited("%")
        'displayFishLotDepositedDetails(cboCS.Text, cboLot.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub initializeShift()
        With cboShift
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 120
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayPurpose()
        With cboPurpose
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .AddItemTitles("Purpose")
            .AddItem("For Production")
            .AddItem("For Export")
            '.AddItem("Reject Fish")
            .Splits(0).DisplayColumns(0).Width = 200
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayAllBatchlotsDeposited(ByVal cs As String)
        With cboLot
            .Text = ""
            .DataSource = modModule.getBatchlotsDeposited().Tables(0) 'getBatchlotsDeposited(cs).Tables(0)
            'getBatchlotsDeposited().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
            '.Splits(0).DisplayColumns(1).Width = 440
            '.Splits(0).DisplayColumns(2).Width = 118

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboCS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCS.TextChanged
        'If cboCS.Text = "" Then If cboCS.ListCount > 0 Then cboCS.SelectedIndex = 0

        'displayAllBatchlotsDeposited(cboCS.Text)
        'displayFishBinsDepositedDetails(cboCS.Text, cboLot.Text)
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displayFWSCode(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboPurpose.Text)
        displayFishBinsDepositedDetails(cboLot.Text)    'cboCS.Text, 
    End Sub

    Public Sub displayFishBinsDepositedDetails(ByVal lot As String)
        'ByVal cs As String, 
        With cboBin
            '.DataSource = modModule.getFishBinDepositedDetails(cs, lot).Tables(0)
            .DataSource = getFishBinDepositedByLot(lot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200

            displaySummary()
        End With
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text.Trim = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

        displayFWSCode(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboPurpose.Text)
        displaySummary()
    End Sub

    Private Sub cboPurpose_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPurpose.TextChanged
        If cboPurpose.Text.Trim = "" Then If cboPurpose.ListCount > 0 Then cboPurpose.SelectedIndex = 0

        If cboPurpose.Text.StartsWith("For Prod") Then
            cboRemarks.ReadOnly = True
            cboRemarks.Text = "*"
        Else
            cboRemarks.ReadOnly = False
            cboRemarks.Text = ""
        End If

        displaySummary()
    End Sub

    Public Sub getFishBinDepositedDetails(ByVal lot As String, ByVal bin As String)
        'ByVal cs As String, 
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_FishBinDetailsPerLot" ' "proc_display_FishBinDetailsPerColdStorage"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            'Dim p1 As New SqlClient.SqlParameter
            'p1.ParameterName = "@cs"
            'p1.Direction = ParameterDirection.Input
            'p1.SqlDbType = SqlDbType.VarChar
            'p1.Value = cs

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@lot"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = lot

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@bin"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = bin

            'cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblFishSpecie.Text = dr.GetString(1)
                    lblFishSize.Text = dr.GetString(2)
                    lblTW.Text = Format(dr.GetDouble(3), "###,##0")
                    lblNW.Text = Format(dr.GetDouble(4), "###,##0")
                    cboCS.Text = dr.GetString(5)
                Else
                    lblFishSpecie.Text = ""
                    lblFishSize.Text = ""
                    lblTW.Text = "0"
                    lblNW.Text = "0"
                    cboCS.Text = ""
                End If
            Else
                lblFishSpecie.Text = ""
                lblFishSize.Text = ""
                lblTW.Text = "0"
                lblNW.Text = "0"
                cboCS.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        getFishBinDepositedDetails(cboLot.Text, cboBin.Text)    'cboCS.Text, 
    End Sub

    Public Sub displaySummary()
        With grid
            .DataSource = getSummaryCanneryAccepted(txtProdnDate.Value, cboShift.Text, cboPurpose.Text).Tables(0)

            .Columns(3).NumberFormat = "###,###,###,##0.#0"
            .Splits(0).DisplayColumns(0).Width = 150
            .Splits(0).DisplayColumns(1).Width = 170
            .Splits(0).DisplayColumns(2).Width = 150
            .Splits(0).DisplayColumns(3).Width = 150
        End With

        computeTotalAccepted()
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        If Not txtProdnDate.Text = "" Then
            displayFWSCode(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboPurpose.Text)
            displayFishBinsDepositedDetails(cboLot.Text)    'cboCS.Text, 
            displaySummary()
            'computeTotalWeight()
        End If
    End Sub

    Public Sub computeTotalAccepted()
        Dim ctr As Integer
        Dim total As Double
        While ctr < grid.RowCount
            total += grid.Item(ctr, 3)
            ctr += 1
        End While

        lblTotal.Text = Format(total, "###,###,##0.#0")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateRel.Text = getServerDateTime()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        txtProdnDate.SelectAll()
        txtProdnDate.Focus()
    End Sub

    Public Sub addNewRecord()
        lblFWS.Text = ""
        txtProdnDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        cboPurpose.SelectedIndex = 0
        'displayColdStorage()
        cboCS.Text = ""
        displayAllBatchlotsDeposited("%")
        displayFishBinsDepositedDetails(cboLot.Text)    'cboCS.Text, 

        displaySummary()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim f As New frmPrintFishDeposits
        'f.Label13.Text = "Detailed Cannery Acceptance of Fish Lot"
        'f.displayFWS(cboLot.Text)
        'f.ShowDialog(Me)

        ''Dim f As New frmPrintFWS
        ''f.bags = False
        ''f.txtDate.Value = getServerDateTime()
        ''f.initializeShift()

        ''f.txtDate.Value = txtProdnDate.Value
        ''f.cboShift.Text = cboProdnShift.Text
        ''f.cboFWS.Text = lblFWS.Text
        ''f.ShowDialog(Me)

        'cmdNew.Focus()
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String
        If Not txtProdnDate.Text.Trim = "" And Not cboShift.Text.Trim = "" And _
        Not cboPurpose.Text.Trim = "" And Not cboCS.Text.Trim = "" And _
        Not cboLot.Text.Trim = "" And Not cboBin.Text.Trim = "" And _
        Not lblFishSpecie.Text.Trim = "" And Not lblNW.Text.Trim = "" And Not lblNW.Text.Trim = "0" And _
        Not cboRemarks.Text.Trim = "" Then
            If lblFWS.Text.Trim = "" Then
                If validateFishLot(cboLot.Text) Then
                    reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        saveNewFishBinWithdrawals(lblDateRel.Text, "Day", cboLot.Text, _
                            txtProdnDate.Text, cboShift.Text, cboRemarks.Text, cboPurpose.Text)

                        'Dim ctr As Integer
                        'With grid
                        '    While ctr < .RowCount
                        '        If Not .Item(ctr, 7) Is DBNull.Value Then
                        '            If CStr(.Item(ctr, 7)).StartsWith("Yes") Then
                        saveNewFishBinWithdrawalsDetails(lblFWS.Text, cboBin.Text, cboLot.Text, "", "0", "")

                        updateFishBinWithdrawalStatus(cboBin.Text, cboLot.Text, "YES")
                        '            End If
                        '        End If

                        '        ctr += 1
                        '    End While
                        'End With

                        MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")

                        displayFWSCode(txtProdnDate.Text, cboShift.Text, cboLot.Text, cboPurpose.Text)
                        displayFishBinsDepositedDetails(cboLot.Text)        'cboCS.Text, 
                        'lblFWS.Text = ""
                        cboBin.Text = ""
                        cboBin.SelectAll()
                        cboBin.Focus()

                    Else
                        txtProdnDate.SelectAll()
                        txtProdnDate.Focus()
                        Exit Sub
                    End If
                Else
                    MsgBox("Fish lot doesn't found in the database", MsgBoxStyle.Critical, "No record found")
                    cboLot.SelectAll()
                    cboLot.Focus()
                End If
            Else
                reply = MsgBox("Fish Withdrawal Slip No. " & lblFWS.Text & " already stored in the database" & Chr(13) & _
                    "Once you clicked Yes, the bin number and it's details will be added to the existing records.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    saveNewFishBinWithdrawalsDetails(lblFWS.Text, cboBin.Text, cboLot.Text, "", "0", "")
                    updateFishBinWithdrawalStatus(cboBin.Text, cboLot.Text, "YES")

                    MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")

                    displayFishBinsDepositedDetails(cboLot.Text)        'cboCS.Text, 
                    displayFishBinsDepositedDetails(cboLot.Text)        'cboCS.Text, 
                    'lblFWS.Text = ""
                    cboBin.Text = ""
                    cboBin.SelectAll()
                    cboBin.Focus()
                Else
                    cboBin.SelectAll()
                    cboBin.Focus()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Please check your fish deposit details.", MsgBoxStyle.Critical, "Result: Found missing value.")
            txtProdnDate.SelectAll()
            txtProdnDate.Focus()
        End If
    End Sub

    Public Sub saveNewFishBinWithdrawals(ByVal dateTime As String, ByVal shift As String, ByVal lot As String, _
    ByVal prodnDate As String, ByVal prodnShift As String, ByVal relNo As String, ByVal purpose As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FishBinsWithdrawal"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishBinWithdrawalCounter()

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@fwsCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            If prodnShift = "Day" Then
                lblFWS.Text = Format(CDate(prodnDate), "ddMMyy") & "D" & lot & "_" & Format(getFishBinWithdrawalCounter, "0#####")
            Else
                lblFWS.Text = Format(CDate(prodnDate), "ddMMyy") & "N" & lot & "_" & Format(getFishBinWithdrawalCounter, "0#####")
            End If

            p2.Value = lblFWS.Text

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@dateReleased"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.DateTime
            lblDateRel.Text = getServerDateTime()
            dateTime = lblDateRel.Text
            p3.Value = dateTime 'Format(CDate(dateTime), getTimeFormat())

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@shift"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = shift

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

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@prodnDate"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.DateTime
            p5.Value = Format(CDate(prodnDate), getTimeFormat())

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@prodnShift"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = prodnShift

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@relNo"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.VarChar
            p7.Value = relNo

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@purpose"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.VarChar
            p8.Value = purpose

            Dim p9 As New SqlClient.SqlParameter
            p9.ParameterName = "@prodnTime"
            p9.Direction = ParameterDirection.Input
            p9.SqlDbType = SqlDbType.DateTime
            p9.Value = Format(CDate(prodnDate), "dd/MM/yyyy hh:mm:ss tt")

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)
            cmd.Parameters.Add(p9)

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

    Private Sub txtProdnDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdnDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPurpose.SelectAll()
            cboPurpose.Focus()
        End If
    End Sub

    Private Sub cboPurpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPurpose.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Private Sub cboCS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCS.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboBin.SelectAll()
            cboBin.Focus()
        End If
    End Sub

    Private Sub cboBin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBin.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave.Focus()
        End If
    End Sub

    Public Sub displayFWSCode(ByVal prodnDate As String, ByVal shift As String, ByVal lot As String, ByVal purpose As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getFWSCode_ByProdnDate"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@prodnDate"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            If prodnDate = "" Then
                p1.Value = Format(getServerDateTime, getTimeFormat())
            Else
                p1.Value = Format(CDate(prodnDate), getTimeFormat())
            End If

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@shift"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = shift

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@lot"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = lot

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@purpose"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = purpose

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblFWS.Text = dr.GetString(0)
                Else
                    lblFWS.Text = ""
                End If
            Else
                lblFWS.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboRemarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRemarks.TextChanged
        lblFWS.Text = ""
    End Sub
End Class
