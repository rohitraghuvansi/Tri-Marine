Public Class frmLabeling_DataEntry2

    Dim prevRecord As Integer

    Private Sub frmLabeling_DataEntry2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtDate.Value = getServerDateTime()
        initializeShift()

        'displayPallet()
        displayBuyer()
        displayLabels()
        displayCartons()
        displayWarehouse()
        displayLoinGrade()

        displayPalletDetails(lblPallet.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub initializeShift()
        With cboShift
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Shift")
            .AddItem("Day")
            .AddItem("Night")
            .Splits(0).DisplayColumns(0).Width = 120
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayBuyer()
        With cboBuyer
            .DataSource = modModule.getAllBuyer().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 200
        End With
    End Sub

    Public Sub displayLoinGrade()
        With cboGrade
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .AddItemTitles("Loin Grade")
            .AddItem("PU")
            .AddItem("BU")
            .AddItem("SU")
            .Splits(0).DisplayColumns(0).Width = 120
            '.SelectedIndex = 0
        End With
    End Sub

    Public Sub displayLabels()
        With cboLabel
            .DataSource = modModule.getLabels().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 307
        End With
    End Sub

    Public Sub displayCartons()
        With cboCarton
            .DataSource = modModule.getAllMaterials_ByCategory("Cartons").Tables(0)
            .Splits(0).DisplayColumns(0).Width = 307
        End With
    End Sub

    Public Sub displayWarehouse()
        With cboWarehouse
            .DataSource = modModule.getWarehouse().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 307

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayPalletDetails(ByVal pallet As String)
        With grid
            .DataSource = modModule.getPalletDetails(pallet).Tables(0)
            .Columns(1).DropDown = cboPShift
            .Columns(3).DropDown = cboPLot
            .Columns(4).DropDown = cboSublot
            .Columns(5).DropDown = cboPCode
            '.Columns(6).DropDown = cboPCode2
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Splits(0).DisplayColumns(3).DropDownList = True
            .Splits(0).DisplayColumns(4).DropDownList = True
            .Splits(0).DisplayColumns(5).DropDownList = True
            .Splits(0).DisplayColumns(6).DropDownList = True

            .Splits(0).DisplayColumns(0).Width = 85 '100
            .Splits(0).DisplayColumns(1).Width = 40 '65
            .Splits(0).DisplayColumns(2).Width = 60 '65
            .Splits(0).DisplayColumns(3).Width = 60 '90
            .Splits(0).DisplayColumns(4).Width = 90 '90
            .Splits(0).DisplayColumns(5).Width = 85
            .Splits(0).DisplayColumns(6).Width = 70    '5
            .Splits(0).DisplayColumns(7).Width = 80    '5
            .Splits(0).DisplayColumns(8).Width = 75
            .Splits(0).DisplayColumns(9).Width = 40
            .Splits(0).DisplayColumns(10).Width = 140
            .Splits(0).DisplayColumns(11).Width = 85

            .Splits(0).DisplayColumns(11).Locked = True                  '5
            .Splits(0).DisplayColumns(11).Style.BackColor = Color.Gray   '5

            .Columns(0).NumberFormat = "dd/MM/yyyy"
            .Columns(0).DefaultValue = Format(getServerDateTime(), "dd/MM/yyyy")
            .Columns(1).DefaultValue = ""
            .Columns(7).DefaultValue = 0
            .Columns(7).NumberFormat = "#####0"
            .Columns(8).DefaultValue = 0
            .Columns(8).NumberFormat = "##0"
            .Columns(11).NumberFormat = "dd/MM/yyyy"

            computeWeights()
        End With
    End Sub

    Public Sub computeWeights()
        Dim ctr As Integer
        Dim total, tinsPerCase As Double
        Dim prodnDate, pCode As String
        With grid
            If identifyProduct() = "FZ" Then
                While ctr < .RowCount
                    Try
                        If .Item(ctr, 0) Is DBNull.Value Then
                            prodnDate = Format(CDate(getServerDateTime()), getTimeFormat())
                        Else
                            prodnDate = .Item(ctr, 0)
                        End If

                        If .Item(ctr, 5) Is DBNull.Value Then
                            pCode = ""
                        Else
                            pCode = .Item(ctr, 5)
                        End If
                    Catch
                        If .Item(ctr, 0) = "" Then
                            prodnDate = Format(CDate(getServerDateTime()), getTimeFormat())
                        Else
                            prodnDate = .Item(ctr, 0)
                        End If

                        If .Item(ctr, 5) = "" Then
                            pCode = ""
                        Else
                            pCode = .Item(ctr, 5)
                        End If
                    End Try

                    tinsPerCase = getCanSize_tinsPerCase(pCode)

                    'total += (.Item(ctr, 6) * tinsPerCase) + .Item(ctr, 7) '* 
                    'total *= (getActualAverageFW(prodnDate, prodnDate, pCode) / 1000)

                    total = getTotalBags() * (getActualAverageFW(prodnDate, prodnDate, pCode) / 1000)

                    ctr += 1
                End While

                txtGW.Text = Format(total + getTare(pCode), "###,##0.#0")    'getPalletTare
                txtNW.Text = Format(total, "###,##0.#0") '(getActualAverageFW(prodnDate, prodnDate, pCode) / 1000)  'total
            Else
                txtGW.Text = "0"
                txtNW.Text = "0"
            End If
        End With
    End Sub

    Public Function getTare(ByVal pCode As String) As Double
        If getProductSpecie(pCode).StartsWith("Albacore") Then
            If getTotalBags() <= 54 Then
                Return 44
            Else
                Return 52
            End If
        Else
            Return getPalletTare()
        End If
    End Function

    Public Function getTotalBags() As Double
        Dim ctr As Integer
        Dim totalBags As Double
        With grid
            While ctr < .RowCount
                If CStr(.Item(ctr, 5)).StartsWith("LA") Or CStr(.Item(ctr, 5)).StartsWith("FA") Then
                    totalBags = totalBags + (.Item(ctr, 7) + .Item(ctr, 8))
                Else
                    totalBags = totalBags + ((.Item(ctr, 7) * getCansPerCase(getProductCanSize(.Item(ctr, 5)), "CAN SIZE")) + .Item(ctr, 8))
                End If

                ctr += 1
            End While
        End With

        Return totalBags
    End Function

    Public Function identifyProduct() As String
        Dim loins As Boolean
        With grid
            Dim ctr As Integer
            While ctr < .RowCount
                If Not .Item(ctr, 5) Is DBNull.Value Then
                    If CStr(.Item(ctr, 5)).StartsWith("L") Or CStr(.Item(ctr, 5)).StartsWith("F") Or CStr(.Item(ctr, 5)).StartsWith("R") Then
                        loins = True
                    Else
                        loins = False
                    End If
                Else
                    loins = False
                End If

                ctr += 1
            End While
        End With

        If loins Then
            'cboGrade.SelectedIndex = 0
            'cboGrade.ReadOnly = False
            Return "FZ"
        Else
            'cboGrade.Text = ""
            'cboGrade.ReadOnly = True
            Return "CN"
        End If
    End Function

    Public Sub displayProductDetails()
        Dim ctr, toAddCases As Integer
        Dim cases, tins As Double
        Dim shift, pCode, subCode, lot, sublot, julian As String
        Dim prodnDate As DateTime

        With grid
            'While ctr < .RowCount
            ctr = .Row ' prevRecord

            If Not .Item(ctr, 0) Is DBNull.Value And Not CStr(.Item(ctr, 0)) = "" Then
                Try
                    If .Item(ctr, 0) Is DBNull.Value Then
                        julian = "0"
                        prodnDate = getServerDateTime()
                    Else
                        julian = CDate(.Item(ctr, 0)).DayOfYear
                        prodnDate = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) Is DBNull.Value Then
                        shift = ""
                    Else
                        shift = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 3) Is DBNull.Value Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 4) Is DBNull.Value Then
                        sublot = ""
                    Else
                        sublot = .Item(ctr, 4)
                    End If

                    If .Item(ctr, 5) Is DBNull.Value Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 5)
                    End If

                    If .Item(ctr, 6) Is DBNull.Value Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 6)
                    End If

                    If .Item(ctr, 7) Is DBNull.Value Then   '6
                        cases = 0
                    Else
                        cases = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 8) Is DBNull.Value Then   '7
                        tins = 0
                    Else
                        tins = .Item(ctr, 8)
                    End If
                Catch e As Exception
                    If CStr(.Item(ctr, 0)) = "" Then
                        julian = "0"
                        prodnDate = getServerDateTime()
                    Else
                        julian = CDate(.Item(ctr, 0)).DayOfYear
                        prodnDate = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) = "" Then
                        shift = ""
                    Else
                        shift = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 3) = "" Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 4) = "" Then
                        sublot = ""
                    Else
                        sublot = .Item(ctr, 4)
                    End If

                    If .Item(ctr, 5) = "" Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 5)
                    End If

                    If .Item(ctr, 6) = "" Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 6)
                    End If

                    If .Item(ctr, 7) = "" Then  '6
                        cases = 0
                    Else
                        cases = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 8) = "" Then  '7
                        tins = 0
                    Else
                        tins = .Item(ctr, 8)
                    End If
                End Try

                'CHANGES ALSO NOT AVAILABLE TO OIS V2.8 BUT ONLY TO OIS V1.1.0.5 NEW RELEASE
                cboPShift.DefColWidth = 93
                cboPShift.DataSource = displayFishWithdrawalDetails_ForLabeling(pCode, subCode, lot, prodnDate, shift, "shift", sublot).Tables(0)
                If cboPShift.RowCount <= 0 Then
                    .Item(ctr, 1) = ""
                End If

                cboPLot.DefColWidth = 93
                cboPLot.DataSource = displayFishWithdrawalDetails_ForLabeling(pCode, subCode, lot, prodnDate, shift, "lot", sublot).Tables(0)
                If cboPLot.RowCount <= 0 Then
                    .Item(ctr, 3) = ""
                End If

                cboSublot.DefColWidth = 93
                cboSublot.DataSource = displayFishWithdrawalDetails_ForLabeling(pCode, subCode, lot, prodnDate, shift, "sublot", sublot).Tables(0)
                If cboSublot.RowCount <= 0 Then
                    .Item(ctr, 4) = ""
                End If

                cboPCode.DefColWidth = 93
                cboPCode.DataSource = getProductCode().Tables(0)  'displayProductOutputShift(pCode, subCode, lot, prodnDate, shift, "pCode", sublot).Tables(0)
                If cboPCode.RowCount <= 0 Then
                    .Item(ctr, 5) = ""
                End If

                'cboPCode2.DefColWidth = 93
                'cboPCode2.DataSource = displayProductOutputShift(pCode, subCode, lot, prodnDate, shift, "pCode2", sublot).Tables(0)
                'If cboPCode2.RowCount <= 0 Then
                '    .Item(ctr, 6) = ""
                'End If

                Try
                    If .Item(ctr, 0) Is DBNull.Value Then
                        julian = "0"
                        prodnDate = getServerDateTime()
                    Else
                        julian = CDate(.Item(ctr, 0)).DayOfYear
                        prodnDate = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) Is DBNull.Value Then
                        shift = ""
                    Else
                        shift = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 3) Is DBNull.Value Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 4) Is DBNull.Value Then
                        sublot = ""
                    Else
                        sublot = .Item(ctr, 4)
                    End If

                    If .Item(ctr, 5) Is DBNull.Value Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 5)
                    End If

                    If .Item(ctr, 6) Is DBNull.Value Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 6)
                    End If

                    If .Item(ctr, 7) Is DBNull.Value Then   '6
                        cases = 0
                    Else
                        cases = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 8) Is DBNull.Value Then   '7
                        tins = 0
                    Else
                        tins = .Item(ctr, 8)
                    End If
                Catch e As Exception
                    If CStr(.Item(ctr, 0)) = "" Then
                        julian = "0"
                        prodnDate = getServerDateTime()
                    Else
                        julian = CDate(.Item(ctr, 0)).DayOfYear
                        prodnDate = .Item(ctr, 0)
                    End If

                    If .Item(ctr, 1) = "" Then
                        shift = ""
                    Else
                        shift = .Item(ctr, 1)
                    End If

                    If .Item(ctr, 3) = "" Then
                        lot = ""
                    Else
                        lot = .Item(ctr, 3)
                    End If

                    If .Item(ctr, 4) = "" Then
                        sublot = ""
                    Else
                        sublot = .Item(ctr, 4)
                    End If

                    If .Item(ctr, 5) = "" Then
                        pCode = ""
                    Else
                        pCode = .Item(ctr, 5)
                    End If

                    If .Item(ctr, 6) = "" Then
                        subCode = ""
                    Else
                        subCode = .Item(ctr, 6)
                    End If

                    If .Item(ctr, 7) = "" Then  '6
                        cases = 0
                    Else
                        cases = .Item(ctr, 7)
                    End If

                    If .Item(ctr, 8) = "" Then  '7
                        tins = 0
                    Else
                        tins = .Item(ctr, 8)
                    End If
                End Try

                '.Item(ctr, 11) = getProductOutputShift(pCode, subCode, lot, prodnDate, shift, "bbe", sublot)
                If CStr(getProductCategory(pCode)).StartsWith("Can") Then
                    .Item(ctr, 11) = CDate(prodnDate).AddYears(3)       '4
                Else
                    .Item(ctr, 11) = CDate(prodnDate).AddYears(1)       '4
                End If

                Try
                    If getCansPerCase(getProductCanSize(pCode), "CAN SIZE") > 0 Then  'getProductCansPerCase(julian, lot, pCode)
                        If tins >= getCansPerCase(getProductCanSize(pCode), "CAN SIZE") Then    'getProductCansPerCase(julian, lot, pCode)
                            'MsgBox("No. of cans is allowed only up to " & getLabelPerCase(cboLabel.Text) & " cans per case for " & cboLabel.Text, MsgBoxStyle.Exclamation, "Warning")

                            toAddCases = (tins \ getCansPerCase(getProductCanSize(pCode), "CAN SIZE"))  'getProductCansPerCase(julian, lot, pCode)
                            'toAddCases = toAddCases

                            .Item(ctr, 7) = cases + toAddCases
                            .Item(ctr, 8) = (tins Mod getCansPerCase(getProductCanSize(pCode), "CAN SIZE"))    'getProductCansPerCase(julian, lot, pCode)
                        End If
                    End If
                Catch ex As Exception
                    If getCansPerCase(getProductCanSize(pCode), "CAN SIZE") > 0 Then    'getProductCansPerCase(julian, lot, pCode)
                        If tins >= getCansPerCase(getProductCanSize(pCode), "CAN SIZE") Then    'getProductCansPerCase(julian, lot, pCode)
                            'MsgBox("No. of cans is allowed only up to " & getLabelPerCase(cboLabel.Text) & " cans per case for " & cboLabel.Text, MsgBoxStyle.Exclamation, "Warning")

                            toAddCases = (tins \ getCansPerCase(getProductCanSize(pCode), "CAN SIZE"))  'getProductCansPerCase(julian, lot, pCode)
                            'toAddCases = System.Math.Round(toAddCases, 0)

                            .Item(ctr, 7) = cases + toAddCases
                            .Item(ctr, 8) = (tins Mod getCansPerCase(getProductCanSize(pCode), "CAN SIZE")) 'getProductCansPerCase(julian, lot, pCode)
                        End If
                    End If
                End Try

                'ctr += 1
                'End While
            End If
        End With
    End Sub

    Private Sub grid_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.Change
        prevRecord = grid.RowCount
        lblPrevRecord.Text = prevRecord
    End Sub

    Private Sub grid_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grid.RowColChange
        displayProductDetails()
        computeWeights()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Pallet Tags"
        f.searchType = 1
        f.displayAllPalletTags()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblPallet.Text = .Item(.Row, 2)
                searchPalletDetails(lblPallet.Text)
                displayPalletDetails(lblPallet.Text)
            End If
        End With
    End Sub

    Public Sub searchPalletDetails(ByVal pallet As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getPalletDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@pallet#"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = pallet

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    txtDate.Value = dr.GetDateTime(0)
                    cboShift.Text = dr.GetString(1)
                    cboLabel.Text = dr.GetString(2)
                    cboWarehouse.Text = dr.GetString(3)
                    cboCarton.Text = dr.GetString(4)
                    If dr.GetString(5) = "Yes" Then
                        chkUnlabel.Checked = True
                    Else
                        chkUnlabel.Checked = False
                    End If
                    cboBuyer.Text = dr.GetString(6)
                    txtEU.Text = dr.GetString(7)
                    cboGrade.Text = dr.GetString(8)
                    txtGW.Text = Format(dr.GetDouble(9), "###,##0.#0")
                    txtNW.Text = Format(dr.GetDouble(10), "###,##0.#0")
                    txtRemarks.Text = dr.GetString(11)
                Else
                    txtDate.Value = getServerDateTime()
                    cboShift.SelectedIndex = 0
                    cboLabel.Text = ""
                    cboWarehouse.Text = ""
                    cboCarton.Text = ""
                    chkUnlabel.Checked = False
                    cboBuyer.Text = ""
                    txtEU.Text = "EU No. SI-02-01-001"
                    cboGrade.Text = ""
                    txtGW.Text = "0.00"
                    txtNW.Text = "0.00"
                    txtRemarks.Text = ""
                End If
            Else
                txtDate.Value = getServerDateTime()
                cboShift.SelectedIndex = 0
                cboLabel.Text = ""
                cboWarehouse.Text = ""
                cboCarton.Text = ""
                chkUnlabel.Checked = False
                cboBuyer.Text = ""
                txtEU.Text = "EU No. SI-02-01-001"
                cboGrade.Text = ""
                txtGW.Text = "0.00"
                txtNW.Text = "0.00"
                txtRemarks.Text = ""
            End If

            'calculateWeights()
            dr.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        txtDate.Value = getServerDateTime()
        cboShift.SelectedIndex = 0
        lblPallet.Text = ""
        cboBuyer.Text = ""
        txtEU.Text = "EU No. SI-02-01-001"
        'displayPallet()
        cboLabel.Text = ""
        displayLabels()
        cboCarton.Text = ""
        displayCartons()
        cboGrade.Text = ""
        cboWarehouse.Text = ""
        displayWarehouse()
        displayPalletDetails(lblPallet.Text)
        txtGW.Text = "0"
        txtNW.Text = "0"
        txtRemarks.Text = ""

        txtDate.SelectAll()
        txtDate.Focus()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim f As New frmPrintLabeling
        'f.txtDate.Value = txtDate.Text
        'f.cboShift.Text = cboShift.Text
        'f.initializeShift()
        'f.ShowDialog(Me)
        Dim f As New frmPrintPalletTag
        f.pallet = lblPallet.Text
        f.productType = identifyProduct()
        f.rptReport.ShowPrintButton = False
        f.displayReport(lblPallet.Text, identifyProduct())
        f.ShowDialog(Me)
    End Sub

    Private Sub cboLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLabel.TextChanged
        If cboLabel.Text.StartsWith("Albacore") Or cboLabel.Text.StartsWith("Skip") Or cboLabel.Text.StartsWith("Yellow") Then
            cboCarton.Text = "Carton - Loins"
            cboCarton.ReadOnly = True
        Else
            cboCarton.Text = ""
            cboCarton.ReadOnly = False
        End If
        displayProductDetails()
    End Sub

    Public Function isDataEntryFieldsAreEmpty() As Boolean
        Try
            Dim ctr As Integer
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 0) = "" Or .Item(ctr, 1) = "" Or .Item(ctr, 2) = "" Or _
                        .Item(ctr, 3) = "" Or .Item(ctr, 4) = "" Or .Item(ctr, 5) = "" Or _
                        .Item(ctr, 6) = "" Or .Item(ctr, 7) = "" Or .Item(ctr, 8) = "" Or _
                        .Item(ctr, 9) = "" Or .Item(ctr, 11) = "" Then
                        MsgBox("Please check the Production Details (1 to 8 column and 10th), this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                        'Else
                        '    Return False
                    End If

                    ctr += 1
                End While
            End With

            Return False
        Catch e As Exception
            Dim ctr As Integer
            With grid
                While ctr < .RowCount
                    If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or .Item(ctr, 2) Is DBNull.Value Or _
                    .Item(ctr, 3) Is DBNull.Value Or .Item(ctr, 4) Is DBNull.Value Or .Item(ctr, 5) Is DBNull.Value Or _
                    .Item(ctr, 6) Is DBNull.Value Or .Item(ctr, 7) Is DBNull.Value Or .Item(ctr, 8) Is DBNull.Value Or _
                    .Item(ctr, 9) Is DBNull.Value Or .Item(ctr, 11) Is DBNull.Value Then
                        MsgBox("Please check the Production Details (1 to 8 column and 10th), this should not be left empty", MsgBoxStyle.Exclamation, "Warning")
                        Return True
                        'Else
                        '    Return False
                    End If

                    ctr += 1
                End While
            End With

            Return False
        End Try
    End Function

    Private Sub mnuLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLabel.Click
        Dim f As New frmLabels
        f.ShowDialog(Me)

        displayLabels()
        cboLabel.SelectAll()
        cboLabel.Focus()
    End Sub

    Private Sub mnuWarehouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWarehouse.Click
        Dim f As New frmWarehouse
        f.ShowDialog(Me)

        displayWarehouse()
        cboWarehouse.SelectAll()
        cboWarehouse.Focus()
    End Sub

    Public Sub displayPalletTag()
        lblPallet.Text = Format(getServerDateTime(), "yy") & "-" & identifyProduct() & "-" & _
            Format(getPalletTagCounter(Format(getServerDateTime(), "yy"), identifyProduct()), "0####0")
    End Sub

    Private Sub txtGW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGW.TextChanged
        If Not IsNumeric(txtGW.Text) Or txtGW.Text.Trim = "" Then
            txtGW.Text = "0"
            txtGW.SelectAll()
            txtGW.Focus()
        End If
    End Sub

    Private Sub txtNW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNW.TextChanged
        If Not IsNumeric(txtNW.Text) Or txtNW.Text.Trim = "" Then
            txtNW.Text = "0"
            txtNW.SelectAll()
            txtNW.Focus()
        End If
    End Sub

    Private Sub cboBuyer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuyer.TextChanged
        If cboBuyer.Text.StartsWith("COSI") Or cboBuyer.Text.StartsWith("Chicken") Then
            txtEU.Text = "FR No. 10254007446"
        Else
            txtEU.Text = "EU No. SI-02-01-001"
        End If

        If cboBuyer.Text.StartsWith("Local") Then
            cboGrade.Text = ""
            cboGrade.ReadOnly = True
        Else
            cboGrade.ReadOnly = False
        End If
    End Sub

    Private Sub cboWarehouse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWarehouse.TextChanged
        If cboWarehouse.Text = "" Then If cboWarehouse.ListCount > 0 Then cboWarehouse.SelectedIndex = 0
    End Sub

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboShift.SelectAll()
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboBuyer.SelectAll()
            cboBuyer.Focus()
        End If
    End Sub

    Private Sub cboBuyer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBuyer.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboLabel.SelectAll()
            cboLabel.Focus()
        End If
    End Sub

    Private Sub cboLabel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLabel.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCarton.SelectAll()
            cboCarton.Focus()
        End If
    End Sub

    Private Sub cboCarton_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCarton.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboGrade.SelectAll()
            cboGrade.Focus()
        End If
    End Sub

    Private Sub cboGrade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGrade.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboWarehouse.SelectAll()
            cboWarehouse.Focus()
        End If
    End Sub

    Private Sub cboWarehouse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboWarehouse.KeyDown
        If e.KeyCode = Keys.Enter Then
            chkUnlabel.Focus()
        End If
    End Sub

    Private Sub chkUnlabel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkUnlabel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRemarks.SelectAll()
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub txtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid.Focus()
        End If
    End Sub

    Public Function checkIfProductDetailsAreValid() As Boolean
        Try
            With grid
                Dim ctr As Integer
                While ctr < .RowCount
                    If getProductDetails_BySeamersRecord(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 3), "code") = "" Then Return False

                    ctr += 1
                End While
            End With

            Return True
        Catch e As Exception
            Return False
        End Try
    End Function

    Private Sub lblPallet_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPallet.DoubleClick
        Dim pallet As String = InputBox("Please enter pallet number to override", "Pallet Number Override")
        lblPallet.Text = pallet
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        computeWeights()
        Dim reply As String

        If Not cboLabel.Text.Trim = "" And Not cboBuyer.Text.Trim = "" And _
        Not cboWarehouse.Text.Trim = "" And grid.RowCount > 0 And Not cboCarton.Text.Trim = "" Then
            'If checkIfProductDetailsAreValid() Then
            If Not validateWithdrawnPallet(lblPallet.Text) Then
                If Not validatePallet(lblPallet.Text.Trim) Then
                    If Not isDataEntryFieldsAreEmpty() Then
                        If validateSpecie() Then
                            If lblPallet.Text.Trim = "" Then
                                displayPalletTag()
                            End If

                            reply = MsgBox("Are you sure you want to process this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                            If reply = vbYes Then
                                If chkUnlabel.Checked = True Then
                                    saveNewPallet(txtDate.Value, cboShift.Text, lblPallet.Text, cboLabel.Text, _
                                        cboWarehouse.Text, cboCarton.Text, "Yes", cboBuyer.Text, txtEU.Text, _
                                        cboGrade.Text, Format(getServerDateTime(), "yy"), identifyProduct(), txtGW.Text, _
                                        txtNW.Text, txtRemarks.Text)
                                Else
                                    saveNewPallet(txtDate.Value, cboShift.Text, lblPallet.Text, cboLabel.Text, _
                                        cboWarehouse.Text, cboCarton.Text, "No", cboBuyer.Text, txtEU.Text, _
                                        cboGrade.Text, Format(getServerDateTime(), "yy"), identifyProduct(), txtGW.Text, _
                                        txtNW.Text, txtRemarks.Text)
                                End If

                                Dim ctr As Integer
                                Dim remarks, tagNo As String
                                While ctr < grid.RowCount
                                    If grid.Item(ctr, 10) Is DBNull.Value Then
                                        remarks = ""
                                    Else
                                        remarks = grid.Item(ctr, 10)
                                    End If

                                    If grid.Item(ctr, 2) Is DBNull.Value Then
                                        tagNo = ""
                                    Else
                                        tagNo = grid.Item(ctr, 2)
                                    End If

                                    'CHANGES MADE TO OIS V1.1.0.5 THAT IS NOT AVAILABLE ON OIS V2.8 (OLD)
                                    If getRetortCode(grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), getLotSublotCode(grid.Item(ctr, 3), grid.Item(ctr, 4))) = "" Then
                                        saveNewProduction(grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), "NO", grid.Item(ctr, 4))
                                    End If

                                    If Not validateProductionDetails(getRetortCode(grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), getLotSublotCode(grid.Item(ctr, 3), grid.Item(ctr, 4))), _
                                        grid.Item(ctr, 5), grid.Item(ctr, 6)) Then
                                        saveNewProduction_Details(grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                            grid.Item(ctr, 5), Format(CDate(grid.Item(ctr, 0)), "yyyy"), CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 11), _
                                            "0", getCansPerCase(getProductCanSize(grid.Item(ctr, 5)), "CAN_SIZE"), getProductBOM(grid.Item(ctr, 5)), "0", _
                                            "0", grid.Item(ctr, 6), "0", grid.Item(ctr, 4))
                                    End If

                                    '***************************************

                                    If CStr(grid.Item(ctr, 5)).StartsWith("F") Or CStr(grid.Item(ctr, 5)).StartsWith("R") Or CStr(grid.Item(ctr, 5)).StartsWith("LA") Then
                                        'If CDbl(grid.Item(ctr, 6)) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                        saveNewPallet_Details(lblPallet.Text, grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                            grid.Item(ctr, 5), grid.Item(ctr, 7), grid.Item(ctr, 8), "", _
                                            "", cboLabel.Text, CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 6), "0", "0", grid.Item(ctr, 9), remarks, tagNo, grid.Item(ctr, 4))
                                        'Else
                                        '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                        '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                        'End If
                                    Else
                                        'If (CDbl(grid.Item(ctr, 6)) * getCansPerCase(getProductCanSize(grid.Item(ctr, 0)), "CAN SIZE")) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                        saveNewPallet_Details(lblPallet.Text, grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                              grid.Item(ctr, 5), grid.Item(ctr, 7), grid.Item(ctr, 8), "", _
                                              "", cboLabel.Text, CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 6), "0", "0", grid.Item(ctr, 9), remarks, tagNo, grid.Item(ctr, 4))
                                        'Else
                                        '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                        '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                        'End If
                                    End If

                                    ctr += 1
                                End While

                                MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                                cmdNew.Focus()
                            End If
                        Else
                            MsgBox("Please check the fish species against the Cannery Acceptance", MsgBoxStyle.Exclamation, "Warning")
                            grid.Focus()
                        End If
                    End If
                Else
                    If getPalletLockStatus(lblPallet.Text) = "N" Or getPositionUser() = "System Administrator" Or getPositionUser() = "Production Manager" Then
                        If Not isDataEntryFieldsAreEmpty() Then
                            If validateSpecie() Then
                                reply = MsgBox("Are you sure you want to update this existing pallet tag?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                                If reply = vbYes Then
                                    If chkUnlabel.Checked = True Then
                                        updatePallet(txtDate.Value, cboShift.Text, lblPallet.Text, cboLabel.Text, _
                                            cboWarehouse.Text, cboCarton.Text, "Yes", cboBuyer.Text, txtEU.Text, cboGrade.Text, _
                                            txtGW.Text, txtNW.Text, txtRemarks.Text)
                                    Else
                                        updatePallet(txtDate.Value, cboShift.Text, lblPallet.Text, cboLabel.Text, _
                                            cboWarehouse.Text, cboCarton.Text, "No", cboBuyer.Text, txtEU.Text, cboGrade.Text, _
                                            txtGW.Text, txtNW.Text, txtRemarks.Text)
                                    End If

                                    deletePalletDetails(lblPallet.Text)

                                    'Dim ctr As Integer
                                    'While ctr < grid.RowCount
                                    '    If (CDbl(grid.Item(ctr, 6)) * getCansPerCase(getProductCanSize(grid.Item(ctr, 0)), "CAN SIZE")) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                    '        saveNewPallet_Details(cboPallet.Text, grid.Item(ctr, 4), "%", grid.Item(ctr, 2), _
                                    '            grid.Item(ctr, 0), grid.Item(ctr, 6), grid.Item(ctr, 7), "", _
                                    '            "", cboLabel.Text, grid.Item(ctr, 3), grid.Item(ctr, 1))
                                    '    Else
                                    '        MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                    '            " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                    '    End If

                                    '    ctr += 1
                                    'End While
                                    Dim ctr As Integer
                                    Dim remarks, tagNo As String
                                    While ctr < grid.RowCount
                                        If grid.Item(ctr, 10) Is DBNull.Value Then
                                            remarks = ""
                                        Else
                                            remarks = grid.Item(ctr, 10)
                                        End If

                                        If grid.Item(ctr, 2) Is DBNull.Value Then
                                            tagNo = ""
                                        Else
                                            tagNo = grid.Item(ctr, 2)
                                        End If

                                        'CHANGES MADE TO OIS V1.1.0.5 THAT IS NOT AVAILABLE ON OIS V2.8 (OLD)
                                        If getRetortCode(grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), getLotSublotCode(grid.Item(ctr, 3), grid.Item(ctr, 4))) = "" Then
                                            saveNewProduction(grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), "NO", grid.Item(ctr, 4))
                                        End If

                                        If Not validateProductionDetails(getRetortCode(grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), getLotSublotCode(grid.Item(ctr, 3), grid.Item(ctr, 4))), _
                                            grid.Item(ctr, 5), grid.Item(ctr, 6)) Then
                                            saveNewProduction_Details(grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                                grid.Item(ctr, 5), Format(CDate(grid.Item(ctr, 0)), "yyyy"), CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 11), _
                                                "0", getCansPerCase(getProductCanSize(grid.Item(ctr, 5)), "CAN_SIZE"), getProductBOM(grid.Item(ctr, 5)), "0", _
                                                "0", grid.Item(ctr, 6), "0", grid.Item(ctr, 4))
                                        End If
                                        '***************************************

                                        If CStr(grid.Item(ctr, 5)).StartsWith("F") Or CStr(grid.Item(ctr, 5)).StartsWith("R") Or CStr(grid.Item(ctr, 5)).StartsWith("LA") Then
                                            'If CDbl(grid.Item(ctr, 6)) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                            saveNewPallet_Details(lblPallet.Text, grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                                grid.Item(ctr, 5), grid.Item(ctr, 7), grid.Item(ctr, 8), "", _
                                                "", cboLabel.Text, CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 6), "0", "0", grid.Item(ctr, 9), remarks, tagNo, grid.Item(ctr, 4))
                                            'Else
                                            '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                            '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                            'End If
                                        Else
                                            'If (CDbl(grid.Item(ctr, 6)) * getCansPerCase(getProductCanSize(grid.Item(ctr, 0)), "CAN SIZE")) <= getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) Then
                                            saveNewPallet_Details(lblPallet.Text, grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 3), _
                                                  grid.Item(ctr, 5), grid.Item(ctr, 7), grid.Item(ctr, 8), "", _
                                                  "", cboLabel.Text, CDate(grid.Item(ctr, 0)).DayOfYear, grid.Item(ctr, 6), "0", "0", grid.Item(ctr, 9), remarks, tagNo, grid.Item(ctr, 4))
                                            'Else
                                            '    MsgBox("Labeling output quantity of " & grid.Item(ctr, 0) & grid.Item(ctr, 1) & _
                                            '        " is greater than seamer quantity of " & getProductSeamerQty(grid.Item(ctr, 4), grid.Item(ctr, 0), grid.Item(ctr, 1), grid.Item(ctr, 2)) & "!", MsgBoxStyle.Critical, "Result: Found missing value.")
                                            'End If
                                        End If

                                        ctr += 1
                                    End While

                                    MsgBox("Transaction successfully completed", MsgBoxStyle.Information, "Information")
                                    cmdNew.Focus()
                                End If
                            Else
                                MsgBox("Please check the fish species against the Cannery Acceptance", MsgBoxStyle.Exclamation, "Warning")
                                grid.Focus()
                            End If
                        End If
                    Else
                        MsgBox("Please contact your Production Manager to override this editing", MsgBoxStyle.Exclamation, "Warning")
                        cmdFind.Focus()
                    End If
                End If
            Else
                MsgBox("Pallet Tag was partially/ fully withdrawn from the cold storage." & Chr(13) & _
                       "For details, please contact your Production Manager about this matter", MsgBoxStyle.Critical, "Restriction for editing")
                txtDate.SelectAll()
                txtDate.Focus()
            End If
            'Else
            '    MsgBox("Please verify your product details correctly", MsgBoxStyle.Critical, "Result: Invalid input")
            '    grid.Focus()
            'End If
        Else
            MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
            txtDate.SelectAll()
            txtDate.Focus()
        End If
    End Sub

    Public Function validateSpecie() As Boolean
        Dim ctr As Integer
        Dim returnValue As Boolean
        With grid
            While ctr < .RowCount
                If (CStr(.Item(ctr, 1)).IndexOf("M")) > 0 Then
                    returnValue = True
                Else
                    If validateSpecieByLotWithdrawn(.Item(ctr, 0), .Item(ctr, 1), .Item(ctr, 3), getProductSpecie(.Item(ctr, 5))) Then
                        returnValue = True
                    Else
                        returnValue = False
                        Exit While
                    End If
                End If

                ctr += 1
            End While
        End With

        Return returnValue
    End Function
End Class