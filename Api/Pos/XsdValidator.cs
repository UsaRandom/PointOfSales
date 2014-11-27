#pragma warning disable
/*
 * XsdValidator.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -XsdValidator
 *       Provides methods for validating a XML file to a Schema
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Schema;

namespace Pos.DB
{
#region Class Definition : XsdValidator
class XsdValidator
{
   
   #region Public Methods

   /// <summary>
   /// Validates the specified file to a schema.
   /// </summary>
   /// <param name="filename">The filename.</param>
   /// <param name="schemaFile">The schema file.</param>
   /// <returns></returns>
   public static bool Validate(string filename, string schemaFile)
   {
      if(filename == null || filename.Length == 0)
         throw new ArgumentException("Filename");
         
      if(schemaFile == null || schemaFile.Length == 0)
         throw new ArgumentException("SchemaFile");
      
      StreamReader  reader;
      string xml;
      XElement element;
      
      reader = new StreamReader (filename);
      xml = reader.ReadToEnd();
      reader.Close ();

      try
      {
         element = XElement.Parse(xml);
      }
      catch
      {
         return false;
      }
      
      return Validate(element, schemaFile);
   }

   /// <summary>
   /// Validates the specified XElement to a schema.
   /// </summary>
   /// <param name="element">The element.</param>
   /// <param name="schemaFile">The schema file.</param>
   /// <returns></returns>
   public static bool Validate(XElement element, string schemaFile)
   {
      if (element == null)
         throw new ArgumentNullException ("element");
      
      if (schemaFile == null || schemaFile.Length == 0)
         throw new ArgumentNullException ("SchemaFile");
      
      XmlValidatingReader reader = null;
      XmlSchemaCollection myschema = new XmlSchemaCollection();

      try
      {
         string xml = element.ToString ();

         XmlParserContext context = new XmlParserContext (null, null, "", XmlSpace.None);

         reader = new XmlValidatingReader(xml, XmlNodeType.Element, context);
         myschema.Add (String.Empty, schemaFile);
         
         reader.ValidationType = ValidationType.Schema;
         reader.Schemas.Add(myschema);
         
         while (reader.Read());

         return true;
      }
      catch
      {
         return false;
      }
   }

   #endregion
      
}
#endregion
}
