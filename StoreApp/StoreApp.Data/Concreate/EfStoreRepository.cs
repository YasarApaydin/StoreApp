using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Concreate
{
    public class EfStoreRepository : IStoreRepository
    {

        private StoreDbContext context;
        public EfStoreRepository(StoreDbContext _context)
        {
            context = _context;
            
        }
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Category> Categories => context.Categories;
        public void CreateProduct(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductByCategory(string category, int sayfa, int sayfaSayisi)
        {
            var products = Products;

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Include(p => p.Categories).Where(p => p.Categories.Any(a => a.Url == category));
            }
            return products.Skip((sayfa - 1) * sayfaSayisi).Take(sayfaSayisi);


   
         
        }

        public int GetProductCount(string category)
        {
            return category == null
                    ?
                    Products.Count()
                    :
                    Products.Include(p => p.Categories).Where(p => p.Categories.Any(a => a.Url == category)).Count();
        }
    }
}
