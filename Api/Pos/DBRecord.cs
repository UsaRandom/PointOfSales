
/*
 * PosDB.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -DBRecord
 *       Handles the interface with the Database.
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Pos.Api;

namespace Pos.DB
{
#region Class Definition : PosDB
public class DBRecord : IRecord
{

   #region Constructor
   
   /// <summary>
   /// Initializes a new instance of the <see cref="DBRecord"/> class.
   /// </summary>
   private DBRecord()
   {
      ;
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Saves the specified products.
   /// </summary>
   /// <param name="products">The products to save.</param>
   public void Save(ICollection<Product> products)
   {
      foreach(Product p in products)
      {
         var inven = m_db.Inventories.SingleOrDefault(i => i.Stock_Number == p.SN.IntValue);
         

         if(inven == null)
         {
             Inventory i = new Inventory(p);
             m_db.Inventories.InsertOnSubmit(i);
             continue;
         }

         inven.Quantity = p.Quantity;
         inven.Price = p.Price.Value;
         inven.Item_Name = p.ItemName;
         inven.Discontinued = p.Discontinued;
         inven.Cost = p.Cost.Value;
      }

      m_db.SubmitChanges();
   }
   
  
   /// <summary>
   /// Gets all the products.
   /// </summary>
   /// <returns></returns>
   public ICollection<Product> Load()
   {
      List<Product> products = new List<Product>();
      
      var invs = from i
                 in m_db.Inventories
                 select i;
                 
      foreach(Inventory i in invs)
      {
         products.Add(new Product(i));
      }
      
      return products;
   }

   /// <summary>
   /// Tests the specified exc.
   /// </summary>
   /// <param name="exc">The exc.</param>
   /// <returns></returns>
   public bool Test(out Exception exc)
   {
      exc = null;
      try
      {
         List<Product> testProducts = this.Load() as List<Product>;
      }
      catch(Exception e)
      {
          Console.Error.WriteLine(e.Message);
          exc = e;
          return false;
      }
      return true;
   }

   /// <summary>
   /// Sets the connection string.
   /// </summary>
   /// <value>The connection string.</value>
   public static string ConnectionString
   {
      set
      {
         m_singleton = new DBRecord();
         m_connectionString = value;
         m_singleton.m_db = new InventoryDataContext(m_connectionString);
      }
   }

   /// <summary>
   /// Gets the singleton instance of the DB.
   /// </summary>
   /// <returns></returns>
   public static DBRecord Instance
   {
      get
      {
         if(m_singleton == null)
            return null;
            
         return m_singleton;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private static DBRecord          m_singleton;
   private static string            m_connectionString;
   private InventoryDataContext     m_db;
   
   #endregion
   
}
#endregion
}
