//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceWebStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_product()
        {
            this.tbl_productsOrdered = new HashSet<tbl_productsOrdered>();
        }
    
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public string prod_image1 { get; set; }
        public string prod_image2 { get; set; }
        public string prod_image3 { get; set; }
        public string prod_desc { get; set; }
        public Nullable<double> prod_price { get; set; }
        public Nullable<int> prod_fk_cat_id { get; set; }
    
        public virtual tbl_category tbl_category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_productsOrdered> tbl_productsOrdered { get; set; }
    }
}