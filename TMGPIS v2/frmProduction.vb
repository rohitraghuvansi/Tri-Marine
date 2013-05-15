Public Class frmProduction
    Inherits System.Windows.Forms.Form

    Public Shared flgCan, flgEnd, flgCarton, flgLabel, flgOil, flgSalt, flgCF, flgCP, flgCurry, flgBroth, flgMSG As Boolean
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboProduct As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents lblCSolid As System.Windows.Forms.Label
    Friend WithEvents lblCChunks As System.Windows.Forms.Label
    Friend WithEvents lblCWF As System.Windows.Forms.Label
    Friend WithEvents lblCDF As System.Windows.Forms.Label
    Friend WithEvents lblFDF As System.Windows.Forms.Label
    Friend WithEvents lblFWF As System.Windows.Forms.Label
    Friend WithEvents lblFLoins As System.Windows.Forms.Label
    Friend WithEvents grpQuantity As System.Windows.Forms.GroupBox
    Friend WithEvents txtOCases As System.Windows.Forms.TextBox
    Friend WithEvents txtOTins As System.Windows.Forms.TextBox
    Friend WithEvents txtOperCase As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cmdOAccept As System.Windows.Forms.Button
    Friend WithEvents cmdOCancel As System.Windows.Forms.Button
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtLayer As System.Windows.Forms.TextBox
    Friend WithEvents txtTinsPerLayer As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents cboUnitPerCase As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdAClose As System.Windows.Forms.Button
    Friend WithEvents cmdASave As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblLotStatus As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboSublot As C1.Win.C1List.C1Combo
    Friend WithEvents lblSublot As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduction))
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
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style21 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style22 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style23 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style24 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style25 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style26 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style27 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style28 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style29 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style30 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style31 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style32 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style33 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style34 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style35 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style36 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style37 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style38 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style39 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style40 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.lblCSolid = New System.Windows.Forms.Label()
        Me.lblCChunks = New System.Windows.Forms.Label()
        Me.lblCWF = New System.Windows.Forms.Label()
        Me.lblCDF = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblFDF = New System.Windows.Forms.Label()
        Me.lblFWF = New System.Windows.Forms.Label()
        Me.lblFLoins = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboProduct = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grpQuantity = New System.Windows.Forms.GroupBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtOperCase = New System.Windows.Forms.TextBox()
        Me.txtOTins = New System.Windows.Forms.TextBox()
        Me.txtOCases = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtLayer = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtTinsPerLayer = New System.Windows.Forms.TextBox()
        Me.cmdOCancel = New System.Windows.Forms.Button()
        Me.cmdOAccept = New System.Windows.Forms.Button()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cboUnitPerCase = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdAClose = New System.Windows.Forms.Button()
        Me.cmdASave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblLotStatus = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboSublot = New C1.Win.C1List.C1Combo()
        Me.lblSublot = New System.Windows.Forms.Label()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQuantity.SuspendLayout()
        CType(Me.cboUnitPerCase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(88, 52)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(152, 23)
        Me.txtProdnDate.TabIndex = 0
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboShift
        '
        Me.cboShift.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboShift.AllowColMove = False
        Me.cboShift.AutoCompletion = True
        Me.cboShift.AutoDropDown = True
        Me.cboShift.Caption = ""
        Me.cboShift.CaptionHeight = 17
        Me.cboShift.CaptionStyle = Style1
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
        Me.cboShift.EvenRowStyle = Style2
        Me.cboShift.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.FooterStyle = Style3
        Me.cboShift.HeadingStyle = Style4
        Me.cboShift.HighLightRowStyle = Style5
        Me.cboShift.Images.Add(CType(resources.GetObject("cboShift.Images"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(88, 84)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(5, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.OddRowStyle = Style6
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.SelectedStyle = Style7
        Me.cboShift.Size = New System.Drawing.Size(152, 24)
        Me.cboShift.Style = Style8
        Me.cboShift.TabIndex = 1
        Me.cboShift.PropBag = resources.GetString("cboShift.PropBag")
        '
        'grid
        '
        Me.grid.AllowAddNew = True
        Me.grid.AllowColMove = False
        Me.grid.AllowSort = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 256)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(888, 218)
        Me.grid.TabIndex = 4
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Prod'n Date"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(906, 40)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Production Output Data"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(536, 481)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(456, 481)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Enabled = False
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(412, 456)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 7
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(375, 481)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 6
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(295, 481)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 5
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Prd'n Shift"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Canned Tuna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Trip Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(240, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Dark Flake"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(240, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "White Flake"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Chunks"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Solid"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Gray
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(703, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Red Meat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gray
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(488, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "White Flake"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Gray
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(488, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 16)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Loins"
        '
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
        Me.cboLot.Caption = ""
        Me.cboLot.CaptionHeight = 17
        Me.cboLot.CaptionStyle = Style9
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
        Me.cboLot.EvenRowStyle = Style10
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.FooterStyle = Style11
        Me.cboLot.HeadingStyle = Style12
        Me.cboLot.HighLightRowStyle = Style13
        Me.cboLot.Images.Add(CType(resources.GetObject("cboLot.Images"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(456, 51)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(10, Short)
        Me.cboLot.MaxLength = 6
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style14
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.SelectedStyle = Style15
        Me.cboLot.Size = New System.Drawing.Size(320, 24)
        Me.cboLot.Style = Style16
        Me.cboLot.TabIndex = 2
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'lblCSolid
        '
        Me.lblCSolid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCSolid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCSolid.Location = New System.Drawing.Point(88, 150)
        Me.lblCSolid.Name = "lblCSolid"
        Me.lblCSolid.Size = New System.Drawing.Size(104, 24)
        Me.lblCSolid.TabIndex = 60
        Me.lblCSolid.Text = "0.0"
        Me.lblCSolid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCChunks
        '
        Me.lblCChunks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCChunks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCChunks.Location = New System.Drawing.Point(88, 183)
        Me.lblCChunks.Name = "lblCChunks"
        Me.lblCChunks.Size = New System.Drawing.Size(104, 24)
        Me.lblCChunks.TabIndex = 61
        Me.lblCChunks.Text = "0.0"
        Me.lblCChunks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCWF
        '
        Me.lblCWF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCWF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCWF.Location = New System.Drawing.Point(320, 150)
        Me.lblCWF.Name = "lblCWF"
        Me.lblCWF.Size = New System.Drawing.Size(104, 24)
        Me.lblCWF.TabIndex = 62
        Me.lblCWF.Text = "0.0"
        Me.lblCWF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCDF
        '
        Me.lblCDF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCDF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCDF.Location = New System.Drawing.Point(320, 183)
        Me.lblCDF.Name = "lblCDF"
        Me.lblCDF.Size = New System.Drawing.Size(104, 24)
        Me.lblCDF.TabIndex = 63
        Me.lblCDF.Text = "0.0"
        Me.lblCDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Gray
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(464, 126)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Frozen Loins"
        '
        'lblFDF
        '
        Me.lblFDF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFDF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFDF.Location = New System.Drawing.Point(776, 150)
        Me.lblFDF.Name = "lblFDF"
        Me.lblFDF.Size = New System.Drawing.Size(104, 24)
        Me.lblFDF.TabIndex = 67
        Me.lblFDF.Text = "0.0"
        Me.lblFDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFWF
        '
        Me.lblFWF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFWF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWF.Location = New System.Drawing.Point(568, 183)
        Me.lblFWF.Name = "lblFWF"
        Me.lblFWF.Size = New System.Drawing.Size(104, 24)
        Me.lblFWF.TabIndex = 66
        Me.lblFWF.Text = "0.0"
        Me.lblFWF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFLoins
        '
        Me.lblFLoins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFLoins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFLoins.Location = New System.Drawing.Point(568, 150)
        Me.lblFLoins.Name = "lblFLoins"
        Me.lblFLoins.Size = New System.Drawing.Size(104, 24)
        Me.lblFLoins.TabIndex = 65
        Me.lblFLoins.Text = "0.0"
        Me.lblFLoins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Gray
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(440, 104)
        Me.Label21.TabIndex = 68
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Gray
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(456, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(440, 104)
        Me.Label22.TabIndex = 69
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 235)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(95, 16)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Meat Utilization"
        '
        'cboProduct
        '
        Me.cboProduct.AllowColMove = True
        Me.cboProduct.AllowColSelect = True
        Me.cboProduct.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboProduct.AlternatingRows = False
        Me.cboProduct.CaptionStyle = Style17
        Me.cboProduct.ColumnCaptionHeight = 17
        Me.cboProduct.ColumnFooterHeight = 17
        Me.cboProduct.EvenRowStyle = Style18
        Me.cboProduct.FetchRowStyles = False
        Me.cboProduct.FooterStyle = Style19
        Me.cboProduct.HeadingStyle = Style20
        Me.cboProduct.HighLightRowStyle = Style21
        Me.cboProduct.Images.Add(CType(resources.GetObject("cboProduct.Images"), System.Drawing.Image))
        Me.cboProduct.Location = New System.Drawing.Point(8, 280)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.OddRowStyle = Style22
        Me.cboProduct.RecordSelectorStyle = Style23
        Me.cboProduct.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProduct.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboProduct.RowHeight = 20
        Me.cboProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProduct.ScrollTips = False
        Me.cboProduct.Size = New System.Drawing.Size(123, 216)
        Me.cboProduct.Style = Style24
        Me.cboProduct.TabIndex = 71
        Me.cboProduct.Text = "C1TrueDBDropdown1"
        Me.cboProduct.Visible = False
        Me.cboProduct.PropBag = resources.GetString("cboProduct.PropBag")
        '
        'grpQuantity
        '
        Me.grpQuantity.Controls.Add(Me.Label55)
        Me.grpQuantity.Controls.Add(Me.Label56)
        Me.grpQuantity.Controls.Add(Me.txtOperCase)
        Me.grpQuantity.Controls.Add(Me.txtOTins)
        Me.grpQuantity.Controls.Add(Me.txtOCases)
        Me.grpQuantity.Controls.Add(Me.Label54)
        Me.grpQuantity.Controls.Add(Me.txtLayer)
        Me.grpQuantity.Controls.Add(Me.Label53)
        Me.grpQuantity.Controls.Add(Me.txtTinsPerLayer)
        Me.grpQuantity.Controls.Add(Me.cmdOCancel)
        Me.grpQuantity.Controls.Add(Me.cmdOAccept)
        Me.grpQuantity.Controls.Add(Me.Label52)
        Me.grpQuantity.Controls.Add(Me.Label51)
        Me.grpQuantity.Controls.Add(Me.Label50)
        Me.grpQuantity.Enabled = False
        Me.grpQuantity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpQuantity.Location = New System.Drawing.Point(229, 280)
        Me.grpQuantity.Name = "grpQuantity"
        Me.grpQuantity.Size = New System.Drawing.Size(448, 184)
        Me.grpQuantity.TabIndex = 74
        Me.grpQuantity.TabStop = False
        Me.grpQuantity.Text = "Quantity"
        Me.grpQuantity.Visible = False
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(16, 64)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(63, 16)
        Me.Label55.TabIndex = 59
        Me.Label55.Text = "Odd Cans"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(16, 32)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(80, 16)
        Me.Label56.TabIndex = 58
        Me.Label56.Text = "No. of Cases"
        '
        'txtOperCase
        '
        Me.txtOperCase.Location = New System.Drawing.Point(96, 95)
        Me.txtOperCase.Name = "txtOperCase"
        Me.txtOperCase.ReadOnly = True
        Me.txtOperCase.Size = New System.Drawing.Size(104, 23)
        Me.txtOperCase.TabIndex = 2
        Me.txtOperCase.TabStop = False
        Me.txtOperCase.Text = "0"
        Me.txtOperCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOTins
        '
        Me.txtOTins.Location = New System.Drawing.Point(96, 62)
        Me.txtOTins.Name = "txtOTins"
        Me.txtOTins.Size = New System.Drawing.Size(104, 23)
        Me.txtOTins.TabIndex = 1
        Me.txtOTins.Text = "0"
        Me.txtOTins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOCases
        '
        Me.txtOCases.Location = New System.Drawing.Point(96, 30)
        Me.txtOCases.Name = "txtOCases"
        Me.txtOCases.Size = New System.Drawing.Size(104, 23)
        Me.txtOCases.TabIndex = 0
        Me.txtOCases.Text = "0"
        Me.txtOCases.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(248, 32)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(39, 16)
        Me.Label54.TabIndex = 57
        Me.Label54.Text = "Layer"
        '
        'txtLayer
        '
        Me.txtLayer.Location = New System.Drawing.Point(336, 30)
        Me.txtLayer.Name = "txtLayer"
        Me.txtLayer.ReadOnly = True
        Me.txtLayer.Size = New System.Drawing.Size(104, 23)
        Me.txtLayer.TabIndex = 56
        Me.txtLayer.TabStop = False
        Me.txtLayer.Text = "0"
        Me.txtLayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(248, 64)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(86, 16)
        Me.Label53.TabIndex = 55
        Me.Label53.Text = "tins per Layer"
        '
        'txtTinsPerLayer
        '
        Me.txtTinsPerLayer.Location = New System.Drawing.Point(336, 62)
        Me.txtTinsPerLayer.Name = "txtTinsPerLayer"
        Me.txtTinsPerLayer.ReadOnly = True
        Me.txtTinsPerLayer.Size = New System.Drawing.Size(104, 23)
        Me.txtTinsPerLayer.TabIndex = 54
        Me.txtTinsPerLayer.TabStop = False
        Me.txtTinsPerLayer.Text = "0"
        Me.txtTinsPerLayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdOCancel
        '
        Me.cmdOCancel.Image = CType(resources.GetObject("cmdOCancel.Image"), System.Drawing.Image)
        Me.cmdOCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdOCancel.Location = New System.Drawing.Point(227, 128)
        Me.cmdOCancel.Name = "cmdOCancel"
        Me.cmdOCancel.Size = New System.Drawing.Size(75, 48)
        Me.cmdOCancel.TabIndex = 53
        Me.cmdOCancel.Text = "&Cancel"
        Me.cmdOCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdOAccept
        '
        Me.cmdOAccept.Image = CType(resources.GetObject("cmdOAccept.Image"), System.Drawing.Image)
        Me.cmdOAccept.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdOAccept.Location = New System.Drawing.Point(147, 128)
        Me.cmdOAccept.Name = "cmdOAccept"
        Me.cmdOAccept.Size = New System.Drawing.Size(75, 48)
        Me.cmdOAccept.TabIndex = 52
        Me.cmdOAccept.Text = "Accep&t"
        Me.cmdOAccept.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(21, 97)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(59, 16)
        Me.Label52.TabIndex = 51
        Me.Label52.Text = "per Case"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(184, 64)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(63, 16)
        Me.Label51.TabIndex = 50
        Me.Label51.Text = "Odd Cans"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(184, 32)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(77, 16)
        Me.Label50.TabIndex = 49
        Me.Label50.Text = "No. of Layer"
        '
        'cboUnitPerCase
        '
        Me.cboUnitPerCase.AllowColMove = True
        Me.cboUnitPerCase.AllowColSelect = True
        Me.cboUnitPerCase.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboUnitPerCase.AlternatingRows = False
        Me.cboUnitPerCase.CaptionStyle = Style25
        Me.cboUnitPerCase.ColumnCaptionHeight = 17
        Me.cboUnitPerCase.ColumnFooterHeight = 17
        Me.cboUnitPerCase.EvenRowStyle = Style26
        Me.cboUnitPerCase.FetchRowStyles = False
        Me.cboUnitPerCase.FooterStyle = Style27
        Me.cboUnitPerCase.HeadingStyle = Style28
        Me.cboUnitPerCase.HighLightRowStyle = Style29
        Me.cboUnitPerCase.Images.Add(CType(resources.GetObject("cboUnitPerCase.Images"), System.Drawing.Image))
        Me.cboUnitPerCase.Location = New System.Drawing.Point(672, 280)
        Me.cboUnitPerCase.Name = "cboUnitPerCase"
        Me.cboUnitPerCase.OddRowStyle = Style30
        Me.cboUnitPerCase.RecordSelectorStyle = Style31
        Me.cboUnitPerCase.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboUnitPerCase.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboUnitPerCase.RowHeight = 20
        Me.cboUnitPerCase.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboUnitPerCase.ScrollTips = False
        Me.cboUnitPerCase.Size = New System.Drawing.Size(123, 216)
        Me.cboUnitPerCase.Style = Style32
        Me.cboUnitPerCase.TabIndex = 75
        Me.cboUnitPerCase.Text = "C1TrueDBDropdown1"
        Me.cboUnitPerCase.Visible = False
        Me.cboUnitPerCase.PropBag = resources.GetString("cboUnitPerCase.PropBag")
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Label10)
        Me.grp.Controls.Add(Me.Label14)
        Me.grp.Controls.Add(Me.cmdAClose)
        Me.grp.Controls.Add(Me.cmdASave)
        Me.grp.Controls.Add(Me.txtPassword)
        Me.grp.Controls.Add(Me.txtUsername)
        Me.grp.Enabled = False
        Me.grp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(245, 397)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(416, 136)
        Me.grp.TabIndex = 76
        Me.grp.TabStop = False
        Me.grp.Text = "User Authentication"
        Me.grp.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(52, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Username"
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
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(216, 23)
        Me.txtPassword.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(148, 24)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(216, 23)
        Me.txtUsername.TabIndex = 0
        '
        'lblLotStatus
        '
        Me.lblLotStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLotStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotStatus.Location = New System.Drawing.Point(866, 51)
        Me.lblLotStatus.Name = "lblLotStatus"
        Me.lblLotStatus.Size = New System.Drawing.Size(152, 24)
        Me.lblLotStatus.TabIndex = 77
        Me.lblLotStatus.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(802, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 16)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Lot Status"
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(392, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 16)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Lot ID"
        '
        'cboSublot
        '
        Me.cboSublot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboSublot.AllowColMove = False
        Me.cboSublot.AutoCompletion = True
        Me.cboSublot.AutoDropDown = True
        Me.cboSublot.Caption = ""
        Me.cboSublot.CaptionHeight = 17
        Me.cboSublot.CaptionStyle = Style33
        Me.cboSublot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSublot.ColumnCaptionHeight = 17
        Me.cboSublot.ColumnFooterHeight = 17
        Me.cboSublot.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboSublot.ContentHeight = 18
        Me.cboSublot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSublot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSublot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSublot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSublot.EditorHeight = 18
        Me.cboSublot.EvenRowStyle = Style34
        Me.cboSublot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSublot.FooterStyle = Style35
        Me.cboSublot.HeadingStyle = Style36
        Me.cboSublot.HighLightRowStyle = Style37
        Me.cboSublot.Images.Add(CType(resources.GetObject("cboSublot.Images"), System.Drawing.Image))
        Me.cboSublot.ItemHeight = 20
        Me.cboSublot.Location = New System.Drawing.Point(456, 84)
        Me.cboSublot.MatchEntryTimeout = CType(2000, Long)
        Me.cboSublot.MaxDropDownItems = CType(10, Short)
        Me.cboSublot.MaxLength = 6
        Me.cboSublot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSublot.Name = "cboSublot"
        Me.cboSublot.OddRowStyle = Style38
        Me.cboSublot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSublot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSublot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSublot.SelectedStyle = Style39
        Me.cboSublot.Size = New System.Drawing.Size(152, 24)
        Me.cboSublot.Style = Style40
        Me.cboSublot.TabIndex = 3
        Me.cboSublot.PropBag = resources.GetString("cboSublot.PropBag")
        '
        'lblSublot
        '
        Me.lblSublot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSublot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSublot.Location = New System.Drawing.Point(624, 84)
        Me.lblSublot.Name = "lblSublot"
        Me.lblSublot.Size = New System.Drawing.Size(152, 24)
        Me.lblSublot.TabIndex = 81
        '
        'frmProduction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(906, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSublot)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboSublot)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblLotStatus)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.cboUnitPerCase)
        Me.Controls.Add(Me.grpQuantity)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFDF)
        Me.Controls.Add(Me.lblFWF)
        Me.Controls.Add(Me.lblFLoins)
        Me.Controls.Add(Me.lblCDF)
        Me.Controls.Add(Me.lblCWF)
        Me.Controls.Add(Me.lblCChunks)
        Me.Controls.Add(Me.lblCSolid)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtProdnDate)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmdFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProduction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProduction"
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQuantity.ResumeLayout(False)
        Me.grpQuantity.PerformLayout()
        CType(Me.cboUnitPerCase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        dataEntry(1)
        txtProdnDate.Value = getServerDateTime()

        initializeShift()
        'initializeUnitPerCase()
        'displayFishLotWithdrawn()

        displayProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboSublot.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Public Sub displayListsOfProduction()
    '    With grid
    '        .DataSource = modModule.getListsOfProduction(Format(CDate(txtProdnDate.Value), "yyyy")).Tables(0)
    '        displayProduct()
    '        .Columns(0).DropDown = cboProduct
    '        .Splits(0).DisplayColumns(0).DropDownList = True
    '        '.Splits(0).DisplayColumns(0).Width = 150
    '        '.Splits(0).DisplayColumns(1).Width = 346
    '        .Splits(0).DisplayColumns(2).Locked = True
    '        .Splits(0).DisplayColumns(2).Style.BackColor = Color.Gray
    '        .Columns(4).DefaultValue = 0
    '        .Columns(4).NumberFormat = "###,###,##0.#0"
    '        .Splits(0).DisplayColumns(5).Locked = True
    '        .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
    '        .Columns(5).NumberFormat = "###,###,##0.#0"
    '        .Splits(0).DisplayColumns(6).Locked = True
    '        .Splits(0).DisplayColumns(6).Style.BackColor = Color.Gray
    '        .Columns(6).DefaultValue = 0
    '        .Columns(6).NumberFormat = "###,###,##0.#0"
    '        .Columns(7).DefaultValue = 0
    '        .Columns(7).NumberFormat = "###,###,##0.#0"

    '        .Splits(0).DisplayColumns(0).Width = 120
    '        .Splits(0).DisplayColumns(1).Width = 90
    '        .Splits(0).DisplayColumns(2).Width = 90
    '        .Splits(0).DisplayColumns(3).Width = 143
    '    End With
    'End Sub

    Public Sub displayProduct()
        With cboProduct
            .DataSource = modModule.getProductCode().Tables(0)
        End With
    End Sub

    Public Sub displayFishLotWithdrawn(ByVal prodnDate As String, ByVal shift As String)
        With cboLot
            .DataSource = modModule.getBatchlotsWithdrawn(prodnDate, shift).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 295

            If .ListCount > 0 Then
                .SelectedIndex = 0
            Else
                .Text = ""
            End If
        End With
    End Sub

    Public Sub initializeShift()
        With cboShift
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 130
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayUnitPerCase()
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand("SELECT unitPerCase AS [Unit/ Case] FROM tblUnitPerCase " & _
                " ORDER BY unitPerCase", c)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("perCase")
            da.Fill(ds)

            cboUnitPerCase.DefColWidth = 80
            cboUnitPerCase.DataSource = ds.Tables(0)

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub displayProdnYear()
        Dim ctr As Integer
        While ctr < grid.RowCount
            grid.Item(ctr, 7) = CStr(Format(CDate(txtProdnDate.Value), "yyyy")).Substring(3)
            ctr += 1
        End While
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

        displayFishLotWithdrawn(txtProdnDate.Value, cboShift.Text)
        displaySublot(txtProdnDate.Text, cboShift.Text, cboLot.Text)

        displayProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboSublot.Text)
    End Sub

    Public Sub computeContent()
        displayProdnYear()
        Dim cansPerCase As Double
        Dim pCode As String

        Dim ctr As Integer
        While ctr < grid.RowCount
            grid.Item(ctr, 8) = CDate(txtProdnDate.Value).DayOfYear     '3

            'If Not grid.Item(ctr, 0) Is DBNull.Value Then
            '    grid.Item(ctr, 5) = getCanSize_tinsPerCase(grid.Item(ctr, 0))
            'Else
            '    grid.Item(ctr, 5) = "0"
            'End If
            Try
                If grid.Item(ctr, 1) Is DBNull.Value Then
                    pCode = ""
                Else
                    pCode = grid.Item(ctr, 1)
                End If

                If grid.Item(ctr, 5) Is DBNull.Value Then   '6
                    cansPerCase = 0
                Else
                    cansPerCase = grid.Item(ctr, 5)         '6
                End If
            Catch e As Exception
                If grid.Item(ctr, 1) = "" Then
                    pCode = ""
                Else
                    pCode = grid.Item(ctr, 1)
                End If

                If grid.Item(ctr, 5) = "" Then              '6
                    cansPerCase = 0
                Else
                    cansPerCase = grid.Item(ctr, 5)         '6
                End If
            End Try

            If CStr(getProductCategory(pCode)).StartsWith("Can") Then
                grid.Item(ctr, 9) = CDate(txtProdnDate.Value).AddYears(3)       '4
            Else
                grid.Item(ctr, 9) = CDate(txtProdnDate.Value).AddYears(1)       '4
            End If

            If CStr(grid.Item(ctr, 1)).StartsWith("R") Or CStr(grid.Item(ctr, 1)).StartsWith("F") Then
                grid.Item(ctr, 5) = "1"                     '6
            Else
                grid.Item(ctr, 5) = getCansPerCase(getProductCanSize(grid.Item(ctr, 1)), "CAN SIZE")    '6
            End If

            If Not grid.Item(ctr, 4) Is DBNull.Value Then       '5
                grid.Item(ctr, 6) = CDbl(grid.Item(ctr, 4)) / cansPerCase       '7  (5)
            Else
                grid.Item(ctr, 6) = 0 / cansPerCase         '7
            End If

            ctr += 1
        End While

        computePackedLoins()
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        computeContent()
    End Sub

    Public Sub computePackedLoins()
        Dim ctr As Integer
        Dim ps As String
        Dim solid, chunks, wFlakes, dFlakes, loins, fWflakes, fDflakes As Double
        Dim unit, fw As Double
        While ctr < grid.RowCount
            If Not grid.Item(ctr, 1) Is DBNull.Value Then
                ps = getPackStyle_ProductCode(grid.Item(ctr, 1))

                If Not grid.Item(ctr, 4) Is DBNull.Value Then
                    unit = grid.Item(ctr, 4)
                Else
                    unit = 0
                End If

                'If Not grid.Item(ctr, 2) Is DBNull.Value Then
                fw = getProductBOM(grid.Item(ctr, 1)) 'grid.Item(ctr, 8)
                'Else
                'fw = 0
                'End If

                If ps.StartsWith("Sol") Then
                    solid = solid + ((unit * fw) / 1000)
                ElseIf ps.StartsWith("Chun") Then
                    chunks = chunks + ((unit * fw) / 1000)
                ElseIf ps.StartsWith("White") Then
                    wFlakes = wFlakes + ((unit * fw) / 1000)
                ElseIf ps.StartsWith("Dark") Then
                    dFlakes = dFlakes + ((unit * fw) / 1000)
                ElseIf ps.StartsWith("Frozen Loin") Then
                    loins = loins + ((unit * fw) / 1000)
                ElseIf ps.StartsWith("Frozen White Flake") Then
                    fWflakes = fWflakes + ((unit * fw) / 1000)
                Else
                    fDflakes = fDflakes + ((unit * fw) / 1000)
                End If
            End If

            ctr += 1
        End While

        lblCSolid.Text = Format(solid, "###,###,##0.0")
        lblCChunks.Text = Format(chunks, "###,###,##0.0")
        lblCWF.Text = Format(wFlakes, "###,###,##0.0")
        lblCDF.Text = Format(dFlakes, "###,###,##0.0")
        lblFLoins.Text = Format(loins, "###,###,##0.0")
        lblFWF.Text = Format(fWflakes, "###,###,##0.0")
        lblFDF.Text = Format(fDflakes, "###,###,##0.0")
    End Sub

    Public Function getPackStyle_ProductCode(ByVal pCode As String) As String
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getPackStyle_ProductCode"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@pCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = pCode

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            Dim returnValue As String
            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    returnValue = dr.GetString(0)
                Else
                    returnValue = ""
                End If
            Else
                returnValue = ""
            End If

            dr.Close()
            c.Close()

            Return returnValue
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Function

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
                txtProdnDate.ReadOnly = False
                cboShift.ReadOnly = False
                cboLot.ReadOnly = False
                cboSublot.ReadOnly = False
                grid.Enabled = True
            Case 1
                txtProdnDate.ReadOnly = True
                cboShift.ReadOnly = True
                cboLot.ReadOnly = True
                cboSublot.ReadOnly = True
                grid.Enabled = False
        End Select
    End Sub

    Public Sub addNewRecord()
        txtProdnDate.ReadOnly = False
        cboShift.ReadOnly = False
        cboLot.ReadOnly = False
        cboSublot.ReadOnly = False
        txtProdnDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        displayFishLotWithdrawn(txtProdnDate.Value, cboShift.Text)


        displayProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboSublot.Text)
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        computeContent()

        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                buttons(0)
                dataEntry(0)
                addNewRecord()
                txtProdnDate.SelectAll()
                txtProdnDate.Focus()
            Case Else ' "&Save"
                If Not cboLot.Text.Trim = "" And Not cboSublot.Text.Trim = "" And grid.RowCount > 0 And validateSpecie() Then
                    If Not isDataEntryFieldsAreEmpty() Then     'And Not isFishBinFoundDuplicate() Then
                        If getRetortCode(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboSublot.Text) = "" Then
                            reply = MsgBox("Are you sure you want to add this records?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                            If reply = vbYes Then
                                saveNewProduction(txtProdnDate.Value, cboShift.Text, cboLot.Text, lblLotStatus.Text, cboSublot.Text)

                                Dim ctr As Integer
                                While ctr < grid.RowCount
                                    If Not grid.Item(ctr, 0) Is DBNull.Value Then
                                        If CStr(grid.Item(ctr, 0)) = "-1" Or CStr(grid.Item(ctr, 0)) = "True" Then
                                            saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                                grid.Item(ctr, 1), grid.Item(ctr, 7), grid.Item(ctr, 8), grid.Item(ctr, 9), _
                                                grid.Item(ctr, 4), grid.Item(ctr, 5), grid.Item(ctr, 3), grid.Item(ctr, 10), _
                                                grid.Item(ctr, 11), grid.Item(ctr, 2), "-1", cboSublot.Text)
                                        Else
                                            saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                                grid.Item(ctr, 1), grid.Item(ctr, 7), grid.Item(ctr, 8), grid.Item(ctr, 9), _
                                                grid.Item(ctr, 4), grid.Item(ctr, 5), grid.Item(ctr, 3), grid.Item(ctr, 10), _
                                                grid.Item(ctr, 11), grid.Item(ctr, 2), "0", cboSublot.Text)
                                        End If
                                    Else
                                        saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                                grid.Item(ctr, 1), grid.Item(ctr, 7), grid.Item(ctr, 8), grid.Item(ctr, 9), _
                                                grid.Item(ctr, 4), grid.Item(ctr, 5), grid.Item(ctr, 3), grid.Item(ctr, 10), _
                                                grid.Item(ctr, 11), grid.Item(ctr, 2), "0", cboSublot.Text)
                                    End If
                                    'saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                    '    grid.Item(ctr, 0), grid.Item(ctr, 2), grid.Item(ctr, 3), grid.Item(ctr, 4), _
                                    '    grid.Item(ctr, 5), grid.Item(ctr, 6), grid.Item(ctr, 8), grid.Item(ctr, 9), _
                                    '    grid.Item(ctr, 10), grid.Item(ctr, 1))

                                    'saveNewProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                    '    grid.Item(ctr, 0), "", "", "", "", "", "", "", "", "", "", "")

                                    ctr += 1
                                End While

                                MsgBox("You have successfully save the transaction", MsgBoxStyle.Information, "Information")
                                cmd.Text = "&Add"
                                cmdEdit.Text = "&Edit"
                                buttons(1)
                                dataEntry(1)
                                'displayProductionDetails_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, True)
                                '---showMRN(True)
                                'gridMRN2.Focus()
                            Else
                                Exit Sub
                            End If
                        Else
                            'MsgBox("To edit the following meat utilization, please contact your Supervisor or Manager for more details", MsgBoxStyle.Exclamation, "Warning")
                            'reply = MsgBox("To edit the following meat utilization, please contact your Supervisor or Manager for more details" & Chr(13) & _
                            '    "Would you like to proceed for Materials Reference Number (MRN) details?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Warning")
                            'If reply = vbYes Then
                            '    showMRN(True)
                            'End If

                            '***********************************************************************
                            '******* IT WAS REMOVE THE BELOW CODE JUST TO GIVE WAY THE ONE TIME ENCODING FOR THE SYSTEM
                            '***********************************************************************
                            reply = MsgBox("Production output details are already stored in the database" & Chr(13) & _
                                "To update, please click YES to proceed but please make sure you have properly coordinated this matter to your supervisor", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")

                            If reply = vbYes Then
                                showValidationMenu(True)
                            Else
                                txtProdnDate.Focus()
                                Exit Sub
                            End If

                            '***********************************************************************
                            '***********************************************************************
                        End If
                    End If
                Else
                    MsgBox("Please review some of the data entry fields and " & Chr(13) & _
                        "the specie of the product, it should match with the specie in the cannery acceptance record", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtProdnDate.SelectAll()
                    txtProdnDate.Focus()
                End If
        End Select
    End Sub

    Public Function validateSpecie() As Boolean
        Dim ctr As Integer
        Dim returnValue As Boolean
        With grid
            While ctr < .RowCount
                If (CStr(.Item(ctr, 1)).IndexOf("M")) > 0 Then
                    returnValue = True
                Else
                    If validateSpecieByLotWithdrawn(txtProdnDate.Text, cboShift.Text, cboLot.Text, getProductSpecie(grid.Item(ctr, 1))) Then
                        returnValue = True
                    Else
                        returnValue = False
                        Exit While
                    End If
                End If

                ctr += 1
            End While
        End With

        Return returnValue
    End Function
    'Public Sub updateEntry()
    '    Dim reply As String
    '    If grid.RowCount > 0 And Not isDataEntryFieldsAreEmpty() And Not isFishBinFoundDuplicate() Then
    '        reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
    '        If reply = vbYes Then
    '            deleteProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text)

    '            Dim ctr As Integer
    '            While ctr < grid.RowCount
    '                saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
    '                    grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2), grid.Item(ctr, 3), _
    '                    grid.Item(ctr, 4), grid.Item(ctr, 7), "", "", "", "", "", "", "", "", "", "")

    '                ctr += 1
    '            End While
    '            cmd.Text = "&Add"
    '            cmdEdit.Text = "&Edit"
    '            buttons(1)
    '            dataEntry(1)

    '            displayProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text)
    '            'displayDefects()
    '            MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
    '            cmd.Focus()
    '        End If
    '    Else
    '        MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
    '        txtProdnDate.SelectAll()
    '        txtProdnDate.Focus()
    '    End If
    'End Sub

    Public Function isDataEntryFieldsAreEmpty() As Boolean
        Try
            Dim ctr As Integer = 0
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 1) = "" Or .Item(ctr, 2) = "" Or .Item(ctr, 5) = "" Or .Item(ctr, 6) = "" Or .Item(ctr, 7) = "" Or .Item(ctr, 9) = "" Then
                        MsgBox("Please check your data entry fields such as Product Code, BBE, quantity and fill weight, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                    End If

                    ctr += 1
                End While
            End With

            Return False
        Catch e As Exception
            Dim ctr As Integer = 0
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 1) Is DBNull.Value Or .Item(ctr, 2) Is DBNull.Value Or .Item(ctr, 5) Is DBNull.Value Or .Item(ctr, 6) Is DBNull.Value Or .Item(ctr, 7) Is DBNull.Value Or .Item(ctr, 9) Is DBNull.Value Then
                        MsgBox("Please check your data entry fields such as Product Code, BBE, quantity and fill weight, this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
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

    'Public Function isFishBinFoundDuplicate() As Boolean
    '    Dim outer As Integer
    '    Dim inner As Integer
    '    With grid
    '        While outer < .RowCount
    '            'If isFishBinFoundDuplicate(.Item(ctr, 0), ctr) Then
    '            '    Return True
    '            'End If

    '            inner = outer + 1
    '            While inner < .RowCount
    '                If Not .Item(outer, 0) Is DBNull.Value And Not .Item(inner, 0) Is DBNull.Value Then
    '                    If .Item(outer, 0) = .Item(inner, 0) And .Item(outer, 1) = .Item(inner, 1) And .Item(outer, 5) = .Item(inner, 5) Then
    '                        MsgBox("You have a multiple entries of Product code in the lists." & Chr(13) & _
    '                            "Please remove Product Code " & .Item(outer, 0) & " on row " & inner + 1 & " in the grid", MsgBoxStyle.Exclamation, "Warning")
    '                        Return True
    '                    End If
    '                End If

    '                inner += 1
    '            End While

    '            outer += 1
    '        End While
    '    End With

    '    Return False
    'End Function

    Public Sub displayProductionDetails(ByVal prodnDate As String, ByVal shift As String, ByVal lot As String, ByVal sublot As String)
        With grid
            .DataSource = getRetortDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, sublot).Tables(0)

            .Columns(0).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            '.Columns(0).DefaultValue = 0
            .Splits(0).DisplayColumns(0).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            displayProduct()
            .Columns(1).DropDown = cboProduct
            .Columns(7).DropDown = cboUnitPerCase
            displayUnitPerCase()

            .Splits(0).DisplayColumns(1).DropDownList = True
            .Splits(0).DisplayColumns(7).DropDownList = True
            '.Splits(0).DisplayColumns(0).Width = 150
            '.Splits(0).DisplayColumns(1).Width = 346
            '.Splits(0).DisplayColumns(2).Locked = True 
            '.Splits(0).DisplayColumns(2).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(3).Locked = True
            '.Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(5).Locked = True
            .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(6).Locked = True
            .Splits(0).DisplayColumns(6).Style.BackColor = Color.Gray
            .Splits(0).DisplayColumns(7).Locked = True
            .Splits(0).DisplayColumns(7).Style.BackColor = Color.Gray

            .Columns(3).DefaultValue = 0
            .Columns(3).NumberFormat = "###,###,##0"
            .Columns(4).DefaultValue = 0
            .Columns(4).NumberFormat = "###,###,##0"
            .Columns(5).DefaultValue = 0
            .Columns(6).DefaultValue = 0
            .Columns(6).NumberFormat = "###,###,##0.#0"
            '.Splits(0).DisplayColumns(5).Locked = True
            '.Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
            '.Columns(6).NumberFormat = "0"
            .Splits(0).DisplayColumns(8).Locked = True
            .Splits(0).DisplayColumns(8).Style.BackColor = Color.Gray
            '.Columns(7).DefaultValue = 0
            '.Columns(7).NumberFormat = "###,###,##0.#0"
            '.Columns(8).DefaultValue = 0
            .Columns(9).NumberFormat = "dd/MM/yyyy"
            .Splits(0).DisplayColumns(9).Locked = True
            .Splits(0).DisplayColumns(9).Style.BackColor = Color.Gray
            .Columns(10).DefaultValue = 0
            .Columns(10).NumberFormat = "###,###,##0.0"
            .Splits(0).DisplayColumns(10).Locked = True
            .Splits(0).DisplayColumns(10).Style.BackColor = Color.Gray
            .Columns(11).DefaultValue = 0
            .Columns(11).NumberFormat = "###,###,##0.0"
            .Splits(0).DisplayColumns(11).Locked = True
            .Splits(0).DisplayColumns(11).Style.BackColor = Color.Gray
            '.Columns(10).DefaultValue = 0
            '.Columns(10).NumberFormat = "###,###,##0.0"

            .Splits(0).DisplayColumns(0).Width = 55
            .Splits(0).DisplayColumns(1).Width = 113
            .Splits(0).DisplayColumns(2).Width = 100
            .Splits(0).DisplayColumns(3).Width = 90
            .Splits(0).DisplayColumns(4).Width = 90
            .Splits(0).DisplayColumns(5).Width = 90

            '************************************************************************************************
            '.Splits(0).DisplayColumns(0).DropDownList = True
            '.Splits(0).DisplayColumns(6).DropDownList = True
            ''.Splits(0).DisplayColumns(0).Width = 150
            ''.Splits(0).DisplayColumns(1).Width = 346
            '.Splits(0).DisplayColumns(2).Locked = True
            '.Splits(0).DisplayColumns(2).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(3).Locked = True
            '.Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(4).Locked = True
            '.Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
            ''.Splits(0).DisplayColumns(5).Locked = True
            ''.Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(6).Locked = True
            '.Splits(0).DisplayColumns(6).Style.BackColor = Color.Gray

            '.Columns(5).DefaultValue = 0
            '.Columns(5).NumberFormat = "###,###,##0"
            ''.Splits(0).DisplayColumns(5).Locked = True
            ''.Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
            '.Columns(6).NumberFormat = "0"
            '.Splits(0).DisplayColumns(7).Locked = True
            '.Splits(0).DisplayColumns(7).Style.BackColor = Color.Gray
            '.Columns(7).DefaultValue = 0
            '.Columns(7).NumberFormat = "###,###,##0.#0"
            '.Columns(8).DefaultValue = 0
            '.Columns(8).NumberFormat = "###,###,##0.0"
            '.Splits(0).DisplayColumns(8).Locked = True
            '.Splits(0).DisplayColumns(8).Style.BackColor = Color.Gray
            '.Columns(9).DefaultValue = 0
            '.Columns(9).NumberFormat = "###,###,##0.0"
            '.Splits(0).DisplayColumns(9).Locked = True
            '.Splits(0).DisplayColumns(9).Style.BackColor = Color.Gray
            '.Columns(10).DefaultValue = 0
            '.Columns(10).NumberFormat = "###,###,##0.0"
            '.Splits(0).DisplayColumns(10).Locked = True
            '.Splits(0).DisplayColumns(10).Style.BackColor = Color.Gray
            ''.Columns(10).DefaultValue = 0
            ''.Columns(10).NumberFormat = "###,###,##0.0"

            '.Splits(0).DisplayColumns(0).Width = 120
            '.Splits(0).DisplayColumns(1).Width = 100
            '.Splits(0).DisplayColumns(2).Width = 90
            '.Splits(0).DisplayColumns(3).Width = 90
            '.Splits(0).DisplayColumns(4).Width = 143
            '************************************************************************************************

            computeNoOfCases()

            'dummy()
            'displayProductionDetails_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, False)
        End With
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboLot.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    txtProdnDate.ReadOnly = True
                    cboShift.ReadOnly = True
                    cboLot.ReadOnly = True
                    cboSublot.ReadOnly = True
                    grid.Focus()
                Else
                    MsgBox("Please review some of the data entry fields because it shouldn't be left empty", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cmdFind.Focus()
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                dataEntry(1)
                cmdEdit.Focus()
        End Select
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        checkLotStatusForFZBag()

        displaySublot(txtProdnDate.Text, cboShift.Text, cboLot.Text)

        displayProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboSublot.Text)
    End Sub

    Public Sub computeNoOfCases()
        Dim ctr As Integer
        While ctr < grid.RowCount
            If Not grid.Item(ctr, 4) Is DBNull.Value Then
                grid.Item(ctr, 6) = CDbl(grid.Item(ctr, 4)) / grid.Item(ctr, 5)
            Else
                grid.Item(ctr, 6) = 0 / grid.Item(ctr, 5)
            End If

            ctr += 1
        End While
        'While ctr < grid.RowCount
        '    If Not grid.Item(ctr, 5) Is DBNull.Value Then
        '        grid.Item(ctr, 7) = CDbl(grid.Item(ctr, 5)) / grid.Item(ctr, 6)
        '    Else
        '        grid.Item(ctr, 7) = 0 / grid.Item(ctr, 6)
        '    End If

        '    ctr += 1
        'End While

        computePackedLoins()
    End Sub

    Public Sub showMRN(ByVal show As Boolean)
        If show Then
            Label1.Text = "MRN Transaction"
            Label4.Visible = False
            txtProdnDate.ReadOnly = True
            cboShift.ReadOnly = True
            cboLot.Visible = False

            '**** USE THIS CRITERIA TO VALIDATE WHAT'S ACTIVE OR NOT FOR THE DAY
            'gridAvailableMRN.DataSource = displayMRNAvailable().Tables(0)
            'validateMaterialsForTheDay()

            'Me.TabControl1.SelectedIndex = 0

            'grpMRN2.Enabled = True
            'grpMRN2.Visible = True

            'displayAllMRN()
            'displayAllProductsPerMRNCategory()
        Else
            Label1.Text = "Production Output Data"
            Label4.Visible = True
            txtProdnDate.ReadOnly = False
            cboShift.ReadOnly = False
            cboLot.Visible = True

            'grpMRN2.Enabled = False
            'grpMRN2.Visible = False
        End If
    End Sub

    Private Sub cmdClose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        showMRN(False)
        txtProdnDate.SelectAll()
        txtProdnDate.Focus()
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Dim reply As String
        '    reply = MsgBox("Would you like to save any changes you made for MRN details about the following products?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        '    If reply = vbYes Then
        '        'deleteProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text)

        '        'Dim ctr As Integer
        '        'While ctr < gridMRN.RowCount
        '        '    saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
        '        '        grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2), grid.Item(ctr, 3), _
        '        '        grid.Item(ctr, 4), grid.Item(ctr, 7), gridMRN.Item(ctr, 2), gridMRN.Item(ctr, 3), _
        '        '        gridMRN.Item(ctr, 4), gridMRN.Item(ctr, 5), gridMRN.Item(ctr, 6), gridMRN.Item(ctr, 7), _
        '        '        gridMRN.Item(ctr, 8), gridMRN.Item(ctr, 9), gridMRN.Item(ctr, 10))

        '        '    ctr += 1
        '        'End While

        '        '************************************************************************************************
        '        'FOR REVIEW TOMORROW MAY 15, 2011
        '        '************************************************************************************************
        '        Dim code, mrn As Integer
        '        mrn = 0
        '        While mrn < gridMRN.RowCount
        '            'code = 0
        '            'While code < grid.RowCount
        '            '    If gridMRN.Item(mrn, 0) = grid.Item(code, 0) And CDbl(gridMRN.Item(mrn, 1)) = CDbl(grid.Item(code, 4)) Then
        '            updateProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, gridMRN.Item(mrn, 0), _
        '                gridMRN.Item(mrn, 1), gridMRN.Item(mrn, 2), gridMRN.Item(mrn, 3), gridMRN.Item(mrn, 5), _
        '                gridMRN.Item(mrn, 6), gridMRN.Item(mrn, 7), gridMRN.Item(mrn, 8), gridMRN.Item(mrn, 9), _
        '                gridMRN.Item(mrn, 10), gridMRN.Item(mrn, 11), gridMRN.Item(mrn, 4))
        '            'saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
        '            '    grid.Item(code, 0), grid.Item(code, 1), grid.Item(code, 2), grid.Item(code, 3), _
        '            '    grid.Item(code, 4), grid.Item(code, 7), gridMRN.Item(mrn, 2), gridMRN.Item(mrn, 3), _
        '            '    gridMRN.Item(mrn, 4), gridMRN.Item(mrn, 5), gridMRN.Item(mrn, 6), _
        '            '    gridMRN.Item(mrn, 7), gridMRN.Item(mrn, 8), gridMRN.Item(mrn, 9), gridMRN.Item(mrn, 10))
        '            '    Else
        '            '        'saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
        '            '        '    grid.Item(code, 0), grid.Item(code, 1), grid.Item(code, 2), grid.Item(code, 3), _
        '            '        '    grid.Item(code, 4), grid.Item(code, 7), "", "", "", "", "", "", "", "", "")
        '            '    End If

        '            '    code += 1
        '            'End While

        '            mrn += 1
        '        End While
        '        '************************************************************************************************

        '        cmd.Text = "&Add"
        '        cmdEdit.Text = "&Edit"
        '        buttons(1)
        '        dataEntry(1)

        '        displayProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text)
        '        MsgBox("Transaction successfully completed", MsgBoxStyle.Information, "Information")
        '        showMRN(False)
        '        cmd.Focus()
        '    Else
        '        cmdClose2.Focus()
        '    End If
    End Sub

    'Public Sub displayProductionDetails_MRN(ByVal prodnDate As String, ByVal shift As String, _
    'ByVal lot As String, ByVal add As Boolean)
    '    With gridMRN
    '        'If add Then
    '        .DataSource = modModule.getProductionDetails_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text).Tables(0)
    '        'Else
    '        'End If

    '        displayMRN()
    '        .Columns(2).DropDown = cboMRNCan
    '        .Splits(0).DisplayColumns(2).DropDownList = True
    '        .Columns(3).DropDown = cboMRNEnd
    '        .Splits(0).DisplayColumns(3).DropDownList = True
    '        .Columns(4).DropDown = cboMRNBag
    '        .Splits(0).DisplayColumns(4).DropDownList = True
    '        .Columns(5).DropDown = cboMRNSBO
    '        .Splits(0).DisplayColumns(5).DropDownList = True
    '        .Columns(6).DropDown = cboMRNBVO
    '        .Splits(0).DisplayColumns(6).DropDownList = True
    '        .Columns(7).DropDown = cboMRNCur
    '        .Splits(0).DisplayColumns(7).DropDownList = True
    '        .Columns(8).DropDown = cboMRNChili
    '        .Splits(0).DisplayColumns(8).DropDownList = True
    '        .Columns(9).DropDown = cboMRNDCF
    '        .Splits(0).DisplayColumns(9).DropDownList = True
    '        .Columns(10).DropDown = cboMRNSalt
    '        .Splits(0).DisplayColumns(10).DropDownList = True
    '        .Columns(11).DropDown = cboMRNFCF
    '        .Splits(0).DisplayColumns(11).DropDownList = True

    '        .Splits(0).DisplayColumns(0).Locked = True
    '        .Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray
    '        .Splits(0).DisplayColumns(1).Locked = True
    '        .Splits(0).DisplayColumns(1).Style.BackColor = Color.Gray

    '        .Columns(1).NumberFormat = "###,###,##0"

    '        .Splits(0).DisplayColumns(0).Width = 100
    '        .Splits(0).DisplayColumns(2).Width = 140
    '        .Splits(0).DisplayColumns(3).Width = 140
    '        .Splits(0).DisplayColumns(4).Width = 140
    '        .Splits(0).DisplayColumns(5).Width = 140
    '        .Splits(0).DisplayColumns(6).Width = 140
    '        .Splits(0).DisplayColumns(7).Width = 140
    '        .Splits(0).DisplayColumns(8).Width = 140
    '        .Splits(0).DisplayColumns(9).Width = 140
    '        .Splits(0).DisplayColumns(10).Width = 140
    '        .Splits(0).DisplayColumns(11).Width = 140

    '        validateMRN()
    '    End With
    'End Sub

    'Public Sub displayMRN()
    '    With Me
    '        .cboMRNCan.DefColWidth = 120
    '        .cboMRNCan.DataSource = modModule.getMRN_Classification("Can").Tables(0)

    '        .cboMRNEnd.DefColWidth = 120
    '        .cboMRNEnd.DataSource = modModule.getMRN_Classification("End").Tables(0)

    '        .cboMRNBag.DefColWidth = 120
    '        .cboMRNBag.DataSource = modModule.getMRN_Classification("Bag").Tables(0)

    '        .cboMRNSBO.DefColWidth = 120
    '        .cboMRNSBO.DataSource = modModule.getMRN_Classification("Soya").Tables(0)

    '        .cboMRNBVO.DefColWidth = 120
    '        .cboMRNBVO.DataSource = modModule.getMRN_Classification("Blended Veg").Tables(0)

    '        .cboMRNCur.DefColWidth = 120
    '        .cboMRNCur.DataSource = modModule.getMRN_Classification("Curry").Tables(0)

    '        .cboMRNChili.DefColWidth = 120
    '        .cboMRNChili.DataSource = modModule.getMRN_Classification("Chili Powder").Tables(0)

    '        .cboMRNDCF.DefColWidth = 120
    '        .cboMRNDCF.DataSource = modModule.getMRN_Classification("Chili Dried").Tables(0)

    '        .cboMRNSalt.DefColWidth = 120
    '        .cboMRNSalt.DataSource = modModule.getMRN_Classification("Salt").Tables(0)

    '        .cboMRNFCF.DefColWidth = 120
    '        .cboMRNFCF.DataSource = modModule.getMRN_Classification("Chili Fresh").Tables(0)
    '    End With
    'End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        displayProdnYear()

        displayFishLotWithdrawn(txtProdnDate.Value, cboShift.Text)
        displaySublot(txtProdnDate.Text, cboShift.Text, cboLot.Text)

        displayProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboSublot.Text)
    End Sub

    'Private Sub transferItems()
    '    Dim ctr As Integer
    '    While ctr < gridMRN.RowCount
    '        gridMRN.Item(ctr, 0) = grid.Item(ctr, 0)
    '        gridMRN.Item(ctr, 1) = grid.Item(ctr, 4)
    '        ctr += 1
    '    End While
    'End Sub

    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                Dim reply As String = MsgBox("Are you sure you want to delete this row?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    Dim row As Integer = grid.Row
                    grid.Delete(row)

                    'If grid.Row < gridMRN.RowCount Then gridMRN.Delete(row)
                End If
                'ElseIf e.KeyCode = Keys.U Then
                '    Try
                '        If Not grid.Item(grid.Row, 0) = "" Then
                '            'If Not CStr(grid.Item(grid.Row, 0)).StartsWith("L") And Not CStr(grid.Item(grid.Row, 0)).StartsWith("F") And Not CStr(grid.Item(grid.Row, 0)).StartsWith("R") Then
                '            showQuantity(True)
                '            If CStr(grid.Item(grid.Row, 0)).StartsWith("R") Or CStr(grid.Item(grid.Row, 0)).StartsWith("F") Then
                '                txtOperCase.Text = "1"
                '            Else
                '                txtOperCase.Text = getCansPerCase(getProductCanSize(grid.Item(grid.Row, 0)), "CAN SIZE")
                '            End If

                '            txtLayer.Text = getCansPerCase(getProductCanSize(grid.Item(grid.Row, 0)), "LAYER")
                '            txtTinsPerLayer.Text = getCansPerCase(getProductCanSize(grid.Item(grid.Row, 0)), "PER LAYER")
                '            txtOCases.SelectAll()
                '            txtOCases.Focus()
                '            'End If
                '        End If
                '    Catch mali As Exception
                '        MsgBox("Please identify the product code", MsgBoxStyle.Exclamation, "Warning")
                '        grid.Focus()
                '    End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning")
        End Try
    End Sub

    'Private Sub gridMRN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Delete Then
    '        gridMRN.Item(gridMRN.Row, gridMRN.Col) = ""
    '    End If
    'End Sub

    'Public Sub validateMRN()
    '    Dim ctr As Integer
    '    With gridMRN
    '        While ctr < .RowCount
    '            If CStr(getProductCode_Type(.Item(ctr, 0))).StartsWith("Frozen") Then
    '                .Item(ctr, 2) = ""
    '                .Item(ctr, 3) = ""
    '                .Item(ctr, 5) = ""
    '                .Item(ctr, 6) = ""
    '                .Item(ctr, 7) = ""
    '                .Item(ctr, 8) = ""
    '                .Item(ctr, 9) = ""
    '                .Item(ctr, 11) = ""

    '                .Splits(0).DisplayColumns(2).Locked = True
    '                .Splits(0).DisplayColumns(2).Style.BackColor = Color.Gray
    '                .Splits(0).DisplayColumns(3).Locked = True
    '                .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
    '                .Splits(0).DisplayColumns(4).Locked = False
    '                .Splits(0).DisplayColumns(4).Style.BackColor = Color.White
    '                .Splits(0).DisplayColumns(5).Locked = True
    '                .Splits(0).DisplayColumns(5).Style.BackColor = Color.Gray
    '                .Splits(0).DisplayColumns(6).Locked = True
    '                .Splits(0).DisplayColumns(6).Style.BackColor = Color.Gray
    '                .Splits(0).DisplayColumns(7).Locked = True
    '                .Splits(0).DisplayColumns(7).Style.BackColor = Color.Gray
    '                .Splits(0).DisplayColumns(8).Locked = True
    '                .Splits(0).DisplayColumns(8).Style.BackColor = Color.Gray
    '                .Splits(0).DisplayColumns(9).Locked = True
    '                .Splits(0).DisplayColumns(9).Style.BackColor = Color.Gray
    '                .Splits(0).DisplayColumns(11).Locked = True
    '                .Splits(0).DisplayColumns(11).Style.BackColor = Color.Gray
    '            Else
    '                .Splits(0).DisplayColumns(2).Locked = False
    '                .Splits(0).DisplayColumns(2).Style.BackColor = Color.White
    '                .Splits(0).DisplayColumns(3).Locked = False
    '                .Splits(0).DisplayColumns(3).Style.BackColor = Color.White
    '                .Splits(0).DisplayColumns(4).Locked = True
    '                .Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
    '                .Splits(0).DisplayColumns(5).Locked = False
    '                .Splits(0).DisplayColumns(5).Style.BackColor = Color.White
    '                .Splits(0).DisplayColumns(6).Locked = False
    '                .Splits(0).DisplayColumns(6).Style.BackColor = Color.White
    '                .Splits(0).DisplayColumns(7).Locked = False
    '                .Splits(0).DisplayColumns(7).Style.BackColor = Color.White
    '                .Splits(0).DisplayColumns(8).Locked = False
    '                .Splits(0).DisplayColumns(8).Style.BackColor = Color.White
    '                .Splits(0).DisplayColumns(9).Locked = False
    '                .Splits(0).DisplayColumns(9).Style.BackColor = Color.White
    '                .Splits(0).DisplayColumns(11).Locked = False
    '                .Splits(0).DisplayColumns(11).Style.BackColor = Color.White
    '            End If

    '            ctr += 1
    '        End While
    '    End With
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim ctr As Integer
    '    While ctr < lstProduct.ListCount
    '        If lstProduct.GetSelected(ctr) Then
    '            MsgBox(lstProduct.GetItemText(ctr, 0))
    '        End If
    '        ctr += 1
    '    End While
    'End Sub

    'Public Sub displayAllMRN()
    '    With Me
    '        .cboT1Can.DefColWidth = 355
    '        .cboT2Ends.DefColWidth = 355
    '        .cboT3Cartons.DefColWidth = 355
    '        .cboT4Labels.DefColWidth = 355
    '        .cboT5Oil.DefColWidth = 355
    '        .cboT6Salt.DefColWidth = 355
    '        .cboT7ChiliFruit.DefColWidth = 355
    '        .cboT8ChiliPowder.DefColWidth = 355
    '        .cboT9Curry.DefColWidth = 355
    '        .cboT10Broth.DefColWidth = 355
    '        .cboT11MSG.DefColWidth = 355

    '        .cboT1Can.DataSource = getAllMRNNoAvailable("%Bod%").Tables(0)
    '        .cboT2Ends.DataSource = getAllMRNNoAvailable("%End%").Tables(0)
    '        .cboT3Cartons.DataSource = getAllMRNNoAvailable("%cart%").Tables(0)
    '        .cboT4Labels.DataSource = getAllMRNNoAvailable("%label%").Tables(0)
    '        .cboT5Oil.DataSource = getAllMRNNoAvailable("%oil%").Tables(0)
    '        .cboT6Salt.DataSource = getAllMRNNoAvailable("%salt%").Tables(0)
    '        .cboT7ChiliFruit.DataSource = getAllMRNNoAvailable("%chili fr%").Tables(0)
    '        .cboT8ChiliPowder.DataSource = getAllMRNNoAvailable("%chili pow%").Tables(0)
    '        .cboT9Curry.DataSource = getAllMRNNoAvailable("%cur%").Tables(0)
    '        .cboT10Broth.DataSource = getAllMRNNoAvailable("%broth%").Tables(0)
    '        .cboT11MSG.DataSource = getAllMRNNoAvailable("%msg%").Tables(0)
    '    End With
    'End Sub

    'Public Sub displayAllProductsPerMRNCategory()
    '    'CAN SIZE
    '    With gridT1Can
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Can", getMRN_MatDesc_byCode(cboT1Can.Text, "Can")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With

    '    'CAN SIZE/ FROZEN LOINS
    '    With Me.gridT2Ends
    '        .FetchRowStyles = True
    '        If getMRN_MatDesc_byCode(Me.cboT2Ends.Text, "End").IndexOf("can") Then
    '            .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "End", "%can%").Tables(0)
    '        ElseIf getMRN_MatDesc_byCode(Me.cboT2Ends.Text, "End").IndexOf("loin") Then
    '            .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "End", "%loin%").Tables(0)
    '        Else
    '            .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "End", "").Tables(0)
    '        End If
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With

    '    With Me.gridT3Cartons
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetails(txtProdnDate.Value, cboShift.Text, "%").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With

    '    With Me.gridT4Labels
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetails(txtProdnDate.Value, cboShift.Text, "%").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With

    '    '***************** OIL
    '    With Me.gridT5Oil
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Oil", getMRN_MatDesc_byCode(Me.cboT5Oil.Text, "Oil")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With

    '    '************** SALT
    '    With Me.gridT6Salt
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Salt", "%").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    '    '************** CHILI FRUIT
    '    With Me.gridT7ChiliFruit
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "CF", "Chili").Tables(0)  'getMRN_MatDesc_byCode(Me.cboT7ChiliFruit.Text, "CF")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    '    '********** CHILI POWDER
    '    With Me.gridT8ChiliPowder
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "CP", "Chili").Tables(0)  'getMRN_MatDesc_byCode(Me.cboT7ChiliFruit.Text, "CP")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    '    '********** CURRY POWDER
    '    With Me.gridT9Curry
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Curry", "Curry").Tables(0)  'getMRN_MatDesc_byCode(Me.cboT7ChiliFruit.Text, "CP")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    '    '******* BROTH
    '    With Me.gridT10Broth
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Broth", "%").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    '    '*********** MSG
    '    With Me.gridT11MSG
    '        .FetchRowStyles = True
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "MSG", "%").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub

    'Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim reply As String
    '    reply = MsgBox("Are you sure you want to save the following MRN's to the product produced for the day?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
    '    If reply = vbYes Then
    '        If Not validateEntries("Can") Then
    '            MsgBox("Please make sure you properly identify the MRN for Can or Bag Size, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '            Exit Sub
    '        Else
    '            'If validateUsage(gridT1Can, txtT1Usage) Then
    '            updateMRN(gridT1Can, "Can", cboT1Can.Text, txtT1Usage.Text)
    '            'Else
    '            'MsgBox("Total usage must be greater than the actual qty shown in the table", MsgBoxStyle.Exclamation, "Warning")
    '            'txtT1Usage.SelectAll()
    '            'txtT1Usage.Focus()
    '            'Exit Sub
    '            'End If

    '            If Not validateEntries("End") Then
    '                MsgBox("Please make sure you properly identify the MRN for Can Ends, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                Exit Sub
    '            Else
    '                updateMRN(gridT2Ends, "End", cboT2Ends.Text, txtT2Usage.Text)

    '                If Not validateEntries("Carton") Then
    '                    MsgBox("Please make sure you properly identify the MRN for Cartons, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                    Exit Sub
    '                Else
    '                    updateMRN(gridT3Cartons, "Cartons", cboT3Cartons.Text, txtT3Usage.Text)

    '                    If Not validateEntries("Label") Then
    '                        MsgBox("Please make sure you properly identify the MRN for Label, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                        Exit Sub
    '                    Else
    '                        updateMRN(gridT4Labels, "Label", cboT4Labels.Text, txtT4Usage.Text)

    '                        If Not validateEntries("Oil") Then
    '                            MsgBox("Please make sure you properly identify the MRN for Oils, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                            Exit Sub
    '                        Else
    '                            updateMRN(gridT5Oil, "Oil", cboT5Oil.Text, txtT5Usage.Text)

    '                            If Not validateEntries("Salt") Then
    '                                MsgBox("Please make sure you properly identify the MRN for Salt, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                                Exit Sub
    '                            Else
    '                                updateMRN(gridT6Salt, "Salt", cboT6Salt.Text, txtT6Usage.Text)

    '                                If Not validateEntries("CF") Then
    '                                    MsgBox("Please make sure you properly identify the MRN for Chili Fruit, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                                    Exit Sub
    '                                Else
    '                                    updateMRN(gridT7ChiliFruit, "CF", cboT7ChiliFruit.Text, txtT7Usage.Text)

    '                                    If Not validateEntries("CP") Then
    '                                        MsgBox("Please make sure you properly identify the MRN for Chili Powder, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                                        Exit Sub
    '                                    Else
    '                                        updateMRN(gridT8ChiliPowder, "CP", cboT8ChiliPowder.Text, txtT8Usage.Text)

    '                                        If Not validateEntries("Curry") Then
    '                                            MsgBox("Please make sure you properly identify the MRN for Curry Powder, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                                            Exit Sub
    '                                        Else
    '                                            updateMRN(gridT9Curry, "Curry", cboT9Curry.Text, txtT9Usage.Text)

    '                                            If Not validateEntries("Broth") Then
    '                                                MsgBox("Please make sure you properly identify the MRN for Broth, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                                                Exit Sub
    '                                            Else
    '                                                updateMRN(gridT10Broth, "Broth", cboT10Broth.Text, txtT10Usage.Text)

    '                                                If Not validateEntries("MSG") Then
    '                                                    MsgBox("Please make sure you properly identify the MRN for MSG, Total Usage and the Product Code", MsgBoxStyle.Critical, "Warning")
    '                                                    Exit Sub
    '                                                Else
    '                                                    updateMRN(gridT11MSG, "MSG", cboT11MSG.Text, txtT11Usage.Text)

    '                                                    MsgBox("You have successfully save all the MRN's details of the products", MsgBoxStyle.Information, "Information")

    '                                                    showMRN(False)
    '                                                    cmd.Text = "&Add"
    '                                                    cmdEdit.Text = "&Edit"
    '                                                    buttons(1)
    '                                                    dataEntry(1)
    '                                                    cmdEdit.Focus()
    '                                                End If
    '                                            End If
    '                                        End If
    '                                    End If
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Public Sub updateMRN(ByVal obj As Object, ByVal category As String, ByVal mrn As String, ByVal mrnUsage As String)
    '    Dim ctr As Integer
    '    Dim selected As Integer
    '    With obj
    '        If .SelectedRows.Count > 0 Then
    '            While selected < .SelectedRows.Count
    '                While ctr < .RowCount
    '                    If (validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, .Item(ctr, 1), .Item(ctr, 0), category)) Then

    '                        'updateProduction_Details_MRN(txtProdnDate.Text, cboShift.Text, .Item(ctr, 1), _
    '                        '    .Item(ctr, 0), category, mrn, mrnUsage)
    '                    Else
    '                        If .Item(ctr, 0) = .Item(.SelectedRows.Item(selected), 0) And .Item(ctr, 1) = .Item(.SelectedRows.Item(selected), 1) Then
    '                            updateProduction_Details_MRN(txtProdnDate.Text, cboShift.Text, .Item(.SelectedRows.Item(selected), 1), _
    '                                .Item(.SelectedRows.Item(selected), 0), category, mrn, mrnUsage)
    '                        End If

    '                    End If

    '                    ctr += 1
    '                End While

    '                selected += 1
    '            End While
    '        Else
    '            MsgBox("You have not selected to any product code in the table", MsgBoxStyle.Information, "Information")
    '            'While ctr < .RowCount
    '            '    If (validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, .Item(ctr, 1), .Item(ctr, 0), category)) Then
    '            '        updateProduction_Details_MRN(txtProdnDate.Text, cboShift.Text, .Item(ctr, 1), _
    '            '            .Item(ctr, 0), category, mrn, mrnUsage)
    '            '    End If

    '            '    ctr += 1
    '            'End While
    '        End If
    '    End With

    '    '********************************************************************************************
    '    '*************** WORKING AND FUNCTIONAL FOR SELECTED ROW ONLY IN THE TABLE *********************************************
    '    'Dim ctr As Integer
    '    'Dim selected As Integer
    '    'With obj
    '    '    If .SelectedRows.Count > 0 Then
    '    '        While selected < .SelectedRows.Count
    '    '            While ctr < .RowCount
    '    '                If (validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, .Item(ctr, 1), .Item(ctr, 0), category)) Then

    '    '                    'updateProduction_Details_MRN(txtProdnDate.Text, cboShift.Text, .Item(ctr, 1), _
    '    '                    '    .Item(ctr, 0), category, mrn, mrnUsage)
    '    '                Else
    '    '                    If .Item(ctr, 0) = .Item(.SelectedRows.Item(selected), 0) And .Item(ctr, 1) = .Item(.SelectedRows.Item(selected), 1) Then
    '    '                        updateProduction_Details_MRN(txtProdnDate.Text, cboShift.Text, .Item(.SelectedRows.Item(selected), 1), _
    '    '                            .Item(.SelectedRows.Item(selected), 0), category, mrn, mrnUsage)
    '    '                    End If

    '    '                End If

    '    '                ctr += 1
    '    '            End While

    '    '            selected += 1
    '    '        End While
    '    '    Else
    '    '        MsgBox("You have not selected to any product code in the table", MsgBoxStyle.Information, "Information")
    '    '        'While ctr < .RowCount
    '    '        '    If (validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, .Item(ctr, 1), .Item(ctr, 0), category)) Then
    '    '        '        updateProduction_Details_MRN(txtProdnDate.Text, cboShift.Text, .Item(ctr, 1), _
    '    '        '            .Item(ctr, 0), category, mrn, mrnUsage)
    '    '        '    End If

    '    '        '    ctr += 1
    '    '        'End While
    '    '    End If
    '    'End With

    '    '********************************************************************************************
    '    '********************************************************************************************
    'End Sub

    'Public Function validateEntries(ByVal mrnTypes As String) As Boolean
    '    Select Case mrnTypes
    '        Case "Can"
    '            If flgCan Then
    '                If (countRecords(Me.gridT1Can) > 0 Or countProductWithMRN(gridT1Can, "Can") > 0) And Not Me.cboT1Can.Text.Trim = "" And Not Me.txtT1Usage.Text.Trim = "" And Not Me.txtT1Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 0
    '                    Me.cboT1Can.SelectAll()
    '                    Me.cboT1Can.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "End"
    '            If flgEnd Then
    '                If (countRecords(Me.gridT2Ends) > 0 Or countProductWithMRN(gridT2Ends, "End") > 0) And Not Me.cboT2Ends.Text.Trim = "" And Not Me.txtT2Usage.Text.Trim = "" And Not Me.txtT2Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 1
    '                    Me.cboT2Ends.SelectAll()
    '                    Me.cboT2Ends.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "Carton"
    '            If flgCarton Then
    '                If (countRecords(Me.gridT3Cartons) > 0 Or countProductWithMRN(gridT3Cartons, "Cartons") > 0) And Not Me.cboT3Cartons.Text.Trim = "" And Not Me.txtT3Usage.Text.Trim = "" And Not Me.txtT3Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 2
    '                    Me.cboT3Cartons.SelectAll()
    '                    Me.cboT3Cartons.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "Label"
    '            If flgLabel Then
    '                If (countRecords(Me.gridT4Labels) > 0 Or countProductWithMRN(gridT4Labels, "Label") > 0) And Not Me.cboT4Labels.Text.Trim = "" And Not Me.txtT4Usage.Text.Trim = "" And Not Me.txtT4Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 3
    '                    Me.cboT4Labels.SelectAll()
    '                    Me.cboT4Labels.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "Oil"
    '            If flgOil Then
    '                If (countRecords(Me.gridT5Oil) > 0 Or countProductWithMRN(gridT5Oil, "Oil") > 0) And Not Me.cboT5Oil.Text.Trim = "" And Not Me.txtT5Usage.Text.Trim = "" And Not Me.txtT5Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 4
    '                    Me.cboT5Oil.SelectAll()
    '                    Me.cboT5Oil.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "Salt"
    '            If flgSalt Then
    '                If (countRecords(Me.gridT6Salt) > 0 Or countProductWithMRN(gridT6Salt, "Salt") > 0) And Not Me.cboT6Salt.Text.Trim = "" And Not Me.txtT6Usage.Text.Trim = "" And Not Me.txtT6Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 5
    '                    Me.cboT6Salt.SelectAll()
    '                    Me.cboT6Salt.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "CF"
    '            If flgCF Then
    '                If (countRecords(Me.gridT7ChiliFruit) > 0 Or countProductWithMRN(gridT7ChiliFruit, "CF") > 0) And Not Me.cboT7ChiliFruit.Text.Trim = "" And Not Me.txtT7Usage.Text.Trim = "" And Not Me.txtT7Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 6
    '                    Me.cboT7ChiliFruit.SelectAll()
    '                    Me.cboT7ChiliFruit.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "CP"
    '            If flgCP Then
    '                If (countRecords(Me.gridT8ChiliPowder) > 0 Or countProductWithMRN(gridT8ChiliPowder, "CP") > 0) And Not Me.cboT8ChiliPowder.Text.Trim = "" And Not Me.txtT8Usage.Text.Trim = "" And Not Me.txtT8Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 7
    '                    Me.cboT8ChiliPowder.SelectAll()
    '                    Me.cboT8ChiliPowder.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "Curry"
    '            If flgCurry Then
    '                If (countRecords(Me.gridT9Curry) > 0 Or countProductWithMRN(gridT9Curry, "Curry") > 0) And Not Me.cboT9Curry.Text.Trim = "" And Not Me.txtT9Usage.Text.Trim = "" And Not Me.txtT9Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 8
    '                    Me.cboT9Curry.SelectAll()
    '                    Me.cboT9Curry.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "Broth"
    '            If flgBroth Then
    '                If (countRecords(Me.gridT10Broth) > 0 Or countProductWithMRN(gridT10Broth, "Broth") > 0) And Not Me.cboT10Broth.Text.Trim = "" And Not Me.txtT10Usage.Text.Trim = "" And Not Me.txtT10Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 9
    '                    Me.cboT10Broth.SelectAll()
    '                    Me.cboT10Broth.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Case "MSG"
    '            If flgMSG Then
    '                If (countRecords(Me.gridT11MSG) > 0 Or countProductWithMRN(gridT11MSG, "MSG") > 0) And Not Me.cboT11MSG.Text.Trim = "" And Not Me.txtT11Usage.Text.Trim = "" And Not Me.txtT11Usage.Text.Trim = "0" Then
    '                    Return True
    '                Else
    '                    Me.TabControl1.SelectedIndex = 10
    '                    Me.cboT11MSG.SelectAll()
    '                    Me.cboT11MSG.Focus()
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '    End Select
    'End Function

    'Private Sub txtT1Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT1Usage.Text) Or txtT1Usage.Text.Trim = "" Then
    '        txtT1Usage.Text = "0"
    '        txtT1Usage.SelectAll()
    '        txtT1Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT2Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT2Usage.Text) Or txtT2Usage.Text.Trim = "" Then
    '        txtT2Usage.Text = "0"
    '        txtT2Usage.SelectAll()
    '        txtT2Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT3Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT3Usage.Text) Or txtT3Usage.Text.Trim = "" Then
    '        txtT3Usage.Text = "0"
    '        txtT3Usage.SelectAll()
    '        txtT3Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT4Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT4Usage.Text) Or txtT4Usage.Text.Trim = "" Then
    '        txtT4Usage.Text = "0"
    '        txtT4Usage.SelectAll()
    '        txtT4Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT5Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT5Usage.Text) Or txtT5Usage.Text.Trim = "" Then
    '        txtT5Usage.Text = "0"
    '        txtT5Usage.SelectAll()
    '        txtT5Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT6Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT6Usage.Text) Or txtT6Usage.Text.Trim = "" Then
    '        txtT6Usage.Text = "0"
    '        txtT6Usage.SelectAll()
    '        txtT6Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT7Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT7Usage.Text) Or txtT7Usage.Text.Trim = "" Then
    '        txtT7Usage.Text = "0"
    '        txtT7Usage.SelectAll()
    '        txtT7Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT8Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT8Usage.Text) Or txtT8Usage.Text.Trim = "" Then
    '        txtT8Usage.Text = "0"
    '        txtT8Usage.SelectAll()
    '        txtT8Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT9Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT9Usage.Text) Or txtT9Usage.Text.Trim = "" Then
    '        txtT9Usage.Text = "0"
    '        txtT9Usage.SelectAll()
    '        txtT9Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT10Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT10Usage.Text) Or txtT10Usage.Text.Trim = "" Then
    '        txtT10Usage.Text = "0"
    '        txtT10Usage.SelectAll()
    '        txtT10Usage.Focus()
    '    End If
    'End Sub

    'Private Sub txtT11Usage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtT11Usage.Text) Or txtT11Usage.Text.Trim = "" Then
    '        txtT11Usage.Text = "0"
    '        txtT11Usage.SelectAll()
    '        txtT11Usage.Focus()
    '    End If
    'End Sub

    ''********* UPDATE THIS AND MAKE ONLY THOSE MRN's AVAILABLE IN THE PRODUCTION, NOT ALL THE RECORDS
    'Public Sub validateMaterialsForTheDay()
    '    disableTabs()
    '    resetFlags()

    '    Dim ctr As Integer
    '    With gridAvailableMRN
    '        While ctr < .RowCount
    '            If Not .Item(ctr, 0) Is DBNull.Value Then
    '                If CStr(.Item(ctr, 0)).StartsWith("Can Bod") Then
    '                    Me.TabControl1.TabPages(0).Enabled = True
    '                    flgCan = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("Can En") Then
    '                    Me.TabControl1.TabPages(1).Enabled = True
    '                    flgEnd = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("Cart") Then
    '                    Me.TabControl1.TabPages(2).Enabled = True
    '                    flgCarton = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("Lab") Then
    '                    Me.TabControl1.TabPages(3).Enabled = True
    '                    flgLabel = True
    '                End If

    '                If CStr(.Item(ctr, 0)).IndexOf("Oil") Then
    '                    Me.TabControl1.TabPages(4).Enabled = True
    '                    flgOil = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("Salt") Then
    '                    Me.TabControl1.TabPages(5).Enabled = True
    '                    flgSalt = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("Chili F") Then
    '                    Me.TabControl1.TabPages(6).Enabled = True
    '                    flgCF = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("Chili P") Then
    '                    Me.TabControl1.TabPages(7).Enabled = True
    '                    flgCP = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("Cur") Then
    '                    Me.TabControl1.TabPages(8).Enabled = True
    '                    flgCurry = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("Bro") Then
    '                    Me.TabControl1.TabPages(9).Enabled = True
    '                    flgBroth = True
    '                End If

    '                If CStr(.Item(ctr, 0)).StartsWith("MS") Then
    '                    Me.TabControl1.TabPages(10).Enabled = True
    '                    flgMSG = True
    '                End If

    '            End If

    '            ctr += 1
    '        End While
    '    End With
    'End Sub

    'Public Sub disableTabs()
    '    With TabControl1.TabPages
    '        .Item(0).Enabled = False
    '        .Item(1).Enabled = False
    '        .Item(2).Enabled = False
    '        .Item(3).Enabled = False
    '        .Item(4).Enabled = False
    '        .Item(5).Enabled = False
    '        .Item(6).Enabled = False
    '        .Item(7).Enabled = False
    '        .Item(8).Enabled = False
    '        .Item(9).Enabled = False
    '        .Item(10).Enabled = False
    '    End With
    'End Sub

    Public Sub resetFlags()
        flgCan = False
        flgEnd = False
        flgCarton = False
        flgLabel = False
        flgOil = False
        flgSalt = False
        flgCF = False
        flgCP = False
        flgCurry = False
        flgBroth = False
        flgMSG = False
    End Sub

    Public Function countRecords(ByVal obj As Object) As Integer
        Dim ctr As Integer
        Dim records As Integer

        '********* DATAGRID HOW TO GET THE SELECTED ROWS AND THE INDEX OF IT
        'While ctr < gridT1Can.SelectedRows.Count()
        'MsgBox(gridT1Can.Item(gridT1Can.SelectedRows().Item(ctr), 0))
        '*******************************************************************
        Return obj.SelectedRows.Count()
        'While ctr < obj.SelectedRows.Count()
        'MsgBox(obj.Item(obj.SelectedRows().Item(ctr), 0))

        '***** LIST CONTROL HOW TO GET THE SELECTED ROWS
        'While ctr < obj.RowCount
        'If obj.GetSelected(ctr) Then
        'MsgBox(obj.Item(ctr, 0))
        'End If
        '***********************************************


        'ctr += 1
        'End While
    End Function

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    countRecords(gridT1Can)
    'End Sub

    'Private Sub cboT1Can_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    With gridT1Can
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Can", getMRN_MatDesc_byCode(cboT1Can.Text, "Can")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub

    'Private Sub cboT2Ends_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    With Me.gridT2Ends
    '        If getMRN_MatDesc_byCode(Me.cboT2Ends.Text, "End").IndexOf("can") Then
    '            .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "End", "%can%").Tables(0)
    '        ElseIf getMRN_MatDesc_byCode(Me.cboT2Ends.Text, "End").IndexOf("loin") Then
    '            .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "End", "%loin%").Tables(0)
    '        Else
    '            .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "End", "").Tables(0)
    '        End If
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub

    'Private Sub cboT5Oil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    With Me.gridT5Oil
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Oil", getMRN_MatDesc_byCode(Me.cboT5Oil.Text, "Oil")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub

    'Private Sub cboT6Salt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '************** SALT
    '    With Me.gridT6Salt
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Salt", "%").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub

    'Private Sub cboT7ChiliFruit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '************** CHILI FRUIT
    '    With Me.gridT7ChiliFruit
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "CF", "Chili").Tables(0)  'getMRN_MatDesc_byCode(Me.cboT7ChiliFruit.Text, "CF")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub

    'Private Sub cboT8ChiliPowder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '********** CHILI POWDER
    '    With Me.gridT8ChiliPowder
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "CP", "Chili").Tables(0)  'getMRN_MatDesc_byCode(Me.cboT7ChiliFruit.Text, "CP")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub


    'Private Sub cboT9Curry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '********** CURRY POWDER
    '    With Me.gridT9Curry
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Curry", "Curry").Tables(0)  'getMRN_MatDesc_byCode(Me.cboT7ChiliFruit.Text, "CP")).Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub

    'Private Sub cboT10Broth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '******* BROTH
    '    With Me.gridT10Broth
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "Broth", "%").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub

    'Private Sub cboT11MSG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '*********** MSG
    '    With Me.gridT11MSG
    '        .DataSource = getProductionDetailsByMRNCategory(txtProdnDate.Value, cboShift.Text, "MSG", "%").Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 88
    '        .Splits(0).DisplayColumns(1).Width = 80
    '        .Splits(0).DisplayColumns(2).Width = 78
    '        .Splits(0).DisplayColumns(3).Width = 83
    '        .Splits(0).DisplayColumns(4).Width = 80
    '        .Splits(0).DisplayColumns(5).Width = 78
    '        .Splits(0).DisplayColumns(6).Width = 80
    '        .Splits(0).DisplayColumns(7).Width = 80
    '        .Splits(0).DisplayColumns(8).Width = 80
    '        .Splits(0).DisplayColumns(9).Width = 80
    '    End With
    'End Sub


    'Private Sub gridT1Can_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    'If gridT1Can.Columns(0).CellValue(e.Row) = "W7Y3BB" Then 'gridLot.Columns(9).CellValue(e.Row) = "For Evaluation" Then
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT1Can.Columns(1).CellValue(e.Row), gridT1Can.Columns(0).CellValue(e.Row), "Can") Then
    '        'gridPallet.Splits(0).DisplayColumns(4).Locked = False
    '        'gridPallet.Splits(0).DisplayColumns(4).Style.BackColor = Color.White
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    Public Function countProductWithMRN(ByVal obj As Object, ByVal category As String) As Integer
        Dim ctr As Integer
        Dim record As Integer
        With obj
            While ctr < .RowCount
                If (validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, .Item(ctr, 1), .Item(ctr, 0), category)) Then
                    record += 1
                End If

                ctr += 1
            End While
        End With

        Return record
    End Function

    'Private Sub gridT2Ends_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT2Ends.Columns(1).CellValue(e.Row), gridT2Ends.Columns(0).CellValue(e.Row), "End") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT3Cartons_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT3Cartons.Columns(1).CellValue(e.Row), gridT3Cartons.Columns(0).CellValue(e.Row), "Cartons") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT4Labels_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT4Labels.Columns(1).CellValue(e.Row), gridT4Labels.Columns(0).CellValue(e.Row), "Label") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT5Oil_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT5Oil.Columns(1).CellValue(e.Row), gridT5Oil.Columns(0).CellValue(e.Row), "Oil") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT6Salt_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT6Salt.Columns(1).CellValue(e.Row), gridT6Salt.Columns(0).CellValue(e.Row), "Salt") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT7ChiliFruit_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT7ChiliFruit.Columns(1).CellValue(e.Row), gridT7ChiliFruit.Columns(0).CellValue(e.Row), "CF") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT8ChiliPowder_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT8ChiliPowder.Columns(1).CellValue(e.Row), gridT8ChiliPowder.Columns(0).CellValue(e.Row), "CP") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT9Curry_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT9Curry.Columns(1).CellValue(e.Row), gridT9Curry.Columns(0).CellValue(e.Row), "Curry") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT10Broth_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT10Broth.Columns(1).CellValue(e.Row), gridT10Broth.Columns(0).CellValue(e.Row), "Broth") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    'Private Sub gridT11MSG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
    '    If validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, gridT11MSG.Columns(1).CellValue(e.Row), gridT11MSG.Columns(0).CellValue(e.Row), "MSG") Then
    '        e.CellStyle.ForeColor = System.Drawing.Color.White
    '        e.CellStyle.BackColor = System.Drawing.Color.DarkBlue
    '    Else
    '        e.CellStyle.ForeColor = System.Drawing.Color.Black
    '        e.CellStyle.BackColor = System.Drawing.Color.White
    '    End If
    'End Sub

    Public Function validateUsage(ByVal mrnObj As Object, ByVal usageObj As Object) As Boolean
        Dim ctr As Integer
        Dim qty As Double
        With mrnObj 'gridT1Can
            While ctr < .RowCount
                qty += .Item(ctr, 5)
                ctr += 1
            End While
        End With

        If CDbl(usageObj.Text) >= qty Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        showMRN(False)
        cmd.Text = "&Add"
        cmdEdit.Text = "&Edit"
        buttons(1)
        dataEntry(1)
        cmdEdit.Focus()
    End Sub

    Private Sub txtProdnDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdnDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLot.SelectAll()
            cboLot.Focus()
        End If
    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSublot.SelectAll()
            cboSublot.Focus()
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim f As New frmPrintProductionOutputDetails
        'f.fz = False
        f.txtDate.Value = txtProdnDate.Text
        f.initializeShift()
        f.cboShift.Text = cboShift.Text
        f.ShowDialog(Me)
    End Sub

    Public Sub showQuantity(ByVal show As Boolean)
        If show Then
            grid.Enabled = False
            grpQuantity.Enabled = True
            grpQuantity.Visible = True
            txtOCases.Text = "0"
            txtOTins.Text = "0"
        Else
            grid.Enabled = True
            grpQuantity.Enabled = False
            grpQuantity.Visible = False
        End If
    End Sub

    Private Sub cmdOCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOCancel.Click
        showQuantity(False)
        grid.Focus()
    End Sub

    Private Sub cmdOAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOAccept.Click
        With grid
            '.Item(.Row, 5) = (CDbl(txtOCases.Text) * txtLayer.Text * txtTinsPerLayer.Text) + txtOTins.Text
            '.Item(.Row, 6) = txtOperCase.Text
            .Item(.Row, 5) = (CDbl(txtOCases.Text) * txtOperCase.Text) + txtOTins.Text
            .Item(.Row, 6) = txtOperCase.Text
            showQuantity(False)
            computeContent()
            .Focus()
        End With
    End Sub

    Private Sub txtOCases_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOCases.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtOTins.SelectAll()
            txtOTins.Focus()
        End If
    End Sub

    Private Sub txtOTins_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOTins.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdOAccept.Focus()
        End If
    End Sub

    Private Sub txtOCases_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOCases.TextChanged
        If Not IsNumeric(txtOCases.Text) Or txtOCases.Text.Trim = "" Then
            txtOCases.Text = "0"
            txtOCases.SelectAll()
            txtOCases.Focus()
        End If
    End Sub

    Private Sub txtOTins_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOTins.TextChanged
        If Not IsNumeric(txtOTins.Text) Or txtOTins.Text.Trim = "" Then
            txtOTins.Text = "0"
            txtOTins.SelectAll()
            txtOTins.Focus()
        End If
    End Sub

    Private Sub cmdAClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAClose.Click
        showValidationMenu(False)
    End Sub

    Public Sub showValidationMenu(ByVal showMe As Boolean)
        txtUsername.Text = ""
        txtPassword.Text = ""
        Select Case showMe
            Case True
                grp.Enabled = True
                grp.Visible = True
                enableDataEntry(False)
            Case False
                grp.Enabled = False
                grp.Visible = False
                enableDataEntry(True)
        End Select

        txtUsername.SelectAll()
        txtUsername.Focus()
    End Sub

    Private Sub cmdASave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdASave.Click
        If validateOverrideAccount(txtUsername.Text, txtPassword.Text) And validateSpecie() Then
            Dim reply As String
            reply = MsgBox("Are you sure you want to update this records?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If reply = vbYes Then
                deleteProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboSublot.Text)

                Dim ctr As Integer
                While ctr < grid.RowCount
                    If Not grid.Item(ctr, 0) Is DBNull.Value Then
                        If CStr(grid.Item(ctr, 0)) = "-1" Or CStr(grid.Item(ctr, 0)) = "True" Then
                            saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                grid.Item(ctr, 1), grid.Item(ctr, 7), grid.Item(ctr, 8), grid.Item(ctr, 9), _
                                grid.Item(ctr, 4), grid.Item(ctr, 5), grid.Item(ctr, 3), grid.Item(ctr, 10), _
                                grid.Item(ctr, 11), grid.Item(ctr, 2), "-1", cboSublot.Text)
                        Else
                            saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                grid.Item(ctr, 1), grid.Item(ctr, 7), grid.Item(ctr, 8), grid.Item(ctr, 9), _
                                grid.Item(ctr, 4), grid.Item(ctr, 5), grid.Item(ctr, 3), grid.Item(ctr, 10), _
                                grid.Item(ctr, 11), grid.Item(ctr, 2), "0", cboSublot.Text)
                        End If
                    Else
                        saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                                grid.Item(ctr, 1), grid.Item(ctr, 7), grid.Item(ctr, 8), grid.Item(ctr, 9), _
                                grid.Item(ctr, 4), grid.Item(ctr, 5), grid.Item(ctr, 3), grid.Item(ctr, 10), _
                                grid.Item(ctr, 11), grid.Item(ctr, 2), "0", cboSublot.Text)
                    End If


                    'saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                    '  grid.Item(ctr, 0), grid.Item(ctr, 6), grid.Item(ctr, 7), grid.Item(ctr, 8), _
                    '  grid.Item(ctr, 3), grid.Item(ctr, 4), grid.Item(ctr, 2), grid.Item(ctr, 9), _
                    '  grid.Item(ctr, 10), grid.Item(ctr, 1), "0")

                    'saveNewProduction_Details(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                    '   grid.Item(ctr, 0), grid.Item(ctr, 2), grid.Item(ctr, 3), grid.Item(ctr, 4), _
                    '   grid.Item(ctr, 5), grid.Item(ctr, 6), grid.Item(ctr, 8), grid.Item(ctr, 9), _
                    '   grid.Item(ctr, 10), grid.Item(ctr, 1))
                    'If Not validateProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, grid.Item(ctr, 0)) Then
                    '    saveNewProduction_Details_MRN(txtProdnDate.Value, cboShift.Text, cboLot.Text, _
                    '       grid.Item(ctr, 0), "", "", "", "", "", "", "", "", "", "", "")
                    '    'End If
                    'End If

                    ctr += 1
                End While

                'showMRN(True)

                MsgBox("You have successfully modify the existing record", MsgBoxStyle.Information, "Information")
                Me.showValidationMenu(False)
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                dataEntry(1)
                cmd.Focus()
            End If
        Else
            MsgBox("You have an invalid account.  For assistance, please call your supervisor" & Chr(13) & _
                "Please check also the specie of the product, it should match with the specie in the cannery acceptance record", MsgBoxStyle.Exclamation, "Access denied")
            cmdAClose.Focus()
        End If
    End Sub

    Public Sub checkLotStatusForFZBag()
        If getLotStatus_FZBag(txtProdnDate.Text, cboShift.Text, cboLot.Text) = 1 Then
            lblLotStatus.Text = "YES"
        Else
            lblLotStatus.Text = "NO"
        End If
    End Sub

    Public Sub displaySublot(ByVal prodnDate As String, ByVal shift As String, ByVal lot As String)
        With cboSublot
            .Text = ""
            .DataSource = getSublotWithdrawnForTheDay(prodnDate, shift, lot).Tables(0)
            .DisplayMember = "Sublot"
            .Splits(0).DisplayColumns(0).Width = 78
            .Splits(0).DisplayColumns(1).Width = 50

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboSublot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSublot.TextChanged
        If cboSublot.Text = "" Then
            lblSublot.Text = ""
        ElseIf cboSublot.ListCount > 0 Then
            lblSublot.Text = cboSublot.Columns(0).Value
        Else
            lblSublot.Text = ""
        End If

        displayProductionDetails(txtProdnDate.Value, cboShift.Text, cboLot.Text, cboSublot.Text)
    End Sub

    Private Sub cboSublot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSublot.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid.Focus()
        End If
    End Sub

    Public Sub enableDataEntry(ByVal enable As Boolean)
        Select enable
            Case True
                txtProdnDate.ReadOnly = False
                cboShift.ReadOnly = False
                cboLot.ReadOnly = False
                cboSublot.ReadOnly = False
                grid.Enabled = True
            Case False
                txtProdnDate.ReadOnly = True
                cboShift.ReadOnly = True
                cboLot.ReadOnly = True
                cboSublot.ReadOnly = True
                grid.Enabled = False
        End Select
    End Sub
End Class
