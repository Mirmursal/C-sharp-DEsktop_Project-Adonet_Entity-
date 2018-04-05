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
    public partial class ExamResult : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        Model.Student ActiveStudent;
        string Total;
        string Subject;
        public ExamResult(Model.Student CurrentStudent , string subject , string total )
        {
            InitializeComponent();
            ActiveStudent = CurrentStudent;
            Subject = subject;
            Total = total;
        }

        private void ExamResult_Load(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;
            int BeforeExam = db.Scores.First(sc => sc.Student_ID == ActiveStudent.id && sc.Subject.Name == Subject).BefareExamScore;
            int Result = Convert.ToInt32(Total) + Convert.ToInt32(BeforeExam);
            lblHeading.Text = ActiveStudent.Name + " " + ActiveStudent.Surname;
            lblGroup.Text = ActiveStudent.Group.Name;
            lblSubName.Text = Subject;
            lblBeforeExam.Text = BeforeExam.ToString();
            lblExamScore.Text = Total;
            lblTotal.Text = Result.ToString();
            if(Result > 90)
            {
                lblType.Text = "A";
            }
            else if (Result > 80)
            {
                lblType.Text = "B";
            }
            else if (Result > 70)
            {
                lblType.Text = "C";
            }
            else if (Result > 60)
            {
                lblType.Text = "D";
            }
            else if (Result > 50)
            {
                lblType.Text = "E";
            }
            else if(Result < 51)
            {
                lblType.Text = "Unsuccessful Exam";
                lblType.Font = new Font("Arial", 16, FontStyle.Bold);
            }
            db.Scores.First(sc => sc.Student_ID == ActiveStudent.id && sc.Subject.Name == Subject).AfterExamScore = Convert.ToInt32(Total);        
            db.SaveChanges();
        }

        private void btnPnlExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
