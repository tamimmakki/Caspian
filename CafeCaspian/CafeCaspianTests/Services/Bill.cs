using System.Collections.Generic;
using CafeCaspian.Models;

namespace CafeCaspian.Services
{
    public class Bill
    {
        public List<MenuItem> Items { get; set; }
        public decimal ItemTotal { get; set; }
    }
}