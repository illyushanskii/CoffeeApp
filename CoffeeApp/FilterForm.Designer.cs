namespace CoffeeApp
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            label1 = new Label();
            label2 = new Label();
            numericPriceMin = new NumericUpDown();
            numericPriceMax = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericWeightMax = new NumericUpDown();
            numericWeightMin = new NumericUpDown();
            label8 = new Label();
            comboBoxType = new ComboBox();
            comboBoxComposition = new ComboBox();
            label9 = new Label();
            comboBoxCountry = new ComboBox();
            label10 = new Label();
            buttonReset = new Button();
            buttonOK = new Button();
            comboBoxName = new ComboBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericPriceMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 0;
            label1.Text = "Фільтрувати";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 40);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 1;
            label2.Text = "Ціна:";
            // 
            // numericPriceMin
            // 
            numericPriceMin.DecimalPlaces = 2;
            numericPriceMin.Location = new Point(86, 78);
            numericPriceMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPriceMin.Name = "numericPriceMin";
            numericPriceMin.Size = new Size(74, 27);
            numericPriceMin.TabIndex = 2;
            numericPriceMin.ValueChanged += numericPriceMin_ValueChanged;
            // 
            // numericPriceMax
            // 
            numericPriceMax.DecimalPlaces = 2;
            numericPriceMax.Location = new Point(203, 78);
            numericPriceMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPriceMax.Name = "numericPriceMax";
            numericPriceMax.Size = new Size(69, 27);
            numericPriceMax.TabIndex = 3;
            numericPriceMax.ValueChanged += numericPriceMax_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(38, 78);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 4;
            label3.Text = "Від :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(166, 78);
            label4.Name = "label4";
            label4.Size = new Size(36, 23);
            label4.TabIndex = 5;
            label4.Text = "До:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(9, 122);
            label5.Name = "label5";
            label5.Size = new Size(63, 28);
            label5.TabIndex = 6;
            label5.Text = "Маса:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(166, 160);
            label6.Name = "label6";
            label6.Size = new Size(36, 23);
            label6.TabIndex = 10;
            label6.Text = "До:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(38, 160);
            label7.Name = "label7";
            label7.Size = new Size(42, 23);
            label7.TabIndex = 9;
            label7.Text = "Від :";
            // 
            // numericWeightMax
            // 
            numericWeightMax.DecimalPlaces = 2;
            numericWeightMax.Location = new Point(203, 160);
            numericWeightMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericWeightMax.Name = "numericWeightMax";
            numericWeightMax.Size = new Size(69, 27);
            numericWeightMax.TabIndex = 8;
            numericWeightMax.ValueChanged += numericWeightMax_ValueChanged;
            // 
            // numericWeightMin
            // 
            numericWeightMin.DecimalPlaces = 2;
            numericWeightMin.Location = new Point(86, 160);
            numericWeightMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericWeightMin.Name = "numericWeightMin";
            numericWeightMin.Size = new Size(74, 27);
            numericWeightMin.TabIndex = 7;
            numericWeightMin.ValueChanged += numericWeightMin_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(9, 286);
            label8.Name = "label8";
            label8.Size = new Size(50, 28);
            label8.TabIndex = 11;
            label8.Text = "Тип:";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "none" });
            comboBoxType.Location = new Point(38, 319);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(234, 28);
            comboBoxType.TabIndex = 12;
            // 
            // comboBoxComposition
            // 
            comboBoxComposition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComposition.FormattingEnabled = true;
            comboBoxComposition.Items.AddRange(new object[] { "none" });
            comboBoxComposition.Location = new Point(38, 401);
            comboBoxComposition.Name = "comboBoxComposition";
            comboBoxComposition.Size = new Size(234, 28);
            comboBoxComposition.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(9, 368);
            label9.Name = "label9";
            label9.Size = new Size(70, 28);
            label9.TabIndex = 13;
            label9.Text = "Склад:";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Items.AddRange(new object[] { "none" });
            comboBoxCountry.Location = new Point(38, 483);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(234, 28);
            comboBoxCountry.TabIndex = 16;
            comboBoxCountry.TextUpdate += comboBoxCountry_TextUpdate;
            comboBoxCountry.Click += comboBoxCountry_Click;
            comboBoxCountry.Leave += comboBoxCountry_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(9, 450);
            label10.Name = "label10";
            label10.Size = new Size(178, 28);
            label10.TabIndex = 15;
            label10.Text = "Країна-виробник:";
            // 
            // buttonReset
            // 
            buttonReset.DialogResult = DialogResult.OK;
            buttonReset.Font = new Font("Segoe UI", 12F);
            buttonReset.Location = new Point(9, 536);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(140, 39);
            buttonReset.TabIndex = 18;
            buttonReset.Text = "Скинути";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Font = new Font("Segoe UI", 12F);
            buttonOK.Location = new Point(155, 536);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(147, 39);
            buttonOK.TabIndex = 19;
            buttonOK.Text = "Прийняти";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // comboBoxName
            // 
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Items.AddRange(new object[] { "none" });
            comboBoxName.Location = new Point(38, 237);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(234, 28);
            comboBoxName.TabIndex = 21;
            comboBoxName.TextUpdate += comboBoxName_TextUpdate;
            comboBoxName.Click += comboBoxName_Click;
            comboBoxName.Leave += comboBoxName_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(9, 204);
            label11.Name = "label11";
            label11.Size = new Size(70, 28);
            label11.TabIndex = 20;
            label11.Text = "Назва:";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 584);
            Controls.Add(comboBoxName);
            Controls.Add(label11);
            Controls.Add(buttonOK);
            Controls.Add(buttonReset);
            Controls.Add(comboBoxCountry);
            Controls.Add(label10);
            Controls.Add(comboBoxComposition);
            Controls.Add(label9);
            Controls.Add(comboBoxType);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(numericWeightMax);
            Controls.Add(numericWeightMin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericPriceMax);
            Controls.Add(numericPriceMin);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фільтр";
            Load += FilterForm_Load;
            Paint += FilterForm_Paint;
            ((System.ComponentModel.ISupportInitialize)numericPriceMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericPriceMin;
        private NumericUpDown numericPriceMax;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericWeightMax;
        private NumericUpDown numericWeightMin;
        private Label label8;
        private ComboBox comboBoxType;
        private ComboBox comboBoxComposition;
        private Label label9;
        private ComboBox comboBoxCountry;
        private Label label10;
        private Button buttonReset;
        private Button buttonOK;
        private ComboBox comboBoxName;
        private Label label11;
    }
}