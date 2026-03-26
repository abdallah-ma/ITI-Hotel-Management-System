namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            Username = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Location = new Point(299, 133);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new Size(150, 31);
            UsernameTxtBox.TabIndex = 0;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(299, 215);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(150, 31);
            PasswordTxtBox.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(317, 269);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(112, 34);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(299, 105);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 187);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UsernameTxtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTxtBox;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private Label Username;
        private Label label2;
    }
}
