Public Class frmPrintLotActivity
    Inherits System.Windows.Forms.Form

    Public Shared typeOfReport As String
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintLotActivity))
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.rptInventory = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.grp.SuspendLayout()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptInventory
        '
        Me.rptInventory.ActiveViewIndex = -1
        Me.rptInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptInventory.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptInventory.Location = New System.Drawing.Point(0, 104)
        Me.rptInventory.Name = "rptInventory"
        Me.rptInventory.Size = New System.Drawing.Size(962, 381)
        Me.rptInventory.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(962, 40)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Print Lot Movement Report"
        '
        'grp
        '
        Me.grp.Controls.Add(Me.cmdGenerate)
        Me.grp.Controls.Add(Me.Label10)
        Me.grp.Controls.Add(Me.cboLot)
        Me.grp.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp.Location = New System.Drawing.Point(0, 40)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(962, 64)
        Me.grp.TabIndex = 60
        Me.grp.TabStop = False
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Image = CType(resources.GetObject("cmdGenerate.Image"), System.Drawing.Image)
        Me.cmdGenerate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGenerate.Location = New System.Drawing.Point(301, 10)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(88, 48)
        Me.cmdGenerate.TabIndex = 74
        Me.cmdGenerate.Text = "&Generate"
        Me.cmdGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Trip Code"
        '
        'cboLot
        '
        Me.cboLot.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboLot.AllowColMove = False
        Me.cboLot.AutoCompletion = True
        Me.cboLot.AutoDropDown = True
        Me.cboLot.Caption = ""
        Me.cboLot.CaptionHeight = 17
        Me.cboLot.CaptionStyle = Style1
        Me.cboLot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLot.ColumnCaptionHeight = 17
        Me.cboLot.ColumnFooterHeight = 17
        Me.cboLot.ContentHeight = 18
        Me.cboLot.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboLot.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboLot.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLot.EditorHeight = 18
        Me.cboLot.EvenRowStyle = Style2
        Me.cboLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLot.FooterStyle = Style3
        Me.cboLot.HeadingStyle = Style4
        Me.cboLot.HighLightRowStyle = Style5
        Me.cboLot.Images.Add(CType(resources.GetObject("cboLot.Images"), System.Drawing.Image))
        Me.cboLot.ItemHeight = 20
        Me.cboLot.Location = New System.Drawing.Point(87, 10)
        Me.cboLot.MatchEntryTimeout = CType(2000, Long)
        Me.cboLot.MaxDropDownItems = CType(20, Short)
        Me.cboLot.MaxLength = 32767
        Me.cboLot.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboLot.Name = "cboLot"
        Me.cboLot.OddRowStyle = Style6
        Me.cboLot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboLot.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboLot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboLot.SelectedStyle = Style7
        Me.cboLot.Size = New System.Drawing.Size(208, 24)
        Me.cboLot.Style = Style8
        Me.cboLot.TabIndex = 72
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'grid
        '
        Me.grid.AllowUpdate = False
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(288, 104)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.Size = New System.Drawing.Size(656, 96)
        Me.grid.TabIndex = 74
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.Visible = False
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'frmPrintLotActivity
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(962, 485)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.rptInventory)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrintLotActivity"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintLotActivity"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintLotActivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        'displayLot()
    End Sub

    Public Sub displayLot()
        With cboLot
            .DataSource = modModule.getBatchlots().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub

    Public Sub displayReport(ByVal lot As String)
        Select Case typeOfReport
            'Case "lotMovement"
            '    Dim rpt As New rptPrintLotMovement
            '    rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            '    rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            '    rpt.Load()

            '    grid.DataSource = getReport_lotMovementSummary(lot).Tables(0)
            '    rpt.SetDataSource(getReport_lotMovement(lot, getBalance(True), getBalance(False)).Tables(0))

            '    rptInventory.ReportSource = rpt
            Case "lotDetails"
                Dim rpt As New rptPrintFishDeposit
                rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                rpt.Load()

                rpt.SetDataSource(getOutstandingLotNumberDeposited(lot).Tables(0))

                rptInventory.ReportSource = rpt
            Case "rr"
                Dim rpt As New rptPrintRRDetails
                rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                rpt.Load()

                rpt.SetDataSource(getRRFishBinDetails(lot).Tables(0))

                rptInventory.ReportSource = rpt
                'Case "lotDetailsPerCS"
                '    Dim rpt As New rptPrintFishDepositPerCS
                '    rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                '    rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                '    rpt.Load()

                '    rpt.SetDataSource(getFishDepositPerColdStorage(lot).Tables(0))

                '    rptInventory.ReportSource = rpt
                'Case "lotCA"
                '    Dim rpt As New rptPrintFWS_byLot
                '    rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                '    rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                '    rpt.Load()

                '    rpt.SetDataSource(getLotCanneryAcceptanceDetails(lot).Tables(0))

                '    rptInventory.ReportSource = rpt
            Case "binsBySublot"
                Dim rpt As New rptPrintBinDetailsBySublot
                rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                rpt.Load()

                rpt.SetDataSource(printBinsBySublot(lot).Tables(0))

                rptInventory.ReportSource = rpt
        End Select
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged

    End Sub

    Public Function getBalance(ByVal bal As Boolean) As Double
        Dim ctr As Integer
        Dim tonnage As Double
        Dim processed As Double

        With grid
            While ctr < .RowCount
                tonnage += .Item(ctr, 3)

                If .Item(ctr, 4) Is DBNull.Value Then
                    processed += 0
                Else
                    processed += .Item(ctr, 4)
                End If

                ctr += 1
            End While
        End With

        If bal Then
            Return tonnage - processed
        Else
            Return tonnage
        End If
    End Function

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        displayReport(cboLot.Text)
    End Sub

    Public Sub displayRR()
        With cboLot
            .DataSource = getAllFishReceipts().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185
        End With
    End Sub
End Class
