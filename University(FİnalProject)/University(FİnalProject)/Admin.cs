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
    public partial class Admin : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        string SelectedType;
        string PassType = "AdminPass";
        public Admin()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Admin ca = new Create_Admin();
            ca.ShowDialog();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTeacher ct = new CreateTeacher();
            ct.ShowDialog();
        }
        private void ShowGroups()
        {
            dataGridShow.Columns.Clear();
            lblDataName.Text = "Groups";
            // show students
            dataGridShow.DataSource = db.Groups.Where(gr=>gr.Status == 1).Select(gr => new
            {
                ID = gr.id,
                gr.Name
            }).ToList();
            dataGridShow.Columns[0].Visible = false;
        }
        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowGroups();
        }
        private void ShowAdmins()
        {
            //Show admins
            var admin = from t in db.Admins
                        where t.Status == 1
                        select new
                        {
                            t.Name,
                            t.Surname,
                            t.Email,
                            t.Age,
                            Identification = t.Identification_Code

                        };
            dataGridShow.DataSource = admin.ToList();
            lblDataName.Text = "Admins";
        }
        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAdmins();
        }
        private void ShowTeachers()
        {
            dataGridShow.Columns.Clear();
            lblDataName.Text = "Teachers";
            // show teachers
            dataGridShow.DataSource = db.Teachers.Where(tc => tc.Status == 1).Select(t => new
            {
                ID = t.id,
                t.Name,
                t.Surname,
                t.Age,
                t.Gender,
                t.Email,
                Identification = t.Identification_Code,
                Subject = db.Subjects.Where(sub => sub.id == 2)
                //subject yarimciq qalib
            }).ToList();
            dataGridShow.Columns[0].Visible = false;
        }
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachers();
        }
        private void ShowStudents()
        {
            dataGridShow.Columns.Clear();
            lblDataName.Text = "Students";
            // show students
            dataGridShow.DataSource = db.Students.Where(st => st.Status == 1).Select(st => new
            {
                ID = st.id,
                st.Name,
                st.Surname,
                Group = st.Group.Name,
                st.Age,
                st.Gender,
                st.Email,
                Identification = st.Identification_Code,
            }).ToList();
            dataGridShow.Columns[0].Visible = false;
        }
        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowStudents();
        }
        private void ShowSubjects()
        {
            dataGridShow.Columns.Clear();
            lblDataName.Text = "Subjects";
            // show students
            dataGridShow.DataSource = db.Subjects.Where(sb => sb.Status == 1).Select(sb => new
            {
                ID = sb.id,
                sb.Name
            }).ToList();
            dataGridShow.Columns[0].Visible = false;
        }
        private void ShowCourses()
        {
            dataGridShow.Columns.Clear();
            lblDataName.Text = "Courses";
            // show students
            dataGridShow.DataSource = db.Teacher_Group_Subject.Select(sb => new
            {
                ID = sb.id,
                Teacher = sb.Teacher.Name,
                Group = sb.Group.Name,
                Subject  = sb.Subject.Name
            }).ToList();
            dataGridShow.Columns[0].Visible = false;
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSubjects();
        }

        private void createNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string type = "Subject";
            //create new group
            Create_Subject_Group csg = new Create_Subject_Group(type);
            csg.ShowDialog();
        }

        private void createNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string type = "Group";
            //create new group
            Create_Subject_Group csg = new Create_Subject_Group(type);
            csg.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ShowAdmins();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string type = "Group";
            Delete_Group_Subject GS = new Delete_Group_Subject(type);
            GS.ShowDialog();
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string type = "Subject";
            Delete_Group_Subject GS = new Delete_Group_Subject(type);
            GS.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedType = "Admin";
            Delete_Teacher__Student___Admin d = new Delete_Teacher__Student___Admin(SelectedType);
            d.ShowDialog();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectedType = "Teacher";
            Delete_Teacher__Student___Admin d = new Delete_Teacher__Student___Admin(SelectedType);
            d.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SelectedType = "Student";
            Delete_Teacher__Student___Admin d = new Delete_Teacher__Student___Admin(SelectedType);
            d.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePassword up = new UpdatePassword(PassType);
            up.ShowDialog();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_Course cc = new Create_Course();
            cc.ShowDialog();
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Student cs = new Create_Student();
            cs.ShowDialog();
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowCourses();
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
