using CafeCaspian.Enums;
using CafeCaspian.Models;
using System.Collections.Generic;
using Xunit;

namespace CafeCaspian.Services
{
    public class BillServiceTests
    {
        private readonly BillService _billService;
        public BillServiceTests()
        {
            _billService = new BillService();
        }

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
            
            const decimal expected = 8.0M;

            // Act
            var result = _billService.CalculateTotalItemPrice(customerBill);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BillService_CalculateTotalItemPrice_ShouldReturn_Decimal_Zero_WhenPassed_Bill_DoNotHaveAnyItems()
        {
            // Arrange
            var customerBill = new Bill
            {
                ItemTotal = 0.00M,
                Items = new List<MenuItem>()
            };
            
            const decimal expected = 0.00M;

            // Act
            var result = _billService.CalculateTotalItemPrice(customerBill);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BillService_CalculateTip_ShouldReturn_Decimal_With_CorrectTip_ByPercentPassedIn()
        {
            // Arrange
            var customerBill = new Bill
            {
                ItemTotal = 8.00M,
                Items = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Name = "Cola",
                        Price = 0.50M,
                    },
                    new MenuItem
                    {
                        Name = "Coffee",
                        Price = 1.00M
                    },
                    new MenuItem
                    {
                        Name = "Cheese Sandwich",
                        Price = 2.00M
                    },
                    new MenuItem
                    {
                        Name = "Steak Sandwich",
                        Price = 4.50M
                    }
                }
            };

            const decimal expected = 0.80M;
            const int tipPercent = 10;

            // Act
            var result = _billService.CalculateTip(customerBill, tipPercent);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BillService_CalculateTip_ShouldReturn_TwoPointDecimal_With_CorrectTip_ByPercentPassedIn()
        {
            // Arrange
            var customerBill = new Bill
            {
                ItemTotal = 6.00M,
                Items = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Name = "Cola",
                        Price = 0.50M,
                    },
                    new MenuItem
                    {
                        Name = "Coffee",
                        Price = 1.00M
                    },
                    new MenuItem
                    {
                        Name = "Steak Sandwich",
                        Price = 4.50M
                    }
                }
            };

            const decimal expected = 0.60M;
            const int tipPercent = 10;

            // Act
            var result = _billService.CalculateTip(customerBill, tipPercent);

            // Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void BillService_CalculateTip_ShouldReturn_ZeroDecimal_WhenNoItemInBill_ByPercentPassedIn()
        {
            // Arrange
            var customerBill = new Bill
            {
                ItemTotal = 0.00M,
                Items = new List<MenuItem>()
            };

            const decimal expected = 0.00M;
            const int tipPercent = 10;

            // Act
            var result = _billService.CalculateTip(customerBill, tipPercent);

            // Assert
            Assert.Equal(expected, result, 2);
        }
    }
}
