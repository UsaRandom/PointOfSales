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
#region Class Definition : ItemSearchUI
public partial class ItemSearchUI : Form
{

   #region Constructor
   
   /// <summary>
   /// Initializes a new instance of the <see cref="ItemSearchUI"/> class.
   /// </summary>
   /// <param name="products">The products.</param>
   public ItemSearchUI(ICollection<Product> products, bool remove, bool price)
   {
      InitializeComponent();
      m_products = products as List<Product>;
      m_isRemove = remove;
      if(price)
          cashLbl.Text = "Price:";
      else
          cashLbl.Text = "Cost:";
      m_price = price;
   }

   public ItemSearchUI(SaleControl saleControl, bool remove, bool price)
   {
      InitializeComponent();
      m_products = saleControl.Products as List<Product>;
      m_isRemove = remove;
      if(price)
          cashLbl.Text = "Price:";
      else
          cashLbl.Text = "Cost:";
      m_price = price;
   }
   
   #endregion
   
   #region Public Methods


   /// <summary>
   /// Gets the products.
   /// </summary>
   /// <value>The products.</value>
   public Product Product
   {
      get
      {
         return m_returnProduct;
      }
   }
   
   #endregion
   
   #region Private Methods


   /// <summary>
   /// Handles the Click event of the searchButton control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void searchButton_Click(object sender, EventArgs e)
   {
       productListBox.Items.Clear();
       if (searchByItemName.Checked)
       {
           foreach (Product p in m_products)
           {
               if (p.ItemName.ToLower().StartsWith(searchBox.Text.ToLower()) && !p.Discontinued)
                   productListBox.Items.Add(p);
           }
       }
       else
       {
           int sn = 0;

           if(!Int32.TryParse(searchBox.Text, out sn))
               return;

           foreach (Product p in m_products)
           {
               if (p.SN.IntValue == sn && !p.Discontinued)
                   productListBox.Items.Add(p);
           }
       }
   }

   /// <summary>
   /// Handles the SelectedIndexChanged event of the productListBox control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
   {
       try
       {
           Product product = (Product)productListBox.Items[productListBox.SelectedIndex];
           productNameLbl.Text = "Product: " + product.ItemName;
           quantityLbl.Text = "Quantity: " + product.Quantity;
           if(m_price)
               cashLbl.Text = "Price: " + product.Price;
           else
               cashLbl.Text = "Cost: " + product.Cost;
           stockNumberLbl.Text = "Stock Number: " + product.SN;
           this.acceptButton.Enabled = true;
           quantityReturnLbl.Enabled = true;
           quantityNum.Enabled = true;
           if(m_isRemove)
               quantityNum.Maximum = product.Quantity;
       }
       catch
       {
       }
   }

   /// <summary>
   /// Handles the Load event of the ItemSearchUI control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void ItemSearchUI_Load(object sender, EventArgs e)
   {
       this.AcceptButton = this.acceptButton;
       this.AcceptButton.DialogResult = DialogResult.OK;
       this.CancelButton = this.cancelButton;
       this.CancelButton.DialogResult = DialogResult.Cancel;
       foreach(Product p in m_products)
       {
           if(!p.Discontinued)
               productListBox.Items.Add(p);
       }
   }

   /// <summary>
   /// Handles the Click event of the acceptButton control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void acceptButton_Click(object sender, EventArgs e)
   {
      Product p = (Product)productListBox.Items[productListBox.SelectedIndex];
      m_returnProduct = new Product(p.ItemName,
                                    p.SN.IntValue,
                                    (int)this.quantityNum.Value,
                                    p.Cost.Value,
                                    p.Price.Value,
                                    p.Discontinued);
   }
   
   #endregion
   
   #region Private Variables
   
   private Product m_returnProduct;
   private bool m_price;
   private bool m_isRemove;
   private List<Product> m_products;

   #endregion

}
#endregion
}
