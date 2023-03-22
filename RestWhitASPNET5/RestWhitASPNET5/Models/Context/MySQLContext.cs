using Microsoft.EntityFrameworkCore;

namespace RestWhitASPNET5.Models.Context
{
    public class MySQLContext : DbContext
    {
        protected MySQLContext() { }
        public MySQLContext( DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
    }
}
