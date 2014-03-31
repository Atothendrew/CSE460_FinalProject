using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSE465_FinalProject.Models;

namespace CSE465_FinalProject.Models
{
    public class Requirement
    {

        /*
         * Add requirement: Each project should have several requirements and each requirement can have several attributes such as:
         * requirement ID, description, type, time required in hours, assigned to, status and other relevant attributes.
         * This feature is also allowed only to the managers. The workers may change the requirement status.
         */

        int RequirementID { get; set; }
        String description { get; set; }
        int Type { get; set; }
        int TimeRequiredInHours { get; set; }
        TenantUser Assignee { get; set; }
        int Status { get; set; }
        Project CorrespondingProject { get; set; }


    }
}