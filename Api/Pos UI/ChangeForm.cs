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
public partial class ChangeForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeForm"/> class.
    /// </summary>
    /// <param name="change">The change.</param>
    public ChangeForm(Money change)
    {
        m_change = change;
        InitializeComponent();
        totalLbl.Text = "Total: " + change.GetCashValue();
        AcceptButton = okButton;
        AcceptButton.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Handles the Load event of the ChangeForm control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void ChangeForm_Load(object sender, EventArgs e)
    {
        foreach(ICurrency cur in m_change.GetListOfCash())
        {
            if(cur.GetCount() == 0)
                continue;
            changeList.Items.Add(String.Format("{0} {1}", cur.GetCount(), cur.GetName()));
        }
        if(changeList.Items.Count == 0)
            this.Dispose();
    }

    private Money m_change;
}
}
