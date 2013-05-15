Public Class frmUpdateFishBin_Deposit
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents chkHold As System.Windows.Forms.CheckBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblLot As System.Windows.Forms.Label
    Friend WithEvents lblMethod As System.Windows.Forms.Label
    Friend WithEvents lblSublot As System.Windows.Forms.Label
    Friend WithEvents lblCS As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblGW As System.Windows.Forms.Label
    Friend WithEvents lblNW As System.Windows.Forms.Label
    Friend WithEvents lblTW As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblSpecie As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblPosition As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUpdateFishBin_Deposit))
        Me.cboBin = New C1.Win.C1List.C1Combo
        Me.chkHold = New System.Windows.Forms.CheckBox
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblLot = New System.Windows.Forms.Label
        Me.lblMethod = New System.Windows.Forms.Label
        Me.lblSublot = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblCS = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblGW = New System.Windows.Forms.Label
        Me.lblNW = New System.Windows.Forms.Label
        Me.lblTW = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblSize = New System.Windows.Forms.Label
        Me.lblSpecie = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblHeight = New System.Windows.Forms.TextBox
        Me.lblPosition = New System.Windows.Forms.TextBox
        Me.lblLocation = New System.Windows.Forms.TextBox
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboBin
        '
        Me.cboBin.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboBin.AllowColMove = False
        Me.cboBin.Caption = ""
        Me.cboBin.CaptionHeight = 17
        Me.cboBin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBin.ColumnCaptionHeight = 17
        Me.cboBin.ColumnFooterHeight = 17
        Me.cboBin.ContentHeight = 18
        Me.cboBin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBin.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBin.EditorHeight = 18
        Me.cboBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(144, 52)
        Me.cboBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboBin.MaxDropDownItems = CType(20, Short)
        Me.cboBin.MaxLength = 32767
        Me.cboBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBin.Name = "cboBin"
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.Size = New System.Drawing.Size(120, 24)
        Me.cboBin.TabIndex = 0
        Me.cboBin.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'chkHold
        '
        Me.chkHold.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHold.Location = New System.Drawing.Point(496, 52)
        Me.chkHold.Name = "chkHold"
        Me.chkHold.Size = New System.Drawing.Size(24, 24)
        Me.chkHold.TabIndex = 4
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(496, 88)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(192, 23)
        Me.txtRemarks.TabIndex = 5
        Me.txtRemarks.Text = "*"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(236, 328)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClear.Location = New System.Drawing.Point(316, 328)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 48)
        Me.cmdClear.TabIndex = 7
        Me.cmdClear.Text = "C&lear"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(396, 328)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 19)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Fish Lot No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Fish Bin#"
        '
        'lblLot
        '
        Me.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.Location = New System.Drawing.Point(144, 88)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(192, 24)
        Me.lblLot.TabIndex = 87
        Me.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMethod
        '
        Me.lblMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMethod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethod.Location = New System.Drawing.Point(144, 156)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(192, 24)
        Me.lblMethod.TabIndex = 85
        '
        'lblSublot
        '
        Me.lblSublot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSublot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSublot.Location = New System.Drawing.Point(144, 124)
        Me.lblSublot.Name = "lblSublot"
        Me.lblSublot.Size = New System.Drawing.Size(192, 24)
        Me.lblSublot.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 19)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Preservation Method"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Sub-lot"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Cold Storage"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(706, 40)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Update Fish Bin Details"
        '
        'lblCS
        '
        Me.lblCS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCS.Location = New System.Drawing.Point(144, 192)
        Me.lblCS.Name = "lblCS"
        Me.lblCS.Size = New System.Drawing.Size(192, 24)
        Me.lblCS.TabIndex = 96
        Me.lblCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(408, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 19)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Remarks"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(408, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 19)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Hold"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(408, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Net Weight"
        '
        'lblGW
        '
        Me.lblGW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGW.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGW.Location = New System.Drawing.Point(496, 191)
        Me.lblGW.Name = "lblGW"
        Me.lblGW.Size = New System.Drawing.Size(192, 36)
        Me.lblGW.TabIndex = 108
        Me.lblGW.Text = "0.00"
        Me.lblGW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNW
        '
        Me.lblNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNW.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNW.Location = New System.Drawing.Point(496, 276)
        Me.lblNW.Name = "lblNW"
        Me.lblNW.Size = New System.Drawing.Size(192, 36)
        Me.lblNW.TabIndex = 107
        Me.lblNW.Text = "0.00"
        Me.lblNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTW
        '
        Me.lblTW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTW.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTW.Location = New System.Drawing.Point(496, 233)
        Me.lblTW.Name = "lblTW"
        Me.lblTW.Size = New System.Drawing.Size(192, 36)
        Me.lblTW.TabIndex = 106
        Me.lblTW.Text = "0.00"
        Me.lblTW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(408, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 19)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Tare Weight"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(408, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 19)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Gross Weight"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(408, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 19)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Fish Size"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(408, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 19)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Fish Specie"
        '
        'lblSize
        '
        Me.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(496, 156)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(192, 24)
        Me.lblSize.TabIndex = 101
        '
        'lblSpecie
        '
        Me.lblSpecie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecie.Location = New System.Drawing.Point(496, 124)
        Me.lblSpecie.Name = "lblSpecie"
        Me.lblSpecie.Size = New System.Drawing.Size(192, 24)
        Me.lblSpecie.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Height"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 19)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Row"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 226)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 19)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "Block"
        '
        'lblHeight
        '
        Me.lblHeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(144, 288)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(192, 23)
        Me.lblHeight.TabIndex = 3
        Me.lblHeight.Text = ""
        '
        'lblPosition
        '
        Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(144, 256)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(192, 23)
        Me.lblPosition.TabIndex = 2
        Me.lblPosition.Text = ""
        '
        'lblLocation
        '
        Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(144, 224)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(192, 23)
        Me.lblLocation.TabIndex = 1
        Me.lblLocation.Text = ""
        '
        'frmUpdateFishBin_Deposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(706, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblGW)
        Me.Controls.Add(Me.lblNW)
        Me.Controls.Add(Me.lblTW)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblSpecie)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblCS)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLot)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.lblSublot)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.chkHold)
        Me.Controls.Add(Me.cboBin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUpdateFishBin_Deposit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdateFishBin_Deposit"
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmUpdateFishBin_Deposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        displayFishBinDeposited()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayFishBinDeposited()
        With cboBin
            .DefColWidth = 98
            .DataSource = modModule.getFishBins_Deposited().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 99
        End With
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        displayBinDetails(cboBin.Text)
    End Sub

    Public Sub displayBinDetails(ByVal bin As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_display_FishBins_DepositedDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@bin"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = bin

            cmd.Parameters.Add(p1)

            Dim drCode As SqlClient.SqlDataReader
            drCode = cmd.ExecuteReader

            If drCode.Read Then
                lblLot.Text = drCode.GetString(0)
                lblSublot.Text = drCode.GetString(1)
                lblMethod.Text = drCode.GetString(2)
                lblCS.Text = drCode.GetString(3)
                lblLocation.Text = drCode.GetString(4)
                lblPosition.Text = drCode.GetString(5)
                lblHeight.Text = drCode.GetString(13)
                If drCode.GetInt32(6) = 1 Then
                    chkHold.Checked = True
                Else
                    chkHold.Checked = False
                End If

                txtRemarks.Text = drCode.GetString(7)
                lblSpecie.Text = drCode.GetString(8)
                lblSize.Text = drCode.GetString(9)
                lblGW.Text = Format(drCode.GetDouble(10), "###,##0.#0")
                lblTW.Text = Format(drCode.GetDouble(11), "###,##0.#0")
                lblNW.Text = Format(drCode.GetDouble(12), "###,##0.#0")

            Else
                lblLot.Text = ""
                lblSublot.Text = ""
                lblMethod.Text = ""
                lblCS.Text = ""
                lblLocation.Text = ""
                lblPosition.Text = ""
                lblHeight.Text = ""
                chkHold.Checked = False

                txtRemarks.Text = ""
                lblSpecie.Text = ""
                lblSize.Text = ""
                lblGW.Text = "0.00"
                lblTW.Text = "0.00"
                lblNW.Text = "0.00"
            End If

            drCode.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        cboBin.Text = ""
        lblLot.Text = ""
        lblSublot.Text = ""
        lblMethod.Text = ""
        lblCS.Text = ""
        lblLocation.Text = ""
        lblPosition.Text = ""
        lblHeight.Text = ""
        chkHold.Checked = False

        txtRemarks.Text = ""
        cboBin.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Not cboBin.Text.Trim = "" Then
            Dim reply As String
            reply = MsgBox("Are you sure you want to update the existing fish bin?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then
                If chkHold.Checked = True Then
                    updateBinStatus(cboBin.Text, 1, txtRemarks.Text, lblLocation.Text, lblPosition.Text, lblHeight.Text)
                Else
                    updateBinStatus(cboBin.Text, 0, txtRemarks.Text, lblLocation.Text, lblPosition.Text, lblHeight.Text)
                End If

                MsgBox("You have sucessfully update the Fish Bin Number " & cboBin.Text, MsgBoxStyle.Information, "Information")

                displayFishBinDeposited()
                cmdClose.Focus()
            End If
        End If
    End Sub
End Class
