Public Class frmProductionScheduleDataEntry

    Private Sub frmProductionScheduleDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        displaySummary()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayTrans(ByVal lot As String, ByVal sublot As String, ByVal sub2 As String, ByVal specie As String, ByVal size As String)
        With grid
            .DataSource = getFishDepositDetails(lot, sublot, sub2, specie, size).Tables(0)
            .Columns(5).NumberFormat = "###,###0.#0"

            .Splits(0).DisplayColumns(0).Width = 150
            .Splits(0).DisplayColumns(1).Width = 80
            .Splits(0).DisplayColumns(2).Width = 150
            .Splits(0).DisplayColumns(6).Width = 150
            .Splits(0).DisplayColumns(7).Width = 70
            .Splits(0).DisplayColumns(8).Width = 70
            .Splits(0).DisplayColumns(9).Width = 70
            .Splits(0).DisplayColumns(10).Width = 200
            .Splits(0).DisplayColumns(11).Width = 200
        End With
    End Sub

    Public Sub displaySummary()
        lblSBCount.Text = grid.SelectedIndices.Count
        lblSBWeight.Text = Format(getSelectedBinsWeight(), "###,##0.##0")
        lblScBCount.Text = Format(getScheduledBins("count"), "###,##0")
        lblScBWeight.Text = Format(getScheduledBins("weight"), "###,##0.##0")
        lblNSCount.Text = grid.ListCount - lblSBCount.Text - lblScBCount.Text
        lblNSWeight.Text = Format(CDbl(getScheduledBins("total") - lblSBWeight.Text - lblScBWeight.Text), "###,##0.##0")
    End Sub


    Public Function getSelectedBinsWeight() As Double
        Dim ctr As Integer
        Dim total As Double

        With grid
            While ctr < .SelectedIndices.Count
                total += .GetItemText(.SelectedIndices.Item(ctr), 5)

                ctr += 1
            End While
        End With

        Return total / 1000
    End Function

    Private Sub grid_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid.MouseClick
        displaySummary()
    End Sub

    Public Function getScheduledBins(ByVal category As String) As Double
        Dim ctr As Integer
        Dim totalSchedule, totalWeights As Double 'totalNS 
        Dim countSchedule As Double 'countNS 
        countSchedule = 0
        'countNS = 0

        With grid
            While ctr < .ListCount
                If Not .GetItemText(ctr, 0) = "" Then
                    countSchedule += 1
                    totalSchedule += .GetItemText(ctr, 5)
                End If

                totalWeights += .GetItemText(ctr, 5)

                ctr += 1
            End While
        End With

        Select category
            Case "count"
                Return countSchedule
            Case "weight"
                Return totalSchedule / 1000
            Case Else
                Return totalWeights / 1000
        End Select
    End Function

    Public Sub showSchedule(ByVal show As Boolean)
        If show Then
            grp.Enabled = True
            grp.Visible = True
            cmdSet.Enabled = False
            cmdClose.Enabled = False
            grid.Enabled = False
            optSchedule.Focus()
        Else
            grp.Enabled = False
            grp.Visible = False
            cmdSet.Enabled = True
            cmdClose.Enabled = True
            grid.Enabled = True
        End If
    End Sub

    Private Sub cmdSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSet.Click
        showSchedule(True)
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        showSchedule(False)
    End Sub

    Private Sub cmdSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSchedule.Click
        Dim ctr As Integer
        Dim reply As String

        With grid
            If Not validateFishSchedule(txtDate.Text, lblTripCode.Text) Then
                reply = MsgBox("Are you sure you want to add the following bins to the schedule?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If reply = vbYes Then
                    While ctr < .SelectedIndices.Count
                        If .GetItemText(.SelectedIndices.Item(ctr), 0) = "" Then
                            MsgBox(.GetItemText(.SelectedIndices.Item(ctr), 1))
                        Else
                            reply = MsgBox("Fish bin is already scheduled, would you like to override it with the new schedule?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                            If reply = vbYes Then

                            End If
                        End If

                        ctr += 1
                    End While

                    MsgBox("You have successfully schedule the selected fish bins", MsgBoxStyle.Information, "Information")
                    showSchedule(False)
                    cmdClose.Focus()
                End If
            Else
            End If
        End With
    End Sub
End Class