namespace ClinicSecretary
{
    partial class SecretaryF
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
            this.dataGridViewConsultation = new System.Windows.Forms.DataGridView();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.btnviewconsultation = new System.Windows.Forms.Button();
            this.btndeleteconsultation = new System.Windows.Forms.Button();
            this.btneditconsultation = new System.Windows.Forms.Button();
            this.btnaddconsultation = new System.Windows.Forms.Button();
            this.btnviewpatient = new System.Windows.Forms.Button();
            this.btneditpatient = new System.Windows.Forms.Button();
            this.btnaddpatient = new System.Windows.Forms.Button();
            this.texticd = new System.Windows.Forms.TextBox();
            this.textdoctorid = new System.Windows.Forms.TextBox();
            this.textconsultid = new System.Windows.Forms.TextBox();
            this.textpatientname = new System.Windows.Forms.TextBox();
            this.namesecretarylabel = new System.Windows.Forms.Label();
            this.idsecretarylabel = new System.Windows.Forms.Label();
            this.namedoctorlabel = new System.Windows.Forms.Label();
            this.iddoctorlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textpatientaddress = new System.Windows.Forms.TextBox();
            this.textpnc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.texticd1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsultation
            // 
            this.dataGridViewConsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultation.Location = new System.Drawing.Point(465, 234);
            this.dataGridViewConsultation.Name = "dataGridViewConsultation";
            this.dataGridViewConsultation.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewConsultation.TabIndex = 39;
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(465, 26);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPatient.TabIndex = 38;
            // 
            // btnviewconsultation
            // 
            this.btnviewconsultation.Location = new System.Drawing.Point(345, 355);
            this.btnviewconsultation.Name = "btnviewconsultation";
            this.btnviewconsultation.Size = new System.Drawing.Size(75, 23);
            this.btnviewconsultation.TabIndex = 37;
            this.btnviewconsultation.Text = "View";
            this.btnviewconsultation.UseVisualStyleBackColor = true;
            this.btnviewconsultation.Click += new System.EventHandler(this.btnviewconsultation_click);
            // 
            // btndeleteconsultation
            // 
            this.btndeleteconsultation.Location = new System.Drawing.Point(235, 355);
            this.btndeleteconsultation.Name = "btndeleteconsultation";
            this.btndeleteconsultation.Size = new System.Drawing.Size(75, 23);
            this.btndeleteconsultation.TabIndex = 36;
            this.btndeleteconsultation.Text = "Delete";
            this.btndeleteconsultation.UseVisualStyleBackColor = true;
            this.btndeleteconsultation.Click += new System.EventHandler(this.btndeleteconsultation_click);
            // 
            // btneditconsultation
            // 
            this.btneditconsultation.Location = new System.Drawing.Point(130, 355);
            this.btneditconsultation.Name = "btneditconsultation";
            this.btneditconsultation.Size = new System.Drawing.Size(75, 23);
            this.btneditconsultation.TabIndex = 35;
            this.btneditconsultation.Text = "Edit";
            this.btneditconsultation.UseVisualStyleBackColor = true;
            this.btneditconsultation.Click += new System.EventHandler(this.btneditconsultation_click);
            // 
            // btnaddconsultation
            // 
            this.btnaddconsultation.Location = new System.Drawing.Point(25, 355);
            this.btnaddconsultation.Name = "btnaddconsultation";
            this.btnaddconsultation.Size = new System.Drawing.Size(75, 23);
            this.btnaddconsultation.TabIndex = 34;
            this.btnaddconsultation.Text = "Add";
            this.btnaddconsultation.UseVisualStyleBackColor = true;
            this.btnaddconsultation.Click += new System.EventHandler(this.btnaddconsultation_click);
            // 
            // btnviewpatient
            // 
            this.btnviewpatient.Location = new System.Drawing.Point(235, 175);
            this.btnviewpatient.Name = "btnviewpatient";
            this.btnviewpatient.Size = new System.Drawing.Size(75, 23);
            this.btnviewpatient.TabIndex = 33;
            this.btnviewpatient.Text = "View";
            this.btnviewpatient.UseVisualStyleBackColor = true;
            this.btnviewpatient.Click += new System.EventHandler(this.btnviewpatient_click);
            // 
            // btneditpatient
            // 
            this.btneditpatient.Location = new System.Drawing.Point(130, 175);
            this.btneditpatient.Name = "btneditpatient";
            this.btneditpatient.Size = new System.Drawing.Size(75, 23);
            this.btneditpatient.TabIndex = 31;
            this.btneditpatient.Text = "Edit";
            this.btneditpatient.UseVisualStyleBackColor = true;
            this.btneditpatient.Click += new System.EventHandler(this.btneditpatient_click);
            // 
            // btnaddpatient
            // 
            this.btnaddpatient.Location = new System.Drawing.Point(25, 175);
            this.btnaddpatient.Name = "btnaddpatient";
            this.btnaddpatient.Size = new System.Drawing.Size(75, 23);
            this.btnaddpatient.TabIndex = 30;
            this.btnaddpatient.Text = "Add";
            this.btnaddpatient.UseVisualStyleBackColor = true;
            this.btnaddpatient.Click += new System.EventHandler(this.btnaddpatient_click);
            // 
            // texticd
            // 
            this.texticd.Location = new System.Drawing.Point(320, 62);
            this.texticd.Name = "texticd";
            this.texticd.Size = new System.Drawing.Size(100, 20);
            this.texticd.TabIndex = 29;
            // 
            // textdoctorid
            // 
            this.textdoctorid.Location = new System.Drawing.Point(320, 286);
            this.textdoctorid.Name = "textdoctorid";
            this.textdoctorid.Size = new System.Drawing.Size(100, 20);
            this.textdoctorid.TabIndex = 28;
            // 
            // textconsultid
            // 
            this.textconsultid.Location = new System.Drawing.Point(320, 230);
            this.textconsultid.Name = "textconsultid";
            this.textconsultid.Size = new System.Drawing.Size(100, 20);
            this.textconsultid.TabIndex = 27;
            // 
            // textpatientname
            // 
            this.textpatientname.Location = new System.Drawing.Point(320, 36);
            this.textpatientname.Name = "textpatientname";
            this.textpatientname.Size = new System.Drawing.Size(100, 20);
            this.textpatientname.TabIndex = 26;
            // 
            // namesecretarylabel
            // 
            this.namesecretarylabel.AutoSize = true;
            this.namesecretarylabel.Location = new System.Drawing.Point(201, 286);
            this.namesecretarylabel.Name = "namesecretarylabel";
            this.namesecretarylabel.Size = new System.Drawing.Size(56, 13);
            this.namesecretarylabel.TabIndex = 25;
            this.namesecretarylabel.Text = "Doctor ID:";
            // 
            // idsecretarylabel
            // 
            this.idsecretarylabel.AutoSize = true;
            this.idsecretarylabel.Location = new System.Drawing.Point(201, 230);
            this.idsecretarylabel.Name = "idsecretarylabel";
            this.idsecretarylabel.Size = new System.Drawing.Size(21, 13);
            this.idsecretarylabel.TabIndex = 24;
            this.idsecretarylabel.Text = "ID:";
            // 
            // namedoctorlabel
            // 
            this.namedoctorlabel.AutoSize = true;
            this.namedoctorlabel.Location = new System.Drawing.Point(184, 62);
            this.namedoctorlabel.Name = "namedoctorlabel";
            this.namedoctorlabel.Size = new System.Drawing.Size(106, 13);
            this.namedoctorlabel.TabIndex = 23;
            this.namedoctorlabel.Text = "Identity card number:";
            // 
            // iddoctorlabel
            // 
            this.iddoctorlabel.AutoSize = true;
            this.iddoctorlabel.Location = new System.Drawing.Point(184, 36);
            this.iddoctorlabel.Name = "iddoctorlabel";
            this.iddoctorlabel.Size = new System.Drawing.Size(38, 13);
            this.iddoctorlabel.TabIndex = 22;
            this.iddoctorlabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Patient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consultation:";
            // 
            // textpatientaddress
            // 
            this.textpatientaddress.Location = new System.Drawing.Point(320, 140);
            this.textpatientaddress.Name = "textpatientaddress";
            this.textpatientaddress.Size = new System.Drawing.Size(100, 20);
            this.textpatientaddress.TabIndex = 41;
            // 
            // textpnc
            // 
            this.textpnc.Location = new System.Drawing.Point(320, 88);
            this.textpnc.Name = "textpnc";
            this.textpnc.Size = new System.Drawing.Size(100, 20);
            this.textpnc.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Date of birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Personal numerical code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Address:";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(320, 114);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(118, 20);
            this.dtpBirth.TabIndex = 45;
            // 
            // texticd1
            // 
            this.texticd1.Location = new System.Drawing.Point(320, 312);
            this.texticd1.Name = "texticd1";
            this.texticd1.Size = new System.Drawing.Size(100, 20);
            this.texticd1.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Appointment:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Identity card number:";
            // 
            // textc
            // 
            this.textc.Location = new System.Drawing.Point(320, 260);
            this.textc.Name = "textc";
            this.textc.Size = new System.Drawing.Size(100, 20);
            this.textc.TabIndex = 50;
            this.textc.TextChanged += new System.EventHandler(this.textc_TextChanged);
            // 
            // SecretaryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 395);
            this.Controls.Add(this.textc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.texticd1);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpatientaddress);
            this.Controls.Add(this.textpnc);
            this.Controls.Add(this.dataGridViewConsultation);
            this.Controls.Add(this.dataGridViewPatient);
            this.Controls.Add(this.btnviewconsultation);
            this.Controls.Add(this.btndeleteconsultation);
            this.Controls.Add(this.btneditconsultation);
            this.Controls.Add(this.btnaddconsultation);
            this.Controls.Add(this.btnviewpatient);
            this.Controls.Add(this.btneditpatient);
            this.Controls.Add(this.btnaddpatient);
            this.Controls.Add(this.texticd);
            this.Controls.Add(this.textdoctorid);
            this.Controls.Add(this.textconsultid);
            this.Controls.Add(this.textpatientname);
            this.Controls.Add(this.namesecretarylabel);
            this.Controls.Add(this.idsecretarylabel);
            this.Controls.Add(this.namedoctorlabel);
            this.Controls.Add(this.iddoctorlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SecretaryF";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SecretaryF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConsultation;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.Button btnviewconsultation;
        private System.Windows.Forms.Button btndeleteconsultation;
        private System.Windows.Forms.Button btneditconsultation;
        private System.Windows.Forms.Button btnaddconsultation;
        private System.Windows.Forms.Button btnviewpatient;
        private System.Windows.Forms.Button btneditpatient;
        private System.Windows.Forms.Button btnaddpatient;
        private System.Windows.Forms.TextBox texticd;
        private System.Windows.Forms.TextBox textdoctorid;
        private System.Windows.Forms.TextBox textconsultid;
        private System.Windows.Forms.TextBox textpatientname;
        private System.Windows.Forms.Label namesecretarylabel;
        private System.Windows.Forms.Label idsecretarylabel;
        private System.Windows.Forms.Label namedoctorlabel;
        private System.Windows.Forms.Label iddoctorlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpatientaddress;
        private System.Windows.Forms.TextBox textpnc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox texticd1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textc;
    }
}

