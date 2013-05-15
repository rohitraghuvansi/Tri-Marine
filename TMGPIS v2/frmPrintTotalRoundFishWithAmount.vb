Public Class frmPrintTotalRoundFishWithAmount
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
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents grpLot As System.Windows.Forms.GroupBox
    Friend WithEvents gridLot As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblAveBE As System.Windows.Forms.Label
    Friend WithEvents lblAveSJ As System.Windows.Forms.Label
    Friend WithEvents lblAveYF As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintTotalRoundFishWithAmount))
        Me.grp = New System.Windows.Forms.GroupBox
        Me.grpLot = New System.Windows.Forms.GroupBox
        Me.gridLot = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdGenerate = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblAveBE = New System.Windows.Forms.Label
        Me.lblAveSJ = New System.Windows.Forms.Label
        Me.lblAveYF = New System.Windows.Forms.Label
        Me.grp.SuspendLayout()
        Me.grpLot.SuspendLayout()
        CType(Me.gridLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp
        '
        Me.grp.Controls.Add(Me.lblAveYF)
        Me.grp.Controls.Add(Me.lblAveSJ)
        Me.grp.Controls.Add(Me.lblAveBE)
        Me.grp.Controls.Add(Me.Label7)
        Me.grp.Controls.Add(Me.Label5)
        Me.grp.Controls.Add(Me.Label6)
        Me.grp.Controls.Add(Me.grpLot)
        Me.grp.Controls.Add(Me.cmdClose)
        Me.grp.Controls.Add(Me.cmdGenerate)
        Me.grp.Controls.Add(Me.Label4)
        Me.grp.Controls.Add(Me.grid)
        Me.grp.Controls.Add(Me.Label3)
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Controls.Add(Me.txtDateTo)
        Me.grp.Controls.Add(Me.txtDateFrom)
        Me.grp.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp.Location = New System.Drawing.Point(0, 40)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(666, 512)
        Me.grp.TabIndex = 61
        Me.grp.TabStop = False
        '
        'grpLot
        '
        Me.grpLot.Controls.Add(Me.gridLot)
        Me.grpLot.Enabled = False
        Me.grpLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLot.Location = New System.Drawing.Point(239, 98)
        Me.grpLot.Name = "grpLot"
        Me.grpLot.Size = New System.Drawing.Size(425, 414)
        Me.grpLot.TabIndex = 82
        Me.grpLot.TabStop = False
        Me.grpLot.Text = "Click X to close"
        Me.grpLot.Visible = False
        '
        'gridLot
        '
        Me.gridLot.AllowColMove = False
        Me.gridLot.AllowUpdate = False
        Me.gridLot.CaptionHeight = 17
        Me.gridLot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridLot.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridLot.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.gridLot.Location = New System.Drawing.Point(3, 19)
        Me.gridLot.Name = "gridLot"
        Me.gridLot.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridLot.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridLot.PreviewInfo.ZoomFactor = 75
        Me.gridLot.RowHeight = 20
        Me.gridLot.Size = New System.Drawing.Size(419, 392)
        Me.gridLot.TabIndex = 80
        Me.gridLot.Text = "C1TrueDBGrid1"
        Me.gridLot.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Tahoma, 9.75pt;}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}He" & _
        "ading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTex" & _
        "t;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}S" & _
        "tyle9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""Fals" & _
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" M" & _
        "arqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>388</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 415, 388</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 415, 388</ClientArea><PrintPageHeaderStyle parent" & _
        "="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(325, 24)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 48)
        Me.cmdClose.TabIndex = 81
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Image = CType(resources.GetObject("cmdGenerate.Image"), System.Drawing.Image)
        Me.cmdGenerate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGenerate.Location = New System.Drawing.Point(240, 24)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(80, 48)
        Me.cmdGenerate.TabIndex = 80
        Me.cmdGenerate.Text = "&Generate"
        Me.cmdGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Details"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(16, 104)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(640, 400)
        Me.grid.TabIndex = 78
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Tahoma, 9.75pt;}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}He" & _
        "ading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTex" & _
        "t;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}S" & _
        "tyle9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""Fals" & _
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" M" & _
        "arqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" Vert" & _
        "icalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>396</Height><CaptionStyle " & _
        "parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenR" & _
        "owStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""St" & _
        "yle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" m" & _
        "e=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle pa" & _
        "rent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /" & _
        "><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordS" & _
        "elector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style pa" & _
        "rent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 636, 396</ClientRect><BorderSide>0" & _
        "</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></" & _
        "Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""He" & _
        "ading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capti" & _
        "on"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selecte" & _
        "d"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRo" & _
        "w"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" />" & _
        "<Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterB" & _
        "ar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpli" & _
        "ts><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defaul" & _
        "tRecSelWidth><ClientArea>0, 0, 636, 396</ClientArea><PrintPageHeaderStyle parent" & _
        "="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Date To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(666, 40)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Generate Monthly Round Fish Acceptance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(440, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Skipjack"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(440, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Big Eye"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(440, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 19)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Yellow Fin"
        '
        'lblAveBE
        '
        Me.lblAveBE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveBE.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveBE.Location = New System.Drawing.Point(512, 13)
        Me.lblAveBE.Name = "lblAveBE"
        Me.lblAveBE.Size = New System.Drawing.Size(136, 24)
        Me.lblAveBE.TabIndex = 86
        Me.lblAveBE.Text = "0.00"
        Me.lblAveBE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAveSJ
        '
        Me.lblAveSJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveSJ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveSJ.Location = New System.Drawing.Point(512, 45)
        Me.lblAveSJ.Name = "lblAveSJ"
        Me.lblAveSJ.Size = New System.Drawing.Size(136, 24)
        Me.lblAveSJ.TabIndex = 87
        Me.lblAveSJ.Text = "0.00"
        Me.lblAveSJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAveYF
        '
        Me.lblAveYF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveYF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveYF.Location = New System.Drawing.Point(512, 77)
        Me.lblAveYF.Name = "lblAveYF"
        Me.lblAveYF.Size = New System.Drawing.Size(136, 24)
        Me.lblAveYF.TabIndex = 88
        Me.lblAveYF.Text = "0.00"
        Me.lblAveYF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPrintTotalRoundFishWithAmount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintTotalRoundFishWithAmount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrintTotalRoundFishWithAmount"
        Me.grp.ResumeLayout(False)
        Me.grpLot.ResumeLayout(False)
        CType(Me.gridLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintTotalRoundFishWithAmount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDateFrom.Value = getServerDateTime()
        txtDateTo.Value = getServerDateTime()
    End Sub

    Private Sub txtDateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateFrom.ValueChanged
        displayReport()
    End Sub

    Private Sub txtDateTo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateTo.ValueChanged
        displayReport()
    End Sub

    Public Sub displayReport()
        'Dim rpt As New rptPrintFWR_Lot
        'rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'rpt.Load()
        'rpt.SetDataSource(getReport_fwrLot(dateFrom, dateTo, shift, "Round Fish", "Daily Round Fish Cannery Acceptance Summary Report").Tables(0))
        'rptInventory.ReportSource = rpt
        With grid
            .DataSource = getRoundFishAcceptance(txtDateFrom.Text, txtDateTo.Text).Tables(0)
            .Columns(3).NumberFormat = "###,###,##0.#0"
            .Columns(4).NumberFormat = "###,###,##0.##0"
        End With

        computeAmount()
    End Sub

    Public Sub computeAmount()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                .Item(ctr, 3) = getFishSpecieAndSizeAmountPerLot(txtDateFrom.Text, txtDateTo.Text, .Item(ctr, 0), .Item(ctr, 1))
                .Item(ctr, 4) = CDbl(.Item(ctr, 2)) * .Item(ctr, 3)

                ctr += 1
            End While
        End With

        lblAveBE.Text = Format(displayComputeAverageCost("Big Eye"), "###,##0.#0")
        lblAveSJ.Text = Format(displayComputeAverageCost("Skipjack"), "###,##0.#0")
        lblAveYF.Text = Format(displayComputeAverageCost("Yellow Fin"), "###,##0.#0")
    End Sub

    Public Function displayComputeAverageCost(ByVal specie As String) As Double
        Dim ctr, divisor As Integer
        Dim totalWeight As Double
        Dim totalAmount As Double
        With grid
            While ctr < .RowCount
                If specie = .Item(ctr, 0) Then
                    totalWeight = +.Item(ctr, 2)
                    totalAmount += .Item(ctr, 3)
                    divisor += 1
                Else
                End If

                ctr += 1
            End While
        End With

        Return totalAmount / divisor
    End Function

    Public Function getFishSpecieAndSizeAmountPerLot(ByVal dateFrom As String, ByVal dateTo As String, _
    ByVal specie As String, ByVal size As String) As Double
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_displayRoundFishAcceptance_usedLot"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@dateFrom"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.DateTime
            If dateFrom = "" Then
                p1.Value = Format(getServerDateTime(), getTimeFormat())
            Else
                p1.Value = Format(CDate(dateFrom), getTimeFormat())
            End If

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@dateTo"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.DateTime
            If dateTo = "" Then
                p2.Value = Format(getServerDateTime(), getTimeFormat())
            Else
                p2.Value = Format(CDate(dateTo), getTimeFormat())
            End If

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@specie"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = specie

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@size"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = size

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)

            Dim totalAmount As Double
            Dim ctr As Integer

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                If Not dr(0) Is DBNull.Value Then
                    ctr += 1

                    totalAmount += getAmount_LotSpecieSize(specie, size, dr.GetString(2))
                End If
            End While

            dr.Close()
            c.Close()

            Return totalAmount / ctr
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Function

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
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

        ' get count of rows and count of columns
        rowCount = grid.RowCount   'objDataSet.Tables(0).Rows.Count()
        colCount = grid.Columns.Count  'displaySummary.Tables(0).Columns.Count 'objDataSet.Tables(0).Columns.Count()

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
        'col = 5
        While ctr < grid.Columns.Count
            If col = 25 Then col = 0
            If col > 24 Then
                cell = GetExcelColumn("A" & col) '& "1"
            Else
                cell = GetExcelColumn(col) '& "1"
            End If
            excelWorksheet.Range(cell & "1").Value = "Specie"
            excelWorksheet.Range(cell & "2").Value = "Size"
            excelWorksheet.Range(cell & "3").Value = "Net Weight"
            excelWorksheet.Range(cell & "4").Value = "Amount"
            excelWorksheet.Range(cell & "5").Value = "Cost"
            excelWorksheet.Range(cell & "6").Value = "Size Category"
            excelWorksheet.Range(cell & "7").Value = "Date From"
            excelWorksheet.Range(cell & "8").Value = "Date To"

            col += 1
            ctr += 1
        End While


        ' now add the data elements
        For row = 0 To rowCount - 1
            rowcell = row + 2
            For col = 0 To grid.RowCount - 1   'colCount - 1
                If col = 25 Then col = 0
                If col > 24 Then
                    cell = GetExcelColumn("A" & col) '& rowcell.ToString
                Else
                    cell = GetExcelColumn(col) '& rowcell.ToString
                End If

                If col < grid.Columns.Count Then
                    excelWorksheet.Range(cell & rowcell.ToString).Value = grid.Item(row, col)
                    'If CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Skip") >= 0 Or _
                    'CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Yell") >= 0 Then
                    '    Dim unitCostFish As Double = (getFishCost(txtProdnDate.Text, cboShift.Text, excelWorksheet.Range("B" & rowcell.ToString).Text) / getAveConversion_byProdnDate(txtProdnDate.Text, cboShift.Text, excelWorksheet.Range("B" & rowcell.ToString).Text)) / 1000
                    '    excelWorksheet.Range("D" & rowcell.ToString).Value = unitCostFish
                    '    If Not CStr(excelWorksheet.Range("C" & rowcell.ToString).Text) = "" Then
                    '        excelWorksheet.Range("E" & rowcell.ToString).Value = excelWorksheet.Range("C" & rowcell.ToString).Text * unitCostFish
                    '    End If
                End If
                'Else
                '    If getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Can Bodies" Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                '            excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Cans")
                '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Can Ends" Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                '            excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Ends")
                '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Ingredients" Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                '            excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Ingredients")
                '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Cartons" Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons_Labels(txtProdnDate.Text, cboShift.Text, _
                '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                '            excelWorksheet.Range("B" & rowcell.ToString).Text, "Cartons")
                '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Labels" Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons_Labels(txtProdnDate.Text, cboShift.Text, _
                '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                '            excelWorksheet.Range("B" & rowcell.ToString).Text, "Labels")
                '    ElseIf getMaterialsCategory(excelWorksheet.Range("B" & rowcell.ToString).Text) = "Loin Bags" Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Materials(excelWorksheet.Range(cell & "1").Text, _
                '           excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text, "Loin Bags")
                '        'excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Cartons_Labels(txtProdnDate.Text, cboShift.Text, _
                '        '    excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                '        '    "%loin%", "Loin Bags")
                '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Labor") >= 0 Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Labor_OH(txtProdnDate.Text, cboShift.Text, _
                '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                '            "Labor")
                '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Supp") >= 0 Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Labor_OH(txtProdnDate.Text, cboShift.Text, _
                '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                '            "OH")
                '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Fuel") >= 0 Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Utilities(txtProdnDate.Text, _
                '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                '            "Fuel")
                '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Elect") >= 0 Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Utilities(txtProdnDate.Text, _
                '            excelWorksheet.Range(cell & "1").Text, excelWorksheet.Range(cell & "2").Text, _
                '            "Electricity")
                '    ElseIf CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Skip") >= 0 Or _
                '    CStr(excelWorksheet.Range("B" & rowcell.ToString).Text).IndexOf("Yell") >= 0 Then
                '        excelWorksheet.Range(cell & rowcell.ToString).Value = getForExcel_Specie(excelWorksheet.Range(cell & "1").Text, _
                '            excelWorksheet.Range(cell & "2").Text, excelWorksheet.Range("B" & rowcell.ToString).Text)
                '    End If
                'End If
            Next
        Next

        ' turn off wait cursor
        Me.Cursor = Cursors.Default

        ' view the spread sheet
        excelApp.Visible = True
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        grpLot.Enabled = True
        grpLot.Visible = True

        gridLot.DataSource = getFishLotThroughput(txtDateFrom.Text, txtDateTo.Text, grid.Item(grid.Row, 0), grid.Item(grid.Row, 1)).Tables(0)
        gridLot.Splits(0).DisplayColumns(0).Width = 60
        gridLot.Splits(0).DisplayColumns(1).Width = 75
        gridLot.Splits(0).DisplayColumns(2).Width = 80
        gridLot.Splits(0).DisplayColumns(3).Width = 85
        gridLot.Splits(0).DisplayColumns(4).Width = 70

        gridLot.Columns(3).NumberFormat = "###,##0.#0"
        gridLot.Columns(4).NumberFormat = "###,##0.#0"

        displayPrice()
    End Sub

    Private Sub grpLot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpLot.Click
        grpLot.Enabled = False
        grpLot.Visible = False
    End Sub

    Public Sub displayPrice()
        With gridLot
            Dim ctr As Integer
            While ctr < .RowCount
                .Item(ctr, 4) = getCOSPrice("%", .Item(ctr, 0), "%", .Item(ctr, 1), .Item(ctr, 2))

                ctr += 1
            End While
        End With
    End Sub
End Class
