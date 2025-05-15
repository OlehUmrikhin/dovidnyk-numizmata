using dovidnyk_numizmata.Models;

namespace dovidnyk_numizmata.Forms
{
    partial class CollectionsOfCollectorsForm
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
            countryAllCoinsLabel = new Label();
            parAllCoinsLabel = new Label();
            yearOfGraduationAllCoinsLabel = new Label();
            materialAllCoinsLabel = new Label();
            numberAllCoinsLabel = new Label();
            featuresAllCoinsLabel = new Label();
            countryAllCoinsTextBox = new TextBox();
            coinBindingSource = new BindingSource(components);
            parAllCoinsTextBox = new TextBox();
            yearOfGraduationAllCoinsTextBox = new TextBox();
            materialAllCoinsTextBox = new TextBox();
            numberAllCoinsTextBox = new TextBox();
            featuresAllCoinsTextBox = new TextBox();
            AllCoinsListBox = new ListBox();
            searchingAllCoinsTextBox = new TextBox();
            searchingAllCoinsButton = new Button();
            addCoinToCollectionOfCollectorButton = new Button();
            AllCoinsTitle = new Label();
            countryCollectionOfCollectorLabel = new Label();
            parCollectionOfCollectorLabel = new Label();
            yearOfGraduationCollectionOfCollectorLabel = new Label();
            materialCollectionOfCollectorLabel = new Label();
            numberCollectionOfCollectorLabel = new Label();
            featuresCollectionOfCollectorLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            CollectionOfCollectorListBox = new ListBox();
            ownedCoinBindingSource = new BindingSource(components);
            CollectionOfCollectorTitle = new Label();
            searchingCollectionOfCollectorButton = new Button();
            searchingCollectionOfCollectorTextBox = new TextBox();
            deleteCoinInCollectionOfCollectorButton = new Button();
            menuStrip1 = new MenuStrip();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ownedCoinBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // countryAllCoinsLabel
            // 
            countryAllCoinsLabel.AutoSize = true;
            countryAllCoinsLabel.Location = new Point(27, 68);
            countryAllCoinsLabel.Name = "countryAllCoinsLabel";
            countryAllCoinsLabel.Size = new Size(46, 15);
            countryAllCoinsLabel.TabIndex = 0;
            countryAllCoinsLabel.Text = "Країна:";
            // 
            // parAllCoinsLabel
            // 
            parAllCoinsLabel.AutoSize = true;
            parAllCoinsLabel.Location = new Point(27, 100);
            parAllCoinsLabel.Name = "parAllCoinsLabel";
            parAllCoinsLabel.Size = new Size(58, 15);
            parAllCoinsLabel.TabIndex = 1;
            parAllCoinsLabel.Text = "Номінал:";
            // 
            // yearOfGraduationAllCoinsLabel
            // 
            yearOfGraduationAllCoinsLabel.AutoSize = true;
            yearOfGraduationAllCoinsLabel.Location = new Point(27, 129);
            yearOfGraduationAllCoinsLabel.Name = "yearOfGraduationAllCoinsLabel";
            yearOfGraduationAllCoinsLabel.Size = new Size(73, 15);
            yearOfGraduationAllCoinsLabel.TabIndex = 2;
            yearOfGraduationAllCoinsLabel.Text = "Рік випуску:";
            // 
            // materialAllCoinsLabel
            // 
            materialAllCoinsLabel.AutoSize = true;
            materialAllCoinsLabel.Location = new Point(27, 160);
            materialAllCoinsLabel.Name = "materialAllCoinsLabel";
            materialAllCoinsLabel.Size = new Size(61, 15);
            materialAllCoinsLabel.TabIndex = 3;
            materialAllCoinsLabel.Text = "Матеріал:";
            // 
            // numberAllCoinsLabel
            // 
            numberAllCoinsLabel.AutoSize = true;
            numberAllCoinsLabel.Location = new Point(27, 191);
            numberAllCoinsLabel.Name = "numberAllCoinsLabel";
            numberAllCoinsLabel.Size = new Size(162, 15);
            numberAllCoinsLabel.TabIndex = 4;
            numberAllCoinsLabel.Text = "Кількість випущених монет:";
            // 
            // featuresAllCoinsLabel
            // 
            featuresAllCoinsLabel.AutoSize = true;
            featuresAllCoinsLabel.Location = new Point(27, 223);
            featuresAllCoinsLabel.Name = "featuresAllCoinsLabel";
            featuresAllCoinsLabel.Size = new Size(80, 15);
            featuresAllCoinsLabel.TabIndex = 5;
            featuresAllCoinsLabel.Text = "Особливості:";
            // 
            // countryAllCoinsTextBox
            // 
            countryAllCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Country", true));
            countryAllCoinsTextBox.Location = new Point(79, 64);
            countryAllCoinsTextBox.Name = "countryAllCoinsTextBox";
            countryAllCoinsTextBox.ReadOnly = true;
            countryAllCoinsTextBox.Size = new Size(177, 23);
            countryAllCoinsTextBox.TabIndex = 6;
            // 
            // coinBindingSource
            // 
            coinBindingSource.DataSource = typeof(Coin);
            // 
            // parAllCoinsTextBox
            // 
            parAllCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Par", true));
            parAllCoinsTextBox.Location = new Point(91, 96);
            parAllCoinsTextBox.Name = "parAllCoinsTextBox";
            parAllCoinsTextBox.ReadOnly = true;
            parAllCoinsTextBox.Size = new Size(165, 23);
            parAllCoinsTextBox.TabIndex = 7;
            // 
            // yearOfGraduationAllCoinsTextBox
            // 
            yearOfGraduationAllCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "YearOfGraduation", true));
            yearOfGraduationAllCoinsTextBox.Location = new Point(107, 126);
            yearOfGraduationAllCoinsTextBox.Name = "yearOfGraduationAllCoinsTextBox";
            yearOfGraduationAllCoinsTextBox.ReadOnly = true;
            yearOfGraduationAllCoinsTextBox.Size = new Size(149, 23);
            yearOfGraduationAllCoinsTextBox.TabIndex = 8;
            // 
            // materialAllCoinsTextBox
            // 
            materialAllCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Material", true));
            materialAllCoinsTextBox.Location = new Point(94, 157);
            materialAllCoinsTextBox.Name = "materialAllCoinsTextBox";
            materialAllCoinsTextBox.ReadOnly = true;
            materialAllCoinsTextBox.Size = new Size(162, 23);
            materialAllCoinsTextBox.TabIndex = 9;
            // 
            // numberAllCoinsTextBox
            // 
            numberAllCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Amount", true));
            numberAllCoinsTextBox.Location = new Point(196, 188);
            numberAllCoinsTextBox.Name = "numberAllCoinsTextBox";
            numberAllCoinsTextBox.ReadOnly = true;
            numberAllCoinsTextBox.Size = new Size(60, 23);
            numberAllCoinsTextBox.TabIndex = 10;
            // 
            // featuresAllCoinsTextBox
            // 
            featuresAllCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Features", true));
            featuresAllCoinsTextBox.Location = new Point(117, 220);
            featuresAllCoinsTextBox.Name = "featuresAllCoinsTextBox";
            featuresAllCoinsTextBox.ReadOnly = true;
            featuresAllCoinsTextBox.Size = new Size(139, 23);
            featuresAllCoinsTextBox.TabIndex = 11;
            // 
            // AllCoinsListBox
            // 
            AllCoinsListBox.DataSource = coinBindingSource;
            AllCoinsListBox.DisplayMember = "Info";
            AllCoinsListBox.FormattingEnabled = true;
            AllCoinsListBox.Location = new Point(281, 64);
            AllCoinsListBox.Name = "AllCoinsListBox";
            AllCoinsListBox.Size = new Size(435, 364);
            AllCoinsListBox.TabIndex = 12;
            // 
            // searchingAllCoinsTextBox
            // 
            searchingAllCoinsTextBox.Location = new Point(122, 281);
            searchingAllCoinsTextBox.Name = "searchingAllCoinsTextBox";
            searchingAllCoinsTextBox.Size = new Size(134, 23);
            searchingAllCoinsTextBox.TabIndex = 14;
            // 
            // searchingAllCoinsButton
            // 
            searchingAllCoinsButton.Location = new Point(31, 281);
            searchingAllCoinsButton.Name = "searchingAllCoinsButton";
            searchingAllCoinsButton.Size = new Size(75, 23);
            searchingAllCoinsButton.TabIndex = 15;
            searchingAllCoinsButton.Text = "Пошук";
            searchingAllCoinsButton.UseVisualStyleBackColor = true;
            searchingAllCoinsButton.Click += searchingAllCoinsButton_Click;
            // 
            // addCoinToCollectionOfCollectorButton
            // 
            addCoinToCollectionOfCollectorButton.Location = new Point(94, 374);
            addCoinToCollectionOfCollectorButton.Name = "addCoinToCollectionOfCollectorButton";
            addCoinToCollectionOfCollectorButton.Size = new Size(75, 23);
            addCoinToCollectionOfCollectorButton.TabIndex = 16;
            addCoinToCollectionOfCollectorButton.Text = "Додати";
            addCoinToCollectionOfCollectorButton.UseVisualStyleBackColor = true;
            addCoinToCollectionOfCollectorButton.Click += addCoinToCollectionOfCollectorButton_Click;
            // 
            // AllCoinsTitle
            // 
            AllCoinsTitle.AutoSize = true;
            AllCoinsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AllCoinsTitle.Location = new Point(303, 30);
            AllCoinsTitle.Name = "AllCoinsTitle";
            AllCoinsTitle.Size = new Size(95, 21);
            AllCoinsTitle.TabIndex = 17;
            AllCoinsTitle.Text = "Всі монети";
            // 
            // countryCollectionOfCollectorLabel
            // 
            countryCollectionOfCollectorLabel.AutoSize = true;
            countryCollectionOfCollectorLabel.Location = new Point(722, 72);
            countryCollectionOfCollectorLabel.Name = "countryCollectionOfCollectorLabel";
            countryCollectionOfCollectorLabel.Size = new Size(46, 15);
            countryCollectionOfCollectorLabel.TabIndex = 18;
            countryCollectionOfCollectorLabel.Text = "Країна:";
            // 
            // parCollectionOfCollectorLabel
            // 
            parCollectionOfCollectorLabel.AutoSize = true;
            parCollectionOfCollectorLabel.Location = new Point(722, 103);
            parCollectionOfCollectorLabel.Name = "parCollectionOfCollectorLabel";
            parCollectionOfCollectorLabel.Size = new Size(58, 15);
            parCollectionOfCollectorLabel.TabIndex = 19;
            parCollectionOfCollectorLabel.Text = "Номінал:";
            // 
            // yearOfGraduationCollectionOfCollectorLabel
            // 
            yearOfGraduationCollectionOfCollectorLabel.AutoSize = true;
            yearOfGraduationCollectionOfCollectorLabel.Location = new Point(722, 137);
            yearOfGraduationCollectionOfCollectorLabel.Name = "yearOfGraduationCollectionOfCollectorLabel";
            yearOfGraduationCollectionOfCollectorLabel.Size = new Size(73, 15);
            yearOfGraduationCollectionOfCollectorLabel.TabIndex = 20;
            yearOfGraduationCollectionOfCollectorLabel.Text = "Рік випуску:";
            // 
            // materialCollectionOfCollectorLabel
            // 
            materialCollectionOfCollectorLabel.AutoSize = true;
            materialCollectionOfCollectorLabel.Location = new Point(722, 170);
            materialCollectionOfCollectorLabel.Name = "materialCollectionOfCollectorLabel";
            materialCollectionOfCollectorLabel.Size = new Size(61, 15);
            materialCollectionOfCollectorLabel.TabIndex = 21;
            materialCollectionOfCollectorLabel.Text = "Матеріал:";
            // 
            // numberCollectionOfCollectorLabel
            // 
            numberCollectionOfCollectorLabel.AutoSize = true;
            numberCollectionOfCollectorLabel.Location = new Point(722, 204);
            numberCollectionOfCollectorLabel.Name = "numberCollectionOfCollectorLabel";
            numberCollectionOfCollectorLabel.Size = new Size(162, 15);
            numberCollectionOfCollectorLabel.TabIndex = 22;
            numberCollectionOfCollectorLabel.Text = "Кількість випущених монет:";
            // 
            // featuresCollectionOfCollectorLabel
            // 
            featuresCollectionOfCollectorLabel.AutoSize = true;
            featuresCollectionOfCollectorLabel.Location = new Point(722, 238);
            featuresCollectionOfCollectorLabel.Name = "featuresCollectionOfCollectorLabel";
            featuresCollectionOfCollectorLabel.Size = new Size(80, 15);
            featuresCollectionOfCollectorLabel.TabIndex = 23;
            featuresCollectionOfCollectorLabel.Text = "Особливості:";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", coinBindingSource, "Country", true));
            textBox1.Location = new Point(783, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", coinBindingSource, "Par", true));
            textBox2.Location = new Point(790, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", coinBindingSource, "YearOfGraduation", true));
            textBox3.Location = new Point(800, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", coinBindingSource, "Material", true));
            textBox4.Location = new Point(786, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 23);
            textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", coinBindingSource, "Amount", true));
            textBox5.Location = new Point(888, 202);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(59, 23);
            textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", coinBindingSource, "Features", true));
            textBox6.Location = new Point(808, 235);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 23);
            textBox6.TabIndex = 29;
            // 
            // CollectionOfCollectorListBox
            // 
            CollectionOfCollectorListBox.DataSource = ownedCoinBindingSource;
            CollectionOfCollectorListBox.DisplayMember = "Info";
            CollectionOfCollectorListBox.FormattingEnabled = true;
            CollectionOfCollectorListBox.Location = new Point(961, 69);
            CollectionOfCollectorListBox.Name = "CollectionOfCollectorListBox";
            CollectionOfCollectorListBox.Size = new Size(465, 364);
            CollectionOfCollectorListBox.TabIndex = 30;
            // 
            // ownedCoinBindingSource
            // 
            ownedCoinBindingSource.DataSource = typeof(OwnedCoin);
            // 
            // CollectionOfCollectorTitle
            // 
            CollectionOfCollectorTitle.AutoSize = true;
            CollectionOfCollectorTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CollectionOfCollectorTitle.Location = new Point(985, 30);
            CollectionOfCollectorTitle.Name = "CollectionOfCollectorTitle";
            CollectionOfCollectorTitle.Size = new Size(196, 21);
            CollectionOfCollectorTitle.TabIndex = 31;
            CollectionOfCollectorTitle.Text = "Колекція колекціонера";
            // 
            // searchingCollectionOfCollectorButton
            // 
            searchingCollectionOfCollectorButton.Location = new Point(724, 286);
            searchingCollectionOfCollectorButton.Name = "searchingCollectionOfCollectorButton";
            searchingCollectionOfCollectorButton.Size = new Size(75, 23);
            searchingCollectionOfCollectorButton.TabIndex = 32;
            searchingCollectionOfCollectorButton.Text = "Пошук";
            searchingCollectionOfCollectorButton.UseVisualStyleBackColor = true;
            // 
            // searchingCollectionOfCollectorTextBox
            // 
            searchingCollectionOfCollectorTextBox.Location = new Point(808, 285);
            searchingCollectionOfCollectorTextBox.Name = "searchingCollectionOfCollectorTextBox";
            searchingCollectionOfCollectorTextBox.Size = new Size(139, 23);
            searchingCollectionOfCollectorTextBox.TabIndex = 33;
            // 
            // deleteCoinInCollectionOfCollectorButton
            // 
            deleteCoinInCollectionOfCollectorButton.Location = new Point(800, 374);
            deleteCoinInCollectionOfCollectorButton.Name = "deleteCoinInCollectionOfCollectorButton";
            deleteCoinInCollectionOfCollectorButton.Size = new Size(75, 23);
            deleteCoinInCollectionOfCollectorButton.TabIndex = 34;
            deleteCoinInCollectionOfCollectorButton.Text = "Видалити";
            deleteCoinInCollectionOfCollectorButton.UseVisualStyleBackColor = true;
            deleteCoinInCollectionOfCollectorButton.Click += deleteCoinInCollectionOfCollectorButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { зберегтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1446, 24);
            menuStrip1.TabIndex = 35;
            menuStrip1.Text = "menuStrip1";
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(69, 20);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // CollectionsOfCollectorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 450);
            Controls.Add(deleteCoinInCollectionOfCollectorButton);
            Controls.Add(searchingCollectionOfCollectorTextBox);
            Controls.Add(searchingCollectionOfCollectorButton);
            Controls.Add(CollectionOfCollectorTitle);
            Controls.Add(CollectionOfCollectorListBox);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(featuresCollectionOfCollectorLabel);
            Controls.Add(numberCollectionOfCollectorLabel);
            Controls.Add(materialCollectionOfCollectorLabel);
            Controls.Add(yearOfGraduationCollectionOfCollectorLabel);
            Controls.Add(parCollectionOfCollectorLabel);
            Controls.Add(countryCollectionOfCollectorLabel);
            Controls.Add(AllCoinsTitle);
            Controls.Add(addCoinToCollectionOfCollectorButton);
            Controls.Add(searchingAllCoinsButton);
            Controls.Add(searchingAllCoinsTextBox);
            Controls.Add(AllCoinsListBox);
            Controls.Add(featuresAllCoinsTextBox);
            Controls.Add(numberAllCoinsTextBox);
            Controls.Add(materialAllCoinsTextBox);
            Controls.Add(yearOfGraduationAllCoinsTextBox);
            Controls.Add(parAllCoinsTextBox);
            Controls.Add(countryAllCoinsTextBox);
            Controls.Add(featuresAllCoinsLabel);
            Controls.Add(numberAllCoinsLabel);
            Controls.Add(materialAllCoinsLabel);
            Controls.Add(yearOfGraduationAllCoinsLabel);
            Controls.Add(parAllCoinsLabel);
            Controls.Add(countryAllCoinsLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CollectionsOfCollectorsForm";
            Text = "ColectionsOfCollectorsForm";
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ownedCoinBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label countryAllCoinsLabel;
        private Label parAllCoinsLabel;
        private Label yearOfGraduationAllCoinsLabel;
        private Label materialAllCoinsLabel;
        private Label numberAllCoinsLabel;
        private Label featuresAllCoinsLabel;
        private TextBox countryAllCoinsTextBox;
        private TextBox parAllCoinsTextBox;
        private TextBox yearOfGraduationAllCoinsTextBox;
        private TextBox materialAllCoinsTextBox;
        private TextBox numberAllCoinsTextBox;
        private TextBox featuresAllCoinsTextBox;
        private ListBox AllCoinsListBox;
        private TextBox searchingAllCoinsTextBox;
        private Button searchingAllCoinsButton;
        private Button addCoinToCollectionOfCollectorButton;
        private Label AllCoinsTitle;
        private Label countryCollectionOfCollectorLabel;
        private Label parCollectionOfCollectorLabel;
        private Label yearOfGraduationCollectionOfCollectorLabel;
        private Label materialCollectionOfCollectorLabel;
        private Label numberCollectionOfCollectorLabel;
        private Label featuresCollectionOfCollectorLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ListBox CollectionOfCollectorListBox;
        private Label CollectionOfCollectorTitle;
        private Button searchingCollectionOfCollectorButton;
        private TextBox searchingCollectionOfCollectorTextBox;
        private Button deleteCoinInCollectionOfCollectorButton;
        private BindingSource coinBindingSource;
        private BindingSource ownedCoinBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
    }
}