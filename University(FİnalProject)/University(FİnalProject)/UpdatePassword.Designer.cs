namespace University_FİnalProject_
{
    partial class UpdatePassword
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
            this.cmbChooseName = new System.Windows.Forms.ComboBox();
            this.lblErrorFullName = new System.Windows.Forms.Label();
            this.lblErrorOldPass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorNewPass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblHeading.Size = new System.Drawing.Size(639, 59);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Update Admin Password";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(134, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Name*";
            // 
            // cmbChooseName
            // 
            this.cmbChooseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChooseName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChooseName.FormattingEnabled = true;
            this.cmbChooseName.Location = new System.Drawing.Point(140, 167);
            this.cmbChooseName.Name = "cmbChooseName";
            this.cmbChooseName.Size = new System.Drawing.Size(385, 35);
            this.cmbChooseName.TabIndex = 2;
            // 
            // lblErrorFullName
            // 
            this.lblErrorFullName.AutoSize = true;
            this.lblErrorFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFullName.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorFullName.Location = new System.Drawing.Point(136, 215);
            this.lblErrorFullName.Name = "lblErrorFullName";
            this.lblErrorFullName.Size = new System.Drawing.Size(181, 23);
            this.lblErrorFullName.TabIndex = 10;
            this.lblErrorFullName.Text = "Sorry , fill the field";
            this.lblErrorFullName.Visible = false;
            // 
            // lblErrorOldPass
            // 
            this.lblErrorOldPass.AutoSize = true;
            this.lblErrorOldPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOldPass.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorOldPass.Location = new System.Drawing.Point(136, 382);
            this.lblErrorOldPass.Name = "lblErrorOldPass";
            this.lblErrorOldPass.Size = new System.Drawing.Size(181, 23);
            this.lblErrorOldPass.TabIndex = 13;
            this.lblErrorOldPass.Text = "Sorry , fill the field";
            this.lblErrorOldPass.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(134, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Old Password*";
            // 
            // lblErrorNewPass
            // 
            this.lblErrorNewPass.AutoSize = true;
            this.lblErrorNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNewPass.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorNewPass.Location = new System.Drawing.Point(136, 548);
            this.lblErrorNewPass.Name = "lblErrorNewPass";
            this.lblErrorNewPass.Size = new System.Drawing.Size(181, 23);
            this.lblErrorNewPass.TabIndex = 16;
            this.lblErrorNewPass.Text = "Sorry , fill the field";
            this.lblErrorNewPass.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(134, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "New Password*";
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.btnUpdatePass.Location = new System.Drawing.Point(140, 614);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(385, 46);
            this.btnUpdatePass.TabIndex = 29;
            this.btnUpdatePass.Text = "UPDATE";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(140, 329);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(385, 36);
            this.txtOldPass.TabIndex = 30;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(140, 509);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(385, 36);
            this.txtNewPass.TabIndex = 31;
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(639, 733);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.btnUpdatePass);
            this.Controls.Add(this.lblErrorNewPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblErrorOldPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrorFullName);
            this.Controls.Add(this.cmbChooseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePassword";
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChooseName;
        private System.Windows.Forms.Label lblErrorFullName;
        private System.Windows.Forms.Label lblErrorOldPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorNewPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
    }
}