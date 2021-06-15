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
    }
}