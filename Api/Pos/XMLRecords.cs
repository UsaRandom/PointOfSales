
/*
 * XMLRecords.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -XMLRecords
 *       Provides methods for loading and saving from an XML file.
 *    -XMLSerializationException
 *       Provides a definition for an XML Exception
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using Pos.Api;

namespace Pos.DB
{

#region Class Definition : XMLRecords
public class XMLRecords : IRecord
{
   
   #region Constructor
   
   /// <summary>
   /// Initializes a new instance of the <see cref="XMLRecords"/> class.
   /// </summary>
   private XMLRecords()
   {
      ;
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Loads the Products from the specified file.
   /// </summary>
   /// <returns></returns>
   public ICollection<Product> Load()
   {
      if(!File.Exists(m_fileSaveLocation))
         throw new FileNotFoundException("Cannot find XML File!");
      
      if(m_useSchema && !File.Exists(m_schemaFileLocation))
         throw new FileNotFoundException("Cannot find schema file!");
      
      if(m_useSchema && !XsdValidator.Validate(m_fileSaveLocation, m_schemaFileLocation))
         throw new XMLSerializationException();
      
      ICollection<Product> products = new List<Product>();
      
      using (StreamReader reader = new StreamReader(new FileStream(m_fileSaveLocation, FileMode.Open)))
      {
         XElement element = XElement.Parse(reader.ReadToEnd());
         products = Serializer.Instance.Deserialize(element);
      }
      
      return products;
   }

   /// <summary>
   /// Saves the specified products.
   /// </summary>
   /// <param name="products">The products to save.</param>
   public void Save(ICollection<Product> products)
   {
     FileStream fs = null;
     if(!File.Exists(m_fileSaveLocation))
         fs = File.Create(m_fileSaveLocation);
      
      XElement element = Serializer.Instance.Serialize(products);
      if(fs == null)
      {
         using(StreamWriter writer = new StreamWriter(new FileStream(m_fileSaveLocation, FileMode.Truncate)))
         {
            writer.Write(element.ToString());
         }
      }
      else
      {
         using(StreamWriter writer = new StreamWriter(fs))
         {
            writer.Write(element.ToString());
         }
      }
      
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
   /// Gets or sets a value indicating whether [use validation].
   /// </summary>
   /// <value><c>true</c> if [use validation]; otherwise, <c>false</c>.</value>
   public static bool UseValidation
   {
      get
      {
         return m_useSchema;
      }
      set
      {
         m_useSchema = value;
      }
   }
   
   /// <summary>
   /// Gets or sets the file location.
   /// </summary>
   /// <value>The file location.</value>
   public static string FileLocation
   {
      get
      {
         return m_fileSaveLocation;
      }
      set
      {
         m_fileSaveLocation = value;
      }
   }

   /// <summary>
   /// Gets or sets the schema location.
   /// </summary>
   /// <value>The schema location.</value>
   public static string SchemaLocation
   {
      get
      {
         return m_schemaFileLocation;
      }
      set
      {
         m_schemaFileLocation = value;
      }
   }

   /// <summary>
   /// Gets the singleton Instance of XMLRecords.
   /// </summary>
   /// <value>The instance.</value>
   public static XMLRecords Instance
   {
      get
      {
         if(m_instance == null)
            m_instance = new XMLRecords();
            
         return m_instance;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private static bool m_useSchema = false;
   private static XMLRecords m_instance;
   private static string m_fileSaveLocation;
   private static string m_schemaFileLocation;
   
   #endregion
   
}
#endregion

#region Class Definition : XMLSerializationException
class XMLSerializationException : Exception
{
   #region Constructor
   public XMLSerializationException()
   {}
   public XMLSerializationException(string message) : base(message)
   {}
   #endregion
}
#endregion

}
