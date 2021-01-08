using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Product : BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string[] PhotosUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        
        public string[] Size { get; set; }
        public string[] ProductType { get; set; }
        public int StockId { get; set; }
        public Stock Stock { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsPromo { get; set; }
        public int OrderBy { get; set; }
    }
}
