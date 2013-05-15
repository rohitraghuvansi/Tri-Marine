Public Class frmMainMenu
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents pnl1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuItemAbout As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuLockPC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInquiresForMe As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents pnl2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSystemAccount As System.Windows.Forms.MenuItem
    Friend WithEvents mnuChangePassword As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUtility As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInquiry As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuMFish As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMBin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTDeposit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTWithdrawal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMLoins As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMCC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFishingVessel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMSupplier As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFAO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMSection As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDReject As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTReject As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTUpdateFishLot As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuMFishSize As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTUpdateBinStatus As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMCOS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMCOP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMProductDescription As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdPackStyle As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdMedia As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdFillerLine As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdCleaning As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdSpecie As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdCanSize As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProduct As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTProduction As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdPeriod As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTLabeling As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuMMRN As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMMRN_Materials As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMMRN_Manufacturer As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMMRNSupplier As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMWarehouse As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMLabel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdLoinSize As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProdFishSize As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTFGWW As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTotalInventory As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTotalInventory_Room As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTotalInventory_TypeOfSet As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRLotActivity As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFWRD As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFWRL As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFWRS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTQCSample As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTQCDispo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRSumVoyLot As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTMRNUsage As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRProductCosting As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMBOM As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTPushBack As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTDeposit2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTD As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTWithdrawal2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTW As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRDiscrepancy As System.Windows.Forms.MenuItem
    Friend WithEvents mrnTMRNBegInventory As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFWSDate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRLotDetails As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRLCA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCAPD As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRLoinInvPD As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRLoinInventory As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTFGOutput As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFGDefect As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRSpoilages As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTMaterialCost As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTUtilityExp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFishDepositPerCS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTLaborRate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCA_Overiew As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCA_PushBack As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCA_Bags As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCA_Fish As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRSumVoySublot As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTFishDeposit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRMRFAA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTOH As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRRecovery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRSpoilages_Daily As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRSpoilages_Lot As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRPrepPackingLists As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton14 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTFGShipment As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton15 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTFGInvoice As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTFishRacking As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFZInventory As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTRFA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTFGA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTAnalysis As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRInventoryAL As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRInventoryOthers As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrintFZO As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrintFZA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTotalReceipts As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFZTotal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFZTotalAl As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFZTotalOthers As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTWithdrawal3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFGOutput As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTMeatPercent As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFZContainers As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRSpoilages_Range As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRInventoryByCS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRLabeling As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRDailyLabeling As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFishExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFishLot As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFR As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTFishReceipts As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFishOwner As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMCS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTCSMap As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIBin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCSMetrics As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTCalibration As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTProdSched As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRRounds As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRFRDetails As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRBinInventory As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIPalletDist As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIProdTrace As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIFishBinSettlement As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCSTrans As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRRoundsLight As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton16 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.mnuMCC = New System.Windows.Forms.MenuItem()
        Me.mnuFishLot = New System.Windows.Forms.MenuItem()
        Me.mnuMFR = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.mnuMCOS = New System.Windows.Forms.MenuItem()
        Me.mnuMCOP = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.mnuMFish = New System.Windows.Forms.MenuItem()
        Me.mnuMFishSize = New System.Windows.Forms.MenuItem()
        Me.mnuMBin = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.mnuMCS = New System.Windows.Forms.MenuItem()
        Me.mnuMFishingVessel = New System.Windows.Forms.MenuItem()
        Me.mnuMFishOwner = New System.Windows.Forms.MenuItem()
        Me.mnuMSupplier = New System.Windows.Forms.MenuItem()
        Me.mnuMFAO = New System.Windows.Forms.MenuItem()
        Me.mnuMSection = New System.Windows.Forms.MenuItem()
        Me.mnuMLabel = New System.Windows.Forms.MenuItem()
        Me.mnuMWarehouse = New System.Windows.Forms.MenuItem()
        Me.mnuDReject = New System.Windows.Forms.MenuItem()
        Me.mnuMFGDefect = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuProduct = New System.Windows.Forms.MenuItem()
        Me.mnuMProductDescription = New System.Windows.Forms.MenuItem()
        Me.mnuProdPackStyle = New System.Windows.Forms.MenuItem()
        Me.mnuProdMedia = New System.Windows.Forms.MenuItem()
        Me.mnuProdSpecie = New System.Windows.Forms.MenuItem()
        Me.mnuProdCanSize = New System.Windows.Forms.MenuItem()
        Me.mnuProdFishSize = New System.Windows.Forms.MenuItem()
        Me.mnuProdLoinSize = New System.Windows.Forms.MenuItem()
        Me.mnuProdFillerLine = New System.Windows.Forms.MenuItem()
        Me.mnuProdCleaning = New System.Windows.Forms.MenuItem()
        Me.mnuProdPeriod = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnuMMRN = New System.Windows.Forms.MenuItem()
        Me.mnuMMRN_Materials = New System.Windows.Forms.MenuItem()
        Me.mnuMMRN_Manufacturer = New System.Windows.Forms.MenuItem()
        Me.mnuMMRNSupplier = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.mnuMBOM = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.mnuTCSMap = New System.Windows.Forms.MenuItem()
        Me.mnuTFishReceipts = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.mnuTD = New System.Windows.Forms.MenuItem()
        Me.mnuTFishDeposit = New System.Windows.Forms.MenuItem()
        Me.mnuTDeposit = New System.Windows.Forms.MenuItem()
        Me.mnuTDeposit2 = New System.Windows.Forms.MenuItem()
        Me.mnuTW = New System.Windows.Forms.MenuItem()
        Me.mnuTProdSched = New System.Windows.Forms.MenuItem()
        Me.mnuTWithdrawal = New System.Windows.Forms.MenuItem()
        Me.mnuTWithdrawal2 = New System.Windows.Forms.MenuItem()
        Me.mnuTWithdrawal3 = New System.Windows.Forms.MenuItem()
        Me.mnuTCalibration = New System.Windows.Forms.MenuItem()
        Me.mnuTFishRacking = New System.Windows.Forms.MenuItem()
        Me.mnuTReject = New System.Windows.Forms.MenuItem()
        Me.mnuMLoins = New System.Windows.Forms.MenuItem()
        Me.mnuTQCSample = New System.Windows.Forms.MenuItem()
        Me.mnuTQCDispo = New System.Windows.Forms.MenuItem()
        Me.mnuTProduction = New System.Windows.Forms.MenuItem()
        Me.mnuTLabeling = New System.Windows.Forms.MenuItem()
        Me.mnuTFGOutput = New System.Windows.Forms.MenuItem()
        Me.mnuTFGWW = New System.Windows.Forms.MenuItem()
        Me.mnuTFGShipment = New System.Windows.Forms.MenuItem()
        Me.mnuTFGInvoice = New System.Windows.Forms.MenuItem()
        Me.mnuTMeatPercent = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.mrnTMRNBegInventory = New System.Windows.Forms.MenuItem()
        Me.mnuTMaterialCost = New System.Windows.Forms.MenuItem()
        Me.mnuTMRNUsage = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.mnuTUpdateFishLot = New System.Windows.Forms.MenuItem()
        Me.mnuTUpdateBinStatus = New System.Windows.Forms.MenuItem()
        Me.mnuTPushBack = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.mnuTLaborRate = New System.Windows.Forms.MenuItem()
        Me.mnuTOH = New System.Windows.Forms.MenuItem()
        Me.mnuTUtilityExp = New System.Windows.Forms.MenuItem()
        Me.mnuTAnalysis = New System.Windows.Forms.MenuItem()
        Me.mnuTRFA = New System.Windows.Forms.MenuItem()
        Me.mnuTFGA = New System.Windows.Forms.MenuItem()
        Me.mnuInquiry = New System.Windows.Forms.MenuItem()
        Me.mnuIBin = New System.Windows.Forms.MenuItem()
        Me.mnuIFishBinSettlement = New System.Windows.Forms.MenuItem()
        Me.mnuIPalletDist = New System.Windows.Forms.MenuItem()
        Me.mnuIProdTrace = New System.Windows.Forms.MenuItem()
        Me.mnuReport = New System.Windows.Forms.MenuItem()
        Me.mnuRCSMetrics = New System.Windows.Forms.MenuItem()
        Me.mnuRCSTrans = New System.Windows.Forms.MenuItem()
        Me.mnuRLotActivity = New System.Windows.Forms.MenuItem()
        Me.mnuRTotalInventory = New System.Windows.Forms.MenuItem()
        Me.mnuRInventoryAL = New System.Windows.Forms.MenuItem()
        Me.mnuRInventoryOthers = New System.Windows.Forms.MenuItem()
        Me.mnuRInventoryByCS = New System.Windows.Forms.MenuItem()
        Me.mnuRRounds = New System.Windows.Forms.MenuItem()
        Me.mnuRBinInventory = New System.Windows.Forms.MenuItem()
        Me.mnuRFZInventory = New System.Windows.Forms.MenuItem()
        Me.mnuPrintFZA = New System.Windows.Forms.MenuItem()
        Me.mnuPrintFZO = New System.Windows.Forms.MenuItem()
        Me.mnuRFZContainers = New System.Windows.Forms.MenuItem()
        Me.mnuRTotalInventory_Room = New System.Windows.Forms.MenuItem()
        Me.mnuRTotalInventory_TypeOfSet = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.mnuRSumVoyLot = New System.Windows.Forms.MenuItem()
        Me.mnuRLotDetails = New System.Windows.Forms.MenuItem()
        Me.mnuRFRDetails = New System.Windows.Forms.MenuItem()
        Me.mnuRTotalReceipts = New System.Windows.Forms.MenuItem()
        Me.mnuRSumVoySublot = New System.Windows.Forms.MenuItem()
        Me.mnuRFishDepositPerCS = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.mnuRFWRD = New System.Windows.Forms.MenuItem()
        Me.mnuRFWRL = New System.Windows.Forms.MenuItem()
        Me.mnuRCA_Overiew = New System.Windows.Forms.MenuItem()
        Me.mnuRCA_PushBack = New System.Windows.Forms.MenuItem()
        Me.mnuRCA_Bags = New System.Windows.Forms.MenuItem()
        Me.mnuRCA_Fish = New System.Windows.Forms.MenuItem()
        Me.mnuRMRFAA = New System.Windows.Forms.MenuItem()
        Me.mnuRFWRS = New System.Windows.Forms.MenuItem()
        Me.mnuRFWSDate = New System.Windows.Forms.MenuItem()
        Me.mnuRLCA = New System.Windows.Forms.MenuItem()
        Me.mnuRCAPD = New System.Windows.Forms.MenuItem()
        Me.mnuRFishExport = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.mnuRLoinInvPD = New System.Windows.Forms.MenuItem()
        Me.mnuRLoinInventory = New System.Windows.Forms.MenuItem()
        Me.mnuRFZTotal = New System.Windows.Forms.MenuItem()
        Me.mnuRFZTotalAl = New System.Windows.Forms.MenuItem()
        Me.mnuRFZTotalOthers = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.mnuRFGOutput = New System.Windows.Forms.MenuItem()
        Me.mnuRLabeling = New System.Windows.Forms.MenuItem()
        Me.mnuRDailyLabeling = New System.Windows.Forms.MenuItem()
        Me.mnuRSpoilages = New System.Windows.Forms.MenuItem()
        Me.mnuRSpoilages_Daily = New System.Windows.Forms.MenuItem()
        Me.mnuRSpoilages_Range = New System.Windows.Forms.MenuItem()
        Me.mnuRSpoilages_Lot = New System.Windows.Forms.MenuItem()
        Me.mnuRPrepPackingLists = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.mnuRProductCosting = New System.Windows.Forms.MenuItem()
        Me.mnuRDiscrepancy = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.mnuRRecovery = New System.Windows.Forms.MenuItem()
        Me.mnuUtility = New System.Windows.Forms.MenuItem()
        Me.mnuSystemAccount = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.mnuChangePassword = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuInquiresForMe = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.mnuItemAbout = New System.Windows.Forms.MenuItem()
        Me.mnuLockPC = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton16 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton14 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton15 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.pnl1 = New System.Windows.Forms.StatusBarPanel()
        Me.pnl2 = New System.Windows.Forms.StatusBarPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuRRoundsLight = New System.Windows.Forms.MenuItem()
        CType(Me.pnl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem40, Me.mnuInquiry, Me.mnuReport, Me.mnuUtility, Me.mnuHelp, Me.mnuLockPC, Me.mnuExit})
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMCC, Me.mnuFishLot, Me.mnuMFR, Me.MenuItem6, Me.mnuMCOS, Me.mnuMCOP, Me.MenuItem4, Me.mnuMFish, Me.mnuMFishSize, Me.mnuMBin, Me.MenuItem7, Me.mnuMCS, Me.mnuMFishingVessel, Me.mnuMFishOwner, Me.mnuMSupplier, Me.mnuMFAO, Me.mnuMSection, Me.mnuMLabel, Me.mnuMWarehouse, Me.mnuDReject, Me.mnuMFGDefect, Me.MenuItem8, Me.MenuItem1, Me.MenuItem12, Me.MenuItem2, Me.MenuItem23, Me.mnuMBOM})
        Me.MenuItem5.Text = "&Maintenance"
        '
        'mnuMCC
        '
        Me.mnuMCC.Checked = True
        Me.mnuMCC.Index = 0
        Me.mnuMCC.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.mnuMCC.Text = "Raw Fish Suppl&y"
        '
        'mnuFishLot
        '
        Me.mnuFishLot.Checked = True
        Me.mnuFishLot.Index = 1
        Me.mnuFishLot.Text = "Fish Lot Id"
        '
        'mnuMFR
        '
        Me.mnuMFR.Checked = True
        Me.mnuMFR.Index = 2
        Me.mnuMFR.Text = "Fish Receipts"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Text = "-"
        '
        'mnuMCOS
        '
        Me.mnuMCOS.Checked = True
        Me.mnuMCOS.Index = 4
        Me.mnuMCOS.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mnuMCOS.Text = "Confirmation of &Sale"
        '
        'mnuMCOP
        '
        Me.mnuMCOP.Checked = True
        Me.mnuMCOP.Index = 5
        Me.mnuMCOP.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.mnuMCOP.Text = "Confirmation &of Purchase"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 6
        Me.MenuItem4.Text = "-"
        '
        'mnuMFish
        '
        Me.mnuMFish.Checked = True
        Me.mnuMFish.Index = 7
        Me.mnuMFish.Text = "&Fish Species"
        '
        'mnuMFishSize
        '
        Me.mnuMFishSize.Checked = True
        Me.mnuMFishSize.Index = 8
        Me.mnuMFishSize.Text = "Fish Si&ze"
        '
        'mnuMBin
        '
        Me.mnuMBin.Checked = True
        Me.mnuMBin.Index = 9
        Me.mnuMBin.Text = "Fish &Bin"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 10
        Me.MenuItem7.Text = "-"
        '
        'mnuMCS
        '
        Me.mnuMCS.Checked = True
        Me.mnuMCS.Index = 11
        Me.mnuMCS.Text = "Cold Storage"
        '
        'mnuMFishingVessel
        '
        Me.mnuMFishingVessel.Checked = True
        Me.mnuMFishingVessel.Index = 12
        Me.mnuMFishingVessel.Text = "Fishing &Vessel"
        '
        'mnuMFishOwner
        '
        Me.mnuMFishOwner.Checked = True
        Me.mnuMFishOwner.Index = 13
        Me.mnuMFishOwner.Text = "Fish Owner"
        '
        'mnuMSupplier
        '
        Me.mnuMSupplier.Checked = True
        Me.mnuMSupplier.Index = 14
        Me.mnuMSupplier.Text = "Fish &Supplier"
        '
        'mnuMFAO
        '
        Me.mnuMFAO.Checked = True
        Me.mnuMFAO.Index = 15
        Me.mnuMFAO.Text = "F&AO Catch Areas"
        '
        'mnuMSection
        '
        Me.mnuMSection.Checked = True
        Me.mnuMSection.Index = 16
        Me.mnuMSection.Text = "&Production Section"
        '
        'mnuMLabel
        '
        Me.mnuMLabel.Index = 17
        Me.mnuMLabel.Text = "La&bels"
        '
        'mnuMWarehouse
        '
        Me.mnuMWarehouse.Checked = True
        Me.mnuMWarehouse.Index = 18
        Me.mnuMWarehouse.Text = "&Warehouse"
        '
        'mnuDReject
        '
        Me.mnuDReject.Checked = True
        Me.mnuDReject.Index = 19
        Me.mnuDReject.Text = "Fish Re&ject"
        '
        'mnuMFGDefect
        '
        Me.mnuMFGDefect.Checked = True
        Me.mnuMFGDefect.Index = 20
        Me.mnuMFGDefect.Text = "FG Defects"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 21
        Me.MenuItem8.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 22
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuProduct, Me.mnuMProductDescription, Me.mnuProdPackStyle, Me.mnuProdMedia, Me.mnuProdSpecie, Me.mnuProdCanSize, Me.mnuProdFishSize, Me.mnuProdLoinSize, Me.mnuProdFillerLine, Me.mnuProdCleaning, Me.mnuProdPeriod})
        Me.MenuItem1.Text = "Product"
        '
        'mnuProduct
        '
        Me.mnuProduct.Index = 0
        Me.mnuProduct.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.mnuProduct.Text = "&Product Code"
        '
        'mnuMProductDescription
        '
        Me.mnuMProductDescription.Enabled = False
        Me.mnuMProductDescription.Index = 1
        Me.mnuMProductDescription.Text = "P&roduct Description"
        Me.mnuMProductDescription.Visible = False
        '
        'mnuProdPackStyle
        '
        Me.mnuProdPackStyle.Index = 2
        Me.mnuProdPackStyle.Text = "P&ack Style"
        '
        'mnuProdMedia
        '
        Me.mnuProdMedia.Index = 3
        Me.mnuProdMedia.Text = "&Media"
        '
        'mnuProdSpecie
        '
        Me.mnuProdSpecie.Index = 4
        Me.mnuProdSpecie.Text = "&Specie"
        '
        'mnuProdCanSize
        '
        Me.mnuProdCanSize.Index = 5
        Me.mnuProdCanSize.Text = "Can Si&ze"
        '
        'mnuProdFishSize
        '
        Me.mnuProdFishSize.Index = 6
        Me.mnuProdFishSize.Text = "Fis&h Size"
        '
        'mnuProdLoinSize
        '
        Me.mnuProdLoinSize.Index = 7
        Me.mnuProdLoinSize.Text = "L&oin Size"
        '
        'mnuProdFillerLine
        '
        Me.mnuProdFillerLine.Index = 8
        Me.mnuProdFillerLine.Text = "&Filler Line"
        '
        'mnuProdCleaning
        '
        Me.mnuProdCleaning.Index = 9
        Me.mnuProdCleaning.Text = "Cleaning St&yle"
        '
        'mnuProdPeriod
        '
        Me.mnuProdPeriod.Index = 10
        Me.mnuProdPeriod.Text = "&Time Period Batch"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 23
        Me.MenuItem12.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 24
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMMRN, Me.mnuMMRN_Materials, Me.mnuMMRN_Manufacturer, Me.mnuMMRNSupplier})
        Me.MenuItem2.Text = "Material Reference Information"
        '
        'mnuMMRN
        '
        Me.mnuMMRN.Index = 0
        Me.mnuMMRN.Shortcut = System.Windows.Forms.Shortcut.CtrlM
        Me.mnuMMRN.Text = "&Material Reference"
        '
        'mnuMMRN_Materials
        '
        Me.mnuMMRN_Materials.Index = 1
        Me.mnuMMRN_Materials.Text = "Mater&ials"
        '
        'mnuMMRN_Manufacturer
        '
        Me.mnuMMRN_Manufacturer.Index = 2
        Me.mnuMMRN_Manufacturer.Text = "Manu&facturer"
        '
        'mnuMMRNSupplier
        '
        Me.mnuMMRNSupplier.Index = 3
        Me.mnuMMRNSupplier.Text = "&Supplier"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 25
        Me.MenuItem23.Text = "-"
        '
        'mnuMBOM
        '
        Me.mnuMBOM.Index = 26
        Me.mnuMBOM.Text = "&Bill of Materials"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 1
        Me.MenuItem40.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTCSMap, Me.mnuTFishReceipts, Me.mnuTD, Me.mnuTW, Me.mnuTCalibration, Me.mnuTFishRacking, Me.mnuTReject, Me.mnuMLoins, Me.mnuTQCSample, Me.mnuTQCDispo, Me.mnuTProduction, Me.mnuTLabeling, Me.mnuTFGOutput, Me.mnuTFGWW, Me.mnuTFGShipment, Me.mnuTFGInvoice, Me.mnuTMeatPercent, Me.MenuItem19, Me.mrnTMRNBegInventory, Me.mnuTMaterialCost, Me.mnuTMRNUsage, Me.MenuItem22, Me.mnuTUpdateFishLot, Me.mnuTUpdateBinStatus, Me.mnuTPushBack, Me.MenuItem27, Me.MenuItem29, Me.mnuTAnalysis})
        Me.MenuItem40.Text = "&Transaction"
        '
        'mnuTCSMap
        '
        Me.mnuTCSMap.Checked = True
        Me.mnuTCSMap.Index = 0
        Me.mnuTCSMap.Text = "Cold Storage Map"
        '
        'mnuTFishReceipts
        '
        Me.mnuTFishReceipts.Index = 1
        Me.mnuTFishReceipts.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem32})
        Me.mnuTFishReceipts.Text = "&Fish Receiving"
        '
        'MenuItem3
        '
        Me.MenuItem3.Checked = True
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Raw Fish Receipts"
        '
        'MenuItem32
        '
        Me.MenuItem32.Checked = True
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "Raw Fish Vessel Reject"
        '
        'mnuTD
        '
        Me.mnuTD.Enabled = False
        Me.mnuTD.Index = 2
        Me.mnuTD.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTFishDeposit, Me.mnuTDeposit, Me.mnuTDeposit2})
        Me.mnuTD.Text = "Deposits"
        Me.mnuTD.Visible = False
        '
        'mnuTFishDeposit
        '
        Me.mnuTFishDeposit.Enabled = False
        Me.mnuTFishDeposit.Index = 0
        Me.mnuTFishDeposit.Text = "Fish Deposit"
        Me.mnuTFishDeposit.Visible = False
        '
        'mnuTDeposit
        '
        Me.mnuTDeposit.Index = 1
        Me.mnuTDeposit.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.mnuTDeposit.Text = "Fish &Deposits or Recieving"
        '
        'mnuTDeposit2
        '
        Me.mnuTDeposit2.Enabled = False
        Me.mnuTDeposit2.Index = 2
        Me.mnuTDeposit2.Text = "Flake Bags Deposits"
        Me.mnuTDeposit2.Visible = False
        '
        'mnuTW
        '
        Me.mnuTW.Index = 3
        Me.mnuTW.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTProdSched, Me.mnuTWithdrawal, Me.mnuTWithdrawal2, Me.mnuTWithdrawal3})
        Me.mnuTW.Text = "Raw Fish Withdrawal"
        '
        'mnuTProdSched
        '
        Me.mnuTProdSched.Index = 0
        Me.mnuTProdSched.Text = "Production Schedule"
        '
        'mnuTWithdrawal
        '
        Me.mnuTWithdrawal.Checked = True
        Me.mnuTWithdrawal.Index = 1
        Me.mnuTWithdrawal.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.mnuTWithdrawal.Text = "Raw Fish Withdrawal"
        '
        'mnuTWithdrawal2
        '
        Me.mnuTWithdrawal2.Enabled = False
        Me.mnuTWithdrawal2.Index = 2
        Me.mnuTWithdrawal2.Text = "Flake Bags Cannery Acceptance"
        Me.mnuTWithdrawal2.Visible = False
        '
        'mnuTWithdrawal3
        '
        Me.mnuTWithdrawal3.Index = 3
        Me.mnuTWithdrawal3.Text = "Flakes Bag Withdrawal"
        '
        'mnuTCalibration
        '
        Me.mnuTCalibration.Checked = True
        Me.mnuTCalibration.Index = 4
        Me.mnuTCalibration.Text = "Calibrate Scale"
        '
        'mnuTFishRacking
        '
        Me.mnuTFishRacking.Checked = True
        Me.mnuTFishRacking.Index = 5
        Me.mnuTFishRacking.Text = "Fish Rackin&g"
        '
        'mnuTReject
        '
        Me.mnuTReject.Checked = True
        Me.mnuTReject.Index = 6
        Me.mnuTReject.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.mnuTReject.Text = "Fish Process &Reject"
        '
        'mnuMLoins
        '
        Me.mnuMLoins.Index = 7
        Me.mnuMLoins.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.mnuMLoins.Text = "Loinin&g"
        '
        'mnuTQCSample
        '
        Me.mnuTQCSample.Enabled = False
        Me.mnuTQCSample.Index = 8
        Me.mnuTQCSample.Text = "&QC Sample"
        Me.mnuTQCSample.Visible = False
        '
        'mnuTQCDispo
        '
        Me.mnuTQCDispo.Enabled = False
        Me.mnuTQCDispo.Index = 9
        Me.mnuTQCDispo.Text = "QC D&isposition"
        Me.mnuTQCDispo.Visible = False
        '
        'mnuTProduction
        '
        Me.mnuTProduction.Checked = True
        Me.mnuTProduction.Index = 10
        Me.mnuTProduction.Shortcut = System.Windows.Forms.Shortcut.CtrlI
        Me.mnuTProduction.Text = "Product&ion Output Data"
        '
        'mnuTLabeling
        '
        Me.mnuTLabeling.Checked = True
        Me.mnuTLabeling.Index = 11
        Me.mnuTLabeling.Shortcut = System.Windows.Forms.Shortcut.CtrlU
        Me.mnuTLabeling.Text = "Labeling and Case-&up"
        '
        'mnuTFGOutput
        '
        Me.mnuTFGOutput.Index = 12
        Me.mnuTFGOutput.Text = "FG Output"
        '
        'mnuTFGWW
        '
        Me.mnuTFGWW.Checked = True
        Me.mnuTFGWW.Index = 13
        Me.mnuTFGWW.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.mnuTFGWW.Text = "F&G Warehouse Withdrawal"
        '
        'mnuTFGShipment
        '
        Me.mnuTFGShipment.Checked = True
        Me.mnuTFGShipment.Index = 14
        Me.mnuTFGShipment.Text = "FG Shipments"
        '
        'mnuTFGInvoice
        '
        Me.mnuTFGInvoice.Checked = True
        Me.mnuTFGInvoice.Index = 15
        Me.mnuTFGInvoice.Text = "FG Commercial Invoice"
        '
        'mnuTMeatPercent
        '
        Me.mnuTMeatPercent.Checked = True
        Me.mnuTMeatPercent.Index = 16
        Me.mnuTMeatPercent.Text = "&Meat Percentage"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 17
        Me.MenuItem19.Text = "-"
        '
        'mrnTMRNBegInventory
        '
        Me.mrnTMRNBegInventory.Enabled = False
        Me.mrnTMRNBegInventory.Index = 18
        Me.mrnTMRNBegInventory.Text = "MRN Beginning In&ventory"
        Me.mrnTMRNBegInventory.Visible = False
        '
        'mnuTMaterialCost
        '
        Me.mnuTMaterialCost.Index = 19
        Me.mnuTMaterialCost.Text = "Material &Cost"
        '
        'mnuTMRNUsage
        '
        Me.mnuTMRNUsage.Index = 20
        Me.mnuTMRNUsage.Text = "&Material Usages"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 21
        Me.MenuItem22.Text = "-"
        '
        'mnuTUpdateFishLot
        '
        Me.mnuTUpdateFishLot.Index = 22
        Me.mnuTUpdateFishLot.Text = "&Update Fish Lot Information"
        '
        'mnuTUpdateBinStatus
        '
        Me.mnuTUpdateBinStatus.Index = 23
        Me.mnuTUpdateBinStatus.Text = "Update Fish Bin Details"
        '
        'mnuTPushBack
        '
        Me.mnuTPushBack.Checked = True
        Me.mnuTPushBack.Index = 24
        Me.mnuTPushBack.Text = "Pus&h Back and Take Back"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 25
        Me.MenuItem27.Text = "-"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 26
        Me.MenuItem29.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTLaborRate, Me.mnuTOH, Me.mnuTUtilityExp})
        Me.MenuItem29.Text = "Product Costing"
        '
        'mnuTLaborRate
        '
        Me.mnuTLaborRate.Enabled = False
        Me.mnuTLaborRate.Index = 0
        Me.mnuTLaborRate.Text = "&Labor Rate"
        Me.mnuTLaborRate.Visible = False
        '
        'mnuTOH
        '
        Me.mnuTOH.Index = 1
        Me.mnuTOH.Text = "Manufacturing Absorption"
        '
        'mnuTUtilityExp
        '
        Me.mnuTUtilityExp.Enabled = False
        Me.mnuTUtilityExp.Index = 2
        Me.mnuTUtilityExp.Text = "&Utility Expenses"
        Me.mnuTUtilityExp.Visible = False
        '
        'mnuTAnalysis
        '
        Me.mnuTAnalysis.Index = 27
        Me.mnuTAnalysis.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTRFA, Me.mnuTFGA})
        Me.mnuTAnalysis.Text = "&Analysis"
        '
        'mnuTRFA
        '
        Me.mnuTRFA.Checked = True
        Me.mnuTRFA.Index = 0
        Me.mnuTRFA.Text = "&Raw Fish Analysis"
        '
        'mnuTFGA
        '
        Me.mnuTFGA.Index = 1
        Me.mnuTFGA.Text = "&Finished Goods"
        '
        'mnuInquiry
        '
        Me.mnuInquiry.Index = 2
        Me.mnuInquiry.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuIBin, Me.mnuIFishBinSettlement, Me.mnuIPalletDist, Me.mnuIProdTrace})
        Me.mnuInquiry.Text = "&Inquiry"
        '
        'mnuIBin
        '
        Me.mnuIBin.Checked = True
        Me.mnuIBin.Index = 0
        Me.mnuIBin.Text = "Fish Bin History"
        '
        'mnuIFishBinSettlement
        '
        Me.mnuIFishBinSettlement.Checked = True
        Me.mnuIFishBinSettlement.Index = 1
        Me.mnuIFishBinSettlement.Text = "Fish Bin Settlement"
        '
        'mnuIPalletDist
        '
        Me.mnuIPalletDist.Checked = True
        Me.mnuIPalletDist.Index = 2
        Me.mnuIPalletDist.Text = "Pallet Tag Distribution"
        '
        'mnuIProdTrace
        '
        Me.mnuIProdTrace.Checked = True
        Me.mnuIProdTrace.Index = 3
        Me.mnuIProdTrace.Text = "Product Traceability"
        '
        'mnuReport
        '
        Me.mnuReport.Index = 3
        Me.mnuReport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRCSMetrics, Me.mnuRCSTrans, Me.mnuRLotActivity, Me.mnuRTotalInventory, Me.mnuRFZInventory, Me.mnuRTotalInventory_Room, Me.mnuRTotalInventory_TypeOfSet, Me.MenuItem20, Me.MenuItem18, Me.MenuItem24, Me.MenuItem25, Me.mnuRLabeling, Me.mnuRSpoilages, Me.mnuRPrepPackingLists, Me.MenuItem21, Me.mnuRProductCosting, Me.mnuRDiscrepancy, Me.MenuItem31, Me.mnuRRecovery})
        Me.mnuReport.Text = "&Reports"
        '
        'mnuRCSMetrics
        '
        Me.mnuRCSMetrics.Checked = True
        Me.mnuRCSMetrics.Index = 0
        Me.mnuRCSMetrics.Text = "Cold Storage Metrics"
        '
        'mnuRCSTrans
        '
        Me.mnuRCSTrans.Checked = True
        Me.mnuRCSTrans.Index = 1
        Me.mnuRCSTrans.Text = "CS Transaction Report"
        '
        'mnuRLotActivity
        '
        Me.mnuRLotActivity.Index = 2
        Me.mnuRLotActivity.Text = "&Lot Movement Report"
        '
        'mnuRTotalInventory
        '
        Me.mnuRTotalInventory.Index = 3
        Me.mnuRTotalInventory.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRInventoryAL, Me.mnuRInventoryOthers, Me.mnuRInventoryByCS, Me.mnuRRounds, Me.mnuRRoundsLight, Me.mnuRBinInventory})
        Me.mnuRTotalInventory.Text = "Round Fish &Inventory Report"
        '
        'mnuRInventoryAL
        '
        Me.mnuRInventoryAL.Enabled = False
        Me.mnuRInventoryAL.Index = 0
        Me.mnuRInventoryAL.Text = "&Albacore"
        Me.mnuRInventoryAL.Visible = False
        '
        'mnuRInventoryOthers
        '
        Me.mnuRInventoryOthers.Enabled = False
        Me.mnuRInventoryOthers.Index = 1
        Me.mnuRInventoryOthers.Text = "&Others (Yellow Fin/ Skipjack/ Big Eye)"
        Me.mnuRInventoryOthers.Visible = False
        '
        'mnuRInventoryByCS
        '
        Me.mnuRInventoryByCS.Checked = True
        Me.mnuRInventoryByCS.Index = 2
        Me.mnuRInventoryByCS.Text = "By Cold Storage"
        '
        'mnuRRounds
        '
        Me.mnuRRounds.Checked = True
        Me.mnuRRounds.Index = 3
        Me.mnuRRounds.Text = "Round Fish Inventory - Long Line"
        '
        'mnuRBinInventory
        '
        Me.mnuRBinInventory.Checked = True
        Me.mnuRBinInventory.Index = 5
        Me.mnuRBinInventory.Text = "Fish Bin Details by Trip Code"
        '
        'mnuRFZInventory
        '
        Me.mnuRFZInventory.Index = 4
        Me.mnuRFZInventory.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPrintFZA, Me.mnuPrintFZO, Me.mnuRFZContainers})
        Me.mnuRFZInventory.Text = "Frozen Loins Inventory Report"
        '
        'mnuPrintFZA
        '
        Me.mnuPrintFZA.Index = 0
        Me.mnuPrintFZA.Text = "&Albacore"
        '
        'mnuPrintFZO
        '
        Me.mnuPrintFZO.Index = 1
        Me.mnuPrintFZO.Text = "&Others (YF and SJ)"
        '
        'mnuRFZContainers
        '
        Me.mnuRFZContainers.Index = 2
        Me.mnuRFZContainers.Text = "By Containers"
        '
        'mnuRTotalInventory_Room
        '
        Me.mnuRTotalInventory_Room.Enabled = False
        Me.mnuRTotalInventory_Room.Index = 5
        Me.mnuRTotalInventory_Room.Text = "Total Inventory Report by &Room"
        Me.mnuRTotalInventory_Room.Visible = False
        '
        'mnuRTotalInventory_TypeOfSet
        '
        Me.mnuRTotalInventory_TypeOfSet.Enabled = False
        Me.mnuRTotalInventory_TypeOfSet.Index = 6
        Me.mnuRTotalInventory_TypeOfSet.Text = "Total Inventory Report by T&ype of Set"
        Me.mnuRTotalInventory_TypeOfSet.Visible = False
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 7
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRSumVoyLot, Me.mnuRLotDetails, Me.mnuRFRDetails, Me.mnuRTotalReceipts, Me.mnuRSumVoySublot, Me.mnuRFishDepositPerCS})
        Me.MenuItem20.Text = "Fish Receipts Report"
        '
        'mnuRSumVoyLot
        '
        Me.mnuRSumVoyLot.Checked = True
        Me.mnuRSumVoyLot.Index = 0
        Me.mnuRSumVoyLot.Text = "Raw Fish Receipts &Summary"
        '
        'mnuRLotDetails
        '
        Me.mnuRLotDetails.Checked = True
        Me.mnuRLotDetails.Index = 1
        Me.mnuRLotDetails.Text = "Trip Code Fish Bin Details"
        '
        'mnuRFRDetails
        '
        Me.mnuRFRDetails.Checked = True
        Me.mnuRFRDetails.Index = 2
        Me.mnuRFRDetails.Text = "Fish &Receipt Fish Bin Details"
        '
        'mnuRTotalReceipts
        '
        Me.mnuRTotalReceipts.Checked = True
        Me.mnuRTotalReceipts.Index = 3
        Me.mnuRTotalReceipts.Text = "Total Round Fish Receipts Summary"
        '
        'mnuRSumVoySublot
        '
        Me.mnuRSumVoySublot.Checked = True
        Me.mnuRSumVoySublot.Index = 4
        Me.mnuRSumVoySublot.Text = "Round Fish per Sublot Receipts Summary"
        '
        'mnuRFishDepositPerCS
        '
        Me.mnuRFishDepositPerCS.Index = 5
        Me.mnuRFishDepositPerCS.Text = "Fish Deposit per Cold Storage"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 8
        Me.MenuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRFWRD, Me.mnuRFWRL, Me.mnuRMRFAA, Me.mnuRFWRS, Me.mnuRFWSDate, Me.mnuRLCA, Me.mnuRCAPD, Me.mnuRFishExport})
        Me.MenuItem18.Text = "Cold Storage Withdrawal"
        '
        'mnuRFWRD
        '
        Me.mnuRFWRD.Checked = True
        Me.mnuRFWRD.Index = 0
        Me.mnuRFWRD.Text = "By Daily"
        '
        'mnuRFWRL
        '
        Me.mnuRFWRL.Index = 1
        Me.mnuRFWRL.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRCA_Overiew, Me.mnuRCA_PushBack, Me.mnuRCA_Bags, Me.mnuRCA_Fish})
        Me.mnuRFWRL.Text = "By Summary"
        '
        'mnuRCA_Overiew
        '
        Me.mnuRCA_Overiew.Checked = True
        Me.mnuRCA_Overiew.Index = 0
        Me.mnuRCA_Overiew.Text = "By Over-All Summary"
        '
        'mnuRCA_PushBack
        '
        Me.mnuRCA_PushBack.Index = 1
        Me.mnuRCA_PushBack.Text = "By Push-Back"
        '
        'mnuRCA_Bags
        '
        Me.mnuRCA_Bags.Index = 2
        Me.mnuRCA_Bags.Text = "By Flakes Bag"
        '
        'mnuRCA_Fish
        '
        Me.mnuRCA_Fish.Index = 3
        Me.mnuRCA_Fish.Text = "By Round Fish"
        '
        'mnuRMRFAA
        '
        Me.mnuRMRFAA.Index = 2
        Me.mnuRMRFAA.Text = "By Monthly Round Fish Acceptance"
        '
        'mnuRFWRS
        '
        Me.mnuRFWRS.Index = 3
        Me.mnuRFWRS.Text = "By Fish Specie"
        '
        'mnuRFWSDate
        '
        Me.mnuRFWSDate.Enabled = False
        Me.mnuRFWSDate.Index = 4
        Me.mnuRFWSDate.Text = "By Inclusive Dates"
        Me.mnuRFWSDate.Visible = False
        '
        'mnuRLCA
        '
        Me.mnuRLCA.Index = 5
        Me.mnuRLCA.Text = "By Lot"
        '
        'mnuRCAPD
        '
        Me.mnuRCAPD.Index = 6
        Me.mnuRCAPD.Text = "By Production Date"
        '
        'mnuRFishExport
        '
        Me.mnuRFishExport.Index = 7
        Me.mnuRFishExport.Text = "By Round Fish Export"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 9
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRLoinInvPD, Me.mnuRLoinInventory, Me.mnuRFZTotal})
        Me.MenuItem24.Text = "Frozen Loins Output"
        '
        'mnuRLoinInvPD
        '
        Me.mnuRLoinInvPD.Index = 0
        Me.mnuRLoinInvPD.Text = "by Production Date"
        '
        'mnuRLoinInventory
        '
        Me.mnuRLoinInventory.Index = 1
        Me.mnuRLoinInventory.Text = "by Period"
        '
        'mnuRFZTotal
        '
        Me.mnuRFZTotal.Index = 2
        Me.mnuRFZTotal.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRFZTotalAl, Me.mnuRFZTotalOthers})
        Me.mnuRFZTotal.Text = "by Summary"
        '
        'mnuRFZTotalAl
        '
        Me.mnuRFZTotalAl.Index = 0
        Me.mnuRFZTotalAl.Text = "Albacore"
        '
        'mnuRFZTotalOthers
        '
        Me.mnuRFZTotalOthers.Index = 1
        Me.mnuRFZTotalOthers.Text = "Others (YF and SJ)"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 10
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.mnuRFGOutput})
        Me.MenuItem25.Text = "Production (Seamer's Record) Output"
        '
        'MenuItem26
        '
        Me.MenuItem26.Checked = True
        Me.MenuItem26.Index = 0
        Me.MenuItem26.Text = "by Daily"
        '
        'mnuRFGOutput
        '
        Me.mnuRFGOutput.Checked = True
        Me.mnuRFGOutput.Index = 1
        Me.mnuRFGOutput.Text = "Finished Goods Output"
        '
        'mnuRLabeling
        '
        Me.mnuRLabeling.Index = 11
        Me.mnuRLabeling.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRDailyLabeling})
        Me.mnuRLabeling.Text = "&Labeling Report"
        '
        'mnuRDailyLabeling
        '
        Me.mnuRDailyLabeling.Index = 0
        Me.mnuRDailyLabeling.Text = "&Daily Labeling Report"
        '
        'mnuRSpoilages
        '
        Me.mnuRSpoilages.Index = 12
        Me.mnuRSpoilages.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRSpoilages_Daily, Me.mnuRSpoilages_Range, Me.mnuRSpoilages_Lot})
        Me.mnuRSpoilages.Text = "Fish Process &Rejects"
        '
        'mnuRSpoilages_Daily
        '
        Me.mnuRSpoilages_Daily.Checked = True
        Me.mnuRSpoilages_Daily.Index = 0
        Me.mnuRSpoilages_Daily.Text = "by Daily"
        '
        'mnuRSpoilages_Range
        '
        Me.mnuRSpoilages_Range.Index = 1
        Me.mnuRSpoilages_Range.Text = "by Summary"
        '
        'mnuRSpoilages_Lot
        '
        Me.mnuRSpoilages_Lot.Checked = True
        Me.mnuRSpoilages_Lot.Index = 2
        Me.mnuRSpoilages_Lot.Text = "by Lot No."
        '
        'mnuRPrepPackingLists
        '
        Me.mnuRPrepPackingLists.Checked = True
        Me.mnuRPrepPackingLists.Index = 13
        Me.mnuRPrepPackingLists.Text = "&Packing Lists"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 14
        Me.MenuItem21.Text = "-"
        '
        'mnuRProductCosting
        '
        Me.mnuRProductCosting.Index = 15
        Me.mnuRProductCosting.Text = "&Product Costing"
        '
        'mnuRDiscrepancy
        '
        Me.mnuRDiscrepancy.Index = 16
        Me.mnuRDiscrepancy.Text = "Production Output &Discrepancy"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 17
        Me.MenuItem31.Text = "-"
        '
        'mnuRRecovery
        '
        Me.mnuRRecovery.Index = 18
        Me.mnuRRecovery.Text = "Production Recover&y"
        '
        'mnuUtility
        '
        Me.mnuUtility.Enabled = False
        Me.mnuUtility.Index = 4
        Me.mnuUtility.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSystemAccount, Me.MenuItem15, Me.mnuChangePassword})
        Me.mnuUtility.Text = "&Utility"
        Me.mnuUtility.Visible = False
        '
        'mnuSystemAccount
        '
        Me.mnuSystemAccount.Index = 0
        Me.mnuSystemAccount.Text = "&System Account"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Text = "-"
        '
        'mnuChangePassword
        '
        Me.mnuChangePassword.Index = 2
        Me.mnuChangePassword.Text = "&Change Password"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 5
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuInquiresForMe, Me.MenuItem28, Me.mnuItemAbout})
        Me.mnuHelp.Text = "&Window"
        '
        'mnuInquiresForMe
        '
        Me.mnuInquiresForMe.Index = 0
        Me.mnuInquiresForMe.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.mnuInquiresForMe.Text = "&For Inquiries  Suggestions"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 1
        Me.MenuItem28.Text = "-"
        '
        'mnuItemAbout
        '
        Me.mnuItemAbout.Index = 2
        Me.mnuItemAbout.Text = "&About"
        '
        'mnuLockPC
        '
        Me.mnuLockPC.Index = 6
        Me.mnuLockPC.Text = "&Lock Applications"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 7
        Me.mnuExit.Text = "E&xit"
        '
        'ToolBar1
        '
        Me.ToolBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton6, Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton16, Me.ToolBarButton7, Me.ToolBarButton8, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton9, Me.ToolBarButton10, Me.ToolBarButton12, Me.ToolBarButton11, Me.ToolBarButton13, Me.ToolBarButton14, Me.ToolBarButton15})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1020, 44)
        Me.ToolBar1.TabIndex = 2
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 0
        Me.ToolBarButton6.Name = "ToolBarButton6"
        Me.ToolBarButton6.Text = "Raw Fish Suppl&y"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Enabled = False
        Me.ToolBarButton1.ImageIndex = 2
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Fish &Lot Number"
        Me.ToolBarButton1.Visible = False
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Enabled = False
        Me.ToolBarButton2.ImageIndex = 5
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "Fish &Deposit"
        Me.ToolBarButton2.Visible = False
        '
        'ToolBarButton16
        '
        Me.ToolBarButton16.ImageIndex = 5
        Me.ToolBarButton16.Name = "ToolBarButton16"
        Me.ToolBarButton16.Text = "&Fish Receipts"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.Enabled = False
        Me.ToolBarButton7.ImageIndex = 1
        Me.ToolBarButton7.Name = "ToolBarButton7"
        Me.ToolBarButton7.Text = "CO&S"
        Me.ToolBarButton7.Visible = False
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.Enabled = False
        Me.ToolBarButton8.ImageIndex = 2
        Me.ToolBarButton8.Name = "ToolBarButton8"
        Me.ToolBarButton8.Text = "C&OP"
        Me.ToolBarButton8.Visible = False
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 4
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "Raw Fish &Withdrawal"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Enabled = False
        Me.ToolBarButton4.ImageIndex = 6
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Text = "Fish &Reject"
        Me.ToolBarButton4.Visible = False
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Enabled = False
        Me.ToolBarButton5.ImageIndex = 7
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Text = "Loinin&g"
        Me.ToolBarButton5.Visible = False
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 8
        Me.ToolBarButton9.Name = "ToolBarButton9"
        Me.ToolBarButton9.Text = "&Product Code"
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.ImageIndex = 9
        Me.ToolBarButton10.Name = "ToolBarButton10"
        Me.ToolBarButton10.Text = "Product&ion Output Data"
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.Enabled = False
        Me.ToolBarButton12.ImageIndex = 7
        Me.ToolBarButton12.Name = "ToolBarButton12"
        Me.ToolBarButton12.Text = "&MRN"
        Me.ToolBarButton12.Visible = False
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.ImageIndex = 6
        Me.ToolBarButton11.Name = "ToolBarButton11"
        Me.ToolBarButton11.Text = "Labelling & Case-&up"
        '
        'ToolBarButton13
        '
        Me.ToolBarButton13.ImageIndex = 11
        Me.ToolBarButton13.Name = "ToolBarButton13"
        Me.ToolBarButton13.Text = "F&G Withdrawal"
        '
        'ToolBarButton14
        '
        Me.ToolBarButton14.ImageIndex = 13
        Me.ToolBarButton14.Name = "ToolBarButton14"
        Me.ToolBarButton14.Text = "FG Shipments"
        '
        'ToolBarButton15
        '
        Me.ToolBarButton15.ImageIndex = 12
        Me.ToolBarButton15.Name = "ToolBarButton15"
        Me.ToolBarButton15.Text = "Invoice"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 653)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.pnl1, Me.pnl2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1020, 24)
        Me.StatusBar1.TabIndex = 4
        '
        'pnl1
        '
        Me.pnl1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.pnl1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Text = "Tri-Marine International Ltd. - Operations Information System"
        Me.pnl1.Width = 501
        '
        'pnl2
        '
        Me.pnl2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.pnl2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Text = "Encoder: "
        Me.pnl2.Width = 501
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(804, 642)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "GenTuna Corp."
        Me.Label2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(916, 619)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(740, 596)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(280, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Timer1
        '
        '
        'mnuRRoundsLight
        '
        Me.mnuRRoundsLight.Checked = True
        Me.mnuRRoundsLight.Index = 4
        Me.mnuRRoundsLight.Text = "Round Fish Inventory - Light Meat"
        '
        'frmMainMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1020, 677)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMainMenu"
        Me.Text = "An Order Monitoring and OFAL Preparation System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pnl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Dim res As String
        res = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Exit")
        If res = vbYes Then
            Application.Exit()
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button.Text() = "Fish &Lot Number" Then
            shortcutToFishLot()
        ElseIf e.Button.Text = "Fish &Deposit" Then
            shortcutToFishDeposit()
        ElseIf e.Button.Text = "Raw Fish &Withdrawal" Then
            shortcutToFishWithdrawal()
        ElseIf e.Button.Text = "Fish &Reject" Then
            shortcutToFishReject()
            'ElseIf e.Button.Text = "Loinin&g" Then
            '    shortcutToLoins()
        ElseIf e.Button.Text = "Raw Fish Suppl&y" Then
            shortcutToCC()
        ElseIf e.Button.Text = "CO&S" Then
            shortcutToCOS()
        ElseIf e.Button.Text = "C&OP" Then
            shortcutToCOP()
        ElseIf e.Button.Text = "&Product Code" Then
            shortcutToProductCode()
        ElseIf e.Button.Text = "Product&ion Output Data" Then
            shortcutToProduction()
        ElseIf e.Button.Text = "Labelling & Case-&up" Then
            shortcutToLabeling()
        ElseIf e.Button.Text = "&MRN" Then
            shortcutToMRN()
        ElseIf e.Button.Text = "F&G Withdrawal" Then
            shortcutToFGWW()
        ElseIf e.Button.Text = "FG Shipments" Then
            shortcutToFGShipments()
        ElseIf e.Button.Text = "Invoice" Then
            shortcuttoFGInvoice()
        ElseIf e.Button.Text = "&Fish Receipts" Then
            shortcutToFR()
        End If
    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim dialogBox As New OpenFileDialog
        'dialogBox.Filter = "Win files (*.ini)|*.ini"

        'dialogBox.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        'If dialogBox.ShowDialog() = DialogResult.OK Then
        '    modModule.setFileName(dialogBox.FileName)
        'Else
        '    MsgBox("Please identify your connection string", MsgBoxStyle.Information, "Warning")
        '    Exit Sub
        'End If

        Me.Text = modModule.getSystemTitle
        Dim f As New frmLogIn
        f.ShowDialog(Me)
        f.Dispose()

        Dim f1 As New frmViewLotStatus
        f1.MdiParent = Me
        f1.Show()

        Me.pnl2.Text = "Encoder: " & modModule.getUserFullName

        accessLevel(f.position)
    End Sub

    Private Sub frmMainMenu_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        If e.Cancel Then
            Dim res As String
            res = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Exit")
            If res = vbYes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub mnuLockPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLockPC.Click
        Dim f As New frmLogIn()
        f.cmdCancel.Enabled = False
        f.ShowDialog(Me)
        f.Dispose()


        Me.pnl2.Text = "Encoder: " & modModule.getUserFullName
        accessLevel(f.position)
    End Sub


    Private Sub mnuInquiresForMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInquiresForMe.Click
        System.Diagnostics.Process.Start("Mailto: ois@trimarinegroup.com")
    End Sub


    Public Sub accessLevel(ByVal position As String)
        Select Case position
            Case "CS Rep", "CS Mgr"
                'LOT
                'ToolBarButton1.Enabled = True
                'ToolBarButton1.Visible = True
                'FISH DEPOSIT
                'ToolBarButton2.Enabled = True
                'ToolBarButton2.Visible = True
                ToolBarButton16.Enabled = False
                ToolBarButton16.Visible = False
                'FISH WITHDRAWAL
                ToolBarButton3.Enabled = True
                ToolBarButton3.Visible = True
                'ToolBarButton4.Enabled = True
                'ToolBarButton4.Visible = True
                'ToolBarButton5.Enabled = True
                'ToolBarButton5.Visible = True
                'CATCH CERTIFICATE
                ToolBarButton6.Enabled = False
                ToolBarButton6.Visible = False
                'ToolBarButton7.Enabled = True
                'ToolBarButton7.Visible = True
                'ToolBarButton8.Enabled = True
                'ToolBarButton8.Visible = True
                'PRODUCT CODE
                ToolBarButton9.Enabled = False
                ToolBarButton9.Visible = False
                'PRODUCTION OUTPUT
                ToolBarButton10.Enabled = False
                ToolBarButton10.Visible = False
                'LABELING AND CASE-UP
                ToolBarButton11.Enabled = False
                ToolBarButton11.Visible = False
                'MRN
                ToolBarButton12.Enabled = False
                ToolBarButton12.Visible = False
                'FG WITHDRAWAL
                ToolBarButton13.Enabled = False
                ToolBarButton13.Visible = False
                ToolBarButton14.Enabled = False
                ToolBarButton14.Visible = False
                ToolBarButton15.Enabled = False
                ToolBarButton15.Visible = False

                mnuMCC.Enabled = False
                mnuMCC.Visible = False
                mnuFishLot.Enabled = False
                mnuFishLot.Visible = False
                mnuMFR.Enabled = False
                mnuMFR.Visible = False
                mnuMFishOwner.Enabled = False
                mnuMFishOwner.Visible = False
                If position = "CS Rep" Then
                    mnuMCS.Enabled = False
                    mnuMCS.Visible = False
                Else
                    mnuMCS.Enabled = True
                    mnuMCS.Visible = True
                End If
                MenuItem6.Enabled = False
                MenuItem6.Visible = False
                mnuMCOS.Enabled = False
                mnuMCOS.Visible = False
                mnuMCOP.Enabled = False
                mnuMCOP.Visible = False
                MenuItem4.Enabled = False
                MenuItem4.Visible = False
                mnuMFish.Enabled = False
                mnuMFish.Visible = False
                mnuMFishSize.Enabled = False
                mnuMFishSize.Visible = False
                mnuMBin.Enabled = False
                mnuMBin.Visible = False
                MenuItem7.Enabled = False
                MenuItem7.Visible = False
                mnuMFishingVessel.Enabled = False
                mnuMFishingVessel.Visible = False
                mnuMSupplier.Enabled = False
                mnuMSupplier.Visible = False
                mnuMFAO.Enabled = False
                mnuMFAO.Visible = False
                mnuMSection.Enabled = False
                mnuMSection.Visible = False
                mnuMLabel.Enabled = False
                mnuMLabel.Visible = False
                mnuMWarehouse.Enabled = False
                mnuMWarehouse.Visible = False
                mnuDReject.Enabled = False
                mnuDReject.Visible = False
                mnuMFGDefect.Enabled = False
                mnuMFGDefect.Visible = False
                MenuItem8.Enabled = False
                MenuItem8.Visible = False
                MenuItem1.Enabled = False
                MenuItem1.Visible = False
                MenuItem12.Enabled = False
                MenuItem12.Visible = False
                MenuItem2.Enabled = False
                MenuItem2.Visible = False
                MenuItem23.Enabled = False
                MenuItem23.Visible = False
                mnuMBOM.Enabled = False
                mnuMBOM.Visible = False
                mnuTPushBack.Enabled = True
                mnuTPushBack.Visible = True
                MenuItem27.Enabled = False
                MenuItem27.Visible = False
                MenuItem29.Enabled = False
                MenuItem29.Visible = False

                mnuTCSMap.Enabled = True
                mnuTCSMap.Visible = True
                mnuTFishReceipts.Enabled = False
                mnuTFishReceipts.Visible = False
                'mnuTD.Enabled = True
                'mnuTD.Visible = True
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                mnuTDeposit2.Enabled = False
                mnuTDeposit2.Visible = False
                mnuTW.Enabled = True
                mnuTW.Visible = True
                mnuTCalibration.Enabled = False
                mnuTCalibration.Visible = False
                'mnuTRejectRound.Enabled = False
                'mnuTRejectRound.Enabled = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTWithdrawal.Enabled = False
                mnuTWithdrawal.Visible = False
                'mnuTWithdrawal2.Enabled = True
                'mnuTWithdrawal2.Visible = True
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTFGShipment.Enabled = False
                mnuTFGShipment.Visible = False
                mnuTFGInvoice.Enabled = False
                mnuTFGInvoice.Visible = False
                mnuTMeatPercent.Enabled = False
                mnuTMeatPercent.Visible = False
                mnuTReject.Enabled = False
                mnuTReject.Visible = False
                'mnuTRejectRound.Enabled = False
                'mnuTRejectRound.Visible = False
                mnuMLoins.Enabled = False
                mnuMLoins.Visible = False
                mnuTQCSample.Enabled = False
                mnuTQCSample.Visible = False
                mnuTQCDispo.Enabled = False
                mnuTQCDispo.Visible = False
                mnuTProduction.Enabled = False
                mnuTProduction.Visible = False
                mnuTLabeling.Enabled = False
                mnuTLabeling.Visible = False
                mnuTFGOutput.Enabled = False
                mnuTFGOutput.Visible = False
                mnuTFGWW.Enabled = False
                mnuTFGWW.Visible = False
                MenuItem19.Enabled = False
                MenuItem19.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                'mrnTMRNBegInventory.Enabled = True
                'mrnTMRNBegInventory.Visible = True
                mnuTMaterialCost.Enabled = False
                mnuTMaterialCost.Visible = False
                mnuTMRNUsage.Enabled = False
                mnuTMRNUsage.Visible = False
                MenuItem22.Enabled = False
                MenuItem22.Visible = False
                mnuTUpdateFishLot.Enabled = False
                mnuTUpdateFishLot.Visible = False
                mnuTUpdateBinStatus.Enabled = False
                mnuTUpdateBinStatus.Visible = False
                mnuTAnalysis.Enabled = True
                mnuTAnalysis.Visible = True

                mnuRLotActivity.Enabled = True
                mnuRLotActivity.Visible = True
                mnuRTotalInventory.Enabled = True
                mnuRTotalInventory.Visible = True
                MenuItem20.Enabled = False
                MenuItem20.Visible = False
                MenuItem18.Enabled = True
                MenuItem18.Visible = True
                MenuItem24.Enabled = False
                MenuItem24.Visible = False
                MenuItem25.Enabled = False
                MenuItem25.Visible = False
                mnuRSpoilages.Enabled = False
                mnuRSpoilages.Visible = False
                mnuRPrepPackingLists.Enabled = False
                mnuRPrepPackingLists.Visible = False
                MenuItem21.Enabled = False
                MenuItem21.Visible = False
                mnuRProductCosting.Enabled = False
                mnuRProductCosting.Visible = False
                mnuRDiscrepancy.Enabled = False
                mnuRDiscrepancy.Visible = False
                MenuItem31.Enabled = False
                MenuItem31.Visible = False
                mnuRRecovery.Enabled = False
                mnuRRecovery.Visible = False

            Case "Inventory"
                'LOT
                'ToolBarButton1.Enabled = True
                'ToolBarButton1.Visible = True
                'FISH DEPOSIT
                'ToolBarButton2.Enabled = False
                'ToolBarButton2.Visible = False
                ToolBarButton16.Enabled = False
                ToolBarButton16.Visible = False
                'FISH WITHDRAWAL
                ToolBarButton3.Enabled = False
                ToolBarButton3.Visible = False
                'ToolBarButton4.Enabled = True
                'ToolBarButton4.Visible = True
                'ToolBarButton5.Enabled = True
                'ToolBarButton5.Visible = True
                'CATCH CERTIFICATE
                ToolBarButton6.Enabled = False
                ToolBarButton6.Visible = False
                'ToolBarButton7.Enabled = True
                'ToolBarButton7.Visible = True
                'ToolBarButton8.Enabled = True
                'ToolBarButton8.Visible = True
                'PRODUCT CODE
                ToolBarButton9.Enabled = False
                ToolBarButton9.Visible = False
                'PRODUCTION OUTPUT
                ToolBarButton10.Enabled = False
                ToolBarButton10.Visible = False
                'LABELING AND CASE-UP
                ToolBarButton11.Enabled = False
                ToolBarButton11.Visible = False
                'MRN
                ToolBarButton12.Enabled = False
                ToolBarButton12.Visible = False
                'FG WITHDRAWAL
                ToolBarButton13.Enabled = True
                ToolBarButton13.Visible = True
                ToolBarButton14.Enabled = True
                ToolBarButton14.Visible = True
                ToolBarButton15.Enabled = True
                ToolBarButton15.Visible = True

                mnuMCC.Enabled = False
                mnuMCC.Visible = False
                mnuFishLot.Enabled = False
                mnuFishLot.Visible = False
                mnuMFR.Enabled = False
                mnuMFR.Visible = False
                mnuMFishOwner.Enabled = False
                mnuMFishOwner.Visible = False
                mnuMCS.Enabled = False
                mnuMCS.Visible = False
                MenuItem6.Enabled = False
                MenuItem6.Visible = False
                mnuMCOS.Enabled = False
                mnuMCOS.Visible = False
                mnuMCOP.Enabled = False
                mnuMCOP.Visible = False
                MenuItem4.Enabled = False
                MenuItem4.Visible = False
                mnuMFish.Enabled = False
                mnuMFish.Visible = False
                mnuMFishSize.Enabled = False
                mnuMFishSize.Visible = False
                mnuMBin.Enabled = False
                mnuMBin.Visible = False
                MenuItem7.Enabled = False
                MenuItem7.Visible = False
                mnuMFishingVessel.Enabled = False
                mnuMFishingVessel.Visible = False
                mnuMSupplier.Enabled = False
                mnuMSupplier.Visible = False
                mnuMFAO.Enabled = False
                mnuMFAO.Visible = False
                mnuMSection.Enabled = False
                mnuMSection.Visible = False
                mnuMLabel.Enabled = False
                mnuMLabel.Visible = False
                mnuMWarehouse.Enabled = False
                mnuMWarehouse.Visible = False
                mnuDReject.Enabled = False
                mnuDReject.Visible = False
                mnuMFGDefect.Enabled = False
                mnuMFGDefect.Visible = False
                MenuItem8.Enabled = False
                MenuItem8.Visible = False
                MenuItem1.Enabled = False
                MenuItem1.Visible = False
                MenuItem12.Enabled = False
                MenuItem12.Visible = False
                MenuItem2.Enabled = False
                MenuItem2.Visible = False
                MenuItem23.Enabled = False
                MenuItem23.Visible = False
                mnuMBOM.Enabled = False
                mnuMBOM.Visible = False
                mnuTPushBack.Enabled = False
                mnuTPushBack.Visible = False
                MenuItem27.Enabled = False
                MenuItem27.Visible = False
                MenuItem29.Enabled = False
                MenuItem29.Visible = False

                mnuTFishReceipts.Enabled = False
                mnuTFishReceipts.Visible = False
                'mnuTD.Enabled = False
                'mnuTD.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                mnuTDeposit2.Enabled = False
                mnuTDeposit2.Visible = False
                mnuTW.Enabled = False
                mnuTW.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTWithdrawal.Enabled = False
                mnuTWithdrawal.Visible = False
                'mnuTWithdrawal2.Enabled = True
                'mnuTWithdrawal2.Visible = True
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTFGShipment.Enabled = True
                mnuTFGShipment.Visible = True
                mnuTFGInvoice.Enabled = True
                mnuTFGInvoice.Visible = True
                mnuTMeatPercent.Enabled = False
                mnuTMeatPercent.Visible = False
                mnuTReject.Enabled = False
                mnuTReject.Visible = False
                'mnuTRejectRound.Enabled = False
                'mnuTRejectRound.Visible = False
                mnuMLoins.Enabled = False
                mnuMLoins.Visible = False
                mnuTQCSample.Enabled = False
                mnuTQCSample.Visible = False
                mnuTQCDispo.Enabled = False
                mnuTQCDispo.Visible = False
                mnuTProduction.Enabled = False
                mnuTProduction.Visible = False
                mnuTLabeling.Enabled = False
                mnuTLabeling.Visible = False
                mnuTFGOutput.Enabled = False
                mnuTFGOutput.Visible = False
                mnuTFGWW.Enabled = True
                mnuTFGWW.Visible = True
                MenuItem19.Enabled = False
                MenuItem19.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                'mrnTMRNBegInventory.Enabled = True
                'mrnTMRNBegInventory.Visible = True
                mnuTMaterialCost.Enabled = False
                mnuTMaterialCost.Visible = False
                mnuTMRNUsage.Enabled = False
                mnuTMRNUsage.Visible = False
                MenuItem22.Enabled = False
                MenuItem22.Visible = False
                mnuTUpdateFishLot.Enabled = False
                mnuTUpdateFishLot.Visible = False
                mnuTUpdateBinStatus.Enabled = False
                mnuTUpdateBinStatus.Visible = False
                mnuTAnalysis.Enabled = False
                mnuTAnalysis.Visible = False

                mnuRLotActivity.Enabled = False
                mnuRLotActivity.Visible = False
                mnuRTotalInventory.Enabled = True
                mnuRTotalInventory.Visible = True
                MenuItem20.Enabled = False
                MenuItem20.Visible = False
                MenuItem18.Enabled = True
                MenuItem18.Visible = True
                MenuItem24.Enabled = True
                MenuItem24.Visible = True
                MenuItem25.Enabled = True
                MenuItem25.Visible = True
                mnuRSpoilages.Enabled = True
                mnuRSpoilages.Visible = True
                mnuRPrepPackingLists.Enabled = True
                mnuRPrepPackingLists.Visible = True
                MenuItem21.Enabled = False
                MenuItem21.Visible = False
                mnuRProductCosting.Enabled = False
                mnuRProductCosting.Visible = False
                mnuRDiscrepancy.Enabled = False
                mnuRDiscrepancy.Visible = False
                MenuItem31.Enabled = False
                MenuItem31.Visible = False
                mnuRRecovery.Enabled = False
                mnuRRecovery.Visible = False

            Case "Analyst", "QA Rep", "QA Mgr"
                'LOT
                'ToolBarButton1.Enabled = True
                'ToolBarButton1.Visible = True
                'FISH DEPOSIT
                'ToolBarButton2.Enabled = False
                'ToolBarButton2.Visible = False
                ToolBarButton16.Enabled = False
                ToolBarButton16.Visible = False
                'FISH WITHDRAWAL
                ToolBarButton3.Enabled = False
                ToolBarButton3.Visible = False
                'ToolBarButton4.Enabled = True
                'ToolBarButton4.Visible = True
                'ToolBarButton5.Enabled = True
                'ToolBarButton5.Visible = True
                'CATCH CERTIFICATE
                ToolBarButton6.Enabled = False
                ToolBarButton6.Visible = False
                'ToolBarButton7.Enabled = True
                'ToolBarButton7.Visible = True
                'ToolBarButton8.Enabled = True
                'ToolBarButton8.Visible = True
                'PRODUCT CODE
                ToolBarButton9.Enabled = True
                ToolBarButton9.Visible = True
                'PRODUCTION OUTPUT
                ToolBarButton10.Enabled = False
                ToolBarButton10.Visible = False
                'LABELING AND CASE-UP
                ToolBarButton11.Enabled = False
                ToolBarButton11.Visible = False
                'MRN
                ToolBarButton12.Enabled = False
                ToolBarButton12.Visible = False
                'FG WITHDRAWAL
                ToolBarButton13.Enabled = False
                ToolBarButton13.Visible = False
                ToolBarButton14.Enabled = False
                ToolBarButton14.Visible = False
                ToolBarButton15.Enabled = False
                ToolBarButton15.Visible = False

                mnuMCC.Enabled = False
                mnuMCC.Visible = False
                mnuFishLot.Enabled = False
                mnuFishLot.Visible = False
                mnuMFR.Enabled = False
                mnuMFR.Visible = False
                mnuMFishOwner.Enabled = False
                mnuMFishOwner.Visible = False
                mnuMCS.Enabled = False
                mnuMCS.Visible = False
                MenuItem6.Enabled = False
                MenuItem6.Visible = False
                mnuMCOS.Enabled = False
                mnuMCOS.Visible = False
                mnuMCOP.Enabled = False
                mnuMCOP.Visible = False
                MenuItem4.Enabled = False
                MenuItem4.Visible = False
                mnuMFish.Enabled = False
                mnuMFish.Visible = False
                mnuMFishSize.Enabled = False
                mnuMFishSize.Visible = False
                mnuMBin.Enabled = False
                mnuMBin.Visible = False
                MenuItem7.Enabled = False
                MenuItem7.Visible = False
                mnuMFishingVessel.Enabled = False
                mnuMFishingVessel.Visible = False
                mnuMSupplier.Enabled = False
                mnuMSupplier.Visible = False
                mnuMFAO.Enabled = False
                mnuMFAO.Visible = False
                mnuMSection.Enabled = False
                mnuMSection.Visible = False
                mnuMLabel.Enabled = False
                mnuMLabel.Visible = False
                mnuMWarehouse.Enabled = False
                mnuMWarehouse.Visible = False
                mnuDReject.Enabled = False
                mnuDReject.Visible = False
                mnuMFGDefect.Enabled = False
                mnuMFGDefect.Visible = False
                MenuItem8.Enabled = False
                MenuItem8.Visible = False
                MenuItem1.Enabled = False
                MenuItem1.Visible = False
                MenuItem12.Enabled = False
                MenuItem12.Visible = False
                MenuItem2.Enabled = False
                MenuItem2.Visible = False
                MenuItem23.Enabled = False
                MenuItem23.Visible = False
                mnuMBOM.Enabled = True
                mnuMBOM.Visible = True
                mnuTPushBack.Enabled = False
                mnuTPushBack.Visible = False
                MenuItem27.Enabled = False
                MenuItem27.Visible = False
                MenuItem29.Enabled = False
                MenuItem29.Visible = False

                mnuTCSMap.Enabled = False
                mnuTCSMap.Visible = False
                mnuTFishReceipts.Enabled = False
                mnuTFishReceipts.Visible = False
                'mnuTD.Enabled = False
                'mnuTD.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                mnuTDeposit2.Enabled = False
                mnuTDeposit2.Visible = False
                mnuTW.Enabled = False
                mnuTW.Visible = False
                mnuTCalibration.Enabled = False
                mnuTCalibration.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTWithdrawal.Enabled = False
                mnuTWithdrawal.Visible = False
                'mnuTWithdrawal2.Enabled = False
                'mnuTWithdrawal2.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTFGShipment.Enabled = False
                mnuTFGShipment.Visible = False
                mnuTFGInvoice.Enabled = False
                mnuTFGInvoice.Visible = False
                mnuTMeatPercent.Enabled = False
                mnuTMeatPercent.Visible = False
                mnuTReject.Enabled = False
                mnuTReject.Visible = False
                'mnuTRejectRound.Enabled = False
                'mnuTRejectRound.Visible = False
                mnuMLoins.Enabled = False
                mnuMLoins.Visible = False
                mnuTQCSample.Enabled = False
                mnuTQCSample.Visible = False
                mnuTQCDispo.Enabled = False
                mnuTQCDispo.Visible = False
                mnuTProduction.Enabled = False
                mnuTProduction.Visible = False
                mnuTLabeling.Enabled = False
                mnuTLabeling.Visible = False
                mnuTFGOutput.Enabled = False
                mnuTFGOutput.Visible = False
                mnuTFGWW.Enabled = False
                mnuTFGWW.Visible = False
                MenuItem19.Enabled = False
                MenuItem19.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                'mrnTMRNBegInventory.Enabled = True
                'mrnTMRNBegInventory.Visible = True
                mnuTMaterialCost.Enabled = False
                mnuTMaterialCost.Visible = False
                mnuTMRNUsage.Enabled = False
                mnuTMRNUsage.Visible = False
                MenuItem22.Enabled = False
                MenuItem22.Visible = False
                mnuTUpdateFishLot.Enabled = False
                mnuTUpdateFishLot.Visible = False
                mnuTUpdateBinStatus.Enabled = False
                mnuTUpdateBinStatus.Visible = False
                mnuTAnalysis.Enabled = True
                mnuTAnalysis.Visible = True

                mnuRLotActivity.Enabled = False
                mnuRLotActivity.Visible = False
                mnuRTotalInventory.Enabled = True
                mnuRTotalInventory.Visible = True
                MenuItem20.Enabled = False
                MenuItem20.Visible = False
                MenuItem18.Enabled = True
                MenuItem18.Visible = True
                MenuItem24.Enabled = False
                MenuItem24.Visible = False
                MenuItem25.Enabled = False
                MenuItem25.Visible = False
                mnuRSpoilages.Enabled = False
                mnuRSpoilages.Visible = False
                mnuRPrepPackingLists.Enabled = True
                mnuRPrepPackingLists.Visible = True
                MenuItem21.Enabled = False
                MenuItem21.Visible = False
                mnuRProductCosting.Enabled = False
                mnuRProductCosting.Visible = False
                mnuRDiscrepancy.Enabled = False
                mnuRDiscrepancy.Visible = False
                MenuItem31.Enabled = False
                MenuItem31.Visible = False
                mnuRRecovery.Enabled = False
                mnuRRecovery.Visible = False

            Case "Cannery Clerk"
                'LOT
                'ToolBarButton1.Enabled = True
                'ToolBarButton1.Visible = True
                'FISH DEPOSIT
                'ToolBarButton2.Enabled = False
                'ToolBarButton2.Visible = False
                ToolBarButton16.Enabled = False
                ToolBarButton16.Visible = False
                'FISH WITHDRAWAL
                ToolBarButton3.Enabled = False
                ToolBarButton3.Visible = False
                'ToolBarButton4.Enabled = True
                'ToolBarButton4.Visible = True
                'ToolBarButton5.Enabled = True
                'ToolBarButton5.Visible = True
                'CATCH CERTIFICATE
                ToolBarButton6.Enabled = False
                ToolBarButton6.Visible = False
                'ToolBarButton7.Enabled = True
                'ToolBarButton7.Visible = True
                'ToolBarButton8.Enabled = True
                'ToolBarButton8.Visible = True
                'PRODUCT CODE
                ToolBarButton9.Enabled = False
                ToolBarButton9.Visible = False
                'PRODUCTION OUTPUT
                ToolBarButton10.Enabled = True
                ToolBarButton10.Visible = True
                'LABELING AND CASE-UP
                ToolBarButton11.Enabled = True
                ToolBarButton11.Visible = True
                'MRN
                ToolBarButton12.Enabled = False
                ToolBarButton12.Visible = False
                'FG WITHDRAWAL
                ToolBarButton13.Enabled = True
                ToolBarButton13.Visible = True
                ToolBarButton14.Enabled = True
                ToolBarButton14.Visible = True
                ToolBarButton15.Enabled = False
                ToolBarButton15.Visible = False

                mnuMCC.Enabled = False
                mnuMCC.Visible = False
                mnuFishLot.Enabled = False
                mnuFishLot.Visible = False
                mnuMFR.Enabled = False
                mnuMFR.Visible = False
                mnuMFishOwner.Enabled = False
                mnuMFishOwner.Visible = False
                mnuMCS.Enabled = False
                mnuMCS.Visible = False
                MenuItem6.Enabled = False
                MenuItem6.Visible = False
                mnuMCOS.Enabled = False
                mnuMCOS.Visible = False
                mnuMCOP.Enabled = False
                mnuMCOP.Visible = False
                MenuItem4.Enabled = False
                MenuItem4.Visible = False
                mnuMFish.Enabled = False
                mnuMFish.Visible = False
                mnuMFishSize.Enabled = False
                mnuMFishSize.Visible = False
                mnuMBin.Enabled = False
                mnuMBin.Visible = False
                MenuItem7.Enabled = False
                MenuItem7.Visible = False
                mnuMFishingVessel.Enabled = False
                mnuMFishingVessel.Visible = False
                mnuMSupplier.Enabled = False
                mnuMSupplier.Visible = False
                mnuMFAO.Enabled = False
                mnuMFAO.Visible = False
                mnuMSection.Enabled = True
                mnuMSection.Visible = True
                mnuMLabel.Enabled = False
                mnuMLabel.Visible = False
                mnuMWarehouse.Enabled = False
                mnuMWarehouse.Visible = False
                mnuDReject.Enabled = True
                mnuDReject.Visible = True
                mnuMFGDefect.Enabled = False
                mnuMFGDefect.Visible = False
                MenuItem8.Enabled = False
                MenuItem8.Visible = False
                MenuItem1.Enabled = False
                MenuItem1.Visible = False
                MenuItem12.Enabled = False
                MenuItem12.Visible = False
                MenuItem2.Enabled = False
                MenuItem2.Visible = False
                MenuItem23.Enabled = False
                MenuItem23.Visible = False
                mnuMBOM.Enabled = False
                mnuMBOM.Visible = False
                mnuTPushBack.Enabled = False
                mnuTPushBack.Visible = False
                MenuItem27.Enabled = False
                MenuItem27.Visible = False
                MenuItem29.Enabled = False
                MenuItem29.Visible = False

                mnuTFishReceipts.Enabled = False
                mnuTFishReceipts.Visible = False
                'mnuTD.Enabled = False
                'mnuTD.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                mnuTDeposit2.Enabled = False
                mnuTDeposit2.Visible = False
                mnuTW.Enabled = True
                mnuTW.Visible = True
                mnuTFishRacking.Enabled = True
                mnuTFishRacking.Visible = True
                mnuTWithdrawal.Enabled = False
                mnuTWithdrawal.Visible = False
                'mnuTWithdrawal2.Enabled = False
                'mnuTWithdrawal2.Visible = False
                mnuTFishRacking.Enabled = True
                mnuTFishRacking.Visible = True
                mnuTFGShipment.Enabled = True
                mnuTFGShipment.Visible = True
                mnuTFGInvoice.Enabled = False
                mnuTFGInvoice.Visible = False
                mnuTMeatPercent.Enabled = True
                mnuTMeatPercent.Visible = True
                mnuTReject.Enabled = True
                mnuTReject.Visible = True
                'mnuTRejectRound.Enabled = False
                'mnuTRejectRound.Visible = False
                mnuMLoins.Enabled = False
                mnuMLoins.Visible = False
                mnuTQCSample.Enabled = False
                mnuTQCSample.Visible = False
                mnuTQCDispo.Enabled = False
                mnuTQCDispo.Visible = False
                mnuTProduction.Enabled = True
                mnuTProduction.Visible = True
                mnuTLabeling.Enabled = True
                mnuTLabeling.Visible = True
                mnuTFGOutput.Enabled = False
                mnuTFGOutput.Visible = False
                mnuTFGWW.Enabled = True
                mnuTFGWW.Visible = True
                MenuItem19.Enabled = False
                MenuItem19.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                'mrnTMRNBegInventory.Enabled = True
                'mrnTMRNBegInventory.Visible = True
                mnuTMaterialCost.Enabled = False
                mnuTMaterialCost.Visible = False
                mnuTMRNUsage.Enabled = False
                mnuTMRNUsage.Visible = False
                MenuItem22.Enabled = False
                MenuItem22.Visible = False
                mnuTUpdateFishLot.Enabled = False
                mnuTUpdateFishLot.Visible = False
                mnuTUpdateBinStatus.Enabled = False
                mnuTUpdateBinStatus.Visible = False
                mnuTPushBack.Enabled = True
                mnuTPushBack.Visible = True
                mnuTAnalysis.Enabled = True
                mnuTAnalysis.Visible = True

                mnuRLotActivity.Enabled = True
                mnuRLotActivity.Visible = True
                mnuRTotalInventory.Enabled = True
                mnuRTotalInventory.Visible = True
                MenuItem20.Enabled = True
                MenuItem20.Visible = True
                MenuItem18.Enabled = True
                MenuItem18.Visible = True
                MenuItem24.Enabled = True
                MenuItem24.Visible = True
                MenuItem25.Enabled = True
                MenuItem25.Visible = True
                mnuRSpoilages.Enabled = True
                mnuRSpoilages.Visible = True
                mnuRPrepPackingLists.Enabled = True
                mnuRPrepPackingLists.Visible = True
                MenuItem21.Enabled = True
                MenuItem21.Visible = True
                mnuRProductCosting.Enabled = False
                mnuRProductCosting.Visible = False
                mnuRDiscrepancy.Enabled = True
                mnuRDiscrepancy.Visible = True
                MenuItem31.Enabled = False
                MenuItem31.Visible = False
                mnuRRecovery.Enabled = True
                mnuRRecovery.Visible = True

            Case "Receiving"
                'LOT
                'ToolBarButton1.Enabled = True
                'ToolBarButton1.Visible = True
                'FISH DEPOSIT
                'ToolBarButton2.Enabled = True
                'ToolBarButton2.Visible = True
                ToolBarButton16.Enabled = True
                ToolBarButton16.Visible = True
                'FISH WITHDRAWAL
                ToolBarButton3.Enabled = False
                ToolBarButton3.Visible = False
                'ToolBarButton4.Enabled = True
                'ToolBarButton4.Visible = True
                'ToolBarButton5.Enabled = True
                'ToolBarButton5.Visible = True
                'CATCH CERTIFICATE
                ToolBarButton6.Enabled = True
                ToolBarButton6.Visible = True
                'ToolBarButton7.Enabled = True
                'ToolBarButton7.Visible = True
                'ToolBarButton8.Enabled = True
                'ToolBarButton8.Visible = True
                'PRODUCT CODE
                ToolBarButton9.Enabled = False
                ToolBarButton9.Visible = False
                'PRODUCTION OUTPUT
                ToolBarButton10.Enabled = False
                ToolBarButton10.Visible = False
                'LABELING AND CASE-UP
                ToolBarButton11.Enabled = False
                ToolBarButton11.Visible = False
                'MRN
                ToolBarButton12.Enabled = False
                ToolBarButton12.Visible = False
                'FG WITHDRAWAL
                ToolBarButton13.Enabled = False
                ToolBarButton13.Visible = False
                ToolBarButton14.Enabled = False
                ToolBarButton14.Visible = False
                ToolBarButton15.Enabled = False
                ToolBarButton15.Visible = False

                mnuTFishReceipts.Enabled = True
                mnuTFishReceipts.Visible = True
                mnuMCC.Enabled = True
                mnuMCC.Visible = True
                mnuFishLot.Enabled = True
                mnuFishLot.Visible = True
                mnuMFR.Enabled = True
                mnuMFR.Visible = True
                mnuMFishOwner.Enabled = True
                mnuMFishOwner.Visible = True
                mnuMCS.Enabled = False
                mnuMCS.Visible = False
                MenuItem6.Enabled = False
                MenuItem6.Visible = False
                mnuMCOS.Enabled = False
                mnuMCOS.Visible = False
                mnuMCOP.Enabled = False
                mnuMCOP.Visible = False
                MenuItem4.Enabled = False
                MenuItem4.Visible = False
                mnuMFish.Enabled = True
                mnuMFish.Visible = True
                mnuMFishSize.Enabled = True
                mnuMFishSize.Visible = True
                mnuMBin.Enabled = True
                mnuMBin.Visible = True
                MenuItem7.Enabled = False
                MenuItem7.Visible = False
                mnuMFishingVessel.Enabled = False
                mnuMFishingVessel.Visible = False
                mnuMSupplier.Enabled = False
                mnuMSupplier.Visible = False
                mnuMFAO.Enabled = False
                mnuMFAO.Visible = False
                mnuMSection.Enabled = False
                mnuMSection.Visible = False
                mnuMLabel.Enabled = False
                mnuMLabel.Visible = False
                mnuMWarehouse.Enabled = False
                mnuMWarehouse.Visible = False
                mnuDReject.Enabled = False
                mnuDReject.Visible = False
                'mnuTRejectRound.Enabled = True
                'mnuTRejectRound.Visible = True
                mnuMFGDefect.Enabled = False
                mnuMFGDefect.Visible = False
                MenuItem8.Enabled = False
                MenuItem8.Visible = False
                MenuItem1.Enabled = False
                MenuItem1.Visible = False
                MenuItem12.Enabled = False
                MenuItem12.Visible = False
                MenuItem2.Enabled = False
                MenuItem2.Visible = False
                MenuItem23.Enabled = False
                MenuItem23.Visible = False
                mnuMBOM.Enabled = False
                mnuMBOM.Visible = False

                'mnuTD.Enabled = True
                'mnuTD.Visible = True
                mnuTCSMap.Enabled = False
                mnuTCSMap.Visible = False
                mnuTDeposit.Enabled = True
                mnuTDeposit.Visible = True
                mnuTDeposit2.Enabled = False
                mnuTDeposit2.Visible = False
                mnuTW.Enabled = False
                mnuTW.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTWithdrawal.Enabled = True
                mnuTWithdrawal.Visible = True
                'mnuTWithdrawal2.Enabled = False
                'mnuTWithdrawal2.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTFGShipment.Enabled = False
                mnuTFGShipment.Visible = False
                mnuTFGInvoice.Enabled = False
                mnuTFGInvoice.Visible = False
                mnuTMeatPercent.Enabled = False
                mnuTMeatPercent.Visible = False
                mnuTReject.Enabled = False
                mnuTReject.Visible = False
                mnuMLoins.Enabled = False
                mnuMLoins.Visible = False
                mnuTQCSample.Enabled = False
                mnuTQCSample.Visible = False
                mnuTQCDispo.Enabled = False
                mnuTQCDispo.Visible = False
                mnuTProduction.Enabled = False
                mnuTProduction.Visible = False
                mnuTLabeling.Enabled = False
                mnuTLabeling.Visible = False
                mnuTFGOutput.Enabled = False
                mnuTFGOutput.Visible = False
                mnuTFGWW.Enabled = False
                mnuTFGWW.Visible = False
                MenuItem19.Enabled = False
                MenuItem19.Visible = False
                'mrnTMRNBegInventory.Enabled = False
                'mrnTMRNBegInventory.Visible = False
                mnuTMaterialCost.Enabled = False
                mnuTMaterialCost.Visible = False
                mnuTMRNUsage.Enabled = False
                mnuTMRNUsage.Visible = False
                MenuItem22.Enabled = False
                MenuItem22.Visible = False
                mnuTUpdateFishLot.Enabled = False
                mnuTUpdateFishLot.Visible = False
                mnuTUpdateBinStatus.Enabled = False
                mnuTUpdateBinStatus.Visible = False
                mnuTPushBack.Enabled = False
                mnuTPushBack.Visible = False
                MenuItem27.Enabled = False
                MenuItem27.Visible = False
                MenuItem29.Enabled = False
                MenuItem29.Visible = False
                mnuTAnalysis.Enabled = True
                mnuTAnalysis.Visible = True

                mnuRLotActivity.Enabled = True
                mnuRLotActivity.Visible = True
                mnuRTotalInventory.Enabled = True
                mnuRTotalInventory.Visible = True
                MenuItem20.Enabled = True
                MenuItem20.Visible = True
                MenuItem18.Enabled = True
                MenuItem18.Visible = True
                MenuItem24.Enabled = False
                MenuItem24.Visible = False
                MenuItem25.Enabled = False
                MenuItem25.Visible = False
                mnuRSpoilages.Enabled = False
                mnuRSpoilages.Visible = False
                mnuRPrepPackingLists.Enabled = False
                mnuRPrepPackingLists.Visible = False
                MenuItem21.Enabled = False
                MenuItem21.Visible = False
                mnuRProductCosting.Enabled = False
                mnuRProductCosting.Visible = False
                mnuRDiscrepancy.Enabled = False
                mnuRDiscrepancy.Visible = False
                MenuItem31.Enabled = False
                MenuItem31.Visible = False
                mnuRRecovery.Enabled = False
                mnuRRecovery.Visible = False

            Case "COS"
                'LOT
                'ToolBarButton1.Enabled = True
                'ToolBarButton1.Visible = True
                'FISH DEPOSIT
                'ToolBarButton2.Enabled = False
                'ToolBarButton2.Visible = False
                ToolBarButton16.Enabled = False
                ToolBarButton16.Visible = False
                'FISH WITHDRAWAL
                ToolBarButton3.Enabled = False
                ToolBarButton3.Visible = False
                'ToolBarButton4.Enabled = True
                'ToolBarButton4.Visible = True
                'ToolBarButton5.Enabled = True
                'ToolBarButton5.Visible = True
                'CATCH CERTIFICATE
                ToolBarButton6.Enabled = False
                ToolBarButton6.Visible = False
                'ToolBarButton7.Enabled = True
                'ToolBarButton7.Visible = True
                'ToolBarButton8.Enabled = True
                'ToolBarButton8.Visible = True
                'PRODUCT CODE
                ToolBarButton9.Enabled = False
                ToolBarButton9.Visible = False
                'PRODUCTION OUTPUT
                ToolBarButton10.Enabled = False
                ToolBarButton10.Visible = False
                'LABELING AND CASE-UP
                ToolBarButton11.Enabled = False
                ToolBarButton11.Visible = False
                'MRN
                ToolBarButton12.Enabled = False
                ToolBarButton12.Visible = False
                'FG WITHDRAWAL
                ToolBarButton13.Enabled = True
                ToolBarButton13.Visible = True
                'FG SHIPMENTS
                ToolBarButton14.Enabled = True
                ToolBarButton14.Visible = True
                'FG INVOICE
                ToolBarButton15.Enabled = True
                ToolBarButton15.Visible = True

                mnuMCC.Enabled = False
                mnuMCC.Visible = False
                mnuFishLot.Enabled = False
                mnuFishLot.Visible = False
                mnuMFR.Enabled = False
                mnuMFR.Visible = False
                mnuMFishOwner.Enabled = False
                mnuMFishOwner.Visible = False
                mnuMCS.Enabled = False
                mnuMCS.Visible = False
                MenuItem6.Enabled = False
                MenuItem6.Visible = False
                mnuMCOS.Enabled = True
                mnuMCOS.Visible = True
                mnuMCOP.Enabled = True
                mnuMCOP.Visible = True
                MenuItem4.Enabled = False
                MenuItem4.Visible = False
                mnuMFish.Enabled = False
                mnuMFish.Visible = False
                mnuMFishSize.Enabled = False
                mnuMFishSize.Visible = False
                mnuMBin.Enabled = False
                mnuMBin.Visible = False
                MenuItem7.Enabled = False
                MenuItem7.Visible = False
                mnuMFishingVessel.Enabled = False
                mnuMFishingVessel.Visible = False
                mnuMSupplier.Enabled = False
                mnuMSupplier.Visible = False
                mnuMFAO.Enabled = False
                mnuMFAO.Visible = False
                mnuMSection.Enabled = False
                mnuMSection.Visible = False
                mnuMLabel.Enabled = False
                mnuMLabel.Visible = False
                mnuMWarehouse.Enabled = False
                mnuMWarehouse.Visible = False
                mnuDReject.Enabled = False
                mnuDReject.Visible = False
                mnuMFGDefect.Enabled = False
                mnuMFGDefect.Visible = False
                MenuItem8.Enabled = False
                MenuItem8.Visible = False
                MenuItem1.Enabled = False
                MenuItem1.Visible = False
                MenuItem12.Enabled = False
                MenuItem12.Visible = False
                MenuItem2.Enabled = False
                MenuItem2.Visible = False
                MenuItem23.Enabled = False
                MenuItem23.Visible = False
                mnuMBOM.Enabled = False
                mnuMBOM.Visible = False
                mnuTPushBack.Enabled = False
                mnuTPushBack.Visible = False
                MenuItem27.Enabled = False
                MenuItem27.Visible = False
                MenuItem29.Enabled = False
                MenuItem29.Visible = False

                mnuTFishReceipts.Enabled = False
                mnuTFishReceipts.Visible = False
                'mnuTD.Enabled = False
                'mnuTD.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                mnuTDeposit2.Enabled = False
                mnuTDeposit2.Visible = False
                mnuTW.Enabled = False
                mnuTW.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTWithdrawal.Enabled = False
                mnuTWithdrawal.Visible = False
                'mnuTWithdrawal2.Enabled = False
                'mnuTWithdrawal2.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTFGShipment.Enabled = True
                mnuTFGShipment.Visible = True
                mnuTFGInvoice.Enabled = True
                mnuTFGInvoice.Visible = True
                mnuTMeatPercent.Enabled = False
                mnuTMeatPercent.Visible = False
                mnuTReject.Enabled = False
                mnuTReject.Visible = False
                'mnuTRejectRound.Enabled = False
                'mnuTRejectRound.Visible = False
                mnuMLoins.Enabled = False
                mnuMLoins.Visible = False
                mnuTQCSample.Enabled = False
                mnuTQCSample.Visible = False
                mnuTQCDispo.Enabled = False
                mnuTQCDispo.Visible = False
                mnuTProduction.Enabled = False
                mnuTProduction.Visible = False
                mnuTLabeling.Enabled = False
                mnuTLabeling.Visible = False
                mnuTFGOutput.Enabled = False
                mnuTFGOutput.Visible = False
                mnuTFGWW.Enabled = True
                mnuTFGWW.Visible = True
                MenuItem19.Enabled = False
                MenuItem19.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                'mrnTMRNBegInventory.Enabled = True
                'mrnTMRNBegInventory.Visible = True
                mnuTMaterialCost.Enabled = False
                mnuTMaterialCost.Visible = False
                mnuTMRNUsage.Enabled = False
                mnuTMRNUsage.Visible = False
                MenuItem22.Enabled = False
                MenuItem22.Visible = False
                mnuTUpdateFishLot.Enabled = False
                mnuTUpdateFishLot.Visible = False
                mnuTUpdateBinStatus.Enabled = False
                mnuTUpdateBinStatus.Visible = False
                mnuTAnalysis.Enabled = False
                mnuTAnalysis.Visible = False

                mnuRLotActivity.Enabled = True
                mnuRLotActivity.Visible = True
                mnuRTotalInventory.Enabled = True
                mnuRTotalInventory.Visible = True
                MenuItem20.Enabled = True
                MenuItem20.Visible = True
                MenuItem18.Enabled = True
                MenuItem18.Visible = True
                MenuItem24.Enabled = True
                MenuItem24.Visible = True
                MenuItem25.Enabled = True
                MenuItem25.Visible = True
                mnuRSpoilages.Enabled = True
                mnuRSpoilages.Visible = True
                mnuRPrepPackingLists.Enabled = True
                mnuRPrepPackingLists.Visible = True
                MenuItem21.Enabled = True
                MenuItem21.Visible = True
                mnuRProductCosting.Enabled = True
                mnuRProductCosting.Visible = True
                mnuRDiscrepancy.Enabled = True
                mnuRDiscrepancy.Visible = True
                MenuItem31.Enabled = False
                MenuItem31.Visible = False
                mnuRRecovery.Enabled = False
                mnuRRecovery.Visible = False

            Case "Report"
                'LOT
                'ToolBarButton1.Enabled = True
                'ToolBarButton1.Visible = True
                'FISH DEPOSIT
                'ToolBarButton2.Enabled = False
                'ToolBarButton2.Visible = False
                ToolBarButton16.Enabled = False
                ToolBarButton16.Visible = False
                'FISH WITHDRAWAL
                ToolBarButton3.Enabled = False
                ToolBarButton3.Visible = False
                'ToolBarButton4.Enabled = True
                'ToolBarButton4.Visible = True
                'ToolBarButton5.Enabled = True
                'ToolBarButton5.Visible = True
                'CATCH CERTIFICATE
                ToolBarButton6.Enabled = False
                ToolBarButton6.Visible = False
                'ToolBarButton7.Enabled = True
                'ToolBarButton7.Visible = True
                'ToolBarButton8.Enabled = True
                'ToolBarButton8.Visible = True
                'PRODUCT CODE
                ToolBarButton9.Enabled = False
                ToolBarButton9.Visible = False
                'PRODUCTION OUTPUT
                ToolBarButton10.Enabled = False
                ToolBarButton10.Visible = False
                'LABELING AND CASE-UP
                ToolBarButton11.Enabled = False
                ToolBarButton11.Visible = False
                'MRN
                ToolBarButton12.Enabled = False
                ToolBarButton12.Visible = False
                'FG WITHDRAWAL
                ToolBarButton13.Enabled = False
                ToolBarButton13.Visible = False
                ToolBarButton14.Enabled = False
                ToolBarButton14.Visible = False
                ToolBarButton15.Enabled = False
                ToolBarButton15.Visible = False

                mnuMCC.Enabled = False
                mnuMCC.Visible = False
                mnuFishLot.Enabled = False
                mnuFishLot.Visible = False
                mnuMFR.Enabled = False
                mnuMFR.Visible = False
                mnuMFishOwner.Enabled = False
                mnuMFishOwner.Visible = False
                mnuMCS.Enabled = False
                mnuMCS.Visible = False
                MenuItem6.Enabled = False
                MenuItem6.Visible = False
                mnuMCOS.Enabled = False
                mnuMCOS.Visible = False
                mnuMCOP.Enabled = False
                mnuMCOP.Visible = False
                MenuItem4.Enabled = False
                MenuItem4.Visible = False
                mnuMFish.Enabled = False
                mnuMFish.Visible = False
                mnuMFishSize.Enabled = False
                mnuMFishSize.Visible = False
                mnuMBin.Enabled = False
                mnuMBin.Visible = False
                MenuItem7.Enabled = False
                MenuItem7.Visible = False
                mnuMFishingVessel.Enabled = False
                mnuMFishingVessel.Visible = False
                mnuMSupplier.Enabled = False
                mnuMSupplier.Visible = False
                mnuMFAO.Enabled = False
                mnuMFAO.Visible = False
                mnuMSection.Enabled = False
                mnuMSection.Visible = False
                mnuMLabel.Enabled = False
                mnuMLabel.Visible = False
                mnuMWarehouse.Enabled = False
                mnuMWarehouse.Visible = False
                mnuDReject.Enabled = False
                mnuDReject.Visible = False
                mnuMFGDefect.Enabled = False
                mnuMFGDefect.Visible = False
                MenuItem8.Enabled = False
                MenuItem8.Visible = False
                MenuItem1.Enabled = False
                MenuItem1.Visible = False
                MenuItem12.Enabled = False
                MenuItem12.Visible = False
                MenuItem2.Enabled = False
                MenuItem2.Visible = False
                MenuItem23.Enabled = False
                MenuItem23.Visible = False
                mnuMBOM.Enabled = False
                mnuMBOM.Visible = False
                mnuTPushBack.Enabled = False
                mnuTPushBack.Visible = False
                MenuItem27.Enabled = False
                MenuItem27.Visible = False
                MenuItem29.Enabled = False
                MenuItem29.Visible = False

                mnuTFishReceipts.Enabled = False
                mnuTFishReceipts.Visible = False
                'mnuTD.Enabled = False
                'mnuTD.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                mnuTDeposit2.Enabled = False
                mnuTDeposit2.Visible = False
                mnuTW.Enabled = False
                mnuTW.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTWithdrawal.Enabled = False
                mnuTWithdrawal.Visible = False
                'mnuTWithdrawal2.Enabled = False
                'mnuTWithdrawal2.Visible = False
                mnuTFishRacking.Enabled = False
                mnuTFishRacking.Visible = False
                mnuTFGShipment.Enabled = False
                mnuTFGShipment.Visible = False
                mnuTFGInvoice.Enabled = False
                mnuTFGInvoice.Visible = False
                mnuTMeatPercent.Enabled = False
                mnuTMeatPercent.Visible = False
                mnuTReject.Enabled = False
                mnuTReject.Visible = False
                'mnuTRejectRound.Enabled = False
                'mnuTRejectRound.Visible = False
                mnuMLoins.Enabled = False
                mnuMLoins.Visible = False
                mnuTQCSample.Enabled = False
                mnuTQCSample.Visible = False
                mnuTQCDispo.Enabled = False
                mnuTQCDispo.Visible = False
                mnuTProduction.Enabled = False
                mnuTProduction.Visible = False
                mnuTLabeling.Enabled = False
                mnuTLabeling.Visible = False
                mnuTFGOutput.Enabled = False
                mnuTFGOutput.Visible = False
                mnuTFGWW.Enabled = False
                mnuTFGWW.Visible = False
                MenuItem19.Enabled = False
                MenuItem19.Visible = False
                mnuTDeposit.Enabled = False
                mnuTDeposit.Visible = False
                'mrnTMRNBegInventory.Enabled = True
                'mrnTMRNBegInventory.Visible = True
                mnuTMaterialCost.Enabled = False
                mnuTMaterialCost.Visible = False
                mnuTMRNUsage.Enabled = False
                mnuTMRNUsage.Visible = False
                MenuItem22.Enabled = False
                MenuItem22.Visible = False
                mnuTUpdateFishLot.Enabled = False
                mnuTUpdateFishLot.Visible = False
                mnuTUpdateBinStatus.Enabled = False
                mnuTUpdateBinStatus.Visible = False
                mnuTAnalysis.Enabled = False
                mnuTAnalysis.Visible = False

                mnuRLotActivity.Enabled = True
                mnuRLotActivity.Visible = True
                mnuRTotalInventory.Enabled = True
                mnuRTotalInventory.Visible = True
                MenuItem20.Enabled = True
                MenuItem20.Visible = True
                MenuItem18.Enabled = True
                MenuItem18.Visible = True
                MenuItem24.Enabled = True
                MenuItem24.Visible = True
                MenuItem25.Enabled = True
                MenuItem25.Visible = True
                mnuRSpoilages.Enabled = True
                mnuRSpoilages.Visible = True
                mnuRPrepPackingLists.Enabled = True
                mnuRPrepPackingLists.Visible = True
                MenuItem21.Enabled = True
                MenuItem21.Visible = True
                mnuRProductCosting.Enabled = True
                mnuRProductCosting.Visible = True
                mnuRDiscrepancy.Enabled = True
                mnuRDiscrepancy.Visible = True
                MenuItem31.Enabled = True
                MenuItem31.Visible = True
                mnuRRecovery.Enabled = True
                mnuRRecovery.Visible = True

            Case "System Administrator"
                'LOT
                'ToolBarButton1.Enabled = True
                'ToolBarButton1.Visible = True
                'FISH DEPOSIT
                'ToolBarButton2.Enabled = True
                'ToolBarButton2.Visible = True
                ToolBarButton16.Enabled = True
                ToolBarButton16.Visible = True
                'FISH WITHDRAWAL
                ToolBarButton3.Enabled = True
                ToolBarButton3.Visible = True
                'ToolBarButton4.Enabled = True
                'ToolBarButton4.Visible = True
                'ToolBarButton5.Enabled = True
                'ToolBarButton5.Visible = True
                'CATCH CERTIFICATE
                ToolBarButton6.Enabled = True
                ToolBarButton6.Visible = True
                'ToolBarButton7.Enabled = True
                'ToolBarButton7.Visible = True
                'ToolBarButton8.Enabled = True
                'ToolBarButton8.Visible = True
                'PRODUCT CODE
                ToolBarButton9.Enabled = True
                ToolBarButton9.Visible = True
                'PRODUCTION OUTPUT
                ToolBarButton10.Enabled = True
                ToolBarButton10.Visible = True
                'LABELING AND CASE-UP
                ToolBarButton11.Enabled = True
                ToolBarButton11.Visible = True
                'MRN
                ToolBarButton12.Enabled = False
                ToolBarButton12.Visible = False
                'FG WITHDRAWAL
                ToolBarButton13.Enabled = True
                ToolBarButton13.Visible = True
                ToolBarButton14.Enabled = True
                ToolBarButton14.Visible = True
                ToolBarButton15.Enabled = True
                ToolBarButton15.Visible = True

                mnuMCC.Enabled = True
                mnuMCC.Visible = True
                mnuFishLot.Enabled = True
                mnuFishLot.Visible = True
                mnuMFR.Enabled = True
                mnuMFR.Visible = True
                mnuMFishOwner.Enabled = True
                mnuMFishOwner.Visible = True
                mnuMCS.Enabled = True
                mnuMCS.Visible = True
                MenuItem6.Enabled = True
                MenuItem6.Visible = True
                mnuMCOS.Enabled = True
                mnuMCOS.Visible = True
                mnuMCOP.Enabled = True
                mnuMCOP.Visible = True
                MenuItem4.Enabled = True
                MenuItem4.Visible = True
                mnuMFish.Enabled = True
                mnuMFish.Visible = True
                mnuMFishSize.Enabled = True
                mnuMFishSize.Visible = True
                mnuMBin.Enabled = True
                mnuMBin.Visible = True
                MenuItem7.Enabled = True
                MenuItem7.Visible = True
                mnuMFishingVessel.Enabled = True
                mnuMFishingVessel.Visible = True
                mnuMSupplier.Enabled = True
                mnuMSupplier.Visible = True
                mnuMFAO.Enabled = True
                mnuMFAO.Visible = True
                mnuMSection.Enabled = True
                mnuMSection.Visible = True
                mnuMLabel.Enabled = True
                mnuMLabel.Visible = True
                mnuMWarehouse.Enabled = True
                mnuMWarehouse.Visible = True
                mnuDReject.Enabled = True
                mnuDReject.Visible = True
                mnuMFGDefect.Enabled = True
                mnuMFGDefect.Visible = True
                MenuItem8.Enabled = True
                MenuItem8.Visible = True
                MenuItem1.Enabled = True
                MenuItem1.Visible = True
                MenuItem12.Enabled = True
                MenuItem12.Visible = True
                MenuItem2.Enabled = True
                MenuItem2.Visible = True
                MenuItem23.Enabled = True
                MenuItem23.Visible = True
                mnuMBOM.Enabled = True
                mnuMBOM.Visible = True
                mnuTPushBack.Enabled = True
                mnuTPushBack.Visible = True
                MenuItem27.Enabled = True
                MenuItem27.Visible = True
                MenuItem29.Enabled = True
                MenuItem29.Visible = True

                mnuTCSMap.Enabled = True
                mnuTCSMap.Visible = True
                mnuTFishReceipts.Enabled = True
                mnuTFishReceipts.Visible = True
                'mnuTD.Enabled = True
                'mnuTD.Visible = True
                mnuTDeposit.Enabled = True
                mnuTDeposit.Visible = True
                mnuTDeposit2.Enabled = False
                mnuTDeposit2.Visible = False
                mnuTW.Enabled = True
                mnuTW.Visible = True
                mnuTCalibration.Enabled = True
                mnuTCalibration.Visible = True
                'mnuTRejectRound.Enabled = True
                'mnuTRejectRound.Enabled = True
                mnuTFishRacking.Enabled = True
                mnuTFishRacking.Visible = True
                mnuTWithdrawal.Enabled = True
                mnuTWithdrawal.Visible = True
                'mnuTWithdrawal2.Enabled = True
                'mnuTWithdrawal2.Visible = True
                mnuTFishRacking.Enabled = True
                mnuTFishRacking.Visible = True
                mnuTFGShipment.Enabled = True
                mnuTFGShipment.Visible = True
                mnuTFGInvoice.Enabled = True
                mnuTFGInvoice.Visible = True
                mnuTMeatPercent.Enabled = True
                mnuTMeatPercent.Visible = True
                mnuTReject.Enabled = True
                mnuTReject.Visible = True
                'mnuTRejectRound.Enabled = True
                'mnuTRejectRound.Visible = True
                mnuMLoins.Enabled = True
                mnuMLoins.Visible = True
                mnuTQCSample.Enabled = False
                mnuTQCSample.Visible = False
                mnuTQCDispo.Enabled = False
                mnuTQCDispo.Visible = False
                mnuTProduction.Enabled = True
                mnuTProduction.Visible = True
                mnuTLabeling.Enabled = True
                mnuTLabeling.Visible = True
                mnuTFGOutput.Enabled = True
                mnuTFGOutput.Visible = True
                mnuTFGWW.Enabled = True
                mnuTFGWW.Visible = True
                MenuItem19.Enabled = True
                MenuItem19.Visible = True
                mnuTDeposit.Enabled = True
                mnuTDeposit.Visible = True
                'mrnTMRNBegInventory.Enabled = True
                'mrnTMRNBegInventory.Visible = True
                mnuTMaterialCost.Enabled = True
                mnuTMaterialCost.Visible = True
                mnuTMRNUsage.Enabled = True
                mnuTMRNUsage.Visible = True
                MenuItem22.Enabled = True
                MenuItem22.Visible = True
                mnuTUpdateFishLot.Enabled = True
                mnuTUpdateFishLot.Visible = True
                mnuTUpdateBinStatus.Enabled = True
                mnuTUpdateBinStatus.Visible = True
                mnuTAnalysis.Enabled = True
                mnuTAnalysis.Visible = True

                mnuRLotActivity.Enabled = True
                mnuRLotActivity.Visible = True
                mnuRTotalInventory.Enabled = True
                mnuRTotalInventory.Visible = True
                MenuItem20.Enabled = True
                MenuItem20.Visible = True
                MenuItem18.Enabled = True
                MenuItem18.Visible = True
                MenuItem24.Enabled = True
                MenuItem24.Visible = True
                MenuItem25.Enabled = True
                MenuItem25.Visible = True
                mnuRSpoilages.Enabled = True
                mnuRSpoilages.Visible = True
                mnuRPrepPackingLists.Enabled = True
                mnuRPrepPackingLists.Visible = True
                MenuItem21.Enabled = True
                MenuItem21.Visible = True
                mnuRProductCosting.Enabled = True
                mnuRProductCosting.Visible = True
                mnuRDiscrepancy.Enabled = True
                mnuRDiscrepancy.Visible = True
                MenuItem31.Enabled = True
                MenuItem31.Visible = True
                mnuRRecovery.Enabled = True
                mnuRRecovery.Visible = True
            Case Else
                MsgBox("You have no permission to use this system" & Chr(13) & Chr(13) & _
                    "For inquiries, please contact your system administrator at egudez@trimarinegroup.com", MsgBoxStyle.Critical, "Result: Trespassing")

                'Call mnuLockPC_Click(Me, New EventArgs())
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim l As String = pnl2.Text.Substring(0, 1)
        pnl2.Text = pnl2.Text.Substring(1, pnl2.Text.Length - 1) & l
    End Sub

    Public Function validateUsername(ByVal user As String) As Boolean
        If user = "System Administrator" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub mnuItemAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemAbout.Click
        Dim f As New frmAbout()
        f.ShowDialog(Me)
    End Sub

    Public Sub shortcutToFishLot()
        Dim f As New frmBatchlot()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        shortcutToFishLot()
    End Sub

    Private Sub mnuMFish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFish.Click
        Dim f As New frmSpecie2()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMBin.Click
        Dim f As New frmFishBin()
        f.MdiParent = Me
        f.Show()
    End Sub

    Public Sub shortcutToFishDeposit()
        Dim f As New frmFishDeposit_DataEntry3
        f.MdiParent = Me
        f.Show()

        'Dim f As New frmFishDeposit_DataEntry2
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuTDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTDeposit.Click
        shortcutToFishDeposit()
    End Sub

    Private Sub mnuTWithdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTWithdrawal.Click
        shortcutToFishWithdrawal()
    End Sub

    Public Sub shortcutToFishWithdrawal()
        Dim f As New frmFishWithdrawal_DataEntry2
        f.MdiParent = Me
        f.Show()
        'Dim f As New frmFishWithdrawal()
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuTReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTReject.Click
        shortcutToFishReject()
    End Sub

    Public Sub shortcutToFishReject()
        Dim f As New frmSpoilage
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMLoins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMLoins.Click
        shortcutToLoins()
    End Sub

    Public Sub shortcutToLoins()
        Dim f As New frmMeatRecovery
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMCC.Click
        shortcutToCC()
    End Sub

    Public Sub shortcutToCC()
        Dim f As New frmSICC_DataEntry2
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMFishingVessel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFishingVessel.Click
        Dim f As New frmFishingVessel
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMSupplier.Click
        Dim f As New frmFishSupplier
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMFAO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFAO.Click
        Dim f As New frmFAO
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMSection.Click
        Dim f As New frmSection
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuDReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDReject.Click
        Dim f As New frmDefects
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTUpdateFishLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTUpdateFishLot.Click
        Dim f As New frmUpdateFishLot
        f.MdiParent = Me
        f.Show()
    End Sub

    Public Sub shortcutToCOS()
        Dim f As New frmCOS
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMFishSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFishSize.Click
        Dim f As New frmFishSize
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTUpdateBinStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTUpdateBinStatus.Click
        Dim f As New frmUpdateFishBin_Deposit
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMCOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMCOS.Click
        shortcutToCOS()
    End Sub

    Private Sub mnuMCOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMCOP.Click
        shortcutToCOP()
    End Sub

    Public Sub shortcutToCOP()
        Dim f As New frmCOP
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMProductDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMProductDescription.Click
        Dim f As New frmProductDescription
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProdPackStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdPackStyle.Click
        Dim f As New frmProdPackStyle
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProdMedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdMedia.Click
        Dim f As New frmProdMedia
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProdFillerLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdFillerLine.Click
        Dim f As New frmProdFillerLine
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProdCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdCleaning.Click
        Dim f As New frmProdCleaning
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProdSpecie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdSpecie.Click
        Dim f As New frmProdSpecie
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProdCanSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdCanSize.Click
        Dim f As New frmProdCanSize
        f.Label1.Text = "Can Size"
        f.Label2.Text = "Can Size"
        f.displayCategory()
        f.cboCategory.Text = "Canned Tuna"
        f.displayCanSize(f.cboCategory.Text)
        f.displayAllCanSize(f.cboCategory.Text)
        f.cboCategory.Enabled = False
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProduct.Click
        shortcutToProductCode()
    End Sub

    Public Sub shortcutToProductCode()
        Dim f As New frmProduct
        f.MdiParent = Me
        f.Show()
    End Sub

    Public Sub shortcutToProduction()
        Dim f As New frmProduction
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTProduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTProduction.Click
        shortcutToProduction()
    End Sub

    Private Sub mnuProdPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdPeriod.Click
        Dim f As New frmProdPeriod
        f.MdiParent = Me
        f.Show()
    End Sub

    Public Sub shortcutToLabeling()
        Dim f As New frmLabeling_DataEntry2  'frmLabeling_DataEntry  'frmLabelling
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTLabeling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTLabeling.Click
        shortcutToLabeling()
    End Sub

    Public Sub shortcutToMRN()
        Dim f As New frmMRN
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMMRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMMRN.Click
        shortcutToMRN()
    End Sub

    Private Sub mnuMMRN_Materials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMMRN_Materials.Click
        Dim f As New frmMRN_Materials
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMMRN_Manufacturer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMMRN_Manufacturer.Click
        Dim f As New frmMRN_Manufacturer
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMMRNSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMMRNSupplier.Click
        Dim f As New frmMRN_Supplier
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMWarehouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMWarehouse.Click
        Dim f As New frmWarehouse
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMLabel.Click
        Dim f As New frmLabels
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProdLoinSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdLoinSize.Click
        Dim f As New frmProdLoinSize
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuProdFishSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdFishSize.Click
        Dim f As New frmProdCanSize
        f.Label1.Text = "Fish Size"
        f.Label2.Text = "Fish Size"
        f.displayCategory()
        f.cboCategory.Text = "Frozen Loins"
        f.displayCanSize(f.cboCategory.Text)
        f.displayAllCanSize(f.cboCategory.Text)
        f.cboCategory.Enabled = False
        f.MdiParent = Me
        f.Show()
    End Sub

    Public Sub shortcutToFGWW()
        Dim f As New frmFGWW_DataEntry  'frmFGWW
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTFGWW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTFGWW.Click
        shortcutToFGWW()
    End Sub

    Private Sub mnuRTotalInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRTotalInventory.Click

    End Sub

    Private Sub mnuRTotalInventory_Room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRTotalInventory_Room.Click
        'Dim f As New frmPrintInventory_Total_perRoom
        'f.Label1.Text = "Print Total Inventory Report By Room"
        'f.grp.Visible = True
        'f.grp.Enabled = True
        'f.displayColdStorage()
        'f.cboCS.SelectedIndex = 0
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuRTotalInventory_TypeOfSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRTotalInventory_TypeOfSet.Click
        Dim f As New frmPrintInventory_TypeOfSet
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRLotActivity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRLotActivity.Click
        'Dim f As New frmPrintLotActivity
        'f.Label1.Text = "Lot Movement Report"
        'f.typeOfReport = "lotMovement"
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuRFWRD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFWRD.Click
        Dim f As New frmPrintFWR
        f.Label1.Text = "Print Daily Cold Storage Fish Bin Withdrawal Report"
        f.daily = True
        f.lot = False
        f.specie = False
        f.weekly = False
        f.dailyLoin = False
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRFWRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFWRL.Click

    End Sub

    Private Sub mnuRFWRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFWRS.Click
        'Dim f As New frmPrintFWR
        'f.Label1.Text = "Print Cannery Acceptance Summary by Specie Report"
        'f.daily = False
        'f.lot = False
        'f.specie = True
        'f.weekly = False
        'f.dailyLoin = False
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuTQCSample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTQCSample.Click
        Dim f As New frmQCSample
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTQCDispo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTQCDispo.Click
        Dim f As New frmQCDisposition
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRSumVoyLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRSumVoyLot.Click
        Dim f As New frmPrintSummaryOfDepositsPerVoyage
        f.Label1.Text = "Print Round Fish Receipts Summary"
        f.summary = True
        f.perSublot = False
        f.rptInventory.ShowPrintButton = False
        f.ShowDialog(Me)
    End Sub

    Private Sub mnuTMRNUsage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTMRNUsage.Click
        Dim f As New frmMRN_Usage_DataEntry
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRProductCosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRProductCosting.Click
        Dim f As New frmProductCosting
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMBOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMBOM.Click
        Dim f As New frmBOM
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTPushBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTPushBack.Click
        Dim f As New frmPushBack
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTDeposit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTDeposit2.Click
        Dim f As New frmFishDeposit_Loin_Bags
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTWithdrawal2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTWithdrawal2.Click
        Dim f As New frmBagsWithdrawal
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRDiscrepancy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRDiscrepancy.Click
        Dim f As New frmPrintProductionOutputDiscrepancy
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mrnTMRNBegInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mrnTMRNBegInventory.Click
        Dim f As New frmMRN_BegInventory
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRFWSDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFWSDate.Click
        'Dim f As New frmPrintFWS
        'f.cboFWS.ReadOnly = True
        'f.ShowDialog(Me)
    End Sub

    Private Sub mnuRLotDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRLotDetails.Click
        Dim f As New frmPrintLotActivity
        f.Label1.Text = "Trip Code Fish Bin Details"
        f.typeOfReport = "lotDetails"
        f.displayLot()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRLCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRLCA.Click
        'Dim f As New frmPrintLotActivity
        'f.Label1.Text = "Detailed Cannery Acceptance of Fish Lot"
        'f.typeOfReport = "lotCA"
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuRCAPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCAPD.Click
        'Dim f As New frmPrintFWR
        'f.Label1.Text = "Print Cannery Acceptance Summary Report"
        'f.weekly = True
        'f.daily = False
        'f.lot = False
        'f.specie = False
        'f.dailyLoin = False
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuRLoinInvPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRLoinInvPD.Click
        'Dim f As New frmPrintFWR
        'f.Label1.Text = "Print Daily Loining Inventory Report"
        'f.dailyLoin = True
        'f.daily = False
        'f.lot = False
        'f.specie = False
        'f.weekly = False
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuRLoinInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRLoinInventory.Click
        'Dim f As New frmPrintInventory_Total_perRoom
        'f.Label1.Text = "Print Frozen Loins Inventory Report"
        'f.roundFish = False
        'f.loin = True
        'f.Label10.Visible = False
        'f.cboCS.Visible = False
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuTFGOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTFGOutput.Click
        Dim f As New frmFGOutput
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMFGDefect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFGDefect.Click
        Dim f As New frmFGDefects
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRSpoilages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRSpoilages.Click

    End Sub

    Private Sub mnuTMaterialCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTMaterialCost.Click
        Dim f As New frmMaterialCost
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTUtilityExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTUtilityExp.Click
        Dim f As New frmProductCosting_UtilityExpenses
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRFishDepositPerCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFishDepositPerCS.Click
        'Dim f As New frmPrintLotActivity
        'f.Label1.Text = "Fish Deposit Inventory per Cold Storage"
        'f.typeOfReport = "lotDetailsPerCS"
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuTLaborRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTLaborRate.Click
        Dim f As New frmProductCosting_LaborRate
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRCA_Overiew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCA_Overiew.Click
        Dim f As New frmPrintFWR
        f.Label1.Text = "Print Cold Storage Withdrawal Summary Report"
        f.daily = False
        f.lot = True
        f.specie = False
        f.weekly = False
        f.dailyLoin = False
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRCA_PushBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCA_PushBack.Click
        Dim accessCode As String = InputBox("Please enter access code:", "Access Code")
        If accessCode = "zedug" Then
            'Dim f As New frmPrintFWR
            'f.Label1.Text = "Print Push Back Cannery Acceptance Summary Report"
            'f.daily = False
            'f.lot = False
            'f.specie = False
            'f.weekly = False
            'f.dailyLoin = False
            'f.pushBack = True
            'f.MdiParent = Me
            'f.Show()
        End If
    End Sub

    Private Sub mnuRCA_Bags_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCA_Bags.Click
        Dim accessCode As String = InputBox("Please enter access code:", "Access Code")
        If accessCode = "zedug" Then
            'Dim f As New frmPrintFWR
            'f.Label1.Text = "Print Flakes Bag Cannery Acceptance Summary Report"
            'f.daily = False
            'f.lot = False
            'f.specie = False
            'f.weekly = False
            'f.dailyLoin = False
            'f.pushBack = False
            'f.flakesBag = True
            'f.MdiParent = Me
            'f.Show()
        End If
    End Sub

    Private Sub mnuRCA_Fish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCA_Fish.Click
        Dim accessCode As String = InputBox("Please enter access code:", "Access Code")
        If accessCode = "zedug" Then
            'Dim f As New frmPrintFWR
            'f.Label1.Text = "Print Round Fish Cannery Acceptance Summary Report"
            'f.daily = False
            'f.lot = False
            'f.specie = False
            'f.weekly = False
            'f.dailyLoin = False
            'f.pushBack = False
            'f.flakesBag = False
            'f.roundFish = True
            'f.MdiParent = Me
            'f.Show()
        End If
    End Sub

    Private Sub mnuRSumVoySublot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRSumVoySublot.Click
        Dim f As New frmPrintSummaryOfDepositsPerVoyage
        f.Label1.Text = "Print Round Fish Receipts per Sublot Summary"
        f.summary = False
        f.perSublot = True
        f.ShowDialog(Me)
    End Sub

    Private Sub mnuTFishDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTFishDeposit.Click
        Dim f As New frmFishDeposit_DataEntry3
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRMRFAA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRMRFAA.Click
        Dim f As New frmPrintTotalRoundFishWithAmount
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTOH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTOH.Click
        Dim f As New frmProductCosting_OH
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRRecovery.Click
        Dim f As New frmInqProductRecovery
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRSpoilages_Daily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRSpoilages_Daily.Click
        Dim f As New frmPrintFishSpoilages
        f.txtProdnDate.Value = getServerDateTime()
        f.initializeShift()
        'f.cboShift.Text = cboShift.Text
        f.ShowDialog(Me)
    End Sub

    Private Sub mnuRSpoilages_Lot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRSpoilages_Lot.Click
        Dim f As New frmPrintFishSpoilages_byLotNo
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRPrepPackingLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRPrepPackingLists.Click
        Dim f As New frmPreparePackingLists
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTFGShipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTFGShipment.Click
        shortcutToFGShipments()
    End Sub

    Public Sub shortcutToFGShipments()
        Dim f As New frmFGShipment
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTFGInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTFGInvoice.Click
        shortcuttoFGInvoice()
    End Sub

    Public Sub shortcuttoFGInvoice()
        Dim f As New frmFGInvoice
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim f As New frmPrintCommercialInvoice
        'f.displayReport("")
        'f.ShowDialog(Me)
    End Sub

    Private Sub mnuTFishRacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTFishRacking.Click
        Dim f As New frmFishRacking
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRFZInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFZInventory.Click

    End Sub

    Private Sub mnuTRFA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTRFA.Click
        Dim f As New frmAnalysis_Raw_Listings 'frmAnalysis_Raw_DataEntry 'frmAnalysis_RF
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTFGA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTFGA.Click
        Dim f As New frmAnalysis_FG_DataEntry  'frmAnalysis_FG_Listings  'frmAnalysis_FG
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click

    End Sub

    Private Sub mnuRInventoryAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRInventoryAL.Click
        'Dim f As New frmPrintInventory_Total_perRoom
        'f.Label1.Text = "Print Round Fish Inventory Report"
        'f.roundFishAL = 1
        'f.roundFish = True
        'f.loin = False
        'f.Label10.Visible = False
        'f.cboCS.Visible = False
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuRInventoryOthers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRInventoryOthers.Click
        Dim f As New frmPrintInventory_Total_perRoom
        f.Label1.Text = "Print Round Fish Inventory Report"
        f.roundFishAL = 0
        f.roundFish = True
        f.loin = False
        f.Label10.Visible = False
        f.cboCS.Visible = False
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuPrintFZO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintFZO.Click
        'Dim f As New frmPrintFZInventory
        'f.displayReport("NO")
        'f.ShowDialog(Me)
    End Sub

    Private Sub mnuPrintFZA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintFZA.Click
        'Dim f As New frmPrintFZInventory
        'f.displayReport("YES")
        'f.ShowDialog(Me)
    End Sub

    Private Sub mnuRTotalReceipts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRTotalReceipts.Click
        Dim f As New frmPrintTotalReceipts
        f.ShowDialog(Me)
    End Sub

    Private Sub mnuRFZTotalAl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFZTotalAl.Click
        'Dim f As New frmPrintFZOutput
        'f.isAlbacore = "YES"
        'f.ShowDialog(Me)
    End Sub

    Private Sub mnuRFZTotalOthers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFZTotalOthers.Click
        'Dim f As New frmPrintFZOutput
        'f.isAlbacore = "NO"
        'f.ShowDialog(Me)
    End Sub

    Private Sub mnuTWithdrawal3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTWithdrawal3.Click
        Dim f As New frmFishWithdrawal_Bags
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRFGOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFGOutput.Click
        Dim f As New frmPrintFGOutput_Seamer
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTMeatPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTMeatPercent.Click
        Dim f As New frmMeatPercentage
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRFZContainers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFZContainers.Click
        'Dim f As New frmPrintFZInventory
        'f.displayReportInContainer()
        'f.ShowDialog(Me)
    End Sub

    Private Sub mnuRSpoilages_Range_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRSpoilages_Range.Click
        'Dim f As New frmPrintFishSpoilagesWeekly
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuRInventoryByCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRInventoryByCS.Click
        Dim f As New frmPrintFZInventory
        f.Label1.Text = "Print Round Fish Inventory by Cold Storage"
        f.displayReportRoundFishInventoryByCS()
        f.ShowDialog(Me)
    End Sub

    Private Sub mnuRDailyLabeling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRDailyLabeling.Click
        'Dim f As New frmPrintLabeling
        'f.txtDate.Value = getServerDateTime()
        'f.initializeShift()
        'f.ShowDialog(Me)
    End Sub

    Private Sub mnuRFishExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFishExport.Click
        'Dim f As New frmPrintRoundFishExport
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub mnuTRejectRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuFishLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFishLot.Click
        Dim f As New frmFishLot
        f.displayFishingVessel()
        If f.cboVessel.ListCount > 0 Then f.cboVessel.SelectedIndex = 0
        f.displayLotDetails(f.lblLot.Text)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMFR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFR.Click
        Dim f As New frmFishReceipts
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMFishOwner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFishOwner.Click
        Dim f As New frmFishOwner
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMCS.Click
        Dim f As New frmColdStorage
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTCSMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTCSMap.Click
        Dim f As New frmColdStorage_Map
        f.cmdSelect.Enabled = False
        f.displayColdStorage()
        f.displayColdStorageLane(f.cboRm.Text)
        f.displayColdStorageRow(f.cboRm.Text, f.cboLane.Text)
        f.MdiParent = Me
        f.Show()
    End Sub

    Public Sub shortcutToFR()
        Dim f As New frmFishReceiptsReceiving
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuIBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIBin.Click
        Dim f As New frmBinHistory
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRCSMetrics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCSMetrics.Click
        Dim f As New frmPrintColdStorageMetrics
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTCalibration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTCalibration.Click
        Dim f As New frmCalibration
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuTProdSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTProdSched.Click
        Dim f As New frmProductionScheduleListing
        f.MdiParent = Me
        f.Show()
    End Sub

    'Private Sub mnuTFR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    shortcutToFR()
    'End Sub

    'Private Sub mnuTRVR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim f As New frmSpoilage_Rounds
    '    f.MdiParent = Me
    '    f.Show()
    'End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        shortcutToFR()
    End Sub

    Private Sub MenuItem32_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim f As New frmSpoilage_Rounds
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRRounds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRRounds.Click
        Dim f As New frmPrintInventory_Total_perRoom
        f.Label1.Text = "Print Round Fish Inventory Report"
        f.roundFishAL = 2
        f.roundFish = True
        f.loin = False
        f.Label10.Visible = False
        f.cboCS.Visible = False
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRFRDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRFRDetails.Click
        Dim f As New frmPrintLotActivity
        f.Label1.Text = "Fish Receipt Fish Bin Details"
        f.typeOfReport = "rr"
        f.Label10.Text = "Receipt No."
        f.displayRR()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRBinInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRBinInventory.Click
        Dim f As New frmPrintLotActivity
        f.Label1.Text = "Print Fish Bin Inventory by Trip Code"
        f.displayLot()
        f.typeOfReport = "binsBySublot"
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim f As New frmPrintProductionOutputDetails
        'f.Label13.Text = "Print Canned Tuna Production Output Details"
        'f.fz = False
        f.txtDate.Value = getServerDateTime()
        f.initializeShift()
        f.ShowDialog(Me)
    End Sub

    Private Sub mnuIPalletDist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIPalletDist.Click
        Dim f As New frmInqPalletAllocation
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuIProdTrace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIProdTrace.Click
        Dim f As New frmInqProductTraceability
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuIFishBinSettlement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIFishBinSettlement.Click
        Dim f As New frmInqFishBinSettlement
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRCSTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCSTrans.Click
        Dim f As New frmSTP_FishInventory
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuRRoundsLight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRRoundsLight.Click
        Dim f As New frmPrintInventory_Total_perRoom
        f.Label1.Text = "Print Round Fish Inventory Report"
        f.roundFishAL = 1
        f.roundFish = True
        f.loin = False
        f.Label10.Visible = False
        f.cboCS.Visible = False
        f.MdiParent = Me
        f.Show()
    End Sub
End Class

