<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionScheduleListing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionScheduleListing))
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
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
        Me.cmdViewMap = New System.Windows.Forms.Button()
        Me.cmdViewBins = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cboState = New C1.Win.C1List.C1Combo()
        Me.cboStatus = New C1.Win.C1List.C1Combo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdViewMap
        '
        Me.cmdViewMap.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewMap.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdViewMap.Location = New System.Drawing.Point(449, 423)
        Me.cmdViewMap.Name = "cmdViewMap"
        Me.cmdViewMap.Size = New System.Drawing.Size(108, 48)
        Me.cmdViewMap.TabIndex = 113
        Me.cmdViewMap.Text = "View Map"
        Me.cmdViewMap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdViewBins
        '
        Me.cmdViewBins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewBins.Image = CType(resources.GetObject("cmdViewBins.Image"), System.Drawing.Image)
        Me.cmdViewBins.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdViewBins.Location = New System.Drawing.Point(323, 423)
        Me.cmdViewBins.Name = "cmdViewBins"
        Me.cmdViewBins.Size = New System.Drawing.Size(120, 48)
        Me.cmdViewBins.TabIndex = 112
        Me.cmdViewBins.Text = "&View Bins"
        Me.cmdViewBins.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(563, 423)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 114
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(960, 40)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "Raw Fish Scheduling - Lot View"
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
        Me.grid.Location = New System.Drawing.Point(6, 80)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(944, 337)
        Me.grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.grid.TabIndex = 115
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cboState
        '
        Me.cboState.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboState.AllowColMove = False
        Me.cboState.AutoCompletion = True
        Me.cboState.AutoDropDown = True
        Me.cboState.Caption = ""
        Me.cboState.CaptionHeight = 17
        Me.cboState.CaptionStyle = Style1
        Me.cboState.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboState.ColumnCaptionHeight = 17
        Me.cboState.ColumnFooterHeight = 17
        Me.cboState.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboState.ContentHeight = 18
        Me.cboState.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboState.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboState.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboState.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboState.EditorHeight = 18
        Me.cboState.EvenRowStyle = Style2
        Me.cboState.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FooterStyle = Style3
        Me.cboState.HeadingStyle = Style4
        Me.cboState.HighLightRowStyle = Style5
        Me.cboState.Images.Add(CType(resources.GetObject("cboState.Images"), System.Drawing.Image))
        Me.cboState.ItemHeight = 20
        Me.cboState.Location = New System.Drawing.Point(116, 50)
        Me.cboState.MatchEntryTimeout = CType(2000, Long)
        Me.cboState.MaxDropDownItems = CType(5, Short)
        Me.cboState.MaxLength = 32767
        Me.cboState.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboState.Name = "cboState"
        Me.cboState.OddRowStyle = Style6
        Me.cboState.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboState.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboState.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboState.SelectedStyle = Style7
        Me.cboState.Size = New System.Drawing.Size(208, 24)
        Me.cboState.Style = Style8
        Me.cboState.TabIndex = 117
        Me.cboState.PropBag = resources.GetString("cboState.PropBag")
        '
        'cboStatus
        '
        Me.cboStatus.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboStatus.AllowColMove = False
        Me.cboStatus.AutoCompletion = True
        Me.cboStatus.AutoDropDown = True
        Me.cboStatus.Caption = ""
        Me.cboStatus.CaptionHeight = 17
        Me.cboStatus.CaptionStyle = Style9
        Me.cboStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboStatus.ColumnCaptionHeight = 17
        Me.cboStatus.ColumnFooterHeight = 17
        Me.cboStatus.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboStatus.ContentHeight = 18
        Me.cboStatus.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboStatus.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboStatus.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboStatus.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStatus.EditorHeight = 18
        Me.cboStatus.EvenRowStyle = Style10
        Me.cboStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FooterStyle = Style11
        Me.cboStatus.HeadingStyle = Style12
        Me.cboStatus.HighLightRowStyle = Style13
        Me.cboStatus.Images.Add(CType(resources.GetObject("cboStatus.Images"), System.Drawing.Image))
        Me.cboStatus.ItemHeight = 20
        Me.cboStatus.Location = New System.Drawing.Point(520, 50)
        Me.cboStatus.MatchEntryTimeout = CType(2000, Long)
        Me.cboStatus.MaxDropDownItems = CType(5, Short)
        Me.cboStatus.MaxLength = 32767
        Me.cboStatus.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.OddRowStyle = Style14
        Me.cboStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboStatus.SelectedStyle = Style15
        Me.cboStatus.Size = New System.Drawing.Size(208, 24)
        Me.cboStatus.Style = Style16
        Me.cboStatus.TabIndex = 118
        Me.cboStatus.PropBag = resources.GetString("cboStatus.PropBag")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Schedule State"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "QA Status"
        '
        'frmProductionScheduleListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdViewMap)
        Me.Controls.Add(Me.cmdViewBins)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProductionScheduleListing"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProductionScheduleListing"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdViewMap As System.Windows.Forms.Button
    Friend WithEvents cmdViewBins As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboState As C1.Win.C1List.C1Combo
    Friend WithEvents cboStatus As C1.Win.C1List.C1Combo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
