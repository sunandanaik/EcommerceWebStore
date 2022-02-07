using EcommerceWebStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebStore.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        EcommerceEntities db = new EcommerceEntities();
        public void EditProduct(Product prod)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            tbl_product item = db.tbl_product.Where(x => x.prod_id == id).SingleOrDefault();
            Product p = new Product();
            p.prod_id = item.prod_id;
            p.prod_name = item.prod_name;
            p.prod_image1 = item.prod_image1;
            p.prod_image2 = item.prod_image2;
            p.prod_image3 = item.prod_image3;
            p.prod_desc = item.prod_desc;
            p.prod_price = item.prod_price;
            p.prod_fk_cat_id = item.prod_fk_cat_id;

            return p;
        }

        public void InsertProduct(Product prod)
        {
            throw new NotImplementedException();
        }

        public List<Product> ViewProduct()
        {
            List<Product> li = new List<Product>();
            List<tbl_product> catlist = db.tbl_product.ToList();
            foreach (var item in catlist)
            {
                Product p = new Product();
                p.prod_id = item.prod_id;
                p.prod_name = item.prod_name;
                p.prod_image1 = item.prod_image1;
                p.prod_image2 = item.prod_image2;
                p.prod_image3 = item.prod_image3;
                p.prod_desc = item.prod_desc;
                p.prod_price = item.prod_price;
                p.prod_fk_cat_id = item.prod_fk_cat_id;

                li.Add(p);
            }
            return li;
        }
    }
}