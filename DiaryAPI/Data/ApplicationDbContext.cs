using DiaryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
                
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }
    }
}
