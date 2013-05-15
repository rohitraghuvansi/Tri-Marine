Public Class frmBinHistory

    Private Sub frmBinHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displayBin()
        displayBinDetails(cboBin.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayBin()
        With cboBin
            .DefColWidth = 137
            .DataSource = getAllFishBins().Tables(0)
        End With
    End Sub

    Public Sub displayBinDetails(ByVal bin As String)
        With grid
            .DataSource = getBinHistory(bin).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 150
            .Splits(0).DisplayColumns(1).Width = 80
            .Splits(0).DisplayColumns(2).Width = 80
            .Splits(0).DisplayColumns(3).Width = 90
            .Splits(0).DisplayColumns(4).Width = 100
            .Splits(0).DisplayColumns(8).Width = 180
            .Splits(0).DisplayColumns(9).Width = 80
            .Splits(0).DisplayColumns(10).Width = 80
            .Splits(0).DisplayColumns(11).Width = 80

            .Columns(5).NumberFormat = "###,###,##0.#0"
            .Columns(6).NumberFormat = "###,###,##0.#0"
            .Columns(7).NumberFormat = "###,###,##0.#0"
        End With
    End Sub

    Private Sub cboBin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBin.TextChanged
        displayBinDetails(cboBin.Text)
    End Sub
End Class
