namespace Administrator
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iddoctorlabel = new System.Windows.Forms.Label();
            this.namedoctorlabel = new System.Windows.Forms.Label();
            this.namesecretarylabel = new System.Windows.Forms.Label();
            this.idsecretarylabel = new System.Windows.Forms.Label();
            this.textdoctorid = new System.Windows.Forms.TextBox();
            this.textsecretaryid = new System.Windows.Forms.TextBox();
            this.textsecretaryname = new System.Windows.Forms.TextBox();
            this.textdoctorname = new System.Windows.Forms.TextBox();
            this.btnadddoctor = new System.Windows.Forms.Button();
            this.btneditdoctor = new System.Windows.Forms.Button();
            this.btndeletedoctor = new System.Windows.Forms.Button();
            this.btnviewdoctor = new System.Windows.Forms.Button();
            this.btnviewsecretary = new System.Windows.Forms.Button();
            this.btndeletesecretary = new System.Windows.Forms.Button();
            this.btneditsecretary = new System.Windows.Forms.Button();
            this.btnaddsecretary = new System.Windows.Forms.Button();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.dataGridViewSecretary = new System.Windows.Forms.DataGridView();
            this.textsecretarypassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textdoctorpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecretary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secretary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor:";
            // 
            // iddoctorlabel
            // 
            this.iddoctorlabel.AutoSize = true;
            this.iddoctorlabel.Location = new System.Drawing.Point(171, 29);
            this.iddoctorlabel.Name = "iddoctorlabel";
            this.iddoctorlabel.Size = new System.Drawing.Size(21, 13);
            this.iddoctorlabel.TabIndex = 2;
            this.iddoctorlabel.Text = "ID:";
            // 
            // namedoctorlabel
            // 
            this.namedoctorlabel.AutoSize = true;
            this.namedoctorlabel.Location = new System.Drawing.Point(171, 55);
            this.namedoctorlabel.Name = "namedoctorlabel";
            this.namedoctorlabel.Size = new System.Drawing.Size(38, 13);
            this.namedoctorlabel.TabIndex = 3;
            this.namedoctorlabel.Text = "Name:";
            // 
            // namesecretarylabel
            // 
            this.namesecretarylabel.AutoSize = true;
            this.namesecretarylabel.Location = new System.Drawing.Point(171, 217);
            this.namesecretarylabel.Name = "namesecretarylabel";
            this.namesecretarylabel.Size = new System.Drawing.Size(38, 13);
            this.namesecretarylabel.TabIndex = 5;
            this.namesecretarylabel.Text = "Name:";
            // 
            // idsecretarylabel
            // 
            this.idsecretarylabel.AutoSize = true;
            this.idsecretarylabel.Location = new System.Drawing.Point(171, 191);
            this.idsecretarylabel.Name = "idsecretarylabel";
            this.idsecretarylabel.Size = new System.Drawing.Size(21, 13);
            this.idsecretarylabel.TabIndex = 4;
            this.idsecretarylabel.Text = "ID:";
            // 
            // textdoctorid
            // 
            this.textdoctorid.Location = new System.Drawing.Point(242, 22);
            this.textdoctorid.Name = "textdoctorid";
            this.textdoctorid.Size = new System.Drawing.Size(100, 20);
            this.textdoctorid.TabIndex = 6;
            // 
            // textsecretaryid
            // 
            this.textsecretaryid.Location = new System.Drawing.Point(242, 184);
            this.textsecretaryid.Name = "textsecretaryid";
            this.textsecretaryid.Size = new System.Drawing.Size(100, 20);
            this.textsecretaryid.TabIndex = 7;
            this.textsecretaryid.TextChanged += new System.EventHandler(this.textsecretaryid_TextChanged);
            // 
            // textsecretaryname
            // 
            this.textsecretaryname.Location = new System.Drawing.Point(242, 210);
            this.textsecretaryname.Name = "textsecretaryname";
            this.textsecretaryname.Size = new System.Drawing.Size(100, 20);
            this.textsecretaryname.TabIndex = 8;
            // 
            // textdoctorname
            // 
            this.textdoctorname.Location = new System.Drawing.Point(242, 48);
            this.textdoctorname.Name = "textdoctorname";
            this.textdoctorname.Size = new System.Drawing.Size(100, 20);
            this.textdoctorname.TabIndex = 9;
            // 
            // btnadddoctor
            // 
            this.btnadddoctor.Location = new System.Drawing.Point(12, 134);
            this.btnadddoctor.Name = "btnadddoctor";
            this.btnadddoctor.Size = new System.Drawing.Size(75, 23);
            this.btnadddoctor.TabIndex = 10;
            this.btnadddoctor.Text = "Add";
            this.btnadddoctor.UseVisualStyleBackColor = true;
            this.btnadddoctor.Click += new System.EventHandler(this.adddoctor_click);
            // 
            // btneditdoctor
            // 
            this.btneditdoctor.Location = new System.Drawing.Point(117, 134);
            this.btneditdoctor.Name = "btneditdoctor";
            this.btneditdoctor.Size = new System.Drawing.Size(75, 23);
            this.btneditdoctor.TabIndex = 11;
            this.btneditdoctor.Text = "Edit";
            this.btneditdoctor.UseVisualStyleBackColor = true;
            this.btneditdoctor.Click += new System.EventHandler(this.editdoctor_click);
            // 
            // btndeletedoctor
            // 
            this.btndeletedoctor.Location = new System.Drawing.Point(222, 134);
            this.btndeletedoctor.Name = "btndeletedoctor";
            this.btndeletedoctor.Size = new System.Drawing.Size(75, 23);
            this.btndeletedoctor.TabIndex = 12;
            this.btndeletedoctor.Text = "Delete";
            this.btndeletedoctor.UseVisualStyleBackColor = true;
            this.btndeletedoctor.Click += new System.EventHandler(this.deletedoctor_click);
            // 
            // btnviewdoctor
            // 
            this.btnviewdoctor.Location = new System.Drawing.Point(332, 134);
            this.btnviewdoctor.Name = "btnviewdoctor";
            this.btnviewdoctor.Size = new System.Drawing.Size(75, 23);
            this.btnviewdoctor.TabIndex = 13;
            this.btnviewdoctor.Text = "View";
            this.btnviewdoctor.UseVisualStyleBackColor = true;
            this.btnviewdoctor.Click += new System.EventHandler(this.viewdoctor_click);
            // 
            // btnviewsecretary
            // 
            this.btnviewsecretary.Location = new System.Drawing.Point(332, 305);
            this.btnviewsecretary.Name = "btnviewsecretary";
            this.btnviewsecretary.Size = new System.Drawing.Size(75, 23);
            this.btnviewsecretary.TabIndex = 17;
            this.btnviewsecretary.Text = "View";
            this.btnviewsecretary.UseVisualStyleBackColor = true;
            this.btnviewsecretary.Click += new System.EventHandler(this.viewsecretary_click);
            // 
            // btndeletesecretary
            // 
            this.btndeletesecretary.Location = new System.Drawing.Point(222, 305);
            this.btndeletesecretary.Name = "btndeletesecretary";
            this.btndeletesecretary.Size = new System.Drawing.Size(75, 23);
            this.btndeletesecretary.TabIndex = 16;
            this.btndeletesecretary.Text = "Delete";
            this.btndeletesecretary.UseVisualStyleBackColor = true;
            this.btndeletesecretary.Click += new System.EventHandler(this.deletesecretary_click);
            // 
            // btneditsecretary
            // 
            this.btneditsecretary.Location = new System.Drawing.Point(117, 305);
            this.btneditsecretary.Name = "btneditsecretary";
            this.btneditsecretary.Size = new System.Drawing.Size(75, 23);
            this.btneditsecretary.TabIndex = 15;
            this.btneditsecretary.Text = "Edit";
            this.btneditsecretary.UseVisualStyleBackColor = true;
            this.btneditsecretary.Click += new System.EventHandler(this.editsecretary_click);
            // 
            // btnaddsecretary
            // 
            this.btnaddsecretary.Location = new System.Drawing.Point(12, 305);
            this.btnaddsecretary.Name = "btnaddsecretary";
            this.btnaddsecretary.Size = new System.Drawing.Size(75, 23);
            this.btnaddsecretary.TabIndex = 14;
            this.btnaddsecretary.Text = "Add";
            this.btnaddsecretary.UseVisualStyleBackColor = true;
            this.btnaddsecretary.Click += new System.EventHandler(this.addsecretary_click);
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(452, 12);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewDoctor.TabIndex = 18;
            // 
            // dataGridViewSecretary
            // 
            this.dataGridViewSecretary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecretary.Location = new System.Drawing.Point(452, 184);
            this.dataGridViewSecretary.Name = "dataGridViewSecretary";
            this.dataGridViewSecretary.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewSecretary.TabIndex = 19;
            // 
            // textsecretarypassword
            // 
            this.textsecretarypassword.Location = new System.Drawing.Point(242, 236);
            this.textsecretarypassword.Name = "textsecretarypassword";
            this.textsecretarypassword.Size = new System.Drawing.Size(100, 20);
            this.textsecretarypassword.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // textdoctorpassword
            // 
            this.textdoctorpassword.Location = new System.Drawing.Point(242, 74);
            this.textdoctorpassword.Name = "textdoctorpassword";
            this.textdoctorpassword.Size = new System.Drawing.Size(100, 20);
            this.textdoctorpassword.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 352);
            this.Controls.Add(this.textdoctorpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textsecretarypassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewSecretary);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.btnviewsecretary);
            this.Controls.Add(this.btndeletesecretary);
            this.Controls.Add(this.btneditsecretary);
            this.Controls.Add(this.btnaddsecretary);
            this.Controls.Add(this.btnviewdoctor);
            this.Controls.Add(this.btndeletedoctor);
            this.Controls.Add(this.btneditdoctor);
            this.Controls.Add(this.btnadddoctor);
            this.Controls.Add(this.textdoctorname);
            this.Controls.Add(this.textsecretaryname);
            this.Controls.Add(this.textsecretaryid);
            this.Controls.Add(this.textdoctorid);
            this.Controls.Add(this.namesecretarylabel);
            this.Controls.Add(this.idsecretarylabel);
            this.Controls.Add(this.namedoctorlabel);
            this.Controls.Add(this.iddoctorlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecretary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label iddoctorlabel;
        private System.Windows.Forms.Label namedoctorlabel;
        private System.Windows.Forms.Label namesecretarylabel;
        private System.Windows.Forms.Label idsecretarylabel;
        private System.Windows.Forms.TextBox textdoctorid;
        private System.Windows.Forms.TextBox textsecretaryid;
        private System.Windows.Forms.TextBox textsecretaryname;
        private System.Windows.Forms.TextBox textdoctorname;
        private System.Windows.Forms.Button btnadddoctor;
        private System.Windows.Forms.Button btneditdoctor;
        private System.Windows.Forms.Button btndeletedoctor;
        private System.Windows.Forms.Button btnviewdoctor;
        private System.Windows.Forms.Button btnviewsecretary;
        private System.Windows.Forms.Button btndeletesecretary;
        private System.Windows.Forms.Button btneditsecretary;
        private System.Windows.Forms.Button btnaddsecretary;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.DataGridView dataGridViewSecretary;
        private System.Windows.Forms.TextBox textsecretarypassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textdoctorpassword;
        private System.Windows.Forms.Label label4;
    }
}

