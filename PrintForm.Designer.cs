namespace Cashier_Dekstop_App
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            panelPrint = new Panel();
            lbl_DataNetPay = new Label();
            lbl_DataDiscount = new Label();
            lbl_DataTotalBill = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbl_NetPay = new Label();
            lbl_Discount = new Label();
            lbl_TotalBill = new Label();
            dataGridView1 = new DataGridView();
            lbl_DataDate = new Label();
            lbl_DataBillNo = new Label();
            label2 = new Label();
            lbl_Date = new Label();
            label1 = new Label();
            lbl_BillNo = new Label();
            lbl_Phone = new Label();
            lbl_Area = new Label();
            lbl_Address = new Label();
            lbl_TokoSejahtera = new Label();
            comboBox1 = new ComboBox();
            lbl_PrintPreview = new Label();
            btn_Print = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelPrint
            // 
            panelPrint.BackColor = SystemColors.ScrollBar;
            panelPrint.Controls.Add(lbl_DataNetPay);
            panelPrint.Controls.Add(lbl_DataDiscount);
            panelPrint.Controls.Add(lbl_DataTotalBill);
            panelPrint.Controls.Add(label5);
            panelPrint.Controls.Add(label4);
            panelPrint.Controls.Add(label3);
            panelPrint.Controls.Add(lbl_NetPay);
            panelPrint.Controls.Add(lbl_Discount);
            panelPrint.Controls.Add(lbl_TotalBill);
            panelPrint.Controls.Add(dataGridView1);
            panelPrint.Controls.Add(lbl_DataDate);
            panelPrint.Controls.Add(lbl_DataBillNo);
            panelPrint.Controls.Add(label2);
            panelPrint.Controls.Add(lbl_Date);
            panelPrint.Controls.Add(label1);
            panelPrint.Controls.Add(lbl_BillNo);
            panelPrint.Controls.Add(lbl_Phone);
            panelPrint.Controls.Add(lbl_Area);
            panelPrint.Controls.Add(lbl_Address);
            panelPrint.Controls.Add(lbl_TokoSejahtera);
            panelPrint.Dock = DockStyle.Bottom;
            panelPrint.Location = new Point(0, 46);
            panelPrint.Name = "panelPrint";
            panelPrint.Size = new Size(497, 432);
            panelPrint.TabIndex = 0;
            // 
            // lbl_DataNetPay
            // 
            lbl_DataNetPay.AutoSize = true;
            lbl_DataNetPay.Location = new Point(399, 403);
            lbl_DataNetPay.Name = "lbl_DataNetPay";
            lbl_DataNetPay.Size = new Size(51, 15);
            lbl_DataNetPay.TabIndex = 19;
            lbl_DataNetPay.Text = "NET PAY";
            // 
            // lbl_DataDiscount
            // 
            lbl_DataDiscount.AutoSize = true;
            lbl_DataDiscount.Location = new Point(399, 381);
            lbl_DataDiscount.Name = "lbl_DataDiscount";
            lbl_DataDiscount.Size = new Size(64, 15);
            lbl_DataDiscount.TabIndex = 18;
            lbl_DataDiscount.Text = "DISCOUNT";
            // 
            // lbl_DataTotalBill
            // 
            lbl_DataTotalBill.AutoSize = true;
            lbl_DataTotalBill.Location = new Point(399, 357);
            lbl_DataTotalBill.Name = "lbl_DataTotalBill";
            lbl_DataTotalBill.Size = new Size(64, 15);
            lbl_DataTotalBill.TabIndex = 17;
            lbl_DataTotalBill.Text = "TOTAL BILL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(383, 403);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 16;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(383, 381);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 15;
            label4.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(383, 357);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 14;
            label3.Text = ":";
            // 
            // lbl_NetPay
            // 
            lbl_NetPay.AutoSize = true;
            lbl_NetPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NetPay.Location = new Point(327, 403);
            lbl_NetPay.Name = "lbl_NetPay";
            lbl_NetPay.Size = new Size(50, 15);
            lbl_NetPay.TabIndex = 13;
            lbl_NetPay.Text = "Net Pay";
            // 
            // lbl_Discount
            // 
            lbl_Discount.AutoSize = true;
            lbl_Discount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Discount.Location = new Point(321, 381);
            lbl_Discount.Name = "lbl_Discount";
            lbl_Discount.Size = new Size(56, 15);
            lbl_Discount.TabIndex = 12;
            lbl_Discount.Text = "Discount";
            // 
            // lbl_TotalBill
            // 
            lbl_TotalBill.AutoSize = true;
            lbl_TotalBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalBill.Location = new Point(275, 357);
            lbl_TotalBill.Name = "lbl_TotalBill";
            lbl_TotalBill.Size = new Size(102, 15);
            lbl_TotalBill.TabIndex = 11;
            lbl_TotalBill.Text = "Total Bill Amount";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(491, 180);
            dataGridView1.TabIndex = 10;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            // 
            // lbl_DataDate
            // 
            lbl_DataDate.AutoSize = true;
            lbl_DataDate.Location = new Point(65, 146);
            lbl_DataDate.Name = "lbl_DataDate";
            lbl_DataDate.Size = new Size(34, 15);
            lbl_DataDate.TabIndex = 9;
            lbl_DataDate.Text = "DATE";
            // 
            // lbl_DataBillNo
            // 
            lbl_DataBillNo.AutoSize = true;
            lbl_DataBillNo.Location = new Point(65, 120);
            lbl_DataBillNo.Name = "lbl_DataBillNo";
            lbl_DataBillNo.Size = new Size(43, 15);
            lbl_DataBillNo.TabIndex = 8;
            lbl_DataBillNo.Text = "BILL ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 146);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 7;
            label2.Text = ":";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Date.Location = new Point(3, 146);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(34, 15);
            lbl_Date.TabIndex = 6;
            lbl_Date.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 120);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 5;
            label1.Text = ":";
            // 
            // lbl_BillNo
            // 
            lbl_BillNo.AutoSize = true;
            lbl_BillNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_BillNo.Location = new Point(3, 120);
            lbl_BillNo.Name = "lbl_BillNo";
            lbl_BillNo.Size = new Size(40, 15);
            lbl_BillNo.TabIndex = 4;
            lbl_BillNo.Text = "Bill ID";
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Location = new Point(203, 82);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(91, 15);
            lbl_Phone.TabIndex = 3;
            lbl_Phone.Text = "Telp : 081234092";
            // 
            // lbl_Area
            // 
            lbl_Area.AutoSize = true;
            lbl_Area.Location = new Point(192, 67);
            lbl_Area.Name = "lbl_Area";
            lbl_Area.Size = new Size(112, 15);
            lbl_Area.TabIndex = 2;
            lbl_Area.Text = "Surabaya, Indonesia";
            lbl_Area.Click += lbl_Area_Click;
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Location = new Point(154, 52);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(188, 15);
            lbl_Address.TabIndex = 1;
            lbl_Address.Text = "Jalan Kerja Bakti  No.3 RT 02 RW 09";
            // 
            // lbl_TokoSejahtera
            // 
            lbl_TokoSejahtera.AutoSize = true;
            lbl_TokoSejahtera.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TokoSejahtera.Location = new Point(34, 12);
            lbl_TokoSejahtera.Name = "lbl_TokoSejahtera";
            lbl_TokoSejahtera.Size = new Size(432, 40);
            lbl_TokoSejahtera.TabIndex = 0;
            lbl_TokoSejahtera.Text = "Toko Sejahtera Abadi Makmur";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(192, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 20;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbl_PrintPreview
            // 
            lbl_PrintPreview.AutoSize = true;
            lbl_PrintPreview.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PrintPreview.Location = new Point(0, 7);
            lbl_PrintPreview.Name = "lbl_PrintPreview";
            lbl_PrintPreview.Size = new Size(146, 32);
            lbl_PrintPreview.TabIndex = 1;
            lbl_PrintPreview.Text = "Print Preview";
            // 
            // btn_Print
            // 
            btn_Print.Location = new Point(381, 12);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(104, 23);
            btn_Print.TabIndex = 2;
            btn_Print.Text = "Print";
            btn_Print.UseVisualStyleBackColor = true;
            btn_Print.Click += btn_Print_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // PrintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(497, 478);
            Controls.Add(comboBox1);
            Controls.Add(btn_Print);
            Controls.Add(lbl_PrintPreview);
            Controls.Add(panelPrint);
            Name = "PrintForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintForm";
            Load += PrintForm_Load;
            panelPrint.ResumeLayout(false);
            panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrint;
        private Label lbl_PrintPreview;
        private Button btn_Print;
        private Label lbl_TokoSejahtera;
        private Label lbl_Area;
        private Label lbl_Address;
        private Label lbl_Phone;
        private Label label2;
        private Label lbl_Date;
        private Label label1;
        private Label lbl_BillNo;
        private Label lbl_DataDate;
        private Label lbl_DataBillNo;
        private DataGridView dataGridView1;
        private Label lbl_TotalBill;
        private Label lbl_Discount;
        private Label lbl_NetPay;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbl_DataNetPay;
        private Label lbl_DataDiscount;
        private Label lbl_DataTotalBill;
        private ComboBox comboBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}