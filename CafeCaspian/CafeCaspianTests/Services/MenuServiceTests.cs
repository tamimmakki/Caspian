using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CafeCaspian.Services
{
    public class MenuServiceTests
    {
        [Fact]
        public void MenuService_GetMenu_ShouldReturn_List_of_MenuItems()
        {
            // Arrange
            var expected = new List<MenuItem>
            {
                new MenuItem
                {
                    Id = 1,
                    Name = "Cola",
                    Price = 0.50M,
                    Category = Category.Drink,
                    IsHot = false
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Coffee",
                    Price = 1.00M,
                    Category = Category.Drink,
                    IsHot = true
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Cheese Sandwich",
                    Price = 2.00M,
                    Category = Category.Food,
                    IsHot = false
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Steak Sandwich",
                    Price = 4.50M,
                    Category = Category.Food,
                    IsHot = true
                }
            };

            var menuService = new MenuService();

            //Act
            var result = menuService.GetMenu();

            //Assert
            Assert.Equal(expected.Count, result.Count);
            Assert.Equal(expected[0].Id, result[0].Id);
            Assert.Equal(expected[0].Name, result[0].Name);
            Assert.Equal(expected[0].Price, result[0].Price);
            Assert.Equal(expected[0].Category, result[0].Category);
            Assert.Equal(expected[0].IsHot, result[0].IsHot);
            Assert.Equal(expected[3].Name, result[3].Name);
            Assert.Equal(expected[3].Price, result[3].Price);
        }
    }
}
