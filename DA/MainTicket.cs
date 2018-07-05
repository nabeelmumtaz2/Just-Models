using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Group_Corporation.Models;

namespace Time_Group_Corporation.Models.DA
{
    public class MainTicket
    {
        public Ticket ticket { get; set; }
        public LetterOfCredit lc { get; set; }
        public Agreement agreement { get; set; }
    }
}