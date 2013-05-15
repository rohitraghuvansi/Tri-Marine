Public Class frmSTP_FishInventory

    Private Sub frmSTP_FishInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDateFrom.Value = getServerDateTime()
        txtDateTo.Value = getServerDateTime()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub optInventory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optInventory.CheckedChanged
        enableDataEntry()
    End Sub

    Public Sub enableDataEntry()
        If optInventory.Checked = True Then
            txtDateFrom.Enabled = False
            txtDateTo.Enabled = False
        Else
            txtDateFrom.Enabled = True
            txtDateTo.Enabled = True
            txtDateFrom.SelectAll()
            txtDateFrom.Focus()
        End If
    End Sub

    Private Sub optTransaction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTransaction.CheckedChanged
        enableDataEntry()
    End Sub

    Public Sub generateReport(ByVal category As String)
        With grid
            .DataSource = getSTP_FishInventory(txtDateFrom.Text, txtDateTo.Text, category).Tables(0)
        End With

        generateExcel()
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        If optInventory.Checked = True Then
            generateReport("inventory")
        Else
            generateReport("transaction")
        End If
    End Sub

    Public Sub generateExcel()
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

        ' get count of rows and count of columns
        rowCount = grid.RowCount  'objDataSet.Tables(0).Rows.Count()
        colCount = grid.Columns.Count  'displaySummary.Tables(0).Columns.Count 'objDataSet.Tables(0).Columns.Count()

        ' add the column headings
        ''''excelWorksheet.Range("F1").Value = "D0S0"
        ''''excelWorksheet.Range("F2").Value = "Cases Produced"
        ''''For col = 0 To colCount - 1
        ''''    row = 1
        ''''    cell = GetExcelColumn(col) & row.ToString
        ''''    excelWorksheet.Range(cell).Value = grid.Splits(0).GridColumnStyles(col).HeaderText
        ''''    excelWorksheet.Range(cell).ColumnWidth = grid.TableStyles(0).GridColumnStyles(col).Width / 4
        ''''Next
        'Dim ctr As Integer
        'col = 5
        'While ctr < grid.RowCount
        '    If col = 25 Then col = 0
        '    If col > 24 Then
        '        cell = GetExcelColumn("A" & col) '& "1"
        '    Else
        '        cell = GetExcelColumn(col) '& "1"
        '    End If
        excelWorksheet.Range("A1").Value = "Date Unloaded"
        excelWorksheet.Range("B1").Value = "Receipt No."
        excelWorksheet.Range("C1").Value = "Trip Code"
        excelWorksheet.Range("D1").Value = "Bin No."
        excelWorksheet.Range("E1").Value = "Lot ID"
        excelWorksheet.Range("F1").Value = "Fish Species"
        excelWorksheet.Range("G1").Value = "Fish Sizes"
        excelWorksheet.Range("H1").Value = "TonsIN"
        excelWorksheet.Range("I1").Value = "Date Out"
        excelWorksheet.Range("J1").Value = "TonsOUT"
        excelWorksheet.Range("K1").Value = "Days"

        '    col += 1
        '    ctr += 1
        'End While


        ' now add the data elements
        For row = 0 To rowCount - 1
            rowcell = row + 2

            For col = 0 To colCount - 1 '(grid.RowCount + displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0).Columns.Count) - 1  'colCount - 1
                'If col = 25 Then col = 0
                'If col > 24 Then
                '    cell = GetExcelColumn("A" & col) '& rowcell.ToString
                'Else
                cell = GetExcelColumn(col) '& rowcell.ToString
                'End If

                'If col < displaySummary(txtProdnDate.Text, cboShift.Text).Tables(0).Columns.Count Then

                excelWorksheet.Range(cell & rowcell.ToString).Value = grid.Item(row, col)  ' gridMaterials.Item(row, col)
            Next
        Next

        ' turn off wait cursor
        Me.Cursor = Cursors.Default

        ' view the spread sheet
        excelApp.Visible = True
    End Sub
End Class