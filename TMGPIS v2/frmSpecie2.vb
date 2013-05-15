Public Class frmSpecie2
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents cboCode As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboBaseSpecie As C1.Win.C1List.C1Combo
    Friend WithEvents cboSpecie As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpecie2))
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style9 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style10 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style11 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style12 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style13 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style14 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style15 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style16 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style17 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style18 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style19 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style20 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style21 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style22 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style23 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style24 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.cboSpecie = New C1.Win.C1List.C1Combo()
        Me.cboCode = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBaseSpecie = New C1.Win.C1List.C1Combo()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBaseSpecie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Table View"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Fish Species"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Specie Code"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 40)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Fish Species Information"
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.FilterBar = True
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(9, 166)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(391, 298)
        Me.grid.TabIndex = 8
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(328, 472)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(248, 472)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(168, 472)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 5
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(88, 472)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 4
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(8, 472)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 3
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cboSpecie
        '
        Me.cboSpecie.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboSpecie.AllowColMove = False
        Me.cboSpecie.AutoCompletion = True
        Me.cboSpecie.AutoDropDown = True
        Me.cboSpecie.Caption = ""
        Me.cboSpecie.CaptionHeight = 17
        Me.cboSpecie.CaptionStyle = Style1
        Me.cboSpecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSpecie.ColumnCaptionHeight = 17
        Me.cboSpecie.ColumnFooterHeight = 17
        Me.cboSpecie.ContentHeight = 18
        Me.cboSpecie.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSpecie.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSpecie.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSpecie.EditorHeight = 18
        Me.cboSpecie.EvenRowStyle = Style2
        Me.cboSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecie.FooterStyle = Style3
        Me.cboSpecie.HeadingStyle = Style4
        Me.cboSpecie.HighLightRowStyle = Style5
        Me.cboSpecie.Images.Add(CType(resources.GetObject("cboSpecie.Images"), System.Drawing.Image))
        Me.cboSpecie.ItemHeight = 20
        Me.cboSpecie.Location = New System.Drawing.Point(104, 84)
        Me.cboSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboSpecie.MaxDropDownItems = CType(10, Short)
        Me.cboSpecie.MaxLength = 32767
        Me.cboSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSpecie.Name = "cboSpecie"
        Me.cboSpecie.OddRowStyle = Style6
        Me.cboSpecie.ReadOnly = True
        Me.cboSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSpecie.SelectedStyle = Style7
        Me.cboSpecie.Size = New System.Drawing.Size(296, 24)
        Me.cboSpecie.Style = Style8
        Me.cboSpecie.TabIndex = 1
        Me.cboSpecie.PropBag = resources.GetString("cboSpecie.PropBag")
        '
        'cboCode
        '
        Me.cboCode.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCode.AllowColMove = False
        Me.cboCode.AutoCompletion = True
        Me.cboCode.AutoDropDown = True
        Me.cboCode.Caption = ""
        Me.cboCode.CaptionHeight = 17
        Me.cboCode.CaptionStyle = Style9
        Me.cboCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCode.ColumnCaptionHeight = 17
        Me.cboCode.ColumnFooterHeight = 17
        Me.cboCode.ContentHeight = 18
        Me.cboCode.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCode.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCode.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCode.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCode.EditorHeight = 18
        Me.cboCode.EvenRowStyle = Style10
        Me.cboCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCode.FooterStyle = Style11
        Me.cboCode.HeadingStyle = Style12
        Me.cboCode.HighLightRowStyle = Style13
        Me.cboCode.Images.Add(CType(resources.GetObject("cboCode.Images"), System.Drawing.Image))
        Me.cboCode.ItemHeight = 20
        Me.cboCode.Location = New System.Drawing.Point(104, 52)
        Me.cboCode.MatchEntryTimeout = CType(2000, Long)
        Me.cboCode.MaxDropDownItems = CType(10, Short)
        Me.cboCode.MaxLength = 32767
        Me.cboCode.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCode.Name = "cboCode"
        Me.cboCode.OddRowStyle = Style14
        Me.cboCode.ReadOnly = True
        Me.cboCode.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCode.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCode.SelectedStyle = Style15
        Me.cboCode.Size = New System.Drawing.Size(88, 24)
        Me.cboCode.Style = Style16
        Me.cboCode.TabIndex = 0
        Me.cboCode.PropBag = resources.GetString("cboCode.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Base Species"
        '
        'cboBaseSpecie
        '
        Me.cboBaseSpecie.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboBaseSpecie.AllowColMove = False
        Me.cboBaseSpecie.AutoCompletion = True
        Me.cboBaseSpecie.AutoDropDown = True
        Me.cboBaseSpecie.Caption = ""
        Me.cboBaseSpecie.CaptionHeight = 17
        Me.cboBaseSpecie.CaptionStyle = Style17
        Me.cboBaseSpecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBaseSpecie.ColumnCaptionHeight = 17
        Me.cboBaseSpecie.ColumnFooterHeight = 17
        Me.cboBaseSpecie.ContentHeight = 18
        Me.cboBaseSpecie.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboBaseSpecie.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboBaseSpecie.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaseSpecie.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBaseSpecie.EditorHeight = 18
        Me.cboBaseSpecie.EvenRowStyle = Style18
        Me.cboBaseSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaseSpecie.FooterStyle = Style19
        Me.cboBaseSpecie.HeadingStyle = Style20
        Me.cboBaseSpecie.HighLightRowStyle = Style21
        Me.cboBaseSpecie.Images.Add(CType(resources.GetObject("cboBaseSpecie.Images"), System.Drawing.Image))
        Me.cboBaseSpecie.ItemHeight = 20
        Me.cboBaseSpecie.Location = New System.Drawing.Point(104, 118)
        Me.cboBaseSpecie.MatchEntryTimeout = CType(2000, Long)
        Me.cboBaseSpecie.MaxDropDownItems = CType(10, Short)
        Me.cboBaseSpecie.MaxLength = 32767
        Me.cboBaseSpecie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboBaseSpecie.Name = "cboBaseSpecie"
        Me.cboBaseSpecie.OddRowStyle = Style22
        Me.cboBaseSpecie.ReadOnly = True
        Me.cboBaseSpecie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboBaseSpecie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboBaseSpecie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboBaseSpecie.SelectedStyle = Style23
        Me.cboBaseSpecie.Size = New System.Drawing.Size(296, 24)
        Me.cboBaseSpecie.Style = Style24
        Me.cboBaseSpecie.TabIndex = 2
        Me.cboBaseSpecie.PropBag = resources.GetString("cboBaseSpecie.PropBag")
        '
        'frmSpecie2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(410, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboBaseSpecie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.cboSpecie)
        Me.Controls.Add(Me.cboCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSpecie2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSpecie2"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBaseSpecie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmSpecie2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        displayAllFishSpecie()
        displaySpecieCode()
        displaySpecie()
        displayBaseSpecie()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllFishSpecie()
        With grid
            .DataSource = modModule.getAllFishSpecie2().Tables(0)
            '.Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 125
            .Splits(0).DisplayColumns(2).Width = 125
        End With
    End Sub

    Public Sub displaySpecieCode()
        With cboCode
            .DataSource = modModule.getFishSpecieCode().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 68
        End With
    End Sub

    Public Sub displaySpecie()
        With cboSpecie
            .DataSource = modModule.getFishSpecie().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 275
        End With
    End Sub

    Public Sub displayBaseSpecie()
        With cboBaseSpecie
            .Text = ""
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
            .AddItemTitles("Base Species")
            .AddItem("Albacore")
            .AddItem("Big Eye")
            .AddItem("Skipjack")
            .AddItem("Yellow Fin")

            .Splits(0).DisplayColumns(0).Width = 275
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
                cboCode.ReadOnly = False
                cboSpecie.ReadOnly = False
                cboBaseSpecie.ReadOnly = False
            Case 1
                cboCode.ReadOnly = True
                cboSpecie.ReadOnly = True
                cboBaseSpecie.ReadOnly = True
        End Select
    End Sub

    Public Sub addNewRecord()
        cboCode.ReadOnly = False
        displaySpecieCode()
        cboCode.Text = ""
        displaySpecie()
        cboSpecie.Text = ""
        cboBaseSpecie.Text = ""

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
                cboCode.SelectAll()
                cboCode.Focus()
            Case "&Save"
                If Not cboCode.Text.Trim = "" And Not cboSpecie.Text.Trim = "" And Not cboBaseSpecie.Text.Trim = "" Then
                    If Not validateSpecie(cboCode.Text.Trim, cboSpecie.Text.Trim) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewFishSpecie(cboCode.Text, cboSpecie.Text, cboBaseSpecie.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            displayAllFishSpecie()
                            displaySpecieCode()
                            displaySpecie()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Fish Specie and/or Specie Code already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCode.SelectAll()
                        cboCode.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCode.SelectAll()
                    cboCode.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFishSpecie(cboCode.Text, cboSpecie.Text, cboBaseSpecie.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)

                    displayAllFishSpecie()
                    displaySpecieCode()
                    displaySpecie()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not Me.cboCode.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboCode.ReadOnly = True
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

    Public Sub displayDataToEachDataEntry()
        With grid
            If .RowCount > 0 Then
                cboCode.Text = .Item(.Row, 0)
                cboSpecie.Text = .Item(.Row, 1)
            Else
                cboCode.Text = ""
                cboSpecie.Text = ""
            End If
        End With
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        displayDataToEachDataEntry()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Fish Specie"
        f.searchType = 1
        f.displayAllSpecie()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                cboCode.Text = .Item(.Row, 0)
                cboSpecie.Text = .Item(.Row, 1)
                cboBaseSpecie.Text = .Item(.Row, 2)
            End If
        End With
    End Sub

    Private Sub cboCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSpecie.SelectAll()
            cboSpecie.Focus()
        End If
    End Sub

    Private Sub cboSpecie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSpecie.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd.Focus()
        End If
    End Sub
End Class
