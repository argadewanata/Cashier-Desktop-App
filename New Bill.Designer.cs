namespace Cashier_Dekstop_App
{
    partial class New_Bill
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
            lbl_BillNo = new Label();
            lbl_Date = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtBox_BillNo = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_Amount = new Label();
            lbl_Qty = new Label();
            lbl_ProductName = new Label();
            lbl_Price = new Label();
            txtbox_ProQty = new TextBox();
            txtbox_ProAmount = new TextBox();
            txtBox_ProPrice = new TextBox();
            comboBox1 = new ComboBox();
            btn_Add = new Button();
            btn_Delete = new Button();
            bnt_Clear = new Button();
            txtBox_DeleUpdate = new TextBox();
            dataGridView1 = new DataGridView();
            sino = new DataGridViewTextBoxColumn();
            productname = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            billno = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            lbl_TotalBillAmount = new Label();
            lbl_Discount = new Label();
            lbl_NetPay = new Label();
            txtbox_TotalBill = new TextBox();
            txtbox_Discount = new TextBox();
            txtbox_NetPay = new TextBox();
            btn_Save = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_BillNo
            // 
            lbl_BillNo.AutoSize = true;
            lbl_BillNo.Location = new Point(3, 9);
            lbl_BillNo.Name = "lbl_BillNo";
            lbl_BillNo.Size = new Size(23, 15);
            lbl_BillNo.TabIndex = 0;
            lbl_BillNo.Text = "No";
            lbl_BillNo.Click += lbl_BillNo_Click;
            // 
            // lbl_Date
            // 
            lbl_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(551, 12);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(31, 15);
            lbl_Date.TabIndex = 1;
            lbl_Date.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(588, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(96, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtBox_BillNo
            // 
            txtBox_BillNo.Location = new Point(32, 6);
            txtBox_BillNo.Name = "txtBox_BillNo";
            txtBox_BillNo.ReadOnly = true;
            txtBox_BillNo.Size = new Size(100, 23);
            txtBox_BillNo.TabIndex = 3;
            txtBox_BillNo.TextChanged += txtBox_BillNo_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtBox_BillNo);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lbl_Date);
            panel1.Controls.Add(lbl_BillNo);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 35);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.19512F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.80488F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Controls.Add(lbl_Amount, 3, 0);
            tableLayoutPanel1.Controls.Add(lbl_Qty, 2, 0);
            tableLayoutPanel1.Controls.Add(lbl_ProductName, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_Price, 1, 0);
            tableLayoutPanel1.Controls.Add(txtbox_ProQty, 2, 1);
            tableLayoutPanel1.Controls.Add(txtbox_ProAmount, 3, 1);
            tableLayoutPanel1.Controls.Add(txtBox_ProPrice, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_Add, 4, 1);
            tableLayoutPanel1.Controls.Add(btn_Delete, 5, 1);
            tableLayoutPanel1.Controls.Add(bnt_Clear, 6, 1);
            tableLayoutPanel1.Controls.Add(txtBox_DeleUpdate, 7, 1);
            tableLayoutPanel1.Location = new Point(2, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(691, 51);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // lbl_Amount
            // 
            lbl_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Amount.AutoSize = true;
            lbl_Amount.ImageAlign = ContentAlignment.BottomCenter;
            lbl_Amount.Location = new Point(366, 0);
            lbl_Amount.Name = "lbl_Amount";
            lbl_Amount.Size = new Size(51, 25);
            lbl_Amount.TabIndex = 3;
            lbl_Amount.Text = "Amount";
            lbl_Amount.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Amount.Click += label1_Click;
            // 
            // lbl_Qty
            // 
            lbl_Qty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Qty.AutoSize = true;
            lbl_Qty.ImageAlign = ContentAlignment.BottomCenter;
            lbl_Qty.Location = new Point(261, 0);
            lbl_Qty.Name = "lbl_Qty";
            lbl_Qty.Size = new Size(53, 25);
            lbl_Qty.TabIndex = 2;
            lbl_Qty.Text = "Quantity";
            lbl_Qty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.ImageAlign = ContentAlignment.BottomCenter;
            lbl_ProductName.Location = new Point(21, 0);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(84, 25);
            lbl_ProductName.TabIndex = 0;
            lbl_ProductName.Text = "Product Name";
            lbl_ProductName.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ProductName.Click += lbl_ProductName_Click;
            // 
            // lbl_Price
            // 
            lbl_Price.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Price.AutoSize = true;
            lbl_Price.ImageAlign = ContentAlignment.BottomCenter;
            lbl_Price.Location = new Point(169, 0);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(33, 25);
            lbl_Price.TabIndex = 1;
            lbl_Price.Text = "Price";
            lbl_Price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbox_ProQty
            // 
            txtbox_ProQty.AcceptsTab = true;
            txtbox_ProQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_ProQty.Location = new Point(247, 28);
            txtbox_ProQty.Name = "txtbox_ProQty";
            txtbox_ProQty.Size = new Size(82, 23);
            txtbox_ProQty.TabIndex = 7;
            txtbox_ProQty.Leave += txtbox_ProQty_Leave;
            // 
            // txtbox_ProAmount
            // 
            txtbox_ProAmount.AcceptsTab = true;
            txtbox_ProAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_ProAmount.Location = new Point(349, 28);
            txtbox_ProAmount.Name = "txtbox_ProAmount";
            txtbox_ProAmount.ReadOnly = true;
            txtbox_ProAmount.Size = new Size(84, 23);
            txtbox_ProAmount.TabIndex = 6;
            // 
            // txtBox_ProPrice
            // 
            txtBox_ProPrice.AcceptsTab = true;
            txtBox_ProPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtBox_ProPrice.Location = new Point(135, 28);
            txtBox_ProPrice.Name = "txtBox_ProPrice";
            txtBox_ProPrice.Size = new Size(100, 23);
            txtBox_ProPrice.TabIndex = 5;
            txtBox_ProPrice.Leave += txtBox_ProPrice_Leave;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // btn_Add
            // 
            btn_Add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btn_Add.Location = new Point(454, 28);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(53, 20);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btn_Delete.Location = new Point(513, 28);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(60, 20);
            btn_Delete.TabIndex = 9;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // bnt_Clear
            // 
            bnt_Clear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bnt_Clear.Location = new Point(579, 28);
            bnt_Clear.Name = "bnt_Clear";
            bnt_Clear.Size = new Size(60, 20);
            bnt_Clear.TabIndex = 10;
            bnt_Clear.Text = "Clear";
            bnt_Clear.UseVisualStyleBackColor = true;
            // 
            // txtBox_DeleUpdate
            // 
            txtBox_DeleUpdate.Location = new Point(645, 28);
            txtBox_DeleUpdate.Name = "txtBox_DeleUpdate";
            txtBox_DeleUpdate.Size = new Size(43, 23);
            txtBox_DeleUpdate.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sino, productname, price, qty, amount, billno, Date });
            dataGridView1.Location = new Point(5, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(688, 217);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // sino
            // 
            sino.HeaderText = "SINo";
            sino.Name = "sino";
            // 
            // productname
            // 
            productname.HeaderText = "Product Name";
            productname.Name = "productname";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // qty
            // 
            qty.HeaderText = "Qty";
            qty.Name = "qty";
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.Name = "amount";
            // 
            // billno
            // 
            billno.HeaderText = "BillNo";
            billno.Name = "billno";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // lbl_TotalBillAmount
            // 
            lbl_TotalBillAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_TotalBillAmount.AutoSize = true;
            lbl_TotalBillAmount.Location = new Point(15, 329);
            lbl_TotalBillAmount.Name = "lbl_TotalBillAmount";
            lbl_TotalBillAmount.Size = new Size(98, 15);
            lbl_TotalBillAmount.TabIndex = 7;
            lbl_TotalBillAmount.Text = "Total Bill Amount";
            // 
            // lbl_Discount
            // 
            lbl_Discount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Discount.AutoSize = true;
            lbl_Discount.Location = new Point(59, 353);
            lbl_Discount.Name = "lbl_Discount";
            lbl_Discount.Size = new Size(54, 15);
            lbl_Discount.TabIndex = 8;
            lbl_Discount.Text = "Discount";
            // 
            // lbl_NetPay
            // 
            lbl_NetPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_NetPay.AutoSize = true;
            lbl_NetPay.Location = new Point(65, 382);
            lbl_NetPay.Name = "lbl_NetPay";
            lbl_NetPay.Size = new Size(48, 15);
            lbl_NetPay.TabIndex = 9;
            lbl_NetPay.Text = "Net Pay";
            // 
            // txtbox_TotalBill
            // 
            txtbox_TotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbox_TotalBill.Location = new Point(119, 321);
            txtbox_TotalBill.Name = "txtbox_TotalBill";
            txtbox_TotalBill.ReadOnly = true;
            txtbox_TotalBill.Size = new Size(100, 23);
            txtbox_TotalBill.TabIndex = 10;
            txtbox_TotalBill.TextChanged += txtbox_TotalBill_TextChanged;
            // 
            // txtbox_Discount
            // 
            txtbox_Discount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbox_Discount.Location = new Point(119, 350);
            txtbox_Discount.Name = "txtbox_Discount";
            txtbox_Discount.Size = new Size(100, 23);
            txtbox_Discount.TabIndex = 11;
            txtbox_Discount.Leave += txtbox_Discount_Leave;
            // 
            // txtbox_NetPay
            // 
            txtbox_NetPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbox_NetPay.Location = new Point(119, 379);
            txtbox_NetPay.Name = "txtbox_NetPay";
            txtbox_NetPay.ReadOnly = true;
            txtbox_NetPay.Size = new Size(100, 23);
            txtbox_NetPay.TabIndex = 12;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Save.Location = new Point(612, 382);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 13;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // New_Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(695, 416);
            Controls.Add(btn_Save);
            Controls.Add(txtbox_NetPay);
            Controls.Add(txtbox_Discount);
            Controls.Add(txtbox_TotalBill);
            Controls.Add(lbl_NetPay);
            Controls.Add(lbl_Discount);
            Controls.Add(lbl_TotalBillAmount);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "New_Bill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Bill";
            Load += New_Bill_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_BillNo;
        private Label lbl_Date;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBox_BillNo;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_ProductName;
        private Label lbl_Price;
        private Label lbl_Amount;
        private Label lbl_Qty;
        private TextBox txtbox_ProAmount;
        private ComboBox comboBox1;
        private TextBox txtBox_ProPrice;
        private TextBox txtbox_ProQty;
        private Button btn_Add;
        private Button btn_Delete;
        private Button bnt_Clear;
        private DataGridView dataGridView1;
        private Label lbl_TotalBillAmount;
        private Label lbl_Discount;
        private Label lbl_NetPay;
        private TextBox txtbox_TotalBill;
        private TextBox txtbox_Discount;
        private TextBox txtbox_NetPay;
        private Button btn_Save;
        private TextBox txtBox_DeleUpdate;
        private DataGridViewTextBoxColumn sino;
        private DataGridViewTextBoxColumn productname;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn billno;
        private DataGridViewTextBoxColumn Date;
    }
}