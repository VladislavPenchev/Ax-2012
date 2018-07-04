namespace UserAccess.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSUSERINFO")]
    public partial class SYSUSERINFO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string ID { get; set; }

        public int DOCUHANDLINGACTIVE { get; set; }

        public int DOCUTOOLBARBUTTONACTIVE { get; set; }

        public int HELPMARKEMPTYLINKS { get; set; }

        [Required]
        [StringLength(60)]
        public string HELPTHEME { get; set; }

        [Required]
        [StringLength(80)]
        public string EMAIL { get; set; }

        public int COMPILERTARGET { get; set; }

        [Required]
        [StringLength(7)]
        public string LANGUAGE { get; set; }

        public Guid SQMUSERGUID { get; set; }

        public int SQMENABLED { get; set; }

        [Required]
        [StringLength(10)]
        public string DEFAULTCOUNTRYREGION { get; set; }

        public int EVENTPOLLFREQUENCY { get; set; }

        public int EVENTPOPUPLINKDESTINATION { get; set; }

        public int EVENTPOPUPDISPLAYWHEN { get; set; }

        public int EVENTEMAILALERTSWHEN { get; set; }

        public int EVENTPOPUPS { get; set; }

        public int EVENTWORKFLOWTASKSINEMAIL { get; set; }

        public int WORKFLOWLINEITEMNOTIFICATIONFORMAT { get; set; }

        public int EVENTWORKFLOWTASKSINCLIENT { get; set; }

        public int EVENTWORKFLOWSHOWPOPUP { get; set; }

        public int RECVERSION { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PARTITION { get; set; }

        public long RECID { get; set; }
    }
}
