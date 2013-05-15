Public Class frmFishReceipts
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
    Friend WithEvents lblLot As C1.Win.C1List.C1Combo
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents txtFR As System.Windows.Forms.TextBox
    Friend WithEvents txtDateStart As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDateEnd As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboStatus As C1.Win.C1List.C1Combo
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFishReceipts))
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
        Me.lblLot = New C1.Win.C1List.C1Combo()
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.txtFR = New System.Windows.Forms.TextBox()
        Me.txtDateStart = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateEnd = New C1.Win.C1Input.C1DateEdit()
        Me.cboStatus = New C1.Win.C1List.C1Combo()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        CType(Me.lblLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLot
        '
        Me.lblLot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lblLot.AllowColMove = False
        Me.lblLot.AutoCompletion = True
        Me.lblLot.AutoDropDown = True
        Me.lblLot.Caption = ""
        Me.lblLot.CaptionHeight = 17
        Me.lblLot.CaptionStyle = Style1
        Me.lblLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lblLot.ColumnCaptionHeight = 17
        Me.lblLot.ColumnFooterHeight = 17
        Me.lblLot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.lblLot.ContentHeight = 18
        Me.lblLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.lblLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.lblLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLot.EditorHeight = 18
        Me.lblLot.EvenRowStyle = Style2
        Me.lblLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.FooterStyle = Style3
        Me.lblLot.HeadingStyle = Style4
        Me.lblLot.HighLightRowStyle = Style5
        Me.lblLot.Images.Add(CType(resources.GetObject("lblLot.Images"), System.Drawing.Image))
        Me.lblLot.ItemHeight = 20
        Me.lblLot.Location = New System.Drawing.Point(112, 89)
        Me.lblLot.MatchEntryTimeout = CType(2000, Long)
        Me.lblLot.MaxDropDownItems = CType(10, Short)
        Me.lblLot.MaxLength = 32767
        Me.lblLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.lblLot.Name = "lblLot"
        Me.lblLot.OddRowStyle = Style6
        Me.lblLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.lblLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lblLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lblLot.SelectedStyle = Style7
        Me.lblLot.Size = New System.Drawing.Size(376, 24)
        Me.lblLot.Style = Style8
        Me.lblLot.TabIndex = 1
        Me.lblLot.PropBag = resources.GetString("lblLot.PropBag")
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
        Me.cboVessel.Location = New System.Drawing.Point(112, 58)
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
        Me.cboVessel.Size = New System.Drawing.Size(376, 24)
        Me.cboVessel.Style = Style16
        Me.cboVessel.TabIndex = 0
        Me.cboVessel.PropBag = resources.GetString("cboVessel.PropBag")
        '
        'txtFR
        '
        Me.txtFR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFR.Location = New System.Drawing.Point(112, 120)
        Me.txtFR.Name = "txtFR"
        Me.txtFR.ReadOnly = True
        Me.txtFR.Size = New System.Drawing.Size(248, 23)
        Me.txtFR.TabIndex = 5
        Me.txtFR.TabStop = False
        '
        'txtDateStart
        '
        Me.txtDateStart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateStart.Location = New System.Drawing.Point(112, 153)
        Me.txtDateStart.Name = "txtDateStart"
        Me.txtDateStart.Size = New System.Drawing.Size(200, 23)
        Me.txtDateStart.TabIndex = 2
        Me.txtDateStart.Tag = Nothing
        Me.txtDateStart.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtDateEnd
        '
        Me.txtDateEnd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateEnd.Location = New System.Drawing.Point(112, 185)
        Me.txtDateEnd.Name = "txtDateEnd"
        Me.txtDateEnd.Size = New System.Drawing.Size(200, 23)
        Me.txtDateEnd.TabIndex = 3
        Me.txtDateEnd.Tag = Nothing
        Me.txtDateEnd.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cboStatus
        '
        Me.cboStatus.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboStatus.AllowColMove = False
        Me.cboStatus.AutoCompletion = True
        Me.cboStatus.AutoDropDown = True
        Me.cboStatus.Caption = ""
        Me.cboStatus.CaptionHeight = 17
        Me.cboStatus.CaptionStyle = Style17
        Me.cboStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboStatus.ColumnCaptionHeight = 17
        Me.cboStatus.ColumnFooterHeight = 17
        Me.cboStatus.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboStatus.ContentHeight = 18
        Me.cboStatus.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboStatus.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboStatus.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStatus.EditorHeight = 18
        Me.cboStatus.EvenRowStyle = Style18
        Me.cboStatus.FooterStyle = Style19
        Me.cboStatus.HeadingStyle = Style20
        Me.cboStatus.HighLightRowStyle = Style21
        Me.cboStatus.Images.Add(CType(resources.GetObject("cboStatus.Images"), System.Drawing.Image))
        Me.cboStatus.ItemHeight = 20
        Me.cboStatus.Location = New System.Drawing.Point(567, 184)
        Me.cboStatus.MatchEntryTimeout = CType(2000, Long)
        Me.cboStatus.MaxDropDownItems = CType(5, Short)
        Me.cboStatus.MaxLength = 32767
        Me.cboStatus.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.OddRowStyle = Style22
        Me.cboStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboStatus.SelectedStyle = Style23
        Me.cboStatus.Size = New System.Drawing.Size(200, 24)
        Me.cboStatus.Style = Style24
        Me.cboStatus.TabIndex = 5
        Me.cboStatus.PropBag = resources.GetString("cboStatus.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(526, 445)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(446, 445)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 48)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(366, 445)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 8
        Me.cmd.Text = "&Save"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 238)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(864, 198)
        Me.grid.TabIndex = 6
        Me.grid.Text = "C1TrueDBGrid1"
        Me.ToolTip1.SetToolTip(Me.grid, "Double-click the record to display from the form view. ")
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(882, 40)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Fish Receipts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Trip Code *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Fishing Vessel *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Date Start *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Receipt No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(491, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Status *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Date End"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Receipt Details"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(282, 445)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 7
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(491, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Shift *"
        '
        'cboShift
        '
        Me.cboShift.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboShift.AllowColMove = False
        Me.cboShift.AutoCompletion = True
        Me.cboShift.AutoDropDown = True
        Me.cboShift.Caption = ""
        Me.cboShift.CaptionHeight = 17
        Me.cboShift.CaptionStyle = Style25
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
        Me.cboShift.EvenRowStyle = Style26
        Me.cboShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.FooterStyle = Style27
        Me.cboShift.HeadingStyle = Style28
        Me.cboShift.HighLightRowStyle = Style29
        Me.cboShift.Images.Add(CType(resources.GetObject("cboShift.Images"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(567, 152)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.OddRowStyle = Style30
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.SelectedStyle = Style31
        Me.cboShift.Size = New System.Drawing.Size(200, 24)
        Me.cboShift.Style = Style32
        Me.cboShift.TabIndex = 4
        Me.cboShift.PropBag = resources.GetString("cboShift.PropBag")
        '
        'frmFishReceipts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(882, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.txtDateEnd)
        Me.Controls.Add(Me.txtDateStart)
        Me.Controls.Add(Me.txtFR)
        Me.Controls.Add(Me.lblLot)
        Me.Controls.Add(Me.cboVessel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishReceipts"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishReceipts"
        CType(Me.lblLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFishReceipts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDateStart.Value = getServerDateTime()
        'txtDateEnd.Value = getServerDateTime()
        displayFishingVessel()
        displayFishReceipts()
        displayStatus()
        displayShift()

        'displayFR()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayFishingVessel()
        With cboVessel
            .DataSource = modModule.getFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 353

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayShift()
        With cboShift
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")

            .Splits(0).DisplayColumns(0).Width = 175
        End With
    End Sub
    Public Sub displayLot(ByVal fv As String)
        With lblLot
            .Text = ""
            .DataSource = getFishLotByFV(fv).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 353
        End With
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        displayLot(cboVessel.Text)
        lblLot.Text = getCurrentLotPerVessel(cboVessel.Text)
        'displayFR()
    End Sub

    Public Sub displayFishReceipts()
        With grid
            .DataSource = getFishReceiptsDetails().Tables(0)
            .Columns(0).NumberFormat = getTimeFormat() & " hh:mm:ss tt"
            .Columns(1).NumberFormat = getTimeFormat() & " hh:mm:ss tt"
            .Columns(4).NumberFormat = "###,###,##0"
            .Columns(5).NumberFormat = "###,###,##0.#0"

            .Splits(0).DisplayColumns(0).Width = 170
            .Splits(0).DisplayColumns(1).Width = 170
            .Splits(0).DisplayColumns(3).Width = 90
            .Splits(0).DisplayColumns(6).Width = 80
            .Splits(0).DisplayColumns(7).Width = 200

            displayQuantity()
        End With
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim reply As String
        If Not lblLot.Text.Trim = "" And Not cboStatus.Text.Trim = "" And Not txtDateStart.Text.Trim = "" And Not cboShift.Text.Trim = "" Then
            If Not validateFishReceipts(txtFR.Text) Then
                reply = MsgBox("Are you sure you want to add this new fish receipts?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    displayFR()
                    saveNewFishReceipts(txtFR.Text, lblLot.Text, txtDateStart.Text, txtDateEnd.Text, cboStatus.Text, cboShift.Text)
                    MsgBox("You have successfully added new fish receipts", MsgBoxStyle.Information, "Information")
                End If
            Else
                reply = MsgBox("Are you sure you want to update this fish receipts?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    updateFishReceipts(txtFR.Text, lblLot.Text, txtDateStart.Text, txtDateEnd.Text, cboStatus.Text, cboShift.Text)
                    MsgBox("You have successfully updated the fish receipts", MsgBoxStyle.Information, "Information")
                End If
            End If

            displayFR()
            displayFishReceipts()
            cboVessel.SelectAll()
            cboVessel.Focus()
        Else
            MsgBox("Please fill in properly the fields", MsgBoxStyle.Exclamation, "Warning")
            cboVessel.SelectAll()
            cboVessel.Focus()
        End If
    End Sub

    Public Sub displayStatus()
        With cboStatus
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .Text = ""
            .AddItemTitles("Status")
            .AddItem("Open")
            .AddItem("Closed")

            .Splits(0).DisplayColumns(0).Width = 175
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFR()
        txtFR.Text = getFRNoCounter()
    End Sub

    Private Sub lblLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLot.TextChanged
        'displayFR()
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        With grid
            If .RowCount > 0 Then
                cboVessel.Text = .Item(.Row, 7)
                lblLot.Text = .Item(.Row, 3)
                txtFR.Text = .Item(.Row, 2)
                txtDateStart.Value = .Item(.Row, 0)
                txtDateEnd.Value = .Item(.Row, 1)
                cboStatus.Text = .Item(.Row, 6)
                cboShift.Text = .Item(.Row, 8)
            End If
        End With

        displayQuantity()
    End Sub

    Public Sub displayQuantity()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                .Item(ctr, 4) = getFishReceiptSummary(.Item(ctr, 2), True)
                .Item(ctr, 5) = getFishReceiptSummary(.Item(ctr, 2), False)

                ctr += 1
            End While
        End With
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
       
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Not txtFR.Text.Trim = "" Then
            If CInt(getFishReceiptSummary(txtFR.Text, True)) = 0 Then
                Dim reply As String = MsgBox("Are you sure you want to delete this receipt number?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                If reply = vbYes Then
                    deleteFishReceipts(txtFR.Text)
                    If cboVessel.ListCount > 0 Then cboVessel.SelectedIndex = 0
                    displayFR()
                    txtDateStart.Value = getServerDateTime()
                    txtDateEnd.Value = DBNull.Value
                    cboStatus.SelectedIndex = 0
                    displayFishReceipts()
                    MsgBox("You have successfully delete the receipt number", MsgBoxStyle.Information, "Information")
                End If
            Else
                MsgBox("You can't delete a receipt if it is not empty", MsgBoxStyle.Exclamation, "Warning")
            End If
        Else
            MsgBox("Double click the record to display the details in the field boxes", MsgBoxStyle.Exclamation, "Warning")
            grid.Focus()
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        displayFR()
        displayFishReceipts()
        cboShift.Text = ""
        cboVessel.SelectAll()
        cboVessel.Focus()
    End Sub
End Class
