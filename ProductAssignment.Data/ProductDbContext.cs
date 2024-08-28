using Microsoft.EntityFrameworkCore;
using ProductAssignment.Models;

namespace ProductAssignment.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
