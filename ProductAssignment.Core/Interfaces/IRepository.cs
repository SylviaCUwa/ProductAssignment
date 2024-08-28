using ProductAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAssignment.Data
{
    public interface IRepository

    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
