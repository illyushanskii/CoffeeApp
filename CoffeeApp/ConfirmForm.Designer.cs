namespace CoffeeApp
{
    partial class ConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmForm));
            label1 = new Label();
            button1 = new Button();
            confirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 63);
            label1.TabIndex = 0;
            label1.Text = "Ви підтверджуєте скидання бази даних? \r\n(Вся інформація зникне)\r\n\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.Location = new Point(12, 72);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 1;
            button1.Text = "Скасувати";
            button1.UseVisualStyleBackColor = true;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // confirm
            // 
            confirm.DialogResult = DialogResult.OK;
            confirm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            confirm.ForeColor = Color.FromArgb(192, 0, 0);
            confirm.Location = new Point(228, 72);
            confirm.Margin = new Padding(3, 2, 3, 2);
            confirm.Name = "confirm";
            confirm.Size = new Size(124, 34);
            confirm.TabIndex = 2;
            confirm.Text = "Підтвердити";
            confirm.UseVisualStyleBackColor = true;
            confirm.MouseEnter += confirm_MouseEnter;
            confirm.MouseLeave += confirm_MouseLeave;
            // 
            // ConfirmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(364, 117);
            Controls.Add(confirm);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Підтвердження";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button confirm;
    }
}