using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.DB.Models;

namespace OnlineShop.DB.Interfaces
{
    public interface ICategoryStorage
    {
        List<Category> GetAll();
        Category? GetById(int id);
    }
}
