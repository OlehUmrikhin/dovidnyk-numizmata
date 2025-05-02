using dovidnyk_numizmata.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dovidnyk_numizmata
{
    public partial class MyCollectionForm : Form
    {
        private MainForm mainForm;
        private CollectorsForm collectorsForm;
        private CoinsForm coinsForm;
        public MyCollectionForm()
        {
            InitializeComponent();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm();
            }
            mainForm.Show();
        }

        private void монетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (coinsForm == null || coinsForm.IsDisposed)
            {
                coinsForm = new CoinsForm();
            }
            coinsForm.Show();
        }

        private void колекціонериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (collectorsForm == null || collectorsForm.IsDisposed)
            {
                collectorsForm = new CollectorsForm();
            }
            collectorsForm.Show();
        }

        private void мояКолекціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}