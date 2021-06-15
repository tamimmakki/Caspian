using System.Collections.Generic;
using System.Text;
using CafeCaspian.Enums;
using CafeCaspian.Models;
using Xunit;

namespace CafeCaspian.Services
{
    public class BillServiceTests
    {
        [Fact]
        public void BillService_CalculateTotalItemPrice_ShouldReturn_Decimal_CorrectlyAddedPrices_WhenPassed_Bill()
        {
            // Arrange
            var customerBill = new Bill
            {
                ItemTotal = 0.00M,
                Items = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Name = "Cola",
                        Price = 0.50M,
                        Category = Category.Drink,
                        IsHot = false
                    },
                    new MenuItem
                    {
                        Name = "Coffee",
                        Price = 1.00M,
                        Category = Category.Drink,
                        IsHot = true
                    },
                    new MenuItem
                    {
                        Name = "Cheese Sandwich",
                        Price = 2.00M,
                        Category = Category.Food,
                        IsHot = false
                    },
                    new MenuItem
                    {
                        Name = "Steak Sandwich",
                        Price = 4.50M,
                        Category = Category.Food,
                        IsHot = true
                    }
                }
            };
            var billService = new BillService();

            const decimal expected = 8.0M;

            // Act
            var result = billService.CalculateTotalItemPrice(customerBill);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
