using Microsoft.EntityFrameworkCore;
using MVCmovies.Models;

namespace MVCmovies.Data
{
    public class PgDbContext : DbContext
    {
        public PgDbContext(DbContextOptions<PgDbContext> options): base(options)
        {
            
        }
        public DbSet<Categery> Categeries {  get; set; }
    }
}


///<summary>
/// -----Command for db migration-----
/// update-database
/// add-migration <comment>
/// </summary>