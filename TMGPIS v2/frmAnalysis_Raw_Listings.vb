Public Class frmAnalysis_Raw_Listings
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
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysis_Raw_Listings))
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(7, 48)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(984, 380)
        Me.grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.grid.TabIndex = 16
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(526, 434)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 111
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdView
        '
        Me.cmdView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdView.Location = New System.Drawing.Point(398, 434)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(120, 48)
        Me.cmdView.TabIndex = 110
        Me.cmdView.Text = "&View/ Edit"
        Me.cmdView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(998, 40)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Raw Fish Analysis List"
        '
        'frmAnalysis_Raw_Listings
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(998, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAnalysis_Raw_Listings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnalysis_Raw_Listings"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAnalysis_Raw_Listings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displayQCRawFishAnalysisList()

        validateUser()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayQCRawFishAnalysisList()
        With grid
            .DataSource = getAllQCRawFishAnalysisList().Tables(0)
            .Columns(0).NumberFormat = getTimeFormat()

            .Refresh()

            .Splits(0).DisplayColumns(0).Width = 120
            .Splits(0).DisplayColumns(1).Width = 150
            .Splits(0).DisplayColumns(2).Width = 70
            .Splits(0).DisplayColumns(5).Width = 110
            .Splits(0).DisplayColumns(7).Width = 70
            .Splits(0).DisplayColumns(8).Width = 115

            displayUnloadingDate()

        End With
    End Sub

    Public Sub displayUnloadingDate()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                .Item(ctr, 0) = Format(CDate(getFVLastUnloadingDate(.Item(ctr, 1))), getTimeFormat())
                .Item(ctr, 4) = getQALotResults(.Item(ctr, 1), .Item(ctr, 2), "histamine")
                .Item(ctr, 5) = getQALotResults(.Item(ctr, 1), .Item(ctr, 2), "ps")
                .Item(ctr, 6) = getQALotResults(.Item(ctr, 1), .Item(ctr, 2), "salt")

                'If .Item(ctr, 4) = "Pass" And .Item(ctr, 5) = "Pass" And .Item(ctr, 6) = "Pass" Then
                '    .Item(ctr, 7) = "Approved"
                'Else
                '    .Item(ctr, 7) = "Pending"
                'End If
                .Item(ctr, 7) = getQALotResults(.Item(ctr, 1), .Item(ctr, 2), "status")

                .Item(ctr, 8) = getQALotResults(.Item(ctr, 1), .Item(ctr, 2), "remarks")
                ctr += 1
            End While

            .Refresh()
            .Columns(0).SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.Descending

            'grid_HeadClick(New Object, New C1.Win.C1TrueDBGrid.ColEventArgs)

        End With
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Try
            With grid
                If .RowCount > 0 Then
                    Dim f As New frmAnalysis_Raw_DataEntry
                    f.cboLot.Text = .Item(.Row, 1)
                    f.cboLot.ReadOnly = True
                    f.cboSublot.Text = .Item(.Row, 2)
                    f.cboSublot.ReadOnly = True
                    f.displayLogs(f.cboLot.Text, f.cboSublot.Text)
                    f.ShowDialog(Me)
                Else
                    MsgBox("Please make sure you have selected a fish lot to analyse", MsgBoxStyle.Exclamation, "Warning")
                End If
            End With

            displayQCRawFishAnalysisList()
            validateUser()
        Catch ex As Exception
            MsgBox(ex.Message)
            '  sendExcemptionError(ex.Message, "Raw Fish Listings: Display of Raw Fish Results")
        End Try
    End Sub

    Public Sub validateUser()
        Select Case getPositionUser()
            Case "Analyst", "QA Rep", "QA Mgr", "System Administrator"
                cmdView.Enabled = True
            Case Else
                cmdView.Enabled = False
        End Select
    End Sub
End Class
