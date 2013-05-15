Public Class frmFGWW
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cboProduct As C1.Win.C1List.C1Combo
    Friend WithEvents cboLoading As C1.Win.C1List.C1Combo
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents cboPurpose As C1.Win.C1List.C1Combo
    Friend WithEvents cboBuyer As C1.Win.C1List.C1Combo
    Friend WithEvents txtLoadingDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboPallet As C1.Win.C1List.C1Combo
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    Friend WithEvents gridPallet As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lstBuffer As C1.Win.C1List.C1List
    Friend WithEvents cmdAll As System.Windows.Forms.Button
    Friend WithEvents cmdPartial As System.Windows.Forms.Button
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuWarehouse As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSeal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents cmdPrintRelease As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFGWW))
        Me.cboProduct = New C1.Win.C1List.C1Combo
        Me.cboLoading = New C1.Win.C1List.C1Combo
        Me.txtContainer = New System.Windows.Forms.TextBox
        Me.cboVessel = New C1.Win.C1List.C1Combo
        Me.cboPurpose = New C1.Win.C1List.C1Combo
        Me.cboBuyer = New C1.Win.C1List.C1Combo
        Me.txtLoadingDate = New C1.Win.C1Input.C1DateEdit
        Me.cboPallet = New C1.Win.C1List.C1Combo
        Me.lblLabel = New System.Windows.Forms.Label
        Me.cmdAll = New System.Windows.Forms.Button
        Me.cmdPartial = New System.Windows.Forms.Button
        Me.gridPallet = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lstBuffer = New C1.Win.C1List.C1List
        Me.lblCode = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuWarehouse = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSeal = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblQty = New System.Windows.Forms.Label
        Me.cmdPrintRelease = New System.Windows.Forms.Button
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPurpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuyer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoadingDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstBuffer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProduct
        '
        Me.cboProduct.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboProduct.AllowColMove = False
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
        Me.cboProduct.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboProduct.ItemHeight = 20
        Me.cboProduct.Location = New System.Drawing.Point(107, 49)
        Me.cboProduct.MatchEntryTimeout = CType(2000, Long)
        Me.cboProduct.MaxDropDownItems = CType(10, Short)
        Me.cboProduct.MaxLength = 32767
        Me.cboProduct.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProduct.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProduct.Size = New System.Drawing.Size(173, 24)
        Me.cboProduct.TabIndex = 0
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
        'cboLoading
        '
        Me.cboLoading.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboLoading.AllowColMove = False
        Me.cboLoading.AutoCompletion = True
        Me.cboLoading.AutoDropDown = True
        Me.cboLoading.Caption = ""
        Me.cboLoading.CaptionHeight = 17
        Me.cboLoading.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLoading.ColumnCaptionHeight = 17
        Me.cboLoading.ColumnFooterHeight = 17
        Me.cboLoading.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboLoading.ContentHeight = 18
        Me.cboLoading.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLoading.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLoading.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoading.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLoading.EditorHeight = 18
        Me.cboLoading.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoading.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboLoading.ItemHeight = 20
        Me.cboLoading.Location = New System.Drawing.Point(107, 78)
        Me.cboLoading.MatchEntryTimeout = CType(2000, Long)
        Me.cboLoading.MaxDropDownItems = CType(10, Short)
        Me.cboLoading.MaxLength = 32767
        Me.cboLoading.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLoading.Name = "cboLoading"
        Me.cboLoading.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLoading.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLoading.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLoading.Size = New System.Drawing.Size(173, 24)
        Me.cboLoading.TabIndex = 1
        Me.cboLoading.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtContainer
        '
        Me.txtContainer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContainer.Location = New System.Drawing.Point(107, 108)
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.Size = New System.Drawing.Size(229, 23)
        Me.txtContainer.TabIndex = 2
        Me.txtContainer.Text = ""
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
        Me.cboVessel.ContentHeight = 18
        Me.cboVessel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVessel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVessel.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVessel.EditorHeight = 18
        Me.cboVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(537, 107)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(10, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.Size = New System.Drawing.Size(229, 24)
        Me.cboVessel.TabIndex = 6
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
        Me.cboPurpose.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboPurpose.ItemHeight = 20
        Me.cboPurpose.Location = New System.Drawing.Point(537, 49)
        Me.cboPurpose.MatchEntryTimeout = CType(2000, Long)
        Me.cboPurpose.MaxDropDownItems = CType(10, Short)
        Me.cboPurpose.MaxLength = 32767
        Me.cboPurpose.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPurpose.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPurpose.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPurpose.Size = New System.Drawing.Size(173, 24)
        Me.cboPurpose.TabIndex = 4
        Me.cboPurpose.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboBuyer
        '
        Me.cboBuyer.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboBuyer.AllowColMove = False
        Me.cboBuyer.AutoCompletion = True
        Me.cboBuyer.AutoDropDown = True
        Me.cboBuyer.Caption = ""
        Me.cboBuyer.CaptionHeight = 17
        Me.cboBuyer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBuyer.ColumnCaptionHeight = 17
        Me.cboBuyer.ColumnFooterHeight = 17
        Me.cboBuyer.ContentHeight = 18
        Me.cboBuyer.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBuyer.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBuyer.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuyer.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBuyer.EditorHeight = 18
        Me.cboBuyer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuyer.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboBuyer.ItemHeight = 20
        Me.cboBuyer.Location = New System.Drawing.Point(537, 78)
        Me.cboBuyer.MatchEntryTimeout = CType(2000, Long)
        Me.cboBuyer.MaxDropDownItems = CType(10, Short)
        Me.cboBuyer.MaxLength = 32767
        Me.cboBuyer.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBuyer.Name = "cboBuyer"
        Me.cboBuyer.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBuyer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBuyer.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBuyer.Size = New System.Drawing.Size(229, 24)
        Me.cboBuyer.TabIndex = 5
        Me.cboBuyer.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtLoadingDate
        '
        Me.txtLoadingDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoadingDate.Location = New System.Drawing.Point(107, 199)
        Me.txtLoadingDate.Name = "txtLoadingDate"
        Me.txtLoadingDate.Size = New System.Drawing.Size(221, 23)
        Me.txtLoadingDate.TabIndex = 7
        Me.txtLoadingDate.Tag = Nothing
        Me.txtLoadingDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboPallet
        '
        Me.cboPallet.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboPallet.AllowColMove = False
        Me.cboPallet.AutoCompletion = True
        Me.cboPallet.AutoDropDown = True
        Me.cboPallet.Caption = ""
        Me.cboPallet.CaptionHeight = 17
        Me.cboPallet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPallet.ColumnCaptionHeight = 17
        Me.cboPallet.ColumnFooterHeight = 17
        Me.cboPallet.ContentHeight = 18
        Me.cboPallet.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPallet.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPallet.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPallet.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPallet.EditorHeight = 18
        Me.cboPallet.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPallet.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboPallet.ItemHeight = 20
        Me.cboPallet.Location = New System.Drawing.Point(520, 198)
        Me.cboPallet.MatchEntryTimeout = CType(2000, Long)
        Me.cboPallet.MaxDropDownItems = CType(10, Short)
        Me.cboPallet.MaxLength = 32767
        Me.cboPallet.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPallet.Name = "cboPallet"
        Me.cboPallet.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPallet.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPallet.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPallet.Size = New System.Drawing.Size(152, 24)
        Me.cboPallet.TabIndex = 8
        Me.cboPallet.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'lblLabel
        '
        Me.lblLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel.Location = New System.Drawing.Point(107, 228)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(565, 23)
        Me.lblLabel.TabIndex = 8
        '
        'cmdAll
        '
        Me.cmdAll.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAll.Image = CType(resources.GetObject("cmdAll.Image"), System.Drawing.Image)
        Me.cmdAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAll.Location = New System.Drawing.Point(678, 204)
        Me.cmdAll.Name = "cmdAll"
        Me.cmdAll.Size = New System.Drawing.Size(109, 48)
        Me.cmdAll.TabIndex = 9
        Me.cmdAll.Text = "Load &All"
        Me.cmdAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPartial
        '
        Me.cmdPartial.Enabled = False
        Me.cmdPartial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPartial.Image = CType(resources.GetObject("cmdPartial.Image"), System.Drawing.Image)
        Me.cmdPartial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPartial.Location = New System.Drawing.Point(792, 204)
        Me.cmdPartial.Name = "cmdPartial"
        Me.cmdPartial.Size = New System.Drawing.Size(109, 48)
        Me.cmdPartial.TabIndex = 10
        Me.cmdPartial.TabStop = False
        Me.cmdPartial.Text = "Load Par&tial"
        Me.cmdPartial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPartial.Visible = False
        '
        'gridPallet
        '
        Me.gridPallet.AllowUpdate = False
        Me.gridPallet.CaptionHeight = 17
        Me.gridPallet.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPallet.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridPallet.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.gridPallet.Location = New System.Drawing.Point(24, 258)
        Me.gridPallet.Name = "gridPallet"
        Me.gridPallet.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridPallet.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridPallet.PreviewInfo.ZoomFactor = 75
        Me.gridPallet.RowHeight = 20
        Me.gridPallet.Size = New System.Drawing.Size(877, 110)
        Me.gridPallet.TabIndex = 11
        Me.gridPallet.Text = "C1TrueDBGrid1"
        Me.gridPallet.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;" & _
        "}Style13{}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColo" & _
        "r:ControlText;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14" & _
        "{}Style15{}Style9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name=""" & _
        """ CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeSty" & _
        "le=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrol" & _
        "lGroup=""1"" HorizontalScrollGroup=""1""><Height>106</Height><CaptionStyle parent=""S" & _
        "tyle2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle p" & _
        "arent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" />" & _
        "<FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style1" & _
        "2"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""Hig" & _
        "hlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowS" & _
        "tyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" " & _
        "me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Nor" & _
        "mal"" me=""Style1"" /><ClientRect>0, 0, 873, 106</ClientRect><BorderSide>0</BorderS" & _
        "ide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><N" & _
        "amedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" />" & _
        "<Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><St" & _
        "yle parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Sty" & _
        "le parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Sty" & _
        "le parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style pa" & _
        "rent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><St" & _
        "yle parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzS" & _
        "plits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWi" & _
        "dth><ClientArea>0, 0, 873, 106</ClientArea><PrintPageHeaderStyle parent="""" me=""S" & _
        "tyle14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(920, 408)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 48)
        Me.cmdClose.TabIndex = 36
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(920, 216)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(96, 88)
        Me.cmdPrint.TabIndex = 35
        Me.cmdPrint.Text = "&Print Loading Report"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(920, 160)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(96, 48)
        Me.cmdFind.TabIndex = 34
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(920, 104)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(96, 48)
        Me.cmdSave.TabIndex = 33
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(920, 48)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(96, 48)
        Me.cmdNew.TabIndex = 32
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 19)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Products"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1022, 40)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "FG Warehouse Withdrawal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Type of Loading"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Container No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(440, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Vessel Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(440, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 19)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Buyer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(440, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 19)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Purpose"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Pallet Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 19)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Loading Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(440, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 19)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Pallet No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 19)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Label"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 19)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Buffer Pallet Table"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(897, 208)
        Me.Label12.TabIndex = 71
        '
        'lstBuffer
        '
        Me.lstBuffer.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.lstBuffer.AllowColMove = False
        Me.lstBuffer.Caption = ""
        Me.lstBuffer.CaptionHeight = 17
        Me.lstBuffer.ColumnCaptionHeight = 17
        Me.lstBuffer.ColumnFooterHeight = 17
        Me.lstBuffer.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.lstBuffer.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.lstBuffer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBuffer.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.lstBuffer.ItemHeight = 20
        Me.lstBuffer.Location = New System.Drawing.Point(24, 403)
        Me.lstBuffer.MatchEntryTimeout = CType(2000, Long)
        Me.lstBuffer.Name = "lstBuffer"
        Me.lstBuffer.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.lstBuffer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.Single
        Me.lstBuffer.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstBuffer.Size = New System.Drawing.Size(880, 170)
        Me.lstBuffer.TabIndex = 72
        Me.lstBuffer.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;Border:None,,0, 0, 0, 0;}HighlightRow{ForeColor:HighlightText;" & _
        "BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{W" & _
        "rap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Align" & _
        "Vert:Center;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><S" & _
        "plits><C1.Win.C1List.ListBoxView AllowColMove=""False"" Name=""Split[0,0]"" CaptionH" & _
        "eight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=" & _
        """1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 876, 166</ClientRect><Height>166" & _
        "</Height><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Heigh" & _
        "t></HScrollBar><CaptionStyle parent=""Heading"" me=""Style9"" /><EvenRowStyle parent" & _
        "=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle " & _
        "parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><High" & _
        "LightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactiv" & _
        "e"" me=""Style5"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle" & _
        " parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Sty" & _
        "le4"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits" & _
        "><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading""" & _
        " /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" />" & _
        "<Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><" & _
        "Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" />" & _
        "<Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector""" & _
        " /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits>" & _
        "<horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRe" & _
        "cSelWidth></Blob>"
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(288, 51)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(144, 21)
        Me.lblCode.TabIndex = 73
        Me.lblCode.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuWarehouse})
        '
        'mnuWarehouse
        '
        Me.mnuWarehouse.Index = 0
        Me.mnuWarehouse.Text = "&Warehouse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Seal No."
        '
        'txtSeal
        '
        Me.txtSeal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeal.Location = New System.Drawing.Point(107, 137)
        Me.txtSeal.Name = "txtSeal"
        Me.txtSeal.Size = New System.Drawing.Size(229, 23)
        Me.txtSeal.TabIndex = 3
        Me.txtSeal.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(440, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 19)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Qty (bags/FCL)"
        '
        'lblQty
        '
        Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(537, 136)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(229, 24)
        Me.lblQty.TabIndex = 76
        Me.lblQty.Text = "0"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdPrintRelease
        '
        Me.cmdPrintRelease.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintRelease.Image = CType(resources.GetObject("cmdPrintRelease.Image"), System.Drawing.Image)
        Me.cmdPrintRelease.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrintRelease.Location = New System.Drawing.Point(920, 312)
        Me.cmdPrintRelease.Name = "cmdPrintRelease"
        Me.cmdPrintRelease.Size = New System.Drawing.Size(96, 88)
        Me.cmdPrintRelease.TabIndex = 78
        Me.cmdPrintRelease.Text = "Print Release Repor&t"
        Me.cmdPrintRelease.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmFGWW
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1022, 581)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdPrintRelease)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSeal)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lstBuffer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.gridPallet)
        Me.Controls.Add(Me.cmdPartial)
        Me.Controls.Add(Me.cmdAll)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.cboPallet)
        Me.Controls.Add(Me.txtLoadingDate)
        Me.Controls.Add(Me.cboBuyer)
        Me.Controls.Add(Me.cboPurpose)
        Me.Controls.Add(Me.cboVessel)
        Me.Controls.Add(Me.txtContainer)
        Me.Controls.Add(Me.cboLoading)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFGWW"
        Me.ShowInTaskbar = False
        Me.Text = "frmFGWW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPurpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuyer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoadingDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPallet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPallet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstBuffer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFGWW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtLoadingDate.Value = getServerDateTime()
        displayFGWWDetails()

        displayPackStyle()
        displayTypeOfLoading()
        displayTypeOfPurpose()
        displayVessel()
        displayPallet(cboProduct.Text)

        displayPalletDetails(cboProduct.Text, cboProduct.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayPackStyle()
        With cboProduct
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .DefColWidth = 150
            .AddItemTitles("Pack Type")
            .AddItem("Canned Tuna")
            .AddItem("Frozen Loins")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduct.TextChanged
        If cboProduct.Text = "" Then If cboProduct.ListCount > 0 Then cboProduct.SelectedIndex = 0

        displayFGWWDetails()
        displayPallet(cboProduct.Text)
    End Sub

    Public Sub displayTypeOfLoading()
        With cboLoading
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .DefColWidth = 150
            .AddItemTitles("Type of Loading")
            .AddItem("Bulk Loading")
            .AddItem("Container Loading")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLoading_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLoading.TextChanged
        If cboLoading.Text = "" Then If cboLoading.ListCount > 0 Then cboLoading.SelectedIndex = 0

        If cboLoading.Text.StartsWith("Cont") Then
            Label3.Text = "Container No."
            txtContainer.Text = ""
        Else
            Label3.Text = "Hatch No."
            txtSeal.Text = "*"
        End If
    End Sub

    Public Sub displayTypeOfPurpose()
        With cboPurpose
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .DefColWidth = 150
            .AddItemTitles("Purpose")
            .AddItem("For Export")
            .AddItem("Local Sales")
            .AddItem("Transfer")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboPurpose_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPurpose.TextChanged
        If cboPurpose.Text = "" Then If cboPurpose.ListCount > 0 Then cboPurpose.SelectedIndex = 0

        If cboPurpose.Text.StartsWith("Transfer") Then
            Label5.Text = "Warehouse"
            displayWarehouse(True)
        Else
            Label5.Text = "Buyer"
            displayWarehouse(False)
        End If
    End Sub

    Public Sub displayWarehouse(ByVal warehouse As Boolean)
        With cboBuyer
            If warehouse Then
                .Text = ""
                .ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
                .DataSource = modModule.getWarehouse().Tables(0)
                .Splits(0).DisplayColumns(0).Width = 205
            Else
                .Text = ""
                .ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownCombo
                .DataSource = Nothing
            End If
        End With
    End Sub

    Public Sub displayVessel()
        With cboVessel
            .DataSource = modModule.getVessel_Container().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 208
        End With
    End Sub

    Public Sub displayPallet(ByVal product As String)
        With cboPallet
            .AutoCompletion = True
            .AutoDropDown = True
            .DataSource = modModule.getPallet_PackType(product).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 132

        End With
    End Sub

    Public Sub displayPalletDetails(ByVal pallet As String, ByVal category As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getPalletDetails_Product"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@pallet"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = pallet

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@case"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.Float
            p2.Value = 0

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@cans"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.Float
            p3.Value = 0

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@category"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            If category.StartsWith("Can") Then
                p4.Value = "%can%"
            Else
                p4.Value = "%loin%"
            End If

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            With gridPallet
                .DataSource = ds.Tables(0)
                '.Columns(5).NumberFormat = "###,###,##0"
                .Columns(6).NumberFormat = "###,###,##0"
                .Columns(7).NumberFormat = "###,###,##0"
                .Columns(8).NumberFormat = "###,###,##0"
                .Columns(9).NumberFormat = "###,###,##0"

                .Splits(0).DisplayColumns(0).Width = 65
                .Splits(0).DisplayColumns(1).Width = 65
                .Splits(0).DisplayColumns(2).Width = 75
                .Splits(0).DisplayColumns(3).Width = 55
                .Splits(0).DisplayColumns(5).Width = 65
                .Splits(0).DisplayColumns(6).Width = 85
                .Splits(0).DisplayColumns(7).Width = 85
                .Splits(0).DisplayColumns(8).Width = 80
                .Splits(0).DisplayColumns(9).Width = 65
            End With

            da.Dispose()
            ds.Dispose()
            c.Close()

            computeCases(p4.Value)
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub computeCases(ByVal category As String)
        Dim ctr As Integer
        With gridPallet
            While ctr < .RowCount
                'If category = "Can" Then
                '    .Item(ctr, 7) = .Item(ctr, 7) - getPalletQty(cboPallet.Text, .Item(ctr, 0))
                '    .Item(ctr, 5) = CDbl(.Item(ctr, 7)) \ .Item(ctr, 8)
                '    .Item(ctr, 6) = CInt(.Item(ctr, 7)) - (CInt(.Item(ctr, 5)) * .Item(ctr, 8))
                'Else
                '.Item(ctr, 7) = CDbl(.Item(ctr, 5)) * .Item(ctr, 8) + .Item(ctr, 6)
                'If CStr(.Item(ctr, 0)).StartsWith("FA") Or CStr(.Item(ctr, 0)).StartsWith("LA") Then
                '.Item(ctr, 7) = .Item(ctr, 5)
                '.Item(ctr, 7) = .Item(ctr, 7) - getPalletQty(cboPallet.Text, .Item(ctr, 0), .Item(ctr, 3))
                'Else
                .Item(ctr, 8) = .Item(ctr, 8) - getPalletQty(cboPallet.Text, .Item(ctr, 1), .Item(ctr, 4), .Item(ctr, 5))
                'End If

                .Item(ctr, 6) = CDbl(.Item(ctr, 8)) \ .Item(ctr, 9)
                .Item(ctr, 7) = CInt(.Item(ctr, 8)) - (CInt(.Item(ctr, 6)) * .Item(ctr, 9))
                'End If

                'If .Item(ctr, 7) = "0" Then .Delete(ctr)

                ctr += 1
            End While
        End With
    End Sub

    Private Sub cboPallet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPallet.TextChanged
        gridPallet.FetchRowStyles = True
        displayPalletLabel(cboPallet.Text)
        displayPalletDetails(cboPallet.Text, cboProduct.Text)
    End Sub

    Public Sub displayFGWWDetails()
        lblCode.Text = ""

        With lstBuffer
            .ClearItems()
            .AddItemTitles("Pallet No.;Tag No;Product Code;Label;Trip Code;Prod'n Date;Total Bags;Cycle;Julian Date;BBE;Loading Date;per Case;Cases;Units")

            .Splits(0).DisplayColumns(0).Width = 110
            .Splits(0).DisplayColumns(1).Width = 80
            .Splits(0).DisplayColumns(2).Width = 100
            .Splits(0).DisplayColumns(3).Width = 200
            .Splits(0).DisplayColumns(4).Width = 70
            .Splits(0).DisplayColumns(6).Width = 85
            .Splits(0).DisplayColumns(7).Width = 50
            .Splits(0).DisplayColumns(8).Width = 80
            .Splits(0).DisplayColumns(11).Width = 70
            .Splits(0).DisplayColumns(12).Width = 70
            .Splits(0).DisplayColumns(13).Width = 70


            .Splits(0).DisplayColumns(6).Style.HorizontalAlignment = C1.Win.C1List.AlignHorzEnum.Far
            .Columns(6).NumberFormat = "###,###,##0"
            .Splits(0).DisplayColumns(11).Style.HorizontalAlignment = C1.Win.C1List.AlignHorzEnum.Far
            .Columns(11).NumberFormat = "###,###,##0"
            .Splits(0).DisplayColumns(12).Style.HorizontalAlignment = C1.Win.C1List.AlignHorzEnum.Far
            .Columns(12).NumberFormat = "###,###,##0"
            .Splits(0).DisplayColumns(13).Style.HorizontalAlignment = C1.Win.C1List.AlignHorzEnum.Far
            .Columns(13).NumberFormat = "###,###,##0"
        End With
    End Sub

    Public Sub addToBuffer(ByVal pallet As String, ByVal tagNo As String, ByVal pCode As String, ByVal label As String, _
    ByVal lot As String, ByVal prodnDate As String, ByVal totalBags As String, ByVal cycle As String, _
    ByVal julian As String, ByVal bbe As String, ByVal loadingDate As String, ByVal perCase As String, _
    ByVal cases As String, ByVal unit As String)

        With lstBuffer
            .AddItem(pallet.Trim & ";" & tagNo & ";" & pCode & ";" & label & ";" & lot & ";" & prodnDate & ";" & _
                totalBags & ";" & cycle & ";" & julian & ";" & bbe & ";" & loadingDate & ";" & _
                perCase & ";" & cases & ";" & unit)
        End With
    End Sub

    Private Sub cmdAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAll.Click
        With gridPallet
            If Not cboPallet.Text.Trim = "" And gridPallet.RowCount > 0 Then   'And Not (.Item(.Row, 7)) = 0
                If .Item(.Row, 8) > 0 Then
                    Dim reply As String
                    'If CDbl(lblQty.Text) + (.Item(.Row, 7) / .Item(.Row, 8)) > 1155 Then
                    '    MsgBox("You exceeded the maximum cases per FCL", MsgBoxStyle.Exclamation, "Warning")
                    '    cmdNew.Focus()
                    'Else
                    reply = MsgBox("Are you sure you want to load all the details of the Pallet No." & cboPallet.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        Dim ctr As Integer
                        While ctr < .RowCount
                            If Not .Item(ctr, 8) = "0" Then
                                If Not isPalletAlreadyAllocated(cboPallet.Text.Trim, .Item(ctr, 1), .Item(ctr, 8)) Then
                                    'addToBuffer(cboPallet.Text, .Item(ctr, 0), lblLabel.Text, .Item(ctr, 1), .Item(ctr, 4), _
                                    '    .Item(ctr, 3), .Item(ctr, 2), .Item(ctr, 5), .Item(ctr, 6), txtLoadingDate.Value, _
                                    '    .Item(ctr, 7), .Item(ctr, 8), .Item(ctr, 10))
                                    addToBuffer(cboPallet.Text, .Item(ctr, 0), .Item(ctr, 1), lblLabel.Text, .Item(ctr, 2), .Item(ctr, 4), _
                                        .Item(ctr, 8), .Item(ctr, 5), .Item(ctr, 3), .Item(ctr, 11), txtLoadingDate.Value, _
                                        .Item(ctr, 7), .Item(ctr, 6), .Item(ctr, 7))
                                Else
                                    MsgBox("Pallet No. " & cboPallet.Text.Trim & " with Product Code of " & .Item(ctr, 0) & " and quantity of " & .Item(.Row, 7) & " is already been used and allocated", MsgBoxStyle.Exclamation, "Warning")
                                End If
                            End If

                            ctr += 1
                        End While
                    End If
                    cboPallet.Text = ""
                    txtLoadingDate.SelectAll()
                    txtLoadingDate.Focus()
                    'End If
                Else
                    MsgBox("Please make sure quantity of pallet is greater than zero (0).", MsgBoxStyle.Exclamation, "Warning")
                    cboPallet.SelectAll()
                    cboPallet.Focus()
                End If
            Else
                MsgBox("Please identify the Pallet Number or it was already been allocated. Check the Total Units/ Bags.", MsgBoxStyle.Exclamation, "Warning")
                cboPallet.SelectAll()
                cboPallet.Focus()
            End If
        End With

        calculateFCLs()
    End Sub

    Public Sub displayPalletLabel(ByVal pallet As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getPalletDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@pallet#"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = pallet

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    lblLabel.Text = dr.GetString(2)
                Else
                    lblLabel.Text = ""
                End If
            Else
                lblLabel.Text = ""
            End If

            dr.Close()
            c.Close()

        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Function isPalletAlreadyAllocated(ByVal pallet As String, ByVal pCode As String, ByVal qty As String) As Boolean
        Dim ctr As Integer
        With lstBuffer
            While ctr < .ListCount
                If .GetItemText(ctr, 0) = pallet And .GetItemText(ctr, 2) = pCode And CDbl(.GetItemText(ctr, 6)) = qty Then
                    Return True
                End If

                ctr += 1
            End While
        End With

        Return False
    End Function

    'Public Sub showOverrideQty(ByVal show As Boolean)
    '    With grpQty
    '        If show Then
    '            .Enabled = True
    '            .Visible = True
    '        Else
    '            .Enabled = False
    '            .Visible = False
    '        End If
    '    End With
    'End Sub

    Private Sub cmdPartial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPartial.Click
        'With gridPallet
        '    If Not cboPallet.Text.Trim = "" And gridPallet.RowCount > 0 Then        'And Not (.Item(.Row, 7)) = 0
        '        If .Item(.Row, 7) > 0 Then
        '            Dim reply As String
        '            'If CDbl(lblQty.Text) + (.Item(.Row, 7) / .Item(.Row, 8)) > 1155 Then
        '            '    MsgBox("You exceeded the maximum cases per FCL", MsgBoxStyle.Exclamation, "Warning")
        '            '    cmdNew.Focus()
        '            'Else
        '            reply = MsgBox("Are you sure you want to load partially the details of the Pallet No." & cboPallet.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        '            If reply = vbYes Then
        '                Dim ctr As Integer

        '                While ctr < .RowCount
        '                    If Not .Item(ctr, 7) = "0" Then
        '                        Dim f As New frmOverridePalletAllocation
        '                        f.lblOPallet.Text = cboPallet.Text
        '                        f.lblOCode.Text = .Item(ctr, 0)
        '                        f.lblOLot.Text = .Item(ctr, 1)
        '                        f.lblOCases.Text = Format(CDbl(.Item(ctr, 5)), "###,###,##0")
        '                        f.lblOTins.Text = Format(CDbl(.Item(ctr, 6)), "###,###,##0")
        '                        f.lblOTotal.Text = Format(CDbl(.Item(ctr, 7)), "###,###,##0")
        '                        f.lblOperCase.Text = .Item(ctr, 8)
        '                        f.lblOIndex.Text = ctr
        '                        f.txtOCase.Text = .Item(ctr, 5)
        '                        f.txtOTins.Text = .Item(ctr, 6)
        '                        f.ShowDialog(Me)

        '                        If Not f.total = 0 Then
        '                            If Not isPalletAlreadyAllocated(cboPallet.Text.Trim, .Item(ctr, 0), .Item(ctr, 7)) Then
        '                                'addToBuffer(cboPallet.Text, .Item(ctr, 0), lblLabel.Text, .Item(ctr, 1), .Item(ctr, 4), _
        '                                '    .Item(ctr, 3), .Item(ctr, 2), f.cases, f.tins, txtLoadingDate.Value, _
        '                                '    f.total, .Item(ctr, 8), .Item(ctr, 10))
        '                                addToBuffer(cboPallet.Text, dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), _
        '                                    dr.GetDateTime(5), dr.GetDouble(6), dr.GetString(7), dr.GetInt32(8), dr.GetDateTime(9), dr.GetDateTime(10), _
        '                                    dr.GetDouble(11), (dr.GetDouble(6) \ dr.GetDouble(11)), _
        '                                   (dr.GetDouble(6) - (dr.GetDouble(6) \ dr.GetDouble(11) * dr.GetDouble(11))))
        '                            Else
        '                                MsgBox("Pallet No. " & cboPallet.Text.Trim & " with Product Code of " & .Item(ctr, 0) & " and quantity of " & .Item(.Row, 7) & " is already been used and allocated", MsgBoxStyle.Exclamation, "Warning")
        '                            End If
        '                        End If
        '                    End If
        '                    ctr += 1
        '                End While

        '                cboPallet.Text = ""
        '                txtLoadingDate.SelectAll()
        '                txtLoadingDate.Focus()
        '                'endif
        '            End If
        '        Else
        '            MsgBox("Please make sure quantity of pallet is greater than zero (0).", MsgBoxStyle.Exclamation, "Warning")
        '            cboPallet.SelectAll()
        '            cboPallet.Focus()
        '        End If
        '    Else
        '        MsgBox("Please identify the Pallet Number or it was already been allocated. Check the Total Units/ Bags.", MsgBoxStyle.Exclamation, "Warning")
        '        cboPallet.SelectAll()
        '        cboPallet.Focus()
        '    End If
        'End With

        'calculateFCLs()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        cboProduct.SelectAll()
        cboProduct.Focus()
    End Sub

    Public Sub addNewRecord()
        With Me
            .lblCode.Text = ""
            .cboProduct.SelectedIndex = 0
            .cboLoading.SelectedIndex = 0
            .txtContainer.Text = ""
            .cboVessel.Text = ""
            .displayVessel()
            .cboPurpose.SelectedIndex = 0
            .cboBuyer.Text = ""
            .txtLoadingDate.Value = getServerDateTime()
            .cboPallet.Text = ""
            lblQty.Text = "0"
            .displayPallet(cboProduct.Text)
            .displayFGWWDetails()
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If isDataEntryFieldAreNotEmpty() And lstBuffer.ListCount > 0 Then
            Dim reply As String = MsgBox("Are you sure you want to process this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If reply = vbYes Then
                If lblCode.Text.Trim = "" Then
                    saveNewFGWithdrawal(cboLoading.Text.Trim, txtContainer.Text.Trim, cboVessel.Text.Trim, _
                        cboPurpose.Text.Trim, cboBuyer.Text.Trim, txtSeal.Text.Trim)

                    Dim ctr As Integer
                    While ctr < lstBuffer.ListCount
                        'saveNewFGWithdrawalDetails(lblCode.Text, lstBuffer.GetItemText(ctr, 0), lstBuffer.GetItemText(ctr, 1), _
                        '        lstBuffer.GetItemText(ctr, 10), lstBuffer.GetItemText(ctr, 7), lstBuffer.GetItemText(ctr, 3), _
                        '        lstBuffer.GetItemText(ctr, 5), lstBuffer.GetItemText(ctr, 12))
                        saveNewFGWithdrawalDetails(lblCode.Text, lstBuffer.GetItemText(ctr, 0), lstBuffer.GetItemText(ctr, 2), _
                                lstBuffer.GetItemText(ctr, 6), lstBuffer.GetItemText(ctr, 10), lstBuffer.GetItemText(ctr, 4), _
                                lstBuffer.GetItemText(ctr, 5), lstBuffer.GetItemText(ctr, 7), "", "")

                        ctr += 1
                    End While
                Else
                    updateFGWithdrawn(lblCode.Text, cboLoading.Text, txtContainer.Text, cboVessel.Text, cboPurpose.Text, cboBuyer.Text, txtSeal.Text)

                    deleteFGWithdrawnDetails(lblCode.Text)
                    Dim ctr As Integer
                    While ctr < lstBuffer.ListCount
                        'saveNewFGWithdrawalDetails(lblCode.Text, lstBuffer.GetItemText(ctr, 0), lstBuffer.GetItemText(ctr, 1), _
                        '    lstBuffer.GetItemText(ctr, 10), lstBuffer.GetItemText(ctr, 7), lstBuffer.GetItemText(ctr, 3), _
                        '    lstBuffer.GetItemText(ctr, 5), lstBuffer.GetItemText(ctr, 12))
                        saveNewFGWithdrawalDetails(lblCode.Text, lstBuffer.GetItemText(ctr, 0), lstBuffer.GetItemText(ctr, 2), _
                                lstBuffer.GetItemText(ctr, 6), lstBuffer.GetItemText(ctr, 10), lstBuffer.GetItemText(ctr, 4), _
                                lstBuffer.GetItemText(ctr, 5), lstBuffer.GetItemText(ctr, 7), "", "")

                        ctr += 1
                    End While
                End If

                MsgBox("Transaction is successfully completed.", MsgBoxStyle.Information, "Information")
                addNewRecord()
                cmdNew.Focus()
            End If
        Else
            MsgBox("Please fill in the empty fields", MsgBoxStyle.Exclamation, "Warning")
            cboProduct.SelectAll()
            cboProduct.Focus()
        End If
    End Sub

    Public Sub saveNewFGWithdrawal(ByVal loadingType As String, ByVal cont As String, ByVal voyageName As String, _
    ByVal purposeType As String, ByVal purpose As String, ByVal seal As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FGWithdrawal"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFGWithdrawalCounter()

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@loadingCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = Format(getServerDateTime(), "MM") & "-" & getFGWithdrawalCounter() & "-" & cont & "-" & seal
            lblCode.Text = p2.Value

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@loadingType"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = loadingType

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@cont#"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = cont

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@voyageName"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = voyageName

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@purposeType"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = purposeType

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@purpose"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.VarChar
            If purposeType.StartsWith("Transfer") Then
                p7.Value = getWarehouseCode(purpose)
            Else
                p7.Value = purpose
            End If

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

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@seal#"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.VarChar
            p8.Value = seal

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)
            cmd.Parameters.Add(p8)


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
        f.lblTitle.Text = "Search FG Warehouse Withdrawal Details"
        f.searchType = 1
        f.displayAllFGWithdrawn()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 0)       '8
                displayFGWithdrawnDetails(lblCode.Text, .Item(.Row, 5))
                lblCode.Text = .Item(.Row, 0)       '8
                displayFGWithdrawnDetails(lblCode.Text)
            End If
        End With

        cboProduct.SelectAll()
        cboProduct.Focus()
    End Sub

    Public Sub displayFGWithdrawnDetails(ByVal code As String, ByVal purpose As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim qry As String
            If purpose.StartsWith("Transfer") Then
                qry = "proc_getFGWithdrawn_Transfer"
            Else
                qry = "proc_getFGWithdrawn_Other"
            End If

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = qry
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@loadingCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = code

            cmd.Parameters.Add(p1)

            Dim drCode As SqlClient.SqlDataReader
            drCode = cmd.ExecuteReader

            If drCode.Read Then
                If Not drCode(0) Is DBNull.Value Then
                    cboProduct.Text = drCode.GetString(0)
                    cboLoading.Text = drCode.GetString(1)
                    txtContainer.Text = drCode.GetString(2)
                    cboVessel.Text = drCode.GetString(3)
                    cboPurpose.Text = drCode.GetString(4)
                    cboBuyer.Text = drCode.GetString(5)
                    txtSeal.Text = drCode.GetString(6)
                Else
                    cboProduct.SelectedIndex = 0
                    cboLoading.SelectedIndex = 0
                    txtContainer.Text = ""
                    cboVessel.Text = ""
                    cboPurpose.SelectedIndex = 0
                    cboBuyer.Text = ""
                    txtSeal.Text = ""
                End If
            Else
                cboProduct.SelectedIndex = 0
                cboLoading.SelectedIndex = 0
                txtContainer.Text = ""
                cboVessel.Text = ""
                cboPurpose.SelectedIndex = 0
                cboBuyer.Text = ""
                txtSeal.Text = ""
            End If

            drCode.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displayFGWithdrawnDetails(ByVal code As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getFGWithdrawn_Details"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@loadingCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = code

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            lstBuffer.ClearItems()
            While dr.Read
                If Not dr(0) Is DBNull.Value Then
                    addToBuffer(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), _
                        dr.GetDateTime(5), dr.GetDouble(6), dr.GetString(7), dr.GetInt32(8), dr.GetDateTime(9), dr.GetDateTime(10), _
                        dr.GetDouble(11), (dr.GetDouble(6) \ dr.GetDouble(11)), _
                        (dr.GetDouble(6) - ((dr.GetDouble(6) \ dr.GetDouble(11)) * dr.GetDouble(11))))
                End If
            End While

            dr.Close()
            c.Close()

            calculateFCLs()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub lstBuffer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstBuffer.KeyDown
        With lstBuffer
            If e.KeyCode = Keys.Delete Then
                If .SelectedIndex >= 0 Then
                    Dim reply As String = MsgBox("Are you sure you want to delete this row with details:" & Chr(13) & _
                                        "Pallet No: " & .GetItemText(.SelectedIndex, 0) & Chr(13) & _
                                        "Product: " & .GetItemText(.SelectedIndex, 2) & Chr(13) & _
                                        "Lot No." & .GetItemText(.SelectedIndex, 4) & Chr(13) & _
                                        "Total Bags: " & .GetItemText(.SelectedIndex, 6) , MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        lstBuffer.RemoveItem(.SelectedIndex)
                        calculateFCLs()
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub gridPallet_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles gridPallet.FetchRowStyle
        If gridPallet.Columns(8).CellValue(e.Row) = "0" Then 'gridLot.Columns(9).CellValue(e.Row) = "For Evaluation" Then
            'gridPallet.Splits(0).DisplayColumns(4).Locked = False
            'gridPallet.Splits(0).DisplayColumns(4).Style.BackColor = Color.White
            e.CellStyle.ForeColor = System.Drawing.Color.White
            e.CellStyle.BackColor = System.Drawing.Color.Red
        Else
            e.CellStyle.ForeColor = System.Drawing.Color.Black
            e.CellStyle.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub mnuWarehouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWarehouse.Click
        Dim f As New frmWarehouse
        f.ShowDialog(Me)

        cboPurpose_TextChanged(sender, New EventArgs)

        cboBuyer.SelectAll()
        cboBuyer.Focus()
    End Sub

    Public Function isDataEntryFieldAreNotEmpty() As Boolean
        If cboPurpose.Text.StartsWith("Transfer") Then
            If Not cboProduct.Text.Trim = "" And Not cboLoading.Text.Trim = "" And Not txtContainer.Text.Trim = "" And _
                Not cboVessel.Text.Trim = "" And Not cboPurpose.Text.Trim = "" And Not cboBuyer.Text.Trim = "" Then
                Return True
            Else
                Return False
            End If
        Else
            If Not cboProduct.Text.Trim = "" And Not cboLoading.Text.Trim = "" And Not txtContainer.Text.Trim = "" And _
                Not cboVessel.Text.Trim = "" And Not cboPurpose.Text.Trim = "" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Sub calculateFCLs()
        With lstBuffer
            Dim ctr As Integer
            Dim total As Double
            Dim perCase As Double
            While ctr < .ListCount
                total += .GetItemText(ctr, 6)
                'perCase = .GetItemText(ctr, 11)

                ctr += 1
            End While

            'lblQty.Text = Format(total / perCase, "###,##0.#0")
            lblQty.Text = Format(total, "###,##0.#0")
        End With
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim f As New frmPrintPackingLists
        f.Label4.Text = "Print Loading Report"
        f.lblContainer.Text = txtContainer.Text
        f.lblSeal.Text = txtSeal.Text
        f.cmdPrint.Enabled = False
        f.ShowDialog(Me)
    End Sub

    Private Sub cboProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProduct.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLoading.SelectAll()
            cboLoading.Focus()
        End If
    End Sub

    Private Sub cboLoading_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLoading.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContainer.SelectAll()
            txtContainer.Focus()
        End If
    End Sub

    Private Sub txtContainer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainer.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSeal.SelectAll()
            txtSeal.Focus()
        End If
    End Sub

    Private Sub txtSeal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeal.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPurpose.SelectAll()
            cboPurpose.Focus()
        End If
    End Sub

    Private Sub cboPurpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPurpose.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboBuyer.SelectAll()
            cboBuyer.Focus()
        End If
    End Sub

    Private Sub cboBuyer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBuyer.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboVessel.SelectAll()
            cboVessel.Focus()
        End If
    End Sub

    Private Sub cboVessel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVessel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtLoadingDate.SelectAll()
            txtLoadingDate.Focus()
        End If
    End Sub

    Private Sub txtLoadingDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoadingDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPallet.SelectAll()
            cboPallet.Focus()
        End If
    End Sub

    Private Sub cboPallet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPallet.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAll.Focus()
        End If
    End Sub

    Private Sub cmdPrintRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintRelease.Click
        Dim f As New frmPrintReleaseReport
        f.displayData(txtContainer.Text, txtSeal.Text)
        f.ShowDialog(Me)
    End Sub
End Class
