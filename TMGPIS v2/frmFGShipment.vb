Public Class frmFGShipment
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
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboVesselNo As C1.Win.C1List.C1Combo
    Friend WithEvents txtDeptDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboBOL As C1.Win.C1List.C1Combo
    Friend WithEvents cboDestination As C1.Win.C1List.C1Combo
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents gridContainer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFGShipment))
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
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.cboVesselNo = New C1.Win.C1List.C1Combo()
        Me.txtDeptDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboBOL = New C1.Win.C1List.C1Combo()
        Me.cboDestination = New C1.Win.C1List.C1Combo()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gridContainer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.lblId = New System.Windows.Forms.Label()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVesselNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeptDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBOL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestination, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboVessel
        '
        Me.cboVessel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboVessel.AllowColMove = False
        Me.cboVessel.AutoCompletion = True
        Me.cboVessel.AutoDropDown = True
        Me.cboVessel.Caption = ""
        Me.cboVessel.CaptionHeight = 17
        Me.cboVessel.CaptionStyle = Style1
        Me.cboVessel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVessel.ColumnCaptionHeight = 17
        Me.cboVessel.ColumnFooterHeight = 17
        Me.cboVessel.ContentHeight = 18
        Me.cboVessel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVessel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVessel.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVessel.EditorHeight = 18
        Me.cboVessel.EvenRowStyle = Style2
        Me.cboVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.FooterStyle = Style3
        Me.cboVessel.HeadingStyle = Style4
        Me.cboVessel.HighLightRowStyle = Style5
        Me.cboVessel.Images.Add(CType(resources.GetObject("cboVessel.Images"), System.Drawing.Image))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(112, 88)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(10, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.OddRowStyle = Style6
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.SelectedStyle = Style7
        Me.cboVessel.Size = New System.Drawing.Size(229, 24)
        Me.cboVessel.Style = Style8
        Me.cboVessel.TabIndex = 7
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
        Me.cboVesselNo.CaptionStyle = Style9
        Me.cboVesselNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVesselNo.ColumnCaptionHeight = 17
        Me.cboVesselNo.ColumnFooterHeight = 17
        Me.cboVesselNo.ContentHeight = 18
        Me.cboVesselNo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVesselNo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVesselNo.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVesselNo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVesselNo.EditorHeight = 18
        Me.cboVesselNo.EvenRowStyle = Style10
        Me.cboVesselNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVesselNo.FooterStyle = Style11
        Me.cboVesselNo.HeadingStyle = Style12
        Me.cboVesselNo.HighLightRowStyle = Style13
        Me.cboVesselNo.Images.Add(CType(resources.GetObject("cboVesselNo.Images"), System.Drawing.Image))
        Me.cboVesselNo.ItemHeight = 20
        Me.cboVesselNo.Location = New System.Drawing.Point(112, 120)
        Me.cboVesselNo.MatchEntryTimeout = CType(2000, Long)
        Me.cboVesselNo.MaxDropDownItems = CType(10, Short)
        Me.cboVesselNo.MaxLength = 32767
        Me.cboVesselNo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVesselNo.Name = "cboVesselNo"
        Me.cboVesselNo.OddRowStyle = Style14
        Me.cboVesselNo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVesselNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVesselNo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVesselNo.SelectedStyle = Style15
        Me.cboVesselNo.Size = New System.Drawing.Size(229, 24)
        Me.cboVesselNo.Style = Style16
        Me.cboVesselNo.TabIndex = 8
        Me.cboVesselNo.PropBag = resources.GetString("cboVesselNo.PropBag")
        '
        'txtDeptDate
        '
        Me.txtDeptDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeptDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDeptDate.Location = New System.Drawing.Point(112, 153)
        Me.txtDeptDate.Name = "txtDeptDate"
        Me.txtDeptDate.Size = New System.Drawing.Size(229, 23)
        Me.txtDeptDate.TabIndex = 9
        Me.txtDeptDate.Tag = Nothing
        Me.txtDeptDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboBOL
        '
        Me.cboBOL.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboBOL.AllowColMove = False
        Me.cboBOL.AutoCompletion = True
        Me.cboBOL.AutoDropDown = True
        Me.cboBOL.Caption = ""
        Me.cboBOL.CaptionHeight = 17
        Me.cboBOL.CaptionStyle = Style17
        Me.cboBOL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBOL.ColumnCaptionHeight = 17
        Me.cboBOL.ColumnFooterHeight = 17
        Me.cboBOL.ContentHeight = 18
        Me.cboBOL.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBOL.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBOL.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBOL.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBOL.EditorHeight = 18
        Me.cboBOL.EvenRowStyle = Style18
        Me.cboBOL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBOL.FooterStyle = Style19
        Me.cboBOL.HeadingStyle = Style20
        Me.cboBOL.HighLightRowStyle = Style21
        Me.cboBOL.Images.Add(CType(resources.GetObject("cboBOL.Images"), System.Drawing.Image))
        Me.cboBOL.ItemHeight = 20
        Me.cboBOL.Location = New System.Drawing.Point(112, 184)
        Me.cboBOL.MatchEntryTimeout = CType(2000, Long)
        Me.cboBOL.MaxDropDownItems = CType(10, Short)
        Me.cboBOL.MaxLength = 32767
        Me.cboBOL.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBOL.Name = "cboBOL"
        Me.cboBOL.OddRowStyle = Style22
        Me.cboBOL.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBOL.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBOL.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBOL.SelectedStyle = Style23
        Me.cboBOL.Size = New System.Drawing.Size(229, 24)
        Me.cboBOL.Style = Style24
        Me.cboBOL.TabIndex = 10
        Me.cboBOL.PropBag = resources.GetString("cboBOL.PropBag")
        '
        'cboDestination
        '
        Me.cboDestination.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboDestination.AllowColMove = False
        Me.cboDestination.AutoCompletion = True
        Me.cboDestination.AutoDropDown = True
        Me.cboDestination.Caption = ""
        Me.cboDestination.CaptionHeight = 17
        Me.cboDestination.CaptionStyle = Style25
        Me.cboDestination.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDestination.ColumnCaptionHeight = 17
        Me.cboDestination.ColumnFooterHeight = 17
        Me.cboDestination.ContentHeight = 18
        Me.cboDestination.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboDestination.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboDestination.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestination.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDestination.EditorHeight = 18
        Me.cboDestination.EvenRowStyle = Style26
        Me.cboDestination.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestination.FooterStyle = Style27
        Me.cboDestination.HeadingStyle = Style28
        Me.cboDestination.HighLightRowStyle = Style29
        Me.cboDestination.Images.Add(CType(resources.GetObject("cboDestination.Images"), System.Drawing.Image))
        Me.cboDestination.ItemHeight = 20
        Me.cboDestination.Location = New System.Drawing.Point(112, 216)
        Me.cboDestination.MatchEntryTimeout = CType(2000, Long)
        Me.cboDestination.MaxDropDownItems = CType(10, Short)
        Me.cboDestination.MaxLength = 32767
        Me.cboDestination.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.OddRowStyle = Style30
        Me.cboDestination.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDestination.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboDestination.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDestination.SelectedStyle = Style31
        Me.cboDestination.Size = New System.Drawing.Size(229, 24)
        Me.cboDestination.Style = Style32
        Me.cboDestination.TabIndex = 11
        Me.cboDestination.PropBag = resources.GetString("cboDestination.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(266, 256)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 41
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(185, 256)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 39
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(105, 256)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 38
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(25, 256)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 37
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Bill of Lading"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Departure Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Vessel Name"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(778, 40)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "FG Shipments"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Vessel No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Destination"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Shipment Code"
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(112, 56)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(229, 24)
        Me.lblCode.TabIndex = 83
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 16)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Lists of For Shipment Freezer Containers"
        '
        'gridContainer
        '
        Me.gridContainer.AllowColMove = False
        Me.gridContainer.CaptionHeight = 17
        Me.gridContainer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridContainer.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridContainer.Images.Add(CType(resources.GetObject("gridContainer.Images"), System.Drawing.Image))
        Me.gridContainer.Location = New System.Drawing.Point(403, 78)
        Me.gridContainer.Name = "gridContainer"
        Me.gridContainer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridContainer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridContainer.PreviewInfo.ZoomFactor = 75.0R
        Me.gridContainer.PrintInfo.PageSettings = CType(resources.GetObject("gridContainer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridContainer.RowHeight = 20
        Me.gridContainer.Size = New System.Drawing.Size(369, 342)
        Me.gridContainer.TabIndex = 85
        Me.gridContainer.Text = "C1TrueDBGrid1"
        Me.gridContainer.PropBag = resources.GetString("gridContainer.PropBag")
        '
        'lblId
        '
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(112, 317)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(229, 24)
        Me.lblId.TabIndex = 86
        Me.lblId.Visible = False
        '
        'frmFGShipment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(778, 427)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.gridContainer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboDestination)
        Me.Controls.Add(Me.cboBOL)
        Me.Controls.Add(Me.txtDeptDate)
        Me.Controls.Add(Me.cboVesselNo)
        Me.Controls.Add(Me.cboVessel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFGShipment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFGShipment"
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVesselNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeptDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBOL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestination, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFGShipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDeptDate.Value = getServerDateTime()
        enableDataEntry(False)

        'displayContainers()
        displayShipmentDetails(0)
        displayShipmentDetails(1)
        displayShipmentDetails(2)

        displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboBOL.Text, cboDestination.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Public Sub displayContainers()
    '    With lstContainers
    '        .DataSource = getContainerVanStatus("N").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 155
    '        .Splits(0).DisplayColumns(1).Width = 155
    '    End With
    'End Sub

    Public Sub displayShipmentContainers(ByVal deptdate As String, ByVal vesselNo As String, ByVal bol As String, ByVal destination As String)
        With gridContainer 'lstContainers
            .DataSource = getShipmentContainers(deptdate, vesselNo, bol, destination).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 50
            .Splits(0).DisplayColumns(1).Width = 140
            .Splits(0).DisplayColumns(2).Width = 140

            .Columns(0).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            .Splits(0).DisplayColumns(0).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            .Splits(0).DisplayColumns(1).Locked = True
            .Splits(0).DisplayColumns(2).Locked = True

            .FetchRowStyles = True
            'Dim ctr As Integer
            'With gridContainer 'lstContainers
            '    While ctr < .ListCount
            '        .SelectedIndex = ctr

            '        ctr += 1
            '    End While
            'End With

            'If .ListCount < 1 Then
            '    displayContainers()
            'End If
        End With
    End Sub

    Public Sub enableDataEntry(ByVal enable As Boolean)
        Select Case enable
            Case True
                cboVessel.ReadOnly = False
                cboVesselNo.ReadOnly = False
                txtDeptDate.ReadOnly = False
                cboBOL.ReadOnly = False
                cboDestination.ReadOnly = False
                'lstContainers.Enabled = True
                gridContainer.Enabled = True
            Case False
                cboVessel.ReadOnly = True
                cboVesselNo.ReadOnly = True
                txtDeptDate.ReadOnly = True
                cboBOL.ReadOnly = True
                cboDestination.ReadOnly = True
                'lstContainers.Enabled = False
                gridContainer.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        lblId.Text = ""
        lblCode.Text = ""
        cboVessel.ReadOnly = False
        cboVesselNo.ReadOnly = False
        txtDeptDate.ReadOnly = False
        displayShipmentDetails(0)
        cboVessel.Text = ""
        displayShipmentDetails(1)
        cboVesselNo.Text = ""
        txtDeptDate.Value = getServerDateTime()
        cboBOL.Text = ""
        displayShipmentDetails(2)
        cboDestination.Text = ""

        'displayContainers()
        displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboBOL.Text, cboDestination.Text)
    End Sub

    Public Sub buttons(ByVal enable As Boolean)
        Select Case enable
            Case False
                Me.cmdFind.Enabled = False
                Me.cmdClose.Enabled = False
            Case True
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
                cboVessel.SelectAll()
                cboVessel.Focus()
            Case "&Save"
                displayShipmentCode()

                If Not cboVessel.Text.Trim = "" And Not Me.cboVesselNo.Text.Trim = "" And _
                Not cboBOL.Text.Trim = "" And Not cboDestination.Text.Trim = "" Then
                    'And lstContainers.SelectedIndices.Count > 0
                    If Not validateShipments(cboVessel.Text, cboVesselNo.Text, txtDeptDate.Text, cboBOL.Text, cboDestination.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewRecord(cboVessel.Text, cboVesselNo.Text, txtDeptDate.Text, cboBOL.Text, cboDestination.Text)

                            Dim ctr As Integer
                            'With lstContainers
                            '    While ctr < .SelectedIndices.Count
                            '        saveNewFG_ShipmentDetails(lblCode.Text, .GetItemText(.SelectedIndices.Item(ctr), 0), _
                            '            .GetItemText(.SelectedIndices.Item(ctr), 1))

                            '        updateContainerStatus(.GetItemText(.SelectedIndices.Item(ctr), 0), _
                            '            .GetItemText(.SelectedIndices.Item(ctr), 1), "Y")

                            '        ctr += 1
                            '    End While
                            'End With
                            With gridContainer
                                While ctr < .RowCount
                                    If .Item(ctr, 0) = True Then
                                        saveNewFG_ShipmentDetails(lblCode.Text, .Item(ctr, 1), .Item(ctr, 2))

                                        updateContainerStatus(.Item(ctr, 1), .Item(ctr, 2), "Y")
                                    End If

                                    ctr += 1
                                End While
                            End With

                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(True)
                            enableDataEntry(False)

                            'displayContainers()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            updateFGShipment(lblCode.Text, cboBOL.Text, cboDestination.Text, cboVessel.Text, cboVesselNo.Text, txtDeptDate.Text, lblId.Text)

                            deleteFGShipmentContainers(lblCode.Text)

                            Dim ctr As Integer
                            'With lstContainers
                            '    While ctr < .SelectedIndices.Count
                            '        saveNewFG_ShipmentDetails(lblCode.Text, .GetItemText(.SelectedIndices.Item(ctr), 0), _
                            '            .GetItemText(.SelectedIndices.Item(ctr), 1))

                            '        updateContainerStatus(.GetItemText(.SelectedIndices.Item(ctr), 0), _
                            '            .GetItemText(.SelectedIndices.Item(ctr), 1), "Y")

                            '        ctr += 1
                            '    End While
                            'End With

                            With gridContainer
                                While ctr < .RowCount
                                    updateContainerStatus(.Item(ctr, 1), .Item(ctr, 2), "N")

                                    ctr += 1
                                End While
                            End With

                            ctr = 0
                            With gridContainer
                                While ctr < .RowCount
                                    If .Item(ctr, 0) = True Then
                                        saveNewFG_ShipmentDetails(lblCode.Text, .Item(ctr, 1), .Item(ctr, 2))

                                        updateContainerStatus(.Item(ctr, 1), .Item(ctr, 2), "Y")
                                    End If

                                    ctr += 1
                                End While
                            End With

                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(True)
                            enableDataEntry(False)

                            'displayContainers()
                            'displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboBOL.Text)
                            MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboVessel.SelectAll()
                    cboVessel.Focus()
                End If
            Case "&Save "
                'If validateShipments(cboVessel.Text, cboVesselNo.Text, txtDeptDate.Text, cboBOL.Text, cboDestination.Text) Then
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFGShipment(lblCode.Text, cboBOL.Text, cboDestination.Text, cboVessel.Text, cboVesselNo.Text, txtDeptDate.Text, lblId.Text)

                    deleteFGShipmentContainers(lblCode.Text)

                    Dim ctr As Integer
                    'With lstContainers
                    '    While ctr < .SelectedIndices.Count
                    '        saveNewFG_ShipmentDetails(lblCode.Text, .GetItemText(.SelectedIndices.Item(ctr), 0), _
                    '            .GetItemText(.SelectedIndices.Item(ctr), 1))

                    '        updateContainerStatus(.GetItemText(.SelectedIndices.Item(ctr), 0), _
                    '            .GetItemText(.SelectedIndices.Item(ctr), 1), "Y")

                    '        ctr += 1
                    '    End While
                    'End With

                    With gridContainer
                        While ctr < .RowCount
                            updateContainerStatus(.Item(ctr, 1), .Item(ctr, 2), "N")

                            ctr += 1
                        End While
                    End With

                    ctr = 0
                    With gridContainer
                        While ctr < .RowCount
                            If .Item(ctr, 0) = True Then
                                saveNewFG_ShipmentDetails(lblCode.Text, .Item(ctr, 1), .Item(ctr, 2))

                                updateContainerStatus(.Item(ctr, 1), .Item(ctr, 2), "Y")
                            End If

                            ctr += 1
                        End While
                    End With

                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(True)
                    enableDataEntry(False)

                    'displayContainers()
                    'displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboBOL.Text)
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
                'Else
                'MsgBox("Shipment details doesn't exists", MsgBoxStyle.Exclamation, "Warning")
                'cmdEdit.Focus()
                'End If
        End Select
    End Sub

    Public Sub saveNewRecord(ByVal vessel As String, ByVal vesselNo As String, ByVal departureDate As String, _
    ByVal bol As String, ByVal destination As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addnew_FGShipment"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@shipmentCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            lblCode.Text = Format(CDate(departureDate), "ddMMyy-") & bol
            p2.Value = lblCode.Text

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@vesselName"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = vessel

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@vesselNo"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = vesselNo

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@departDate"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.DateTime
            If departureDate = "" Then
                p5.Value = Format(getServerDateTime, getTimeFormat())
            Else
                p5.Value = Format(CDate(departureDate), getTimeFormat())
            End If

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@BOL"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = bol

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@destination"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.VarChar
            p7.Value = destination

            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)

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
                If Not Me.lblCode.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(False)
                    enableDataEntry(True)
                    'cboVessel.ReadOnly = True
                    'cboVesselNo.ReadOnly = True
                    'txtDeptDate.ReadOnly = True
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
                buttons(True)
                enableDataEntry(False)
                cmdEdit.Focus()
        End Select
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search FG Shipments"
        f.searchType = 1
        f.displayAllFGShipments()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 5)
                cboVessel.Text = .Item(.Row, 1)
                cboVesselNo.Text = .Item(.Row, 2)
                txtDeptDate.Value = .Item(.Row, 0)
                cboBOL.Text = .Item(.Row, 3)
                cboDestination.Text = .Item(.Row, 4)
                lblId.Text = .Item(.Row, 6)

                'displayContainers()
                displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboBOL.Text, cboDestination.Text)
            End If
        End With
    End Sub

    Public Sub displayShipmentCode()
        If cboVessel.Text.Trim = "" Or cboBOL.Text.Trim = "" Then
            lblCode.Text = ""
        Else
            lblCode.Text = Format(CDate(txtDeptDate.Text), "ddMMyy-") & cboBOL.Text
        End If
    End Sub

    Private Sub txtDeptDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeptDate.ValueChanged
        'displayShipmentCode()
        'displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboBOL.Text, cboDestination.Text)
    End Sub

    Public Sub displayShipmentDetails(ByVal category As Integer)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim qry As String
            Select Case category
                Case 0      ' Vessel Name
                    qry = "SELECT DISTINCT vesselName AS [Vessel Name] " & _
                        " FROM dbo.tblFG_Shipments " & _
                        " ORDER BY [Vessel Name]"
                Case 1      'Vessel No
                    qry = "SELECT DISTINCT vesselNo AS [Vessel No.] " & _
                        " FROM dbo.tblFG_Shipments " & _
                        " ORDER BY [Vessel No.]"
                Case 2      'Destination
                    qry = "SELECT DISTINCT destination AS Destination " & _
                        " FROM dbo.tblFG_Shipments " & _
                        " ORDER BY Destination"
            End Select

            Dim cmd As New SqlClient.SqlCommand(qry, c)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            Select Case category
                Case 0      ' Vessel Name
                    cboVessel.DefColWidth = 205
                    cboVessel.DataSource = ds.Tables(0)
                Case 1      'Vessel No
                    cboVesselNo.DefColWidth = 205
                    cboVesselNo.DataSource = ds.Tables(0)
                Case 2      'Destination
                    cboDestination.DefColWidth = 205
                    cboDestination.DataSource = ds.Tables(0)
            End Select

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboBOL_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBOL.TextChanged
        'displayShipmentCode()
        'displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboBOL.Text, cboDestination.Text)
    End Sub

    Private Sub cboVesselNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVesselNo.TextChanged
        'displayShipmentContainers(txtDeptDate.Text, cboVesselNo.Text, cboBOL.Text, cboDestination.Text)
    End Sub

    Private Sub gridContainer_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles gridContainer.FetchRowStyle
        If gridContainer.Columns(0).CellValue(e.Row) = True Then
            'gridPallet.Splits(0).DisplayColumns(4).Locked = False
            'gridPallet.Splits(0).DisplayColumns(4).Style.BackColor = Color.White
            e.CellStyle.ForeColor = System.Drawing.Color.White
            e.CellStyle.BackColor = System.Drawing.Color.Red
        Else
            e.CellStyle.ForeColor = System.Drawing.Color.Black
            e.CellStyle.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged

    End Sub

    Private Sub cboDestination_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestination.TextChanged

    End Sub
End Class
