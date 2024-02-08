using FloBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloBank.Core.IServices
{
    public interface IAccountService
    {
        Account Authenticate(string AccountName, string Pin);
        IEnumerable<Account> GetAllAccounts();
        Account Create(Account account, string Pin, string ConfirmPin);
        void Update(Account account, string Pin = null);
        void Delete(int Id); 
        Account GetById(int Id);
        Account GetByAccountNumber(string AccountNumber);
    }
}
