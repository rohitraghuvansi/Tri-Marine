Public Class frmAnalysis_RF
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
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUnloadingDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAnalysisDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents optComposite As System.Windows.Forms.RadioButton
    Friend WithEvents optIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents cboCategory As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAnalysis_RF))
        Me.txtUnloadingDate = New C1.Win.C1Input.C1DateEdit
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmd = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboSpecie = New C1.Win.C1List.C1Combo
        Me.txtAnalysisDate = New C1.Win.C1Input.C1DateEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.optComposite = New System.Windows.Forms.RadioButton
        Me.optIndividual = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboCategory = New C1.Win.C1List.C1Combo
        CType(Me.txtUnloadingDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnalysisDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUnloadingDate
        '
        Me.txtUnloadingDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnloadingDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtUnloadingDate.Location = New System.Drawing.Point(120, 79)
        Me.txtUnloadingDate.Name = "txtUnloadingDate"
        Me.txtUnloadingDate.Size = New System.Drawing.Size(144, 23)
        Me.txtUnloadingDate.TabIndex = 1
        Me.txtUnloadingDate.Tag = Nothing
        Me.txtUnloadingDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboLot.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(120, 112)
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(432, 72)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(208, 184)
        Me.grid.TabIndex = 7
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;" & _
        "}Style13{}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColo" & _
        "r:ControlText;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14" & _
        "{}Style15{}Style9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowC" & _
        "olMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterH" & _
        "eight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWid" & _
        "th=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>180</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 204, 180</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>17</DefaultRecSelWidth><ClientArea>0, 0, 204, 180</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(328, 208)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(248, 208)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(168, 208)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 10
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(88, 208)
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
        Me.cmd.Location = New System.Drawing.Point(8, 208)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 8
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Lot No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Unloading Date"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 40)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Analysis - Raw Fish"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Specie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Results"
        '
        'cboSpecie
        '
        Me.cboSpecie.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSpecie.AllowColMove = False
        Me.cboSpecie.AllowSort = False
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
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboSpecie.ItemHeight = 20
        Me.cboSpecie.Location = New System.Drawing.Point(120, 145)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(10, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.Size = New System.Drawing.Size(144, 24)
        Me.cboSpecie.TabIndex = 3
        Me.cboSpecie.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtAnalysisDate
        '
        Me.txtAnalysisDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnalysisDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtAnalysisDate.Location = New System.Drawing.Point(120, 46)
        Me.txtAnalysisDate.Name = "txtAnalysisDate"
        Me.txtAnalysisDate.Size = New System.Drawing.Size(144, 23)
        Me.txtAnalysisDate.TabIndex = 0
        Me.txtAnalysisDate.Tag = Nothing
        Me.txtAnalysisDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Analysis Date"
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(288, 128)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(120, 24)
        Me.lblCode.TabIndex = 29
        Me.lblCode.Visible = False
        '
        'optComposite
        '
        Me.optComposite.Checked = True
        Me.optComposite.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optComposite.Location = New System.Drawing.Point(432, 49)
        Me.optComposite.Name = "optComposite"
        Me.optComposite.Size = New System.Drawing.Size(104, 16)
        Me.optComposite.TabIndex = 5
        Me.optComposite.TabStop = True
        Me.optComposite.Text = "C&omposite"
        '
        'optIndividual
        '
        Me.optIndividual.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optIndividual.Location = New System.Drawing.Point(536, 49)
        Me.optIndividual.Name = "optIndividual"
        Me.optIndividual.Size = New System.Drawing.Size(112, 16)
        Me.optIndividual.TabIndex = 6
        Me.optIndividual.Text = "&Invidividual"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(328, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Sampling Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Type of Analysis"
        '
        'cboCategory
        '
        Me.cboCategory.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCategory.AllowColMove = False
        Me.cboCategory.AllowSort = False
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
        Me.cboCategory.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboCategory.ItemHeight = 20
        Me.cboCategory.Location = New System.Drawing.Point(120, 176)
        Me.cboCategory.MatchEntryTimeout = CType(2000, Long)
        Me.cboCategory.MaxDropDownItems = CType(10, Short)
        Me.cboCategory.MaxLength = 32767
        Me.cboCategory.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCategory.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategory.Size = New System.Drawing.Size(144, 24)
        Me.cboCategory.TabIndex = 4
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
        'frmAnalysis_RF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(650, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.optIndividual)
        Me.Controls.Add(Me.optComposite)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAnalysisDate)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.txtUnloadingDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnalysis_RF"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnalysis_RF"
        CType(Me.txtUnloadingDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnalysisDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAnalysis_RF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtAnalysisDate.Value = getServerDateTime()
        txtUnloadingDate.Value = getServerDateTime()

        'initializeResults()
        dataEntry(1)
        displayLabTest()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Public Sub initializeResults()
    '    With cboResults
    '        .DataMode = C1.Win.C1List.DataModeEnum.AddItem

    '        .ClearItems()
    '        .Text = ""
    '        .AddItemTitles("Results")
    '        .AddItem("1st")
    '        .AddItem("2nd")
    '        .AddItem("3rd")
    '        .AddItem("4th")
    '        .AddItem("5th")
    '        .AddItem("6th")
    '        .AddItem("7th")
    '        .AddItem("8th")
    '        .AddItem("9th")
    '        .AddItem("10th")
    '        .Splits(0).DisplayColumns(0).Width = 120

    '        .SelectedIndex = 0
    '    End With
    'End Sub

    Public Sub displayLot(ByVal unloadingDate As String)
        With cboLot
            .DataSource = getLot_byUnloadingDate(unloadingDate).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 120

            If .ListCount > 0 Then .SelectedIndex = 0

        End With
    End Sub

    Private Sub txtUnloadingDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnloadingDate.ValueChanged
        displayLot(txtUnloadingDate.Text)
        'displayLotDetails(txtUnloadingDate.Text, cboLot.Text)
    End Sub

    Public Sub displayTestDetails(ByVal lot As String, ByVal specie As String, ByVal category As String)
        With grid
            .DefColWidth = 165
            If optComposite.Checked = True Then
                .DataSource = getAnalysis_RF_LaboratoryDetails(lot, specie, "Composite", category).Tables(0)
            Else
                .DataSource = getAnalysis_RF_LaboratoryDetails(lot, specie, "Individual", category).Tables(0)
            End If
        End With
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displaySpecie()
        displayTestDetails(cboLot.Text, cboSpecie.Text, cboCategory.Text)
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
                txtAnalysisDate.ReadOnly = False
                txtUnloadingDate.ReadOnly = False
                cboLot.ReadOnly = False
                cboSpecie.ReadOnly = False
                cboCategory.ReadOnly = False
                optComposite.Enabled = True
                optIndividual.Enabled = True
                grid.Enabled = True
            Case 1
                txtAnalysisDate.ReadOnly = True
                txtUnloadingDate.ReadOnly = True
                cboLot.ReadOnly = True
                cboSpecie.ReadOnly = True
                cboCategory.ReadOnly = True
                optComposite.Enabled = False
                optIndividual.Enabled = False
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        txtUnloadingDate.ReadOnly = False
        cboLot.ReadOnly = False
        txtAnalysisDate.Value = getServerDateTime()
        txtUnloadingDate.Value = getServerDateTime()
        cboLot.Text = ""
        cboCategory.SelectedIndex = 0
        'cboResults.SelectedIndex = 0

        displayTestDetails(cboLot.Text, cboSpecie.Text, cboCategory.Text)
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
                txtAnalysisDate.SelectAll()
                txtAnalysisDate.Focus()
            Case "&Save"
                If Not cboLot.Text.Trim = "" And Not cboSpecie.Text.Trim = "" And _
                Not cboCategory.Text.Trim = "" And grid.RowCount > 0 Then
                    If Not validateRFA(cboLot.Text, cboSpecie.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewRFA(txtAnalysisDate.Text, txtUnloadingDate.Text, cboLot.Text, cboSpecie.Text)

                            Dim index As Integer
                            While index < grid.RowCount
                                If optComposite.Checked = True Then
                                    saveNewRFADetails(lblCode.Text, "Composite", grid.Item(index, 0), cboCategory.Text)
                                Else
                                    saveNewRFADetails(lblCode.Text, "Individual", grid.Item(index, 0), cboCategory.Text)
                                End If

                                index += 1
                            End While

                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Raw Fish Analysis record already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        txtAnalysisDate.SelectAll()
                        txtAnalysisDate.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtAnalysisDate.SelectAll()
                    txtAnalysisDate.Focus()
                End If
            Case "&Save "
                If Not cboLot.Text.Trim = "" And grid.RowCount > 0 Then
                    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        updateRFA(lblCode.Text, txtAnalysisDate.Text)

                        If optComposite.Checked = True Then
                            deleteRFADetails(lblCode.Text, "Composite", cboCategory.Text)
                        Else
                            deleteRFADetails(lblCode.Text, "Individual", cboCategory.Text)
                        End If

                        Dim index As Integer
                        While index < grid.RowCount
                            If optComposite.Checked = True Then
                                saveNewRFADetails(lblCode.Text, "Composite", grid.Item(index, 0), cboCategory.Text)
                            Else
                                saveNewRFADetails(lblCode.Text, "Individual", grid.Item(index, 0), cboCategory.Text)
                            End If

                            index += 1
                        End While

                        cmd.Text = "&Add"
                        cmdEdit.Text = "&Edit"
                        buttons(1)
                        dataEntry(1)
                        'displayAllCatchAreas()
                        'displayAreaCode()
                        'displayOcean()
                        MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                        cmd.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtAnalysisDate.SelectAll()
                    txtAnalysisDate.Focus()
                End If
        End Select
    End Sub

    Public Sub saveNewRFA(ByVal analysisDate As String, ByVal unloadingDate As String, _
    ByVal lot As String, ByVal specie As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_AnalysisRF"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@rfaCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            lblCode.Text = lot & getSpecieCode(specie)
            p1.Value = lblCode.Text

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@analysisDate"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.DateTime
            If analysisDate = "" Then
                p2.Value = Format(getServerDateTime, getTimeFormat())
            Else
                p2.Value = Format(CDate(analysisDate), getTimeFormat())
            End If

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@unloadingDate"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.DateTime
            If unloadingDate = "" Then
                p3.Value = Format(getServerDateTime, getTimeFormat())
            Else
                p3.Value = Format(CDate(unloadingDate), getTimeFormat())
            End If

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@lot"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = lot

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@specieCode"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = getSpecieCode(specie)

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@salt"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.Float
            p6.Value = "0"

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

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)

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

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboLot.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    txtUnloadingDate.ReadOnly = True
                    cboLot.ReadOnly = True
                    txtAnalysisDate.SelectAll()
                    txtAnalysisDate.Focus()
                Else
                    MsgBox("Pleas identify the lot number.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cmdFind.Focus()
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

    Public Sub displaySpecie()
        With cboSpecie
            .DefColWidth = 120
            .DataSource = getLotDetails_byUnloadingDate(cboLot.Text).Tables(0)

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub optComposite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optComposite.CheckedChanged
        displayTestDetails(cboLot.Text, cboSpecie.Text, cboCategory.Text)
    End Sub

    Private Sub optIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIndividual.CheckedChanged
        displayTestDetails(cboLot.Text, cboSpecie.Text, cboCategory.Text)
    End Sub

    Private Sub cboSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSpecie.TextChanged
        If cboSpecie.Text = "" Then If cboSpecie.ListCount > 0 Then cboSpecie.SelectedIndex = 0

        displayTestDetails(cboLot.Text, cboSpecie.Text, cboCategory.Text)
    End Sub

    Public Sub displayLabTest()
        With cboCategory
            .DefColWidth = 120
            .DataSource = getAnalysis_LaboratoryTest("Raw").Tables(0)
        End With
    End Sub

    Private Sub cboCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.TextChanged
        displayTestDetails(cboLot.Text, cboSpecie.Text, cboCategory.Text)
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Round Fish Analysis"
        f.searchType = 1
        f.displayAllAnalysis_RF()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 6)
                txtAnalysisDate.Value = .Item(.Row, 0)
                txtUnloadingDate.Value = .Item(.Row, 1)
                cboLot.Text = .Item(.Row, 2)
                cboSpecie.Text = .Item(.Row, 3)
                cboCategory.Text = .Item(.Row, 4)

                If CStr(.Item(.Row, 5)).StartsWith("Composite") Then
                    optComposite.Checked = True
                    optIndividual.Checked = False
                Else
                    optComposite.Checked = False
                    optIndividual.Checked = True
                End If
            End If
        End With
    End Sub
End Class
