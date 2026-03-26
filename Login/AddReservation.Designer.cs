namespace Hotel.UI
{
    partial class AddReservation
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            RoomNoTxtBox = new TextBox();
            FnameTxtBox = new TextBox();
            LnameTxtBox = new TextBox();
            PhoneNoTxtBox = new TextBox();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 245);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 17;
            label4.Text = "Room no";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 61);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 16;
            label3.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 126);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 15;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 180);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 14;
            label1.Text = "Phone no";
            // 
            // RoomNoTxtBox
            // 
            RoomNoTxtBox.Location = new Point(317, 239);
            RoomNoTxtBox.Name = "RoomNoTxtBox";
            RoomNoTxtBox.Size = new Size(150, 31);
            RoomNoTxtBox.TabIndex = 13;
            // 
            // FnameTxtBox
            // 
            FnameTxtBox.Location = new Point(317, 58);
            FnameTxtBox.Name = "FnameTxtBox";
            FnameTxtBox.Size = new Size(150, 31);
            FnameTxtBox.TabIndex = 12;
            // 
            // LnameTxtBox
            // 
            LnameTxtBox.Location = new Point(317, 120);
            LnameTxtBox.Name = "LnameTxtBox";
            LnameTxtBox.Size = new Size(150, 31);
            LnameTxtBox.TabIndex = 11;
            // 
            // PhoneNoTxtBox
            // 
            PhoneNoTxtBox.Location = new Point(317, 174);
            PhoneNoTxtBox.Name = "PhoneNoTxtBox";
            PhoneNoTxtBox.Size = new Size(150, 31);
            PhoneNoTxtBox.TabIndex = 10;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(317, 313);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(112, 34);
            AddBtn.TabIndex = 18;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddReservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 423);
            Controls.Add(AddBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RoomNoTxtBox);
            Controls.Add(FnameTxtBox);
            Controls.Add(LnameTxtBox);
            Controls.Add(PhoneNoTxtBox);
            Name = "AddReservation";
            Text = "AddReservation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox RoomNoTxtBox;
        private TextBox FnameTxtBox;
        private TextBox LnameTxtBox;
        private TextBox PhoneNoTxtBox;
        private Button AddBtn;
    }
}