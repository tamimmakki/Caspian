using CafeCaspian.Models;

namespace CafeCaspian.Interfaces
{
    public interface IBillService
    {
        decimal CalculateTotalItemPrice(Bill customerBill);
    }
}
