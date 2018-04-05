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
    public partial class Teacher : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        Model.Teacher ActiveTeacher = null;
        public Teacher(Model.Teacher current)
        { 
            InitializeComponent();
            ActiveTeacher = current; 
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "Teacher " + ActiveTeacher.Name + " " + ActiveTeacher.Surname + " " + " WELCOME";
        }

        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Score ads =  new Add_Score(ActiveTeacher.Name , ActiveTeacher.Surname);
            ads.ShowDialog();
        }

        private void showScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dgTeacher.DataSource = db.Scores.Where(sc=>sc.TeacherId == ActiveTeacher.id).Select(sc => new
            {
                Student = sc.Student.Name + sc.Student.Surname,
                Subject = sc.Subject.Name,
                Group = sc.Student.Group.Name,
                Access_Point = sc.BefareExamScore,
                Exam_Point = sc.AfterExamScore,
                Total = sc.AfterExamScore + sc.BefareExamScore,
                Teacher = sc.Teacher.Name
            }).ToList();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question qs = new Question();
            qs.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgTeacher.DataSource = db.ExamQuestions.Select(sc => new
            {
                Subject = sc.Subject.Name,
                Content = sc.Content,
                Correct_Variant = sc.Correct,
                Incorrect_Variant_1 = sc.Incorrect1,
                Incorrect_Variant_2 = sc.Incorrect2,
                Incorrect_Variant_3 = sc.Incorrect3
            }).ToList();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();
        }
    }
}
