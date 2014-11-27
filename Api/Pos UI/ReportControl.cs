using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pos.Api;

namespace Pos.UI
{
public partial class ReportControl : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportControl"/> class.
    /// </summary>
    /// <param name="report">The report.</param>
    public ReportControl(ref Report report, ref Register register)
    {
        InitializeComponent();
        m_report = report;
        m_register = register;
    }


    /// <summary>
    /// Handles the Load event of the ReportControl control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void ReportControl_Load(object sender, EventArgs e)
    {
        UpdateReport();
    }

    /// <summary>
    /// Updates the report.
    /// </summary>
    public void UpdateReport()
    {
        listOfSales.Rows.Clear();

        foreach(Receipt receipt in m_report.Receipts)
        {
            var index = listOfSales.Rows.Add();

            listOfSales.Rows[index].Cells[0].Value = receipt.SaleID;
            listOfSales.Rows[index].Cells[1].Value = receipt.NumberOfItemsSold;
            listOfSales.Rows[index].Cells[2].Value = receipt.TotalBeforeTax;
            listOfSales.Rows[index].Cells[3].Value = receipt.Tax;
            listOfSales.Rows[index].Cells[4].Value = receipt.TotalAfterTax;
            listOfSales.Rows[index].Cells[5].Value = receipt.Profit;

        }

        itemsTotalLbl.Text = m_report.NumberOfItemsSold.ToString();
        taxTotalLbl.Text = m_report.TaxCollected.ToString();
        subTotalLbl.Text = m_report.TotalBeforeTax.ToString();
        totalLbl.Text = m_report.TotalAfterTax.ToString();
        profitLbl.Text = m_report.Profit.ToString();

        listOfCash.Items.Clear();

        foreach(ICurrency cur in m_register.Cash.GetListOfCash())
        {
            listOfCash.Items.Add(String.Format("{0} {1}",
                                 cur.GetCount(),
                                 cur.GetName()));
        }

    }


    private Report m_report;
    private Register m_register;

    private void updateButton_Click(object sender, EventArgs e)
    {
        CashUpdaterUI updater = new CashUpdaterUI(m_register.Cash);
        DialogResult tempDR;

        tempDR = updater.ShowDialog();

        if(tempDR != DialogResult.OK)
            return;
        
        m_register.Cash = updater.Cash;
        UpdateReport();
    }

    private void listOfSales_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
    {
        if(e.ColumnIndex < 0)
            return;
        if(e.RowIndex < 0)
            return;
        try
        {
            listOfSales.ClearSelection();
            listOfSales.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }
        catch
        {}
    }

    private void viewSaleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var rowIndex = listOfSales.SelectedCells[0].RowIndex;
            var saleId = Int32.Parse(listOfSales.Rows[rowIndex].Cells[0].Value.ToString());
            var receipt = m_report.Receipts.Single(r => r.SaleID == saleId);
            new SaleDetailForm(receipt).ShowDialog();
        }
        catch
        {

        }
    }
}
}
