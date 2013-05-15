Public Class frmMRN_BegInventory
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtUsage As System.Windows.Forms.TextBox
    Friend WithEvents cboMRN As C1.Win.C1List.C1Combo
    Friend WithEvents cboMaterials As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMRN_BegInventory))
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdReset = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtUsage = New System.Windows.Forms.TextBox
        Me.cboMRN = New C1.Win.C1List.C1Combo
        Me.cboMaterials = New C1.Win.C1List.C1Combo
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMRN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "MRN No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Beg. Inventory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Materials"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(858, 40)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Materials Beginning Inventory"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(4, 152)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(851, 331)
        Me.grid.TabIndex = 123
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
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" F" & _
        "ilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecS" & _
        "elWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>327</Heig" & _
        "ht><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=" & _
        """Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""" & _
        "FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle" & _
        " parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><Hig" & _
        "hLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inacti" & _
        "ve"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyl" & _
        "e parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""St" & _
        "yle6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 847, 327</ClientR" & _
        "ect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDB" & _
        "Grid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style paren" & _
        "t=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""H" & _
        "eading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""No" & _
        "rmal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal" & _
        """ me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Norma" & _
        "l"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""No" & _
        "rmal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertS" & _
        "plits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSe" & _
        "lWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 847, 327</ClientArea><PrintPageH" & _
        "eaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15""" & _
        " /></Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(471, 491)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(77, 48)
        Me.cmdClose.TabIndex = 122
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Image = CType(resources.GetObject("cmdReset.Image"), System.Drawing.Image)
        Me.cmdReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReset.Location = New System.Drawing.Point(391, 491)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(77, 48)
        Me.cmdReset.TabIndex = 121
        Me.cmdReset.Text = "&Refresh"
        Me.cmdReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(311, 491)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(77, 48)
        Me.cmdSave.TabIndex = 120
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtUsage
        '
        Me.txtUsage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsage.Location = New System.Drawing.Point(98, 118)
        Me.txtUsage.Name = "txtUsage"
        Me.txtUsage.Size = New System.Drawing.Size(160, 23)
        Me.txtUsage.TabIndex = 119
        Me.txtUsage.Text = "0"
        Me.txtUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.cboMRN.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboMRN.ItemHeight = 20
        Me.cboMRN.Location = New System.Drawing.Point(98, 86)
        Me.cboMRN.MatchEntryTimeout = CType(2000, Long)
        Me.cboMRN.MaxDropDownItems = CType(15, Short)
        Me.cboMRN.MaxLength = 32767
        Me.cboMRN.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMRN.Name = "cboMRN"
        Me.cboMRN.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMRN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMRN.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMRN.Size = New System.Drawing.Size(336, 24)
        Me.cboMRN.TabIndex = 118
        Me.cboMRN.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboMaterials.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboMaterials.ItemHeight = 20
        Me.cboMaterials.Location = New System.Drawing.Point(98, 53)
        Me.cboMaterials.MatchEntryTimeout = CType(2000, Long)
        Me.cboMaterials.MaxDropDownItems = CType(15, Short)
        Me.cboMaterials.MaxLength = 32767
        Me.cboMaterials.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMaterials.Name = "cboMaterials"
        Me.cboMaterials.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMaterials.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMaterials.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMaterials.Size = New System.Drawing.Size(336, 24)
        Me.cboMaterials.TabIndex = 117
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
        'frmMRN_BegInventory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(858, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUsage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cboMRN)
        Me.Controls.Add(Me.cboMaterials)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMRN_BegInventory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMRN_BegInventory"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMRN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMRN_BegInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displayAllMaterials()
        displayMaterialsInventory()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllMaterials()
        With cboMaterials
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

        displayAllMaterials(cboMaterials.Text)
        txtUsage.Text = "0"
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        cboMaterials.Text = ""
        txtUsage.Text = "0"
        displayAllMaterials()
        displayMaterialsInventory()
        cboMaterials.SelectAll()
        cboMaterials.Focus()
    End Sub

    Private Sub txtUsage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsage.TextChanged
        If Not IsNumeric(txtUsage.Text) Or txtUsage.Text.Trim = "" Then
            txtUsage.Text = "0"
            txtUsage.SelectAll()
            txtUsage.Focus()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Not cboMRN.Text.Trim = "" And Not txtUsage.Text.Trim = "" And _
        Not CDbl(txtUsage.Text) > getMaterialsInventoryCount(cboMRN.Text, "received") Then
            Dim reply As String
            reply = MsgBox("Are you sure you want to assign this figure for the beginning inventory", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If reply = vbYes Then

                updateMRN_Balance(cboMRN.Text, txtUsage.Text)
                displayMaterialsInventory()

                MsgBox("You have successfully update the beginning inventory of " & cboMaterials.Text, MsgBoxStyle.Information, "Information")
                cboMaterials.SelectAll()
                cboMaterials.Focus()
            End If
        Else
            MsgBox("Please review the below possible erros: " & Chr(13) & _
                "1. Materials Reference Number" & Chr(13) & _
                "2. Balance must not be greater than the total quantity received", MsgBoxStyle.Exclamation, "Warning")
            cboMaterials.SelectAll()
            cboMaterials.Focus()
        End If
    End Sub

    Public Sub displayMaterialsInventory()
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand("SELECT dbo.tblMRN_Materials.matDesc AS Materials, " & _
                "dbo.tblMRN.mrnNo AS [MRN No.], dbo.tblMRN.qty AS [Qty Received], " & _
                " dbo.tblMRN.bal AS Balance, dbo.tblMRN.invoiceNo AS [Invoice No.], " & _
                " dbo.tblMRN.poNo AS [PO No.], dbo.tblMRN.invoiceDate AS [Invoice Date], " & _
                " dbo.tblMRN.grnDate AS [GRN Date] " & _
                " FROM dbo.tblMRN INNER JOIN " & _
                " dbo.tblMRN_Materials ON dbo.tblMRN.matCode = dbo.tblMRN_Materials.matCode " & _
                " ORDER BY Materials, [GRN Date] DESC", c)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("mrn")
            da.Fill(ds)

            With grid
                .DataSource = ds.Tables(0)

                .Splits(0).DisplayColumns(0).Width = 310
                .Splits(0).DisplayColumns(1).Width = 170
                .Splits(0).DisplayColumns(4).Width = 120

                .Columns(2).DefaultValue = 0
                .Columns(2).NumberFormat = "###,###,###,###,##0.#0"
                .Columns(3).DefaultValue = 0
                .Columns(3).NumberFormat = "###,###,###,###,##0.#0"
            End With

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        With grid
            If .RowCount > 0 Then
                cboMaterials.Text = .Item(.Row, 0)
                cboMRN.Text = .Item(.Row, 1)
                txtUsage.Text = .Item(.Row, 3)

                txtUsage.SelectAll()
                txtUsage.Focus()
            End If
        End With
    End Sub
End Class
