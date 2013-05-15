Public Class frmSICC
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents txtDateValid As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboAuthority As C1.Win.C1List.C1Combo
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents txtDateDepart As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateArrive As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboMethod As C1.Win.C1List.C1Combo
    Friend WithEvents cboAreaCode As C1.Win.C1List.C1Combo
    Friend WithEvents cboProduct As C1.Win.C1List.C1Combo
    Friend WithEvents cboProcessing As C1.Win.C1List.C1Combo
    Friend WithEvents cboRefNo As C1.Win.C1List.C1Combo
    Friend WithEvents lblRegNo As System.Windows.Forms.Label
    Friend WithEvents lblCallSign As System.Windows.Forms.Label
    Friend WithEvents lblLicNo As System.Windows.Forms.Label
    Friend WithEvents lblExpiration As System.Windows.Forms.Label
    Friend WithEvents lblTelNo As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblOcean As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuMFV As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMCA As System.Windows.Forms.MenuItem
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPreservationMethod As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDateUnload As C1.Win.C1Input.C1DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSICC))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDateUnload = New C1.Win.C1Input.C1DateEdit()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblOcean = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelNo = New System.Windows.Forms.Label()
        Me.lblExpiration = New System.Windows.Forms.Label()
        Me.lblLicNo = New System.Windows.Forms.Label()
        Me.lblCallSign = New System.Windows.Forms.Label()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.cboRefNo = New C1.Win.C1List.C1Combo()
        Me.cboProcessing = New C1.Win.C1List.C1Combo()
        Me.cboProduct = New C1.Win.C1List.C1Combo()
        Me.cboAreaCode = New C1.Win.C1List.C1Combo()
        Me.cboMethod = New C1.Win.C1List.C1Combo()
        Me.txtDateArrive = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateDepart = New C1.Win.C1Input.C1DateEdit()
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.cboAuthority = New C1.Win.C1List.C1Combo()
        Me.txtDateValid = New C1.Win.C1Input.C1DateEdit()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuMCA = New System.Windows.Forms.MenuItem()
        Me.mnuMFV = New System.Windows.Forms.MenuItem()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPreservationMethod = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.txtDateUnload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProcessing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAreaCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateArrive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAuthority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateValid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPreservationMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1})
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(849, 208)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.txtDateUnload, Me.Label27, Me.lblOcean, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.Label20, Me.lblEmail, Me.lblTelNo, Me.lblExpiration, Me.lblLicNo, Me.lblCallSign, Me.lblRegNo, Me.cboRefNo, Me.cboProcessing, Me.cboProduct, Me.cboAreaCode, Me.cboMethod, Me.txtDateArrive, Me.txtDateDepart, Me.cboVessel, Me.cboAuthority, Me.txtDateValid, Me.txtCC, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label17, Me.Label7, Me.Label4, Me.Label3, Me.Label2, Me.Label5})
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(841, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Solomon Island Catch Certificate Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Unloading Date"
        '
        'txtDateUnload
        '
        Me.txtDateUnload.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateUnload.Location = New System.Drawing.Point(128, 141)
        Me.txtDateUnload.Name = "txtDateUnload"
        Me.txtDateUnload.Size = New System.Drawing.Size(136, 23)
        Me.txtDateUnload.TabIndex = 69
        Me.txtDateUnload.Tag = Nothing
        Me.txtDateUnload.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(472, 83)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(110, 16)
        Me.Label27.TabIndex = 68
        Me.Label27.Text = "RMO Reference #"
        '
        'lblOcean
        '
        Me.lblOcean.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOcean.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcean.Location = New System.Drawing.Point(584, 48)
        Me.lblOcean.Name = "lblOcean"
        Me.lblOcean.Size = New System.Drawing.Size(248, 24)
        Me.lblOcean.TabIndex = 67
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(472, 368)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 16)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Product"
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(472, 400)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(101, 16)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Processing Type"
        Me.Label22.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(472, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 16)
        Me.Label23.TabIndex = 64
        Me.Label23.Text = "Ocean"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(472, 384)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 16)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Fishing Method"
        Me.Label24.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(472, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 16)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Catch Area Code"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 115)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 16)
        Me.Label20.TabIndex = 61
        Me.Label20.Text = "Arrival Date"
        '
        'lblEmail
        '
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(128, 512)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(320, 24)
        Me.lblEmail.TabIndex = 60
        Me.lblEmail.Visible = False
        '
        'lblTelNo
        '
        Me.lblTelNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTelNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelNo.Location = New System.Drawing.Point(128, 480)
        Me.lblTelNo.Name = "lblTelNo"
        Me.lblTelNo.Size = New System.Drawing.Size(320, 24)
        Me.lblTelNo.TabIndex = 59
        Me.lblTelNo.Visible = False
        '
        'lblExpiration
        '
        Me.lblExpiration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExpiration.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiration.Location = New System.Drawing.Point(128, 448)
        Me.lblExpiration.Name = "lblExpiration"
        Me.lblExpiration.Size = New System.Drawing.Size(320, 24)
        Me.lblExpiration.TabIndex = 58
        Me.lblExpiration.Visible = False
        '
        'lblLicNo
        '
        Me.lblLicNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLicNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicNo.Location = New System.Drawing.Point(128, 416)
        Me.lblLicNo.Name = "lblLicNo"
        Me.lblLicNo.Size = New System.Drawing.Size(320, 24)
        Me.lblLicNo.TabIndex = 57
        Me.lblLicNo.Visible = False
        '
        'lblCallSign
        '
        Me.lblCallSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCallSign.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCallSign.Location = New System.Drawing.Point(128, 384)
        Me.lblCallSign.Name = "lblCallSign"
        Me.lblCallSign.Size = New System.Drawing.Size(320, 24)
        Me.lblCallSign.TabIndex = 56
        Me.lblCallSign.Visible = False
        '
        'lblRegNo
        '
        Me.lblRegNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegNo.Location = New System.Drawing.Point(128, 352)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(320, 24)
        Me.lblRegNo.TabIndex = 55
        Me.lblRegNo.Visible = False
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
        Me.cboRefNo.ContentHeight = 18
        Me.cboRefNo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRefNo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRefNo.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRefNo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRefNo.EditorHeight = 18
        Me.cboRefNo.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboRefNo.ItemHeight = 20
        Me.cboRefNo.Location = New System.Drawing.Point(584, 79)
        Me.cboRefNo.MatchEntryTimeout = CType(2000, Long)
        Me.cboRefNo.MaxDropDownItems = CType(20, Short)
        Me.cboRefNo.MaxLength = 32767
        Me.cboRefNo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRefNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRefNo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRefNo.Size = New System.Drawing.Size(248, 24)
        Me.cboRefNo.TabIndex = 54
        Me.cboRefNo.Text = "*"
        Me.cboRefNo.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboProcessing
        '
        Me.cboProcessing.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboProcessing.AllowColMove = False
        Me.cboProcessing.AutoCompletion = True
        Me.cboProcessing.AutoDropDown = True
        Me.cboProcessing.Caption = ""
        Me.cboProcessing.CaptionHeight = 17
        Me.cboProcessing.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProcessing.ColumnCaptionHeight = 17
        Me.cboProcessing.ColumnFooterHeight = 17
        Me.cboProcessing.ContentHeight = 18
        Me.cboProcessing.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboProcessing.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboProcessing.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcessing.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProcessing.EditorHeight = 18
        Me.cboProcessing.Enabled = False
        Me.cboProcessing.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.cboProcessing.ItemHeight = 20
        Me.cboProcessing.Location = New System.Drawing.Point(584, 400)
        Me.cboProcessing.MatchEntryTimeout = CType(2000, Long)
        Me.cboProcessing.MaxDropDownItems = CType(20, Short)
        Me.cboProcessing.MaxLength = 32767
        Me.cboProcessing.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboProcessing.Name = "cboProcessing"
        Me.cboProcessing.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProcessing.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboProcessing.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProcessing.Size = New System.Drawing.Size(248, 24)
        Me.cboProcessing.TabIndex = 53
        Me.cboProcessing.TabStop = False
        Me.cboProcessing.Text = "*"
        Me.cboProcessing.Visible = False
        Me.cboProcessing.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:Near;}OddRow{}Reco" & _
        "rdSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Border:Raised,," & _
        "1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{}Style11{}St" & _
        "yle1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColMove=""False"" Al" & _
        "lowColSelect=""False"" Name=""Split[0,0]"" CaptionHeight=""17"" ColumnCaptionHeight=""1" & _
        "7"" ColumnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Cl" & _
        "ientRect>0, 0, 116, 156</ClientRect><Height>156</Height><VScrollBar><Width>16</W" & _
        "idth></VScrollBar><HScrollBar><Height>16</Height></HScrollBar><CaptionStyle pare" & _
        "nt=""Style2"" me=""Style9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterSt" & _
        "yle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><Hea" & _
        "dingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow" & _
        """ me=""Style6"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle pare" & _
        "nt=""OddRow"" me=""Style8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style" & _
        "10"" /><SelectedStyle parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""" & _
        "Style1"" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent="""" me=" & _
        """Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foo" & _
        "ter"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inacti" & _
        "ve"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Gro" & _
        "up"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>" & _
        "Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>"
        '
        'cboProduct
        '
        Me.cboProduct.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboProduct.AllowColMove = False
        Me.cboProduct.AutoCompletion = True
        Me.cboProduct.AutoDropDown = True
        Me.cboProduct.Caption = ""
        Me.cboProduct.CaptionHeight = 17
        Me.cboProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProduct.ColumnCaptionHeight = 17
        Me.cboProduct.ColumnFooterHeight = 17
        Me.cboProduct.ContentHeight = 18
        Me.cboProduct.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboProduct.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboProduct.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProduct.EditorHeight = 18
        Me.cboProduct.Enabled = False
        Me.cboProduct.Images.Add(CType(resources.GetObject("resource.Images2"), System.Drawing.Bitmap))
        Me.cboProduct.ItemHeight = 20
        Me.cboProduct.Location = New System.Drawing.Point(584, 368)
        Me.cboProduct.MatchEntryTimeout = CType(2000, Long)
        Me.cboProduct.MaxDropDownItems = CType(20, Short)
        Me.cboProduct.MaxLength = 32767
        Me.cboProduct.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProduct.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProduct.Size = New System.Drawing.Size(248, 24)
        Me.cboProduct.TabIndex = 52
        Me.cboProduct.TabStop = False
        Me.cboProduct.Text = "*"
        Me.cboProduct.Visible = False
        Me.cboProduct.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:Near;}OddRow{}Reco" & _
        "rdSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Border:Raised,," & _
        "1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{}Style11{}St" & _
        "yle1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColMove=""False"" Al" & _
        "lowColSelect=""False"" Name=""Split[0,0]"" CaptionHeight=""17"" ColumnCaptionHeight=""1" & _
        "7"" ColumnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Cl" & _
        "ientRect>0, 0, 116, 156</ClientRect><Height>156</Height><VScrollBar><Width>16</W" & _
        "idth></VScrollBar><HScrollBar><Height>16</Height></HScrollBar><CaptionStyle pare" & _
        "nt=""Style2"" me=""Style9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterSt" & _
        "yle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><Hea" & _
        "dingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow" & _
        """ me=""Style6"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle pare" & _
        "nt=""OddRow"" me=""Style8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style" & _
        "10"" /><SelectedStyle parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""" & _
        "Style1"" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent="""" me=" & _
        """Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foo" & _
        "ter"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inacti" & _
        "ve"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Gro" & _
        "up"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>" & _
        "Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>"
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
        Me.cboAreaCode.Images.Add(CType(resources.GetObject("resource.Images3"), System.Drawing.Bitmap))
        Me.cboAreaCode.ItemHeight = 20
        Me.cboAreaCode.Location = New System.Drawing.Point(584, 16)
        Me.cboAreaCode.MatchEntryTimeout = CType(2000, Long)
        Me.cboAreaCode.MaxDropDownItems = CType(20, Short)
        Me.cboAreaCode.MaxLength = 32767
        Me.cboAreaCode.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboAreaCode.Name = "cboAreaCode"
        Me.cboAreaCode.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboAreaCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboAreaCode.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboAreaCode.Size = New System.Drawing.Size(248, 24)
        Me.cboAreaCode.TabIndex = 51
        Me.cboAreaCode.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboMethod
        '
        Me.cboMethod.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboMethod.AllowColMove = False
        Me.cboMethod.AutoCompletion = True
        Me.cboMethod.AutoDropDown = True
        Me.cboMethod.Caption = ""
        Me.cboMethod.CaptionHeight = 17
        Me.cboMethod.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMethod.ColumnCaptionHeight = 17
        Me.cboMethod.ColumnFooterHeight = 17
        Me.cboMethod.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboMethod.ContentHeight = 18
        Me.cboMethod.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboMethod.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboMethod.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMethod.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMethod.EditorHeight = 18
        Me.cboMethod.Enabled = False
        Me.cboMethod.Images.Add(CType(resources.GetObject("resource.Images4"), System.Drawing.Bitmap))
        Me.cboMethod.ItemHeight = 20
        Me.cboMethod.Location = New System.Drawing.Point(584, 384)
        Me.cboMethod.MatchEntryTimeout = CType(2000, Long)
        Me.cboMethod.MaxDropDownItems = CType(20, Short)
        Me.cboMethod.MaxLength = 32767
        Me.cboMethod.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMethod.Name = "cboMethod"
        Me.cboMethod.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMethod.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMethod.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMethod.Size = New System.Drawing.Size(248, 24)
        Me.cboMethod.TabIndex = 50
        Me.cboMethod.TabStop = False
        Me.cboMethod.Visible = False
        Me.cboMethod.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtDateArrive
        '
        Me.txtDateArrive.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateArrive.Location = New System.Drawing.Point(128, 112)
        Me.txtDateArrive.Name = "txtDateArrive"
        Me.txtDateArrive.Size = New System.Drawing.Size(136, 23)
        Me.txtDateArrive.TabIndex = 49
        Me.txtDateArrive.Tag = Nothing
        Me.txtDateArrive.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateDepart
        '
        Me.txtDateDepart.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateDepart.Location = New System.Drawing.Point(128, 80)
        Me.txtDateDepart.Name = "txtDateDepart"
        Me.txtDateDepart.Size = New System.Drawing.Size(136, 23)
        Me.txtDateDepart.TabIndex = 48
        Me.txtDateDepart.Tag = Nothing
        Me.txtDateDepart.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cboVessel.Images.Add(CType(resources.GetObject("resource.Images5"), System.Drawing.Bitmap))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(128, 48)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(20, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.Size = New System.Drawing.Size(320, 24)
        Me.cboVessel.TabIndex = 47
        Me.cboVessel.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboAuthority
        '
        Me.cboAuthority.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboAuthority.Caption = ""
        Me.cboAuthority.CaptionHeight = 17
        Me.cboAuthority.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAuthority.ColumnCaptionHeight = 17
        Me.cboAuthority.ColumnFooterHeight = 17
        Me.cboAuthority.ContentHeight = 18
        Me.cboAuthority.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboAuthority.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboAuthority.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAuthority.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAuthority.EditorHeight = 18
        Me.cboAuthority.Enabled = False
        Me.cboAuthority.Images.Add(CType(resources.GetObject("resource.Images6"), System.Drawing.Bitmap))
        Me.cboAuthority.ItemHeight = 20
        Me.cboAuthority.Location = New System.Drawing.Point(128, 408)
        Me.cboAuthority.MatchEntryTimeout = CType(2000, Long)
        Me.cboAuthority.MaxDropDownItems = CType(5, Short)
        Me.cboAuthority.MaxLength = 32767
        Me.cboAuthority.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboAuthority.Name = "cboAuthority"
        Me.cboAuthority.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboAuthority.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboAuthority.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboAuthority.Size = New System.Drawing.Size(320, 24)
        Me.cboAuthority.TabIndex = 46
        Me.cboAuthority.TabStop = False
        Me.cboAuthority.Text = "Ministry Of Fisheries And Marine Resources"
        Me.cboAuthority.Visible = False
        Me.cboAuthority.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:Near;}OddRow{}Reco" & _
        "rdSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Border:Raised,," & _
        "1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{}Style11{}St" & _
        "yle1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColSelect=""False"" " & _
        "Name=""Split[0,0]"" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight" & _
        "=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 1" & _
        "56</ClientRect><Height>156</Height><VScrollBar><Width>16</Width></VScrollBar><HS" & _
        "crollBar><Height>16</Height></HScrollBar><CaptionStyle parent=""Style2"" me=""Style" & _
        "9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" m" & _
        "e=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Hea" & _
        "ding"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><Inac" & _
        "tiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style" & _
        "8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle " & _
        "parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1" & _
        "List.ListBoxView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style par" & _
        "ent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=" & _
        """Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""" & _
        "Normal"" me=""Selected"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent" & _
        "=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Hea" & _
        "ding"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><" & _
        "vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" & _
        "aultRecSelWidth>16</DefaultRecSelWidth></Blob>"
        '
        'txtDateValid
        '
        Me.txtDateValid.Enabled = False
        Me.txtDateValid.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateValid.Location = New System.Drawing.Point(128, 376)
        Me.txtDateValid.Name = "txtDateValid"
        Me.txtDateValid.Size = New System.Drawing.Size(176, 23)
        Me.txtDateValid.TabIndex = 45
        Me.txtDateValid.TabStop = False
        Me.txtDateValid.Tag = Nothing
        Me.txtDateValid.Visible = False
        Me.txtDateValid.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(128, 17)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(176, 23)
        Me.txtCC.TabIndex = 44
        Me.txtCC.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 520)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "E-mail Address"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 16)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Validate To"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Departure Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 376)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 16)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Validation Date"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 480)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Telephone No."
        Me.Label14.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 416)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 16)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Fishing License No."
        Me.Label17.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Registration No."
        Me.Label7.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Vessel Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Validating Authority"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Document No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Call Sign"
        Me.Label5.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(554, 456)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(474, 456)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 9
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(394, 456)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 8
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Bitmap)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(314, 456)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Bitmap)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(234, 456)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 6
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(862, 40)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Catch Information"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMCA, Me.mnuMFV})
        '
        'mnuMCA
        '
        Me.mnuMCA.Index = 0
        Me.mnuMCA.Text = "&Catch Area Code"
        '
        'mnuMFV
        '
        Me.mnuMFV.Index = 1
        Me.mnuMFV.Text = "Fishing &Vessel"
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource.Images7"), System.Drawing.Bitmap))
        Me.grid.Location = New System.Drawing.Point(137, 264)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(718, 176)
        Me.grid.TabIndex = 29
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
        "th=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>172</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 714, 172</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>16</DefaultRecSelWidth><ClientArea>0, 0, 714, 172</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Fish Lot details"
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
        Me.cboPreservationMethod.Images.Add(CType(resources.GetObject("resource.Images8"), System.Drawing.Bitmap))
        Me.cboPreservationMethod.Location = New System.Drawing.Point(448, 288)
        Me.cboPreservationMethod.Name = "cboPreservationMethod"
        Me.cboPreservationMethod.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPreservationMethod.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboPreservationMethod.RowHeight = 20
        Me.cboPreservationMethod.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPreservationMethod.ScrollTips = False
        Me.cboPreservationMethod.Size = New System.Drawing.Size(216, 152)
        Me.cboPreservationMethod.TabIndex = 42
        Me.cboPreservationMethod.Text = "C1TrueDBDropdown1"
        Me.cboPreservationMethod.Visible = False
        Me.cboPreservationMethod.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.DropdownView Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" C" & _
        "olumnFooterHeight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" " & _
        "DefRecSelWidth=""16"" RecordSelectors=""False"" VerticalScrollGroup=""1"" HorizontalSc" & _
        "rollGroup=""1""><Height>148</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><" & _
        "EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Sty" & _
        "le8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Fo" & _
        "oter"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle pare" & _
        "nt=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" " & _
        "/><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me" & _
        "=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><Selecte" & _
        "dStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><Cli" & _
        "entRect>0, 0, 212, 148</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken" & _
        "</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView></Splits><NamedStyles><Style pa" & _
        "rent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Headi" & _
        "ng"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading""" & _
        " me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" m" & _
        "e=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" m" & _
        "e=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""R" & _
        "ecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption""" & _
        " me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits>" & _
        "<Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0" & _
        ", 212, 148</ClientArea></Blob>"
        '
        'frmSICC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(862, 511)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPreservationMethod, Me.Label1, Me.grid, Me.Label16, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdEdit, Me.cmd, Me.TabControl1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSICC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSICC"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.txtDateUnload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProcessing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAreaCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateArrive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateDepart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAuthority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateValid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPreservationMethod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSICC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        startup = 0
        txtDateValid.Value = getServerDateTime()
        txtDateDepart.Value = getServerDateTime()
        txtDateArrive.Value = getServerDateTime()
        txtDateUnload.Value = getServerDateTime()
        dataEntry(1)

        'displayAllCC()
        displayFishingVessel()
        displayCatchAreas()
        displayCC_Reference()
        displayFishingMethods()
        'displayListsofFishLot(txtDateDepart.Value)

        Me.displayListsofFishLot(txtDateArrive.Value)

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayFishingVessel()
        With cboVessel
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

    Public Sub displayFishingMethods()
        With cboMethod
            .DataSource = modModule.getFishingMethod().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 225
        End With
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
                Me.TabControl1.TabPages(0).Enabled = True
                grid.Enabled = True
            Case 1
                Me.TabControl1.TabPages(0).Enabled = False
                grid.Enabled = False
        End Select
    End Sub

    Private Sub cboAreaCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreaCode.TextChanged
        If Not cboAreaCode.Text = "" Then
            lblOcean.Text = getFAOOCean(cboAreaCode.Text)
        Else
            lblOcean.Text = ""
        End If
    End Sub

    Public Sub addNewRecord()
        txtCC.ReadOnly = False
        txtCC.Text = ""
        txtDateValid.Value = getServerDateTime()
        cboAuthority.Text = "Ministry Of Fisheries And Marine Resources"
        displayFishingVessel()
        cboVessel.Text = ""
        txtDateDepart.Value = getServerDateTime()
        txtDateArrive.Value = getServerDateTime()
        displayFishingMethods()
        cboMethod.Text = ""
        displayCatchAreas()
        cboAreaCode.Text = ""
        'lblOcean.Text = ""
        cboProduct.Text = "FROZEN TUNA"
        cboProcessing.Text = "BRINE FREEZING"
        displayCC_Reference()
        cboRefNo.Text = "*"

        displayListsofFishLot(txtDateArrive.Value)
        'displayAllCC()
    End Sub

    Public Sub displayFishingVesselDetails(ByVal vessel As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_display_FishingVesselDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@vessel"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = vessel

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    'lblCode.Text = dr.GetString(0)
                    'txtFlag.Text = dr.GetString(2)
                    'txtPort.Text = dr.GetString(3)
                    lblRegNo.Text = dr.GetString(4)
                    lblCallSign.Text = dr.GetString(5)
                    'txtImo.Text = dr.GetString(6)
                    lblLicNo.Text = dr.GetString(7)
                    'txtImmarsat.Text = dr.GetString(8)
                    'txtTelefax.Text = dr.GetString(9)
                    lblExpiration.Text = dr.GetDateTime(10)
                    lblTelNo.Text = dr.GetString(11)
                    lblEmail.Text = dr.GetString(12)
                Else
                    'lblCode.Text = dr.GetString(0)
                    'txtFlag.Text = dr.GetString(2)
                    'txtPort.Text = dr.GetString(3)
                    lblRegNo.Text = ""
                    lblCallSign.Text = ""
                    'txtImo.Text = dr.GetString(6)
                    lblLicNo.Text = ""
                    'txtImmarsat.Text = dr.GetString(8)
                    'txtTelefax.Text = dr.GetString(9)
                    lblExpiration.Text = ""
                    lblTelNo.Text = ""
                    lblEmail.Text = ""
                End If
            Else
                'lblCode.Text = dr.GetString(0)
                'txtFlag.Text = dr.GetString(2)
                'txtPort.Text = dr.GetString(3)
                lblRegNo.Text = ""
                lblCallSign.Text = ""
                'txtImo.Text = dr.GetString(6)
                lblLicNo.Text = ""
                'txtImmarsat.Text = dr.GetString(8)
                'txtTelefax.Text = dr.GetString(9)
                lblExpiration.Text = ""
                lblTelNo.Text = ""
                lblEmail.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            'MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        'If cboVessel.Text = "" Then If cboVessel.ListCount > 0 Then cboVessel.SelectedIndex = 0
        'displayFishingVesselDetails(cboVessel.Text)

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
                Me.TabControl1.SelectedIndex = 0
                editMode = False
                txtCC.SelectAll()
                txtCC.Focus()
            Case "&Save"
                setFishYear()
                setFishTrip()
                setFishLot()

                If Not txtCC.Text.Trim = "" And Not cboVessel.Text.Trim = "" And _
                Not cboAreaCode.Text.Trim = "" And Not lblOcean.Text.Trim = "" And _
                Not cboRefNo.Text.Trim = "" And grid.RowCount > 0 And _
                Not isFishLotEntriesEmpty() Then
                    If Not validateCC(txtCC.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            'saveNewSICC(txtCC.Text, txtDateValid.Text, cboAuthority.Text, cboVessel.Text, _
                            '    txtDateDepart.Text, txtDateArrive.Text, cboMethod.Text, cboAreaCode.Text, _
                            '    cboProduct.Text, cboProcessing.Text, cboRefNo.Text, txtDateUnload.Text)
                            saveNewSICC_Details(txtCC.Text, "", "", cboAreaCode.Text, "1/1/1901", "1/1/1901", "0", "0")

                            'SAVE BATCHLOT
                            Dim ctr As Integer
                            While ctr < grid.RowCount
                                If Not validateFishLot(grid.Item(ctr, 0)) Then
                                    saveNewFishLot(grid.Item(ctr, 0), "National%", "Normal Quality", txtCC.Text, grid.Item(ctr, 5), txtDateUnload.Text, CInt(grid.Item(ctr, 1)), CInt(grid.Item(ctr, 2)))
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
                        txtCC.SelectAll()
                        txtCC.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtCC.SelectAll()
                    txtCC.Focus()
                End If
            Case "&Save "
                If Not isFishLotEntriesEmpty() Then
                    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        'updateSICC(txtCC.Text, txtDateValid.Text, cboAuthority.Text, cboVessel.Text, _
                        '    txtDateDepart.Text, txtDateArrive.Text, cboMethod.Text, cboAreaCode.Text, _
                        '    cboProduct.Text, cboProcessing.Text, cboRefNo.Text, txtDateUnload.Text)
                        updateSICCDetails(txtCC.Text, "", "", cboAreaCode.Text, "1/1/1901", "1/1/1901", "0", "0")

                        'SAVE BATCHLOT
                        Dim ctr As Integer
                        While ctr < grid.RowCount
                            If Not validateFishLot(grid.Item(ctr, 0)) Then
                                saveNewFishLot(grid.Item(ctr, 0), "National%", "Normal Quality", txtCC.Text, grid.Item(ctr, 5), txtDateUnload.Text, CInt(grid.Item(ctr, 1)), CInt(grid.Item(ctr, 2)))
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
                If Not txtCC.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    txtCC.ReadOnly = True
                    editMode = True
                    cboVessel.SelectAll()
                    cboVessel.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboVessel.SelectAll()
                    cboVessel.Focus()
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
                    'txtDateValid.Value = dr.GetDateTime(1)
                    'cboAuthority.Text = dr.GetString(2)
                    cboVessel.Text = dr.GetString(2)
                    txtDateDepart.Value = dr.GetDateTime(3)
                    txtDateArrive.Value = dr.GetDateTime(4)
                    txtDateUnload.Value = dr.GetDateTime(5)
                    cboMethod.Text = dr.GetString(6)
                    cboAreaCode.Text = dr.GetString(7)
                    'lblOcean.Text = ""
                    'cboProduct.Text = dr.GetString(15)
                    'cboProcessing.Text = dr.GetString(16)
                    cboRefNo.Text = dr.GetString(9)
                Else
                    'txtDateValid.Value = Format(getServerDateTime(), getTimeFormat())
                    'cboAuthority.Text = "Ministry Of Fisheries And Marine Resources"
                    cboVessel.Text = ""
                    txtDateDepart.Value = Format(getServerDateTime(), getTimeFormat())
                    txtDateArrive.Value = Format(getServerDateTime(), getTimeFormat())
                    txtDateUnload.Value = Format(getServerDateTime(), getTimeFormat())
                    cboMethod.Text = ""
                    cboAreaCode.Text = ""
                    'lblOcean.Text = ""
                    'cboProduct.Text = "*"
                    'cboProcessing.Text = "*"
                    cboRefNo.Text = "*"
                End If
            Else
                'txtDateValid.Value = Format(getServerDateTime(), getTimeFormat())
                'cboAuthority.Text = "Ministry Of Fisheries And Marine Resources"
                cboVessel.Text = ""
                txtDateDepart.Value = Format(getServerDateTime(), getTimeFormat())
                txtDateArrive.Value = Format(getServerDateTime(), getTimeFormat())
                txtDateUnload.Value = Format(getServerDateTime(), getTimeFormat())
                cboMethod.Text = ""
                cboAreaCode.Text = ""
                'lblOcean.Text = ""
                'cboProduct.Text = "*"
                'cboProcessing.Text = "*"
                cboRefNo.Text = "*"
            End If

            dr.Close()
            c.Close()

            displayFishLotBySICC(txtCC.Text)
        Catch e As Exception
            MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Private Sub txtCC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCC.TextChanged
        displayRecord(txtCC.Text)
    End Sub

    Private Sub mnuMFV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFV.Click
        Dim f As New frmFishingVessel()
        f.ShowDialog(Me)

        displayFishingVessel()
        cboVessel.SelectAll()
        cboVessel.Focus()
    End Sub

    Private Sub mnuMCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMCA.Click
        Dim f As New frmFAO()
        f.ShowDialog(Me)

        displayCatchAreas()
        cboAreaCode.SelectAll()
        cboAreaCode.Focus()
    End Sub

    'Public Sub displayDataToEachDataEntry()
    '    With grid
    '        If .RowCount > 0 Then
    '            txtCC.Text = .Item(.Row, 0)
    '        Else
    '            txtCC.Text = ""
    '        End If
    '    End With
    'End Sub

    Private Sub grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'displayDataToEachDataEntry()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Solomon Catch Certificate"
        f.searchType = 2
        f.displayAllCC()
        f.ShowDialog(Me)

        If Not f.cancel Then txtCC.Text = f.searchItem
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
            .Splits(0).DisplayColumns(5).Width = 210

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
        If Not cboVessel.Text = "" Then
            Dim ctr As Integer
            While ctr < grid.RowCount
                If Not grid.Item(ctr, 1) Is DBNull.Value And Not grid.Item(ctr, 2) Is DBNull.Value Then
                    grid.Item(ctr, 0) = getVesselCode(cboVessel.Text) & _
                        Format(CInt(grid.Item(ctr, 1)), "0#") & _
                        Format(CInt(grid.Item(ctr, 2)), "0#")
                End If

                ctr += 1
            End While
        End If
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
                .Splits(0).DisplayColumns(5).Width = 210

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

    Private Sub txtCC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCC.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboVessel.SelectAll()
            cboVessel.Focus()
        End If
    End Sub

    Private Sub txtDateValid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDateValid.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboAuthority.SelectAll()
            cboAuthority.Focus()
        End If
    End Sub

    Private Sub cboAuthority_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAuthority.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboVessel.SelectAll()
            cboVessel.Focus()
        End If
    End Sub

    Private Sub cboVessel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVessel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDateDepart.Focus()
        End If
    End Sub

    Private Sub txtDateDepart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDateDepart.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDateArrive.Focus()
        End If
    End Sub

    Private Sub txtDateArrive_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDateArrive.KeyDown
        If e.KeyCode = Keys.Enter Then
            setFishYear()
            txtDateUnload.Focus()
        End If
    End Sub

    Private Sub txtDateUnload_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDateUnload.KeyDown
        If e.KeyCode = Keys.Enter Then
            'cboMethod.SelectAll()
            'cboMethod.Focus()
            cboAreaCode.SelectAll()
            cboAreaCode.Focus()
        End If
    End Sub

    Private Sub cboMethod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMethod.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboAreaCode.SelectAll()
            cboAreaCode.Focus()
        End If
    End Sub

    Private Sub cboAreaCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAreaCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            'cboProduct.SelectAll()
            'cboProduct.Focus()
            cboRefNo.SelectAll()
            cboRefNo.Focus()
        End If
    End Sub

    Private Sub cboProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProduct.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboProcessing.SelectAll()
            cboProcessing.Focus()
        End If
    End Sub

    Private Sub cboProcessing_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProcessing.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboRefNo.SelectAll()
            cboRefNo.Focus()
        End If
    End Sub

    Private Sub cboRefNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRefNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid.Focus()
        End If
    End Sub

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
End Class
