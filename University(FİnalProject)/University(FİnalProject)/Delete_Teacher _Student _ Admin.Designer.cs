namespace University_FİnalProject_
{
    partial class Delete_Teacher__Student___Admin
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectFullName = new System.Windows.Forms.ComboBox();
            this.lblErrorFullName = new System.Windows.Forms.Label();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(515, 40);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Delete Selected Admin";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(79, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name*";
            // 
            // cmbSelectFullName
            // 
            this.cmbSelectFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSelectFullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectFullName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectFullName.FormattingEnabled = true;
            this.cmbSelectFullName.Location = new System.Drawing.Point(84, 191);
            this.cmbSelectFullName.Name = "cmbSelectFullName";
            this.cmbSelectFullName.Size = new System.Drawing.Size(340, 35);
            this.cmbSelectFullName.TabIndex = 2;
            // 
            // lblErrorFullName
            // 
            this.lblErrorFullName.AutoSize = true;
            this.lblErrorFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFullName.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorFullName.Location = new System.Drawing.Point(80, 244);
            this.lblErrorFullName.Name = "lblErrorFullName";
            this.lblErrorFullName.Size = new System.Drawing.Size(181, 23);
            this.lblErrorFullName.TabIndex = 9;
            this.lblErrorFullName.Text = "Sorry , fill the field";
            this.lblErrorFullName.Visible = false;
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.btnCreateTeacher.Location = new System.Drawing.Point(84, 316);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(340, 46);
            this.btnCreateTeacher.TabIndex = 28;
            this.btnCreateTeacher.Text = "DELETE";
            this.btnCreateTeacher.UseVisualStyleBackColor = true;
            this.btnCreateTeacher.Click += new System.EventHandler(this.btnCreateTeacher_Click);
            // 
            // Delete_Teacher__Student___Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(515, 517);
            this.Controls.Add(this.btnCreateTeacher);
            this.Controls.Add(this.lblErrorFullName);
            this.Controls.Add(this.cmbSelectFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Name = "Delete_Teacher__Student___Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Teacher__Student___Admin";
            this.Load += new System.EventHandler(this.Delete_Teacher__Student___Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectFullName;
        private System.Windows.Forms.Label lblErrorFullName;
        private System.Windows.Forms.Button btnCreateTeacher;
    }
}