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
    public partial class CollectorsForm : Form
    {
        public CollectorsForm()
        {
            InitializeComponent();
            collectorBindingSource.DataSource = AppState.CollectorsList;
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

        private void addCollectorButton_Click(object sender, EventArgs e)
        {
            if (AppState.addCollectorForm == null || AppState.addCollectorForm.IsDisposed)
            {
                AppState.addCollectorForm = new AddCollectorForm();
            }
            AppState.addCollectorForm.ShowDialog();
        }

        private void deleteCollectorButton_Click(object sender, EventArgs e)
        {
            if (collectorBindingSource.Current is Collector collectorToRemove && collectorToRemove.Id.ToString() != AppState.MyId)
            {
                var result = MessageBox.Show("Чи дійсно Ви хочете видалити цього колекціонера?", "Повідомлення", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Колекціонер успішно видалений!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AppState.CollectorsList.Remove(collectorToRemove);
                        AppState.isEdit = true;
                        collectorBindingSource.ResetBindings(true);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else MessageBox.Show("Це Ви! Ви не можете видалити себе, як колекціонера!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void lookCollectionOfCollectorButton_Click(object sender, EventArgs e)
        {
            var me = AppState.CollectorsList?.FirstOrDefault(c => c.Id == Guid.Parse(AppState.MyId));
            if (collectorBindingSource.Current is Collector selectedCollector)
            {
                if (selectedCollector != me)
                {

                    if (AppState.collectionsOfCollectorsForm == null || AppState.collectionsOfCollectorsForm.IsDisposed)
                    {
                        AppState.collectionsOfCollectorsForm = new CollectionsOfCollectorsForm(selectedCollector);
                        AppState.collectionsOfCollectorsForm.Show();
                    }
                    AppState.collectionsOfCollectorsForm?.Activate();
                }
                if (selectedCollector == me)
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
            }
        }

        private void searchCollectorTextBox_TextChanged(object sender, EventArgs e)
        {

            string search = searchCollectorTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search))
            {
                collectorBindingSource.DataSource = AppState.CollectorsList;
                return;
            }

            List<Collector> result = AppState.CollectorsList.Where(curentCollector =>
                (curentCollector.Country.ToLower().Contains(search)) ||
                (curentCollector.Name.ToLower().Contains(search)) ||
                (curentCollector.Contacts.ToLower().Contains(search))
            ).ToList();

            collectorBindingSource.DataSource = result;

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