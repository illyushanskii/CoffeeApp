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
            panel2 = new Panel();
            label6 = new Label();
            numericWeightMin = new NumericUpDown();
            label7 = new Label();
            label5 = new Label();
            numericPriceMax = new NumericUpDown();
            label4 = new Label();
            numericPriceMin = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericWeightMax = new NumericUpDown();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericWeightMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMax).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.FromArgb(82, 38, 7);
            label8.Location = new Point(12, 262);
            label8.Name = "label8";
            label8.Size = new Size(59, 23);
            label8.TabIndex = 11;
            label8.Text = "Тип:";
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.White;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "none" });
            comboBoxType.Location = new Point(61, 297);
            comboBoxType.Margin = new Padding(3, 2, 3, 2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(177, 23);
            comboBoxType.TabIndex = 12;
            // 
            // comboBoxComposition
            // 
            comboBoxComposition.BackColor = Color.White;
            comboBoxComposition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComposition.FormattingEnabled = true;
            comboBoxComposition.Items.AddRange(new object[] { "none" });
            comboBoxComposition.Location = new Point(61, 365);
            comboBoxComposition.Margin = new Padding(3, 2, 3, 2);
            comboBoxComposition.Name = "comboBoxComposition";
            comboBoxComposition.Size = new Size(177, 23);
            comboBoxComposition.TabIndex = 14;
            comboBoxComposition.SelectedIndexChanged += comboBoxComposition_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.FromArgb(82, 38, 7);
            label9.Location = new Point(12, 331);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 13;
            label9.Text = "Склад:";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.BackColor = Color.White;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Items.AddRange(new object[] { "none" });
            comboBoxCountry.Location = new Point(61, 433);
            comboBoxCountry.Margin = new Padding(3, 2, 3, 2);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(177, 23);
            comboBoxCountry.TabIndex = 16;
            comboBoxCountry.TextUpdate += comboBoxCountry_TextUpdate;
            comboBoxCountry.Click += comboBoxCountry_Click;
            comboBoxCountry.Leave += comboBoxCountry_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.FromArgb(82, 38, 7);
            label10.Location = new Point(12, 399);
            label10.Name = "label10";
            label10.Size = new Size(209, 23);
            label10.TabIndex = 15;
            label10.Text = "Країна-виробник:";
            // 
            // buttonReset
            // 
            buttonReset.DialogResult = DialogResult.OK;
            buttonReset.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(12, 470);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(110, 30);
            buttonReset.TabIndex = 18;
            buttonReset.Text = "Скинути";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            buttonReset.MouseLeave += buttonReset_MouseLeave;
            buttonReset.MouseHover += buttonReset_MouseHover;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK.Location = new Point(128, 470);
            buttonOK.Margin = new Padding(3, 2, 3, 2);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(110, 30);
            buttonOK.TabIndex = 19;
            buttonOK.Text = "Прийняти";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            buttonOK.MouseLeave += buttonOK_MouseLeave;
            buttonOK.MouseHover += buttonOK_MouseHover;
            // 
            // comboBoxName
            // 
            comboBoxName.BackColor = Color.White;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Items.AddRange(new object[] { "none" });
            comboBoxName.Location = new Point(61, 228);
            comboBoxName.Margin = new Padding(3, 2, 3, 2);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(177, 23);
            comboBoxName.TabIndex = 21;
            comboBoxName.TextUpdate += comboBoxName_TextUpdate;
            comboBoxName.Click += comboBoxName_Click;
            comboBoxName.Leave += comboBoxName_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.FromArgb(82, 38, 7);
            label11.Location = new Point(12, 194);
            label11.Name = "label11";
            label11.Size = new Size(84, 23);
            label11.TabIndex = 20;
            label11.Text = "Назва:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(246, 221, 199);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(numericWeightMin);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(numericPriceMax);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numericPriceMin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBoxName);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(buttonOK);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(buttonReset);
            panel2.Controls.Add(comboBoxType);
            panel2.Controls.Add(comboBoxCountry);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(comboBoxComposition);
            panel2.Controls.Add(numericWeightMax);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Vladimir Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 511);
            panel2.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(82, 38, 7);
            label6.Location = new Point(132, 161);
            label6.Name = "label6";
            label6.Size = new Size(32, 16);
            label6.TabIndex = 10;
            label6.Text = "До:";
            // 
            // numericWeightMin
            // 
            numericWeightMin.DecimalPlaces = 2;
            numericWeightMin.Location = new Point(61, 155);
            numericWeightMin.Margin = new Padding(3, 2, 3, 2);
            numericWeightMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericWeightMin.Name = "numericWeightMin";
            numericWeightMin.Size = new Size(65, 22);
            numericWeightMin.TabIndex = 7;
            numericWeightMin.ValueChanged += numericWeightMin_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.FromArgb(82, 38, 7);
            label7.Location = new Point(12, 161);
            label7.Name = "label7";
            label7.Size = new Size(39, 16);
            label7.TabIndex = 9;
            label7.Text = "Від :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(82, 38, 7);
            label5.Location = new Point(7, 121);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 6;
            label5.Text = "Маса:";
            // 
            // numericPriceMax
            // 
            numericPriceMax.DecimalPlaces = 2;
            numericPriceMax.Location = new Point(178, 89);
            numericPriceMax.Margin = new Padding(3, 2, 3, 2);
            numericPriceMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPriceMax.Name = "numericPriceMax";
            numericPriceMax.Size = new Size(60, 22);
            numericPriceMax.TabIndex = 3;
            numericPriceMax.ValueChanged += numericPriceMax_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(82, 38, 7);
            label4.Location = new Point(132, 95);
            label4.Name = "label4";
            label4.Size = new Size(32, 16);
            label4.TabIndex = 5;
            label4.Text = "До:";
            // 
            // numericPriceMin
            // 
            numericPriceMin.DecimalPlaces = 2;
            numericPriceMin.Location = new Point(61, 89);
            numericPriceMin.Margin = new Padding(3, 2, 3, 2);
            numericPriceMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPriceMin.Name = "numericPriceMin";
            numericPriceMin.Size = new Size(65, 22);
            numericPriceMin.TabIndex = 2;
            numericPriceMin.ValueChanged += numericPriceMin_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(82, 38, 7);
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 4;
            label3.Text = "Від :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(82, 38, 7);
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 1;
            label2.Text = "Ціна:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(82, 38, 7);
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Фільтрувати";
            label1.Click += label1_Click;
            // 
            // numericWeightMax
            // 
            numericWeightMax.DecimalPlaces = 2;
            numericWeightMax.Location = new Point(178, 155);
            numericWeightMax.Margin = new Padding(3, 2, 3, 2);
            numericWeightMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericWeightMax.Name = "numericWeightMax";
            numericWeightMax.Size = new Size(60, 22);
            numericWeightMax.TabIndex = 8;
            numericWeightMax.ValueChanged += numericWeightMax_ValueChanged;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 511);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фільтр";
            Load += FilterForm_Load;
            Paint += FilterForm_Paint;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericWeightMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMax).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panel2;
        private Label label6;
        private NumericUpDown numericWeightMin;
        private Label label7;
        private Label label5;
        private NumericUpDown numericPriceMax;
        private Label label4;
        private NumericUpDown numericPriceMin;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericWeightMax;
    }
}