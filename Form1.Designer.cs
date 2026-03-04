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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.MaskedTextBox();
            this.textboxmatkhau = new System.Windows.Forms.MaskedTextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(200, 232);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(313, 46);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên Đăng Nhập";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(200, 329);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(197, 46);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật Khẩu";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(600, 232);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(496, 38);
            this.textboxusername.TabIndex = 2;
            // 
            // textboxmatkhau
            // 
            this.textboxmatkhau.Location = new System.Drawing.Point(600, 329);
            this.textboxmatkhau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.PasswordChar = '*';
            this.textboxmatkhau.Size = new System.Drawing.Size(496, 38);
            this.textboxmatkhau.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(600, 426);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(240, 68);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 789);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.btnlogin);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.MaskedTextBox textboxusername;
        private System.Windows.Forms.MaskedTextBox textboxmatkhau;
        private System.Windows.Forms.Button btnlogin;
    }
}