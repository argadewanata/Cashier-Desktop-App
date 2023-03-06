namespace Cashier_Dekstop_App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbl_Password = new Label();
            lbl_Username = new Label();
            txtbox_Username = new TextBox();
            txtbox_Password = new TextBox();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(101, 104);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(101, 49);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(60, 15);
            lbl_Username.TabIndex = 3;
            lbl_Username.Text = "Username";
            // 
            // txtbox_Username
            // 
            txtbox_Username.Location = new Point(101, 67);
            txtbox_Username.Name = "txtbox_Username";
            txtbox_Username.Size = new Size(119, 23);
            txtbox_Username.TabIndex = 0;
            // 
            // txtbox_Password
            // 
            txtbox_Password.Location = new Point(101, 122);
            txtbox_Password.Name = "txtbox_Password";
            txtbox_Password.Size = new Size(119, 23);
            txtbox_Password.TabIndex = 1;
            txtbox_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(119, 166);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 23);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 244);
            Controls.Add(btn_Login);
            Controls.Add(txtbox_Password);
            Controls.Add(txtbox_Username);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_Password);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Password;
        private Label lbl_Username;
        private TextBox txtbox_Username;
        private TextBox txtbox_Password;
        private Button btn_Login;
    }
}