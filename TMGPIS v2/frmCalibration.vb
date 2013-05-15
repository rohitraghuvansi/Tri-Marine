Public Class frmCalibration

    Public Shared manualTest As Boolean

    Private Sub frmCalibration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        manualTest = True
        If manualTest Then
            Label16.Text = "Calibrate Scale - Manaul"
        Else
            Label16.Text = "Calibrate Scale - Digital"
        End If

        Me.Text = getSystemTitle()
        lblDate.Text = getServerDateTime()

        displayScaleID()
        displayScaleLocation()
        displayHistory(cboScale.Text)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayScaleID()
        With cboScale
            .DataSource = getScaleID().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 240

            If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayScaleLocation()
        With gridLoc
            .DataSource = getScaleTestLocation().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 180
            .Splits(0).DisplayColumns(1).Width = 100
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = getServerDateTime()
    End Sub

    Private Sub cmdRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRead.Click
        Dim result As String

        If cboScale.Text.Trim = "" Then
            MsgBox("Please identify the type of scale to test", MsgBoxStyle.Exclamation, "Warning")
            cboScale.SelectAll()
            cboScale.Focus()
        Else
            If manualTest Then
                result = InputBox("Please enter override results for this location", "Results")
                If result = "" Then result = "0"
                Select Case whichLocation()
                    Case "UL"
                        gridLoc.Item(0, 1) = result
                        optUL.Focus()
                    Case "UR"
                        gridLoc.Item(1, 1) = result
                        optUR.Focus()
                    Case "CTR"
                        gridLoc.Item(2, 1) = result
                        optCtr.Focus()
                    Case "LL"
                        gridLoc.Item(3, 1) = result
                        optLL.Focus()
                    Case "LR"
                        gridLoc.Item(4, 1) = result
                        optLR.Focus()
                End Select
            End If
        End If

    End Sub

    Public Function whichLocation() As String
        If optUL.Checked Then
            Return "UL"
        ElseIf optUR.Checked Then
            Return "UR"
        ElseIf optCtr.Checked Then
            Return "CTR"
        ElseIf optLL.Checked Then
            Return "LL"
        Else
            Return "LR"
        End If
    End Function

    Public Function evaluateResults() As Boolean
        With gridLoc
            Dim row As Integer
            While row < .RowCount
                If Not .Item(row, 1) = 100 Then
                    Return False
                End If
                row += 1
            End While
        End With
    End Function

    Private Sub gridLoc_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridLoc.Change
        'If evaluateResults() Then
        '    optPass.Checked = True
        'Else
        '    optFail.Checked = True
        'End If
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        If Not cboScale.Text.Trim = "" Then
            If checkIfTestAreComplete() Then
                If Not validateScaleTest(Format(CDate(lblDate.Text), "ddMMyyyy") & cboScale.Text) Then
                    Dim reply As String = MsgBox("Are you sure you want to add this calibration test?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        If manualTest Then
                            saveNewScaleTest(cboScale.Text, lblDate.Text, getTestResults(), "Manual", lblDate.Text)
                        Else
                            saveNewScaleTest(cboScale.Text, lblDate.Text, getTestResults(), "Digital", lblDate.Text)
                        End If

                        saveNewScaleTestDetails(cboScale.Text, lblDate.Text, gridLoc.Item(0, 1), _
                                gridLoc.Item(1, 1), gridLoc.Item(2, 1), gridLoc.Item(3, 1), gridLoc.Item(4, 1))
                        displayHistory(cboScale.Text)

                        MsgBox("You have succesfully completed the scale calibration", MsgBoxStyle.Information, "Information")
                        optPending.Checked = True
                        displayScaleLocation()
                        cboScale.SelectAll()
                        cboScale.Focus()
                    End If
                Else
                    MsgBox("Calibration for this scale was already been done, please schedule next time", MsgBoxStyle.Exclamation, "Warning")
                    cboScale.SelectAll()
                    cboScale.Focus()
                End If
            Else
                MsgBox("Please complete your data results before you proceed", MsgBoxStyle.Exclamation, "Warning")
                cboScale.SelectAll()
                cboScale.Focus()
            End If
            Else
                MsgBox("Please identify the scale id", MsgBoxStyle.Exclamation, "Warning")
                cboScale.SelectAll()
                cboScale.Focus()
            End If
    End Sub

    Public Function getTestResults() As String
        If optPending.Checked Then
            Return "Pending"
        ElseIf optPass.Checked Then
            Return "Pass"
        Else
            Return "Fail"
        End If
    End Function

    Public Function checkIfTestAreComplete() As Boolean
        With gridLoc
            Dim ctr As Integer
            While ctr < .RowCount
                If CDbl(.Item(ctr, 1)) = 0 Then
                    Return False
                End If

                ctr += 1
            End While
        End With

        Return True
    End Function

    Public Sub displayHistory(ByVal scale As String)
        With grid
            .DataSource = getScaleIDTestHistory(scale).Tables(0)
            .Columns(0).NumberFormat = getTimeFormat() & " hh:mm:ss tt"

            .Splits(0).DisplayColumns(0).Width = 180
            .Splits(0).DisplayColumns(2).Width = 70
            .Splits(0).DisplayColumns(3).Width = 70
            .Splits(0).DisplayColumns(4).Width = 70
            .Splits(0).DisplayColumns(5).Width = 70
            .Splits(0).DisplayColumns(6).Width = 70
        End With
    End Sub

    Private Sub cboScale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboScale.TextChanged
        displayHistory(cboScale.Text)
    End Sub
End Class