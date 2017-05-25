namespace ClinicSecretary
{
    partial class SecretaryLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.textsecretarypassword = new System.Windows.Forms.TextBox();
            this.textsecretaryname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(101, 175);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textsecretarypassword
            // 
            this.textsecretarypassword.Location = new System.Drawing.Point(144, 113);
            this.textsecretarypassword.Name = "textsecretarypassword";
            this.textsecretarypassword.PasswordChar = '*';
            this.textsecretarypassword.Size = new System.Drawing.Size(100, 20);
            this.textsecretarypassword.TabIndex = 9;
            // 
            // textsecretaryname
            // 
            this.textsecretaryname.Location = new System.Drawing.Point(144, 62);
            this.textsecretaryname.Name = "textsecretaryname";
            this.textsecretaryname.Size = new System.Drawing.Size(100, 20);
            this.textsecretaryname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // SecretaryLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textsecretarypassword);
            this.Controls.Add(this.textsecretaryname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "SecretaryLogin";
            this.Text = "SecretaryLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textsecretarypassword;
        private System.Windows.Forms.TextBox textsecretaryname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}