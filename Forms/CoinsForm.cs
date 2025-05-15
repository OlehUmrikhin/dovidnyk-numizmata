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
    public partial class CoinsForm : Form
    {
        private MyCollectionForm myCollectionForm;
        private CollectorsForm collectorsForm;
        private bool isSearchActive = false;
        private bool isEdit = false;

        public CoinsForm()
        {
            InitializeComponent();
            coinBindingSource.DataSource = AppState.CoinsList;
            //coinsListBox.SelectedIndex = -1;
            //AppState.CoinsList.Add(new Coin("Україна", "1 гривня", "1996", "матеріал1", 10, "Перша гривня"));
            //AppState.CoinsList.Add(new Coin("Україна", "2 гривні", "2024", "матеріал2", 10, "нема"));
            //AppState.CoinsList.Add(new Coin("Україна", "3 гривні", "2025", "матеріал3", 10, "нема"));
            //AppState.CoinsList.Add(new Coin("Україна", "4 гривні", "2026", "матеріал4", 10, "нема"));
            //AppState.CoinsList.Add(new Coin("Україна", "5 гривні", "2027", "матеріал5", 10, "нема"));
            //AppState.CoinsList.Add(new Coin("Україна", "6 гривні", "2028", "матеріал6", 10, "нема"));
            //AppState.CoinsList.Add(new Coin("Україна", "7 гривні", "2029", "матеріал7", 10, "нема"));
            //AppState.CoinsList.Add(new Coin("Україна", "8 гривні", "2030", "матеріал8", 10, "нема"));
            //AppState.CoinsList.Add(new Coin("Україна", "9 гривні", "2031", "матеріал9", 10, "нема"));
            //AppState.CoinsList.Add(new Coin("Україна", "10 гривні", "2032", "матеріал10", 10, "нема"));
            //coinBindingSource.ResetBindings(true);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string country = countryCoinsTextBox.Text;
            string par = parCoinsTextBox.Text;
            string year = yearOfGraduationCoinsTextBox.Text;
            string material = materialCoinsTextBox.Text;
            int number = Int32.Parse(numberCoinsTextBox.Text);
            string features = featuresCoinsTextBox.Text;

            //ClearInputFields();

            Coin newCoin = new Coin(country, par, year, material, number, features);
            if (!string.IsNullOrEmpty(newCoin.Country) && !string.IsNullOrEmpty(newCoin.Par) && !string.IsNullOrEmpty(newCoin.YearOfGraduation) && !string.IsNullOrEmpty(newCoin.Material) && newCoin.Amount > 0 && !string.IsNullOrEmpty(newCoin.Features))
            {
                AppState.CoinsList.Add(newCoin);
                isEdit = true;
                coinBindingSource.ResetBindings(true);
            }
            else
            {
                MessageBox.Show("Введіть всі поля!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (coinsListBox.SelectedItem is Coin coinToRemove)
            {
                AppState.CoinsList.Remove(coinToRemove);
                isEdit = true;
                coinBindingSource.ResetBindings(false);
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
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string countrySearch = countryCoinsTextBox.Text.Trim().ToLower();
            string parSearch = parCoinsTextBox.Text.Trim().ToLower();
            string yearSearch = yearOfGraduationCoinsTextBox.Text.Trim().ToLower();
            string materialSearch = materialCoinsTextBox.Text.Trim().ToLower();
            string numberSearch = numberCoinsTextBox.Text.Trim().ToLower();
            string featuresSearch = featuresCoinsTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(countrySearch) && string.IsNullOrEmpty(parSearch) &&
            string.IsNullOrEmpty(yearSearch) && string.IsNullOrEmpty(materialSearch) &&
            string.IsNullOrEmpty(numberSearch) && string.IsNullOrEmpty(featuresSearch) &&
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

        private void зберігтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(AppState.CoinsList);
            File.WriteAllText("data.txt", jsonString);
            MessageBox.Show("Дані збережені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isEdit = false;
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

            ClearDataBinding();

            countryCoinsTextBox.Text = country;
            parCoinsTextBox.Text = par;
            yearOfGraduationCoinsTextBox.Text = year;
            materialCoinsTextBox.Text = material;
            numberCoinsTextBox.Text = number;
            featuresCoinsTextBox.Text = features;

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
            }
        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (isEdit)
            {
                var result = MessageBox.Show("Чи хочете зберегти зміни?", "Повідомлення", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        string jsonString = JsonSerializer.Serialize(AppState.CoinsList);
                        File.WriteAllText("data.txt", jsonString);
                        Close(); break;
                    case DialogResult.No:
                        Close(); break;
                }
            }
            else Close();
        }

        private void мояКолекціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myCollectionForm == null || myCollectionForm.IsDisposed)
            {
                myCollectionForm = new MyCollectionForm();
            }
            myCollectionForm.Show();
        }

        private void колекціонериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (collectorsForm == null || collectorsForm.IsDisposed)
            {
                collectorsForm = new CollectorsForm();
            }
            collectorsForm.Show();
        }
    }
}