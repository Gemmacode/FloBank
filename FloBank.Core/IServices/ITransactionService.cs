using Azure;
using FloBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloBank.Core.IServices
{
    public interface ITransactionService
    {
        Response CreateNewTransaction(Transaction transaction);
        Response FindTransactionByDate(DateTime date);
        Response MakeDeposit(string AccountNumber, decimal Amount, string TransactionPin);
        Response MakeWithrawal(string AccountNumber, decimal Amount, string TransactionPin);
        Response MakeFundsTransfer(string FromAccount, string ToAccount, decimal Amount, string TransactionPin);
       
    }
}
