namespace InfosoftAssessment_Villasis.Pages
{
    partial class ClientPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            addBtn = new Button();
            firstName = new TextBox();
            birthDate = new DateTimePicker();
            label2 = new Label();
            middleName = new TextBox();
            label3 = new Label();
            lastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            editBtn = new Button();
            clientGridView = new DataGridView();
            maleRbtn = new RadioButton();
            femaleRbtn = new RadioButton();
            searchBarTxt = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)clientGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 0;
            label1.Text = "Client Page";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LimeGreen;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(475, 325);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(150, 41);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // firstName
            // 
            firstName.BorderStyle = BorderStyle.FixedSingle;
            firstName.Location = new Point(77, 170);
            firstName.Name = "firstName";
            firstName.Size = new Size(150, 31);
            firstName.TabIndex = 2;
            // 
            // birthDate
            // 
            birthDate.Location = new Point(77, 266);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(300, 31);
            birthDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(159, 82, 85);
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 128);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // middleName
            // 
            middleName.BorderStyle = BorderStyle.FixedSingle;
            middleName.Location = new Point(272, 170);
            middleName.Name = "middleName";
            middleName.Size = new Size(150, 31);
            middleName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(159, 82, 85);
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(272, 128);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 5;
            label3.Text = "Middle Name";
            // 
            // lastName
            // 
            lastName.BorderStyle = BorderStyle.FixedSingle;
            lastName.Location = new Point(475, 170);
            lastName.Name = "lastName";
            lastName.Size = new Size(150, 31);
            lastName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(159, 82, 85);
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(475, 128);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(159, 82, 85);
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(674, 128);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 5;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(159, 82, 85);
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(77, 227);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 6;
            label6.Text = "Date of Birth";
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.CornflowerBlue;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(673, 325);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(150, 41);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // clientGridView
            // 
            clientGridView.AllowUserToAddRows = false;
            clientGridView.AllowUserToDeleteRows = false;
            clientGridView.BackgroundColor = SystemColors.Control;
            clientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientGridView.Location = new Point(57, 377);
            clientGridView.Name = "clientGridView";
            clientGridView.ReadOnly = true;
            clientGridView.RowHeadersWidth = 62;
            clientGridView.Size = new Size(766, 260);
            clientGridView.TabIndex = 7;
            clientGridView.CellClick += clientGridView_CellClick;
            // 
            // maleRbtn
            // 
            maleRbtn.AutoSize = true;
            maleRbtn.BackColor = Color.FromArgb(159, 82, 85);
            maleRbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            maleRbtn.ForeColor = Color.White;
            maleRbtn.Location = new Point(682, 170);
            maleRbtn.Name = "maleRbtn";
            maleRbtn.Size = new Size(78, 29);
            maleRbtn.TabIndex = 8;
            maleRbtn.TabStop = true;
            maleRbtn.Text = "Male";
            maleRbtn.UseVisualStyleBackColor = false;
            // 
            // femaleRbtn
            // 
            femaleRbtn.AutoSize = true;
            femaleRbtn.BackColor = Color.FromArgb(159, 82, 85);
            femaleRbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            femaleRbtn.ForeColor = Color.White;
            femaleRbtn.Location = new Point(682, 205);
            femaleRbtn.Name = "femaleRbtn";
            femaleRbtn.Size = new Size(96, 29);
            femaleRbtn.TabIndex = 8;
            femaleRbtn.TabStop = true;
            femaleRbtn.Text = "Female";
            femaleRbtn.UseVisualStyleBackColor = false;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Location = new Point(93, 335);
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.PlaceholderText = "  search by last name";
            searchBarTxt.Size = new Size(191, 31);
            searchBarTxt.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(57, 336);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 82, 85);
            panel1.Location = new Point(57, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 209);
            panel1.TabIndex = 10;
            // 
            // ClientPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(editBtn);
            Controls.Add(pictureBox1);
            Controls.Add(femaleRbtn);
            Controls.Add(maleRbtn);
            Controls.Add(clientGridView);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(birthDate);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(searchBarTxt);
            Controls.Add(firstName);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ClientPage";
            Size = new Size(885, 664);
            ((System.ComponentModel.ISupportInitialize)clientGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addBtn;
        private TextBox firstName;
        private DateTimePicker birthDate;
        private Label label2;
        private TextBox middleName;
        private Label label3;
        private TextBox lastName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button editBtn;
        private DataGridView clientGridView;
        private RadioButton maleRbtn;
        private RadioButton femaleRbtn;
        private TextBox searchBarTxt;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
