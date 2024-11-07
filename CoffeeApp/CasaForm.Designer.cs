namespace CoffeeApp
{
    partial class CasaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasaForm));
            panel1 = new Panel();
            labelCosts = new Label();
            buttonCancel = new Button();
            labelCasa = new Label();
            groupBox1 = new GroupBox();
            labelIncome = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 340);
            panel1.TabIndex = 7;
            // 
            // labelCosts
            // 
            labelCosts.AutoSize = true;
            labelCosts.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelCosts.ForeColor = Color.Red;
            labelCosts.Location = new Point(3, 44);
            labelCosts.Name = "labelCosts";
            labelCosts.Size = new Size(353, 25);
            labelCosts.TabIndex = 5;
            labelCosts.Text = "Витрати на  товари: 1000000000 грн.";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCancel.Location = new Point(691, 31);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(136, 48);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Закрити";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelCasa
            // 
            labelCasa.AutoSize = true;
            labelCasa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelCasa.ForeColor = Color.Blue;
            labelCasa.Location = new Point(3, 9);
            labelCasa.Name = "labelCasa";
            labelCasa.Size = new Size(295, 25);
            labelCasa.TabIndex = 4;
            labelCasa.Text = "Каса загалом: 1000000000 грн.";
            labelCasa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelIncome);
            groupBox1.Controls.Add(labelCosts);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(labelCasa);
            groupBox1.Location = new Point(1, 344);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(881, 108);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelIncome.ForeColor = Color.Green;
            labelIncome.Location = new Point(3, 79);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(218, 25);
            labelIncome.TabIndex = 6;
            labelIncome.Text = "Дохід: 100000000 грн.";
            // 
            // CasaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 454);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CasaForm";
            Text = "Каса";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCosts;
        private Button buttonCancel;
        private Label labelCasa;
        private GroupBox groupBox1;
        private Label labelIncome;
    }
}