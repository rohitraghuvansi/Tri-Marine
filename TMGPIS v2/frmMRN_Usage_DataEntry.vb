Public Class frmMRN_Usage_DataEntry
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
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblUsage As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMaterials As C1.Win.C1List.C1Combo
    Friend WithEvents cboMRN As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMaterials2 As C1.Win.C1List.C1Combo
    Friend WithEvents cmdHistory As System.Windows.Forms.Button
    Friend WithEvents grid2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblUsage2 As System.Windows.Forms.Label
    Friend WithEvents txtUsage As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMRN_Usage_DataEntry))
        Me.cboShift = New C1.Win.C1List.C1Combo
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit
        Me.cboMaterials = New C1.Win.C1List.C1Combo
        Me.cboMRN = New C1.Win.C1List.C1Combo
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdHistory = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblBalance = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblUsage = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblUsage2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.grid2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboMaterials2 = New C1.Win.C1List.C1Combo
        Me.txtUsage = New C1.Win.C1Input.C1NumericEdit
        Me.cmdDelete = New System.Windows.Forms.Button
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMRN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterials2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cboShift.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(96, 86)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(10, Short)
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(96, 54)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(160, 23)
        Me.txtProdnDate.TabIndex = 0
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboMaterials.Location = New System.Drawing.Point(96, 119)
        Me.cboMaterials.MatchEntryTimeout = CType(2000, Long)
        Me.cboMaterials.MaxDropDownItems = CType(15, Short)
        Me.cboMaterials.MaxLength = 32767
        Me.cboMaterials.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMaterials.Name = "cboMaterials"
        Me.cboMaterials.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMaterials.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMaterials.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMaterials.Size = New System.Drawing.Size(336, 24)
        Me.cboMaterials.TabIndex = 2
        Me.cboMaterials.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboMRN
        '
        Me.cboMRN.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboMRN.AllowColMove = False
        Me.cboMRN.AutoCompletion = True
        Me.cboMRN.AutoDropDown = True
        Me.cboMRN.Caption = ""
        Me.cboMRN.CaptionHeight = 17
        Me.cboMRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMRN.ColumnCaptionHeight = 17
        Me.cboMRN.ColumnFooterHeight = 17
        Me.cboMRN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboMRN.ContentHeight = 18
        Me.cboMRN.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboMRN.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboMRN.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMRN.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMRN.EditorHeight = 18
        Me.cboMRN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMRN.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboMRN.ItemHeight = 20
        Me.cboMRN.Location = New System.Drawing.Point(96, 152)
        Me.cboMRN.MatchEntryTimeout = CType(2000, Long)
        Me.cboMRN.MaxDropDownItems = CType(15, Short)
        Me.cboMRN.MaxLength = 32767
        Me.cboMRN.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMRN.Name = "cboMRN"
        Me.cboMRN.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMRN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMRN.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMRN.Size = New System.Drawing.Size(336, 24)
        Me.cboMRN.TabIndex = 3
        Me.cboMRN.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(550, 512)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(77, 48)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdHistory
        '
        Me.cmdHistory.Enabled = False
        Me.cmdHistory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistory.Image = CType(resources.GetObject("cmdHistory.Image"), System.Drawing.Image)
        Me.cmdHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdHistory.Location = New System.Drawing.Point(430, 512)
        Me.cmdHistory.Name = "cmdHistory"
        Me.cmdHistory.Size = New System.Drawing.Size(117, 48)
        Me.cmdHistory.TabIndex = 8
        Me.cmdHistory.Text = "&History Trans"
        Me.cmdHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(269, 512)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(77, 48)
        Me.cmdFind.TabIndex = 7
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(189, 512)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(77, 48)
        Me.cmdEdit.TabIndex = 6
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(109, 512)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(77, 48)
        Me.cmd.TabIndex = 5
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBalance)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblUsage)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(512, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 159)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Details"
        Me.GroupBox1.Visible = False
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(80, 101)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(128, 24)
        Me.lblBalance.TabIndex = 112
        Me.lblBalance.Text = "0.00"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 19)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Balance"
        '
        'lblUsage
        '
        Me.lblUsage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsage.Location = New System.Drawing.Point(80, 69)
        Me.lblUsage.Name = "lblUsage"
        Me.lblUsage.Size = New System.Drawing.Size(128, 24)
        Me.lblUsage.TabIndex = 110
        Me.lblUsage.Text = "0.00"
        Me.lblUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 19)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Usage"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(80, 37)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(128, 24)
        Me.lblTotal.TabIndex = 108
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 19)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Received"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 240)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(719, 264)
        Me.grid.TabIndex = 109
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Tahoma, 9.75pt;}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}He" & _
        "ading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTex" & _
        "t;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}S" & _
        "tyle9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""Fals" & _
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" M" & _
        "arqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>260</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 715, 260</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 715, 260</ClientArea><PrintPageHeaderStyle parent" & _
        "="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 19)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "MRN Usage Table"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "MRN No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Total Usage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Materials"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 19)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Shift"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Prod'n Date"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(737, 40)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Material Usages"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUsage2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.grid2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboMaterials2)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 519)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Click here to close the history X"
        Me.GroupBox2.Visible = False
        '
        'lblUsage2
        '
        Me.lblUsage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsage2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsage2.Location = New System.Drawing.Point(96, 53)
        Me.lblUsage2.Name = "lblUsage2"
        Me.lblUsage2.Size = New System.Drawing.Size(208, 32)
        Me.lblUsage2.TabIndex = 119
        Me.lblUsage2.Text = "0.00"
        Me.lblUsage2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 19)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Total Usages"
        '
        'grid2
        '
        Me.grid2.AllowColMove = False
        Me.grid2.AllowUpdate = False
        Me.grid2.CaptionHeight = 17
        Me.grid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grid2.FilterBar = True
        Me.grid2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid2.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid2.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.grid2.Location = New System.Drawing.Point(3, 92)
        Me.grid2.Name = "grid2"
        Me.grid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid2.PreviewInfo.ZoomFactor = 75
        Me.grid2.RowHeight = 20
        Me.grid2.Size = New System.Drawing.Size(722, 424)
        Me.grid2.TabIndex = 117
        Me.grid2.Text = "C1TrueDBGrid1"
        Me.grid2.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Tahoma, 9.75pt;}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}He" & _
        "ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" & _
        ";BackColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}S" & _
        "tyle1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""Fals" & _
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" F" & _
        "ilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecS" & _
        "elWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>420</Heig" & _
        "ht><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=" & _
        """Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""" & _
        "FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle" & _
        " parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><Hig" & _
        "hLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inacti" & _
        "ve"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyl" & _
        "e parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""St" & _
        "yle6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 718, 420</ClientR" & _
        "ect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDB" & _
        "Grid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style paren" & _
        "t=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""H" & _
        "eading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""No" & _
        "rmal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal" & _
        """ me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Norma" & _
        "l"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""No" & _
        "rmal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertS" & _
        "plits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSe" & _
        "lWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 718, 420</ClientArea><PrintPageH" & _
        "eaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15""" & _
        " /></Blob>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Materials"
        '
        'cboMaterials2
        '
        Me.cboMaterials2.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboMaterials2.AllowColMove = False
        Me.cboMaterials2.AutoCompletion = True
        Me.cboMaterials2.AutoDropDown = True
        Me.cboMaterials2.Caption = ""
        Me.cboMaterials2.CaptionHeight = 17
        Me.cboMaterials2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMaterials2.ColumnCaptionHeight = 17
        Me.cboMaterials2.ColumnFooterHeight = 17
        Me.cboMaterials2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboMaterials2.ContentHeight = 18
        Me.cboMaterials2.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboMaterials2.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboMaterials2.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterials2.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMaterials2.EditorHeight = 18
        Me.cboMaterials2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterials2.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboMaterials2.ItemHeight = 20
        Me.cboMaterials2.Location = New System.Drawing.Point(96, 24)
        Me.cboMaterials2.MatchEntryTimeout = CType(2000, Long)
        Me.cboMaterials2.MaxDropDownItems = CType(15, Short)
        Me.cboMaterials2.MaxLength = 32767
        Me.cboMaterials2.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMaterials2.Name = "cboMaterials2"
        Me.cboMaterials2.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMaterials2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMaterials2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMaterials2.Size = New System.Drawing.Size(336, 24)
        Me.cboMaterials2.TabIndex = 115
        Me.cboMaterials2.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtUsage
        '
        Me.txtUsage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsage.Location = New System.Drawing.Point(96, 184)
        Me.txtUsage.Name = "txtUsage"
        Me.txtUsage.Size = New System.Drawing.Size(160, 23)
        Me.txtUsage.TabIndex = 4
        Me.txtUsage.Tag = Nothing
        Me.txtUsage.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(349, 512)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(77, 48)
        Me.cmdDelete.TabIndex = 119
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmMRN_Usage_DataEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(737, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.txtUsage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdHistory)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.cboMRN)
        Me.Controls.Add(Me.cboMaterials)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtProdnDate)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMRN_Usage_DataEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMRN_Usage_DataEntry"
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMRN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterials2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMRN_Usage_DataEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtProdnDate.Value = getServerDateTime()
        initializeShift()
        enableDataEntry(False)
        displayAllMaterials()
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
            .Splits(0).DisplayColumns(0).Width = 138
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayAllMaterials()
        With cboMaterials
            .DataSource = modModule.getAllMaterials().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 314
        End With

        With cboMaterials2
            .DataSource = modModule.getAllMaterials().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 314
        End With
    End Sub

    Public Sub displayAllMaterials(ByVal materials As String)
        With cboMRN
            .DataSource = modModule.getAllMRNNoPerMaterials(materials).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
            .Splits(0).DisplayColumns(1).Width = 100
            .Splits(0).DisplayColumns(2).Width = 150

            .Text = ""
            If .ListCount > 0 Then
                .SelectedIndex = 0
            End If
        End With
    End Sub

    Private Sub cboMaterials_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMaterials.TextChanged
        If cboMaterials.Text = "" Then If cboMaterials.ListCount > 0 Then cboMaterials.SelectedIndex = 0

        displayMRNNo(cboMaterials.Text)
        'txtUsage.Text = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, cboMRN.Text)
        'displayAllMaterials(cboMaterials.Text)
    End Sub

    Private Sub cboMRN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMRN.TextChanged
        'If cboMRN.Text = "" Then If cboMRN.ListCount > 0 Then cboMRN.SelectedIndex = 0

        'txtUsage.Text = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, cboMRN.Text)
        'displayInventory(cboMRN.Text)
    End Sub

    Public Sub displayRecords(ByVal prodnDate As String, ByVal shift As String)
        With grid
            .DataSource = getAllMaterialsByProdnDate(prodnDate, shift).Tables(0)  'getAllMRNNoByProdnDate(prodnDate, shift).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 90
            .Splits(0).DisplayColumns(1).Width = 50
            .Splits(0).DisplayColumns(2).Width = 435 '175
            .Splits(0).DisplayColumns(3).Width = 100 '260
            '.Splits(0).DisplayColumns(4).Width = 100
            .Columns(3).NumberFormat = "###,###,##0.#0"
        End With
    End Sub

    Public Sub enableDataEntry(ByVal yes As Boolean)
        If yes Then
            txtProdnDate.ReadOnly = False
            cboShift.ReadOnly = False
            cboMaterials.ReadOnly = False
            cboMRN.ReadOnly = False
            txtUsage.ReadOnly = False
        Else
            txtProdnDate.ReadOnly = True
            cboShift.ReadOnly = True
            cboMaterials.ReadOnly = True
            cboMRN.ReadOnly = True
            txtUsage.ReadOnly = True
        End If
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                buttons(0)
                enableDataEntry(True)
                addNewRecord()
                txtProdnDate.Focus()
            Case "&Save"
                'Not cboMRN.Text.Trim = "" And
                If Not cboMaterials.Text.Trim = "" And _
                Not txtUsage.Text.Trim = "" And Not txtUsage.Text = "0" Then 'And CDbl(lblBalance.Text) > 0 Then
                    'If Not validateMRNUsage(txtProdnDate.Text, cboShift.Text.Trim, cboMRN.Text.Trim) Then
                    If Not validateMaterialUsages(txtProdnDate.Text, cboShift.Text.Trim, cboMaterials.Text.Trim) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            'saveNewMRN_Usage(txtProdnDate.Text, cboShift.Text, cboMRN.Text, txtUsage.Text)
                            saveNewMaterialUsages(txtProdnDate.Text, cboShift.Text, cboMaterials.Text, txtUsage.Text, cboMRN.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            enableDataEntry(False)

                            displayRecords(txtProdnDate.Text, cboShift.Text)
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Material usages already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboMRN.SelectAll()
                        cboMRN.Focus()
                    End If
                Else
                    MsgBox("Please review the details of the materials to be modify such as the quantity and the inventory", MsgBoxStyle.Critical, "Result: Invalid data")
                    txtProdnDate.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    'updateMRN_Usage(txtProdnDate.Text, cboShift.Text, cboMRN.Text, txtUsage.Text)
                    updateMaterialUsages(txtProdnDate.Text, cboShift.Text, cboMaterials.Text, txtUsage.Text, cboMRN.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    enableDataEntry(False)

                    displayRecords(txtProdnDate.Text, cboShift.Text)
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboMaterials.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    enableDataEntry(True)
                    'cboMRN.ReadOnly = True
                    txtProdnDate.ReadOnly = True
                    cboShift.ReadOnly = True
                    cboMaterials.ReadOnly = True
                    txtUsage.SelectAll()
                    txtUsage.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtProdnDate.Focus()
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                enableDataEntry(False)
                cmdEdit.Focus()
        End Select
    End Sub

    Public Sub buttons(ByVal i As Integer)
        Select Case i
            Case 0
                'Me.cmdHistory.Enabled = False
                Me.cmdFind.Enabled = False
                cmdDelete.Enabled = False
                Me.cmdClose.Enabled = False
            Case 1
                'Me.cmdHistory.Enabled = True
                Me.cmdFind.Enabled = True
                cmdDelete.Enabled = True
                Me.cmdClose.Enabled = True
        End Select
    End Sub

    Public Sub addNewRecord()
        'cboMRN.ReadOnly = False
        txtProdnDate.ReadOnly = False
        cboShift.ReadOnly = False
        cboMaterials.ReadOnly = False
        txtProdnDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        displayAllMaterials()
        cboMRN.Text = ""
        txtUsage.Value = "0"
        displayRecords(txtProdnDate.Text, cboShift.Text)
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        displayRecords(txtProdnDate.Text, cboShift.Text)
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

        displayRecords(txtProdnDate.Text, cboShift.Text)
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Materials Usage"
        f.searchType = 1
        'f.displayAllMRN_Usage()
        f.displayAllMaterialUsages()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                txtProdnDate.Value = .Item(.Row, 0)
                cboShift.Text = .Item(.Row, 1)
                cboMaterials.Text = .Item(.Row, 2)
                'cboMRN.Text = .Item(.Row, 2)
                txtUsage.Value = .Item(.Row, 3)
            End If
        End With
    End Sub

    Private Sub txtUsage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not IsNumeric(txtUsage.Text) Or txtUsage.Text.Trim = "" Then
            txtUsage.Text = "0"
            txtUsage.SelectAll()
            txtUsage.Focus()
        End If
    End Sub

    Public Sub displayInventory(ByVal mrn As String)
        lblTotal.Text = Format(getMaterialsInventoryCount(mrn, "bal"), "###,###,###,##0.#0")
        lblUsage.Text = Format(getMaterialsInventoryCount(mrn, "usage"), "###,###,###,##0.#0")
        lblBalance.Text = Format(lblTotal.Text - lblUsage.Text, "###,###,###,##0.#0")
    End Sub

    Private Sub cboMaterials2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMaterials2.TextChanged
        With grid2
            .DataSource = getAllMRNUsageHistory(cboMaterials2.Text).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 180
            .Splits(0).DisplayColumns(1).Width = 80
            .Splits(0).DisplayColumns(2).Width = 120
            .Splits(0).DisplayColumns(3).Width = 85
            .Splits(0).DisplayColumns(4).Width = 85
            .Splits(0).DisplayColumns(5).Width = 45
            .Splits(0).DisplayColumns(6).Width = 80

            .Columns(6).DefaultValue = 0
            .Columns(6).NumberFormat = "###,###,###,##0.#0"

            computeUsages()
        End With
    End Sub

    Private Sub GroupBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox2.Click
        GroupBox2.Enabled = False
        GroupBox2.Visible = False
        cmd.Focus()
    End Sub

    Private Sub cmdHistory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdHistory.Click
        GroupBox2.Enabled = True
        GroupBox2.Visible = True

        If cboMaterials2.ListCount > 0 Then cboMaterials2.SelectedIndex = 0

        cboMaterials2.SelectAll()
        cboMaterials2.Focus()
    End Sub

    Public Sub computeUsages()
        Dim ctr As Integer
        Dim total As Double

        With grid2
            While ctr < .RowCount
                total += .Item(ctr, 6)
                ctr += 1
            End While
        End With

        lblUsage2.Text = Format(total, "###,###,###,###,##0.#0")

    End Sub

    Private Sub grid2_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid2.RowColChange
        computeUsages()
    End Sub

    Private Sub cmd_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles cmd.ChangeUICues

    End Sub

    Private Sub txtProdnDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdnDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboMaterials.SelectAll()
            cboMaterials.Focus()
        End If
    End Sub

    Private Sub cboMaterials_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMaterials.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUsage.SelectAll()
            txtUsage.Focus()
        End If
    End Sub

    Private Sub txtUsage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmd.Focus()
        End If
    End Sub

    Public Sub displayMRNNo(ByVal materials As String)
        With cboMRN
            .DataSource = getMRNNo_ByMaterials(materials).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 314
        End With
    End Sub

    Private Sub txtUsage_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsage.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd.Focus()
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim reply As String
        If Not txtProdnDate.Text.Trim = "" And Not cboShift.Text.Trim = "" And Not cboMaterials.Text.Trim = "" Then
            reply = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then
                deleteMaterialUsages(txtProdnDate.Text, cboShift.Text, cboMaterials.Text)
                addNewRecord()

                MsgBox("You have successfully removed the records from the database", MsgBoxStyle.Information, "Information")
                cmd.Focus()
            End If
        End If
    End Sub
End Class
