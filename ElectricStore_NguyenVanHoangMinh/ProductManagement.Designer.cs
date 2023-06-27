namespace ElectricStore_NguyenVanHoangMinh
{
    partial class ProductManagement
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
            dataGridView1 = new DataGridView();
            txtProductCodeSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnDelete = new Button();
            txtProductID = new NumericUpDown();
            txtProductPrice = new NumericUpDown();
            txtProductDate = new DateTimePicker();
            cbCate = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductPrice).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtProductCodeSearch
            // 
            txtProductCodeSearch.Location = new Point(525, 196);
            txtProductCodeSearch.Name = "txtProductCodeSearch";
            txtProductCodeSearch.Size = new Size(163, 27);
            txtProductCodeSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(694, 194);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 217);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(119, 214);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(250, 27);
            txtProductName.TabIndex = 4;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(119, 259);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(250, 27);
            txtProductCode.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 262);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 309);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 354);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 9;
            label4.Text = "Date Create";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 400);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 13;
            label6.Text = "Category Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(375, 215);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(80, 27);
            txtProductID.TabIndex = 16;
            txtProductID.Visible = false;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(119, 302);
            txtProductPrice.Maximum = new decimal(new int[] { -64771072, 6, 0, 0 });
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(250, 27);
            txtProductPrice.TabIndex = 17;
            // 
            // txtProductDate
            // 
            txtProductDate.Location = new Point(119, 349);
            txtProductDate.Name = "txtProductDate";
            txtProductDate.Size = new Size(250, 27);
            txtProductDate.TabIndex = 18;
            // 
            // cbCate
            // 
            cbCate.FormattingEnabled = true;
            cbCate.Location = new Point(119, 392);
            cbCate.Name = "cbCate";
            cbCate.Size = new Size(250, 28);
            cbCate.TabIndex = 19;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(694, 309);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(694, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 456);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbCate);
            Controls.Add(txtProductDate);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductID);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtProductCode);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtProductCodeSearch);
            Controls.Add(dataGridView1);
            Name = "ProductManagement";
            Text = "ProductManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtProductCodeSearch;
        private Button btnSearch;
        private Label label1;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnDelete;
        private NumericUpDown txtProductID;
        private NumericUpDown txtProductPrice;
        private DateTimePicker txtProductDate;
        private ComboBox cbCate;
        private Button btnCreate;
        private Button btnUpdate;
    }
}