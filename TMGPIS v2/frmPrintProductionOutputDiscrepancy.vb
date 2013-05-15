Public Class frmPrintProductionOutputDiscrepancy
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintProductionOutputDiscrepancy))
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit
        Me.cboShift = New C1.Win.C1List.C1Combo
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdGenerate = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.Location = New System.Drawing.Point(88, 56)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(184, 23)
        Me.txtDateFrom.TabIndex = 0
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateTo
        '
        Me.txtDateTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.Location = New System.Drawing.Point(88, 87)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(184, 23)
        Me.txtDateTo.TabIndex = 1
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cboShift
        '
        Me.cboShift.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboShift.AllowColMove = False
        Me.cboShift.AutoCompletion = True
        Me.cboShift.AutoDropDown = True
        Me.cboShift.Caption = ""
        Me.cboShift.CaptionHeight = 17
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
        Me.cboShift.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(88, 118)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(20, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.Size = New System.Drawing.Size(184, 24)
        Me.cboShift.TabIndex = 40
        Me.cboShift.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Contr" & _
        "ol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Sty" & _
        "le10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
        "tBoxView AllowColMove=""False"" AllowColSelect=""False"" Name=""Split[0,0]"" CaptionHe" & _
        "ight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" VerticalScrollGroup=""" & _
        "1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 156</ClientRect><Height>156<" & _
        "/Height><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Height>16</Height" & _
        "></HScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRowStyle parent=""" & _
        "EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle pa" & _
        "rent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLi" & _
        "ghtRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle parent=""Inactive""" & _
        " me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordSelectorStyle p" & _
        "arent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selected"" me=""Style" & _
        "5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxView></Splits><" & _
        "NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /" & _
        "><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><S" & _
        "tyle parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><St" & _
        "yle parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><S" & _
        "tyle parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /" & _
        "><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><h" & _
        "orzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</Default" & _
        "RecSelWidth></Blob>"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(0, 157)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(928, 424)
        Me.grid.TabIndex = 41
        Me.grid.TabStop = False
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;" & _
        "}Style13{}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColo" & _
        "r:ControlText;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14" & _
        "{}Style15{}Style9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowC" & _
        "olMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterH" & _
        "eight=""17"" FilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=" & _
        """16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Heig" & _
        "ht>420</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=" & _
        """Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarSt" & _
        "yle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /" & _
        "><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""St" & _
        "yle2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle pa" & _
        "rent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><Record" & _
        "SelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Sele" & _
        "cted"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 924, " & _
        "420</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1." & _
        "Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" />" & _
        "<Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Sty" & _
        "le parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Styl" & _
        "e parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style pa" & _
        "rent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style p" & _
        "arent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Styl" & _
        "e parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedS" & _
        "tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><" & _
        "DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 924, 420</ClientArea" & _
        "><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" " & _
        "me=""Style15"" /></Blob>"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(376, 88)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(80, 56)
        Me.cmdPrint.TabIndex = 43
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Image = CType(resources.GetObject("cmdGenerate.Image"), System.Drawing.Image)
        Me.cmdGenerate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGenerate.Location = New System.Drawing.Point(288, 88)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(80, 56)
        Me.cmdGenerate.TabIndex = 42
        Me.cmdGenerate.Text = "&Generate"
        Me.cmdGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(464, 88)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 56)
        Me.cmdClose.TabIndex = 44
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(928, 40)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Finished Goods Discrepancy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Date To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 19)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Shift"
        '
        'frmPrintProductionOutputDiscrepancy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.MaximizeBox = False
        Me.Name = "frmPrintProductionOutputDiscrepancy"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrintProductionOutputDiscrepancy"
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintProductionOutputDiscrepancy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDateFrom.Value = getServerDateTime()
        txtDateTo.Value = getServerDateTime()
        initializeShift()

        displayData(txtDateFrom.Text, txtDateTo.Text, cboShift.Text)

    End Sub

    Public Sub initializeShift()
        With cboShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 160
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayData(ByVal dateFrom As String, ByVal dateTo As String, ByVal shift As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "proc_display_Product_DiscrepancyData2"
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@dateFrom"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            If dateFrom = "" Then
                p1.Value = getServerDateTime()
            Else
                p1.Value = CDate(dateFrom)
            End If

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@dateTo"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.DateTime
            If dateTo = "" Then
                p2.Value = getServerDateTime()
            Else
                p2.Value = CDate(dateTo)
            End If

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@shift"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = shift

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("FG")
            da.Fill(ds)

            With grid
                .DataSource = ds.Tables(0)

                .Splits(0).DisplayColumns(1).Width = 60
                .Splits(0).DisplayColumns(2).Width = 80
                .Splits(0).DisplayColumns(4).Width = 70
                .Splits(0).DisplayColumns(5).Width = 70
                .Splits(0).DisplayColumns(6).Width = 120
                .Splits(0).DisplayColumns(7).Width = 120
                .Splits(0).DisplayColumns(8).Width = 120
                .Splits(0).DisplayColumns(9).Width = 120
                .Splits(0).DisplayColumns(10).Width = 120

                .Columns(6).NumberFormat = "###,###,###,##0"
                .Columns(7).NumberFormat = "###,###,###,##0"
                .Columns(8).NumberFormat = "###,###,###,##0"
                .Columns(9).NumberFormat = "###,###,###,##0"
                .Columns(10).NumberFormat = "###,###,###,##0"

                .FetchRowStyles = True
            End With

            da.Dispose()
            ds.Dispose()
            c.Close()

            getLabelingDetails()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getLabelingDetails()
        With grid
            Dim ctr As Integer
            While ctr < .RowCount
                .Item(ctr, 7) = getLabeledQtyPerProduct(.Item(ctr, 0), "%", .Item(ctr, 2), .Item(ctr, 3), .Item(ctr, 4))
                .Item(ctr, 8) = getFGOutputQuantity_byProduct(.Item(ctr, 0), "%", .Item(ctr, 2), .Item(ctr, 3), .Item(ctr, 4), "%sample%")
                .Item(ctr, 9) = getFGOutputQuantity_byProduct(.Item(ctr, 0), "%", .Item(ctr, 2), .Item(ctr, 3), .Item(ctr, 4), "%dented%") + _
                                getFGOutputQuantity_byProduct(.Item(ctr, 0), "%", .Item(ctr, 2), .Item(ctr, 3), .Item(ctr, 4), "%reject%")
                .Item(ctr, 10) = .Item(ctr, 6) - (.Item(ctr, 7) + .Item(ctr, 8) + .Item(ctr, 9))
                ctr += 1
            End While
        End With
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        displayData(txtDateFrom.Text, txtDateTo.Text, cboShift.Text)
    End Sub

    Private Sub grid_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grid.FetchRowStyle
        If CDbl(grid.Columns(10).CellValue(e.Row)) < 0 Then
            e.CellStyle.ForeColor = System.Drawing.Color.White
            e.CellStyle.BackColor = System.Drawing.Color.Red
        ElseIf CDbl(grid.Columns(10).CellValue(e.Row)) >= 50 Then
            e.CellStyle.ForeColor = System.Drawing.Color.Yellow
            e.CellStyle.BackColor = System.Drawing.Color.Blue
        Else
            e.CellStyle.ForeColor = System.Drawing.Color.Black
            e.CellStyle.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        With grid
            Dim ctr As Integer

            displayData(txtDateFrom.Text, txtDateTo.Text, cboShift.Text)
            delete_tmp_PrintProductionOutputDiscrepancy()

            While ctr < .RowCount
                saveNewPrintProductionOutputDiscrepancy(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), .Item(ctr, 4), _
                    .Item(ctr, 5), .Item(ctr, 6), .Item(ctr, 7), .Item(ctr, 8), .Item(ctr, 9))

                ctr += 1
            End While
        End With

        'Dim f As New frmPrintProductionReport
        'f.Label1.Text = "Print Daily Production Output Report"
        'f.displayProductionOutputDiscrepancy()
        'f.ShowDialog(Me)

        'displayData(txtDateFrom.Text, txtDateTo.Text, cboShift.Text)

        '' display wait cursor
        'Me.Cursor = Cursors.WaitCursor
        '' various variables
        'Dim row As Integer
        'Dim col As Integer
        'Dim rowCount As Integer
        'Dim colCount As Integer
        'Dim cell As String
        'Dim rowcell As Integer

        '' Excel Variables
        'Dim excelApp As New Excel.Application
        'Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        'Dim excelWorksheet As Excel.Worksheet = _
        '    CType(excelBook.Worksheets(1), Excel.Worksheet)

        ''gridMaterials.DataSource = displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0)

        '' get count of rows and count of columns
        'rowCount = grid.RowCount  'objDataSet.Tables(0).Rows.Count()
        'colCount = grid.Columns.Count  'displaySummary.Tables(0).Columns.Count 'objDataSet.Tables(0).Columns.Count()

        '' add the column headings
        ''''excelWorksheet.Range("F1").Value = "D0S0"
        ''''excelWorksheet.Range("F2").Value = "Cases Produced"
        ''''For col = 0 To colCount - 1
        ''''    row = 1
        ''''    cell = GetExcelColumn(col) & row.ToString
        ''''    excelWorksheet.Range(cell).Value = grid.Splits(0).GridColumnStyles(col).HeaderText
        ''''    excelWorksheet.Range(cell).ColumnWidth = grid.TableStyles(0).GridColumnStyles(col).Width / 4
        ''''Next
        ''Dim ctr As Integer
        ''col = 5
        ''While ctr < grid.RowCount
        ''    If col = 25 Then col = 0
        ''    If col > 24 Then
        ''        cell = GetExcelColumn("A" & col) '& "1"
        ''    Else
        ''        cell = GetExcelColumn(col) '& "1"
        ''    End If
        'excelWorksheet.Range("A1").Value = "Production Date"
        'excelWorksheet.Range("B1").Value = "Shift"
        'excelWorksheet.Range("C1").Value = "Lot No."
        'excelWorksheet.Range("D1").Value = "Product"
        'excelWorksheet.Range("E1").Value = "Code2"
        'excelWorksheet.Range("F1").Value = "per Case"
        'excelWorksheet.Range("G1").Value = "Production Output"
        'excelWorksheet.Range("H1").Value = "Labeling Output"
        'excelWorksheet.Range("I1").Value = "QA Sample"
        'excelWorksheet.Range("J1").Value = "Defectives"
        'excelWorksheet.Range("K1").Value = "Discrepancy"

        ''    col += 1
        ''    ctr += 1
        ''End While


        '' now add the data elements
        'For row = 0 To rowCount - 1
        '    rowcell = row + 2

        '    For col = 0 To colCount - 1 '(grid.RowCount + displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0).Columns.Count) - 1  'colCount - 1
        '        'If col = 25 Then col = 0
        '        'If col > 24 Then
        '        '    cell = GetExcelColumn("A" & col) '& rowcell.ToString
        '        'Else
        '        cell = GetExcelColumn(col) '& rowcell.ToString
        '        'End If

        '        'If col < displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0).Columns.Count Then

        '        excelWorksheet.Range(cell & rowcell.ToString).Value = grid.Item(row, col)  ' gridMaterials.Item(row, col)
        '        'If CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Skip") >= 0 Or _
        '        'CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Yell") >= 0 Then
        '        '    Dim unitCostFish As Double = (getFishCost(txtProdnDate.Text, cboShift.Text, excelWorksheet.Range("B" & rowcell.ToString).Text) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, excelWorksheet.Range("B" & rowcell.ToString).Text)) / 1000
        '        '    excelWorksheet.Range("D" & rowcell.ToString).Value = unitCostFish
        '        '    If Not CStr(excelWorksheet.Range("C" & rowcell.ToString).Text) = "" Then
        '        '        excelWorksheet.Range("E" & rowcell.ToString).Value = excelWorksheet.Range("C" & rowcell.ToString).Text * unitCostFish
        '        '    End If
        '        'End If
        '        'Else
        '        '    If getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Can Bodies" Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
        '        '            excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Cans")
        '        '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Can Ends" Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
        '        '            excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Ends")
        '        '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Ingredients" Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
        '        '            excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Ingredients")
        '        '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Cartons" Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons_Labels(txtProdnDate.Text, cboShift.Text, _
        '        '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
        '        '            excelWorksheet.Range("B" & rowcell.ToString).Text, "Cartons")
        '        '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Labels" Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons_Labels(txtProdnDate.Text, cboShift.Text, _
        '        '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
        '        '            excelWorksheet.Range("B" & rowcell.ToString).Text, "Labels")
        '        '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Loin Bags" Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons_Labels(txtProdnDate.Text, cboShift.Text, _
        '        '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
        '        '            "%loin%", "Loin Bags")
        '        '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Labor") >= 0 Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Labor_OH(txtProdnDate.Text, cboShift.Text, _
        '        '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
        '        '            "Labor")
        '        '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Supp") >= 0 Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Labor_OH(txtProdnDate.Text, cboShift.Text, _
        '        '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
        '        '            "OH")
        '        '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Fuel") >= 0 Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Utilities(txtProdnDate.Text, _
        '        '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
        '        '            "Fuel")
        '        '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Elect") >= 0 Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Utilities(txtProdnDate.Text, _
        '        '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
        '        '            "Electricity")
        '        '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Skip") >= 0 Or _
        '        '    CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Yell") >= 0 Then
        '        '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Specie(excelWorksheet.Range(cell & "1").Text, _
        '        '            excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text)
        '        '    End If
        '        'End If
        '    Next
        'Next

        '' turn off wait cursor
        'Me.Cursor = Cursors.Default

        '' view the spread sheet
        'excelApp.Visible = True
    End Sub

    '********************************************************************************
    '********************************************************************************
    '********************************************************************************
    '********************************************************************************
    ' Function GetExcelColumn - returns the column reference
    ' from an integer representing a column in a datagrid or dataset
    Function GetExcelColumn(ByVal col As Integer) As String
        Dim result As String
        Select Case col
            Case 0 ' first column
                result = "A"
            Case 1
                result = "B"
            Case 2
                result = "C"
            Case 3
                result = "D"
            Case 4
                result = "E"
            Case 5
                result = "F"
            Case 6
                result = "G"
            Case 7
                result = "H"
            Case 8
                result = "I"
            Case 9
                result = "J"
            Case 10
                result = "K"
            Case 11
                result = "L"
            Case 12
                result = "M"
            Case 13
                result = "N"
            Case 14
                result = "O"
            Case 15
                result = "P"
            Case 16
                result = "Q"
            Case 17
                result = "R"
            Case 18
                result = "S"
            Case 19
                result = "T"
            Case 20
                result = "U"
            Case 21
                result = "V"
            Case 22
                result = "W"
            Case 23
                result = "X"
            Case 24
                result = "Y"
            Case 25
                result = "Z"
        End Select
        Return result
    End Function
End Class
