Public Class frmProductionScheduleListing

    Private Sub frmProductionScheduleListing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()

        displayScheduleState()
        displayQAStatus()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayLotView(ByVal category As String)
        With grid
            'If category.Contains("All") Then
            '.DataSource = getAllFishDepositDetails(category).Tables(0)
            'ElseIf category.Contains("Schedule") Then

            .DataSource = getAllFishDepositDetails(category).Tables(0)

            'End If

            .Columns(7).NumberFormat = "###,###,##0.#0"
            .Columns(8).NumberFormat = "###,###,##0.#0"

            .Refresh()

            .Splits(0).DisplayColumns(2).Width = 70
            .Splits(0).DisplayColumns(5).Width = 110
            .Splits(0).DisplayColumns(8).Width = 115

            'displayUnloadingDate()

        End With
    End Sub

    Public Sub displayScheduleState()
        With cboState
            .Text = ""
            .DefColWidth = 183
            .AddItemTitles("State")
            .AddItem("All Bins")
            .AddItem("Non-Scheduled")
            .AddItem("Scheduled")

            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayQAStatus()
        With cboStatus
            .Text = ""
            .DefColWidth = 183
            .AddItemTitles("Status")
            .AddItem("Approved")
            .AddItem("Pending")
        End With
    End Sub

    Private Sub cboState_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboState.TextChanged
        displayLotView(cboState.Text)
    End Sub

    Private Sub cmdViewBins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewBins.Click
        Dim f As New frmProductionScheduleDataEntry
        With grid
            If .RowCount > 0 Then
                f.lblTripCode.Text = .Item(.Row, 1)
                f.lblLot.Text = .Item(.Row, 2)
                f.lblSublot.Text = .Item(.Row, 4)
                f.lblSpecie.Text = .Item(.Row, 3)
                f.lblUnloading.Text = .Item(.Row, 0)
                f.lblRemarks.Text = .Item(.Row, 10)

                f.displayTrans(f.lblTripCode.Text, f.lblLot.Text, f.lblSublot.Text, f.lblSpecie.Text, .Item(.Row, 5))
            End If
        End With

        f.ShowDialog()

        displayLotView(cboState.Text)
    End Sub
End Class