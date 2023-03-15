using Microsoft.EntityFrameworkCore;
using Web_App_Patient.Model;

namespace Web_App_Patient.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Patient> Patient { get; set; }
    }
}
