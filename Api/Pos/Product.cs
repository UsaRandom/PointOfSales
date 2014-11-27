
/*
 * Product.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -Product
 *       Encapsulates information relating to a Product Object.
 *    -StockNumber
 *       Encapsulates the int value of a stock number along with
 *       an overridden ToString method for correct display.
 *    -CashValue
 *       Encapsulates the double value of 'cash' along with an
 *       overridden ToString method for correct display.
 *  
 */

using System;
using System.Collections.Generic;
using System.Text;
using Pos.DB;

namespace Pos.Api
{

#region Class Definition : Product
public class Product
{
   
   #region Constructor
   
   /// <summary>
   /// Initializes a new instance of the <see cref="Product"/> class.
   /// </summary>
   /// <param name="name">The Name of the Product.</param>
   /// <param name="stockNumber">The Stock Number of the Product.</param>
   /// <param name="quantity">The Quantity of the Product.</param>
   /// <param name="cost">The Cost of the Product.</param>
   /// <param name="price">The Price of the Product.</param>
   public Product(string name, int stockNumber, int quantity, int cost, int price, bool discontinued)
   {
      m_productName = name;
      m_sn = new StockNumber(stockNumber);
      m_quantity = quantity;
      m_cost = new CashValue(cost);
      m_price = new CashValue(price);
      m_discontinued = discontinued;
   }

   /// <summary>
   /// Initializes a new instance of the <see cref="Product"/> class.
   /// </summary>
   /// <param name="i">The Inventory object to create a product from.</param>
   public Product(Inventory i)
   {
      m_productName = i.Item_Name;
      m_quantity = i.Quantity;
      m_sn = new StockNumber(i.Stock_Number);
      m_price = new CashValue(i.Price);
      m_cost = new CashValue(i.Cost);
      m_discontinued = i.Discontinued;
   }

   /// <summary>
   /// Initializes a new instance of the <see cref="Product"/> class.
   /// </summary>
   public Product()
   {
      ;
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Gets or Sets the Name of the Product.
   /// </summary>
   /// <param name="value">The name.</param>
   public string ItemName
   {
      get
      {
         return m_productName;
      }
      set
      {
         m_productName = value;
      }
   }

   /// <summary>
   /// Gets or Sets the Stock Number.
   /// </summary>
   /// <param name="value">The stock number.</param>
   public StockNumber SN
   {
      get
      {
         return m_sn;
      }
      set
      {
         m_sn = value;
      }
   }

   /// <summary>
   /// Gets or sets the quantity.
   /// </summary>
   /// <value>The Quantity.</value>
   public int Quantity
   {
      get
      {
         return m_quantity;
      }
      set
      {
         m_quantity = value;
      }
   }

   /// <summary>
   /// Gets or Sets the cost.
   /// </summary>
   /// <param name="value">The cost.</param>
   public CashValue Cost
   {
      get
      {
         return m_cost;
      }
      set
      {
         m_cost = value;
      }
   }

   /// <summary>
   /// Gets or Sets the price.
   /// </summary>
   /// <param name="value">The price.</param>
   public CashValue Price
   {
      get
      {
         return m_price;
      }
      set
      {
         m_price = value;
      }
   }

   /// <summary>
   /// Gets or sets a value indicating whether this <see cref="Product"/> is discontinued.
   /// </summary>
   /// <value><c>true</c> if discontinued; otherwise, <c>false</c>.</value>
   public bool Discontinued
   {
      get
      {
         return m_discontinued;
      }
      set
      {
         m_discontinued = value;
      }
   }

   /// <summary>
   /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
   /// </summary>
   /// <returns>
   /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
   /// </returns>
   public override string ToString()
   {
       return this.m_productName;
   }

   /// <summary>
   /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
   /// </summary>
   /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
   /// <returns>
   /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
   /// </returns>
   /// <exception cref="T:System.NullReferenceException">
   /// The <paramref name="obj"/> parameter is null.
   /// </exception>
   public override bool Equals(object obj)
   {
       if (!(obj is Product))
           return false;

       Product temp = obj as Product;

       if (this.SN.Equals(temp.SN))
           return true;

       return false;
   }
   
   #endregion
   
   #region Private Variables
   
   private string       m_productName;
   private StockNumber  m_sn;
   private int          m_quantity;
   private CashValue    m_cost;
   private CashValue    m_price;
   private bool         m_discontinued;
   
   #endregion
}
#endregion

#region Class Definition : StockNumber
public class StockNumber
{
   #region Constructor

