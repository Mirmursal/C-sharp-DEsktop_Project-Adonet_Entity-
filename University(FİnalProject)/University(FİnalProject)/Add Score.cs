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
    public partial class Add_Score : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        string tName;
        string tSurname;
        List<string> GroupList = new List<string>();
        List<string> StudentList = new List<string>();
        List<string> SubjectList = new List<string>();
        Model.Teacher ActiveTeacher; 
        public Add_Score(string teacherName, string teacherSurname)
        {
            InitializeComponent();
            tName = teacherName;
            tSurname = teacherSurname;
        }
        private void Add_Score_Load(object sender, EventArgs e)
        {
            //Find current teacher begin
            foreach (var teachers in db.Teachers)
            {
                if(teachers.Name == tName && teachers.Surname == tSurname)
                {
                    ActiveTeacher = teachers;
                }
            }
            //Find current teacher end
            //Find Groups of teacher begin
            foreach (var courses in db.Teacher_Group_Subject)
            {
                if(courses.Teacher_ID == ActiveTeacher.id)
                {
                    if(GroupList.Contains(courses.Group.Name))
                    {
                        
                    }
                    else
                    {
                        GroupList.Add(courses.Group.Name);
                    }
                }
            }
            //Find Groups of teacher end
            //Add combobox groups
            cmbGroup.Items.Clear();
            foreach (var group in GroupList)
            {
                cmbGroup.Items.Add(group);
            }
            //Add combobox end
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if(cmbGroup.Text == "" && cmbStudent.Text == "" && cmbSubject.Text == "")
            {
                Extensions.Message("Your choice was incorrect" , false);
            }
            else
            {
                string GroupName = cmbGroup.Text;
                string StudentName = cmbStudent.Text;
                string SubjectName = cmbSubject.Text;

                int group_ID = db.Groups.First(g => g.Name == GroupName).id;
                int student_ID = db.Students.First(st => st.Name + " " + st.Surname == StudentName).id;
                int subject_ID = db.Subjects.First(sb => sb.Name == SubjectName).id;

                if (!db.Scores.Any(sc => sc.Subject_ID == subject_ID && sc.Student_ID == student_ID))
                {
                    db.Scores.Add(new Model.Score
                    {
                        Student_ID = student_ID,
                        Subject_ID = subject_ID,
                        BefareExamScore = (int)nmScore.Value,
                        AfterExamScore = 0,
                        Status = 1,
                        TeacherId = ActiveTeacher.id
                    });
                    db.SaveChanges();
                    Extensions.Message("You was succesfully added " + nmScore.Value + " point to student " + StudentName);
                    Close();
                }
                else
                {
                    Extensions.Message("This student alredy scored for this subject",false);
                    Close();

                }

            }
        }
        int activeGroupID = 0;
        //ActiveTeacher.id;
        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {     
            string selectedGroup = cmbGroup.Text;
            int groupID = 0;
            activeGroupID = groupID;
            //Find selected group id begin
            foreach (var group in db.Groups)
            {
                if(group.Name == selectedGroup)
                {
                    groupID = group.id;
                }
            }
            //end
            //Add list student begin
            StudentList.Clear();
            foreach (var student in db.Students)
            {
                if(student.Group_ID == groupID)
                {
                    StudentList.Add(student.Name + " " + student.Surname);
                }
            }
            //Add list student end
            //add  student combo
            cmbStudent.Items.Clear();
            foreach (var students in StudentList)
            {
                cmbStudent.Items.Add(students);
            }
            cmbStudent.SelectedIndex = 0;
            //end
            // find subjects begin 
            cmbSubject.Items.Clear();   
            cmbSubject.Items.AddRange(db.Teacher_Group_Subject.Where(tchs => tchs.Group.Name == cmbGroup.Text && tchs.Teacher_ID == ActiveTeacher.id).Select(tchs => tchs.Subject.Name).ToArray());
            cmbSubject.SelectedIndex = 0;
           
            //find subject end
        }
    }
}
