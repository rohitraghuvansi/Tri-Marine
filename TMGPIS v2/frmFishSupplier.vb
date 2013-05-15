Public Class frmFishSupplier
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
    Friend WithEvents cboSupplier As C1.Win.C1List.C1Combo
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishSupplier))
        Me.cboSupplier = New C1.Win.C1List.C1Combo()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.cboSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSupplier
        '
        Me.cboSupplier.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.cboSupplier.AllowColMove = False
        Me.cboSupplier.AutoCompletion = True
        Me.cboSupplier.AutoDropDown = True
        Me.cboSupplier.Caption = ""
        Me.cboSupplier.CaptionHeight = 17
        Me.cboSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSupplier.ColumnCaptionHeight = 17
        Me.cboSupplier.ColumnFooterHeight = 17
        Me.cboSupplier.ContentHeight = 18
        Me.cboSupplier.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSupplier.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSupplier.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSupplier.EditorHeight = 18
        Me.cboSupplier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.cboSupplier.ItemHeight = 20
        Me.cboSupplier.Location = New System.Drawing.Point(104, 88)
        Me.cboSupplier.MatchEntryTimeout = CType(2000, Long)
        Me.cboSupplier.MaxDropDownItems = CType(20, Short)
        Me.cboSupplier.MaxLength = 32767
        Me.cboSupplier.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.ReadOnly = True
        Me.cboSupplier.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSupplier.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSupplier.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSupplier.Size = New System.Drawing.Size(464, 24)
        Me.cboSupplier.TabIndex = 0
        Me.cboSupplier.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(412, 472)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 21
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(332, 472)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 20
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(252, 472)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 19
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Bitmap)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(172, 472)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 18
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Bitmap)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(92, 472)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 17
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.grid.Location = New System.Drawing.Point(9, 152)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(560, 312)
        Me.grid.TabIndex = 22
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
        "e"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" F" & _
        "ilterBar=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecS" & _
        "elWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>308</Heig" & _
        "ht><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=" & _
        """Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""" & _
        "FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle" & _
        " parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><Hig" & _
        "hLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inacti" & _
        "ve"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyl" & _
        "e parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""St" & _
        "yle6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 556, 308</ClientR" & _
        "ect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDB" & _
        "Grid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style paren" & _
        "t=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""H" & _
        "eading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""No" & _
        "rmal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal" & _
        """ me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Norma" & _
        "l"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""No" & _
        "rmal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertS" & _
        "plits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSe" & _
        "lWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 556, 308</ClientArea><PrintPageH" & _
        "eaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15""" & _
        " /></Blob>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Supplier Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Supplier Code"
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(104, 56)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(128, 24)
        Me.lblCode.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(578, 40)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Fish Supplier Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Table View"
        '
        'frmFishSupplier
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(578, 527)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label3, Me.Label5, Me.lblCode, Me.Label1, Me.grid, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdEdit, Me.cmd, Me.cboSupplier})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishSupplier"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishSupplier"
        CType(Me.cboSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        displayAllSupplier()
        displaySupplier()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllSupplier()
        With grid
            .DataSource = modModule.getAllFishSupplier().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 430
            .Splits(0).DisplayColumns(1).Width = 90
            '.Splits(0).DisplayColumns(2).Width = 118
        End With
    End Sub

    Public Sub displaySupplier()
        With cboSupplier
            .DataSource = modModule.getSupplier().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 440
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
                cboSupplier.ReadOnly = False
            Case 1
                cboSupplier.ReadOnly = True
        End Select
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        displaySupplier()
        cboSupplier.Text = ""

        displayAllSupplier()
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
                cboSupplier.SelectAll()
                cboSupplier.Focus()
            Case "&Save"
                If Not cboSupplier.Text.Trim = "" Then
                    If Not validateFishSupplier(cboSupplier.Text.Trim) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewFishSupplier(cboSupplier.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            displayAllSupplier()
                            displaySupplier()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Fish Supplier already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboSupplier.SelectAll()
                        cboSupplier.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboSupplier.SelectAll()
                    cboSupplier.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFishSupplier(lblCode.Text, cboSupplier.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)

                    displayAllSupplier()
                    'displaySupplier()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Public Sub saveNewFishSupplier(ByVal supplier As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_addNew_FishSupplier"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishSupplierCounter()

            Dim p2 As New SqlClient.SqlParameter()
            p2.ParameterName = "@supCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            lblCode.Text = Format(getFishSupplierCounter, "S0###")
            p2.Value = lblCode.Text

            Dim p3 As New SqlClient.SqlParameter()
            p3.ParameterName = "@supName"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = supplier

            Dim pOptr As New SqlClient.SqlParameter()
            pOptr.ParameterName = "@optr"
            pOptr.Direction = ParameterDirection.Input
            pOptr.SqlDbType = SqlDbType.VarChar
            pOptr.Value = modModule.getUsername

            Dim pEncoded As New SqlClient.SqlParameter()
            pEncoded.ParameterName = "@dateTimeEncoded"
            pEncoded.Direction = ParameterDirection.Input
            pEncoded.SqlDbType = SqlDbType.DateTime
            pEncoded.Value = getServerDateTime()

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)

            Dim daBuyer As New SqlClient.SqlDataAdapter()
            daBuyer.SelectCommand = cmd

            Dim dsBuyer As New DataSet("dbPPICIS")
            daBuyer.Fill(dsBuyer)

            daBuyer.Dispose()
            dsBuyer.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not Me.lblCode.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboSupplier.SelectAll()
                    cboSupplier.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboSupplier.SelectAll()
                    cboSupplier.Focus()
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

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        displayDataToEachDataEntry()
    End Sub

    Public Sub displayDataToEachDataEntry()
        With grid
            If .RowCount > 0 Then
                lblCode.Text = .Item(.Row, 1)
                cboSupplier.Text = .Item(.Row, 0)
            Else
                lblCode.Text = ""
                cboSupplier.Text = ""
            End If
        End With
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Fish Supplier"
        f.searchType = 1
        f.displayAllSupplier()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 1)
                cboSupplier.Text = .Item(.Row, 0)
            End If
        End With
    End Sub

End Class
