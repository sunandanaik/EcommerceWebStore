using EcommerceWebStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebStore.Models.Repository
{
    interface IProductRepository
    {
        void InsertProduct(Product prod);
        void EditProduct(Product prod);
        List<Product> ViewProduct();
        Product GetProduct(int id);
    }
}
