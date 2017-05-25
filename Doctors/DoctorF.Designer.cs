namespace Doctors
{
    partial class DoctorF
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpAppoinment = new System.Windows.Forms.DateTimePicker();
            this.texticn = new System.Windows.Forms.TextBox();
            this.dataGridViewConsult = new System.Windows.Forms.DataGridView();
            this.btnviewconsult = new System.Windows.Forms.Button();
            this.btnaddconsult = new System.Windows.Forms.Button();
            this.textconsultdoctorid = new System.Windows.Forms.TextBox();
            this.textconsultationid = new System.Windows.Forms.TextBox();
            this.namesecretarylabel = new System.Windows.Forms.Label();
            this.idsecretarylabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Appoinment:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Identity card number:";
            // 
            // dtpAppoinment
            // 
            this.dtpAppoinment.Location = new System.Drawing.Point(136, 72);
            this.dtpAppoinment.Name = "dtpAppoinment";
            this.dtpAppoinment.Size = new System.Drawing.Size(118, 20);
            this.dtpAppoinment.TabIndex = 61;
            // 
            // texticn
            // 
            this.texticn.Location = new System.Drawing.Point(136, 124);
            this.texticn.Name = "texticn";
            this.texticn.Size = new System.Drawing.Size(100, 20);
            this.texticn.TabIndex = 60;
            // 
            // dataGridViewConsult
            // 
            this.dataGridViewConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsult.Location = new System.Drawing.Point(20, 210);
            this.dataGridViewConsult.Name = "dataGridViewConsult";
            this.dataGridViewConsult.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewConsult.TabIndex = 59;
            this.dataGridViewConsult.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // btnviewconsult
            // 
            this.btnviewconsult.Location = new System.Drawing.Point(140, 158);
            this.btnviewconsult.Name = "btnviewconsult";
            this.btnviewconsult.Size = new System.Drawing.Size(75, 23);
            this.btnviewconsult.TabIndex = 58;
            this.btnviewconsult.Text = "View";
            this.btnviewconsult.UseVisualStyleBackColor = true;
            this.btnviewconsult.Click += new System.EventHandler(this.btnviewconsult_click);
            // 
            // btnaddconsult
            // 
            this.btnaddconsult.Location = new System.Drawing.Point(18, 158);
            this.btnaddconsult.Name = "btnaddconsult";
            this.btnaddconsult.Size = new System.Drawing.Size(75, 23);
            this.btnaddconsult.TabIndex = 55;
            this.btnaddconsult.Text = "Add";
            this.btnaddconsult.UseVisualStyleBackColor = true;
            this.btnaddconsult.Click += new System.EventHandler(this.btnaddconsult_click);
            // 
            // textconsultdoctorid
            // 
            this.textconsultdoctorid.Location = new System.Drawing.Point(136, 98);
            this.textconsultdoctorid.Name = "textconsultdoctorid";
            this.textconsultdoctorid.Size = new System.Drawing.Size(100, 20);
            this.textconsultdoctorid.TabIndex = 54;
            // 
            // textconsultationid
            // 
            this.textconsultationid.Location = new System.Drawing.Point(136, 42);
            this.textconsultationid.Name = "textconsultationid";
            this.textconsultationid.Size = new System.Drawing.Size(100, 20);
            this.textconsultationid.TabIndex = 53;
            // 
            // namesecretarylabel
            // 
            this.namesecretarylabel.AutoSize = true;
            this.namesecretarylabel.Location = new System.Drawing.Point(17, 98);
            this.namesecretarylabel.Name = "namesecretarylabel";
            this.namesecretarylabel.Size = new System.Drawing.Size(56, 13);
            this.namesecretarylabel.TabIndex = 52;
            this.namesecretarylabel.Text = "Doctor ID:";
            // 
            // idsecretarylabel
            // 
            this.idsecretarylabel.AutoSize = true;
            this.idsecretarylabel.Location = new System.Drawing.Point(17, 42);
            this.idsecretarylabel.Name = "idsecretarylabel";
            this.idsecretarylabel.Size = new System.Drawing.Size(21, 13);
            this.idsecretarylabel.TabIndex = 51;
            this.idsecretarylabel.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Consultation:";
            // 
            // DoctorF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 372);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpAppoinment);
            this.Controls.Add(this.texticn);
            this.Controls.Add(this.dataGridViewConsult);
            this.Controls.Add(this.btnviewconsult);
            this.Controls.Add(this.btnaddconsult);
            this.Controls.Add(this.textconsultdoctorid);
            this.Controls.Add(this.textconsultationid);
            this.Controls.Add(this.namesecretarylabel);
            this.Controls.Add(this.idsecretarylabel);
            this.Controls.Add(this.label1);
            this.Name = "DoctorF";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpAppoinment;
        private System.Windows.Forms.TextBox texticn;
        private System.Windows.Forms.DataGridView dataGridViewConsult;
        private System.Windows.Forms.Button btnviewconsult;
        private System.Windows.Forms.Button btnaddconsult;
        private System.Windows.Forms.TextBox textconsultdoctorid;
        private System.Windows.Forms.TextBox textconsultationid;
        private System.Windows.Forms.Label namesecretarylabel;
        private System.Windows.Forms.Label idsecretarylabel;
        private System.Windows.Forms.Label label1;
    }
}

