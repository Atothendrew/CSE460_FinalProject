using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSE465_FinalProject.Models
{
    public class TenantUser
    {

        /*
         * Tenants should be able to add their users and should be able assign various roles/permissions to these users.
         * (For simplicity, at max 10 users can be added and there can be two types of users: manager and worker)
         */

        String Username { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        int EmployeeID { get; set; } // Should be Generated and Auto-Incremented from the DB

        public class Manager : TenantUser{} // Used to represent a Manager for comparison and permissions checking
        public class Worker : TenantUser{}
    }
}