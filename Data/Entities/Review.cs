using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
   public class Review : BaseEntity
    {
        
        [Required(ErrorMessage = "Please enter Fullname")]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Please enter Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string PhotoUrl { get; set; }
        
    }
}
