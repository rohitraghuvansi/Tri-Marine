Public Class frmPrintFWR
    Inherits System.Windows.Forms.Form

    Public Shared daily As Boolean
    Public Shared lot As Boolean
    Public Shared specie As Boolean
    Public Shared weekly As Boolean
    Public Shared dailyLoin As Boolean
    Public Shared pushBack As Boolean
    Public Shared flakesBag As Boolean
    Public Shared roundFish As Boolean
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintFWR))
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
        Me.rptInventory = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCS = New C1.Win.C1List.C1Combo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp.SuspendLayout()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptInventory
        '
        Me.rptInventory.ActiveViewIndex = -1
        Me.rptInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptInventory.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptInventory.Location = New System.Drawing.Point(0, 120)
        Me.rptInventory.Name = "rptInventory"
        Me.rptInventory.Size = New System.Drawing.Size(658, 375)
        Me.rptInventory.TabIndex = 3
        Me.rptInventory.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Label9)
        Me.grp.Controls.Add(Me.cboShift)
        Me.grp.Controls.Add(Me.Label3)
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Controls.Add(Me.txtDateTo)
        Me.grp.Controls.Add(Me.txtDateFrom)
        Me.grp.Controls.Add(Me.Label10)
        Me.grp.Controls.Add(Me.cboCS)
        Me.grp.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp.Location = New System.Drawing.Point(0, 40)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(658, 80)
        Me.grp.TabIndex = 59
        Me.grp.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(280, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Prodn Shift"
        Me.Label9.Visible = False
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
        Me.cboShift.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboShift.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboShift.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboShift.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboShift.EditorHeight = 18
        Me.cboShift.Enabled = False
        Me.cboShift.EvenRowStyle = Style2
        Me.cboShift.FooterStyle = Style3
        Me.cboShift.HeadingStyle = Style4
        Me.cboShift.HighLightRowStyle = Style5
        Me.cboShift.Images.Add(CType(resources.GetObject("cboShift.Images"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(352, 48)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(20, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.OddRowStyle = Style6
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.SelectedStyle = Style7
        Me.cboShift.Size = New System.Drawing.Size(144, 24)
        Me.cboShift.Style = Style8
        Me.cboShift.TabIndex = 2
        Me.cboShift.Visible = False
        Me.cboShift.PropBag = resources.GetString("cboShift.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Date To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Date From"
        '
        'txtDateTo
        '
        Me.txtDateTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.Location = New System.Drawing.Point(88, 47)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(144, 23)
        Me.txtDateTo.TabIndex = 1
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.Location = New System.Drawing.Point(88, 16)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(144, 23)
        Me.txtDateFrom.TabIndex = 0
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(448, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Cold Storage"
        Me.Label10.Visible = False
        '
        'cboCS
        '
        Me.cboCS.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCS.AllowColMove = False
        Me.cboCS.AutoCompletion = True
        Me.cboCS.AutoDropDown = True
        Me.cboCS.Caption = ""
        Me.cboCS.CaptionHeight = 17
        Me.cboCS.CaptionStyle = Style9
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
        Me.cboCS.Enabled = False
        Me.cboCS.EvenRowStyle = Style10
        Me.cboCS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCS.FooterStyle = Style11
        Me.cboCS.HeadingStyle = Style12
        Me.cboCS.HighLightRowStyle = Style13
        Me.cboCS.Images.Add(CType(resources.GetObject("cboCS.Images"), System.Drawing.Image))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(536, 16)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(20, Short)
        Me.cboCS.MaxLength = 32767
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.OddRowStyle = Style14
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.SelectedStyle = Style15
        Me.cboCS.Size = New System.Drawing.Size(208, 24)
        Me.cboCS.Style = Style16
        Me.cboCS.TabIndex = 72
        Me.cboCS.Visible = False
        Me.cboCS.PropBag = resources.GetString("cboCS.PropBag")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(658, 40)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Print Total Inventory Report"
        '
        'frmPrintFWR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(658, 495)
        Me.Controls.Add(Me.rptInventory)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrintFWR"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintFWR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintFWR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        initializeShift()

        txtDateFrom.Value = getServerDateTime()
        txtDateTo.Value = getServerDateTime()
    End Sub

    
    Private Sub txtDateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateFrom.ValueChanged
        If daily Or dailyLoin Or lot Or pushBack Or flakesBag Or roundFish Then
            txtDateTo.ReadOnly = True
            txtDateTo.Value = txtDateFrom.Value
        Else
            txtDateTo.ReadOnly = False
        End If

        displayReport(txtDateFrom.Text, txtDateTo.Text, cboShift.Text)
    End Sub

    Private Sub txtDateTo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateTo.ValueChanged
        displayReport(txtDateFrom.Text, txtDateTo.Text, cboShift.Text)
    End Sub

    Public Sub displayReport(ByVal dateFrom As String, ByVal dateTo As String, ByVal shift As String)
        Try
            If daily Then
                Dim rpt As New rptPrintFWS_byProdnDate
                rpt.Load()
                rpt.SetDataSource(getFWSByInclusiveDates(dateFrom, dateTo, shift).Tables(0))
                rptInventory.ReportSource = rpt

                'ElseIf dailyLoin Then
                '    Dim rpt As New rptPrintLoinInventory
                '    rpt.Load()
                '    rpt.SetDataSource(getLoinInventory(dateFrom, dateTo).Tables(0))
                '    rptInventory.ReportSource = rpt
                'ElseIf weekly Then
                '    Dim rpt As New rptPrintFWS_byWeekly
                '    rpt.Load()
                '    rpt.SetDataSource(getFWSByWeekly(dateFrom, dateTo).Tables(0))
                '    rptInventory.ReportSource = rpt
            ElseIf lot Then
                Dim rpt As New rptPrintFWR_Lot
                rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
                rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                rpt.Load()
                rpt.SetDataSource(getReport_fwrLot(dateFrom, dateTo, shift, "Summary", "Daily Cold Storage Withdrawal Summary Report").Tables(0))
                rptInventory.ReportSource = rpt
                'ElseIf pushBack Then
                'Dim rpt As New rptPrintFWR_Lot
                'rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
                'rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                'rpt.Load()
                'rpt.SetDataSource(getReport_fwrLot(dateFrom, dateTo, shift, "Push Back", "Daily Push Back Cannery Acceptance Summary Report").Tables(0))
                'rptInventory.ReportSource = rpt
                'ElseIf flakesBag Then
                'Dim rpt As New rptPrintFWR_Lot
                'rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
                'rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                'rpt.Load()
                'rpt.SetDataSource(getReport_fwrLot(dateFrom, dateTo, shift, "Flakes Bag", "Daily Flakes Bag Cannery Acceptance Summary Report").Tables(0))
                'rptInventory.ReportSource = rpt
                'ElseIf roundFish Then
                'Dim rpt As New rptPrintFWR_Lot
                'rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
                'rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                'rpt.Load()
                'rpt.SetDataSource(getReport_fwrLot(dateFrom, dateTo, shift, "Round Fish", "Daily Round Fish Cannery Acceptance Summary Report").Tables(0))
                'rptInventory.ReportSource = rpt
                'Else
                'Dim rpt As New rptPrintFWR_Specie
                'rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
                'rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                'rpt.Load()
                'rpt.SetDataSource(getReport_fwrSpecie(dateFrom, dateTo).Tables(0))
                'rptInventory.ReportSource = rpt
            End If
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub initializeShift()
        With cboShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 118
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        If cboShift.Text.Trim = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

        displayReport(txtDateFrom.Text, txtDateTo.Text, cboShift.Text)
    End Sub
End Class
