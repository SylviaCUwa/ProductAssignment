using Microsoft.EntityFrameworkCore;
using ProductAssignment.Models;



namespace ProductAssignment.Data.Repositories
{

    public class Repository : IRepository
    {
        private readonly TodoContext _context;

        public Repository(TodoContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

    }
}
