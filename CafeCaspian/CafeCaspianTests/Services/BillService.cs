using System;
using System.Linq;

namespace CafeCaspian.Services
{
    public class BillService
    {
        public decimal CalculateTotalItemPrice(Bill customerBill)
        {
            return Math.Round(customerBill.Items.Select(x => x.Price).Sum());
        }
    }
}