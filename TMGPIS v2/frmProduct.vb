Public Class frmProduct
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
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCan As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents cboCategory As C1.Win.C1List.C1Combo
    Friend WithEvents cboPS As C1.Win.C1List.C1Combo
    Friend WithEvents cboMedia As C1.Win.C1List.C1Combo
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents cboCanSize As C1.Win.C1List.C1Combo
    Friend WithEvents cboFL As C1.Win.C1List.C1Combo
    Friend WithEvents cboCleaning As C1.Win.C1List.C1Combo
    Friend WithEvents lblFiller As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPeriod As C1.Win.C1List.C1Combo
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuPS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMedia As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSpecie As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCan As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFL As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCleaning As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPeriod As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFishSize As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLoinSize As System.Windows.Forms.MenuItem
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdAClose As System.Windows.Forms.Button
    Friend WithEvents cmdASave As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents grpFormula As System.Windows.Forms.GroupBox
    Friend WithEvents txtOil As System.Windows.Forms.TextBox
    Friend WithEvents txtWater As System.Windows.Forms.TextBox
    Friend WithEvents txtSalt As System.Windows.Forms.TextBox
    Friend WithEvents txtChili As System.Windows.Forms.TextBox
    Friend WithEvents txtCurry As System.Windows.Forms.TextBox
    Friend WithEvents txtBroth As System.Windows.Forms.TextBox
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProduct))
        Me.cboCategory = New C1.Win.C1List.C1Combo
        Me.cboPS = New C1.Win.C1List.C1Combo
        Me.cboMedia = New C1.Win.C1List.C1Combo
        Me.cboSpecie = New C1.Win.C1List.C1Combo
        Me.cboCanSize = New C1.Win.C1List.C1Combo
        Me.cboFL = New C1.Win.C1List.C1Combo
        Me.cboCleaning = New C1.Win.C1List.C1Combo
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmd = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblFiller = New System.Windows.Forms.Label
        Me.lblCan = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.cboPeriod = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuPS = New System.Windows.Forms.MenuItem
        Me.mnuMedia = New System.Windows.Forms.MenuItem
        Me.mnuSpecie = New System.Windows.Forms.MenuItem
        Me.mnuFishSize = New System.Windows.Forms.MenuItem
        Me.mnuCan = New System.Windows.Forms.MenuItem
        Me.mnuLoinSize = New System.Windows.Forms.MenuItem
        Me.mnuFL = New System.Windows.Forms.MenuItem
        Me.mnuCleaning = New System.Windows.Forms.MenuItem
        Me.mnuPeriod = New System.Windows.Forms.MenuItem
        Me.cmdClose = New System.Windows.Forms.Button
        Me.grp = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdAClose = New System.Windows.Forms.Button
        Me.cmdASave = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.grpFormula = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtMsg = New System.Windows.Forms.TextBox
        Me.txtBroth = New System.Windows.Forms.TextBox
        Me.txtCurry = New System.Windows.Forms.TextBox
        Me.txtChili = New System.Windows.Forms.TextBox
        Me.txtSalt = New System.Windows.Forms.TextBox
        Me.txtWater = New System.Windows.Forms.TextBox
        Me.txtOil = New System.Windows.Forms.TextBox
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCanSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCleaning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        Me.grpFormula.SuspendLayout()
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
        Me.cboCategory.Location = New System.Drawing.Point(98, 95)
        Me.cboCategory.MatchEntryTimeout = CType(2000, Long)
        Me.cboCategory.MaxDropDownItems = CType(10, Short)
        Me.cboCategory.MaxLength = 32767
        Me.cboCategory.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCategory.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategory.Size = New System.Drawing.Size(176, 24)
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboPS
        '
        Me.cboPS.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboPS.AllowColMove = False
        Me.cboPS.AutoCompletion = True
        Me.cboPS.AutoDropDown = True
        Me.cboPS.Caption = ""
        Me.cboPS.CaptionHeight = 17
        Me.cboPS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPS.ColumnCaptionHeight = 17
        Me.cboPS.ColumnFooterHeight = 17
        Me.cboPS.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboPS.ContentHeight = 18
        Me.cboPS.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPS.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPS.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPS.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPS.EditorHeight = 18
        Me.cboPS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPS.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboPS.ItemHeight = 20
        Me.cboPS.Location = New System.Drawing.Point(98, 126)
        Me.cboPS.MatchEntryTimeout = CType(2000, Long)
        Me.cboPS.MaxDropDownItems = CType(10, Short)
        Me.cboPS.MaxLength = 32767
        Me.cboPS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPS.Name = "cboPS"
        Me.cboPS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPS.Size = New System.Drawing.Size(176, 24)
        Me.cboPS.TabIndex = 1
        Me.cboPS.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;BackColor2:Window;BackColor:Window;}HighlightRow{ForeColor:Hig" & _
        "hlightText;BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center" & _
        ";}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:Contro" & _
        "lText;AlignVert:Center;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data>" & _
        "</Styles><Splits><C1.Win.C1List.ListBoxView AllowColMove=""False"" AllowColSelect=" & _
        """False"" Name=""Split[0,0]"" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFoot" & _
        "erHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0" & _
        ", 116, 156</ClientRect><Height>156</Height><VScrollBar><Width>16</Width></VScrol" & _
        "lBar><HScrollBar><Height>16</Height></HScrollBar><CaptionStyle parent=""Style2"" m" & _
        "e=""Style9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""F" & _
        "ooter"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle par" & _
        "ent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6""" & _
        " /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" m" & _
        "e=""Style8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style10"" /><Select" & _
        "edStyle parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C" & _
        "1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><S" & _
        "tyle parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style" & _
        " parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style " & _
        "parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""HighlightRow"" /><Styl" & _
        "e parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style par" & _
        "ent=""Heading"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Group"" /></Named" & _
        "Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" & _
        "out><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>"
        '
        'cboMedia
        '
        Me.cboMedia.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboMedia.AllowColMove = False
        Me.cboMedia.AutoCompletion = True
        Me.cboMedia.AutoDropDown = True
        Me.cboMedia.Caption = ""
        Me.cboMedia.CaptionHeight = 17
        Me.cboMedia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMedia.ColumnCaptionHeight = 17
        Me.cboMedia.ColumnFooterHeight = 17
        Me.cboMedia.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboMedia.ContentHeight = 18
        Me.cboMedia.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboMedia.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboMedia.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedia.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMedia.EditorHeight = 18
        Me.cboMedia.Enabled = False
        Me.cboMedia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedia.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboMedia.ItemHeight = 20
        Me.cboMedia.Location = New System.Drawing.Point(98, 157)
        Me.cboMedia.MatchEntryTimeout = CType(2000, Long)
        Me.cboMedia.MaxDropDownItems = CType(10, Short)
        Me.cboMedia.MaxLength = 32767
        Me.cboMedia.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMedia.Name = "cboMedia"
        Me.cboMedia.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMedia.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMedia.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMedia.Size = New System.Drawing.Size(176, 24)
        Me.cboMedia.TabIndex = 2
        Me.cboMedia.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboSpecie.Location = New System.Drawing.Point(98, 188)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(10, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.Size = New System.Drawing.Size(176, 24)
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
        'cboCanSize
        '
        Me.cboCanSize.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCanSize.AllowColMove = False
        Me.cboCanSize.AutoCompletion = True
        Me.cboCanSize.AutoDropDown = True
        Me.cboCanSize.Caption = ""
        Me.cboCanSize.CaptionHeight = 17
        Me.cboCanSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCanSize.ColumnCaptionHeight = 17
        Me.cboCanSize.ColumnFooterHeight = 17
        Me.cboCanSize.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCanSize.ContentHeight = 18
        Me.cboCanSize.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCanSize.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCanSize.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCanSize.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCanSize.EditorHeight = 18
        Me.cboCanSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCanSize.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboCanSize.ItemHeight = 20
        Me.cboCanSize.Location = New System.Drawing.Point(98, 219)
        Me.cboCanSize.MatchEntryTimeout = CType(2000, Long)
        Me.cboCanSize.MaxDropDownItems = CType(10, Short)
        Me.cboCanSize.MaxLength = 32767
        Me.cboCanSize.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCanSize.Name = "cboCanSize"
        Me.cboCanSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCanSize.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCanSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCanSize.Size = New System.Drawing.Size(176, 24)
        Me.cboCanSize.TabIndex = 4
        Me.cboCanSize.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboFL
        '
        Me.cboFL.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboFL.AllowColMove = False
        Me.cboFL.AutoCompletion = True
        Me.cboFL.AutoDropDown = True
        Me.cboFL.Caption = ""
        Me.cboFL.CaptionHeight = 17
        Me.cboFL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFL.ColumnCaptionHeight = 17
        Me.cboFL.ColumnFooterHeight = 17
        Me.cboFL.ContentHeight = 18
        Me.cboFL.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboFL.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboFL.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFL.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFL.EditorHeight = 18
        Me.cboFL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFL.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboFL.ItemHeight = 20
        Me.cboFL.Location = New System.Drawing.Point(98, 251)
        Me.cboFL.MatchEntryTimeout = CType(2000, Long)
        Me.cboFL.MaxDropDownItems = CType(10, Short)
        Me.cboFL.MaxLength = 32767
        Me.cboFL.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboFL.Name = "cboFL"
        Me.cboFL.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFL.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboFL.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFL.Size = New System.Drawing.Size(176, 24)
        Me.cboFL.TabIndex = 5
        Me.cboFL.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboCleaning
        '
        Me.cboCleaning.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCleaning.AllowColMove = False
        Me.cboCleaning.AutoCompletion = True
        Me.cboCleaning.AutoDropDown = True
        Me.cboCleaning.Caption = ""
        Me.cboCleaning.CaptionHeight = 17
        Me.cboCleaning.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCleaning.ColumnCaptionHeight = 17
        Me.cboCleaning.ColumnFooterHeight = 17
        Me.cboCleaning.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCleaning.ContentHeight = 18
        Me.cboCleaning.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCleaning.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCleaning.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCleaning.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCleaning.EditorHeight = 18
        Me.cboCleaning.Enabled = False
        Me.cboCleaning.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCleaning.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.cboCleaning.ItemHeight = 20
        Me.cboCleaning.Location = New System.Drawing.Point(744, 104)
        Me.cboCleaning.MatchEntryTimeout = CType(2000, Long)
        Me.cboCleaning.MaxDropDownItems = CType(10, Short)
        Me.cboCleaning.MaxLength = 32767
        Me.cboCleaning.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCleaning.Name = "cboCleaning"
        Me.cboCleaning.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCleaning.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCleaning.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCleaning.Size = New System.Drawing.Size(176, 24)
        Me.cboCleaning.TabIndex = 6
        Me.cboCleaning.Visible = False
        Me.cboCleaning.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(552, 448)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 12
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(472, 448)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 11
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(392, 448)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 48)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(312, 448)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 9
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(232, 448)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 8
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Product Type"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(938, 40)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Product Code"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(96, 288)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(832, 152)
        Me.grid.TabIndex = 44
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
        "arqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>148</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 828, 148</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 828, 148</ClientArea><PrintPageHeaderStyle parent" & _
        "="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Packing Style"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 19)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Media"
        '
        'lblFiller
        '
        Me.lblFiller.AutoSize = True
        Me.lblFiller.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiller.Location = New System.Drawing.Point(8, 255)
        Me.lblFiller.Name = "lblFiller"
        Me.lblFiller.Size = New System.Drawing.Size(61, 19)
        Me.lblFiller.TabIndex = 51
        Me.lblFiller.Text = "Filler Line"
        '
        'lblCan
        '
        Me.lblCan.AutoSize = True
        Me.lblCan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCan.Location = New System.Drawing.Point(8, 223)
        Me.lblCan.Name = "lblCan"
        Me.lblCan.Size = New System.Drawing.Size(55, 19)
        Me.lblCan.TabIndex = 50
        Me.lblCan.Text = "Can Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Fish Specie"
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(98, 56)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(176, 32)
        Me.lblCode.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 19)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(656, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Cleaning Code"
        Me.Label10.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Table View"
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.SystemColors.Control
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(758, 48)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(176, 32)
        Me.lblID.TabIndex = 57
        Me.lblID.Visible = False
        '
        'cboPeriod
        '
        Me.cboPeriod.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboPeriod.AllowColMove = False
        Me.cboPeriod.AutoCompletion = True
        Me.cboPeriod.AutoDropDown = True
        Me.cboPeriod.Caption = ""
        Me.cboPeriod.CaptionHeight = 17
        Me.cboPeriod.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPeriod.ColumnCaptionHeight = 17
        Me.cboPeriod.ColumnFooterHeight = 17
        Me.cboPeriod.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboPeriod.ContentHeight = 18
        Me.cboPeriod.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPeriod.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPeriod.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriod.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPeriod.EditorHeight = 18
        Me.cboPeriod.Enabled = False
        Me.cboPeriod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriod.Images.Add(CType(resources.GetObject("resource8"), System.Drawing.Image))
        Me.cboPeriod.ItemHeight = 20
        Me.cboPeriod.Location = New System.Drawing.Point(744, 136)
        Me.cboPeriod.MatchEntryTimeout = CType(2000, Long)
        Me.cboPeriod.MaxDropDownItems = CType(10, Short)
        Me.cboPeriod.MaxLength = 32767
        Me.cboPeriod.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPeriod.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPeriod.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPeriod.Size = New System.Drawing.Size(176, 24)
        Me.cboPeriod.TabIndex = 7
        Me.cboPeriod.Visible = False
        Me.cboPeriod.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'Label4
        '
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(656, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 32)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Time Period Batch"
        Me.Label4.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPS, Me.mnuMedia, Me.mnuSpecie, Me.mnuFishSize, Me.mnuCan, Me.mnuLoinSize, Me.mnuFL, Me.mnuCleaning, Me.mnuPeriod})
        '
        'mnuPS
        '
        Me.mnuPS.Index = 0
        Me.mnuPS.Text = "&Pack Style"
        '
        'mnuMedia
        '
        Me.mnuMedia.Index = 1
        Me.mnuMedia.Text = "&Media"
        '
        'mnuSpecie
        '
        Me.mnuSpecie.Index = 2
        Me.mnuSpecie.Text = "Fish &Specie"
        '
        'mnuFishSize
        '
        Me.mnuFishSize.Index = 3
        Me.mnuFishSize.Text = "F&ish Size"
        '
        'mnuCan
        '
        Me.mnuCan.Index = 4
        Me.mnuCan.Text = "Can Si&ze"
        '
        'mnuLoinSize
        '
        Me.mnuLoinSize.Index = 5
        Me.mnuLoinSize.Text = "&Loin Size"
        '
        'mnuFL
        '
        Me.mnuFL.Index = 6
        Me.mnuFL.Text = "&Filler Line"
        '
        'mnuCleaning
        '
        Me.mnuCleaning.Index = 7
        Me.mnuCleaning.Text = "&Cleaning"
        '
        'mnuPeriod
        '
        Me.mnuPeriod.Index = 8
        Me.mnuPeriod.Text = "&Time Period Batch"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(632, 448)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 60
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Label8)
        Me.grp.Controls.Add(Me.Label11)
        Me.grp.Controls.Add(Me.cmdAClose)
        Me.grp.Controls.Add(Me.cmdASave)
        Me.grp.Controls.Add(Me.txtPassword)
        Me.grp.Controls.Add(Me.txtUsername)
        Me.grp.Enabled = False
        Me.grp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(229, 360)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(480, 136)
        Me.grp.TabIndex = 70
        Me.grp.TabStop = False
        Me.grp.Text = "User Authentication"
        Me.grp.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 19)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Username"
        '
        'cmdAClose
        '
        Me.cmdAClose.Image = CType(resources.GetObject("cmdAClose.Image"), System.Drawing.Image)
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
        Me.cmdASave.Image = CType(resources.GetObject("cmdASave.Image"), System.Drawing.Image)
        Me.cmdASave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdASave.Location = New System.Drawing.Point(131, 88)
        Me.cmdASave.Name = "cmdASave"
        Me.cmdASave.Size = New System.Drawing.Size(75, 40)
        Me.cmdASave.TabIndex = 2
        Me.cmdASave.Text = "Delete"
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
        'grpFormula
        '
        Me.grpFormula.Controls.Add(Me.Label23)
        Me.grpFormula.Controls.Add(Me.Label22)
        Me.grpFormula.Controls.Add(Me.Label21)
        Me.grpFormula.Controls.Add(Me.Label20)
        Me.grpFormula.Controls.Add(Me.Label19)
        Me.grpFormula.Controls.Add(Me.Label12)
        Me.grpFormula.Controls.Add(Me.Label13)
        Me.grpFormula.Controls.Add(Me.Label14)
        Me.grpFormula.Controls.Add(Me.Label15)
        Me.grpFormula.Controls.Add(Me.Label16)
        Me.grpFormula.Controls.Add(Me.Label17)
        Me.grpFormula.Controls.Add(Me.Label18)
        Me.grpFormula.Controls.Add(Me.txtMsg)
        Me.grpFormula.Controls.Add(Me.txtBroth)
        Me.grpFormula.Controls.Add(Me.txtCurry)
        Me.grpFormula.Controls.Add(Me.txtChili)
        Me.grpFormula.Controls.Add(Me.txtSalt)
        Me.grpFormula.Controls.Add(Me.txtWater)
        Me.grpFormula.Controls.Add(Me.txtOil)
        Me.grpFormula.Enabled = False
        Me.grpFormula.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFormula.Location = New System.Drawing.Point(304, 87)
        Me.grpFormula.Name = "grpFormula"
        Me.grpFormula.Size = New System.Drawing.Size(344, 193)
        Me.grpFormula.TabIndex = 71
        Me.grpFormula.TabStop = False
        Me.grpFormula.Text = "Product Formulation (Qty Grams/ Net Weight)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(224, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(12, 19)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "g"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(224, 159)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(12, 19)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "g"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(224, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(12, 19)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "g"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(224, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(12, 19)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "g"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(224, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(12, 19)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "g"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(440, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 19)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Oil"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 19)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "MSG"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 19)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Broth"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 19)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Curry Powder"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 19)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Chili Powder"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 19)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Salt"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Enabled = False
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(440, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 19)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Water"
        Me.Label18.Visible = False
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(120, 157)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.TabIndex = 6
        Me.txtMsg.Text = "0"
        Me.txtMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBroth
        '
        Me.txtBroth.Location = New System.Drawing.Point(120, 126)
        Me.txtBroth.Name = "txtBroth"
        Me.txtBroth.TabIndex = 5
        Me.txtBroth.Text = "0"
        Me.txtBroth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCurry
        '
        Me.txtCurry.Location = New System.Drawing.Point(120, 94)
        Me.txtCurry.Name = "txtCurry"
        Me.txtCurry.TabIndex = 4
        Me.txtCurry.Text = "0"
        Me.txtCurry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChili
        '
        Me.txtChili.Location = New System.Drawing.Point(120, 61)
        Me.txtChili.Name = "txtChili"
        Me.txtChili.TabIndex = 3
        Me.txtChili.Text = "0"
        Me.txtChili.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalt
        '
        Me.txtSalt.Location = New System.Drawing.Point(120, 29)
        Me.txtSalt.Name = "txtSalt"
        Me.txtSalt.TabIndex = 2
        Me.txtSalt.Text = "0"
        Me.txtSalt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWater
        '
        Me.txtWater.Enabled = False
        Me.txtWater.Location = New System.Drawing.Point(480, 63)
        Me.txtWater.Name = "txtWater"
        Me.txtWater.TabIndex = 1
        Me.txtWater.Text = "0"
        Me.txtWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtWater.Visible = False
        '
        'txtOil
        '
        Me.txtOil.Enabled = False
        Me.txtOil.Location = New System.Drawing.Point(480, 32)
        Me.txtOil.Name = "txtOil"
        Me.txtOil.TabIndex = 0
        Me.txtOil.Text = "0"
        Me.txtOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOil.Visible = False
        '
        'frmProduct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(938, 500)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.grpFormula)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cboPeriod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.cboCleaning)
        Me.Controls.Add(Me.cboFL)
        Me.Controls.Add(Me.cboCanSize)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.cboMedia)
        Me.Controls.Add(Me.cboPS)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblFiller)
        Me.Controls.Add(Me.lblCan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProduct"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProduct"
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCanSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCleaning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        Me.grpFormula.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        dataEntry(1)
       
        displayProductType()
        displayMedia()
        displaySpecie()
        '        displayFL()
        displayCleaning()

        displayAllProduct(cboCategory.Text)
        displayPeriod()
    End Sub

    Public Sub displayAllProduct(ByVal packType As String)
        With grid
            .DataSource = modModule.getAllProduct(packType).Tables(0)
            .Splits(0).DisplayColumns(5).Width = 150
            .Splits(0).DisplayColumns(6).Width = 150
        End With
    End Sub

    Public Sub displayProductType()
        With cboCategory
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .DefColWidth = 155
            .AddItemTitles("Pack Type")
            .AddItem("Canned Tuna")
            .AddItem("Frozen Loins")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.TextChanged
        If cboCategory.Text = "" Then If cboCategory.ListCount > 0 Then cboCategory.SelectedIndex = 0

        lblCode.Text = ""
        validatePackType(cboCategory.Text)

        displayAllProduct(cboCategory.Text)
        displayPS(cboCategory.Text)
        displayCanSize(cboCategory.Text)
        displayFL(cboCategory.Text)
    End Sub

    Public Sub displayPS(ByVal packType As String)
        With cboPS
            .DataSource = modModule.getPackStyleDescription(packType).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
        End With
    End Sub

    Public Sub displayMedia()
        With cboMedia
            .DataSource = modModule.getProductMediaDescription().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
        End With
    End Sub

    Public Sub displaySpecie()
        With cboSpecie
            .DataSource = modModule.getAllFishSpecie_ProductSpecie().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
        End With
    End Sub

    Public Sub displayCanSize(ByVal packType As String)
        With cboCanSize
            .DataSource = modModule.getProductCanSize_PackType(packType).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
        End With
    End Sub

    Public Sub displayFL(ByVal category As String)
        With cboFL
            If category.StartsWith("Can") Then
                .ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
                .DataSource = modModule.getProductFLDescription().Tables(0)
            Else
                .ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
                .DataSource = modModule.getProductLSDescription().Tables(0)
            End If

            .Splits(0).DisplayColumns(0).Width = 155
        End With
    End Sub

    Public Sub displayCleaning()
        With cboCleaning
            .DataSource = modModule.getProductCleaningDescription().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
        End With
    End Sub

    Public Sub displayPeriod()
        With cboPeriod
            .DataSource = modModule.getProductPeriodDescription().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
        End With
    End Sub

    Public Sub validatePackType(ByVal packType As String)
        With Me
            If packType.StartsWith("Can") Then
                .lblCan.Text = "Can Size"
                .lblFiller.Text = "Filler Line"
                grpFormula.Enabled = True
            Else
                .lblCan.Text = "Fish Size"
                .lblFiller.Text = "Loin Size"
                grpFormula.Enabled = False
                txtOil.Text = "0"
                txtWater.Text = "0"
                txtSalt.Text = "0"
                txtChili.Text = "0"
                txtCurry.Text = "0"
                txtBroth.Text = "0"
                txtMsg.Text = "0"
            End If

            If cmd.Text = "&Add" Then
                .cboMedia.Enabled = False
                .cboCleaning.Enabled = False
                .grpFormula.Enabled = False
            Else
                If packType.StartsWith("Can") Then
                    .cboMedia.Enabled = True
                    .cboCleaning.Text = ""
                    .cboCleaning.Enabled = False
                    .grpFormula.Enabled = True
                Else
                    .cboMedia.Text = ""
                    .cboMedia.Enabled = False
                    .cboCleaning.Enabled = True
                    .grpFormula.Enabled = False
                End If
            End If
        End With
    End Sub

    Public Sub showProductCode(ByVal packType As String)
        With Me
            If packType.StartsWith("Can") Then
                lblCode.Text = modModule.getPackStyleCode(cboPS.Text) & _
                    modModule.getProductMediaCode(cboMedia.Text) & _
                    modModule.getFishSpecieCode_Product(cboSpecie.Text) & _
                    modModule.getProductCanSizeCode(cboCanSize.Text) & _
                    modModule.getProductFLCode(cboFL.Text) & _
                    modModule.getProductPeriodCode(cboPeriod.Text)
            Else
                lblCode.Text = modModule.getPackStyleCode(cboPS.Text) & _
                    modModule.getFishSpecieCode_Product(cboSpecie.Text) & _
                    modModule.getProductCanSizeCode(cboCanSize.Text) & _
                    modModule.getProductLSCode(cboFL.Text) & _
                    modModule.getProductCleaningCode(cboCleaning.Text) & _
                    modModule.getProductPeriodCode(cboPeriod.Text)
            End If
        End With
    End Sub

    Private Sub cboPS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPS.TextChanged
        showProductCode(cboCategory.Text)
    End Sub

    Private Sub cboMedia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedia.TextChanged
        showProductCode(cboCategory.Text)

        If cboMedia.Text.StartsWith("Chil") Then
            Label16.Text = "Chili Fruit"
            Label23.Text = "pc"
            txtSalt.Text = "0"
            txtSalt.ReadOnly = True
            txtChili.Text = "0"
            txtChili.ReadOnly = False
            txtCurry.Text = "0"
            txtCurry.ReadOnly = True
            txtBroth.Text = "0"
            txtBroth.ReadOnly = True
            txtMsg.Text = "0"
            txtMsg.ReadOnly = True
        ElseIf cboMedia.Text.StartsWith("Cur") Then
            Label16.Text = "Chili Powder"
            Label23.Text = "g"
            txtSalt.Text = "0"
            txtSalt.ReadOnly = False
            txtChili.Text = "0"
            txtChili.ReadOnly = False
            txtCurry.Text = "0"
            txtCurry.ReadOnly = False
            txtBroth.Text = "0"
            txtBroth.ReadOnly = False
            txtMsg.Text = "0"
            txtMsg.ReadOnly = False
        ElseIf cboMedia.Text.StartsWith("Sand") Then
            Label16.Text = "Chili Powder"
            Label23.Text = "g"
            txtSalt.Text = "0"
            txtSalt.ReadOnly = False
            txtChili.Text = "0"
            txtChili.ReadOnly = True
            txtCurry.Text = "0"
            txtCurry.ReadOnly = True
            txtBroth.Text = "0"
            txtBroth.ReadOnly = False
            txtMsg.Text = "0"
            txtMsg.ReadOnly = False
        Else
            Label16.Text = "Chili Powder"
            Label23.Text = "g"
            txtSalt.Text = "0"
            txtSalt.ReadOnly = True
            txtChili.Text = "0"
            txtChili.ReadOnly = True
            txtCurry.Text = "0"
            txtCurry.ReadOnly = True
            txtBroth.Text = "0"
            txtBroth.ReadOnly = True
            txtMsg.Text = "0"
            txtMsg.ReadOnly = True
        End If
    End Sub

    Private Sub cboSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSpecie.TextChanged
        showProductCode(cboCategory.Text)
    End Sub

    Private Sub cboCanSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCanSize.TextChanged
        showProductCode(cboCategory.Text)
    End Sub

    Private Sub cboFL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFL.TextChanged
        showProductCode(cboCategory.Text)
    End Sub

    Private Sub cboCleaning_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCleaning.TextChanged
        showProductCode(cboCategory.Text)
    End Sub

    Public Sub buttons(ByVal i As Integer)
        Select Case i
            Case 0
                cmdDelete.Enabled = False
                Me.cmdPrint.Enabled = False
                Me.cmdFind.Enabled = False
                Me.cmdClose.Enabled = False
            Case 1
                cmdDelete.Enabled = True
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
                cboPS.ReadOnly = False
                cboSpecie.ReadOnly = False
                cboCanSize.ReadOnly = False
                cboFL.ReadOnly = False
                cboPeriod.ReadOnly = False
                grpFormula.Enabled = True
                grid.Enabled = True
            Case 1
                cboCategory.ReadOnly = True
                cboPS.ReadOnly = True
                cboSpecie.ReadOnly = True
                cboCanSize.ReadOnly = True
                cboFL.ReadOnly = True
                cboPeriod.ReadOnly = True
                grpFormula.Enabled = False
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        lblID.Text = ""
        lblCode.Text = ""
        cboCategory.SelectedIndex = 0
        validatePackType(cboCategory.Text)
        cboPS.Text = ""
        cboMedia.Text = ""

        If cboMedia.Text = "" Then
            Label16.Text = "Chili Powder"
            Label23.Text = "g"
            txtSalt.Text = "0"
            txtSalt.ReadOnly = True
            txtChili.Text = "0"
            txtChili.ReadOnly = True
            txtCurry.Text = "0"
            txtCurry.ReadOnly = True
            txtBroth.Text = "0"
            txtBroth.ReadOnly = True
            txtMsg.Text = "0"
            txtMsg.ReadOnly = True
        End If

        displayMedia()
        cboSpecie.Text = ""
        displaySpecie()
        cboCanSize.Text = ""
        cboFL.Text = ""
        'displayFL()
        cboCleaning.Text = ""
        displayCleaning()
        cboPeriod.Text = ""
        displayPeriod()
        txtOil.Text = "0"
        txtWater.Text = "0"
        txtSalt.Text = "0"
        txtChili.Text = "0"
        txtCurry.Text = "0"
        txtBroth.Text = "0"
        txtMsg.Text = "0"

        displayAllProduct(cboCategory.Text)
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
                If lblCode.Text.Length >= 4 And validateFields() Then
                    If Not validateProduct(lblCode.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewProduct(lblCode.Text, cboPS.Text, cboMedia.Text, cboSpecie.Text, _
                                cboCanSize.Text, cboFL.Text, cboCleaning.Text, cboCategory.Text, cboPeriod.Text, _
                                txtOil.Text, txtWater.Text, txtSalt.Text, txtChili.Text, txtCurry.Text, _
                                txtBroth.Text, txtMsg.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)
                            validatePackType(cboCategory.Text)

                            displayAllProduct(cboCategory.Text)
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Product Code already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCategory.SelectAll()
                        cboCategory.Focus()
                    End If
                Else
                    MsgBox("Product code length must not be less than to six (6) codes", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCategory.SelectAll()
                    cboCategory.Focus()
                End If
            Case "&Save "
                If lblCode.Text.Length >= 4 And validateFields() Then
                    If validateProduct(lblCode.Text) And cmd.Text = "&Save " Then 'If Not validateProduct(lblCode.Text) Then
                        reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            updateProduct(lblID.Text, lblCode.Text, cboPS.Text, cboMedia.Text, cboSpecie.Text, _
                                    cboCanSize.Text, cboFL.Text, cboCleaning.Text, cboCategory.Text, cboPeriod.Text, _
                                    txtOil.Text, txtWater.Text, txtSalt.Text, txtChili.Text, txtCurry.Text, _
                                    txtBroth.Text, txtMsg.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)
                            validatePackType(cboCategory.Text)

                            displayAllProduct(cboCategory.Text)
                            'displayDefects()
                            MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Product Code already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCategory.SelectAll()
                        cboCategory.Focus()
                    End If
                Else
                    MsgBox("Product code length must not be less than to six (6) codes", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCategory.SelectAll()
                    cboCategory.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not lblCode.Text = "" And Not lblID.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    validatePackType(cboCategory.Text)
                    cboCategory.SelectAll()
                    cboCategory.Focus()
                Else
                    MsgBox("Product Code doesn't exists.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCategory.SelectAll()
                    cboCategory.Focus()
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                dataEntry(1)
                validatePackType(cboCategory.Text)
                cmdEdit.Focus()
        End Select
    End Sub

    Public Sub searchProductDetails(ByVal product As String, ByVal category As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim qry As String
            If category.StartsWith("Can") Then
                qry = "proc_display_Product_CannedTuna"
            Else
                qry = "proc_display_Product_FrozenLoins"
            End If

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = qry
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@pCode"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = product

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    If category.StartsWith("Can") Then
                        cboPS.Text = dr.GetString(2)
                        cboMedia.Text = dr.GetString(3)
                        cboSpecie.Text = dr.GetString(4)
                        cboCanSize.Text = dr.GetString(5)
                        'cboFL.Text = dr.GetString(6)
                        cboCleaning.Text = ""
                        'cboPeriod.Text = dr.GetString(7)

                        txtOil.Text = dr.GetDouble(6)
                        txtWater.Text = dr.GetDouble(7)
                        txtSalt.Text = dr.GetDouble(8)
                        txtChili.Text = dr.GetDouble(9)
                        txtCurry.Text = dr.GetDouble(10)
                        txtBroth.Text = dr.GetDouble(11)
                        txtMsg.Text = dr.GetDouble(12)
                    Else
                        cboPS.Text = dr.GetString(2)
                        cboMedia.Text = ""
                        cboSpecie.Text = dr.GetString(3)
                        cboCanSize.Text = dr.GetString(4)
                        cboFL.Text = dr.GetString(5)
                        'cboCleaning.Text = dr.GetString(6)
                        'cboPeriod.Text = dr.GetString(7)

                        txtOil.Text = "0"
                        txtWater.Text = "0"
                        txtSalt.Text = "0"
                        txtChili.Text = "0"
                        txtCurry.Text = "0"
                        txtBroth.Text = "0"
                        txtMsg.Text = "0"
                    End If
                Else
                    cboPS.Text = ""
                    cboMedia.Text = ""
                    cboSpecie.Text = ""
                    cboCanSize.Text = ""
                    cboFL.Text = ""
                    cboCleaning.Text = ""
                    cboPeriod.Text = ""
                End If
            Else
                cboPS.Text = ""
                cboMedia.Text = ""
                cboSpecie.Text = ""
                cboCanSize.Text = ""
                cboFL.Text = ""
                cboCleaning.Text = ""
                cboPeriod.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboPeriod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriod.TextChanged
        showProductCode(cboCategory.Text)
    End Sub

    Public Function validateFields() As Boolean
        If cboCategory.Text.StartsWith("Can") Then
            If Not cboPS.Text.Trim = "" And Not cboMedia.Text.Trim = "" And Not cboSpecie.Text.Trim = "" And Not cboCanSize.Text.Trim = "" Then
                Return True
            Else
                Return False
            End If
        Else
            If Not cboPS.Text.Trim = "" And Not cboSpecie.Text.Trim = "" And Not cboCanSize.Text.Trim = "" And Not cboFL.Text.Trim = "" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub mnuPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPS.Click
        Dim f As New frmProdPackStyle()
        f.ShowDialog(Me)

        displayPS(cboCategory.Text)
        cboPS.SelectAll()
        cboPS.Focus()
    End Sub

    Private Sub mnuMedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedia.Click
        Dim f As New frmProdMedia()
        f.ShowDialog(Me)

        displayMedia()
        cboMedia.SelectAll()
        cboMedia.Focus()
    End Sub

    Private Sub mnuSpecie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSpecie.Click
        Dim f As New frmProdSpecie()
        f.ShowDialog(Me)

        displaySpecie()
        cboSpecie.SelectAll()
        cboSpecie.Focus()
    End Sub

    Private Sub mnuCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCan.Click
        Dim f As New frmProdCanSize()
        f.ShowDialog(Me)

        displayCanSize(cboCategory.Text)
        cboCanSize.SelectAll()
        cboCanSize.Focus()
    End Sub

    Private Sub mnuFL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFL.Click
        Dim f As New frmProdFillerLine()
        f.ShowDialog(Me)

        displayFL(cboCategory.Text)
        cboFL.SelectAll()
        cboFL.Focus()
    End Sub

    Private Sub mnuCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCleaning.Click
        Dim f As New frmProdCleaning()
        f.ShowDialog(Me)

        displayCleaning()
        cboCleaning.SelectAll()
        cboCleaning.Focus()
    End Sub

    Private Sub mnuPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPeriod.Click
        Dim f As New frmProdPeriod()
        f.ShowDialog(Me)

        displayPeriod()
        cboPeriod.SelectAll()
        cboPeriod.Focus()
    End Sub

    Private Sub mnuFishSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFishSize.Click
        Dim f As New frmProdCanSize()
        f.Label1.Text = "Fish Size"
        f.displayCategory()
        f.displayAllCanSize(cboCategory.Text)
        f.cboCategory.Text = cboCategory.Text
        f.cboCategory.Enabled = False
        f.ShowDialog(Me)

        displayCanSize(cboCategory.Text)
        cboCanSize.SelectAll()
        cboCanSize.Focus()
    End Sub

    Private Sub mnuLoinSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLoinSize.Click
        Dim f As New frmProdLoinSize()
        f.ShowDialog(Me)

        displayFL(cboCategory.Text)
        cboFL.SelectAll()
        cboFL.Focus()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Product Code"
        f.searchType = 1
        f.displayAllProductCodes()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblID.Text = .Item(.Row, 0)
                cboCategory.Text = .Item(.Row, 2)
                lblCode.Text = .Item(.Row, 1)

                validatePackType(cboCategory.Text)
                searchProductDetails(lblCode.Text, cboCategory.Text)
            End If
        End With
    End Sub

    Private Sub cmdAClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAClose.Click
        showValidationMenu(False)
    End Sub

    Private Sub cmdASave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdASave.Click
        If validateOverrideAccount(txtUsername.Text, txtPassword.Text) Then
            Dim reply As String
            reply = MsgBox("Are you sure you want to delete this product code " & lblCode.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then
                deleteProductCode(lblCode.Text)
                addNewRecord()

                MsgBox("You have successfully delete the product code", MsgBoxStyle.Information, "Information")
                showValidationMenu(False)
                cmdClose.Focus()
            End If
        Else
            MsgBox("You have an invalid account.  For assistance, please call your supervisor", MsgBoxStyle.Exclamation, "Access denied")
            cmdAClose.Focus()
        End If
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

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Not lblCode.Text = "" Then
            showValidationMenu(True)
        Else
            MsgBox("Please identify the product code before you can proceed on this transaction!", MsgBoxStyle.Exclamation, "Warning")
            cmdFind.Focus()
        End If
    End Sub

    Private Sub txtOil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOil.TextChanged
        If Not IsNumeric(txtOil.Text) Or txtOil.Text = "" Then
            txtOil.Text = "0"
            txtOil.SelectAll()
            txtOil.Focus()
        End If
    End Sub

    Private Sub txtWater_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWater.TextChanged
        If Not IsNumeric(txtWater.Text) Or txtWater.Text = "" Then
            txtWater.Text = "0"
            txtWater.SelectAll()
            txtWater.Focus()
        End If
    End Sub

    Private Sub txtSalt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalt.TextChanged
        If Not IsNumeric(txtSalt.Text) Or txtSalt.Text = "" Then
            txtSalt.Text = "0"
            txtSalt.SelectAll()
            txtSalt.Focus()
        End If
    End Sub

    Private Sub txtChili_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChili.TextChanged
        If Not IsNumeric(txtChili.Text) Or txtChili.Text = "" Then
            txtChili.Text = "0"
            txtChili.SelectAll()
            txtChili.Focus()
        End If
    End Sub

    Private Sub txtCurry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurry.TextChanged
        If Not IsNumeric(txtCurry.Text) Or txtCurry.Text = "" Then
            txtCurry.Text = "0"
            txtCurry.SelectAll()
            txtCurry.Focus()
        End If
    End Sub

    Private Sub txtBroth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBroth.TextChanged
        If Not IsNumeric(txtBroth.Text) Or txtBroth.Text = "" Then
            txtBroth.Text = "0"
            txtBroth.SelectAll()
            txtBroth.Focus()
        End If
    End Sub

    Private Sub txtMsg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMsg.TextChanged
        If Not IsNumeric(txtMsg.Text) Or txtMsg.Text = "" Then
            txtMsg.Text = "0"
            txtMsg.SelectAll()
            txtMsg.Focus()
        End If
    End Sub

    Private Sub cboCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPS.SelectAll()
            cboPS.Focus()
        End If
    End Sub

    Private Sub cboPS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPS.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboMedia.SelectAll()
            cboMedia.Focus()
        End If
    End Sub

    Private Sub cboMedia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMedia.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSpecie.SelectAll()
            cboSpecie.Focus()
        End If
    End Sub

    Private Sub cboSpecie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSpecie.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCanSize.SelectAll()
            cboCanSize.Focus()
        End If
    End Sub

    Private Sub cboCanSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCanSize.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboFL.SelectAll()
            cboFL.Focus()
        End If
    End Sub

    Private Sub cboFL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFL.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCleaning.SelectAll()
            cboCleaning.Focus()
        End If
    End Sub

    Private Sub cboCleaning_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCleaning.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPeriod.SelectAll()
            cboPeriod.Focus()
        End If
    End Sub

    Private Sub cboPeriod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPeriod.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd.Focus()
        End If
    End Sub
End Class
