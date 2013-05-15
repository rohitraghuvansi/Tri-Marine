Public Class frmSICC_DataEntry
    Inherits System.Windows.Forms.Form

    Dim startup As Integer
    Dim editMode As Boolean
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblOcean As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboCC As C1.Win.C1List.C1Combo
    Friend WithEvents cboDelivery As C1.Win.C1List.C1Combo
    Friend WithEvents cboCarrier As C1.Win.C1List.C1Combo
    Friend WithEvents txtCarrierTrip As System.Windows.Forms.TextBox
    Friend WithEvents txtCarrierHatch As System.Windows.Forms.TextBox
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents txtDateDepart As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateArrive As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateUnload As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboAreaCode As C1.Win.C1List.C1Combo
    Friend WithEvents cboRefNo As C1.Win.C1List.C1Combo
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuMFV As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFAO As System.Windows.Forms.MenuItem
    Friend WithEvents cboPreservationMethod As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSICC_DataEntry))
        Me.cboCC = New C1.Win.C1List.C1Combo()
        Me.cboDelivery = New C1.Win.C1List.C1Combo()
        Me.cboCarrier = New C1.Win.C1List.C1Combo()
        Me.txtCarrierTrip = New System.Windows.Forms.TextBox()
        Me.txtCarrierHatch = New System.Windows.Forms.TextBox()
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.txtDateDepart = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateArrive = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateUnload = New C1.Win.C1Input.C1DateEdit()
        Me.cboAreaCode = New C1.Win.C1List.C1Combo()
        Me.cboRefNo = New C1.Win.C1List.C1Combo()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmd = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblOcean = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuMFV = New System.Windows.Forms.MenuItem()
        Me.mnuMFAO = New System.Windows.Forms.MenuItem()
        Me.cboPreservationMethod = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        CType(Me.cboCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarrier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateArrive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateUnload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAreaCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPreservationMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCC
        '
        Me.cboCC.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCC.AllowColMove = False
        Me.cboCC.AutoCompletion = True
        Me.cboCC.AutoDropDown = True
        Me.cboCC.Caption = ""
        Me.cboCC.CaptionHeight = 17
        Me.cboCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCC.ColumnCaptionHeight = 17
        Me.cboCC.ColumnFooterHeight = 17
        Me.cboCC.ContentHeight = 18
        Me.cboCC.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCC.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCC.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCC.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCC.EditorHeight = 18
        Me.cboCC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCC.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboCC.ItemHeight = 20
        Me.cboCC.Location = New System.Drawing.Point(104, 56)
        Me.cboCC.MatchEntryTimeout = CType(2000, Long)
        Me.cboCC.MaxDropDownItems = CType(20, Short)
        Me.cboCC.MaxLength = 32767
        Me.cboCC.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCC.Name = "cboCC"
        Me.cboCC.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCC.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCC.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCC.Size = New System.Drawing.Size(216, 24)
        Me.cboCC.TabIndex = 0
        Me.cboCC.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboDelivery
        '
        Me.cboDelivery.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboDelivery.AllowColMove = False
        Me.cboDelivery.AutoCompletion = True
        Me.cboDelivery.AutoDropDown = True
        Me.cboDelivery.Caption = ""
        Me.cboDelivery.CaptionHeight = 17
        Me.cboDelivery.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDelivery.ColumnCaptionHeight = 17
        Me.cboDelivery.ColumnFooterHeight = 17
        Me.cboDelivery.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboDelivery.ContentHeight = 18
        Me.cboDelivery.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboDelivery.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboDelivery.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDelivery.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDelivery.EditorHeight = 18
        Me.cboDelivery.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDelivery.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.cboDelivery.ItemHeight = 20
        Me.cboDelivery.Location = New System.Drawing.Point(104, 89)
        Me.cboDelivery.MatchEntryTimeout = CType(2000, Long)
        Me.cboDelivery.MaxDropDownItems = CType(20, Short)
        Me.cboDelivery.MaxLength = 32767
        Me.cboDelivery.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboDelivery.Name = "cboDelivery"
        Me.cboDelivery.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDelivery.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboDelivery.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDelivery.Size = New System.Drawing.Size(216, 24)
        Me.cboDelivery.TabIndex = 1
        Me.cboDelivery.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 206, 1</ClientRect><Height>1</Hei" & _
        "ght><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Height></H" & _
        "ScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowStyle parent=""Even" & _
        "Row"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent" & _
        "=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightR" & _
        "owStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactive"" me=" & _
        """Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle paren" & _
        "t=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Style5"" /" & _
        "><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits><Name" & _
        "dStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><St" & _
        "yle parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style" & _
        " parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style " & _
        "parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style" & _
        " parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><St" & _
        "yle parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzS" & _
        "plits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</DefaultRecS" & _
        "elWidth></Blob>"
        '
        'cboCarrier
        '
        Me.cboCarrier.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCarrier.AllowColMove = False
        Me.cboCarrier.AutoCompletion = True
        Me.cboCarrier.AutoDropDown = True
        Me.cboCarrier.Caption = ""
        Me.cboCarrier.CaptionHeight = 17
        Me.cboCarrier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCarrier.ColumnCaptionHeight = 17
        Me.cboCarrier.ColumnFooterHeight = 17
        Me.cboCarrier.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCarrier.ContentHeight = 18
        Me.cboCarrier.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCarrier.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCarrier.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarrier.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCarrier.EditorHeight = 18
        Me.cboCarrier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarrier.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.cboCarrier.ItemHeight = 20
        Me.cboCarrier.Location = New System.Drawing.Point(104, 120)
        Me.cboCarrier.MatchEntryTimeout = CType(2000, Long)
        Me.cboCarrier.MaxDropDownItems = CType(20, Short)
        Me.cboCarrier.MaxLength = 32767
        Me.cboCarrier.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCarrier.Name = "cboCarrier"
        Me.cboCarrier.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCarrier.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCarrier.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCarrier.Size = New System.Drawing.Size(312, 24)
        Me.cboCarrier.TabIndex = 2
        Me.cboCarrier.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtCarrierTrip
        '
        Me.txtCarrierTrip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarrierTrip.Location = New System.Drawing.Point(104, 153)
        Me.txtCarrierTrip.Name = "txtCarrierTrip"
        Me.txtCarrierTrip.Size = New System.Drawing.Size(120, 23)
        Me.txtCarrierTrip.TabIndex = 3
        Me.txtCarrierTrip.Text = ""
        '
        'txtCarrierHatch
        '
        Me.txtCarrierHatch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarrierHatch.Location = New System.Drawing.Point(104, 185)
        Me.txtCarrierHatch.Name = "txtCarrierHatch"
        Me.txtCarrierHatch.Size = New System.Drawing.Size(120, 23)
        Me.txtCarrierHatch.TabIndex = 4
        Me.txtCarrierHatch.Text = ""
        '
        'cboVessel
        '
        Me.cboVessel.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboVessel.AllowColMove = False
        Me.cboVessel.AutoCompletion = True
        Me.cboVessel.AutoDropDown = True
        Me.cboVessel.Caption = ""
        Me.cboVessel.CaptionHeight = 17
        Me.cboVessel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVessel.ColumnCaptionHeight = 17
        Me.cboVessel.ColumnFooterHeight = 17
        Me.cboVessel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboVessel.ContentHeight = 18
        Me.cboVessel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVessel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVessel.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVessel.EditorHeight = 18
        Me.cboVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(104, 216)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(20, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.Size = New System.Drawing.Size(312, 24)
        Me.cboVessel.TabIndex = 5
        Me.cboVessel.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtDateDepart
        '
        Me.txtDateDepart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateDepart.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateDepart.Location = New System.Drawing.Point(584, 57)
        Me.txtDateDepart.Name = "txtDateDepart"
        Me.txtDateDepart.Size = New System.Drawing.Size(136, 23)
        Me.txtDateDepart.TabIndex = 6
        Me.txtDateDepart.Tag = Nothing
        Me.txtDateDepart.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateArrive
        '
        Me.txtDateArrive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateArrive.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateArrive.Location = New System.Drawing.Point(584, 90)
        Me.txtDateArrive.Name = "txtDateArrive"
        Me.txtDateArrive.Size = New System.Drawing.Size(136, 23)
        Me.txtDateArrive.TabIndex = 7
        Me.txtDateArrive.Tag = Nothing
        Me.txtDateArrive.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateUnload
        '
        Me.txtDateUnload.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateUnload.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateUnload.Location = New System.Drawing.Point(584, 121)
        Me.txtDateUnload.Name = "txtDateUnload"
        Me.txtDateUnload.Size = New System.Drawing.Size(136, 23)
        Me.txtDateUnload.TabIndex = 8
        Me.txtDateUnload.Tag = Nothing
        Me.txtDateUnload.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboAreaCode
        '
        Me.cboAreaCode.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboAreaCode.AllowColMove = False
        Me.cboAreaCode.AutoCompletion = True
        Me.cboAreaCode.AutoDropDown = True
        Me.cboAreaCode.Caption = ""
        Me.cboAreaCode.CaptionHeight = 17
        Me.cboAreaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAreaCode.ColumnCaptionHeight = 17
        Me.cboAreaCode.ColumnFooterHeight = 17
        Me.cboAreaCode.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboAreaCode.ContentHeight = 18
        Me.cboAreaCode.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboAreaCode.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboAreaCode.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreaCode.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAreaCode.EditorHeight = 18
        Me.cboAreaCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreaCode.Images.Add(CType(resources.GetObject("resource.Images4"), System.Drawing.Bitmap))
        Me.cboAreaCode.ItemHeight = 20
        Me.cboAreaCode.Location = New System.Drawing.Point(584, 152)
        Me.cboAreaCode.MatchEntryTimeout = CType(2000, Long)
        Me.cboAreaCode.MaxDropDownItems = CType(20, Short)
        Me.cboAreaCode.MaxLength = 32767
        Me.cboAreaCode.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboAreaCode.Name = "cboAreaCode"
        Me.cboAreaCode.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboAreaCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboAreaCode.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboAreaCode.Size = New System.Drawing.Size(272, 24)
        Me.cboAreaCode.TabIndex = 9
        Me.cboAreaCode.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboRefNo
        '
        Me.cboRefNo.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboRefNo.AllowColMove = False
        Me.cboRefNo.AutoCompletion = True
        Me.cboRefNo.AutoDropDown = True
        Me.cboRefNo.Caption = ""
        Me.cboRefNo.CaptionHeight = 17
        Me.cboRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRefNo.ColumnCaptionHeight = 17
        Me.cboRefNo.ColumnFooterHeight = 17
        Me.cboRefNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.SimpleCombo
        Me.cboRefNo.ContentHeight = 18
        Me.cboRefNo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRefNo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRefNo.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRefNo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRefNo.EditorHeight = 18
        Me.cboRefNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRefNo.Images.Add(CType(resources.GetObject("resource.Images5"), System.Drawing.Bitmap))
        Me.cboRefNo.ItemHeight = 20
        Me.cboRefNo.Location = New System.Drawing.Point(584, 216)
        Me.cboRefNo.MatchEntryTimeout = CType(2000, Long)
        Me.cboRefNo.MaxDropDownItems = CType(20, Short)
        Me.cboRefNo.MaxLength = 32767
        Me.cboRefNo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRefNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRefNo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRefNo.Size = New System.Drawing.Size(272, 24)
        Me.cboRefNo.TabIndex = 10
        Me.cboRefNo.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        "1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 262, 2</ClientRect><Height>2</Hei" & _
        "ght><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Height></H" & _
        "ScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowStyle parent=""Even" & _
        "Row"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent" & _
        "=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightR" & _
        "owStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactive"" me=" & _
        """Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle paren" & _
        "t=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Style5"" /" & _
        "><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits><Name" & _
        "dStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><St" & _
        "yle parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style" & _
        " parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style " & _
        "parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style" & _
        " parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><St" & _
        "yle parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzS" & _
        "plits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</DefaultRecS" & _
        "elWidth></Blob>"
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource.Images6"), System.Drawing.Bitmap))
        Me.grid.Location = New System.Drawing.Point(104, 256)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(752, 232)
        Me.grid.TabIndex = 11
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
        "eight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWid" & _
        "th=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>228</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 748, 228</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>16</DefaultRecSelWidth><ClientArea>0, 0, 748, 228</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Bitmap)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(235, 496)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 12
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Bitmap)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(315, 496)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 13
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(395, 496)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 14
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(475, 496)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 15
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(555, 496)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 16
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Hatch No."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(472, 124)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 16)
        Me.Label27.TabIndex = 78
        Me.Label27.Text = "Unloading Date"
        '
        'lblOcean
        '
        Me.lblOcean.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOcean.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcean.Location = New System.Drawing.Point(584, 184)
        Me.lblOcean.Name = "lblOcean"
        Me.lblOcean.Size = New System.Drawing.Size(272, 24)
        Me.lblOcean.TabIndex = 77
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(472, 93)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 16)
        Me.Label23.TabIndex = 76
        Me.Label23.Text = "Arrival Date"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(472, 60)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 16)
        Me.Label25.TabIndex = 75
        Me.Label25.Text = "Departure Date"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 156)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 74
        Me.Label20.Text = "Carrier Trip No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Carrier Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Delivery Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Document No."
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(865, 40)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Catch Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Fishing Vessel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(472, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "RMO Reference #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Ocean"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(472, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Catch Area Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Fish Lot details"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMFV, Me.mnuMFAO})
        '
        'mnuMFV
        '
        Me.mnuMFV.Index = 0
        Me.mnuMFV.Text = "Fishing &Vessel"
        '
        'mnuMFAO
        '
        Me.mnuMFAO.Index = 1
        Me.mnuMFAO.Text = "&FAO Catch Area Code"
        '
        'cboPreservationMethod
        '
        Me.cboPreservationMethod.AllowColMove = True
        Me.cboPreservationMethod.AllowColSelect = True
        Me.cboPreservationMethod.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboPreservationMethod.AlternatingRows = False
        Me.cboPreservationMethod.ColumnCaptionHeight = 17
        Me.cboPreservationMethod.ColumnFooterHeight = 17
        Me.cboPreservationMethod.FetchRowStyles = False
        Me.cboPreservationMethod.Images.Add(CType(resources.GetObject("resource.Images7"), System.Drawing.Bitmap))
        Me.cboPreservationMethod.Location = New System.Drawing.Point(440, 256)
        Me.cboPreservationMethod.Name = "cboPreservationMethod"
        Me.cboPreservationMethod.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPreservationMethod.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboPreservationMethod.RowHeight = 20
        Me.cboPreservationMethod.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPreservationMethod.ScrollTips = False
        Me.cboPreservationMethod.Size = New System.Drawing.Size(216, 232)
        Me.cboPreservationMethod.TabIndex = 86
        Me.cboPreservationMethod.Text = "C1TrueDBDropdown1"
        Me.cboPreservationMethod.Visible = False
        Me.cboPreservationMethod.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.DropdownView Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" C" & _
        "olumnFooterHeight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" " & _
        "DefRecSelWidth=""16"" RecordSelectors=""False"" VerticalScrollGroup=""1"" HorizontalSc" & _
        "rollGroup=""1""><Height>228</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><" & _
        "EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Sty" & _
        "le8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Fo" & _
        "oter"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle pare" & _
        "nt=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" " & _
        "/><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me" & _
        "=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><Selecte" & _
        "dStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><Cli" & _
        "entRect>0, 0, 212, 228</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken" & _
        "</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView></Splits><NamedStyles><Style pa" & _
        "rent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Headi" & _
        "ng"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading""" & _
        " me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" m" & _
        "e=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" m" & _
        "e=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""R" & _
        "ecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption""" & _
        " me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits>" & _
        "<Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0" & _
        ", 212, 228</ClientArea></Blob>"
        '
        'frmSICC_DataEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(865, 551)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPreservationMethod, Me.Label8, Me.Label7, Me.Label3, Me.Label5, Me.Label1, Me.Label6, Me.Label27, Me.Label23, Me.Label25, Me.Label20, Me.Label12, Me.Label4, Me.Label2, Me.Label16, Me.lblOcean, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdEdit, Me.cmd, Me.grid, Me.cboRefNo, Me.cboAreaCode, Me.txtDateUnload, Me.txtDateArrive, Me.txtDateDepart, Me.cboVessel, Me.txtCarrierHatch, Me.txtCarrierTrip, Me.cboCarrier, Me.cboDelivery, Me.cboCC})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSICC_DataEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSICC_DataEntry"
        CType(Me.cboCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarrier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateDepart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateArrive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateUnload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAreaCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPreservationMethod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSICC_DataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        startup = 0
        'txtDateValid.Value = getServerDateTime()
        txtDateDepart.Value = getServerDateTime()
        txtDateArrive.Value = getServerDateTime()
        txtDateUnload.Value = getServerDateTime()
        dataEntry(1)

        displayCC()
        displayAllDelivery()
        displayFishingVessel()
        displayCatchAreas()
        displayCC_Reference()
        'displayFishingMethods()
        'displayListsofFishLot(txtDateDepart.Value)

        Me.displayListsofFishLot(txtDateArrive.Value)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllDelivery()
        With cboDelivery
            .DataSource = modModule.getAllDelivery().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 195

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayCC()
        With cboCC
            .DataSource = modModule.getCC().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 195

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishingVessel()
        With cboVessel
            .DataSource = modModule.getFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 290

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With

        With cboCarrier
            .DataSource = modModule.getFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 290

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayCatchAreas()
        With cboAreaCode
            .DataSource = modModule.getAllCatchAreas().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 50
            .Splits(0).DisplayColumns(1).Width = 200
        End With
    End Sub

    Public Sub displayCC_Reference()
        With cboRefNo
            .DataSource = modModule.getCC_Reference().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 225
        End With
    End Sub

    'Public Sub displayFishingMethods()
    '    With cboMethod
    '        .DataSource = modModule.getFishingMethod().Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 225
    '    End With
    'End Sub

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
        With Me
            Select Case s
                Case 0
                    .cboCC.ReadOnly = False
                    .cboDelivery.ReadOnly = False
                    .cboCarrier.ReadOnly = False
                    .txtCarrierTrip.ReadOnly = False
                    .txtCarrierHatch.ReadOnly = False
                    .cboVessel.ReadOnly = False
                    .txtDateDepart.ReadOnly = False
                    .txtDateArrive.ReadOnly = False
                    .txtDateUnload.ReadOnly = False
                    .cboAreaCode.ReadOnly = False
                    .cboRefNo.ReadOnly = False
                    grid.Enabled = True
                Case 1
                    .cboCC.ReadOnly = True
                    .cboDelivery.ReadOnly = True
                    .cboCarrier.ReadOnly = True
                    .txtCarrierTrip.ReadOnly = True
                    .txtCarrierHatch.ReadOnly = True
                    .cboVessel.ReadOnly = True
                    .txtDateDepart.ReadOnly = True
                    .txtDateArrive.ReadOnly = True
                    .txtDateUnload.ReadOnly = True
                    .cboAreaCode.ReadOnly = True
                    .cboRefNo.ReadOnly = True
                    grid.Enabled = False
            End Select
        End With
    End Sub

    Private Sub cboAreaCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreaCode.TextChanged
        If Not cboAreaCode.Text = "" Then
            lblOcean.Text = getFAOOCean(cboAreaCode.Text)
        Else
            lblOcean.Text = ""
        End If
    End Sub

    Public Sub addNewRecord()
        With Me
            .cboCC.ReadOnly = False
            displayCC()
            .cboCC.Text = ""
            .displayAllDelivery()
            .cboDelivery.Text = ""
            'txtDateValid.Value = getServerDateTime()
            'cboAuthority.Text = "Ministry Of Fisheries And Marine Resources"
            .displayFishingVessel()
            .cboCarrier.Text = ""
            .txtCarrierTrip.Text = ""
            .txtCarrierHatch.Text = ""
            .cboVessel.Text = ""
            .txtDateDepart.Value = getServerDateTime()
            .txtDateArrive.Value = getServerDateTime()
            .txtDateUnload.Value = getServerDateTime()
            'displayFishingMethods()
            'cboMethod.Text = ""
            .displayCatchAreas()
            .cboAreaCode.Text = ""
            'lblOcean.Text = ""
            'cboProduct.Text = "FROZEN TUNA"
            'cboProcessing.Text = "BRINE FREEZING"
            .displayCC_Reference()
            .cboRefNo.Text = "*"

            .displayListsofFishLot(txtDateArrive.Value)
            'displayAllCC()
        End With
    End Sub

    Public Sub displayFishingVesselDetails(ByVal vessel As String)
        'Try
        '    Dim c As New SqlClient.SqlConnection()
        '    c.ConnectionString = modModule.getConnectionString
        '    c.Open()

        '    Dim cmd As New SqlClient.SqlCommand()
        '    cmd.CommandText = "proc_display_FishingVesselDetails"
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Connection = c

        '    Dim p1 As New SqlClient.SqlParameter()
        '    p1.ParameterName = "@vessel"
        '    p1.SqlDbType = SqlDbType.VarChar
        '    p1.Direction = ParameterDirection.Input
        '    p1.Value = vessel

        '    cmd.Parameters.Add(p1)

        '    Dim dr As SqlClient.SqlDataReader
        '    dr = cmd.ExecuteReader

        '    If dr.Read Then
        '        If Not dr(0) Is DBNull.Value Then
        '            'lblCode.Text = dr.GetString(0)
        '            'txtFlag.Text = dr.GetString(2)
        '            'txtPort.Text = dr.GetString(3)
        '            lblRegNo.Text = dr.GetString(4)
        '            lblCallSign.Text = dr.GetString(5)
        '            'txtImo.Text = dr.GetString(6)
        '            lblLicNo.Text = dr.GetString(7)
        '            'txtImmarsat.Text = dr.GetString(8)
        '            'txtTelefax.Text = dr.GetString(9)
        '            lblExpiration.Text = dr.GetDateTime(10)
        '            lblTelNo.Text = dr.GetString(11)
        '            lblEmail.Text = dr.GetString(12)
        '        Else
        '            'lblCode.Text = dr.GetString(0)
        '            'txtFlag.Text = dr.GetString(2)
        '            'txtPort.Text = dr.GetString(3)
        '            lblRegNo.Text = ""
        '            lblCallSign.Text = ""
        '            'txtImo.Text = dr.GetString(6)
        '            lblLicNo.Text = ""
        '            'txtImmarsat.Text = dr.GetString(8)
        '            'txtTelefax.Text = dr.GetString(9)
        '            lblExpiration.Text = ""
        '            lblTelNo.Text = ""
        '            lblEmail.Text = ""
        '        End If
        '    Else
        '        'lblCode.Text = dr.GetString(0)
        '        'txtFlag.Text = dr.GetString(2)
        '        'txtPort.Text = dr.GetString(3)
        '        lblRegNo.Text = ""
        '        lblCallSign.Text = ""
        '        'txtImo.Text = dr.GetString(6)
        '        lblLicNo.Text = ""
        '        'txtImmarsat.Text = dr.GetString(8)
        '        'txtTelefax.Text = dr.GetString(9)
        '        lblExpiration.Text = ""
        '        lblTelNo.Text = ""
        '        lblEmail.Text = ""
        '    End If

        '    dr.Close()
        '    c.Close()
        'Catch e As Exception
        '    'MsgBox(e.Message)
        '    MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        'Finally
        'End Try
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        setFishTrip()
        setFishLot()
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
                'Me.TabControl1.SelectedIndex = 0
                editMode = False
                cboCC.SelectAll()
                cboCC.Focus()
            Case "&Save"
                setFishYear()
                setFishTrip()
                setFishLot()

                If Not cboCC.Text.Trim = "" And Not cboVessel.Text.Trim = "" And _
                Not cboAreaCode.Text.Trim = "" And Not lblOcean.Text.Trim = "" And _
                Not cboRefNo.Text.Trim = "" And grid.RowCount > 0 And _
                Not isFishLotEntriesEmpty() Then
                    If Not validateCC(cboCC.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            'saveNewSICC(cboCC.Text, CDate(getServerDateTime()), "Ministry Of Fisheries And Marine Resources", cboVessel.Text, _
                            '    txtDateDepart.Text, txtDateArrive.Text, "*", cboAreaCode.Text, _
                            '    "FROZEN TUNA", "BRINE FREEZING", cboRefNo.Text, txtDateUnload.Text)
                            saveNewSICC_Details(cboCC.Text, "", "", cboAreaCode.Text, "1/1/1901", "1/1/1901", "0", "0")

                            'SAVE BATCHLOT
                            Dim ctr As Integer
                            While ctr < grid.RowCount
                                If Not validateFishLot(grid.Item(ctr, 0)) Then
                                    saveNewFishLot(grid.Item(ctr, 0), "National%", "Normal Quality", cboCC.Text, grid.Item(ctr, 5), txtDateUnload.Text, CInt(grid.Item(ctr, 1)), CInt(grid.Item(ctr, 2)))
                                    'Else
                                    'MsgBox("Fish lot number " & grid.Item(ctr, 0) & " already stored in the database" & Chr(13) & _
                                    '"To update, please proceed to Transaction menu and select Update Fish Lot Information.", MsgBoxStyle.Exclamation, "Warning!")
                                End If

                                ctr += 1
                            End While

                            'SAVE BATCHLOT DETAILS SUCH AS SUBLOT
                            ctr = 0
                            deleteBatchLotDetails(grid.Item(0, 0))

                            While ctr < grid.RowCount
                                If Not validateFishLotDetails(grid.Item(ctr, 0), grid.Item(ctr, 4), grid.Item(ctr, 3)) Then
                                    'saveNewFishLotDetails(grid.Item(ctr, 0), grid.Item(ctr, 3), grid.Item(ctr, 4))
                                Else
                                    MsgBox("Fish sub-lot number " & grid.Item(ctr, 3) & " with preservation method of " & grid.Item(ctr, 4) & " already stored in the database", MsgBoxStyle.Exclamation, "Warning!")
                                End If

                                ctr += 1
                            End While


                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            'displayAllCC()
                            editMode = False
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Catch Certificate already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCC.SelectAll()
                        cboCC.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCC.SelectAll()
                    cboCC.Focus()
                End If
            Case "&Save "
                If Not isFishLotEntriesEmpty() Then
                    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        'updateSICC(cboCC.Text, CStr(getServerDateTime()), "Ministry Of Fisheries And Marine Resources", cboVessel.Text, _
                        '    txtDateDepart.Text, txtDateArrive.Text, "*", cboAreaCode.Text, _
                        '    "FROZEN TUNA", "BRINE FREEZING", cboRefNo.Text, txtDateUnload.Text)
                        updateSICCDetails(cboCC.Text, "", "", cboAreaCode.Text, "1/1/1901", "1/1/1901", "0", "0")

                        'SAVE BATCHLOT
                        Dim ctr As Integer
                        While ctr < grid.RowCount
                            If Not validateFishLot(grid.Item(ctr, 0)) Then
                                saveNewFishLot(grid.Item(ctr, 0), "National%", "Normal Quality", cboCC.Text, grid.Item(ctr, 5), txtDateUnload.Text, CInt(grid.Item(ctr, 1)), CInt(grid.Item(ctr, 2)))
                                'Else
                                '    MsgBox("Fish lot number " & grid.Item(ctr, 0) & " already stored in the database" & Chr(13) & _
                                '        "To update, please proceed to Transaction menu and select Update Fish Lot Information.", MsgBoxStyle.Exclamation, "Warning!")
                            End If

                            ctr += 1
                        End While

                        'SAVE BATCHLOT DETAILS SUCH AS SUBLOT
                        ctr = 0
                        deleteBatchLotDetails(grid.Item(0, 0))

                        While ctr < grid.RowCount
                            If Not validateFishLotDetails(grid.Item(ctr, 0), grid.Item(ctr, 4), grid.Item(ctr, 3)) Then
                                'saveNewFishLotDetails(grid.Item(ctr, 0), grid.Item(ctr, 3), grid.Item(ctr, 4))
                            Else
                                MsgBox("Fish sub-lot number " & grid.Item(ctr, 3) & " with preservation method of " & grid.Item(ctr, 4) & " already stored in the database", MsgBoxStyle.Exclamation, "Warning!")
                            End If

                            ctr += 1
                        End While
                        'MsgBox("Fish lot is not allowed to update from this module," & _
                        '    "Please use the Fish Lot interface to update but with proper authorization", MsgBoxStyle.Exclamation, "Warning")

                        cmd.Text = "&Add"
                        cmdEdit.Text = "&Edit"
                        buttons(1)
                        dataEntry(1)

                        'displayAllCC()
                        editMode = False
                        MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                        cmd.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboVessel.SelectAll()
                    cboVessel.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboCC.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboCC.ReadOnly = True
                    editMode = True
                    cboDelivery.SelectAll()
                    cboDelivery.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboDelivery.SelectAll()
                    cboDelivery.Focus()
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                dataEntry(1)
                editMode = False
                cmdEdit.Focus()
        End Select
    End Sub

    Public Sub displayRecord(ByVal cc As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_search_CC"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@cc"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = cc

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    ''txtDateValid.Value = dr.GetDateTime(1)
                    ''cboAuthority.Text = dr.GetString(2)
                    'cboVessel.Text = dr.GetString(2)
                    'txtDateDepart.Value = dr.GetDateTime(3)
                    'txtDateArrive.Value = dr.GetDateTime(4)
                    'txtDateUnload.Value = dr.GetDateTime(5)
                    ''cboMethod.Text = dr.GetString(6)
                    'cboAreaCode.Text = dr.GetString(7)
                    ''lblOcean.Text = ""
                    ''cboProduct.Text = dr.GetString(15)
                    ''cboProcessing.Text = dr.GetString(16)
                    'cboRefNo.Text = dr.GetString(9)

                    cboDelivery.Text = dr.GetString(1)
                    cboCarrier.Text = dr.GetString(2)
                    txtCarrierTrip.Text = dr.GetString(3)
                    txtCarrierHatch.Text = dr.GetString(4)
                    cboVessel.Text = dr.GetString(5)
                    txtDateDepart.Value = dr.GetDateTime(6)
                    txtDateArrive.Value = dr.GetDateTime(7)
                    txtDateUnload.Value = dr.GetDateTime(8)
                    cboAreaCode.Text = dr.GetString(9)
                    cboRefNo.Text = dr.GetString(11)
                Else
                    'txtDateValid.Value = Format(getServerDateTime(), getTimeFormat())
                    'cboAuthority.Text = "Ministry Of Fisheries And Marine Resources"
                    'txtDateDepart.Value = Format(getServerDateTime(), getTimeFormat())
                    'txtDateArrive.Value = Format(getServerDateTime(), getTimeFormat())
                    'txtDateUnload.Value = Format(getServerDateTime(), getTimeFormat())

                    cboDelivery.Text = ""
                    cboCarrier.Text = ""
                    txtCarrierTrip.Text = ""
                    txtCarrierHatch.Text = ""
                    cboVessel.Text = ""
                    txtDateDepart.Value = Format(getServerDateTime(), getTimeFormat())
                    txtDateArrive.Value = Format(getServerDateTime(), getTimeFormat())
                    txtDateUnload.Value = Format(getServerDateTime(), getTimeFormat())
                    cboAreaCode.Text = ""
                    cboRefNo.Text = ""
                End If
            Else
                cboDelivery.Text = ""
                cboCarrier.Text = ""
                txtCarrierTrip.Text = ""
                txtCarrierHatch.Text = ""
                cboVessel.Text = ""
                txtDateDepart.Value = Format(getServerDateTime(), getTimeFormat())
                txtDateArrive.Value = Format(getServerDateTime(), getTimeFormat())
                txtDateUnload.Value = Format(getServerDateTime(), getTimeFormat())
                cboAreaCode.Text = ""
                cboRefNo.Text = ""
            End If

            dr.Close()
            c.Close()

            displayFishLotBySICC(cboCC.Text)
        Catch e As Exception
            MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Private Sub cboCC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCC.TextChanged
        displayRecord(cboCC.Text)
    End Sub

    Private Sub mnuMFV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFV.Click
        Dim f As New frmFishingVessel()
        f.ShowDialog(Me)

        displayFishingVessel()
        cboVessel.SelectAll()
        cboVessel.Focus()
    End Sub

    Private Sub mnuMFAO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFAO.Click
        Dim f As New frmFAO()
        f.ShowDialog(Me)

        displayCatchAreas()
        cboAreaCode.SelectAll()
        cboAreaCode.Focus()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Solomon Catch Certificate"
        f.searchType = 2
        f.displayAllCC()
        f.ShowDialog(Me)

        If Not f.cancel Then cboCC.Text = f.searchItem
        'displayRecord(f.searchItem)
    End Sub

    Public Sub displayListsofFishLot(ByVal year As String)
        With grid
            .DataSource = modModule.getListsOfFishLot(year).Tables(0)
            .Columns(4).DropDown = cboPreservationMethod
            .Splits(0).DisplayColumns(4).DropDownList = True

            displayPreservationMethod()

            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 50
            .Columns(1).NumberFormat = "##"
            .Splits(0).DisplayColumns(2).Width = 50
            .Columns(2).NumberFormat = "##"
            .Splits(0).DisplayColumns(3).Width = 70
            '.Columns(3).NumberFormat = "##"
            .Splits(0).DisplayColumns(4).Width = 210
            .Splits(0).DisplayColumns(5).Width = 250

            .Splits(0).DisplayColumns(0).Locked = True
            .Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(1).Locked = True
            .Splits(0).DisplayColumns(1).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(3).Locked = True
            .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(3).Locked = True
            .Splits(0).DisplayColumns(5).Locked = True
            .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(5).Locked = True
        End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        If startup > 0 Then ' And Not grid.Item(0, 1) Is DBNull.Value Then
            'grid.Columns(2).Value = Format(CDate(Me.txtDateArrive.Value), "yy")
            countSublot()

            setFishYear()
            setFishTrip()
            setFishLot()
        End If

        startup += 1
    End Sub

    Public Sub countSublot()
        Dim ctr As Integer = 0
        While ctr < grid.RowCount
            grid.Item(ctr, 1) = grid.Item(0, 1)
            grid.Item(ctr, 3) = ctr + 1
            ctr += 1
        End While
    End Sub

    Public Sub displayPreservationMethod()
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_displayAll_PreservationMethod"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim da As New SqlClient.SqlDataAdapter()
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            With cboPreservationMethod
                .DataSource = ds.Tables(0)

                .DisplayColumns(0).Width = 110
                .DisplayColumns(1).Width = 80
            End With


            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub


    Private Sub cboPreservationMethod_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPreservationMethod.RowChange
        grid.Item(grid.Row, 4) = cboPreservationMethod.Columns(0).Value
        grid.Item(grid.Row, 5) = cboPreservationMethod.Columns(1).Value
    End Sub

    Public Sub setFishLot() '(ByVal trip As Integer, ByVal yr As Integer)
        Dim ctr As Integer
        While ctr < grid.RowCount
            If Not grid.Item(ctr, 1) Is DBNull.Value And Not grid.Item(ctr, 2) Is DBNull.Value Then
                If Not cboVessel.Text = "" Then
                    grid.Item(ctr, 0) = getVesselCode(cboVessel.Text) & _
                        Format(CInt(grid.Item(ctr, 1)), "0#") & _
                        Format(CInt(grid.Item(ctr, 2)), "0#")
                Else
                    grid.Item(ctr, 0) = ""
                End If
            End If

            ctr += 1
        End While
    End Sub

    Public Sub displayFishLotBySICC(ByVal certificate As String)
        With grid
            .DataSource = modModule.getFishlotBySICC(certificate).Tables(0)

            If grid.RowCount > 0 Then
                .Columns(4).DropDown = cboPreservationMethod
                .Splits(0).DisplayColumns(4).DropDownList = True

                displayPreservationMethod()

                .Splits(0).DisplayColumns(0).Width = 80
                .Splits(0).DisplayColumns(1).Width = 50
                .Columns(1).NumberFormat = "##"
                .Splits(0).DisplayColumns(2).Width = 50
                .Columns(2).NumberFormat = "##"
                .Splits(0).DisplayColumns(3).Width = 70
                '.Columns(3).NumberFormat = "##"
                .Splits(0).DisplayColumns(4).Width = 210
                .Splits(0).DisplayColumns(5).Width = 250

                .Splits(0).DisplayColumns(0).Locked = True
                .Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray
                .Splits(0).DisplayColumns(1).Locked = True
                .Splits(0).DisplayColumns(1).Style.BackColor = Color.Gray
                .Splits(0).DisplayColumns(3).Locked = True
                .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
                '.Splits(0).DisplayColumns(3).Locked = True
                .Splits(0).DisplayColumns(5).Locked = True
                .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
                '.Splits(0).DisplayColumns(5).Locked = True
            Else
                displayListsofFishLot(txtDateArrive.Value)
            End If
        End With
    End Sub

    Public Function isFishLotEntriesEmpty() As Boolean
        Dim ctr As Integer
        While ctr < grid.RowCount
            If Not grid.Item(ctr, 1) Is DBNull.Value And Not grid.Item(ctr, 2) Is DBNull.Value And _
                Not grid.Item(ctr, 4) Is DBNull.Value And Not grid.Item(ctr, 5) Is DBNull.Value Then
                Return False
            End If
            ctr += 1
        End While

        Return True
    End Function

    Private Sub txtDateArrive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateArrive.TextChanged
        setFishYear()
    End Sub

    Public Sub setFishTrip()
        Dim ctr As Integer
        If Not editMode Then
            While ctr < grid.RowCount
                grid.Item(ctr, 1) = getFishingVesselTrip(cboVessel.Text)
                ctr += 1
            End While
        End If
    End Sub

    Public Sub setFishYear()
        Dim ctr As Integer
        'If Not editMode Then
        If grid.RowCount > 0 Then
            While ctr < grid.RowCount
                If Not txtDateArrive.Value Is DBNull.Value Then
                    grid.Item(ctr, 2) = Format(CDate(Me.txtDateArrive.Value), "yy")
                Else
                    grid.Item(ctr, 2) = Format(Now, "yy")
                End If

                ctr += 1
            End While
        End If
        'End If
        setFishTrip()
        setFishLot()
    End Sub

    Private Sub txtDateArrive_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateArrive.Leave
        setFishYear()
    End Sub

    Private Sub cboDelivery_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDelivery.TextChanged
        If cboDelivery.Text.StartsWith("Direct") Then
            cboVessel.ReadOnly = True
        Else
            cboVessel.ReadOnly = False
        End If

        cboCarrier_TextChanged(sender, New EventArgs())
    End Sub

    Private Sub cboCarrier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCarrier.TextChanged
        If cboDelivery.Text.StartsWith("Direct") Then
            cboVessel.Text = cboCarrier.Text
        Else
            cboVessel.Text = ""
        End If

        cboVessel_TextChanged(sender, New EventArgs())
    End Sub
End Class
