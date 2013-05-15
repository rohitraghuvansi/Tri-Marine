Public Class frmBagsWithdrawal
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents gridSummary As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdAClose As System.Windows.Forms.Button
    Friend WithEvents cmdASave As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboPurpose As C1.Win.C1List.C1Combo
    Friend WithEvents lblTotalYF As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboChoices As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents lblTotalBE As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSJ As System.Windows.Forms.Label
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboRN As C1.Win.C1List.C1Combo
    Friend WithEvents cboProdnShift As C1.Win.C1List.C1Combo
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboBin As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboRelShift As C1.Win.C1List.C1Combo
    Friend WithEvents txtRelDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFWS As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAL As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBagsWithdrawal))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label16 = New System.Windows.Forms.Label
        Me.gridSummary = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.grp = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdAClose = New System.Windows.Forms.Button
        Me.cmdASave = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboPurpose = New C1.Win.C1List.C1Combo
        Me.lblTotalYF = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cboChoices = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.lblTotalBE = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblTotalSJ = New System.Windows.Forms.Label
        Me.cboCS = New C1.Win.C1List.C1Combo
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboRN = New C1.Win.C1List.C1Combo
        Me.cboProdnShift = New C1.Win.C1List.C1Combo
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboBin = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cboLot = New C1.Win.C1List.C1Combo
        Me.cboRelShift = New C1.Win.C1List.C1Combo
        Me.txtRelDate = New C1.Win.C1Input.C1DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFWS = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTotalAL = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        CType(Me.gridSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.cboPurpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboChoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProdnShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRelShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRelDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(774, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(169, 19)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Total Withdrawal of the day"
        '
        'gridSummary
        '
        Me.gridSummary.AllowColMove = False
        Me.gridSummary.AllowUpdate = False
        Me.gridSummary.CaptionHeight = 17
        Me.gridSummary.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSummary.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridSummary.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.gridSummary.Location = New System.Drawing.Point(774, 73)
        Me.gridSummary.Name = "gridSummary"
        Me.gridSummary.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridSummary.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridSummary.PreviewInfo.ZoomFactor = 75
        Me.gridSummary.RowHeight = 20
        Me.gridSummary.Size = New System.Drawing.Size(194, 520)
        Me.gridSummary.TabIndex = 80
        Me.gridSummary.Text = "C1TrueDBGrid1"
        Me.gridSummary.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "th=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>516</Height><C" & _
        "aptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Styl" & _
        "e5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""Filte" & _
        "rBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pare" & _
        "nt=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLigh" & _
        "tRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" m" & _
        "e=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle par" & _
        "ent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6""" & _
        " /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 190, 516</ClientRect><" & _
        "BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid." & _
        "MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""No" & _
        "rmal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Headin" & _
        "g"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal""" & _
        " me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=" & _
        """HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me" & _
        "=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal""" & _
        " me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits" & _
        ">1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidt" & _
        "h>16</DefaultRecSelWidth><ClientArea>0, 0, 190, 516</ClientArea><PrintPageHeader" & _
        "Style parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></" & _
        "Blob>"
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Controls.Add(Me.Label11)
        Me.grp.Controls.Add(Me.cmdAClose)
        Me.grp.Controls.Add(Me.cmdASave)
        Me.grp.Controls.Add(Me.txtPassword)
        Me.grp.Controls.Add(Me.txtUsername)
        Me.grp.Enabled = False
        Me.grp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(181, 461)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(416, 136)
        Me.grp.TabIndex = 79
        Me.grp.TabStop = False
        Me.grp.Text = "User Authentication"
        Me.grp.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 19)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Username"
        '
        'cmdAClose
        '
        Me.cmdAClose.Image = CType(resources.GetObject("cmdAClose.Image"), System.Drawing.Image)
        Me.cmdAClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAClose.Location = New System.Drawing.Point(211, 88)
        Me.cmdAClose.Name = "cmdAClose"
        Me.cmdAClose.Size = New System.Drawing.Size(75, 40)
        Me.cmdAClose.TabIndex = 3
        Me.cmdAClose.Text = "&Cancel"
        Me.cmdAClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdASave
        '
        Me.cmdASave.Image = CType(resources.GetObject("cmdASave.Image"), System.Drawing.Image)
        Me.cmdASave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdASave.Location = New System.Drawing.Point(131, 88)
        Me.cmdASave.Name = "cmdASave"
        Me.cmdASave.Size = New System.Drawing.Size(75, 40)
        Me.cmdASave.TabIndex = 2
        Me.cmdASave.Text = "&Override"
        Me.cmdASave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(148, 56)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(216, 23)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = ""
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(148, 24)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(216, 23)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Text = ""
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(512, 547)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 78
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(432, 547)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 77
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Enabled = False
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(352, 547)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 76
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(272, 547)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 75
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(192, 547)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 74
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(973, 40)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Flake Bags Withdrawal Slip"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(5, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 494)
        Me.TabControl1.TabIndex = 72
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.cboPurpose)
        Me.TabPage1.Controls.Add(Me.lblTotalYF)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.cboChoices)
        Me.TabPage1.Controls.Add(Me.lblTotalBE)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.lblTotalSJ)
        Me.TabPage1.Controls.Add(Me.cboCS)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cboRN)
        Me.TabPage1.Controls.Add(Me.cboProdnShift)
        Me.TabPage1.Controls.Add(Me.txtProdnDate)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cboBin)
        Me.TabPage1.Controls.Add(Me.grid)
        Me.TabPage1.Controls.Add(Me.cboLot)
        Me.TabPage1.Controls.Add(Me.cboRelShift)
        Me.TabPage1.Controls.Add(Me.txtRelDate)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblFWS)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblTotalAL)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(755, 465)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fish Withdrawal Slip"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(440, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 19)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Purpose"
        '
        'cboPurpose
        '
        Me.cboPurpose.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboPurpose.AllowColMove = False
        Me.cboPurpose.AutoCompletion = True
        Me.cboPurpose.AutoDropDown = True
        Me.cboPurpose.Caption = ""
        Me.cboPurpose.CaptionHeight = 17
        Me.cboPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPurpose.ColumnCaptionHeight = 17
        Me.cboPurpose.ColumnFooterHeight = 17
        Me.cboPurpose.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboPurpose.ContentHeight = 18
        Me.cboPurpose.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboPurpose.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPurpose.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPurpose.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPurpose.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPurpose.EditorHeight = 18
        Me.cboPurpose.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboPurpose.ItemHeight = 20
        Me.cboPurpose.Location = New System.Drawing.Point(560, 48)
        Me.cboPurpose.MatchEntryTimeout = CType(2000, Long)
        Me.cboPurpose.MaxDropDownItems = CType(5, Short)
        Me.cboPurpose.MaxLength = 32767
        Me.cboPurpose.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPurpose.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPurpose.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPurpose.Size = New System.Drawing.Size(176, 24)
        Me.cboPurpose.TabIndex = 42
        Me.cboPurpose.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}RecordSelector{Alig" & _
        "nImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;For" & _
        "eColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}Style9{AlignHorz:" & _
        "Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColMove=""False"" Al" & _
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
        'lblTotalYF
        '
        Me.lblTotalYF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalYF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalYF.Location = New System.Drawing.Point(560, 120)
        Me.lblTotalYF.Name = "lblTotalYF"
        Me.lblTotalYF.Size = New System.Drawing.Size(176, 24)
        Me.lblTotalYF.TabIndex = 52
        Me.lblTotalYF.Text = "0.00"
        Me.lblTotalYF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Gray
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(443, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 19)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Bigeye Total [kg]"
        '
        'cboChoices
        '
        Me.cboChoices.AllowColMove = True
        Me.cboChoices.AllowColSelect = True
        Me.cboChoices.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboChoices.AlternatingRows = False
        Me.cboChoices.CaptionHeight = 17
        Me.cboChoices.ColumnCaptionHeight = 17
        Me.cboChoices.ColumnFooterHeight = 17
        Me.cboChoices.FetchRowStyles = False
        Me.cboChoices.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChoices.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.cboChoices.Location = New System.Drawing.Point(664, 232)
        Me.cboChoices.Name = "cboChoices"
        Me.cboChoices.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboChoices.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboChoices.RowHeight = 20
        Me.cboChoices.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboChoices.ScrollTips = False
        Me.cboChoices.Size = New System.Drawing.Size(72, 96)
        Me.cboChoices.TabIndex = 87
        Me.cboChoices.Text = "C1TrueDBDropdown1"
        Me.cboChoices.Visible = False
        Me.cboChoices.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "order"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>92</Height><CaptionStyle p" & _
        "arent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRo" & _
        "wStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Sty" & _
        "le13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me" & _
        "=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle par" & _
        "ent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" />" & _
        "<OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSe" & _
        "lector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style par" & _
        "ent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 68, 92</ClientRect><BorderSide>0</B" & _
        "orderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 68, 92</ClientArea></Blob>"
        '
        'lblTotalBE
        '
        Me.lblTotalBE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalBE.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBE.Location = New System.Drawing.Point(560, 152)
        Me.lblTotalBE.Name = "lblTotalBE"
        Me.lblTotalBE.Size = New System.Drawing.Size(176, 24)
        Me.lblTotalBE.TabIndex = 54
        Me.lblTotalBE.Text = "0.00"
        Me.lblTotalBE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Gray
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(443, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 19)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Yellowfin Total [kg]"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gray
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(443, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 19)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Skipjack Total [kg]"
        '
        'lblTotalSJ
        '
        Me.lblTotalSJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSJ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSJ.Location = New System.Drawing.Point(560, 88)
        Me.lblTotalSJ.Name = "lblTotalSJ"
        Me.lblTotalSJ.Size = New System.Drawing.Size(176, 24)
        Me.lblTotalSJ.TabIndex = 50
        Me.lblTotalSJ.Text = "0.00"
        Me.lblTotalSJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCS
        '
        Me.cboCS.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboCS.AllowColMove = False
        Me.cboCS.AutoCompletion = True
        Me.cboCS.AutoDropDown = True
        Me.cboCS.Caption = ""
        Me.cboCS.CaptionHeight = 17
        Me.cboCS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCS.ColumnCaptionHeight = 17
        Me.cboCS.ColumnFooterHeight = 17
        Me.cboCS.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboCS.ContentHeight = 18
        Me.cboCS.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCS.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCS.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCS.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCS.EditorHeight = 18
        Me.cboCS.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(112, 142)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(20, Short)
        Me.cboCS.MaxLength = 6
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.Size = New System.Drawing.Size(184, 24)
        Me.cboCS.TabIndex = 40
        Me.cboCS.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(120, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 19)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Release Note#"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 19)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Prodn Shift"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 19)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Prodn Date"
        '
        'cboRN
        '
        Me.cboRN.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboRN.AllowColMove = False
        Me.cboRN.AutoCompletion = True
        Me.cboRN.AutoDropDown = True
        Me.cboRN.Caption = ""
        Me.cboRN.CaptionHeight = 17
        Me.cboRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRN.ColumnCaptionHeight = 17
        Me.cboRN.ColumnFooterHeight = 17
        Me.cboRN.ContentHeight = 18
        Me.cboRN.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRN.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRN.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRN.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRN.EditorHeight = 18
        Me.cboRN.Enabled = False
        Me.cboRN.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.cboRN.ItemHeight = 20
        Me.cboRN.Location = New System.Drawing.Point(120, 200)
        Me.cboRN.MatchEntryTimeout = CType(2000, Long)
        Me.cboRN.MaxDropDownItems = CType(20, Short)
        Me.cboRN.MaxLength = 32767
        Me.cboRN.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRN.Name = "cboRN"
        Me.cboRN.ReadOnly = True
        Me.cboRN.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRN.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRN.Size = New System.Drawing.Size(88, 24)
        Me.cboRN.TabIndex = 49
        Me.cboRN.TabStop = False
        Me.cboRN.Visible = False
        Me.cboRN.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboProdnShift
        '
        Me.cboProdnShift.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboProdnShift.AllowColMove = False
        Me.cboProdnShift.AutoCompletion = True
        Me.cboProdnShift.AutoDropDown = True
        Me.cboProdnShift.Caption = ""
        Me.cboProdnShift.CaptionHeight = 17
        Me.cboProdnShift.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProdnShift.ColumnCaptionHeight = 17
        Me.cboProdnShift.ColumnFooterHeight = 17
        Me.cboProdnShift.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboProdnShift.ContentHeight = 18
        Me.cboProdnShift.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboProdnShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboProdnShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboProdnShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProdnShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProdnShift.EditorHeight = 18
        Me.cboProdnShift.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.cboProdnShift.ItemHeight = 20
        Me.cboProdnShift.Location = New System.Drawing.Point(112, 111)
        Me.cboProdnShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboProdnShift.MaxDropDownItems = CType(20, Short)
        Me.cboProdnShift.MaxLength = 32767
        Me.cboProdnShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboProdnShift.Name = "cboProdnShift"
        Me.cboProdnShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProdnShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboProdnShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProdnShift.Size = New System.Drawing.Size(184, 24)
        Me.cboProdnShift.TabIndex = 39
        Me.cboProdnShift.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtProdnDate
        '
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(112, 80)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(184, 23)
        Me.txtProdnDate.TabIndex = 38
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(442, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Lot No."
        '
        'cboBin
        '
        Me.cboBin.AllowColMove = True
        Me.cboBin.AllowColSelect = True
        Me.cboBin.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboBin.AlternatingRows = False
        Me.cboBin.CaptionHeight = 17
        Me.cboBin.ColumnCaptionHeight = 17
        Me.cboBin.ColumnFooterHeight = 17
        Me.cboBin.FetchRowStyles = False
        Me.cboBin.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.cboBin.Location = New System.Drawing.Point(8, 232)
        Me.cboBin.Name = "cboBin"
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.cboBin.RowHeight = 20
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.ScrollTips = False
        Me.cboBin.Size = New System.Drawing.Size(114, 280)
        Me.cboBin.TabIndex = 42
        Me.cboBin.Text = "C1TrueDBDropdown1"
        Me.cboBin.Visible = False
        Me.cboBin.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "order"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" RecordSelectors=""False"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>276</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 110, 276</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.DropdownView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 110, 276</ClientArea></Blob>"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowDelete = True
        Me.grid.CaptionHeight = 17
        Me.grid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grid.FilterBar = True
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(0, 225)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(755, 240)
        Me.grid.TabIndex = 120
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
        "eight=""17"" FilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=" & _
        """16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Heig" & _
        "ht>236</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=" & _
        """Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarSt" & _
        "yle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 751, " & _
        "236</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1." & _
        "Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" />" & _
        "<Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Sty" & _
        "le parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Styl" & _
        "e parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style pa" & _
        "rent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style p" & _
        "arent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Styl" & _
        "e parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedS" & _
        "tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><" & _
        "DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 751, 236</ClientArea" & _
        "><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" " & _
        "me=""Style15"" /></Blob>"
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
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.Images.Add(CType(resources.GetObject("resource8"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(560, 12)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 6
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.Size = New System.Drawing.Size(176, 24)
        Me.cboLot.TabIndex = 41
        Me.cboLot.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cboRelShift
        '
        Me.cboRelShift.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboRelShift.AllowColMove = False
        Me.cboRelShift.AutoCompletion = True
        Me.cboRelShift.AutoDropDown = True
        Me.cboRelShift.Caption = ""
        Me.cboRelShift.CaptionHeight = 17
        Me.cboRelShift.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRelShift.ColumnCaptionHeight = 17
        Me.cboRelShift.ColumnFooterHeight = 17
        Me.cboRelShift.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboRelShift.ContentHeight = 18
        Me.cboRelShift.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboRelShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRelShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRelShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRelShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRelShift.EditorHeight = 18
        Me.cboRelShift.Enabled = False
        Me.cboRelShift.Images.Add(CType(resources.GetObject("resource9"), System.Drawing.Image))
        Me.cboRelShift.ItemHeight = 20
        Me.cboRelShift.Location = New System.Drawing.Point(304, 12)
        Me.cboRelShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboRelShift.MaxDropDownItems = CType(20, Short)
        Me.cboRelShift.MaxLength = 32767
        Me.cboRelShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRelShift.Name = "cboRelShift"
        Me.cboRelShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRelShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRelShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRelShift.Size = New System.Drawing.Size(96, 24)
        Me.cboRelShift.TabIndex = 38
        Me.cboRelShift.Visible = False
        Me.cboRelShift.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'txtRelDate
        '
        Me.txtRelDate.Location = New System.Drawing.Point(112, 49)
        Me.txtRelDate.Name = "txtRelDate"
        Me.txtRelDate.ReadOnly = True
        Me.txtRelDate.Size = New System.Drawing.Size(184, 23)
        Me.txtRelDate.TabIndex = 37
        Me.txtRelDate.TabStop = False
        Me.txtRelDate.Tag = Nothing
        Me.txtRelDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Fish Bin Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Storage Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "FWS Number"
        '
        'lblFWS
        '
        Me.lblFWS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFWS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWS.Location = New System.Drawing.Point(112, 13)
        Me.lblFWS.Name = "lblFWS"
        Me.lblFWS.Size = New System.Drawing.Size(184, 23)
        Me.lblFWS.TabIndex = 32
        Me.lblFWS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(443, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 19)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Albacore Total [kg]"
        '
        'lblTotalAL
        '
        Me.lblTotalAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAL.Location = New System.Drawing.Point(560, 184)
        Me.lblTotalAL.Name = "lblTotalAL"
        Me.lblTotalAL.Size = New System.Drawing.Size(176, 24)
        Me.lblTotalAL.TabIndex = 30
        Me.lblTotalAL.Text = "0.00"
        Me.lblTotalAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Date Released"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Gray
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(440, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(304, 136)
        Me.Label18.TabIndex = 119
        '
        'frmBagsWithdrawal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(973, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.gridSummary)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBagsWithdrawal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBagsWithdrawal"
        CType(Me.gridSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.cboPurpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboChoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProdnShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRelShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRelDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmBagsWithdrawal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtRelDate.Value = getServerDateTime()
        txtProdnDate.Value = getServerDateTime()

        initializeShift()
        displayPurpose()
        displayColdStorage()
        displayFishLotDepositedDetails(cboCS.Text, cboLot.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtRelDate.Value = getServerDateTime()
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 160

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub initializeShift()
        With cboRelShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 155
            .SelectedIndex = 0
        End With

        With cboProdnShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 160
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayPurpose()
        With cboPurpose
            .ClearItems()
            .AddItemTitles("Purpose")
            .AddItem("For Production")
            .AddItem("For Export")
            .Splits(0).DisplayColumns(0).Width = 155
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayAllBatchlotsDeposited(ByVal cs As String)
        With cboLot
            .Text = ""
            .DataSource = modModule.getBatchlotsDeposited(cs).Tables(0)
            'getBatchlotsDeposited().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 155
            '.Splits(0).DisplayColumns(1).Width = 440
            '.Splits(0).DisplayColumns(2).Width = 118

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboCS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCS.TextChanged
        If cboCS.Text = "" Then If cboCS.ListCount > 0 Then cboCS.SelectedIndex = 0

        displayAllBatchlotsDeposited(cboCS.Text)
        displayFishLotDepositedDetails(cboCS.Text, cboLot.Text)
    End Sub

    Public Sub displayFishLotDepositedDetails(ByVal cs As String, ByVal lot As String)
        With grid
            .DataSource = modModule.getFishLotDepositedDetails_Bags(cs, lot).Tables(0)

            .Splits(0).DisplayColumns(0).Width = 110
            .Splits(0).DisplayColumns(1).Width = 110
            .Splits(0).DisplayColumns(2).Width = 110
            .Splits(0).DisplayColumns(3).Width = 80
            .Splits(0).DisplayColumns(4).Width = 70
            .Splits(0).DisplayColumns(5).Width = 80
            .Splits(0).DisplayColumns(6).Width = 150

            .Splits(0).DisplayColumns(0).Locked = True
            .Splits(0).DisplayColumns(1).Locked = True
            .Splits(0).DisplayColumns(2).Locked = True
            .Splits(0).DisplayColumns(3).Locked = True
            .Splits(0).DisplayColumns(4).Locked = True
            .Splits(0).DisplayColumns(6).Locked = True

            .Columns(3).NumberFormat = "###,##0.0"
            .Columns(4).NumberFormat = "###,##0.#0"
            .Columns(5).DefaultValue = "0"
            .Columns(5).NumberFormat = "###,##0.#0"

            .Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(1).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(2).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(6).Style.BackColor = Color.Gray

            computeTotalWeight()
        End With
    End Sub

    Public Sub computeTotalWeight()
        Dim ctr As Integer
        Dim sj As Double, yf As Double, be As Double, al As Double
        Dim klPerBag As Double
        With grid
            While ctr < .RowCount
                If CStr(.Item(ctr, 1)).StartsWith("Loin") Then
                    klPerBag = 7.5
                Else
                    klPerBag = 8
                End If

                .Item(ctr, 3) = getStoredBags(.Item(ctr, 6)) - getAllocatedBags(.Item(ctr, 6))
                .Item(ctr, 4) = .Item(ctr, 3) / klPerBag


                If Not .Item(ctr, 5) Is DBNull.Value Then
                    'If .Item(ctr, 6) = "Yes" Then
                    If CStr(.Item(ctr, 0)).StartsWith("Skip") Then
                        sj += .Item(ctr, 5)
                    ElseIf CStr(.Item(ctr, 0)).StartsWith("Yellow") Then
                        yf += .Item(ctr, 5)
                    ElseIf CStr(.Item(ctr, 0)).StartsWith("Big") Then
                        be += .Item(ctr, 5)
                    ElseIf CStr(.Item(ctr, 0)).StartsWith("Alb") Then
                        al += .Item(ctr, 5)
                    End If
                    'End If
                End If

                ctr += 1
            End While
        End With

        lblTotalSJ.Text = Format(sj, "###,###,##0.0")
        lblTotalYF.Text = Format(yf, "###,###,##0.0")
        lblTotalBE.Text = Format(be, "###,###,##0.0")
        lblTotalAL.Text = Format(al, "###,###,##0.0")
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displayFishLotDepositedDetails(cboCS.Text, cboLot.Text)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        txtProdnDate.SelectAll()
        txtProdnDate.Focus()
    End Sub

    Public Sub addNewRecord()
        lblFWS.Text = ""
        txtProdnDate.Value = getServerDateTime()
        cboProdnShift.SelectedIndex = 0
        txtRelDate.Value = getServerDateTime()
        cboRelShift.SelectedIndex = 0
        displayColdStorage()
        'displayAllBatchlotsDeposited(cboCS.Text)
        cboLot.Text = ""
        cboPurpose.Text = ""
        displayPurpose()
        'displayReleaseNote()
        cboRN.Text = ""
        displayFishLotDepositedDetails(cboCS.Text, cboLot.Text)
        'computeTotalWeight()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'displayFishBinLoad()
        'computeTotalWeight()
        computeTotalWeight()

        Dim reply As String
        If CDbl(lblTotalSJ.Text) > 0 Or CDbl(lblTotalYF.Text) > 0 Or _
        CDbl(lblTotalBE.Text) > 0 Or CDbl(lblTotalAL.Text) > 0 Then
            If Not txtRelDate.Text.Trim = "" And Not cboCS.Text.Trim = "" And _
                Not txtProdnDate.Text.Trim = "" And Not cboProdnShift.Text.Trim = "" And _
                Not cboLot.Text.Trim = "" And grid.RowCount > 0 Then
                'Not isDataEntryFieldsAreEmpty() Then 'Not isFishBinFoundDuplicate() And isFishBinValid() Then
                If lblFWS.Text.Trim = "" Then
                    If validateFishLot(cboLot.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            'txtRelDate.Value = getServerDateTime()
                            saveNewFishBinWithdrawals(txtRelDate.Text, "Day", cboLot.Text, _
                                txtProdnDate.Text, cboProdnShift.Text, cboRN.Text, cboPurpose.Text)

                            Dim ctr As Integer
                            With grid
                                Dim klPerBag As Double
                                Dim qtyIsNumeric As Boolean
                                While ctr < .RowCount
                                    'If CStr(.Item(ctr, 1)).StartsWith("Loin") Then
                                    '    klPerBag = 7.5
                                    'Else
                                    '    klPerBag = 8
                                    'End If

                                    Try
                                        If Not .Item(ctr, 5) = "" Then
                                            qtyIsNumeric = True
                                        Else
                                            qtyIsNumeric = False
                                        End If
                                    Catch
                                        If Not .Item(ctr, 5) Is DBNull.Value Then
                                            qtyIsNumeric = True
                                        Else
                                            qtyIsNumeric = False
                                        End If
                                    End Try

                                    If qtyIsNumeric Then
                                        If CDbl(.Item(ctr, 5)) > 0 Then
                                            saveNewFishBinWithdrawalsDetails2(lblFWS.Text, .Item(ctr, 6), .Item(ctr, 5))
                                            ' * klperbag
                                            If CDbl(.Item(ctr, 3)) = .Item(ctr, 5) Then
                                                updateFishBinWithdrawalStatus(.Item(ctr, 6), "YES")
                                            End If
                                        End If
                                    End If

                                    ctr += 1
                                End While
                            End With

                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")

                            displayAllBatchlotsDeposited(cboCS.Text)
                            displayFishLotDepositedDetails(cboCS.Text, cboLot.Text)
                            addNewRecord()
                            cboRelShift.SelectAll()
                            cboRelShift.Focus()

                        Else
                            cboRelShift.SelectAll()
                            cboRelShift.Focus()
                            Exit Sub
                        End If
                    Else
                        MsgBox("Fish lot doesn't found in the database", MsgBoxStyle.Critical, "No record found")
                        cboLot.SelectAll()
                        cboLot.Focus()
                    End If
                Else
                    reply = MsgBox("Fish Withdrawal Slip No. " & lblFWS.Text & " already stored in the database" & Chr(13) & _
                        "To update, please click YES to proceed but please make sure you have properly coordinated this matter to your supervisor", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    If reply = vbYes Then
                        showValidationMenu(True)
                    Else
                        cboRelShift.SelectAll()
                        cboRelShift.Focus()
                        Exit Sub
                    End If
                End If
            Else
                MsgBox("Kindly fill out important field(s)." & Chr(13) & _
                    "Please make sure you have not multiple entries of fish bin in the lists.", MsgBoxStyle.Critical, "Result: Found missing value.")
                cboLot.SelectAll()
                cboLot.Focus()
            End If
        Else
            MsgBox("Please make sure you have selected a fish bin for withdrawal in the fish bin details table.", MsgBoxStyle.Critical, "Result: Found missing value.")
            grid.Focus()
        End If
    End Sub

    Public Sub saveNewFishBinWithdrawals(ByVal dateTime As String, ByVal shift As String, ByVal lot As String, _
    ByVal prodnDate As String, ByVal prodnShift As String, ByVal relNo As String, ByVal purpose As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FishBinsWithdrawal"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishBinWithdrawalCounter()

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@fwsCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            If prodnShift = "Day" Then
                lblFWS.Text = Format(CDate(prodnDate), "ddMMyy") & "D" & lot & "_" & Format(getFishBinWithdrawalCounter, "0#####")
            Else
                lblFWS.Text = Format(CDate(prodnDate), "ddMMyy") & "N" & lot & "_" & Format(getFishBinWithdrawalCounter, "0#####")
            End If

            p2.Value = lblFWS.Text

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@dateReleased"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.DateTime
            txtRelDate.Value = getServerDateTime()
            dateTime = txtRelDate.Value
            p3.Value = dateTime 'Format(CDate(dateTime), getTimeFormat())

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@shift"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = shift

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

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@prodnDate"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.DateTime
            p5.Value = Format(CDate(prodnDate), getTimeFormat())

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@prodnShift"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = prodnShift

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@relNo"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.VarChar
            p7.Value = relNo

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@purpose"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.VarChar
            p8.Value = purpose

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)

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

    Public Sub showValidationMenu(ByVal showMe As Boolean)
        txtUsername.Text = ""
        txtPassword.Text = ""
        Select Case showMe
            Case True
                grp.Enabled = True
                grp.Visible = True
            Case False
                grp.Enabled = False
                grp.Visible = False
        End Select

        txtUsername.SelectAll()
        txtUsername.Focus()
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        computeTotalWeight()
    End Sub

    Public Sub displayTotalWithdrawal()
        With gridSummary
            If txtProdnDate.Text = "" Then
                .DataSource = getTotalWithdrawalOfTheDay(getServerDateTime, cboProdnShift.Text, True).Tables(0)
            Else
                .DataSource = getTotalWithdrawalOfTheDay(txtProdnDate.Value, cboProdnShift.Text, True).Tables(0)
            End If

            .Columns(1).NumberFormat = "###,###,###,##0.#0"
            .Splits(0).DisplayColumns(0).Width = 70
            '.Splits(0).DisplayColumns(0).Width = 80

            Dim ctr As Integer
            Dim klPerBag
            While ctr < .RowCount
                If CStr(.Item(ctr, 2)).StartsWith("Loin") Then
                    klPerBag = 7.5
                Else
                    klPerBag = 8
                End If

                .Item(ctr, 1) /= klPerBag

                ctr += 1
            End While
        End With
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        If Not txtProdnDate.Text = "" Then
            lblFWS.Text = ""
            displayFishLotDepositedDetails(cboCS.Text, cboLot.Text)
            displayTotalWithdrawal()
            'computeTotalWeight()
        End If
    End Sub

    Private Sub gridSummary_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles gridSummary.RowColChange
        displayTotalWithdrawal()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim f As New frmPrintFWS
        'f.bags = True
        'f.txtDate.Value = getServerDateTime()
        'f.initializeShift()

        'f.txtDate.Value = txtProdnDate.Value
        'f.cboShift.Text = cboProdnShift.Text
        'f.cboFWS.Text = lblFWS.Text
        'f.ShowDialog(Me)

        'cmdNew.Focus()
    End Sub
End Class
