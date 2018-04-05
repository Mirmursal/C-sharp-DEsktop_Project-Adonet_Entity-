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
    public partial class Create_Admin : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        public Create_Admin()
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
        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            bool nameError = false;
            bool surnameError = false;
            bool emailError = false;
            bool passError = false;
            bool identiError = false;

            string Name = txtName.Text;
            string Surname = txtSurname.Text;
            string Email = txtEmail.Text;
            int Age = (int)nmAge.Value;
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
            if (nameError || surnameError || emailError || passError || identiError)
            {
                Extensions.Message("Please , fill the form correctly...", false);
            }
            else if (txtName.Text != "" && txtSurname.Text != "" && txtEmail.Text != ""
               && txtPass.Text != "" && txtConPass.Text != "" && txtIdenti.Text != "")
            {
                db.Admins.Add(new Model.Admin
                {
                    Name = Name,
                    Surname = Surname,
                    Email = Email,
                    Age = Age,
                    Password = Pass,
                    Identification_Code = Identificator,
                    Status = 1
                });
                db.SaveChanges();
                Extensions.Message("New admin was added succesfully");
                Clear();
                Close();
            }
            else
            {
                Extensions.Message("Please , fill the form correctly...", false);
            }
        }
    }
}
