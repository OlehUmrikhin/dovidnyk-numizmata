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
using dovidnyk_numizmata.Models;

namespace dovidnyk_numizmata.Forms
{
    public partial class AddCoinsForm : Form
    {
        public List<Coin> allCoinsList = new List<Coin>();
        public AddCoinsForm()
        {
            
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            
            //Coin newCoin = new Coin(country, par, year, material, number, features);
            //OwnedCoin newOwnedCoin = new OwnedCoin(newCoin, "owned");
            //if (!string.IsNullOrEmpty(newCoin.Country) && !string.IsNullOrEmpty(newCoin.Par) && !string.IsNullOrEmpty(newCoin.YearOfGraduation) && !string.IsNullOrEmpty(newCoin.Material) && !string.IsNullOrEmpty(newCoin.Number) && !string.IsNullOrEmpty(newCoin.Features))
            //{
            //    //myСollection.OwnedCoins.Add(ownedCoin);
            //    //ownedCoinBindingSource.ResetBindings(true);
            //}
            //else
            //{
            //    MessageBox.Show("Введіть всі поля!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
