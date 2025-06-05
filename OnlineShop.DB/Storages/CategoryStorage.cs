using System.Collections.Generic;
using System.Linq;
using OnlineShop.DB;
using OnlineShop.DB.Interfaces;
using OnlineShop.DB.Models;

namespace OnlineShopWebApp.Connected_Services
{
    public class CategoryStorage : ICategoryStorage
    {
        private readonly DatabaseContext _context;

        public CategoryStorage(DatabaseContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
