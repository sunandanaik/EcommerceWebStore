using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebStore.Models.ViewModels
{
    public class Product
    {
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public string prod_image1 { get; set; }
        public string prod_image2 { get; set; }
        public string prod_image3 { get; set; }
        public string prod_desc { get; set; }
        public Nullable<double> prod_price { get; set; }
        public Nullable<int> prod_fk_cat_id { get; set; }

    }
}