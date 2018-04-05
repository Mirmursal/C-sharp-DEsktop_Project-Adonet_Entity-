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
    public partial class Create_Student : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        public Create_Student()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            foreach (Control ct in pnlBody.Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
                else if (ct is NumericUpDown)
                {
                    NumericUpDown numControls = ct as NumericUpDown;
                    numControls.Value = 18;
                }
            }
        }
        private void btnCreateStudent_Click_1(object sender, EventArgs e)
        {
            bool nameError = false;
            bool surnameError = false;
            bool emailError = false;
            bool genderError = false;
            bool passError = false;
            bool identiError = false;
            bool groupError = false;

            string Name = txtName.Text;
            string Surname = txtSurname.Text;
            string Email = txtEmail.Text;
            int Age = (int)nmAge.Value;
            string Gender = null;
            string Pass = txtPass.Text;
            string ConPass = txtConPass.Text;
            string Identificator = txtIdenti.Text;
            //checked textbox name
            if (Name == "")
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
                txtName.Text.Remove(txtName.Text.Length - 1);
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
                txtSurname.Text.Remove(txtSurname.Text.Length - 1);
            }
            else
            {
                surnameError = false;
                lblErrorTeachSurname.Visible = false;
            }
            //checked textbox email
            if (Email == "")
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
            if (cmbGender.SelectedIndex == 0)
            {
                Gender = "Male";
                genderError = false;
                lblErrorTeachGender.Visible = false;
            }
            else if (cmbGender.SelectedIndex == 1)
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
            if (Identificator == "")
            {
                identiError = true;
                lblErrorTeachIdenty.Text = "Sorry , you must be fill the field";
                lblErrorTeachIdenty.Visible = true;
            }
            else if (db.Admins.Any(ad => ad.Identification_Code == Identificator)
                || db.Teachers.Any(tc => tc.Identification_Code == Identificator
                || db.Students.Any(st => st.Identification_Code == Identificator)))
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
            if (Pass == "")
            {
                passError = true;
                lblErrorTeachPass.Text = "Sorry , you must be fill the field";
                lblErrorTeachPass.Visible = true;
            }
            else if (Pass.Length < 8)
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
            //check groups combo
            if(cmbGroup.Text == "")
            {
                lblErrorGroup.Visible = true;
                groupError = true;
                lblErrorGroup.Text = "Sorry , you must be choose a group";
            }
            else
            {
                lblErrorGroup.Visible = false;
                groupError = false;
            }
            if (ConPass == "")
            {
                passError = true;
                lblErrorTeachPass.Text = "Sorry , you must be fill the field";
                lblErrorTeachPass.Visible = true;
            }
            else if (ConPass.Length < 8)
            {
                passError = true;
                lblErrorTeachPass.Text = "Sorry , the password must be contains minimum 8 character...";
                lblErrorTeachPass.Visible = true;
            }
            else if (Pass != ConPass)
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
            if (nameError || surnameError || emailError || passError || identiError || genderError || groupError)
            {
                Extensions.Message("Please , fill the form correctly...", false);
            }
            else if (txtName.Text != "" && txtSurname.Text != "" && txtEmail.Text != ""
               && txtPass.Text != "" && txtConPass.Text != "" && txtIdenti.Text != "" && cmbGroup.Text != "")
            {
                int id = 0;
                foreach (var group in db.Groups)
                {
                    if(group.Name == cmbGroup.Text)
                    {
                        id = group.id;
                    }
                }
                db.Students.Add(new Model.Student
                {
                    Name = Name,
                    Surname = Surname,
                    Email = Email,
                    Age = Age,
                    Gender = Gender,
                    Password = Pass,
                    Identification_Code = Identificator,
                    Group_ID = id,
                    Status = 1
                });
                db.SaveChanges();
                Extensions.Message("New student was added succesfully");
                Clear();
            }
            else
            {
                Extensions.Message("Please , fill the form correctly...", false);
            }
        }

        private void Create_Student_Load(object sender, EventArgs e)
        {
            cmbGroup.Items.Clear();
            foreach (var groups in db.Groups)
            {
                if(groups.Status == 1)
                {
                    cmbGroup.Items.Add(groups.Name);
                }
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorTeachPass_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorTeachIdenty_Click(object sender, EventArgs e)
        {

        }

        private void txtIdenti_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorTeachGender_Click(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorTeachAge_Click(object sender, EventArgs e)
        {

        }

        private void nmAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorTeachEmail_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorTeachName_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorTeachSurname_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
