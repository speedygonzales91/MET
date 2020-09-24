using System;
using System.Collections.Generic;
using System.Text;
using METWebShop.Core.Data;

namespace METWebShop.DAL.Interfaces.Repository
{
    public interface ITransactionRepository
    {
        Transaction GetTransactionById(int id);
        Transaction PlaceTransaction(Transaction newOrder);
        Transaction Delete(int id);

        int Commit();
    }
}
