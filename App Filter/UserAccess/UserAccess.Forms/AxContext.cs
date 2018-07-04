namespace UserAccess.Forms
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Linq;

    public partial class AxContext : DbContext
    {
        public AxContext()
            : base("name=AxContext")
        {
        }

        public virtual DbSet<SYSUSERINFO> SYSUSERINFOes { get; set; }
        public virtual DbSet<SYSUSERLOG> SYSUSERLOGs { get; set; }
        public virtual DbSet<USERINFO> USERINFOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
