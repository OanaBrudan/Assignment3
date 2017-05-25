namespace Doctors
{
    partial class DoctorLogin
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
            this.textdoctorpassword = new System.Windows.Forms.TextBox();
            this.textdoctorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(101, 175);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textdoctorpassword
            // 
            this.textdoctorpassword.Location = new System.Drawing.Point(144, 113);
            this.textdoctorpassword.Name = "textdoctorpassword";
            this.textdoctorpassword.PasswordChar = '*';
            this.textdoctorpassword.Size = new System.Drawing.Size(100, 20);
            this.textdoctorpassword.TabIndex = 14;
            // 
            // textdoctorname
            // 
            this.textdoctorname.Location = new System.Drawing.Point(144, 62);
            this.textdoctorname.Name = "textdoctorname";
            this.textdoctorname.Size = new System.Drawing.Size(100, 20);
            this.textdoctorname.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // DoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textdoctorpassword);
            this.Controls.Add(this.textdoctorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DoctorLogin";
            this.Text = "DoctorLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textdoctorpassword;
        private System.Windows.Forms.TextBox textdoctorname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}