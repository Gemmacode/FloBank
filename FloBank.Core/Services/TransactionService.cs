using FloBank.Core.IServices;
using FloBank.Data;
using FloBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloBank.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly FloBankDbContext _dbContext;

        public TransactionService(FloBankDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Response CreateNewTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Response FindTransactionByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Response MakeDeposit(string AccountNumber, decimal Amount, string TransactionPin)
        {
            throw new NotImplementedException();
        }

        public Response MakeFundsTransfer(string FromAccount, string ToAccount, decimal Amount, string TransactionPin)
        {
            throw new NotImplementedException();
        }

        public Response MakeWithrawal(string AccountNumber, decimal Amount, string TransactionPin)
        {
            throw new NotImplementedException();
        }
    }
}
