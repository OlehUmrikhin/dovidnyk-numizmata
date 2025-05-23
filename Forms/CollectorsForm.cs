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
        private CoinsForm coinsForm;
        private bool isSearchActive = false;
        public CollectorsForm()
        {
            InitializeComponent();
            collectorBindingSource.DataSource = AppState.CollectorsList;

            //AppState.TestDataCollectors();
            //collectorBindingSource.ResetBindings(true);
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (coinsForm == null || coinsForm.IsDisposed)
            {
                coinsForm = new CoinsForm();
            }
            coinsForm.Show();
        }

        private void монетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (coinsForm == null || coinsForm.IsDisposed)
            {
                coinsForm = new CoinsForm();
            }
            coinsForm.Show();
        }

        private void колекціонериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void addCollectorButton_Click(object sender, EventArgs e)
        {
            string contacts = contactsCollectorTextBox.Text;

            if (!(int.TryParse(nameCollectorTextBox.Text, out int nameInt)) && !(int.TryParse(countryCollectorTextBox.Text, out int countryInt)))
            {
                string name = nameCollectorTextBox.Text;
                string country = countryCollectorTextBox.Text;
                Collector newCollector = new Collector(country, name, contacts);

                if (!string.IsNullOrEmpty(newCollector.Country) && !string.IsNullOrEmpty(newCollector.Name) && !string.IsNullOrEmpty(newCollector.Contacts))
                {
                    AppState.CollectorsList.Add(newCollector);
                    AppState.isEdit = true;
                    collectorBindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Введіть всі поля!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Заповніть всі поля коректно", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteCollectorButton_Click(object sender, EventArgs e)
        {
            if (collectorListBox.SelectedItem is Collector collectorToRemove)
            {
                if (!collectorToRemove.Id.Equals(Guid.Parse(AppState.MyId)))
                {
                    if (isSearchActive)
                    {
                        AppState.CollectorsList.Remove(collectorToRemove);
                        AppState.isEdit = true;
                    }
                    else
                    {
                        AppState.CollectorsList.Remove(collectorToRemove);
                        AppState.isEdit = true;
                    }
                    collectorBindingSource.ResetBindings(false);
                }
            }
        }

        private void collectorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isItemSelected = (collectorListBox.SelectedIndex != -1);
            addCollectorButton.Enabled = !isItemSelected;
            deleteCollectorButton.Enabled = isItemSelected;

            if (isItemSelected && collectorBindingSource.Current is Collector selectedCollector)
            {

                if (countryCollectorTextBox.DataBindings["Text"] == null)
                {
                    countryCollectorTextBox.DataBindings.Add("Text", collectorBindingSource, "Country");
                }

                if (nameCollectorTextBox.DataBindings["Text"] == null)
                {
                    nameCollectorTextBox.DataBindings.Add("Text", collectorBindingSource, "Name");
                }

                if (contactsCollectorTextBox.DataBindings["Text"] == null)
                {
                    contactsCollectorTextBox.DataBindings.Add("Text", collectorBindingSource, "Contacts");
                }
            }
        }

        private void ClearDataBinding()
        {
            collectorListBox.SelectedIndex = -1;
            countryCollectorTextBox.DataBindings.Clear();
            nameCollectorTextBox.DataBindings.Clear();
            contactsCollectorTextBox.DataBindings.Clear();
        }

        private void CollectorsForm_Click(object sender, EventArgs e)
        {
            collectorListBox.SelectedIndex = -1;

            string country = countryCollectorTextBox.Text;
            string name = nameCollectorTextBox.Text;
            string contacts = contactsCollectorTextBox.Text;

            ClearDataBinding();

            countryCollectorTextBox.Text = country;
            nameCollectorTextBox.Text = name;
            contactsCollectorTextBox.Text = contacts;
        }

        private void searchCollectorButton_Click(object sender, EventArgs e)
        {
            string search = searchCollectorTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search) && isSearchActive)
            {
                collectorBindingSource.DataSource = AppState.CollectorsList;
                isSearchActive = false;
                collectorListBox.SelectedIndex = -1;
                return;
            }

            List<Collector> result = AppState.CollectorsList.Where(curentCollector =>
                (curentCollector.Country.ToLower().Contains(search)) ||
                (curentCollector.Name.ToLower().Contains(search)) ||
                (curentCollector.Contacts.ToLower().Contains(search))
            ).ToList();

            collectorBindingSource.DataSource = result;
            isSearchActive = true;
            collectorListBox.SelectedIndex = -1;

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
            if (AppState.collectionsOfCollectorsForm == null || AppState.collectionsOfCollectorsForm.IsDisposed)
            {
                var selectedCollector = collectorListBox.SelectedItem as Collector;
                var me = AppState.CollectorsList.FirstOrDefault(c => c.Id == Guid.Parse(AppState.MyId));
                if (selectedCollector != null && selectedCollector != me)
                {
                    AppState.collectionsOfCollectorsForm = new CollectionsOfCollectorsForm(selectedCollector);
                    AppState.collectionsOfCollectorsForm.Show();
                }
                else if (selectedCollector == me) 
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
            }
            
        }
    }
}