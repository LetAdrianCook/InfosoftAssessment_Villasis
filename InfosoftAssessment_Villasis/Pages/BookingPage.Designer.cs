namespace InfosoftAssessment_Villasis.Pages
{
    partial class BookingPage
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
            label2 = new Label();
            clientGridView = new DataGridView();
            serviceGridView = new DataGridView();
            scheduledVisit = new DateTimePicker();
            pictureBox1 = new PictureBox();
            searchBarTxt = new TextBox();
            searchBarTxt2 = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            selectedGridView = new DataGridView();
            selectedService = new TextBox();
            clientName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            selectedClient = new TextBox();
            addServicebtn = new Button();
            removeServicebtn = new Button();
            scheduleBtn = new Button();
            label7 = new Label();
            totalAmount = new TextBox();
            label8 = new Label();
            hoursRendered = new Label();
            hourRendered = new TextBox();
            ((System.ComponentModel.ISupportInitialize)clientGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 1;
            label1.Text = "Booking Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 42);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 2;
            label2.Text = "Schedule Client Visits";
            // 
            // clientGridView
            // 
            clientGridView.AllowUserToAddRows = false;
            clientGridView.AllowUserToDeleteRows = false;
            clientGridView.BackgroundColor = SystemColors.Control;
            clientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientGridView.Location = new Point(57, 123);
            clientGridView.Name = "clientGridView";
            clientGridView.ReadOnly = true;
            clientGridView.RowHeadersWidth = 62;
            clientGridView.Size = new Size(367, 206);
            clientGridView.TabIndex = 8;
            clientGridView.CellClick += clientGridView_CellClick;
            // 
            // serviceGridView
            // 
            serviceGridView.AllowUserToAddRows = false;
            serviceGridView.AllowUserToDeleteRows = false;
            serviceGridView.BackgroundColor = SystemColors.Control;
            serviceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceGridView.Location = new Point(483, 123);
            serviceGridView.Name = "serviceGridView";
            serviceGridView.ReadOnly = true;
            serviceGridView.RowHeadersWidth = 62;
            serviceGridView.Size = new Size(344, 206);
            serviceGridView.TabIndex = 8;
            serviceGridView.CellClick += serviceGridView_CellClick;
            // 
            // scheduledVisit
            // 
            scheduledVisit.Location = new Point(57, 419);
            scheduledVisit.Name = "scheduledVisit";
            scheduledVisit.Size = new Size(364, 31);
            scheduledVisit.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(54, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Location = new Point(90, 82);
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.PlaceholderText = "  search by last name";
            searchBarTxt.Size = new Size(334, 31);
            searchBarTxt.TabIndex = 10;
            // 
            // searchBarTxt2
            // 
            searchBarTxt2.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt2.Location = new Point(519, 82);
            searchBarTxt2.Name = "searchBarTxt2";
            searchBarTxt2.PlaceholderText = "  search by service name";
            searchBarTxt2.Size = new Size(308, 31);
            searchBarTxt2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_search_30;
            pictureBox2.Location = new Point(483, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 459);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Selected Client";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(483, 342);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 2;
            label4.Text = "Selected Services";
            // 
            // selectedGridView
            // 
            selectedGridView.AllowUserToAddRows = false;
            selectedGridView.AllowUserToDeleteRows = false;
            selectedGridView.BackgroundColor = SystemColors.Control;
            selectedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedGridView.Location = new Point(483, 422);
            selectedGridView.Name = "selectedGridView";
            selectedGridView.ReadOnly = true;
            selectedGridView.RowHeadersWidth = 62;
            selectedGridView.Size = new Size(344, 152);
            selectedGridView.TabIndex = 8;
            selectedGridView.CellClick += selectedGridView_CellClick;
            // 
            // selectedService
            // 
            selectedService.BorderStyle = BorderStyle.FixedSingle;
            selectedService.Enabled = false;
            selectedService.Location = new Point(648, 337);
            selectedService.Name = "selectedService";
            selectedService.Size = new Size(179, 31);
            selectedService.TabIndex = 12;
            // 
            // clientName
            // 
            clientName.BorderStyle = BorderStyle.FixedSingle;
            clientName.Enabled = false;
            clientName.Location = new Point(140, 551);
            clientName.Name = "clientName";
            clientName.Size = new Size(284, 31);
            clientName.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 557);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 2;
            label5.Text = "Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 503);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 2;
            label6.Text = "Client ID :";
            // 
            // selectedClient
            // 
            selectedClient.BorderStyle = BorderStyle.FixedSingle;
            selectedClient.Enabled = false;
            selectedClient.Location = new Point(170, 497);
            selectedClient.Name = "selectedClient";
            selectedClient.Size = new Size(254, 31);
            selectedClient.TabIndex = 12;
            // 
            // addServicebtn
            // 
            addServicebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addServicebtn.Location = new Point(741, 374);
            addServicebtn.Name = "addServicebtn";
            addServicebtn.Size = new Size(40, 34);
            addServicebtn.TabIndex = 13;
            addServicebtn.Text = "+";
            addServicebtn.UseVisualStyleBackColor = true;
            addServicebtn.Click += addServicebtn_Click;
            // 
            // removeServicebtn
            // 
            removeServicebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeServicebtn.Location = new Point(787, 374);
            removeServicebtn.Name = "removeServicebtn";
            removeServicebtn.Size = new Size(40, 34);
            removeServicebtn.TabIndex = 13;
            removeServicebtn.Text = "-";
            removeServicebtn.UseVisualStyleBackColor = true;
            removeServicebtn.Click += removeServicebtn_Click;
            // 
            // scheduleBtn
            // 
            scheduleBtn.BackColor = Color.CornflowerBlue;
            scheduleBtn.FlatStyle = FlatStyle.Flat;
            scheduleBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scheduleBtn.ForeColor = Color.White;
            scheduleBtn.Location = new Point(54, 594);
            scheduleBtn.Name = "scheduleBtn";
            scheduleBtn.Size = new Size(370, 43);
            scheduleBtn.TabIndex = 14;
            scheduleBtn.Text = "Schedule";
            scheduleBtn.UseVisualStyleBackColor = false;
            scheduleBtn.Click += scheduleBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(483, 603);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 2;
            label7.Text = "Total Amount :";
            // 
            // totalAmount
            // 
            totalAmount.BorderStyle = BorderStyle.FixedSingle;
            totalAmount.Enabled = false;
            totalAmount.Location = new Point(627, 601);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(200, 31);
            totalAmount.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(57, 386);
            label8.Name = "label8";
            label8.Size = new Size(145, 25);
            label8.TabIndex = 2;
            label8.Text = "Select Schedule";
            // 
            // hoursRendered
            // 
            hoursRendered.AutoSize = true;
            hoursRendered.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoursRendered.Location = new Point(483, 377);
            hoursRendered.Name = "hoursRendered";
            hoursRendered.Size = new Size(147, 25);
            hoursRendered.TabIndex = 2;
            hoursRendered.Text = "Hours to render";
            // 
            // hourRendered
            // 
            hourRendered.BorderStyle = BorderStyle.FixedSingle;
            hourRendered.Location = new Point(648, 377);
            hourRendered.Name = "hourRendered";
            hourRendered.Size = new Size(87, 31);
            hourRendered.TabIndex = 12;
            // 
            // BookingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scheduleBtn);
            Controls.Add(removeServicebtn);
            Controls.Add(addServicebtn);
            Controls.Add(selectedClient);
            Controls.Add(clientName);
            Controls.Add(totalAmount);
            Controls.Add(hourRendered);
            Controls.Add(selectedService);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(searchBarTxt2);
            Controls.Add(searchBarTxt);
            Controls.Add(scheduledVisit);
            Controls.Add(selectedGridView);
            Controls.Add(serviceGridView);
            Controls.Add(clientGridView);
            Controls.Add(label7);
            Controls.Add(hoursRendered);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookingPage";
            Size = new Size(885, 664);
            ((System.ComponentModel.ISupportInitialize)clientGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView clientGridView;
        private DataGridView serviceGridView;
        private DateTimePicker scheduledVisit;
        private PictureBox pictureBox1;
        private TextBox searchBarTxt;
        private TextBox searchBarTxt2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private DataGridView selectedGridView;
        private TextBox selectedService;
        private TextBox clientName;
        private Label label5;
        private Label label6;
        private TextBox selectedClient;
        private Button addServicebtn;
        private Button removeServicebtn;
        private Button scheduleBtn;
        private Label label7;
        private TextBox totalAmount;
        private Label label8;
        private Label hoursRendered;
        private TextBox hourRendered;
    }
}
