using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.DAL.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DataContext _context;

        public TransactionRepository(DataContext context)
        {
            _context = context;
        }

        public Transaction GetTransactionById(int id)
        {
            return _context.Transactions.SingleOrDefault(x => x.Id == id);
        }

        public Transaction PlaceTransaction(Transaction newTransaction)
        {
            _context.Transactions.Add(newTransaction);
            return newTransaction;
        }

        public Transaction Delete(int id)
        {
            var transactionToDelete = GetTransactionById(id);
            if (transactionToDelete != null)
            {
                _context.Transactions.Remove(transactionToDelete);
            }
            return transactionToDelete;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
