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
        private bool isEdit = false;
        private Collector CurrentСollectioner;
        public CollectionsOfCollectorsForm(Collector collectioner)
        {
            InitializeComponent();
            this.CurrentСollectioner = collectioner;
            coinBindingSource.DataSource = AppState.CoinsList;
            ownedCoinBindingSource.DataSource = collectioner.CoinsCollection;
        }


        private void searchingAllCoinsButton_Click(object sender, EventArgs e)
        {

        }

        private void addCoinToCollectionOfCollectorButton_Click(object sender, EventArgs e)
        {
            Coin? selectedCoin = (Coin?)AllCoinsListBox.SelectedItem;
            if (selectedCoin != null && selectedCoin.Amount > 0)
            {
                this.CurrentСollectioner.CollectCoin(selectedCoin, "new");
                selectedCoin.Amount--;
                ownedCoinBindingSource.ResetBindings(true);
                isEdit = true;
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(AppState.CollectorsList);
            File.WriteAllText("collectors.txt", jsonString);
            MessageBox.Show("Дані збережені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isEdit = false;
        }

        private void deleteCoinInCollectionOfCollectorButton_Click(object sender, EventArgs e)
        {
            //OwnedCoin selectedCoin = CollectionOfCollectorListBox.SelectedItem;
            if (CollectionOfCollectorListBox.SelectedItem is OwnedCoin selectedCoin)
            {
                this.CurrentСollectioner.DeCollectCoin(selectedCoin);
                //selectedCoin.Amount++;
                ownedCoinBindingSource.ResetBindings(true);
                isEdit = true;
            }
        }
    }
}
