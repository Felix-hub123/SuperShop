using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }

       public IQueryable GetAllWithUsers()
        {
            return _context.Products
                .Include(p => p.User);
                
        }
        public async Task<Product> GetProductWithUser(int id)
        {
            return await _context.Products
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
    
}
