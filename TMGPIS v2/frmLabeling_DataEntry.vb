
Public Class frmLabeling_DataEntry
    Inherits System.Windows.Forms.Form

    Dim prevRecord As Integer
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
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkUnlabel As System.Windows.Forms.CheckBox
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Buyer As System.Windows.Forms.Label
    Friend WithEvents cboBuyer As C1.Win.C1List.C1Combo
    Friend WithEvents txtEU As System.Windows.Forms.TextBox
    Friend WithEvents cboLabel As C1.Win.C1List.C1Combo
    Friend WithEvents cboCarton As C1.Win.C1List.C1Combo
    Friend WithEvents cboGrade As C1.Win.C1List.C1Combo
    Friend WithEvents cboWarehouse As C1.Win.C1List.C1Combo
    Friend WithEvents lblPallet As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuLabel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWarehouse As System.Windows.Forms.MenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGW As System.Windows.Forms.TextBox
    Friend WithEvents txtNW As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cboPShift As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboPLot As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboPCode As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cboPCode2 As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents lblPrevRecord As System.Windows.Forms.Label
    Friend WithEvents cboSublot As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLabeling_DataEntry))
        Me.cboShift = New C1.Win.C1List.C1Combo
        Me.txtDate = New C1.Win.C1Input.C1DateEdit
        Me.cboBuyer = New C1.Win.C1List.C1Combo
        Me.txtEU = New System.Windows.Forms.TextBox
        Me.cboLabel = New C1.Win.C1List.C1Combo
        Me.cboCarton = New C1.Win.C1List.C1Combo
        Me.cboGrade = New C1.Win.C1List.C1Combo
        Me.cboWarehouse = New C1.Win.C1List.C1Combo
        Me.chkUnlabel = New System.Windows.Forms.CheckBox
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblPallet = New System.Windows.Forms.Label
        Me.Buyer = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuLabel = New System.Windows.Forms.MenuItem
        Me.mnuWarehouse = New System.Windows.Forms.MenuItem
        Me.txtGW = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNW = New System.Windows.Forms.TextBox
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboPShift = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboPLot = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboPCode = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cboPCode2 = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.lblPrevRecord = New System.Windows.Forms.Label
        Me.cboSublot = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuyer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPCode2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cboShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboShift.EditorHeight = 18
        Me.cboShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(103, 130)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.Size = New System.Drawing.Size(144, 24)
        Me.cboShift.TabIndex = 4
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
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(103, 94)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(144, 23)
        Me.txtDate.TabIndex = 3
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboBuyer.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboBuyer.ContentHeight = 18
        Me.cboBuyer.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBuyer.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBuyer.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuyer.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBuyer.EditorHeight = 18
        Me.cboBuyer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuyer.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboBuyer.ItemHeight = 20
        Me.cboBuyer.Location = New System.Drawing.Point(103, 165)
        Me.cboBuyer.MatchEntryTimeout = CType(2000, Long)
        Me.cboBuyer.MaxDropDownItems = CType(5, Short)
        Me.cboBuyer.MaxLength = 32767
        Me.cboBuyer.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBuyer.Name = "cboBuyer"
        Me.cboBuyer.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBuyer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBuyer.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBuyer.Size = New System.Drawing.Size(225, 24)
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
        'txtEU
        '
        Me.txtEU.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEU.Location = New System.Drawing.Point(103, 198)
        Me.txtEU.Name = "txtEU"
        Me.txtEU.ReadOnly = True
        Me.txtEU.Size = New System.Drawing.Size(225, 23)
        Me.txtEU.TabIndex = 6
        Me.txtEU.TabStop = False
        Me.txtEU.Text = "SI-02-01-001"
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
        Me.cboLabel.Location = New System.Drawing.Point(440, 53)
        Me.cboLabel.MatchEntryTimeout = CType(2000, Long)
        Me.cboLabel.MaxDropDownItems = CType(10, Short)
        Me.cboLabel.MaxLength = 32767
        Me.cboLabel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLabel.Name = "cboLabel"
        Me.cboLabel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLabel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLabel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLabel.Size = New System.Drawing.Size(328, 24)
        Me.cboLabel.TabIndex = 7
        Me.cboLabel.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboCarton
        '
        Me.cboCarton.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCarton.AllowColMove = False
        Me.cboCarton.AutoCompletion = True
        Me.cboCarton.AutoDropDown = True
        Me.cboCarton.Caption = ""
        Me.cboCarton.CaptionHeight = 17
        Me.cboCarton.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCarton.ColumnCaptionHeight = 17
        Me.cboCarton.ColumnFooterHeight = 17
        Me.cboCarton.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCarton.ContentHeight = 18
        Me.cboCarton.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCarton.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCarton.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarton.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCarton.EditorHeight = 18
        Me.cboCarton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarton.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboCarton.ItemHeight = 20
        Me.cboCarton.Location = New System.Drawing.Point(440, 93)
        Me.cboCarton.MatchEntryTimeout = CType(2000, Long)
        Me.cboCarton.MaxDropDownItems = CType(10, Short)
        Me.cboCarton.MaxLength = 32767
        Me.cboCarton.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCarton.Name = "cboCarton"
        Me.cboCarton.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCarton.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCarton.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCarton.Size = New System.Drawing.Size(328, 24)
        Me.cboCarton.TabIndex = 8
        Me.cboCarton.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboGrade
        '
        Me.cboGrade.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboGrade.AllowColMove = False
        Me.cboGrade.AutoCompletion = True
        Me.cboGrade.AutoDropDown = True
        Me.cboGrade.Caption = ""
        Me.cboGrade.CaptionHeight = 17
        Me.cboGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboGrade.ColumnCaptionHeight = 17
        Me.cboGrade.ColumnFooterHeight = 17
        Me.cboGrade.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboGrade.ContentHeight = 18
        Me.cboGrade.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboGrade.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboGrade.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrade.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGrade.EditorHeight = 18
        Me.cboGrade.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrade.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboGrade.ItemHeight = 20
        Me.cboGrade.Location = New System.Drawing.Point(440, 130)
        Me.cboGrade.MatchEntryTimeout = CType(2000, Long)
        Me.cboGrade.MaxDropDownItems = CType(5, Short)
        Me.cboGrade.MaxLength = 32767
        Me.cboGrade.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboGrade.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboGrade.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboGrade.Size = New System.Drawing.Size(144, 24)
        Me.cboGrade.TabIndex = 9
        Me.cboGrade.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.cboWarehouse.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboWarehouse.ItemHeight = 20
        Me.cboWarehouse.Location = New System.Drawing.Point(440, 165)
        Me.cboWarehouse.MatchEntryTimeout = CType(2000, Long)
        Me.cboWarehouse.MaxDropDownItems = CType(5, Short)
        Me.cboWarehouse.MaxLength = 32767
        Me.cboWarehouse.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboWarehouse.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboWarehouse.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboWarehouse.Size = New System.Drawing.Size(328, 24)
        Me.cboWarehouse.TabIndex = 10
        Me.cboWarehouse.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        Me.chkUnlabel.Location = New System.Drawing.Point(440, 197)
        Me.chkUnlabel.Name = "chkUnlabel"
        Me.chkUnlabel.TabIndex = 11
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(13, 232)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(960, 240)
        Me.grid.TabIndex = 12
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Tahoma, 8.25pt, style=Bold;}HighlightRow{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;" & _
        "}Style15{}Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor" & _
        ":ControlText;BackColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12" & _
        "{}Style13{}Style1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowC" & _
        "olMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterH" & _
        "eight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWid" & _
        "th=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>236</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 956, 236</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>17</DefaultRecSelWidth><ClientArea>0, 0, 956, 236</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(616, 476)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 52
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(536, 476)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 51
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(376, 476)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 48
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(296, 476)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 49
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(456, 476)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 50
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Pallet No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Shift"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 54
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
        Me.Label1.Size = New System.Drawing.Size(986, 40)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Labeling and Case-up Information"
        '
        'lblPallet
        '
        Me.lblPallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPallet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPallet.Location = New System.Drawing.Point(103, 54)
        Me.lblPallet.Name = "lblPallet"
        Me.lblPallet.Size = New System.Drawing.Size(225, 32)
        Me.lblPallet.TabIndex = 57
        '
        'Buyer
        '
        Me.Buyer.AutoSize = True
        Me.Buyer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buyer.Location = New System.Drawing.Point(16, 168)
        Me.Buyer.Name = "Buyer"
        Me.Buyer.Size = New System.Drawing.Size(39, 19)
        Me.Buyer.TabIndex = 60
        Me.Buyer.Text = "Buyer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 19)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Product Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Reg Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(352, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 19)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Loin Grade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(352, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 19)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Carton"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(352, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 19)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Unlabelled"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 19)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Warehouse"
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
        'txtGW
        '
        Me.txtGW.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGW.Location = New System.Drawing.Point(880, 54)
        Me.txtGW.Name = "txtGW"
        Me.txtGW.ReadOnly = True
        Me.txtGW.Size = New System.Drawing.Size(96, 23)
        Me.txtGW.TabIndex = 65
        Me.txtGW.Text = "0"
        Me.txtGW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(792, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 19)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Gross Weight"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(792, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Net Weight"
        '
        'txtNW
        '
        Me.txtNW.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNW.Location = New System.Drawing.Point(880, 94)
        Me.txtNW.Name = "txtNW"
        Me.txtNW.ReadOnly = True
        Me.txtNW.Size = New System.Drawing.Size(96, 23)
        Me.txtNW.TabIndex = 68
        Me.txtNW.Text = "0"
        Me.txtNW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(792, 160)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(184, 56)
        Me.txtRemarks.TabIndex = 69
        Me.txtRemarks.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(792, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 19)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Remarks"
        '
        'cboPShift
        '
        Me.cboPShift.AllowColMove = True
        Me.cboPShift.AllowColSelect = True
        Me.cboPShift.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboPShift.AlternatingRows = False
        Me.cboPShift.CaptionHeight = 17
        Me.cboPShift.ColumnCaptionHeight = 17
        Me.cboPShift.ColumnFooterHeight = 17
        Me.cboPShift.FetchRowStyles = False
        Me.cboPShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPShift.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.cboPShift.Location = New System.Drawing.Point(152, 232)
        Me.cboPShift.Name = "cboPShift"
        Me.cboPShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPShift.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboPShift.RowHeight = 20
        Me.cboPShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPShift.ScrollTips = False
        Me.cboPShift.Size = New System.Drawing.Size(101, 240)
        Me.cboPShift.TabIndex = 71
        Me.cboPShift.Text = "C1TrueDBDropdown1"
        Me.cboPShift.Visible = False
        Me.cboPShift.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style9{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackC" & _
        "olor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>236</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 97, 236</ClientRect><BorderSide>0<" & _
        "/BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 97, 236</ClientArea></Blob>"
        '
        'cboPLot
        '
        Me.cboPLot.AllowColMove = True
        Me.cboPLot.AllowColSelect = True
        Me.cboPLot.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboPLot.AlternatingRows = False
        Me.cboPLot.CaptionHeight = 17
        Me.cboPLot.ColumnCaptionHeight = 17
        Me.cboPLot.ColumnFooterHeight = 17
        Me.cboPLot.FetchRowStyles = False
        Me.cboPLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPLot.Images.Add(CType(resources.GetObject("resource8"), System.Drawing.Image))
        Me.cboPLot.Location = New System.Drawing.Point(368, 232)
        Me.cboPLot.Name = "cboPLot"
        Me.cboPLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPLot.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboPLot.RowHeight = 20
        Me.cboPLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPLot.ScrollTips = False
        Me.cboPLot.Size = New System.Drawing.Size(101, 240)
        Me.cboPLot.TabIndex = 72
        Me.cboPLot.Text = "C1TrueDBDropdown1"
        Me.cboPLot.Visible = False
        Me.cboPLot.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Alig" & _
        "nVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>236</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 97, 236</ClientRect><BorderSide>0<" & _
        "/BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 97, 236</ClientArea></Blob>"
        '
        'cboPCode
        '
        Me.cboPCode.AllowColMove = True
        Me.cboPCode.AllowColSelect = True
        Me.cboPCode.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboPCode.AlternatingRows = False
        Me.cboPCode.CaptionHeight = 17
        Me.cboPCode.ColumnCaptionHeight = 17
        Me.cboPCode.ColumnFooterHeight = 17
        Me.cboPCode.FetchRowStyles = False
        Me.cboPCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPCode.Images.Add(CType(resources.GetObject("resource9"), System.Drawing.Image))
        Me.cboPCode.Location = New System.Drawing.Point(472, 232)
        Me.cboPCode.Name = "cboPCode"
        Me.cboPCode.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPCode.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboPCode.RowHeight = 20
        Me.cboPCode.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPCode.ScrollTips = False
        Me.cboPCode.Size = New System.Drawing.Size(101, 240)
        Me.cboPCode.TabIndex = 73
        Me.cboPCode.Text = "C1TrueDBDropdown1"
        Me.cboPCode.Visible = False
        Me.cboPCode.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Alig" & _
        "nVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>236</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 97, 236</ClientRect><BorderSide>0<" & _
        "/BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 97, 236</ClientArea></Blob>"
        '
        'cboPCode2
        '
        Me.cboPCode2.AllowColMove = True
        Me.cboPCode2.AllowColSelect = True
        Me.cboPCode2.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboPCode2.AlternatingRows = False
        Me.cboPCode2.CaptionHeight = 17
        Me.cboPCode2.ColumnCaptionHeight = 17
        Me.cboPCode2.ColumnFooterHeight = 17
        Me.cboPCode2.FetchRowStyles = False
        Me.cboPCode2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPCode2.Images.Add(CType(resources.GetObject("resource10"), System.Drawing.Image))
        Me.cboPCode2.Location = New System.Drawing.Point(576, 232)
        Me.cboPCode2.Name = "cboPCode2"
        Me.cboPCode2.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPCode2.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboPCode2.RowHeight = 20
        Me.cboPCode2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPCode2.ScrollTips = False
        Me.cboPCode2.Size = New System.Drawing.Size(101, 240)
        Me.cboPCode2.TabIndex = 74
        Me.cboPCode2.Text = "C1TrueDBDropdown1"
        Me.cboPCode2.Visible = False
        Me.cboPCode2.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Alig" & _
        "nVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>236</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 97, 236</ClientRect><BorderSide>0<" & _
        "/BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 97, 236</ClientArea></Blob>"
        '
        'lblPrevRecord
        '
        Me.lblPrevRecord.AutoSize = True
        Me.lblPrevRecord.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevRecord.Location = New System.Drawing.Point(696, 200)
        Me.lblPrevRecord.Name = "lblPrevRecord"
        Me.lblPrevRecord.Size = New System.Drawing.Size(12, 19)
        Me.lblPrevRecord.TabIndex = 75
        Me.lblPrevRecord.Text = "0"
        Me.lblPrevRecord.Visible = False
        '
        'cboSublot
        '
        Me.cboSublot.AllowColMove = True
        Me.cboSublot.AllowColSelect = True
        Me.cboSublot.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSublot.AlternatingRows = False
        Me.cboSublot.CaptionHeight = 17
        Me.cboSublot.ColumnCaptionHeight = 17
        Me.cboSublot.ColumnFooterHeight = 17
        Me.cboSublot.FetchRowStyles = False
        Me.cboSublot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSublot.Images.Add(CType(resources.GetObject("resource11"), System.Drawing.Image))
        Me.cboSublot.Location = New System.Drawing.Point(264, 232)
        Me.cboSublot.Name = "cboSublot"
        Me.cboSublot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSublot.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboSublot.RowHeight = 20
        Me.cboSublot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSublot.ScrollTips = False
        Me.cboSublot.Size = New System.Drawing.Size(101, 240)
        Me.cboSublot.TabIndex = 76
        Me.cboSublot.Text = "C1TrueDBDropdown1"
        Me.cboSublot.Visible = False
        Me.cboSublot.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:HighlightText" & _
        ";BackColor:Highlight;}Style9{}OddRow{}RecordSelector{AlignImage:Center;}Heading{" & _
        "Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackC" & _
        "olor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{" & _
        "}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.DropdownView Name="""" CaptionHeight" & _
        "=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellB" & _
        "order"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>236</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 97, 236</ClientRect><BorderSide>0<" & _
        "/BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 97, 236</ClientArea></Blob>"
        '
        'frmLabeling_DataEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(986, 528)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.cboSublot)
        Me.Controls.Add(Me.lblPrevRecord)
        Me.Controls.Add(Me.cboPCode2)
        Me.Controls.Add(Me.cboPCode)
        Me.Controls.Add(Me.cboPLot)
        Me.Controls.Add(Me.cboPShift)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtNW)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGW)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Buyer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPallet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.chkUnlabel)
        Me.Controls.Add(Me.cboWarehouse)
        Me.Controls.Add(Me.cboGrade)
        Me.Controls.Add(Me.cboCarton)
        Me.Controls.Add(Me.cboLabel)
        Me.Controls.Add(Me.txtEU)
        Me.Controls.Add(Me.cboBuyer)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtDate)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLabeling_DataEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLabeling_DataEntry"
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuyer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPCode2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmLabeling_DataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()
        initializeShift()

        'displayPallet()
        displayBuyer()
        displayLabels()
        displayCartons()
        displayWarehouse()
        displayLoinGrade()

        displayPalletDetails(lblPallet.Text)
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

    Public Sub displayBuyer()
        With cboBuyer
            .DataSource = modModule.getAllBuyer().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
        End With
    End Sub

    Public Sub displayLoinGrade()
        With cboGrade
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Loin Grade")
            .AddItem("PU")
            .AddItem("BU")
            .AddItem("SU")
            .Splits(0).DisplayColumns(0).Width = 120
            '.SelectedIndex = 0
        End With
    End Sub

    Public Sub displayLabels()
        With cboLabel
            .DataSource = modModule.getLabels().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 307
        End With
    End Sub

    Public Sub displayCartons()
        With cboCarton
            .DataSource = modModule.getAllMaterials_ByCategory("Cartons").Tables(0)
            .Splits(0).DisplayColumns(0).Width = 307
        End With
    End Sub

    Public Sub displayWarehouse()
        With cboWarehouse
            .DataSource = modModule.getWarehouse().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 307

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayPalletDetails(ByVal pallet As String)
        With grid
            .DataSource = modModule.getPalletDetails(pallet).Tables(0)
            .Columns(1).DropDown = cboPShift
            .Columns(3).DropDown = cboPLot
            .Columns(4).DropDown = cboSublot
            .Columns(5).DropDown = cboPCode
            .Columns(6).DropDown = cboPCode2
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Splits(0).DisplayColumns(3).DropDownList = True
            .Splits(0).DisplayColumns(4).DropDownList = True
            .Splits(0).DisplayColumns(5).DropDownList = True
            .Splits(0).DisplayColumns(6).DropDownList = True

            .Splits(0).DisplayColumns(0).Width = 85 '100
            .Splits(0).DisplayColumns(1).Width = 40 '65
            .Splits(0).DisplayColumns(2).Width = 60 '65
            .Splits(0).DisplayColumns(3).Width = 60 '90
            .Splits(0).DisplayColumns(4).Width = 90 '90
            .Splits(0).DisplayColumns(5).Width = 85
            .Splits(0).DisplayColumns(6).Width = 70    '5
            .Splits(0).DisplayColumns(7).Width = 80    '5
            .Splits(0).DisplayColumns(8).Width = 75
            .Splits(0).DisplayColumns(9).Width = 40
            .Splits(0).DisplayColumns(10).Width = 140
            .Splits(0).DisplayColumns(11).Width = 85

            .Splits(0).DisplayColumns(11).Locked = True                  '5
            .Splits(0).DisplayColumns(11).Style.BackColor = Color.Gray   '5

            .Columns(0).NumberFormat = "dd/MM/yyyy"
            .Columns(0).DefaultValue = Format(getServerDateTime(), "dd/MM/yyyy")
            .Columns(1).DefaultValue = ""
            .Columns(7).DefaultValue = 0
            .Columns(7).NumberFormat = "#####0"
            .Columns(8).DefaultValue = 0
            .Columns(8).NumberFormat = "##0"
            .Columns(11).NumberFormat = "dd/MM/yyyy"

            computeWeights()
        End With
    End Sub

    Public Sub displayProductDetails()
        Dim ctr, toAddCases As Integer
        Dim cases, tins As Double
        Dim shift, pCode, subCode, lot, sublot, julian As String
        Dim prodnDate As DateTime

        With grid
            'While ctr < .RowCount
            ctr = .Row ' prevRecord

            If Not .Item(ctr, 0) Is DBNull.Value And Not CStr(.Item(ctr, 0)) = "" Then
                Try
                    If .Item(ctr, 0) Is DBNull.Value Then
                        julian = "0"
                        prodnDate = getServerDateTime()
                    Else
                        julian = CDate(.Item(ctr, 0)).DayOfYear
                        prodnDate = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) Is DBNull.Value Then
                        shift = ""
                    Else
                        shift = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 3) Is DBNull.Value Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 4) Is DBNull.Value Then
                        sublot = ""
                    Else
                        sublot = .Item(ctr, 4)
                    End If

                    If .Item(ctr, 5) Is DBNull.Value Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 5)
                    End If

                    If .Item(ctr, 6) Is DBNull.Value Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 6)
                    End If

                    If .Item(ctr, 7) Is DBNull.Value Then   '6
                        cases = 0
                    Else
                        cases = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 8) Is DBNull.Value Then   '7
                        tins = 0
                    Else
                        tins = .Item(ctr, 8)
                    End If
                Catch e As Exception
                    If CStr(.Item(ctr, 0)) = "" Then
                        julian = "0"
                        prodnDate = getServerDateTime()
                    Else
                        julian = CDate(.Item(ctr, 0)).DayOfYear
                        prodnDate = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) = "" Then
                        shift = ""
                    Else
                        shift = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 3) = "" Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 4) = "" Then
                        sublot = ""
                    Else
                        sublot = .Item(ctr, 4)
                    End If

                    If .Item(ctr, 5) = "" Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 5)
                    End If

                    If .Item(ctr, 6) = "" Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 6)
                    End If

                    If .Item(ctr, 7) = "" Then  '6
                        cases = 0
                    Else
                        cases = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 8) = "" Then  '7
                        tins = 0
                    Else
                        tins = .Item(ctr, 8)
                    End If
                End Try

                cboPShift.DefColWidth = 93
                cboPShift.DataSource = displayProductOutputShift(pCode, subCode, lot, prodnDate, shift, "shift", sublot).Tables(0)
                If cboPShift.RowCount <= 0 Then
                    .Item(ctr, 1) = ""
                End If

                cboPLot.DefColWidth = 93
                cboPLot.DataSource = displayProductOutputShift(pCode, subCode, lot, prodnDate, shift, "lot", sublot).Tables(0)
                If cboPLot.RowCount <= 0 Then
                    .Item(ctr, 3) = ""
                End If

                cboSublot.DefColWidth = 93
                cboSublot.DataSource = displayProductOutputShift(pCode, subCode, lot, prodnDate, shift, "sublot", sublot).Tables(0)
                If cboSublot.RowCount <= 0 Then
                    .Item(ctr, 4) = ""
                End If

                cboPCode.DefColWidth = 93
                cboPCode.DataSource = displayProductOutputShift(pCode, subCode, lot, prodnDate, shift, "pCode", sublot).Tables(0)
                If cboPCode.RowCount <= 0 Then
                    .Item(ctr, 5) = ""
                End If

                cboPCode2.DefColWidth = 93
                cboPCode2.DataSource = displayProductOutputShift(pCode, subCode, lot, prodnDate, shift, "pCode2", sublot).Tables(0)
                If cboPCode2.RowCount <= 0 Then
                    .Item(ctr, 6) = ""
                End If

                Try
                    If .Item(ctr, 0) Is DBNull.Value Then
                        julian = "0"
                        prodnDate = getServerDateTime()
                    Else
                        julian = CDate(.Item(ctr, 0)).DayOfYear
                        prodnDate = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) Is DBNull.Value Then
                        shift = ""
                    Else
                        shift = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 3) Is DBNull.Value Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 4) Is DBNull.Value Then
                        sublot = ""
                    Else
                        sublot = .Item(ctr, 4)
                    End If

                    If .Item(ctr, 5) Is DBNull.Value Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 5)
                    End If

                    If .Item(ctr, 6) Is DBNull.Value Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 6)
                    End If

                    If .Item(ctr, 7) Is DBNull.Value Then   '6
                        cases = 0
                    Else
                        cases = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 8) Is DBNull.Value Then   '7
                        tins = 0
                    Else
                        tins = .Item(ctr, 8)
                    End If
                Catch e As Exception
                    If CStr(.Item(ctr, 0)) = "" Then
                        julian = "0"
                        prodnDate = getServerDateTime()
                    Else
                        julian = CDate(.Item(ctr, 0)).DayOfYear
                        prodnDate = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) = "" Then
                        shift = ""
                    Else
                        shift = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 3) = "" Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 4) = "" Then
                        sublot = ""
                    Else
                        sublot = .Item(ctr, 4)
                    End If

                    If .Item(ctr, 5) = "" Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 5)
                    End If

                    If .Item(ctr, 6) = "" Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 6)
                    End If

                    If .Item(ctr, 7) = "" Then  '6
                        cases = 0
                    Else
                        cases = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 8) = "" Then  '7
                        tins = 0
                    Else
                        tins = .Item(ctr, 8)
                    End If
                End Try

                .Item(ctr, 11) = getProductOutputShift(pCode, subCode, lot, prodnDate, shift, "bbe", sublot)

                Try
                    If getCansPerCase(getProductCanSize(pCode), "CAN SIZE") > 0 Then  'getProductCansPerCase(julian, lot, pCode)
                        If tins >= getCansPerCase(getProductCanSize(pCode), "CAN SIZE") Then    'getProductCansPerCase(julian, lot, pCode)
                            'MsgBox("No. of cans is allowed only up to " & getLabelPerCase(cboLabel.Text) & " cans per case for " & cboLabel.Text, MsgBoxStyle.Exclamation, "Warning")

                            toAddCases = (tins \ getCansPerCase(getProductCanSize(pCode), "CAN SIZE"))  'getProductCansPerCase(julian, lot, pCode)
                            'toAddCases = toAddCases

                            .Item(ctr, 7) = cases + toAddCases
                            .Item(ctr, 8) = (tins Mod getCansPerCase(getProductCanSize(pCode), "CAN SIZE"))    'getProductCansPerCase(julian, lot, pCode)
                        End If
                    End If
                Catch ex As Exception
                    If getCansPerCase(getProductCanSize(pCode), "CAN SIZE") > 0 Then    'getProductCansPerCase(julian, lot, pCode)
                        If tins >= getCansPerCase(getProductCanSize(pCode), "CAN SIZE") Then    'getProductCansPerCase(julian, lot, pCode)
                            'MsgBox("No. of cans is allowed only up to " & getLabelPerCase(cboLabel.Text) & " cans per case for " & cboLabel.Text, MsgBoxStyle.Exclamation, "Warning")

                            toAddCases = (tins \ getCansPerCase(getProductCanSize(pCode), "CAN SIZE"))  'getProductCansPerCase(julian, lot, pCode)
                            'toAddCases = System.Math.Round(toAddCases, 0)

                            .Item(ctr, 7) = cases + toAddCases
                            .Item(ctr, 8) = (tins Mod getCansPerCase(getProductCanSize(pCode), "CAN SIZE")) 'getProductCansPerCase(julian, lot, pCode)
                        End If
                    End If
                End Try

                'ctr += 1
                'End While
            End If
        End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        displayProductDetails()
        computeWeights()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Pallet Tags"
        f.searchType = 1
        f.displayAllPalletTags()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblPallet.Text = .Item(.Row, 2)
                searchPalletDetails(lblPallet.Text)
                displayPalletDetails(lblPallet.Text)
            End If
        End With
    End Sub

    Private Sub cboLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLabel.TextChanged
        If cboLabel.Text.StartsWith("Albacore") Or cboLabel.Text.StartsWith("Skip") Or cboLabel.Text.StartsWith("Yellow") Then
            cboCarton.Text = "Carton - Loins"
            cboCarton.ReadOnly = True
        Else
            cboCarton.Text = ""
            cboCarton.ReadOnly = False
        End If
        displayProductDetails()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        txtDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        lblPallet.Text = ""
        cboBuyer.Text = ""
        txtEU.Text = "EU No. SI-02-01-001"
        'displayPallet()
        cboLabel.Text = ""
        displayLabels()
        cboCarton.Text = ""
        displayCartons()
        cboGrade.Text = ""
        cboWarehouse.Text = ""
        displayWarehouse()
        displayPalletDetails(lblPallet.Text)
        txtGW.Text = "0"
        txtNW.Text = "0"
        txtRemarks.Text = ""

        txtDate.SelectAll()
        txtDate.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        computeWeights()
        Dim reply As String

        If Not cboLabel.Text.Trim = "" And Not cboBuyer.Text.Trim = "" And _
        Not cboWarehouse.Text.Trim = "" And grid.RowCount > 0 And Not cboCarton.Text.Trim = "" Then
            'If checkIfProductDetailsAreValid() Then
            If Not validateWithdrawnPallet(lblPallet.Text) Then
                If Not validatePallet(lblPallet.Text.Trim) Then
                    If Not isDataEntryFieldsAreEmpty() Then
                        If lblPallet.Text.Trim = "" Then
                            displayPalletTag()
                        End If

                        reply = MsgBox("Are you sure you want to process this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            If chkUnlabel.Checked = True Then
                                saveNewPallet(txtDate.Value, cboShift.Text, lblPallet.Text, cboLabel.Text, _
                                    cboWarehouse.Text, cboCarton.Text, "Yes", cboBuyer.Text, txtEU.Text, _
                                    cboGrade.Text, Format(getServerDateTime(), "yy"), identifyProduct(), txtGW.Text, _
                                    txtNW.Text, txtRemarks.Text)
                            Else
                                saveNewPallet(txtDate.Value, cboShift.Text, lblPallet.Text, cboLabel.Text, _
                                    cboWarehouse.Text, cboCarton.Text, "No", cboBuyer.Text, txtEU.Text, _
                                    cboGrade.Text, Format(getServerDateTime(), "yy"), identifyProduct(), txtGW.Text, _
                                    txtNW.Text, txtRemarks.Text)
                            End If

                            Dim ctr As Integer
                            Dim remarks, tagNo As String
                            While ctr < grid.RowCount
                                If grid.Item(ctr, 10) Is DBNull.Value Then
                                    remarks = ""
                                Else
                                    remarks = grid.Item(ctr, 10)
                                End If

                                If grid.Item(ctr, 2) Is DBNull.Value Then
                                    tagNo = ""
                                Else
                                    tagNo = grid.Item(ctr, 2)
                                End If

                                If CStr(grid.Item(ctr, 5)).StartsWith("F") Or CStr(grid.Item(ctr, 5)).StartsWith("R") Or CStr(grid.Item(ctr, 5)).StartsWith("LA") Then
                                    'If CDbl(grid.Item(ctr, 6)) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                    saveNewPallet_Details(lblPallet.Text, grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                        grid.Item(ctr, 5), grid.Item(ctr, 7), grid.Item(ctr, 8), "", _
                                        "", cboLabel.Text, CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 6), "0", "0", grid.Item(ctr, 9), remarks, tagNo, grid.Item(ctr, 4))
                                    'Else
                                    '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                    '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                    'End If
                                Else
                                    'If (CDbl(grid.Item(ctr, 6)) * getCansPerCase(getProductCanSize(grid.Item(ctr, 0)), "CAN SIZE")) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                    saveNewPallet_Details(lblPallet.Text, grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                          grid.Item(ctr, 5), grid.Item(ctr, 7), grid.Item(ctr, 8), "", _
                                          "", cboLabel.Text, CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 6), "0", "0", grid.Item(ctr, 9), remarks, tagNo, grid.Item(ctr, 4))
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
                    If getPalletLockStatus(lblPallet.Text) = "N" Or getPositionUser() = "System Administrator" Or getPositionUser() = "Production Manager" Then
                        If Not isDataEntryFieldsAreEmpty() Then
                            reply = MsgBox("Are you sure you want to update this existing pallet tag?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                            If reply = vbYes Then
                                If chkUnlabel.Checked = True Then
                                    updatePallet(txtDate.Value, cboShift.Text, lblPallet.Text, cboLabel.Text, _
                                        cboWarehouse.Text, cboCarton.Text, "Yes", cboBuyer.Text, txtEU.Text, cboGrade.Text, _
                                        txtGW.Text, txtNW.Text, txtRemarks.Text)
                                Else
                                    updatePallet(txtDate.Value, cboShift.Text, lblPallet.Text, cboLabel.Text, _
                                        cboWarehouse.Text, cboCarton.Text, "No", cboBuyer.Text, txtEU.Text, cboGrade.Text, _
                                        txtGW.Text, txtNW.Text, txtRemarks.Text)
                                End If

                                deletePalletDetails(lblPallet.Text)

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
                                Dim remarks, tagNo As String
                                While ctr < grid.RowCount
                                    If grid.Item(ctr, 10) Is DBNull.Value Then
                                        remarks = ""
                                    Else
                                        remarks = grid.Item(ctr, 10)
                                    End If

                                    If grid.Item(ctr, 2) Is DBNull.Value Then
                                        tagNo = ""
                                    Else
                                        tagNo = grid.Item(ctr, 2)
                                    End If

                                    If CStr(grid.Item(ctr, 5)).StartsWith("F") Or CStr(grid.Item(ctr, 5)).StartsWith("R") Or CStr(grid.Item(ctr, 5)).StartsWith("LA") Then
                                        'If CDbl(grid.Item(ctr, 6)) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                        saveNewPallet_Details(lblPallet.Text, grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                            grid.Item(ctr, 5), grid.Item(ctr, 7), grid.Item(ctr, 8), "", _
                                            "", cboLabel.Text, CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 6), "0", "0", grid.Item(ctr, 9), remarks, tagNo, grid.Item(ctr, 4))
                                        'Else
                                        '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                        '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                        'End If
                                    Else
                                        'If (CDbl(grid.Item(ctr, 6)) * getCansPerCase(getProductCanSize(grid.Item(ctr, 0)), "CAN SIZE")) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                        saveNewPallet_Details(lblPallet.Text, grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                              grid.Item(ctr, 5), grid.Item(ctr, 7), grid.Item(ctr, 8), "", _
                                              "", cboLabel.Text, CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 6), "0", "0", grid.Item(ctr, 9), remarks, tagNo, grid.Item(ctr, 4))
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
                    Else
                        MsgBox("Please contact your Production Manager to override this editing", MsgBoxStyle.Exclamation, "Warning")
                        cmdFind.Focus()
                    End If
                End If
            Else
                MsgBox("Pallet Tag was partially/ fully withdrawn from the cold storage." & Chr(13) & _
                       "For details, please contact your Production Manager about this matter", MsgBoxStyle.Critical, "Restriction for editing")
                txtDate.SelectAll()
                txtDate.Focus()
            End If
            'Else
            '    MsgBox("Please verify your product details correctly", MsgBoxStyle.Critical, "Result: Invalid input")
            '    grid.Focus()
            'End If
        Else
            MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
            txtDate.SelectAll()
            txtDate.Focus()
        End If
    End Sub

    Public Function isDataEntryFieldsAreEmpty() As Boolean
        Try
            Dim ctr As Integer
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 0) = "" Or .Item(ctr, 1) = "" Or .Item(ctr, 2) = "" Or _
                        .Item(ctr, 3) = "" Or .Item(ctr, 4) = "" Or .Item(ctr, 5) = "" Or _
                        .Item(ctr, 6) = "" Or .Item(ctr, 7) = "" Or .Item(ctr, 8) = "" Or _
                        .Item(ctr, 9) = "" Or .Item(ctr, 11) = "" Then
                        MsgBox("Please check the Production Details (1 to 8 column and 10th), this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
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
                    If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or .Item(ctr, 2) Is DBNull.Value Or _
                    .Item(ctr, 3) Is DBNull.Value Or .Item(ctr, 4) Is DBNull.Value Or .Item(ctr, 5) Is DBNull.Value Or _
                    .Item(ctr, 6) Is DBNull.Value Or .Item(ctr, 7) Is DBNull.Value Or .Item(ctr, 8) Is DBNull.Value Or _
                    .Item(ctr, 9) Is DBNull.Value Or .Item(ctr, 11) Is DBNull.Value Then
                        MsgBox("Please check the Production Details (1 to 8 column and 10th), this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
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
                    cboCarton.Text = dr.GetString(4)
                    If dr.GetString(5) = "Yes" Then
                        chkUnlabel.Checked = True
                    Else
                        chkUnlabel.Checked = False
                    End If
                    cboBuyer.Text = dr.GetString(6)
                    txtEU.Text = dr.GetString(7)
                    cboGrade.Text = dr.GetString(8)
                    txtGW.Text = Format(dr.GetDouble(9), "###,##0.#0")
                    txtNW.Text = Format(dr.GetDouble(10), "###,##0.#0")
                    txtRemarks.Text = dr.GetString(11)
                Else
                    txtDate.Value = getServerDateTime()
                    cboShift.SelectedIndex = 0
                    cboLabel.Text = ""
                    cboWarehouse.Text = ""
                    cboCarton.Text = ""
                    chkUnlabel.Checked = False
                    cboBuyer.Text = ""
                    txtEU.Text = "EU No. SI-02-01-001"
                    cboGrade.Text = ""
                    txtGW.Text = "0.00"
                    txtNW.Text = "0.00"
                    txtRemarks.Text = ""
                End If
            Else
                txtDate.Value = getServerDateTime()
                cboShift.SelectedIndex = 0
                cboLabel.Text = ""
                cboWarehouse.Text = ""
                cboCarton.Text = ""
                chkUnlabel.Checked = False
                cboBuyer.Text = ""
                txtEU.Text = "EU No. SI-02-01-001"
                cboGrade.Text = ""
                txtGW.Text = "0.00"
                txtNW.Text = "0.00"
                txtRemarks.Text = ""
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
        Dim f As New frmPrintPalletTag
        f.pallet = lblPallet.Text
        f.productType = identifyProduct()
        f.rptReport.ShowPrintButton = False
        f.displayReport(lblPallet.Text, identifyProduct())
        f.ShowDialog(Me)
    End Sub

    Public Sub displayPalletTag()
        lblPallet.Text = Format(getServerDateTime(), "yy") & "-" & identifyProduct() & "-" & _
            Format(getPalletTagCounter(Format(getServerDateTime(), "yy"), identifyProduct()), "0####0")
    End Sub

    Public Function identifyProduct() As String
        Dim loins As Boolean
        With grid
            Dim ctr As Integer
            While ctr < .RowCount
                If Not .Item(ctr, 5) Is DBNull.Value Then
                    If CStr(.Item(ctr, 5)).StartsWith("L") Or CStr(.Item(ctr, 5)).StartsWith("F") Or CStr(.Item(ctr, 5)).StartsWith("R") Then
                        loins = True
                    Else
                        loins = False
                    End If
                Else
                    loins = False
                End If

                ctr += 1
            End While
        End With

        If loins Then
            'cboGrade.SelectedIndex = 0
            'cboGrade.ReadOnly = False
            Return "FZ"
        Else
            'cboGrade.Text = ""
            'cboGrade.ReadOnly = True
            Return "CN"
        End If
    End Function

    Private Sub txtGW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGW.TextChanged
        If Not IsNumeric(txtGW.Text) Or txtGW.Text.Trim = "" Then
            txtGW.Text = "0"
            txtGW.SelectAll()
            txtGW.Focus()
        End If
    End Sub

    Private Sub txtNW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNW.TextChanged
        If Not IsNumeric(txtNW.Text) Or txtNW.Text.Trim = "" Then
            txtNW.Text = "0"
            txtNW.SelectAll()
            txtNW.Focus()
        End If
    End Sub

    Private Sub cboBuyer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuyer.TextChanged
        If cboBuyer.Text.StartsWith("COSI") Or cboBuyer.Text.StartsWith("Chicken") Then
            txtEU.Text = "FR No. 10254007446"
        Else
            txtEU.Text = "EU No. SI-02-01-001"
        End If

        If cboBuyer.Text.StartsWith("Local") Then
            cboGrade.Text = ""
            cboGrade.ReadOnly = True
        Else
            cboGrade.ReadOnly = False
        End If
    End Sub

    Public Function getTotalBags() As Double
        Dim ctr As Integer
        Dim totalBags As Double
        With grid
            While ctr < .RowCount
                If CStr(.Item(ctr, 5)).StartsWith("LA") Or CStr(.Item(ctr, 5)).StartsWith("FA") Then
                    totalBags = totalBags + (.Item(ctr, 7) + .Item(ctr, 8))
                Else
                    totalBags = totalBags + ((.Item(ctr, 7) * getCansPerCase(getProductCanSize(.Item(ctr, 5)), "CAN SIZE")) + .Item(ctr, 8))
                End If

                ctr += 1
            End While
        End With

        Return totalBags
    End Function

    Public Sub computeWeights()
        Dim ctr As Integer
        Dim total, tinsPerCase As Double
        Dim prodnDate, pCode As String
        With grid
            If identifyProduct() = "FZ" Then
                While ctr < .RowCount
                    Try
                        If .Item(ctr, 0) Is DBNull.Value Then
                            prodnDate = Format(CDate(getServerDateTime()), "dd/MM/yyyy")
                        Else
                            prodnDate = .Item(ctr, 0)
                        End If

                        If .Item(ctr, 5) Is DBNull.Value Then
                            pCode = ""
                        Else
                            pCode = .Item(ctr, 5)
                        End If
                    Catch
                        If .Item(ctr, 0) = "" Then
                            prodnDate = Format(CDate(getServerDateTime()), "dd/MM/yyyy")
                        Else
                            prodnDate = .Item(ctr, 0)
                        End If

                        If .Item(ctr, 5) = "" Then
                            pCode = ""
                        Else
                            pCode = .Item(ctr, 5)
                        End If
                    End Try

                    tinsPerCase = getCanSize_tinsPerCase(pCode)

                    'total += (.Item(ctr, 6) * tinsPerCase) + .Item(ctr, 7) '* 
                    'total *= (getActualAverageFW(prodnDate, prodnDate, pCode) / 1000)

                    total = getTotalBags() * (getActualAverageFW(prodnDate, prodnDate, pCode) / 1000)

                    ctr += 1
                End While

                txtGW.Text = Format(total + getTare(pCode), "###,##0.#0")    'getPalletTare
                txtNW.Text = Format(total, "###,##0.#0") '(getActualAverageFW(prodnDate, prodnDate, pCode) / 1000)  'total
            Else
                txtGW.Text = "0"
                txtNW.Text = "0"
            End If
        End With
    End Sub

    Public Function getTare(ByVal pCode As String) As Double
        If getProductSpecie(pCode).StartsWith("Albacore") Then
            If getTotalBags() <= 54 Then
                Return 44
            Else
                Return 52
            End If
        Else
            Return getPalletTare()
        End If
    End Function

    Private Sub cboWarehouse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWarehouse.TextChanged
        If cboWarehouse.Text = "" Then If cboWarehouse.ListCount > 0 Then cboWarehouse.SelectedIndex = 0
    End Sub

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboBuyer.SelectAll()
            cboBuyer.Focus()
        End If
    End Sub

    Private Sub cboBuyer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBuyer.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLabel.SelectAll()
            cboLabel.Focus()
        End If
    End Sub

    Private Sub cboLabel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLabel.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCarton.SelectAll()
            cboCarton.Focus()
        End If
    End Sub

    Private Sub cboCarton_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCarton.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboGrade.SelectAll()
            cboGrade.Focus()
        End If
    End Sub

    Private Sub cboGrade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGrade.KeyDown
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
            txtRemarks.SelectAll()
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub txtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid.Focus()
        End If
    End Sub

    Public Function checkIfProductDetailsAreValid() As Boolean
        Try
            With grid
                Dim ctr As Integer
                While ctr < .RowCount
                    If getProductDetails_BySeamersRecord(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), "code") = "" Then Return False

                    ctr += 1
                End While
            End With

            Return True
        Catch e As Exception
            Return False
        End Try
    End Function

    Private Sub lblPallet_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPallet.DoubleClick
        Dim pallet As String = InputBox("Please enter pallet number to override", "Pallet Number Override")
        lblPallet.Text = pallet
    End Sub

    Private Sub grid_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.Change
        prevRecord = grid.RowCount
        lblPrevRecord.Text = prevRecord
    End Sub
End Class
