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
    public partial class CollectorsForm : Form
    {
        private MainForm mainForm;
        private CoinsForm coinsForm;
        private MyCollectionForm myCollectionForm;
        public CollectorsForm()
        {
            InitializeComponent();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm();
            }
            mainForm.Show();
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

        private void мояКолекціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myCollectionForm == null || myCollectionForm.IsDisposed)
            {
                myCollectionForm = new MyCollectionForm();
            }
            myCollectionForm.Show();
        }

    }
}