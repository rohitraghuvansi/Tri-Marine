Public Class frmPrintPalletTag
    Inherits System.Windows.Forms.Form

    Public Shared pallet As String
    Public Shared productType As String
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
    Friend WithEvents rptReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rptReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rptReport
        '
        Me.rptReport.ActiveViewIndex = -1
        Me.rptReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptReport.Location = New System.Drawing.Point(0, 40)
        Me.rptReport.Name = "rptReport"
        Me.rptReport.Size = New System.Drawing.Size(944, 494)
        Me.rptReport.TabIndex = 64
        Me.rptReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(944, 40)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Print Pallet Tag"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(306, 42)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(62, 23)
        Me.cmdPrint.TabIndex = 66
        Me.cmdPrint.Text = "&Print"
        '
        'frmPrintPalletTag
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(944, 534)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.rptReport)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPrintPalletTag"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrintPalletTag"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintPalletTag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
    End Sub

    Public Sub displayReport(ByVal palletTag As String, ByVal canType As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_report_PrintPalletTag"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@pallet#"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = palletTag

            Dim p2 As New SqlClient.SqlParameter
            p2.ParameterName = "@cleaning"
            p2.Direction = ParameterDirection.Input
            p2.SqlDbType = SqlDbType.VarChar
            If getPalletTagBuyer(palletTag).StartsWith("Bolton") Then
                p2.Value = "Double Cleaned"
            Else
                p2.Value = ""
            End If

            Dim p3 As New SqlClient.SqlParameter
            p3.ParameterName = "@preparedBy"
            p3.Direction = ParameterDirection.Input
            p3.SqlDbType = SqlDbType.VarChar
            p3.Value = getUserFullName()

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("TRAKIM")
            da.Fill(ds)

            If canType = "FZ" Then
                Dim rpt As New rptPrintPalletTag_FZ
                rpt.Load()
                rpt.SetDataSource(ds.Tables(0))
                rptReport.ReportSource = rpt

                Dim reply As String
                If getPalletLockStatus(pallet) = "N" Or getPositionUser() = "System Administrator" Or getPositionUser() = "Production Manager" Then
                    reply = MsgBox("Would you like to print this Pallet Tag?" & Chr(13) & _
                        "Note:  Once your print this tag, this tag will be locked for transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    If reply = vbYes Then
                        'rptReport.PrintReport()
                        rpt.PrintToPrinter(2, True, 0, 0)
                        updatePalletLockStatus(pallet, "Y")
                    End If
                Else
                    MsgBox("Please contact your Production Manager to override this printing", MsgBoxStyle.Exclamation, "Warning")
                End If
            Else
                Dim rpt As New rptPrintPalletTag
                rpt.Load()
                rpt.SetDataSource(ds.Tables(0))
                rptReport.ReportSource = rpt

                Dim reply As String
                If getPalletLockStatus(pallet) = "N" Or getPositionUser() = "System Administrator" Or getPositionUser() = "Production Manager" Then
                    reply = MsgBox("Would you like to print this Pallet Tag?" & Chr(13) & _
                        "Note:  Once your print this tag, this tag will be locked for transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
                    If reply = vbYes Then
                        'rptReport.PrintReport()
                        rpt.PrintToPrinter(2, True, 0, 0)
                        updatePalletLockStatus(pallet, "Y")
                    End If
                Else
                    MsgBox("Please contact your Production Manager to override this printing", MsgBoxStyle.Exclamation, "Warning")
                End If
            End If

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        displayReport(pallet, productType)
    End Sub

   
End Class
