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
        Collector me = AppState.CollectorsList.FirstOrDefault(c => c.Id == Guid.Parse(AppState.MyId));

        public CoinsForm()
        {
            InitializeComponent();
            coinBindingSource.DataSource = AppState.CoinsList;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (AppState.addCoinForm == null || AppState.addCoinForm.IsDisposed)
            {
                AppState.addCoinForm = new AddCoinForm();
            }
            AppState.addCoinForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (coinBindingSource.Current is Coin coinToRemove)
            {
                var result = MessageBox.Show("Чи дійсно Ви хочете видалити цю монету?", "Повідомлення", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        AppState.CoinsList.Remove(coinToRemove);
                        AppState.RemoveCoinFromAllCollector(coinToRemove.Id);
                        if (!(AppState.collectionsOfCollectorsForm == null || AppState.collectionsOfCollectorsForm.IsDisposed))
                        {
                            AppState.collectionsOfCollectorsForm.ownedCoinBindingSource.ResetBindings(true);
                        }
                        AppState.isEdit = true;
                        coinBindingSource.ResetBindings(true);
                        MessageBox.Show("Монета успішно видалена!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
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

        private void мояКолекціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.myCollectionOfCollectorsForm == null || AppState.myCollectionOfCollectorsForm.IsDisposed)
            {

                if (me != null)
                {
                    AppState.myCollectionOfCollectorsForm = new CollectionsOfCollectorsForm(me);
                    AppState.myCollectionOfCollectorsForm.Show();
                }
            }
            AppState.myCollectionOfCollectorsForm?.Activate();

        }

        private void колекціонериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.collectorsForm == null || AppState.collectorsForm.IsDisposed)
            {
                AppState.collectorsForm = new CollectorsForm();
                AppState.collectorsForm.Show();
            }
            AppState.collectorsForm.Activate();
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

        private void searchingtextBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchingTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search))
            {
                coinBindingSource.DataSource = AppState.CoinsList;
                SortCoinsByCountry();
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
        }

        public void SortCoinsByCountry()
        {
            List<Coin> sortedList = AppState.CoinsList.OrderBy(coin => coin.Country).ToList();
            AppState.CoinsList = new BindingList<Coin>(sortedList);
            coinBindingSource.DataSource = AppState.CoinsList;
            coinBindingSource.ResetBindings(false);
            collectionOfCoinsDataGridView.ClearSelection();
        }

        private void вийтиЗДодаткуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}