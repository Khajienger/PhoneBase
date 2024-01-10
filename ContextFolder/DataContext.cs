using Microsoft.EntityFrameworkCore;
using PhoneBase.Models;

namespace PhoneBase.ContextFolder
{
    public class DataContext : DbContext
    {
        public DbSet<PhoneRecord> PhoneRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; DataBase=PhoneBase; Trusted_Connection=True");
        }
    }
}