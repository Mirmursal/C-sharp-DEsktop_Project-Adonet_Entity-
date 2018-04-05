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
    public partial class Create_Subject_Group : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        string myType;
        bool nameError = false;
        public Create_Subject_Group(string type)
        {
            InitializeComponent();
             myType = type;
        }

        private void Create_Subject_Group_Load(object sender, EventArgs e)
        {
            lblHead.Text = "Create New " + myType;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                nameError = true;
                lblHead.Text = "Sorry , you must be fill the field";
                lblErrorName.Visible = true;
            }
            else if (myType == "Group")
            {
               if(db.Groups.Any(gr=>gr.Name == txtName.Text))
                {
                    nameError = true;
                    lblErrorName.Visible = true;
                    lblErrorName.Text = "Sorry , this group alredy exists";
                }
                else
                {
                    nameError = false;
                    lblErrorName.Visible = false;
                    string GroupName = txtName.Text;

                    db.Groups.Add(new Model.Group
                    {
                        Name = GroupName

                    });
                    db.SaveChanges();
                    Extensions.Message("New group was added succesfully");
                    Close();
                }
            }
            else if (myType == "Subject")
            {
                
                string SubjectName = txtName.Text;
                if(db.Subjects.Any(sb=>sb.Name == SubjectName ))
                {
                    nameError = true;
                    lblErrorName.Visible = true;
                    lblErrorName.Text = "Sorry , this subject alredy exists";
                }
                else {
                    nameError = false;
                    lblErrorName.Visible = false;
                    db.Subjects.Add(new Model.Subject
                {
                    Name = SubjectName
                });
                db.SaveChanges();
                Extensions.Message("New subject was added succesfully");
                    Close();
                }
            }
        }
    }
}
