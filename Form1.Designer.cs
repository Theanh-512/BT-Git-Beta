namespace BT_Git
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textboxmatkhau = new System.Windows.Forms.MaskedTextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(118, 216);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(164, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên Đăng Nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(326, 220);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(343, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(272, 114);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(290, 22);
            this.textboxusername.TabIndex = 1;
            this.textboxusername.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(326, 343);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(343, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // textboxmatkhau
            // 
            this.textboxmatkhau.Location = new System.Drawing.Point(272, 163);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.Size = new System.Drawing.Size(290, 22);
            this.textboxmatkhau.TabIndex = 3;
            // 
            // btnlogin
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 407);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textboxusername;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.MaskedTextBox textboxmatkhau;
        private System.Windows.Forms.Button btnlogin;
    }
}
