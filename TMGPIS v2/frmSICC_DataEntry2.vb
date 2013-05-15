Public Class frmSICC_DataEntry2
    Inherits System.Windows.Forms.Form

    Dim startup As Integer
    Dim editMode As Boolean
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblOcean As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboCC As C1.Win.C1List.C1Combo
    Friend WithEvents cboVessel As C1.Win.C1List.C1Combo
    Friend WithEvents txtFVDepart As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtFVUnload As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboCarrier As C1.Win.C1List.C1Combo
    Friend WithEvents cboCarTrip As C1.Win.C1List.C1Combo
    Friend WithEvents cboCarHatch As C1.Win.C1List.C1Combo
    Friend WithEvents gridContainer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboAreaCode As C1.Win.C1List.C1Combo
    Friend WithEvents cboRefNo As C1.Win.C1List.C1Combo
    Friend WithEvents gridLot As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboDelivery As C1.Win.C1List.C1Combo
    Friend WithEvents cboPreservationMethod As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuMFV As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFAO As System.Windows.Forms.MenuItem
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtFVArrive As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtFVTrans As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtCarArrive As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtCarDepart As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cboSublot As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cboPortTrans As C1.Win.C1List.C1Combo
    Friend WithEvents cboPortUnload As C1.Win.C1List.C1Combo
    Friend WithEvents cboSet As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents chkNoCC As System.Windows.Forms.CheckBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSICC_DataEntry2))
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style9 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style10 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style11 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style12 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style13 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style14 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style15 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style16 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style17 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style18 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style19 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style20 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style21 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style22 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style23 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style24 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style25 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style26 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style27 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style28 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style29 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style30 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style31 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style32 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style33 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style34 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style35 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style36 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style37 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style38 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style39 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style40 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style41 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style42 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style43 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style44 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style45 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style46 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style47 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style48 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style49 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style50 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style51 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style52 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style53 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style54 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style55 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style56 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style57 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style58 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style59 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style60 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style61 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style62 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style63 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style64 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style65 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style66 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style67 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style68 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style69 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style70 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style71 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style72 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style73 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style74 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style75 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style76 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style77 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style78 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style79 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style80 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style81 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style82 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style83 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style84 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style85 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style86 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style87 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style88 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style89 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style90 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style91 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style92 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style93 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style94 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style95 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style96 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style97 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style98 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style99 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style100 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style101 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style102 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style103 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style104 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.cboCC = New C1.Win.C1List.C1Combo()
        Me.cboDelivery = New C1.Win.C1List.C1Combo()
        Me.cboVessel = New C1.Win.C1List.C1Combo()
        Me.txtFVDepart = New C1.Win.C1Input.C1DateEdit()
        Me.txtFVArrive = New C1.Win.C1Input.C1DateEdit()
        Me.txtFVUnload = New C1.Win.C1Input.C1DateEdit()
        Me.cboCarrier = New C1.Win.C1List.C1Combo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOcean = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboCarTrip = New C1.Win.C1List.C1Combo()
        Me.cboCarHatch = New C1.Win.C1List.C1Combo()
        Me.gridContainer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cboAreaCode = New C1.Win.C1List.C1Combo()
        Me.cboRefNo = New C1.Win.C1List.C1Combo()
        Me.gridLot = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboPreservationMethod = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuMFV = New System.Windows.Forms.MenuItem()
        Me.mnuMFAO = New System.Windows.Forms.MenuItem()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtFVTrans = New C1.Win.C1Input.C1DateEdit()
        Me.txtCarArrive = New C1.Win.C1Input.C1DateEdit()
        Me.txtCarDepart = New C1.Win.C1Input.C1DateEdit()
        Me.cboSublot = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cboPortTrans = New C1.Win.C1List.C1Combo()
        Me.cboPortUnload = New C1.Win.C1List.C1Combo()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboSet = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.chkNoCC = New System.Windows.Forms.CheckBox()
        CType(Me.cboCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFVDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFVArrive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFVUnload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarrier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarTrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarHatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAreaCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPreservationMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFVTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCarArrive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCarDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPortTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPortUnload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCC
        '
        Me.cboCC.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCC.AllowColMove = False
        Me.cboCC.AutoCompletion = True
        Me.cboCC.AutoDropDown = True
        Me.cboCC.Caption = ""
        Me.cboCC.CaptionHeight = 17
        Me.cboCC.CaptionStyle = Style1
        Me.cboCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCC.ColumnCaptionHeight = 17
        Me.cboCC.ColumnFooterHeight = 17
        Me.cboCC.ContentHeight = 18
        Me.cboCC.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCC.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCC.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCC.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCC.EditorHeight = 18
        Me.cboCC.EvenRowStyle = Style2
        Me.cboCC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCC.FooterStyle = Style3
        Me.cboCC.HeadingStyle = Style4
        Me.cboCC.HighLightRowStyle = Style5
        Me.cboCC.Images.Add(CType(resources.GetObject("cboCC.Images"), System.Drawing.Image))
        Me.cboCC.ItemHeight = 20
        Me.cboCC.Location = New System.Drawing.Point(136, 56)
        Me.cboCC.MatchEntryTimeout = CType(2000, Long)
        Me.cboCC.MaxDropDownItems = CType(10, Short)
        Me.cboCC.MaxLength = 32767
        Me.cboCC.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCC.Name = "cboCC"
        Me.cboCC.OddRowStyle = Style6
        Me.cboCC.ReadOnly = True
        Me.cboCC.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCC.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCC.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCC.SelectedStyle = Style7
        Me.cboCC.Size = New System.Drawing.Size(376, 24)
        Me.cboCC.Style = Style8
        Me.cboCC.TabIndex = 0
        Me.cboCC.PropBag = resources.GetString("cboCC.PropBag")
        '
        'cboDelivery
        '
        Me.cboDelivery.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboDelivery.AllowColMove = False
        Me.cboDelivery.AutoCompletion = True
        Me.cboDelivery.AutoDropDown = True
        Me.cboDelivery.Caption = ""
        Me.cboDelivery.CaptionHeight = 17
        Me.cboDelivery.CaptionStyle = Style9
        Me.cboDelivery.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDelivery.ColumnCaptionHeight = 17
        Me.cboDelivery.ColumnFooterHeight = 17
        Me.cboDelivery.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboDelivery.ContentHeight = 18
        Me.cboDelivery.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboDelivery.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboDelivery.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDelivery.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDelivery.EditorHeight = 18
        Me.cboDelivery.EvenRowStyle = Style10
        Me.cboDelivery.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDelivery.FooterStyle = Style11
        Me.cboDelivery.HeadingStyle = Style12
        Me.cboDelivery.HighLightRowStyle = Style13
        Me.cboDelivery.Images.Add(CType(resources.GetObject("cboDelivery.Images"), System.Drawing.Image))
        Me.cboDelivery.ItemHeight = 20
        Me.cboDelivery.Location = New System.Drawing.Point(136, 85)
        Me.cboDelivery.MatchEntryTimeout = CType(2000, Long)
        Me.cboDelivery.MaxDropDownItems = CType(10, Short)
        Me.cboDelivery.MaxLength = 32767
        Me.cboDelivery.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboDelivery.Name = "cboDelivery"
        Me.cboDelivery.OddRowStyle = Style14
        Me.cboDelivery.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboDelivery.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboDelivery.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDelivery.SelectedStyle = Style15
        Me.cboDelivery.Size = New System.Drawing.Size(184, 24)
        Me.cboDelivery.Style = Style16
        Me.cboDelivery.TabIndex = 1
        Me.cboDelivery.PropBag = resources.GetString("cboDelivery.PropBag")
        '
        'cboVessel
        '
        Me.cboVessel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboVessel.AllowColMove = False
        Me.cboVessel.AutoCompletion = True
        Me.cboVessel.AutoDropDown = True
        Me.cboVessel.Caption = ""
        Me.cboVessel.CaptionHeight = 17
        Me.cboVessel.CaptionStyle = Style17
        Me.cboVessel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVessel.ColumnCaptionHeight = 17
        Me.cboVessel.ColumnFooterHeight = 17
        Me.cboVessel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboVessel.ContentHeight = 18
        Me.cboVessel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboVessel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboVessel.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVessel.EditorHeight = 18
        Me.cboVessel.EvenRowStyle = Style18
        Me.cboVessel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVessel.FooterStyle = Style19
        Me.cboVessel.HeadingStyle = Style20
        Me.cboVessel.HighLightRowStyle = Style21
        Me.cboVessel.Images.Add(CType(resources.GetObject("cboVessel.Images"), System.Drawing.Image))
        Me.cboVessel.ItemHeight = 20
        Me.cboVessel.Location = New System.Drawing.Point(136, 121)
        Me.cboVessel.MatchEntryTimeout = CType(2000, Long)
        Me.cboVessel.MaxDropDownItems = CType(10, Short)
        Me.cboVessel.MaxLength = 32767
        Me.cboVessel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboVessel.Name = "cboVessel"
        Me.cboVessel.OddRowStyle = Style22
        Me.cboVessel.ReadOnly = True
        Me.cboVessel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboVessel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboVessel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboVessel.SelectedStyle = Style23
        Me.cboVessel.Size = New System.Drawing.Size(376, 24)
        Me.cboVessel.Style = Style24
        Me.cboVessel.TabIndex = 2
        Me.cboVessel.PropBag = resources.GetString("cboVessel.PropBag")
        '
        'txtFVDepart
        '
        Me.txtFVDepart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFVDepart.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtFVDepart.Location = New System.Drawing.Point(136, 149)
        Me.txtFVDepart.Name = "txtFVDepart"
        Me.txtFVDepart.ReadOnly = True
        Me.txtFVDepart.Size = New System.Drawing.Size(128, 23)
        Me.txtFVDepart.TabIndex = 3
        Me.txtFVDepart.Tag = Nothing
        Me.txtFVDepart.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtFVArrive
        '
        Me.txtFVArrive.EmptyAsNull = True
        Me.txtFVArrive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFVArrive.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtFVArrive.Location = New System.Drawing.Point(136, 176)
        Me.txtFVArrive.Name = "txtFVArrive"
        Me.txtFVArrive.ReadOnly = True
        Me.txtFVArrive.Size = New System.Drawing.Size(128, 23)
        Me.txtFVArrive.TabIndex = 4
        Me.txtFVArrive.Tag = Nothing
        Me.txtFVArrive.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtFVUnload
        '
        Me.txtFVUnload.EmptyAsNull = True
        Me.txtFVUnload.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFVUnload.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtFVUnload.Location = New System.Drawing.Point(136, 235)
        Me.txtFVUnload.Name = "txtFVUnload"
        Me.txtFVUnload.ReadOnly = True
        Me.txtFVUnload.Size = New System.Drawing.Size(128, 23)
        Me.txtFVUnload.TabIndex = 7
        Me.txtFVUnload.Tag = Nothing
        Me.txtFVUnload.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cboCarrier
        '
        Me.cboCarrier.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCarrier.AllowColMove = False
        Me.cboCarrier.AutoCompletion = True
        Me.cboCarrier.AutoDropDown = True
        Me.cboCarrier.Caption = ""
        Me.cboCarrier.CaptionHeight = 17
        Me.cboCarrier.CaptionStyle = Style25
        Me.cboCarrier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCarrier.ColumnCaptionHeight = 17
        Me.cboCarrier.ColumnFooterHeight = 17
        Me.cboCarrier.ContentHeight = 18
        Me.cboCarrier.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCarrier.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCarrier.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarrier.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCarrier.EditorHeight = 18
        Me.cboCarrier.EvenRowStyle = Style26
        Me.cboCarrier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarrier.FooterStyle = Style27
        Me.cboCarrier.HeadingStyle = Style28
        Me.cboCarrier.HighLightRowStyle = Style29
        Me.cboCarrier.Images.Add(CType(resources.GetObject("cboCarrier.Images"), System.Drawing.Image))
        Me.cboCarrier.ItemHeight = 20
        Me.cboCarrier.Location = New System.Drawing.Point(648, 121)
        Me.cboCarrier.MatchEntryTimeout = CType(2000, Long)
        Me.cboCarrier.MaxDropDownItems = CType(10, Short)
        Me.cboCarrier.MaxLength = 32767
        Me.cboCarrier.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCarrier.Name = "cboCarrier"
        Me.cboCarrier.OddRowStyle = Style30
        Me.cboCarrier.ReadOnly = True
        Me.cboCarrier.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCarrier.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCarrier.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCarrier.SelectedStyle = Style31
        Me.cboCarrier.Size = New System.Drawing.Size(224, 24)
        Me.cboCarrier.Style = Style32
        Me.cboCarrier.TabIndex = 9
        Me.cboCarrier.PropBag = resources.GetString("cboCarrier.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Unloading Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Transshipment Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Arrival Date"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Gray
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 16)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "Departure Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gray
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 16)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Fishing Vessel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Delivery Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Trip Code No."
        '
        'lblOcean
        '
        Me.lblOcean.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOcean.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcean.Location = New System.Drawing.Point(136, 326)
        Me.lblOcean.Name = "lblOcean"
        Me.lblOcean.Size = New System.Drawing.Size(224, 24)
        Me.lblOcean.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(536, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Hatch No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(536, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Carrier Trip No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(536, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Departure Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(536, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Arrival Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gray
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(536, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Carrier Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Gray
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 361)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "RMO Ref No."
        Me.Label11.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Gray
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Catch Area Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 520)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 16)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Fish Lot Details"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Gray
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(536, 276)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 16)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Container Details"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(922, 40)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Raw Fish Supply"
        '
        'cboCarTrip
        '
        Me.cboCarTrip.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCarTrip.AutoCompletion = True
        Me.cboCarTrip.AutoDropDown = True
        Me.cboCarTrip.Caption = ""
        Me.cboCarTrip.CaptionHeight = 17
        Me.cboCarTrip.CaptionStyle = Style33
        Me.cboCarTrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCarTrip.ColumnCaptionHeight = 17
        Me.cboCarTrip.ColumnFooterHeight = 17
        Me.cboCarTrip.ComboStyle = C1.Win.C1List.ComboStyleEnum.SimpleCombo
        Me.cboCarTrip.ContentHeight = 18
        Me.cboCarTrip.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCarTrip.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCarTrip.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarTrip.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCarTrip.EditorHeight = 18
        Me.cboCarTrip.EvenRowStyle = Style34
        Me.cboCarTrip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarTrip.FooterStyle = Style35
        Me.cboCarTrip.HeadingStyle = Style36
        Me.cboCarTrip.HighLightRowStyle = Style37
        Me.cboCarTrip.Images.Add(CType(resources.GetObject("cboCarTrip.Images"), System.Drawing.Image))
        Me.cboCarTrip.ItemHeight = 20
        Me.cboCarTrip.Location = New System.Drawing.Point(648, 203)
        Me.cboCarTrip.MatchEntryTimeout = CType(2000, Long)
        Me.cboCarTrip.MaxDropDownItems = CType(10, Short)
        Me.cboCarTrip.MaxLength = 32767
        Me.cboCarTrip.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCarTrip.Name = "cboCarTrip"
        Me.cboCarTrip.OddRowStyle = Style38
        Me.cboCarTrip.ReadOnly = True
        Me.cboCarTrip.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCarTrip.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCarTrip.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCarTrip.SelectedStyle = Style39
        Me.cboCarTrip.Size = New System.Drawing.Size(224, 26)
        Me.cboCarTrip.Style = Style40
        Me.cboCarTrip.TabIndex = 12
        Me.cboCarTrip.PropBag = resources.GetString("cboCarTrip.PropBag")
        '
        'cboCarHatch
        '
        Me.cboCarHatch.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCarHatch.AutoCompletion = True
        Me.cboCarHatch.AutoDropDown = True
        Me.cboCarHatch.Caption = ""
        Me.cboCarHatch.CaptionHeight = 17
        Me.cboCarHatch.CaptionStyle = Style41
        Me.cboCarHatch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCarHatch.ColumnCaptionHeight = 17
        Me.cboCarHatch.ColumnFooterHeight = 17
        Me.cboCarHatch.ComboStyle = C1.Win.C1List.ComboStyleEnum.SimpleCombo
        Me.cboCarHatch.ContentHeight = 18
        Me.cboCarHatch.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCarHatch.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCarHatch.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarHatch.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCarHatch.EditorHeight = 18
        Me.cboCarHatch.EvenRowStyle = Style42
        Me.cboCarHatch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarHatch.FooterStyle = Style43
        Me.cboCarHatch.HeadingStyle = Style44
        Me.cboCarHatch.HighLightRowStyle = Style45
        Me.cboCarHatch.Images.Add(CType(resources.GetObject("cboCarHatch.Images"), System.Drawing.Image))
        Me.cboCarHatch.ItemHeight = 20
        Me.cboCarHatch.Location = New System.Drawing.Point(648, 233)
        Me.cboCarHatch.MatchEntryTimeout = CType(2000, Long)
        Me.cboCarHatch.MaxDropDownItems = CType(10, Short)
        Me.cboCarHatch.MaxLength = 32767
        Me.cboCarHatch.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCarHatch.Name = "cboCarHatch"
        Me.cboCarHatch.OddRowStyle = Style46
        Me.cboCarHatch.ReadOnly = True
        Me.cboCarHatch.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCarHatch.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCarHatch.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCarHatch.SelectedStyle = Style47
        Me.cboCarHatch.Size = New System.Drawing.Size(224, 26)
        Me.cboCarHatch.Style = Style48
        Me.cboCarHatch.TabIndex = 13
        Me.cboCarHatch.PropBag = resources.GetString("cboCarHatch.PropBag")
        '
        'gridContainer
        '
        Me.gridContainer.AllowAddNew = True
        Me.gridContainer.AllowColMove = False
        Me.gridContainer.AllowDelete = True
        Me.gridContainer.CaptionHeight = 17
        Me.gridContainer.Enabled = False
        Me.gridContainer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridContainer.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridContainer.Images.Add(CType(resources.GetObject("gridContainer.Images"), System.Drawing.Image))
        Me.gridContainer.Location = New System.Drawing.Point(536, 296)
        Me.gridContainer.Name = "gridContainer"
        Me.gridContainer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridContainer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridContainer.PreviewInfo.ZoomFactor = 75.0R
        Me.gridContainer.PrintInfo.PageSettings = CType(resources.GetObject("gridContainer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridContainer.RowHeight = 20
        Me.gridContainer.Size = New System.Drawing.Size(344, 112)
        Me.gridContainer.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.gridContainer.TabIndex = 14
        Me.gridContainer.Text = "C1TrueDBGrid1"
        Me.gridContainer.PropBag = resources.GetString("gridContainer.PropBag")
        '
        'cboAreaCode
        '
        Me.cboAreaCode.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboAreaCode.AllowColMove = False
        Me.cboAreaCode.AutoCompletion = True
        Me.cboAreaCode.AutoDropDown = True
        Me.cboAreaCode.Caption = ""
        Me.cboAreaCode.CaptionHeight = 17
        Me.cboAreaCode.CaptionStyle = Style49
        Me.cboAreaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAreaCode.ColumnCaptionHeight = 17
        Me.cboAreaCode.ColumnFooterHeight = 17
        Me.cboAreaCode.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboAreaCode.ContentHeight = 18
        Me.cboAreaCode.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboAreaCode.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboAreaCode.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreaCode.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAreaCode.EditorHeight = 18
        Me.cboAreaCode.EvenRowStyle = Style50
        Me.cboAreaCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreaCode.FooterStyle = Style51
        Me.cboAreaCode.HeadingStyle = Style52
        Me.cboAreaCode.HighLightRowStyle = Style53
        Me.cboAreaCode.Images.Add(CType(resources.GetObject("cboAreaCode.Images"), System.Drawing.Image))
        Me.cboAreaCode.ItemHeight = 20
        Me.cboAreaCode.Location = New System.Drawing.Point(136, 296)
        Me.cboAreaCode.MatchEntryTimeout = CType(2000, Long)
        Me.cboAreaCode.MaxDropDownItems = CType(10, Short)
        Me.cboAreaCode.MaxLength = 32767
        Me.cboAreaCode.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboAreaCode.Name = "cboAreaCode"
        Me.cboAreaCode.OddRowStyle = Style54
        Me.cboAreaCode.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboAreaCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboAreaCode.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboAreaCode.SelectedStyle = Style55
        Me.cboAreaCode.Size = New System.Drawing.Size(224, 24)
        Me.cboAreaCode.Style = Style56
        Me.cboAreaCode.TabIndex = 15
        Me.cboAreaCode.PropBag = resources.GetString("cboAreaCode.PropBag")
        '
        'cboRefNo
        '
        Me.cboRefNo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboRefNo.AllowColMove = False
        Me.cboRefNo.AutoCompletion = True
        Me.cboRefNo.AutoDropDown = True
        Me.cboRefNo.Caption = ""
        Me.cboRefNo.CaptionHeight = 17
        Me.cboRefNo.CaptionStyle = Style57
        Me.cboRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRefNo.ColumnCaptionHeight = 17
        Me.cboRefNo.ColumnFooterHeight = 17
        Me.cboRefNo.ContentHeight = 18
        Me.cboRefNo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboRefNo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboRefNo.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRefNo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRefNo.EditorHeight = 18
        Me.cboRefNo.Enabled = False
        Me.cboRefNo.EvenRowStyle = Style58
        Me.cboRefNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRefNo.FooterStyle = Style59
        Me.cboRefNo.HeadingStyle = Style60
        Me.cboRefNo.HighLightRowStyle = Style61
        Me.cboRefNo.Images.Add(CType(resources.GetObject("cboRefNo.Images"), System.Drawing.Image))
        Me.cboRefNo.ItemHeight = 20
        Me.cboRefNo.Location = New System.Drawing.Point(136, 357)
        Me.cboRefNo.MatchEntryTimeout = CType(2000, Long)
        Me.cboRefNo.MaxDropDownItems = CType(10, Short)
        Me.cboRefNo.MaxLength = 32767
        Me.cboRefNo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.OddRowStyle = Style62
        Me.cboRefNo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboRefNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboRefNo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboRefNo.SelectedStyle = Style63
        Me.cboRefNo.Size = New System.Drawing.Size(224, 24)
        Me.cboRefNo.Style = Style64
        Me.cboRefNo.TabIndex = 16
        Me.cboRefNo.TabStop = False
        Me.cboRefNo.Text = "*"
        Me.cboRefNo.Visible = False
        Me.cboRefNo.PropBag = resources.GetString("cboRefNo.PropBag")
        '
        'gridLot
        '
        Me.gridLot.AllowAddNew = True
        Me.gridLot.AllowColMove = False
        Me.gridLot.AllowDelete = True
        Me.gridLot.CaptionHeight = 17
        Me.gridLot.Enabled = False
        Me.gridLot.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridLot.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridLot.Images.Add(CType(resources.GetObject("gridLot.Images"), System.Drawing.Image))
        Me.gridLot.Location = New System.Drawing.Point(112, 512)
        Me.gridLot.Name = "gridLot"
        Me.gridLot.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridLot.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridLot.PreviewInfo.ZoomFactor = 75.0R
        Me.gridLot.PrintInfo.PageSettings = CType(resources.GetObject("gridLot.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridLot.RowHeight = 20
        Me.gridLot.Size = New System.Drawing.Size(776, 144)
        Me.gridLot.TabIndex = 17
        Me.gridLot.Text = "C1TrueDBGrid2"
        Me.gridLot.Visible = False
        Me.gridLot.PropBag = resources.GetString("gridLot.PropBag")
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClose.Location = New System.Drawing.Point(584, 432)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 22
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(504, 432)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 21
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(424, 432)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 48)
        Me.cmdFind.TabIndex = 20
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEdit.Location = New System.Drawing.Point(344, 432)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 48)
        Me.cmdEdit.TabIndex = 19
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Image = CType(resources.GetObject("cmd.Image"), System.Drawing.Image)
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd.Location = New System.Drawing.Point(264, 432)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(75, 48)
        Me.cmd.TabIndex = 18
        Me.cmd.Text = "&Add"
        Me.cmd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Gray
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 330)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 16)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "Ocean"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Gray
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(512, 155)
        Me.Label18.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Gray
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(528, 114)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(360, 155)
        Me.Label19.TabIndex = 119
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Gray
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(528, 272)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(360, 144)
        Me.Label21.TabIndex = 120
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Gray
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 272)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(512, 144)
        Me.Label22.TabIndex = 121
        '
        'cboPreservationMethod
        '
        Me.cboPreservationMethod.AllowColMove = False
        Me.cboPreservationMethod.AllowColSelect = True
        Me.cboPreservationMethod.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboPreservationMethod.AlternatingRows = False
        Me.cboPreservationMethod.CaptionStyle = Style65
        Me.cboPreservationMethod.ColumnCaptionHeight = 17
        Me.cboPreservationMethod.ColumnFooterHeight = 17
        Me.cboPreservationMethod.Enabled = False
        Me.cboPreservationMethod.EvenRowStyle = Style66
        Me.cboPreservationMethod.FetchRowStyles = False
        Me.cboPreservationMethod.FooterStyle = Style67
        Me.cboPreservationMethod.HeadingStyle = Style68
        Me.cboPreservationMethod.HighLightRowStyle = Style69
        Me.cboPreservationMethod.Images.Add(CType(resources.GetObject("cboPreservationMethod.Images"), System.Drawing.Image))
        Me.cboPreservationMethod.Location = New System.Drawing.Point(376, 512)
        Me.cboPreservationMethod.Name = "cboPreservationMethod"
        Me.cboPreservationMethod.OddRowStyle = Style70
        Me.cboPreservationMethod.RecordSelectorStyle = Style71
        Me.cboPreservationMethod.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPreservationMethod.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboPreservationMethod.RowHeight = 20
        Me.cboPreservationMethod.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPreservationMethod.ScrollTips = False
        Me.cboPreservationMethod.Size = New System.Drawing.Size(192, 144)
        Me.cboPreservationMethod.Style = Style72
        Me.cboPreservationMethod.TabIndex = 122
        Me.cboPreservationMethod.Text = "C1TrueDBDropdown1"
        Me.cboPreservationMethod.Visible = False
        Me.cboPreservationMethod.PropBag = resources.GetString("cboPreservationMethod.PropBag")
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMFV, Me.mnuMFAO})
        '
        'mnuMFV
        '
        Me.mnuMFV.Index = 0
        Me.mnuMFV.Text = "Fishing &Vessel"
        '
        'mnuMFAO
        '
        Me.mnuMFAO.Index = 1
        Me.mnuMFAO.Text = "&FAO Catch Area"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Gray
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 276)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 16)
        Me.Label23.TabIndex = 124
        Me.Label23.Text = "Ocean of Capture"
        '
        'txtFVTrans
        '
        Me.txtFVTrans.EmptyAsNull = True
        Me.txtFVTrans.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFVTrans.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtFVTrans.Location = New System.Drawing.Point(136, 205)
        Me.txtFVTrans.Name = "txtFVTrans"
        Me.txtFVTrans.ReadOnly = True
        Me.txtFVTrans.Size = New System.Drawing.Size(128, 23)
        Me.txtFVTrans.TabIndex = 5
        Me.txtFVTrans.Tag = Nothing
        Me.txtFVTrans.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtCarArrive
        '
        Me.txtCarArrive.EmptyAsNull = True
        Me.txtCarArrive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarArrive.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtCarArrive.Location = New System.Drawing.Point(648, 149)
        Me.txtCarArrive.Name = "txtCarArrive"
        Me.txtCarArrive.ReadOnly = True
        Me.txtCarArrive.Size = New System.Drawing.Size(120, 23)
        Me.txtCarArrive.TabIndex = 10
        Me.txtCarArrive.Tag = Nothing
        Me.txtCarArrive.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtCarDepart
        '
        Me.txtCarDepart.EmptyAsNull = True
        Me.txtCarDepart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarDepart.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtCarDepart.Location = New System.Drawing.Point(648, 176)
        Me.txtCarDepart.Name = "txtCarDepart"
        Me.txtCarDepart.ReadOnly = True
        Me.txtCarDepart.Size = New System.Drawing.Size(120, 23)
        Me.txtCarDepart.TabIndex = 11
        Me.txtCarDepart.Tag = Nothing
        Me.txtCarDepart.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cboSublot
        '
        Me.cboSublot.AllowColMove = False
        Me.cboSublot.AllowColSelect = True
        Me.cboSublot.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSublot.AlternatingRows = False
        Me.cboSublot.CaptionStyle = Style73
        Me.cboSublot.ColumnCaptionHeight = 17
        Me.cboSublot.ColumnFooterHeight = 17
        Me.cboSublot.Enabled = False
        Me.cboSublot.EvenRowStyle = Style74
        Me.cboSublot.FetchRowStyles = False
        Me.cboSublot.FooterStyle = Style75
        Me.cboSublot.HeadingStyle = Style76
        Me.cboSublot.HighLightRowStyle = Style77
        Me.cboSublot.Images.Add(CType(resources.GetObject("cboSublot.Images"), System.Drawing.Image))
        Me.cboSublot.Location = New System.Drawing.Point(200, 512)
        Me.cboSublot.Name = "cboSublot"
        Me.cboSublot.OddRowStyle = Style78
        Me.cboSublot.RecordSelectorStyle = Style79
        Me.cboSublot.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSublot.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSublot.RowHeight = 20
        Me.cboSublot.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSublot.ScrollTips = False
        Me.cboSublot.Size = New System.Drawing.Size(93, 144)
        Me.cboSublot.Style = Style80
        Me.cboSublot.TabIndex = 125
        Me.cboSublot.Text = "C1TrueDBDropdown1"
        Me.cboSublot.Visible = False
        Me.cboSublot.PropBag = resources.GetString("cboSublot.PropBag")
        '
        'cboPortTrans
        '
        Me.cboPortTrans.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboPortTrans.AllowColMove = False
        Me.cboPortTrans.AutoCompletion = True
        Me.cboPortTrans.AutoDropDown = True
        Me.cboPortTrans.Caption = ""
        Me.cboPortTrans.CaptionHeight = 17
        Me.cboPortTrans.CaptionStyle = Style81
        Me.cboPortTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPortTrans.ColumnCaptionHeight = 17
        Me.cboPortTrans.ColumnFooterHeight = 17
        Me.cboPortTrans.ContentHeight = 18
        Me.cboPortTrans.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPortTrans.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPortTrans.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPortTrans.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPortTrans.EditorHeight = 18
        Me.cboPortTrans.EvenRowStyle = Style82
        Me.cboPortTrans.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPortTrans.FooterStyle = Style83
        Me.cboPortTrans.HeadingStyle = Style84
        Me.cboPortTrans.HighLightRowStyle = Style85
        Me.cboPortTrans.Images.Add(CType(resources.GetObject("cboPortTrans.Images"), System.Drawing.Image))
        Me.cboPortTrans.ItemHeight = 20
        Me.cboPortTrans.Location = New System.Drawing.Point(328, 204)
        Me.cboPortTrans.MatchEntryTimeout = CType(2000, Long)
        Me.cboPortTrans.MaxDropDownItems = CType(10, Short)
        Me.cboPortTrans.MaxLength = 32767
        Me.cboPortTrans.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPortTrans.Name = "cboPortTrans"
        Me.cboPortTrans.OddRowStyle = Style86
        Me.cboPortTrans.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPortTrans.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPortTrans.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPortTrans.SelectedStyle = Style87
        Me.cboPortTrans.Size = New System.Drawing.Size(184, 24)
        Me.cboPortTrans.Style = Style88
        Me.cboPortTrans.TabIndex = 6
        Me.cboPortTrans.PropBag = resources.GetString("cboPortTrans.PropBag")
        '
        'cboPortUnload
        '
        Me.cboPortUnload.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboPortUnload.AllowColMove = False
        Me.cboPortUnload.AutoCompletion = True
        Me.cboPortUnload.AutoDropDown = True
        Me.cboPortUnload.Caption = ""
        Me.cboPortUnload.CaptionHeight = 17
        Me.cboPortUnload.CaptionStyle = Style89
        Me.cboPortUnload.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPortUnload.ColumnCaptionHeight = 17
        Me.cboPortUnload.ColumnFooterHeight = 17
        Me.cboPortUnload.ContentHeight = 18
        Me.cboPortUnload.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboPortUnload.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboPortUnload.EditorFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPortUnload.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPortUnload.EditorHeight = 18
        Me.cboPortUnload.EvenRowStyle = Style90
        Me.cboPortUnload.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPortUnload.FooterStyle = Style91
        Me.cboPortUnload.HeadingStyle = Style92
        Me.cboPortUnload.HighLightRowStyle = Style93
        Me.cboPortUnload.Images.Add(CType(resources.GetObject("cboPortUnload.Images"), System.Drawing.Image))
        Me.cboPortUnload.ItemHeight = 20
        Me.cboPortUnload.Location = New System.Drawing.Point(328, 234)
        Me.cboPortUnload.MatchEntryTimeout = CType(2000, Long)
        Me.cboPortUnload.MaxDropDownItems = CType(10, Short)
        Me.cboPortUnload.MaxLength = 32767
        Me.cboPortUnload.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboPortUnload.Name = "cboPortUnload"
        Me.cboPortUnload.OddRowStyle = Style94
        Me.cboPortUnload.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboPortUnload.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboPortUnload.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboPortUnload.SelectedStyle = Style95
        Me.cboPortUnload.Size = New System.Drawing.Size(184, 24)
        Me.cboPortUnload.Style = Style96
        Me.cboPortUnload.TabIndex = 8
        Me.cboPortUnload.PropBag = resources.GetString("cboPortUnload.PropBag")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Gray
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(296, 208)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 16)
        Me.Label24.TabIndex = 128
        Me.Label24.Text = "Port"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Gray
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(296, 238)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 16)
        Me.Label25.TabIndex = 129
        Me.Label25.Text = "Port"
        '
        'cboSet
        '
        Me.cboSet.AllowColMove = False
        Me.cboSet.AllowColSelect = True
        Me.cboSet.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboSet.AlternatingRows = False
        Me.cboSet.CaptionStyle = Style97
        Me.cboSet.ColumnCaptionHeight = 17
        Me.cboSet.ColumnFooterHeight = 17
        Me.cboSet.Enabled = False
        Me.cboSet.EvenRowStyle = Style98
        Me.cboSet.FetchRowStyles = False
        Me.cboSet.FooterStyle = Style99
        Me.cboSet.HeadingStyle = Style100
        Me.cboSet.HighLightRowStyle = Style101
        Me.cboSet.Images.Add(CType(resources.GetObject("cboSet.Images"), System.Drawing.Image))
        Me.cboSet.Location = New System.Drawing.Point(736, 512)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.OddRowStyle = Style102
        Me.cboSet.RecordSelectorStyle = Style103
        Me.cboSet.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboSet.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboSet.RowHeight = 20
        Me.cboSet.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSet.ScrollTips = False
        Me.cboSet.Size = New System.Drawing.Size(140, 144)
        Me.cboSet.Style = Style104
        Me.cboSet.TabIndex = 130
        Me.cboSet.Text = "C1TrueDBDropdown1"
        Me.cboSet.Visible = False
        Me.cboSet.PropBag = resources.GetString("cboSet.PropBag")
        '
        'chkNoCC
        '
        Me.chkNoCC.Enabled = False
        Me.chkNoCC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoCC.Location = New System.Drawing.Point(520, 58)
        Me.chkNoCC.Name = "chkNoCC"
        Me.chkNoCC.Size = New System.Drawing.Size(152, 24)
        Me.chkNoCC.TabIndex = 131
        Me.chkNoCC.Text = "without certificate"
        Me.chkNoCC.Visible = False
        '
        'frmSICC_DataEntry2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(922, 488)
        Me.ContextMenu = Me.ContextMenu1
        Me.ControlBox = False
        Me.Controls.Add(Me.chkNoCC)
        Me.Controls.Add(Me.cboSet)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cboPortUnload)
        Me.Controls.Add(Me.cboPortTrans)
        Me.Controls.Add(Me.cboSublot)
        Me.Controls.Add(Me.txtCarDepart)
        Me.Controls.Add(Me.txtCarArrive)
        Me.Controls.Add(Me.txtFVTrans)
        Me.Controls.Add(Me.txtFVArrive)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cboPreservationMethod)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.gridLot)
        Me.Controls.Add(Me.cboRefNo)
        Me.Controls.Add(Me.cboAreaCode)
        Me.Controls.Add(Me.gridContainer)
        Me.Controls.Add(Me.cboCarHatch)
        Me.Controls.Add(Me.cboCarTrip)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOcean)
        Me.Controls.Add(Me.cboCarrier)
        Me.Controls.Add(Me.txtFVUnload)
        Me.Controls.Add(Me.txtFVDepart)
        Me.Controls.Add(Me.cboVessel)
        Me.Controls.Add(Me.cboDelivery)
        Me.Controls.Add(Me.cboCC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSICC_DataEntry2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        CType(Me.cboCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVessel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFVDepart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFVArrive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFVUnload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarrier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarTrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarHatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAreaCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPreservationMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFVTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCarArrive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCarDepart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSublot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPortTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPortUnload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmSICC_DataEntry2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = getSystemTitle()
        editMode = False
        startup = 0
        'txtDateValid.Value = getServerDateTime()
        txtFVDepart.Value = getServerDateTime()
        txtFVArrive.Value = Format(getServerDateTime(), getTimeFormat())
        'txtFVTrans.Value = getServerDateTime()
        txtFVUnload.Value = getServerDateTime()

        dataEntry(1)

        displayCC()
        displayAllDelivery()
        displayFishingVessel()
        displayCarrier()
        displayCatchAreas()
        displayCC_Reference()
        'displayFishingMethods()
        'displayListsofFishLot(txtDateDepart.Value)

        displayListsOfContainer(cboCC.Text)
        displayListsofFishLot(txtFVArrive.Value)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub displayAllDelivery()
        With cboDelivery
            .DataSource = modModule.getAllDelivery().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 164

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayCC()
        With cboCC
            .DataSource = modModule.getCC().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 353 '164

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayFishingVessel()
        With cboVessel
            .DataSource = modModule.getFishingVessel().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 353

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayCarrier()
        With cboCarrier
            .DataSource = modModule.getCarrier().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 204

            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Public Sub displayCatchAreas()
        With cboAreaCode
            .DataSource = modModule.getAllCatchAreas().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 50
            .Splits(0).DisplayColumns(1).Width = 200
        End With
    End Sub

    Public Sub displayCC_Reference()
        With cboRefNo
            .DataSource = modModule.getCC_Reference().Tables(0)
            .Splits(0).DisplayColumns(0).Width = 204
        End With
    End Sub

    'Public Sub displayFishingMethods()
    '    With cboMethod
    '        .DataSource = modModule.getFishingMethod().Tables(0)
    '        .Splits(0).DisplayColumns(0).Width = 225
    '    End With
    'End Sub

    Public Sub buttons(ByVal i As Integer)
        Select Case i
            Case 0
                Me.cmdPrint.Enabled = False
                Me.cmdFind.Enabled = False
                Me.cmdClose.Enabled = False
            Case 1
                Me.cmdPrint.Enabled = True
                Me.cmdFind.Enabled = True
                Me.cmdClose.Enabled = True
        End Select
    End Sub

    Public Sub dataEntry(ByVal s As Int16)
        'used to disable and enable data entry controls
        With Me
            Select Case s
                Case 0  'enable
                    '.cboCC.ReadOnly = False
                    .chkNoCC.Enabled = True
                    .cboDelivery.ReadOnly = False
                    .cboVessel.ReadOnly = False
                    .txtFVDepart.ReadOnly = False
                    .txtFVArrive.ReadOnly = False
                    .txtFVTrans.ReadOnly = True
                    .cboPortTrans.ReadOnly = True
                    .txtFVUnload.ReadOnly = False
                    .cboPortUnload.ReadOnly = False
                    '.txtFVUnload.ReadOnly = False
                    '.cboCarrier.ReadOnly = True
                    '.txtCarDepart.ReadOnly = True
                    '.txtCarArrive.ReadOnly = True
                    '.cboCarTrip.ReadOnly = True
                    '.cboCarHatch.ReadOnly = True
                    '.gridContainer.Enabled = False
                    .cboAreaCode.ReadOnly = False
                    .cboRefNo.ReadOnly = False
                    .gridContainer.Enabled = True
                    .gridLot.Enabled = True
                Case 1  'disable
                    '.cboCC.ReadOnly = True
                    .chkNoCC.Enabled = False
                    .cboDelivery.ReadOnly = True
                    .cboVessel.ReadOnly = True
                    .txtFVDepart.ReadOnly = True
                    .txtFVArrive.ReadOnly = True
                    .txtFVTrans.ReadOnly = True
                    .cboPortTrans.ReadOnly = True
                    .txtFVUnload.ReadOnly = True
                    .cboPortUnload.ReadOnly = True
                    '.cboCarrier.ReadOnly = True
                    '.txtCarDepart.ReadOnly = True
                    '.txtCarArrive.ReadOnly = True
                    '.cboCarTrip.ReadOnly = True
                    '.cboCarHatch.ReadOnly = True
                    '.gridContainer.Enabled = False
                    .cboAreaCode.ReadOnly = True
                    .cboRefNo.ReadOnly = True
                    .gridContainer.Enabled = False
                    .gridLot.Enabled = False
            End Select
        End With
    End Sub

    Private Sub cboAreaCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreaCode.TextChanged
        If Not cboAreaCode.Text = "" Then
            lblOcean.Text = getFAOOCean(cboAreaCode.Text)
        Else
            lblOcean.Text = ""
        End If
    End Sub

    Public Sub addNewRecord()
        With Me
            '.cboCC.ReadOnly = False
            .cboCC.Text = ""
            displayCC()
            .chkNoCC.Enabled = True
            .chkNoCC.Checked = False
            .cboCC.Text = ""
            .displayAllDelivery()
            .cboDelivery.Text = ""
            'txtDateValid.Value = getServerDateTime()
            'cboAuthority.Text = "Ministry Of Fisheries And Marine Resources"
            .displayFishingVessel()
            .cboVessel.ReadOnly = False
            .cboVessel.Text = ""
            '.txtFVDepart.TextDetached = True
            .txtFVDepart.Value = getServerDateTime()
            '.txtFVArrive.TextDetached = True
            .txtFVArrive.Value = getServerDateTime()
            .cboPortTrans.Text = ""
            '.txtFVTrans.Value = ""
            '.txtFVTrans.EditMask = ""
            '.txtFVUnload.TextDetached = True
            .txtFVUnload.Value = getServerDateTime()
            .cboPortUnload.Text = ""

            .displayCarrier()
            .cboCarrier.Text = ""
            '.txtCarDepart.Value = ""
            '.txtCarDepart.EditMask = ""
            '.txtCarArrive.Value = ""
            '.txtCarArrive.EditMask = ""
            .cboCarTrip.Text = ""
            .cboCarHatch.Text = ""

            'displayFishingMethods()
            'cboMethod.Text = ""
            .displayCatchAreas()
            .cboAreaCode.Text = ""
            'lblOcean.Text = ""
            'cboProduct.Text = "FROZEN TUNA"
            'cboProcessing.Text = "BRINE FREEZING"
            displayListsOfContainer(cboCC.Text)
            gridContainer.Enabled = False
            .displayCC_Reference()
            .cboRefNo.Text = "*"

            .displayListsofFishLot(txtFVArrive.Value)
            'displayAllCC()
        End With
    End Sub

    Public Sub displayFishingVesselDetails(ByVal vessel As String)
        'Try
        '    Dim c As New SqlClient.SqlConnection()
        '    c.ConnectionString = modModule.getConnectionString
        '    c.Open()

        '    Dim cmd As New SqlClient.SqlCommand()
        '    cmd.CommandText = "proc_display_FishingVesselDetails"
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Connection = c

        '    Dim p1 As New SqlClient.SqlParameter()
        '    p1.ParameterName = "@vessel"
        '    p1.SqlDbType = SqlDbType.VarChar
        '    p1.Direction = ParameterDirection.Input
        '    p1.Value = vessel

        '    cmd.Parameters.Add(p1)

        '    Dim dr As SqlClient.SqlDataReader
        '    dr = cmd.ExecuteReader

        '    If dr.Read Then
        '        If Not dr(0) Is DBNull.Value Then
        '            'lblCode.Text = dr.GetString(0)
        '            'txtFlag.Text = dr.GetString(2)
        '            'txtPort.Text = dr.GetString(3)
        '            lblRegNo.Text = dr.GetString(4)
        '            lblCallSign.Text = dr.GetString(5)
        '            'txtImo.Text = dr.GetString(6)
        '            lblLicNo.Text = dr.GetString(7)
        '            'txtImmarsat.Text = dr.GetString(8)
        '            'txtTelefax.Text = dr.GetString(9)
        '            lblExpiration.Text = dr.GetDateTime(10)
        '            lblTelNo.Text = dr.GetString(11)
        '            lblEmail.Text = dr.GetString(12)
        '        Else
        '            'lblCode.Text = dr.GetString(0)
        '            'txtFlag.Text = dr.GetString(2)
        '            'txtPort.Text = dr.GetString(3)
        '            lblRegNo.Text = ""
        '            lblCallSign.Text = ""
        '            'txtImo.Text = dr.GetString(6)
        '            lblLicNo.Text = ""
        '            'txtImmarsat.Text = dr.GetString(8)
        '            'txtTelefax.Text = dr.GetString(9)
        '            lblExpiration.Text = ""
        '            lblTelNo.Text = ""
        '            lblEmail.Text = ""
        '        End If
        '    Else
        '        'lblCode.Text = dr.GetString(0)
        '        'txtFlag.Text = dr.GetString(2)
        '        'txtPort.Text = dr.GetString(3)
        '        lblRegNo.Text = ""
        '        lblCallSign.Text = ""
        '        'txtImo.Text = dr.GetString(6)
        '        lblLicNo.Text = ""
        '        'txtImmarsat.Text = dr.GetString(8)
        '        'txtTelefax.Text = dr.GetString(9)
        '        lblExpiration.Text = ""
        '        lblTelNo.Text = ""
        '        lblEmail.Text = ""
        '    End If

        '    dr.Close()
        '    c.Close()
        'Catch e As Exception
        '    'MsgBox(e.Message)
        '    MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        'Finally
        'End Try
    End Sub

    Private Sub cboVessel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVessel.TextChanged
        setFishLot()
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click

        'If chkNoCC.Checked Then
        '    cc = "SIC-NFD [SOLTAI] " & gridLot.Item(0, 0)
        'Else
        '    cc = cboCC.Text
        'End If

        'If Not cboVessel.Text.Trim = "" Then
        '    'Format(CInt(getVesselCode(cboVessel.Text)), "0#") & _
        '    cboCC.Text = getVesselCode(cboVessel.Text) & _
        '                 Format(CInt(getFishingVesselTrip(cboVessel.Text)), "0#") & _
        '                Format(CInt(getFishYear()), "0#")
        'Else
        '    cboCC.Text = ""
        'End If

        Dim cc As String = cboCC.Text

        gridLot.Refresh()
        gridLot.Refresh()
        displayPMFishCondition()

        Dim reply As String
        Select Case cmd.Text
            Case "&Add"
                cmd.Text = "&Save"
                cmdEdit.Text = "&Cancel"
                buttons(0)
                dataEntry(0)
                addNewRecord()
                'Me.TabControl1.SelectedIndex = 0
                editMode = False
                cboDelivery.SelectAll() 'cboCC.SelectAll()
                cboDelivery.Focus() 'cboCC.Focus()
            Case "&Save"
                If Not cboVessel.Text.Trim = "" Then
                    'Format(CInt(getVesselCode(cboVessel.Text)), "0#") & _
                    cboCC.Text = getVesselCode(cboVessel.Text) & _
                                 Format(CInt(getFishingVesselTrip(cboVessel.Text)), "0#") & _
                                Format(CInt(getFishYear()), "0#")
                Else
                    cboCC.Text = ""
                End If

                cc = cboCC.Text

                setFishLot()
                'Not cboRefNo.Text.Trim = "" And 
                'gridLot.RowCount > 0 And Not isFishLotEntriesEmpty() And 
                If Not cboCC.Text.Trim = "" And validateDataEntries(cboDelivery.Text) And _
                Not cboAreaCode.Text.Trim = "" And Not lblOcean.Text.Trim = "" And _
                Not isContainerEntriesEmpty() Then
                    If Not validateCC(cc) Then
                        reply = MsgBox("Are you sure you want to add this new record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If reply = vbYes Then
                            saveNewSICC(cc, CDate(getServerDateTime()), "Ministry Of Fisheries And Marine Resources", cboVessel.Text, _
                                txtFVDepart.Text, txtFVArrive.Text, "*", cboAreaCode.Text, "FROZEN TUNA", _
                                "BRINE FREEZING", cboRefNo.Text, txtFVUnload.Text, txtFVTrans.Text, cboCarrier.Text, _
                                txtCarDepart.Text, txtCarArrive.Text, cboCarTrip.Text, cboCarHatch.Text, _
                                cboDelivery.Text, cboPortTrans.Text, cboPortUnload.Text)

                            saveNewSICC_Details(cc, "", "", cboAreaCode.Text, "1/1/1901", "1/1/1901", "0", "0")

                            'SAVE CONTAINERS PER SICC
                            Dim ctr As Integer
                            While ctr < gridContainer.RowCount
                                saveNewSICC_Containers(cc, gridContainer.Item(ctr, 2), gridContainer.Item(ctr, 0), gridContainer.Item(ctr, 1))

                                ctr += 1
                            End While


                            'SAVE BATCHLOT
                            ctr = 0
                            While ctr < gridLot.RowCount
                                If Not validateFishLot(cc) Then 'gridLot.Item(ctr, 0)
                                    ''CInt(CStr(cc).Substring(2, 2))
                                    'CInt(CStr(cc).Substring(4, 2))
                                    saveNewFishLot(cc, "National%", "Normal Quality", cc, "Frozen", txtFVUnload.Text, _
                                        Format(CInt(getFishingVesselTrip(cboVessel.Text)), "0#"), _
                                        Format(CInt(getFishYear()), "0#"))


                                    'gridLot.Item(ctr, 0), gridLot.Item(ctr, 3)

                                    'Else
                                    'MsgBox("Fish lot number " & grid.Item(ctr, 0) & " already stored in the database" & Chr(13) & _
                                    '"To update, please proceed to Transaction menu and select Update Fish Lot Information.", MsgBoxStyle.Exclamation, "Warning!")
                                End If

                                ctr += 1
                            End While

                            '*********** REMOVE THIS PART AS THEIR WILL BE NEW INTERFACE FOR FISH LOT/ SUBLOT ****************************
                            ''SAVE BATCHLOT DETAILS SUCH AS SUBLOT
                            'ctr = 0
                            'deleteBatchLotDetails(gridLot.Item(0, 0))

                            'While ctr < gridLot.RowCount
                            '    If Not validateFishLotDetails(gridLot.Item(ctr, 0), gridLot.Item(ctr, 2), gridLot.Item(ctr, 1)) Then
                            '        If cboDelivery.Text.StartsWith("Direct") Then
                            '            saveNewFishLotDetails(gridLot.Item(ctr, 0), gridLot.Item(ctr, 1), gridLot.Item(ctr, 2), gridLot.Item(ctr, 4), gridLot.Item(ctr, 5))
                            '        Else
                            '            saveNewFishLotDetails(gridLot.Item(ctr, 0), gridLot.Item(ctr, 1), gridLot.Item(ctr, 2), "", gridLot.Item(ctr, 5))
                            '        End If
                            '    Else
                            '        MsgBox("Fish sub-lot number " & gridLot.Item(ctr, 1) & " with preservation method of " & gridLot.Item(ctr, 2) & " already stored in the database", MsgBoxStyle.Exclamation, "Warning!")
                            '    End If

                            '    ctr += 1
                            'End While
                            '***********************************************************************************************


                            cmd.Text = "&Add"
                            cmdEdit.Text = "&Edit"
                            buttons(1)
                            dataEntry(1)
                            editMode = False

                            'displayAllCC()
                            editMode = False
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "Information")
                            cmd.Focus()
                        End If
                    Else
                        MsgBox("Catch Certificate already exists in the system. Please have another record.", MsgBoxStyle.Critical, "Result: Found duplicate record.")
                        cboCC.SelectAll()
                        cboCC.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboCC.Text = ""
                    cboDelivery.SelectAll()
                    cboDelivery.Focus()
                End If
            Case "&Save "
                'Not isFishLotEntriesEmpty() And 
                If validateDataEntries(cboDelivery.Text) And _
                Not isContainerEntriesEmpty() Then
                    reply = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If reply = vbYes Then
                        updateSICC(cc, CStr(getServerDateTime()), "Ministry Of Fisheries And Marine Resources", cboVessel.Text, _
                            txtFVDepart.Text, txtFVArrive.Text, "*", cboAreaCode.Text, _
                            "FROZEN TUNA", "BRINE FREEZING", cboRefNo.Text, txtFVUnload.Text, txtFVTrans.Text, _
                            cboCarrier.Text, txtCarDepart.Text, txtCarArrive.Text, cboCarTrip.Text, _
                            cboCarHatch.Text, cboDelivery.Text, cboPortTrans.Text, cboPortUnload.Text)
                        updateSICCDetails(cc, "", "", cboAreaCode.Text, "1/1/1901", "1/1/1901", "0", "0")

                        deleteSICCContainers(cc)

                        'SAVE CONTAINERS PER SICC
                        Dim ctr As Integer
                        While ctr < gridContainer.RowCount
                            saveNewSICC_Containers(cc, gridContainer.Item(ctr, 2), gridContainer.Item(ctr, 0), gridContainer.Item(ctr, 1))

                            ctr += 1
                        End While

                        'SAVE BATCHLOT
                        ctr = 0
                        While ctr < gridLot.RowCount
                            If Not validateFishLot(cc) Then 'gridLot.Item(ctr, 0)
                                saveNewFishLot(cc, "National%", "Normal Quality", cc, "Frozen", txtFVUnload.Text, _
                                     Format(CInt(getFishingVesselTrip(cboVessel.Text)), "0#"), _
                                     Format(CInt(getFishYear()), "0#"))
                                'gridLot.Item(ctr, 0), gridLot.Item(ctr, 3)

                                'Else
                                '    MsgBox("Fish lot number " & grid.Item(ctr, 0) & " already stored in the database" & Chr(13) & _
                                '        "To update, please proceed to Transaction menu and select Update Fish Lot Information.", MsgBoxStyle.Exclamation, "Warning!")
                            End If

                            ctr += 1
                        End While

                        '*********** REMOVE THIS PART AS THEIR WILL BE NEW INTERFACE FOR FISH LOT/ SUBLOT ****************************
                        ''SAVE BATCHLOT DETAILS SUCH AS SUBLOT
                        'ctr = 0
                        'deleteBatchLotDetails(gridLot.Item(0, 0))

                        'While ctr < gridLot.RowCount
                        '    If Not validateFishLotDetails(gridLot.Item(ctr, 0), gridLot.Item(ctr, 2), gridLot.Item(ctr, 1)) Then
                        '        If cboDelivery.Text.StartsWith("Direct") Then
                        '            saveNewFishLotDetails(gridLot.Item(ctr, 0), gridLot.Item(ctr, 1), gridLot.Item(ctr, 2), gridLot.Item(ctr, 4), gridLot.Item(ctr, 5))
                        '        Else
                        '            saveNewFishLotDetails(gridLot.Item(ctr, 0), gridLot.Item(ctr, 1), gridLot.Item(ctr, 2), "", gridLot.Item(ctr, 5))
                        '        End If
                        '    Else
                        '        MsgBox("Fish sub-lot number " & gridLot.Item(ctr, 1) & " with preservation method of " & gridLot.Item(ctr, 2) & " already stored in the database", MsgBoxStyle.Exclamation, "Warning!")
                        '    End If

                        '    ctr += 1
                        'End While
                        ''MsgBox("Fish lot is not allowed to update from this module," & _
                        ''    "Please use the Fish Lot interface to update but with proper authorization", MsgBoxStyle.Exclamation, "Warning")

                        '***********************************************************************************************

                        cmd.Text = "&Add"
                        cmdEdit.Text = "&Edit"
                        buttons(1)
                        dataEntry(1)
                        editMode = False

                        'displayAllCC()
                        editMode = False
                        MsgBox("You have successfully update a record", MsgBoxStyle.Information, "Information")
                        cmd.Focus()
                    End If
                Else
                    MsgBox("Kindly fill out important field(s)", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboVessel.SelectAll()
                    cboVessel.Focus()
                End If
        End Select
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If Not cboCC.Text = "" Then
                    cmd.Text = "&Save "
                    cmdEdit.Text = "&Cancel"
                    buttons(0)
                    dataEntry(0)

                    cboCC.ReadOnly = True
                    chkNoCC.Enabled = False
                    editMode = True
                    dataEntryForDelivery()
                    'cboDelivery_TextChanged(sender, New EventArgs())

                    cboDelivery.SelectAll()
                    cboDelivery.Focus()
                Else
                    MsgBox("Kindly fill out blank fields.", MsgBoxStyle.Critical, "Result: Found missing value.")
                    cboDelivery.SelectAll()
                    cboDelivery.Focus()
                    Exit Sub
                End If
            Case "&Cancel"
                cmd.Text = "&Add"
                cmdEdit.Text = "&Edit"
                buttons(1)
                dataEntry(1)
                editMode = False
                cmdEdit.Focus()
        End Select
    End Sub

    Public Sub displayRecord(ByVal cc As String)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_search_CC"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim p1 As New SqlClient.SqlParameter
            p1.ParameterName = "@cc"
            p1.SqlDbType = SqlDbType.VarChar
            p1.Direction = ParameterDirection.Input
            p1.Value = cc

            cmd.Parameters.Add(p1)

            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader

            If dr.Read Then
                'If Not dr(0) Is DBNull.Value Then
                cboDelivery.Text = dr.GetString(1)
                cboVessel.Text = dr.GetString(2)
                txtFVDepart.Value = dr.GetDateTime(3)

                'MsgBox("FV Departure: " & dr.GetDateTime(3) & Chr(13) & _
                '    "FV Arrival: " & dr.GetString(4) & Chr(13) & _
                '    "FV Transshipment: " & dr.GetString(5) & Chr(13) & _
                '    "FV Unloading: " & dr.GetString(6))

                txtFVArrive.TextDetached = True
                txtFVArrive.Value = dr.GetString(4)    'Format(CDate(dr.GetString(4)), getTimeFormat())
                txtFVArrive.TextDetached = False

                txtFVTrans.TextDetached = True
                txtFVTrans.Value = dr.GetString(5) 'Format(CDate(dr.GetString(5)), getTimeFormat())
                txtFVTrans.TextDetached = False

                txtFVUnload.TextDetached = True
                txtFVUnload.Value = dr.GetString(6) 'Format(CDate(dr.GetString(6)), getTimeFormat())
                txtFVUnload.TextDetached = False

                cboCarrier.Text = dr.GetString(7)
                txtCarDepart.Value = dr.GetString(8)
                txtCarArrive.Value = dr.GetString(9)
                cboCarTrip.Text = dr.GetString(10)
                cboCarHatch.Text = dr.GetString(11)
                cboAreaCode.Text = dr.GetString(12)
                cboRefNo.Text = dr.GetString(14)
                cboPortTrans.Text = dr.GetString(15)
                cboPortUnload.Text = dr.GetString(16)
                'Else
                '    cboDelivery.Text = ""
                '    cboVessel.Text = ""
                '    txtFVDepart.Value = Format(getServerDateTime(), getTimeFormat())
                '    txtFVArrive.Value = Format(getServerDateTime(), getTimeFormat())
                '    txtFVTrans.Value = ""
                '    txtFVUnload.Value = Format(getServerDateTime(), getTimeFormat())
                '    cboCarrier.Text = ""
                '    txtCarDepart.Value = ""
                '    txtCarArrive.Value = ""
                '    cboCarTrip.Text = ""
                '    cboCarHatch.Text = ""
                '    cboAreaCode.Text = ""
                '    cboRefNo.Text = ""
                'End If
            Else
                cboDelivery.Text = ""
                cboVessel.Text = ""
                txtFVDepart.Value = Format(getServerDateTime(), getTimeFormat())
                txtFVArrive.Value = Format(getServerDateTime(), getTimeFormat())
                txtFVTrans.Value = ""
                txtFVUnload.Value = Format(getServerDateTime(), getTimeFormat())
                cboCarrier.Text = ""
                txtCarDepart.Value = ""
                txtCarArrive.Value = ""
                cboCarTrip.Text = ""
                cboCarHatch.Text = ""
                cboAreaCode.Text = ""
                cboRefNo.Text = ""
                cboPortTrans.Text = ""
                cboPortUnload.Text = ""
            End If

            dr.Close()
            c.Close()

            'cboDelivery_TextChanged(New Object(), New EventArgs())
            displayListsOfContainer(cboCC.Text)
            displayFishLotBySICC(cboCC.Text)
        Catch e As Exception
            MsgBox(e.Message)
            'MsgBox("No record found in the database", MsgBoxStyle.Information, "Result: Record not found")
        Finally
        End Try
    End Sub

    Private Sub cboCC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCC.TextChanged
        'displayRecord(cboCC.Text)
        'dataEntryForDelivery()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim f As New frmSearch
        f.lblTitle.Text = "Search Trip Code"
        f.searchType = 2
        f.displayAllCC()
        f.ShowDialog(Me)

        If Not f.cancel Then cboCC.Text = f.searchItem
        displayRecord(cboCC.Text)
        '//displayRecord(f.searchItem)
        gridLot.FetchRowStyles = True
        'cboDelivery_TextChanged(sender, New EventArgs())
    End Sub

    Public Sub displayListsofFishLot(ByVal year As String)
        With gridLot
            .DataSource = modModule.getListsOfFishLot(year).Tables(0)
            .Columns(1).DropDown = cboSublot
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Columns(2).DropDown = cboPreservationMethod
            .Splits(0).DisplayColumns(2).DropDownList = True
            .Columns(5).DropDown = cboSet
            .Splits(0).DisplayColumns(5).DropDownList = True

            displaySublots()
            displayPreservationMethod()
            displayTypeOfSets()

            .Splits(0).DisplayColumns(0).Width = 90
            .Splits(0).DisplayColumns(1).Width = 90
            '.Columns(1).DefaultValue = 0
            '.Columns(1).NumberFormat = "##"
            .Splits(0).DisplayColumns(2).Width = 190
            '.Columns(2).NumberFormat = "##"
            .Splits(0).DisplayColumns(3).Width = 130
            '.Columns(3).NumberFormat = "##"
            .Splits(0).DisplayColumns(4).Width = 90
            .Splits(0).DisplayColumns(5).Width = 140

            '.Splits(0).DisplayColumns(0).Locked = True
            '.Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(1).Locked = True
            '.Splits(0).DisplayColumns(1).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(3).Locked = True
            '.Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(3).Locked = True
            .Splits(0).DisplayColumns(3).Locked = True
            .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(5).Locked = True
        End With
    End Sub

    Public Sub displaySublots()
        With cboSublot
            .DefColWidth = 70
            .DataSource = getSublot().Tables(0)
        End With
    End Sub

    Public Sub displayTypeOfSets()
        With cboSet
            .DefColWidth = 120
            .DataSource = getTypeOfSets().Tables(0)
        End With
    End Sub

    Private Sub gridLot_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles gridLot.RowColChange
        If startup > 0 Then ' And Not grid.Item(0, 1) Is DBNull.Value Then
            'grid.Columns(2).Value = Format(CDate(Me.txtDateArrive.Value), "yy")
            'countSublot()

            'setFishYear()
            'setFishTrip()
            displayPMFishCondition()
            setFishLot()
        End If

        startup += 1
    End Sub

    Public Sub countSublot()
        'With gridLot
        '    Dim ctr As Integer = 0
        '    While ctr < .RowCount
        '        '.Item(ctr, 1) = .Item(0, 1)
        '        .Item(ctr, 1) = ctr + 1
        '        ctr += 1
        '    End While
        'End With
    End Sub

    Public Sub displayPreservationMethod()
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "proc_displayAll_PreservationMethod"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = c

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            With cboPreservationMethod
                .DataSource = ds.Tables(0)

                .DisplayColumns(0).Width = 90
                .DisplayColumns(1).Width = 80
            End With


            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    'Private Sub cboPreservationMethod_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPreservationMethod.RowChange
    '    gridLot.Item(gridLot.Row, 2) = cboPreservationMethod.Columns(0).Value
    '    gridLot.Item(gridLot.Row, 3) = cboPreservationMethod.Columns(1).Value
    'End Sub

    Public Sub displayPMFishCondition()
        Dim ctr As Integer
        While ctr < gridLot.RowCount
            If Not gridLot.Item(ctr, 2) Is DBNull.Value Then
                gridLot.Item(ctr, 3) = getPMFishCondition(gridLot.Item(ctr, 2))
            Else
                gridLot.Item(ctr, 3) = ""
            End If

            ctr += 1
        End While
    End Sub

    Public Sub setFishLot() '(ByVal trip As Integer, ByVal yr As Integer)
        With gridLot
            Dim ctr As Integer
            While ctr < .RowCount
                'If Not .Item(ctr, 1) Is DBNull.Value And Not .Item(ctr, 2) Is DBNull.Value Then
                If Not editMode Then
                    If Not cboVessel.Text = "" Then
                        'CInt(getVesselCode(cboVessel.Text)), "0#") & _
                        .Item(ctr, 0) = getVesselCode(cboVessel.Text) & _
                            Format(CInt(getFishingVesselTrip(cboVessel.Text)), "0#") & _
                            Format(CInt(getFishYear()), "0#")
                        'Format(CInt(.Item(ctr, 1)), "0#") & _
                        'Format(CInt(.Item(ctr, 2)), "0#")
                        'Else
                        '    .Item(ctr, 0) = ""
                    End If
                Else
                    .Item(ctr, 0) = .Item(0, 0)
                End If

                ctr += 1
            End While
        End With
    End Sub

    Public Sub displayFishLotBySICC(ByVal certificate As String)
        With gridLot
            .DataSource = modModule.getFishlotBySICC(certificate).Tables(0)
            .Columns(1).DropDown = cboSublot
            .Splits(0).DisplayColumns(1).DropDownList = True
            .Columns(2).DropDown = cboPreservationMethod
            .Splits(0).DisplayColumns(2).DropDownList = True
            .Columns(5).DropDown = cboSet
            .Splits(0).DisplayColumns(5).DropDownList = True

            displaySublots()
            displayPreservationMethod()
            displayTypeOfSets()

            .Splits(0).DisplayColumns(0).Width = 90
            .Splits(0).DisplayColumns(1).Width = 90
            '.Columns(1).DefaultValue = 0
            '.Columns(1).NumberFormat = "##"
            .Splits(0).DisplayColumns(2).Width = 190
            '.Columns(2).NumberFormat = "##"
            .Splits(0).DisplayColumns(3).Width = 130
            '.Columns(3).NumberFormat = "##"
            .Splits(0).DisplayColumns(4).Width = 90
            .Splits(0).DisplayColumns(5).Width = 140

            '.Splits(0).DisplayColumns(0).Locked = True
            '.Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(1).Locked = True
            '.Splits(0).DisplayColumns(1).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(3).Locked = True
            '.Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(3).Locked = True
            .Splits(0).DisplayColumns(3).Locked = True
            .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
            '.Splits(0).DisplayColumns(5).Locked = True
        End With
        'With gridLot
        '    .DataSource = modModule.getFishlotBySICC(certificate).Tables(0)

        '    If .RowCount > 0 Then
        '        .Columns(2).DropDown = cboPreservationMethod
        '        .Splits(0).DisplayColumns(2).DropDownList = True

        '        displayPreservationMethod()

        '        .Splits(0).DisplayColumns(0).Width = 90
        '        .Splits(0).DisplayColumns(1).Width = 90
        '        .Columns(1).DefaultValue = 0
        '        .Columns(1).NumberFormat = "##"
        '        .Splits(0).DisplayColumns(2).Width = 190
        '        '.Columns(2).NumberFormat = "##"
        '        .Splits(0).DisplayColumns(3).Width = 130
        '        '.Columns(3).NumberFormat = "##"
        '        .Splits(0).DisplayColumns(4).Width = 90
        '        '.Splits(0).DisplayColumns(5).Width = 250

        '        '.Splits(0).DisplayColumns(0).Locked = True
        '        '.Splits(0).DisplayColumns(0).Style.BackColor = Color.Gray
        '        '.Splits(0).DisplayColumns(1).Locked = True
        '        '.Splits(0).DisplayColumns(1).Style.BackColor = Color.Gray
        '        '.Splits(0).DisplayColumns(3).Locked = True
        '        '.Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
        '        '.Splits(0).DisplayColumns(3).Locked = True
        '        .Splits(0).DisplayColumns(3).Locked = True
        '        .Splits(0).DisplayColumns(3).Style.BackColor = Color.Gray
        '        '.Splits(0).DisplayColumns(5).Locked = True
        '    Else
        '        displayListsofFishLot(txtFVArrive.Value)
        '    End If
        'End With
    End Sub

    Public Function isFishLotEntriesEmpty() As Boolean
        Try
            Dim ctr As Integer = 0
            With gridLot
                If cboDelivery.Text.StartsWith("Direct") Then
                    While ctr < .RowCount
                        If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or _
                             .Item(ctr, 2) Is DBNull.Value Or .Item(ctr, 3) Is DBNull.Value Or _
                             .Item(ctr, 4) Is DBNull.Value Or .Item(ctr, 5) Is DBNull.Value Then
                            Return True
                        End If

                        ctr += 1
                    End While
                Else
                    While ctr < .RowCount
                        If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or _
                         .Item(ctr, 2) Is DBNull.Value Or .Item(ctr, 3) Is DBNull.Value Or _
                         .Item(ctr, 5) Is DBNull.Value Then
                            Return True
                        End If

                        ctr += 1
                    End While
                End If
            End With

            Return False
        Catch e As Exception
            Dim ctr As Integer
            With gridLot
                If cboDelivery.Text.StartsWith("Direct") Then
                    While ctr < .RowCount
                        If .Item(ctr, 0) = "" Or .Item(ctr, 1) = "" Or _
                             .Item(ctr, 2) = "" Or .Item(ctr, 3) = "" Or _
                             .Item(ctr, 4) = "" Or .Item(ctr, 5) = "" Then
                            Return True
                        End If

                        ctr += 1
                    End While
                Else
                    While ctr < .RowCount
                        If .Item(ctr, 0) = "" Or .Item(ctr, 1) = "" Or _
                         .Item(ctr, 2) = "" Or .Item(ctr, 3) = "" Or .Item(ctr, 5) = "" Then
                            Return True
                        End If

                        ctr += 1
                    End While
                End If
            End With

            Return False
        End Try
    End Function

    Public Function isContainerEntriesEmpty() As Boolean
        Dim ctr As Integer
        If cboDelivery.Text.StartsWith("Direct") Then
            Return False
        ElseIf cboDelivery.Text.StartsWith("Reefer Carrier") Then
            Return False
        Else
            With gridContainer
                While ctr < .RowCount
                    If .Item(ctr, 0) Is DBNull.Value Or .Item(ctr, 1) Is DBNull.Value Or _
                         .Item(ctr, 2) Is DBNull.Value Then
                        Return True
                    End If
                    ctr += 1
                End While
            End With
        End If

        Return False
    End Function

    Public Function getFishYear() As String
        Try
            Dim ctr As Integer
            'If Not editMode Then
            Dim yr As String
            If gridLot.RowCount > 0 Then
                While ctr < gridLot.RowCount
                    If Not txtFVArrive.Value Is DBNull.Value Then
                        If Not txtFVArrive.Text = "" Then
                            yr = Format(CDate(Me.txtFVArrive.Value), "yy")
                        Else
                            yr = Format(getServerDateTime(), "yy")
                        End If
                    Else
                        yr = Format(getServerDateTime(), "yy")
                    End If

                    ctr += 1
                End While
            End If
            'End If
            'setFishTrip()
            'setFishLot()

            Return yr
        Catch e As Exception
            MsgBox("You have an invalid date format for Arrival Date, please used the standard format dd/MM/yyyy", MsgBoxStyle.Exclamation, "Warning")
        End Try
    End Function

    Private Sub cboDelivery_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDelivery.TextChanged
        dataEntryForDelivery()

        If Not editMode Then cboVessel_TextChanged(sender, New EventArgs)

        gridLot.FetchRowStyles = True
    End Sub

    Public Sub dataEntryForDelivery()
        If cmdEdit.Text = "&Cancel" Then
            If cboDelivery.Text.StartsWith("Direct") Then
                dataEntryForDelivery(0)
            ElseIf cboDelivery.Text.StartsWith("Reefer Carrier") Then
                dataEntryForDelivery(1)
            ElseIf cboDelivery.Text.StartsWith("Reefer Cont") Then
                dataEntryForDelivery(2)
            End If

        End If
    End Sub

    Public Sub dataEntryForDelivery(ByVal category As Integer)
        With Me
            Select Case category
                Case 0  'direct
                    .cboVessel.ReadOnly = False
                    .txtFVDepart.ReadOnly = False

                    .txtFVArrive.ReadOnly = False
                    If .txtFVArrive.Text = "" Then .txtFVArrive.Value = Format(getServerDateTime, getTimeFormat())

                    .txtFVTrans.TextDetached = False
                    .txtFVTrans.ReadOnly = True
                    .cboPortTrans.ReadOnly = True
                    .cboPortTrans.Text = ""
                    .txtFVTrans.Value = ""

                    .txtFVUnload.ReadOnly = False
                    .cboPortUnload.ReadOnly = False
                    .cboPortUnload.Text = ""
                    .displayPorts(False)
                    If .txtFVUnload.Text = "" Then .txtFVUnload.Value = Format(getServerDateTime, getTimeFormat())

                    .cboCarrier.ReadOnly = True
                    .txtCarArrive.Value = ""
                    .txtCarArrive.ReadOnly = True
                    .txtCarDepart.Value = ""
                    .txtCarDepart.ReadOnly = True
                    .cboCarTrip.ReadOnly = True
                    .cboCarHatch.ReadOnly = True
                    .gridContainer.Enabled = False

                    .cboCarrier.Text = ""
                    '.txtCarDepart.Value = ""
                    '.txtCarDepart.EditMask = ""
                    '.txtCarArrive.Value = ""
                    '.txtCarArrive.EditMask = ""
                    .cboCarTrip.Text = ""
                    .cboCarHatch.Text = ""
                    .displayListsOfContainer(.cboCC.Text)

                    '.gridLot.Splits(0).DisplayColumns(4).Locked = False
                    '.gridLot.Splits(0).DisplayColumns(4).Style.BackColor = Color.White
                Case 1  'reefer carrier
                    .cboVessel.ReadOnly = False
                    .txtFVDepart.ReadOnly = False
                    .txtFVArrive.ReadOnly = True
                    .txtFVArrive.TextDetached = False
                    .txtFVArrive.Value = ""
                    .txtFVTrans.ReadOnly = False
                    .cboPortTrans.ReadOnly = False
                    .displayPorts(True)
                    .cboPortTrans.Text = ""
                    If .txtFVTrans.Text = "" Then .txtFVTrans.Value = Format(getServerDateTime, getTimeFormat())
                    '.txtFVTrans.EditMask = ""
                    .txtFVUnload.ReadOnly = False
                    .cboPortUnload.ReadOnly = False
                    .displayPorts(False)
                    .cboPortUnload.Text = ""
                    If .txtFVUnload.Text = "" Then .txtFVUnload.Value = Format(getServerDateTime, getTimeFormat())

                    .cboCarrier.ReadOnly = False
                    If .txtCarArrive.Text = "" Then .txtCarArrive.Value = Format(getServerDateTime, getTimeFormat())
                    .txtCarArrive.ReadOnly = False
                    If .txtCarDepart.Text = "" Then .txtCarDepart.Value = Format(getServerDateTime, getTimeFormat())
                    .txtCarDepart.ReadOnly = False
                    .cboCarTrip.ReadOnly = False
                    .cboCarHatch.ReadOnly = False
                    .gridContainer.Enabled = False

                    '.txtCarDepart.EditMask = ""
                    '.txtCarArrive.EditMask = ""
                    .displayListsOfContainer(.cboCC.Text)

                    '.gridLot.Splits(0).DisplayColumns(4).Locked = True
                    '.gridLot.Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
                    .clearWellId()
                Case 2  'reefer container
                    .cboVessel.ReadOnly = False
                    .txtFVDepart.ReadOnly = False
                    .txtFVArrive.ReadOnly = False
                    If .txtFVArrive.Text = "" Then .txtFVArrive.Value = Format(getServerDateTime, getTimeFormat())
                    '.txtFVTrans.EditMask = ""
                    .txtFVTrans.TextDetached = False
                    .txtFVTrans.Value = ""
                    .txtFVTrans.ReadOnly = True
                    .cboPortTrans.Text = ""
                    .cboPortTrans.ReadOnly = True
                    '.txtFVUnload.Value = ""
                    .txtFVUnload.TextDetached = False
                    .txtFVUnload.Value = "" 'may error dito, careful!
                    .txtFVUnload.ReadOnly = True
                    .cboPortUnload.Text = ""
                    .cboPortUnload.ReadOnly = True

                    .cboCarrier.ReadOnly = False
                    If .txtCarArrive.Text = "" Then .txtCarArrive.Value = Format(getServerDateTime, getTimeFormat())
                    .txtCarArrive.ReadOnly = False
                    If .txtCarDepart.Text = "" Then .txtCarDepart.Value = Format(getServerDateTime, getTimeFormat())
                    .txtCarDepart.ReadOnly = False
                    .cboCarTrip.ReadOnly = False
                    .cboCarHatch.ReadOnly = False
                    .gridContainer.Enabled = True

                    '.cboCarrier.Text = ""
                    ''.txtCarDepart.Value = ""
                    ''.txtCarDepart.EditMask = ""
                    ''.txtCarArrive.Value = ""
                    ''.txtCarArrive.EditMask = ""
                    '.cboCarTrip.Text = ""
                    '.cboCarHatch.Text = ""

                    If cboCC.Text = "" Then
                        .displayListsOfContainer(.cboCC.Text)
                    Else
                        .displayListsOfContainer(cboCC.Text)
                    End If

                    '.gridLot.Splits(0).DisplayColumns(4).Locked = True
                    '.gridLot.Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
                    .clearWellId()
            End Select
        End With
    End Sub

    Public Function validateDataEntries(ByVal delivery As String) As Boolean
        With Me
            If delivery.StartsWith("Direct") Then
                If Not .cboVessel.Text.Trim = "" And Not .txtFVDepart.Text.Trim = "" And _
                Not .txtFVArrive.Text.Trim = "" And Not .txtFVUnload.Text.Trim = "" Then
                    Return True
                Else
                    Return False
                End If
            ElseIf delivery.StartsWith("Reefer Carrier") Then
                If Not .cboVessel.Text.Trim = "" And Not .txtFVDepart.Text.Trim = "" And _
                Not .txtFVTrans.Text.Trim = "" And Not .txtFVUnload.Text.Trim = "" And _
                Not .cboCarrier.Text.Trim = "" And Not .txtCarDepart.Text.Trim = "" And Not .txtCarArrive.Text.Trim = "" And _
                Not .cboCarTrip.Text.Trim = "" And Not .cboCarHatch.Text.Trim = "" Then
                    Return True
                Else
                    Return False
                End If
            Else
                If Not .cboVessel.Text.Trim = "" And Not .txtFVDepart.Text.Trim = "" And _
                Not .txtFVArrive.Text.Trim = "" And .gridContainer.RowCount > 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        End With
    End Function

    'Public Sub displayListsOfContainer()
    '    With gridContainer
    '        .DataSource = modModule.getListsOfContainer().Tables(0)

    '        'If .ListCount > 0 Then .SelectedIndex = 0
    '    End With
    'End Sub

    Public Sub displayListsOfContainer(ByVal cc As String)
        With gridContainer
            .DataSource = modModule.getContainersBySICC(cc).Tables(0)
            .Columns(0).DefaultValue = getServerDateTime()
            .Columns(0).NumberFormat = getTimeFormat()
            .Columns(1).DefaultValue = getServerDateTime()
            .Columns(1).NumberFormat = getTimeFormat()

            '.Columns(2).ValueItems
            'If .ListCount > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub mnuMFV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFV.Click
        Dim f As New frmFishingVessel
        f.ShowDialog(Me)

        displayFishingVessel()
        cboVessel.SelectAll()
        cboVessel.Focus()
    End Sub

    Private Sub mnuMFAO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFAO.Click
        Dim f As New frmFAO
        f.ShowDialog(Me)

        displayCatchAreas()
        cboAreaCode.SelectAll()
        cboAreaCode.Focus()
    End Sub

    'Private Sub txtFVArrive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFVArrive.TextChanged
    '    setFishLot()
    'End Sub

    'Private Sub txtFVArrive_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFVArrive.Leave
    '    setFishLot()
    'End Sub

    'Private Sub txtFVTrans_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFVTrans.KeyDown
    '    If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
    '        txtFVTrans.EditMask = ""
    '    End If
    'End Sub

    'Private Sub txtFVTrans_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFVTrans.Enter
    '    txtFVTrans.EditMask = "99/99/9999"
    'End Sub

    'Private Sub txtCarArrive_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCarArrive.KeyDown
    '    If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
    '        txtCarArrive.EditMask = ""
    '    End If
    'End Sub

    'Private Sub txtCarArrive_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCarArrive.Enter
    '    txtCarArrive.EditMask = "99/99/9999"
    'End Sub

    'Private Sub txtCarDepart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCarDepart.KeyDown
    '    If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
    '        txtCarDepart.EditMask = ""
    '    End If
    'End Sub

    'Private Sub txtCarDepart_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCarDepart.Enter
    '    txtCarDepart.EditMask = "99/99/9999"
    'End Sub

    'Private Sub txtFVTrans_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFVTrans.Leave
    '    If txtFVTrans.Text.Trim = "__/__/____" Then
    '        txtFVTrans.EditMask = ""
    '    End If
    'End Sub

    'Private Sub txtCarArrive_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCarArrive.Leave
    '    If txtCarArrive.Text.Length = 10 Then
    '        txtCarArrive.EditMask = ""
    '    End If
    'End Sub

    'Private Sub txtCarDepart_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCarDepart.Leave
    '    If txtCarDepart.Text.Length = 10 Then
    '        txtCarDepart.EditMask = ""
    '    End If
    'End Sub

    Public Sub clearWellId()
        Dim ctr As Integer
        While ctr < gridLot.RowCount
            gridLot.Item(ctr, 4) = ""

            ctr += 1
        End While
    End Sub

    Private Sub gridLot_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles gridLot.FetchRowStyle
        If cboDelivery.Text.StartsWith("Direct") Then  'gridLot.Columns(9).CellValue(e.Row) = "For Evaluation" Then
            gridLot.Splits(0).DisplayColumns(4).Locked = False
            gridLot.Splits(0).DisplayColumns(4).Style.BackColor = Color.White
            'e.CellStyle.ForeColor = System.Drawing.Color.White
            'e.CellStyle.BackColor = System.Drawing.Color.Red
        Else
            gridLot.Splits(0).DisplayColumns(4).Locked = True
            gridLot.Splits(0).DisplayColumns(4).Style.BackColor = Color.Gray
            'gridLot.Columns(4).Value = ""
            'gridLot.Refresh()
            'clearWellId()
        End If
    End Sub

    Private Sub txtFVUnload_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFVUnload.Validating
        'e.Cancel = False
    End Sub

    Private Sub txtFVArrive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFVArrive.TextChanged
        setFishLot()
    End Sub

    Private Sub txtFVArrive_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFVArrive.Leave
        If txtFVArrive.Text.Trim = "" And Not cboDelivery.Text.StartsWith("Reefer Carrier") Then
            txtFVArrive.Value = Format(getServerDateTime, getTimeFormat())
        End If
    End Sub

    Private Sub txtFVTrans_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFVTrans.Leave
        If txtFVTrans.Text.Trim = "" And cboDelivery.Text.StartsWith("Reefer Carrier") Then
            txtFVTrans.Value = Format(getServerDateTime, getTimeFormat())
        End If
    End Sub

    Private Sub txtFVUnload_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFVUnload.Leave
        If txtFVUnload.Text.Trim = "" And Not cboDelivery.Text.StartsWith("Reefer Cont") Then
            txtFVUnload.Value = Format(getServerDateTime, getTimeFormat())
        End If
    End Sub

    Private Sub txtCarArrive_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCarArrive.Leave
        If txtCarArrive.Text.Trim = "" And cboDelivery.Text.StartsWith("Reefer Carrier") Then
            txtCarArrive.Value = Format(getServerDateTime, getTimeFormat())
        End If
    End Sub

    Private Sub txtCarDepart_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCarDepart.Leave
        If txtCarDepart.Text.Trim = "" And cboDelivery.Text.StartsWith("Reefer Carrier") Then
            txtCarDepart.Value = Format(getServerDateTime, getTimeFormat())
        End If
    End Sub

    Public Sub displayPorts(ByVal trans As Boolean)
        Try
            Dim c As New SqlClient.SqlConnection
            c.ConnectionString = modModule.getConnectionString
            c.Open()

            Dim qry As String
            If trans Then
                qry = "SELECT DISTINCT portTrans AS [Transshippment Port]" & _
                " FROM dbo.tblCatchCertificate " & _
                " WHERE NOT portTrans = '' " & _
                " ORDER BY portTrans"
            Else
                qry = "SELECT DISTINCT portUnload AS [Unloading Port]" & _
                " FROM dbo.tblCatchCertificate " & _
                " WHERE NOT portUnload = '' " & _
                " ORDER BY portUnload"
            End If

            Dim cmd As New SqlClient.SqlCommand(qry, c)

            Dim da As New SqlClient.SqlDataAdapter
            da.SelectCommand = cmd

            Dim ds As New DataSet("dbPPICIS")
            da.Fill(ds)

            If trans Then
                cboPortTrans.DefColWidth = 160
                cboPortTrans.DataSource = ds.Tables(0)
            Else
                cboPortUnload.DefColWidth = 160
                cboPortUnload.DataSource = ds.Tables(0)
            End If

            da.Dispose()
            ds.Dispose()
            c.Close()
        Catch e As Exception
            MsgBox(e.Message)
        Finally
        End Try
    End Sub

    Private Sub chkNoCC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoCC.CheckedChanged
        If chkNoCC.Checked Then
            cboCC.Text = ""
            cboCC.ReadOnly = True
            cboCC.Text = "System will generate cc number for this transaction"
            cboDelivery.SelectAll()
            cboDelivery.Focus()
        Else
            cboCC.ReadOnly = False
            cboCC.SelectAll()
            cboCC.Focus()
        End If
    End Sub

    Private Sub cboAreaCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAreaCode.KeyDown

    End Sub
End Class
