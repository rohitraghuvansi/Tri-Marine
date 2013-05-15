Public Class frmPrintFishSpoilages_byLotNo
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
    Friend WithEvents rptInventory As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmdGenerate2 As System.Windows.Forms.Button
    Friend WithEvents cmdGenerateDetails As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style9 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style10 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style11 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style12 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style13 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintFishSpoilages_byLotNo))
        Dim Style14 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style15 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style16 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.rptInventory = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.cmdGenerateDetails = New System.Windows.Forms.Button()
        Me.cmdGenerate2 = New System.Windows.Forms.Button()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp.SuspendLayout()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptInventory
        '
        Me.rptInventory.ActiveViewIndex = -1
        Me.rptInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptInventory.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptInventory.Location = New System.Drawing.Point(0, 96)
        Me.rptInventory.Name = "rptInventory"
        Me.rptInventory.Size = New System.Drawing.Size(896, 422)
        Me.rptInventory.TabIndex = 60
        Me.rptInventory.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'grp
        '
        Me.grp.Controls.Add(Me.cmdGenerateDetails)
        Me.grp.Controls.Add(Me.cmdGenerate2)
        Me.grp.Controls.Add(Me.cmdGenerate)
        Me.grp.Controls.Add(Me.Label9)
        Me.grp.Controls.Add(Me.cboLot)
        Me.grp.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp.Location = New System.Drawing.Point(0, 40)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(896, 56)
        Me.grp.TabIndex = 62
        Me.grp.TabStop = False
        '
        'cmdGenerateDetails
        '
        Me.cmdGenerateDetails.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerateDetails.Location = New System.Drawing.Point(464, 16)
        Me.cmdGenerateDetails.Name = "cmdGenerateDetails"
        Me.cmdGenerateDetails.Size = New System.Drawing.Size(169, 32)
        Me.cmdGenerateDetails.TabIndex = 82
        Me.cmdGenerateDetails.Text = "&Generate Details"
        '
        'cmdGenerate2
        '
        Me.cmdGenerate2.Enabled = False
        Me.cmdGenerate2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate2.Location = New System.Drawing.Point(608, 16)
        Me.cmdGenerate2.Name = "cmdGenerate2"
        Me.cmdGenerate2.Size = New System.Drawing.Size(169, 32)
        Me.cmdGenerate2.TabIndex = 81
        Me.cmdGenerate2.TabStop = False
        Me.cmdGenerate2.Text = "&Generate by Defects"
        Me.cmdGenerate2.Visible = False
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Location = New System.Drawing.Point(287, 16)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(169, 32)
        Me.cmdGenerate.TabIndex = 80
        Me.cmdGenerate.Text = "&Generate Summary"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Lot No."
        Me.Label9.Visible = False
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
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.EvenRowStyle = Style10
        Me.cboLot.FooterStyle = Style11
        Me.cboLot.HeadingStyle = Style12
        Me.cboLot.HighLightRowStyle = Style13
        Me.cboLot.Images.Add(CType(resources.GetObject("cboLot.Images"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(64, 16)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style14
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.SelectedStyle = Style15
        Me.cboLot.Size = New System.Drawing.Size(208, 24)
        Me.cboLot.Style = Style16
        Me.cboLot.TabIndex = 2
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(896, 40)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Print Fish Rejects by Lot No."
        '
        'frmPrintFishSpoilages_byLotNo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(896, 518)
        Me.Controls.Add(Me.rptInventory)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmPrintFishSpoilages_byLotNo"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintFishSpoilages_byLotNo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub displayReport(ByVal lotNo As String)
        Dim rpt As New rptPrintFishLotSpoilages
        rpt.Load()
        rpt.SetDataSource(getFVSpoilages(lotNo).Tables(0))
        rptInventory.ReportSource = rpt
    End Sub

    Private Sub frmPrintFishSpoilages_byLotNo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displayLotNo()
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged

    End Sub

    Public Sub displayLotNo()
        With cboLot
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        displayReport(cboLot.Text)
    End Sub

    'Public Sub displayRejectsByDefects(ByVal lotNo As String)
    '    Dim rpt As New rptPrintFishLotSpoilages_byDefects
    '    rpt.Load()
    '    rpt.SetDataSource(getFishRejects_byDefects(lotNo).Tables(0))
    '    rptInventory.ReportSource = rpt
    'End Sub

    'Private Sub cmdGenerate2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate2.Click
    '    displayRejectsByDefects(cboLot.Text)
    'End Sub

    Private Sub cmdGenerateDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerateDetails.Click
        displayRejectsByDetails(cboLot.Text)
    End Sub

    Public Sub displayRejectsByDetails(ByVal lotNo As String)
        Dim rpt As New rptPrintFishLotSpoilages_byDetails
        rpt.Load()
        rpt.SetDataSource(getLotFishRejectDetails(lotNo).Tables(0))
        rptInventory.ReportSource = rpt
    End Sub
End Class
