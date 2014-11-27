/*
 * Sale.cs 
 * Author: Martin Stauber & Tito Gomez
 * 
 * Classes:
 *    -Sale
 *       Handles the Selling of Items.
 *  
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pos.DB;

namespace Pos.Api
{
#region Class Definition : Sale
public class Sale 
{

   #region Constructor

   /// <summary>
   /// Initializes a new instance of the <see cref="Sale"/> class.
   /// </summary>
   /// <param name="register">The register.</param>
    public Sale(ref Register register)
    { 
        m_register = register;
        m_products = new List<Product>();
        m_completed = false;
        m_saleID = GetNewSaleID();
    }
    
    #endregion
    
    #region Public Methods

    /// <summary>
    /// Adds the specified p.
    /// </summary>
    /// <param name="p">The p.</param>
    public void Add(Product p)
    {
        if (m_completed)
            throw new InvalidOperationException("Sale already completed!");
        Product product = m_products.SingleOrDefault(pr => pr.SN.Equals(p.SN));

        if(product == null)
            m_products.Add(p);
        else
            product.Quantity += p.Quantity;
    }

    /// <summary>
    /// Removes the specified p.
    /// </summary>
    /// <param name="p">The p.</param>
    /// <returns></returns>
    public bool Remove(Product p)
    {
        if (m_completed)
            throw new InvalidOperationException("Sale already completed!");
        
        Product product = m_products.SingleOrDefault(pr => pr.SN.Equals(p.SN));

        if(product == null)
            throw new NullReferenceException("Product not found in Collection!");
        
        product.Quantity -= p.Quantity;

        if(product.Quantity == 0)
            m_products.Remove(product);
        else if (product.Quantity < 0)
            throw new ArithmeticException("Product Quantity cannot be less than 0!!!");

        return true;
    }

    /// <summary>
    /// Totals this instance.
    /// </summary>
    /// <returns></returns>
    public CashValue GetTotal()
    {
        Receipt tempReceipt;
        
        tempReceipt = new Receipt(m_products, m_saleID, ref m_register);
        
        return tempReceipt.TotalAfterTax;
    }

    /// <summary>
    /// Gets the sub total.
    /// </summary>
    /// <returns></returns>
    public CashValue GetSubTotal()
    {
        Receipt tempReceipt;
        
        tempReceipt = new Receipt(m_products, m_saleID, ref m_register);
        
        return tempReceipt.TotalBeforeTax;
    }

    /// <summary>
    /// Gets the tax.
    /// </summary>
    /// <returns></returns>
    public CashValue GetTax()
    {
        Receipt tempReceipt;
        
        tempReceipt = new Receipt(m_products, m_saleID, ref m_register);
        
        return tempReceipt.Tax;
    }

    /// <summary>
    /// Completes the specified payment.
    /// </summary>
    /// <param name="payment">The payment.</param>
    /// <returns></returns>
    public Receipt Complete(Money payment)
    {
        Receipt toReturn;
        try
        {
            if(payment.GetCashValue().Value < this.GetTotal().Value)
                throw new ArgumentException("Too little Money was given!");
            
            foreach(Product product in m_register.Products)
            {
                var selectedProduct = m_products.SingleOrDefault(p => p.SN.Equals(product.SN));

                if(selectedProduct == null)
                    continue;

                product.Quantity -= selectedProduct.Quantity;
            }
            
            toReturn = new Receipt(m_products, m_saleID, ref m_register, payment);
            
            m_completed = true;
        }
        catch(Exception e)
        {
            throw e;
        }
        return toReturn;
    }

    /// <summary>
    /// Gets the products.
    /// </summary>
    /// <value>The products.</value>
    public ICollection<Product> Products
    {
        get
        {
            return m_products;
        }
    }

    /// <summary>
    /// Gets a value indicating whether this instance is completed.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is completed; otherwise, <c>false</c>.
    /// </value>
    public bool IsCompleted
    {
        get
        {
            return m_completed;
        }
    }

    public int SaleID
    {
        get
        {
            return m_saleID;
        }
    }
    
    #endregion


    #region Private Methods

    /// <summary>
    /// Gets a new sale ID.
    /// </summary>
    /// <returns></returns>
    private static int GetNewSaleID()
    {
        return m_counter++;
    }

    #endregion

    #region Private Variables

    private bool m_completed;
    private Register m_register;
    private ICollection<Product> m_products;
    private int m_saleID;
    private static int m_counter = 1;
    
    #endregion
    
}
#endregion
}
