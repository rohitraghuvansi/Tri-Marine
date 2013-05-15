Public Class frmQCSample
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblCode As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmQCSample))
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(88, 53)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(136, 23)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboShift.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(88, 85)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(10, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.Size = New System.Drawing.Size(136, 24)
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
        Me.cboLot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(360, 52)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(10, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(144, 24)
        Me.cboLot.TabIndex = 2
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
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(360, 86)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(144, 23)
        Me.txtQty.TabIndex = 3
        Me.txtQty.Text = "0"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.grid.Location = New System.Drawing.Point(9, 142)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(496, 364)
        Me.grid.TabIndex = 4
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
        "eight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWid" & _
        "th=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>360</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 492, 360</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>16</DefaultRecSelWidth><ClientArea>0, 0, 492, 360</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(380, 514)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 57
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(300, 514)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 56
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(220, 514)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 55
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Bitmap)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(140, 514)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 54
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Bitmap)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(60, 514)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 53
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Table View"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Shift"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Prod'n Date"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 40)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "QC  Sample Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Lot No."
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(88, 120)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(74, 16)
        Me.lblCode.TabIndex = 65
        Me.lblCode.Visible = False
        '
        'frmQCSample
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(514, 567)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCode, Me.Label2, Me.Label3, Me.Label6, Me.Label4, Me.Label5, Me.Label1, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdEdit, Me.cmd, Me.grid, Me.txtQty, Me.cboLot, Me.cboShift, Me.txtDate})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmQCSample"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQCSample"
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmQCSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()
        dataEntry(1)

        initializeShift()
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
            .Splits(0).DisplayColumns(0).Width = 115
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishLotWithdrawn(ByVal prodnDate As String, ByVal shift As String)
        With cboLot
            .DataSource = modModule.getBatchlotsWithdrawn(prodnDate, shift).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 123

            If .ListCount > 0 Then
                .SelectedIndex = 0
            Else
                .Text = ""
            End If
        End With
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

        lblCode.Text = getQCSampleCode(txtDate.Text, cboShift.Text, cboLot.Text)
        displayFishLotWithdrawn(txtDate.Text, cboShift.Text)
        displaySampleDetails(txtDate.Text, cboShift.Text, cboLot.Text)
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        lblCode.Text = getQCSampleCode(txtDate.Text, cboShift.Text, cboLot.Text)

        displayFishLotWithdrawn(txtDate.Text, cboShift.Text)
        displaySampleDetails(txtDate.Text, cboShift.Text, cboLot.Text)
    End Sub

    Public Sub displaySampleDetails(ByVal prodnDate As String, ByVal shift As String, ByVal lot As String)
        With grid
            If prodnDate = "" Then prodnDate = Format(getServerDateTime, getTimeFormat())

            .DataSource = modModule.getQCSampleDetails(prodnDate, shift, lot).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 120
            .Splits(0).DisplayColumns(1).Width = 110
            .Splits(0).DisplayColumns(2).Width = 120
        End With
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        lblCode.Text = getQCSampleCode(txtDate.Text, cboShift.Text, cboLot.Text)

        displaySampleDetails(txtDate.Text, cboShift.Text, cboLot.Text)
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        If txtQty.Text = "" Or Not IsNumeric(txtQty.Text) Then
            txtQty.Text = "0"
            txtQty.SelectAll()
            txtQty.Focus()
        End If
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
                txtDate.ReadOnly = False
                cboShift.ReadOnly = False
                cboLot.ReadOnly = False
                txtQty.ReadOnly = False
            Case 1
                txtDate.ReadOnly = True
                cboShift.ReadOnly = True
                cboLot.ReadOnly = True
                txtQty.ReadOnly = True
        End Select
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        txtDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        cboLot.Text = ""
        txtQty.Text = "0"
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
                txtDate.Focus()
            Case "&Save"
                If Not cboShift.Text.Trim = "" And Not cboLot.Text.Trim = "" And Not txtQty.Text.Trim = "" And Not txtQty.Text.Trim = "0" Then
                    If Not validateQCSample(txtDate.Text.Trim, cboShift.Text.Trim, cboLot.Text.Trim) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewQCSample(txtDate.Text, cboShift.Text, cboLot.Text, txtQty.Text)
                            GoTo message
                        End If
                    Else
                        reply = MsgBox("Are you sure you want to update the existing record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            updateQCSample(lblCode.Text, txtDate.Text, cboShift.Text, cboLot.Text, txtQty.Text)
                            GoTo message
                        End If
                    End If

                    Exit Sub

message:
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)
                    displaySampleDetails(txtDate.Text, cboShift.Text, cboLot.Text)
                    MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                    Exit Sub
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtDate.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update the existing record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateQCSample(lblCode.Text, txtDate.Text, cboShift.Text, cboLot.Text, txtQty.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)
                    displaySampleDetails(txtDate.Text, cboShift.Text, cboLot.Text)
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Public Sub saveNewQCSample(ByVal prodnDate As String, ByVal shift As String, ByVal lot As String, ByVal qty As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_addNew_QCSample"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getQCSampleCounter()

            Dim p2 As New SqlClient.SqlParameter()
            p2.ParameterName = "@qcsCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = Format(getQCSampleCounter(), "0#####")
            lblCode.Text = p2.Value


            Dim p3 As New SqlClient.SqlParameter()
            p3.ParameterName = "@prodnDate"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.DateTime
            p3.Value = Format(CDate(prodnDate), getTimeFormat())

            Dim p4 As New SqlClient.SqlParameter()
            p4.ParameterName = "@prodnShift"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = shift

            Dim p5 As New SqlClient.SqlParameter()
            p5.ParameterName = "@lot#"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = lot

            Dim p6 As New SqlClient.SqlParameter()
            p6.ParameterName = "@qty"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.Float
            p6.Value = qty

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

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not lblCode.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    txtDate.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtDate.Focus()
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
        f.lblTitle.Text = "Search QC Sample"
        f.searchType = 1
        f.displayAllQCSample()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = getQCSampleCode(txtDate.Text, cboShift.Text, cboLot.Text)
                txtDate.Value = .Item(.Row, 0)
                cboShift.Text = .Item(.Row, 1)
                cboLot.Text = .Item(.Row, 2)
                txtQty.Text = .Item(.Row, 3)
            End If
        End With
    End Sub

    Private Sub txtDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.TextChanged

    End Sub
End Class
