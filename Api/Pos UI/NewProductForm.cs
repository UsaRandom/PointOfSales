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
public partial class NewProductForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NewProductForm"/> class.
    /// </summary>
    /// <param name="register">The register.</param>
    public NewProductForm(ref Register register)
    {
        var max = register.Products.Max(m => m.SN.IntValue);
        m_maxSn = max+1;
        m_product = new Product();

        InitializeComponent();

        AcceptButton = addButton;
        AcceptButton.DialogResult = DialogResult.OK;
        CancelButton = cancelButton;
        CancelButton.DialogResult = DialogResult.Cancel;
        addButton.Enabled = false;
        stockNumberNum.Value = m_maxSn;
        stockNumberNum.Minimum = m_maxSn;

        m_product.SN = new StockNumber(m_maxSn);
        m_product.Cost = new CashValue(0);
        m_product.Price = new CashValue(0);

    }

    /// <summary>
    /// Gets the product to add.
    /// </summary>
    /// <value>The product to add.</value>
    public Product ProductToAdd
    {
        get
        {
            CheckProduct();

            if(!this.addButton.Enabled)
                throw new NullReferenceException("The Product to Add has not been made yet!");

            return m_product;
        }
    }

    /// <summary>
    /// Handles the ValueChanged event of the StockNumberNum control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void StockNumberNum_ValueChanged(object sender, EventArgs e)
    {
        m_product.SN = new StockNumber((int)stockNumberNum.Value);
        CheckProduct();
    }


    /// <summary>
    /// Handles the TextChanged event of the itemName control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void itemName_TextChanged(object sender, EventArgs e)
    {
        m_product.ItemName = itemName.Text;
        CheckProduct();
    }

    /// <summary>
    /// Handles the ValueChanged event of the costNum control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void costNum_ValueChanged(object sender, EventArgs e)
    {
        int cost = (int)(costNum.Value * (decimal)100);
        m_product.Cost = new CashValue(cost);
        CheckProduct();
    }

    /// <summary>
    /// Handles the ValueChanged event of the priceNum control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void priceNum_ValueChanged(object sender, EventArgs e)
    {
        int price = (int)(priceNum.Value * (decimal)100);
        m_product.Price = new CashValue(price);
        CheckProduct();
    }

    /// <summary>
    /// Checks the product.
    /// </summary>
    private void CheckProduct()
    {
        if(m_product.SN != null &&
           m_product.Price != null &&
           m_product.ItemName != null &&
           m_product.Cost != null)
        {
            m_product.Discontinued = false;
            m_product.Quantity = 0;
            addButton.Enabled = true;
        }
        else
        {
            addButton.Enabled = false;
        }
        
    }
    
    private Product m_product;
    private int m_maxSn;

}
}
