using Microsoft.EntityFrameworkCore;


namespace PhoneBook_entity
{

    public class MyApplicationContext : DbContext
    {
        public DbSet <Abonent> Abonents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-N6GODSK;Database=PhoneBase;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}


