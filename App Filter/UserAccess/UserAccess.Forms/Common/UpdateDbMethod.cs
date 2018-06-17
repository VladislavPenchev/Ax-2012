using System;
using UserAccess.Data;
using UserAccess.Models;
namespace UserAccess.Forms.Common
{ 
    public class UpdateDbMethod
    {
        public static void UpdateLogOutTime(UserAccessDbContent dataFromUserAccessQueryRECID, SYSUSERLOG dataFromUSERLOGQueryLOGOUT)
        {
            var _time = new UserAccessDbContent() { Id = dataFromUserAccessQueryRECID.Id, LogOut = dataFromUSERLOGQueryLOGOUT.LOGOUTDATETIME };

            using (var newContext = new UserAccessDbContext())
            {
                newContext.UserAccess.Attach(_time);
                newContext.Entry(_time).Property(x => x.LogOut).IsModified = true;
                newContext.SaveChanges();
            }
        }
    }
}
