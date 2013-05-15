Public Class frmViewLotStatus
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
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewLotStatus))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.Label16.Size = New System.Drawing.Size(644, 40)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "Trip Code Settlement"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(0, 40)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(644, 456)
        Me.grid.TabIndex = 94
        Me.grid.Text = "C1TrueDBGrid1"
        Me.ToolTip1.SetToolTip(Me.grid, "Double click the table to view the rejection details")
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmViewLotStatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(644, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewLotStatus"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmViewLotStatus"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmViewLotStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displayLotStatus()
    End Sub

    Public Sub displayLotStatus()
        With grid
            .DataSource = getAllLotStatus().Tables(0)
            .Columns(2).NumberFormat = getTimeFormat()
            .Columns(3).NumberFormat = getTimeFormat()

            .Splits(0).DisplayColumns(0).Width = 200
            .Splits(0).DisplayColumns(1).Width = 200

        End With

        'getDetails()
    End Sub

    'Public Sub getDetails()
    '    With grid
    '        Dim ctr As Integer
    '        While ctr < .RowCount
    '            If Format(CDate(getFVLastUnloadingDate(.Item(ctr, 1))), getTimeFormat()) = "01/01/0001" Then
    '                '    .Item(ctr, 2) = DBNull.Value
    '                '    .Item(ctr, 3) = DBNull.Value
    '            Else
    '                .Item(ctr, 2) = Format(CDate(getFVLastUnloadingDate(.Item(ctr, 1))), getTimeFormat())
    '                .Item(ctr, 3) = Format(CDate(.Item(ctr, 2)).AddDays(45), getTimeFormat())

    '                .Refresh()
    '                .Columns(3).SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.Ascending
    '                '.FetchRowStyles = True
    '            End If

    '            ctr += 1
    '        End While


    '    End With
    'End Sub

    'Private Sub grid_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grid.FetchRowStyle
    '    With grid
    '        'If Not .Columns(2) Is DBNull.Value Or Not .Columns(2).Value = "" Then
    '        If CDate(.Columns(2).CellValue(e.Row)).AddDays(30) <= getServerDateTime() Then
    '            e.CellStyle.ForeColor = System.Drawing.Color.White
    '            e.CellStyle.BackColor = System.Drawing.Color.Red
    '        Else
    '            e.CellStyle.ForeColor = System.Drawing.Color.Black
    '            e.CellStyle.BackColor = System.Drawing.Color.White
    '            'gridLot.Splits(0).DisplayColumns(4).Locked = True
    '            'gridLot.Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
    '            'gridLot.Columns(4).Value = ""
    '            'gridLot.Refresh()
    '            'clearWellId()
    '        End If
    '        'End If
    '    End With
    'End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        Dim f As New frmPrintFishSpoilages_byLotNo
        f.cboLot.Text = grid.Item(grid.Row, 1)
        f.displayReport(grid.Item(grid.Row, 1))
        f.ShowDialog(Me)

    End Sub

    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        'If modModule.getUsername = "admin" Or modModule.getUsername = "malopitu" Then
        '    If e.KeyCode = Keys.C Then
        '        If Not grid.Columns(2).Value = "" And Not grid.Columns(2).Value Is DBNull.Value Then
        '            If grid.RowCount > 0 Then
        '                Dim reply As String
        '                reply = MsgBox("Are you sure you want to settle this lot number " & grid.Item(grid.Row, 1) & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
        '                If reply = vbYes Then
        '                    Dim lot As String = grid.Item(grid.Row, 1)
        '                    updateLotSettlement(grid.Item(grid.Row, 1), "Y")
        '                    displayLotStatus()

        '                    MsgBox("You have successfully closed the lot number " & lot, MsgBoxStyle.Information, "Information")
        '                End If
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        displayLotStatus()
    End Sub
End Class
