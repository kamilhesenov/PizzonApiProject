using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
   public class Comment : BaseEntity
    {
        
        [Required(ErrorMessage = "Please enter Fullname")]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Please enter Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string PhotoUrl { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
