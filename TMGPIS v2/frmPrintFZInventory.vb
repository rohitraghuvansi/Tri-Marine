Public Class frmPrintFZInventory
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rptInventory = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rptInventory
        '
        Me.rptInventory.ActiveViewIndex = -1
        Me.rptInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptInventory.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptInventory.Location = New System.Drawing.Point(0, 40)
        Me.rptInventory.Name = "rptInventory"
        Me.rptInventory.Size = New System.Drawing.Size(920, 496)
        Me.rptInventory.TabIndex = 56
        Me.rptInventory.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(920, 40)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Print Frozen Loins Total Inventory Report"
        '
        'frmPrintFZInventory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(920, 536)
        Me.Controls.Add(Me.rptInventory)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmPrintFZInventory"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintFZInventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintFZInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
    End Sub

    'Public Sub displayReport(ByVal isAlbacore As String)
    '    Dim rpt As New rptPrintFZInventory
    '    rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
    '    rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
    '    rpt.Load()

    '    rpt.SetDataSource(getFZTotalInventory(isAlbacore).Tables(0))
    '    rptInventory.ReportSource = rpt
    'End Sub

    'Public Sub displayReportInContainer()
    '    Dim rpt As New rptPrintFZInventory_Container
    '    rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
    '    rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
    '    rpt.Load()

    '    rpt.SetDataSource(getFZInventoryInContainers().Tables(0))
    '    rptInventory.ReportSource = rpt
    'End Sub

    Public Sub displayReportRoundFishInventoryByCS()
        Dim rpt As New rptPrintRoundFishInventory_byCS
        rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        rpt.Load()

        rpt.SetDataSource(getRoundFishInventory_ByCS().Tables(0))
        rptInventory.ReportSource = rpt
    End Sub
End Class
