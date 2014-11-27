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
public partial class InventoryControl : UserControl
{
    public InventoryControl(ref Register register)
    {
        m_register = register;
        InitializeComponent();
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        MakeAllVisible();
        if(itemNameSearch.Checked)
        {

            if(searchBox.Text == String.Empty)
                return;

            foreach(DataGridViewRow row in listOfItems.Rows)
            {
                if(!row.Cells[1].Value.ToString().ToLower().StartsWith(searchBox.Text))
                {
                    row.Visible = false;
                }
            }
        }
        else
        {
            int searchInt;

            if(!Int32.TryParse(searchBox.Text, out searchInt))
                return;

            foreach(DataGridViewRow row in listOfItems.Rows)
            {
                if(Int32.Parse(row.Cells[0].Value.ToString()) != searchInt)
                {
                    row.Visible = false;
                }
            }
        }
    }

    private void InventoryControl_Load(object sender, EventArgs e)
    {
        UpdateInventory();
    }

    public void MakeAllVisible()
    {
        foreach(DataGridViewRow row in listOfItems.Rows)
        {
            row.Visible = true;
        }
    }

    public void UpdateInventory()
    {
        listOfItems.Rows.Clear();
        foreach(Product p in m_register.Products)
        {
            var index = listOfItems.Rows.Add();
            listOfItems.Rows[index].Cells[0].Value = p.SN;
            listOfItems.Rows[index].Cells[1].Value = p.ItemName;
            listOfItems.Rows[index].Cells[2].Value = p.Quantity;
            listOfItems.Rows[index].Cells[3].Value = p.Cost;
            listOfItems.Rows[index].Cells[4].Value = p.Price;
            listOfItems.Rows[index].Cells[5].Value = p.Discontinued;
        }
    }

    private Register m_register;

    private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Got here!");

        DataGridViewRow row = listOfItems.CurrentRow;

        Console.WriteLine("Got there!");

        int sn = Int32.Parse(row.Cells[0].Value.ToString());

        var products = from p
                      in m_register.Products
                      where p.SN.IntValue == sn
                      select p;

        if(products.Count() != 1)
            return;

        Console.WriteLine("Got there!");

        var product = products.First();

        UpdateProductForm upf = new UpdateProductForm(ref m_register, product, this);
        
        upf.ShowDialog();

    }

    private void listOfItems_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
    {
        if(e.ColumnIndex < 0)
            return;
        if(e.RowIndex < 0)
            return;
        try
        {
            listOfItems.ClearSelection();
            listOfItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }
        catch
        {}
    }
}
}
