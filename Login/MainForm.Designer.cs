namespace Login
{
    partial class MainForm
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
            UpdateReservationBtn = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            RemoveReservation = new Button();
            label5 = new Label();
            IdLabel = new Label();
            RoomNoLabel = new Label();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            PhoneNoLabel = new Label();
            SuspendLayout();
            // 
            // UpdateReservationBtn
            // 
            UpdateReservationBtn.Location = new Point(27, 456);
            UpdateReservationBtn.Name = "UpdateReservationBtn";
            UpdateReservationBtn.Size = new Size(112, 34);
            UpdateReservationBtn.TabIndex = 0;
            UpdateReservationBtn.Text = "Update";
            UpdateReservationBtn.UseVisualStyleBackColor = true;
            UpdateReservationBtn.Click += UpdateReservationBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(694, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(226, 379);
            listBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 241);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 6;
            label1.Text = "Phone no";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 187);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 7;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 122);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 8;
            label3.Text = "First name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 306);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 9;
            label4.Text = "Room no";
            // 
            // button1
            // 
            button1.Location = new Point(704, 432);
            button1.Name = "button1";
            button1.Size = new Size(182, 34);
            button1.TabIndex = 10;
            button1.Text = "Add Reservation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddReservationBtn_Click;
            // 
            // RemoveReservation
            // 
            RemoveReservation.Location = new Point(704, 484);
            RemoveReservation.Name = "RemoveReservation";
            RemoveReservation.Size = new Size(182, 34);
            RemoveReservation.TabIndex = 11;
            RemoveReservation.Text = "Remove Reservation";
            RemoveReservation.UseVisualStyleBackColor = true;
            RemoveReservation.Click += RemoveReservation_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 73);
            label5.Name = "label5";
            label5.Size = new Size(28, 25);
            label5.TabIndex = 13;
            label5.Text = "Id";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(126, 73);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(0, 25);
            IdLabel.TabIndex = 18;
            // 
            // RoomNoLabel
            // 
            RoomNoLabel.AutoSize = true;
            RoomNoLabel.Location = new Point(126, 306);
            RoomNoLabel.Name = "RoomNoLabel";
            RoomNoLabel.Size = new Size(0, 25);
            RoomNoLabel.TabIndex = 17;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(126, 122);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(0, 25);
            FirstNameLabel.TabIndex = 16;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(126, 187);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(0, 25);
            LastNameLabel.TabIndex = 15;
            // 
            // PhoneNoLabel
            // 
            PhoneNoLabel.AutoSize = true;
            PhoneNoLabel.Location = new Point(126, 241);
            PhoneNoLabel.Name = "PhoneNoLabel";
            PhoneNoLabel.Size = new Size(0, 25);
            PhoneNoLabel.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 530);
            Controls.Add(IdLabel);
            Controls.Add(RoomNoLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(PhoneNoLabel);
            Controls.Add(label5);
            Controls.Add(RemoveReservation);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(UpdateReservationBtn);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateReservationBtn;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button RemoveReservation;
        private Label label5;
        private Label IdLabel;
        private Label RoomNoLabel;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label PhoneNoLabel;
    }
}