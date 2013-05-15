Public Class frmPrintProductionOutputDetails
    Inherits System.Windows.Forms.Form

    Public Shared fz As Boolean
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
    Friend WithEvents rptLabeling As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintProductionOutputDetails))
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.rptLabeling = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptLabeling
        '
        Me.rptLabeling.ActiveViewIndex = -1
        Me.rptLabeling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptLabeling.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptLabeling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptLabeling.Location = New System.Drawing.Point(0, 128)
        Me.rptLabeling.Name = "rptLabeling"
        Me.rptLabeling.Size = New System.Drawing.Size(672, 405)
        Me.rptLabeling.TabIndex = 34
        Me.rptLabeling.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.cboShift)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 88)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'grid
        '
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(3, 109)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 15
        Me.grid.Size = New System.Drawing.Size(666, 168)
        Me.grid.TabIndex = 44
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Shift"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Prod'n Date"
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(232, 32)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(312, 32)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.TabStop = False
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.Visible = False
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
        Me.cboShift.EvenRowStyle = Style2
        Me.cboShift.FooterStyle = Style3
        Me.cboShift.HeadingStyle = Style4
        Me.cboShift.HighLightRowStyle = Style5
        Me.cboShift.Images.Add(CType(resources.GetObject("cboShift.Images"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(104, 56)
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
        Me.cboShift.Size = New System.Drawing.Size(120, 24)
        Me.cboShift.Style = Style8
        Me.cboShift.TabIndex = 1
        Me.cboShift.Text = "C1Combo1"
        Me.cboShift.PropBag = resources.GetString("cboShift.PropBag")
        '
        'txtDate
        '
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.Location = New System.Drawing.Point(104, 24)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(120, 23)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(672, 40)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Print Production Output Details"
        '
        'frmPrintProductionOutputDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 533)
        Me.Controls.Add(Me.rptLabeling)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.MaximizeBox = False
        Me.Name = "frmPrintProductionOutputDetails"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintProductionOutputDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmPrintProductionOutputDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
    End Sub

    Public Sub initializeShift()
        With cboShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 100
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayReport(ByVal prodnDate As String, ByVal shift As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_ProductionOutputDetails2"   '"proc_report_ProductionOutputDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@prodnDate"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            If prodnDate = "" Then
                p1.Value = Format(getServerDateTime, "dd/MM/yyyy")
            Else
                p1.Value = Format(CDate(prodnDate), "dd/MM/yyyy")
            End If

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@shift"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = shift

            'Dim p3 As New SqlClient.SqlParameter
            'p3.ParameterName = "@productType"
            'p3.Direction = ParameterDirection.Input
            'p3.SqlDbType = SqlDbType.VarChar
            'If fz Then
            '    p3.Value = "Frozen%"
            'Else
            '    p3.Value = "Can%"
            'End If

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            'cmd.Parameters.Add(p3)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("TRAKIM")
            da.Fill(ds)

            'If fz Then
            '    Dim rpt As New rptPrintProductionOutput_FZ
            '    rpt.Load()
            '    rpt.SetDataSource(ds.Tables(0))
            '    rptLabeling.ReportSource = rpt
            'Else
            '    Dim rpt As New rptPrintProductionOutput
            '    rpt.Load()
            '    rpt.SetDataSource(ds.Tables(0))
            '    rptLabeling.ReportSource = rpt
            'End If

            Dim rpt As New rptPrintProductionOutputDetails2
            rpt.Load()
            rpt.SetDataSource(ds.Tables(0))
            rptLabeling.ReportSource = rpt

            da.Dispose()
            ds.Dispose()
            c.Close()

        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub displayData(ByVal prodnDate As String, ByVal shift As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_display_ProductionOutputDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@prodnDate"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            If prodnDate = "" Then
                p1.Value = Format(getServerDateTime, "dd/MM/yyyy")
            Else
                p1.Value = Format(CDate(prodnDate), "dd/MM/yyyy")
            End If

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@shift"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = shift

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@productType"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            If fz Then
                p3.Value = "Frozen%"
            Else
                p3.Value = "Can%"
            End If

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("TRAKIM")
            da.Fill(ds)

            grid.DataSource = ds.Tables(0)

            da.Dispose()
            ds.Dispose()
            c.Close()

            collectData()
            displayReport(prodnDate, shift)
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        displayReport(txtDate.Text, cboShift.Text)
        'displayData(txtDate.Text, cboShift.Text)
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        displayReport(txtDate.Text, cboShift.Text)
        'displayData(txtDate.Text, cboShift.Text)
    End Sub

    Public Sub collectData()
        With grid
            Dim ctr As Integer
            While ctr < .RowCount
                .Item(ctr, 9) = getFGOutputQuantity(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), _
                    .Item(ctr, 3), .Item(ctr, 4), "Dent%")
                .Item(ctr, 10) = getFGOutputQuantity(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), _
                    .Item(ctr, 3), .Item(ctr, 4), "Rej%")
                .Item(ctr, 11) = getFGOutputQuantity(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), _
                    .Item(ctr, 3), .Item(ctr, 4), "%Sample%")

                ctr += 1
            End While

            delete_tmp_DailyProductionOutput()

            ctr = 0
            While ctr < .RowCount
                saveNewPrintProductionOutput(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), _
                    .Item(ctr, 4), .Item(ctr, 5), .Item(ctr, 6), .Item(ctr, 7), .Item(ctr, 9), .Item(ctr, 10), _
                    .Item(ctr, 11), .Item(ctr, 12), .Item(ctr, 13), .Item(ctr, 14), .Item(ctr, 15), .Item(ctr, 16))

                ctr += 1
            End While
        End With
    End Sub
End Class
