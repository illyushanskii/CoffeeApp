namespace CoffeeApp
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            groupBox1 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            textBoxComposition = new TextBox();
            textBoxType = new TextBox();
            textBoxName = new TextBox();
            buttonCancel = new Button();
            label3 = new Label();
            label10 = new Label();
            label5 = new Label();
            textBoxCountry = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxWeight = new TextBox();
            textBoxPriceSell = new TextBox();
            label2 = new Label();
            pictureBoxImg = new PictureBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Beige;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxComposition);
            groupBox1.Controls.Add(textBoxType);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxCountry);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxWeight);
            groupBox1.Controls.Add(textBoxPriceSell);
            groupBox1.Location = new Point(4, 113);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(277, 231);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(82, 38, 7);
            label6.Location = new Point(228, 75);
            label6.Name = "label6";
            label6.Size = new Size(44, 18);
            label6.TabIndex = 28;
            label6.Text = "Грам";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(82, 38, 7);
            label4.Location = new Point(221, 45);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 27;
            label4.Text = "₴ грн.";
            // 
            // textBoxComposition
            // 
            textBoxComposition.Location = new Point(106, 165);
            textBoxComposition.Margin = new Padding(3, 2, 3, 2);
            textBoxComposition.Name = "textBoxComposition";
            textBoxComposition.ReadOnly = true;
            textBoxComposition.Size = new Size(162, 23);
            textBoxComposition.TabIndex = 26;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(94, 105);
            textBoxType.Margin = new Padding(3, 2, 3, 2);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(175, 23);
            textBoxType.TabIndex = 25;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(64, 15);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.MaxLength = 32;
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(205, 23);
            textBoxName.TabIndex = 11;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Ivory;
            buttonCancel.DialogResult = DialogResult.OK;
            buttonCancel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = Color.FromArgb(82, 38, 7);
            buttonCancel.Location = new Point(72, 195);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(131, 36);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "OK";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(82, 38, 7);
            label3.Location = new Point(0, 15);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 6;
            label3.Text = "Назва:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.FromArgb(82, 38, 7);
            label10.Location = new Point(0, 165);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 20;
            label10.Text = "Склад кави:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(82, 38, 7);
            label5.Location = new Point(0, 45);
            label5.Name = "label5";
            label5.Size = new Size(44, 18);
            label5.TabIndex = 8;
            label5.Text = "Ціна:";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(155, 135);
            textBoxCountry.Margin = new Padding(3, 2, 3, 2);
            textBoxCountry.MaxLength = 32;
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.ReadOnly = true;
            textBoxCountry.Size = new Size(113, 23);
            textBoxCountry.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.FromArgb(82, 38, 7);
            label9.Location = new Point(0, 135);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 18;
            label9.Text = "Країна-виробник:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.FromArgb(82, 38, 7);
            label7.Location = new Point(0, 75);
            label7.Name = "label7";
            label7.Size = new Size(92, 18);
            label7.TabIndex = 10;
            label7.Text = "Маса нетто:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.FromArgb(82, 38, 7);
            label8.Location = new Point(0, 105);
            label8.Name = "label8";
            label8.Size = new Size(77, 18);
            label8.TabIndex = 16;
            label8.Text = "Тип кави:";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(114, 75);
            textBoxWeight.Margin = new Padding(3, 2, 3, 2);
            textBoxWeight.MaxLength = 10;
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.ReadOnly = true;
            textBoxWeight.Size = new Size(110, 23);
            textBoxWeight.TabIndex = 15;
            // 
            // textBoxPriceSell
            // 
            textBoxPriceSell.Location = new Point(56, 45);
            textBoxPriceSell.Margin = new Padding(3, 2, 3, 2);
            textBoxPriceSell.MaxLength = 10;
            textBoxPriceSell.Name = "textBoxPriceSell";
            textBoxPriceSell.ReadOnly = true;
            textBoxPriceSell.Size = new Size(168, 23);
            textBoxPriceSell.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(82, 38, 7);
            label2.Location = new Point(120, 62);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 30;
            label2.Text = "Фото товару";
            // 
            // pictureBoxImg
            // 
            pictureBoxImg.Image = (Image)resources.GetObject("pictureBoxImg.Image");
            pictureBoxImg.Location = new Point(5, 33);
            pictureBoxImg.Margin = new Padding(3, 2, 3, 2);
            pictureBoxImg.Name = "pictureBoxImg";
            pictureBoxImg.Size = new Size(88, 76);
            pictureBoxImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImg.TabIndex = 29;
            pictureBoxImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(82, 38, 7);
            label1.Location = new Point(100, 4);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 28;
            label1.Text = "Товар";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(284, 350);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(pictureBoxImg);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InfoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Харектиристики";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Button buttonCancel;
        private Label label10;
        private Label label5;
        private TextBox textBoxCountry;
        private Label label9;
        private Label label7;
        private Label label8;
        private TextBox textBoxWeight;
        private TextBox textBoxPriceSell;
        private Label label2;
        private PictureBox pictureBoxImg;
        private Label label1;
        private Label label6;
        private Label label4;
        private TextBox textBoxComposition;
        private TextBox textBoxType;
        private Label label3;
    }
}