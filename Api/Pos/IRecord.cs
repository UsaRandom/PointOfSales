/*
 * Money.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -IRecord
 *       Interface for Record keeping...
 *  
 */
 
using System.Collections.Generic;
using Pos.Api;
using System;

namespace Pos.DB
{
#region Interface Definition : IRecord
public interface IRecord
{
   void Save(ICollection<Product> products);
   ICollection<Product> Load();
   bool Test(out Exception e);
}
#endregion
}