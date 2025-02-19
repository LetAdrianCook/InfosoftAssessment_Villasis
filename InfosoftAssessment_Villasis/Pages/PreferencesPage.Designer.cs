namespace InfosoftAssessment_Villasis.Pages
{
    partial class PreferencesPage
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
            hourlyRate = new TextBox();
            label3 = new Label();
            serviceName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            serviceGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            searchBarTxt = new TextBox();
            label4 = new Label();
            deleteID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)serviceGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(282, 32);
            label1.TabIndex = 1;
            label1.Text = "Setup Preferences Page";
            // 
            // hourlyRate
            // 
            hourlyRate.BorderStyle = BorderStyle.FixedSingle;
            hourlyRate.Font = new Font("Segoe UI", 9F);
            hourlyRate.Location = new Point(88, 356);
            hourlyRate.Name = "hourlyRate";
            hourlyRate.Size = new Size(294, 31);
            hourlyRate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(159, 82, 85);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(88, 304);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 3;
            label3.Text = "Hourly Rate (₱)";
            // 
            // serviceName
            // 
            serviceName.BorderStyle = BorderStyle.FixedSingle;
            serviceName.Font = new Font("Segoe UI", 9F);
            serviceName.Location = new Point(88, 218);
            serviceName.Name = "serviceName";
            serviceName.Size = new Size(294, 31);
            serviceName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(159, 82, 85);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 166);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 3;
            label2.Text = "Service Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 82, 85);
            panel1.Location = new Point(57, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 338);
            panel1.TabIndex = 4;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LimeGreen;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(57, 481);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(356, 65);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.CornflowerBlue;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(57, 552);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(356, 65);
            editBtn.TabIndex = 5;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Crimson;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(439, 552);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(380, 65);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // serviceGridView
            // 
            serviceGridView.AllowUserToAddRows = false;
            serviceGridView.AllowUserToDeleteRows = false;
            serviceGridView.BackgroundColor = SystemColors.Control;
            serviceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceGridView.Location = new Point(439, 127);
            serviceGridView.Name = "serviceGridView";
            serviceGridView.ReadOnly = true;
            serviceGridView.RowHeadersWidth = 62;
            serviceGridView.Size = new Size(380, 342);
            serviceGridView.TabIndex = 8;
            serviceGridView.CellClick += serviceGridView_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(439, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Font = new Font("Segoe UI", 9F);
            searchBarTxt.Location = new Point(486, 90);
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.PlaceholderText = "  search by service name";
            searchBarTxt.Size = new Size(333, 31);
            searchBarTxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(439, 507);
            label4.Name = "label4";
            label4.Size = new Size(239, 25);
            label4.TabIndex = 12;
            label4.Text = "Enter Service ID to delete :";
            // 
            // deleteID
            // 
            deleteID.BorderStyle = BorderStyle.FixedSingle;
            deleteID.Font = new Font("Segoe UI", 9F);
            deleteID.Location = new Point(684, 501);
            deleteID.Name = "deleteID";
            deleteID.Size = new Size(135, 31);
            deleteID.TabIndex = 2;
            // 
            // PreferencesPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(searchBarTxt);
            Controls.Add(serviceGridView);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(deleteID);
            Controls.Add(serviceName);
            Controls.Add(label3);
            Controls.Add(hourlyRate);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "PreferencesPage";
            Size = new Size(885, 664);
            ((System.ComponentModel.ISupportInitialize)serviceGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox hourlyRate;
        private Label label3;
        private TextBox serviceName;
        private Label label2;
        private Panel panel1;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridView serviceGridView;
        private PictureBox pictureBox1;
        private TextBox searchBarTxt;
        private Label label4;
        private TextBox deleteID;
    }
}
