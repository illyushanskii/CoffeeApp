namespace CoffeeApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label4 = new Label();
            textBoxLogin = new TextBox();
            label2 = new Label();
            buttonLogIn = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            textBoxPass = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 65);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 17;
            label4.Text = "Введіть логін:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 88);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(282, 27);
            textBoxLogin.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 14;
            label2.Text = "Введіть пароль:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonLogIn.Location = new Point(151, 205);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(127, 42);
            buttonLogIn.TabIndex = 13;
            buttonLogIn.Text = "Увійти";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCancel.Location = new Point(12, 205);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(124, 42);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Вийти";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 11;
            label1.Text = "Вхід в меню адміністратора!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(12, 152);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(282, 27);
            textBoxPass.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 263);
            Controls.Add(label4);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(buttonLogIn);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Controls.Add(textBoxPass);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Вхід";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxLogin;
        private Label label2;
        private Button buttonLogIn;
        private Button buttonCancel;
        private Label label1;
        private TextBox textBoxPass;
    }
}