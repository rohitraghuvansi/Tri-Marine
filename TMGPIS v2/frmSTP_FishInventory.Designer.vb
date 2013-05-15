<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSTP_FishInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSTP_FishInventory))
        Me.optInventory = New System.Windows.Forms.RadioButton()
        Me.optTransaction = New System.Windows.Forms.RadioButton()
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optInventory
        '
        Me.optInventory.AutoSize = True
        Me.optInventory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optInventory.Location = New System.Drawing.Point(13, 59)
        Me.optInventory.Name = "optInventory"
        Me.optInventory.Size = New System.Drawing.Size(144, 20)
        Me.optInventory.TabIndex = 0
        Me.optInventory.TabStop = True
        Me.optInventory.Text = "Freezer Inventory"
        Me.optInventory.UseVisualStyleBackColor = True
        '
        'optTransaction
        '
        Me.optTransaction.AutoSize = True
        Me.optTransaction.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTransaction.Location = New System.Drawing.Point(13, 88)
        Me.optTransaction.Name = "optTransaction"
        Me.optTransaction.Size = New System.Drawing.Size(155, 20)
        Me.optTransaction.TabIndex = 1
        Me.optTransaction.TabStop = True
        Me.optTransaction.Text = "Freezer Transaction"
        Me.optTransaction.UseVisualStyleBackColor = True
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Enabled = False
        Me.txtDateFrom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.Location = New System.Drawing.Point(193, 88)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(144, 23)
        Me.txtDateFrom.TabIndex = 2
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDateTo
        '
        Me.txtDateTo.Enabled = False
        Me.txtDateTo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.Location = New System.Drawing.Point(193, 117)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(144, 23)
        Me.txtDateTo.TabIndex = 3
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Image = CType(resources.GetObject("cmdGenerate.Image"), System.Drawing.Image)
        Me.cmdGenerate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGenerate.Location = New System.Drawing.Point(354, 47)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(99, 45)
        Me.cmdGenerate.TabIndex = 4
        Me.cmdGenerate.Text = "&Generate"
        Me.cmdGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(354, 98)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(99, 45)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowColMove = False
        Me.grid.AllowUpdate = False
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(6, 156)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.Size = New System.Drawing.Size(624, 261)
        Me.grid.TabIndex = 6
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
        Me.Label1.Size = New System.Drawing.Size(463, 40)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Cold Storage Transaction"
        '
        'frmSTP_FishInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.optTransaction)
        Me.Controls.Add(Me.optInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSTP_FishInventory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSTP_FishInventory"
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optInventory As System.Windows.Forms.RadioButton
    Friend WithEvents optTransaction As System.Windows.Forms.RadioButton
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
