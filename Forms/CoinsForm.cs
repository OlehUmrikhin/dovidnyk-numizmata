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
using System.Diagnostics.Metrics;

namespace dovidnyk_numizmata.Forms
{
    public partial class CoinsForm : Form
    {
        private bool isSearchActive = false;
        Collector me = AppState.CollectorsList.FirstOrDefault(c => c.Id == Guid.Parse(AppState.MyId));

        public CoinsForm()
        {
            InitializeComponent();
            coinBindingSource.DataSource = AppState.CoinsList;
            coinsListBox.DataSource = coinBindingSource;

            //AppState.TestDataCoins("CША", "долар");
            //AppState.TestDataCoins("Україна", "гривня");
            //AppState.TestDataCoins("Німеччина", "євро");
            //coinBindingSource.ResetBindings(true);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string country = countryCoinsTextBox.Text;
            string par = parCoinsTextBox.Text;
            string year = yearOfGraduationCoinsTextBox.Text;
            string material = materialCoinsTextBox.Text;
            string features = featuresCoinsTextBox.Text;

            if (int.TryParse(numberCoinsTextBox.Text, out int number) && int.TryParse(remainingCoinsTextBox.Text, out int remainingCoins))
            {
                Coin newCoin = new Coin(country, par, year, material, number, features, remainingCoins);

                if (!string.IsNullOrEmpty(newCoin.Country) && !string.IsNullOrEmpty(newCoin.Par) && !string.IsNullOrEmpty(newCoin.YearOfGraduation) && !string.IsNullOrEmpty(newCoin.Material) && newCoin.Amount > 0 && !string.IsNullOrEmpty(newCoin.Features) && newCoin.RemainingCoins > 0)
                {
                    AppState.CoinsList.Add(newCoin);
                    AppState.isEdit = true;
                    coinBindingSource.ResetBindings(true);

                }
                else
                {
                    MessageBox.Show("Заповніть всі поля!", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля коректно", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (coinsListBox.SelectedItem is Coin coinToRemove)
            {
                AppState.CoinsList.Remove(coinToRemove);

                AppState.RemoveCoinFromAllCollector(coinToRemove.Id);
                if (!(AppState.collectionsOfCollectorsForm == null || AppState.collectionsOfCollectorsForm.IsDisposed))
                {
                    AppState.collectionsOfCollectorsForm.ownedCoinBindingSource.ResetBindings(true);
                }



                AppState.isEdit = true;
                coinBindingSource.ResetBindings(true);
                deleteButton.Enabled = false;
                coinsListBox.SelectedIndex = -1;
            }
        }

        private void ClearInputFields()
        {
            countryCoinsTextBox.Clear();
            parCoinsTextBox.Clear();
            yearOfGraduationCoinsTextBox.Clear();
            materialCoinsTextBox.Clear();
            numberCoinsTextBox.Clear();
            featuresCoinsTextBox.Clear();
            remainingCoinsTextBox.Clear();

        }

        private void ClearDataBinding()
        {
            coinsListBox.SelectedIndex = -1;
            countryCoinsTextBox.DataBindings.Clear();
            parCoinsTextBox.DataBindings.Clear();
            yearOfGraduationCoinsTextBox.DataBindings.Clear();
            materialCoinsTextBox.DataBindings.Clear();
            numberCoinsTextBox.DataBindings.Clear();
            featuresCoinsTextBox.DataBindings.Clear();
            remainingCoinsTextBox.DataBindings.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string countrySearch = countryCoinsTextBox.Text.Trim().ToLower();
            string parSearch = parCoinsTextBox.Text.Trim().ToLower();
            string yearSearch = yearOfGraduationCoinsTextBox.Text.Trim().ToLower();
            string materialSearch = materialCoinsTextBox.Text.Trim().ToLower();
            string amountSearch = numberCoinsTextBox.Text.Trim().ToLower();
            string featuresSearch = featuresCoinsTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(countrySearch) && string.IsNullOrEmpty(parSearch) &&
            string.IsNullOrEmpty(yearSearch) && string.IsNullOrEmpty(materialSearch) &&
            string.IsNullOrEmpty(amountSearch) && string.IsNullOrEmpty(featuresSearch) &&
            isSearchActive)
            {
                coinBindingSource.DataSource = AppState.CoinsList;
                isSearchActive = false;
                coinsListBox.SelectedIndex = -1;
                return;
            }

            List<Coin> results = AppState.CoinsList.Where(coin =>
                (string.IsNullOrEmpty(countrySearch) || coin.Country.ToLower().Contains(countrySearch)) &&
                (string.IsNullOrEmpty(parSearch) || coin.Par.ToLower().Contains(parSearch)) &&
                (string.IsNullOrEmpty(yearSearch) || coin.YearOfGraduation.ToLower().Contains(yearSearch)) &&
                (string.IsNullOrEmpty(materialSearch) || coin.Material.ToLower().Contains(materialSearch)) &&
                (string.IsNullOrEmpty(featuresSearch) || coin.Features.ToLower().Contains(featuresSearch))
            ).ToList();

            coinBindingSource.DataSource = results;
            isSearchActive = true;
            coinsListBox.SelectedIndex = -1;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonStringCoins = JsonSerializer.Serialize(AppState.CoinsList);
            string jsonStringCollectors = JsonSerializer.Serialize(AppState.CollectorsList);
            File.WriteAllText("coins.txt", jsonStringCoins);
            File.WriteAllText("collectors.txt", jsonStringCollectors);
            MessageBox.Show("Дані збережені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AppState.isEdit = false;

        }

        private void CoinsForm_Click(object sender, EventArgs e)
        {
            coinsListBox.SelectedIndex = -1;

            string country = countryCoinsTextBox.Text;
            string par = parCoinsTextBox.Text;
            string year = yearOfGraduationCoinsTextBox.Text;
            string material = materialCoinsTextBox.Text;
            string number = numberCoinsTextBox.Text;
            string features = featuresCoinsTextBox.Text;
            string remainingCoins = remainingCoinsTextBox.Text;

            ClearDataBinding();

            countryCoinsTextBox.Text = country;
            parCoinsTextBox.Text = par;
            yearOfGraduationCoinsTextBox.Text = year;
            materialCoinsTextBox.Text = material;
            numberCoinsTextBox.Text = number;
            featuresCoinsTextBox.Text = features;
            remainingCoinsTextBox.Text = remainingCoins;

        }

        private void coinsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isItemSelected = (coinsListBox.SelectedIndex != -1);
            addButton.Enabled = !isItemSelected;
            deleteButton.Enabled = isItemSelected;

            if (isItemSelected && coinBindingSource.Current is Coin selectedCoin)
            {

                if (countryCoinsTextBox.DataBindings["Text"] == null)
                {
                    countryCoinsTextBox.DataBindings.Add("Text", coinBindingSource, "Country");
                }

                if (parCoinsTextBox.DataBindings["Text"] == null)
                {
                    parCoinsTextBox.DataBindings.Add("Text", coinBindingSource, "Par");
                }

                if (yearOfGraduationCoinsTextBox.DataBindings["Text"] == null)
                {
                    yearOfGraduationCoinsTextBox.DataBindings.Add("Text", coinBindingSource, "YearOfGraduation");
                }

                if (materialCoinsTextBox.DataBindings["Text"] == null)
                {
                    materialCoinsTextBox.DataBindings.Add("Text", coinBindingSource, "Material");
                }

                if (numberCoinsTextBox.DataBindings["Text"] == null)
                {
                    numberCoinsTextBox.DataBindings.Add("Text", coinBindingSource, "Amount");
                }

                if (featuresCoinsTextBox.DataBindings["Text"] == null)
                {
                    featuresCoinsTextBox.DataBindings.Add("Text", coinBindingSource, "Features");
                }

                if (remainingCoinsTextBox.DataBindings["Text"] == null)
                {
                    remainingCoinsTextBox.DataBindings.Add("Text", coinBindingSource, "RemainingCoins");
                }
            }
        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void мояКолекціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.collectionOfCollectorsForm == null || AppState.collectionOfCollectorsForm.IsDisposed)
            {
                
                if (me != null)
                {
                    AppState.collectionOfCollectorsForm = new CollectionsOfCollectorsForm(me);
                    AppState.collectionOfCollectorsForm.Show();
                }
            }

        }

        private void колекціонериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.collectorsForm == null || AppState.collectorsForm.IsDisposed)
            {
                AppState.collectorsForm = new CollectorsForm();
            }
            AppState.collectorsForm.Show();
        }

        public void CoinsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppState.isEdit)
            {
                var result = MessageBox.Show("Чи хочете зберегти зміни?", "Повідомлення", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        string jsonStringCoinsList = JsonSerializer.Serialize(AppState.CoinsList);
                        string jsonStringCollectorList = JsonSerializer.Serialize(AppState.CollectorsList);
                        File.WriteAllText("coins.txt", jsonStringCoinsList);
                        File.WriteAllText("collectors.txt", jsonStringCollectorList);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true; 
                        break;
                }
            }
            
        }

    }
}