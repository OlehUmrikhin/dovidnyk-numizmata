using dovidnyk_numizmata.Models;

namespace dovidnyk_numizmata.Forms
{
    partial class CoinsForm
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
            titleCoinsLabel = new Label();
            countryCoinsLabel = new Label();
            parCoinsLabel = new Label();
            yearOfGraduationCoinsLabel = new Label();
            MaterialCoinsLabel = new Label();
            numberCoinsLabel = new Label();
            FeaturesCoinsLabel = new Label();
            countryCoinsTextBox = new TextBox();
            coinBindingSource = new BindingSource(components);
            parCoinsTextBox = new TextBox();
            yearOfGraduationCoinsTextBox = new TextBox();
            materialCoinsTextBox = new TextBox();
            numberCoinsTextBox = new TextBox();
            featuresCoinsTextBox = new TextBox();
            coinsListBox = new ListBox();
            addButton = new Button();
            deleteButton = new Button();
            searchButton = new Button();
            menuStrip1 = new MenuStrip();
            закритиToolStripMenuItem = new ToolStripMenuItem();
            зберігтиToolStripMenuItem = new ToolStripMenuItem();
            колекціонериToolStripMenuItem = new ToolStripMenuItem();
            мояКолекціяToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleCoinsLabel
            // 
            titleCoinsLabel.AutoSize = true;
            titleCoinsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleCoinsLabel.Location = new Point(492, 28);
            titleCoinsLabel.Name = "titleCoinsLabel";
            titleCoinsLabel.Size = new Size(186, 21);
            titleCoinsLabel.TabIndex = 0;
            titleCoinsLabel.Text = "Взаємодія з монетами";
            // 
            // countryCoinsLabel
            // 
            countryCoinsLabel.AutoSize = true;
            countryCoinsLabel.Location = new Point(52, 70);
            countryCoinsLabel.Name = "countryCoinsLabel";
            countryCoinsLabel.Size = new Size(46, 15);
            countryCoinsLabel.TabIndex = 1;
            countryCoinsLabel.Text = "Країна:";
            // 
            // parCoinsLabel
            // 
            parCoinsLabel.AutoSize = true;
            parCoinsLabel.Location = new Point(52, 105);
            parCoinsLabel.Name = "parCoinsLabel";
            parCoinsLabel.Size = new Size(58, 15);
            parCoinsLabel.TabIndex = 2;
            parCoinsLabel.Text = "Номінал:";
            // 
            // yearOfGraduationCoinsLabel
            // 
            yearOfGraduationCoinsLabel.AutoSize = true;
            yearOfGraduationCoinsLabel.Location = new Point(52, 140);
            yearOfGraduationCoinsLabel.Name = "yearOfGraduationCoinsLabel";
            yearOfGraduationCoinsLabel.Size = new Size(73, 15);
            yearOfGraduationCoinsLabel.TabIndex = 3;
            yearOfGraduationCoinsLabel.Text = "Рік випуску:";
            // 
            // MaterialCoinsLabel
            // 
            MaterialCoinsLabel.AutoSize = true;
            MaterialCoinsLabel.Location = new Point(52, 175);
            MaterialCoinsLabel.Name = "MaterialCoinsLabel";
            MaterialCoinsLabel.Size = new Size(61, 15);
            MaterialCoinsLabel.TabIndex = 4;
            MaterialCoinsLabel.Text = "Матеріал:";
            // 
            // numberCoinsLabel
            // 
            numberCoinsLabel.AutoSize = true;
            numberCoinsLabel.Location = new Point(52, 210);
            numberCoinsLabel.Name = "numberCoinsLabel";
            numberCoinsLabel.Size = new Size(162, 15);
            numberCoinsLabel.TabIndex = 5;
            numberCoinsLabel.Text = "Кількість випущених монет:";
            // 
            // FeaturesCoinsLabel
            // 
            FeaturesCoinsLabel.AutoSize = true;
            FeaturesCoinsLabel.Location = new Point(52, 245);
            FeaturesCoinsLabel.Name = "FeaturesCoinsLabel";
            FeaturesCoinsLabel.Size = new Size(124, 15);
            FeaturesCoinsLabel.TabIndex = 6;
            FeaturesCoinsLabel.Text = "Особливості монети:";
            // 
            // countryCoinsTextBox
            // 
            countryCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Country", true));
            countryCoinsTextBox.Location = new Point(124, 66);
            countryCoinsTextBox.Name = "countryCoinsTextBox";
            countryCoinsTextBox.Size = new Size(259, 23);
            countryCoinsTextBox.TabIndex = 7;
            countryCoinsTextBox.Text = " ";
            // 
            // parCoinsTextBox
            // 
            parCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Par", true));
            parCoinsTextBox.Location = new Point(124, 102);
            parCoinsTextBox.Name = "parCoinsTextBox";
            parCoinsTextBox.Size = new Size(259, 23);
            parCoinsTextBox.TabIndex = 8;
            // 
            // yearOfGraduationCoinsTextBox
            // 
            yearOfGraduationCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "YearOfGraduation", true));
            yearOfGraduationCoinsTextBox.Location = new Point(124, 137);
            yearOfGraduationCoinsTextBox.Name = "yearOfGraduationCoinsTextBox";
            yearOfGraduationCoinsTextBox.Size = new Size(259, 23);
            yearOfGraduationCoinsTextBox.TabIndex = 9;
            // 
            // materialCoinsTextBox
            // 
            materialCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Material", true));
            materialCoinsTextBox.Location = new Point(124, 172);
            materialCoinsTextBox.Name = "materialCoinsTextBox";
            materialCoinsTextBox.Size = new Size(259, 23);
            materialCoinsTextBox.TabIndex = 10;
            // 
            // numberCoinsTextBox
            // 
            numberCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Amount", true));
            numberCoinsTextBox.Location = new Point(219, 207);
            numberCoinsTextBox.Name = "numberCoinsTextBox";
            numberCoinsTextBox.Size = new Size(164, 23);
            numberCoinsTextBox.TabIndex = 11;
            // 
            // featuresCoinsTextBox
            // 
            featuresCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Features", true));
            featuresCoinsTextBox.Location = new Point(182, 242);
            featuresCoinsTextBox.Name = "featuresCoinsTextBox";
            featuresCoinsTextBox.Size = new Size(201, 23);
            featuresCoinsTextBox.TabIndex = 12;
            // 
            // coinsListBox
            // 
            coinsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            coinsListBox.DataSource = coinBindingSource;
            coinsListBox.DisplayMember = "Info";
            coinsListBox.Font = new Font("Segoe UI", 11F);
            coinsListBox.FormattingEnabled = true;
            coinsListBox.Location = new Point(424, 69);
            coinsListBox.Name = "coinsListBox";
            coinsListBox.Size = new Size(660, 304);
            coinsListBox.TabIndex = 13;
            coinsListBox.SelectedIndexChanged += coinsListBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 10);
            addButton.Name = "addButton";
            addButton.Size = new Size(66, 50);
            addButton.TabIndex = 14;
            addButton.Text = "Додати монету";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(88, 10);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(67, 50);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "Видалити монету";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(174, 10);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 50);
            searchButton.TabIndex = 17;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { закритиToolStripMenuItem, зберігтиToolStripMenuItem, колекціонериToolStripMenuItem, мояКолекціяToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1114, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // закритиToolStripMenuItem
            // 
            закритиToolStripMenuItem.Name = "закритиToolStripMenuItem";
            закритиToolStripMenuItem.Size = new Size(64, 20);
            закритиToolStripMenuItem.Text = "Закрити";
            закритиToolStripMenuItem.Click += закритиToolStripMenuItem_Click;
            // 
            // зберігтиToolStripMenuItem
            // 
            зберігтиToolStripMenuItem.Name = "зберігтиToolStripMenuItem";
            зберігтиToolStripMenuItem.Size = new Size(69, 20);
            зберігтиToolStripMenuItem.Text = "Зберегти";
            зберігтиToolStripMenuItem.Click += зберігтиToolStripMenuItem_Click;
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
            // panel1
            // 
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(deleteButton);
            panel1.Location = new Point(47, 314);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 73);
            panel1.TabIndex = 19;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(268, 10);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(68, 50);
            clearButton.TabIndex = 18;
            clearButton.Text = "Очистити поля";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // CoinsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1114, 450);
            Controls.Add(panel1);
            Controls.Add(coinsListBox);
            Controls.Add(featuresCoinsTextBox);
            Controls.Add(numberCoinsTextBox);
            Controls.Add(materialCoinsTextBox);
            Controls.Add(yearOfGraduationCoinsTextBox);
            Controls.Add(parCoinsTextBox);
            Controls.Add(countryCoinsTextBox);
            Controls.Add(FeaturesCoinsLabel);
            Controls.Add(numberCoinsLabel);
            Controls.Add(MaterialCoinsLabel);
            Controls.Add(yearOfGraduationCoinsLabel);
            Controls.Add(parCoinsLabel);
            Controls.Add(countryCoinsLabel);
            Controls.Add(titleCoinsLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CoinsForm";
            Text = "CoinsForm";
            Click += CoinsForm_Click;
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleCoinsLabel;
        private Label countryCoinsLabel;
        private Label parCoinsLabel;
        private Label yearOfGraduationCoinsLabel;
        private Label MaterialCoinsLabel;
        private Label numberCoinsLabel;
        private Label FeaturesCoinsLabel;
        private TextBox countryCoinsTextBox;
        private TextBox parCoinsTextBox;
        private TextBox yearOfGraduationCoinsTextBox;
        private TextBox materialCoinsTextBox;
        private TextBox numberCoinsTextBox;
        private TextBox featuresCoinsTextBox;
        private ListBox coinsListBox;
        private Button addButton;
        private Button deleteButton;
        private Button searchButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem закритиToolStripMenuItem;
        private ToolStripMenuItem зберігтиToolStripMenuItem;
        private Panel panel1;
        private Button clearButton;
        private BindingSource coinBindingSource;
        private ToolStripMenuItem колекціонериToolStripMenuItem;
        private ToolStripMenuItem мояКолекціяToolStripMenuItem;
    }
}