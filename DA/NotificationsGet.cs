using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Time_Group_Corporation.Models.DA
{
    public class NotificationsGet
    {
        private LcManagementSystemEntities db = new LcManagementSystemEntities();
        public NotificationsGet() { }
        public IEnumerable getNotifications()
        {
            return db.Employees.Find(HttpContext.Current.Session["name"].ToString()).Notifications.Reverse().ToList();
        }
    }
}