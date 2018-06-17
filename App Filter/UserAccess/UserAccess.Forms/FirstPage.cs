namespace UserAccess.Forms
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Linq;

    using UserAccess.Data;
    using UserAccess.Forms.Common;
    using UserAccess.Models;
    using System.Data.Entity;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Threading;
    using System.Runtime.InteropServices;
    using AxClientLib;

    public partial class FirstPage : Form
    {
        AxContext dbAx = new AxContext();
        UserAccessDbContext dbUA = new UserAccessDbContext();
        UserAccessDbContent uContent = new UserAccessDbContent();
        AdminModeDBContent adminContent = new AdminModeDBContent();
        public SettingsDbContent dataFromSettings;

        AdministrationForm admin = new AdministrationForm();

        private static Stack<Process> _startedProcesses = new Stack<Process>();

        public string UserName = Environment.UserName;

        Process newProcess = new Process();

        private bool submitBtnWasClickedAndAxIsOpen;

        private string NameOfCompany;

        public FirstPage()
        {
            InitializeComponent();

            CommonInit();
        }
        public void CommonInit()
        {            
                  
  
            if (Database.Exists(string.Format(GlobalConstants.ConnectionStringAccessServer, GlobalConstants.MachineName)))
            {
                var userAuthentication = dbAx.USERINFOes
                            .Where(u => u.NETWORKALIAS == UserName)
                            .FirstOrDefault();

                if (userAuthentication == null)
                {
                    MessageBox.Show(GlobalConstants.AuthenticationNullReferenceError);
                }
                else
                {
                    TextBoxViewUser.Text = userAuthentication.NAME;
                }
            }
                        
        }

        public void UserChecker()
        {
            uContent.Description = discriptionBox.Text;

            var dataFromUSERINFO = dbAx.USERINFOes
                                       .Where(u => u.NETWORKALIAS == UserName)
                                       .ToList()
                                       .Last();

            var dataFromSYSUSERINFO = dbAx.SYSUSERINFOes
                                          .Where(x => x.RECID == dataFromUSERINFO.RECID)
                                          .ToList()
                                          .Last();

            dataFromSettings = dbUA.Settings
                                       .ToList()
                                       .Last();


            NameOfCompany = dataFromUSERINFO.COMPANY;

            if (Validations.DiscriptionLengths(discriptionBox.Text,submitBtnWasClickedAndAxIsOpen) == true)
            {
                if (dataFromUSERINFO.NETWORKALIAS.ToLower() == UserName.ToLower())
                {
                    IfCheckboxIsCheck();

                    AxOptions.OpenAx(newProcess, _startedProcesses);

                    Thread.Sleep(10000);
                    
                    submitBtnWasClickedAndAxIsOpen = true;

                    Validations.ClearDiscriptionText(discriptionBox);

                    var dataFromUSERLOG = dbAx.SYSUSERLOGs
                                          .Where(t => t.USERID == dataFromUSERINFO.ID)
                                          .ToList()
                                          .Last();

                    

                    uContent.CustomerName = UserName;

                    uContent.RECID = dataFromUSERLOG.RECID;

                    uContent.LogOn = dataFromUSERLOG.CREATEDDATETIME;

                    dbUA.UserAccess.Add(uContent);

                    dbUA.SaveChanges();

                    

                    new Thread(() =>
                    {


                    AxOptions.IfAxIsClosed(newProcess, _startedProcesses, discriptionBox, Handle, NameOfCompany, submitBtnWasClickedAndAxIsOpen, dataFromUSERINFO, dataFromSettings, dataFromUSERLOG);
                                                
                        submitBtnWasClickedAndAxIsOpen = false;

                    }).Start();

                }
                else
                {
                    MessageBox.Show(GlobalConstants.UsernameIsNotValid);

                }
            }
        }
        public void IfCheckboxIsCheck()
        {
            var enumm = dbAx.USERINFOes
                            .Where(u => u.NETWORKALIAS == UserName)
                            .FirstOrDefault();

            var dataFromSettings = dbUA.Settings
                                       .ToList()
                                       .Last();

            if (enumm.ENABLE == GlobalConstants.CheckBoxIsNotChecked)
            {               
                SqlQueryWithString.Query(enumm, GlobalConstants.UpdateCheckBoxTestsWithTrue,dataFromSettings,GlobalConstants.MachineName);
            }

        }

        //ToolBox


        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton(object sender, EventArgs e)
        {
            if (!Database.Exists(string.Format(GlobalConstants.ConnectionStringAccessServer, GlobalConstants.MachineName)))
            {
                MessageBox.Show(GlobalConstants.DonNotHaveDatabaseName);
                submitBtnWasClickedAndAxIsOpen = false;
            }
            else
            {
                if (submitBtnWasClickedAndAxIsOpen)
                {
                    MessageBox.Show(GlobalConstants.HaveOneAxOpen);
                }
                else
                {
                    UserChecker();

                }
            }
                        
        }

        private void Cancel_Button(object sender, EventArgs e)
        {
            if (submitBtnWasClickedAndAxIsOpen || discriptionBox.Text.Length > GlobalConstants.PlaceholderLength)
            {
                MessageBox.Show(GlobalConstants.CancelButtnoIsClicedAndDiscriptionIsMoreThan50Symbols);
            }
            else
            {
                Application.Exit();
            }
        }

        private void AdminModeButton(object sender, EventArgs e)
        {
            admin.ShowDialog();
        }

        //Description Placeholder

        private void Description_Enter(object sender, EventArgs e)
        {
            if (discriptionBox.Text == GlobalConstants.PlaceholderDescription)
            {
                discriptionBox.Text = "";
                discriptionBox.ForeColor = Color.Black;
            }
        }

        private void Description_Leave(object sender, EventArgs e)
        {
            if (discriptionBox.Text == "")
            {
                discriptionBox.Text = GlobalConstants.PlaceholderDescription;
                discriptionBox.ForeColor = Color.Silver;
            }
        }
        private void TextBoxDiscription(object sender, EventArgs e)
        {

        }

        private void TextBoxEnterUser(object sender, EventArgs e)
        {

        }

        private void UserLabel(object sender, EventArgs e)
        {

        }

        private void DiscriptionLabel(object sender, EventArgs e)
        {

        }

        private void TextBoxOutput(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
                       
    }
}
