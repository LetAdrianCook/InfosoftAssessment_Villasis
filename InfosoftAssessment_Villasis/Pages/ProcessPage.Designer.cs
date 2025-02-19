namespace InfosoftAssessment_Villasis.Pages
{
    partial class ProcessPage
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
            panel1 = new Panel();
            totalAmount = new TextBox();
            receivedAmountTxt = new TextBox();
            billingIDTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            payBtn = new Button();
            scheduleGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            searchBarTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 1;
            label1.Text = "Process Page";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 82, 85);
            panel1.Controls.Add(totalAmount);
            panel1.Controls.Add(receivedAmountTxt);
            panel1.Controls.Add(billingIDTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(57, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 356);
            panel1.TabIndex = 16;
            // 
            // totalAmount
            // 
            totalAmount.BorderStyle = BorderStyle.FixedSingle;
            totalAmount.Location = new Point(201, 85);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(165, 31);
            totalAmount.TabIndex = 11;
            // 
            // receivedAmountTxt
            // 
            receivedAmountTxt.BorderStyle = BorderStyle.FixedSingle;
            receivedAmountTxt.Location = new Point(201, 285);
            receivedAmountTxt.Name = "receivedAmountTxt";
            receivedAmountTxt.Size = new Size(165, 31);
            receivedAmountTxt.TabIndex = 11;
            // 
            // billingIDTxt
            // 
            billingIDTxt.BorderStyle = BorderStyle.FixedSingle;
            billingIDTxt.Location = new Point(201, 27);
            billingIDTxt.Name = "billingIDTxt";
            billingIDTxt.Size = new Size(165, 31);
            billingIDTxt.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 87);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 10;
            label5.Text = "Total Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 287);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 10;
            label4.Text = "Received Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 33);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 10;
            label2.Text = "Bill ID";
            // 
            // payBtn
            // 
            payBtn.BackColor = Color.CornflowerBlue;
            payBtn.FlatStyle = FlatStyle.Flat;
            payBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payBtn.ForeColor = Color.White;
            payBtn.Location = new Point(57, 480);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(405, 90);
            payBtn.TabIndex = 15;
            payBtn.Text = "Pay Bill";
            payBtn.UseVisualStyleBackColor = false;
            payBtn.Click += payBtn_Click;
            // 
            // scheduleGridView
            // 
            scheduleGridView.AllowUserToAddRows = false;
            scheduleGridView.AllowUserToDeleteRows = false;
            scheduleGridView.BackgroundColor = SystemColors.Control;
            scheduleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleGridView.Location = new Point(504, 153);
            scheduleGridView.Name = "scheduleGridView";
            scheduleGridView.ReadOnly = true;
            scheduleGridView.RowHeadersWidth = 62;
            scheduleGridView.Size = new Size(327, 417);
            scheduleGridView.TabIndex = 17;
            scheduleGridView.CellClick += scheduleGridView_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(502, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Font = new Font("Segoe UI", 9F);
            searchBarTxt.Location = new Point(549, 105);
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.PlaceholderText = "  search by bill ID";
            searchBarTxt.Size = new Size(282, 31);
            searchBarTxt.TabIndex = 18;
            // 
            // ProcessPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(searchBarTxt);
            Controls.Add(scheduleGridView);
            Controls.Add(panel1);
            Controls.Add(payBtn);
            Controls.Add(label1);
            Name = "ProcessPage";
            Size = new Size(885, 664);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox totalAmount;
        private TextBox receivedAmountTxt;
        private TextBox billingIDTxt;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button payBtn;
        private DataGridView scheduleGridView;
        private PictureBox pictureBox1;
        private TextBox searchBarTxt;
    }
}
