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
    public partial class Student : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        Model.Student ActiveStudent = null;
        public Student(Model.Student current)
        {
            InitializeComponent();
            ActiveStudent = current;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "Student " + ActiveStudent.Name + " " + ActiveStudent.Surname + " WELCOME";
        }

        private void showMyScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridSt.DataSource = db.Scores.Where(sc => sc.Student_ID == ActiveStudent.id && sc.Status==1).Select(sc => new
            {
                ID = sc.id,
                Student = ActiveStudent.Name + " " + ActiveStudent.Surname,
                Group = ActiveStudent.Group.Name,
                Subject = sc.Subject.Name,
                Exam_Access_Point = sc.BefareExamScore,
                Exam_Reasult = sc.AfterExamScore,
                Total = sc.BefareExamScore + sc.AfterExamScore,
                Teacher = sc.Teacher.Name + " " + sc.Teacher.Surname
            }).ToList();
            dataGridSt.Columns[0].Visible = false;
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 st = new Form1();
            st.ShowDialog();
            this.Close();
        }

        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamPanel ep = new ExamPanel(ActiveStudent);
            ep.ShowDialog();
        }
    }
}
