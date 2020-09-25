using System;
using System.Collections.Generic;
using System.Text;

namespace METWebShop.BLL.Interfaces
{
    public interface IUserManager
    {
        int GetBalanceOfUser(string userId);
        void AddBalanceToUser(string userId, int balance);
    }
}
