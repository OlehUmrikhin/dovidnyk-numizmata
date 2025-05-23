using dovidnyk_numizmata.Forms;
using dovidnyk_numizmata;
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

namespace dovidnyk_numizmata.Forms
{
    public partial class CollectionsOfCollectorsForm : Form
    {


        private bool isSearchActive = false;
        private Collector CurrentСollectioner;
        public CollectionsOfCollectorsForm(Collector collectioner)
        {
            InitializeComponent();


            this.CurrentСollectioner = collectioner;
            coinBindingSource.DataSource = AppState.CoinsList;
            ownedCoinBindingSource.DataSource = collectioner.CoinsCollection;
            textBox1.DataBindings.Add("Text", ownedCoinBindingSource, "Coin.Country");
            textBox2.DataBindings.Add("Text", ownedCoinBindingSource, "Coin.Par");
            textBox3.DataBindings.Add("Text", ownedCoinBindingSource, "Coin.YearOfGraduation");
            textBox4.DataBindings.Add("Text", ownedCoinBindingSource, "Coin.Material");
            textBox5.DataBindings.Add("Text", ownedCoinBindingSource, "Coin.Amount");
            textBox6.DataBindings.Add("Text", ownedCoinBindingSource, "Coin.Features");
            textBox7.DataBindings.Add("Text", ownedCoinBindingSource, "Coin.RemainingCoins");
        }

        private void searchingAllCoinsButton_Click(object sender, EventArgs e)
        {
            string search = searchingAllCoinsTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search) && isSearchActive)
            {
                coinBindingSource.DataSource = AppState.CoinsList;
                isSearchActive = false;
                AllCoinsListBox.SelectedIndex = -1;
                return;
            }

            List<Coin> result = AppState.CoinsList.Where(curentCoin =>
                (curentCoin.Country.ToLower().Contains(search)) ||
                (curentCoin.Par.ToLower().Contains(search)) ||
                (curentCoin.YearOfGraduation.ToLower().Contains(search)) ||
                (curentCoin.Material.ToLower().Contains(search)) ||
                (curentCoin.Features.ToLower().Contains(search))
            ).ToList();

            coinBindingSource.DataSource = result;
            isSearchActive = true;
            AllCoinsListBox.SelectedIndex = -1;
        }

        private void addCoinToCollectionOfCollectorButton_Click(object sender, EventArgs e)
        {
            Coin? selectedCoin = (Coin?)AllCoinsListBox.SelectedItem;
            if (selectedCoin != null && selectedCoin.RemainingCoins > 0)
            {
                selectedCoin.RemainingCoins--;

                this.CurrentСollectioner.CollectCoin(selectedCoin, "new");
                ownedCoinBindingSource.ResetBindings(true);
                coinBindingSource.ResetBindings(true);
                AppState.isEdit = true;
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonStringCoinsList = JsonSerializer.Serialize(AppState.CoinsList);
            string jsonStringCollectorList = JsonSerializer.Serialize(AppState.CollectorsList);
            File.WriteAllText("coins.txt", jsonStringCoinsList);
            File.WriteAllText("collectors.txt", jsonStringCollectorList);
            MessageBox.Show("Дані збережені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AppState.isEdit = false;
        }

        private void deleteCoinInCollectionOfCollectorButton_Click(object sender, EventArgs e)
        {
            if (CollectionOfCollectorListBox.SelectedItem is OwnedCoin selectedCoin)
            {
                selectedCoin.Coin.RemainingCoins++;
                this.CurrentСollectioner.DeCollectCoin(selectedCoin);
                ownedCoinBindingSource.ResetBindings(true);
                coinBindingSource.ResetBindings(true);
                AppState.isEdit = true;
            }
        }

        private void searchingCollectionOfCollectorButton_Click(object sender, EventArgs e)
        {
            string searchedOwnedCoins = searchingCollectionOfCollectorTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchedOwnedCoins) && isSearchActive)
            {
                ownedCoinBindingSource.DataSource = CurrentСollectioner.CoinsCollection;
                isSearchActive = false;
                //CollectionOfCollectorListBox.SelectedIndex = -1;
                return;
            }

            List<OwnedCoin> result = CurrentСollectioner.CoinsCollection.Where(ownedCoin =>
                (ownedCoin.Coin.Country.ToLower().Contains(searchedOwnedCoins)) ||
                (ownedCoin.Coin.Par.ToLower().Contains(searchedOwnedCoins)) ||
                (ownedCoin.Coin.YearOfGraduation.ToLower().Contains(searchedOwnedCoins)) ||
                (ownedCoin.Coin.Material.ToLower().Contains(searchedOwnedCoins)) ||
                (ownedCoin.Coin.Features.ToLower().Contains(searchedOwnedCoins))
            ).ToList();

            ownedCoinBindingSource.DataSource = result;
            isSearchActive = true;
            //CollectionOfCollectorListBox.SelectedIndex = -1;
        }
    }
}
