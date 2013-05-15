Public Class frmA
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmA))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'grid
        '
        Me.grid.AllowUpdate = False
        Me.grid.GroupByCaption = "Drag a column header here to group by that column"
        Me.grid.Images.Add(CType(resources.GetObject("grid.Images"), System.Drawing.Image))
        Me.grid.Location = New System.Drawing.Point(532, 44)
        Me.grid.Name = "grid"
        Me.grid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grid.PreviewInfo.ZoomFactor = 75.0R
        Me.grid.PrintInfo.PageSettings = CType(resources.GetObject("grid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grid.Size = New System.Drawing.Size(204, 420)
        Me.grid.TabIndex = 1
        Me.grid.Text = "C1TrueDBGrid1"
        Me.grid.PropBag = resources.GetString("grid.PropBag")
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(158, 192)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(244, 149)
        Me.C1TrueDBGrid1.TabIndex = 2
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'frmA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 485)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmA"
        Me.Text = "frmA"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grid.DataSource = displaySummary.Tables(0)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

        'grid.DataSource = displaySummary.Tables(0)

        ' get count of rows and count of columns
        rowCount = displaySummary.Tables(0).Rows.Count 'objDataSet.Tables(0).Rows.Count()
        colCount = displaySummary.Tables(0).Columns.Count 'objDataSet.Tables(0).Columns.Count()

        ' add the column headings
        excelWorksheet.Range("F1").Value = "D0S0"
        excelWorksheet.Range("F2").Value = "Cases Produced"
        'For col = 0 To colCount - 1
        '    row = 1
        '    cell = GetExcelColumn(col) & row.ToString
        '    'excelWorksheet.Range(cell).Value = grdFieldnetData.TableStyles(0).GridColumnStyles(col).HeaderText
        '    'excelWorksheet.Range(cell).ColumnWidth = grdFieldnetData.TableStyles(0).GridColumnStyles(col).Width / 4
        'Next

        ' now add the data elements
        For row = 0 To rowCount - 1
            rowcell = row + 3
            For col = 0 To colCount - 1
                cell = GetExcelColumn(col) & rowcell.ToString
                excelWorksheet.Range(cell).Value = grid.Item(row, col)
            Next
        Next
        ' turn off wait cursor
        Me.Cursor = Cursors.Default

        ' view the spread sheet
        excelApp.Visible = True
    End Sub

    ' Function GetExcelColumn - returns the column reference
    ' from an integer representing a column in a datagrid or dataset
    Function GetExcelColumn(ByVal col As Integer) As String
        Dim result As String
        Select Case col
            Case 0 ' first column
                result = "A"
            Case 1
                result = "B"
            Case 2
                result = "C"
            Case 3
                result = "D"
            Case 4
                result = "E"
            Case 5
                result = "F"
            Case 6
                result = "G"
            Case 7
                result = "H"
            Case 8
                result = "I"
            Case 9
                result = "J"
            Case 10
                result = "K"
            Case 11
                result = "L"
            Case 12
                result = "M"
            Case 13
                result = "N"
            Case 14
                result = "O"
            Case 15
                result = "P"
            Case 16
                result = "Q"
            Case 17
                result = "R"
            Case 18
                result = "S"
            Case 19
                result = "T"
            Case 20
                result = "U"
            Case 21
                result = "V"
            Case 22
                result = "W"
            Case 23
                result = "X"
            Case 24
                result = "Y"
            Case 25
                result = "Z"
        End Select
        Return result
    End Function

    Public Function displaySummary() As DataSet
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand("SELECT lot#, item, qty, unitCost, amount " & _
                " FROM dbo.tbl_tmp_PrintProductCosting_table " & _
                " WHERE (accountCode IN ('5050', '5060', '5051', '1710', '1720', '1730', '1740'))", c)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            Dim d As DataSet = ds

            da.Dispose()
            ds.Dispose()
            c.Close()

            Return d
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Function
End Class
