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
    public partial class ExamPanel : Form
    {
        //general variables begin
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        Model.Student ActiveStudent;
        string ChoosenSubject;
        //end
        public ExamPanel(Model.Student CurrentStudent)
        {
            InitializeComponent();
            ActiveStudent = CurrentStudent;
        }

        private void ExamPanel_Load(object sender, EventArgs e)
        {
            lblHeading.Text = ActiveStudent.Name + " " + ActiveStudent.Surname + " Welcome";
            bool isNullScore = false;
            //add exam subject to combo begin
            foreach (var item in db.Scores)
            {
                if(item.Student_ID == ActiveStudent.id)
                {
                    cmbSubject.Items.Add(item.Subject.Name);
                    isNullScore = true;
                }
            }
            //add exam subject to combo end
            //check do you have exam???
            if (!isNullScore)
            {
                lblHeading.Text = ActiveStudent.Name+" "+ActiveStudent.Surname +" \nYou do NOT have an exam yet";
                lblHeading.ForeColor = Color.Red;
            }
            //end
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            if(cmbSubject.Text == "")
            {
                lblErrorSubject.Visible = true;
                lblErrorSubject.Text = "Sorry , you must be choose subject...";
            }
            else if (db.Scores.Any(sc=>sc.Student_ID == ActiveStudent.id && sc.Subject.Name == cmbSubject.Text && sc.BefareExamScore < 17))
            {
                lblErrorSubject.Visible = true;
                lblErrorSubject.Text = "You can NOT enter the exam \n because your access point is \n less than 17";
            }
            else if (db.Scores.Any(sc => sc.Student_ID == ActiveStudent.id && sc.Subject.Name == cmbSubject.Text && sc.AfterExamScore > 0))
            {
                lblErrorSubject.Visible = true;
                lblErrorSubject.Text = "You gave the exam alredy";
            }
            else
            {
                lblErrorSubject.Visible = false;
                ChoosenSubject = cmbSubject.Text;
                this.Hide();
                Exam ex = new Exam(ChoosenSubject, ActiveStudent);
                ex.ShowDialog();
                this.Close();
            }
        }
    }
}