   /// <summary>
   /// Initializes a new instance of the <see cref="StockNumber"/> class.
   /// </summary>
   private StockNumber()
   {
      ;
   }
   
   /// <summary>
   /// Initializes a new instance of the <see cref="StockNumber"/> class.
   /// </summary>
   /// <param name="value">The value.</param>
   public StockNumber(int value)
   {
      m_value = value;
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Gets the int value of the Stock Number.
   /// </summary>
   /// <value>The int value.</value>
   public int IntValue
   {
      get
      {
         return m_value;
      }
   }
   
   /// <summary>
   /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
   /// </summary>
   /// <returns>
   /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
   /// </returns>
   public override string ToString()
   {
      return String.Format("{0:D3}", m_value);
   }

   /// <summary>
   /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
   /// </summary>
   /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
   /// <returns>
   /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
   /// </returns>
   /// <exception cref="T:System.NullReferenceException">
   /// The <paramref name="obj"/> parameter is null.
   /// </exception>
   public override bool Equals(object obj)
   {
       StockNumber sn = obj as StockNumber;
       if(sn == null)
           return false;
       return (m_value == sn.m_value);
   }
   
   #endregion

   #region Private Variables
   
   private int    m_value;
   
   #endregion
}
#endregion

#region Class Definition : CashValue
public class CashValue
{

   #region Constructor
   
   /// <summary>
   /// Initializes a new instance of the <see cref="CashValue"/> class.
   /// </summary>
   private CashValue()
   {
      ;
   }

   /// <summary>
   /// Initializes a new instance of the <see cref="CashValue"/> class.
   /// </summary>
   /// <param name="value">The value.</param>
   public CashValue(int value)
   {
      m_value = value;
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Gets the double value for the cash.
   /// </summary>
   /// <value>The value.</value>
   public int Value
   {
      get
      {
         return m_value;
      }
   }

   /// <summary>
   /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
   /// </summary>
   /// <returns>
   /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
   /// </returns>
   public override string ToString()
   {
      return String.Format("{0:C}", ((double)m_value/(double)100));
   }

   /// <summary>
   /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
   /// </summary>
   /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
   /// <returns>
   /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
   /// </returns>
   /// <exception cref="T:System.NullReferenceException">
   /// The <paramref name="obj"/> parameter is null.
   /// </exception>
   public override bool Equals(object obj)
   {
      return obj.ToString().Equals(this.ToString());
   }

   /// <summary>
   /// Parses the specified string to a CashValue object.
   /// </summary>
   /// <param name="s">The string to parse.</param>
   /// <returns></returns>
   public static CashValue Parse(String s)
   {
       CashValue toReturn;
       try
       {
           s = s.Replace("$", String.Empty);
           double d = Double.Parse(s);
           toReturn = new CashValue((int) Math.Floor((d * (double)100)));
       }
       catch(Exception e)
       {
           throw e;
       }
       return toReturn;
   }

   /// <summary>
   /// Parses the specified d.
   /// </summary>
   /// <param name="d">The d.</param>
   /// <returns></returns>
   public static CashValue Parse(double d)
   {
       CashValue toReturn;
       try
       {
           toReturn = new CashValue((int) Math.Floor((d * (double)100)));
       }
       catch(Exception e)
       {
           throw e;
       }
       return toReturn;
   }

   /// <summary>
   /// Tries to parse.
   /// </summary>
   /// <param name="s">The s.</param>
   /// <param name="cash">The cash.</param>
   /// <returns></returns>
   public static bool TryParse(String s, out CashValue cash)
   {
       cash = null;
       try
       {
           s = s.Replace("$", String.Empty);
           double d = Double.Parse(s);
           cash = new CashValue((int) Math.Floor((d * (double)100)));
       }
       catch(Exception e)
       {
           return false;
       }
       return true;
   }

   /// <summary>
   /// Tries the parse.
   /// </summary>
   /// <param name="d">The d.</param>
   /// <param name="cash">The cash.</param>
   /// <returns></returns>
   public static bool TryParse(double d, out CashValue cash)
   {
       cash = null;
       try
       {
           cash = new CashValue((int) Math.Floor((d * (double)100)));
       }
       catch(Exception e)
       {
           return false;
       }
       return true;
   }

   
   #endregion
   
   #region Private Variables
   
   private int    m_value;
   
   #endregion
}
#endregion

}
