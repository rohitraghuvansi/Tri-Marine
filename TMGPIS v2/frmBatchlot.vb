Public Class frmBatchlot
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblDateArrive As System.Windows.Forms.Label
    Friend WithEvents lblDateDepart As System.Windows.Forms.Label
    Friend WithEvents lblMethod As System.Windows.Forms.Label
    Friend WithEvents lblFAO As System.Windows.Forms.Label
    Friend WithEvents lblOcean As System.Windows.Forms.Label
    Friend WithEvents lblVessel As System.Windows.Forms.Label
    Friend WithEvents cboClassification As C1.Win.C1List.C1Combo
    Friend WithEvents cboFishType As C1.Win.C1List.C1Combo
    Friend WithEvents txtDateUnload As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkWo As System.Windows.Forms.CheckBox
    Friend WithEvents cboCC As C1.Win.C1List.C1Combo
    Friend WithEvents cboSupplier As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuMSupplier As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMCC As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBatchlot))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblDateArrive = New System.Windows.Forms.Label()
        Me.lblDateDepart = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblFAO = New System.Windows.Forms.Label()
        Me.lblOcean = New System.Windows.Forms.Label()
        Me.lblVessel = New System.Windows.Forms.Label()
        Me.cboClassification = New C1.Win.C1List.C1Combo()
        Me.cboFishType = New C1.Win.C1List.C1Combo()
        Me.txtDateUnload = New C1.Win.C1Input.C1DateEdit()
        Me.chkWo = New System.Windows.Forms.CheckBox()
        Me.cboCC = New C1.Win.C1List.C1Combo()
        Me.cboSupplier = New C1.Win.C1List.C1Combo()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmd = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuMSupplier = New System.Windows.Forms.MenuItem()
        Me.mnuMCC = New System.Windows.Forms.MenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.cboClassification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFishType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateUnload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1})
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(740, 312)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label20, Me.lblDateArrive, Me.lblDateDepart, Me.lblMethod, Me.lblFAO, Me.lblOcean, Me.lblVessel, Me.cboClassification, Me.cboFishType, Me.txtDateUnload, Me.chkWo, Me.cboCC, Me.cboSupplier, Me.cboLot, Me.Label21, Me.Label22, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label4, Me.Label3, Me.Label2, Me.Label6, Me.Label5, Me.Label19})
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(732, 283)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fish Lot Information"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 143)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(146, 16)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Catch Certificate Details"
        '
        'lblDateArrive
        '
        Me.lblDateArrive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateArrive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateArrive.Location = New System.Drawing.Point(536, 232)
        Me.lblDateArrive.Name = "lblDateArrive"
        Me.lblDateArrive.Size = New System.Drawing.Size(176, 27)
        Me.lblDateArrive.TabIndex = 44
        '
        'lblDateDepart
        '
        Me.lblDateDepart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateDepart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateDepart.Location = New System.Drawing.Point(536, 200)
        Me.lblDateDepart.Name = "lblDateDepart"
        Me.lblDateDepart.Size = New System.Drawing.Size(176, 27)
        Me.lblDateDepart.TabIndex = 43
        '
        'lblMethod
        '
        Me.lblMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMethod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethod.Location = New System.Drawing.Point(536, 168)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(176, 27)
        Me.lblMethod.TabIndex = 42
        '
        'lblFAO
        '
        Me.lblFAO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFAO.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFAO.Location = New System.Drawing.Point(136, 232)
        Me.lblFAO.Name = "lblFAO"
        Me.lblFAO.Size = New System.Drawing.Size(168, 27)
        Me.lblFAO.TabIndex = 41
        '
        'lblOcean
        '
        Me.lblOcean.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOcean.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcean.Location = New System.Drawing.Point(136, 200)
        Me.lblOcean.Name = "lblOcean"
        Me.lblOcean.Size = New System.Drawing.Size(168, 27)
        Me.lblOcean.TabIndex = 40
        '
        'lblVessel
        '
        Me.lblVessel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVessel.Location = New System.Drawing.Point(136, 168)
        Me.lblVessel.Name = "lblVessel"
        Me.lblVessel.Size = New System.Drawing.Size(168, 27)
        Me.lblVessel.TabIndex = 39
        '
        'cboClassification
        '
        Me.cboClassification.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboClassification.AllowColMove = False
        Me.cboClassification.AutoCompletion = True
        Me.cboClassification.AutoDropDown = True
        Me.cboClassification.Caption = ""
        Me.cboClassification.CaptionHeight = 17
        Me.cboClassification.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboClassification.ColumnCaptionHeight = 17
        Me.cboClassification.ColumnFooterHeight = 17
        Me.cboClassification.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboClassification.ContentHeight = 18
        Me.cboClassification.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboClassification.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboClassification.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClassification.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboClassification.EditorHeight = 18
        Me.cboClassification.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboClassification.ItemHeight = 20
        Me.cboClassification.Location = New System.Drawing.Point(544, 72)
        Me.cboClassification.MatchEntryTimeout = CType(2000, Long)
        Me.cboClassification.MaxDropDownItems = CType(20, Short)
        Me.cboClassification.MaxLength = 32767
        Me.cboClassification.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboClassification.Name = "cboClassification"
        Me.cboClassification.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboClassification.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboClassification.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboClassification.Size = New System.Drawing.Size(176, 24)
        Me.cboClassification.TabIndex = 38
        Me.cboClassification.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboFishType
        '
        Me.cboFishType.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboFishType.AllowColMove = False
        Me.cboFishType.AutoCompletion = True
        Me.cboFishType.AutoDropDown = True
        Me.cboFishType.Caption = ""
        Me.cboFishType.CaptionHeight = 17
        Me.cboFishType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFishType.ColumnCaptionHeight = 17
        Me.cboFishType.ColumnFooterHeight = 17
        Me.cboFishType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboFishType.ContentHeight = 18
        Me.cboFishType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboFishType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboFishType.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFishType.EditorHeight = 18
        Me.cboFishType.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.cboFishType.ItemHeight = 20
        Me.cboFishType.Location = New System.Drawing.Point(544, 40)
        Me.cboFishType.MatchEntryTimeout = CType(2000, Long)
        Me.cboFishType.MaxDropDownItems = CType(20, Short)
        Me.cboFishType.MaxLength = 32767
        Me.cboFishType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboFishType.Name = "cboFishType"
        Me.cboFishType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFishType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboFishType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFishType.Size = New System.Drawing.Size(176, 24)
        Me.cboFishType.TabIndex = 37
        Me.cboFishType.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtDateUnload
        '
        Me.txtDateUnload.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateUnload.Location = New System.Drawing.Point(544, 8)
        Me.txtDateUnload.Name = "txtDateUnload"
        Me.txtDateUnload.Size = New System.Drawing.Size(120, 23)
        Me.txtDateUnload.TabIndex = 36
        Me.txtDateUnload.Tag = Nothing
        Me.txtDateUnload.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkWo
        '
        Me.chkWo.Location = New System.Drawing.Point(136, 96)
        Me.chkWo.Name = "chkWo"
        Me.chkWo.Size = New System.Drawing.Size(208, 40)
        Me.chkWo.TabIndex = 35
        Me.chkWo.Text = "&Without CC Document"
        '
        'cboCC
        '
        Me.cboCC.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCC.AllowColMove = False
        Me.cboCC.AutoCompletion = True
        Me.cboCC.AutoDropDown = True
        Me.cboCC.Caption = ""
        Me.cboCC.CaptionHeight = 17
        Me.cboCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCC.ColumnCaptionHeight = 17
        Me.cboCC.ColumnFooterHeight = 17
        Me.cboCC.ContentHeight = 18
        Me.cboCC.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCC.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCC.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCC.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCC.EditorHeight = 18
        Me.cboCC.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.cboCC.ItemHeight = 20
        Me.cboCC.Location = New System.Drawing.Point(136, 72)
        Me.cboCC.MatchEntryTimeout = CType(2000, Long)
        Me.cboCC.MaxDropDownItems = CType(5, Short)
        Me.cboCC.MaxLength = 32767
        Me.cboCC.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCC.Name = "cboCC"
        Me.cboCC.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCC.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCC.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCC.Size = New System.Drawing.Size(168, 24)
        Me.cboCC.TabIndex = 34
        Me.cboCC.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboSupplier
        '
        Me.cboSupplier.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSupplier.AllowColMove = False
        Me.cboSupplier.AutoCompletion = True
        Me.cboSupplier.AutoDropDown = True
        Me.cboSupplier.Caption = ""
        Me.cboSupplier.CaptionHeight = 17
        Me.cboSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSupplier.ColumnCaptionHeight = 17
        Me.cboSupplier.ColumnFooterHeight = 17
        Me.cboSupplier.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboSupplier.ContentHeight = 18
        Me.cboSupplier.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSupplier.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSupplier.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSupplier.EditorHeight = 18
        Me.cboSupplier.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.cboSupplier.ItemHeight = 20
        Me.cboSupplier.Location = New System.Drawing.Point(136, 40)
        Me.cboSupplier.MatchEntryTimeout = CType(2000, Long)
        Me.cboSupplier.MaxDropDownItems = CType(20, Short)
        Me.cboSupplier.MaxLength = 32767
        Me.cboSupplier.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSupplier.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSupplier.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSupplier.Size = New System.Drawing.Size(256, 24)
        Me.cboSupplier.TabIndex = 33
        Me.cboSupplier.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboLot.Images.Add(CType(resources.GetObject("resource.Images4"), System.Drawing.Bitmap))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(136, 8)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(5, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(168, 24)
        Me.cboLot.TabIndex = 32
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
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(424, 237)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 16)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Date Arrived"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(424, 205)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Date Departure"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(424, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Fishing Method"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(424, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Fish Classification"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(424, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fish Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(424, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Date Unloaded"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "FAO Fishing#"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Catch Certificate#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Lot Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Ocean of Capture"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fishing Vessel"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(712, 136)
        Me.Label19.TabIndex = 45
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Bitmap)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(180, 368)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 1
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Bitmap)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(260, 368)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(340, 368)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 3
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(420, 368)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(500, 368)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(754, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fish Lot Information"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMSupplier, Me.mnuMCC})
        '
        'mnuMSupplier
        '
        Me.mnuMSupplier.Index = 0
        Me.mnuMSupplier.Text = "&Supplier"
        '
        'mnuMCC
        '
        Me.mnuMCC.Index = 1
        Me.mnuMCC.Text = "&Catch Certificate"
        '
        'frmBatchlot
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(754, 423)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdEdit, Me.cmd, Me.TabControl1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmBatchlot"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBatchlot"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.cboClassification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFishType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateUnload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmBatchlot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDateUnload.Value = getServerDateTime()
        dataEntry(1)

        'displayAllFishLots()
        displayFishLots()
        displayUnallocatedCC()
        displaySupplier()
        displayFishType()
        displayFishClassification()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayUnallocatedCC()
        With cboCC
            .DataSource = modModule.getUnallocatedCC().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 150
        End With
    End Sub

    Public Sub displayFishLots()
        With cboLot
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 145
        End With
    End Sub

    Public Sub displaySupplier()
        With cboSupplier
            .DataSource = modModule.getSupplier().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 235
        End With
    End Sub

    Public Sub displayFishType()
        With cboFishType
            .DataSource = modModule.getFishType().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
        End With
    End Sub

    Public Sub displayFishClassification()
        With cboClassification
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Classification")
            .AddItem("Lower Quality")
            .AddItem("Normal Quality")
            .Splits(0).DisplayColumns(0).Width = 155
        End With
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
                Me.TabControl1.TabPages(0).Enabled = True
            Case 1
                Me.TabControl1.TabPages(0).Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        displayUnallocatedCC()
        cboLot.ReadOnly = False
        displayFishLots()
        cboLot.Text = ""
        displaySupplier()
        cboSupplier.SelectedIndex = 0
        cboCC.ReadOnly = False
        cboCC.Text = ""
        displayUnallocatedCC()
        txtDateUnload.Value = getServerDateTime()
        displayFishType()
        cboFishType.SelectedIndex = 0
        cboClassification.SelectedIndex = 0
        'displayAllFishLots()
    End Sub

    Private Sub cboCC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCC.TextChanged
        displayCCDetails(cboCC.Text)
    End Sub

    Private Sub cboSupplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSupplier.TextChanged
        If cboSupplier.Text = "" Then
            If cboSupplier.ListCount > 0 Then cboSupplier.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboFishType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFishType.TextChanged
        If cboFishType.Text = "" Then
            If cboFishType.ListCount > 0 Then cboFishType.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboClassification_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClassification.TextChanged
        If cboClassification.Text = "" Then
            If cboClassification.ListCount > 0 Then cboClassification.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                Me.TabControl1.SelectedIndex = 0
                buttons(0)
                dataEntry(0)
                addNewRecord()
                cboLot.SelectAll()
                cboLot.Focus()
            Case "&Save"
                If chkWo.Checked = True Then
                    If validateDataEntry(False) Then
                        GoTo proceedToSaveTheRecord
                    Else
                        GoTo errorOnValidationOfDataEntry
                    End If
                Else
                    If validateDataEntry(True) Then
                        If Not validateAllocatedCC(cboCC.Text) Then
                            GoTo proceedToSaveTheRecord
                        Else
                            GoTo errorOnValidationOfDataEntry
                        End If
                    Else
                        GoTo errorOnValidationOfDataEntry
                    End If
                End If

                Exit Sub

proceedToSaveTheRecord:
                'If Not cboLot.Text.Trim = "" And Not cboSupplier.Text.Trim = "" And Not cboFishType.Text.Trim = "" And Not cboClassification.Text.Trim = "" And Not cboCC.Text.Trim = "" Then
                If Not validateFishLot(cboLot.Text) Then
                    reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        saveNewFishLot(cboLot.Text, cboSupplier.Text, cboClassification.Text, cboCC.Text, cboFishType.Text, txtDateUnload.Text, 0, 0)
                        cmd.Text = "&Add"
                        cmdEdit.Text = "&Edit"
                        buttons(1)
                        dataEntry(1)

                        'displayAllFishLots()
                        MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                        cmd.Focus()
                    End If
                Else
                    MsgBox("Fishlots already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                    cboLot.SelectAll()
                    cboLot.Focus()
                End If

                Exit Sub

errorOnValidationOfDataEntry:
                MsgBox("Kindly fill out important field(s) and make sure you have properly checked the data.", MsgBoxStyle.Critical, "Result: Found missing value.")
                cboLot.SelectAll()
                cboLot.Focus()

                Exit Sub

            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFishLot(cboLot.Text, cboSupplier.Text, cboClassification.Text, cboCC.Text, cboFishType.Text, txtDateUnload.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)

                    'displayAllFishLots()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Private Sub chkWo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWo.CheckedChanged
        If chkWo.Checked = True Then
            cboCC.Text = ""
            cboCC.ReadOnly = True
        Else
            cboCC.ReadOnly = False
            cboCC.SelectAll()
            cboCC.Focus()
        End If
    End Sub

    Public Function validateDataEntry(ByVal withCC As Boolean) As Boolean
        Select Case withCC
            Case True
                If Not cboLot.Text.Trim = "" And Not cboSupplier.Text.Trim = "" And Not cboFishType.Text.Trim = "" And Not cboClassification.Text.Trim = "" And Not cboCC.Text.Trim = "" And Not lblVessel.Text.Trim = "" Then
                    Return True
                Else
                    Return False
                End If
            Case False
                If Not cboLot.Text.Trim = "" And Not cboSupplier.Text.Trim = "" And Not cboFishType.Text.Trim = "" And Not cboClassification.Text.Trim = "" Then
                    Return True
                Else
                    Return False
                End If
        End Select
    End Function

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboLot.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboLot.ReadOnly = True
                    cboSupplier.SelectAll()
                    cboSupplier.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboSupplier.SelectAll()
                    cboSupplier.Focus()
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

    Public Sub displayCCDetails(ByVal cc As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_display_CCDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@cc"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = cc

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblVessel.Text = dr.GetString(1)
                    lblOcean.Text = dr.GetString(2)
                    lblFAO.Text = dr.GetString(3)
                    lblMethod.Text = dr.GetString(4)
                    lblDateDepart.Text = dr.GetDateTime(5)
                    lblDateArrive.Text = dr.GetDateTime(6)
                Else
                    lblVessel.Text = ""
                    lblOcean.Text = ""
                    lblFAO.Text = ""
                    lblMethod.Text = ""
                    lblDateDepart.Text = ""
                    lblDateArrive.Text = ""
                End If
            Else
                lblVessel.Text = ""
                lblOcean.Text = ""
                lblFAO.Text = ""
                lblMethod.Text = ""
                lblDateDepart.Text = ""
                lblDateArrive.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            'MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Public Sub displayBatchlotDetails(ByVal lot As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_display_BatchlotDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@lot"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = lot

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            displayUnallocatedCC()
            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    cboSupplier.Text = dr.GetString(0)
                    If CStr(dr.GetString(1)) = "" Then
                        chkWo.Checked = True
                    Else
                        chkWo.Checked = False
                    End If

                    cboCC.Text = dr.GetString(1)
                    txtDateUnload.Value = dr.GetDateTime(2)
                    cboFishType.Text = dr.GetString(3)
                    cboClassification.Text = dr.GetString(4)
                Else
                    cboSupplier.SelectedIndex = 0
                    cboCC.Text = ""
                    chkWo.Checked = False
                    txtDateUnload.Value = getServerDateTime()
                    cboFishType.SelectedIndex = 0
                    cboClassification.SelectedIndex = 0
                End If
            Else
                cboSupplier.SelectedIndex = 0
                cboCC.Text = ""
                chkWo.Checked = False
                txtDateUnload.Value = getServerDateTime()
                cboFishType.SelectedIndex = 0
                cboClassification.SelectedIndex = 0
            End If

            dr.Close()
            c.Close()

            cboLot.Focus()
        Catch e As Exception
            'MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displayBatchlotDetails(cboLot.Text)
    End Sub

    Private Sub mnuMSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMSupplier.Click
        Dim f As New frmFishSupplier()
        f.ShowDialog(Me)

        displaySupplier()
        cboSupplier.SelectAll()
        cboSupplier.Focus()
    End Sub

    Private Sub mnuMCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMCC.Click
        Dim f As New frmSICC()
        f.ShowDialog(Me)

        displayUnallocatedCC()
        cboCC.SelectAll()
        cboCC.Focus()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Fish Lot Number"
        f.searchType = 2
        f.displayAllFishLots()
        f.ShowDialog(Me)

        If Not f.cancel Then
            cboLot.Text = f.searchItem
        End If
        'displayRecord(f.searchItem)
    End Sub
End Class
