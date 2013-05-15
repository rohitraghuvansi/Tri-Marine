Public Class frmFGInvoice
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
    Friend WithEvents lstContainers As C1.Win.C1List.C1List
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents cboBuyer As C1.Win.C1List.C1Combo
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents cboVesselNo As C1.Win.C1List.C1Combo
    Friend WithEvents cboDestination As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFGInvoice))
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style9 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style10 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style11 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style12 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style13 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style14 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style15 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style16 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style17 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style18 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style19 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style20 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style21 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style22 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style23 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style24 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style25 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style26 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style27 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style28 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style29 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style30 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style31 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style32 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style33 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style34 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style35 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style36 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style37 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style38 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style39 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style40 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.cboBuyer = New C1.Win.C1List.C1Combo()
        Me.txtDeptDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.cboVesselNo = New C1.Win.C1List.C1Combo()
        Me.lstContainers = New C1.Win.C1List.C1List()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.cboDestination = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.cboBuyer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeptDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVesselNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstContainers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboBuyer
        '
        Me.cboBuyer.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboBuyer.AllowColMove = False
        Me.cboBuyer.AutoCompletion = True
        Me.cboBuyer.AutoDropDown = True
        Me.cboBuyer.Caption = ""
        Me.cboBuyer.CaptionHeight = 17
        Me.cboBuyer.CaptionStyle = Style1
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
        Me.cboBuyer.EvenRowStyle = Style2
        Me.cboBuyer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuyer.FooterStyle = Style3
        Me.cboBuyer.HeadingStyle = Style4
        Me.cboBuyer.HighLightRowStyle = Style5
        Me.cboBuyer.Images.Add(CType(resources.GetObject("cboBuyer.Images"), System.Drawing.Image))
        Me.cboBuyer.ItemHeight = 20
        Me.cboBuyer.Location = New System.Drawing.Point(120, 87)
        Me.cboBuyer.MatchEntryTimeout = CType(2000, Long)
        Me.cboBuyer.MaxDropDownItems = CType(10, Short)
        Me.cboBuyer.MaxLength = 32767
        Me.cboBuyer.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBuyer.Name = "cboBuyer"
        Me.cboBuyer.OddRowStyle = Style6
        Me.cboBuyer.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBuyer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBuyer.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBuyer.SelectedStyle = Style7
        Me.cboBuyer.Size = New System.Drawing.Size(488, 24)
        Me.cboBuyer.Style = Style8
        Me.cboBuyer.TabIndex = 8
        Me.cboBuyer.PropBag = resources.GetString("cboBuyer.PropBag")
        '
        'txtDeptDate
        '
        Me.txtDeptDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeptDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDeptDate.Location = New System.Drawing.Point(120, 120)
        Me.txtDeptDate.Name = "txtDeptDate"
        Me.txtDeptDate.Size = New System.Drawing.Size(229, 23)
        Me.txtDeptDate.TabIndex = 10
        Me.txtDeptDate.Tag = Nothing
        Me.txtDeptDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboVessel
        '
        Me.cboVessel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboVessel.AllowColMove = False
        Me.cboVessel.AutoCompletion = True
        Me.cboVessel.AutoDropDown = True
        Me.cboVessel.Caption = ""
        Me.cboVessel.CaptionHeight = 17
        Me.cboVessel.CaptionStyle = Style9
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
        Me.cboVessel.EvenRowStyle = Style10
        Me.cboVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.FooterStyle = Style11
        Me.cboVessel.HeadingStyle = Style12
        Me.cboVessel.HighLightRowStyle = Style13
        Me.cboVessel.Images.Add(CType(resources.GetObject("cboVessel.Images"), System.Drawing.Image))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(120, 151)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(10, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.OddRowStyle = Style14
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.SelectedStyle = Style15
        Me.cboVessel.Size = New System.Drawing.Size(229, 24)
        Me.cboVessel.Style = Style16
        Me.cboVessel.TabIndex = 11
        Me.cboVessel.PropBag = resources.GetString("cboVessel.PropBag")
        '
        'cboVesselNo
        '
        Me.cboVesselNo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboVesselNo.AllowColMove = False
        Me.cboVesselNo.AutoCompletion = True
        Me.cboVesselNo.AutoDropDown = True
        Me.cboVesselNo.Caption = ""
        Me.cboVesselNo.CaptionHeight = 17
        Me.cboVesselNo.CaptionStyle = Style17
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
        Me.cboVesselNo.EvenRowStyle = Style18
        Me.cboVesselNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVesselNo.FooterStyle = Style19
        Me.cboVesselNo.HeadingStyle = Style20
        Me.cboVesselNo.HighLightRowStyle = Style21
        Me.cboVesselNo.Images.Add(CType(resources.GetObject("cboVesselNo.Images"), System.Drawing.Image))
        Me.cboVesselNo.ItemHeight = 20
        Me.cboVesselNo.Location = New System.Drawing.Point(120, 184)
        Me.cboVesselNo.MatchEntryTimeout = CType(2000, Long)
        Me.cboVesselNo.MaxDropDownItems = CType(10, Short)
        Me.cboVesselNo.MaxLength = 32767
        Me.cboVesselNo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVesselNo.Name = "cboVesselNo"
        Me.cboVesselNo.OddRowStyle = Style22
        Me.cboVesselNo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVesselNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVesselNo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVesselNo.SelectedStyle = Style23
        Me.cboVesselNo.Size = New System.Drawing.Size(229, 24)
        Me.cboVesselNo.Style = Style24
        Me.cboVesselNo.TabIndex = 12
        Me.cboVesselNo.PropBag = resources.GetString("cboVesselNo.PropBag")
        '
        'lstContainers
        '
        Me.lstContainers.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstContainers.AllowColMove = False
        Me.lstContainers.Caption = ""
        Me.lstContainers.CaptionHeight = 17
        Me.lstContainers.CaptionStyle = Style25
        Me.lstContainers.ColumnCaptionHeight = 17
        Me.lstContainers.ColumnFooterHeight = 17
        Me.lstContainers.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.lstContainers.EvenRowStyle = Style26
        Me.lstContainers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstContainers.FooterStyle = Style27
        Me.lstContainers.HeadingStyle = Style28
        Me.lstContainers.HighLightRowStyle = Style29
        Me.lstContainers.Images.Add(CType(resources.GetObject("lstContainers.Images"), System.Drawing.Image))
        Me.lstContainers.ItemHeight = 20
        Me.lstContainers.Location = New System.Drawing.Point(16, 265)
        Me.lstContainers.MatchEntryTimeout = CType(2000, Long)
        Me.lstContainers.Name = "lstContainers"
        Me.lstContainers.OddRowStyle = Style30
        Me.lstContainers.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.lstContainers.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstContainers.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstContainers.SelectedStyle = Style31
        Me.lstContainers.Size = New System.Drawing.Size(594, 177)
        Me.lstContainers.Style = Style32
        Me.lstContainers.TabIndex = 86
        Me.lstContainers.Text = "C1List1"
        Me.lstContainers.PropBag = resources.GetString("lstContainers.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(432, 447)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 91
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(352, 447)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 90
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(272, 447)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 89
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(192, 447)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 88
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(112, 447)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 87
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Invoice No."
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(14, 244)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(136, 16)
        Me.lbl.TabIndex = 97
        Me.lbl.Text = "Lists of Container Nos."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Vessel No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Vessel"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Buyer"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(618, 40)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Commercial Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Departure Date"
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(120, 56)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(229, 24)
        Me.lblCode.TabIndex = 99
        '
        'cboDestination
        '
        Me.cboDestination.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboDestination.AllowColMove = False
        Me.cboDestination.AutoCompletion = True
        Me.cboDestination.AutoDropDown = True
        Me.cboDestination.Caption = ""
        Me.cboDestination.CaptionHeight = 17
        Me.cboDestination.CaptionStyle = Style33
        Me.cboDestination.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDestination.ColumnCaptionHeight = 17
        Me.cboDestination.ColumnFooterHeight = 17
        Me.cboDestination.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboDestination.ContentHeight = 18
        Me.cboDestination.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboDestination.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboDestination.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestination.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDestination.EditorHeight = 18
        Me.cboDestination.EvenRowStyle = Style34
        Me.cboDestination.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestination.FooterStyle = Style35
        Me.cboDestination.HeadingStyle = Style36
        Me.cboDestination.HighLightRowStyle = Style37
        Me.cboDestination.Images.Add(CType(resources.GetObject("cboDestination.Images"), System.Drawing.Image))
        Me.cboDestination.ItemHeight = 20
        Me.cboDestination.Location = New System.Drawing.Point(120, 214)
        Me.cboDestination.MatchEntryTimeout = CType(2000, Long)
        Me.cboDestination.MaxDropDownItems = CType(10, Short)
        Me.cboDestination.MaxLength = 32767
        Me.cboDestination.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.OddRowStyle = Style38
        Me.cboDestination.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDestination.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboDestination.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDestination.SelectedStyle = Style39
        Me.cboDestination.Size = New System.Drawing.Size(229, 24)
        Me.cboDestination.Style = Style40
        Me.cboDestination.TabIndex = 100
        Me.cboDestination.PropBag = resources.GetString("cboDestination.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Destination"
        '
        'frmFGInvoice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboDestination)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.lstContainers)
        Me.Controls.Add(Me.cboVesselNo)
        Me.Controls.Add(Me.cboVessel)
        Me.Controls.Add(Me.txtDeptDate)
        Me.Controls.Add(Me.cboBuyer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFGInvoice"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFGInvoice"
        CType(Me.cboBuyer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeptDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVesselNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstContainers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFGInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDeptDate.Value = getServerDateTime()
        enableDataEntry(False)

        displayBuyers()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayVessel(ByVal departureDate As String, Optional ByVal vessel As String = "")


      
        'If vessel = "" Then
       
        'Else
        
        'End If
    End Sub

    Private Sub txtDeptDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeptDate.ValueChanged
        'displayVessel(txtDeptDate.Text)
        cboVessel.Text = ""
        cboVessel.DefColWidth = 205
        cboVessel.DataSource = getShipmentDetails_Vessel(txtDeptDate.Text, "1").Tables(0)
        If cboVessel.ListCount > 0 Then cboVessel.SelectedIndex = 0

        'If Not txtDeptDate.Text.Trim = "" Then
        '    displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text)
        '    displayInvoiceNo()
        'End If
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        'displayVessel(txtDeptDate.Text, cboVessel.Text)
        cboVesselNo.Text = ""
        cboVesselNo.DefColWidth = 205
        cboVesselNo.DataSource = getShipmentDetails_Vessel(txtDeptDate.Text, "2", cboVessel.Text).Tables(0)
        If cboVesselNo.ListCount > 0 Then cboVesselNo.SelectedIndex = 0
    End Sub

    Public Sub displayBuyers()
        With cboBuyer
            .DataSource = getAllBuyer().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 465
        End With
    End Sub

    Public Sub displayShipmentContainers(ByVal deptDate As String, ByVal vesselNo As String, ByVal destination As String)
        With lstContainers
            .DataSource = getShipmentContainers(deptDate, vesselNo, destination).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 280
            .Splits(0).DisplayColumns(1).Width = 280
        End With

        lbl.Text = "Lists of " & lstContainers.ListCount & " Containers Number"
    End Sub

    Public Sub enableDataEntry(ByVal enable As Boolean)
        Select Case enable
            Case True
                cboBuyer.ReadOnly = False
                txtDeptDate.ReadOnly = False
                cboVessel.ReadOnly = False
                cboVesselNo.ReadOnly = False
                cboDestination.ReadOnly = False
                lstContainers.Enabled = True
            Case False
                cboBuyer.ReadOnly = True
                txtDeptDate.ReadOnly = True
                cboVessel.ReadOnly = True
                cboVesselNo.ReadOnly = True
                cboDestination.ReadOnly = True
                lstContainers.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        displayBuyers()
        cboBuyer.Text = ""
        txtDeptDate.ReadOnly = False
        cboVessel.ReadOnly = False
        cboVesselNo.ReadOnly = False
        txtDeptDate.Value = getServerDateTime()
        cboVessel.Text = ""
        cboVesselNo.Text = ""
        cboDestination.Text = ""
    End Sub

    Public Sub buttons(ByVal enable As Boolean)
        Select Case enable
            Case False
                Me.cmdPrint.Enabled = False
                Me.cmdFind.Enabled = False
                Me.cmdClose.Enabled = False
            Case True
                Me.cmdPrint.Enabled = True
                Me.cmdFind.Enabled = True
                Me.cmdClose.Enabled = True
        End Select
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                buttons(False)
                enableDataEntry(True)
                addNewRecord()
                cboBuyer.SelectAll()
                cboBuyer.Focus()
            Case "&Save"
                displayInvoiceNo()

                If Not cboBuyer.Text.Trim = "" And Not Me.cboVessel.Text.Trim = "" And _
                Not cboVesselNo.Text.Trim = "" And lstContainers.ListCount > 0 Then
                    If Not validateInvoice(lblCode.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewFGInvoice(lblCode.Text, cboBuyer.Text, txtDeptDate.Text, cboVesselNo.Text)
                            saveNewFGInvoiceDetails(lblCode.Text, getFGShipmentCode(txtDeptDate.Text, cboVessel.Text, cboVesselNo.Text, cboDestination.Text))

                            Dim ctr As Integer
                            With lstContainers
                                While ctr < .ListCount
                                    updateContainerShipmentStatus(.GetItemText(ctr, 0), _
                                        .GetItemText(ctr, 1), "Y")

                                    ctr += 1
                                End While
                            End With

                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(True)
                            enableDataEntry(False)

                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Invoice Number already exists in the database.  Please check the data", MsgBoxStyle.Exclamation, "Warning")
                        cboBuyer.SelectAll()
                        cboBuyer.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboBuyer.SelectAll()
                    cboBuyer.Focus()
                End If
            Case "&Save "
                If lstContainers.ListCount > 0 Then
                    If validateInvoice(lblCode.Text) Then
                        reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            updateFGInvoice(lblCode.Text, cboBuyer.Text)

                            deleteFGInvoiceDetails(lblCode.Text)
                            saveNewFGInvoiceDetails(lblCode.Text, getFGShipmentCode(txtDeptDate.Text, cboVessel.Text, cboVesselNo.Text, cboDestination.Text))

                            Dim ctr As Integer
                            With lstContainers
                                While ctr < .ListCount
                                    updateContainerShipmentStatus(.GetItemText(ctr, 0), _
                                        .GetItemText(ctr, 1), "Y")

                                    ctr += 1
                                End While
                            End With

                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(True)
                            enableDataEntry(False)

                            MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Invoice Number doesn't exists", MsgBoxStyle.Exclamation, "Warning")
                        cmdEdit.Focus()
                    End If
                Else
                    MsgBox("Please identify the Lists of Containers", MsgBoxStyle.Exclamation, "Warning")
                    cmdEdit.Focus()
                End If
        End Select
    End Sub

    Public Sub displayInvoiceNo()
        Dim code As String
        If lstContainers.ListCount > 0 Then
            If getFGShipmentProduct(lstContainers.GetItemText(0, 0), lstContainers.GetItemText(0, 1)).IndexOf("Loin") > 0 Then
                code = "LOIN"
            Else
                code = "CAN"
            End If
        Else
            code = "LOIN"
        End If

        If cboBuyer.Text = "" Then
            lblCode.Text = ""
        Else
            lblCode.Text = code & Format(CDate(txtDeptDate.Text), "MMyy") & _
                Format(getFGInvoiceNoSeries(code & Format(CDate(txtDeptDate.Text), "MMyy") & "%"), "0#") & "-" & _
                getFGShipmentDestination(txtDeptDate.Text, cboVessel.Text).ToUpper
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not Me.lblCode.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(False)
                    enableDataEntry(True)
                    txtDeptDate.ReadOnly = True
                    cboVessel.ReadOnly = True
                    cboVesselNo.ReadOnly = True
                    cboBuyer.SelectAll()
                    cboBuyer.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboBuyer.SelectAll()
                    cboBuyer.Focus()
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(True)
                enableDataEntry(False)
                cmdEdit.Focus()
        End Select
    End Sub

    Private Sub cboBuyer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuyer.TextChanged
        displayInvoiceNo()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim f As New frmPrintCommercialInvoice
        f.displayReport(lblCode.Text)
        f.ShowDialog(Me)
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Commercial Invoices"
        f.searchType = 1
        f.displayAllFGInvoice()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 0)
                cboBuyer.Text = .Item(.Row, 2)
                txtDeptDate.Value = .Item(.Row, 7)
                cboVessel.Text = .Item(.Row, 5)
                cboVesselNo.Text = .Item(.Row, 6)
                cboDestination.Text = .Item(.Row, 9)
                lblCode.Text = .Item(.Row, 0)
            End If
        End With
    End Sub

    Private Sub cboVesselNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVesselNo.TextChanged
        If Not txtDeptDate.Text.Trim = "" Then
            cboDestination.Text = ""
            cboDestination.DefColWidth = 205
            cboDestination.DataSource = getShipmentDetails_Vessel(txtDeptDate.Text, "3", cboVessel.Text).Tables(0)

        End If
    End Sub

    Private Sub cboDestination_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestination.TextChanged
        displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboDestination.Text)
        'displayInvoiceNo()
    End Sub
End Class
