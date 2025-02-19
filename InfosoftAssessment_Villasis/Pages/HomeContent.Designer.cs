namespace InfosoftAssessment_Villasis.Pages
{
    partial class HomeContent
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
            scheduleGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 3;
            label1.Text = "Reports Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 122);
            label2.Name = "label2";
            label2.Size = new Size(321, 32);
            label2.TabIndex = 3;
            label2.Text = "Schedule to Visit this Week";
            // 
            // scheduleGridView
            // 
            scheduleGridView.AllowUserToAddRows = false;
            scheduleGridView.AllowUserToDeleteRows = false;
            scheduleGridView.BackgroundColor = SystemColors.Control;
            scheduleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleGridView.Location = new Point(57, 212);
            scheduleGridView.Name = "scheduleGridView";
            scheduleGridView.ReadOnly = true;
            scheduleGridView.RowHeadersWidth = 62;
            scheduleGridView.Size = new Size(761, 351);
            scheduleGridView.TabIndex = 19;
            // 
            // HomeContent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scheduleGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeContent";
            Size = new Size(885, 664);
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView scheduleGridView;
    }
}
