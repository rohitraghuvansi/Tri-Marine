<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintColdStorageMetrics
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
        Dim Style9 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style10 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style11 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style12 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style13 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintColdStorageMetrics))
        Dim Style14 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style15 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style16 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rptControl = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.lblTotalBlocked = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotalReserved = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalOccupied = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalSpaces = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboRm = New C1.Win.C1List.C1Combo()
        Me.grp.SuspendLayout()
        CType(Me.cboRm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1110, 40)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Print Cold Storage Metrics Report"
        '
        'rptControl
        '
        Me.rptControl.ActiveViewIndex = -1
        Me.rptControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptControl.Location = New System.Drawing.Point(0, 85)
        Me.rptControl.Name = "rptControl"
        Me.rptControl.Size = New System.Drawing.Size(1110, 516)
        Me.rptControl.TabIndex = 3
        Me.rptControl.TabStop = False
        Me.rptControl.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'grp
        '
        Me.grp.Controls.Add(Me.lblTotalBlocked)
        Me.grp.Controls.Add(Me.Label12)
        Me.grp.Controls.Add(Me.lblTotalReserved)
        Me.grp.Controls.Add(Me.Label10)
        Me.grp.Controls.Add(Me.lblTotalOccupied)
        Me.grp.Controls.Add(Me.Label8)
        Me.grp.Controls.Add(Me.lblAvailable)
        Me.grp.Controls.Add(Me.Label6)
        Me.grp.Controls.Add(Me.lblTotalSpaces)
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Controls.Add(Me.Label5)
        Me.grp.Controls.Add(Me.cboRm)
        Me.grp.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp.Location = New System.Drawing.Point(0, 40)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(1110, 45)
        Me.grp.TabIndex = 57
        Me.grp.TabStop = False
        '
        'lblTotalBlocked
        '
        Me.lblTotalBlocked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalBlocked.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBlocked.Location = New System.Drawing.Point(144, 213)
        Me.lblTotalBlocked.Name = "lblTotalBlocked"
        Me.lblTotalBlocked.Size = New System.Drawing.Size(121, 23)
        Me.lblTotalBlocked.TabIndex = 63
        Me.lblTotalBlocked.Text = "0"
        Me.lblTotalBlocked.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalBlocked.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Total Blocked"
        Me.Label12.Visible = False
        '
        'lblTotalReserved
        '
        Me.lblTotalReserved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalReserved.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalReserved.Location = New System.Drawing.Point(144, 177)
        Me.lblTotalReserved.Name = "lblTotalReserved"
        Me.lblTotalReserved.Size = New System.Drawing.Size(121, 23)
        Me.lblTotalReserved.TabIndex = 61
        Me.lblTotalReserved.Text = "0"
        Me.lblTotalReserved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalReserved.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Total Reserved"
        Me.Label10.Visible = False
        '
        'lblTotalOccupied
        '
        Me.lblTotalOccupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOccupied.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOccupied.Location = New System.Drawing.Point(144, 138)
        Me.lblTotalOccupied.Name = "lblTotalOccupied"
        Me.lblTotalOccupied.Size = New System.Drawing.Size(121, 23)
        Me.lblTotalOccupied.TabIndex = 59
        Me.lblTotalOccupied.Text = "0"
        Me.lblTotalOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalOccupied.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Total Occupied"
        Me.Label8.Visible = False
        '
        'lblAvailable
        '
        Me.lblAvailable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvailable.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailable.Location = New System.Drawing.Point(144, 105)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(121, 23)
        Me.lblAvailable.TabIndex = 57
        Me.lblAvailable.Text = "0"
        Me.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAvailable.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Total Available"
        Me.Label6.Visible = False
        '
        'lblTotalSpaces
        '
        Me.lblTotalSpaces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSpaces.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSpaces.Location = New System.Drawing.Point(144, 71)
        Me.lblTotalSpaces.Name = "lblTotalSpaces"
        Me.lblTotalSpaces.Size = New System.Drawing.Size(121, 23)
        Me.lblTotalSpaces.TabIndex = 55
        Me.lblTotalSpaces.Text = "0"
        Me.lblTotalSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalSpaces.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Total Spaces"
        Me.Label2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Cold Storage Room *"
        '
        'cboRm
        '
        Me.cboRm.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboRm.AllowColMove = False
        Me.cboRm.AutoCompletion = True
        Me.cboRm.AutoDropDown = True
        Me.cboRm.Caption = ""
        Me.cboRm.CaptionHeight = 17
        Me.cboRm.CaptionStyle = Style9
        Me.cboRm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRm.ColumnCaptionHeight = 17
        Me.cboRm.ColumnFooterHeight = 17
        Me.cboRm.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboRm.ContentHeight = 18
        Me.cboRm.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRm.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRm.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRm.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRm.EditorHeight = 18
        Me.cboRm.EvenRowStyle = Style10
        Me.cboRm.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRm.FooterStyle = Style11
        Me.cboRm.HeadingStyle = Style12
        Me.cboRm.HighLightRowStyle = Style13
        Me.cboRm.Images.Add(CType(resources.GetObject("cboRm.Images"), System.Drawing.Image))
        Me.cboRm.ItemHeight = 20
        Me.cboRm.Location = New System.Drawing.Point(145, 10)
        Me.cboRm.MatchEntryTimeout = CType(2000, Long)
        Me.cboRm.MaxDropDownItems = CType(10, Short)
        Me.cboRm.MaxLength = 32767
        Me.cboRm.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRm.Name = "cboRm"
        Me.cboRm.OddRowStyle = Style14
        Me.cboRm.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRm.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRm.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRm.SelectedStyle = Style15
        Me.cboRm.Size = New System.Drawing.Size(200, 24)
        Me.cboRm.Style = Style16
        Me.cboRm.TabIndex = 52
        Me.cboRm.PropBag = resources.GetString("cboRm.PropBag")
        '
        'frmPrintColdStorageMetrics
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1110, 601)
        Me.Controls.Add(Me.rptControl)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPrintColdStorageMetrics"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintColdStorageMetrics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.cboRm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rptControl As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalBlocked As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalReserved As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalOccupied As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAvailable As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSpaces As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboRm As C1.Win.C1List.C1Combo
End Class
