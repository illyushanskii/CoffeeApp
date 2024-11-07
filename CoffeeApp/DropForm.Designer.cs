namespace CoffeeApp
{
    partial class DropForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropForm));
            label1 = new Label();
            button1 = new Button();
            confirm = new Button();
            boxAll = new CheckBox();
            BoxAdmin = new CheckBox();
            boxProducts = new CheckBox();
            boxCasa = new CheckBox();
            boxDeletedProducts = new CheckBox();
            boxLoginHistory = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(396, 28);
            label1.TabIndex = 0;
            label1.Text = "Оберіть ті дані, які потрібно видалити!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.Location = new Point(15, 285);
            button1.Name = "button1";
            button1.Size = new Size(142, 45);
            button1.TabIndex = 1;
            button1.Text = "Скасувати";
            button1.UseVisualStyleBackColor = true;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // confirm
            // 
            confirm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            confirm.ForeColor = Color.FromArgb(192, 0, 0);
            confirm.Location = new Point(262, 285);
            confirm.Name = "confirm";
            confirm.Size = new Size(142, 45);
            confirm.TabIndex = 2;
            confirm.Text = "Підтвердити";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            confirm.MouseEnter += confirm_MouseEnter;
            confirm.MouseLeave += confirm_MouseLeave;
            // 
            // boxAll
            // 
            boxAll.AutoSize = true;
            boxAll.Font = new Font("Segoe UI", 12F);
            boxAll.Location = new Point(12, 51);
            boxAll.Name = "boxAll";
            boxAll.Size = new Size(146, 32);
            boxAll.TabIndex = 3;
            boxAll.Text = "Вибрати все";
            boxAll.UseVisualStyleBackColor = true;
            boxAll.CheckedChanged += BoxAll_CheckedChanged;
            // 
            // BoxAdmin
            // 
            BoxAdmin.AutoSize = true;
            BoxAdmin.FlatAppearance.BorderSize = 10;
            BoxAdmin.Font = new Font("Segoe UI", 12F);
            BoxAdmin.Location = new Point(12, 89);
            BoxAdmin.Name = "BoxAdmin";
            BoxAdmin.Size = new Size(216, 32);
            BoxAdmin.TabIndex = 4;
            BoxAdmin.Text = "Вхід Адміністратора";
            BoxAdmin.UseVisualStyleBackColor = true;
            BoxAdmin.CheckedChanged += BoxAdmin_CheckedChanged;
            // 
            // boxProducts
            // 
            boxProducts.AutoSize = true;
            boxProducts.Font = new Font("Segoe UI", 12F);
            boxProducts.Location = new Point(12, 165);
            boxProducts.Name = "boxProducts";
            boxProducts.Size = new Size(101, 32);
            boxProducts.TabIndex = 5;
            boxProducts.Text = "Товари";
            boxProducts.UseVisualStyleBackColor = true;
            boxProducts.CheckedChanged += boxProducts_CheckedChanged;
            // 
            // boxCasa
            // 
            boxCasa.AutoSize = true;
            boxCasa.Font = new Font("Segoe UI", 12F);
            boxCasa.Location = new Point(12, 237);
            boxCasa.Name = "boxCasa";
            boxCasa.Size = new Size(75, 32);
            boxCasa.TabIndex = 6;
            boxCasa.Text = "Каса";
            boxCasa.UseVisualStyleBackColor = true;
            // 
            // boxDeletedProducts
            // 
            boxDeletedProducts.AutoSize = true;
            boxDeletedProducts.Font = new Font("Segoe UI", 12F);
            boxDeletedProducts.Location = new Point(12, 199);
            boxDeletedProducts.Name = "boxDeletedProducts";
            boxDeletedProducts.Size = new Size(186, 32);
            boxDeletedProducts.TabIndex = 7;
            boxDeletedProducts.Text = "Видалені товари";
            boxDeletedProducts.UseVisualStyleBackColor = true;
            // 
            // boxLoginHistory
            // 
            boxLoginHistory.AutoSize = true;
            boxLoginHistory.Font = new Font("Segoe UI", 12F);
            boxLoginHistory.Location = new Point(12, 127);
            boxLoginHistory.Name = "boxLoginHistory";
            boxLoginHistory.Size = new Size(164, 32);
            boxLoginHistory.TabIndex = 8;
            boxLoginHistory.Text = "Журнал входу";
            boxLoginHistory.UseVisualStyleBackColor = true;
            // 
            // DropForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(416, 338);
            Controls.Add(boxLoginHistory);
            Controls.Add(boxDeletedProducts);
            Controls.Add(boxCasa);
            Controls.Add(boxProducts);
            Controls.Add(BoxAdmin);
            Controls.Add(boxAll);
            Controls.Add(confirm);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DropForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Видалення БД";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Button button1;
        private Button confirm;
        private CheckBox boxAll;
        private CheckBox BoxAdmin;
        private CheckBox boxProducts;
        private CheckBox boxCasa;
        private CheckBox boxDeletedProducts;
        private CheckBox boxLoginHistory;
    }
}