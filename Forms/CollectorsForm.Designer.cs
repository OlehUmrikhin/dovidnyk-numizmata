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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            наГоловнуToolStripMenuItem = new ToolStripMenuItem();
            монетиToolStripMenuItem = new ToolStripMenuItem();
            колекціонериToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            countryCollectorLabel = new Label();
            nameCollectorLabel = new Label();
            contactsCollectorLabel = new Label();
            countryCollectorTextBox = new TextBox();
            collectorBindingSource = new BindingSource(components);
            nameCollectorTextBox = new TextBox();
            contactsCollectorTextBox = new TextBox();
            collectorListBox = new ListBox();
            addCollectorButton = new Button();
            lookCollectionOfCollectorButton = new Button();
            searchCollectorButton = new Button();
            searchCollectorTextBox = new TextBox();
            deleteCollectorButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)collectorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // titleCollectorsLabel
            // 
            titleCollectorsLabel.AutoSize = true;
            titleCollectorsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleCollectorsLabel.Location = new Point(295, 41);
            titleCollectorsLabel.Name = "titleCollectorsLabel";
            titleCollectorsLabel.Size = new Size(239, 21);
            titleCollectorsLabel.TabIndex = 0;
            titleCollectorsLabel.Text = "Взаємодія з колекціонерами";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { наГоловнуToolStripMenuItem, монетиToolStripMenuItem, колекціонериToolStripMenuItem, зберегтиToolStripMenuItem });
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
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(69, 20);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // countryCollectorLabel
            // 
            countryCollectorLabel.AutoSize = true;
            countryCollectorLabel.Location = new Point(24, 107);
            countryCollectorLabel.Name = "countryCollectorLabel";
            countryCollectorLabel.Size = new Size(46, 15);
            countryCollectorLabel.TabIndex = 2;
            countryCollectorLabel.Text = "Країна:";
            // 
            // nameCollectorLabel
            // 
            nameCollectorLabel.AutoSize = true;
            nameCollectorLabel.Location = new Point(24, 141);
            nameCollectorLabel.Name = "nameCollectorLabel";
            nameCollectorLabel.Size = new Size(31, 15);
            nameCollectorLabel.TabIndex = 3;
            nameCollectorLabel.Text = "Ім'я:";
            // 
            // contactsCollectorLabel
            // 
            contactsCollectorLabel.AutoSize = true;
            contactsCollectorLabel.Location = new Point(24, 172);
            contactsCollectorLabel.Name = "contactsCollectorLabel";
            contactsCollectorLabel.Size = new Size(88, 15);
            contactsCollectorLabel.TabIndex = 4;
            contactsCollectorLabel.Text = "Контактні дані:";
            // 
            // countryCollectorTextBox
            // 
            countryCollectorTextBox.DataBindings.Add(new Binding("Text", collectorBindingSource, "Country", true));
            countryCollectorTextBox.Location = new Point(80, 104);
            countryCollectorTextBox.Name = "countryCollectorTextBox";
            countryCollectorTextBox.Size = new Size(202, 23);
            countryCollectorTextBox.TabIndex = 5;
            // 
            // collectorBindingSource
            // 
            collectorBindingSource.DataSource = typeof(Collector);
            // 
            // nameCollectorTextBox
            // 
            nameCollectorTextBox.DataBindings.Add(new Binding("Text", collectorBindingSource, "Name", true));
            nameCollectorTextBox.Location = new Point(59, 136);
            nameCollectorTextBox.Name = "nameCollectorTextBox";
            nameCollectorTextBox.Size = new Size(223, 23);
            nameCollectorTextBox.TabIndex = 6;
            // 
            // contactsCollectorTextBox
            // 
            contactsCollectorTextBox.DataBindings.Add(new Binding("Text", collectorBindingSource, "Contacts", true));
            contactsCollectorTextBox.Location = new Point(121, 168);
            contactsCollectorTextBox.Name = "contactsCollectorTextBox";
            contactsCollectorTextBox.Size = new Size(161, 23);
            contactsCollectorTextBox.TabIndex = 7;
            // 
            // collectorListBox
            // 
            collectorListBox.DataSource = collectorBindingSource;
            collectorListBox.DisplayMember = "Info";
            collectorListBox.Font = new Font("Segoe UI", 11F);
            collectorListBox.FormattingEnabled = true;
            collectorListBox.Location = new Point(312, 102);
            collectorListBox.Name = "collectorListBox";
            collectorListBox.Size = new Size(458, 284);
            collectorListBox.TabIndex = 8;
            collectorListBox.SelectedIndexChanged += collectorsListBox_SelectedIndexChanged;
            // 
            // addCollectorButton
            // 
            addCollectorButton.Location = new Point(107, 343);
            addCollectorButton.Name = "addCollectorButton";
            addCollectorButton.Size = new Size(90, 56);
            addCollectorButton.TabIndex = 9;
            addCollectorButton.Text = "Додати колекціонера";
            addCollectorButton.UseVisualStyleBackColor = true;
            addCollectorButton.Click += addCollectorButton_Click;
            // 
            // lookCollectionOfCollectorButton
            // 
            lookCollectionOfCollectorButton.Location = new Point(16, 343);
            lookCollectionOfCollectorButton.Name = "lookCollectionOfCollectorButton";
            lookCollectionOfCollectorButton.Size = new Size(75, 56);
            lookCollectionOfCollectorButton.TabIndex = 10;
            lookCollectionOfCollectorButton.Text = "Подивитись колекцію";
            lookCollectionOfCollectorButton.UseVisualStyleBackColor = true;
            lookCollectionOfCollectorButton.Click += lookCollectionOfCollectorButton_Click;
            // 
            // searchCollectorButton
            // 
            searchCollectorButton.Location = new Point(24, 214);
            searchCollectorButton.Name = "searchCollectorButton";
            searchCollectorButton.Size = new Size(75, 23);
            searchCollectorButton.TabIndex = 11;
            searchCollectorButton.Text = "Пошук";
            searchCollectorButton.UseVisualStyleBackColor = true;
            searchCollectorButton.Click += searchCollectorButton_Click;
            // 
            // searchCollectorTextBox
            // 
            searchCollectorTextBox.Location = new Point(105, 214);
            searchCollectorTextBox.Name = "searchCollectorTextBox";
            searchCollectorTextBox.Size = new Size(177, 23);
            searchCollectorTextBox.TabIndex = 12;
            // 
            // deleteCollectorButton
            // 
            deleteCollectorButton.Location = new Point(214, 342);
            deleteCollectorButton.Name = "deleteCollectorButton";
            deleteCollectorButton.Size = new Size(75, 57);
            deleteCollectorButton.TabIndex = 13;
            deleteCollectorButton.Text = "Видалити колекціонера";
            deleteCollectorButton.UseVisualStyleBackColor = true;
            deleteCollectorButton.Click += deleteCollectorButton_Click;
            // 
            // CollectorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteCollectorButton);
            Controls.Add(searchCollectorTextBox);
            Controls.Add(searchCollectorButton);
            Controls.Add(lookCollectionOfCollectorButton);
            Controls.Add(addCollectorButton);
            Controls.Add(collectorListBox);
            Controls.Add(contactsCollectorTextBox);
            Controls.Add(nameCollectorTextBox);
            Controls.Add(countryCollectorTextBox);
            Controls.Add(contactsCollectorLabel);
            Controls.Add(nameCollectorLabel);
            Controls.Add(countryCollectorLabel);
            Controls.Add(titleCollectorsLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CollectorsForm";
            Text = "CollectorsForm";
            Click += CollectorsForm_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)collectorBindingSource).EndInit();
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
        private Label countryCollectorLabel;
        private Label nameCollectorLabel;
        private Label contactsCollectorLabel;
        private TextBox countryCollectorTextBox;
        private TextBox nameCollectorTextBox;
        private TextBox contactsCollectorTextBox;
        private ListBox collectorListBox;
        private Button addCollectorButton;
        private Button lookCollectionOfCollectorButton;
        private Button searchCollectorButton;
        private TextBox searchCollectorTextBox;
        private Button deleteCollectorButton;
        private BindingSource collectorBindingSource;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
    }
}