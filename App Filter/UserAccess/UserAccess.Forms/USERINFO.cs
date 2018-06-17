namespace UserAccess.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERINFO")]
    public partial class USERINFO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string ID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        public int ENABLE { get; set; }

        [Required]
        [StringLength(40)]
        public string DEL_STARTUPMENU { get; set; }

        public int STATUSLINEINFO { get; set; }

        public int TOOLBARINFO { get; set; }

        public int DEBUGINFO { get; set; }

        public int AUTOINFO { get; set; }

        public int AUTOUPDATE { get; set; }

        public int GARBAGECOLLECTLIMIT { get; set; }

        public int HISTORYLIMIT { get; set; }

        public int MESSAGELIMIT { get; set; }

        public int GENERALINFO { get; set; }

        public int SHOWSTATUSLINE { get; set; }

        public int SHOWTOOLBAR { get; set; }

        public int DEBUGGERPOPUP { get; set; }

        public int SHOWAOTLAYER { get; set; }

        [Required]
        [StringLength(20)]
        public string DEL_PASSWORD { get; set; }

        [Required]
        [StringLength(41)]
        public string DEL_OSACCOUNTNAME { get; set; }

        [Required]
        [StringLength(40)]
        public string STARTUPPROJECT { get; set; }

        public int CONFIRMDELETE { get; set; }

        public int CONFIRMUPDATE { get; set; }

        [Required]
        [StringLength(31)]
        public string REPORTFONTNAME { get; set; }

        public int REPORTFONTSIZE { get; set; }

        [Required]
        [StringLength(31)]
        public string FORMFONTNAME { get; set; }

        public int FORMFONTSIZE { get; set; }

        [Required]
        [StringLength(31)]
        public string PROPERTYFONTNAME { get; set; }

        public int PROPERTYFONTSIZE { get; set; }

        public int INFOLOGLEVEL { get; set; }

        [Required]
        [StringLength(4)]
        public string COMPANY { get; set; }

        public int AUTOLOGOFF { get; set; }

        public int QUERYTIMELIMIT { get; set; }

        public int TRACEINFO { get; set; }

        [Required]
        [StringLength(11)]
        public string REPORTTOPMARGIN { get; set; }

        [Required]
        [StringLength(11)]
        public string REPORTBOTTOMMARGIN { get; set; }

        [Required]
        [StringLength(11)]
        public string REPORTLEFTMARGIN { get; set; }

        [Required]
        [StringLength(11)]
        public string REPORTRIGHTMARGIN { get; set; }

        public int COMPILERWARNINGLEVEL { get; set; }

        [Required]
        [StringLength(124)]
        public string SID { get; set; }

        [Required]
        [StringLength(255)]
        public string NETWORKDOMAIN { get; set; }

        [Required]
        [StringLength(80)]
        public string NETWORKALIAS { get; set; }

        public int ENABLEDONCE { get; set; }

        public int EXTERNALUSER { get; set; }

        [Required]
        [StringLength(7)]
        public string LANGUAGE { get; set; }

        [Required]
        [StringLength(7)]
        public string HELPLANGUAGE { get; set; }

        public int PREFERREDTIMEZONE { get; set; }

        public int PREFERREDCALENDAR { get; set; }

        public int HOMEPAGEREFRESHDURATION { get; set; }

        public int NOTIFYTIMEZONEMISMATCH { get; set; }

        public int FILTERBYGRIDONBYDEFAULT { get; set; }

        public int GLOBALFORMOPENMODE { get; set; }

        public int DEL_DEFAULTMODELID { get; set; }

        public int SHOWMODELNAMEINAOT { get; set; }

        public int ACCOUNTTYPE { get; set; }

        public long ISSUERRECID { get; set; }

        public long CREDENTIALRECID { get; set; }

        public int GLOBALLISTPAGELINKMODE { get; set; }

        public int GLOBALEXCELEXPORTMODE { get; set; }

        public int GLOBALEXCELEXPORTLOCATION { get; set; }

        public int CLIENTACCESSLOGLEVEL { get; set; }

        public int DEFAULTPARTITION { get; set; }

        [Required]
        [StringLength(259)]
        public string GLOBALEXCELEXPORTFILEPATH { get; set; }

        public int RECVERSION { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PARTITION { get; set; }

        public long RECID { get; set; }
    }
}
