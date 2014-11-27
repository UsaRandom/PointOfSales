using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pos.Api;

namespace Pos.UI
{
#region Class Definition : MoneySelectorUI
public partial class CashUpdaterUI : Form, IDisposable
{

   #region Constructor
   
   /// <summary>
   /// Initializes a new instance of the <see cref="MoneySelectorUI"/> class.
   /// </summary>
   /// <param name="goal">The goal.</param>
   public CashUpdaterUI(Money old)
   {
      InitializeComponent();
      foreach(ICurrency cur in old.GetListOfCash())
      {
          if(cur is TwentyDollarBills)
              m_numTwenty.Value = cur.GetCount();
          else if(cur is TenDollarBills)
              m_numTen.Value = cur.GetCount();
          else if(cur is FiveDollarBills)
              m_numFive.Value = cur.GetCount();
          else if(cur is OneDollarBills)
              m_numOne.Value = cur.GetCount();
          else if(cur is Quarters)
              m_numQuarters.Value = cur.GetCount();
          else if(cur is Dimes)
              m_numDimes.Value = cur.GetCount();
          else if(cur is Nickels)
              m_numNickels.Value = cur.GetCount();
          else if(cur is Pennies)
              m_numPennies.Value = cur.GetCount();
          else
              throw new ArgumentException("lol, good job Numnuts");
      }
      this.m_cash = new Money();
      updateTotal();
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Gets the cash.
   /// </summary>
   /// <value>The cash.</value>
   public Money Cash
   {
      get
      {
         return this.m_cash;
      }
   }
   
   #endregion
   
   #region Privar Methods

   /// <summary>
   /// Handles the Load event of the MoneySelectorUI control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void MoneySelectorUI_Load(object sender, EventArgs e)
   {
      this.AcceptButton = acceptButton;
      this.CancelButton = cancelButton;
      this.CancelButton.DialogResult = DialogResult.Cancel;
      this.AcceptButton.DialogResult = DialogResult.OK;
   }

   /// <summary>
   /// Handles the Click event of the picTwenty control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void picTwenty_Click(object sender, EventArgs e)
   {
      m_numTwenty.Value++;
      updateTotal();
   }

   /// <summary>
   /// Handles the Click event of the picTen control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void picTen_Click(object sender, EventArgs e)
   {
      m_numTen.Value++;
      updateTotal();
   }

   /// <summary>
   /// Handles the Click event of the picFive control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void picFive_Click(object sender, EventArgs e)
   {
      m_numFive.Value++;
      updateTotal();
   }

   /// <summary>
   /// Handles the Click event of the picOne control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void picOne_Click(object sender, EventArgs e)
   {
      m_numOne.Value++;
      updateTotal();
   }

   /// <summary>
   /// Handles the Click event of the picQuarter control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void picQuarter_Click(object sender, EventArgs e)
   {
      m_numQuarters.Value++;
      updateTotal();
   }

   /// <summary>
   /// Handles the Click event of the picDime control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void picDime_Click(object sender, EventArgs e)
   {
      m_numDimes.Value++;
      updateTotal();
   }

   /// <summary>
   /// Handles the Click event of the picNickel control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void picNickel_Click(object sender, EventArgs e)
   {
      m_numNickels.Value++;
      updateTotal();
   }

   /// <summary>
   /// Handles the Click event of the picPennie control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void picPennie_Click(object sender, EventArgs e)
   {
      m_numPennies.Value++;
      updateTotal();
   }

   /// <summary>
   /// Updates the total.
   /// </summary>
   private void updateTotal()
   {
      m_cash = new Money(new TwentyDollarBills((int)m_numTwenty.Value),
                          new TenDollarBills((int)m_numTen.Value),
                          new FiveDollarBills((int)m_numFive.Value),
                          new OneDollarBills((int)m_numOne.Value),
                          new Quarters((int)m_numQuarters.Value),
                          new Dimes((int)m_numDimes.Value),
                          new Nickels((int) m_numNickels.Value),
                          new Pennies((int)m_numPennies.Value));
     
      totalLbl.Text = "Total: " + m_cash.GetCashValue();

   }

   /// <summary>
   /// Handles the ValueChanged event of the m_numTwenty control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void m_numTwenty_ValueChanged(object sender, EventArgs e)
   {
            updateTotal();
   }

   /// <summary>
   /// Handles the ValueChanged event of the m_numTen control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void m_numTen_ValueChanged(object sender, EventArgs e)
   {
            updateTotal();
   }

   /// <summary>
   /// Handles the ValueChanged event of the m_numFive control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void m_numFive_ValueChanged(object sender, EventArgs e)
   {
            updateTotal();
   }

   /// <summary>
   /// Handles the ValueChanged event of the m_numOne control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void m_numOne_ValueChanged(object sender, EventArgs e)
   {
            updateTotal();
   }

   /// <summary>
   /// Handles the ValueChanged event of the m_numQuarters control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void m_numQuarters_ValueChanged(object sender, EventArgs e)
   {
            updateTotal();
   }

   /// <summary>
   /// Handles the ValueChanged event of the m_numDimes control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void m_numDimes_ValueChanged(object sender, EventArgs e)
   {
            updateTotal();
   }

   /// <summary>
   /// Handles the ValueChanged event of the m_numNickels control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void m_numNickels_ValueChanged(object sender, EventArgs e)
   {
            updateTotal();
   }

   /// <summary>
   /// Handles the ValueChanged event of the m_numPennies control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void m_numPennies_ValueChanged(object sender, EventArgs e)
   {
            updateTotal();
   }
   
   #endregion
   
   #region Private Variables
      
   private Money m_cash;
   
   #endregion

}
#endregion
}
