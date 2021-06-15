using CafeCaspian.Models;

namespace CafeCaspian.Interfaces
{
    public interface IBillService
    {
        decimal CalculateTotalItemPrice(Bill customerBill);
        decimal CalculateTip(Bill customerBill, decimal tipPercentage);
        Bill CalculateTotalBill(Bill customerBill, decimal tipPercentage = 0);
    }
}
