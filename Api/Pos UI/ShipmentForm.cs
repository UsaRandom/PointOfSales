using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pos.Api;
using Pos.UI;

namespace Pos.UI
{
public partial class ShipmentForm : Form
{

    public ShipmentForm(ref Register register, ref InventoryControl ic, ref ReportControl rc)
    {
        m_register = register;
        InitializeComponent();
        m_products = new List<Product>();
        m_report = rc;
        m_inventory = ic;
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        ItemSearchUI itemSearcher = new ItemSearchUI(m_register.Products, false, false);
        DialogResult tempDR = itemSearcher.ShowDialog();

        if(tempDR != DialogResult.OK)
            return;

        Product toAdd = itemSearcher.Product;
        bool added = false;

        foreach(DataGridViewRow row in listOfProducts.Rows)
        {
            if(Int32.Parse(row.Cells[0].Value.ToString()) == toAdd.SN.IntValue)
            {
               int temp = Int32.Parse(row.Cells[3].Value.ToString());
               row.Cells[3].Value = temp + toAdd.Quantity;
               added = true;
               UpdateShipment();
            }
        }

        if(added)
            return;
        
        var index = listOfProducts.Rows.Add();
        listOfProducts.Rows[index].Cells[0].Value = toAdd.SN;
        listOfProducts.Rows[index].Cells[1].Value = toAdd.ItemName;
        listOfProducts.Rows[index].Cells[2].Value = toAdd.Cost;
        listOfProducts.Rows[index].Cells[3].Value = toAdd.Quantity;
        UpdateShipment();

    }

    private void UpdateShipment()
    {
        var totalItems = 0;
        var totalCost = 0;

        m_products = new List<Product>();

        foreach(DataGridViewRow row in listOfProducts.Rows)
        {
            var quantity =  Int32.Parse(row.Cells[3].Value.ToString());

            var product = m_register.Products.SingleOrDefault
                                (p => p.SN.IntValue == Int32.Parse(row.Cells[0].Value.ToString()));

            if(product != null)
            {
                product = new Product(product.ItemName,
                                      product.SN.IntValue,
                                      quantity,
                                      product.Cost.Value,
                                      product.Price.Value,
                                      product.Discontinued);

                m_products.Add(product);
            }
            totalItems += quantity;
            totalCost += quantity * (int)((CashValue)row.Cells[2].Value).Value;
        }

        var totalCashValueCost = new CashValue(totalCost);
        costLbl.Text = totalCashValueCost.ToString();
        countLbl.Text = totalItems.ToString();
    }

    private void completeShipmentButton_Click(object sender, EventArgs e)
    {
        if(AcceptButton != null)
            return;

        var cashValue = 0;
        foreach(Product p in m_products)
        {
            cashValue += p.Quantity * p.Cost.Value;
        }
        CashValue total = new CashValue(cashValue);

        if(m_register.Cash.GetCashValue().Value < total.Value)
        {
            MessageBox.Show("You need more money to pay for all this than you have", "Notice!");
            return;
        }

        Money unlim = new Money(new TwentyDollarBills(100),
                                new TenDollarBills(100),
                                new FiveDollarBills(100),
                                new OneDollarBills(100),
                                new Quarters(100),
                                new Dimes(100),
                                new Nickels(100),
                                new Pennies(100));

        MoneySelectorUI moneySelector = new MoneySelectorUI(ref m_register, total, false, true);
        DialogResult tempDR = moneySelector.ShowDialog();

        if(tempDR != DialogResult.OK)
            return;

        var payment = moneySelector.Cash;

        var change = unlim.Credit(total, payment);

        m_register.Cash.Debit(payment);

        if(change.GetCashValue().Value != 0)
        {
            ChangeForm cf = new ChangeForm(change);
            cf.ShowDialog();
        }

        m_register.Cash.Credit(change);

        foreach(Product p in m_register.Products)
        {
            var product = m_products.SingleOrDefault(pro => pro.SN.Equals(p.SN));
            
            if(product == null)
                continue;

            p.Quantity += product.Quantity;

        }

        m_register.Save();
        m_inventory.UpdateInventory();
        m_report.UpdateReport();
        AcceptButton = completeShipmentButton;
        AcceptButton.DialogResult = DialogResult.OK;
        AcceptButton.PerformClick();
    }

    private void removeButton_Click(object sender, EventArgs e)
    {
        if(m_products.Count == 0)
            return;

        ItemSearchUI itemSearcher = new ItemSearchUI(m_products, true, false);
        DialogResult tempDR = itemSearcher.ShowDialog();

        if(tempDR != DialogResult.OK)
            return;

        Product toRemove = itemSearcher.Product;

        int index = -1;
        bool removed = true;

        foreach(DataGridViewRow row in listOfProducts.Rows)
        {
            if(Int32.Parse(row.Cells[0].Value.ToString()) == toRemove.SN.IntValue)
            {
               if(toRemove.Quantity == Int32.Parse(row.Cells[3].Value.ToString()))
               {
                   index = row.Index;
                   removed = false;
                   break;
               }
               else
               {
                   int temp = Int32.Parse(row.Cells[3].Value.ToString());
                   temp -= toRemove.Quantity;
                   row.Cells[3].Value = temp;
                   UpdateShipment();
               }
            }
        }

        if(removed)
            return;

        if(index != -1)
        {
            listOfProducts.Rows.Remove(listOfProducts.Rows[index]);
            UpdateShipment();
        }
        else
            throw new Exception("Error removing item from shipment!");

    }
    
    private Register m_register;
    private List<Product> m_products;
    private InventoryControl m_inventory;
    private ReportControl m_report;

    private void listOfProducts_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
    {
        if(e.ColumnIndex < 0)
            return;
        if(e.RowIndex < 0)
            return;
        try
        {
            listOfProducts.ClearSelection();
            listOfProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }
        catch
        {}
    }

}
}
