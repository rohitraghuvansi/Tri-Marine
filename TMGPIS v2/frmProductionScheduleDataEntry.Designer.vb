<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionScheduleDataEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionScheduleDataEntry))
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdViewMap = New System.Windows.Forms.Button()
        Me.cmdSet = New System.Windows.Forms.Button()
        Me.lblTripCode = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLot = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSublot = New System.Windows.Forms.Label()
        Me.lblSpecie = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblUnloading = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grid = New C1.Win.C1List.C1List()
        Me.lblSBCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblScBCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNSCount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNSWeight = New System.Windows.Forms.Label()
        Me.lblScBWeight = New System.Windows.Forms.Label()
        Me.lblSBWeight = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSchedule = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.DateTimePicker()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.optClear = New System.Windows.Forms.RadioButton()
        Me.optSchedule = New System.Windows.Forms.RadioButton()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(639, 540)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 117
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdViewMap
        '
        Me.cmdViewMap.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewMap.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdViewMap.Location = New System.Drawing.Point(525, 540)
        Me.cmdViewMap.Name = "cmdViewMap"
        Me.cmdViewMap.Size = New System.Drawing.Size(108, 48)
        Me.cmdViewMap.TabIndex = 116
        Me.cmdViewMap.Text = "View Info"
        Me.cmdViewMap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSet
        '
        Me.cmdSet.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSet.Image = CType(resources.GetObject("cmdSet.Image"), System.Drawing.Image)
        Me.cmdSet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSet.Location = New System.Drawing.Point(399, 540)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(120, 48)
        Me.cmdSet.TabIndex = 115
        Me.cmdSet.Text = "Schedule Bins"
        Me.cmdSet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblTripCode
        '
        Me.lblTripCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTripCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTripCode.Location = New System.Drawing.Point(92, 48)
        Me.lblTripCode.Name = "lblTripCode"
        Me.lblTripCode.Size = New System.Drawing.Size(176, 24)
        Me.lblTripCode.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Trip Code"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1113, 40)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Raw Fish Scheduling - Bin Details"
        '
        'lblRemarks
        '
        Me.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(92, 81)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(685, 24)
        Me.lblRemarks.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Lot Remarks"
        '
        'lblLot
        '
        Me.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.Location = New System.Drawing.Point(501, 48)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(137, 24)
        Me.lblLot.TabIndex = 124
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Lot/ Sublot"
        '
        'lblSublot
        '
        Me.lblSublot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSublot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSublot.Location = New System.Drawing.Point(646, 48)
        Me.lblSublot.Name = "lblSublot"
        Me.lblSublot.Size = New System.Drawing.Size(131, 24)
        Me.lblSublot.TabIndex = 125
        '
        'lblSpecie
        '
        Me.lblSpecie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpecie.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecie.Location = New System.Drawing.Point(937, 48)
        Me.lblSpecie.Name = "lblSpecie"
        Me.lblSpecie.Size = New System.Drawing.Size(164, 24)
        Me.lblSpecie.TabIndex = 127
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(842, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Specie"
        '
        'lblUnloading
        '
        Me.lblUnloading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnloading.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnloading.Location = New System.Drawing.Point(937, 81)
        Me.lblUnloading.Name = "lblUnloading"
        Me.lblUnloading.Size = New System.Drawing.Size(167, 24)
        Me.lblUnloading.TabIndex = 129
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(842, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Unloading Date"
        '
        'grid
        '
        Me.grid.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.grid.AllowColMove = False
        Me.grid.Caption = ""
        Me.grid.CaptionHeight = 17
        Me.grid.CaptionStyle = Style1
        Me.grid.ColumnCaptionHeight = 17
        Me.grid.ColumnFooterHeight = 17
        Me.grid.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.grid.EvenRowStyle = Style2
        Me.grid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.FooterStyle = Style3
        Me.grid.HeadingStyle = Style4
        Me.grid.HighLightRowStyle = Style5
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.ItemHeight = 20
        Me.grid.Location = New System.Drawing.Point(12, 108)
        Me.grid.MatchEntryTimeout = CType(2000, Long)
        Me.grid.Name = "grid"
        Me.grid.OddRowStyle = Style6
        Me.grid.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.grid.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.grid.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.grid.SelectedStyle = Style7
        Me.grid.SelectionMode = C1.Win.C1List.SelectionModeEnum.CheckBox
        Me.grid.Size = New System.Drawing.Size(1094, 413)
        Me.grid.Style = Style8
        Me.grid.TabIndex = 130
        Me.grid.Text = "C1List1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'lblSBCount
        '
        Me.lblSBCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSBCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSBCount.Location = New System.Drawing.Point(924, 525)
        Me.lblSBCount.Name = "lblSBCount"
        Me.lblSBCount.Size = New System.Drawing.Size(69, 24)
        Me.lblSBCount.TabIndex = 132
        Me.lblSBCount.Text = "0"
        Me.lblSBCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(826, 529)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Selected Bins"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScBCount
        '
        Me.lblScBCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScBCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScBCount.Location = New System.Drawing.Point(924, 553)
        Me.lblScBCount.Name = "lblScBCount"
        Me.lblScBCount.Size = New System.Drawing.Size(69, 24)
        Me.lblScBCount.TabIndex = 134
        Me.lblScBCount.Text = "0"
        Me.lblScBCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(826, 557)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 16)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Scheduled Bins"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNSCount
        '
        Me.lblNSCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNSCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNSCount.Location = New System.Drawing.Point(924, 581)
        Me.lblNSCount.Name = "lblNSCount"
        Me.lblNSCount.Size = New System.Drawing.Size(69, 24)
        Me.lblNSCount.TabIndex = 136
        Me.lblNSCount.Text = "0"
        Me.lblNSCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(826, 585)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "Non-Scheduled"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNSWeight
        '
        Me.lblNSWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNSWeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNSWeight.Location = New System.Drawing.Point(999, 581)
        Me.lblNSWeight.Name = "lblNSWeight"
        Me.lblNSWeight.Size = New System.Drawing.Size(80, 24)
        Me.lblNSWeight.TabIndex = 139
        Me.lblNSWeight.Text = "0"
        Me.lblNSWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScBWeight
        '
        Me.lblScBWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScBWeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScBWeight.Location = New System.Drawing.Point(999, 553)
        Me.lblScBWeight.Name = "lblScBWeight"
        Me.lblScBWeight.Size = New System.Drawing.Size(80, 24)
        Me.lblScBWeight.TabIndex = 138
        Me.lblScBWeight.Text = "0"
        Me.lblScBWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSBWeight
        '
        Me.lblSBWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSBWeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSBWeight.Location = New System.Drawing.Point(999, 525)
        Me.lblSBWeight.Name = "lblSBWeight"
        Me.lblSBWeight.Size = New System.Drawing.Size(80, 24)
        Me.lblSBWeight.TabIndex = 137
        Me.lblSBWeight.Text = "0"
        Me.lblSBWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1081, 529)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "mt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1081, 557)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 16)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "mt"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1081, 585)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 16)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "mt"
        '
        'grp
        '
        Me.grp.Controls.Add(Me.cmdCancel)
        Me.grp.Controls.Add(Me.cmdSchedule)
        Me.grp.Controls.Add(Me.Label12)
        Me.grp.Controls.Add(Me.Label17)
        Me.grp.Controls.Add(Me.Label14)
        Me.grp.Controls.Add(Me.Label13)
        Me.grp.Controls.Add(Me.txtTime)
        Me.grp.Controls.Add(Me.txtDate)
        Me.grp.Controls.Add(Me.optClear)
        Me.grp.Controls.Add(Me.optSchedule)
        Me.grp.Enabled = False
        Me.grp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(308, 306)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(497, 282)
        Me.grp.TabIndex = 143
        Me.grp.TabStop = False
        Me.grp.Text = "Raw Fish Schedule Time"
        Me.grp.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancel.Location = New System.Drawing.Point(266, 219)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 48)
        Me.cmdCancel.TabIndex = 139
        Me.cmdCancel.Text = "&Close"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSchedule
        '
        Me.cmdSchedule.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSchedule.Image = CType(resources.GetObject("cmdSchedule.Image"), System.Drawing.Image)
        Me.cmdSchedule.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSchedule.Location = New System.Drawing.Point(155, 219)
        Me.cmdSchedule.Name = "cmdSchedule"
        Me.cmdSchedule.Size = New System.Drawing.Size(105, 48)
        Me.cmdSchedule.TabIndex = 138
        Me.cmdSchedule.Text = "&Schedule"
        Me.cmdSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(115, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "Schedule"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(115, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "Operations"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(115, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Time"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(115, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 16)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Date"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTime
        '
        Me.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtTime.Location = New System.Drawing.Point(182, 173)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(200, 23)
        Me.txtTime.TabIndex = 3
        '
        'txtDate
        '
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate.Location = New System.Drawing.Point(182, 144)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(200, 23)
        Me.txtDate.TabIndex = 2
        '
        'optClear
        '
        Me.optClear.AutoSize = True
        Me.optClear.Location = New System.Drawing.Point(182, 80)
        Me.optClear.Name = "optClear"
        Me.optClear.Size = New System.Drawing.Size(120, 20)
        Me.optClear.TabIndex = 1
        Me.optClear.TabStop = True
        Me.optClear.Text = "Clear schedule"
        Me.optClear.UseVisualStyleBackColor = True
        '
        'optSchedule
        '
        Me.optSchedule.AutoSize = True
        Me.optSchedule.Location = New System.Drawing.Point(182, 54)
        Me.optSchedule.Name = "optSchedule"
        Me.optSchedule.Size = New System.Drawing.Size(199, 20)
        Me.optSchedule.TabIndex = 0
        Me.optSchedule.TabStop = True
        Me.optSchedule.Text = "Schedule the selected bins"
        Me.optSchedule.UseVisualStyleBackColor = True
        '
        'frmProductionScheduleDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 610)
        Me.ControlBox = False
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNSWeight)
        Me.Controls.Add(Me.lblScBWeight)
        Me.Controls.Add(Me.lblSBWeight)
        Me.Controls.Add(Me.lblNSCount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblScBCount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSBCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lblUnloading)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSpecie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblSublot)
        Me.Controls.Add(Me.lblLot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblTripCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdViewMap)
        Me.Controls.Add(Me.cmdSet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProductionScheduleDataEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProductionScheduleDataEntry"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdViewMap As System.Windows.Forms.Button
    Friend WithEvents cmdSet As System.Windows.Forms.Button
    Friend WithEvents lblTripCode As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLot As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSublot As System.Windows.Forms.Label
    Friend WithEvents lblSpecie As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblUnloading As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grid As C1.Win.C1List.C1List
    Friend WithEvents lblSBCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblScBCount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblNSCount As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNSWeight As System.Windows.Forms.Label
    Friend WithEvents lblScBWeight As System.Windows.Forms.Label
    Friend WithEvents lblSBWeight As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents txtTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents optClear As System.Windows.Forms.RadioButton
    Friend WithEvents optSchedule As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSchedule As System.Windows.Forms.Button
End Class
