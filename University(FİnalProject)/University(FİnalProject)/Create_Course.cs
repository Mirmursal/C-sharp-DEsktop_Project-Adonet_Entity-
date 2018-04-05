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
    public partial class Create_Course : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        bool groupError = false;
        bool teacherError = false;
        bool subjectError = false;
        public Create_Course()
        {
            InitializeComponent();
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            if(cmbGroup.Text == "")
            {
                lblErrorGroup.Visible = true;
                groupError = true;
                lblErrorGroup.Text = "Choose group...";
            }
            else
            {
                lblErrorGroup.Visible = false;
                groupError = false;
            }
            if (cmbTeacher.Text == "")
            {
                lblErrorTeacher.Visible = true;
                teacherError = true;
                lblErrorTeacher.Text = "Choose teacher...";
            }
            else
            {
                lblErrorTeacher.Visible = false;
                teacherError = false;
            }
            if(cmbSubject.Text == "")
            {
                lblErrorSubject.Visible = true;
                subjectError = true;
                lblErrorSubject.Text = "Choose subject...";
            }
            else
            {
                lblErrorSubject.Visible = false;
                subjectError = false;
            }
            if(subjectError || teacherError || groupError)
            {
                Extensions.Message("Sorry you must be fill the fields", false);
            }
            else
            {
                string teacher = cmbTeacher.Text;
                string group = cmbGroup.Text;
                string subject = cmbSubject.Text;

                int teacherID = 0;
                int subjectID = 0;
                int groupID = 0;
                //FindForm id by name
                foreach (var item in db.Teachers)
                {
                    if(item.Status == 1 && item.Name + " " + item.Surname == teacher)
                    {
                        teacherID = item.id;
                    }
                }
                foreach (var item in db.Groups)
                {
                    if(item.Status == 1 && item.Name == group)
                    {
                        groupID = item.id;
                    }
                }
                foreach (var item in db.Subjects)
                {
                    if(item.Status == 1 && item.Name == subject)
                    {
                        subjectID = item.id;
                    }
                }
                bool IsExists = false;
                foreach (var pivot in db.Teacher_Group_Subject)
                {
                    if ((pivot.Group_ID == groupID
                        && pivot.Teacher_ID == teacherID
                        && pivot.Subject_ID == subjectID)||
                        (pivot.Subject_ID == subjectID && pivot.Group_ID == groupID))
                    {
                        IsExists = true;
                    }
                }
                if (!IsExists)
                {
                    db.Teacher_Group_Subject.Add(new Model.Teacher_Group_Subject
                    {
                        Teacher_ID = teacherID,
                        Subject_ID = subjectID,
                        Group_ID = groupID
                    });
                    db.SaveChanges();
                    Extensions.Message("New course was added succesfully");
                }
                else
                {
                    Extensions.Message("Sorry , this course alredy exists...", false);
                }

            }
        }

        private void Create_Course_Load(object sender, EventArgs e)
        {
            cmbTeacher.Items.Clear();
            cmbSubject.Items.Clear();
            cmbGroup.Items.Clear();
            foreach (var teacher in db.Teachers)
            {
                if(teacher.Status == 1)
                {
                    cmbTeacher.Items.Add(teacher.Name + " "+teacher.Surname);
                }
            }
            foreach (var group in db.Groups)
            {
                if (group.Status == 1)
                {
                    cmbGroup.Items.Add(group.Name);
                }
            }
            foreach (var subject in db.Subjects)
            {
                if (subject.Status == 1)
                {
                    cmbSubject.Items.Add(subject.Name);
                }
            }
        }
    }
}
