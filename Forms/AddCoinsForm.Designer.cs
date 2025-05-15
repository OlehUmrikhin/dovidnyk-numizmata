using dovidnyk_numizmata.Models;

namespace dovidnyk_numizmata.Forms
{
    partial class AddCoinsForm
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
            titleAdd = new Label();
            countryCoinsAddLabel = new Label();
            parCoinsAddLabel = new Label();
            yearOfGraduationCoinsAddLabel = new Label();
            MaterialCoinsAddLabel = new Label();
            numberCoinsAddLabel = new Label();
            FeaturesCoinsAddLabel = new Label();
            countryCoinsAddTextBox = new TextBox();
            parCoinsAddTextBox = new TextBox();
            yearOfGraduationCoinsAddTextBox = new TextBox();
            materialCoinsAddTextBox = new TextBox();
            numberCoinsAddTextBox = new TextBox();
            featuresCoinsAddTextBox = new TextBox();
            allCoinsListBox = new ListBox();
            coinBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).BeginInit();
            SuspendLayout();
            // 
            // titleAdd
            // 
            titleAdd.AutoSize = true;
            titleAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleAdd.Location = new Point(326, 34);
            titleAdd.Name = "titleAdd";
            titleAdd.Size = new Size(129, 21);
            titleAdd.TabIndex = 0;
            titleAdd.Text = "Додати монету";
            // 
            // countryCoinsAddLabel
            // 
            countryCoinsAddLabel.AutoSize = true;
            countryCoinsAddLabel.Location = new Point(25, 77);
            countryCoinsAddLabel.Name = "countryCoinsAddLabel";
            countryCoinsAddLabel.Size = new Size(46, 15);
            countryCoinsAddLabel.TabIndex = 1;
            countryCoinsAddLabel.Text = "Країна:";
            // 
            // parCoinsAddLabel
            // 
            parCoinsAddLabel.AutoSize = true;
            parCoinsAddLabel.Location = new Point(25, 106);
            parCoinsAddLabel.Name = "parCoinsAddLabel";
            parCoinsAddLabel.Size = new Size(58, 15);
            parCoinsAddLabel.TabIndex = 2;
            parCoinsAddLabel.Text = "Номінал:";
            // 
            // yearOfGraduationCoinsAddLabel
            // 
            yearOfGraduationCoinsAddLabel.AutoSize = true;
            yearOfGraduationCoinsAddLabel.Location = new Point(25, 134);
            yearOfGraduationCoinsAddLabel.Name = "yearOfGraduationCoinsAddLabel";
            yearOfGraduationCoinsAddLabel.Size = new Size(73, 15);
            yearOfGraduationCoinsAddLabel.TabIndex = 3;
            yearOfGraduationCoinsAddLabel.Text = "Рік випуску:";
            // 
            // MaterialCoinsAddLabel
            // 
            MaterialCoinsAddLabel.AutoSize = true;
            MaterialCoinsAddLabel.Location = new Point(25, 165);
            MaterialCoinsAddLabel.Name = "MaterialCoinsAddLabel";
            MaterialCoinsAddLabel.Size = new Size(61, 15);
            MaterialCoinsAddLabel.TabIndex = 4;
            MaterialCoinsAddLabel.Text = "Матеріал:";
            // 
            // numberCoinsAddLabel
            // 
            numberCoinsAddLabel.AutoSize = true;
            numberCoinsAddLabel.Location = new Point(25, 199);
            numberCoinsAddLabel.Name = "numberCoinsAddLabel";
            numberCoinsAddLabel.Size = new Size(162, 15);
            numberCoinsAddLabel.TabIndex = 5;
            numberCoinsAddLabel.Text = "Кількість випущених монет:";
            // 
            // FeaturesCoinsAddLabel
            // 
            FeaturesCoinsAddLabel.AutoSize = true;
            FeaturesCoinsAddLabel.Location = new Point(25, 233);
            FeaturesCoinsAddLabel.Name = "FeaturesCoinsAddLabel";
            FeaturesCoinsAddLabel.Size = new Size(77, 15);
            FeaturesCoinsAddLabel.TabIndex = 6;
            FeaturesCoinsAddLabel.Text = "Особливості";
            // 
            // countryCoinsAddTextBox
            // 
            countryCoinsAddTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Country", true));
            countryCoinsAddTextBox.Location = new Point(87, 70);
            countryCoinsAddTextBox.Name = "countryCoinsAddTextBox";
            countryCoinsAddTextBox.Size = new Size(206, 23);
            countryCoinsAddTextBox.TabIndex = 7;
            // 
            // parCoinsAddTextBox
            // 
            parCoinsAddTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Par", true));
            parCoinsAddTextBox.Location = new Point(87, 102);
            parCoinsAddTextBox.Name = "parCoinsAddTextBox";
            parCoinsAddTextBox.Size = new Size(206, 23);
            parCoinsAddTextBox.TabIndex = 8;
            // 
            // yearOfGraduationCoinsAddTextBox
            // 
            yearOfGraduationCoinsAddTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "YearOfGraduation", true));
            yearOfGraduationCoinsAddTextBox.Location = new Point(104, 131);
            yearOfGraduationCoinsAddTextBox.Name = "yearOfGraduationCoinsAddTextBox";
            yearOfGraduationCoinsAddTextBox.Size = new Size(189, 23);
            yearOfGraduationCoinsAddTextBox.TabIndex = 9;
            // 
            // materialCoinsAddTextBox
            // 
            materialCoinsAddTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Material", true));
            materialCoinsAddTextBox.Location = new Point(92, 162);
            materialCoinsAddTextBox.Name = "materialCoinsAddTextBox";
            materialCoinsAddTextBox.Size = new Size(201, 23);
            materialCoinsAddTextBox.TabIndex = 10;
            // 
            // numberCoinsAddTextBox
            // 
            numberCoinsAddTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Number", true));
            numberCoinsAddTextBox.Location = new Point(193, 196);
            numberCoinsAddTextBox.Name = "numberCoinsAddTextBox";
            numberCoinsAddTextBox.Size = new Size(100, 23);
            numberCoinsAddTextBox.TabIndex = 11;
            // 
            // featuresCoinsAddTextBox
            // 
            featuresCoinsAddTextBox.DataBindings.Add(new Binding("Text", coinBindingSource, "Features", true));
            featuresCoinsAddTextBox.Location = new Point(108, 230);
            featuresCoinsAddTextBox.Name = "featuresCoinsAddTextBox";
            featuresCoinsAddTextBox.Size = new Size(185, 23);
            featuresCoinsAddTextBox.TabIndex = 12;
            // 
            // allCoinsListBox
            // 
            allCoinsListBox.DataSource = coinBindingSource;
            allCoinsListBox.DisplayMember = "Info";
            allCoinsListBox.FormattingEnabled = true;
            allCoinsListBox.Location = new Point(327, 72);
            allCoinsListBox.Name = "allCoinsListBox";
            allCoinsListBox.Size = new Size(448, 319);
            allCoinsListBox.TabIndex = 13;
            // 
            // coinBindingSource
            // 
            coinBindingSource.DataSource = typeof(Coin);
            // 
            // button1
            // 
            button1.Location = new Point(30, 302);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(123, 301);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Пошук";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddCoinsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(allCoinsListBox);
            Controls.Add(featuresCoinsAddTextBox);
            Controls.Add(numberCoinsAddTextBox);
            Controls.Add(materialCoinsAddTextBox);
            Controls.Add(yearOfGraduationCoinsAddTextBox);
            Controls.Add(parCoinsAddTextBox);
            Controls.Add(countryCoinsAddTextBox);
            Controls.Add(FeaturesCoinsAddLabel);
            Controls.Add(numberCoinsAddLabel);
            Controls.Add(MaterialCoinsAddLabel);
            Controls.Add(yearOfGraduationCoinsAddLabel);
            Controls.Add(parCoinsAddLabel);
            Controls.Add(countryCoinsAddLabel);
            Controls.Add(titleAdd);
            Name = "AddCoinsForm";
            Text = "AddCoinsForm";
            ((System.ComponentModel.ISupportInitialize)coinBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleAdd;
        private Label countryCoinsAddLabel;
        private Label parCoinsAddLabel;
        private Label yearOfGraduationCoinsAddLabel;
        private Label MaterialCoinsAddLabel;
        private Label numberCoinsAddLabel;
        private Label FeaturesCoinsAddLabel;
        private TextBox countryCoinsAddTextBox;
        private TextBox parCoinsAddTextBox;
        private TextBox yearOfGraduationCoinsAddTextBox;
        private TextBox materialCoinsAddTextBox;
        private TextBox numberCoinsAddTextBox;
        private TextBox featuresCoinsAddTextBox;
        private ListBox allCoinsListBox;
        private Button button1;
        private Button button2;
        private BindingSource coinBindingSource;
    }
}