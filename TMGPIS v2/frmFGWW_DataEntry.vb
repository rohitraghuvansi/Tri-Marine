Public Class frmFGWW_DataEntry

    Private Sub frmFGWW_DataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        txtStartLoading.Value = getServerDateTime()
        txtEndLoading.Value = getServerDateTime()
        'displayFGWWDetails()

        displayPackStyle()
        displayTypeOfLoading()
        displayTypeOfPurpose()
        displayVessel()
        'displayPallet(cboProduct.Text)
        displayContainerDetails()

        'displayPalletDetails(cboProduct.Text, cboProduct.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayPackStyle()
        With cboProduct
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .DefColWidth = 150
            .AddItemTitles("Pack Type")
            .AddItem("Canned Tuna")
            .AddItem("Frozen Loins")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduct.TextChanged
        If cboProduct.Text = "" Then If cboProduct.ListCount > 0 Then cboProduct.SelectedIndex = 0

        'cboLoading.SelectedIndex = 0
        txtContainer.Text = ""
        txtSeal.Text = ""
        cboBuyer.Text = ""
        displayVessel()
        cboVessel.Text = ""
        'cboPurpose.SelectedIndex = 0
        txtStartLoading.Value = getServerDateTime()
        txtEndLoading.Value = getServerDateTime()

        'displayFGWWDetails()
        'displayPallet(cboProduct.Text)
        displayContainerDetails()
    End Sub

    Public Sub displayTypeOfLoading()
        With cboLoading
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .DefColWidth = 150
            .AddItemTitles("Type of Loading")
            .AddItem("Bulk Loading")
            .AddItem("Container Loading")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboLoading_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLoading.TextChanged
        If cboLoading.Text = "" Then If cboLoading.ListCount > 0 Then cboLoading.SelectedIndex = 0

        If cboLoading.Text.StartsWith("Cont") Then
            Label3.Text = "Container No."
            txtContainer.Text = ""
        Else
            Label3.Text = "Hatch No."
            txtSeal.Text = "*"
        End If
    End Sub

    Public Sub displayTypeOfPurpose()
        With cboPurpose
            .DataMode = C1.Win.C1List.DataModeEnum.AddItem
            .ClearItems()
            .DefColWidth = 150
            .AddItemTitles("Purpose")
            .AddItem("For Export")
            .AddItem("Local Sales")
            .AddItem("Transfer")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub cboPurpose_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPurpose.TextChanged
        If cboPurpose.Text = "" Then If cboPurpose.ListCount > 0 Then cboPurpose.SelectedIndex = 0

        If cboPurpose.Text.StartsWith("Transfer") Then
            Label5.Text = "Warehouse"
            displayWarehouse(True)
        Else
            Label5.Text = "Buyer"
            displayWarehouse(False)
        End If
    End Sub

    Public Sub displayWarehouse(ByVal warehouse As Boolean)
        With cboBuyer
            If warehouse Then
                .Text = ""
                .ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
                .DataSource = modModule.getWarehouse().Tables(0)
                .Splits(0).DisplayColumns(0).Width = 205
            Else
                .Text = ""
                .ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownCombo
                .DataSource = Nothing
            End If
        End With
    End Sub

    Public Sub displayVessel()
        With cboVessel
            .DataSource = modModule.getVessel_Container().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 208
        End With
    End Sub

    'Public Sub displayPallet(ByVal product As String)
    'With gridPalletTags
    '    .DataSource = getPalletTagInventory(product).Tables(0)
    '    .Splits(0).DisplayColumns(0).Width = 35
    '    .Splits(0).DisplayColumns(1).Width = 100
    '    .Splits(0).DisplayColumns(2).Width = 50
    '    .Splits(0).DisplayColumns(3).Width = 120
    '    .Splits(0).DisplayColumns(4).Width = 80
    '    .Splits(0).DisplayColumns(5).Width = 70
    '    .Splits(0).DisplayColumns(6).Width = 70
    '    .Splits(0).DisplayColumns(7).Width = 190
    '    .Splits(0).DisplayColumns(8).Width = 40
    '    .Splits(0).DisplayColumns(9).Width = 80

    '    .Columns(0).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
    '    '.Columns(0).DefaultValue = 0
    '    .Splits(0).DisplayColumns(0).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

    '    .Splits(0).DisplayColumns(1).Locked = True
    '    .Splits(0).DisplayColumns(2).Locked = True
    '    .Splits(0).DisplayColumns(3).Locked = True
    '    .Splits(0).DisplayColumns(4).Locked = True
    '    .Splits(0).DisplayColumns(5).Locked = True
    '    .Splits(0).DisplayColumns(6).Locked = True
    '    .Splits(0).DisplayColumns(7).Locked = True
    '    .Splits(0).DisplayColumns(8).Locked = True
    '    .Splits(0).DisplayColumns(9).Locked = True

    '.FetchRowStyles = True

    'displayContainerDetails() '(txtContainer.Text, txtSeal.Text)
    'End With
    'End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        addNewRecord()
        cboProduct.SelectAll()
        cboProduct.Focus()
    End Sub

    Public Sub addNewRecord()
        With Me
            .lblCode.Text = ""
            .cboProduct.SelectedIndex = 0
            .cboLoading.SelectedIndex = 0
            .txtContainer.Text = ""
            .txtSeal.Text = ""
            .cboVessel.Text = ""
            .displayVessel()
            .cboPurpose.SelectedIndex = 0
            .cboBuyer.Text = ""
            .txtStartLoading.Value = getServerDateTime()
            .txtEndLoading.Value = getServerDateTime()
            '.cboPallet.Text = ""
            lblQty.Text = "0"
            '.displayPallet(cboProduct.Text)
            displayContainerDetails()
            '.displayFGWWDetails()
        End With
    End Sub

    Public Function getPalletAllocationFromContainer(ByVal container As String, ByVal seal As String, ByVal pallet As String, _
    ByVal tag As String, ByVal pCode As String, ByVal pCode2 As String, ByVal lot As String, _
    ByVal prodnDate As String, ByVal cycle As String) As Boolean
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getExistencePalletFromContainer"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@loadingCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = getLoadingCode(container, seal)

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@pallet"
            p2.SqlDbType = SqlDbType.VarChar
            p2.Direction = ParameterDirection.Input
            p2.Value = pallet

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@tag"
            p3.SqlDbType = SqlDbType.VarChar
            p3.Direction = ParameterDirection.Input
            p3.Value = tag

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@pCode"
            p4.SqlDbType = SqlDbType.VarChar
            p4.Direction = ParameterDirection.Input
            p4.Value = pCode

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@pCode2"
            p5.SqlDbType = SqlDbType.VarChar
            p5.Direction = ParameterDirection.Input
            p5.Value = pCode2

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@lot"
            p6.SqlDbType = SqlDbType.VarChar
            p6.Direction = ParameterDirection.Input
            p6.Value = lot

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@prodnDate"
            p7.SqlDbType = SqlDbType.DateTime
            p7.Direction = ParameterDirection.Input
            If prodnDate = "" Then
                p7.Value = Format(CDate(getServerDateTime()), getTimeFormat())
            Else
                p7.Value = Format(CDate(prodnDate), getTimeFormat())
            End If

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@cycle"
            p8.SqlDbType = SqlDbType.VarChar
            p8.Direction = ParameterDirection.Input
            p8.Value = cycle

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            Dim returnValue As Boolean
            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    returnValue = True
                Else
                    returnValue = False
                End If
            Else
                returnValue = False
            End If

            dr.Close()
            c.Close()

            Return returnValue

        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Function

    Public Function getPalletQtyAllocationFromContainer(ByVal container As String, ByVal seal As String, ByVal pallet As String, _
    ByVal tag As String, ByVal pCode As String, ByVal pCode2 As String, ByVal lot As String, _
    ByVal prodnDate As String, ByVal cycle As String) As Double
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_getExistencePalletFromContainer"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@loadingCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = getLoadingCode(container, seal)

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@pallet"
            p2.SqlDbType = SqlDbType.VarChar
            p2.Direction = ParameterDirection.Input
            p2.Value = pallet

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@tag"
            p3.SqlDbType = SqlDbType.VarChar
            p3.Direction = ParameterDirection.Input
            p3.Value = tag

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@pCode"
            p4.SqlDbType = SqlDbType.VarChar
            p4.Direction = ParameterDirection.Input
            p4.Value = pCode

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@pCode2"
            p5.SqlDbType = SqlDbType.VarChar
            p5.Direction = ParameterDirection.Input
            p5.Value = pCode2

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@lot"
            p6.SqlDbType = SqlDbType.VarChar
            p6.Direction = ParameterDirection.Input
            p6.Value = lot

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@prodnDate"
            p7.SqlDbType = SqlDbType.DateTime
            p7.Direction = ParameterDirection.Input
            If prodnDate = "" Then
                p7.Value = Format(CDate(getServerDateTime()), getTimeFormat())
            Else
                p7.Value = Format(CDate(prodnDate), getTimeFormat())
            End If

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@cycle"
            p8.SqlDbType = SqlDbType.VarChar
            p8.Direction = ParameterDirection.Input
            p8.Value = cycle

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            Dim returnValue As Double
            If dr.Read Then
                If Not dr(0) Is DBNull.Value Then
                    returnValue = dr.GetDouble(5)
                Else
                    returnValue = 0
                End If
            Else
                returnValue = 0
            End If

            dr.Close()
            c.Close()

            Return returnValue

        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Function

    Public Sub calculateFCLs()
        With gridPalletTags
            Dim ctr As Integer
            Dim total As Double
            Dim perCase As Double

            While ctr < .RowCount
                If .Item(ctr, 0) = True Then
                    total += .Item(ctr, 9)
                    'perCase = .GetItemText(ctr, 11)
                End If

                ctr += 1
            End While

            'lblQty.Text = Format(total / perCase, "###,##0.#0")
            lblQty.Text = Format(total, "###,##0.#0")
        End With
    End Sub

    Private Sub gridPalletTags_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridPalletTags.Change
        With gridPalletTags
            If .Item(.Row, 9) = "0" Then
                MsgBox("You are not allowed to allocate this bins as it is already been allocated", MsgBoxStyle.Exclamation, "Warning")
                .Item(.Row, 0) = False
            End If

        End With

        calculateFCLs()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search FG Warehouse Withdrawal Details"
        f.searchType = 1
        f.displayAllFGWithdrawn()
        f.ShowDialog(Me)

        With f.grid
            If Not f.cancel Then
                lblCode.Text = .Item(.Row, 0)       '8
                displayFGWithdrawnDetails(lblCode.Text, .Item(.Row, 5))
                lblCode.Text = .Item(.Row, 0)       '8
                displayContainerDetails() '(txtContainer.Text, txtSeal.Text)
            End If
        End With

        cboProduct.SelectAll()
        cboProduct.Focus()
    End Sub

    Public Sub displayFGWithdrawnDetails(ByVal code As String, ByVal purpose As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim qry As String
            If purpose.StartsWith("Transfer") Then
                qry = "proc_getFGWithdrawn_Transfer"
            Else
                qry = "proc_getFGWithdrawn_Other"
            End If

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = qry
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@loadingCode"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = code

            cmd.Parameters.Add(p1)

            Dim drCode As SqlClient.SqlDataReader
            drCode = cmd.ExecuteReader

            If drCode.Read Then
                If Not drCode(0) Is DBNull.Value Then
                    cboProduct.Text = drCode.GetString(0)
                    cboLoading.Text = drCode.GetString(1)
                    txtContainer.Text = drCode.GetString(2)
                    cboVessel.Text = drCode.GetString(3)
                    cboPurpose.Text = drCode.GetString(4)
                    cboBuyer.Text = drCode.GetString(5)
                    txtSeal.Text = drCode.GetString(6)
                    txtStartLoading.Text = drCode.GetDateTime(7)
                    txtEndLoading.Text = drCode.GetDateTime(8)
                Else
                    cboProduct.SelectedIndex = 0
                    cboLoading.SelectedIndex = 0
                    txtContainer.Text = ""
                    cboVessel.Text = ""
                    cboPurpose.SelectedIndex = 0
                    cboBuyer.Text = ""
                    txtSeal.Text = ""
                    txtStartLoading.Text = getServerDateTime()
                    txtEndLoading.Text = getServerDateTime()
                End If
            Else
                cboProduct.SelectedIndex = 0
                cboLoading.SelectedIndex = 0
                txtContainer.Text = ""
                cboVessel.Text = ""
                cboPurpose.SelectedIndex = 0
                cboBuyer.Text = ""
                txtSeal.Text = ""
                txtStartLoading.Text = getServerDateTime()
                txtEndLoading.Text = getServerDateTime()
            End If

            drCode.Close()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        With gridPalletTags
            If isDataEntryFieldAreNotEmpty() Then      'And lstBuffer.ListCount > 0
                If getContainerShipmentStatus(getLoadingCode(txtContainer.Text, txtSeal.Text)) = "N" Then
                    Dim reply As String = MsgBox("Are you sure you want to process this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        If lblCode.Text.Trim = "" Then
                            saveNewFGWithdrawal(cboLoading.Text.Trim, txtContainer.Text.Trim, cboVessel.Text.Trim, _
                                cboPurpose.Text.Trim, cboBuyer.Text.Trim, txtSeal.Text.Trim)

                            Dim ctr As Integer
                            While ctr < .RowCount  'lstBuffer.ListCount
                                If .Item(ctr, 0) = True Then
                                    saveNewFGWithdrawalDetails(lblCode.Text, .Item(ctr, 1), .Item(ctr, 5), _
                                            .Item(ctr, 9), txtStartLoading.Text, .Item(ctr, 3), _
                                            .Item(ctr, 4), .Item(ctr, 8), txtEndLoading.Text, .Item(ctr, 6))
                                End If

                                ctr += 1
                            End While
                        Else
                            updateFGWithdrawn(lblCode.Text, cboLoading.Text, txtContainer.Text, cboVessel.Text, cboPurpose.Text, cboBuyer.Text, txtSeal.Text)

                            deleteFGWithdrawnDetails(lblCode.Text)
                            Dim ctr As Integer
                            While ctr < .RowCount  'lstBuffer.ListCount
                                If .Item(ctr, 0) = True Then
                                    saveNewFGWithdrawalDetails(lblCode.Text, .Item(ctr, 1), .Item(ctr, 5), _
                                             .Item(ctr, 9), txtStartLoading.Text, .Item(ctr, 3), _
                                             .Item(ctr, 4), .Item(ctr, 8), txtEndLoading.Text, .Item(ctr, 6))
                                End If

                                ctr += 1
                            End While
                        End If

                        MsgBox("Transaction is successfully completed.", MsgBoxStyle.Information, "Information")
                        'addNewRecord()
                        cmdNew.Focus()
                    End If
                Else
                    MsgBox("Editing of container that was already been shipped out is restricted from the system." & Chr(13) & _
                        "Please contact your Production Manager about this matter", MsgBoxStyle.Exclamation, "Warning")
                    cmdFind.Focus()
                End If
            Else
                MsgBox("Please fill in the empty fields", MsgBoxStyle.Exclamation, "Warning")
                cboProduct.SelectAll()
                cboProduct.Focus()
            End If
        End With
    End Sub

    Public Function isDataEntryFieldAreNotEmpty() As Boolean
        If cboPurpose.Text.StartsWith("Transfer") Then
            If Not cboProduct.Text.Trim = "" And Not cboLoading.Text.Trim = "" And Not txtContainer.Text.Trim = "" And Not txtSeal.Text.Trim = "" And _
                Not cboVessel.Text.Trim = "" And Not cboPurpose.Text.Trim = "" And Not cboBuyer.Text.Trim = "" Then
                Return True
            Else
                Return False
            End If
        Else
            If Not cboProduct.Text.Trim = "" And Not cboLoading.Text.Trim = "" And Not txtContainer.Text.Trim = "" And Not txtSeal.Text.Trim = "" And _
                Not cboVessel.Text.Trim = "" And Not cboPurpose.Text.Trim = "" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Sub saveNewFGWithdrawal(ByVal loadingType As String, ByVal cont As String, ByVal voyageName As String, _
  ByVal purposeType As String, ByVal purpose As String, ByVal seal As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_addNew_FGWithdrawal"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@id"
            p1.SqlDbType = SqlDbType.BigInt
            p1.Direction = ParameterDirection.Input
            p1.Value = getFGWithdrawalCounter()

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@loadingCode"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            p2.Value = Format(getServerDateTime(), "MM") & "-" & getFGWithdrawalCounter() & "-" & cont & "-" & seal
            lblCode.Text = p2.Value

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@loadingType"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = loadingType

            Dim p4 As New SqlClient.SqlParameter
            p4.ParameterName = "@cont#"
            p4.Direction = ParameterDirection.Input
            p4.SqlDbType = SqlDbType.VarChar
            p4.Value = cont.ToUpper

            Dim p5 As New SqlClient.SqlParameter
            p5.ParameterName = "@voyageName"
            p5.Direction = ParameterDirection.Input
            p5.SqlDbType = SqlDbType.VarChar
            p5.Value = voyageName

            Dim p6 As New SqlClient.SqlParameter
            p6.ParameterName = "@purposeType"
            p6.Direction = ParameterDirection.Input
            p6.SqlDbType = SqlDbType.VarChar
            p6.Value = purposeType

            Dim p7 As New SqlClient.SqlParameter
            p7.ParameterName = "@purpose"
            p7.Direction = ParameterDirection.Input
            p7.SqlDbType = SqlDbType.VarChar
            If purposeType.StartsWith("Transfer") Then
                p7.Value = getWarehouseCode(purpose)
            Else
                p7.Value = purpose
            End If

            Dim pOptr As New SqlClient.SqlParameter
            pOptr.ParameterName = "@optr"
            pOptr.Direction = ParameterDirection.Input
            pOptr.SqlDbType = SqlDbType.VarChar
            pOptr.Value = modModule.getUsername

            Dim pEncoded As New SqlClient.SqlParameter
            pEncoded.ParameterName = "@dateTimeEncoded"
            pEncoded.Direction = ParameterDirection.Input
            pEncoded.SqlDbType = SqlDbType.DateTime
            pEncoded.Value = getServerDateTime()

            Dim p8 As New SqlClient.SqlParameter
            p8.ParameterName = "@seal#"
            p8.Direction = ParameterDirection.Input
            p8.SqlDbType = SqlDbType.VarChar
            p8.Value = seal.ToUpper

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(pOptr)
            cmd.Parameters.Add(pEncoded)
            cmd.Parameters.Add(p8)


            Dim daBuyer As New SqlClient.SqlDataAdapter
            daBuyer.SelectCommand = cmd

            Dim dsBuyer As New DataSet("dbPPICIS")
            daBuyer.Fill(dsBuyer)

            daBuyer.Dispose()
            dsBuyer.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Public Sub displayContainerDetails()
        Dim ctr As Integer
        With gridPalletTags
            .DataSource = getPalletTagInventory(cboProduct.Text, txtContainer.Text, txtSeal.Text).Tables(0)
            .Splits(0).DisplayColumns(0).Width = 35
            .Splits(0).DisplayColumns(1).Width = 100
            .Splits(0).DisplayColumns(2).Width = 50
            .Splits(0).DisplayColumns(3).Width = 120
            .Splits(0).DisplayColumns(4).Width = 80
            .Splits(0).DisplayColumns(5).Width = 70
            .Splits(0).DisplayColumns(6).Width = 70
            .Splits(0).DisplayColumns(7).Width = 190
            .Splits(0).DisplayColumns(8).Width = 40
            .Splits(0).DisplayColumns(9).Width = 80

            .Columns(0).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            '.Columns(0).DefaultValue = 0
            .Splits(0).DisplayColumns(0).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            .Splits(0).DisplayColumns(1).Locked = True
            .Splits(0).DisplayColumns(2).Locked = True
            .Splits(0).DisplayColumns(3).Locked = True
            .Splits(0).DisplayColumns(4).Locked = True
            .Splits(0).DisplayColumns(5).Locked = True
            .Splits(0).DisplayColumns(6).Locked = True
            .Splits(0).DisplayColumns(7).Locked = True
            .Splits(0).DisplayColumns(8).Locked = True
            .Splits(0).DisplayColumns(9).Locked = True

            'While ctr < .RowCount
            '    If getPalletAllocationFromContainer(txtContainer.Text, txtSeal.Text, .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 5), _
            '        .Item(ctr, 6), .Item(ctr, 3), .Item(ctr, 4), .Item(ctr, 8)) Then

            '        .Item(ctr, 0) = True
            '        .Item(ctr, 9) = getPalletQtyAllocationFromContainer(txtContainer.Text, txtSeal.Text, .Item(ctr, 1), .Item(ctr, 2), .Item(ctr, 5), _
            '                            .Item(ctr, 6), .Item(ctr, 3), .Item(ctr, 4), .Item(ctr, 8))
            '    End If

            '    ctr += 1
            'End While

            .FetchRowStyles = True
        End With

        calculateFCLs()
    End Sub

    Private Sub gridPalletTags_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles gridPalletTags.FetchRowStyle
        If gridPalletTags.Columns(0).CellValue(e.Row) = True Or gridPalletTags.Columns(9).CellValue(e.Row) = "0" Then
            'gridPallet.Splits(0).DisplayColumns(4).Locked = False
            'gridPallet.Splits(0).DisplayColumns(4).Style.BackColor = Color.White
            e.CellStyle.ForeColor = System.Drawing.Color.White
            e.CellStyle.BackColor = System.Drawing.Color.Red
        Else
            e.CellStyle.ForeColor = System.Drawing.Color.Black
            e.CellStyle.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub cmdPrintRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintRelease.Click
        Dim f As New frmPrintReleaseReport
        f.displayData(txtContainer.Text, txtSeal.Text)
        f.ShowDialog(Me)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim f As New frmPrintPackingLists
        f.Label4.Text = "Print Loading Report"
        f.lblContainer.Text = txtContainer.Text
        f.lblSeal.Text = txtSeal.Text
        f.cmdPrint.Enabled = False
        f.ShowDialog(Me)
    End Sub
End Class