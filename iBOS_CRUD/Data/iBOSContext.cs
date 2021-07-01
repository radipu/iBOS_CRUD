using iBOS_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBOS_CRUD.Data
{
    public class iBOSContext : DbContext
    {
        public iBOSContext(DbContextOptions<iBOSContext> options) : base (options)
        {

        }

        public DbSet<iBOS> tblColdDrinks { get; set; }
    }
}
