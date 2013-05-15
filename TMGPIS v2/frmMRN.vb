Public Class frmMRN
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
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As C1.Win.C1List.C1Combo
    Friend WithEvents cboMaterials As C1.Win.C1List.C1Combo
    Friend WithEvents cboManufacturer As C1.Win.C1List.C1Combo
    Friend WithEvents cboSupplier As C1.Win.C1List.C1Combo
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtInvoice As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtGRN As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuMaterials As System.Windows.Forms.MenuItem
    Friend WithEvents mnuManufacturer As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSupplier As System.Windows.Forms.MenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtFreight As System.Windows.Forms.TextBox
    Friend WithEvents txtConversion As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMRN))
        Me.cboCategory = New C1.Win.C1List.C1Combo
        Me.cboMaterials = New C1.Win.C1List.C1Combo
        Me.cboManufacturer = New C1.Win.C1List.C1Combo
        Me.cboSupplier = New C1.Win.C1List.C1Combo
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmd = New System.Windows.Forms.Button
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.lblCode = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtInvoice = New C1.Win.C1Input.C1DateEdit
        Me.txtGRN = New C1.Win.C1Input.C1DateEdit
        Me.lblID = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuMaterials = New System.Windows.Forms.MenuItem
        Me.mnuManufacturer = New System.Windows.Forms.MenuItem
        Me.mnuSupplier = New System.Windows.Forms.MenuItem
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtFreight = New System.Windows.Forms.TextBox
        Me.txtConversion = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboManufacturer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGRN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCategory
        '
        Me.cboCategory.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCategory.AllowColMove = False
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
        Me.cboCategory.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboCategory.ItemHeight = 20
        Me.cboCategory.Location = New System.Drawing.Point(96, 86)
        Me.cboCategory.MatchEntryTimeout = CType(2000, Long)
        Me.cboCategory.MaxDropDownItems = CType(10, Short)
        Me.cboCategory.MaxLength = 32767
        Me.cboCategory.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCategory.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategory.Size = New System.Drawing.Size(192, 24)
        Me.cboCategory.TabIndex = 0
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboMaterials
        '
        Me.cboMaterials.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboMaterials.AllowColMove = False
        Me.cboMaterials.AutoCompletion = True
        Me.cboMaterials.AutoDropDown = True
        Me.cboMaterials.Caption = ""
        Me.cboMaterials.CaptionHeight = 17
        Me.cboMaterials.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMaterials.ColumnCaptionHeight = 17
        Me.cboMaterials.ColumnFooterHeight = 17
        Me.cboMaterials.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboMaterials.ContentHeight = 18
        Me.cboMaterials.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboMaterials.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboMaterials.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterials.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMaterials.EditorHeight = 18
        Me.cboMaterials.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterials.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboMaterials.ItemHeight = 20
        Me.cboMaterials.Location = New System.Drawing.Point(96, 117)
        Me.cboMaterials.MatchEntryTimeout = CType(2000, Long)
        Me.cboMaterials.MaxDropDownItems = CType(10, Short)
        Me.cboMaterials.MaxLength = 32767
        Me.cboMaterials.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMaterials.Name = "cboMaterials"
        Me.cboMaterials.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMaterials.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMaterials.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMaterials.Size = New System.Drawing.Size(400, 24)
        Me.cboMaterials.TabIndex = 1
        Me.cboMaterials.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboManufacturer
        '
        Me.cboManufacturer.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboManufacturer.AllowColMove = False
        Me.cboManufacturer.AutoCompletion = True
        Me.cboManufacturer.AutoDropDown = True
        Me.cboManufacturer.Caption = ""
        Me.cboManufacturer.CaptionHeight = 17
        Me.cboManufacturer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboManufacturer.ColumnCaptionHeight = 17
        Me.cboManufacturer.ColumnFooterHeight = 17
        Me.cboManufacturer.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboManufacturer.ContentHeight = 18
        Me.cboManufacturer.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboManufacturer.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboManufacturer.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboManufacturer.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboManufacturer.EditorHeight = 18
        Me.cboManufacturer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboManufacturer.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboManufacturer.ItemHeight = 20
        Me.cboManufacturer.Location = New System.Drawing.Point(96, 149)
        Me.cboManufacturer.MatchEntryTimeout = CType(2000, Long)
        Me.cboManufacturer.MaxDropDownItems = CType(10, Short)
        Me.cboManufacturer.MaxLength = 32767
        Me.cboManufacturer.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboManufacturer.Name = "cboManufacturer"
        Me.cboManufacturer.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboManufacturer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboManufacturer.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboManufacturer.Size = New System.Drawing.Size(400, 24)
        Me.cboManufacturer.TabIndex = 2
        Me.cboManufacturer.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboSupplier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboSupplier.ItemHeight = 20
        Me.cboSupplier.Location = New System.Drawing.Point(96, 181)
        Me.cboSupplier.MatchEntryTimeout = CType(2000, Long)
        Me.cboSupplier.MaxDropDownItems = CType(10, Short)
        Me.cboSupplier.MaxLength = 32767
        Me.cboSupplier.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSupplier.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSupplier.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSupplier.Size = New System.Drawing.Size(400, 24)
        Me.cboSupplier.TabIndex = 3
        Me.cboSupplier.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(96, 278)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(136, 23)
        Me.txtYear.TabIndex = 6
        Me.txtYear.Text = "2011"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(517, 529)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(437, 529)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 17
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(357, 529)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 16
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(277, 529)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 15
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(197, 529)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 14
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 336)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(771, 184)
        Me.grid.TabIndex = 19
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "arqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>180</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 767, 180</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 767, 180</ClientArea><PrintPageHeaderStyle parent" & _
        "="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(96, 54)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(400, 24)
        Me.lblCode.TabIndex = 62
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 19)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "MRN Number"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(788, 40)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Material Reference Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Manufacturer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Materials"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "GRN Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Invoice Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 19)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 19)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Supplier"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 19)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Table View"
        '
        'txtInvoice
        '
        Me.txtInvoice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoice.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtInvoice.Location = New System.Drawing.Point(96, 214)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(136, 23)
        Me.txtInvoice.TabIndex = 4
        Me.txtInvoice.Tag = Nothing
        Me.txtInvoice.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtGRN
        '
        Me.txtGRN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGRN.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtGRN.Location = New System.Drawing.Point(96, 246)
        Me.txtGRN.Name = "txtGRN"
        Me.txtGRN.Size = New System.Drawing.Size(136, 23)
        Me.txtGRN.TabIndex = 5
        Me.txtGRN.Tag = Nothing
        Me.txtGRN.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(584, 48)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(192, 24)
        Me.lblID.TabIndex = 72
        Me.lblID.Text = "0"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblID.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(560, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 19)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Quantity"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(640, 150)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(136, 23)
        Me.txtQty.TabIndex = 9
        Me.txtQty.Text = "0"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(560, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 19)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Unit"
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(640, 182)
        Me.txtUnit.MaxLength = 5
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(136, 23)
        Me.txtUnit.TabIndex = 10
        Me.txtUnit.Text = ""
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMaterials, Me.mnuManufacturer, Me.mnuSupplier})
        '
        'mnuMaterials
        '
        Me.mnuMaterials.Index = 0
        Me.mnuMaterials.Text = "&Materials"
        '
        'mnuManufacturer
        '
        Me.mnuManufacturer.Index = 1
        Me.mnuManufacturer.Text = "Manu&facturer"
        '
        'mnuSupplier
        '
        Me.mnuSupplier.Index = 2
        Me.mnuSupplier.Text = "Su&pplier"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(560, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 19)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Amount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(560, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 19)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Freight"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(640, 214)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtAmount.TabIndex = 11
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFreight
        '
        Me.txtFreight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFreight.Location = New System.Drawing.Point(640, 246)
        Me.txtFreight.Name = "txtFreight"
        Me.txtFreight.Size = New System.Drawing.Size(136, 23)
        Me.txtFreight.TabIndex = 12
        Me.txtFreight.Text = "0"
        Me.txtFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConversion
        '
        Me.txtConversion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConversion.Location = New System.Drawing.Point(640, 278)
        Me.txtConversion.Name = "txtConversion"
        Me.txtConversion.Size = New System.Drawing.Size(136, 23)
        Me.txtConversion.TabIndex = 13
        Me.txtConversion.Text = "0"
        Me.txtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(560, 280)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 19)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Conversion"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(640, 118)
        Me.txtInvoiceNo.MaxLength = 50
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(136, 23)
        Me.txtInvoiceNo.TabIndex = 8
        Me.txtInvoiceNo.Text = ""
        '
        'txtPO
        '
        Me.txtPO.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO.Location = New System.Drawing.Point(640, 87)
        Me.txtPO.MaxLength = 50
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(136, 23)
        Me.txtPO.TabIndex = 7
        Me.txtPO.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(560, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 19)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Invoice No."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(560, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 19)
        Me.Label17.TabIndex = 85
        Me.Label17.Text = "PO No."
        '
        'frmMRN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(788, 583)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtConversion)
        Me.Controls.Add(Me.txtFreight)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtGRN)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cboSupplier)
        Me.Controls.Add(Me.cboManufacturer)
        Me.Controls.Add(Me.cboMaterials)
        Me.Controls.Add(Me.cboCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMRN"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMRN"
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboManufacturer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGRN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMRN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        dataentry(1)
        txtInvoice.Value = getServerDateTime()
        txtGRN.Value = getServerDateTime()
        txtYear.Text = Format(getServerDateTime, "yyyy")
        'txtInvoice.Text = CDate(getServerDateTime()).DayOfYear
        'txtGRN.Text = CDate(getServerDateTime()).DayOfYear

        displayCategory()
        displayMRN(cboCategory.Text)
        displayMaterials(cboCategory.Text)
        displayManufacturer()
        displaySupplier()
    End Sub

    Public Sub displayMRN(ByVal category As String)
        With grid
            .DataSource = modModule.getAllMRN(category).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 130
            .Splits(0).DisplayColumns(1).Width = 100
            .Splits(0).DisplayColumns(2).Width = 180
            .Splits(0).DisplayColumns(3).Width = 180
            .Splits(0).DisplayColumns(4).Width = 180
            .Columns(8).NumberFormat = "###,###,##0.#0"
            .Columns(10).NumberFormat = "###,###,##0.#0"
            .Columns(11).NumberFormat = "###,###,##0.#0"
            .Columns(12).NumberFormat = "###,###,##0.#0"
        End With
    End Sub

    Public Sub displayCategory()
        With cboCategory
            .DefColWidth = 170
            .DataSource = getMRN_MaterialsCategory().Tables(0)
        End With
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cboCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.TextChanged
        If cboCategory.Text = "" Then If cboCategory.ListCount > 0 Then cboCategory.SelectedIndex = 0

        displayMaterials(cboCategory.Text)
        displayMRN(cboCategory.Text)
    End Sub

    Public Sub displayMaterials(ByVal category As String)
        With cboMaterials
            .DefColWidth = 377
            .DataSource = getMRN_MaterialsCategory(category).Tables(0)
        End With
    End Sub

    Public Sub displayManufacturer()
        With cboManufacturer
            .DefColWidth = 377
            .DataSource = getMRN_ManufacturerDescription().Tables(0)
        End With
    End Sub

    Public Sub displaySupplier()
        With cboSupplier
            .DefColWidth = 377
            .DataSource = getMRN_SupplierDescription().Tables(0)
        End With
    End Sub

    'Private Sub txtInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvoice.TextChanged
    '    If Not IsNumeric(txtInvoice.Text) Or txtInvoice.Text = "" Then
    '        txtInvoice.Text = "0"
    '        txtInvoice.SelectAll()
    '        txtInvoice.Focus()
    '    End If

    '    If CDbl(txtInvoice.Text) > 366 Or CDbl(txtInvoice.Text) < 1 Then
    '        MsgBox("Equivalent Julian Date number for Invoice date is invalid" & Chr(13) & _
    '            "You can only have values between 1 to 365 or 366 for leap year", MsgBoxStyle.Exclamation, "Warning")
    '        txtInvoice.Text = CDate(getServerDateTime()).DayOfYear
    '        txtInvoice.SelectAll()
    '        txtInvoice.Focus()
    '    End If
    'End Sub

    'Private Sub txtGRN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGRN.TextChanged
    '    If Not IsNumeric(txtGRN.Text) Or txtGRN.Text = "" Then
    '        txtGRN.Text = "0"
    '        txtGRN.SelectAll()
    '        txtGRN.Focus()
    '    End If

    '    If CDbl(txtGRN.Text) > 366 Or CDbl(txtGRN.Text) < 1 Then
    '        MsgBox("Equivalent Julian Date number for Soltai GRN date is invalid" & Chr(13) & _
    '            "You can only have values between 1 to 365 or 366 for leap year", MsgBoxStyle.Exclamation, "Warning")
    '        txtGRN.Text = CDate(getServerDateTime()).DayOfYear
    '        txtGRN.SelectAll()
    '        txtGRN.Focus()
    '    End If
    'End Sub

    Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged
        If Not IsNumeric(txtYear.Text) Or txtYear.Text = "" Then
            txtYear.Text = Format(getServerDateTime, "yy")
            txtYear.SelectAll()
            txtYear.Focus()
        End If

        showMRNCode()
    End Sub

    Public Sub showMRNCode()
        Dim invoice As String
        Dim grn As String
        Dim yr As String

        If txtInvoice.Text = "" Then
            invoice = Format(getServerDateTime, getTimeFormat())
        Else
            invoice = txtInvoice.Value
        End If

        If txtGRN.Text = "" Then
            grn = Format(getServerDateTime, getTimeFormat())
        Else
            grn = txtGRN.Value
        End If

        If txtYear.Text.Length = 4 Then
            yr = txtYear.Text.Substring(2, 2)
        Else
            yr = Format(getServerDateTime, "yy")
        End If

        If cboMaterials.Text.Trim = "" Or cboManufacturer.Text.Trim = "" Or cboSupplier.Text.Trim = "" Or _
            yr.Trim = "" Then
            lblCode.Text = ""
        Else
            lblCode.Text = getMRN_MaterialsCode(cboMaterials.Text) & _
                getMRN_SupplierCode(cboSupplier.Text) & _
                CStr(CDate(invoice).Year).Substring(3, 1) & _
                Format(CDate(invoice).DayOfYear, "00#")
            'getMRN_ManufacturerCode(cboManufacturer.Text) & _
        End If
    End Sub

    Private Sub cboMaterials_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMaterials.TextChanged
        showMRNCode()
    End Sub

    Private Sub cboManufacturer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboManufacturer.TextChanged
        showMRNCode()
    End Sub

    Private Sub cboSupplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSupplier.TextChanged
        showMRNCode()
    End Sub

    Private Sub txtInvoice_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoice.ValueChanged
        showMRNCode()
    End Sub

    Private Sub txtGRN_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGRN.ValueChanged
        showMRNCode()
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
                cboCategory.ReadOnly = False
                cboMaterials.ReadOnly = False
                cboManufacturer.ReadOnly = False
                cboSupplier.ReadOnly = False
                txtInvoice.ReadOnly = False
                txtGRN.ReadOnly = False
                txtYear.ReadOnly = False
                txtPO.ReadOnly = False
                txtInvoiceNo.ReadOnly = False
                txtQty.ReadOnly = False
                txtUnit.ReadOnly = False
                txtAmount.ReadOnly = False
                txtFreight.ReadOnly = False
                txtConversion.ReadOnly = False
                grid.Enabled = True
            Case 1
                cboCategory.ReadOnly = True
                cboMaterials.ReadOnly = True
                cboManufacturer.ReadOnly = True
                cboSupplier.ReadOnly = True
                txtInvoice.ReadOnly = True
                txtGRN.ReadOnly = True
                txtYear.ReadOnly = True
                txtPO.ReadOnly = True
                txtInvoiceNo.ReadOnly = True
                txtQty.ReadOnly = True
                txtUnit.ReadOnly = True
                txtAmount.ReadOnly = True
                txtFreight.ReadOnly = True
                txtConversion.ReadOnly = True
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        lblID.Text = ""
        lblCode.Text = ""
        cboCategory.Text = ""
        displayCategory()
        cboMaterials.Text = ""
        displayMaterials(cboCategory.Text)
        cboManufacturer.Text = ""
        displayManufacturer()
        cboSupplier.Text = ""
        displaySupplier()
        txtInvoice.Value = getServerDateTime()
        txtGRN.Value = getServerDateTime()
        txtYear.Text = Format(getServerDateTime, "yyyy")
        txtQty.Text = "0"
        txtUnit.Text = ""
        txtAmount.Text = "0"
        txtFreight.Text = "0"
        txtConversion.Text = "0"
        txtPO.Text = ""
        txtInvoiceNo.Text = ""

        displayMRN(cboCategory.Text)
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
                cboCategory.SelectAll()
                cboCategory.Focus()
            Case "&Save"
                If Not lblCode.Text.Trim = "" And Not cboCategory.Text.Trim = "" And _
                Not cboMaterials.Text.Trim = "" And Not cboManufacturer.Text.Trim = "" And _
                Not cboSupplier.Text.Trim = "" And Not txtYear.Text.Trim = "0" And _
                Not txtQty.Text.Trim = "0" And Not txtQty.Text.Trim = "" And _
                Not txtAmount.Text.Trim = "0" And Not txtAmount.Text.Trim = "" And _
                Not txtFreight.Text.Trim = "" And Not txtConversion.Text.Trim = "" Then
                    If Not validateMRN(lblCode.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewMRN(lblCode.Text, cboMaterials.Text, cboManufacturer.Text, cboSupplier.Text, _
                                txtInvoice.Text, txtGRN.Text, txtYear.Text, txtQty.Text, txtUnit.Text, _
                                txtAmount.Text, txtFreight.Text, txtConversion.Text, txtPO.Text, txtInvoiceNo.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            displayMRN(cboCategory.Text)
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("MRN No. already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCategory.SelectAll()
                        cboCategory.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCategory.SelectAll()
                    cboCategory.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateMRN(lblCode.Text, cboMaterials.Text, cboManufacturer.Text, _
                        cboSupplier.Text, txtInvoice.Text, txtGRN.Text, txtYear.Text, _
                        lblID.Text, txtQty.Text, txtUnit.Text, txtAmount.Text, txtFreight.Text, _
                        txtConversion.Text, txtPO.Text, txtInvoiceNo.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)

                    displayMRN(cboCategory.Text)
                    'displayDefects()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not lblID.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboCategory.SelectAll()
                    cboCategory.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCategory.SelectAll()
                    cboCategory.Focus()
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

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Material Reference"
        f.searchType = 1
        f.displayAllMRN("%")
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 0)
                searchMRNDetials(lblCode.Text)
            End If
        End With
    End Sub

    Public Sub searchMRNDetials(ByVal mrnNo As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_display_MRNDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@mrnNo"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = mrnNo

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    cboCategory.Text = dr.GetString(1)
                    cboMaterials.Text = dr.GetString(2)
                    cboManufacturer.Text = dr.GetString(3)
                    cboSupplier.Text = dr.GetString(4)
                    txtInvoice.Value = dr.GetDateTime(5)
                    txtGRN.Value = dr.GetDateTime(6)
                    txtYear.Text = dr.GetInt32(7)
                    lblID.Text = dr.GetInt64(8)
                    txtQty.Text = dr.GetDouble(9)
                    txtUnit.Text = dr.GetString(10)
                    txtAmount.Text = dr.GetDouble(11)
                    txtFreight.Text = dr.GetDouble(12)
                    txtConversion.Text = dr.GetDouble(13)
                    txtPO.Text = dr.GetString(14)
                    txtInvoiceNo.Text = dr.GetString(15)
                Else
                    cboCategory.Text = ""
                    cboMaterials.Text = ""
                    cboManufacturer.Text = ""
                    cboSupplier.Text = ""
                    txtInvoice.Value = getServerDateTime()
                    txtGRN.Value = getServerDateTime()
                    txtYear.Text = Format(getServerDateTime, "yyyy")
                    lblID.Text = ""
                    txtQty.Text = "0"
                    txtUnit.Text = ""
                    txtAmount.Text = "0"
                    txtFreight.Text = "0"
                    txtConversion.Text = "0"
                    txtPO.Text = ""
                    txtInvoiceNo.Text = ""
                End If
            Else
                cboCategory.Text = ""
                cboMaterials.Text = ""
                cboManufacturer.Text = ""
                cboSupplier.Text = ""
                txtInvoice.Value = getServerDateTime()
                txtGRN.Value = getServerDateTime()
                txtYear.Text = Format(getServerDateTime, "yyyy")
                lblID.Text = ""
                txtQty.Text = "0"
                txtUnit.Text = ""
                txtAmount.Text = "0"
                txtFreight.Text = "0"
                txtConversion.Text = "0"
                txtPO.Text = ""
                txtInvoiceNo.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        If Not IsNumeric(txtQty.Text) Or txtQty.Text = "" Then
            txtQty.Text = "0"
            txtQty.SelectAll()
            txtQty.Focus()
        End If
    End Sub

    Private Sub mnuMaterials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaterials.Click
        Dim f As New frmMRN_Materials
        f.ShowDialog(Me)
        displayCategory()
        Me.displayMaterials(cboCategory.Text)
        cboMaterials.SelectAll()
        cboMaterials.Focus()
    End Sub

    Private Sub mnuManufacturer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuManufacturer.Click
        Dim f As New frmMRN_Manufacturer
        f.ShowDialog(Me)
        Me.displayManufacturer()
        cboManufacturer.SelectAll()
        cboManufacturer.Focus()
    End Sub

    Private Sub mnuSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSupplier.Click
        Dim f As New frmMRN_Supplier
        f.ShowDialog(Me)
        Me.displaySupplier()
        cboSupplier.SelectAll()
        cboSupplier.Focus()
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        If Not IsNumeric(txtAmount.Text) Or txtAmount.Text.Trim = "" Then
            txtAmount.Text = "0"
            txtAmount.SelectAll()
            txtAmount.Focus()
        End If
    End Sub

    Private Sub txtFreight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreight.TextChanged
        If Not IsNumeric(txtFreight.Text) Or txtFreight.Text.Trim = "" Then
            txtFreight.Text = "0"
            txtFreight.SelectAll()
            txtFreight.Focus()
        End If
    End Sub

    Private Sub txtConversion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConversion.TextChanged
        If Not IsNumeric(txtConversion.Text) Or txtConversion.Text.Trim = "" Then
            txtConversion.Text = "0"
            txtConversion.SelectAll()
            txtConversion.Focus()
        End If
    End Sub

    Private Sub cboCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboMaterials.SelectAll()
            cboMaterials.Focus()
        End If
    End Sub

    Private Sub cboMaterials_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMaterials.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboManufacturer.SelectAll()
            cboManufacturer.Focus()
        End If
    End Sub

    Private Sub cboManufacturer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboManufacturer.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSupplier.SelectAll()
            cboSupplier.Focus()
        End If
    End Sub

    Private Sub cboSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtInvoice.SelectAll()
            txtInvoice.Focus()
        End If
    End Sub

    Private Sub txtInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGRN.SelectAll()
            txtGRN.Focus()
        End If
    End Sub

    Private Sub txtGRN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGRN.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtYear.SelectAll()
            txtYear.Focus()
        End If
    End Sub

    Private Sub txtYear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYear.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPO.SelectAll()
            txtPO.Focus()
        End If
    End Sub

    Private Sub txtPO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPO.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtInvoiceNo.SelectAll()
            txtInvoiceNo.Focus()
        End If
    End Sub

    Private Sub txtInvoiceNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInvoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtQty.SelectAll()
            txtQty.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUnit.SelectAll()
            txtUnit.Focus()
        End If
    End Sub

    Private Sub txtUnit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAmount.SelectAll()
            txtAmount.Focus()
        End If
    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFreight.SelectAll()
            txtFreight.Focus()
        End If
    End Sub

    Private Sub txtFreight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFreight.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtConversion.SelectAll()
            txtConversion.Focus()
        End If
    End Sub

    Private Sub txtConversion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConversion.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd.Focus()
        End If
    End Sub
End Class
