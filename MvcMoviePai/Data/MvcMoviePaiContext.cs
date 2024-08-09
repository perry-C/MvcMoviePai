using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMoviePai.Models;

namespace MvcMoviePai.Data
{
    public class MvcMoviePaiContext : DbContext
    {
        public MvcMoviePaiContext (DbContextOptions<MvcMoviePaiContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMoviePai.Models.Movie> Movie { get; set; } = default!;
    }
}
