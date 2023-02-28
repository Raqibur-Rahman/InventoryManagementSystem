using CRUD_WEB_API_DEMO.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WEB_API_DEMO.Data
{
    public class RegistrationModelAPIDbContext : DbContext
    {
        public RegistrationModelAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RegistrationModel> Registration { get; set; }
    }

}
