using Microsoft.EntityFrameworkCore;
using DatabaseModels;



namespace DatabaseContext
{
    public class ApplicationContext: DbContext
    {
        private const string Host = "";
        private const string Port = "";
        private const string database = "";
        private const string Username = "";
        //private const string Password = "";

        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<Specializations> Specializations { get; set; }

        public DbSet<Certificates> Certificates { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql($"Host={Host};Port={Port};Database={database};Username={Username}");
        }
    }
}