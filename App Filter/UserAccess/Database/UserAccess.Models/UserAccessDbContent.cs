namespace UserAccess.Models
{
    using System;

    public class UserAccessDbContent
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public DateTime? LogOn { get; set; }

        public DateTime? LogOut { get; set; }

        public string Description { get; set; }

        public long RECID { get; set; }

    }
}
