Public Class frmFishSize
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
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents cboFrom As C1.Win.C1List.C1Combo
    Friend WithEvents cboTo As C1.Win.C1List.C1Combo
    Friend WithEvents cboUnit As C1.Win.C1List.C1Combo
    Friend WithEvents lblRange As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFishSize))
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
        Me.cboFrom = New C1.Win.C1List.C1Combo()
        Me.cboTo = New C1.Win.C1List.C1Combo()
        Me.cboUnit = New C1.Win.C1List.C1Combo()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.cboFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboFrom
        '
        Me.cboFrom.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboFrom.AllowColMove = False
        Me.cboFrom.AutoCompletion = True
        Me.cboFrom.AutoDropDown = True
        Me.cboFrom.Caption = ""
        Me.cboFrom.CaptionHeight = 17
        Me.cboFrom.CaptionStyle = Style1
        Me.cboFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFrom.ColumnCaptionHeight = 17
        Me.cboFrom.ColumnFooterHeight = 17
        Me.cboFrom.ContentHeight = 18
        Me.cboFrom.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboFrom.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboFrom.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFrom.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFrom.EditorHeight = 18
        Me.cboFrom.EvenRowStyle = Style2
        Me.cboFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFrom.FooterStyle = Style3
        Me.cboFrom.HeadingStyle = Style4
        Me.cboFrom.HighLightRowStyle = Style5
        Me.cboFrom.Images.Add(CType(resources.GetObject("cboFrom.Images"), System.Drawing.Image))
        Me.cboFrom.ItemHeight = 20
        Me.cboFrom.Location = New System.Drawing.Point(112, 76)
        Me.cboFrom.MatchEntryTimeout = CType(2000, Long)
        Me.cboFrom.MaxDropDownItems = CType(5, Short)
        Me.cboFrom.MaxLength = 32767
        Me.cboFrom.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboFrom.Name = "cboFrom"
        Me.cboFrom.OddRowStyle = Style6
        Me.cboFrom.ReadOnly = True
        Me.cboFrom.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboFrom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboFrom.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboFrom.SelectedStyle = Style7
        Me.cboFrom.Size = New System.Drawing.Size(121, 24)
        Me.cboFrom.Style = Style8
        Me.cboFrom.TabIndex = 0
        Me.cboFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cboFrom.PropBag = resources.GetString("cboFrom.PropBag")
        '
        'cboTo
        '
        Me.cboTo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboTo.AllowColMove = False
        Me.cboTo.AutoCompletion = True
        Me.cboTo.AutoDropDown = True
        Me.cboTo.Caption = ""
        Me.cboTo.CaptionHeight = 17
        Me.cboTo.CaptionStyle = Style9
        Me.cboTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTo.ColumnCaptionHeight = 17
        Me.cboTo.ColumnFooterHeight = 17
        Me.cboTo.ContentHeight = 18
        Me.cboTo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboTo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboTo.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTo.EditorHeight = 18
        Me.cboTo.EvenRowStyle = Style10
        Me.cboTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTo.FooterStyle = Style11
        Me.cboTo.HeadingStyle = Style12
        Me.cboTo.HighLightRowStyle = Style13
        Me.cboTo.Images.Add(CType(resources.GetObject("cboTo.Images"), System.Drawing.Image))
        Me.cboTo.ItemHeight = 20
        Me.cboTo.Location = New System.Drawing.Point(112, 110)
        Me.cboTo.MatchEntryTimeout = CType(2000, Long)
        Me.cboTo.MaxDropDownItems = CType(5, Short)
        Me.cboTo.MaxLength = 32767
        Me.cboTo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboTo.Name = "cboTo"
        Me.cboTo.OddRowStyle = Style14
        Me.cboTo.ReadOnly = True
        Me.cboTo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboTo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboTo.SelectedStyle = Style15
        Me.cboTo.Size = New System.Drawing.Size(121, 24)
        Me.cboTo.Style = Style16
        Me.cboTo.TabIndex = 1
        Me.cboTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cboTo.PropBag = resources.GetString("cboTo.PropBag")
        '
        'cboUnit
        '
        Me.cboUnit.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboUnit.AllowColMove = False
        Me.cboUnit.AutoCompletion = True
        Me.cboUnit.AutoDropDown = True
        Me.cboUnit.Caption = ""
        Me.cboUnit.CaptionHeight = 17
        Me.cboUnit.CaptionStyle = Style17
        Me.cboUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboUnit.ColumnCaptionHeight = 17
        Me.cboUnit.ColumnFooterHeight = 17
        Me.cboUnit.ContentHeight = 18
        Me.cboUnit.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboUnit.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboUnit.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboUnit.EditorHeight = 18
        Me.cboUnit.EvenRowStyle = Style18
        Me.cboUnit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.FooterStyle = Style19
        Me.cboUnit.HeadingStyle = Style20
        Me.cboUnit.HighLightRowStyle = Style21
        Me.cboUnit.Images.Add(CType(resources.GetObject("cboUnit.Images"), System.Drawing.Image))
        Me.cboUnit.ItemHeight = 20
        Me.cboUnit.Location = New System.Drawing.Point(112, 144)
        Me.cboUnit.MatchEntryTimeout = CType(2000, Long)
        Me.cboUnit.MaxDropDownItems = CType(5, Short)
        Me.cboUnit.MaxLength = 32767
        Me.cboUnit.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.OddRowStyle = Style22
        Me.cboUnit.ReadOnly = True
        Me.cboUnit.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboUnit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboUnit.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboUnit.SelectedStyle = Style23
        Me.cboUnit.Size = New System.Drawing.Size(121, 24)
        Me.cboUnit.Style = Style24
        Me.cboUnit.TabIndex = 2
        Me.cboUnit.PropBag = resources.GetString("cboUnit.PropBag")
        '
        'lblCode
        '
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(112, 46)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(120, 24)
        Me.lblCode.TabIndex = 48
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Size To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Size From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Size Code"
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
        Me.grid.Location = New System.Drawing.Point(8, 216)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(489, 256)
        Me.grid.TabIndex = 43
        Me.grid.TabStop = False
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(504, 40)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Fish Size Information"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(375, 476)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 41
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(295, 476)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 40
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(215, 476)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 39
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(135, 476)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 38
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(55, 476)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 37
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblRange
        '
        Me.lblRange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRange.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRange.Location = New System.Drawing.Point(112, 176)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(232, 24)
        Me.lblRange.TabIndex = 50
        Me.lblRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Fish Size Range"
        '
        'frmFishSize
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.cboTo)
        Me.Controls.Add(Me.cboFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFishSize"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishSize"
        CType(Me.cboFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmFishSize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        displayAllFishSizes()
        displaySizeDetails(0)
        displaySizeDetails(1)
        displaySizeDetails(2)

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllFishSizes()
        With grid
            .DataSource = modModule.getAllFishSizes().Tables(0)
            .Splits(0).DisplayColumns(1).Width = 60
            .Columns(1).NumberFormat = "##0.#0"
            .Splits(0).DisplayColumns(2).Width = 60
            .Columns(2).NumberFormat = "##0.#0"
            .Splits(0).DisplayColumns(3).Width = 70
            .Splits(0).DisplayColumns(4).Width = 150
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
                cboFrom.ReadOnly = False
                cboTo.ReadOnly = False
                cboUnit.ReadOnly = False
            Case 1
                cboFrom.ReadOnly = True
                cboTo.ReadOnly = True
                cboUnit.ReadOnly = True
        End Select
    End Sub

    Public Sub addNewRecord()
        lblCode.Text = ""
        displaySizeDetails(0)
        displaySizeDetails(1)
        displaySizeDetails(2)
        lblRange.Text = ""
        displayAllFishSizes()
    End Sub

    Private Sub cboFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFrom.TextChanged
        If cboFrom.Text = "" Or Not IsNumeric(cboFrom.Text.Trim) Then
            cboFrom.Text = "0"
            cboFrom.SelectAll()
            cboFrom.Focus()
        End If

        displayRange(cboFrom.Text, cboTo.Text, cboUnit.Text)
    End Sub

    Private Sub cboTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTo.TextChanged
        If cboTo.Text = "" Or Not IsNumeric(cboTo.Text.Trim) Then
            cboTo.Text = "0"
            cboTo.SelectAll()
            cboTo.Focus()
        End If

        displayRange(cboFrom.Text, cboTo.Text, cboUnit.Text)
    End Sub

    Public Sub displayRange(ByVal from As String, ByVal dest As String, ByVal unit As String)
        lblRange.Text = from & " - " & dest & " " & unit & "."
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
                cboFrom.SelectAll()
                cboFrom.Focus()
            Case "&Save"
                If Not cboFrom.Text.Trim = "" And Not cboTo.Text.Trim = "" And Not cboUnit.Text.Trim = "" And _
                (Not cboFrom.Text.Trim = "0" Or Not cboTo.Text.Trim = "0") Then
                    If Not validateFishSize(cboFrom.Text, cboTo.Text) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewFishSize(cboFrom.Text, cboTo.Text, cboUnit.Text, lblRange.Text)
                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)

                            displayAllFishSizes()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Fish sizes already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboFrom.SelectAll()
                        cboFrom.Focus()
                    End If
                Else
                    MsgBox("Please check your data entry fields.", MsgBoxStyle.Critical, "Result: Check your data")
                    cboFrom.SelectAll()
                    cboFrom.Focus()
                End If
            Case "&Save "
                reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFishSize(lblCode.Text, cboFrom.Text, cboTo.Text, cboUnit.Text, lblRange.Text)
                    cmd.Text = "&Add"
                    cmdEdit.Text = "&Edit"
                    buttons(1)
                    dataEntry(1)

                    displayAllFishSizes()
                    'displayFishSpecie()
                    MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                    cmd.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not Me.lblCode.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)
                    cboFrom.SelectAll()
                    cboFrom.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboFrom.SelectAll()
                    cboFrom.Focus()
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

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch()
        f.lblTitle.Text = "Search Fish Sizes"
        f.searchType = 1
        f.displayAllFishSizes()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 0)
                cboFrom.Text = .Item(.Row, 1)
                cboTo.Text = .Item(.Row, 2)
                cboUnit.Text = .Item(.Row, 3)
                lblRange.Text = .Item(.Row, 4)
            End If
        End With
    End Sub

    Public Sub saveNewFishSize(ByVal from As String, ByVal tu As String, _
    ByVal unit As String, ByVal range As String)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand()
            cmd.CommandText = "proc_addNew_FishSizes"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter()
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFishSizesCounter()

            Dim p2 As New SqlClient.SqlParameter()
            p2.ParameterName = "@code"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            lblCode.Text = Format(getFishSizesCounter, "SZ0###")
            p2.Value = lblCode.Text

            Dim p3 As New SqlClient.SqlParameter()
            p3.ParameterName = "@from"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.Float
            p3.Value = CDbl(from)

            Dim p4 As New SqlClient.SqlParameter()
            p4.ParameterName = "@to"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.Float
            p4.Value = CDbl(tu)

            Dim p5 As New SqlClient.SqlParameter()
            p5.ParameterName = "@unit"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = unit

            Dim p6 As New SqlClient.SqlParameter()
            p6.ParameterName = "@range"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = range.Trim

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
            cmd.Parameters.Add(p6)
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

    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        With grid
            If grid.RowCount > 0 Then
                lblCode.Text = .Item(.Row, 0)
                cboFrom.Text = .Item(.Row, 1)
                cboTo.Text = .Item(.Row, 2)
                cboUnit.Text = .Item(.Row, 3)
                lblRange.Text = .Item(.Row, 4)
            End If
        End With
    End Sub

    Private Sub cboUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnit.TextChanged
        displayRange(cboFrom.Text, cboTo.Text, cboUnit.Text)
    End Sub

    Public Sub displaySizeDetails(ByVal type As Integer)
        Try
            Dim c As New SqlClient.SqlConnection()
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim qry As String
            Select Case type
                Case 0
                    qry = "SELECT DISTINCT sizeFrom AS [From] FROM tblFishSizes ORDER by sizeFrom"
                Case 1
                    qry = "SELECT DISTINCT sizeTo AS [To] FROM tblFishSizes ORDER by sizeTo"
                Case 2
                    qry = "SELECT DISTINCT sizeUnit AS [Size Range] FROM tblFishSizes ORDER by sizeUnit"
            End Select

            Dim cmd As New SqlClient.SqlCommand(qry, c)

            Dim da As New SqlClient.SqlDataAdapter()
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            Select Case type
                Case 0
                    cboFrom.Text = "0"
                    cboFrom.DefColWidth = 100
                    cboFrom.DataSource = ds.Tables(0)
                Case 1
                    cboTo.Text = "0"
                    cboTo.DefColWidth = 100
                    cboTo.DataSource = ds.Tables(0)
                Case 2
                    cboUnit.Text = ""
                    cboUnit.DefColWidth = 100
                    cboUnit.DataSource = ds.Tables(0)
            End Select

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cboFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboTo.SelectAll()
            cboTo.Focus()
        End If
    End Sub

    Private Sub cboTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboUnit.SelectAll()
            cboUnit.Focus()
        End If
    End Sub

    Private Sub cboUnit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboUnit.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd.Focus()
        End If
    End Sub
End Class
