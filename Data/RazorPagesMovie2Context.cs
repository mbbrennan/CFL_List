using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _27nov2020.Models;
using RazorPagesMovie2.Models;

namespace RazorPagesMovie2.Data
{
    public class RazorPagesMovie2Context : DbContext
    {
        public RazorPagesMovie2Context (DbContextOptions<RazorPagesMovie2Context> options)
            : base(options)
        {
        }

        public DbSet<_27nov2020.Models.Team> Team { get; set; }

        public DbSet<RazorPagesMovie2.Models.Standing> Standing { get; set; }
    }
}
