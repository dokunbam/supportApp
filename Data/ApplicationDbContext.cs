using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FCMB_Support_App.Models;

namespace FCMB_Support_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FCMB_Support_App.Models.Client> Clients { get; set; }
        public DbSet<Issue> Issues{ get; set; }

    }
}
