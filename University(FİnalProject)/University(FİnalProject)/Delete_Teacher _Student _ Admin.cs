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
    public partial class Delete_Teacher__Student___Admin : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        string Type;
        public Delete_Teacher__Student___Admin(string Deleted)
        {
            InitializeComponent();
            Type = Deleted;
        }
        private void Delete_Teacher__Student___Admin_Load(object sender, EventArgs e)
        {
            if (Type == "Admin")
            {
                lblHeading.Text = "Select Admin";
                cmbSelectFullName.Items.Clear();
                foreach (var admins in db.Admins)
                {
                    if(admins.Status == 1)
                    {
                        cmbSelectFullName.Items.Add(admins.Name + " " + admins.Surname);
                    }
                }
            }
            else if (Type == "Student")
            {
                lblHeading.Text = "Select Student";
                cmbSelectFullName.Items.Clear();
                foreach (var students in db.Students)
                {
                    if(students.Status == 1)
                    {
                        cmbSelectFullName.Items.Add(students.Name + " " + students.Surname);
                    }
                }
            }
            else if (Type == "Teacher")
            {
                lblHeading.Text = "Select Teacher";
                cmbSelectFullName.Items.Clear();
                foreach (var teachers in db.Teachers)
                {
                    if(teachers.Status == 1)
                    {
                        cmbSelectFullName.Items.Add(teachers.Name + " " + teachers.Surname);
                    }
                }
            }
        }

        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            string SelectedText = cmbSelectFullName.Text;
            if (SelectedText == "")
            {
                lblErrorFullName.Visible = true;
                lblErrorFullName.Text = "Choose " + Type + "... ";
            }
            else if(Type == "Admin")
            {
                lblErrorFullName.Visible = false;
                for(int i = 0;i < db.Admins.Count();i++)
                {
                    if (db.Admins.ToList()[i].Name + " " + db.Admins.ToList()[i].Surname == SelectedText)
                    {
                        var selectedAdmin = db.Admins.First(ad => ad.Name + " " + ad.Surname == SelectedText);
                        selectedAdmin.Status = 0;
                        db.SaveChanges();
                        Extensions.Message("Selected " + Type + " was deleted succesfully");
                        Close();
                    }
                }
            }
            else if (Type == "Student")
            {
                lblErrorFullName.Visible = false;
                for (int i = 0; i < db.Students.Count(); i++)
                {
                    if (db.Students.ToList()[i].Name + " " + db.Students.ToList()[i].Surname == SelectedText)
                    {
                        var selectedStudent = db.Students.First(st=> st.Name + " " + st.Surname == SelectedText);
                        selectedStudent.Status = 0;
                        db.SaveChanges();
                        Extensions.Message("Selected " + Type + " was deleted succesfully");
                        Close();
                    }
                }
            }
            else if (Type == "Teacher")
            {
                lblErrorFullName.Visible = false;
                for (int i = 0; i < db.Teachers.Count(); i++)
                {
                    if (db.Teachers.ToList()[i].Name + " " + db.Teachers.ToList()[i].Surname == SelectedText)
                    {
                        var selectedTeacher = db.Teachers.First(t => t.Name + " " + t.Surname == SelectedText);
                        selectedTeacher.Status = 0;
                        db.SaveChanges();
                        Extensions.Message("Selected " + Type + " was deleted succesfully");
                        Close();
                    }
                }
            }
        }
    }
}
