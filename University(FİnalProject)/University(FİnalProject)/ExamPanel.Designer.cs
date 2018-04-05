namespace University_FİnalProject_
{
    partial class ExamPanel
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
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.lblSubName = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblErrorSubject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(87, 178);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(333, 41);
            this.cmbSubject.TabIndex = 5;
            // 
            // btnStartExam
            // 
            this.btnStartExam.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.btnStartExam.Location = new System.Drawing.Point(87, 325);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(333, 54);
            this.btnStartExam.TabIndex = 4;
            this.btnStartExam.Text = "START EXAM";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // lblSubName
            // 
            this.lblSubName.AutoSize = true;
            this.lblSubName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubName.Location = new System.Drawing.Point(82, 145);
            this.lblSubName.Name = "lblSubName";
            this.lblSubName.Size = new System.Drawing.Size(211, 30);
            this.lblSubName.TabIndex = 3;
            this.lblSubName.Text = "Choose Subject*";
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblHeading.Size = new System.Drawing.Size(502, 104);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "filankes filankesov choose exam";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorSubject
            // 
            this.lblErrorSubject.AutoSize = true;
            this.lblErrorSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSubject.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorSubject.Location = new System.Drawing.Point(83, 222);
            this.lblErrorSubject.Name = "lblErrorSubject";
            this.lblErrorSubject.Size = new System.Drawing.Size(181, 23);
            this.lblErrorSubject.TabIndex = 9;
            this.lblErrorSubject.Text = "Sorry , fill the field";
            this.lblErrorSubject.Visible = false;
            // 
            // ExamPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(502, 519);
            this.Controls.Add(this.lblErrorSubject);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.lblSubName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ExamPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamPanel";
            this.Load += new System.EventHandler(this.ExamPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Label lblSubName;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblErrorSubject;
    }
}