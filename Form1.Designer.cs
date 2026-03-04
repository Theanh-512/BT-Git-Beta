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
            this.txtUsername = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(50, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 25);
            this.lblUsername.Text = "Tên Đăng Nhập";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(220, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(50, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(115, 25);
            this.lblPassword.Text = "Mật Khẩu";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(220, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(220, 180);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MaskedTextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}
