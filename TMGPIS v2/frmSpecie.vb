Public Class frmSpecie
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
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblCode As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSpecie))
        Me.cboSpecie = New C1.Win.C1List.C1Combo()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSpecie
        '
        Me.cboSpecie.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSpecie.AllowColMove = False
        Me.cboSpecie.AutoCompletion = True
        Me.cboSpecie.AutoDropDown = True
        Me.cboSpecie.Caption = ""
        Me.cboSpecie.CaptionHeight = 17
        Me.cboSpecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSpecie.ColumnCaptionHeight = 17
        Me.cboSpecie.ColumnFooterHeight = 17
        Me.cboSpecie.ContentHeight = 18
        Me.cboSpecie.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSpecie.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSpecie.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSpecie.EditorHeight = 18
        Me.cboSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboSpecie.ItemHeight = 20
        Me.cboSpecie.Location = New System.Drawing.Point(104, 56)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(20, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.ReadOnly = True
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.Size = New System.Drawing.Size(336, 24)
        Me.cboSpecie.TabIndex = 0
        Me.cboSpecie.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Tahoma, 9" & _
        ".75pt, style=Bold;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Sty" & _
        "le9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;" & _
        "AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Contr" & _
        "ol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Lis" & _
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
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(104, 85)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(152, 23)
        Me.txtWeight.TabIndex = 1
        Me.txtWeight.Text = "0"
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTo
        '
        Me.lblTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(288, 120)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(152, 24)
        Me.lblTo.TabIndex = 23
        Me.lblTo.Text = "0"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFrom
        '
        Me.lblFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(104, 120)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(152, 24)
        Me.lblFrom.TabIndex = 22
        Me.lblFrom.Text = "0"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(346, 464)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 28
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(266, 464)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 27
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(186, 464)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 26
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Bitmap)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(106, 464)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 25
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Bitmap)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(26, 464)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 24
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 40)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Fish Specie Information"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.grid.Location = New System.Drawing.Point(5, 176)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(436, 278)
        Me.grid.TabIndex = 30
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><DataCols><C1DataColumn Caption=""Fish Name"" DataField=" & _
        """""><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Caption=""Weight"" Data" & _
        "Field=""""><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Caption=""Bracke" & _
        "t From"" DataField=""""><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Cap" & _
        "tion=""Bracket To"" DataField=""""><ValueItems /><GroupInfo /></C1DataColumn><C1Data" & _
        "Column Caption=""Unit"" DataField=""""><ValueItems /><GroupInfo /></C1DataColumn></D" & _
        "ataCols><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrapper""><Data>Caption{A" & _
        "lignHorz:Center;}Style27{}Normal{Font:Tahoma, 9.75pt;}Style25{}Selected{ForeColo" & _
        "r:HighlightText;BackColor:Highlight;}Editor{}Style18{}Style19{}Style14{}Style15{" & _
        "}Style16{AlignHorz:Near;}Style17{AlignHorz:Near;}Style10{AlignHorz:Near;}Style11" & _
        "{}OddRow{}Style13{}Style12{}Style4{}Style29{AlignHorz:Near;}Style28{AlignHorz:Ne" & _
        "ar;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style26{}RecordSel" & _
        "ector{AlignImage:Center;}Footer{}Style23{AlignHorz:Near;}Style22{AlignHorz:Near;" & _
        "}Style21{}Style20{}Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert" & _
        ":Center;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}EvenR" & _
        "ow{BackColor:Aqua;}Style6{}Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, " & _
        "1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style3{}Style24{}Style7{}Style8" & _
        "{}Style1{}Style5{}Style41{AlignHorz:Near;}Style40{AlignHorz:Near;}Style43{}Filte" & _
        "rBar{}Style45{}Style44{}Style42{}Style9{}Style38{}Style39{}Style36{}Style37{}Sty" & _
        "le34{AlignHorz:Near;}Style35{AlignHorz:Near;}Style32{}Style33{}Style30{}Style31{" & _
        "}Style2{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""Fa" & _
        "lse"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17""" & _
        " FilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRe" & _
        "cSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>274</He" & _
        "ight><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" m" & _
        "e=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent" & _
        "=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSty" & _
        "le parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><H" & _
        "ighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inac" & _
        "tive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorSt" & _
        "yle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""" & _
        "Style6"" /><Style parent=""Normal"" me=""Style1"" /><internalCols><C1DisplayColumn><H" & _
        "eadingStyle parent=""Style2"" me=""Style16"" /><Style parent=""Style1"" me=""Style17"" /" & _
        "><FooterStyle parent=""Style3"" me=""Style18"" /><EditorStyle parent=""Style5"" me=""St" & _
        "yle19"" /><GroupHeaderStyle parent=""Style1"" me=""Style21"" /><GroupFooterStyle pare" & _
        "nt=""Style1"" me=""Style20"" /><Visible>True</Visible><ColumnDivider>DarkGray,Single" & _
        "</ColumnDivider><Width>109</Width><Height>15</Height><DCIdx>0</DCIdx></C1Display" & _
        "Column><C1DisplayColumn><HeadingStyle parent=""Style2"" me=""Style22"" /><Style pare" & _
        "nt=""Style1"" me=""Style23"" /><FooterStyle parent=""Style3"" me=""Style24"" /><EditorSt" & _
        "yle parent=""Style5"" me=""Style25"" /><GroupHeaderStyle parent=""Style1"" me=""Style27" & _
        """ /><GroupFooterStyle parent=""Style1"" me=""Style26"" /><Visible>True</Visible><Col" & _
        "umnDivider>DarkGray,Single</ColumnDivider><Width>62</Width><Height>15</Height><D" & _
        "CIdx>1</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=""Style2"" m" & _
        "e=""Style28"" /><Style parent=""Style1"" me=""Style29"" /><FooterStyle parent=""Style3""" & _
        " me=""Style30"" /><EditorStyle parent=""Style5"" me=""Style31"" /><GroupHeaderStyle pa" & _
        "rent=""Style1"" me=""Style33"" /><GroupFooterStyle parent=""Style1"" me=""Style32"" /><V" & _
        "isible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Width>82</Wi" & _
        "dth><Height>15</Height><DCIdx>2</DCIdx></C1DisplayColumn><C1DisplayColumn><Headi" & _
        "ngStyle parent=""Style2"" me=""Style34"" /><Style parent=""Style1"" me=""Style35"" /><Fo" & _
        "oterStyle parent=""Style3"" me=""Style36"" /><EditorStyle parent=""Style5"" me=""Style3" & _
        "7"" /><GroupHeaderStyle parent=""Style1"" me=""Style39"" /><GroupFooterStyle parent=""" & _
        "Style1"" me=""Style38"" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</Co" & _
        "lumnDivider><Width>69</Width><Height>15</Height><DCIdx>3</DCIdx></C1DisplayColum" & _
        "n><C1DisplayColumn><HeadingStyle parent=""Style2"" me=""Style40"" /><Style parent=""S" & _
        "tyle1"" me=""Style41"" /><FooterStyle parent=""Style3"" me=""Style42"" /><EditorStyle p" & _
        "arent=""Style5"" me=""Style43"" /><GroupHeaderStyle parent=""Style1"" me=""Style45"" /><" & _
        "GroupFooterStyle parent=""Style1"" me=""Style44"" /><Visible>True</Visible><ColumnDi" & _
        "vider>DarkGray,Single</ColumnDivider><Width>72</Width><Height>15</Height><DCIdx>" & _
        "4</DCIdx></C1DisplayColumn></internalCols><ClientRect>0, 0, 432, 274</ClientRect" & _
        "><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGri" & _
        "d.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""" & _
        "Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Head" & _
        "ing"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Norma" & _
        "l"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" m" & _
        "e=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" " & _
        "me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Norma" & _
        "l"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSpli" & _
        "ts>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecS" & _
        "elWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 432, 274</ClientArea><PrintPage" & _
        "HeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15" & _
        """ /></Blob>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Specie Code"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fish Specie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Weight"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Weight Bracket"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Fish Table View"
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(104, 21)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(152, 24)
        Me.lblCode.TabIndex = 36
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCode.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "to"
        '
        'frmSpecie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(446, 519)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCode, Me.Label8, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.grid, Me.Label1, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdEdit, Me.cmd, Me.lblTo, Me.lblFrom, Me.txtWeight, Me.cboSpecie, Me.Label2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSpecie"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSpecie"
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSpecie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        displayAllFishSpecie()
        displayFishSpecie()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllFishSpecie()
        With grid
            .DataSource = modModule.getAllFishSpecie().Tables(0)
            '.Columns(2).NumberFormat = "##0.#0"
            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 50
            .Splits(0).DisplayColumns(2).Width = 70
            .Splits(0).DisplayColumns(3).Width = 70
            .Splits(0).DisplayColumns(4).Width = 40
            .Splits(0).DisplayColumns(5).Width = 80
        End With
    End Sub

    Public Sub displayFishSpecie()
        With cboSpecie
            .DataSource = modModule.getFishSpecie().Tables(0)
            '.Columns(2).NumberFormat = "##0.#0"
            .Splits(0).DisplayColumns(0).Width = 315
            '.Splits(0).DisplayColumns(1).Width = 50
            '.Splits(0).DisplayColumns(2).Width = 70
            '.Splits(0).DisplayColumns(3).Width = 70
            '.Splits(0).DisplayColumns(4).Width = 40
            '.Splits(0).DisplayColumns(5).Width = 80
        End With
    End Sub

    Public Sub buttons(ByVal i As Integer)
        Select Case i
            Case 0
                Me.cmdPrint.Enabled = False
                Me.cmdFind.Enabled = False
                Me.cmdClose.Enabled = False
            Case 1
                Me.cmdPrint.Enabled = True
                Me.cmdFind.Enabled = True
                Me.cmdClose.Enabled = True
        End Select
    End Sub

    Public Sub dataEntry(ByVal s As Int16)
        'used to disable and enable data entry controls
        Select Case s
            Case 0
                cboSpecie.ReadOnly = False
                txtWeight.ReadOnly = False
            Case 1
                cboSpecie.ReadOnly = True
                txtWeight.ReadOnly = True
        End Select
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        displayFishSpecie()
        cboSpecie.Text = ""
        txtWeight.Text = "0"
        displayAllFishSpecie()
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                buttons(0)
                dataEntry(0)
                addNewRecord()
                cboSpecie.SelectAll()
                cboSpecie.Focus()
            Case "&Save"
                If Not cboSpecie.Text.Trim = "" And Not txtWeight.Text.Trim = "0" Then
                    If Not validateFishSpecie(cboSpecie.Text, txtWeight.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            lblCode.Text = cboSpecie.Text.Substring(0, 1) & txtWeight.Text

                            saveNewFishSpecie(lblCode.Text, cboSpecie.Text, txtWeight.Text, lblFrom.Text, lblTo.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            displayAllFishSpecie()
                            displayFishSpecie()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Fish specie already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboSpecie.SelectAll()
                        cboSpecie.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboSpecie.SelectAll()
                    cboSpecie.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFishSpecie(lblCode.Text, cboSpecie.Text, txtWeight.Text, lblFrom.Text, lblTo.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)

                    displayAllFishSpecie()
                    'displayFishSpecie()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not Me.lblCode.Text = "" And Not cboSpecie.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboSpecie.SelectAll()
                    cboSpecie.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboSpecie.SelectAll()
                    cboSpecie.Focus()
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                dataEntry(1)
                cmdEdit.Focus()
        End Select
    End Sub

    Public Sub displayFishSizeBracket(ByVal weight As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_getFishSizeBracket"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@weight"
            p1.SqlDbType = SqlDbType.Float
            p1.Direction = ParameterDirection.Input
            p1.Value = weight

            cmd.Parameters.Add(p1)

            Dim drCode As SqlClient.SqlDataReader
            drCode = cmd.ExecuteReader

            lblFrom.Text = "0"
            lblTo.Text = "0"
            If drCode.Read Then
                If Not drCode(0) Is DBNull.Value Then
                    lblFrom.Text = drCode.GetDouble(0)
                    lblTo.Text = drCode.GetDouble(1)
                End If
            End If

            drCode.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged
        If Not IsNumeric(txtWeight.Text) Or txtWeight.Text.Trim = "" Then
            txtWeight.Text = "0"
            txtWeight.SelectAll()
            txtWeight.Focus()
        End If

        displayFishSizeBracket(txtWeight.Text)
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Fish Specie"
        f.searchType = 1
        f.displayAllFishSpecie()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 5)
                cboSpecie.Text = .Item(.Row, 0)
                txtWeight.Text = .Item(.Row, 1)
            End If
        End With
    End Sub

    Private Sub cboSpecie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSpecie.TextChanged

    End Sub
End Class
