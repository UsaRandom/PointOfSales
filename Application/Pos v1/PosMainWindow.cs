using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pos.UI;
using Pos.DB;
using Pos.Api;

namespace Pos_v1
{
public partial class PosMainWindow : Form
{
    public PosMainWindow()
    {
        InitializeComponent();
    }

    private void PosMainWindow_Load(object sender, EventArgs e)
    {
        DataSourceSelectorUI dataSelector = new DataSourceSelectorUI();

        if (dataSelector.ShowDialog() == DialogResult.OK)
        {
            m_record = dataSelector.Record;
        }
        else
        {
            this.Dispose();
            Application.Exit();
            return;
        }

        m_register = new Register(m_record);
        m_report = new Report();
        m_saleControl = new SaleControl(ref m_register, ref m_report, ref removeItemButton);
        saleTab.Controls.Add(m_saleControl);

        m_reportTab = new TabPage(" Report ");
        m_reportTab.Controls.Add(new ReportControl(ref m_report, ref m_register));
        m_reportTab.Enter += new EventHandler(m_reportTab_Enter);

        m_inventoryTab = new TabPage(" Inventory ");
        m_inventoryTab.Controls.Add(new InventoryControl(ref m_register));
        m_inventoryTab.Enter += new EventHandler(m_inventoryTab_Enter);

    }

    void m_inventoryTab_Enter(object sender, EventArgs e)
    {
        m_removeEnabled = removeItemButton.Enabled;
        foreach(ToolStripItem item in standardToolStrip.Items)
        {
            item.Enabled = false;
        }
        foreach (Control c in m_inventoryTab.Controls)
        {
            if (c is InventoryControl)
            {
                var ic = c as InventoryControl;
                ic.UpdateInventory();
            }
        }
    }

    void m_reportTab_Enter(object sender, EventArgs e)
    {
        m_removeEnabled = removeItemButton.Enabled;
        foreach(ToolStripItem item in standardToolStrip.Items)
        {
            item.Enabled = false;
        }
        foreach(Control c in m_reportTab.Controls)
        {
            if( c is ReportControl)
            {
                ReportControl rc = c as ReportControl;
                rc.UpdateReport();
            }
        }
    }

    private void addItemButton_Click(object sender, EventArgs e)
    {
        ItemSearchUI itemSearch = new ItemSearchUI(m_register.Products, false, true);
        DialogResult tempDR = itemSearch.ShowDialog();

        if(tempDR == DialogResult.OK)
        {
            m_saleControl.Add(itemSearch.Product);
            removeItemButton.Enabled = true;
        }
        else
            return;
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        removeItemButton.Enabled = false;
        m_saleControl.Clear();
    }

    private void showReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if(showReportToolStripMenuItem.Checked)
            tabControl.Controls.Add(m_reportTab);
        else
            tabControl.Controls.Remove(m_reportTab);
    }

    private void saleTab_Enter(object sender, EventArgs e)
    {
        foreach(ToolStripItem item in standardToolStrip.Items)
        {
            item.Enabled = true;
        }
        removeItemButton.Enabled = m_removeEnabled;
    }

    private void showInventoryButton_Click(object sender, EventArgs e)
    {
        if(showInventoryButton.Checked)
            tabControl.Controls.Add(m_inventoryTab);
        else
            tabControl.Controls.Remove(m_inventoryTab);
    }

    private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
    {
        NewProductForm newProductform = new NewProductForm(ref m_register);
        DialogResult tempDR = newProductform.ShowDialog();

        Product toAdd;

        if(tempDR != DialogResult.OK)
            return;

        toAdd = newProductform.ProductToAdd;

        m_register.Products.Add(toAdd);

        foreach(Control c in m_inventoryTab.Controls)
        {
            if(c is InventoryControl)
            {
                InventoryControl inv = c as InventoryControl;
                inv.UpdateInventory();
            }
        }
        m_register.Save();

    }

    private void aboutPointOfSalesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new AboutPOS().ShowDialog();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        m_register.Save();
        Application.Exit();
    }

    private void removeItemButton_Click(object sender, EventArgs e)
    {
        SaleControl sc = null;
        foreach(Control c in saleTab.Controls)
        {
            if(c is SaleControl)
            {
                sc = c as SaleControl;
            }
        }

        if(sc == null)
            return;

        ItemSearchUI searchUI = new ItemSearchUI(sc, true, true);
        DialogResult tempDR;

        tempDR = searchUI.ShowDialog();

        if(tempDR != DialogResult.OK)
            return;

        if(!sc.Remove(searchUI.Product))
            MessageBox.Show("The Product was not in the Sale!"
                           +" But seriously, how did you do that?",
                           "Error!", MessageBoxButtons.OK);



    }

    private void discontinueProductToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var rc = from Control c
                 in m_reportTab.Controls
                 where c is ReportControl
                 select c;
        ReportControl report = rc.First() as ReportControl;
        
        var ic = from Control c
                 in m_inventoryTab.Controls
                 where c is InventoryControl
                 select c;
        InventoryControl inventory = ic.First() as InventoryControl;

        DiscontinueItemForm dif = new DiscontinueItemForm(ref m_register,
                                                          ref inventory,
                                                          ref report);

        dif.ShowDialog();
    }

    private void newShipmentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var rc = from Control c
                 in m_reportTab.Controls
                 where c is ReportControl
                 select c;
        ReportControl report = rc.First() as ReportControl;
        
        var ic = from Control c
                 in m_inventoryTab.Controls
                 where c is InventoryControl
                 select c;

        InventoryControl inventory = ic.First() as InventoryControl;

        ShipmentForm sf = new ShipmentForm(ref m_register,
                                           ref inventory,
                                           ref report);
        sf.ShowDialog();
    }

    private void returnMenuItem_Click(object sender, EventArgs e)
    {
        var rc = from Control c
                 in m_reportTab.Controls
                 where c is ReportControl
                 select c;
        ReportControl report = rc.First() as ReportControl;
        
        var ic = from Control c
                 in m_inventoryTab.Controls
                 where c is InventoryControl
                 select c;

        InventoryControl inventory = ic.First() as InventoryControl;

        ReturnForm rf = new ReturnForm(ref m_register,
                                           ref inventory,
                                           ref report);
        rf.ShowDialog();
    }

    private Register m_register;
    private Report m_report;
    private IRecord m_record;
    private SaleControl m_saleControl;
    private bool m_removeEnabled;
    private TabPage m_reportTab;
    private TabPage m_inventoryTab;


}
}
