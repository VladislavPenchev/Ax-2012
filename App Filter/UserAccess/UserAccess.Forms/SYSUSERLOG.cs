namespace UserAccess.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSUSERLOG")]
    public partial class SYSUSERLOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string USERID { get; set; }

        public int TYPE { get; set; }

        [Required]
        [StringLength(30)]
        public string COMPUTERNAME { get; set; }

        public int CLIENTTYPE { get; set; }

        [Required]
        [StringLength(10)]
        public string BUILDNUM { get; set; }

        public int SESSIONID { get; set; }

        public int TERMINATEDOK { get; set; }

        public DateTime LOGOUTDATETIME { get; set; }

        public int LOGOUTDATETIMETZID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CREATEDDATETIME { get; set; }

        public int RECVERSION { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PARTITION { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RECID { get; set; }
    }
}
