<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalibration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalibration))
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.cboScale = New C1.Win.C1List.C1Combo()
        Me.optUL = New System.Windows.Forms.RadioButton()
        Me.optUR = New System.Windows.Forms.RadioButton()
        Me.optCtr = New System.Windows.Forms.RadioButton()
        Me.optLL = New System.Windows.Forms.RadioButton()
        Me.optLR = New System.Windows.Forms.RadioButton()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.gridLoc = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optFail = New System.Windows.Forms.RadioButton()
        Me.optPass = New System.Windows.Forms.RadioButton()
        Me.optPending = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.cboScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboScale
        '
        Me.cboScale.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboScale.Caption = ""
        Me.cboScale.CaptionHeight = 17
        Me.cboScale.CaptionStyle = Style1
        Me.cboScale.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboScale.ColumnCaptionHeight = 17
        Me.cboScale.ColumnFooterHeight = 17
        Me.cboScale.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboScale.ContentHeight = 18
        Me.cboScale.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboScale.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboScale.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboScale.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboScale.EditorHeight = 18
        Me.cboScale.EvenRowStyle = Style2
        Me.cboScale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboScale.FooterStyle = Style3
        Me.cboScale.HeadingStyle = Style4
        Me.cboScale.HighLightRowStyle = Style5
        Me.cboScale.Images.Add(CType(resources.GetObject("cboScale.Images"), System.Drawing.Image))
        Me.cboScale.ItemHeight = 20
        Me.cboScale.Location = New System.Drawing.Point(89, 55)
        Me.cboScale.MatchEntryTimeout = CType(2000, Long)
        Me.cboScale.MaxDropDownItems = CType(5, Short)
        Me.cboScale.MaxLength = 32767
        Me.cboScale.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboScale.Name = "cboScale"
        Me.cboScale.OddRowStyle = Style6
        Me.cboScale.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboScale.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboScale.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboScale.SelectedStyle = Style7
        Me.cboScale.Size = New System.Drawing.Size(262, 24)
        Me.cboScale.Style = Style8
        Me.cboScale.TabIndex = 0
        Me.cboScale.PropBag = resources.GetString("cboScale.PropBag")
        '
        'optUL
        '
        Me.optUL.AutoSize = True
        Me.optUL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optUL.Location = New System.Drawing.Point(48, 111)
        Me.optUL.Name = "optUL"
        Me.optUL.Size = New System.Drawing.Size(94, 20)
        Me.optUL.TabIndex = 1
        Me.optUL.TabStop = True
        Me.optUL.Text = "Upper &Left"
        Me.optUL.UseVisualStyleBackColor = True
        '
        'optUR
        '
        Me.optUR.AutoSize = True
        Me.optUR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optUR.Location = New System.Drawing.Point(221, 111)
        Me.optUR.Name = "optUR"
        Me.optUR.Size = New System.Drawing.Size(102, 20)
        Me.optUR.TabIndex = 2
        Me.optUR.TabStop = True
        Me.optUR.Text = "Upper &Right"
        Me.optUR.UseVisualStyleBackColor = True
        '
        'optCtr
        '
        Me.optCtr.AutoSize = True
        Me.optCtr.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCtr.Location = New System.Drawing.Point(141, 151)
        Me.optCtr.Name = "optCtr"
        Me.optCtr.Size = New System.Drawing.Size(70, 20)
        Me.optCtr.TabIndex = 3
        Me.optCtr.TabStop = True
        Me.optCtr.Text = "C&enter"
        Me.optCtr.UseVisualStyleBackColor = True
        '
        'optLL
        '
        Me.optLL.AutoSize = True
        Me.optLL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLL.Location = New System.Drawing.Point(48, 194)
        Me.optLL.Name = "optLL"
        Me.optLL.Size = New System.Drawing.Size(96, 20)
        Me.optLL.TabIndex = 4
        Me.optLL.TabStop = True
        Me.optLL.Text = "L&ower Left"
        Me.optLL.UseVisualStyleBackColor = True
        '
        'optLR
        '
        Me.optLR.AutoSize = True
        Me.optLR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLR.Location = New System.Drawing.Point(221, 194)
        Me.optLR.Name = "optLR"
        Me.optLR.Size = New System.Drawing.Size(104, 20)
        Me.optLR.TabIndex = 5
        Me.optLR.TabStop = True
        Me.optLR.Text = "Lo&wer Right"
        Me.optLR.UseVisualStyleBackColor = True
        '
        'cmdRead
        '
        Me.cmdRead.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRead.Location = New System.Drawing.Point(97, 268)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(157, 48)
        Me.cmdRead.TabIndex = 6
        Me.cmdRead.Text = "Rea&d Scale >>>"
        Me.cmdRead.UseVisualStyleBackColor = True
        '
        'gridLoc
        '
        Me.gridLoc.AllowUpdate = False
        Me.gridLoc.CaptionHeight = 17
        Me.gridLoc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridLoc.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridLoc.Images.Add(CType(resources.GetObject("gridLoc.Images"), System.Drawing.Image))
        Me.gridLoc.Location = New System.Drawing.Point(375, 201)
        Me.gridLoc.Name = "gridLoc"
        Me.gridLoc.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridLoc.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridLoc.PreviewInfo.ZoomFactor = 75.0R
        Me.gridLoc.PrintInfo.PageSettings = CType(resources.GetObject("gridLoc.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridLoc.RowHeight = 20
        Me.gridLoc.Size = New System.Drawing.Size(317, 146)
        Me.gridLoc.TabIndex = 7
        Me.gridLoc.Text = "C1TrueDBGrid1"
        Me.gridLoc.PropBag = resources.GetString("gridLoc.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optFail)
        Me.GroupBox1.Controls.Add(Me.optPass)
        Me.GroupBox1.Controls.Add(Me.optPending)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(375, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 103)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calibration Results"
        '
        'optFail
        '
        Me.optFail.AutoSize = True
        Me.optFail.Location = New System.Drawing.Point(26, 70)
        Me.optFail.Name = "optFail"
        Me.optFail.Size = New System.Drawing.Size(46, 20)
        Me.optFail.TabIndex = 2
        Me.optFail.TabStop = True
        Me.optFail.Text = "&Fail"
        Me.optFail.UseVisualStyleBackColor = True
        '
        'optPass
        '
        Me.optPass.AutoSize = True
        Me.optPass.Location = New System.Drawing.Point(26, 48)
        Me.optPass.Name = "optPass"
        Me.optPass.Size = New System.Drawing.Size(56, 20)
        Me.optPass.TabIndex = 1
        Me.optPass.TabStop = True
        Me.optPass.Text = "P&ass"
        Me.optPass.UseVisualStyleBackColor = True
        '
        'optPending
        '
        Me.optPending.AutoSize = True
        Me.optPending.Checked = True
        Me.optPending.Location = New System.Drawing.Point(26, 25)
        Me.optPending.Name = "optPending"
        Me.optPending.Size = New System.Drawing.Size(77, 20)
        Me.optPending.TabIndex = 0
        Me.optPending.TabStop = True
        Me.optPending.Text = "&Pending"
        Me.optPending.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Scale ID"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(700, 40)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Calibrate Scale"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(617, 147)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 102
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(536, 147)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 101
        Me.cmd.Text = "&Save"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 136)
        Me.Label1.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 105)
        Me.Label2.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Date of Test"
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(469, 56)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(174, 22)
        Me.lblDate.TabIndex = 121
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'grid
        '
        Me.grid.AllowUpdate = False
        Me.grid.CaptionHeight = 17
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(15, 384)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(677, 121)
        Me.grid.TabIndex = 122
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Calibration Log History"
        '
        'frmCalibration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gridLoc)
        Me.Controls.Add(Me.cmdRead)
        Me.Controls.Add(Me.optLR)
        Me.Controls.Add(Me.optLL)
        Me.Controls.Add(Me.optCtr)
        Me.Controls.Add(Me.optUR)
        Me.Controls.Add(Me.optUL)
        Me.Controls.Add(Me.cboScale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCalibration"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCalibration"
        CType(Me.cboScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboScale As C1.Win.C1List.C1Combo
    Friend WithEvents optUL As System.Windows.Forms.RadioButton
    Friend WithEvents optUR As System.Windows.Forms.RadioButton
    Friend WithEvents optCtr As System.Windows.Forms.RadioButton
    Friend WithEvents optLL As System.Windows.Forms.RadioButton
    Friend WithEvents optLR As System.Windows.Forms.RadioButton
    Friend WithEvents cmdRead As System.Windows.Forms.Button
    Friend WithEvents gridLoc As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optFail As System.Windows.Forms.RadioButton
    Friend WithEvents optPass As System.Windows.Forms.RadioButton
    Friend WithEvents optPending As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
