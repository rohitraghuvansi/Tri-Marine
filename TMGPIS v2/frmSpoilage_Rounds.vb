Public Class frmSpoilage_Rounds
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
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboLane As C1.Win.C1List.C1Combo
    Friend WithEvents cboRow As C1.Win.C1List.C1Combo
    Friend WithEvents cboStack As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboBin As C1.Win.C1List.C1Combo
    Friend WithEvents lblTare As System.Windows.Forms.Label
    Friend WithEvents lblNW As System.Windows.Forms.Label
    Friend WithEvents txtGW As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboOwner As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents lblDepCode As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Style49 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style50 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style51 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style52 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style53 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpoilage_Rounds))
        Dim Style54 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style55 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style56 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style57 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style58 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style59 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style60 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style61 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style62 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style63 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style64 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style65 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style66 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style67 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style68 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style69 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style70 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style71 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style72 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style73 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style74 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style75 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style76 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style77 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style78 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style79 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style80 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style81 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style82 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style83 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style84 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style85 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style86 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style87 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style88 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style89 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style90 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style91 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style92 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style93 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style94 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style95 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style96 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.cboCS = New C1.Win.C1List.C1Combo()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboLane = New C1.Win.C1List.C1Combo()
        Me.cboRow = New C1.Win.C1List.C1Combo()
        Me.cboStack = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboBin = New C1.Win.C1List.C1Combo()
        Me.lblTare = New System.Windows.Forms.Label()
        Me.lblNW = New System.Windows.Forms.Label()
        Me.txtGW = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboOwner = New C1.Win.C1List.C1Combo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.lblDepCode = New System.Windows.Forms.Label()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(107, 84)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(144, 23)
        Me.txtDate.TabIndex = 2
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
        Me.cboLot.Caption = ""
        Me.cboLot.CaptionHeight = 17
        Me.cboLot.CaptionStyle = Style49
        Me.cboLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLot.ColumnCaptionHeight = 17
        Me.cboLot.ColumnFooterHeight = 17
        Me.cboLot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.EvenRowStyle = Style50
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.FooterStyle = Style51
        Me.cboLot.HeadingStyle = Style52
        Me.cboLot.HighLightRowStyle = Style53
        Me.cboLot.Images.Add(CType(resources.GetObject("cboLot.Images"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(107, 53)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style54
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.SelectedStyle = Style55
        Me.cboLot.Size = New System.Drawing.Size(272, 24)
        Me.cboLot.Style = Style56
        Me.cboLot.TabIndex = 1
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'cboCS
        '
        Me.cboCS.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCS.AllowColMove = False
        Me.cboCS.AutoCompletion = True
        Me.cboCS.AutoDropDown = True
        Me.cboCS.Caption = ""
        Me.cboCS.CaptionHeight = 17
        Me.cboCS.CaptionStyle = Style57
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
        Me.cboCS.EvenRowStyle = Style58
        Me.cboCS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCS.FooterStyle = Style59
        Me.cboCS.HeadingStyle = Style60
        Me.cboCS.HighLightRowStyle = Style61
        Me.cboCS.Images.Add(CType(resources.GetObject("cboCS.Images"), System.Drawing.Image))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(107, 115)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(20, Short)
        Me.cboCS.MaxLength = 32767
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.OddRowStyle = Style62
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.SelectedStyle = Style63
        Me.cboCS.Size = New System.Drawing.Size(272, 24)
        Me.cboCS.Style = Style64
        Me.cboCS.TabIndex = 3
        Me.cboCS.PropBag = resources.GetString("cboCS.PropBag")
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(107, 238)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(272, 48)
        Me.txtRemarks.TabIndex = 6
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(7, 293)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(799, 129)
        Me.grid.TabIndex = 31
        Me.grid.Text = "C1TrueDBGrid1"
        Me.ToolTip1.SetToolTip(Me.grid, "Double click the table to display information to the data entry fields.")
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(489, 432)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 14
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(732, 428)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 13
        Me.cmdPrint.TabStop = False
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.Visible = False
        '
        'cmdFind
        '
        Me.cmdFind.Enabled = False
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(652, 428)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 12
        Me.cmdFind.TabStop = False
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSave.Location = New System.Drawing.Point(328, 432)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 48)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNew.Location = New System.Drawing.Point(248, 432)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 48)
        Me.cmdNew.TabIndex = 10
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(542, 48)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(259, 24)
        Me.lblCode.TabIndex = 55
        Me.lblCode.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(813, 40)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Receive Raw Fish Reject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Room*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Unloading Date*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Trip Code *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Reject Ctrl#"
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Remarks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Stack*"
        '
        'cboLane
        '
        Me.cboLane.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboLane.AllowColMove = False
        Me.cboLane.AutoCompletion = True
        Me.cboLane.AutoDropDown = True
        Me.cboLane.Caption = ""
        Me.cboLane.CaptionHeight = 17
        Me.cboLane.CaptionStyle = Style65
        Me.cboLane.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLane.ColumnCaptionHeight = 17
        Me.cboLane.ColumnFooterHeight = 17
        Me.cboLane.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboLane.ContentHeight = 18
        Me.cboLane.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLane.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLane.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLane.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLane.EditorHeight = 18
        Me.cboLane.EvenRowStyle = Style66
        Me.cboLane.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLane.FooterStyle = Style67
        Me.cboLane.HeadingStyle = Style68
        Me.cboLane.HighLightRowStyle = Style69
        Me.cboLane.Images.Add(CType(resources.GetObject("cboLane.Images"), System.Drawing.Image))
        Me.cboLane.ItemHeight = 20
        Me.cboLane.Location = New System.Drawing.Point(107, 145)
        Me.cboLane.MatchEntryTimeout = CType(2000, Long)
        Me.cboLane.MaxDropDownItems = CType(20, Short)
        Me.cboLane.MaxLength = 32767
        Me.cboLane.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLane.Name = "cboLane"
        Me.cboLane.OddRowStyle = Style70
        Me.cboLane.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLane.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLane.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLane.SelectedStyle = Style71
        Me.cboLane.Size = New System.Drawing.Size(144, 24)
        Me.cboLane.Style = Style72
        Me.cboLane.TabIndex = 4
        Me.cboLane.PropBag = resources.GetString("cboLane.PropBag")
        '
        'cboRow
        '
        Me.cboRow.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboRow.AllowColMove = False
        Me.cboRow.AutoCompletion = True
        Me.cboRow.AutoDropDown = True
        Me.cboRow.Caption = ""
        Me.cboRow.CaptionHeight = 17
        Me.cboRow.CaptionStyle = Style73
        Me.cboRow.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRow.ColumnCaptionHeight = 17
        Me.cboRow.ColumnFooterHeight = 17
        Me.cboRow.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboRow.ContentHeight = 18
        Me.cboRow.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRow.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRow.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRow.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRow.EditorHeight = 18
        Me.cboRow.EvenRowStyle = Style74
        Me.cboRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRow.FooterStyle = Style75
        Me.cboRow.HeadingStyle = Style76
        Me.cboRow.HighLightRowStyle = Style77
        Me.cboRow.Images.Add(CType(resources.GetObject("cboRow.Images"), System.Drawing.Image))
        Me.cboRow.ItemHeight = 20
        Me.cboRow.Location = New System.Drawing.Point(107, 176)
        Me.cboRow.MatchEntryTimeout = CType(2000, Long)
        Me.cboRow.MaxDropDownItems = CType(20, Short)
        Me.cboRow.MaxLength = 32767
        Me.cboRow.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRow.Name = "cboRow"
        Me.cboRow.OddRowStyle = Style78
        Me.cboRow.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRow.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRow.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRow.SelectedStyle = Style79
        Me.cboRow.Size = New System.Drawing.Size(144, 24)
        Me.cboRow.Style = Style80
        Me.cboRow.TabIndex = 5
        Me.cboRow.PropBag = resources.GetString("cboRow.PropBag")
        '
        'cboStack
        '
        Me.cboStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cboStack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStack.Location = New System.Drawing.Point(107, 207)
        Me.cboStack.Name = "cboStack"
        Me.cboStack.Size = New System.Drawing.Size(144, 24)
        Me.cboStack.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Lane*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Row*"
        '
        'cboBin
        '
        Me.cboBin.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboBin.AllowColMove = False
        Me.cboBin.AutoCompletion = True
        Me.cboBin.AutoDropDown = True
        Me.cboBin.Caption = ""
        Me.cboBin.CaptionHeight = 17
        Me.cboBin.CaptionStyle = Style81
        Me.cboBin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBin.ColumnCaptionHeight = 17
        Me.cboBin.ColumnFooterHeight = 17
        Me.cboBin.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboBin.ContentHeight = 18
        Me.cboBin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBin.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBin.EditorHeight = 18
        Me.cboBin.EvenRowStyle = Style82
        Me.cboBin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBin.FooterStyle = Style83
        Me.cboBin.HeadingStyle = Style84
        Me.cboBin.HighLightRowStyle = Style85
        Me.cboBin.Images.Add(CType(resources.GetObject("cboBin.Images"), System.Drawing.Image))
        Me.cboBin.ItemHeight = 20
        Me.cboBin.Location = New System.Drawing.Point(542, 83)
        Me.cboBin.MatchEntryTimeout = CType(2000, Long)
        Me.cboBin.MaxDropDownItems = CType(20, Short)
        Me.cboBin.MaxLength = 32767
        Me.cboBin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBin.Name = "cboBin"
        Me.cboBin.OddRowStyle = Style86
        Me.cboBin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBin.SelectedStyle = Style87
        Me.cboBin.Size = New System.Drawing.Size(144, 24)
        Me.cboBin.Style = Style88
        Me.cboBin.TabIndex = 7
        Me.cboBin.PropBag = resources.GetString("cboBin.PropBag")
        '
        'lblTare
        '
        Me.lblTare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTare.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTare.Location = New System.Drawing.Point(542, 158)
        Me.lblTare.Name = "lblTare"
        Me.lblTare.Size = New System.Drawing.Size(144, 34)
        Me.lblTare.TabIndex = 69
        Me.lblTare.Text = "0"
        Me.lblTare.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNW
        '
        Me.lblNW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNW.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNW.Location = New System.Drawing.Point(542, 198)
        Me.lblNW.Name = "lblNW"
        Me.lblNW.Size = New System.Drawing.Size(144, 35)
        Me.lblNW.TabIndex = 70
        Me.lblNW.Text = "0"
        Me.lblNW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGW
        '
        Me.txtGW.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGW.Location = New System.Drawing.Point(542, 115)
        Me.txtGW.MaxLength = 4
        Me.txtGW.Name = "txtGW"
        Me.txtGW.Size = New System.Drawing.Size(144, 36)
        Me.txtGW.TabIndex = 8
        Me.txtGW.Text = "0"
        Me.txtGW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(446, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Bin No.*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(446, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 16)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Gross Weight*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(446, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 16)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Tare Weight"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(446, 197)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 16)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Net Weight"
        '
        'cboOwner
        '
        Me.cboOwner.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboOwner.AllowColMove = False
        Me.cboOwner.AutoCompletion = True
        Me.cboOwner.AutoDropDown = True
        Me.cboOwner.Caption = ""
        Me.cboOwner.CaptionHeight = 17
        Me.cboOwner.CaptionStyle = Style89
        Me.cboOwner.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboOwner.ColumnCaptionHeight = 17
        Me.cboOwner.ColumnFooterHeight = 17
        Me.cboOwner.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboOwner.ContentHeight = 18
        Me.cboOwner.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboOwner.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboOwner.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOwner.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboOwner.EditorHeight = 18
        Me.cboOwner.EvenRowStyle = Style90
        Me.cboOwner.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOwner.FooterStyle = Style91
        Me.cboOwner.HeadingStyle = Style92
        Me.cboOwner.HighLightRowStyle = Style93
        Me.cboOwner.Images.Add(CType(resources.GetObject("cboOwner.Images"), System.Drawing.Image))
        Me.cboOwner.ItemHeight = 20
        Me.cboOwner.Location = New System.Drawing.Point(542, 240)
        Me.cboOwner.MatchEntryTimeout = CType(2000, Long)
        Me.cboOwner.MaxDropDownItems = CType(20, Short)
        Me.cboOwner.MaxLength = 32767
        Me.cboOwner.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboOwner.Name = "cboOwner"
        Me.cboOwner.OddRowStyle = Style94
        Me.cboOwner.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboOwner.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboOwner.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboOwner.SelectedStyle = Style95
        Me.cboOwner.Size = New System.Drawing.Size(264, 24)
        Me.cboOwner.Style = Style96
        Me.cboOwner.TabIndex = 9
        Me.cboOwner.PropBag = resources.GetString("cboOwner.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(446, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Owner*"
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(409, 432)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(74, 48)
        Me.cmdDelete.TabIndex = 78
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblDepCode
        '
        Me.lblDepCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepCode.Location = New System.Drawing.Point(257, 207)
        Me.lblDepCode.Name = "lblDepCode"
        Me.lblDepCode.Size = New System.Drawing.Size(126, 24)
        Me.lblDepCode.TabIndex = 79
        Me.lblDepCode.Visible = False
        '
        'frmSpoilage_Rounds
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(813, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDepCode)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboOwner)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtGW)
        Me.Controls.Add(Me.lblNW)
        Me.Controls.Add(Me.lblTare)
        Me.Controls.Add(Me.cboBin)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboStack)
        Me.Controls.Add(Me.cboRow)
        Me.Controls.Add(Me.cboLane)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cboCS)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.txtDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSpoilage_Rounds"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSpoilage_Rounds"
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOwner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmSpoilage_Rounds_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()

        displayLot()
        displayFishBins()
        displayColdStorage()
        displayFishOwner()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayLot()
        With cboLot
            .Text = ""
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 248

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 248

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDate.SelectAll()
            txtDate.Focus()
        End If
    End Sub

    'Public Sub displayRoundRejectDetails(ByVal lot As String)
    '    With grid
    '        .DataSource = getRoundRejectDetails(lot).Tables(0)
    '        .Columns(0).DropDown = cboBin
    '        displayFishBins()
    '        .Columns(4).DropDown = cboReason
    '        displayReason()
    '        .Splits(0).DisplayColumns(4).DropDownList = True

    '        .Splits(0).DisplayColumns(4).Width = 200

    '        .Columns(1).NumberFormat = "###,##0"
    '        .Columns(2).NumberFormat = "###,##0"
    '        .Columns(3).NumberFormat = "###,##0"

    '        .Columns(1).DefaultValue = 0
    '        .Columns(2).DefaultValue = 0
    '        .Columns(3).DefaultValue = 0

    '        .Splits(0).DisplayColumns(2).Locked = True
    '        .Splits(0).DisplayColumns(3).Locked = True
    '        .Splits(0).DisplayColumns(2).Style.BackColor = Color.Gray
    '        .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
    '    End With
    'End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        'displayRoundRejectDetails(cboLot.Text)
        lblCode.Text = ""
        displayVesselLotReject(cboLot.Text)
    End Sub

    'Public Sub computeWeight()
    '    With grid
    '        Dim ctr As Integer
    '        While ctr < .RowCount
    '            Try
    '                .Item(ctr, 2) = modModule.getFishBinTareWeight(.Item(ctr, 0))
    '            Catch ex As Exception
    '                .Item(ctr, 2) = modModule.getFishBinTareWeight("")
    '            End Try

    '            .Item(ctr, 3) = .Item(ctr, 1) - .Item(ctr, 2)

    '            ctr += 1
    '        End While
    '    End With
    'End Sub

    Public Sub displayFishBins()
        With cboBin
            .Text = ""
            .DefColWidth = 120 '78
            .DataSource = modModule.getAllFishBins_AvailableForDeposit().Tables(0)
        End With
    End Sub

    Public Function validateEntries() As Boolean
        With grid
            Dim ctr As Integer = 0
            While ctr < .RowCount
                If .Item(ctr, 0) = "" Or .Item(ctr, 1) = "" Or _
                    CDbl(.Item(ctr, 1)) <= 0 Or .Item(ctr, 4) = "" Or _
                    CDbl(.Item(ctr, 3)) <= 0 Then

                    Return True
                    Exit Function
                End If

                ctr += 1
            End While
        End With

        Return False
    End Function

    Private Sub cboBin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGW.SelectAll()
            txtGW.Focus()
        End If
    End Sub

    'Private Sub grid_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.AfterUpdate
    '    MsgBox(grid.Item(grid.RowCount - 1, 0) & " - " & grid.Item(grid.RowCount - 1, 1) & " - " & grid.Item(grid.RowCount - 1, 2) & _
    '        " - " & grid.Item(grid.RowCount - 1, 3) & " - " & grid.Item(grid.RowCount - 1, 4))
    'End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        lblCode.Text = ""
        lblDepCode.Text = ""

        lblTare.Text = getFishBinTareWeight(cboBin.Text)
        computeWeight()
    End Sub

    Public Sub computeWeight()
        lblNW.Text = Format(CDbl(txtGW.Text) - lblTare.Text, "###,##0.#0")
    End Sub

    Private Sub txtGW_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGW.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboOwner.SelectAll()
            cboOwner.Focus()
        End If
    End Sub

    Private Sub txtGW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGW.TextChanged
        If Not IsNumeric(txtGW.Text) Or txtGW.Text = "" Then
            txtGW.Text = "0"
            txtGW.SelectAll()
            txtGW.Focus()
        End If

        computeWeight()
    End Sub

    Private Sub cboCS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCS.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLane.SelectAll()
            cboLane.Focus()
        End If
    End Sub

    Private Sub cboCS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCS.TextChanged
        displayColdStorageLane(cboCS.Text)
        displayColdStorageRow(cboCS.Text, cboLane.Text)
        displayNextStack()
    End Sub

    Public Sub displayColdStorageLane(ByVal room As String)
        With cboLane
            .DataSource = modModule.getColdStorageLane(room).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayColdStorageRow(ByVal room As String, ByVal lane As String)
        With cboRow
            .DataSource = modModule.getColdStorageRow(room, lane).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 130
            .Splits(0).DisplayColumns(1).Width = 122
            .Splits(0).DisplayColumns(2).Width = 122
            .Splits(0).DisplayColumns(3).Width = 122
            .Splits(0).DisplayColumns(4).Width = 122
            .Splits(0).DisplayColumns(5).Width = 122
            .Splits(0).DisplayColumns(6).Width = 122

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLane_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLane.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboRow.SelectAll()
            cboRow.Focus()
        End If
    End Sub

    Private Sub cboLane_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLane.TextChanged
        displayColdStorageRow(cboCS.Text, cboLane.Text)
        displayNextStack()
    End Sub

    Private Sub cboRow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRow.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRemarks.SelectAll()
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub cboRow_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRow.TextChanged
        displayNextStack()
    End Sub

    Public Sub displayNextStack()
        cboStack.Text = getNextAvailableBinHeight(cboCS.Text, cboLane.Text, cboRow.Text)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
    End Sub

    Public Sub addNewRecord()
        lblDepCode.Text = ""
        displayLot()
        txtDate.Value = getServerDateTime()
        displayColdStorage()
        txtRemarks.Text = ""
        displayFishBins()
        txtGW.Text = 0
        cboLot.SelectAll()
        cboLot.Focus()

        displayFishOwner()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim reply As String

        If Not cboLot.Text.Trim = "" And Not cboCS.Text.Trim = "" And Not cboLane.Text.Trim = "" And _
            Not cboRow.Text.Trim = "" And Not cboBin.Text.Trim = "" And Not cboOwner.Text.Trim = "" Then
            If Not cboStack.Text.Trim = "0" Then
                If CDbl(lblNW.Text.Trim) > 0 Then
                    If lblCode.Text = "" Then
                        reply = MsgBox("Are you sure you want to add this new vessel fish reject?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            'saveNewVesselFishReject(cboLot.Text, txtDate.Text, cboCS.Text, cboLane.Text, cboRow.Text, cboStack.Text, _
                            '        txtRemarks.Text, cboBin.Text, txtGW.Text)

                            displayNextStack()

                            saveNewFishBinForDeposit(cboBin.Text, txtDate.Text, cboCS.Text, txtRemarks.Text, cboLot.Text, "MIXED", "Mixed", _
                                                CDbl(txtGW.Text), "", False, cboLane.Text, _
                                                cboRow.Text, cboStack.Text, "0", modModule.getUsername, "", _
                                                cboOwner.Text, "")

                            updateColdStorageStack(cboCS.Text, cboLane.Text, cboRow.Text, cboStack.Text, _
                                        lblDepCode.Text)

                            displayVesselLotReject(cboLot.Text)

                            MsgBox("You have successfully added new vessel fish rejects", MsgBoxStyle.Information, "Information")
                            displayFishBins()
                            txtGW.Text = "0"
                            displayNextStack()
                            cboBin.SelectAll()
                            cboBin.Focus()
                        End If
                    Else
                        reply = MsgBox("Are you sure you want to update the existing vessel fish reject?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            updateVesselRejectDetails(lblCode.Text, txtGW.Text, txtDate.Text, cboOwner.Text, txtRemarks.Text)
                            displayVesselLotReject(cboLot.Text)

                            MsgBox("You have successfully updated the existing vessel reject", MsgBoxStyle.Information, "Information")

                            cmdNew.Focus()
                        End If
                    End If
                Else
                    MsgBox("Please make sure you weigh the fish bin", MsgBoxStyle.Exclamation, "Warning")
                    txtGW.SelectAll()
                    txtGW.Focus()
                End If
            Else
                MsgBox("You cannot stack to this location because it's full", MsgBoxStyle.Exclamation, "Warning")
                cboCS.SelectAll()
                cboCS.Focus()
            End If
        Else
            MsgBox("Please identify those fields marked with asterisk (*)", MsgBoxStyle.Exclamation, "Warning")
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Public Sub saveNewFishBinForDeposit(ByVal bin As String, ByVal dateTime As String, ByVal cs As String, _
   ByVal remarks As String, ByVal lot As String, ByVal fishSpecie As String, ByVal size As String, _
   ByVal grossWeight As Double, ByVal sublot As String, ByVal hold As Boolean, _
   ByVal location As String, ByVal position As String, ByVal height As String, _
   ByVal sample As String, ByVal scaler As String, ByVal rr As String, ByVal owner As String, ByVal sub2 As String)
        Dim depositCode As String

        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FishBinsDeposit"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishBinForDepositCounter()

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@depositCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = "VR" & Format(CDate(dateTime), "ddMMyy") & "L" & lot & bin & p1.Value
            depositCode = p2.Value
            lblDepCode.Text = p2.Value

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@binCode"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = getFishBinCode(bin)

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@batchlot"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = lot

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@specieCode"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = getSpecieCode(fishSpecie)

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@csCode"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = getCSCode(cs)

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@grossWeight"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.Float
            p7.Value = grossWeight

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@dateTimeTransfer"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.DateTime
            'txtDate.Value = getServerDateTime()
            'dateTime = txtDate.Value
            'dateTime = txtDate.Value
            p8.Value = Format(CDate(dateTime), getTimeFormat())

            Dim p9 As New SqlClient.SqlParameter
            p9.ParameterName = "@remarks"
            p9.Direction = ParameterDirection.Input
            p9.SqlDbType = SqlDbType.VarChar
            p9.Value = remarks

            Dim p10 As New SqlClient.SqlParameter
            p10.ParameterName = "@withdraw"
            p10.Direction = ParameterDirection.Input
            p10.SqlDbType = SqlDbType.VarChar
            p10.Value = "NO"

            Dim p11 As New SqlClient.SqlParameter
            p11.ParameterName = "@depositStatus"
            p11.Direction = ParameterDirection.Input
            p11.SqlDbType = SqlDbType.VarChar
            p11.Value = "*"

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

            Dim p12 As New SqlClient.SqlParameter
            p12.ParameterName = "@sizeCode"
            p12.Direction = ParameterDirection.Input
            p12.SqlDbType = SqlDbType.VarChar
            p12.Value = getFishSizeCodeByRange(size)

            Dim p13 As New SqlClient.SqlParameter
            p13.ParameterName = "@sublot"
            p13.Direction = ParameterDirection.Input
            p13.SqlDbType = SqlDbType.VarChar
            p13.Value = sublot

            Dim p14 As New SqlClient.SqlParameter
            p14.ParameterName = "@hold"
            p14.Direction = ParameterDirection.Input
            p14.SqlDbType = SqlDbType.Int
            If hold Then
                p14.Value = 1
            Else
                p14.Value = 0
            End If

            Dim p15 As New SqlClient.SqlParameter
            p15.ParameterName = "@location"
            p15.Direction = ParameterDirection.Input
            p15.SqlDbType = SqlDbType.VarChar
            p15.Value = location

            Dim p16 As New SqlClient.SqlParameter
            p16.ParameterName = "@position"
            p16.Direction = ParameterDirection.Input
            p16.SqlDbType = SqlDbType.VarChar
            p16.Value = position

            Dim p17 As New SqlClient.SqlParameter
            p17.ParameterName = "@height"
            p17.Direction = ParameterDirection.Input
            p17.SqlDbType = SqlDbType.VarChar
            p17.Value = height

            Dim p18 As New SqlClient.SqlParameter
            p18.ParameterName = "@sample"
            p18.Direction = ParameterDirection.Input
            p18.SqlDbType = SqlDbType.VarChar
            p18.Value = sample

            Dim p19 As New SqlClient.SqlParameter
            p19.ParameterName = "@scaler"
            p19.Direction = ParameterDirection.Input
            p19.SqlDbType = SqlDbType.VarChar
            p19.Value = scaler

            Dim p20 As New SqlClient.SqlParameter
            p20.ParameterName = "@rrNo"
            p20.Direction = ParameterDirection.Input
            p20.SqlDbType = SqlDbType.VarChar
            p20.Value = rr

            Dim p21 As New SqlClient.SqlParameter
            p21.ParameterName = "@ownerCode"
            p21.Direction = ParameterDirection.Input
            p21.SqlDbType = SqlDbType.VarChar
            p21.Value = getFishOwnerCode(owner)

            Dim p22 As New SqlClient.SqlParameter
            p22.ParameterName = "@sub"
            p22.Direction = ParameterDirection.Input
            p22.SqlDbType = SqlDbType.VarChar
            p22.Value = sub2

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)
            cmd.Parameters.Add(p9)
            cmd.Parameters.Add(p10)
            cmd.Parameters.Add(p11)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)
            cmd.Parameters.Add(p12)
            cmd.Parameters.Add(p13)
            cmd.Parameters.Add(p14)
            cmd.Parameters.Add(p15)
            cmd.Parameters.Add(p16)
            cmd.Parameters.Add(p17)
            cmd.Parameters.Add(p18)
            cmd.Parameters.Add(p19)
            cmd.Parameters.Add(p20)
            cmd.Parameters.Add(p21)
            cmd.Parameters.Add(p22)

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

    Public Sub displayFishOwner()
        With cboOwner
            .Text = ""
            .DefColWidth = 240
            .DataSource = modModule.getOwner().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 99
        End With
    End Sub

    Public Sub displayVesselLotReject(ByVal lot As String)
        With grid
            .DataSource = getLotVesselRejects(lot).Tables(0)
            .Columns(7).NumberFormat = "###,##0.#0"
            .Columns(8).NumberFormat = "###,##0.#0"
            .Columns(9).NumberFormat = "###,##0.#0"

            .Splits(0).DisplayColumns(10).Width = 180
            .Splits(0).DisplayColumns(11).Width = 180
        End With
    End Sub

    Public Sub displayRecordToField()
        With grid
            If .RowCount > 0 Then
                cboLot.Text = .Item(.Row, 0)
                txtDate.Value = .Item(.Row, 1)
                cboCS.Text = .Item(.Row, 2)
                cboLane.Text = .Item(.Row, 3)
                cboRow.Text = .Item(.Row, 4)
                cboStack.Text = .Item(.Row, 5)
                cboBin.Text = .Item(.Row, 6)
                txtGW.Text = .Item(.Row, 7)
                cboOwner.Text = .Item(.Row, 10)
                txtRemarks.Text = .Item(.Row, 11)

                lblCode.Text = getDepositCode(.Item(.Row, 6))
            End If
        End With
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        displayRecordToField()
    End Sub

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCS.SelectAll()
            cboCS.Focus()
        End If
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        lblCode.Text = ""
    End Sub

    Private Sub txtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboBin.SelectAll()
            cboBin.Focus()
        End If
    End Sub

    Private Sub cboOwner_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboOwner.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave.Focus()
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim reply As String
        If Not cboBin.Text.Trim = "" Then
            reply = MsgBox("Are you sure you want to delete this bin from the lists?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If reply = vbYes Then
                With grid
                    If .RowCount > 0 Then
                        If Not .Item(.Row, 4) Is DBNull.Value Then
                            If Not CStr(.Item(.Row, 4)) = "" Then
                                deleteBinFromDeposit(cboBin.Text)

                                updateColdStorageStack(cboCS.Text, cboLane.Text, cboRow.Text, cboStack.Text, "")

                                Dim stack As Integer
                                While stack < 6
                                    checkForAutoStack(cboCS.Text, cboLane.Text, cboRow.Text) 'lblRow.Text)

                                    stack += 1
                                End While

                                displayVesselLotReject(cboLot.Text)
                                addNewRecord()

                                MsgBox("You have successfully remove the bins from the lists", MsgBoxStyle.Information, "Information")

                                grid.Focus()
                            Else
                                MsgBox("Please identify properly the bin number before you can remove the record", MsgBoxStyle.Exclamation, "Warning")
                                grid.Focus()
                            End If
                        Else
                            MsgBox("Please identify properly the bin number before you can remove the record", MsgBoxStyle.Exclamation, "Warning")
                            grid.Focus()
                        End If
                    Else
                        MsgBox("Please identify properly the bin number before you can remove the record", MsgBoxStyle.Exclamation, "Warning")
                        grid.Focus()
                    End If
                End With
            End If
        End If
    End Sub
End Class
