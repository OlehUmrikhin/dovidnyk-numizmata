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
            coinBindingSource = new BindingSource(components);
            searchingAllCoinsTextBox = new TextBox();
            addCoinToCollectionOfCollectorButton = new Button();
            AllCoinsTitle = new Label();
            ownedCoinBindingSource = new BindingSource(components);
            CollectionOfCollectorTitle = new Label();
            searchingCollectionOfCollectorTextBox = new TextBox();
            deleteCoinInCollectionOfCollectorButton = new Button();
            menuStrip1 = new MenuStrip();
            навігаціяToolStripMenuItem = new ToolStripMenuItem();
            монетиToolStripMenuItem = new ToolStripMenuItem();
            колекціонериToolStripMenuItem = new ToolStripMenuItem();
            мояКолекціяToolStripMenuItem = new ToolStripMenuItem();
            функціїToolStripMenuItem = new ToolStripMenuItem();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem1 = new ToolStripMenuItem();
            вийтиЗДодаткуToolStripMenuItem = new ToolStripMenuItem();
            collectorBindingSource = new BindingSource(components);
            NameOfCollectorTitle = new Label();
            allCoinsDataGridView = new DataGridView();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Par = new DataGridViewTextBoxColumn();
            yearOfGraduationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            featuresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remainingCoinsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IsRare = new DataGridViewCheckBoxColumn();
            collectionOfCollectorDataGridView = new DataGridView();
            CoinCountry = new DataGridViewTextBoxColumn();
            CoinPar = new DataGridViewTextBoxColumn();
            CoinYearOfGraduation = new DataGridViewTextBoxColumn();
            CoinMaterial = new DataGridViewTextBoxColumn();
            CoinAmount = new DataGridViewTextBoxColumn();
            CoinFeatures = new DataGridViewTextBoxColumn();
            CoinRemaining = new DataGridViewTextBoxColumn();
            conditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CoinIsRare = new DataGridViewCheckBoxColumn();
            searchingAllCoinsLabel = new Label();
            searchingCollectionOfCollectorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ownedCoinBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)collectorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allCoinsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)collectionOfCollectorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // coinBindingSource
            // 
            coinBindingSource.DataSource = typeof(Coin);
            // 
            // searchingAllCoinsTextBox
            // 
            searchingAllCoinsTextBox.Location = new Point(206, 66);
            searchingAllCoinsTextBox.Name = "searchingAllCoinsTextBox";
            searchingAllCoinsTextBox.Size = new Size(134, 23);
            searchingAllCoinsTextBox.TabIndex = 14;
            searchingAllCoinsTextBox.TextChanged += searchingAllCoinsTextBox_TextChanged;
            // 
            // addCoinToCollectionOfCollectorButton
            // 
            addCoinToCollectionOfCollectorButton.BackColor = SystemColors.Control;
            addCoinToCollectionOfCollectorButton.Location = new Point(357, 66);
            addCoinToCollectionOfCollectorButton.Name = "addCoinToCollectionOfCollectorButton";
            addCoinToCollectionOfCollectorButton.Size = new Size(75, 23);
            addCoinToCollectionOfCollectorButton.TabIndex = 16;
            addCoinToCollectionOfCollectorButton.Text = "Додати";
            addCoinToCollectionOfCollectorButton.UseVisualStyleBackColor = false;
            addCoinToCollectionOfCollectorButton.Click += addCoinToCollectionOfCollectorButton_Click;
            // 
            // AllCoinsTitle
            // 
            AllCoinsTitle.AutoSize = true;
            AllCoinsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AllCoinsTitle.Location = new Point(382, 30);
            AllCoinsTitle.Name = "AllCoinsTitle";
            AllCoinsTitle.Size = new Size(95, 21);
            AllCoinsTitle.TabIndex = 17;
            AllCoinsTitle.Text = "Всі монети";
            // 
            // ownedCoinBindingSource
            // 
            ownedCoinBindingSource.DataSource = typeof(OwnedCoin);
            // 
            // CollectionOfCollectorTitle
            // 
            CollectionOfCollectorTitle.AutoSize = true;
            CollectionOfCollectorTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CollectionOfCollectorTitle.Location = new Point(1279, 29);
            CollectionOfCollectorTitle.Name = "CollectionOfCollectorTitle";
            CollectionOfCollectorTitle.Size = new Size(200, 21);
            CollectionOfCollectorTitle.TabIndex = 31;
            CollectionOfCollectorTitle.Text = "Колекція колекціонера:";
            // 
            // searchingCollectionOfCollectorTextBox
            // 
            searchingCollectionOfCollectorTextBox.Location = new Point(1198, 69);
            searchingCollectionOfCollectorTextBox.Name = "searchingCollectionOfCollectorTextBox";
            searchingCollectionOfCollectorTextBox.Size = new Size(137, 23);
            searchingCollectionOfCollectorTextBox.TabIndex = 33;
            searchingCollectionOfCollectorTextBox.TextChanged += searchingCollectionOfCollectorTextBox_TextChanged;
            // 
            // deleteCoinInCollectionOfCollectorButton
            // 
            deleteCoinInCollectionOfCollectorButton.BackColor = SystemColors.Control;
            deleteCoinInCollectionOfCollectorButton.Location = new Point(1355, 69);
            deleteCoinInCollectionOfCollectorButton.Name = "deleteCoinInCollectionOfCollectorButton";
            deleteCoinInCollectionOfCollectorButton.Size = new Size(122, 23);
            deleteCoinInCollectionOfCollectorButton.TabIndex = 34;
            deleteCoinInCollectionOfCollectorButton.Text = "Видалити";
            deleteCoinInCollectionOfCollectorButton.UseVisualStyleBackColor = false;
            deleteCoinInCollectionOfCollectorButton.Click += deleteCoinInCollectionOfCollectorButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { навігаціяToolStripMenuItem, функціїToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 24);
            menuStrip1.TabIndex = 35;
            menuStrip1.Text = "menuStrip1";
            // 
            // навігаціяToolStripMenuItem
            // 
            навігаціяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { монетиToolStripMenuItem, колекціонериToolStripMenuItem, мояКолекціяToolStripMenuItem });
            навігаціяToolStripMenuItem.Name = "навігаціяToolStripMenuItem";
            навігаціяToolStripMenuItem.Size = new Size(83, 20);
            навігаціяToolStripMenuItem.Text = "Навігація ▾";
            // 
            // монетиToolStripMenuItem
            // 
            монетиToolStripMenuItem.Name = "монетиToolStripMenuItem";
            монетиToolStripMenuItem.Size = new Size(151, 22);
            монетиToolStripMenuItem.Text = "Монети";
            монетиToolStripMenuItem.Click += монетиToolStripMenuItem_Click;
            // 
            // колекціонериToolStripMenuItem
            // 
            колекціонериToolStripMenuItem.Name = "колекціонериToolStripMenuItem";
            колекціонериToolStripMenuItem.Size = new Size(151, 22);
            колекціонериToolStripMenuItem.Text = "Колекціонери";
            колекціонериToolStripMenuItem.Click += колекціонериToolStripMenuItem_Click;
            // 
            // мояКолекціяToolStripMenuItem
            // 
            мояКолекціяToolStripMenuItem.Name = "мояКолекціяToolStripMenuItem";
            мояКолекціяToolStripMenuItem.Size = new Size(151, 22);
            мояКолекціяToolStripMenuItem.Text = "Моя колекція";
            мояКолекціяToolStripMenuItem.Click += мояКолекціяToolStripMenuItem_Click;
            // 
            // функціїToolStripMenuItem
            // 
            функціїToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиToolStripMenuItem, видалитиToolStripMenuItem, зберегтиToolStripMenuItem1, вийтиЗДодаткуToolStripMenuItem });
            функціїToolStripMenuItem.Name = "функціїToolStripMenuItem";
            функціїToolStripMenuItem.Size = new Size(73, 20);
            функціїToolStripMenuItem.Text = "Функції ▾";
            // 
            // додатиToolStripMenuItem
            // 
            додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            додатиToolStripMenuItem.Size = new Size(160, 22);
            додатиToolStripMenuItem.Text = "Додати";
            додатиToolStripMenuItem.Click += addCoinToCollectionOfCollectorButton_Click;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(160, 22);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += deleteCoinInCollectionOfCollectorButton_Click;
            // 
            // зберегтиToolStripMenuItem1
            // 
            зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            зберегтиToolStripMenuItem1.Size = new Size(160, 22);
            зберегтиToolStripMenuItem1.Text = "Зберегти";
            зберегтиToolStripMenuItem1.Click += зберегтиToolStripMenuItem_Click;
            // 
            // вийтиЗДодаткуToolStripMenuItem
            // 
            вийтиЗДодаткуToolStripMenuItem.Name = "вийтиЗДодаткуToolStripMenuItem";
            вийтиЗДодаткуToolStripMenuItem.Size = new Size(160, 22);
            вийтиЗДодаткуToolStripMenuItem.Text = "Вийти з додатку";
            вийтиЗДодаткуToolStripMenuItem.Click += вийтиЗДодаткуToolStripMenuItem_Click;
            // 
            // collectorBindingSource
            // 
            collectorBindingSource.DataSource = typeof(Collector);
            // 
            // NameOfCollectorTitle
            // 
            NameOfCollectorTitle.AutoSize = true;
            NameOfCollectorTitle.DataBindings.Add(new Binding("Text", collectorBindingSource, "Name", true));
            NameOfCollectorTitle.Font = new Font("Segoe UI", 12F);
            NameOfCollectorTitle.Location = new Point(1484, 30);
            NameOfCollectorTitle.Name = "NameOfCollectorTitle";
            NameOfCollectorTitle.Size = new Size(101, 21);
            NameOfCollectorTitle.TabIndex = 40;
            NameOfCollectorTitle.Text = "Колекціонер";
            // 
            // allCoinsDataGridView
            // 
            allCoinsDataGridView.AllowUserToAddRows = false;
            allCoinsDataGridView.AllowUserToDeleteRows = false;
            allCoinsDataGridView.AutoGenerateColumns = false;
            allCoinsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allCoinsDataGridView.Columns.AddRange(new DataGridViewColumn[] { countryDataGridViewTextBoxColumn, Par, yearOfGraduationDataGridViewTextBoxColumn, materialDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, featuresDataGridViewTextBoxColumn, remainingCoinsDataGridViewTextBoxColumn, IsRare });
            allCoinsDataGridView.DataSource = coinBindingSource;
            allCoinsDataGridView.Location = new Point(12, 108);
            allCoinsDataGridView.MultiSelect = false;
            allCoinsDataGridView.Name = "allCoinsDataGridView";
            allCoinsDataGridView.ReadOnly = true;
            allCoinsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allCoinsDataGridView.Size = new Size(921, 400);
            allCoinsDataGridView.TabIndex = 41;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Країна";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Par
            // 
            Par.DataPropertyName = "Par";
            Par.HeaderText = "Номінал";
            Par.Name = "Par";
            Par.ReadOnly = true;
            // 
            // yearOfGraduationDataGridViewTextBoxColumn
            // 
            yearOfGraduationDataGridViewTextBoxColumn.DataPropertyName = "YearOfGraduation";
            yearOfGraduationDataGridViewTextBoxColumn.HeaderText = "Рік випуску";
            yearOfGraduationDataGridViewTextBoxColumn.Name = "yearOfGraduationDataGridViewTextBoxColumn";
            yearOfGraduationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            materialDataGridViewTextBoxColumn.HeaderText = "Матеріал";
            materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            materialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Кількість";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // featuresDataGridViewTextBoxColumn
            // 
            featuresDataGridViewTextBoxColumn.DataPropertyName = "Features";
            featuresDataGridViewTextBoxColumn.HeaderText = "Особливості";
            featuresDataGridViewTextBoxColumn.Name = "featuresDataGridViewTextBoxColumn";
            featuresDataGridViewTextBoxColumn.ReadOnly = true;
            featuresDataGridViewTextBoxColumn.Width = 200;
            // 
            // remainingCoinsDataGridViewTextBoxColumn
            // 
            remainingCoinsDataGridViewTextBoxColumn.DataPropertyName = "RemainingCoins";
            remainingCoinsDataGridViewTextBoxColumn.HeaderText = "Залишок";
            remainingCoinsDataGridViewTextBoxColumn.Name = "remainingCoinsDataGridViewTextBoxColumn";
            remainingCoinsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IsRare
            // 
            IsRare.DataPropertyName = "IsRare";
            IsRare.HeaderText = "Рідкість";
            IsRare.Name = "IsRare";
            IsRare.ReadOnly = true;
            IsRare.Width = 60;
            // 
            // collectionOfCollectorDataGridView
            // 
            collectionOfCollectorDataGridView.AllowUserToAddRows = false;
            collectionOfCollectorDataGridView.AllowUserToDeleteRows = false;
            collectionOfCollectorDataGridView.AutoGenerateColumns = false;
            collectionOfCollectorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            collectionOfCollectorDataGridView.Columns.AddRange(new DataGridViewColumn[] { CoinCountry, CoinPar, CoinYearOfGraduation, CoinMaterial, CoinAmount, CoinFeatures, CoinRemaining, conditionDataGridViewTextBoxColumn, CoinIsRare });
            collectionOfCollectorDataGridView.DataSource = ownedCoinBindingSource;
            collectionOfCollectorDataGridView.Location = new Point(969, 108);
            collectionOfCollectorDataGridView.Name = "collectionOfCollectorDataGridView";
            collectionOfCollectorDataGridView.ReadOnly = true;
            collectionOfCollectorDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            collectionOfCollectorDataGridView.Size = new Size(901, 399);
            collectionOfCollectorDataGridView.TabIndex = 42;
            // 
            // CoinCountry
            // 
            CoinCountry.DataPropertyName = "CoinCountry";
            CoinCountry.HeaderText = "Країна";
            CoinCountry.Name = "CoinCountry";
            CoinCountry.ReadOnly = true;
            // 
            // CoinPar
            // 
            CoinPar.DataPropertyName = "CoinPar";
            CoinPar.HeaderText = "Номінал";
            CoinPar.Name = "CoinPar";
            CoinPar.ReadOnly = true;
            // 
            // CoinYearOfGraduation
            // 
            CoinYearOfGraduation.DataPropertyName = "CoinYearOfGraduation";
            CoinYearOfGraduation.HeaderText = "Рік випуску";
            CoinYearOfGraduation.Name = "CoinYearOfGraduation";
            CoinYearOfGraduation.ReadOnly = true;
            // 
            // CoinMaterial
            // 
            CoinMaterial.DataPropertyName = "CoinMaterial";
            CoinMaterial.HeaderText = "Матеріал";
            CoinMaterial.Name = "CoinMaterial";
            CoinMaterial.ReadOnly = true;
            // 
            // CoinAmount
            // 
            CoinAmount.DataPropertyName = "CoinAmount";
            CoinAmount.HeaderText = "Кількість";
            CoinAmount.Name = "CoinAmount";
            CoinAmount.ReadOnly = true;
            // 
            // CoinFeatures
            // 
            CoinFeatures.DataPropertyName = "CoinFeatures";
            CoinFeatures.HeaderText = "Особливості";
            CoinFeatures.Name = "CoinFeatures";
            CoinFeatures.ReadOnly = true;
            // 
            // CoinRemaining
            // 
            CoinRemaining.DataPropertyName = "CoinRemaining";
            CoinRemaining.HeaderText = "Залишок";
            CoinRemaining.Name = "CoinRemaining";
            CoinRemaining.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            conditionDataGridViewTextBoxColumn.HeaderText = "Стан";
            conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            conditionDataGridViewTextBoxColumn.ReadOnly = true;
            conditionDataGridViewTextBoxColumn.Width = 80;
            // 
            // CoinIsRare
            // 
            CoinIsRare.DataPropertyName = "CoinIsRare";
            CoinIsRare.HeaderText = "Рідкість";
            CoinIsRare.Name = "CoinIsRare";
            CoinIsRare.ReadOnly = true;
            CoinIsRare.Width = 60;
            // 
            // searchingAllCoinsLabel
            // 
            searchingAllCoinsLabel.AutoSize = true;
            searchingAllCoinsLabel.Location = new Point(37, 70);
            searchingAllCoinsLabel.Name = "searchingAllCoinsLabel";
            searchingAllCoinsLabel.Size = new Size(164, 15);
            searchingAllCoinsLabel.TabIndex = 43;
            searchingAllCoinsLabel.Text = "Пошук в колекції всіх монет";
            // 
            // searchingCollectionOfCollectorLabel
            // 
            searchingCollectionOfCollectorLabel.AutoSize = true;
            searchingCollectionOfCollectorLabel.Location = new Point(1011, 73);
            searchingCollectionOfCollectorLabel.Name = "searchingCollectionOfCollectorLabel";
            searchingCollectionOfCollectorLabel.Size = new Size(181, 15);
            searchingCollectionOfCollectorLabel.TabIndex = 44;
            searchingCollectionOfCollectorLabel.Text = "Пошук в колекції колекціонера";
            // 
            // CollectionsOfCollectorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1902, 555);
            Controls.Add(searchingCollectionOfCollectorLabel);
            Controls.Add(searchingAllCoinsLabel);
            Controls.Add(collectionOfCollectorDataGridView);
            Controls.Add(allCoinsDataGridView);
            Controls.Add(NameOfCollectorTitle);
            Controls.Add(deleteCoinInCollectionOfCollectorButton);
            Controls.Add(searchingCollectionOfCollectorTextBox);
            Controls.Add(CollectionOfCollectorTitle);
            Controls.Add(AllCoinsTitle);
            Controls.Add(addCoinToCollectionOfCollectorButton);
            Controls.Add(searchingAllCoinsTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1918, 594);
            MinimumSize = new Size(1918, 594);
            Name = "CollectionsOfCollectorsForm";
            Text = "ColectionsOfCollectorsForm";
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ownedCoinBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)collectorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allCoinsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)collectionOfCollectorDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchingAllCoinsTextBox;
        private Button addCoinToCollectionOfCollectorButton;
        private Label AllCoinsTitle;
        private Label CollectionOfCollectorTitle;
        private TextBox searchingCollectionOfCollectorTextBox;
        private Button deleteCoinInCollectionOfCollectorButton;
        private MenuStrip menuStrip1;
        private BindingSource coinBindingSource;
        public BindingSource ownedCoinBindingSource;
        private Label NameOfCollectorTitle;
        private BindingSource collectorBindingSource;
        private DataGridView allCoinsDataGridView;
        private DataGridView collectionOfCollectorDataGridView;
        private Label searchingAllCoinsLabel;
        private Label searchingCollectionOfCollectorLabel;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Par;
        private DataGridViewTextBoxColumn yearOfGraduationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remainingCoinsDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn IsRare;
        private DataGridViewTextBoxColumn CoinCountry;
        private DataGridViewTextBoxColumn CoinPar;
        private DataGridViewTextBoxColumn CoinYearOfGraduation;
        private DataGridViewTextBoxColumn CoinMaterial;
        private DataGridViewTextBoxColumn CoinAmount;
        private DataGridViewTextBoxColumn CoinFeatures;
        private DataGridViewTextBoxColumn CoinRemaining;
        private DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn CoinIsRare;
        private ToolStripMenuItem навігаціяToolStripMenuItem;
        private ToolStripMenuItem монетиToolStripMenuItem;
        private ToolStripMenuItem колекціонериToolStripMenuItem;
        private ToolStripMenuItem мояКолекціяToolStripMenuItem;
        private ToolStripMenuItem функціїToolStripMenuItem;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem1;
        private ToolStripMenuItem вийтиЗДодаткуToolStripMenuItem;
    }
}