using dovidnyk_numizmata.Forms;
using dovidnyk_numizmata.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dovidnyk_numizmata
{
    public partial class MyCollectionForm : Form
    {
        AddCoinsForm addCoinsForm;
        //MyСollection myСollection;
       
        
        //public List<OwnedCoin> myСollection = new List<OwnedCoin>();
        public MyCollectionForm()
        {
            InitializeComponent();
            List<OwnedCoin> OwnedCoins = new List<OwnedCoin>();
            ownedCoinBindingSource.DataSource = OwnedCoins;
        }
        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addCoinsForm == null || addCoinsForm.IsDisposed)
            {
                addCoinsForm = new AddCoinsForm();
            }
            addCoinsForm.Show();
        }


    }
}