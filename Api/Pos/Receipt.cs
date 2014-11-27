
/*
 * Receipt.cs 
 * Author: Martin Stauber and Tito Gomez
 * 
 * Classes:
 *    -Receipt
 *       Readonly Object that holds Source Sale Information.
 *  
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pos.Api
{
#region Class Definition : Receipt
public class Receipt
{

    #region Constructors

   /// <summary>
   /// Initializes a new instance of the <see cref="Receipt"/> class.
   /// </summary>
   /// <param name="products">The products.</param>
   /// <param name="register">The register.</param>
    internal Receipt(ICollection<Product> products, int saleId, ref Register register)
    {
        m_products = products as List<Product>;
        m_saleId = saleId;
        int totalPrice = 0;
        int costForUs = 0;
        
        foreach(Product p in products)
        {
            totalPrice += p.Quantity * p.Price.Value;
            costForUs += p.Quantity * p.Cost.Value;
        }
        
        m_totalBeforeTax = new CashValue(totalPrice);
        
        int tax = (int)Math.Ceiling((double)totalPrice * TAX);
        
        m_tax = new CashValue(tax);
        
        int profit = costForUs - totalPrice;
        
        m_profit = new CashValue(profit);
        
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Receipt"/> class.
    /// </summary>
    /// <param name="products">The products.</param>
    /// <param name="register">The register.</param>
    /// <param name="payment">The payment.</param>
    internal Receipt(ICollection<Product> products, int saleId, ref Register register, Money payment)
    {
        m_saleId = saleId;
        m_products = products as List<Product>;
        int totalPrice = 0;
        int costForUs = 0;
        
        foreach(Product p in products)
        {
            totalPrice += p.Quantity * p.Price.Value;
            costForUs += p.Quantity * p.Cost.Value;
        }
        
        m_totalBeforeTax = new CashValue(totalPrice);
        
        int tax = (int)Math.Ceiling((double)totalPrice * TAX);
        
        m_tax = new CashValue(tax);
        
        int profit = totalPrice - costForUs;
        
        m_profit = new CashValue(profit);
        
        register.Cash.Credit(payment);
        
        int diff = payment.GetCashValue().Value - TotalAfterTax.Value;
        try
        {
            m_change = register.Cash.Debit(new CashValue(diff));
        }
        catch(Exception e)
        {
            register.Cash.Debit(payment.GetCashValue());
            throw e;
        }
    }
    
    
    #endregion
    
    #region Public Methods

    /// <summary>
    /// Gets the profit.
    /// </summary>
    /// <value>The profit.</value>
    public CashValue Profit
    {
        get
        {
            return m_profit;
        }
    }

    /// <summary>
    /// Gets the tax.
    /// </summary>
    /// <value>The tax.</value>
    public CashValue Tax
    {
        get
        {
            return m_tax;
        }
    }

    /// <summary>
    /// Gets the tax rate.
    /// </summary>
    /// <value>The tax rate.</value>
    public static String TaxRate
    {
        get
        {
            return String.Format("{0:p}", TAX);
        }
    }

    /// <summary>
    /// Gets the total before tax.
    /// </summary>
    /// <value>The total before tax.</value>
    public CashValue TotalBeforeTax
    {
        get
        {
            return m_totalBeforeTax;
        }
    }

    /// <summary>
    /// Gets the total after tax.
    /// </summary>
    /// <value>The total after tax.</value>
    public CashValue TotalAfterTax
    {
        get
        {
            return new CashValue(m_totalBeforeTax.Value + m_tax.Value);
        }
    }

    /// <summary>
    /// Gets the change.
    /// </summary>
    /// <value>The change.</value>
    public Money Change
    {
        get
        {
            return m_change;
        }
    }

    /// <summary>
    /// Gets the items sold.
    /// </summary>
    /// <value>The items sold.</value>
    public ICollection<Product> ItemsSold
    {
        get
        {
            return m_products;
        }
    }

    /// <summary>
    /// Gets the number of items sold.
    /// </summary>
    /// <value>The number of items sold.</value>
    public int NumberOfItemsSold
    {
        get
        {
            var total = 0;
            foreach(Product p in m_products)
            {
                total += p.Quantity;
            }
            return total;
        }
    }

    public int SaleID
    {
        get
        {
            return m_saleId;
        }
    }
    
    #endregion
    
    #region Private Variables

    private readonly List<Product> m_products;
    private readonly Money m_change;
    private readonly CashValue m_profit;
    private readonly CashValue m_tax;
    private readonly CashValue m_totalBeforeTax;
    private readonly int m_saleId;
    private const double TAX = 0.07;
    
    #endregion
     
}
#endregion
}
