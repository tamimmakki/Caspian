using CafeCaspian.Enums;

namespace CafeCaspian.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public bool IsHot { get; set; }
    }
}