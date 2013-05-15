Public Class frmInqProductRecovery
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblRecovery As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRejects As System.Windows.Forms.Label
    Friend WithEvents lblTotalMeat As System.Windows.Forms.Label
    Friend WithEvents lblTotalFish As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblODM As System.Windows.Forms.Label
    Friend WithEvents lblOWM As System.Windows.Forms.Label
    Friend WithEvents lblOLoins As System.Windows.Forms.Label
    Friend WithEvents lblORejects As System.Windows.Forms.Label
    Friend WithEvents lblOFish As System.Windows.Forms.Label
    Friend WithEvents lblBFish As System.Windows.Forms.Label
    Friend WithEvents lblYFish As System.Windows.Forms.Label
    Friend WithEvents lblSFish As System.Windows.Forms.Label
    Friend WithEvents lblBRejects As System.Windows.Forms.Label
    Friend WithEvents lblYRejects As System.Windows.Forms.Label
    Friend WithEvents lblSRejects As System.Windows.Forms.Label
    Friend WithEvents lblBLoins As System.Windows.Forms.Label
    Friend WithEvents lblYLoins As System.Windows.Forms.Label
    Friend WithEvents lblSLoins As System.Windows.Forms.Label
    Friend WithEvents lblBWM As System.Windows.Forms.Label
    Friend WithEvents lblYWM As System.Windows.Forms.Label
    Friend WithEvents lblSWM As System.Windows.Forms.Label
    Friend WithEvents lblBDM As System.Windows.Forms.Label
    Friend WithEvents lblYDM As System.Windows.Forms.Label
    Friend WithEvents lblSDM As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblBSize As System.Windows.Forms.Label
    Friend WithEvents lblYSize As System.Windows.Forms.Label
    Friend WithEvents lblSSize As System.Windows.Forms.Label
    Friend WithEvents lblOSize As System.Windows.Forms.Label
    Friend WithEvents lblBCurve As System.Windows.Forms.Label
    Friend WithEvents lblYCurve As System.Windows.Forms.Label
    Friend WithEvents lblSCurve As System.Windows.Forms.Label
    Friend WithEvents lblOCurve As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblBRejP As System.Windows.Forms.Label
    Friend WithEvents lblYRejP As System.Windows.Forms.Label
    Friend WithEvents lblSRejP As System.Windows.Forms.Label
    Friend WithEvents lblORejP As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblDF As System.Windows.Forms.Label
    Friend WithEvents lblWF As System.Windows.Forms.Label
    Friend WithEvents lblFL As System.Windows.Forms.Label
    Friend WithEvents lblSDM2 As System.Windows.Forms.Label
    Friend WithEvents lblSWM2 As System.Windows.Forms.Label
    Friend WithEvents lblSLoins2 As System.Windows.Forms.Label
    Friend WithEvents lblYDM2 As System.Windows.Forms.Label
    Friend WithEvents lblYWM2 As System.Windows.Forms.Label
    Friend WithEvents lblYLoins2 As System.Windows.Forms.Label
    Friend WithEvents lblBDM2 As System.Windows.Forms.Label
    Friend WithEvents lblBWM2 As System.Windows.Forms.Label
    Friend WithEvents lblBLoins2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents lblOSizeQty As System.Windows.Forms.Label
    Friend WithEvents lblSSizeQty As System.Windows.Forms.Label
    Friend WithEvents lblYSizeQty As System.Windows.Forms.Label
    Friend WithEvents lblBSizeQty As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblADM2 As System.Windows.Forms.Label
    Friend WithEvents lblAWM2 As System.Windows.Forms.Label
    Friend WithEvents lblALoins2 As System.Windows.Forms.Label
    Friend WithEvents lblARejP As System.Windows.Forms.Label
    Friend WithEvents lblACurve As System.Windows.Forms.Label
    Friend WithEvents lblASize As System.Windows.Forms.Label
    Friend WithEvents lblARejects As System.Windows.Forms.Label
    Friend WithEvents lblAFish As System.Windows.Forms.Label
    Friend WithEvents lblADM As System.Windows.Forms.Label
    Friend WithEvents lblAWM As System.Windows.Forms.Label
    Friend WithEvents lblALoins As System.Windows.Forms.Label
    Friend WithEvents lblASizeQty As System.Windows.Forms.Label
    Friend WithEvents cmdKPI As System.Windows.Forms.Button
    Friend WithEvents gridFZ As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblAWFZ As System.Windows.Forms.Label
    Friend WithEvents lblBWFZ As System.Windows.Forms.Label
    Friend WithEvents lblYWFZ As System.Windows.Forms.Label
    Friend WithEvents lblSWFZ As System.Windows.Forms.Label
    Friend WithEvents lblOWFZ As System.Windows.Forms.Label
    Friend WithEvents lblARFZ As System.Windows.Forms.Label
    Friend WithEvents lblBRFZ As System.Windows.Forms.Label
    Friend WithEvents lblYRFZ As System.Windows.Forms.Label
    Friend WithEvents lblSRFZ As System.Windows.Forms.Label
    Friend WithEvents lblORFZ As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInqProductRecovery))
        Me.Label1 = New System.Windows.Forms.Label
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblARFZ = New System.Windows.Forms.Label
        Me.lblBRFZ = New System.Windows.Forms.Label
        Me.lblYRFZ = New System.Windows.Forms.Label
        Me.lblSRFZ = New System.Windows.Forms.Label
        Me.lblORFZ = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.lblAWFZ = New System.Windows.Forms.Label
        Me.lblBWFZ = New System.Windows.Forms.Label
        Me.lblYWFZ = New System.Windows.Forms.Label
        Me.lblSWFZ = New System.Windows.Forms.Label
        Me.lblOWFZ = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmdKPI = New System.Windows.Forms.Button
        Me.lblASizeQty = New System.Windows.Forms.Label
        Me.lblADM2 = New System.Windows.Forms.Label
        Me.lblAWM2 = New System.Windows.Forms.Label
        Me.lblALoins2 = New System.Windows.Forms.Label
        Me.lblARejP = New System.Windows.Forms.Label
        Me.lblACurve = New System.Windows.Forms.Label
        Me.lblASize = New System.Windows.Forms.Label
        Me.lblARejects = New System.Windows.Forms.Label
        Me.lblAFish = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.lblADM = New System.Windows.Forms.Label
        Me.lblAWM = New System.Windows.Forms.Label
        Me.lblALoins = New System.Windows.Forms.Label
        Me.lblBSizeQty = New System.Windows.Forms.Label
        Me.lblYSizeQty = New System.Windows.Forms.Label
        Me.lblSSizeQty = New System.Windows.Forms.Label
        Me.lblOSizeQty = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdExport = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblBDM2 = New System.Windows.Forms.Label
        Me.lblBWM2 = New System.Windows.Forms.Label
        Me.lblBLoins2 = New System.Windows.Forms.Label
        Me.lblYDM2 = New System.Windows.Forms.Label
        Me.lblYWM2 = New System.Windows.Forms.Label
        Me.lblYLoins2 = New System.Windows.Forms.Label
        Me.lblSDM2 = New System.Windows.Forms.Label
        Me.lblSWM2 = New System.Windows.Forms.Label
        Me.lblSLoins2 = New System.Windows.Forms.Label
        Me.lblDF = New System.Windows.Forms.Label
        Me.lblWF = New System.Windows.Forms.Label
        Me.lblFL = New System.Windows.Forms.Label
        Me.lblBRejP = New System.Windows.Forms.Label
        Me.lblYRejP = New System.Windows.Forms.Label
        Me.lblSRejP = New System.Windows.Forms.Label
        Me.lblORejP = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblBCurve = New System.Windows.Forms.Label
        Me.lblYCurve = New System.Windows.Forms.Label
        Me.lblSCurve = New System.Windows.Forms.Label
        Me.lblOCurve = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblBSize = New System.Windows.Forms.Label
        Me.lblYSize = New System.Windows.Forms.Label
        Me.lblSSize = New System.Windows.Forms.Label
        Me.lblOSize = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblBRejects = New System.Windows.Forms.Label
        Me.lblBFish = New System.Windows.Forms.Label
        Me.lblYRejects = New System.Windows.Forms.Label
        Me.lblYFish = New System.Windows.Forms.Label
        Me.lblSRejects = New System.Windows.Forms.Label
        Me.lblSFish = New System.Windows.Forms.Label
        Me.lblORejects = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.lblOFish = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.lblBDM = New System.Windows.Forms.Label
        Me.lblBWM = New System.Windows.Forms.Label
        Me.lblBLoins = New System.Windows.Forms.Label
        Me.lblYDM = New System.Windows.Forms.Label
        Me.lblYWM = New System.Windows.Forms.Label
        Me.lblYLoins = New System.Windows.Forms.Label
        Me.lblSDM = New System.Windows.Forms.Label
        Me.lblSWM = New System.Windows.Forms.Label
        Me.lblSLoins = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblTotalRejects = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblODM = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblOWM = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblOLoins = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblRecovery = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblTotalMeat = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotalFish = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit
        Me.gridFZ = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1286, 40)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Production Recovery"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowSort = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(0, 512)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(632, 72)
        Me.grid.TabIndex = 52
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
        """17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Heig" & _
        "ht>68</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""" & _
        "Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarSty" & _
        "le parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" />" & _
        "<GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Sty" & _
        "le2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle par" & _
        "ent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordS" & _
        "electorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selec" & _
        "ted"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 628, 6" & _
        "8</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Wi" & _
        "n.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><S" & _
        "tyle parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style" & _
        " parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style " & _
        "parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style pare" & _
        "nt=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style par" & _
        "ent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style " & _
        "parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedSty" & _
        "les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><De" & _
        "faultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 628, 68</ClientArea><P" & _
        "rintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=" & _
        """Style15"" /></Blob>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblARFZ)
        Me.GroupBox1.Controls.Add(Me.lblBRFZ)
        Me.GroupBox1.Controls.Add(Me.lblYRFZ)
        Me.GroupBox1.Controls.Add(Me.lblSRFZ)
        Me.GroupBox1.Controls.Add(Me.lblORFZ)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.lblAWFZ)
        Me.GroupBox1.Controls.Add(Me.lblBWFZ)
        Me.GroupBox1.Controls.Add(Me.lblYWFZ)
        Me.GroupBox1.Controls.Add(Me.lblSWFZ)
        Me.GroupBox1.Controls.Add(Me.lblOWFZ)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.cmdKPI)
        Me.GroupBox1.Controls.Add(Me.lblASizeQty)
        Me.GroupBox1.Controls.Add(Me.lblADM2)
        Me.GroupBox1.Controls.Add(Me.lblAWM2)
        Me.GroupBox1.Controls.Add(Me.lblALoins2)
        Me.GroupBox1.Controls.Add(Me.lblARejP)
        Me.GroupBox1.Controls.Add(Me.lblACurve)
        Me.GroupBox1.Controls.Add(Me.lblASize)
        Me.GroupBox1.Controls.Add(Me.lblARejects)
        Me.GroupBox1.Controls.Add(Me.lblAFish)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.lblADM)
        Me.GroupBox1.Controls.Add(Me.lblAWM)
        Me.GroupBox1.Controls.Add(Me.lblALoins)
        Me.GroupBox1.Controls.Add(Me.lblBSizeQty)
        Me.GroupBox1.Controls.Add(Me.lblYSizeQty)
        Me.GroupBox1.Controls.Add(Me.lblSSizeQty)
        Me.GroupBox1.Controls.Add(Me.lblOSizeQty)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.cmdExport)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblBDM2)
        Me.GroupBox1.Controls.Add(Me.lblBWM2)
        Me.GroupBox1.Controls.Add(Me.lblBLoins2)
        Me.GroupBox1.Controls.Add(Me.lblYDM2)
        Me.GroupBox1.Controls.Add(Me.lblYWM2)
        Me.GroupBox1.Controls.Add(Me.lblYLoins2)
        Me.GroupBox1.Controls.Add(Me.lblSDM2)
        Me.GroupBox1.Controls.Add(Me.lblSWM2)
        Me.GroupBox1.Controls.Add(Me.lblSLoins2)
        Me.GroupBox1.Controls.Add(Me.lblDF)
        Me.GroupBox1.Controls.Add(Me.lblWF)
        Me.GroupBox1.Controls.Add(Me.lblFL)
        Me.GroupBox1.Controls.Add(Me.lblBRejP)
        Me.GroupBox1.Controls.Add(Me.lblYRejP)
        Me.GroupBox1.Controls.Add(Me.lblSRejP)
        Me.GroupBox1.Controls.Add(Me.lblORejP)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lblBCurve)
        Me.GroupBox1.Controls.Add(Me.lblYCurve)
        Me.GroupBox1.Controls.Add(Me.lblSCurve)
        Me.GroupBox1.Controls.Add(Me.lblOCurve)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lblBSize)
        Me.GroupBox1.Controls.Add(Me.lblYSize)
        Me.GroupBox1.Controls.Add(Me.lblSSize)
        Me.GroupBox1.Controls.Add(Me.lblOSize)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblBRejects)
        Me.GroupBox1.Controls.Add(Me.lblBFish)
        Me.GroupBox1.Controls.Add(Me.lblYRejects)
        Me.GroupBox1.Controls.Add(Me.lblYFish)
        Me.GroupBox1.Controls.Add(Me.lblSRejects)
        Me.GroupBox1.Controls.Add(Me.lblSFish)
        Me.GroupBox1.Controls.Add(Me.lblORejects)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.lblOFish)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.lblBDM)
        Me.GroupBox1.Controls.Add(Me.lblBWM)
        Me.GroupBox1.Controls.Add(Me.lblBLoins)
        Me.GroupBox1.Controls.Add(Me.lblYDM)
        Me.GroupBox1.Controls.Add(Me.lblYWM)
        Me.GroupBox1.Controls.Add(Me.lblYLoins)
        Me.GroupBox1.Controls.Add(Me.lblSDM)
        Me.GroupBox1.Controls.Add(Me.lblSWM)
        Me.GroupBox1.Controls.Add(Me.lblSLoins)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lblTotalRejects)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblODM)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblOWM)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblOLoins)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblRecovery)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblTotalMeat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblTotalFish)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDateTo)
        Me.GroupBox1.Controls.Add(Me.txtDateFrom)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1286, 464)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'lblARFZ
        '
        Me.lblARFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblARFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblARFZ.Location = New System.Drawing.Point(1008, 424)
        Me.lblARFZ.Name = "lblARFZ"
        Me.lblARFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblARFZ.TabIndex = 159
        Me.lblARFZ.Text = "0"
        Me.lblARFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBRFZ
        '
        Me.lblBRFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRFZ.Location = New System.Drawing.Point(856, 424)
        Me.lblBRFZ.Name = "lblBRFZ"
        Me.lblBRFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblBRFZ.TabIndex = 158
        Me.lblBRFZ.Text = "0"
        Me.lblBRFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYRFZ
        '
        Me.lblYRFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYRFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYRFZ.Location = New System.Drawing.Point(704, 424)
        Me.lblYRFZ.Name = "lblYRFZ"
        Me.lblYRFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblYRFZ.TabIndex = 157
        Me.lblYRFZ.Text = "0"
        Me.lblYRFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSRFZ
        '
        Me.lblSRFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSRFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRFZ.Location = New System.Drawing.Point(552, 424)
        Me.lblSRFZ.Name = "lblSRFZ"
        Me.lblSRFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblSRFZ.TabIndex = 156
        Me.lblSRFZ.Text = "0"
        Me.lblSRFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblORFZ
        '
        Me.lblORFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblORFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORFZ.Location = New System.Drawing.Point(400, 424)
        Me.lblORFZ.Name = "lblORFZ"
        Me.lblORFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblORFZ.TabIndex = 155
        Me.lblORFZ.Text = "0"
        Me.lblORFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(264, 427)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(97, 19)
        Me.Label28.TabIndex = 154
        Me.Label28.Text = "Red Flakes (FZ)"
        '
        'lblAWFZ
        '
        Me.lblAWFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAWFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAWFZ.Location = New System.Drawing.Point(1008, 392)
        Me.lblAWFZ.Name = "lblAWFZ"
        Me.lblAWFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblAWFZ.TabIndex = 153
        Me.lblAWFZ.Text = "0"
        Me.lblAWFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBWFZ
        '
        Me.lblBWFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBWFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBWFZ.Location = New System.Drawing.Point(856, 392)
        Me.lblBWFZ.Name = "lblBWFZ"
        Me.lblBWFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblBWFZ.TabIndex = 152
        Me.lblBWFZ.Text = "0"
        Me.lblBWFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYWFZ
        '
        Me.lblYWFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYWFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYWFZ.Location = New System.Drawing.Point(704, 392)
        Me.lblYWFZ.Name = "lblYWFZ"
        Me.lblYWFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblYWFZ.TabIndex = 151
        Me.lblYWFZ.Text = "0"
        Me.lblYWFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSWFZ
        '
        Me.lblSWFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSWFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSWFZ.Location = New System.Drawing.Point(552, 392)
        Me.lblSWFZ.Name = "lblSWFZ"
        Me.lblSWFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblSWFZ.TabIndex = 150
        Me.lblSWFZ.Text = "0"
        Me.lblSWFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOWFZ
        '
        Me.lblOWFZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOWFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOWFZ.Location = New System.Drawing.Point(400, 392)
        Me.lblOWFZ.Name = "lblOWFZ"
        Me.lblOWFZ.Size = New System.Drawing.Size(128, 24)
        Me.lblOWFZ.TabIndex = 149
        Me.lblOWFZ.Text = "0"
        Me.lblOWFZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(264, 395)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 19)
        Me.Label24.TabIndex = 148
        Me.Label24.Text = "White Flakes (FZ)"
        '
        'cmdKPI
        '
        Me.cmdKPI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKPI.Image = CType(resources.GetObject("cmdKPI.Image"), System.Drawing.Image)
        Me.cmdKPI.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdKPI.Location = New System.Drawing.Point(48, 144)
        Me.cmdKPI.Name = "cmdKPI"
        Me.cmdKPI.Size = New System.Drawing.Size(144, 48)
        Me.cmdKPI.TabIndex = 147
        Me.cmdKPI.Text = "&KPI Report"
        Me.cmdKPI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblASizeQty
        '
        Me.lblASizeQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblASizeQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblASizeQty.Location = New System.Drawing.Point(1064, 13)
        Me.lblASizeQty.Name = "lblASizeQty"
        Me.lblASizeQty.Size = New System.Drawing.Size(72, 24)
        Me.lblASizeQty.TabIndex = 145
        Me.lblASizeQty.Text = "0"
        Me.lblASizeQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblASizeQty.Visible = False
        '
        'lblADM2
        '
        Me.lblADM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblADM2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblADM2.Location = New System.Drawing.Point(1008, 328)
        Me.lblADM2.Name = "lblADM2"
        Me.lblADM2.Size = New System.Drawing.Size(128, 24)
        Me.lblADM2.TabIndex = 144
        Me.lblADM2.Text = "0"
        Me.lblADM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAWM2
        '
        Me.lblAWM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAWM2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAWM2.Location = New System.Drawing.Point(1008, 264)
        Me.lblAWM2.Name = "lblAWM2"
        Me.lblAWM2.Size = New System.Drawing.Size(128, 24)
        Me.lblAWM2.TabIndex = 143
        Me.lblAWM2.Text = "0"
        Me.lblAWM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblALoins2
        '
        Me.lblALoins2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblALoins2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblALoins2.Location = New System.Drawing.Point(1008, 200)
        Me.lblALoins2.Name = "lblALoins2"
        Me.lblALoins2.Size = New System.Drawing.Size(128, 24)
        Me.lblALoins2.TabIndex = 142
        Me.lblALoins2.Text = "0"
        Me.lblALoins2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblARejP
        '
        Me.lblARejP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblARejP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblARejP.Location = New System.Drawing.Point(1008, 136)
        Me.lblARejP.Name = "lblARejP"
        Me.lblARejP.Size = New System.Drawing.Size(128, 24)
        Me.lblARejP.TabIndex = 141
        Me.lblARejP.Text = "0"
        Me.lblARejP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblACurve
        '
        Me.lblACurve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblACurve.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACurve.Location = New System.Drawing.Point(1008, 168)
        Me.lblACurve.Name = "lblACurve"
        Me.lblACurve.Size = New System.Drawing.Size(128, 24)
        Me.lblACurve.TabIndex = 140
        Me.lblACurve.Text = "0"
        Me.lblACurve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblASize
        '
        Me.lblASize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblASize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblASize.Location = New System.Drawing.Point(1008, 72)
        Me.lblASize.Name = "lblASize"
        Me.lblASize.Size = New System.Drawing.Size(128, 24)
        Me.lblASize.TabIndex = 139
        Me.lblASize.Text = "0"
        Me.lblASize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblARejects
        '
        Me.lblARejects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblARejects.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblARejects.Location = New System.Drawing.Point(1008, 104)
        Me.lblARejects.Name = "lblARejects"
        Me.lblARejects.Size = New System.Drawing.Size(128, 24)
        Me.lblARejects.TabIndex = 138
        Me.lblARejects.Text = "0"
        Me.lblARejects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAFish
        '
        Me.lblAFish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAFish.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAFish.Location = New System.Drawing.Point(1008, 40)
        Me.lblAFish.Name = "lblAFish"
        Me.lblAFish.Size = New System.Drawing.Size(128, 24)
        Me.lblAFish.TabIndex = 137
        Me.lblAFish.Text = "0"
        Me.lblAFish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(1008, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(56, 19)
        Me.Label31.TabIndex = 136
        Me.Label31.Text = "Albacore"
        '
        'lblADM
        '
        Me.lblADM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblADM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblADM.Location = New System.Drawing.Point(1008, 360)
        Me.lblADM.Name = "lblADM"
        Me.lblADM.Size = New System.Drawing.Size(128, 24)
        Me.lblADM.TabIndex = 135
        Me.lblADM.Text = "0"
        Me.lblADM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAWM
        '
        Me.lblAWM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAWM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAWM.Location = New System.Drawing.Point(1008, 296)
        Me.lblAWM.Name = "lblAWM"
        Me.lblAWM.Size = New System.Drawing.Size(128, 24)
        Me.lblAWM.TabIndex = 134
        Me.lblAWM.Text = "0"
        Me.lblAWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblALoins
        '
        Me.lblALoins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblALoins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblALoins.Location = New System.Drawing.Point(1008, 232)
        Me.lblALoins.Name = "lblALoins"
        Me.lblALoins.Size = New System.Drawing.Size(128, 24)
        Me.lblALoins.TabIndex = 133
        Me.lblALoins.Text = "0"
        Me.lblALoins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBSizeQty
        '
        Me.lblBSizeQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBSizeQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBSizeQty.Location = New System.Drawing.Point(912, 13)
        Me.lblBSizeQty.Name = "lblBSizeQty"
        Me.lblBSizeQty.Size = New System.Drawing.Size(72, 24)
        Me.lblBSizeQty.TabIndex = 132
        Me.lblBSizeQty.Text = "0"
        Me.lblBSizeQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBSizeQty.Visible = False
        '
        'lblYSizeQty
        '
        Me.lblYSizeQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYSizeQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYSizeQty.Location = New System.Drawing.Point(776, 13)
        Me.lblYSizeQty.Name = "lblYSizeQty"
        Me.lblYSizeQty.Size = New System.Drawing.Size(56, 24)
        Me.lblYSizeQty.TabIndex = 131
        Me.lblYSizeQty.Text = "0"
        Me.lblYSizeQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblYSizeQty.Visible = False
        '
        'lblSSizeQty
        '
        Me.lblSSizeQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSSizeQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSizeQty.Location = New System.Drawing.Point(608, 13)
        Me.lblSSizeQty.Name = "lblSSizeQty"
        Me.lblSSizeQty.Size = New System.Drawing.Size(72, 24)
        Me.lblSSizeQty.TabIndex = 130
        Me.lblSSizeQty.Text = "0"
        Me.lblSSizeQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSSizeQty.Visible = False
        '
        'lblOSizeQty
        '
        Me.lblOSizeQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOSizeQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSizeQty.Location = New System.Drawing.Point(400, 8)
        Me.lblOSizeQty.Name = "lblOSizeQty"
        Me.lblOSizeQty.Size = New System.Drawing.Size(128, 24)
        Me.lblOSizeQty.TabIndex = 129
        Me.lblOSizeQty.Text = "0"
        Me.lblOSizeQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOSizeQty.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(48, 256)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 48)
        Me.cmdClose.TabIndex = 128
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdExport
        '
        Me.cmdExport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Image = CType(resources.GetObject("cmdExport.Image"), System.Drawing.Image)
        Me.cmdExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdExport.Location = New System.Drawing.Point(48, 200)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(144, 48)
        Me.cmdExport.TabIndex = 127
        Me.cmdExport.Text = "E&xport to Excel"
        Me.cmdExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(48, 88)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(144, 48)
        Me.cmdPrint.TabIndex = 126
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(264, 331)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 19)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "Dark Meat (kg)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(264, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 19)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "White Meat (kg)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 19)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Frozen Loin Meat (kg)"
        '
        'lblBDM2
        '
        Me.lblBDM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBDM2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBDM2.Location = New System.Drawing.Point(856, 328)
        Me.lblBDM2.Name = "lblBDM2"
        Me.lblBDM2.Size = New System.Drawing.Size(128, 24)
        Me.lblBDM2.TabIndex = 120
        Me.lblBDM2.Text = "0"
        Me.lblBDM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBWM2
        '
        Me.lblBWM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBWM2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBWM2.Location = New System.Drawing.Point(856, 264)
        Me.lblBWM2.Name = "lblBWM2"
        Me.lblBWM2.Size = New System.Drawing.Size(128, 24)
        Me.lblBWM2.TabIndex = 119
        Me.lblBWM2.Text = "0"
        Me.lblBWM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBLoins2
        '
        Me.lblBLoins2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBLoins2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBLoins2.Location = New System.Drawing.Point(856, 200)
        Me.lblBLoins2.Name = "lblBLoins2"
        Me.lblBLoins2.Size = New System.Drawing.Size(128, 24)
        Me.lblBLoins2.TabIndex = 118
        Me.lblBLoins2.Text = "0"
        Me.lblBLoins2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYDM2
        '
        Me.lblYDM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYDM2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYDM2.Location = New System.Drawing.Point(704, 328)
        Me.lblYDM2.Name = "lblYDM2"
        Me.lblYDM2.Size = New System.Drawing.Size(128, 24)
        Me.lblYDM2.TabIndex = 117
        Me.lblYDM2.Text = "0"
        Me.lblYDM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYWM2
        '
        Me.lblYWM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYWM2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYWM2.Location = New System.Drawing.Point(704, 264)
        Me.lblYWM2.Name = "lblYWM2"
        Me.lblYWM2.Size = New System.Drawing.Size(128, 24)
        Me.lblYWM2.TabIndex = 116
        Me.lblYWM2.Text = "0"
        Me.lblYWM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYLoins2
        '
        Me.lblYLoins2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYLoins2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYLoins2.Location = New System.Drawing.Point(704, 200)
        Me.lblYLoins2.Name = "lblYLoins2"
        Me.lblYLoins2.Size = New System.Drawing.Size(128, 24)
        Me.lblYLoins2.TabIndex = 115
        Me.lblYLoins2.Text = "0"
        Me.lblYLoins2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSDM2
        '
        Me.lblSDM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSDM2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSDM2.Location = New System.Drawing.Point(552, 328)
        Me.lblSDM2.Name = "lblSDM2"
        Me.lblSDM2.Size = New System.Drawing.Size(128, 24)
        Me.lblSDM2.TabIndex = 114
        Me.lblSDM2.Text = "0"
        Me.lblSDM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSWM2
        '
        Me.lblSWM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSWM2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSWM2.Location = New System.Drawing.Point(552, 264)
        Me.lblSWM2.Name = "lblSWM2"
        Me.lblSWM2.Size = New System.Drawing.Size(128, 24)
        Me.lblSWM2.TabIndex = 113
        Me.lblSWM2.Text = "0"
        Me.lblSWM2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSLoins2
        '
        Me.lblSLoins2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSLoins2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSLoins2.Location = New System.Drawing.Point(552, 200)
        Me.lblSLoins2.Name = "lblSLoins2"
        Me.lblSLoins2.Size = New System.Drawing.Size(128, 24)
        Me.lblSLoins2.TabIndex = 112
        Me.lblSLoins2.Text = "0"
        Me.lblSLoins2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDF
        '
        Me.lblDF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDF.Location = New System.Drawing.Point(400, 328)
        Me.lblDF.Name = "lblDF"
        Me.lblDF.Size = New System.Drawing.Size(128, 24)
        Me.lblDF.TabIndex = 111
        Me.lblDF.Text = "0"
        Me.lblDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWF
        '
        Me.lblWF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWF.Location = New System.Drawing.Point(400, 264)
        Me.lblWF.Name = "lblWF"
        Me.lblWF.Size = New System.Drawing.Size(128, 24)
        Me.lblWF.TabIndex = 110
        Me.lblWF.Text = "0"
        Me.lblWF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFL
        '
        Me.lblFL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFL.Location = New System.Drawing.Point(400, 200)
        Me.lblFL.Name = "lblFL"
        Me.lblFL.Size = New System.Drawing.Size(128, 24)
        Me.lblFL.TabIndex = 109
        Me.lblFL.Text = "0"
        Me.lblFL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBRejP
        '
        Me.lblBRejP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRejP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRejP.Location = New System.Drawing.Point(856, 136)
        Me.lblBRejP.Name = "lblBRejP"
        Me.lblBRejP.Size = New System.Drawing.Size(128, 24)
        Me.lblBRejP.TabIndex = 108
        Me.lblBRejP.Text = "0"
        Me.lblBRejP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYRejP
        '
        Me.lblYRejP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYRejP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYRejP.Location = New System.Drawing.Point(704, 136)
        Me.lblYRejP.Name = "lblYRejP"
        Me.lblYRejP.Size = New System.Drawing.Size(128, 24)
        Me.lblYRejP.TabIndex = 107
        Me.lblYRejP.Text = "0"
        Me.lblYRejP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSRejP
        '
        Me.lblSRejP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSRejP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRejP.Location = New System.Drawing.Point(552, 136)
        Me.lblSRejP.Name = "lblSRejP"
        Me.lblSRejP.Size = New System.Drawing.Size(128, 24)
        Me.lblSRejP.TabIndex = 106
        Me.lblSRejP.Text = "0"
        Me.lblSRejP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblORejP
        '
        Me.lblORejP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblORejP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORejP.Location = New System.Drawing.Point(400, 136)
        Me.lblORejP.Name = "lblORejP"
        Me.lblORejP.Size = New System.Drawing.Size(128, 24)
        Me.lblORejP.TabIndex = 105
        Me.lblORejP.Text = "0"
        Me.lblORejP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(264, 139)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 19)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "Reject %"
        '
        'lblBCurve
        '
        Me.lblBCurve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBCurve.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCurve.Location = New System.Drawing.Point(856, 168)
        Me.lblBCurve.Name = "lblBCurve"
        Me.lblBCurve.Size = New System.Drawing.Size(128, 24)
        Me.lblBCurve.TabIndex = 103
        Me.lblBCurve.Text = "0"
        Me.lblBCurve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYCurve
        '
        Me.lblYCurve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYCurve.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYCurve.Location = New System.Drawing.Point(704, 168)
        Me.lblYCurve.Name = "lblYCurve"
        Me.lblYCurve.Size = New System.Drawing.Size(128, 24)
        Me.lblYCurve.TabIndex = 102
        Me.lblYCurve.Text = "0"
        Me.lblYCurve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSCurve
        '
        Me.lblSCurve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSCurve.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSCurve.Location = New System.Drawing.Point(552, 168)
        Me.lblSCurve.Name = "lblSCurve"
        Me.lblSCurve.Size = New System.Drawing.Size(128, 24)
        Me.lblSCurve.TabIndex = 101
        Me.lblSCurve.Text = "0"
        Me.lblSCurve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOCurve
        '
        Me.lblOCurve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOCurve.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOCurve.Location = New System.Drawing.Point(400, 168)
        Me.lblOCurve.Name = "lblOCurve"
        Me.lblOCurve.Size = New System.Drawing.Size(128, 24)
        Me.lblOCurve.TabIndex = 100
        Me.lblOCurve.Text = "0"
        Me.lblOCurve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(264, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 19)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "Recovery % of Curve"
        '
        'lblBSize
        '
        Me.lblBSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBSize.Location = New System.Drawing.Point(856, 72)
        Me.lblBSize.Name = "lblBSize"
        Me.lblBSize.Size = New System.Drawing.Size(128, 24)
        Me.lblBSize.TabIndex = 98
        Me.lblBSize.Text = "0"
        Me.lblBSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYSize
        '
        Me.lblYSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYSize.Location = New System.Drawing.Point(704, 72)
        Me.lblYSize.Name = "lblYSize"
        Me.lblYSize.Size = New System.Drawing.Size(128, 24)
        Me.lblYSize.TabIndex = 97
        Me.lblYSize.Text = "0"
        Me.lblYSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSSize
        '
        Me.lblSSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSize.Location = New System.Drawing.Point(552, 72)
        Me.lblSSize.Name = "lblSSize"
        Me.lblSSize.Size = New System.Drawing.Size(128, 24)
        Me.lblSSize.TabIndex = 96
        Me.lblSSize.Text = "0"
        Me.lblSSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOSize
        '
        Me.lblOSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSize.Location = New System.Drawing.Point(400, 72)
        Me.lblOSize.Name = "lblOSize"
        Me.lblOSize.Size = New System.Drawing.Size(128, 24)
        Me.lblOSize.TabIndex = 95
        Me.lblOSize.Text = "0"
        Me.lblOSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(264, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(137, 19)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "Average Fish Size (kg)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 19)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Production Output Details"
        '
        'lblBRejects
        '
        Me.lblBRejects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRejects.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRejects.Location = New System.Drawing.Point(856, 104)
        Me.lblBRejects.Name = "lblBRejects"
        Me.lblBRejects.Size = New System.Drawing.Size(128, 24)
        Me.lblBRejects.TabIndex = 92
        Me.lblBRejects.Text = "0"
        Me.lblBRejects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBFish
        '
        Me.lblBFish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBFish.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBFish.Location = New System.Drawing.Point(856, 40)
        Me.lblBFish.Name = "lblBFish"
        Me.lblBFish.Size = New System.Drawing.Size(128, 24)
        Me.lblBFish.TabIndex = 91
        Me.lblBFish.Text = "0"
        Me.lblBFish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYRejects
        '
        Me.lblYRejects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYRejects.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYRejects.Location = New System.Drawing.Point(704, 104)
        Me.lblYRejects.Name = "lblYRejects"
        Me.lblYRejects.Size = New System.Drawing.Size(128, 24)
        Me.lblYRejects.TabIndex = 90
        Me.lblYRejects.Text = "0"
        Me.lblYRejects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYFish
        '
        Me.lblYFish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYFish.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYFish.Location = New System.Drawing.Point(704, 40)
        Me.lblYFish.Name = "lblYFish"
        Me.lblYFish.Size = New System.Drawing.Size(128, 24)
        Me.lblYFish.TabIndex = 89
        Me.lblYFish.Text = "0"
        Me.lblYFish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSRejects
        '
        Me.lblSRejects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSRejects.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRejects.Location = New System.Drawing.Point(552, 104)
        Me.lblSRejects.Name = "lblSRejects"
        Me.lblSRejects.Size = New System.Drawing.Size(128, 24)
        Me.lblSRejects.TabIndex = 88
        Me.lblSRejects.Text = "0"
        Me.lblSRejects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSFish
        '
        Me.lblSFish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSFish.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSFish.Location = New System.Drawing.Point(552, 40)
        Me.lblSFish.Name = "lblSFish"
        Me.lblSFish.Size = New System.Drawing.Size(128, 24)
        Me.lblSFish.TabIndex = 87
        Me.lblSFish.Text = "0"
        Me.lblSFish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblORejects
        '
        Me.lblORejects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblORejects.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORejects.Location = New System.Drawing.Point(400, 104)
        Me.lblORejects.Name = "lblORejects"
        Me.lblORejects.Size = New System.Drawing.Size(128, 24)
        Me.lblORejects.TabIndex = 86
        Me.lblORejects.Text = "0"
        Me.lblORejects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(264, 107)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(70, 19)
        Me.Label34.TabIndex = 85
        Me.Label34.Text = "Reject (kg)"
        '
        'lblOFish
        '
        Me.lblOFish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOFish.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOFish.Location = New System.Drawing.Point(400, 40)
        Me.lblOFish.Name = "lblOFish"
        Me.lblOFish.Size = New System.Drawing.Size(128, 24)
        Me.lblOFish.TabIndex = 84
        Me.lblOFish.Text = "0"
        Me.lblOFish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(264, 43)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(99, 19)
        Me.Label36.TabIndex = 83
        Me.Label36.Text = "Round Fish (kg)"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(856, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 19)
        Me.Label27.TabIndex = 82
        Me.Label27.Text = "Big Eye"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(704, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 19)
        Me.Label26.TabIndex = 81
        Me.Label26.Text = "Yellow Fin"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(552, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 19)
        Me.Label25.TabIndex = 80
        Me.Label25.Text = "Skipjack"
        '
        'lblBDM
        '
        Me.lblBDM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBDM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBDM.Location = New System.Drawing.Point(856, 360)
        Me.lblBDM.Name = "lblBDM"
        Me.lblBDM.Size = New System.Drawing.Size(128, 24)
        Me.lblBDM.TabIndex = 79
        Me.lblBDM.Text = "0"
        Me.lblBDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBWM
        '
        Me.lblBWM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBWM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBWM.Location = New System.Drawing.Point(856, 296)
        Me.lblBWM.Name = "lblBWM"
        Me.lblBWM.Size = New System.Drawing.Size(128, 24)
        Me.lblBWM.TabIndex = 78
        Me.lblBWM.Text = "0"
        Me.lblBWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBLoins
        '
        Me.lblBLoins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBLoins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBLoins.Location = New System.Drawing.Point(856, 232)
        Me.lblBLoins.Name = "lblBLoins"
        Me.lblBLoins.Size = New System.Drawing.Size(128, 24)
        Me.lblBLoins.TabIndex = 77
        Me.lblBLoins.Text = "0"
        Me.lblBLoins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYDM
        '
        Me.lblYDM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYDM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYDM.Location = New System.Drawing.Point(704, 360)
        Me.lblYDM.Name = "lblYDM"
        Me.lblYDM.Size = New System.Drawing.Size(128, 24)
        Me.lblYDM.TabIndex = 76
        Me.lblYDM.Text = "0"
        Me.lblYDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYWM
        '
        Me.lblYWM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYWM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYWM.Location = New System.Drawing.Point(704, 296)
        Me.lblYWM.Name = "lblYWM"
        Me.lblYWM.Size = New System.Drawing.Size(128, 24)
        Me.lblYWM.TabIndex = 75
        Me.lblYWM.Text = "0"
        Me.lblYWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYLoins
        '
        Me.lblYLoins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYLoins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYLoins.Location = New System.Drawing.Point(704, 232)
        Me.lblYLoins.Name = "lblYLoins"
        Me.lblYLoins.Size = New System.Drawing.Size(128, 24)
        Me.lblYLoins.TabIndex = 74
        Me.lblYLoins.Text = "0"
        Me.lblYLoins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSDM
        '
        Me.lblSDM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSDM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSDM.Location = New System.Drawing.Point(552, 360)
        Me.lblSDM.Name = "lblSDM"
        Me.lblSDM.Size = New System.Drawing.Size(128, 24)
        Me.lblSDM.TabIndex = 73
        Me.lblSDM.Text = "0"
        Me.lblSDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSWM
        '
        Me.lblSWM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSWM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSWM.Location = New System.Drawing.Point(552, 296)
        Me.lblSWM.Name = "lblSWM"
        Me.lblSWM.Size = New System.Drawing.Size(128, 24)
        Me.lblSWM.TabIndex = 72
        Me.lblSWM.Text = "0"
        Me.lblSWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSLoins
        '
        Me.lblSLoins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSLoins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSLoins.Location = New System.Drawing.Point(552, 232)
        Me.lblSLoins.Name = "lblSLoins"
        Me.lblSLoins.Size = New System.Drawing.Size(128, 24)
        Me.lblSLoins.TabIndex = 71
        Me.lblSLoins.Text = "0"
        Me.lblSLoins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(264, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 19)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Over-All Recovery"
        '
        'lblTotalRejects
        '
        Me.lblTotalRejects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRejects.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRejects.Location = New System.Drawing.Point(816, 488)
        Me.lblTotalRejects.Name = "lblTotalRejects"
        Me.lblTotalRejects.Size = New System.Drawing.Size(168, 24)
        Me.lblTotalRejects.TabIndex = 69
        Me.lblTotalRejects.Text = "0"
        Me.lblTotalRejects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalRejects.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(808, 488)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 19)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Total Rejects"
        Me.Label14.Visible = False
        '
        'lblODM
        '
        Me.lblODM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblODM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblODM.Location = New System.Drawing.Point(400, 360)
        Me.lblODM.Name = "lblODM"
        Me.lblODM.Size = New System.Drawing.Size(128, 24)
        Me.lblODM.TabIndex = 67
        Me.lblODM.Text = "0"
        Me.lblODM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(264, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 19)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Dark Flakes %"
        '
        'lblOWM
        '
        Me.lblOWM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOWM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOWM.Location = New System.Drawing.Point(400, 296)
        Me.lblOWM.Name = "lblOWM"
        Me.lblOWM.Size = New System.Drawing.Size(128, 24)
        Me.lblOWM.TabIndex = 65
        Me.lblOWM.Text = "0"
        Me.lblOWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(264, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 19)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "White Flakes %"
        '
        'lblOLoins
        '
        Me.lblOLoins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOLoins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOLoins.Location = New System.Drawing.Point(400, 232)
        Me.lblOLoins.Name = "lblOLoins"
        Me.lblOLoins.Size = New System.Drawing.Size(128, 24)
        Me.lblOLoins.TabIndex = 63
        Me.lblOLoins.Text = "0"
        Me.lblOLoins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(264, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 19)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Frozen Loins %"
        '
        'lblRecovery
        '
        Me.lblRecovery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecovery.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecovery.Location = New System.Drawing.Point(1016, 480)
        Me.lblRecovery.Name = "lblRecovery"
        Me.lblRecovery.Size = New System.Drawing.Size(168, 56)
        Me.lblRecovery.TabIndex = 61
        Me.lblRecovery.Text = "0"
        Me.lblRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRecovery.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(904, 480)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 32)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Total Recovery (%)"
        Me.Label9.Visible = False
        '
        'lblTotalMeat
        '
        Me.lblTotalMeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMeat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMeat.Location = New System.Drawing.Point(40, 320)
        Me.lblTotalMeat.Name = "lblTotalMeat"
        Me.lblTotalMeat.Size = New System.Drawing.Size(168, 24)
        Me.lblTotalMeat.TabIndex = 59
        Me.lblTotalMeat.Text = "0"
        Me.lblTotalMeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalMeat.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(640, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Total Packed Meat"
        Me.Label4.Visible = False
        '
        'lblTotalFish
        '
        Me.lblTotalFish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFish.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFish.Location = New System.Drawing.Point(456, 488)
        Me.lblTotalFish.Name = "lblTotalFish"
        Me.lblTotalFish.Size = New System.Drawing.Size(168, 24)
        Me.lblTotalFish.TabIndex = 57
        Me.lblTotalFish.Text = "0"
        Me.lblTotalFish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalFish.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(456, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Total Round Fish"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Date To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Date From"
        '
        'txtDateTo
        '
        Me.txtDateTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.Location = New System.Drawing.Point(96, 46)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(144, 23)
        Me.txtDateTo.TabIndex = 53
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.Location = New System.Drawing.Point(96, 13)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(144, 23)
        Me.txtDateFrom.TabIndex = 52
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'gridFZ
        '
        Me.gridFZ.AllowColMove = False
        Me.gridFZ.AllowSort = False
        Me.gridFZ.AllowUpdate = False
        Me.gridFZ.CaptionHeight = 17
        Me.gridFZ.FilterBar = True
        Me.gridFZ.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridFZ.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridFZ.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.gridFZ.Location = New System.Drawing.Point(640, 512)
        Me.gridFZ.Name = "gridFZ"
        Me.gridFZ.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridFZ.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridFZ.PreviewInfo.ZoomFactor = 75
        Me.gridFZ.RowHeight = 20
        Me.gridFZ.Size = New System.Drawing.Size(632, 72)
        Me.gridFZ.TabIndex = 54
        Me.gridFZ.TabStop = False
        Me.gridFZ.Text = "C1TrueDBGrid1"
        Me.gridFZ.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Tahoma, 9.75pt, style=Bold;}HighlightRow{ForeColor:Highl" & _
        "ightText;BackColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;" & _
        "}Style15{}Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor" & _
        ":ControlText;BackColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12" & _
        "{}Style13{}Style1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowC" & _
        "olMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterH" & _
        "eight=""17"" FilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=" & _
        """17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Heig" & _
        "ht>68</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""" & _
        "Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarSty" & _
        "le parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" />" & _
        "<GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Sty" & _
        "le2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle par" & _
        "ent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordS" & _
        "electorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selec" & _
        "ted"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 628, 6" & _
        "8</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Wi" & _
        "n.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><S" & _
        "tyle parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style" & _
        " parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style " & _
        "parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style pare" & _
        "nt=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style par" & _
        "ent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style " & _
        "parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedSty" & _
        "les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><De" & _
        "faultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 628, 68</ClientArea><P" & _
        "rintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=" & _
        """Style15"" /></Blob>"
        '
        'frmInqProductRecovery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1286, 576)
        Me.Controls.Add(Me.gridFZ)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmInqProductRecovery"
        Me.ShowInTaskbar = False
        Me.Text = "frmInqProductRecovery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmInqProductRecovery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDateFrom.Value = getServerDateTime()
        txtDateTo.Value = getServerDateTime()
    End Sub

    Public Sub displayData()
        With grid
            .DataSource = getProductionOutput(txtDateFrom.Text, txtDateTo.Text, "%").Tables(0)  'getProductionDetails(txtDateFrom.Text, txtDateTo.Text).Tables(0)
            .Columns(3).DefaultValue = "0.00"
            .Columns(6).DefaultValue = "0.00"
            .Columns(7).DefaultValue = "0.00"
            .Columns(8).DefaultValue = "0.00"

            .Columns(3).NumberFormat = "###,###,##0.##0"
            .Columns(6).NumberFormat = "###,###,##0.#0"
            .Columns(7).NumberFormat = "###,###,##0.#0"
            .Columns(8).NumberFormat = "###,###,##0.#0"

            computeMeat()
        End With
    End Sub

    Public Sub displayDataFZBag()
        With gridFZ
            .DataSource = getProductionOutput_FZBag(txtDateFrom.Text, txtDateTo.Text, "%").Tables(0)  'getProductionDetails(txtDateFrom.Text, txtDateTo.Text).Tables(0)
            .Columns(3).DefaultValue = "0.00"
            .Columns(6).DefaultValue = "0.00"
            .Columns(7).DefaultValue = "0.00"
            .Columns(8).DefaultValue = "0.00"

            .Columns(3).NumberFormat = "###,###,##0.##0"
            .Columns(6).NumberFormat = "###,###,##0.#0"
            .Columns(7).NumberFormat = "###,###,##0.#0"
            .Columns(8).NumberFormat = "###,###,##0.#0"

            'computeMeat()
        End With
    End Sub

    Public Sub computeMeat()
        Dim ctr As Integer
        Dim total As Double
        With grid
            While ctr < .RowCount
                If CStr(.Item(ctr, 2)).StartsWith("F") Or CStr(.Item(ctr, 2)).StartsWith("R") Then
                    .Item(ctr, 3) = CDbl(.Item(ctr, 3)) * getCansPerCase(getProductCanSize(.Item(ctr, 2)), "CAN SIZE")
                    .Item(ctr, 5) = 1
                    .Item(ctr, 6) = (CDbl(.Item(ctr, 3)) * .Item(ctr, 4) * 1) / 1000
                End If

                If CStr(.Item(ctr, 2)).StartsWith("D") Then 'Or CStr(.Item(ctr, 2)).StartsWith("R") Then
                    .Item(ctr, 7) = .Item(ctr, 6) * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))  '0.67
                    .Item(ctr, 8) = .Item(ctr, 6) * (getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))
                ElseIf CStr(.Item(ctr, 2)).StartsWith("R") Then
                    .Item(ctr, 7) = .Item(ctr, 6) * 0.8
                    .Item(ctr, 8) = .Item(ctr, 6) * 0.2 '(getMeatPercentage(txtDateFrom.Text))
                ElseIf CStr(.Item(ctr, 2)).StartsWith("P") Then
                    .Item(ctr, 7) = .Item(ctr, 6) * 0.08
                    .Item(ctr, 8) = .Item(ctr, 6) * 0.92
                Else
                    .Item(ctr, 7) = "0.00"
                    .Item(ctr, 8) = .Item(ctr, 6)
                End If

                total += .Item(ctr, 6)

                ctr += 1
            End While
        End With

        lblTotalFish.Text = Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text, "%", "%"), "###,###,##0.#0")  'Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text), "###,###,##0.#0")
        lblTotalMeat.Text = Format(total, "###,###,##0.#0")
        lblOSizeQty.Text = getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "%")
        lblOSize.Text = Format(CDbl(lblTotalFish.Text) / getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "%"), "###,###,##0.#0")

        lblTotalRejects.Text = Format(getTotalRejects(txtDateFrom.Text, txtDateTo.Text, "%", "%"), "###,###,##0.#0")
        lblORejP.Text = Format(CDbl(lblTotalRejects.Text) / lblTotalFish.Text * 100, "##0.#0")
        lblRecovery.Text = Format((total / (getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text) - getTotalRejects(txtDateFrom.Text, txtDateTo.Text, "%", "%"))), "##0.#0%")

        lblSFish.Text = Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text, "%", "Skip%"), "###,###,##0.#0")
        lblSRejects.Text = Format(getTotalRejects(txtDateFrom.Text, txtDateTo.Text, "%", "Skip%"), "###,###,##0.#0")
        If CDbl(lblSFish.Text) = 0 Then
            lblSSize.Text = "0.00"
            lblSSizeQty.Text = "0.00"
            lblSRejP.Text = "0.00"
        Else
            lblSSize.Text = Format(CDbl(lblSFish.Text) / getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Skip%"), "###,###,##0.#0")
            lblSSizeQty.Text = getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Skip%")
            lblSRejP.Text = Format(CDbl(lblSRejects.Text) / lblSFish.Text * 100, "##0.#0")
        End If

        lblYFish.Text = Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text, "%", "Yellow%"), "###,###,##0.#0")
        lblYRejects.Text = Format(getTotalRejects(txtDateFrom.Text, txtDateTo.Text, "%", "Yellow%"), "###,###,##0.#0")
        If CDbl(lblYFish.Text) = 0 Then
            lblYSize.Text = "0.00"
            lblYSizeQty.Text = "0.00"
            lblYRejP.Text = "0.00"
        Else
            lblYSize.Text = Format(CDbl(lblYFish.Text) / getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Yellow%"), "###,###,##0.#0")
            lblYSizeQty.Text = getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Yellow%")
            lblYRejP.Text = Format(CDbl(lblYRejects.Text) / lblYFish.Text * 100, "##0.#0")
        End If

        lblBFish.Text = Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text, "%", "Big%"), "###,###,##0.#0")
        lblBRejects.Text = Format(getTotalRejects(txtDateFrom.Text, txtDateTo.Text, "%", "Big%"), "###,###,##0.#0")
        If CDbl(lblBFish.Text) = 0 Then
            lblBSize.Text = "0.00"
            lblBSizeQty.Text = "0.00"
            lblBRejP.Text = "0.00"
        Else
            lblBSize.Text = Format(CDbl(lblBFish.Text) / getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Big%"), "###,###,##0.#0")
            lblBSizeQty.Text = getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Big%")
            lblBRejP.Text = Format(CDbl(lblBRejects.Text) / lblBFish.Text * 100, "##0.#0")
        End If

        lblAFish.Text = Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text, "%", "Alb%"), "###,###,##0.#0")
        lblARejects.Text = Format(getTotalRejects(txtDateFrom.Text, txtDateTo.Text, "%", "Alb%"), "###,###,##0.#0")
        If CDbl(lblAFish.Text) = 0 Then
            lblASize.Text = "0.00"
            lblASizeQty.Text = "0.00"
            lblARejP.Text = "0.00"
        Else
            lblASize.Text = Format(CDbl(lblAFish.Text) / getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Alb%"), "###,###,##0.#0")
            lblASizeQty.Text = getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Alb%")
            lblARejP.Text = Format(CDbl(lblARejects.Text) / lblAFish.Text * 100, "##0.#0")
        End If

        computeRecovery()
    End Sub

    Public Sub computeRecovery()
        Dim ctr As Integer
        Dim loin, loinS, loinY, loinB, loinA As Double
        Dim wm, wmS, wmY, wmB, wmA As Double
        Dim dm, dmS, dmY, dmB, dmA As Double
        With grid
            'REPROCESSED FROZEN FLAKES BAG
            lblYWFZ.Text = Format(getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "F%", "Yellow Fin"), "###,###,##0.#0")
            lblSWFZ.Text = Format(getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "F%", "Skipjack"), "###,###,##0.#0")
            lblBWFZ.Text = Format(getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "F%", "Big Eye"), "###,###,##0.#0")
            lblAWFZ.Text = Format(getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "F%", "Albacore"), "###,###,##0.#0")
            lblOWFZ.Text = Format(CDbl(lblYWFZ.Text) + lblSWFZ.Text + lblBWFZ.Text + lblAWFZ.Text, "###,###,##0.#0")

            lblYRFZ.Text = Format(getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Yellow Fin"), "###,###,##0.#0")
            lblSRFZ.Text = Format(getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Skipjack"), "###,###,##0.#0")
            lblBRFZ.Text = Format(getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Big Eye"), "###,###,##0.#0")
            lblARFZ.Text = Format(getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Albacore"), "###,###,##0.#0")
            lblORFZ.Text = Format(CDbl(lblYRFZ.Text) + lblSRFZ.Text + lblBRFZ.Text + lblARFZ.Text, "###,###,##0.#0")

            While ctr < .RowCount
                If CStr(.Item(ctr, 2)).StartsWith("L") Then
                    loin += CDbl(.Item(ctr, 6))
                ElseIf CStr(.Item(ctr, 2)).StartsWith("W") Or CStr(.Item(ctr, 2)).StartsWith("F") Or CStr(.Item(ctr, 2)).StartsWith("C") Or CStr(.Item(ctr, 2)).StartsWith("S") Then
                    wm += .Item(ctr, 6)
                ElseIf CStr(.Item(ctr, 2)).StartsWith("D") Then
                    wm += (.Item(ctr, 6) * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))     '0.67
                    dm += (.Item(ctr, 6) * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))) '0.33
                ElseIf CStr(.Item(ctr, 2)).StartsWith("R") Then
                    wm += (.Item(ctr, 6) * 0.2)
                    dm += (.Item(ctr, 6) * 0.8)  '(1 - getMeatPercentage(txtDateFrom.Text))) '0.33
                ElseIf CStr(.Item(ctr, 2)).StartsWith("P") Then
                    wm += (.Item(ctr, 6) * 0.92)
                    dm += (.Item(ctr, 6) * 0.08)
                End If

                'If CStr(.Item(ctr, 2)).StartsWith("D") Or CStr(.Item(ctr, 2)).StartsWith("R") Then wm += (.Item(ctr, 6) * 0.33)

                If (CStr(.Item(ctr, 2)).StartsWith("L")) And CStr(.Item(ctr, 9)).StartsWith("Skip") Then loinS += .Item(ctr, 6)
                If (CStr(.Item(ctr, 2)).StartsWith("L")) And CStr(.Item(ctr, 9)).StartsWith("Yellow") Then loinY += .Item(ctr, 6)
                If (CStr(.Item(ctr, 2)).StartsWith("L")) And CStr(.Item(ctr, 9)).StartsWith("Big") Then loinB += .Item(ctr, 6)
                If (CStr(.Item(ctr, 2)).StartsWith("L")) And CStr(.Item(ctr, 9)).StartsWith("Alb") Then loinA += .Item(ctr, 6)
                'Or CStr(.Item(ctr, 2)).StartsWith("C") Or CStr(.Item(ctr, 2)).StartsWith("S")

                'computation for white meat
                If (CStr(.Item(ctr, 2)).StartsWith("W") Or CStr(.Item(ctr, 2)).StartsWith("F") Or CStr(.Item(ctr, 2)).StartsWith("C") Or CStr(.Item(ctr, 2)).StartsWith("S")) And CStr(.Item(ctr, 9)).StartsWith("Skip") Then wmS += .Item(ctr, 6)
                If (CStr(.Item(ctr, 2)).StartsWith("W") Or CStr(.Item(ctr, 2)).StartsWith("F") Or CStr(.Item(ctr, 2)).StartsWith("C") Or CStr(.Item(ctr, 2)).StartsWith("S")) And CStr(.Item(ctr, 9)).StartsWith("Yellow") Then wmY += .Item(ctr, 6)
                If (CStr(.Item(ctr, 2)).StartsWith("W") Or CStr(.Item(ctr, 2)).StartsWith("F") Or CStr(.Item(ctr, 2)).StartsWith("C") Or CStr(.Item(ctr, 2)).StartsWith("S")) And CStr(.Item(ctr, 9)).StartsWith("Big") Then wmB += .Item(ctr, 6)
                If (CStr(.Item(ctr, 2)).StartsWith("W") Or CStr(.Item(ctr, 2)).StartsWith("F") Or CStr(.Item(ctr, 2)).StartsWith("C") Or CStr(.Item(ctr, 2)).StartsWith("S")) And CStr(.Item(ctr, 9)).StartsWith("Alb") Then wmA += .Item(ctr, 6)
                'add the 92% of white meat from special products
                If (CStr(.Item(ctr, 2)).StartsWith("P")) And CStr(.Item(ctr, 9)).StartsWith("Skip") Then wmS += (.Item(ctr, 6) * 0.92)
                If (CStr(.Item(ctr, 2)).StartsWith("P")) And CStr(.Item(ctr, 9)).StartsWith("Yellow") Then wmY += (.Item(ctr, 6) * 0.92)
                If (CStr(.Item(ctr, 2)).StartsWith("P")) And CStr(.Item(ctr, 9)).StartsWith("Big") Then wmB += (.Item(ctr, 6) * 0.92)
                If (CStr(.Item(ctr, 2)).StartsWith("P")) And CStr(.Item(ctr, 9)).StartsWith("Alb") Then wmA += (.Item(ctr, 6) * 0.92)
                'add also the 33% of white meat from dark meat products
                If (CStr(.Item(ctr, 2)).StartsWith("D")) And CStr(.Item(ctr, 9)).StartsWith("Skip") Then wmS += (.Item(ctr, 6) * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)) '0.33
                If (CStr(.Item(ctr, 2)).StartsWith("D")) And CStr(.Item(ctr, 9)).StartsWith("Yellow") Then wmY += (.Item(ctr, 6) * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)) '0.33
                If (CStr(.Item(ctr, 2)).StartsWith("D")) And CStr(.Item(ctr, 9)).StartsWith("Big") Then wmB += (.Item(ctr, 6) * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)) '0.33
                If (CStr(.Item(ctr, 2)).StartsWith("D")) And CStr(.Item(ctr, 9)).StartsWith("Alb") Then wmA += (.Item(ctr, 6) * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)) '0.33
                'add also the 20% of white meat from dark meat products
                If (CStr(.Item(ctr, 2)).StartsWith("R")) And CStr(.Item(ctr, 9)).StartsWith("Skip") Then wmS += (.Item(ctr, 6) * 0.2) '0.33
                If (CStr(.Item(ctr, 2)).StartsWith("R")) And CStr(.Item(ctr, 9)).StartsWith("Yellow") Then wmY += (.Item(ctr, 6) * 0.2) '0.33
                If (CStr(.Item(ctr, 2)).StartsWith("R")) And CStr(.Item(ctr, 9)).StartsWith("Big") Then wmB += (.Item(ctr, 6) * 0.2) '0.33
                If (CStr(.Item(ctr, 2)).StartsWith("R")) And CStr(.Item(ctr, 9)).StartsWith("Alb") Then wmA += (.Item(ctr, 6) * 0.2) '0.33
               
                'computation for dark meat
                If (CStr(.Item(ctr, 2)).StartsWith("D")) And CStr(.Item(ctr, 9)).StartsWith("Skip") Then dmS += (.Item(ctr, 6) * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))) '0.67
                If (CStr(.Item(ctr, 2)).StartsWith("D")) And CStr(.Item(ctr, 9)).StartsWith("Yellow") Then dmY += (.Item(ctr, 6) * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))) '0.67
                If (CStr(.Item(ctr, 2)).StartsWith("D")) And CStr(.Item(ctr, 9)).StartsWith("Big") Then dmB += (.Item(ctr, 6) * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))) '0.67
                If (CStr(.Item(ctr, 2)).StartsWith("D")) And CStr(.Item(ctr, 9)).StartsWith("Alb") Then dmA += (.Item(ctr, 6) * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))) '0.67
                'add the 8% of specie products
                If (CStr(.Item(ctr, 2)).StartsWith("P")) And CStr(.Item(ctr, 9)).StartsWith("Skip") Then dmS += (.Item(ctr, 6) * 0.08)
                If (CStr(.Item(ctr, 2)).StartsWith("P")) And CStr(.Item(ctr, 9)).StartsWith("Yellow") Then dmY += (.Item(ctr, 6) * 0.08)
                If (CStr(.Item(ctr, 2)).StartsWith("P")) And CStr(.Item(ctr, 9)).StartsWith("Big") Then dmB += (.Item(ctr, 6) * 0.08)
                If (CStr(.Item(ctr, 2)).StartsWith("P")) And CStr(.Item(ctr, 9)).StartsWith("Alb") Then dmA += (.Item(ctr, 6) * 0.08)
                'add the 80% of dark meat from red flakes bags
                If (CStr(.Item(ctr, 2)).StartsWith("R")) And CStr(.Item(ctr, 9)).StartsWith("Skip") Then dmS += (.Item(ctr, 6) * 0.8) '0.67
                If (CStr(.Item(ctr, 2)).StartsWith("R")) And CStr(.Item(ctr, 9)).StartsWith("Yellow") Then dmY += (.Item(ctr, 6) * 0.8) '0.67
                If (CStr(.Item(ctr, 2)).StartsWith("R")) And CStr(.Item(ctr, 9)).StartsWith("Big") Then dmB += (.Item(ctr, 6) * 0.8) '0.67
                If (CStr(.Item(ctr, 2)).StartsWith("R")) And CStr(.Item(ctr, 9)).StartsWith("Alb") Then dmA += (.Item(ctr, 6) * 0.8) '0.67

                ctr += 1
            End While
        End With

        wm = wm - lblOWFZ.Text - (CDbl(lblORFZ.Text) * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))
        dm = dm - (CDbl(lblORFZ.Text) * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)))

        lblFL.Text = Format(loin, "###,###,##0.#0")
        lblWF.Text = Format(wm, "###,###,##0.#0")
        lblDF.Text = Format(dm, "###,###,##0.#0")

        lblOLoins.Text = Format((loin / (lblOFish.Text - lblORejects.Text)) * 100, "###,###,##0.#0")
        lblOWM.Text = Format((wm / (lblOFish.Text - lblORejects.Text)) * 100, "###,###,##0.#0")
        lblODM.Text = Format((dm / (lblOFish.Text - lblORejects.Text)) * 100, "###,###,##0.#0")

        'deduct the total packed meat from frozen white flakes bag which is equivalent to number of bags multiply to 8kg
        If wmS > 0 Then wmS -= lblSWFZ.Text
        If wmY > 0 Then wmY -= lblYWFZ.Text
        If wmB > 0 Then wmB -= lblBWFZ.Text
        If wmA > 0 Then wmA -= lblAWFZ.Text
        'deduct the 20% of total packed meat from frozen red flakes bag
        If wmS > 0 Then wmS -= (lblSRFZ.Text * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))
        If wmY > 0 Then wmY -= (lblYRFZ.Text * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))
        If wmB > 0 Then wmB -= (lblBRFZ.Text * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))
        If wmA > 0 Then wmA -= (lblARFZ.Text * getMeatPercentage(txtDateFrom.Text, txtDateTo.Text))

        'deduct the 80% of total packed meat from frozen red flakes bag
        If dmS > 0 Then dmS -= (lblSRFZ.Text * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)))
        If dmY > 0 Then dmY -= (lblYRFZ.Text * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)))
        If dmB > 0 Then dmB -= (lblBRFZ.Text * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)))
        If dmA > 0 Then dmA -= (lblARFZ.Text * (1 - getMeatPercentage(txtDateFrom.Text, txtDateTo.Text)))

        'FROZEN LOINS
        lblSLoins2.Text = Format(loinS, "###,##0.#0")
        If Not lblSFish.Text = "0.00" Then
            lblSLoins.Text = Format((loinS / (lblSFish.Text - lblSRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblSLoins.Text = "0.00"
        End If

        lblYLoins2.Text = Format(loinY, "###,##0.#0")
        If Not lblYFish.Text = "0.00" Then
            lblYLoins.Text = Format((loinY / (lblYFish.Text - lblYRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblYLoins.Text = "0.00"
        End If

        lblBLoins2.Text = Format(loinB, "###,##0.#0")
        If Not lblBFish.Text = "0.00" Then
            lblBLoins.Text = Format((loinB / (lblBFish.Text - lblBRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblBLoins.Text = "0.00"
        End If

        lblALoins2.Text = Format(loinA, "###,##0.#0")
        If Not lblAFish.Text = "0.00" Then
            lblALoins.Text = Format((loinA / (lblAFish.Text - lblARejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblALoins.Text = "0.00"
        End If

        'WHITE MEAT
        '- getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "F%", "Skipjack") - (getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Skipjack") * 0.2)
        lblSWM2.Text = Format(wmS, "###,##0.#0")
        If Not lblSFish.Text = "0.00" Then
            lblSWM.Text = Format((lblSWM2.Text / (lblSFish.Text - lblSRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblSWM.Text = "0.00"
        End If

        '- getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "F%", "Yellow Fin") - (getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Yellow Fin") * 0.2)
        lblYWM2.Text = Format(wmY, "###,##0.#0")
        If Not lblYFish.Text = "0.00" Then
            lblYWM.Text = Format((lblYWM2.Text / (lblYFish.Text - lblYRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblYWM.Text = "0.00"
        End If

        '- getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "F%", "Big Eye") - (getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Big Eye") * 0.2)
        lblBWM2.Text = Format(wmB, "###,##0.#0")
        If Not lblBFish.Text = "0.00" Then
            lblBWM.Text = Format((lblBWM2.Text / (lblBFish.Text - lblBRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblBWM.Text = "0.00"
        End If

        '- getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "F%", "Albacore") - (getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Albacore") * 0.2)
        lblAWM2.Text = Format(wmA, "###,##0.#0")
        If Not lblAFish.Text = "0.00" Then
            lblAWM.Text = Format((lblAWM2.Text / (lblAFish.Text - lblARejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblAWM.Text = "0.00"
        End If

        'DARK MEAT
        '- (getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Skipjack") * 0.8)
        lblSDM2.Text = Format(dmS, "###,##0.#0")
        If Not lblSFish.Text = "0.00" Then
            lblSDM.Text = Format((lblSDM2.Text / (lblSFish.Text - lblSRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblSDM.Text = "0.00"
        End If

        '- (getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Yellow Fin") * 0.8)
        lblYDM2.Text = Format(dmY, "###,##0.#0")
        If Not lblYFish.Text = "0.00" Then
            lblYDM.Text = Format((lblYDM2.Text / (lblYFish.Text - lblYRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblYDM.Text = "0.00"
        End If

        '- (getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Big Eye") * 0.8)
        lblBDM2.Text = Format(dmB, "###,##0.#0")
        If Not lblBFish.Text = "0.00" Then
            lblBDM.Text = Format((lblBDM2.Text / (lblBFish.Text - lblBRejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblBDM.Text = "0.00"
        End If

        '- (getFZBagsWithdrawalQty(txtDateFrom.Text, txtDateTo.Text, "R%", "Albacore") * 0.8)
        lblADM2.Text = Format(dmA, "###,##0.#0")
        If Not lblAFish.Text = "0.00" Then
            lblADM.Text = Format((lblADM2.Text / (lblAFish.Text - lblARejects.Text)) * 100, "###,###,##0.#0")
        Else
            lblADM.Text = "0.00"
        End If

        Dim cSJ, cYF, cBE, cAL As Double
        cSJ = ((CDbl(lblSSize.Text) * 2.2046) ^ getMatrixCurve(True, "SJ")) * getMatrixCurve(False, "SJ")
        cYF = ((CDbl(lblYSize.Text) * 2.2046) ^ getMatrixCurve(True, "YF")) * getMatrixCurve(False, "YF")
        cBE = ((CDbl(lblBSize.Text) * 2.2046) ^ getMatrixCurve(True, "BE")) * getMatrixCurve(False, "BE")
        cAL = ((CDbl(lblASize.Text) * 2.2046) ^ getMatrixCurve(True, "AL")) * getMatrixCurve(False, "AL")

        If cSJ > 0 Then
            lblSCurve.Text = Format(((CDbl(lblSWM.Text) + lblSLoins.Text) / cSJ) * 100, "##0.#0")
        Else
            lblSCurve.Text = "0.00"
        End If
        If cYF > 0 Then
            lblYCurve.Text = Format(((CDbl(lblYWM.Text) + lblYLoins.Text) / cYF) * 100, "##0.#0")
        Else
            lblYCurve.Text = "0.00"
        End If
        If cBE > 0 Then
            lblBCurve.Text = Format(((CDbl(lblBWM.Text) + lblBLoins.Text) / cBE) * 100, "##0.#0")
        Else
            lblBCurve.Text = "0.00"
        End If
        If cAL > 0 Then
            lblACurve.Text = Format(((CDbl(lblAWM.Text) + lblALoins.Text) / cAL) * 100, "##0.#0")
        Else
            lblACurve.Text = "0.00"
        End If

        Dim cTot As Double = ((cSJ * (lblSFish.Text - lblSRejects.Text)) + _
            (cYF * (lblYFish.Text - lblYRejects.Text)) + _
            (cBE * (lblBFish.Text - lblBRejects.Text)) + _
            (cAL * (lblAFish.Text - lblARejects.Text)))
        Dim aTot As Double = ((CDbl(lblSWM.Text) + lblSLoins.Text) * (lblSFish.Text - lblSRejects.Text)) + _
            ((CDbl(lblYWM.Text) + lblYLoins.Text) * (lblYFish.Text - lblYRejects.Text)) + _
            ((CDbl(lblBWM.Text) + lblBLoins.Text) * (lblBFish.Text - lblBRejects.Text)) + _
            ((CDbl(lblAWM.Text) + lblALoins.Text) * (lblAFish.Text - lblARejects.Text))

        lblOCurve.Text = Format(aTot / cTot * 100, "##0.#0")
    End Sub

    Private Sub txtDateFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateFrom.ValueChanged
        printCaption()

        displayData()
        displayDataFZBag()
    End Sub

    Private Sub txtDateTo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateTo.ValueChanged
        printCaption()
        displayData()
        displayDataFZBag()
    End Sub

    Private Sub lblTotalFish_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTotalFish.TextChanged
        If Not lblTotalFish.Text.Trim = "" Then
            lblOFish.Text = Format(CDbl(lblTotalFish.Text), "###,###,###,##0.#0")
        Else
            lblOFish.Text = "0.00"
        End If
    End Sub

    Private Sub lblTotalRejects_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTotalRejects.TextChanged
        If Not lblTotalRejects.Text.Trim = "" Then
            lblORejects.Text = Format(CDbl(lblTotalRejects.Text), "###,###,###,##0.#0")
        Else
            lblORejects.Text = "0.00"
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If cmdPrint.Text = "&Save and Print" Then
            deletePrintProductionReport(txtDateFrom.Text, "*")

            saveNewPrintProductionReport(lblTotalFish.Text, lblSFish.Text, lblYFish.Text, lblBFish.Text, _
                lblOSize.Text, lblSSize.Text, lblYSize.Text, lblBSize.Text, _
                lblORejects.Text, lblSRejects.Text, lblYRejects.Text, lblBRejects.Text, _
                lblORejP.Text, lblSRejP.Text, lblYRejP.Text, lblBRejP.Text, _
                lblOCurve.Text, lblSCurve.Text, lblYCurve.Text, lblBCurve.Text, _
                lblFL.Text, lblSLoins2.Text, lblYLoins2.Text, lblBLoins2.Text, _
                lblOLoins.Text, lblSLoins.Text, lblYLoins.Text, lblBLoins.Text, _
                lblWF.Text, lblSWM2.Text, lblYWM2.Text, lblBWM2.Text, _
                lblOWM.Text, lblSWM.Text, lblYWM.Text, lblBWM.Text, _
                lblDF.Text, lblSDM2.Text, lblYDM2.Text, lblBDM2.Text, _
                lblODM.Text, lblSDM.Text, lblYDM.Text, lblBDM.Text, 0, 0, txtDateFrom.Text, txtDateTo.Text, "*", _
                lblOSizeQty.Text, lblSSizeQty.Text, lblYSizeQty.Text, lblBSizeQty.Text, lblAFish.Text, _
                lblASize.Text, lblARejects.Text, lblARejP.Text, lblACurve.Text, lblALoins2.Text, _
                lblALoins.Text, lblAWM2.Text, lblAWM.Text, lblADM2.Text, lblADM.Text, lblASizeQty.Text)

            'Else
            '    deletePrintProductionReport(txtDateTo.Text, Format(CDate(txtDateFrom.Text), getTimeFormat()) & " - " & Format(CDate(txtDateTo.Text), getTimeFormat()))

            '    saveNewPrintProductionReport(lblTotalFish.Text, lblSFish.Text, lblYFish.Text, lblBFish.Text, _
            '        lblOSize.Text, lblSSize.Text, lblYSize.Text, lblBSize.Text, _
            '        lblORejects.Text, lblSRejects.Text, lblYRejects.Text, lblBRejects.Text, _
            '        lblORejP.Text, lblSRejP.Text, lblYRejP.Text, lblBRejP.Text, _
            '        lblOCurve.Text, lblSCurve.Text, lblYCurve.Text, lblBCurve.Text, _
            '        lblFL.Text, lblSLoins2.Text, lblYLoins2.Text, lblBLoins2.Text, _
            '        lblOLoins.Text, lblSLoins.Text, lblYLoins.Text, lblBLoins.Text, _
            '        lblWF.Text, lblSWM2.Text, lblYWM2.Text, lblBWM2.Text, _
            '        lblOWM.Text, lblSWM.Text, lblYWM.Text, lblBWM.Text, _
            '        lblDF.Text, lblSDM2.Text, lblYDM2.Text, lblBDM2.Text, _
            '        lblODM.Text, lblSDM.Text, lblYDM.Text, lblBDM.Text, 0, 0, txtDateTo.Text, txtDateTo.Text, _
            '        Format(CDate(txtDateFrom.Text), getTimeFormat()) & " - " & Format(CDate(txtDateTo.Text), getTimeFormat()))
        End If

        'Dim f As New frmPrintProductionReport
        'f.displayReport(txtDateFrom.Text, txtDateTo.Text, lblOCurve.Text, lblYCurve.Text, lblSCurve.Text, lblBCurve.Text, lblACurve.Text)
        'f.ShowDialog(Me)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
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
        'While ctr < grid.Columns.Count
        '    If col = 25 Then col = 0
        '    If col > 24 Then
        '        cell = GetExcelColumn("A" & col) '& "1"
        '    Else
        '        cell = GetExcelColumn(col) '& "1"
        '    End If
        excelWorksheet.Range("A1").Value = "Prod'n Date"
        excelWorksheet.Range("B1").Value = "Lot No."
        excelWorksheet.Range("C1").Value = "Product"
        excelWorksheet.Range("D1").Value = "No. of cases"
        excelWorksheet.Range("E1").Value = "FW"
        excelWorksheet.Range("F1").Value = "per Case"
        excelWorksheet.Range("G1").Value = "Meat per Case"
        excelWorksheet.Range("H1").Value = "Dark Meat"
        excelWorksheet.Range("I1").Value = "White Meat"
        excelWorksheet.Range("J1").Value = "Fish Specie"

        '    col += 1
        '    ctr += 1
        'End While

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
            Next
        Next

        ' turn off wait cursor
        Me.Cursor = Cursors.Default

        ' view the spread sheet
        excelApp.Visible = True
    End Sub

    Public Sub printCaption()
        If txtDateFrom.Text = txtDateTo.Text Then
            'cmdPrint.Enabled = True
            cmdPrint.Text = "&Save and Print"
        Else
            'cmdPrint.Enabled = False
            cmdPrint.Text = "&Print Summary"
        End If
    End Sub

    Private Sub cmdKPI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKPI.Click
        Dim dateFrom As DateTime = txtDateFrom.Value '"01/02/2012"
        Dim dateTo As DateTime = txtDateTo.Value '"29/02/2012"

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

        'COLUMNS
        excelWorksheet.Range("B4").Value = "Skipjack"
        excelWorksheet.Range("B5").Value = txtDateFrom.Text 'Format(CDate(txtDateFrom.Text), getTimeFormat())
        excelWorksheet.Range("C5").Value = "WTD"
        excelWorksheet.Range("D5").Value = "MTD"
        excelWorksheet.Range("E5").Value = "YTD"

        excelWorksheet.Range("F4").Value = "Yellow Fin"
        excelWorksheet.Range("F5").Value = txtDateFrom.Text 'Format(CDate(txtDateFrom.Text), getTimeFormat())
        excelWorksheet.Range("G5").Value = "WTD"
        excelWorksheet.Range("H5").Value = "MTD"
        excelWorksheet.Range("I5").Value = "YTD"

        excelWorksheet.Range("J4").Value = "Albacore"
        excelWorksheet.Range("J5").Value = txtDateFrom.Text 'Format(CDate(txtDateFrom.Text), getTimeFormat())
        excelWorksheet.Range("K5").Value = "WTD"
        excelWorksheet.Range("L5").Value = "MTD"
        excelWorksheet.Range("M5").Value = "YTD"

        excelWorksheet.Range("n4").Value = "Total YTD"

        'ROWS
        excelWorksheet.Range("A6").Value = "Gross Throughput [Metric Tons]"
        excelWorksheet.Range("A7").Value = "Cold Room Exit Weight [Metric Tons]"
        excelWorksheet.Range("A8").Value = "Reject [%]"
        excelWorksheet.Range("A9").Value = "Net Throughput [Metric Tons]"
        excelWorksheet.Range("A10").Value = "Average Fish Size [Kilograms]"
        excelWorksheet.Range("A11").Value = "Recovery %"
        excelWorksheet.Range("A12").Value = "   Frozen Loin"
        excelWorksheet.Range("A13").Value = "   Chunks and White Flakes - Canned Tuna"
        excelWorksheet.Range("A14").Value = "   Total White Meat Recovery"
        excelWorksheet.Range("A15").Value = "   Dark Meat"
        excelWorksheet.Range("A16").Value = "   Total Recovery"
        excelWorksheet.Range("A17").Value = "% Curve"

        excelWorksheet.Range("A19").Value = "   Frozen Loins [Metric Tons]"
        excelWorksheet.Range("A20").Value = "   Canned Tuna [Metric Tons]"

        excelWorksheet.Range("A22").Value = "Finished Goods Produced"
        excelWorksheet.Range("A23").Value = "  -  Frozen Loins"
        excelWorksheet.Range("A24").Value = "      7.5 kg Frozen Loins [Metric Tons]"
        excelWorksheet.Range("A25").Value = "      13 kg Frozen Loins [Metric Tons]"

        excelWorksheet.Range("A26").Value = "  -  Canned Tuna"
        excelWorksheet.Range("A27").Value = "     SJ Chunks in Oil"
        excelWorksheet.Range("A28").Value = "          100g (C0S2, C0Y2, C0A2, S0S2, S0Y2, S0A2)"
        excelWorksheet.Range("A29").Value = "          180g (C0S3, C0Y3, C0A3, S0S3, S0Y3, S0A3)"
        excelWorksheet.Range("A30").Value = "     SJ Chunks in Oil - Special"
        excelWorksheet.Range("A31").Value = "          100g (P0S2, P0Y2, P0A2)"
        excelWorksheet.Range("A32").Value = "          180g (P0S3, P0Y3, P0A3)"
        excelWorksheet.Range("A33").Value = "     YF Solid in Oil - Chilli"
        excelWorksheet.Range("A34").Value = "          100g (C6S2, C6Y2, C6A2, S6S2, S6Y2, S6A2)"
        excelWorksheet.Range("A35").Value = "          180g (C6S3, C6Y3, C6A3, S6S3, S6Y3, S6A3)"
        excelWorksheet.Range("A36").Value = "    White flakes in Oil"
        excelWorksheet.Range("A37").Value = "          100g (W0S2, W0Y2, W0A2)"
        excelWorksheet.Range("A38").Value = "          180g (W0S3, W0Y3, W0A3)"
        excelWorksheet.Range("A39").Value = "          250g (W0S9, W0Y9, W0A9)"
        excelWorksheet.Range("A40").Value = "          380g (W0S5, W0Y5, W0A5)"
        excelWorksheet.Range("A41").Value = "   Solomon Blue Dark Flakes"
        excelWorksheet.Range("A42").Value = "          100g (D0S2, D0Y2, D0A2)"
        excelWorksheet.Range("A43").Value = "          180g (D0S3, D0Y3, D0A3)"
        excelWorksheet.Range("A44").Value = "          250g (D0S9, D0Y9, D0A9)"
        excelWorksheet.Range("A45").Value = "          380g (D0S5, D0Y5, D0A5)"
        excelWorksheet.Range("A46").Value = "   Sandwich Flakes"
        excelWorksheet.Range("A47").Value = "          100g (W8S2, W8Y2, W8A2)"
        excelWorksheet.Range("A48").Value = "          180g (W8S3, W8Y3, W8A3)"
        excelWorksheet.Range("A49").Value = "   Curry Flakes"
        excelWorksheet.Range("A50").Value = "          100g (W7S2, W7Y2, W7A2)"
        excelWorksheet.Range("A51").Value = "          180g (W7S3, W7Y3, W7A3)"

        excelWorksheet.Range("B8").Value = Format(CDbl(lblSRejP.Text), "##0.#0")
        excelWorksheet.Range("F8").Value = Format(CDbl(lblYRejP.Text), "##0.#0")
        excelWorksheet.Range("J8").Value = Format(CDbl(lblARejP.Text), "##0.#0")

        excelWorksheet.Range("B9").Value = Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text, "%", "Skip%") / 1000, "###,###,##0.#0")
        excelWorksheet.Range("F9").Value = Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text, "%", "Yellow%") / 1000, "###,###,##0.#0")
        excelWorksheet.Range("J9").Value = Format(getTotalRoundFishProcessed(txtDateFrom.Text, txtDateTo.Text, "%", "Alb%") / 1000, "###,###,##0.#0")

        excelWorksheet.Range("B10").Value = Format(CDbl(lblSSize.Text), "##0.#0")   'CDbl(excelWorksheet.Range("B9").Value) / getFishRackQuantity(txtDateFrom.Text, txtDateTo.Text, "Skip%")
        excelWorksheet.Range("F10").Value = Format(CDbl(lblYSize.Text), "##0.#0")
        excelWorksheet.Range("J10").Value = Format(CDbl(lblASize.Text), "##0.#0")

        'FROZEN LOINS RECOVERY PERCENTAGE
        excelWorksheet.Range("B12").Value = Format(CDbl(lblSLoins.Text), "##0.#0")
        excelWorksheet.Range("F12").Value = Format(CDbl(lblYLoins.Text), "##0.#0")
        excelWorksheet.Range("J12").Value = Format(CDbl(lblALoins.Text), "##0.#0")
        'WHITE MEAT RECOVERY PERCENTAGE
        excelWorksheet.Range("B13").Value = Format(CDbl(lblSWM.Text), "##0.#0")
        excelWorksheet.Range("F13").Value = Format(CDbl(lblYWM.Text), "##0.#0")
        excelWorksheet.Range("J13").Value = Format(CDbl(lblAWM.Text), "##0.#0")
        'TOTAL WHITE MEAT RECOVERY PERCENTAGE
        excelWorksheet.Range("B14").Value = Format(CDbl(lblSLoins.Text) + CDbl(lblSWM.Text), "##0.#0")
        excelWorksheet.Range("F14").Value = Format(CDbl(lblYLoins.Text) + CDbl(lblYWM.Text), "##0.#0")
        excelWorksheet.Range("J14").Value = Format(CDbl(lblALoins.Text) + CDbl(lblAWM.Text), "##0.#0")
        'DARK MEAT RECOVERY PERCENTAGE
        excelWorksheet.Range("B15").Value = Format(CDbl(lblSDM.Text), "##0.#0")
        excelWorksheet.Range("F15").Value = Format(CDbl(lblYDM.Text), "##0.#0")
        excelWorksheet.Range("J15").Value = Format(CDbl(lblADM.Text), "##0.#0")
        'TOTAL RECOVERY
        excelWorksheet.Range("B16").Value = Format(CDbl(lblSLoins.Text) + CDbl(lblSWM.Text) + CDbl(lblSDM.Text), "##0.#0")
        excelWorksheet.Range("F16").Value = Format(CDbl(lblYLoins.Text) + CDbl(lblYWM.Text) + CDbl(lblYDM.Text), "##0.#0")
        excelWorksheet.Range("J16").Value = Format(CDbl(lblALoins.Text) + CDbl(lblAWM.Text) + CDbl(lblADM.Text), "##0.#0")
        'CURVE
        excelWorksheet.Range("B17").Value = Format(CDbl(lblSCurve.Text), "##0.#0")
        excelWorksheet.Range("F17").Value = Format(CDbl(lblYCurve.Text), "##0.#0")
        excelWorksheet.Range("J17").Value = Format(CDbl(lblACurve.Text), "##0.#0")
        'TOTAL FROZEN LOINS IN METRIC TONS
        excelWorksheet.Range("B19").Value = getTotalMTOutput("LS", False)
        excelWorksheet.Range("F19").Value = getTotalMTOutput("LY", False)
        excelWorksheet.Range("J19").Value = getTotalMTOutput("LA", False) + getTotalMTOutput("FA", False)
        'TOTAL CANNED TUNA IN METRIC TONS
        excelWorksheet.Range("B20").Value = getTotalMTOutput("D0S", True) + getTotalMTOutput("W0S", True) + getTotalMTOutput("C0S", True) + getTotalMTOutput("S0S", True) + getTotalMTOutput("W7S", True) + getTotalMTOutput("W8S", True) + getTotalMTOutput("P0S", True) + getTotalMTOutput("C6S", True) + getTotalMTOutput("S6S", True)
        excelWorksheet.Range("F20").Value = getTotalMTOutput("D0Y", True) + getTotalMTOutput("W0Y", True) + getTotalMTOutput("C0Y", True) + getTotalMTOutput("S0Y", True) + getTotalMTOutput("W7Y", True) + getTotalMTOutput("W8Y", True) + getTotalMTOutput("P0Y", True) + getTotalMTOutput("C6Y", True) + getTotalMTOutput("S6Y", True)
        excelWorksheet.Range("J20").Value = getTotalMTOutput("D0A", True) + getTotalMTOutput("W0A", True) + getTotalMTOutput("C0A", True) + getTotalMTOutput("S0A", True) + getTotalMTOutput("W7A", True) + getTotalMTOutput("W8A", True) + getTotalMTOutput("P0A", True) + getTotalMTOutput("C6A", True) + getTotalMTOutput("S6A", True)

        '7.5 FROZEN LOINS IN METRIC TONS
        excelWorksheet.Range("B24").Value = getTotalMTOutput("LS", False)
        excelWorksheet.Range("F24").Value = getTotalMTOutput("LY", False)
        excelWorksheet.Range("J24").Value = "0.00"
        '13kg FROZEN LOINS IN METRIC TONS
        excelWorksheet.Range("B25").Value = "0.00"
        excelWorksheet.Range("F25").Value = "0.00"
        excelWorksheet.Range("J25").Value = getTotalMTOutput("LA", False) + getTotalMTOutput("FA", False)

        'SJ Chunks in Oil
        '100g
        excelWorksheet.Range("B28").Value = getTotalCasesOutput("C0S2") + getTotalCasesOutput("S0S2")
        excelWorksheet.Range("F28").Value = getTotalCasesOutput("C0Y2") + getTotalCasesOutput("S0Y2")
        excelWorksheet.Range("J28").Value = getTotalCasesOutput("C0A2") + getTotalCasesOutput("S0A2")
        'SJ Chunks in Oil
        '180g
        excelWorksheet.Range("B29").Value = getTotalCasesOutput("C0S3") + getTotalCasesOutput("S0S3")
        excelWorksheet.Range("F29").Value = getTotalCasesOutput("C0Y3") + getTotalCasesOutput("S0Y3")
        excelWorksheet.Range("J29").Value = getTotalCasesOutput("C0A3") + getTotalCasesOutput("S0A3")
        'SJ Chunks in Oil - Special
        '100g
        excelWorksheet.Range("B31").Value = getTotalCasesOutput("P0S2")
        excelWorksheet.Range("F31").Value = getTotalCasesOutput("P0Y2")
        excelWorksheet.Range("J31").Value = getTotalCasesOutput("P0A2")
        '180g
        excelWorksheet.Range("B32").Value = getTotalCasesOutput("P0S3")
        excelWorksheet.Range("F32").Value = getTotalCasesOutput("P0Y3")
        excelWorksheet.Range("J32").Value = getTotalCasesOutput("P0A3")
        'YF Solid in Oil - Chilli
        '100g
        excelWorksheet.Range("B34").Value = getTotalCasesOutput("C6S2") + getTotalCasesOutput("S6S2")
        excelWorksheet.Range("F34").Value = getTotalCasesOutput("C6Y2") + getTotalCasesOutput("S6Y2")
        excelWorksheet.Range("J34").Value = getTotalCasesOutput("C6A2") + getTotalCasesOutput("S6A2")
        '180g
        excelWorksheet.Range("B35").Value = getTotalCasesOutput("C6S3") + getTotalCasesOutput("S6S3")
        excelWorksheet.Range("F35").Value = getTotalCasesOutput("C6Y3") + getTotalCasesOutput("S6Y3")
        excelWorksheet.Range("J35").Value = getTotalCasesOutput("C6A3") + getTotalCasesOutput("S6A3")
        'White flakes in Oil
        '100g
        excelWorksheet.Range("B37").Value = getTotalCasesOutput("W0S2")
        excelWorksheet.Range("F37").Value = getTotalCasesOutput("W0Y2")
        excelWorksheet.Range("J37").Value = getTotalCasesOutput("W0A2")
        '180g
        excelWorksheet.Range("B38").Value = getTotalCasesOutput("W0S3")
        excelWorksheet.Range("F38").Value = getTotalCasesOutput("W0Y3")
        excelWorksheet.Range("J38").Value = getTotalCasesOutput("W0A3")
        '250g
        excelWorksheet.Range("B39").Value = getTotalCasesOutput("W0S9")
        excelWorksheet.Range("F39").Value = getTotalCasesOutput("W0Y9")
        excelWorksheet.Range("J39").Value = getTotalCasesOutput("W0A9")
        '380g
        excelWorksheet.Range("B40").Value = getTotalCasesOutput("W0S5")
        excelWorksheet.Range("F40").Value = getTotalCasesOutput("W0Y5")
        excelWorksheet.Range("J40").Value = getTotalCasesOutput("W0A5")
        'Solomon Blue Dark Flakes
        '100g
        excelWorksheet.Range("B42").Value = getTotalCasesOutput("D0S2")
        excelWorksheet.Range("F42").Value = getTotalCasesOutput("D0Y2")
        excelWorksheet.Range("J42").Value = getTotalCasesOutput("D0A2")
        '180g
        excelWorksheet.Range("B43").Value = getTotalCasesOutput("D0S3")
        excelWorksheet.Range("F43").Value = getTotalCasesOutput("D0Y3")
        excelWorksheet.Range("J43").Value = getTotalCasesOutput("D0A3")
        '250g
        excelWorksheet.Range("B44").Value = getTotalCasesOutput("D0S9")
        excelWorksheet.Range("F44").Value = getTotalCasesOutput("D0Y9")
        excelWorksheet.Range("J44").Value = getTotalCasesOutput("D0A9")
        '380g
        excelWorksheet.Range("B45").Value = getTotalCasesOutput("D0S5")
        excelWorksheet.Range("F45").Value = getTotalCasesOutput("D0Y5")
        excelWorksheet.Range("J45").Value = getTotalCasesOutput("D0A5")
        'SANDWICH FLAKES
        '100g
        excelWorksheet.Range("B47").Value = getTotalCasesOutput("W8S2")
        excelWorksheet.Range("F47").Value = getTotalCasesOutput("W8Y2")
        excelWorksheet.Range("J47").Value = getTotalCasesOutput("W8A2")
        '180g
        excelWorksheet.Range("B48").Value = getTotalCasesOutput("W8S3")
        excelWorksheet.Range("F48").Value = getTotalCasesOutput("W8Y3")
        excelWorksheet.Range("J48").Value = getTotalCasesOutput("W8A3")
        'CURRY FLAKES
        '100g
        excelWorksheet.Range("B50").Value = getTotalCasesOutput("W7S2")
        excelWorksheet.Range("F50").Value = getTotalCasesOutput("W7Y2")
        excelWorksheet.Range("J50").Value = getTotalCasesOutput("W7A2")
        '180g
        excelWorksheet.Range("B51").Value = getTotalCasesOutput("W7S3")
        excelWorksheet.Range("F51").Value = getTotalCasesOutput("W7Y3")
        excelWorksheet.Range("J51").Value = getTotalCasesOutput("W7A3")

        ' turn off wait cursor
        Me.Cursor = Cursors.Default

        ' view the spread sheet
        'excelApp.Sheets.PrintPreview()
        excelApp.Visible = True

        'printCostDist()
    End Sub

    Public Function getTotalCasesOutput(ByVal pCode As String) As Double
        Dim ctr As Integer
        Dim output As Double
        With grid
            While ctr < .RowCount
                If pCode = .Item(ctr, 2) Then
                    output += .Item(ctr, 3)
                End If

                ctr += 1
            End While
        End With

        Return output
    End Function

    Public Function getTotalMTOutput(ByVal pCode As String, ByVal isCanned As Boolean) As Double
        Dim ctr As Integer
        Dim output As Double
        With grid
            While ctr < .RowCount
                If isCanned Then
                    If pCode = CStr(.Item(ctr, 2)).Substring(0, 3) Then
                        output += .Item(ctr, 6)
                    End If
                Else
                    If pCode = CStr(.Item(ctr, 2)).Substring(0, 2) Then
                        output += .Item(ctr, 6)
                    End If
                End If

                ctr += 1
            End While
        End With

        Return output / 1000
    End Function
End Class
