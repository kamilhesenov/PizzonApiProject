using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities.Home
{
   public class Associate : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string PhotoUrl { get; set; }
    }
}
