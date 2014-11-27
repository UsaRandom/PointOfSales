/*
 * Register.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -Register
 *       Holds information about the current Register such as
 *       a list of product objects, and how much money is in
 *       the register.
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pos.DB;

namespace Pos.Api
{
#region Class Definition : Register
public class Register
{

   #region Constructors

   /// <summary>
   /// Initializes a new instance of the <see cref="Register"/> class. Uses the default
   /// starting cash counts.
   /// </summary>
   /// <param name="record">The record to load the products data from.</param>
   public Register(IRecord record)
   {
      m_products = record.Load() as List<Product>;
      m_record = record;
      m_cash = new Money(new TwentyDollarBills((int)StartingCashCount.TwentyDollarBills),
                         new TenDollarBills((int)StartingCashCount.TenDollarBills),
                         new FiveDollarBills((int)StartingCashCount.FiveDollarBills),
                         new OneDollarBills((int)StartingCashCount.OneDollarBills),
                         new Quarters((int)StartingCashCount.Quarters),
                         new Dimes((int)StartingCashCount.Dimes),
                         new Nickels((int)StartingCashCount.Nickels),
                         new Pennies((int)StartingCashCount.Pennies));
   }

   /// <summary>
   /// Initializes a new instance of the <see cref="Register"/> class.
   /// </summary>
   /// <param name="record">The record to load the products data from.</param>
   /// <param name="cash">The starting cash.</param>
   public Register(IRecord record, Money cash)
   {
      m_products = record.Load() as List<Product>;
      m_cash = cash;
      m_record = record;
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Gets or sets the cash.
   /// </summary>
   /// <value>The cash.</value>
   public Money Cash
   {
      get
      {
         return m_cash;
      }
      set
      {
         m_cash = value;
      }
   }
   
   /// <summary>
   /// Gets or sets the products.
   /// </summary>
   /// <value>The products.</value>
   public ICollection<Product> Products
   {
      get
      {
         return m_products;
      }
      set
      {
         m_products = value as List<Product>;
      }
   }

   /// <summary>
   /// Saves this Products.
   /// </summary>
   public void Save()
   {
      m_record.Save(m_products);
   }
   
   #endregion
   
   #region Private Variables
   
   private Money m_cash;
   private IRecord m_record;
   private List<Product> m_products;
   
   private enum StartingCashCount
   {
      Pennies = 100,
      Nickels = 100,
      Dimes = 100,
      Quarters = 100,
      OneDollarBills = 50,
      FiveDollarBills = 25,
      TenDollarBills = 10,
      TwentyDollarBills = 5
   }
   
   #endregion
   
}
#endregion
}
