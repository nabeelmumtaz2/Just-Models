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
    
    public partial class Comments
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public long TicketTicketNumber { get; set; }
        public string Commentby { get; set; }
        public System.DateTime CommentedOn { get; set; }
    
        public virtual Ticket Ticket { get; set; }
    }
}
