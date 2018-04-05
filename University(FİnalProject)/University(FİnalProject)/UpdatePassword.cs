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
    public partial class UpdatePassword : Form
    {
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        string Respond;
        public UpdatePassword(string type)
        {
            InitializeComponent();
            Respond = type;
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            if(Respond == "AdminPass")
            {
                lblHeading.Text = "Update Admin's Password";
                cmbChooseName.Items.Clear();
                foreach (var admins in db.Admins)
                {
                    if(admins.Status == 1)
                    {
                        string AdName = admins.Name + " " + admins.Surname;
                        cmbChooseName.Items.Add(AdName);
                    }
                }
            }
        }
        bool nameError = false;
        bool newPassError = false;
        bool oldPassError = false;
        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            if(cmbChooseName.Text == "")
            {
                lblErrorFullName.Text = "Choose Admin..!";
                lblErrorFullName.Visible = true;
                nameError = true;
            }
            else
            {
                lblErrorFullName.Visible = false;
                nameError = false;
            }
            if(txtNewPass.Text == "")
            {
                newPassError = true;
                lblErrorNewPass.Visible = true;
                lblErrorNewPass.Text = "Enter old password";
            }
            else
            {
                newPassError = false;
                lblErrorNewPass.Visible = false;
            }
            if(txtOldPass.Text == "")
            {
                oldPassError = true;
                lblErrorOldPass.Visible = true;
                lblErrorOldPass.Text = "Enter new password";
            }
            else
            {
                oldPassError = false;
                lblErrorOldPass.Visible = false;
            }
            if(nameError || newPassError || oldPassError)
            {
                Extensions.Message("You must be fill the field...", false);
            }
            else
            {
                string SelectedText = cmbChooseName.Text;
                for (int i = 0; i < db.Admins.Count(); i++)
                {
                    if (db.Admins.ToList()[i].Name + " " + db.Admins.ToList()[i].Surname == SelectedText)
                    {
                        var selectedAdmin = db.Admins.First(t => t.Name + " " + t.Surname == SelectedText);
                        if(Extensions.ChechkHashPass(selectedAdmin.Password , txtOldPass.Text))
                        {
                            selectedAdmin.Password = Extensions.GetHash(txtNewPass.Text);
                            db.SaveChanges();
                            Extensions.Message("Selected admin's password was updated succesfully");
                            Close();
                        }
                        else
                        {
                            Extensions.Message("Old password is NOT correct" , false);
                        }

                    }
                }
            }
        }
    }
}
