namespace dovidnyk_numizmata
{
    partial class MyCollectionForm
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
            titleMyCollectionLabel = new Label();
            menuStrip1 = new MenuStrip();
            наГоловнуToolStripMenuItem = new ToolStripMenuItem();
            монетиToolStripMenuItem = new ToolStripMenuItem();
            колекціонериToolStripMenuItem = new ToolStripMenuItem();
            мояКолекціяToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // titleMyCollectionLabel
            // 
            titleMyCollectionLabel.AutoSize = true;
            titleMyCollectionLabel.Location = new Point(258, 44);
            titleMyCollectionLabel.Name = "titleMyCollectionLabel";
            titleMyCollectionLabel.Size = new Size(82, 15);
            titleMyCollectionLabel.TabIndex = 0;
            titleMyCollectionLabel.Text = "Моя колекція";
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
            // MyCollectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleMyCollectionLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MyCollectionForm";
            Text = "MyCollectionForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleMyCollectionLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem наГоловнуToolStripMenuItem;
        private ToolStripMenuItem монетиToolStripMenuItem;
        private ToolStripMenuItem колекціонериToolStripMenuItem;
        private ToolStripMenuItem мояКолекціяToolStripMenuItem;
    }
}