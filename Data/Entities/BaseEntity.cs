using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public abstract class  BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
}
