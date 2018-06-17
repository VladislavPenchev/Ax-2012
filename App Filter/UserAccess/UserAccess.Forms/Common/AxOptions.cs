namespace UserAccess.Forms.Common
{
    using AxClientLib;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using UserAccess.Data;
    using UserAccess.Models;

    public class AxOptions
    {      
        public static void OpenAx(Process newProcess, Stack<Process> _startedProcesses)
        {
            newProcess.StartInfo = new ProcessStartInfo(GlobalConstants.AxFileName);
            newProcess.Start();
            _startedProcesses.Push(newProcess);
        }

        public static void IfAxIsClosed(Process newProcess, Stack<Process> _startedProcesses, TextBox discriptionBox, IntPtr Handle, string NameOfCompany, bool submitBtnWasClickedAndAxIsOpen, USERINFO dataFromUSERINFO, SettingsDbContent nameofDatabaseSettings, SYSUSERLOG dataFromUSERLOG)
        {
            AxContext AxContextt = new AxContext();
            UserAccessDbContext UserAccesss = new UserAccessDbContext();

            while (_startedProcesses.Count > 0)
            {
                Thread.Sleep(10);
                
                if (newProcess == null || newProcess.HasExited)
                {
                    _startedProcesses.Pop();
                }
            
                if (_startedProcesses.Count == 0)
                {
                    SqlQueryWithString.Query(dataFromUSERINFO, GlobalConstants.UpdateCheckBoxTestsWithFalse, nameofDatabaseSettings, GlobalConstants.MachineName);                   
                    

                    var dataFromUSERLOGQueryLOGOUT = AxContextt.SYSUSERLOGs
                                          .Where(t => t.USERID == dataFromUSERINFO.ID)
                                          .ToList()
                                          .Last();

                    var dataFromUserAccessQueryRECID = UserAccesss.UserAccess
                                                                  .ToList()
                                                                  .Last();

                    UpdateDbMethod.UpdateLogOutTime(dataFromUserAccessQueryRECID,dataFromUSERLOGQueryLOGOUT);
                    //Update LogOut Time
                    //var _time = new UserAccessDbContent() { Id = dataFromUserAccessQueryRECID.Id, LogOut = dataFromUSERLOGQueryLOGOUT.LOGOUTDATETIME };
                    //
                    //using (var newContext = new UserAccessDbContext())
                    //{
                    //    newContext.UserAccess.Attach(_time);
                    //    newContext.Entry(_time).Property(x => x.LogOut).IsModified = true;
                    //    newContext.SaveChanges();
                    //}


                    DynamicsAxApplication axComClient = new DynamicsAxApplication();
                    axComClient.OpenMenuItem(NameOfCompany, GlobalConstants.AxFormOpenSYSUSERINFOPAGE, AxClientLib.AxMenuType.DisplayMenu);
                    ProcessKiller.KillProcessByNameAndUser(GlobalConstants.AxProcessWork, Environment.UserName, 0);

                    submitBtnWasClickedAndAxIsOpen = false;

                    DisableFunctionalityOfExitBtn.EnableCloseButton(Handle);
                    discriptionBox.ReadOnly = false;                    
                
                    Validations.ClearDiscriptionText(discriptionBox);
                }
                else
                {
                    DisableFunctionalityOfExitBtn.DisableCloseButton(Handle);
                    discriptionBox.ReadOnly = true;
                }
            
            }
        }
    }
}
