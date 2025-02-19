namespace InfosoftAssessment_Villasis
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
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            userName = new TextBox();
            passWord = new TextBox();
            label2 = new Label();
            label3 = new Label();
            loginBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(159, 82, 85);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(280, 50);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Alexis Construction";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 82, 85);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 129);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(159, 82, 85);
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(223, 91);
            label4.Name = "label4";
            label4.Size = new Size(372, 25);
            label4.TabIndex = 1;
            label4.Text = "Electrical * Masonry * Carpentry Works * Others";
            // 
            // userName
            // 
            userName.BorderStyle = BorderStyle.FixedSingle;
            userName.Location = new Point(344, 201);
            userName.Name = "userName";
            userName.Size = new Size(150, 31);
            userName.TabIndex = 2;
            // 
            // passWord
            // 
            passWord.BorderStyle = BorderStyle.FixedSingle;
            passWord.Location = new Point(344, 290);
            passWord.Name = "passWord";
            passWord.PasswordChar = '*';
            passWord.Size = new Size(150, 31);
            passWord.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 207);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 3;
            label2.Text = "username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(223, 293);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 3;
            label3.Text = "password :";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(159, 82, 85);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(223, 368);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(334, 51);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passWord);
            Controls.Add(userName);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox userName;
        private TextBox passWord;
        private Label label2;
        private Label label3;
        private Button loginBtn;
        private Label label4;
    }
}
