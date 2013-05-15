Public Class frmBOM
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
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboProduct As C1.Win.C1List.C1Combo
    Friend WithEvents cboDesc As C1.Win.C1List.C1Combo
    Friend WithEvents txtRevDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtFish As System.Windows.Forms.TextBox
    Friend WithEvents txtUpC As System.Windows.Forms.TextBox
    Friend WithEvents txtCan As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtLabels As System.Windows.Forms.TextBox
    Friend WithEvents txtCartons As System.Windows.Forms.TextBox
    Friend WithEvents txtOil As System.Windows.Forms.TextBox
    Friend WithEvents txtBroth As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtCF As System.Windows.Forms.TextBox
    Friend WithEvents txtMSG As System.Windows.Forms.TextBox
    Friend WithEvents txtCurry As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSalt As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtFW As System.Windows.Forms.TextBox
    Friend WithEvents txtNW As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBOM))
        Me.cboProduct = New C1.Win.C1List.C1Combo
        Me.cboDesc = New C1.Win.C1List.C1Combo
        Me.txtRevDate = New C1.Win.C1Input.C1DateEdit
        Me.txtFish = New System.Windows.Forms.TextBox
        Me.txtUpC = New System.Windows.Forms.TextBox
        Me.txtCan = New System.Windows.Forms.TextBox
        Me.txtEnd = New System.Windows.Forms.TextBox
        Me.txtLabels = New System.Windows.Forms.TextBox
        Me.txtCartons = New System.Windows.Forms.TextBox
        Me.txtOil = New System.Windows.Forms.TextBox
        Me.txtBroth = New System.Windows.Forms.TextBox
        Me.txtMSG = New System.Windows.Forms.TextBox
        Me.txtCP = New System.Windows.Forms.TextBox
        Me.txtCF = New System.Windows.Forms.TextBox
        Me.txtCurry = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmd = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtSalt = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtFW = New System.Windows.Forms.TextBox
        Me.txtNW = New System.Windows.Forms.TextBox
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRevDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProduct
        '
        Me.cboProduct.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboProduct.AllowColMove = False
        Me.cboProduct.AutoCompletion = True
        Me.cboProduct.AutoDropDown = True
        Me.cboProduct.Caption = ""
        Me.cboProduct.CaptionHeight = 17
        Me.cboProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProduct.ColumnCaptionHeight = 17
        Me.cboProduct.ColumnFooterHeight = 17
        Me.cboProduct.ContentHeight = 18
        Me.cboProduct.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboProduct.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboProduct.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProduct.EditorHeight = 18
        Me.cboProduct.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.cboProduct.ItemHeight = 20
        Me.cboProduct.Location = New System.Drawing.Point(112, 53)
        Me.cboProduct.MatchEntryTimeout = CType(2000, Long)
        Me.cboProduct.MaxDropDownItems = CType(10, Short)
        Me.cboProduct.MaxLength = 32767
        Me.cboProduct.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboProduct.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboProduct.Size = New System.Drawing.Size(200, 24)
        Me.cboProduct.TabIndex = 0
        Me.cboProduct.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}RecordSelector{Alig" & _
        "nImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;For" & _
        "eColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}Style9{AlignHorz:" & _
        "Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColMove=""False"" Al" & _
        "lowColSelect=""False"" Name=""Split[0,0]"" CaptionHeight=""17"" ColumnCaptionHeight=""1" & _
        "7"" ColumnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Cl" & _
        "ientRect>0, 0, 116, 156</ClientRect><Height>156</Height><VScrollBar><Width>16</W" & _
        "idth></VScrollBar><HScrollBar><Height>16</Height></HScrollBar><CaptionStyle pare" & _
        "nt=""Style2"" me=""Style9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterSt" & _
        "yle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><Hea" & _
        "dingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow" & _
        """ me=""Style6"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle pare" & _
        "nt=""OddRow"" me=""Style8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style" & _
        "10"" /><SelectedStyle parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""" & _
        "Style1"" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent="""" me=" & _
        """Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foo" & _
        "ter"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inacti" & _
        "ve"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Gro" & _
        "up"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>" & _
        "Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>"
        '
        'cboDesc
        '
        Me.cboDesc.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboDesc.AllowColMove = False
        Me.cboDesc.AutoCompletion = True
        Me.cboDesc.AutoDropDown = True
        Me.cboDesc.Caption = ""
        Me.cboDesc.CaptionHeight = 17
        Me.cboDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDesc.ColumnCaptionHeight = 17
        Me.cboDesc.ColumnFooterHeight = 17
        Me.cboDesc.ContentHeight = 18
        Me.cboDesc.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboDesc.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboDesc.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDesc.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDesc.EditorHeight = 18
        Me.cboDesc.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.cboDesc.ItemHeight = 20
        Me.cboDesc.Location = New System.Drawing.Point(112, 86)
        Me.cboDesc.MatchEntryTimeout = CType(2000, Long)
        Me.cboDesc.MaxDropDownItems = CType(10, Short)
        Me.cboDesc.MaxLength = 32767
        Me.cboDesc.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboDesc.Name = "cboDesc"
        Me.cboDesc.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDesc.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboDesc.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDesc.Size = New System.Drawing.Size(480, 24)
        Me.cboDesc.TabIndex = 1
        Me.cboDesc.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}RecordSelector{Alig" & _
        "nImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;For" & _
        "eColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}Style9{AlignHorz:" & _
        "Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColMove=""False"" Al" & _
        "lowColSelect=""False"" Name=""Split[0,0]"" CaptionHeight=""17"" ColumnCaptionHeight=""1" & _
        "7"" ColumnFooterHeight=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Cl" & _
        "ientRect>0, 0, 116, 156</ClientRect><Height>156</Height><VScrollBar><Width>16</W" & _
        "idth></VScrollBar><HScrollBar><Height>16</Height></HScrollBar><CaptionStyle pare" & _
        "nt=""Style2"" me=""Style9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterSt" & _
        "yle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><Hea" & _
        "dingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow" & _
        """ me=""Style6"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle pare" & _
        "nt=""OddRow"" me=""Style8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style" & _
        "10"" /><SelectedStyle parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""" & _
        "Style1"" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent="""" me=" & _
        """Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foo" & _
        "ter"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inacti" & _
        "ve"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Gro" & _
        "up"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>" & _
        "Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>"
        '
        'txtRevDate
        '
        Me.txtRevDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtRevDate.Location = New System.Drawing.Point(112, 119)
        Me.txtRevDate.Name = "txtRevDate"
        Me.txtRevDate.TabIndex = 2
        Me.txtRevDate.Tag = Nothing
        Me.txtRevDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtFish
        '
        Me.txtFish.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFish.Location = New System.Drawing.Point(112, 184)
        Me.txtFish.Name = "txtFish"
        Me.txtFish.TabIndex = 3
        Me.txtFish.Text = "0"
        Me.txtFish.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUpC
        '
        Me.txtUpC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpC.Location = New System.Drawing.Point(112, 214)
        Me.txtUpC.Name = "txtUpC"
        Me.txtUpC.TabIndex = 4
        Me.txtUpC.Text = "0"
        Me.txtUpC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCan
        '
        Me.txtCan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCan.Location = New System.Drawing.Point(112, 246)
        Me.txtCan.Name = "txtCan"
        Me.txtCan.TabIndex = 5
        Me.txtCan.Text = "0"
        Me.txtCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEnd
        '
        Me.txtEnd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(112, 278)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.TabIndex = 6
        Me.txtEnd.Text = "0"
        Me.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLabels
        '
        Me.txtLabels.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabels.Location = New System.Drawing.Point(112, 310)
        Me.txtLabels.Name = "txtLabels"
        Me.txtLabels.TabIndex = 7
        Me.txtLabels.Text = "0"
        Me.txtLabels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCartons
        '
        Me.txtCartons.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCartons.Location = New System.Drawing.Point(112, 342)
        Me.txtCartons.Name = "txtCartons"
        Me.txtCartons.TabIndex = 8
        Me.txtCartons.Text = "0"
        Me.txtCartons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOil
        '
        Me.txtOil.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOil.Location = New System.Drawing.Point(360, 184)
        Me.txtOil.Name = "txtOil"
        Me.txtOil.TabIndex = 9
        Me.txtOil.Text = "0"
        Me.txtOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBroth
        '
        Me.txtBroth.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBroth.Location = New System.Drawing.Point(360, 214)
        Me.txtBroth.Name = "txtBroth"
        Me.txtBroth.TabIndex = 10
        Me.txtBroth.Text = "0"
        Me.txtBroth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMSG
        '
        Me.txtMSG.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMSG.Location = New System.Drawing.Point(360, 246)
        Me.txtMSG.Name = "txtMSG"
        Me.txtMSG.TabIndex = 11
        Me.txtMSG.Text = "0"
        Me.txtMSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCP
        '
        Me.txtCP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(360, 278)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.TabIndex = 12
        Me.txtCP.Text = "0"
        Me.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCF
        '
        Me.txtCF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCF.Location = New System.Drawing.Point(360, 310)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.TabIndex = 13
        Me.txtCF.Text = "0"
        Me.txtCF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCurry
        '
        Me.txtCurry.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurry.Location = New System.Drawing.Point(360, 342)
        Me.txtCurry.Name = "txtCurry"
        Me.txtCurry.TabIndex = 14
        Me.txtCurry.Text = "0"
        Me.txtCurry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(476, 416)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 22
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(396, 416)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 21
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(316, 416)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 20
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(236, 416)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 19
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(156, 416)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 18
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Product Code"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(706, 40)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Product Bill of Materials"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Fish"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Revision Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Unit per Case"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 19)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "End"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 19)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Can"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 19)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Carton"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 19)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Labels"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(272, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 19)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Curry"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(272, 312)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 19)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Chili Fruit"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(272, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 19)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Chili Powder"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(272, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 19)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "MSG"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(272, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 19)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Broth"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(272, 186)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 19)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Oil"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(691, 232)
        Me.Label17.TabIndex = 55
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 19)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Materials Details"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(272, 376)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 19)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Salt"
        '
        'txtSalt
        '
        Me.txtSalt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalt.Location = New System.Drawing.Point(360, 374)
        Me.txtSalt.Name = "txtSalt"
        Me.txtSalt.TabIndex = 15
        Me.txtSalt.Text = "0"
        Me.txtSalt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(520, 216)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 19)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Fill Weight"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(520, 186)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 19)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "Net Weight"
        '
        'txtFW
        '
        Me.txtFW.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFW.Location = New System.Drawing.Point(592, 214)
        Me.txtFW.Name = "txtFW"
        Me.txtFW.TabIndex = 17
        Me.txtFW.Text = "0"
        Me.txtFW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNW
        '
        Me.txtNW.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNW.Location = New System.Drawing.Point(592, 184)
        Me.txtNW.Name = "txtNW"
        Me.txtNW.TabIndex = 16
        Me.txtNW.Text = "0"
        Me.txtNW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmBOM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(706, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtFW)
        Me.Controls.Add(Me.txtNW)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtSalt)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.txtCurry)
        Me.Controls.Add(Me.txtCF)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtMSG)
        Me.Controls.Add(Me.txtBroth)
        Me.Controls.Add(Me.txtOil)
        Me.Controls.Add(Me.txtCartons)
        Me.Controls.Add(Me.txtLabels)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtCan)
        Me.Controls.Add(Me.txtUpC)
        Me.Controls.Add(Me.txtFish)
        Me.Controls.Add(Me.txtRevDate)
        Me.Controls.Add(Me.cboDesc)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.Label17)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBOM"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "0"
        CType(Me.cboProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRevDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmBOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtRevDate.Value = getServerDateTime()
        enableDataEntry(False)

        displayProduct()
        displayProductDesc()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayProduct()
        With cboProduct
            .DataSource = modModule.getProductCode().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 175
        End With
    End Sub

    Public Sub displayProductDesc()
        With cboDesc
            .DataSource = modModule.getProductDesc().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 458
        End With
    End Sub

    Private Sub txtFish_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFish.TextChanged
        If Not IsNumeric(txtFish.Text) Or txtFish.Text = "" Then
            txtFish.Text = "0"
            txtFish.SelectAll()
            txtFish.Focus()
        End If
    End Sub

    Private Sub txtUpC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUpC.TextChanged
        If Not IsNumeric(txtUpC.Text) Or txtUpC.Text = "" Then
            txtUpC.Text = "0"
            txtUpC.SelectAll()
            txtUpC.Focus()
        End If
    End Sub

    Private Sub txtCan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCan.TextChanged
        If Not IsNumeric(txtCan.Text) Or txtCan.Text = "" Then
            txtCan.Text = "0"
            txtCan.SelectAll()
            txtCan.Focus()
        End If
    End Sub

    Private Sub txtEnd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnd.TextChanged
        If Not IsNumeric(txtEnd.Text) Or txtEnd.Text = "" Then
            txtEnd.Text = "0"
            txtEnd.SelectAll()
            txtEnd.Focus()
        End If
    End Sub

    Private Sub txtLabels_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLabels.TextChanged
        If Not IsNumeric(txtLabels.Text) Or txtLabels.Text = "" Then
            txtLabels.Text = "0"
            txtLabels.SelectAll()
            txtLabels.Focus()
        End If
    End Sub

    Private Sub txtCartons_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCartons.TextChanged
        If Not IsNumeric(txtCartons.Text) Or txtCartons.Text = "" Then
            txtCartons.Text = "0"
            txtCartons.SelectAll()
            txtCartons.Focus()
        End If
    End Sub

    Private Sub txtOil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOil.TextChanged
        If Not IsNumeric(txtOil.Text) Or txtOil.Text = "" Then
            txtOil.Text = "0"
            txtOil.SelectAll()
            txtOil.Focus()
        End If
    End Sub

    Private Sub txtBroth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBroth.TextChanged
        If Not IsNumeric(txtBroth.Text) Or txtBroth.Text = "" Then
            txtBroth.Text = "0"
            txtBroth.SelectAll()
            txtBroth.Focus()
        End If
    End Sub

    Private Sub txtMSG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMSG.TextChanged
        If Not IsNumeric(txtMSG.Text) Or txtMSG.Text = "" Then
            txtMSG.Text = "0"
            txtMSG.SelectAll()
            txtMSG.Focus()
        End If
    End Sub

    Private Sub txtCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCP.TextChanged
        If Not IsNumeric(txtCP.Text) Or txtCP.Text = "" Then
            txtCP.Text = "0"
            txtCP.SelectAll()
            txtCP.Focus()
        End If
    End Sub

    Private Sub txtCF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCF.TextChanged
        If Not IsNumeric(txtCF.Text) Or txtCF.Text = "" Then
            txtCF.Text = "0"
            txtCF.SelectAll()
            txtCF.Focus()
        End If
    End Sub

    Private Sub txtCurry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurry.TextChanged
        If Not IsNumeric(txtCurry.Text) Or txtCurry.Text = "" Then
            txtCurry.Text = "0"
            txtCurry.SelectAll()
            txtCurry.Focus()
        End If
    End Sub

    Private Sub cboProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduct.TextChanged
        If CStr(getProductCategory(cboProduct.Text)).StartsWith("Frozen") Then
            Label8.Text = "Bags"
            txtUpC.ReadOnly = True
            txtEnd.ReadOnly = True
            txtLabels.ReadOnly = True
            txtOil.ReadOnly = True
            txtBroth.ReadOnly = True
            txtMSG.ReadOnly = True
            txtCP.ReadOnly = True
            txtCF.ReadOnly = True
            txtCurry.ReadOnly = True
            txtSalt.ReadOnly = False
            txtNW.ReadOnly = True
            txtFW.ReadOnly = True
        Else
            Label8.Text = "Can"
            txtUpC.ReadOnly = False
            txtEnd.ReadOnly = False
            txtLabels.ReadOnly = False
            txtOil.ReadOnly = False
            txtBroth.ReadOnly = False
            txtMSG.ReadOnly = False
            txtCP.ReadOnly = False
            txtCF.ReadOnly = False
            txtCurry.ReadOnly = False
            txtSalt.ReadOnly = False
            txtNW.ReadOnly = False
            txtFW.ReadOnly = False
        End If

        cboDesc.Text = getProductDesc(cboProduct.Text)
        getBOMDetails(cboProduct.Text, txtRevDate.Text)
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

    Public Sub enableDataEntry(ByVal yes As Boolean)
        'used to disable and enable data entry controls
        Select Case yes
            Case True
                cboProduct.ReadOnly = False
                cboDesc.ReadOnly = False
                txtRevDate.ReadOnly = False
                txtFish.ReadOnly = False
                txtUpC.ReadOnly = False
                txtCan.ReadOnly = False
                txtEnd.ReadOnly = False
                txtLabels.ReadOnly = False
                txtCartons.ReadOnly = False
                txtOil.ReadOnly = False
                txtBroth.ReadOnly = False
                txtMSG.ReadOnly = False
                txtCP.ReadOnly = False
                txtCF.ReadOnly = False
                txtCurry.ReadOnly = False
                txtSalt.ReadOnly = False
                txtNW.ReadOnly = False
                txtFW.ReadOnly = False
            Case False
                cboProduct.ReadOnly = True
                cboDesc.ReadOnly = True
                txtRevDate.ReadOnly = True
                txtFish.ReadOnly = True
                txtUpC.ReadOnly = True
                txtCan.ReadOnly = True
                txtEnd.ReadOnly = True
                txtLabels.ReadOnly = True
                txtCartons.ReadOnly = True
                txtOil.ReadOnly = True
                txtBroth.ReadOnly = True
                txtMSG.ReadOnly = True
                txtCP.ReadOnly = True
                txtCF.ReadOnly = True
                txtCurry.ReadOnly = True
                txtSalt.ReadOnly = True
                txtNW.ReadOnly = True
                txtFW.ReadOnly = True
        End Select
    End Sub

    Public Sub addNewRecord()
        cboProduct.Text = ""
        displayProduct()
        cboDesc.Text = ""
        displayProductDesc()
        txtRevDate.Value = getServerDateTime()
        txtFish.Text = "0"
        txtUpC.Text = "0"
        txtCan.Text = "0"
        txtEnd.Text = "0"
        txtLabels.Text = "0"
        txtCartons.Text = "0"
        txtOil.Text = "0"
        txtBroth.Text = "0"
        txtMSG.Text = "0"
        txtCP.Text = "0"
        txtCF.Text = "0"
        txtCurry.Text = "0"
        txtSalt.Text = "0"
        txtNW.Text = "0"
        txtFW.Text = "0"
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                buttons(0)
                enableDataEntry(True)
                addNewRecord()
                cboProduct.SelectAll()
                cboProduct.Focus()
            Case "&Save"
                If Not cboProduct.Text.Trim = "" And Not cboDesc.Text.Trim = "" Then
                    If Not validateBOM(cboProduct.Text, cboDesc.Text, txtRevDate.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewBOM(cboProduct.Text, cboDesc.Text, txtFish.Text, txtUpC.Text, _
                                txtEnd.Text, txtOil.Text, txtBroth.Text, txtCF.Text, txtCP.Text, _
                                txtCurry.Text, txtMSG.Text, txtCan.Text, txtLabels.Text, _
                                txtCartons.Text, txtRevDate.Text, txtSalt.Text, txtNW.Text, txtFW.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            enableDataEntry(False)

                            'displayAllFishBins()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("BOM already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboProduct.SelectAll()
                        cboProduct.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboProduct.SelectAll()
                    cboProduct.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateBOM(cboProduct.Text, cboDesc.Text, txtFish.Text, txtUpC.Text, _
                               txtEnd.Text, txtOil.Text, txtBroth.Text, txtCF.Text, txtCP.Text, _
                               txtCurry.Text, txtMSG.Text, txtCan.Text, txtLabels.Text, _
                               txtCartons.Text, txtRevDate.Text, txtSalt.Text, txtNW.Text, txtFW.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    enableDataEntry(False)

                    'displayAllFishBins()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not Me.cboProduct.Text = "" And Not cboDesc.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    enableDataEntry(True)
                    cboProduct.ReadOnly = True
                    cboDesc.ReadOnly = True
                    txtRevDate.ReadOnly = True
                    txtFish.SelectAll()
                    txtFish.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                enableDataEntry(False)
                cmdEdit.Focus()
        End Select
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Bill of Materials"
        f.searchType = 1
        f.displayAllBOM()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                cboProduct.Text = .Item(.Row, 0)
                cboDesc.Text = .Item(.Row, 1)
                txtRevDate.Value = .Item(.Row, 2)
                txtFish.Text = .Item(.Row, 3)
                txtUpC.Text = .Item(.Row, 4)
                txtCan.Text = .Item(.Row, 5)
                txtEnd.Text = .Item(.Row, 6)
                txtLabels.Text = .Item(.Row, 7)
                txtCartons.Text = .Item(.Row, 8)
                txtOil.Text = .Item(.Row, 9)
                txtBroth.Text = .Item(.Row, 10)
                txtMSG.Text = .Item(.Row, 11)
                txtCP.Text = .Item(.Row, 12)
                txtCF.Text = .Item(.Row, 13)
                txtCurry.Text = .Item(.Row, 14)
                txtSalt.Text = .Item(.Row, 15)
                txtNW.Text = .Item(.Row, 16)
                txtFW.Text = .Item(.Row, 17)
                enableDataEntry(False)
            End If
        End With
    End Sub

    Public Sub getBOMDetails(ByVal pCode As String, ByVal revDate As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_get_BOM_Details"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@pCode"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = pCode

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@revisionDate"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.DateTime
            p2.Value = Format(CDate(revDate), getTimeFormat())

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            Dim returnValue As String
            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    txtFish.Text = dr.GetDouble(3)
                    txtUpC.Text = dr.GetDouble(4)
                    txtCan.Text = dr.GetDouble(5)
                    txtEnd.Text = dr.GetDouble(6)
                    txtLabels.Text = dr.GetDouble(7)
                    txtCartons.Text = dr.GetDouble(8)
                    txtOil.Text = dr.GetDouble(9)
                    txtBroth.Text = dr.GetDouble(10)
                    txtMSG.Text = dr.GetDouble(11)
                    txtCP.Text = dr.GetDouble(12)
                    txtCF.Text = dr.GetDouble(13)
                    txtCurry.Text = dr.GetDouble(14)
                    txtSalt.Text = dr.GetDouble(15)
                Else
                    txtFish.Text = "0"
                    txtUpC.Text = "0"
                    txtCan.Text = "0"
                    txtEnd.Text = "0"
                    txtLabels.Text = "0"
                    txtCartons.Text = "0"
                    txtOil.Text = "0"
                    txtBroth.Text = "0"
                    txtMSG.Text = "0"
                    txtCP.Text = "0"
                    txtCF.Text = "0"
                    txtCurry.Text = "0"
                    txtSalt.Text = "0"
                End If
            Else
                txtFish.Text = "0"
                txtUpC.Text = "0"
                txtCan.Text = "0"
                txtEnd.Text = "0"
                txtLabels.Text = "0"
                txtCartons.Text = "0"
                txtOil.Text = "0"
                txtBroth.Text = "0"
                txtMSG.Text = "0"
                txtCP.Text = "0"
                txtCF.Text = "0"
                txtCurry.Text = "0"
                txtSalt.Text = "0"
            End If

            dr.Close()
            c.Close()

        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub txtRevDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRevDate.ValueChanged
        getBOMDetails(cboProduct.Text, txtRevDate.Text)
    End Sub

    Private Sub txtNW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNW.TextChanged
        If Not IsNumeric(txtNW.Text) Or txtNW.Text = "" Then
            txtNW.Text = "0"
            txtNW.SelectAll()
            txtNW.Focus()
        End If
    End Sub

    Private Sub txtFW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFW.TextChanged
        If Not IsNumeric(txtFW.Text) Or txtFW.Text = "" Then
            txtFW.Text = "0"
            txtFW.SelectAll()
            txtFW.Focus()
        End If
    End Sub
End Class
