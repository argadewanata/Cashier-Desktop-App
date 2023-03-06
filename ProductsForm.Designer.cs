namespace Cashier_Dekstop_App
{
    partial class ProductsForm
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
            lbl_ProductID = new Label();
            lbl_ProductName = new Label();
            txtbox_ProductID = new TextBox();
            txtbox_ProductName = new TextBox();
            btn_Save = new Button();
            btn_Update = new Button();
            dataGridView1 = new DataGridView();
            btn_Delete = new Button();
            lbl_ProductPrice = new Label();
            txtbox_ProductPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_ProductID
            // 
            lbl_ProductID.AutoSize = true;
            lbl_ProductID.Location = new Point(167, 15);
            lbl_ProductID.Name = "lbl_ProductID";
            lbl_ProductID.Size = new Size(60, 15);
            lbl_ProductID.TabIndex = 0;
            lbl_ProductID.Text = "ProductID";
            lbl_ProductID.Click += lbl_Product_Click;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.Location = new Point(149, 51);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(84, 15);
            lbl_ProductName.TabIndex = 1;
            lbl_ProductName.Text = "Product Name";
            lbl_ProductName.Click += lbl_ProductName_Click;
            // 
            // txtbox_ProductID
            // 
            txtbox_ProductID.Location = new Point(233, 12);
            txtbox_ProductID.Name = "txtbox_ProductID";
            txtbox_ProductID.Size = new Size(126, 23);
            txtbox_ProductID.TabIndex = 0;
            txtbox_ProductID.TextChanged += txtbox_ProductID_TextChanged;
            // 
            // txtbox_ProductName
            // 
            txtbox_ProductName.Location = new Point(233, 48);
            txtbox_ProductName.Name = "txtbox_ProductName";
            txtbox_ProductName.Size = new Size(126, 23);
            txtbox_ProductName.TabIndex = 1;
            txtbox_ProductName.TextChanged += textBox2_TextChanged;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(143, 111);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(242, 111);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 4;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(553, 232);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(333, 111);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(106, 23);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete Product";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click_1;
            // 
            // lbl_ProductPrice
            // 
            lbl_ProductPrice.AutoSize = true;
            lbl_ProductPrice.Location = new Point(149, 79);
            lbl_ProductPrice.Name = "lbl_ProductPrice";
            lbl_ProductPrice.Size = new Size(78, 15);
            lbl_ProductPrice.TabIndex = 10;
            lbl_ProductPrice.Text = "Product Price";
            // 
            // txtbox_ProductPrice
            // 
            txtbox_ProductPrice.Location = new Point(233, 76);
            txtbox_ProductPrice.Name = "txtbox_ProductPrice";
            txtbox_ProductPrice.Size = new Size(126, 23);
            txtbox_ProductPrice.TabIndex = 2;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 376);
            Controls.Add(txtbox_ProductPrice);
            Controls.Add(lbl_ProductPrice);
            Controls.Add(btn_Delete);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Update);
            Controls.Add(btn_Save);
            Controls.Add(txtbox_ProductName);
            Controls.Add(txtbox_ProductID);
            Controls.Add(lbl_ProductName);
            Controls.Add(lbl_ProductID);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products Form";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ProductID;
        private Label lbl_ProductName;
        private TextBox txtbox_ProductID;
        private TextBox txtbox_ProductName;
        private Button btn_Save;
        private Button btn_Update;
        private DataGridView dataGridView1;
        private Button btn_Delete;
        private Label lbl_ProductPrice;
        private TextBox txtbox_ProductPrice;
    }
}