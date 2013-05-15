using Ribbon=C1.Win.C1Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace TMG.WinForms
{
    public partial class frmMainMenu : Form, IfrmMainMenu
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        #region FormEvents
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            CreateRawFishTab();
            CreateColdStorageTab();
        }
        #endregion
        #region PrivateMethods
        private void CreateRawFishTab()
        {
            this.c1Ribbon1.Tabs.Clear();
            Ribbon.RibbonTab homeTab = new Ribbon.RibbonTab("Raw Fish");
            Ribbon.RibbonGroup clipboardGroup = new Ribbon.RibbonGroup("Supply");
            Ribbon.RibbonButton pasteButton = new Ribbon.RibbonButton("New Trip", null, Properties.Resources.paste);
            pasteButton.TextImageRelation = Ribbon.TextImageRelation.ImageAboveText;

            Ribbon.RibbonButton ownerButton = new Ribbon.RibbonButton("Owners", null, Properties.Resources.paste);
            ownerButton.TextImageRelation = Ribbon.TextImageRelation.ImageAboveText;


            Ribbon.RibbonMenu vesselButton = new Ribbon.RibbonMenu();
            vesselButton.Text = "Vessels";
            vesselButton.Name = "Vessels";
            vesselButton.LargeImage = Properties.Resources.paste;           
            vesselButton.Items.Add("US Vessel");
            vesselButton.Items.Add("California Vessel");
            vesselButton.TextImageRelation = Ribbon.TextImageRelation.Automatic;

            clipboardGroup.Items.Add(pasteButton);
            clipboardGroup.Items.Add(ownerButton);
            clipboardGroup.Items.Add(vesselButton);
            homeTab.Groups.Add(clipboardGroup);

            Ribbon.RibbonGroup receiptGroup = new Ribbon.RibbonGroup("Receipts");
            Ribbon.RibbonButton receiptButton = new Ribbon.RibbonButton("New Receipt", null);
            receiptButton.TextImageRelation = Ribbon.TextImageRelation.ImageAboveText;
            receiptGroup.Items.Add(receiptButton);
            homeTab.Groups.Add(receiptGroup);


            this.c1Ribbon1.Tabs.Add(homeTab);
        }
        private void CreateColdStorageTab()
        {
            //this.c1Ribbon1.Tabs.Clear();
            Ribbon.RibbonTab homeTab = new Ribbon.RibbonTab("ColdStore");
            Ribbon.RibbonGroup clipboardGroup = new Ribbon.RibbonGroup("Supply");
            Ribbon.RibbonButton pasteButton = new Ribbon.RibbonButton("New Trip Code", null);
            pasteButton.TextImageRelation = Ribbon.TextImageRelation.ImageAboveText;
            clipboardGroup.Items.Add(pasteButton);
            homeTab.Groups.Add(clipboardGroup);
            this.c1Ribbon1.Tabs.Add(homeTab);
        }
        #endregion
    }
}
