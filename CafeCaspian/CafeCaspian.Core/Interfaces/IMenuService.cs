using CafeCaspian.Models;
using System.Collections.Generic;

namespace CafeCaspian.Interfaces
{
    public interface IMenuService
    {
        IList<MenuItem> GetMenu();
    }
}
