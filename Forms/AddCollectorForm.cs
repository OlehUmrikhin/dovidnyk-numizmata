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
    public partial class AddCollectorForm : Form
    {
        public AddCollectorForm()
        {
            InitializeComponent();
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
                    bool collectorExists = AppState.CollectorsList.Any(existingCollector => existingCollector.IsIdentical(newCollector));
                    if (!collectorExists)
                    {
                        MessageBox.Show("Колекціонер успішно доданий!", "Додавання", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AppState.CollectorsList.Add(newCollector);
                        AppState.isEdit = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Такий колекціонер вже існує у списку!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Заповніть всі поля коректно!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля коректно", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
