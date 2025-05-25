namespace dovidnyk_numizmata.Forms
{
    partial class AddCollectorForm
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
            addCollectorButton = new Button();
            contactsCollectorTextBox = new TextBox();
            nameCollectorTextBox = new TextBox();
            countryCollectorTextBox = new TextBox();
            contactsCollectorLabel = new Label();
            nameCollectorLabel = new Label();
            countryCollectorLabel = new Label();
            addingCollectorLabel = new Label();
            SuspendLayout();
            // 
            // addCollectorButton
            // 
            addCollectorButton.Location = new Point(187, 191);
            addCollectorButton.Name = "addCollectorButton";
            addCollectorButton.Size = new Size(75, 23);
            addCollectorButton.TabIndex = 16;
            addCollectorButton.Text = "Додати";
            addCollectorButton.UseVisualStyleBackColor = true;
            addCollectorButton.Click += addCollectorButton_Click;
            // 
            // contactsCollectorTextBox
            // 
            contactsCollectorTextBox.Location = new Point(172, 140);
            contactsCollectorTextBox.Name = "contactsCollectorTextBox";
            contactsCollectorTextBox.Size = new Size(203, 23);
            contactsCollectorTextBox.TabIndex = 15;
            // 
            // nameCollectorTextBox
            // 
            nameCollectorTextBox.Location = new Point(110, 108);
            nameCollectorTextBox.Name = "nameCollectorTextBox";
            nameCollectorTextBox.Size = new Size(265, 23);
            nameCollectorTextBox.TabIndex = 14;
            // 
            // countryCollectorTextBox
            // 
            countryCollectorTextBox.Location = new Point(131, 76);
            countryCollectorTextBox.Name = "countryCollectorTextBox";
            countryCollectorTextBox.Size = new Size(244, 23);
            countryCollectorTextBox.TabIndex = 13;
            // 
            // contactsCollectorLabel
            // 
            contactsCollectorLabel.AutoSize = true;
            contactsCollectorLabel.Location = new Point(75, 144);
            contactsCollectorLabel.Name = "contactsCollectorLabel";
            contactsCollectorLabel.Size = new Size(88, 15);
            contactsCollectorLabel.TabIndex = 12;
            contactsCollectorLabel.Text = "Контактні дані:";
            // 
            // nameCollectorLabel
            // 
            nameCollectorLabel.AutoSize = true;
            nameCollectorLabel.Location = new Point(75, 113);
            nameCollectorLabel.Name = "nameCollectorLabel";
            nameCollectorLabel.Size = new Size(31, 15);
            nameCollectorLabel.TabIndex = 11;
            nameCollectorLabel.Text = "Ім'я:";
            // 
            // countryCollectorLabel
            // 
            countryCollectorLabel.AutoSize = true;
            countryCollectorLabel.Location = new Point(75, 79);
            countryCollectorLabel.Name = "countryCollectorLabel";
            countryCollectorLabel.Size = new Size(46, 15);
            countryCollectorLabel.TabIndex = 10;
            countryCollectorLabel.Text = "Країна:";
            // 
            // addingCollectorLabel
            // 
            addingCollectorLabel.AutoSize = true;
            addingCollectorLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addingCollectorLabel.Location = new Point(131, 25);
            addingCollectorLabel.Name = "addingCollectorLabel";
            addingCollectorLabel.Size = new Size(194, 20);
            addingCollectorLabel.TabIndex = 17;
            addingCollectorLabel.Text = "Додавання колекціонера";
            // 
            // AddCollectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 251);
            Controls.Add(addingCollectorLabel);
            Controls.Add(addCollectorButton);
            Controls.Add(contactsCollectorTextBox);
            Controls.Add(nameCollectorTextBox);
            Controls.Add(countryCollectorTextBox);
            Controls.Add(contactsCollectorLabel);
            Controls.Add(nameCollectorLabel);
            Controls.Add(countryCollectorLabel);
            Name = "AddCollectorForm";
            Text = "AddCollectorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCollectorButton;
        private TextBox contactsCollectorTextBox;
        private TextBox nameCollectorTextBox;
        private TextBox countryCollectorTextBox;
        private Label contactsCollectorLabel;
        private Label nameCollectorLabel;
        private Label countryCollectorLabel;
        private Label addingCollectorLabel;
    }
}