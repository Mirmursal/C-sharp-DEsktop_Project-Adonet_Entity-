namespace University_FİnalProject_
{
    partial class Question
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIncorrect1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIncorrect2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIncorrect3 = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblErrorSubject = new System.Windows.Forms.Label();
            this.lblErrorContent = new System.Windows.Forms.Label();
            this.lblErrorCorrect = new System.Windows.Forms.Label();
            this.lblErrorIncorrect1 = new System.Windows.Forms.Label();
            this.lblErrorIncorrect2 = new System.Windows.Forms.Label();
            this.lblErrorIncorrect3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1039, 45);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Add New Questions";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(66, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Subject*";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(71, 116);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(258, 35);
            this.cmbSubject.TabIndex = 3;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtContent.Location = new System.Drawing.Point(71, 237);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(874, 166);
            this.rtxtContent.TabIndex = 4;
            this.rtxtContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(66, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Question Content*";
            // 
            // txtCorrect
            // 
            this.txtCorrect.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrect.Location = new System.Drawing.Point(71, 486);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(318, 36);
            this.txtCorrect.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(66, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correct*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(625, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Incorrect*";
            // 
            // txtIncorrect1
            // 
            this.txtIncorrect1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncorrect1.Location = new System.Drawing.Point(630, 486);
            this.txtIncorrect1.Name = "txtIncorrect1";
            this.txtIncorrect1.Size = new System.Drawing.Size(318, 36);
            this.txtIncorrect1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(66, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Incorrect*";
            // 
            // txtIncorrect2
            // 
            this.txtIncorrect2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncorrect2.Location = new System.Drawing.Point(71, 590);
            this.txtIncorrect2.Name = "txtIncorrect2";
            this.txtIncorrect2.Size = new System.Drawing.Size(318, 36);
            this.txtIncorrect2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(625, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Incorrect*";
            // 
            // txtIncorrect3
            // 
            this.txtIncorrect3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncorrect3.Location = new System.Drawing.Point(630, 590);
            this.txtIncorrect3.Name = "txtIncorrect3";
            this.txtIncorrect3.Size = new System.Drawing.Size(318, 36);
            this.txtIncorrect3.TabIndex = 12;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.btnCreate.Location = new System.Drawing.Point(380, 659);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(249, 55);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblErrorSubject
            // 
            this.lblErrorSubject.AutoSize = true;
            this.lblErrorSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSubject.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorSubject.Location = new System.Drawing.Point(67, 154);
            this.lblErrorSubject.Name = "lblErrorSubject";
            this.lblErrorSubject.Size = new System.Drawing.Size(181, 23);
            this.lblErrorSubject.TabIndex = 15;
            this.lblErrorSubject.Text = "Sorry , fill the field";
            this.lblErrorSubject.Visible = false;
            // 
            // lblErrorContent
            // 
            this.lblErrorContent.AutoSize = true;
            this.lblErrorContent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContent.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorContent.Location = new System.Drawing.Point(67, 406);
            this.lblErrorContent.Name = "lblErrorContent";
            this.lblErrorContent.Size = new System.Drawing.Size(181, 23);
            this.lblErrorContent.TabIndex = 16;
            this.lblErrorContent.Text = "Sorry , fill the field";
            this.lblErrorContent.Visible = false;
            // 
            // lblErrorCorrect
            // 
            this.lblErrorCorrect.AutoSize = true;
            this.lblErrorCorrect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCorrect.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorCorrect.Location = new System.Drawing.Point(67, 525);
            this.lblErrorCorrect.Name = "lblErrorCorrect";
            this.lblErrorCorrect.Size = new System.Drawing.Size(181, 23);
            this.lblErrorCorrect.TabIndex = 17;
            this.lblErrorCorrect.Text = "Sorry , fill the field";
            this.lblErrorCorrect.Visible = false;
            // 
            // lblErrorIncorrect1
            // 
            this.lblErrorIncorrect1.AutoSize = true;
            this.lblErrorIncorrect1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIncorrect1.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorIncorrect1.Location = new System.Drawing.Point(626, 525);
            this.lblErrorIncorrect1.Name = "lblErrorIncorrect1";
            this.lblErrorIncorrect1.Size = new System.Drawing.Size(181, 23);
            this.lblErrorIncorrect1.TabIndex = 18;
            this.lblErrorIncorrect1.Text = "Sorry , fill the field";
            this.lblErrorIncorrect1.Visible = false;
            // 
            // lblErrorIncorrect2
            // 
            this.lblErrorIncorrect2.AutoSize = true;
            this.lblErrorIncorrect2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIncorrect2.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorIncorrect2.Location = new System.Drawing.Point(67, 629);
            this.lblErrorIncorrect2.Name = "lblErrorIncorrect2";
            this.lblErrorIncorrect2.Size = new System.Drawing.Size(181, 23);
            this.lblErrorIncorrect2.TabIndex = 19;
            this.lblErrorIncorrect2.Text = "Sorry , fill the field";
            this.lblErrorIncorrect2.Visible = false;
            // 
            // lblErrorIncorrect3
            // 
            this.lblErrorIncorrect3.AutoSize = true;
            this.lblErrorIncorrect3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIncorrect3.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorIncorrect3.Location = new System.Drawing.Point(626, 633);
            this.lblErrorIncorrect3.Name = "lblErrorIncorrect3";
            this.lblErrorIncorrect3.Size = new System.Drawing.Size(181, 23);
            this.lblErrorIncorrect3.TabIndex = 20;
            this.lblErrorIncorrect3.Text = "Sorry , fill the field";
            this.lblErrorIncorrect3.Visible = false;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1039, 764);
            this.Controls.Add(this.lblErrorIncorrect3);
            this.Controls.Add(this.lblErrorIncorrect2);
            this.Controls.Add(this.lblErrorIncorrect1);
            this.Controls.Add(this.lblErrorCorrect);
            this.Controls.Add(this.lblErrorContent);
            this.Controls.Add(this.lblErrorSubject);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIncorrect3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIncorrect2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIncorrect1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIncorrect1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIncorrect2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIncorrect3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblErrorSubject;
        private System.Windows.Forms.Label lblErrorContent;
        private System.Windows.Forms.Label lblErrorCorrect;
        private System.Windows.Forms.Label lblErrorIncorrect1;
        private System.Windows.Forms.Label lblErrorIncorrect2;
        private System.Windows.Forms.Label lblErrorIncorrect3;
    }
}