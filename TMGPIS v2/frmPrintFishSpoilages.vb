Public Class frmPrintFishSpoilages
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
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboShift As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtProdnDate As C1.Win.C1Input.C1DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintFishSpoilages))
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboShift = New C1.Win.C1List.C1Combo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdnDate = New C1.Win.C1Input.C1DateEdit()
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grp.SuspendLayout()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(672, 40)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Print Fish Process Rejects"
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Label9)
        Me.grp.Controls.Add(Me.cboShift)
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Controls.Add(Me.txtProdnDate)
        Me.grp.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp.Location = New System.Drawing.Point(0, 40)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(672, 82)
        Me.grp.TabIndex = 62
        Me.grp.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Shift"
        '
        'cboShift
        '
        Me.cboShift.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboShift.AllowColMove = False
        Me.cboShift.AutoCompletion = True
        Me.cboShift.AutoDropDown = True
        Me.cboShift.Caption = ""
        Me.cboShift.CaptionHeight = 17
        Me.cboShift.CaptionStyle = Style1
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
        Me.cboShift.EvenRowStyle = Style2
        Me.cboShift.FooterStyle = Style3
        Me.cboShift.HeadingStyle = Style4
        Me.cboShift.HighLightRowStyle = Style5
        Me.cboShift.Images.Add(CType(resources.GetObject("cboShift.Images"), System.Drawing.Image))
        Me.cboShift.ItemHeight = 20
        Me.cboShift.Location = New System.Drawing.Point(88, 48)
        Me.cboShift.MatchEntryTimeout = CType(2000, Long)
        Me.cboShift.MaxDropDownItems = CType(20, Short)
        Me.cboShift.MaxLength = 32767
        Me.cboShift.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboShift.Name = "cboShift"
        Me.cboShift.OddRowStyle = Style6
        Me.cboShift.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboShift.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboShift.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboShift.SelectedStyle = Style7
        Me.cboShift.Size = New System.Drawing.Size(144, 24)
        Me.cboShift.Style = Style8
        Me.cboShift.TabIndex = 2
        Me.cboShift.PropBag = resources.GetString("cboShift.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Date From"
        '
        'txtProdnDate
        '
        Me.txtProdnDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtProdnDate.Location = New System.Drawing.Point(88, 17)
        Me.txtProdnDate.Name = "txtProdnDate"
        Me.txtProdnDate.Size = New System.Drawing.Size(144, 23)
        Me.txtProdnDate.TabIndex = 0
        Me.txtProdnDate.Tag = Nothing
        Me.txtProdnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptViewer.Location = New System.Drawing.Point(0, 122)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.Size = New System.Drawing.Size(672, 387)
        Me.rptViewer.TabIndex = 63
        Me.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmPrintFishSpoilages
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 509)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPrintFishSpoilages"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintFishSpoilages"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.cboShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdnDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintFishSpoilages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        'txtProdnDate.Value = getServerDateTime()
        'initializeShift()

    End Sub

    Public Sub initializeShift()
        With cboShift
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 118
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayReport(ByVal prodnDate As String, ByVal shift As String)
        Try
            Dim rpt As New rptPrintFishSpoilage
            rpt.Load()
            rpt.SetDataSource(getFishSpoilagesReport(prodnDate, shift).Tables(0))
            rptViewer.ReportSource = rpt
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub txtProdnDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdnDate.ValueChanged
        displayReport(txtProdnDate.Text, cboShift.Text)
    End Sub

    Private Sub cboShift_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboShift.TextChanged
        displayReport(txtProdnDate.Text, cboShift.Text)
    End Sub
End Class
