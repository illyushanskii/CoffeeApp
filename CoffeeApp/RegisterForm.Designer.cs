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
            textBoxPass.Location = new Point(10, 174);
            textBoxPass.MaxLength = 32;
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(282, 27);
            textBoxPass.TabIndex = 0;
            // 
            // textBoxPassCheck
            // 
            textBoxPassCheck.Location = new Point(10, 250);
            textBoxPassCheck.MaxLength = 32;
            textBoxPassCheck.Name = "textBoxPassCheck";
            textBoxPassCheck.PasswordChar = '*';
            textBoxPassCheck.Size = new Size(282, 27);
            textBoxPassCheck.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 56);
            label1.TabIndex = 2;
            label1.Text = "Вітаємо новий адміністратор.\r\nЗареєструйтесь в системі!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCancel.Location = new Point(12, 300);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(124, 42);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Вийти";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonLogIn.Location = new Point(151, 300);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(127, 42);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Увійти";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(10, 151);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 5;
            label2.Text = "Введіть пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(10, 224);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 6;
            label3.Text = "Повторіть пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(10, 87);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 8;
            label4.Text = "Введіть логін:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(10, 110);
            textBoxLogin.MaxLength = 32;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(282, 27);
            textBoxLogin.TabIndex = 7;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 354);
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