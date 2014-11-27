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
public partial class UpdateProductForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateProductForm"/> class.
    /// </summary>
    /// <param name="register">The register.</param>
    /// <param name="product">The product.</param>
    /// <param name="ic">The ic.</param>
    public UpdateProductForm(ref Register register, Product product, InventoryControl ic)
    {
        InitializeComponent();

        m_product = product;
        m_register = register;
        m_inventory = ic;
        
        itemNameBox.Text = m_product.ItemName;
        quantityNum.Value = m_product.Quantity;
        costNum.Value = (decimal)m_product.Cost.Value/(decimal)100;
        priceNum.Value = (decimal)m_product.Price.Value/(decimal)100;

        CancelButton = cancelButton;
        CancelButton.DialogResult = DialogResult.Cancel;

    }

    /// <summary>
    /// Handles the Click event of the updateButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void updateButton_Click(object sender, EventArgs e)
    {
        if(AcceptButton != null)
            return;

        CashValue cost;
        CashValue price;

        if(!CashValue.TryParse((double)costNum.Value, out cost))
        {
            MessageBox.Show("Failed to parse Cash Value for cost!", "Notice!");
            return;
        }

        if(!CashValue.TryParse((double)priceNum.Value, out price))
        {
            MessageBox.Show("Failed to parse Price Value for cost!", "Notice!");
            return;
        }
        
        m_product.Cost = cost;
        m_product.Price = price;
        m_product.ItemName = itemNameBox.Text;
        m_product.Quantity = (int)quantityNum.Value;

        m_inventory.UpdateInventory();
        m_register.Save();
        AcceptButton = updateButton;
        AcceptButton.DialogResult = DialogResult.OK;
        AcceptButton.PerformClick();
    }
    
    private Product m_product;
    private Register m_register;
    private InventoryControl m_inventory;

}
}
