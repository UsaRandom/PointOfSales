
/*
 * Money.cs 
 * Author: Martin Stauber
 * 
 * Classes:
 *    -Money
 *       Encapsulates information and methods for handling the
 *       lesser ICurrency Objects.
 *    -ICurrency Objects
 *       Handles a specific currency object, Pennie, Dime, Dollar Bill, ect.
 *  
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pos.Api
{
#region Class Definition : Money
public class Money
{

   #region Constructors
   
   /// <summary>
   /// Initializes a new instance of the <see cref="Money"/> class.
   /// </summary>
   public Money()
   {
      //DO NOT CHANGE THE ORDER!!!!
      //If you must, make sure it is decending!!!!
      m_cash = new List<ICurrency> ();
      m_cash.Add(new TwentyDollarBills());
      m_cash.Add(new TenDollarBills());
      m_cash.Add(new FiveDollarBills());
      m_cash.Add(new OneDollarBills());
      m_cash.Add(new Quarters());
      m_cash.Add(new Dimes());
      m_cash.Add(new Nickels());
      m_cash.Add(new Pennies());
   }
   /// <summary>
   /// Initializes a new instance of the <see cref="Money"/> class.
   /// </summary>
   /// <param name="twenties">The twenties.</param>
   /// <param name="tens">The tens.</param>
   /// <param name="fives">The fives.</param>
   /// <param name="ones">The ones.</param>
   /// <param name="quarters">The quarters.</param>
   /// <param name="dimes">The dimes.</param>
   /// <param name="nickels">The nickels.</param>
   /// <param name="pennies">The pennies.</param>
   public Money(TwentyDollarBills twenties, TenDollarBills tens, FiveDollarBills fives, OneDollarBills ones, 
                Quarters quarters, Dimes dimes, Nickels nickels, Pennies pennies)
   {
      //DO NOT CHANGE THE ORDER!!!!
      //If you must, make sure it is decending!!!!
      m_cash = new List<ICurrency> ();
      m_cash.Add(twenties);
      m_cash.Add(tens);
      m_cash.Add(fives);
      m_cash.Add(ones);
      m_cash.Add(quarters);
      m_cash.Add(dimes);
      m_cash.Add(nickels);
      m_cash.Add(pennies);
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Debits the Money object for the given CashValue. Returns Change.
   /// </summary>
   /// <param name="toSubtract">To subtract.</param>
   /// <returns></returns>
   public Money Debit(CashValue toSubtract)
   {
      Money toReturn = new Money();
      int iterator = 0;

      if(toSubtract.Value < 0)
          throw new ArgumentException("Too little cash was given!");

      foreach(ICurrency cur in m_cash)
      {
         toReturn.m_cash[iterator] = cur.GetChange(ref toSubtract);
         iterator++;
      }
      if(toReturn.GetCashValue().Value == 0 && toSubtract.Value != 0)
          throw new ArithmeticException("Change cannot be given...");
      return toReturn;
   }

   public void Debit(Money m)
   {
       foreach(ICurrency cur in m_cash)
       {
           cur.Subtract(m.m_cash);
       }
   }

   /// <summary>
   /// Credits the Money object for the given Money Object.
   /// </summary>
   /// <param name="toAdd">Money Object to Add.</param>
   public void Credit(Money toAdd)
   {
      foreach(ICurrency cur in m_cash)
      {
         cur.Add(toAdd.m_cash);
      }
   }

   /// <summary>
   /// Credits the Money object only to the amount of CashValue.
   /// </summary>
   /// <param name="toPay">The amount of cash to Pay.</param>
   /// <param name="toAdd">The Money object paid with.</param>
   /// <returns>The change.</returns>
   public Money Credit(CashValue toPay, Money toAdd)
   {
      this.Credit(toAdd);
      Money toReturn = this.Debit(new CashValue(toAdd.GetCashValue().Value-toPay.Value));
      return toReturn;
   }

   /// <summary>
   /// Gets the cash value.
   /// </summary>
   /// <returns></returns>
   public CashValue GetCashValue()
   {
      int temp = 0;
      foreach(ICurrency cur in m_cash)
      {
         temp += cur.GetValue();
      }
      return new CashValue(temp);
   }

   /// <summary>
   /// Gets the list of ICurrency Objects.
   /// </summary>
   /// <returns></returns>
   public ICollection<ICurrency> GetListOfCash()
   {
      return m_cash;
   }
   
   #endregion
   
   #region Private Variables
   
   private List<ICurrency> m_cash;
   
   #endregion
   
}
#endregion
#region Interface Definition : ICurrency
public interface ICurrency
{

   ICurrency GetChange(ref CashValue newCashValue);

   void Subtract(List<ICurrency> cur);
   
   string GetName();
   
   int GetCount();
   
   int GetValue();
   
   void Add(List<ICurrency> cur);
   
}
#endregion
#region Class Definition : Pennies
public class Pennies : ICurrency
{
   
   #region Constructors
   
   public Pennies()
   {
      m_count = 0;
   }
   
   public Pennies(int count)
   {
      m_count = count;
   }
   
   #endregion
   
   #region Public Methods

   public void Subtract(List<ICurrency> cur)
   {
       var currency = cur.SingleOrDefault(c => c.GetType().Equals(this.GetType()));

       if(currency == null)
           throw new NullReferenceException("Once again... Good Job Numnuts!");

       this.m_count -= currency.GetCount();
   }
   
   public ICurrency GetChange(ref CashValue newCashValue)
   {
      int iter = 0;
      while(iter * VALUE <= newCashValue.Value && iter < m_count)
      {
         iter++;
         if(iter * VALUE > newCashValue.Value)
         {
            iter--;
            break;
         }
      }
      newCashValue = new CashValue(newCashValue.Value-(iter*VALUE));
      m_count -= iter;
      return new Pennies(iter);
   }
   
   public int GetValue()
   {
      return VALUE * m_count;
   }

   public int GetCount()
   {
      return m_count;
   }

   public string GetName()
   {
      if(m_count == 1)
         return NAME;
      
      return NAME + "s";
   }

   public void Add(List<ICurrency> cur)
   {
      try
      {
         var thisType = cur.Single(c => c is Pennies);
         var temp = thisType as Pennies;
         m_count += temp.m_count;
      }
      catch (Exception e)
      {
         throw e;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private const int       VALUE = 1;
   private const string    NAME = "Pennie";
   private int             m_count;
   
   #endregion
   
}
#endregion
#region Class Definition : Nickels
public class Nickels : ICurrency
{
   
   #region Constructors
   
   public Nickels()
   {
      m_count = 0;
   }
   
   public Nickels(int count)
   {
      m_count = count;
   }
   
   #endregion
   
   #region Public Methods

   public void Subtract(List<ICurrency> cur)
   {
       var currency = cur.SingleOrDefault(c => c.GetType().Equals(this.GetType()));

       if(currency == null)
           throw new NullReferenceException("Once again... Good Job Numnuts!");

       this.m_count -= currency.GetCount();
    }
   
   public ICurrency GetChange(ref CashValue newCashValue)
   {
      int iter = 0;
      while(iter * VALUE <= newCashValue.Value && iter < m_count)
      {
         iter++;
         if(iter * VALUE > newCashValue.Value)
         {
            iter--;
            break;
         }
      }
      newCashValue = new CashValue(newCashValue.Value-(iter*VALUE));
      m_count -= iter;
      return new Nickels(iter);
   }
   
   public int GetValue()
   {
      return VALUE * m_count;
   }

   public int GetCount()
   {
      return m_count;
   }

   public string GetName()
   {
      if(m_count == 1)
         return NAME;
      
      return NAME + "s";
   }

   public void Add(List<ICurrency> cur)
   {
      try
      {
         var thisType = cur.Single(c => c is Nickels);
         var temp = thisType as Nickels;
         m_count += temp.m_count;
      }
      catch (Exception e)
      {


         throw e;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private const int       VALUE = 5;
   private const string    NAME = "Nickel";
   private int             m_count;
   
   #endregion
   
}
#endregion
#region Class Definition : Dimes
public class Dimes : ICurrency
{
   
   #region Constructors
   
   public Dimes()
   {
      m_count = 0;
   }
   
   public Dimes(int count)
   {
      m_count = count;
   }
   
   #endregion
   
   #region Public Methods

   public void Subtract(List<ICurrency> cur)
   {
       var currency = cur.SingleOrDefault(c => c.GetType().Equals(this.GetType()));

       if(currency == null)
           throw new NullReferenceException("Once again... Good Job Numnuts!");

       this.m_count -= currency.GetCount();
   }
   
   public ICurrency GetChange(ref CashValue newCashValue)
   {
      int iter = 0;
      while(iter * VALUE <= newCashValue.Value && iter < m_count)
      {
         iter++;
         if(iter * VALUE > newCashValue.Value)
         {
            iter--;
            break;
         }
      }
      newCashValue = new CashValue(newCashValue.Value-(iter*VALUE));
      m_count -= iter;
      return new Dimes(iter);
   }
   
   public int GetValue()
   {
      return VALUE * m_count;
   }

   public int GetCount()
   {
      return m_count;
   }

   public string GetName()
   {
      if(m_count == 1)
         return NAME;
      
      return NAME + "s";
   }

   public void Add(List<ICurrency> cur)
   {
      try
      {
         var thisType = cur.Single(c => c is Dimes);
         var temp = thisType as Dimes;
         m_count += temp.m_count;
      }
      catch (Exception e)
      {

         throw e;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private const int       VALUE = 10;
   private const string    NAME = "Dime";
   private int             m_count;
   
   #endregion
   
}
#endregion
#region Class Definition : Quarters
public class Quarters : ICurrency
{
   
   #region Constructors
   
   public Quarters()
   {
      m_count = 0;
   }
   
   public Quarters(int count)
   {
      m_count = count;
   }
   
   #endregion
   
   #region Public Methods

   public void Subtract(List<ICurrency> cur)
   {
       var currency = cur.SingleOrDefault(c => c.GetType().Equals(this.GetType()));

       if(currency == null)
           throw new NullReferenceException("Once again... Good Job Numnuts!");

       this.m_count -= currency.GetCount();
   }

   public ICurrency GetChange(ref CashValue newCashValue)
   {
      int iter = 0;
      while(iter * VALUE <= newCashValue.Value && iter < m_count)
      {
         iter++;
         if(iter * VALUE > newCashValue.Value)
         {
            iter--;
            break;
         }
      }
      newCashValue = new CashValue(newCashValue.Value-(iter*VALUE));
      m_count -= iter;
      return new Quarters(iter);
   }
   
   public int GetValue()
   {
      return VALUE * m_count;
   }

   public int GetCount()
   {
      return m_count;
   }

   public string GetName()
   {
      if(m_count == 1)
         return NAME;
      
      return NAME + "s";
   }

   public void Add(List<ICurrency> cur)
   {
      try
      {
         var thisType = cur.Single(c => c is Quarters);
         var temp = thisType as Quarters;
         m_count += temp.m_count;
      }
      catch (Exception e)
      {

         throw e;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private const int       VALUE = 25;
   private const string    NAME = "Quarter";
   private int             m_count;
   
   #endregion
   
}
#endregion
#region Class Definition : OneDollarBills
public class OneDollarBills : ICurrency
{
 
   #region Constructors
   
   public OneDollarBills()
   {
      m_count = 0;
   }
   
   public OneDollarBills(int count)
   {
      m_count = count;
   }
   
   #endregion
   
   #region Public Methods

   public void Subtract(List<ICurrency> cur)
   {
       var currency = cur.SingleOrDefault(c => c.GetType().Equals(this.GetType()));

       if(currency == null)
           throw new NullReferenceException("Once again... Good Job Numnuts!");

       this.m_count -= currency.GetCount();
   }
   
   public ICurrency GetChange(ref CashValue newCashValue)
   {
      int iter = 0;
      while(iter * VALUE <= newCashValue.Value && iter < m_count)
      {
         iter++;
         if(iter * VALUE > newCashValue.Value)
         {
            iter--;
            break;
         }
      }
      newCashValue = new CashValue(newCashValue.Value-(iter*VALUE));
      m_count -= iter;
      return new OneDollarBills(iter);
   }
   
   public int GetValue()
   {
      return VALUE * m_count;
   }

   public int GetCount()
   {
      return m_count;
   }

   public string GetName()
   {
      if(m_count == 1)
         return NAME;
      
      return NAME + "s";
   }

   public void Add(List<ICurrency> cur)
   {
      try
      {
         var thisType = cur.Single(c => c is OneDollarBills);
         var temp = thisType as OneDollarBills;
         m_count += temp.m_count;
      }
      catch (Exception e)
      {
         throw e;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private const int       VALUE = 100;
   private const string    NAME = "One Dollar Bill";
   private int             m_count;
   
   #endregion
   
}
#endregion
#region Class Definition :  FiveDollayBills
public class FiveDollarBills : ICurrency
{
 
   #region Constructors
   
   public FiveDollarBills()
   {
      m_count = 0;
   }
   
   public FiveDollarBills(int count)
   {
      m_count = count;
   }
   
   #endregion
   
   #region Public Methods

   public void Subtract(List<ICurrency> cur)
   {
       var currency = cur.SingleOrDefault(c => c.GetType().Equals(this.GetType()));

       if(currency == null)
           throw new NullReferenceException("Once again... Good Job Numnuts!");

       this.m_count -= currency.GetCount();
   }
   
   public ICurrency GetChange(ref CashValue newCashValue)
   {
      int iter = 0;
      while(iter * VALUE <= newCashValue.Value && iter < m_count)
      {
         iter++;
         if(iter * VALUE > newCashValue.Value)
         {
            iter--;
            break;
         }
      }
      newCashValue = new CashValue(newCashValue.Value-(iter*VALUE));
      m_count -= iter;
      return new FiveDollarBills(iter);
   }
   
   public int GetValue()
   {
      return VALUE * m_count;
   }

   public int GetCount()
   {
      return m_count;
   }

   public string GetName()
   {
      if(m_count == 1)
         return NAME;
      
      return NAME + "s";
   }

   public void Add(List<ICurrency> cur)
   {
      try
      {
         var thisType = cur.Single(c => c is FiveDollarBills);
         var temp = thisType as FiveDollarBills;
         m_count += temp.m_count;
      }
      catch (Exception e)
      {
         throw e;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private const int       VALUE = 500;
   private const string    NAME = "Five Dollar Bill";
   private int             m_count;
   
   #endregion
   
}
#endregion
#region Class Definition : TenDollarBills
public class TenDollarBills :  ICurrency
{
    
   #region Constructors
   
   public TenDollarBills()
   {
      m_count = 0;
   }
   
   public TenDollarBills(int count)
   {
      m_count = count;
   }
   
   #endregion
   
   #region Public Methods

   public void Subtract(List<ICurrency> cur)
   {
       var currency = cur.SingleOrDefault(c => c.GetType().Equals(this.GetType()));

       if(currency == null)
           throw new NullReferenceException("Once again... Good Job Numnuts!");

       this.m_count -= currency.GetCount();
   }
   
   public ICurrency GetChange(ref CashValue newCashValue)
   {
      int iter = 0;
      while(iter * VALUE <= newCashValue.Value && iter < m_count)
      {
         iter++;
         if(iter * VALUE > newCashValue.Value)
         {
            iter--;
            break;
         }
      }
      newCashValue = new CashValue(newCashValue.Value-(iter*VALUE));
      m_count -= iter;
      return new TenDollarBills(iter);
   }
   
   public int GetValue()
   {
      return VALUE * m_count;
   }

   public int GetCount()
   {
      return m_count;
   }

   public string GetName()
   {
      if(m_count == 1)
         return NAME;
      
      return NAME + "s";
   }

   public void Add(List<ICurrency> cur)
   {
      try
      {
         var thisType = cur.Single(c => c is TenDollarBills);
         var temp = thisType as TenDollarBills;
         m_count += temp.m_count;
      }
      catch (Exception e)
      {
         throw e;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private const int       VALUE = 1000;
   private const string    NAME = "Ten Dollar Bill";
   private int             m_count;
   
   #endregion
   
}
#endregion
#region Class Definition : TwentyDollarBills
public class TwentyDollarBills : ICurrency
{
    
   #region Constructors
   
   public TwentyDollarBills()
   {
      m_count = 0;
   }
   
   public TwentyDollarBills(int count)
   {
      m_count = count;
   }
   
   #endregion
   
   #region Public Methods

   public void Subtract(List<ICurrency> cur)
   {
       var currency = cur.SingleOrDefault(c => c.GetType().Equals(this.GetType()));

       if(currency == null)
           throw new NullReferenceException("Once again... Good Job Numnuts!");

       this.m_count -= currency.GetCount();
   }
   
   public ICurrency GetChange(ref CashValue newCashValue)
   {
      int iter = 0;
      while(iter * VALUE <= newCashValue.Value && iter < m_count)
      {
         iter++;
         if(iter * VALUE > newCashValue.Value)
         {
            iter--;
            break;
         }
      }
      newCashValue = new CashValue(newCashValue.Value-(iter*VALUE));
      m_count -= iter;
      return new TwentyDollarBills(iter);
   }
   
   public int GetValue()
   {
      return VALUE * m_count;
   }

   public int GetCount()
   {
      return m_count;
   }

   public string GetName()
   {
      if(m_count == 1)
         return NAME;
      
      return NAME + "s";
   }

   public void Add(List<ICurrency> cur)
   {
      try
      {
         var thisType = cur.Single(c => c is TwentyDollarBills);
         var temp = thisType as TwentyDollarBills;
         m_count += temp.m_count;
      }
      catch (Exception e)
      {
         throw e;
      }
   }
   
   #endregion
   
   #region Private Variables
   
   private const int    VALUE = 2000;
   private const string    NAME = "Twenty Dollar Bill";
   private int             m_count;
   
   #endregion
  
}
#endregion
}
