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
            textBoxPass = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(10, 67);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 17;
            label4.Text = "Логін:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(10, 88);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(247, 23);
            textBoxLogin.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(10, 122);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 14;
            label2.Text = "Пароль:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = SystemColors.ActiveCaption;
            buttonLogIn.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogIn.Location = new Point(176, 182);
            buttonLogIn.Margin = new Padding(3, 2, 3, 2);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(111, 44);
            buttonLogIn.TabIndex = 13;
            buttonLogIn.Text = "Увійти";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.ActiveCaption;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(12, 182);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(111, 44);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Вийти";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(10, 143);
            textBoxPass.Margin = new Padding(3, 2, 3, 2);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(247, 23);
            textBoxPass.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 22);
            label1.TabIndex = 11;
            label1.Text = "Вхід в меню адміністратора!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(299, 237);
            Controls.Add(label4);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(buttonLogIn);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Controls.Add(textBoxPass);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBoxPass;
        private Label label1;
    }
}