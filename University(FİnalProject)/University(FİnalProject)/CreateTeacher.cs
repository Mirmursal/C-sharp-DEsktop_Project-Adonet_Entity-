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
    public partial class CreateTeacher : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        public CreateTeacher()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            foreach (Control ct in panelCreateTeacher.Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
                else if(ct is NumericUpDown)
                {
                    NumericUpDown numControls = ct as NumericUpDown;
                    numControls.Value = 18;
                }
            }
        }
        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            bool nameError = false;
            bool surnameError = false;
            bool emailError = false;
            bool genderError = false;
            bool passError = false;
            bool identiError = false;

            string  Name = txtTeachName.Text;
            string Surname = txtTeachSurname.Text;
            string Email = txtTeachEmail.Text;
            int Age = (int)nmTeachAge.Value;
            string Gender = null;
            string Pass = txtTeachPass.Text;
            string ConPass = txtTeachConPass.Text;
            string Identificator = txtTeachIdenti.Text;
            //checked textbox name
            if(Name == "")
            {
                nameError = true;
                lblErrorTeachName.Text = "Sorry , you must be fill the field";
                lblErrorTeachName.Visible = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[a-zA-Z ]"))
            {
                nameError = true;
                lblErrorTeachName.Text = "Sorry , you must be write correct format.";
                lblErrorTeachName.Visible = true;
                txtTeachName.Text.Remove(txtTeachName.Text.Length - 1);
            }
            else
            {
                nameError = false;
                lblErrorTeachName.Visible = false;
            }
            //checked textbox Surname
            if (Surname == "")
            {
                surnameError = true;
                lblErrorTeachSurname.Text = "Sorry , you must be fill the field";
                lblErrorTeachSurname.Visible = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Surname, "^[a-zA-Z ]"))
            {
                surnameError = true;
                lblErrorTeachSurname.Text = "Sorry , you must be write correct format.";
                lblErrorTeachSurname.Visible = true;
                txtTeachSurname.Text.Remove(txtTeachSurname.Text.Length - 1);
            }
            else
            {
                surnameError = false;
                lblErrorTeachSurname.Visible = false;
            }
            //checked textbox email
            if(Email == "")
            {
                emailError = true;
                lblErrorTeachEmail.Text = "Sorry , you must be fill the field";
                lblErrorTeachEmail.Visible = true;
            }
            else if (!Email.Contains('@') || !(Email.Contains(".az") || Email.Contains(".com") || Email.Contains(".ru")))
            {
                emailError = true;
                lblErrorTeachEmail.Text = "Sorry , incorrect email format";
                lblErrorTeachEmail.Visible = true;
            }
            else
            {
                emailError = false;
                lblErrorTeachEmail.Visible = false;
            }
            //checked combobox gender
            if(cmbTeachGender.SelectedIndex == 0)
            {
                Gender = "Male";
                genderError = false;
                lblErrorTeachGender.Visible = false;
            }
            else if(cmbTeachGender.SelectedIndex==1)
            {
                Gender = "Female";
                genderError = false;
                lblErrorTeachGender.Visible = false;
            }
            else
            {
                genderError = true;
                lblErrorTeachGender.Visible = true;
                lblErrorTeachGender.Text = "Choose gender...";
            }
            //identification textbox check
            if(Identificator == "")
            {
                identiError = true;
                lblErrorTeachIdenty.Text = "Sorry , you must be fill the field";
                lblErrorTeachIdenty.Visible = true;
            }
            else if(db.Admins.Any(ad=>ad.Identification_Code == Identificator)
                || db.Teachers.Any(tc=>tc.Identification_Code == Identificator
                || db.Students.Any(st=>st.Identification_Code == Identificator)))
            {
                identiError = true;
                lblErrorTeachIdenty.Text = "Sorry , this code is not UNIQUE";
                lblErrorTeachIdenty.Visible = true;
            }
            else
            {
                identiError = false;
                lblErrorTeachIdenty.Visible = false;
            }
            // check password
            if(Pass == "")
            {
                passError = true;
                lblErrorTeachPass.Text = "Sorry , you must be fill the field";
                lblErrorTeachPass.Visible = true;
            }
            else if(Pass.Length < 8)
            {
                passError = true;
                lblErrorTeachPass.Text = "Sorry , the password must be contains minimum 8 character...";
                lblErrorTeachPass.Visible = true;
            }
            else
            {
                passError = false;
                lblErrorTeachPass.Visible = false;
            }
            // check confirm password password
            if(ConPass == "")
            {
                passError = true;
                lblErrorTeachPass.Text = "Sorry , you must be fill the field";
                lblErrorTeachPass.Visible = true;
            }
            else if(ConPass.Length < 8)
            {
                passError = true;
                lblErrorTeachPass.Text = "Sorry , the password must be contains minimum 8 character...";
                lblErrorTeachPass.Visible = true;
            }
            else if(Pass != ConPass)
            {
                passError = true;
                lblErrorTeachPass.Text = "Sorry , password and confirm password is NOT the same..";
                lblErrorTeachPass.Visible = true;
            }
            else
            {
                passError = false;
                lblErrorTeachPass.Visible = false;
                Pass = Extensions.GetHash(Pass);
            }
             if(nameError || surnameError || emailError || passError || identiError || genderError)
            {
                Extensions.Message("Please , fill the form correctly...", false);
            }
             else if(txtTeachName.Text != "" && txtTeachSurname.Text != "" && txtTeachEmail.Text != "" 
                && txtTeachPass.Text != "" && txtTeachConPass.Text != "" && txtTeachIdenti.Text != "")
            {
                db.Teachers.Add(new Model.Teacher
                {
                    Name = Name,
                    Surname = Surname,
                    Email = Email,
                    Age = Age,
                    Gender = Gender,
                    Password = Pass,
                    Identification_Code = Identificator
                });
                db.SaveChanges();
                Extensions.Message("New teacher was added succesfully");
                Clear();
            }
            else
            {
                Extensions.Message("Please , fill the form correctly...", false);
            }
        }
    }
}
