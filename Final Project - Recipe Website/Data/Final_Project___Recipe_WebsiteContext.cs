using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_Project___Recipe_Website.Models;

namespace Final_Project___Recipe_Website.Data
{
    public class Final_Project___Recipe_WebsiteContext : DbContext
    {
        public Final_Project___Recipe_WebsiteContext (DbContextOptions<Final_Project___Recipe_WebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Project___Recipe_Website.Models.Recipe> Recipe { get; set; } = default!;
    }
}
