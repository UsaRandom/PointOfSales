/*
 * Inventory.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -Inventory 
 *          Overloaded Constructor for Easily creating Inventories from Product
 *          Objects.
 *  
 */

namespace Pos.Api
{
partial class Inventory
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Inventory"/> class.
    /// </summary>
    /// <param name="p">The p.</param>
    public Inventory(Product p)
    {
        this.Cost = p.Cost.Value;
        this.Discontinued = p.Discontinued;
        this.Item_Name = p.ItemName;
        this.Price = p.Price.Value;
        this.Quantity = p.Quantity;
        this.Stock_Number = p.SN.IntValue;
    }
}
}
