namespace Hotel.UI
{
    partial class UpdateReservationFrm
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
            NewPhoneNoTxtBox = new TextBox();
            NewLastNameTxtBox = new TextBox();
            NewFirstNameTxtBox = new TextBox();
            NewRoomNoTxtBox = new TextBox();
            UpdateReservationBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 254);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 17;
            label4.Text = "Room no";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 92);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 16;
            label3.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 145);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 15;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 199);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 14;
            label1.Text = "Phone no";
            // 
            // NewPhoneNoTxtBox
            // 
            NewPhoneNoTxtBox.Location = new Point(346, 199);
            NewPhoneNoTxtBox.Name = "NewPhoneNoTxtBox";
            NewPhoneNoTxtBox.Size = new Size(150, 31);
            NewPhoneNoTxtBox.TabIndex = 19;
            // 
            // NewLastNameTxtBox
            // 
            NewLastNameTxtBox.Location = new Point(346, 145);
            NewLastNameTxtBox.Name = "NewLastNameTxtBox";
            NewLastNameTxtBox.Size = new Size(150, 31);
            NewLastNameTxtBox.TabIndex = 20;
            // 
            // NewFirstNameTxtBox
            // 
            NewFirstNameTxtBox.Location = new Point(346, 89);
            NewFirstNameTxtBox.Name = "NewFirstNameTxtBox";
            NewFirstNameTxtBox.Size = new Size(150, 31);
            NewFirstNameTxtBox.TabIndex = 21;
            // 
            // NewRoomNoTxtBox
            // 
            NewRoomNoTxtBox.Location = new Point(346, 251);
            NewRoomNoTxtBox.Name = "NewRoomNoTxtBox";
            NewRoomNoTxtBox.Size = new Size(150, 31);
            NewRoomNoTxtBox.TabIndex = 23;
            // 
            // UpdateReservationBtn
            // 
            UpdateReservationBtn.Location = new Point(346, 335);
            UpdateReservationBtn.Name = "UpdateReservationBtn";
            UpdateReservationBtn.Size = new Size(112, 34);
            UpdateReservationBtn.TabIndex = 24;
            UpdateReservationBtn.Text = "Update";
            UpdateReservationBtn.UseVisualStyleBackColor = true;
            UpdateReservationBtn.Click += UpdateReservationBtn_Click;
            // 
            // UpdateReservationFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateReservationBtn);
            Controls.Add(NewRoomNoTxtBox);
            Controls.Add(NewFirstNameTxtBox);
            Controls.Add(NewLastNameTxtBox);
            Controls.Add(NewPhoneNoTxtBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateReservationFrm";
            Text = "UpdateReservationFrm";
            Load += UpdateReservationFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox NewPhoneNoTxtBox;
        private TextBox NewLastNameTxtBox;
        private TextBox NewFirstNameTxtBox;
        private TextBox NewRoomNoTxtBox;
        private Button UpdateReservationBtn;
    }
}