Public Class frmFishRacking
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
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents cboSize As C1.Win.C1List.C1Combo
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalWeight As System.Windows.Forms.Label
    Friend WithEvents lblAveSize As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishRacking))
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit
        Me.cboShift = New C1.Win.C1List.C1Combo
        Me.cboSpecie = New C1.Win.C1List.C1Combo
        Me.cboSize = New C1.Win.C1List.C1Combo
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotalWeight = New System.Windows.Forms.Label
        Me.lblAveSize = New System.Windows.Forms.Label
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(104, 56)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(232, 23)
        Me.txtProdnDate.TabIndex = 40
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
        Me.cboShift.Location = New System.Drawing.Point(104, 88)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.Size = New System.Drawing.Size(232, 24)
        Me.cboShift.TabIndex = 41
        Me.cboShift.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboSpecie.ItemHeight = 20
        Me.cboSpecie.Location = New System.Drawing.Point(104, 120)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(10, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.Size = New System.Drawing.Size(232, 24)
        Me.cboSpecie.TabIndex = 42
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
        Me.cboSize.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboSize.ItemHeight = 20
        Me.cboSize.Location = New System.Drawing.Point(104, 152)
        Me.cboSize.MatchEntryTimeout = CType(2000, Long)
        Me.cboSize.MaxDropDownItems = CType(10, Short)
        Me.cboSize.MaxLength = 32767
        Me.cboSize.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSize.Name = "cboSize"
        Me.cboSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSize.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSize.Size = New System.Drawing.Size(232, 24)
        Me.cboSize.TabIndex = 43
        Me.cboSize.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(104, 184)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(144, 23)
        Me.txtQty.TabIndex = 44
        Me.txtQty.Text = "0"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(428, 472)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 49
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(347, 472)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 46
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(267, 472)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 45
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(7, 240)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(756, 224)
        Me.grid.TabIndex = 106
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}FilterBar{}EvenRow{BackColor:Aqua;}Selected{ForeColor:HighlightText;BackC" & _
        "olor:Highlight;}Heading{Wrap:True;Font:Tahoma, 9.75pt;AlignVert:Center;Border:Ra" & _
        "ised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Inactive{ForeColor:Ina" & _
        "ctiveCaptionText;BackColor:InactiveCaption;}Style70{}Style69{}Footer{}Caption{Al" & _
        "ignHorz:Center;}Style78{}Style79{}HighlightRow{ForeColor:HighlightText;BackColor" & _
        ":Highlight;}Style72{}Style73{}Normal{Font:Tahoma, 9.75pt;}Style71{}Style76{}Styl" & _
        "e77{AlignHorz:Near;}Style74{}Style75{}Style80{}OddRow{}Style68{}RecordSelector{A" & _
        "lignImage:Center;}Style14{}Style15{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid" & _
        ".MergeView AllowColMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""" & _
        "17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=" & _
        """17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Heig" & _
        "ht>220</Height><CaptionStyle parent=""Heading"" me=""Style77"" /><EditorStyle parent" & _
        "=""Editor"" me=""Style69"" /><EvenRowStyle parent=""EvenRow"" me=""Style75"" /><FilterBa" & _
        "rStyle parent=""FilterBar"" me=""Style80"" /><FooterStyle parent=""Footer"" me=""Style7" & _
        "1"" /><GroupStyle parent=""Group"" me=""Style79"" /><HeadingStyle parent=""Heading"" me" & _
        "=""Style70"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style74"" /><InactiveSt" & _
        "yle parent=""Inactive"" me=""Style73"" /><OddRowStyle parent=""OddRow"" me=""Style76"" /" & _
        "><RecordSelectorStyle parent=""RecordSelector"" me=""Style78"" /><SelectedStyle pare" & _
        "nt=""Selected"" me=""Style72"" /><Style parent=""Normal"" me=""Style68"" /><ClientRect>0" & _
        ", 0, 752, 220</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 752, 220</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(770, 40)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Fish Racking"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 19)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Racking Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Quantity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 19)
        Me.Label16.TabIndex = 109
        Me.Label16.Text = "Fish Size"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 19)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Fish Specie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 19)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Prodn Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 19)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Shift"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Total Weight"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(424, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Average Size"
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalWeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWeight.Location = New System.Drawing.Point(512, 152)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(128, 24)
        Me.lblTotalWeight.TabIndex = 115
        Me.lblTotalWeight.Text = "0.00"
        Me.lblTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAveSize
        '
        Me.lblAveSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveSize.Location = New System.Drawing.Point(512, 183)
        Me.lblAveSize.Name = "lblAveSize"
        Me.lblAveSize.Size = New System.Drawing.Size(128, 24)
        Me.lblAveSize.TabIndex = 116
        Me.lblAveSize.Text = "0.00"
        Me.lblAveSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmFishRacking
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(770, 528)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAveSize)
        Me.Controls.Add(Me.lblTotalWeight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtProdnDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishRacking"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishRacking"
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishRacking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtProdnDate.Value = getServerDateTime()

        displayShift(txtProdnDate.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Public Sub initializeShift()
    '    With cboShift
    '        .DataMode = C1.Win.C1List.DataModeEnum.AddItem
    '        .AddItemTitles("Shift")
    '        .AddItem("Day")
    '        .AddItem("Night")
    '        .Splits(0).DisplayColumns(0).Width = 208
    '        .SelectedIndex = 0
    '    End With
    'End Sub

    Public Sub displayShift(ByVal prodnDate As String)
        With cboShift
            .DefColWidth = 208
            .Text = ""
            .DataSource = displayProductOutputShift("%", "%", "%", prodnDate, "%", "shift", "%").Tables(0)

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishSpecie()
        With cboSpecie
            .DefColWidth = 208
            .Text = ""
            .DataSource = getFishDetails_byWithdrawn(txtProdnDate.Text, cboShift.Text, "", "YES").Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishSizes()
        With cboSize
            .DefColWidth = 208
            .Text = ""
            .DataSource = getFishDetails_byWithdrawn(txtProdnDate.Text, cboShift.Text, cboSpecie.Text, "").Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 185

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        If Not IsNumeric(txtQty.Text) Or txtQty.Text.Trim = "" Then
            txtQty.Text = "0"
            txtQty.SelectAll()
            txtQty.Focus()
        End If

        displayTotalWeight(txtProdnDate.Text, cboShift.Text, cboSpecie.Text, cboSize.Text)
    End Sub

    Public Sub addNewRecord()
        txtProdnDate.Value = getServerDateTime()
        displayShift(txtProdnDate.Text)
        displayFishSpecie()
        cboSpecie.Text = ""
        displayFishSizes()
        cboSize.Text = ""
        txtQty.Text = "0"
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        txtProdnDate.SelectAll()
        txtProdnDate.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String
        'Select Case cmd.Text
        '    Case "&Save"
        If Not cboShift.Text.Trim = "" And Not cboShift.Text.Trim = "" And Not cboSpecie.Text.Trim = "" And Not cboSize.Text.Trim = "" And _
        Not txtQty.Text.Trim = "" And CDbl(txtQty.Text) > 0 Then
            If getFishRackQuantity2(txtProdnDate.Text, cboShift.Text, cboSpecie.Text, cboSize.Text) = 0 Then
                reply = MsgBox("Are you sure you want to add this fish rack quantity?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    saveNewFishRack(txtProdnDate.Text, cboShift.Text, cboSpecie.Text, cboSize.Text, txtQty.Text)
                End If
            Else
                reply = MsgBox("Are you sure you want to update the fish rack quantity?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFishRack(txtProdnDate.Text, cboShift.Text, cboSpecie.Text, cboSize.Text, txtQty.Text)
                End If
            End If

            displayRecord(txtProdnDate.Text, cboShift.Text)

            MsgBox("You have successfully compeleted the transaction", MsgBoxStyle.Information, "Information")
            txtQty.Text = "0"
            txtProdnDate.SelectAll()
            txtProdnDate.Focus()
        Else
            MsgBox("Please fill-in necessary information.", MsgBoxStyle.Exclamation, "Warning")
            txtProdnDate.SelectAll()
            txtProdnDate.Focus()
        End If
    End Sub

    Public Sub displayRecord(ByVal prodnDate As String, ByVal shift As String)
        With grid
            .DataSource = getFishRackDetails(prodnDate, shift).Tables(0)
            .Columns(0).NumberFormat = "dd/MM/yyyy"
            .Columns(4).NumberFormat = "###,###"
            .Columns(5).NumberFormat = "###,###"
            .Columns(6).NumberFormat = "###,##0.#0"
        End With
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        displayShift(txtProdnDate.Text)
        displayFishSpecie()
        displayRecord(txtProdnDate.Text, cboShift.Text)
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        displayFishSpecie()
        displayRecord(txtProdnDate.Text, cboShift.Text)
    End Sub

    Private Sub cboSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSpecie.TextChanged
        displayFishSizes()
    End Sub

    Private Sub txtProdnDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdnDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
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
            txtQty.SelectAll()
            txtQty.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave.Focus()
        End If
    End Sub

    Private Sub cboSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.TextChanged
        displayTotalWeight(txtProdnDate.Text, cboShift.Text, cboSpecie.Text, cboSize.Text)
    End Sub

    Public Sub displayTotalWeight(ByVal prodnDate As String, ByVal shift As String, _
    ByVal specie As String, ByVal size As String)
        lblTotalWeight.Text = Format(getFishSpecieTotalWeightByProdnDate(prodnDate, shift, specie, size), "###,##0.#0")

        If CDbl(txtQty.Text) = 0 Then
            lblAveSize.Text = "0"
        Else
            lblAveSize.Text = Format(CDbl(lblTotalWeight.Text) / txtQty.Text, "##0.#0")
        End If
    End Sub
End Class
