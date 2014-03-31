using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSE465_FinalProject.Models;

namespace CSE465_FinalProject.Models
{
    public class Tenant
    {
        String Username { get; set; }
   //     String Password { get; set; } Might not want to keep this in memory, here for reference though
        TenantUser[] Users {get; set;}
    }
}