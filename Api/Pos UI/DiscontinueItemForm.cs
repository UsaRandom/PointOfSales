using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pos.Api;

namespace Pos.UI
{
public partial class DiscontinueItemForm : Form
{
    public DiscontinueItemForm(ref Register register, ref InventoryControl ic, ref ReportControl rc)
    {
        InitializeComponent();
        m_register = register;
        m_inventory = ic;
        m_report = rc;
        foreach(Product p in register.Products)
        {
            if(!p.Discontinued)
                listOfProducts.Items.Add(p);
        }
        CancelButton = cancelButton;
        CancelButton.DialogResult = DialogResult.OK;
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        listOfProducts.Items.Clear();
        if(searchBySN.Checked)
        {
            int sn = 0;
            if(!Int32.TryParse(searchBox.Text, out sn))
                return;
            foreach(Product p in m_register.Products)
            {
                if(p.SN.IntValue == sn)
                    listOfProducts.Items.Add(p);
            }
        }
        else
        {
            foreach(Product p in m_register.Products)
            {
                if(p.ItemName.ToLower().StartsWith(searchBox.Text.ToLower()))
                    listOfProducts.Items.Add(p);
            }
        }
    }

    private void disconButton_Click(object sender, EventArgs e)
    {
        if(AcceptButton != null)
            return;

        try
        {
            m_product = listOfProducts.Items[listOfProducts.SelectedIndex] as Product;
        }
        catch
        {
            return;
        }
        DialogResult tempDR;
        tempDR = MessageBox.Show("Are you sure you want to discontinue "+ m_product + ".",
                                 "Confirm",
                                 MessageBoxButtons.YesNo);

        if(tempDR == DialogResult.Yes)
        {
            if(m_product.Quantity > 0)
            {
                CashValue returnCash = new CashValue(m_product.Cost.Value * m_product.Quantity);
                MessageBox.Show("Please chose how you will get your money back.", "Notice");
                MoneySelectorUI selector = new MoneySelectorUI(ref m_register, returnCash, true, false);
                tempDR = selector.ShowDialog();

                if(tempDR != DialogResult.OK)
                    return;

                m_register.Cash.Credit(selector.Cash);
                MessageBox.Show(selector.Cash.GetCashValue()+" was added to your register", "Notice");
            }

            m_product.Discontinued = true;
            m_product.Quantity = 0;

            m_report.UpdateReport();
            m_inventory.UpdateInventory();

        }
        m_register.Save();
        AcceptButton = disconButton;
        AcceptButton.DialogResult = DialogResult.OK;
        AcceptButton.PerformClick();

    }

    private Product m_product;
    private Register m_register;
    private InventoryControl m_inventory;
    private ReportControl m_report;

    private void listOfProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(listOfProducts.Items[listOfProducts.SelectedIndex] != null)
            disconButton.Enabled = true;
        else
            disconButton.Enabled = false;
    }

}
}