namespace University_FİnalProject_
{
    partial class Exam
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
            this.pnlExQues = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnIncorrect2 = new System.Windows.Forms.Button();
            this.btnIncorrect1 = new System.Windows.Forms.Button();
            this.btnIncorrect3 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblActiveQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblCountPoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountIncAnsw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountCorAnsw = new System.Windows.Forms.Label();
            this.lblCorrectAnsw = new System.Windows.Forms.Label();
            this.pnlExQues.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExQues
            // 
            this.pnlExQues.Controls.Add(this.lblError);
            this.pnlExQues.Controls.Add(this.btnExit);
            this.pnlExQues.Controls.Add(this.pnlButton);
            this.pnlExQues.Controls.Add(this.btnStart);
            this.pnlExQues.Controls.Add(this.btnPrev);
            this.pnlExQues.Controls.Add(this.btnNext);
            this.pnlExQues.Controls.Add(this.lblActiveQuestion);
            this.pnlExQues.Controls.Add(this.label1);
            this.pnlExQues.Controls.Add(this.rtxtContent);
            this.pnlExQues.Controls.Add(this.lblHeading);
            this.pnlExQues.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlExQues.Location = new System.Drawing.Point(0, 0);
            this.pnlExQues.Name = "pnlExQues";
            this.pnlExQues.Size = new System.Drawing.Size(1118, 840);
            this.pnlExQues.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Brown;
            this.lblError.Location = new System.Drawing.Point(69, 378);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(249, 34);
            this.lblError.TabIndex = 80;
            this.lblError.Text = "Sorry , fill the field";
            this.lblError.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Peru;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(901, 617);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 51);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "EXIT EXAM";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCorrect);
            this.pnlButton.Controls.Add(this.btnIncorrect2);
            this.pnlButton.Controls.Add(this.btnIncorrect1);
            this.pnlButton.Controls.Add(this.btnIncorrect3);
            this.pnlButton.Location = new System.Drawing.Point(75, 415);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(981, 171);
            this.pnlButton.TabIndex = 18;
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.White;
            this.btnCorrect.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect.Location = new System.Drawing.Point(0, 28);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(434, 41);
            this.btnCorrect.TabIndex = 11;
            this.btnCorrect.Tag = "0";
            this.btnCorrect.UseVisualStyleBackColor = false;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnIncorrect2
            // 
            this.btnIncorrect2.BackColor = System.Drawing.Color.White;
            this.btnIncorrect2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrect2.Location = new System.Drawing.Point(0, 108);
            this.btnIncorrect2.Name = "btnIncorrect2";
            this.btnIncorrect2.Size = new System.Drawing.Size(434, 41);
            this.btnIncorrect2.TabIndex = 13;
            this.btnIncorrect2.Tag = "0";
            this.btnIncorrect2.UseVisualStyleBackColor = false;
            this.btnIncorrect2.Click += new System.EventHandler(this.btnIncorrect2_Click);
            // 
            // btnIncorrect1
            // 
            this.btnIncorrect1.BackColor = System.Drawing.Color.White;
            this.btnIncorrect1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrect1.Location = new System.Drawing.Point(544, 28);
            this.btnIncorrect1.Name = "btnIncorrect1";
            this.btnIncorrect1.Size = new System.Drawing.Size(434, 41);
            this.btnIncorrect1.TabIndex = 12;
            this.btnIncorrect1.Tag = "0";
            this.btnIncorrect1.UseVisualStyleBackColor = false;
            this.btnIncorrect1.Click += new System.EventHandler(this.btnIncorrect1_Click);
            // 
            // btnIncorrect3
            // 
            this.btnIncorrect3.BackColor = System.Drawing.Color.White;
            this.btnIncorrect3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrect3.Location = new System.Drawing.Point(547, 108);
            this.btnIncorrect3.Name = "btnIncorrect3";
            this.btnIncorrect3.Size = new System.Drawing.Size(434, 41);
            this.btnIncorrect3.TabIndex = 14;
            this.btnIncorrect3.Tag = "0";
            this.btnIncorrect3.UseVisualStyleBackColor = false;
            this.btnIncorrect3.Click += new System.EventHandler(this.btnIncorrect3_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Peru;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Location = new System.Drawing.Point(459, 74);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 51);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START EXAM";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Peru;
            this.btnPrev.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.Location = new System.Drawing.Point(474, 617);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(85, 51);
            this.btnPrev.TabIndex = 16;
            this.btnPrev.Text = "PREV";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Peru;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(565, 617);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 51);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblActiveQuestion
            // 
            this.lblActiveQuestion.AutoSize = true;
            this.lblActiveQuestion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveQuestion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveQuestion.Location = new System.Drawing.Point(204, 104);
            this.lblActiveQuestion.Name = "lblActiveQuestion";
            this.lblActiveQuestion.Size = new System.Drawing.Size(34, 37);
            this.lblActiveQuestion.TabIndex = 6;
            this.lblActiveQuestion.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(70, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question :";
            // 
            // rtxtContent
            // 
            this.rtxtContent.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtContent.Location = new System.Drawing.Point(75, 152);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(981, 198);
            this.rtxtContent.TabIndex = 1;
            this.rtxtContent.Text = "";
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1118, 59);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Exam Subject";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFilters.Controls.Add(this.lblCountPoint);
            this.pnlFilters.Controls.Add(this.label3);
            this.pnlFilters.Controls.Add(this.lblCountIncAnsw);
            this.pnlFilters.Controls.Add(this.label2);
            this.pnlFilters.Controls.Add(this.lblCountCorAnsw);
            this.pnlFilters.Controls.Add(this.lblCorrectAnsw);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(1118, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(466, 840);
            this.pnlFilters.TabIndex = 1;
            // 
            // lblCountPoint
            // 
            this.lblCountPoint.AutoSize = true;
            this.lblCountPoint.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountPoint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCountPoint.Location = new System.Drawing.Point(284, 175);
            this.lblCountPoint.Name = "lblCountPoint";
            this.lblCountPoint.Size = new System.Drawing.Size(34, 37);
            this.lblCountPoint.TabIndex = 5;
            this.lblCountPoint.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Point :";
            // 
            // lblCountIncAnsw
            // 
            this.lblCountIncAnsw.AutoSize = true;
            this.lblCountIncAnsw.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountIncAnsw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCountIncAnsw.Location = new System.Drawing.Point(284, 111);
            this.lblCountIncAnsw.Name = "lblCountIncAnsw";
            this.lblCountIncAnsw.Size = new System.Drawing.Size(34, 37);
            this.lblCountIncAnsw.TabIndex = 3;
            this.lblCountIncAnsw.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(45, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Incorrect Answers :";
            // 
            // lblCountCorAnsw
            // 
            this.lblCountCorAnsw.AutoSize = true;
            this.lblCountCorAnsw.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCorAnsw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCountCorAnsw.Location = new System.Drawing.Point(284, 46);
            this.lblCountCorAnsw.Name = "lblCountCorAnsw";
            this.lblCountCorAnsw.Size = new System.Drawing.Size(34, 37);
            this.lblCountCorAnsw.TabIndex = 1;
            this.lblCountCorAnsw.Text = "0";
            // 
            // lblCorrectAnsw
            // 
            this.lblCorrectAnsw.AutoSize = true;
            this.lblCorrectAnsw.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnsw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorrectAnsw.Location = new System.Drawing.Point(44, 55);
            this.lblCorrectAnsw.Name = "lblCorrectAnsw";
            this.lblCorrectAnsw.Size = new System.Drawing.Size(216, 28);
            this.lblCorrectAnsw.TabIndex = 0;
            this.lblCorrectAnsw.Text = "Correct Answers :";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1584, 840);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlExQues);
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            this.pnlExQues.ResumeLayout(false);
            this.pnlExQues.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExQues;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblCountCorAnsw;
        private System.Windows.Forms.Label lblCorrectAnsw;
        private System.Windows.Forms.Label lblCountPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountIncAnsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblActiveQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Button btnIncorrect3;
        private System.Windows.Forms.Button btnIncorrect2;
        private System.Windows.Forms.Button btnIncorrect1;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblError;
    }
}