using Pos.UI;

namespace Pos_v1
{
   partial class PosMainWindow
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosMainWindow));
          this.mainWindowMenu = new System.Windows.Forms.MenuStrip();
          this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
          this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.showReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.showInventoryButton = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
          this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.discontinueProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
          this.returnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.newShipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.aboutPointOfSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
          this.tabControl = new System.Windows.Forms.TabControl();
          this.saleTab = new System.Windows.Forms.TabPage();
          this.standardToolStrip = new System.Windows.Forms.ToolStrip();
          this.addItemButton = new System.Windows.Forms.ToolStripButton();
          this.removeItemButton = new System.Windows.Forms.ToolStripButton();
          this.mainWindowMenu.SuspendLayout();
          this.toolStripContainer1.ContentPanel.SuspendLayout();
          this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
          this.toolStripContainer1.SuspendLayout();
          this.tabControl.SuspendLayout();
          this.standardToolStrip.SuspendLayout();
          this.SuspendLayout();
          // 
          // mainWindowMenu
          // 
          this.mainWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.reportsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.helpToolStripMenuItem});
          this.mainWindowMenu.Location = new System.Drawing.Point(0, 0);
          this.mainWindowMenu.Name = "mainWindowMenu";
          this.mainWindowMenu.Size = new System.Drawing.Size(758, 24);
          this.mainWindowMenu.TabIndex = 0;
          this.mainWindowMenu.Text = "menuStrip1";
          // 
          // toolStripMenuItem1
          // 
          this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
          this.toolStripMenuItem1.Name = "toolStripMenuItem1";
          this.toolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
          this.toolStripMenuItem1.Text = "File";
          // 
          // newToolStripMenuItem
          // 
          this.newToolStripMenuItem.Name = "newToolStripMenuItem";
          this.newToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
          this.newToolStripMenuItem.Text = "New Sale";
          this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
          // 
          // toolStripSeparator1
          // 
          this.toolStripSeparator1.Name = "toolStripSeparator1";
          this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
          // 
          // exitToolStripMenuItem
          // 
          this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
          this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
          this.exitToolStripMenuItem.Text = "Exit";
          this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
          // 
          // reportsToolStripMenuItem
          // 
          this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showReportToolStripMenuItem});
          this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
          this.reportsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
          this.reportsToolStripMenuItem.Text = "Report";
          // 
          // showReportToolStripMenuItem
          // 
          this.showReportToolStripMenuItem.CheckOnClick = true;
          this.showReportToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
          this.showReportToolStripMenuItem.Name = "showReportToolStripMenuItem";
          this.showReportToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
          this.showReportToolStripMenuItem.Text = "Show Report";
          this.showReportToolStripMenuItem.Click += new System.EventHandler(this.showReportToolStripMenuItem_Click);
          // 
          // inventoryToolStripMenuItem
          // 
          this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInventoryButton,
            this.toolStripSeparator3,
            this.addNewProductToolStripMenuItem,
            this.discontinueProductToolStripMenuItem,
            this.toolStripSeparator2,
            this.returnMenuItem,
            this.newShipmentToolStripMenuItem});
          this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
          this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
          this.inventoryToolStripMenuItem.Text = "Inventory";
          // 
          // showInventoryButton
          // 
          this.showInventoryButton.CheckOnClick = true;
          this.showInventoryButton.Name = "showInventoryButton";
          this.showInventoryButton.Size = new System.Drawing.Size(180, 22);
          this.showInventoryButton.Text = "Show Inventory";
          this.showInventoryButton.Click += new System.EventHandler(this.showInventoryButton_Click);
          // 
          // toolStripSeparator3
          // 
          this.toolStripSeparator3.Name = "toolStripSeparator3";
          this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
          // 
          // addNewProductToolStripMenuItem
          // 
          this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
          this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
          this.addNewProductToolStripMenuItem.Text = "Add New Product";
          this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
          // 
          // discontinueProductToolStripMenuItem
          // 
          this.discontinueProductToolStripMenuItem.Name = "discontinueProductToolStripMenuItem";
          this.discontinueProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
          this.discontinueProductToolStripMenuItem.Text = "Discontinue Product";
          this.discontinueProductToolStripMenuItem.Click += new System.EventHandler(this.discontinueProductToolStripMenuItem_Click);
          // 
          // toolStripSeparator2
          // 
          this.toolStripSeparator2.Name = "toolStripSeparator2";
          this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
          // 
          // returnMenuItem
          // 
          this.returnMenuItem.Name = "returnMenuItem";
          this.returnMenuItem.Size = new System.Drawing.Size(180, 22);
          this.returnMenuItem.Text = "New Return";
          this.returnMenuItem.Click += new System.EventHandler(this.returnMenuItem_Click);
          // 
          // newShipmentToolStripMenuItem
          // 
          this.newShipmentToolStripMenuItem.Name = "newShipmentToolStripMenuItem";
          this.newShipmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
          this.newShipmentToolStripMenuItem.Text = "New Shipment";
          this.newShipmentToolStripMenuItem.Click += new System.EventHandler(this.newShipmentToolStripMenuItem_Click);
          // 
          // helpToolStripMenuItem
          // 
          this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPointOfSalesToolStripMenuItem});
          this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
          this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
          this.helpToolStripMenuItem.Text = "Help";
          // 
          // aboutPointOfSalesToolStripMenuItem
          // 
          this.aboutPointOfSalesToolStripMenuItem.Name = "aboutPointOfSalesToolStripMenuItem";
          this.aboutPointOfSalesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
          this.aboutPointOfSalesToolStripMenuItem.Text = "About Point of Sales";
          this.aboutPointOfSalesToolStripMenuItem.Click += new System.EventHandler(this.aboutPointOfSalesToolStripMenuItem_Click);
          // 
          // toolStripContainer1
          // 
          this.toolStripContainer1.BottomToolStripPanelVisible = false;
          // 
          // toolStripContainer1.ContentPanel
          // 
          this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
          this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(758, 458);
          this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.toolStripContainer1.LeftToolStripPanelVisible = false;
          this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
          this.toolStripContainer1.Name = "toolStripContainer1";
          this.toolStripContainer1.RightToolStripPanelVisible = false;
          this.toolStripContainer1.Size = new System.Drawing.Size(758, 483);
          this.toolStripContainer1.TabIndex = 1;
          this.toolStripContainer1.Text = "toolStripContainer1";
          // 
          // toolStripContainer1.TopToolStripPanel
          // 
          this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.standardToolStrip);
          // 
          // tabControl
          // 
          this.tabControl.Controls.Add(this.saleTab);
          this.tabControl.Location = new System.Drawing.Point(3, 3);
          this.tabControl.Name = "tabControl";
          this.tabControl.SelectedIndex = 0;
          this.tabControl.Size = new System.Drawing.Size(750, 451);
          this.tabControl.TabIndex = 0;
          // 
          // saleTab
          // 
          this.saleTab.BackColor = System.Drawing.Color.White;
          this.saleTab.Location = new System.Drawing.Point(4, 22);
          this.saleTab.Name = "saleTab";
          this.saleTab.Padding = new System.Windows.Forms.Padding(3);
          this.saleTab.Size = new System.Drawing.Size(742, 425);
          this.saleTab.TabIndex = 0;
          this.saleTab.Text = " Sale ";
          this.saleTab.Enter += new System.EventHandler(this.saleTab_Enter);
          // 
          // standardToolStrip
          // 
          this.standardToolStrip.Dock = System.Windows.Forms.DockStyle.None;
          this.standardToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemButton,
            this.removeItemButton});
          this.standardToolStrip.Location = new System.Drawing.Point(3, 0);
          this.standardToolStrip.Name = "standardToolStrip";
          this.standardToolStrip.Size = new System.Drawing.Size(172, 25);
          this.standardToolStrip.TabIndex = 0;
          // 
          // addItemButton
          // 
          this.addItemButton.Image = ((System.Drawing.Image)(resources.GetObject("addItemButton.Image")));
          this.addItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.addItemButton.Name = "addItemButton";
          this.addItemButton.Size = new System.Drawing.Size(71, 22);
          this.addItemButton.Text = "Add Item";
          this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
          // 
          // removeItemButton
          // 
          this.removeItemButton.Enabled = false;
          this.removeItemButton.Image = ((System.Drawing.Image)(resources.GetObject("removeItemButton.Image")));
          this.removeItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.removeItemButton.Name = "removeItemButton";
          this.removeItemButton.Size = new System.Drawing.Size(91, 22);
          this.removeItemButton.Text = "Remove Item";
          this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
          // 
          // PosMainWindow
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(758, 507);
          this.Controls.Add(this.toolStripContainer1);
          this.Controls.Add(this.mainWindowMenu);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.MainMenuStrip = this.mainWindowMenu;
          this.MaximizeBox = false;
          this.MaximumSize = new System.Drawing.Size(764, 532);
          this.MinimumSize = new System.Drawing.Size(764, 532);
          this.Name = "PosMainWindow";
          this.Text = "Point of Sales";
          this.Load += new System.EventHandler(this.PosMainWindow_Load);
          this.mainWindowMenu.ResumeLayout(false);
          this.mainWindowMenu.PerformLayout();
          this.toolStripContainer1.ContentPanel.ResumeLayout(false);
          this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
          this.toolStripContainer1.TopToolStripPanel.PerformLayout();
          this.toolStripContainer1.ResumeLayout(false);
          this.toolStripContainer1.PerformLayout();
          this.tabControl.ResumeLayout(false);
          this.standardToolStrip.ResumeLayout(false);
          this.standardToolStrip.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip mainWindowMenu;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
      private System.Windows.Forms.ToolStripContainer toolStripContainer1;
      private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem discontinueProductToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutPointOfSalesToolStripMenuItem;
      private System.Windows.Forms.TabControl tabControl;
      private System.Windows.Forms.TabPage saleTab;
      private System.Windows.Forms.ToolStrip standardToolStrip;
      private System.Windows.Forms.ToolStripButton addItemButton;
      private System.Windows.Forms.ToolStripButton removeItemButton;
      private System.Windows.Forms.ToolStripMenuItem showReportToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem showInventoryButton;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem returnMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newShipmentToolStripMenuItem;




   }
}

