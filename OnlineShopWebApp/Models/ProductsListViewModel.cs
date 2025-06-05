using OnlineShop.DB.Models;
using System.Collections.Generic;

namespace OnlineShopWebApp.Models
{
    public class GoodsListViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public int? SelectedCategoryId { get; set; }
    }

}
