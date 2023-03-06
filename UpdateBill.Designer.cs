namespace Cashier_Dekstop_App
{
    partial class UpdateBill
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
            btn_Save = new Button();
            txtbox_NetPay = new TextBox();
            txtbox_Discount = new TextBox();
            txtbox_TotalBill = new TextBox();
            lbl_NetPay = new Label();
            lbl_Discount = new Label();
            lbl_TotalBillAmount = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
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
            lbl_Amount = new Label();
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            txtBox_BillNo = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lbl_Date = new Label();
            lbl_BillNo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.None;
            btn_Save.Location = new Point(597, 392);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(81, 23);
            btn_Save.TabIndex = 23;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // txtbox_NetPay
            // 
            txtbox_NetPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbox_NetPay.Location = new Point(112, 393);
            txtbox_NetPay.Name = "txtbox_NetPay";
            txtbox_NetPay.ReadOnly = true;
            txtbox_NetPay.Size = new Size(100, 23);
            txtbox_NetPay.TabIndex = 22;
            // 
            // txtbox_Discount
            // 
            txtbox_Discount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbox_Discount.Location = new Point(112, 364);
            txtbox_Discount.Name = "txtbox_Discount";
            txtbox_Discount.Size = new Size(100, 23);
            txtbox_Discount.TabIndex = 21;
            // 
            // txtbox_TotalBill
            // 
            txtbox_TotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbox_TotalBill.Location = new Point(112, 335);
            txtbox_TotalBill.Name = "txtbox_TotalBill";
            txtbox_TotalBill.ReadOnly = true;
            txtbox_TotalBill.Size = new Size(100, 23);
            txtbox_TotalBill.TabIndex = 20;
            // 
            // lbl_NetPay
            // 
            lbl_NetPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_NetPay.AutoSize = true;
            lbl_NetPay.Location = new Point(58, 396);
            lbl_NetPay.Name = "lbl_NetPay";
            lbl_NetPay.Size = new Size(48, 15);
            lbl_NetPay.TabIndex = 19;
            lbl_NetPay.Text = "Net Pay";
            // 
            // lbl_Discount
            // 
            lbl_Discount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Discount.AutoSize = true;
            lbl_Discount.Location = new Point(52, 367);
            lbl_Discount.Name = "lbl_Discount";
            lbl_Discount.Size = new Size(54, 15);
            lbl_Discount.TabIndex = 18;
            lbl_Discount.Text = "Discount";
            // 
            // lbl_TotalBillAmount
            // 
            lbl_TotalBillAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_TotalBillAmount.AutoSize = true;
            lbl_TotalBillAmount.Location = new Point(8, 343);
            lbl_TotalBillAmount.Name = "lbl_TotalBillAmount";
            lbl_TotalBillAmount.Size = new Size(98, 15);
            lbl_TotalBillAmount.TabIndex = 17;
            lbl_TotalBillAmount.Text = "Total Bill Amount";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(679, 228);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            tableLayoutPanel1.Controls.Add(lbl_Amount, 3, 0);
            tableLayoutPanel1.Location = new Point(3, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(678, 51);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // lbl_Qty
            // 
            lbl_Qty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Qty.AutoSize = true;
            lbl_Qty.ImageAlign = ContentAlignment.BottomCenter;
            lbl_Qty.Location = new Point(248, 0);
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
            lbl_ProductName.Location = new Point(18, 0);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(84, 25);
            lbl_ProductName.TabIndex = 0;
            lbl_ProductName.Text = "Product Name";
            lbl_ProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Price
            // 
            lbl_Price.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Price.AutoSize = true;
            lbl_Price.ImageAlign = ContentAlignment.BottomCenter;
            lbl_Price.Location = new Point(159, 0);
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
            txtbox_ProQty.BorderStyle = BorderStyle.FixedSingle;
            txtbox_ProQty.Location = new Point(234, 28);
            txtbox_ProQty.Name = "txtbox_ProQty";
            txtbox_ProQty.Size = new Size(82, 23);
            txtbox_ProQty.TabIndex = 7;
            // 
            // txtbox_ProAmount
            // 
            txtbox_ProAmount.AcceptsTab = true;
            txtbox_ProAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_ProAmount.BorderStyle = BorderStyle.FixedSingle;
            txtbox_ProAmount.Location = new Point(336, 28);
            txtbox_ProAmount.Name = "txtbox_ProAmount";
            txtbox_ProAmount.ReadOnly = true;
            txtbox_ProAmount.Size = new Size(84, 23);
            txtbox_ProAmount.TabIndex = 6;
            // 
            // txtBox_ProPrice
            // 
            txtBox_ProPrice.AcceptsTab = true;
            txtBox_ProPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtBox_ProPrice.BorderStyle = BorderStyle.FixedSingle;
            txtBox_ProPrice.Location = new Point(126, 28);
            txtBox_ProPrice.Name = "txtBox_ProPrice";
            txtBox_ProPrice.Size = new Size(100, 23);
            txtBox_ProPrice.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(115, 23);
            comboBox1.TabIndex = 4;
            // 
            // btn_Add
            // 
            btn_Add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btn_Add.Location = new Point(441, 28);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(53, 20);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btn_Delete.Location = new Point(500, 28);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(60, 20);
            btn_Delete.TabIndex = 9;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // bnt_Clear
            // 
            bnt_Clear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bnt_Clear.Location = new Point(566, 28);
            bnt_Clear.Name = "bnt_Clear";
            bnt_Clear.Size = new Size(60, 20);
            bnt_Clear.TabIndex = 10;
            bnt_Clear.Text = "Clear";
            bnt_Clear.UseVisualStyleBackColor = true;
            // 
            // txtBox_DeleUpdate
            // 
            txtBox_DeleUpdate.Location = new Point(632, 28);
            txtBox_DeleUpdate.Name = "txtBox_DeleUpdate";
            txtBox_DeleUpdate.Size = new Size(43, 23);
            txtBox_DeleUpdate.TabIndex = 11;
            // 
            // lbl_Amount
            // 
            lbl_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Amount.AutoSize = true;
            lbl_Amount.ImageAlign = ContentAlignment.BottomCenter;
            lbl_Amount.Location = new Point(353, 0);
            lbl_Amount.Name = "lbl_Amount";
            lbl_Amount.Size = new Size(51, 25);
            lbl_Amount.TabIndex = 3;
            lbl_Amount.Text = "Amount";
            lbl_Amount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBox_BillNo);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lbl_Date);
            panel1.Controls.Add(lbl_BillNo);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 35);
            panel1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(577, 6);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(96, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(540, 12);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 24;
            label1.Text = "Date";
            // 
            // txtBox_BillNo
            // 
            txtBox_BillNo.BorderStyle = BorderStyle.FixedSingle;
            txtBox_BillNo.Location = new Point(32, 6);
            txtBox_BillNo.Name = "txtBox_BillNo";
            txtBox_BillNo.ReadOnly = true;
            txtBox_BillNo.Size = new Size(100, 23);
            txtBox_BillNo.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1067, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(96, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // lbl_Date
            // 
            lbl_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(1030, 12);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(31, 15);
            lbl_Date.TabIndex = 1;
            lbl_Date.Text = "Date";
            // 
            // lbl_BillNo
            // 
            lbl_BillNo.AutoSize = true;
            lbl_BillNo.Location = new Point(3, 9);
            lbl_BillNo.Name = "lbl_BillNo";
            lbl_BillNo.Size = new Size(23, 15);
            lbl_BillNo.TabIndex = 0;
            lbl_BillNo.Text = "No";
            // 
            // UpdateBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(686, 423);
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
            Name = "UpdateBill";
            Text = "UpdateBill";
            Load += UpdateBill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Save;
        private Label lbl_NetPay;
        private Label lbl_Discount;
        private Label lbl_TotalBillAmount;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_Amount;
        private Label lbl_Qty;
        private Label lbl_ProductName;
        private Label lbl_Price;
        private ComboBox comboBox1;
        private Button btn_Add;
        private Button btn_Delete;
        private Button bnt_Clear;
        private TextBox txtBox_DeleUpdate;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label lbl_Date;
        private Label lbl_BillNo;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        public TextBox txtbox_NetPay;
        public TextBox txtbox_Discount;
        public TextBox txtbox_TotalBill;
        public TextBox txtbox_ProQty;
        public TextBox txtbox_ProAmount;
        public TextBox txtBox_ProPrice;
        public TextBox txtBox_BillNo;
    }
}