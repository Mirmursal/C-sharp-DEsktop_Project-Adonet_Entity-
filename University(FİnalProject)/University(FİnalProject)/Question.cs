using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_FİnalProject_.Model;

namespace University_FİnalProject_
{
    public partial class Question : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        bool SubError = false;
        bool ContError = false;
        bool CorrectError = false;
        bool IncorrectError1 = false;
        bool IncorrectError2 = false;
        bool IncorrectError3 = false;

        public Question()
        {
            InitializeComponent();
        }

        private void Question_Load(object sender, EventArgs e)
        {
            foreach (var subjects in db.Subjects)
            {
                if(subjects.Status == 1)
                {
                    cmbSubject.Items.Add(subjects.Name);
                }
            }
        }
        private void Clear()
        {
            foreach (Control ct in this.Controls)
            {
                if(ct is RichTextBox || ct is TextBox)
                {
                    ct.Text = "";
                }     
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Subject Check begin
            if(cmbSubject.Text == "")
            {
                SubError = true;
                lblErrorSubject.Visible = true;
                lblErrorSubject.Text = "Choose subject";
            }
            else
            {
                SubError = false;
                lblErrorSubject.Visible = false;
            }
            //end
            //content check begin
            if(rtxtContent.Text == "")
            {
                ContError = true;
                lblErrorContent.Visible = true;
                lblErrorContent.Text = "Fill the field";
            }
            else if(rtxtContent.Text.Length < 15)
            {
                ContError = true;
                lblErrorContent.Visible = true;
                lblErrorContent.Text = "Explain more vividly";
            }
            else
            {
                ContError = false;
                lblErrorContent.Visible = false;
            }
            //end
            //correct check begin
            if(txtCorrect.Text == "")
            {
                CorrectError = true;
                lblErrorCorrect.Visible = true;
                lblErrorCorrect.Text = "Fill the field";
            }
            else
            {
                CorrectError = false;
                lblErrorCorrect.Visible = false;
            }
            //end
            //incorrect 1 check begin
            if(txtIncorrect1.Text == "")
            {
                IncorrectError1 = true;
                lblErrorIncorrect1.Visible = true;
                lblErrorIncorrect1.Text = "Fill the field";
            }
            else
            {
                IncorrectError1 = false;
                lblErrorIncorrect1.Visible = false;
            }
            // end
            //incorrect2 check begin
            if (txtIncorrect2.Text == "")
            {
                IncorrectError2 = true;
                lblErrorIncorrect2.Visible = true;
                lblErrorIncorrect2.Text = "Fill the field";
            }
            else
            {
                IncorrectError2 = false;
                lblErrorIncorrect2.Visible = false;
            }
            //end
            //incorrect3 check begin
            if (txtIncorrect3.Text == "")
            {
                IncorrectError3 = true;
                lblErrorIncorrect3.Visible = true;
                lblErrorIncorrect3.Text = "Fill the field";
            }
            else
            {
                IncorrectError3 = false;
                lblErrorIncorrect3.Visible = false;
            }
            //end
            if(cmbSubject.Text =="" || rtxtContent.Text == "" || txtIncorrect1.Text == "" ||
                txtIncorrect2.Text == "" || txtIncorrect3.Text == "")
            {
                Extensions.Message("Sorry you must be fill the field CORRECTLY", false);
            }
            else if (SubError || ContError || CorrectError || IncorrectError1 || IncorrectError2 || IncorrectError3)
            {
                Extensions.Message("Sorry you must be fill the field CORRECTLY", false);
            }
            else
            {
                int SubjectID = db.Subjects.First(sb => sb.Name == cmbSubject.Text).id;
                string Content = rtxtContent.Text;
                string Correct = txtCorrect.Text;
                string Incorrect1 = txtIncorrect1.Text;
                string Incorrect2 = txtIncorrect2.Text;
                string Incorrect3 = txtIncorrect3.Text;

                db.ExamQuestions.Add(new Model.ExamQuestion
                {
                   Subject_ID = SubjectID,
                   Content = Content,
                   Correct = Correct,
                   Incorrect1 = Incorrect1,
                   Incorrect2 = Incorrect2,
                   Incorrect3 = Incorrect3
                });
                db.SaveChanges();
                Extensions.Message("New question was added succesfully");
                Clear();
            }
        }
    }
}
