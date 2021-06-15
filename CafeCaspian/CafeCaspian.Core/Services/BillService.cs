using System;
using System.Linq;
using CafeCaspian.Interfaces;
using CafeCaspian.Models;

namespace CafeCaspian.Services
{
    public class BillService : IBillService
    {
        public decimal CalculateTotalItemPrice(Bill customerBill)
        {
            return Math.Round(customerBill.Items.Select(x => x.Price).Sum());
        }

        public decimal CalculateTip(Bill customerBill, decimal tipPercent)
        {
            if (customerBill.ItemTotal > 0 && tipPercent >= 0)
                return Math.Round(customerBill.ItemTotal * (tipPercent / 100), 2);
            return 0;
        }
    }
}