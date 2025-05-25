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
            addButton = new Button();
            deleteButton = new Button();
            menuStrip1 = new MenuStrip();
            закритиToolStripMenuItem = new ToolStripMenuItem();
            зберігтиToolStripMenuItem = new ToolStripMenuItem();
            колекціонериToolStripMenuItem = new ToolStripMenuItem();
            мояКолекціяToolStripMenuItem = new ToolStripMenuItem();
            RemainingCoinsLabel = new Label();
            remainingCoinsTextBox = new TextBox();
            collectionOfCoinsDataGridView = new DataGridView();
            panel2 = new Panel();
            editLabel = new Label();
            searchingTitle = new Label();
            searchingTextBox = new TextBox();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearOfGraduationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            featuresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remainingCoinsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IsRare = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)collectionOfCoinsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleCoinsLabel
            // 
            titleCoinsLabel.AutoSize = true;
            titleCoinsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleCoinsLabel.Location = new Point(631, 28);
            titleCoinsLabel.Name = "titleCoinsLabel";
            titleCoinsLabel.Size = new Size(186, 21);
            titleCoinsLabel.TabIndex = 0;
            titleCoinsLabel.Text = "Взаємодія з монетами";
            // 
            // countryCoinsLabel
            // 
            countryCoinsLabel.AutoSize = true;
            countryCoinsLabel.Location = new Point(1061, 170);
            countryCoinsLabel.Name = "countryCoinsLabel";
            countryCoinsLabel.Size = new Size(46, 15);
            countryCoinsLabel.TabIndex = 1;
            countryCoinsLabel.Text = "Країна:";
            // 
            // parCoinsLabel
            // 
            parCoinsLabel.AutoSize = true;
            parCoinsLabel.Location = new Point(1061, 205);
            parCoinsLabel.Name = "parCoinsLabel";
            parCoinsLabel.Size = new Size(58, 15);
            parCoinsLabel.TabIndex = 2;
            parCoinsLabel.Text = "Номінал:";
            // 
            // yearOfGraduationCoinsLabel
            // 
            yearOfGraduationCoinsLabel.AutoSize = true;
            yearOfGraduationCoinsLabel.Location = new Point(1061, 240);
            yearOfGraduationCoinsLabel.Name = "yearOfGraduationCoinsLabel";
            yearOfGraduationCoinsLabel.Size = new Size(73, 15);
            yearOfGraduationCoinsLabel.TabIndex = 3;
            yearOfGraduationCoinsLabel.Text = "Рік випуску:";
            // 
            // MaterialCoinsLabel
            // 
            MaterialCoinsLabel.AutoSize = true;
            MaterialCoinsLabel.Location = new Point(1061, 275);
            MaterialCoinsLabel.Name = "MaterialCoinsLabel";
            MaterialCoinsLabel.Size = new Size(61, 15);
            MaterialCoinsLabel.TabIndex = 4;
            MaterialCoinsLabel.Text = "Матеріал:";
            // 
            // numberCoinsLabel
            // 
            numberCoinsLabel.AutoSize = true;
            numberCoinsLabel.Location = new Point(1061, 310);
            numberCoinsLabel.Name = "numberCoinsLabel";
            numberCoinsLabel.Size = new Size(162, 15);
            numberCoinsLabel.TabIndex = 5;
            numberCoinsLabel.Text = "Кількість випущених монет:";
            // 
            // FeaturesCoinsLabel
            // 
            FeaturesCoinsLabel.AutoSize = true;
            FeaturesCoinsLabel.Location = new Point(1061, 345);
            FeaturesCoinsLabel.Name = "FeaturesCoinsLabel";
            FeaturesCoinsLabel.Size = new Size(124, 15);
            FeaturesCoinsLabel.TabIndex = 6;
            FeaturesCoinsLabel.Text = "Особливості монети:";
            // 
            // countryCoinsTextBox
            // 
            countryCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Country", true));
            countryCoinsTextBox.Location = new Point(1133, 166);
            countryCoinsTextBox.Name = "countryCoinsTextBox";
            countryCoinsTextBox.Size = new Size(259, 23);
            countryCoinsTextBox.TabIndex = 7;
            countryCoinsTextBox.Text = " ";
            // 
            // coinBindingSource
            // 
            coinBindingSource.DataSource = typeof(Coin);
            // 
            // parCoinsTextBox
            // 
            parCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Par", true));
            parCoinsTextBox.Location = new Point(1133, 202);
            parCoinsTextBox.Name = "parCoinsTextBox";
            parCoinsTextBox.Size = new Size(259, 23);
            parCoinsTextBox.TabIndex = 8;
            // 
            // yearOfGraduationCoinsTextBox
            // 
            yearOfGraduationCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "YearOfGraduation", true));
            yearOfGraduationCoinsTextBox.Location = new Point(1140, 237);
            yearOfGraduationCoinsTextBox.Name = "yearOfGraduationCoinsTextBox";
            yearOfGraduationCoinsTextBox.Size = new Size(252, 23);
            yearOfGraduationCoinsTextBox.TabIndex = 9;
            // 
            // materialCoinsTextBox
            // 
            materialCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Material", true));
            materialCoinsTextBox.Location = new Point(1133, 272);
            materialCoinsTextBox.Name = "materialCoinsTextBox";
            materialCoinsTextBox.Size = new Size(259, 23);
            materialCoinsTextBox.TabIndex = 10;
            // 
            // numberCoinsTextBox
            // 
            numberCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Amount", true));
            numberCoinsTextBox.Location = new Point(1228, 307);
            numberCoinsTextBox.Name = "numberCoinsTextBox";
            numberCoinsTextBox.Size = new Size(164, 23);
            numberCoinsTextBox.TabIndex = 11;
            // 
            // featuresCoinsTextBox
            // 
            featuresCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Features", true));
            featuresCoinsTextBox.Location = new Point(1191, 342);
            featuresCoinsTextBox.Name = "featuresCoinsTextBox";
            featuresCoinsTextBox.Size = new Size(201, 23);
            featuresCoinsTextBox.TabIndex = 12;
            // 
            // addButton
            // 
            addButton.Location = new Point(1061, 493);
            addButton.Name = "addButton";
            addButton.Size = new Size(134, 25);
            addButton.TabIndex = 14;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1251, 493);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(137, 25);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { закритиToolStripMenuItem, зберігтиToolStripMenuItem, колекціонериToolStripMenuItem, мояКолекціяToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1419, 24);
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
            зберігтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
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
            // RemainingCoinsLabel
            // 
            RemainingCoinsLabel.AutoSize = true;
            RemainingCoinsLabel.Location = new Point(1061, 380);
            RemainingCoinsLabel.Name = "RemainingCoinsLabel";
            RemainingCoinsLabel.Size = new Size(81, 15);
            RemainingCoinsLabel.TabIndex = 20;
            RemainingCoinsLabel.Text = "Залишилося:";
            // 
            // remainingCoinsTextBox
            // 
            remainingCoinsTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "RemainingCoins", true));
            remainingCoinsTextBox.Location = new Point(1150, 377);
            remainingCoinsTextBox.Name = "remainingCoinsTextBox";
            remainingCoinsTextBox.Size = new Size(242, 23);
            remainingCoinsTextBox.TabIndex = 13;
            // 
            // collectionOfCoinsDataGridView
            // 
            collectionOfCoinsDataGridView.AllowUserToAddRows = false;
            collectionOfCoinsDataGridView.AllowUserToDeleteRows = false;
            collectionOfCoinsDataGridView.AllowUserToResizeRows = false;
            collectionOfCoinsDataGridView.AutoGenerateColumns = false;
            collectionOfCoinsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            collectionOfCoinsDataGridView.Columns.AddRange(new DataGridViewColumn[] { countryDataGridViewTextBoxColumn, parDataGridViewTextBoxColumn, yearOfGraduationDataGridViewTextBoxColumn, materialDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, featuresDataGridViewTextBoxColumn, remainingCoinsDataGridViewTextBoxColumn, IsRare });
            collectionOfCoinsDataGridView.DataSource = coinBindingSource;
            collectionOfCoinsDataGridView.Location = new Point(12, 112);
            collectionOfCoinsDataGridView.MultiSelect = false;
            collectionOfCoinsDataGridView.Name = "collectionOfCoinsDataGridView";
            collectionOfCoinsDataGridView.ReadOnly = true;
            collectionOfCoinsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            collectionOfCoinsDataGridView.Size = new Size(1001, 404);
            collectionOfCoinsDataGridView.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Location = new Point(1046, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 263);
            panel2.TabIndex = 22;
            // 
            // editLabel
            // 
            editLabel.AutoSize = true;
            editLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            editLabel.Location = new Point(1145, 112);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(159, 20);
            editLabel.TabIndex = 23;
            editLabel.Text = "Редагування монети";
            // 
            // searchingTitle
            // 
            searchingTitle.AutoSize = true;
            searchingTitle.Location = new Point(32, 70);
            searchingTitle.Name = "searchingTitle";
            searchingTitle.Size = new Size(49, 15);
            searchingTitle.TabIndex = 24;
            searchingTitle.Text = "Пошук:";
            // 
            // searchingTextBox
            // 
            searchingTextBox.Location = new Point(87, 67);
            searchingTextBox.Name = "searchingTextBox";
            searchingTextBox.Size = new Size(279, 23);
            searchingTextBox.TabIndex = 16;
            searchingTextBox.TextChanged += searchingtextBox_TextChanged;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Країна";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parDataGridViewTextBoxColumn
            // 
            parDataGridViewTextBoxColumn.DataPropertyName = "Par";
            parDataGridViewTextBoxColumn.HeaderText = "Номінал";
            parDataGridViewTextBoxColumn.Name = "parDataGridViewTextBoxColumn";
            parDataGridViewTextBoxColumn.ReadOnly = true;
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
            featuresDataGridViewTextBoxColumn.Width = 260;
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
            IsRare.Width = 70;
            // 
            // CoinsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1419, 552);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(searchingTextBox);
            Controls.Add(searchingTitle);
            Controls.Add(editLabel);
            Controls.Add(collectionOfCoinsDataGridView);
            Controls.Add(remainingCoinsTextBox);
            Controls.Add(RemainingCoinsLabel);
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
            Controls.Add(panel2);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1354, 591);
            Name = "CoinsForm";
            Text = "CoinsForm";
            FormClosing += CoinsForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)collectionOfCoinsDataGridView).EndInit();
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
        private Button addButton;
        private Button deleteButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem закритиToolStripMenuItem;
        private ToolStripMenuItem зберігтиToolStripMenuItem;
        private ToolStripMenuItem колекціонериToolStripMenuItem;
        private ToolStripMenuItem мояКолекціяToolStripMenuItem;
        private Label RemainingCoinsLabel;
        private TextBox remainingCoinsTextBox;
        private BindingSource coinBindingSource;
        private DataGridView collectionOfCoinsDataGridView;
        private Panel panel2;
        private Label editLabel;
        private Label searchingTitle;
        private TextBox searchingTextBox;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearOfGraduationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remainingCoinsDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn IsRare;
    }
}