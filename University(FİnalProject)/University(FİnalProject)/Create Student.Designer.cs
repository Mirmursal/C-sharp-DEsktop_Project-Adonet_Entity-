namespace University_FİnalProject_
{
    partial class Create_Student
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblErrorGroup = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblErrorTeachPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrorTeachIdenty = new System.Windows.Forms.Label();
            this.txtIdenti = new System.Windows.Forms.TextBox();
            this.lblErrorTeachGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErrorTeachAge = new System.Windows.Forms.Label();
            this.nmAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblErrorTeachEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblErrorTeachName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorTeachSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblErrorGroup);
            this.pnlBody.Controls.Add(this.label10);
            this.pnlBody.Controls.Add(this.cmbGroup);
            this.pnlBody.Controls.Add(this.label9);
            this.pnlBody.Controls.Add(this.txtConPass);
            this.pnlBody.Controls.Add(this.btnCreateStudent);
            this.pnlBody.Controls.Add(this.label8);
            this.pnlBody.Controls.Add(this.lblErrorTeachPass);
            this.pnlBody.Controls.Add(this.txtPass);
            this.pnlBody.Controls.Add(this.label7);
            this.pnlBody.Controls.Add(this.lblErrorTeachIdenty);
            this.pnlBody.Controls.Add(this.txtIdenti);
            this.pnlBody.Controls.Add(this.lblErrorTeachGender);
            this.pnlBody.Controls.Add(this.cmbGender);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.lblErrorTeachAge);
            this.pnlBody.Controls.Add(this.nmAge);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.txtName);
            this.pnlBody.Controls.Add(this.lblErrorTeachEmail);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.txtEmail);
            this.pnlBody.Controls.Add(this.lblErrorTeachName);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.lblErrorTeachSurname);
            this.pnlBody.Controls.Add(this.txtSurname);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 50);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1264, 809);
            this.pnlBody.TabIndex = 2;
            // 
            // lblErrorGroup
            // 
            this.lblErrorGroup.AutoSize = true;
            this.lblErrorGroup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGroup.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorGroup.Location = new System.Drawing.Point(122, 694);
            this.lblErrorGroup.Name = "lblErrorGroup";
            this.lblErrorGroup.Size = new System.Drawing.Size(181, 23);
            this.lblErrorGroup.TabIndex = 80;
            this.lblErrorGroup.Text = "Sorry , fill the field";
            this.lblErrorGroup.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(121, 615);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 28);
            this.label10.TabIndex = 79;
            this.label10.Text = "Choose Group*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(126, 656);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(422, 35);
            this.cmbGroup.TabIndex = 78;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(687, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 28);
            this.label9.TabIndex = 77;
            this.label9.Text = "Confirm Password*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPass.Location = new System.Drawing.Point(692, 508);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(422, 36);
            this.txtConPass.TabIndex = 76;
            this.txtConPass.UseSystemPasswordChar = true;
            this.txtConPass.TextChanged += new System.EventHandler(this.txtConPass_TextChanged);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudent.Location = new System.Drawing.Point(692, 645);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(422, 46);
            this.btnCreateStudent.TabIndex = 75;
            this.btnCreateStudent.Text = "CREATE";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(121, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 28);
            this.label8.TabIndex = 73;
            this.label8.Text = "Password*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblErrorTeachPass
            // 
            this.lblErrorTeachPass.AutoSize = true;
            this.lblErrorTeachPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeachPass.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorTeachPass.Location = new System.Drawing.Point(122, 557);
            this.lblErrorTeachPass.Name = "lblErrorTeachPass";
            this.lblErrorTeachPass.Size = new System.Drawing.Size(181, 23);
            this.lblErrorTeachPass.TabIndex = 74;
            this.lblErrorTeachPass.Text = "Sorry , fill the field";
            this.lblErrorTeachPass.Visible = false;
            this.lblErrorTeachPass.Click += new System.EventHandler(this.lblErrorTeachPass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(126, 508);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(422, 36);
            this.txtPass.TabIndex = 72;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(687, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 28);
            this.label7.TabIndex = 70;
            this.label7.Text = "Identification*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblErrorTeachIdenty
            // 
            this.lblErrorTeachIdenty.AutoSize = true;
            this.lblErrorTeachIdenty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeachIdenty.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorTeachIdenty.Location = new System.Drawing.Point(688, 426);
            this.lblErrorTeachIdenty.Name = "lblErrorTeachIdenty";
            this.lblErrorTeachIdenty.Size = new System.Drawing.Size(181, 23);
            this.lblErrorTeachIdenty.TabIndex = 71;
            this.lblErrorTeachIdenty.Text = "Sorry , fill the field";
            this.lblErrorTeachIdenty.Visible = false;
            this.lblErrorTeachIdenty.Click += new System.EventHandler(this.lblErrorTeachIdenty_Click);
            // 
            // txtIdenti
            // 
            this.txtIdenti.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdenti.Location = new System.Drawing.Point(692, 375);
            this.txtIdenti.Name = "txtIdenti";
            this.txtIdenti.Size = new System.Drawing.Size(422, 36);
            this.txtIdenti.TabIndex = 69;
            this.txtIdenti.TextChanged += new System.EventHandler(this.txtIdenti_TextChanged);
            // 
            // lblErrorTeachGender
            // 
            this.lblErrorTeachGender.AutoSize = true;
            this.lblErrorTeachGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeachGender.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorTeachGender.Location = new System.Drawing.Point(122, 426);
            this.lblErrorTeachGender.Name = "lblErrorTeachGender";
            this.lblErrorTeachGender.Size = new System.Drawing.Size(181, 23);
            this.lblErrorTeachGender.TabIndex = 68;
            this.lblErrorTeachGender.Text = "Sorry , fill the field";
            this.lblErrorTeachGender.Visible = false;
            this.lblErrorTeachGender.Click += new System.EventHandler(this.lblErrorTeachGender_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(126, 375);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(422, 35);
            this.cmbGender.TabIndex = 67;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(121, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 66;
            this.label6.Text = "Gender*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblErrorTeachAge
            // 
            this.lblErrorTeachAge.AutoSize = true;
            this.lblErrorTeachAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeachAge.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorTeachAge.Location = new System.Drawing.Point(688, 283);
            this.lblErrorTeachAge.Name = "lblErrorTeachAge";
            this.lblErrorTeachAge.Size = new System.Drawing.Size(181, 23);
            this.lblErrorTeachAge.TabIndex = 65;
            this.lblErrorTeachAge.Text = "Sorry , fill the field";
            this.lblErrorTeachAge.Visible = false;
            this.lblErrorTeachAge.Click += new System.EventHandler(this.lblErrorTeachAge_Click);
            // 
            // nmAge
            // 
            this.nmAge.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmAge.Location = new System.Drawing.Point(692, 235);
            this.nmAge.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmAge.Name = "nmAge";
            this.nmAge.Size = new System.Drawing.Size(422, 36);
            this.nmAge.TabIndex = 64;
            this.nmAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nmAge.ValueChanged += new System.EventHandler(this.nmAge_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(687, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 63;
            this.label3.Text = "Age*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(422, 36);
            this.txtName.TabIndex = 54;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblErrorTeachEmail
            // 
            this.lblErrorTeachEmail.AutoSize = true;
            this.lblErrorTeachEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeachEmail.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorTeachEmail.Location = new System.Drawing.Point(122, 283);
            this.lblErrorTeachEmail.Name = "lblErrorTeachEmail";
            this.lblErrorTeachEmail.Size = new System.Drawing.Size(181, 23);
            this.lblErrorTeachEmail.TabIndex = 62;
            this.lblErrorTeachEmail.Text = "Sorry , fill the field";
            this.lblErrorTeachEmail.Visible = false;
            this.lblErrorTeachEmail.Click += new System.EventHandler(this.lblErrorTeachEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(121, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "Name*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(126, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(422, 36);
            this.txtEmail.TabIndex = 60;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblErrorTeachName
            // 
            this.lblErrorTeachName.AutoSize = true;
            this.lblErrorTeachName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeachName.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorTeachName.Location = new System.Drawing.Point(122, 143);
            this.lblErrorTeachName.Name = "lblErrorTeachName";
            this.lblErrorTeachName.Size = new System.Drawing.Size(181, 23);
            this.lblErrorTeachName.TabIndex = 56;
            this.lblErrorTeachName.Text = "Sorry , fill the field";
            this.lblErrorTeachName.Visible = false;
            this.lblErrorTeachName.Click += new System.EventHandler(this.lblErrorTeachName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(121, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 61;
            this.label5.Text = "Email*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(687, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 58;
            this.label4.Text = "Surname*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblErrorTeachSurname
            // 
            this.lblErrorTeachSurname.AutoSize = true;
            this.lblErrorTeachSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeachSurname.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorTeachSurname.Location = new System.Drawing.Point(688, 143);
            this.lblErrorTeachSurname.Name = "lblErrorTeachSurname";
            this.lblErrorTeachSurname.Size = new System.Drawing.Size(181, 23);
            this.lblErrorTeachSurname.TabIndex = 59;
            this.lblErrorTeachSurname.Text = "Sorry , fill the field";
            this.lblErrorTeachSurname.Visible = false;
            this.lblErrorTeachSurname.Click += new System.EventHandler(this.lblErrorTeachSurname_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(692, 94);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(422, 36);
            this.txtSurname.TabIndex = 57;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // Create_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1264, 859);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.label1);
            this.Name = "Create_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_Student";
            this.Load += new System.EventHandler(this.Create_Student_Load);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErrorTeachPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblErrorTeachIdenty;
        private System.Windows.Forms.TextBox txtIdenti;
        private System.Windows.Forms.Label lblErrorTeachGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblErrorTeachAge;
        private System.Windows.Forms.NumericUpDown nmAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblErrorTeachEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblErrorTeachName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorTeachSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblErrorGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGroup;
    }
}