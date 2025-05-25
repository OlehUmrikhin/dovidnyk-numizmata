namespace dovidnyk_numizmata.Forms
{
    partial class AddCoinForm
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
            featuresCoinsTextBox = new TextBox();
            numberCoinsTextBox = new TextBox();
            materialCoinsTextBox = new TextBox();
            yearOfGraduationCoinsTextBox = new TextBox();
            parCoinsTextBox = new TextBox();
            countryCoinsTextBox = new TextBox();
            featuresCoinsLabel = new Label();
            numberCoinsLabel = new Label();
            MaterialCoinsLabel = new Label();
            yearOfGraduationCoinsLabel = new Label();
            parCoinsLabel = new Label();
            countryCoinsLabel = new Label();
            panel2 = new Panel();
            addLabel = new Label();
            AddCoinButton = new Button();
            coinBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).BeginInit();
            SuspendLayout();
            // 
            // featuresCoinsTextBox
            // 
            featuresCoinsTextBox.Location = new Point(195, 259);
            featuresCoinsTextBox.Name = "featuresCoinsTextBox";
            featuresCoinsTextBox.Size = new Size(201, 23);
            featuresCoinsTextBox.TabIndex = 34;
            // 
            // numberCoinsTextBox
            // 
            numberCoinsTextBox.Location = new Point(232, 224);
            numberCoinsTextBox.Name = "numberCoinsTextBox";
            numberCoinsTextBox.Size = new Size(164, 23);
            numberCoinsTextBox.TabIndex = 33;
            // 
            // materialCoinsTextBox
            // 
            materialCoinsTextBox.Location = new Point(137, 189);
            materialCoinsTextBox.Name = "materialCoinsTextBox";
            materialCoinsTextBox.Size = new Size(259, 23);
            materialCoinsTextBox.TabIndex = 32;
            // 
            // yearOfGraduationCoinsTextBox
            // 
            yearOfGraduationCoinsTextBox.Location = new Point(144, 154);
            yearOfGraduationCoinsTextBox.Name = "yearOfGraduationCoinsTextBox";
            yearOfGraduationCoinsTextBox.Size = new Size(252, 23);
            yearOfGraduationCoinsTextBox.TabIndex = 31;
            // 
            // parCoinsTextBox
            // 
            parCoinsTextBox.Location = new Point(137, 119);
            parCoinsTextBox.Name = "parCoinsTextBox";
            parCoinsTextBox.Size = new Size(259, 23);
            parCoinsTextBox.TabIndex = 30;
            // 
            // countryCoinsTextBox
            // 
            countryCoinsTextBox.Location = new Point(137, 83);
            countryCoinsTextBox.Name = "countryCoinsTextBox";
            countryCoinsTextBox.Size = new Size(259, 23);
            countryCoinsTextBox.TabIndex = 29;
            // 
            // featuresCoinsLabel
            // 
            featuresCoinsLabel.AutoSize = true;
            featuresCoinsLabel.Location = new Point(65, 262);
            featuresCoinsLabel.Name = "featuresCoinsLabel";
            featuresCoinsLabel.Size = new Size(124, 15);
            featuresCoinsLabel.TabIndex = 28;
            featuresCoinsLabel.Text = "Особливості монети:";
            // 
            // numberCoinsLabel
            // 
            numberCoinsLabel.AutoSize = true;
            numberCoinsLabel.Location = new Point(65, 227);
            numberCoinsLabel.Name = "numberCoinsLabel";
            numberCoinsLabel.Size = new Size(162, 15);
            numberCoinsLabel.TabIndex = 27;
            numberCoinsLabel.Text = "Кількість випущених монет:";
            // 
            // MaterialCoinsLabel
            // 
            MaterialCoinsLabel.AutoSize = true;
            MaterialCoinsLabel.Location = new Point(65, 192);
            MaterialCoinsLabel.Name = "MaterialCoinsLabel";
            MaterialCoinsLabel.Size = new Size(61, 15);
            MaterialCoinsLabel.TabIndex = 26;
            MaterialCoinsLabel.Text = "Матеріал:";
            // 
            // yearOfGraduationCoinsLabel
            // 
            yearOfGraduationCoinsLabel.AutoSize = true;
            yearOfGraduationCoinsLabel.Location = new Point(65, 157);
            yearOfGraduationCoinsLabel.Name = "yearOfGraduationCoinsLabel";
            yearOfGraduationCoinsLabel.Size = new Size(73, 15);
            yearOfGraduationCoinsLabel.TabIndex = 25;
            yearOfGraduationCoinsLabel.Text = "Рік випуску:";
            // 
            // parCoinsLabel
            // 
            parCoinsLabel.AutoSize = true;
            parCoinsLabel.Location = new Point(65, 122);
            parCoinsLabel.Name = "parCoinsLabel";
            parCoinsLabel.Size = new Size(58, 15);
            parCoinsLabel.TabIndex = 24;
            parCoinsLabel.Text = "Номінал:";
            // 
            // countryCoinsLabel
            // 
            countryCoinsLabel.AutoSize = true;
            countryCoinsLabel.Location = new Point(65, 87);
            countryCoinsLabel.Name = "countryCoinsLabel";
            countryCoinsLabel.Size = new Size(46, 15);
            countryCoinsLabel.TabIndex = 23;
            countryCoinsLabel.Text = "Країна:";
            // 
            // panel2
            // 
            panel2.Controls.Add(AddCoinButton);
            panel2.Location = new Point(36, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 318);
            panel2.TabIndex = 37;
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addLabel.Location = new Point(154, 19);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(149, 20);
            addLabel.TabIndex = 1;
            addLabel.Text = "Додавання монети";
            // 
            // AddCoinButton
            // 
            AddCoinButton.Location = new Point(155, 270);
            AddCoinButton.Name = "AddCoinButton";
            AddCoinButton.Size = new Size(75, 23);
            AddCoinButton.TabIndex = 0;
            AddCoinButton.Text = "Додати";
            AddCoinButton.UseVisualStyleBackColor = true;
            AddCoinButton.Click += AddCoinButton_Click;
            // 
            // coinBindingSource
            // 
            coinBindingSource.DataSource = typeof(Models.Coin);
            // 
            // AddCoinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 375);
            Controls.Add(addLabel);
            Controls.Add(featuresCoinsTextBox);
            Controls.Add(numberCoinsTextBox);
            Controls.Add(materialCoinsTextBox);
            Controls.Add(yearOfGraduationCoinsTextBox);
            Controls.Add(parCoinsTextBox);
            Controls.Add(countryCoinsTextBox);
            Controls.Add(featuresCoinsLabel);
            Controls.Add(numberCoinsLabel);
            Controls.Add(MaterialCoinsLabel);
            Controls.Add(yearOfGraduationCoinsLabel);
            Controls.Add(parCoinsLabel);
            Controls.Add(countryCoinsLabel);
            Controls.Add(panel2);
            Name = "AddCoinForm";
            Text = "AddCoinForm";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox featuresCoinsTextBox;
        private TextBox numberCoinsTextBox;
        private TextBox materialCoinsTextBox;
        private TextBox yearOfGraduationCoinsTextBox;
        private TextBox parCoinsTextBox;
        private TextBox countryCoinsTextBox;
        private Label featuresCoinsLabel;
        private Label numberCoinsLabel;
        private Label MaterialCoinsLabel;
        private Label yearOfGraduationCoinsLabel;
        private Label parCoinsLabel;
        private Label countryCoinsLabel;
        private Panel panel2;
        private Button AddCoinButton;
        private BindingSource coinBindingSource;
        private Label addLabel;
    }
}