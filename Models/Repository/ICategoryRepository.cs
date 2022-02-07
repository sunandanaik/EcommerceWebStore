using EcommerceWebStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebStore.Models.Repository
{
    interface ICategoryRepository
    {
        void InsertCategory(Category cat);
        void EditCategory(Category cat);
        List<Category> ViewCategory();
        Category GetCategory(int id);
    }
}
