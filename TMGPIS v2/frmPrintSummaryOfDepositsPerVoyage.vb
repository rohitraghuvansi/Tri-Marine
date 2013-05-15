Public Class frmPrintSummaryOfDepositsPerVoyage
    Inherits System.Windows.Forms.Form

    Public Shared summary As Boolean
    Public Shared perSublot As Boolean
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
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rptInventory As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents cboLot As C1.Win.C1List.C1Combo
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdGenerateReport As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintSummaryOfDepositsPerVoyage))
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
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.cmdGenerateReport = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboLot = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rptInventory = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grp.SuspendLayout()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp
        '
        Me.grp.Controls.Add(Me.cmdGenerateReport)
        Me.grp.Controls.Add(Me.Label4)
        Me.grp.Controls.Add(Me.cboLot)
        Me.grp.Controls.Add(Me.Label3)
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Controls.Add(Me.txtDateTo)
        Me.grp.Controls.Add(Me.txtDateFrom)
        Me.grp.Controls.Add(Me.Label10)
        Me.grp.Controls.Add(Me.cboVessel)
        Me.grp.Controls.Add(Me.grid)
        Me.grp.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp.Location = New System.Drawing.Point(0, 40)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(978, 80)
        Me.grp.TabIndex = 62
        Me.grp.TabStop = False
        '
        'cmdGenerateReport
        '
        Me.cmdGenerateReport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerateReport.Image = CType(resources.GetObject("cmdGenerateReport.Image"), System.Drawing.Image)
        Me.cmdGenerateReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGenerateReport.Location = New System.Drawing.Point(328, 16)
        Me.cmdGenerateReport.Name = "cmdGenerateReport"
        Me.cmdGenerateReport.Size = New System.Drawing.Size(152, 56)
        Me.cmdGenerateReport.TabIndex = 81
        Me.cmdGenerateReport.Text = "&Generate and Print"
        Me.cmdGenerateReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Trip Code"
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
        Me.cboLot.Location = New System.Drawing.Point(112, 47)
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
        Me.cboLot.TabIndex = 3
        Me.cboLot.PropBag = resources.GetString("cboLot.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Date To"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Date From"
        Me.Label2.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Enabled = False
        Me.txtDateTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.Location = New System.Drawing.Point(88, 112)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.ReadOnly = True
        Me.txtDateTo.Size = New System.Drawing.Size(264, 23)
        Me.txtDateTo.TabIndex = 1
        Me.txtDateTo.TabStop = False
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.Visible = False
        Me.txtDateTo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Enabled = False
        Me.txtDateFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.Location = New System.Drawing.Point(88, 80)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.ReadOnly = True
        Me.txtDateFrom.Size = New System.Drawing.Size(264, 23)
        Me.txtDateFrom.TabIndex = 0
        Me.txtDateFrom.TabStop = False
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.Visible = False
        Me.txtDateFrom.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Fishing Vessel"
        '
        'cboVessel
        '
        Me.cboVessel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboVessel.AllowColMove = False
        Me.cboVessel.AutoCompletion = True
        Me.cboVessel.AutoDropDown = True
        Me.cboVessel.Caption = ""
        Me.cboVessel.CaptionHeight = 17
        Me.cboVessel.CaptionStyle = Style9
        Me.cboVessel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVessel.ColumnCaptionHeight = 17
        Me.cboVessel.ColumnFooterHeight = 17
        Me.cboVessel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboVessel.ContentHeight = 18
        Me.cboVessel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVessel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVessel.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVessel.EditorHeight = 18
        Me.cboVessel.EvenRowStyle = Style10
        Me.cboVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.FooterStyle = Style11
        Me.cboVessel.HeadingStyle = Style12
        Me.cboVessel.HighLightRowStyle = Style13
        Me.cboVessel.Images.Add(CType(resources.GetObject("cboVessel.Images"), System.Drawing.Image))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(112, 15)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(20, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.OddRowStyle = Style14
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.SelectedStyle = Style15
        Me.cboVessel.Size = New System.Drawing.Size(208, 24)
        Me.cboVessel.Style = Style16
        Me.cboVessel.TabIndex = 2
        Me.cboVessel.PropBag = resources.GetString("cboVessel.PropBag")
        '
        'grid
        '
        Me.grid.AllowUpdate = False
        Me.grid.Enabled = False
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(8, 64)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.Size = New System.Drawing.Size(952, 8)
        Me.grid.TabIndex = 80
        Me.grid.TabStop = False
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.Visible = False
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(978, 40)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Print Round Fish Receipts Summary"
        '
        'rptInventory
        '
        Me.rptInventory.ActiveViewIndex = -1
        Me.rptInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptInventory.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptInventory.Location = New System.Drawing.Point(0, 120)
        Me.rptInventory.Name = "rptInventory"
        Me.rptInventory.Size = New System.Drawing.Size(978, 405)
        Me.rptInventory.TabIndex = 60
        Me.rptInventory.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmPrintSummaryOfDepositsPerVoyage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(978, 525)
        Me.Controls.Add(Me.rptInventory)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrintSummaryOfDepositsPerVoyage"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintSummaryOfDepositsPerVoyage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.cboLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintSummaryOfDepositsPerVoyage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        txtDateFrom.Value = getServerDateTime()
        txtDateTo.Value = getServerDateTime()

        displayFV()
    End Sub

    Public Sub displayFV(ByVal dateFrom As String, ByVal dateTo As String)
        If dateFrom = "" Or dateFrom Is DBNull.Value Then dateFrom = getServerDateTime() 'Format(getServerDateTime(), "dd/MM/yyyy")
        If dateTo = "" Or dateTo Is DBNull.Value Then dateTo = getServerDateTime() 'Format(getServerDateTime(), "dd/MM/yyyy")

        With cboVessel
            .Text = ""
            .DataSource = getFishingVessel(dateFrom, dateTo).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 184

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFV()
        With cboVessel
            .Text = ""
            .DataSource = getFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 184

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayLot(ByVal dateFrom As String, ByVal dateTo As String, ByVal fv As String)
        If dateFrom = "" Or dateFrom Is DBNull.Value Then dateFrom = getServerDateTime() 'Format(getServerDateTime(), "dd/MM/yyyy")
        If dateTo = "" Or dateTo Is DBNull.Value Then dateTo = getServerDateTime() 'Format(getServerDateTime(), "dd/MM/yyyy")

        With cboLot
            .Text = ""
            .DataSource = getBatchlotsDeposited(dateFrom, dateTo, fv).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 184

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayLot(ByVal fv As String)
        With cboLot
            .Text = ""
            .DataSource = getFishLotByFV(fv).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 184

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub txtDateFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateFrom.TextChanged
        'displayFV(txtDateFrom.Text, txtDateTo.Text)
        'displayData(txtDateFrom.Text, txtDateTo.Text, cboVessel.Text, cboLot.Text)
    End Sub

    Private Sub txtDateTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateTo.TextChanged
        'displayFV(txtDateFrom.Text, txtDateTo.Text)
        'displayData(txtDateFrom.Text, txtDateTo.Text, cboVessel.Text, cboLot.Text)
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        'displayLot(txtDateFrom.Text, txtDateTo.Text, cboVessel.Text)
        displayLot(cboVessel.Text)
        displayData(txtDateFrom.Text, txtDateTo.Text, cboVessel.Text, cboLot.Text)
    End Sub

    Public Sub displayReport()
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_report_fishDepositSummary"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@dateRange"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = getFVStartUnloadingDate(True, cboLot.Text) & getFVStartUnloadingDate(False, cboLot.Text)

            cmd.Parameters.Add(p1)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("TRAKIM")
            da.Fill(ds)

            Dim rpt As New rptPrintFishDepositPaymentSummary
            rpt.Load()
            rpt.SetDataSource(ds.Tables(0))
            rptInventory.ReportSource = rpt

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub displayReport(ByVal lot As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim qry As String
            If summary Then
                qry = "proc_report_roundFishReceipts"
            ElseIf perSublot Then
                qry = "proc_report_roundFishReceiptsPerSublot"
            End If

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = qry
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@lot"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = lot

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@dateRange"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = getFVStartUnloadingDate(True, cboLot.Text) & getFVStartUnloadingDate(False, cboLot.Text)

            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p1)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("TRAKIM")
            da.Fill(ds)

            If summary Then
                Dim rpt As New rptPrintFishDepositPaymentSummary
                rpt.Load()
                rpt.SetDataSource(ds.Tables(0))
                rptInventory.ReportSource = rpt

                If modModule.getUsername = "admin" Or modModule.getUsername = "solo" Then
                    Dim reply As String
                    reply = MsgBox("Would you like to print this fish receipts?" & Chr(13) & _
                        "Note:  Once your print this receipts, this fish lot will be locked for transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    If reply = vbYes Then
                        rpt.PrintToPrinter(0, True, 0, 0)
                        updateFishLotLockStatus(cboLot.Text, "Y")
                    End If
                Else
                End If
            ElseIf perSublot Then
                Dim rpt As New rptPrintFishDepositPerSublot
                rpt.Load()
                rpt.SetDataSource(ds.Tables(0))
                rptInventory.ReportSource = rpt
                End If

                da.Dispose()
                ds.Dispose()
                c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub displayData(ByVal dateFrom As String, ByVal dateTo As String, _
    ByVal fv As String, ByVal lot As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            'If dateFrom = "" Or dateFrom Is DBNull.Value Then dateFrom = getServerDateTime() 'Format(getServerDateTime(), "dd/MM/yyyy")
            'If dateTo = "" Or dateTo Is DBNull.Value Then dateTo = getServerDateTime() 'Format(getServerDateTime(), "dd/MM/yyyy")
            If fv = "" Then fv = "%"
            If lot = "" Then lot = "%"

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_displayReceivedFishWithAmount"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@dateFrom"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            p1.Value = getServerDateTime() 'dateFrom

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@dateTo"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.DateTime
            p2.Value = getServerDateTime() 'dateTo

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@fv"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = fv

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@lot"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = lot

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@price"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.Float
            p5.Value = 0

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@amount"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.Float
            p6.Value = 0

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            With grid
                .DataSource = ds.Tables(0)

                '.Splits(0).DisplayColumns(0).Width = 180
                '.Splits(0).DisplayColumns(1).Width = 60
                '.Splits(0).DisplayColumns(2).Width = 40
                '.Splits(0).DisplayColumns(3).Width = 130
                '.Splits(0).DisplayColumns(4).Width = 80
                '.Splits(0).DisplayColumns(5).Width = 90
                '.Splits(0).DisplayColumns(6).Width = 90
                '.Splits(0).DisplayColumns(7).Width = 60
                '.Splits(0).DisplayColumns(8).Width = 90
                '.Splits(0).DisplayColumns(9).Width = 90

                '.Columns(3).NumberFormat = "dd/MM/yyyy hh:mm:ss tt"
                '.Columns(6).NumberFormat = "###,##0.#0"
                '.Columns(7).NumberFormat = "###,##0.#0"
                '.Columns(8).NumberFormat = "###,###,###,##0.#0"
                '.Columns(9).NumberFormat = "###,###,###,##0.#0"
            End With

            da.Dispose()
            ds.Dispose()
            c.Close()

            displayCOSAmount()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboLot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLot.TextChanged
        displayData(txtDateFrom.Text, txtDateTo.Text, cboVessel.Text, cboLot.Text)
    End Sub

    Public Sub displayCOSAmount()
        Dim ctr As Integer
        While ctr < grid.RowCount
            grid.Item(ctr, 7) = getCOSAmountPerSpecieAndSize(cboLot.Text, grid.Item(ctr, 2), grid.Item(ctr, 3), grid.Item(ctr, 4))
            'grid.Item(ctr, 9) = (grid.Item(ctr, 6) / 1000) * getCOSAmountPerSpecieAndSize(cboLot.Text, grid.Item(ctr, 2), grid.Item(ctr, 4), grid.Item(ctr, 5))

            ctr += 1
        End While

        generateSummary()
    End Sub

    Public Sub generateSummary()
        deleteTmpFishDepositSummary()

        Dim ctr As Integer
        While ctr < grid.RowCount
            saveNewTmpFishDepositSummary(txtDateFrom.Text, txtDateTo.Text, cboVessel.Text, _
                cboLot.Text, grid.Item(ctr, 2), grid.Item(ctr, 3), grid.Item(ctr, 4), _
                grid.Item(ctr, 5), grid.Item(ctr, 6), grid.Item(ctr, 7))

            ctr += 1
        End While
    End Sub

    Private Sub cmdGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerateReport.Click
        displayReport(cboLot.Text)
    End Sub
End Class
