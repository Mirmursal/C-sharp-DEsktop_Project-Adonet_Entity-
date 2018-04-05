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
    public partial class Form1 : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        //general variable
        int count = 1;

        //end
        public Form1()
        {
            InitializeComponent();
        }
        private string FindUserType()
        {
            if (rbStudent.Checked)
            {
                return  "Student";
            }
            else if (rbTeacher.Checked)
            {
                return "Teacher";
            }
            else
            {
                return "Admin";
            }
        }
        private void ClearLog()
        {
            txtPassword.Text = "";
            txtIdentificator.Text = "";
            rbStudent.Checked = false;
            rbTeacher.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Identi = txtIdentificator.Text;
            string Pass = txtPassword.Text;
            string UserType = null;

            if (Identi == "")
            {
                lblErrorIdentification.Text = "Sorry , field must be fill..!";
                lblErrorIdentification.Visible = true;
            }
            if (Pass == "")
            {
                lblErrorPass.Text = "Sorry , field must be fill..!";
                lblErrorPass.Visible = true;
            }
            if (Identi != "")
            {
                lblErrorIdentification.Visible = false;
            }
            if (Pass != "")
            {
                lblErrorPass.Visible = false;
            }
            if (Identi != "" && Pass != "")
            {
                UserType = FindUserType();
                if (UserType == "Teacher")
                {
                    bool isFind = false;
                    foreach (var teacher in db.Teachers)
                    {
                        if (teacher.Identification_Code == Identi && Extensions.ChechkHashPass(teacher.Password,Pass))
                        {
                            ClearLog();
                            isFind = true;
                            this.Hide();
                            Teacher teach = new Teacher(teacher);
                            teach.ShowDialog();
                            this.Close();
                            break;
                        }
                    }
                    if (!isFind)
                    {
                        Extensions.Message("Incorrect identification code or password", false);
                        ClearLog();
                    }
                }
                else if (UserType == "Student")
                {
                    bool isFind = false;
                    foreach (var student in db.Students)
                    {
                        if (student.Identification_Code == Identi && Extensions.ChechkHashPass(student.Password, Pass))
                        { 
                            ClearLog();
                            isFind = true;
                            this.Hide();
                            Student st = new Student(student);
                            st.ShowDialog();
                            this.Close();
                            break;
                        }
                    }
                    if (!isFind)
                    {
                        Extensions.Message("Incorrect identification code or password", false);
                        ClearLog();
                    }
                }
                else if (UserType == "Admin")
                {
                    bool isFind = false;
                    foreach (var admin in db.Admins)
                    {
                        if (admin.Identification_Code == Identi && Extensions.ChechkHashPass(admin.Password, Pass))
                        {
                            ClearLog();
                            isFind = true;
                            this.Hide();
                            Admin adm = new Admin();
                            adm.ShowDialog();
                            this.Close();
                            break;
                        }
                    }
                    if (!isFind)
                    {
                        Extensions.Message("Incorrect identification code or password",false);
                        ClearLog();
                    }
                }
            }
        } 
        private void lblShowPass_Click(object sender, EventArgs e)
        {
            count++;
            if(count%2 == 0)
            {
                lblShowPass.Text = "Hide Password";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                lblShowPass.Text = "Show Password";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtIdentificator_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
