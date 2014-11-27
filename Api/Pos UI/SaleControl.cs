using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pos.Api;

namespace Pos.UI
{
public partial class SaleControl : UserControl
{
    public SaleControl(ref Register register, ref Report report, ref ToolStripButton button)
    {
        m_register = register;
        m_report = report;
        m_sale = new Sale(ref m_register);
        m_button = button;
        InitializeComponent();
    }

    public void Add(Product p)
    {
        m_sale.Add(p);
        UpdateList();
    }

    public bool Remove(Product p)
    {
        bool toReturn = m_sale.Remove(p);
        if(m_sale.Products.Count == 0)
            m_button.Enabled = false;

        UpdateList();
        return toReturn;
    }

    internal ICollection<Product> Products
    {
        get
        {
            return m_sale.Products;
        }
    }

    /// <summary>
    /// Clears the Sale.
    /// </summary>
    public void Clear()
    {
        m_receipt = null;
        m_sale = new Sale(ref m_register);
        UpdateList();
    }

    public Receipt Receipt
    {
        get
        {
            if(m_receipt == null)
                throw new NullReferenceException();
            return m_receipt;
        }
    }

    private void UpdateList()
    {
        listOfProducts.Rows.Clear();
        foreach(Product p in m_sale.Products)
        {
            var index = listOfProducts.Rows.Add();
            listOfProducts.Rows[index].Cells[0].Value = p.SN;
            listOfProducts.Rows[index].Cells[1].Value = p.ItemName;
            listOfProducts.Rows[index].Cells[2].Value = p.Quantity;
            listOfProducts.Rows[index].Cells[3].Value = p.Price;
        }
        this.subTotalCashLbl.Text = m_sale.GetSubTotal().ToString();
        this.taxCashLbl.Text = m_sale.GetTax().ToString();
        this.totalCashLbl.Text = m_sale.GetTotal().ToString();

        if(m_sale.Products.Count == 0)
            completeSale.Enabled = false;
        else
            completeSale.Enabled = true;
    }

    private void completeSale_Click(object sender, EventArgs e)
    {
        if(m_sale.Products.Count == 0)
            return;

        MoneySelectorUI moneySelector = new MoneySelectorUI(ref m_register, m_sale.GetTotal(), false, false);
        DialogResult tempDR = moneySelector.ShowDialog();
        Money payment;

        if(tempDR == DialogResult.OK)
            payment = moneySelector.Cash;
        else
            return;
        Receipt receipt;
        try
        {
            receipt = m_sale.Complete(payment);
        }
        catch(Exception exc)
        {
            MessageBox.Show(exc.Message);
            return;
        }
        ChangeForm changeForm = new ChangeForm(receipt.Change);

        changeForm.ShowDialog();

        m_report.Receipts.Add(receipt);
        m_register.Save();
        m_button.Enabled = false;
        this.Clear();
    }

    private Sale m_sale;
    private Receipt m_receipt;
    private ToolStripButton m_button;
    private Register m_register;
    private Report m_report;

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
