using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebStore.Models.ViewModels
{
    public class Category
    {
        public int cat_id { get; set; }
        public string cat_name { get; set; }
        public Nullable<System.DateTime> cat_createdon { get; set; }
        public string cat_color { get; set; }
        public Nullable<int> cat_fk_admin_id { get; set; }
        public string cat_icon { get; set; }
    }
}