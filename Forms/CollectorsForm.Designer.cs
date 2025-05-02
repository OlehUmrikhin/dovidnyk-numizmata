namespace dovidnyk_numizmata
{
    partial class CollectorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleCollectorsLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            наГоловнуToolStripMenuItem = new ToolStripMenuItem();
            монетиToolStripMenuItem = new ToolStripMenuItem();
            колекціонериToolStripMenuItem = new ToolStripMenuItem();
            мояКолекціяToolStripMenuItem = new ToolStripMenuItem();
            countryCollectorsLabel = new Label();
            nameCollectorsLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // titleCollectorsLabel
            // 
            titleCollectorsLabel.AutoSize = true;
            titleCollectorsLabel.Location = new Point(261, 66);
            titleCollectorsLabel.Name = "titleCollectorsLabel";
            titleCollectorsLabel.Size = new Size(164, 15);
            titleCollectorsLabel.TabIndex = 0;
            titleCollectorsLabel.Text = "Взаємодія з колекціонерами";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { наГоловнуToolStripMenuItem, монетиToolStripMenuItem, колекціонериToolStripMenuItem, мояКолекціяToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // наГоловнуToolStripMenuItem
            // 
            наГоловнуToolStripMenuItem.Name = "наГоловнуToolStripMenuItem";
            наГоловнуToolStripMenuItem.Size = new Size(82, 20);
            наГоловнуToolStripMenuItem.Text = "На головну";
            наГоловнуToolStripMenuItem.Click += наГоловнуToolStripMenuItem_Click;
            // 
            // монетиToolStripMenuItem
            // 
            монетиToolStripMenuItem.Name = "монетиToolStripMenuItem";
            монетиToolStripMenuItem.Size = new Size(62, 20);
            монетиToolStripMenuItem.Text = "Монети";
            // 
            // колекціонериToolStripMenuItem
            // 
            колекціонериToolStripMenuItem.Name = "колекціонериToolStripMenuItem";
            колекціонериToolStripMenuItem.Size = new Size(96, 20);
            колекціонериToolStripMenuItem.Text = "Колекціонери";
            // 
            // мояКолекціяToolStripMenuItem
            // 
            мояКолекціяToolStripMenuItem.Name = "мояКолекціяToolStripMenuItem";
            мояКолекціяToolStripMenuItem.Size = new Size(94, 20);
            мояКолекціяToolStripMenuItem.Text = "Моя колекція";
            // 
            // countryCollectorsLabel
            // 
            countryCollectorsLabel.AutoSize = true;
            countryCollectorsLabel.Location = new Point(51, 115);
            countryCollectorsLabel.Name = "countryCollectorsLabel";
            countryCollectorsLabel.Size = new Size(46, 15);
            countryCollectorsLabel.TabIndex = 2;
            countryCollectorsLabel.Text = "Країна:";
            // 
            // nameCollectorsLabel
            // 
            nameCollectorsLabel.AutoSize = true;
            nameCollectorsLabel.Location = new Point(51, 144);
            nameCollectorsLabel.Name = "nameCollectorsLabel";
            nameCollectorsLabel.Size = new Size(31, 15);
            nameCollectorsLabel.TabIndex = 3;
            nameCollectorsLabel.Text = "Ім'я:";
            // 
            // CollectorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nameCollectorsLabel);
            Controls.Add(countryCollectorsLabel);
            Controls.Add(titleCollectorsLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CollectorsForm";
            Text = "CollectorsForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleCollectorsLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem наГоловнуToolStripMenuItem;
        private ToolStripMenuItem монетиToolStripMenuItem;
        private ToolStripMenuItem колекціонериToolStripMenuItem;
        private ToolStripMenuItem мояКолекціяToolStripMenuItem;
        private Label countryCollectorsLabel;
        private Label nameCollectorsLabel;
    }
}