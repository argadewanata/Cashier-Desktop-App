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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_ProductID
            // 
            lbl_ProductID.AutoSize = true;
            lbl_ProductID.Location = new Point(166, 26);
            lbl_ProductID.Name = "lbl_ProductID";
            lbl_ProductID.Size = new Size(60, 15);
            lbl_ProductID.TabIndex = 0;
            lbl_ProductID.Text = "ProductID";
            lbl_ProductID.Click += lbl_Product_Click;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.Location = new Point(142, 62);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(84, 15);
            lbl_ProductName.TabIndex = 1;
            lbl_ProductName.Text = "Product Name";
            lbl_ProductName.Click += lbl_ProductName_Click;
            // 
            // txtbox_ProductID
            // 
            txtbox_ProductID.Location = new Point(232, 23);
            txtbox_ProductID.Name = "txtbox_ProductID";
            txtbox_ProductID.Size = new Size(126, 23);
            txtbox_ProductID.TabIndex = 7;
            // 
            // txtbox_ProductName
            // 
            txtbox_ProductName.Location = new Point(232, 59);
            txtbox_ProductName.Name = "txtbox_ProductName";
            txtbox_ProductName.Size = new Size(126, 23);
            txtbox_ProductName.TabIndex = 3;
            txtbox_ProductName.TextChanged += textBox2_TextChanged;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(204, 115);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(308, 115);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(553, 219);
            dataGridView1.TabIndex = 6;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 376);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Update);
            Controls.Add(btn_Save);
            Controls.Add(txtbox_ProductName);
            Controls.Add(txtbox_ProductID);
            Controls.Add(lbl_ProductName);
            Controls.Add(lbl_ProductID);
            Name = "ProductsForm";
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
    }
}