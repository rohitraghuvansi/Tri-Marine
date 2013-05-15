Public Class frmInqFishBinSettlement

    Private Sub frmInqFishBinSettlement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displayFishLot()
        displayLotDetails(cboLot.Text)
    End Sub

    Public Sub displayFishLot()
        With cboLot
            .DefColWidth = 187
            .DataSource = getBatchlots().Tables(0)
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        displayLotDetails(cboLot.Text)

        ' display wait cursor
        Me.Cursor = Cursors.WaitCursor
        ' various variables
        Dim row As Integer
        Dim col As Integer
        Dim rowCount As Integer
        Dim colCount As Integer
        Dim cell As String
        Dim rowcell As Integer

        ' Excel Variables
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = _
            CType(excelBook.Worksheets(1), Excel.Worksheet)

        'gridMaterials.DataSource = displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0)

        ' get count of rows and count of columns
        rowCount = grid.RowCount  'objDataSet.Tables(0).Rows.Count()
        colCount = grid.Columns.Count  'displaySummary.Tables(0).Columns.Count 'objDataSet.Tables(0).Columns.Count()

        excelWorksheet.Range("A1").Value = "Lot No"
        excelWorksheet.Range("B1").Value = "Sublot"
        excelWorksheet.Range("C1").Value = "Bin No."
        excelWorksheet.Range("D1").Value = "Fish Species"
        excelWorksheet.Range("E1").Value = "Fish Sizes"
        excelWorksheet.Range("F1").Value = "GW"
        excelWorksheet.Range("G1").Value = "TW"
        excelWorksheet.Range("H1").Value = "NW"
        excelWorksheet.Range("I1").Value = "Date Processed"


        ' now add the data elements
        For row = 0 To rowCount - 1
            rowcell = row + 2

            For col = 0 To colCount - 1 '(grid.RowCount + displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0).Columns.Count) - 1  'colCount - 1
                cell = GetExcelColumn(col) '& rowcell.ToString

                excelWorksheet.Range(cell & rowcell.ToString).Value = grid.Item(row, col)  ' gridMaterials.Item(row, col)
            Next
        Next

        ' turn off wait cursor
        Me.Cursor = Cursors.Default

        ' view the spread sheet
        excelApp.Visible = True
    End Sub

    Public Sub displayLotDetails(ByVal lot As String)
        With grid
            .DataSource = getLotBinDetailsSettlement(lot).Tables(0)
            .Columns(5).NumberFormat = "###,###.#0"
            .Columns(6).NumberFormat = "###,###.#0"
            .Columns(7).NumberFormat = "###,###.#0"

            .Splits(0).DisplayColumns(0).Width = 150
            .Splits(0).DisplayColumns(1).Width = 60
            .Splits(0).DisplayColumns(4).Width = 110
            .Splits(0).DisplayColumns(6).Width = 70

            displayLotDetails()
        End With
    End Sub

    Public Sub displayLotDetails()
        Dim ctr As Integer
        With grid
            While ctr < .RowCount
                .Item(ctr, 8) = getFishLotBinProcessed(.Item(ctr, 0), .Item(ctr, 2))

                ctr += 1
            End While
        End With
    End Sub
End Class