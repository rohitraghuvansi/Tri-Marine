Public Class frmOverridePalletAllocation
    Inherits System.Windows.Forms.Form

    Public Shared cases As Double
    Public Shared tins As Double
    Public Shared total As Double
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
    Friend WithEvents grpQty As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAllocate As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtOTotal As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblOperCase As System.Windows.Forms.Label
    Friend WithEvents txtOTins As System.Windows.Forms.TextBox
    Friend WithEvents txtOCase As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblOTotal As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblOTins As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblOCases As System.Windows.Forms.Label
    Friend WithEvents lblOIndex As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblOLot As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblOCode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOPallet As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOverridePalletAllocation))
        Me.grpQty = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAllocate = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtOTotal = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblOperCase = New System.Windows.Forms.Label()
        Me.txtOTins = New System.Windows.Forms.TextBox()
        Me.txtOCase = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblOTotal = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblOTins = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblOCases = New System.Windows.Forms.Label()
        Me.lblOIndex = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblOLot = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblOCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOPallet = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.grpQty.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpQty
        '
        Me.grpQty.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.cmdCancel, Me.cmdAllocate, Me.Label33, Me.Label31, Me.txtOTotal, Me.Label29, Me.Label30, Me.lblOperCase, Me.txtOTins, Me.txtOCase, Me.Label27, Me.Label21, Me.lblOTotal, Me.Label23, Me.lblOTins, Me.Label25, Me.lblOCases, Me.lblOIndex, Me.Label18, Me.lblOLot, Me.Label15, Me.lblOCode, Me.Label1, Me.lblOPallet, Me.Label34})
        Me.grpQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpQty.Location = New System.Drawing.Point(1, 0)
        Me.grpQty.Name = "grpQty"
        Me.grpQty.Size = New System.Drawing.Size(528, 349)
        Me.grpQty.TabIndex = 74
        Me.grpQty.TabStop = False
        Me.grpQty.Text = "Pallet Quantity Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(87, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Bitmap)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancel.Location = New System.Drawing.Point(267, 292)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 48)
        Me.cmdCancel.TabIndex = 94
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdAllocate
        '
        Me.cmdAllocate.Image = CType(resources.GetObject("cmdAllocate.Image"), System.Drawing.Bitmap)
        Me.cmdAllocate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAllocate.Location = New System.Drawing.Point(187, 292)
        Me.cmdAllocate.Name = "cmdAllocate"
        Me.cmdAllocate.Size = New System.Drawing.Size(75, 48)
        Me.cmdAllocate.TabIndex = 93
        Me.cmdAllocate.Text = "All&ocate"
        Me.cmdAllocate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(200, 168)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 16)
        Me.Label33.TabIndex = 91
        Me.Label33.Text = "Quantity to allocate"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(232, 256)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 16)
        Me.Label31.TabIndex = 90
        Me.Label31.Text = "Total Units"
        '
        'txtOTotal
        '
        Me.txtOTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtOTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTotal.Location = New System.Drawing.Point(304, 252)
        Me.txtOTotal.Name = "txtOTotal"
        Me.txtOTotal.Size = New System.Drawing.Size(128, 24)
        Me.txtOTotal.TabIndex = 89
        Me.txtOTotal.Text = "0"
        Me.txtOTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(232, 224)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(60, 16)
        Me.Label29.TabIndex = 88
        Me.Label29.Text = "Can/ Unit"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(232, 192)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 16)
        Me.Label30.TabIndex = 87
        Me.Label30.Text = "Case"
        '
        'lblOperCase
        '
        Me.lblOperCase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOperCase.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperCase.Location = New System.Drawing.Point(430, 144)
        Me.lblOperCase.Name = "lblOperCase"
        Me.lblOperCase.Size = New System.Drawing.Size(88, 24)
        Me.lblOperCase.TabIndex = 86
        Me.lblOperCase.Text = "0"
        Me.lblOperCase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOperCase.Visible = False
        '
        'txtOTins
        '
        Me.txtOTins.Location = New System.Drawing.Point(304, 221)
        Me.txtOTins.Name = "txtOTins"
        Me.txtOTins.Size = New System.Drawing.Size(128, 23)
        Me.txtOTins.TabIndex = 85
        Me.txtOTins.Text = "0"
        Me.txtOTins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOCase
        '
        Me.txtOCase.Location = New System.Drawing.Point(304, 189)
        Me.txtOCase.Name = "txtOCase"
        Me.txtOCase.Size = New System.Drawing.Size(128, 23)
        Me.txtOCase.TabIndex = 84
        Me.txtOCase.Text = "0"
        Me.txtOCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(294, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 16)
        Me.Label27.TabIndex = 83
        Me.Label27.Text = "Available Quantity"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(294, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 16)
        Me.Label21.TabIndex = 82
        Me.Label21.Text = "Total Units"
        '
        'lblOTotal
        '
        Me.lblOTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTotal.Location = New System.Drawing.Point(382, 111)
        Me.lblOTotal.Name = "lblOTotal"
        Me.lblOTotal.Size = New System.Drawing.Size(136, 24)
        Me.lblOTotal.TabIndex = 81
        Me.lblOTotal.Text = "0"
        Me.lblOTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(294, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 16)
        Me.Label23.TabIndex = 80
        Me.Label23.Text = "Can/ Unit"
        '
        'lblOTins
        '
        Me.lblOTins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOTins.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTins.Location = New System.Drawing.Point(382, 78)
        Me.lblOTins.Name = "lblOTins"
        Me.lblOTins.Size = New System.Drawing.Size(136, 24)
        Me.lblOTins.TabIndex = 79
        Me.lblOTins.Text = "0"
        Me.lblOTins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(294, 51)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 16)
        Me.Label25.TabIndex = 78
        Me.Label25.Text = "Case"
        '
        'lblOCases
        '
        Me.lblOCases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOCases.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOCases.Location = New System.Drawing.Point(382, 47)
        Me.lblOCases.Name = "lblOCases"
        Me.lblOCases.Size = New System.Drawing.Size(136, 24)
        Me.lblOCases.TabIndex = 77
        Me.lblOCases.Text = "0"
        Me.lblOCases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOIndex
        '
        Me.lblOIndex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOIndex.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOIndex.Location = New System.Drawing.Point(238, 47)
        Me.lblOIndex.Name = "lblOIndex"
        Me.lblOIndex.Size = New System.Drawing.Size(40, 24)
        Me.lblOIndex.TabIndex = 76
        Me.lblOIndex.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Lot No."
        '
        'lblOLot
        '
        Me.lblOLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOLot.Location = New System.Drawing.Point(98, 111)
        Me.lblOLot.Name = "lblOLot"
        Me.lblOLot.Size = New System.Drawing.Size(136, 24)
        Me.lblOLot.TabIndex = 74
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 16)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Product Code"
        '
        'lblOCode
        '
        Me.lblOCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOCode.Location = New System.Drawing.Point(98, 78)
        Me.lblOCode.Name = "lblOCode"
        Me.lblOCode.Size = New System.Drawing.Size(136, 24)
        Me.lblOCode.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Pallet No."
        '
        'lblOPallet
        '
        Me.lblOPallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOPallet.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPallet.Location = New System.Drawing.Point(98, 47)
        Me.lblOPallet.Name = "lblOPallet"
        Me.lblOPallet.Size = New System.Drawing.Size(136, 24)
        Me.lblOPallet.TabIndex = 70
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(197, 162)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(244, 123)
        Me.Label34.TabIndex = 92
        '
        'frmOverridePalletAllocation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(530, 351)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpQty})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmOverridePalletAllocation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grpQty.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmOverridePalletAllocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub computeOverrideQty(ByVal cases As String, ByVal tins As String, ByVal perCase As String)
        If cases = "" Then cases = 0
        If tins = "" Then tins = 0
        If perCase = "" Then perCase = 0

        Try
            txtOTotal.Text = Format(CDbl((cases * perCase) + tins), "###,###,##0")
        Catch ex As Exception
            txtOTotal.Text = "0.00"
        End Try
    End Sub

    Private Sub txtOCase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOCase.TextChanged
        If Not IsNumeric(txtOCase.Text) Or txtOCase.Text = "" Then
            txtOCase.Text = "0"
            txtOCase.SelectAll()
            txtOCase.Focus()
        End If

        computeOverrideQty(txtOCase.Text, txtOTins.Text, lblOperCase.Text)

        Try
            If CDbl(txtOTotal.Text) > lblOTotal.Text Then
                MsgBox("You are not allowed to allocate more than the allowable quantity left for this pallet", MsgBoxStyle.Exclamation, "Warning")
                txtOCase.Text = "0"
                txtOCase.SelectAll()
                txtOCase.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtOTins_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOTins.TextChanged
        If Not IsNumeric(txtOTins.Text) Or txtOTins.Text = "" Then
            txtOTins.Text = "0"
            txtOTins.SelectAll()
            txtOTins.Focus()
        End If

        If CDbl(txtOTins.Text) > lblOperCase.Text Then
            txtOTins.Text = CDbl(lblOperCase.Text) - 1
            txtOTins.SelectAll()
            txtOTins.Focus()
        End If

        computeOverrideQty(txtOCase.Text, txtOTins.Text, lblOperCase.Text)

        Try
            If CDbl(txtOTotal.Text) > lblOTotal.Text Then
                MsgBox("You are not allowed to allocate more than the allowable quantity left for this pallet", MsgBoxStyle.Exclamation, "Warning")
                txtOTins.Text = "0"
                txtOTins.SelectAll()
                txtOTins.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdAllocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllocate.Click
        If Not CDbl(txtOTotal.Text) = 0 Then
            cases = txtOCase.Text
            tins = txtOTins.Text
            total = txtOTotal.Text

            Me.Close()
            Me.Dispose()
        Else
            MsgBox("You cannot withdrawn pallet without quantity", MsgBoxStyle.Exclamation, "Warning")
            txtOCase.SelectAll()
            txtOCase.Focus()
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cases = 0
        tins = 0
        total = 0

        Me.Close()
        Me.Dispose()
    End Sub
End Class
