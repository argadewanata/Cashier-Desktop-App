namespace Cashier_Dekstop_App
{
    partial class ViewBill
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePickerTo = new DateTimePicker();
            btn_PrintSummary = new Button();
            lbl_FromDate = new Label();
            lbl_ToDate = new Label();
            dateTimePickerFrom = new DateTimePicker();
            bnt_DeleteBills = new Button();
            txtbox_Flag = new TextBox();
            btn_ViewBills = new Button();
            dataGridView1 = new DataGridView();
            lbl_TotalBills = new Label();
            txtbox_TotalBills = new TextBox();
            lbl_TotalSales = new Label();
            txtbox_TotalSales = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5696354F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1631117F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5696354F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0376415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.32246F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.214092F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.8211384F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.Controls.Add(dateTimePickerTo, 4, 0);
            tableLayoutPanel1.Controls.Add(btn_PrintSummary, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_FromDate, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_ToDate, 3, 0);
            tableLayoutPanel1.Controls.Add(dateTimePickerFrom, 2, 0);
            tableLayoutPanel1.Controls.Add(bnt_DeleteBills, 7, 0);
            tableLayoutPanel1.Controls.Add(txtbox_Flag, 5, 0);
            tableLayoutPanel1.Controls.Add(btn_ViewBills, 6, 0);
            tableLayoutPanel1.Location = new Point(2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(797, 29);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Format = DateTimePickerFormat.Short;
            dateTimePickerTo.Location = new Point(428, 3);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(137, 23);
            dateTimePickerTo.TabIndex = 1;
            // 
            // btn_PrintSummary
            // 
            btn_PrintSummary.Location = new Point(3, 3);
            btn_PrintSummary.Name = "btn_PrintSummary";
            btn_PrintSummary.Size = new Size(124, 23);
            btn_PrintSummary.TabIndex = 0;
            btn_PrintSummary.Text = "Print Summary";
            btn_PrintSummary.UseVisualStyleBackColor = true;
            // 
            // lbl_FromDate
            // 
            lbl_FromDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_FromDate.AutoSize = true;
            lbl_FromDate.Location = new Point(158, 0);
            lbl_FromDate.Name = "lbl_FromDate";
            lbl_FromDate.Size = new Size(35, 29);
            lbl_FromDate.TabIndex = 1;
            lbl_FromDate.Text = "From";
            lbl_FromDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_ToDate
            // 
            lbl_ToDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_ToDate.AutoSize = true;
            lbl_ToDate.Location = new Point(378, 0);
            lbl_ToDate.Name = "lbl_ToDate";
            lbl_ToDate.Size = new Size(19, 29);
            lbl_ToDate.TabIndex = 2;
            lbl_ToDate.Text = "To";
            lbl_ToDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom.Location = new Point(216, 3);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(132, 23);
            dateTimePickerFrom.TabIndex = 3;
            // 
            // bnt_DeleteBills
            // 
            bnt_DeleteBills.Location = new Point(741, 3);
            bnt_DeleteBills.Name = "bnt_DeleteBills";
            bnt_DeleteBills.Size = new Size(53, 23);
            bnt_DeleteBills.TabIndex = 5;
            bnt_DeleteBills.Text = "Delete Bills";
            bnt_DeleteBills.UseVisualStyleBackColor = true;
            bnt_DeleteBills.Click += bnt_DeleteBills_Click;
            // 
            // txtbox_Flag
            // 
            txtbox_Flag.Location = new Point(571, 3);
            txtbox_Flag.Name = "txtbox_Flag";
            txtbox_Flag.Size = new Size(60, 23);
            txtbox_Flag.TabIndex = 6;
            txtbox_Flag.TextChanged += textBox1_TextChanged;
            // 
            // btn_ViewBills
            // 
            btn_ViewBills.Location = new Point(639, 3);
            btn_ViewBills.Name = "btn_ViewBills";
            btn_ViewBills.Size = new Size(96, 23);
            btn_ViewBills.TabIndex = 4;
            btn_ViewBills.Text = "View Bills";
            btn_ViewBills.UseVisualStyleBackColor = true;
            btn_ViewBills.Click += btn_ViewBills_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(797, 357);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // lbl_TotalBills
            // 
            lbl_TotalBills.AutoSize = true;
            lbl_TotalBills.Location = new Point(5, 401);
            lbl_TotalBills.Name = "lbl_TotalBills";
            lbl_TotalBills.Size = new Size(56, 15);
            lbl_TotalBills.TabIndex = 2;
            lbl_TotalBills.Text = "Total Bills";
            // 
            // txtbox_TotalBills
            // 
            txtbox_TotalBills.Location = new Point(5, 419);
            txtbox_TotalBills.Name = "txtbox_TotalBills";
            txtbox_TotalBills.Size = new Size(100, 23);
            txtbox_TotalBills.TabIndex = 3;
            txtbox_TotalBills.TextChanged += txtbox_TotalBills_TextChanged;
            // 
            // lbl_TotalSales
            // 
            lbl_TotalSales.AutoSize = true;
            lbl_TotalSales.Location = new Point(123, 401);
            lbl_TotalSales.Name = "lbl_TotalSales";
            lbl_TotalSales.Size = new Size(61, 15);
            lbl_TotalSales.TabIndex = 4;
            lbl_TotalSales.Text = "Total Sales";
            // 
            // txtbox_TotalSales
            // 
            txtbox_TotalSales.Location = new Point(123, 419);
            txtbox_TotalSales.Name = "txtbox_TotalSales";
            txtbox_TotalSales.Size = new Size(100, 23);
            txtbox_TotalSales.TabIndex = 5;
            // 
            // ViewBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbox_TotalSales);
            Controls.Add(lbl_TotalSales);
            Controls.Add(txtbox_TotalBills);
            Controls.Add(lbl_TotalBills);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "ViewBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Bills";
            Load += ViewBill_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_PrintSummary;
        private DateTimePicker dateTimePickerTo;
        private Label lbl_ToDate;
        private DateTimePicker dateTimePickerFrom;
        private Label lbl_FromDate;
        private Button btn_ViewBills;
        private Button bnt_DeleteBills;
        private DataGridView dataGridView1;
        private TextBox txtbox_Flag;
        private Label lbl_TotalBills;
        private TextBox txtbox_TotalBills;
        private Label lbl_TotalSales;
        private TextBox txtbox_TotalSales;
    }
}