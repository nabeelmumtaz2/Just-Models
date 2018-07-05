//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Time_Group_Corporation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.Comments = new HashSet<Comments>();
        }
    
        public long TicketNumber { get; set; }
        public string EmployeeUsername { get; set; }
        public string Status { get; set; }
        public string FacilityUsed { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Path { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual LetterOfCredit LetterOfCredit { get; set; }
        public virtual Employee CreatedBy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
