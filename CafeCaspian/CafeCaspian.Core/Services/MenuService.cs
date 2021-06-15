using CafeCaspian.Enums;
using CafeCaspian.Models;
using System.Collections.Generic;

namespace CafeCaspian.Services
{
    public class MenuService
    {
        public IList<MenuItem> GetMenu()
        {
            return new List<MenuItem>
            {
                new MenuItem
                {
                    Id = 1,
                    Name = "Cola",
                    Price = 0.5M,
                    Category = Category.Drink,
                    IsHot = false

                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Coffee",
                    Price = 1.0M,
                    Category = Category.Drink,
                    IsHot = true
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Cheese Sandwich",
                    Price = 2.0M,
                    Category = Category.Food,
                    IsHot = false
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Steak Sandwich",
                    Price = 4.5M,
                    Category = Category.Food,
                    IsHot = true
                }
            };
        }
    }
}