Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintInventory_Total_perRoom
    Inherits System.Windows.Forms.Form

    Public Shared roundFish As Boolean
    Public Shared roundFishAL As Integer
    Public Shared loin As Boolean

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rptInventory As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCS As C1.Win.C1List.C1Combo
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintInventory_Total_perRoom))
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
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCS = New C1.Win.C1List.C1Combo()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.rptInventory.Location = New System.Drawing.Point(0, 121)
        Me.rptInventory.Name = "rptInventory"
        Me.rptInventory.Size = New System.Drawing.Size(1488, 498)
        Me.rptInventory.TabIndex = 0
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
        Me.Label1.Size = New System.Drawing.Size(1488, 40)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Print Total Inventory Report"
        '
        'grp
        '
        Me.grp.Controls.Add(Me.grid)
        Me.grp.Controls.Add(Me.Label3)
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Controls.Add(Me.txtDateTo)
        Me.grp.Controls.Add(Me.txtDateFrom)
        Me.grp.Controls.Add(Me.Label10)
        Me.grp.Controls.Add(Me.cboCS)
        Me.grp.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp.Location = New System.Drawing.Point(0, 40)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(1488, 81)
        Me.grp.TabIndex = 56
        Me.grp.TabStop = False
        '
        'grid
        '
        Me.grid.AllowUpdate = False
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(288, 16)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.Size = New System.Drawing.Size(843, 54)
        Me.grid.TabIndex = 78
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.Visible = False
        Me.grid.PropBag = resources.GetString("grid.PropBag")
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
        Me.txtDateTo.Location = New System.Drawing.Point(88, 47)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(192, 23)
        Me.txtDateTo.TabIndex = 75
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.Location = New System.Drawing.Point(88, 16)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(192, 23)
        Me.txtDateFrom.TabIndex = 74
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
        Me.cboCS.CaptionStyle = Style1
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
        Me.cboCS.EvenRowStyle = Style2
        Me.cboCS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCS.FooterStyle = Style3
        Me.cboCS.HeadingStyle = Style4
        Me.cboCS.HighLightRowStyle = Style5
        Me.cboCS.Images.Add(CType(resources.GetObject("cboCS.Images"), System.Drawing.Image))
        Me.cboCS.ItemHeight = 20
        Me.cboCS.Location = New System.Drawing.Point(536, 16)
        Me.cboCS.MatchEntryTimeout = CType(2000, Long)
        Me.cboCS.MaxDropDownItems = CType(20, Short)
        Me.cboCS.MaxLength = 32767
        Me.cboCS.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCS.Name = "cboCS"
        Me.cboCS.OddRowStyle = Style6
        Me.cboCS.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCS.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCS.SelectedStyle = Style7
        Me.cboCS.Size = New System.Drawing.Size(208, 24)
        Me.cboCS.Style = Style8
        Me.cboCS.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.cboCS, "Clear this field if you want to display all cold storage in the report.")
        Me.cboCS.Visible = False
        Me.cboCS.PropBag = resources.GetString("cboCS.PropBag")
        '
        'frmPrintInventory_Total_perRoom
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1488, 619)
        Me.Controls.Add(Me.rptInventory)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrintInventory_Total_perRoom"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintInventory_Total_perRoom"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintInventory_Total_perRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        txtDateFrom.Value = getServerDateTime()
        txtDateTo.Value = getServerDateTime()
        'deleteTmpPrintRoundFishInventory()
    End Sub

    'Public Sub displayReportByRoom(ByVal cs As String)
    '    Try
    '        Dim rpt As New rptInventory_Total_and_perRoom()
    '        rpt.Load()
    '        rpt.SetDataSource(getReport_totalInventory(cs).Tables(0))
    '        rptInventory.ReportSource = rpt

    '    Catch e As Exception
    '        MsgBox(e.Message)
    '    Finally
    '    End Try
    'End Sub

    Public Sub displayReportByTotal(ByVal dateFrom As String, ByVal dateTo As String)
        Try
            If roundFish Then
                Dim rpt As New rptInventory_Total
                rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
                rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                rpt.Load()

                'grid.DataSource = getReport_totalInventory_tableView(dateFrom, dateTo, roundFishAL).Tables(0)
                'getUnloadingDate()

                Dim header As String
                Select Case roundFishAL
                    Case 1
                        header = "Light Meat Raw Fish Inventory Report"
                    Case 2
                        header = "Long Line Raw Fish Inventory Report"
                    Case 3
                        header = "Raw Fish Inventory in Containers Report"
                End Select

                rpt.SetDataSource(getReport_totalInventory(dateFrom, dateTo, header, roundFishAL).Tables(0))
                rptInventory.ReportSource = rpt
                'ElseIf loin Then
                '    Dim rpt As New rptInventory_Total_Loins
                '    rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
                '    rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                '    rpt.Load()
                '    rpt.SetDataSource(getLoinInventory_Summary(dateFrom, dateTo).Tables(0))
                '    rptInventory.ReportSource = rpt
            End If
            '***************************************************************************************************
            ''Dim strRptPath As String = Application.StartupPath & "\" & "rptTotalInventory.rpt"
            ''If Not IO.File.Exists(strRptPath) Then
            ''    Throw (New Exception("Unable to locate report file:" & _
            ''      vbCrLf & strRptPath))
            ''End If

            ''Dim rpt As New ReportDocument()
            ''rpt.Load(strRptPath)

            ''Dim dcValue As ParameterDiscreteValue
            ''Dim fieldDefinitions As ParameterFieldDefinitions
            ''Dim fieldDate As ParameterFieldDefinition
            ''Dim paramValue As ParameterValues

            ''fieldDefinitions = rpt.DataDefinition.ParameterFields

            ''fieldDate = fieldDefinitions.Item("@dateFrom")
            ''paramValue = fieldDate.CurrentValues
            ''dcValue = New CrystalDecisions.Shared.ParameterDiscreteValue()
            ''If dateFrom = "" Then
            ''    dcValue.Value = Format(getServerDateTime, "dd/MM/yyyy")
            ''Else
            ''    dcValue.Value = Format(CDate(dateFrom), "dd/MM/yyyy")
            ''End If
            ''paramValue.Add(dcValue)
            ''fieldDate.ApplyCurrentValues(paramValue)

            ''fieldDate = fieldDefinitions.Item("@dateTo")
            ''paramValue = fieldDate.CurrentValues
            ''dcValue = New CrystalDecisions.Shared.ParameterDiscreteValue()
            ''If dateTo = "" Then
            ''    dcValue.Value = Format(getServerDateTime, "dd/MM/yyyy")
            ''Else
            ''    dcValue.Value = Format(CDate(dateTo), "dd/MM/yyyy")
            ''End If
            ''paramValue.Add(dcValue)
            ''fieldDate.ApplyCurrentValues(paramValue)

            ''rptInventory.ReportSource = rpt

            '***************************************************************************************************
            ''Dim grpField As New ParameterFields()
            ''Dim paramDateFrom As New ParameterField()
            ''Dim paramDateTo As New ParameterField()
            ''Dim dcValue As New ParameterDiscreteValue()

            ''paramDateFrom.ParameterFieldName = "@dateFrom"
            ''If dateFrom = "" Then
            ''    dcValue.Value = Format(getServerDateTime, "dd/MM/yyyy")
            ''Else
            ''    dcValue.Value = Format(CDate(dateFrom), "dd/MM/yyyy")
            ''End If
            ''paramDateFrom.CurrentValues.Add(dcValue)

            ''dcValue = New ParameterDiscreteValue()
            ''paramDateTo.ParameterFieldName = "@dateTo"
            ''If dateTo = "" Then
            ''    dcValue.Value = Format(getServerDateTime, "dd/MM/yyyy")
            ''Else
            ''    dcValue.Value = Format(CDate(dateTo), "dd/MM/yyyy")
            ''End If
            ''paramDateTo.CurrentValues.Add(dcValue)

            ''grpField.Add(paramDateFrom)
            ''grpField.Add(paramDateTo)

            ''rptInventory.ParameterFieldInfo = grpField
            ''rptInventory.ReportSource = rpt

        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displayColdStorage()
        With cboCS
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 185

        End With
    End Sub

    'Private Sub cboCS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCS.TextChanged
    '    'If cboCS.Text.Trim = "" Then If cboCS.ListCount > 0 Then cboCS.SelectedIndex = 0

    '    'displayReportByRoom(cboCS.Text)
    'End Sub

    Private Sub txtDateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateFrom.ValueChanged
        displayReportByTotal(txtDateFrom.Text, txtDateTo.Text)
    End Sub

    Private Sub txtDateTo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateTo.ValueChanged
        displayReportByTotal(txtDateFrom.Text, txtDateTo.Text)
    End Sub

    Public Sub getUnloadingDate()
        With grid
            Dim ctr As Integer
            deleteTmpPrintRoundFishInventory()

            While ctr < .RowCount
                .Item(ctr, 7) = Format(getFVLastUnloadingDate(.Item(ctr, 1)), getTimeFormat())
                .Item(ctr, 8) = DateDiff(DateInterval.Day, getServerDateTime(), CDate(.Item(ctr, 7))) * -1
                .Item(ctr, 9) = Format(CDate(getFVLastUnloadingDate(.Item(ctr, 1)).AddDays(45)), getTimeFormat())

                Select Case roundFishAL
                    Case 1
                        saveNewTmpPrintRoundFishInventory(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), _
                            .Item(ctr, 3), .Item(ctr, 4), .Item(ctr, 5), .Item(ctr, 6), .Item(ctr, 7), _
                            .Item(ctr, 8), .Item(ctr, 9), "Raw Fish Inventory Report", "")
                    Case 2
                        saveNewTmpPrintRoundFishInventory(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), _
                            .Item(ctr, 3), .Item(ctr, 4), .Item(ctr, 5), .Item(ctr, 6), .Item(ctr, 7), _
                            .Item(ctr, 8), .Item(ctr, 9), "Light Meat Round Fish Inventory Report", "")
                    Case 3
                        saveNewTmpPrintRoundFishInventory(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), _
                            .Item(ctr, 3), .Item(ctr, 4), .Item(ctr, 5), .Item(ctr, 6), .Item(ctr, 7), _
                            .Item(ctr, 8), .Item(ctr, 9), "Round Fish Inventory in Containers Report", "")
                End Select

                ctr += 1
            End While
        End With
    End Sub

End Class
