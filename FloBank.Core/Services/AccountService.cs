using FloBank.Core.IServices;
using FloBank.Data;
using FloBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FloBank.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly FloBankDbContext _db;

        public AccountService(FloBankDbContext db)
        {
            _db = db;
        }

        public Account Authenticate(string AccountNumber, string Pin)
        {
            var account = _db.Accounts.Where(x => x.AccountNumberGenerated == AccountNumber).SingleOrDefault(); 
            if (account == null)
            
                return null;
                if (!VerifyPinHash( Pin, account.PinHash, account.PinSalt))
                    return null;    
                return account;

            
        }

        private static bool VerifyPinHash(string Pin, byte[] pinHash, byte[] pinSalt)
        {
            if (string.IsNullOrWhiteSpace(Pin)) throw new ArgumentNullException("Pin");
            using (var hmac = new System.Security.Cryptography.HMACSHA512(pinSalt))
            {
                var computedPinHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Pin));
                for (int i = 0; i<computedPinHash.Length; i++)
                {
                    if (computedPinHash[i] != pinHash[i])
                        return false;
                }
            }
            return true;
        }

        public Account Create(Account account, string Pin, string ConfirmPin)
        {
            if (_db.Accounts.Any(x => x.Email == account.Email)) throw new ApplicationException("Account already exist with this Email");
            if (!Pin.Equals(ConfirmPin)) throw new ArgumentException("Pins does not match", "Pin");
            byte[] pinHash, pinSalt;
            CreatePinHash(Pin, out pinHash, out pinSalt);   
            account.PinHash = pinHash;  
            account.PinSalt = pinSalt;
            
            _db.Accounts.Add(account);
            _db.SaveChanges();
            return account;
        }

        private static void CreatePinHash( string pin, out byte[] pinHash, out byte[] pinSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) 
            {
                pinSalt = hmac.Key;
                pinHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(pin));
            }
        }

        public void Delete(int Id)
        {
            var account = _db.Accounts.Find(Id);
            if (account != null)
            {
                _db.Accounts.Remove(account);
                _db.SaveChanges();
            }
        }

        public IEnumerable<Account> GetAllAccounts()
        {
           return _db.Accounts.ToList();    
        }

        public Account GetByAccountNumber(string AccountNumber)
        {
            var account = _db.Accounts.Where(x => x.AccountNumberGenerated == AccountNumber).FirstOrDefault();  
            if (account == null) 
            {
                return null;
            }
            return account;
        }

        public Account GetById(int Id)
        {
            var account = _db.Accounts.Where(x=>x.id== Id).FirstOrDefault();    
            if (account == null)
            {
                return null
            }
            return account;
        }

        public void Update(Account account, string Pin = null)
        {
            throw new NotImplementedException();
        }
    }
}
