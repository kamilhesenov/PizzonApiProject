using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Setting : BaseEntity
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BookInfo { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string WeekPeriod { get; set; }
    }
}
