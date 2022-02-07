using EcommerceWebStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EcommerceWebStore.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        EcommerceEntities db = new EcommerceEntities();
        public void EditCategory(Category cat)
        {
            tbl_category table_cat = db.tbl_category.Where(x => x.cat_id == cat.cat_id).SingleOrDefault();
            table_cat.cat_id = cat.cat_id;
            table_cat.cat_name = cat.cat_name;
            table_cat.cat_icon = cat.cat_icon;
            table_cat.cat_createdon = DateTime.Now;
            table_cat.cat_fk_admin_id = cat.cat_fk_admin_id;
            
            db.Entry(table_cat).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Category GetCategory(int id)
        {
            tbl_category item= db.tbl_category.Where(x => x.cat_id == id).SingleOrDefault();
            Category c = new Category();
            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_icon = item.cat_icon;
            c.cat_createdon = item.cat_createdon;
            c.cat_fk_admin_id = item.cat_fk_admin_id;
            return c;
        }

        public void InsertCategory(Category cat)
        {
            tbl_category table_cat = new tbl_category();
            table_cat.cat_id = cat.cat_id;
            table_cat.cat_name = cat.cat_name;
            table_cat.cat_icon = cat.cat_icon;
            table_cat.cat_createdon = DateTime.Now;
            table_cat.cat_fk_admin_id = cat.cat_fk_admin_id;
            db.tbl_category.Add(table_cat);
            db.SaveChanges();
        }

        public List<Category> ViewCategory()
        {
            List<Category> li = new List<Category>();
            List<tbl_category> catlist = db.tbl_category.ToList();
            foreach(var item in catlist)
            {
                Category c = new Category();
                c.cat_id = item.cat_id;
                c.cat_name = item.cat_name;
                c.cat_icon = item.cat_icon;
                c.cat_createdon = item.cat_createdon;
                c.cat_fk_admin_id = item.cat_fk_admin_id;

                li.Add(c);
            }
            return li;
        }
    }
}