using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyMvc.Models
{
   public class StudentModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Location")]
        public int? AddressId { get; set; }

        [Required]
        public int RollNo { get; set; }
        public AddressModel Address { get; set; }
    }
}
