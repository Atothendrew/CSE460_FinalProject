using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSE465_FinalProject.Models;

namespace CSE465_FinalProject.Models
{
    public class Project
    {

        /*
         * Add project: The managers should be able to enter project details such as:
         * Project Name, Project Id, start date, expected end date, status, assigned manager, employees associated and other such details.
         * The manager who has added the project becomes responsible for the project.
         * This manager also becomes the manager for the employees who are working under this project (added by the manager).
         * For simplicity, the only editable or dynamic field should be status; rest of the information will not be modifiable after the project has been added.
         */

        enum ProjectStatusList
        {
            Queued, InProgress, Completed
        };

        String ProjectName { get; }
        int ProjectID { get; }
        DateTime StartDate { get; }
        DateTime ExpectedEndDate { get; }
        int Status { set; }
        TenantUser.Manager manager { get; }
        TenantUser.Worker[] workers { get; }

        public Project(String ProjectName, int ProjectID, DateTime StartDate, DateTime ExpectedEndDate, int Status, TenantUser.Manager manager, TenantUser.Worker[] workers)
        {
            // TODO
        }


    }
}