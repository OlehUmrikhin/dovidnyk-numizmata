using dovidnyk_numizmata.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dovidnyk_numizmata.Forms
{
    public partial class AddCoinForm : Form
    {
        public AddCoinForm()
        {
            InitializeComponent();
        }

        private void AddCoinButton_Click(object sender, EventArgs e)
        {
            string country = countryCoinsTextBox.Text;
            string par = parCoinsTextBox.Text;
            string year = yearOfGraduationCoinsTextBox.Text;
            string material = materialCoinsTextBox.Text;
            string features = featuresCoinsTextBox.Text;

            if (int.TryParse(numberCoinsTextBox.Text, out int number) && number > 0)
            {
                Coin newCoin = new Coin(country, par, year, material, number, features, number);

                if (!string.IsNullOrEmpty(newCoin.Country) && !string.IsNullOrEmpty(newCoin.Par) && !string.IsNullOrEmpty(newCoin.YearOfGraduation) && !string.IsNullOrEmpty(newCoin.Material) && newCoin.Amount > 0 && !string.IsNullOrEmpty(newCoin.Features))
                {
                    bool coinExists = AppState.CoinsList.Any(existingCoin => existingCoin.IsIdentical(newCoin));
                    if (!coinExists)
                    {
                        AppState.CoinsList.Add(newCoin);
                        AppState.coinsForm?.SortCoinsByCountry();
                        AppState.isEdit = true;
                        coinBindingSource.ResetBindings(true);
                        MessageBox.Show("Монета успішно додана!", "Додавання", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("Така монета вже існує у списку!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                }
                else
                {
                    MessageBox.Show("Заповніть всі поля коректно!", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля коректно", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
