namespace UserAccess.Data
{
    using System.Data.Entity;
    using UserAccess.Models;
    public class UserAccessDbContext : DbContext
    {
        public UserAccessDbContext()
            : base("AccessServer")
        {
        }

        public virtual IDbSet<UserAccessDbContent> UserAccess { get; set; }

        public virtual IDbSet<AdminModeDBContent> AdminModes { get; set; }

        public virtual IDbSet<SettingsDbContent> Settings { get; set; }
    }
}

