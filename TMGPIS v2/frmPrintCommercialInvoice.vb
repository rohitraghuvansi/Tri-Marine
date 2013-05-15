Public Class frmPrintCommercialInvoice
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
    Friend WithEvents rptReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rptReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.rptReport.Size = New System.Drawing.Size(704, 390)
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
        Me.Label1.Size = New System.Drawing.Size(704, 40)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Print Commercial Invoice"
        '
        'frmPrintCommercialInvoice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 430)
        Me.Controls.Add(Me.rptReport)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmPrintCommercialInvoice"
        Me.ShowInTaskbar = False
        Me.Text = "frmPrintCommercialInvoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPrintCommercialInvoice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
    End Sub

    Public Sub displayReport(ByVal invoiceNo As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = getConnectionString()
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_printInvoiceNo"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@invoiceNo"
            p1.Direction = ParameterDirection.Input
            p1.SqlDbType = SqlDbType.VarChar
            p1.Value = invoiceNo

            cmd.Parameters.Add(p1)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("TRAKIM")
            da.Fill(ds)

            'grid.DataSource = ds.Tables(0)

            Dim rpt As New rptPrintCommercialInvoices
            rpt.Load()
            rpt.SetDataSource(ds.Tables(0))
            rptReport.ReportSource = rpt

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
End Class
