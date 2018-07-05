using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Time_Group_Corporation.Models
{
    [MetadataType(typeof(notifyMetaData))]
    public partial class Notification
    {
    }
    public class notifyMetaData
    {
        public int NotificationId { get; set; }
        public string EmployeeUsername { get; set; }
        [Required,MaxLength(50)]
        [Display(Name ="Content can have maximum 50 letters including spaces and this")]
        public string Content { get; set; }
        public bool Seen { get; set; }

        public virtual Employee Employee { get; set; }
    }
}