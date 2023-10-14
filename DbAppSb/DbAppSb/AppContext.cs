using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DbAppSb
{
    internal class AppContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Shift> Shifts { get; set; }

        public AppContext() : base("DefaultConnection")
        {

        }
    }
}
