using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccess.Data;
using UserAccess.Forms.Common;
using UserAccess.Models;

namespace UserAccess.Forms
{
    public partial class AdministrationForm : Form
    {

        SettingsForm settingsForm = new SettingsForm();

        UserAccessDbContext dbUA = new UserAccessDbContext();
        AdminModeDBContent adminContent = new AdminModeDBContent();

        private AdminModeDBContent dataFromAdminMode;

        public AdministrationForm()
        {
            InitializeComponent();
        }

        public void UserChecker()
        {
            if (!Database.Exists(string.Format(GlobalConstants.ConnectionStringAccessServer, GlobalConstants.MachineName)))
            {
                settingsForm.ShowDialog();
            }
            else
            {       
                  
                dataFromAdminMode = dbUA.AdminModes
                                  .ToList()
                                  .Last();

                if (passwordDiscription.Text == dataFromAdminMode.Passsword)
                {
                    settingsForm.ShowDialog();
                    Validations.ClearDiscriptionText(passwordDiscription);
                }
                else
                {
                    MessageBox.Show(GlobalConstants.WrongPassword);
                    Validations.ClearDiscriptionText(passwordDiscription);
                }
            }
            
        }


        //Buttons

        private void LoginButton(object sender, EventArgs e)
        {
            UserChecker();
        }

        private void Cancel_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            if (Database.Exists(string.Format(GlobalConstants.ConnectionStringAccessServer, GlobalConstants.MachineName)) && dbUA.AdminModes.Count() == 0)
            {
                adminContent.Passsword = GlobalConstants.DefaultPassword;
                dbUA.AdminModes.Add(adminContent);
                dbUA.SaveChanges();
            } 
        }

        private void vTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordDiscription(object sender, EventArgs e)
        {

        }
    }
}
