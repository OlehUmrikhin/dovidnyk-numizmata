using dovidnyk_numizmata.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dovidnyk_numizmata
{
    public partial class CoinsForm : Form
    {
        private List<Coin> coinsList = new List<Coin>();
        private List<Coin> currentDisplayList;
        private Coin selectedCoinBeforeEdit = null;

        public CoinsForm()
        {
            InitializeComponent();
            string jsonString = File.ReadAllText("data.txt");
            coinsList = JsonSerializer.Deserialize<List<Coin>>(jsonString);
            coinsList.Add(new Coin("Україна", "1 гривня", "1996", "матеріал2", "1", "Перша гривня"));
            coinsList.Add(new Coin("Україна", "2 гривні", "2024", "матеріал3", "1", "нема"));
            coinsList.Add(new Coin("Україна", "3 гривні", "2025", "матеріал4", "1", "нема"));
            coinsList.Add(new Coin("Україна", "4 гривні", "2026", "матеріал5", "1", "нема"));
            coinsList.Add(new Coin("Україна", "5 гривні", "2027", "матеріал6", "1", "нема"));
            coinsList.Add(new Coin("Україна", "6 гривні", "2028", "матеріал7", "1", "нема"));
            coinsList.Add(new Coin("Україна", "7 гривні", "2029", "матеріал8", "1", "нема"));
            coinsList.Add(new Coin("Україна", "8 гривні", "2030", "матеріал9", "1", "нема"));
            coinsList.Add(new Coin("Україна", "9 гривні", "2031", "матеріал10", "1", "нема"));
            coinsList.Add(new Coin("Україна", "10 гривні", "2032", "матеріал11", "1", "нема"));
            currentDisplayList = [.. coinsList];
            UpdateListBox();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string country = countryCoinsTextBox.Text;
            string par = parCoinsTextBox.Text;
            string year = yearOfGraduationCoinsTextBox.Text;
            string material = materialCoinsTextBox.Text;
            string number = numberCoinsTextBox.Text;
            string features = featuresCoinsTextBox.Text;

            Coin newCoin = new Coin(country, par, year, material, number, features);
            if (!string.IsNullOrEmpty(newCoin.Country) && !string.IsNullOrEmpty(newCoin.Par) && !string.IsNullOrEmpty(newCoin.YearOfGraduation) && !string.IsNullOrEmpty(newCoin.Material) && !string.IsNullOrEmpty(newCoin.Number) && !string.IsNullOrEmpty(newCoin.Features))
            {
                coinsList.Add(newCoin);
                currentDisplayList.Add(newCoin);
                UpdateListBox();
                ClearInputFields();
                coinsListBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Введіть всі поля!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (coinsListBox.SelectedIndex != -1 && selectedCoinBeforeEdit != null)
            {
                Coin currentCoin = currentDisplayList[coinsListBox.SelectedIndex];
                Coin updatedCoinFromFields = new Coin(
                    countryCoinsTextBox.Text,
                    parCoinsTextBox.Text,
                    yearOfGraduationCoinsTextBox.Text,
                    materialCoinsTextBox.Text,
                    numberCoinsTextBox.Text,
                    featuresCoinsTextBox.Text
                );

                if (!currentCoin.Equals(updatedCoinFromFields))
                {
                    int indexInMainList = coinsList.IndexOf(currentCoin);
                    if (indexInMainList != -1)
                    {
                        coinsList[indexInMainList] = updatedCoinFromFields;
                    }
                    currentDisplayList[coinsListBox.SelectedIndex] = updatedCoinFromFields;
                    UpdateListBox();
                }
                ClearInputFields();
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                coinsListBox.SelectedIndex = -1;
                selectedCoinBeforeEdit = null;
            }
        }

        private void UpdateListBox()
        {
            
            coinsListBox.Items.Clear();
            foreach (Coin coin in currentDisplayList)
            {
                coinsListBox.Items.Add(coin);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
                int selectedIndex = coinsListBox.SelectedIndex;
                if (selectedIndex < currentDisplayList.Count && selectedIndex < coinsList.Count && selectedIndex != -1)
                {
                    Coin coinToRemoveFromMainList = currentDisplayList[selectedIndex];
                    coinsList.Remove(coinToRemoveFromMainList);
                    currentDisplayList.RemoveAt(selectedIndex);

                    UpdateListBox();
                    ClearInputFields();
                    deleteButton.Enabled = false;
                    editButton.Enabled = false;
                    coinsListBox.SelectedIndex = -1;
                    selectedCoinBeforeEdit = null;
                }
        }



        private void coinsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isItemSelected = (coinsListBox.SelectedIndex != -1);
            deleteButton.Enabled = isItemSelected;
            editButton.Enabled = isItemSelected;

            if (isItemSelected)
            {
                Coin selectedCoin = currentDisplayList[coinsListBox.SelectedIndex]; 
                countryCoinsTextBox.Text = selectedCoin.Country;
                parCoinsTextBox.Text = selectedCoin.Par;
                yearOfGraduationCoinsTextBox.Text = selectedCoin.YearOfGraduation;
                materialCoinsTextBox.Text = selectedCoin.Material;
                numberCoinsTextBox.Text = selectedCoin.Number;
                featuresCoinsTextBox.Text = selectedCoin.Features;
                selectedCoinBeforeEdit = new Coin(selectedCoin.Country, selectedCoin.Par, selectedCoin.YearOfGraduation, selectedCoin.Material, selectedCoin.Number, selectedCoin.Features);
            }
            else
            {
                ClearInputFields();
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                selectedCoinBeforeEdit = null;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string countrySearch = countryCoinsTextBox.Text.Trim().ToLower();
            string parSearch = parCoinsTextBox.Text.Trim().ToLower();
            string yearSearch = yearOfGraduationCoinsTextBox.Text.Trim().ToLower();
            string materialSearch = materialCoinsTextBox.Text.Trim().ToLower();
            string numberSearch = numberCoinsTextBox.Text.Trim().ToLower();
            string featuresSearch = featuresCoinsTextBox.Text.Trim().ToLower();

            currentDisplayList = coinsList.Where(coin =>
                (string.IsNullOrEmpty(countrySearch) || coin.Country.ToLower().Contains(countrySearch)) &&
                (string.IsNullOrEmpty(parSearch) || coin.Par.ToLower().Contains(parSearch)) &&
                (string.IsNullOrEmpty(yearSearch) || coin.YearOfGraduation.ToLower().Contains(yearSearch)) &&
                (string.IsNullOrEmpty(materialSearch) || coin.Material.ToLower().Contains(materialSearch)) &&
                (string.IsNullOrEmpty(numberSearch) || coin.Number.ToLower().Contains(numberSearch)) &&
                (string.IsNullOrEmpty(featuresSearch) || coin.Features.ToLower().Contains(featuresSearch))
            ).ToList();

            UpdateListBox();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void зберігтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(coinsList);
            File.WriteAllText("data.txt", jsonString);
            MessageBox.Show("Дані збережені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void вийтиЗДодаткуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}