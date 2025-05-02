namespace dovidnyk_numizmata.Forms
{
    partial class MainForm
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
            mainButtonsBox = new GroupBox();
            myCollectionButton = new Button();
            collectorsButton = new Button();
            coinsButton = new Button();
            welcomeLabel = new Label();
            menuStrip1 = new MenuStrip();
            наГоловнуToolStripMenuItem = new ToolStripMenuItem();
            монетиToolStripMenuItem = new ToolStripMenuItem();
            колекціонериToolStripMenuItem = new ToolStripMenuItem();
            мояКолекціяToolStripMenuItem = new ToolStripMenuItem();
            mainButtonsBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainButtonsBox
            // 
            mainButtonsBox.Controls.Add(myCollectionButton);
            mainButtonsBox.Controls.Add(collectorsButton);
            mainButtonsBox.Controls.Add(coinsButton);
            mainButtonsBox.Location = new Point(70, 159);
            mainButtonsBox.Name = "mainButtonsBox";
            mainButtonsBox.Size = new Size(640, 138);
            mainButtonsBox.TabIndex = 0;
            mainButtonsBox.TabStop = false;
            // 
            // myCollectionButton
            // 
            myCollectionButton.Font = new Font("Segoe UI", 12F);
            myCollectionButton.Location = new Point(449, 45);
            myCollectionButton.Name = "myCollectionButton";
            myCollectionButton.Size = new Size(120, 60);
            myCollectionButton.TabIndex = 2;
            myCollectionButton.Text = "Моя колекція";
            myCollectionButton.UseVisualStyleBackColor = true;
            myCollectionButton.Click += myCollectionButton_Click;
            // 
            // collectorsButton
            // 
            collectorsButton.Font = new Font("Segoe UI", 12F);
            collectorsButton.Location = new Point(254, 45);
            collectorsButton.Name = "collectorsButton";
            collectorsButton.Size = new Size(124, 60);
            collectorsButton.TabIndex = 1;
            collectorsButton.Text = "Колекціонери";
            collectorsButton.UseVisualStyleBackColor = true;
            collectorsButton.Click += collectorsButton_Click;
            // 
            // coinsButton
            // 
            coinsButton.Font = new Font("Segoe UI", 12F);
            coinsButton.Location = new Point(47, 45);
            coinsButton.Name = "coinsButton";
            coinsButton.Size = new Size(130, 60);
            coinsButton.TabIndex = 0;
            coinsButton.Text = "Монети";
            coinsButton.UseVisualStyleBackColor = true;
            coinsButton.Click += coinsButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Font = new Font("Segoe UI", 24F);
            welcomeLabel.Location = new Point(141, 41);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(500, 100);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Ласкаво просимо до програми \"Довідник нумізмата\"";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { наГоловнуToolStripMenuItem, монетиToolStripMenuItem, колекціонериToolStripMenuItem, мояКолекціяToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
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
            монетиToolStripMenuItem.Click += монетиToolStripMenuItem_Click;
            // 
            // колекціонериToolStripMenuItem
            // 
            колекціонериToolStripMenuItem.Name = "колекціонериToolStripMenuItem";
            колекціонериToolStripMenuItem.Size = new Size(96, 20);
            колекціонериToolStripMenuItem.Text = "Колекціонери";
            колекціонериToolStripMenuItem.Click += колекціонериToolStripMenuItem_Click;
            // 
            // мояКолекціяToolStripMenuItem
            // 
            мояКолекціяToolStripMenuItem.Name = "мояКолекціяToolStripMenuItem";
            мояКолекціяToolStripMenuItem.Size = new Size(94, 20);
            мояКолекціяToolStripMenuItem.Text = "Моя колекція";
            мояКолекціяToolStripMenuItem.Click += мояКолекціяToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(welcomeLabel);
            Controls.Add(mainButtonsBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            mainButtonsBox.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox mainButtonsBox;
        private Button myCollectionButton;
        private Button collectorsButton;
        private Button coinsButton;
        private Label welcomeLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem наГоловнуToolStripMenuItem;
        private ToolStripMenuItem монетиToolStripMenuItem;
        private ToolStripMenuItem колекціонериToolStripMenuItem;
        private ToolStripMenuItem мояКолекціяToolStripMenuItem;
    }
}