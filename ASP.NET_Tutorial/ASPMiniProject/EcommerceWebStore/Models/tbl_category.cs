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
    
    public partial class tbl_category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_category()
        {
            this.tbl_product = new HashSet<tbl_product>();
        }
    
        public int cat_id { get; set; }
        public string cat_name { get; set; }
        public Nullable<System.DateTime> cat_createdon { get; set; }
        public string cat_color { get; set; }
        public Nullable<int> cat_fk_admin_id { get; set; }
        public string cat_icon { get; set; }
    
        public virtual tbl_admin tbl_admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_product> tbl_product { get; set; }
    }
}
