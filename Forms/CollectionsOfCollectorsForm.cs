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


        private Collector CurrentСollectioner;
        public CollectionsOfCollectorsForm(Collector collectioner)
        {
            InitializeComponent();

            this.CurrentСollectioner = collectioner;
            coinBindingSource.DataSource = AppState.CoinsList;
            ownedCoinBindingSource.DataSource = collectioner.CoinsCollection;
            collectorBindingSource.DataSource = collectioner;
        }

        private void addCoinToCollectionOfCollectorButton_Click(object sender, EventArgs e)
        {
            Coin? selectedCoin = (Coin?)coinBindingSource.Current;
            if (selectedCoin != null && selectedCoin.RemainingCoins > 0)
            {
                MessageBox.Show("Монета успішно додана до колекції колекціонера!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (ownedCoinBindingSource.Current is OwnedCoin selectedCoin)
            {
                var result = MessageBox.Show("Чи дійсно Ви хочете видалити цю монету з колекції колекціонера?", "Повідомлення", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Монета успішно видалена!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CurrentСollectioner.DeCollectCoin(selectedCoin);
                        ownedCoinBindingSource.ResetBindings(true);
                        coinBindingSource.ResetBindings(true);
                        AppState.isEdit = true;
                        break;
                    case DialogResult.No:
                        break;
                }

            }
        }

        private void searchingAllCoinsTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchingAllCoinsTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search))
            {
                coinBindingSource.DataSource = AppState.CoinsList;
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

        private void searchingCollectionOfCollectorTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchedOwnedCoins = searchingCollectionOfCollectorTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchedOwnedCoins))
            {
                ownedCoinBindingSource.DataSource = CurrentСollectioner.CoinsCollection;
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
        }

        private void монетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.coinsForm == null || AppState.coinsForm.IsDisposed)
            {
                AppState.coinsForm = new CoinsForm();
                AppState.coinsForm.Show();
            }
            AppState.coinsForm?.Activate();
        }

        private void колекціонериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.collectorsForm == null || AppState.collectorsForm.IsDisposed)
            {
                AppState.collectorsForm = new CollectorsForm();
                AppState.collectorsForm.Show();
            }
            AppState.collectorsForm?.Activate();
        }

        private void мояКолекціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var me = AppState.CollectorsList?.FirstOrDefault(c => c.Id == Guid.Parse(AppState.MyId));
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

        private void вийтиЗДодаткуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
