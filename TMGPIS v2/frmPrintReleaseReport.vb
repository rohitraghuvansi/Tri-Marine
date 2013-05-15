Public Class frmPrintReleaseReport
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboSupervisor As C1.Win.C1List.C1Combo
    Friend WithEvents cboProdnMgr As C1.Win.C1List.C1Combo
    Friend WithEvents cboGM As C1.Win.C1List.C1Combo
    Friend WithEvents cboQCMgr As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents rptControl As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintReleaseReport))
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboSupervisor = New C1.Win.C1List.C1Combo()
        Me.cboProdnMgr = New C1.Win.C1List.C1Combo()
        Me.cboGM = New C1.Win.C1List.C1Combo()
        Me.cboQCMgr = New C1.Win.C1List.C1Combo()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.rptControl = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.cboSupervisor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProdnMgr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboQCMgr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1146, 40)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Print Release Report"
        '
        'cboSupervisor
        '
        Me.cboSupervisor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboSupervisor.AllowColMove = False
        Me.cboSupervisor.AutoCompletion = True
        Me.cboSupervisor.AutoDropDown = True
        Me.cboSupervisor.Caption = ""
        Me.cboSupervisor.CaptionHeight = 17
        Me.cboSupervisor.CaptionStyle = Style1
        Me.cboSupervisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSupervisor.ColumnCaptionHeight = 17
        Me.cboSupervisor.ColumnFooterHeight = 17
        Me.cboSupervisor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboSupervisor.ContentHeight = 18
        Me.cboSupervisor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSupervisor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSupervisor.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupervisor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSupervisor.EditorHeight = 18
        Me.cboSupervisor.EvenRowStyle = Style2
        Me.cboSupervisor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupervisor.FooterStyle = Style3
        Me.cboSupervisor.HeadingStyle = Style4
        Me.cboSupervisor.HighLightRowStyle = Style5
        Me.cboSupervisor.Images.Add(CType(resources.GetObject("cboSupervisor.Images"), System.Drawing.Image))
        Me.cboSupervisor.ItemHeight = 20
        Me.cboSupervisor.Location = New System.Drawing.Point(8, 32)
        Me.cboSupervisor.MatchEntryTimeout = CType(2000, Long)
        Me.cboSupervisor.MaxDropDownItems = CType(5, Short)
        Me.cboSupervisor.MaxLength = 32767
        Me.cboSupervisor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSupervisor.Name = "cboSupervisor"
        Me.cboSupervisor.OddRowStyle = Style6
        Me.cboSupervisor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSupervisor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSupervisor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSupervisor.SelectedStyle = Style7
        Me.cboSupervisor.Size = New System.Drawing.Size(192, 24)
        Me.cboSupervisor.Style = Style8
        Me.cboSupervisor.TabIndex = 0
        Me.cboSupervisor.PropBag = resources.GetString("cboSupervisor.PropBag")
        '
        'cboProdnMgr
        '
        Me.cboProdnMgr.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboProdnMgr.AllowColMove = False
        Me.cboProdnMgr.AutoCompletion = True
        Me.cboProdnMgr.AutoDropDown = True
        Me.cboProdnMgr.Caption = ""
        Me.cboProdnMgr.CaptionHeight = 17
        Me.cboProdnMgr.CaptionStyle = Style9
        Me.cboProdnMgr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProdnMgr.ColumnCaptionHeight = 17
        Me.cboProdnMgr.ColumnFooterHeight = 17
        Me.cboProdnMgr.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboProdnMgr.ContentHeight = 18
        Me.cboProdnMgr.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboProdnMgr.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboProdnMgr.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProdnMgr.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProdnMgr.EditorHeight = 18
        Me.cboProdnMgr.EvenRowStyle = Style10
        Me.cboProdnMgr.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProdnMgr.FooterStyle = Style11
        Me.cboProdnMgr.HeadingStyle = Style12
        Me.cboProdnMgr.HighLightRowStyle = Style13
        Me.cboProdnMgr.Images.Add(CType(resources.GetObject("cboProdnMgr.Images"), System.Drawing.Image))
        Me.cboProdnMgr.ItemHeight = 20
        Me.cboProdnMgr.Location = New System.Drawing.Point(208, 32)
        Me.cboProdnMgr.MatchEntryTimeout = CType(2000, Long)
        Me.cboProdnMgr.MaxDropDownItems = CType(5, Short)
        Me.cboProdnMgr.MaxLength = 32767
        Me.cboProdnMgr.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboProdnMgr.Name = "cboProdnMgr"
        Me.cboProdnMgr.OddRowStyle = Style14
        Me.cboProdnMgr.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProdnMgr.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboProdnMgr.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProdnMgr.SelectedStyle = Style15
        Me.cboProdnMgr.Size = New System.Drawing.Size(192, 24)
        Me.cboProdnMgr.Style = Style16
        Me.cboProdnMgr.TabIndex = 1
        Me.cboProdnMgr.PropBag = resources.GetString("cboProdnMgr.PropBag")
        '
        'cboGM
        '
        Me.cboGM.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboGM.AllowColMove = False
        Me.cboGM.AutoCompletion = True
        Me.cboGM.AutoDropDown = True
        Me.cboGM.Caption = ""
        Me.cboGM.CaptionHeight = 17
        Me.cboGM.CaptionStyle = Style17
        Me.cboGM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboGM.ColumnCaptionHeight = 17
        Me.cboGM.ColumnFooterHeight = 17
        Me.cboGM.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboGM.ContentHeight = 18
        Me.cboGM.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboGM.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboGM.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGM.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGM.EditorHeight = 18
        Me.cboGM.EvenRowStyle = Style18
        Me.cboGM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGM.FooterStyle = Style19
        Me.cboGM.HeadingStyle = Style20
        Me.cboGM.HighLightRowStyle = Style21
        Me.cboGM.Images.Add(CType(resources.GetObject("cboGM.Images"), System.Drawing.Image))
        Me.cboGM.ItemHeight = 20
        Me.cboGM.Location = New System.Drawing.Point(624, 32)
        Me.cboGM.MatchEntryTimeout = CType(2000, Long)
        Me.cboGM.MaxDropDownItems = CType(5, Short)
        Me.cboGM.MaxLength = 32767
        Me.cboGM.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboGM.Name = "cboGM"
        Me.cboGM.OddRowStyle = Style22
        Me.cboGM.ReadOnly = True
        Me.cboGM.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboGM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboGM.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboGM.SelectedStyle = Style23
        Me.cboGM.Size = New System.Drawing.Size(192, 24)
        Me.cboGM.Style = Style24
        Me.cboGM.TabIndex = 3
        Me.cboGM.Text = "Jim Alexander"
        Me.cboGM.PropBag = resources.GetString("cboGM.PropBag")
        '
        'cboQCMgr
        '
        Me.cboQCMgr.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboQCMgr.AllowColMove = False
        Me.cboQCMgr.AutoCompletion = True
        Me.cboQCMgr.AutoDropDown = True
        Me.cboQCMgr.Caption = ""
        Me.cboQCMgr.CaptionHeight = 17
        Me.cboQCMgr.CaptionStyle = Style25
        Me.cboQCMgr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboQCMgr.ColumnCaptionHeight = 17
        Me.cboQCMgr.ColumnFooterHeight = 17
        Me.cboQCMgr.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboQCMgr.ContentHeight = 18
        Me.cboQCMgr.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboQCMgr.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboQCMgr.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQCMgr.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboQCMgr.EditorHeight = 18
        Me.cboQCMgr.EvenRowStyle = Style26
        Me.cboQCMgr.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQCMgr.FooterStyle = Style27
        Me.cboQCMgr.HeadingStyle = Style28
        Me.cboQCMgr.HighLightRowStyle = Style29
        Me.cboQCMgr.Images.Add(CType(resources.GetObject("cboQCMgr.Images"), System.Drawing.Image))
        Me.cboQCMgr.ItemHeight = 20
        Me.cboQCMgr.Location = New System.Drawing.Point(408, 32)
        Me.cboQCMgr.MatchEntryTimeout = CType(2000, Long)
        Me.cboQCMgr.MaxDropDownItems = CType(5, Short)
        Me.cboQCMgr.MaxLength = 32767
        Me.cboQCMgr.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboQCMgr.Name = "cboQCMgr"
        Me.cboQCMgr.OddRowStyle = Style30
        Me.cboQCMgr.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboQCMgr.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboQCMgr.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboQCMgr.SelectedStyle = Style31
        Me.cboQCMgr.Size = New System.Drawing.Size(192, 24)
        Me.cboQCMgr.Style = Style32
        Me.cboQCMgr.TabIndex = 2
        Me.cboQCMgr.PropBag = resources.GetString("cboQCMgr.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.grid)
        Me.GroupBox1.Controls.Add(Me.cboQCMgr)
        Me.GroupBox1.Controls.Add(Me.cboProdnMgr)
        Me.GroupBox1.Controls.Add(Me.cboSupervisor)
        Me.GroupBox1.Controls.Add(Me.cboGM)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1146, 65)
        Me.GroupBox1.TabIndex = 136
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(624, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "General Manager"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "QC Manager"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Production Manager"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Supervisor"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(824, 10)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(144, 48)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grid
        '
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 72)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(1128, 176)
        Me.grid.TabIndex = 136
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'rptControl
        '
        Me.rptControl.ActiveViewIndex = -1
        Me.rptControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptControl.Location = New System.Drawing.Point(0, 105)
        Me.rptControl.Name = "rptControl"
        Me.rptControl.Size = New System.Drawing.Size(1146, 373)
        Me.rptControl.TabIndex = 137
        Me.rptControl.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmPrintReleaseReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1146, 478)
        Me.Controls.Add(Me.rptControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintReleaseReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrintReleaseReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cboSupervisor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProdnMgr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboQCMgr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintReleaseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displaySignatories()
    End Sub

    Public Sub displayData(ByVal container As String, ByVal seal As String)
        With grid
            .DataSource = getContainerReleaseData(container, seal).Tables(0)
            .Columns(17).NumberFormat = getTimeFormat() & " hh:mm:ss tt"
            .Columns(18).NumberFormat = getTimeFormat() & " hh:mm:ss tt"
            .Columns(19).NumberFormat = getTimeFormat() & " hh:mm:ss tt"

            displayResults()
        End With
    End Sub

    Public Sub displayResults()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                .Item(ctr, 13) = getQAFGResults(.Item(ctr, 7), .Item(ctr, 8), getProductSpecie(.Item(ctr, 6)), .Item(ctr, 9), "histamine")
                .Item(ctr, 14) = getQAFGResults(.Item(ctr, 7), .Item(ctr, 8), getProductSpecie(.Item(ctr, 6)), .Item(ctr, 9), "micro")
                .Item(ctr, 15) = getQAFGResults(.Item(ctr, 7), .Item(ctr, 8), getProductSpecie(.Item(ctr, 6)), .Item(ctr, 9), "deviation")
                '.Item(ctr, 17) = getContainerLoadingTime(.Item(ctr, 0), .Item(ctr, 1), "start")
                '.Item(ctr, 18) = getContainerLoadingTime(.Item(ctr, 0), .Item(ctr, 1), "start")
                '.Item(ctr, 19) = getContainerLoadingTime(.Item(ctr, 0), .Item(ctr, 1), "end")

                ctr += 1
            End While
        End With


    End Sub

    Public Sub savePrintRelease()
        Dim ctr As Integer
        deletePrintReleaseReport()

        With grid
            While ctr < .RowCount
                saveNewPrintReleaseReport(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), .Item(ctr, 4), .Item(ctr, 5), _
                    .Item(ctr, 6), .Item(ctr, 7), .Item(ctr, 8), .Item(ctr, 9), .Item(ctr, 10), .Item(ctr, 11), .Item(ctr, 12), _
                    .Item(ctr, 13), .Item(ctr, 14), .Item(ctr, 15), .Item(ctr, 16), .Item(ctr, 17), .Item(ctr, 18), .Item(ctr, 19), _
                    cboSupervisor.Text, cboProdnMgr.Text, cboQCMgr.Text, cboGM.Text)

                ctr += 1
            End While
        End With

        displayReport()
    End Sub

    Public Sub displayReport()
        Dim rpt As New rptPrintReleaseReport
        rpt.Load()

        rpt.SetDataSource(printReleaseReport().Tables(0))
        rptControl.ReportSource = rpt
    End Sub
 
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        savePrintRelease()
    End Sub

    Public Sub displaySignatories()
        cboSupervisor.DefColWidth = 170
        cboSupervisor.DataSource = getSignatories("%supervisor%", "%CS%").Tables(0)
        If cboSupervisor.ListCount > 0 Then cboSupervisor.SelectedIndex = 0

        cboProdnMgr.DefColWidth = 170
        cboProdnMgr.DataSource = getSignatories("%manager%", "Production - Mgr").Tables(0)
        If cboProdnMgr.ListCount > 0 Then cboProdnMgr.SelectedIndex = 0

        cboQCMgr.DefColWidth = 170
        cboQCMgr.DataSource = getSignatories("%manager%", "QC - Mgr").Tables(0)
        If cboQCMgr.ListCount > 0 Then cboQCMgr.SelectedIndex = 0
    End Sub

    Private Sub cboSupervisor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSupervisor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cboProdnMgr.SelectAll()
            Me.cboProdnMgr.Focus()
        End If
    End Sub

    Private Sub cboProdnMgr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProdnMgr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cboQCMgr.SelectAll()
            Me.cboQCMgr.Focus()
        End If
    End Sub

    Private Sub cboQCMgr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboQCMgr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cboGM.SelectAll()
            Me.cboGM.Focus()
        End If
    End Sub

    Private Sub cboGM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGM.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdPrint.Focus()
        End If
    End Sub
End Class
