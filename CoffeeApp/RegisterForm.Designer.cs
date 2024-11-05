namespace CoffeeApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            textBoxPass = new TextBox();
            textBoxPassCheck = new TextBox();
            label1 = new Label();
            buttonCancel = new Button();
            buttonLogIn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxLogin = new TextBox();
            SuspendLayout();
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(9, 157);
            textBoxPass.Margin = new Padding(3, 2, 3, 2);
            textBoxPass.MaxLength = 32;
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(247, 23);
            textBoxPass.TabIndex = 0;
            // 
            // textBoxPassCheck
            // 
            textBoxPassCheck.Location = new Point(12, 229);
            textBoxPassCheck.Margin = new Padding(3, 2, 3, 2);
            textBoxPassCheck.MaxLength = 32;
            textBoxPassCheck.Name = "textBoxPassCheck";
            textBoxPassCheck.PasswordChar = '*';
            textBoxPassCheck.Size = new Size(247, 23);
            textBoxPassCheck.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 44);
            label1.TabIndex = 2;
            label1.Text = "Вітаємо новий адміністратор.\r\nЗареєструйтесь в системі!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.ActiveCaption;
            buttonCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(12, 271);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(128, 57);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Вийти";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = SystemColors.ActiveCaption;
            buttonLogIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogIn.Location = new Point(181, 271);
            buttonLogIn.Margin = new Padding(3, 2, 3, 2);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(128, 57);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Увійти";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(9, 136);
            label2.Name = "label2";
            label2.Size = new Size(141, 19);
            label2.TabIndex = 5;
            label2.Text = "Введіть пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 208);
            label3.Name = "label3";
            label3.Size = new Size(160, 19);
            label3.TabIndex = 6;
            label3.Text = "Повторіть пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 8;
            label4.Text = "Введіть логін:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 88);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.MaxLength = 32;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(247, 23);
            textBoxLogin.TabIndex = 7;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(321, 341);
            Controls.Add(label4);
            Controls.Add(textBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonLogIn);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Controls.Add(textBoxPassCheck);
            Controls.Add(textBoxPass);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            Text = "Реєстрація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPass;
        private TextBox textBoxPassCheck;
        private Label label1;
        private Button buttonCancel;
        private Button buttonLogIn;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxLogin;
    }
}