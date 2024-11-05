namespace CoffeeApp
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonPay = new Button();
            label1 = new Label();
            labelAllPrice = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 397);
            panel1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(27, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(180, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Продовжити покупки";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPay
            // 
            buttonPay.DialogResult = DialogResult.OK;
            buttonPay.Location = new Point(640, 4);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(94, 29);
            buttonPay.TabIndex = 2;
            buttonPay.Text = "Сплатити";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 10);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "До сплати:";
            // 
            // labelAllPrice
            // 
            labelAllPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAllPrice.ForeColor = Color.Red;
            labelAllPrice.Location = new Point(493, 8);
            labelAllPrice.Name = "labelAllPrice";
            labelAllPrice.Size = new Size(100, 25);
            labelAllPrice.TabIndex = 4;
            labelAllPrice.Text = "1000000000";
            labelAllPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(598, 8);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "грн.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(labelAllPrice);
            groupBox1.Controls.Add(buttonPay);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 401);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 35);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 441);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CartForm";
            Text = "Кошик";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancel;
        private Button buttonPay;
        private Label label1;
        private Label labelAllPrice;
        private Label label2;
        private GroupBox groupBox1;
    }
}