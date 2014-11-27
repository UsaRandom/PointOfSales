using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pos.Api;

namespace Pos.Api
{
#region Class Definition : Report

public class Report
{
   
   #region Constructor

   /// <summary>
   /// Initializes a new instance of the <see cref="Report"/> class.
   /// </summary>
   public Report()
   {
      m_receipts = new List<Receipt>();
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
         int temp = 0;
         foreach(Receipt receipt in m_receipts)
         {
            temp += receipt.Profit.Value;
         }
         return new CashValue(temp);
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
         int temp = 0;
         foreach(Receipt receipt in m_receipts)
         {
            temp += receipt.TotalBeforeTax.Value;
         }
         return new CashValue(temp);
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
         int temp = 0;
         foreach(Receipt receipt in m_receipts)
         {
            temp += receipt.TotalAfterTax.Value;
         }
         return new CashValue(temp);
      }
   }

   /// <summary>
   /// Gets the tax collected.
   /// </summary>
   /// <value>The tax collected.</value>
   public CashValue TaxCollected
   {
      get
      {
         int temp = 0;
         foreach(Receipt receipt in m_receipts)
         {
            temp += receipt.Tax.Value;
         }
         return new CashValue(temp);
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
         List<Product> toReturn = new List<Product>();
         foreach(Receipt receipt in m_receipts)
         {
            foreach(Product product in receipt.ItemsSold)
            {
               var proInReturn = toReturn.SingleOrDefault(p => p.SN.Equals(product));

               if(proInReturn == null)
                   toReturn.Add(product);
               else
                   proInReturn.Quantity += product.Quantity;

            }
         }
         return toReturn;
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

            foreach(Receipt r in m_receipts)
            {
                total += r.NumberOfItemsSold;
            }

            return total;
       }
   }

   /// <summary>
   /// Gets or sets the receipts.
   /// </summary>
   /// <value>The receipts.</value>
   public ICollection<Receipt> Receipts
   {
      get
      {
         return m_receipts;
      }
      set
      {
         m_receipts = value as List<Receipt>;
      }
   }

    #endregion


    #region Private Variables

    private List<Receipt> m_receipts;

    #endregion

    }
    #endregion
}
