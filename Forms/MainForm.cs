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
    public partial class MainForm : Form
    {
        private CoinsForm coinsForm;
        private CollectorsForm collectorsForm;
        private MyCollectionForm myCollectionForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void coinsButton_Click(object sender, EventArgs e)
        {
            if (coinsForm == null || coinsForm.IsDisposed)
            {
                coinsForm = new CoinsForm();
            }
            coinsForm.Show();
        }
        private void collectorsButton_Click(object sender, EventArgs e)
        {
            if (collectorsForm == null || collectorsForm.IsDisposed)
            {
                collectorsForm = new CollectorsForm();
            }
            collectorsForm.Show();
        }

        private void myCollectionButton_Click(object sender, EventArgs e)
        {
            if (myCollectionForm == null || myCollectionForm.IsDisposed)
            {
                myCollectionForm = new MyCollectionForm();
            }
            myCollectionForm.Show();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
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
            if (collectorsForm == null || collectorsForm.IsDisposed)
            {
                collectorsForm = new CollectorsForm();
            }
            collectorsForm.Show();
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
