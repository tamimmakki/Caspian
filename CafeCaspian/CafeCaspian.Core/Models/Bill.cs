using System.Collections.Generic;

namespace CafeCaspian.Models
{
    public class Bill
    {
        public List<MenuItem> Items { get; set; }
        public decimal ItemTotal { get; set; }
    }
}