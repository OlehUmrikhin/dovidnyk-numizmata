using dovidnyk_numizmata.Models;

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
            components = new System.ComponentModel.Container();
            titleCollectorsLabel = new Label();
            menuStrip1 = new MenuStrip();
            навігаціяToolStripMenuItem = new ToolStripMenuItem();
            монетиToolStripMenuItem = new ToolStripMenuItem();
            мояКолекціяToolStripMenuItem = new ToolStripMenuItem();
            функціїToolStripMenuItem = new ToolStripMenuItem();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            подивитисьКолекціюToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem1 = new ToolStripMenuItem();
            вийтиЗДодаткуToolStripMenuItem = new ToolStripMenuItem();
            countryCollectorLabelMain = new Label();
            nameCollectorLabelMain = new Label();
            contactsCollectorLabelMain = new Label();
            countryCollectorTextBoxMain = new TextBox();
            collectorBindingSource = new BindingSource(components);
            nameCollectorTextBoxMain = new TextBox();
            contactsCollectorTextBoxMain = new TextBox();
            addCollectorButtonMain = new Button();
            lookCollectionOfCollectorButton = new Button();
            searchCollectorTextBox = new TextBox();
            deleteCollectorButton = new Button();
            collectorsDataGridView = new DataGridView();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            searchingTitle = new Label();
            editingTitleMain = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)collectorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)collectorsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleCollectorsLabel
            // 
            titleCollectorsLabel.AutoSize = true;
            titleCollectorsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleCollectorsLabel.Location = new Point(387, 43);
            titleCollectorsLabel.Name = "titleCollectorsLabel";
            titleCollectorsLabel.Size = new Size(239, 21);
            titleCollectorsLabel.TabIndex = 0;
            titleCollectorsLabel.Text = "Взаємодія з колекціонерами";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { навігаціяToolStripMenuItem, функціїToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(955, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // навігаціяToolStripMenuItem
            // 
            навігаціяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { монетиToolStripMenuItem, мояКолекціяToolStripMenuItem });
            навігаціяToolStripMenuItem.Name = "навігаціяToolStripMenuItem";
            навігаціяToolStripMenuItem.Size = new Size(83, 20);
            навігаціяToolStripMenuItem.Text = "Навігація ▾";
            // 
            // монетиToolStripMenuItem
            // 
            монетиToolStripMenuItem.Name = "монетиToolStripMenuItem";
            монетиToolStripMenuItem.Size = new Size(149, 22);
            монетиToolStripMenuItem.Text = "Монети";
            монетиToolStripMenuItem.Click += монетиToolStripMenuItem_Click;
            // 
            // мояКолекціяToolStripMenuItem
            // 
            мояКолекціяToolStripMenuItem.Name = "мояКолекціяToolStripMenuItem";
            мояКолекціяToolStripMenuItem.Size = new Size(149, 22);
            мояКолекціяToolStripMenuItem.Text = "Моя колекція";
            мояКолекціяToolStripMenuItem.Click += мояКолекціяToolStripMenuItem_Click;
            // 
            // функціїToolStripMenuItem
            // 
            функціїToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиToolStripMenuItem, видалитиToolStripMenuItem, подивитисьКолекціюToolStripMenuItem, зберегтиToolStripMenuItem1, вийтиЗДодаткуToolStripMenuItem });
            функціїToolStripMenuItem.Name = "функціїToolStripMenuItem";
            функціїToolStripMenuItem.Size = new Size(73, 20);
            функціїToolStripMenuItem.Text = "Функції ▾";
            // 
            // додатиToolStripMenuItem
            // 
            додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            додатиToolStripMenuItem.Size = new Size(195, 22);
            додатиToolStripMenuItem.Text = "Додати";
            додатиToolStripMenuItem.Click += addCollectorButton_Click;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(195, 22);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += deleteCollectorButton_Click;
            // 
            // подивитисьКолекціюToolStripMenuItem
            // 
            подивитисьКолекціюToolStripMenuItem.Name = "подивитисьКолекціюToolStripMenuItem";
            подивитисьКолекціюToolStripMenuItem.Size = new Size(195, 22);
            подивитисьКолекціюToolStripMenuItem.Text = "Подивитись колекцію";
            подивитисьКолекціюToolStripMenuItem.Click += lookCollectionOfCollectorButton_Click;
            // 
            // зберегтиToolStripMenuItem1
            // 
            зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            зберегтиToolStripMenuItem1.Size = new Size(195, 22);
            зберегтиToolStripMenuItem1.Text = "Зберегти";
            зберегтиToolStripMenuItem1.Click += зберегтиToolStripMenuItem_Click;
            // 
            // вийтиЗДодаткуToolStripMenuItem
            // 
            вийтиЗДодаткуToolStripMenuItem.Name = "вийтиЗДодаткуToolStripMenuItem";
            вийтиЗДодаткуToolStripMenuItem.Size = new Size(195, 22);
            вийтиЗДодаткуToolStripMenuItem.Text = "Вийти з додатку";
            вийтиЗДодаткуToolStripMenuItem.Click += вийтиЗДодаткуToolStripMenuItem_Click;
            // 
            // countryCollectorLabelMain
            // 
            countryCollectorLabelMain.AutoSize = true;
            countryCollectorLabelMain.Location = new Point(659, 183);
            countryCollectorLabelMain.Name = "countryCollectorLabelMain";
            countryCollectorLabelMain.Size = new Size(46, 15);
            countryCollectorLabelMain.TabIndex = 2;
            countryCollectorLabelMain.Text = "Країна:";
            // 
            // nameCollectorLabelMain
            // 
            nameCollectorLabelMain.AutoSize = true;
            nameCollectorLabelMain.Location = new Point(659, 217);
            nameCollectorLabelMain.Name = "nameCollectorLabelMain";
            nameCollectorLabelMain.Size = new Size(31, 15);
            nameCollectorLabelMain.TabIndex = 3;
            nameCollectorLabelMain.Text = "Ім'я:";
            // 
            // contactsCollectorLabelMain
            // 
            contactsCollectorLabelMain.AutoSize = true;
            contactsCollectorLabelMain.Location = new Point(659, 248);
            contactsCollectorLabelMain.Name = "contactsCollectorLabelMain";
            contactsCollectorLabelMain.Size = new Size(88, 15);
            contactsCollectorLabelMain.TabIndex = 4;
            contactsCollectorLabelMain.Text = "Контактні дані:";
            // 
            // countryCollectorTextBoxMain
            // 
            countryCollectorTextBoxMain.DataBindings.Add(new Binding("Text", collectorBindingSource, "Country", true));
            countryCollectorTextBoxMain.Location = new Point(715, 180);
            countryCollectorTextBoxMain.Name = "countryCollectorTextBoxMain";
            countryCollectorTextBoxMain.Size = new Size(202, 23);
            countryCollectorTextBoxMain.TabIndex = 5;
            // 
            // collectorBindingSource
            // 
            collectorBindingSource.DataSource = typeof(Collector);
            // 
            // nameCollectorTextBoxMain
            // 
            nameCollectorTextBoxMain.DataBindings.Add(new Binding("Text", collectorBindingSource, "Name", true));
            nameCollectorTextBoxMain.Location = new Point(694, 212);
            nameCollectorTextBoxMain.Name = "nameCollectorTextBoxMain";
            nameCollectorTextBoxMain.Size = new Size(223, 23);
            nameCollectorTextBoxMain.TabIndex = 6;
            // 
            // contactsCollectorTextBoxMain
            // 
            contactsCollectorTextBoxMain.DataBindings.Add(new Binding("Text", collectorBindingSource, "Contacts", true));
            contactsCollectorTextBoxMain.Location = new Point(756, 244);
            contactsCollectorTextBoxMain.Name = "contactsCollectorTextBoxMain";
            contactsCollectorTextBoxMain.Size = new Size(161, 23);
            contactsCollectorTextBoxMain.TabIndex = 7;
            // 
            // addCollectorButtonMain
            // 
            addCollectorButtonMain.BackColor = SystemColors.Control;
            addCollectorButtonMain.Location = new Point(745, 375);
            addCollectorButtonMain.Name = "addCollectorButtonMain";
            addCollectorButtonMain.Size = new Size(96, 57);
            addCollectorButtonMain.TabIndex = 9;
            addCollectorButtonMain.Text = "Додати колекціонера";
            addCollectorButtonMain.UseVisualStyleBackColor = false;
            addCollectorButtonMain.Click += addCollectorButton_Click;
            // 
            // lookCollectionOfCollectorButton
            // 
            lookCollectionOfCollectorButton.BackColor = SystemColors.Control;
            lookCollectionOfCollectorButton.Location = new Point(643, 375);
            lookCollectionOfCollectorButton.Name = "lookCollectionOfCollectorButton";
            lookCollectionOfCollectorButton.Size = new Size(96, 57);
            lookCollectionOfCollectorButton.TabIndex = 8;
            lookCollectionOfCollectorButton.Text = "Подивитись колекцію";
            lookCollectionOfCollectorButton.UseVisualStyleBackColor = false;
            lookCollectionOfCollectorButton.Click += lookCollectionOfCollectorButton_Click;
            // 
            // searchCollectorTextBox
            // 
            searchCollectorTextBox.Location = new Point(88, 85);
            searchCollectorTextBox.Name = "searchCollectorTextBox";
            searchCollectorTextBox.Size = new Size(177, 23);
            searchCollectorTextBox.TabIndex = 11;
            searchCollectorTextBox.TextChanged += searchCollectorTextBox_TextChanged;
            // 
            // deleteCollectorButton
            // 
            deleteCollectorButton.BackColor = SystemColors.Control;
            deleteCollectorButton.Location = new Point(847, 375);
            deleteCollectorButton.Name = "deleteCollectorButton";
            deleteCollectorButton.Size = new Size(96, 57);
            deleteCollectorButton.TabIndex = 10;
            deleteCollectorButton.Text = "Видалити колекціонера";
            deleteCollectorButton.UseVisualStyleBackColor = false;
            deleteCollectorButton.Click += deleteCollectorButton_Click;
            // 
            // collectorsDataGridView
            // 
            collectorsDataGridView.AllowUserToAddRows = false;
            collectorsDataGridView.AllowUserToDeleteRows = false;
            collectorsDataGridView.AllowUserToResizeRows = false;
            collectorsDataGridView.AutoGenerateColumns = false;
            collectorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            collectorsDataGridView.Columns.AddRange(new DataGridViewColumn[] { countryDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactsDataGridViewTextBoxColumn });
            collectorsDataGridView.DataSource = collectorBindingSource;
            collectorsDataGridView.Location = new Point(12, 121);
            collectorsDataGridView.MultiSelect = false;
            collectorsDataGridView.Name = "collectorsDataGridView";
            collectorsDataGridView.ReadOnly = true;
            collectorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            collectorsDataGridView.Size = new Size(614, 404);
            collectorsDataGridView.TabIndex = 14;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Країна";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Ім'я";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactsDataGridViewTextBoxColumn
            // 
            contactsDataGridViewTextBoxColumn.DataPropertyName = "Contacts";
            contactsDataGridViewTextBoxColumn.HeaderText = "Контактні дані";
            contactsDataGridViewTextBoxColumn.Name = "contactsDataGridViewTextBoxColumn";
            contactsDataGridViewTextBoxColumn.ReadOnly = true;
            contactsDataGridViewTextBoxColumn.Width = 300;
            // 
            // searchingTitle
            // 
            searchingTitle.AutoSize = true;
            searchingTitle.Location = new Point(36, 88);
            searchingTitle.Name = "searchingTitle";
            searchingTitle.Size = new Size(46, 15);
            searchingTitle.TabIndex = 15;
            searchingTitle.Text = "Пошук";
            // 
            // editingTitleMain
            // 
            editingTitleMain.AutoSize = true;
            editingTitleMain.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            editingTitleMain.Location = new Point(694, 137);
            editingTitleMain.Name = "editingTitleMain";
            editingTitleMain.Size = new Size(204, 20);
            editingTitleMain.TabIndex = 16;
            editingTitleMain.Text = "Редагування колекціонера";
            // 
            // CollectorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(955, 545);
            Controls.Add(editingTitleMain);
            Controls.Add(searchingTitle);
            Controls.Add(collectorsDataGridView);
            Controls.Add(deleteCollectorButton);
            Controls.Add(searchCollectorTextBox);
            Controls.Add(lookCollectionOfCollectorButton);
            Controls.Add(addCollectorButtonMain);
            Controls.Add(contactsCollectorTextBoxMain);
            Controls.Add(nameCollectorTextBoxMain);
            Controls.Add(countryCollectorTextBoxMain);
            Controls.Add(contactsCollectorLabelMain);
            Controls.Add(nameCollectorLabelMain);
            Controls.Add(countryCollectorLabelMain);
            Controls.Add(titleCollectorsLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(971, 584);
            MinimumSize = new Size(971, 584);
            Name = "CollectorsForm";
            Text = "CollectorsForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)collectorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)collectorsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleCollectorsLabel;
        private MenuStrip menuStrip1;
        private Label countryCollectorLabelMain;
        private Label nameCollectorLabelMain;
        private Label contactsCollectorLabelMain;
        private TextBox countryCollectorTextBoxMain;
        private TextBox nameCollectorTextBoxMain;
        private TextBox contactsCollectorTextBoxMain;
        private Button addCollectorButtonMain;
        private Button lookCollectionOfCollectorButton;
        private TextBox searchCollectorTextBox;
        private Button deleteCollectorButton;
        private BindingSource collectorBindingSource;
        private DataGridView collectorsDataGridView;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactsDataGridViewTextBoxColumn;
        private Label searchingTitle;
        private Label editingTitleMain;
        private ToolStripMenuItem навігаціяToolStripMenuItem;
        private ToolStripMenuItem функціїToolStripMenuItem;
        private ToolStripMenuItem монетиToolStripMenuItem;
        private ToolStripMenuItem мояКолекціяToolStripMenuItem;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private ToolStripMenuItem подивитисьКолекціюToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem1;
        private ToolStripMenuItem вийтиЗДодаткуToolStripMenuItem;
    }
}