namespace InfosoftAssessment_Villasis.Pages
{
    partial class InventoryPage
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
            equipmentGridView = new DataGridView();
            label2 = new Label();
            equipmentNameTxt = new TextBox();
            label3 = new Label();
            typeCbx = new ComboBox();
            label4 = new Label();
            quantityTxt = new TextBox();
            addBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            searchBarTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)equipmentGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 2;
            label1.Text = "Inventory Page";
            // 
            // equipmentGridView
            // 
            equipmentGridView.AllowUserToAddRows = false;
            equipmentGridView.AllowUserToDeleteRows = false;
            equipmentGridView.BackgroundColor = SystemColors.Control;
            equipmentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            equipmentGridView.Location = new Point(57, 137);
            equipmentGridView.Name = "equipmentGridView";
            equipmentGridView.ReadOnly = true;
            equipmentGridView.RowHeadersWidth = 62;
            equipmentGridView.Size = new Size(770, 224);
            equipmentGridView.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 33);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 10;
            label2.Text = "Equipment Name";
            // 
            // equipmentNameTxt
            // 
            equipmentNameTxt.BorderStyle = BorderStyle.FixedSingle;
            equipmentNameTxt.Location = new Point(201, 27);
            equipmentNameTxt.Name = "equipmentNameTxt";
            equipmentNameTxt.Size = new Size(194, 31);
            equipmentNameTxt.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(460, 29);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 10;
            label3.Text = "Service Type";
            // 
            // typeCbx
            // 
            typeCbx.FormattingEnabled = true;
            typeCbx.Location = new Point(460, 66);
            typeCbx.Name = "typeCbx";
            typeCbx.Size = new Size(272, 33);
            typeCbx.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 113);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 10;
            label4.Text = "Quantity";
            // 
            // quantityTxt
            // 
            quantityTxt.BorderStyle = BorderStyle.FixedSingle;
            quantityTxt.Location = new Point(201, 111);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(194, 31);
            quantityTxt.TabIndex = 11;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.CornflowerBlue;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(57, 582);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(770, 48);
            addBtn.TabIndex = 13;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 82, 85);
            panel1.Controls.Add(typeCbx);
            panel1.Controls.Add(quantityTxt);
            panel1.Controls.Add(equipmentNameTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(57, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 189);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(58, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // searchBarTxt
            // 
            searchBarTxt.BorderStyle = BorderStyle.FixedSingle;
            searchBarTxt.Font = new Font("Segoe UI", 9F);
            searchBarTxt.Location = new Point(105, 100);
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.PlaceholderText = "  search by equipment name";
            searchBarTxt.Size = new Size(333, 31);
            searchBarTxt.TabIndex = 15;
            // 
            // InventoryPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(searchBarTxt);
            Controls.Add(panel1);
            Controls.Add(addBtn);
            Controls.Add(equipmentGridView);
            Controls.Add(label1);
            Name = "InventoryPage";
            Size = new Size(885, 664);
            ((System.ComponentModel.ISupportInitialize)equipmentGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView equipmentGridView;
        private Label label2;
        private TextBox equipmentNameTxt;
        private Label label3;
        private ComboBox typeCbx;
        private Label label4;
        private TextBox quantityTxt;
        private Button addBtn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox searchBarTxt;
    }
}
