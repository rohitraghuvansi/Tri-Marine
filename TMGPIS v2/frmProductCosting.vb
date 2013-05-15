Public Class frmProductCosting
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents gridMaterials As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAccpacData As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProductCosting))
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gridMaterials = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdAccpacData = New System.Windows.Forms.Button
        Me.cmdExport = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdGenerate = New System.Windows.Forms.Button
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.lblWait = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(618, 40)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Product Costing"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblWait)
        Me.GroupBox1.Controls.Add(Me.gridMaterials)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.txtDateTo)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdAccpacData)
        Me.GroupBox1.Controls.Add(Me.cmdExport)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.cmdGenerate)
        Me.GroupBox1.Controls.Add(Me.txtDateFrom)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 248)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'gridMaterials
        '
        Me.gridMaterials.AllowUpdate = False
        Me.gridMaterials.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridMaterials.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.gridMaterials.Location = New System.Drawing.Point(8, 80)
        Me.gridMaterials.Name = "gridMaterials"
        Me.gridMaterials.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridMaterials.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridMaterials.PreviewInfo.ZoomFactor = 75
        Me.gridMaterials.Size = New System.Drawing.Size(664, 160)
        Me.gridMaterials.TabIndex = 14
        Me.gridMaterials.Text = "C1TrueDBGrid1"
        Me.gridMaterials.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""17"" ColumnCapti" & _
        "onHeight=""17"" ColumnFooterHeight=""17"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>156</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 660, 156</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 660, 156</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(520, 24)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(88, 48)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtDateTo
        '
        Me.txtDateTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.Location = New System.Drawing.Point(91, 48)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(160, 23)
        Me.txtDateTo.TabIndex = 1
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(1040, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Button2"
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(888, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 48)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "February"
        Me.Button1.Visible = False
        '
        'cmdAccpacData
        '
        Me.cmdAccpacData.Enabled = False
        Me.cmdAccpacData.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccpacData.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAccpacData.Location = New System.Drawing.Point(672, 88)
        Me.cmdAccpacData.Name = "cmdAccpacData"
        Me.cmdAccpacData.Size = New System.Drawing.Size(112, 48)
        Me.cmdAccpacData.TabIndex = 15
        Me.cmdAccpacData.TabStop = False
        Me.cmdAccpacData.Text = "Export to Accpac"
        Me.cmdAccpacData.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdExport
        '
        Me.cmdExport.Enabled = False
        Me.cmdExport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Image = CType(resources.GetObject("cmdExport.Image"), System.Drawing.Image)
        Me.cmdExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdExport.Location = New System.Drawing.Point(416, 88)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(144, 48)
        Me.cmdExport.TabIndex = 13
        Me.cmdExport.TabStop = False
        Me.cmdExport.Text = "&Export Balance Sheet"
        Me.cmdExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Shift"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Prod'n Date"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(416, 24)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(96, 48)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Image = CType(resources.GetObject("cmdGenerate.Image"), System.Drawing.Image)
        Me.cmdGenerate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGenerate.Location = New System.Drawing.Point(259, 24)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(149, 48)
        Me.cmdGenerate.TabIndex = 7
        Me.cmdGenerate.Text = "&Generate to Excel"
        Me.cmdGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.Location = New System.Drawing.Point(91, 16)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(160, 23)
        Me.txtDateFrom.TabIndex = 0
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(0, 288)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(618, 0)
        Me.grid.TabIndex = 31
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Tahoma, 9.75pt;}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}He" & _
        "ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" & _
        ";BackColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}S" & _
        "tyle1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""Fals" & _
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" M" & _
        "arqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>0</Height><CaptionStyle pa" & _
        "rent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRow" & _
        "Style parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Styl" & _
        "e13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=" & _
        """Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pare" & _
        "nt=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><" & _
        "OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSel" & _
        "ector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pare" & _
        "nt=""Normal"" me=""Style1"" /><ClientRect>0, 0, 618, 0</ClientRect><BorderSide>0</Bo" & _
        "rderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Spli" & _
        "ts><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Headin" & _
        "g"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" " & _
        "/><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /" & _
        "><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /" & _
        "><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Sty" & _
        "le parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" " & _
        "/><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><" & _
        "horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRec" & _
        "SelWidth><ClientArea>0, 0, 618, 0</ClientArea><PrintPageHeaderStyle parent="""" me" & _
        "=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'lblWait
        '
        Me.lblWait.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.Location = New System.Drawing.Point(41, 26)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(536, 32)
        Me.lblWait.TabIndex = 32
        Me.lblWait.Text = "Please wait..."
        Me.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWait.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmProductCosting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 120)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmProductCosting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProductCosting"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmProductCosting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDateFrom.Value = getServerDateTime()
        txtDateTo.Value = getServerDateTime()
        'initializeShift()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Public Sub initializeShift()
    '    With cboShift
    '        .DataMode = C1.Win.C1List.DataModeEnum.AddItem
    '        .AddItemTitles("Shift")
    '        .AddItem("Day")
    '        .AddItem("Night")
    '        .Splits(0).DisplayColumns(0).Width = 138
    '        .SelectedIndex = 0
    '    End With
    'End Sub

    'Private Sub cboShift_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cboShift.Text = "" Then If cboShift.ListCount > 0 Then cboShift.SelectedIndex = 0

    '    'displayProductForCosting()
    'End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateFrom.ValueChanged
        'displayProductForCosting()
    End Sub

    Public Sub displayProductForCosting(Optional ByVal monthEnd As Boolean = False)
        With grid
            If monthEnd Then
                .DataSource = getProductCosting_MonthEnd(txtDateFrom.Text, txtDateTo.Text).Tables(0)
                'Else
                '    .DataSource = getProductCosting(txtProdnDate.Value, cboShift.Text).Tables(0)
            End If

            .Splits(0).DisplayColumns(1).Width = 65
            .Splits(0).DisplayColumns(2).Width = 73
            .Splits(0).DisplayColumns(4).Width = 60
            .Splits(0).DisplayColumns(6).Width = 150
            .Splits(0).DisplayColumns(7).Width = 150
            .Splits(0).DisplayColumns(8).Width = 150
            .Splits(0).DisplayColumns(49).Width = 150
            .Splits(0).DisplayColumns(50).Width = 150
            .Splits(0).DisplayColumns(54).Width = 150
            .Splits(0).DisplayColumns(55).Width = 150
            .Splits(0).DisplayColumns(60).Width = 150
            .Splits(0).DisplayColumns(65).Width = 150
            .Splits(0).DisplayColumns(70).Width = 150
            .Splits(0).DisplayColumns(71).Width = 150
            .Splits(0).DisplayColumns(73).Width = 150
            .Splits(0).DisplayColumns(75).Width = 150
            .Splits(0).DisplayColumns(77).Width = 150
            .Splits(0).DisplayColumns(79).Width = 150
            .Splits(0).DisplayColumns(81).Width = 150
            .Splits(0).DisplayColumns(82).Width = 300

            .Columns(3).NumberFormat = "###,###,##0.##0"
            .Columns(4).NumberFormat = "###,###,##0.#0"
            .Columns(5).NumberFormat = "###,###,###,##0.##0"
            .Columns(6).NumberFormat = "###,###,###,##0.#0"
            .Columns(7).NumberFormat = "###,###,###,##0.#0"
            .Columns(8).NumberFormat = "###,###,###,##0.#0"
            'Oil
            .Columns(9).NumberFormat = "###,###,###,##0.##0"
            .Columns(10).NumberFormat = "###,###,###,##0.##0"
            .Columns(11).NumberFormat = "###,###,###,##0.#0"
            .Columns(12).NumberFormat = "###,###,###,##0.#0"
            .Columns(13).NumberFormat = "###,###,###,##0.#0"
            'Anti-Oxidant
            .Columns(14).NumberFormat = "###,###,###,##0.##0"
            .Columns(15).NumberFormat = "###,###,###,##0.##0"
            .Columns(16).NumberFormat = "###,###,###,##0.#0"
            .Columns(17).NumberFormat = "###,###,###,##0.#0"
            .Columns(18).NumberFormat = "###,###,###,##0.#0"
            'Broth
            .Columns(19).NumberFormat = "###,###,###,##0.##0"
            .Columns(20).NumberFormat = "###,###,###,##0.##0"
            .Columns(21).NumberFormat = "###,###,###,##0.#0"
            .Columns(22).NumberFormat = "###,###,###,##0.#0"
            .Columns(23).NumberFormat = "###,###,###,##0.#0"
            'Chili Fruit (CF)
            .Columns(24).NumberFormat = "###,###,###,##0.##0"
            .Columns(25).NumberFormat = "###,###,###,##0.##0"
            .Columns(26).NumberFormat = "###,###,###,##0.#0"
            .Columns(27).NumberFormat = "###,###,###,##0.#0"
            .Columns(28).NumberFormat = "###,###,###,##0.#0"
            'Chili Powder (CP)
            .Columns(29).NumberFormat = "###,###,###,##0.##0"
            .Columns(30).NumberFormat = "###,###,###,##0.##0"
            .Columns(31).NumberFormat = "###,###,###,##0.#0"
            .Columns(32).NumberFormat = "###,###,###,##0.#0"
            .Columns(33).NumberFormat = "###,###,###,##0.#0"
            'Curry
            .Columns(34).NumberFormat = "###,###,###,##0.##0"
            .Columns(35).NumberFormat = "###,###,###,##0.##0"
            .Columns(36).NumberFormat = "###,###,###,##0.#0"
            .Columns(37).NumberFormat = "###,###,###,##0.#0"
            .Columns(38).NumberFormat = "###,###,###,##0.#0"
            'MSG
            .Columns(39).NumberFormat = "###,###,###,##0.##0"
            .Columns(40).NumberFormat = "###,###,###,##0.##0"
            .Columns(41).NumberFormat = "###,###,###,##0.#0"
            .Columns(42).NumberFormat = "###,###,###,##0.#0"
            .Columns(43).NumberFormat = "###,###,###,##0.#0"
            'Salt
            .Columns(44).NumberFormat = "###,###,###,##0.##0"
            .Columns(45).NumberFormat = "###,###,###,##0.##0"
            .Columns(46).NumberFormat = "###,###,###,##0.#0"
            .Columns(47).NumberFormat = "###,###,###,##0.#0"
            .Columns(48).NumberFormat = "###,###,###,##0.#0"
            'TOTAL INGREDIENTS
            .Columns(49).NumberFormat = "###,###,###,##0.#0"
            .Columns(50).NumberFormat = "###,###,###,##0.#0"

            'Can
            .Columns(51).NumberFormat = "###,###,###,##0"
            .Columns(52).NumberFormat = "###,###,###,##0.#0"
            .Columns(53).NumberFormat = "###,###,###,##0.#0"
            .Columns(54).NumberFormat = "###,###,###,##0.#0"
            .Columns(55).NumberFormat = "###,###,###,##0.#0"
            'Ends
            .Columns(56).NumberFormat = "###,###,###,##0"
            .Columns(57).NumberFormat = "###,###,###,##0.#0"
            .Columns(58).NumberFormat = "###,###,###,##0.#0"
            .Columns(59).NumberFormat = "###,###,###,##0.#0"
            .Columns(60).NumberFormat = "###,###,###,##0.#0"
            'Cartons
            .Columns(61).NumberFormat = "###,###,###,##0"
            .Columns(62).NumberFormat = "###,###,###,##0.#0"
            .Columns(63).NumberFormat = "###,###,###,##0.#0"
            .Columns(64).NumberFormat = "###,###,###,##0.#0"
            .Columns(65).NumberFormat = "###,###,###,##0.#0"
            'Labels
            .Columns(66).NumberFormat = "###,###,###,##0.#0"
            .Columns(67).NumberFormat = "###,###,###,##0.#0"
            .Columns(68).NumberFormat = "###,###,###,##0.#0"
            .Columns(69).NumberFormat = "###,###,###,##0.#0"
            .Columns(70).NumberFormat = "###,###,###,##0.#0"
            'TOTAL PACKAGING
            .Columns(71).NumberFormat = "###,###,###,##0.#0"
            'LABOR
            .Columns(72).NumberFormat = "###,###,###,##0.#0"
            .Columns(73).NumberFormat = "###,###,###,##0.#0"
            'UTILITIES
            .Columns(74).NumberFormat = "###,###,###,##0.#0"
            .Columns(75).NumberFormat = "###,###,###,##0.#0"
            'OVERHEAD
            .Columns(76).NumberFormat = "###,###,###,##0.#0"
            .Columns(77).NumberFormat = "###,###,###,##0.#0"
            'TOTAL PRODUCT COST
            .Columns(78).NumberFormat = "###,###,###,##0.#0"
            .Columns(79).NumberFormat = "###,###,###,##0.#0"

            If monthEnd Then
                computeCost(True)
            Else
                computeCost()
            End If
        End With
    End Sub

    Public Sub computeCost(Optional ByVal monthEnd As Boolean = False)
        Try
            Dim ctr As Integer
            Dim totalTonnage, aveAmountPerLotAndSpecie As Double
            Dim fishCost, balFishCostForAllocation As Double
            'Dim whiteFlakesCost As Double
            Dim totalWhiteMeatForDistribution As Double
            Dim specie As String

            Dim dateFrom, dateTo As DateTime
            dateFrom = txtDateFrom.Text 'CDate("01/02/2012")
            dateTo = txtDateTo.Text 'CDate("29/02/2012")

            With grid
                If monthEnd Then
                    While ctr < .RowCount
                        '.Item(ctr, 3) += (getDentedQty(dateFrom, dateTo, .Item(ctr, 0)))
                        'If CStr(.Item(ctr, 0)).StartsWith("D") Or CStr(.Item(ctr, 0)).StartsWith("W") Then
                        '    .Item(ctr, 80) = "Flakes"
                        'Else
                        '    .Item(ctr, 80) = getProductSpecie(.Item(ctr, 0))
                        'End If

                        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                            'FW
                            If CStr(.Item(ctr, 0)).StartsWith("LS") Or CStr(.Item(ctr, 0)).StartsWith("LY") Then
                                .Item(ctr, 4) = (7.5 * 1000)
                                .Item(ctr, 5) = CDbl(.Item(ctr, 3)) * .Item(ctr, 4) * .Item(ctr, 51) / 1000
                            ElseIf CStr(.Item(ctr, 0)).StartsWith("LA") Or CStr(.Item(ctr, 0)).StartsWith("FA") Then
                                .Item(ctr, 51) = 1
                                .Item(ctr, 4) = getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0))
                                'MsgBox(.Item(ctr, 0) & " " & .Item(ctr, 4))
                                .Item(ctr, 5) = CDbl(.Item(ctr, 3)) * .Item(ctr, 4) * .Item(ctr, 51) / 1000
                            Else
                                '.Item(ctr, 3) *= 3
                                .Item(ctr, 51) = 1
                                .Item(ctr, 4) = (8 * 1000)
                                .Item(ctr, 5) = CDbl(.Item(ctr, 3)) * .Item(ctr, 4) * .Item(ctr, 51) / 1000
                            End If
                        Else
                            'If CStr(.Item(ctr, 0)).StartsWith("D") Then
                            '    .Item(ctr, 4) = getActualAverageFW(dateFrom, dateTo, "D%", .Item(ctr, 81))
                            'ElseIf CStr(.Item(ctr, 0)).StartsWith("W") Then
                            '    .Item(ctr, 4) = getActualAverageFW(dateFrom, dateTo, "W%", .Item(ctr, 81))
                            'Else
                                .Item(ctr, 4) = getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0))
                            'End If

                            .Item(ctr, 5) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 51)) * .Item(ctr, 4) / 1000
                        End If

                        specie = .Item(ctr, 80)

                        'FISH COST  '
                        'If specie.StartsWith("Big") Then
                        '    .Item(ctr, 80) = "Yellow Fin"       'CHANGE THE SPECIE FROM BE TO YF
                        '    totalTonnage = getTotalTonnageWithdraw(dateFrom, dateTo, cboShift.Text, "Yellow Fin")
                        '    aveAmountPerLotAndSpecie = (getFishCost(dateFrom, dateTo, cboShift.Text, "Yellow Fin") / getAveConversion_byProdnDate(dateFrom, dateTo, cboShift.Text, "Yellow Fin")) / 1000

                        '    balFishCostForAllocation = ((totalTonnage * aveAmountPerLotAndSpecie)) - getDarkMeatPercentageInCost("Yellow Fin")
                        '    totalWhiteMeatForDistribution = getTotalWhiteMeatForDistribution("Yellow Fin") ' + getWhitePercentageOnDarkMeat(.Item(ctr, 80)))

                        '    If CStr(.Item(ctr, 0)).StartsWith("D") Then
                        '        fishCost = ((.Item(ctr, 5) * 0.67) * 12) + ((.Item(ctr, 5) * 0.33) / totalWhiteMeatForDistribution) * balFishCostForAllocation '* whiteFlakesCost
                        '    Else
                        '        fishCost = ((.Item(ctr, 5) / 1000) / totalWhiteMeatForDistribution) * balFishCostForAllocation '
                        '    End If
                        'Else
                        totalTonnage = getTotalRoundFishProcessed(dateFrom, dateTo, "%", specie) 'getTotalTonnageWithdraw(dateFrom, dateTo, "", specie)
                        aveAmountPerLotAndSpecie = (getFishCost(dateFrom, dateTo, "", specie) / getSBDConversion(dateFrom)) / 1000

                        'getAveConversion_byProdnDate(dateFrom, dateTo, "", specie)

                        '//modify on september 7
                        '//If specie.StartsWith("Alb") Then
                        '//    balFishCostForAllocation = ((totalTonnage * aveAmountPerLotAndSpecie)) - _
                        '//        ((getDarkMeatPercentageInCost(specie, dateFrom, dateTo) * 12) + getFZDarkMeatPercentageInCost(specie) + getSpecialDarkMeatPercentageInCost(specie, dateFrom, dateTo))
                        '//Else
                            'balFishCostForAllocation = ((totalTonnage * aveAmountPerLotAndSpecie)) - _
                            '(((getDarkMeatPercentageInCost(specie, dateFrom, dateTo) * 0.67) * 12) + getFZDarkMeatPercentageInCost(specie) + getSpecialDarkMeatPercentageInCost(specie, dateFrom, dateTo))
                            balFishCostForAllocation = ((totalTonnage * aveAmountPerLotAndSpecie)) - _
                                (((getDarkMeatPercentageInCost(specie, dateFrom, dateTo) * (1 - getMeatPercentage(dateFrom, dateTo))) * 12) + getFZDarkMeatPercentageInCost(specie) + getSpecialDarkMeatPercentageInCost(specie, dateFrom, dateTo))

                            'MsgBox(.Item(ctr, 0) & " = " & (getDarkMeatPercentageInCost(specie, dateFrom, dateTo) * (1 - getMeatPercentage(dateFrom, dateTo))) * 12)
                        '//End If

                        'MsgBox(.Item(ctr, 0) & " = " & balFishCostForAllocation)

                        'MsgBox(getFZDarkMeatPercentageInCost(specie))

                        totalWhiteMeatForDistribution = getTotalWhiteMeatForDistribution(specie, dateFrom, dateTo) '+ getFZDarkMeatPercentage(specie) ' + getWhitePercentageOnDarkMeat(.Item(ctr, 80)))

                        'MsgBox(specie & " = " & totalWhiteMeatForDistribution)
                        'MsgBox(specie & " white meat: " & getTotalWhiteMeatForDistribution(specie, dateFrom, dateTo))   '& Chr(13) & _
                        'MsgBox("red meat 33%: " & getFZDarkMeatPercentage(specie))

                        'MsgBox(.Item(ctr, 0) & " " & getTotalWhiteMeatForDistribution(specie, dateFrom, dateTo))
                        'MsgBox(getFZDarkMeatPercentageInCost(specie)) ' * aveAmountPerLotAndSpecie)
                        'MsgBox(aveAmountPerLotAndSpecie)
                        'MsgBox(getDarkMeatPercentageInCost(specie, dateFrom, dateTo))

                        '//modify on september 7
                        '//If CStr(.Item(ctr, 0)).StartsWith("D0A") Then
                        '//fishCost = ((.Item(ctr, 5)) * 12)  '+ ((.Item(ctr, 5) * 0.33) / totalWhiteMeatForDistribution) * balFishCostForAllocation
                        '//ElseIf CStr(.Item(ctr, 0)).StartsWith("D0S") Or CStr(.Item(ctr, 0)).StartsWith("D0Y") Or CStr(.Item(ctr, 0)).StartsWith("D0B") Then
                        If CStr(.Item(ctr, 0)).StartsWith("D") Then
                            'fishCost = ((.Item(ctr, 5) * 0.67) * 12) + ((.Item(ctr, 5) * 0.33) / totalWhiteMeatForDistribution) * balFishCostForAllocation
                            fishCost = ((.Item(ctr, 5) * (1 - getMeatPercentage(dateFrom, dateTo))) * 12) + ((.Item(ctr, 5) * (getMeatPercentage(dateFrom, dateTo))) / totalWhiteMeatForDistribution) * balFishCostForAllocation
                        ElseIf CStr(.Item(ctr, 0)).StartsWith("R") Then
                            fishCost = ((CDbl(.Item(ctr, 5)) * 0.8) * 12) + ((.Item(ctr, 5) * 0.2) / totalWhiteMeatForDistribution) * balFishCostForAllocation
                        ElseIf CStr(.Item(ctr, 0)).StartsWith("P") Then
                            fishCost = ((CDbl(.Item(ctr, 5)) * 0.08) * 12) + ((.Item(ctr, 5) * 0.92) / totalWhiteMeatForDistribution) * balFishCostForAllocation
                        Else
                            'If CStr(.Item(ctr, 0)).StartsWith("L") Then
                            '/ 1000
                            fishCost = (.Item(ctr, 5) / totalWhiteMeatForDistribution) * balFishCostForAllocation '- getFZDarkMeatPercentageInCost(specie)) '

                            ''getDarkMeatPercentageInCost(specie) +
                            'If MsgBox((totalTonnage * aveAmountPerLotAndSpecie) & Chr(13) & _
                            '(getFZDarkMeatPercentageInCost(specie)) & Chr(13) & _
                            '((.Item(ctr, 3) * .Item(ctr, 4) * .Item(ctr, 51) / 1000) / totalWhiteMeatForDistribution) * balFishCostForAllocation & Chr(13) & _
                            '   totalWhiteMeatForDistribution & Chr(13) & _
                            '   balFishCostForAllocation, MsgBoxStyle.YesNo, "Cfdgsdfsa") = vbYes Then
                            '    End
                            'End If
                            'fishCost = (.Item(ctr, 5) / totalWhiteMeatForDistribution) * balFishCostForAllocation
                            'Else
                            '    If CStr(.Item(ctr, 80)).StartsWith("Skip") Then
                            '        fishCost = .Item(ctr, 5) * (totalWhiteMeatForDistribution / 0.5)
                            '    Else
                            '        fishCost = .Item(ctr, 5) * (totalWhiteMeatForDistribution / 0.52)
                            '    End If
                            'End If
                        End If
                        'End If

                        .Item(ctr, 6) = Format(fishCost, "###,###,###,###,##0.#0")
                        .Item(ctr, 8) = CDbl(.Item(ctr, 7)) + .Item(ctr, 6)

                        'Salt
                        .Item(ctr, 44) = computeProductBOM(.Item(ctr, 0), "salt")
                        '.Item(ctr, 45) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Salt", "Ingred%") * _
                        '    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 44) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Salt"))

                        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                            'SALT
                            .Item(ctr, 46) = CDbl(.Item(ctr, 45)) * getAverageMaterialCosts(dateFrom, dateTo, "Salt")

                            'CLEAR THE CAN ENDS ENTRY
                            .Item(ctr, 56) = 0
                        Else
                            'OIL
                            .Item(ctr, 9) = computeProductBOM(.Item(ctr, 0), "oil")
                            If materialsTotalUsage("", "Oil") > 0 Then
                                .Item(ctr, 10) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Oil - Soya%", "Ingred%") * _
                                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 9) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Oil"))
                            Else
                                .Item(ctr, 10) = "0.000"
                            End If
                            'BROTH
                            .Item(ctr, 19) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "broth")
                            If materialsTotalUsage("", "Broth") > 0 Then
                                .Item(ctr, 20) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Broth", "Ingred%") * _
                                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 19) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Broth"))
                                '*****.Item(ctr, 20) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 19) * .Item(ctr, 51)) / 1000
                            Else
                                .Item(ctr, 20) = "0.000"
                            End If
                            'Chili Fruit
                            .Item(ctr, 24) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "cf")
                            If materialsTotalUsage("", "CF") > 0 Then
                                .Item(ctr, 25) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "%fruit%", "Ingred%") * _
                                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 24) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "CF"))
                                '*****.Item(ctr, 25) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 24) * .Item(ctr, 51)) / 1000
                            Else
                                .Item(ctr, 25) = "0.000"
                            End If
                            'Chili Powder
                            .Item(ctr, 29) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "cp")
                            If materialsTotalUsage("", "CP") > 0 Then
                                .Item(ctr, 30) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Chilli Po%", "Ingred%") * _
                                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 29) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "CP"))
                                '*****.Item(ctr, 30) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 29) * .Item(ctr, 51)) / 1000
                            Else
                                .Item(ctr, 30) = "0.000"
                            End If
                            'Curry
                            .Item(ctr, 34) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "curry")
                            If materialsTotalUsage("", "Curry") > 0 Then
                                .Item(ctr, 35) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Curry%", "Ingred%") * _
                                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 34) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Curry"))
                                '*****.Item(ctr, 35) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 34) * .Item(ctr, 51)) / 1000
                            Else
                                .Item(ctr, 35) = "0.000"
                            End If
                            'MSG
                            .Item(ctr, 39) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "msg")
                            If materialsTotalUsage("", "MSG") > 0 Then
                                .Item(ctr, 40) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "MSG", "Ingred%") * _
                                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 39) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "MSG"))
                                '*****.Item(ctr, 40) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 39) * .Item(ctr, 51)) / 1000
                            Else
                                .Item(ctr, 40) = "0.000"
                            End If

                            .Item(ctr, 11) = CDbl(.Item(ctr, 10)) * getAverageMaterialCosts(dateFrom, dateTo, "Oil - Soya%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "%soya%", "Ingred%"))
                            .Item(ctr, 21) = CDbl(.Item(ctr, 20)) * getAverageMaterialCosts(dateFrom, dateTo, "Broth%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Broth", "Ingred%"))
                            .Item(ctr, 26) = CDbl(.Item(ctr, 25)) * getAverageMaterialCosts(dateFrom, dateTo, "Chilli Fr%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Chilli Fr%", "Ingred%"))
                            .Item(ctr, 31) = CDbl(.Item(ctr, 30)) * getAverageMaterialCosts(dateFrom, dateTo, "Chilli Po%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Chilli Po%", "Ingred%"))
                            .Item(ctr, 36) = CDbl(.Item(ctr, 35)) * getAverageMaterialCosts(dateFrom, dateTo, "Cur%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Cur%", "Ingred%")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                            .Item(ctr, 41) = CDbl(.Item(ctr, 40)) * getAverageMaterialCosts(dateFrom, dateTo, "MSG%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "MSG", "Ingred%"))
                            .Item(ctr, 46) = CDbl(.Item(ctr, 45)) * getAverageMaterialCosts(dateFrom, dateTo, "Salt") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Salt", "Ingred%"))

                            .Item(ctr, 13) = CDbl(.Item(ctr, 12)) + .Item(ctr, 11)
                            .Item(ctr, 23) = CDbl(.Item(ctr, 22)) + .Item(ctr, 21)
                            .Item(ctr, 28) = CDbl(.Item(ctr, 27)) + .Item(ctr, 26)
                            .Item(ctr, 33) = CDbl(.Item(ctr, 32)) + .Item(ctr, 31)
                            .Item(ctr, 38) = CDbl(.Item(ctr, 37)) + .Item(ctr, 36)
                            .Item(ctr, 43) = CDbl(.Item(ctr, 42)) + .Item(ctr, 41)

                            'ENDS
                            .Item(ctr, 57) = getTotalMaterialUsagesDetail(dateFrom, dateTo, .Item(ctr, 81), "%ends%") * _
                                ((.Item(ctr, 3)) * .Item(ctr, 56) / materialsTotalUsage(.Item(ctr, 81), "Ends"))
                            .Item(ctr, 58) = CDbl(.Item(ctr, 57)) * getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 81), "%ends%")

                            .Item(ctr, 60) = CDbl(.Item(ctr, 59)) + .Item(ctr, 58)
                        End If

                        'TOTAL SALT
                        .Item(ctr, 48) = CDbl(.Item(ctr, 47)) + .Item(ctr, 46)

                        'TOTAL INGREDIENTS
                        .Item(ctr, 50) = CDbl(.Item(ctr, 13)) + .Item(ctr, 18) + _
                                    .Item(ctr, 23) + .Item(ctr, 28) + .Item(ctr, 33) + _
                                    .Item(ctr, 38) + .Item(ctr, 43) + +.Item(ctr, 48)
                        If CDbl(.Item(ctr, 50)) = 0 Then
                            .Item(ctr, 49) = "0.00"
                        Else
                            .Item(ctr, 49) = CDbl(.Item(ctr, 50)) / .Item(ctr, 3)
                        End If

                        'CANS and LOIN BAGS
                        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                            If CStr(.Item(ctr, 80)).StartsWith("Alb") Then
                                'MsgBox(ctr & " = " & materialsTotalUsage("Bag 11%", "Loins2"))

                                .Item(ctr, 52) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Bag 11%", "%bag%") * _
                                    ((.Item(ctr, 3)) * .Item(ctr, 51) / materialsTotalUsage("Albacore", "Loins2"))
                                .Item(ctr, 53) = CDbl(.Item(ctr, 52)) * getAverageMaterialCosts(dateFrom, dateTo, "Bag 11%", "%bag%")
                            Else
                                '--MsgBox(.Item(ctr, 80) & " " & materialsTotalUsage("Bag 7.5%", "Loins2"))
                                .Item(ctr, 52) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Bag 7.5%", "%bag%") * _
                                    ((.Item(ctr, 3)) * .Item(ctr, 51) / materialsTotalUsage("", "Loins2"))
                                '--((.Item(ctr, 3)) * .Item(ctr, 51) / materialsTotalUsage(getProductCanSize(.Item(ctr, 0)), "Loins"))
                                .Item(ctr, 53) = CDbl(.Item(ctr, 52)) * getAverageMaterialCosts(dateFrom, dateTo, "Bag 7.5%", "%bag%")  'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Bag%", "%bag%"))
                            End If
                        Else
                            .Item(ctr, 52) = getTotalMaterialUsagesDetail(dateFrom, dateTo, CStr(.Item(ctr, 81)).Substring(0, 7) & "%", "%bod%") * _
                                ((.Item(ctr, 3)) * .Item(ctr, 51) / materialsTotalUsage(.Item(ctr, 81), "Cans"))
                            .Item(ctr, 53) = CDbl(.Item(ctr, 52)) * getAverageMaterialCosts(dateFrom, dateTo, CStr(.Item(ctr, 81)).Substring(0, 7) & "%", "%bod%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, CStr(.Item(ctr, 81)).Substring(0, 7) & "%", "%bod%")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "False")))
                        End If

                        .Item(ctr, 55) = CDbl(.Item(ctr, 54)) + .Item(ctr, 53)

                        'CARTONS
                        .Item(ctr, 61) = 1
                        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                            If CStr(.Item(ctr, 0)).StartsWith("F") Or CStr(.Item(ctr, 0)).StartsWith("R") Or CStr(.Item(ctr, 0)).StartsWith("LA") Then
                                .Item(ctr, 62) = "0.000"
                            Else
                                If materialsTotalUsage(.Item(ctr, 0), "Loin Bags", dateFrom, dateTo) > 0 Then
                                    .Item(ctr, 62) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Carton - Loin%", "Cartons") * _
                                        CDbl(.Item(ctr, 3)) / materialsTotalUsage(.Item(ctr, 0), "Loin Bags", dateFrom, dateTo)
                                    'materialsTotalUsage(.Item(ctr, 0), "Loin Bags", dateFrom, dateTo)
                                    'materialsTotalUsage(materials, "Cartons2", dateFrom, dateTo)
                                Else
                                    .Item(ctr, 62) = "0.000"
                                End If
                            End If
                            'If materialsTotalUsage(.Item(ctr, 0), "Loin Bags", dateFrom, dateTo) > 0 Then
                            '    .Item(ctr, 62) = getTotalMaterialUsagesDetail(dateFrom, dateTo, "Carton - Loin%", "Cartons") * _
                            '        (getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, .Item(ctr, 0), .Item(ctr, 1), "Cartons") / materialsTotalUsage(.Item(ctr, 0), "Loin Bags", dateFrom, dateTo))
                            'Else
                            '    .Item(ctr, 62) = "0.000"
                            'End If
                            .Item(ctr, 63) = .Item(ctr, 62) * getAverageMaterialCosts(dateFrom, dateTo, "Carton - Loin%", "Cartons")
                        Else
                            If materialsTotalUsage(.Item(ctr, 0), "Cartons", dateFrom, dateTo) > 0 Then
                                .Item(ctr, 62) = getTotalMaterialUsagesDetail(dateFrom, dateTo, getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), "Cartons"), "Cartons") * _
                                    (getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, .Item(ctr, 0), "", "Cartons") / materialsTotalUsage(.Item(ctr, 0), "Cartons", dateFrom, dateTo))
                            Else
                                .Item(ctr, 62) = "0.000"
                            End If
                            .Item(ctr, 63) = .Item(ctr, 62) * getAverageMaterialCosts(dateFrom, dateTo, getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), "Cartons"))
                        End If
                        .Item(ctr, 65) = .Item(ctr, 64) + .Item(ctr, 63)

                        'LABELS
                        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                            .Item(ctr, 66) = 0
                            .Item(ctr, 67) = 0
                            .Item(ctr, 68) = 0
                        Else
                            .Item(ctr, 66) = 1
                            If materialsTotalUsage(.Item(ctr, 0), "Labels", dateFrom, dateTo) > 0 Then
                                .Item(ctr, 67) = getTotalMaterialUsagesDetail(dateFrom, dateTo, getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), "Labels"), "Labels") * _
                                    (getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, .Item(ctr, 0), .Item(ctr, 1), "Labels") / materialsTotalUsage(.Item(ctr, 0), "Labels", dateFrom, dateTo))
                            Else
                                .Item(ctr, 67) = "0.000"
                            End If
                            .Item(ctr, 68) = .Item(ctr, 67) * getAverageMaterialCosts(dateFrom, dateTo, getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), "Labels"))
                        End If
                        .Item(ctr, 70) = .Item(ctr, 69) + .Item(ctr, 68)

                        'TOTAL PACKAGING MATERIALS
                        .Item(ctr, 71) = CDbl(.Item(ctr, 55)) + .Item(ctr, 60) + .Item(ctr, 65) + .Item(ctr, 70)
                        'LABOR COST STANDARD FORMAT
                        '.Item(ctr, 73) = (computeLaborRate(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                        .Item(ctr, 73) = getManufacturingAbsorptionCost(dateFrom, dateTo, "Labor") * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay(dateFrom, dateTo, .Item(ctr, 0)))  'computeLaborRate(txtProdnDate.Text) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                        'MsgBox(getTotalMeatPackedOfTheDay(dateFrom, dateTo))
                        .Item(ctr, 72) = CDbl(.Item(ctr, 73)) / .Item(ctr, 3)

                        'MsgBox(.Item(ctr, 0) & " = " & getTotalMeatPackedOfTheDay(dateFrom, dateTo, .Item(ctr, 0)))

                        'UTILITY COST STANDARD FORMAT
                        '.Item(ctr, 75) = (computeUtilityExpenses(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                        .Item(ctr, 75) = getManufacturingAbsorptionCost(dateFrom, dateTo, "Utilities") * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay(dateFrom, dateTo, .Item(ctr, 0))) 'computeUtilityExpenses(txtProdnDate.Text) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                        .Item(ctr, 74) = CDbl(.Item(ctr, 75)) / .Item(ctr, 3)


                        'OVERHEAD COST STANDARD FORMAT
                        '.Item(ctr, 77) = (computeTotalOH(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                        .Item(ctr, 77) = getManufacturingAbsorptionCost(dateFrom, dateTo, "Overhead") * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay(dateFrom, dateTo, .Item(ctr, 0))) 'computeTotalOH(txtProdnDate.Text) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                        .Item(ctr, 76) = CDbl(.Item(ctr, 77)) / .Item(ctr, 3)

                        'TOTAL PRODUCT COST
                        .Item(ctr, 79) = .Item(ctr, 8) + .Item(ctr, 50) + .Item(ctr, 71) + _
                            .Item(ctr, 73) + .Item(ctr, 75) + .Item(ctr, 77)
                        .Item(ctr, 78) = CDbl(.Item(ctr, 79)) / .Item(ctr, 3)


                        .Item(ctr, 82) = getProductDesc(CStr(.Item(ctr, 0)).Substring(0, 4) & "%")

                        ctr += 1
                    End While
                '***********************************************************************************************************************************
                'Else
                '    While ctr < .RowCount
                '        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                '            'FW
                '            If CStr(.Item(ctr, 0)).StartsWith("L") Then
                '                .Item(ctr, 4) = (7.5 * 1000)
                '                .Item(ctr, 5) = CDbl(.Item(ctr, 3)) * .Item(ctr, 4)
                '            Else
                '                .Item(ctr, 4) = (8 * 1000)
                '                .Item(ctr, 5) = CDbl(.Item(ctr, 3)) * .Item(ctr, 4)
                '            End If
                '        End If

                '        'FISH COST  '
                '        totalTonnage = getTotalTonnageWithdraw(txtProdnDate.Text, cboShift.Text, .Item(ctr, 80))  ' getLotTotalTonnage(.Item(ctr, 1), getProductSpecie(.Item(ctr, 0)))
                '        'aveAmountPerLotAndSpecie = (getAveFishCost_byProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 80)) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 80))) / 1000 'getAveAmountPerLotAndSpecie(.Item(ctr, 1), getProductSpecie(.Item(ctr, 0))) / 1000
                '        aveAmountPerLotAndSpecie = (getFishCost(txtProdnDate.Text, cboShift.Text, .Item(ctr, 80)) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 80))) / 1000 'getAveAmountPerLotAndSpecie(.Item(ctr, 1), getProductSpecie(.Item(ctr, 0))) / 1000

                '        balFishCostForAllocation = ((totalTonnage * aveAmountPerLotAndSpecie)) - getDarkMeatPercentageInCost(.Item(ctr, 80))
                '        'MsgBox("1 " & totalTonnage & Chr(13) & _
                '        '    "2 " & aveAmountPerLotAndSpecie & Chr(13) & _
                '        '    "3 " & getDarkMeatPercentageInCost(.Item(ctr, 80)))

                '        totalWhiteMeatForDistribution = (getTotalWhiteMeatForDistribution(.Item(ctr, 80))) ' + getWhitePercentageOnDarkMeat(.Item(ctr, 80)))
                '        If CStr(.Item(ctr, 0)).StartsWith("D") Then
                '            '--balFishCostForAllocation = ((totalTonnage * aveAmountPerLotAndSpecie)) - getTotalDarkMeatAllocated(.Item(ctr, 80))
                '            '--(totalTonnage * aveAmountPerLotAndSpecie) - getDarkMeatPercentageInCost(.Item(ctr, 80)) 

                '            'whiteFlakesCost = balFishCostForAllocation / totalWhiteMeatForDistribution '(getTotalFW(.Item(ctr, 80)) + getWhitePercentageOnDarkMeat(.Item(ctr, 80)))

                '            'MsgBox("67% " & (.Item(ctr, 5) * 0.67) * 12 & Chr(13) & _
                '            '    "1 " & (.Item(ctr, 5) * 0.33) & Chr(13) & _
                '            '    "2 " & totalWhiteMeatForDistribution & Chr(13) & _
                '            '    "3 " & balFishCostForAllocation)

                '            fishCost = ((.Item(ctr, 5) * 0.67) * 12) + ((.Item(ctr, 5) * 0.33) / totalWhiteMeatForDistribution) * balFishCostForAllocation '* whiteFlakesCost
                '        Else
                '            '--balFishCostForAllocation = ((totalTonnage * aveAmountPerLotAndSpecie)) - getDarkMeatPercentageInCost(.Item(ctr, 80)) 'getTotalDarkMeatAllocated(.Item(ctr, 80))

                '            'fishCost = (.Item(ctr, 5) / totalWhiteMeatForDistribution) * balFishCostForAllocation

                '            '--(getTotalFW(.Item(ctr, 80)) + getWhitePercentageOnDarkMeat(.Item(ctr, 80)))
                '            '-- REMOVED: LOT IN TOTAL DARK MEAT USED .Item(ctr, 1),

                '            fishCost = ((.Item(ctr, 5) / 1000) / totalWhiteMeatForDistribution) * balFishCostForAllocation '
                '        End If
                '        'computeTotalFW(txtProdnDate.Text, cboShift.Text, .Item(ctr, 1))

                '        .Item(ctr, 6) = Format(fishCost, "###,###,###,###,##0.#0")
                '        .Item(ctr, 8) = CDbl(.Item(ctr, 7)) + .Item(ctr, 6)

                '        'Salt
                '        .Item(ctr, 44) = computeProductBOM(.Item(ctr, 0), "salt")
                '        '.Item(ctr, 45) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 44) * .Item(ctr, 51)) / 1000
                '        .Item(ctr, 45) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "Salt", "Ingred%") * _
                '            (((CDbl(.Item(ctr, 3)) * .Item(ctr, 44) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Salt"))
                '        '*****.Item(ctr, 45) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Salt", "Ingred%")) * _
                '        '*****    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 44) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Salt"))

                '        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then

                '            'fishCost = (Me.getTotalFW(.Item(ctr, 1), .Item(ctr, 80)))  '* ((totalTonnage * aveAmountPerLotAndSpecie) - getTotalDarkMeatAllocated(.Item(ctr, 1), .Item(ctr, 80)))
                '            ''.Item(ctr, 5) /
                '            '' 
                '            '.Item(ctr, 6) = Format(fishCost, "###,###,###,###,##0.#0")
                '            '.Item(ctr, 8) = CDbl(.Item(ctr, 7)) + .Item(ctr, 6)

                '            'SALT
                '            .Item(ctr, 46) = CDbl(.Item(ctr, 45)) * getMaterialCosts(txtProdnDate.Text, "Salt") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Salt", "Ingred%"))

                '            'CLEAR THE CAN ENDS ENTRY
                '            .Item(ctr, 56) = 0
                '        Else
                '            'OIL
                '            .Item(ctr, 9) = computeProductBOM(.Item(ctr, 0), "oil")
                '            '.Item(ctr, 10) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 9) * .Item(ctr, 51)) / 1000
                '            If materialsTotalUsage("", "Oil") > 0 Then
                '                .Item(ctr, 10) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "Oil - Soya%", "Ingred%") * _
                '                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 9) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Oil"))
                '                '*****.Item(ctr, 10) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Oil - Soya%", "Ingred%")) * _
                '                '*****    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 9) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Oil"))
                '            Else
                '                .Item(ctr, 10) = "0.000"
                '            End If
                '            'BROTH
                '            .Item(ctr, 19) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "broth")
                '            If materialsTotalUsage("", "Broth") > 0 Then
                '                .Item(ctr, 20) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "Broth", "Ingred%") * _
                '                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 19) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Broth"))
                '                '*****.Item(ctr, 20) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 19) * .Item(ctr, 51)) / 1000
                '            Else
                '                .Item(ctr, 20) = "0.000"
                '            End If
                '            'Chili Fruit
                '            .Item(ctr, 24) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "cf")
                '            If materialsTotalUsage("", "CF") > 0 Then
                '                .Item(ctr, 25) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "%fruit%", "Ingred%") * _
                '                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 24) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "CF"))
                '                '*****.Item(ctr, 25) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 24) * .Item(ctr, 51)) / 1000
                '            Else
                '                .Item(ctr, 25) = "0.000"
                '            End If
                '            'Chili Powder
                '            .Item(ctr, 29) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "cp")
                '            If materialsTotalUsage("", "CP") > 0 Then
                '                .Item(ctr, 30) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "Chilli Po%", "Ingred%") * _
                '                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 29) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "CP"))
                '                '*****.Item(ctr, 30) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 29) * .Item(ctr, 51)) / 1000
                '            Else
                '                .Item(ctr, 30) = "0.000"
                '            End If
                '            'Curry
                '            .Item(ctr, 34) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "curry")
                '            If materialsTotalUsage("", "Curry") > 0 Then
                '                .Item(ctr, 35) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "Curry%", "Ingred%") * _
                '                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 34) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "Curry"))
                '                '*****.Item(ctr, 35) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 34) * .Item(ctr, 51)) / 1000
                '            Else
                '                .Item(ctr, 35) = "0.000"
                '            End If
                '            'MSG
                '            .Item(ctr, 39) = computeProductBOM(CStr(.Item(ctr, 0)).Substring(0, 4) & "%", "msg")
                '            If materialsTotalUsage("", "MSG") > 0 Then
                '                .Item(ctr, 40) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "MSG", "Ingred%") * _
                '                    (((CDbl(.Item(ctr, 3)) * .Item(ctr, 39) * .Item(ctr, 51)) / 1000) / materialsTotalUsage("", "MSG"))
                '                '*****.Item(ctr, 40) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 39) * .Item(ctr, 51)) / 1000
                '            Else
                '                .Item(ctr, 40) = "0.000"
                '            End If

                '            'If (getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True").StartsWith("Curry")) Or (getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True").StartsWith("Chil")) Then
                '            '    .Item(ctr, 11) = CDbl(.Item(ctr, 10)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "%soya%"))
                '            '    .Item(ctr, 21) = CDbl(.Item(ctr, 20)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Broth"))
                '            '    .Item(ctr, 26) = CDbl(.Item(ctr, 25)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Chilli Fr%"))
                '            '    .Item(ctr, 31) = CDbl(.Item(ctr, 30)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Chilli Po%"))
                '            '    .Item(ctr, 36) = CDbl(.Item(ctr, 35)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                '            '    '.Item(ctr, 41) = CDbl(.Item(ctr, 40)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "MSG"))
                '            '    '.Item(ctr, 46) = CDbl(.Item(ctr, 45)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Salt"))
                '            'Else
                '            '    .Item(ctr, 11) = CDbl(.Item(ctr, 10)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "%soya%")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                '            '    .Item(ctr, 21) = CDbl(.Item(ctr, 20)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Broth")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                '            '    .Item(ctr, 26) = CDbl(.Item(ctr, 25)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Chilli Fr%")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                '            '    .Item(ctr, 31) = CDbl(.Item(ctr, 30)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Chilli Po%")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                '            '    '.Item(ctr, 41) = CDbl(.Item(ctr, 40)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "MSG")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                '            '    '.Item(ctr, 46) = CDbl(.Item(ctr, 45)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Salt")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                '            'End If
                '            'COMPUTE THE COST OF EACH MATERIALS
                '            'MsgBox("Usage: " & .Item(ctr, 10) & _
                '            '    "Cost: " & getMaterialCosts(txtProdnDate.Text, "Oil - Soya%"))

                '            .Item(ctr, 11) = CDbl(.Item(ctr, 10)) * getMaterialCosts(txtProdnDate.Text, "Oil - Soya%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "%soya%", "Ingred%"))
                '            .Item(ctr, 21) = CDbl(.Item(ctr, 20)) * getMaterialCosts(txtProdnDate.Text, "Broth%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Broth", "Ingred%"))
                '            .Item(ctr, 26) = CDbl(.Item(ctr, 25)) * getMaterialCosts(txtProdnDate.Text, "Chilli Fr%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Chilli Fr%", "Ingred%"))
                '            .Item(ctr, 31) = CDbl(.Item(ctr, 30)) * getMaterialCosts(txtProdnDate.Text, "Chilli Po%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Chilli Po%", "Ingred%"))
                '            .Item(ctr, 36) = CDbl(.Item(ctr, 35)) * getMaterialCosts(txtProdnDate.Text, "Cur%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Cur%", "Ingred%")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "True")))
                '            .Item(ctr, 41) = CDbl(.Item(ctr, 40)) * getMaterialCosts(txtProdnDate.Text, "MSG%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "MSG", "Ingred%"))
                '            .Item(ctr, 46) = CDbl(.Item(ctr, 45)) * getMaterialCosts(txtProdnDate.Text, "Salt") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Salt", "Ingred%"))

                '            .Item(ctr, 13) = CDbl(.Item(ctr, 12)) + .Item(ctr, 11)
                '            .Item(ctr, 23) = CDbl(.Item(ctr, 22)) + .Item(ctr, 21)
                '            .Item(ctr, 28) = CDbl(.Item(ctr, 27)) + .Item(ctr, 26)
                '            .Item(ctr, 33) = CDbl(.Item(ctr, 32)) + .Item(ctr, 31)
                '            .Item(ctr, 38) = CDbl(.Item(ctr, 37)) + .Item(ctr, 36)
                '            .Item(ctr, 43) = CDbl(.Item(ctr, 42)) + .Item(ctr, 41)

                '            'ENDS
                '            .Item(ctr, 57) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, .Item(ctr, 81), "%ends%") * _
                '                ((.Item(ctr, 3)) * .Item(ctr, 56) / materialsTotalUsage(.Item(ctr, 81), "Ends"))
                '            .Item(ctr, 58) = CDbl(.Item(ctr, 57)) * getMaterialCosts(txtProdnDate.Text, .Item(ctr, 81), "%ends%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, CStr(.Item(ctr, 81)).Substring(0, 7) & "%", "%bod%")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "False")))
                '            '*****.Item(ctr, 57) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 81), "%ends%")) * ((.Item(ctr, 3)) * .Item(ctr, 56) / materialsTotalUsage(.Item(ctr, 81), "Ends"))
                '            '//CDbl(.Item(ctr, 3)) * .Item(ctr, 56)
                '            'If CInt(CStr(.Item(ctr, 81)).IndexOf("EOE")) > 0 Then
                '            '.Item(ctr, 58) = CDbl(.Item(ctr, 57)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, getProductMaterials(.Item(ctr, 0), "Canned Tuna", "False").Substring(0, 3) & " EOE%", "Ends"))
                '            '*****.Item(ctr, 58) = CDbl(.Item(ctr, 57)) * computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 81), "%ends%"))
                '            'Else
                '            '    .Item(ctr, 58) = CDbl(.Item(ctr, 57)) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, getProductMaterials(.Item(ctr, 0), "Canned Tuna", "False").Substring(0, 3) & "%", "Ends"))
                '            'End If

                '            .Item(ctr, 60) = CDbl(.Item(ctr, 59)) + .Item(ctr, 58)
                '        End If

                '        'TOTAL SALT
                '        .Item(ctr, 48) = CDbl(.Item(ctr, 47)) + .Item(ctr, 46)

                '        'TOTAL INGREDIENTS
                '        .Item(ctr, 50) = CDbl(.Item(ctr, 13)) + .Item(ctr, 18) + _
                '                    .Item(ctr, 23) + .Item(ctr, 28) + .Item(ctr, 33) + _
                '                    .Item(ctr, 38) + .Item(ctr, 43) + +.Item(ctr, 48)
                '        If CDbl(.Item(ctr, 50)) = 0 Then
                '            .Item(ctr, 49) = "0.00"
                '        Else
                '            .Item(ctr, 49) = CDbl(.Item(ctr, 50)) / .Item(ctr, 3)
                '        End If

                '        'CANS and LOIN BAGS
                '        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                '            .Item(ctr, 52) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "Bag%", "%bag%") * _
                '                ((.Item(ctr, 3)) * .Item(ctr, 51) / materialsTotalUsage(getProductCanSize(.Item(ctr, 0)), "Loins"))
                '            '*****.Item(ctr, 52) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Bag%", "%bag%")) * ((.Item(ctr, 3)) * .Item(ctr, 51) / materialsTotalUsage(getProductCanSize(.Item(ctr, 0)), "Loins"))
                '            .Item(ctr, 53) = CDbl(.Item(ctr, 52)) * getMaterialCosts(txtProdnDate.Text, "Bag%", "%bag%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Bag%", "%bag%"))
                '        Else
                '            .Item(ctr, 52) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, CStr(.Item(ctr, 81)).Substring(0, 7) & "%", "%bod%") * _
                '                ((.Item(ctr, 3)) * .Item(ctr, 51) / materialsTotalUsage(.Item(ctr, 81), "Cans"))
                '            '*****.Item(ctr, 52) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, CStr(.Item(ctr, 81)).Substring(0, 7) & "%", "%bod%")) * ((.Item(ctr, 3)) * .Item(ctr, 51) / materialsTotalUsage(.Item(ctr, 81), "Cans"))
                '            .Item(ctr, 53) = CDbl(.Item(ctr, 52)) * getMaterialCosts(txtProdnDate.Text, CStr(.Item(ctr, 81)).Substring(0, 7) & "%", "%bod%") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, CStr(.Item(ctr, 81)).Substring(0, 7) & "%", "%bod%")) 'getProductMaterials(.Item(ctr, 0), "Canned Tuna", "False")))
                '            '
                '        End If

                '        .Item(ctr, 55) = CDbl(.Item(ctr, 54)) + .Item(ctr, 53)

                '        'CARTONS
                '        .Item(ctr, 61) = 1
                '        'getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Cartons")     '.Item(ctr, 61) * .Item(ctr, 3)
                '        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                '            If materialsTotalUsage(.Item(ctr, 0), "Loin Bags") > 0 Then
                '                .Item(ctr, 62) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, "Carton - Loin%", "Cartons") * _
                '                    (getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Cartons") / materialsTotalUsage(.Item(ctr, 0), "Loin Bags"))
                '                '*****.Item(ctr, 62) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Carton - Loin%", "Cartons")) * _
                '                '*****(getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Cartons") / materialsTotalUsage(.Item(ctr, 0), "Loin Bags"))
                '            Else
                '                .Item(ctr, 62) = "0.000"
                '            End If
                '            .Item(ctr, 63) = .Item(ctr, 62) * getMaterialCosts(txtProdnDate.Text, "Carton - Loin%", "Cartons") 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Carton - Loin%", "Cartons"))
                '        Else
                '            If materialsTotalUsage(.Item(ctr, 0), "Cartons") > 0 Then
                '                'If .Item(ctr, 0) = "D0Y9" Or .Item(ctr, 0) = "W0S9" Then
                '                '    MsgBox("Product Code:" & .Item(ctr, 0) & Chr(13) & _
                '                '        "Material Usages: " & getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Cartons"), "Cartons") & Chr(13) & _
                '                '        "Product Usages: " & getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "", "Cartons") & Chr(13) & _
                '                '        "Total Allocation: " & materialsTotalUsage(.Item(ctr, 0), "Cartons"))
                '                'End If
                '                .Item(ctr, 62) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Cartons"), "Cartons") * _
                '                    (getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "", "Cartons") / materialsTotalUsage(.Item(ctr, 0), "Cartons"))
                '                '*****.Item(ctr, 62) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Cartons"), "Cartons")) * _
                '                '*****    (getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "", "Cartons") / materialsTotalUsage(.Item(ctr, 0), "Cartons"))
                '            Else
                '                .Item(ctr, 62) = "0.000"
                '            End If
                '            .Item(ctr, 63) = .Item(ctr, 62) * getMaterialCosts(txtProdnDate.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Cartons")) 'computeMaterials_UnitCost(txtProdnDate.Text, cboShift.Text, getPackagingMaterialsMRN_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Cartons"))
                '        End If
                '        .Item(ctr, 65) = .Item(ctr, 64) + .Item(ctr, 63)

                '        'LABELS
                '        If (getProductCategory(.Item(ctr, 0))).StartsWith("Frozen") Then
                '            .Item(ctr, 66) = 0
                '            .Item(ctr, 67) = 0
                '            .Item(ctr, 68) = 0 '.Item(ctr, 62) * computeProductMaterials(getProductMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, "Carton - Loin%"))
                '        Else
                '            .Item(ctr, 66) = 1
                '            If materialsTotalUsage(.Item(ctr, 0), "Labels") > 0 Then
                '                .Item(ctr, 67) = getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Labels"), "Labels") * _
                '                    (getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Labels") / materialsTotalUsage(.Item(ctr, 0), "Labels"))
                '                '*****.Item(ctr, 67) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Labels"), "Labels")) * _
                '                '*****(getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Labels") / materialsTotalUsage(.Item(ctr, 0), "Labels"))
                '            Else
                '                .Item(ctr, 67) = "0.000"
                '            End If
                '            .Item(ctr, 68) = .Item(ctr, 67) * getMaterialCosts(txtProdnDate.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Labels"))   'computeMaterials_UnitCost(txtProdnDate.Text, cboShift.Text, getPackagingMaterialsMRN_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Labels"))
                '        End If
                '        .Item(ctr, 70) = .Item(ctr, 69) + .Item(ctr, 68)

                '        'TOTAL PACKAGING MATERIALS
                '        .Item(ctr, 71) = CDbl(.Item(ctr, 55)) + .Item(ctr, 60) + .Item(ctr, 65) + .Item(ctr, 70)
                '        'LABOR COST STANDARD FORMAT
                '        '.Item(ctr, 73) = (computeLaborRate(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                '        .Item(ctr, 73) = getManufacturingAbsorptionCost(txtProdnDate.Text, txtProdnDate.Text, "Labor") * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())  'computeLaborRate(txtProdnDate.Text) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                '        .Item(ctr, 72) = CDbl(.Item(ctr, 73)) / .Item(ctr, 3)
                '        'UTILITY COST STANDARD FORMAT
                '        '.Item(ctr, 75) = (computeUtilityExpenses(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                '        .Item(ctr, 75) = getManufacturingAbsorptionCost(txtProdnDate.Text, txtProdnDate.Text, "Utilities") * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())  'computeUtilityExpenses(txtProdnDate.Text) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                '        .Item(ctr, 74) = CDbl(.Item(ctr, 75)) / .Item(ctr, 3)
                '        'OVERHEAD COST STANDARD FORMAT
                '        '.Item(ctr, 77) = (computeTotalOH(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                '        .Item(ctr, 77) = getManufacturingAbsorptionCost(txtProdnDate.Text, txtProdnDate.Text, "Overhead") * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())  'computeTotalOH(txtProdnDate.Text) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
                '        .Item(ctr, 76) = CDbl(.Item(ctr, 77)) / .Item(ctr, 3)

                '        'TOTAL PRODUCT COST
                '        .Item(ctr, 79) = .Item(ctr, 8) + .Item(ctr, 50) + .Item(ctr, 71) + _
                '            .Item(ctr, 73) + .Item(ctr, 75) + .Item(ctr, 77)
                '        .Item(ctr, 78) = CDbl(.Item(ctr, 79)) / .Item(ctr, 3)


                '        .Item(ctr, 82) = getProductDesc(CStr(.Item(ctr, 0)).Substring(0, 4) & "%")

                '        ctr += 1
                '    End While
                End If
            End With
        Catch e As Exception
            MsgBox("Materials doesn't have any entries in the system", MsgBoxStyle.Exclamation, "Warning")
        Finally
        End Try
    End Sub

    Public Function materialsTotalUsage(ByVal materials As String, ByVal category As String, Optional ByVal dateFrom As String = "", _
    Optional ByVal dateTo As String = "") As Double
        Dim ctr As Integer
        Dim returnValue As Double
        With grid
            Select Case category
                Case "Cans"
                    While ctr < .RowCount
                        If getProductCategory(.Item(ctr, 0)).StartsWith("Can") Then
                            If materials.Substring(0, 7) = CStr(.Item(ctr, 81)).Substring(0, 7) Then
                                returnValue += (.Item(ctr, 3) * .Item(ctr, 51))
                            End If
                        End If

                        ctr += 1
                    End While
                Case "Ends"
                    While ctr < .RowCount
                        If getProductCategory(.Item(ctr, 0)).StartsWith("Can") Then
                            If materials = .Item(ctr, 81) Then
                                returnValue += (.Item(ctr, 3) * .Item(ctr, 56))
                            End If
                        End If

                        ctr += 1
                    End While
                Case "Loins"
                    While ctr < .RowCount
                        If getProductCategory(.Item(ctr, 0)).StartsWith("Frozen") Then
                            returnValue += (.Item(ctr, 3) * .Item(ctr, 51))
                        End If

                        ctr += 1
                    End While
                Case "Loins2"
                    Dim output, perCase, albUsage As Double
                    While ctr < .RowCount
                        If CStr(.Item(ctr, 0)).StartsWith("L") Or CStr(.Item(ctr, 0)).StartsWith("F") Or CStr(.Item(ctr, 0)).StartsWith("R") Then
                            output = .Item(ctr, 3)

                            If CStr(.Item(ctr, 80)).StartsWith("Alb") Or CStr(.Item(ctr, 0)).StartsWith("F") Or CStr(.Item(ctr, 0)).StartsWith("R") Then
                                perCase = 1
                            Else
                                perCase = .Item(ctr, 51)
                            End If

                            Select Case .Item(ctr, 80).ToString
                                Case "Albacore"
                                    albUsage += (output * perCase)
                                Case "Yellow Fin", "Skipjack", "Big Eye"
                                    returnValue += (output * perCase)
                            End Select
                        End If

                        ctr += 1
                    End While

                    If materials.StartsWith("Alb") Then
                        returnValue = albUsage
                    End If
                Case "Cartons"
                    'If dateFrom = "" Then
                    '    While ctr < .RowCount
                    '        If getPackagingMaterials(txtProdnDate.Text, cboShift.Text, materials, category) = _
                    '        getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), category) Then
                    '            returnValue += getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "", "Cartons")
                    '        End If

                    '        ctr += 1
                    '    End While
                    'Else
                    While ctr < .RowCount
                        If getPackagingMaterials_byMonthEnd(dateFrom, dateTo, materials, category) = _
                        getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), category) Then
                            returnValue += getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, .Item(ctr, 0), "", "Cartons")
                        End If

                        ctr += 1
                    End While
                    'End If
                Case "Cartons2"
                    'If dateFrom = "" Then
                    '    While ctr < .RowCount
                    '        If materials = getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Cartons") Then
                    '            returnValue += getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "", "Cartons")
                    '        End If

                    '        ctr += 1
                    '    End While
                    'Else
                    While ctr < .RowCount
                        If materials = getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), "Cartons") Then
                            returnValue += getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, .Item(ctr, 0), "", "Cartons")
                        End If

                        ctr += 1
                    End While
                    'End If
                Case "Loin Bags"
                    'If dateFrom = "" Then
                    '    While ctr < .RowCount
                    '        If getProductCategory(.Item(ctr, 0)).StartsWith("Frozen") Then
                    '            returnValue += getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Cartons")
                    '        End If
                    '        ctr += 1
                    '    End While
                    'Else
                    While ctr < .RowCount
                        If CStr(.Item(ctr, 0)).StartsWith("LS") Or CStr(.Item(ctr, 0)).StartsWith("LY") Then
                            returnValue += .Item(ctr, 3)   '* .Item(ctr, 56))
                        End If

                        ctr += 1
                    End While
                    'End If
                Case "Labels"
                    'If dateFrom = "" Then
                    '    While ctr < .RowCount
                    '        If getPackagingMaterials(txtProdnDate.Text, cboShift.Text, materials, category) = _
                    '        getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), category) Then
                    '            returnValue += getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Labels")
                    '        End If

                    '        ctr += 1
                    '    End While
                    'Else
                    While ctr < .RowCount
                        If getPackagingMaterials_byMonthEnd(dateFrom, dateTo, materials, category) = _
                        getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), category) Then
                            returnValue += getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, .Item(ctr, 0), .Item(ctr, 1), "Labels")
                        End If

                        ctr += 1
                    End While
                    'End If
                Case "Labels2"
                    'If dateFrom = "" Then
                    '    While ctr < .RowCount
                    '        If materials = getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Labels") Then
                    '            returnValue += getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), .Item(ctr, 1), "Labels")
                    '        End If

                    '        ctr += 1
                    '    End While
                    'Else

                    While ctr < .RowCount
                        If materials = getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), "Labels") Then
                            returnValue += getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, .Item(ctr, 0), "", "Labels")
                        End If

                        ctr += 1
                    End While
                    '    While ctr < .RowCount
                    '        If materials = getPackagingMaterials_byMonthEnd(dateFrom, dateTo, .Item(ctr, 0), "Labels") Then
                    '            returnValue += getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, .Item(ctr, 0), "", "Labels")
                    '        End If

                    '        ctr += 1
                    'End While


                    'End If
                Case "Oil"
                    While ctr < .RowCount
                        returnValue += (CDbl(.Item(ctr, 3)) * computeProductBOM(.Item(ctr, 0), "oil") * .Item(ctr, 51)) / 1000

                        ctr += 1
                    End While
                Case "Salt"
                    While ctr < .RowCount
                        returnValue += (CDbl(.Item(ctr, 3)) * computeProductBOM(.Item(ctr, 0), "salt") * .Item(ctr, 51)) / 1000
                        'computeProductBOM(.Item(ctr, 0), "salt")

                        ctr += 1
                    End While
                Case "Broth"
                    While ctr < .RowCount
                        returnValue += (CDbl(.Item(ctr, 3)) * computeProductBOM(.Item(ctr, 0), "broth") * .Item(ctr, 51)) / 1000

                        ctr += 1
                    End While
                Case "CF"
                    While ctr < .RowCount
                        returnValue += (CDbl(.Item(ctr, 3)) * computeProductBOM(.Item(ctr, 0), "cf") * .Item(ctr, 51)) / 1000

                        ctr += 1
                    End While
                Case "CP"
                    While ctr < .RowCount
                        returnValue += (CDbl(.Item(ctr, 3)) * computeProductBOM(.Item(ctr, 0), "cp") * .Item(ctr, 51)) / 1000

                        ctr += 1
                    End While
                Case "Curry"
                    While ctr < .RowCount
                        returnValue += (CDbl(.Item(ctr, 3)) * computeProductBOM(.Item(ctr, 0), "curry") * .Item(ctr, 51)) / 1000

                        ctr += 1
                    End While
                Case "MSG"
                    While ctr < .RowCount
                        returnValue += (CDbl(.Item(ctr, 3)) * computeProductBOM(.Item(ctr, 0), "msg") * .Item(ctr, 51)) / 1000

                        ctr += 1
                    End While
            End Select
        End With

        Return returnValue
    End Function

    Public Function getTotalMeatPackedOfTheDay(ByVal dateFrom As String, ByVal dateTo As String, ByVal pCode As String) As Double
        dateFrom = Format(CDate(dateFrom), getTimeFormat())
        dateTo = Format(CDate(dateTo), getTimeFormat())

        'If dateFrom = dateTo Then
        Dim ctr As Integer
        Dim total As Double
        With grid
            While ctr < .RowCount
                'If CStr(.Item(ctr, 0)).StartsWith("D") Then
                '    total += ((CDbl(.Item(ctr, 3)) * .Item(ctr, 51)) * getActualAverageFW(dateFrom, dateTo, "D%", .Item(ctr, 81)) / 1000)
                'ElseIf CStr(.Item(ctr, 0)).StartsWith("W") Then
                '    total += ((CDbl(.Item(ctr, 3)) * .Item(ctr, 51)) * getActualAverageFW(dateFrom, dateTo, "W%", .Item(ctr, 81)) / 1000)
                'Else
                If CStr(.Item(ctr, 0)).StartsWith("LA") Or CStr(.Item(ctr, 0)).StartsWith("F") Or CStr(.Item(ctr, 0)).StartsWith("R") Then
                    total += ((CDbl(.Item(ctr, 3)) * 1) * getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0)) / 1000)

                    '                    MsgBox(ctr & " = " & .Item(ctr, 3) & ", " & getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0)) & " = " & total)
                Else
                    total += ((CDbl(.Item(ctr, 3)) * .Item(ctr, 51)) * getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0)) / 1000)
                End If

                'End If

                'total += ((CDbl(.Item(ctr, 3)) * .Item(ctr, 51)) * getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0)) / 1000)
                '.Item(ctr, 5) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 51)) * .Item(ctr, 4) / 1000
                '.Item(ctr, 5)

                ctr += 1
            End While
        End With

        Return total
        'Else
        'Return getTotalMeat_ProdnDate(dateFrom, dateTo, pCode)
        'End If
    End Function

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Timer1.Enabled = True
        'displayProductForCosting()
        'saveDataCosting()

        'Dim f As New frmPrintProductCosting
        'f.displayReport()
        'f.ShowDialog(Me)

        Dim dateFrom As DateTime = txtDateFrom.Value '"01/02/2012"
        Dim dateTo As DateTime = txtDateTo.Value '"29/02/2012"

        If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
            saveDataCosting()                   ' SAVE THE DATA OF THE TABLE TO TMP_PRINTPRODUCTCOSTING
            deletePrintProductCostingTable()    ' EMPTY THE TABLE TMP_PRINTPRODUCTCOSTING_TABLE

            collectData(True, dateFrom, dateTo)  ' RE-ENTRY THE DATA TO TMP_PRINTPRODUCTCOSTING_TABLE
            'displayProductForCosting()          ' RE-QUERY TO COMPUTE FOR THE COSTS OF THE MATERIALS

            displayProductForCosting(True)          ' REQUERY TO DISPLAY THE COST DISTRIBUTION

            ' display wait cursor
            Me.Cursor = Cursors.WaitCursor
            ' various variables
            Dim row As Integer
            Dim col As Integer
            Dim rowCount As Integer
            Dim colCount As Integer
            Dim cell As String
            Dim rowcell As Integer

            ' Excel Variables
            Dim excelApp As New Excel.Application
            Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = _
                CType(excelBook.Worksheets(1), Excel.Worksheet)

            'QUERY THE TMP_PRINTPRODUCTCOSTING_TABLE TO GET THE LISTS OF MATERIALS AND OVERHEADDS
            gridMaterials.DataSource = displayDirectMaterialsSummary(dateFrom, dateTo).Tables(0)  'displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0)        'UNION OF QUERY OF FISH AND MATERIALS FROM TMP_PRINTPRODUCTCOSTING_TABLE

            ' get count of rows and count of columns
            rowCount = gridMaterials.RowCount 'displayDirectMaterialsSummary(dateFrom, dateTo).Tables(0).Rows.Count  'displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0).Rows.Count  'objDataSet.Tables(0).Rows.Count()
            colCount = 50 'displaySummary.Tables(0).Columns.Count 'objDataSet.Tables(0).Columns.Count()

            ' add the column headings
            'excelWorksheet.Range("F1").Value = "D0S0"
            'excelWorksheet.Range("F2").Value = "Cases Produced"
            'For col = 0 To colCount - 1
            '    row = 1
            '    cell = GetExcelColumn(col) & row.ToString
            '    'excelWorksheet.Range(cell).Value = grdFieldnetData.TableStyles(0).GridColumnStyles(col).HeaderText
            '    'excelWorksheet.Range(cell).ColumnWidth = grdFieldnetData.TableStyles(0).GridColumnStyles(col).Width / 4
            'Next
            Dim ctr As Integer
            col = 5     'STARTS AT COLUMN E

            deletePrintProductCostDist()

            Dim revPCode As String
            Dim revPDesc As String
            With grid
                While ctr < .RowCount
                    If ctr = 21 Then col = 0
                    If ctr >= 21 Then
                        cell = "A" & GetExcelColumn(col)  ' & col) '& "1"
                    Else
                        cell = GetExcelColumn(col) '& "1"
                    End If

                    excelWorksheet.Range(cell & "1").Value = .Item(ctr, 0) ').Substring(0, 4)
                    excelWorksheet.Range(cell & "2").Value = getProductDesc(grid.Item(ctr, 0)) '"" 'grid.Item(ctr, 1)
                    excelWorksheet.Range(cell & "3").Value = .Item(ctr, 3)

                    revPCode = getRevisedProductCode(.Item(ctr, 0), excelWorksheet.Range(cell & "2").Value, False)
                    revPDesc = getRevisedProductCode(.Item(ctr, 0), excelWorksheet.Range(cell & "2").Value, True)

                    If Not validateProductCostDist(revPCode) Then
                        saveNewPrintProductCostDist(revPCode, _
                            revPDesc, 0, excelWorksheet.Range(cell & "3").Value)

                        If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                            deleteProductCost(dateFrom, revPCode)

                            saveNewProductCost(dateFrom, revPCode, revPDesc, 0, excelWorksheet.Range(cell & "3").Value)
                        End If
                    Else
                        updateProductCostDist_Output(revPCode, excelWorksheet.Range(cell & "3").Value + getProductCostDist_Output(revPCode))

                        If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                            updateProductCost_Output(dateFrom, revPCode, getProductCostDist_Output(revPCode))
                            'excelWorksheet.Range(cell & "3").Value) ' +
                        End If
                    End If

                    col += 1
                    ctr += 1
                End While


                ' now add the data elements
                Dim colCtr As Integer
                For row = 0 To rowCount - 1         'USED TO COLLECT AND PUT ALL THE DIRECT MATERIALS TO THE ROWS IN EXCEL
                    rowcell = row + 4               'START AT ROW 4

                    colCtr = 0
                    For col = 0 To (.RowCount + gridMaterials.Columns.Count) - 1  'colCount - 1
                        '***REMOVED ***
                        'displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0).Columns.Count) - 1  'colCount - 1
                        'If col = 25 Then col = 0
                        'If col > 24 Then
                        '    cell = GetExcelColumn("A" & col) '& rowcell.ToString
                        'Else
                        '    cell = GetExcelColumn(col) '& rowcell.ToString
                        'End If
                        '**************

                        If colCtr = 26 Then col = 0
                        If colCtr >= 26 Then
                            cell = "A" & GetExcelColumn(col) '& rowcell.ToString
                        Else
                            cell = GetExcelColumn(col) '& rowcell.ToString
                        End If

                        If colCtr < gridMaterials.Columns.Count Then   'displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0).
                            'DISPLAY THE MATERIALS TO ROW
                            excelWorksheet.Range(cell & rowcell.ToString).Value = gridMaterials.Item(row, col)

                            'CHECK THE SPECIE FOR SJ AND YF AND COMPUTE THE COST
                            If CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Skip") >= 0 Or _
                            CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Yell") >= 0 Or _
                            CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Big") >= 0 Or _
                            CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Alb") >= 0 Then
                                Dim unitCostFish As Double = (getFishCost(dateFrom, dateTo, "", excelWorksheet.Range("B" & rowcell.ToString).Text) / getSBDConversion(dateFrom)) / 1000   '(getFishCost(txtProdnDate.Text, cboShift.Text, excelWorksheet.Range("B" & rowcell.ToString).Text) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, excelWorksheet.Range("B" & rowcell.ToString).Text)) / 1000
                                'getAveConversion_byProdnDate(dateFrom, dateTo, "", excelWorksheet.Range("B" & rowcell.ToString).Text)

                                excelWorksheet.Range("D" & rowcell.ToString).Value = unitCostFish
                                If Not CStr(excelWorksheet.Range("C" & rowcell.ToString).Text) = "" Then
                                    excelWorksheet.Range("E" & rowcell.ToString).Value = CDbl(excelWorksheet.Range("C" & rowcell.ToString).Text) * unitCostFish
                                End If
                            End If
                        Else
                            If getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Can Bodies" Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                                    excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Cans")
                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If

                            ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Can Ends" Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                                    excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Ends")
                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If

                            ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Ingredients" Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                                    excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Ingredients")
                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If

                            ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Cartons" Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons2_Labels2(dateFrom, dateTo, _
                                    excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                    excelWorksheet.Range("B" & rowcell.ToString).Text, "Cartons", excelWorksheet.Range(cell & "3").Text)
                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If

                            ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Labels" Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons2_Labels2(dateFrom, dateTo, _
                                    excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                    excelWorksheet.Range("B" & rowcell.ToString).Text, "Labels")
                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If
                                'excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons_Labels(txtProdnDate.Text, cboShift.Text, _
                                '    excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                '    excelWorksheet.Range("B" & rowcell.ToString).Text, "Labels")

                            ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).StartsWith("Bag 7") Then  'getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Loin Bags" Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                                    excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Loin Bags")

                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If
                            ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).StartsWith("Bag 11") Then  'getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Loin Bags" Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                                    excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Loin Bags_AL")

                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If
                                '                '    '** REMOVED THIS PORTION *****
                                '                '    'excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons_Labels(txtProdnDate.Text, cboShift.Text, _
                                '                '    '    excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                '                '    '    "%loin%", "Loin Bags")
                                '                '    '** REMOVED THIS PORTION *****
                                '                '    'ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Labor") >= 0 Then
                                '                '    '    excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Labor_OH(txtProdnDate.Text, cboShift.Text, _
                                '                '    '        excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                '                '    '        "Labor")
                                '                '    'ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Supp") >= 0 Then
                                '                '    '    excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Labor_OH(txtProdnDate.Text, cboShift.Text, _
                                '                '    '        excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                '                '    '        "OH")
                                '                '    'ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Fuel") >= 0 Then
                                '                '    '    excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Utilities(txtProdnDate.Text, _
                                '                '    '        excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                '                '    '        "Fuel")
                                '                '    'ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Elect") >= 0 Then
                                '                '    '    excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Utilities(txtProdnDate.Text, _
                                '                '    '        excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                '                '    '        "Electricity")
                            ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Labor") >= 0 Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getManufacturingAbsorption(dateFrom, dateTo, _
                                    excelWorksheet.Range(cell & "1").Text, "Labor") 'excelWorksheet.Range(cell & "2").Text
                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("C" & rowcell.ToString).Text, "0", _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    '
                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If

                            ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Utilities") >= 0 Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getManufacturingAbsorption(dateFrom, dateTo, _
                                    excelWorksheet.Range(cell & "1").Text, "Utilities") 'excelWorksheet.Range(cell & "2").Text
                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("C" & rowcell.ToString).Text, "0", _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    'excelWorksheet.Range("D" & rowcell.ToString).Text

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If

                            ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Overhead") >= 0 Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getManufacturingAbsorption(dateFrom, dateTo, _
                                    excelWorksheet.Range(cell & "1").Text, "Overhead")  'excelWorksheet.Range(cell & "2").Text,
                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range("C" & rowcell.ToString).Text, "0", _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    'excelWorksheet.Range("D" & rowcell.ToString).Text

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            excelWorksheet.Range("D" & rowcell.ToString).Text, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If
                                '                '    'ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Elect") >= 0 Then
                                '                '    '    excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Utilities(txtProdnDate.Text, _
                                '                '    '        excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                                '                '    '        "Electricity")

                            ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Skip") >= 0 Or _
                            CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Yell") >= 0 Or _
                            CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Big") >= 0 Or _
                            CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Alb") >= 0 Then
                                excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Specie(excelWorksheet.Range(cell & "1").Text, _
                                    excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text)

                                Dim fishCost As Double = (getFishCost(dateFrom, dateTo, "", excelWorksheet.Range("B" & rowcell.ToString).Text) / getSBDConversion(dateFrom)) / 1000   '(getFishCost(txtProdnDate.Text, cboShift.Text, excelWorksheet.Range("B" & rowcell.ToString).Text) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, excelWorksheet.Range("B" & rowcell.ToString).Text)) / 1000

                                If excelWorksheet.Range(cell & rowcell.ToString).Value > 0 Then
                                    saveNewPrintProductCostDist_Details(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                        fishCost, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                        excelWorksheet.Range(cell & rowcell.ToString).Value)
                                    'excelWorksheet.Range("D" & rowcell.ToString).Text

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        saveNewProductCost_Details(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            excelWorksheet.Range("B" & rowcell.ToString).Text, excelWorksheet.Range("C" & rowcell.ToString).Text, _
                                            fishCost, excelWorksheet.Range("E" & rowcell.ToString).Text, _
                                            excelWorksheet.Range(cell & rowcell.ToString).Value)
                                        'excelWorksheet.Range("D" & rowcell.ToString).Text
                                    End If

                                    updateProductCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                        getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))

                                    If Format(CDate(dateFrom), getTimeFormat()) = Format(CDate(dateTo), getTimeFormat()) Then
                                        updateProductCost_Cost(dateFrom, getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False), _
                                            getUnitCost(getRevisedProductCode(excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Value, False)))
                                    End If
                                End If
                            End If
                        End If

                        colCtr += 1
                    Next
                Next

            End With
            ' turn off wait cursor
            Me.Cursor = Cursors.Default

            ' view the spread sheet
            'excelApp.Sheets.PrintPreview()
            'excelApp.Visible = True

            printCostDist()
        Else
            'Dim f As New frmPrintProductCosting
            'f.displayReport_toDate(txtDateFrom.Text, txtDateTo.Text)
            'f.ShowDialog(Me)
        End If

        Timer1.Enabled = False
        If lblWait.Visible = True Then lblWait.Visible = False
    End Sub

    Public Function getRevisedProductCode(ByVal pCode As String, ByVal pDesc As String, ByVal desc As Boolean) As String
        Dim revPCode, revPDesc As String

        Select Case pCode
            Case "D0S2", "D0Y2", "D0B2", "D0A2"
                revPCode = "SB 100g" '"Dark Flakes 100g"
                revPDesc = "SB 100g" '"Dark Flakes 100g"
            Case "D0S3", "D0Y3", "D0B3", "D0A3"
                revPCode = "SB 180g" '"Dark Flakes 180g"
                revPDesc = "SB 180g" '"Dark Flakes 180g"
            Case "D0S9", "D0Y9", "D0B9", "D0A9"
                revPCode = "SB 250g" '"Dark Flakes 250g"
                revPDesc = "SB 250g" '"Dark Flakes 250g"
            Case "D0S5", "D0Y5", "D0B5", "D0A5"
                revPCode = "SB 380g" '"Dark Flakes 380g"
                revPDesc = "SB 380g" '"Dark Flakes 380g"

            Case "W0S2", "W0Y2", "W0B2", "W0A2"
                revPCode = "WF 100g" '"White Flakes 100g"
                revPDesc = "WF 100g" '"White Flakes 100g"
            Case "W0S3", "W0Y3", "W0B3", "W0A3"
                revPCode = "WF 180g" '"White Flakes 180g"
                revPDesc = "WF 180g" '"White Flakes 180g"
            Case "W0S9", "W0Y9", "W0B9", "W0A9"
                revPCode = "WF 250g" '"White Flakes 250g"
                revPDesc = "WF 250g" '"White Flakes 250g"
            Case "W0S5", "W0Y5", "W0B5", "W0A5"
                revPCode = "WF 380g" '"White Flakes 380g"
                revPDesc = "WF 380g" '"White Flakes 380g"

            Case "RSM1", "RSX1", "RYS1", "RAS1", "RBS1"
                revPCode = "FZ RF Bag"
                revPDesc = "FZ RF Bag"
            Case "FYS1", "FSX1", "FBS1", "FBX1"
                revPCode = "FZ WF Bag"
                revPDesc = "FZ WF Bag"

            Case "LSX1", "LSS1", "LSM1", "LSL1"
                revPCode = "FZ Loins SJ"
                revPDesc = "FZ Loins SJ"
            Case "LYX1", "LYS1", "LYM1", "LYL1"
                revPCode = "FZ Loins YF"
                revPDesc = "FZ Loins YF"
            Case "LAS1", "LAL1", "FAS1"
                revPCode = "FZ Loins AL"
                revPDesc = "FZ Loins AL"

            Case Else
                revPCode = pCode
                revPDesc = pDesc
        End Select

        If desc Then
            Return revPDesc
        Else
            Return revPCode
        End If
    End Function

    Public Sub printCostDist()
        'Dim f As New frmPrintProductCosting
        'f.displayReport_Dist(txtDateFrom.Text, txtDateTo.Text)
        'f.ShowDialog(Me)
    End Sub

    Public Function getForExcel_Materials(ByVal pCode As String, ByVal lot As String, _
    ByVal size As String, ByVal category As String) As Double
        Dim ctr As Integer
        Dim returnValue As Double
        Dim divisor As Double
        With grid
            Select Case category
                Case "Cans"
                    While ctr < .RowCount
                        If getMaterialsCategory(size).StartsWith("Can") And getMaterialsCategory(.Item(ctr, 81)).StartsWith("Can") Then
                            If pCode = .Item(ctr, 0) And size.Substring(0, 7) = CStr(.Item(ctr, 81)).Substring(0, 7) Then
                                'And Format(CLng(lot), "0#####") = .Item(ctr, 1)
                                returnValue += .Item(ctr, 55)
                                divisor += 1
                            End If
                        End If

                        ctr += 1
                    End While
                Case "Ends"
                    While ctr < .RowCount
                        If pCode = .Item(ctr, 0) And size = .Item(ctr, 81) Then
                            'And Format(CLng(lot), "0#####") = .Item(ctr, 1)
                            returnValue += .Item(ctr, 60)
                            divisor += 1
                        End If

                        ctr += 1
                    End While
                Case "Loin Bags"
                    While ctr < .RowCount
                        If getProductCategory(pCode).StartsWith("Frozen") Then
                            If pCode = .Item(ctr, 0) And Not CStr(.Item(ctr, 80)).StartsWith("Alb") Then
                                'And Format(CLng(lot), "0#####") = .Item(ctr, 1)
                                returnValue += .Item(ctr, 55)
                                divisor += 1
                            End If
                        End If

                        ctr += 1
                    End While
                Case "Loin Bags_AL"
                    While ctr < .RowCount
                        If getProductCategory(pCode).StartsWith("Frozen") Then
                            If pCode = .Item(ctr, 0) And CStr(.Item(ctr, 80)).StartsWith("Alb") Then
                                'And Format(CLng(lot), "0#####") = .Item(ctr, 1)
                                returnValue += .Item(ctr, 55)
                                divisor += 1
                            End If
                        End If

                        ctr += 1
                    End While
                Case "Ingredients"
                    If size.IndexOf("Oil") >= 0 Then
                        While ctr < .RowCount
                            If pCode = .Item(ctr, 0) Then 'And Format(CLng(lot), "0#####") = .Item(ctr, 1) Then
                                returnValue += .Item(ctr, 13)
                                divisor += 1
                            End If

                            ctr += 1
                        End While
                    ElseIf size.IndexOf("Salt") >= 0 Then
                        While ctr < .RowCount
                            If pCode = .Item(ctr, 0) Then 'And Format(CLng(lot), "0#####") = .Item(ctr, 1) Then
                                returnValue += .Item(ctr, 48)
                                divisor += 1
                            End If

                            ctr += 1
                        End While
                    ElseIf size.IndexOf("Curry") >= 0 Then
                        While ctr < .RowCount
                            If pCode = .Item(ctr, 0) Then 'And Format(CLng(lot), "0#####") = .Item(ctr, 1) Then
                                returnValue += .Item(ctr, 38)
                                divisor += 1
                            End If

                            ctr += 1
                        End While
                    ElseIf size.IndexOf("MSG") >= 0 Then
                        While ctr < .RowCount
                            If pCode = .Item(ctr, 0) Then 'And Format(CLng(lot), "0#####") = .Item(ctr, 1) Then
                                returnValue += .Item(ctr, 43)
                                divisor += 1
                            End If

                            ctr += 1
                        End While
                    ElseIf size.IndexOf("Chilli Pow") >= 0 Then
                        While ctr < .RowCount
                            If pCode = .Item(ctr, 0) Then 'And Format(CLng(lot), "0#####") = .Item(ctr, 1) Then
                                returnValue += .Item(ctr, 33)
                                divisor += 1
                            End If

                            ctr += 1
                        End While
                    ElseIf size.IndexOf("Chilli Fru") >= 0 Then
                        While ctr < .RowCount
                            If pCode = .Item(ctr, 0) Then 'And Format(CLng(lot), "0#####") = .Item(ctr, 1) Then
                                returnValue += .Item(ctr, 28)
                                divisor += 1
                            End If

                            ctr += 1
                        End While
                    End If
            End Select
        End With

        If returnValue = 0 Then
            Return returnValue
        Else
            Return returnValue / divisor
        End If
    End Function

    Public Function getForExcel_Cartons2_Labels2(ByVal dateFrom As String, ByVal dateTo As String, _
    ByVal pCode As String, ByVal lot As String, ByVal materials As String, ByVal category As String, Optional ByVal output As String = "") As Double
        Dim returnValue As Double

        If category = "Loin Bags" Then
            'MsgBox(pCode & ": " & getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) & Chr(13) & _
            '    "Total tonnage: " & materialsTotalUsage(materials, "Loins"))
            'MsgBox(pCode & Chr(13) & _
            '    "Materials: " & getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(prodnDate, shift, materials, "%bag%")) & Chr(13) & _
            '    "Usage: " & getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) & Chr(13) & _
            '    "Total Usages: " & materialsTotalUsage(materials, "Loins") & Chr(13) & _
            '    "Amount: " & computeProductMaterials(getMRN_ByProdnDate(prodnDate, shift, materials, "%bag%")))

            'returnValue = (getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(prodnDate, shift, materials, "%bag%")) * _
            '    (getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) / materialsTotalUsage(materials, "Loins"))) * _
            '    (computeProductMaterials(getMRN_ByProdnDate(prodnDate, shift, materials, "%bag%")))

            returnValue = (getTotalMaterialUsagesDetail(dateFrom, dateTo, materials, "%bag%") * _
                (getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, pCode, "", materials, category) / materialsTotalUsage(materials, "Loins", dateFrom, dateTo))) * _
                getAverageMaterialCosts(dateFrom, dateTo, materials, "%bag%")
            'getMaterialCosts(txtProdnDate.Text, materials, "%bag%")
        Else
            If category = "Cartons" Then
                '//getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, materials, category))
                If materialsTotalUsage(materials, "Cartons2", dateFrom, dateTo) = 0 Then 'getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, pCode, "", materials, category) = 0 Then
                    Return 0
                Else
                    'returnValue = (getTotalMaterialUsagesDetail(dateFrom, dateTo, materials, "Cartons") * _
                    '    (getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, pCode, "", materials, category) / materialsTotalUsage(materials, "Cartons2", dateFrom, dateTo))) * _
                    '    getAverageMaterialCosts(dateFrom, dateTo, materials)

                    'getProductFGOutput(dateFrom, dateTo, pCode, materials)
                    'materialsTotalUsage(pCode, "Loin Bags", dateFrom, dateTo)

                    If pCode.StartsWith("F") Or pCode.StartsWith("R") Or pCode.StartsWith("LA") Then
                        Return 0
                    Else
                        If materials = getPackagingMaterials_byMonthEnd(dateFrom, dateTo, pCode, "Cartons") Then
                            returnValue = (getTotalMaterialUsagesDetail(dateFrom, dateTo, materials, "Cartons") * _
                                (getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, pCode, "", "Cartons") / materialsTotalUsage(materials, "Cartons2", dateFrom, dateTo))) * _
                                getAverageMaterialCosts(dateFrom, dateTo, materials)
                        Else
                            returnValue = 0
                        End If
                    End If


                    '--materialsTotalUsage(materials, "Cartons", dateFrom, dateTo)
                    '//computeProductMaterials(getMRN_ByProdnDate(prodnDate, shift, materials, category))  'getMaterialsCategory(materials)
                End If
            Else 'If category = "Labels" Then
                'getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Cartons"), "Cartons") * _
                '(getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text,  .Item(ctr, 0), "", "Cartons") / materialsTotalUsage(.Item(ctr, 0), "Cartons"))
                '//getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, materials, category))
                If materialsTotalUsage(materials, "Labels2", dateFrom, dateTo) = 0 Then 'materialsTotalUsage(materials, "Labels2", dateFrom, dateTo) = 0 Then 'getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, pCode, "", materials, category) = 0 Then
                    Return 0
                Else
                    If materials = getPackagingMaterials_byMonthEnd(dateFrom, dateTo, pCode, "Labels") Then
                        returnValue = (getTotalMaterialUsagesDetail(dateFrom, dateTo, materials, "Labels") * _
                            (getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, pCode, "", "Labels") / materialsTotalUsage(materials, "Labels2", dateFrom, dateTo))) * _
                            getAverageMaterialCosts(dateFrom, dateTo, materials)
                    Else
                        returnValue = 0
                    End If

                    'returnValue = (getTotalMaterialUsagesDetail(dateFrom, dateTo, materials, "Labels") * _
                    '    (getTotalPackagingMaterialsUsage_Cartons_Labels(dateFrom, dateTo, pCode, "", materials, category) / materialsTotalUsage(materials, "Labels2", dateFrom, dateTo))) * _
                    '    getAverageMaterialCosts(dateFrom, dateTo, materials)

                    '//CHANGE DUE TO CHANGES ON MATERIALS computeProductMaterials(getMRN_ByProdnDate(prodnDate, shift, materials, category))  'getMaterialsCategory(materials)
                End If
                'Else
                'returnValue = getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) * _
                '    (computeProductMaterials(getMRN_ByProdnDate(prodnDate, shift, materials, getMaterialsCategory(materials))))
            End If

        End If
        'Format(CInt(lot), "0#####")

        Return returnValue
    End Function

    Public Function getForExcel_Cartons_Labels(ByVal prodnDate As String, ByVal shift As String, _
    ByVal pCode As String, ByVal lot As String, ByVal materials As String, ByVal category As String) As Double
        Dim returnValue As Double

        'If category = "Loin Bags" Then
        '    returnValue = (getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, materials, "%bag%") * _
        '        (getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) / materialsTotalUsage(materials, "Loins"))) * _
        '        getMaterialCosts(txtProdnDate.Text, materials, "%bag%")
        'Else
        '    If category = "Cartons" Then
        '        '//getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, materials, category))
        '        If getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) = 0 Then
        '            Return 0
        '        Else
        '            returnValue = (getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, materials, "Cartons") * _
        '                (getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) / materialsTotalUsage(materials, "Cartons2"))) * _
        '                getMaterialCosts(txtProdnDate.Text, materials)
        '            '//computeProductMaterials(getMRN_ByProdnDate(prodnDate, shift, materials, category))  'getMaterialsCategory(materials)
        '        End If
        '    Else 'If category = "Labels" Then
        '        'getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, getPackagingMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 0), "Cartons"), "Cartons") * _
        '        '(getPackagingMaterialsUsage_Cartons_Labels(txtProdnDate.Text, cboShift.Text,  .Item(ctr, 0), "", "Cartons") / materialsTotalUsage(.Item(ctr, 0), "Cartons"))
        '        '//getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, materials, category))
        '        If getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) = 0 Then
        '            Return 0
        '        Else
        '            returnValue = (getMaterialUsagesDetail(txtProdnDate.Text, cboShift.Text, materials, "Labels") * _
        '            (getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) / materialsTotalUsage(materials, "Labels2"))) * _
        '            getMaterialCosts(txtProdnDate.Text, materials)
        '            '//CHANGE DUE TO CHANGES ON MATERIALS computeProductMaterials(getMRN_ByProdnDate(prodnDate, shift, materials, category))  'getMaterialsCategory(materials)
        '        End If
        '        'Else
        '        'returnValue = getPackagingMaterialsUsage_Cartons_Labels(prodnDate, shift, pCode, "", materials, category) * _
        '        '    (computeProductMaterials(getMRN_ByProdnDate(prodnDate, shift, materials, getMaterialsCategory(materials))))
        '    End If

        'End If
        ''Format(CInt(lot), "0#####")

        Return returnValue
    End Function

    Public Function getManufacturingAbsorption(ByVal dateFrom As String, ByVal dateTo As String, ByVal pCode As String, ByVal category As String) As Double
        Dim returnValue As Double
        Dim ctr As Integer

        returnValue = getManufacturingAbsorptionCost(dateFrom, dateTo, pCode, category) * (getTotalFW_perProduct(pCode, "") / getTotalMeatPackedOfTheDay(dateFrom, dateTo, pCode))
        'Format(CInt(lot), "0#####")

        Return returnValue

        'With grid
        '    While ctr < .RowCount
        '        Select Case category
        '            Case "Labor"
        '                returnValue += .Item(ctr, 73)
        '            Case "Utilities"
        '                returnValue += .Item(ctr, 75)
        '            Case "Overhead"
        '                returnValue += .Item(ctr, 77)
        '        End Select

        '        ctr += 1
        '    End While
        'End With

        'Return returnValue
    End Function

    'Public Function getManufacturingAbsorptionCost(ByVal dateFrom As String, ByVal dateTo As String, ByVal category As String) As Double
    '    Dim returnValue As Double
    '    Dim ctr As Integer

    '    'returnValue = getManufacturingAbsorptionCost(dateFrom, dateTo, "Labor") * (getTotalFW_perProduct(pCode, "") / getTotalMeatPackedOfTheDay())
    '    ''Format(CInt(lot), "0#####")

    '    'Return returnValue

    '    With grid
    '        While ctr < .RowCount
    '            Select Case category
    '                Case "Labor"
    '                    returnValue += .Item(ctr, 73)
    '                Case "Utilities"
    '                    returnValue += .Item(ctr, 75)
    '                Case "Overhead"
    '                    returnValue += .Item(ctr, 77)
    '            End Select

    '            ctr += 1
    '        End While
    '    End With

    '    Return returnValue
    'End Function

    'Public Function getForExcel_Utilities(ByVal prodnDate As String, ByVal pCode As String, _
    'ByVal lot As String, ByVal category As String) As Double
    '    Dim returnValue As Double

    '    returnValue = computeUtilityExpenses(prodnDate, category) * (getTotalFW_perProduct(pCode, "") / getTotalMeatPackedOfTheDay(txtDateFrom.Text, txtDateTo.Text))
    '    'Format(CInt(lot), "0#####")

    '    Return returnValue
    'End Function

    Public Function getTotalFW_perProduct(ByVal pCode As String, ByVal lot As String) As Double
        Dim ctr As Integer
        Dim returnValue As Double
        With grid
            While ctr < .RowCount
                If pCode = .Item(ctr, 0) Then 'And lot = .Item(ctr, 1) Then
                    returnValue = .Item(ctr, 5)
                    Exit While
                End If

                ctr += 1
            End While
        End With

        Return returnValue
    End Function

    Public Function getForExcel_Specie(ByVal pCode As String, ByVal lot As String, ByVal specie As String) As Double
        Dim ctr As Integer
        Dim returnValue As Double
        With grid
            While ctr < .RowCount
                'If specie = "Yellow Fin" Then
                '    If pCode = .Item(ctr, 0) And (specie = "Yellow Fin" Or specie = "Big Eye") Then
                '        returnValue = .Item(ctr, 8)
                '        Exit While
                '    End If
                'Else
                If pCode = .Item(ctr, 0) And specie = .Item(ctr, 80) Then
                    returnValue = .Item(ctr, 8)
                    Exit While
                End If
                'End If

                ctr += 1
            End While
        End With

        Return returnValue
    End Function

    Public Function getForExcel_Labor_OH(ByVal prodnDate As String, ByVal shift As String, _
    ByVal pCode As String, ByVal lot As String, ByVal category As String) As Double
        Dim ctr As Integer
        Dim returnValue As Double
        With grid
            returnValue = getManufacturingAbsorption_Labor_OH(prodnDate, shift, _
                pCode, "", category)
            'Format(CInt(lot), "0#####")

            ctr += 1
        End With

        Return returnValue
    End Function

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        'displayProductForCosting()
        displayProductForCosting(True)
        Try
            Dim reply As String = MsgBox("Are you sure you want to export the table to excel file?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then

                saveDataCosting()

                Dim c As New SqlClient.SqlConnection
                c.ConnectionString = getConnectionString()
                c.Open()

                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandText = "proc_report_ProductCosting"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = c

                Dim da As New SqlClient.SqlDataAdapter
                da.SelectCommand = cmd

                Dim ds As New DataSet("TRAKIM")
                da.Fill(ds)

                exportFile(ds)

                ds.Dispose()
                da.Dispose()
                c.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub saveDataCosting()
        deletePrintProductCosting()

        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                saveNewPrintProductCost(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), _
                    .Item(ctr, 4), .Item(ctr, 5), .Item(ctr, 6), .Item(ctr, 7), .Item(ctr, 8), _
                    .Item(ctr, 9), .Item(ctr, 10), .Item(ctr, 11), .Item(ctr, 12), .Item(ctr, 13), _
                    .Item(ctr, 14), .Item(ctr, 15), .Item(ctr, 16), .Item(ctr, 17), .Item(ctr, 18), _
                    .Item(ctr, 19), .Item(ctr, 20), .Item(ctr, 21), .Item(ctr, 22), .Item(ctr, 23), _
                    .Item(ctr, 24), .Item(ctr, 25), .Item(ctr, 26), .Item(ctr, 27), .Item(ctr, 28), _
                    .Item(ctr, 29), .Item(ctr, 30), .Item(ctr, 31), .Item(ctr, 32), .Item(ctr, 33), _
                    .Item(ctr, 34), .Item(ctr, 35), .Item(ctr, 36), .Item(ctr, 37), .Item(ctr, 38), _
                    .Item(ctr, 39), .Item(ctr, 40), .Item(ctr, 41), .Item(ctr, 42), .Item(ctr, 43), _
                    .Item(ctr, 44), .Item(ctr, 45), .Item(ctr, 46), .Item(ctr, 47), .Item(ctr, 48), _
                    .Item(ctr, 49), .Item(ctr, 50), .Item(ctr, 51), .Item(ctr, 52), .Item(ctr, 53), _
                    .Item(ctr, 54), .Item(ctr, 55), .Item(ctr, 56), .Item(ctr, 57), .Item(ctr, 58), _
                    .Item(ctr, 59), .Item(ctr, 60), .Item(ctr, 61), .Item(ctr, 62), .Item(ctr, 63), _
                    .Item(ctr, 64), .Item(ctr, 65), .Item(ctr, 66), .Item(ctr, 67), .Item(ctr, 68), _
                    .Item(ctr, 69), .Item(ctr, 70), .Item(ctr, 71), .Item(ctr, 72), .Item(ctr, 73), _
                    .Item(ctr, 74), .Item(ctr, 75), .Item(ctr, 76), .Item(ctr, 77), .Item(ctr, 78), _
                    .Item(ctr, 79), .Item(ctr, 80), .Item(ctr, 81), txtDateFrom.Text, txtDateTo.Text, _
                    .Item(ctr, 82))

                ctr += 1
            End While
        End With
    End Sub

    Public Function getTotalDarkMeatAllocated(ByVal specie As String) As Double
        'ByVal lot As String, 
        Dim ctr As Integer
        Dim total As Double
        With grid
            While ctr < .RowCount
                '.Item(ctr, 1) = lot And
                If CStr(.Item(ctr, 0)).StartsWith("D") And getProductSpecie(.Item(ctr, 0)) = specie Then
                    total += grid.Item(ctr, 6)
                End If

                ctr += 1
            End While
        End With

        Return total
    End Function

    Public Function getWhitePercentageOnDarkMeat(ByVal specie As String) As Double
        'ByVal lot As String, 
        Dim ctr As Integer
        Dim total As Double
        With grid
            While ctr < .RowCount
                '.Item(ctr, 1) = lot And
                If CStr(.Item(ctr, 0)).StartsWith("D") And getProductSpecie(.Item(ctr, 0)) = specie Then
                    total += grid.Item(ctr, 5)
                End If

                ctr += 1
            End While
        End With

        Return (total * 0.33)
    End Function

    Public Function getDarkMeatPercentageInCost(ByVal specie As String, ByVal dateFrom As String, ByVal dateTo As String) As Double
        'ByVal lot As String, 
        Dim ctr As Integer
        Dim total As Double
        With grid
            While ctr < .RowCount
                '.Item(ctr, 1) = lot And
                'Or CStr(.Item(ctr, 0)).StartsWith("R") Or CStr(.Item(ctr, 0)).StartsWith("P"))
                If CStr(.Item(ctr, 0)).StartsWith("D") And .Item(ctr, 80) = specie Then
                    'total += (((CDbl(.Item(ctr, 3)) * (getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0)) * .Item(ctr, 51))) / 1000))
                    'Else
                    'getProductSpecie(.Item(ctr, 0))
                    'total += (((CDbl(.Item(ctr, 3)) * (getActualAverageFW(dateFrom, dateTo, "D%", .Item(ctr, 81)) * .Item(ctr, 51))) / 1000))
                    total += ((((CDbl(.Item(ctr, 3)) * (getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0)) * .Item(ctr, 51))) / 1000)))

                    'getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0))
                    'grid.Item(ctr, 5)
                End If

                ctr += 1
            End While
        End With

        'If CStr(.Item(ctr, 0)).StartsWith("D") Then
        'Else

        Return (total) '* 12        '* 0.67
        'End If
    End Function

    Public Function getSpecialDarkMeatPercentageInCost(ByVal specie As String, ByVal dateFrom As String, ByVal dateTo As String)
        'ByVal lot As String, 
        Dim ctr As Integer
        Dim total As Double
        With grid
            While ctr < .RowCount
                '.Item(ctr, 1) = lot And
                If CStr(.Item(ctr, 0)).StartsWith("P") And .Item(ctr, 80) = specie Then
                    'getProductSpecie(.Item(ctr, 0))
                    total += ((((CDbl(.Item(ctr, 3)) * (getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0)) * .Item(ctr, 51))) / 1000)))
                End If

                ctr += 1
            End While
        End With

        Return (total * 0.08) * 12
    End Function

    Public Function getFZDarkMeatPercentageInCost(ByVal specie As String) As Double
        'ByVal lot As String, 
        Dim ctr As Integer
        Dim total As Double
        With grid
            While ctr < .RowCount
                '.Item(ctr, 1) = lot And
                If CStr(.Item(ctr, 0)).StartsWith("R") And .Item(ctr, 80) = specie Then
                    'getProductSpecie(.Item(ctr, 0))
                    total += ((CDbl(.Item(ctr, 3)) * ((8 * 1000) * 1)) / 1000) 'grid.Item(ctr, 5)   '.Item(ctr, 51)
                End If

                ctr += 1
            End While
        End With

        Return (total * 0.8) * 12
    End Function

    Public Function getFZDarkMeatPercentage(ByVal specie As String) As Double
        'ByVal lot As String, 
        Dim ctr As Integer
        Dim total As Double
        With grid
            While ctr < .RowCount
                '.Item(ctr, 1) = lot And
                If CStr(.Item(ctr, 0)).StartsWith("R") And .Item(ctr, 80) = specie Then
                    'getProductSpecie(.Item(ctr, 0))
                    total += (.Item(ctr, 5) * 0.33)
                End If

                ctr += 1
            End While
        End With

        Return total
    End Function

    'TOTAL WHITE MEAT LIKE LOINS, WHITE FLAKES AND 33% OF WHITE FLAKES FROM DARK FLAKES PRODUCT
    Public Function getTotalWhiteMeatForDistribution(ByVal specie As String, ByVal dateFrom As String, ByVal dateTo As String) As Double
        'ByVal lot As String, 
        Dim index As Integer
        Dim total As Double = 0
        Dim tfw As Double

        With grid
            While index < .RowCount
                '.Item(index, 3) += (getDentedQty(dateFrom, dateTo, .Item(index, 0)))

                If Not CStr(.Item(index, 0)).StartsWith("D") Then
                    If (getProductCategory(.Item(index, 0))).StartsWith("Frozen") Then
                        'FW
                        '.Item(ctr, 4) = "22.50"
                        '.Item(index, 5) = CDbl(.Item(index, 3)) * (7.5 * 1000)

                        If CStr(.Item(index, 0)).StartsWith("R") Or CStr(.Item(index, 0)).StartsWith("FS") Or CStr(.Item(index, 0)).StartsWith("FY") Then
                            .Item(index, 5) = (CDbl(.Item(index, 3)) * ((8 * 1000) * 1)) / 1000     '.Item(index, 51)
                        ElseIf CStr(.Item(index, 0)).StartsWith("LA") Or CStr(.Item(index, 0)).StartsWith("FA") Then
                            .Item(index, 5) = CDbl(.Item(index, 3)) * getActualAverageFW(dateFrom, dateTo, .Item(index, 0)) / 1000
                        Else
                            .Item(index, 5) = (CDbl(.Item(index, 3)) * ((7.5 * 1000) * .Item(index, 51))) / 1000
                        End If
                    Else
                        'If CStr(.Item(index, 0)).StartsWith("W") Then
                        '    tfw = ((CDbl(.Item(index, 3)) * (getActualAverageFW(dateFrom, dateTo, "W%", .Item(index, 81)) * .Item(index, 51))) / 1000) * 0.33 'CDbl(.Item(index, 5)) * 0.33
                        'Else
                        .Item(index, 5) = (CDbl(.Item(index, 3)) * getActualAverageFW(dateFrom, dateTo, .Item(index, 0)) * .Item(index, 51)) / 1000
                        'End If
                    End If

                    If CStr(.Item(index, 0)).StartsWith("R") Then
                        tfw = (.Item(index, 5) * 0.2)
                    ElseIf CStr(.Item(index, 0)).StartsWith("P") Then
                        tfw = (.Item(index, 5) * 0.92)  '0.08
                    Else
                        tfw = .Item(index, 5) '/ 1000
                    End If

                Else
                    'getActualAverageFW(dateFrom, dateTo, .Item(ctr, 0))
                    tfw = ((CDbl(.Item(index, 3)) * (getActualAverageFW(dateFrom, dateTo, .Item(index, 0)) * .Item(index, 51))) / 1000) * getMeatPercentage(dateFrom, dateTo) '0.33 'CDbl(.Item(index, 5)) * 0.33
                    '//If Not CStr(.Item(index, 0)).StartsWith("D0A") Then tfw = ((CDbl(.Item(index, 3)) * (getActualAverageFW(dateFrom, dateTo, .Item(index, 0)) * .Item(index, 51))) / 1000) * getMeatPercentage(dateFrom, dateTo) '0.33 'CDbl(.Item(index, 5)) * 0.33
                End If

                'If .Item(index, 80) = "Skipjack" Then
                '    MsgBox(tfw)
                'End If

                If specie = .Item(index, 80) Then     'lot = .Item(ctr, 1) And
                    total += tfw
                End If

                index += 1
            End While
        End With

        Return total
    End Function

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        displayProductForCosting(True)
        saveDataCosting()

        deletePrintProductCostingTable()
        collectData(True, txtDateFrom.Text, txtDateTo.Text)

        Try
            Dim reply As String = MsgBox("Are you sure you want to export the table to excel file for Accpac?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")

            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_report_ProductCosting_forAccpac"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@dateFrom"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            p1.Value = Format(CDate(txtDateFrom.Text), getTimeFormat())

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@dateTo"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.DateTime
            p2.Value = Format(CDate(txtDateTo.Text), getTimeFormat())

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("TRAKIM")
            da.Fill(ds)

            ''If reply = vbYes Then
            ''exportFile(ds)
            ''Else
            'Dim f As New frmPrintProductCosting
            'f.displayReport_TB(txtDateFrom.Text, txtDateTo.Text)
            'f.ShowDialog(Me)
            ''End If

            ds.Dispose()
            da.Dispose()
            c.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        displayProductForCosting()
    End Sub

    Public Sub saveProductCost(ByVal fg As Boolean)
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                If fg Then
                    saveNewPrintProductCost_Table(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), _
                        .Item(ctr, 4), .Item(ctr, 5), .Item(ctr, 7), .Item(ctr, 8))
                Else
                    saveNewPrintProductCost_Table(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), _
                        .Item(ctr, 4), .Item(ctr, 5), .Item(ctr, 7), .Item(ctr, 8))
                    '
                End If

                ctr += 1
            End While
        End With
    End Sub

    Public Sub collectData(Optional ByVal monthEnd As Boolean = False, Optional ByVal dateFrom As String = "", _
    Optional ByVal dateTo As String = "")
        With grid
            If monthEnd Then
                .DataSource = getCostData_FG_FL_monthEnd(dateFrom, dateTo, "FG").Tables(0)
                displayData_FG_FL()
                .DataSource = getCostData_FG_FL_monthEnd(dateFrom, dateTo, "FL").Tables(0)
                displayData_FG_FL()
                .DataSource = getCostData_Specie_monthEnd(dateFrom, dateTo, "SJ").Tables(0)
                displayData_Specie_monthEnd("Skipjack", dateFrom, dateTo)
                .DataSource = getCostData_Specie_monthEnd(dateFrom, dateTo, "YF").Tables(0)
                displayData_Specie_monthEnd("Yellow Fin", dateFrom, dateTo)
                .DataSource = getCostData_Specie_monthEnd(dateFrom, dateTo, "BE").Tables(0)
                displayData_Specie_monthEnd("Big Eye", dateFrom, dateTo)
                .DataSource = getCostData_Materials_monthEnd(dateFrom, dateTo, "packaging").Tables(0)
                displayData_PackagingMaterials(dateFrom, dateTo)
                .DataSource = getCostData_Materials_monthEnd(dateFrom, dateTo, "ingredients").Tables(0)
                displayData_IngredientsMaterials(dateFrom, dateTo)

                ''getCostData_ManufacturingAbsorption(dateFrom, dateTo, "Labor")
                saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Direct Labor", "1710", _
                        "1", getManufacturingAbsorptionCost(dateFrom, dateTo, "Labor"), "0", getManufacturingAbsorptionCost(dateFrom, dateTo, "Labor"))
                saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Utilities", "1720", _
                       "1", getManufacturingAbsorptionCost(dateFrom, dateTo, "Utilities"), "0", getManufacturingAbsorptionCost(dateFrom, dateTo, "Utilities"))
                ''saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Fuel", "1730", _
                ''        "1", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Fuel"), "0", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Fuel"))
                saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Overhead", "1740", _
                        "1", getManufacturingAbsorptionCost(dateFrom, dateTo, "Overhead"), "0", getManufacturingAbsorptionCost(dateFrom, dateTo, "Overhead"))
                ''Else
                ''    .DataSource = getCostData_FG_FL(txtProdnDate.Text, cboShift.Text, "FG").Tables(0)
                ''    displayData_FG_FL()
                ''    .DataSource = getCostData_FG_FL(txtProdnDate.Text, cboShift.Text, "FL").Tables(0)
                ''    displayData_FG_FL()
                ''    .DataSource = getCostData_Specie(txtProdnDate.Text, cboShift.Text, "SJ").Tables(0)
                ''    displayData_Specie("Skipjack")
                ''    .DataSource = getCostData_Specie(txtProdnDate.Text, cboShift.Text, "YF").Tables(0)
                ''    displayData_Specie("Yellow Fin")
                ''    .DataSource = getCostData_Materials(txtProdnDate.Text, cboShift.Text, "packaging").Tables(0)
                ''    displayData_PackagingMaterials()
                ''    .DataSource = getCostData_Materials(txtProdnDate.Text, cboShift.Text, "ingredients").Tables(0)
                ''    displayData_IngredientsMaterials()

                ''    saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Direct Labor", "1710", _
                ''            "1", getCostData_Labor_OH(txtProdnDate.Text, cboShift.Text, "Labor"), "0", getCostData_Labor_OH(txtProdnDate.Text, cboShift.Text, "Labor"))
                ''    saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Electricity", "1720", _
                ''            "1", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Electricity"), "0", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Electricity"))
                ''    saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Fuel", "1730", _
                ''            "1", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Fuel"), "0", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Fuel"))
                ''    saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Supplies and Cafeteria Provision", "1740", _
                ''            "1", getCostData_Labor_OH(txtProdnDate.Text, cboShift.Text, "OH"), "0", getCostData_Labor_OH(txtProdnDate.Text, cboShift.Text, "OH"))
            End If
            ''LABOR COST
            '.Item(ctr, 73) = (computeLaborRate(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
            '.Item(ctr, 72) = CDbl(.Item(ctr, 73)) / .Item(ctr, 3)
            ''UTILITY COST
            '.Item(ctr, 75) = (computeUtilityExpenses(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
            '.Item(ctr, 74) = CDbl(.Item(ctr, 75)) / .Item(ctr, 3)
            ''OVERHEAD COST
            '.Item(ctr, 77) = (computeTotalOH(txtProdnDate.Value) * getTotalProcessed(txtProdnDate.Value, cboShift.Text)) * (.Item(ctr, 5) / getTotalMeatPackedOfTheDay())
            '.Item(ctr, 76) = CDbl(.Item(ctr, 77)) / .Item(ctr, 3)


            .Splits(0).DisplayColumns(2).Width = 250
            .Columns(4).NumberFormat = "###,###,###,##0.#0"
            .Columns(5).NumberFormat = "###,###,###,##0.#0"
            .Columns(6).NumberFormat = "###,###,###,##0.#0"
            .Columns(7).NumberFormat = "###,###,###,##0.#0"
            .Columns(8).NumberFormat = "###,###,###,##0.#0"
        End With
    End Sub

    Public Sub displayData_FG_FL()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                .Item(ctr, 2) = getProductDesc(CStr(.Item(ctr, 0)).Substring(0, 4) & "%")

                If CStr(.Item(ctr, 0)).StartsWith("F") Or CStr(.Item(ctr, 3)).StartsWith("R") Then
                    .Item(ctr, 4) *= 3
                End If

                .Item(ctr, 5) = getUnitCost_FG_FL(.Item(ctr, 0), .Item(ctr, 1))
                .Item(ctr, 6) = CDbl(.Item(ctr, 4)) * .Item(ctr, 5)
                .Item(ctr, 7) = .Item(ctr, 6)
                ctr += 1
            End While
        End With

        saveProductCost(True)
    End Sub

    'Public Sub displayData_Specie(ByVal specie As String)
    '    Dim ctr As Integer
    '    With grid
    '        While ctr < .RowCount
    '            If specie = "Skipjack" Then
    '                .Item(ctr, 2) = "SJ " & .Item(ctr, 2)
    '            ElseIf specie = "Yellow Fin" Then
    '                .Item(ctr, 2) = "YF " & .Item(ctr, 2)
    '            Else
    '                .Item(ctr, 2) = "BE " & .Item(ctr, 2)
    '            End If
    '            .Item(ctr, 5) = (getFishCost(txtProdnDate.Text, cboShift.Text, specie) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, specie)) / 1000
    '            .Item(ctr, 6) = CDbl(.Item(ctr, 4)) * (getFishCost(txtProdnDate.Text, cboShift.Text, specie) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, specie)) / 1000
    '            .Item(ctr, 8) = .Item(ctr, 6)
    '            ctr += 1
    '        End While
    '    End With

    '    MsgBox("oops!")
    '    saveProductCost(False)
    'End Sub

    Public Sub displayData_Specie_monthEnd(ByVal specie As String, Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "")
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                If specie = "Skipjack" Then
                    .Item(ctr, 2) = "SJ " & .Item(ctr, 2)
                ElseIf specie = "Yellow Fin" Then
                    .Item(ctr, 2) = "YF " & .Item(ctr, 2)
                Else
                    .Item(ctr, 2) = "BE " & .Item(ctr, 2)
                End If

                .Item(ctr, 5) = (getFishCost(dateFrom, dateTo, "", specie) / getAveConversion_byProdnDate(dateFrom, dateTo, "", specie)) / 1000
                .Item(ctr, 6) = CDbl(.Item(ctr, 4)) * (getFishCost(dateFrom, dateTo, "", specie) / getAveConversion_byProdnDate(dateFrom, dateTo, "", specie)) / 1000
                .Item(ctr, 8) = .Item(ctr, 6) '* (getFishCost(dateFrom, dateTo, "", specie) / getAveConversion_byProdnDate(dateFrom, dateTo, "", specie)) / 1000
                ctr += 1
            End While
        End With

        'saveProductCost2(False)
        saveProductCost(False)
    End Sub

    Public Sub displayData_Specie_monthEnd2(ByVal specie As String, Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "")
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                If specie = "Skipjack" Then
                    .Item(ctr, 9) = "SJ " & .Item(ctr, 9)
                ElseIf specie = "Yellow Fin" Then
                    .Item(ctr, 9) = "YF " & .Item(ctr, 9)
                Else
                    .Item(ctr, 9) = "BE " & .Item(ctr, 9)
                End If

                '.Item(ctr, 5) = (getFishCost(dateFrom, dateTo, "", specie) / getAveConversion_byProdnDate(dateFrom, dateTo, "", specie)) / 1000
                '.Item(ctr, 6) = CDbl(.Item(ctr, 4)) * (getFishCost(dateFrom, dateTo, "", specie) / getAveConversion_byProdnDate(dateFrom, dateTo, "", specie)) / 1000
                .Item(ctr, 8) = .Item(ctr, 6) * (getFishCost(dateFrom, dateTo, "", specie) / getAveConversion_byProdnDate(dateFrom, dateTo, "", specie)) / 1000
                ctr += 1
            End While
        End With

        saveProductCost2(False)
        'saveProductCost(False)
    End Sub

    Public Sub displayData_PackagingMaterials2(Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "")
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                'If getMaterialsCategory(.Item(ctr, 2)).IndexOf("Bod") >= 0 Then
                '    .Item(ctr, 4) = getCostData_PackagingMaterials(txtProdnDate.Text , cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), CStr(.Item(ctr, 2)).Substring(0, 7) & "%")
                'ElseIf getMaterialsCategory(.Item(ctr, 2)) = "Cartons" Or getMaterialsCategory(.Item(ctr, 2)) = "Labels" Then
                '    .Item(ctr, 4) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                '    '.Item(ctr, 4) = getCostData_PackagingMaterials_Cartons(txtProdnDate.Text, cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), .Item(ctr, 2))
                'Else
                '    .Item(ctr, 4) = getCostData_PackagingMaterials(txtProdnDate.Text, cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), .Item(ctr, 2))
                'End If
                'If dateFrom = "" Then
                '    .Item(ctr, 5) = getMaterialCosts(txtProdnDate.Text, .Item(ctr, 2)) 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'Else
                '.Item(ctr, 5) = getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 2)) 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'End If
                '.Item(ctr, 6) = .Item(ctr, 4) * .Item(ctr, 5) 'CDbl(.Item(ctr, 4)) * (computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2)))))
                .Item(ctr, 8) = .Item(ctr, 6) * getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 9))
                ctr += 1
            End While
        End With

        saveProductCost2(False)
    End Sub

    Public Sub displayData_PackagingMaterials(Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "")
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                'If getMaterialsCategory(.Item(ctr, 2)).IndexOf("Bod") >= 0 Then
                '    .Item(ctr, 4) = getCostData_PackagingMaterials(txtProdnDate.Text , cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), CStr(.Item(ctr, 2)).Substring(0, 7) & "%")
                'ElseIf getMaterialsCategory(.Item(ctr, 2)) = "Cartons" Or getMaterialsCategory(.Item(ctr, 2)) = "Labels" Then
                '    .Item(ctr, 4) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                '    '.Item(ctr, 4) = getCostData_PackagingMaterials_Cartons(txtProdnDate.Text, cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), .Item(ctr, 2))
                'Else
                '    .Item(ctr, 4) = getCostData_PackagingMaterials(txtProdnDate.Text, cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), .Item(ctr, 2))
                'End If
                'If dateFrom = "" Then
                '    .Item(ctr, 5) = getMaterialCosts(txtProdnDate.Text, .Item(ctr, 2)) 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'Else
                .Item(ctr, 5) = getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 2)) 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'End If
                .Item(ctr, 6) = .Item(ctr, 4) * .Item(ctr, 5) 'CDbl(.Item(ctr, 4)) * (computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2)))))
                .Item(ctr, 8) = .Item(ctr, 6) '* getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 9))
                ctr += 1
            End While
        End With

        saveProductCost(False)
    End Sub

    Public Sub displayData_IngredientsMaterials2(Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "")
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                '.Item(ctr, 4) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'getCostData_IngredientsMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2))
                'If dateFrom = "" Then
                '    .Item(ctr, 5) = getMaterialCosts(txtProdnDate.Text, .Item(ctr, 2)) 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'Else
                '.Item(ctr, 5) = getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 2))    'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'End If
                '.Item(ctr, 6) = CDbl(.Item(ctr, 4)) * .Item(ctr, 5) '(computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2)))))
                .Item(ctr, 8) = .Item(ctr, 6) * getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 9))
                ctr += 1
            End While
        End With

        saveProductCost2(False)
    End Sub

    Public Sub displayData_IngredientsMaterials(Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "")
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                '.Item(ctr, 4) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'getCostData_IngredientsMaterials(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2))
                'If dateFrom = "" Then
                '    .Item(ctr, 5) = getMaterialCosts(txtProdnDate.Text, .Item(ctr, 2)) 'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'Else
                .Item(ctr, 5) = getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 2))    'computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
                'End If
                .Item(ctr, 6) = CDbl(.Item(ctr, 4)) * .Item(ctr, 5) '(computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2)))))
                .Item(ctr, 8) = .Item(ctr, 6) '* getAverageMaterialCosts(dateFrom, dateTo, .Item(ctr, 9))
                ctr += 1
            End While
        End With

        saveProductCost(False)
    End Sub

    '********************************************************************************
    '********************************************************************************
    '********************************************************************************
    '********************************************************************************
    Public Function displaySummary(ByVal prodnDate As String, ByVal shift As String) As DataSet
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            '("SELECT lot#, item, qty, unitCost, amount " & _
            '    " FROM dbo.tbl_tmp_PrintProductCosting_table " & _
            '    " WHERE (accountCode IN ('5060', '5051', '1710', '1720', '1730', '1740'))", c)
            cmd.CommandText = "proc_displayAll_CostingDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@prodnDate"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            p1.Value = Format(CDate(prodnDate), getTimeFormat())

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@shift"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = shift

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@unitCost"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.Float
            p3.Value = 0

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            Dim d As DataSet = ds

            da.Dispose()
            ds.Dispose()
            c.Close()

            Return d
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Function

    Public Function displayDirectMaterialsSummary(ByVal dateFrom As String, ByVal dateTo As String) As DataSet
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_displayAll_CostingDetails_monthEnd"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@dateFrom"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            p1.Value = Format(CDate(dateFrom), getTimeFormat())

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@dateTo"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.DateTime
            p2.Value = Format(CDate(dateTo), getTimeFormat())

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@unitCost"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.Float
            p3.Value = 0

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            Dim d As DataSet = ds

            da.Dispose()
            ds.Dispose()
            c.Close()

            Return d
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Function

    Private Sub cmdAccpacData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccpacData.Click
        displayProductForCosting(True)
        saveDataCosting()

        deletePrintProductCostingTable2()
        collectDataForExport()

        Try
            Dim reply As String = MsgBox("Are you sure you want to export the table to excel file for Accpac?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then
                Dim c As New SqlClient.SqlConnection
                c.ConnectionString = getConnectionString()
                c.Open()

                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandText = "proc_report_ProductCosting_forAccpac2"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = c

                Dim da As New SqlClient.SqlDataAdapter
                da.SelectCommand = cmd

                Dim ds As New DataSet("TRAKIM")
                da.Fill(ds)

                exportFile(ds)

                ds.Dispose()
                da.Dispose()
                c.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        displayProductForCosting()
    End Sub

    Public Sub collectDataForExport()
        With grid
            saveNewPrintProductCost_Table("1", "0", "*** NEW ***", "Adjustment for " & Format(CDate(txtDateFrom.Text), "dd, MMMM yyyy") & " production", _
                Format(CDate(txtDateFrom.Text), "yyyyMMdd"), "", "", "", _
                    "", "", "")

            .DataSource = getCostData_FG_FL2(txtDateFrom.Text, txtDateTo.Text, "FG").Tables(0)
            displayData_FG_FL2()
            .DataSource = getCostData_FG_FL2(txtDateFrom.Text, txtDateTo.Text, "FL").Tables(0)
            displayData_FG_FL2()
            .DataSource = getCostData_Specie(txtDateFrom.Text, txtDateTo.Text, "SJ", "Skipjack").Tables(0) 'getCostData_Specie2(txtDateFrom.Text, txtDateTo.Text, "SJ").Tables(0)
            displayData_Specie_monthEnd2("Skipjack", txtDateFrom.Text, txtDateTo.Text)
            .DataSource = getCostData_Specie(txtDateFrom.Text, txtDateTo.Text, "YF", "Yellow Fin").Tables(0) 'getCostData_Specie2(txtDateFrom.Text, txtDateTo.Text, "YF").Tables(0)
            displayData_Specie_monthEnd2("Yellow Fin", txtDateFrom.Text, txtDateTo.Text)
            .DataSource = getCostData_Specie(txtDateFrom.Text, txtDateTo.Text, "YF", "Big Eye").Tables(0) 'getCostData_Specie2(txtDateFrom.Text, txtDateTo.Text, "YF").Tables(0)
            displayData_Specie_monthEnd2("Big Eye", txtDateFrom.Text, txtDateTo.Text)
            .DataSource = getCostData_Materials2(txtDateFrom.Text, txtDateTo.Text, "packaging").Tables(0)
            displayData_PackagingMaterials2(txtDateFrom.Text, txtDateTo.Text)
            .DataSource = getCostData_Materials2(txtDateFrom.Text, txtDateTo.Text, "ingredients").Tables(0)
            displayData_IngredientsMaterials2(txtDateFrom.Text, txtDateTo.Text)

            'getCostData_Labor_OH(txtProdnDate.Text, cboShift.Text, "Labor")
            saveNewPrintProductCost_Table("2", "0", "1710", "MADL", "N24", "6", "1", "mos", _
                    getManufacturingAbsorptionCost(txtDateFrom.Text, txtDateTo.Text, "Labor"), _
                    "Manufacturing Absorption - Direct Labor", "9999")
            'getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Electricity")
            saveNewPrintProductCost_Table("2", "0", "1720", "MAEL", "N24", "6", "1", "mos", _
                    getManufacturingAbsorptionCost(txtDateFrom.Text, txtDateTo.Text, "Utilities"), _
                    "Manufacturing Absorption - Electricity", "9999")
            'saveNewPrintProductCost_Table("2", "0", "1730", "MAFU", "N24", "6", "1", "mos", _
            '        getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Fuel"), _
            '        "Manufacturing Absorption - Fuel", "9999")
            'getCostData_Labor_OH(txtProdnDate.Text, cboShift.Text, "OH")
            saveNewPrintProductCost_Table("2", "0", "1730", "MASC", "N24", "6", "1", "mos", _
                    getManufacturingAbsorptionCost(txtDateFrom.Text, txtDateTo.Text, "Overhead"), _
                    "Manufacturing Absorption - Supplies and Cafeteria Provision", "9999")

            ''saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Electricity", "1720", _
            ''        "1", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Electricity"), "0", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Electricity"))
            ''saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Fuel", "1730", _
            ''        "1", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Fuel"), "0", getCostData_Utility(txtProdnDate.Text, cboShift.Text, "Fuel"))
            ''saveNewPrintProductCost_Table("", "", "Manufacturing Absorption - Supplies and Cafeteria Provision", "1740", _
            ''        "1", getCostData_Labor_OH(txtProdnDate.Text, cboShift.Text, "OH"), "0", getCostData_Labor_OH(txtProdnDate.Text, cboShift.Text, "OH"))

            ''.Splits(0).DisplayColumns(2).Width = 250
            ''.Columns(6).NumberFormat = "###,###,###,##0.#0"
            ''.Columns(8).NumberFormat = "###,###,###,##0.#0"
            ''.Columns(6).NumberFormat = "###,###,###,##0.#0"
            ''.Columns(7).NumberFormat = "###,###,###,##0.#0"
            ''.Columns(8).NumberFormat = "###,###,###,##0.#0"
        End With
    End Sub

    Public Sub displayData_FG_FL2()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                .Item(ctr, 8) = CDbl(.Item(ctr, 6)) * getUnitCost_FG_FL(.Item(ctr, 3), .Item(ctr, 11))
                .Item(ctr, 9) = getProductDesc(.Item(ctr, 3))
                '.Item(ctr, 5) = getUnitCost_FG_FL(.Item(ctr, 0), .Item(ctr, 1))
                '.Item(ctr, 7) = .Item(ctr, 6)
                ctr += 1
            End While
        End With

        saveProductCost2(True)
        saveSuspenseAccountCost()
    End Sub

    'Public Sub displayData_Specie2(ByVal specie As String)
    '    Dim ctr As Integer
    '    With grid
    '        While ctr < .RowCount
    '            .Item(ctr, 8) = CDbl(.Item(ctr, 6)) * (getFishCost(txtProdnDate.Text, cboShift.Text, specie) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, specie)) / 1000
    '            If specie = "Skipjack" Then
    '                .Item(ctr, 9) = "SJ " & .Item(ctr, 9)
    '            Else
    '                .Item(ctr, 9) = "YF " & .Item(ctr, 9)
    '            End If

    '            ctr += 1
    '        End While
    '    End With

    '    saveProductCost2(False)
    'End Sub

    'Public Sub displayData_PackagingMaterials2()
    '    Dim ctr As Integer
    '    With grid
    '        While ctr < .RowCount
    '            'If getMaterialsCategory(.Item(ctr, 2)).IndexOf("Bod") >= 0 Then
    '            '    .Item(ctr, 4) = getCostData_PackagingMaterials(txtProdnDate.Text, cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), CStr(.Item(ctr, 2)).Substring(0, 7) & "%")
    '            'ElseIf getMaterialsCategory(.Item(ctr, 2)) = "Cartons" Or getMaterialsCategory(.Item(ctr, 2)) = "Labels" Then
    '            '    .Item(ctr, 4) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
    '            '    '.Item(ctr, 4) = getCostData_PackagingMaterials_Cartons(txtProdnDate.Text, cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), .Item(ctr, 2))
    '            'Else
    '            '    .Item(ctr, 4) = getCostData_PackagingMaterials(txtProdnDate.Text, cboShift.Text, getMaterialsCategory(.Item(ctr, 2)), .Item(ctr, 2))
    '            'End If
    '            .Item(ctr, 8) = .Item(ctr, 6) * computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 9), getMaterialsCategory(.Item(ctr, 9))))
    '            '.Item(ctr, 6) = CDbl(.Item(ctr, 4)) * (computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2)))))
    '            '.Item(ctr, 8) = .Item(ctr, 6)
    '            ctr += 1
    '        End While
    '    End With

    '    saveProductCost2(False)
    'End Sub

    'Public Sub displayData_IngredientsMaterials2()
    '    Dim ctr As Integer
    '    With grid
    '        While ctr < .RowCount
    '            '.Item(ctr, 4) = getMRNUsageDetails(txtProdnDate.Text, cboShift.Text, getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
    '            '.Item(ctr, 5) = computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 2), getMaterialsCategory(.Item(ctr, 2))))
    '            If CStr(.Item(ctr, 9)).StartsWith("Oil") Then
    '                .Item(ctr, 7) = "ltr"
    '            Else
    '                .Item(ctr, 7) = "kg"
    '            End If
    '            .Item(ctr, 8) = CDbl(.Item(ctr, 6)) * (computeProductMaterials(getMRN_ByProdnDate(txtProdnDate.Text, cboShift.Text, .Item(ctr, 9), getMaterialsCategory(.Item(ctr, 9)))))
    '            '.Item(ctr, 8) = .Item(ctr, 6)
    '            ctr += 1
    '        End While
    '    End With

    '    saveProductCost2(False)
    'End Sub

    Public Sub saveProductCost2(ByVal fg As Boolean)
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                saveNewPrintProductCost_Table(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), _
                    .Item(ctr, 4), .Item(ctr, 5), .Item(ctr, 6), .Item(ctr, 7), .Item(ctr, 8), _
                    .Item(ctr, 9), .Item(ctr, 10))

                ctr += 1
            End While
        End With
    End Sub

    Public Sub saveSuspenseAccountCost()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                saveNewPrintProductCost_Table("6", "0", .Item(ctr, 2), .Item(ctr, 11), _
                    .Item(ctr, 6), .Item(ctr, 6), .Item(ctr, 8), "", "", "", "")

                ctr += 1
            End While
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        displayProductForCosting(True)
        Try
            Dim reply As String = MsgBox("Are you sure you want to export the table to excel file?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If reply = vbYes Then

                saveDataCosting()

                Dim c As New SqlClient.SqlConnection
                c.ConnectionString = getConnectionString()
                c.Open()

                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandText = "proc_report_ProductCosting"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = c

                Dim da As New SqlClient.SqlDataAdapter
                da.SelectCommand = cmd

                Dim ds As New DataSet("TRAKIM")
                da.Fill(ds)

                exportFile(ds)

                ds.Dispose()
                da.Dispose()
                c.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        printCostDist()
        'Dim dateFrom As DateTime = "01/02/2012"
        'Dim dateTo As DateTime = "29/02/2012"

        'MsgBox(materialsTotalUsage(grid.Item(grid.Row, 0), "Loin Bags", dateFrom, dateTo))
    End Sub

    Public Function materialsUsage(ByVal pCode As String) As Double
        Dim ctr As Integer
        Dim returnValue As Double
        With grid

            While ctr < .RowCount
                If CStr(.Item(ctr, 0)).StartsWith("L") And CStr(.Item(ctr, 0)) = pCode Then
                    returnValue = CDbl(.Item(ctr, 3))
                End If

                ctr += 1
            End While
        End With

        Return returnValue
    End Function

    Public Function getUnitCost(ByVal pCode As String) As Double
        Dim ctr, divisor As Integer
        Dim cost As Double
        With grid
            While ctr < .RowCount
                If pCode = getRevisedProductCode(.Item(ctr, 0), "", False) Then
                    cost += .Item(ctr, 78)
                    divisor += 1
                End If

                ctr += 1
            End While
        End With

        Return cost / divisor
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If lblWait.Visible = True Then
            lblWait.Visible = False
        Else
            lblWait.Visible = True
        End If
    End Sub
End Class
