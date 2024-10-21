namespace CoffeeApp
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            label_ID = new Label();
            buttonCancel = new Button();
            buttonAdd = new Button();
            label1 = new Label();
            pictureBoxImg = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxName = new TextBox();
            textBoxPriceBuy = new TextBox();
            textBoxPriceSell = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxWeight = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxCounty = new TextBox();
            label10 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBoxComposition = new ComboBox();
            comboBoxType = new ComboBox();
            textBoxDescription = new TextBox();
            label11 = new Label();
            groupBox1 = new GroupBox();
            label_Pop = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_ID.ForeColor = Color.FromArgb(82, 38, 7);
            label_ID.Location = new Point(8, 11);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(39, 19);
            label_ID.TabIndex = 26;
            label_ID.Text = "ID: 0";
            label_ID.Visible = false;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = Color.FromArgb(82, 38, 7);
            buttonCancel.Location = new Point(0, 315);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(131, 36);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.MouseLeave += buttonCancel_MouseLeave;
            buttonCancel.MouseHover += buttonCancel_MouseHover;
            // 
            // buttonAdd
            // 
            buttonAdd.Enabled = false;
            buttonAdd.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdd.ForeColor = Color.FromArgb(82, 38, 7);
            buttonAdd.Location = new Point(140, 315);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(127, 36);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            buttonAdd.MouseLeave += buttonAdd_MouseLeave;
            buttonAdd.MouseHover += buttonAdd_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(82, 38, 7);
            label1.Location = new Point(104, 7);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 3;
            label1.Text = "Товар";
            // 
            // pictureBoxImg
            // 
            pictureBoxImg.Image = (Image)resources.GetObject("pictureBoxImg.Image");
            pictureBoxImg.Location = new Point(10, 36);
            pictureBoxImg.Margin = new Padding(3, 2, 3, 2);
            pictureBoxImg.Name = "pictureBoxImg";
            pictureBoxImg.Size = new Size(88, 76);
            pictureBoxImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImg.TabIndex = 4;
            pictureBoxImg.TabStop = false;
            pictureBoxImg.Click += pictureBoxImg_Click;
            pictureBoxImg.MouseLeave += pictureBoxImg_MouseLeave;
            pictureBoxImg.MouseMove += pictureBoxImg_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(82, 38, 7);
            label2.Location = new Point(124, 65);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 5;
            label2.Text = "Фото товару";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(82, 38, 7);
            label4.Location = new Point(0, 45);
            label4.Name = "label4";
            label4.Size = new Size(104, 18);
            label4.TabIndex = 7;
            label4.Text = "Ціна закупки:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(82, 38, 7);
            label5.Location = new Point(0, 75);
            label5.Name = "label5";
            label5.Size = new Size(110, 18);
            label5.TabIndex = 8;
            label5.Text = "Ціна продажу:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(82, 38, 7);
            label6.Location = new Point(0, 105);
            label6.Name = "label6";
            label6.Size = new Size(79, 18);
            label6.TabIndex = 9;
            label6.Text = "Кількість:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.FromArgb(82, 38, 7);
            label7.Location = new Point(0, 135);
            label7.Name = "label7";
            label7.Size = new Size(92, 18);
            label7.TabIndex = 10;
            label7.Text = "Маса нетто:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(64, 10);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(205, 23);
            textBoxName.TabIndex = 11;
            // 
            // textBoxPriceBuy
            // 
            textBoxPriceBuy.Location = new Point(112, 40);
            textBoxPriceBuy.Margin = new Padding(3, 2, 3, 2);
            textBoxPriceBuy.Name = "textBoxPriceBuy";
            textBoxPriceBuy.Size = new Size(157, 23);
            textBoxPriceBuy.TabIndex = 12;
            // 
            // textBoxPriceSell
            // 
            textBoxPriceSell.Location = new Point(119, 70);
            textBoxPriceSell.Margin = new Padding(3, 2, 3, 2);
            textBoxPriceSell.Name = "textBoxPriceSell";
            textBoxPriceSell.Size = new Size(150, 23);
            textBoxPriceSell.TabIndex = 13;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(84, 100);
            textBoxQuantity.Margin = new Padding(3, 2, 3, 2);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(185, 23);
            textBoxQuantity.TabIndex = 14;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(94, 130);
            textBoxWeight.Margin = new Padding(3, 2, 3, 2);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(175, 23);
            textBoxWeight.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.FromArgb(82, 38, 7);
            label8.Location = new Point(0, 165);
            label8.Name = "label8";
            label8.Size = new Size(77, 18);
            label8.TabIndex = 16;
            label8.Text = "Тип кави:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.FromArgb(82, 38, 7);
            label9.Location = new Point(0, 193);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 18;
            label9.Text = "Країна-виробник:";
            // 
            // textBoxCounty
            // 
            textBoxCounty.Location = new Point(139, 190);
            textBoxCounty.Margin = new Padding(3, 2, 3, 2);
            textBoxCounty.Name = "textBoxCounty";
            textBoxCounty.Size = new Size(130, 23);
            textBoxCounty.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.FromArgb(82, 38, 7);
            label10.Location = new Point(2, 223);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 20;
            label10.Text = "Склад кави:";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // comboBoxComposition
            // 
            comboBoxComposition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComposition.FormattingEnabled = true;
            comboBoxComposition.Items.AddRange(new object[] { "Арабіка", "Купаж", "Робуста", "Ліберіка", "Ексцельса" });
            comboBoxComposition.Location = new Point(102, 220);
            comboBoxComposition.Margin = new Padding(3, 2, 3, 2);
            comboBoxComposition.Name = "comboBoxComposition";
            comboBoxComposition.Size = new Size(167, 23);
            comboBoxComposition.TabIndex = 21;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "У зернах", "У капсулах", "Дріп-кава", "Кавовий напій", "Мелена ", "Розчинна", "Цикорій" });
            comboBoxType.Location = new Point(84, 160);
            comboBoxType.Margin = new Padding(3, 2, 3, 2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(185, 23);
            comboBoxType.TabIndex = 22;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(59, 248);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(210, 56);
            textBoxDescription.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.FromArgb(82, 38, 7);
            label11.Location = new Point(2, 248);
            label11.Name = "label11";
            label11.Size = new Size(50, 18);
            label11.TabIndex = 23;
            label11.Text = "Опис:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(246, 221, 199);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxComposition);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxCounty);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxPriceBuy);
            groupBox1.Controls.Add(textBoxWeight);
            groupBox1.Controls.Add(textBoxPriceSell);
            groupBox1.Controls.Add(textBoxQuantity);
            groupBox1.Location = new Point(8, 116);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(277, 358);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // label_Pop
            // 
            label_Pop.AutoSize = true;
            label_Pop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_Pop.ForeColor = Color.FromArgb(82, 38, 7);
            label_Pop.Location = new Point(221, 11);
            label_Pop.Name = "label_Pop";
            label_Pop.Size = new Size(54, 19);
            label_Pop.TabIndex = 27;
            label_Pop.Text = "Поп: 0";
            label_Pop.Visible = false;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 221, 199);
            ClientSize = new Size(284, 474);
            Controls.Add(label_Pop);
            Controls.Add(label_ID);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(pictureBoxImg);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddForm";
            Text = "Додати товар";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonAdd;
        private Label label1;
        private PictureBox pictureBoxImg;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxName;
        private TextBox textBoxPriceBuy;
        private TextBox textBoxPriceSell;
        private TextBox textBoxQuantity;
        private TextBox textBoxWeight;
        private Label label8;
        private Label label9;
        private TextBox textBoxCounty;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBoxComposition;
        private ComboBox comboBoxType;
        private TextBox textBoxDescription;
        private Label label11;
        private GroupBox groupBox1;
        private Label label_Pop;
        private Label label_ID;
    }
}