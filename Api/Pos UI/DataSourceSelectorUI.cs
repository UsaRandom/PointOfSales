using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Pos.DB;

namespace Pos.UI
{
#region Class Definition : DataSourceSelectorUI
public partial class DataSourceSelectorUI : Form
{
   
   #region Constructor
   
   /// <summary>
   /// Initializes a new instance of the <see cref="DataSourceSelectorUI"/> class.
   /// </summary>
   public DataSourceSelectorUI()
   {
      InitializeComponent();
   }
   
   #endregion
   
   #region Public Methods

   /// <summary>
   /// Gets the record.
   /// </summary>
   /// <value>The record.</value>
   public IRecord Record
   {
      get
      {
         return m_returnRecord;
      }
   }
   
   #endregion
   
   #region Private Methods

   /// <summary>
   /// Handles the Load event of the DataSourceSelectorUI control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void DataSourceSelectorUI_Load(object sender, EventArgs e)
   {
      xmlFileLocationBox.Items.Add(String.Empty);
      xmlFileLocationBox.Items.Add(BROWSE);
      schemaLocationBox.Items.Add(String.Empty);
      schemaLocationBox.Items.Add(BROWSE);
      this.CancelButton = this.cancelButton;
      this.CancelButton.DialogResult = DialogResult.Cancel;
   }

   /// <summary>
   /// Handles the SelectedIndexChanged event of the xmlFileLocationBox control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void xmlFileLocationBox_SelectedIndexChanged(object sender, EventArgs e)
   {
      if(xmlFileLocationBox.SelectedItem.Equals(BROWSE))
      {
         OpenFileDialog fileBrowser = new OpenFileDialog();
         fileBrowser.Filter = "XML Files (*.xml)|*.xml";
         fileBrowser.Title = "Browse for XML File";
         
         if(fileBrowser.ShowDialog() == DialogResult.Cancel)
            return;
         
         if(!File.Exists(fileBrowser.FileName))
            return;
         
         if(xmlFileLocationBox.Items.Contains(fileBrowser.FileName))
         {
            xmlFileLocationBox.SelectedIndex = xmlFileLocationBox.Items.IndexOf(fileBrowser.FileName);
            return;
         }
         
         xmlFileLocationBox.Items.Insert(0, fileBrowser.FileName);
         xmlFileLocationBox.SelectedIndex = 0;
         
         for(int i = 0; i < xmlFileLocationBox.Items.Count; i++)
         {
            if(xmlFileLocationBox.Items[i].Equals(String.Empty))
               xmlFileLocationBox.Items.RemoveAt(i);
         }
         
      }
   }

   /// <summary>
   /// Handles the SelectedIndexChanged event of the schemaLocationBox control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void schemaLocationBox_SelectedIndexChanged(object sender, EventArgs e)
   {
      if(schemaLocationBox.SelectedItem.Equals(BROWSE))
      {
         OpenFileDialog fileBrowser = new OpenFileDialog();
         fileBrowser.Filter = "XSD Files (*.xsd)|*.xsd";
         fileBrowser.Title = "Browse for XSD File";
         
         if(fileBrowser.ShowDialog() == DialogResult.Cancel)
            return;
         
         if(!File.Exists(fileBrowser.FileName))
            return;
         
         if(schemaLocationBox.Items.Contains(fileBrowser.FileName))
         {
            schemaLocationBox.SelectedIndex = schemaLocationBox.Items.IndexOf(fileBrowser.FileName);
            return;
         }
         
         schemaLocationBox.Items.Insert(0, fileBrowser.FileName);
         schemaLocationBox.SelectedIndex = 0;
         
         for(int i = 0; i < schemaLocationBox.Items.Count; i++)
         {
            if(schemaLocationBox.Items[i].Equals(String.Empty))
               schemaLocationBox.Items.RemoveAt(i);
         }
         
      }
   }

   /// <summary>
   /// Handles the CheckedChanged event of the validateXmlCheckBox control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void validateXmlCheckBox_CheckedChanged(object sender, EventArgs e)
   {
      if(validateXmlCheckBox.Checked)
      {
         schemaLocationBox.Enabled = true;
         schemaLbl.Enabled = true;
         XMLRecords.UseValidation = true;
      }
      else
      {
         schemaLocationBox.Enabled = false;
         schemaLbl.Enabled = false;
         XMLRecords.UseValidation = false;
      }
   }

   /// <summary>
   /// Handles the Click event of the connectButton control.
   /// </summary>
   /// <param name="sender">The source of the event.</param>
   /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
   private void connectButton_Click(object sender, EventArgs e)
   {
     if(AcceptButton == connectButton)
         return;

     if(tabControl.SelectedIndex == 1)
     {
        m_returnRecord = XMLRecords.Instance;
        XMLRecords.FileLocation = xmlFileLocationBox.Text;
        if(XMLRecords.UseValidation)
           XMLRecords.SchemaLocation = schemaLocationBox.Text;
     }
     else
     {
        DBRecord.ConnectionString = String.Format("Server={0};Database={1};User ID={2};Password={3};",
                                            serverLocationBox.Text,
                                            databaseNameBox.Text,
                                            usernameBox.Text,
                                            passwordBox.Text);
                                            
        m_returnRecord = DBRecord.Instance;
     }
     Exception exc = null;
     if(!m_returnRecord.Test(out exc))
     {
        MessageBox.Show(exc.Message,
                        "ERROR!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
     }
     else
     {
         AcceptButton = connectButton;
         AcceptButton.DialogResult = DialogResult.OK;
         AcceptButton.PerformClick();
     }
   }
   
   #endregion
   
   #region Private Variables
   
   private IRecord m_returnRecord;
   private const string BROWSE = "<Browse...>";
   
   #endregion

   private void keyUp(object sender, KeyEventArgs e)
   {
       checkEnter(e);
   }

   private void keyDown(object sender, KeyEventArgs e)
   {
       checkEnter(e);
   }

    private void checkEnter(KeyEventArgs e)
    {
       if(e.KeyCode == Keys.Enter)
       {
           this.connectButton.PerformClick();
       }
    }

    private void usernameBox_KeyUp(object sender, KeyEventArgs e)
    {
        checkEnter(e);
    }

    private void databaseNameBox_KeyUp(object sender, KeyEventArgs e)
    {
        checkEnter(e);
    }

    private void serverLocationBox_KeyUp(object sender, KeyEventArgs e)
    {
        checkEnter(e);
    }

    private void xmlFileLocationBox_KeyUp(object sender, KeyEventArgs e)
    {
        checkEnter(e);
    }

    private void schemaLocationBox_KeyUp(object sender, KeyEventArgs e)
    {
        checkEnter(e);
    }
   
}
#endregion
}
