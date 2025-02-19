namespace InfosoftAssessment_Villasis.Pages
{
    partial class ReportsPage
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
            scheduleGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            searchBarTxt = new TextBox();
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
            label1.Size = new Size(165, 32);
            label1.TabIndex = 2;
            label1.Text = "Reports Page";
            // 
            // scheduleGridView
            // 
            scheduleGridView.AllowUserToAddRows = false;
            scheduleGridView.AllowUserToDeleteRows = false;
            scheduleGridView.BackgroundColor = SystemColors.Control;
            scheduleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleGridView.Location = new Point(57, 190);
            scheduleGridView.Name = "scheduleGridView";
            scheduleGridView.ReadOnly = true;
            scheduleGridView.RowHeadersWidth = 62;
            scheduleGridView.Size = new Size(761, 351);
            scheduleGridView.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(59, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Font = new Font("Segoe UI", 9F);
            searchBarTxt.Location = new Point(106, 143);
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.PlaceholderText = "  search by client ID";
            searchBarTxt.Size = new Size(282, 31);
            searchBarTxt.TabIndex = 20;
            // 
            // ReportsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(searchBarTxt);
            Controls.Add(scheduleGridView);
            Controls.Add(label1);
            Name = "ReportsPage";
            Size = new Size(885, 664);
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView scheduleGridView;
        private PictureBox pictureBox1;
        private TextBox searchBarTxt;
    }
}
