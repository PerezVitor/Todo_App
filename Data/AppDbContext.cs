using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoModel> Todos { get; set; }
        const string CONNECTION_STRING = "DataSource=app.db;Cache=Shared";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(CONNECTION_STRING);
    }   
}