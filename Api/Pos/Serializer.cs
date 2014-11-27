
/*
 * Serializer.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -Serializer
 *       Serializes a List of Products.
 *    -ProductSerializer
 *       Serializes a single instance of a Product.
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
#region Class Definition : Serializer
class Serializer
{

   #region Constructor

   /// <summary>
   /// Initializes a new instance of the <see cref="Serializer"/> class.
   /// </summary>
   private Serializer()
   {
      ;
   }
   
   #endregion

   #region Public Methods
   
   /// <summary>
   /// Serializes the specified Collection of Products.
   /// </summary>
   /// <param name="products">The products to Serialize.</param>
   /// <returns></returns>
   public XElement Serialize(ICollection<Product> products)
   {
      XElement element = new XElement("Products");
      
      foreach(Product p in products)
      {
         element.Add(ProductSerializer.Instance.Serialize(p));
      }
      
      return element;
   }

   /// <summary>
   /// Deserializes the specified element.
   /// </summary>
   /// <param name="element">The element.</param>
   /// <returns></returns>
   public ICollection<Product> Deserialize(XElement element)
   {
      List<Product> products = new List<Product>();
      
      foreach(XElement x in element.Elements("Product"))
      {
         products.Add(ProductSerializer.Instance.Deserialize(x));
      }
      
      return products;
   }

   /// <summary>
   /// Gets the singleton Instance of the Serializer.
   /// </summary>
   /// <value>The instance.</value>
   public static Serializer Instance
   {
      get
      {
         if(m_instance == null)
            m_instance = new Serializer();
         
         return m_instance;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private static Serializer m_instance;
   
   #endregion
   
}
#endregion

#region Class Definition : ProductSerializer
class ProductSerializer
{
   #region Constructor

   /// <summary>
   /// Initializes a new instance of the <see cref="ProductSerializer"/> class.
   /// </summary>
   private ProductSerializer()
   {
      ;
   }
      
   #endregion

   #region Public Methods

   /// <summary>
   /// Serializes the specified product to an XElement.
   /// </summary>
   /// <param name="product">The product to Serialize.</param>
   /// <returns></returns>
   public XElement Serialize(Product product)
   {
      if(product == null)
         return null;
      
      return 
         new XElement("Product",
            new XElement("Item_Name", product.ItemName),
            new XElement("Stock_Number", product.SN.IntValue),
            new XElement("Quantity", product.Quantity),
            new XElement("Cost", product.Cost.Value),
            new XElement("Price", product.Price.Value),
            new XElement("Discontinued", product.Discontinued));
   }

   /// <summary>
   /// Deserializes the specified element to a Product Object.
   /// </summary>
   /// <param name="element">The element to deserialize.</param>
   /// <returns></returns>
   public Product Deserialize(XElement element)
   {
      Product product = new Product();
      
      XElement e;
      int      tempInt;
      bool     tempBool;
      
      e = element.Element("Item_Name");
      if(e != null)
         product.ItemName = e.Value;
      
      e = element.Element("Stock_Number");
      if(e != null && Int32.TryParse(e.Value, out tempInt))
         product.SN = new StockNumber(tempInt);
      
      e = element.Element("Quantity");
      if(e != null && Int32.TryParse(e.Value, out tempInt))
         product.Quantity = tempInt;
         
      e = element.Element("Cost");
      if(e != null && Int32.TryParse(e.Value, out tempInt))
         product.Cost = new CashValue(tempInt);
      
      e = element.Element("Price");
      if(e != null && Int32.TryParse(e.Value, out tempInt))
         product.Price = new CashValue(tempInt);
      
      e = element.Element("Discontinued");
      if(e != null && Boolean.TryParse(e.Value, out tempBool))
         product.Discontinued = tempBool;
      
      return product;
   }

   /// <summary>
   /// Gets the instance.
   /// </summary>
   /// <value>The instance.</value>
   public static ProductSerializer Instance
   {
      get
      {
         if(m_instance == null)
            m_instance = new ProductSerializer();
          
         return m_instance;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private static ProductSerializer m_instance;
   
   #endregion
   
}
#endregion
}
