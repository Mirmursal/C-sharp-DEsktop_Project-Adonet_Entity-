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
    public partial class Delete_Group_Subject : Form
    {
        string selectedType;
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        public Delete_Group_Subject(string type)
        {
            InitializeComponent();
            selectedType = type;
        }

        private void Delete_Group_Subject_Load(object sender, EventArgs e)
        {
            label1.Text = "Choose " + selectedType + " to delete";
            if(selectedType == "Group")
            {
                cmbSelect.Items.Clear();
                foreach (Group Group in db.Groups)
                {
                    if(Group.Status == 1)
                    {
                        cmbSelect.Items.Add(Group.Name);
                    }
                }
            }
            else if(selectedType == "Subject")
            {
                cmbSelect.Items.Clear();
                foreach (Subject Subject in db.Subjects)
                {
                    if(Subject.Status == 1)
                    {
                        cmbSelect.Items.Add(Subject.Name);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cmbSelect.Text == "")
            {
                lblErrorSelect.Visible = true;
                lblErrorSelect.Text = "Sorry , you must be to choose " + selectedType;
            }
            else
            {
                lblErrorSelect.Visible = false;
                string SelectedElement = cmbSelect.Text;
                if (selectedType == "Group")
                {
                    Group Deleted = db.Groups.FirstOrDefault(gr => gr.Name == SelectedElement);
                    if(Deleted == null)
                    {
                        lblErrorSelect.Visible = true;
                        lblErrorSelect.Text = "Sorry , this was NOT find";
                    }
                    else
                    {
                        Deleted.Status = 0;
                        lblErrorSelect.Visible = false;      
                        Extensions.Message(SelectedElement + " was deleted succesfully");    
                        Close();
                        db.SaveChanges();
                    }

                }
                else if(selectedType == "Subject")
                {
                    Subject Deleted = db.Subjects.FirstOrDefault(sb => sb.Name == SelectedElement);
                    if (Deleted == null)
                    {
                        lblErrorSelect.Visible = true;
                        lblErrorSelect.Text = "Sorry , this was NOT find";
                    }
                    else
                    {
                        lblErrorSelect.Visible = false;
                        Deleted.Status = 0;
                        Extensions.Message(SelectedElement + " was deleted succesfully");
                        Close();
                        db.SaveChanges();
                    }
                   
                }
            }  
        }
    }
}
