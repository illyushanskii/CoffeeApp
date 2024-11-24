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
            panel1.BackColor = Color.Beige;
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 403);
            panel1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.PeachPuff;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = Color.FromArgb(82, 38, 7);
            buttonCancel.Location = new Point(25, 8);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(221, 52);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Продовжити покупки";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonPay
            // 
            buttonPay.BackColor = Color.LawnGreen;
            buttonPay.DialogResult = DialogResult.OK;
            buttonPay.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPay.ForeColor = Color.Brown;
            buttonPay.Location = new Point(637, 8);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(129, 52);
            buttonPay.TabIndex = 2;
            buttonPay.Text = "Сплатити";
            buttonPay.UseVisualStyleBackColor = false;
            buttonPay.Click += buttonPay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(82, 38, 7);
            label1.Location = new Point(363, 24);
            label1.Name = "label1";
            label1.Size = new Size(114, 22);
            label1.TabIndex = 3;
            label1.Text = "До сплати:";
            // 
            // labelAllPrice
            // 
            labelAllPrice.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAllPrice.ForeColor = Color.Red;
            labelAllPrice.Location = new Point(469, 24);
            labelAllPrice.Name = "labelAllPrice";
            labelAllPrice.Size = new Size(101, 25);
            labelAllPrice.TabIndex = 4;
            labelAllPrice.Text = "1000000000";
            labelAllPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(82, 38, 7);
            label2.Location = new Point(565, 27);
            label2.Name = "label2";
            label2.Size = new Size(46, 22);
            label2.TabIndex = 5;
            label2.Text = "грн.";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Beige;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(labelAllPrice);
            groupBox1.Controls.Add(buttonPay);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 371);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 65);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 437);
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