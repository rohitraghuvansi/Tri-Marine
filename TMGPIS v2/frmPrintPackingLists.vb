Public Class frmPrintPackingLists
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
    Friend WithEvents txtDeptDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents cboVesselNo As C1.Win.C1List.C1Combo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents lblSeal As System.Windows.Forms.Label
    Friend WithEvents lblContainer As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboBOL As C1.Win.C1List.C1Combo
    Friend WithEvents cmdPrintLR As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintPackingLists))
        Me.txtDeptDate = New C1.Win.C1Input.C1DateEdit
        Me.cboVessel = New C1.Win.C1List.C1Combo
        Me.cboVesselNo = New C1.Win.C1List.C1Combo
        Me.lblSeal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblContainer = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboBOL = New C1.Win.C1List.C1Combo
        Me.cmdPrintLR = New System.Windows.Forms.Button
        CType(Me.txtDeptDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVesselNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBOL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDeptDate
        '
        Me.txtDeptDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeptDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDeptDate.Location = New System.Drawing.Point(120, 119)
        Me.txtDeptDate.Name = "txtDeptDate"
        Me.txtDeptDate.Size = New System.Drawing.Size(229, 23)
        Me.txtDeptDate.TabIndex = 0
        Me.txtDeptDate.Tag = Nothing
        Me.txtDeptDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboVessel.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(120, 151)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(10, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.Size = New System.Drawing.Size(229, 24)
        Me.cboVessel.TabIndex = 1
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
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Default" & _
        "RecSelWidth></Blob>"
        '
        'cboVesselNo
        '
        Me.cboVesselNo.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboVesselNo.AllowColMove = False
        Me.cboVesselNo.AutoCompletion = True
        Me.cboVesselNo.AutoDropDown = True
        Me.cboVesselNo.Caption = ""
        Me.cboVesselNo.CaptionHeight = 17
        Me.cboVesselNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVesselNo.ColumnCaptionHeight = 17
        Me.cboVesselNo.ColumnFooterHeight = 17
        Me.cboVesselNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboVesselNo.ContentHeight = 18
        Me.cboVesselNo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVesselNo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVesselNo.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVesselNo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVesselNo.EditorHeight = 18
        Me.cboVesselNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVesselNo.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboVesselNo.ItemHeight = 20
        Me.cboVesselNo.Location = New System.Drawing.Point(120, 184)
        Me.cboVesselNo.MatchEntryTimeout = CType(2000, Long)
        Me.cboVesselNo.MaxDropDownItems = CType(10, Short)
        Me.cboVesselNo.MaxLength = 32767
        Me.cboVesselNo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVesselNo.Name = "cboVesselNo"
        Me.cboVesselNo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVesselNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVesselNo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVesselNo.Size = New System.Drawing.Size(229, 24)
        Me.cboVesselNo.TabIndex = 2
        Me.cboVesselNo.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'lblSeal
        '
        Me.lblSeal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeal.Location = New System.Drawing.Point(120, 86)
        Me.lblSeal.Name = "lblSeal"
        Me.lblSeal.Size = New System.Drawing.Size(229, 24)
        Me.lblSeal.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Seal No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Departure Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 19)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Vessel Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Vessel No."
        '
        'lblContainer
        '
        Me.lblContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblContainer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainer.Location = New System.Drawing.Point(120, 53)
        Me.lblContainer.Name = "lblContainer"
        Me.lblContainer.Size = New System.Drawing.Size(229, 24)
        Me.lblContainer.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(442, 40)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Print Packing Lists"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Container No."
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(356, 256)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(12, 256)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(168, 48)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.TabStop = False
        Me.cmdPrint.Text = "&Print Packing Lists"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Bill of Lading"
        '
        'cboBOL
        '
        Me.cboBOL.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboBOL.AllowColMove = False
        Me.cboBOL.AutoCompletion = True
        Me.cboBOL.AutoDropDown = True
        Me.cboBOL.Caption = ""
        Me.cboBOL.CaptionHeight = 17
        Me.cboBOL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBOL.ColumnCaptionHeight = 17
        Me.cboBOL.ColumnFooterHeight = 17
        Me.cboBOL.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboBOL.ContentHeight = 18
        Me.cboBOL.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBOL.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBOL.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBOL.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBOL.EditorHeight = 18
        Me.cboBOL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBOL.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboBOL.ItemHeight = 20
        Me.cboBOL.Location = New System.Drawing.Point(120, 216)
        Me.cboBOL.MatchEntryTimeout = CType(2000, Long)
        Me.cboBOL.MaxDropDownItems = CType(10, Short)
        Me.cboBOL.MaxLength = 32767
        Me.cboBOL.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBOL.Name = "cboBOL"
        Me.cboBOL.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBOL.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBOL.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBOL.Size = New System.Drawing.Size(229, 24)
        Me.cboBOL.TabIndex = 3
        Me.cboBOL.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cmdPrintLR
        '
        Me.cmdPrintLR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintLR.Image = CType(resources.GetObject("cmdPrintLR.Image"), System.Drawing.Image)
        Me.cmdPrintLR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrintLR.Location = New System.Drawing.Point(184, 256)
        Me.cmdPrintLR.Name = "cmdPrintLR"
        Me.cmdPrintLR.Size = New System.Drawing.Size(168, 48)
        Me.cmdPrintLR.TabIndex = 4
        Me.cmdPrintLR.Text = "&Print Loading Report"
        Me.cmdPrintLR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmPrintPackingLists
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdPrintLR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboBOL)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblContainer)
        Me.Controls.Add(Me.lblSeal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboVesselNo)
        Me.Controls.Add(Me.cboVessel)
        Me.Controls.Add(Me.txtDeptDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrintPackingLists"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrintPackingLists"
        CType(Me.txtDeptDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVesselNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBOL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintPackingLists_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDeptDate.Value = getServerDateTime()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txtDeptDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeptDate.ValueChanged
        'displayVessel(txtDeptDate.Text)
        cboVessel.Text = ""
        cboVessel.DefColWidth = 205
        cboVessel.DataSource = getShipmentDetails_Vessel(txtDeptDate.Text, "1").Tables(0)
        If cboVessel.ListCount > 0 Then cboVessel.SelectedIndex = 0
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        'displayVessel(txtDeptDate.Text, cboVessel.Text)
        cboVesselNo.Text = ""
        cboVesselNo.DefColWidth = 205
        cboVesselNo.DataSource = getShipmentDetails_Vessel(txtDeptDate.Text, "2", cboVessel.Text).Tables(0)
        If cboVesselNo.ListCount > 0 Then cboVesselNo.SelectedIndex = 0
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'If getFGContainer_Specie(lblContainer.Text, lblSeal.Text).StartsWith("Alb") Then
        '    Dim f As New frmPrintPackingLists_Report
        '    f.displayReport_AL(Format(CDate(txtDeptDate.Text), "ddMMyy-") & cboBOL.Text, lblContainer.Text, lblSeal.Text)
        '    f.ShowDialog(Me)
        'Else
            Dim f As New frmPrintPackingLists_Report
            f.displayPackingLists(Format(CDate(txtDeptDate.Text), "ddMMyy-") & cboBOL.Text, lblContainer.Text, lblSeal.Text)
            f.ShowDialog(Me)
        'End If
    End Sub

    Private Sub cboVesselNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVesselNo.TextChanged
        cboBOL.Text = ""
        cboBOL.DefColWidth = 205
        cboBOL.DataSource = getShipmentDetails_Vessel(txtDeptDate.Text, "3", cboVessel.Text).Tables(0)
        If cboBOL.ListCount > 0 Then cboBOL.SelectedIndex = 0
    End Sub

    Private Sub cmdPrintLR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintLR.Click
        'If getFGContainer_Specie(lblContainer.Text, lblSeal.Text).StartsWith("Alb") Then
        'Dim f As New frmPrintPackingLists_Report
        'f.displayReport_AL(Format(CDate(txtDeptDate.Text), "ddMMyy-") & cboBOL.Text, lblContainer.Text, lblSeal.Text)
        'f.ShowDialog(Me)
        'Else
        Dim f As New frmPrintPackingLists_Report
        f.Label1.Text = Label4.Text
        f.displayLoadingReport(Format(CDate(txtDeptDate.Text), "ddMMyy-") & cboBOL.Text, lblContainer.Text, lblSeal.Text)
        f.ShowDialog(Me)
        'End If
    End Sub
End Class
