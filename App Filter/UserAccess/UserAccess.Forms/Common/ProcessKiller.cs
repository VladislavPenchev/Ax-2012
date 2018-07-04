namespace UserAccess.Forms.Common
{
    using System;
    using System.Management;
    using System.Diagnostics;
    using System.Windows.Forms;

    public class ProcessKiller
    {      

        public static string GetProcessOwner(int processId)
        {
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            foreach (ManagementObject obj in processList)
            {
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    return argList[0];   // return user
                }
            }
            return "NO OWNER";
        }
                
        public static void KillProcessByNameAndUser(string ProcessName, string ProcessUserName, int HasStartedForHours)
        {
            Process[] foundProcesses = Process.GetProcessesByName(ProcessName);
            string strMessage = string.Empty;
            foreach (Process p in foundProcesses)
            {
                string UserName = GetProcessOwner(p.Id);

                if (UserName != "NO OWNER")
                {
                    bool TimeExpired = (p.StartTime.AddHours(HasStartedForHours) < DateTime.Now) || HasStartedForHours == 0;
                    bool PrcoessUserName_Is_Matched = UserName.Equals(ProcessUserName);

                    if ((ProcessUserName.ToLower() == "all" && TimeExpired) ||
                         PrcoessUserName_Is_Matched && TimeExpired)
                    {
                        p.Kill();

                        //p.CloseMainWindow();
                    }
                }                
            }
        }


    }
}
