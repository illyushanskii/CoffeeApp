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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericPriceMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMin).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(36, 30, 19);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 0;
            label1.Text = "Фільтрувати";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(36, 30, 19);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(58, 22);
            label2.TabIndex = 1;
            label2.Text = "Ціна:";
            // 
            // numericPriceMin
            // 
            numericPriceMin.DecimalPlaces = 2;
            numericPriceMin.Location = new Point(102, 53);
            numericPriceMin.Margin = new Padding(3, 2, 3, 2);
            numericPriceMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPriceMin.Name = "numericPriceMin";
            numericPriceMin.Size = new Size(65, 23);
            numericPriceMin.TabIndex = 2;
            numericPriceMin.ValueChanged += numericPriceMin_ValueChanged;
            // 
            // numericPriceMax
            // 
            numericPriceMax.DecimalPlaces = 2;
            numericPriceMax.Location = new Point(209, 53);
            numericPriceMax.Margin = new Padding(3, 2, 3, 2);
            numericPriceMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPriceMax.Name = "numericPriceMax";
            numericPriceMax.Size = new Size(60, 23);
            numericPriceMax.TabIndex = 3;
            numericPriceMax.ValueChanged += numericPriceMax_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(61, 57);
            label3.Name = "label3";
            label3.Size = new Size(35, 19);
            label3.TabIndex = 4;
            label3.Text = "Від :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(173, 57);
            label4.Name = "label4";
            label4.Size = new Size(30, 19);
            label4.TabIndex = 5;
            label4.Text = "До:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(36, 30, 19);
            label5.Location = new Point(1, 110);
            label5.Name = "label5";
            label5.Size = new Size(67, 22);
            label5.TabIndex = 6;
            label5.Text = "Маса:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(173, 118);
            label6.Name = "label6";
            label6.Size = new Size(30, 19);
            label6.TabIndex = 10;
            label6.Text = "До:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(65, 116);
            label7.Name = "label7";
            label7.Size = new Size(35, 19);
            label7.TabIndex = 9;
            label7.Text = "Від :";
            // 
            // numericWeightMax
            // 
            numericWeightMax.DecimalPlaces = 2;
            numericWeightMax.Location = new Point(209, 116);
            numericWeightMax.Margin = new Padding(3, 2, 3, 2);
            numericWeightMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericWeightMax.Name = "numericWeightMax";
            numericWeightMax.Size = new Size(60, 23);
            numericWeightMax.TabIndex = 8;
            numericWeightMax.ValueChanged += numericWeightMax_ValueChanged;
            // 
            // numericWeightMin
            // 
            numericWeightMin.DecimalPlaces = 2;
            numericWeightMin.Location = new Point(102, 116);
            numericWeightMin.Margin = new Padding(3, 2, 3, 2);
            numericWeightMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericWeightMin.Name = "numericWeightMin";
            numericWeightMin.Size = new Size(65, 23);
            numericWeightMin.TabIndex = 7;
            numericWeightMin.ValueChanged += numericWeightMin_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.FromArgb(168, 141, 85);
            label8.Location = new Point(12, 58);
            label8.Name = "label8";
            label8.Size = new Size(52, 22);
            label8.TabIndex = 11;
            label8.Text = "Тип:";
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.White;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "none" });
            comboBoxType.Location = new Point(61, 82);
            comboBoxType.Margin = new Padding(3, 2, 3, 2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(232, 23);
            comboBoxType.TabIndex = 12;
            // 
            // comboBoxComposition
            // 
            comboBoxComposition.BackColor = Color.White;
            comboBoxComposition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComposition.FormattingEnabled = true;
            comboBoxComposition.Items.AddRange(new object[] { "none" });
            comboBoxComposition.Location = new Point(61, 131);
            comboBoxComposition.Margin = new Padding(3, 2, 3, 2);
            comboBoxComposition.Name = "comboBoxComposition";
            comboBoxComposition.Size = new Size(232, 23);
            comboBoxComposition.TabIndex = 14;
            comboBoxComposition.SelectedIndexChanged += comboBoxComposition_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.FromArgb(168, 141, 85);
            label9.Location = new Point(9, 107);
            label9.Name = "label9";
            label9.Size = new Size(76, 22);
            label9.TabIndex = 13;
            label9.Text = "Склад:";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.BackColor = Color.White;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Items.AddRange(new object[] { "none" });
            comboBoxCountry.Location = new Point(61, 180);
            comboBoxCountry.Margin = new Padding(3, 2, 3, 2);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(232, 23);
            comboBoxCountry.TabIndex = 16;
            comboBoxCountry.TextUpdate += comboBoxCountry_TextUpdate;
            comboBoxCountry.Click += comboBoxCountry_Click;
            comboBoxCountry.Leave += comboBoxCountry_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.FromArgb(168, 141, 85);
            label10.Location = new Point(12, 156);
            label10.Name = "label10";
            label10.Size = new Size(178, 22);
            label10.TabIndex = 15;
            label10.Text = "Країна-виробник:";
            // 
            // buttonReset
            // 
            buttonReset.DialogResult = DialogResult.OK;
            buttonReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(9, 230);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(122, 29);
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
            buttonOK.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK.Location = new Point(173, 230);
            buttonOK.Margin = new Padding(3, 2, 3, 2);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(129, 29);
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
            comboBoxName.Location = new Point(65, 33);
            comboBoxName.Margin = new Padding(3, 2, 3, 2);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(232, 23);
            comboBoxName.TabIndex = 21;
            comboBoxName.TextUpdate += comboBoxName_TextUpdate;
            comboBoxName.Click += comboBoxName_Click;
            comboBoxName.Leave += comboBoxName_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.FromArgb(168, 141, 85);
            label11.Location = new Point(9, 9);
            label11.Name = "label11";
            label11.Size = new Size(73, 22);
            label11.TabIndex = 20;
            label11.Text = "Назва:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(168, 141, 85);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericPriceMin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numericPriceMax);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numericWeightMin);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericWeightMax);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 170);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 43, 7);
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
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 279);
            panel2.TabIndex = 23;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 443);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фільтр";
            Load += FilterForm_Load;
            Paint += FilterForm_Paint;
            ((System.ComponentModel.ISupportInitialize)numericPriceMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPriceMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWeightMin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
    }
}