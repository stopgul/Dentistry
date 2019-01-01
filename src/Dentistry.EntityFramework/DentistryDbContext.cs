using Dentistry.Core.Dentist;
using Dentistry.Core.Patient;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dentistry.EntityFramework
{
    public class DentistryDbContext : IdentityDbContext//<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>// DbContext
    {
        public DentistryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
 