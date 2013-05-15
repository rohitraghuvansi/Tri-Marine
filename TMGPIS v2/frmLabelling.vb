Public Class frmLabelling
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
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cboPallet As C1.Win.C1List.C1Combo
    Friend WithEvents cboLabel As C1.Win.C1List.C1Combo
    Friend WithEvents cboWarehouse As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMRNCarton As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboMRNLabel As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuLabel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWarehouse As System.Windows.Forms.MenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboCartons As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkUnlabel As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLabelling))
        Me.txtDate = New C1.Win.C1Input.C1DateEdit
        Me.cboShift = New C1.Win.C1List.C1Combo
        Me.cboPallet = New C1.Win.C1List.C1Combo
        Me.cboLabel = New C1.Win.C1List.C1Combo
        Me.cboWarehouse = New C1.Win.C1List.C1Combo
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboMRNCarton = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboMRNLabel = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuLabel = New System.Windows.Forms.MenuItem
        Me.mnuWarehouse = New System.Windows.Forms.MenuItem
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboCartons = New C1.Win.C1List.C1Combo
        Me.chkUnlabel = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMRNCarton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMRNLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCartons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(96, 88)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(144, 23)
        Me.txtDate.TabIndex = 1
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
        Me.cboShift.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(96, 119)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.Size = New System.Drawing.Size(144, 24)
        Me.cboShift.TabIndex = 2
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
        Me.cboPallet.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboPallet.ItemHeight = 20
        Me.cboPallet.Location = New System.Drawing.Point(96, 55)
        Me.cboPallet.MatchEntryTimeout = CType(2000, Long)
        Me.cboPallet.MaxDropDownItems = CType(10, Short)
        Me.cboPallet.MaxLength = 32767
        Me.cboPallet.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPallet.Name = "cboPallet"
        Me.cboPallet.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPallet.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPallet.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPallet.Size = New System.Drawing.Size(144, 24)
        Me.cboPallet.TabIndex = 0
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
        'cboLabel
        '
        Me.cboLabel.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboLabel.AllowColMove = False
        Me.cboLabel.AutoCompletion = True
        Me.cboLabel.AutoDropDown = True
        Me.cboLabel.Caption = ""
        Me.cboLabel.CaptionHeight = 17
        Me.cboLabel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLabel.ColumnCaptionHeight = 17
        Me.cboLabel.ColumnFooterHeight = 17
        Me.cboLabel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboLabel.ContentHeight = 18
        Me.cboLabel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLabel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLabel.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLabel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLabel.EditorHeight = 18
        Me.cboLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLabel.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboLabel.ItemHeight = 20
        Me.cboLabel.Location = New System.Drawing.Point(760, 55)
        Me.cboLabel.MatchEntryTimeout = CType(2000, Long)
        Me.cboLabel.MaxDropDownItems = CType(10, Short)
        Me.cboLabel.MaxLength = 32767
        Me.cboLabel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLabel.Name = "cboLabel"
        Me.cboLabel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLabel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLabel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLabel.Size = New System.Drawing.Size(368, 24)
        Me.cboLabel.TabIndex = 3
        Me.cboLabel.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboWarehouse
        '
        Me.cboWarehouse.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboWarehouse.AllowColMove = False
        Me.cboWarehouse.AutoCompletion = True
        Me.cboWarehouse.AutoDropDown = True
        Me.cboWarehouse.Caption = ""
        Me.cboWarehouse.CaptionHeight = 17
        Me.cboWarehouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboWarehouse.ColumnCaptionHeight = 17
        Me.cboWarehouse.ColumnFooterHeight = 17
        Me.cboWarehouse.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboWarehouse.ContentHeight = 18
        Me.cboWarehouse.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboWarehouse.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboWarehouse.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWarehouse.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboWarehouse.EditorHeight = 18
        Me.cboWarehouse.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWarehouse.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboWarehouse.ItemHeight = 20
        Me.cboWarehouse.Location = New System.Drawing.Point(760, 119)
        Me.cboWarehouse.MatchEntryTimeout = CType(2000, Long)
        Me.cboWarehouse.MaxDropDownItems = CType(10, Short)
        Me.cboWarehouse.MaxLength = 32767
        Me.cboWarehouse.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboWarehouse.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboWarehouse.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboWarehouse.Size = New System.Drawing.Size(368, 24)
        Me.cboWarehouse.TabIndex = 5
        Me.cboWarehouse.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 184)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(1126, 280)
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
        "th=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>276</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 1122, 276</ClientRect>" & _
        "<BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid" & _
        ".MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""N" & _
        "ormal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headi" & _
        "ng"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal" & _
        """ me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me" & _
        "=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" m" & _
        "e=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal" & _
        """ me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplit" & _
        "s>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWid" & _
        "th>17</DefaultRecSelWidth><ClientArea>0, 0, 1122, 276</ClientArea><PrintPageHead" & _
        "erStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" />" & _
        "</Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(694, 472)
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
        Me.cmdPrint.Location = New System.Drawing.Point(614, 472)
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
        Me.cmdFind.Location = New System.Drawing.Point(534, 472)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 10
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(454, 472)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(374, 472)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 9
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Pallet No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 19)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Shift"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Labeling Date"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1143, 40)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Labeling and Case-up Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(672, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Warehouse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(672, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Labels"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 19)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Production Output Details"
        '
        'cboMRNCarton
        '
        Me.cboMRNCarton.AllowColMove = False
        Me.cboMRNCarton.AllowColSelect = True
        Me.cboMRNCarton.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboMRNCarton.AlternatingRows = False
        Me.cboMRNCarton.CaptionHeight = 17
        Me.cboMRNCarton.ColumnCaptionHeight = 17
        Me.cboMRNCarton.ColumnFooterHeight = 17
        Me.cboMRNCarton.FetchRowStyles = False
        Me.cboMRNCarton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMRNCarton.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboMRNCarton.Location = New System.Drawing.Point(456, 192)
        Me.cboMRNCarton.Name = "cboMRNCarton"
        Me.cboMRNCarton.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMRNCarton.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboMRNCarton.RowHeight = 20
        Me.cboMRNCarton.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMRNCarton.ScrollTips = False
        Me.cboMRNCarton.Size = New System.Drawing.Size(160, 264)
        Me.cboMRNCarton.TabIndex = 34
        Me.cboMRNCarton.Text = "C1TrueDBDropdown1"
        Me.cboMRNCarton.Visible = False
        Me.cboMRNCarton.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style9{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackC" & _
        "olor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView AllowColMove=""False"" " & _
        "Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" Marq" & _
        "ueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" RecordS" & _
        "electors=""False"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>260</" & _
        "Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor""" & _
        " me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle pare" & _
        "nt=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupS" & _
        "tyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" />" & _
        "<HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""In" & _
        "active"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelector" & _
        "Style parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me" & _
        "=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 156, 260</Cli" & _
        "entRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1Tr" & _
        "ueDBGrid.DropdownView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Styl" & _
        "e parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style pa" & _
        "rent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style par" & _
        "ent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=" & _
        """Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent" & _
        "=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style par" & _
        "ent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles" & _
        "><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><Defau" & _
        "ltRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 156, 260</ClientArea></Bl" & _
        "ob>"
        '
        'cboMRNLabel
        '
        Me.cboMRNLabel.AllowColMove = False
        Me.cboMRNLabel.AllowColSelect = True
        Me.cboMRNLabel.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboMRNLabel.AlternatingRows = False
        Me.cboMRNLabel.CaptionHeight = 17
        Me.cboMRNLabel.ColumnCaptionHeight = 17
        Me.cboMRNLabel.ColumnFooterHeight = 17
        Me.cboMRNLabel.FetchRowStyles = False
        Me.cboMRNLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMRNLabel.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.cboMRNLabel.Location = New System.Drawing.Point(656, 192)
        Me.cboMRNLabel.Name = "cboMRNLabel"
        Me.cboMRNLabel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMRNLabel.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboMRNLabel.RowHeight = 20
        Me.cboMRNLabel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMRNLabel.ScrollTips = False
        Me.cboMRNLabel.Size = New System.Drawing.Size(160, 264)
        Me.cboMRNLabel.TabIndex = 45
        Me.cboMRNLabel.Text = "C1TrueDBDropdown2"
        Me.cboMRNLabel.Visible = False
        Me.cboMRNLabel.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Alig" & _
        "nVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView AllowColMove=""False"" " & _
        "Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" Marq" & _
        "ueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" RecordS" & _
        "electors=""False"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>260</" & _
        "Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor""" & _
        " me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle pare" & _
        "nt=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupS" & _
        "tyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" />" & _
        "<HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""In" & _
        "active"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelector" & _
        "Style parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me" & _
        "=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 156, 260</Cli" & _
        "entRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1Tr" & _
        "ueDBGrid.DropdownView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Styl" & _
        "e parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style pa" & _
        "rent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style par" & _
        "ent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=" & _
        """Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent" & _
        "=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style par" & _
        "ent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles" & _
        "><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><Defau" & _
        "ltRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 156, 260</ClientArea></Bl" & _
        "ob>"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuLabel, Me.mnuWarehouse})
        '
        'mnuLabel
        '
        Me.mnuLabel.Index = 0
        Me.mnuLabel.Text = "&Label"
        '
        'mnuWarehouse
        '
        Me.mnuWarehouse.Index = 1
        Me.mnuWarehouse.Text = "&Warehouse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(672, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Cartons"
        '
        'cboCartons
        '
        Me.cboCartons.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCartons.AllowColMove = False
        Me.cboCartons.AutoCompletion = True
        Me.cboCartons.AutoDropDown = True
        Me.cboCartons.Caption = ""
        Me.cboCartons.CaptionHeight = 17
        Me.cboCartons.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCartons.ColumnCaptionHeight = 17
        Me.cboCartons.ColumnFooterHeight = 17
        Me.cboCartons.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCartons.ContentHeight = 18
        Me.cboCartons.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCartons.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCartons.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCartons.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCartons.EditorHeight = 18
        Me.cboCartons.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCartons.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.cboCartons.ItemHeight = 20
        Me.cboCartons.Location = New System.Drawing.Point(760, 87)
        Me.cboCartons.MatchEntryTimeout = CType(2000, Long)
        Me.cboCartons.MaxDropDownItems = CType(10, Short)
        Me.cboCartons.MaxLength = 32767
        Me.cboCartons.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCartons.Name = "cboCartons"
        Me.cboCartons.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCartons.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCartons.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCartons.Size = New System.Drawing.Size(368, 24)
        Me.cboCartons.TabIndex = 4
        Me.cboCartons.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'chkUnlabel
        '
        Me.chkUnlabel.Location = New System.Drawing.Point(760, 151)
        Me.chkUnlabel.Name = "chkUnlabel"
        Me.chkUnlabel.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(672, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 19)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Unlabelled"
        '
        'frmLabelling
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1143, 528)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkUnlabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboCartons)
        Me.Controls.Add(Me.cboMRNLabel)
        Me.Controls.Add(Me.cboMRNCarton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboWarehouse)
        Me.Controls.Add(Me.cboLabel)
        Me.Controls.Add(Me.cboPallet)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.cmdFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLabelling"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLabelling"
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPallet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMRNCarton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMRNLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCartons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmLabelling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()
        initializeShift()

        displayPallet()
        displayLabels()
        displayCartons()
        displayWarehouse()

        displayPalletDetails(cboPallet.Text)
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
            .Splits(0).DisplayColumns(0).Width = 120
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0
    End Sub

    Public Sub displayLabels()
        With cboLabel
            .DataSource = modModule.getLabels().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 347
        End With
    End Sub

    Public Sub displayCartons()
        With cboCartons
            .DataSource = modModule.getAllMaterials_ByCategory("Cartons").Tables(0)
            .Splits(0).DisplayColumns(0).Width = 347
        End With
    End Sub

    Public Sub displayWarehouse()
        With cboWarehouse
            .DataSource = modModule.getWarehouse().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 347
        End With
    End Sub

    Public Sub displayPallet()
        With cboPallet
            .DataSource = modModule.getPallets().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 120
        End With
    End Sub

    Public Sub displayPalletDetails(ByVal pallet As String)
        With grid
            .DataSource = modModule.getPalletDetails(pallet).Tables(0)
            displayMRN()
            '.Columns(7).DropDown = cboMRNCarton
            '.Columns(8).DropDown = cboMRNLabel
            '.Splits(0).DisplayColumns(7).DropDownList = True
            '.Splits(0).DisplayColumns(8).DropDownList = True

            .Splits(0).DisplayColumns(0).Width = 110 '100
            .Splits(0).DisplayColumns(1).Width = 100 '65
            .Splits(0).DisplayColumns(2).Width = 100 '65
            .Splits(0).DisplayColumns(3).Width = 100 '90
            .Splits(0).DisplayColumns(4).Width = 130
            .Splits(0).DisplayColumns(5).Width = 130
            '.Splits(0).DisplayColumns(7).Width = 160
            '.Splits(0).DisplayColumns(8).Width = 160

            .Splits(0).DisplayColumns(4).Locked = True
            .Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(5).Locked = True
            .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray

            .Columns(2).NumberFormat = "######"
            .Columns(3).NumberFormat = "###"
            .Columns(6).NumberFormat = "###,###,##0"
            .Columns(6).DefaultValue = 0
            .Columns(7).NumberFormat = "###,###,##0"
            .Columns(7).DefaultValue = 0
            .Columns(8).NumberFormat = "###,###,##0"
            .Columns(8).DefaultValue = 0
            .Columns(9).NumberFormat = "###,###,##0"
            .Columns(9).DefaultValue = 0
        End With
    End Sub

    Private Sub cboPallet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPallet.TextChanged
        searchPalletDetails(cboPallet.Text)
        displayPalletDetails(cboPallet.Text)
    End Sub

    Public Sub displayProductDetails()
        Dim ctr, toAddCases As Integer
        Dim cases, tins As Double
        Dim pCode, subCode, lot, julian As String
        With grid
            While ctr < .RowCount
                Try
                    If .Item(ctr, 0) Is DBNull.Value Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) Is DBNull.Value Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 2) Is DBNull.Value Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 2)
                    End If

                    If .Item(ctr, 3) Is DBNull.Value Then
                        julian = "0"
                    Else
                        julian = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 7) Is DBNull.Value Then
                        tins = 0
                    Else
                        tins = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 6) Is DBNull.Value Then
                        cases = 0
                    Else
                        cases = .Item(ctr, 6)
                    End If
                Catch e As Exception
                    If .Item(ctr, 0) = "" Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) = "" Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 2) = "" Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 2)
                    End If

                    If .Item(ctr, 3) = "" Then
                        julian = "0"
                    Else
                        julian = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 7) = "" Then
                        tins = 0
                    Else
                        tins = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 6) = "" Then
                        cases = 0
                    Else
                        cases = .Item(ctr, 6)
                    End If
                End Try

                .Item(ctr, 4) = getProductionDetails(pCode, subCode, lot, julian, True)
                .Item(ctr, 5) = getProductionDetails(pCode, subCode, lot, julian, False)

                Try
                    If getProductCansPerCase(julian, lot, pCode) > 0 Then
                        If tins >= getProductCansPerCase(julian, lot, pCode) Then
                            'MsgBox("No. of cans is allowed only up to " & getLabelPerCase(cboLabel.Text) & " cans per case for " & cboLabel.Text, MsgBoxStyle.Exclamation, "Warning")

                            toAddCases = (tins \ getProductCansPerCase(julian, lot, pCode))
                            'toAddCases = toAddCases

                            .Item(ctr, 6) = cases + toAddCases
                            .Item(ctr, 7) = (tins Mod getProductCansPerCase(julian, lot, pCode))
                        End If
                    End If
                Catch ex As Exception
                    If getProductCansPerCase(julian, lot, pCode) > 0 Then
                        If tins >= getProductCansPerCase(julian, lot, pCode) Then
                            'MsgBox("No. of cans is allowed only up to " & getLabelPerCase(cboLabel.Text) & " cans per case for " & cboLabel.Text, MsgBoxStyle.Exclamation, "Warning")

                            toAddCases = (tins \ getProductCansPerCase(julian, lot, pCode))
                            'toAddCases = System.Math.Round(toAddCases, 0)

                            .Item(ctr, 6) = cases + toAddCases
                            .Item(ctr, 7) = (tins Mod getProductCansPerCase(julian, lot, pCode))
                        End If
                    End If
                End Try

                ctr += 1
            End While
        End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        displayProductDetails()

        'Dim cases As Integer
        'Try
        '    If Not cboLabel.Text = "" Then
        '        If Not grid.Item(grid.Row, 6) Is DBNull.Value Then
        '            If grid.Item(grid.Row, 6) >= getLabelPerCase(cboLabel.Text) Then
        '                'MsgBox("No. of cans is allowed only up to " & getLabelPerCase(cboLabel.Text) & " cans per case for " & cboLabel.Text, MsgBoxStyle.Exclamation, "Warning")

        '                cases = (grid.Item(grid.Row, 6) / getLabelPerCase(cboLabel.Text))
        '                cases = System.Math.Round(cases, 0)
        '                grid.Item(grid.Row, 5) = grid.Item(grid.Row, 5) + cases
        '                grid.Item(grid.Row, 6) = (grid.Item(grid.Row, 6) Mod getLabelPerCase(cboLabel.Text))
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    If Not cboLabel.Text = "" Then
        '        If Not grid.Item(grid.Row, 6) = "" Then
        '            If grid.Item(grid.Row, 6) >= getLabelPerCase(cboLabel.Text) Then
        '                'MsgBox("No. of cans is allowed only up to " & getLabelPerCase(cboLabel.Text) & " cans per case for " & cboLabel.Text, MsgBoxStyle.Exclamation, "Warning")

        '                cases = (grid.Item(grid.Row, 6) / getLabelPerCase(cboLabel.Text))
        '                cases = System.Math.Round(cases, 0)
        '                grid.Item(grid.Row, 5) = grid.Item(grid.Row, 5) + cases
        '                grid.Item(grid.Row, 6) = (grid.Item(grid.Row, 6) Mod getLabelPerCase(cboLabel.Text))
        '            End If
        '        End If
        '    End If
        'End Try
    End Sub

    'Public Sub checkPerCase()
    '    Dim ctr As Integer
    '    Dim cases As Integer
    '    While ctr < grid.RowCount


    '        ctr += 1
    '    End While
    'End Sub

    Private Sub cboLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLabel.TextChanged
        displayProductDetails()
    End Sub

    Public Sub displayMRN()
        cboMRNCarton.DefColWidth = 140
        cboMRNCarton.DataSource = modModule.getMRN_Classification("Carton").Tables(0)

        cboMRNLabel.DefColWidth = 140
        cboMRNLabel.DataSource = modModule.getMRN_Classification("Label").Tables(0)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        txtDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        cboPallet.Text = ""
        displayPallet()
        cboLabel.Text = ""
        displayLabels()
        cboCartons.Text = ""
        displayCartons()
        cboWarehouse.Text = ""
        displayWarehouse()

        cboPallet.SelectAll()
        cboPallet.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String
        If Not cboPallet.Text.Trim = "" And Not cboLabel.Text.Trim = "" And Not cboWarehouse.Text.Trim = "" And grid.RowCount > 0 Then
            If Not validateWithdrawnPallet(cboPallet.Text) Then
                If Not validatePallet(cboPallet.Text.Trim) Then
                    If Not isDataEntryFieldsAreEmpty() Then
                        reply = MsgBox("Are you sure you want to process this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            If chkUnlabel.Checked = True Then
                                saveNewPallet(txtDate.Value, cboShift.Text, cboPallet.Text, cboLabel.Text, _
                                    cboWarehouse.Text, cboCartons.Text, "Yes", "", "", "", "", "", "", "", "")
                            Else
                                saveNewPallet(txtDate.Value, cboShift.Text, cboPallet.Text, cboLabel.Text, _
                                    cboWarehouse.Text, cboCartons.Text, "No", "", "", "", "", "", "", "", "")
                            End If

                            Dim ctr As Integer
                            While ctr < grid.RowCount
                                If CStr(grid.Item(ctr, 0)).StartsWith("F") Or CStr(grid.Item(ctr, 0)).StartsWith("R") Or CStr(grid.Item(ctr, 0)).StartsWith("LA") Then
                                    'If CDbl(grid.Item(ctr, 6)) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                    saveNewPallet_Details(cboPallet.Text, grid.Item(ctr, 4), "%", grid.Item(ctr, 2), _
                                        grid.Item(ctr, 0), grid.Item(ctr, 6), grid.Item(ctr, 7), "", _
                                        "", cboLabel.Text, grid.Item(ctr, 3), grid.Item(ctr, 1), grid.Item(ctr, 8), grid.Item(ctr, 9), "", "", "", "")
                                    'Else
                                    '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                    '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                    'End If
                                Else
                                    'If (CDbl(grid.Item(ctr, 6)) * getCansPerCase(getProductCanSize(grid.Item(ctr, 0)), "CAN SIZE")) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                    saveNewPallet_Details(cboPallet.Text, grid.Item(ctr, 4), "%", grid.Item(ctr, 2), _
                                        grid.Item(ctr, 0), grid.Item(ctr, 6), grid.Item(ctr, 7), "", _
                                        "", cboLabel.Text, grid.Item(ctr, 3), grid.Item(ctr, 1), grid.Item(ctr, 8), grid.Item(ctr, 9), "", "", "", "")
                                    'Else
                                    '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                    '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                    'End If
                                End If

                                ctr += 1
                            End While

                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmdNew.Focus()
                        End If
                    End If
                Else
                    If Not isDataEntryFieldsAreEmpty() Then
                        reply = MsgBox("Are you sure you want to process this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            If chkUnlabel.Checked = True Then
                                updatePallet(txtDate.Value, cboShift.Text, cboPallet.Text, cboLabel.Text, _
                                    cboWarehouse.Text, cboCartons.Text, "Yes", "", "", "", "", "", "")
                            Else
                                updatePallet(txtDate.Value, cboShift.Text, cboPallet.Text, cboLabel.Text, _
                                cboWarehouse.Text, cboCartons.Text, "No", "", "", "", "", "", "")
                            End If

                            deletePalletDetails(cboPallet.Text)

                            'Dim ctr As Integer
                            'While ctr < grid.RowCount
                            '    If (CDbl(grid.Item(ctr, 6)) * getCansPerCase(getProductCanSize(grid.Item(ctr, 0)), "CAN SIZE")) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                            '        saveNewPallet_Details(cboPallet.Text, grid.Item(ctr, 4), "%", grid.Item(ctr, 2), _
                            '            grid.Item(ctr, 0), grid.Item(ctr, 6), grid.Item(ctr, 7), "", _
                            '            "", cboLabel.Text, grid.Item(ctr, 3), grid.Item(ctr, 1))
                            '    Else
                            '        MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                            '            " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                            '    End If

                            '    ctr += 1
                            'End While
                            Dim ctr As Integer
                            While ctr < grid.RowCount
                                If CStr(grid.Item(ctr, 0)).StartsWith("F") Or CStr(grid.Item(ctr, 0)).StartsWith("R") Or CStr(grid.Item(ctr, 0)).StartsWith("LA") Then
                                    'If CDbl(grid.Item(ctr, 6)) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                    saveNewPallet_Details(cboPallet.Text, grid.Item(ctr, 4), "%", grid.Item(ctr, 2), _
                                        grid.Item(ctr, 0), grid.Item(ctr, 6), grid.Item(ctr, 7), "", _
                                        "", cboLabel.Text, grid.Item(ctr, 3), grid.Item(ctr, 1), grid.Item(ctr, 8), grid.Item(ctr, 9), "", "", "", "")
                                    'Else
                                    '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                    '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                    'End If
                                Else
                                    'If (CDbl(grid.Item(ctr, 6)) * getCansPerCase(getProductCanSize(grid.Item(ctr, 0)), "CAN SIZE")) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                    saveNewPallet_Details(cboPallet.Text, grid.Item(ctr, 4), "%", grid.Item(ctr, 2), _
                                        grid.Item(ctr, 0), grid.Item(ctr, 6), grid.Item(ctr, 7), "", _
                                        "", cboLabel.Text, grid.Item(ctr, 3), grid.Item(ctr, 1), grid.Item(ctr, 8), grid.Item(ctr, 9), "", "", "", "")
                                    'Else
                                    '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                    '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                    'End If
                                End If

                                ctr += 1
                            End While

                            MsgBox("Transaction successfully completed", MsgBoxStyle.Information, "Information")
                            cmdNew.Focus()
                        End If
                    End If
                End If
            Else
                MsgBox("Pallet Tag was partially/ fully withdrawn from the cold storage." & Chr(13) & _
                    "For details, please contact your Production Manager about this matter", MsgBoxStyle.Critical, "Restriction for editing")
                cboLabel.SelectAll()
                cboLabel.Focus()
            End If
        Else
            MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
            cboLabel.SelectAll()
            cboLabel.Focus()
        End If
    End Sub

    Public Function isDataEntryFieldsAreEmpty() As Boolean
        Try
            Dim ctr As Integer
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 4) = "" Or .Item(ctr, 5) = "" Or _
                        .Item(ctr, 6) = "" Or .Item(ctr, 7) = "" Then
                        'Or .Item(ctr, 7) = "" Or .Item(ctr, 8) = ""
                        MsgBox("Please check your data entry fields such as Product code, Lot No., Julian Date, Qty and MRN Nos., this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                        'Else
                        '    Return False
                    End If

                    ctr += 1
                End While
            End With

            Return False
        Catch e As Exception
            Dim ctr As Integer
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 4) Is DBNull.Value Or .Item(ctr, 5) Is DBNull.Value Or _
                    .Item(ctr, 6) Is DBNull.Value Or .Item(ctr, 7) Is DBNull.Value Then
                        'Or .Item(ctr, 7) Is DBNull.Value Or .Item(ctr, 8) Is DBNull.Value
                        MsgBox("Please check your data entry fields such as Product code, Lot No., Julian Date, Qty and MRN Nos., this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                        'Else
                        '    Return False
                    End If

                    ctr += 1
                End While
            End With

            Return False
        End Try
    End Function

    Public Sub searchPalletDetails(ByVal pallet As String)
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
                    txtDate.Value = dr.GetDateTime(0)
                    cboShift.Text = dr.GetString(1)
                    cboLabel.Text = dr.GetString(2)
                    cboWarehouse.Text = dr.GetString(3)
                    cboCartons.Text = dr.GetString(4)
                    If dr.GetString(5) = "Yes" Then
                        chkUnlabel.Checked = True
                    Else
                        chkUnlabel.Checked = False
                    End If
                Else
                    txtDate.Value = getServerDateTime()
                    cboShift.SelectedIndex = 0
                    cboLabel.Text = ""
                    cboWarehouse.Text = ""
                    cboCartons.Text = ""
                    chkUnlabel.Checked = False
                End If
            Else
                txtDate.Value = getServerDateTime()
                cboShift.SelectedIndex = 0
                cboLabel.Text = ""
                cboWarehouse.Text = ""
                cboCartons.Text = ""
                chkUnlabel.Checked = False
            End If

            'calculateWeights()
            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub mnuLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLabel.Click
        Dim f As New frmLabels
        f.ShowDialog(Me)

        displayLabels()
        cboLabel.SelectAll()
        cboLabel.Focus()
    End Sub

    Private Sub mnuWarehouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWarehouse.Click
        Dim f As New frmWarehouse
        f.ShowDialog(Me)

        displayWarehouse()
        cboWarehouse.SelectAll()
        cboWarehouse.Focus()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim f As New frmPrintLabeling
        'f.txtDate.Value = txtDate.Text
        'f.cboShift.Text = cboShift.Text
        'f.initializeShift()
        'f.ShowDialog(Me)
    End Sub

    Private Sub cboPallet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPallet.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDate.SelectAll()
            txtDate.Focus()
        End If
    End Sub

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLabel.SelectAll()
            cboLabel.Focus()
        End If
    End Sub

    Private Sub cboLabel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLabel.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCartons.SelectAll()
            cboCartons.Focus()
        End If
    End Sub

    Private Sub cboCartons_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCartons.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboWarehouse.SelectAll()
            cboWarehouse.Focus()
        End If
    End Sub

    Private Sub cboWarehouse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboWarehouse.KeyDown
        If e.KeyCode = Keys.Enter Then
            chkUnlabel.Focus()
        End If
    End Sub

    Private Sub chkUnlabel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkUnlabel.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid.Focus()
        End If
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Pallet Tags"
        f.searchType = 1
        f.displayAllPalletTags()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                cboPallet.Text = .Item(.Row, 2)
            End If
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(getProductSeamerQty(grid.Item(grid.Row, 4), grid.Item(grid.Row, 0), grid.Item(grid.Row, 1), grid.Item(grid.Row, 2)))
    End Sub
End Class
