using Microsoft.EntityFrameworkCore;
using Project.Models;
namespace Project.Models
{
    public class CompanyDBContext: DbContext
    {
        public DbSet<Dept> Depts { get; set; }

        public CompanyDBContext():base(){

        }

        public CompanyDBContext(DbContextOptions options):base(options){
            
        }
    }
}