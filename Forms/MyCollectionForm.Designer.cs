using dovidnyk_numizmata.Models;

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
            components = new System.ComponentModel.Container();
            titleMyCollectionLabel = new Label();
            menuStrip1 = new MenuStrip();
            наГоловнуToolStripMenuItem = new ToolStripMenuItem();
            countryCoinsMyCollectionLabel = new Label();
            parCoinsMyCollectionLabel = new Label();
            yearOfGraduationCoinsMyCollectionLabel = new Label();
            MaterialCoinsMyCollectionLabel = new Label();
            numberCoinsMyCollectionLabel = new Label();
            FeaturesCoinsMyCollectionLabel = new Label();
            countryCoinsMyCollectionTextBox = new TextBox();
            parCoinsMyCollectionTextBox = new TextBox();
            yearOfGraduationCoinsMyCollectionTextBox = new TextBox();
            materialCoinsMyCollectionTextBox = new TextBox();
            numberCoinsMyCollectionTextBox = new TextBox();
            featuresCoinsMyCollectionTextBox = new TextBox();
            coinsMyCollectionListBox = new ListBox();
            ownedCoinBindingSource = new BindingSource(components);
            coinBindingSource = new BindingSource(components);
            addButton = new Button();
            deleteButton = new Button();
            searchButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ownedCoinBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).BeginInit();
            SuspendLayout();
            // 
            // titleMyCollectionLabel
            // 
            titleMyCollectionLabel.AutoSize = true;
            titleMyCollectionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleMyCollectionLabel.Location = new Point(472, 37);
            titleMyCollectionLabel.Name = "titleMyCollectionLabel";
            titleMyCollectionLabel.Size = new Size(119, 21);
            titleMyCollectionLabel.TabIndex = 0;
            titleMyCollectionLabel.Text = "Моя колекція";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { наГоловнуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1043, 24);
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
            // countryCoinsMyCollectionLabel
            // 
            countryCoinsMyCollectionLabel.AutoSize = true;
            countryCoinsMyCollectionLabel.Location = new Point(27, 70);
            countryCoinsMyCollectionLabel.Name = "countryCoinsMyCollectionLabel";
            countryCoinsMyCollectionLabel.Size = new Size(46, 15);
            countryCoinsMyCollectionLabel.TabIndex = 2;
            countryCoinsMyCollectionLabel.Text = "Країна:";
            // 
            // parCoinsMyCollectionLabel
            // 
            parCoinsMyCollectionLabel.AutoSize = true;
            parCoinsMyCollectionLabel.Location = new Point(27, 105);
            parCoinsMyCollectionLabel.Name = "parCoinsMyCollectionLabel";
            parCoinsMyCollectionLabel.Size = new Size(58, 15);
            parCoinsMyCollectionLabel.TabIndex = 3;
            parCoinsMyCollectionLabel.Text = "Номінал:";
            // 
            // yearOfGraduationCoinsMyCollectionLabel
            // 
            yearOfGraduationCoinsMyCollectionLabel.AutoSize = true;
            yearOfGraduationCoinsMyCollectionLabel.Location = new Point(27, 140);
            yearOfGraduationCoinsMyCollectionLabel.Name = "yearOfGraduationCoinsMyCollectionLabel";
            yearOfGraduationCoinsMyCollectionLabel.Size = new Size(73, 15);
            yearOfGraduationCoinsMyCollectionLabel.TabIndex = 4;
            yearOfGraduationCoinsMyCollectionLabel.Text = "Рік випуску:";
            // 
            // MaterialCoinsMyCollectionLabel
            // 
            MaterialCoinsMyCollectionLabel.AutoSize = true;
            MaterialCoinsMyCollectionLabel.Location = new Point(27, 175);
            MaterialCoinsMyCollectionLabel.Name = "MaterialCoinsMyCollectionLabel";
            MaterialCoinsMyCollectionLabel.Size = new Size(61, 15);
            MaterialCoinsMyCollectionLabel.TabIndex = 5;
            MaterialCoinsMyCollectionLabel.Text = "Матеріал:";
            // 
            // numberCoinsMyCollectionLabel
            // 
            numberCoinsMyCollectionLabel.AutoSize = true;
            numberCoinsMyCollectionLabel.Location = new Point(27, 210);
            numberCoinsMyCollectionLabel.Name = "numberCoinsMyCollectionLabel";
            numberCoinsMyCollectionLabel.Size = new Size(162, 15);
            numberCoinsMyCollectionLabel.TabIndex = 6;
            numberCoinsMyCollectionLabel.Text = "Кількість випущених монет:";
            // 
            // FeaturesCoinsMyCollectionLabel
            // 
            FeaturesCoinsMyCollectionLabel.AutoSize = true;
            FeaturesCoinsMyCollectionLabel.Location = new Point(27, 245);
            FeaturesCoinsMyCollectionLabel.Name = "FeaturesCoinsMyCollectionLabel";
            FeaturesCoinsMyCollectionLabel.Size = new Size(124, 15);
            FeaturesCoinsMyCollectionLabel.TabIndex = 7;
            FeaturesCoinsMyCollectionLabel.Text = "Особливості монети:";
            // 
            // countryCoinsMyCollectionTextBox
            // 
            countryCoinsMyCollectionTextBox.Location = new Point(89, 65);
            countryCoinsMyCollectionTextBox.Name = "countryCoinsMyCollectionTextBox";
            countryCoinsMyCollectionTextBox.Size = new Size(261, 23);
            countryCoinsMyCollectionTextBox.TabIndex = 8;
            // 
            // parCoinsMyCollectionTextBox
            // 
            parCoinsMyCollectionTextBox.Location = new Point(90, 102);
            parCoinsMyCollectionTextBox.Name = "parCoinsMyCollectionTextBox";
            parCoinsMyCollectionTextBox.Size = new Size(260, 23);
            parCoinsMyCollectionTextBox.TabIndex = 9;
            // 
            // yearOfGraduationCoinsMyCollectionTextBox
            // 
            yearOfGraduationCoinsMyCollectionTextBox.Location = new Point(101, 136);
            yearOfGraduationCoinsMyCollectionTextBox.Name = "yearOfGraduationCoinsMyCollectionTextBox";
            yearOfGraduationCoinsMyCollectionTextBox.Size = new Size(249, 23);
            yearOfGraduationCoinsMyCollectionTextBox.TabIndex = 10;
            // 
            // materialCoinsMyCollectionTextBox
            // 
            materialCoinsMyCollectionTextBox.Location = new Point(95, 172);
            materialCoinsMyCollectionTextBox.Name = "materialCoinsMyCollectionTextBox";
            materialCoinsMyCollectionTextBox.Size = new Size(255, 23);
            materialCoinsMyCollectionTextBox.TabIndex = 11;
            // 
            // numberCoinsMyCollectionTextBox
            // 
            numberCoinsMyCollectionTextBox.Location = new Point(191, 207);
            numberCoinsMyCollectionTextBox.Name = "numberCoinsMyCollectionTextBox";
            numberCoinsMyCollectionTextBox.Size = new Size(159, 23);
            numberCoinsMyCollectionTextBox.TabIndex = 12;
            // 
            // featuresCoinsMyCollectionTextBox
            // 
            featuresCoinsMyCollectionTextBox.Location = new Point(157, 242);
            featuresCoinsMyCollectionTextBox.Name = "featuresCoinsMyCollectionTextBox";
            featuresCoinsMyCollectionTextBox.Size = new Size(193, 23);
            featuresCoinsMyCollectionTextBox.TabIndex = 13;
            // 
            // coinsMyCollectionListBox
            // 
            coinsMyCollectionListBox.DataSource = ownedCoinBindingSource;
            coinsMyCollectionListBox.Font = new Font("Segoe UI", 11F);
            coinsMyCollectionListBox.FormattingEnabled = true;
            coinsMyCollectionListBox.Location = new Point(401, 65);
            coinsMyCollectionListBox.Name = "coinsMyCollectionListBox";
            coinsMyCollectionListBox.Size = new Size(601, 284);
            coinsMyCollectionListBox.TabIndex = 14;
            // 
            // ownedCoinBindingSource
            // 
            ownedCoinBindingSource.DataSource = typeof(OwnedCoin);
            // 
            // coinBindingSource
            // 
            coinBindingSource.DataSource = typeof(Coin);
            // 
            // addButton
            // 
            addButton.Location = new Point(30, 293);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 15;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(126, 293);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 16;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(222, 293);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 17;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // MyCollectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(searchButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(coinsMyCollectionListBox);
            Controls.Add(featuresCoinsMyCollectionTextBox);
            Controls.Add(numberCoinsMyCollectionTextBox);
            Controls.Add(materialCoinsMyCollectionTextBox);
            Controls.Add(yearOfGraduationCoinsMyCollectionTextBox);
            Controls.Add(parCoinsMyCollectionTextBox);
            Controls.Add(countryCoinsMyCollectionTextBox);
            Controls.Add(FeaturesCoinsMyCollectionLabel);
            Controls.Add(numberCoinsMyCollectionLabel);
            Controls.Add(MaterialCoinsMyCollectionLabel);
            Controls.Add(yearOfGraduationCoinsMyCollectionLabel);
            Controls.Add(parCoinsMyCollectionLabel);
            Controls.Add(countryCoinsMyCollectionLabel);
            Controls.Add(titleMyCollectionLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MyCollectionForm";
            Text = "MyCollectionForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ownedCoinBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleMyCollectionLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem наГоловнуToolStripMenuItem;
        private Label countryCoinsMyCollectionLabel;
        private Label parCoinsMyCollectionLabel;
        private Label yearOfGraduationCoinsMyCollectionLabel;
        private Label MaterialCoinsMyCollectionLabel;
        private Label numberCoinsMyCollectionLabel;
        private Label FeaturesCoinsMyCollectionLabel;
        private TextBox countryCoinsMyCollectionTextBox;
        private TextBox parCoinsMyCollectionTextBox;
        private TextBox yearOfGraduationCoinsMyCollectionTextBox;
        private TextBox materialCoinsMyCollectionTextBox;
        private TextBox numberCoinsMyCollectionTextBox;
        private TextBox featuresCoinsMyCollectionTextBox;
        private ListBox coinsMyCollectionListBox;
        private BindingSource coinBindingSource;
        private Button addButton;
        private Button deleteButton;
        private Button searchButton;
        private BindingSource ownedCoinBindingSource;
    }
}