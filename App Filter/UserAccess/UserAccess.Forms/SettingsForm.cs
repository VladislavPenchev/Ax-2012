namespace UserAccess.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using UserAccess.Data;
    using UserAccess.Forms.Common;
    using UserAccess.Forms.Properties;
    using UserAccess.Models;
    public partial class SettingsForm : Form
    {
        SettingsDbContent settingsContent = new SettingsDbContent();
        UserAccessDbContext dbUA = new UserAccessDbContext();
        AdminModeDBContent adminContent = new AdminModeDBContent();

        ViewUserInfo viewUserInfoForm = new ViewUserInfo();
        AdministrationForm adminForm = new AdministrationForm();
        SettingsForm SettForm = new SettingsForm();

        public string NameOfAX2012DB;

        public SettingsDbContent dataFromSettings;

        public bool editFlagDatabaseName = false;

        public bool editFlagChangePassword = false;

        public bool editFlagAppConfig = false;
        public SettingsForm()
        {
            InitializeComponent();

        }
        public void NameOfDb()
        {
            NameOfAX2012DB = AxDbDiscription.Text;

            settingsContent.NameOfDatabase = NameOfAX2012DB;

            if (NameOfAX2012DB == string.Empty)
            {
                MessageBox.Show(GlobalConstants.FieldDatabaseCanNotBeEmpty);
            }
            else
            {
                if (Database.Exists(string.Format(GlobalConstants.ConnectionStringAccessServer, GlobalConstants.MachineName)))
                {
                    dbUA.Settings.Add(settingsContent);
                    dbUA.SaveChanges();
                    
                }
                else
                {
                    dbUA.Settings.Add(settingsContent);
                    dbUA.SaveChanges();
                }
                MessageBox.Show(GlobalConstants.SuccessfullySaved);
            }

        }

        public void PasswordChecker()
        {
            if (confirmPasswordDescription.Text == passwordDescription.Text
                && confirmPasswordDescription.Text != string.Empty)
            {
                adminContent.Passsword = passwordDescription.Text;
                dbUA.AdminModes.Add(adminContent);
                dbUA.SaveChanges();
                MessageBox.Show(GlobalConstants.SuccessfullySaved);
                Validations.ClearDiscriptionText(passwordDescription);
                Validations.ClearDiscriptionText(confirmPasswordDescription);
            }
            else
            {
                MessageBox.Show(GlobalConstants.PasswordAreNotTheSame);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (AxDbDiscription.Text == string.Empty)
            {
                e.Cancel = true;
                MessageBox.Show(GlobalConstants.FieldDatabaseCanNotBeEmpty);

            }
            else if (dbUA.AdminModes.Count() == 0)
            {
                e.Cancel = true;
                MessageBox.Show(GlobalConstants.FieldPasswordCanNotBeEmpty);
            }
            else
            {
                e.Cancel = false;

                databaseNameLabel.Visible = false;
                AxDbDiscription.Visible = false;

                passwordDescription.Visible = false;
                passwordLabel.Visible = false;
                confirmPassword.Visible = false;
                confirmPasswordDescription.Visible = false;

                appConfigLabel.Visible = false;
                appConfigDescription.Visible = false;

                submitButton.Visible = false;
                cancelButton.Visible = false;
            }
        }


        //ToolBox
        private void Cancel_Button(object sender, EventArgs e)
        {
            if (editFlagDatabaseName)
            {
                databaseNameLabel.Visible = false;
                AxDbDiscription.Visible = false;
                submitButton.Visible = false;
                cancelButton.Visible = false;

                editFlagDatabaseName = false;
            }
            if (editFlagChangePassword)
            {
                passwordDescription.Visible = false;
                passwordLabel.Visible = false;
                confirmPassword.Visible = false;
                confirmPasswordDescription.Visible = false;
                submitButton.Visible = false;
                cancelButton.Visible = false;

                editFlagChangePassword = false;
            }
            if (editFlagAppConfig)
            {
                appConfigLabel.Visible = false;
                appConfigDescription.Visible = false;
                submitButton.Visible = false;
                cancelButton.Visible = false;

                editFlagAppConfig = false;

                submitButton.Text = GlobalConstants.NameOfButtonSubmit;
                cancelButton.Text = GlobalConstants.NameOfButtonCancel;
            }

        }

        private void SubmitButton(object sender, EventArgs e)
        {
            if (editFlagDatabaseName)
            {
                NameOfDb();
            }

            if (editFlagChangePassword)
            {
                PasswordChecker();

                if (dbUA.AdminModes.Count() == 1)
                {
                    AxDbDiscription.Text = ".";

                    Application.Restart();
                    Environment.Exit(0);
                }                                
            }

            if (editFlagAppConfig)
            {
                UpdateAppConfig.add(GlobalConstants.AxDatabaseNameAppConfig, dataFromSettings, appConfigDescription,GlobalConstants.PathAppConfig);
                UpdateAppConfig.add(GlobalConstants.AxDatabaseNameAppConfig, dataFromSettings, appConfigDescription, GlobalConstants.PathAppConfig2);


                submitButton.Text = GlobalConstants.NameOfButtonSubmit;
                cancelButton.Text = GlobalConstants.NameOfButtonCancel;
                
                MessageBox.Show(GlobalConstants.SuccessfullySaved);

                appConfigLabel.Visible = false;
                appConfigDescription.Visible = false;
                submitButton.Visible = false;
                cancelButton.Visible = false;

                AxDbDiscription.Text = ".";

                Application.Restart();
                Environment.Exit(0);

            }
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (dbUA.Settings.Count() > 0)
            {

            }
        }

        //Edits
        private void EditChangePasswordButton(object sender, EventArgs e)
        {
            if (passwordDescription.Visible == false && passwordLabel.Visible == false
                && confirmPassword.Visible == false && confirmPasswordDescription.Visible == false
                && submitButton.Visible == false && cancelButton.Visible == false
                )
            {
                passwordDescription.Visible = true;
                passwordLabel.Visible = true;
                confirmPassword.Visible = true;
                confirmPasswordDescription.Visible = true;
                submitButton.Visible = true;
                cancelButton.Visible = true;
            }

            editFlagChangePassword = true;
        }

        private void EditDatabaseName_Click(object sender, EventArgs e)
        {
            if (AxDbDiscription.Visible == false && databaseNameLabel.Visible == false
                && submitButton.Visible == false && cancelButton.Visible == false)
            {
                AxDbDiscription.Visible = true;
                databaseNameLabel.Visible = true;
                submitButton.Visible = true;
                cancelButton.Visible = true;
            }

            if (dbUA.Settings.Count() != 0)
            {
                dataFromSettings = dbUA.Settings
                                         .ToList()
                                         .Last();

                if (dataFromSettings.NameOfDatabase == string.Empty)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    AxDbDiscription.Text = dataFromSettings.NameOfDatabase;
                }
            }

            editFlagDatabaseName = true;
        }

        private void EditAppConfig(object sender, EventArgs e)
        {
            if (dbUA.Settings.Count() == 0)
            {
                MessageBox.Show(GlobalConstants.FieldDatabaseCanNotBeEmpty);
            }
            else
            {
                dataFromSettings = dbUA.Settings
                                         .ToList()
                                         .Last();

                UpdateAppConfig.ViewAppConfig(GlobalConstants.AxDatabaseNameAppConfig, dataFromSettings, appConfigDescription);

                if (appConfigLabel.Visible == false && appConfigDescription.Visible == false
               && submitButton.Visible == false && cancelButton.Visible == false)
                {
                    submitButton.Text = GlobalConstants.NameOfButtonYes;
                    cancelButton.Text = GlobalConstants.NameOfButtonNo;

                    submitButton.Visible = true;
                    cancelButton.Visible = true;
                    appConfigLabel.Visible = true;
                    appConfigDescription.Visible = true;
                }

                editFlagAppConfig = true;
            }

        }
        
        private void appConfigLabel_Click(object sender, EventArgs e)
        {

        }



        private void ResetPassword(object sender, EventArgs e)
        {

        }
                
        private void NameMicrosoftDynamicsAX2012Database(object sender, EventArgs e)
        {

        }

        private void vLabel2_Click(object sender, EventArgs e)
        {

        }

        private void confirmPasswordDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void nameOfDataBase(object sender, EventArgs e)
        {

        }

        private void appConfigDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void vButton1_Click(object sender, EventArgs e)
        {
            viewUserInfoForm.ShowDialog();
            adminForm.Close();
            SettForm.Close();            
        }

    }
}
