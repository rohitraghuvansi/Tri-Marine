Public Class frmFishReceiptsReceiving
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
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdNewFR As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdCloseFR As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFishReceiptsReceiving))
        Me.cmdNewFR = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdCloseFR = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNewFR
        '
        Me.cmdNewFR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewFR.Image = CType(resources.GetObject("cmdNewFR.Image"), System.Drawing.Image)
        Me.cmdNewFR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNewFR.Location = New System.Drawing.Point(204, 444)
        Me.cmdNewFR.Name = "cmdNewFR"
        Me.cmdNewFR.Size = New System.Drawing.Size(120, 48)
        Me.cmdNewFR.TabIndex = 2
        Me.cmdNewFR.Text = "&New Receipt"
        Me.cmdNewFR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdView
        '
        Me.cmdView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdView.Location = New System.Drawing.Point(416, 444)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(120, 48)
        Me.cmdView.TabIndex = 4
        Me.cmdView.Text = "&View/ Edit"
        Me.cmdView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.grid.Location = New System.Drawing.Point(8, 48)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.RowHeight = 20
        Me.grid.Size = New System.Drawing.Size(929, 388)
        Me.grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.grid.TabIndex = 1
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(944, 40)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "Fish Receiving - Receipt Lists"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(665, 444)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(332, 444)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 48)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdCloseFR
        '
        Me.cmdCloseFR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseFR.Image = CType(resources.GetObject("cmdCloseFR.Image"), System.Drawing.Image)
        Me.cmdCloseFR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCloseFR.Location = New System.Drawing.Point(542, 444)
        Me.cmdCloseFR.Name = "cmdCloseFR"
        Me.cmdCloseFR.Size = New System.Drawing.Size(117, 48)
        Me.cmdCloseFR.TabIndex = 5
        Me.cmdCloseFR.Text = "Close &Receipts"
        Me.cmdCloseFR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmFishReceiptsReceiving
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(944, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCloseFR)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cmdNewFR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFishReceiptsReceiving"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFishReceiptsReceiving"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFishReceiptsReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displayFishReceivingReceipts()
    End Sub

    Public Sub displayFishReceivingReceipts()
        With grid
            .DataSource = getFishReceivingReceipts().Tables(0)

            .Columns(7).NumberFormat = "###,###,##0.##0"

            .Splits(0).DisplayColumns(0).Width = 80
            .Splits(0).DisplayColumns(1).Width = 80
            .Splits(0).DisplayColumns(2).Width = 80
            .Splits(0).DisplayColumns(3).Width = 80
            .Splits(0).DisplayColumns(4).Width = 180
            .Splits(0).DisplayColumns(5).Width = 180
            .Splits(0).DisplayColumns(6).Width = 70
            .Splits(0).DisplayColumns(7).Width = 80
            .Splits(0).DisplayColumns(8).Width = 50

            displayQuantity()
        End With
    End Sub

    Private Sub cmdNewFR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewFR.Click
        Dim f As New frmFishReceipts
        f.displayFR()
        f.ShowDialog(Me)
        displayFishReceivingReceipts()

        displayQuantity()

        grid.Focus()
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        With grid
            If .RowCount > 0 Then

                Dim f As New frmFishDeposit_DataEntry4
                If grid.RowCount > 0 Then
                    f.depositDateAndTime = grid.Item(grid.Row, 0)
                    f.lblReceipt.Text = grid.Item(grid.Row, 2)
                    f.lblTripCode.Text = grid.Item(grid.Row, 4)
                    f.lblVessel.Text = grid.Item(grid.Row, 5)
                    f.displayReceiptDetails(f.lblReceipt.Text)

                    If CStr(.Item(.Row, 8)).Contains("Open") Then
                        f.enableUI(True)
                    Else
                        'MsgBox("Fish Reciepts already closed", MsgBoxStyle.Critical, "Warning")
                        'grid.Focus()
                        f.enableUI(False)
                    End If

                    f.ShowDialog(Me)
                    displayQuantity()

                End If
            End If
        End With

        grid.Focus()
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        displayQuantity()

        If grid.RowCount > 0 Then
            If validateUser(grid.Item(grid.Row, 3)) Then
                cmdDelete.Enabled = True
                cmdView.Enabled = True
                cmdCloseFR.Enabled = True
            Else
                cmdDelete.Enabled = False
                cmdView.Enabled = False
                cmdCloseFR.Enabled = False
            End If
        End If
    End Sub

    Public Sub displayQuantity()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                .Item(ctr, 6) = getFishReceiptSummary(.Item(ctr, 2), True)
                .Item(ctr, 7) = Format(CDbl(getFishReceiptSummary(.Item(ctr, 2), False)), "###,##0.##0")

                ctr += 1
            End While
        End With
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        With grid
            If .RowCount > 0 Then
                If CInt(getFishReceiptSummary(.Item(.Row, 2), True)) = 0 Then
                    Dim reply As String = MsgBox("Are you sure you want to delete this receipt number?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    If reply = vbYes Then
                        deleteFishReceipts(.Item(.Row, 2))
                        displayFishReceivingReceipts()
                        MsgBox("You have successfully delete the receipt number", MsgBoxStyle.Information, "Information")
                    End If
                Else
                    MsgBox("You can't delete a receipt if it is not empty", MsgBoxStyle.Exclamation, "Warning")
                End If
            Else
                MsgBox("Please identify what's the fish receipt number", MsgBoxStyle.Exclamation, "Warning")
                grid.Focus()
            End If
        End With

        grid.Focus()
    End Sub

    Public Function validateUser(ByVal user As String) As Boolean
        If getUsername() = user Or getUsername() = "admin" Or getUsername() = "csmgr" Or getUsername() = "solo" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdCloseFR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseFR.Click
        With grid
            If .RowCount > 0 Then
                Dim reply As String
                reply = MsgBox("Are you sure you want to close this fish receipts number?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    updateFRStatus(.Item(.Row, 2), "Closed")
                    displayFishReceivingReceipts()

                    MsgBox("Fish Receipt Number is successfully closed", MsgBoxStyle.Information, "Information")
                    grid.Focus()
                End If
            End If
        End With

        grid.Focus()
    End Sub
End Class
