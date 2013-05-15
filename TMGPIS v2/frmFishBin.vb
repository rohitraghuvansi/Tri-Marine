Public Class frmFishBin
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
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtBinNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTare As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFishBin))
        Me.txtBinNo = New System.Windows.Forms.TextBox()
        Me.txtTare = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBinNo
        '
        Me.txtBinNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBinNo.Location = New System.Drawing.Point(96, 80)
        Me.txtBinNo.Name = "txtBinNo"
        Me.txtBinNo.ReadOnly = True
        Me.txtBinNo.Size = New System.Drawing.Size(112, 23)
        Me.txtBinNo.TabIndex = 0
        Me.txtBinNo.Text = ""
        '
        'txtTare
        '
        Me.txtTare.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTare.Location = New System.Drawing.Point(96, 112)
        Me.txtTare.Name = "txtTare"
        Me.txtTare.ReadOnly = True
        Me.txtTare.Size = New System.Drawing.Size(112, 23)
        Me.txtTare.TabIndex = 1
        Me.txtTare.Text = "0"
        Me.txtTare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fish Bins Information"
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(96, 48)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(112, 24)
        Me.lblCode.TabIndex = 11
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Bitmap)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(332, 472)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 16
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Bitmap)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(252, 472)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 15
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Bitmap)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(172, 472)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 14
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Bitmap)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(92, 472)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 13
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Bitmap)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(12, 472)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 12
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tare Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Bin Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Bin Code"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.grid.Location = New System.Drawing.Point(5, 168)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(408, 296)
        Me.grid.TabIndex = 20
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = "<?xml version=""1.0""?><Blob><DataCols><C1DataColumn Caption=""Bin Code"" DataField=""" & _
        """><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Caption=""Bin Number"" D" & _
        "ataField=""""><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Caption=""Tar" & _
        "e Weight"" DataField=""""><ValueItems /><GroupInfo /></C1DataColumn></DataCols><Sty" & _
        "les type=""C1.Win.C1TrueDBGrid.Design.ContextWrapper""><Data>Caption{AlignHorz:Cen" & _
        "ter;}Style27{}Normal{Font:Tahoma, 9.75pt, style=Bold;}Style25{}Selected{ForeColo" & _
        "r:HighlightText;BackColor:Highlight;}Editor{}Style18{}Style19{}Style14{}Style15{" & _
        "}Style16{AlignHorz:Near;}Style17{AlignHorz:Near;}Style10{AlignHorz:Near;}Style11" & _
        "{}OddRow{}Style13{}Style12{}Style32{}Style33{}Style31{}Footer{}Style29{AlignHorz" & _
        ":Near;}Style28{AlignHorz:Near;}HighlightRow{ForeColor:HighlightText;BackColor:Hi" & _
        "ghlight;}Style26{}RecordSelector{AlignImage:Center;}Style24{}Style23{AlignHorz:N" & _
        "ear;}Style22{AlignHorz:Near;}Style21{}Style20{}Group{AlignVert:Center;Border:Non" & _
        "e,,0, 0, 0, 0;BackColor:ControlDark;}Inactive{ForeColor:InactiveCaptionText;Back" & _
        "Color:InactiveCaption;}EvenRow{BackColor:Aqua;}Heading{Wrap:True;Font:Tahoma, 9." & _
        "75pt, style=Bold;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTe" & _
        "xt;AlignVert:Center;}FilterBar{}Style9{}Style8{}Style5{}Style4{}Style7{}Style6{}" & _
        "Style1{}Style30{}Style3{}Style2{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.Me" & _
        "rgeView AllowColMove=""False"" Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17""" & _
        " ColumnFooterHeight=""17"" FilterBar=""True"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><Height>292</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><Edito" & _
        "rStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" " & _
        "/><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer""" & _
        " me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""H" & _
        "eading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><In" & _
        "activeStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Sty" & _
        "le9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyl" & _
        "e parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><internal" & _
        "Cols><C1DisplayColumn><HeadingStyle parent=""Style2"" me=""Style16"" /><Style parent" & _
        "=""Style1"" me=""Style17"" /><FooterStyle parent=""Style3"" me=""Style18"" /><EditorStyl" & _
        "e parent=""Style5"" me=""Style19"" /><GroupHeaderStyle parent=""Style1"" me=""Style21"" " & _
        "/><GroupFooterStyle parent=""Style1"" me=""Style20"" /><Visible>True</Visible><Colum" & _
        "nDivider>DarkGray,Single</ColumnDivider><Width>92</Width><Height>15</Height><DCI" & _
        "dx>0</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=""Style2"" me=" & _
        """Style22"" /><Style parent=""Style1"" me=""Style23"" /><FooterStyle parent=""Style3"" m" & _
        "e=""Style24"" /><EditorStyle parent=""Style5"" me=""Style25"" /><GroupHeaderStyle pare" & _
        "nt=""Style1"" me=""Style27"" /><GroupFooterStyle parent=""Style1"" me=""Style26"" /><Vis" & _
        "ible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Width>153</Wid" & _
        "th><Height>15</Height><DCIdx>1</DCIdx></C1DisplayColumn><C1DisplayColumn><Headin" & _
        "gStyle parent=""Style2"" me=""Style28"" /><Style parent=""Style1"" me=""Style29"" /><Foo" & _
        "terStyle parent=""Style3"" me=""Style30"" /><EditorStyle parent=""Style5"" me=""Style31" & _
        """ /><GroupHeaderStyle parent=""Style1"" me=""Style33"" /><GroupFooterStyle parent=""S" & _
        "tyle1"" me=""Style32"" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</Col" & _
        "umnDivider><Width>124</Width><Height>15</Height><DCIdx>2</DCIdx></C1DisplayColum" & _
        "n></internalCols><ClientRect>0, 0, 404, 292</ClientRect><BorderSide>0</BorderSid" & _
        "e><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><Nam" & _
        "edStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><S" & _
        "tyle parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Styl" & _
        "e parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style" & _
        " parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style" & _
        " parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style pare" & _
        "nt=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Styl" & _
        "e parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSpl" & _
        "its>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>16</DefaultRecSel" & _
        "Width><ClientArea>0, 0, 404, 292</ClientArea><PrintPageHeaderStyle parent="""" me=" & _
        """Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Fish Bins Table View"
        '
        'frmFishBin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(418, 527)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.Label4, Me.Label3, Me.Label5, Me.grid, Me.cmdClose, Me.cmdPrint, Me.cmdFind, Me.cmdEdit, Me.cmd, Me.lblCode, Me.Label1, Me.txtTare, Me.txtBinNo})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishBin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishBin"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishBin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        displayAllFishBins()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllFishBins()
        With grid
            .DataSource = modModule.getAllFishBins().Tables(0)
            .Columns(2).NumberFormat = "##0.#0"
            .Splits(0).DisplayColumns(0).Width = 125
            .Splits(0).DisplayColumns(1).Width = 125
            .Splits(0).DisplayColumns(2).Width = 118
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
                txtBinNo.ReadOnly = False
                txtTare.ReadOnly = False
            Case 1
                txtBinNo.ReadOnly = True
                txtTare.ReadOnly = True
        End Select
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        txtBinNo.Text = ""
        txtTare.Text = "0"
        displayAllFishBins()
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
                txtBinNo.SelectAll()
                txtBinNo.Focus()
            Case "&Save"
                If Not txtBinNo.Text.Trim = "" And Not Me.txtTare.Text.Trim = "0" Then
                    If Not validateFishBins(txtBinNo.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewRecord(txtBinNo.Text.ToUpper, txtTare.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            displayAllFishBins()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Fish bins already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        Me.txtBinNo.SelectAll()
                        Me.txtBinNo.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    Me.txtBinNo.SelectAll()
                    Me.txtBinNo.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFishBins(lblCode.Text, txtBinNo.Text.ToUpper, txtTare.Text, "N")
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)

                    displayAllFishBins()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Public Sub saveNewRecord(ByVal bin As String, ByVal weight As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_addNew_FishBins"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishBinCounter()

            Dim p2 As New SqlClient.SqlParameter()
            p2.ParameterName = "@binCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            lblCode.Text = Format(getFishBinCounter, "FB0###")
            p2.Value = lblCode.Text

            Dim p3 As New SqlClient.SqlParameter()
            p3.ParameterName = "@bin#"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = bin.ToUpper

            Dim p4 As New SqlClient.SqlParameter()
            p4.ParameterName = "@tareWeight"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.Float
            p4.Value = weight

            Dim p5 As New SqlClient.SqlParameter()
            p5.ParameterName = "@dummyBin"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = "N"

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
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(poptr)
            cmd.Parameters.Add(pencoded)

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
                If Not Me.lblCode.Text = "" And Not txtBinNo.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    txtBinNo.ReadOnly = True
                    txtTare.SelectAll()
                    txtTare.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    txtBinNo.SelectAll()
                    txtBinNo.Focus()
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

    Public Sub displayDataToEachDataEntry()
        With grid
            If .RowCount > 0 Then
                lblCode.Text = .Item(.Row, 0)
                txtBinNo.Text = .Item(.Row, 1)
                txtTare.Text = .Item(.Row, 2)
            Else
                lblCode.Text = ""
                txtBinNo.Text = ""
                txtTare.Text = "0"
            End If
        End With
    End Sub

    Private Sub txtTare_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTare.TextChanged
        If Not IsNumeric(txtTare.Text) Or txtTare.Text = "" Then
            txtTare.Text = "0"
            txtTare.SelectAll()
            txtTare.Focus()
        End If
    End Sub

    Public Sub displayRecord(ByVal bin As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_display_FishBinsDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@binNo"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = bin

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    txtTare.Text = dr.GetDouble(0)
                    lblCode.Text = dr.GetString(1)
                Else
                    txtTare.Text = "0"
                    lblCode.Text = ""
                End If
            Else
                txtTare.Text = "0"
                lblCode.Text = ""
            End If

            dr.Close()
            c.Close()
        Catch e As Exception
            'MsgBox(e.Message)
            MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Private Sub txtBinNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBinNo.TextChanged
        displayRecord(txtBinNo.Text)
    End Sub

    Private Sub txtBinNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBinNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTare.SelectAll()
            txtTare.Focus()
        End If
    End Sub

    Private Sub txtTare_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTare.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd.Focus()
        End If
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        displayDataToEachDataEntry()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Fish Bins"
        f.searchType = 1
        f.displayAllFishBins()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                txtBinNo.Text = .Item(.Row, 1)
            End If
        End With
    End Sub
End Class
