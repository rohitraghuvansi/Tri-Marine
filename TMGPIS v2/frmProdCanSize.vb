Public Class frmProdCanSize
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCode As C1.Win.C1List.C1Combo
    Friend WithEvents cboCanSize As C1.Win.C1List.C1Combo
    Friend WithEvents cboCategory As C1.Win.C1List.C1Combo
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtCase As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProdCanSize))
        Me.cboCode = New C1.Win.C1List.C1Combo()
        Me.cboCanSize = New C1.Win.C1List.C1Combo()
        Me.cboCategory = New C1.Win.C1List.C1Combo()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtCase = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.cboCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCanSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCode
        '
        Me.cboCode.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCode.AllowColMove = False
        Me.cboCode.AutoCompletion = True
        Me.cboCode.AutoDropDown = True
        Me.cboCode.Caption = ""
        Me.cboCode.CaptionHeight = 17
        Me.cboCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCode.ColumnCaptionHeight = 17
        Me.cboCode.ColumnFooterHeight = 17
        Me.cboCode.ContentHeight = 18
        Me.cboCode.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCode.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCode.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCode.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCode.EditorHeight = 18
        Me.cboCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCode.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboCode.ItemHeight = 20
        Me.cboCode.Location = New System.Drawing.Point(96, 55)
        Me.cboCode.MatchEntryTimeout = CType(2000, Long)
        Me.cboCode.MaxDropDownItems = CType(20, Short)
        Me.cboCode.MaxLength = 32767
        Me.cboCode.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCode.Name = "cboCode"
        Me.cboCode.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCode.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCode.Size = New System.Drawing.Size(121, 24)
        Me.cboCode.TabIndex = 0
        Me.cboCode.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboCanSize.ContentHeight = 18
        Me.cboCanSize.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCanSize.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCanSize.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCanSize.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCanSize.EditorHeight = 18
        Me.cboCanSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCanSize.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.cboCanSize.ItemHeight = 20
        Me.cboCanSize.Location = New System.Drawing.Point(96, 87)
        Me.cboCanSize.MatchEntryTimeout = CType(2000, Long)
        Me.cboCanSize.MaxDropDownItems = CType(20, Short)
        Me.cboCanSize.MaxLength = 32767
        Me.cboCanSize.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCanSize.Name = "cboCanSize"
        Me.cboCanSize.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCanSize.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCanSize.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCanSize.Size = New System.Drawing.Size(232, 24)
        Me.cboCanSize.TabIndex = 1
        Me.cboCanSize.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboCategory.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboCategory.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCategory.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCategory.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCategory.EditorHeight = 18
        Me.cboCategory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.cboCategory.ItemHeight = 20
        Me.cboCategory.Location = New System.Drawing.Point(96, 119)
        Me.cboCategory.MatchEntryTimeout = CType(2000, Long)
        Me.cboCategory.MaxDropDownItems = CType(20, Short)
        Me.cboCategory.MaxLength = 32767
        Me.cboCategory.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCategory.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategory.Size = New System.Drawing.Size(232, 24)
        Me.cboCategory.TabIndex = 2
        Me.cboCategory.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(464, 56)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(104, 23)
        Me.txtUnit.TabIndex = 3
        Me.txtUnit.Text = "0"
        Me.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCase
        '
        Me.txtCase.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCase.Location = New System.Drawing.Point(464, 88)
        Me.txtCase.Name = "txtCase"
        Me.txtCase.Size = New System.Drawing.Size(104, 23)
        Me.txtCase.TabIndex = 4
        Me.txtCase.Text = "0"
        Me.txtCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(412, 496)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 43
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(332, 496)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 42
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(252, 496)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 41
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Bitmap)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(172, 496)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 40
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Bitmap)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(92, 496)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 39
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(578, 40)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Can Size - Fish Size"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.grid.Location = New System.Drawing.Point(8, 176)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(563, 312)
        Me.grid.TabIndex = 44
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
        "arqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>308</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 559, 308</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 559, 308</ClientArea><PrintPageHeaderStyle parent" & _
        "="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Size Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Can Size"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Case per FCL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(376, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Unit per Case"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Table View"
        '
        'frmProdCanSize
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(578, 551)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.Label4, Me.Label6, Me.Label3, Me.Label2, Me.Label5, Me.Label1, Me.grid, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdEdit, Me.cmd, Me.txtCase, Me.txtUnit, Me.cboCategory, Me.cboCanSize, Me.cboCode})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProdCanSize"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProdCanSize"
        CType(Me.cboCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCanSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmProdCanSize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        dataentry(1)

        'displayAllCanSize(cboCategory.Text)
        displayCanSizeCode()
        'displayCanSize()
        'displayCategory()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllCanSize(ByVal category As String)
        With grid
            .DataSource = modModule.getAllCanSize(category).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 60
            .Splits(0).DisplayColumns(1).Width = 150
            .Splits(0).DisplayColumns(2).Width = 110
        End With
    End Sub

    Public Sub displayCanSize(ByVal category As String)
        With cboCanSize
            .DataSource = modModule.getProductCanSize_PackType(category).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 210
        End With
    End Sub

    Public Sub displayCanSizeCode()
        With cboCode
            .DataSource = modModule.getProductCanSizeCode().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 100
        End With
    End Sub

    Public Sub displayCategory()
        With cboCategory
            .ClearItems()
            .DefColWidth = 210
            .AddItemTitles("Size Category")
            .AddItem("Canned Tuna")
            .AddItem("Frozen Loins")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCode.TextChanged
        getProductCanSize(cboCode.Text, cboCategory.Text)
    End Sub

    Public Sub getProductCanSize(ByVal code As String, ByVal category As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_getCanSize"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@canCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = code

            Dim p2 As New SqlClient.SqlParameter()
            p2.ParameterName = "@category"
            p2.SqlDbType = SqlDbType.VarChar
            p2.Direction = ParameterDirection.Input
            p2.Value = category

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)

            Dim drCode As SqlClient.SqlDataReader
            drCode = cmd.ExecuteReader

            If drCode.Read Then
                If Not drCode(0) Is DBNull.Value Then
                    cboCanSize.Text = drCode.GetString(0)
                    'cboCategory.Text = drCode.GetString(1)
                    txtUnit.Text = drCode.GetDouble(2)
                    txtCase.Text = drCode.GetDouble(3)
                Else
                    cboCanSize.Text = ""
                    'cboCategory.SelectedIndex = 0
                    txtUnit.Text = "0"
                    txtCase.Text = "0"
                End If
            Else
                cboCanSize.Text = ""
                'cboCategory.SelectedIndex = 0
                txtUnit.Text = "0"
                txtCase.Text = "0"
            End If

            drCode.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
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
                cboCode.ReadOnly = False
                cboCanSize.ReadOnly = False
                cboCategory.ReadOnly = False
                txtUnit.ReadOnly = False
                txtCase.ReadOnly = False
                grid.Enabled = True
            Case 1
                cboCode.ReadOnly = True
                cboCanSize.ReadOnly = True
                cboCategory.ReadOnly = True
                txtUnit.ReadOnly = True
                txtCase.ReadOnly = True
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        cboCode.ReadOnly = False
        cboCode.Text = ""
        displayCanSizeCode()
        cboCanSize.Text = ""
        displayCanSize(cboCategory.Text)
        'cboCategory.SelectedIndex = 0
        txtUnit.Text = "0"
        txtCase.Text = "0"

        displayAllCanSize(cboCategory.Text)
    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        If txtUnit.Text = "" Or Not IsNumeric(txtUnit.Text) Then
            txtUnit.Text = "0"
            txtUnit.SelectAll()
            txtUnit.Focus()
        End If
    End Sub

    Private Sub txtCase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCase.TextChanged
        If txtCase.Text = "" Or Not IsNumeric(txtCase.Text) Then
            txtCase.Text = "0"
            txtCase.SelectAll()
            txtCase.Focus()
        End If
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
                cboCode.SelectAll()
                cboCode.Focus()
            Case "&Save"
                If Not cboCode.Text.Trim = "" And Not cboCanSize.Text.Trim = "" And Not txtUnit.Text.Trim = "" And _
                Not txtCase.Text.Trim = "" Then
                    If Not validatCanSize(cboCode.Text, cboCanSize.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewCanSize(cboCode.Text, cboCanSize.Text, cboCategory.Text, txtUnit.Text, txtCase.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            displayAllCanSize(cboCategory.Text)
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox(cboCategory.Text & " already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCode.SelectAll()
                        cboCode.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCode.SelectAll()
                    cboCode.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateCanSize(cboCode.Text, cboCanSize.Text, cboCategory.Text, txtUnit.Text, txtCase.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)

                    displayAllCanSize(cboCategory.Text)
                    'displayDefects()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Private Sub cboCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.TextChanged
        If cboCategory.Text = "" Then If cboCategory.ListCount > 0 Then cboCategory.SelectedIndex = 0

        displayAllCanSize(cboCategory.Text)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboCode.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboCode.ReadOnly = True
                    cboCanSize.SelectAll()
                    cboCanSize.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCanSize.SelectAll()
                    cboCanSize.Focus()
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

        If cboCategory.Text.StartsWith("Can") Then
            f.lblTitle.Text = "Search Product Can Size"
        Else
            f.lblTitle.Text = "Search Product Fish Size"
        End If

        f.searchType = 1
        f.displayAllCanSize(cboCategory.Text)
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                cboCode.Text = .Item(.Row, 0)
                cboCanSize.Text = .Item(.Row, 1)
                cboCategory.Text = .Item(.Row, 2)
                txtUnit.Text = .Item(.Row, 3)
                txtCase.Text = .Item(.Row, 4)
            End If
        End With
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        With grid
            If .RowCount > 0 Then
                cboCode.Text = .Item(.Row, 0)
                cboCanSize.Text = .Item(.Row, 1)
                cboCategory.Text = .Item(.Row, 2)
                txtUnit.Text = .Item(.Row, 3)
                txtCase.Text = .Item(.Row, 4)
            End If
        End With
    End Sub

    Private Sub cboCanSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCanSize.TextChanged

    End Sub
End Class
