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
public partial class SaleDetailForm : Form
{
    public SaleDetailForm(Receipt receipt)
    {
        InitializeComponent();
        AcceptButton = okButton;
        AcceptButton.DialogResult = DialogResult.OK;
        foreach(Product p in receipt.ItemsSold)
        {
            var index = listOfItems.Rows.Add();
            listOfItems.Rows[index].Cells[0].Value = p.ItemName;
            listOfItems.Rows[index].Cells[1].Value = p.Quantity;
            listOfItems.Rows[index].Cells[2].Value = p.Price;
        }
    }
}
}
