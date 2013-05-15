Imports CrystalDecisions.CrystalReports.Engine

Public Class frmPrintColdStorageMetrics

    Private Sub frmPrintColdStorageMetrics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsPrintColdStorageMetrics.proc_report_PrintColdStorageMetrics' table. You can move, or remove it, as needed.
        Me.Text = getSystemTitle()
        displayColdStorage()
        Me.rptControl.RefreshReport()
    End Sub

    Public Sub displayColdStorage()
        With cboRm
            .DataSource = modModule.getColdStorage().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 175

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayCSDetails(ByVal cs As String)
        lblTotalSpaces.Text = getCS_TotalSpaces(cs)
        lblTotalReserved.Text = getCS_Blockage(cs, "RESERVED")
        lblTotalBlocked.Text = getCS_Blockage(cs, "BLOCKED")
        lblTotalOccupied.Text = getCS_Occupied(cs)

        lblAvailable.Text = CInt(lblTotalSpaces.Text) - CInt(lblTotalOccupied.Text) - CInt(lblTotalReserved.Text) - CInt(lblTotalBlocked.Text)

        delete_PrintColdStorageMetrics()
        saveNewPrintColdStorageMetrics(cboRm.Text, lblTotalSpaces.Text, lblTotalOccupied.Text, lblTotalReserved.Text, lblTotalBlocked.Text)
        printReport()
    End Sub

    Private Sub cboRm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRm.TextChanged
        displayCSDetails(cboRm.Text)
    End Sub

    Public Sub printReport()
        Dim rpt As New rptPrintColdStorageMetrics
        rpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        rpt.Load()
        rpt.SetDataSource(printColdStorageMetrics().Tables(0))

        rptControl.ReportSource = rpt
    End Sub

End Class