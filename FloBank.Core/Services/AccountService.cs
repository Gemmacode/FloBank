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
    public class AccountService : IAccountService
    {
        private readonly FloBankDbContext dbContext;
        public Account Authenticate(string AccountName, string Pin)
        {
            throw new NotImplementedException();
        }

        public Account Create(Account account, string Pin, string ConfirmPin)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public Account GetByAccountNumber(string AccountNumber)
        {
            throw new NotImplementedException();
        }

        public Account GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Account account, string Pin = null)
        {
            throw new NotImplementedException();
        }
    }
}
