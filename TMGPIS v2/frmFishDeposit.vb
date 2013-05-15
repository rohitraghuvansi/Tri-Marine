Public Class frmFishDeposit
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboFishSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents cboFishWeight As C1.Win.C1List.C1Combo
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTare As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents chkDummy As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuFB As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMCS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFL As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFS As System.Windows.Forms.MenuItem
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishDeposit))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkDummy = New System.Windows.Forms.CheckBox()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblTare = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.cboFishWeight = New C1.Win.C1List.C1Combo()
        Me.cboFishSpecie = New C1.Win.C1List.C1Combo()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cboCS = New C1.Win.C1List.C1Combo()
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboBin = New C1.Win.C1List.C1Combo()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuFB = New System.Windows.Forms.MenuItem()
        Me.mnuMCS = New System.Windows.Forms.MenuItem()
        Me.mnuMFL = New System.Windows.Forms.MenuItem()
        Me.mnuMFS = New System.Windows.Forms.MenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.cboFishWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFishSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1})
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(4, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(676, 266)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkDummy, Me.lblNet, Me.lblTare, Me.txtWeight, Me.cboFishWeight, Me.cboFishSpecie, Me.cboLot, Me.txtRemarks, Me.cboCS, Me.txtDate, Me.cboBin, Me.Label11, Me.Label7, Me.Label8, Me.Label9, Me.Label1, Me.Label2, Me.Label4, Me.Label3, Me.Label5, Me.Label6})
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(668, 237)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fish Deposit Details"
        '
        'chkDummy
        '
        Me.chkDummy.Enabled = False
        Me.chkDummy.Location = New System.Drawing.Point(272, 10)
        Me.chkDummy.Name = "chkDummy"
        Me.chkDummy.Size = New System.Drawing.Size(112, 24)
        Me.chkDummy.TabIndex = 42
        Me.chkDummy.TabStop = False
        Me.chkDummy.Text = "&Dummy Bin"
        Me.chkDummy.Visible = False
        '
        'lblNet
        '
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNet.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.Location = New System.Drawing.Point(504, 192)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(152, 32)
        Me.lblNet.TabIndex = 41
        Me.lblNet.Text = "0"
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTare
        '
        Me.lblTare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTare.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTare.Location = New System.Drawing.Point(504, 152)
        Me.lblTare.Name = "lblTare"
        Me.lblTare.Size = New System.Drawing.Size(152, 32)
        Me.lblTare.TabIndex = 40
        Me.lblTare.Text = "0"
        Me.lblTare.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(504, 104)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(152, 40)
        Me.txtWeight.TabIndex = 39
        Me.txtWeight.Text = "0"
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboFishWeight
        '
        Me.cboFishWeight.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboFishWeight.AllowColMove = False
        Me.cboFishWeight.AutoCompletion = True
        Me.cboFishWeight.AutoDropDown = True
        Me.cboFishWeight.Caption = ""
        Me.cboFishWeight.CaptionHeight = 17
        Me.cboFishWeight.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFishWeight.ColumnCaptionHeight = 17
        Me.cboFishWeight.ColumnFooterHeight = 17
        Me.cboFishWeight.ContentHeight = 18
        Me.cboFishWeight.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboFishWeight.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboFishWeight.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishWeight.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFishWeight.EditorHeight = 18
        Me.cboFishWeight.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboFishWeight.ItemHeight = 20
        Me.cboFishWeight.Location = New System.Drawing.Point(504, 72)
        Me.cboFishWeight.MatchEntryTimeout = CType(2000, Long)
        Me.cboFishWeight.MaxDropDownItems = CType(20, Short)
        Me.cboFishWeight.MaxLength = 32767
        Me.cboFishWeight.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboFishWeight.Name = "cboFishWeight"
        Me.cboFishWeight.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFishWeight.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboFishWeight.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFishWeight.Size = New System.Drawing.Size(152, 24)
        Me.cboFishWeight.TabIndex = 38
        Me.cboFishWeight.Text = "0"
        Me.cboFishWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cboFishWeight.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboFishSpecie.ContentHeight = 18
        Me.cboFishSpecie.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboFishSpecie.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboFishSpecie.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFishSpecie.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFishSpecie.EditorHeight = 18
        Me.cboFishSpecie.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.cboFishSpecie.ItemHeight = 20
        Me.cboFishSpecie.Location = New System.Drawing.Point(504, 40)
        Me.cboFishSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboFishSpecie.MaxDropDownItems = CType(20, Short)
        Me.cboFishSpecie.MaxLength = 32767
        Me.cboFishSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboFishSpecie.Name = "cboFishSpecie"
        Me.cboFishSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFishSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboFishSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFishSpecie.Size = New System.Drawing.Size(152, 24)
        Me.cboFishSpecie.TabIndex = 37
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
        Me.cboLot.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(504, 8)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(152, 24)
        Me.cboLot.TabIndex = 36
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
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(136, 104)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(224, 120)
        Me.txtRemarks.TabIndex = 35
        Me.txtRemarks.Text = ""
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
        Me.cboCS.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(136, 72)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(20, Short)
        Me.cboCS.MaxLength = 32767
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.Size = New System.Drawing.Size(224, 24)
        Me.cboCS.TabIndex = 34
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(136, 41)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(224, 23)
        Me.txtDate.TabIndex = 33
        Me.txtDate.TabStop = False
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboBin.Images.Add(CType(resources.GetObject("resource.Images4"), System.Drawing.Bitmap))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(136, 8)
        Me.cboBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboBin.MaxDropDownItems = CType(20, Short)
        Me.cboBin.MaxLength = 32767
        Me.cboBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBin.Name = "cboBin"
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.Size = New System.Drawing.Size(128, 24)
        Me.cboBin.TabIndex = 32
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(408, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Net Weight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(408, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Tare Weight"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(408, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Gross Weight"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(408, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Fish Size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Cold Storage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(408, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Fish Specie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Lot#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Bin Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Date/Time Deposited"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(465, 328)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 21
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(385, 328)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 20
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(305, 328)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 19
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Bitmap)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(225, 328)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 18
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Bitmap)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(145, 328)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(685, 40)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Fish Deposit Information"
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(528, 328)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(152, 48)
        Me.lblCode.TabIndex = 41
        Me.lblCode.Text = "FD000000123"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCode.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFB, Me.mnuMCS, Me.mnuMFL, Me.mnuMFS})
        '
        'mnuFB
        '
        Me.mnuFB.Index = 0
        Me.mnuFB.Text = "Fish &Bins"
        '
        'mnuMCS
        '
        Me.mnuMCS.Index = 1
        Me.mnuMCS.Text = "&Cold Storage"
        '
        'mnuMFL
        '
        Me.mnuMFL.Index = 2
        Me.mnuMFL.Text = "Fish &Lots"
        '
        'mnuMFS
        '
        Me.mnuMFS.Index = 3
        Me.mnuMFS.Text = "&Fish Specie"
        '
        'frmFishDeposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(685, 384)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label13, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdNew, Me.cmdSave, Me.TabControl1, Me.lblCode})
        Me.Name = "frmFishDeposit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishDeposit"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.cboFishWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFishSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()
        'Me.TabControl1.TabPages(0).Enabled = False
        'Me.TabControl1.TabPages(0).Visible = False

        'displayAllFishDeposits()
        displayFishBins()
        displayColdStorage()
        displayBatchlot()
        displayFishSpecie()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Public Sub displayAllFishDeposits()
    '    With grid
    '        .DataSource = modModule.getAllFishDeposits().Tables(0)
    '        .Columns(2).NumberFormat = "##0.#0"
    '        .Splits(0).DisplayColumns(0).Width = 125
    '        .Splits(0).DisplayColumns(1).Width = 125
    '        .Splits(0).DisplayColumns(2).Width = 118
    '    End With
    'End Sub

    Public Sub displayFishBins()
        With cboBin
            .DataSource = modModule.getFishBins().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 106
        End With
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
        End With
    End Sub

    Public Sub displayBatchlot()
        With cboLot
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130
        End With
    End Sub

    Public Sub displayFishSpecie()
        With cboFishSpecie
            .DataSource = modModule.getFishSpecie().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130
        End With
    End Sub

    Public Sub displayFishSpecieSizes(ByVal specie As String)
        With cboFishWeight
            .DataSource = modModule.getFishSpecieSizes(specie).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboFishSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFishSpecie.TextChanged
        displayFishSpecieSizes(cboFishSpecie.Text)
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
        cboBin.SelectAll()
        cboBin.Focus()
    End Sub

    Public Sub addNewRecord()
        chkDummy.Checked = False
        displayFishBins()
        cboBin.Text = ""
        txtDate.Value = getServerDateTime()
        displayColdStorage()
        cboCS.Text = ""
        txtRemarks.Text = ""
        displayBatchlot()
        cboLot.Text = ""
        displayFishSpecie()
        cboFishSpecie.Text = ""
        cboFishWeight.Text = ""
        txtWeight.Text = 0
        lblTare.Text = "0"
        lblNet.Text = "0"
    End Sub

    Public Sub computeNetWeight(ByVal gross As Double, ByVal tare As Double)
        lblNet.Text = Format(gross - tare, "###,###,##0.#0")
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged
        If Not IsNumeric(txtWeight.Text) Or txtWeight.Text = "" Then
            txtWeight.Text = "0.00"
            txtWeight.SelectAll()
            txtWeight.Focus()
        Else
            computeNetWeight(txtWeight.Text, lblTare.Text)
        End If
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        lblTare.Text = Format(getFishBinTareWeight(cboBin.Text), "###,###,##0.#0")
        computeNetWeight(txtWeight.Text, lblTare.Text)

        displayRecord(cboBin.Text)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String
        'Select Case cmd.Text
        '    Case "&Save"
        If Not cboBin.Text.Trim = "" And Not cboCS.Text.Trim = "" And Not cboLot.Text.Trim = "" And _
        Not cboFishSpecie.Text.Trim = "" And Not cboFishWeight.Text.Trim = "" Then
            If Not validateFishBinsFromDepositInventory(cboBin.Text) Then
                reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    saveNewFishBinForDeposit(cboBin.Text, txtDate.Text, cboCS.Text, txtRemarks.Text.Trim, _
                        cboLot.Text, cboFishSpecie.Text, CDbl(cboFishWeight.Text), CDbl(txtWeight.Text))

                    MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                Else
                    cboBin.SelectAll()
                    cboBin.Focus()
                    Exit Sub
                End If
            Else
                reply = MsgBox("Fish bins haven't yet withdrawn from the cold storage, " & Chr(13) & _
                    "but if you want to update the existing record, please click YES.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    updateFishBinForDeposits(lblCode.Text, cboBin.Text, txtDate.Text, cboCS.Text, _
                        txtRemarks.Text.Trim, cboLot.Text, cboFishSpecie.Text, CDbl(cboFishWeight.Text), _
                        CDbl(txtWeight.Text), 1)

                    MsgBox("You have successfully update the existing record.", MsgBoxStyle.Information, "Information")
                Else
                    cboBin.SelectAll()
                    cboBin.Focus()
                    Exit Sub
                End If
            End If

            'displayAllFishDeposits()
            addNewRecord()
            cboBin.SelectAll()
            cboBin.Focus()
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
    ByVal remarks As String, ByVal lot As String, ByVal fishSpecie As String, ByVal fishWeight As Double, _
    ByVal grossWeight As Double)
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
            p5.ParameterName = "@fishCode"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = getFishSpecieCode(fishSpecie, fishWeight)

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

    Public Sub displayRecord(ByVal bin As String)
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

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    txtDate.Value = dr.GetDateTime(0)
                    cboCS.Text = dr.GetString(1)
                    txtRemarks.Text = dr.GetString(2)
                    cboLot.Text = dr.GetString(3)
                    cboFishSpecie.Text = dr.GetString(4)
                    cboFishWeight.Text = dr.GetDouble(5)
                    txtWeight.Text = dr.GetDouble(6)
                    lblCode.Text = dr.GetString(9)
                Else
                    txtDate.Value = Format(getServerDateTime(), getTimeFormat())
                    cboCS.Text = ""
                    txtRemarks.Text = ""
                    cboLot.Text = ""
                    cboFishSpecie.Text = ""
                    cboFishWeight.Text = ""
                    txtWeight.Text = "0.00"
                    lblCode.Text = ""
                End If
            Else
                txtDate.Value = Format(getServerDateTime(), getTimeFormat())
                cboCS.Text = ""
                txtRemarks.Text = ""
                cboLot.Text = ""
                cboFishSpecie.Text = ""
                cboFishWeight.Text = ""
                txtWeight.Text = "0.00"
                lblCode.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            'MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Private Sub mnuFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFB.Click
        Dim f As New frmFishBin()
        f.ShowDialog(Me)

        displayFishBins()
        cboBin.SelectAll()
        cboBin.Focus()
    End Sub

    Private Sub mnuMCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMCS.Click

    End Sub

    Private Sub mnuMFL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFL.Click
        Dim f As New frmBatchlot()
        f.ShowDialog(Me)

        displayBatchlot()
        cboLot.SelectAll()
        cboLot.Focus()
    End Sub

    Private Sub mnuMFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFS.Click
        Dim f As New frmSpecie2()
        f.ShowDialog(Me)

        displayFishSpecie()
        cboFishSpecie.SelectAll()
        cboFishSpecie.Focus()
    End Sub

    Private Sub cboFishWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFishWeight.TextChanged
        If Not IsNumeric(cboFishWeight.Text) Or cboFishWeight.Text = "" Then
            cboFishWeight.Text = "0"
            'cboFishWeight.SelectAll()
            'cboFishWeight.Focus()
        End If
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Fish Deposit"
        f.searchType = 2
        f.displayAllFishDeposits()
        f.ShowDialog(Me)

        If Not f.cancel Then cboBin.Text = f.searchItem
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click

    End Sub
End Class
