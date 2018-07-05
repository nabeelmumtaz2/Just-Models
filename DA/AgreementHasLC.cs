using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Group_Corporation.Models;

namespace Time_Group_Corporation.Models.DA
{
    public class AgreementHasLC
    {
        public Agreement agreement { get; set; }
        public List<MainTicket> tickets { get; set; }
        public AgreementHasLC()
        {
            tickets = new List<MainTicket>();
        }
    }
}